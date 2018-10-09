using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E58 RID: 3672
	[HotFix]
	public class ReloginUITask : ReloginBySessionUITaskBase
	{
		// Token: 0x06011C7F RID: 72831 RVA: 0x00499C6C File Offset: 0x00497E6C
		public ReloginUITask(string name) : base(name)
		{
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

		// Token: 0x06011C80 RID: 72832 RVA: 0x00499D64 File Offset: 0x00497F64
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool result = base.OnStart(intent);
			if (!ReloginUITask.Enable)
			{
				base.Stop();
				return result;
			}
			ReloginBySessionUIIntent reloginBySessionUIIntent = intent as ReloginBySessionUIIntent;
			if (reloginBySessionUIIntent != null)
			{
				if (reloginBySessionUIIntent.m_onReloginSuccessCallBack != null)
				{
					if (reloginBySessionUIIntent.m_onReloginSuccessCallBack == ReloginUITask.s_prevReloginSuccessCallBack)
					{
						this.m_isAutoRelogin = false;
					}
				}
				else
				{
					this.m_isAutoRelogin = false;
				}
				ReloginUITask.s_prevReloginSuccessCallBack = reloginBySessionUIIntent.m_onReloginSuccessCallBack;
			}
			return result;
		}

		// Token: 0x06011C81 RID: 72833 RVA: 0x00499E48 File Offset: 0x00498048
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_reloginUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_reloginUIController = (this.m_uiCtrlArray[0] as ReloginUIController);
				}
				if (!(this.m_reloginUIController != null))
				{
					Debug.LogError("ReloginUIController is null");
					return;
				}
				this.m_reloginUIController.SetButtonClickListener("RetryLoginButton", new Action<UIControllerBase>(this.OnRetryLoginButtonClicked));
				this.m_reloginUIController.SetButtonClickListener("ReturnToLoginButton", new Action<UIControllerBase>(this.OnReturnToLoginConfirmButtonClicked));
			}
		}

		// Token: 0x06011C82 RID: 72834 RVA: 0x00499F3C File Offset: 0x0049813C
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_reloginUIController != null)
			{
				this.m_reloginUIController.SetButtonClickListener("RetryLoginButton", null);
				this.m_reloginUIController.SetButtonClickListener("ReturnToLoginButton", null);
			}
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x06011C83 RID: 72835 RVA: 0x00499FD8 File Offset: 0x004981D8
		// (set) Token: 0x06011C84 RID: 72836 RVA: 0x00499FE0 File Offset: 0x004981E0
		public static bool Enable
		{
			get
			{
				return ReloginUITask.s_isEnable;
			}
			set
			{
				ReloginUITask.s_isEnable = value;
			}
		}

		// Token: 0x06011C85 RID: 72837 RVA: 0x00499FE8 File Offset: 0x004981E8
		protected override void StartRelogin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRelogin_hotfix != null)
			{
				this.m_StartRelogin_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.CheckServerMaitainState();
			base.StartRelogin();
		}

		// Token: 0x06011C86 RID: 72838 RVA: 0x0049A054 File Offset: 0x00498254
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_reloginUIController.Open();
			if (LoginUITask.FindAInstance != null)
			{
				this.SetCurrentMode("WaitReturnToLoginConfirm");
			}
			string currMode = this.m_currMode;
			if (currMode != null)
			{
				if (!(currMode == "WaitForReloginConfirm"))
				{
					if (!(currMode == "WaitForReloginProcessing"))
					{
						if (currMode == "WaitReturnToLoginConfirm")
						{
							this.m_reloginUIController.ShowWaitReturnToLoginConfirm();
							this.EnableUIInput(true, null);
						}
					}
					else
					{
						this.m_reloginUIController.ShowWaitForReloginProcessing();
					}
				}
				else if (this.m_isAutoRelogin)
				{
					this.m_isAutoRelogin = false;
					this.m_reloginUIController.ShowWaitForReloginProcessing();
					this.StartRelogin();
				}
				else
				{
					this.m_reloginUIController.ShowWaitForReloginConfirm();
					this.EnableUIInput(true, null);
				}
			}
			UIUtility.SetLongFrame();
		}

		// Token: 0x06011C87 RID: 72839 RVA: 0x0049A194 File Offset: 0x00498394
		protected override void ShowErrorMsg(string key)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowErrorMsgString_hotfix != null)
			{
				this.m_ShowErrorMsgString_hotfix.call(new object[]
				{
					this,
					key
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.LogWarning("ReloginUITask.ShowErrorMsg " + key);
		}

		// Token: 0x06011C88 RID: 72840 RVA: 0x0049A214 File Offset: 0x00498414
		protected override void OnRetryLoginButtonClicked(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRetryLoginButtonClickedUIControllerBase_hotfix != null)
			{
				this.m_OnRetryLoginButtonClickedUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnRetryLoginButtonClicked(ctrl);
		}

		// Token: 0x06011C89 RID: 72841 RVA: 0x0049A28C File Offset: 0x0049848C
		protected override void OnReturnToLoginConfirmButtonClicked(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnToLoginConfirmButtonClickedUIControllerBase_hotfix != null)
			{
				this.m_OnReturnToLoginConfirmButtonClickedUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ReloginUITask.s_prevReloginSuccessCallBack = null;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null && projectLPlayerContext.GetChatComponent().DataDirty)
			{
				projectLPlayerContext.GetChatComponent().SaveChatHistoryData();
			}
			base.OnReturnToLoginConfirmButtonClicked(ctrl);
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x06011C8A RID: 72842 RVA: 0x0049A33C File Offset: 0x0049853C
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x06011C8B RID: 72843 RVA: 0x0049A3B0 File Offset: 0x004985B0
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x06011C8C RID: 72844 RVA: 0x0049A424 File Offset: 0x00498624
		// (set) Token: 0x06011C8D RID: 72845 RVA: 0x0049A444 File Offset: 0x00498644
		[DoNotToLua]
		public new ReloginUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ReloginUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011C8E RID: 72846 RVA: 0x0049A450 File Offset: 0x00498650
		private void __callBase_InitlizeBeforeManagerStartIt()
		{
			base.InitlizeBeforeManagerStartIt();
		}

		// Token: 0x06011C8F RID: 72847 RVA: 0x0049A458 File Offset: 0x00498658
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011C90 RID: 72848 RVA: 0x0049A464 File Offset: 0x00498664
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06011C91 RID: 72849 RVA: 0x0049A470 File Offset: 0x00498670
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011C92 RID: 72850 RVA: 0x0049A478 File Offset: 0x00498678
		private void __callBase_StartRelogin()
		{
			base.StartRelogin();
		}

		// Token: 0x06011C93 RID: 72851 RVA: 0x0049A480 File Offset: 0x00498680
		private void __callBase_ShowErrorMsg(string key)
		{
			base.ShowErrorMsg(key);
		}

		// Token: 0x06011C94 RID: 72852 RVA: 0x0049A48C File Offset: 0x0049868C
		private void __callBase_ShowWaitForReloginConfirmUI()
		{
			base.ShowWaitForReloginConfirmUI();
		}

		// Token: 0x06011C95 RID: 72853 RVA: 0x0049A494 File Offset: 0x00498694
		private void __callBase_ShowWaitForReloginProcessingUI()
		{
			base.ShowWaitForReloginProcessingUI();
		}

		// Token: 0x06011C96 RID: 72854 RVA: 0x0049A49C File Offset: 0x0049869C
		private void __callBase_ShowWaitReturnToLoginConfirmUI()
		{
			base.ShowWaitReturnToLoginConfirmUI();
		}

		// Token: 0x06011C97 RID: 72855 RVA: 0x0049A4A4 File Offset: 0x004986A4
		private void __callBase_OnRetryLoginButtonClicked(UIControllerBase ctrl)
		{
			base.OnRetryLoginButtonClicked(ctrl);
		}

		// Token: 0x06011C98 RID: 72856 RVA: 0x0049A4B0 File Offset: 0x004986B0
		private void __callBase_OnReturnToLoginConfirmButtonClicked(UIControllerBase ctrl)
		{
			base.OnReturnToLoginConfirmButtonClicked(ctrl);
		}

		// Token: 0x06011C99 RID: 72857 RVA: 0x0049A4BC File Offset: 0x004986BC
		private bool __callBase_IsNeedCheckLocalDataCache()
		{
			return base.IsNeedCheckLocalDataCache();
		}

		// Token: 0x06011C9A RID: 72858 RVA: 0x0049A4C4 File Offset: 0x004986C4
		private void __callBase_RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
		}

		// Token: 0x06011C9B RID: 72859 RVA: 0x0049A4CC File Offset: 0x004986CC
		private void __callBase_UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
		}

		// Token: 0x06011C9C RID: 72860 RVA: 0x0049A4D4 File Offset: 0x004986D4
		private bool __callBase_OnLoginBySessionTokenAck(int result)
		{
			return base.OnLoginBySessionTokenAck(result);
		}

		// Token: 0x06011C9D RID: 72861 RVA: 0x0049A4E0 File Offset: 0x004986E0
		private void __callBase_OnPlayerInfoInitAck(object msg)
		{
			base.OnPlayerInfoInitAck(msg);
		}

		// Token: 0x06011C9E RID: 72862 RVA: 0x0049A4EC File Offset: 0x004986EC
		private void __callBase_OnPlayerInfoInitEnd()
		{
			base.OnPlayerInfoInitEnd();
		}

		// Token: 0x06011C9F RID: 72863 RVA: 0x0049A4F4 File Offset: 0x004986F4
		private void __callBase_OnGameServerDataUnsyncNotify()
		{
			base.OnGameServerDataUnsyncNotify();
		}

		// Token: 0x06011CA0 RID: 72864 RVA: 0x0049A4FC File Offset: 0x004986FC
		private void __callBase_OnGameServerNetworkError()
		{
			base.OnGameServerNetworkError();
		}

		// Token: 0x06011CA1 RID: 72865 RVA: 0x0049A504 File Offset: 0x00498704
		private void __callBase_OnGameServerDisconnected()
		{
			base.OnGameServerDisconnected();
		}

		// Token: 0x06011CA2 RID: 72866 RVA: 0x0049A50C File Offset: 0x0049870C
		private static void __callDele_s_prevReloginSuccessCallBack()
		{
			Action action = ReloginUITask.s_prevReloginSuccessCallBack;
			if (action != null)
			{
				action();
			}
		}

		// Token: 0x06011CA3 RID: 72867 RVA: 0x0049A52C File Offset: 0x0049872C
		private static void __clearDele_s_prevReloginSuccessCallBack()
		{
			ReloginUITask.s_prevReloginSuccessCallBack = null;
		}

		// Token: 0x06011CA5 RID: 72869 RVA: 0x0049A53C File Offset: 0x0049873C
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_StartRelogin_hotfix = (luaObj.RawGet("StartRelogin") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ShowErrorMsgString_hotfix = (luaObj.RawGet("ShowErrorMsg") as LuaFunction);
					this.m_OnRetryLoginButtonClickedUIControllerBase_hotfix = (luaObj.RawGet("OnRetryLoginButtonClicked") as LuaFunction);
					this.m_OnReturnToLoginConfirmButtonClickedUIControllerBase_hotfix = (luaObj.RawGet("OnReturnToLoginConfirmButtonClicked") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011CA6 RID: 72870 RVA: 0x0049A704 File Offset: 0x00498904
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ReloginUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A1D7 RID: 41431
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ReloginUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/ReloginUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A1D8 RID: 41432
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ReloginUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ReloginUIController"),
				m_ctrlName = "ReloginUIController"
			}
		};

		// Token: 0x0400A1D9 RID: 41433
		private ReloginUIController m_reloginUIController;

		// Token: 0x0400A1DA RID: 41434
		private bool m_isAutoRelogin = true;

		// Token: 0x0400A1DB RID: 41435
		private static Action s_prevReloginSuccessCallBack;

		// Token: 0x0400A1DC RID: 41436
		private static bool s_isEnable = true;

		// Token: 0x0400A1DD RID: 41437
		[DoNotToLua]
		private ReloginUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A1DE RID: 41438
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A1DF RID: 41439
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A1E0 RID: 41440
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A1E1 RID: 41441
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A1E2 RID: 41442
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A1E3 RID: 41443
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A1E4 RID: 41444
		private LuaFunction m_StartRelogin_hotfix;

		// Token: 0x0400A1E5 RID: 41445
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A1E6 RID: 41446
		private LuaFunction m_ShowErrorMsgString_hotfix;

		// Token: 0x0400A1E7 RID: 41447
		private LuaFunction m_OnRetryLoginButtonClickedUIControllerBase_hotfix;

		// Token: 0x0400A1E8 RID: 41448
		private LuaFunction m_OnReturnToLoginConfirmButtonClickedUIControllerBase_hotfix;

		// Token: 0x0400A1E9 RID: 41449
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A1EA RID: 41450
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E59 RID: 3673
		public new class LuaExportHelper
		{
			// Token: 0x06011CA7 RID: 72871 RVA: 0x0049A76C File Offset: 0x0049896C
			public LuaExportHelper(ReloginUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011CA8 RID: 72872 RVA: 0x0049A77C File Offset: 0x0049897C
			public void __callBase_InitlizeBeforeManagerStartIt()
			{
				this.m_owner.__callBase_InitlizeBeforeManagerStartIt();
			}

			// Token: 0x06011CA9 RID: 72873 RVA: 0x0049A78C File Offset: 0x0049898C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06011CAA RID: 72874 RVA: 0x0049A79C File Offset: 0x0049899C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011CAB RID: 72875 RVA: 0x0049A7AC File Offset: 0x004989AC
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011CAC RID: 72876 RVA: 0x0049A7BC File Offset: 0x004989BC
			public void __callBase_StartRelogin()
			{
				this.m_owner.__callBase_StartRelogin();
			}

			// Token: 0x06011CAD RID: 72877 RVA: 0x0049A7CC File Offset: 0x004989CC
			public void __callBase_ShowErrorMsg(string key)
			{
				this.m_owner.__callBase_ShowErrorMsg(key);
			}

			// Token: 0x06011CAE RID: 72878 RVA: 0x0049A7DC File Offset: 0x004989DC
			public void __callBase_ShowWaitForReloginConfirmUI()
			{
				this.m_owner.__callBase_ShowWaitForReloginConfirmUI();
			}

			// Token: 0x06011CAF RID: 72879 RVA: 0x0049A7EC File Offset: 0x004989EC
			public void __callBase_ShowWaitForReloginProcessingUI()
			{
				this.m_owner.__callBase_ShowWaitForReloginProcessingUI();
			}

			// Token: 0x06011CB0 RID: 72880 RVA: 0x0049A7FC File Offset: 0x004989FC
			public void __callBase_ShowWaitReturnToLoginConfirmUI()
			{
				this.m_owner.__callBase_ShowWaitReturnToLoginConfirmUI();
			}

			// Token: 0x06011CB1 RID: 72881 RVA: 0x0049A80C File Offset: 0x00498A0C
			public void __callBase_OnRetryLoginButtonClicked(UIControllerBase ctrl)
			{
				this.m_owner.__callBase_OnRetryLoginButtonClicked(ctrl);
			}

			// Token: 0x06011CB2 RID: 72882 RVA: 0x0049A81C File Offset: 0x00498A1C
			public void __callBase_OnReturnToLoginConfirmButtonClicked(UIControllerBase ctrl)
			{
				this.m_owner.__callBase_OnReturnToLoginConfirmButtonClicked(ctrl);
			}

			// Token: 0x06011CB3 RID: 72883 RVA: 0x0049A82C File Offset: 0x00498A2C
			public bool __callBase_IsNeedCheckLocalDataCache()
			{
				return this.m_owner.__callBase_IsNeedCheckLocalDataCache();
			}

			// Token: 0x06011CB4 RID: 72884 RVA: 0x0049A83C File Offset: 0x00498A3C
			public void __callBase_RegisterNetworkEvent()
			{
				this.m_owner.__callBase_RegisterNetworkEvent();
			}

			// Token: 0x06011CB5 RID: 72885 RVA: 0x0049A84C File Offset: 0x00498A4C
			public void __callBase_UnregisterNetworkEvent()
			{
				this.m_owner.__callBase_UnregisterNetworkEvent();
			}

			// Token: 0x06011CB6 RID: 72886 RVA: 0x0049A85C File Offset: 0x00498A5C
			public bool __callBase_OnLoginBySessionTokenAck(int result)
			{
				return this.m_owner.__callBase_OnLoginBySessionTokenAck(result);
			}

			// Token: 0x06011CB7 RID: 72887 RVA: 0x0049A86C File Offset: 0x00498A6C
			public void __callBase_OnPlayerInfoInitAck(object msg)
			{
				this.m_owner.__callBase_OnPlayerInfoInitAck(msg);
			}

			// Token: 0x06011CB8 RID: 72888 RVA: 0x0049A87C File Offset: 0x00498A7C
			public void __callBase_OnPlayerInfoInitEnd()
			{
				this.m_owner.__callBase_OnPlayerInfoInitEnd();
			}

			// Token: 0x06011CB9 RID: 72889 RVA: 0x0049A88C File Offset: 0x00498A8C
			public void __callBase_OnGameServerDataUnsyncNotify()
			{
				this.m_owner.__callBase_OnGameServerDataUnsyncNotify();
			}

			// Token: 0x06011CBA RID: 72890 RVA: 0x0049A89C File Offset: 0x00498A9C
			public void __callBase_OnGameServerNetworkError()
			{
				this.m_owner.__callBase_OnGameServerNetworkError();
			}

			// Token: 0x06011CBB RID: 72891 RVA: 0x0049A8AC File Offset: 0x00498AAC
			public void __callBase_OnGameServerDisconnected()
			{
				this.m_owner.__callBase_OnGameServerDisconnected();
			}

			// Token: 0x06011CBC RID: 72892 RVA: 0x0049A8BC File Offset: 0x00498ABC
			public static void __callDele_s_prevReloginSuccessCallBack()
			{
				ReloginUITask.__callDele_s_prevReloginSuccessCallBack();
			}

			// Token: 0x06011CBD RID: 72893 RVA: 0x0049A8C4 File Offset: 0x00498AC4
			public static void __clearDele_s_prevReloginSuccessCallBack()
			{
				ReloginUITask.__clearDele_s_prevReloginSuccessCallBack();
			}

			// Token: 0x1700368C RID: 13964
			// (get) Token: 0x06011CBE RID: 72894 RVA: 0x0049A8CC File Offset: 0x00498ACC
			// (set) Token: 0x06011CBF RID: 72895 RVA: 0x0049A8DC File Offset: 0x00498ADC
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x1700368D RID: 13965
			// (get) Token: 0x06011CC0 RID: 72896 RVA: 0x0049A8EC File Offset: 0x00498AEC
			// (set) Token: 0x06011CC1 RID: 72897 RVA: 0x0049A8FC File Offset: 0x00498AFC
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x1700368E RID: 13966
			// (get) Token: 0x06011CC2 RID: 72898 RVA: 0x0049A90C File Offset: 0x00498B0C
			// (set) Token: 0x06011CC3 RID: 72899 RVA: 0x0049A91C File Offset: 0x00498B1C
			public ReloginUIController m_reloginUIController
			{
				get
				{
					return this.m_owner.m_reloginUIController;
				}
				set
				{
					this.m_owner.m_reloginUIController = value;
				}
			}

			// Token: 0x1700368F RID: 13967
			// (get) Token: 0x06011CC4 RID: 72900 RVA: 0x0049A92C File Offset: 0x00498B2C
			// (set) Token: 0x06011CC5 RID: 72901 RVA: 0x0049A93C File Offset: 0x00498B3C
			public bool m_isAutoRelogin
			{
				get
				{
					return this.m_owner.m_isAutoRelogin;
				}
				set
				{
					this.m_owner.m_isAutoRelogin = value;
				}
			}

			// Token: 0x17003690 RID: 13968
			// (get) Token: 0x06011CC6 RID: 72902 RVA: 0x0049A94C File Offset: 0x00498B4C
			// (set) Token: 0x06011CC7 RID: 72903 RVA: 0x0049A954 File Offset: 0x00498B54
			public static Action s_prevReloginSuccessCallBack
			{
				get
				{
					return ReloginUITask.s_prevReloginSuccessCallBack;
				}
				set
				{
					ReloginUITask.s_prevReloginSuccessCallBack = value;
				}
			}

			// Token: 0x17003691 RID: 13969
			// (get) Token: 0x06011CC8 RID: 72904 RVA: 0x0049A95C File Offset: 0x00498B5C
			// (set) Token: 0x06011CC9 RID: 72905 RVA: 0x0049A964 File Offset: 0x00498B64
			public static bool s_isEnable
			{
				get
				{
					return ReloginUITask.s_isEnable;
				}
				set
				{
					ReloginUITask.s_isEnable = value;
				}
			}

			// Token: 0x17003692 RID: 13970
			// (get) Token: 0x06011CCA RID: 72906 RVA: 0x0049A96C File Offset: 0x00498B6C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003693 RID: 13971
			// (get) Token: 0x06011CCB RID: 72907 RVA: 0x0049A97C File Offset: 0x00498B7C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06011CCC RID: 72908 RVA: 0x0049A98C File Offset: 0x00498B8C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011CCD RID: 72909 RVA: 0x0049A99C File Offset: 0x00498B9C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06011CCE RID: 72910 RVA: 0x0049A9AC File Offset: 0x00498BAC
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06011CCF RID: 72911 RVA: 0x0049A9BC File Offset: 0x00498BBC
			public void StartRelogin()
			{
				this.m_owner.StartRelogin();
			}

			// Token: 0x06011CD0 RID: 72912 RVA: 0x0049A9CC File Offset: 0x00498BCC
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06011CD1 RID: 72913 RVA: 0x0049A9DC File Offset: 0x00498BDC
			public void ShowErrorMsg(string key)
			{
				this.m_owner.ShowErrorMsg(key);
			}

			// Token: 0x06011CD2 RID: 72914 RVA: 0x0049A9EC File Offset: 0x00498BEC
			public void OnRetryLoginButtonClicked(UIControllerBase ctrl)
			{
				this.m_owner.OnRetryLoginButtonClicked(ctrl);
			}

			// Token: 0x06011CD3 RID: 72915 RVA: 0x0049A9FC File Offset: 0x00498BFC
			public void OnReturnToLoginConfirmButtonClicked(UIControllerBase ctrl)
			{
				this.m_owner.OnReturnToLoginConfirmButtonClicked(ctrl);
			}

			// Token: 0x0400A1EB RID: 41451
			private ReloginUITask m_owner;
		}
	}
}
