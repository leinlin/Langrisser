using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014AF RID: 5295
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroComposeNetTask : LuaObject
{
	// Token: 0x0601EBDE RID: 125918 RVA: 0x009F6098 File Offset: 0x009F4298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroComposeNetTask o = new HeroComposeNetTask(heroId);
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

	// Token: 0x0601EBDF RID: 125919 RVA: 0x009F60EC File Offset: 0x009F42EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroComposeNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroComposeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroComposeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroComposeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroComposeNetTask.<>f__mg$cache0, typeof(HeroComposeNetTask), typeof(UINetTask));
	}

	// Token: 0x04014C62 RID: 85090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
