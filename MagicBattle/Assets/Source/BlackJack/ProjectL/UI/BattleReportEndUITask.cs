using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AA2 RID: 2722
	[HotFix]
	public class BattleReportEndUITask : UITask
	{
		// Token: 0x0600AF17 RID: 44823 RVA: 0x0030AA18 File Offset: 0x00308C18
		public BattleReportEndUITask(string name) : base(name)
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

		// Token: 0x0600AF18 RID: 44824 RVA: 0x0030AB0C File Offset: 0x00308D0C
		public static BattleReportEndUITask StartUITask(ArenaBattleReport battleReport)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BattleReportEndUITask).Name, null);
			uiintentCustom.SetParam("ArenaBattleReport", battleReport);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as BattleReportEndUITask;
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x0030AB50 File Offset: 0x00308D50
		public static BattleReportEndUITask StartUITask(RealTimePVPBattleReport battleReport)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BattleReportEndUITask).Name, null);
			uiintentCustom.SetParam("RealTimePVPBattleReport", battleReport);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as BattleReportEndUITask;
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x0030AB94 File Offset: 0x00308D94
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

		// Token: 0x0600AF1B RID: 44827 RVA: 0x0030AC20 File Offset: 0x00308E20
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

		// Token: 0x0600AF1C RID: 44828 RVA: 0x0030ACAC File Offset: 0x00308EAC
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
			this.m_arenaBattleReport = null;
			this.m_realtimePVPBattleReport = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_arenaBattleReport = uiintentCustom.GetClassParam<ArenaBattleReport>("ArenaBattleReport");
				this.m_realtimePVPBattleReport = uiintentCustom.GetClassParam<RealTimePVPBattleReport>("RealTimePVPBattleReport");
			}
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x0030AD5C File Offset: 0x00308F5C
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
			if (this.m_battleReportEndUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_battleReportEndUIController = (this.m_uiCtrlArray[0] as BattleReportEndUIController);
				}
				if (!(this.m_battleReportEndUIController != null))
				{
					Debug.LogError("BattleReportEndUIController is null");
					return;
				}
				this.m_battleReportEndUIController.EventOnClose += this.BattleReportEndUIController_OnClose;
				this.m_battleReportEndUIController.EventOnPlayAgain += this.BattleReportEndUIController_OnPlayAgain;
			}
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x0030AE44 File Offset: 0x00309044
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
			if (this.m_battleReportEndUIController != null)
			{
				this.m_battleReportEndUIController.EventOnClose -= this.BattleReportEndUIController_OnClose;
				this.m_battleReportEndUIController.EventOnPlayAgain -= this.BattleReportEndUIController_OnPlayAgain;
				this.m_battleReportEndUIController = null;
			}
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x0030AEF0 File Offset: 0x003090F0
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
				if (this.m_arenaBattleReport != null)
				{
					this.m_battleReportEndUIController.Open(this.m_arenaBattleReport);
				}
				else if (this.m_realtimePVPBattleReport != null)
				{
					this.m_battleReportEndUIController.Open(this.m_realtimePVPBattleReport);
				}
			}
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x0030AF98 File Offset: 0x00309198
		private void BattleReportEndUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleReportEndUIController_OnClose_hotfix != null)
			{
				this.m_BattleReportEndUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleReportEndUIController.Close(delegate
			{
				base.Pause();
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			});
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x0030B010 File Offset: 0x00309210
		private void BattleReportEndUIController_OnPlayAgain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleReportEndUIController_OnPlayAgain_hotfix != null)
			{
				this.m_BattleReportEndUIController_OnPlayAgain_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleReportEndUIController.Close(delegate
			{
				base.Pause();
				if (this.EventOnPlayAgain != null)
				{
					this.EventOnPlayAgain();
				}
			});
		}

		// Token: 0x14000216 RID: 534
		// (add) Token: 0x0600AF22 RID: 44834 RVA: 0x0030B088 File Offset: 0x00309288
		// (remove) Token: 0x0600AF23 RID: 44835 RVA: 0x0030B124 File Offset: 0x00309324
		public event Action EventOnPlayAgain
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPlayAgainAction_hotfix != null)
				{
					this.m_add_EventOnPlayAgainAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPlayAgain;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPlayAgain, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPlayAgainAction_hotfix != null)
				{
					this.m_remove_EventOnPlayAgainAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPlayAgain;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPlayAgain, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000217 RID: 535
		// (add) Token: 0x0600AF24 RID: 44836 RVA: 0x0030B1C0 File Offset: 0x003093C0
		// (remove) Token: 0x0600AF25 RID: 44837 RVA: 0x0030B25C File Offset: 0x0030945C
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x0030B2F8 File Offset: 0x003094F8
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

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x0600AF27 RID: 44839 RVA: 0x0030B36C File Offset: 0x0030956C
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

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x0030B3E0 File Offset: 0x003095E0
		// (set) Token: 0x0600AF29 RID: 44841 RVA: 0x0030B400 File Offset: 0x00309600
		[DoNotToLua]
		public new BattleReportEndUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleReportEndUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x0030B40C File Offset: 0x0030960C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x0030B418 File Offset: 0x00309618
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x0030B420 File Offset: 0x00309620
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x0030B428 File Offset: 0x00309628
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600AF2E RID: 44846 RVA: 0x0030B434 File Offset: 0x00309634
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600AF2F RID: 44847 RVA: 0x0030B440 File Offset: 0x00309640
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600AF30 RID: 44848 RVA: 0x0030B44C File Offset: 0x0030964C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600AF31 RID: 44849 RVA: 0x0030B454 File Offset: 0x00309654
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x0030B45C File Offset: 0x0030965C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x0030B464 File Offset: 0x00309664
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600AF34 RID: 44852 RVA: 0x0030B46C File Offset: 0x0030966C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x0030B474 File Offset: 0x00309674
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x0030B47C File Offset: 0x0030967C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x0030B484 File Offset: 0x00309684
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x0030B490 File Offset: 0x00309690
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x0030B49C File Offset: 0x0030969C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x0030B4A8 File Offset: 0x003096A8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600AF3B RID: 44859 RVA: 0x0030B4B4 File Offset: 0x003096B4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x0030B4BC File Offset: 0x003096BC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x0030B4C4 File Offset: 0x003096C4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x0030B4CC File Offset: 0x003096CC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600AF3F RID: 44863 RVA: 0x0030B4D4 File Offset: 0x003096D4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x0030B4DC File Offset: 0x003096DC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x0030B4E4 File Offset: 0x003096E4
		private void __callDele_EventOnPlayAgain()
		{
			Action eventOnPlayAgain = this.EventOnPlayAgain;
			if (eventOnPlayAgain != null)
			{
				eventOnPlayAgain();
			}
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x0030B504 File Offset: 0x00309704
		private void __clearDele_EventOnPlayAgain()
		{
			this.EventOnPlayAgain = null;
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x0030B510 File Offset: 0x00309710
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x0030B530 File Offset: 0x00309730
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600AF47 RID: 44871 RVA: 0x0030B57C File Offset: 0x0030977C
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
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_BattleReportEndUIController_OnClose_hotfix = (luaObj.RawGet("BattleReportEndUIController_OnClose") as LuaFunction);
					this.m_BattleReportEndUIController_OnPlayAgain_hotfix = (luaObj.RawGet("BattleReportEndUIController_OnPlayAgain") as LuaFunction);
					this.m_add_EventOnPlayAgainAction_hotfix = (luaObj.RawGet("add_EventOnPlayAgain") as LuaFunction);
					this.m_remove_EventOnPlayAgainAction_hotfix = (luaObj.RawGet("remove_EventOnPlayAgain") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AF48 RID: 44872 RVA: 0x0030B7A8 File Offset: 0x003099A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleReportEndUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007252 RID: 29266
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleReportEndUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleReportEndUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007253 RID: 29267
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleReportEndUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleReportEndUIController"),
				m_ctrlName = "BattleReportEndUIController"
			}
		};

		// Token: 0x04007254 RID: 29268
		private BattleReportEndUIController m_battleReportEndUIController;

		// Token: 0x04007255 RID: 29269
		private ArenaBattleReport m_arenaBattleReport;

		// Token: 0x04007256 RID: 29270
		private RealTimePVPBattleReport m_realtimePVPBattleReport;

		// Token: 0x04007257 RID: 29271
		[DoNotToLua]
		private BattleReportEndUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007258 RID: 29272
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007259 RID: 29273
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400725A RID: 29274
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400725B RID: 29275
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400725C RID: 29276
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400725D RID: 29277
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400725E RID: 29278
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400725F RID: 29279
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007260 RID: 29280
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007261 RID: 29281
		private LuaFunction m_BattleReportEndUIController_OnClose_hotfix;

		// Token: 0x04007262 RID: 29282
		private LuaFunction m_BattleReportEndUIController_OnPlayAgain_hotfix;

		// Token: 0x04007263 RID: 29283
		private LuaFunction m_add_EventOnPlayAgainAction_hotfix;

		// Token: 0x04007264 RID: 29284
		private LuaFunction m_remove_EventOnPlayAgainAction_hotfix;

		// Token: 0x04007265 RID: 29285
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007266 RID: 29286
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04007267 RID: 29287
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007268 RID: 29288
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000AA3 RID: 2723
		public new class LuaExportHelper
		{
			// Token: 0x0600AF49 RID: 44873 RVA: 0x0030B810 File Offset: 0x00309A10
			public LuaExportHelper(BattleReportEndUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AF4A RID: 44874 RVA: 0x0030B820 File Offset: 0x00309A20
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600AF4B RID: 44875 RVA: 0x0030B830 File Offset: 0x00309A30
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600AF4C RID: 44876 RVA: 0x0030B840 File Offset: 0x00309A40
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600AF4D RID: 44877 RVA: 0x0030B850 File Offset: 0x00309A50
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600AF4E RID: 44878 RVA: 0x0030B860 File Offset: 0x00309A60
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600AF4F RID: 44879 RVA: 0x0030B870 File Offset: 0x00309A70
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600AF50 RID: 44880 RVA: 0x0030B880 File Offset: 0x00309A80
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600AF51 RID: 44881 RVA: 0x0030B890 File Offset: 0x00309A90
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600AF52 RID: 44882 RVA: 0x0030B8A0 File Offset: 0x00309AA0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600AF53 RID: 44883 RVA: 0x0030B8B0 File Offset: 0x00309AB0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600AF54 RID: 44884 RVA: 0x0030B8C0 File Offset: 0x00309AC0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600AF55 RID: 44885 RVA: 0x0030B8D0 File Offset: 0x00309AD0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600AF56 RID: 44886 RVA: 0x0030B8E0 File Offset: 0x00309AE0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600AF57 RID: 44887 RVA: 0x0030B8F0 File Offset: 0x00309AF0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600AF58 RID: 44888 RVA: 0x0030B900 File Offset: 0x00309B00
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600AF59 RID: 44889 RVA: 0x0030B910 File Offset: 0x00309B10
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600AF5A RID: 44890 RVA: 0x0030B920 File Offset: 0x00309B20
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600AF5B RID: 44891 RVA: 0x0030B930 File Offset: 0x00309B30
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600AF5C RID: 44892 RVA: 0x0030B940 File Offset: 0x00309B40
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600AF5D RID: 44893 RVA: 0x0030B950 File Offset: 0x00309B50
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600AF5E RID: 44894 RVA: 0x0030B960 File Offset: 0x00309B60
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600AF5F RID: 44895 RVA: 0x0030B970 File Offset: 0x00309B70
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600AF60 RID: 44896 RVA: 0x0030B980 File Offset: 0x00309B80
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600AF61 RID: 44897 RVA: 0x0030B990 File Offset: 0x00309B90
			public void __callDele_EventOnPlayAgain()
			{
				this.m_owner.__callDele_EventOnPlayAgain();
			}

			// Token: 0x0600AF62 RID: 44898 RVA: 0x0030B9A0 File Offset: 0x00309BA0
			public void __clearDele_EventOnPlayAgain()
			{
				this.m_owner.__clearDele_EventOnPlayAgain();
			}

			// Token: 0x0600AF63 RID: 44899 RVA: 0x0030B9B0 File Offset: 0x00309BB0
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600AF64 RID: 44900 RVA: 0x0030B9C0 File Offset: 0x00309BC0
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002381 RID: 9089
			// (get) Token: 0x0600AF65 RID: 44901 RVA: 0x0030B9D0 File Offset: 0x00309BD0
			// (set) Token: 0x0600AF66 RID: 44902 RVA: 0x0030B9E0 File Offset: 0x00309BE0
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

			// Token: 0x17002382 RID: 9090
			// (get) Token: 0x0600AF67 RID: 44903 RVA: 0x0030B9F0 File Offset: 0x00309BF0
			// (set) Token: 0x0600AF68 RID: 44904 RVA: 0x0030BA00 File Offset: 0x00309C00
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

			// Token: 0x17002383 RID: 9091
			// (get) Token: 0x0600AF69 RID: 44905 RVA: 0x0030BA10 File Offset: 0x00309C10
			// (set) Token: 0x0600AF6A RID: 44906 RVA: 0x0030BA20 File Offset: 0x00309C20
			public BattleReportEndUIController m_battleReportEndUIController
			{
				get
				{
					return this.m_owner.m_battleReportEndUIController;
				}
				set
				{
					this.m_owner.m_battleReportEndUIController = value;
				}
			}

			// Token: 0x17002384 RID: 9092
			// (get) Token: 0x0600AF6B RID: 44907 RVA: 0x0030BA30 File Offset: 0x00309C30
			// (set) Token: 0x0600AF6C RID: 44908 RVA: 0x0030BA40 File Offset: 0x00309C40
			public ArenaBattleReport m_arenaBattleReport
			{
				get
				{
					return this.m_owner.m_arenaBattleReport;
				}
				set
				{
					this.m_owner.m_arenaBattleReport = value;
				}
			}

			// Token: 0x17002385 RID: 9093
			// (get) Token: 0x0600AF6D RID: 44909 RVA: 0x0030BA50 File Offset: 0x00309C50
			// (set) Token: 0x0600AF6E RID: 44910 RVA: 0x0030BA60 File Offset: 0x00309C60
			public RealTimePVPBattleReport m_realtimePVPBattleReport
			{
				get
				{
					return this.m_owner.m_realtimePVPBattleReport;
				}
				set
				{
					this.m_owner.m_realtimePVPBattleReport = value;
				}
			}

			// Token: 0x17002386 RID: 9094
			// (get) Token: 0x0600AF6F RID: 44911 RVA: 0x0030BA70 File Offset: 0x00309C70
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002387 RID: 9095
			// (get) Token: 0x0600AF70 RID: 44912 RVA: 0x0030BA80 File Offset: 0x00309C80
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600AF71 RID: 44913 RVA: 0x0030BA90 File Offset: 0x00309C90
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600AF72 RID: 44914 RVA: 0x0030BAA0 File Offset: 0x00309CA0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600AF73 RID: 44915 RVA: 0x0030BAB0 File Offset: 0x00309CB0
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600AF74 RID: 44916 RVA: 0x0030BAC0 File Offset: 0x00309CC0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600AF75 RID: 44917 RVA: 0x0030BAD0 File Offset: 0x00309CD0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600AF76 RID: 44918 RVA: 0x0030BAE0 File Offset: 0x00309CE0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600AF77 RID: 44919 RVA: 0x0030BAF0 File Offset: 0x00309CF0
			public void BattleReportEndUIController_OnClose()
			{
				this.m_owner.BattleReportEndUIController_OnClose();
			}

			// Token: 0x0600AF78 RID: 44920 RVA: 0x0030BB00 File Offset: 0x00309D00
			public void BattleReportEndUIController_OnPlayAgain()
			{
				this.m_owner.BattleReportEndUIController_OnPlayAgain();
			}

			// Token: 0x04007269 RID: 29289
			private BattleReportEndUITask m_owner;
		}
	}
}
