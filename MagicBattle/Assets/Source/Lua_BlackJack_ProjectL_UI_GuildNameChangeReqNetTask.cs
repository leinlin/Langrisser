using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001492 RID: 5266
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildNameChangeReqNetTask : LuaObject
{
	// Token: 0x0601E7F7 RID: 124919 RVA: 0x009D7750 File Offset: 0x009D5950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			GuildNameChangeReqNetTask o = new GuildNameChangeReqNetTask(name);
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

	// Token: 0x0601E7F8 RID: 124920 RVA: 0x009D77A4 File Offset: 0x009D59A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildNameChangeReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildNameChangeReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildNameChangeReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildNameChangeReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildNameChangeReqNetTask.<>f__mg$cache0, typeof(GuildNameChangeReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040148B5 RID: 84149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
