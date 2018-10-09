using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000477 RID: 1143
	[HotFix]
	public class HeroDungeonComponentCommon : IComponentBase
	{
		// Token: 0x060042E5 RID: 17125 RVA: 0x0013F990 File Offset: 0x0013DB90
		public HeroDungeonComponentCommon()
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

		// Token: 0x060042E6 RID: 17126 RVA: 0x0013F9F8 File Offset: 0x0013DBF8
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
			return "HeroDungeon";
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x0013FA6C File Offset: 0x0013DC6C
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
			this.m_heroDungeonDS = new DataSectionHeroDungeon();
			this.OperationalActivityChanllengenumsAdd = 0;
			this.HasRewardAddRelativeOperationalActivity = false;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x0013FAE8 File Offset: 0x0013DCE8
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushLevelChallengeNumsEvent;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x0013FBE8 File Offset: 0x0013DDE8
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

		// Token: 0x060042EA RID: 17130 RVA: 0x0013FC48 File Offset: 0x0013DE48
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

		// Token: 0x060042EB RID: 17131 RVA: 0x0013FCB8 File Offset: 0x0013DEB8
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

		// Token: 0x060042EC RID: 17132 RVA: 0x0013FD38 File Offset: 0x0013DF38
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

		// Token: 0x060042ED RID: 17133 RVA: 0x0013FDA8 File Offset: 0x0013DFA8
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

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0013FE08 File Offset: 0x0013E008
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x0013FE7C File Offset: 0x0013E07C
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

		// Token: 0x060042F0 RID: 17136 RVA: 0x0013FEF4 File Offset: 0x0013E0F4
		private void OnFlushLevelChallengeNumsEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushLevelChallengeNumsEvent_hotfix != null)
			{
				this.m_OnFlushLevelChallengeNumsEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDungeonDS.ResetLevelChallengeNums();
			this.m_heroDungeonDS.SetDailyChallengeNums(0);
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x0013FF6C File Offset: 0x0013E16C
		public bool HasGotAchievementRelationId(int achievementRelationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasGotAchievementRelationIdInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasGotAchievementRelationIdInt32_hotfix.call(new object[]
				{
					this,
					achievementRelationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDungeonDS.HasGotAchievementRelationId(achievementRelationId);
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x0013FFF4 File Offset: 0x0013E1F4
		public bool IsLevelFirstPass(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelFirstPassInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelFirstPassInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.IsFinishedLevel(levelId);
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x0014007C File Offset: 0x0013E27C
		public bool IsFinishedLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFinishedLevelInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFinishedLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDungeonDS.IsFinishedLevel(levelId);
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00140104 File Offset: 0x0013E304
		private bool IsEnoughAttackNums(ConfigDataHeroDungeonLevelInfo levelInfo, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnoughAttackNumsConfigDataHeroDungeonLevelInfoInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnoughAttackNumsConfigDataHeroDungeonLevelInfoInt32_hotfix.call(new object[]
				{
					this,
					levelInfo,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDungeonLevel heroDungeonLevel = this.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			return heroDungeonLevel == null || heroDungeonLevel.Nums + nums <= this.GetLevelCanChallengeMaxNums(levelInfo);
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x001401C0 File Offset: 0x0013E3C0
		public int GetLevelCanChallengeMaxNums(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelCanChallengeMaxNumsConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLevelCanChallengeMaxNumsConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return levelInfo.ChallengeCount;
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00140244 File Offset: 0x0013E444
		public int GetDailyChallengeMaxNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDailyChallengeMaxNums_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDailyChallengeMaxNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_configDataLoader.ConfigableConstId_HeroDungeonDailyChallengeMaxNums + this.OperationalActivityChanllengenumsAdd - this.m_heroDungeonDS.DailyChallengeNums;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x001402D0 File Offset: 0x0013E4D0
		protected void InitLevel(int chapterId, int levelId, int stars, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLevelInt32Int32Int32Int32_hotfix != null)
			{
				this.m_InitLevelInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					levelId,
					stars,
					nums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDungeonChapter heroDungeonChapter = this.m_heroDungeonDS.FindChapter(chapterId);
			if (heroDungeonChapter == null)
			{
				heroDungeonChapter = this.m_heroDungeonDS.AddChapter(chapterId);
			}
			this.m_heroDungeonDS.InitLevel(heroDungeonChapter, levelId, stars, nums);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x001403A0 File Offset: 0x0013E5A0
		protected void SetLevel(int chapterId, int LevelId, int stars, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInt32Int32Int32Int32_hotfix != null)
			{
				this.m_SetLevelInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					LevelId,
					stars,
					nums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDungeonChapter heroDungeonChapter = this.m_heroDungeonDS.FindChapter(chapterId);
			if (heroDungeonChapter == null)
			{
				heroDungeonChapter = this.m_heroDungeonDS.AddChapter(chapterId);
			}
			HeroDungeonLevel heroDungeonLevel = this.FindLevel(chapterId, LevelId);
			if (heroDungeonLevel == null)
			{
				this.m_heroDungeonDS.AddLevel(heroDungeonChapter, LevelId, stars, nums);
			}
			else
			{
				if (stars == 0)
				{
					return;
				}
				if (this.IsLevelFirstPass(LevelId))
				{
					this.m_heroDungeonDS.FinishedLevel(LevelId);
				}
				heroDungeonLevel.Nums += nums;
				int num = stars - heroDungeonLevel.Stars;
				if (num > 0)
				{
					heroDungeonLevel.Stars = stars;
					heroDungeonChapter.TotalStars += num;
				}
				this.m_heroDungeonDS.SetDirty(true);
			}
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x001404E4 File Offset: 0x0013E6E4
		public HeroDungeonLevel FindLevel(int chapterId, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindLevelInt32Int32_hotfix != null)
			{
				return (HeroDungeonLevel)this.m_FindLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					levelId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroDungeonDS.FindLevel(chapterId, levelId);
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x00140580 File Offset: 0x0013E780
		public int AttackHeroDungeonLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackHeroDungeonLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackHeroDungeonLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackHeroDungeonLevel(levelId);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataHeroDungeonLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_HeroDungeon, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.HeroDungeon, levelId);
			this.SetLevel(configDataHeroDungeonLevelInfo.m_chapterId, levelId, 0, 0);
			return 0;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00140670 File Offset: 0x0013E870
		protected virtual void SetSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo, List<int> newGotAchievementRelationInds, int stars, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List`1_hotfix != null)
			{
				this.m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List`1_hotfix.call(new object[]
				{
					this,
					levelInfo,
					newGotAchievementRelationInds,
					stars,
					battleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.DecreaseEnergy(levelInfo.EnergySuccess - levelInfo.EnergyFail, GameFunctionType.GameFunctionType_HeroDungeon, levelInfo.ID.ToString());
			this.m_basicInfo.AddGold(levelInfo.GoldReward, GameFunctionType.GameFunctionType_HeroDungeon, levelInfo.ID.ToString());
			this.m_basicInfo.AddPlayerExp(levelInfo.PlayerExpReward);
			List<int> pveTeam = this.m_battle.GetPveTeam();
			this.m_battle.AddFightHeroFightNumsAndExp(pveTeam, levelInfo.HeroExpReward);
			this.SetLevel(levelInfo.m_chapterId, levelInfo.ID, stars, 1);
			foreach (int achievementRelationId in newGotAchievementRelationInds)
			{
				this.m_heroDungeonDS.AddAchievementRelationId(achievementRelationId);
			}
			this.m_hero.AddHeroJobAchievementsAfterBattleLevelEnd(newGotAchievementRelationInds, pveTeam);
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			HeroDungeonLevel heroDungeonLevel = this.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			this.m_heroDungeonDS.AddDailyChallengeNums(1);
			if (this.CompleteHeroDungeonLevelMissionEvent != null)
			{
				this.CompleteHeroDungeonLevelMissionEvent(BattleType.HeroDungeon, levelInfo.ID, pveTeam);
			}
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x00140864 File Offset: 0x0013EA64
		protected void SetRaidSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRaidSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_SetRaidSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.DecreaseEnergy(levelInfo.EnergySuccess, GameFunctionType.GameFunctionType_HeroDungeon, levelInfo.ID.ToString());
			this.m_basicInfo.AddGold(levelInfo.GoldReward, GameFunctionType.GameFunctionType_HeroDungeon, levelInfo.ID.ToString());
			this.m_basicInfo.AddPlayerExp(levelInfo.PlayerExpReward);
			HeroDungeonLevel level = this.FindLevel(levelInfo.m_chapterId, levelInfo.ID);
			this.m_heroDungeonDS.AddHeroDungeonLevelChallengeNums(level, 1);
			this.m_heroDungeonDS.AddDailyChallengeNums(1);
			if (this.CompleteHeroDungeonLevelMissionEvent != null)
			{
				this.CompleteHeroDungeonLevelMissionEvent(BattleType.HeroDungeon, levelInfo.ID, null);
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00140980 File Offset: 0x0013EB80
		public virtual int CanAttackHeroDungeonLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackHeroDungeonLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackHeroDungeonLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Fetters))
			{
				return -2916;
			}
			if (!this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroDungeon))
			{
				return -2914;
			}
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
			if (configDataHeroDungeonLevelInfo == null)
			{
				return -2900;
			}
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = this.m_configDataLoader.GetConfigDataHeroInformationInfo(configDataHeroDungeonLevelInfo.m_chapterId);
			if (configDataHeroInformationInfo == null || !configDataHeroInformationInfo.IsDungeonLevelsUnLock)
			{
				return -2914;
			}
			if (configDataHeroDungeonLevelInfo.m_battleInfo == null)
			{
				return -2904;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			int num = this.CanUnlockHeroDungeonLevel(levelId);
			if (num != 0)
			{
				return num;
			}
			return this.CanAttackLevelByEnergyAndSoOn(configDataHeroDungeonLevelInfo, false);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00140AB0 File Offset: 0x0013ECB0
		public int CanRaidHeroDungeonLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanRaidHeroDungeonLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanRaidHeroDungeonLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
			if (configDataHeroDungeonLevelInfo == null)
			{
				return -2900;
			}
			HeroDungeonLevel heroDungeonLevel = this.FindLevel(configDataHeroDungeonLevelInfo.m_chapterId, levelId);
			if (heroDungeonLevel == null)
			{
				return -2906;
			}
			if (heroDungeonLevel.Stars < this.m_configDataLoader.ConfigableConstId_HeroDungeonLevelMaxStar)
			{
				return -2907;
			}
			return this.CanAttackLevelByEnergyAndSoOn(configDataHeroDungeonLevelInfo, true);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00140B84 File Offset: 0x0013ED84
		private int CanAttackLevelByEnergyAndSoOn(ConfigDataHeroDungeonLevelInfo levelInfo, bool isRaid)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataHeroDungeonLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataHeroDungeonLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isRaid
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int dailyChallengeMaxNums = this.GetDailyChallengeMaxNums();
			if (dailyChallengeMaxNums <= 0)
			{
				return -2917;
			}
			if (!this.IsEnoughAttackNums(levelInfo, 1))
			{
				return -2905;
			}
			if (!this.m_basicInfo.IsEnergyEnough(levelInfo.EnergySuccess))
			{
				return -402;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00140C6C File Offset: 0x0013EE6C
		private int CanAttackLevelByRewards(ConfigDataHeroDungeonLevelInfo levelInfo, bool isRaid)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByRewardsConfigDataHeroDungeonLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByRewardsConfigDataHeroDungeonLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isRaid
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> list = new List<Goods>();
			if (isRaid)
			{
				list.AddRange(levelInfo.RaidReward);
			}
			else if (this.IsLevelFirstPass(levelInfo.ID))
			{
				list.AddRange(levelInfo.FirstReward);
			}
			else
			{
				list.AddRange(levelInfo.AchievementReward1);
				list.AddRange(levelInfo.AchievementReward2);
				list.AddRange(levelInfo.AchievementReward3);
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00140D74 File Offset: 0x0013EF74
		public int CanUnlockHeroDungeonLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanUnlockHeroDungeonLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanUnlockHeroDungeonLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
			if (configDataHeroDungeonLevelInfo == null)
			{
				return -2900;
			}
			foreach (HeroDungeonLevelUnlcokCondition heroDungeonLevelUnlcokCondition in configDataHeroDungeonLevelInfo.UnlockConditions)
			{
				HeroDungeonLevellUnlockConditionType conditionType = heroDungeonLevelUnlcokCondition.ConditionType;
				if (conditionType != HeroDungeonLevellUnlockConditionType.HeroDungeonLevellUnlockConditionType_HeroFavorabilityLevel)
				{
					return -2902;
				}
				Hero hero = this.m_hero.FindHero(heroDungeonLevelUnlcokCondition.Param1);
				if (hero == null || hero.FavorabilityLevel < heroDungeonLevelUnlcokCondition.Param2)
				{
					return -2903;
				}
			}
			if (configDataHeroDungeonLevelInfo.PreLevel_ID != 0 && !this.IsFinishedLevel(configDataHeroDungeonLevelInfo.PreLevel_ID))
			{
				return -2901;
			}
			return 0;
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00140ED4 File Offset: 0x0013F0D4
		public int GetHeroDungeonChapterStar(int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroDungeonChapterStarInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroDungeonChapterStarInt32_hotfix.call(new object[]
				{
					this,
					chapterId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDungeonChapter heroDungeonChapter = this.m_heroDungeonDS.FindChapter(chapterId);
			if (heroDungeonChapter == null)
			{
				return 0;
			}
			return heroDungeonChapter.TotalStars;
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00140F6C File Offset: 0x0013F16C
		public bool HasGotChapterStarReward(int chapterId, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasGotChapterStarRewardInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasGotChapterStarRewardInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDungeonChapter heroDungeonChapter = this.m_heroDungeonDS.FindChapter(chapterId);
			return heroDungeonChapter != null && heroDungeonChapter.StarRewardIndexes.Contains(index);
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x0014101C File Offset: 0x0013F21C
		public int CanGainHeroDungeonChapterStarRewards(int chapterId, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGainHeroDungeonChapterStarRewardsInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGainHeroDungeonChapterStarRewardsInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (index < 1 || index > 3)
			{
				return -2915;
			}
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = this.m_configDataLoader.GetConfigDataHeroInformationInfo(chapterId);
			if (configDataHeroInformationInfo == null)
			{
				return -2909;
			}
			if (this.HasGotChapterStarReward(chapterId, index))
			{
				return -2912;
			}
			int num = 0;
			if (index != 1)
			{
				if (index != 2)
				{
					if (index == 3)
					{
						num = configDataHeroInformationInfo.Reward3Star;
					}
				}
				else
				{
					num = configDataHeroInformationInfo.Reward2Star;
				}
			}
			else
			{
				num = configDataHeroInformationInfo.Reward1Star;
			}
			int heroDungeonChapterStar = this.GetHeroDungeonChapterStar(chapterId);
			if (heroDungeonChapterStar == 0 || heroDungeonChapterStar < num)
			{
				return -2911;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x0014115C File Offset: 0x0013F35C
		protected List<Goods> GetHeroDungeonChapterStarRewards(ConfigDataHeroInformationInfo chapterInfo, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroDungeonChapterStarRewardsConfigDataHeroInformationInfoInt32_hotfix != null)
			{
				return (List<Goods>)this.m_GetHeroDungeonChapterStarRewardsConfigDataHeroInformationInfoInt32_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (index == 1)
			{
				return chapterInfo.Reward1;
			}
			if (index == 2)
			{
				return chapterInfo.Reward2;
			}
			if (index != 3)
			{
				return null;
			}
			return chapterInfo.Reward3;
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x00141218 File Offset: 0x0013F418
		public int GainHeroDungeonChapterStarRewards(int chapterId, int index, bool check = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainHeroDungeonChapterStarRewardsInt32Int32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_GainHeroDungeonChapterStarRewardsInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					chapterId,
					index,
					check
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (check)
			{
				int num = this.CanGainHeroDungeonChapterStarRewards(chapterId, index);
				if (num != 0)
				{
					return num;
				}
			}
			this.GenerateHeroDungeonChapterStarRewards(chapterId, index);
			HeroDungeonChapter chapter = this.m_heroDungeonDS.FindChapter(chapterId);
			this.m_heroDungeonDS.AddChapterStarRewardIndex(chapter, index);
			return 0;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x001412F0 File Offset: 0x0013F4F0
		protected virtual void GenerateHeroDungeonChapterStarRewards(int chapterId, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateHeroDungeonChapterStarRewardsInt32Int32_hotfix != null)
			{
				this.m_GenerateHeroDungeonChapterStarRewardsInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterId,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x00141370 File Offset: 0x0013F570
		// (set) Token: 0x06004309 RID: 17161 RVA: 0x001413E4 File Offset: 0x0013F5E4
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

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x0014145C File Offset: 0x0013F65C
		// (set) Token: 0x0600430B RID: 17163 RVA: 0x001414D0 File Offset: 0x0013F6D0
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

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x0600430C RID: 17164 RVA: 0x00141548 File Offset: 0x0013F748
		// (remove) Token: 0x0600430D RID: 17165 RVA: 0x001415E4 File Offset: 0x0013F7E4
		public event Action<BattleType, int, List<int>> CompleteHeroDungeonLevelMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteHeroDungeonLevelMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteHeroDungeonLevelMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteHeroDungeonLevelMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteHeroDungeonLevelMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteHeroDungeonLevelMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteHeroDungeonLevelMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteHeroDungeonLevelMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteHeroDungeonLevelMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x00141680 File Offset: 0x0013F880
		// (set) Token: 0x0600430F RID: 17167 RVA: 0x001416A0 File Offset: 0x0013F8A0
		[DoNotToLua]
		public HeroDungeonComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDungeonComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x001416AC File Offset: 0x0013F8AC
		private void __callDele_CompleteHeroDungeonLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeHeroDungeonLevelMissionEvent = this.CompleteHeroDungeonLevelMissionEvent;
			if (completeHeroDungeonLevelMissionEvent != null)
			{
				completeHeroDungeonLevelMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x001416D0 File Offset: 0x0013F8D0
		private void __clearDele_CompleteHeroDungeonLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteHeroDungeonLevelMissionEvent = null;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x001416DC File Offset: 0x0013F8DC
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
					this.m_OnFlushLevelChallengeNumsEvent_hotfix = (luaObj.RawGet("OnFlushLevelChallengeNumsEvent") as LuaFunction);
					this.m_HasGotAchievementRelationIdInt32_hotfix = (luaObj.RawGet("HasGotAchievementRelationId") as LuaFunction);
					this.m_IsLevelFirstPassInt32_hotfix = (luaObj.RawGet("IsLevelFirstPass") as LuaFunction);
					this.m_IsFinishedLevelInt32_hotfix = (luaObj.RawGet("IsFinishedLevel") as LuaFunction);
					this.m_IsEnoughAttackNumsConfigDataHeroDungeonLevelInfoInt32_hotfix = (luaObj.RawGet("IsEnoughAttackNums") as LuaFunction);
					this.m_GetLevelCanChallengeMaxNumsConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("GetLevelCanChallengeMaxNums") as LuaFunction);
					this.m_GetDailyChallengeMaxNums_hotfix = (luaObj.RawGet("GetDailyChallengeMaxNums") as LuaFunction);
					this.m_InitLevelInt32Int32Int32Int32_hotfix = (luaObj.RawGet("InitLevel") as LuaFunction);
					this.m_SetLevelInt32Int32Int32Int32_hotfix = (luaObj.RawGet("SetLevel") as LuaFunction);
					this.m_FindLevelInt32Int32_hotfix = (luaObj.RawGet("FindLevel") as LuaFunction);
					this.m_AttackHeroDungeonLevelInt32_hotfix = (luaObj.RawGet("AttackHeroDungeonLevel") as LuaFunction);
					this.m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List`1_hotfix = (luaObj.RawGet("SetSuccessHeroDungeonLevel") as LuaFunction);
					this.m_SetRaidSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("SetRaidSuccessHeroDungeonLevel") as LuaFunction);
					this.m_CanAttackHeroDungeonLevelInt32_hotfix = (luaObj.RawGet("CanAttackHeroDungeonLevel") as LuaFunction);
					this.m_CanRaidHeroDungeonLevelInt32_hotfix = (luaObj.RawGet("CanRaidHeroDungeonLevel") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataHeroDungeonLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_CanAttackLevelByRewardsConfigDataHeroDungeonLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByRewards") as LuaFunction);
					this.m_CanUnlockHeroDungeonLevelInt32_hotfix = (luaObj.RawGet("CanUnlockHeroDungeonLevel") as LuaFunction);
					this.m_GetHeroDungeonChapterStarInt32_hotfix = (luaObj.RawGet("GetHeroDungeonChapterStar") as LuaFunction);
					this.m_HasGotChapterStarRewardInt32Int32_hotfix = (luaObj.RawGet("HasGotChapterStarReward") as LuaFunction);
					this.m_CanGainHeroDungeonChapterStarRewardsInt32Int32_hotfix = (luaObj.RawGet("CanGainHeroDungeonChapterStarRewards") as LuaFunction);
					this.m_GetHeroDungeonChapterStarRewardsConfigDataHeroInformationInfoInt32_hotfix = (luaObj.RawGet("GetHeroDungeonChapterStarRewards") as LuaFunction);
					this.m_GainHeroDungeonChapterStarRewardsInt32Int32Boolean_hotfix = (luaObj.RawGet("GainHeroDungeonChapterStarRewards") as LuaFunction);
					this.m_GenerateHeroDungeonChapterStarRewardsInt32Int32_hotfix = (luaObj.RawGet("GenerateHeroDungeonChapterStarRewards") as LuaFunction);
					this.m_get_HasRewardAddRelativeOperationalActivity_hotfix = (luaObj.RawGet("get_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix = (luaObj.RawGet("set_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_get_OperationalActivityChanllengenumsAdd_hotfix = (luaObj.RawGet("get_OperationalActivityChanllengenumsAdd") as LuaFunction);
					this.m_set_OperationalActivityChanllengenumsAddInt32_hotfix = (luaObj.RawGet("set_OperationalActivityChanllengenumsAdd") as LuaFunction);
					this.m_add_CompleteHeroDungeonLevelMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteHeroDungeonLevelMissionEvent") as LuaFunction);
					this.m_remove_CompleteHeroDungeonLevelMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteHeroDungeonLevelMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00141B90 File Offset: 0x0013FD90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040032F0 RID: 13040
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040032F1 RID: 13041
		protected RiftComponentCommon m_rift;

		// Token: 0x040032F2 RID: 13042
		protected HeroComponentCommon m_hero;

		// Token: 0x040032F3 RID: 13043
		protected BattleComponentCommon m_battle;

		// Token: 0x040032F4 RID: 13044
		protected BagComponentCommon m_bag;

		// Token: 0x040032F5 RID: 13045
		protected DataSectionHeroDungeon m_heroDungeonDS;

		// Token: 0x040032F6 RID: 13046
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040032F8 RID: 13048
		[DoNotToLua]
		private HeroDungeonComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040032F9 RID: 13049
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040032FA RID: 13050
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040032FB RID: 13051
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040032FC RID: 13052
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040032FD RID: 13053
		private LuaFunction m_Init_hotfix;

		// Token: 0x040032FE RID: 13054
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040032FF RID: 13055
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003300 RID: 13056
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003301 RID: 13057
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003302 RID: 13058
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003303 RID: 13059
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003304 RID: 13060
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003305 RID: 13061
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003306 RID: 13062
		private LuaFunction m_OnFlushLevelChallengeNumsEvent_hotfix;

		// Token: 0x04003307 RID: 13063
		private LuaFunction m_HasGotAchievementRelationIdInt32_hotfix;

		// Token: 0x04003308 RID: 13064
		private LuaFunction m_IsLevelFirstPassInt32_hotfix;

		// Token: 0x04003309 RID: 13065
		private LuaFunction m_IsFinishedLevelInt32_hotfix;

		// Token: 0x0400330A RID: 13066
		private LuaFunction m_IsEnoughAttackNumsConfigDataHeroDungeonLevelInfoInt32_hotfix;

		// Token: 0x0400330B RID: 13067
		private LuaFunction m_GetLevelCanChallengeMaxNumsConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x0400330C RID: 13068
		private LuaFunction m_GetDailyChallengeMaxNums_hotfix;

		// Token: 0x0400330D RID: 13069
		private LuaFunction m_InitLevelInt32Int32Int32Int32_hotfix;

		// Token: 0x0400330E RID: 13070
		private LuaFunction m_SetLevelInt32Int32Int32Int32_hotfix;

		// Token: 0x0400330F RID: 13071
		private LuaFunction m_FindLevelInt32Int32_hotfix;

		// Token: 0x04003310 RID: 13072
		private LuaFunction m_AttackHeroDungeonLevelInt32_hotfix;

		// Token: 0x04003311 RID: 13073
		private LuaFunction m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List;

		// Token: 0x04003312 RID: 13074
		private LuaFunction m_SetRaidSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04003313 RID: 13075
		private LuaFunction m_CanAttackHeroDungeonLevelInt32_hotfix;

		// Token: 0x04003314 RID: 13076
		private LuaFunction m_CanRaidHeroDungeonLevelInt32_hotfix;

		// Token: 0x04003315 RID: 13077
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataHeroDungeonLevelInfoBoolean_hotfix;

		// Token: 0x04003316 RID: 13078
		private LuaFunction m_CanAttackLevelByRewardsConfigDataHeroDungeonLevelInfoBoolean_hotfix;

		// Token: 0x04003317 RID: 13079
		private LuaFunction m_CanUnlockHeroDungeonLevelInt32_hotfix;

		// Token: 0x04003318 RID: 13080
		private LuaFunction m_GetHeroDungeonChapterStarInt32_hotfix;

		// Token: 0x04003319 RID: 13081
		private LuaFunction m_HasGotChapterStarRewardInt32Int32_hotfix;

		// Token: 0x0400331A RID: 13082
		private LuaFunction m_CanGainHeroDungeonChapterStarRewardsInt32Int32_hotfix;

		// Token: 0x0400331B RID: 13083
		private LuaFunction m_GetHeroDungeonChapterStarRewardsConfigDataHeroInformationInfoInt32_hotfix;

		// Token: 0x0400331C RID: 13084
		private LuaFunction m_GainHeroDungeonChapterStarRewardsInt32Int32Boolean_hotfix;

		// Token: 0x0400331D RID: 13085
		private LuaFunction m_GenerateHeroDungeonChapterStarRewardsInt32Int32_hotfix;

		// Token: 0x0400331E RID: 13086
		private LuaFunction m_get_HasRewardAddRelativeOperationalActivity_hotfix;

		// Token: 0x0400331F RID: 13087
		private LuaFunction m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix;

		// Token: 0x04003320 RID: 13088
		private LuaFunction m_get_OperationalActivityChanllengenumsAdd_hotfix;

		// Token: 0x04003321 RID: 13089
		private LuaFunction m_set_OperationalActivityChanllengenumsAddInt32_hotfix;

		// Token: 0x04003322 RID: 13090
		private LuaFunction m_add_CompleteHeroDungeonLevelMissionEventAction;

		// Token: 0x04003323 RID: 13091
		private LuaFunction m_remove_CompleteHeroDungeonLevelMissionEventAction;

		// Token: 0x02000478 RID: 1144
		public class LuaExportHelper
		{
			// Token: 0x06004314 RID: 17172 RVA: 0x00141BF8 File Offset: 0x0013FDF8
			public LuaExportHelper(HeroDungeonComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004315 RID: 17173 RVA: 0x00141C08 File Offset: 0x0013FE08
			public void __callDele_CompleteHeroDungeonLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteHeroDungeonLevelMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004316 RID: 17174 RVA: 0x00141C18 File Offset: 0x0013FE18
			public void __clearDele_CompleteHeroDungeonLevelMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteHeroDungeonLevelMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x1700116E RID: 4462
			// (get) Token: 0x06004317 RID: 17175 RVA: 0x00141C28 File Offset: 0x0013FE28
			// (set) Token: 0x06004318 RID: 17176 RVA: 0x00141C38 File Offset: 0x0013FE38
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

			// Token: 0x1700116F RID: 4463
			// (get) Token: 0x06004319 RID: 17177 RVA: 0x00141C48 File Offset: 0x0013FE48
			// (set) Token: 0x0600431A RID: 17178 RVA: 0x00141C58 File Offset: 0x0013FE58
			public RiftComponentCommon m_rift
			{
				get
				{
					return this.m_owner.m_rift;
				}
				set
				{
					this.m_owner.m_rift = value;
				}
			}

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x0600431B RID: 17179 RVA: 0x00141C68 File Offset: 0x0013FE68
			// (set) Token: 0x0600431C RID: 17180 RVA: 0x00141C78 File Offset: 0x0013FE78
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

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x0600431D RID: 17181 RVA: 0x00141C88 File Offset: 0x0013FE88
			// (set) Token: 0x0600431E RID: 17182 RVA: 0x00141C98 File Offset: 0x0013FE98
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

			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x0600431F RID: 17183 RVA: 0x00141CA8 File Offset: 0x0013FEA8
			// (set) Token: 0x06004320 RID: 17184 RVA: 0x00141CB8 File Offset: 0x0013FEB8
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

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x06004321 RID: 17185 RVA: 0x00141CC8 File Offset: 0x0013FEC8
			// (set) Token: 0x06004322 RID: 17186 RVA: 0x00141CD8 File Offset: 0x0013FED8
			public DataSectionHeroDungeon m_heroDungeonDS
			{
				get
				{
					return this.m_owner.m_heroDungeonDS;
				}
				set
				{
					this.m_owner.m_heroDungeonDS = value;
				}
			}

			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x06004323 RID: 17187 RVA: 0x00141CE8 File Offset: 0x0013FEE8
			// (set) Token: 0x06004324 RID: 17188 RVA: 0x00141CF8 File Offset: 0x0013FEF8
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

			// Token: 0x06004325 RID: 17189 RVA: 0x00141D08 File Offset: 0x0013FF08
			public void OnFlushLevelChallengeNumsEvent()
			{
				this.m_owner.OnFlushLevelChallengeNumsEvent();
			}

			// Token: 0x06004326 RID: 17190 RVA: 0x00141D18 File Offset: 0x0013FF18
			public bool IsEnoughAttackNums(ConfigDataHeroDungeonLevelInfo levelInfo, int nums)
			{
				return this.m_owner.IsEnoughAttackNums(levelInfo, nums);
			}

			// Token: 0x06004327 RID: 17191 RVA: 0x00141D28 File Offset: 0x0013FF28
			public void InitLevel(int chapterId, int levelId, int stars, int nums)
			{
				this.m_owner.InitLevel(chapterId, levelId, stars, nums);
			}

			// Token: 0x06004328 RID: 17192 RVA: 0x00141D3C File Offset: 0x0013FF3C
			public void SetLevel(int chapterId, int LevelId, int stars, int nums)
			{
				this.m_owner.SetLevel(chapterId, LevelId, stars, nums);
			}

			// Token: 0x06004329 RID: 17193 RVA: 0x00141D50 File Offset: 0x0013FF50
			public void SetSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo, List<int> newGotAchievementRelationInds, int stars, List<int> battleTreasures)
			{
				this.m_owner.SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			}

			// Token: 0x0600432A RID: 17194 RVA: 0x00141D64 File Offset: 0x0013FF64
			public void SetRaidSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				this.m_owner.SetRaidSuccessHeroDungeonLevel(levelInfo);
			}

			// Token: 0x0600432B RID: 17195 RVA: 0x00141D74 File Offset: 0x0013FF74
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataHeroDungeonLevelInfo levelInfo, bool isRaid)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo, isRaid);
			}

			// Token: 0x0600432C RID: 17196 RVA: 0x00141D84 File Offset: 0x0013FF84
			public int CanAttackLevelByRewards(ConfigDataHeroDungeonLevelInfo levelInfo, bool isRaid)
			{
				return this.m_owner.CanAttackLevelByRewards(levelInfo, isRaid);
			}

			// Token: 0x0600432D RID: 17197 RVA: 0x00141D94 File Offset: 0x0013FF94
			public List<Goods> GetHeroDungeonChapterStarRewards(ConfigDataHeroInformationInfo chapterInfo, int index)
			{
				return this.m_owner.GetHeroDungeonChapterStarRewards(chapterInfo, index);
			}

			// Token: 0x0600432E RID: 17198 RVA: 0x00141DA4 File Offset: 0x0013FFA4
			public void GenerateHeroDungeonChapterStarRewards(int chapterId, int index)
			{
				this.m_owner.GenerateHeroDungeonChapterStarRewards(chapterId, index);
			}

			// Token: 0x04003324 RID: 13092
			private HeroDungeonComponentCommon m_owner;
		}
	}
}
