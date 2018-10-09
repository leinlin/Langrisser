using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001481 RID: 5249
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinInviteReqNetTask : LuaObject
{
	// Token: 0x0601E4F4 RID: 124148 RVA: 0x009BF840 File Offset: 0x009BDA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userId;
			LuaObject.checkType(l, 2, out userId);
			GuildJoinInviteReqNetTask o = new GuildJoinInviteReqNetTask(userId);
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

	// Token: 0x0601E4F5 RID: 124149 RVA: 0x009BF894 File Offset: 0x009BDA94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinInviteReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInviteReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInviteReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInviteReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinInviteReqNetTask.<>f__mg$cache0, typeof(GuildJoinInviteReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145D4 RID: 83412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
