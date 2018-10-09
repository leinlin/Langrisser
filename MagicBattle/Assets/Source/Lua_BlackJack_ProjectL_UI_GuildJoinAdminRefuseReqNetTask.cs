using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200147B RID: 5243
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinAdminRefuseReqNetTask : LuaObject
{
	// Token: 0x0601E4D4 RID: 124116 RVA: 0x009BEDC0 File Offset: 0x009BCFC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			GuildJoinAdminRefuseReqNetTask o = new GuildJoinAdminRefuseReqNetTask(userID);
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

	// Token: 0x0601E4D5 RID: 124117 RVA: 0x009BEE14 File Offset: 0x009BD014
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinAdminRefuseReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinAdminRefuseReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinAdminRefuseReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinAdminRefuseReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinAdminRefuseReqNetTask.<>f__mg$cache0, typeof(GuildJoinAdminRefuseReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145C0 RID: 83392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
