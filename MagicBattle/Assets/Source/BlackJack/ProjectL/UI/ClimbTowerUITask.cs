using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B99 RID: 2969
	[HotFix]
	public class ClimbTowerUITask : UITask
	{
		// Token: 0x0600CB0D RID: 51981 RVA: 0x0037F084 File Offset: 0x0037D284
		public ClimbTowerUITask(string name) : base(name)
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

		// Token: 0x0600CB0E RID: 51982 RVA: 0x0037F1F0 File Offset: 0x0037D3F0
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

		// Token: 0x0600CB0F RID: 51983 RVA: 0x0037F27C File Offset: 0x0037D47C
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

		// Token: 0x0600CB10 RID: 51984 RVA: 0x0037F308 File Offset: 0x0037D508
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
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x0037F378 File Offset: 0x0037D578
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int climbTowerMaxFloorId = projectLPlayerContext.GetClimbTowerMaxFloorId();
			int climbTowerFinishedFloorId = projectLPlayerContext.GetClimbTowerFinishedFloorId();
			int num = ClimbTowerUITask.ComputeBigFloorFromFloorId(climbTowerFinishedFloorId);
			if (climbTowerFinishedFloorId < climbTowerMaxFloorId)
			{
				this.CollectFloorAssets(num);
			}
			RewardPlayerStatus beforeRewardPlayerStatus = projectLPlayerContext.GetBeforeRewardPlayerStatus();
			if (beforeRewardPlayerStatus.ClimbTowerFinishedFloorId != 0)
			{
				int climbTowerFinishedFloorId2 = beforeRewardPlayerStatus.ClimbTowerFinishedFloorId;
				int num2 = ClimbTowerUITask.ComputeBigFloorFromFloorId(climbTowerFinishedFloorId2);
				if (num2 != num)
				{
					this.CollectFloorAssets(num2);
				}
			}
			foreach (KeyValuePair<int, ConfigDataTowerFloorInfo> keyValuePair in configDataLoader.GetAllConfigDataTowerFloorInfo())
			{
				if (keyValuePair.Key % 5 == 0)
				{
					ConfigDataTowerFloorInfo value = keyValuePair.Value;
					foreach (Goods goods in value.RewardList)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x0037F538 File Offset: 0x0037D738
		private void CollectFloorAssets(int fromFloorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectFloorAssetsInt32_hotfix != null)
			{
				this.m_CollectFloorAssetsInt32_hotfix.call(new object[]
				{
					this,
					fromFloorId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			for (int i = fromFloorId; i < fromFloorId + 5; i++)
			{
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = configDataLoader.GetConfigDataTowerFloorInfo(i);
				if (configDataTowerFloorInfo != null)
				{
					GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(i);
					if (climbTowerFloor != null)
					{
						ConfigDataTowerLevelInfo configDataTowerLevelInfo = configDataLoader.GetConfigDataTowerLevelInfo(climbTowerFloor.LevelId);
						if (configDataTowerLevelInfo != null)
						{
							base.CollectAsset(configDataTowerLevelInfo.LevelRes);
							foreach (Goods goods in configDataTowerFloorInfo.RewardList)
							{
								base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
							}
						}
					}
				}
			}
		}

		// Token: 0x0600CB13 RID: 51987 RVA: 0x0037F690 File Offset: 0x0037D890
		private static int ComputeBigFloorFromFloorId(int finishedFloorId)
		{
			return finishedFloorId / 5 * 5 + 1;
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x0037F69C File Offset: 0x0037D89C
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

		// Token: 0x0600CB15 RID: 51989 RVA: 0x0037F73C File Offset: 0x0037D93C
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
			this.InitClimbTowerUIController();
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x0037F7A8 File Offset: 0x0037D9A8
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
			this.UninitClimbTowerUIController();
		}

		// Token: 0x0600CB17 RID: 51991 RVA: 0x0037F814 File Offset: 0x0037DA14
		private void InitClimbTowerUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitClimbTowerUIController_hotfix != null)
			{
				this.m_InitClimbTowerUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_climbTowerUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_climbTowerUIController = (this.m_uiCtrlArray[0] as ClimbTowerUIController);
				}
				if (!(this.m_climbTowerUIController != null))
				{
					Debug.LogError("ClimbTowerUIController is null");
					return;
				}
				this.m_climbTowerUIController.EventOnReturn += this.ClimbTowerUIController_OnReturn;
				this.m_climbTowerUIController.EventOnShowHelp += this.ClimbTowerUIController_OnShowHelp;
				this.m_climbTowerUIController.EventOnShowLevelInfo += this.ClimbTowerUIController_OnShowLevelInfo;
				this.m_climbTowerUIController.EventOnShowRaid += this.ClimbTowerUIController_OnShowRaid;
				this.m_climbTowerUIController.EventOnConfirmRaid += this.ClimbTowerUIController_OnConfirmRaid;
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
				this.m_playerResourceUIController.EventOnAddGold += this.PlayerResourceUIController_OnAddGold;
				this.m_playerResourceUIController.EventOnAddCrystal += this.PlayerResourceUIController_OnAddCrystal;
			}
		}

		// Token: 0x0600CB18 RID: 51992 RVA: 0x0037F9BC File Offset: 0x0037DBBC
		private void UninitClimbTowerUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitClimbTowerUIController_hotfix != null)
			{
				this.m_UninitClimbTowerUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_climbTowerUIController != null)
			{
				this.m_climbTowerUIController.EventOnReturn -= this.ClimbTowerUIController_OnReturn;
				this.m_climbTowerUIController.EventOnShowHelp -= this.ClimbTowerUIController_OnShowHelp;
				this.m_climbTowerUIController.EventOnShowLevelInfo -= this.ClimbTowerUIController_OnShowLevelInfo;
				this.m_climbTowerUIController.EventOnShowRaid -= this.ClimbTowerUIController_OnShowRaid;
				this.m_climbTowerUIController.EventOnConfirmRaid -= this.ClimbTowerUIController_OnConfirmRaid;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController.EventOnAddGold -= this.PlayerResourceUIController_OnAddGold;
				this.m_playerResourceUIController.EventOnAddCrystal -= this.PlayerResourceUIController_OnAddCrystal;
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x0037FAE8 File Offset: 0x0037DCE8
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
			if (this.m_climbTowerUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateClimbTowerFlushTime();
			}
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x0037FB88 File Offset: 0x0037DD88
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
				this.m_climbTowerUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.UpdateClimbTowerFlushTime();
			int maxFloorId = projectLPlayerContext.GetClimbTowerMaxFloorId();
			int finishedFloorId = projectLPlayerContext.GetClimbTowerFinishedFloorId();
			int fromFloorId = ClimbTowerUITask.ComputeBigFloorFromFloorId(finishedFloorId);
			int finishedFloorId2 = finishedFloorId;
			int num = fromFloorId;
			RewardPlayerStatus beforeRewardPlayerStatus = projectLPlayerContext.GetBeforeRewardPlayerStatus();
			if (beforeRewardPlayerStatus.ClimbTowerFinishedFloorId != 0)
			{
				finishedFloorId2 = beforeRewardPlayerStatus.ClimbTowerFinishedFloorId;
				num = ClimbTowerUITask.ComputeBigFloorFromFloorId(finishedFloorId2);
				beforeRewardPlayerStatus.ClimbTowerFinishedFloorId = 0;
			}
			if (fromFloorId != num)
			{
				this.m_climbTowerUIController.SetClearAllFloors(false);
				this.UpdateFloors(num, finishedFloorId2);
				this.m_climbTowerUIController.ShowClearEffectBegin(this.m_isRaidClear, delegate
				{
					if (finishedFloorId >= maxFloorId)
					{
						this.m_climbTowerUIController.SetClearAllFloors(true);
					}
					else
					{
						this.m_climbTowerUIController.SetClearAllFloors(false);
						this.UpdateFloors(fromFloorId, finishedFloorId);
					}
					this.m_climbTowerUIController.ShowClearEffectEnd();
				});
				this.m_isRaidClear = false;
			}
			else if (finishedFloorId >= maxFloorId)
			{
				this.m_climbTowerUIController.SetClearAllFloors(true);
			}
			else
			{
				this.m_climbTowerUIController.SetClearAllFloors(false);
				this.UpdateFloors(fromFloorId, finishedFloorId);
			}
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x0037FD18 File Offset: 0x0037DF18
		private void UpdateFloors(int fromFloorId, int finishedFloorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFloorsInt32Int32_hotfix != null)
			{
				this.m_UpdateFloorsInt32Int32_hotfix.call(new object[]
				{
					this,
					fromFloorId,
					finishedFloorId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int climbTowerMaxFloorId = projectLPlayerContext.GetClimbTowerMaxFloorId();
			this.m_climbTowerUIController.SetProgress((float)finishedFloorId / (float)climbTowerMaxFloorId);
			int num = finishedFloorId + 1;
			int num2 = 0;
			for (int i = fromFloorId; i < fromFloorId + 5; i++)
			{
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = configDataLoader.GetConfigDataTowerFloorInfo(i);
				if (configDataTowerFloorInfo != null)
				{
					GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(i);
					if (climbTowerFloor != null)
					{
						ConfigDataTowerLevelInfo configDataTowerLevelInfo = configDataLoader.GetConfigDataTowerLevelInfo(climbTowerFloor.LevelId);
						if (configDataTowerLevelInfo != null)
						{
							if (i == num)
							{
								this.m_climbTowerUIController.SetCurrentTowerFloor(configDataTowerFloorInfo);
							}
							bool isCleared;
							bool isLocked;
							if (finishedFloorId >= climbTowerMaxFloorId)
							{
								isCleared = true;
								isLocked = false;
							}
							else
							{
								isCleared = (i < num);
								isLocked = (i > num);
							}
							this.m_climbTowerUIController.SetTowerFloor(num2, configDataTowerFloorInfo, configDataTowerLevelInfo, isCleared, isLocked);
							num2++;
						}
					}
				}
			}
			int climbTowerHistoryMaxFloorId = projectLPlayerContext.GetClimbTowerHistoryMaxFloorId();
			int climbTowerRaidMaxFloorId = projectLPlayerContext.GetClimbTowerRaidMaxFloorId();
			this.m_climbTowerUIController.ShowRaidButton(climbTowerHistoryMaxFloorId >= configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_CanAutoClimbTowerHistoryFloorMax));
			ConfigDataTowerFloorInfo configDataTowerFloorInfo2 = configDataLoader.GetConfigDataTowerFloorInfo(climbTowerHistoryMaxFloorId);
			ConfigDataTowerFloorInfo configDataTowerFloorInfo3 = configDataLoader.GetConfigDataTowerFloorInfo(climbTowerRaidMaxFloorId);
			this.m_climbTowerUIController.SetRaidTowerFloor(configDataTowerFloorInfo2, configDataTowerFloorInfo3, climbTowerRaidMaxFloorId >= num);
		}

		// Token: 0x0600CB1C RID: 51996 RVA: 0x0037FEE0 File Offset: 0x0037E0E0
		private void UpdateClimbTowerFlushTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateClimbTowerFlushTime_hotfix != null)
			{
				this.m_UpdateClimbTowerFlushTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan nextFlushTime = projectLPlayerContext.GetClimbTowerNextFlushTime() - projectLPlayerContext.GetServerTime();
			if (nextFlushTime.Ticks <= 0L)
			{
				nextFlushTime = TimeSpan.Zero;
			}
			this.m_climbTowerUIController.SetNextFlushTime(nextFlushTime);
			DateTime now = DateTime.Now;
			if (now >= this.m_nextCheckClimbTowerFlushTime)
			{
				if (nextFlushTime.Ticks <= 0L)
				{
					this.FlushClimbTower();
				}
				else
				{
					this.m_nextCheckClimbTowerFlushTime = now.AddSeconds(5.0);
				}
			}
		}

		// Token: 0x0600CB1D RID: 51997 RVA: 0x0037FFC8 File Offset: 0x0037E1C8
		private void StartClimbTowerLevelInfoUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClimbTowerLevelInfoUITask_hotfix != null)
			{
				this.m_StartClimbTowerLevelInfoUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.GetClimbTowerFinishedFloorId() + 1;
			ConfigDataTowerFloorInfo configDataTowerFloorInfo = configDataLoader.GetConfigDataTowerFloorInfo(num);
			if (configDataTowerFloorInfo == null)
			{
				return;
			}
			GlobalClimbTowerFloor climbTowerFloor = projectLPlayerContext.GetClimbTowerFloor(num);
			if (climbTowerFloor == null)
			{
				return;
			}
			ConfigDataTowerLevelInfo configDataTowerLevelInfo = configDataLoader.GetConfigDataTowerLevelInfo(climbTowerFloor.LevelId);
			if (configDataTowerLevelInfo == null)
			{
				return;
			}
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = configDataLoader.GetConfigDataTowerBattleRuleInfo(climbTowerFloor.RuleId);
			ConfigDataTowerBonusHeroGroupInfo configDataTowerBonusHeroGroupInfo = configDataLoader.GetConfigDataTowerBonusHeroGroupInfo(climbTowerFloor.BonusHeroGroupId);
			this.m_armyRandomNumber.SetSeed(climbTowerFloor.ArmyRandomSeed);
			int randomTalentSkillId = BattleUtility.GetRandomTalentSkillId(configDataLoader, this.m_armyRandomNumber, configDataTowerLevelInfo.BattleInfo.EnemyRandomTalent_ID);
			ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(randomTalentSkillId);
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(ClimbTowerLevelInfoUITask).Name, null);
			uiintentCustom.SetParam("TowerFloorInfo", configDataTowerFloorInfo);
			uiintentCustom.SetParam("TowerLevelInfo", configDataTowerLevelInfo);
			uiintentCustom.SetParam("TowerBattleRuleInfo", configDataTowerBattleRuleInfo);
			uiintentCustom.SetParam("TowerBonusHeroGroupInfo", configDataTowerBonusHeroGroupInfo);
			uiintentCustom.SetParam("TowerMonsterSkillInfo", configDataSkillInfo);
			ClimbTowerLevelInfoUITask climbTowerLevelInfoUITask = UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as ClimbTowerLevelInfoUITask;
			if (this.m_climbTowerLevelInfoUITask == null)
			{
				this.m_climbTowerLevelInfoUITask = climbTowerLevelInfoUITask;
				this.m_climbTowerLevelInfoUITask.EventOnClose += this.ClimbTowerLevelInfoUITask_OnClose;
			}
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x00380178 File Offset: 0x0037E378
		private void StartClimbTowerRaidUITask(BattleReward battleReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartClimbTowerRaidUITaskBattleReward_hotfix != null)
			{
				this.m_StartClimbTowerRaidUITaskBattleReward_hotfix.call(new object[]
				{
					this,
					battleReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(ClimbTowerRaidUITask).Name, null);
			uiintentReturnable.SetParam("BattleReward", battleReward);
			ClimbTowerRaidUITask climbTowerRaidUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, null) as ClimbTowerRaidUITask;
			if (this.m_climbTowerRaidUITask == null)
			{
				this.m_climbTowerRaidUITask = climbTowerRaidUITask;
				this.m_climbTowerRaidUITask.EventOnClose += this.ClimbTowerRaidUITask_OnClose;
			}
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x00380250 File Offset: 0x0037E450
		private void ClimbTowerUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerUIController_OnReturn_hotfix != null)
			{
				this.m_ClimbTowerUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x0600CB20 RID: 52000 RVA: 0x003802D4 File Offset: 0x0037E4D4
		private void ClimbTowerUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerUIController_OnShowHelp_hotfix != null)
			{
				this.m_ClimbTowerUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_ClimbTower);
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x00380340 File Offset: 0x0037E540
		private void ClimbTowerUIController_OnShowLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerUIController_OnShowLevelInfo_hotfix != null)
			{
				this.m_ClimbTowerUIController_OnShowLevelInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartClimbTowerLevelInfoUITask();
		}

		// Token: 0x0600CB22 RID: 52002 RVA: 0x003803A8 File Offset: 0x0037E5A8
		private void ClimbTowerUIController_OnShowRaid()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerUIController_OnShowRaid_hotfix != null)
			{
				this.m_ClimbTowerUIController_OnShowRaid_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int key;
			int costEnergy;
			int num = projectLPlayerContext.ClimbTowerTryRaid(out key, out costEnergy);
			if (num == 0)
			{
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = configDataLoader.GetConfigDataTowerFloorInfo(key);
				this.m_climbTowerUIController.ShowRaidPanel(projectLPlayerContext.GetEnergy(), costEnergy, configDataTowerFloorInfo);
			}
			else if (num == -5403)
			{
				this.FlushClimbTower();
			}
			else if (num != 0)
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
				return;
			}
		}

		// Token: 0x0600CB23 RID: 52003 RVA: 0x0038048C File Offset: 0x0037E68C
		private void ClimbTowerUIController_OnConfirmRaid()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerUIController_OnConfirmRaid_hotfix != null)
			{
				this.m_ClimbTowerUIController_OnConfirmRaid_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerRaidNetTask climbTowerRaidNetTask = new ClimbTowerRaidNetTask();
			climbTowerRaidNetTask.EventOnStop += delegate(Task task)
			{
				ClimbTowerRaidNetTask climbTowerRaidNetTask2 = task as ClimbTowerRaidNetTask;
				if (climbTowerRaidNetTask2.Result == 0)
				{
					this.StartClimbTowerRaidUITask(climbTowerRaidNetTask2.Reward);
				}
				else if (climbTowerRaidNetTask2.Result == -5403)
				{
					this.FlushClimbTower();
				}
				else
				{
					WorldUITask.HandleAttackFailResult(climbTowerRaidNetTask2.Result, this.m_currIntent);
				}
			};
			climbTowerRaidNetTask.Start(null);
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x0038050C File Offset: 0x0037E70C
		private void FlushClimbTower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushClimbTower_hotfix != null)
			{
				this.m_FlushClimbTower_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ClimbTower_Flush, 2f, null, true);
			this.m_nextCheckClimbTowerFlushTime = DateTime.MaxValue;
			ClimbTowerGetNetTask climbTowerGetNetTask = new ClimbTowerGetNetTask();
			climbTowerGetNetTask.EventOnStop += delegate(Task task)
			{
				ClimbTowerGetNetTask climbTowerGetNetTask2 = task as ClimbTowerGetNetTask;
				if (climbTowerGetNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(climbTowerGetNetTask2.Result, 2f, null, true);
				}
				this.m_nextCheckClimbTowerFlushTime = DateTime.Now.AddSeconds(5.0);
			};
			climbTowerGetNetTask.Start(null);
		}

		// Token: 0x0600CB25 RID: 52005 RVA: 0x003805B0 File Offset: 0x0037E7B0
		private void PlayerResourceUIController_OnAddGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerResourceUIController_OnAddGold_hotfix != null)
			{
				this.m_PlayerResourceUIController_OnAddGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x0600CB26 RID: 52006 RVA: 0x00380628 File Offset: 0x0037E828
		private void PlayerResourceUIController_OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerResourceUIController_OnAddCrystal_hotfix != null)
			{
				this.m_PlayerResourceUIController_OnAddCrystal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
		}

		// Token: 0x0600CB27 RID: 52007 RVA: 0x003806A0 File Offset: 0x0037E8A0
		private void ClimbTowerLevelInfoUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerLevelInfoUITask_OnClose_hotfix != null)
			{
				this.m_ClimbTowerLevelInfoUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_climbTowerLevelInfoUITask != null)
			{
				this.m_climbTowerLevelInfoUITask.EventOnClose -= this.ClimbTowerLevelInfoUITask_OnClose;
				this.m_climbTowerLevelInfoUITask = null;
			}
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x00380734 File Offset: 0x0037E934
		private void ClimbTowerRaidUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClimbTowerRaidUITask_OnClose_hotfix != null)
			{
				this.m_ClimbTowerRaidUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_climbTowerRaidUITask != null)
			{
				this.m_climbTowerRaidUITask.EventOnClose -= this.ClimbTowerRaidUITask_OnClose;
				this.m_climbTowerRaidUITask = null;
			}
			this.m_isRaidClear = true;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x003807D0 File Offset: 0x0037E9D0
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

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600CB2A RID: 52010 RVA: 0x00380844 File Offset: 0x0037EA44
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

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x003808B8 File Offset: 0x0037EAB8
		// (set) Token: 0x0600CB2C RID: 52012 RVA: 0x003808D8 File Offset: 0x0037EAD8
		[DoNotToLua]
		public new ClimbTowerUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x003808E4 File Offset: 0x0037EAE4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x003808F0 File Offset: 0x0037EAF0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x003808F8 File Offset: 0x0037EAF8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x00380900 File Offset: 0x0037EB00
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x0038090C File Offset: 0x0037EB0C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x00380918 File Offset: 0x0037EB18
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x00380924 File Offset: 0x0037EB24
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x0038092C File Offset: 0x0037EB2C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x00380934 File Offset: 0x0037EB34
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x0038093C File Offset: 0x0037EB3C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x00380944 File Offset: 0x0037EB44
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x0038094C File Offset: 0x0037EB4C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x00380954 File Offset: 0x0037EB54
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x0038095C File Offset: 0x0037EB5C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x00380968 File Offset: 0x0037EB68
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600CB3C RID: 52028 RVA: 0x00380974 File Offset: 0x0037EB74
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x00380980 File Offset: 0x0037EB80
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x0038098C File Offset: 0x0037EB8C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x00380994 File Offset: 0x0037EB94
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x0038099C File Offset: 0x0037EB9C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x003809A4 File Offset: 0x0037EBA4
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x003809AC File Offset: 0x0037EBAC
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x003809B4 File Offset: 0x0037EBB4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600CB47 RID: 52039 RVA: 0x00380A98 File Offset: 0x0037EC98
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
					this.m_CollectFloorAssetsInt32_hotfix = (luaObj.RawGet("CollectFloorAssets") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitClimbTowerUIController_hotfix = (luaObj.RawGet("InitClimbTowerUIController") as LuaFunction);
					this.m_UninitClimbTowerUIController_hotfix = (luaObj.RawGet("UninitClimbTowerUIController") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateFloorsInt32Int32_hotfix = (luaObj.RawGet("UpdateFloors") as LuaFunction);
					this.m_UpdateClimbTowerFlushTime_hotfix = (luaObj.RawGet("UpdateClimbTowerFlushTime") as LuaFunction);
					this.m_StartClimbTowerLevelInfoUITask_hotfix = (luaObj.RawGet("StartClimbTowerLevelInfoUITask") as LuaFunction);
					this.m_StartClimbTowerRaidUITaskBattleReward_hotfix = (luaObj.RawGet("StartClimbTowerRaidUITask") as LuaFunction);
					this.m_ClimbTowerUIController_OnReturn_hotfix = (luaObj.RawGet("ClimbTowerUIController_OnReturn") as LuaFunction);
					this.m_ClimbTowerUIController_OnShowHelp_hotfix = (luaObj.RawGet("ClimbTowerUIController_OnShowHelp") as LuaFunction);
					this.m_ClimbTowerUIController_OnShowLevelInfo_hotfix = (luaObj.RawGet("ClimbTowerUIController_OnShowLevelInfo") as LuaFunction);
					this.m_ClimbTowerUIController_OnShowRaid_hotfix = (luaObj.RawGet("ClimbTowerUIController_OnShowRaid") as LuaFunction);
					this.m_ClimbTowerUIController_OnConfirmRaid_hotfix = (luaObj.RawGet("ClimbTowerUIController_OnConfirmRaid") as LuaFunction);
					this.m_FlushClimbTower_hotfix = (luaObj.RawGet("FlushClimbTower") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddGold_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddGold") as LuaFunction);
					this.m_PlayerResourceUIController_OnAddCrystal_hotfix = (luaObj.RawGet("PlayerResourceUIController_OnAddCrystal") as LuaFunction);
					this.m_ClimbTowerLevelInfoUITask_OnClose_hotfix = (luaObj.RawGet("ClimbTowerLevelInfoUITask_OnClose") as LuaFunction);
					this.m_ClimbTowerRaidUITask_OnClose_hotfix = (luaObj.RawGet("ClimbTowerRaidUITask_OnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x00380E20 File Offset: 0x0037F020
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007F9F RID: 32671
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ClimbTowerBackgroundUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/ClimbTower_ABS/Prefab/ClimbTowerBackgroundUIPrefab.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ClimbTowerUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/ClimbTower_ABS/Prefab/ClimbTowerUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007FA0 RID: 32672
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ClimbTowerUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ClimbTowerUIController"),
				m_ctrlName = "ClimbTowerUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ClimbTowerUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "ClimbTowerPlayerResourceUIController"
			}
		};

		// Token: 0x04007FA1 RID: 32673
		private ClimbTowerUIController m_climbTowerUIController;

		// Token: 0x04007FA2 RID: 32674
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04007FA3 RID: 32675
		private int m_nowSeconds;

		// Token: 0x04007FA4 RID: 32676
		private ClimbTowerLevelInfoUITask m_climbTowerLevelInfoUITask;

		// Token: 0x04007FA5 RID: 32677
		private ClimbTowerRaidUITask m_climbTowerRaidUITask;

		// Token: 0x04007FA6 RID: 32678
		private RandomNumber m_armyRandomNumber = new RandomNumber();

		// Token: 0x04007FA7 RID: 32679
		private DateTime m_nextCheckClimbTowerFlushTime = DateTime.MinValue;

		// Token: 0x04007FA8 RID: 32680
		private bool m_isRaidClear;

		// Token: 0x04007FA9 RID: 32681
		[DoNotToLua]
		private ClimbTowerUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007FAA RID: 32682
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007FAB RID: 32683
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007FAC RID: 32684
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007FAD RID: 32685
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007FAE RID: 32686
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04007FAF RID: 32687
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04007FB0 RID: 32688
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04007FB1 RID: 32689
		private LuaFunction m_CollectFloorAssetsInt32_hotfix;

		// Token: 0x04007FB2 RID: 32690
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x04007FB3 RID: 32691
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007FB4 RID: 32692
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007FB5 RID: 32693
		private LuaFunction m_InitClimbTowerUIController_hotfix;

		// Token: 0x04007FB6 RID: 32694
		private LuaFunction m_UninitClimbTowerUIController_hotfix;

		// Token: 0x04007FB7 RID: 32695
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04007FB8 RID: 32696
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007FB9 RID: 32697
		private LuaFunction m_UpdateFloorsInt32Int32_hotfix;

		// Token: 0x04007FBA RID: 32698
		private LuaFunction m_UpdateClimbTowerFlushTime_hotfix;

		// Token: 0x04007FBB RID: 32699
		private LuaFunction m_StartClimbTowerLevelInfoUITask_hotfix;

		// Token: 0x04007FBC RID: 32700
		private LuaFunction m_StartClimbTowerRaidUITaskBattleReward_hotfix;

		// Token: 0x04007FBD RID: 32701
		private LuaFunction m_ClimbTowerUIController_OnReturn_hotfix;

		// Token: 0x04007FBE RID: 32702
		private LuaFunction m_ClimbTowerUIController_OnShowHelp_hotfix;

		// Token: 0x04007FBF RID: 32703
		private LuaFunction m_ClimbTowerUIController_OnShowLevelInfo_hotfix;

		// Token: 0x04007FC0 RID: 32704
		private LuaFunction m_ClimbTowerUIController_OnShowRaid_hotfix;

		// Token: 0x04007FC1 RID: 32705
		private LuaFunction m_ClimbTowerUIController_OnConfirmRaid_hotfix;

		// Token: 0x04007FC2 RID: 32706
		private LuaFunction m_FlushClimbTower_hotfix;

		// Token: 0x04007FC3 RID: 32707
		private LuaFunction m_PlayerResourceUIController_OnAddGold_hotfix;

		// Token: 0x04007FC4 RID: 32708
		private LuaFunction m_PlayerResourceUIController_OnAddCrystal_hotfix;

		// Token: 0x04007FC5 RID: 32709
		private LuaFunction m_ClimbTowerLevelInfoUITask_OnClose_hotfix;

		// Token: 0x04007FC6 RID: 32710
		private LuaFunction m_ClimbTowerRaidUITask_OnClose_hotfix;

		// Token: 0x04007FC7 RID: 32711
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007FC8 RID: 32712
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B9A RID: 2970
		public new class LuaExportHelper
		{
			// Token: 0x0600CB49 RID: 52041 RVA: 0x00380E88 File Offset: 0x0037F088
			public LuaExportHelper(ClimbTowerUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CB4A RID: 52042 RVA: 0x00380E98 File Offset: 0x0037F098
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600CB4B RID: 52043 RVA: 0x00380EA8 File Offset: 0x0037F0A8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600CB4C RID: 52044 RVA: 0x00380EB8 File Offset: 0x0037F0B8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600CB4D RID: 52045 RVA: 0x00380EC8 File Offset: 0x0037F0C8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600CB4E RID: 52046 RVA: 0x00380ED8 File Offset: 0x0037F0D8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600CB4F RID: 52047 RVA: 0x00380EE8 File Offset: 0x0037F0E8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600CB50 RID: 52048 RVA: 0x00380EF8 File Offset: 0x0037F0F8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CB51 RID: 52049 RVA: 0x00380F08 File Offset: 0x0037F108
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600CB52 RID: 52050 RVA: 0x00380F18 File Offset: 0x0037F118
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600CB53 RID: 52051 RVA: 0x00380F28 File Offset: 0x0037F128
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600CB54 RID: 52052 RVA: 0x00380F38 File Offset: 0x0037F138
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600CB55 RID: 52053 RVA: 0x00380F48 File Offset: 0x0037F148
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600CB56 RID: 52054 RVA: 0x00380F58 File Offset: 0x0037F158
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600CB57 RID: 52055 RVA: 0x00380F68 File Offset: 0x0037F168
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600CB58 RID: 52056 RVA: 0x00380F78 File Offset: 0x0037F178
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600CB59 RID: 52057 RVA: 0x00380F88 File Offset: 0x0037F188
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600CB5A RID: 52058 RVA: 0x00380F98 File Offset: 0x0037F198
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600CB5B RID: 52059 RVA: 0x00380FA8 File Offset: 0x0037F1A8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600CB5C RID: 52060 RVA: 0x00380FB8 File Offset: 0x0037F1B8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600CB5D RID: 52061 RVA: 0x00380FC8 File Offset: 0x0037F1C8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600CB5E RID: 52062 RVA: 0x00380FD8 File Offset: 0x0037F1D8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600CB5F RID: 52063 RVA: 0x00380FE8 File Offset: 0x0037F1E8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600CB60 RID: 52064 RVA: 0x00380FF8 File Offset: 0x0037F1F8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002844 RID: 10308
			// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00381008 File Offset: 0x0037F208
			// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x00381018 File Offset: 0x0037F218
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

			// Token: 0x17002845 RID: 10309
			// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00381028 File Offset: 0x0037F228
			// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x00381038 File Offset: 0x0037F238
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

			// Token: 0x17002846 RID: 10310
			// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00381048 File Offset: 0x0037F248
			// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x00381058 File Offset: 0x0037F258
			public ClimbTowerUIController m_climbTowerUIController
			{
				get
				{
					return this.m_owner.m_climbTowerUIController;
				}
				set
				{
					this.m_owner.m_climbTowerUIController = value;
				}
			}

			// Token: 0x17002847 RID: 10311
			// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00381068 File Offset: 0x0037F268
			// (set) Token: 0x0600CB68 RID: 52072 RVA: 0x00381078 File Offset: 0x0037F278
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

			// Token: 0x17002848 RID: 10312
			// (get) Token: 0x0600CB69 RID: 52073 RVA: 0x00381088 File Offset: 0x0037F288
			// (set) Token: 0x0600CB6A RID: 52074 RVA: 0x00381098 File Offset: 0x0037F298
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

			// Token: 0x17002849 RID: 10313
			// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x003810A8 File Offset: 0x0037F2A8
			// (set) Token: 0x0600CB6C RID: 52076 RVA: 0x003810B8 File Offset: 0x0037F2B8
			public ClimbTowerLevelInfoUITask m_climbTowerLevelInfoUITask
			{
				get
				{
					return this.m_owner.m_climbTowerLevelInfoUITask;
				}
				set
				{
					this.m_owner.m_climbTowerLevelInfoUITask = value;
				}
			}

			// Token: 0x1700284A RID: 10314
			// (get) Token: 0x0600CB6D RID: 52077 RVA: 0x003810C8 File Offset: 0x0037F2C8
			// (set) Token: 0x0600CB6E RID: 52078 RVA: 0x003810D8 File Offset: 0x0037F2D8
			public ClimbTowerRaidUITask m_climbTowerRaidUITask
			{
				get
				{
					return this.m_owner.m_climbTowerRaidUITask;
				}
				set
				{
					this.m_owner.m_climbTowerRaidUITask = value;
				}
			}

			// Token: 0x1700284B RID: 10315
			// (get) Token: 0x0600CB6F RID: 52079 RVA: 0x003810E8 File Offset: 0x0037F2E8
			// (set) Token: 0x0600CB70 RID: 52080 RVA: 0x003810F8 File Offset: 0x0037F2F8
			public RandomNumber m_armyRandomNumber
			{
				get
				{
					return this.m_owner.m_armyRandomNumber;
				}
				set
				{
					this.m_owner.m_armyRandomNumber = value;
				}
			}

			// Token: 0x1700284C RID: 10316
			// (get) Token: 0x0600CB71 RID: 52081 RVA: 0x00381108 File Offset: 0x0037F308
			// (set) Token: 0x0600CB72 RID: 52082 RVA: 0x00381118 File Offset: 0x0037F318
			public DateTime m_nextCheckClimbTowerFlushTime
			{
				get
				{
					return this.m_owner.m_nextCheckClimbTowerFlushTime;
				}
				set
				{
					this.m_owner.m_nextCheckClimbTowerFlushTime = value;
				}
			}

			// Token: 0x1700284D RID: 10317
			// (get) Token: 0x0600CB73 RID: 52083 RVA: 0x00381128 File Offset: 0x0037F328
			// (set) Token: 0x0600CB74 RID: 52084 RVA: 0x00381138 File Offset: 0x0037F338
			public bool m_isRaidClear
			{
				get
				{
					return this.m_owner.m_isRaidClear;
				}
				set
				{
					this.m_owner.m_isRaidClear = value;
				}
			}

			// Token: 0x1700284E RID: 10318
			// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x00381148 File Offset: 0x0037F348
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x1700284F RID: 10319
			// (get) Token: 0x0600CB76 RID: 52086 RVA: 0x00381158 File Offset: 0x0037F358
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600CB77 RID: 52087 RVA: 0x00381168 File Offset: 0x0037F368
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600CB78 RID: 52088 RVA: 0x00381178 File Offset: 0x0037F378
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600CB79 RID: 52089 RVA: 0x00381188 File Offset: 0x0037F388
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600CB7A RID: 52090 RVA: 0x00381198 File Offset: 0x0037F398
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CB7B RID: 52091 RVA: 0x003811A8 File Offset: 0x0037F3A8
			public void CollectFloorAssets(int fromFloorId)
			{
				this.m_owner.CollectFloorAssets(fromFloorId);
			}

			// Token: 0x0600CB7C RID: 52092 RVA: 0x003811B8 File Offset: 0x0037F3B8
			public static int ComputeBigFloorFromFloorId(int finishedFloorId)
			{
				return ClimbTowerUITask.ComputeBigFloorFromFloorId(finishedFloorId);
			}

			// Token: 0x0600CB7D RID: 52093 RVA: 0x003811C0 File Offset: 0x0037F3C0
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600CB7E RID: 52094 RVA: 0x003811D0 File Offset: 0x0037F3D0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600CB7F RID: 52095 RVA: 0x003811E0 File Offset: 0x0037F3E0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600CB80 RID: 52096 RVA: 0x003811F0 File Offset: 0x0037F3F0
			public void InitClimbTowerUIController()
			{
				this.m_owner.InitClimbTowerUIController();
			}

			// Token: 0x0600CB81 RID: 52097 RVA: 0x00381200 File Offset: 0x0037F400
			public void UninitClimbTowerUIController()
			{
				this.m_owner.UninitClimbTowerUIController();
			}

			// Token: 0x0600CB82 RID: 52098 RVA: 0x00381210 File Offset: 0x0037F410
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600CB83 RID: 52099 RVA: 0x00381220 File Offset: 0x0037F420
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600CB84 RID: 52100 RVA: 0x00381230 File Offset: 0x0037F430
			public void UpdateFloors(int fromFloorId, int finishedFloorId)
			{
				this.m_owner.UpdateFloors(fromFloorId, finishedFloorId);
			}

			// Token: 0x0600CB85 RID: 52101 RVA: 0x00381240 File Offset: 0x0037F440
			public void UpdateClimbTowerFlushTime()
			{
				this.m_owner.UpdateClimbTowerFlushTime();
			}

			// Token: 0x0600CB86 RID: 52102 RVA: 0x00381250 File Offset: 0x0037F450
			public void StartClimbTowerLevelInfoUITask()
			{
				this.m_owner.StartClimbTowerLevelInfoUITask();
			}

			// Token: 0x0600CB87 RID: 52103 RVA: 0x00381260 File Offset: 0x0037F460
			public void StartClimbTowerRaidUITask(BattleReward battleReward)
			{
				this.m_owner.StartClimbTowerRaidUITask(battleReward);
			}

			// Token: 0x0600CB88 RID: 52104 RVA: 0x00381270 File Offset: 0x0037F470
			public void ClimbTowerUIController_OnReturn()
			{
				this.m_owner.ClimbTowerUIController_OnReturn();
			}

			// Token: 0x0600CB89 RID: 52105 RVA: 0x00381280 File Offset: 0x0037F480
			public void ClimbTowerUIController_OnShowHelp()
			{
				this.m_owner.ClimbTowerUIController_OnShowHelp();
			}

			// Token: 0x0600CB8A RID: 52106 RVA: 0x00381290 File Offset: 0x0037F490
			public void ClimbTowerUIController_OnShowLevelInfo()
			{
				this.m_owner.ClimbTowerUIController_OnShowLevelInfo();
			}

			// Token: 0x0600CB8B RID: 52107 RVA: 0x003812A0 File Offset: 0x0037F4A0
			public void ClimbTowerUIController_OnShowRaid()
			{
				this.m_owner.ClimbTowerUIController_OnShowRaid();
			}

			// Token: 0x0600CB8C RID: 52108 RVA: 0x003812B0 File Offset: 0x0037F4B0
			public void ClimbTowerUIController_OnConfirmRaid()
			{
				this.m_owner.ClimbTowerUIController_OnConfirmRaid();
			}

			// Token: 0x0600CB8D RID: 52109 RVA: 0x003812C0 File Offset: 0x0037F4C0
			public void FlushClimbTower()
			{
				this.m_owner.FlushClimbTower();
			}

			// Token: 0x0600CB8E RID: 52110 RVA: 0x003812D0 File Offset: 0x0037F4D0
			public void PlayerResourceUIController_OnAddGold()
			{
				this.m_owner.PlayerResourceUIController_OnAddGold();
			}

			// Token: 0x0600CB8F RID: 52111 RVA: 0x003812E0 File Offset: 0x0037F4E0
			public void PlayerResourceUIController_OnAddCrystal()
			{
				this.m_owner.PlayerResourceUIController_OnAddCrystal();
			}

			// Token: 0x0600CB90 RID: 52112 RVA: 0x003812F0 File Offset: 0x0037F4F0
			public void ClimbTowerLevelInfoUITask_OnClose()
			{
				this.m_owner.ClimbTowerLevelInfoUITask_OnClose();
			}

			// Token: 0x0600CB91 RID: 52113 RVA: 0x00381300 File Offset: 0x0037F500
			public void ClimbTowerRaidUITask_OnClose()
			{
				this.m_owner.ClimbTowerRaidUITask_OnClose();
			}

			// Token: 0x04007FC9 RID: 32713
			private ClimbTowerUITask m_owner;
		}
	}
}
