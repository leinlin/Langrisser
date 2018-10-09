using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.Utils;
using ProtoBuf;
using SLua;

namespace BlackJack.BJFramework.Runtime.PlayerContext
{
	// Token: 0x0200006C RID: 108
	[HotFix]
	public abstract class PlayerContextBase : ITickable, IPlayerContextNetworkEventHandler
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x000158D0 File Offset: 0x00013AD0
		protected PlayerContextBase()
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

		// Token: 0x060004DA RID: 1242 RVA: 0x00015958 File Offset: 0x00013B58
		public static PlayerContextBase GetInstance()
		{
			return GameManager.Instance.PlayerContext;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00015964 File Offset: 0x00013B64
		[DoNotToLua]
		public virtual void InitWithNetworkClient(IPlayerContextNetworkClient networkClient)
		{
			this.m_networkClient = networkClient;
			this.m_fsm.SetStateWithoutCheck(1);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0001597C File Offset: 0x00013B7C
		public bool IsInited()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInited_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInited_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_inited;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000159F0 File Offset: 0x00013BF0
		[DoNotToLua]
		public void BlockNetworkClient(bool isBlock)
		{
			this.m_networkClient.BlockProcessMsg(isBlock);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00015A00 File Offset: 0x00013C00
		protected void OnPlayerInfoInitEndNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerInfoInitEndNtf_hotfix != null)
			{
				this.m_OnPlayerInfoInitEndNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_inited = true;
		}

		// Token: 0x060004DF RID: 1247
		public abstract bool IsDataCacheDirtyByPlayerInfoInitAck(object msg, out bool raiseCriticalDataCacheDirty);

		// Token: 0x060004E0 RID: 1248
		public abstract bool IsPlayerInfoInitAck4CheckOnly(object msg);

		// Token: 0x060004E1 RID: 1249 RVA: 0x00015A68 File Offset: 0x00013C68
		protected void SyncServerTime(DateTime serverTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SyncServerTimeDateTime_hotfix != null)
			{
				this.m_SyncServerTimeDateTime_hotfix.call(new object[]
				{
					this,
					serverTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_serverTimeSynced = new DateTime?(serverTime);
			this.m_localTimeAtServerTimeSynced = DateTime.Now;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00015AF0 File Offset: 0x00013CF0
		public DateTime GetCurrServerTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrServerTime_hotfix != null)
			{
				return (DateTime)this.m_GetCurrServerTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime? serverTimeSynced = this.m_serverTimeSynced;
			if (serverTimeSynced == null)
			{
				return DateTime.Now;
			}
			return this.m_serverTimeSynced.Value.Add(DateTime.Now - this.m_localTimeAtServerTimeSynced);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00015B9C File Offset: 0x00013D9C
		public DateTime GetCurrTickServerTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrTickServerTime_hotfix != null)
			{
				return (DateTime)this.m_GetCurrTickServerTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currTickServerTime;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00015C10 File Offset: 0x00013E10
		public bool Disconnect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Disconnect_hotfix != null)
			{
				return Convert.ToBoolean(this.m_Disconnect_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_networkClient.Disconnect();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00015C88 File Offset: 0x00013E88
		public virtual bool StartGameAuthLogin(string serverAddress, int serverPort, string authToken, string localization, int loginChannelId, int bornChannelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGameAuthLoginStringInt32StringStringInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartGameAuthLoginStringInt32StringStringInt32Int32_hotfix.call(new object[]
				{
					this,
					serverAddress,
					serverPort,
					authToken,
					localization,
					loginChannelId,
					bornChannelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log(string.Format("PlayerContextBase.StartGameAuthLogin serverAddress={0} port={1} token={2}", serverAddress, serverPort, authToken));
			if (this.m_networkClient == null)
			{
				Debug.LogError("PlayerContextBase.StartGameAuthLogin m_networkClient is null");
				return false;
			}
			if (this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnAuthLoginStart, PlayerContextStateMachine.StateCode.Invalid, false) == PlayerContextStateMachine.StateCode.Invalid)
			{
				Debug.LogError("PlayerContextBase.StartGameAuthLogin state error");
				return false;
			}
			this.m_deviceId = this.GetDeviceId();
			this.m_clientVersion = this.GetClientVersion();
			this.m_localization = localization;
			this.m_loginChannelId = loginChannelId;
			this.m_bornChannelId = bornChannelId;
			if (!this.m_networkClient.LoginByAuthToken(serverAddress, serverPort, authToken, this.m_clientVersion, this.m_deviceId, localization, loginChannelId, bornChannelId))
			{
				Debug.LogError("PlayerContextBase.StartGameAuthLogin m_networkClient.LoginByAuthToken fail");
				return false;
			}
			return true;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00015E04 File Offset: 0x00014004
		public void SetSessionToken(string sessionToken, int channelId, int bornChannelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSessionTokenStringInt32Int32_hotfix != null)
			{
				this.m_SetSessionTokenStringInt32Int32_hotfix.call(new object[]
				{
					this,
					sessionToken,
					channelId,
					bornChannelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sessionToken = sessionToken;
			this.m_loginChannelId = channelId;
			this.m_bornChannelId = bornChannelId;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00015EAC File Offset: 0x000140AC
		public virtual bool StartGameSessionLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGameSessionLogin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartGameSessionLogin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("PlayerContextBase.StartGameSessionLogin");
			if (this.m_sessionToken == null)
			{
				Debug.LogError("PlayerContextBase.StartGameSessionLogin m_sessionToken == null");
				return false;
			}
			if (this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnSessionLoginStart, PlayerContextStateMachine.StateCode.Invalid, false) == PlayerContextStateMachine.StateCode.Invalid)
			{
				Debug.LogError("PlayerContextBase.StartGameSessionLogin LoginBySessionToken SetStateCheck fail");
				return false;
			}
			this.m_clientVersion = this.GetClientVersion();
			if (!this.m_networkClient.LoginBySessionToken(this.m_sessionToken, this.m_clientVersion, this.m_localization, this.m_loginChannelId, this.m_bornChannelId))
			{
				Debug.LogError("PlayerContextBase.StartGameSessionLogin LoginBySessionToken fail");
				return false;
			}
			return true;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00015FA0 File Offset: 0x000141A0
		public virtual bool SendPlayerInfoInitReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendPlayerInfoInitReq_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SendPlayerInfoInitReq_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00016018 File Offset: 0x00014218
		public virtual bool SendPlayerInfoReqOnReloginBySession(bool checkOnly)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendPlayerInfoReqOnReloginBySessionBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SendPlayerInfoReqOnReloginBySessionBoolean_hotfix.call(new object[]
				{
					this,
					checkOnly
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000160A0 File Offset: 0x000142A0
		public virtual bool SendWorldEnterReqOnReloginBySession()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendWorldEnterReqOnReloginBySession_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SendWorldEnterReqOnReloginBySession_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00016118 File Offset: 0x00014318
		public virtual bool CheckForSessionLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckForSessionLogin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckForSessionLogin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnSessionLoginStart, PlayerContextStateMachine.StateCode.Invalid, true) != PlayerContextStateMachine.StateCode.Invalid;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00016198 File Offset: 0x00014398
		public static string CreateFakeAuthToken(string platformUserId, string password)
		{
			return string.Format("1|{0}|{1}|{2}|Self|0|0|0", platformUserId, platformUserId, password);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000161A8 File Offset: 0x000143A8
		protected virtual string GetDeviceId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDeviceId_hotfix != null)
			{
				return (string)this.m_GetDeviceId_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00016220 File Offset: 0x00014420
		protected virtual string GetClientVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClientVersion_hotfix != null)
			{
				return (string)this.m_GetClientVersion_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00016298 File Offset: 0x00014498
		[DoNotToLua]
		public virtual void OnGameServerConnected()
		{
			Debug.Log("PlayerContextBase OnGameServerConnected");
			this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnConnected, PlayerContextStateMachine.StateCode.Invalid, false);
			if (this.EventOnGameServerConnected != null)
			{
				this.EventOnGameServerConnected();
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000162CC File Offset: 0x000144CC
		[DoNotToLua]
		public virtual void OnGameServerDisconnected()
		{
			Debug.Log("PlayerContextBase OnGameServerDisconnected");
			this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnDisconnected, PlayerContextStateMachine.StateCode.Invalid, false);
			this.m_networkClient.Close();
			if (this.EventOnGameServerDisconnected != null)
			{
				this.EventOnGameServerDisconnected();
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00016308 File Offset: 0x00014508
		[DoNotToLua]
		public virtual void OnGameServerError(int err, string excepionInfo = null)
		{
			Debug.LogError(string.Format("PlayerContextBase OnGameServerError {0}", err));
			if (excepionInfo != null)
			{
				Debug.LogError(string.Format("PlayerContextBase OnGameServerError Msg={0}", excepionInfo));
			}
			this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnDisconnected, PlayerContextStateMachine.StateCode.Invalid, false);
			if (this.EventOnGameServerNetworkError != null)
			{
				this.EventOnGameServerNetworkError();
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00016368 File Offset: 0x00014568
		[DoNotToLua]
		public virtual void OnLoginByAuthTokenAck(int result, bool needRedirect, string sessionToken)
		{
			Debug.Log(string.Format("PlayerContextBase OnLoginByAuthTokenAck result={0} sessionToken={1}", result, sessionToken));
			if (result != 0)
			{
				this.m_fsm.SetStateCheck(6, -1, false);
			}
			else
			{
				if (needRedirect)
				{
					this.m_fsm.SetStateCheck(5, -1, false);
				}
				else
				{
					this.m_fsm.SetStateCheck(4, -1, false);
				}
				this.m_sessionToken = sessionToken;
			}
			if (this.EventOnLoginByAuthTokenAck != null)
			{
				this.EventOnLoginByAuthTokenAck(result, this.m_sessionToken, needRedirect);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000163F4 File Offset: 0x000145F4
		[DoNotToLua]
		public virtual void OnLoginBySessionTokenAck(int result)
		{
			Debug.Log(string.Format("PlayerContextBase OnLoginBySessionTokenAck result={0}", result));
			if (result != 0)
			{
				this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnSessionLoginAckFail, PlayerContextStateMachine.StateCode.Invalid, false);
			}
			else
			{
				this.m_fsm.SetStateCheck(PlayerContextStateMachine.EventCode.OnSessionLoginAckOk, PlayerContextStateMachine.StateCode.Invalid, false);
			}
			if (this.EventOnLoginBySessionTokenAck != null)
			{
				this.EventOnLoginBySessionTokenAck(result);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00016458 File Offset: 0x00014658
		[DoNotToLua]
		public virtual void OnGameServerMessage(object msg, int msgId)
		{
			bool flag = BJExtensionHelper.HasExtendProtocolData(msg);
			if (flag)
			{
				this.OnGameServerMessageExtend(msg, msgId);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001647C File Offset: 0x0001467C
		[DoNotToLua]
		protected virtual void OnGameServerMessageExtend(object msg, int msgId)
		{
			Debug.LogError(string.Format("OnGameServerMessageExtend msgid={0}", msgId));
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00016494 File Offset: 0x00014694
		[DoNotToLua]
		public virtual void Tick()
		{
			DateTime currTickServerTime = this.m_currTickServerTime;
			this.m_currTickServerTime = this.GetCurrServerTime();
			if (currTickServerTime.AddMinutes(1.0) < this.m_currTickServerTime)
			{
				this.OnTimeJumped();
			}
			if (this.m_networkClient != null)
			{
				this.m_networkClient.Tick();
			}
			this.m_tinyCorutineHelper.Tick();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000164FC File Offset: 0x000146FC
		protected virtual void OnTimeJumped()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTimeJumped_hotfix != null)
			{
				this.m_OnTimeJumped_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060004F8 RID: 1272 RVA: 0x0001655C File Offset: 0x0001475C
		// (remove) Token: 0x060004F9 RID: 1273 RVA: 0x000165F8 File Offset: 0x000147F8
		public event Action EventOnGameServerConnected
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGameServerConnectedAction_hotfix != null)
				{
					this.m_add_EventOnGameServerConnectedAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerConnected;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerConnected, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGameServerConnectedAction_hotfix != null)
				{
					this.m_remove_EventOnGameServerConnectedAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerConnected;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerConnected, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060004FA RID: 1274 RVA: 0x00016694 File Offset: 0x00014894
		// (remove) Token: 0x060004FB RID: 1275 RVA: 0x00016730 File Offset: 0x00014930
		public event Action EventOnGameServerNetworkError
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGameServerNetworkErrorAction_hotfix != null)
				{
					this.m_add_EventOnGameServerNetworkErrorAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerNetworkError;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerNetworkError, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGameServerNetworkErrorAction_hotfix != null)
				{
					this.m_remove_EventOnGameServerNetworkErrorAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerNetworkError;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerNetworkError, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060004FC RID: 1276 RVA: 0x000167CC File Offset: 0x000149CC
		// (remove) Token: 0x060004FD RID: 1277 RVA: 0x00016868 File Offset: 0x00014A68
		public event Action EventOnGameServerDisconnected
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGameServerDisconnectedAction_hotfix != null)
				{
					this.m_add_EventOnGameServerDisconnectedAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerDisconnected;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerDisconnected, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGameServerDisconnectedAction_hotfix != null)
				{
					this.m_remove_EventOnGameServerDisconnectedAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerDisconnected;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerDisconnected, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060004FE RID: 1278 RVA: 0x00016904 File Offset: 0x00014B04
		// (remove) Token: 0x060004FF RID: 1279 RVA: 0x000169A0 File Offset: 0x00014BA0
		public event Func<int, string, bool, bool> EventOnLoginByAuthTokenAck
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLoginByAuthTokenAckFunc`4_hotfix != null)
				{
					this.m_add_EventOnLoginByAuthTokenAckFunc`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Func<int, string, bool, bool> func = this.EventOnLoginByAuthTokenAck;
				Func<int, string, bool, bool> func2;
				do
				{
					func2 = func;
					func = Interlocked.CompareExchange<Func<int, string, bool, bool>>(ref this.EventOnLoginByAuthTokenAck, (Func<int, string, bool, bool>)Delegate.Combine(func2, value), func);
				}
				while (func != func2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLoginByAuthTokenAckFunc`4_hotfix != null)
				{
					this.m_remove_EventOnLoginByAuthTokenAckFunc`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Func<int, string, bool, bool> func = this.EventOnLoginByAuthTokenAck;
				Func<int, string, bool, bool> func2;
				do
				{
					func2 = func;
					func = Interlocked.CompareExchange<Func<int, string, bool, bool>>(ref this.EventOnLoginByAuthTokenAck, (Func<int, string, bool, bool>)Delegate.Remove(func2, value), func);
				}
				while (func != func2);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000500 RID: 1280 RVA: 0x00016A3C File Offset: 0x00014C3C
		// (remove) Token: 0x06000501 RID: 1281 RVA: 0x00016AD8 File Offset: 0x00014CD8
		public event Func<int, bool> EventOnLoginBySessionTokenAck
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLoginBySessionTokenAckFunc`2_hotfix != null)
				{
					this.m_add_EventOnLoginBySessionTokenAckFunc`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Func<int, bool> func = this.EventOnLoginBySessionTokenAck;
				Func<int, bool> func2;
				do
				{
					func2 = func;
					func = Interlocked.CompareExchange<Func<int, bool>>(ref this.EventOnLoginBySessionTokenAck, (Func<int, bool>)Delegate.Combine(func2, value), func);
				}
				while (func != func2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLoginBySessionTokenAckFunc`2_hotfix != null)
				{
					this.m_remove_EventOnLoginBySessionTokenAckFunc`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Func<int, bool> func = this.EventOnLoginBySessionTokenAck;
				Func<int, bool> func2;
				do
				{
					func2 = func;
					func = Interlocked.CompareExchange<Func<int, bool>>(ref this.EventOnLoginBySessionTokenAck, (Func<int, bool>)Delegate.Remove(func2, value), func);
				}
				while (func != func2);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000502 RID: 1282 RVA: 0x00016B74 File Offset: 0x00014D74
		// (remove) Token: 0x06000503 RID: 1283 RVA: 0x00016C10 File Offset: 0x00014E10
		public virtual event Action EventOnGameServerDataUnsyncNotify
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGameServerDataUnsyncNotifyAction_hotfix != null)
				{
					this.m_add_EventOnGameServerDataUnsyncNotifyAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerDataUnsyncNotify;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerDataUnsyncNotify, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGameServerDataUnsyncNotifyAction_hotfix != null)
				{
					this.m_remove_EventOnGameServerDataUnsyncNotifyAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGameServerDataUnsyncNotify;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGameServerDataUnsyncNotify, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000504 RID: 1284 RVA: 0x00016CAC File Offset: 0x00014EAC
		// (remove) Token: 0x06000505 RID: 1285 RVA: 0x00016D48 File Offset: 0x00014F48
		public virtual event Action<object> EventOnPlayerInfoInitAck
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPlayerInfoInitAckAction`1_hotfix != null)
				{
					this.m_add_EventOnPlayerInfoInitAckAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<object> action = this.EventOnPlayerInfoInitAck;
				Action<object> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<object>>(ref this.EventOnPlayerInfoInitAck, (Action<object>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPlayerInfoInitAckAction`1_hotfix != null)
				{
					this.m_remove_EventOnPlayerInfoInitAckAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<object> action = this.EventOnPlayerInfoInitAck;
				Action<object> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<object>>(ref this.EventOnPlayerInfoInitAck, (Action<object>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000506 RID: 1286 RVA: 0x00016DE4 File Offset: 0x00014FE4
		// (remove) Token: 0x06000507 RID: 1287 RVA: 0x00016E80 File Offset: 0x00015080
		public virtual event Action EventOnPlayerInfoInitEnd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPlayerInfoInitEndAction_hotfix != null)
				{
					this.m_add_EventOnPlayerInfoInitEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPlayerInfoInitEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPlayerInfoInitEnd, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPlayerInfoInitEndAction_hotfix != null)
				{
					this.m_remove_EventOnPlayerInfoInitEndAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPlayerInfoInitEnd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPlayerInfoInitEnd, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00016F1C File Offset: 0x0001511C
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00016F3C File Offset: 0x0001513C
		[DoNotToLua]
		public PlayerContextBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerContextBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00016F48 File Offset: 0x00015148
		private void __callDele_EventOnGameServerConnected()
		{
			Action eventOnGameServerConnected = this.EventOnGameServerConnected;
			if (eventOnGameServerConnected != null)
			{
				eventOnGameServerConnected();
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00016F68 File Offset: 0x00015168
		private void __clearDele_EventOnGameServerConnected()
		{
			this.EventOnGameServerConnected = null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00016F74 File Offset: 0x00015174
		private void __callDele_EventOnGameServerNetworkError()
		{
			Action eventOnGameServerNetworkError = this.EventOnGameServerNetworkError;
			if (eventOnGameServerNetworkError != null)
			{
				eventOnGameServerNetworkError();
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00016F94 File Offset: 0x00015194
		private void __clearDele_EventOnGameServerNetworkError()
		{
			this.EventOnGameServerNetworkError = null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00016FA0 File Offset: 0x000151A0
		private void __callDele_EventOnGameServerDisconnected()
		{
			Action eventOnGameServerDisconnected = this.EventOnGameServerDisconnected;
			if (eventOnGameServerDisconnected != null)
			{
				eventOnGameServerDisconnected();
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00016FC0 File Offset: 0x000151C0
		private void __clearDele_EventOnGameServerDisconnected()
		{
			this.EventOnGameServerDisconnected = null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00016FCC File Offset: 0x000151CC
		private bool __callDele_EventOnLoginByAuthTokenAck(int arg1, string arg2, bool arg3)
		{
			bool result = false;
			Func<int, string, bool, bool> eventOnLoginByAuthTokenAck = this.EventOnLoginByAuthTokenAck;
			if (eventOnLoginByAuthTokenAck != null)
			{
				result = eventOnLoginByAuthTokenAck(arg1, arg2, arg3);
			}
			return result;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00016FF4 File Offset: 0x000151F4
		private void __clearDele_EventOnLoginByAuthTokenAck(int arg1, string arg2, bool arg3)
		{
			this.EventOnLoginByAuthTokenAck = null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00017000 File Offset: 0x00015200
		private bool __callDele_EventOnLoginBySessionTokenAck(int arg1)
		{
			bool result = false;
			Func<int, bool> eventOnLoginBySessionTokenAck = this.EventOnLoginBySessionTokenAck;
			if (eventOnLoginBySessionTokenAck != null)
			{
				result = eventOnLoginBySessionTokenAck(arg1);
			}
			return result;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00017028 File Offset: 0x00015228
		private void __clearDele_EventOnLoginBySessionTokenAck(int arg1)
		{
			this.EventOnLoginBySessionTokenAck = null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00017034 File Offset: 0x00015234
		private void __callDele_EventOnGameServerDataUnsyncNotify()
		{
			Action eventOnGameServerDataUnsyncNotify = this.EventOnGameServerDataUnsyncNotify;
			if (eventOnGameServerDataUnsyncNotify != null)
			{
				eventOnGameServerDataUnsyncNotify();
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00017054 File Offset: 0x00015254
		private void __clearDele_EventOnGameServerDataUnsyncNotify()
		{
			this.EventOnGameServerDataUnsyncNotify = null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00017060 File Offset: 0x00015260
		private void __callDele_EventOnPlayerInfoInitAck(object obj)
		{
			Action<object> eventOnPlayerInfoInitAck = this.EventOnPlayerInfoInitAck;
			if (eventOnPlayerInfoInitAck != null)
			{
				eventOnPlayerInfoInitAck(obj);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00017084 File Offset: 0x00015284
		private void __clearDele_EventOnPlayerInfoInitAck(object obj)
		{
			this.EventOnPlayerInfoInitAck = null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00017090 File Offset: 0x00015290
		private void __callDele_EventOnPlayerInfoInitEnd()
		{
			Action eventOnPlayerInfoInitEnd = this.EventOnPlayerInfoInitEnd;
			if (eventOnPlayerInfoInitEnd != null)
			{
				eventOnPlayerInfoInitEnd();
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000170B0 File Offset: 0x000152B0
		private void __clearDele_EventOnPlayerInfoInitEnd()
		{
			this.EventOnPlayerInfoInitEnd = null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000170BC File Offset: 0x000152BC
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
					this.m_IsInited_hotfix = (luaObj.RawGet("IsInited") as LuaFunction);
					this.m_OnPlayerInfoInitEndNtf_hotfix = (luaObj.RawGet("OnPlayerInfoInitEndNtf") as LuaFunction);
					this.m_SyncServerTimeDateTime_hotfix = (luaObj.RawGet("SyncServerTime") as LuaFunction);
					this.m_GetCurrServerTime_hotfix = (luaObj.RawGet("GetCurrServerTime") as LuaFunction);
					this.m_GetCurrTickServerTime_hotfix = (luaObj.RawGet("GetCurrTickServerTime") as LuaFunction);
					this.m_Disconnect_hotfix = (luaObj.RawGet("Disconnect") as LuaFunction);
					this.m_StartGameAuthLoginStringInt32StringStringInt32Int32_hotfix = (luaObj.RawGet("StartGameAuthLogin") as LuaFunction);
					this.m_SetSessionTokenStringInt32Int32_hotfix = (luaObj.RawGet("SetSessionToken") as LuaFunction);
					this.m_StartGameSessionLogin_hotfix = (luaObj.RawGet("StartGameSessionLogin") as LuaFunction);
					this.m_SendPlayerInfoInitReq_hotfix = (luaObj.RawGet("SendPlayerInfoInitReq") as LuaFunction);
					this.m_SendPlayerInfoReqOnReloginBySessionBoolean_hotfix = (luaObj.RawGet("SendPlayerInfoReqOnReloginBySession") as LuaFunction);
					this.m_SendWorldEnterReqOnReloginBySession_hotfix = (luaObj.RawGet("SendWorldEnterReqOnReloginBySession") as LuaFunction);
					this.m_CheckForSessionLogin_hotfix = (luaObj.RawGet("CheckForSessionLogin") as LuaFunction);
					this.m_GetDeviceId_hotfix = (luaObj.RawGet("GetDeviceId") as LuaFunction);
					this.m_GetClientVersion_hotfix = (luaObj.RawGet("GetClientVersion") as LuaFunction);
					this.m_OnTimeJumped_hotfix = (luaObj.RawGet("OnTimeJumped") as LuaFunction);
					this.m_add_EventOnGameServerConnectedAction_hotfix = (luaObj.RawGet("add_EventOnGameServerConnected") as LuaFunction);
					this.m_remove_EventOnGameServerConnectedAction_hotfix = (luaObj.RawGet("remove_EventOnGameServerConnected") as LuaFunction);
					this.m_add_EventOnGameServerNetworkErrorAction_hotfix = (luaObj.RawGet("add_EventOnGameServerNetworkError") as LuaFunction);
					this.m_remove_EventOnGameServerNetworkErrorAction_hotfix = (luaObj.RawGet("remove_EventOnGameServerNetworkError") as LuaFunction);
					this.m_add_EventOnGameServerDisconnectedAction_hotfix = (luaObj.RawGet("add_EventOnGameServerDisconnected") as LuaFunction);
					this.m_remove_EventOnGameServerDisconnectedAction_hotfix = (luaObj.RawGet("remove_EventOnGameServerDisconnected") as LuaFunction);
					this.m_add_EventOnLoginByAuthTokenAckFunc`4_hotfix = (luaObj.RawGet("add_EventOnLoginByAuthTokenAck") as LuaFunction);
					this.m_remove_EventOnLoginByAuthTokenAckFunc`4_hotfix = (luaObj.RawGet("remove_EventOnLoginByAuthTokenAck") as LuaFunction);
					this.m_add_EventOnLoginBySessionTokenAckFunc`2_hotfix = (luaObj.RawGet("add_EventOnLoginBySessionTokenAck") as LuaFunction);
					this.m_remove_EventOnLoginBySessionTokenAckFunc`2_hotfix = (luaObj.RawGet("remove_EventOnLoginBySessionTokenAck") as LuaFunction);
					this.m_add_EventOnGameServerDataUnsyncNotifyAction_hotfix = (luaObj.RawGet("add_EventOnGameServerDataUnsyncNotify") as LuaFunction);
					this.m_remove_EventOnGameServerDataUnsyncNotifyAction_hotfix = (luaObj.RawGet("remove_EventOnGameServerDataUnsyncNotify") as LuaFunction);
					this.m_add_EventOnPlayerInfoInitAckAction`1_hotfix = (luaObj.RawGet("add_EventOnPlayerInfoInitAck") as LuaFunction);
					this.m_remove_EventOnPlayerInfoInitAckAction`1_hotfix = (luaObj.RawGet("remove_EventOnPlayerInfoInitAck") as LuaFunction);
					this.m_add_EventOnPlayerInfoInitEndAction_hotfix = (luaObj.RawGet("add_EventOnPlayerInfoInitEnd") as LuaFunction);
					this.m_remove_EventOnPlayerInfoInitEndAction_hotfix = (luaObj.RawGet("remove_EventOnPlayerInfoInitEnd") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000174A8 File Offset: 0x000156A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerContextBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04000254 RID: 596
		protected IPlayerContextNetworkClient m_networkClient;

		// Token: 0x04000255 RID: 597
		protected TinyCorutineHelper m_tinyCorutineHelper = new TinyCorutineHelper();

		// Token: 0x04000256 RID: 598
		protected PlayerContextStateMachine m_fsm = new PlayerContextStateMachine();

		// Token: 0x04000257 RID: 599
		protected string m_deviceId;

		// Token: 0x04000258 RID: 600
		protected string m_clientVersion;

		// Token: 0x04000259 RID: 601
		private int m_loginChannelId;

		// Token: 0x0400025A RID: 602
		private int m_bornChannelId;

		// Token: 0x0400025B RID: 603
		private string m_localization;

		// Token: 0x0400025C RID: 604
		protected string m_sessionToken;

		// Token: 0x0400025D RID: 605
		protected bool m_inited;

		// Token: 0x0400025E RID: 606
		private DateTime? m_serverTimeSynced;

		// Token: 0x0400025F RID: 607
		private DateTime m_localTimeAtServerTimeSynced;

		// Token: 0x04000260 RID: 608
		private DateTime m_currTickServerTime = DateTime.MinValue;

		// Token: 0x04000261 RID: 609
		[DoNotToLua]
		private PlayerContextBase.LuaExportHelper luaExportHelper;

		// Token: 0x04000262 RID: 610
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04000263 RID: 611
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04000264 RID: 612
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04000265 RID: 613
		private LuaFunction m_IsInited_hotfix;

		// Token: 0x04000266 RID: 614
		private LuaFunction m_OnPlayerInfoInitEndNtf_hotfix;

		// Token: 0x04000267 RID: 615
		private LuaFunction m_SyncServerTimeDateTime_hotfix;

		// Token: 0x04000268 RID: 616
		private LuaFunction m_GetCurrServerTime_hotfix;

		// Token: 0x04000269 RID: 617
		private LuaFunction m_GetCurrTickServerTime_hotfix;

		// Token: 0x0400026A RID: 618
		private LuaFunction m_Disconnect_hotfix;

		// Token: 0x0400026B RID: 619
		private LuaFunction m_StartGameAuthLoginStringInt32StringStringInt32Int32_hotfix;

		// Token: 0x0400026C RID: 620
		private LuaFunction m_SetSessionTokenStringInt32Int32_hotfix;

		// Token: 0x0400026D RID: 621
		private LuaFunction m_StartGameSessionLogin_hotfix;

		// Token: 0x0400026E RID: 622
		private LuaFunction m_SendPlayerInfoInitReq_hotfix;

		// Token: 0x0400026F RID: 623
		private LuaFunction m_SendPlayerInfoReqOnReloginBySessionBoolean_hotfix;

		// Token: 0x04000270 RID: 624
		private LuaFunction m_SendWorldEnterReqOnReloginBySession_hotfix;

		// Token: 0x04000271 RID: 625
		private LuaFunction m_CheckForSessionLogin_hotfix;

		// Token: 0x04000272 RID: 626
		private LuaFunction m_GetDeviceId_hotfix;

		// Token: 0x04000273 RID: 627
		private LuaFunction m_GetClientVersion_hotfix;

		// Token: 0x04000274 RID: 628
		private LuaFunction m_OnTimeJumped_hotfix;

		// Token: 0x04000275 RID: 629
		private LuaFunction m_add_EventOnGameServerConnectedAction_hotfix;

		// Token: 0x04000276 RID: 630
		private LuaFunction m_remove_EventOnGameServerConnectedAction_hotfix;

		// Token: 0x04000277 RID: 631
		private LuaFunction m_add_EventOnGameServerNetworkErrorAction_hotfix;

		// Token: 0x04000278 RID: 632
		private LuaFunction m_remove_EventOnGameServerNetworkErrorAction_hotfix;

		// Token: 0x04000279 RID: 633
		private LuaFunction m_add_EventOnGameServerDisconnectedAction_hotfix;

		// Token: 0x0400027A RID: 634
		private LuaFunction m_remove_EventOnGameServerDisconnectedAction_hotfix;

		// Token: 0x0400027B RID: 635
		private LuaFunction m_add_EventOnLoginByAuthTokenAckFunc;

		// Token: 0x0400027C RID: 636
		private LuaFunction m_remove_EventOnLoginByAuthTokenAckFunc;

		// Token: 0x0400027D RID: 637
		private LuaFunction m_add_EventOnLoginBySessionTokenAckFunc;

		// Token: 0x0400027E RID: 638
		private LuaFunction m_remove_EventOnLoginBySessionTokenAckFunc;

		// Token: 0x0400027F RID: 639
		private LuaFunction m_add_EventOnGameServerDataUnsyncNotifyAction_hotfix;

		// Token: 0x04000280 RID: 640
		private LuaFunction m_remove_EventOnGameServerDataUnsyncNotifyAction_hotfix;

		// Token: 0x04000281 RID: 641
		private LuaFunction m_add_EventOnPlayerInfoInitAckAction;

		// Token: 0x04000282 RID: 642
		private LuaFunction m_remove_EventOnPlayerInfoInitAckAction;

		// Token: 0x04000283 RID: 643
		private LuaFunction m_add_EventOnPlayerInfoInitEndAction_hotfix;

		// Token: 0x04000284 RID: 644
		private LuaFunction m_remove_EventOnPlayerInfoInitEndAction_hotfix;

		// Token: 0x0200006D RID: 109
		public class LuaExportHelper
		{
			// Token: 0x0600051C RID: 1308 RVA: 0x00017510 File Offset: 0x00015710
			public LuaExportHelper(PlayerContextBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x00017520 File Offset: 0x00015720
			public void __callDele_EventOnGameServerConnected()
			{
				this.m_owner.__callDele_EventOnGameServerConnected();
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x00017530 File Offset: 0x00015730
			public void __clearDele_EventOnGameServerConnected()
			{
				this.m_owner.__clearDele_EventOnGameServerConnected();
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x00017540 File Offset: 0x00015740
			public void __callDele_EventOnGameServerNetworkError()
			{
				this.m_owner.__callDele_EventOnGameServerNetworkError();
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x00017550 File Offset: 0x00015750
			public void __clearDele_EventOnGameServerNetworkError()
			{
				this.m_owner.__clearDele_EventOnGameServerNetworkError();
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00017560 File Offset: 0x00015760
			public void __callDele_EventOnGameServerDisconnected()
			{
				this.m_owner.__callDele_EventOnGameServerDisconnected();
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00017570 File Offset: 0x00015770
			public void __clearDele_EventOnGameServerDisconnected()
			{
				this.m_owner.__clearDele_EventOnGameServerDisconnected();
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00017580 File Offset: 0x00015780
			public bool __callDele_EventOnLoginByAuthTokenAck(int arg1, string arg2, bool arg3)
			{
				return this.m_owner.__callDele_EventOnLoginByAuthTokenAck(arg1, arg2, arg3);
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x000175A0 File Offset: 0x000157A0
			public void __clearDele_EventOnLoginByAuthTokenAck(int arg1, string arg2, bool arg3)
			{
				this.m_owner.__clearDele_EventOnLoginByAuthTokenAck(arg1, arg2, arg3);
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x000175B0 File Offset: 0x000157B0
			public bool __callDele_EventOnLoginBySessionTokenAck(int arg1)
			{
				return this.m_owner.__callDele_EventOnLoginBySessionTokenAck(arg1);
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x000175D0 File Offset: 0x000157D0
			public void __clearDele_EventOnLoginBySessionTokenAck(int arg1)
			{
				this.m_owner.__clearDele_EventOnLoginBySessionTokenAck(arg1);
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x000175E0 File Offset: 0x000157E0
			public void __callDele_EventOnGameServerDataUnsyncNotify()
			{
				this.m_owner.__callDele_EventOnGameServerDataUnsyncNotify();
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x000175F0 File Offset: 0x000157F0
			public void __clearDele_EventOnGameServerDataUnsyncNotify()
			{
				this.m_owner.__clearDele_EventOnGameServerDataUnsyncNotify();
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x00017600 File Offset: 0x00015800
			public void __callDele_EventOnPlayerInfoInitAck(object obj)
			{
				this.m_owner.__callDele_EventOnPlayerInfoInitAck(obj);
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00017610 File Offset: 0x00015810
			public void __clearDele_EventOnPlayerInfoInitAck(object obj)
			{
				this.m_owner.__clearDele_EventOnPlayerInfoInitAck(obj);
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x00017620 File Offset: 0x00015820
			public void __callDele_EventOnPlayerInfoInitEnd()
			{
				this.m_owner.__callDele_EventOnPlayerInfoInitEnd();
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00017630 File Offset: 0x00015830
			public void __clearDele_EventOnPlayerInfoInitEnd()
			{
				this.m_owner.__clearDele_EventOnPlayerInfoInitEnd();
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600052D RID: 1325 RVA: 0x00017640 File Offset: 0x00015840
			// (set) Token: 0x0600052E RID: 1326 RVA: 0x00017650 File Offset: 0x00015850
			public IPlayerContextNetworkClient m_networkClient
			{
				get
				{
					return this.m_owner.m_networkClient;
				}
				set
				{
					this.m_owner.m_networkClient = value;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600052F RID: 1327 RVA: 0x00017660 File Offset: 0x00015860
			// (set) Token: 0x06000530 RID: 1328 RVA: 0x00017670 File Offset: 0x00015870
			public TinyCorutineHelper m_tinyCorutineHelper
			{
				get
				{
					return this.m_owner.m_tinyCorutineHelper;
				}
				set
				{
					this.m_owner.m_tinyCorutineHelper = value;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000531 RID: 1329 RVA: 0x00017680 File Offset: 0x00015880
			// (set) Token: 0x06000532 RID: 1330 RVA: 0x00017690 File Offset: 0x00015890
			public PlayerContextStateMachine m_fsm
			{
				get
				{
					return this.m_owner.m_fsm;
				}
				set
				{
					this.m_owner.m_fsm = value;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000533 RID: 1331 RVA: 0x000176A0 File Offset: 0x000158A0
			// (set) Token: 0x06000534 RID: 1332 RVA: 0x000176B0 File Offset: 0x000158B0
			public string m_deviceId
			{
				get
				{
					return this.m_owner.m_deviceId;
				}
				set
				{
					this.m_owner.m_deviceId = value;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000535 RID: 1333 RVA: 0x000176C0 File Offset: 0x000158C0
			// (set) Token: 0x06000536 RID: 1334 RVA: 0x000176D0 File Offset: 0x000158D0
			public string m_clientVersion
			{
				get
				{
					return this.m_owner.m_clientVersion;
				}
				set
				{
					this.m_owner.m_clientVersion = value;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000537 RID: 1335 RVA: 0x000176E0 File Offset: 0x000158E0
			// (set) Token: 0x06000538 RID: 1336 RVA: 0x000176F0 File Offset: 0x000158F0
			public int m_loginChannelId
			{
				get
				{
					return this.m_owner.m_loginChannelId;
				}
				set
				{
					this.m_owner.m_loginChannelId = value;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000539 RID: 1337 RVA: 0x00017700 File Offset: 0x00015900
			// (set) Token: 0x0600053A RID: 1338 RVA: 0x00017710 File Offset: 0x00015910
			public int m_bornChannelId
			{
				get
				{
					return this.m_owner.m_bornChannelId;
				}
				set
				{
					this.m_owner.m_bornChannelId = value;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x0600053B RID: 1339 RVA: 0x00017720 File Offset: 0x00015920
			// (set) Token: 0x0600053C RID: 1340 RVA: 0x00017730 File Offset: 0x00015930
			public string m_localization
			{
				get
				{
					return this.m_owner.m_localization;
				}
				set
				{
					this.m_owner.m_localization = value;
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600053D RID: 1341 RVA: 0x00017740 File Offset: 0x00015940
			// (set) Token: 0x0600053E RID: 1342 RVA: 0x00017750 File Offset: 0x00015950
			public string m_sessionToken
			{
				get
				{
					return this.m_owner.m_sessionToken;
				}
				set
				{
					this.m_owner.m_sessionToken = value;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600053F RID: 1343 RVA: 0x00017760 File Offset: 0x00015960
			// (set) Token: 0x06000540 RID: 1344 RVA: 0x00017770 File Offset: 0x00015970
			public bool m_inited
			{
				get
				{
					return this.m_owner.m_inited;
				}
				set
				{
					this.m_owner.m_inited = value;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000541 RID: 1345 RVA: 0x00017780 File Offset: 0x00015980
			// (set) Token: 0x06000542 RID: 1346 RVA: 0x00017790 File Offset: 0x00015990
			public DateTime? m_serverTimeSynced
			{
				get
				{
					return this.m_owner.m_serverTimeSynced;
				}
				set
				{
					this.m_owner.m_serverTimeSynced = value;
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x000177A0 File Offset: 0x000159A0
			// (set) Token: 0x06000544 RID: 1348 RVA: 0x000177B0 File Offset: 0x000159B0
			public DateTime m_localTimeAtServerTimeSynced
			{
				get
				{
					return this.m_owner.m_localTimeAtServerTimeSynced;
				}
				set
				{
					this.m_owner.m_localTimeAtServerTimeSynced = value;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000545 RID: 1349 RVA: 0x000177C0 File Offset: 0x000159C0
			// (set) Token: 0x06000546 RID: 1350 RVA: 0x000177D0 File Offset: 0x000159D0
			public DateTime m_currTickServerTime
			{
				get
				{
					return this.m_owner.m_currTickServerTime;
				}
				set
				{
					this.m_owner.m_currTickServerTime = value;
				}
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x000177E0 File Offset: 0x000159E0
			public void OnPlayerInfoInitEndNtf()
			{
				this.m_owner.OnPlayerInfoInitEndNtf();
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x000177F0 File Offset: 0x000159F0
			public void SyncServerTime(DateTime serverTime)
			{
				this.m_owner.SyncServerTime(serverTime);
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x00017800 File Offset: 0x00015A00
			public string GetDeviceId()
			{
				return this.m_owner.GetDeviceId();
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00017810 File Offset: 0x00015A10
			public string GetClientVersion()
			{
				return this.m_owner.GetClientVersion();
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x00017820 File Offset: 0x00015A20
			public void OnTimeJumped()
			{
				this.m_owner.OnTimeJumped();
			}

			// Token: 0x04000285 RID: 645
			private PlayerContextBase m_owner;
		}
	}
}
