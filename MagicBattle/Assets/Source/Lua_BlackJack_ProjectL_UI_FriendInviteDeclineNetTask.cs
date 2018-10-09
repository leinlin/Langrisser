using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001450 RID: 5200
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendInviteDeclineNetTask : LuaObject
{
	// Token: 0x0601DF22 RID: 122658 RVA: 0x00991CD8 File Offset: 0x0098FED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			FriendInviteDeclineNetTask o = new FriendInviteDeclineNetTask(userIDList);
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

	// Token: 0x0601DF23 RID: 122659 RVA: 0x00991D2C File Offset: 0x0098FF2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendInviteDeclineNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendInviteDeclineNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendInviteDeclineNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendInviteDeclineNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendInviteDeclineNetTask.<>f__mg$cache0, typeof(FriendInviteDeclineNetTask), typeof(UINetTask));
	}

	// Token: 0x04014064 RID: 82020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
