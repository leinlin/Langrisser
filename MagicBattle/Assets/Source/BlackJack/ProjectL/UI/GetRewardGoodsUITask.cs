using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BC6 RID: 3014
	[HotFix]
	public class GetRewardGoodsUITask : UITask
	{
		// Token: 0x0600CF47 RID: 53063 RVA: 0x0038E824 File Offset: 0x0038CA24
		public GetRewardGoodsUITask(string name) : base(name)
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

		// Token: 0x0600CF48 RID: 53064 RVA: 0x0038E920 File Offset: 0x0038CB20
		public static GetRewardGoodsUITask StartUITask(List<Goods> rewardGoodsList)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(GetRewardGoodsUITask).Name, null);
			uiintentCustom.SetParam("RewardGoodsList", rewardGoodsList);
			return UIManager.Instance.StartUITask(uiintentCustom, false, false, null) as GetRewardGoodsUITask;
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x0038E964 File Offset: 0x0038CB64
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

		// Token: 0x0600CF4A RID: 53066 RVA: 0x0038E9F0 File Offset: 0x0038CBF0
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

		// Token: 0x0600CF4B RID: 53067 RVA: 0x0038EA7C File Offset: 0x0038CC7C
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x0038EB08 File Offset: 0x0038CD08
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
			this.m_rewardGoodsList.Clear();
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				List<Goods> classParam = uiintentCustom.GetClassParam<List<Goods>>("RewardGoodsList");
				if (classParam != null)
				{
					this.m_rewardGoodsList.AddRange(classParam);
				}
			}
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x0038EBB0 File Offset: 0x0038CDB0
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
			foreach (Goods goods in this.m_rewardGoodsList)
			{
				base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x0038EC88 File Offset: 0x0038CE88
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
			if (this.m_getRewardGoodsUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_getRewardGoodsUIController = (this.m_uiCtrlArray[0] as GetRewardGoodsUIController);
				}
				if (this.m_getRewardGoodsUIController != null)
				{
					this.m_getRewardGoodsUIController.EventOnClose += this.GetRewardGoodsUIController_OnClose;
				}
				else
				{
					Debug.LogError("GetRewardGoodsUIController is null");
				}
			}
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x0038ED58 File Offset: 0x0038CF58
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
			if (this.m_getRewardGoodsUIController != null)
			{
				this.m_getRewardGoodsUIController.EventOnClose -= this.GetRewardGoodsUIController_OnClose;
				this.m_getRewardGoodsUIController = null;
			}
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x0038EDF0 File Offset: 0x0038CFF0
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
			this.m_getRewardGoodsUIController.ShowReward(this.m_rewardGoodsList);
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x0038EE64 File Offset: 0x0038D064
		private void GetRewardGoodsUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardGoodsUIController_OnClose_hotfix != null)
			{
				this.m_GetRewardGoodsUIController_OnClose_hotfix.call(new object[]
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

		// Token: 0x1400027B RID: 635
		// (add) Token: 0x0600CF52 RID: 53074 RVA: 0x0038EEE0 File Offset: 0x0038D0E0
		// (remove) Token: 0x0600CF53 RID: 53075 RVA: 0x0038EF7C File Offset: 0x0038D17C
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

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0600CF54 RID: 53076 RVA: 0x0038F018 File Offset: 0x0038D218
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

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0600CF55 RID: 53077 RVA: 0x0038F08C File Offset: 0x0038D28C
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

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0600CF56 RID: 53078 RVA: 0x0038F100 File Offset: 0x0038D300
		// (set) Token: 0x0600CF57 RID: 53079 RVA: 0x0038F120 File Offset: 0x0038D320
		[DoNotToLua]
		public new GetRewardGoodsUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GetRewardGoodsUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x0038F12C File Offset: 0x0038D32C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600CF59 RID: 53081 RVA: 0x0038F138 File Offset: 0x0038D338
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600CF5A RID: 53082 RVA: 0x0038F140 File Offset: 0x0038D340
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600CF5B RID: 53083 RVA: 0x0038F148 File Offset: 0x0038D348
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600CF5C RID: 53084 RVA: 0x0038F154 File Offset: 0x0038D354
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x0038F160 File Offset: 0x0038D360
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x0038F16C File Offset: 0x0038D36C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CF5F RID: 53087 RVA: 0x0038F174 File Offset: 0x0038D374
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600CF60 RID: 53088 RVA: 0x0038F17C File Offset: 0x0038D37C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x0038F184 File Offset: 0x0038D384
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x0038F18C File Offset: 0x0038D38C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600CF63 RID: 53091 RVA: 0x0038F194 File Offset: 0x0038D394
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x0038F19C File Offset: 0x0038D39C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x0038F1A4 File Offset: 0x0038D3A4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x0038F1B0 File Offset: 0x0038D3B0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x0038F1BC File Offset: 0x0038D3BC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x0038F1C8 File Offset: 0x0038D3C8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x0038F1D4 File Offset: 0x0038D3D4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x0038F1DC File Offset: 0x0038D3DC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x0038F1E4 File Offset: 0x0038D3E4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600CF6C RID: 53100 RVA: 0x0038F1EC File Offset: 0x0038D3EC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x0038F1F4 File Offset: 0x0038D3F4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x0038F1FC File Offset: 0x0038D3FC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600CF6F RID: 53103 RVA: 0x0038F204 File Offset: 0x0038D404
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x0038F224 File Offset: 0x0038D424
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x0038F230 File Offset: 0x0038D430
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
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_GetRewardGoodsUIController_OnClose_hotfix = (luaObj.RawGet("GetRewardGoodsUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x0038F440 File Offset: 0x0038D640
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetRewardGoodsUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400816C RID: 33132
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GetRewardGoodsUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/GetRewardGoodsUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400816D RID: 33133
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GetRewardGoodsUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GetRewardGoodsUIController"),
				m_ctrlName = "GetRewardGoodsUIController"
			}
		};

		// Token: 0x0400816E RID: 33134
		private const string ParamKey_RewardGoodsList = "RewardGoodsList";

		// Token: 0x0400816F RID: 33135
		private GetRewardGoodsUIController m_getRewardGoodsUIController;

		// Token: 0x04008170 RID: 33136
		private List<Goods> m_rewardGoodsList = new List<Goods>();

		// Token: 0x04008171 RID: 33137
		[DoNotToLua]
		private GetRewardGoodsUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008172 RID: 33138
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008173 RID: 33139
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008174 RID: 33140
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008175 RID: 33141
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008176 RID: 33142
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04008177 RID: 33143
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x04008178 RID: 33144
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04008179 RID: 33145
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400817A RID: 33146
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400817B RID: 33147
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400817C RID: 33148
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400817D RID: 33149
		private LuaFunction m_GetRewardGoodsUIController_OnClose_hotfix;

		// Token: 0x0400817E RID: 33150
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400817F RID: 33151
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04008180 RID: 33152
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008181 RID: 33153
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000BC7 RID: 3015
		public new class LuaExportHelper
		{
			// Token: 0x0600CF73 RID: 53107 RVA: 0x0038F4A8 File Offset: 0x0038D6A8
			public LuaExportHelper(GetRewardGoodsUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CF74 RID: 53108 RVA: 0x0038F4B8 File Offset: 0x0038D6B8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600CF75 RID: 53109 RVA: 0x0038F4C8 File Offset: 0x0038D6C8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600CF76 RID: 53110 RVA: 0x0038F4D8 File Offset: 0x0038D6D8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600CF77 RID: 53111 RVA: 0x0038F4E8 File Offset: 0x0038D6E8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600CF78 RID: 53112 RVA: 0x0038F4F8 File Offset: 0x0038D6F8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600CF79 RID: 53113 RVA: 0x0038F508 File Offset: 0x0038D708
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600CF7A RID: 53114 RVA: 0x0038F518 File Offset: 0x0038D718
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CF7B RID: 53115 RVA: 0x0038F528 File Offset: 0x0038D728
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600CF7C RID: 53116 RVA: 0x0038F538 File Offset: 0x0038D738
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600CF7D RID: 53117 RVA: 0x0038F548 File Offset: 0x0038D748
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600CF7E RID: 53118 RVA: 0x0038F558 File Offset: 0x0038D758
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600CF7F RID: 53119 RVA: 0x0038F568 File Offset: 0x0038D768
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600CF80 RID: 53120 RVA: 0x0038F578 File Offset: 0x0038D778
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600CF81 RID: 53121 RVA: 0x0038F588 File Offset: 0x0038D788
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600CF82 RID: 53122 RVA: 0x0038F598 File Offset: 0x0038D798
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600CF83 RID: 53123 RVA: 0x0038F5A8 File Offset: 0x0038D7A8
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600CF84 RID: 53124 RVA: 0x0038F5B8 File Offset: 0x0038D7B8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600CF85 RID: 53125 RVA: 0x0038F5C8 File Offset: 0x0038D7C8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600CF86 RID: 53126 RVA: 0x0038F5D8 File Offset: 0x0038D7D8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600CF87 RID: 53127 RVA: 0x0038F5E8 File Offset: 0x0038D7E8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600CF88 RID: 53128 RVA: 0x0038F5F8 File Offset: 0x0038D7F8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600CF89 RID: 53129 RVA: 0x0038F608 File Offset: 0x0038D808
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600CF8A RID: 53130 RVA: 0x0038F618 File Offset: 0x0038D818
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600CF8B RID: 53131 RVA: 0x0038F628 File Offset: 0x0038D828
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600CF8C RID: 53132 RVA: 0x0038F638 File Offset: 0x0038D838
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170028F3 RID: 10483
			// (get) Token: 0x0600CF8D RID: 53133 RVA: 0x0038F648 File Offset: 0x0038D848
			// (set) Token: 0x0600CF8E RID: 53134 RVA: 0x0038F658 File Offset: 0x0038D858
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

			// Token: 0x170028F4 RID: 10484
			// (get) Token: 0x0600CF8F RID: 53135 RVA: 0x0038F668 File Offset: 0x0038D868
			// (set) Token: 0x0600CF90 RID: 53136 RVA: 0x0038F678 File Offset: 0x0038D878
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

			// Token: 0x170028F5 RID: 10485
			// (get) Token: 0x0600CF91 RID: 53137 RVA: 0x0038F688 File Offset: 0x0038D888
			public static string ParamKey_RewardGoodsList
			{
				get
				{
					return "RewardGoodsList";
				}
			}

			// Token: 0x170028F6 RID: 10486
			// (get) Token: 0x0600CF92 RID: 53138 RVA: 0x0038F690 File Offset: 0x0038D890
			// (set) Token: 0x0600CF93 RID: 53139 RVA: 0x0038F6A0 File Offset: 0x0038D8A0
			public GetRewardGoodsUIController m_getRewardGoodsUIController
			{
				get
				{
					return this.m_owner.m_getRewardGoodsUIController;
				}
				set
				{
					this.m_owner.m_getRewardGoodsUIController = value;
				}
			}

			// Token: 0x170028F7 RID: 10487
			// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x0038F6B0 File Offset: 0x0038D8B0
			// (set) Token: 0x0600CF95 RID: 53141 RVA: 0x0038F6C0 File Offset: 0x0038D8C0
			public List<Goods> m_rewardGoodsList
			{
				get
				{
					return this.m_owner.m_rewardGoodsList;
				}
				set
				{
					this.m_owner.m_rewardGoodsList = value;
				}
			}

			// Token: 0x170028F8 RID: 10488
			// (get) Token: 0x0600CF96 RID: 53142 RVA: 0x0038F6D0 File Offset: 0x0038D8D0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170028F9 RID: 10489
			// (get) Token: 0x0600CF97 RID: 53143 RVA: 0x0038F6E0 File Offset: 0x0038D8E0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600CF98 RID: 53144 RVA: 0x0038F6F0 File Offset: 0x0038D8F0
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600CF99 RID: 53145 RVA: 0x0038F700 File Offset: 0x0038D900
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600CF9A RID: 53146 RVA: 0x0038F710 File Offset: 0x0038D910
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600CF9B RID: 53147 RVA: 0x0038F720 File Offset: 0x0038D920
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CF9C RID: 53148 RVA: 0x0038F730 File Offset: 0x0038D930
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600CF9D RID: 53149 RVA: 0x0038F740 File Offset: 0x0038D940
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600CF9E RID: 53150 RVA: 0x0038F750 File Offset: 0x0038D950
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600CF9F RID: 53151 RVA: 0x0038F760 File Offset: 0x0038D960
			public void GetRewardGoodsUIController_OnClose()
			{
				this.m_owner.GetRewardGoodsUIController_OnClose();
			}

			// Token: 0x04008182 RID: 33154
			private GetRewardGoodsUITask m_owner;
		}
	}
}
