using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001493 RID: 5267
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildPresidentAppointReqNetTask : LuaObject
{
	// Token: 0x0601E7FA RID: 124922 RVA: 0x009D77FC File Offset: 0x009D59FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userId;
			LuaObject.checkType(l, 2, out userId);
			GuildPresidentAppointReqNetTask o = new GuildPresidentAppointReqNetTask(userId);
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

	// Token: 0x0601E7FB RID: 124923 RVA: 0x009D7850 File Offset: 0x009D5A50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildPresidentAppointReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildPresidentAppointReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildPresidentAppointReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildPresidentAppointReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildPresidentAppointReqNetTask.<>f__mg$cache0, typeof(GuildPresidentAppointReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040148B6 RID: 84150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
