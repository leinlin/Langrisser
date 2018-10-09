using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001377 RID: 4983
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackNetTask : LuaObject
{
	// Token: 0x0601AFB2 RID: 110514 RVA: 0x008182D0 File Offset: 0x008164D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			bool autoBattle;
			LuaObject.checkType(l, 2, out autoBattle);
			ArenaOpponentAttackNetTask o = new ArenaOpponentAttackNetTask(autoBattle);
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

	// Token: 0x0601AFB3 RID: 110515 RVA: 0x00818324 File Offset: 0x00816524
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaOpponentAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackNetTask.<>f__mg$cache0, typeof(ArenaOpponentAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x040112A6 RID: 70310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
