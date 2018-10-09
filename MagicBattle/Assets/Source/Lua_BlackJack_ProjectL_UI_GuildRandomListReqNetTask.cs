using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001499 RID: 5273
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask : LuaObject
{
	// Token: 0x0601E87D RID: 125053 RVA: 0x009DB7A8 File Offset: 0x009D99A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildRandomListReqNetTask o = new GuildRandomListReqNetTask();
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

	// Token: 0x0601E87E RID: 125054 RVA: 0x009DB7F0 File Offset: 0x009D99F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildSearchInfoList(IntPtr l)
	{
		int result;
		try
		{
			GuildRandomListReqNetTask guildRandomListReqNetTask = (GuildRandomListReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildRandomListReqNetTask.m_guildSearchInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E87F RID: 125055 RVA: 0x009DB844 File Offset: 0x009D9A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildSearchInfoList(IntPtr l)
	{
		int result;
		try
		{
			GuildRandomListReqNetTask guildRandomListReqNetTask = (GuildRandomListReqNetTask)LuaObject.checkSelf(l);
			List<GuildSearchInfo> guildSearchInfoList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildSearchInfoList);
			guildRandomListReqNetTask.m_guildSearchInfoList = guildSearchInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E880 RID: 125056 RVA: 0x009DB89C File Offset: 0x009D9A9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildRandomListReqNetTask");
		string name = "m_guildSearchInfoList";
		if (Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.get_m_guildSearchInfoList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.set_m_guildSearchInfoList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.<>f__mg$cache2, typeof(GuildRandomListReqNetTask), typeof(UINetTask));
	}

	// Token: 0x0401492D RID: 84269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401492E RID: 84270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401492F RID: 84271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
