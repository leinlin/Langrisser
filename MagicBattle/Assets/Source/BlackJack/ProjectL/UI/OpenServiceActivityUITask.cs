using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009B5 RID: 2485
	[HotFix]
	public class OpenServiceActivityUITask : UITask
	{
		// Token: 0x06009059 RID: 36953 RVA: 0x0029F030 File Offset: 0x0029D230
		public OpenServiceActivityUITask(string name) : base(name)
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

		// Token: 0x0600905A RID: 36954 RVA: 0x0029F124 File Offset: 0x0029D324
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
			ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(14);
			ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
			if (charImageInfo != null)
			{
				base.CollectAsset(charImageInfo.Spine);
				base.CollectSpriteAsset(charImageInfo.Image);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x0029F1E0 File Offset: 0x0029D3E0
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
			if (this.m_openServiceActivityUIController == null)
			{
				this.m_openServiceActivityUIController = (this.m_uiCtrlArray[0] as OpenServiceActivityUIController);
				if (!(this.m_openServiceActivityUIController != null))
				{
					Debug.LogError("OpenServiceActivityUIController is null");
					return;
				}
				this.m_openServiceActivityUIController.EventOnReturn += this.OpenServiceActivityUIController_OnReturn;
				this.m_openServiceActivityUIController.EventOnMissionGet += this.OpenServiceActivityUIController_OnMissionGet;
				this.m_openServiceActivityUIController.EventOnMissionGoto += this.OpenServiceActivityUIController_OnMissionGoto;
				this.m_openServiceActivityUIController.EventOnIntegralGoodsClick += this.OpenServiceActivityUIController_OnIntegralGoodsClick;
			}
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x0029F2E8 File Offset: 0x0029D4E8
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
			if (this.m_openServiceActivityUIController != null)
			{
				this.m_openServiceActivityUIController.EventOnReturn -= this.OpenServiceActivityUIController_OnReturn;
				this.m_openServiceActivityUIController.EventOnMissionGet -= this.OpenServiceActivityUIController_OnMissionGet;
				this.m_openServiceActivityUIController.EventOnMissionGoto -= this.OpenServiceActivityUIController_OnMissionGoto;
				this.m_openServiceActivityUIController.EventOnIntegralGoodsClick -= this.OpenServiceActivityUIController_OnIntegralGoodsClick;
				this.m_openServiceActivityUIController = null;
			}
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x0029F3C4 File Offset: 0x0029D5C4
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
				this.m_openServiceActivityUIController.Open();
			}
			this.m_openServiceActivityUIController.UpdateViewInOpenServiceActivity();
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x0029F448 File Offset: 0x0029D648
		private void OpenServiceActivityUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenServiceActivityUIController_OnReturn_hotfix != null)
			{
				this.m_OpenServiceActivityUIController_OnReturn_hotfix.call(new object[]
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
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x0029F4CC File Offset: 0x0029D6CC
		private void OpenServiceActivityUIController_OnMissionGoto(GetPathData getPathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenServiceActivityUIController_OnMissionGotoGetPathData_hotfix != null)
			{
				this.m_OpenServiceActivityUIController_OnMissionGotoGetPathData_hotfix.call(new object[]
				{
					this,
					getPathInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathData getPathInfo = getPathInfo2;
			OpenServiceActivityUITask $this = this;
			int? num = new int?(0);
			FadeStyle style = FadeStyle.Black;
			int num2 = WorldUITask.CanGotoGetPath(getPathInfo, ref style);
			if (num2 <= 0)
			{
				num = new int?(num2);
				if (num == 0)
				{
					CommonUIController.Instance.StartFadeOut(delegate
					{
						$this.Pause();
						WorldUITask.StartGetPathTargetUITask(getPathInfo, $this.m_currIntent, null);
					}, style, -1f);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num.Value, 2f, null, true);
				}
				return;
			}
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x0029F5D0 File Offset: 0x0029D7D0
		private void OpenServiceActivityUIController_OnMissionGet(OpenServiceMissonUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenServiceActivityUIController_OnMissionGetOpenServiceMissonUIController_hotfix != null)
			{
				this.m_OpenServiceActivityUIController_OnMissionGetOpenServiceMissonUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OpenServiceActivityUITask.<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey1 <OpenServiceActivityUIController_OnMissionGet>c__AnonStorey = new OpenServiceActivityUITask.<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey1();
			<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey.ctrl = ctrl;
			<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey.$this = this;
			MissionRewardGetNetTask missionRewardGetNetTask = new MissionRewardGetNetTask(<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey.ctrl.Mission.MissionId);
			missionRewardGetNetTask.EventOnStop += delegate(Task task)
			{
				MissionRewardGetNetTask returnTask = task as MissionRewardGetNetTask;
				if (returnTask.Result == 0)
				{
					<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey.ctrl.PlayGetRewardEffect(delegate
					{
						List<Goods> rewards = returnTask.Rewards;
						if (rewards != null && rewards.Count != 0)
						{
							GetRewardGoodsUITask.StartUITask(rewards);
						}
						<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey.StartUpdatePipeLine(null, false, false, true);
					});
				}
				else if (returnTask.Result == -500)
				{
					BagFullUITask.StartUITask(<OpenServiceActivityUIController_OnMissionGet>c__AnonStorey.$this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(returnTask.Result, 2f, null, true);
				}
			};
			missionRewardGetNetTask.Start(null);
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x0029F684 File Offset: 0x0029D884
		private void OpenServiceActivityUIController_OnIntegralGoodsClick(IntegralGoodsUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenServiceActivityUIController_OnIntegralGoodsClickIntegralGoodsUIController_hotfix != null)
			{
				this.m_OpenServiceActivityUIController_OnIntegralGoodsClickIntegralGoodsUIController_hotfix.call(new object[]
				{
					this,
					ctrl2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IntegralGoodsUIController ctrl = ctrl2;
			OpenServiceActivityUITask $this = this;
			NoviceClaimRewardReqNetTask noviceClaimRewardReqNetTask = new NoviceClaimRewardReqNetTask(ctrl.Slot);
			noviceClaimRewardReqNetTask.EventOnStop += delegate(Task task)
			{
				NoviceClaimRewardReqNetTask noviceClaimRewardReqNetTask2 = task as NoviceClaimRewardReqNetTask;
				if (noviceClaimRewardReqNetTask2.Result == 0)
				{
					List<Goods> rewards = noviceClaimRewardReqNetTask2.Rewards;
					ctrl.PlayGotChangeEffect(delegate
					{
						if (rewards != null && rewards.Count != 0)
						{
							GetRewardGoodsUITask.StartUITask(rewards);
						}
					});
				}
				else if (noviceClaimRewardReqNetTask2.Result == -500)
				{
					BagFullUITask.StartUITask($this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(noviceClaimRewardReqNetTask2.Result, 2f, null, true);
				}
			};
			noviceClaimRewardReqNetTask.Start(null);
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x0029F734 File Offset: 0x0029D934
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_openServiceActivityUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateTimeText();
			}
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x0029F7D4 File Offset: 0x0029D9D4
		private void UpdateTimeText()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTimeText_hotfix != null)
			{
				this.m_UpdateTimeText_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan noviceMissionsEndTime = projectLPlayerContext.GetNoviceMissionsEndTime();
			this.m_openServiceActivityUIController.SetResidueTime(noviceMissionsEndTime);
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x0029F858 File Offset: 0x0029DA58
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

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06009065 RID: 36965 RVA: 0x0029F8CC File Offset: 0x0029DACC
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

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06009066 RID: 36966 RVA: 0x0029F940 File Offset: 0x0029DB40
		// (set) Token: 0x06009067 RID: 36967 RVA: 0x0029F960 File Offset: 0x0029DB60
		[DoNotToLua]
		public new OpenServiceActivityUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OpenServiceActivityUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x0029F96C File Offset: 0x0029DB6C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06009069 RID: 36969 RVA: 0x0029F978 File Offset: 0x0029DB78
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x0029F980 File Offset: 0x0029DB80
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600906B RID: 36971 RVA: 0x0029F988 File Offset: 0x0029DB88
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x0029F994 File Offset: 0x0029DB94
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600906D RID: 36973 RVA: 0x0029F9A0 File Offset: 0x0029DBA0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x0029F9AC File Offset: 0x0029DBAC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x0029F9B4 File Offset: 0x0029DBB4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06009070 RID: 36976 RVA: 0x0029F9BC File Offset: 0x0029DBBC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x0029F9C4 File Offset: 0x0029DBC4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x0029F9CC File Offset: 0x0029DBCC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x0029F9D4 File Offset: 0x0029DBD4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x0029F9DC File Offset: 0x0029DBDC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06009075 RID: 36981 RVA: 0x0029F9E4 File Offset: 0x0029DBE4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x0029F9F0 File Offset: 0x0029DBF0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06009077 RID: 36983 RVA: 0x0029F9FC File Offset: 0x0029DBFC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x0029FA08 File Offset: 0x0029DC08
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x0029FA14 File Offset: 0x0029DC14
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x0029FA1C File Offset: 0x0029DC1C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0029FA24 File Offset: 0x0029DC24
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x0029FA2C File Offset: 0x0029DC2C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x0029FA34 File Offset: 0x0029DC34
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x0029FA3C File Offset: 0x0029DC3C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06009080 RID: 36992 RVA: 0x0029FA60 File Offset: 0x0029DC60
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
					this.m_OpenServiceActivityUIController_OnReturn_hotfix = (luaObj.RawGet("OpenServiceActivityUIController_OnReturn") as LuaFunction);
					this.m_OpenServiceActivityUIController_OnMissionGotoGetPathData_hotfix = (luaObj.RawGet("OpenServiceActivityUIController_OnMissionGoto") as LuaFunction);
					this.m_OpenServiceActivityUIController_OnMissionGetOpenServiceMissonUIController_hotfix = (luaObj.RawGet("OpenServiceActivityUIController_OnMissionGet") as LuaFunction);
					this.m_OpenServiceActivityUIController_OnIntegralGoodsClickIntegralGoodsUIController_hotfix = (luaObj.RawGet("OpenServiceActivityUIController_OnIntegralGoodsClick") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateTimeText_hotfix = (luaObj.RawGet("UpdateTimeText") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x0029FC58 File Offset: 0x0029DE58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenServiceActivityUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006598 RID: 26008
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "OpenServiceActivityUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Activity_ABS/Prefab/LegendBeginUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006599 RID: 26009
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "OpenServiceActivityUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.OpenServiceActivityUIController"),
				m_ctrlName = "OpenServiceActivityUIController"
			}
		};

		// Token: 0x0400659A RID: 26010
		private OpenServiceActivityUIController m_openServiceActivityUIController;

		// Token: 0x0400659B RID: 26011
		private int m_nowSeconds;

		// Token: 0x0400659C RID: 26012
		[DoNotToLua]
		private OpenServiceActivityUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400659D RID: 26013
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400659E RID: 26014
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400659F RID: 26015
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040065A0 RID: 26016
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040065A1 RID: 26017
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040065A2 RID: 26018
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040065A3 RID: 26019
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040065A4 RID: 26020
		private LuaFunction m_OpenServiceActivityUIController_OnReturn_hotfix;

		// Token: 0x040065A5 RID: 26021
		private LuaFunction m_OpenServiceActivityUIController_OnMissionGotoGetPathData_hotfix;

		// Token: 0x040065A6 RID: 26022
		private LuaFunction m_OpenServiceActivityUIController_OnMissionGetOpenServiceMissonUIController_hotfix;

		// Token: 0x040065A7 RID: 26023
		private LuaFunction m_OpenServiceActivityUIController_OnIntegralGoodsClickIntegralGoodsUIController_hotfix;

		// Token: 0x040065A8 RID: 26024
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x040065A9 RID: 26025
		private LuaFunction m_UpdateTimeText_hotfix;

		// Token: 0x040065AA RID: 26026
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040065AB RID: 26027
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x020009B6 RID: 2486
		public new class LuaExportHelper
		{
			// Token: 0x06009082 RID: 36994 RVA: 0x0029FCC0 File Offset: 0x0029DEC0
			public LuaExportHelper(OpenServiceActivityUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009083 RID: 36995 RVA: 0x0029FCD0 File Offset: 0x0029DED0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06009084 RID: 36996 RVA: 0x0029FCE0 File Offset: 0x0029DEE0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06009085 RID: 36997 RVA: 0x0029FCF0 File Offset: 0x0029DEF0
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06009086 RID: 36998 RVA: 0x0029FD00 File Offset: 0x0029DF00
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06009087 RID: 36999 RVA: 0x0029FD10 File Offset: 0x0029DF10
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06009088 RID: 37000 RVA: 0x0029FD20 File Offset: 0x0029DF20
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06009089 RID: 37001 RVA: 0x0029FD30 File Offset: 0x0029DF30
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600908A RID: 37002 RVA: 0x0029FD40 File Offset: 0x0029DF40
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600908B RID: 37003 RVA: 0x0029FD50 File Offset: 0x0029DF50
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600908C RID: 37004 RVA: 0x0029FD60 File Offset: 0x0029DF60
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600908D RID: 37005 RVA: 0x0029FD70 File Offset: 0x0029DF70
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600908E RID: 37006 RVA: 0x0029FD80 File Offset: 0x0029DF80
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600908F RID: 37007 RVA: 0x0029FD90 File Offset: 0x0029DF90
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06009090 RID: 37008 RVA: 0x0029FDA0 File Offset: 0x0029DFA0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06009091 RID: 37009 RVA: 0x0029FDB0 File Offset: 0x0029DFB0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06009092 RID: 37010 RVA: 0x0029FDC0 File Offset: 0x0029DFC0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06009093 RID: 37011 RVA: 0x0029FDD0 File Offset: 0x0029DFD0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06009094 RID: 37012 RVA: 0x0029FDE0 File Offset: 0x0029DFE0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06009095 RID: 37013 RVA: 0x0029FDF0 File Offset: 0x0029DFF0
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06009096 RID: 37014 RVA: 0x0029FE00 File Offset: 0x0029E000
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06009097 RID: 37015 RVA: 0x0029FE10 File Offset: 0x0029E010
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06009098 RID: 37016 RVA: 0x0029FE20 File Offset: 0x0029E020
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06009099 RID: 37017 RVA: 0x0029FE30 File Offset: 0x0029E030
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17001E15 RID: 7701
			// (get) Token: 0x0600909A RID: 37018 RVA: 0x0029FE40 File Offset: 0x0029E040
			// (set) Token: 0x0600909B RID: 37019 RVA: 0x0029FE50 File Offset: 0x0029E050
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

			// Token: 0x17001E16 RID: 7702
			// (get) Token: 0x0600909C RID: 37020 RVA: 0x0029FE60 File Offset: 0x0029E060
			// (set) Token: 0x0600909D RID: 37021 RVA: 0x0029FE70 File Offset: 0x0029E070
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

			// Token: 0x17001E17 RID: 7703
			// (get) Token: 0x0600909E RID: 37022 RVA: 0x0029FE80 File Offset: 0x0029E080
			// (set) Token: 0x0600909F RID: 37023 RVA: 0x0029FE90 File Offset: 0x0029E090
			public OpenServiceActivityUIController m_openServiceActivityUIController
			{
				get
				{
					return this.m_owner.m_openServiceActivityUIController;
				}
				set
				{
					this.m_owner.m_openServiceActivityUIController = value;
				}
			}

			// Token: 0x17001E18 RID: 7704
			// (get) Token: 0x060090A0 RID: 37024 RVA: 0x0029FEA0 File Offset: 0x0029E0A0
			// (set) Token: 0x060090A1 RID: 37025 RVA: 0x0029FEB0 File Offset: 0x0029E0B0
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x17001E19 RID: 7705
			// (get) Token: 0x060090A2 RID: 37026 RVA: 0x0029FEC0 File Offset: 0x0029E0C0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001E1A RID: 7706
			// (get) Token: 0x060090A3 RID: 37027 RVA: 0x0029FED0 File Offset: 0x0029E0D0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060090A4 RID: 37028 RVA: 0x0029FEE0 File Offset: 0x0029E0E0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060090A5 RID: 37029 RVA: 0x0029FEF0 File Offset: 0x0029E0F0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060090A6 RID: 37030 RVA: 0x0029FF00 File Offset: 0x0029E100
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060090A7 RID: 37031 RVA: 0x0029FF10 File Offset: 0x0029E110
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060090A8 RID: 37032 RVA: 0x0029FF20 File Offset: 0x0029E120
			public void OpenServiceActivityUIController_OnReturn()
			{
				this.m_owner.OpenServiceActivityUIController_OnReturn();
			}

			// Token: 0x060090A9 RID: 37033 RVA: 0x0029FF30 File Offset: 0x0029E130
			public void OpenServiceActivityUIController_OnMissionGoto(GetPathData getPathInfo)
			{
				this.m_owner.OpenServiceActivityUIController_OnMissionGoto(getPathInfo);
			}

			// Token: 0x060090AA RID: 37034 RVA: 0x0029FF40 File Offset: 0x0029E140
			public void OpenServiceActivityUIController_OnMissionGet(OpenServiceMissonUIController ctrl)
			{
				this.m_owner.OpenServiceActivityUIController_OnMissionGet(ctrl);
			}

			// Token: 0x060090AB RID: 37035 RVA: 0x0029FF50 File Offset: 0x0029E150
			public void OpenServiceActivityUIController_OnIntegralGoodsClick(IntegralGoodsUIController ctrl)
			{
				this.m_owner.OpenServiceActivityUIController_OnIntegralGoodsClick(ctrl);
			}

			// Token: 0x060090AC RID: 37036 RVA: 0x0029FF60 File Offset: 0x0029E160
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x060090AD RID: 37037 RVA: 0x0029FF70 File Offset: 0x0029E170
			public void UpdateTimeText()
			{
				this.m_owner.UpdateTimeText();
			}

			// Token: 0x040065AC RID: 26028
			private OpenServiceActivityUITask m_owner;
		}
	}
}
