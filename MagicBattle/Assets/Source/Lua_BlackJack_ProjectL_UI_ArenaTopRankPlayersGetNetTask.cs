using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001384 RID: 4996
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaTopRankPlayersGetNetTask : LuaObject
{
	// Token: 0x0601B0A4 RID: 110756 RVA: 0x0081FACC File Offset: 0x0081DCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayersGetNetTask o = new ArenaTopRankPlayersGetNetTask();
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

	// Token: 0x0601B0A5 RID: 110757 RVA: 0x0081FB14 File Offset: 0x0081DD14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaTopRankPlayersGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaTopRankPlayersGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaTopRankPlayersGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaTopRankPlayersGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaTopRankPlayersGetNetTask.<>f__mg$cache0, typeof(ArenaTopRankPlayersGetNetTask), typeof(UINetTask));
	}

	// Token: 0x0401137E RID: 70526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
