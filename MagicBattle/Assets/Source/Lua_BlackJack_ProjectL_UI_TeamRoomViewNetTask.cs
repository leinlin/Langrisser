using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A7 RID: 5543
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask : LuaObject
{
	// Token: 0x060218FF RID: 137471 RVA: 0x00B5E584 File Offset: 0x00B5C784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			TeamRoomViewNetTask o = new TeamRoomViewNetTask(gameFunctionTypeId, chapterId, locationId);
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

	// Token: 0x06021900 RID: 137472 RVA: 0x00B5E5F4 File Offset: 0x00B5C7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamRooms(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomViewNetTask teamRoomViewNetTask = (TeamRoomViewNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomViewNetTask.TeamRooms);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021901 RID: 137473 RVA: 0x00B5E648 File Offset: 0x00B5C848
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomViewNetTask");
		string name = "TeamRooms";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.get_TeamRooms);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.<>f__mg$cache1, typeof(TeamRoomViewNetTask), typeof(UINetTask));
	}

	// Token: 0x04017793 RID: 96147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017794 RID: 96148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
