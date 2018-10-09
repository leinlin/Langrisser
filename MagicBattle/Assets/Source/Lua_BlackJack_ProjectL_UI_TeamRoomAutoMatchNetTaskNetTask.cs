using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001595 RID: 5525
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask : LuaObject
{
	// Token: 0x06021696 RID: 136854 RVA: 0x00B4B5BC File Offset: 0x00B497BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			TeamRoomAutoMatchNetTaskNetTask o = new TeamRoomAutoMatchNetTaskNetTask(gameFunctionTypeId, locationId);
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

	// Token: 0x06021697 RID: 136855 RVA: 0x00B4B61C File Offset: 0x00B4981C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FrontOfYouWaitingNums(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomAutoMatchNetTaskNetTask teamRoomAutoMatchNetTaskNetTask = (TeamRoomAutoMatchNetTaskNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomAutoMatchNetTaskNetTask.FrontOfYouWaitingNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021698 RID: 136856 RVA: 0x00B4B670 File Offset: 0x00B49870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsEnterRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomAutoMatchNetTaskNetTask teamRoomAutoMatchNetTaskNetTask = (TeamRoomAutoMatchNetTaskNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomAutoMatchNetTaskNetTask.IsEnterRoom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021699 RID: 136857 RVA: 0x00B4B6C4 File Offset: 0x00B498C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomAutoMatchNetTaskNetTask");
		string name = "FrontOfYouWaitingNums";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.get_FrontOfYouWaitingNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache0, null, true);
		string name2 = "IsEnterRoom";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.get_IsEnterRoom);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.<>f__mg$cache2, typeof(TeamRoomAutoMatchNetTaskNetTask), typeof(UINetTask));
	}

	// Token: 0x0401754E RID: 95566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401754F RID: 95567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017550 RID: 95568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
