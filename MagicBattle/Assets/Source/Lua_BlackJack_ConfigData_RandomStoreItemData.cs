using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001184 RID: 4484
[Preserve]
public class Lua_BlackJack_ConfigData_RandomStoreItemData : LuaObject
{
	// Token: 0x06016FA8 RID: 94120 RVA: 0x0062C58C File Offset: 0x0062A78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemData o = new RandomStoreItemData();
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

	// Token: 0x06016FA9 RID: 94121 RVA: 0x0062C5D4 File Offset: 0x0062A7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemData randomStoreItemData = (RandomStoreItemData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreItemData.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FAA RID: 94122 RVA: 0x0062C628 File Offset: 0x0062A828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemData randomStoreItemData = (RandomStoreItemData)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			randomStoreItemData.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FAB RID: 94123 RVA: 0x0062C680 File Offset: 0x0062A880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Weight(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemData randomStoreItemData = (RandomStoreItemData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomStoreItemData.Weight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FAC RID: 94124 RVA: 0x0062C6D4 File Offset: 0x0062A8D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Weight(IntPtr l)
	{
		int result;
		try
		{
			RandomStoreItemData randomStoreItemData = (RandomStoreItemData)LuaObject.checkSelf(l);
			int weight;
			LuaObject.checkType(l, 2, out weight);
			randomStoreItemData.Weight = weight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FAD RID: 94125 RVA: 0x0062C72C File Offset: 0x0062A92C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.RandomStoreItemData");
		string name = "Id";
		if (Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemData.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemData.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache1, true);
		string name2 = "Weight";
		if (Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemData.get_Weight);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemData.set_Weight);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache3, true);
		if (Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_RandomStoreItemData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_RandomStoreItemData.<>f__mg$cache4, typeof(RandomStoreItemData));
	}

	// Token: 0x0400D682 RID: 54914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D683 RID: 54915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D684 RID: 54916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D685 RID: 54917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D686 RID: 54918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
