using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001138 RID: 4408
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo : LuaObject
{
	// Token: 0x060164C4 RID: 91332 RVA: 0x005DD95C File Offset: 0x005DBB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo o = new ConfigDataBattleAchievementRelatedInfo();
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

	// Token: 0x060164C5 RID: 91333 RVA: 0x005DD9A4 File Offset: 0x005DBBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = (ConfigDataBattleAchievementRelatedInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleAchievementRelatedInfo.m_achievementInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C6 RID: 91334 RVA: 0x005DD9F8 File Offset: 0x005DBBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = (ConfigDataBattleAchievementRelatedInfo)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementInfo achievementInfo;
			LuaObject.checkType<ConfigDataBattleAchievementInfo>(l, 2, out achievementInfo);
			configDataBattleAchievementRelatedInfo.m_achievementInfo = achievementInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C7 RID: 91335 RVA: 0x005DDA50 File Offset: 0x005DBC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = (ConfigDataBattleAchievementRelatedInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleAchievementRelatedInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C8 RID: 91336 RVA: 0x005DDAA4 File Offset: 0x005DBCA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = (ConfigDataBattleAchievementRelatedInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleAchievementRelatedInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C9 RID: 91337 RVA: 0x005DDAFC File Offset: 0x005DBCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievement_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = (ConfigDataBattleAchievementRelatedInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleAchievementRelatedInfo.Achievement_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164CA RID: 91338 RVA: 0x005DDB50 File Offset: 0x005DBD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievement_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = (ConfigDataBattleAchievementRelatedInfo)LuaObject.checkSelf(l);
			int achievement_ID;
			LuaObject.checkType(l, 2, out achievement_ID);
			configDataBattleAchievementRelatedInfo.Achievement_ID = achievement_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164CB RID: 91339 RVA: 0x005DDBA8 File Offset: 0x005DBDA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleAchievementRelatedInfo");
		string name = "m_achievementInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.get_m_achievementInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.set_m_achievementInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache3, true);
		string name3 = "Achievement_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.get_Achievement_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.set_Achievement_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache5, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.<>f__mg$cache6, typeof(ConfigDataBattleAchievementRelatedInfo));
	}

	// Token: 0x0400CC36 RID: 52278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CC37 RID: 52279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CC38 RID: 52280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CC39 RID: 52281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CC3A RID: 52282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CC3B RID: 52283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CC3C RID: 52284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
