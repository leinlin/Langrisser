using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D4B RID: 3403
	[HotFix]
	public class GuildUITask : UITask
	{
		// Token: 0x0600F9AA RID: 63914 RVA: 0x0041B9C8 File Offset: 0x00419BC8
		public GuildUITask(string name) : base(name)
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

		// Token: 0x0600F9AB RID: 63915 RVA: 0x0041BABC File Offset: 0x00419CBC
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
		}

		// Token: 0x0600F9AC RID: 63916 RVA: 0x0041BB1C File Offset: 0x00419D1C
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600F9AD RID: 63917 RVA: 0x0041BBAC File Offset: 0x00419DAC
		public void ReturnPrevUITaskWrap()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReturnPrevUITaskWrap_hotfix != null)
			{
				this.m_ReturnPrevUITaskWrap_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ReturnPrevUITask();
		}

		// Token: 0x0600F9AE RID: 63918 RVA: 0x0041BC14 File Offset: 0x00419E14
		public void LoadRes(List<string> assetList, Action onComplete)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadResList`1Action_hotfix != null)
			{
				this.m_LoadResList`1Action_hotfix.call(new object[]
				{
					this,
					assetList,
					onComplete
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<string> pathList = base.CalculateDynamicResReallyNeedLoad(assetList);
			ResourceManager.Instance.StartLoadAssetsCorutine(pathList, this.m_dynamicResCacheDict, onComplete, false);
		}

		// Token: 0x17002FA2 RID: 12194
		// (get) Token: 0x0600F9AF RID: 63919 RVA: 0x0041BCB0 File Offset: 0x00419EB0
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

		// Token: 0x17002FA3 RID: 12195
		// (get) Token: 0x0600F9B0 RID: 63920 RVA: 0x0041BD24 File Offset: 0x00419F24
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

		// Token: 0x17002FA4 RID: 12196
		// (get) Token: 0x0600F9B1 RID: 63921 RVA: 0x0041BD98 File Offset: 0x00419F98
		// (set) Token: 0x0600F9B2 RID: 63922 RVA: 0x0041BDB8 File Offset: 0x00419FB8
		[DoNotToLua]
		public new GuildUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F9B3 RID: 63923 RVA: 0x0041BDC4 File Offset: 0x00419FC4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600F9B4 RID: 63924 RVA: 0x0041BDD0 File Offset: 0x00419FD0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600F9B5 RID: 63925 RVA: 0x0041BDD8 File Offset: 0x00419FD8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600F9B6 RID: 63926 RVA: 0x0041BDE0 File Offset: 0x00419FE0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600F9B7 RID: 63927 RVA: 0x0041BDEC File Offset: 0x00419FEC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600F9B8 RID: 63928 RVA: 0x0041BDF8 File Offset: 0x00419FF8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600F9B9 RID: 63929 RVA: 0x0041BE04 File Offset: 0x0041A004
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F9BA RID: 63930 RVA: 0x0041BE0C File Offset: 0x0041A00C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600F9BB RID: 63931 RVA: 0x0041BE14 File Offset: 0x0041A014
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600F9BC RID: 63932 RVA: 0x0041BE1C File Offset: 0x0041A01C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600F9BD RID: 63933 RVA: 0x0041BE24 File Offset: 0x0041A024
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600F9BE RID: 63934 RVA: 0x0041BE2C File Offset: 0x0041A02C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600F9BF RID: 63935 RVA: 0x0041BE34 File Offset: 0x0041A034
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600F9C0 RID: 63936 RVA: 0x0041BE3C File Offset: 0x0041A03C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600F9C1 RID: 63937 RVA: 0x0041BE48 File Offset: 0x0041A048
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600F9C2 RID: 63938 RVA: 0x0041BE54 File Offset: 0x0041A054
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600F9C3 RID: 63939 RVA: 0x0041BE60 File Offset: 0x0041A060
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600F9C4 RID: 63940 RVA: 0x0041BE6C File Offset: 0x0041A06C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600F9C5 RID: 63941 RVA: 0x0041BE74 File Offset: 0x0041A074
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600F9C6 RID: 63942 RVA: 0x0041BE7C File Offset: 0x0041A07C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600F9C7 RID: 63943 RVA: 0x0041BE84 File Offset: 0x0041A084
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600F9C8 RID: 63944 RVA: 0x0041BE8C File Offset: 0x0041A08C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600F9C9 RID: 63945 RVA: 0x0041BE94 File Offset: 0x0041A094
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600F9CA RID: 63946 RVA: 0x0041BE9C File Offset: 0x0041A09C
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ReturnPrevUITaskWrap_hotfix = (luaObj.RawGet("ReturnPrevUITaskWrap") as LuaFunction);
					this.m_LoadResList`1Action_hotfix = (luaObj.RawGet("LoadRes") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F9CB RID: 63947 RVA: 0x0041C000 File Offset: 0x0041A200
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040092A0 RID: 37536
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "SociatyUIPrefab",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/GuildUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040092A1 RID: 37537
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "SociatyUIPrefab",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BeforeJoinGuildUIController"),
				m_ctrlName = "BeforeJoinGuildUIController"
			}
		};

		// Token: 0x040092A2 RID: 37538
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040092A3 RID: 37539
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040092A4 RID: 37540
		[DoNotToLua]
		private GuildUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040092A5 RID: 37541
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040092A6 RID: 37542
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040092A7 RID: 37543
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040092A8 RID: 37544
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040092A9 RID: 37545
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040092AA RID: 37546
		private LuaFunction m_ReturnPrevUITaskWrap_hotfix;

		// Token: 0x040092AB RID: 37547
		private LuaFunction m_LoadResList;

		// Token: 0x040092AC RID: 37548
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040092AD RID: 37549
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D4C RID: 3404
		public new class LuaExportHelper
		{
			// Token: 0x0600F9CC RID: 63948 RVA: 0x0041C068 File Offset: 0x0041A268
			public LuaExportHelper(GuildUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F9CD RID: 63949 RVA: 0x0041C078 File Offset: 0x0041A278
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600F9CE RID: 63950 RVA: 0x0041C088 File Offset: 0x0041A288
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600F9CF RID: 63951 RVA: 0x0041C098 File Offset: 0x0041A298
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600F9D0 RID: 63952 RVA: 0x0041C0A8 File Offset: 0x0041A2A8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600F9D1 RID: 63953 RVA: 0x0041C0B8 File Offset: 0x0041A2B8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600F9D2 RID: 63954 RVA: 0x0041C0C8 File Offset: 0x0041A2C8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600F9D3 RID: 63955 RVA: 0x0041C0D8 File Offset: 0x0041A2D8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F9D4 RID: 63956 RVA: 0x0041C0E8 File Offset: 0x0041A2E8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600F9D5 RID: 63957 RVA: 0x0041C0F8 File Offset: 0x0041A2F8
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600F9D6 RID: 63958 RVA: 0x0041C108 File Offset: 0x0041A308
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600F9D7 RID: 63959 RVA: 0x0041C118 File Offset: 0x0041A318
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600F9D8 RID: 63960 RVA: 0x0041C128 File Offset: 0x0041A328
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600F9D9 RID: 63961 RVA: 0x0041C138 File Offset: 0x0041A338
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600F9DA RID: 63962 RVA: 0x0041C148 File Offset: 0x0041A348
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600F9DB RID: 63963 RVA: 0x0041C158 File Offset: 0x0041A358
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600F9DC RID: 63964 RVA: 0x0041C168 File Offset: 0x0041A368
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600F9DD RID: 63965 RVA: 0x0041C178 File Offset: 0x0041A378
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600F9DE RID: 63966 RVA: 0x0041C188 File Offset: 0x0041A388
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600F9DF RID: 63967 RVA: 0x0041C198 File Offset: 0x0041A398
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600F9E0 RID: 63968 RVA: 0x0041C1A8 File Offset: 0x0041A3A8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600F9E1 RID: 63969 RVA: 0x0041C1B8 File Offset: 0x0041A3B8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600F9E2 RID: 63970 RVA: 0x0041C1C8 File Offset: 0x0041A3C8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600F9E3 RID: 63971 RVA: 0x0041C1D8 File Offset: 0x0041A3D8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002FA5 RID: 12197
			// (get) Token: 0x0600F9E4 RID: 63972 RVA: 0x0041C1E8 File Offset: 0x0041A3E8
			// (set) Token: 0x0600F9E5 RID: 63973 RVA: 0x0041C1F8 File Offset: 0x0041A3F8
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

			// Token: 0x17002FA6 RID: 12198
			// (get) Token: 0x0600F9E6 RID: 63974 RVA: 0x0041C208 File Offset: 0x0041A408
			// (set) Token: 0x0600F9E7 RID: 63975 RVA: 0x0041C218 File Offset: 0x0041A418
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

			// Token: 0x17002FA7 RID: 12199
			// (get) Token: 0x0600F9E8 RID: 63976 RVA: 0x0041C228 File Offset: 0x0041A428
			// (set) Token: 0x0600F9E9 RID: 63977 RVA: 0x0041C238 File Offset: 0x0041A438
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002FA8 RID: 12200
			// (get) Token: 0x0600F9EA RID: 63978 RVA: 0x0041C248 File Offset: 0x0041A448
			// (set) Token: 0x0600F9EB RID: 63979 RVA: 0x0041C258 File Offset: 0x0041A458
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17002FA9 RID: 12201
			// (get) Token: 0x0600F9EC RID: 63980 RVA: 0x0041C268 File Offset: 0x0041A468
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002FAA RID: 12202
			// (get) Token: 0x0600F9ED RID: 63981 RVA: 0x0041C278 File Offset: 0x0041A478
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600F9EE RID: 63982 RVA: 0x0041C288 File Offset: 0x0041A488
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600F9EF RID: 63983 RVA: 0x0041C298 File Offset: 0x0041A498
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x040092AE RID: 37550
			private GuildUITask m_owner;
		}
	}
}
