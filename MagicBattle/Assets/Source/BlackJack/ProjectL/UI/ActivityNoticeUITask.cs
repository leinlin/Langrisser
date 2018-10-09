using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009C4 RID: 2500
	[HotFix]
	public class ActivityNoticeUITask : UITask
	{
		// Token: 0x06009186 RID: 37254 RVA: 0x002A2330 File Offset: 0x002A0530
		public ActivityNoticeUITask(string name) : base(name)
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

		// Token: 0x06009187 RID: 37255 RVA: 0x002A2438 File Offset: 0x002A0638
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
			if (this.m_activityNoticeUICtrl == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_activityNoticeUICtrl = (this.m_uiCtrlArray[0] as ActivityNoticeUIController);
				}
				this.m_activityNoticeUICtrl.EventOnActivityClick += this.ActivityNoticeUIController_ActivityClick;
				this.m_activityNoticeUICtrl.EventOnCloseButtonClick += this.ActivityNoticeUIController_CloseButtonClick;
				return;
			}
			Debug.LogError("ActivityNoticeUIController is null");
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x002A2510 File Offset: 0x002A0710
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
			if (this.m_activityNoticeUICtrl != null)
			{
				this.m_activityNoticeUICtrl.EventOnActivityClick -= this.ActivityNoticeUIController_ActivityClick;
				this.m_activityNoticeUICtrl.EventOnCloseButtonClick -= this.ActivityNoticeUIController_CloseButtonClick;
				this.m_activityNoticeUICtrl = null;
			}
		}

		// Token: 0x06009189 RID: 37257 RVA: 0x002A25BC File Offset: 0x002A07BC
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (configDataLoader != null)
			{
				List<AdvertisementFlowLayout> allAdvertisementFlowLayouts = this.m_playerCtx.GetAllAdvertisementFlowLayouts();
				foreach (AdvertisementFlowLayout advertisementFlowLayout in allAdvertisementFlowLayouts)
				{
					ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = configDataLoader.GetConfigDataOperationalActivityInfo(advertisementFlowLayout.ActivityId);
					if (configDataOperationalActivityInfo != null)
					{
						base.CollectSpriteAsset(configDataOperationalActivityInfo.AdvertisingImage);
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600918A RID: 37258 RVA: 0x002A26C0 File Offset: 0x002A08C0
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
				this.m_activityNoticeUICtrl.SignOpenTween();
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (configDataLoader == null)
			{
				return;
			}
			List<AdvertisementFlowLayout> allAdvertisementFlowLayouts = this.m_playerCtx.GetAllAdvertisementFlowLayouts();
			List<ActivityNoticeInfo> list = new List<ActivityNoticeInfo>();
			foreach (AdvertisementFlowLayout advertisementFlowLayout in allAdvertisementFlowLayouts)
			{
				ConfigDataOperationalActivityInfo configDataOperationalActivityInfo = configDataLoader.GetConfigDataOperationalActivityInfo(advertisementFlowLayout.ActivityId);
				if (configDataOperationalActivityInfo != null)
				{
					list.Add(new ActivityNoticeInfo
					{
						ActivityId = advertisementFlowLayout.ActivityId,
						ImageName = configDataOperationalActivityInfo.AdvertisingImage,
						IsLarge = advertisementFlowLayout.IsLarge,
						SortId = advertisementFlowLayout.SortId,
						Desc = configDataOperationalActivityInfo.Desc
					});
				}
			}
			list.Sort((ActivityNoticeInfo a, ActivityNoticeInfo b) => a.SortId.CompareTo(b.SortId));
			this.m_activityNoticeUICtrl.UpdateActivityList(list);
		}

		// Token: 0x0600918B RID: 37259 RVA: 0x002A2840 File Offset: 0x002A0A40
		private void ActivityNoticeUIController_ActivityClick(int activityId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityNoticeUIController_ActivityClickInt32_hotfix != null)
			{
				this.m_ActivityNoticeUIController_ActivityClickInt32_hotfix.call(new object[]
				{
					this,
					activityId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int activityId = activityId2;
			ActivityNoticeUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				$this.Pause();
				WorldUITask.StartGetPathTargetUITask(new GetPathData
				{
					PathType = GetPathType.GetPathType_Activity,
					ID = activityId
				}, null, null);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600918C RID: 37260 RVA: 0x002A28E8 File Offset: 0x002A0AE8
		private void ActivityNoticeUIController_CloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityNoticeUIController_CloseButtonClick_hotfix != null)
			{
				this.m_ActivityNoticeUIController_CloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			base.ReturnPrevUITask();
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x002A2958 File Offset: 0x002A0B58
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

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x002A29CC File Offset: 0x002A0BCC
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

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x002A2A40 File Offset: 0x002A0C40
		// (set) Token: 0x06009190 RID: 37264 RVA: 0x002A2A60 File Offset: 0x002A0C60
		[DoNotToLua]
		public new ActivityNoticeUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityNoticeUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x002A2A6C File Offset: 0x002A0C6C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x002A2A78 File Offset: 0x002A0C78
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x002A2A80 File Offset: 0x002A0C80
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x002A2A88 File Offset: 0x002A0C88
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x002A2A94 File Offset: 0x002A0C94
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x002A2AA0 File Offset: 0x002A0CA0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x002A2AAC File Offset: 0x002A0CAC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x002A2AB4 File Offset: 0x002A0CB4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x002A2ABC File Offset: 0x002A0CBC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x002A2AC4 File Offset: 0x002A0CC4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x002A2ACC File Offset: 0x002A0CCC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x002A2AD4 File Offset: 0x002A0CD4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x002A2ADC File Offset: 0x002A0CDC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x002A2AE4 File Offset: 0x002A0CE4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600919F RID: 37279 RVA: 0x002A2AF0 File Offset: 0x002A0CF0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x002A2AFC File Offset: 0x002A0CFC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x002A2B08 File Offset: 0x002A0D08
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x002A2B14 File Offset: 0x002A0D14
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x002A2B1C File Offset: 0x002A0D1C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x002A2B24 File Offset: 0x002A0D24
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x002A2B2C File Offset: 0x002A0D2C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x002A2B34 File Offset: 0x002A0D34
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x002A2B3C File Offset: 0x002A0D3C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x002A2B58 File Offset: 0x002A0D58
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
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ActivityNoticeUIController_ActivityClickInt32_hotfix = (luaObj.RawGet("ActivityNoticeUIController_ActivityClick") as LuaFunction);
					this.m_ActivityNoticeUIController_CloseButtonClick_hotfix = (luaObj.RawGet("ActivityNoticeUIController_CloseButtonClick") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x002A2CEC File Offset: 0x002A0EEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityNoticeUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040065FF RID: 26111
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ActivityNoticeUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Activity_ABS/Prefab/NoticeBeginUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006600 RID: 26112
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ActivityNoticeUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ActivityNoticeUIController"),
				m_ctrlName = "ActivityNoticeUIController"
			}
		};

		// Token: 0x04006601 RID: 26113
		private ActivityNoticeUIController m_activityNoticeUICtrl;

		// Token: 0x04006602 RID: 26114
		private ProjectLPlayerContext m_playerCtx = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04006603 RID: 26115
		[DoNotToLua]
		private ActivityNoticeUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006605 RID: 26117
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006606 RID: 26118
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006607 RID: 26119
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04006608 RID: 26120
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006609 RID: 26121
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400660A RID: 26122
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400660B RID: 26123
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400660C RID: 26124
		private LuaFunction m_ActivityNoticeUIController_ActivityClickInt32_hotfix;

		// Token: 0x0400660D RID: 26125
		private LuaFunction m_ActivityNoticeUIController_CloseButtonClick_hotfix;

		// Token: 0x0400660E RID: 26126
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400660F RID: 26127
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x020009C5 RID: 2501
		public new class LuaExportHelper
		{
			// Token: 0x060091AB RID: 37291 RVA: 0x002A2D54 File Offset: 0x002A0F54
			public LuaExportHelper(ActivityNoticeUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060091AC RID: 37292 RVA: 0x002A2D64 File Offset: 0x002A0F64
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060091AD RID: 37293 RVA: 0x002A2D74 File Offset: 0x002A0F74
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060091AE RID: 37294 RVA: 0x002A2D84 File Offset: 0x002A0F84
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060091AF RID: 37295 RVA: 0x002A2D94 File Offset: 0x002A0F94
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060091B0 RID: 37296 RVA: 0x002A2DA4 File Offset: 0x002A0FA4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060091B1 RID: 37297 RVA: 0x002A2DB4 File Offset: 0x002A0FB4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060091B2 RID: 37298 RVA: 0x002A2DC4 File Offset: 0x002A0FC4
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060091B3 RID: 37299 RVA: 0x002A2DD4 File Offset: 0x002A0FD4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060091B4 RID: 37300 RVA: 0x002A2DE4 File Offset: 0x002A0FE4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060091B5 RID: 37301 RVA: 0x002A2DF4 File Offset: 0x002A0FF4
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060091B6 RID: 37302 RVA: 0x002A2E04 File Offset: 0x002A1004
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060091B7 RID: 37303 RVA: 0x002A2E14 File Offset: 0x002A1014
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060091B8 RID: 37304 RVA: 0x002A2E24 File Offset: 0x002A1024
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060091B9 RID: 37305 RVA: 0x002A2E34 File Offset: 0x002A1034
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060091BA RID: 37306 RVA: 0x002A2E44 File Offset: 0x002A1044
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060091BB RID: 37307 RVA: 0x002A2E54 File Offset: 0x002A1054
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060091BC RID: 37308 RVA: 0x002A2E64 File Offset: 0x002A1064
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060091BD RID: 37309 RVA: 0x002A2E74 File Offset: 0x002A1074
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060091BE RID: 37310 RVA: 0x002A2E84 File Offset: 0x002A1084
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060091BF RID: 37311 RVA: 0x002A2E94 File Offset: 0x002A1094
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060091C0 RID: 37312 RVA: 0x002A2EA4 File Offset: 0x002A10A4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060091C1 RID: 37313 RVA: 0x002A2EB4 File Offset: 0x002A10B4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060091C2 RID: 37314 RVA: 0x002A2EC4 File Offset: 0x002A10C4
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17001E38 RID: 7736
			// (get) Token: 0x060091C3 RID: 37315 RVA: 0x002A2ED4 File Offset: 0x002A10D4
			// (set) Token: 0x060091C4 RID: 37316 RVA: 0x002A2EE4 File Offset: 0x002A10E4
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

			// Token: 0x17001E39 RID: 7737
			// (get) Token: 0x060091C5 RID: 37317 RVA: 0x002A2EF4 File Offset: 0x002A10F4
			// (set) Token: 0x060091C6 RID: 37318 RVA: 0x002A2F04 File Offset: 0x002A1104
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

			// Token: 0x17001E3A RID: 7738
			// (get) Token: 0x060091C7 RID: 37319 RVA: 0x002A2F14 File Offset: 0x002A1114
			// (set) Token: 0x060091C8 RID: 37320 RVA: 0x002A2F24 File Offset: 0x002A1124
			public ActivityNoticeUIController m_activityNoticeUICtrl
			{
				get
				{
					return this.m_owner.m_activityNoticeUICtrl;
				}
				set
				{
					this.m_owner.m_activityNoticeUICtrl = value;
				}
			}

			// Token: 0x17001E3B RID: 7739
			// (get) Token: 0x060091C9 RID: 37321 RVA: 0x002A2F34 File Offset: 0x002A1134
			// (set) Token: 0x060091CA RID: 37322 RVA: 0x002A2F44 File Offset: 0x002A1144
			public ProjectLPlayerContext m_playerCtx
			{
				get
				{
					return this.m_owner.m_playerCtx;
				}
				set
				{
					this.m_owner.m_playerCtx = value;
				}
			}

			// Token: 0x17001E3C RID: 7740
			// (get) Token: 0x060091CB RID: 37323 RVA: 0x002A2F54 File Offset: 0x002A1154
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001E3D RID: 7741
			// (get) Token: 0x060091CC RID: 37324 RVA: 0x002A2F64 File Offset: 0x002A1164
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060091CD RID: 37325 RVA: 0x002A2F74 File Offset: 0x002A1174
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060091CE RID: 37326 RVA: 0x002A2F84 File Offset: 0x002A1184
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060091CF RID: 37327 RVA: 0x002A2F94 File Offset: 0x002A1194
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060091D0 RID: 37328 RVA: 0x002A2FA4 File Offset: 0x002A11A4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060091D1 RID: 37329 RVA: 0x002A2FB4 File Offset: 0x002A11B4
			public void ActivityNoticeUIController_ActivityClick(int activityId)
			{
				this.m_owner.ActivityNoticeUIController_ActivityClick(activityId);
			}

			// Token: 0x060091D2 RID: 37330 RVA: 0x002A2FC4 File Offset: 0x002A11C4
			public void ActivityNoticeUIController_CloseButtonClick()
			{
				this.m_owner.ActivityNoticeUIController_CloseButtonClick();
			}

			// Token: 0x04006610 RID: 26128
			private ActivityNoticeUITask m_owner;
		}
	}
}
