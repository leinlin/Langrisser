using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A2 RID: 5538
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomJoinNetTask : LuaObject
{
	// Token: 0x0602186C RID: 137324 RVA: 0x00B59BF4 File Offset: 0x00B57DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			ulong inviterSessionId;
			LuaObject.checkType(l, 5, out inviterSessionId);
			TeamRoomJoinNetTask o = new TeamRoomJoinNetTask(roomId, gameFunctionTypeId, locationId, inviterSessionId);
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

	// Token: 0x0602186D RID: 137325 RVA: 0x00B59C70 File Offset: 0x00B57E70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomJoinNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomJoinNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomJoinNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomJoinNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomJoinNetTask.<>f__mg$cache0, typeof(TeamRoomJoinNetTask), typeof(UINetTask));
	}

	// Token: 0x0401770A RID: 96010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
