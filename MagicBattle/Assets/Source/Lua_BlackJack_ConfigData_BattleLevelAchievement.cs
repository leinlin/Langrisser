using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001131 RID: 4401
[Preserve]
public class Lua_BlackJack_ConfigData_BattleLevelAchievement : LuaObject
{
	// Token: 0x06015EEE RID: 89838 RVA: 0x005B09F8 File Offset: 0x005AEBF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelAchievement o = new BattleLevelAchievement();
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

	// Token: 0x06015EEF RID: 89839 RVA: 0x005B0A40 File Offset: 0x005AEC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementRelatedInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelAchievement battleLevelAchievement = (BattleLevelAchievement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelAchievement.m_achievementRelatedInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EF0 RID: 89840 RVA: 0x005B0A94 File Offset: 0x005AEC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementRelatedInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelAchievement battleLevelAchievement = (BattleLevelAchievement)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementRelatedInfo achievementRelatedInfo;
			LuaObject.checkType<ConfigDataBattleAchievementRelatedInfo>(l, 2, out achievementRelatedInfo);
			battleLevelAchievement.m_achievementRelatedInfo = achievementRelatedInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EF1 RID: 89841 RVA: 0x005B0AEC File Offset: 0x005AECEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewards(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelAchievement battleLevelAchievement = (BattleLevelAchievement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleLevelAchievement.m_rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EF2 RID: 89842 RVA: 0x005B0B40 File Offset: 0x005AED40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewards(IntPtr l)
	{
		int result;
		try
		{
			BattleLevelAchievement battleLevelAchievement = (BattleLevelAchievement)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			battleLevelAchievement.m_rewards = rewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EF3 RID: 89843 RVA: 0x005B0B98 File Offset: 0x005AED98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.BattleLevelAchievement");
		string name = "m_achievementRelatedInfo";
		if (Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_BattleLevelAchievement.get_m_achievementRelatedInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_BattleLevelAchievement.set_m_achievementRelatedInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache1, true);
		string name2 = "m_rewards";
		if (Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_BattleLevelAchievement.get_m_rewards);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_BattleLevelAchievement.set_m_rewards);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_BattleLevelAchievement.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_BattleLevelAchievement.<>f__mg$cache4, typeof(BattleLevelAchievement));
	}

	// Token: 0x0400C66E RID: 50798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C66F RID: 50799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C670 RID: 50800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C671 RID: 50801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C672 RID: 50802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
