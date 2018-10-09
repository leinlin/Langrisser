using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001453 RID: 5203
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendLeaveChatGroupNetTask : LuaObject
{
	// Token: 0x0601DF2D RID: 122669 RVA: 0x00991FF0 File Offset: 0x009901F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string chatGroupID;
			LuaObject.checkType(l, 2, out chatGroupID);
			FriendLeaveChatGroupNetTask o = new FriendLeaveChatGroupNetTask(chatGroupID);
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

	// Token: 0x0601DF2E RID: 122670 RVA: 0x00992044 File Offset: 0x00990244
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendLeaveChatGroupNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendLeaveChatGroupNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendLeaveChatGroupNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendLeaveChatGroupNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendLeaveChatGroupNetTask.<>f__mg$cache0, typeof(FriendLeaveChatGroupNetTask), typeof(UINetTask));
	}

	// Token: 0x04014069 RID: 82025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
