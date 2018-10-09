using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A4B RID: 2635
	[HotFix]
	public class BagFullUITask : UITask
	{
		// Token: 0x0600A299 RID: 41625 RVA: 0x002DD6A4 File Offset: 0x002DB8A4
		public BagFullUITask(string name) : base(name)
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

		// Token: 0x0600A29A RID: 41626 RVA: 0x002DD798 File Offset: 0x002DB998
		public static void StartUITask(UIIntent uiIntent)
		{
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(uiIntent, typeof(BagFullUITask).Name, null);
			uiintentReturnable.SetParam("LastUIIntent", uiIntent);
			UIManager.Instance.StartUITask(uiintentReturnable, true, false, null);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x002DD7D8 File Offset: 0x002DB9D8
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

		// Token: 0x0600A29C RID: 41628 RVA: 0x002DD864 File Offset: 0x002DBA64
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

		// Token: 0x0600A29D RID: 41629 RVA: 0x002DD8F0 File Offset: 0x002DBAF0
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
			this.m_lastUIIntent = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_lastUIIntent = uiintentCustom.GetClassParam<UIIntent>("LastUIIntent");
			}
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x002DD988 File Offset: 0x002DBB88
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
			if (this.m_bagFullUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_bagFullUIController = (this.m_uiCtrlArray[0] as BagFullUIController);
				}
				if (!(this.m_bagFullUIController != null))
				{
					Debug.LogError("BagFullUITask is null");
					return;
				}
				this.m_bagFullUIController.EventOnReturn += this.BagFullUIController_OnReturn;
				this.m_bagFullUIController.EventOnGotoBag += this.BagFullUIController_OnGotoBag;
			}
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x002DDA70 File Offset: 0x002DBC70
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
			if (this.m_bagFullUIController != null)
			{
				this.m_bagFullUIController.EventOnReturn -= this.BagFullUIController_OnReturn;
				this.m_bagFullUIController.EventOnGotoBag -= this.BagFullUIController_OnGotoBag;
				this.m_bagFullUIController = null;
			}
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x002DDB1C File Offset: 0x002DBD1C
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
				this.m_bagFullUIController.Open();
			}
			this.m_bagFullUIController.UpdateView();
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x002DDBA0 File Offset: 0x002DBDA0
		private void BagFullUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagFullUIController_OnReturn_hotfix != null)
			{
				this.m_BagFullUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bagFullUIController.Close(delegate
			{
				base.Pause();
				base.ReturnPrevUITask();
			});
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x002DDC18 File Offset: 0x002DBE18
		private void BagFullUIController_OnGotoBag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagFullUIController_OnGotoBag_hotfix != null)
			{
				this.m_BagFullUIController_OnGotoBag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = new UIIntentReturnable(this.m_lastUIIntent, typeof(BagListUITask).Name, null);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.BagListUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x002DDC9C File Offset: 0x002DBE9C
		private void BagListUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_BagListUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(BagListUITask));
			if (uitaskBase != null)
			{
				if (this.m_lastUIIntent != null)
				{
					UITaskBase uitaskBase2 = UIManager.Instance.FindUITaskWithName(this.m_lastUIIntent.TargetTaskName);
					if (uitaskBase2 != null)
					{
						uitaskBase2.Pause();
					}
				}
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600A2A4 RID: 41636 RVA: 0x002DDD58 File Offset: 0x002DBF58
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

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x002DDDCC File Offset: 0x002DBFCC
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

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600A2A6 RID: 41638 RVA: 0x002DDE40 File Offset: 0x002DC040
		// (set) Token: 0x0600A2A7 RID: 41639 RVA: 0x002DDE60 File Offset: 0x002DC060
		[DoNotToLua]
		public new BagFullUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagFullUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x002DDE6C File Offset: 0x002DC06C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x002DDE78 File Offset: 0x002DC078
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x002DDE80 File Offset: 0x002DC080
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x002DDE88 File Offset: 0x002DC088
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x002DDE94 File Offset: 0x002DC094
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x002DDEA0 File Offset: 0x002DC0A0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x002DDEAC File Offset: 0x002DC0AC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x002DDEB4 File Offset: 0x002DC0B4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x002DDEBC File Offset: 0x002DC0BC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x002DDEC4 File Offset: 0x002DC0C4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x002DDECC File Offset: 0x002DC0CC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x002DDED4 File Offset: 0x002DC0D4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x002DDEDC File Offset: 0x002DC0DC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x002DDEE4 File Offset: 0x002DC0E4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x002DDEF0 File Offset: 0x002DC0F0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x002DDEFC File Offset: 0x002DC0FC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x002DDF08 File Offset: 0x002DC108
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x002DDF14 File Offset: 0x002DC114
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x002DDF1C File Offset: 0x002DC11C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x002DDF24 File Offset: 0x002DC124
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x002DDF2C File Offset: 0x002DC12C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x002DDF34 File Offset: 0x002DC134
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x002DDF3C File Offset: 0x002DC13C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x002DDF98 File Offset: 0x002DC198
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_BagFullUIController_OnReturn_hotfix = (luaObj.RawGet("BagFullUIController_OnReturn") as LuaFunction);
					this.m_BagFullUIController_OnGotoBag_hotfix = (luaObj.RawGet("BagFullUIController_OnGotoBag") as LuaFunction);
					this.m_BagListUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("BagListUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x002DE178 File Offset: 0x002DC378
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagFullUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006CD8 RID: 27864
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BagFullUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Bag_ABS/Prefab/BagFullUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006CD9 RID: 27865
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BagFullUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BagFullUIController"),
				m_ctrlName = "BagFullUIController"
			}
		};

		// Token: 0x04006CDA RID: 27866
		private BagFullUIController m_bagFullUIController;

		// Token: 0x04006CDB RID: 27867
		private UIIntent m_lastUIIntent;

		// Token: 0x04006CDC RID: 27868
		[DoNotToLua]
		private BagFullUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006CDD RID: 27869
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006CDE RID: 27870
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006CDF RID: 27871
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04006CE0 RID: 27872
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04006CE1 RID: 27873
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04006CE2 RID: 27874
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04006CE3 RID: 27875
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006CE4 RID: 27876
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006CE5 RID: 27877
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006CE6 RID: 27878
		private LuaFunction m_BagFullUIController_OnReturn_hotfix;

		// Token: 0x04006CE7 RID: 27879
		private LuaFunction m_BagFullUIController_OnGotoBag_hotfix;

		// Token: 0x04006CE8 RID: 27880
		private LuaFunction m_BagListUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04006CE9 RID: 27881
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04006CEA RID: 27882
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000A4C RID: 2636
		public new class LuaExportHelper
		{
			// Token: 0x0600A2C3 RID: 41667 RVA: 0x002DE1E0 File Offset: 0x002DC3E0
			public LuaExportHelper(BagFullUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A2C4 RID: 41668 RVA: 0x002DE1F0 File Offset: 0x002DC3F0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600A2C5 RID: 41669 RVA: 0x002DE200 File Offset: 0x002DC400
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600A2C6 RID: 41670 RVA: 0x002DE210 File Offset: 0x002DC410
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600A2C7 RID: 41671 RVA: 0x002DE220 File Offset: 0x002DC420
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600A2C8 RID: 41672 RVA: 0x002DE230 File Offset: 0x002DC430
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600A2C9 RID: 41673 RVA: 0x002DE240 File Offset: 0x002DC440
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600A2CA RID: 41674 RVA: 0x002DE250 File Offset: 0x002DC450
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A2CB RID: 41675 RVA: 0x002DE260 File Offset: 0x002DC460
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600A2CC RID: 41676 RVA: 0x002DE270 File Offset: 0x002DC470
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600A2CD RID: 41677 RVA: 0x002DE280 File Offset: 0x002DC480
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600A2CE RID: 41678 RVA: 0x002DE290 File Offset: 0x002DC490
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600A2CF RID: 41679 RVA: 0x002DE2A0 File Offset: 0x002DC4A0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600A2D0 RID: 41680 RVA: 0x002DE2B0 File Offset: 0x002DC4B0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600A2D1 RID: 41681 RVA: 0x002DE2C0 File Offset: 0x002DC4C0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600A2D2 RID: 41682 RVA: 0x002DE2D0 File Offset: 0x002DC4D0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600A2D3 RID: 41683 RVA: 0x002DE2E0 File Offset: 0x002DC4E0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600A2D4 RID: 41684 RVA: 0x002DE2F0 File Offset: 0x002DC4F0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600A2D5 RID: 41685 RVA: 0x002DE300 File Offset: 0x002DC500
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600A2D6 RID: 41686 RVA: 0x002DE310 File Offset: 0x002DC510
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600A2D7 RID: 41687 RVA: 0x002DE320 File Offset: 0x002DC520
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600A2D8 RID: 41688 RVA: 0x002DE330 File Offset: 0x002DC530
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600A2D9 RID: 41689 RVA: 0x002DE340 File Offset: 0x002DC540
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600A2DA RID: 41690 RVA: 0x002DE350 File Offset: 0x002DC550
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700210E RID: 8462
			// (get) Token: 0x0600A2DB RID: 41691 RVA: 0x002DE360 File Offset: 0x002DC560
			// (set) Token: 0x0600A2DC RID: 41692 RVA: 0x002DE370 File Offset: 0x002DC570
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

			// Token: 0x1700210F RID: 8463
			// (get) Token: 0x0600A2DD RID: 41693 RVA: 0x002DE380 File Offset: 0x002DC580
			// (set) Token: 0x0600A2DE RID: 41694 RVA: 0x002DE390 File Offset: 0x002DC590
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

			// Token: 0x17002110 RID: 8464
			// (get) Token: 0x0600A2DF RID: 41695 RVA: 0x002DE3A0 File Offset: 0x002DC5A0
			// (set) Token: 0x0600A2E0 RID: 41696 RVA: 0x002DE3B0 File Offset: 0x002DC5B0
			public BagFullUIController m_bagFullUIController
			{
				get
				{
					return this.m_owner.m_bagFullUIController;
				}
				set
				{
					this.m_owner.m_bagFullUIController = value;
				}
			}

			// Token: 0x17002111 RID: 8465
			// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x002DE3C0 File Offset: 0x002DC5C0
			// (set) Token: 0x0600A2E2 RID: 41698 RVA: 0x002DE3D0 File Offset: 0x002DC5D0
			public UIIntent m_lastUIIntent
			{
				get
				{
					return this.m_owner.m_lastUIIntent;
				}
				set
				{
					this.m_owner.m_lastUIIntent = value;
				}
			}

			// Token: 0x17002112 RID: 8466
			// (get) Token: 0x0600A2E3 RID: 41699 RVA: 0x002DE3E0 File Offset: 0x002DC5E0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002113 RID: 8467
			// (get) Token: 0x0600A2E4 RID: 41700 RVA: 0x002DE3F0 File Offset: 0x002DC5F0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600A2E5 RID: 41701 RVA: 0x002DE400 File Offset: 0x002DC600
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600A2E6 RID: 41702 RVA: 0x002DE410 File Offset: 0x002DC610
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600A2E7 RID: 41703 RVA: 0x002DE420 File Offset: 0x002DC620
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600A2E8 RID: 41704 RVA: 0x002DE430 File Offset: 0x002DC630
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600A2E9 RID: 41705 RVA: 0x002DE440 File Offset: 0x002DC640
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600A2EA RID: 41706 RVA: 0x002DE450 File Offset: 0x002DC650
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600A2EB RID: 41707 RVA: 0x002DE460 File Offset: 0x002DC660
			public void BagFullUIController_OnReturn()
			{
				this.m_owner.BagFullUIController_OnReturn();
			}

			// Token: 0x0600A2EC RID: 41708 RVA: 0x002DE470 File Offset: 0x002DC670
			public void BagFullUIController_OnGotoBag()
			{
				this.m_owner.BagFullUIController_OnGotoBag();
			}

			// Token: 0x0600A2ED RID: 41709 RVA: 0x002DE480 File Offset: 0x002DC680
			public void BagListUITask_OnLoadAllResCompleted()
			{
				this.m_owner.BagListUITask_OnLoadAllResCompleted();
			}

			// Token: 0x04006CEB RID: 27883
			private BagFullUITask m_owner;
		}
	}
}
