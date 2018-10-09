using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001181 RID: 4481
[Preserve]
public class Lua_BlackJack_ConfigData_RandomDropRewardArea : LuaObject
{
	// Token: 0x06016F91 RID: 94097 RVA: 0x0062BD2C File Offset: 0x00629F2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea o = new RandomDropRewardArea();
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

	// Token: 0x06016F92 RID: 94098 RVA: 0x0062BD74 File Offset: 0x00629F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_groups(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea randomDropRewardArea = (RandomDropRewardArea)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropRewardArea.groups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F93 RID: 94099 RVA: 0x0062BDC8 File Offset: 0x00629FC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_groups(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea randomDropRewardArea = (RandomDropRewardArea)LuaObject.checkSelf(l);
			List<RandomDropRewardGroup> groups;
			LuaObject.checkType<List<RandomDropRewardGroup>>(l, 2, out groups);
			randomDropRewardArea.groups = groups;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F94 RID: 94100 RVA: 0x0062BE20 File Offset: 0x0062A020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AreaId(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea randomDropRewardArea = (RandomDropRewardArea)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropRewardArea.AreaId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F95 RID: 94101 RVA: 0x0062BE74 File Offset: 0x0062A074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AreaId(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea randomDropRewardArea = (RandomDropRewardArea)LuaObject.checkSelf(l);
			int areaId;
			LuaObject.checkType(l, 2, out areaId);
			randomDropRewardArea.AreaId = areaId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F96 RID: 94102 RVA: 0x0062BECC File Offset: 0x0062A0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CanDropMaxCount(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea randomDropRewardArea = (RandomDropRewardArea)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropRewardArea.CanDropMaxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F97 RID: 94103 RVA: 0x0062BF20 File Offset: 0x0062A120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CanDropMaxCount(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardArea randomDropRewardArea = (RandomDropRewardArea)LuaObject.checkSelf(l);
			int canDropMaxCount;
			LuaObject.checkType(l, 2, out canDropMaxCount);
			randomDropRewardArea.CanDropMaxCount = canDropMaxCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F98 RID: 94104 RVA: 0x0062BF78 File Offset: 0x0062A178
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RandomDropRewardArea");
		string name = "groups";
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.get_groups);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.set_groups);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache1, true);
		string name2 = "AreaId";
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.get_AreaId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.set_AreaId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache3, true);
		string name3 = "CanDropMaxCount";
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.get_CanDropMaxCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.set_CanDropMaxCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache5, true);
		if (Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardArea.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RandomDropRewardArea.<>f__mg$cache6, typeof(RandomDropRewardArea));
	}

	// Token: 0x0400D671 RID: 54897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D672 RID: 54898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D673 RID: 54899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D674 RID: 54900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D675 RID: 54901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D676 RID: 54902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D677 RID: 54903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
