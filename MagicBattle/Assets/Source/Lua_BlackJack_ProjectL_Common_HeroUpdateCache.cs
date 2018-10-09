using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001248 RID: 4680
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroUpdateCache : LuaObject
{
	// Token: 0x0601853C RID: 99644 RVA: 0x006CDDF8 File Offset: 0x006CBFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroUpdateCache o = new HeroUpdateCache();
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

	// Token: 0x0601853D RID: 99645 RVA: 0x006CDE40 File Offset: 0x006CC040
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroUpdateCache");
		if (Lua_BlackJack_ProjectL_Common_HeroUpdateCache.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroUpdateCache.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroUpdateCache.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroUpdateCache.<>f__mg$cache0, typeof(HeroUpdateCache), typeof(UpdateCacheList<Hero>));
	}

	// Token: 0x0400EA8E RID: 60046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
