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
	// Token: 0x02000AAA RID: 2730
	[HotFix]
	public class BattleResultScoreUITask : UITask
	{
		// Token: 0x0600AFE6 RID: 45030 RVA: 0x0030D074 File Offset: 0x0030B274
		public BattleResultScoreUITask(string name) : base(name)
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

		// Token: 0x0600AFE7 RID: 45031 RVA: 0x0030D168 File Offset: 0x0030B368
		public static BattleResultScoreUITask StartUITask(BattleReward battleReward)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BattleResultScoreUITask).Name, null);
			uiintentCustom.SetParam("BattleReward", battleReward);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as BattleResultScoreUITask;
		}

		// Token: 0x0600AFE8 RID: 45032 RVA: 0x0030D1AC File Offset: 0x0030B3AC
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

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x0030D238 File Offset: 0x0030B438
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

		// Token: 0x0600AFEA RID: 45034 RVA: 0x0030D2C4 File Offset: 0x0030B4C4
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
			}
		}

		// Token: 0x0600AFEB RID: 45035 RVA: 0x0030D35C File Offset: 0x0030B55C
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
				foreach (Goods goods in this.m_battleReward.ScoreGoods)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600AFEC RID: 45036 RVA: 0x0030D444 File Offset: 0x0030B644
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
			if (this.m_battleResultScoreUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_battleResultScoreUIController = (this.m_uiCtrlArray[0] as BattleResultScoreUIController);
				}
				if (!(this.m_battleResultScoreUIController != null))
				{
					Debug.LogError("BattleResultScoreUIController is null");
					return;
				}
				this.m_battleResultScoreUIController.EventOnClose += this.BattleResultScoreUIController_OnClose;
			}
		}

		// Token: 0x0600AFED RID: 45037 RVA: 0x0030D514 File Offset: 0x0030B714
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
			if (this.m_battleResultScoreUIController != null)
			{
				this.m_battleResultScoreUIController.EventOnClose -= this.BattleResultScoreUIController_OnClose;
				this.m_battleResultScoreUIController = null;
			}
		}

		// Token: 0x0600AFEE RID: 45038 RVA: 0x0030D5AC File Offset: 0x0030B7AC
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
			if (base.IsOpeningUI() && this.m_battleReward != null)
			{
				this.m_battleResultScoreUIController.ShowBattleResultScore(this.m_battleReward);
			}
		}

		// Token: 0x0600AFEF RID: 45039 RVA: 0x0030D634 File Offset: 0x0030B834
		private void BattleResultScoreUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleResultScoreUIController_OnClose_hotfix != null)
			{
				this.m_BattleResultScoreUIController_OnClose_hotfix.call(new object[]
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

		// Token: 0x14000219 RID: 537
		// (add) Token: 0x0600AFF0 RID: 45040 RVA: 0x0030D6B0 File Offset: 0x0030B8B0
		// (remove) Token: 0x0600AFF1 RID: 45041 RVA: 0x0030D74C File Offset: 0x0030B94C
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

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600AFF2 RID: 45042 RVA: 0x0030D7E8 File Offset: 0x0030B9E8
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

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0600AFF3 RID: 45043 RVA: 0x0030D85C File Offset: 0x0030BA5C
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

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0600AFF4 RID: 45044 RVA: 0x0030D8D0 File Offset: 0x0030BAD0
		// (set) Token: 0x0600AFF5 RID: 45045 RVA: 0x0030D8F0 File Offset: 0x0030BAF0
		[DoNotToLua]
		public new BattleResultScoreUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleResultScoreUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AFF6 RID: 45046 RVA: 0x0030D8FC File Offset: 0x0030BAFC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600AFF7 RID: 45047 RVA: 0x0030D908 File Offset: 0x0030BB08
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600AFF8 RID: 45048 RVA: 0x0030D910 File Offset: 0x0030BB10
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600AFF9 RID: 45049 RVA: 0x0030D918 File Offset: 0x0030BB18
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600AFFA RID: 45050 RVA: 0x0030D924 File Offset: 0x0030BB24
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600AFFB RID: 45051 RVA: 0x0030D930 File Offset: 0x0030BB30
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600AFFC RID: 45052 RVA: 0x0030D93C File Offset: 0x0030BB3C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600AFFD RID: 45053 RVA: 0x0030D944 File Offset: 0x0030BB44
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x0030D94C File Offset: 0x0030BB4C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x0030D954 File Offset: 0x0030BB54
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x0030D95C File Offset: 0x0030BB5C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x0030D964 File Offset: 0x0030BB64
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600B002 RID: 45058 RVA: 0x0030D96C File Offset: 0x0030BB6C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600B003 RID: 45059 RVA: 0x0030D974 File Offset: 0x0030BB74
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600B004 RID: 45060 RVA: 0x0030D980 File Offset: 0x0030BB80
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600B005 RID: 45061 RVA: 0x0030D98C File Offset: 0x0030BB8C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600B006 RID: 45062 RVA: 0x0030D998 File Offset: 0x0030BB98
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600B007 RID: 45063 RVA: 0x0030D9A4 File Offset: 0x0030BBA4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600B008 RID: 45064 RVA: 0x0030D9AC File Offset: 0x0030BBAC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600B009 RID: 45065 RVA: 0x0030D9B4 File Offset: 0x0030BBB4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600B00A RID: 45066 RVA: 0x0030D9BC File Offset: 0x0030BBBC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600B00B RID: 45067 RVA: 0x0030D9C4 File Offset: 0x0030BBC4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600B00C RID: 45068 RVA: 0x0030D9CC File Offset: 0x0030BBCC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600B00D RID: 45069 RVA: 0x0030D9D4 File Offset: 0x0030BBD4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600B00E RID: 45070 RVA: 0x0030D9F4 File Offset: 0x0030BBF4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600B00F RID: 45071 RVA: 0x0030DA00 File Offset: 0x0030BC00
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
					this.m_BattleResultScoreUIController_OnClose_hotfix = (luaObj.RawGet("BattleResultScoreUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B010 RID: 45072 RVA: 0x0030DBF8 File Offset: 0x0030BDF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleResultScoreUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007299 RID: 29337
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleResultScoreUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleResultScoreUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400729A RID: 29338
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleResultScoreUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleResultScoreUIController"),
				m_ctrlName = "BattleResultScoreUIController"
			}
		};

		// Token: 0x0400729B RID: 29339
		private BattleResultScoreUIController m_battleResultScoreUIController;

		// Token: 0x0400729C RID: 29340
		private BattleReward m_battleReward;

		// Token: 0x0400729D RID: 29341
		[DoNotToLua]
		private BattleResultScoreUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400729E RID: 29342
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400729F RID: 29343
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040072A0 RID: 29344
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040072A1 RID: 29345
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040072A2 RID: 29346
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x040072A3 RID: 29347
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x040072A4 RID: 29348
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040072A5 RID: 29349
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040072A6 RID: 29350
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040072A7 RID: 29351
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040072A8 RID: 29352
		private LuaFunction m_BattleResultScoreUIController_OnClose_hotfix;

		// Token: 0x040072A9 RID: 29353
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040072AA RID: 29354
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040072AB RID: 29355
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040072AC RID: 29356
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000AAB RID: 2731
		public new class LuaExportHelper
		{
			// Token: 0x0600B011 RID: 45073 RVA: 0x0030DC60 File Offset: 0x0030BE60
			public LuaExportHelper(BattleResultScoreUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B012 RID: 45074 RVA: 0x0030DC70 File Offset: 0x0030BE70
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600B013 RID: 45075 RVA: 0x0030DC80 File Offset: 0x0030BE80
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600B014 RID: 45076 RVA: 0x0030DC90 File Offset: 0x0030BE90
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600B015 RID: 45077 RVA: 0x0030DCA0 File Offset: 0x0030BEA0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600B016 RID: 45078 RVA: 0x0030DCB0 File Offset: 0x0030BEB0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600B017 RID: 45079 RVA: 0x0030DCC0 File Offset: 0x0030BEC0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600B018 RID: 45080 RVA: 0x0030DCD0 File Offset: 0x0030BED0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600B019 RID: 45081 RVA: 0x0030DCE0 File Offset: 0x0030BEE0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600B01A RID: 45082 RVA: 0x0030DCF0 File Offset: 0x0030BEF0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600B01B RID: 45083 RVA: 0x0030DD00 File Offset: 0x0030BF00
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600B01C RID: 45084 RVA: 0x0030DD10 File Offset: 0x0030BF10
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600B01D RID: 45085 RVA: 0x0030DD20 File Offset: 0x0030BF20
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600B01E RID: 45086 RVA: 0x0030DD30 File Offset: 0x0030BF30
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600B01F RID: 45087 RVA: 0x0030DD40 File Offset: 0x0030BF40
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600B020 RID: 45088 RVA: 0x0030DD50 File Offset: 0x0030BF50
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600B021 RID: 45089 RVA: 0x0030DD60 File Offset: 0x0030BF60
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600B022 RID: 45090 RVA: 0x0030DD70 File Offset: 0x0030BF70
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600B023 RID: 45091 RVA: 0x0030DD80 File Offset: 0x0030BF80
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600B024 RID: 45092 RVA: 0x0030DD90 File Offset: 0x0030BF90
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600B025 RID: 45093 RVA: 0x0030DDA0 File Offset: 0x0030BFA0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600B026 RID: 45094 RVA: 0x0030DDB0 File Offset: 0x0030BFB0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600B027 RID: 45095 RVA: 0x0030DDC0 File Offset: 0x0030BFC0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600B028 RID: 45096 RVA: 0x0030DDD0 File Offset: 0x0030BFD0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600B029 RID: 45097 RVA: 0x0030DDE0 File Offset: 0x0030BFE0
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600B02A RID: 45098 RVA: 0x0030DDF0 File Offset: 0x0030BFF0
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700239E RID: 9118
			// (get) Token: 0x0600B02B RID: 45099 RVA: 0x0030DE00 File Offset: 0x0030C000
			// (set) Token: 0x0600B02C RID: 45100 RVA: 0x0030DE10 File Offset: 0x0030C010
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

			// Token: 0x1700239F RID: 9119
			// (get) Token: 0x0600B02D RID: 45101 RVA: 0x0030DE20 File Offset: 0x0030C020
			// (set) Token: 0x0600B02E RID: 45102 RVA: 0x0030DE30 File Offset: 0x0030C030
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

			// Token: 0x170023A0 RID: 9120
			// (get) Token: 0x0600B02F RID: 45103 RVA: 0x0030DE40 File Offset: 0x0030C040
			// (set) Token: 0x0600B030 RID: 45104 RVA: 0x0030DE50 File Offset: 0x0030C050
			public BattleResultScoreUIController m_battleResultScoreUIController
			{
				get
				{
					return this.m_owner.m_battleResultScoreUIController;
				}
				set
				{
					this.m_owner.m_battleResultScoreUIController = value;
				}
			}

			// Token: 0x170023A1 RID: 9121
			// (get) Token: 0x0600B031 RID: 45105 RVA: 0x0030DE60 File Offset: 0x0030C060
			// (set) Token: 0x0600B032 RID: 45106 RVA: 0x0030DE70 File Offset: 0x0030C070
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

			// Token: 0x170023A2 RID: 9122
			// (get) Token: 0x0600B033 RID: 45107 RVA: 0x0030DE80 File Offset: 0x0030C080
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170023A3 RID: 9123
			// (get) Token: 0x0600B034 RID: 45108 RVA: 0x0030DE90 File Offset: 0x0030C090
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600B035 RID: 45109 RVA: 0x0030DEA0 File Offset: 0x0030C0A0
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600B036 RID: 45110 RVA: 0x0030DEB0 File Offset: 0x0030C0B0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600B037 RID: 45111 RVA: 0x0030DEC0 File Offset: 0x0030C0C0
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600B038 RID: 45112 RVA: 0x0030DED0 File Offset: 0x0030C0D0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600B039 RID: 45113 RVA: 0x0030DEE0 File Offset: 0x0030C0E0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600B03A RID: 45114 RVA: 0x0030DEF0 File Offset: 0x0030C0F0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600B03B RID: 45115 RVA: 0x0030DF00 File Offset: 0x0030C100
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600B03C RID: 45116 RVA: 0x0030DF10 File Offset: 0x0030C110
			public void BattleResultScoreUIController_OnClose()
			{
				this.m_owner.BattleResultScoreUIController_OnClose();
			}

			// Token: 0x040072AD RID: 29357
			private BattleResultScoreUITask m_owner;
		}
	}
}
