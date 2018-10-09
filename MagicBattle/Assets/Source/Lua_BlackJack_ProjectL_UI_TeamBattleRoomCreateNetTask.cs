using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001590 RID: 5520
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamBattleRoomCreateNetTask : LuaObject
{
	// Token: 0x06021626 RID: 136742 RVA: 0x00B47E90 File Offset: 0x00B46090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamBattleRoomCreateNetTask o = new TeamBattleRoomCreateNetTask();
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

	// Token: 0x06021627 RID: 136743 RVA: 0x00B47ED8 File Offset: 0x00B460D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamBattleRoomCreateNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamBattleRoomCreateNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamBattleRoomCreateNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamBattleRoomCreateNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamBattleRoomCreateNetTask.<>f__mg$cache0, typeof(TeamBattleRoomCreateNetTask), typeof(UINetTask));
	}

	// Token: 0x040174E8 RID: 95464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
