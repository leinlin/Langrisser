using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D7A RID: 3450
	[HotFix]
	public class HeroBreakEffectUITask : UITask
	{
		// Token: 0x0601006B RID: 65643 RVA: 0x004330E8 File Offset: 0x004312E8
		public HeroBreakEffectUITask(string name) : base(name)
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

		// Token: 0x0601006C RID: 65644 RVA: 0x004331DC File Offset: 0x004313DC
		public static void StartUITask(UIIntent uiIntent, int heroId)
		{
			HeroBreakEffectUITask.m_preUiIntent = uiIntent;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(uiIntent, typeof(HeroBreakEffectUITask).Name, null);
				HeroBreakEffectUITask.m_heroId = heroId;
				UIManager instance = UIManager.Instance;
				UIIntent intent = uiintentReturnable;
				bool pushIntentToStack = true;
				bool clearIntentStack = false;
				if (HeroBreakEffectUITask.<>f__mg$cache0 == null)
				{
					HeroBreakEffectUITask.<>f__mg$cache0 = new Action(HeroBreakEffectUITask.HeroBreakEffectUITask_OnLoadAllResCompleted);
				}
				instance.StartUITask(intent, pushIntentToStack, clearIntentStack, HeroBreakEffectUITask.<>f__mg$cache0);
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x0601006D RID: 65645 RVA: 0x0043322C File Offset: 0x0043142C
		public static void HeroBreakEffectUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroBreakEffectUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601006E RID: 65646 RVA: 0x00433260 File Offset: 0x00431460
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Hero hero = projectLPlayerContext.GetHero(HeroBreakEffectUITask.m_heroId);
			if (hero != null)
			{
				ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
				if (charImageInfo != null)
				{
					base.CollectAsset(charImageInfo.Spine);
					base.CollectSpriteAsset(charImageInfo.Image);
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601006F RID: 65647 RVA: 0x0043332C File Offset: 0x0043152C
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
			if (this.m_heroBreakEffectUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroBreakEffectUIController = (this.m_uiCtrlArray[0] as HeroBreakEffectUIController);
				}
				if (this.m_heroBreakEffectUIController != null)
				{
					this.m_heroBreakEffectUIController.EventOnReturn += this.OnClose;
				}
			}
		}

		// Token: 0x06010070 RID: 65648 RVA: 0x004333EC File Offset: 0x004315EC
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
			if (this.m_heroBreakEffectUIController != null)
			{
				this.m_heroBreakEffectUIController.EventOnReturn -= this.OnClose;
				this.m_heroBreakEffectUIController = null;
			}
		}

		// Token: 0x06010071 RID: 65649 RVA: 0x00433484 File Offset: 0x00431684
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
				this.m_heroBreakEffectUIController.Open();
			}
			this.m_heroBreakEffectUIController.HeroBreakEffectUpdateView(HeroBreakEffectUITask.m_heroId);
		}

		// Token: 0x06010072 RID: 65650 RVA: 0x0043350C File Offset: 0x0043170C
		private void OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClose_hotfix != null)
			{
				this.m_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				Hero hero = projectLPlayerContext.GetHero(HeroBreakEffectUITask.m_heroId);
				int rank = hero.HeroInfo.GetRank(hero.StarLevel - 1);
				int rank2 = hero.HeroInfo.GetRank(hero.StarLevel);
				if (rank != rank2)
				{
					base.Pause();
					HeroBreakRarityUpUITask.StartUITask(HeroBreakEffectUITask.m_preUiIntent, HeroBreakEffectUITask.m_heroId);
				}
				else
				{
					base.Pause();
					base.ReturnPrevUITask();
					HeroBreakEffectUITask.m_heroId = 0;
				}
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x06010073 RID: 65651 RVA: 0x00433590 File Offset: 0x00431790
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

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x06010074 RID: 65652 RVA: 0x00433604 File Offset: 0x00431804
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

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x06010075 RID: 65653 RVA: 0x00433678 File Offset: 0x00431878
		// (set) Token: 0x06010076 RID: 65654 RVA: 0x00433698 File Offset: 0x00431898
		[DoNotToLua]
		public new HeroBreakEffectUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroBreakEffectUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010077 RID: 65655 RVA: 0x004336A4 File Offset: 0x004318A4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06010078 RID: 65656 RVA: 0x004336B0 File Offset: 0x004318B0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06010079 RID: 65657 RVA: 0x004336B8 File Offset: 0x004318B8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0601007A RID: 65658 RVA: 0x004336C0 File Offset: 0x004318C0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601007B RID: 65659 RVA: 0x004336CC File Offset: 0x004318CC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601007C RID: 65660 RVA: 0x004336D8 File Offset: 0x004318D8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601007D RID: 65661 RVA: 0x004336E4 File Offset: 0x004318E4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601007E RID: 65662 RVA: 0x004336EC File Offset: 0x004318EC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601007F RID: 65663 RVA: 0x004336F4 File Offset: 0x004318F4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06010080 RID: 65664 RVA: 0x004336FC File Offset: 0x004318FC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06010081 RID: 65665 RVA: 0x00433704 File Offset: 0x00431904
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06010082 RID: 65666 RVA: 0x0043370C File Offset: 0x0043190C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06010083 RID: 65667 RVA: 0x00433714 File Offset: 0x00431914
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06010084 RID: 65668 RVA: 0x0043371C File Offset: 0x0043191C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06010085 RID: 65669 RVA: 0x00433728 File Offset: 0x00431928
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06010086 RID: 65670 RVA: 0x00433734 File Offset: 0x00431934
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06010087 RID: 65671 RVA: 0x00433740 File Offset: 0x00431940
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06010088 RID: 65672 RVA: 0x0043374C File Offset: 0x0043194C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06010089 RID: 65673 RVA: 0x00433754 File Offset: 0x00431954
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0601008A RID: 65674 RVA: 0x0043375C File Offset: 0x0043195C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0601008B RID: 65675 RVA: 0x00433764 File Offset: 0x00431964
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601008C RID: 65676 RVA: 0x0043376C File Offset: 0x0043196C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0601008D RID: 65677 RVA: 0x00433774 File Offset: 0x00431974
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601008F RID: 65679 RVA: 0x0043380C File Offset: 0x00431A0C
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnClose_hotfix = (luaObj.RawGet("OnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010090 RID: 65680 RVA: 0x00433988 File Offset: 0x00431B88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroBreakEffectUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040095CC RID: 38348
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BreakEffectUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/BreakEffect_ABS/Prefab/BreakEffectUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040095CD RID: 38349
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BreakEffectUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroBreakEffectUIController"),
				m_ctrlName = "HeroBreakEffectUIController"
			}
		};

		// Token: 0x040095CE RID: 38350
		private HeroBreakEffectUIController m_heroBreakEffectUIController;

		// Token: 0x040095CF RID: 38351
		private static int m_heroId;

		// Token: 0x040095D0 RID: 38352
		private static UIIntent m_preUiIntent;

		// Token: 0x040095D1 RID: 38353
		[DoNotToLua]
		private HeroBreakEffectUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040095D2 RID: 38354
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x040095D3 RID: 38355
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040095D4 RID: 38356
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040095D5 RID: 38357
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040095D6 RID: 38358
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040095D7 RID: 38359
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040095D8 RID: 38360
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040095D9 RID: 38361
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040095DA RID: 38362
		private LuaFunction m_OnClose_hotfix;

		// Token: 0x040095DB RID: 38363
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040095DC RID: 38364
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D7B RID: 3451
		public new class LuaExportHelper
		{
			// Token: 0x06010091 RID: 65681 RVA: 0x004339F0 File Offset: 0x00431BF0
			public LuaExportHelper(HeroBreakEffectUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010092 RID: 65682 RVA: 0x00433A00 File Offset: 0x00431C00
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06010093 RID: 65683 RVA: 0x00433A10 File Offset: 0x00431C10
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06010094 RID: 65684 RVA: 0x00433A20 File Offset: 0x00431C20
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06010095 RID: 65685 RVA: 0x00433A30 File Offset: 0x00431C30
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06010096 RID: 65686 RVA: 0x00433A40 File Offset: 0x00431C40
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06010097 RID: 65687 RVA: 0x00433A50 File Offset: 0x00431C50
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06010098 RID: 65688 RVA: 0x00433A60 File Offset: 0x00431C60
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06010099 RID: 65689 RVA: 0x00433A70 File Offset: 0x00431C70
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0601009A RID: 65690 RVA: 0x00433A80 File Offset: 0x00431C80
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0601009B RID: 65691 RVA: 0x00433A90 File Offset: 0x00431C90
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601009C RID: 65692 RVA: 0x00433AA0 File Offset: 0x00431CA0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601009D RID: 65693 RVA: 0x00433AB0 File Offset: 0x00431CB0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601009E RID: 65694 RVA: 0x00433AC0 File Offset: 0x00431CC0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601009F RID: 65695 RVA: 0x00433AD0 File Offset: 0x00431CD0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060100A0 RID: 65696 RVA: 0x00433AE0 File Offset: 0x00431CE0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060100A1 RID: 65697 RVA: 0x00433AF0 File Offset: 0x00431CF0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060100A2 RID: 65698 RVA: 0x00433B00 File Offset: 0x00431D00
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060100A3 RID: 65699 RVA: 0x00433B10 File Offset: 0x00431D10
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060100A4 RID: 65700 RVA: 0x00433B20 File Offset: 0x00431D20
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060100A5 RID: 65701 RVA: 0x00433B30 File Offset: 0x00431D30
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060100A6 RID: 65702 RVA: 0x00433B40 File Offset: 0x00431D40
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060100A7 RID: 65703 RVA: 0x00433B50 File Offset: 0x00431D50
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060100A8 RID: 65704 RVA: 0x00433B60 File Offset: 0x00431D60
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003153 RID: 12627
			// (get) Token: 0x060100A9 RID: 65705 RVA: 0x00433B70 File Offset: 0x00431D70
			// (set) Token: 0x060100AA RID: 65706 RVA: 0x00433B80 File Offset: 0x00431D80
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

			// Token: 0x17003154 RID: 12628
			// (get) Token: 0x060100AB RID: 65707 RVA: 0x00433B90 File Offset: 0x00431D90
			// (set) Token: 0x060100AC RID: 65708 RVA: 0x00433BA0 File Offset: 0x00431DA0
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

			// Token: 0x17003155 RID: 12629
			// (get) Token: 0x060100AD RID: 65709 RVA: 0x00433BB0 File Offset: 0x00431DB0
			// (set) Token: 0x060100AE RID: 65710 RVA: 0x00433BC0 File Offset: 0x00431DC0
			public HeroBreakEffectUIController m_heroBreakEffectUIController
			{
				get
				{
					return this.m_owner.m_heroBreakEffectUIController;
				}
				set
				{
					this.m_owner.m_heroBreakEffectUIController = value;
				}
			}

			// Token: 0x17003156 RID: 12630
			// (get) Token: 0x060100AF RID: 65711 RVA: 0x00433BD0 File Offset: 0x00431DD0
			// (set) Token: 0x060100B0 RID: 65712 RVA: 0x00433BD8 File Offset: 0x00431DD8
			public static int m_heroId
			{
				get
				{
					return HeroBreakEffectUITask.m_heroId;
				}
				set
				{
					HeroBreakEffectUITask.m_heroId = value;
				}
			}

			// Token: 0x17003157 RID: 12631
			// (get) Token: 0x060100B1 RID: 65713 RVA: 0x00433BE0 File Offset: 0x00431DE0
			// (set) Token: 0x060100B2 RID: 65714 RVA: 0x00433BE8 File Offset: 0x00431DE8
			public static UIIntent m_preUiIntent
			{
				get
				{
					return HeroBreakEffectUITask.m_preUiIntent;
				}
				set
				{
					HeroBreakEffectUITask.m_preUiIntent = value;
				}
			}

			// Token: 0x17003158 RID: 12632
			// (get) Token: 0x060100B3 RID: 65715 RVA: 0x00433BF0 File Offset: 0x00431DF0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003159 RID: 12633
			// (get) Token: 0x060100B4 RID: 65716 RVA: 0x00433C00 File Offset: 0x00431E00
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060100B5 RID: 65717 RVA: 0x00433C10 File Offset: 0x00431E10
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060100B6 RID: 65718 RVA: 0x00433C20 File Offset: 0x00431E20
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060100B7 RID: 65719 RVA: 0x00433C30 File Offset: 0x00431E30
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060100B8 RID: 65720 RVA: 0x00433C40 File Offset: 0x00431E40
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060100B9 RID: 65721 RVA: 0x00433C50 File Offset: 0x00431E50
			public void OnClose()
			{
				this.m_owner.OnClose();
			}

			// Token: 0x040095DD RID: 38365
			private HeroBreakEffectUITask m_owner;
		}
	}
}
