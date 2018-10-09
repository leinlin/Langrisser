using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001594 RID: 5524
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchCancelNetTask : LuaObject
{
	// Token: 0x06021693 RID: 136851 RVA: 0x00B4B51C File Offset: 0x00B4971C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomAutoMatchCancelNetTask o = new TeamRoomAutoMatchCancelNetTask();
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

	// Token: 0x06021694 RID: 136852 RVA: 0x00B4B564 File Offset: 0x00B49764
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomAutoMatchCancelNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchCancelNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchCancelNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchCancelNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchCancelNetTask.<>f__mg$cache0, typeof(TeamRoomAutoMatchCancelNetTask), typeof(UINetTask));
	}

	// Token: 0x0401754D RID: 95565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
