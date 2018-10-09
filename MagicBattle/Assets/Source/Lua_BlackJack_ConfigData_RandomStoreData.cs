using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001183 RID: 4483
[Preserve]
public class Lua_BlackJack_ConfigData_RandomStoreData : LuaObject
{
	// Token: 0x06016FA3 RID: 94115 RVA: 0x0062C404 File Offset: 0x0062A604
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreData o = new RandomStoreData();
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

	// Token: 0x06016FA4 RID: 94116 RVA: 0x0062C44C File Offset: 0x0062A64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Stores(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreData randomStoreData = (RandomStoreData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreData.Stores);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FA5 RID: 94117 RVA: 0x0062C4A0 File Offset: 0x0062A6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Stores(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreData randomStoreData = (RandomStoreData)LuaObject.checkSelf(l);
			Dictionary<RandomStoreItemDataKey, List<RandomStoreItemData>> stores;
			LuaObject.checkType<Dictionary<RandomStoreItemDataKey, List<RandomStoreItemData>>>(l, 2, out stores);
			randomStoreData.Stores = stores;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FA6 RID: 94118 RVA: 0x0062C4F8 File Offset: 0x0062A6F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RandomStoreData");
		string name = "Stores";
		if (Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreData.get_Stores);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreData.set_Stores);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache1, true);
		if (Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RandomStoreData.<>f__mg$cache2, typeof(RandomStoreData));
	}

	// Token: 0x0400D67F RID: 54911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D680 RID: 54912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D681 RID: 54913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
