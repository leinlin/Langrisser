using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200175A RID: 5978
[Preserve]
public class Lua_UnityEngine_PreferBinarySerialization : LuaObject
{
	// Token: 0x0602387B RID: 145531 RVA: 0x00C68334 File Offset: 0x00C66534
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PreferBinarySerialization o = new PreferBinarySerialization();
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

	// Token: 0x0602387C RID: 145532 RVA: 0x00C6837C File Offset: 0x00C6657C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PreferBinarySerialization");
		if (Lua_UnityEngine_PreferBinarySerialization.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PreferBinarySerialization.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PreferBinarySerialization.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_PreferBinarySerialization.<>f__mg$cache0, typeof(PreferBinarySerialization), typeof(Attribute));
	}

	// Token: 0x04019625 RID: 103973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
