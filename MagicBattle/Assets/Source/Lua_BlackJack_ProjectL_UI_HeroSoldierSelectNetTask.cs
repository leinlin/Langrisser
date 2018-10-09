using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014E5 RID: 5349
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSoldierSelectNetTask : LuaObject
{
	// Token: 0x0601F898 RID: 129176 RVA: 0x00A5C4D0 File Offset: 0x00A5A6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			HeroSoldierSelectNetTask o = new HeroSoldierSelectNetTask(heroId, soldierId);
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

	// Token: 0x0601F899 RID: 129177 RVA: 0x00A5C530 File Offset: 0x00A5A730
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSoldierSelectNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroSoldierSelectNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSoldierSelectNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSoldierSelectNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroSoldierSelectNetTask.<>f__mg$cache0, typeof(HeroSoldierSelectNetTask), typeof(UINetTask));
	}

	// Token: 0x040158B0 RID: 88240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
