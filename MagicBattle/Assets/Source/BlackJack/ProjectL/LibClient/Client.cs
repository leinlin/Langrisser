using System;
using System.Collections.Generic;
using System.IO;
using BlackJack.LibClient;
using BlackJack.ServerFramework.Protocol;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005A7 RID: 1447
	[CustomLuaClass]
	public class Client : IClient
	{
		// Token: 0x0600525C RID: 21084 RVA: 0x00186A2C File Offset: 0x00184C2C
		public Client(IClientEventHandler handler, Func<Stream, Type, int, object> deserializeMessageAction = null)
		{
			if (handler == null)
			{
				throw new Exception("Client::Client, called failed, handler is null");
			}
			this.m_clientEventHandler = handler;
			this.m_protoProvider = new LibClientProtoProvider();
			this.m_messageDeserializeAction = deserializeMessageAction;
			this.m_connect = new Connection(this.m_protoProvider, deserializeMessageAction);
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00186A88 File Offset: 0x00184C88
		public void SetClientToInit()
		{
			this.Close();
			this.m_csm.SetStateWithoutCheck(0);
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00186A9C File Offset: 0x00184C9C
		public void BlockProcessMsg(bool isBlock)
		{
			this.m_isBlockProcessMsg = isBlock;
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00186AA8 File Offset: 0x00184CA8
		public bool LoginByAuthToken(string serverAddress, int serverPort, string authToken, string clientVersion, string clientDeviceId, string localization = "", int loginChannelId = 0, int bornChannelId = 0)
		{
			if (this.m_connect.State != ConnectionState.None && this.m_connect.State != ConnectionState.Closed)
			{
				return false;
			}
			if (this.m_csm.SetStateCheck(1, 1, true) == -1)
			{
				return false;
			}
			if (!this.m_connect.Initialize(serverAddress, serverPort))
			{
				return false;
			}
			this.m_authToken = authToken;
			this.m_clientVersion = clientVersion;
			this.m_clientDeviceId = clientDeviceId;
			this.m_localization = localization;
			this.m_loginChannelId = loginChannelId;
			this.m_bornChannelId = bornChannelId;
			this.m_connectedAddress = serverAddress;
			this.m_csm.SetStateCheck(1, -1, false);
			return true;
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x00186B48 File Offset: 0x00184D48
		public bool LoginBySessionToken(string sessionToken, string clientVersion, string localization = "", int loginChannelId = 0, int bornChannelId = 0)
		{
			if (this.m_connect.State != ConnectionState.None && this.m_connect.State != ConnectionState.Closed)
			{
				this.Close();
				this.m_connect = new Connection(this.m_protoProvider, this.m_messageDeserializeAction);
			}
			if (this.m_csm.SetStateCheck(8, 4, true) == -1)
			{
				UnityEngine.Debug.LogErrorFormat("Client::LoginBySessionToken SetStateCheck failed, {0}", new object[]
				{
					sessionToken
				});
				return false;
			}
			SessionToken sessionObject = SessionToken.GetSessionObject(sessionToken);
			if (sessionToken == null)
			{
				UnityEngine.Debug.LogErrorFormat("Client::LoginBySessionToken GetSessionObject failed, {0}", new object[]
				{
					sessionToken
				});
				return false;
			}
			if (!this.m_connect.Initialize(sessionObject.ServerAddress, sessionObject.ServerPort))
			{
				UnityEngine.Debug.LogErrorFormat("Client::LoginBySessionToken call _connect.Initialize failed, {0}", new object[]
				{
					sessionToken
				});
				return false;
			}
			this.m_sessionToken = sessionToken;
			this.m_clientVersion = clientVersion;
			this.m_localization = localization;
			this.m_loginChannelId = loginChannelId;
			this.m_bornChannelId = bornChannelId;
			this.m_connectedAddress = sessionObject.ServerAddress;
			this.m_csm.SetStateCheck(8, -1, false);
			return true;
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00186C54 File Offset: 0x00184E54
		public bool Disconnect()
		{
			if (this.m_csm.SetStateCheck(3, -1, false) != 99)
			{
				return false;
			}
			if (this.m_connect.State == ConnectionState.None || this.m_connect.State == ConnectionState.Closed)
			{
				return true;
			}
			this.m_connect.Disconnect();
			return true;
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00186CA8 File Offset: 0x00184EA8
		public void Close()
		{
			this.m_connect.Close();
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00186CB8 File Offset: 0x00184EB8
		public bool SendMessage(object msg)
		{
			if (this.m_csm.State != 6)
			{
				this.m_clientEventHandler.OnError(9004, "Client::SendMessage state not equal to login_ok");
				return false;
			}
			if (this.m_connect.State != ConnectionState.Established)
			{
				this.m_clientEventHandler.OnError(9004, "Client::SendMessage state not equal to established");
				return false;
			}
			this.m_connect.SendMessage(msg);
			return true;
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00186D24 File Offset: 0x00184F24
		public void Tick()
		{
			int state = this.m_csm.State;
			switch (state)
			{
			case 0:
				break;
			case 1:
			case 2:
			case 3:
				this.TickAuthLogin();
				break;
			case 4:
			case 5:
				this.TickSessionLogin();
				break;
			case 6:
				this.TickLoginOk();
				break;
			default:
				if (state != 99)
				{
					if (state == 100)
					{
						this.TickDisconnected();
					}
				}
				else
				{
					this.TickDisconnecting();
				}
				break;
			}
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x00186DB8 File Offset: 0x00184FB8
		protected virtual void TickAuthLogin()
		{
			switch (this.m_csm.State)
			{
			case 1:
				this.ProcessMessages(delegate(int msgId, object msgObj)
				{
					switch (msgId)
					{
					case 9001:
					{
						this.m_csm.SetStateCheck(2, -1, false);
						this.m_clientEventHandler.OnConnected();
						LoginByAuthTokenReq loginByAuthTokenReq = new LoginByAuthTokenReq();
						loginByAuthTokenReq.AuthToken = this.m_authToken;
						loginByAuthTokenReq.ClientVersion = this.m_clientVersion;
						loginByAuthTokenReq.ClientDeviceId = this.m_clientDeviceId;
						loginByAuthTokenReq.CurrChannelId = this.m_loginChannelId;
						loginByAuthTokenReq.BornChannelId = this.m_bornChannelId;
						this.m_connect.SendMessage(loginByAuthTokenReq);
						return true;
					}
					case 9002:
					case 9003:
					case 9004:
					case 9005:
						return false;
					default:
						return true;
					}
				});
				break;
			case 2:
				this.ProcessMessages(delegate(int msgId, object msgObj)
				{
					switch (msgId)
					{
					case 9001:
					case 9002:
					case 9003:
					case 9004:
					case 9005:
						return false;
					default:
					{
						if (msgId != 1)
						{
							return true;
						}
						LoginByAuthTokenAck loginByAuthTokenAck = (LoginByAuthTokenAck)msgObj;
						if (loginByAuthTokenAck.Result != 0)
						{
							this.m_csm.SetStateCheck(7, -1, false);
						}
						else if (loginByAuthTokenAck.NeedRedirect)
						{
							this.m_csm.SetStateCheck(6, -1, false);
						}
						else
						{
							this.m_csm.SetStateCheck(5, -1, false);
						}
						this.m_clientEventHandler.OnLoginByAuthTokenAck(loginByAuthTokenAck.Result, loginByAuthTokenAck.NeedRedirect, loginByAuthTokenAck.SessionToken);
						return true;
					}
					}
				});
				break;
			case 3:
				this.ProcessMessages(delegate(int msgId, object msgObj)
				{
					switch (msgId)
					{
					case 9001:
					case 9002:
					case 9003:
					case 9004:
					case 9005:
						return false;
					default:
						return true;
					}
				});
				break;
			}
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00186E48 File Offset: 0x00185048
		protected virtual void TickSessionLogin()
		{
			int state = this.m_csm.State;
			if (state != 4)
			{
				if (state == 5)
				{
					this.ProcessMessages(delegate(int msgId, object msgObj)
					{
						switch (msgId)
						{
						case 9001:
						case 9002:
						case 9003:
						case 9004:
						case 9005:
							return false;
						default:
						{
							if (msgId != 3)
							{
								return true;
							}
							LoginBySessionTokenAck loginBySessionTokenAck = (LoginBySessionTokenAck)msgObj;
							if (loginBySessionTokenAck.Result != 0)
							{
								this.m_csm.SetStateCheck(10, -1, false);
							}
							else
							{
								this.m_csm.SetStateCheck(9, -1, false);
							}
							this.m_clientEventHandler.OnLoginBySessionTokenAck(loginBySessionTokenAck.Result);
							return true;
						}
						}
					});
				}
			}
			else
			{
				this.ProcessMessages(delegate(int msgId, object msgObj)
				{
					switch (msgId)
					{
					case 9001:
					{
						this.m_csm.SetStateCheck(2, -1, false);
						this.m_clientEventHandler.OnConnected();
						LoginBySessionTokenReq loginBySessionTokenReq = new LoginBySessionTokenReq();
						loginBySessionTokenReq.SessionToken = this.m_sessionToken;
						loginBySessionTokenReq.ClientVersion = this.m_clientVersion;
						loginBySessionTokenReq.CurrChannelId = this.m_loginChannelId;
						loginBySessionTokenReq.BornChannelId = this.m_bornChannelId;
						this.m_connect.SendMessage(loginBySessionTokenReq);
						return true;
					}
					case 9002:
					case 9003:
					case 9004:
					case 9005:
						return false;
					default:
						return true;
					}
				});
			}
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00186EA8 File Offset: 0x001850A8
		protected virtual void TickLoginOk()
		{
			this.ProcessMessages(null);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00186EB4 File Offset: 0x001850B4
		protected virtual void TickDisconnecting()
		{
			this.ProcessMessages(null);
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00186EC0 File Offset: 0x001850C0
		protected virtual void TickDisconnected()
		{
			this.ProcessMessages(null);
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00186ECC File Offset: 0x001850CC
		private void DebugWarning(string fun, string msg1, string msg2)
		{
			string str = string.Format("Client::{0}, {1} {2}", fun.ToString(), msg1.GetType().ToString(), msg2.ToString());
			global::Debug.WriteLine(str);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00186F04 File Offset: 0x00185104
		private void ProcessMessages(MessageProc proc = null)
		{
			while (!this.m_isBlockProcessMsg)
			{
				KeyValuePair<int, object> messagePair = this.m_connect.GetMessagePair();
				if (messagePair.Value == null)
				{
					break;
				}
				int key = messagePair.Key;
				int state = this.m_csm.State;
				if (proc != null && proc(key, messagePair.Value))
				{
					if (state != this.m_csm.State)
					{
						return;
					}
				}
				else
				{
					switch (key)
					{
					case 9001:
						this.m_csm.SetStateCheck(2, -1, false);
						this.m_clientEventHandler.OnConnected();
						return;
					case 9002:
						this.m_csm.SetStateCheck(4, -1, false);
						this.m_clientEventHandler.OnDisconnected();
						return;
					case 9003:
						this.m_csm.SetStateCheck(4, -1, false);
						this.m_clientEventHandler.OnError(key, "connection disconnected");
						return;
					case 9004:
					{
						this.m_csm.SetStateCheck(4, -1, false);
						CCMSGConnectionSendFailure ccmsgconnectionSendFailure = messagePair.Value as CCMSGConnectionSendFailure;
						this.m_clientEventHandler.OnError(key, ccmsgconnectionSendFailure.ExceptionInfo);
						if (this.m_connect.State == ConnectionState.Connecting || this.m_connect.State == ConnectionState.Established)
						{
							this.Close();
						}
						return;
					}
					case 9005:
					{
						this.m_csm.SetStateCheck(4, -1, false);
						CCMSGConnectionRecvFailure ccmsgconnectionRecvFailure = messagePair.Value as CCMSGConnectionRecvFailure;
						this.m_clientEventHandler.OnError(key, ccmsgconnectionRecvFailure.ExceptionInfo);
						if (this.m_connect.State == ConnectionState.Connecting || this.m_connect.State == ConnectionState.Established)
						{
							this.Close();
						}
						return;
					}
					default:
						this.m_clientEventHandler.OnMessage(messagePair.Value, key);
						break;
					}
				}
			}
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x001870C8 File Offset: 0x001852C8
		public int GetEndPoint()
		{
			if (this.m_connect == null)
			{
				return 0;
			}
			return this.m_connect.GetEndpoint();
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x001870E4 File Offset: 0x001852E4
		public void RegConnectionLogEvent(Action<string> logEvent)
		{
			this.m_connect.EventOnLogPrint += logEvent;
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x001870F4 File Offset: 0x001852F4
		public string GetIp()
		{
			return this.m_connectedAddress;
		}

		// Token: 0x04003DDA RID: 15834
		private LibClientStateMachine m_csm = new LibClientStateMachine();

		// Token: 0x04003DDB RID: 15835
		private IClientEventHandler m_clientEventHandler;

		// Token: 0x04003DDC RID: 15836
		private string m_authToken;

		// Token: 0x04003DDD RID: 15837
		private string m_clientVersion;

		// Token: 0x04003DDE RID: 15838
		private string m_clientDeviceId;

		// Token: 0x04003DDF RID: 15839
		private string m_localization;

		// Token: 0x04003DE0 RID: 15840
		private int m_loginChannelId;

		// Token: 0x04003DE1 RID: 15841
		private int m_bornChannelId;

		// Token: 0x04003DE2 RID: 15842
		private string m_sessionToken;

		// Token: 0x04003DE3 RID: 15843
		private Connection m_connect;

		// Token: 0x04003DE4 RID: 15844
		private LibClientProtoProvider m_protoProvider;

		// Token: 0x04003DE5 RID: 15845
		private bool m_isBlockProcessMsg;

		// Token: 0x04003DE6 RID: 15846
		private Func<Stream, Type, int, object> m_messageDeserializeAction;

		// Token: 0x04003DE7 RID: 15847
		private string m_connectedAddress;
	}
}
