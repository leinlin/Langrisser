using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200116F RID: 4463
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo : LuaObject
{
	// Token: 0x06016E49 RID: 93769 RVA: 0x006230B8 File Offset: 0x006212B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo o = new ConfigDataTowerBattleRuleInfo();
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

	// Token: 0x06016E4A RID: 93770 RVA: 0x00623100 File Offset: 0x00621300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerBattleRuleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E4B RID: 93771 RVA: 0x00623154 File Offset: 0x00621354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataTowerBattleRuleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E4C RID: 93772 RVA: 0x006231AC File Offset: 0x006213AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Skill_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerBattleRuleInfo.Skill_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E4D RID: 93773 RVA: 0x00623200 File Offset: 0x00621400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Skill_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			int skill_ID;
			LuaObject.checkType(l, 2, out skill_ID);
			configDataTowerBattleRuleInfo.Skill_ID = skill_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E4E RID: 93774 RVA: 0x00623258 File Offset: 0x00621458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Target(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerBattleRuleInfo.Target);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E4F RID: 93775 RVA: 0x006232AC File Offset: 0x006214AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Target(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			int target;
			LuaObject.checkType(l, 2, out target);
			configDataTowerBattleRuleInfo.Target = target;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E50 RID: 93776 RVA: 0x00623304 File Offset: 0x00621504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerBattleRuleInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E51 RID: 93777 RVA: 0x00623358 File Offset: 0x00621558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataTowerBattleRuleInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E52 RID: 93778 RVA: 0x006233B0 File Offset: 0x006215B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTowerBattleRuleInfo.SkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E53 RID: 93779 RVA: 0x00623404 File Offset: 0x00621604
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTowerBattleRuleInfo configDataTowerBattleRuleInfo = (ConfigDataTowerBattleRuleInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			configDataTowerBattleRuleInfo.SkillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E54 RID: 93780 RVA: 0x0062345C File Offset: 0x0062165C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataTowerBattleRuleInfo");
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache1, true);
		string name2 = "Skill_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.get_Skill_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.set_Skill_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache3, true);
		string name3 = "Target";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.get_Target);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.set_Target);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache7, true);
		string name5 = "SkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.get_SkillInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.set_SkillInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cache9, true);
		if (Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.<>f__mg$cacheA, typeof(ConfigDataTowerBattleRuleInfo));
	}

	// Token: 0x0400D54D RID: 54605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D54E RID: 54606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D54F RID: 54607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D550 RID: 54608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D551 RID: 54609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D552 RID: 54610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D553 RID: 54611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D554 RID: 54612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D555 RID: 54613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D556 RID: 54614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D557 RID: 54615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
