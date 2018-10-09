using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000483 RID: 1155
	[HotFix]
	public class MemoryCorridorCompomentCommon : IComponentBase
	{
		// Token: 0x0600445E RID: 17502 RVA: 0x0014A534 File Offset: 0x00148734
		public MemoryCorridorCompomentCommon()
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

		// Token: 0x0600445F RID: 17503 RVA: 0x0014A5A8 File Offset: 0x001487A8
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
			return "MemoryCorridor";
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x0014A61C File Offset: 0x0014881C
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

		// Token: 0x06004461 RID: 17505 RVA: 0x0014A684 File Offset: 0x00148884
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

		// Token: 0x06004462 RID: 17506 RVA: 0x0014A784 File Offset: 0x00148984
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

		// Token: 0x06004463 RID: 17507 RVA: 0x0014A7E4 File Offset: 0x001489E4
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

		// Token: 0x06004464 RID: 17508 RVA: 0x0014A854 File Offset: 0x00148A54
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

		// Token: 0x06004465 RID: 17509 RVA: 0x0014A8D4 File Offset: 0x00148AD4
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

		// Token: 0x06004466 RID: 17510 RVA: 0x0014A944 File Offset: 0x00148B44
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

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x0014A9A4 File Offset: 0x00148BA4
		// (set) Token: 0x06004468 RID: 17512 RVA: 0x0014AA18 File Offset: 0x00148C18
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

		// Token: 0x06004469 RID: 17513 RVA: 0x0014AA90 File Offset: 0x00148C90
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
			return this.m_memoryCorridorDS.IsLevelFinished(levelId);
		}

		// Token: 0x0600446A RID: 17514 RVA: 0x0014AB18 File Offset: 0x00148D18
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
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_MemoryCorridor);
		}

		// Token: 0x0600446B RID: 17515 RVA: 0x0014AB94 File Offset: 0x00148D94
		public int AttackMemoryCorridorLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackMemoryCorridorLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackMemoryCorridorLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackMemoryCorridorLevel(levelId, false);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataMemoryCorridorLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_MemoryCorridor, levelId.ToString());
			this.m_battle.SetProcessingBattleInfo(BattleType.MemoryCorridor, levelId);
			return 0;
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x0014AC78 File Offset: 0x00148E78
		public virtual int CanAttackMemoryCorridorLevel(int levelId, bool isTeamBattle = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackMemoryCorridorLevelInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackMemoryCorridorLevelInt32Boolean_hotfix.call(new object[]
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
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
			return this.CanAttackLevelByEnergyAndSoOn(configDataMemoryCorridorLevelInfo, isTeamBattle);
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x0014AD40 File Offset: 0x00148F40
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
				return -2805;
			}
			ConfigDataMemoryCorridorLevelInfo levelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
			if (levelInfo == null)
			{
				return -2801;
			}
			if (levelInfo.m_battleInfo == null)
			{
				return -2802;
			}
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataMemoryCorridorInfo> list;
			if (!this.m_configDataLoader.MemoryCorridorData.MemoryCorridorOfWeekDict.TryGetValue(key, out list))
			{
				return -2804;
			}
			if (list.Find((ConfigDataMemoryCorridorInfo t) => t.ID == levelInfo.m_groupInfo.ID) == null)
			{
				return -2803;
			}
			int level = this.m_basicInfo.GetLevel();
			if (level < levelInfo.OpenPlayerLevel)
			{
				return -413;
			}
			return 0;
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x0014AE98 File Offset: 0x00149098
		private int CanAttackLevelByEnergyAndSoOn(ConfigDataMemoryCorridorLevelInfo levelInfo, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataMemoryCorridorLevelInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataMemoryCorridorLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					isTeamBattle
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_MemoryCorridor);
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

		// Token: 0x0600446F RID: 17519 RVA: 0x0014AF94 File Offset: 0x00149194
		protected void SetCommonSuccessMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List`1Int32Boolean_hotfix != null)
			{
				this.m_SetCommonSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List`1Int32Boolean_hotfix.call(new object[]
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
			this.m_basicInfo.AddGold(levelInfo.Gold, GameFunctionType.GameFunctionType_MemoryCorridor, levelInfo.ID.ToString());
			if (levelInfo.TicketCost > 0)
			{
				int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_MemoryCorridor);
				BagItemBase bagItem = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
				this.m_bag.RemoveBagItemDirectly(bagItem, levelInfo.TicketCost, GameFunctionType.GameFunctionType_MemoryCorridor, levelInfo.ID.ToString());
			}
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_MemoryCorridor, levelInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			if (!isBattleTeam)
			{
				this.m_memoryCorridorDS.AddFinishedLevel(levelInfo.ID);
			}
			if (this.IsDailyChallenge())
			{
				this.AddChallengedNums(1);
			}
			if (this.CompleteMemoryCorridorMissionEvent != null)
			{
				this.CompleteMemoryCorridorMissionEvent(BattleType.MemoryCorridor, levelInfo.ID, heroes);
			}
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x0014B174 File Offset: 0x00149374
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
			return this.m_memoryCorridorDS.GetAllFinishedLevels();
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x0014B1EC File Offset: 0x001493EC
		// (set) Token: 0x06004472 RID: 17522 RVA: 0x0014B260 File Offset: 0x00149460
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

		// Token: 0x06004473 RID: 17523 RVA: 0x0014B2D8 File Offset: 0x001494D8
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
			this.m_memoryCorridorDS.SetChallengedNums(0);
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x0014B344 File Offset: 0x00149544
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

		// Token: 0x06004475 RID: 17525 RVA: 0x0014B3BC File Offset: 0x001495BC
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
			int dailyBonusMaxNums = this.m_battle.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_MemoryCorridor);
			int challengedNums = this.m_memoryCorridorDS.ChallengedNums;
			if (dailyBonusMaxNums > challengedNums)
			{
				return dailyBonusMaxNums - challengedNums;
			}
			return 0;
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x0014B450 File Offset: 0x00149650
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
			this.m_memoryCorridorDS.AddChallengedNums(nums);
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x0014B4CC File Offset: 0x001496CC
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
			List<ConfigDataMemoryCorridorInfo> list2;
			if (!this.m_configDataLoader.MemoryCorridorData.MemoryCorridorOfWeekDict.TryGetValue(key, out list2))
			{
				return list;
			}
			int level = this.m_basicInfo.GetLevel();
			foreach (ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo in list2)
			{
				foreach (ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo in configDataMemoryCorridorInfo.m_levelInfos)
				{
					if (level >= configDataMemoryCorridorLevelInfo.OpenPlayerLevel)
					{
						list.Add(configDataMemoryCorridorLevelInfo.ID);
					}
				}
			}
			return list;
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x0014B638 File Offset: 0x00149838
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

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06004479 RID: 17529 RVA: 0x0014B6C0 File Offset: 0x001498C0
		// (remove) Token: 0x0600447A RID: 17530 RVA: 0x0014B75C File Offset: 0x0014995C
		public event Action<BattleType, int, List<int>> CompleteMemoryCorridorMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteMemoryCorridorMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteMemoryCorridorMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteMemoryCorridorMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteMemoryCorridorMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteMemoryCorridorMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteMemoryCorridorMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteMemoryCorridorMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteMemoryCorridorMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x0014B7F8 File Offset: 0x001499F8
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x0014B818 File Offset: 0x00149A18
		[DoNotToLua]
		public MemoryCorridorCompomentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MemoryCorridorCompomentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x0014B824 File Offset: 0x00149A24
		private void __callDele_CompleteMemoryCorridorMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeMemoryCorridorMissionEvent = this.CompleteMemoryCorridorMissionEvent;
			if (completeMemoryCorridorMissionEvent != null)
			{
				completeMemoryCorridorMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x0014B848 File Offset: 0x00149A48
		private void __clearDele_CompleteMemoryCorridorMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteMemoryCorridorMissionEvent = null;
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x0014B854 File Offset: 0x00149A54
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
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_AttackMemoryCorridorLevelInt32_hotfix = (luaObj.RawGet("AttackMemoryCorridorLevel") as LuaFunction);
					this.m_CanAttackMemoryCorridorLevelInt32Boolean_hotfix = (luaObj.RawGet("CanAttackMemoryCorridorLevel") as LuaFunction);
					this.m_CanOpenLevelInt32_hotfix = (luaObj.RawGet("CanOpenLevel") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataMemoryCorridorLevelInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_SetCommonSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List`1Int32Boolean_hotfix = (luaObj.RawGet("SetCommonSuccessMemoryCorridorLevel") as LuaFunction);
					this.m_GetAllFinishedLevels_hotfix = (luaObj.RawGet("GetAllFinishedLevels") as LuaFunction);
					this.m_get_HasRewardAddRelativeOperationalActivity_hotfix = (luaObj.RawGet("get_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix = (luaObj.RawGet("set_HasRewardAddRelativeOperationalActivity") as LuaFunction);
					this.m_FlushChallengNums_hotfix = (luaObj.RawGet("FlushChallengNums") as LuaFunction);
					this.m_IsDailyChallenge_hotfix = (luaObj.RawGet("IsDailyChallenge") as LuaFunction);
					this.m_GetDailyChallengNums_hotfix = (luaObj.RawGet("GetDailyChallengNums") as LuaFunction);
					this.m_AddChallengedNumsInt32_hotfix = (luaObj.RawGet("AddChallengedNums") as LuaFunction);
					this.m_GetAllUnlockedLevels_hotfix = (luaObj.RawGet("GetAllUnlockedLevels") as LuaFunction);
					this.m_IsLevelUnlockedInt32_hotfix = (luaObj.RawGet("IsLevelUnlocked") as LuaFunction);
					this.m_add_CompleteMemoryCorridorMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteMemoryCorridorMissionEvent") as LuaFunction);
					this.m_remove_CompleteMemoryCorridorMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteMemoryCorridorMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x0014BBDC File Offset: 0x00149DDC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorCompomentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003400 RID: 13312
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003401 RID: 13313
		protected DataSectionMemoryCorridor m_memoryCorridorDS = new DataSectionMemoryCorridor();

		// Token: 0x04003402 RID: 13314
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003403 RID: 13315
		protected BattleComponentCommon m_battle;

		// Token: 0x04003404 RID: 13316
		protected RiftComponentCommon m_rift;

		// Token: 0x04003405 RID: 13317
		protected HeroComponentCommon m_hero;

		// Token: 0x04003406 RID: 13318
		protected BagComponentCommon m_bag;

		// Token: 0x04003408 RID: 13320
		[DoNotToLua]
		private MemoryCorridorCompomentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003409 RID: 13321
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400340A RID: 13322
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400340B RID: 13323
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400340C RID: 13324
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400340D RID: 13325
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400340E RID: 13326
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400340F RID: 13327
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003410 RID: 13328
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003411 RID: 13329
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003412 RID: 13330
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003413 RID: 13331
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003414 RID: 13332
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003415 RID: 13333
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003416 RID: 13334
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x04003417 RID: 13335
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x04003418 RID: 13336
		private LuaFunction m_AttackMemoryCorridorLevelInt32_hotfix;

		// Token: 0x04003419 RID: 13337
		private LuaFunction m_CanAttackMemoryCorridorLevelInt32Boolean_hotfix;

		// Token: 0x0400341A RID: 13338
		private LuaFunction m_CanOpenLevelInt32_hotfix;

		// Token: 0x0400341B RID: 13339
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataMemoryCorridorLevelInfoBoolean_hotfix;

		// Token: 0x0400341C RID: 13340
		private LuaFunction m_SetCommonSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List;

		// Token: 0x0400341D RID: 13341
		private LuaFunction m_GetAllFinishedLevels_hotfix;

		// Token: 0x0400341E RID: 13342
		private LuaFunction m_get_HasRewardAddRelativeOperationalActivity_hotfix;

		// Token: 0x0400341F RID: 13343
		private LuaFunction m_set_HasRewardAddRelativeOperationalActivityBoolean_hotfix;

		// Token: 0x04003420 RID: 13344
		private LuaFunction m_FlushChallengNums_hotfix;

		// Token: 0x04003421 RID: 13345
		private LuaFunction m_IsDailyChallenge_hotfix;

		// Token: 0x04003422 RID: 13346
		private LuaFunction m_GetDailyChallengNums_hotfix;

		// Token: 0x04003423 RID: 13347
		private LuaFunction m_AddChallengedNumsInt32_hotfix;

		// Token: 0x04003424 RID: 13348
		private LuaFunction m_GetAllUnlockedLevels_hotfix;

		// Token: 0x04003425 RID: 13349
		private LuaFunction m_IsLevelUnlockedInt32_hotfix;

		// Token: 0x04003426 RID: 13350
		private LuaFunction m_add_CompleteMemoryCorridorMissionEventAction;

		// Token: 0x04003427 RID: 13351
		private LuaFunction m_remove_CompleteMemoryCorridorMissionEventAction;

		// Token: 0x02000484 RID: 1156
		public class LuaExportHelper
		{
			// Token: 0x06004481 RID: 17537 RVA: 0x0014BC44 File Offset: 0x00149E44
			public LuaExportHelper(MemoryCorridorCompomentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004482 RID: 17538 RVA: 0x0014BC54 File Offset: 0x00149E54
			public void __callDele_CompleteMemoryCorridorMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteMemoryCorridorMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x06004483 RID: 17539 RVA: 0x0014BC64 File Offset: 0x00149E64
			public void __clearDele_CompleteMemoryCorridorMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteMemoryCorridorMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x1700119D RID: 4509
			// (get) Token: 0x06004484 RID: 17540 RVA: 0x0014BC74 File Offset: 0x00149E74
			// (set) Token: 0x06004485 RID: 17541 RVA: 0x0014BC84 File Offset: 0x00149E84
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

			// Token: 0x1700119E RID: 4510
			// (get) Token: 0x06004486 RID: 17542 RVA: 0x0014BC94 File Offset: 0x00149E94
			// (set) Token: 0x06004487 RID: 17543 RVA: 0x0014BCA4 File Offset: 0x00149EA4
			public DataSectionMemoryCorridor m_memoryCorridorDS
			{
				get
				{
					return this.m_owner.m_memoryCorridorDS;
				}
				set
				{
					this.m_owner.m_memoryCorridorDS = value;
				}
			}

			// Token: 0x1700119F RID: 4511
			// (get) Token: 0x06004488 RID: 17544 RVA: 0x0014BCB4 File Offset: 0x00149EB4
			// (set) Token: 0x06004489 RID: 17545 RVA: 0x0014BCC4 File Offset: 0x00149EC4
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

			// Token: 0x170011A0 RID: 4512
			// (get) Token: 0x0600448A RID: 17546 RVA: 0x0014BCD4 File Offset: 0x00149ED4
			// (set) Token: 0x0600448B RID: 17547 RVA: 0x0014BCE4 File Offset: 0x00149EE4
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

			// Token: 0x170011A1 RID: 4513
			// (get) Token: 0x0600448C RID: 17548 RVA: 0x0014BCF4 File Offset: 0x00149EF4
			// (set) Token: 0x0600448D RID: 17549 RVA: 0x0014BD04 File Offset: 0x00149F04
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

			// Token: 0x170011A2 RID: 4514
			// (get) Token: 0x0600448E RID: 17550 RVA: 0x0014BD14 File Offset: 0x00149F14
			// (set) Token: 0x0600448F RID: 17551 RVA: 0x0014BD24 File Offset: 0x00149F24
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

			// Token: 0x170011A3 RID: 4515
			// (get) Token: 0x06004490 RID: 17552 RVA: 0x0014BD34 File Offset: 0x00149F34
			// (set) Token: 0x06004491 RID: 17553 RVA: 0x0014BD44 File Offset: 0x00149F44
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

			// Token: 0x06004492 RID: 17554 RVA: 0x0014BD54 File Offset: 0x00149F54
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x06004493 RID: 17555 RVA: 0x0014BD64 File Offset: 0x00149F64
			public int CanOpenLevel(int levelId)
			{
				return this.m_owner.CanOpenLevel(levelId);
			}

			// Token: 0x06004494 RID: 17556 RVA: 0x0014BD74 File Offset: 0x00149F74
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataMemoryCorridorLevelInfo levelInfo, bool isTeamBattle)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
			}

			// Token: 0x06004495 RID: 17557 RVA: 0x0014BD84 File Offset: 0x00149F84
			public void SetCommonSuccessMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.SetCommonSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x06004496 RID: 17558 RVA: 0x0014BD98 File Offset: 0x00149F98
			public void FlushChallengNums()
			{
				this.m_owner.FlushChallengNums();
			}

			// Token: 0x06004497 RID: 17559 RVA: 0x0014BDA8 File Offset: 0x00149FA8
			public void AddChallengedNums(int nums)
			{
				this.m_owner.AddChallengedNums(nums);
			}

			// Token: 0x04003428 RID: 13352
			private MemoryCorridorCompomentCommon m_owner;
		}
	}
}
