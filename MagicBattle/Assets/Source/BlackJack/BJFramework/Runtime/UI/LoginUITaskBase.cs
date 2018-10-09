using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000F6 RID: 246
	[HotFix]
	public abstract class LoginUITaskBase : UITaskBase
	{
		// Token: 0x06000915 RID: 2325 RVA: 0x000282CC File Offset: 0x000264CC
		public LoginUITaskBase(string name) : base(name)
		{
			this.m_loginTaskState = LoginUITaskBase.LoginState.None;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00028358 File Offset: 0x00026558
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UnRegisterNetEvent();
			base.OnStop();
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000283C4 File Offset: 0x000265C4
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginTaskState == LoginUITaskBase.LoginState.None)
			{
				this.m_loginTaskState = LoginUITaskBase.LoginState.Inited;
				if (this.IsEditorTestLogin())
				{
					this.LaunchEnterGameUIWithGameSettingTokenAndServer();
				}
				else if (this.IsSDKLogin())
				{
					this.StartInitSDK();
				}
				else
				{
					this.LaunchEnterGameUIWithUIInputAccountAndServer();
				}
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00028468 File Offset: 0x00026668
		protected virtual bool IsSDKLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSDKLogin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSDKLogin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return GameManager.Instance.GameClientSetting.LoginSetting.LoginUseSDK;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000284E8 File Offset: 0x000266E8
		protected virtual bool IsEditorTestLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEditorTestLogin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEditorTestLogin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return GameManager.Instance.GameClientSetting.LoginSetting.LoginUseSettings;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00028568 File Offset: 0x00026768
		protected virtual void StartInitSDK()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartInitSDK_hotfix != null)
			{
				this.m_StartInitSDK_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.StartSDKInit;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000285D0 File Offset: 0x000267D0
		protected virtual void OnSDKInitEnd(bool isSuccess)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSDKInitEndBoolean_hotfix != null)
			{
				this.m_OnSDKInitEndBoolean_hotfix.call(new object[]
				{
					this,
					isSuccess
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.SDKInitEnd;
			if (isSuccess)
			{
				this.StartSDKLogin();
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00028654 File Offset: 0x00026854
		protected virtual void StartSDKLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartSDKLogin_hotfix != null)
			{
				this.m_StartSDKLogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.StartSDKLogin;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000286BC File Offset: 0x000268BC
		protected virtual void OnSDKLoginEnd(bool isSuccess)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSDKLoginEndBoolean_hotfix != null)
			{
				this.m_OnSDKLoginEndBoolean_hotfix.call(new object[]
				{
					this,
					isSuccess
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.SDKLoginEnd;
			if (isSuccess)
			{
				this.PostSDKLogin();
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00028740 File Offset: 0x00026940
		protected virtual void PostSDKLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostSDKLogin_hotfix != null)
			{
				this.m_PostSDKLogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsNeedSelectServer())
			{
				this.LaunchServerListUI();
				return;
			}
			string lastLoginedServerID = this.GetLastLoginedServerID();
			this.InitServerCtxByServerID(lastLoginedServerID);
			this.LaunchEnterGameUI();
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000287C8 File Offset: 0x000269C8
		protected virtual bool IsNeedSelectServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedSelectServer_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedSelectServer_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00028840 File Offset: 0x00026A40
		protected virtual void LaunchServerListUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LaunchServerListUI_hotfix != null)
			{
				this.m_LaunchServerListUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_corutineHelper.StartCorutine(this.DownloadServerList(new Action<bool>(this.OnDownloadServerListEnd)));
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000288C0 File Offset: 0x00026AC0
		protected virtual IEnumerator DownloadServerList(Action<bool> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DownloadServerListAction`1_hotfix != null)
			{
				return (IEnumerator)this.m_DownloadServerListAction`1_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00028948 File Offset: 0x00026B48
		protected virtual void OnDownloadServerListEnd(bool isSuccess)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDownloadServerListEndBoolean_hotfix != null)
			{
				this.m_OnDownloadServerListEndBoolean_hotfix.call(new object[]
				{
					this,
					isSuccess
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isSuccess)
			{
				this.ShowServerListUI();
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000289C4 File Offset: 0x00026BC4
		protected virtual void ShowServerListUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowServerListUI_hotfix != null)
			{
				this.m_ShowServerListUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00028A24 File Offset: 0x00026C24
		protected virtual void OnGameServerConfirmed(string serverId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGameServerConfirmedString_hotfix != null)
			{
				this.m_OnGameServerConfirmedString_hotfix.call(new object[]
				{
					this,
					serverId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitServerCtxByServerID(serverId);
			this.LaunchEnterGameUI();
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00028AA4 File Offset: 0x00026CA4
		protected virtual void InitServerCtxByServerID(string serverId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitServerCtxByServerIDString_hotfix != null)
			{
				this.m_InitServerCtxByServerIDString_hotfix.call(new object[]
				{
					this,
					serverId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00028B18 File Offset: 0x00026D18
		protected virtual string GetLastLoginedServerID()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastLoginedServerID_hotfix != null)
			{
				return (string)this.m_GetLastLoginedServerID_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00028B90 File Offset: 0x00026D90
		protected virtual void LaunchEnterGameUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LaunchEnterGameUI_hotfix != null)
			{
				this.m_LaunchEnterGameUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnableUIInput(false, null);
			this.ShowEnterGameUI();
			this.m_corutineHelper.StartCorutine(this.DownloadGameServerLoginAnnouncement(new Action<bool>(this.OnDownloadGameServerLoginAnnouncementEnd)));
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00028C24 File Offset: 0x00026E24
		protected virtual void LaunchEnterGameUIWithGameSettingTokenAndServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix != null)
			{
				this.m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameClientSetting gameClientSetting = GameManager.Instance.GameClientSetting;
			this.m_gameUserId = gameClientSetting.LoginSetting.LoginAccount;
			this.m_authtoken = PlayerContextBase.CreateFakeAuthToken(this.m_gameUserId, string.Empty);
			this.m_authLoginServerAddress = gameClientSetting.LoginSetting.GameServerAddress;
			this.m_authLoginServerPort = gameClientSetting.LoginSetting.GameServerPort;
			this.LaunchEnterGameUI();
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00028CE0 File Offset: 0x00026EE0
		protected virtual void LaunchEnterGameUIWithUIInputAccountAndServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix != null)
			{
				this.m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.LoadLastLoginWithUIInputInfo(out this.m_gameUserId, out this.m_authLoginServerAddress, out this.m_authLoginServerPort))
			{
				this.m_authtoken = PlayerContextBase.CreateFakeAuthToken(this.m_gameUserId, string.Empty);
			}
			this.LaunchEnterGameUI();
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00028D7C File Offset: 0x00026F7C
		protected virtual bool LoadLastLoginWithUIInputInfo(out string loginUserId, out string authLoginServerAddress, out int authLoginServerPort)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadLastLoginWithUIInputInfoString_String_Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase_LoadLastLoginWithUIInputInfo_String_String_Int32(this, this.m_LoadLastLoginWithUIInputInfoString_String_Int32__hotfix, out loginUserId, out authLoginServerAddress, out authLoginServerPort);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			throw new NotImplementedException();
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00028DE4 File Offset: 0x00026FE4
		[DebuggerHidden]
		protected virtual IEnumerator DownloadGameServerLoginAnnouncement(Action<bool> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DownloadGameServerLoginAnnouncementAction`1_hotfix != null)
			{
				return (IEnumerator)this.m_DownloadGameServerLoginAnnouncementAction`1_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITaskBase.<DownloadGameServerLoginAnnouncement>c__Iterator0 <DownloadGameServerLoginAnnouncement>c__Iterator = new LoginUITaskBase.<DownloadGameServerLoginAnnouncement>c__Iterator0();
			<DownloadGameServerLoginAnnouncement>c__Iterator.$this = this;
			return <DownloadGameServerLoginAnnouncement>c__Iterator;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00028E70 File Offset: 0x00027070
		protected virtual void OnDownloadGameServerLoginAnnouncementEnd(bool isSuccess)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDownloadGameServerLoginAnnouncementEndBoolean_hotfix != null)
			{
				this.m_OnDownloadGameServerLoginAnnouncementEndBoolean_hotfix.call(new object[]
				{
					this,
					isSuccess
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnableUIInput(true, null);
			if (isSuccess)
			{
				this.ShowGameServerLoginAnnouncementUI();
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00028EFC File Offset: 0x000270FC
		protected virtual void ShowGameServerLoginAnnouncementUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGameServerLoginAnnouncementUI_hotfix != null)
			{
				this.m_ShowGameServerLoginAnnouncementUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00028F60 File Offset: 0x00027160
		protected virtual void ShowEnterGameUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnterGameUI_hotfix != null)
			{
				this.m_ShowEnterGameUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.ReadyForEnterGame;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00028FC8 File Offset: 0x000271C8
		protected virtual void OnEnterGameConfirmed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnterGameConfirmed_hotfix != null)
			{
				this.m_OnEnterGameConfirmed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnableUIInput(false, null);
			this.m_corutineHelper.StartCorutine(this.StartLoginAgentLogin(new Action<int, string, string>(this.LoginAgentLoginEnd)));
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00029058 File Offset: 0x00027258
		protected virtual IEnumerator StartLoginAgentLogin(Action<int, string, string> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoginAgentLoginAction`3_hotfix != null)
			{
				return (IEnumerator)this.m_StartLoginAgentLoginAction`3_hotfix.call(new object[]
				{
					this,
					onEnd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.StartLoginAgentLogin;
			throw new NotImplementedException();
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000290E8 File Offset: 0x000272E8
		protected virtual void LoginAgentLoginEnd(int errCode, string loginUserId, string authToken)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoginAgentLoginEndInt32StringString_hotfix != null)
			{
				this.m_LoginAgentLoginEndInt32StringString_hotfix.call(new object[]
				{
					this,
					errCode,
					loginUserId,
					authToken
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.LoginAgentLoginEnd;
			if (errCode == 0)
			{
				this.m_authtoken = authToken;
				this.m_gameUserId = loginUserId;
				this.StartAuthLogin();
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0002919C File Offset: 0x0002739C
		protected virtual void StartAuthLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartAuthLogin_hotfix != null)
			{
				this.m_StartAuthLogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loginTaskState = LoginUITaskBase.LoginState.StartAuthLogin;
			if (!GameManager.Instance.InitlizeBeforeGameAuthLogin(this.m_gameUserId))
			{
				global::Debug.LogError(string.Format("InitlizeBeforeGameServerLogin fail", this.m_authLoginServerAddress, this.m_authLoginServerPort, this.m_authtoken));
				this.ClearGameServerLoginState();
				return;
			}
			this.RegisterNetEvent();
			PlayerContextBase playerContext = GameManager.Instance.PlayerContext;
			if (!playerContext.StartGameAuthLogin(this.m_authLoginServerAddress, this.m_authLoginServerPort, this.m_authtoken, string.Empty, this.m_loginChannelId, this.m_bornChannelId))
			{
				global::Debug.LogError(string.Format("StartAuthLogin fail {0} {1} {2}", this.m_authLoginServerAddress, this.m_authLoginServerPort, this.m_authtoken));
				this.ClearGameServerLoginState();
				return;
			}
			this.StartWaitingMsgAck(this.m_timeoutDelayTime);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000292C4 File Offset: 0x000274C4
		protected virtual void StartSessionLogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartSessionLogin_hotfix != null)
			{
				this.m_StartSessionLogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("StartSessionLogin");
			this.m_loginTaskState = LoginUITaskBase.LoginState.StartSessionLogin;
			PlayerContextBase playerContext = GameManager.Instance.PlayerContext;
			if (playerContext == null)
			{
				if (!GameManager.Instance.InitlizeBeforeGameAuthLogin(this.m_gameUserId))
				{
					global::Debug.LogError(string.Format("InitlizeBeforeGameServerLogin fail", this.m_authLoginServerAddress, this.m_authLoginServerPort, this.m_authtoken));
					this.ClearGameServerLoginState();
					return;
				}
				this.RegisterNetEvent();
				playerContext = GameManager.Instance.PlayerContext;
				playerContext.SetSessionToken(this.m_lastSessionToken, this.m_loginChannelId, this.m_bornChannelId);
			}
			if (!playerContext.StartGameSessionLogin())
			{
				global::Debug.LogError("StartGameSessionLogin fail");
				this.ClearGameServerLoginState();
				return;
			}
			this.StartWaitingMsgAck(this.m_timeoutDelayTime);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000293E0 File Offset: 0x000275E0
		protected virtual void StartPlayerInfoInitReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartPlayerInfoInitReq_hotfix != null)
			{
				this.m_StartPlayerInfoInitReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00029440 File Offset: 0x00027640
		protected virtual void LauncheMainUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LauncheMainUI_hotfix != null)
			{
				this.m_LauncheMainUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000294A4 File Offset: 0x000276A4
		protected virtual void OnWaitingMsgAckOutTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWaitingMsgAckOutTime_hotfix != null)
			{
				this.m_OnWaitingMsgAckOutTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00029508 File Offset: 0x00027708
		protected void StartWaitingMsgAck(float waitTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartWaitingMsgAckSingle_hotfix != null)
			{
				this.m_StartWaitingMsgAckSingle_hotfix.call(new object[]
				{
					this,
					waitTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isWaitingForMsgAck = true;
			this.m_timeOutTime = Timer.m_currTime.AddSeconds((double)waitTime);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00029594 File Offset: 0x00027794
		protected void StopWaitingMsgAck()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopWaitingMsgAck_hotfix != null)
			{
				this.m_StopWaitingMsgAck_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isWaitingForMsgAck = false;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000295FC File Offset: 0x000277FC
		protected void ClearGameServerLoginState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGameServerLoginState_hotfix != null)
			{
				this.m_ClearGameServerLoginState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnableUIInput(true, null);
			this.m_loginTaskState = LoginUITaskBase.LoginState.ReadyForEnterGame;
			GameManager.Instance.Clear4Return2Login(false);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00029680 File Offset: 0x00027880
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_isWaitingForMsgAck && Timer.m_currTime > this.m_timeOutTime)
			{
				this.m_isWaitingForMsgAck = false;
				this.OnWaitingMsgAckOutTime();
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00029714 File Offset: 0x00027914
		protected virtual void OnGameServerConnected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGameServerConnected_hotfix != null)
			{
				this.m_OnGameServerConnected_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00029778 File Offset: 0x00027978
		protected virtual void OnGameServerDisconnected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGameServerDisconnected_hotfix != null)
			{
				this.m_OnGameServerDisconnected_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_loginTaskState == LoginUITaskBase.LoginState.RedirectWaitDisconnect)
			{
				this.StartSessionLogin();
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000297F0 File Offset: 0x000279F0
		protected virtual void OnGameServerNetworkError()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGameServerNetworkError_hotfix != null)
			{
				this.m_OnGameServerNetworkError_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00029854 File Offset: 0x00027A54
		protected virtual bool OnLoginByAuthTokenAck(int ret, string sessionToken, bool needRedirect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix.call(new object[]
				{
					this,
					ret,
					sessionToken,
					needRedirect
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("OnLoginByAuthTokenAck ret {0} sessionToken {1}", ret, sessionToken));
			if (this.m_loginTaskState != LoginUITaskBase.LoginState.StartAuthLogin)
			{
				global::Debug.LogError(string.Format("OnLoginByAuthTokenAck state error", new object[0]));
				return false;
			}
			this.StopWaitingMsgAck();
			this.m_loginTaskState = LoginUITaskBase.LoginState.AuthLoginEnd;
			if (ret != 0)
			{
				this.ClearGameServerLoginState();
				return false;
			}
			if (needRedirect)
			{
				this.m_loginTaskState = LoginUITaskBase.LoginState.RedirectWaitDisconnect;
				GameManager.Instance.PlayerContext.Disconnect();
				return true;
			}
			this.StartPlayerInfoInitReq();
			return true;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00029970 File Offset: 0x00027B70
		protected virtual bool OnLoginBySessionTokenAck(int ret)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginBySessionTokenAckInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnLoginBySessionTokenAckInt32_hotfix.call(new object[]
				{
					this,
					ret
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("LoginUITaskBase.OnLoginBySessionTokenAck:    " + ret);
			if (this.m_loginTaskState != LoginUITaskBase.LoginState.StartSessionLogin)
			{
				global::Debug.LogError(string.Format("LoginUITaskBase.OnLoginBySessionTokenAck state error", new object[0]));
				return false;
			}
			this.StopWaitingMsgAck();
			this.m_loginTaskState = LoginUITaskBase.LoginState.SessionLoginEnd;
			if (ret != 0)
			{
				this.ClearGameServerLoginState();
				global::Debug.LogError(string.Format("LoginUITaskBase.OnLoginBySessionTokenAck fail ret={0}", ret));
				return false;
			}
			this.StartPlayerInfoInitReq();
			return true;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00029A60 File Offset: 0x00027C60
		protected virtual void OnConfigDataMD5InfoNtf(string fileNameWithErrorMD5, string localMD5, string serverMD5)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfigDataMD5InfoNtfStringStringString_hotfix != null)
			{
				this.m_OnConfigDataMD5InfoNtfStringStringString_hotfix.call(new object[]
				{
					this,
					fileNameWithErrorMD5,
					localMD5,
					serverMD5
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError(string.Format("{0} MD5 Not Match!Local MD5 {1}, Server MD5 {2}", fileNameWithErrorMD5, localMD5, serverMD5));
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00029B04 File Offset: 0x00027D04
		protected virtual void OnPlayerInfoInitEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerInfoInitEnd_hotfix != null)
			{
				this.m_OnPlayerInfoInitEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00029B64 File Offset: 0x00027D64
		private void RegisterNetEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterNetEvent_hotfix != null)
			{
				this.m_RegisterNetEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerContextBase playerContext = GameManager.Instance.PlayerContext;
			playerContext.EventOnGameServerConnected += this.OnGameServerConnected;
			playerContext.EventOnGameServerDisconnected += this.OnGameServerDisconnected;
			playerContext.EventOnGameServerNetworkError += this.OnGameServerNetworkError;
			playerContext.EventOnLoginByAuthTokenAck += this.OnLoginByAuthTokenAck;
			playerContext.EventOnLoginBySessionTokenAck += this.OnLoginBySessionTokenAck;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00029C30 File Offset: 0x00027E30
		private void UnRegisterNetEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnRegisterNetEvent_hotfix != null)
			{
				this.m_UnRegisterNetEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerContextBase playerContext = GameManager.Instance.PlayerContext;
			if (playerContext != null)
			{
				playerContext.EventOnGameServerConnected -= this.OnGameServerConnected;
				playerContext.EventOnGameServerDisconnected -= this.OnGameServerDisconnected;
				playerContext.EventOnGameServerNetworkError -= this.OnGameServerNetworkError;
				playerContext.EventOnLoginByAuthTokenAck -= this.OnLoginByAuthTokenAck;
				playerContext.EventOnLoginBySessionTokenAck -= this.OnLoginBySessionTokenAck;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00029D00 File Offset: 0x00027F00
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00029D20 File Offset: 0x00027F20
		[DoNotToLua]
		public new LoginUITaskBase.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LoginUITaskBase.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00029D2C File Offset: 0x00027F2C
		private void __callBase_InitlizeBeforeManagerStartIt()
		{
			base.InitlizeBeforeManagerStartIt();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00029D34 File Offset: 0x00027F34
		private void __callBase_PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
		{
			base.PrepareForStartOrResume(intent, onPrepareEnd);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00029D40 File Offset: 0x00027F40
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00029D4C File Offset: 0x00027F4C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00029D58 File Offset: 0x00027F58
		private UITaskPipeLineCtx __callBase_GetPipeLineCtx()
		{
			return base.GetPipeLineCtx();
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00029D60 File Offset: 0x00027F60
		private UITaskPipeLineCtx __callBase_CreatePipeLineCtx()
		{
			return base.CreatePipeLineCtx();
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00029D68 File Offset: 0x00027F68
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00029D70 File Offset: 0x00027F70
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00029D78 File Offset: 0x00027F78
		private bool __callBase_OnResume(object param)
		{
			return base.OnResume(param);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00029D84 File Offset: 0x00027F84
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00029D90 File Offset: 0x00027F90
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00029D9C File Offset: 0x00027F9C
		private bool __callBase_StartUpdatePipeLine(UIIntent intent, bool onlyUpdateView, bool canBeSkip, bool enableQueue)
		{
			return base.StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00029DAC File Offset: 0x00027FAC
		private bool __callBase_NeedSkipUpdatePipeLine(UIIntent intent, bool onlyUpdateView)
		{
			return base.NeedSkipUpdatePipeLine(intent, onlyUpdateView);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00029DB8 File Offset: 0x00027FB8
		private bool __callBase_IsNeedUpdateDataCache()
		{
			return base.IsNeedUpdateDataCache();
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00029DC0 File Offset: 0x00027FC0
		private void __callBase_UpdateDataCache()
		{
			base.UpdateDataCache();
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00029DC8 File Offset: 0x00027FC8
		private bool __callBase_IsNeedLoadStaticRes()
		{
			return base.IsNeedLoadStaticRes();
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00029DD0 File Offset: 0x00027FD0
		private void __callBase_StartLoadStaticRes()
		{
			base.StartLoadStaticRes();
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00029DD8 File Offset: 0x00027FD8
		private void __callBase_CheckLayerDescArray(List<UITaskBase.LayerDesc> layerDescArray)
		{
			base.CheckLayerDescArray(layerDescArray);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00029DE4 File Offset: 0x00027FE4
		private void __callBase_OnLoadStaticResCompleted()
		{
			base.OnLoadStaticResCompleted();
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00029DEC File Offset: 0x00027FEC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00029DF4 File Offset: 0x00027FF4
		private void __callBase_StartLoadDynamicRes()
		{
			base.StartLoadDynamicRes();
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00029DFC File Offset: 0x00027FFC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00029E04 File Offset: 0x00028004
		private List<UITaskBase.LayerDesc> __callBase_CollectAllStaticResDescForLoad()
		{
			return base.CollectAllStaticResDescForLoad();
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00029E0C File Offset: 0x0002800C
		private HashSet<string> __callBase_CalculateDynamicResReallyNeedLoad(List<string> resPathList)
		{
			return base.CalculateDynamicResReallyNeedLoad(resPathList);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00029E18 File Offset: 0x00028018
		private void __callBase_OnLoadDynamicResCompleted()
		{
			base.OnLoadDynamicResCompleted();
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00029E20 File Offset: 0x00028020
		private void __callBase_RedirectPipLineOnAllResReady(Action callBack)
		{
			base.RedirectPipLineOnAllResReady(callBack);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00029E2C File Offset: 0x0002802C
		private void __callBase_OnLoadAllResCompleted()
		{
			base.OnLoadAllResCompleted();
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00029E34 File Offset: 0x00028034
		private void __callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted()
		{
			base.ReturnFromRedirectPipLineOnLoadAllResCompleted();
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00029E3C File Offset: 0x0002803C
		private void __callBase_InitLayerStateOnLoadAllResCompleted()
		{
			base.InitLayerStateOnLoadAllResCompleted();
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00029E44 File Offset: 0x00028044
		private void __callBase_InitAllUIControllers()
		{
			base.InitAllUIControllers();
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00029E4C File Offset: 0x0002804C
		private void __callBase_PostOnLoadAllResCompleted()
		{
			base.PostOnLoadAllResCompleted();
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00029E54 File Offset: 0x00028054
		private bool __callBase_IsLoadAllResCompleted()
		{
			return base.IsLoadAllResCompleted();
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00029E5C File Offset: 0x0002805C
		private void __callBase_StartUpdateView()
		{
			base.StartUpdateView();
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00029E64 File Offset: 0x00028064
		private void __callBase_UpdateView()
		{
			base.UpdateView();
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00029E6C File Offset: 0x0002806C
		private void __callBase_RegUpdateViewPlayingEffect(string name, int timeout, Action<string> onTimeOut)
		{
			base.RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00029E78 File Offset: 0x00028078
		private void __callBase_UnregUpdateViewPlayingEffect(string name, bool isTimeOut)
		{
			base.UnregUpdateViewPlayingEffect(name, isTimeOut);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00029E84 File Offset: 0x00028084
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00029E8C File Offset: 0x0002808C
		private void __callBase_PostUpdateViewBeforeClearContext()
		{
			base.PostUpdateViewBeforeClearContext();
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00029E94 File Offset: 0x00028094
		private void __callBase_HideAllView()
		{
			base.HideAllView();
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00029E9C File Offset: 0x0002809C
		private void __callBase_ClearAllContextAndRes()
		{
			base.ClearAllContextAndRes();
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00029EA4 File Offset: 0x000280A4
		private void __callBase_SaveContextInIntentOnPause()
		{
			base.SaveContextInIntentOnPause();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00029EAC File Offset: 0x000280AC
		private void __callBase_ClearContextOnPause()
		{
			base.ClearContextOnPause();
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00029EB4 File Offset: 0x000280B4
		private void __callBase_ClearContextOnIntentChange(UIIntent newIntent)
		{
			base.ClearContextOnIntentChange(newIntent);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00029EC0 File Offset: 0x000280C0
		private void __callBase_ClearContextOnUpdateViewEnd()
		{
			base.ClearContextOnUpdateViewEnd();
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00029EC8 File Offset: 0x000280C8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00029ED4 File Offset: 0x000280D4
		private UITaskBase.LayerDesc __callBase_GetLayerDescByName(string name)
		{
			return base.GetLayerDescByName(name);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00029EE0 File Offset: 0x000280E0
		private SceneLayerBase __callBase_GetLayerByName(string name)
		{
			return base.GetLayerByName(name);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00029EEC File Offset: 0x000280EC
		private void __callBase_RegisterModesDefine(string defaultMode, string[] modes)
		{
			base.RegisterModesDefine(defaultMode, modes);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00029EF8 File Offset: 0x000280F8
		private bool __callBase_SetCurrentMode(string mode)
		{
			return base.SetCurrentMode(mode);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00029F04 File Offset: 0x00028104
		private void __callBase_SetIsNeedPauseTimeOut(bool isNeed)
		{
			base.SetIsNeedPauseTimeOut(isNeed);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00029F10 File Offset: 0x00028110
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00029F18 File Offset: 0x00028118
		private void __callBase_PostDelayTimeExecuteAction(Action action, float delaySeconds)
		{
			base.PostDelayTimeExecuteAction(action, delaySeconds);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00029F24 File Offset: 0x00028124
		private void __callBase_PostDelayTicksExecuteAction(Action action, ulong delayTickCount)
		{
			base.PostDelayTicksExecuteAction(action, delayTickCount);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00029F30 File Offset: 0x00028130
		private void __callBase_SetTag(string tag)
		{
			base.SetTag(tag);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00029F3C File Offset: 0x0002813C
		private bool __callBase_HasTag(string tag)
		{
			return base.HasTag(tag);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00029F48 File Offset: 0x00028148
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_IsSDKLogin_hotfix = (luaObj.RawGet("IsSDKLogin") as LuaFunction);
					this.m_IsEditorTestLogin_hotfix = (luaObj.RawGet("IsEditorTestLogin") as LuaFunction);
					this.m_StartInitSDK_hotfix = (luaObj.RawGet("StartInitSDK") as LuaFunction);
					this.m_OnSDKInitEndBoolean_hotfix = (luaObj.RawGet("OnSDKInitEnd") as LuaFunction);
					this.m_StartSDKLogin_hotfix = (luaObj.RawGet("StartSDKLogin") as LuaFunction);
					this.m_OnSDKLoginEndBoolean_hotfix = (luaObj.RawGet("OnSDKLoginEnd") as LuaFunction);
					this.m_PostSDKLogin_hotfix = (luaObj.RawGet("PostSDKLogin") as LuaFunction);
					this.m_IsNeedSelectServer_hotfix = (luaObj.RawGet("IsNeedSelectServer") as LuaFunction);
					this.m_LaunchServerListUI_hotfix = (luaObj.RawGet("LaunchServerListUI") as LuaFunction);
					this.m_DownloadServerListAction`1_hotfix = (luaObj.RawGet("DownloadServerList") as LuaFunction);
					this.m_OnDownloadServerListEndBoolean_hotfix = (luaObj.RawGet("OnDownloadServerListEnd") as LuaFunction);
					this.m_ShowServerListUI_hotfix = (luaObj.RawGet("ShowServerListUI") as LuaFunction);
					this.m_OnGameServerConfirmedString_hotfix = (luaObj.RawGet("OnGameServerConfirmed") as LuaFunction);
					this.m_InitServerCtxByServerIDString_hotfix = (luaObj.RawGet("InitServerCtxByServerID") as LuaFunction);
					this.m_GetLastLoginedServerID_hotfix = (luaObj.RawGet("GetLastLoginedServerID") as LuaFunction);
					this.m_LaunchEnterGameUI_hotfix = (luaObj.RawGet("LaunchEnterGameUI") as LuaFunction);
					this.m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix = (luaObj.RawGet("LaunchEnterGameUIWithGameSettingTokenAndServer") as LuaFunction);
					this.m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix = (luaObj.RawGet("LaunchEnterGameUIWithUIInputAccountAndServer") as LuaFunction);
					this.m_LoadLastLoginWithUIInputInfoString_String_Int32__hotfix = (luaObj.RawGet("LoadLastLoginWithUIInputInfo") as LuaFunction);
					this.m_DownloadGameServerLoginAnnouncementAction`1_hotfix = (luaObj.RawGet("DownloadGameServerLoginAnnouncement") as LuaFunction);
					this.m_OnDownloadGameServerLoginAnnouncementEndBoolean_hotfix = (luaObj.RawGet("OnDownloadGameServerLoginAnnouncementEnd") as LuaFunction);
					this.m_ShowGameServerLoginAnnouncementUI_hotfix = (luaObj.RawGet("ShowGameServerLoginAnnouncementUI") as LuaFunction);
					this.m_ShowEnterGameUI_hotfix = (luaObj.RawGet("ShowEnterGameUI") as LuaFunction);
					this.m_OnEnterGameConfirmed_hotfix = (luaObj.RawGet("OnEnterGameConfirmed") as LuaFunction);
					this.m_StartLoginAgentLoginAction`3_hotfix = (luaObj.RawGet("StartLoginAgentLogin") as LuaFunction);
					this.m_LoginAgentLoginEndInt32StringString_hotfix = (luaObj.RawGet("LoginAgentLoginEnd") as LuaFunction);
					this.m_StartAuthLogin_hotfix = (luaObj.RawGet("StartAuthLogin") as LuaFunction);
					this.m_StartSessionLogin_hotfix = (luaObj.RawGet("StartSessionLogin") as LuaFunction);
					this.m_StartPlayerInfoInitReq_hotfix = (luaObj.RawGet("StartPlayerInfoInitReq") as LuaFunction);
					this.m_LauncheMainUI_hotfix = (luaObj.RawGet("LauncheMainUI") as LuaFunction);
					this.m_OnWaitingMsgAckOutTime_hotfix = (luaObj.RawGet("OnWaitingMsgAckOutTime") as LuaFunction);
					this.m_StartWaitingMsgAckSingle_hotfix = (luaObj.RawGet("StartWaitingMsgAck") as LuaFunction);
					this.m_StopWaitingMsgAck_hotfix = (luaObj.RawGet("StopWaitingMsgAck") as LuaFunction);
					this.m_ClearGameServerLoginState_hotfix = (luaObj.RawGet("ClearGameServerLoginState") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_OnGameServerConnected_hotfix = (luaObj.RawGet("OnGameServerConnected") as LuaFunction);
					this.m_OnGameServerDisconnected_hotfix = (luaObj.RawGet("OnGameServerDisconnected") as LuaFunction);
					this.m_OnGameServerNetworkError_hotfix = (luaObj.RawGet("OnGameServerNetworkError") as LuaFunction);
					this.m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix = (luaObj.RawGet("OnLoginByAuthTokenAck") as LuaFunction);
					this.m_OnLoginBySessionTokenAckInt32_hotfix = (luaObj.RawGet("OnLoginBySessionTokenAck") as LuaFunction);
					this.m_OnConfigDataMD5InfoNtfStringStringString_hotfix = (luaObj.RawGet("OnConfigDataMD5InfoNtf") as LuaFunction);
					this.m_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("OnPlayerInfoInitEnd") as LuaFunction);
					this.m_RegisterNetEvent_hotfix = (luaObj.RawGet("RegisterNetEvent") as LuaFunction);
					this.m_UnRegisterNetEvent_hotfix = (luaObj.RawGet("UnRegisterNetEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002A494 File Offset: 0x00028694
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginUITaskBase));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040005B8 RID: 1464
		protected LoginUITaskBase.LoginState m_loginTaskState;

		// Token: 0x040005B9 RID: 1465
		protected string m_authLoginServerAddress;

		// Token: 0x040005BA RID: 1466
		protected int m_authLoginServerPort;

		// Token: 0x040005BB RID: 1467
		protected string m_authtoken;

		// Token: 0x040005BC RID: 1468
		protected string m_gameUserId;

		// Token: 0x040005BD RID: 1469
		protected int m_loginChannelId;

		// Token: 0x040005BE RID: 1470
		protected int m_bornChannelId;

		// Token: 0x040005BF RID: 1471
		protected string m_lastSessionToken;

		// Token: 0x040005C0 RID: 1472
		protected bool m_isWaitingForMsgAck;

		// Token: 0x040005C1 RID: 1473
		protected DateTime m_timeOutTime;

		// Token: 0x040005C2 RID: 1474
		protected float m_timeoutDelayTime = 10f;

		// Token: 0x040005C3 RID: 1475
		[DoNotToLua]
		private LoginUITaskBase.LuaExportHelper luaExportHelper;

		// Token: 0x040005C4 RID: 1476
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040005C5 RID: 1477
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040005C6 RID: 1478
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040005C7 RID: 1479
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x040005C8 RID: 1480
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x040005C9 RID: 1481
		private LuaFunction m_IsSDKLogin_hotfix;

		// Token: 0x040005CA RID: 1482
		private LuaFunction m_IsEditorTestLogin_hotfix;

		// Token: 0x040005CB RID: 1483
		private LuaFunction m_StartInitSDK_hotfix;

		// Token: 0x040005CC RID: 1484
		private LuaFunction m_OnSDKInitEndBoolean_hotfix;

		// Token: 0x040005CD RID: 1485
		private LuaFunction m_StartSDKLogin_hotfix;

		// Token: 0x040005CE RID: 1486
		private LuaFunction m_OnSDKLoginEndBoolean_hotfix;

		// Token: 0x040005CF RID: 1487
		private LuaFunction m_PostSDKLogin_hotfix;

		// Token: 0x040005D0 RID: 1488
		private LuaFunction m_IsNeedSelectServer_hotfix;

		// Token: 0x040005D1 RID: 1489
		private LuaFunction m_LaunchServerListUI_hotfix;

		// Token: 0x040005D2 RID: 1490
		private LuaFunction m_DownloadServerListAction;

		// Token: 0x040005D3 RID: 1491
		private LuaFunction m_OnDownloadServerListEndBoolean_hotfix;

		// Token: 0x040005D4 RID: 1492
		private LuaFunction m_ShowServerListUI_hotfix;

		// Token: 0x040005D5 RID: 1493
		private LuaFunction m_OnGameServerConfirmedString_hotfix;

		// Token: 0x040005D6 RID: 1494
		private LuaFunction m_InitServerCtxByServerIDString_hotfix;

		// Token: 0x040005D7 RID: 1495
		private LuaFunction m_GetLastLoginedServerID_hotfix;

		// Token: 0x040005D8 RID: 1496
		private LuaFunction m_LaunchEnterGameUI_hotfix;

		// Token: 0x040005D9 RID: 1497
		private LuaFunction m_LaunchEnterGameUIWithGameSettingTokenAndServer_hotfix;

		// Token: 0x040005DA RID: 1498
		private LuaFunction m_LaunchEnterGameUIWithUIInputAccountAndServer_hotfix;

		// Token: 0x040005DB RID: 1499
		private LuaFunction m_LoadLastLoginWithUIInputInfoString_String_Int32__hotfix;

		// Token: 0x040005DC RID: 1500
		private LuaFunction m_DownloadGameServerLoginAnnouncementAction;

		// Token: 0x040005DD RID: 1501
		private LuaFunction m_OnDownloadGameServerLoginAnnouncementEndBoolean_hotfix;

		// Token: 0x040005DE RID: 1502
		private LuaFunction m_ShowGameServerLoginAnnouncementUI_hotfix;

		// Token: 0x040005DF RID: 1503
		private LuaFunction m_ShowEnterGameUI_hotfix;

		// Token: 0x040005E0 RID: 1504
		private LuaFunction m_OnEnterGameConfirmed_hotfix;

		// Token: 0x040005E1 RID: 1505
		private LuaFunction m_StartLoginAgentLoginAction;

		// Token: 0x040005E2 RID: 1506
		private LuaFunction m_LoginAgentLoginEndInt32StringString_hotfix;

		// Token: 0x040005E3 RID: 1507
		private LuaFunction m_StartAuthLogin_hotfix;

		// Token: 0x040005E4 RID: 1508
		private LuaFunction m_StartSessionLogin_hotfix;

		// Token: 0x040005E5 RID: 1509
		private LuaFunction m_StartPlayerInfoInitReq_hotfix;

		// Token: 0x040005E6 RID: 1510
		private LuaFunction m_LauncheMainUI_hotfix;

		// Token: 0x040005E7 RID: 1511
		private LuaFunction m_OnWaitingMsgAckOutTime_hotfix;

		// Token: 0x040005E8 RID: 1512
		private LuaFunction m_StartWaitingMsgAckSingle_hotfix;

		// Token: 0x040005E9 RID: 1513
		private LuaFunction m_StopWaitingMsgAck_hotfix;

		// Token: 0x040005EA RID: 1514
		private LuaFunction m_ClearGameServerLoginState_hotfix;

		// Token: 0x040005EB RID: 1515
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x040005EC RID: 1516
		private LuaFunction m_OnGameServerConnected_hotfix;

		// Token: 0x040005ED RID: 1517
		private LuaFunction m_OnGameServerDisconnected_hotfix;

		// Token: 0x040005EE RID: 1518
		private LuaFunction m_OnGameServerNetworkError_hotfix;

		// Token: 0x040005EF RID: 1519
		private LuaFunction m_OnLoginByAuthTokenAckInt32StringBoolean_hotfix;

		// Token: 0x040005F0 RID: 1520
		private LuaFunction m_OnLoginBySessionTokenAckInt32_hotfix;

		// Token: 0x040005F1 RID: 1521
		private LuaFunction m_OnConfigDataMD5InfoNtfStringStringString_hotfix;

		// Token: 0x040005F2 RID: 1522
		private LuaFunction m_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x040005F3 RID: 1523
		private LuaFunction m_RegisterNetEvent_hotfix;

		// Token: 0x040005F4 RID: 1524
		private LuaFunction m_UnRegisterNetEvent_hotfix;

		// Token: 0x020000F7 RID: 247
		public enum LoginState
		{
			// Token: 0x040005F6 RID: 1526
			None,
			// Token: 0x040005F7 RID: 1527
			Inited,
			// Token: 0x040005F8 RID: 1528
			StartSDKInit,
			// Token: 0x040005F9 RID: 1529
			SDKInitEnd,
			// Token: 0x040005FA RID: 1530
			StartSDKLogin,
			// Token: 0x040005FB RID: 1531
			SDKLoginEnd,
			// Token: 0x040005FC RID: 1532
			ReadyForEnterGame,
			// Token: 0x040005FD RID: 1533
			StartLoginAgentLogin,
			// Token: 0x040005FE RID: 1534
			LoginAgentLoginEnd,
			// Token: 0x040005FF RID: 1535
			StartAuthLogin,
			// Token: 0x04000600 RID: 1536
			AuthLoginEnd,
			// Token: 0x04000601 RID: 1537
			RedirectWaitDisconnect,
			// Token: 0x04000602 RID: 1538
			StartSessionLogin,
			// Token: 0x04000603 RID: 1539
			SessionLoginEnd,
			// Token: 0x04000604 RID: 1540
			StartPlayerInfoInit,
			// Token: 0x04000605 RID: 1541
			ReadyForCharacterUI
		}

		// Token: 0x020000F8 RID: 248
		public new class LuaExportHelper
		{
			// Token: 0x0600097F RID: 2431 RVA: 0x0002A4FC File Offset: 0x000286FC
			public LuaExportHelper(LoginUITaskBase owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000980 RID: 2432 RVA: 0x0002A50C File Offset: 0x0002870C
			public void __callBase_InitlizeBeforeManagerStartIt()
			{
				this.m_owner.__callBase_InitlizeBeforeManagerStartIt();
			}

			// Token: 0x06000981 RID: 2433 RVA: 0x0002A51C File Offset: 0x0002871C
			public void __callBase_PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
			{
				this.m_owner.__callBase_PrepareForStartOrResume(intent, onPrepareEnd);
			}

			// Token: 0x06000982 RID: 2434 RVA: 0x0002A52C File Offset: 0x0002872C
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x0002A53C File Offset: 0x0002873C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x0002A54C File Offset: 0x0002874C
			public UITaskPipeLineCtx __callBase_GetPipeLineCtx()
			{
				return this.m_owner.__callBase_GetPipeLineCtx();
			}

			// Token: 0x06000985 RID: 2437 RVA: 0x0002A55C File Offset: 0x0002875C
			public UITaskPipeLineCtx __callBase_CreatePipeLineCtx()
			{
				return this.m_owner.__callBase_CreatePipeLineCtx();
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x0002A56C File Offset: 0x0002876C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06000987 RID: 2439 RVA: 0x0002A57C File Offset: 0x0002877C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06000988 RID: 2440 RVA: 0x0002A58C File Offset: 0x0002878C
			public bool __callBase_OnResume(object param)
			{
				return this.m_owner.__callBase_OnResume(param);
			}

			// Token: 0x06000989 RID: 2441 RVA: 0x0002A59C File Offset: 0x0002879C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x0002A5AC File Offset: 0x000287AC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600098B RID: 2443 RVA: 0x0002A5BC File Offset: 0x000287BC
			public bool __callBase_StartUpdatePipeLine(UIIntent intent, bool onlyUpdateView, bool canBeSkip, bool enableQueue)
			{
				return this.m_owner.__callBase_StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
			}

			// Token: 0x0600098C RID: 2444 RVA: 0x0002A5D0 File Offset: 0x000287D0
			public bool __callBase_NeedSkipUpdatePipeLine(UIIntent intent, bool onlyUpdateView)
			{
				return this.m_owner.__callBase_NeedSkipUpdatePipeLine(intent, onlyUpdateView);
			}

			// Token: 0x0600098D RID: 2445 RVA: 0x0002A5E0 File Offset: 0x000287E0
			public bool __callBase_IsNeedUpdateDataCache()
			{
				return this.m_owner.__callBase_IsNeedUpdateDataCache();
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x0002A5F0 File Offset: 0x000287F0
			public void __callBase_UpdateDataCache()
			{
				this.m_owner.__callBase_UpdateDataCache();
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x0002A600 File Offset: 0x00028800
			public bool __callBase_IsNeedLoadStaticRes()
			{
				return this.m_owner.__callBase_IsNeedLoadStaticRes();
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x0002A610 File Offset: 0x00028810
			public void __callBase_StartLoadStaticRes()
			{
				this.m_owner.__callBase_StartLoadStaticRes();
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x0002A620 File Offset: 0x00028820
			public void __callBase_CheckLayerDescArray(List<UITaskBase.LayerDesc> layerDescArray)
			{
				this.m_owner.__callBase_CheckLayerDescArray(layerDescArray);
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x0002A630 File Offset: 0x00028830
			public void __callBase_OnLoadStaticResCompleted()
			{
				this.m_owner.__callBase_OnLoadStaticResCompleted();
			}

			// Token: 0x06000993 RID: 2451 RVA: 0x0002A640 File Offset: 0x00028840
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x0002A650 File Offset: 0x00028850
			public void __callBase_StartLoadDynamicRes()
			{
				this.m_owner.__callBase_StartLoadDynamicRes();
			}

			// Token: 0x06000995 RID: 2453 RVA: 0x0002A660 File Offset: 0x00028860
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x0002A670 File Offset: 0x00028870
			public List<UITaskBase.LayerDesc> __callBase_CollectAllStaticResDescForLoad()
			{
				return this.m_owner.__callBase_CollectAllStaticResDescForLoad();
			}

			// Token: 0x06000997 RID: 2455 RVA: 0x0002A680 File Offset: 0x00028880
			public HashSet<string> __callBase_CalculateDynamicResReallyNeedLoad(List<string> resPathList)
			{
				return this.m_owner.__callBase_CalculateDynamicResReallyNeedLoad(resPathList);
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x0002A690 File Offset: 0x00028890
			public void __callBase_OnLoadDynamicResCompleted()
			{
				this.m_owner.__callBase_OnLoadDynamicResCompleted();
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x0002A6A0 File Offset: 0x000288A0
			public void __callBase_RedirectPipLineOnAllResReady(Action callBack)
			{
				this.m_owner.__callBase_RedirectPipLineOnAllResReady(callBack);
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x0002A6B0 File Offset: 0x000288B0
			public void __callBase_OnLoadAllResCompleted()
			{
				this.m_owner.__callBase_OnLoadAllResCompleted();
			}

			// Token: 0x0600099B RID: 2459 RVA: 0x0002A6C0 File Offset: 0x000288C0
			public void __callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted()
			{
				this.m_owner.__callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x0002A6D0 File Offset: 0x000288D0
			public void __callBase_InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.__callBase_InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x0002A6E0 File Offset: 0x000288E0
			public void __callBase_InitAllUIControllers()
			{
				this.m_owner.__callBase_InitAllUIControllers();
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x0002A6F0 File Offset: 0x000288F0
			public void __callBase_PostOnLoadAllResCompleted()
			{
				this.m_owner.__callBase_PostOnLoadAllResCompleted();
			}

			// Token: 0x0600099F RID: 2463 RVA: 0x0002A700 File Offset: 0x00028900
			public bool __callBase_IsLoadAllResCompleted()
			{
				return this.m_owner.__callBase_IsLoadAllResCompleted();
			}

			// Token: 0x060009A0 RID: 2464 RVA: 0x0002A710 File Offset: 0x00028910
			public void __callBase_StartUpdateView()
			{
				this.m_owner.__callBase_StartUpdateView();
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x0002A720 File Offset: 0x00028920
			public void __callBase_UpdateView()
			{
				this.m_owner.__callBase_UpdateView();
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x0002A730 File Offset: 0x00028930
			public void __callBase_RegUpdateViewPlayingEffect(string name, int timeout, Action<string> onTimeOut)
			{
				this.m_owner.__callBase_RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x0002A740 File Offset: 0x00028940
			public void __callBase_UnregUpdateViewPlayingEffect(string name, bool isTimeOut)
			{
				this.m_owner.__callBase_UnregUpdateViewPlayingEffect(name, isTimeOut);
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x0002A750 File Offset: 0x00028950
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x0002A760 File Offset: 0x00028960
			public void __callBase_PostUpdateViewBeforeClearContext()
			{
				this.m_owner.__callBase_PostUpdateViewBeforeClearContext();
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x0002A770 File Offset: 0x00028970
			public void __callBase_HideAllView()
			{
				this.m_owner.__callBase_HideAllView();
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x0002A780 File Offset: 0x00028980
			public void __callBase_ClearAllContextAndRes()
			{
				this.m_owner.__callBase_ClearAllContextAndRes();
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x0002A790 File Offset: 0x00028990
			public void __callBase_SaveContextInIntentOnPause()
			{
				this.m_owner.__callBase_SaveContextInIntentOnPause();
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x0002A7A0 File Offset: 0x000289A0
			public void __callBase_ClearContextOnPause()
			{
				this.m_owner.__callBase_ClearContextOnPause();
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x0002A7B0 File Offset: 0x000289B0
			public void __callBase_ClearContextOnIntentChange(UIIntent newIntent)
			{
				this.m_owner.__callBase_ClearContextOnIntentChange(newIntent);
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x0002A7C0 File Offset: 0x000289C0
			public void __callBase_ClearContextOnUpdateViewEnd()
			{
				this.m_owner.__callBase_ClearContextOnUpdateViewEnd();
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x0002A7D0 File Offset: 0x000289D0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x0002A7E0 File Offset: 0x000289E0
			public UITaskBase.LayerDesc __callBase_GetLayerDescByName(string name)
			{
				return this.m_owner.__callBase_GetLayerDescByName(name);
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x0002A7F0 File Offset: 0x000289F0
			public SceneLayerBase __callBase_GetLayerByName(string name)
			{
				return this.m_owner.__callBase_GetLayerByName(name);
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x0002A800 File Offset: 0x00028A00
			public void __callBase_RegisterModesDefine(string defaultMode, string[] modes)
			{
				this.m_owner.__callBase_RegisterModesDefine(defaultMode, modes);
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x0002A810 File Offset: 0x00028A10
			public bool __callBase_SetCurrentMode(string mode)
			{
				return this.m_owner.__callBase_SetCurrentMode(mode);
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x0002A820 File Offset: 0x00028A20
			public void __callBase_SetIsNeedPauseTimeOut(bool isNeed)
			{
				this.m_owner.__callBase_SetIsNeedPauseTimeOut(isNeed);
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x0002A830 File Offset: 0x00028A30
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x0002A840 File Offset: 0x00028A40
			public void __callBase_PostDelayTimeExecuteAction(Action action, float delaySeconds)
			{
				this.m_owner.__callBase_PostDelayTimeExecuteAction(action, delaySeconds);
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x0002A850 File Offset: 0x00028A50
			public void __callBase_PostDelayTicksExecuteAction(Action action, ulong delayTickCount)
			{
				this.m_owner.__callBase_PostDelayTicksExecuteAction(action, delayTickCount);
			}

			// Token: 0x060009B5 RID: 2485 RVA: 0x0002A860 File Offset: 0x00028A60
			public void __callBase_SetTag(string tag)
			{
				this.m_owner.__callBase_SetTag(tag);
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x0002A870 File Offset: 0x00028A70
			public bool __callBase_HasTag(string tag)
			{
				return this.m_owner.__callBase_HasTag(tag);
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0002A880 File Offset: 0x00028A80
			// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0002A890 File Offset: 0x00028A90
			public LoginUITaskBase.LoginState m_loginTaskState
			{
				get
				{
					return this.m_owner.m_loginTaskState;
				}
				set
				{
					this.m_owner.m_loginTaskState = value;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0002A8A0 File Offset: 0x00028AA0
			// (set) Token: 0x060009BA RID: 2490 RVA: 0x0002A8B0 File Offset: 0x00028AB0
			public string m_authLoginServerAddress
			{
				get
				{
					return this.m_owner.m_authLoginServerAddress;
				}
				set
				{
					this.m_owner.m_authLoginServerAddress = value;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060009BB RID: 2491 RVA: 0x0002A8C0 File Offset: 0x00028AC0
			// (set) Token: 0x060009BC RID: 2492 RVA: 0x0002A8D0 File Offset: 0x00028AD0
			public int m_authLoginServerPort
			{
				get
				{
					return this.m_owner.m_authLoginServerPort;
				}
				set
				{
					this.m_owner.m_authLoginServerPort = value;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060009BD RID: 2493 RVA: 0x0002A8E0 File Offset: 0x00028AE0
			// (set) Token: 0x060009BE RID: 2494 RVA: 0x0002A8F0 File Offset: 0x00028AF0
			public string m_authtoken
			{
				get
				{
					return this.m_owner.m_authtoken;
				}
				set
				{
					this.m_owner.m_authtoken = value;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060009BF RID: 2495 RVA: 0x0002A900 File Offset: 0x00028B00
			// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0002A910 File Offset: 0x00028B10
			public string m_gameUserId
			{
				get
				{
					return this.m_owner.m_gameUserId;
				}
				set
				{
					this.m_owner.m_gameUserId = value;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0002A920 File Offset: 0x00028B20
			// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0002A930 File Offset: 0x00028B30
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

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0002A940 File Offset: 0x00028B40
			// (set) Token: 0x060009C4 RID: 2500 RVA: 0x0002A950 File Offset: 0x00028B50
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

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0002A960 File Offset: 0x00028B60
			// (set) Token: 0x060009C6 RID: 2502 RVA: 0x0002A970 File Offset: 0x00028B70
			public string m_lastSessionToken
			{
				get
				{
					return this.m_owner.m_lastSessionToken;
				}
				set
				{
					this.m_owner.m_lastSessionToken = value;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0002A980 File Offset: 0x00028B80
			// (set) Token: 0x060009C8 RID: 2504 RVA: 0x0002A990 File Offset: 0x00028B90
			public bool m_isWaitingForMsgAck
			{
				get
				{
					return this.m_owner.m_isWaitingForMsgAck;
				}
				set
				{
					this.m_owner.m_isWaitingForMsgAck = value;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0002A9A0 File Offset: 0x00028BA0
			// (set) Token: 0x060009CA RID: 2506 RVA: 0x0002A9B0 File Offset: 0x00028BB0
			public DateTime m_timeOutTime
			{
				get
				{
					return this.m_owner.m_timeOutTime;
				}
				set
				{
					this.m_owner.m_timeOutTime = value;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060009CB RID: 2507 RVA: 0x0002A9C0 File Offset: 0x00028BC0
			// (set) Token: 0x060009CC RID: 2508 RVA: 0x0002A9D0 File Offset: 0x00028BD0
			public float m_timeoutDelayTime
			{
				get
				{
					return this.m_owner.m_timeoutDelayTime;
				}
				set
				{
					this.m_owner.m_timeoutDelayTime = value;
				}
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x0002A9E0 File Offset: 0x00028BE0
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x060009CE RID: 2510 RVA: 0x0002A9F0 File Offset: 0x00028BF0
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x060009CF RID: 2511 RVA: 0x0002AA00 File Offset: 0x00028C00
			public bool IsSDKLogin()
			{
				return this.m_owner.IsSDKLogin();
			}

			// Token: 0x060009D0 RID: 2512 RVA: 0x0002AA10 File Offset: 0x00028C10
			public bool IsEditorTestLogin()
			{
				return this.m_owner.IsEditorTestLogin();
			}

			// Token: 0x060009D1 RID: 2513 RVA: 0x0002AA20 File Offset: 0x00028C20
			public void StartInitSDK()
			{
				this.m_owner.StartInitSDK();
			}

			// Token: 0x060009D2 RID: 2514 RVA: 0x0002AA30 File Offset: 0x00028C30
			public void OnSDKInitEnd(bool isSuccess)
			{
				this.m_owner.OnSDKInitEnd(isSuccess);
			}

			// Token: 0x060009D3 RID: 2515 RVA: 0x0002AA40 File Offset: 0x00028C40
			public void StartSDKLogin()
			{
				this.m_owner.StartSDKLogin();
			}

			// Token: 0x060009D4 RID: 2516 RVA: 0x0002AA50 File Offset: 0x00028C50
			public void OnSDKLoginEnd(bool isSuccess)
			{
				this.m_owner.OnSDKLoginEnd(isSuccess);
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x0002AA60 File Offset: 0x00028C60
			public void PostSDKLogin()
			{
				this.m_owner.PostSDKLogin();
			}

			// Token: 0x060009D6 RID: 2518 RVA: 0x0002AA70 File Offset: 0x00028C70
			public bool IsNeedSelectServer()
			{
				return this.m_owner.IsNeedSelectServer();
			}

			// Token: 0x060009D7 RID: 2519 RVA: 0x0002AA80 File Offset: 0x00028C80
			public void LaunchServerListUI()
			{
				this.m_owner.LaunchServerListUI();
			}

			// Token: 0x060009D8 RID: 2520 RVA: 0x0002AA90 File Offset: 0x00028C90
			public IEnumerator DownloadServerList(Action<bool> onEnd)
			{
				return this.m_owner.DownloadServerList(onEnd);
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x0002AAA0 File Offset: 0x00028CA0
			public void OnDownloadServerListEnd(bool isSuccess)
			{
				this.m_owner.OnDownloadServerListEnd(isSuccess);
			}

			// Token: 0x060009DA RID: 2522 RVA: 0x0002AAB0 File Offset: 0x00028CB0
			public void ShowServerListUI()
			{
				this.m_owner.ShowServerListUI();
			}

			// Token: 0x060009DB RID: 2523 RVA: 0x0002AAC0 File Offset: 0x00028CC0
			public void OnGameServerConfirmed(string serverId)
			{
				this.m_owner.OnGameServerConfirmed(serverId);
			}

			// Token: 0x060009DC RID: 2524 RVA: 0x0002AAD0 File Offset: 0x00028CD0
			public void InitServerCtxByServerID(string serverId)
			{
				this.m_owner.InitServerCtxByServerID(serverId);
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x0002AAE0 File Offset: 0x00028CE0
			public string GetLastLoginedServerID()
			{
				return this.m_owner.GetLastLoginedServerID();
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x0002AAF0 File Offset: 0x00028CF0
			public void LaunchEnterGameUI()
			{
				this.m_owner.LaunchEnterGameUI();
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x0002AB00 File Offset: 0x00028D00
			public void LaunchEnterGameUIWithGameSettingTokenAndServer()
			{
				this.m_owner.LaunchEnterGameUIWithGameSettingTokenAndServer();
			}

			// Token: 0x060009E0 RID: 2528 RVA: 0x0002AB10 File Offset: 0x00028D10
			public void LaunchEnterGameUIWithUIInputAccountAndServer()
			{
				this.m_owner.LaunchEnterGameUIWithUIInputAccountAndServer();
			}

			// Token: 0x060009E1 RID: 2529 RVA: 0x0002AB20 File Offset: 0x00028D20
			public bool LoadLastLoginWithUIInputInfo(out string loginUserId, out string authLoginServerAddress, out int authLoginServerPort)
			{
				return this.m_owner.LoadLastLoginWithUIInputInfo(out loginUserId, out authLoginServerAddress, out authLoginServerPort);
			}

			// Token: 0x060009E2 RID: 2530 RVA: 0x0002AB30 File Offset: 0x00028D30
			public IEnumerator DownloadGameServerLoginAnnouncement(Action<bool> onEnd)
			{
				return this.m_owner.DownloadGameServerLoginAnnouncement(onEnd);
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x0002AB40 File Offset: 0x00028D40
			public void OnDownloadGameServerLoginAnnouncementEnd(bool isSuccess)
			{
				this.m_owner.OnDownloadGameServerLoginAnnouncementEnd(isSuccess);
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x0002AB50 File Offset: 0x00028D50
			public void ShowGameServerLoginAnnouncementUI()
			{
				this.m_owner.ShowGameServerLoginAnnouncementUI();
			}

			// Token: 0x060009E5 RID: 2533 RVA: 0x0002AB60 File Offset: 0x00028D60
			public void ShowEnterGameUI()
			{
				this.m_owner.ShowEnterGameUI();
			}

			// Token: 0x060009E6 RID: 2534 RVA: 0x0002AB70 File Offset: 0x00028D70
			public void OnEnterGameConfirmed()
			{
				this.m_owner.OnEnterGameConfirmed();
			}

			// Token: 0x060009E7 RID: 2535 RVA: 0x0002AB80 File Offset: 0x00028D80
			public IEnumerator StartLoginAgentLogin(Action<int, string, string> onEnd)
			{
				return this.m_owner.StartLoginAgentLogin(onEnd);
			}

			// Token: 0x060009E8 RID: 2536 RVA: 0x0002AB90 File Offset: 0x00028D90
			public void LoginAgentLoginEnd(int errCode, string loginUserId, string authToken)
			{
				this.m_owner.LoginAgentLoginEnd(errCode, loginUserId, authToken);
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x0002ABA0 File Offset: 0x00028DA0
			public void StartAuthLogin()
			{
				this.m_owner.StartAuthLogin();
			}

			// Token: 0x060009EA RID: 2538 RVA: 0x0002ABB0 File Offset: 0x00028DB0
			public void StartSessionLogin()
			{
				this.m_owner.StartSessionLogin();
			}

			// Token: 0x060009EB RID: 2539 RVA: 0x0002ABC0 File Offset: 0x00028DC0
			public void StartPlayerInfoInitReq()
			{
				this.m_owner.StartPlayerInfoInitReq();
			}

			// Token: 0x060009EC RID: 2540 RVA: 0x0002ABD0 File Offset: 0x00028DD0
			public void LauncheMainUI()
			{
				this.m_owner.LauncheMainUI();
			}

			// Token: 0x060009ED RID: 2541 RVA: 0x0002ABE0 File Offset: 0x00028DE0
			public void OnWaitingMsgAckOutTime()
			{
				this.m_owner.OnWaitingMsgAckOutTime();
			}

			// Token: 0x060009EE RID: 2542 RVA: 0x0002ABF0 File Offset: 0x00028DF0
			public void StartWaitingMsgAck(float waitTime)
			{
				this.m_owner.StartWaitingMsgAck(waitTime);
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x0002AC00 File Offset: 0x00028E00
			public void StopWaitingMsgAck()
			{
				this.m_owner.StopWaitingMsgAck();
			}

			// Token: 0x060009F0 RID: 2544 RVA: 0x0002AC10 File Offset: 0x00028E10
			public void ClearGameServerLoginState()
			{
				this.m_owner.ClearGameServerLoginState();
			}

			// Token: 0x060009F1 RID: 2545 RVA: 0x0002AC20 File Offset: 0x00028E20
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x0002AC30 File Offset: 0x00028E30
			public void OnGameServerConnected()
			{
				this.m_owner.OnGameServerConnected();
			}

			// Token: 0x060009F3 RID: 2547 RVA: 0x0002AC40 File Offset: 0x00028E40
			public void OnGameServerDisconnected()
			{
				this.m_owner.OnGameServerDisconnected();
			}

			// Token: 0x060009F4 RID: 2548 RVA: 0x0002AC50 File Offset: 0x00028E50
			public void OnGameServerNetworkError()
			{
				this.m_owner.OnGameServerNetworkError();
			}

			// Token: 0x060009F5 RID: 2549 RVA: 0x0002AC60 File Offset: 0x00028E60
			public bool OnLoginByAuthTokenAck(int ret, string sessionToken, bool needRedirect)
			{
				return this.m_owner.OnLoginByAuthTokenAck(ret, sessionToken, needRedirect);
			}

			// Token: 0x060009F6 RID: 2550 RVA: 0x0002AC70 File Offset: 0x00028E70
			public bool OnLoginBySessionTokenAck(int ret)
			{
				return this.m_owner.OnLoginBySessionTokenAck(ret);
			}

			// Token: 0x060009F7 RID: 2551 RVA: 0x0002AC80 File Offset: 0x00028E80
			public void OnConfigDataMD5InfoNtf(string fileNameWithErrorMD5, string localMD5, string serverMD5)
			{
				this.m_owner.OnConfigDataMD5InfoNtf(fileNameWithErrorMD5, localMD5, serverMD5);
			}

			// Token: 0x060009F8 RID: 2552 RVA: 0x0002AC90 File Offset: 0x00028E90
			public void OnPlayerInfoInitEnd()
			{
				this.m_owner.OnPlayerInfoInitEnd();
			}

			// Token: 0x060009F9 RID: 2553 RVA: 0x0002ACA0 File Offset: 0x00028EA0
			public void RegisterNetEvent()
			{
				this.m_owner.RegisterNetEvent();
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x0002ACB0 File Offset: 0x00028EB0
			public void UnRegisterNetEvent()
			{
				this.m_owner.UnRegisterNetEvent();
			}

			// Token: 0x04000606 RID: 1542
			private LoginUITaskBase m_owner;
		}
	}
}
