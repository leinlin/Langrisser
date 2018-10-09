using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001444 RID: 5188
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendAddNetTask : LuaObject
{
	// Token: 0x0601DE70 RID: 122480 RVA: 0x0098C954 File Offset: 0x0098AB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			FriendAddNetTask o = new FriendAddNetTask(userIDList);
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

	// Token: 0x0601DE71 RID: 122481 RVA: 0x0098C9A8 File Offset: 0x0098ABA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserIdLIst(IntPtr l)
	{
		int result;
		try
		{
			FriendAddNetTask friendAddNetTask = (FriendAddNetTask)LuaObject.checkSelf(l);
			List<string> userIdLIst = friendAddNetTask.GetUserIdLIst();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userIdLIst);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE72 RID: 122482 RVA: 0x0098C9FC File Offset: 0x0098ABFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FailedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendAddNetTask friendAddNetTask = (FriendAddNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendAddNetTask.FailedUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DE73 RID: 122483 RVA: 0x0098CA50 File Offset: 0x0098AC50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendAddNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendAddNetTask.GetUserIdLIst);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache0);
		string name = "FailedUser";
		if (Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendAddNetTask.get_FailedUser);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendAddNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendAddNetTask.<>f__mg$cache2, typeof(FriendAddNetTask), typeof(UINetTask));
	}

	// Token: 0x04013FCA RID: 81866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013FCB RID: 81867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013FCC RID: 81868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
