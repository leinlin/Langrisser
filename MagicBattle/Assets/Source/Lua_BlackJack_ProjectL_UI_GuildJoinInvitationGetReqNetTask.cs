using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200147F RID: 5247
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask : LuaObject
{
	// Token: 0x0601E4EC RID: 124140 RVA: 0x009BF600 File Offset: 0x009BD800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitationGetReqNetTask o = new GuildJoinInvitationGetReqNetTask();
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

	// Token: 0x0601E4ED RID: 124141 RVA: 0x009BF648 File Offset: 0x009BD848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinInvitationList(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitationGetReqNetTask guildJoinInvitationGetReqNetTask = (GuildJoinInvitationGetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinInvitationGetReqNetTask.m_guildJoinInvitationList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4EE RID: 124142 RVA: 0x009BF69C File Offset: 0x009BD89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinInvitationList(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinInvitationGetReqNetTask guildJoinInvitationGetReqNetTask = (GuildJoinInvitationGetReqNetTask)LuaObject.checkSelf(l);
			List<GuildJoinInvitation> guildJoinInvitationList;
			LuaObject.checkType<List<GuildJoinInvitation>>(l, 2, out guildJoinInvitationList);
			guildJoinInvitationGetReqNetTask.m_guildJoinInvitationList = guildJoinInvitationList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4EF RID: 124143 RVA: 0x009BF6F4 File Offset: 0x009BD8F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinInvitationGetReqNetTask");
		string name = "m_guildJoinInvitationList";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.get_m_guildJoinInvitationList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.set_m_guildJoinInvitationList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.<>f__mg$cache2, typeof(GuildJoinInvitationGetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145D0 RID: 83408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145D1 RID: 83409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040145D2 RID: 83410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
