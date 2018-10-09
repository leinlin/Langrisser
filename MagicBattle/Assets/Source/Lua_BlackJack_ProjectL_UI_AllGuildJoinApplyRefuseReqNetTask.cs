using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200135B RID: 4955
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AllGuildJoinApplyRefuseReqNetTask : LuaObject
{
	// Token: 0x0601AB24 RID: 109348 RVA: 0x007F3C6C File Offset: 0x007F1E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AllGuildJoinApplyRefuseReqNetTask o = new AllGuildJoinApplyRefuseReqNetTask();
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

	// Token: 0x0601AB25 RID: 109349 RVA: 0x007F3CB4 File Offset: 0x007F1EB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AllGuildJoinApplyRefuseReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_AllGuildJoinApplyRefuseReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AllGuildJoinApplyRefuseReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AllGuildJoinApplyRefuseReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AllGuildJoinApplyRefuseReqNetTask.<>f__mg$cache0, typeof(AllGuildJoinApplyRefuseReqNetTask), typeof(UINetTask));
	}

	// Token: 0x04010E50 RID: 69200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
