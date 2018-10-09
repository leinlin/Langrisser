using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001495 RID: 5269
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildQuitReqNetTask : LuaObject
{
	// Token: 0x0601E800 RID: 124928 RVA: 0x009D7954 File Offset: 0x009D5B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildQuitReqNetTask o = new GuildQuitReqNetTask();
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

	// Token: 0x0601E801 RID: 124929 RVA: 0x009D799C File Offset: 0x009D5B9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildQuitReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildQuitReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildQuitReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildQuitReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildQuitReqNetTask.<>f__mg$cache0, typeof(GuildQuitReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040148B8 RID: 84152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
