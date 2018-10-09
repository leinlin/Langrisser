using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200146E RID: 5230
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask : LuaObject
{
	// Token: 0x0601E3BF RID: 123839 RVA: 0x009B6550 File Offset: 0x009B4750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string announcement;
			LuaObject.checkType(l, 2, out announcement);
			GuildAnnouncementSetReqNetTask o = new GuildAnnouncementSetReqNetTask(announcement);
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

	// Token: 0x0601E3C0 RID: 123840 RVA: 0x009B65A4 File Offset: 0x009B47A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Announcement(IntPtr l)
	{
		int result;
		try
		{
			GuildAnnouncementSetReqNetTask guildAnnouncementSetReqNetTask = (GuildAnnouncementSetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildAnnouncementSetReqNetTask.Announcement);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C1 RID: 123841 RVA: 0x009B65F8 File Offset: 0x009B47F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildAnnouncementSetReqNetTask");
		string name = "Announcement";
		if (Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.get_Announcement);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.<>f__mg$cache1, typeof(GuildAnnouncementSetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040144C5 RID: 83141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040144C6 RID: 83142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
