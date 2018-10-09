using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003AB RID: 939
	[HotFix]
	public class BattleProperty
	{
		// Token: 0x0600371A RID: 14106 RVA: 0x000F592C File Offset: 0x000F3B2C
		public BattleProperty()
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

		// Token: 0x0600371B RID: 14107 RVA: 0x000F5994 File Offset: 0x000F3B94
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HealthPointMax = (this.Attack = (this.Defense = (this.Magic = (this.MagicDefense = (this.Dexterity = (this.CriticalRate = 0))))));
			this.Buff_PhysicalDamageMul = (this.Buff_PhysicalDamageReceiveMul = (this.Buff_HealMul = (this.Buff_HealReceiveMul = (this.Buff_MagicalDamageMul = (this.Buff_MagicalDamageReceiveMul = (this.Buff_IgnoreDFMul = 0))))));
			this.Buff_SkillDamageMul = (this.Buff_BFSkillDamageMul = (this.Buff_RangeDamageReceiveMul = (this.Buff_ReceiveCriticalRateAdd = 0)));
			this.Buff_SuperPhysicalDamageReceiveMul = (this.Buff_SuperMagicalDamageReceiveMul = 0);
			this.Cmd_HealthPoint = (this.Cmd_Attack = (this.Cmd_Defense = (this.Cmd_MagicDefense = 0)));
			this.CriticalDamage = (this.CriticalRate = 0);
			this.AttackDistance = (this.MagicSkillDistanceAdd = (this.MovePoint = 0));
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x000F5AEC File Offset: 0x000F3CEC
		public void ComputeHeroProperties(IConfigDataLoader configDataLoader, ConfigDataHeroInfo heroInfo, ConfigDataJobConnectionInfo jobConnectionInfo, int jobLevel, int heroLevel, int heroStar, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeHeroPropertiesIConfigDataLoaderConfigDataHeroInfoConfigDataJobConnectionInfoInt32Int32Int32BattlePropertyModifier_hotfix != null)
			{
				this.m_ComputeHeroPropertiesIConfigDataLoaderConfigDataHeroInfoConfigDataJobConnectionInfoInt32Int32Int32BattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					configDataLoader,
					heroInfo,
					jobConnectionInfo,
					jobLevel,
					heroLevel,
					heroStar,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int growMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_HPMul);
			int growAdd = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_HPAdd);
			int buffMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HPMul);
			int buffAdd = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HPAdd);
			int selfMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_HPMul);
			int selfAdd = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_HPAdd);
			int growMul2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_ATMul);
			int growAdd2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_ATAdd);
			int buffMul2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_ATMul);
			int buffAdd2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_ATAdd);
			int selfMul2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_ATMul);
			int selfAdd2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_ATAdd);
			int growMul3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_DFMul);
			int growAdd3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_DFAdd);
			int buffMul3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_DFMul);
			int buffAdd3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_DFAdd);
			int selfMul3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_DFMul);
			int selfAdd3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_DFAdd);
			int growMul4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_MagicMul);
			int growAdd4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_MagicAdd);
			int buffMul4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicMul);
			int buffAdd4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicAdd);
			int selfMul4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_MagicMul);
			int selfAdd4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_MagicAdd);
			int growMul5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_MagicDFMul);
			int growAdd5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd);
			int buffMul5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDFMul);
			int buffAdd5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDFAdd);
			int selfMul5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_MagicDFMul);
			int selfAdd5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_MagicDFAdd);
			int growMul6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_DEXMul);
			int growAdd6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_DEXAdd);
			int buffMul6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_DEXMul);
			int buffAdd6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_DEXAdd);
			int selfMul6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_DEXMul);
			int selfAdd6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_DEXAdd);
			int heroStarMul = 0;
			int heroStarMul2 = 0;
			int heroStarMul3 = 0;
			int heroStarMul4 = 0;
			int heroStarMul5 = 0;
			int heroStarMul6 = 0;
			if (heroStar > 0)
			{
				int index = heroStar - 1;
				heroStarMul = heroInfo.HPStar[index];
				heroStarMul2 = heroInfo.ATStar[index];
				heroStarMul3 = heroInfo.DFStar[index];
				heroStarMul4 = heroInfo.MagicStar[index];
				heroStarMul5 = heroInfo.MagicDFStar[index];
				heroStarMul6 = heroInfo.DEXStar[index];
			}
			ConfigDataJobLevelInfo configDataJobLevelInfo = jobConnectionInfo.m_jobLevelInfos[jobLevel];
			this.HealthPointMax = BattleFormula.ComputeHeroBattleProperty(configDataJobLevelInfo.HP_INI, configDataJobLevelInfo.HP_UP, heroLevel, heroStarMul, growMul, growAdd, buffMul, buffAdd, selfMul, selfAdd);
			this.Attack = BattleFormula.ComputeHeroBattleProperty(configDataJobLevelInfo.AT_INI, configDataJobLevelInfo.AT_UP, heroLevel, heroStarMul2, growMul2, growAdd2, buffMul2, buffAdd2, selfMul2, selfAdd2);
			this.Defense = BattleFormula.ComputeHeroBattleProperty(configDataJobLevelInfo.DF_INI, configDataJobLevelInfo.DF_UP, heroLevel, heroStarMul3, growMul3, growAdd3, buffMul3, buffAdd3, selfMul3, selfAdd3);
			this.Magic = BattleFormula.ComputeHeroBattleProperty(configDataJobLevelInfo.Magic_INI, configDataJobLevelInfo.Magic_UP, heroLevel, heroStarMul4, growMul4, growAdd4, buffMul4, buffAdd4, selfMul4, selfAdd4);
			this.MagicDefense = BattleFormula.ComputeHeroBattleProperty(configDataJobLevelInfo.MagicDF_INI, configDataJobLevelInfo.MagicDF_UP, heroLevel, heroStarMul5, growMul5, growAdd5, buffMul5, buffAdd5, selfMul5, selfAdd5);
			this.Dexterity = BattleFormula.ComputeHeroBattleProperty(configDataJobLevelInfo.DEX_INI, configDataJobLevelInfo.DEX_UP, heroLevel, heroStarMul6, growMul6, growAdd6, buffMul6, buffAdd6, selfMul6, selfAdd6);
			this.Buff_PhysicalDamageMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_PsyDmgMul);
			this.Buff_PhysicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_PsyDmgRecvMul);
			this.Buff_SuperPhysicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_SuperPsyDmgRecvMul);
			this.Buff_HealMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HealMul);
			this.Buff_HealReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HealRecvMul);
			this.Buff_MagicalDamageMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDmgMul);
			this.Buff_MagicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDmgRecvMul);
			this.Buff_SuperMagicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_SuperMagicDmgRecvMul);
			this.Buff_IgnoreDFMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_IgnoreDFMul);
			if (this.Buff_IgnoreDFMul > 10000)
			{
				this.Buff_IgnoreDFMul = 10000;
			}
			this.Buff_SkillDamageMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_SkillDmgMul);
			this.Buff_BFSkillDamageMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_BFSkillDmgMul);
			this.Buff_RangeDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_RangeDmgRecvMul);
			this.Buff_ReceiveCriticalRateAdd = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_RecvCriticalRateAdd);
			int const_CriticalDamageBase = configDataLoader.Const_CriticalDamageBase;
			int num = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_CriticalDamageAdd);
			int num2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_CriticalDamageAdd);
			int num3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_CriticalDamageAdd);
			this.CriticalDamage = const_CriticalDamageBase + (num + num2 + num3);
			int num4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_CriticalRateAdd);
			int num5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_CriticalRateAdd);
			int num6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_CriticalRateAdd);
			this.CriticalRate = this.Dexterity * 10 + (num4 + num5 + num6);
			if (this.CriticalRate > 10000)
			{
				this.CriticalRate = 10000;
			}
			int num7 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_HPCmdAdd);
			int num8 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HPCmdAdd);
			int num9 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_HPCmdAdd);
			int num10 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_ATCmdAdd);
			int num11 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_ATCmdAdd);
			int num12 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_ATCmdAdd);
			int num13 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_DFCmdAdd);
			int num14 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_DFCmdAdd);
			int num15 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_DFCmdAdd);
			int num16 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_MagicDFCmdAdd);
			int num17 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDFCmdAdd);
			int num18 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_MagicDFCmdAdd);
			this.Cmd_HealthPoint = heroInfo.HPCmd_INI + num7 + num8 + num9;
			this.Cmd_Attack = heroInfo.ATCmd_INI + num10 + num11 + num12;
			this.Cmd_Defense = heroInfo.DFCmd_INI + num13 + num14 + num15;
			this.Cmd_MagicDefense = heroInfo.MagicDFCmd_INI + num16 + num17 + num18;
			int num19 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_BFAttackDistanceAdd);
			int num20 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_BFAttackDistanceAdd);
			this.AttackDistance = jobConnectionInfo.m_jobInfo.BF_AttackDistance + num19 + num20;
			this.AttackDistance = BattleProperty.ClampNegativeValue(this.AttackDistance);
			this.MagicSkillDistanceAdd = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDistanceAdd);
			this.PhysicalSkillDistanceAdd = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_PsyDistanceAdd);
			int num21 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_BFMovePointAdd);
			int num22 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_BFMovePointAdd);
			this.MovePoint = jobConnectionInfo.m_jobInfo.BF_MovePoint + num21 + num22;
			this.MovePoint = BattleProperty.ClampNegativeValue(this.MovePoint);
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x000F6194 File Offset: 0x000F4394
		private static int ClampNegativeValue(int value)
		{
			if (value < 0)
			{
				return 0;
			}
			return value;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x000F61A0 File Offset: 0x000F43A0
		public void ApplyExchangeProperty(BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ApplyExchangePropertyBattlePropertyModifier_hotfix != null)
			{
				this.m_ApplyExchangePropertyBattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Attack += pm.ExchangeAttack;
			this.Defense += pm.ExchangeDefense;
			this.Magic += pm.ExchangeMagic;
			this.MagicDefense += pm.ExchangeMagicDefense;
			this.Dexterity += pm.ExchangeDexterity;
			this.HealthPointMax += pm.ExchangeHealthPointMax;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x000F6284 File Offset: 0x000F4484
		public void ComputeSoldierProperties(IConfigDataLoader configDataLoader, ConfigDataSoldierInfo soldierInfo, ConfigDataHeroInfo heroInfo, int heroLevel, BattlePropertyModifier pm)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierPropertiesIConfigDataLoaderConfigDataSoldierInfoConfigDataHeroInfoInt32BattlePropertyModifier_hotfix != null)
			{
				this.m_ComputeSoldierPropertiesIConfigDataLoaderConfigDataSoldierInfoConfigDataHeroInfoInt32BattlePropertyModifier_hotfix.call(new object[]
				{
					this,
					configDataLoader,
					soldierInfo,
					heroInfo,
					heroLevel,
					pm
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int growMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_HPMul);
			int growAdd = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_HPAdd);
			int buffMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_HPMul);
			int buffAdd = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_HPAdd);
			int growMul2 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_ATMul);
			int growAdd2 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_ATAdd);
			int buffMul2 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_ATMul);
			int buffAdd2 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_ATAdd);
			int growMul3 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_DFMul);
			int growAdd3 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_DFAdd);
			int buffMul3 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_DFMul);
			int buffAdd3 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_DFAdd);
			int growMul4 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_MagicDFMul);
			int growAdd4 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_MagicDFAdd);
			int buffMul4 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_MagicDFMul);
			int buffAdd4 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_MagicDFAdd);
			if (heroInfo != null)
			{
				int num = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_HPCmdAdd);
				int num2 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HPCmdAdd);
				int num3 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_HPCmdAdd);
				int num4 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_ATCmdAdd);
				int num5 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_ATCmdAdd);
				int num6 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_ATCmdAdd);
				int num7 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_DFCmdAdd);
				int num8 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_DFCmdAdd);
				int num9 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_DFCmdAdd);
				int num10 = pm.Get(PropertyModifyType.PropertyModifyType_Hero1_MagicDFCmdAdd);
				int num11 = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_MagicDFCmdAdd);
				int num12 = pm.Get(PropertyModifyType.PropertyModifyType_Hero3_MagicDFCmdAdd);
				this.Cmd_HealthPoint = heroInfo.HPCmd_INI + num + num2 + num3;
				this.Cmd_Attack = heroInfo.ATCmd_INI + num4 + num5 + num6;
				this.Cmd_Defense = heroInfo.DFCmd_INI + num7 + num8 + num9;
				this.Cmd_MagicDefense = heroInfo.MagicDFCmd_INI + num10 + num11 + num12;
			}
			else
			{
				this.Cmd_HealthPoint = 0;
				this.Cmd_Attack = 0;
				this.Cmd_Defense = 0;
				this.Cmd_MagicDefense = 0;
			}
			this.HealthPointMax = BattleFormula.ComputeSoldierBattleProperty(soldierInfo.HP_INI, soldierInfo.HP_UP, heroLevel, this.Cmd_HealthPoint, growMul, growAdd, buffMul, buffAdd);
			this.Attack = BattleFormula.ComputeSoldierBattleProperty(soldierInfo.AT_INI, soldierInfo.AT_UP, heroLevel, this.Cmd_Attack, growMul2, growAdd2, buffMul2, buffAdd2);
			this.Defense = BattleFormula.ComputeSoldierBattleProperty(soldierInfo.DF_INI, soldierInfo.DF_UP, heroLevel, this.Cmd_Defense, growMul3, growAdd3, buffMul3, buffAdd3);
			this.Magic = 0;
			this.MagicDefense = BattleFormula.ComputeSoldierBattleProperty(soldierInfo.MagicDF_INI, soldierInfo.MagicDF_UP, heroLevel, this.Cmd_MagicDefense, growMul4, growAdd4, buffMul4, buffAdd4);
			this.Dexterity = 0;
			this.Buff_PhysicalDamageMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_PsyDmgMul);
			this.Buff_PhysicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_PsyDmgRecvMul);
			this.Buff_SuperPhysicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_SuperPsyDmgRecvMul);
			this.Buff_HealMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HealMul);
			this.Buff_HealReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Hero2_HealRecvMul);
			this.Buff_MagicalDamageMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_MagicDmgMul);
			this.Buff_MagicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_MagicDmgRecvMul);
			this.Buff_SuperMagicalDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_SuperMagicDmgRecvMul);
			this.Buff_IgnoreDFMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_IgnoreDFMul);
			if (this.Buff_IgnoreDFMul > 10000)
			{
				this.Buff_IgnoreDFMul = 10000;
			}
			this.Buff_SkillDamageMul = 0;
			this.Buff_BFSkillDamageMul = 0;
			this.Buff_RangeDamageReceiveMul = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_RangeDmgRecvMul);
			this.Buff_ReceiveCriticalRateAdd = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_RecvCriticalRateAdd);
			int num13 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_CriticalDamageAdd);
			int num14 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_CriticalDamageAdd);
			this.CriticalDamage = soldierInfo.CriticalDamage + num13 + num14;
			int num15 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_CriticalRateAdd);
			int num16 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_CriticalRateAdd);
			this.CriticalRate = soldierInfo.CriticalRate + num15 + num16;
			if (this.CriticalRate > 10000)
			{
				this.CriticalRate = 10000;
			}
			int num17 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_BFAttackDistanceAdd);
			int num18 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_BFAttackDistanceAdd);
			this.AttackDistance = soldierInfo.BF_AttackDistance + num17 + num18;
			this.AttackDistance = BattleProperty.ClampNegativeValue(this.AttackDistance);
			int num19 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier1_BFMovePointAdd);
			int num20 = pm.Get(PropertyModifyType.PropertyModifyType_Soldier2_BFMovePointAdd);
			this.MovePoint = soldierInfo.BF_MovePoint + num19 + num20;
			this.MovePoint = BattleProperty.ClampNegativeValue(this.MovePoint);
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x000F6730 File Offset: 0x000F4930
		// (set) Token: 0x06003721 RID: 14113 RVA: 0x000F6750 File Offset: 0x000F4950
		[DoNotToLua]
		public BattleProperty.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleProperty.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x000F675C File Offset: 0x000F495C
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_ComputeHeroPropertiesIConfigDataLoaderConfigDataHeroInfoConfigDataJobConnectionInfoInt32Int32Int32BattlePropertyModifier_hotfix = (luaObj.RawGet("ComputeHeroProperties") as LuaFunction);
					this.m_ApplyExchangePropertyBattlePropertyModifier_hotfix = (luaObj.RawGet("ApplyExchangeProperty") as LuaFunction);
					this.m_ComputeSoldierPropertiesIConfigDataLoaderConfigDataSoldierInfoConfigDataHeroInfoInt32BattlePropertyModifier_hotfix = (luaObj.RawGet("ComputeSoldierProperties") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x000F688C File Offset: 0x000F4A8C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleProperty));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A5F RID: 10847
		public int HealthPointMax;

		// Token: 0x04002A60 RID: 10848
		public int Attack;

		// Token: 0x04002A61 RID: 10849
		public int Defense;

		// Token: 0x04002A62 RID: 10850
		public int Magic;

		// Token: 0x04002A63 RID: 10851
		public int MagicDefense;

		// Token: 0x04002A64 RID: 10852
		public int Dexterity;

		// Token: 0x04002A65 RID: 10853
		public int Buff_PhysicalDamageMul;

		// Token: 0x04002A66 RID: 10854
		public int Buff_PhysicalDamageReceiveMul;

		// Token: 0x04002A67 RID: 10855
		public int Buff_SuperPhysicalDamageReceiveMul;

		// Token: 0x04002A68 RID: 10856
		public int Buff_HealMul;

		// Token: 0x04002A69 RID: 10857
		public int Buff_HealReceiveMul;

		// Token: 0x04002A6A RID: 10858
		public int Buff_MagicalDamageMul;

		// Token: 0x04002A6B RID: 10859
		public int Buff_MagicalDamageReceiveMul;

		// Token: 0x04002A6C RID: 10860
		public int Buff_SuperMagicalDamageReceiveMul;

		// Token: 0x04002A6D RID: 10861
		public int Buff_IgnoreDFMul;

		// Token: 0x04002A6E RID: 10862
		public int Buff_SkillDamageMul;

		// Token: 0x04002A6F RID: 10863
		public int Buff_BFSkillDamageMul;

		// Token: 0x04002A70 RID: 10864
		public int Buff_RangeDamageReceiveMul;

		// Token: 0x04002A71 RID: 10865
		public int Buff_ReceiveCriticalRateAdd;

		// Token: 0x04002A72 RID: 10866
		public int Cmd_HealthPoint;

		// Token: 0x04002A73 RID: 10867
		public int Cmd_Attack;

		// Token: 0x04002A74 RID: 10868
		public int Cmd_Defense;

		// Token: 0x04002A75 RID: 10869
		public int Cmd_MagicDefense;

		// Token: 0x04002A76 RID: 10870
		public int CriticalDamage;

		// Token: 0x04002A77 RID: 10871
		public int CriticalRate;

		// Token: 0x04002A78 RID: 10872
		public int AttackDistance;

		// Token: 0x04002A79 RID: 10873
		public int MagicSkillDistanceAdd;

		// Token: 0x04002A7A RID: 10874
		public int PhysicalSkillDistanceAdd;

		// Token: 0x04002A7B RID: 10875
		public int MovePoint;

		// Token: 0x04002A7C RID: 10876
		[DoNotToLua]
		private BattleProperty.LuaExportHelper luaExportHelper;

		// Token: 0x04002A7D RID: 10877
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A7E RID: 10878
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A7F RID: 10879
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002A80 RID: 10880
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04002A81 RID: 10881
		private LuaFunction m_ComputeHeroPropertiesIConfigDataLoaderConfigDataHeroInfoConfigDataJobConnectionInfoInt32Int32Int32BattlePropertyModifier_hotfix;

		// Token: 0x04002A82 RID: 10882
		private LuaFunction m_ApplyExchangePropertyBattlePropertyModifier_hotfix;

		// Token: 0x04002A83 RID: 10883
		private LuaFunction m_ComputeSoldierPropertiesIConfigDataLoaderConfigDataSoldierInfoConfigDataHeroInfoInt32BattlePropertyModifier_hotfix;

		// Token: 0x020003AC RID: 940
		public class LuaExportHelper
		{
			// Token: 0x06003724 RID: 14116 RVA: 0x000F68F4 File Offset: 0x000F4AF4
			public LuaExportHelper(BattleProperty owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003725 RID: 14117 RVA: 0x000F6904 File Offset: 0x000F4B04
			public static int ClampNegativeValue(int value)
			{
				return BattleProperty.ClampNegativeValue(value);
			}

			// Token: 0x04002A84 RID: 10884
			private BattleProperty m_owner;
		}
	}
}
