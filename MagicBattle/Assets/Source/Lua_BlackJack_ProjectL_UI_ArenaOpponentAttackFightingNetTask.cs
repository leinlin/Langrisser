using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001376 RID: 4982
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackFightingNetTask : LuaObject
{
	// Token: 0x0601AFAF RID: 110511 RVA: 0x00818230 File Offset: 0x00816430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentAttackFightingNetTask o = new ArenaOpponentAttackFightingNetTask();
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

	// Token: 0x0601AFB0 RID: 110512 RVA: 0x00818278 File Offset: 0x00816478
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaOpponentAttackFightingNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackFightingNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackFightingNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackFightingNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackFightingNetTask.<>f__mg$cache0, typeof(ArenaOpponentAttackFightingNetTask), typeof(UINetTask));
	}

	// Token: 0x040112A5 RID: 70309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
