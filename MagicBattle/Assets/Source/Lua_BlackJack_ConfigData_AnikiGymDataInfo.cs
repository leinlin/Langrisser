using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001130 RID: 4400
[Preserve]
public class Lua_BlackJack_ConfigData_AnikiGymDataInfo : LuaObject
{
	// Token: 0x06015EE9 RID: 89833 RVA: 0x005B0870 File Offset: 0x005AEA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymDataInfo o = new AnikiGymDataInfo();
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

	// Token: 0x06015EEA RID: 89834 RVA: 0x005B08B8 File Offset: 0x005AEAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AnikiGymOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymDataInfo anikiGymDataInfo = (AnikiGymDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymDataInfo.AnikiGymOfWeekDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EEB RID: 89835 RVA: 0x005B090C File Offset: 0x005AEB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AnikiGymOfWeekDict(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymDataInfo anikiGymDataInfo = (AnikiGymDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, List<ConfigDataAnikiGymInfo>> anikiGymOfWeekDict;
			LuaObject.checkType<Dictionary<int, List<ConfigDataAnikiGymInfo>>>(l, 2, out anikiGymOfWeekDict);
			anikiGymDataInfo.AnikiGymOfWeekDict = anikiGymOfWeekDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EEC RID: 89836 RVA: 0x005B0964 File Offset: 0x005AEB64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.AnikiGymDataInfo");
		string name = "AnikiGymOfWeekDict";
		if (Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_AnikiGymDataInfo.get_AnikiGymOfWeekDict);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_AnikiGymDataInfo.set_AnikiGymOfWeekDict);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_AnikiGymDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_AnikiGymDataInfo.<>f__mg$cache2, typeof(AnikiGymDataInfo));
	}

	// Token: 0x0400C66B RID: 50795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C66C RID: 50796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C66D RID: 50797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
