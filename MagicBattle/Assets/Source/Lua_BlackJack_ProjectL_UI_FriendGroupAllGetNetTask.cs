using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001449 RID: 5193
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask : LuaObject
{
	// Token: 0x0601DEE1 RID: 122593 RVA: 0x00990018 File Offset: 0x0098E218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupAllGetNetTask o = new FriendGroupAllGetNetTask();
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

	// Token: 0x0601DEE2 RID: 122594 RVA: 0x00990060 File Offset: 0x0098E260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatGroupList(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupAllGetNetTask friendGroupAllGetNetTask = (FriendGroupAllGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupAllGetNetTask.ChatGroupList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEE3 RID: 122595 RVA: 0x009900B4 File Offset: 0x0098E2B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGroupAllGetNetTask");
		string name = "ChatGroupList";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.get_ChatGroupList);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.<>f__mg$cache1, typeof(FriendGroupAllGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04014031 RID: 81969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014032 RID: 81970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
