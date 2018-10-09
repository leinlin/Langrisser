using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B60 RID: 2912
	[HotFix]
	public class PlayerVoiceHandleThread
	{
		// Token: 0x0600C6A2 RID: 50850 RVA: 0x0036FEC4 File Offset: 0x0036E0C4
		private PlayerVoiceHandleThread()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x0036FF6C File Offset: 0x0036E16C
		public void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("PlayerVoiceHandleThread::Initialize Start");
			if (this.m_startHandle)
			{
				return;
			}
			this.m_startHandle = true;
			this.m_voiceHandleThread = new Thread(new ThreadStart(this.VoiceThreadProc));
			this.m_voiceHandleThread.Start();
			Debug.Log("PlayerVoiceHandleThread::Initialize End");
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x00370018 File Offset: 0x0036E218
		public void Stop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Stop_hotfix != null)
			{
				this.m_Stop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_startHandle = false;
			try
			{
				Debug.Log("PlayerVoiceHandleThread::VoiceThread Stop");
				if (this.m_voiceHandleThread != null)
				{
					this.m_voiceHandleThread.Abort();
				}
			}
			catch (Exception)
			{
				Thread.ResetAbort();
			}
		}

		// Token: 0x0600C6A5 RID: 50853 RVA: 0x003700C0 File Offset: 0x0036E2C0
		private void AddDataToInputBuffer(PlayerVoiceHandleThread.VoicePacket packet)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDataToInputBufferVoicePacket_hotfix != null)
			{
				this.m_AddDataToInputBufferVoicePacket_hotfix.call(new object[]
				{
					this,
					packet
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Monitor.Enter(this.m_lock);
			if (this.m_inputQueue != null)
			{
				if (packet != null)
				{
					if (packet.m_srcData != null)
					{
						Debug.Log(string.Concat(new object[]
						{
							"PlayerVoiceHandleThread.AddDataToInputBuffer ",
							packet.m_srcData.Length,
							" ",
							packet.m_type
						}));
					}
					else
					{
						Debug.Log("PlayerVoiceHandleThread.AddDataToInputBuffer srcData = null type=" + packet.m_type);
					}
				}
				this.m_inputQueue.Enqueue(packet);
			}
			Monitor.Exit(this.m_lock);
		}

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x003701CC File Offset: 0x0036E3CC
		public void AddDataContentToInputBuffer(float[] audioData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDataContentToInputBufferSinglebe_hotfix != null)
			{
				this.m_AddDataContentToInputBufferSinglebe_hotfix.call(new object[]
				{
					this,
					audioData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddDataToInputBuffer(new PlayerVoiceHandleThread.VoicePacket
			{
				m_srcData = audioData,
				m_type = DataType.Content
			});
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x00370258 File Offset: 0x0036E458
		public void AddDataHeadToInputBuffer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDataHeadToInputBuffer_hotfix != null)
			{
				this.m_AddDataHeadToInputBuffer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddDataToInputBuffer(new PlayerVoiceHandleThread.VoicePacket
			{
				m_type = DataType.Head
			});
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x003702CC File Offset: 0x0036E4CC
		public void AddDataEndToInputBuffer(ChatVoiceInfo chatInfo, bool isValid)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDataEndToInputBufferChatVoiceInfoBoolean_hotfix != null)
			{
				this.m_AddDataEndToInputBufferChatVoiceInfoBoolean_hotfix.call(new object[]
				{
					this,
					chatInfo,
					isValid
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddDataToInputBuffer(new PlayerVoiceHandleThread.VoicePacket
			{
				m_type = DataType.End,
				m_chatInfo = chatInfo,
				m_isValid = isValid
			});
		}

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x00370370 File Offset: 0x0036E570
		private PlayerVoiceHandleThread.VoicePacket GetInputBufferData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetInputBufferData_hotfix != null)
			{
				return (PlayerVoiceHandleThread.VoicePacket)this.m_GetInputBufferData_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerVoiceHandleThread.VoicePacket result = null;
			Monitor.Enter(this.m_lock);
			if (this.m_inputQueue != null && this.m_inputQueue.Count != 0)
			{
				result = this.m_inputQueue.Dequeue();
			}
			Monitor.Exit(this.m_lock);
			return result;
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x0037041C File Offset: 0x0036E61C
		private void AddDataToOutputBuffer(PlayerVoiceHandleThread.VoicePacket packet)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDataToOutputBufferVoicePacket_hotfix != null)
			{
				this.m_AddDataToOutputBufferVoicePacket_hotfix.call(new object[]
				{
					this,
					packet
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Monitor.Enter(this.m_seclock);
			if (this.m_outputQueue != null)
			{
				this.m_outputQueue.Enqueue(packet);
			}
			Monitor.Exit(this.m_seclock);
		}

		// Token: 0x0600C6AB RID: 50859 RVA: 0x003704BC File Offset: 0x0036E6BC
		public PlayerVoiceHandleThread.VoicePacket GetOutputBufferData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOutputBufferData_hotfix != null)
			{
				return (PlayerVoiceHandleThread.VoicePacket)this.m_GetOutputBufferData_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerVoiceHandleThread.VoicePacket result = null;
			if (this.m_outputQueue != null && this.m_outputQueue.Count != 0)
			{
				Monitor.Enter(this.m_seclock);
				if (this.m_outputQueue != null && this.m_outputQueue.Count != 0)
				{
					result = this.m_outputQueue.Dequeue();
				}
				Monitor.Exit(this.m_seclock);
			}
			return result;
		}

		// Token: 0x0600C6AC RID: 50860 RVA: 0x00370584 File Offset: 0x0036E784
		private int GetTickTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTickTime_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTickTime_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return 250;
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x003705F8 File Offset: 0x0036E7F8
		private void VoiceThreadProc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_VoiceThreadProc_hotfix != null)
			{
				this.m_VoiceThreadProc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<byte[]> list = new List<byte[]>();
			while (this.m_startHandle)
			{
				DateTime now = DateTime.Now;
				int tickTime = this.GetTickTime();
				PlayerVoiceHandleThread.VoicePacket inputBufferData = this.GetInputBufferData();
				if (inputBufferData != null)
				{
					if (inputBufferData.m_type == DataType.Head)
					{
						list.Clear();
					}
					if (inputBufferData.m_srcData != null)
					{
						byte[] array = VoiceChatCompression.Instance.Compress(inputBufferData.m_srcData, VoiceChatCompressionType.Speex);
						if (array != null)
						{
							list.Add(array);
						}
					}
					if (inputBufferData.m_type == DataType.End)
					{
						if (inputBufferData.m_srcData != null)
						{
							Debug.Log(string.Concat(new object[]
							{
								"PlayerVoiceHandleThread.VoiceThreadProc srcData.Len=",
								inputBufferData.m_srcData.Length,
								" data.count=",
								list.Count,
								" isValid=",
								inputBufferData.m_isValid
							}));
						}
						else
						{
							Debug.LogError("PlayerVoiceHandleThread.VoiceThreadProc srcData is null");
						}
						if (inputBufferData.m_isValid)
						{
							if (list.Count != 0)
							{
								inputBufferData.m_isCompressed = true;
								inputBufferData.m_chatInfo.m_voiceBytes = this.ByteArrayListToByteArray(list);
								list.Clear();
								this.AddDataToOutputBuffer(inputBufferData);
							}
							else
							{
								inputBufferData.m_chatInfo = null;
								this.AddDataToOutputBuffer(inputBufferData);
							}
						}
						else
						{
							list.Clear();
						}
					}
				}
				int num = (int)(now.AddMilliseconds((double)tickTime) - DateTime.Now).TotalMilliseconds;
				if (num > 0)
				{
					Thread.Sleep(num);
				}
			}
		}

		// Token: 0x0600C6AE RID: 50862 RVA: 0x003707CC File Offset: 0x0036E9CC
		private byte[] ByteArrayListToByteArray(List<byte[]> list)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ByteArrayListToByteArrayList`1_hotfix != null)
			{
				return (byte[])this.m_ByteArrayListToByteArrayList`1_hotfix.call(new object[]
				{
					this,
					list
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			for (int i = 0; i < list.Count; i++)
			{
				num += list[i].Length;
			}
			byte[] array = new byte[num];
			int num2 = 0;
			for (int j = 0; j < list.Count; j++)
			{
				Array.Copy(list[j], 0, array, num2, list[j].Length);
				num2 += list[j].Length;
			}
			return array;
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600C6AF RID: 50863 RVA: 0x003708BC File Offset: 0x0036EABC
		public static PlayerVoiceHandleThread Instance
		{
			get
			{
				if (PlayerVoiceHandleThread.m_instance == null)
				{
					PlayerVoiceHandleThread.m_instance = new PlayerVoiceHandleThread();
				}
				return PlayerVoiceHandleThread.m_instance;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600C6B0 RID: 50864 RVA: 0x003708D8 File Offset: 0x0036EAD8
		// (set) Token: 0x0600C6B1 RID: 50865 RVA: 0x003708F8 File Offset: 0x0036EAF8
		[DoNotToLua]
		public PlayerVoiceHandleThread.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerVoiceHandleThread.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C6B2 RID: 50866 RVA: 0x00370904 File Offset: 0x0036EB04
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_Stop_hotfix = (luaObj.RawGet("Stop") as LuaFunction);
					this.m_AddDataToInputBufferVoicePacket_hotfix = (luaObj.RawGet("AddDataToInputBuffer") as LuaFunction);
					this.m_AddDataContentToInputBufferSinglebe_hotfix = (luaObj.RawGet("AddDataContentToInputBuffer") as LuaFunction);
					this.m_AddDataHeadToInputBuffer_hotfix = (luaObj.RawGet("AddDataHeadToInputBuffer") as LuaFunction);
					this.m_AddDataEndToInputBufferChatVoiceInfoBoolean_hotfix = (luaObj.RawGet("AddDataEndToInputBuffer") as LuaFunction);
					this.m_GetInputBufferData_hotfix = (luaObj.RawGet("GetInputBufferData") as LuaFunction);
					this.m_AddDataToOutputBufferVoicePacket_hotfix = (luaObj.RawGet("AddDataToOutputBuffer") as LuaFunction);
					this.m_GetOutputBufferData_hotfix = (luaObj.RawGet("GetOutputBufferData") as LuaFunction);
					this.m_GetTickTime_hotfix = (luaObj.RawGet("GetTickTime") as LuaFunction);
					this.m_VoiceThreadProc_hotfix = (luaObj.RawGet("VoiceThreadProc") as LuaFunction);
					this.m_ByteArrayListToByteArrayList`1_hotfix = (luaObj.RawGet("ByteArrayListToByteArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C6B3 RID: 50867 RVA: 0x00370AFC File Offset: 0x0036ECFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerVoiceHandleThread));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007D9D RID: 32157
		public bool m_startHandle;

		// Token: 0x04007D9E RID: 32158
		public Thread m_voiceHandleThread;

		// Token: 0x04007D9F RID: 32159
		private Queue<PlayerVoiceHandleThread.VoicePacket> m_inputQueue = new Queue<PlayerVoiceHandleThread.VoicePacket>();

		// Token: 0x04007DA0 RID: 32160
		private Queue<PlayerVoiceHandleThread.VoicePacket> m_outputQueue = new Queue<PlayerVoiceHandleThread.VoicePacket>();

		// Token: 0x04007DA1 RID: 32161
		private List<int> m_validIdList = new List<int>();

		// Token: 0x04007DA2 RID: 32162
		private readonly object m_lock = new object();

		// Token: 0x04007DA3 RID: 32163
		private readonly object m_seclock = new object();

		// Token: 0x04007DA4 RID: 32164
		private readonly object m_idListLock = new object();

		// Token: 0x04007DA5 RID: 32165
		private static PlayerVoiceHandleThread m_instance;

		// Token: 0x04007DA6 RID: 32166
		[DoNotToLua]
		private PlayerVoiceHandleThread.LuaExportHelper luaExportHelper;

		// Token: 0x04007DA7 RID: 32167
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007DA8 RID: 32168
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007DA9 RID: 32169
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04007DAA RID: 32170
		private LuaFunction m_Start_hotfix;

		// Token: 0x04007DAB RID: 32171
		private LuaFunction m_Stop_hotfix;

		// Token: 0x04007DAC RID: 32172
		private LuaFunction m_AddDataToInputBufferVoicePacket_hotfix;

		// Token: 0x04007DAD RID: 32173
		private LuaFunction m_AddDataContentToInputBufferSinglebe_hotfix;

		// Token: 0x04007DAE RID: 32174
		private LuaFunction m_AddDataHeadToInputBuffer_hotfix;

		// Token: 0x04007DAF RID: 32175
		private LuaFunction m_AddDataEndToInputBufferChatVoiceInfoBoolean_hotfix;

		// Token: 0x04007DB0 RID: 32176
		private LuaFunction m_GetInputBufferData_hotfix;

		// Token: 0x04007DB1 RID: 32177
		private LuaFunction m_AddDataToOutputBufferVoicePacket_hotfix;

		// Token: 0x04007DB2 RID: 32178
		private LuaFunction m_GetOutputBufferData_hotfix;

		// Token: 0x04007DB3 RID: 32179
		private LuaFunction m_GetTickTime_hotfix;

		// Token: 0x04007DB4 RID: 32180
		private LuaFunction m_VoiceThreadProc_hotfix;

		// Token: 0x04007DB5 RID: 32181
		private LuaFunction m_ByteArrayListToByteArrayList;

		// Token: 0x02000B61 RID: 2913
		[HotFix]
		public class VoicePacket
		{
			// Token: 0x04007DB6 RID: 32182
			public float[] m_srcData;

			// Token: 0x04007DB7 RID: 32183
			public ChatVoiceInfo m_chatInfo;

			// Token: 0x04007DB8 RID: 32184
			public bool m_isCompressed;

			// Token: 0x04007DB9 RID: 32185
			public DataType m_type;

			// Token: 0x04007DBA RID: 32186
			public bool m_isValid = true;
		}

		// Token: 0x02000B62 RID: 2914
		public class LuaExportHelper
		{
			// Token: 0x0600C6B5 RID: 50869 RVA: 0x00370B74 File Offset: 0x0036ED74
			public LuaExportHelper(PlayerVoiceHandleThread owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x1700278A RID: 10122
			// (get) Token: 0x0600C6B6 RID: 50870 RVA: 0x00370B84 File Offset: 0x0036ED84
			// (set) Token: 0x0600C6B7 RID: 50871 RVA: 0x00370B94 File Offset: 0x0036ED94
			public Queue<PlayerVoiceHandleThread.VoicePacket> m_inputQueue
			{
				get
				{
					return this.m_owner.m_inputQueue;
				}
				set
				{
					this.m_owner.m_inputQueue = value;
				}
			}

			// Token: 0x1700278B RID: 10123
			// (get) Token: 0x0600C6B8 RID: 50872 RVA: 0x00370BA4 File Offset: 0x0036EDA4
			// (set) Token: 0x0600C6B9 RID: 50873 RVA: 0x00370BB4 File Offset: 0x0036EDB4
			public Queue<PlayerVoiceHandleThread.VoicePacket> m_outputQueue
			{
				get
				{
					return this.m_owner.m_outputQueue;
				}
				set
				{
					this.m_owner.m_outputQueue = value;
				}
			}

			// Token: 0x1700278C RID: 10124
			// (get) Token: 0x0600C6BA RID: 50874 RVA: 0x00370BC4 File Offset: 0x0036EDC4
			// (set) Token: 0x0600C6BB RID: 50875 RVA: 0x00370BD4 File Offset: 0x0036EDD4
			public List<int> m_validIdList
			{
				get
				{
					return this.m_owner.m_validIdList;
				}
				set
				{
					this.m_owner.m_validIdList = value;
				}
			}

			// Token: 0x1700278D RID: 10125
			// (get) Token: 0x0600C6BC RID: 50876 RVA: 0x00370BE4 File Offset: 0x0036EDE4
			public object m_lock
			{
				get
				{
					return this.m_owner.m_lock;
				}
			}

			// Token: 0x1700278E RID: 10126
			// (get) Token: 0x0600C6BD RID: 50877 RVA: 0x00370BF4 File Offset: 0x0036EDF4
			public object m_seclock
			{
				get
				{
					return this.m_owner.m_seclock;
				}
			}

			// Token: 0x1700278F RID: 10127
			// (get) Token: 0x0600C6BE RID: 50878 RVA: 0x00370C04 File Offset: 0x0036EE04
			public object m_idListLock
			{
				get
				{
					return this.m_owner.m_idListLock;
				}
			}

			// Token: 0x17002790 RID: 10128
			// (get) Token: 0x0600C6BF RID: 50879 RVA: 0x00370C14 File Offset: 0x0036EE14
			// (set) Token: 0x0600C6C0 RID: 50880 RVA: 0x00370C1C File Offset: 0x0036EE1C
			public static PlayerVoiceHandleThread m_instance
			{
				get
				{
					return PlayerVoiceHandleThread.m_instance;
				}
				set
				{
					PlayerVoiceHandleThread.m_instance = value;
				}
			}

			// Token: 0x0600C6C1 RID: 50881 RVA: 0x00370C24 File Offset: 0x0036EE24
			public void AddDataToInputBuffer(PlayerVoiceHandleThread.VoicePacket packet)
			{
				this.m_owner.AddDataToInputBuffer(packet);
			}

			// Token: 0x0600C6C2 RID: 50882 RVA: 0x00370C34 File Offset: 0x0036EE34
			public PlayerVoiceHandleThread.VoicePacket GetInputBufferData()
			{
				return this.m_owner.GetInputBufferData();
			}

			// Token: 0x0600C6C3 RID: 50883 RVA: 0x00370C44 File Offset: 0x0036EE44
			public void AddDataToOutputBuffer(PlayerVoiceHandleThread.VoicePacket packet)
			{
				this.m_owner.AddDataToOutputBuffer(packet);
			}

			// Token: 0x0600C6C4 RID: 50884 RVA: 0x00370C54 File Offset: 0x0036EE54
			public int GetTickTime()
			{
				return this.m_owner.GetTickTime();
			}

			// Token: 0x0600C6C5 RID: 50885 RVA: 0x00370C64 File Offset: 0x0036EE64
			public void VoiceThreadProc()
			{
				this.m_owner.VoiceThreadProc();
			}

			// Token: 0x0600C6C6 RID: 50886 RVA: 0x00370C74 File Offset: 0x0036EE74
			public byte[] ByteArrayListToByteArray(List<byte[]> list)
			{
				return this.m_owner.ByteArrayListToByteArray(list);
			}

			// Token: 0x04007DBB RID: 32187
			private PlayerVoiceHandleThread m_owner;
		}
	}
}
