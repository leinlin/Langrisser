using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C0E RID: 3086
	[HotFix]
	public class WaitPVPInviteUITask : UITask
	{
		// Token: 0x0600D855 RID: 55381 RVA: 0x003AD21C File Offset: 0x003AB41C
		public WaitPVPInviteUITask(string name) : base(name)
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

		// Token: 0x0600D856 RID: 55382 RVA: 0x003AD318 File Offset: 0x003AB518
		protected override void Finalize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Finalize_hotfix != null)
			{
				this.m_Finalize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600D857 RID: 55383 RVA: 0x003AD394 File Offset: 0x003AB594
		public static void StartUITask(string targetUserId)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(WaitPVPInviteUITask).Name, null);
			uiintentCustom.SetParam("TargetUserId", targetUserId);
			UIManager.Instance.StartUITask(uiintentCustom, false, false, null);
		}

		// Token: 0x0600D858 RID: 55384 RVA: 0x003AD3D4 File Offset: 0x003AB5D4
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
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x0600D859 RID: 55385 RVA: 0x003AD460 File Offset: 0x003AB660
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x0600D85A RID: 55386 RVA: 0x003AD4EC File Offset: 0x003AB6EC
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_targetUserId = string.Empty;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_targetUserId = uiintentCustom.GetClassParam<string>("TargetUserId");
			}
		}

		// Token: 0x0600D85B RID: 55387 RVA: 0x003AD588 File Offset: 0x003AB788
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
			this.InitWaitPVPInviteUIController();
		}

		// Token: 0x0600D85C RID: 55388 RVA: 0x003AD5F4 File Offset: 0x003AB7F4
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
			this.UninitWaitPVPInviteUIController();
		}

		// Token: 0x0600D85D RID: 55389 RVA: 0x003AD660 File Offset: 0x003AB860
		protected override void RegisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterPlayerContextEvents_hotfix != null)
			{
				this.m_RegisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.RegisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattlePracticeFailNtf += this.PlayerContext_OnOnBattlePracticeFailNtf;
				projectLPlayerContext.EventOnBattlePracticeDeclinedNtf += this.PlayerContext_OnBattlePracticeDeclinedNtf;
			}
		}

		// Token: 0x0600D85E RID: 55390 RVA: 0x003AD700 File Offset: 0x003AB900
		protected override void UnregisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterPlayerContextEvents_hotfix != null)
			{
				this.m_UnregisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UnregisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattlePracticeFailNtf -= this.PlayerContext_OnOnBattlePracticeFailNtf;
				projectLPlayerContext.EventOnBattlePracticeDeclinedNtf -= this.PlayerContext_OnBattlePracticeDeclinedNtf;
			}
		}

		// Token: 0x0600D85F RID: 55391 RVA: 0x003AD7A0 File Offset: 0x003AB9A0
		private void InitWaitPVPInviteUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitWaitPVPInviteUIController_hotfix != null)
			{
				this.m_InitWaitPVPInviteUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_waitPVPInviteUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_waitPVPInviteUIController = (this.m_uiCtrlArray[0] as WaitPVPInviteUIController);
				}
				if (!(this.m_waitPVPInviteUIController != null))
				{
					Debug.LogError("WaitPVPInviteUIController is null");
					return;
				}
				this.m_waitPVPInviteUIController.EventOnCancel += this.WaitPVPInviteUIController_OnCancel;
			}
		}

		// Token: 0x0600D860 RID: 55392 RVA: 0x003AD86C File Offset: 0x003ABA6C
		private void UninitWaitPVPInviteUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitWaitPVPInviteUIController_hotfix != null)
			{
				this.m_UninitWaitPVPInviteUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_waitPVPInviteUIController != null)
			{
				this.m_waitPVPInviteUIController.EventOnCancel -= this.WaitPVPInviteUIController_OnCancel;
				this.m_waitPVPInviteUIController = null;
			}
		}

		// Token: 0x0600D861 RID: 55393 RVA: 0x003AD8FC File Offset: 0x003ABAFC
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
			if (base.IsOpeningUI())
			{
				this.m_waitPVPInviteUIController.Open();
				if (!string.IsNullOrEmpty(this.m_targetUserId))
				{
					this.StartBattlePracticeInviteNetTask(this.m_targetUserId);
				}
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.m_waitTimeout = DateTime.Now.AddSeconds((double)configDataLoader.ConfigableConstId_BattleInviteFriendsToPracticeMaxWaitInterval);
			}
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x003AD9B8 File Offset: 0x003ABBB8
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
			if (this.m_waitPVPInviteUIController == null)
			{
				return;
			}
			if (this.m_waitTimeout != DateTime.MinValue && DateTime.Now > this.m_waitTimeout)
			{
				this.m_waitTimeout = DateTime.MinValue;
				this.WaitPVPInviteUIController_OnCancel();
			}
			else
			{
				CommonUITask.TickCheckOnline();
			}
		}

		// Token: 0x0600D863 RID: 55395 RVA: 0x003ADA78 File Offset: 0x003ABC78
		private void StartBattlePracticeInviteNetTask(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattlePracticeInviteNetTaskString_hotfix != null)
			{
				this.m_StartBattlePracticeInviteNetTaskString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePracticeInviteNetTask battlePracticeInviteNetTask = new BattlePracticeInviteNetTask(userId);
			battlePracticeInviteNetTask.EventOnStop += delegate(Task task)
			{
				BattlePracticeInviteNetTask battlePracticeInviteNetTask2 = task as BattlePracticeInviteNetTask;
				if (battlePracticeInviteNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(battlePracticeInviteNetTask2.Result, 2f, null, true);
					this.CloseAndPause();
				}
			};
			battlePracticeInviteNetTask.Start(null);
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x003ADB0C File Offset: 0x003ABD0C
		private void CloseAndPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAndPause_hotfix != null)
			{
				this.m_CloseAndPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_waitPVPInviteUIController.Close(delegate
			{
				base.Pause();
			});
		}

		// Token: 0x0600D865 RID: 55397 RVA: 0x003ADB84 File Offset: 0x003ABD84
		private void WaitPVPInviteUIController_OnCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WaitPVPInviteUIController_OnCancel_hotfix != null)
			{
				this.m_WaitPVPInviteUIController_OnCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePracticeCancelNetTask battlePracticeCancelNetTask = new BattlePracticeCancelNetTask();
			battlePracticeCancelNetTask.EventOnStop += delegate(Task task)
			{
				BattlePracticeCancelNetTask battlePracticeCancelNetTask2 = task as BattlePracticeCancelNetTask;
				if (battlePracticeCancelNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(battlePracticeCancelNetTask2.Result, 2f, null, true);
				}
				this.CloseAndPause();
			};
			battlePracticeCancelNetTask.Start(null);
		}

		// Token: 0x0600D866 RID: 55398 RVA: 0x003ADC04 File Offset: 0x003ABE04
		private void PlayerContext_OnOnBattlePracticeFailNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnOnBattlePracticeFailNtf_hotfix != null)
			{
				this.m_PlayerContext_OnOnBattlePracticeFailNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Friend_PVPInviteFail, 2f, null, true);
			this.CloseAndPause();
		}

		// Token: 0x0600D867 RID: 55399 RVA: 0x003ADC80 File Offset: 0x003ABE80
		private void PlayerContext_OnBattlePracticeDeclinedNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnBattlePracticeDeclinedNtf_hotfix != null)
			{
				this.m_PlayerContext_OnBattlePracticeDeclinedNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Friend_PVPInviteFail, 2f, null, true);
			this.CloseAndPause();
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0600D868 RID: 55400 RVA: 0x003ADCFC File Offset: 0x003ABEFC
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

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600D869 RID: 55401 RVA: 0x003ADD70 File Offset: 0x003ABF70
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

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600D86A RID: 55402 RVA: 0x003ADDE4 File Offset: 0x003ABFE4
		// (set) Token: 0x0600D86B RID: 55403 RVA: 0x003ADE04 File Offset: 0x003AC004
		[DoNotToLua]
		public new WaitPVPInviteUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WaitPVPInviteUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x003ADE10 File Offset: 0x003AC010
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x003ADE1C File Offset: 0x003AC01C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x003ADE24 File Offset: 0x003AC024
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x003ADE2C File Offset: 0x003AC02C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x003ADE38 File Offset: 0x003AC038
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x003ADE44 File Offset: 0x003AC044
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x003ADE50 File Offset: 0x003AC050
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x003ADE58 File Offset: 0x003AC058
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D874 RID: 55412 RVA: 0x003ADE60 File Offset: 0x003AC060
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D875 RID: 55413 RVA: 0x003ADE68 File Offset: 0x003AC068
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x003ADE70 File Offset: 0x003AC070
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D877 RID: 55415 RVA: 0x003ADE78 File Offset: 0x003AC078
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D878 RID: 55416 RVA: 0x003ADE80 File Offset: 0x003AC080
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D879 RID: 55417 RVA: 0x003ADE88 File Offset: 0x003AC088
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x003ADE94 File Offset: 0x003AC094
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D87B RID: 55419 RVA: 0x003ADEA0 File Offset: 0x003AC0A0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D87C RID: 55420 RVA: 0x003ADEAC File Offset: 0x003AC0AC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D87D RID: 55421 RVA: 0x003ADEB8 File Offset: 0x003AC0B8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D87E RID: 55422 RVA: 0x003ADEC0 File Offset: 0x003AC0C0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D87F RID: 55423 RVA: 0x003ADEC8 File Offset: 0x003AC0C8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D880 RID: 55424 RVA: 0x003ADED0 File Offset: 0x003AC0D0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D881 RID: 55425 RVA: 0x003ADED8 File Offset: 0x003AC0D8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D882 RID: 55426 RVA: 0x003ADEE0 File Offset: 0x003AC0E0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D886 RID: 55430 RVA: 0x003ADF78 File Offset: 0x003AC178
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
					this.m_Finalize_hotfix = (luaObj.RawGet("Finalize") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_InitWaitPVPInviteUIController_hotfix = (luaObj.RawGet("InitWaitPVPInviteUIController") as LuaFunction);
					this.m_UninitWaitPVPInviteUIController_hotfix = (luaObj.RawGet("UninitWaitPVPInviteUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_StartBattlePracticeInviteNetTaskString_hotfix = (luaObj.RawGet("StartBattlePracticeInviteNetTask") as LuaFunction);
					this.m_CloseAndPause_hotfix = (luaObj.RawGet("CloseAndPause") as LuaFunction);
					this.m_WaitPVPInviteUIController_OnCancel_hotfix = (luaObj.RawGet("WaitPVPInviteUIController_OnCancel") as LuaFunction);
					this.m_PlayerContext_OnOnBattlePracticeFailNtf_hotfix = (luaObj.RawGet("PlayerContext_OnOnBattlePracticeFailNtf") as LuaFunction);
					this.m_PlayerContext_OnBattlePracticeDeclinedNtf_hotfix = (luaObj.RawGet("PlayerContext_OnBattlePracticeDeclinedNtf") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D887 RID: 55431 RVA: 0x003AE220 File Offset: 0x003AC420
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WaitPVPInviteUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040084EF RID: 34031
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "WaitPVPInviteUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/WaitPVPInviteUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040084F0 RID: 34032
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "WaitPVPInviteUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.WaitPVPInviteUIController"),
				m_ctrlName = "WaitPVPInviteUIController"
			}
		};

		// Token: 0x040084F1 RID: 34033
		private WaitPVPInviteUIController m_waitPVPInviteUIController;

		// Token: 0x040084F2 RID: 34034
		private string m_targetUserId;

		// Token: 0x040084F3 RID: 34035
		private DateTime m_waitTimeout = DateTime.MinValue;

		// Token: 0x040084F4 RID: 34036
		[DoNotToLua]
		private WaitPVPInviteUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040084F5 RID: 34037
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040084F6 RID: 34038
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040084F7 RID: 34039
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040084F8 RID: 34040
		private LuaFunction m_Finalize_hotfix;

		// Token: 0x040084F9 RID: 34041
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040084FA RID: 34042
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x040084FB RID: 34043
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x040084FC RID: 34044
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040084FD RID: 34045
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040084FE RID: 34046
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x040084FF RID: 34047
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x04008500 RID: 34048
		private LuaFunction m_InitWaitPVPInviteUIController_hotfix;

		// Token: 0x04008501 RID: 34049
		private LuaFunction m_UninitWaitPVPInviteUIController_hotfix;

		// Token: 0x04008502 RID: 34050
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008503 RID: 34051
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04008504 RID: 34052
		private LuaFunction m_StartBattlePracticeInviteNetTaskString_hotfix;

		// Token: 0x04008505 RID: 34053
		private LuaFunction m_CloseAndPause_hotfix;

		// Token: 0x04008506 RID: 34054
		private LuaFunction m_WaitPVPInviteUIController_OnCancel_hotfix;

		// Token: 0x04008507 RID: 34055
		private LuaFunction m_PlayerContext_OnOnBattlePracticeFailNtf_hotfix;

		// Token: 0x04008508 RID: 34056
		private LuaFunction m_PlayerContext_OnBattlePracticeDeclinedNtf_hotfix;

		// Token: 0x04008509 RID: 34057
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400850A RID: 34058
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000C0F RID: 3087
		public new class LuaExportHelper
		{
			// Token: 0x0600D888 RID: 55432 RVA: 0x003AE288 File Offset: 0x003AC488
			public LuaExportHelper(WaitPVPInviteUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D889 RID: 55433 RVA: 0x003AE298 File Offset: 0x003AC498
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D88A RID: 55434 RVA: 0x003AE2A8 File Offset: 0x003AC4A8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D88B RID: 55435 RVA: 0x003AE2B8 File Offset: 0x003AC4B8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D88C RID: 55436 RVA: 0x003AE2C8 File Offset: 0x003AC4C8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D88D RID: 55437 RVA: 0x003AE2D8 File Offset: 0x003AC4D8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D88E RID: 55438 RVA: 0x003AE2E8 File Offset: 0x003AC4E8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D88F RID: 55439 RVA: 0x003AE2F8 File Offset: 0x003AC4F8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D890 RID: 55440 RVA: 0x003AE308 File Offset: 0x003AC508
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D891 RID: 55441 RVA: 0x003AE318 File Offset: 0x003AC518
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D892 RID: 55442 RVA: 0x003AE328 File Offset: 0x003AC528
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D893 RID: 55443 RVA: 0x003AE338 File Offset: 0x003AC538
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D894 RID: 55444 RVA: 0x003AE348 File Offset: 0x003AC548
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D895 RID: 55445 RVA: 0x003AE358 File Offset: 0x003AC558
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D896 RID: 55446 RVA: 0x003AE368 File Offset: 0x003AC568
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D897 RID: 55447 RVA: 0x003AE378 File Offset: 0x003AC578
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D898 RID: 55448 RVA: 0x003AE388 File Offset: 0x003AC588
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D899 RID: 55449 RVA: 0x003AE398 File Offset: 0x003AC598
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D89A RID: 55450 RVA: 0x003AE3A8 File Offset: 0x003AC5A8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D89B RID: 55451 RVA: 0x003AE3B8 File Offset: 0x003AC5B8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D89C RID: 55452 RVA: 0x003AE3C8 File Offset: 0x003AC5C8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D89D RID: 55453 RVA: 0x003AE3D8 File Offset: 0x003AC5D8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D89E RID: 55454 RVA: 0x003AE3E8 File Offset: 0x003AC5E8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D89F RID: 55455 RVA: 0x003AE3F8 File Offset: 0x003AC5F8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002A26 RID: 10790
			// (get) Token: 0x0600D8A0 RID: 55456 RVA: 0x003AE408 File Offset: 0x003AC608
			// (set) Token: 0x0600D8A1 RID: 55457 RVA: 0x003AE418 File Offset: 0x003AC618
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

			// Token: 0x17002A27 RID: 10791
			// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x003AE428 File Offset: 0x003AC628
			// (set) Token: 0x0600D8A3 RID: 55459 RVA: 0x003AE438 File Offset: 0x003AC638
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

			// Token: 0x17002A28 RID: 10792
			// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x003AE448 File Offset: 0x003AC648
			// (set) Token: 0x0600D8A5 RID: 55461 RVA: 0x003AE458 File Offset: 0x003AC658
			public WaitPVPInviteUIController m_waitPVPInviteUIController
			{
				get
				{
					return this.m_owner.m_waitPVPInviteUIController;
				}
				set
				{
					this.m_owner.m_waitPVPInviteUIController = value;
				}
			}

			// Token: 0x17002A29 RID: 10793
			// (get) Token: 0x0600D8A6 RID: 55462 RVA: 0x003AE468 File Offset: 0x003AC668
			// (set) Token: 0x0600D8A7 RID: 55463 RVA: 0x003AE478 File Offset: 0x003AC678
			public string m_targetUserId
			{
				get
				{
					return this.m_owner.m_targetUserId;
				}
				set
				{
					this.m_owner.m_targetUserId = value;
				}
			}

			// Token: 0x17002A2A RID: 10794
			// (get) Token: 0x0600D8A8 RID: 55464 RVA: 0x003AE488 File Offset: 0x003AC688
			// (set) Token: 0x0600D8A9 RID: 55465 RVA: 0x003AE498 File Offset: 0x003AC698
			public DateTime m_waitTimeout
			{
				get
				{
					return this.m_owner.m_waitTimeout;
				}
				set
				{
					this.m_owner.m_waitTimeout = value;
				}
			}

			// Token: 0x17002A2B RID: 10795
			// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x003AE4A8 File Offset: 0x003AC6A8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002A2C RID: 10796
			// (get) Token: 0x0600D8AB RID: 55467 RVA: 0x003AE4B8 File Offset: 0x003AC6B8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D8AC RID: 55468 RVA: 0x003AE4C8 File Offset: 0x003AC6C8
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D8AD RID: 55469 RVA: 0x003AE4D8 File Offset: 0x003AC6D8
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D8AE RID: 55470 RVA: 0x003AE4E8 File Offset: 0x003AC6E8
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600D8AF RID: 55471 RVA: 0x003AE4F8 File Offset: 0x003AC6F8
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D8B0 RID: 55472 RVA: 0x003AE508 File Offset: 0x003AC708
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D8B1 RID: 55473 RVA: 0x003AE518 File Offset: 0x003AC718
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x0600D8B2 RID: 55474 RVA: 0x003AE528 File Offset: 0x003AC728
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D8B3 RID: 55475 RVA: 0x003AE538 File Offset: 0x003AC738
			public void InitWaitPVPInviteUIController()
			{
				this.m_owner.InitWaitPVPInviteUIController();
			}

			// Token: 0x0600D8B4 RID: 55476 RVA: 0x003AE548 File Offset: 0x003AC748
			public void UninitWaitPVPInviteUIController()
			{
				this.m_owner.UninitWaitPVPInviteUIController();
			}

			// Token: 0x0600D8B5 RID: 55477 RVA: 0x003AE558 File Offset: 0x003AC758
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D8B6 RID: 55478 RVA: 0x003AE568 File Offset: 0x003AC768
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600D8B7 RID: 55479 RVA: 0x003AE578 File Offset: 0x003AC778
			public void StartBattlePracticeInviteNetTask(string userId)
			{
				this.m_owner.StartBattlePracticeInviteNetTask(userId);
			}

			// Token: 0x0600D8B8 RID: 55480 RVA: 0x003AE588 File Offset: 0x003AC788
			public void CloseAndPause()
			{
				this.m_owner.CloseAndPause();
			}

			// Token: 0x0600D8B9 RID: 55481 RVA: 0x003AE598 File Offset: 0x003AC798
			public void WaitPVPInviteUIController_OnCancel()
			{
				this.m_owner.WaitPVPInviteUIController_OnCancel();
			}

			// Token: 0x0600D8BA RID: 55482 RVA: 0x003AE5A8 File Offset: 0x003AC7A8
			public void PlayerContext_OnOnBattlePracticeFailNtf()
			{
				this.m_owner.PlayerContext_OnOnBattlePracticeFailNtf();
			}

			// Token: 0x0600D8BB RID: 55483 RVA: 0x003AE5B8 File Offset: 0x003AC7B8
			public void PlayerContext_OnBattlePracticeDeclinedNtf()
			{
				this.m_owner.PlayerContext_OnBattlePracticeDeclinedNtf();
			}

			// Token: 0x0400850B RID: 34059
			private WaitPVPInviteUITask m_owner;
		}
	}
}
