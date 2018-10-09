using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004AE RID: 1198
	[HotFix]
	public class ThearchyTrialCompomentCommon : IComponentBase
	{
		// Token: 0x0600492F RID: 18735 RVA: 0x0016C5F0 File Offset: 0x0016A7F0
		public ThearchyTrialCompomentCommon()
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

		// Token: 0x06004930 RID: 18736 RVA: 0x0016C664 File Offset: 0x0016A864
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
			return "ThearchyTrail";
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x0016C6D8 File Offset: 0x0016A8D8
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
			this.HasRewardAddRelativeOperationalActivity = false;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x0016C740 File Offset: 0x0016A940
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
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.FlushChallengNums;
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0016C840 File Offset: 0x0016AA40
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

		// Token: 0x06004934 RID: 18740 RVA: 0x0016C8A0 File Offset: 0x0016AAA0
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

		// Token: 0x06004935 RID: 18741 RVA: 0x0016C910 File Offset: 0x0016AB10
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

		// Token: 0x06004936 RID: 18742 RVA: 0x0016C990 File Offset: 0x0016AB90
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

		// Token: 0x06004937 RID: 18743 RVA: 0x0016CA00 File Offset: 0x0016AC00
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

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06004938 RID: 18744 RVA: 0x0016CA60 File Offset: 0x0016AC60
		// (set) Token: 0x06004939 RID: 18745 RVA: 0x0016CAD4 File Offset: 0x0016ACD4
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

		// Token: 0x0600493A RID: 18746 RVA: 0x0016CB4C File Offset: 0x0016AD4C
		public int AttackThearchyTrialLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackThearchyTrialLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackThearchyTrialLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackThearchyTrialLevel(levelId, false);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataThearchyTrialLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_ThearchyTrial, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.ThearchyTrial, levelId);
			return 0;
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x0016CC30 File Offset: 0x0016AE30
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
			return this.m_thearchyTrial.IsLevelFinished(levelId);
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x0016CCB8 File Offset: 0x0016AEB8
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
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ThearchyTrial);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x0016CD34 File Offset: 0x0016AF34
		public virtual int CanAttackThearchyTrialLevel(int levelId, bool isTeamBattle = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackThearchyTrialLevelInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackThearchyTrialLevelInt32Boolean_hotfix.call(new object[]
				{
					this,
					levelId,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanOpenLevel(levelId);
			if (num != 0)
			{
				return num;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
			return this.CanAttackLevelByEnergyAndSoOn(configDataThearchyTrialLevelInfo, isTeamBattle);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x0016CDFC File Offset: 0x0016AFFC
		private int CanOpenLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanOpenLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanOpenLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsGameFunctionOpened())
			{
				return -1809;
			}
			ConfigDataThearchyTrialLevelInfo levelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
			if (levelInfo == null)
			{
				return -1801;
			}
			if (levelInfo.m_battleInfo == null)
			{
				return -1807;
			}
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataThearchyTrialInfo> list;
			if (!this.m_configDataLoader.ThearchyTrialData.ThearchyTrailOfWeekDict.TryGetValue(key, out list))
			{
				return -1800;
			}
			if (list.Find((ConfigDataThearchyTrialInfo t) => t.ID == levelInfo.m_groupInfo.ID) == null)
			{
				return -1802;
			}
			if (levelInfo.PreLevel != 0 && !this.m_thearchyTrial.IsLevelFinished(levelInfo.PreLevel))
			{
				return -1803;
			}
			return 0;
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x0016CF60 File Offset: 0x0016B160
		protected int CanAttackLevelByEnergyAndSoOn(ConfigDataThearchyTrialLevelInfo levelInfo, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataThearchyTrialLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataThearchyTrialLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_ThearchyTrial);
			if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, ticketId, levelInfo.TicketCost))
			{
				return -1808;
			}
			int consumeEnergy = levelInfo.EnergySuccess;
			if (isTeamBattle)
			{
				consumeEnergy = levelInfo.TeamEnergyCost;
			}
			if (!this.m_basicInfo.IsEnergyEnough(consumeEnergy))
			{
				return -402;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x0016D05C File Offset: 0x0016B25C
		protected virtual void SetCommonSuccessThearchyTrialLevel(ConfigDataThearchyTrialLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List`1Int32Boolean_hotfix != null)
			{
				this.m_SetCommonSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List`1Int32Boolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					battleTreasures,
					heroes,
					energyCost,
					isBattleTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.AddPlayerExp(levelInfo.PlayerExp);
			this.m_battle.AddFightHeroFightNumsAndExp(heroes, levelInfo.HeroExp);
			this.m_basicInfo.AddGold(levelInfo.Gold, GameFunctionType.GameFunctionType_ThearchyTrial, levelInfo.ID.ToString());
			if (levelInfo.TicketCost > 0)
			{
				int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_ThearchyTrial);
				BagItemBase bagItem = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
				this.m_bag.RemoveBagItemDirectly(bagItem, levelInfo.TicketCost, GameFunctionType.GameFunctionType_ThearchyTrial, levelInfo.ID.ToString());
			}
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_ThearchyTrial, levelInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			if (this.IsDailyChallenge())
			{
				this.AddChallengedNums(1);
			}
			if (!isBattleTeam)
			{
				this.m_thearchyTrial.AddFinishedLevel(levelInfo.ID);
			}
			if (this.CompleteThearchyTrialMissionEvent != null)
			{
				this.CompleteThearchyTrialMissionEvent(BattleType.ThearchyTrial, levelInfo.ID, heroes);
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x0016D23C File Offset: 0x0016B43C
		public HashSet<int> GetAllFinishedLevels()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllFinishedLevels_hotfix != null)
			{
				return (HashSet<int>)this.m_GetAllFinishedLevels_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_thearchyTrial.GetAllFinishedLevels();
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004942 RID: 18754 RVA: 0x0016D2B4 File Offset: 0x0016B4B4
		// (set) Token: 0x06004943 RID: 18755 RVA: 0x0016D328 File Offset: 0x0016B528
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

		// Token: 0x06004944 RID: 18756 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
		private void FlushChallengNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushChallengNums_hotfix != null)
			{
				this.m_FlushChallengNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_thearchyTrial.SetChallengedNums(0);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x0016D40C File Offset: 0x0016B60C
		public bool IsDailyChallenge()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDailyChallenge_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDailyChallenge_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetDailyChallengNums() > 0;
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x0016D484 File Offset: 0x0016B684
		public int GetDailyChallengNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDailyChallengNums_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDailyChallengNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int dailyBonusMaxNums = this.m_battle.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_ThearchyTrial);
			int challengedNums = this.m_thearchyTrial.ChallengedNums;
			if (dailyBonusMaxNums > challengedNums)
			{
				return dailyBonusMaxNums - challengedNums;
			}
			return 0;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x0016D518 File Offset: 0x0016B718
		protected void AddChallengedNums(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddChallengedNumsInt32_hotfix != null)
			{
				this.m_AddChallengedNumsInt32_hotfix.call(new object[]
				{
					this,
					nums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_thearchyTrial.AddChallengedNums(nums);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x0016D594 File Offset: 0x0016B794
		public List<int> GetAllUnlockedLevels()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllUnlockedLevels_hotfix != null)
			{
				return (List<int>)this.m_GetAllUnlockedLevels_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataThearchyTrialInfo> list2;
			if (!this.m_configDataLoader.ThearchyTrialData.ThearchyTrailOfWeekDict.TryGetValue(key, out list2))
			{
				return list;
			}
			foreach (ConfigDataThearchyTrialInfo configDataThearchyTrialInfo in list2)
			{
				foreach (ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo in configDataThearchyTrialInfo.m_levelInfos)
				{
					if (configDataThearchyTrialLevelInfo.PreLevel == 0 || this.IsLevelFinished(configDataThearchyTrialLevelInfo.PreLevel))
					{
						list.Add(configDataThearchyTrialLevelInfo.ID);
					}
				}
			}
			return list;
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x0016D700 File Offset: 0x0016B900
		public bool IsLevelUnlocked(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelUnlockedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelUnlockedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.CanOpenLevel(levelId) == 0;
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x0600494A RID: 18762 RVA: 0x0016D788 File Offset: 0x0016B988
		// (remove) Token: 0x0600494B RID: 18763 RVA: 0x0016D824 File Offset: 0x0016BA24
		public event Action<BattleType, int, List<int>> CompleteThearchyTrialMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteThearchyTrialMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteThearchyTrialMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteThearchyTrialMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteThearchyTrialMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteThearchyTrialMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteThearchyTrialMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteThearchyTrialMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteThearchyTrialMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x0016D8C0 File Offset: 0x0016BAC0
		// (set) Token: 0x0600494D RID: 18765 RVA: 0x0016D8E0 File Offset: 0x0016BAE0
		[DoNotToLua]
		public ThearchyTrialCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ThearchyTrialCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x0016D8EC File Offset: 0x0016BAEC
		private void __callDele_CompleteThearchyTrialMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeThearchyTrialMissionEvent = this.CompleteThearchyTrialMissionEvent;
			if (completeThearchyTrialMissionEvent != null)
			{
				completeThearchyTrialMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x0016D910 File Offset: 0x0016BB10
		private void __clearDele_CompleteThearchyTrialMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteThearchyTrialMissionEvent = null;
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x0016D91C File Offset: 0x0016BB1C
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
					this.m_AttackThearchyTrialLevelInt32_hotfix = (luaObj.RawGet("AttackThearchyTrialLevel") as LuaFunction);
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_CanAttackThearchyTrialLevelInt32Boolean_hotfix = (luaObj.RawGet("CanAttackThearchyTrialLevel") as LuaFunction);
					this.m_CanOpenLevelInt32_hotfix = (luaObj.RawGet("CanOpenLevel") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataThearchyTrialLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_SetCommonSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List`1Int32Boolean_hotfix = (luaObj.RawGet("SetCommonSuccessThearchyTrialLevel") as LuaFunction);
					this.m_GetAllFinishedLevels_hotfix = (luaObj.RawGet("GetAllFinishedLevels") as LuaFunction);
					this.m_get_HasRewardAddRelativeOperationalActivity_hotfix = (luaObj.RawGet("get_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix = (luaObj.RawGet("set_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_FlushChallengNums_hotfix = (luaObj.RawGet("FlushChallengNums") as LuaFunction);
					this.m_IsDailyChallenge_hotfix = (luaObj.RawGet("IsDailyChallenge") as LuaFunction);
					this.m_GetDailyChallengNums_hotfix = (luaObj.RawGet("GetDailyChallengNums") as LuaFunction);
					this.m_AddChallengedNumsInt32_hotfix = (luaObj.RawGet("AddChallengedNums") as LuaFunction);
					this.m_GetAllUnlockedLevels_hotfix = (luaObj.RawGet("GetAllUnlockedLevels") as LuaFunction);
					this.m_IsLevelUnlockedInt32_hotfix = (luaObj.RawGet("IsLevelUnlocked") as LuaFunction);
					this.m_add_CompleteThearchyTrialMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteThearchyTrialMissionEvent") as LuaFunction);
					this.m_remove_CompleteThearchyTrialMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteThearchyTrialMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x0016DCA4 File Offset: 0x0016BEA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyTrialCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003765 RID: 14181
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003766 RID: 14182
		protected DataSectionThearchyTrail m_thearchyTrial = new DataSectionThearchyTrail();

		// Token: 0x04003767 RID: 14183
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003768 RID: 14184
		protected BattleComponentCommon m_battle;

		// Token: 0x04003769 RID: 14185
		protected RiftComponentCommon m_rift;

		// Token: 0x0400376A RID: 14186
		protected HeroComponentCommon m_hero;

		// Token: 0x0400376B RID: 14187
		protected BagComponentCommon m_bag;

		// Token: 0x0400376D RID: 14189
		[DoNotToLua]
		private ThearchyTrialCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400376E RID: 14190
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400376F RID: 14191
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003770 RID: 14192
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003771 RID: 14193
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003772 RID: 14194
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003773 RID: 14195
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003774 RID: 14196
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003775 RID: 14197
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003776 RID: 14198
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003777 RID: 14199
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003778 RID: 14200
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003779 RID: 14201
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400377A RID: 14202
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400377B RID: 14203
		private LuaFunction m_AttackThearchyTrialLevelInt32_hotfix;

		// Token: 0x0400377C RID: 14204
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x0400377D RID: 14205
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x0400377E RID: 14206
		private LuaFunction m_CanAttackThearchyTrialLevelInt32Boolean_hotfix;

		// Token: 0x0400377F RID: 14207
		private LuaFunction m_CanOpenLevelInt32_hotfix;

		// Token: 0x04003780 RID: 14208
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataThearchyTrialLevelInfoBoolean_hotfix;

		// Token: 0x04003781 RID: 14209
		private LuaFunction m_SetCommonSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List;

		// Token: 0x04003782 RID: 14210
		private LuaFunction m_GetAllFinishedLevels_hotfix;

		// Token: 0x04003783 RID: 14211
		private LuaFunction m_get_HasRewardAddRelativeOperationalActivity_hotfix;

		// Token: 0x04003784 RID: 14212
		private LuaFunction m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix;

		// Token: 0x04003785 RID: 14213
		private LuaFunction m_FlushChallengNums_hotfix;

		// Token: 0x04003786 RID: 14214
		private LuaFunction m_IsDailyChallenge_hotfix;

		// Token: 0x04003787 RID: 14215
		private LuaFunction m_GetDailyChallengNums_hotfix;

		// Token: 0x04003788 RID: 14216
		private LuaFunction m_AddChallengedNumsInt32_hotfix;

		// Token: 0x04003789 RID: 14217
		private LuaFunction m_GetAllUnlockedLevels_hotfix;

		// Token: 0x0400378A RID: 14218
		private LuaFunction m_IsLevelUnlockedInt32_hotfix;

		// Token: 0x0400378B RID: 14219
		private LuaFunction m_add_CompleteThearchyTrialMissionEventAction;

		// Token: 0x0400378C RID: 14220
		private LuaFunction m_remove_CompleteThearchyTrialMissionEventAction;

		// Token: 0x020004AF RID: 1199
		public class LuaExportHelper
		{
			// Token: 0x06004952 RID: 18770 RVA: 0x0016DD0C File Offset: 0x0016BF0C
			public LuaExportHelper(ThearchyTrialCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004953 RID: 18771 RVA: 0x0016DD1C File Offset: 0x0016BF1C
			public void __callDele_CompleteThearchyTrialMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteThearchyTrialMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004954 RID: 18772 RVA: 0x0016DD2C File Offset: 0x0016BF2C
			public void __clearDele_CompleteThearchyTrialMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteThearchyTrialMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x1700123A RID: 4666
			// (get) Token: 0x06004955 RID: 18773 RVA: 0x0016DD3C File Offset: 0x0016BF3C
			// (set) Token: 0x06004956 RID: 18774 RVA: 0x0016DD4C File Offset: 0x0016BF4C
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

			// Token: 0x1700123B RID: 4667
			// (get) Token: 0x06004957 RID: 18775 RVA: 0x0016DD5C File Offset: 0x0016BF5C
			// (set) Token: 0x06004958 RID: 18776 RVA: 0x0016DD6C File Offset: 0x0016BF6C
			public DataSectionThearchyTrail m_thearchyTrial
			{
				get
				{
					return this.m_owner.m_thearchyTrial;
				}
				set
				{
					this.m_owner.m_thearchyTrial = value;
				}
			}

			// Token: 0x1700123C RID: 4668
			// (get) Token: 0x06004959 RID: 18777 RVA: 0x0016DD7C File Offset: 0x0016BF7C
			// (set) Token: 0x0600495A RID: 18778 RVA: 0x0016DD8C File Offset: 0x0016BF8C
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

			// Token: 0x1700123D RID: 4669
			// (get) Token: 0x0600495B RID: 18779 RVA: 0x0016DD9C File Offset: 0x0016BF9C
			// (set) Token: 0x0600495C RID: 18780 RVA: 0x0016DDAC File Offset: 0x0016BFAC
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

			// Token: 0x1700123E RID: 4670
			// (get) Token: 0x0600495D RID: 18781 RVA: 0x0016DDBC File Offset: 0x0016BFBC
			// (set) Token: 0x0600495E RID: 18782 RVA: 0x0016DDCC File Offset: 0x0016BFCC
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

			// Token: 0x1700123F RID: 4671
			// (get) Token: 0x0600495F RID: 18783 RVA: 0x0016DDDC File Offset: 0x0016BFDC
			// (set) Token: 0x06004960 RID: 18784 RVA: 0x0016DDEC File Offset: 0x0016BFEC
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

			// Token: 0x17001240 RID: 4672
			// (get) Token: 0x06004961 RID: 18785 RVA: 0x0016DDFC File Offset: 0x0016BFFC
			// (set) Token: 0x06004962 RID: 18786 RVA: 0x0016DE0C File Offset: 0x0016C00C
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

			// Token: 0x06004963 RID: 18787 RVA: 0x0016DE1C File Offset: 0x0016C01C
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x06004964 RID: 18788 RVA: 0x0016DE2C File Offset: 0x0016C02C
			public int CanOpenLevel(int levelId)
			{
				return this.m_owner.CanOpenLevel(levelId);
			}

			// Token: 0x06004965 RID: 18789 RVA: 0x0016DE3C File Offset: 0x0016C03C
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataThearchyTrialLevelInfo levelInfo, bool isTeamBattle)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
			}

			// Token: 0x06004966 RID: 18790 RVA: 0x0016DE4C File Offset: 0x0016C04C
			public void SetCommonSuccessThearchyTrialLevel(ConfigDataThearchyTrialLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.SetCommonSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x06004967 RID: 18791 RVA: 0x0016DE60 File Offset: 0x0016C060
			public void FlushChallengNums()
			{
				this.m_owner.FlushChallengNums();
			}

			// Token: 0x06004968 RID: 18792 RVA: 0x0016DE70 File Offset: 0x0016C070
			public void AddChallengedNums(int nums)
			{
				this.m_owner.AddChallengedNums(nums);
			}

			// Token: 0x0400378D RID: 14221
			private ThearchyTrialCompomentCommon m_owner;
		}
	}
}
