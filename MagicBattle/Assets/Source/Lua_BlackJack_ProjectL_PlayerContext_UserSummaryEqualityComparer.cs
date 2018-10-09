using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E9 RID: 4841
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_UserSummaryEqualityComparer : LuaObject
{
	// Token: 0x0601A140 RID: 106816 RVA: 0x007A9974 File Offset: 0x007A7B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UserSummaryEqualityComparer o = new UserSummaryEqualityComparer();
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

	// Token: 0x0601A141 RID: 106817 RVA: 0x007A99BC File Offset: 0x007A7BBC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.UserSummaryEqualityComparer");
		if (Lua_BlackJack_ProjectL_PlayerContext_UserSummaryEqualityComparer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_UserSummaryEqualityComparer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_UserSummaryEqualityComparer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_UserSummaryEqualityComparer.<>f__mg$cache0, typeof(UserSummaryEqualityComparer));
	}

	// Token: 0x04010550 RID: 66896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
