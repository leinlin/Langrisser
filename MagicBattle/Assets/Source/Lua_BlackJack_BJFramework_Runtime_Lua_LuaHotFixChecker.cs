using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200110C RID: 4364
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker : LuaObject
{
	// Token: 0x06015B72 RID: 88946 RVA: 0x005963A0 File Offset: 0x005945A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixChecker o = new LuaHotFixChecker();
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

	// Token: 0x06015B73 RID: 88947 RVA: 0x005963E8 File Offset: 0x005945E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WithOutParam(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixChecker luaHotFixChecker = (LuaHotFixChecker)LuaObject.checkSelf(l);
			int notOutParam;
			LuaObject.checkType(l, 2, out notOutParam);
			LuaHotFixExample o;
			LuaTestStruct luaTestStruct;
			int i;
			float o2;
			bool b;
			ObjectLuaHotFixState objectLuaHotFixState;
			luaHotFixChecker.WithOutParam(notOutParam, out o, out luaTestStruct, out i, out o2, out b, out objectLuaHotFixState);
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

	// Token: 0x06015B74 RID: 88948 RVA: 0x00596488 File Offset: 0x00594688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOutParam(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixChecker luaHotFixChecker = (LuaHotFixChecker)LuaObject.checkSelf(l);
			LuaHotFixExample o;
			int i;
			LuaTestStruct luaTestStruct;
			int outParam = luaHotFixChecker.GetOutParam(out o, out i, out luaTestStruct);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, outParam);
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

	// Token: 0x06015B75 RID: 88949 RVA: 0x00596504 File Offset: 0x00594704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRefParam(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixChecker luaHotFixChecker = (LuaHotFixChecker)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 3, out i);
			LuaHotFixExample o;
			LuaTestStruct luaTestStruct;
			int refParam = luaHotFixChecker.GetRefParam(out o, ref i, out luaTestStruct);
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

	// Token: 0x06015B76 RID: 88950 RVA: 0x0059658C File Offset: 0x0059478C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WithOutParamAndArray(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixChecker luaHotFixChecker = (LuaHotFixChecker)LuaObject.checkSelf(l);
			string[] strArray;
			LuaObject.checkArray<string>(l, 2, out strArray);
			int i;
			luaHotFixChecker.WithOutParamAndArray(strArray, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B77 RID: 88951 RVA: 0x005965F0 File Offset: 0x005947F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnVoid(IntPtr l)
	{
		int result;
		try
		{
			LuaHotFixChecker luaHotFixChecker = (LuaHotFixChecker)LuaObject.checkSelf(l);
			luaHotFixChecker.ReturnVoid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015B78 RID: 88952 RVA: 0x0059663C File Offset: 0x0059483C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Lua.LuaHotFixChecker");
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.WithOutParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.GetOutParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.GetRefParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.WithOutParamAndArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.ReturnVoid);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.<>f__mg$cache5, typeof(LuaHotFixChecker));
	}

	// Token: 0x0400C33C RID: 49980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C33D RID: 49981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C33E RID: 49982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C33F RID: 49983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C340 RID: 49984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C341 RID: 49985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
