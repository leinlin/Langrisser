using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200147A RID: 5242
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinAdminConfirmReqNetTask : LuaObject
{
	// Token: 0x0601E4D1 RID: 124113 RVA: 0x009BED14 File Offset: 0x009BCF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			GuildJoinAdminConfirmReqNetTask o = new GuildJoinAdminConfirmReqNetTask(userID);
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

	// Token: 0x0601E4D2 RID: 124114 RVA: 0x009BED68 File Offset: 0x009BCF68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinAdminConfirmReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinAdminConfirmReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinAdminConfirmReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinAdminConfirmReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinAdminConfirmReqNetTask.<>f__mg$cache0, typeof(GuildJoinAdminConfirmReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145BF RID: 83391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
