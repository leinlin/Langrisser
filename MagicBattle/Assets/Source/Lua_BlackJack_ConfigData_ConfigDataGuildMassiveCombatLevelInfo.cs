using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001152 RID: 4434
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo : LuaObject
{
	// Token: 0x0601688A RID: 92298 RVA: 0x005F8F54 File Offset: 0x005F7154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo o = new ConfigDataGuildMassiveCombatLevelInfo();
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

	// Token: 0x0601688B RID: 92299 RVA: 0x005F8F9C File Offset: 0x005F719C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601688C RID: 92300 RVA: 0x005F8FF0 File Offset: 0x005F71F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataGuildMassiveCombatLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601688D RID: 92301 RVA: 0x005F9048 File Offset: 0x005F7248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_strongholdInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatLevelInfo.m_strongholdInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601688E RID: 92302 RVA: 0x005F909C File Offset: 0x005F729C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_strongholdInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			ConfigDataGuildMassiveCombatStrongholdInfo strongholdInfo;
			LuaObject.checkType<ConfigDataGuildMassiveCombatStrongholdInfo>(l, 2, out strongholdInfo);
			configDataGuildMassiveCombatLevelInfo.m_strongholdInfo = strongholdInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601688F RID: 92303 RVA: 0x005F90F4 File Offset: 0x005F72F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016890 RID: 92304 RVA: 0x005F9148 File Offset: 0x005F7348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataGuildMassiveCombatLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016891 RID: 92305 RVA: 0x005F91A0 File Offset: 0x005F73A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatLevelInfo.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016892 RID: 92306 RVA: 0x005F91F4 File Offset: 0x005F73F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			configDataGuildMassiveCombatLevelInfo.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016893 RID: 92307 RVA: 0x005F924C File Offset: 0x005F744C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MiniMapResources(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatLevelInfo.MiniMapResources);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016894 RID: 92308 RVA: 0x005F92A0 File Offset: 0x005F74A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MiniMapResources(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			string miniMapResources;
			LuaObject.checkType(l, 2, out miniMapResources);
			configDataGuildMassiveCombatLevelInfo.MiniMapResources = miniMapResources;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016895 RID: 92309 RVA: 0x005F92F8 File Offset: 0x005F74F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataGuildMassiveCombatLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016896 RID: 92310 RVA: 0x005F934C File Offset: 0x005F754C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = (ConfigDataGuildMassiveCombatLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataGuildMassiveCombatLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016897 RID: 92311 RVA: 0x005F93A4 File Offset: 0x005F75A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataGuildMassiveCombatLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_strongholdInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.get_m_strongholdInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.set_m_strongholdInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache5, true);
		string name4 = "BattleId";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.get_BattleId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.set_BattleId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache7, true);
		string name5 = "MiniMapResources";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.get_MiniMapResources);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.set_MiniMapResources);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cache9, true);
		string name6 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.get_Strategy);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.<>f__mg$cacheC, typeof(ConfigDataGuildMassiveCombatLevelInfo));
	}

	// Token: 0x0400CFC8 RID: 53192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CFC9 RID: 53193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CFCA RID: 53194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CFCB RID: 53195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CFCC RID: 53196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CFCD RID: 53197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CFCE RID: 53198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CFCF RID: 53199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CFD0 RID: 53200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CFD1 RID: 53201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CFD2 RID: 53202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CFD3 RID: 53203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CFD4 RID: 53204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
