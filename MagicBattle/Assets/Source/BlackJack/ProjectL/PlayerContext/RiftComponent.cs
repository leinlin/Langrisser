using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008E1 RID: 2273
	[HotFix]
	public class RiftComponent : RiftComponentCommon
	{
		// Token: 0x06007678 RID: 30328 RVA: 0x00206290 File Offset: 0x00204490
		public RiftComponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x002062F8 File Offset: 0x002044F8
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00206374 File Offset: 0x00204574
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x002063DC File Offset: 0x002045DC
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00206444 File Offset: 0x00204644
		public void DeSerialize(DSRiftNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSRiftNtf_hotfix != null)
			{
				this.m_DeSerializeDSRiftNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_riftDS.ClearInitedData();
			this.m_riftDS.InitAchievementRelationIds(msg.AchievementRelationIds, this.m_riftDS.LastRiftRankUpdateTime, this.m_riftDS.LastRiftAchievementRank);
			this.InitChapterInfos(msg.RiftChapters);
			this.m_riftDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x0020650C File Offset: 0x0020470C
		private void InitChapterInfos(List<ProRiftChapter> proChapters)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitChapterInfosList`1_hotfix != null)
			{
				this.m_InitChapterInfosList`1_hotfix.call(new object[]
				{
					this,
					proChapters
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (ProRiftChapter proRiftChapter in proChapters)
			{
				num = 0;
				foreach (ProRiftLevel proRiftLevel in proRiftChapter.ChapterLevels)
				{
					ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(proRiftLevel.LevelId);
					if (configDataRiftLevelInfo != null && configDataRiftLevelInfo.m_chapterId != 0)
					{
						num = configDataRiftLevelInfo.m_chapterId;
						this.m_riftDS.InitLevel(num, proRiftLevel.LevelId, proRiftLevel.Nums, proRiftLevel.Star);
					}
				}
				if (num != 0)
				{
					foreach (int index in proRiftChapter.StarRewardIndexes)
					{
						this.m_riftDS.AddChapterStarReward(num, index);
					}
				}
			}
			foreach (RiftChapter riftChapter in this.m_riftDS.Chapters.Values)
			{
				int num2 = 0;
				foreach (RiftLevel riftLevel in riftChapter.ChapterLevels)
				{
					ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(riftLevel.LevelId);
					if (configDataRiftLevelInfo.LevelType != RiftLevelType.RiftLevelType_Event)
					{
						num2 += riftLevel.Stars;
					}
				}
				riftChapter.TotalStars = num2;
			}
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00206784 File Offset: 0x00204984
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftDS.ClientVersion;
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x002067FC File Offset: 0x002049FC
		public int GainChapterReward(int chapterId, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainChapterRewardInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GainChapterRewardInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = this.m_configDataLoader.GetConfigDataRiftChapterInfo(chapterId);
			if (configDataRiftChapterInfo == null)
			{
				return -805;
			}
			if (base.GetChapterRewards(configDataRiftChapterInfo, index) == null)
			{
				return -815;
			}
			this.m_riftDS.SetChapterStarReward(chapterId, index);
			return 0;
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x002068C4 File Offset: 0x00204AC4
		public override void SetSuccessRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo, List<int> newAchievementIds, int stars, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessRiftLevelConfigDataRiftLevelInfoList`1Int32List`1_hotfix != null)
			{
				this.m_SetSuccessRiftLevelConfigDataRiftLevelInfoList`1Int32List`1_hotfix.call(new object[]
				{
					this,
					riftLevelInfo,
					newAchievementIds,
					stars,
					battleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.SetSuccessRiftLevel(riftLevelInfo, newAchievementIds, stars, battleTreasures);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = riftLevelInfo.PlayerExpReward;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(riftLevelInfo.HeroExpReward);
			battleReward.Gold = riftLevelInfo.GoldReward;
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x002069B0 File Offset: 0x00204BB0
		protected override void ComplteRiftLevel(int riftLevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComplteRiftLevelInt32_hotfix != null)
			{
				this.m_ComplteRiftLevelInt32_hotfix.call(new object[]
				{
					this,
					riftLevelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ComplteRiftLevel(riftLevelId);
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x00206A28 File Offset: 0x00204C28
		public override void CompleteAchievement(int achievementId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CompleteAchievementInt32_hotfix != null)
			{
				this.m_CompleteAchievementInt32_hotfix.call(new object[]
				{
					this,
					achievementId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.CompleteAchievement(achievementId);
		}

		// Token: 0x06007683 RID: 30339 RVA: 0x00206AA0 File Offset: 0x00204CA0
		public int CanUnlockChapter(int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockChapterInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnlockChapterInt32_hotfix.call(new object[]
				{
					this,
					chapterId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = this.m_configDataLoader.GetConfigDataRiftChapterInfo(chapterId);
			if (configDataRiftChapterInfo == null)
			{
				return -805;
			}
			if (!configDataRiftChapterInfo.IsOpened)
			{
				return -826;
			}
			if (configDataRiftChapterInfo.UnlockConditions == null)
			{
				return 0;
			}
			foreach (RiftChapterInfoUnlockConditions riftChapterInfoUnlockConditions in configDataRiftChapterInfo.UnlockConditions)
			{
				RiftChapterUnlockConditionType conditionType = riftChapterInfoUnlockConditions.ConditionType;
				if (conditionType != RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_PlayerLevel)
				{
					if (conditionType != RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_Scenario)
					{
						if (conditionType == RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_ChapterStar)
						{
							if (riftChapterInfoUnlockConditions.Param != 0 && base.GetChapterTotalStars(configDataRiftChapterInfo.HardChapter) < riftChapterInfoUnlockConditions.Param)
							{
								return -822;
							}
						}
					}
					else if (riftChapterInfoUnlockConditions.Param != 0)
					{
						ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(this.m_level.GetLastFinishedScenarioId());
						ConfigDataScenarioInfo configDataScenarioInfo2 = this.m_configDataLoader.GetConfigDataScenarioInfo(riftChapterInfoUnlockConditions.Param);
						if (configDataScenarioInfo2 == null)
						{
							return -700;
						}
						if (configDataScenarioInfo == null || configDataScenarioInfo.m_scenarioDepth < configDataScenarioInfo2.m_scenarioDepth)
						{
							return -807;
						}
					}
				}
				else if (riftChapterInfoUnlockConditions.Param != 0 && this.m_basicInfo.GetLevel() < riftChapterInfoUnlockConditions.Param)
				{
					return -806;
				}
			}
			return 0;
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x00206CA8 File Offset: 0x00204EA8
		public int GetRiftLevelChallengeNum(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRiftLevelChallengeNumInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRiftLevelChallengeNumInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
			if (configDataRiftLevelInfo == null)
			{
				return 0;
			}
			RiftLevel riftLevel = this.m_riftDS.FindLevel(configDataRiftLevelInfo.m_chapterId, levelId);
			if (riftLevel == null)
			{
				return 0;
			}
			return this.m_riftDS.GetLevelChallengeNums(riftLevel);
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x00206D60 File Offset: 0x00204F60
		public int GetRiftLevelCanChallengeNums(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRiftLevelCanChallengeNumsConfigDataRiftLevelInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRiftLevelCanChallengeNumsConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevel riftLevel = this.m_riftDS.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			if (riftLevel == null)
			{
				return base.GetRiftLevelCanChallengeMaxNums(levelInfo);
			}
			return base.GetRiftLevelCanChallengeMaxNums(levelInfo) - this.m_riftDS.GetLevelChallengeNums(riftLevel);
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00206E18 File Offset: 0x00205018
		public int RaidRiftLevel(int riftlevelId, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidRiftLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_RaidRiftLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					riftlevelId,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(riftlevelId);
			if (configDataRiftLevelInfo == null)
			{
				return -808;
			}
			for (int i = 0; i < nums; i++)
			{
				base.SetRaidSuccessRiftLevel(configDataRiftLevelInfo);
			}
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = configDataRiftLevelInfo.PlayerExpReward * nums;
			battleReward.HeroExp = 0;
			battleReward.Gold = configDataRiftLevelInfo.GoldReward * nums;
			return 0;
		}

		// Token: 0x06007687 RID: 30343 RVA: 0x00206F0C File Offset: 0x0020510C
		public bool IsRiftLevelChallenged(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRiftLevelChallengedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRiftLevelChallengedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
			if (configDataRiftLevelInfo == null)
			{
				return false;
			}
			RiftLevel riftLevel = this.m_riftDS.FindLevel(configDataRiftLevelInfo.m_chapterId, levelId);
			return riftLevel != null;
		}

		// Token: 0x06007688 RID: 30344 RVA: 0x00206FB8 File Offset: 0x002051B8
		public int GetRiftLevelStars(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRiftLevelStarsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRiftLevelStarsInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
			if (configDataRiftLevelInfo == null)
			{
				return 0;
			}
			RiftLevel riftLevel = this.m_riftDS.FindLevel(configDataRiftLevelInfo.m_chapterId, levelId);
			if (riftLevel == null)
			{
				return 0;
			}
			return riftLevel.Stars;
		}

		// Token: 0x06007689 RID: 30345 RVA: 0x0020706C File Offset: 0x0020526C
		public int FinishBattleRiftLevel(int riftLevelId, List<int> gotAchievementIds, int star, List<int> battleTreasureIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishBattleRiftLevelInt32List`1Int32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishBattleRiftLevelInt32List`1Int32List`1_hotfix.call(new object[]
				{
					this,
					riftLevelId,
					gotAchievementIds,
					star,
					battleTreasureIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(riftLevelId);
			if (configDataRiftLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -808;
			}
			if (star > 0)
			{
				this.SetSuccessRiftLevel(configDataRiftLevelInfo, gotAchievementIds, star, battleTreasureIds);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, star > 0, true);
			return 0;
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00207164 File Offset: 0x00205364
		public int CanGainChapterStarReward(int chapterId, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGainChapterStarRewardInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGainChapterStarRewardInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = this.m_configDataLoader.GetConfigDataRiftChapterInfo(chapterId);
			if (configDataRiftChapterInfo == null)
			{
				return -805;
			}
			int chapterTotalStars = base.GetChapterTotalStars(configDataRiftChapterInfo.ID);
			if (chapterTotalStars == 0)
			{
				return -814;
			}
			if (this.m_riftDS.IsGainChapterStarReward(configDataRiftChapterInfo.ID, index))
			{
				return -804;
			}
			int num = 0;
			if (index != 1)
			{
				if (index != 2)
				{
					if (index == 3)
					{
						num = configDataRiftChapterInfo.Reward3Star;
					}
				}
				else
				{
					num = configDataRiftChapterInfo.Reward2Star;
				}
			}
			else
			{
				num = configDataRiftChapterInfo.Reward1Star;
			}
			return (chapterTotalStars < num) ? -814 : 0;
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00207294 File Offset: 0x00205494
		public bool IsRiftChapterUnlockConditionCompleted(int chapterId, RiftChapterUnlockConditionType condition, int param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRiftChapterUnlockConditionCompletedInt32RiftChapterUnlockConditionTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRiftChapterUnlockConditionCompletedInt32RiftChapterUnlockConditionTypeInt32_hotfix.call(new object[]
				{
					this,
					chapterId,
					condition,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (condition == RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_PlayerLevel)
			{
				return this.m_basicInfo.GetLevel() >= param;
			}
			if (condition != RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_Scenario)
			{
				return false;
			}
			ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(param);
			if (configDataScenarioInfo == null)
			{
				return false;
			}
			ConfigDataScenarioInfo configDataScenarioInfo2 = this.m_configDataLoader.GetConfigDataScenarioInfo(this.m_level.GetLastFinishedScenarioId());
			return configDataScenarioInfo2 != null && configDataScenarioInfo2.m_scenarioDepth >= configDataScenarioInfo.m_scenarioDepth;
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x00207398 File Offset: 0x00205598
		public bool IsRiftLevelUnlockConditionCompleted(int levelId, RiftLevelUnlockConditionType condition, int param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRiftLevelUnlockConditionCompletedInt32RiftLevelUnlockConditionTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRiftLevelUnlockConditionCompletedInt32RiftLevelUnlockConditionTypeInt32_hotfix.call(new object[]
				{
					this,
					levelId,
					condition,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Scenario)
			{
				ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(param);
				if (configDataScenarioInfo == null)
				{
					return false;
				}
				ConfigDataScenarioInfo configDataScenarioInfo2 = this.m_configDataLoader.GetConfigDataScenarioInfo(this.m_level.GetLastFinishedScenarioId());
				return configDataScenarioInfo2 != null && configDataScenarioInfo2.m_scenarioDepth >= configDataScenarioInfo.m_scenarioDepth;
			}
			else
			{
				if (condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Achievement)
				{
					return this.m_unLockInfo.GainRiftAchievementRelationIds.Contains(param);
				}
				return condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Hero && this.m_unLockInfo.GainHeroIds.Contains(param);
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x0600768D RID: 30349 RVA: 0x002074B8 File Offset: 0x002056B8
		// (set) Token: 0x0600768E RID: 30350 RVA: 0x002074D8 File Offset: 0x002056D8
		[DoNotToLua]
		public new RiftComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x002074E4 File Offset: 0x002056E4
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x002074EC File Offset: 0x002056EC
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x002074F4 File Offset: 0x002056F4
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x002074FC File Offset: 0x002056FC
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00207504 File Offset: 0x00205704
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00207510 File Offset: 0x00205710
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00207518 File Offset: 0x00205718
		private void __callBase_AddChallengeNums(ConfigDataRiftLevelInfo levelInfo, int num)
		{
			base.AddChallengeNums(levelInfo, num);
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00207524 File Offset: 0x00205724
		private void __callBase_ResetLevelChallengeNums()
		{
			base.ResetLevelChallengeNums();
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x0020752C File Offset: 0x0020572C
		private HashSet<int> __callBase_GetAllRiftLevelAchievements()
		{
			return base.GetAllRiftLevelAchievements();
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00207534 File Offset: 0x00205734
		private int __callBase_AttackLevel(int levelId)
		{
			return base.AttackLevel(levelId);
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x00207540 File Offset: 0x00205740
		private void __callBase_SetLevel(int chapterId, int levelId, int nums, int stars, bool needAddStar)
		{
			base.SetLevel(chapterId, levelId, nums, stars, needAddStar);
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00207550 File Offset: 0x00205750
		private int __callBase_CanAttackLevel(int levelId)
		{
			return base.CanAttackLevel(levelId);
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x0020755C File Offset: 0x0020575C
		private bool __callBase_IsFirstPassLevel(int levelId)
		{
			return base.IsFirstPassLevel(levelId);
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00207568 File Offset: 0x00205768
		private bool __callBase_IsLevelFinished(int levelId)
		{
			return base.IsLevelFinished(levelId);
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00207574 File Offset: 0x00205774
		private int __callBase_GetAddRandomDropRewardExpectedSize(int randomDropId)
		{
			return base.GetAddRandomDropRewardExpectedSize(randomDropId);
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00207580 File Offset: 0x00205780
		private int __callBase_CanUnLockLevel(int riftLevelId)
		{
			return base.CanUnLockLevel(riftLevelId);
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x0020758C File Offset: 0x0020578C
		private int __callBase_GetRiftLevelCanChallengeMaxNums(ConfigDataRiftLevelInfo levelInfo)
		{
			return base.GetRiftLevelCanChallengeMaxNums(levelInfo);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00207598 File Offset: 0x00205798
		private int __callBase_CanRaidLevel(ConfigDataRiftLevelInfo levelInfo)
		{
			return base.CanRaidLevel(levelInfo);
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x002075A4 File Offset: 0x002057A4
		private void __callBase_CompleteAchievement(int achievementRelationId)
		{
			base.CompleteAchievement(achievementRelationId);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x002075B0 File Offset: 0x002057B0
		private void __callBase_AddRiftLevelBasicRewards(ConfigDataRiftLevelInfo riftLevelInfo, bool isRaid)
		{
			base.AddRiftLevelBasicRewards(riftLevelInfo, isRaid);
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x002075BC File Offset: 0x002057BC
		private void __callBase_SetSuccessRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo, List<int> newAchievementIds, int stars, List<int> battleTreasures)
		{
			base.SetSuccessRiftLevel(riftLevelInfo, newAchievementIds, stars, battleTreasures);
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x002075CC File Offset: 0x002057CC
		private void __callBase_SetRaidSuccessRiftLevel(ConfigDataRiftLevelInfo levelInfo)
		{
			base.SetRaidSuccessRiftLevel(levelInfo);
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x002075D8 File Offset: 0x002057D8
		private bool __callBase_HasGotAchievementRelationId(int achievementId)
		{
			return base.HasGotAchievementRelationId(achievementId);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x002075E4 File Offset: 0x002057E4
		private List<Goods> __callBase_GetChapterRewards(ConfigDataRiftChapterInfo chapterInfo, int index)
		{
			return base.GetChapterRewards(chapterInfo, index);
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x002075F0 File Offset: 0x002057F0
		private int __callBase_CanGainChapterReward(ConfigDataRiftChapterInfo chapterInfo, int index, List<Goods> rewards)
		{
			return base.CanGainChapterReward(chapterInfo, index, rewards);
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x002075FC File Offset: 0x002057FC
		private int __callBase_GetChapterTotalStars(int chapterId)
		{
			return base.GetChapterTotalStars(chapterId);
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00207608 File Offset: 0x00205808
		private int __callBase_GetAllRiftLevelStars()
		{
			return base.GetAllRiftLevelStars();
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00207610 File Offset: 0x00205810
		private void __callBase_ComplteRiftLevel(int riftLevelId)
		{
			base.ComplteRiftLevel(riftLevelId);
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x0020761C File Offset: 0x0020581C
		private void __callBase_OnAllRiftLevelStarAdd(int addStar)
		{
			base.OnAllRiftLevelStarAdd(addStar);
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00207628 File Offset: 0x00205828
		private void __callBase_OnRiftAchivementAdd(int addAchivement)
		{
			base.OnRiftAchivementAdd(addAchivement);
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00207634 File Offset: 0x00205834
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSRiftNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_InitChapterInfosList`1_hotfix = (luaObj.RawGet("InitChapterInfos") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GainChapterRewardInt32Int32_hotfix = (luaObj.RawGet("GainChapterReward") as LuaFunction);
					this.m_SetSuccessRiftLevelConfigDataRiftLevelInfoList`1Int32List`1_hotfix = (luaObj.RawGet("SetSuccessRiftLevel") as LuaFunction);
					this.m_ComplteRiftLevelInt32_hotfix = (luaObj.RawGet("ComplteRiftLevel") as LuaFunction);
					this.m_CompleteAchievementInt32_hotfix = (luaObj.RawGet("CompleteAchievement") as LuaFunction);
					this.m_CanUnlockChapterInt32_hotfix = (luaObj.RawGet("CanUnlockChapter") as LuaFunction);
					this.m_GetRiftLevelChallengeNumInt32_hotfix = (luaObj.RawGet("GetRiftLevelChallengeNum") as LuaFunction);
					this.m_GetRiftLevelCanChallengeNumsConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("GetRiftLevelCanChallengeNums") as LuaFunction);
					this.m_RaidRiftLevelInt32Int32_hotfix = (luaObj.RawGet("RaidRiftLevel") as LuaFunction);
					this.m_IsRiftLevelChallengedInt32_hotfix = (luaObj.RawGet("IsRiftLevelChallenged") as LuaFunction);
					this.m_GetRiftLevelStarsInt32_hotfix = (luaObj.RawGet("GetRiftLevelStars") as LuaFunction);
					this.m_FinishBattleRiftLevelInt32List`1Int32List`1_hotfix = (luaObj.RawGet("FinishBattleRiftLevel") as LuaFunction);
					this.m_CanGainChapterStarRewardInt32Int32_hotfix = (luaObj.RawGet("CanGainChapterStarReward") as LuaFunction);
					this.m_IsRiftChapterUnlockConditionCompletedInt32RiftChapterUnlockConditionTypeInt32_hotfix = (luaObj.RawGet("IsRiftChapterUnlockConditionCompleted") as LuaFunction);
					this.m_IsRiftLevelUnlockConditionCompletedInt32RiftLevelUnlockConditionTypeInt32_hotfix = (luaObj.RawGet("IsRiftLevelUnlockConditionCompleted") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x002078F4 File Offset: 0x00205AF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005615 RID: 22037
		[DoNotToLua]
		private RiftComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005616 RID: 22038
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005617 RID: 22039
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005618 RID: 22040
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005619 RID: 22041
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400561A RID: 22042
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400561B RID: 22043
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400561C RID: 22044
		private LuaFunction m_DeSerializeDSRiftNtf_hotfix;

		// Token: 0x0400561D RID: 22045
		private LuaFunction m_InitChapterInfosList;

		// Token: 0x0400561E RID: 22046
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400561F RID: 22047
		private LuaFunction m_GainChapterRewardInt32Int32_hotfix;

		// Token: 0x04005620 RID: 22048
		private LuaFunction m_SetSuccessRiftLevelConfigDataRiftLevelInfoList`1Int32List;

		// Token: 0x04005621 RID: 22049
		private LuaFunction m_ComplteRiftLevelInt32_hotfix;

		// Token: 0x04005622 RID: 22050
		private LuaFunction m_CompleteAchievementInt32_hotfix;

		// Token: 0x04005623 RID: 22051
		private LuaFunction m_CanUnlockChapterInt32_hotfix;

		// Token: 0x04005624 RID: 22052
		private LuaFunction m_GetRiftLevelChallengeNumInt32_hotfix;

		// Token: 0x04005625 RID: 22053
		private LuaFunction m_GetRiftLevelCanChallengeNumsConfigDataRiftLevelInfo_hotfix;

		// Token: 0x04005626 RID: 22054
		private LuaFunction m_RaidRiftLevelInt32Int32_hotfix;

		// Token: 0x04005627 RID: 22055
		private LuaFunction m_IsRiftLevelChallengedInt32_hotfix;

		// Token: 0x04005628 RID: 22056
		private LuaFunction m_GetRiftLevelStarsInt32_hotfix;

		// Token: 0x04005629 RID: 22057
		private LuaFunction m_FinishBattleRiftLevelInt32List`1Int32List;

		// Token: 0x0400562A RID: 22058
		private LuaFunction m_CanGainChapterStarRewardInt32Int32_hotfix;

		// Token: 0x0400562B RID: 22059
		private LuaFunction m_IsRiftChapterUnlockConditionCompletedInt32RiftChapterUnlockConditionTypeInt32_hotfix;

		// Token: 0x0400562C RID: 22060
		private LuaFunction m_IsRiftLevelUnlockConditionCompletedInt32RiftLevelUnlockConditionTypeInt32_hotfix;

		// Token: 0x020008E2 RID: 2274
		public new class LuaExportHelper
		{
			// Token: 0x060076AF RID: 30383 RVA: 0x0020795C File Offset: 0x00205B5C
			public LuaExportHelper(RiftComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060076B0 RID: 30384 RVA: 0x0020796C File Offset: 0x00205B6C
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060076B1 RID: 30385 RVA: 0x0020797C File Offset: 0x00205B7C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060076B2 RID: 30386 RVA: 0x0020798C File Offset: 0x00205B8C
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060076B3 RID: 30387 RVA: 0x0020799C File Offset: 0x00205B9C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060076B4 RID: 30388 RVA: 0x002079AC File Offset: 0x00205BAC
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060076B5 RID: 30389 RVA: 0x002079BC File Offset: 0x00205BBC
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060076B6 RID: 30390 RVA: 0x002079CC File Offset: 0x00205BCC
			public void __callBase_AddChallengeNums(ConfigDataRiftLevelInfo levelInfo, int num)
			{
				this.m_owner.__callBase_AddChallengeNums(levelInfo, num);
			}

			// Token: 0x060076B7 RID: 30391 RVA: 0x002079DC File Offset: 0x00205BDC
			public void __callBase_ResetLevelChallengeNums()
			{
				this.m_owner.__callBase_ResetLevelChallengeNums();
			}

			// Token: 0x060076B8 RID: 30392 RVA: 0x002079EC File Offset: 0x00205BEC
			public HashSet<int> __callBase_GetAllRiftLevelAchievements()
			{
				return this.m_owner.__callBase_GetAllRiftLevelAchievements();
			}

			// Token: 0x060076B9 RID: 30393 RVA: 0x002079FC File Offset: 0x00205BFC
			public int __callBase_AttackLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackLevel(levelId);
			}

			// Token: 0x060076BA RID: 30394 RVA: 0x00207A0C File Offset: 0x00205C0C
			public void __callBase_SetLevel(int chapterId, int levelId, int nums, int stars, bool needAddStar)
			{
				this.m_owner.__callBase_SetLevel(chapterId, levelId, nums, stars, needAddStar);
			}

			// Token: 0x060076BB RID: 30395 RVA: 0x00207A20 File Offset: 0x00205C20
			public int __callBase_CanAttackLevel(int levelId)
			{
				return this.m_owner.__callBase_CanAttackLevel(levelId);
			}

			// Token: 0x060076BC RID: 30396 RVA: 0x00207A30 File Offset: 0x00205C30
			public bool __callBase_IsFirstPassLevel(int levelId)
			{
				return this.m_owner.__callBase_IsFirstPassLevel(levelId);
			}

			// Token: 0x060076BD RID: 30397 RVA: 0x00207A40 File Offset: 0x00205C40
			public bool __callBase_IsLevelFinished(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(levelId);
			}

			// Token: 0x060076BE RID: 30398 RVA: 0x00207A50 File Offset: 0x00205C50
			public int __callBase_GetAddRandomDropRewardExpectedSize(int randomDropId)
			{
				return this.m_owner.__callBase_GetAddRandomDropRewardExpectedSize(randomDropId);
			}

			// Token: 0x060076BF RID: 30399 RVA: 0x00207A60 File Offset: 0x00205C60
			public int __callBase_CanUnLockLevel(int riftLevelId)
			{
				return this.m_owner.__callBase_CanUnLockLevel(riftLevelId);
			}

			// Token: 0x060076C0 RID: 30400 RVA: 0x00207A70 File Offset: 0x00205C70
			public int __callBase_GetRiftLevelCanChallengeMaxNums(ConfigDataRiftLevelInfo levelInfo)
			{
				return this.m_owner.__callBase_GetRiftLevelCanChallengeMaxNums(levelInfo);
			}

			// Token: 0x060076C1 RID: 30401 RVA: 0x00207A80 File Offset: 0x00205C80
			public int __callBase_CanRaidLevel(ConfigDataRiftLevelInfo levelInfo)
			{
				return this.m_owner.__callBase_CanRaidLevel(levelInfo);
			}

			// Token: 0x060076C2 RID: 30402 RVA: 0x00207A90 File Offset: 0x00205C90
			public void __callBase_CompleteAchievement(int achievementRelationId)
			{
				this.m_owner.__callBase_CompleteAchievement(achievementRelationId);
			}

			// Token: 0x060076C3 RID: 30403 RVA: 0x00207AA0 File Offset: 0x00205CA0
			public void __callBase_AddRiftLevelBasicRewards(ConfigDataRiftLevelInfo riftLevelInfo, bool isRaid)
			{
				this.m_owner.__callBase_AddRiftLevelBasicRewards(riftLevelInfo, isRaid);
			}

			// Token: 0x060076C4 RID: 30404 RVA: 0x00207AB0 File Offset: 0x00205CB0
			public void __callBase_SetSuccessRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo, List<int> newAchievementIds, int stars, List<int> battleTreasures)
			{
				this.m_owner.__callBase_SetSuccessRiftLevel(riftLevelInfo, newAchievementIds, stars, battleTreasures);
			}

			// Token: 0x060076C5 RID: 30405 RVA: 0x00207AC4 File Offset: 0x00205CC4
			public void __callBase_SetRaidSuccessRiftLevel(ConfigDataRiftLevelInfo levelInfo)
			{
				this.m_owner.__callBase_SetRaidSuccessRiftLevel(levelInfo);
			}

			// Token: 0x060076C6 RID: 30406 RVA: 0x00207AD4 File Offset: 0x00205CD4
			public bool __callBase_HasGotAchievementRelationId(int achievementId)
			{
				return this.m_owner.__callBase_HasGotAchievementRelationId(achievementId);
			}

			// Token: 0x060076C7 RID: 30407 RVA: 0x00207AE4 File Offset: 0x00205CE4
			public List<Goods> __callBase_GetChapterRewards(ConfigDataRiftChapterInfo chapterInfo, int index)
			{
				return this.m_owner.__callBase_GetChapterRewards(chapterInfo, index);
			}

			// Token: 0x060076C8 RID: 30408 RVA: 0x00207AF4 File Offset: 0x00205CF4
			public int __callBase_CanGainChapterReward(ConfigDataRiftChapterInfo chapterInfo, int index, List<Goods> rewards)
			{
				return this.m_owner.__callBase_CanGainChapterReward(chapterInfo, index, rewards);
			}

			// Token: 0x060076C9 RID: 30409 RVA: 0x00207B04 File Offset: 0x00205D04
			public int __callBase_GetChapterTotalStars(int chapterId)
			{
				return this.m_owner.__callBase_GetChapterTotalStars(chapterId);
			}

			// Token: 0x060076CA RID: 30410 RVA: 0x00207B14 File Offset: 0x00205D14
			public int __callBase_GetAllRiftLevelStars()
			{
				return this.m_owner.__callBase_GetAllRiftLevelStars();
			}

			// Token: 0x060076CB RID: 30411 RVA: 0x00207B24 File Offset: 0x00205D24
			public void __callBase_ComplteRiftLevel(int riftLevelId)
			{
				this.m_owner.__callBase_ComplteRiftLevel(riftLevelId);
			}

			// Token: 0x060076CC RID: 30412 RVA: 0x00207B34 File Offset: 0x00205D34
			public void __callBase_OnAllRiftLevelStarAdd(int addStar)
			{
				this.m_owner.__callBase_OnAllRiftLevelStarAdd(addStar);
			}

			// Token: 0x060076CD RID: 30413 RVA: 0x00207B44 File Offset: 0x00205D44
			public void __callBase_OnRiftAchivementAdd(int addAchivement)
			{
				this.m_owner.__callBase_OnRiftAchivementAdd(addAchivement);
			}

			// Token: 0x060076CE RID: 30414 RVA: 0x00207B54 File Offset: 0x00205D54
			public void InitChapterInfos(List<ProRiftChapter> proChapters)
			{
				this.m_owner.InitChapterInfos(proChapters);
			}

			// Token: 0x060076CF RID: 30415 RVA: 0x00207B64 File Offset: 0x00205D64
			public void ComplteRiftLevel(int riftLevelId)
			{
				this.m_owner.ComplteRiftLevel(riftLevelId);
			}

			// Token: 0x0400562D RID: 22061
			private RiftComponent m_owner;
		}
	}
}
