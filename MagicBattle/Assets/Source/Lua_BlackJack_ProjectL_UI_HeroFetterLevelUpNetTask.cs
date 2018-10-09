using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014C4 RID: 5316
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroFetterLevelUpNetTask : LuaObject
{
	// Token: 0x0601F194 RID: 127380 RVA: 0x00A23EC4 File Offset: 0x00A220C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			HeroFetterLevelUpNetTask o = new HeroFetterLevelUpNetTask(heroId, fetterId);
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

	// Token: 0x0601F195 RID: 127381 RVA: 0x00A23F24 File Offset: 0x00A22124
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroFetterLevelUpNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroFetterLevelUpNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroFetterLevelUpNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroFetterLevelUpNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroFetterLevelUpNetTask.<>f__mg$cache0, typeof(HeroFetterLevelUpNetTask), typeof(UINetTask));
	}

	// Token: 0x040151EE RID: 86510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
