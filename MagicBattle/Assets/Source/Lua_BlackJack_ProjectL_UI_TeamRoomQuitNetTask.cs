using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A6 RID: 5542
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomQuitNetTask : LuaObject
{
	// Token: 0x060218FC RID: 137468 RVA: 0x00B5E4E4 File Offset: 0x00B5C6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomQuitNetTask o = new TeamRoomQuitNetTask();
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

	// Token: 0x060218FD RID: 137469 RVA: 0x00B5E52C File Offset: 0x00B5C72C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomQuitNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomQuitNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomQuitNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomQuitNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomQuitNetTask.<>f__mg$cache0, typeof(TeamRoomQuitNetTask), typeof(UINetTask));
	}

	// Token: 0x04017792 RID: 96146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
