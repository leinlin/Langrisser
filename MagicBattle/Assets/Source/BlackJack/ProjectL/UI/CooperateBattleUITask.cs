using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C15 RID: 3093
	[HotFix]
	public class CooperateBattleUITask : UITask
	{
		// Token: 0x0600D96D RID: 55661 RVA: 0x003B0644 File Offset: 0x003AE844
		public CooperateBattleUITask(string name) : base(name)
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

		// Token: 0x0600D96E RID: 55662 RVA: 0x003B0770 File Offset: 0x003AE970
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

		// Token: 0x0600D96F RID: 55663 RVA: 0x003B07FC File Offset: 0x003AE9FC
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

		// Token: 0x0600D970 RID: 55664 RVA: 0x003B0888 File Offset: 0x003AEA88
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
			this.m_cooperateBattleInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_cooperateBattleInfo = uiintentCustom.GetClassParam<ConfigDataCooperateBattleInfo>("CooperateBattleInfo");
			}
			if (this.m_cooperateBattleInfo != null && !projectLPlayerContext.IsCooperateBattleOpened(this.m_cooperateBattleInfo.ID))
			{
				this.m_cooperateBattleInfo = null;
			}
			if (this.m_cooperateBattleInfo == null)
			{
				foreach (KeyValuePair<int, ConfigDataCooperateBattleInfo> keyValuePair in configDataLoader.GetAllConfigDataCooperateBattleInfo())
				{
					if (projectLPlayerContext.IsCooperateBattleOpened(keyValuePair.Key))
					{
						this.m_cooperateBattleInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x003B09E0 File Offset: 0x003AEBE0
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
			if (this.m_cooperateBattleInfo != null)
			{
				base.CollectSpriteAsset(this.m_cooperateBattleInfo.BriefView);
				List<Goods> list = new List<Goods>();
				foreach (ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo in this.m_cooperateBattleInfo.m_levelInfos)
				{
					base.CollectSpriteAsset(configDataCooperateBattleLevelInfo.Icon);
					list.Clear();
					UIUtility.AppendRandomDropRewardGoodsToList(configDataCooperateBattleLevelInfo.DropID, list);
					foreach (Goods goods in list)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x003B0B3C File Offset: 0x003AED3C
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
			this.InitCooperateBattleUIController();
		}

		// Token: 0x0600D973 RID: 55667 RVA: 0x003B0BA8 File Offset: 0x003AEDA8
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
			this.UninitCooperateBattleUIController();
		}

		// Token: 0x0600D974 RID: 55668 RVA: 0x003B0C14 File Offset: 0x003AEE14
		private void InitCooperateBattleUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCooperateBattleUIController_hotfix != null)
			{
				this.m_InitCooperateBattleUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cooperateBattleUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_cooperateBattleUIController = (this.m_uiCtrlArray[0] as CooperateBattleUIController);
				}
				if (!(this.m_cooperateBattleUIController != null))
				{
					Debug.LogError("CooperateBattleUIController is null");
					return;
				}
				this.m_cooperateBattleUIController.EventOnReturn += this.CooperateBattleUIController_OnReturn;
				this.m_cooperateBattleUIController.EventOnShowHelp += this.CooperateBattleUIController_OnShowHelp;
				this.m_cooperateBattleUIController.EventOnAddTicket += this.CooperateBattleUIController_OnAddTicket;
				this.m_cooperateBattleUIController.EventOnShowTeam += this.CooperateBattleUIController_OnShowTeam;
				this.m_cooperateBattleUIController.EventOnStartCooperateBattleLevel += this.CooperateBattleUIController_OnStartCooperateBattleLevel;
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

		// Token: 0x0600D975 RID: 55669 RVA: 0x003B0D90 File Offset: 0x003AEF90
		private void UninitCooperateBattleUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitCooperateBattleUIController_hotfix != null)
			{
				this.m_UninitCooperateBattleUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cooperateBattleUIController != null)
			{
				this.m_cooperateBattleUIController.EventOnReturn -= this.CooperateBattleUIController_OnReturn;
				this.m_cooperateBattleUIController.EventOnShowHelp -= this.CooperateBattleUIController_OnShowHelp;
				this.m_cooperateBattleUIController.EventOnAddTicket -= this.CooperateBattleUIController_OnAddTicket;
				this.m_cooperateBattleUIController.EventOnShowTeam -= this.CooperateBattleUIController_OnShowTeam;
				this.m_cooperateBattleUIController.EventOnStartCooperateBattleLevel -= this.CooperateBattleUIController_OnStartCooperateBattleLevel;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x0600D976 RID: 55670 RVA: 0x003B0E8C File Offset: 0x003AF08C
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
				this.m_cooperateBattleUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerResourceUIController.UpdatePlayerResource();
			if (this.m_cooperateBattleInfo != null)
			{
				this.m_cooperateBattleUIController.SetCooperateBattle(this.m_cooperateBattleInfo);
				this.m_cooperateBattleUIController.ClearCooperateBattleLevelListItems();
				this.m_cooperateBattleUIController.AddAllCooperateBattleLevelListItems(this.m_cooperateBattleInfo.m_levelInfos);
				this.m_cooperateBattleUIController.SetDailyRewardCount(projectLPlayerContext.GetCooperateBattleDailyChallengeNums(this.m_cooperateBattleInfo.ID), projectLPlayerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_CooperateBattle));
			}
		}

		// Token: 0x0600D977 RID: 55671 RVA: 0x003B0F80 File Offset: 0x003AF180
		private void CooperateBattleUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleUIController_OnReturn_hotfix != null)
			{
				this.m_CooperateBattleUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x0600D978 RID: 55672 RVA: 0x003B1004 File Offset: 0x003AF204
		private void CooperateBattleUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleUIController_OnShowHelp_hotfix != null)
			{
				this.m_CooperateBattleUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_CooperateBattle);
		}

		// Token: 0x0600D979 RID: 55673 RVA: 0x003B1070 File Offset: 0x003AF270
		private void CooperateBattleUIController_OnAddTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleUIController_OnAddTicket_hotfix != null)
			{
				this.m_CooperateBattleUIController_OnAddTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600D97A RID: 55674 RVA: 0x003B10D0 File Offset: 0x003AF2D0
		private void CooperateBattleUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleUIController_OnShowTeam_hotfix != null)
			{
				this.m_CooperateBattleUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cooperateBattleInfo == null)
			{
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_CooperateBattle, this.m_cooperateBattleInfo.ID, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600D97B RID: 55675 RVA: 0x003B1160 File Offset: 0x003AF360
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

		// Token: 0x0600D97C RID: 55676 RVA: 0x003B11EC File Offset: 0x003AF3EC
		private void CooperateBattleUIController_OnStartCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CooperateBattleUIController_OnStartCooperateBattleLevelConfigDataCooperateBattleLevelInfo_hotfix != null)
			{
				this.m_CooperateBattleUIController_OnStartCooperateBattleLevelConfigDataCooperateBattleLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cooperateBattleInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackCooperateBattleLevel(levelInfo.ID);
			if (num == 0)
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_CooperateBattle, this.m_cooperateBattleInfo.ID, levelInfo.ID);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x17002A43 RID: 10819
		// (get) Token: 0x0600D97D RID: 55677 RVA: 0x003B12D8 File Offset: 0x003AF4D8
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

		// Token: 0x17002A44 RID: 10820
		// (get) Token: 0x0600D97E RID: 55678 RVA: 0x003B134C File Offset: 0x003AF54C
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

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0600D97F RID: 55679 RVA: 0x003B13C0 File Offset: 0x003AF5C0
		// (set) Token: 0x0600D980 RID: 55680 RVA: 0x003B13E0 File Offset: 0x003AF5E0
		[DoNotToLua]
		public new CooperateBattleUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CooperateBattleUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D981 RID: 55681 RVA: 0x003B13EC File Offset: 0x003AF5EC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600D982 RID: 55682 RVA: 0x003B13F8 File Offset: 0x003AF5F8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x003B1400 File Offset: 0x003AF600
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600D984 RID: 55684 RVA: 0x003B1408 File Offset: 0x003AF608
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600D985 RID: 55685 RVA: 0x003B1414 File Offset: 0x003AF614
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x003B1420 File Offset: 0x003AF620
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600D987 RID: 55687 RVA: 0x003B142C File Offset: 0x003AF62C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600D988 RID: 55688 RVA: 0x003B1434 File Offset: 0x003AF634
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600D989 RID: 55689 RVA: 0x003B143C File Offset: 0x003AF63C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600D98A RID: 55690 RVA: 0x003B1444 File Offset: 0x003AF644
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600D98B RID: 55691 RVA: 0x003B144C File Offset: 0x003AF64C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600D98C RID: 55692 RVA: 0x003B1454 File Offset: 0x003AF654
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600D98D RID: 55693 RVA: 0x003B145C File Offset: 0x003AF65C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600D98E RID: 55694 RVA: 0x003B1464 File Offset: 0x003AF664
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600D98F RID: 55695 RVA: 0x003B1470 File Offset: 0x003AF670
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x003B147C File Offset: 0x003AF67C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x003B1488 File Offset: 0x003AF688
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x003B1494 File Offset: 0x003AF694
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600D993 RID: 55699 RVA: 0x003B149C File Offset: 0x003AF69C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600D994 RID: 55700 RVA: 0x003B14A4 File Offset: 0x003AF6A4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600D995 RID: 55701 RVA: 0x003B14AC File Offset: 0x003AF6AC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600D996 RID: 55702 RVA: 0x003B14B4 File Offset: 0x003AF6B4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600D997 RID: 55703 RVA: 0x003B14BC File Offset: 0x003AF6BC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600D99A RID: 55706 RVA: 0x003B1524 File Offset: 0x003AF724
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
					this.m_InitCooperateBattleUIController_hotfix = (luaObj.RawGet("InitCooperateBattleUIController") as LuaFunction);
					this.m_UninitCooperateBattleUIController_hotfix = (luaObj.RawGet("UninitCooperateBattleUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_CooperateBattleUIController_OnReturn_hotfix = (luaObj.RawGet("CooperateBattleUIController_OnReturn") as LuaFunction);
					this.m_CooperateBattleUIController_OnShowHelp_hotfix = (luaObj.RawGet("CooperateBattleUIController_OnShowHelp") as LuaFunction);
					this.m_CooperateBattleUIController_OnAddTicket_hotfix = (luaObj.RawGet("CooperateBattleUIController_OnAddTicket") as LuaFunction);
					this.m_CooperateBattleUIController_OnShowTeam_hotfix = (luaObj.RawGet("CooperateBattleUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_CooperateBattleUIController_OnStartCooperateBattleLevelConfigDataCooperateBattleLevelInfo_hotfix = (luaObj.RawGet("CooperateBattleUIController_OnStartCooperateBattleLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D99B RID: 55707 RVA: 0x003B1798 File Offset: 0x003AF998
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CooperateBattleUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400854E RID: 34126
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "CooperateBattleUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/CooperateBattle_ABS/Prefab/CooperateBattleUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400854F RID: 34127
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "CooperateBattleUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.CooperateBattleUIController"),
				m_ctrlName = "CooperateBattleUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "CooperateBattleUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "CooperateBattlePlayerResourceUIController"
			}
		};

		// Token: 0x04008550 RID: 34128
		private CooperateBattleUIController m_cooperateBattleUIController;

		// Token: 0x04008551 RID: 34129
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04008552 RID: 34130
		private ConfigDataCooperateBattleInfo m_cooperateBattleInfo;

		// Token: 0x04008553 RID: 34131
		[DoNotToLua]
		private CooperateBattleUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008554 RID: 34132
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008555 RID: 34133
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008556 RID: 34134
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008557 RID: 34135
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008558 RID: 34136
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04008559 RID: 34137
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400855A RID: 34138
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400855B RID: 34139
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400855C RID: 34140
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400855D RID: 34141
		private LuaFunction m_InitCooperateBattleUIController_hotfix;

		// Token: 0x0400855E RID: 34142
		private LuaFunction m_UninitCooperateBattleUIController_hotfix;

		// Token: 0x0400855F RID: 34143
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008560 RID: 34144
		private LuaFunction m_CooperateBattleUIController_OnReturn_hotfix;

		// Token: 0x04008561 RID: 34145
		private LuaFunction m_CooperateBattleUIController_OnShowHelp_hotfix;

		// Token: 0x04008562 RID: 34146
		private LuaFunction m_CooperateBattleUIController_OnAddTicket_hotfix;

		// Token: 0x04008563 RID: 34147
		private LuaFunction m_CooperateBattleUIController_OnShowTeam_hotfix;

		// Token: 0x04008564 RID: 34148
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04008565 RID: 34149
		private LuaFunction m_CooperateBattleUIController_OnStartCooperateBattleLevelConfigDataCooperateBattleLevelInfo_hotfix;

		// Token: 0x04008566 RID: 34150
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008567 RID: 34151
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000C16 RID: 3094
		public new class LuaExportHelper
		{
			// Token: 0x0600D99C RID: 55708 RVA: 0x003B1800 File Offset: 0x003AFA00
			public LuaExportHelper(CooperateBattleUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D99D RID: 55709 RVA: 0x003B1810 File Offset: 0x003AFA10
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600D99E RID: 55710 RVA: 0x003B1820 File Offset: 0x003AFA20
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600D99F RID: 55711 RVA: 0x003B1830 File Offset: 0x003AFA30
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600D9A0 RID: 55712 RVA: 0x003B1840 File Offset: 0x003AFA40
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600D9A1 RID: 55713 RVA: 0x003B1850 File Offset: 0x003AFA50
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600D9A2 RID: 55714 RVA: 0x003B1860 File Offset: 0x003AFA60
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600D9A3 RID: 55715 RVA: 0x003B1870 File Offset: 0x003AFA70
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D9A4 RID: 55716 RVA: 0x003B1880 File Offset: 0x003AFA80
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600D9A5 RID: 55717 RVA: 0x003B1890 File Offset: 0x003AFA90
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600D9A6 RID: 55718 RVA: 0x003B18A0 File Offset: 0x003AFAA0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600D9A7 RID: 55719 RVA: 0x003B18B0 File Offset: 0x003AFAB0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600D9A8 RID: 55720 RVA: 0x003B18C0 File Offset: 0x003AFAC0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600D9A9 RID: 55721 RVA: 0x003B18D0 File Offset: 0x003AFAD0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600D9AA RID: 55722 RVA: 0x003B18E0 File Offset: 0x003AFAE0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600D9AB RID: 55723 RVA: 0x003B18F0 File Offset: 0x003AFAF0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600D9AC RID: 55724 RVA: 0x003B1900 File Offset: 0x003AFB00
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600D9AD RID: 55725 RVA: 0x003B1910 File Offset: 0x003AFB10
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600D9AE RID: 55726 RVA: 0x003B1920 File Offset: 0x003AFB20
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600D9AF RID: 55727 RVA: 0x003B1930 File Offset: 0x003AFB30
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600D9B0 RID: 55728 RVA: 0x003B1940 File Offset: 0x003AFB40
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600D9B1 RID: 55729 RVA: 0x003B1950 File Offset: 0x003AFB50
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600D9B2 RID: 55730 RVA: 0x003B1960 File Offset: 0x003AFB60
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600D9B3 RID: 55731 RVA: 0x003B1970 File Offset: 0x003AFB70
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002A46 RID: 10822
			// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x003B1980 File Offset: 0x003AFB80
			// (set) Token: 0x0600D9B5 RID: 55733 RVA: 0x003B1990 File Offset: 0x003AFB90
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

			// Token: 0x17002A47 RID: 10823
			// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x003B19A0 File Offset: 0x003AFBA0
			// (set) Token: 0x0600D9B7 RID: 55735 RVA: 0x003B19B0 File Offset: 0x003AFBB0
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

			// Token: 0x17002A48 RID: 10824
			// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x003B19C0 File Offset: 0x003AFBC0
			// (set) Token: 0x0600D9B9 RID: 55737 RVA: 0x003B19D0 File Offset: 0x003AFBD0
			public CooperateBattleUIController m_cooperateBattleUIController
			{
				get
				{
					return this.m_owner.m_cooperateBattleUIController;
				}
				set
				{
					this.m_owner.m_cooperateBattleUIController = value;
				}
			}

			// Token: 0x17002A49 RID: 10825
			// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x003B19E0 File Offset: 0x003AFBE0
			// (set) Token: 0x0600D9BB RID: 55739 RVA: 0x003B19F0 File Offset: 0x003AFBF0
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

			// Token: 0x17002A4A RID: 10826
			// (get) Token: 0x0600D9BC RID: 55740 RVA: 0x003B1A00 File Offset: 0x003AFC00
			// (set) Token: 0x0600D9BD RID: 55741 RVA: 0x003B1A10 File Offset: 0x003AFC10
			public ConfigDataCooperateBattleInfo m_cooperateBattleInfo
			{
				get
				{
					return this.m_owner.m_cooperateBattleInfo;
				}
				set
				{
					this.m_owner.m_cooperateBattleInfo = value;
				}
			}

			// Token: 0x17002A4B RID: 10827
			// (get) Token: 0x0600D9BE RID: 55742 RVA: 0x003B1A20 File Offset: 0x003AFC20
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002A4C RID: 10828
			// (get) Token: 0x0600D9BF RID: 55743 RVA: 0x003B1A30 File Offset: 0x003AFC30
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600D9C0 RID: 55744 RVA: 0x003B1A40 File Offset: 0x003AFC40
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600D9C1 RID: 55745 RVA: 0x003B1A50 File Offset: 0x003AFC50
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600D9C2 RID: 55746 RVA: 0x003B1A60 File Offset: 0x003AFC60
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600D9C3 RID: 55747 RVA: 0x003B1A70 File Offset: 0x003AFC70
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600D9C4 RID: 55748 RVA: 0x003B1A80 File Offset: 0x003AFC80
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600D9C5 RID: 55749 RVA: 0x003B1A90 File Offset: 0x003AFC90
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600D9C6 RID: 55750 RVA: 0x003B1AA0 File Offset: 0x003AFCA0
			public void InitCooperateBattleUIController()
			{
				this.m_owner.InitCooperateBattleUIController();
			}

			// Token: 0x0600D9C7 RID: 55751 RVA: 0x003B1AB0 File Offset: 0x003AFCB0
			public void UninitCooperateBattleUIController()
			{
				this.m_owner.UninitCooperateBattleUIController();
			}

			// Token: 0x0600D9C8 RID: 55752 RVA: 0x003B1AC0 File Offset: 0x003AFCC0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600D9C9 RID: 55753 RVA: 0x003B1AD0 File Offset: 0x003AFCD0
			public void CooperateBattleUIController_OnReturn()
			{
				this.m_owner.CooperateBattleUIController_OnReturn();
			}

			// Token: 0x0600D9CA RID: 55754 RVA: 0x003B1AE0 File Offset: 0x003AFCE0
			public void CooperateBattleUIController_OnShowHelp()
			{
				this.m_owner.CooperateBattleUIController_OnShowHelp();
			}

			// Token: 0x0600D9CB RID: 55755 RVA: 0x003B1AF0 File Offset: 0x003AFCF0
			public void CooperateBattleUIController_OnAddTicket()
			{
				this.m_owner.CooperateBattleUIController_OnAddTicket();
			}

			// Token: 0x0600D9CC RID: 55756 RVA: 0x003B1B00 File Offset: 0x003AFD00
			public void CooperateBattleUIController_OnShowTeam()
			{
				this.m_owner.CooperateBattleUIController_OnShowTeam();
			}

			// Token: 0x0600D9CD RID: 55757 RVA: 0x003B1B10 File Offset: 0x003AFD10
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600D9CE RID: 55758 RVA: 0x003B1B20 File Offset: 0x003AFD20
			public void CooperateBattleUIController_OnStartCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo levelInfo)
			{
				this.m_owner.CooperateBattleUIController_OnStartCooperateBattleLevel(levelInfo);
			}

			// Token: 0x04008568 RID: 34152
			private CooperateBattleUITask m_owner;
		}
	}
}
