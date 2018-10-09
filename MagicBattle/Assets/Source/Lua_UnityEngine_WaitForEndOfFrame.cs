using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200187A RID: 6266
[Preserve]
public class Lua_UnityEngine_WaitForEndOfFrame : LuaObject
{
	// Token: 0x06024433 RID: 148531 RVA: 0x00CBF76C File Offset: 0x00CBD96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WaitForEndOfFrame o = new WaitForEndOfFrame();
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

	// Token: 0x06024434 RID: 148532 RVA: 0x00CBF7B4 File Offset: 0x00CBD9B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WaitForEndOfFrame");
		if (Lua_UnityEngine_WaitForEndOfFrame.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WaitForEndOfFrame.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WaitForEndOfFrame.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WaitForEndOfFrame.<>f__mg$cache0, typeof(WaitForEndOfFrame), typeof(YieldInstruction));
	}

	// Token: 0x04019F9D RID: 106397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
