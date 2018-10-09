using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EC6 RID: 3782
	[HotFix]
	public class BattleLevelInfoUITask : UITask
	{
		// Token: 0x0601285C RID: 75868 RVA: 0x004C00E8 File Offset: 0x004BE2E8
		public BattleLevelInfoUITask(string name) : base(name)
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

		// Token: 0x0601285D RID: 75869 RVA: 0x004C01E0 File Offset: 0x004BE3E0
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

		// Token: 0x0601285E RID: 75870 RVA: 0x004C026C File Offset: 0x004BE46C
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

		// Token: 0x0601285F RID: 75871 RVA: 0x004C02F8 File Offset: 0x004BE4F8
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
			this.m_riftLevelInfo = null;
			this.m_heroDungeonLevelInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_riftLevelInfo = uiintentCustom.GetClassParam<ConfigDataRiftLevelInfo>("RiftLevelInfo");
				this.m_heroDungeonLevelInfo = uiintentCustom.GetClassParam<ConfigDataHeroDungeonLevelInfo>("HeroDungeonLevelInfo");
				this.m_battleType = uiintentCustom.GetStructParam<BattleType>("BattleType");
				this.m_needGoods = uiintentCustom.GetClassParam<NeedGoods>("RaidNeedGoods");
			}
		}

		// Token: 0x06012860 RID: 75872 RVA: 0x004C03C8 File Offset: 0x004BE5C8
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
			List<Goods> list = new List<Goods>();
			if (this.m_riftLevelInfo != null)
			{
				base.CollectSpriteAsset(this.m_riftLevelInfo.Image);
				UIUtility.AppendRandomDropRewardGoodsToList(this.m_riftLevelInfo.Drop_ID, list);
				list.AddRange(this.m_riftLevelInfo.FirstReward);
				foreach (BattleLevelAchievement battleLevelAchievement in this.m_riftLevelInfo.m_achievements)
				{
					list.AddRange(battleLevelAchievement.m_rewards);
				}
			}
			if (this.m_heroDungeonLevelInfo != null)
			{
				base.CollectSpriteAsset(this.m_heroDungeonLevelInfo.Resource);
				UIUtility.AppendRandomDropRewardGoodsToList(this.m_heroDungeonLevelInfo.Drop_ID, list);
				list.AddRange(this.m_heroDungeonLevelInfo.FirstReward);
				foreach (BattleLevelAchievement battleLevelAchievement2 in this.m_heroDungeonLevelInfo.m_achievements)
				{
					list.AddRange(battleLevelAchievement2.m_rewards);
				}
			}
			foreach (Goods goods in list)
			{
				base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012861 RID: 75873 RVA: 0x004C058C File Offset: 0x004BE78C
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
			if (this.m_battleLevelInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_battleLevelInfoUIController = (this.m_uiCtrlArray[0] as BattleLevelInfoUIController);
				}
				if (!(this.m_battleLevelInfoUIController != null))
				{
					Debug.LogError("BattleLevelInfoUIController is null");
					return;
				}
				this.m_battleLevelInfoUIController.EventOnStartBattle += this.BattleLevelInfoUIController_OnStartBattle;
				this.m_battleLevelInfoUIController.EventOnRaidBattle += this.BattleLevelInfoUIController_OnRaidBattle;
				this.m_battleLevelInfoUIController.EventOnShowAchievement += this.BattleLevelInfoUIController_OnShowAchievement;
				this.m_battleLevelInfoUIController.EventOnClose += this.BattleLevelInfoUIController_OnClose;
			}
		}

		// Token: 0x06012862 RID: 75874 RVA: 0x004C06A4 File Offset: 0x004BE8A4
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
			if (this.m_battleLevelInfoUIController != null)
			{
				this.m_battleLevelInfoUIController.EventOnStartBattle -= this.BattleLevelInfoUIController_OnStartBattle;
				this.m_battleLevelInfoUIController.EventOnRaidBattle -= this.BattleLevelInfoUIController_OnRaidBattle;
				this.m_battleLevelInfoUIController.EventOnShowAchievement -= this.BattleLevelInfoUIController_OnShowAchievement;
				this.m_battleLevelInfoUIController.EventOnClose -= this.BattleLevelInfoUIController_OnClose;
				this.m_battleLevelInfoUIController = null;
			}
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x004C0780 File Offset: 0x004BE980
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
			if (this.m_riftLevelInfo != null && this.m_battleType == BattleType.Rift)
			{
				UIUtility.ActivateLayer(this.m_battleLevelInfoUIController, true);
				this.UpdateRiftLevelInfo(this.m_riftLevelInfo);
			}
			else if (this.m_heroDungeonLevelInfo != null && this.m_battleType == BattleType.HeroDungeon)
			{
				UIUtility.ActivateLayer(this.m_battleLevelInfoUIController, true);
				this.UpdateHeroDungeonLevelInfo(this.m_heroDungeonLevelInfo);
			}
		}

		// Token: 0x06012864 RID: 75876 RVA: 0x004C0844 File Offset: 0x004BEA44
		private void UpdateRiftLevelInfo(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRiftLevelInfoConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_UpdateRiftLevelInfoConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (levelInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int riftLevelStars = projectLPlayerContext.GetRiftLevelStars(levelInfo.ID);
			if (levelInfo.LevelType == RiftLevelType.RiftLevelType_Scenario)
			{
				this.m_battleLevelInfoUIController.SetRiftLevelShowByType(RiftLevelType.RiftLevelType_Scenario);
				this.m_battleLevelInfoUIController.SetRiftLevel(levelInfo);
				this.m_battleLevelInfoUIController.SetStars(riftLevelStars);
				this.m_battleLevelInfoUIController.SetCanChallengeCount(projectLPlayerContext.GetRiftLevelCanChallengeNums(levelInfo));
				this.m_battleLevelInfoUIController.SetAchievementCount(projectLPlayerContext.GetRiftLevelAchievementCount(levelInfo.ID), levelInfo.m_achievements.Length);
				this.m_battleLevelInfoUIController.SetRaidTicketCount(projectLPlayerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, configDataLoader.ConfigableConstId_LevelRaidTicketID));
				this.m_battleLevelInfoUIController.SetBattleTreasureCount(projectLPlayerContext.GetGainBattleTreasureCount(levelInfo.m_battleInfo), levelInfo.m_battleInfo.BattleTreasures_ID.Count);
				if (this.m_needOpenTween)
				{
					this.m_battleLevelInfoUIController.LevelInfoOpenTween();
					this.m_needOpenTween = false;
				}
			}
			else if (levelInfo.LevelType == RiftLevelType.RiftLevelType_Event)
			{
				this.m_battleLevelInfoUIController.SetRiftLevelShowByType(RiftLevelType.RiftLevelType_Event);
				this.m_battleLevelInfoUIController.SetRiftLevel(levelInfo);
				if (this.m_needOpenTween)
				{
					this.m_battleLevelInfoUIController.EventLevelInfoOpenTween();
					this.m_needOpenTween = false;
				}
			}
			List<Goods> list = new List<Goods>();
			bool firstWin;
			if (riftLevelStars <= 0)
			{
				firstWin = true;
				list.AddRange(levelInfo.FirstReward);
			}
			else
			{
				firstWin = false;
				UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.Drop_ID, list);
			}
			if (list.Count > levelInfo.DisplayRewardCount)
			{
				list.RemoveRange(levelInfo.DisplayRewardCount, list.Count - levelInfo.DisplayRewardCount);
			}
			this.m_battleLevelInfoUIController.SetReward(list, firstWin);
		}

		// Token: 0x06012865 RID: 75877 RVA: 0x004C0A58 File Offset: 0x004BEC58
		private void UpdateHeroDungeonLevelInfo(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroDungeonLevelInfoConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_UpdateHeroDungeonLevelInfoConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int heroDungeonLevelStars = projectLPlayerContext.GetHeroDungeonLevelStars(levelInfo);
			this.m_battleLevelInfoUIController.SetRiftLevelShowByType(RiftLevelType.RiftLevelType_Scenario);
			this.m_battleLevelInfoUIController.SetHeroDungeonLevel(levelInfo);
			this.m_battleLevelInfoUIController.SetStars(heroDungeonLevelStars);
			this.m_battleLevelInfoUIController.SetCanChallengeCount(projectLPlayerContext.GetHeroDungeonLevelCanChallengeNum(levelInfo));
			this.m_battleLevelInfoUIController.SetAchievementCount(projectLPlayerContext.GetHeroDungeonLevelAchievementCount(levelInfo), levelInfo.m_achievements.Length);
			this.m_battleLevelInfoUIController.SetRaidTicketCount(projectLPlayerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, configDataLoader.ConfigableConstId_LevelRaidTicketID));
			this.m_battleLevelInfoUIController.SetBattleTreasureCount(0, 0);
			if (this.m_needOpenTween)
			{
				this.m_battleLevelInfoUIController.LevelInfoOpenTween();
				this.m_needOpenTween = false;
			}
			List<Goods> list = new List<Goods>();
			bool firstWin;
			if (heroDungeonLevelStars <= 0)
			{
				firstWin = true;
				list.AddRange(levelInfo.FirstReward);
			}
			else
			{
				firstWin = false;
				UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.Drop_ID, list);
			}
			if (list.Count > levelInfo.DisplayRewardCount)
			{
				list.RemoveRange(levelInfo.DisplayRewardCount, list.Count - levelInfo.DisplayRewardCount);
			}
			this.m_battleLevelInfoUIController.SetReward(list, firstWin);
		}

		// Token: 0x06012866 RID: 75878 RVA: 0x004C0BF0 File Offset: 0x004BEDF0
		private void StartRiftRaidLevelUITask(int riftLevelID, BattleReward reward, List<Goods> extraReward, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRiftRaidLevelUITaskInt32BattleRewardList`1NeedGoods_hotfix != null)
			{
				this.m_StartRiftRaidLevelUITaskInt32BattleRewardList`1NeedGoods_hotfix.call(new object[]
				{
					this,
					riftLevelID,
					reward,
					extraReward,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (reward == null)
			{
				return;
			}
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(RaidLevelUITask).Name, null);
			uiintentReturnable.SetParam("BattleReward", reward);
			uiintentReturnable.SetParam("ExtraReward", extraReward);
			uiintentReturnable.SetParam("RiftLevelID", riftLevelID);
			uiintentReturnable.SetParam("BattleType", BattleType.Rift);
			if (needGoods != null)
			{
				uiintentReturnable.SetParam("RaidNeedGoods", needGoods);
			}
			RaidLevelUITask raidLevelUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.RaidUITask_OnLoadAllResCompleted)) as RaidLevelUITask;
			if (this.m_raidLevelUITask == null)
			{
				this.m_raidLevelUITask = raidLevelUITask;
				this.m_raidLevelUITask.EventOnClose += this.RaidLevelUITask_OnRiftRaidClose;
				this.m_raidLevelUITask.EventOnRiftRaidComplete += this.RaidLevelUITask_OnRiftRaidComplete;
			}
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x004C0D60 File Offset: 0x004BEF60
		private void StartHeroDungeonLevelRaidUITask(int heroDungeonLevelID, BattleReward reward, List<Goods> extraReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonLevelRaidUITaskInt32BattleRewardList`1_hotfix != null)
			{
				this.m_StartHeroDungeonLevelRaidUITaskInt32BattleRewardList`1_hotfix.call(new object[]
				{
					this,
					heroDungeonLevelID,
					reward,
					extraReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (reward == null)
			{
				return;
			}
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(RaidLevelUITask).Name, null);
			uiintentReturnable.SetParam("BattleReward", reward);
			uiintentReturnable.SetParam("ExtraReward", extraReward);
			uiintentReturnable.SetParam("HeroDungeonLevelID", heroDungeonLevelID);
			uiintentReturnable.SetParam("BattleType", BattleType.HeroDungeon);
			RaidLevelUITask raidLevelUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.RaidUITask_OnLoadAllResCompleted)) as RaidLevelUITask;
			if (this.m_raidLevelUITask == null)
			{
				this.m_raidLevelUITask = raidLevelUITask;
				this.m_raidLevelUITask.EventOnClose += this.RaidLevelUITask_OnHeroDungeonRaidClose;
				this.m_raidLevelUITask.EventOnHeroDungeonRaidComplete += this.RaidLevelUITask_OnHeroDungeonRaidComplete;
			}
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x004C0EAC File Offset: 0x004BF0AC
		private void RaidUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_RaidUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(RaidLevelUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06012869 RID: 75881 RVA: 0x004C0F30 File Offset: 0x004BF130
		private void StartRiftLevelRaidNetTask(int levelId, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRiftLevelRaidNetTaskInt32Int32_hotfix != null)
			{
				this.m_StartRiftLevelRaidNetTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					levelId2,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int levelId = levelId2;
			BattleLevelInfoUITask $this = this;
			RiftLevelRaidNetTask riftLevelRaidNetTask = new RiftLevelRaidNetTask(levelId, count);
			riftLevelRaidNetTask.EventOnStop += delegate(Task task)
			{
				RiftLevelRaidNetTask riftLevelRaidNetTask2 = task as RiftLevelRaidNetTask;
				if (riftLevelRaidNetTask2.Result == 0)
				{
					$this.StartRiftRaidLevelUITask(levelId, riftLevelRaidNetTask2.Reward, riftLevelRaidNetTask2.ExtraReward, $this.m_needGoods);
					if ($this.EventOnRiftRaidComplete != null)
					{
						$this.EventOnRiftRaidComplete(levelId);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(riftLevelRaidNetTask2.Result, 2f, null, true);
				}
			};
			riftLevelRaidNetTask.Start(null);
		}

		// Token: 0x0601286A RID: 75882 RVA: 0x004C0FEC File Offset: 0x004BF1EC
		private void StartHeroDungeonLevelRaidNetTask(int levelId, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix != null)
			{
				this.m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					levelId2,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int levelId = levelId2;
			BattleLevelInfoUITask $this = this;
			HeroDungeonLevelRaidNetTask heroDungeonLevelRaidNetTask = new HeroDungeonLevelRaidNetTask(levelId, count);
			heroDungeonLevelRaidNetTask.EventOnStop += delegate(Task task)
			{
				HeroDungeonLevelRaidNetTask heroDungeonLevelRaidNetTask2 = task as HeroDungeonLevelRaidNetTask;
				if (heroDungeonLevelRaidNetTask2.Result == 0)
				{
					$this.StartHeroDungeonLevelRaidUITask(levelId, heroDungeonLevelRaidNetTask2.Reward, heroDungeonLevelRaidNetTask2.ExtraReward);
					if ($this.EventOnHeroDungeonRaidComplete != null)
					{
						$this.EventOnHeroDungeonRaidComplete(levelId);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroDungeonLevelRaidNetTask2.Result, 2f, null, true);
				}
			};
			heroDungeonLevelRaidNetTask.Start(null);
		}

		// Token: 0x0601286B RID: 75883 RVA: 0x004C10A8 File Offset: 0x004BF2A8
		private void BattleLevelInfoUIController_OnStartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUIController_OnStartBattle_hotfix != null)
			{
				this.m_BattleLevelInfoUIController_OnStartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftLevelInfo != null && this.m_battleType == BattleType.Rift)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				int num = projectLPlayerContext.CanAttackRiftLevel(this.m_riftLevelInfo.ID);
				if (num == 0)
				{
					WorldUITask.StartBattleHappening(BattleType.Rift, this.m_riftLevelInfo.ID);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
				}
			}
			else if (this.m_heroDungeonLevelInfo != null && this.m_battleType == BattleType.HeroDungeon)
			{
				ProjectLPlayerContext projectLPlayerContext2 = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				int num2 = projectLPlayerContext2.CanAttackHeroDungeonLevel(this.m_heroDungeonLevelInfo.ID);
				if (num2 == 0)
				{
					WorldUITask.StartBattleHappening(BattleType.HeroDungeon, this.m_heroDungeonLevelInfo.ID);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(num2, this.m_currIntent);
				}
			}
		}

		// Token: 0x0601286C RID: 75884 RVA: 0x004C11D0 File Offset: 0x004BF3D0
		private void BattleLevelInfoUIController_OnRaidBattle(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUIController_OnRaidBattleInt32_hotfix != null)
			{
				this.m_BattleLevelInfoUIController_OnRaidBattleInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_riftLevelInfo != null && this.m_battleType == BattleType.Rift)
			{
				int num = projectLPlayerContext.CanRaidRiftLevel(this.m_riftLevelInfo.ID);
				if (num == 0)
				{
					this.StartRiftLevelRaidNetTask(this.m_riftLevelInfo.ID, count);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
				}
			}
			else if (this.m_heroDungeonLevelInfo != null && this.m_battleType == BattleType.HeroDungeon)
			{
				int num2 = projectLPlayerContext.CanRaidHeroDungeonLevel(this.m_heroDungeonLevelInfo.ID);
				if (num2 == 0)
				{
					this.StartHeroDungeonLevelRaidNetTask(this.m_heroDungeonLevelInfo.ID, count);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(num2, this.m_currIntent);
				}
			}
		}

		// Token: 0x0601286D RID: 75885 RVA: 0x004C12FC File Offset: 0x004BF4FC
		private void BattleLevelInfoUIController_OnShowAchievement()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUIController_OnShowAchievement_hotfix != null)
			{
				this.m_BattleLevelInfoUIController_OnShowAchievement_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_riftLevelInfo != null && this.m_battleType == BattleType.Rift)
			{
				if (this.m_riftLevelInfo.m_achievements != null && this.m_riftLevelInfo.m_achievements.Length > 0)
				{
					this.m_battleLevelInfoUIController.ShowAchievement(this.m_riftLevelInfo.m_achievements, BattleType.Rift);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_NoAchievement, 2f, null, true);
				}
			}
			else if (this.m_heroDungeonLevelInfo != null && this.m_battleType == BattleType.HeroDungeon)
			{
				if (this.m_heroDungeonLevelInfo.m_achievements != null && this.m_heroDungeonLevelInfo.m_achievements.Length > 0)
				{
					this.m_battleLevelInfoUIController.ShowAchievement(this.m_heroDungeonLevelInfo.m_achievements, BattleType.HeroDungeon);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_NoAchievement, 2f, null, true);
				}
			}
		}

		// Token: 0x0601286E RID: 75886 RVA: 0x004C143C File Offset: 0x004BF63C
		private void BattleLevelInfoUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleLevelInfoUIController_OnClose_hotfix != null)
			{
				this.m_BattleLevelInfoUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			this.m_needOpenTween = true;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x0601286F RID: 75887 RVA: 0x004C14C0 File Offset: 0x004BF6C0
		private void RaidLevelUITask_OnRiftRaidClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidLevelUITask_OnRiftRaidClose_hotfix != null)
			{
				this.m_RaidLevelUITask_OnRiftRaidClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_raidLevelUITask != null)
			{
				this.m_raidLevelUITask.EventOnClose -= this.RaidLevelUITask_OnRiftRaidClose;
				this.m_raidLevelUITask.EventOnRiftRaidComplete -= this.RaidLevelUITask_OnRiftRaidComplete;
				this.m_raidLevelUITask = null;
				this.BattleLevelInfoUIController_OnClose();
			}
		}

		// Token: 0x06012870 RID: 75888 RVA: 0x004C1568 File Offset: 0x004BF768
		private void RaidLevelUITask_OnHeroDungeonRaidClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidLevelUITask_OnHeroDungeonRaidClose_hotfix != null)
			{
				this.m_RaidLevelUITask_OnHeroDungeonRaidClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_raidLevelUITask != null)
			{
				this.m_raidLevelUITask.EventOnClose -= this.RaidLevelUITask_OnHeroDungeonRaidClose;
				this.m_raidLevelUITask.EventOnHeroDungeonRaidComplete -= this.RaidLevelUITask_OnHeroDungeonRaidComplete;
				this.m_raidLevelUITask = null;
				this.BattleLevelInfoUIController_OnClose();
			}
		}

		// Token: 0x06012871 RID: 75889 RVA: 0x004C1610 File Offset: 0x004BF810
		private void RaidLevelUITask_OnRiftRaidComplete(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidLevelUITask_OnRiftRaidCompleteInt32_hotfix != null)
			{
				this.m_RaidLevelUITask_OnRiftRaidCompleteInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRiftRaidComplete != null)
			{
				this.EventOnRiftRaidComplete(levelId);
			}
		}

		// Token: 0x06012872 RID: 75890 RVA: 0x004C1698 File Offset: 0x004BF898
		private void RaidLevelUITask_OnHeroDungeonRaidComplete(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidLevelUITask_OnHeroDungeonRaidCompleteInt32_hotfix != null)
			{
				this.m_RaidLevelUITask_OnHeroDungeonRaidCompleteInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnHeroDungeonRaidComplete != null)
			{
				this.EventOnHeroDungeonRaidComplete(levelId);
			}
		}

		// Token: 0x140003FA RID: 1018
		// (add) Token: 0x06012873 RID: 75891 RVA: 0x004C1720 File Offset: 0x004BF920
		// (remove) Token: 0x06012874 RID: 75892 RVA: 0x004C17BC File Offset: 0x004BF9BC
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003FB RID: 1019
		// (add) Token: 0x06012875 RID: 75893 RVA: 0x004C1858 File Offset: 0x004BFA58
		// (remove) Token: 0x06012876 RID: 75894 RVA: 0x004C18F4 File Offset: 0x004BFAF4
		public event Action<int> EventOnRiftRaidComplete
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRiftRaidCompleteAction`1_hotfix != null)
				{
					this.m_add_EventOnRiftRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRiftRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRiftRaidComplete, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRiftRaidCompleteAction`1_hotfix != null)
				{
					this.m_remove_EventOnRiftRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRiftRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRiftRaidComplete, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003FC RID: 1020
		// (add) Token: 0x06012877 RID: 75895 RVA: 0x004C1990 File Offset: 0x004BFB90
		// (remove) Token: 0x06012878 RID: 75896 RVA: 0x004C1A2C File Offset: 0x004BFC2C
		public event Action<int> EventOnHeroDungeonRaidComplete
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroDungeonRaidCompleteAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroDungeonRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroDungeonRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroDungeonRaidComplete, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroDungeonRaidCompleteAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroDungeonRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroDungeonRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroDungeonRaidComplete, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x06012879 RID: 75897 RVA: 0x004C1AC8 File Offset: 0x004BFCC8
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

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0601287A RID: 75898 RVA: 0x004C1B3C File Offset: 0x004BFD3C
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

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0601287B RID: 75899 RVA: 0x004C1BB0 File Offset: 0x004BFDB0
		// (set) Token: 0x0601287C RID: 75900 RVA: 0x004C1BD0 File Offset: 0x004BFDD0
		[DoNotToLua]
		public new BattleLevelInfoUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleLevelInfoUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601287D RID: 75901 RVA: 0x004C1BDC File Offset: 0x004BFDDC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0601287E RID: 75902 RVA: 0x004C1BE8 File Offset: 0x004BFDE8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601287F RID: 75903 RVA: 0x004C1BF0 File Offset: 0x004BFDF0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06012880 RID: 75904 RVA: 0x004C1BF8 File Offset: 0x004BFDF8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06012881 RID: 75905 RVA: 0x004C1C04 File Offset: 0x004BFE04
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06012882 RID: 75906 RVA: 0x004C1C10 File Offset: 0x004BFE10
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06012883 RID: 75907 RVA: 0x004C1C1C File Offset: 0x004BFE1C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012884 RID: 75908 RVA: 0x004C1C24 File Offset: 0x004BFE24
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06012885 RID: 75909 RVA: 0x004C1C2C File Offset: 0x004BFE2C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06012886 RID: 75910 RVA: 0x004C1C34 File Offset: 0x004BFE34
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06012887 RID: 75911 RVA: 0x004C1C3C File Offset: 0x004BFE3C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06012888 RID: 75912 RVA: 0x004C1C44 File Offset: 0x004BFE44
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06012889 RID: 75913 RVA: 0x004C1C4C File Offset: 0x004BFE4C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x004C1C54 File Offset: 0x004BFE54
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601288B RID: 75915 RVA: 0x004C1C60 File Offset: 0x004BFE60
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x004C1C6C File Offset: 0x004BFE6C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0601288D RID: 75917 RVA: 0x004C1C78 File Offset: 0x004BFE78
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0601288E RID: 75918 RVA: 0x004C1C84 File Offset: 0x004BFE84
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0601288F RID: 75919 RVA: 0x004C1C8C File Offset: 0x004BFE8C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06012890 RID: 75920 RVA: 0x004C1C94 File Offset: 0x004BFE94
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06012891 RID: 75921 RVA: 0x004C1C9C File Offset: 0x004BFE9C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06012892 RID: 75922 RVA: 0x004C1CA4 File Offset: 0x004BFEA4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06012893 RID: 75923 RVA: 0x004C1CAC File Offset: 0x004BFEAC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06012894 RID: 75924 RVA: 0x004C1CB4 File Offset: 0x004BFEB4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06012895 RID: 75925 RVA: 0x004C1CD4 File Offset: 0x004BFED4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06012896 RID: 75926 RVA: 0x004C1CE0 File Offset: 0x004BFEE0
		private void __callDele_EventOnRiftRaidComplete(int obj)
		{
			Action<int> eventOnRiftRaidComplete = this.EventOnRiftRaidComplete;
			if (eventOnRiftRaidComplete != null)
			{
				eventOnRiftRaidComplete(obj);
			}
		}

		// Token: 0x06012897 RID: 75927 RVA: 0x004C1D04 File Offset: 0x004BFF04
		private void __clearDele_EventOnRiftRaidComplete(int obj)
		{
			this.EventOnRiftRaidComplete = null;
		}

		// Token: 0x06012898 RID: 75928 RVA: 0x004C1D10 File Offset: 0x004BFF10
		private void __callDele_EventOnHeroDungeonRaidComplete(int obj)
		{
			Action<int> eventOnHeroDungeonRaidComplete = this.EventOnHeroDungeonRaidComplete;
			if (eventOnHeroDungeonRaidComplete != null)
			{
				eventOnHeroDungeonRaidComplete(obj);
			}
		}

		// Token: 0x06012899 RID: 75929 RVA: 0x004C1D34 File Offset: 0x004BFF34
		private void __clearDele_EventOnHeroDungeonRaidComplete(int obj)
		{
			this.EventOnHeroDungeonRaidComplete = null;
		}

		// Token: 0x0601289A RID: 75930 RVA: 0x004C1D40 File Offset: 0x004BFF40
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateRiftLevelInfoConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("UpdateRiftLevelInfo") as LuaFunction);
					this.m_UpdateHeroDungeonLevelInfoConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("UpdateHeroDungeonLevelInfo") as LuaFunction);
					this.m_StartRiftRaidLevelUITaskInt32BattleRewardList`1NeedGoods_hotfix = (luaObj.RawGet("StartRiftRaidLevelUITask") as LuaFunction);
					this.m_StartHeroDungeonLevelRaidUITaskInt32BattleRewardList`1_hotfix = (luaObj.RawGet("StartHeroDungeonLevelRaidUITask") as LuaFunction);
					this.m_RaidUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("RaidUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartRiftLevelRaidNetTaskInt32Int32_hotfix = (luaObj.RawGet("StartRiftLevelRaidNetTask") as LuaFunction);
					this.m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix = (luaObj.RawGet("StartHeroDungeonLevelRaidNetTask") as LuaFunction);
					this.m_BattleLevelInfoUIController_OnStartBattle_hotfix = (luaObj.RawGet("BattleLevelInfoUIController_OnStartBattle") as LuaFunction);
					this.m_BattleLevelInfoUIController_OnRaidBattleInt32_hotfix = (luaObj.RawGet("BattleLevelInfoUIController_OnRaidBattle") as LuaFunction);
					this.m_BattleLevelInfoUIController_OnShowAchievement_hotfix = (luaObj.RawGet("BattleLevelInfoUIController_OnShowAchievement") as LuaFunction);
					this.m_BattleLevelInfoUIController_OnClose_hotfix = (luaObj.RawGet("BattleLevelInfoUIController_OnClose") as LuaFunction);
					this.m_RaidLevelUITask_OnRiftRaidClose_hotfix = (luaObj.RawGet("RaidLevelUITask_OnRiftRaidClose") as LuaFunction);
					this.m_RaidLevelUITask_OnHeroDungeonRaidClose_hotfix = (luaObj.RawGet("RaidLevelUITask_OnHeroDungeonRaidClose") as LuaFunction);
					this.m_RaidLevelUITask_OnRiftRaidCompleteInt32_hotfix = (luaObj.RawGet("RaidLevelUITask_OnRiftRaidComplete") as LuaFunction);
					this.m_RaidLevelUITask_OnHeroDungeonRaidCompleteInt32_hotfix = (luaObj.RawGet("RaidLevelUITask_OnHeroDungeonRaidComplete") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnRiftRaidCompleteAction`1_hotfix = (luaObj.RawGet("add_EventOnRiftRaidComplete") as LuaFunction);
					this.m_remove_EventOnRiftRaidCompleteAction`1_hotfix = (luaObj.RawGet("remove_EventOnRiftRaidComplete") as LuaFunction);
					this.m_add_EventOnHeroDungeonRaidCompleteAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroDungeonRaidComplete") as LuaFunction);
					this.m_remove_EventOnHeroDungeonRaidCompleteAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroDungeonRaidComplete") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601289B RID: 75931 RVA: 0x004C20FC File Offset: 0x004C02FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleLevelInfoUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A676 RID: 42614
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleLevelInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Rift_ABS/Prefab/BattleLevelInfoUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A677 RID: 42615
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleLevelInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleLevelInfoUIController"),
				m_ctrlName = "BattleLevelInfoUIController"
			}
		};

		// Token: 0x0400A678 RID: 42616
		private BattleLevelInfoUIController m_battleLevelInfoUIController;

		// Token: 0x0400A679 RID: 42617
		private RaidLevelUITask m_raidLevelUITask;

		// Token: 0x0400A67A RID: 42618
		private ConfigDataRiftLevelInfo m_riftLevelInfo;

		// Token: 0x0400A67B RID: 42619
		private ConfigDataHeroDungeonLevelInfo m_heroDungeonLevelInfo;

		// Token: 0x0400A67C RID: 42620
		private BattleType m_battleType;

		// Token: 0x0400A67D RID: 42621
		private NeedGoods m_needGoods;

		// Token: 0x0400A67E RID: 42622
		private bool m_needOpenTween = true;

		// Token: 0x0400A67F RID: 42623
		[DoNotToLua]
		private BattleLevelInfoUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A680 RID: 42624
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A681 RID: 42625
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A682 RID: 42626
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A683 RID: 42627
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A684 RID: 42628
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A685 RID: 42629
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400A686 RID: 42630
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A687 RID: 42631
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A688 RID: 42632
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A689 RID: 42633
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A68A RID: 42634
		private LuaFunction m_UpdateRiftLevelInfoConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400A68B RID: 42635
		private LuaFunction m_UpdateHeroDungeonLevelInfoConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x0400A68C RID: 42636
		private LuaFunction m_StartRiftRaidLevelUITaskInt32BattleRewardList;

		// Token: 0x0400A68D RID: 42637
		private LuaFunction m_StartHeroDungeonLevelRaidUITaskInt32BattleRewardList;

		// Token: 0x0400A68E RID: 42638
		private LuaFunction m_RaidUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400A68F RID: 42639
		private LuaFunction m_StartRiftLevelRaidNetTaskInt32Int32_hotfix;

		// Token: 0x0400A690 RID: 42640
		private LuaFunction m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix;

		// Token: 0x0400A691 RID: 42641
		private LuaFunction m_BattleLevelInfoUIController_OnStartBattle_hotfix;

		// Token: 0x0400A692 RID: 42642
		private LuaFunction m_BattleLevelInfoUIController_OnRaidBattleInt32_hotfix;

		// Token: 0x0400A693 RID: 42643
		private LuaFunction m_BattleLevelInfoUIController_OnShowAchievement_hotfix;

		// Token: 0x0400A694 RID: 42644
		private LuaFunction m_BattleLevelInfoUIController_OnClose_hotfix;

		// Token: 0x0400A695 RID: 42645
		private LuaFunction m_RaidLevelUITask_OnRiftRaidClose_hotfix;

		// Token: 0x0400A696 RID: 42646
		private LuaFunction m_RaidLevelUITask_OnHeroDungeonRaidClose_hotfix;

		// Token: 0x0400A697 RID: 42647
		private LuaFunction m_RaidLevelUITask_OnRiftRaidCompleteInt32_hotfix;

		// Token: 0x0400A698 RID: 42648
		private LuaFunction m_RaidLevelUITask_OnHeroDungeonRaidCompleteInt32_hotfix;

		// Token: 0x0400A699 RID: 42649
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A69A RID: 42650
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400A69B RID: 42651
		private LuaFunction m_add_EventOnRiftRaidCompleteAction;

		// Token: 0x0400A69C RID: 42652
		private LuaFunction m_remove_EventOnRiftRaidCompleteAction;

		// Token: 0x0400A69D RID: 42653
		private LuaFunction m_add_EventOnHeroDungeonRaidCompleteAction;

		// Token: 0x0400A69E RID: 42654
		private LuaFunction m_remove_EventOnHeroDungeonRaidCompleteAction;

		// Token: 0x0400A69F RID: 42655
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A6A0 RID: 42656
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000EC7 RID: 3783
		public new class LuaExportHelper
		{
			// Token: 0x0601289C RID: 75932 RVA: 0x004C2164 File Offset: 0x004C0364
			public LuaExportHelper(BattleLevelInfoUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601289D RID: 75933 RVA: 0x004C2174 File Offset: 0x004C0374
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601289E RID: 75934 RVA: 0x004C2184 File Offset: 0x004C0384
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601289F RID: 75935 RVA: 0x004C2194 File Offset: 0x004C0394
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060128A0 RID: 75936 RVA: 0x004C21A4 File Offset: 0x004C03A4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060128A1 RID: 75937 RVA: 0x004C21B4 File Offset: 0x004C03B4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060128A2 RID: 75938 RVA: 0x004C21C4 File Offset: 0x004C03C4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060128A3 RID: 75939 RVA: 0x004C21D4 File Offset: 0x004C03D4
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060128A4 RID: 75940 RVA: 0x004C21E4 File Offset: 0x004C03E4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060128A5 RID: 75941 RVA: 0x004C21F4 File Offset: 0x004C03F4
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060128A6 RID: 75942 RVA: 0x004C2204 File Offset: 0x004C0404
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060128A7 RID: 75943 RVA: 0x004C2214 File Offset: 0x004C0414
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060128A8 RID: 75944 RVA: 0x004C2224 File Offset: 0x004C0424
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060128A9 RID: 75945 RVA: 0x004C2234 File Offset: 0x004C0434
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060128AA RID: 75946 RVA: 0x004C2244 File Offset: 0x004C0444
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060128AB RID: 75947 RVA: 0x004C2254 File Offset: 0x004C0454
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060128AC RID: 75948 RVA: 0x004C2264 File Offset: 0x004C0464
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060128AD RID: 75949 RVA: 0x004C2274 File Offset: 0x004C0474
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060128AE RID: 75950 RVA: 0x004C2284 File Offset: 0x004C0484
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060128AF RID: 75951 RVA: 0x004C2294 File Offset: 0x004C0494
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060128B0 RID: 75952 RVA: 0x004C22A4 File Offset: 0x004C04A4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060128B1 RID: 75953 RVA: 0x004C22B4 File Offset: 0x004C04B4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060128B2 RID: 75954 RVA: 0x004C22C4 File Offset: 0x004C04C4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060128B3 RID: 75955 RVA: 0x004C22D4 File Offset: 0x004C04D4
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060128B4 RID: 75956 RVA: 0x004C22E4 File Offset: 0x004C04E4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x060128B5 RID: 75957 RVA: 0x004C22F4 File Offset: 0x004C04F4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x060128B6 RID: 75958 RVA: 0x004C2304 File Offset: 0x004C0504
			public void __callDele_EventOnRiftRaidComplete(int obj)
			{
				this.m_owner.__callDele_EventOnRiftRaidComplete(obj);
			}

			// Token: 0x060128B7 RID: 75959 RVA: 0x004C2314 File Offset: 0x004C0514
			public void __clearDele_EventOnRiftRaidComplete(int obj)
			{
				this.m_owner.__clearDele_EventOnRiftRaidComplete(obj);
			}

			// Token: 0x060128B8 RID: 75960 RVA: 0x004C2324 File Offset: 0x004C0524
			public void __callDele_EventOnHeroDungeonRaidComplete(int obj)
			{
				this.m_owner.__callDele_EventOnHeroDungeonRaidComplete(obj);
			}

			// Token: 0x060128B9 RID: 75961 RVA: 0x004C2334 File Offset: 0x004C0534
			public void __clearDele_EventOnHeroDungeonRaidComplete(int obj)
			{
				this.m_owner.__clearDele_EventOnHeroDungeonRaidComplete(obj);
			}

			// Token: 0x17003808 RID: 14344
			// (get) Token: 0x060128BA RID: 75962 RVA: 0x004C2344 File Offset: 0x004C0544
			// (set) Token: 0x060128BB RID: 75963 RVA: 0x004C2354 File Offset: 0x004C0554
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

			// Token: 0x17003809 RID: 14345
			// (get) Token: 0x060128BC RID: 75964 RVA: 0x004C2364 File Offset: 0x004C0564
			// (set) Token: 0x060128BD RID: 75965 RVA: 0x004C2374 File Offset: 0x004C0574
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

			// Token: 0x1700380A RID: 14346
			// (get) Token: 0x060128BE RID: 75966 RVA: 0x004C2384 File Offset: 0x004C0584
			// (set) Token: 0x060128BF RID: 75967 RVA: 0x004C2394 File Offset: 0x004C0594
			public BattleLevelInfoUIController m_battleLevelInfoUIController
			{
				get
				{
					return this.m_owner.m_battleLevelInfoUIController;
				}
				set
				{
					this.m_owner.m_battleLevelInfoUIController = value;
				}
			}

			// Token: 0x1700380B RID: 14347
			// (get) Token: 0x060128C0 RID: 75968 RVA: 0x004C23A4 File Offset: 0x004C05A4
			// (set) Token: 0x060128C1 RID: 75969 RVA: 0x004C23B4 File Offset: 0x004C05B4
			public RaidLevelUITask m_raidLevelUITask
			{
				get
				{
					return this.m_owner.m_raidLevelUITask;
				}
				set
				{
					this.m_owner.m_raidLevelUITask = value;
				}
			}

			// Token: 0x1700380C RID: 14348
			// (get) Token: 0x060128C2 RID: 75970 RVA: 0x004C23C4 File Offset: 0x004C05C4
			// (set) Token: 0x060128C3 RID: 75971 RVA: 0x004C23D4 File Offset: 0x004C05D4
			public ConfigDataRiftLevelInfo m_riftLevelInfo
			{
				get
				{
					return this.m_owner.m_riftLevelInfo;
				}
				set
				{
					this.m_owner.m_riftLevelInfo = value;
				}
			}

			// Token: 0x1700380D RID: 14349
			// (get) Token: 0x060128C4 RID: 75972 RVA: 0x004C23E4 File Offset: 0x004C05E4
			// (set) Token: 0x060128C5 RID: 75973 RVA: 0x004C23F4 File Offset: 0x004C05F4
			public ConfigDataHeroDungeonLevelInfo m_heroDungeonLevelInfo
			{
				get
				{
					return this.m_owner.m_heroDungeonLevelInfo;
				}
				set
				{
					this.m_owner.m_heroDungeonLevelInfo = value;
				}
			}

			// Token: 0x1700380E RID: 14350
			// (get) Token: 0x060128C6 RID: 75974 RVA: 0x004C2404 File Offset: 0x004C0604
			// (set) Token: 0x060128C7 RID: 75975 RVA: 0x004C2414 File Offset: 0x004C0614
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

			// Token: 0x1700380F RID: 14351
			// (get) Token: 0x060128C8 RID: 75976 RVA: 0x004C2424 File Offset: 0x004C0624
			// (set) Token: 0x060128C9 RID: 75977 RVA: 0x004C2434 File Offset: 0x004C0634
			public NeedGoods m_needGoods
			{
				get
				{
					return this.m_owner.m_needGoods;
				}
				set
				{
					this.m_owner.m_needGoods = value;
				}
			}

			// Token: 0x17003810 RID: 14352
			// (get) Token: 0x060128CA RID: 75978 RVA: 0x004C2444 File Offset: 0x004C0644
			// (set) Token: 0x060128CB RID: 75979 RVA: 0x004C2454 File Offset: 0x004C0654
			public bool m_needOpenTween
			{
				get
				{
					return this.m_owner.m_needOpenTween;
				}
				set
				{
					this.m_owner.m_needOpenTween = value;
				}
			}

			// Token: 0x17003811 RID: 14353
			// (get) Token: 0x060128CC RID: 75980 RVA: 0x004C2464 File Offset: 0x004C0664
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003812 RID: 14354
			// (get) Token: 0x060128CD RID: 75981 RVA: 0x004C2474 File Offset: 0x004C0674
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060128CE RID: 75982 RVA: 0x004C2484 File Offset: 0x004C0684
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060128CF RID: 75983 RVA: 0x004C2494 File Offset: 0x004C0694
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060128D0 RID: 75984 RVA: 0x004C24A4 File Offset: 0x004C06A4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060128D1 RID: 75985 RVA: 0x004C24B4 File Offset: 0x004C06B4
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060128D2 RID: 75986 RVA: 0x004C24C4 File Offset: 0x004C06C4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060128D3 RID: 75987 RVA: 0x004C24D4 File Offset: 0x004C06D4
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060128D4 RID: 75988 RVA: 0x004C24E4 File Offset: 0x004C06E4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060128D5 RID: 75989 RVA: 0x004C24F4 File Offset: 0x004C06F4
			public void UpdateRiftLevelInfo(ConfigDataRiftLevelInfo levelInfo)
			{
				this.m_owner.UpdateRiftLevelInfo(levelInfo);
			}

			// Token: 0x060128D6 RID: 75990 RVA: 0x004C2504 File Offset: 0x004C0704
			public void UpdateHeroDungeonLevelInfo(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				this.m_owner.UpdateHeroDungeonLevelInfo(levelInfo);
			}

			// Token: 0x060128D7 RID: 75991 RVA: 0x004C2514 File Offset: 0x004C0714
			public void StartRiftRaidLevelUITask(int riftLevelID, BattleReward reward, List<Goods> extraReward, NeedGoods needGoods)
			{
				this.m_owner.StartRiftRaidLevelUITask(riftLevelID, reward, extraReward, needGoods);
			}

			// Token: 0x060128D8 RID: 75992 RVA: 0x004C2528 File Offset: 0x004C0728
			public void StartHeroDungeonLevelRaidUITask(int heroDungeonLevelID, BattleReward reward, List<Goods> extraReward)
			{
				this.m_owner.StartHeroDungeonLevelRaidUITask(heroDungeonLevelID, reward, extraReward);
			}

			// Token: 0x060128D9 RID: 75993 RVA: 0x004C2538 File Offset: 0x004C0738
			public void RaidUITask_OnLoadAllResCompleted()
			{
				this.m_owner.RaidUITask_OnLoadAllResCompleted();
			}

			// Token: 0x060128DA RID: 75994 RVA: 0x004C2548 File Offset: 0x004C0748
			public void StartRiftLevelRaidNetTask(int levelId, int count)
			{
				this.m_owner.StartRiftLevelRaidNetTask(levelId, count);
			}

			// Token: 0x060128DB RID: 75995 RVA: 0x004C2558 File Offset: 0x004C0758
			public void StartHeroDungeonLevelRaidNetTask(int levelId, int count)
			{
				this.m_owner.StartHeroDungeonLevelRaidNetTask(levelId, count);
			}

			// Token: 0x060128DC RID: 75996 RVA: 0x004C2568 File Offset: 0x004C0768
			public void BattleLevelInfoUIController_OnStartBattle()
			{
				this.m_owner.BattleLevelInfoUIController_OnStartBattle();
			}

			// Token: 0x060128DD RID: 75997 RVA: 0x004C2578 File Offset: 0x004C0778
			public void BattleLevelInfoUIController_OnRaidBattle(int count)
			{
				this.m_owner.BattleLevelInfoUIController_OnRaidBattle(count);
			}

			// Token: 0x060128DE RID: 75998 RVA: 0x004C2588 File Offset: 0x004C0788
			public void BattleLevelInfoUIController_OnShowAchievement()
			{
				this.m_owner.BattleLevelInfoUIController_OnShowAchievement();
			}

			// Token: 0x060128DF RID: 75999 RVA: 0x004C2598 File Offset: 0x004C0798
			public void BattleLevelInfoUIController_OnClose()
			{
				this.m_owner.BattleLevelInfoUIController_OnClose();
			}

			// Token: 0x060128E0 RID: 76000 RVA: 0x004C25A8 File Offset: 0x004C07A8
			public void RaidLevelUITask_OnRiftRaidClose()
			{
				this.m_owner.RaidLevelUITask_OnRiftRaidClose();
			}

			// Token: 0x060128E1 RID: 76001 RVA: 0x004C25B8 File Offset: 0x004C07B8
			public void RaidLevelUITask_OnHeroDungeonRaidClose()
			{
				this.m_owner.RaidLevelUITask_OnHeroDungeonRaidClose();
			}

			// Token: 0x060128E2 RID: 76002 RVA: 0x004C25C8 File Offset: 0x004C07C8
			public void RaidLevelUITask_OnRiftRaidComplete(int levelId)
			{
				this.m_owner.RaidLevelUITask_OnRiftRaidComplete(levelId);
			}

			// Token: 0x060128E3 RID: 76003 RVA: 0x004C25D8 File Offset: 0x004C07D8
			public void RaidLevelUITask_OnHeroDungeonRaidComplete(int levelId)
			{
				this.m_owner.RaidLevelUITask_OnHeroDungeonRaidComplete(levelId);
			}

			// Token: 0x0400A6A1 RID: 42657
			private BattleLevelInfoUITask m_owner;
		}
	}
}
