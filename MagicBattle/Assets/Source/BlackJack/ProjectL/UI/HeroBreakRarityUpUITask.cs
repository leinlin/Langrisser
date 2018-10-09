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
	// Token: 0x02000D7F RID: 3455
	[HotFix]
	public class HeroBreakRarityUpUITask : UITask
	{
		// Token: 0x060100FA RID: 65786 RVA: 0x00434644 File Offset: 0x00432844
		public HeroBreakRarityUpUITask(string name) : base(name)
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

		// Token: 0x060100FB RID: 65787 RVA: 0x00434738 File Offset: 0x00432938
		public static void StartUITask(UIIntent uiIntent, int heroId)
		{
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(uiIntent, typeof(HeroBreakRarityUpUITask).Name, null);
				HeroBreakRarityUpUITask.m_heroId = heroId;
				UIManager instance = UIManager.Instance;
				UIIntent intent = uiintentReturnable;
				bool pushIntentToStack = true;
				bool clearIntentStack = false;
				if (HeroBreakRarityUpUITask.<>f__mg$cache0 == null)
				{
					HeroBreakRarityUpUITask.<>f__mg$cache0 = new Action(HeroBreakRarityUpUITask.HeroBreakRarityUpUITask_OnLoadAllResCompleted);
				}
				instance.StartUITask(intent, pushIntentToStack, clearIntentStack, HeroBreakRarityUpUITask.<>f__mg$cache0);
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x060100FC RID: 65788 RVA: 0x0043477C File Offset: 0x0043297C
		public static void HeroBreakRarityUpUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroBreakRarityUpUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x060100FD RID: 65789 RVA: 0x004347B0 File Offset: 0x004329B0
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
			Hero hero = projectLPlayerContext.GetHero(HeroBreakRarityUpUITask.m_heroId);
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

		// Token: 0x060100FE RID: 65790 RVA: 0x0043487C File Offset: 0x00432A7C
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
			if (this.m_heroBreakRarityUpUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroBreakRarityUpUIController = (this.m_uiCtrlArray[0] as HeroBreakRarityUpUIController);
				}
				if (this.m_heroBreakRarityUpUIController != null)
				{
					this.m_heroBreakRarityUpUIController.EventOnReturn += this.OnClose;
				}
			}
		}

		// Token: 0x060100FF RID: 65791 RVA: 0x0043493C File Offset: 0x00432B3C
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
			if (this.m_heroBreakRarityUpUIController != null)
			{
				this.m_heroBreakRarityUpUIController.EventOnReturn -= this.OnClose;
				this.m_heroBreakRarityUpUIController = null;
			}
		}

		// Token: 0x06010100 RID: 65792 RVA: 0x004349D4 File Offset: 0x00432BD4
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
				this.m_heroBreakRarityUpUIController.Open();
			}
			this.m_heroBreakRarityUpUIController.HeroBreakRarityUpUpdateView(HeroBreakRarityUpUITask.m_heroId);
		}

		// Token: 0x06010101 RID: 65793 RVA: 0x00434A5C File Offset: 0x00432C5C
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
				base.Pause();
				base.ReturnPrevUITask();
				HeroBreakRarityUpUITask.m_heroId = 0;
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06010102 RID: 65794 RVA: 0x00434AE0 File Offset: 0x00432CE0
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

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06010103 RID: 65795 RVA: 0x00434B54 File Offset: 0x00432D54
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

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x06010104 RID: 65796 RVA: 0x00434BC8 File Offset: 0x00432DC8
		// (set) Token: 0x06010105 RID: 65797 RVA: 0x00434BE8 File Offset: 0x00432DE8
		[DoNotToLua]
		public new HeroBreakRarityUpUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroBreakRarityUpUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010106 RID: 65798 RVA: 0x00434BF4 File Offset: 0x00432DF4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06010107 RID: 65799 RVA: 0x00434C00 File Offset: 0x00432E00
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06010108 RID: 65800 RVA: 0x00434C08 File Offset: 0x00432E08
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06010109 RID: 65801 RVA: 0x00434C10 File Offset: 0x00432E10
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601010A RID: 65802 RVA: 0x00434C1C File Offset: 0x00432E1C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601010B RID: 65803 RVA: 0x00434C28 File Offset: 0x00432E28
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601010C RID: 65804 RVA: 0x00434C34 File Offset: 0x00432E34
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601010D RID: 65805 RVA: 0x00434C3C File Offset: 0x00432E3C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601010E RID: 65806 RVA: 0x00434C44 File Offset: 0x00432E44
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601010F RID: 65807 RVA: 0x00434C4C File Offset: 0x00432E4C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06010110 RID: 65808 RVA: 0x00434C54 File Offset: 0x00432E54
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06010111 RID: 65809 RVA: 0x00434C5C File Offset: 0x00432E5C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06010112 RID: 65810 RVA: 0x00434C64 File Offset: 0x00432E64
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06010113 RID: 65811 RVA: 0x00434C6C File Offset: 0x00432E6C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06010114 RID: 65812 RVA: 0x00434C78 File Offset: 0x00432E78
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06010115 RID: 65813 RVA: 0x00434C84 File Offset: 0x00432E84
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06010116 RID: 65814 RVA: 0x00434C90 File Offset: 0x00432E90
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06010117 RID: 65815 RVA: 0x00434C9C File Offset: 0x00432E9C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06010118 RID: 65816 RVA: 0x00434CA4 File Offset: 0x00432EA4
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06010119 RID: 65817 RVA: 0x00434CAC File Offset: 0x00432EAC
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0601011A RID: 65818 RVA: 0x00434CB4 File Offset: 0x00432EB4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601011B RID: 65819 RVA: 0x00434CBC File Offset: 0x00432EBC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0601011C RID: 65820 RVA: 0x00434CC4 File Offset: 0x00432EC4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601011E RID: 65822 RVA: 0x00434CEC File Offset: 0x00432EEC
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

		// Token: 0x0601011F RID: 65823 RVA: 0x00434E68 File Offset: 0x00433068
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroBreakRarityUpUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040095F2 RID: 38386
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "RarityUpUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/BreakEffect_ABS/Prefab/RarityUpUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040095F3 RID: 38387
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RarityUpUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroBreakRarityUpUIController"),
				m_ctrlName = "HeroBreakRarityUpUIController"
			}
		};

		// Token: 0x040095F4 RID: 38388
		private HeroBreakRarityUpUIController m_heroBreakRarityUpUIController;

		// Token: 0x040095F5 RID: 38389
		private static int m_heroId;

		// Token: 0x040095F6 RID: 38390
		[DoNotToLua]
		private HeroBreakRarityUpUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040095F7 RID: 38391
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x040095F8 RID: 38392
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040095F9 RID: 38393
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040095FA RID: 38394
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040095FB RID: 38395
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040095FC RID: 38396
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040095FD RID: 38397
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040095FE RID: 38398
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040095FF RID: 38399
		private LuaFunction m_OnClose_hotfix;

		// Token: 0x04009600 RID: 38400
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009601 RID: 38401
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D80 RID: 3456
		public new class LuaExportHelper
		{
			// Token: 0x06010120 RID: 65824 RVA: 0x00434ED0 File Offset: 0x004330D0
			public LuaExportHelper(HeroBreakRarityUpUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010121 RID: 65825 RVA: 0x00434EE0 File Offset: 0x004330E0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06010122 RID: 65826 RVA: 0x00434EF0 File Offset: 0x004330F0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06010123 RID: 65827 RVA: 0x00434F00 File Offset: 0x00433100
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06010124 RID: 65828 RVA: 0x00434F10 File Offset: 0x00433110
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06010125 RID: 65829 RVA: 0x00434F20 File Offset: 0x00433120
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06010126 RID: 65830 RVA: 0x00434F30 File Offset: 0x00433130
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06010127 RID: 65831 RVA: 0x00434F40 File Offset: 0x00433140
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06010128 RID: 65832 RVA: 0x00434F50 File Offset: 0x00433150
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06010129 RID: 65833 RVA: 0x00434F60 File Offset: 0x00433160
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0601012A RID: 65834 RVA: 0x00434F70 File Offset: 0x00433170
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601012B RID: 65835 RVA: 0x00434F80 File Offset: 0x00433180
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601012C RID: 65836 RVA: 0x00434F90 File Offset: 0x00433190
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601012D RID: 65837 RVA: 0x00434FA0 File Offset: 0x004331A0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601012E RID: 65838 RVA: 0x00434FB0 File Offset: 0x004331B0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601012F RID: 65839 RVA: 0x00434FC0 File Offset: 0x004331C0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06010130 RID: 65840 RVA: 0x00434FD0 File Offset: 0x004331D0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06010131 RID: 65841 RVA: 0x00434FE0 File Offset: 0x004331E0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06010132 RID: 65842 RVA: 0x00434FF0 File Offset: 0x004331F0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06010133 RID: 65843 RVA: 0x00435000 File Offset: 0x00433200
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06010134 RID: 65844 RVA: 0x00435010 File Offset: 0x00433210
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06010135 RID: 65845 RVA: 0x00435020 File Offset: 0x00433220
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06010136 RID: 65846 RVA: 0x00435030 File Offset: 0x00433230
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06010137 RID: 65847 RVA: 0x00435040 File Offset: 0x00433240
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003164 RID: 12644
			// (get) Token: 0x06010138 RID: 65848 RVA: 0x00435050 File Offset: 0x00433250
			// (set) Token: 0x06010139 RID: 65849 RVA: 0x00435060 File Offset: 0x00433260
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

			// Token: 0x17003165 RID: 12645
			// (get) Token: 0x0601013A RID: 65850 RVA: 0x00435070 File Offset: 0x00433270
			// (set) Token: 0x0601013B RID: 65851 RVA: 0x00435080 File Offset: 0x00433280
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

			// Token: 0x17003166 RID: 12646
			// (get) Token: 0x0601013C RID: 65852 RVA: 0x00435090 File Offset: 0x00433290
			// (set) Token: 0x0601013D RID: 65853 RVA: 0x004350A0 File Offset: 0x004332A0
			public HeroBreakRarityUpUIController m_heroBreakRarityUpUIController
			{
				get
				{
					return this.m_owner.m_heroBreakRarityUpUIController;
				}
				set
				{
					this.m_owner.m_heroBreakRarityUpUIController = value;
				}
			}

			// Token: 0x17003167 RID: 12647
			// (get) Token: 0x0601013E RID: 65854 RVA: 0x004350B0 File Offset: 0x004332B0
			// (set) Token: 0x0601013F RID: 65855 RVA: 0x004350B8 File Offset: 0x004332B8
			public static int m_heroId
			{
				get
				{
					return HeroBreakRarityUpUITask.m_heroId;
				}
				set
				{
					HeroBreakRarityUpUITask.m_heroId = value;
				}
			}

			// Token: 0x17003168 RID: 12648
			// (get) Token: 0x06010140 RID: 65856 RVA: 0x004350C0 File Offset: 0x004332C0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003169 RID: 12649
			// (get) Token: 0x06010141 RID: 65857 RVA: 0x004350D0 File Offset: 0x004332D0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06010142 RID: 65858 RVA: 0x004350E0 File Offset: 0x004332E0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06010143 RID: 65859 RVA: 0x004350F0 File Offset: 0x004332F0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06010144 RID: 65860 RVA: 0x00435100 File Offset: 0x00433300
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06010145 RID: 65861 RVA: 0x00435110 File Offset: 0x00433310
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06010146 RID: 65862 RVA: 0x00435120 File Offset: 0x00433320
			public void OnClose()
			{
				this.m_owner.OnClose();
			}

			// Token: 0x04009602 RID: 38402
			private HeroBreakRarityUpUITask m_owner;
		}
	}
}
