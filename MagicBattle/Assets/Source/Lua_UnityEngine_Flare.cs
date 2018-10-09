using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016C9 RID: 5833
[Preserve]
public class Lua_UnityEngine_Flare : LuaObject
{
	// Token: 0x06023223 RID: 143907 RVA: 0x00C2BBD8 File Offset: 0x00C29DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Flare o = new Flare();
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

	// Token: 0x06023224 RID: 143908 RVA: 0x00C2BC20 File Offset: 0x00C29E20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Flare");
		if (Lua_UnityEngine_Flare.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Flare.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Flare.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Flare.<>f__mg$cache0, typeof(Flare), typeof(UnityEngine.Object));
	}

	// Token: 0x040190EF RID: 102639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
