using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001185 RID: 4485
[Preserve]
public class Lua_BlackJack_ConfigData_RandomStoreItemDataKey : LuaObject
{
	// Token: 0x06016FAF RID: 94127 RVA: 0x0062C808 File Offset: 0x0062AA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int levelZoneId;
			LuaObject.checkType(l, 3, out levelZoneId);
			RandomStoreItemDataKey o = new RandomStoreItemDataKey(storeId, levelZoneId);
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

	// Token: 0x06016FB0 RID: 94128 RVA: 0x0062C868 File Offset: 0x0062AA68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StoreId(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemDataKey randomStoreItemDataKey = (RandomStoreItemDataKey)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreItemDataKey.StoreId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB1 RID: 94129 RVA: 0x0062C8BC File Offset: 0x0062AABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StoreId(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemDataKey randomStoreItemDataKey = (RandomStoreItemDataKey)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			randomStoreItemDataKey.StoreId = storeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB2 RID: 94130 RVA: 0x0062C914 File Offset: 0x0062AB14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelZoneId(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemDataKey randomStoreItemDataKey = (RandomStoreItemDataKey)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreItemDataKey.LevelZoneId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB3 RID: 94131 RVA: 0x0062C968 File Offset: 0x0062AB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelZoneId(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemDataKey randomStoreItemDataKey = (RandomStoreItemDataKey)LuaObject.checkSelf(l);
			int levelZoneId;
			LuaObject.checkType(l, 2, out levelZoneId);
			randomStoreItemDataKey.LevelZoneId = levelZoneId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FB4 RID: 94132 RVA: 0x0062C9C0 File Offset: 0x0062ABC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RandomStoreItemDataKey");
		string name = "StoreId";
		if (Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemDataKey.get_StoreId);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemDataKey.set_StoreId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache1, true);
		string name2 = "LevelZoneId";
		if (Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemDataKey.get_LevelZoneId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemDataKey.set_LevelZoneId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemDataKey.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RandomStoreItemDataKey.<>f__mg$cache4, typeof(RandomStoreItemDataKey));
	}

	// Token: 0x0400D687 RID: 54919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D688 RID: 54920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D689 RID: 54921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D68A RID: 54922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D68B RID: 54923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
