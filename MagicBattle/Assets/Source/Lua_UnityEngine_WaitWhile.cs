using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200187F RID: 6271
[Preserve]
public class Lua_UnityEngine_WaitWhile : LuaObject
{
	// Token: 0x06024444 RID: 148548 RVA: 0x00CBFBB0 File Offset: 0x00CBDDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Func<bool> predicate;
			LuaObject.checkDelegate<Func<bool>>(l, 2, out predicate);
			WaitWhile o = new WaitWhile(predicate);
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

	// Token: 0x06024445 RID: 148549 RVA: 0x00CBFC04 File Offset: 0x00CBDE04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_keepWaiting(IntPtr l)
	{
		int result;
		try
		{
			WaitWhile waitWhile = (WaitWhile)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitWhile.keepWaiting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024446 RID: 148550 RVA: 0x00CBFC58 File Offset: 0x00CBDE58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WaitWhile");
		string name = "keepWaiting";
		if (Lua_UnityEngine_WaitWhile.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WaitWhile.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WaitWhile.get_keepWaiting);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_WaitWhile.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_WaitWhile.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WaitWhile.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WaitWhile.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WaitWhile.<>f__mg$cache1, typeof(WaitWhile), typeof(CustomYieldInstruction));
	}

	// Token: 0x04019FA4 RID: 106404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FA5 RID: 106405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
