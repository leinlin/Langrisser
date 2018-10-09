using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001379 RID: 4985
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaOpponentRevengeNetTask : LuaObject
{
	// Token: 0x0601AFDD RID: 110557 RVA: 0x00819894 File Offset: 0x00817A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong arenaBattleReportInstanceId;
			LuaObject.checkType(l, 2, out arenaBattleReportInstanceId);
			bool autoBattle;
			LuaObject.checkType(l, 3, out autoBattle);
			ArenaOpponentRevengeNetTask o = new ArenaOpponentRevengeNetTask(arenaBattleReportInstanceId, autoBattle);
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

	// Token: 0x0601AFDE RID: 110558 RVA: 0x008198F4 File Offset: 0x00817AF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaOpponentRevengeNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentRevengeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentRevengeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentRevengeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentRevengeNetTask.<>f__mg$cache0, typeof(ArenaOpponentRevengeNetTask), typeof(UINetTask));
	}

	// Token: 0x040112CD RID: 70349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
