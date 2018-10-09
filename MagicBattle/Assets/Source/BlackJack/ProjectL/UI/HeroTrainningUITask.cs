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
	// Token: 0x02000E2A RID: 3626
	[HotFix]
	public class HeroTrainningUITask : UITask
	{
		// Token: 0x0601184C RID: 71756 RVA: 0x00488640 File Offset: 0x00486840
		public HeroTrainningUITask(string name) : base(name)
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

		// Token: 0x0601184D RID: 71757 RVA: 0x0048876C File Offset: 0x0048696C
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

		// Token: 0x0601184E RID: 71758 RVA: 0x004887F8 File Offset: 0x004869F8
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

		// Token: 0x0601184F RID: 71759 RVA: 0x00488884 File Offset: 0x00486A84
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_heroTrainningInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_heroTrainningInfo = uiintentCustom.GetClassParam<ConfigDataHeroTrainningInfo>("HeroTrainningInfo");
			}
			if (this.m_heroTrainningInfo != null && !projectLPlayerContext.IsHeroTrainningOpened(this.m_heroTrainningInfo.ID))
			{
				this.m_heroTrainningInfo = null;
			}
			if (this.m_heroTrainningInfo == null)
			{
				foreach (KeyValuePair<int, ConfigDataHeroTrainningInfo> keyValuePair in configDataLoader.GetAllConfigDataHeroTrainningInfo())
				{
					if (projectLPlayerContext.IsHeroTrainningOpened(keyValuePair.Key))
					{
						this.m_heroTrainningInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x06011850 RID: 71760 RVA: 0x004889DC File Offset: 0x00486BDC
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
			if (this.m_heroTrainningInfo != null)
			{
				base.CollectAsset(this.m_heroTrainningInfo.Model);
				List<Goods> list = new List<Goods>();
				foreach (ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo in this.m_heroTrainningInfo.m_levelInfos)
				{
					base.CollectSpriteAsset(configDataHeroTrainningLevelInfo.Icon);
					list.Clear();
					UIUtility.AppendRandomDropRewardGoodsToList(configDataHeroTrainningLevelInfo.Drop_ID, list);
					foreach (Goods goods in list)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011851 RID: 71761 RVA: 0x00488B38 File Offset: 0x00486D38
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
			this.InitHeroTrainningUIController();
		}

		// Token: 0x06011852 RID: 71762 RVA: 0x00488BA4 File Offset: 0x00486DA4
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
			this.UninitHeroTrainningUIController();
		}

		// Token: 0x06011853 RID: 71763 RVA: 0x00488C10 File Offset: 0x00486E10
		private void InitHeroTrainningUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroTrainningUIController_hotfix != null)
			{
				this.m_InitHeroTrainningUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroTrainningUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroTrainningUIController = (this.m_uiCtrlArray[0] as HeroTrainningUIController);
				}
				if (!(this.m_heroTrainningUIController != null))
				{
					Debug.LogError("HeroTrainingUIController is null");
					return;
				}
				this.m_heroTrainningUIController.EventOnReturn += this.HeroTrainningUIController_OnReturn;
				this.m_heroTrainningUIController.EventOnShowHelp += this.HeroTrainningUIController_OnShowHelp;
				this.m_heroTrainningUIController.EventOnShowTeam += this.HeroTrainningUIController_OnShowTeam;
				this.m_heroTrainningUIController.EventOnStartHeroTrainningLevel += this.HeroTrainningUIController_OnStartHeroTrainningLevel;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
			}
		}

		// Token: 0x06011854 RID: 71764 RVA: 0x00488D74 File Offset: 0x00486F74
		private void UninitHeroTrainningUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitHeroTrainningUIController_hotfix != null)
			{
				this.m_UninitHeroTrainningUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroTrainningUIController != null)
			{
				this.m_heroTrainningUIController.EventOnReturn -= this.HeroTrainningUIController_OnReturn;
				this.m_heroTrainningUIController.EventOnShowHelp -= this.HeroTrainningUIController_OnShowHelp;
				this.m_heroTrainningUIController.EventOnShowTeam -= this.HeroTrainningUIController_OnShowTeam;
				this.m_heroTrainningUIController.EventOnStartHeroTrainningLevel -= this.HeroTrainningUIController_OnStartHeroTrainningLevel;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06011855 RID: 71765 RVA: 0x00488E5C File Offset: 0x0048705C
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
				this.m_heroTrainningUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.m_heroTrainningUIController.SetDailyRewardCount(projectLPlayerContext.GetHeroTrainingDailyRewardRestCount(), projectLPlayerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_HeroTrainning));
			if (this.m_heroTrainningInfo != null)
			{
				this.m_heroTrainningUIController.SetHeroTrainning(this.m_heroTrainningInfo);
				this.m_heroTrainningUIController.ClearHeroTrainningLevelListItems();
				this.m_heroTrainningUIController.AddAllHeroTrainningLevelListItems(this.m_heroTrainningInfo.m_levelInfos);
			}
		}

		// Token: 0x06011856 RID: 71766 RVA: 0x00488F44 File Offset: 0x00487144
		private void HeroTrainningUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroTrainningUIController_OnReturn_hotfix != null)
			{
				this.m_HeroTrainningUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x06011857 RID: 71767 RVA: 0x00488FC8 File Offset: 0x004871C8
		private void HeroTrainningUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroTrainningUIController_OnShowHelp_hotfix != null)
			{
				this.m_HeroTrainningUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_HeroTraining);
		}

		// Token: 0x06011858 RID: 71768 RVA: 0x00489034 File Offset: 0x00487234
		private void HeroTrainningUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroTrainningUIController_OnShowTeam_hotfix != null)
			{
				this.m_HeroTrainningUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_HeroTrainning, this.m_heroTrainningInfo.ID, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06011859 RID: 71769 RVA: 0x004890B8 File Offset: 0x004872B8
		private void TeamUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_TeamUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TeamUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601185A RID: 71770 RVA: 0x00489144 File Offset: 0x00487344
		private void HeroTrainningUIController_OnStartHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroTrainningUIController_OnStartHeroTrainningLevelConfigDataHeroTrainningLevelInfo_hotfix != null)
			{
				this.m_HeroTrainningUIController_OnStartHeroTrainningLevelConfigDataHeroTrainningLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackHeroTrainningLevel(levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.HeroTrainning, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0601185B RID: 71771 RVA: 0x004891F8 File Offset: 0x004873F8
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

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0601185C RID: 71772 RVA: 0x0048926C File Offset: 0x0048746C
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

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0601185D RID: 71773 RVA: 0x004892E0 File Offset: 0x004874E0
		// (set) Token: 0x0601185E RID: 71774 RVA: 0x00489300 File Offset: 0x00487500
		[DoNotToLua]
		public new HeroTrainningUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroTrainningUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601185F RID: 71775 RVA: 0x0048930C File Offset: 0x0048750C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011860 RID: 71776 RVA: 0x00489318 File Offset: 0x00487518
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011861 RID: 71777 RVA: 0x00489320 File Offset: 0x00487520
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06011862 RID: 71778 RVA: 0x00489328 File Offset: 0x00487528
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06011863 RID: 71779 RVA: 0x00489334 File Offset: 0x00487534
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06011864 RID: 71780 RVA: 0x00489340 File Offset: 0x00487540
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06011865 RID: 71781 RVA: 0x0048934C File Offset: 0x0048754C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011866 RID: 71782 RVA: 0x00489354 File Offset: 0x00487554
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06011867 RID: 71783 RVA: 0x0048935C File Offset: 0x0048755C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06011868 RID: 71784 RVA: 0x00489364 File Offset: 0x00487564
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06011869 RID: 71785 RVA: 0x0048936C File Offset: 0x0048756C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601186A RID: 71786 RVA: 0x00489374 File Offset: 0x00487574
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601186B RID: 71787 RVA: 0x0048937C File Offset: 0x0048757C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601186C RID: 71788 RVA: 0x00489384 File Offset: 0x00487584
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601186D RID: 71789 RVA: 0x00489390 File Offset: 0x00487590
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0601186E RID: 71790 RVA: 0x0048939C File Offset: 0x0048759C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0601186F RID: 71791 RVA: 0x004893A8 File Offset: 0x004875A8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06011870 RID: 71792 RVA: 0x004893B4 File Offset: 0x004875B4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06011871 RID: 71793 RVA: 0x004893BC File Offset: 0x004875BC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06011872 RID: 71794 RVA: 0x004893C4 File Offset: 0x004875C4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06011873 RID: 71795 RVA: 0x004893CC File Offset: 0x004875CC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06011874 RID: 71796 RVA: 0x004893D4 File Offset: 0x004875D4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011875 RID: 71797 RVA: 0x004893DC File Offset: 0x004875DC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06011878 RID: 71800 RVA: 0x00489444 File Offset: 0x00487644
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
					this.m_InitHeroTrainningUIController_hotfix = (luaObj.RawGet("InitHeroTrainningUIController") as LuaFunction);
					this.m_UninitHeroTrainningUIController_hotfix = (luaObj.RawGet("UninitHeroTrainningUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_HeroTrainningUIController_OnReturn_hotfix = (luaObj.RawGet("HeroTrainningUIController_OnReturn") as LuaFunction);
					this.m_HeroTrainningUIController_OnShowHelp_hotfix = (luaObj.RawGet("HeroTrainningUIController_OnShowHelp") as LuaFunction);
					this.m_HeroTrainningUIController_OnShowTeam_hotfix = (luaObj.RawGet("HeroTrainningUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_HeroTrainningUIController_OnStartHeroTrainningLevelConfigDataHeroTrainningLevelInfo_hotfix = (luaObj.RawGet("HeroTrainningUIController_OnStartHeroTrainningLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011879 RID: 71801 RVA: 0x004896A0 File Offset: 0x004878A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009FD1 RID: 40913
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroTrainningUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/HeroTraining_ABS/Prefab/HeroTrainingUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009FD2 RID: 40914
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroTrainningUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroTrainningUIController"),
				m_ctrlName = "HeroTrainningUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroTrainningUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "HeroTrainningPlayerResourceUIController"
			}
		};

		// Token: 0x04009FD3 RID: 40915
		private HeroTrainningUIController m_heroTrainningUIController;

		// Token: 0x04009FD4 RID: 40916
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04009FD5 RID: 40917
		private ConfigDataHeroTrainningInfo m_heroTrainningInfo;

		// Token: 0x04009FD6 RID: 40918
		[DoNotToLua]
		private HeroTrainningUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009FD7 RID: 40919
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009FD8 RID: 40920
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009FD9 RID: 40921
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009FDA RID: 40922
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009FDB RID: 40923
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009FDC RID: 40924
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009FDD RID: 40925
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009FDE RID: 40926
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009FDF RID: 40927
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009FE0 RID: 40928
		private LuaFunction m_InitHeroTrainningUIController_hotfix;

		// Token: 0x04009FE1 RID: 40929
		private LuaFunction m_UninitHeroTrainningUIController_hotfix;

		// Token: 0x04009FE2 RID: 40930
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009FE3 RID: 40931
		private LuaFunction m_HeroTrainningUIController_OnReturn_hotfix;

		// Token: 0x04009FE4 RID: 40932
		private LuaFunction m_HeroTrainningUIController_OnShowHelp_hotfix;

		// Token: 0x04009FE5 RID: 40933
		private LuaFunction m_HeroTrainningUIController_OnShowTeam_hotfix;

		// Token: 0x04009FE6 RID: 40934
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009FE7 RID: 40935
		private LuaFunction m_HeroTrainningUIController_OnStartHeroTrainningLevelConfigDataHeroTrainningLevelInfo_hotfix;

		// Token: 0x04009FE8 RID: 40936
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009FE9 RID: 40937
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E2B RID: 3627
		public new class LuaExportHelper
		{
			// Token: 0x0601187A RID: 71802 RVA: 0x00489708 File Offset: 0x00487908
			public LuaExportHelper(HeroTrainningUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601187B RID: 71803 RVA: 0x00489718 File Offset: 0x00487918
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601187C RID: 71804 RVA: 0x00489728 File Offset: 0x00487928
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601187D RID: 71805 RVA: 0x00489738 File Offset: 0x00487938
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601187E RID: 71806 RVA: 0x00489748 File Offset: 0x00487948
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0601187F RID: 71807 RVA: 0x00489758 File Offset: 0x00487958
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011880 RID: 71808 RVA: 0x00489768 File Offset: 0x00487968
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011881 RID: 71809 RVA: 0x00489778 File Offset: 0x00487978
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011882 RID: 71810 RVA: 0x00489788 File Offset: 0x00487988
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06011883 RID: 71811 RVA: 0x00489798 File Offset: 0x00487998
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06011884 RID: 71812 RVA: 0x004897A8 File Offset: 0x004879A8
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06011885 RID: 71813 RVA: 0x004897B8 File Offset: 0x004879B8
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06011886 RID: 71814 RVA: 0x004897C8 File Offset: 0x004879C8
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06011887 RID: 71815 RVA: 0x004897D8 File Offset: 0x004879D8
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06011888 RID: 71816 RVA: 0x004897E8 File Offset: 0x004879E8
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06011889 RID: 71817 RVA: 0x004897F8 File Offset: 0x004879F8
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601188A RID: 71818 RVA: 0x00489808 File Offset: 0x00487A08
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0601188B RID: 71819 RVA: 0x00489818 File Offset: 0x00487A18
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601188C RID: 71820 RVA: 0x00489828 File Offset: 0x00487A28
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601188D RID: 71821 RVA: 0x00489838 File Offset: 0x00487A38
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601188E RID: 71822 RVA: 0x00489848 File Offset: 0x00487A48
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0601188F RID: 71823 RVA: 0x00489858 File Offset: 0x00487A58
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011890 RID: 71824 RVA: 0x00489868 File Offset: 0x00487A68
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011891 RID: 71825 RVA: 0x00489878 File Offset: 0x00487A78
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170035D8 RID: 13784
			// (get) Token: 0x06011892 RID: 71826 RVA: 0x00489888 File Offset: 0x00487A88
			// (set) Token: 0x06011893 RID: 71827 RVA: 0x00489898 File Offset: 0x00487A98
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

			// Token: 0x170035D9 RID: 13785
			// (get) Token: 0x06011894 RID: 71828 RVA: 0x004898A8 File Offset: 0x00487AA8
			// (set) Token: 0x06011895 RID: 71829 RVA: 0x004898B8 File Offset: 0x00487AB8
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

			// Token: 0x170035DA RID: 13786
			// (get) Token: 0x06011896 RID: 71830 RVA: 0x004898C8 File Offset: 0x00487AC8
			// (set) Token: 0x06011897 RID: 71831 RVA: 0x004898D8 File Offset: 0x00487AD8
			public HeroTrainningUIController m_heroTrainningUIController
			{
				get
				{
					return this.m_owner.m_heroTrainningUIController;
				}
				set
				{
					this.m_owner.m_heroTrainningUIController = value;
				}
			}

			// Token: 0x170035DB RID: 13787
			// (get) Token: 0x06011898 RID: 71832 RVA: 0x004898E8 File Offset: 0x00487AE8
			// (set) Token: 0x06011899 RID: 71833 RVA: 0x004898F8 File Offset: 0x00487AF8
			public PlayerResourceUIController m_playerResourceUIController
			{
				get
				{
					return this.m_owner.m_playerResourceUIController;
				}
				set
				{
					this.m_owner.m_playerResourceUIController = value;
				}
			}

			// Token: 0x170035DC RID: 13788
			// (get) Token: 0x0601189A RID: 71834 RVA: 0x00489908 File Offset: 0x00487B08
			// (set) Token: 0x0601189B RID: 71835 RVA: 0x00489918 File Offset: 0x00487B18
			public ConfigDataHeroTrainningInfo m_heroTrainningInfo
			{
				get
				{
					return this.m_owner.m_heroTrainningInfo;
				}
				set
				{
					this.m_owner.m_heroTrainningInfo = value;
				}
			}

			// Token: 0x170035DD RID: 13789
			// (get) Token: 0x0601189C RID: 71836 RVA: 0x00489928 File Offset: 0x00487B28
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170035DE RID: 13790
			// (get) Token: 0x0601189D RID: 71837 RVA: 0x00489938 File Offset: 0x00487B38
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601189E RID: 71838 RVA: 0x00489948 File Offset: 0x00487B48
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0601189F RID: 71839 RVA: 0x00489958 File Offset: 0x00487B58
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060118A0 RID: 71840 RVA: 0x00489968 File Offset: 0x00487B68
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060118A1 RID: 71841 RVA: 0x00489978 File Offset: 0x00487B78
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060118A2 RID: 71842 RVA: 0x00489988 File Offset: 0x00487B88
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060118A3 RID: 71843 RVA: 0x00489998 File Offset: 0x00487B98
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060118A4 RID: 71844 RVA: 0x004899A8 File Offset: 0x00487BA8
			public void InitHeroTrainningUIController()
			{
				this.m_owner.InitHeroTrainningUIController();
			}

			// Token: 0x060118A5 RID: 71845 RVA: 0x004899B8 File Offset: 0x00487BB8
			public void UninitHeroTrainningUIController()
			{
				this.m_owner.UninitHeroTrainningUIController();
			}

			// Token: 0x060118A6 RID: 71846 RVA: 0x004899C8 File Offset: 0x00487BC8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060118A7 RID: 71847 RVA: 0x004899D8 File Offset: 0x00487BD8
			public void HeroTrainningUIController_OnReturn()
			{
				this.m_owner.HeroTrainningUIController_OnReturn();
			}

			// Token: 0x060118A8 RID: 71848 RVA: 0x004899E8 File Offset: 0x00487BE8
			public void HeroTrainningUIController_OnShowHelp()
			{
				this.m_owner.HeroTrainningUIController_OnShowHelp();
			}

			// Token: 0x060118A9 RID: 71849 RVA: 0x004899F8 File Offset: 0x00487BF8
			public void HeroTrainningUIController_OnShowTeam()
			{
				this.m_owner.HeroTrainningUIController_OnShowTeam();
			}

			// Token: 0x060118AA RID: 71850 RVA: 0x00489A08 File Offset: 0x00487C08
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060118AB RID: 71851 RVA: 0x00489A18 File Offset: 0x00487C18
			public void HeroTrainningUIController_OnStartHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo)
			{
				this.m_owner.HeroTrainningUIController_OnStartHeroTrainningLevel(levelInfo);
			}

			// Token: 0x04009FEA RID: 40938
			private HeroTrainningUITask m_owner;
		}
	}
}
