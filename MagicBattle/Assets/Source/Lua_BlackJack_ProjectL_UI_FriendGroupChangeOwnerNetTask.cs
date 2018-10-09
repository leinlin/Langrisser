using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200144B RID: 5195
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGroupChangeOwnerNetTask : LuaObject
{
	// Token: 0x0601DEE8 RID: 122600 RVA: 0x009901F0 File Offset: 0x0098E3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string chatGroupID;
			LuaObject.checkType(l, 2, out chatGroupID);
			string userID;
			LuaObject.checkType(l, 3, out userID);
			FriendGroupChangeOwnerNetTask o = new FriendGroupChangeOwnerNetTask(chatGroupID, userID);
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

	// Token: 0x0601DEE9 RID: 122601 RVA: 0x00990250 File Offset: 0x0098E450
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGroupChangeOwnerNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendGroupChangeOwnerNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupChangeOwnerNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupChangeOwnerNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendGroupChangeOwnerNetTask.<>f__mg$cache0, typeof(FriendGroupChangeOwnerNetTask), typeof(UINetTask));
	}

	// Token: 0x04014034 RID: 81972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
