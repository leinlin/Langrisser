using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003A1 RID: 929
	[HotFix]
	public class BattleFormula
	{
		// Token: 0x060036C8 RID: 14024 RVA: 0x000F3154 File Offset: 0x000F1354
		public BattleFormula()
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

		// Token: 0x060036C9 RID: 14025 RVA: 0x000F31BC File Offset: 0x000F13BC
		private static Fix64 ComputePhysicalDamageValue(BattleProperty attackerProperty, BattleProperty targetProperty, ConfigDataSkillInfo skillInfo, bool isCritical, int targetTerrainBonus, int armyAttack, int armyDefend, int meleePunish)
		{
			Fix64 x = (Fix64)((long)attackerProperty.Attack) * (Fix64.One + (Fix64)((long)armyAttack) * BattleFormula.d100) - (Fix64)((long)targetProperty.Defense) * (Fix64.One - (Fix64)((long)attackerProperty.Buff_IgnoreDFMul) * BattleFormula.d10000) * (Fix64.One + (Fix64)((long)targetTerrainBonus) * BattleFormula.d100 + (Fix64)((long)armyDefend) * BattleFormula.d100);
			if (x < Fix64.Zero)
			{
				x = Fix64.Zero;
			}
			Fix64 fix = x * (Fix64.One + (Fix64)((long)skillInfo.Power) * BattleFormula.d100);
			if (skillInfo.IsRangeSkill && !skillInfo.IsBattlefieldSkill() && meleePunish != 0)
			{
				fix *= Fix64.One - (Fix64)((long)meleePunish) * BattleFormula.d100;
			}
			Fix64 fix2 = fix;
			int num = attackerProperty.Buff_PhysicalDamageMul + targetProperty.Buff_PhysicalDamageReceiveMul;
			if (num != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)num) * BattleFormula.d10000;
			}
			if (isCritical)
			{
				fix2 *= Fix64.One + (Fix64)((long)attackerProperty.CriticalDamage) * BattleFormula.d10000;
			}
			if (targetProperty.Buff_SuperPhysicalDamageReceiveMul != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)targetProperty.Buff_SuperPhysicalDamageReceiveMul) * BattleFormula.d10000;
			}
			int num2 = 0;
			if (skillInfo.IsActiveSkill)
			{
				num2 = attackerProperty.Buff_SkillDamageMul;
			}
			if (skillInfo.IsBattlefieldSkill())
			{
				num2 += attackerProperty.Buff_BFSkillDamageMul;
			}
			if (num2 != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)num2) * BattleFormula.d10000;
			}
			if (skillInfo.IsRangeSkill && targetProperty.Buff_RangeDamageReceiveMul != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)targetProperty.Buff_RangeDamageReceiveMul) * BattleFormula.d10000;
			}
			if (fix2 < Fix64.One)
			{
				fix2 = Fix64.One;
			}
			return fix2;
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x000F3424 File Offset: 0x000F1624
		private static Fix64 ComputeMagicDamageValue(BattleProperty attackerProperty, BattleProperty targetProperty, ConfigDataSkillInfo skillInfo, bool isCritical, int targetTerrainBonus, int armyMagic, int armyMagicDefend, int meleePunish, bool useAttackAsMagic)
		{
			int num = attackerProperty.Magic;
			if (useAttackAsMagic)
			{
				num = attackerProperty.Attack;
			}
			Fix64 x = (Fix64)((long)num) * (Fix64.One + (Fix64)((long)armyMagic) * BattleFormula.d100) - (Fix64)((long)targetProperty.MagicDefense) * (Fix64.One - (Fix64)((long)attackerProperty.Buff_IgnoreDFMul) * BattleFormula.d10000) * (Fix64.One + (Fix64)((long)targetTerrainBonus) * BattleFormula.d100 + (Fix64)((long)armyMagicDefend) * BattleFormula.d100);
			if (x < Fix64.Zero)
			{
				x = Fix64.Zero;
			}
			Fix64 fix = x * (Fix64.One + (Fix64)((long)skillInfo.Power) * BattleFormula.d100);
			if (skillInfo.IsRangeSkill && !skillInfo.IsBattlefieldSkill() && meleePunish != 0)
			{
				fix *= Fix64.One - (Fix64)((long)meleePunish) * BattleFormula.d100;
			}
			Fix64 fix2 = fix;
			int num2 = attackerProperty.Buff_MagicalDamageMul + targetProperty.Buff_MagicalDamageReceiveMul;
			if (num2 != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)num2) * BattleFormula.d10000;
			}
			if (isCritical)
			{
				fix2 *= Fix64.One + (Fix64)((long)attackerProperty.CriticalDamage) * BattleFormula.d10000;
			}
			if (targetProperty.Buff_SuperMagicalDamageReceiveMul != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)targetProperty.Buff_SuperMagicalDamageReceiveMul) * BattleFormula.d10000;
			}
			int num3 = 0;
			if (skillInfo.IsActiveSkill)
			{
				num3 = attackerProperty.Buff_SkillDamageMul;
			}
			if (skillInfo.IsBattlefieldSkill())
			{
				num3 += attackerProperty.Buff_BFSkillDamageMul;
			}
			if (num3 != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)num3) * BattleFormula.d10000;
			}
			if (skillInfo.IsRangeSkill && targetProperty.Buff_RangeDamageReceiveMul != 0)
			{
				fix2 *= Fix64.One + (Fix64)((long)targetProperty.Buff_RangeDamageReceiveMul) * BattleFormula.d10000;
			}
			if (fix2 < Fix64.One)
			{
				fix2 = Fix64.One;
			}
			return fix2;
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x000F36A0 File Offset: 0x000F18A0
		public static Fix64 ComputeHealFinalValue(Fix64 baseHeal, int attackerBuff_HealMul, int targetBuff_HealReceiveMul)
		{
			Fix64 fix = baseHeal * (Fix64.One + (Fix64)((long)attackerBuff_HealMul) * BattleFormula.d10000 + (Fix64)((long)targetBuff_HealReceiveMul) * BattleFormula.d10000);
			if (fix < Fix64.Zero)
			{
				fix = Fix64.Zero;
			}
			return fix;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x000F36FC File Offset: 0x000F18FC
		public static Fix64 ComputeHealValue(BattleProperty attackerProperty, BattleProperty targetProperty, int skillPower, bool isPercent, bool useAttackAsMagic)
		{
			Fix64 baseHeal;
			if (isPercent)
			{
				baseHeal = (Fix64)((long)targetProperty.HealthPointMax) * (Fix64)((long)skillPower) * BattleFormula.d100;
			}
			else
			{
				int num = attackerProperty.Magic;
				if (useAttackAsMagic)
				{
					num = attackerProperty.Attack;
				}
				baseHeal = (Fix64)((long)num) * (Fix64.One + (Fix64)((long)skillPower) * BattleFormula.d100);
			}
			return BattleFormula.ComputeHealFinalValue(baseHeal, attackerProperty.Buff_HealMul, targetProperty.Buff_HealReceiveMul);
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000F3788 File Offset: 0x000F1988
		private static Fix64 ComputeHealValue(BattleProperty attackerProperty, BattleProperty targetProperty, ConfigDataSkillInfo skillInfo)
		{
			bool isPercent = skillInfo.SkillType == SkillType.SkillType_BF_HealPercent;
			return BattleFormula.ComputeHealValue(attackerProperty, targetProperty, skillInfo.Power, isPercent, false);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x000F37B0 File Offset: 0x000F19B0
		public static int ComputeSkillHpModifyValue(BattleProperty attackerProperty, BattleProperty targetProperty, ArmyRelationData armyRelation, ConfigDataSkillInfo skillInfo, bool isCritical, bool isBuffForceMagicDamage, bool isBanMeleePunish, ConfigDataTerrainInfo targetTerrain, int gridDistance, bool isSameTeam, RandomNumber randomNumber, IConfigDataLoader configDataLoader)
		{
			Fix64 value = Fix64.Zero;
			bool flag = false;
			if (skillInfo.SkillType == SkillType.SkillType_BF_DamageHeal)
			{
				if (isSameTeam)
				{
					flag = true;
				}
			}
			else if (skillInfo.IsHealSkill() || skillInfo.IsBuffSkill())
			{
				flag = true;
			}
			if (flag)
			{
				value = BattleFormula.ComputeHealValue(attackerProperty, targetProperty, skillInfo);
			}
			else
			{
				int targetTerrainBonus = 0;
				if (targetTerrain != null)
				{
					targetTerrainBonus = targetTerrain.BattleBonus;
				}
				int meleePunish = 0;
				if (gridDistance <= 1 && !isBanMeleePunish)
				{
					meleePunish = configDataLoader.Const_MeleeATKPunish_Mult;
				}
				if (skillInfo.IsMagic)
				{
					value = -BattleFormula.ComputeMagicDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyRelation.Magic, armyRelation.MagicDefend, meleePunish, false);
				}
				else if (isBuffForceMagicDamage)
				{
					value = -BattleFormula.ComputeMagicDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyRelation.Attack, armyRelation.MagicDefend, meleePunish, true);
				}
				else
				{
					value = -BattleFormula.ComputePhysicalDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyRelation.Attack, armyRelation.Defend, meleePunish);
				}
			}
			return (int)((long)Fix64.Round(value));
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x000F38C0 File Offset: 0x000F1AC0
		public static int ComputeBuffHealValue(int value1, int value2, int applyerBuff_HealMul, int targetBuff_HealReceiveMul)
		{
			Fix64 baseHeal = (Fix64)((long)(value1 * value2)) * BattleFormula.d10000;
			Fix64 value3 = BattleFormula.ComputeHealFinalValue(baseHeal, applyerBuff_HealMul, targetBuff_HealReceiveMul);
			return (int)((long)Fix64.Round(value3));
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x000F38F8 File Offset: 0x000F1AF8
		public static int ComputeBuffDamageValue(int value1, int value2)
		{
			Fix64 value3 = (Fix64)((long)(value1 * value2)) * BattleFormula.d10000;
			return (int)((long)Fix64.Round(value3));
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x000F3928 File Offset: 0x000F1B28
		public static int ComputeBuffExchangeValue(int value1, int value2)
		{
			Fix64 value3 = (Fix64)((long)(value1 * value2)) * BattleFormula.d10000;
			return (int)((long)Fix64.Round(value3));
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x000F3958 File Offset: 0x000F1B58
		public static int ComputeHeroBattleProperty(int jobBase, int jobUp, int heroLevel, int heroStarMul, int growMul, int growAdd, int buffMul, int buffAdd, int selfMul, int selfAdd)
		{
			Fix64 x = ((Fix64)((long)jobBase) + (Fix64)((long)jobUp) * BattleFormula.d10 * (Fix64)((long)(heroLevel - 1))) * (Fix64.One + (Fix64)((long)heroStarMul) * BattleFormula.d10000) * (Fix64.One + (Fix64)((long)selfMul) * BattleFormula.d10000) + (Fix64)((long)selfAdd);
			Fix64 x2 = x * (Fix64.One + (Fix64)((long)growMul) * BattleFormula.d10000) + (Fix64)((long)growAdd);
			Fix64 value = x2 * (Fix64.One + (Fix64)((long)buffMul) * BattleFormula.d10000) + (Fix64)((long)buffAdd);
			int num = (int)((long)Fix64.Round(value));
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000F3A58 File Offset: 0x000F1C58
		public static int ComputeSoldierBattleProperty(int soldierBase, int soldierUp, int heroLevel, int heroCmdMul, int growMul, int growAdd, int buffMul, int buffAdd)
		{
			Fix64 x = (Fix64)((long)soldierBase) + (Fix64)((long)soldierUp) * BattleFormula.d10 * (Fix64)((long)(heroLevel - 1));
			Fix64 x2 = (x * (Fix64.One + (Fix64)((long)growMul) * BattleFormula.d10000) + (Fix64)((long)growAdd)) * (Fix64.One + (Fix64)((long)buffMul) * BattleFormula.d10000) + (Fix64)((long)buffAdd);
			Fix64 y = x2 * (Fix64)((long)heroCmdMul) * BattleFormula.d10000;
			Fix64 value = x2 + y;
			int num = (int)((long)Fix64.Round(value));
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000F3B2C File Offset: 0x000F1D2C
		public static int ComputeEquipmentPropertyAdd(int baseValue, int levelUpValue, int level)
		{
			Fix64 value = (Fix64)((long)baseValue) + (Fix64)((long)levelUpValue) * BattleFormula.d10 * (Fix64)((long)(level - 1));
			return (int)((long)Fix64.Round(value));
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x000F3B74 File Offset: 0x000F1D74
		public static int ComputeHeroBattlePower(ConfigDataJobInfo jobInfo, int hp, int at, int df, int magic, int magicDf, int dex, int skillBattlePower)
		{
			Fix64 fix = (Fix64)((long)(hp * jobInfo.BattlePowerHP + at * jobInfo.BattlePowerAT + df * jobInfo.BattlePowerDF + magic * jobInfo.BattlePowerMagic + magicDf * jobInfo.BattlePowerMagicDF + dex * jobInfo.BattlePowerDEX)) * BattleFormula.d10000;
			fix *= Fix64.One + (Fix64)((long)skillBattlePower) * BattleFormula.d10000;
			return (int)((long)Fix64.Round(fix));
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x000F3BFC File Offset: 0x000F1DFC
		public static int ComputeSoldierBattlePower(ConfigDataSoldierInfo soldierInfo, int hp, int at, int df, int magicDf, int skillBattlePower)
		{
			Fix64 fix = (Fix64)((long)(hp * soldierInfo.BattlePowerHP + at * soldierInfo.BattlePowerAT + df * soldierInfo.BattlePowerDF + magicDf * soldierInfo.BattlePowerMagicDF)) * BattleFormula.d10000;
			fix *= Fix64.One + (Fix64)((long)skillBattlePower) * BattleFormula.d10000;
			return (int)((long)Fix64.Round(fix));
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x000F3C70 File Offset: 0x000F1E70
		public static DamageNumberType ComputeDamangeNumberType(ConfigDataSkillInfo skillInfo, bool isCritical, ArmyRelationData armyRelation, bool isSameTeam)
		{
			DamageNumberType result = DamageNumberType.Normal;
			if (skillInfo != null)
			{
				if (skillInfo.SkillType == SkillType.SkillType_BF_DamageHeal && isSameTeam)
				{
					result = DamageNumberType.Heal;
				}
				else if (skillInfo.IsDamageSkill())
				{
					if (isCritical)
					{
						result = DamageNumberType.Critical;
					}
					else
					{
						int num = 0;
						if (skillInfo.IsPhysicalDamageSkill())
						{
							num = armyRelation.Attack - armyRelation.Defend;
						}
						else if (skillInfo.IsMagicDamageSkill())
						{
							num = armyRelation.Magic - armyRelation.MagicDefend;
						}
						if (num > 0)
						{
							result = DamageNumberType.Weak;
						}
						else if (num < 0)
						{
							result = DamageNumberType.Strong;
						}
					}
				}
				else if (skillInfo.IsHealSkill())
				{
					result = DamageNumberType.Heal;
				}
			}
			else if (isCritical)
			{
				result = DamageNumberType.Critical;
			}
			return result;
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000F3D2C File Offset: 0x000F1F2C
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x000F3D4C File Offset: 0x000F1F4C
		[DoNotToLua]
		public BattleFormula.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleFormula.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x000F3DB0 File Offset: 0x000F1FB0
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x000F3E7C File Offset: 0x000F207C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleFormula));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A1F RID: 10783
		private static Fix64 d10 = Fix64.One / (Fix64)10L;

		// Token: 0x04002A20 RID: 10784
		private static Fix64 d100 = Fix64.One / (Fix64)100L;

		// Token: 0x04002A21 RID: 10785
		private static Fix64 d10000 = Fix64.One / (Fix64)10000L;

		// Token: 0x04002A22 RID: 10786
		[DoNotToLua]
		private BattleFormula.LuaExportHelper luaExportHelper;

		// Token: 0x04002A23 RID: 10787
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A24 RID: 10788
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A25 RID: 10789
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020003A2 RID: 930
		public class LuaExportHelper
		{
			// Token: 0x060036DD RID: 14045 RVA: 0x000F3EE4 File Offset: 0x000F20E4
			public LuaExportHelper(BattleFormula owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000F21 RID: 3873
			// (get) Token: 0x060036DE RID: 14046 RVA: 0x000F3EF4 File Offset: 0x000F20F4
			// (set) Token: 0x060036DF RID: 14047 RVA: 0x000F3EFC File Offset: 0x000F20FC
			public static Fix64 d10
			{
				get
				{
					return BattleFormula.d10;
				}
				set
				{
					BattleFormula.d10 = value;
				}
			}

			// Token: 0x17000F22 RID: 3874
			// (get) Token: 0x060036E0 RID: 14048 RVA: 0x000F3F04 File Offset: 0x000F2104
			// (set) Token: 0x060036E1 RID: 14049 RVA: 0x000F3F0C File Offset: 0x000F210C
			public static Fix64 d100
			{
				get
				{
					return BattleFormula.d100;
				}
				set
				{
					BattleFormula.d100 = value;
				}
			}

			// Token: 0x17000F23 RID: 3875
			// (get) Token: 0x060036E2 RID: 14050 RVA: 0x000F3F14 File Offset: 0x000F2114
			// (set) Token: 0x060036E3 RID: 14051 RVA: 0x000F3F1C File Offset: 0x000F211C
			public static Fix64 d10000
			{
				get
				{
					return BattleFormula.d10000;
				}
				set
				{
					BattleFormula.d10000 = value;
				}
			}

			// Token: 0x060036E4 RID: 14052 RVA: 0x000F3F24 File Offset: 0x000F2124
			public static Fix64 ComputePhysicalDamageValue(BattleProperty attackerProperty, BattleProperty targetProperty, ConfigDataSkillInfo skillInfo, bool isCritical, int targetTerrainBonus, int armyAttack, int armyDefend, int meleePunish)
			{
				return BattleFormula.ComputePhysicalDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyAttack, armyDefend, meleePunish);
			}

			// Token: 0x060036E5 RID: 14053 RVA: 0x000F3F38 File Offset: 0x000F2138
			public static Fix64 ComputeMagicDamageValue(BattleProperty attackerProperty, BattleProperty targetProperty, ConfigDataSkillInfo skillInfo, bool isCritical, int targetTerrainBonus, int armyMagic, int armyMagicDefend, int meleePunish, bool useAttackAsMagic)
			{
				return BattleFormula.ComputeMagicDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyMagic, armyMagicDefend, meleePunish, useAttackAsMagic);
			}

			// Token: 0x060036E6 RID: 14054 RVA: 0x000F3F58 File Offset: 0x000F2158
			public static Fix64 ComputeHealValue(BattleProperty attackerProperty, BattleProperty targetProperty, ConfigDataSkillInfo skillInfo)
			{
				return BattleFormula.ComputeHealValue(attackerProperty, targetProperty, skillInfo);
			}

			// Token: 0x04002A26 RID: 10790
			private BattleFormula m_owner;
		}
	}
}
