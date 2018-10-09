using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001195 RID: 4501
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleFormula : LuaObject
{
	// Token: 0x060173BF RID: 95167 RVA: 0x0064C9C8 File Offset: 0x0064ABC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleFormula o = new BattleFormula();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C0 RID: 95168 RVA: 0x0064CA10 File Offset: 0x0064AC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeHealFinalValue_s(IntPtr l)
	{
		int result;
		try
		{
			Fix64 baseHeal;
			LuaObject.checkValueType<Fix64>(l, 1, out baseHeal);
			int attackerBuff_HealMul;
			LuaObject.checkType(l, 2, out attackerBuff_HealMul);
			int targetBuff_HealReceiveMul;
			LuaObject.checkType(l, 3, out targetBuff_HealReceiveMul);
			Fix64 fix = BattleFormula.ComputeHealFinalValue(baseHeal, attackerBuff_HealMul, targetBuff_HealReceiveMul);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C1 RID: 95169 RVA: 0x0064CA84 File Offset: 0x0064AC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeHealValue_s(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty attackerProperty;
			LuaObject.checkType<BattleProperty>(l, 1, out attackerProperty);
			BattleProperty targetProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out targetProperty);
			int skillPower;
			LuaObject.checkType(l, 3, out skillPower);
			bool isPercent;
			LuaObject.checkType(l, 4, out isPercent);
			bool useAttackAsMagic;
			LuaObject.checkType(l, 5, out useAttackAsMagic);
			Fix64 fix = BattleFormula.ComputeHealValue(attackerProperty, targetProperty, skillPower, isPercent, useAttackAsMagic);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C2 RID: 95170 RVA: 0x0064CB10 File Offset: 0x0064AD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSkillHpModifyValue_s(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty attackerProperty;
			LuaObject.checkType<BattleProperty>(l, 1, out attackerProperty);
			BattleProperty targetProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out targetProperty);
			ArmyRelationData armyRelation;
			LuaObject.checkValueType<ArmyRelationData>(l, 3, out armyRelation);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 4, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 5, out isCritical);
			bool isBuffForceMagicDamage;
			LuaObject.checkType(l, 6, out isBuffForceMagicDamage);
			bool isBanMeleePunish;
			LuaObject.checkType(l, 7, out isBanMeleePunish);
			ConfigDataTerrainInfo targetTerrain;
			LuaObject.checkType<ConfigDataTerrainInfo>(l, 8, out targetTerrain);
			int gridDistance;
			LuaObject.checkType(l, 9, out gridDistance);
			bool isSameTeam;
			LuaObject.checkType(l, 10, out isSameTeam);
			RandomNumber randomNumber;
			LuaObject.checkType<RandomNumber>(l, 11, out randomNumber);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 12, out configDataLoader);
			int i = BattleFormula.ComputeSkillHpModifyValue(attackerProperty, targetProperty, armyRelation, skillInfo, isCritical, isBuffForceMagicDamage, isBanMeleePunish, targetTerrain, gridDistance, isSameTeam, randomNumber, configDataLoader);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C3 RID: 95171 RVA: 0x0064CBF0 File Offset: 0x0064ADF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBuffHealValue_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int value2;
			LuaObject.checkType(l, 2, out value2);
			int applyerBuff_HealMul;
			LuaObject.checkType(l, 3, out applyerBuff_HealMul);
			int targetBuff_HealReceiveMul;
			LuaObject.checkType(l, 4, out targetBuff_HealReceiveMul);
			int i = BattleFormula.ComputeBuffHealValue(value, value2, applyerBuff_HealMul, targetBuff_HealReceiveMul);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C4 RID: 95172 RVA: 0x0064CC6C File Offset: 0x0064AE6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeBuffDamageValue_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int value2;
			LuaObject.checkType(l, 2, out value2);
			int i = BattleFormula.ComputeBuffDamageValue(value, value2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C5 RID: 95173 RVA: 0x0064CCCC File Offset: 0x0064AECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBuffExchangeValue_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int value2;
			LuaObject.checkType(l, 2, out value2);
			int i = BattleFormula.ComputeBuffExchangeValue(value, value2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C6 RID: 95174 RVA: 0x0064CD2C File Offset: 0x0064AF2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeHeroBattleProperty_s(IntPtr l)
	{
		int result;
		try
		{
			int jobBase;
			LuaObject.checkType(l, 1, out jobBase);
			int jobUp;
			LuaObject.checkType(l, 2, out jobUp);
			int heroLevel;
			LuaObject.checkType(l, 3, out heroLevel);
			int heroStarMul;
			LuaObject.checkType(l, 4, out heroStarMul);
			int growMul;
			LuaObject.checkType(l, 5, out growMul);
			int growAdd;
			LuaObject.checkType(l, 6, out growAdd);
			int buffMul;
			LuaObject.checkType(l, 7, out buffMul);
			int buffAdd;
			LuaObject.checkType(l, 8, out buffAdd);
			int selfMul;
			LuaObject.checkType(l, 9, out selfMul);
			int selfAdd;
			LuaObject.checkType(l, 10, out selfAdd);
			int i = BattleFormula.ComputeHeroBattleProperty(jobBase, jobUp, heroLevel, heroStarMul, growMul, growAdd, buffMul, buffAdd, selfMul, selfAdd);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C7 RID: 95175 RVA: 0x0064CDF0 File Offset: 0x0064AFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierBattleProperty_s(IntPtr l)
	{
		int result;
		try
		{
			int soldierBase;
			LuaObject.checkType(l, 1, out soldierBase);
			int soldierUp;
			LuaObject.checkType(l, 2, out soldierUp);
			int heroLevel;
			LuaObject.checkType(l, 3, out heroLevel);
			int heroCmdMul;
			LuaObject.checkType(l, 4, out heroCmdMul);
			int growMul;
			LuaObject.checkType(l, 5, out growMul);
			int growAdd;
			LuaObject.checkType(l, 6, out growAdd);
			int buffMul;
			LuaObject.checkType(l, 7, out buffMul);
			int buffAdd;
			LuaObject.checkType(l, 8, out buffAdd);
			int i = BattleFormula.ComputeSoldierBattleProperty(soldierBase, soldierUp, heroLevel, heroCmdMul, growMul, growAdd, buffMul, buffAdd);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C8 RID: 95176 RVA: 0x0064CE9C File Offset: 0x0064B09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeEquipmentPropertyAdd_s(IntPtr l)
	{
		int result;
		try
		{
			int baseValue;
			LuaObject.checkType(l, 1, out baseValue);
			int levelUpValue;
			LuaObject.checkType(l, 2, out levelUpValue);
			int level;
			LuaObject.checkType(l, 3, out level);
			int i = BattleFormula.ComputeEquipmentPropertyAdd(baseValue, levelUpValue, level);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173C9 RID: 95177 RVA: 0x0064CF0C File Offset: 0x0064B10C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeHeroBattlePower_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo jobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 1, out jobInfo);
			int hp;
			LuaObject.checkType(l, 2, out hp);
			int at;
			LuaObject.checkType(l, 3, out at);
			int df;
			LuaObject.checkType(l, 4, out df);
			int magic;
			LuaObject.checkType(l, 5, out magic);
			int magicDf;
			LuaObject.checkType(l, 6, out magicDf);
			int dex;
			LuaObject.checkType(l, 7, out dex);
			int skillBattlePower;
			LuaObject.checkType(l, 8, out skillBattlePower);
			int i = BattleFormula.ComputeHeroBattlePower(jobInfo, hp, at, df, magic, magicDf, dex, skillBattlePower);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173CA RID: 95178 RVA: 0x0064CFB8 File Offset: 0x0064B1B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeSoldierBattlePower_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 1, out soldierInfo);
			int hp;
			LuaObject.checkType(l, 2, out hp);
			int at;
			LuaObject.checkType(l, 3, out at);
			int df;
			LuaObject.checkType(l, 4, out df);
			int magicDf;
			LuaObject.checkType(l, 5, out magicDf);
			int skillBattlePower;
			LuaObject.checkType(l, 6, out skillBattlePower);
			int i = BattleFormula.ComputeSoldierBattlePower(soldierInfo, hp, at, df, magicDf, skillBattlePower);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173CB RID: 95179 RVA: 0x0064D04C File Offset: 0x0064B24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeDamangeNumberType_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 1, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 2, out isCritical);
			ArmyRelationData armyRelation;
			LuaObject.checkValueType<ArmyRelationData>(l, 3, out armyRelation);
			bool isSameTeam;
			LuaObject.checkType(l, 4, out isSameTeam);
			DamageNumberType e = BattleFormula.ComputeDamangeNumberType(skillInfo, isCritical, armyRelation, isSameTeam);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060173CC RID: 95180 RVA: 0x0064D0C8 File Offset: 0x0064B2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputePhysicalDamageValue_s(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty attackerProperty;
			LuaObject.checkType<BattleProperty>(l, 1, out attackerProperty);
			BattleProperty targetProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out targetProperty);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 4, out isCritical);
			int targetTerrainBonus;
			LuaObject.checkType(l, 5, out targetTerrainBonus);
			int armyAttack;
			LuaObject.checkType(l, 6, out armyAttack);
			int armyDefend;
			LuaObject.checkType(l, 7, out armyDefend);
			int meleePunish;
			LuaObject.checkType(l, 8, out meleePunish);
			Fix64 fix = BattleFormula.LuaExportHelper.ComputePhysicalDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyAttack, armyDefend, meleePunish);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173CD RID: 95181 RVA: 0x0064D178 File Offset: 0x0064B378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeMagicDamageValue_s(IntPtr l)
	{
		int result;
		try
		{
			BattleProperty attackerProperty;
			LuaObject.checkType<BattleProperty>(l, 1, out attackerProperty);
			BattleProperty targetProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out targetProperty);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 4, out isCritical);
			int targetTerrainBonus;
			LuaObject.checkType(l, 5, out targetTerrainBonus);
			int armyMagic;
			LuaObject.checkType(l, 6, out armyMagic);
			int armyMagicDefend;
			LuaObject.checkType(l, 7, out armyMagicDefend);
			int meleePunish;
			LuaObject.checkType(l, 8, out meleePunish);
			bool useAttackAsMagic;
			LuaObject.checkType(l, 9, out useAttackAsMagic);
			Fix64 fix = BattleFormula.LuaExportHelper.ComputeMagicDamageValue(attackerProperty, targetProperty, skillInfo, isCritical, targetTerrainBonus, armyMagic, armyMagicDefend, meleePunish, useAttackAsMagic);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173CE RID: 95182 RVA: 0x0064D234 File Offset: 0x0064B434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_d10(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleFormula.LuaExportHelper.d10);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173CF RID: 95183 RVA: 0x0064D280 File Offset: 0x0064B480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_d10(IntPtr l)
	{
		int result;
		try
		{
			Fix64 d;
			LuaObject.checkValueType<Fix64>(l, 2, out d);
			BattleFormula.LuaExportHelper.d10 = d;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D0 RID: 95184 RVA: 0x0064D2CC File Offset: 0x0064B4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_d100(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleFormula.LuaExportHelper.d100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D1 RID: 95185 RVA: 0x0064D318 File Offset: 0x0064B518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_d100(IntPtr l)
	{
		int result;
		try
		{
			Fix64 d;
			LuaObject.checkValueType<Fix64>(l, 2, out d);
			BattleFormula.LuaExportHelper.d100 = d;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D2 RID: 95186 RVA: 0x0064D364 File Offset: 0x0064B564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_d10000(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleFormula.LuaExportHelper.d10000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D3 RID: 95187 RVA: 0x0064D3B0 File Offset: 0x0064B5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_d10000(IntPtr l)
	{
		int result;
		try
		{
			Fix64 d;
			LuaObject.checkValueType<Fix64>(l, 2, out d);
			BattleFormula.LuaExportHelper.d10000 = d;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060173D4 RID: 95188 RVA: 0x0064D3FC File Offset: 0x0064B5FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleFormula");
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeHealFinalValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeHealValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeSkillHpModifyValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeBuffHealValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeBuffDamageValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeBuffExchangeValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeHeroBattleProperty_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeSoldierBattleProperty_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeEquipmentPropertyAdd_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeHeroBattlePower_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeSoldierBattlePower_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeDamangeNumberType_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputePhysicalDamageValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.ComputeMagicDamageValue_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheD);
		string name = "d10";
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.get_d10);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.set_d10);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cacheF, false);
		string name2 = "d100";
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.get_d100);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.set_d100);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache11, false);
		string name3 = "d10000";
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.get_d10000);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.set_d10000);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache13, false);
		if (Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleFormula.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleFormula.<>f__mg$cache14, typeof(BattleFormula));
	}

	// Token: 0x0400DA77 RID: 55927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DA78 RID: 55928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DA79 RID: 55929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DA7A RID: 55930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DA7B RID: 55931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DA7C RID: 55932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DA7D RID: 55933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DA7E RID: 55934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DA7F RID: 55935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DA80 RID: 55936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DA81 RID: 55937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DA82 RID: 55938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DA83 RID: 55939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DA84 RID: 55940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DA85 RID: 55941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DA86 RID: 55942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DA87 RID: 55943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DA88 RID: 55944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DA89 RID: 55945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DA8A RID: 55946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DA8B RID: 55947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
