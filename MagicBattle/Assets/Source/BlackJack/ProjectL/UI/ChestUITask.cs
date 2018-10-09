using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BA4 RID: 2980
	[HotFix]
	public class ChestUITask : UITask
	{
		// Token: 0x0600CC11 RID: 52241 RVA: 0x00382EB0 File Offset: 0x003810B0
		public ChestUITask(string name) : base(name)
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

		// Token: 0x0600CC12 RID: 52242 RVA: 0x00382FAC File Offset: 0x003811AC
		public static ChestUITask StartUITask(BattleReward reward, bool isFirstWin, bool isAutoOpen)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(ChestUITask).Name, null);
			uiintentCustom.SetParam("BattleReward", reward);
			uiintentCustom.SetParam("IsFirstWin", isFirstWin);
			uiintentCustom.SetParam("AutoOpen", isAutoOpen);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as ChestUITask;
		}

		// Token: 0x0600CC13 RID: 52243 RVA: 0x00383010 File Offset: 0x00381210
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

		// Token: 0x0600CC14 RID: 52244 RVA: 0x0038309C File Offset: 0x0038129C
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

		// Token: 0x0600CC15 RID: 52245 RVA: 0x00383128 File Offset: 0x00381328
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
			this.m_battleReward = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_battleReward = uiintentCustom.GetClassParam<BattleReward>("BattleReward");
				this.m_isFirstWin = uiintentCustom.GetStructParam<bool>("IsFirstWin");
				this.m_isAutoOpen = uiintentCustom.GetStructParam<bool>("AutoOpen");
			}
		}

		// Token: 0x0600CC16 RID: 52246 RVA: 0x003831E0 File Offset: 0x003813E0
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			if (this.m_battleReward != null)
			{
				foreach (Goods goods in this.m_battleReward.Goods)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				}
				foreach (Goods goods2 in this.m_battleReward.TeamGoods1)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
				}
				foreach (Goods goods3 in this.m_battleReward.TeamGoods2)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods3.GoodsType, goods3.Id));
				}
				foreach (Goods goods4 in this.m_battleReward.FriendGoods)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods4.GoodsType, goods4.Id));
				}
				foreach (Goods goods5 in this.m_battleReward.DailyGoods)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods5.GoodsType, goods5.Id));
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CC17 RID: 52247 RVA: 0x00383454 File Offset: 0x00381654
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
			if (this.m_chestUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_chestUIController = (this.m_uiCtrlArray[0] as ChestUIController);
				}
				if (this.m_chestUIController != null)
				{
					this.m_chestUIController.EventOnClose += this.ChestUIController_OnClose;
				}
				else
				{
					Debug.LogError("ChestUIController is null");
				}
			}
		}

		// Token: 0x0600CC18 RID: 52248 RVA: 0x00383524 File Offset: 0x00381724
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
			if (this.m_chestUIController != null)
			{
				this.m_chestUIController.EventOnClose -= this.ChestUIController_OnClose;
				this.m_chestUIController = null;
			}
		}

		// Token: 0x0600CC19 RID: 52249 RVA: 0x003835BC File Offset: 0x003817BC
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
			if (this.m_battleReward != null)
			{
				this.m_chestUIController.ShowReward(this.m_battleReward, this.m_isFirstWin, this.m_isAutoOpen);
			}
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x00383644 File Offset: 0x00381844
		private void ChestUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChestUIController_OnClose_hotfix != null)
			{
				this.m_ChestUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x14000276 RID: 630
		// (add) Token: 0x0600CC1B RID: 52251 RVA: 0x003836C0 File Offset: 0x003818C0
		// (remove) Token: 0x0600CC1C RID: 52252 RVA: 0x0038375C File Offset: 0x0038195C
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

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600CC1D RID: 52253 RVA: 0x003837F8 File Offset: 0x003819F8
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

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600CC1E RID: 52254 RVA: 0x0038386C File Offset: 0x00381A6C
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

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600CC1F RID: 52255 RVA: 0x003838E0 File Offset: 0x00381AE0
		// (set) Token: 0x0600CC20 RID: 52256 RVA: 0x00383900 File Offset: 0x00381B00
		[DoNotToLua]
		public new ChestUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChestUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x0038390C File Offset: 0x00381B0C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600CC22 RID: 52258 RVA: 0x00383918 File Offset: 0x00381B18
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600CC23 RID: 52259 RVA: 0x00383920 File Offset: 0x00381B20
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600CC24 RID: 52260 RVA: 0x00383928 File Offset: 0x00381B28
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600CC25 RID: 52261 RVA: 0x00383934 File Offset: 0x00381B34
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CC26 RID: 52262 RVA: 0x00383940 File Offset: 0x00381B40
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600CC27 RID: 52263 RVA: 0x0038394C File Offset: 0x00381B4C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CC28 RID: 52264 RVA: 0x00383954 File Offset: 0x00381B54
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600CC29 RID: 52265 RVA: 0x0038395C File Offset: 0x00381B5C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600CC2A RID: 52266 RVA: 0x00383964 File Offset: 0x00381B64
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600CC2B RID: 52267 RVA: 0x0038396C File Offset: 0x00381B6C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600CC2C RID: 52268 RVA: 0x00383974 File Offset: 0x00381B74
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x0038397C File Offset: 0x00381B7C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x00383984 File Offset: 0x00381B84
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600CC2F RID: 52271 RVA: 0x00383990 File Offset: 0x00381B90
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x0038399C File Offset: 0x00381B9C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x003839A8 File Offset: 0x00381BA8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x003839B4 File Offset: 0x00381BB4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x003839BC File Offset: 0x00381BBC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600CC34 RID: 52276 RVA: 0x003839C4 File Offset: 0x00381BC4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x003839CC File Offset: 0x00381BCC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x003839D4 File Offset: 0x00381BD4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600CC37 RID: 52279 RVA: 0x003839DC File Offset: 0x00381BDC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x003839E4 File Offset: 0x00381BE4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x00383A04 File Offset: 0x00381C04
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600CC3A RID: 52282 RVA: 0x00383A10 File Offset: 0x00381C10
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ChestUIController_OnClose_hotfix = (luaObj.RawGet("ChestUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CC3B RID: 52283 RVA: 0x00383C08 File Offset: 0x00381E08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChestUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008015 RID: 32789
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ChestUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/ChestUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008016 RID: 32790
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ChestUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ChestUIController"),
				m_ctrlName = "ChestUIController"
			}
		};

		// Token: 0x04008017 RID: 32791
		private const string ParamKey_BattleReward = "BattleReward";

		// Token: 0x04008018 RID: 32792
		private const string ParamKey_IsFirstWin = "IsFirstWin";

		// Token: 0x04008019 RID: 32793
		private const string ParamKey_IsAutoOpen = "AutoOpen";

		// Token: 0x0400801A RID: 32794
		private BattleReward m_battleReward = new BattleReward();

		// Token: 0x0400801B RID: 32795
		private bool m_isFirstWin;

		// Token: 0x0400801C RID: 32796
		private bool m_isAutoOpen;

		// Token: 0x0400801D RID: 32797
		private ChestUIController m_chestUIController;

		// Token: 0x0400801E RID: 32798
		[DoNotToLua]
		private ChestUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400801F RID: 32799
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008020 RID: 32800
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008021 RID: 32801
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008022 RID: 32802
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008023 RID: 32803
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04008024 RID: 32804
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04008025 RID: 32805
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04008026 RID: 32806
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008027 RID: 32807
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008028 RID: 32808
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008029 RID: 32809
		private LuaFunction m_ChestUIController_OnClose_hotfix;

		// Token: 0x0400802A RID: 32810
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400802B RID: 32811
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400802C RID: 32812
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400802D RID: 32813
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BA5 RID: 2981
		public new class LuaExportHelper
		{
			// Token: 0x0600CC3C RID: 52284 RVA: 0x00383C70 File Offset: 0x00381E70
			public LuaExportHelper(ChestUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CC3D RID: 52285 RVA: 0x00383C80 File Offset: 0x00381E80
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600CC3E RID: 52286 RVA: 0x00383C90 File Offset: 0x00381E90
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600CC3F RID: 52287 RVA: 0x00383CA0 File Offset: 0x00381EA0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600CC40 RID: 52288 RVA: 0x00383CB0 File Offset: 0x00381EB0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600CC41 RID: 52289 RVA: 0x00383CC0 File Offset: 0x00381EC0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600CC42 RID: 52290 RVA: 0x00383CD0 File Offset: 0x00381ED0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600CC43 RID: 52291 RVA: 0x00383CE0 File Offset: 0x00381EE0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CC44 RID: 52292 RVA: 0x00383CF0 File Offset: 0x00381EF0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600CC45 RID: 52293 RVA: 0x00383D00 File Offset: 0x00381F00
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600CC46 RID: 52294 RVA: 0x00383D10 File Offset: 0x00381F10
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600CC47 RID: 52295 RVA: 0x00383D20 File Offset: 0x00381F20
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600CC48 RID: 52296 RVA: 0x00383D30 File Offset: 0x00381F30
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600CC49 RID: 52297 RVA: 0x00383D40 File Offset: 0x00381F40
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600CC4A RID: 52298 RVA: 0x00383D50 File Offset: 0x00381F50
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600CC4B RID: 52299 RVA: 0x00383D60 File Offset: 0x00381F60
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600CC4C RID: 52300 RVA: 0x00383D70 File Offset: 0x00381F70
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600CC4D RID: 52301 RVA: 0x00383D80 File Offset: 0x00381F80
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600CC4E RID: 52302 RVA: 0x00383D90 File Offset: 0x00381F90
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600CC4F RID: 52303 RVA: 0x00383DA0 File Offset: 0x00381FA0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600CC50 RID: 52304 RVA: 0x00383DB0 File Offset: 0x00381FB0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600CC51 RID: 52305 RVA: 0x00383DC0 File Offset: 0x00381FC0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600CC52 RID: 52306 RVA: 0x00383DD0 File Offset: 0x00381FD0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600CC53 RID: 52307 RVA: 0x00383DE0 File Offset: 0x00381FE0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600CC54 RID: 52308 RVA: 0x00383DF0 File Offset: 0x00381FF0
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600CC55 RID: 52309 RVA: 0x00383E00 File Offset: 0x00382000
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700286E RID: 10350
			// (get) Token: 0x0600CC56 RID: 52310 RVA: 0x00383E10 File Offset: 0x00382010
			// (set) Token: 0x0600CC57 RID: 52311 RVA: 0x00383E20 File Offset: 0x00382020
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

			// Token: 0x1700286F RID: 10351
			// (get) Token: 0x0600CC58 RID: 52312 RVA: 0x00383E30 File Offset: 0x00382030
			// (set) Token: 0x0600CC59 RID: 52313 RVA: 0x00383E40 File Offset: 0x00382040
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

			// Token: 0x17002870 RID: 10352
			// (get) Token: 0x0600CC5A RID: 52314 RVA: 0x00383E50 File Offset: 0x00382050
			public static string ParamKey_BattleReward
			{
				get
				{
					return "BattleReward";
				}
			}

			// Token: 0x17002871 RID: 10353
			// (get) Token: 0x0600CC5B RID: 52315 RVA: 0x00383E58 File Offset: 0x00382058
			public static string ParamKey_IsFirstWin
			{
				get
				{
					return "IsFirstWin";
				}
			}

			// Token: 0x17002872 RID: 10354
			// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x00383E60 File Offset: 0x00382060
			public static string ParamKey_IsAutoOpen
			{
				get
				{
					return "AutoOpen";
				}
			}

			// Token: 0x17002873 RID: 10355
			// (get) Token: 0x0600CC5D RID: 52317 RVA: 0x00383E68 File Offset: 0x00382068
			// (set) Token: 0x0600CC5E RID: 52318 RVA: 0x00383E78 File Offset: 0x00382078
			public BattleReward m_battleReward
			{
				get
				{
					return this.m_owner.m_battleReward;
				}
				set
				{
					this.m_owner.m_battleReward = value;
				}
			}

			// Token: 0x17002874 RID: 10356
			// (get) Token: 0x0600CC5F RID: 52319 RVA: 0x00383E88 File Offset: 0x00382088
			// (set) Token: 0x0600CC60 RID: 52320 RVA: 0x00383E98 File Offset: 0x00382098
			public bool m_isFirstWin
			{
				get
				{
					return this.m_owner.m_isFirstWin;
				}
				set
				{
					this.m_owner.m_isFirstWin = value;
				}
			}

			// Token: 0x17002875 RID: 10357
			// (get) Token: 0x0600CC61 RID: 52321 RVA: 0x00383EA8 File Offset: 0x003820A8
			// (set) Token: 0x0600CC62 RID: 52322 RVA: 0x00383EB8 File Offset: 0x003820B8
			public bool m_isAutoOpen
			{
				get
				{
					return this.m_owner.m_isAutoOpen;
				}
				set
				{
					this.m_owner.m_isAutoOpen = value;
				}
			}

			// Token: 0x17002876 RID: 10358
			// (get) Token: 0x0600CC63 RID: 52323 RVA: 0x00383EC8 File Offset: 0x003820C8
			// (set) Token: 0x0600CC64 RID: 52324 RVA: 0x00383ED8 File Offset: 0x003820D8
			public ChestUIController m_chestUIController
			{
				get
				{
					return this.m_owner.m_chestUIController;
				}
				set
				{
					this.m_owner.m_chestUIController = value;
				}
			}

			// Token: 0x17002877 RID: 10359
			// (get) Token: 0x0600CC65 RID: 52325 RVA: 0x00383EE8 File Offset: 0x003820E8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002878 RID: 10360
			// (get) Token: 0x0600CC66 RID: 52326 RVA: 0x00383EF8 File Offset: 0x003820F8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600CC67 RID: 52327 RVA: 0x00383F08 File Offset: 0x00382108
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600CC68 RID: 52328 RVA: 0x00383F18 File Offset: 0x00382118
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600CC69 RID: 52329 RVA: 0x00383F28 File Offset: 0x00382128
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600CC6A RID: 52330 RVA: 0x00383F38 File Offset: 0x00382138
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CC6B RID: 52331 RVA: 0x00383F48 File Offset: 0x00382148
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600CC6C RID: 52332 RVA: 0x00383F58 File Offset: 0x00382158
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600CC6D RID: 52333 RVA: 0x00383F68 File Offset: 0x00382168
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600CC6E RID: 52334 RVA: 0x00383F78 File Offset: 0x00382178
			public void ChestUIController_OnClose()
			{
				this.m_owner.ChestUIController_OnClose();
			}

			// Token: 0x0400802E RID: 32814
			private ChestUITask m_owner;
		}
	}
}
