using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200147C RID: 5244
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask : LuaObject
{
	// Token: 0x0601E4D7 RID: 124119 RVA: 0x009BEE6C File Offset: 0x009BD06C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinApplyGetReqNetTask o = new GuildJoinApplyGetReqNetTask();
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

	// Token: 0x0601E4D8 RID: 124120 RVA: 0x009BEEB4 File Offset: 0x009BD0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Players(IntPtr l)
	{
		int result;
		try
		{
			GuildJoinApplyGetReqNetTask guildJoinApplyGetReqNetTask = (GuildJoinApplyGetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildJoinApplyGetReqNetTask.Players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E4D9 RID: 124121 RVA: 0x009BEF08 File Offset: 0x009BD108
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinApplyGetReqNetTask");
		string name = "Players";
		if (Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.get_Players);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.<>f__mg$cache1, typeof(GuildJoinApplyGetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145C1 RID: 83393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040145C2 RID: 83394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
