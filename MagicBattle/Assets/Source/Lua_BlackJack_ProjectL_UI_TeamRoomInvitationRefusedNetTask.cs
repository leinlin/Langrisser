using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200159B RID: 5531
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInvitationRefusedNetTask : LuaObject
{
	// Token: 0x060217A9 RID: 137129 RVA: 0x00B53D0C File Offset: 0x00B51F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong inviterSessionId;
			LuaObject.checkType(l, 2, out inviterSessionId);
			int inviterChannelId;
			LuaObject.checkType(l, 3, out inviterChannelId);
			int roomId;
			LuaObject.checkType(l, 4, out roomId);
			TeamRoomInvitationRefusedNetTask o = new TeamRoomInvitationRefusedNetTask(inviterSessionId, inviterChannelId, roomId);
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

	// Token: 0x060217AA RID: 137130 RVA: 0x00B53D7C File Offset: 0x00B51F7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInvitationRefusedNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInvitationRefusedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInvitationRefusedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInvitationRefusedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomInvitationRefusedNetTask.<>f__mg$cache0, typeof(TeamRoomInvitationRefusedNetTask), typeof(UINetTask));
	}

	// Token: 0x04017655 RID: 95829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
