using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001486 RID: 5254
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask : LuaObject
{
	// Token: 0x0601E526 RID: 124198 RVA: 0x009C10EC File Offset: 0x009BF2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildLogGetReqNetTask o = new GuildLogGetReqNetTask();
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

	// Token: 0x0601E527 RID: 124199 RVA: 0x009C1134 File Offset: 0x009BF334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildLogs(IntPtr l)
	{
		int result;
		try
		{
			GuildLogGetReqNetTask guildLogGetReqNetTask = (GuildLogGetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildLogGetReqNetTask.GuildLogs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E528 RID: 124200 RVA: 0x009C1188 File Offset: 0x009BF388
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildLogGetReqNetTask");
		string name = "GuildLogs";
		if (Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.get_GuildLogs);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.<>f__mg$cache1, typeof(GuildLogGetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145FC RID: 83452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145FD RID: 83453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
