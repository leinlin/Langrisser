using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001180 RID: 4480
[Preserve]
public class Lua_BlackJack_ConfigData_RandomDropDataInfo : LuaObject
{
	// Token: 0x06016F8C RID: 94092 RVA: 0x0062BBA4 File Offset: 0x00629DA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomDropDataInfo o = new RandomDropDataInfo();
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

	// Token: 0x06016F8D RID: 94093 RVA: 0x0062BBEC File Offset: 0x00629DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Areas(IntPtr l)
	{
		int result;
		try
		{
			RandomDropDataInfo randomDropDataInfo = (RandomDropDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomDropDataInfo.Areas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F8E RID: 94094 RVA: 0x0062BC40 File Offset: 0x00629E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Areas(IntPtr l)
	{
		int result;
		try
		{
			RandomDropDataInfo randomDropDataInfo = (RandomDropDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, RandomDropRewardArea> areas;
			LuaObject.checkType<Dictionary<int, RandomDropRewardArea>>(l, 2, out areas);
			randomDropDataInfo.Areas = areas;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F8F RID: 94095 RVA: 0x0062BC98 File Offset: 0x00629E98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RandomDropDataInfo");
		string name = "Areas";
		if (Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropDataInfo.get_Areas);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropDataInfo.set_Areas);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomDropDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RandomDropDataInfo.<>f__mg$cache2, typeof(RandomDropDataInfo));
	}

	// Token: 0x0400D66E RID: 54894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D66F RID: 54895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D670 RID: 54896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
