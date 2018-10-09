using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FFB RID: 4091
	[HotFix]
	public class UnchartedScoreUITask : UITask
	{
		// Token: 0x0601491A RID: 84250 RVA: 0x00537978 File Offset: 0x00535B78
		public UnchartedScoreUITask(string name) : base(name)
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

		// Token: 0x0601491B RID: 84251 RVA: 0x00537AA4 File Offset: 0x00535CA4
		protected override void Finalize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Finalize_hotfix != null)
			{
				this.m_Finalize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0601491C RID: 84252 RVA: 0x00537B20 File Offset: 0x00535D20
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

		// Token: 0x0601491D RID: 84253 RVA: 0x00537BAC File Offset: 0x00535DAC
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

		// Token: 0x0601491E RID: 84254 RVA: 0x00537C38 File Offset: 0x00535E38
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
			this.m_unchartedScoreInfo = null;
			this.m_battleType = BattleType.UnchartedScore_ScoreLevel;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_unchartedScoreInfo = uiintentCustom.GetClassParam<ConfigDataUnchartedScoreInfo>("UnchartedScoreInfo");
				this.m_battleType = uiintentCustom.GetStructParam<BattleType>("BattleType");
			}
			if (this.m_unchartedScoreInfo != null && !projectLPlayerContext.IsUnchartedScoreOpened(this.m_unchartedScoreInfo.ID))
			{
				this.m_unchartedScoreInfo = null;
			}
			this.m_unchartedScoreModelInfo = null;
			if (this.m_unchartedScoreInfo != null)
			{
				if (this.m_unchartedScoreInfo.ModelIdList.Count > 0)
				{
					int index = UnityEngine.Random.Range(0, this.m_unchartedScoreInfo.ModelIdList.Count);
					int key = this.m_unchartedScoreInfo.ModelIdList[index];
					this.m_unchartedScoreModelInfo = configDataLoader.GetConfigDataUnchartedScoreModelInfo(key);
				}
			}
			else
			{
				foreach (KeyValuePair<int, ConfigDataUnchartedScoreInfo> keyValuePair in configDataLoader.GetAllConfigDataUnchartedScoreInfo())
				{
					if (projectLPlayerContext.IsUnchartedScoreOpened(keyValuePair.Key))
					{
						this.m_unchartedScoreInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x0601491F RID: 84255 RVA: 0x00537E04 File Offset: 0x00536004
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
			if (this.m_unchartedScoreInfo != null)
			{
				if (this.m_unchartedScoreModelInfo != null)
				{
					base.CollectAsset(this.m_unchartedScoreModelInfo.Model);
				}
				List<Goods> list = new List<Goods>();
				foreach (ConfigDataScoreLevelInfo configDataScoreLevelInfo in this.m_unchartedScoreInfo.Id2ScoreLevelInfos.Values)
				{
					list.Clear();
					UIUtility.AppendRandomDropRewardGoodsToList(configDataScoreLevelInfo.DropID, list);
					foreach (Goods goods in list)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
				foreach (ConfigDataChallengeLevelInfo configDataChallengeLevelInfo in this.m_unchartedScoreInfo.Id2ChallengeLevelInfos.Values)
				{
					foreach (Goods goods2 in configDataChallengeLevelInfo.CommonRewardList)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
					}
				}
				foreach (KeyValuePair<int, ConfigDataUnchartedScoreRewardGroupInfo> keyValuePair in configDataLoader.GetAllConfigDataUnchartedScoreRewardGroupInfo())
				{
					ConfigDataUnchartedScoreRewardGroupInfo value = keyValuePair.Value;
					if (value.GroupId == this.m_unchartedScoreInfo.UnchartedScoreRewardGroupId)
					{
						foreach (Goods goods3 in value.RewardList)
						{
							base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods3.GoodsType, goods3.Id));
						}
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014920 RID: 84256 RVA: 0x005380F4 File Offset: 0x005362F4
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
			this.InitUnchartedScoreUIController();
		}

		// Token: 0x06014921 RID: 84257 RVA: 0x00538160 File Offset: 0x00536360
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
			this.UninitUnchartedScoreUIController();
		}

		// Token: 0x06014922 RID: 84258 RVA: 0x005381CC File Offset: 0x005363CC
		private void InitUnchartedScoreUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitUnchartedScoreUIController_hotfix != null)
			{
				this.m_InitUnchartedScoreUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_unchartedScoreUIController = (this.m_uiCtrlArray[0] as UnchartedScoreUIController);
				}
				if (!(this.m_unchartedScoreUIController != null))
				{
					global::Debug.LogError("UnchartedScoreUIController is null");
					return;
				}
				this.m_unchartedScoreUIController.EventOnReturn += this.UnchartedScoreUIController_OnReturn;
				this.m_unchartedScoreUIController.EventOnShowHelp += this.UnchartedScoreUIController_OnShowHelp;
				this.m_unchartedScoreUIController.EventOnShowTeam += this.UnchartedScoreUIController_OnShowTeam;
				this.m_unchartedScoreUIController.EventOnChangeBattleType += this.UnchartedScoreUIController_EventOnChangeBattleType;
				this.m_unchartedScoreUIController.EventOnStartUnchartedScoreLevel += this.UnchartedScoreUIController_OnStartUnchartedScoreLevel;
				this.m_unchartedScoreUIController.EventOnStartUnchartedChallengeLevel += this.UnchartedScoreUIController_OnStartUnchartedChallengeLevel;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					global::Debug.LogError("PlayerResourceUIController is null");
					return;
				}
			}
		}

		// Token: 0x06014923 RID: 84259 RVA: 0x0053835C File Offset: 0x0053655C
		private void UninitUnchartedScoreUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitUnchartedScoreUIController_hotfix != null)
			{
				this.m_UninitUnchartedScoreUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreUIController != null)
			{
				this.m_unchartedScoreUIController.EventOnReturn -= this.UnchartedScoreUIController_OnReturn;
				this.m_unchartedScoreUIController.EventOnShowHelp -= this.UnchartedScoreUIController_OnShowHelp;
				this.m_unchartedScoreUIController.EventOnShowTeam -= this.UnchartedScoreUIController_OnShowTeam;
				this.m_unchartedScoreUIController.EventOnChangeBattleType -= this.UnchartedScoreUIController_EventOnChangeBattleType;
				this.m_unchartedScoreUIController.EventOnStartUnchartedScoreLevel -= this.UnchartedScoreUIController_OnStartUnchartedScoreLevel;
				this.m_unchartedScoreUIController.EventOnStartUnchartedChallengeLevel -= this.UnchartedScoreUIController_OnStartUnchartedChallengeLevel;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06014924 RID: 84260 RVA: 0x00538470 File Offset: 0x00536670
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
				this.m_unchartedScoreUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerResourceUIController.UpdatePlayerResource();
			if (this.m_unchartedScoreInfo != null)
			{
				this.m_unchartedScoreUIController.SetUnchartedScoreInfo(this.m_unchartedScoreInfo, this.m_unchartedScoreModelInfo);
				this.m_unchartedScoreUIController.SetScore(projectLPlayerContext.GetUnchartedScoreScore(this.m_unchartedScoreInfo.ID));
				this.m_unchartedScoreUIController.SetDailyRewardCount(projectLPlayerContext.GetUnchartedScoreDailyRewardRestCount(this.m_unchartedScoreInfo.ID), this.m_unchartedScoreInfo.ScoreLevelBonusCount);
				this.m_unchartedScoreUIController.SetBattleType(this.m_battleType);
				if (this.m_battleType == BattleType.UnchartedScore_ScoreLevel)
				{
					this.m_unchartedScoreUIController.SetAllUnchartedScoreLevelListItems(this.m_unchartedScoreInfo.Id2ScoreLevelInfos.Values);
				}
				else if (this.m_battleType == BattleType.UnchartedScore_ChallengeLevel)
				{
					this.m_unchartedScoreUIController.SetAllUnchartedChallengeLevelListItems(this.m_unchartedScoreInfo.Id2ChallengeLevelInfos.Values);
				}
			}
		}

		// Token: 0x06014925 RID: 84261 RVA: 0x005385CC File Offset: 0x005367CC
		private void UnchartedScoreUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUIController_OnReturn_hotfix != null)
			{
				this.m_UnchartedScoreUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x06014926 RID: 84262 RVA: 0x00538650 File Offset: 0x00536850
		private void UnchartedScoreUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUIController_OnShowHelp_hotfix != null)
			{
				this.m_UnchartedScoreUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_UnchartedScore);
		}

		// Token: 0x06014927 RID: 84263 RVA: 0x005386BC File Offset: 0x005368BC
		private void UnchartedScoreUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUIController_OnShowTeam_hotfix != null)
			{
				this.m_UnchartedScoreUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreInfo == null)
			{
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel, this.m_unchartedScoreInfo.ID, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06014928 RID: 84264 RVA: 0x0053874C File Offset: 0x0053694C
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

		// Token: 0x06014929 RID: 84265 RVA: 0x005387D8 File Offset: 0x005369D8
		private void UnchartedScoreUIController_EventOnChangeBattleType(BattleType battleType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUIController_EventOnChangeBattleTypeBattleType_hotfix != null)
			{
				this.m_UnchartedScoreUIController_EventOnChangeBattleTypeBattleType_hotfix.call(new object[]
				{
					this,
					battleType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleType = battleType;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0601492A RID: 84266 RVA: 0x0053885C File Offset: 0x00536A5C
		private void UnchartedScoreUIController_OnStartUnchartedScoreLevel(ConfigDataScoreLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUIController_OnStartUnchartedScoreLevelConfigDataScoreLevelInfo_hotfix != null)
			{
				this.m_UnchartedScoreUIController_OnStartUnchartedScoreLevelConfigDataScoreLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackUnchartedScoreLevel(levelInfo.UnchartedScoreInfo.ID, levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.UnchartedScore_ScoreLevel, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x0601492B RID: 84267 RVA: 0x00538924 File Offset: 0x00536B24
		private void UnchartedScoreUIController_OnStartUnchartedChallengeLevel(ConfigDataChallengeLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreUIController_OnStartUnchartedChallengeLevelConfigDataChallengeLevelInfo_hotfix != null)
			{
				this.m_UnchartedScoreUIController_OnStartUnchartedChallengeLevelConfigDataChallengeLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackUnchartedChallengeLevel(levelInfo.UnchartedScoreInfo.ID, levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.UnchartedScore_ChallengeLevel, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0601492C RID: 84268 RVA: 0x005389EC File Offset: 0x00536BEC
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

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0601492D RID: 84269 RVA: 0x00538A60 File Offset: 0x00536C60
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

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0601492E RID: 84270 RVA: 0x00538AD4 File Offset: 0x00536CD4
		// (set) Token: 0x0601492F RID: 84271 RVA: 0x00538AF4 File Offset: 0x00536CF4
		[DoNotToLua]
		public new UnchartedScoreUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014930 RID: 84272 RVA: 0x00538B00 File Offset: 0x00536D00
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014931 RID: 84273 RVA: 0x00538B0C File Offset: 0x00536D0C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06014932 RID: 84274 RVA: 0x00538B14 File Offset: 0x00536D14
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014933 RID: 84275 RVA: 0x00538B1C File Offset: 0x00536D1C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014934 RID: 84276 RVA: 0x00538B28 File Offset: 0x00536D28
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014935 RID: 84277 RVA: 0x00538B34 File Offset: 0x00536D34
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014936 RID: 84278 RVA: 0x00538B40 File Offset: 0x00536D40
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014937 RID: 84279 RVA: 0x00538B48 File Offset: 0x00536D48
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014938 RID: 84280 RVA: 0x00538B50 File Offset: 0x00536D50
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014939 RID: 84281 RVA: 0x00538B58 File Offset: 0x00536D58
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601493A RID: 84282 RVA: 0x00538B60 File Offset: 0x00536D60
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601493B RID: 84283 RVA: 0x00538B68 File Offset: 0x00536D68
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601493C RID: 84284 RVA: 0x00538B70 File Offset: 0x00536D70
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601493D RID: 84285 RVA: 0x00538B78 File Offset: 0x00536D78
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601493E RID: 84286 RVA: 0x00538B84 File Offset: 0x00536D84
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0601493F RID: 84287 RVA: 0x00538B90 File Offset: 0x00536D90
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06014940 RID: 84288 RVA: 0x00538B9C File Offset: 0x00536D9C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06014941 RID: 84289 RVA: 0x00538BA8 File Offset: 0x00536DA8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06014942 RID: 84290 RVA: 0x00538BB0 File Offset: 0x00536DB0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014943 RID: 84291 RVA: 0x00538BB8 File Offset: 0x00536DB8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014944 RID: 84292 RVA: 0x00538BC0 File Offset: 0x00536DC0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014945 RID: 84293 RVA: 0x00538BC8 File Offset: 0x00536DC8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014946 RID: 84294 RVA: 0x00538BD0 File Offset: 0x00536DD0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014949 RID: 84297 RVA: 0x00538C38 File Offset: 0x00536E38
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_Finalize_hotfix = (luaObj.RawGet("Finalize") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitUnchartedScoreUIController_hotfix = (luaObj.RawGet("InitUnchartedScoreUIController") as LuaFunction);
					this.m_UninitUnchartedScoreUIController_hotfix = (luaObj.RawGet("UninitUnchartedScoreUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UnchartedScoreUIController_OnReturn_hotfix = (luaObj.RawGet("UnchartedScoreUIController_OnReturn") as LuaFunction);
					this.m_UnchartedScoreUIController_OnShowHelp_hotfix = (luaObj.RawGet("UnchartedScoreUIController_OnShowHelp") as LuaFunction);
					this.m_UnchartedScoreUIController_OnShowTeam_hotfix = (luaObj.RawGet("UnchartedScoreUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_UnchartedScoreUIController_EventOnChangeBattleTypeBattleType_hotfix = (luaObj.RawGet("UnchartedScoreUIController_EventOnChangeBattleType") as LuaFunction);
					this.m_UnchartedScoreUIController_OnStartUnchartedScoreLevelConfigDataScoreLevelInfo_hotfix = (luaObj.RawGet("UnchartedScoreUIController_OnStartUnchartedScoreLevel") as LuaFunction);
					this.m_UnchartedScoreUIController_OnStartUnchartedChallengeLevelConfigDataChallengeLevelInfo_hotfix = (luaObj.RawGet("UnchartedScoreUIController_OnStartUnchartedChallengeLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601494A RID: 84298 RVA: 0x00538EE0 File Offset: 0x005370E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B4C5 RID: 46277
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "UnchartedScoreUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/UnchartedScore_ABS/Prefab/UnchartedScoreUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B4C6 RID: 46278
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "UnchartedScoreUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.UnchartedScoreUIController"),
				m_ctrlName = "UnchartedScoreUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "UnchartedScoreUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "UnchartedScorePlayerResourceUIController"
			}
		};

		// Token: 0x0400B4C7 RID: 46279
		private UnchartedScoreUIController m_unchartedScoreUIController;

		// Token: 0x0400B4C8 RID: 46280
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400B4C9 RID: 46281
		private ConfigDataUnchartedScoreInfo m_unchartedScoreInfo;

		// Token: 0x0400B4CA RID: 46282
		private ConfigDataUnchartedScoreModelInfo m_unchartedScoreModelInfo;

		// Token: 0x0400B4CB RID: 46283
		private BattleType m_battleType;

		// Token: 0x0400B4CC RID: 46284
		[DoNotToLua]
		private UnchartedScoreUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B4CD RID: 46285
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B4CE RID: 46286
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B4CF RID: 46287
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B4D0 RID: 46288
		private LuaFunction m_Finalize_hotfix;

		// Token: 0x0400B4D1 RID: 46289
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B4D2 RID: 46290
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B4D3 RID: 46291
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400B4D4 RID: 46292
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B4D5 RID: 46293
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B4D6 RID: 46294
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B4D7 RID: 46295
		private LuaFunction m_InitUnchartedScoreUIController_hotfix;

		// Token: 0x0400B4D8 RID: 46296
		private LuaFunction m_UninitUnchartedScoreUIController_hotfix;

		// Token: 0x0400B4D9 RID: 46297
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B4DA RID: 46298
		private LuaFunction m_UnchartedScoreUIController_OnReturn_hotfix;

		// Token: 0x0400B4DB RID: 46299
		private LuaFunction m_UnchartedScoreUIController_OnShowHelp_hotfix;

		// Token: 0x0400B4DC RID: 46300
		private LuaFunction m_UnchartedScoreUIController_OnShowTeam_hotfix;

		// Token: 0x0400B4DD RID: 46301
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B4DE RID: 46302
		private LuaFunction m_UnchartedScoreUIController_EventOnChangeBattleTypeBattleType_hotfix;

		// Token: 0x0400B4DF RID: 46303
		private LuaFunction m_UnchartedScoreUIController_OnStartUnchartedScoreLevelConfigDataScoreLevelInfo_hotfix;

		// Token: 0x0400B4E0 RID: 46304
		private LuaFunction m_UnchartedScoreUIController_OnStartUnchartedChallengeLevelConfigDataChallengeLevelInfo_hotfix;

		// Token: 0x0400B4E1 RID: 46305
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B4E2 RID: 46306
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000FFC RID: 4092
		public new class LuaExportHelper
		{
			// Token: 0x0601494B RID: 84299 RVA: 0x00538F48 File Offset: 0x00537148
			public LuaExportHelper(UnchartedScoreUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601494C RID: 84300 RVA: 0x00538F58 File Offset: 0x00537158
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601494D RID: 84301 RVA: 0x00538F68 File Offset: 0x00537168
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601494E RID: 84302 RVA: 0x00538F78 File Offset: 0x00537178
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601494F RID: 84303 RVA: 0x00538F88 File Offset: 0x00537188
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014950 RID: 84304 RVA: 0x00538F98 File Offset: 0x00537198
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014951 RID: 84305 RVA: 0x00538FA8 File Offset: 0x005371A8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014952 RID: 84306 RVA: 0x00538FB8 File Offset: 0x005371B8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014953 RID: 84307 RVA: 0x00538FC8 File Offset: 0x005371C8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014954 RID: 84308 RVA: 0x00538FD8 File Offset: 0x005371D8
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014955 RID: 84309 RVA: 0x00538FE8 File Offset: 0x005371E8
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014956 RID: 84310 RVA: 0x00538FF8 File Offset: 0x005371F8
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014957 RID: 84311 RVA: 0x00539008 File Offset: 0x00537208
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014958 RID: 84312 RVA: 0x00539018 File Offset: 0x00537218
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014959 RID: 84313 RVA: 0x00539028 File Offset: 0x00537228
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601495A RID: 84314 RVA: 0x00539038 File Offset: 0x00537238
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601495B RID: 84315 RVA: 0x00539048 File Offset: 0x00537248
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0601495C RID: 84316 RVA: 0x00539058 File Offset: 0x00537258
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601495D RID: 84317 RVA: 0x00539068 File Offset: 0x00537268
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601495E RID: 84318 RVA: 0x00539078 File Offset: 0x00537278
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601495F RID: 84319 RVA: 0x00539088 File Offset: 0x00537288
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06014960 RID: 84320 RVA: 0x00539098 File Offset: 0x00537298
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06014961 RID: 84321 RVA: 0x005390A8 File Offset: 0x005372A8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06014962 RID: 84322 RVA: 0x005390B8 File Offset: 0x005372B8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003CEC RID: 15596
			// (get) Token: 0x06014963 RID: 84323 RVA: 0x005390C8 File Offset: 0x005372C8
			// (set) Token: 0x06014964 RID: 84324 RVA: 0x005390D8 File Offset: 0x005372D8
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

			// Token: 0x17003CED RID: 15597
			// (get) Token: 0x06014965 RID: 84325 RVA: 0x005390E8 File Offset: 0x005372E8
			// (set) Token: 0x06014966 RID: 84326 RVA: 0x005390F8 File Offset: 0x005372F8
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

			// Token: 0x17003CEE RID: 15598
			// (get) Token: 0x06014967 RID: 84327 RVA: 0x00539108 File Offset: 0x00537308
			// (set) Token: 0x06014968 RID: 84328 RVA: 0x00539118 File Offset: 0x00537318
			public UnchartedScoreUIController m_unchartedScoreUIController
			{
				get
				{
					return this.m_owner.m_unchartedScoreUIController;
				}
				set
				{
					this.m_owner.m_unchartedScoreUIController = value;
				}
			}

			// Token: 0x17003CEF RID: 15599
			// (get) Token: 0x06014969 RID: 84329 RVA: 0x00539128 File Offset: 0x00537328
			// (set) Token: 0x0601496A RID: 84330 RVA: 0x00539138 File Offset: 0x00537338
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

			// Token: 0x17003CF0 RID: 15600
			// (get) Token: 0x0601496B RID: 84331 RVA: 0x00539148 File Offset: 0x00537348
			// (set) Token: 0x0601496C RID: 84332 RVA: 0x00539158 File Offset: 0x00537358
			public ConfigDataUnchartedScoreInfo m_unchartedScoreInfo
			{
				get
				{
					return this.m_owner.m_unchartedScoreInfo;
				}
				set
				{
					this.m_owner.m_unchartedScoreInfo = value;
				}
			}

			// Token: 0x17003CF1 RID: 15601
			// (get) Token: 0x0601496D RID: 84333 RVA: 0x00539168 File Offset: 0x00537368
			// (set) Token: 0x0601496E RID: 84334 RVA: 0x00539178 File Offset: 0x00537378
			public ConfigDataUnchartedScoreModelInfo m_unchartedScoreModelInfo
			{
				get
				{
					return this.m_owner.m_unchartedScoreModelInfo;
				}
				set
				{
					this.m_owner.m_unchartedScoreModelInfo = value;
				}
			}

			// Token: 0x17003CF2 RID: 15602
			// (get) Token: 0x0601496F RID: 84335 RVA: 0x00539188 File Offset: 0x00537388
			// (set) Token: 0x06014970 RID: 84336 RVA: 0x00539198 File Offset: 0x00537398
			public BattleType m_battleType
			{
				get
				{
					return this.m_owner.m_battleType;
				}
				set
				{
					this.m_owner.m_battleType = value;
				}
			}

			// Token: 0x17003CF3 RID: 15603
			// (get) Token: 0x06014971 RID: 84337 RVA: 0x005391A8 File Offset: 0x005373A8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003CF4 RID: 15604
			// (get) Token: 0x06014972 RID: 84338 RVA: 0x005391B8 File Offset: 0x005373B8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06014973 RID: 84339 RVA: 0x005391C8 File Offset: 0x005373C8
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06014974 RID: 84340 RVA: 0x005391D8 File Offset: 0x005373D8
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06014975 RID: 84341 RVA: 0x005391E8 File Offset: 0x005373E8
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06014976 RID: 84342 RVA: 0x005391F8 File Offset: 0x005373F8
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06014977 RID: 84343 RVA: 0x00539208 File Offset: 0x00537408
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014978 RID: 84344 RVA: 0x00539218 File Offset: 0x00537418
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014979 RID: 84345 RVA: 0x00539228 File Offset: 0x00537428
			public void InitUnchartedScoreUIController()
			{
				this.m_owner.InitUnchartedScoreUIController();
			}

			// Token: 0x0601497A RID: 84346 RVA: 0x00539238 File Offset: 0x00537438
			public void UninitUnchartedScoreUIController()
			{
				this.m_owner.UninitUnchartedScoreUIController();
			}

			// Token: 0x0601497B RID: 84347 RVA: 0x00539248 File Offset: 0x00537448
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0601497C RID: 84348 RVA: 0x00539258 File Offset: 0x00537458
			public void UnchartedScoreUIController_OnReturn()
			{
				this.m_owner.UnchartedScoreUIController_OnReturn();
			}

			// Token: 0x0601497D RID: 84349 RVA: 0x00539268 File Offset: 0x00537468
			public void UnchartedScoreUIController_OnShowHelp()
			{
				this.m_owner.UnchartedScoreUIController_OnShowHelp();
			}

			// Token: 0x0601497E RID: 84350 RVA: 0x00539278 File Offset: 0x00537478
			public void UnchartedScoreUIController_OnShowTeam()
			{
				this.m_owner.UnchartedScoreUIController_OnShowTeam();
			}

			// Token: 0x0601497F RID: 84351 RVA: 0x00539288 File Offset: 0x00537488
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06014980 RID: 84352 RVA: 0x00539298 File Offset: 0x00537498
			public void UnchartedScoreUIController_EventOnChangeBattleType(BattleType battleType)
			{
				this.m_owner.UnchartedScoreUIController_EventOnChangeBattleType(battleType);
			}

			// Token: 0x06014981 RID: 84353 RVA: 0x005392A8 File Offset: 0x005374A8
			public void UnchartedScoreUIController_OnStartUnchartedScoreLevel(ConfigDataScoreLevelInfo levelInfo)
			{
				this.m_owner.UnchartedScoreUIController_OnStartUnchartedScoreLevel(levelInfo);
			}

			// Token: 0x06014982 RID: 84354 RVA: 0x005392B8 File Offset: 0x005374B8
			public void UnchartedScoreUIController_OnStartUnchartedChallengeLevel(ConfigDataChallengeLevelInfo levelInfo)
			{
				this.m_owner.UnchartedScoreUIController_OnStartUnchartedChallengeLevel(levelInfo);
			}

			// Token: 0x0400B4E3 RID: 46307
			private UnchartedScoreUITask m_owner;
		}
	}
}
