using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using System.Threading;
using BlackJack.LibClient.Protocol;
using UnityEngine;

namespace BlackJack.LibClient
{
	// Token: 0x02000863 RID: 2147
	[Synchronization]
	public class Connection
	{
		// Token: 0x06006AEF RID: 27375 RVA: 0x001DFCC0 File Offset: 0x001DDEC0
		public Connection(IProtoProvider provider, Func<Stream, Type, int, object> deserializeMessageAction = null)
		{
			this.State = ConnectionState.None;
			this.m_provider = provider;
			this.m_messageDeserializeAction = deserializeMessageAction;
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x001DFD1C File Offset: 0x001DDF1C
		public bool Initialize(string remoteAddress, int remotePort)
		{
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				string empty = string.Empty;
				AddressFamily addressFamily = AddressFamily.InterNetwork;
				this.GetIpType(remoteAddress, remotePort.ToString(), out empty, out addressFamily);
				if (!string.IsNullOrEmpty(empty))
				{
					remoteAddress = empty;
				}
			}
			IPAddress address;
			if (IPAddress.TryParse(remoteAddress, out address))
			{
				this.m_ipEndPoint = new IPEndPoint(address, remotePort);
				if (this.State != ConnectionState.None)
				{
					this.Close();
				}
				this.m_recvQueue.Clear();
				this.StartConnection();
				return true;
			}
			return false;
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x001DFDA8 File Offset: 0x001DDFA8
		private void StartConnection()
		{
			this.State = ConnectionState.Connecting;
			this.m_socket = new Socket(this.m_ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			this.m_connEventArg = new SocketAsyncEventArgs();
			this.m_connEventArg.Completed += this.OnCompletedForConnect;
			this.m_connEventArg.RemoteEndPoint = this.m_ipEndPoint;
			if (!this.m_socket.ConnectAsync(this.m_connEventArg))
			{
				this.OnCompletedForConnect(null, this.m_connEventArg);
			}
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x001DFE2C File Offset: 0x001DE02C
		public void Disconnect()
		{
			if (this.State != ConnectionState.Established)
			{
				return;
			}
			Socket oldSocket = this.m_socket;
			if (this.m_disconnectTimer == null)
			{
				this.m_disconnectTimer = new Timer(delegate(object o)
				{
					if (oldSocket == this.m_socket && !this.m_socket.Connected && this.State == ConnectionState.Disconnecting)
					{
						this.FireEventOnLogPrint("Disconnect.Timerstate=" + this.State, string.Empty);
						this.State = ConnectionState.Closed;
						CCMSGConnectionBreak msg = new CCMSGConnectionBreak();
						this.WriteMsg2RecvCache(msg);
					}
				}, null, 500, 1000);
				try
				{
					this.m_socket.Shutdown(SocketShutdown.Both);
				}
				catch (Exception arg)
				{
					string str = string.Format("{0}", arg);
					global::Debug.WriteLine(str);
				}
			}
			this.State = ConnectionState.Disconnecting;
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x001DFECC File Offset: 0x001DE0CC
		public void Close()
		{
			try
			{
				if (this.m_socket != null)
				{
					this.m_socket.Close();
				}
				if (this.m_connEventArg != null)
				{
					this.m_connEventArg.Dispose();
					this.m_connEventArg = null;
				}
				if (this.m_receiveEventArg != null)
				{
					this.m_receiveEventArg.Dispose();
					this.m_receiveEventArg = null;
				}
				if (this.m_disconnectTimer != null)
				{
					this.m_disconnectTimer.Dispose();
					this.m_disconnectTimer = null;
				}
			}
			catch (Exception ex)
			{
				string str = string.Format("{0}:{1}", ex.GetType(), ex.Message);
				global::Debug.WriteLine(str);
			}
			this.State = ConnectionState.None;
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x001DFF88 File Offset: 0x001DE188
		public KeyValuePair<int, object> GetMessagePair()
		{
			this.TryDecodeMsg();
			KeyValuePair<int, object> result = new KeyValuePair<int, object>(0, null);
			object recvQueue = this.m_recvQueue;
			lock (recvQueue)
			{
				if (this.m_recvQueue.Count > 0)
				{
					result = this.m_recvQueue.Dequeue();
				}
			}
			return result;
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x001DFFEC File Offset: 0x001DE1EC
		public void SendMessage(object msg)
		{
			if (this.State != ConnectionState.Established)
			{
				global::Debug.WriteLine(string.Format("SendMessage Error:in State {0}", this.State));
				return;
			}
			if (msg == null)
			{
				global::Debug.WriteLine("SendMessage Error:msg is null");
				return;
			}
			ArraySegment<byte> arraySegment = ProtoHelper.EncodeMessage(msg, this.m_provider);
			SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs();
			socketAsyncEventArgs.Completed += this.OnCompletedForSend;
			socketAsyncEventArgs.SetBuffer(arraySegment.Array, arraySegment.Offset, arraySegment.Count);
			global::Debug.WriteLine(string.Format("SendMessage Send {0}", msg.GetType().Name));
			if (!this.m_socket.SendAsync(socketAsyncEventArgs))
			{
				this.OnCompletedForSendImpl(socketAsyncEventArgs);
				socketAsyncEventArgs.Dispose();
			}
		}

		// Token: 0x06006AF6 RID: 27382 RVA: 0x001E00AC File Offset: 0x001DE2AC
		private void OnCompletedForSend(object sender, SocketAsyncEventArgs e)
		{
			this.OnCompletedForSendImpl(e);
			e.Dispose();
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x001E00BC File Offset: 0x001DE2BC
		private void OnCompletedForSendImpl(SocketAsyncEventArgs e)
		{
			try
			{
				if (e.SocketError == SocketError.Success)
				{
					return;
				}
				throw new Exception("The result of SendAsync is not correct");
			}
			catch (Exception ex)
			{
				CCMSGConnectionSendFailure msg = new CCMSGConnectionSendFailure
				{
					ExceptionInfo = ex.ToString()
				};
				this.WriteMsg2RecvCache(msg);
			}
			if (this.State == ConnectionState.Established)
			{
				this.State = ConnectionState.Closed;
				CCMSGConnectionBreak msg2 = new CCMSGConnectionBreak();
				this.WriteMsg2RecvCache(msg2);
				this.FireEventOnLogPrint("OnCompletedForSendImpl", string.Empty);
			}
		}

		// Token: 0x06006AF8 RID: 27384 RVA: 0x001E0148 File Offset: 0x001DE348
		private void OnCompletedForConnect(object sender, SocketAsyncEventArgs eventArgs)
		{
			try
			{
				if (eventArgs.SocketError != SocketError.Success)
				{
					CCMSGConnectionFailure msg = new CCMSGConnectionFailure();
					this.WriteMsg2RecvCache(msg);
					this.State = ConnectionState.Closed;
				}
				else
				{
					this.State = ConnectionState.Established;
					CCMSGConnectionReady msg2 = new CCMSGConnectionReady();
					this.WriteMsg2RecvCache(msg2);
					this.m_receiveEventArg = new SocketAsyncEventArgs();
					this.m_receiveEventArg.Completed += this.OnCompletedForReceive;
					this.m_receiveEventArg.SetBuffer(new byte[65536], 0, 65536);
					if (!this.m_socket.ReceiveAsync(this.m_receiveEventArg))
					{
						this.OnCompletedForReceive(null, this.m_receiveEventArg);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06006AF9 RID: 27385 RVA: 0x001E0208 File Offset: 0x001DE408
		private void OnCompletedForReceive(object sender, SocketAsyncEventArgs eventArgs)
		{
			try
			{
				if (eventArgs.SocketError != SocketError.Success)
				{
					throw new Exception(string.Format("The result of ReceiveAsync is not correct, SocketError={0}", eventArgs.SocketError));
				}
				if (eventArgs.BytesTransferred != 0)
				{
					object recvCache = this.m_recvCache;
					lock (recvCache)
					{
						this.m_recvCache.Write(eventArgs.Buffer, eventArgs.BytesTransferred);
					}
					if (this.m_receiveEventArg != null)
					{
						this.m_receiveEventArg.SetBuffer(0, 65536);
						if (!this.m_socket.ReceiveAsync(this.m_receiveEventArg))
						{
							this.OnCompletedForReceive(null, this.m_receiveEventArg);
						}
					}
					return;
				}
			}
			catch (Exception ex)
			{
				CCMSGConnectionRecvFailure msg = new CCMSGConnectionRecvFailure
				{
					ExceptionInfo = ex.ToString()
				};
				this.WriteMsg2RecvCache(msg);
			}
			if (this.State == ConnectionState.Established || this.State == ConnectionState.Disconnecting)
			{
				this.FireEventOnLogPrint("OnCompletedForReceivestate=" + this.State, string.Empty);
				this.State = ConnectionState.Closed;
				CCMSGConnectionBreak msg2 = new CCMSGConnectionBreak();
				this.WriteMsg2RecvCache(msg2);
			}
		}

		// Token: 0x06006AFA RID: 27386 RVA: 0x001E034C File Offset: 0x001DE54C
		private void WriteMsg2RecvCache(object msg)
		{
			object recvCache = this.m_recvCache;
			lock (recvCache)
			{
				ArraySegment<byte> arraySegment = ProtoHelper.EncodeMessage(msg, this.m_provider);
				this.m_recvCache.Write(arraySegment.Array, arraySegment.Count);
			}
		}

		// Token: 0x06006AFB RID: 27387 RVA: 0x001E03AC File Offset: 0x001DE5AC
		private void TryDecodeMsg()
		{
			object recvCache = this.m_recvCache;
			lock (recvCache)
			{
				if (this.m_lastRecvCacheLength != this.m_recvCache.Length)
				{
					do
					{
						int key;
						object obj = ProtoHelper.DecodeMessage(this.m_recvCache, this.m_provider, out key, this.m_messageDeserializeAction);
						if (obj == null)
						{
							break;
						}
						KeyValuePair<int, object> item = new KeyValuePair<int, object>(key, obj);
						object recvQueue = this.m_recvQueue;
						lock (recvQueue)
						{
							this.m_recvQueue.Enqueue(item);
						}
					}
					while (this.m_recvCache.Length != 0);
					this.m_recvCache.Crunch();
					this.m_lastRecvCacheLength = this.m_recvCache.Length;
				}
			}
		}

		// Token: 0x06006AFC RID: 27388 RVA: 0x001E0498 File Offset: 0x001DE698
		public static string GetIPv6String(string mHost, string mPort)
		{
			return mHost + "&&ipv4";
		}

		// Token: 0x06006AFD RID: 27389 RVA: 0x001E04A8 File Offset: 0x001DE6A8
		private void GetIpType(string serverIp, string serverPorts, out string newServerIp, out AddressFamily mIpType)
		{
			mIpType = AddressFamily.InterNetwork;
			newServerIp = serverIp;
			try
			{
				string ipv6String = Connection.GetIPv6String(serverIp, serverPorts);
				if (!string.IsNullOrEmpty(ipv6String))
				{
					string[] array = Regex.Split(ipv6String, "&&");
					if (array != null && array.Length >= 2)
					{
						string a = array[1];
						if (a == "ipv6")
						{
							newServerIp = array[0];
							mIpType = AddressFamily.InterNetworkV6;
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06006AFE RID: 27390 RVA: 0x001E0520 File Offset: 0x001DE720
		private void FireEventOnLogPrint(string callFun, string log = "")
		{
			if (string.IsNullOrEmpty(log))
			{
				log = string.Format("m_ipEndPoint={0}:{1} CCMSGConnectionBreak happen. callFun={2}", this.m_ipEndPoint.Address.ToString(), this.m_ipEndPoint.Port, callFun);
			}
			if (this.EventOnLogPrint != null)
			{
				this.EventOnLogPrint(log);
			}
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x001E057C File Offset: 0x001DE77C
		public int GetEndpoint()
		{
			if (this.m_ipEndPoint == null)
			{
				return 0;
			}
			return this.m_ipEndPoint.Port;
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06006B00 RID: 27392 RVA: 0x001E0598 File Offset: 0x001DE798
		// (set) Token: 0x06006B01 RID: 27393 RVA: 0x001E05A0 File Offset: 0x001DE7A0
		public ConnectionState State { get; private set; }

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06006B02 RID: 27394 RVA: 0x001E05AC File Offset: 0x001DE7AC
		// (remove) Token: 0x06006B03 RID: 27395 RVA: 0x001E05E4 File Offset: 0x001DE7E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<string> EventOnLogPrint;

		// Token: 0x04005258 RID: 21080
		private IProtoProvider m_provider;

		// Token: 0x04005259 RID: 21081
		private Socket m_socket;

		// Token: 0x0400525A RID: 21082
		private Queue<KeyValuePair<int, object>> m_recvQueue = new Queue<KeyValuePair<int, object>>();

		// Token: 0x0400525B RID: 21083
		private MessageBlock m_recvCache = new MessageBlock(65536);

		// Token: 0x0400525C RID: 21084
		private int m_lastRecvCacheLength;

		// Token: 0x0400525D RID: 21085
		private IPEndPoint m_ipEndPoint;

		// Token: 0x0400525E RID: 21086
		private SocketAsyncEventArgs m_connEventArg = new SocketAsyncEventArgs();

		// Token: 0x0400525F RID: 21087
		private SocketAsyncEventArgs m_receiveEventArg = new SocketAsyncEventArgs();

		// Token: 0x04005260 RID: 21088
		private Timer m_disconnectTimer;

		// Token: 0x04005261 RID: 21089
		private Func<Stream, Type, int, object> m_messageDeserializeAction;
	}
}
