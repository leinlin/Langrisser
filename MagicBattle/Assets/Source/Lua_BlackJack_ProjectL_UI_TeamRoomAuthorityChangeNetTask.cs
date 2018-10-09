using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001593 RID: 5523
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomAuthorityChangeNetTask : LuaObject
{
	// Token: 0x06021690 RID: 136848 RVA: 0x00B4B470 File Offset: 0x00B49670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			TeamRoomAuthorityChangeNetTask o = new TeamRoomAuthorityChangeNetTask(authority);
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

	// Token: 0x06021691 RID: 136849 RVA: 0x00B4B4C4 File Offset: 0x00B496C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomAuthorityChangeNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomAuthorityChangeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomAuthorityChangeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomAuthorityChangeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomAuthorityChangeNetTask.<>f__mg$cache0, typeof(TeamRoomAuthorityChangeNetTask), typeof(UINetTask));
	}

	// Token: 0x0401754C RID: 95564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
