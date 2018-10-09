using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001479 RID: 5241
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask : LuaObject
{
	// Token: 0x0601E4CD RID: 124109 RVA: 0x009BEBF4 File Offset: 0x009BCDF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildInvitePlayerListReqNetTask o = new GuildInvitePlayerListReqNetTask();
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

	// Token: 0x0601E4CE RID: 124110 RVA: 0x009BEC3C File Offset: 0x009BCE3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildInvitePlayerListReqNetTask guildInvitePlayerListReqNetTask = (GuildInvitePlayerListReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInvitePlayerListReqNetTask.PlayerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4CF RID: 124111 RVA: 0x009BEC90 File Offset: 0x009BCE90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildInvitePlayerListReqNetTask");
		string name = "PlayerList";
		if (Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.get_PlayerList);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.<>f__mg$cache1, typeof(GuildInvitePlayerListReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145BD RID: 83389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145BE RID: 83390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
