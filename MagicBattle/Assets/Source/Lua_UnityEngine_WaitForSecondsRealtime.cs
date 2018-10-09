using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200187D RID: 6269
[Preserve]
public class Lua_UnityEngine_WaitForSecondsRealtime : LuaObject
{
	// Token: 0x0602443C RID: 148540 RVA: 0x00CBF958 File Offset: 0x00CBDB58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float time;
			LuaObject.checkType(l, 2, out time);
			WaitForSecondsRealtime o = new WaitForSecondsRealtime(time);
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

	// Token: 0x0602443D RID: 148541 RVA: 0x00CBF9AC File Offset: 0x00CBDBAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_keepWaiting(IntPtr l)
	{
		int result;
		try
		{
			WaitForSecondsRealtime waitForSecondsRealtime = (WaitForSecondsRealtime)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waitForSecondsRealtime.keepWaiting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602443E RID: 148542 RVA: 0x00CBFA00 File Offset: 0x00CBDC00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WaitForSecondsRealtime");
		string name = "keepWaiting";
		if (Lua_UnityEngine_WaitForSecondsRealtime.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WaitForSecondsRealtime.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WaitForSecondsRealtime.get_keepWaiting);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_WaitForSecondsRealtime.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_WaitForSecondsRealtime.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_WaitForSecondsRealtime.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_WaitForSecondsRealtime.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WaitForSecondsRealtime.<>f__mg$cache1, typeof(WaitForSecondsRealtime), typeof(CustomYieldInstruction));
	}

	// Token: 0x04019FA0 RID: 106400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019FA1 RID: 106401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
