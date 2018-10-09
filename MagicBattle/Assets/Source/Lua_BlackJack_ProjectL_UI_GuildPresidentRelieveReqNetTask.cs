using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001494 RID: 5268
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildPresidentRelieveReqNetTask : LuaObject
{
	// Token: 0x0601E7FD RID: 124925 RVA: 0x009D78A8 File Offset: 0x009D5AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userId;
			LuaObject.checkType(l, 2, out userId);
			GuildPresidentRelieveReqNetTask o = new GuildPresidentRelieveReqNetTask(userId);
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

	// Token: 0x0601E7FE RID: 124926 RVA: 0x009D78FC File Offset: 0x009D5AFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildPresidentRelieveReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildPresidentRelieveReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildPresidentRelieveReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildPresidentRelieveReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildPresidentRelieveReqNetTask.<>f__mg$cache0, typeof(GuildPresidentRelieveReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040148B7 RID: 84151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
