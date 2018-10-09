using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001484 RID: 5252
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildKickOutReqNetTask : LuaObject
{
	// Token: 0x0601E50F RID: 124175 RVA: 0x009C0528 File Offset: 0x009BE728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userId;
			LuaObject.checkType(l, 2, out userId);
			GuildKickOutReqNetTask o = new GuildKickOutReqNetTask(userId);
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

	// Token: 0x0601E510 RID: 124176 RVA: 0x009C057C File Offset: 0x009BE77C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildKickOutReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildKickOutReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildKickOutReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildKickOutReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildKickOutReqNetTask.<>f__mg$cache0, typeof(GuildKickOutReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145E9 RID: 83433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
