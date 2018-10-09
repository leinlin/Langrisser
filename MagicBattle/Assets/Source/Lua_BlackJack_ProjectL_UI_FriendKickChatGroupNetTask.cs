using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001452 RID: 5202
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendKickChatGroupNetTask : LuaObject
{
	// Token: 0x0601DF2A RID: 122666 RVA: 0x00991F38 File Offset: 0x00990138
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
			FriendKickChatGroupNetTask o = new FriendKickChatGroupNetTask(chatGroupID, userID);
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

	// Token: 0x0601DF2B RID: 122667 RVA: 0x00991F98 File Offset: 0x00990198
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendKickChatGroupNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendKickChatGroupNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendKickChatGroupNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendKickChatGroupNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendKickChatGroupNetTask.<>f__mg$cache0, typeof(FriendKickChatGroupNetTask), typeof(UINetTask));
	}

	// Token: 0x04014068 RID: 82024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
