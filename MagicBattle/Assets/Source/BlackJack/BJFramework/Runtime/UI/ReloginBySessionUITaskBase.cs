using System;
using System.Diagnostics;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000FB RID: 251
	public abstract class ReloginBySessionUITaskBase : UITaskBase
	{
		// Token: 0x06000A02 RID: 2562 RVA: 0x0002AD28 File Offset: 0x00028F28
		public ReloginBySessionUITaskBase(string name) : base(name)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002AD34 File Offset: 0x00028F34
		public override void InitlizeBeforeManagerStartIt()
		{
			base.RegisterModesDefine("WaitForReloginConfirm", new string[]
			{
				"WaitForReloginProcessing",
				"WaitReturnToLoginConfirm"
			});
			base.InitlizeBeforeManagerStartIt();
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002AD60 File Offset: 0x00028F60
		protected override bool OnStart(UIIntent intent)
		{
			ReloginBySessionUIIntent reloginBySessionUIIntent = intent as ReloginBySessionUIIntent;
			ReloginBySessionUITaskBase.EventOnReloginSuccess += reloginBySessionUIIntent.m_onReloginSuccessCallBack;
			this.RegisterNetworkEvent();
			this.m_raiseCriticalDataCacheDirty = false;
			return base.OnStart(intent);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002AD94 File Offset: 0x00028F94
		public override bool OnNewIntent(UIIntent intent)
		{
			ReloginBySessionUIIntent reloginBySessionUIIntent = intent as ReloginBySessionUIIntent;
			if (reloginBySessionUIIntent != null && reloginBySessionUIIntent.m_onReloginSuccessCallBack != null)
			{
				ReloginBySessionUITaskBase.EventOnReloginSuccess += reloginBySessionUIIntent.m_onReloginSuccessCallBack;
			}
			return true;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002ADC8 File Offset: 0x00028FC8
		protected override void OnStop()
		{
			ReloginBySessionUITaskBase.EventOnReloginSuccess = null;
			ReloginBySessionUITaskBase.EventOnReturnToLoginConfirmed = null;
			this.UnregisterNetworkEvent();
			base.OnStop();
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002ADE4 File Offset: 0x00028FE4
		protected virtual void StartRelogin()
		{
			global::Debug.Log("StartRelogin");
			this.ShowWaitForReloginProcessingUI();
			global::Debug.Log("ReloginBySessionUITaskBase StartRelogin");
			if (!GameManager.Instance.PlayerContext.CheckForSessionLogin())
			{
				global::Debug.Log("ReloginBySessionUITaskBase Disconnect first");
				if (GameManager.Instance.PlayerContext.Disconnect())
				{
					this.m_waitForStartGameSessionLogin = true;
					return;
				}
			}
			if (!GameManager.Instance.PlayerContext.StartGameSessionLogin())
			{
				global::Debug.LogError("ReloginBySessionUITaskBase StartGameSessionLogin fail");
				this.ShowErrorMsg("StartGameSessionLoginFail");
				this.ShowWaitReturnToLoginConfirmUI();
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002AE78 File Offset: 0x00029078
		protected virtual void ShowErrorMsg(string key)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002AE80 File Offset: 0x00029080
		protected virtual void ShowWaitForReloginConfirmUI()
		{
			this.SetCurrentMode("WaitForReloginConfirm");
			base.StartUpdatePipeLine(null, true, false, true);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002AE9C File Offset: 0x0002909C
		protected virtual void ShowWaitForReloginProcessingUI()
		{
			this.SetCurrentMode("WaitForReloginProcessing");
			base.StartUpdatePipeLine(null, true, false, true);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002AEB8 File Offset: 0x000290B8
		protected void ShowWaitReturnToLoginConfirmUI()
		{
			this.SetCurrentMode("WaitReturnToLoginConfirm");
			base.StartUpdatePipeLine(null, true, false, true);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002AED4 File Offset: 0x000290D4
		protected virtual void OnRetryLoginButtonClicked(UIControllerBase ctrl)
		{
			global::Debug.Log("OnRetryLoginButtonClicked");
			if (!base.IsUIInputEnable)
			{
				return;
			}
			this.EnableUIInput(false, null);
			this.StartRelogin();
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0002AF10 File Offset: 0x00029110
		protected virtual void OnReturnToLoginConfirmButtonClicked(UIControllerBase ctrl)
		{
			global::Debug.Log("OnReturnToLoginConfirmButtonClicked");
			this.EnableUIInput(false, null);
			Action eventOnReturnToLoginConfirmed = ReloginBySessionUITaskBase.EventOnReturnToLoginConfirmed;
			base.Stop();
			GameManager.Instance.Return2Login(this.m_raiseCriticalDataCacheDirty);
			if (eventOnReturnToLoginConfirmed != null)
			{
				eventOnReturnToLoginConfirmed();
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002AF64 File Offset: 0x00029164
		protected virtual bool IsNeedCheckLocalDataCache()
		{
			return false;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002AF68 File Offset: 0x00029168
		protected virtual void RegisterNetworkEvent()
		{
			GameManager.Instance.PlayerContext.EventOnGameServerDisconnected += this.OnGameServerDisconnected;
			GameManager.Instance.PlayerContext.EventOnGameServerNetworkError += this.OnGameServerNetworkError;
			GameManager.Instance.PlayerContext.EventOnLoginBySessionTokenAck += this.OnLoginBySessionTokenAck;
			GameManager.Instance.PlayerContext.EventOnGameServerDataUnsyncNotify += this.OnGameServerDataUnsyncNotify;
			GameManager.Instance.PlayerContext.EventOnPlayerInfoInitAck += this.OnPlayerInfoInitAck;
			GameManager.Instance.PlayerContext.EventOnPlayerInfoInitEnd += this.OnPlayerInfoInitEnd;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002B020 File Offset: 0x00029220
		protected virtual void UnregisterNetworkEvent()
		{
			if (GameManager.Instance.PlayerContext != null)
			{
				GameManager.Instance.PlayerContext.EventOnGameServerDisconnected -= this.OnGameServerDisconnected;
				GameManager.Instance.PlayerContext.EventOnGameServerNetworkError -= this.OnGameServerNetworkError;
				GameManager.Instance.PlayerContext.EventOnLoginBySessionTokenAck -= this.OnLoginBySessionTokenAck;
				GameManager.Instance.PlayerContext.EventOnGameServerDataUnsyncNotify -= this.OnGameServerDataUnsyncNotify;
				GameManager.Instance.PlayerContext.EventOnPlayerInfoInitAck -= this.OnPlayerInfoInitAck;
				GameManager.Instance.PlayerContext.EventOnPlayerInfoInitEnd -= this.OnPlayerInfoInitEnd;
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0002B0E4 File Offset: 0x000292E4
		protected virtual bool OnLoginBySessionTokenAck(int result)
		{
			global::Debug.Log("ReloginBySessionUITaskBase OnLoginBySessionTokenAck lret=" + result);
			if (result == 0)
			{
				if (!GameManager.Instance.PlayerContext.SendPlayerInfoReqOnReloginBySession(this.IsNeedCheckLocalDataCache()))
				{
					global::Debug.LogError("ReloginBySessionUITaskBase SendPlayerInfoReqOnReloginBySession fail");
					this.ShowWaitForReloginConfirmUI();
					return true;
				}
				return false;
			}
			else
			{
				if (result == -5)
				{
					global::Debug.LogError("ReloginBySessionUITaskBase.OnLoginBySessionTokenAck -5 login conflict");
					this.ShowWaitForReloginConfirmUI();
					return false;
				}
				global::Debug.LogError(string.Format("ReloginBySessionUITaskBase.OnLoginBySessionTokenAck {0}", result));
				this.ShowWaitReturnToLoginConfirmUI();
				return false;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002B178 File Offset: 0x00029378
		protected virtual void OnPlayerInfoInitAck(object msg)
		{
			global::Debug.Log("ReloginBySessionUITaskBase OnPlayerInfoInitAck");
			if (!GameManager.Instance.PlayerContext.IsPlayerInfoInitAck4CheckOnly(msg))
			{
				return;
			}
			if (GameManager.Instance.PlayerContext.IsDataCacheDirtyByPlayerInfoInitAck(msg, out this.m_raiseCriticalDataCacheDirty) && this.m_raiseCriticalDataCacheDirty)
			{
				global::Debug.Log("CriticalDataCacheDirty");
				this.ShowWaitReturnToLoginConfirmUI();
				return;
			}
			GameManager.Instance.Clear4Relogin();
			if (!GameManager.Instance.PlayerContext.SendPlayerInfoReqOnReloginBySession(false))
			{
				global::Debug.LogError("ReloginBySessionUITaskBase SendPlayerInfoReqOnReloginBySession fail");
				this.ShowWaitForReloginConfirmUI();
				return;
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002B20C File Offset: 0x0002940C
		protected virtual void OnPlayerInfoInitEnd()
		{
			global::Debug.Log("ReloginBySessionUITaskBase OnPlayerInfoInitEnd");
			Action eventOnReloginSuccess = ReloginBySessionUITaskBase.EventOnReloginSuccess;
			base.Stop();
			if (eventOnReloginSuccess != null)
			{
				eventOnReloginSuccess();
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002B240 File Offset: 0x00029440
		protected virtual void OnGameServerDataUnsyncNotify()
		{
			global::Debug.LogError("ReloginBySessionUITaskBase OnGameServerDataUnsyncNotify");
			this.ShowWaitReturnToLoginConfirmUI();
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002B254 File Offset: 0x00029454
		protected virtual void OnGameServerNetworkError()
		{
			global::Debug.LogError("ReloginBySessionUITaskBase OnGameServerNetworkError");
			if (this.m_currMode == "WaitForReloginProcessing")
			{
				this.ShowWaitForReloginConfirmUI();
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002B27C File Offset: 0x0002947C
		protected virtual void OnGameServerDisconnected()
		{
			global::Debug.LogError("ReloginBySessionUITaskBase OnGameServerDisconnected");
			if (this.m_waitForStartGameSessionLogin)
			{
				this.m_waitForStartGameSessionLogin = false;
				if (!GameManager.Instance.PlayerContext.StartGameSessionLogin())
				{
					global::Debug.LogError("ReloginBySessionUITaskBase StartGameSessionLogin fail");
					this.ShowErrorMsg("StartGameSessionLoginFail");
					this.ShowWaitReturnToLoginConfirmUI();
				}
			}
			if (this.m_currMode == "WaitForReloginProcessing")
			{
				this.ShowWaitForReloginConfirmUI();
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000A17 RID: 2583 RVA: 0x0002B2F4 File Offset: 0x000294F4
		// (remove) Token: 0x06000A18 RID: 2584 RVA: 0x0002B328 File Offset: 0x00029528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action EventOnReloginSuccess;

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000A19 RID: 2585 RVA: 0x0002B35C File Offset: 0x0002955C
		// (remove) Token: 0x06000A1A RID: 2586 RVA: 0x0002B390 File Offset: 0x00029590
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action EventOnReturnToLoginConfirmed;

		// Token: 0x0400060C RID: 1548
		protected bool m_waitForStartGameSessionLogin;

		// Token: 0x0400060D RID: 1549
		protected bool m_raiseCriticalDataCacheDirty;
	}
}
