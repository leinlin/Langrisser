using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001162 RID: 4450
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo : LuaObject
{
	// Token: 0x06016B54 RID: 93012 RVA: 0x0060D4D4 File Offset: 0x0060B6D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo o = new ConfigDataModelSkinResourceInfo();
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

	// Token: 0x06016B55 RID: 93013 RVA: 0x0060D51C File Offset: 0x0060B71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_meleeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.m_meleeSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B56 RID: 93014 RVA: 0x0060D570 File Offset: 0x0060B770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_meleeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo meleeSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out meleeSkillInfo);
			configDataModelSkinResourceInfo.m_meleeSkillInfo = meleeSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B57 RID: 93015 RVA: 0x0060D5C8 File Offset: 0x0060B7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rangeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.m_rangeSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B58 RID: 93016 RVA: 0x0060D61C File Offset: 0x0060B81C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rangeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo rangeSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out rangeSkillInfo);
			configDataModelSkinResourceInfo.m_rangeSkillInfo = rangeSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B59 RID: 93017 RVA: 0x0060D674 File Offset: 0x0060B874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.m_skinSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B5A RID: 93018 RVA: 0x0060D6C8 File Offset: 0x0060B8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skinSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skinSkillInfo);
			configDataModelSkinResourceInfo.m_skinSkillInfo = skinSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B5B RID: 93019 RVA: 0x0060D720 File Offset: 0x0060B920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B5C RID: 93020 RVA: 0x0060D774 File Offset: 0x0060B974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataModelSkinResourceInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B5D RID: 93021 RVA: 0x0060D7CC File Offset: 0x0060B9CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B5E RID: 93022 RVA: 0x0060D820 File Offset: 0x0060BA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataModelSkinResourceInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B5F RID: 93023 RVA: 0x0060D878 File Offset: 0x0060BA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B60 RID: 93024 RVA: 0x0060D8CC File Offset: 0x0060BACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataModelSkinResourceInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B61 RID: 93025 RVA: 0x0060D924 File Offset: 0x0060BB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatModel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.CombatModel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B62 RID: 93026 RVA: 0x0060D978 File Offset: 0x0060BB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CombatModel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			string combatModel;
			LuaObject.checkType(l, 2, out combatModel);
			configDataModelSkinResourceInfo.CombatModel = combatModel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B63 RID: 93027 RVA: 0x0060D9D0 File Offset: 0x0060BBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MeleeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.MeleeATK_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B64 RID: 93028 RVA: 0x0060DA24 File Offset: 0x0060BC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MeleeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			int meleeATK_ID;
			LuaObject.checkType(l, 2, out meleeATK_ID);
			configDataModelSkinResourceInfo.MeleeATK_ID = meleeATK_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B65 RID: 93029 RVA: 0x0060DA7C File Offset: 0x0060BC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RangeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.RangeATK_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B66 RID: 93030 RVA: 0x0060DAD0 File Offset: 0x0060BCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RangeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			int rangeATK_ID;
			LuaObject.checkType(l, 2, out rangeATK_ID);
			configDataModelSkinResourceInfo.RangeATK_ID = rangeATK_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B67 RID: 93031 RVA: 0x0060DB28 File Offset: 0x0060BD28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Skill_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataModelSkinResourceInfo.Skill_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B68 RID: 93032 RVA: 0x0060DB7C File Offset: 0x0060BD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Skill_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = (ConfigDataModelSkinResourceInfo)LuaObject.checkSelf(l);
			int skill_ID;
			LuaObject.checkType(l, 2, out skill_ID);
			configDataModelSkinResourceInfo.Skill_ID = skill_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016B69 RID: 93033 RVA: 0x0060DBD4 File Offset: 0x0060BDD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataModelSkinResourceInfo");
		string name = "m_meleeSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_m_meleeSkillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_m_meleeSkillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache1, true);
		string name2 = "m_rangeSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_m_rangeSkillInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_m_rangeSkillInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache3, true);
		string name3 = "m_skinSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_m_skinSkillInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_m_skinSkillInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache9, true);
		string name6 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_Model);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_Model);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheB, true);
		string name7 = "CombatModel";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_CombatModel);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_CombatModel);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheD, true);
		string name8 = "MeleeATK_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_MeleeATK_ID);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_MeleeATK_ID);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cacheF, true);
		string name9 = "RangeATK_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_RangeATK_ID);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_RangeATK_ID);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache11, true);
		string name10 = "Skill_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.get_Skill_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.set_Skill_ID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache13, true);
		if (Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.<>f__mg$cache14, typeof(ConfigDataModelSkinResourceInfo));
	}

	// Token: 0x0400D272 RID: 53874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D273 RID: 53875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D274 RID: 53876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D275 RID: 53877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D276 RID: 53878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D277 RID: 53879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D278 RID: 53880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D279 RID: 53881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D27A RID: 53882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D27B RID: 53883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D27C RID: 53884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D27D RID: 53885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D27E RID: 53886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D27F RID: 53887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D280 RID: 53888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D281 RID: 53889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D282 RID: 53890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D283 RID: 53891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D284 RID: 53892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D285 RID: 53893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D286 RID: 53894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
