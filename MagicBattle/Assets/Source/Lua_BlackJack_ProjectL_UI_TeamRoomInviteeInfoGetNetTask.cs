using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200159C RID: 5532
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInviteeInfoGetNetTask : LuaObject
{
	// Token: 0x060217AC RID: 137132 RVA: 0x00B53DD4 File Offset: 0x00B51FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> inviteeUserIds;
			LuaObject.checkType<List<string>>(l, 2, out inviteeUserIds);
			TeamRoomInviteeInfoType infoType;
			LuaObject.checkEnum<TeamRoomInviteeInfoType>(l, 3, out infoType);
			TeamRoomInviteeInfoGetNetTask o = new TeamRoomInviteeInfoGetNetTask(inviteeUserIds, infoType);
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

	// Token: 0x060217AD RID: 137133 RVA: 0x00B53E34 File Offset: 0x00B52034
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInviteeInfoGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteeInfoGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteeInfoGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteeInfoGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteeInfoGetNetTask.<>f__mg$cache0, typeof(TeamRoomInviteeInfoGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04017656 RID: 95830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
