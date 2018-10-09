using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200043A RID: 1082
	[HotFix]
	public class ClimbTowerComponentCommon : IComponentBase
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x00125610 File Offset: 0x00123810
		public ClimbTowerComponentCommon()
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

		// Token: 0x06003F5D RID: 16221 RVA: 0x00125684 File Offset: 0x00123884
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
			return "ClimbTower";
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x001256F8 File Offset: 0x001238F8
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

		// Token: 0x06003F5F RID: 16223 RVA: 0x00125758 File Offset: 0x00123958
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
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			ConfigDataConfigableConst configDataConfigableConst = this.m_configDataLoader.GetConfigDataConfigableConst(296);
			if (configDataConfigableConst != null)
			{
				this.ClimbTowerFloorMax = configDataConfigableConst.Value;
			}
			configDataConfigableConst = this.m_configDataLoader.GetConfigDataConfigableConst(294);
			if (configDataConfigableConst != null)
			{
				this.AutoClimbFactor = configDataConfigableConst.Value;
			}
			configDataConfigableConst = this.m_configDataLoader.GetConfigDataConfigableConst(295);
			if (configDataConfigableConst != null)
			{
				this.AutoClimbMax = configDataConfigableConst.Value;
			}
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x00125890 File Offset: 0x00123A90
		public void DeInit()
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

		// Token: 0x06003F61 RID: 16225 RVA: 0x001258F0 File Offset: 0x00123AF0
		public void Tick(uint deltaMillisecond)
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

		// Token: 0x06003F62 RID: 16226 RVA: 0x00125960 File Offset: 0x00123B60
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

		// Token: 0x06003F63 RID: 16227 RVA: 0x001259E0 File Offset: 0x00123BE0
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

		// Token: 0x06003F64 RID: 16228 RVA: 0x00125A50 File Offset: 0x00123C50
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

		// Token: 0x06003F65 RID: 16229 RVA: 0x00125AB0 File Offset: 0x00123CB0
		public bool IsNeedFlush()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedFlush_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedFlush_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.GetCurrentTime() >= this.m_climbTowerDS.ClimbTower.NextFlushTime;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00125B3C File Offset: 0x00123D3C
		public int GetAutoRaidClimbTowerMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAutoRaidClimbTowerMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAutoRaidClimbTowerMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			if (this.m_climbTowerDS.ClimbTower.HistoryFloorMax > this.AutoClimbFactor)
			{
				num = this.m_climbTowerDS.ClimbTower.HistoryFloorMax - this.AutoClimbFactor;
			}
			if (num > this.AutoClimbMax)
			{
				num = this.AutoClimbMax;
			}
			return num;
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00125BF4 File Offset: 0x00123DF4
		public bool IsReachTopTower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsReachTopTower_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsReachTopTower_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_climbTowerDS.ClimbTower.Floor == this.ClimbTowerFloorMax;
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00125C78 File Offset: 0x00123E78
		public ClimbTower GetClimbTower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClimbTower_hotfix != null)
			{
				return (ClimbTower)this.m_GetClimbTower_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_climbTowerDS.ClimbTower;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x00125CF0 File Offset: 0x00123EF0
		public void SetCompleteSuccessFloor(int floorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCompleteSuccessFloorInt32_hotfix != null)
			{
				this.m_SetCompleteSuccessFloorInt32_hotfix.call(new object[]
				{
					this,
					floorId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_climbTowerDS.ClimbTower.Floor = floorId;
			if (floorId > this.m_climbTowerDS.ClimbTower.HistoryFloorMax)
			{
				this.m_climbTowerDS.ClimbTower.HistoryFloorMax = floorId;
			}
			this.m_climbTowerDS.SetDirty(true);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00125DA4 File Offset: 0x00123FA4
		public GlobalClimbTowerInfo GetGlobalClimbTowerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGlobalClimbTowerInfo_hotfix != null)
			{
				return (GlobalClimbTowerInfo)this.m_GetGlobalClimbTowerInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_climbTowerDS.GlobalClimbTowerInfo;
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00125E1C File Offset: 0x0012401C
		public int AttackClimbTowerLevel(int floorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackClimbTowerLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackClimbTowerLevelInt32_hotfix.call(new object[]
				{
					this,
					floorId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackClimbTowerLevel(floorId);
			if (num != 0)
			{
				return num;
			}
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(floorId);
			this.m_basicInfo.DecreaseEnergy(configDataTowerFloorInfo.EnergyFail, GameFunctionType.GameFunctionType_ClimbTower, floorId.ToString());
			GlobalClimbTowerFloor globalClimbTowerFloor = this.m_climbTowerDS.GlobalClimbTowerInfo.Floors[floorId - 1];
			this.m_battle.SetProcessingBattleInfo(BattleType.ClimbTower, floorId);
			this.m_battle.SetBattleArmyRandomSeed(globalClimbTowerFloor.ArmyRandomSeed);
			ClimberTowerProcessingBattleParamInterface climberTowerProcessingBattleParamInterface = new ClimberTowerProcessingBattleParamInterface(this.m_battle.GetProcessingBattle());
			climberTowerProcessingBattleParamInterface.SetFloorId(floorId);
			climberTowerProcessingBattleParamInterface.SetLevelId(globalClimbTowerFloor.LevelId);
			climberTowerProcessingBattleParamInterface.SetRuleId(globalClimbTowerFloor.RuleId);
			climberTowerProcessingBattleParamInterface.SetBonusHeroGroupId(globalClimbTowerFloor.BonusHeroGroupId);
			return 0;
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00125F6C File Offset: 0x0012416C
		public int CanAttackClimbTowerLevel(int floorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackClimbTowerLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackClimbTowerLevelInt32_hotfix.call(new object[]
				{
					this,
					floorId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num;
			if (this.IsNeedFlush())
			{
				num = -5403;
			}
			else if (floorId < 1 || floorId > this.ClimbTowerFloorMax)
			{
				num = -5400;
			}
			else if (this.m_climbTowerDS.ClimbTower.Floor + 1 != floorId)
			{
				num = -5404;
			}
			else
			{
				GlobalClimbTowerFloor floor = this.GetFloor(floorId);
				if (floor == null)
				{
					num = -5405;
				}
				else
				{
					ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(floorId);
					if (configDataTowerFloorInfo == null)
					{
						num = -5407;
					}
					else
					{
						num = this.CanAttackLevelByEnergyAndSoOn(configDataTowerFloorInfo, true);
						if (num == 0)
						{
							if (this.m_configDataLoader.GetConfigDataTowerLevelInfo(floor.LevelId) == null)
							{
								num = -5402;
							}
							else if (configDataTowerFloorInfo.HasBonusHero != 0 && this.m_configDataLoader.GetConfigDataTowerBonusHeroGroupInfo(floor.BonusHeroGroupId) == null)
							{
								num = -5406;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x001260E0 File Offset: 0x001242E0
		public GlobalClimbTowerFloor GetFloor(int floorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFloorInt32_hotfix != null)
			{
				return (GlobalClimbTowerFloor)this.m_GetFloorInt32_hotfix.call(new object[]
				{
					this,
					floorId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (floorId < 1 || floorId > this.ClimbTowerFloorMax)
			{
				return null;
			}
			return this.m_climbTowerDS.GlobalClimbTowerInfo.Floors[floorId - 1];
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0012618C File Offset: 0x0012438C
		public GlobalClimbTowerInfo NewClimbTower(int seed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NewClimbTowerInt32_hotfix != null)
			{
				return (GlobalClimbTowerInfo)this.m_NewClimbTowerInt32_hotfix.call(new object[]
				{
					this,
					seed
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GlobalClimbTowerInfo globalClimbTowerInfo = new GlobalClimbTowerInfo();
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, ConfigDataTowerBonusHeroGroupInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataTowerBonusHeroGroupInfo())
			{
				list.Add(keyValuePair.Key);
			}
			Random random = new Random(seed);
			for (int i = 1; i <= this.ClimbTowerFloorMax; i++)
			{
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = this.m_configDataLoader.GetConfigDataTowerFloorInfo(i);
				GlobalClimbTowerFloor globalClimbTowerFloor = new GlobalClimbTowerFloor();
				globalClimbTowerFloor.LevelId = configDataTowerFloorInfo.RandomLevelIdList[random.Next(configDataTowerFloorInfo.RandomLevelIdList.Count)];
				globalClimbTowerFloor.ArmyRandomSeed = random.Next();
				ConfigDataTowerLevelInfo configDataTowerLevelInfo = this.m_configDataLoader.GetConfigDataTowerLevelInfo(globalClimbTowerFloor.LevelId);
				globalClimbTowerFloor.RuleId = configDataTowerLevelInfo.BattleRuleList[random.Next(configDataTowerLevelInfo.BattleRuleList.Count)];
				if (configDataTowerFloorInfo.HasBonusHero != 0)
				{
					globalClimbTowerFloor.BonusHeroGroupId = list[random.Next(list.Count)];
				}
				globalClimbTowerInfo.Floors.Add(globalClimbTowerFloor);
			}
			return globalClimbTowerInfo;
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00126348 File Offset: 0x00124548
		protected void SetCommonSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, List<int> battleTreasures, int energyCost)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList`1Int32_hotfix != null)
			{
				this.m_SetCommonSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList`1Int32_hotfix.call(new object[]
				{
					this,
					floorInfo,
					levelInfo,
					battleTreasures,
					energyCost
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.AddPlayerExp(floorInfo.PlayerExp);
			if (energyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(energyCost, GameFunctionType.GameFunctionType_ClimbTower, floorInfo.ID.ToString());
			}
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			this.SetCompleteSuccessFloor(floorInfo.ID);
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00126450 File Offset: 0x00124650
		public int CanRaidLevel(ConfigDataTowerFloorInfo floorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanRaidLevelConfigDataTowerFloorInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanRaidLevelConfigDataTowerFloorInfo_hotfix.call(new object[]
				{
					this,
					floorInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.CanAttackLevelByEnergyAndSoOn(floorInfo, false);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x001264D4 File Offset: 0x001246D4
		protected void SetRaidSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRaidSuccessClimbTowerLevelConfigDataTowerFloorInfo_hotfix != null)
			{
				this.m_SetRaidSuccessClimbTowerLevelConfigDataTowerFloorInfo_hotfix.call(new object[]
				{
					this,
					floorInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo.DecreaseEnergy(floorInfo.EnergySuccess, GameFunctionType.GameFunctionType_ClimbTower, floorInfo.ID.ToString());
			this.m_basicInfo.AddPlayerExp(floorInfo.PlayerExp);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00126580 File Offset: 0x00124780
		protected int CanAttackLevelByEnergyAndSoOn(ConfigDataTowerFloorInfo floorInfo, bool checkBagFull = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataTowerFloorInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataTowerFloorInfoBoolean_hotfix.call(new object[]
				{
					this,
					floorInfo,
					checkBagFull
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_basicInfo.IsEnergyEnough(floorInfo.EnergySuccess))
			{
				return -402;
			}
			if (checkBagFull && this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x00126648 File Offset: 0x00124848
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x001266BC File Offset: 0x001248BC
		protected int ClimbTowerFloorMax
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ClimbTowerFloorMax_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ClimbTowerFloorMax_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ClimbTowerFloorMax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ClimbTowerFloorMaxInt32_hotfix != null)
				{
					this.m_set_ClimbTowerFloorMaxInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ClimbTowerFloorMax>k__BackingField = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x00126734 File Offset: 0x00124934
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x001267A8 File Offset: 0x001249A8
		protected int AutoClimbFactor
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AutoClimbFactor_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_AutoClimbFactor_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<AutoClimbFactor>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_AutoClimbFactorInt32_hotfix != null)
				{
					this.m_set_AutoClimbFactorInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<AutoClimbFactor>k__BackingField = value;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x00126820 File Offset: 0x00124A20
		// (set) Token: 0x06003F78 RID: 16248 RVA: 0x00126894 File Offset: 0x00124A94
		protected int AutoClimbMax
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AutoClimbMax_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_AutoClimbMax_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<AutoClimbMax>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_AutoClimbMaxInt32_hotfix != null)
				{
					this.m_set_AutoClimbMaxInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<AutoClimbMax>k__BackingField = value;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x0012690C File Offset: 0x00124B0C
		// (set) Token: 0x06003F7A RID: 16250 RVA: 0x00126980 File Offset: 0x00124B80
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

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06003F7B RID: 16251 RVA: 0x001269F8 File Offset: 0x00124BF8
		// (set) Token: 0x06003F7C RID: 16252 RVA: 0x00126A18 File Offset: 0x00124C18
		[DoNotToLua]
		public ClimbTowerComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00126A24 File Offset: 0x00124C24
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
					this.m_IsNeedFlush_hotfix = (luaObj.RawGet("IsNeedFlush") as LuaFunction);
					this.m_GetAutoRaidClimbTowerMax_hotfix = (luaObj.RawGet("GetAutoRaidClimbTowerMax") as LuaFunction);
					this.m_IsReachTopTower_hotfix = (luaObj.RawGet("IsReachTopTower") as LuaFunction);
					this.m_GetClimbTower_hotfix = (luaObj.RawGet("GetClimbTower") as LuaFunction);
					this.m_SetCompleteSuccessFloorInt32_hotfix = (luaObj.RawGet("SetCompleteSuccessFloor") as LuaFunction);
					this.m_GetGlobalClimbTowerInfo_hotfix = (luaObj.RawGet("GetGlobalClimbTowerInfo") as LuaFunction);
					this.m_AttackClimbTowerLevelInt32_hotfix = (luaObj.RawGet("AttackClimbTowerLevel") as LuaFunction);
					this.m_CanAttackClimbTowerLevelInt32_hotfix = (luaObj.RawGet("CanAttackClimbTowerLevel") as LuaFunction);
					this.m_GetFloorInt32_hotfix = (luaObj.RawGet("GetFloor") as LuaFunction);
					this.m_NewClimbTowerInt32_hotfix = (luaObj.RawGet("NewClimbTower") as LuaFunction);
					this.m_SetCommonSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList`1Int32_hotfix = (luaObj.RawGet("SetCommonSuccessClimbTowerLevel") as LuaFunction);
					this.m_CanRaidLevelConfigDataTowerFloorInfo_hotfix = (luaObj.RawGet("CanRaidLevel") as LuaFunction);
					this.m_SetRaidSuccessClimbTowerLevelConfigDataTowerFloorInfo_hotfix = (luaObj.RawGet("SetRaidSuccessClimbTowerLevel") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataTowerFloorInfoBoolean_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_get_ClimbTowerFloorMax_hotfix = (luaObj.RawGet("get_ClimbTowerFloorMax") as LuaFunction);
					this.m_set_ClimbTowerFloorMaxInt32_hotfix = (luaObj.RawGet("set_ClimbTowerFloorMax") as LuaFunction);
					this.m_get_AutoClimbFactor_hotfix = (luaObj.RawGet("get_AutoClimbFactor") as LuaFunction);
					this.m_set_AutoClimbFactorInt32_hotfix = (luaObj.RawGet("set_AutoClimbFactor") as LuaFunction);
					this.m_get_AutoClimbMax_hotfix = (luaObj.RawGet("get_AutoClimbMax") as LuaFunction);
					this.m_set_AutoClimbMaxInt32_hotfix = (luaObj.RawGet("set_AutoClimbMax") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00126DE0 File Offset: 0x00124FE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002FDC RID: 12252
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04002FDD RID: 12253
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04002FDE RID: 12254
		protected BattleComponentCommon m_battle;

		// Token: 0x04002FDF RID: 12255
		protected BagComponentCommon m_bag;

		// Token: 0x04002FE0 RID: 12256
		protected HeroComponentCommon m_hero;

		// Token: 0x04002FE1 RID: 12257
		protected DataSectionClimbTower m_climbTowerDS = new DataSectionClimbTower();

		// Token: 0x04002FE2 RID: 12258
		[DoNotToLua]
		private ClimbTowerComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04002FE3 RID: 12259
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002FE4 RID: 12260
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002FE5 RID: 12261
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002FE6 RID: 12262
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04002FE7 RID: 12263
		private LuaFunction m_Init_hotfix;

		// Token: 0x04002FE8 RID: 12264
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04002FE9 RID: 12265
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04002FEA RID: 12266
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04002FEB RID: 12267
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04002FEC RID: 12268
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04002FED RID: 12269
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04002FEE RID: 12270
		private LuaFunction m_IsNeedFlush_hotfix;

		// Token: 0x04002FEF RID: 12271
		private LuaFunction m_GetAutoRaidClimbTowerMax_hotfix;

		// Token: 0x04002FF0 RID: 12272
		private LuaFunction m_IsReachTopTower_hotfix;

		// Token: 0x04002FF1 RID: 12273
		private LuaFunction m_GetClimbTower_hotfix;

		// Token: 0x04002FF2 RID: 12274
		private LuaFunction m_SetCompleteSuccessFloorInt32_hotfix;

		// Token: 0x04002FF3 RID: 12275
		private LuaFunction m_GetGlobalClimbTowerInfo_hotfix;

		// Token: 0x04002FF4 RID: 12276
		private LuaFunction m_AttackClimbTowerLevelInt32_hotfix;

		// Token: 0x04002FF5 RID: 12277
		private LuaFunction m_CanAttackClimbTowerLevelInt32_hotfix;

		// Token: 0x04002FF6 RID: 12278
		private LuaFunction m_GetFloorInt32_hotfix;

		// Token: 0x04002FF7 RID: 12279
		private LuaFunction m_NewClimbTowerInt32_hotfix;

		// Token: 0x04002FF8 RID: 12280
		private LuaFunction m_SetCommonSuccessClimbTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoList;

		// Token: 0x04002FF9 RID: 12281
		private LuaFunction m_CanRaidLevelConfigDataTowerFloorInfo_hotfix;

		// Token: 0x04002FFA RID: 12282
		private LuaFunction m_SetRaidSuccessClimbTowerLevelConfigDataTowerFloorInfo_hotfix;

		// Token: 0x04002FFB RID: 12283
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataTowerFloorInfoBoolean_hotfix;

		// Token: 0x04002FFC RID: 12284
		private LuaFunction m_get_ClimbTowerFloorMax_hotfix;

		// Token: 0x04002FFD RID: 12285
		private LuaFunction m_set_ClimbTowerFloorMaxInt32_hotfix;

		// Token: 0x04002FFE RID: 12286
		private LuaFunction m_get_AutoClimbFactor_hotfix;

		// Token: 0x04002FFF RID: 12287
		private LuaFunction m_set_AutoClimbFactorInt32_hotfix;

		// Token: 0x04003000 RID: 12288
		private LuaFunction m_get_AutoClimbMax_hotfix;

		// Token: 0x04003001 RID: 12289
		private LuaFunction m_set_AutoClimbMaxInt32_hotfix;

		// Token: 0x04003002 RID: 12290
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003003 RID: 12291
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0200043B RID: 1083
		public class LuaExportHelper
		{
			// Token: 0x06003F7F RID: 16255 RVA: 0x00126E48 File Offset: 0x00125048
			public LuaExportHelper(ClimbTowerComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x06003F80 RID: 16256 RVA: 0x00126E58 File Offset: 0x00125058
			// (set) Token: 0x06003F81 RID: 16257 RVA: 0x00126E68 File Offset: 0x00125068
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

			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x06003F82 RID: 16258 RVA: 0x00126E78 File Offset: 0x00125078
			// (set) Token: 0x06003F83 RID: 16259 RVA: 0x00126E88 File Offset: 0x00125088
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

			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x06003F84 RID: 16260 RVA: 0x00126E98 File Offset: 0x00125098
			// (set) Token: 0x06003F85 RID: 16261 RVA: 0x00126EA8 File Offset: 0x001250A8
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

			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x06003F86 RID: 16262 RVA: 0x00126EB8 File Offset: 0x001250B8
			// (set) Token: 0x06003F87 RID: 16263 RVA: 0x00126EC8 File Offset: 0x001250C8
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

			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x06003F88 RID: 16264 RVA: 0x00126ED8 File Offset: 0x001250D8
			// (set) Token: 0x06003F89 RID: 16265 RVA: 0x00126EE8 File Offset: 0x001250E8
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

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x06003F8A RID: 16266 RVA: 0x00126EF8 File Offset: 0x001250F8
			// (set) Token: 0x06003F8B RID: 16267 RVA: 0x00126F08 File Offset: 0x00125108
			public DataSectionClimbTower m_climbTowerDS
			{
				get
				{
					return this.m_owner.m_climbTowerDS;
				}
				set
				{
					this.m_owner.m_climbTowerDS = value;
				}
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x06003F8C RID: 16268 RVA: 0x00126F18 File Offset: 0x00125118
			// (set) Token: 0x06003F8D RID: 16269 RVA: 0x00126F28 File Offset: 0x00125128
			public int ClimbTowerFloorMax
			{
				get
				{
					return this.m_owner.ClimbTowerFloorMax;
				}
				set
				{
					this.m_owner.ClimbTowerFloorMax = value;
				}
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x06003F8E RID: 16270 RVA: 0x00126F38 File Offset: 0x00125138
			// (set) Token: 0x06003F8F RID: 16271 RVA: 0x00126F48 File Offset: 0x00125148
			public int AutoClimbFactor
			{
				get
				{
					return this.m_owner.AutoClimbFactor;
				}
				set
				{
					this.m_owner.AutoClimbFactor = value;
				}
			}

			// Token: 0x1700110A RID: 4362
			// (get) Token: 0x06003F90 RID: 16272 RVA: 0x00126F58 File Offset: 0x00125158
			// (set) Token: 0x06003F91 RID: 16273 RVA: 0x00126F68 File Offset: 0x00125168
			public int AutoClimbMax
			{
				get
				{
					return this.m_owner.AutoClimbMax;
				}
				set
				{
					this.m_owner.AutoClimbMax = value;
				}
			}

			// Token: 0x06003F92 RID: 16274 RVA: 0x00126F78 File Offset: 0x00125178
			public void SetCommonSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, List<int> battleTreasures, int energyCost)
			{
				this.m_owner.SetCommonSuccessClimbTowerLevel(floorInfo, levelInfo, battleTreasures, energyCost);
			}

			// Token: 0x06003F93 RID: 16275 RVA: 0x00126F8C File Offset: 0x0012518C
			public void SetRaidSuccessClimbTowerLevel(ConfigDataTowerFloorInfo floorInfo)
			{
				this.m_owner.SetRaidSuccessClimbTowerLevel(floorInfo);
			}

			// Token: 0x06003F94 RID: 16276 RVA: 0x00126F9C File Offset: 0x0012519C
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataTowerFloorInfo floorInfo, bool checkBagFull)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(floorInfo, checkBagFull);
			}

			// Token: 0x04003004 RID: 12292
			private ClimbTowerComponentCommon m_owner;
		}
	}
}
