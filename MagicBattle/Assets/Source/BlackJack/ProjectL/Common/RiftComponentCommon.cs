using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004A6 RID: 1190
	[HotFix]
	public class RiftComponentCommon : IComponentBase
	{
		// Token: 0x06004825 RID: 18469 RVA: 0x00164DA4 File Offset: 0x00162FA4
		public RiftComponentCommon()
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

		// Token: 0x06004826 RID: 18470 RVA: 0x00164E20 File Offset: 0x00163020
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Rift";
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x00164E94 File Offset: 0x00163094
		public virtual void Init()
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
			this.OperationalActivityChanllengenumsAdd = 0;
			this.HasRewardAddRelativeOperationalActivity = false;
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x00164F04 File Offset: 0x00163104
		public virtual void PostInit()
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_level = (this.Owner.GetOwnerComponent("Level") as LevelComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_unLockInfo.FinishedRiftLevelIds = this.m_riftDS.FinishedRiftLevelIds;
			this.m_unLockInfo.GainRiftAchievementRelationIds = this.m_riftDS.AchievementRelationIds;
			this.m_unLockInfo.GainHeroIds = this.m_hero.GetGainHeroIds();
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushChallengeCountEvent;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x00165044 File Offset: 0x00163244
		public virtual void DeInit()
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
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x001650A4 File Offset: 0x001632A4
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x00165114 File Offset: 0x00163314
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x00165194 File Offset: 0x00163394
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x00165204 File Offset: 0x00163404
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x00165264 File Offset: 0x00163464
		// (set) Token: 0x0600482F RID: 18479 RVA: 0x001652D8 File Offset: 0x001634D8
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00165350 File Offset: 0x00163550
		private void OnFlushChallengeCountEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushChallengeCountEvent_hotfix != null)
			{
				this.m_OnFlushChallengeCountEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ResetLevelChallengeNums();
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x001653B8 File Offset: 0x001635B8
		public void AddChallengeNums(ConfigDataRiftLevelInfo levelInfo, int num)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddChallengeNumsConfigDataRiftLevelInfoInt32_hotfix != null)
			{
				this.m_AddChallengeNumsConfigDataRiftLevelInfoInt32_hotfix.call(new object[]
				{
					this,
					levelInfo,
					num
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevel riftLevel = this.m_riftDS.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			this.m_riftDS.AddLevelChallengeNums(riftLevel, num);
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x00165460 File Offset: 0x00163660
		public void ResetLevelChallengeNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetLevelChallengeNums_hotfix != null)
			{
				this.m_ResetLevelChallengeNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_riftDS.ResetLevelChallengeNums();
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x001654CC File Offset: 0x001636CC
		public HashSet<int> GetAllRiftLevelAchievements()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllRiftLevelAchievements_hotfix != null)
			{
				return (HashSet<int>)this.m_GetAllRiftLevelAchievements_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int key in this.m_riftDS.AchievementRelationIds)
			{
				ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = this.m_configDataLoader.GetConfigDataBattleAchievementRelatedInfo(key);
				if (configDataBattleAchievementRelatedInfo != null)
				{
					hashSet.Add(configDataBattleAchievementRelatedInfo.Achievement_ID);
				}
			}
			return hashSet;
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x001655B4 File Offset: 0x001637B4
		public int AttackLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackLevel(levelId);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataRiftLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_Rift, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.Rift, levelId);
			bool needAddStar = configDataRiftLevelInfo.LevelType != RiftLevelType.RiftLevelType_Event;
			this.SetLevel(configDataRiftLevelInfo.m_chapterId, levelId, 0, 0, needAddStar);
			return 0;
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x001656BC File Offset: 0x001638BC
		protected void SetLevel(int chapterId, int levelId, int nums, int stars, bool needAddStar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInt32Int32Int32Int32Boolean_hotfix != null)
			{
				this.m_SetLevelInt32Int32Int32Int32Boolean_hotfix.call(new object[]
				{
					this,
					chapterId,
					levelId,
					nums,
					stars,
					needAddStar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = stars;
			RiftChapter riftChapter = this.m_riftDS.FindChapter(chapterId);
			if (riftChapter != null)
			{
				RiftLevel riftLevel = this.m_riftDS.FindLevel(riftChapter, levelId);
				if (riftLevel != null)
				{
					if (stars == 0)
					{
						return;
					}
					riftLevel.Nums += nums;
					num = stars - riftLevel.Stars;
					if (num > 0)
					{
						riftLevel.Stars = stars;
					}
					this.m_riftDS.SetDirty(true);
					this.m_riftDS.FinishedRiftLevelIds.Add(levelId);
				}
				else
				{
					this.m_riftDS.AddLevel(riftChapter, levelId, nums, stars);
				}
			}
			else
			{
				riftChapter = this.m_riftDS.AddChapter(chapterId);
				this.m_riftDS.AddLevel(riftChapter, levelId, nums, stars);
			}
			if (num > 0 && needAddStar)
			{
				this.AddChapterTotalStar(riftChapter, num);
				this.OnAllRiftLevelStarAdd(num);
			}
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x00165838 File Offset: 0x00163A38
		private void AddChapterTotalStar(RiftChapter chapter, int addStar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddChapterTotalStarRiftChapterInt32_hotfix != null)
			{
				this.m_AddChapterTotalStarRiftChapterInt32_hotfix.call(new object[]
				{
					this,
					chapter,
					addStar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			chapter.TotalStars += addStar;
			this.m_riftDS.RiftChaptersStarUpdateTime = this.m_basicInfo.GetCurrentTime();
			if (this.GetRiftLevelFightStarMissionEvent != null)
			{
				this.GetRiftLevelFightStarMissionEvent(addStar);
			}
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x001658F4 File Offset: 0x00163AF4
		private bool IsGameFunctionOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGameFunctionOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGameFunctionOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Rift);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x00165970 File Offset: 0x00163B70
		public virtual int CanAttackLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsGameFunctionOpened())
			{
				return -824;
			}
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelId);
			if (configDataRiftLevelInfo == null)
			{
				return -808;
			}
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = this.m_configDataLoader.GetConfigDataRiftChapterInfo(configDataRiftLevelInfo.ChapterID);
			if (!configDataRiftChapterInfo.IsOpened)
			{
				return -824;
			}
			if (configDataRiftLevelInfo.m_battleInfo == null)
			{
				return -816;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			int num = this.CanUnLockLevel(levelId);
			if (num != 0)
			{
				return num;
			}
			if (configDataRiftLevelInfo.LevelType == RiftLevelType.RiftLevelType_Event && !this.IsFirstPassLevel(levelId))
			{
				return -921;
			}
			return this.CanAttackLevelByEnergyAndSoOn(configDataRiftLevelInfo, false);
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x00165A98 File Offset: 0x00163C98
		public bool IsFirstPassLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFirstPassLevelInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFirstPassLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.m_riftDS.FinishedRiftLevelIds.Contains(levelId);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x00165B28 File Offset: 0x00163D28
		public bool IsLevelFinished(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelFinishedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelFinishedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftDS.FinishedRiftLevelIds.Contains(levelId);
		}

		// Token: 0x0600483B RID: 18491 RVA: 0x00165BB8 File Offset: 0x00163DB8
		private int CanAttackLevelByEnergyAndSoOn(ConfigDataRiftLevelInfo levelInfo, bool isRaid)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataRiftLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataRiftLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isRaid
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_basicInfo.IsEnergyEnough(levelInfo.EnergySuccess))
			{
				return -402;
			}
			if (!this.IsEnoughAttackNums(levelInfo, 1))
			{
				return -801;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x0600483C RID: 18492 RVA: 0x00165C8C File Offset: 0x00163E8C
		public int GetAddRandomDropRewardExpectedSize(int randomDropId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAddRandomDropRewardExpectedSizeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAddRandomDropRewardExpectedSizeInt32_hotfix.call(new object[]
				{
					this,
					randomDropId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RandomDropRewardArea randomDropRewardArea;
			if (!this.m_configDataLoader.RandomDropData.Areas.TryGetValue(randomDropId, out randomDropRewardArea))
			{
				return 0;
			}
			int num = 0;
			foreach (RandomDropRewardGroup randomDropRewardGroup in randomDropRewardArea.groups)
			{
				num += randomDropRewardGroup.DropCount;
			}
			return num;
		}

		// Token: 0x0600483D RID: 18493 RVA: 0x00165D7C File Offset: 0x00163F7C
		public int CanUnLockLevel(int riftLevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnLockLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnLockLevelInt32_hotfix.call(new object[]
				{
					this,
					riftLevelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(riftLevelId);
			if (configDataRiftLevelInfo == null)
			{
				return -808;
			}
			if (this.m_riftDS.FinishedRiftLevelIds.Contains(riftLevelId))
			{
				return 0;
			}
			if (configDataRiftLevelInfo.PreLevel_ID != 0 && !this.m_unLockInfo.FinishedRiftLevelIds.Contains(configDataRiftLevelInfo.PreLevel_ID))
			{
				return -809;
			}
			if (this.m_basicInfo.GetLevel() < configDataRiftLevelInfo.PlayerLevel)
			{
				return -819;
			}
			foreach (RiftLevelInfoUnlockConditions riftLevelInfoUnlockConditions in configDataRiftLevelInfo.UnlockConditions)
			{
				switch (riftLevelInfoUnlockConditions.ConditionType)
				{
				case RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Scenario:
					if (riftLevelInfoUnlockConditions.Param1 != 0 && !this.m_level.IsScenarioCompleted(riftLevelInfoUnlockConditions.Param1))
					{
						return -807;
					}
					break;
				case RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Achievement:
					if (riftLevelInfoUnlockConditions.Param1 != 0 && !this.m_unLockInfo.GainRiftAchievementRelationIds.Contains(riftLevelInfoUnlockConditions.Param1))
					{
						return -810;
					}
					break;
				case RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Hero:
					if (riftLevelInfoUnlockConditions.Param1 != 0 && !this.m_unLockInfo.GainHeroIds.Contains(riftLevelInfoUnlockConditions.Param1))
					{
						return 811;
					}
					break;
				case RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_RiftLevel:
					if (riftLevelInfoUnlockConditions.Param1 != 0 && !this.m_unLockInfo.FinishedRiftLevelIds.Contains(riftLevelInfoUnlockConditions.Param1))
					{
						return -809;
					}
					break;
				}
			}
			return 0;
		}

		// Token: 0x0600483E RID: 18494 RVA: 0x00165FC4 File Offset: 0x001641C4
		private bool IsEnoughAttackNums(ConfigDataRiftLevelInfo levelInfo, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnoughAttackNumsConfigDataRiftLevelInfoInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnoughAttackNumsConfigDataRiftLevelInfoInt32_hotfix.call(new object[]
				{
					this,
					levelInfo,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevel riftLevel = this.m_riftDS.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			return riftLevel == null || this.m_riftDS.GetLevelChallengeNums(riftLevel) + nums <= this.GetRiftLevelCanChallengeMaxNums(levelInfo);
		}

		// Token: 0x0600483F RID: 18495 RVA: 0x0016608C File Offset: 0x0016428C
		public int GetRiftLevelCanChallengeMaxNums(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRiftLevelCanChallengeMaxNumsConfigDataRiftLevelInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRiftLevelCanChallengeMaxNumsConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return levelInfo.ChallengeCount + this.OperationalActivityChanllengenumsAdd;
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00166118 File Offset: 0x00164318
		public int CanRaidLevel(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanRaidLevelConfigDataRiftLevelInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanRaidLevelConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevel riftLevel = this.m_riftDS.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			if (riftLevel == null)
			{
				return -818;
			}
			if (riftLevel.Stars < this.m_configDataLoader.ConfigableConstId_RiftLevelMaxStar)
			{
				return -802;
			}
			return this.CanAttackLevelByEnergyAndSoOn(levelInfo, true);
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x001661DC File Offset: 0x001643DC
		public virtual void CompleteAchievement(int achievementRelationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CompleteAchievementInt32_hotfix != null)
			{
				this.m_CompleteAchievementInt32_hotfix.call(new object[]
				{
					this,
					achievementRelationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_riftDS.AddAchievementRelationId(achievementRelationId, this.m_basicInfo.GetCurrentTime());
			if (this.GetRiftLevelAchievementMissionEvent != null)
			{
				this.GetRiftLevelAchievementMissionEvent(achievementRelationId);
			}
		}

		// Token: 0x06004842 RID: 18498 RVA: 0x0016627C File Offset: 0x0016447C
		protected void AddRiftLevelBasicRewards(ConfigDataRiftLevelInfo riftLevelInfo, bool isRaid)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRiftLevelBasicRewardsConfigDataRiftLevelInfoBoolean_hotfix != null)
			{
				this.m_AddRiftLevelBasicRewardsConfigDataRiftLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					riftLevelInfo,
					isRaid
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.AddGold(riftLevelInfo.GoldReward, GameFunctionType.GameFunctionType_Rift, riftLevelInfo.ID.ToString());
			this.m_basicInfo.AddPlayerExp(riftLevelInfo.PlayerExpReward);
			if (!isRaid)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.m_battle.AddFightHeroFightNumsAndExp(pveTeam, riftLevelInfo.HeroExpReward);
			}
		}

		// Token: 0x06004843 RID: 18499 RVA: 0x0016635C File Offset: 0x0016455C
		public virtual void SetSuccessRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo, List<int> newAchievementIds, int stars, List<int> battleTreasures)
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
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.DecreaseEnergy(riftLevelInfo.EnergySuccess - riftLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_Rift, riftLevelInfo.ID.ToString());
			this.AddRiftLevelBasicRewards(riftLevelInfo, false);
			bool needAddStar = riftLevelInfo.LevelType != RiftLevelType.RiftLevelType_Event;
			this.SetLevel(riftLevelInfo.m_chapterId, riftLevelInfo.ID, 1, stars, needAddStar);
			foreach (int achievementRelationId in newAchievementIds)
			{
				this.CompleteAchievement(achievementRelationId);
			}
			if (newAchievementIds.Count != 0)
			{
				this.OnRiftAchivementAdd(newAchievementIds.Count);
			}
			List<int> pveTeam = this.m_battle.GetPveTeam();
			this.m_hero.AddHeroJobAchievementsAfterBattleLevelEnd(newAchievementIds, pveTeam);
			this.m_battle.WinPveBattle(riftLevelInfo.Battle_ID);
			this.ComplteRiftLevel(riftLevelInfo.ID);
			if (this.CompleteRiftLevelMissionEvent != null)
			{
				this.CompleteRiftLevelMissionEvent(BattleType.Rift, riftLevelInfo.ID, pveTeam);
			}
		}

		// Token: 0x06004844 RID: 18500 RVA: 0x00166524 File Offset: 0x00164724
		protected void SetRaidSuccessRiftLevel(ConfigDataRiftLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRaidSuccessRiftLevelConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_SetRaidSuccessRiftLevelConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.DecreaseEnergy(levelInfo.EnergySuccess, GameFunctionType.GameFunctionType_Rift, levelInfo.ID.ToString());
			this.AddRiftLevelBasicRewards(levelInfo, true);
			this.AddChallengeNums(levelInfo, 1);
			this.ComplteRiftLevel(levelInfo.ID);
			if (this.CompleteRiftLevelMissionEvent != null)
			{
				this.CompleteRiftLevelMissionEvent(BattleType.Rift, levelInfo.ID, null);
			}
		}

		// Token: 0x06004845 RID: 18501 RVA: 0x001665F8 File Offset: 0x001647F8
		public bool HasGotAchievementRelationId(int achievementId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasGotAchievementRelationIdInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasGotAchievementRelationIdInt32_hotfix.call(new object[]
				{
					this,
					achievementId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftDS.HasGotAchievementRelationId(achievementId);
		}

		// Token: 0x06004846 RID: 18502 RVA: 0x00166680 File Offset: 0x00164880
		protected List<Goods> GetChapterRewards(ConfigDataRiftChapterInfo chapterInfo, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChapterRewardsConfigDataRiftChapterInfoInt32_hotfix != null)
			{
				return (List<Goods>)this.m_GetChapterRewardsConfigDataRiftChapterInfoInt32_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> result;
			switch (index)
			{
			case 1:
				result = chapterInfo.Reward1;
				break;
			case 2:
				result = chapterInfo.Reward2;
				break;
			case 3:
				result = chapterInfo.Reward3;
				break;
			default:
				return null;
			}
			return result;
		}

		// Token: 0x06004847 RID: 18503 RVA: 0x00166750 File Offset: 0x00164950
		protected int CanGainChapterReward(ConfigDataRiftChapterInfo chapterInfo, int index, List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGainChapterRewardConfigDataRiftChapterInfoInt32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGainChapterRewardConfigDataRiftChapterInfoInt32List`1_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					index,
					rewards
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (index < 1 || index > 3)
			{
				return -825;
			}
			int chapterTotalStars = this.GetChapterTotalStars(chapterInfo.ID);
			if (chapterTotalStars == 0)
			{
				return -814;
			}
			if (this.m_riftDS.IsGainChapterStarReward(chapterInfo.ID, index))
			{
				return -804;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			int num = 0;
			if (index != 1)
			{
				if (index != 2)
				{
					if (index == 3)
					{
						num = chapterInfo.Reward3Star;
					}
				}
				else
				{
					num = chapterInfo.Reward2Star;
				}
			}
			else
			{
				num = chapterInfo.Reward1Star;
			}
			if (chapterTotalStars < num)
			{
				return -814;
			}
			return 0;
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0016689C File Offset: 0x00164A9C
		public int GetChapterTotalStars(int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChapterTotalStarsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetChapterTotalStarsInt32_hotfix.call(new object[]
				{
					this,
					chapterId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftDS.GetChapterTotalStars(chapterId);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x00166924 File Offset: 0x00164B24
		public int GetAllRiftLevelStars()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllRiftLevelStars_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAllRiftLevelStars_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftDS.GetAllRiftLevelStars();
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x0016699C File Offset: 0x00164B9C
		protected virtual void ComplteRiftLevel(int riftLevelId)
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
			if (this.RiftLevelCompleteEvent != null)
			{
				this.RiftLevelCompleteEvent(riftLevelId);
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x0600484B RID: 18507 RVA: 0x00166A24 File Offset: 0x00164C24
		// (set) Token: 0x0600484C RID: 18508 RVA: 0x00166A98 File Offset: 0x00164C98
		public bool HasRewardAddRelativeOperationalActivity
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HasRewardAddRelativeOperationalActivity_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_HasRewardAddRelativeOperationalActivity_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HasRewardAddRelativeOperationalActivity>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix != null)
				{
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HasRewardAddRelativeOperationalActivity>k__BackingField = value;
			}
		}

		// Token: 0x0600484D RID: 18509 RVA: 0x00166B10 File Offset: 0x00164D10
		protected virtual void OnAllRiftLevelStarAdd(int addStar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAllRiftLevelStarAddInt32_hotfix != null)
			{
				this.m_OnAllRiftLevelStarAddInt32_hotfix.call(new object[]
				{
					this,
					addStar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600484E RID: 18510 RVA: 0x00166B80 File Offset: 0x00164D80
		protected virtual void OnRiftAchivementAdd(int addAchivement)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRiftAchivementAddInt32_hotfix != null)
			{
				this.m_OnRiftAchivementAddInt32_hotfix.call(new object[]
				{
					this,
					addAchivement
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600484F RID: 18511 RVA: 0x00166BF0 File Offset: 0x00164DF0
		// (remove) Token: 0x06004850 RID: 18512 RVA: 0x00166C8C File Offset: 0x00164E8C
		public event Action<BattleType, int, List<int>> CompleteRiftLevelMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteRiftLevelMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteRiftLevelMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteRiftLevelMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteRiftLevelMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteRiftLevelMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteRiftLevelMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteRiftLevelMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteRiftLevelMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06004851 RID: 18513 RVA: 0x00166D28 File Offset: 0x00164F28
		// (remove) Token: 0x06004852 RID: 18514 RVA: 0x00166DC4 File Offset: 0x00164FC4
		public event Action<int> GetRiftLevelAchievementMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_GetRiftLevelAchievementMissionEventAction`1_hotfix != null)
				{
					this.m_add_GetRiftLevelAchievementMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.GetRiftLevelAchievementMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.GetRiftLevelAchievementMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_GetRiftLevelAchievementMissionEventAction`1_hotfix != null)
				{
					this.m_remove_GetRiftLevelAchievementMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.GetRiftLevelAchievementMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.GetRiftLevelAchievementMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06004853 RID: 18515 RVA: 0x00166E60 File Offset: 0x00165060
		// (remove) Token: 0x06004854 RID: 18516 RVA: 0x00166EFC File Offset: 0x001650FC
		public event Action<int> GetRiftLevelFightStarMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_GetRiftLevelFightStarMissionEventAction`1_hotfix != null)
				{
					this.m_add_GetRiftLevelFightStarMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.GetRiftLevelFightStarMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.GetRiftLevelFightStarMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_GetRiftLevelFightStarMissionEventAction`1_hotfix != null)
				{
					this.m_remove_GetRiftLevelFightStarMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.GetRiftLevelFightStarMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.GetRiftLevelFightStarMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06004855 RID: 18517 RVA: 0x00166F98 File Offset: 0x00165198
		// (set) Token: 0x06004856 RID: 18518 RVA: 0x0016700C File Offset: 0x0016520C
		public int OperationalActivityChanllengenumsAdd
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_OperationalActivityChanllengenumsAdd_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_OperationalActivityChanllengenumsAdd_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<OperationalActivityChanllengenumsAdd>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OperationalActivityChanllengenumsAddInt32_hotfix != null)
				{
					this.m_set_OperationalActivityChanllengenumsAddInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<OperationalActivityChanllengenumsAdd>k__BackingField = value;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x00167084 File Offset: 0x00165284
		// (set) Token: 0x06004858 RID: 18520 RVA: 0x001670A4 File Offset: 0x001652A4
		[DoNotToLua]
		public RiftComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x001670B0 File Offset: 0x001652B0
		private void __callDele_CompleteRiftLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeRiftLevelMissionEvent = this.CompleteRiftLevelMissionEvent;
			if (completeRiftLevelMissionEvent != null)
			{
				completeRiftLevelMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x001670D4 File Offset: 0x001652D4
		private void __clearDele_CompleteRiftLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteRiftLevelMissionEvent = null;
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x001670E0 File Offset: 0x001652E0
		private void __callDele_GetRiftLevelAchievementMissionEvent(int obj)
		{
			Action<int> getRiftLevelAchievementMissionEvent = this.GetRiftLevelAchievementMissionEvent;
			if (getRiftLevelAchievementMissionEvent != null)
			{
				getRiftLevelAchievementMissionEvent(obj);
			}
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x00167104 File Offset: 0x00165304
		private void __clearDele_GetRiftLevelAchievementMissionEvent(int obj)
		{
			this.GetRiftLevelAchievementMissionEvent = null;
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00167110 File Offset: 0x00165310
		private void __callDele_GetRiftLevelFightStarMissionEvent(int obj)
		{
			Action<int> getRiftLevelFightStarMissionEvent = this.GetRiftLevelFightStarMissionEvent;
			if (getRiftLevelFightStarMissionEvent != null)
			{
				getRiftLevelFightStarMissionEvent(obj);
			}
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x00167134 File Offset: 0x00165334
		private void __clearDele_GetRiftLevelFightStarMissionEvent(int obj)
		{
			this.GetRiftLevelFightStarMissionEvent = null;
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x00167140 File Offset: 0x00165340
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_OnFlushChallengeCountEvent_hotfix = (luaObj.RawGet("OnFlushChallengeCountEvent") as LuaFunction);
					this.m_AddChallengeNumsConfigDataRiftLevelInfoInt32_hotfix = (luaObj.RawGet("AddChallengeNums") as LuaFunction);
					this.m_ResetLevelChallengeNums_hotfix = (luaObj.RawGet("ResetLevelChallengeNums") as LuaFunction);
					this.m_GetAllRiftLevelAchievements_hotfix = (luaObj.RawGet("GetAllRiftLevelAchievements") as LuaFunction);
					this.m_AttackLevelInt32_hotfix = (luaObj.RawGet("AttackLevel") as LuaFunction);
					this.m_SetLevelInt32Int32Int32Int32Boolean_hotfix = (luaObj.RawGet("SetLevel") as LuaFunction);
					this.m_AddChapterTotalStarRiftChapterInt32_hotfix = (luaObj.RawGet("AddChapterTotalStar") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_CanAttackLevelInt32_hotfix = (luaObj.RawGet("CanAttackLevel") as LuaFunction);
					this.m_IsFirstPassLevelInt32_hotfix = (luaObj.RawGet("IsFirstPassLevel") as LuaFunction);
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataRiftLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_GetAddRandomDropRewardExpectedSizeInt32_hotfix = (luaObj.RawGet("GetAddRandomDropRewardExpectedSize") as LuaFunction);
					this.m_CanUnLockLevelInt32_hotfix = (luaObj.RawGet("CanUnLockLevel") as LuaFunction);
					this.m_IsEnoughAttackNumsConfigDataRiftLevelInfoInt32_hotfix = (luaObj.RawGet("IsEnoughAttackNums") as LuaFunction);
					this.m_GetRiftLevelCanChallengeMaxNumsConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("GetRiftLevelCanChallengeMaxNums") as LuaFunction);
					this.m_CanRaidLevelConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("CanRaidLevel") as LuaFunction);
					this.m_CompleteAchievementInt32_hotfix = (luaObj.RawGet("CompleteAchievement") as LuaFunction);
					this.m_AddRiftLevelBasicRewardsConfigDataRiftLevelInfoBoolean_hotfix = (luaObj.RawGet("AddRiftLevelBasicRewards") as LuaFunction);
					this.m_SetSuccessRiftLevelConfigDataRiftLevelInfoList`1Int32List`1_hotfix = (luaObj.RawGet("SetSuccessRiftLevel") as LuaFunction);
					this.m_SetRaidSuccessRiftLevelConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("SetRaidSuccessRiftLevel") as LuaFunction);
					this.m_HasGotAchievementRelationIdInt32_hotfix = (luaObj.RawGet("HasGotAchievementRelationId") as LuaFunction);
					this.m_GetChapterRewardsConfigDataRiftChapterInfoInt32_hotfix = (luaObj.RawGet("GetChapterRewards") as LuaFunction);
					this.m_CanGainChapterRewardConfigDataRiftChapterInfoInt32List`1_hotfix = (luaObj.RawGet("CanGainChapterReward") as LuaFunction);
					this.m_GetChapterTotalStarsInt32_hotfix = (luaObj.RawGet("GetChapterTotalStars") as LuaFunction);
					this.m_GetAllRiftLevelStars_hotfix = (luaObj.RawGet("GetAllRiftLevelStars") as LuaFunction);
					this.m_ComplteRiftLevelInt32_hotfix = (luaObj.RawGet("ComplteRiftLevel") as LuaFunction);
					this.m_get_HasRewardAddRelativeOperationalActivity_hotfix = (luaObj.RawGet("get_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix = (luaObj.RawGet("set_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_OnAllRiftLevelStarAddInt32_hotfix = (luaObj.RawGet("OnAllRiftLevelStarAdd") as LuaFunction);
					this.m_OnRiftAchivementAddInt32_hotfix = (luaObj.RawGet("OnRiftAchivementAdd") as LuaFunction);
					this.m_add_CompleteRiftLevelMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteRiftLevelMissionEvent") as LuaFunction);
					this.m_remove_CompleteRiftLevelMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteRiftLevelMissionEvent") as LuaFunction);
					this.m_add_GetRiftLevelAchievementMissionEventAction`1_hotfix = (luaObj.RawGet("add_GetRiftLevelAchievementMissionEvent") as LuaFunction);
					this.m_remove_GetRiftLevelAchievementMissionEventAction`1_hotfix = (luaObj.RawGet("remove_GetRiftLevelAchievementMissionEvent") as LuaFunction);
					this.m_add_GetRiftLevelFightStarMissionEventAction`1_hotfix = (luaObj.RawGet("add_GetRiftLevelFightStarMissionEvent") as LuaFunction);
					this.m_remove_GetRiftLevelFightStarMissionEventAction`1_hotfix = (luaObj.RawGet("remove_GetRiftLevelFightStarMissionEvent") as LuaFunction);
					this.m_get_OperationalActivityChanllengenumsAdd_hotfix = (luaObj.RawGet("get_OperationalActivityChanllengenumsAdd") as LuaFunction);
					this.m_set_OperationalActivityChanllengenumsAddInt32_hotfix = (luaObj.RawGet("set_OperationalActivityChanllengenumsAdd") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x001676D4 File Offset: 0x001658D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400369A RID: 13978
		public Action<int> RiftLevelCompleteEvent;

		// Token: 0x0400369B RID: 13979
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x0400369F RID: 13983
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040036A0 RID: 13984
		protected LevelComponentCommon m_level;

		// Token: 0x040036A1 RID: 13985
		protected HeroComponentCommon m_hero;

		// Token: 0x040036A2 RID: 13986
		protected BagComponentCommon m_bag;

		// Token: 0x040036A3 RID: 13987
		protected BattleComponentCommon m_battle;

		// Token: 0x040036A4 RID: 13988
		protected DataSectionRift m_riftDS = new DataSectionRift();

		// Token: 0x040036A5 RID: 13989
		public RiftLevelUnLockInfo m_unLockInfo = new RiftLevelUnLockInfo();

		// Token: 0x040036A7 RID: 13991
		[DoNotToLua]
		private RiftComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040036A8 RID: 13992
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040036A9 RID: 13993
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040036AA RID: 13994
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040036AB RID: 13995
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040036AC RID: 13996
		private LuaFunction m_Init_hotfix;

		// Token: 0x040036AD RID: 13997
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040036AE RID: 13998
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040036AF RID: 13999
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040036B0 RID: 14000
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040036B1 RID: 14001
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040036B2 RID: 14002
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040036B3 RID: 14003
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040036B4 RID: 14004
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040036B5 RID: 14005
		private LuaFunction m_OnFlushChallengeCountEvent_hotfix;

		// Token: 0x040036B6 RID: 14006
		private LuaFunction m_AddChallengeNumsConfigDataRiftLevelInfoInt32_hotfix;

		// Token: 0x040036B7 RID: 14007
		private LuaFunction m_ResetLevelChallengeNums_hotfix;

		// Token: 0x040036B8 RID: 14008
		private LuaFunction m_GetAllRiftLevelAchievements_hotfix;

		// Token: 0x040036B9 RID: 14009
		private LuaFunction m_AttackLevelInt32_hotfix;

		// Token: 0x040036BA RID: 14010
		private LuaFunction m_SetLevelInt32Int32Int32Int32Boolean_hotfix;

		// Token: 0x040036BB RID: 14011
		private LuaFunction m_AddChapterTotalStarRiftChapterInt32_hotfix;

		// Token: 0x040036BC RID: 14012
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x040036BD RID: 14013
		private LuaFunction m_CanAttackLevelInt32_hotfix;

		// Token: 0x040036BE RID: 14014
		private LuaFunction m_IsFirstPassLevelInt32_hotfix;

		// Token: 0x040036BF RID: 14015
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x040036C0 RID: 14016
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataRiftLevelInfoBoolean_hotfix;

		// Token: 0x040036C1 RID: 14017
		private LuaFunction m_GetAddRandomDropRewardExpectedSizeInt32_hotfix;

		// Token: 0x040036C2 RID: 14018
		private LuaFunction m_CanUnLockLevelInt32_hotfix;

		// Token: 0x040036C3 RID: 14019
		private LuaFunction m_IsEnoughAttackNumsConfigDataRiftLevelInfoInt32_hotfix;

		// Token: 0x040036C4 RID: 14020
		private LuaFunction m_GetRiftLevelCanChallengeMaxNumsConfigDataRiftLevelInfo_hotfix;

		// Token: 0x040036C5 RID: 14021
		private LuaFunction m_CanRaidLevelConfigDataRiftLevelInfo_hotfix;

		// Token: 0x040036C6 RID: 14022
		private LuaFunction m_CompleteAchievementInt32_hotfix;

		// Token: 0x040036C7 RID: 14023
		private LuaFunction m_AddRiftLevelBasicRewardsConfigDataRiftLevelInfoBoolean_hotfix;

		// Token: 0x040036C8 RID: 14024
		private LuaFunction m_SetSuccessRiftLevelConfigDataRiftLevelInfoList`1Int32List;

		// Token: 0x040036C9 RID: 14025
		private LuaFunction m_SetRaidSuccessRiftLevelConfigDataRiftLevelInfo_hotfix;

		// Token: 0x040036CA RID: 14026
		private LuaFunction m_HasGotAchievementRelationIdInt32_hotfix;

		// Token: 0x040036CB RID: 14027
		private LuaFunction m_GetChapterRewardsConfigDataRiftChapterInfoInt32_hotfix;

		// Token: 0x040036CC RID: 14028
		private LuaFunction m_CanGainChapterRewardConfigDataRiftChapterInfoInt32List;

		// Token: 0x040036CD RID: 14029
		private LuaFunction m_GetChapterTotalStarsInt32_hotfix;

		// Token: 0x040036CE RID: 14030
		private LuaFunction m_GetAllRiftLevelStars_hotfix;

		// Token: 0x040036CF RID: 14031
		private LuaFunction m_ComplteRiftLevelInt32_hotfix;

		// Token: 0x040036D0 RID: 14032
		private LuaFunction m_get_HasRewardAddRelativeOperationalActivity_hotfix;

		// Token: 0x040036D1 RID: 14033
		private LuaFunction m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix;

		// Token: 0x040036D2 RID: 14034
		private LuaFunction m_OnAllRiftLevelStarAddInt32_hotfix;

		// Token: 0x040036D3 RID: 14035
		private LuaFunction m_OnRiftAchivementAddInt32_hotfix;

		// Token: 0x040036D4 RID: 14036
		private LuaFunction m_add_CompleteRiftLevelMissionEventAction;

		// Token: 0x040036D5 RID: 14037
		private LuaFunction m_remove_CompleteRiftLevelMissionEventAction;

		// Token: 0x040036D6 RID: 14038
		private LuaFunction m_add_GetRiftLevelAchievementMissionEventAction;

		// Token: 0x040036D7 RID: 14039
		private LuaFunction m_remove_GetRiftLevelAchievementMissionEventAction;

		// Token: 0x040036D8 RID: 14040
		private LuaFunction m_add_GetRiftLevelFightStarMissionEventAction;

		// Token: 0x040036D9 RID: 14041
		private LuaFunction m_remove_GetRiftLevelFightStarMissionEventAction;

		// Token: 0x040036DA RID: 14042
		private LuaFunction m_get_OperationalActivityChanllengenumsAdd_hotfix;

		// Token: 0x040036DB RID: 14043
		private LuaFunction m_set_OperationalActivityChanllengenumsAddInt32_hotfix;

		// Token: 0x020004A7 RID: 1191
		public class LuaExportHelper
		{
			// Token: 0x06004861 RID: 18529 RVA: 0x0016773C File Offset: 0x0016593C
			public LuaExportHelper(RiftComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004862 RID: 18530 RVA: 0x0016774C File Offset: 0x0016594C
			public void __callDele_CompleteRiftLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteRiftLevelMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004863 RID: 18531 RVA: 0x0016775C File Offset: 0x0016595C
			public void __clearDele_CompleteRiftLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteRiftLevelMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004864 RID: 18532 RVA: 0x0016776C File Offset: 0x0016596C
			public void __callDele_GetRiftLevelAchievementMissionEvent(int obj)
			{
				this.m_owner.__callDele_GetRiftLevelAchievementMissionEvent(obj);
			}

			// Token: 0x06004865 RID: 18533 RVA: 0x0016777C File Offset: 0x0016597C
			public void __clearDele_GetRiftLevelAchievementMissionEvent(int obj)
			{
				this.m_owner.__clearDele_GetRiftLevelAchievementMissionEvent(obj);
			}

			// Token: 0x06004866 RID: 18534 RVA: 0x0016778C File Offset: 0x0016598C
			public void __callDele_GetRiftLevelFightStarMissionEvent(int obj)
			{
				this.m_owner.__callDele_GetRiftLevelFightStarMissionEvent(obj);
			}

			// Token: 0x06004867 RID: 18535 RVA: 0x0016779C File Offset: 0x0016599C
			public void __clearDele_GetRiftLevelFightStarMissionEvent(int obj)
			{
				this.m_owner.__clearDele_GetRiftLevelFightStarMissionEvent(obj);
			}

			// Token: 0x17001211 RID: 4625
			// (get) Token: 0x06004868 RID: 18536 RVA: 0x001677AC File Offset: 0x001659AC
			// (set) Token: 0x06004869 RID: 18537 RVA: 0x001677BC File Offset: 0x001659BC
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17001212 RID: 4626
			// (get) Token: 0x0600486A RID: 18538 RVA: 0x001677CC File Offset: 0x001659CC
			// (set) Token: 0x0600486B RID: 18539 RVA: 0x001677DC File Offset: 0x001659DC
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001213 RID: 4627
			// (get) Token: 0x0600486C RID: 18540 RVA: 0x001677EC File Offset: 0x001659EC
			// (set) Token: 0x0600486D RID: 18541 RVA: 0x001677FC File Offset: 0x001659FC
			public LevelComponentCommon m_level
			{
				get
				{
					return this.m_owner.m_level;
				}
				set
				{
					this.m_owner.m_level = value;
				}
			}

			// Token: 0x17001214 RID: 4628
			// (get) Token: 0x0600486E RID: 18542 RVA: 0x0016780C File Offset: 0x00165A0C
			// (set) Token: 0x0600486F RID: 18543 RVA: 0x0016781C File Offset: 0x00165A1C
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001215 RID: 4629
			// (get) Token: 0x06004870 RID: 18544 RVA: 0x0016782C File Offset: 0x00165A2C
			// (set) Token: 0x06004871 RID: 18545 RVA: 0x0016783C File Offset: 0x00165A3C
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x17001216 RID: 4630
			// (get) Token: 0x06004872 RID: 18546 RVA: 0x0016784C File Offset: 0x00165A4C
			// (set) Token: 0x06004873 RID: 18547 RVA: 0x0016785C File Offset: 0x00165A5C
			public BattleComponentCommon m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x17001217 RID: 4631
			// (get) Token: 0x06004874 RID: 18548 RVA: 0x0016786C File Offset: 0x00165A6C
			// (set) Token: 0x06004875 RID: 18549 RVA: 0x0016787C File Offset: 0x00165A7C
			public DataSectionRift m_riftDS
			{
				get
				{
					return this.m_owner.m_riftDS;
				}
				set
				{
					this.m_owner.m_riftDS = value;
				}
			}

			// Token: 0x06004876 RID: 18550 RVA: 0x0016788C File Offset: 0x00165A8C
			public void OnFlushChallengeCountEvent()
			{
				this.m_owner.OnFlushChallengeCountEvent();
			}

			// Token: 0x06004877 RID: 18551 RVA: 0x0016789C File Offset: 0x00165A9C
			public void SetLevel(int chapterId, int levelId, int nums, int stars, bool needAddStar)
			{
				this.m_owner.SetLevel(chapterId, levelId, nums, stars, needAddStar);
			}

			// Token: 0x06004878 RID: 18552 RVA: 0x001678B0 File Offset: 0x00165AB0
			public void AddChapterTotalStar(RiftChapter chapter, int addStar)
			{
				this.m_owner.AddChapterTotalStar(chapter, addStar);
			}

			// Token: 0x06004879 RID: 18553 RVA: 0x001678C0 File Offset: 0x00165AC0
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x0600487A RID: 18554 RVA: 0x001678D0 File Offset: 0x00165AD0
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataRiftLevelInfo levelInfo, bool isRaid)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo, isRaid);
			}

			// Token: 0x0600487B RID: 18555 RVA: 0x001678E0 File Offset: 0x00165AE0
			public bool IsEnoughAttackNums(ConfigDataRiftLevelInfo levelInfo, int nums)
			{
				return this.m_owner.IsEnoughAttackNums(levelInfo, nums);
			}

			// Token: 0x0600487C RID: 18556 RVA: 0x001678F0 File Offset: 0x00165AF0
			public void AddRiftLevelBasicRewards(ConfigDataRiftLevelInfo riftLevelInfo, bool isRaid)
			{
				this.m_owner.AddRiftLevelBasicRewards(riftLevelInfo, isRaid);
			}

			// Token: 0x0600487D RID: 18557 RVA: 0x00167900 File Offset: 0x00165B00
			public void SetRaidSuccessRiftLevel(ConfigDataRiftLevelInfo levelInfo)
			{
				this.m_owner.SetRaidSuccessRiftLevel(levelInfo);
			}

			// Token: 0x0600487E RID: 18558 RVA: 0x00167910 File Offset: 0x00165B10
			public List<Goods> GetChapterRewards(ConfigDataRiftChapterInfo chapterInfo, int index)
			{
				return this.m_owner.GetChapterRewards(chapterInfo, index);
			}

			// Token: 0x0600487F RID: 18559 RVA: 0x00167920 File Offset: 0x00165B20
			public int CanGainChapterReward(ConfigDataRiftChapterInfo chapterInfo, int index, List<Goods> rewards)
			{
				return this.m_owner.CanGainChapterReward(chapterInfo, index, rewards);
			}

			// Token: 0x06004880 RID: 18560 RVA: 0x00167930 File Offset: 0x00165B30
			public void ComplteRiftLevel(int riftLevelId)
			{
				this.m_owner.ComplteRiftLevel(riftLevelId);
			}

			// Token: 0x06004881 RID: 18561 RVA: 0x00167940 File Offset: 0x00165B40
			public void OnAllRiftLevelStarAdd(int addStar)
			{
				this.m_owner.OnAllRiftLevelStarAdd(addStar);
			}

			// Token: 0x06004882 RID: 18562 RVA: 0x00167950 File Offset: 0x00165B50
			public void OnRiftAchivementAdd(int addAchivement)
			{
				this.m_owner.OnRiftAchivementAdd(addAchivement);
			}

			// Token: 0x040036DC RID: 14044
			private RiftComponentCommon m_owner;
		}
	}
}
