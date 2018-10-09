using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001182 RID: 4482
[Preserve]
public class Lua_BlackJack_ConfigData_RandomDropRewardGroup : LuaObject
{
	// Token: 0x06016F9A RID: 94106 RVA: 0x0062C098 File Offset: 0x0062A298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup o = new RandomDropRewardGroup();
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

	// Token: 0x06016F9B RID: 94107 RVA: 0x0062C0E0 File Offset: 0x0062A2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GroupIndex(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup randomDropRewardGroup = (RandomDropRewardGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropRewardGroup.GroupIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F9C RID: 94108 RVA: 0x0062C134 File Offset: 0x0062A334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GroupIndex(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup randomDropRewardGroup = (RandomDropRewardGroup)LuaObject.checkSelf(l);
			int groupIndex;
			LuaObject.checkType(l, 2, out groupIndex);
			randomDropRewardGroup.GroupIndex = groupIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F9D RID: 94109 RVA: 0x0062C18C File Offset: 0x0062A38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DropCount(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup randomDropRewardGroup = (RandomDropRewardGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropRewardGroup.DropCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F9E RID: 94110 RVA: 0x0062C1E0 File Offset: 0x0062A3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DropCount(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup randomDropRewardGroup = (RandomDropRewardGroup)LuaObject.checkSelf(l);
			int dropCount;
			LuaObject.checkType(l, 2, out dropCount);
			randomDropRewardGroup.DropCount = dropCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F9F RID: 94111 RVA: 0x0062C238 File Offset: 0x0062A438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DropRewards(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup randomDropRewardGroup = (RandomDropRewardGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropRewardGroup.DropRewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FA0 RID: 94112 RVA: 0x0062C28C File Offset: 0x0062A48C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DropRewards(IntPtr l)
	{
		int result;
		try
		{
			RandomDropRewardGroup randomDropRewardGroup = (RandomDropRewardGroup)LuaObject.checkSelf(l);
			Dictionary<int, WeightGoods> dropRewards;
			LuaObject.checkType<Dictionary<int, WeightGoods>>(l, 2, out dropRewards);
			randomDropRewardGroup.DropRewards = dropRewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FA1 RID: 94113 RVA: 0x0062C2E4 File Offset: 0x0062A4E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RandomDropRewardGroup");
		string name = "GroupIndex";
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.get_GroupIndex);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.set_GroupIndex);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache1, true);
		string name2 = "DropCount";
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.get_DropCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.set_DropCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache3, true);
		string name3 = "DropRewards";
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.get_DropRewards);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.set_DropRewards);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache5, true);
		if (Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropRewardGroup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RandomDropRewardGroup.<>f__mg$cache6, typeof(RandomDropRewardGroup));
	}

	// Token: 0x0400D678 RID: 54904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D679 RID: 54905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D67A RID: 54906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D67B RID: 54907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D67C RID: 54908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D67D RID: 54909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D67E RID: 54910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
