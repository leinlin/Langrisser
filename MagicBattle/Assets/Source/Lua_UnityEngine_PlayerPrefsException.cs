using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001755 RID: 5973
[Preserve]
public class Lua_UnityEngine_PlayerPrefsException : LuaObject
{
	// Token: 0x0602384C RID: 145484 RVA: 0x00C66EF8 File Offset: 0x00C650F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string error;
			LuaObject.checkType(l, 2, out error);
			PlayerPrefsException o = new PlayerPrefsException(error);
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

	// Token: 0x0602384D RID: 145485 RVA: 0x00C66F4C File Offset: 0x00C6514C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PlayerPrefsException");
		if (Lua_UnityEngine_PlayerPrefsException.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PlayerPrefsException.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefsException.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_PlayerPrefsException.<>f__mg$cache0, typeof(PlayerPrefsException), typeof(Exception));
	}

	// Token: 0x04019600 RID: 103936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
