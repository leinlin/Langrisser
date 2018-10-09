using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A5 RID: 5541
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomPlayerPositionChangeNetTask : LuaObject
{
	// Token: 0x060218F9 RID: 137465 RVA: 0x00B5E438 File Offset: 0x00B5C638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<ProTeamRoomPlayerPositionInfo> positionInfos;
			LuaObject.checkType<List<ProTeamRoomPlayerPositionInfo>>(l, 2, out positionInfos);
			TeamRoomPlayerPositionChangeNetTask o = new TeamRoomPlayerPositionChangeNetTask(positionInfos);
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

	// Token: 0x060218FA RID: 137466 RVA: 0x00B5E48C File Offset: 0x00B5C68C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomPlayerPositionChangeNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomPlayerPositionChangeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomPlayerPositionChangeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerPositionChangeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomPlayerPositionChangeNetTask.<>f__mg$cache0, typeof(TeamRoomPlayerPositionChangeNetTask), typeof(UINetTask));
	}

	// Token: 0x04017791 RID: 96145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
