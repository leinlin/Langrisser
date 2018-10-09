using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009D6 RID: 2518
	[HotFix]
	public class ArchiveUITask : UITask
	{
		// Token: 0x060093F7 RID: 37879 RVA: 0x002A9774 File Offset: 0x002A7974
		public ArchiveUITask(string name) : base(name)
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

		// Token: 0x060093F8 RID: 37880 RVA: 0x002A998C File Offset: 0x002A7B8C
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
			this.m_manualUIController = (this.m_uiCtrlArray[0] as ManualUIController);
			this.m_heroArchiveUIController = (this.m_uiCtrlArray[1] as HeroArchiveUIController);
			this.m_equipmentArchiveUIController = (this.m_uiCtrlArray[2] as EquipmentArchiveUIController);
			this.m_heroShowUIController = (this.m_uiCtrlArray[3] as HeroShowUIController);
			this.m_manualUIController.SetTask(this);
			this.m_heroArchiveUIController.SetTask(this);
			this.m_equipmentArchiveUIController.SetTask(this);
			this.m_heroShowUIController.SetTask(this);
			this.m_manualUIController.gameObject.SetActive(true);
			this.m_heroArchiveUIController.gameObject.SetActive(false);
			this.m_equipmentArchiveUIController.gameObject.SetActive(false);
			this.m_heroShowUIController.gameObject.SetActive(false);
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x002A9AB4 File Offset: 0x002A7CB4
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitLayerStateOnLoadAllResCompleted();
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x002A9B54 File Offset: 0x002A7D54
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x002A9BBC File Offset: 0x002A7DBC
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

		// Token: 0x060093FC RID: 37884 RVA: 0x002A9C1C File Offset: 0x002A7E1C
		public void CustomLoadAsset(Action collectionCallback, Action finishCallback)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CustomLoadAssetActionAction_hotfix != null)
			{
				this.m_CustomLoadAssetActionAction_hotfix.call(new object[]
				{
					this,
					collectionCallback,
					finishCallback
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			collectionCallback();
			base.StartLoadCustomAssets(finishCallback);
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x002A9CB0 File Offset: 0x002A7EB0
		public void CollectAssetWrap(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAssetWrapString_hotfix != null)
			{
				this.m_CollectAssetWrapString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.CollectAsset(assetName);
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x002A9D28 File Offset: 0x002A7F28
		public void CollectSpriteAssetWrap(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSpriteAssetWrapString_hotfix != null)
			{
				this.m_CollectSpriteAssetWrapString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x002A9DA0 File Offset: 0x002A7FA0
		public void ReturnLastTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReturnLastTask_hotfix != null)
			{
				this.m_ReturnLastTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ReturnPrevUITask();
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x002A9E08 File Offset: 0x002A8008
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

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06009401 RID: 37889 RVA: 0x002A9E7C File Offset: 0x002A807C
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

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06009402 RID: 37890 RVA: 0x002A9EF0 File Offset: 0x002A80F0
		// (set) Token: 0x06009403 RID: 37891 RVA: 0x002A9F10 File Offset: 0x002A8110
		[DoNotToLua]
		public new ArchiveUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArchiveUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x002A9F1C File Offset: 0x002A811C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x002A9F28 File Offset: 0x002A8128
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x002A9F30 File Offset: 0x002A8130
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x002A9F38 File Offset: 0x002A8138
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x002A9F44 File Offset: 0x002A8144
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x002A9F50 File Offset: 0x002A8150
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x002A9F5C File Offset: 0x002A815C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x002A9F64 File Offset: 0x002A8164
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x002A9F6C File Offset: 0x002A816C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x002A9F74 File Offset: 0x002A8174
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x002A9F7C File Offset: 0x002A817C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x002A9F84 File Offset: 0x002A8184
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x002A9F8C File Offset: 0x002A818C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x002A9F94 File Offset: 0x002A8194
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x002A9FA0 File Offset: 0x002A81A0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x002A9FAC File Offset: 0x002A81AC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x002A9FB8 File Offset: 0x002A81B8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x002A9FC4 File Offset: 0x002A81C4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x002A9FCC File Offset: 0x002A81CC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x002A9FD4 File Offset: 0x002A81D4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x002A9FDC File Offset: 0x002A81DC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x002A9FE4 File Offset: 0x002A81E4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600941A RID: 37914 RVA: 0x002A9FEC File Offset: 0x002A81EC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600941B RID: 37915 RVA: 0x002A9FF4 File Offset: 0x002A81F4
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_CustomLoadAssetActionAction_hotfix = (luaObj.RawGet("CustomLoadAsset") as LuaFunction);
					this.m_CollectAssetWrapString_hotfix = (luaObj.RawGet("CollectAssetWrap") as LuaFunction);
					this.m_CollectSpriteAssetWrapString_hotfix = (luaObj.RawGet("CollectSpriteAssetWrap") as LuaFunction);
					this.m_ReturnLastTask_hotfix = (luaObj.RawGet("ReturnLastTask") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x002AA1BC File Offset: 0x002A83BC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArchiveUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040066C4 RID: 26308
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ManualUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Archive_ABS/Prefab/ManualUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroArchiveUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Archive_ABS/Prefab/HeroArchiveUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "EquipmentArchiveUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Archive_ABS/Prefab/EquipmentArchiveUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroShowUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Share_ABS/Prefab/HeroShowUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040066C5 RID: 26309
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ManualUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ManualUIController"),
				m_ctrlName = "ManualUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroArchiveUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroArchiveUIController"),
				m_ctrlName = "HeroArchiveUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "EquipmentArchiveUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.EquipmentArchiveUIController"),
				m_ctrlName = "EquipmentArchiveUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroShowUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroShowUIController"),
				m_ctrlName = "HeroShowUIController"
			}
		};

		// Token: 0x040066C6 RID: 26310
		public ManualUIController m_manualUIController;

		// Token: 0x040066C7 RID: 26311
		public HeroArchiveUIController m_heroArchiveUIController;

		// Token: 0x040066C8 RID: 26312
		public EquipmentArchiveUIController m_equipmentArchiveUIController;

		// Token: 0x040066C9 RID: 26313
		public HeroShowUIController m_heroShowUIController;

		// Token: 0x040066CA RID: 26314
		[DoNotToLua]
		private ArchiveUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040066CB RID: 26315
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040066CC RID: 26316
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040066CD RID: 26317
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040066CE RID: 26318
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040066CF RID: 26319
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x040066D0 RID: 26320
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x040066D1 RID: 26321
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040066D2 RID: 26322
		private LuaFunction m_CustomLoadAssetActionAction_hotfix;

		// Token: 0x040066D3 RID: 26323
		private LuaFunction m_CollectAssetWrapString_hotfix;

		// Token: 0x040066D4 RID: 26324
		private LuaFunction m_CollectSpriteAssetWrapString_hotfix;

		// Token: 0x040066D5 RID: 26325
		private LuaFunction m_ReturnLastTask_hotfix;

		// Token: 0x040066D6 RID: 26326
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040066D7 RID: 26327
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x020009D7 RID: 2519
		public new class LuaExportHelper
		{
			// Token: 0x0600941D RID: 37917 RVA: 0x002AA224 File Offset: 0x002A8424
			public LuaExportHelper(ArchiveUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600941E RID: 37918 RVA: 0x002AA234 File Offset: 0x002A8434
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600941F RID: 37919 RVA: 0x002AA244 File Offset: 0x002A8444
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06009420 RID: 37920 RVA: 0x002AA254 File Offset: 0x002A8454
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06009421 RID: 37921 RVA: 0x002AA264 File Offset: 0x002A8464
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06009422 RID: 37922 RVA: 0x002AA274 File Offset: 0x002A8474
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06009423 RID: 37923 RVA: 0x002AA284 File Offset: 0x002A8484
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06009424 RID: 37924 RVA: 0x002AA294 File Offset: 0x002A8494
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06009425 RID: 37925 RVA: 0x002AA2A4 File Offset: 0x002A84A4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06009426 RID: 37926 RVA: 0x002AA2B4 File Offset: 0x002A84B4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06009427 RID: 37927 RVA: 0x002AA2C4 File Offset: 0x002A84C4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06009428 RID: 37928 RVA: 0x002AA2D4 File Offset: 0x002A84D4
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06009429 RID: 37929 RVA: 0x002AA2E4 File Offset: 0x002A84E4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600942A RID: 37930 RVA: 0x002AA2F4 File Offset: 0x002A84F4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600942B RID: 37931 RVA: 0x002AA304 File Offset: 0x002A8504
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600942C RID: 37932 RVA: 0x002AA314 File Offset: 0x002A8514
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600942D RID: 37933 RVA: 0x002AA324 File Offset: 0x002A8524
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600942E RID: 37934 RVA: 0x002AA334 File Offset: 0x002A8534
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600942F RID: 37935 RVA: 0x002AA344 File Offset: 0x002A8544
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06009430 RID: 37936 RVA: 0x002AA354 File Offset: 0x002A8554
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06009431 RID: 37937 RVA: 0x002AA364 File Offset: 0x002A8564
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06009432 RID: 37938 RVA: 0x002AA374 File Offset: 0x002A8574
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06009433 RID: 37939 RVA: 0x002AA384 File Offset: 0x002A8584
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06009434 RID: 37940 RVA: 0x002AA394 File Offset: 0x002A8594
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17001E80 RID: 7808
			// (get) Token: 0x06009435 RID: 37941 RVA: 0x002AA3A4 File Offset: 0x002A85A4
			// (set) Token: 0x06009436 RID: 37942 RVA: 0x002AA3B4 File Offset: 0x002A85B4
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

			// Token: 0x17001E81 RID: 7809
			// (get) Token: 0x06009437 RID: 37943 RVA: 0x002AA3C4 File Offset: 0x002A85C4
			// (set) Token: 0x06009438 RID: 37944 RVA: 0x002AA3D4 File Offset: 0x002A85D4
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

			// Token: 0x17001E82 RID: 7810
			// (get) Token: 0x06009439 RID: 37945 RVA: 0x002AA3E4 File Offset: 0x002A85E4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001E83 RID: 7811
			// (get) Token: 0x0600943A RID: 37946 RVA: 0x002AA3F4 File Offset: 0x002A85F4
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600943B RID: 37947 RVA: 0x002AA404 File Offset: 0x002A8604
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600943C RID: 37948 RVA: 0x002AA414 File Offset: 0x002A8614
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600943D RID: 37949 RVA: 0x002AA424 File Offset: 0x002A8624
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600943E RID: 37950 RVA: 0x002AA434 File Offset: 0x002A8634
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x040066D8 RID: 26328
			private ArchiveUITask m_owner;
		}
	}
}
