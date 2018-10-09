using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200159D RID: 5533
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInviteNetTask : LuaObject
{
	// Token: 0x060217AF RID: 137135 RVA: 0x00B53E8C File Offset: 0x00B5208C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> inviteeUserIds;
			LuaObject.checkType<List<string>>(l, 2, out inviteeUserIds);
			TeamRoomInviteNetTask o = new TeamRoomInviteNetTask(inviteeUserIds);
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

	// Token: 0x060217B0 RID: 137136 RVA: 0x00B53EE0 File Offset: 0x00B520E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInviteNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteNetTask.<>f__mg$cache0, typeof(TeamRoomInviteNetTask), typeof(UINetTask));
	}

	// Token: 0x04017657 RID: 95831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
