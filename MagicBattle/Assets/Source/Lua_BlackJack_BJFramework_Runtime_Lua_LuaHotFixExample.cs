using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200110D RID: 4365
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample : LuaObject
{
	// Token: 0x06015B7A RID: 88954 RVA: 0x00596738 File Offset: 0x00594938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixExample o = new LuaHotFixExample();
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

	// Token: 0x06015B7B RID: 88955 RVA: 0x00596780 File Offset: 0x00594980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WithOutParam(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixExample luaHotFixExample = (LuaHotFixExample)LuaObject.checkSelf(l);
			int notOutParam;
			LuaObject.checkType(l, 2, out notOutParam);
			LuaHotFixExample o;
			LuaTestStruct luaTestStruct;
			int i;
			float o2;
			bool b;
			ObjectLuaHotFixState objectLuaHotFixState;
			luaHotFixExample.WithOutParam(notOutParam, out o, out luaTestStruct, out i, out o2, out b, out objectLuaHotFixState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, luaTestStruct);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, o2);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, objectLuaHotFixState);
			result = 7;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B7C RID: 88956 RVA: 0x00596820 File Offset: 0x00594A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOutParam(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				LuaHotFixExample luaHotFixExample = (LuaHotFixExample)LuaObject.checkSelf(l);
				LuaHotFixExample o;
				int i;
				LuaTestStruct luaTestStruct;
				int outParam = luaHotFixExample.GetOutParam(out o, out i, out luaTestStruct);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, outParam);
				LuaObject.pushValue(l, o);
				LuaObject.pushValue(l, i);
				LuaObject.pushValue(l, luaTestStruct);
				result = 5;
			}
			else if (num == 13)
			{
				LuaHotFixExample luaHotFixExample2 = (LuaHotFixExample)LuaObject.checkSelf(l);
				LuaHotFixExample notOutClassParam;
				LuaObject.checkType<LuaHotFixExample>(l, 3, out notOutClassParam);
				LuaTestStruct notOutvalueTypeParam;
				LuaObject.checkValueType<LuaTestStruct>(l, 5, out notOutvalueTypeParam);
				int notOutIntParam;
				LuaObject.checkType(l, 7, out notOutIntParam);
				float notOutfloatParam;
				LuaObject.checkType(l, 9, out notOutfloatParam);
				bool notOutboolParam;
				LuaObject.checkType(l, 11, out notOutboolParam);
				ObjectLuaHotFixState notOutEnumParam;
				LuaObject.checkEnum<ObjectLuaHotFixState>(l, 13, out notOutEnumParam);
				LuaHotFixExample o2;
				LuaTestStruct luaTestStruct2;
				int i2;
				float o3;
				bool b;
				ObjectLuaHotFixState objectLuaHotFixState;
				int outParam2 = luaHotFixExample2.GetOutParam(out o2, notOutClassParam, out luaTestStruct2, notOutvalueTypeParam, out i2, notOutIntParam, out o3, notOutfloatParam, out b, notOutboolParam, out objectLuaHotFixState, notOutEnumParam);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, outParam2);
				LuaObject.pushValue(l, o2);
				LuaObject.pushValue(l, luaTestStruct2);
				LuaObject.pushValue(l, i2);
				LuaObject.pushValue(l, o3);
				LuaObject.pushValue(l, b);
				LuaObject.pushValue(l, objectLuaHotFixState);
				result = 8;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetOutParam to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B7D RID: 88957 RVA: 0x00596998 File Offset: 0x00594B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRefParam(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixExample luaHotFixExample = (LuaHotFixExample)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 3, out i);
			LuaHotFixExample o;
			LuaTestStruct luaTestStruct;
			int refParam = luaHotFixExample.GetRefParam(out o, ref i, out luaTestStruct);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, refParam);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, luaTestStruct);
			result = 5;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B7E RID: 88958 RVA: 0x00596A20 File Offset: 0x00594C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnVoid(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixExample luaHotFixExample = (LuaHotFixExample)LuaObject.checkSelf(l);
			luaHotFixExample.ReturnVoid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B7F RID: 88959 RVA: 0x00596A6C File Offset: 0x00594C6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Lua.LuaHotFixExample");
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.WithOutParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.GetOutParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.GetRefParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.ReturnVoid);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.<>f__mg$cache4, typeof(LuaHotFixExample));
	}

	// Token: 0x0400C342 RID: 49986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C343 RID: 49987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C344 RID: 49988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C345 RID: 49989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C346 RID: 49990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
