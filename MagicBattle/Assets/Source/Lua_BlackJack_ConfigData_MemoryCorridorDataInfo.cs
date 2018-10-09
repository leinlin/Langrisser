using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200117D RID: 4477
[Preserve]
public class Lua_BlackJack_ConfigData_MemoryCorridorDataInfo : LuaObject
{
	// Token: 0x06016F79 RID: 94073 RVA: 0x0062B524 File Offset: 0x00629724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorDataInfo o = new MemoryCorridorDataInfo();
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

	// Token: 0x06016F7A RID: 94074 RVA: 0x0062B56C File Offset: 0x0062976C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MemoryCorridorOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorDataInfo memoryCorridorDataInfo = (MemoryCorridorDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorDataInfo.MemoryCorridorOfWeekDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F7B RID: 94075 RVA: 0x0062B5C0 File Offset: 0x006297C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MemoryCorridorOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorDataInfo memoryCorridorDataInfo = (MemoryCorridorDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, List<ConfigDataMemoryCorridorInfo>> memoryCorridorOfWeekDict;
			LuaObject.checkType<Dictionary<int, List<ConfigDataMemoryCorridorInfo>>>(l, 2, out memoryCorridorOfWeekDict);
			memoryCorridorDataInfo.MemoryCorridorOfWeekDict = memoryCorridorOfWeekDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F7C RID: 94076 RVA: 0x0062B618 File Offset: 0x00629818
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.MemoryCorridorDataInfo");
		string name = "MemoryCorridorOfWeekDict";
		if (Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.get_MemoryCorridorOfWeekDict);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.set_MemoryCorridorOfWeekDict);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.<>f__mg$cache2, typeof(MemoryCorridorDataInfo));
	}

	// Token: 0x0400D661 RID: 54881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D662 RID: 54882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D663 RID: 54883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
