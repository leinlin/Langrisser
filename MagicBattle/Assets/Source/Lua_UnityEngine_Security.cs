using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017CB RID: 6091
[Preserve]
public class Lua_UnityEngine_Security : LuaObject
{
	// Token: 0x06023CDE RID: 146654 RVA: 0x00C8B3E0 File Offset: 0x00C895E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Security o = new Security();
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

	// Token: 0x06023CDF RID: 146655 RVA: 0x00C8B428 File Offset: 0x00C89628
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Security");
		if (Lua_UnityEngine_Security.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Security.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Security.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Security.<>f__mg$cache0, typeof(Security));
	}

	// Token: 0x040199A6 RID: 104870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
