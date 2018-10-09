using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001474 RID: 5236
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask : LuaObject
{
	// Token: 0x0601E462 RID: 124002 RVA: 0x009BB718 File Offset: 0x009B9918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string guildID;
			LuaObject.checkType(l, 2, out guildID);
			GuildGetReqNetTask o = new GuildGetReqNetTask(guildID);
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

	// Token: 0x0601E463 RID: 124003 RVA: 0x009BB76C File Offset: 0x009B996C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildGetReqNetTask guildGetReqNetTask = (GuildGetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildGetReqNetTask.GuildInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E464 RID: 124004 RVA: 0x009BB7C0 File Offset: 0x009B99C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildGetReqNetTask");
		string name = "GuildInfo";
		if (Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.get_GuildInfo);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.<>f__mg$cache1, typeof(GuildGetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x0401455C RID: 83292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401455D RID: 83293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
