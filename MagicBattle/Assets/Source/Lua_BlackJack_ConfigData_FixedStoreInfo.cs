using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200117B RID: 4475
[Preserve]
public class Lua_BlackJack_ConfigData_FixedStoreInfo : LuaObject
{
	// Token: 0x06016F6D RID: 94061 RVA: 0x0062B120 File Offset: 0x00629320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreInfo o = new FixedStoreInfo();
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

	// Token: 0x06016F6E RID: 94062 RVA: 0x0062B168 File Offset: 0x00629368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StoreItems(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreInfo fixedStoreInfo = (FixedStoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreInfo.StoreItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F6F RID: 94063 RVA: 0x0062B1BC File Offset: 0x006293BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StoreItems(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreInfo fixedStoreInfo = (FixedStoreInfo)LuaObject.checkSelf(l);
			Dictionary<int, ConfigDataFixedStoreItemInfo> storeItems;
			LuaObject.checkType<Dictionary<int, ConfigDataFixedStoreItemInfo>>(l, 2, out storeItems);
			fixedStoreInfo.StoreItems = storeItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F70 RID: 94064 RVA: 0x0062B214 File Offset: 0x00629414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StoreId(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreInfo fixedStoreInfo = (FixedStoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedStoreInfo.StoreId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F71 RID: 94065 RVA: 0x0062B268 File Offset: 0x00629468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StoreId(IntPtr l)
	{
		int result;
		try
		{
			FixedStoreInfo fixedStoreInfo = (FixedStoreInfo)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			fixedStoreInfo.StoreId = storeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F72 RID: 94066 RVA: 0x0062B2C0 File Offset: 0x006294C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.FixedStoreInfo");
		string name = "StoreItems";
		if (Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreInfo.get_StoreItems);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreInfo.set_StoreItems);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache1, true);
		string name2 = "StoreId";
		if (Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreInfo.get_StoreId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreInfo.set_StoreId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_FixedStoreInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_FixedStoreInfo.<>f__mg$cache4, typeof(FixedStoreInfo));
	}

	// Token: 0x0400D659 RID: 54873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D65A RID: 54874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D65B RID: 54875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D65C RID: 54876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D65D RID: 54877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
