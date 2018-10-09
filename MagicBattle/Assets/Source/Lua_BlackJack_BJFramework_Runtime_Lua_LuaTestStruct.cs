using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200110F RID: 4367
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct : LuaObject
{
	// Token: 0x06015B89 RID: 88969 RVA: 0x00596E7C File Offset: 0x0059507C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LuaTestStruct luaTestStruct = default(LuaTestStruct);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaTestStruct);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B8A RID: 88970 RVA: 0x00596ECC File Offset: 0x005950CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_str(IntPtr l)
	{
		int result;
		try
		{
			LuaTestStruct luaTestStruct;
			LuaObject.checkValueType<LuaTestStruct>(l, 1, out luaTestStruct);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, luaTestStruct.m_str);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B8B RID: 88971 RVA: 0x00596F20 File Offset: 0x00595120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_str(IntPtr l)
	{
		int result;
		try
		{
			LuaTestStruct luaTestStruct;
			LuaObject.checkValueType<LuaTestStruct>(l, 1, out luaTestStruct);
			string str;
			LuaObject.checkType(l, 2, out str);
			luaTestStruct.m_str = str;
			LuaObject.setBack(l, luaTestStruct);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B8C RID: 88972 RVA: 0x00596F84 File Offset: 0x00595184
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Lua.LuaTestStruct");
		string name = "m_str";
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.get_m_str);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.set_m_str);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache1, true);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.<>f__mg$cache2, typeof(LuaTestStruct), typeof(ValueType));
	}

	// Token: 0x0400C34D RID: 49997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C34E RID: 49998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C34F RID: 49999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
