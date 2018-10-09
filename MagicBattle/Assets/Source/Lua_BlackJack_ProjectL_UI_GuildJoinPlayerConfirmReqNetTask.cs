using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001482 RID: 5250
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinPlayerConfirmReqNetTask : LuaObject
{
	// Token: 0x0601E4F7 RID: 124151 RVA: 0x009BF8EC File Offset: 0x009BDAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string guildID;
			LuaObject.checkType(l, 2, out guildID);
			GuildJoinPlayerConfirmReqNetTask o = new GuildJoinPlayerConfirmReqNetTask(guildID);
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

	// Token: 0x0601E4F8 RID: 124152 RVA: 0x009BF940 File Offset: 0x009BDB40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinPlayerConfirmReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinPlayerConfirmReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinPlayerConfirmReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinPlayerConfirmReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinPlayerConfirmReqNetTask.<>f__mg$cache0, typeof(GuildJoinPlayerConfirmReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145D5 RID: 83413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
