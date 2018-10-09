using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x0200101A RID: 4122
	[HotFix]
	public class EnergyStatusUITask : UITask
	{
		// Token: 0x06014D43 RID: 85315 RVA: 0x00547C2C File Offset: 0x00545E2C
		public EnergyStatusUITask(string name) : base(name)
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

		// Token: 0x06014D44 RID: 85316 RVA: 0x00547D20 File Offset: 0x00545F20
		public static EnergyStatusUITask StartUITask(Vector3 vector3)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(EnergyStatusUITask).Name, null);
			uiintentCustom.SetParam("EnergyStatusPostion", vector3);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as EnergyStatusUITask;
		}

		// Token: 0x06014D45 RID: 85317 RVA: 0x00547D68 File Offset: 0x00545F68
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
			bool flag = base.OnStart(intent);
			if (!flag)
			{
				global::Debug.LogError("EnergyStatusUITask base.OnStart fail!");
				return flag;
			}
			return flag;
		}

		// Token: 0x06014D46 RID: 85318 RVA: 0x00547E08 File Offset: 0x00546008
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

		// Token: 0x06014D47 RID: 85319 RVA: 0x00547E94 File Offset: 0x00546094
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
			if (this.m_energyStatusUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_energyStatusUIController = (this.m_uiCtrlArray[0] as EnergyStatusUIController);
				}
				if (!(this.m_energyStatusUIController != null))
				{
					global::Debug.LogError("EnergyStatusUIController is null");
					return;
				}
				this.m_energyStatusUIController.EventOnClose += this.EnergyStatusUIController_OnClose;
			}
		}

		// Token: 0x06014D48 RID: 85320 RVA: 0x00547F64 File Offset: 0x00546164
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
			if (this.m_energyStatusUIController != null)
			{
				this.m_energyStatusUIController.EventOnClose -= this.EnergyStatusUIController_OnClose;
				this.m_energyStatusUIController = null;
			}
		}

		// Token: 0x06014D49 RID: 85321 RVA: 0x00547FFC File Offset: 0x005461FC
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
				this.m_energyStatusUIController.SetEnergyStatusPosition(this.m_energyStatusPosition);
				this.m_energyStatusUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_energyStatusUIController.SetNow(projectLPlayerContext.GetServerTime());
			int num = projectLPlayerContext.GetEnergyMax() - projectLPlayerContext.GetEnergy();
			TimeSpan timeSpan = projectLPlayerContext.GetEnergyFlushTime() + TimeSpan.FromSeconds((double)configDataLoader.ConfigableConstId_EnergyAddPeriod) - projectLPlayerContext.GetServerTime();
			TimeSpan recoverAllTime = TimeSpan.Zero;
			if (num <= 0)
			{
				timeSpan = TimeSpan.Zero;
				recoverAllTime = TimeSpan.Zero;
			}
			else
			{
				recoverAllTime = timeSpan + TimeSpan.FromSeconds((double)((num - 1) * configDataLoader.ConfigableConstId_EnergyAddPeriod));
			}
			this.m_energyStatusUIController.SetRecoverTime(timeSpan);
			this.m_energyStatusUIController.SetRecoverAllTime(recoverAllTime);
		}

		// Token: 0x06014D4A RID: 85322 RVA: 0x00548138 File Offset: 0x00546338
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
			if (this.m_energyStatusUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateView();
			}
		}

		// Token: 0x06014D4B RID: 85323 RVA: 0x005481D8 File Offset: 0x005463D8
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
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_energyStatusPosition = uiintentCustom.GetStructParam<Vector3>("EnergyStatusPostion");
			}
		}

		// Token: 0x06014D4C RID: 85324 RVA: 0x00548268 File Offset: 0x00546468
		private void EnergyStatusUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnergyStatusUIController_OnClose_hotfix != null)
			{
				this.m_EnergyStatusUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x06014D4D RID: 85325 RVA: 0x005482D0 File Offset: 0x005464D0
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

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x06014D4E RID: 85326 RVA: 0x00548344 File Offset: 0x00546544
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

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x06014D4F RID: 85327 RVA: 0x005483B8 File Offset: 0x005465B8
		// (set) Token: 0x06014D50 RID: 85328 RVA: 0x005483D8 File Offset: 0x005465D8
		[DoNotToLua]
		public new EnergyStatusUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EnergyStatusUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014D51 RID: 85329 RVA: 0x005483E4 File Offset: 0x005465E4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014D52 RID: 85330 RVA: 0x005483F0 File Offset: 0x005465F0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06014D53 RID: 85331 RVA: 0x005483F8 File Offset: 0x005465F8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014D54 RID: 85332 RVA: 0x00548400 File Offset: 0x00546600
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014D55 RID: 85333 RVA: 0x0054840C File Offset: 0x0054660C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014D56 RID: 85334 RVA: 0x00548418 File Offset: 0x00546618
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014D57 RID: 85335 RVA: 0x00548424 File Offset: 0x00546624
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014D58 RID: 85336 RVA: 0x0054842C File Offset: 0x0054662C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014D59 RID: 85337 RVA: 0x00548434 File Offset: 0x00546634
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014D5A RID: 85338 RVA: 0x0054843C File Offset: 0x0054663C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06014D5B RID: 85339 RVA: 0x00548444 File Offset: 0x00546644
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06014D5C RID: 85340 RVA: 0x0054844C File Offset: 0x0054664C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06014D5D RID: 85341 RVA: 0x00548454 File Offset: 0x00546654
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06014D5E RID: 85342 RVA: 0x0054845C File Offset: 0x0054665C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06014D5F RID: 85343 RVA: 0x00548468 File Offset: 0x00546668
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06014D60 RID: 85344 RVA: 0x00548474 File Offset: 0x00546674
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06014D61 RID: 85345 RVA: 0x00548480 File Offset: 0x00546680
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06014D62 RID: 85346 RVA: 0x0054848C File Offset: 0x0054668C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06014D63 RID: 85347 RVA: 0x00548494 File Offset: 0x00546694
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014D64 RID: 85348 RVA: 0x0054849C File Offset: 0x0054669C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014D65 RID: 85349 RVA: 0x005484A4 File Offset: 0x005466A4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014D66 RID: 85350 RVA: 0x005484AC File Offset: 0x005466AC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014D67 RID: 85351 RVA: 0x005484B4 File Offset: 0x005466B4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014D68 RID: 85352 RVA: 0x005484BC File Offset: 0x005466BC
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_EnergyStatusUIController_OnClose_hotfix = (luaObj.RawGet("EnergyStatusUIController_OnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014D69 RID: 85353 RVA: 0x00548684 File Offset: 0x00546884
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EnergyStatusUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B675 RID: 46709
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "EnergyStatusUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/EnergyStatusUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B676 RID: 46710
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "EnergyStatusUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.EnergyStatusUIController"),
				m_ctrlName = "EnergyStatusUIController"
			}
		};

		// Token: 0x0400B677 RID: 46711
		private const string ParamKey_EnergyStatusPostion = "EnergyStatusPostion";

		// Token: 0x0400B678 RID: 46712
		private EnergyStatusUIController m_energyStatusUIController;

		// Token: 0x0400B679 RID: 46713
		private int m_nowSeconds;

		// Token: 0x0400B67A RID: 46714
		private Vector3 m_energyStatusPosition;

		// Token: 0x0400B67B RID: 46715
		[DoNotToLua]
		private EnergyStatusUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B67C RID: 46716
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B67D RID: 46717
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B67E RID: 46718
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B67F RID: 46719
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B680 RID: 46720
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B681 RID: 46721
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B682 RID: 46722
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B683 RID: 46723
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B684 RID: 46724
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400B685 RID: 46725
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400B686 RID: 46726
		private LuaFunction m_EnergyStatusUIController_OnClose_hotfix;

		// Token: 0x0400B687 RID: 46727
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B688 RID: 46728
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x0200101B RID: 4123
		public new class LuaExportHelper
		{
			// Token: 0x06014D6A RID: 85354 RVA: 0x005486EC File Offset: 0x005468EC
			public LuaExportHelper(EnergyStatusUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014D6B RID: 85355 RVA: 0x005486FC File Offset: 0x005468FC
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06014D6C RID: 85356 RVA: 0x0054870C File Offset: 0x0054690C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06014D6D RID: 85357 RVA: 0x0054871C File Offset: 0x0054691C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06014D6E RID: 85358 RVA: 0x0054872C File Offset: 0x0054692C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014D6F RID: 85359 RVA: 0x0054873C File Offset: 0x0054693C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014D70 RID: 85360 RVA: 0x0054874C File Offset: 0x0054694C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014D71 RID: 85361 RVA: 0x0054875C File Offset: 0x0054695C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014D72 RID: 85362 RVA: 0x0054876C File Offset: 0x0054696C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014D73 RID: 85363 RVA: 0x0054877C File Offset: 0x0054697C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014D74 RID: 85364 RVA: 0x0054878C File Offset: 0x0054698C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014D75 RID: 85365 RVA: 0x0054879C File Offset: 0x0054699C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014D76 RID: 85366 RVA: 0x005487AC File Offset: 0x005469AC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014D77 RID: 85367 RVA: 0x005487BC File Offset: 0x005469BC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014D78 RID: 85368 RVA: 0x005487CC File Offset: 0x005469CC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06014D79 RID: 85369 RVA: 0x005487DC File Offset: 0x005469DC
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06014D7A RID: 85370 RVA: 0x005487EC File Offset: 0x005469EC
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06014D7B RID: 85371 RVA: 0x005487FC File Offset: 0x005469FC
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06014D7C RID: 85372 RVA: 0x0054880C File Offset: 0x00546A0C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06014D7D RID: 85373 RVA: 0x0054881C File Offset: 0x00546A1C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06014D7E RID: 85374 RVA: 0x0054882C File Offset: 0x00546A2C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06014D7F RID: 85375 RVA: 0x0054883C File Offset: 0x00546A3C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06014D80 RID: 85376 RVA: 0x0054884C File Offset: 0x00546A4C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06014D81 RID: 85377 RVA: 0x0054885C File Offset: 0x00546A5C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003D83 RID: 15747
			// (get) Token: 0x06014D82 RID: 85378 RVA: 0x0054886C File Offset: 0x00546A6C
			// (set) Token: 0x06014D83 RID: 85379 RVA: 0x0054887C File Offset: 0x00546A7C
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

			// Token: 0x17003D84 RID: 15748
			// (get) Token: 0x06014D84 RID: 85380 RVA: 0x0054888C File Offset: 0x00546A8C
			// (set) Token: 0x06014D85 RID: 85381 RVA: 0x0054889C File Offset: 0x00546A9C
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

			// Token: 0x17003D85 RID: 15749
			// (get) Token: 0x06014D86 RID: 85382 RVA: 0x005488AC File Offset: 0x00546AAC
			public static string ParamKey_EnergyStatusPostion
			{
				get
				{
					return "EnergyStatusPostion";
				}
			}

			// Token: 0x17003D86 RID: 15750
			// (get) Token: 0x06014D87 RID: 85383 RVA: 0x005488B4 File Offset: 0x00546AB4
			// (set) Token: 0x06014D88 RID: 85384 RVA: 0x005488C4 File Offset: 0x00546AC4
			public EnergyStatusUIController m_energyStatusUIController
			{
				get
				{
					return this.m_owner.m_energyStatusUIController;
				}
				set
				{
					this.m_owner.m_energyStatusUIController = value;
				}
			}

			// Token: 0x17003D87 RID: 15751
			// (get) Token: 0x06014D89 RID: 85385 RVA: 0x005488D4 File Offset: 0x00546AD4
			// (set) Token: 0x06014D8A RID: 85386 RVA: 0x005488E4 File Offset: 0x00546AE4
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x17003D88 RID: 15752
			// (get) Token: 0x06014D8B RID: 85387 RVA: 0x005488F4 File Offset: 0x00546AF4
			// (set) Token: 0x06014D8C RID: 85388 RVA: 0x00548904 File Offset: 0x00546B04
			public Vector3 m_energyStatusPosition
			{
				get
				{
					return this.m_owner.m_energyStatusPosition;
				}
				set
				{
					this.m_owner.m_energyStatusPosition = value;
				}
			}

			// Token: 0x17003D89 RID: 15753
			// (get) Token: 0x06014D8D RID: 85389 RVA: 0x00548914 File Offset: 0x00546B14
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003D8A RID: 15754
			// (get) Token: 0x06014D8E RID: 85390 RVA: 0x00548924 File Offset: 0x00546B24
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06014D8F RID: 85391 RVA: 0x00548934 File Offset: 0x00546B34
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06014D90 RID: 85392 RVA: 0x00548944 File Offset: 0x00546B44
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06014D91 RID: 85393 RVA: 0x00548954 File Offset: 0x00546B54
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014D92 RID: 85394 RVA: 0x00548964 File Offset: 0x00546B64
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014D93 RID: 85395 RVA: 0x00548974 File Offset: 0x00546B74
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014D94 RID: 85396 RVA: 0x00548984 File Offset: 0x00546B84
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06014D95 RID: 85397 RVA: 0x00548994 File Offset: 0x00546B94
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06014D96 RID: 85398 RVA: 0x005489A4 File Offset: 0x00546BA4
			public void EnergyStatusUIController_OnClose()
			{
				this.m_owner.EnergyStatusUIController_OnClose();
			}

			// Token: 0x0400B689 RID: 46729
			private EnergyStatusUITask m_owner;
		}
	}
}
