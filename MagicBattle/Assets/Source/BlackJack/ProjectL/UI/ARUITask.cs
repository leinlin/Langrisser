using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.XR.iOS;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B1A RID: 2842
	[HotFix]
	public class ARUITask : UITask
	{
		// Token: 0x0600BF94 RID: 49044 RVA: 0x00356E18 File Offset: 0x00355018
		public ARUITask(string name) : base(name)
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

		// Token: 0x0600BF95 RID: 49045 RVA: 0x00356F6C File Offset: 0x0035516C
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
			this.m_arShowUIController = (this.m_uiCtrlArray[0] as ARShowUIController);
			this.m_arShowSceneController = (this.m_uiCtrlArray[1] as ARShowSceneController);
			this.m_arShowUIController.SetUITask(this);
			this.m_arShowUIController.SetARShowSceneController(this.m_arShowSceneController);
			this.m_arShowSceneController.SetUITask(this);
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x00357024 File Offset: 0x00355224
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

		// Token: 0x0600BF97 RID: 49047 RVA: 0x003570C4 File Offset: 0x003552C4
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
			NoticeUIController.IsForceHide = true;
			InviteNotifyUITask.DisableDisplay();
			return base.OnStart(intent);
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x00357154 File Offset: 0x00355354
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

		// Token: 0x0600BF99 RID: 49049 RVA: 0x003571B4 File Offset: 0x003553B4
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
			bool result = base.OnResume(intent);
			this.m_arShowUIController.LoadData();
			return result;
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x00357244 File Offset: 0x00355444
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnStop();
			InviteNotifyUITask.EnableDispaly();
			NoticeUIController.IsForceHide = false;
			UnityARSessionNativeInterface arsessionNativeInterface = UnityARSessionNativeInterface.GetARSessionNativeInterface();
			ARKitWorldTrackingSessionConfiguration config = default(ARKitWorldTrackingSessionConfiguration);
			config.planeDetection = UnityARPlaneDetection.Horizontal;
			config.alignment = UnityARAlignment.UnityARAlignmentGravity;
			config.getPointCloudData = false;
			config.enableLightEstimation = false;
			if (config.IsSupported)
			{
				arsessionNativeInterface.RunWithConfig(config);
			}
			arsessionNativeInterface.Pause();
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x003572FC File Offset: 0x003554FC
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

		// Token: 0x0600BF9C RID: 49052 RVA: 0x00357390 File Offset: 0x00355590
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

		// Token: 0x0600BF9D RID: 49053 RVA: 0x00357408 File Offset: 0x00355608
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

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0600BF9E RID: 49054 RVA: 0x00357470 File Offset: 0x00355670
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

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600BF9F RID: 49055 RVA: 0x003574E4 File Offset: 0x003556E4
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

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600BFA0 RID: 49056 RVA: 0x00357558 File Offset: 0x00355758
		// (set) Token: 0x0600BFA1 RID: 49057 RVA: 0x00357578 File Offset: 0x00355778
		[DoNotToLua]
		public new ARUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ARUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x00357584 File Offset: 0x00355784
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x00357590 File Offset: 0x00355790
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x00357598 File Offset: 0x00355798
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x003575A0 File Offset: 0x003557A0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x003575AC File Offset: 0x003557AC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x003575B8 File Offset: 0x003557B8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x003575C4 File Offset: 0x003557C4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x003575CC File Offset: 0x003557CC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x003575D4 File Offset: 0x003557D4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x003575DC File Offset: 0x003557DC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x003575E4 File Offset: 0x003557E4
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x003575EC File Offset: 0x003557EC
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x003575F4 File Offset: 0x003557F4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x003575FC File Offset: 0x003557FC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x00357608 File Offset: 0x00355808
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600BFB1 RID: 49073 RVA: 0x00357614 File Offset: 0x00355814
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x00357620 File Offset: 0x00355820
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x0035762C File Offset: 0x0035582C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x00357634 File Offset: 0x00355834
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x0035763C File Offset: 0x0035583C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x00357644 File Offset: 0x00355844
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600BFB7 RID: 49079 RVA: 0x0035764C File Offset: 0x0035584C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x00357654 File Offset: 0x00355854
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600BFB9 RID: 49081 RVA: 0x0035765C File Offset: 0x0035585C
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_CustomLoadAssetActionAction_hotfix = (luaObj.RawGet("CustomLoadAsset") as LuaFunction);
					this.m_CollectAssetWrapString_hotfix = (luaObj.RawGet("CollectAssetWrap") as LuaFunction);
					this.m_ReturnLastTask_hotfix = (luaObj.RawGet("ReturnLastTask") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BFBA RID: 49082 RVA: 0x0035783C File Offset: 0x00355A3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ARUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007A71 RID: 31345
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ARShowSceneLayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/AR_ABS/ARShowScenePrefab.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ARShowUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/AR_ABS/ARShowUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007A72 RID: 31346
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ARShowUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ARShowUIController"),
				m_ctrlName = "ARShowUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ARShowSceneLayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ARShowSceneController"),
				m_ctrlName = "ARShowSceneController"
			}
		};

		// Token: 0x04007A73 RID: 31347
		private ARShowUIController m_arShowUIController;

		// Token: 0x04007A74 RID: 31348
		private ARShowSceneController m_arShowSceneController;

		// Token: 0x04007A75 RID: 31349
		[DoNotToLua]
		private ARUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007A76 RID: 31350
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007A77 RID: 31351
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007A78 RID: 31352
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007A79 RID: 31353
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007A7A RID: 31354
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x04007A7B RID: 31355
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007A7C RID: 31356
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007A7D RID: 31357
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04007A7E RID: 31358
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04007A7F RID: 31359
		private LuaFunction m_CustomLoadAssetActionAction_hotfix;

		// Token: 0x04007A80 RID: 31360
		private LuaFunction m_CollectAssetWrapString_hotfix;

		// Token: 0x04007A81 RID: 31361
		private LuaFunction m_ReturnLastTask_hotfix;

		// Token: 0x04007A82 RID: 31362
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007A83 RID: 31363
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B1B RID: 2843
		public new class LuaExportHelper
		{
			// Token: 0x0600BFBB RID: 49083 RVA: 0x003578A4 File Offset: 0x00355AA4
			public LuaExportHelper(ARUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BFBC RID: 49084 RVA: 0x003578B4 File Offset: 0x00355AB4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600BFBD RID: 49085 RVA: 0x003578C4 File Offset: 0x00355AC4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600BFBE RID: 49086 RVA: 0x003578D4 File Offset: 0x00355AD4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600BFBF RID: 49087 RVA: 0x003578E4 File Offset: 0x00355AE4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600BFC0 RID: 49088 RVA: 0x003578F4 File Offset: 0x00355AF4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600BFC1 RID: 49089 RVA: 0x00357904 File Offset: 0x00355B04
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600BFC2 RID: 49090 RVA: 0x00357914 File Offset: 0x00355B14
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600BFC3 RID: 49091 RVA: 0x00357924 File Offset: 0x00355B24
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600BFC4 RID: 49092 RVA: 0x00357934 File Offset: 0x00355B34
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600BFC5 RID: 49093 RVA: 0x00357944 File Offset: 0x00355B44
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600BFC6 RID: 49094 RVA: 0x00357954 File Offset: 0x00355B54
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600BFC7 RID: 49095 RVA: 0x00357964 File Offset: 0x00355B64
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600BFC8 RID: 49096 RVA: 0x00357974 File Offset: 0x00355B74
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600BFC9 RID: 49097 RVA: 0x00357984 File Offset: 0x00355B84
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600BFCA RID: 49098 RVA: 0x00357994 File Offset: 0x00355B94
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600BFCB RID: 49099 RVA: 0x003579A4 File Offset: 0x00355BA4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600BFCC RID: 49100 RVA: 0x003579B4 File Offset: 0x00355BB4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600BFCD RID: 49101 RVA: 0x003579C4 File Offset: 0x00355BC4
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600BFCE RID: 49102 RVA: 0x003579D4 File Offset: 0x00355BD4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600BFCF RID: 49103 RVA: 0x003579E4 File Offset: 0x00355BE4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600BFD0 RID: 49104 RVA: 0x003579F4 File Offset: 0x00355BF4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600BFD1 RID: 49105 RVA: 0x00357A04 File Offset: 0x00355C04
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600BFD2 RID: 49106 RVA: 0x00357A14 File Offset: 0x00355C14
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700267D RID: 9853
			// (get) Token: 0x0600BFD3 RID: 49107 RVA: 0x00357A24 File Offset: 0x00355C24
			// (set) Token: 0x0600BFD4 RID: 49108 RVA: 0x00357A34 File Offset: 0x00355C34
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

			// Token: 0x1700267E RID: 9854
			// (get) Token: 0x0600BFD5 RID: 49109 RVA: 0x00357A44 File Offset: 0x00355C44
			// (set) Token: 0x0600BFD6 RID: 49110 RVA: 0x00357A54 File Offset: 0x00355C54
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

			// Token: 0x1700267F RID: 9855
			// (get) Token: 0x0600BFD7 RID: 49111 RVA: 0x00357A64 File Offset: 0x00355C64
			// (set) Token: 0x0600BFD8 RID: 49112 RVA: 0x00357A74 File Offset: 0x00355C74
			public ARShowUIController m_arShowUIController
			{
				get
				{
					return this.m_owner.m_arShowUIController;
				}
				set
				{
					this.m_owner.m_arShowUIController = value;
				}
			}

			// Token: 0x17002680 RID: 9856
			// (get) Token: 0x0600BFD9 RID: 49113 RVA: 0x00357A84 File Offset: 0x00355C84
			// (set) Token: 0x0600BFDA RID: 49114 RVA: 0x00357A94 File Offset: 0x00355C94
			public ARShowSceneController m_arShowSceneController
			{
				get
				{
					return this.m_owner.m_arShowSceneController;
				}
				set
				{
					this.m_owner.m_arShowSceneController = value;
				}
			}

			// Token: 0x17002681 RID: 9857
			// (get) Token: 0x0600BFDB RID: 49115 RVA: 0x00357AA4 File Offset: 0x00355CA4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002682 RID: 9858
			// (get) Token: 0x0600BFDC RID: 49116 RVA: 0x00357AB4 File Offset: 0x00355CB4
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600BFDD RID: 49117 RVA: 0x00357AC4 File Offset: 0x00355CC4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600BFDE RID: 49118 RVA: 0x00357AD4 File Offset: 0x00355CD4
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600BFDF RID: 49119 RVA: 0x00357AE4 File Offset: 0x00355CE4
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600BFE0 RID: 49120 RVA: 0x00357AF4 File Offset: 0x00355CF4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600BFE1 RID: 49121 RVA: 0x00357B04 File Offset: 0x00355D04
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600BFE2 RID: 49122 RVA: 0x00357B14 File Offset: 0x00355D14
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x04007A84 RID: 31364
			private ARUITask m_owner;
		}
	}
}
