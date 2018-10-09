using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200042B RID: 1067
	[HotFix]
	public class AnikiGymComponentCommon : IComponentBase
	{
		// Token: 0x06003D6A RID: 15722 RVA: 0x00115074 File Offset: 0x00113274
		public AnikiGymComponentCommon()
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

		// Token: 0x06003D6B RID: 15723 RVA: 0x001150E8 File Offset: 0x001132E8
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
			return "AnikiGym";
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x0011515C File Offset: 0x0011335C
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

		// Token: 0x06003D6D RID: 15725 RVA: 0x001151C4 File Offset: 0x001133C4
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

		// Token: 0x06003D6E RID: 15726 RVA: 0x001152C4 File Offset: 0x001134C4
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

		// Token: 0x06003D6F RID: 15727 RVA: 0x00115324 File Offset: 0x00113524
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

		// Token: 0x06003D70 RID: 15728 RVA: 0x00115394 File Offset: 0x00113594
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

		// Token: 0x06003D71 RID: 15729 RVA: 0x00115414 File Offset: 0x00113614
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

		// Token: 0x06003D72 RID: 15730 RVA: 0x00115484 File Offset: 0x00113684
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

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06003D73 RID: 15731 RVA: 0x001154E4 File Offset: 0x001136E4
		// (set) Token: 0x06003D74 RID: 15732 RVA: 0x00115558 File Offset: 0x00113758
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

		// Token: 0x06003D75 RID: 15733 RVA: 0x001155D0 File Offset: 0x001137D0
		public int AttackAnikiGymLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackAnikiGymLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackAnikiGymLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackAnikiGymLevel(levelId, false);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataAnikiLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_AnikiGym, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.AnikiGym, levelId);
			return 0;
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x001156B4 File Offset: 0x001138B4
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
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AnikiGym);
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00115730 File Offset: 0x00113930
		public virtual int CanAttackAnikiGymLevel(int levelId, bool isTeamBattle = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackAnikiGymLevelInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackAnikiGymLevelInt32Boolean_hotfix.call(new object[]
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
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(levelId);
			return this.CanAttackLevelByEnergyAndSoOn(configDataAnikiLevelInfo, isTeamBattle);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x001157F8 File Offset: 0x001139F8
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
				return -1909;
			}
			ConfigDataAnikiLevelInfo levelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(levelId);
			if (levelInfo == null)
			{
				return -1901;
			}
			if (levelInfo.m_battleInfo == null)
			{
				return -1907;
			}
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataAnikiGymInfo> list;
			if (!this.m_configDataLoader.AnikiGymData.AnikiGymOfWeekDict.TryGetValue(key, out list))
			{
				return -1900;
			}
			if (list.Find((ConfigDataAnikiGymInfo t) => t.ID == levelInfo.m_groupInfo.ID) == null)
			{
				return -1902;
			}
			if (levelInfo.PreLevel != 0 && !this.m_anikiGymDS.IsLevelFinished(levelInfo.PreLevel))
			{
				return -1903;
			}
			return 0;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x0011595C File Offset: 0x00113B5C
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
			return this.m_anikiGymDS.IsLevelFinished(levelId);
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x001159E4 File Offset: 0x00113BE4
		private int CanAttackLevelByEnergyAndSoOn(ConfigDataAnikiLevelInfo levelInfo, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataAnikiLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataAnikiLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_AnikiGym);
			if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, ticketId, levelInfo.TicketCost))
			{
				return -1908;
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

		// Token: 0x06003D7B RID: 15739 RVA: 0x00115AE0 File Offset: 0x00113CE0
		protected void SetCommonSuccessAnikiGymLevel(ConfigDataAnikiLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List`1Int32Boolean_hotfix != null)
			{
				this.m_SetCommonSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List`1Int32Boolean_hotfix.call(new object[]
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
			this.m_basicInfo.AddGold(levelInfo.Gold, GameFunctionType.GameFunctionType_AnikiGym, levelInfo.ID.ToString());
			if (levelInfo.TicketCost > 0)
			{
				int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_AnikiGym);
				BagItemBase bagItem = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
				this.m_bag.RemoveBagItemDirectly(bagItem, levelInfo.TicketCost, GameFunctionType.GameFunctionType_AnikiGym, levelInfo.ID.ToString());
			}
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_AnikiGym, levelInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			if (this.IsDailyChallenge())
			{
				this.AddChallengedNums(1);
			}
			if (!isBattleTeam)
			{
				this.m_anikiGymDS.AddFinishedLevel(levelInfo.ID);
			}
			if (this.CompleteAnikiGymMissionEvent != null)
			{
				this.CompleteAnikiGymMissionEvent(BattleType.AnikiGym, levelInfo.ID, heroes);
			}
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x00115CC0 File Offset: 0x00113EC0
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
			return this.m_anikiGymDS.GetAllFinishedLevels();
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x00115D38 File Offset: 0x00113F38
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x00115DAC File Offset: 0x00113FAC
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

		// Token: 0x06003D7F RID: 15743 RVA: 0x00115E24 File Offset: 0x00114024
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
			this.m_anikiGymDS.SetChallengedNums(0);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x00115E90 File Offset: 0x00114090
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

		// Token: 0x06003D81 RID: 15745 RVA: 0x00115F08 File Offset: 0x00114108
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
			int dailyBonusMaxNums = this.m_battle.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_AnikiGym);
			int challengedNums = this.m_anikiGymDS.ChallengedNums;
			if (dailyBonusMaxNums > challengedNums)
			{
				return dailyBonusMaxNums - challengedNums;
			}
			return 0;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x00115F9C File Offset: 0x0011419C
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
			this.m_anikiGymDS.AddChallengedNums(nums);
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00116018 File Offset: 0x00114218
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
			List<ConfigDataAnikiGymInfo> list2;
			if (!this.m_configDataLoader.AnikiGymData.AnikiGymOfWeekDict.TryGetValue(key, out list2))
			{
				return list;
			}
			foreach (ConfigDataAnikiGymInfo configDataAnikiGymInfo in list2)
			{
				foreach (ConfigDataAnikiLevelInfo configDataAnikiLevelInfo in configDataAnikiGymInfo.m_levelInfos)
				{
					if (configDataAnikiLevelInfo.PreLevel == 0 || this.IsLevelFinished(configDataAnikiLevelInfo.PreLevel))
					{
						list.Add(configDataAnikiLevelInfo.ID);
					}
				}
			}
			return list;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00116184 File Offset: 0x00114384
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

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06003D85 RID: 15749 RVA: 0x0011620C File Offset: 0x0011440C
		// (remove) Token: 0x06003D86 RID: 15750 RVA: 0x001162A8 File Offset: 0x001144A8
		public event Action<BattleType, int, List<int>> CompleteAnikiGymMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteAnikiGymMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteAnikiGymMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteAnikiGymMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteAnikiGymMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteAnikiGymMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteAnikiGymMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteAnikiGymMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteAnikiGymMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x00116344 File Offset: 0x00114544
		// (set) Token: 0x06003D88 RID: 15752 RVA: 0x00116364 File Offset: 0x00114564
		[DoNotToLua]
		public AnikiGymComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AnikiGymComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00116370 File Offset: 0x00114570
		private void __callDele_CompleteAnikiGymMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeAnikiGymMissionEvent = this.CompleteAnikiGymMissionEvent;
			if (completeAnikiGymMissionEvent != null)
			{
				completeAnikiGymMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00116394 File Offset: 0x00114594
		private void __clearDele_CompleteAnikiGymMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteAnikiGymMissionEvent = null;
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x001163A0 File Offset: 0x001145A0
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
					this.m_AttackAnikiGymLevelInt32_hotfix = (luaObj.RawGet("AttackAnikiGymLevel") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_CanAttackAnikiGymLevelInt32Boolean_hotfix = (luaObj.RawGet("CanAttackAnikiGymLevel") as LuaFunction);
					this.m_CanOpenLevelInt32_hotfix = (luaObj.RawGet("CanOpenLevel") as LuaFunction);
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataAnikiLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_SetCommonSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List`1Int32Boolean_hotfix = (luaObj.RawGet("SetCommonSuccessAnikiGymLevel") as LuaFunction);
					this.m_GetAllFinishedLevels_hotfix = (luaObj.RawGet("GetAllFinishedLevels") as LuaFunction);
					this.m_get_HasRewardAddRelativeOperationalActivity_hotfix = (luaObj.RawGet("get_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix = (luaObj.RawGet("set_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_FlushChallengNums_hotfix = (luaObj.RawGet("FlushChallengNums") as LuaFunction);
					this.m_IsDailyChallenge_hotfix = (luaObj.RawGet("IsDailyChallenge") as LuaFunction);
					this.m_GetDailyChallengNums_hotfix = (luaObj.RawGet("GetDailyChallengNums") as LuaFunction);
					this.m_AddChallengedNumsInt32_hotfix = (luaObj.RawGet("AddChallengedNums") as LuaFunction);
					this.m_GetAllUnlockedLevels_hotfix = (luaObj.RawGet("GetAllUnlockedLevels") as LuaFunction);
					this.m_IsLevelUnlockedInt32_hotfix = (luaObj.RawGet("IsLevelUnlocked") as LuaFunction);
					this.m_add_CompleteAnikiGymMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteAnikiGymMissionEvent") as LuaFunction);
					this.m_remove_CompleteAnikiGymMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteAnikiGymMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x00116728 File Offset: 0x00114928
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002E66 RID: 11878
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04002E67 RID: 11879
		protected DataSectionAnikiGym m_anikiGymDS = new DataSectionAnikiGym();

		// Token: 0x04002E68 RID: 11880
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04002E69 RID: 11881
		protected BattleComponentCommon m_battle;

		// Token: 0x04002E6A RID: 11882
		protected RiftComponentCommon m_rift;

		// Token: 0x04002E6B RID: 11883
		protected HeroComponentCommon m_hero;

		// Token: 0x04002E6C RID: 11884
		protected BagComponentCommon m_bag;

		// Token: 0x04002E6E RID: 11886
		[DoNotToLua]
		private AnikiGymComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002E6F RID: 11887
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002E70 RID: 11888
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002E71 RID: 11889
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002E72 RID: 11890
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002E73 RID: 11891
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002E74 RID: 11892
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002E75 RID: 11893
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002E76 RID: 11894
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002E77 RID: 11895
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002E78 RID: 11896
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002E79 RID: 11897
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002E7A RID: 11898
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04002E7B RID: 11899
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04002E7C RID: 11900
		private LuaFunction m_AttackAnikiGymLevelInt32_hotfix;

		// Token: 0x04002E7D RID: 11901
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x04002E7E RID: 11902
		private LuaFunction m_CanAttackAnikiGymLevelInt32Boolean_hotfix;

		// Token: 0x04002E7F RID: 11903
		private LuaFunction m_CanOpenLevelInt32_hotfix;

		// Token: 0x04002E80 RID: 11904
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x04002E81 RID: 11905
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataAnikiLevelInfoBoolean_hotfix;

		// Token: 0x04002E82 RID: 11906
		private LuaFunction m_SetCommonSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List;

		// Token: 0x04002E83 RID: 11907
		private LuaFunction m_GetAllFinishedLevels_hotfix;

		// Token: 0x04002E84 RID: 11908
		private LuaFunction m_get_HasRewardAddRelativeOperationalActivity_hotfix;

		// Token: 0x04002E85 RID: 11909
		private LuaFunction m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix;

		// Token: 0x04002E86 RID: 11910
		private LuaFunction m_FlushChallengNums_hotfix;

		// Token: 0x04002E87 RID: 11911
		private LuaFunction m_IsDailyChallenge_hotfix;

		// Token: 0x04002E88 RID: 11912
		private LuaFunction m_GetDailyChallengNums_hotfix;

		// Token: 0x04002E89 RID: 11913
		private LuaFunction m_AddChallengedNumsInt32_hotfix;

		// Token: 0x04002E8A RID: 11914
		private LuaFunction m_GetAllUnlockedLevels_hotfix;

		// Token: 0x04002E8B RID: 11915
		private LuaFunction m_IsLevelUnlockedInt32_hotfix;

		// Token: 0x04002E8C RID: 11916
		private LuaFunction m_add_CompleteAnikiGymMissionEventAction;

		// Token: 0x04002E8D RID: 11917
		private LuaFunction m_remove_CompleteAnikiGymMissionEventAction;

		// Token: 0x0200042C RID: 1068
		public class LuaExportHelper
		{
			// Token: 0x06003D8D RID: 15757 RVA: 0x00116790 File Offset: 0x00114990
			public LuaExportHelper(AnikiGymComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003D8E RID: 15758 RVA: 0x001167A0 File Offset: 0x001149A0
			public void __callDele_CompleteAnikiGymMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteAnikiGymMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06003D8F RID: 15759 RVA: 0x001167B0 File Offset: 0x001149B0
			public void __clearDele_CompleteAnikiGymMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteAnikiGymMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x170010C1 RID: 4289
			// (get) Token: 0x06003D90 RID: 15760 RVA: 0x001167C0 File Offset: 0x001149C0
			// (set) Token: 0x06003D91 RID: 15761 RVA: 0x001167D0 File Offset: 0x001149D0
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

			// Token: 0x170010C2 RID: 4290
			// (get) Token: 0x06003D92 RID: 15762 RVA: 0x001167E0 File Offset: 0x001149E0
			// (set) Token: 0x06003D93 RID: 15763 RVA: 0x001167F0 File Offset: 0x001149F0
			public DataSectionAnikiGym m_anikiGymDS
			{
				get
				{
					return this.m_owner.m_anikiGymDS;
				}
				set
				{
					this.m_owner.m_anikiGymDS = value;
				}
			}

			// Token: 0x170010C3 RID: 4291
			// (get) Token: 0x06003D94 RID: 15764 RVA: 0x00116800 File Offset: 0x00114A00
			// (set) Token: 0x06003D95 RID: 15765 RVA: 0x00116810 File Offset: 0x00114A10
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

			// Token: 0x170010C4 RID: 4292
			// (get) Token: 0x06003D96 RID: 15766 RVA: 0x00116820 File Offset: 0x00114A20
			// (set) Token: 0x06003D97 RID: 15767 RVA: 0x00116830 File Offset: 0x00114A30
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

			// Token: 0x170010C5 RID: 4293
			// (get) Token: 0x06003D98 RID: 15768 RVA: 0x00116840 File Offset: 0x00114A40
			// (set) Token: 0x06003D99 RID: 15769 RVA: 0x00116850 File Offset: 0x00114A50
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

			// Token: 0x170010C6 RID: 4294
			// (get) Token: 0x06003D9A RID: 15770 RVA: 0x00116860 File Offset: 0x00114A60
			// (set) Token: 0x06003D9B RID: 15771 RVA: 0x00116870 File Offset: 0x00114A70
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

			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x06003D9C RID: 15772 RVA: 0x00116880 File Offset: 0x00114A80
			// (set) Token: 0x06003D9D RID: 15773 RVA: 0x00116890 File Offset: 0x00114A90
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

			// Token: 0x06003D9E RID: 15774 RVA: 0x001168A0 File Offset: 0x00114AA0
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x06003D9F RID: 15775 RVA: 0x001168B0 File Offset: 0x00114AB0
			public int CanOpenLevel(int levelId)
			{
				return this.m_owner.CanOpenLevel(levelId);
			}

			// Token: 0x06003DA0 RID: 15776 RVA: 0x001168C0 File Offset: 0x00114AC0
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataAnikiLevelInfo levelInfo, bool isTeamBattle)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
			}

			// Token: 0x06003DA1 RID: 15777 RVA: 0x001168D0 File Offset: 0x00114AD0
			public void SetCommonSuccessAnikiGymLevel(ConfigDataAnikiLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.SetCommonSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x06003DA2 RID: 15778 RVA: 0x001168E4 File Offset: 0x00114AE4
			public void FlushChallengNums()
			{
				this.m_owner.FlushChallengNums();
			}

			// Token: 0x06003DA3 RID: 15779 RVA: 0x001168F4 File Offset: 0x00114AF4
			public void AddChallengedNums(int nums)
			{
				this.m_owner.AddChallengedNums(nums);
			}

			// Token: 0x04002E8E RID: 11918
			private AnikiGymComponentCommon m_owner;
		}
	}
}
