using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200047C RID: 1148
	[HotFix]
	public class HeroTrainningComponentCommon : IComponentBase
	{
		// Token: 0x0600436E RID: 17262 RVA: 0x00143678 File Offset: 0x00141878
		public HeroTrainningComponentCommon()
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

		// Token: 0x0600436F RID: 17263 RVA: 0x001436EC File Offset: 0x001418EC
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
			return "HeroTrainning";
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00143760 File Offset: 0x00141960
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

		// Token: 0x06004371 RID: 17265 RVA: 0x001437C8 File Offset: 0x001419C8
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

		// Token: 0x06004372 RID: 17266 RVA: 0x001438C8 File Offset: 0x00141AC8
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

		// Token: 0x06004373 RID: 17267 RVA: 0x00143928 File Offset: 0x00141B28
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

		// Token: 0x06004374 RID: 17268 RVA: 0x00143998 File Offset: 0x00141B98
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

		// Token: 0x06004375 RID: 17269 RVA: 0x00143A18 File Offset: 0x00141C18
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

		// Token: 0x06004376 RID: 17270 RVA: 0x00143A88 File Offset: 0x00141C88
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

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x00143AE8 File Offset: 0x00141CE8
		// (set) Token: 0x06004378 RID: 17272 RVA: 0x00143B5C File Offset: 0x00141D5C
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

		// Token: 0x06004379 RID: 17273 RVA: 0x00143BD4 File Offset: 0x00141DD4
		public int AttackHeroTrainningLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackHeroTrainningLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackHeroTrainningLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackHeroTrainningLevel(levelId, false);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataHeroTrainningLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_HeroTrainning, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.HeroTrainning, levelId);
			return 0;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x00143CB8 File Offset: 0x00141EB8
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
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroTrainning);
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x00143D34 File Offset: 0x00141F34
		public virtual int CanAttackHeroTrainningLevel(int levelId, bool isTeamBattle = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackHeroTrainningLevelInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackHeroTrainningLevelInt32Boolean_hotfix.call(new object[]
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
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
			return this.CanAttackLevelByEnergyAndSoOn(configDataHeroTrainningLevelInfo, isTeamBattle);
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00143DFC File Offset: 0x00141FFC
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
				return -4208;
			}
			ConfigDataHeroTrainningLevelInfo levelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
			if (levelInfo == null)
			{
				return -4201;
			}
			if (levelInfo.m_battleInfo == null)
			{
				return -4206;
			}
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataHeroTrainningInfo> list;
			if (!this.m_configDataLoader.HeroTrainningData.HeroTrainningOfWeekDict.TryGetValue(key, out list))
			{
				return -4200;
			}
			if (list.Find((ConfigDataHeroTrainningInfo t) => t.ID == levelInfo.m_groupInfo.ID) == null)
			{
				return -4202;
			}
			int level = this.m_basicInfo.GetLevel();
			if (level < levelInfo.OpenPlayerLevel)
			{
				return -413;
			}
			return 0;
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00143F54 File Offset: 0x00142154
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
			return this.m_heroTrainningDS.IsLevelFinished(levelId);
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00143FDC File Offset: 0x001421DC
		private int CanAttackLevelByEnergyAndSoOn(ConfigDataHeroTrainningLevelInfo levelInfo, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataHeroTrainningLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataHeroTrainningLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_HeroTrainning);
			if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, ticketId, levelInfo.TicketCost))
			{
				return -4207;
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

		// Token: 0x0600437F RID: 17279 RVA: 0x001440D8 File Offset: 0x001422D8
		protected void SetCommonSuccessHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List`1Int32Boolean_hotfix != null)
			{
				this.m_SetCommonSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List`1Int32Boolean_hotfix.call(new object[]
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
			this.m_basicInfo.AddGold(levelInfo.Gold, GameFunctionType.GameFunctionType_HeroTrainning, levelInfo.ID.ToString());
			if (levelInfo.TicketCost > 0)
			{
				int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_HeroTrainning);
				BagItemBase bagItem = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
				this.m_bag.RemoveBagItemDirectly(bagItem, levelInfo.TicketCost, GameFunctionType.GameFunctionType_HeroTrainning, levelInfo.ID.ToString());
			}
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_HeroTrainning, levelInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			if (!isBattleTeam)
			{
				this.m_heroTrainningDS.AddFinishedLevel(levelInfo.ID);
			}
			if (this.IsDailyChallenge())
			{
				this.AddChallengedNums(1);
			}
			if (this.CompleteHeroTrainningMissionEvent != null)
			{
				this.CompleteHeroTrainningMissionEvent(BattleType.HeroTrainning, levelInfo.ID, heroes);
			}
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x001442B8 File Offset: 0x001424B8
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
			return this.m_heroTrainningDS.GetAllFinishedLevels();
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x00144330 File Offset: 0x00142530
		// (set) Token: 0x06004382 RID: 17282 RVA: 0x001443A4 File Offset: 0x001425A4
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

		// Token: 0x06004383 RID: 17283 RVA: 0x0014441C File Offset: 0x0014261C
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
			this.m_heroTrainningDS.SetChallengedNums(0);
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00144488 File Offset: 0x00142688
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

		// Token: 0x06004385 RID: 17285 RVA: 0x00144500 File Offset: 0x00142700
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
			int dailyBonusMaxNums = this.m_battle.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_HeroTrainning);
			int challengedNums = this.m_heroTrainningDS.ChallengedNums;
			if (dailyBonusMaxNums > challengedNums)
			{
				return dailyBonusMaxNums - challengedNums;
			}
			return 0;
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00144594 File Offset: 0x00142794
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
			this.m_heroTrainningDS.AddChallengedNums(nums);
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00144610 File Offset: 0x00142810
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
			List<ConfigDataHeroTrainningInfo> list2;
			if (!this.m_configDataLoader.HeroTrainningData.HeroTrainningOfWeekDict.TryGetValue(key, out list2))
			{
				return list;
			}
			int level = this.m_basicInfo.GetLevel();
			foreach (ConfigDataHeroTrainningInfo configDataHeroTrainningInfo in list2)
			{
				foreach (ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo in configDataHeroTrainningInfo.m_levelInfos)
				{
					if (level >= configDataHeroTrainningLevelInfo.OpenPlayerLevel)
					{
						list.Add(configDataHeroTrainningLevelInfo.ID);
					}
				}
			}
			return list;
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x0014477C File Offset: 0x0014297C
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

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06004389 RID: 17289 RVA: 0x00144804 File Offset: 0x00142A04
		// (remove) Token: 0x0600438A RID: 17290 RVA: 0x001448A0 File Offset: 0x00142AA0
		public event Action<BattleType, int, List<int>> CompleteHeroTrainningMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteHeroTrainningMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteHeroTrainningMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteHeroTrainningMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteHeroTrainningMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteHeroTrainningMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteHeroTrainningMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteHeroTrainningMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteHeroTrainningMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x0014493C File Offset: 0x00142B3C
		// (set) Token: 0x0600438C RID: 17292 RVA: 0x0014495C File Offset: 0x00142B5C
		[DoNotToLua]
		public HeroTrainningComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroTrainningComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00144968 File Offset: 0x00142B68
		private void __callDele_CompleteHeroTrainningMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeHeroTrainningMissionEvent = this.CompleteHeroTrainningMissionEvent;
			if (completeHeroTrainningMissionEvent != null)
			{
				completeHeroTrainningMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x0014498C File Offset: 0x00142B8C
		private void __clearDele_CompleteHeroTrainningMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteHeroTrainningMissionEvent = null;
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00144998 File Offset: 0x00142B98
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
					this.m_AttackHeroTrainningLevelInt32_hotfix = (luaObj.RawGet("AttackHeroTrainningLevel") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_CanAttackHeroTrainningLevelInt32Boolean_hotfix = (luaObj.RawGet("CanAttackHeroTrainningLevel") as LuaFunction);
					this.m_CanOpenLevelInt32_hotfix = (luaObj.RawGet("CanOpenLevel") as LuaFunction);
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataHeroTrainningLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_SetCommonSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List`1Int32Boolean_hotfix = (luaObj.RawGet("SetCommonSuccessHeroTrainningLevel") as LuaFunction);
					this.m_GetAllFinishedLevels_hotfix = (luaObj.RawGet("GetAllFinishedLevels") as LuaFunction);
					this.m_get_HasRewardAddRelativeOperationalActivity_hotfix = (luaObj.RawGet("get_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix = (luaObj.RawGet("set_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_FlushChallengNums_hotfix = (luaObj.RawGet("FlushChallengNums") as LuaFunction);
					this.m_IsDailyChallenge_hotfix = (luaObj.RawGet("IsDailyChallenge") as LuaFunction);
					this.m_GetDailyChallengNums_hotfix = (luaObj.RawGet("GetDailyChallengNums") as LuaFunction);
					this.m_AddChallengedNumsInt32_hotfix = (luaObj.RawGet("AddChallengedNums") as LuaFunction);
					this.m_GetAllUnlockedLevels_hotfix = (luaObj.RawGet("GetAllUnlockedLevels") as LuaFunction);
					this.m_IsLevelUnlockedInt32_hotfix = (luaObj.RawGet("IsLevelUnlocked") as LuaFunction);
					this.m_add_CompleteHeroTrainningMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteHeroTrainningMissionEvent") as LuaFunction);
					this.m_remove_CompleteHeroTrainningMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteHeroTrainningMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00144D20 File Offset: 0x00142F20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003354 RID: 13140
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003355 RID: 13141
		protected DataSectionHeroTrainning m_heroTrainningDS = new DataSectionHeroTrainning();

		// Token: 0x04003356 RID: 13142
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003357 RID: 13143
		protected BattleComponentCommon m_battle;

		// Token: 0x04003358 RID: 13144
		protected RiftComponentCommon m_rift;

		// Token: 0x04003359 RID: 13145
		protected HeroComponentCommon m_hero;

		// Token: 0x0400335A RID: 13146
		protected BagComponentCommon m_bag;

		// Token: 0x0400335C RID: 13148
		[DoNotToLua]
		private HeroTrainningComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400335D RID: 13149
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400335E RID: 13150
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400335F RID: 13151
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003360 RID: 13152
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003361 RID: 13153
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003362 RID: 13154
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003363 RID: 13155
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003364 RID: 13156
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003365 RID: 13157
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003366 RID: 13158
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003367 RID: 13159
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003368 RID: 13160
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003369 RID: 13161
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400336A RID: 13162
		private LuaFunction m_AttackHeroTrainningLevelInt32_hotfix;

		// Token: 0x0400336B RID: 13163
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x0400336C RID: 13164
		private LuaFunction m_CanAttackHeroTrainningLevelInt32Boolean_hotfix;

		// Token: 0x0400336D RID: 13165
		private LuaFunction m_CanOpenLevelInt32_hotfix;

		// Token: 0x0400336E RID: 13166
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x0400336F RID: 13167
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataHeroTrainningLevelInfoBoolean_hotfix;

		// Token: 0x04003370 RID: 13168
		private LuaFunction m_SetCommonSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List;

		// Token: 0x04003371 RID: 13169
		private LuaFunction m_GetAllFinishedLevels_hotfix;

		// Token: 0x04003372 RID: 13170
		private LuaFunction m_get_HasRewardAddRelativeOperationalActivity_hotfix;

		// Token: 0x04003373 RID: 13171
		private LuaFunction m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix;

		// Token: 0x04003374 RID: 13172
		private LuaFunction m_FlushChallengNums_hotfix;

		// Token: 0x04003375 RID: 13173
		private LuaFunction m_IsDailyChallenge_hotfix;

		// Token: 0x04003376 RID: 13174
		private LuaFunction m_GetDailyChallengNums_hotfix;

		// Token: 0x04003377 RID: 13175
		private LuaFunction m_AddChallengedNumsInt32_hotfix;

		// Token: 0x04003378 RID: 13176
		private LuaFunction m_GetAllUnlockedLevels_hotfix;

		// Token: 0x04003379 RID: 13177
		private LuaFunction m_IsLevelUnlockedInt32_hotfix;

		// Token: 0x0400337A RID: 13178
		private LuaFunction m_add_CompleteHeroTrainningMissionEventAction;

		// Token: 0x0400337B RID: 13179
		private LuaFunction m_remove_CompleteHeroTrainningMissionEventAction;

		// Token: 0x0200047D RID: 1149
		public class LuaExportHelper
		{
			// Token: 0x06004391 RID: 17297 RVA: 0x00144D88 File Offset: 0x00142F88
			public LuaExportHelper(HeroTrainningComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004392 RID: 17298 RVA: 0x00144D98 File Offset: 0x00142F98
			public void __callDele_CompleteHeroTrainningMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteHeroTrainningMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004393 RID: 17299 RVA: 0x00144DA8 File Offset: 0x00142FA8
			public void __clearDele_CompleteHeroTrainningMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteHeroTrainningMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x06004394 RID: 17300 RVA: 0x00144DB8 File Offset: 0x00142FB8
			// (set) Token: 0x06004395 RID: 17301 RVA: 0x00144DC8 File Offset: 0x00142FC8
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

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x06004396 RID: 17302 RVA: 0x00144DD8 File Offset: 0x00142FD8
			// (set) Token: 0x06004397 RID: 17303 RVA: 0x00144DE8 File Offset: 0x00142FE8
			public DataSectionHeroTrainning m_heroTrainningDS
			{
				get
				{
					return this.m_owner.m_heroTrainningDS;
				}
				set
				{
					this.m_owner.m_heroTrainningDS = value;
				}
			}

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x06004398 RID: 17304 RVA: 0x00144DF8 File Offset: 0x00142FF8
			// (set) Token: 0x06004399 RID: 17305 RVA: 0x00144E08 File Offset: 0x00143008
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

			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x0600439A RID: 17306 RVA: 0x00144E18 File Offset: 0x00143018
			// (set) Token: 0x0600439B RID: 17307 RVA: 0x00144E28 File Offset: 0x00143028
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

			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x0600439C RID: 17308 RVA: 0x00144E38 File Offset: 0x00143038
			// (set) Token: 0x0600439D RID: 17309 RVA: 0x00144E48 File Offset: 0x00143048
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

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x0600439E RID: 17310 RVA: 0x00144E58 File Offset: 0x00143058
			// (set) Token: 0x0600439F RID: 17311 RVA: 0x00144E68 File Offset: 0x00143068
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

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x060043A0 RID: 17312 RVA: 0x00144E78 File Offset: 0x00143078
			// (set) Token: 0x060043A1 RID: 17313 RVA: 0x00144E88 File Offset: 0x00143088
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

			// Token: 0x060043A2 RID: 17314 RVA: 0x00144E98 File Offset: 0x00143098
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x060043A3 RID: 17315 RVA: 0x00144EA8 File Offset: 0x001430A8
			public int CanOpenLevel(int levelId)
			{
				return this.m_owner.CanOpenLevel(levelId);
			}

			// Token: 0x060043A4 RID: 17316 RVA: 0x00144EB8 File Offset: 0x001430B8
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataHeroTrainningLevelInfo levelInfo, bool isTeamBattle)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
			}

			// Token: 0x060043A5 RID: 17317 RVA: 0x00144EC8 File Offset: 0x001430C8
			public void SetCommonSuccessHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.SetCommonSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x060043A6 RID: 17318 RVA: 0x00144EDC File Offset: 0x001430DC
			public void FlushChallengNums()
			{
				this.m_owner.FlushChallengNums();
			}

			// Token: 0x060043A7 RID: 17319 RVA: 0x00144EEC File Offset: 0x001430EC
			public void AddChallengedNums(int nums)
			{
				this.m_owner.AddChallengedNums(nums);
			}

			// Token: 0x0400337C RID: 13180
			private HeroTrainningComponentCommon m_owner;
		}
	}
}
