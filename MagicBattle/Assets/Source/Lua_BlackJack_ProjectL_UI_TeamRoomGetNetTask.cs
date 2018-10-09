using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001597 RID: 5527
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask : LuaObject
{
	// Token: 0x0602169E RID: 136862 RVA: 0x00B4B81C File Offset: 0x00B49A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomGetNetTask o = new TeamRoomGetNetTask();
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

	// Token: 0x0602169F RID: 136863 RVA: 0x00B4B864 File Offset: 0x00B49A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FrontOfYouWaitingNums(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomGetNetTask teamRoomGetNetTask = (TeamRoomGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomGetNetTask.FrontOfYouWaitingNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060216A0 RID: 136864 RVA: 0x00B4B8B8 File Offset: 0x00B49AB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomGetNetTask");
		string name = "FrontOfYouWaitingNums";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.get_FrontOfYouWaitingNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.<>f__mg$cache1, typeof(TeamRoomGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04017552 RID: 95570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017553 RID: 95571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
