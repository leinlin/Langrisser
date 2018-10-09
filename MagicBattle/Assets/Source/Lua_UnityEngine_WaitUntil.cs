using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200187E RID: 6270
[Preserve]
public class Lua_UnityEngine_WaitUntil : LuaObject
{
	// Token: 0x06024440 RID: 148544 RVA: 0x00CBFA84 File Offset: 0x00CBDC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Func<bool> predicate;
			LuaObject.checkDelegate<Func<bool>>(l, 2, out predicate);
			WaitUntil o = new WaitUntil(predicate);
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

	// Token: 0x06024441 RID: 148545 RVA: 0x00CBFAD8 File Offset: 0x00CBDCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_keepWaiting(IntPtr l)
	{
		int result;
		try
		{
			WaitUntil waitUntil = (WaitUntil)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitUntil.keepWaiting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024442 RID: 148546 RVA: 0x00CBFB2C File Offset: 0x00CBDD2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WaitUntil");
		string name = "keepWaiting";
		if (Lua_UnityEngine_WaitUntil.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WaitUntil.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WaitUntil.get_keepWaiting);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_WaitUntil.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_WaitUntil.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WaitUntil.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WaitUntil.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WaitUntil.<>f__mg$cache1, typeof(WaitUntil), typeof(CustomYieldInstruction));
	}

	// Token: 0x04019FA2 RID: 106402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FA3 RID: 106403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
