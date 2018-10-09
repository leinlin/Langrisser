using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200117A RID: 4474
[Preserve]
public class Lua_BlackJack_ConfigData_FixedStoreDataInfo : LuaObject
{
	// Token: 0x06016F68 RID: 94056 RVA: 0x0062AF98 File Offset: 0x00629198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreDataInfo o = new FixedStoreDataInfo();
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

	// Token: 0x06016F69 RID: 94057 RVA: 0x0062AFE0 File Offset: 0x006291E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Stores(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreDataInfo fixedStoreDataInfo = (FixedStoreDataInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreDataInfo.Stores);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F6A RID: 94058 RVA: 0x0062B034 File Offset: 0x00629234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Stores(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreDataInfo fixedStoreDataInfo = (FixedStoreDataInfo)LuaObject.checkSelf(l);
			Dictionary<int, FixedStoreInfo> stores;
			LuaObject.checkType<Dictionary<int, FixedStoreInfo>>(l, 2, out stores);
			fixedStoreDataInfo.Stores = stores;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F6B RID: 94059 RVA: 0x0062B08C File Offset: 0x0062928C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.FixedStoreDataInfo");
		string name = "Stores";
		if (Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreDataInfo.get_Stores);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreDataInfo.set_Stores);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreDataInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_FixedStoreDataInfo.<>f__mg$cache2, typeof(FixedStoreDataInfo));
	}

	// Token: 0x0400D656 RID: 54870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D657 RID: 54871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D658 RID: 54872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
