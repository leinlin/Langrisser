using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200135C RID: 4956
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AllGuildJoinInvitationRefuseReqNetTask : LuaObject
{
	// Token: 0x0601AB27 RID: 109351 RVA: 0x007F3D0C File Offset: 0x007F1F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AllGuildJoinInvitationRefuseReqNetTask o = new AllGuildJoinInvitationRefuseReqNetTask();
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

	// Token: 0x0601AB28 RID: 109352 RVA: 0x007F3D54 File Offset: 0x007F1F54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AllGuildJoinInvitationRefuseReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_AllGuildJoinInvitationRefuseReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AllGuildJoinInvitationRefuseReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AllGuildJoinInvitationRefuseReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AllGuildJoinInvitationRefuseReqNetTask.<>f__mg$cache0, typeof(AllGuildJoinInvitationRefuseReqNetTask), typeof(UINetTask));
	}

	// Token: 0x04010E51 RID: 69201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
