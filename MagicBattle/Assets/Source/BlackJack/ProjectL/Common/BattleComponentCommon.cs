using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000434 RID: 1076
	[HotFix]
	public class BattleComponentCommon : IComponentBase
	{
		// Token: 0x06003EA6 RID: 16038 RVA: 0x0011F2E4 File Offset: 0x0011D4E4
		public BattleComponentCommon()
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

		// Token: 0x06003EA7 RID: 16039 RVA: 0x0011F360 File Offset: 0x0011D560
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
			return "Battle";
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x0011F3D4 File Offset: 0x0011D5D4
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
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0011F434 File Offset: 0x0011D634
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
			this.m_level = (this.Owner.GetOwnerComponent("Level") as LevelComponentCommon);
			this.m_arena = (this.Owner.GetOwnerComponent("Arena") as ArenaComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_team = (this.Owner.GetOwnerComponent("Team") as TeamComponentCommon);
			this.m_trainingGround = (this.Owner.GetOwnerComponent("TrainingGround") as TrainingGroundCompomentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
			this.m_realtimePVP = (this.Owner.GetOwnerComponent("RealTimePVP") as RealTimePVPComponentCommon);
			this.m_guild = (this.Owner.GetOwnerComponent("Guild") as GuildComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushBattle;
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x0011F5BC File Offset: 0x0011D7BC
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

		// Token: 0x06003EAB RID: 16043 RVA: 0x0011F61C File Offset: 0x0011D81C
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

		// Token: 0x06003EAC RID: 16044 RVA: 0x0011F68C File Offset: 0x0011D88C
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

		// Token: 0x06003EAD RID: 16045 RVA: 0x0011F70C File Offset: 0x0011D90C
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

		// Token: 0x06003EAE RID: 16046 RVA: 0x0011F77C File Offset: 0x0011D97C
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

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x0011F7DC File Offset: 0x0011D9DC
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x0011F850 File Offset: 0x0011DA50
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

		// Token: 0x06003EB1 RID: 16049 RVA: 0x0011F8C8 File Offset: 0x0011DAC8
		public bool IsGameFunctionOpenByMonthCard(GameFunctionType gameFuncTypeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGameFunctionOpenByMonthCardGameFunctionType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGameFunctionOpenByMonthCardGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFuncTypeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (MonthCard monthCard in this.m_resource.GetAllValidMonthCards())
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null && configDataMonthCardInfo.OpenGameFunc == gameFuncTypeId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x0011F9C4 File Offset: 0x0011DBC4
		private int GetDailyBonusAddNumsByMonthCard(GameFunctionType gameFuncTypeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDailyBonusAddNumsByMonthCardGameFunctionType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDailyBonusAddNumsByMonthCardGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFuncTypeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (MonthCard monthCard in this.m_resource.GetAllValidMonthCards())
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null)
				{
					foreach (GameFuncDayBonus gameFuncDayBonus in configDataMonthCardInfo.DayBonusAdd)
					{
						if (gameFuncTypeId == gameFuncDayBonus.GameFuncId)
						{
							num += gameFuncDayBonus.Nums;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0011FB0C File Offset: 0x0011DD0C
		public int GetDailyBonusMaxNums(GameFunctionType gameFuncTypeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDailyBonusMaxNumsGameFunctionType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDailyBonusMaxNumsGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFuncTypeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int dailyBonusAddNumsByMonthCard = this.GetDailyBonusAddNumsByMonthCard(gameFuncTypeId);
			if (gameFuncTypeId == GameFunctionType.GameFunctionType_AnikiGym)
			{
				return dailyBonusAddNumsByMonthCard + this.m_configDataLoader.ConfigableConstId_DayBonusNum_Aniki;
			}
			if (gameFuncTypeId == GameFunctionType.GameFunctionType_ThearchyTrial)
			{
				return dailyBonusAddNumsByMonthCard + this.m_configDataLoader.ConfigableConstId_DayBonusNum_ThearchyTrial;
			}
			if (gameFuncTypeId == GameFunctionType.GameFunctionType_MemoryCorridor)
			{
				return dailyBonusAddNumsByMonthCard + this.m_configDataLoader.ConfigableConstId_DayBonusNum_MemoryCorridor;
			}
			if (gameFuncTypeId == GameFunctionType.GameFunctionType_HeroTrainning)
			{
				return dailyBonusAddNumsByMonthCard + this.m_configDataLoader.ConfigableConstId_DayBonusNum_HeroTrain;
			}
			if (gameFuncTypeId != GameFunctionType.GameFunctionType_CooperateBattle)
			{
				return 0;
			}
			return dailyBonusAddNumsByMonthCard + this.m_configDataLoader.ConfigableConstId_DayBonusNum_CooperateBattle;
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0011FC04 File Offset: 0x0011DE04
		private int GetSinglePveBattleFightEnergyCost()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSinglePveBattleFightEnergyCost_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSinglePveBattleFightEnergyCost_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDS.ArenaBattleId != -2147483648)
			{
				return 0;
			}
			BattleType type = this.m_battleDS.ProcessingBattleInfo.Type;
			int typeId = this.m_battleDS.ProcessingBattleInfo.TypeId;
			switch (type)
			{
			case BattleType.WayPoint:
			{
				ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(typeId);
				WaypointFuncType funcType = configDataWaypointInfo.FuncType;
				if (funcType == WaypointFuncType.WaypointFuncType_Event)
				{
					int eventId = this.m_level.GetEventId(configDataWaypointInfo);
					return this.m_configDataLoader.GetConfigDataEventInfo(eventId).EnergyFail;
				}
				break;
			}
			case BattleType.Rift:
				return this.m_configDataLoader.GetConfigDataRiftLevelInfo(typeId).EnergyFail;
			case BattleType.ThearchyTrial:
				return this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(typeId).EnergyFail;
			case BattleType.AnikiGym:
				return this.m_configDataLoader.GetConfigDataAnikiLevelInfo(typeId).EnergyFail;
			case BattleType.HeroDungeon:
				return this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(typeId).EnergyFail;
			case BattleType.Scenario:
				return this.m_configDataLoader.GetConfigDataScenarioInfo(typeId).EnergyFail;
			case BattleType.TreasureMap:
				return this.m_configDataLoader.GetConfigDataTreasureLevelInfo(typeId).EnergyFail;
			case BattleType.MemoryCorridor:
				return this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(typeId).EnergyFail;
			case BattleType.HeroTrainning:
				return this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(typeId).EnergyFail;
			case BattleType.HeroPhantom:
				return this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(typeId).EnergyFail;
			case BattleType.CooperateBattle:
				return this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(typeId).EnergyFail;
			case BattleType.UnchartedScore_ChallengeLevel:
				return this.m_configDataLoader.GetConfigDataChallengeLevelInfo(typeId).EnergyFail;
			case BattleType.UnchartedScore_ScoreLevel:
				return this.m_configDataLoader.GetConfigDataScoreLevelInfo(typeId).EnergyFail;
			case BattleType.ClimbTower:
				return this.m_configDataLoader.GetConfigDataTowerFloorInfo(typeId).EnergyFail;
			case BattleType.GuildMassiveCombat:
				return 0;
			}
			return 0;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0011FE34 File Offset: 0x0011E034
		public int GetSinglePveBattleFailEnergyCostByMonthCard()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSinglePveBattleFailEnergyCostByMonthCard_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSinglePveBattleFailEnergyCostByMonthCard_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProcessingBattle processingBattleInfo = this.m_battleDS.ProcessingBattleInfo;
			if (processingBattleInfo == null)
			{
				return 0;
			}
			if (processingBattleInfo.Type == BattleType.Scenario)
			{
				if (!this.m_level.IsScenarioFinished(processingBattleInfo.TypeId))
				{
					return 0;
				}
			}
			else if (processingBattleInfo.Type == BattleType.GuildMassiveCombat)
			{
				return 0;
			}
			int singlePveBattleFightEnergyCost = this.GetSinglePveBattleFightEnergyCost();
			return this.GetFightFailEnergyCostByMonthcard(singlePveBattleFightEnergyCost);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x0011FEFC File Offset: 0x0011E0FC
		public int GetTeamPveBattleFailEnergyCost(GameFunctionType typeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamPveBattleFailEnergyCostGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTeamPveBattleFailEnergyCostGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					typeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (typeId == GameFunctionType.GameFunctionType_AnikiGym)
			{
				return this.m_configDataLoader.GetConfigDataAnikiLevelInfo(locationId).TeamEnergyCost;
			}
			if (typeId == GameFunctionType.GameFunctionType_ThearchyTrial)
			{
				return this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(locationId).TeamEnergyCost;
			}
			if (typeId == GameFunctionType.GameFunctionType_MemoryCorridor)
			{
				return this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(locationId).TeamEnergyCost;
			}
			if (typeId == GameFunctionType.GameFunctionType_HeroTrainning)
			{
				return this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(locationId).TeamEnergyCost;
			}
			if (typeId == GameFunctionType.GameFunctionType_CooperateBattle)
			{
				return this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(locationId).EnergyFail;
			}
			if (typeId == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
			{
				return this.m_configDataLoader.GetConfigDataScoreLevelInfo(locationId).EnergyTeam;
			}
			if (typeId != GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				return 0;
			}
			return 0;
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x00120034 File Offset: 0x0011E234
		public int GetTeamPveBattleFailEnergyCostByMonthCard(GameFunctionType typeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamPveBattleFailEnergyCostByMonthCardGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTeamPveBattleFailEnergyCostByMonthCardGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					typeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (typeId == GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				return 0;
			}
			int teamPveBattleFailEnergyCost = this.GetTeamPveBattleFailEnergyCost(typeId, locationId);
			return this.GetFightFailEnergyCostByMonthcard(teamPveBattleFailEnergyCost);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001200DC File Offset: 0x0011E2DC
		private int GetFightFailEnergyCostByMonthcard(int energyCost)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFightFailEnergyCostByMonthcardInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFightFailEnergyCostByMonthcardInt32_hotfix.call(new object[]
				{
					this,
					energyCost
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (MonthCard monthCard in this.m_resource.GetAllValidMonthCards())
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(monthCard.CardId);
				if (configDataMonthCardInfo != null && configDataMonthCardInfo.FightFailEnergyDecreaseRate != 0)
				{
					num += configDataMonthCardInfo.FightFailEnergyDecreaseRate;
				}
			}
			double num2 = 1.0 - 1.0 * (double)num / (double)this.m_configDataLoader.ConfigableConstId_GainMaximum;
			int num3 = (int)((double)energyCost * num2);
			if (num3 < 1)
			{
				num3 = 1;
			}
			return num3;
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x00120210 File Offset: 0x0011E410
		private void AddFightFailCompensationEnergyByMonthCard(int energyCost)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddFightFailCompensationEnergyByMonthCardInt32_hotfix != null)
			{
				this.m_AddFightFailCompensationEnergyByMonthCardInt32_hotfix.call(new object[]
				{
					this,
					energyCost
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int fightFailEnergyCostByMonthcard = this.GetFightFailEnergyCostByMonthcard(energyCost);
			if (energyCost > fightFailEnergyCostByMonthcard)
			{
				this.m_basicInfo.IncreamentEnergy((long)(energyCost - fightFailEnergyCostByMonthcard), true, GameFunctionType.GameFunctionType_MonthCard, null);
			}
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x001202A4 File Offset: 0x0011E4A4
		public void AddTeamPveFightFailCompensationEnergyByMonthCard(GameFunctionType typeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTeamPveFightFailCompensationEnergyByMonthCardGameFunctionTypeInt32_hotfix != null)
			{
				this.m_AddTeamPveFightFailCompensationEnergyByMonthCardGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					typeId,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int teamPveBattleFailEnergyCost = this.GetTeamPveBattleFailEnergyCost(typeId, locationId);
			this.AddFightFailCompensationEnergyByMonthCard(teamPveBattleFailEnergyCost);
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x00120334 File Offset: 0x0011E534
		private void AddSinglePveFightFailCompensationEnergyByMonthCard()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSinglePveFightFailCompensationEnergyByMonthCard_hotfix != null)
			{
				this.m_AddSinglePveFightFailCompensationEnergyByMonthCard_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProcessingBattle processingBattleInfo = this.m_battleDS.ProcessingBattleInfo;
			if (processingBattleInfo == null)
			{
				return;
			}
			if (processingBattleInfo.Type == BattleType.Scenario && !this.m_level.IsScenarioFinished(processingBattleInfo.TypeId))
			{
				return;
			}
			int singlePveBattleFightEnergyCost = this.GetSinglePveBattleFightEnergyCost();
			this.AddFightFailCompensationEnergyByMonthCard(singlePveBattleFightEnergyCost);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x001203D8 File Offset: 0x0011E5D8
		public bool IsWaypointBattling()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWaypointBattling_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWaypointBattling_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProcessingBattle processingBattleInfo = this.m_battleDS.ProcessingBattleInfo;
			return processingBattleInfo != null && processingBattleInfo.Type == BattleType.WayPoint && processingBattleInfo.TypeId != 0;
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00120474 File Offset: 0x0011E674
		private void OnFlushBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushBattle_hotfix != null)
			{
				this.m_OnFlushBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.ClearDailyArmyRandomSeeds();
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x001204E0 File Offset: 0x0011E6E0
		public bool IsBattleWin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBattleWin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBattleWin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battle != null && this.m_battle.GetStars() > 0;
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x00120568 File Offset: 0x0011E768
		public int CancelBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelBattle_hotfix != null)
			{
				return Convert.ToInt32(this.m_CancelBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsFighting())
			{
				return -904;
			}
			this.FightFinished(GameFunctionStatus.Cancel, false, true);
			return 0;
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x001205F0 File Offset: 0x0011E7F0
		public bool IsFighting()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFighting_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFighting_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ProcessingBattleInfo.Type != BattleType.None || this.IsAttackingArenaOpponent() || this.IsAttackingInBattleServer();
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x00120688 File Offset: 0x0011E888
		public bool CanSetupMineTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetupMineTeam_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanSetupMineTeam_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ProcessingBattleInfo.Type == BattleType.None || this.IsArenaBattleInReady();
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x00120714 File Offset: 0x0011E914
		public virtual void FightFinished(GameFunctionStatus status, bool win = false, bool needBatlleLog = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FightFinishedGameFunctionStatusBooleanBoolean_hotfix != null)
			{
				this.m_FightFinishedGameFunctionStatusBooleanBoolean_hotfix.call(new object[]
				{
					this,
					status,
					win,
					needBatlleLog
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsAttackingArenaOpponent())
			{
				if (!win)
				{
					this.AddSinglePveFightFailCompensationEnergyByMonthCard();
				}
				if (status != GameFunctionStatus.Error)
				{
					this.m_battleDS.SetArmyRandomSeed(0);
				}
				this.m_battleDS.SetRandomSeed(0);
				this.m_battleDS.SetProcessingBattleInfo(BattleType.None, 0);
			}
			else
			{
				this.FinishedArenaFight();
			}
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x001207F8 File Offset: 0x0011E9F8
		public bool IsWayPointFightExist(int wayPointId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsWayPointFightExistInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsWayPointFightExistInt32_hotfix.call(new object[]
				{
					this,
					wayPointId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsAttackingPveLevel(BattleType.WayPoint, wayPointId);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x0012087C File Offset: 0x0011EA7C
		public void WinPveBattle(int battleId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WinPveBattleInt32_hotfix != null)
			{
				this.m_WinPveBattleInt32_hotfix.call(new object[]
				{
					this,
					battleId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.RemoveEveryTimeArmyRandomSeed(battleId);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x001208F8 File Offset: 0x0011EAF8
		public void FinishedArenaFight()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedArenaFight_hotfix != null)
			{
				this.m_FinishedArenaFight_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.ArenaBattleStatus = ArenaBattleStatus.None;
			this.m_battleDS.ArenaBattleId = int.MinValue;
			this.m_battleDS.ArenaBattleRandomSeed = int.MinValue;
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00120984 File Offset: 0x0011EB84
		public ProcessingBattle GetProcessingBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetProcessingBattle_hotfix != null)
			{
				return (ProcessingBattle)this.m_GetProcessingBattle_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ProcessingBattleInfo;
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x001209FC File Offset: 0x0011EBFC
		public virtual void SetProcessingBattleInfo(BattleType type, int typeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetProcessingBattleInfoBattleTypeInt32_hotfix != null)
			{
				this.m_SetProcessingBattleInfoBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					type,
					typeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.SetProcessingBattleInfo(type, typeId);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00120A8C File Offset: 0x0011EC8C
		public void SetBattleArmyRandomSeed(int armyRandomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleArmyRandomSeedInt32_hotfix != null)
			{
				this.m_SetBattleArmyRandomSeedInt32_hotfix.call(new object[]
				{
					this,
					armyRandomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.SetArmyRandomSeed(armyRandomSeed);
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00120B08 File Offset: 0x0011ED08
		public int GetBattleArmyRandomSeed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleArmyRandomSeed_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBattleArmyRandomSeed_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.GetArmyRandomSeed();
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00120B80 File Offset: 0x0011ED80
		public virtual void SetArenaBattleInfo(int arenaBattleId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaBattleInfoInt32_hotfix != null)
			{
				this.m_SetArenaBattleInfoInt32_hotfix.call(new object[]
				{
					this,
					arenaBattleId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.ArenaBattleId = arenaBattleId;
			this.m_battleDS.ArenaBattleStatus = ArenaBattleStatus.Ready;
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00120C08 File Offset: 0x0011EE08
		public bool IsAttackingPveLevel(BattleType battleType, int levelId = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAttackingPveLevelBattleTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAttackingPveLevelBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					battleType,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProcessingBattle processingBattleInfo = this.m_battleDS.ProcessingBattleInfo;
			if (processingBattleInfo == null)
			{
				return false;
			}
			if (battleType == BattleType.Scenario)
			{
				return processingBattleInfo.Type == battleType;
			}
			return processingBattleInfo.Type == battleType && processingBattleInfo.TypeId == levelId;
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x00120CD4 File Offset: 0x0011EED4
		public bool IsAttackingArenaOpponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAttackingArenaOpponent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAttackingArenaOpponent_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ArenaBattleStatus != ArenaBattleStatus.None;
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x00120D54 File Offset: 0x0011EF54
		public bool IsArenaBattleInReady()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaBattleInReady_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArenaBattleInReady_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ArenaBattleStatus == ArenaBattleStatus.Ready;
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00120DD0 File Offset: 0x0011EFD0
		public bool IsAttackingInBattleServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAttackingInBattleServer_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAttackingInBattleServer_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.BattleRoomId != 0UL;
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x00120E4C File Offset: 0x0011F04C
		public void FinishBattleInBattleServer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishBattleInBattleServer_hotfix != null)
			{
				this.m_FinishBattleInBattleServer_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BattleRoomId = 0UL;
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00120EB4 File Offset: 0x0011F0B4
		public int CanCreateBattleRoom(BattleRoomType battleRoomType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCreateBattleRoomBattleRoomType_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCreateBattleRoomBattleRoomType_hotfix.call(new object[]
				{
					this,
					battleRoomType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleRoomType == BattleRoomType.Team)
			{
				return this.CanCreateTeamBattleRoom();
			}
			return (!this.IsFighting()) ? 0 : -900;
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x00120F54 File Offset: 0x0011F154
		public int CanCreateTeamBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCreateTeamBattleRoom_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCreateTeamBattleRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsFighting())
			{
				return -900;
			}
			return (!this.m_team.IsInRoom()) ? -3014 : 0;
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x00120FEC File Offset: 0x0011F1EC
		public int CanChangePlayerBattleStatus(PlayerBattleStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanChangePlayerBattleStatusPlayerBattleStatus_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanChangePlayerBattleStatusPlayerBattleStatus_hotfix.call(new object[]
				{
					this,
					status
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (status < PlayerBattleStatus.Normal || status >= PlayerBattleStatus.Max)
			{
				return -927;
			}
			return (!this.IsAttackingInBattleServer()) ? -926 : 0;
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x00121094 File Offset: 0x0011F294
		public void SetArenaBattleFighting()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaBattleFighting_hotfix != null)
			{
				this.m_SetArenaBattleFighting_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.ArenaBattleStatus = ArenaBattleStatus.Fighting;
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00121100 File Offset: 0x0011F300
		public int GetBattleId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBattleId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDS.ArenaBattleId != -2147483648)
			{
				return this.m_battleDS.ArenaBattleId;
			}
			BattleType type = this.m_battleDS.ProcessingBattleInfo.Type;
			int typeId = this.m_battleDS.ProcessingBattleInfo.TypeId;
			switch (type)
			{
			case BattleType.WayPoint:
			{
				ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(typeId);
				WaypointFuncType funcType = configDataWaypointInfo.FuncType;
				if (funcType == WaypointFuncType.WaypointFuncType_Event)
				{
					int eventId = this.m_level.GetEventId(configDataWaypointInfo);
					return this.m_configDataLoader.GetConfigDataEventInfo(eventId).Battle_ID;
				}
				break;
			}
			case BattleType.Rift:
				return this.m_configDataLoader.GetConfigDataRiftLevelInfo(typeId).Battle_ID;
			case BattleType.ThearchyTrial:
				return this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(typeId).Battle_ID;
			case BattleType.AnikiGym:
				return this.m_configDataLoader.GetConfigDataAnikiLevelInfo(typeId).Battle_ID;
			case BattleType.HeroDungeon:
				return this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(typeId).Battle_ID;
			case BattleType.Scenario:
				return this.m_configDataLoader.GetConfigDataScenarioInfo(typeId).Battle_ID;
			case BattleType.TreasureMap:
				return this.m_configDataLoader.GetConfigDataTreasureLevelInfo(typeId).Battle_ID;
			case BattleType.MemoryCorridor:
				return this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(typeId).Battle_ID;
			case BattleType.HeroTrainning:
				return this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(typeId).Battle_ID;
			case BattleType.HeroPhantom:
				return this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(typeId).Battle_ID;
			case BattleType.CooperateBattle:
				return this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(typeId).Battle_ID;
			case BattleType.UnchartedScore_ChallengeLevel:
				return this.m_configDataLoader.GetConfigDataChallengeLevelInfo(typeId).Battle_ID;
			case BattleType.UnchartedScore_ScoreLevel:
				return this.m_configDataLoader.GetConfigDataScoreLevelInfo(typeId).Battle_ID;
			case BattleType.GuildMassiveCombat:
				return this.m_configDataLoader.GetConfigDataGuildMassiveCombatLevelInfo(typeId).BattleId;
			}
			return -912;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0012133C File Offset: 0x0011F53C
		public int GetBattleId(GameFunctionType typeId, int loctionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleIdGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBattleIdGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					typeId,
					loctionId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (typeId)
			{
			case GameFunctionType.GameFunctionType_Rift:
				return this.m_configDataLoader.GetConfigDataRiftLevelInfo(loctionId).Battle_ID;
			case GameFunctionType.GameFunctionType_Scenario:
				return this.m_configDataLoader.GetConfigDataScenarioInfo(loctionId).Battle_ID;
			case GameFunctionType.GameFunctionType_Event:
				break;
			case GameFunctionType.GameFunctionType_AnikiGym:
				return this.m_configDataLoader.GetConfigDataAnikiLevelInfo(loctionId).Battle_ID;
			case GameFunctionType.GameFunctionType_ThearchyTrial:
				return this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(loctionId).Battle_ID;
			default:
				if (typeId == GameFunctionType.GameFunctionType_TreasureMap)
				{
					return this.m_configDataLoader.GetConfigDataTreasureLevelInfo(loctionId).Battle_ID;
				}
				if (typeId == GameFunctionType.GameFunctionType_MemoryCorridor)
				{
					return this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(loctionId).Battle_ID;
				}
				if (typeId == GameFunctionType.GameFunctionType_HeroPhantom)
				{
					return this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(loctionId).Battle_ID;
				}
				if (typeId == GameFunctionType.GameFunctionType_CooperateBattle)
				{
					return this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(loctionId).Battle_ID;
				}
				if (typeId == GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel)
				{
					return this.m_configDataLoader.GetConfigDataChallengeLevelInfo(loctionId).Battle_ID;
				}
				if (typeId == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
				{
					return this.m_configDataLoader.GetConfigDataScoreLevelInfo(loctionId).Battle_ID;
				}
				if (typeId == GameFunctionType.GameFunctionType_HeroDungeon)
				{
					return this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(loctionId).Battle_ID;
				}
				if (typeId != GameFunctionType.GameFunctionType_RandomEvent)
				{
					if (typeId == GameFunctionType.GameFunctionType_HeroTrainning)
					{
						return this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(loctionId).Battle_ID;
					}
					if (typeId != GameFunctionType.GameFunctionType_GuildMassiveCombat)
					{
						return -912;
					}
					return this.m_configDataLoader.GetConfigDataGuildMassiveCombatLevelInfo(loctionId).BattleId;
				}
				break;
			}
			return this.m_configDataLoader.GetConfigDataEventInfo(loctionId).Battle_ID;
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0012153C File Offset: 0x0011F73C
		public int GetMonsterLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMonsterLevel_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMonsterLevel_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleType type = this.m_battleDS.ProcessingBattleInfo.Type;
			int typeId = this.m_battleDS.ProcessingBattleInfo.TypeId;
			switch (type)
			{
			case BattleType.WayPoint:
			{
				ConfigDataWaypointInfo configDataWaypointInfo = this.m_configDataLoader.GetConfigDataWaypointInfo(typeId);
				WaypointFuncType funcType = configDataWaypointInfo.FuncType;
				if (funcType == WaypointFuncType.WaypointFuncType_Event)
				{
					int eventId = this.m_level.GetEventId(configDataWaypointInfo);
					return this.m_configDataLoader.GetConfigDataEventInfo(eventId).MonsterLevel;
				}
				break;
			}
			case BattleType.Rift:
				return this.m_configDataLoader.GetConfigDataRiftLevelInfo(typeId).MonsterLevel;
			case BattleType.ThearchyTrial:
				return this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(typeId).MonsterLevel;
			case BattleType.AnikiGym:
				return this.m_configDataLoader.GetConfigDataAnikiLevelInfo(typeId).MonsterLevel;
			case BattleType.HeroDungeon:
				return this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(typeId).MonsterLevel;
			case BattleType.Scenario:
				return this.m_configDataLoader.GetConfigDataScenarioInfo(typeId).MonsterLevel;
			case BattleType.TreasureMap:
				return this.m_configDataLoader.GetConfigDataTreasureLevelInfo(typeId).MonsterLevel;
			case BattleType.MemoryCorridor:
				return this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(typeId).MonsterLevel;
			case BattleType.HeroTrainning:
				return this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(typeId).MonsterLevel;
			case BattleType.HeroPhantom:
				return this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(typeId).MonsterLevel;
			case BattleType.CooperateBattle:
				return this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(typeId).MonsterLevel;
			case BattleType.UnchartedScore_ChallengeLevel:
				return this.m_configDataLoader.GetConfigDataChallengeLevelInfo(typeId).MonsterLevel;
			case BattleType.UnchartedScore_ScoreLevel:
				return this.m_configDataLoader.GetConfigDataScoreLevelInfo(typeId).MonsterLevel;
			case BattleType.ClimbTower:
				return this.m_configDataLoader.GetConfigDataTowerFloorInfo(typeId).MonsterLevel;
			}
			return -913;
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00121750 File Offset: 0x0011F950
		public void AddFightHeroFightNumsAndExp(List<int> heroes, int exp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddFightHeroFightNumsAndExpList`1Int32_hotfix != null)
			{
				this.m_AddFightHeroFightNumsAndExpList`1Int32_hotfix.call(new object[]
				{
					this,
					heroes,
					exp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int num in heroes)
			{
				if (num != 0)
				{
					this.m_hero.AddHeroFightNums(num, 1);
					if (exp > 0 && this.m_hero.CanAddHeroExp(num) == 0)
					{
						this.m_hero.AddHeroExp(num, exp);
					}
				}
			}
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00121854 File Offset: 0x0011FA54
		public List<int> GetPveTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPveTeam_hotfix != null)
			{
				return (List<int>)this.m_GetPveTeam_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGamePlayTeamTypeInfo configDataGamePlayTeamTypeInfo = this.m_configDataLoader.GetConfigDataGamePlayTeamTypeInfo((int)this.m_battleDS.ProcessingBattleInfo.Type);
			return this.m_battleDS.GetTeam(configDataGamePlayTeamTypeInfo.TeamType);
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x001218F0 File Offset: 0x0011FAF0
		public int IsMineTeamSetValid(int battleId, int battleType, List<int> fightHeroes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMineTeamSetValidInt32Int32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsMineTeamSetValidInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					battleId,
					battleType,
					fightHeroes
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (int num2 in fightHeroes)
			{
				if (num2 != 0)
				{
					if (this.m_hero.FindHero(num2) == null)
					{
						return -602;
					}
					num++;
				}
			}
			switch (battleType)
			{
			case 1:
			case 2:
			case 3:
			case 4:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 12:
			case 13:
			case 15:
			case 16:
			case 17:
			{
				ConfigDataBattleInfo configDataBattleInfo = this.m_configDataLoader.GetConfigDataBattleInfo(battleId);
				if (configDataBattleInfo == null)
				{
					return -905;
				}
				if (num > configDataBattleInfo.AllyNumber)
				{
					return -907;
				}
				foreach (int num3 in configDataBattleInfo.ImperativeBattleHeroes_ID)
				{
					if (!fightHeroes.Contains(num3) && this.m_hero.FindHero(num3) != null)
					{
						return -922;
					}
				}
				return 0;
			}
			case 5:
			{
				ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_configDataLoader.GetConfigDataArenaBattleInfo(battleId);
				if (configDataArenaBattleInfo == null)
				{
					return -905;
				}
				if (num == 0 || num > configDataArenaBattleInfo.AttackNumber)
				{
					return -907;
				}
				return 0;
			}
			case 18:
			{
				int num4 = this.m_guild.CanTheseHeroesAttackStronghold(fightHeroes);
				if (num4 != 0)
				{
					return num4;
				}
				return 0;
			}
			}
			return -915;
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00121B58 File Offset: 0x0011FD58
		public int IsArenaDefensiveTeamSetValid(int battleId, int teamCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaDefensiveTeamSetValidInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsArenaDefensiveTeamSetValidInt32Int32_hotfix.call(new object[]
				{
					this,
					battleId,
					teamCount
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_configDataLoader.GetConfigDataArenaBattleInfo(battleId);
			if (configDataArenaBattleInfo == null)
			{
				return -905;
			}
			if (teamCount == 0 || teamCount > configDataArenaBattleInfo.DefendNumber)
			{
				return -907;
			}
			return 0;
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00121C18 File Offset: 0x0011FE18
		public bool IsActionPositionIndexValid(ConfigDataArenaBattleInfo battleInfo, int actionPositionIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActionPositionIndexValidConfigDataArenaBattleInfoInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActionPositionIndexValidConfigDataArenaBattleInfoInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					actionPositionIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return actionPositionIndex >= 0 && actionPositionIndex < battleInfo.DefendPositions.Count;
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00121CBC File Offset: 0x0011FEBC
		public bool IsActionValueValid(ConfigDataArenaBattleInfo battleInfo, int actionValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsActionValueValidConfigDataArenaBattleInfoInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsActionValueValidConfigDataArenaBattleInfoInt32_hotfix.call(new object[]
				{
					this,
					battleInfo,
					actionValue
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return actionValue >= 1 && actionValue < battleInfo.DefendNumber + 1;
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00121D60 File Offset: 0x0011FF60
		private bool IsTeamEmpty(List<int> team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTeamEmptyList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTeamEmptyList`1_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int num in team)
			{
				if (num != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x00121E30 File Offset: 0x00120030
		public int SetMineTeam(int battleId, int battleType, List<int> team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMineTeamInt32Int32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_SetMineTeamInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					battleId,
					battleType,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.CanSetupMineTeam())
			{
				this.FightFinished(GameFunctionStatus.Error, false, true);
				return -900;
			}
			int num = this.IsMineTeamSetValid(battleId, battleType, team);
			if (num != 0)
			{
				return num;
			}
			ConfigDataGamePlayTeamTypeInfo configDataGamePlayTeamTypeInfo = this.m_configDataLoader.GetConfigDataGamePlayTeamTypeInfo(battleType);
			if (configDataGamePlayTeamTypeInfo == null)
			{
				return -915;
			}
			this.m_battleDS.SetTeam(configDataGamePlayTeamTypeInfo.TeamType, team);
			return 0;
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00121F24 File Offset: 0x00120124
		public void SetTeam(BattleType battleType, List<int> team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamBattleTypeList`1_hotfix != null)
			{
				this.m_SetTeamBattleTypeList`1_hotfix.call(new object[]
				{
					this,
					battleType,
					team
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGamePlayTeamTypeInfo configDataGamePlayTeamTypeInfo = this.m_configDataLoader.GetConfigDataGamePlayTeamTypeInfo((int)battleType);
			if (configDataGamePlayTeamTypeInfo == null)
			{
				return;
			}
			this.m_battleDS.SetTeam(configDataGamePlayTeamTypeInfo.TeamType, team);
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00121FCC File Offset: 0x001201CC
		public List<int> GetTeam(BattleType battleType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamBattleType_hotfix != null)
			{
				return (List<int>)this.m_GetTeamBattleType_hotfix.call(new object[]
				{
					this,
					battleType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGamePlayTeamTypeInfo configDataGamePlayTeamTypeInfo = this.m_configDataLoader.GetConfigDataGamePlayTeamTypeInfo((int)battleType);
			if (configDataGamePlayTeamTypeInfo == null)
			{
				return new List<int>();
			}
			return this.m_battleDS.GetTeam(configDataGamePlayTeamTypeInfo.TeamType);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00122074 File Offset: 0x00120274
		public List<BattleHeroEquipment> CreateMineBattleHeroEquipments(ulong[] equipmentIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMineBattleHeroEquipmentsUInt64be_hotfix != null)
			{
				return (List<BattleHeroEquipment>)this.m_CreateMineBattleHeroEquipmentsUInt64be_hotfix.call(new object[]
				{
					this,
					equipmentIds
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<BattleHeroEquipment> list = new List<BattleHeroEquipment>();
			foreach (ulong num in equipmentIds)
			{
				if (num != 0UL)
				{
					EquipmentBagItem equipmentBagItem = this.m_bag.FindBagItemByInstanceId(num) as EquipmentBagItem;
					if (equipmentBagItem != null)
					{
						BattleHeroEquipment battleHeroEquipment = new BattleHeroEquipment();
						battleHeroEquipment.Id = equipmentBagItem.ContentId;
						battleHeroEquipment.Level = equipmentBagItem.Level;
						battleHeroEquipment.StarLevel = equipmentBagItem.StarLevel;
						battleHeroEquipment.Exp = equipmentBagItem.Exp;
						battleHeroEquipment.ResonanceId = equipmentBagItem.ResonanceId;
						battleHeroEquipment.EnchantProperties.AddRange(equipmentBagItem.EnchantProperties);
						list.Add(battleHeroEquipment);
					}
				}
			}
			return list;
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x001221A0 File Offset: 0x001203A0
		public int ComputeBattlePowerFromBattleHeroes(List<BattleHero> heroes, List<TrainingTech> techs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBattlePowerFromBattleHeroesList`1List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeBattlePowerFromBattleHeroesList`1List`1_hotfix.call(new object[]
				{
					this,
					heroes,
					techs
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleHero hero in heroes)
			{
				num += this.ComputeBattlePower(hero, techs);
			}
			return num;
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00122280 File Offset: 0x00120480
		public int ComputeBattlePower(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBattlePowerHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeBattlePowerHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero battleHero = BattleHero.HeroToBattleHero(hero);
			battleHero.Equipments = this.CreateMineBattleHeroEquipments(hero.EquipmentIds);
			return this.ComputeBattlePower(battleHero, this.m_trainingGround.GetAvailableTechs());
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00122328 File Offset: 0x00120528
		public int ComputeBattlePower(BattleHero hero, List<TrainingTech> techs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeBattlePowerBattleHeroList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeBattlePowerBattleHeroList`1_hotfix.call(new object[]
				{
					this,
					hero,
					techs
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_propertyModifier == null)
			{
				this.m_propertyModifier = new BattlePropertyModifier();
			}
			if (this.m_battleProperty == null)
			{
				this.m_battleProperty = new BattleProperty();
			}
			BattleHeroJob battleHeroJob = null;
			foreach (BattleHeroJob battleHeroJob2 in hero.Jobs)
			{
				if (battleHeroJob2.JobRelatedId == hero.ActiveHeroJobRelatedId)
				{
					battleHeroJob = battleHeroJob2;
					break;
				}
			}
			if (battleHeroJob == null)
			{
				return 0;
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(hero.HeroId);
			if (configDataHeroInfo == null)
			{
				return 0;
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(battleHeroJob.JobRelatedId);
			if (configDataJobConnectionInfo == null)
			{
				return 0;
			}
			this.m_propertyModifier.Clear();
			this.CollectJobMasterPropertyModifier(hero.Jobs, this.m_propertyModifier);
			int num = 0;
			foreach (int key in hero.SelectedSkillList)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(key);
				if (configDataSkillInfo != null)
				{
					num += configDataSkillInfo.BattlePower;
				}
			}
			ConfigDataSkillInfo talentSkillInfo = configDataJobConnectionInfo.GetTalentSkillInfo(hero.StarLevel);
			if (talentSkillInfo != null)
			{
				this.CollectPassiveSkillStaticPropertyModifier(talentSkillInfo, this.m_propertyModifier);
				num += talentSkillInfo.BattlePower;
			}
			if (configDataHeroInfo.m_hiddenSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo configDataSkillInfo2 in configDataHeroInfo.m_hiddenSkillInfos)
				{
					this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo2, this.m_propertyModifier);
					num += configDataSkillInfo2.BattlePower;
				}
			}
			if (configDataJobConnectionInfo.m_jobInfo.m_jobSkillInfos != null)
			{
				foreach (ConfigDataSkillInfo configDataSkillInfo3 in configDataJobConnectionInfo.m_jobInfo.m_jobSkillInfos)
				{
					this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo3, this.m_propertyModifier);
					num += configDataSkillInfo3.BattlePower;
				}
			}
			foreach (KeyValuePair<int, int> keyValuePair in hero.Fetters)
			{
				ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(keyValuePair.Key);
				if (configDataHeroFetterInfo != null)
				{
					int num2 = keyValuePair.Value - 1;
					if (num2 < configDataHeroFetterInfo.GotSkills_ID.Count)
					{
						ConfigDataSkillInfo configDataSkillInfo4 = this.m_configDataLoader.GetConfigDataSkillInfo(configDataHeroFetterInfo.GotSkills_ID[num2]);
						if (configDataSkillInfo4 != null)
						{
							this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo4, this.m_propertyModifier);
							num += configDataSkillInfo4.BattlePower;
						}
					}
				}
			}
			num += this.CollectEquipmentPropertyModifierAndSkillBattlePower(hero.Equipments, this.m_propertyModifier);
			ConfigDataModelSkinResourceInfo heroActiveJobModelSkinResourceInfo = hero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader);
			if (heroActiveJobModelSkinResourceInfo != null && heroActiveJobModelSkinResourceInfo.m_skinSkillInfo != null)
			{
				this.CollectPassiveSkillStaticPropertyModifier(heroActiveJobModelSkinResourceInfo.m_skinSkillInfo, this.m_propertyModifier);
				num += heroActiveJobModelSkinResourceInfo.m_skinSkillInfo.BattlePower;
			}
			this.m_battleProperty.ComputeHeroProperties(this.m_configDataLoader, configDataHeroInfo, configDataJobConnectionInfo, battleHeroJob.JobLevel, hero.Level, hero.StarLevel, this.m_propertyModifier);
			int num3 = BattleFormula.ComputeHeroBattlePower(configDataJobConnectionInfo.m_jobInfo, this.m_battleProperty.HealthPointMax, this.m_battleProperty.Attack, this.m_battleProperty.Defense, this.m_battleProperty.Magic, this.m_battleProperty.MagicDefense, this.m_battleProperty.Dexterity, num);
			int num4 = 0;
			ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(hero.SelectedSoldierId);
			if (configDataSoldierInfo != null)
			{
				int num5 = 0;
				int skillLevelUp = 0;
				List<ConfigDataSkillInfo> trainingTechSoldierSkillInfos = BattleUtility.GetTrainingTechSoldierSkillInfos(this.m_configDataLoader, techs, configDataSoldierInfo, out skillLevelUp);
				foreach (ConfigDataSkillInfo configDataSkillInfo5 in trainingTechSoldierSkillInfos)
				{
					this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo5, this.m_propertyModifier);
					num5 += configDataSkillInfo5.BattlePower;
				}
				ConfigDataSkillInfo levelUpSkillInfo = configDataSoldierInfo.GetLevelUpSkillInfo(skillLevelUp);
				if (levelUpSkillInfo != null)
				{
					this.CollectPassiveSkillStaticPropertyModifier(levelUpSkillInfo, this.m_propertyModifier);
					num5 += levelUpSkillInfo.BattlePower;
				}
				ConfigDataModelSkinResourceInfo selectedSoldierModelSkinResourceInfo = hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader);
				if (selectedSoldierModelSkinResourceInfo != null && selectedSoldierModelSkinResourceInfo.m_skinSkillInfo != null)
				{
					this.CollectPassiveSkillStaticPropertyModifier(selectedSoldierModelSkinResourceInfo.m_skinSkillInfo, this.m_propertyModifier);
					num5 += selectedSoldierModelSkinResourceInfo.m_skinSkillInfo.BattlePower;
				}
				this.m_battleProperty.ComputeSoldierProperties(this.m_configDataLoader, configDataSoldierInfo, configDataHeroInfo, hero.Level, this.m_propertyModifier);
				num4 = BattleFormula.ComputeSoldierBattlePower(configDataSoldierInfo, this.m_battleProperty.HealthPointMax, this.m_battleProperty.Attack, this.m_battleProperty.Defense, this.m_battleProperty.MagicDefense, num5);
			}
			return num3 + num4;
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x001228D8 File Offset: 0x00120AD8
		private void CollectJobMasterPropertyModifier(List<BattleHeroJob> jobs, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectJobMasterPropertyModifierList`1BattlePropertyModifier_hotfix != null)
			{
				this.m_CollectJobMasterPropertyModifierList`1BattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					jobs,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleHeroJob battleHeroJob in jobs)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(battleHeroJob.JobRelatedId);
				if (configDataJobConnectionInfo.IsJobLevelMax(battleHeroJob.JobLevel))
				{
					ConfigDataJobInfo configDataJobInfo = this.m_configDataLoader.GetConfigDataJobInfo(configDataJobConnectionInfo.Job_ID);
					BattleComponentCommon.CollectJobPropertyModifier(configDataJobInfo, pm);
				}
			}
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x001229D8 File Offset: 0x00120BD8
		private static void CollectJobPropertyModifier(ConfigDataJobInfo jobInfo, BattlePropertyModifier pm)
		{
			if (jobInfo != null)
			{
				pm.Collect(jobInfo.Property1_ID, jobInfo.Property1_Value);
				pm.Collect(jobInfo.Property2_ID, jobInfo.Property2_Value);
				pm.Collect(jobInfo.Property3_ID, jobInfo.Property3_Value);
			}
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00122A18 File Offset: 0x00120C18
		private int CollectEquipmentPropertyModifierAndSkillBattlePower(List<BattleHeroEquipment> equipments, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectEquipmentPropertyModifierAndSkillBattlePowerList`1BattlePropertyModifier_hotfix != null)
			{
				return Convert.ToInt32(this.m_CollectEquipmentPropertyModifierAndSkillBattlePowerList`1BattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					equipments,
					pm
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleHeroEquipment battleHeroEquipment in equipments)
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(battleHeroEquipment.Id);
				if (configDataEquipmentInfo != null)
				{
					pm.Collect(configDataEquipmentInfo.Property1_ID, BattleFormula.ComputeEquipmentPropertyAdd(configDataEquipmentInfo.Property1_Value, configDataEquipmentInfo.Property1_LevelUpValue, battleHeroEquipment.Level));
					pm.Collect(configDataEquipmentInfo.Property2_ID, BattleFormula.ComputeEquipmentPropertyAdd(configDataEquipmentInfo.Property2_Value, configDataEquipmentInfo.Property2_LevelUpValue, battleHeroEquipment.Level));
					foreach (CommonBattleProperty commonBattleProperty in battleHeroEquipment.EnchantProperties)
					{
						pm.Collect(commonBattleProperty.Id, commonBattleProperty.Value);
					}
					int activeSkillId = configDataEquipmentInfo.GetActiveSkillId(battleHeroEquipment.Level);
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(activeSkillId);
					if (configDataSkillInfo != null)
					{
						this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo, pm);
						num += configDataSkillInfo.BattlePower;
					}
				}
			}
			List<ConfigDataSkillInfo> equipmentResonanceSkillInfos = BattleUtility.GetEquipmentResonanceSkillInfos(this.m_configDataLoader, equipments);
			foreach (ConfigDataSkillInfo configDataSkillInfo2 in equipmentResonanceSkillInfos)
			{
				this.CollectPassiveSkillStaticPropertyModifier(configDataSkillInfo2, pm);
				num += configDataSkillInfo2.BattlePower;
			}
			return num;
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x00122C60 File Offset: 0x00120E60
		private void CollectPassiveSkillStaticPropertyModifier(ConfigDataSkillInfo skillInfo, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfoBattlePropertyModifier_hotfix != null)
			{
				this.m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfoBattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					skillInfo,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo.m_passiveBuffInfos != null)
			{
				foreach (ConfigDataBuffInfo configDataBuffInfo in skillInfo.m_passiveBuffInfos)
				{
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property1_ID, configDataBuffInfo.Property1_Value, pm);
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property2_ID, configDataBuffInfo.Property2_Value, pm);
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property3_ID, configDataBuffInfo.Property3_Value, pm);
					this.CollectStaticPropertyModifier(configDataBuffInfo.Property4_ID, configDataBuffInfo.Property4_Value, pm);
				}
			}
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x00122D58 File Offset: 0x00120F58
		private void CollectStaticPropertyModifier(PropertyModifyType modifyType, int value, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectStaticPropertyModifierPropertyModifyTypeInt32BattlePropertyModifier_hotfix != null)
			{
				this.m_CollectStaticPropertyModifierPropertyModifyTypeInt32BattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					modifyType,
					value,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataPropertyModifyInfo configDataPropertyModifyInfo = this.m_configDataLoader.GetConfigDataPropertyModifyInfo((int)modifyType);
			if (configDataPropertyModifyInfo != null && !configDataPropertyModifyInfo.IsDynamic)
			{
				pm.Collect(modifyType, value);
			}
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00122E10 File Offset: 0x00121010
		protected void InitGainBattleTreasures()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGainBattleTreasures_hotfix != null)
			{
				this.m_InitGainBattleTreasures_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.InitGainBattleTreasures(this.m_battleDS.GotBattleTreasureIds);
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00122E88 File Offset: 0x00121088
		public void AddGotBattleTreasuresInThisBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGotBattleTreasuresInThisBattle_hotfix != null)
			{
				this.m_AddGotBattleTreasuresInThisBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.AddBattleTreasures(this.GetGainBattleTreasuresInThisBattle());
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00122EF4 File Offset: 0x001210F4
		public virtual void AddBattleTreasures(List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBattleTreasuresList`1_hotfix != null)
			{
				this.m_AddBattleTreasuresList`1_hotfix.call(new object[]
				{
					this,
					battleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_gotBattleTreasureIds.Clear();
			foreach (int num in battleTreasures)
			{
				if (!this.m_battleDS.IsGotBattleTreasureId(num))
				{
					this.m_battleDS.AddBattleTreasureId(num);
					this.m_gotBattleTreasureIds.Add(num);
				}
			}
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00122FDC File Offset: 0x001211DC
		public List<int> GetGainBattleTreasuresInThisBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGainBattleTreasuresInThisBattle_hotfix != null)
			{
				return (List<int>)this.m_GetGainBattleTreasuresInThisBattle_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (int num in this.m_battle.GetGainBattleTreasures())
			{
				if (!this.m_battleDS.IsGotBattleTreasureId(num))
				{
					list.Add(num);
				}
			}
			return list;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x001230B4 File Offset: 0x001212B4
		public List<Goods> GetAllBattleBoxTreasuresInBattle(ConfigDataBattleInfo battleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllBattleBoxTreasuresInBattleConfigDataBattleInfo_hotfix != null)
			{
				return (List<Goods>)this.m_GetAllBattleBoxTreasuresInBattleConfigDataBattleInfo_hotfix.call(new object[]
				{
					this,
					battleInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null || battleInfo.m_battleTreasureInfos == null)
			{
				return new List<Goods>();
			}
			List<Goods> list = new List<Goods>();
			foreach (ConfigDataBattleTreasureInfo configDataBattleTreasureInfo in battleInfo.m_battleTreasureInfos)
			{
				if (!this.m_battleDS.IsGotBattleTreasureId(configDataBattleTreasureInfo.ID))
				{
					list.AddRange(configDataBattleTreasureInfo.Reward);
				}
			}
			return list;
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06003EEF RID: 16111 RVA: 0x00123190 File Offset: 0x00121390
		public int BattleRandomSeed
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleRandomSeed_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_BattleRandomSeed_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleDS.ProcessingBattleInfo.RandomSeed;
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x0012320C File Offset: 0x0012140C
		public int ArmyRandomSeed
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ArmyRandomSeed_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ArmyRandomSeed_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleDS.ProcessingBattleInfo.ArmyRandomSeed;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x00123288 File Offset: 0x00121488
		public int ProcessingScenarioId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ProcessingScenarioId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ProcessingScenarioId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleDS.ProcessingBattleInfo.TypeId;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003EF2 RID: 16114 RVA: 0x00123304 File Offset: 0x00121504
		public int ArenaBattleRandomSeed
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ArenaBattleRandomSeed_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ArenaBattleRandomSeed_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleDS.ArenaBattleRandomSeed;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x0012337C File Offset: 0x0012157C
		// (set) Token: 0x06003EF4 RID: 16116 RVA: 0x001233F4 File Offset: 0x001215F4
		public ulong BattleRoomId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleRoomId_hotfix != null)
				{
					return Convert.ToUInt64(this.m_get_BattleRoomId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleDS.BattleRoomId;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_BattleRoomIdUInt64_hotfix != null)
				{
					this.m_set_BattleRoomIdUInt64_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_battleDS.BattleRoomId = value;
			}
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x00123470 File Offset: 0x00121670
		public void OnBattlePracticeMissionEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattlePracticeMissionEvent_hotfix != null)
			{
				this.m_OnBattlePracticeMissionEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.BattlePracticeMissionEvent != null)
			{
				this.BattlePracticeMissionEvent();
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06003EF6 RID: 16118 RVA: 0x001234E8 File Offset: 0x001216E8
		// (remove) Token: 0x06003EF7 RID: 16119 RVA: 0x00123584 File Offset: 0x00121784
		public event Action BattlePracticeMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_BattlePracticeMissionEventAction_hotfix != null)
				{
					this.m_add_BattlePracticeMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.BattlePracticeMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.BattlePracticeMissionEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_BattlePracticeMissionEventAction_hotfix != null)
				{
					this.m_remove_BattlePracticeMissionEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.BattlePracticeMissionEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.BattlePracticeMissionEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06003EF8 RID: 16120 RVA: 0x00123620 File Offset: 0x00121820
		// (set) Token: 0x06003EF9 RID: 16121 RVA: 0x00123640 File Offset: 0x00121840
		[DoNotToLua]
		public BattleComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0012364C File Offset: 0x0012184C
		private void __callDele_BattlePracticeMissionEvent()
		{
			Action battlePracticeMissionEvent = this.BattlePracticeMissionEvent;
			if (battlePracticeMissionEvent != null)
			{
				battlePracticeMissionEvent();
			}
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0012366C File Offset: 0x0012186C
		private void __clearDele_BattlePracticeMissionEvent()
		{
			this.BattlePracticeMissionEvent = null;
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x00123678 File Offset: 0x00121878
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
					this.m_IsGameFunctionOpenByMonthCardGameFunctionType_hotfix = (luaObj.RawGet("IsGameFunctionOpenByMonthCard") as LuaFunction);
					this.m_GetDailyBonusAddNumsByMonthCardGameFunctionType_hotfix = (luaObj.RawGet("GetDailyBonusAddNumsByMonthCard") as LuaFunction);
					this.m_GetDailyBonusMaxNumsGameFunctionType_hotfix = (luaObj.RawGet("GetDailyBonusMaxNums") as LuaFunction);
					this.m_GetSinglePveBattleFightEnergyCost_hotfix = (luaObj.RawGet("GetSinglePveBattleFightEnergyCost") as LuaFunction);
					this.m_GetSinglePveBattleFailEnergyCostByMonthCard_hotfix = (luaObj.RawGet("GetSinglePveBattleFailEnergyCostByMonthCard") as LuaFunction);
					this.m_GetTeamPveBattleFailEnergyCostGameFunctionTypeInt32_hotfix = (luaObj.RawGet("GetTeamPveBattleFailEnergyCost") as LuaFunction);
					this.m_GetTeamPveBattleFailEnergyCostByMonthCardGameFunctionTypeInt32_hotfix = (luaObj.RawGet("GetTeamPveBattleFailEnergyCostByMonthCard") as LuaFunction);
					this.m_GetFightFailEnergyCostByMonthcardInt32_hotfix = (luaObj.RawGet("GetFightFailEnergyCostByMonthcard") as LuaFunction);
					this.m_AddFightFailCompensationEnergyByMonthCardInt32_hotfix = (luaObj.RawGet("AddFightFailCompensationEnergyByMonthCard") as LuaFunction);
					this.m_AddTeamPveFightFailCompensationEnergyByMonthCardGameFunctionTypeInt32_hotfix = (luaObj.RawGet("AddTeamPveFightFailCompensationEnergyByMonthCard") as LuaFunction);
					this.m_AddSinglePveFightFailCompensationEnergyByMonthCard_hotfix = (luaObj.RawGet("AddSinglePveFightFailCompensationEnergyByMonthCard") as LuaFunction);
					this.m_IsWaypointBattling_hotfix = (luaObj.RawGet("IsWaypointBattling") as LuaFunction);
					this.m_OnFlushBattle_hotfix = (luaObj.RawGet("OnFlushBattle") as LuaFunction);
					this.m_IsBattleWin_hotfix = (luaObj.RawGet("IsBattleWin") as LuaFunction);
					this.m_CancelBattle_hotfix = (luaObj.RawGet("CancelBattle") as LuaFunction);
					this.m_IsFighting_hotfix = (luaObj.RawGet("IsFighting") as LuaFunction);
					this.m_CanSetupMineTeam_hotfix = (luaObj.RawGet("CanSetupMineTeam") as LuaFunction);
					this.m_FightFinishedGameFunctionStatusBooleanBoolean_hotfix = (luaObj.RawGet("FightFinished") as LuaFunction);
					this.m_IsWayPointFightExistInt32_hotfix = (luaObj.RawGet("IsWayPointFightExist") as LuaFunction);
					this.m_WinPveBattleInt32_hotfix = (luaObj.RawGet("WinPveBattle") as LuaFunction);
					this.m_FinishedArenaFight_hotfix = (luaObj.RawGet("FinishedArenaFight") as LuaFunction);
					this.m_GetProcessingBattle_hotfix = (luaObj.RawGet("GetProcessingBattle") as LuaFunction);
					this.m_SetProcessingBattleInfoBattleTypeInt32_hotfix = (luaObj.RawGet("SetProcessingBattleInfo") as LuaFunction);
					this.m_SetBattleArmyRandomSeedInt32_hotfix = (luaObj.RawGet("SetBattleArmyRandomSeed") as LuaFunction);
					this.m_GetBattleArmyRandomSeed_hotfix = (luaObj.RawGet("GetBattleArmyRandomSeed") as LuaFunction);
					this.m_SetArenaBattleInfoInt32_hotfix = (luaObj.RawGet("SetArenaBattleInfo") as LuaFunction);
					this.m_IsAttackingPveLevelBattleTypeInt32_hotfix = (luaObj.RawGet("IsAttackingPveLevel") as LuaFunction);
					this.m_IsAttackingArenaOpponent_hotfix = (luaObj.RawGet("IsAttackingArenaOpponent") as LuaFunction);
					this.m_IsArenaBattleInReady_hotfix = (luaObj.RawGet("IsArenaBattleInReady") as LuaFunction);
					this.m_IsAttackingInBattleServer_hotfix = (luaObj.RawGet("IsAttackingInBattleServer") as LuaFunction);
					this.m_FinishBattleInBattleServer_hotfix = (luaObj.RawGet("FinishBattleInBattleServer") as LuaFunction);
					this.m_CanCreateBattleRoomBattleRoomType_hotfix = (luaObj.RawGet("CanCreateBattleRoom") as LuaFunction);
					this.m_CanCreateTeamBattleRoom_hotfix = (luaObj.RawGet("CanCreateTeamBattleRoom") as LuaFunction);
					this.m_CanChangePlayerBattleStatusPlayerBattleStatus_hotfix = (luaObj.RawGet("CanChangePlayerBattleStatus") as LuaFunction);
					this.m_SetArenaBattleFighting_hotfix = (luaObj.RawGet("SetArenaBattleFighting") as LuaFunction);
					this.m_GetBattleId_hotfix = (luaObj.RawGet("GetBattleId") as LuaFunction);
					this.m_GetBattleIdGameFunctionTypeInt32_hotfix = (luaObj.RawGet("GetBattleId") as LuaFunction);
					this.m_GetMonsterLevel_hotfix = (luaObj.RawGet("GetMonsterLevel") as LuaFunction);
					this.m_AddFightHeroFightNumsAndExpList`1Int32_hotfix = (luaObj.RawGet("AddFightHeroFightNumsAndExp") as LuaFunction);
					this.m_GetPveTeam_hotfix = (luaObj.RawGet("GetPveTeam") as LuaFunction);
					this.m_IsMineTeamSetValidInt32Int32List`1_hotfix = (luaObj.RawGet("IsMineTeamSetValid") as LuaFunction);
					this.m_IsArenaDefensiveTeamSetValidInt32Int32_hotfix = (luaObj.RawGet("IsArenaDefensiveTeamSetValid") as LuaFunction);
					this.m_IsActionPositionIndexValidConfigDataArenaBattleInfoInt32_hotfix = (luaObj.RawGet("IsActionPositionIndexValid") as LuaFunction);
					this.m_IsActionValueValidConfigDataArenaBattleInfoInt32_hotfix = (luaObj.RawGet("IsActionValueValid") as LuaFunction);
					this.m_IsTeamEmptyList`1_hotfix = (luaObj.RawGet("IsTeamEmpty") as LuaFunction);
					this.m_SetMineTeamInt32Int32List`1_hotfix = (luaObj.RawGet("SetMineTeam") as LuaFunction);
					this.m_SetTeamBattleTypeList`1_hotfix = (luaObj.RawGet("SetTeam") as LuaFunction);
					this.m_GetTeamBattleType_hotfix = (luaObj.RawGet("GetTeam") as LuaFunction);
					this.m_CreateMineBattleHeroEquipmentsUInt64be_hotfix = (luaObj.RawGet("CreateMineBattleHeroEquipments") as LuaFunction);
					this.m_ComputeBattlePowerFromBattleHeroesList`1List`1_hotfix = (luaObj.RawGet("ComputeBattlePowerFromBattleHeroes") as LuaFunction);
					this.m_ComputeBattlePowerHero_hotfix = (luaObj.RawGet("ComputeBattlePower") as LuaFunction);
					this.m_ComputeBattlePowerBattleHeroList`1_hotfix = (luaObj.RawGet("ComputeBattlePower") as LuaFunction);
					this.m_CollectJobMasterPropertyModifierList`1BattlePropertyModifier_hotfix = (luaObj.RawGet("CollectJobMasterPropertyModifier") as LuaFunction);
					this.m_CollectEquipmentPropertyModifierAndSkillBattlePowerList`1BattlePropertyModifier_hotfix = (luaObj.RawGet("CollectEquipmentPropertyModifierAndSkillBattlePower") as LuaFunction);
					this.m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfoBattlePropertyModifier_hotfix = (luaObj.RawGet("CollectPassiveSkillStaticPropertyModifier") as LuaFunction);
					this.m_CollectStaticPropertyModifierPropertyModifyTypeInt32BattlePropertyModifier_hotfix = (luaObj.RawGet("CollectStaticPropertyModifier") as LuaFunction);
					this.m_InitGainBattleTreasures_hotfix = (luaObj.RawGet("InitGainBattleTreasures") as LuaFunction);
					this.m_AddGotBattleTreasuresInThisBattle_hotfix = (luaObj.RawGet("AddGotBattleTreasuresInThisBattle") as LuaFunction);
					this.m_AddBattleTreasuresList`1_hotfix = (luaObj.RawGet("AddBattleTreasures") as LuaFunction);
					this.m_GetGainBattleTreasuresInThisBattle_hotfix = (luaObj.RawGet("GetGainBattleTreasuresInThisBattle") as LuaFunction);
					this.m_GetAllBattleBoxTreasuresInBattleConfigDataBattleInfo_hotfix = (luaObj.RawGet("GetAllBattleBoxTreasuresInBattle") as LuaFunction);
					this.m_get_BattleRandomSeed_hotfix = (luaObj.RawGet("get_BattleRandomSeed") as LuaFunction);
					this.m_get_ArmyRandomSeed_hotfix = (luaObj.RawGet("get_ArmyRandomSeed") as LuaFunction);
					this.m_get_ProcessingScenarioId_hotfix = (luaObj.RawGet("get_ProcessingScenarioId") as LuaFunction);
					this.m_get_ArenaBattleRandomSeed_hotfix = (luaObj.RawGet("get_ArenaBattleRandomSeed") as LuaFunction);
					this.m_get_BattleRoomId_hotfix = (luaObj.RawGet("get_BattleRoomId") as LuaFunction);
					this.m_set_BattleRoomIdUInt64_hotfix = (luaObj.RawGet("set_BattleRoomId") as LuaFunction);
					this.m_OnBattlePracticeMissionEvent_hotfix = (luaObj.RawGet("OnBattlePracticeMissionEvent") as LuaFunction);
					this.m_add_BattlePracticeMissionEventAction_hotfix = (luaObj.RawGet("add_BattlePracticeMissionEvent") as LuaFunction);
					this.m_remove_BattlePracticeMissionEventAction_hotfix = (luaObj.RawGet("remove_BattlePracticeMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x00123F14 File Offset: 0x00122114
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002F48 RID: 12104
		public List<int> m_gotBattleTreasureIds = new List<int>();

		// Token: 0x04002F49 RID: 12105
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04002F4A RID: 12106
		protected HeroComponentCommon m_hero;

		// Token: 0x04002F4B RID: 12107
		protected LevelComponentCommon m_level;

		// Token: 0x04002F4C RID: 12108
		protected ArenaComponentCommon m_arena;

		// Token: 0x04002F4D RID: 12109
		protected GuildComponentCommon m_guild;

		// Token: 0x04002F4E RID: 12110
		protected RealTimePVPComponentCommon m_realtimePVP;

		// Token: 0x04002F4F RID: 12111
		protected BagComponentCommon m_bag;

		// Token: 0x04002F50 RID: 12112
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04002F51 RID: 12113
		protected TeamComponentCommon m_team;

		// Token: 0x04002F52 RID: 12114
		protected TrainingGroundCompomentCommon m_trainingGround;

		// Token: 0x04002F53 RID: 12115
		protected ResourceComponentCommon m_resource;

		// Token: 0x04002F54 RID: 12116
		protected DataSectionBattle m_battleDS = new DataSectionBattle();

		// Token: 0x04002F55 RID: 12117
		protected BattleBase m_battle;

		// Token: 0x04002F56 RID: 12118
		private BattlePropertyModifier m_propertyModifier;

		// Token: 0x04002F57 RID: 12119
		private BattleProperty m_battleProperty;

		// Token: 0x04002F59 RID: 12121
		[DoNotToLua]
		private BattleComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002F5A RID: 12122
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002F5B RID: 12123
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002F5C RID: 12124
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002F5D RID: 12125
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002F5E RID: 12126
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002F5F RID: 12127
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002F60 RID: 12128
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002F61 RID: 12129
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002F62 RID: 12130
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002F63 RID: 12131
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002F64 RID: 12132
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002F65 RID: 12133
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04002F66 RID: 12134
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04002F67 RID: 12135
		private LuaFunction m_IsGameFunctionOpenByMonthCardGameFunctionType_hotfix;

		// Token: 0x04002F68 RID: 12136
		private LuaFunction m_GetDailyBonusAddNumsByMonthCardGameFunctionType_hotfix;

		// Token: 0x04002F69 RID: 12137
		private LuaFunction m_GetDailyBonusMaxNumsGameFunctionType_hotfix;

		// Token: 0x04002F6A RID: 12138
		private LuaFunction m_GetSinglePveBattleFightEnergyCost_hotfix;

		// Token: 0x04002F6B RID: 12139
		private LuaFunction m_GetSinglePveBattleFailEnergyCostByMonthCard_hotfix;

		// Token: 0x04002F6C RID: 12140
		private LuaFunction m_GetTeamPveBattleFailEnergyCostGameFunctionTypeInt32_hotfix;

		// Token: 0x04002F6D RID: 12141
		private LuaFunction m_GetTeamPveBattleFailEnergyCostByMonthCardGameFunctionTypeInt32_hotfix;

		// Token: 0x04002F6E RID: 12142
		private LuaFunction m_GetFightFailEnergyCostByMonthcardInt32_hotfix;

		// Token: 0x04002F6F RID: 12143
		private LuaFunction m_AddFightFailCompensationEnergyByMonthCardInt32_hotfix;

		// Token: 0x04002F70 RID: 12144
		private LuaFunction m_AddTeamPveFightFailCompensationEnergyByMonthCardGameFunctionTypeInt32_hotfix;

		// Token: 0x04002F71 RID: 12145
		private LuaFunction m_AddSinglePveFightFailCompensationEnergyByMonthCard_hotfix;

		// Token: 0x04002F72 RID: 12146
		private LuaFunction m_IsWaypointBattling_hotfix;

		// Token: 0x04002F73 RID: 12147
		private LuaFunction m_OnFlushBattle_hotfix;

		// Token: 0x04002F74 RID: 12148
		private LuaFunction m_IsBattleWin_hotfix;

		// Token: 0x04002F75 RID: 12149
		private LuaFunction m_CancelBattle_hotfix;

		// Token: 0x04002F76 RID: 12150
		private LuaFunction m_IsFighting_hotfix;

		// Token: 0x04002F77 RID: 12151
		private LuaFunction m_CanSetupMineTeam_hotfix;

		// Token: 0x04002F78 RID: 12152
		private LuaFunction m_FightFinishedGameFunctionStatusBooleanBoolean_hotfix;

		// Token: 0x04002F79 RID: 12153
		private LuaFunction m_IsWayPointFightExistInt32_hotfix;

		// Token: 0x04002F7A RID: 12154
		private LuaFunction m_WinPveBattleInt32_hotfix;

		// Token: 0x04002F7B RID: 12155
		private LuaFunction m_FinishedArenaFight_hotfix;

		// Token: 0x04002F7C RID: 12156
		private LuaFunction m_GetProcessingBattle_hotfix;

		// Token: 0x04002F7D RID: 12157
		private LuaFunction m_SetProcessingBattleInfoBattleTypeInt32_hotfix;

		// Token: 0x04002F7E RID: 12158
		private LuaFunction m_SetBattleArmyRandomSeedInt32_hotfix;

		// Token: 0x04002F7F RID: 12159
		private LuaFunction m_GetBattleArmyRandomSeed_hotfix;

		// Token: 0x04002F80 RID: 12160
		private LuaFunction m_SetArenaBattleInfoInt32_hotfix;

		// Token: 0x04002F81 RID: 12161
		private LuaFunction m_IsAttackingPveLevelBattleTypeInt32_hotfix;

		// Token: 0x04002F82 RID: 12162
		private LuaFunction m_IsAttackingArenaOpponent_hotfix;

		// Token: 0x04002F83 RID: 12163
		private LuaFunction m_IsArenaBattleInReady_hotfix;

		// Token: 0x04002F84 RID: 12164
		private LuaFunction m_IsAttackingInBattleServer_hotfix;

		// Token: 0x04002F85 RID: 12165
		private LuaFunction m_FinishBattleInBattleServer_hotfix;

		// Token: 0x04002F86 RID: 12166
		private LuaFunction m_CanCreateBattleRoomBattleRoomType_hotfix;

		// Token: 0x04002F87 RID: 12167
		private LuaFunction m_CanCreateTeamBattleRoom_hotfix;

		// Token: 0x04002F88 RID: 12168
		private LuaFunction m_CanChangePlayerBattleStatusPlayerBattleStatus_hotfix;

		// Token: 0x04002F89 RID: 12169
		private LuaFunction m_SetArenaBattleFighting_hotfix;

		// Token: 0x04002F8A RID: 12170
		private LuaFunction m_GetBattleId_hotfix;

		// Token: 0x04002F8B RID: 12171
		private LuaFunction m_GetBattleIdGameFunctionTypeInt32_hotfix;

		// Token: 0x04002F8C RID: 12172
		private LuaFunction m_GetMonsterLevel_hotfix;

		// Token: 0x04002F8D RID: 12173
		private LuaFunction m_AddFightHeroFightNumsAndExpList;

		// Token: 0x04002F8E RID: 12174
		private LuaFunction m_GetPveTeam_hotfix;

		// Token: 0x04002F8F RID: 12175
		private LuaFunction m_IsMineTeamSetValidInt32Int32List;

		// Token: 0x04002F90 RID: 12176
		private LuaFunction m_IsArenaDefensiveTeamSetValidInt32Int32_hotfix;

		// Token: 0x04002F91 RID: 12177
		private LuaFunction m_IsActionPositionIndexValidConfigDataArenaBattleInfoInt32_hotfix;

		// Token: 0x04002F92 RID: 12178
		private LuaFunction m_IsActionValueValidConfigDataArenaBattleInfoInt32_hotfix;

		// Token: 0x04002F93 RID: 12179
		private LuaFunction m_IsTeamEmptyList;

		// Token: 0x04002F94 RID: 12180
		private LuaFunction m_SetMineTeamInt32Int32List;

		// Token: 0x04002F95 RID: 12181
		private LuaFunction m_SetTeamBattleTypeList;

		// Token: 0x04002F96 RID: 12182
		private LuaFunction m_GetTeamBattleType_hotfix;

		// Token: 0x04002F97 RID: 12183
		private LuaFunction m_CreateMineBattleHeroEquipmentsUInt64be_hotfix;

		// Token: 0x04002F98 RID: 12184
		private LuaFunction m_ComputeBattlePowerFromBattleHeroesList`1List;

		// Token: 0x04002F99 RID: 12185
		private LuaFunction m_ComputeBattlePowerHero_hotfix;

		// Token: 0x04002F9A RID: 12186
		private LuaFunction m_ComputeBattlePowerBattleHeroList;

		// Token: 0x04002F9B RID: 12187
		private LuaFunction m_CollectJobMasterPropertyModifierList;

		// Token: 0x04002F9C RID: 12188
		private LuaFunction m_CollectEquipmentPropertyModifierAndSkillBattlePowerList;

		// Token: 0x04002F9D RID: 12189
		private LuaFunction m_CollectPassiveSkillStaticPropertyModifierConfigDataSkillInfoBattlePropertyModifier_hotfix;

		// Token: 0x04002F9E RID: 12190
		private LuaFunction m_CollectStaticPropertyModifierPropertyModifyTypeInt32BattlePropertyModifier_hotfix;

		// Token: 0x04002F9F RID: 12191
		private LuaFunction m_InitGainBattleTreasures_hotfix;

		// Token: 0x04002FA0 RID: 12192
		private LuaFunction m_AddGotBattleTreasuresInThisBattle_hotfix;

		// Token: 0x04002FA1 RID: 12193
		private LuaFunction m_AddBattleTreasuresList;

		// Token: 0x04002FA2 RID: 12194
		private LuaFunction m_GetGainBattleTreasuresInThisBattle_hotfix;

		// Token: 0x04002FA3 RID: 12195
		private LuaFunction m_GetAllBattleBoxTreasuresInBattleConfigDataBattleInfo_hotfix;

		// Token: 0x04002FA4 RID: 12196
		private LuaFunction m_get_BattleRandomSeed_hotfix;

		// Token: 0x04002FA5 RID: 12197
		private LuaFunction m_get_ArmyRandomSeed_hotfix;

		// Token: 0x04002FA6 RID: 12198
		private LuaFunction m_get_ProcessingScenarioId_hotfix;

		// Token: 0x04002FA7 RID: 12199
		private LuaFunction m_get_ArenaBattleRandomSeed_hotfix;

		// Token: 0x04002FA8 RID: 12200
		private LuaFunction m_get_BattleRoomId_hotfix;

		// Token: 0x04002FA9 RID: 12201
		private LuaFunction m_set_BattleRoomIdUInt64_hotfix;

		// Token: 0x04002FAA RID: 12202
		private LuaFunction m_OnBattlePracticeMissionEvent_hotfix;

		// Token: 0x04002FAB RID: 12203
		private LuaFunction m_add_BattlePracticeMissionEventAction_hotfix;

		// Token: 0x04002FAC RID: 12204
		private LuaFunction m_remove_BattlePracticeMissionEventAction_hotfix;

		// Token: 0x02000435 RID: 1077
		public class LuaExportHelper
		{
			// Token: 0x06003EFE RID: 16126 RVA: 0x00123F7C File Offset: 0x0012217C
			public LuaExportHelper(BattleComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003EFF RID: 16127 RVA: 0x00123F8C File Offset: 0x0012218C
			public void __callDele_BattlePracticeMissionEvent()
			{
				this.m_owner.__callDele_BattlePracticeMissionEvent();
			}

			// Token: 0x06003F00 RID: 16128 RVA: 0x00123F9C File Offset: 0x0012219C
			public void __clearDele_BattlePracticeMissionEvent()
			{
				this.m_owner.__clearDele_BattlePracticeMissionEvent();
			}

			// Token: 0x170010E6 RID: 4326
			// (get) Token: 0x06003F01 RID: 16129 RVA: 0x00123FAC File Offset: 0x001221AC
			// (set) Token: 0x06003F02 RID: 16130 RVA: 0x00123FBC File Offset: 0x001221BC
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

			// Token: 0x170010E7 RID: 4327
			// (get) Token: 0x06003F03 RID: 16131 RVA: 0x00123FCC File Offset: 0x001221CC
			// (set) Token: 0x06003F04 RID: 16132 RVA: 0x00123FDC File Offset: 0x001221DC
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

			// Token: 0x170010E8 RID: 4328
			// (get) Token: 0x06003F05 RID: 16133 RVA: 0x00123FEC File Offset: 0x001221EC
			// (set) Token: 0x06003F06 RID: 16134 RVA: 0x00123FFC File Offset: 0x001221FC
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

			// Token: 0x170010E9 RID: 4329
			// (get) Token: 0x06003F07 RID: 16135 RVA: 0x0012400C File Offset: 0x0012220C
			// (set) Token: 0x06003F08 RID: 16136 RVA: 0x0012401C File Offset: 0x0012221C
			public ArenaComponentCommon m_arena
			{
				get
				{
					return this.m_owner.m_arena;
				}
				set
				{
					this.m_owner.m_arena = value;
				}
			}

			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06003F09 RID: 16137 RVA: 0x0012402C File Offset: 0x0012222C
			// (set) Token: 0x06003F0A RID: 16138 RVA: 0x0012403C File Offset: 0x0012223C
			public GuildComponentCommon m_guild
			{
				get
				{
					return this.m_owner.m_guild;
				}
				set
				{
					this.m_owner.m_guild = value;
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06003F0B RID: 16139 RVA: 0x0012404C File Offset: 0x0012224C
			// (set) Token: 0x06003F0C RID: 16140 RVA: 0x0012405C File Offset: 0x0012225C
			public RealTimePVPComponentCommon m_realtimePVP
			{
				get
				{
					return this.m_owner.m_realtimePVP;
				}
				set
				{
					this.m_owner.m_realtimePVP = value;
				}
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x06003F0D RID: 16141 RVA: 0x0012406C File Offset: 0x0012226C
			// (set) Token: 0x06003F0E RID: 16142 RVA: 0x0012407C File Offset: 0x0012227C
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

			// Token: 0x170010ED RID: 4333
			// (get) Token: 0x06003F0F RID: 16143 RVA: 0x0012408C File Offset: 0x0012228C
			// (set) Token: 0x06003F10 RID: 16144 RVA: 0x0012409C File Offset: 0x0012229C
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

			// Token: 0x170010EE RID: 4334
			// (get) Token: 0x06003F11 RID: 16145 RVA: 0x001240AC File Offset: 0x001222AC
			// (set) Token: 0x06003F12 RID: 16146 RVA: 0x001240BC File Offset: 0x001222BC
			public TeamComponentCommon m_team
			{
				get
				{
					return this.m_owner.m_team;
				}
				set
				{
					this.m_owner.m_team = value;
				}
			}

			// Token: 0x170010EF RID: 4335
			// (get) Token: 0x06003F13 RID: 16147 RVA: 0x001240CC File Offset: 0x001222CC
			// (set) Token: 0x06003F14 RID: 16148 RVA: 0x001240DC File Offset: 0x001222DC
			public TrainingGroundCompomentCommon m_trainingGround
			{
				get
				{
					return this.m_owner.m_trainingGround;
				}
				set
				{
					this.m_owner.m_trainingGround = value;
				}
			}

			// Token: 0x170010F0 RID: 4336
			// (get) Token: 0x06003F15 RID: 16149 RVA: 0x001240EC File Offset: 0x001222EC
			// (set) Token: 0x06003F16 RID: 16150 RVA: 0x001240FC File Offset: 0x001222FC
			public ResourceComponentCommon m_resource
			{
				get
				{
					return this.m_owner.m_resource;
				}
				set
				{
					this.m_owner.m_resource = value;
				}
			}

			// Token: 0x170010F1 RID: 4337
			// (get) Token: 0x06003F17 RID: 16151 RVA: 0x0012410C File Offset: 0x0012230C
			// (set) Token: 0x06003F18 RID: 16152 RVA: 0x0012411C File Offset: 0x0012231C
			public DataSectionBattle m_battleDS
			{
				get
				{
					return this.m_owner.m_battleDS;
				}
				set
				{
					this.m_owner.m_battleDS = value;
				}
			}

			// Token: 0x170010F2 RID: 4338
			// (get) Token: 0x06003F19 RID: 16153 RVA: 0x0012412C File Offset: 0x0012232C
			// (set) Token: 0x06003F1A RID: 16154 RVA: 0x0012413C File Offset: 0x0012233C
			public BattleBase m_battle
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

			// Token: 0x170010F3 RID: 4339
			// (get) Token: 0x06003F1B RID: 16155 RVA: 0x0012414C File Offset: 0x0012234C
			// (set) Token: 0x06003F1C RID: 16156 RVA: 0x0012415C File Offset: 0x0012235C
			public BattlePropertyModifier m_propertyModifier
			{
				get
				{
					return this.m_owner.m_propertyModifier;
				}
				set
				{
					this.m_owner.m_propertyModifier = value;
				}
			}

			// Token: 0x170010F4 RID: 4340
			// (get) Token: 0x06003F1D RID: 16157 RVA: 0x0012416C File Offset: 0x0012236C
			// (set) Token: 0x06003F1E RID: 16158 RVA: 0x0012417C File Offset: 0x0012237C
			public BattleProperty m_battleProperty
			{
				get
				{
					return this.m_owner.m_battleProperty;
				}
				set
				{
					this.m_owner.m_battleProperty = value;
				}
			}

			// Token: 0x06003F1F RID: 16159 RVA: 0x0012418C File Offset: 0x0012238C
			public int GetDailyBonusAddNumsByMonthCard(GameFunctionType gameFuncTypeId)
			{
				return this.m_owner.GetDailyBonusAddNumsByMonthCard(gameFuncTypeId);
			}

			// Token: 0x06003F20 RID: 16160 RVA: 0x0012419C File Offset: 0x0012239C
			public int GetSinglePveBattleFightEnergyCost()
			{
				return this.m_owner.GetSinglePveBattleFightEnergyCost();
			}

			// Token: 0x06003F21 RID: 16161 RVA: 0x001241AC File Offset: 0x001223AC
			public int GetFightFailEnergyCostByMonthcard(int energyCost)
			{
				return this.m_owner.GetFightFailEnergyCostByMonthcard(energyCost);
			}

			// Token: 0x06003F22 RID: 16162 RVA: 0x001241BC File Offset: 0x001223BC
			public void AddFightFailCompensationEnergyByMonthCard(int energyCost)
			{
				this.m_owner.AddFightFailCompensationEnergyByMonthCard(energyCost);
			}

			// Token: 0x06003F23 RID: 16163 RVA: 0x001241CC File Offset: 0x001223CC
			public void AddSinglePveFightFailCompensationEnergyByMonthCard()
			{
				this.m_owner.AddSinglePveFightFailCompensationEnergyByMonthCard();
			}

			// Token: 0x06003F24 RID: 16164 RVA: 0x001241DC File Offset: 0x001223DC
			public void OnFlushBattle()
			{
				this.m_owner.OnFlushBattle();
			}

			// Token: 0x06003F25 RID: 16165 RVA: 0x001241EC File Offset: 0x001223EC
			public bool IsTeamEmpty(List<int> team)
			{
				return this.m_owner.IsTeamEmpty(team);
			}

			// Token: 0x06003F26 RID: 16166 RVA: 0x001241FC File Offset: 0x001223FC
			public void CollectJobMasterPropertyModifier(List<BattleHeroJob> jobs, BattlePropertyModifier pm)
			{
				this.m_owner.CollectJobMasterPropertyModifier(jobs, pm);
			}

			// Token: 0x06003F27 RID: 16167 RVA: 0x0012420C File Offset: 0x0012240C
			public static void CollectJobPropertyModifier(ConfigDataJobInfo jobInfo, BattlePropertyModifier pm)
			{
				BattleComponentCommon.CollectJobPropertyModifier(jobInfo, pm);
			}

			// Token: 0x06003F28 RID: 16168 RVA: 0x00124218 File Offset: 0x00122418
			public int CollectEquipmentPropertyModifierAndSkillBattlePower(List<BattleHeroEquipment> equipments, BattlePropertyModifier pm)
			{
				return this.m_owner.CollectEquipmentPropertyModifierAndSkillBattlePower(equipments, pm);
			}

			// Token: 0x06003F29 RID: 16169 RVA: 0x00124228 File Offset: 0x00122428
			public void CollectPassiveSkillStaticPropertyModifier(ConfigDataSkillInfo skillInfo, BattlePropertyModifier pm)
			{
				this.m_owner.CollectPassiveSkillStaticPropertyModifier(skillInfo, pm);
			}

			// Token: 0x06003F2A RID: 16170 RVA: 0x00124238 File Offset: 0x00122438
			public void CollectStaticPropertyModifier(PropertyModifyType modifyType, int value, BattlePropertyModifier pm)
			{
				this.m_owner.CollectStaticPropertyModifier(modifyType, value, pm);
			}

			// Token: 0x06003F2B RID: 16171 RVA: 0x00124248 File Offset: 0x00122448
			public void InitGainBattleTreasures()
			{
				this.m_owner.InitGainBattleTreasures();
			}

			// Token: 0x04002FAD RID: 12205
			private BattleComponentCommon m_owner;
		}
	}
}
