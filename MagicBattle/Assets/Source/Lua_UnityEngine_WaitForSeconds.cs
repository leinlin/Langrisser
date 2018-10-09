using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200187C RID: 6268
[Preserve]
public class Lua_UnityEngine_WaitForSeconds : LuaObject
{
	// Token: 0x06024439 RID: 148537 RVA: 0x00CBF8AC File Offset: 0x00CBDAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float seconds;
			LuaObject.checkType(l, 2, out seconds);
			WaitForSeconds o = new WaitForSeconds(seconds);
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

	// Token: 0x0602443A RID: 148538 RVA: 0x00CBF900 File Offset: 0x00CBDB00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WaitForSeconds");
		if (Lua_UnityEngine_WaitForSeconds.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WaitForSeconds.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WaitForSeconds.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WaitForSeconds.<>f__mg$cache0, typeof(WaitForSeconds), typeof(YieldInstruction));
	}

	// Token: 0x04019F9F RID: 106399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
