using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016C5 RID: 5829
[Preserve]
public class Lua_UnityEngine_ExposedPropertyResolver : LuaObject
{
	// Token: 0x06023215 RID: 143893 RVA: 0x00C2B820 File Offset: 0x00C29A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ExposedPropertyResolver exposedPropertyResolver = default(ExposedPropertyResolver);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, exposedPropertyResolver);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023216 RID: 143894 RVA: 0x00C2B870 File Offset: 0x00C29A70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ExposedPropertyResolver");
		if (Lua_UnityEngine_ExposedPropertyResolver.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ExposedPropertyResolver.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ExposedPropertyResolver.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ExposedPropertyResolver.<>f__mg$cache0, typeof(ExposedPropertyResolver), typeof(ValueType));
	}

	// Token: 0x040190E9 RID: 102633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
