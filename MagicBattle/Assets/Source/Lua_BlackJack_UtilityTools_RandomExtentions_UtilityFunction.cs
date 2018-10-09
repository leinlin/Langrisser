using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F6 RID: 5622
[Preserve]
public class Lua_BlackJack_UtilityTools_RandomExtentions_UtilityFunction : LuaObject
{
	// Token: 0x060227E6 RID: 141286 RVA: 0x00BD3EC0 File Offset: 0x00BD20C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomExtentions.UtilityFunction o = new RandomExtentions.UtilityFunction();
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

	// Token: 0x060227E7 RID: 141287 RVA: 0x00BD3F08 File Offset: 0x00BD2108
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.RandomExtentions.UtilityFunction");
		if (Lua_BlackJack_UtilityTools_RandomExtentions_UtilityFunction.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_RandomExtentions_UtilityFunction.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_RandomExtentions_UtilityFunction.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_RandomExtentions_UtilityFunction.<>f__mg$cache0, typeof(RandomExtentions.UtilityFunction));
	}

	// Token: 0x040185DC RID: 99804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
