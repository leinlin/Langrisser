using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009D4 RID: 2516
	[HotFix]
	public class AppScoreUITask : UITask
	{
		// Token: 0x060093A5 RID: 37797 RVA: 0x002A8AFC File Offset: 0x002A6CFC
		public AppScoreUITask(string name) : base(name)
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

		// Token: 0x060093A6 RID: 37798 RVA: 0x002A8BF0 File Offset: 0x002A6DF0
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
			if (this.m_appScoreUIController == null)
			{
				this.m_appScoreUIController = (this.m_uiCtrlArray[0] as AppScoreUIController);
				if (this.m_appScoreUIController != null)
				{
					this.m_appScoreUIController.EventOnClose += this.AppScoreUIController_OnCloseAppScore;
					this.m_appScoreUIController.EventOnGoScore += this.AppScoreUIController_OnGoScore;
				}
				else
				{
					global::Debug.LogError("AppScoreUIController is null!");
				}
			}
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x002A8CC8 File Offset: 0x002A6EC8
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
			if (this.m_appScoreUIController != null)
			{
				this.m_appScoreUIController.EventOnClose -= this.AppScoreUIController_OnCloseAppScore;
				this.m_appScoreUIController.EventOnGoScore -= this.AppScoreUIController_OnGoScore;
				this.m_appScoreUIController = null;
			}
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x002A8D74 File Offset: 0x002A6F74
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
				this.m_appScoreUIController.PlayOpenTween();
			}
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x002A8DEC File Offset: 0x002A6FEC
		private void AppScoreUIController_OnGoScore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppScoreUIController_OnGoScore_hotfix != null)
			{
				this.m_AppScoreUIController_OnGoScore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.doOpenRequestReview();
			this.CloseSelf();
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x002A8E5C File Offset: 0x002A705C
		private void AppScoreUIController_OnCloseAppScore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppScoreUIController_OnCloseAppScore_hotfix != null)
			{
				this.m_AppScoreUIController_OnCloseAppScore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseSelf();
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x002A8EC4 File Offset: 0x002A70C4
		private void CloseSelf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSelf_hotfix != null)
			{
				this.m_CloseSelf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Stop();
			PlayerPrefs.SetInt("SHOW_APPSCORE", 1);
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x002A8F4C File Offset: 0x002A714C
		public static void ShowAppScoreUI(UIIntent currIntent)
		{
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x002A8F50 File Offset: 0x002A7150
		public static bool CanScore()
		{
			return !PlayerPrefs.HasKey("SHOW_APPSCORE") || PlayerPrefs.GetInt("SHOW_APPSCORE") != 1;
		}

		// Token: 0x140001A1 RID: 417
		// (add) Token: 0x060093AE RID: 37806 RVA: 0x002A8F74 File Offset: 0x002A7174
		// (remove) Token: 0x060093AF RID: 37807 RVA: 0x002A9010 File Offset: 0x002A7210
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

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x060093B0 RID: 37808 RVA: 0x002A90AC File Offset: 0x002A72AC
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

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x060093B1 RID: 37809 RVA: 0x002A9120 File Offset: 0x002A7320
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

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x060093B2 RID: 37810 RVA: 0x002A9194 File Offset: 0x002A7394
		// (set) Token: 0x060093B3 RID: 37811 RVA: 0x002A91B4 File Offset: 0x002A73B4
		[DoNotToLua]
		public new AppScoreUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AppScoreUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x002A91C0 File Offset: 0x002A73C0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x002A91CC File Offset: 0x002A73CC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x002A91D4 File Offset: 0x002A73D4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x002A91DC File Offset: 0x002A73DC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x002A91E8 File Offset: 0x002A73E8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x002A91F4 File Offset: 0x002A73F4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x002A9200 File Offset: 0x002A7400
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x002A9208 File Offset: 0x002A7408
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x002A9210 File Offset: 0x002A7410
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060093BD RID: 37821 RVA: 0x002A9218 File Offset: 0x002A7418
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x002A9220 File Offset: 0x002A7420
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x002A9228 File Offset: 0x002A7428
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x002A9230 File Offset: 0x002A7430
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x002A9238 File Offset: 0x002A7438
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060093C2 RID: 37826 RVA: 0x002A9244 File Offset: 0x002A7444
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060093C3 RID: 37827 RVA: 0x002A9250 File Offset: 0x002A7450
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x002A925C File Offset: 0x002A745C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060093C5 RID: 37829 RVA: 0x002A9268 File Offset: 0x002A7468
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x002A9270 File Offset: 0x002A7470
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x002A9278 File Offset: 0x002A7478
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x002A9280 File Offset: 0x002A7480
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x002A9288 File Offset: 0x002A7488
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x002A9290 File Offset: 0x002A7490
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060093CB RID: 37835 RVA: 0x002A9298 File Offset: 0x002A7498
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x060093CC RID: 37836 RVA: 0x002A92B8 File Offset: 0x002A74B8
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x002A92C4 File Offset: 0x002A74C4
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_AppScoreUIController_OnGoScore_hotfix = (luaObj.RawGet("AppScoreUIController_OnGoScore") as LuaFunction);
					this.m_AppScoreUIController_OnCloseAppScore_hotfix = (luaObj.RawGet("AppScoreUIController_OnCloseAppScore") as LuaFunction);
					this.m_CloseSelf_hotfix = (luaObj.RawGet("CloseSelf") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x002A948C File Offset: 0x002A768C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AppScoreUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040066B0 RID: 26288
		private AppScoreUIController m_appScoreUIController;

		// Token: 0x040066B1 RID: 26289
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "AppScoreUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/AppScore_ABS/Prefab/AppScoreUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040066B2 RID: 26290
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "AppScoreUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.AppScoreUIController"),
				m_ctrlName = "AppScoreUIController"
			}
		};

		// Token: 0x040066B3 RID: 26291
		public const int APPSCORE_RIFTID = 104;

		// Token: 0x040066B4 RID: 26292
		public const string SHOW_APPSCORE_KEY = "SHOW_APPSCORE";

		// Token: 0x040066B5 RID: 26293
		[DoNotToLua]
		private AppScoreUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040066B6 RID: 26294
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040066B7 RID: 26295
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040066B8 RID: 26296
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040066B9 RID: 26297
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040066BA RID: 26298
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040066BB RID: 26299
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040066BC RID: 26300
		private LuaFunction m_AppScoreUIController_OnGoScore_hotfix;

		// Token: 0x040066BD RID: 26301
		private LuaFunction m_AppScoreUIController_OnCloseAppScore_hotfix;

		// Token: 0x040066BE RID: 26302
		private LuaFunction m_CloseSelf_hotfix;

		// Token: 0x040066BF RID: 26303
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040066C0 RID: 26304
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040066C1 RID: 26305
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040066C2 RID: 26306
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x020009D5 RID: 2517
		public new class LuaExportHelper
		{
			// Token: 0x060093CF RID: 37839 RVA: 0x002A94F4 File Offset: 0x002A76F4
			public LuaExportHelper(AppScoreUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060093D0 RID: 37840 RVA: 0x002A9504 File Offset: 0x002A7704
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060093D1 RID: 37841 RVA: 0x002A9514 File Offset: 0x002A7714
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060093D2 RID: 37842 RVA: 0x002A9524 File Offset: 0x002A7724
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060093D3 RID: 37843 RVA: 0x002A9534 File Offset: 0x002A7734
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060093D4 RID: 37844 RVA: 0x002A9544 File Offset: 0x002A7744
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060093D5 RID: 37845 RVA: 0x002A9554 File Offset: 0x002A7754
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060093D6 RID: 37846 RVA: 0x002A9564 File Offset: 0x002A7764
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060093D7 RID: 37847 RVA: 0x002A9574 File Offset: 0x002A7774
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060093D8 RID: 37848 RVA: 0x002A9584 File Offset: 0x002A7784
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060093D9 RID: 37849 RVA: 0x002A9594 File Offset: 0x002A7794
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060093DA RID: 37850 RVA: 0x002A95A4 File Offset: 0x002A77A4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060093DB RID: 37851 RVA: 0x002A95B4 File Offset: 0x002A77B4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060093DC RID: 37852 RVA: 0x002A95C4 File Offset: 0x002A77C4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060093DD RID: 37853 RVA: 0x002A95D4 File Offset: 0x002A77D4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060093DE RID: 37854 RVA: 0x002A95E4 File Offset: 0x002A77E4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060093DF RID: 37855 RVA: 0x002A95F4 File Offset: 0x002A77F4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060093E0 RID: 37856 RVA: 0x002A9604 File Offset: 0x002A7804
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060093E1 RID: 37857 RVA: 0x002A9614 File Offset: 0x002A7814
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060093E2 RID: 37858 RVA: 0x002A9624 File Offset: 0x002A7824
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060093E3 RID: 37859 RVA: 0x002A9634 File Offset: 0x002A7834
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060093E4 RID: 37860 RVA: 0x002A9644 File Offset: 0x002A7844
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060093E5 RID: 37861 RVA: 0x002A9654 File Offset: 0x002A7854
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060093E6 RID: 37862 RVA: 0x002A9664 File Offset: 0x002A7864
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060093E7 RID: 37863 RVA: 0x002A9674 File Offset: 0x002A7874
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x060093E8 RID: 37864 RVA: 0x002A9684 File Offset: 0x002A7884
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17001E78 RID: 7800
			// (get) Token: 0x060093E9 RID: 37865 RVA: 0x002A9694 File Offset: 0x002A7894
			// (set) Token: 0x060093EA RID: 37866 RVA: 0x002A96A4 File Offset: 0x002A78A4
			public AppScoreUIController m_appScoreUIController
			{
				get
				{
					return this.m_owner.m_appScoreUIController;
				}
				set
				{
					this.m_owner.m_appScoreUIController = value;
				}
			}

			// Token: 0x17001E79 RID: 7801
			// (get) Token: 0x060093EB RID: 37867 RVA: 0x002A96B4 File Offset: 0x002A78B4
			// (set) Token: 0x060093EC RID: 37868 RVA: 0x002A96C4 File Offset: 0x002A78C4
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

			// Token: 0x17001E7A RID: 7802
			// (get) Token: 0x060093ED RID: 37869 RVA: 0x002A96D4 File Offset: 0x002A78D4
			// (set) Token: 0x060093EE RID: 37870 RVA: 0x002A96E4 File Offset: 0x002A78E4
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

			// Token: 0x17001E7B RID: 7803
			// (get) Token: 0x060093EF RID: 37871 RVA: 0x002A96F4 File Offset: 0x002A78F4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001E7C RID: 7804
			// (get) Token: 0x060093F0 RID: 37872 RVA: 0x002A9704 File Offset: 0x002A7904
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060093F1 RID: 37873 RVA: 0x002A9714 File Offset: 0x002A7914
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060093F2 RID: 37874 RVA: 0x002A9724 File Offset: 0x002A7924
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060093F3 RID: 37875 RVA: 0x002A9734 File Offset: 0x002A7934
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060093F4 RID: 37876 RVA: 0x002A9744 File Offset: 0x002A7944
			public void AppScoreUIController_OnGoScore()
			{
				this.m_owner.AppScoreUIController_OnGoScore();
			}

			// Token: 0x060093F5 RID: 37877 RVA: 0x002A9754 File Offset: 0x002A7954
			public void AppScoreUIController_OnCloseAppScore()
			{
				this.m_owner.AppScoreUIController_OnCloseAppScore();
			}

			// Token: 0x060093F6 RID: 37878 RVA: 0x002A9764 File Offset: 0x002A7964
			public void CloseSelf()
			{
				this.m_owner.CloseSelf();
			}

			// Token: 0x040066C3 RID: 26307
			private AppScoreUITask m_owner;
		}
	}
}
