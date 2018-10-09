using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F2 RID: 5618
[Preserve]
public class Lua_BlackJack_UtilityTools_Find : LuaObject
{
	// Token: 0x060227D1 RID: 141265 RVA: 0x00BD3804 File Offset: 0x00BD1A04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Find o = new Find();
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

	// Token: 0x060227D2 RID: 141266 RVA: 0x00BD384C File Offset: 0x00BD1A4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.Find");
		if (Lua_BlackJack_UtilityTools_Find.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_Find.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_Find.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_Find.<>f__mg$cache0, typeof(Find));
	}

	// Token: 0x040185CF RID: 99791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
