using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200149A RID: 5274
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask : LuaObject
{
	// Token: 0x0601E882 RID: 125058 RVA: 0x009DB93C File Offset: 0x009D9B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string searchText;
			LuaObject.checkType(l, 2, out searchText);
			GuildSearchReqNetTask o = new GuildSearchReqNetTask(searchText);
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

	// Token: 0x0601E883 RID: 125059 RVA: 0x009DB990 File Offset: 0x009D9B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSearchInfoList(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchReqNetTask guildSearchReqNetTask = (GuildSearchReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildSearchReqNetTask.m_guildSearchInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E884 RID: 125060 RVA: 0x009DB9E4 File Offset: 0x009D9BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildSearchInfoList(IntPtr l)
	{
		int result;
		try
		{
			GuildSearchReqNetTask guildSearchReqNetTask = (GuildSearchReqNetTask)LuaObject.checkSelf(l);
			List<GuildSearchInfo> guildSearchInfoList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildSearchInfoList);
			guildSearchReqNetTask.m_guildSearchInfoList = guildSearchInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E885 RID: 125061 RVA: 0x009DBA3C File Offset: 0x009D9C3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildSearchReqNetTask");
		string name = "m_guildSearchInfoList";
		if (Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.get_m_guildSearchInfoList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.set_m_guildSearchInfoList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.<>f__mg$cache2, typeof(GuildSearchReqNetTask), typeof(UINetTask));
	}

	// Token: 0x04014930 RID: 84272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014931 RID: 84273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014932 RID: 84274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
