using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200144C RID: 5196
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask : LuaObject
{
	// Token: 0x0601DEEB RID: 122603 RVA: 0x009902A8 File Offset: 0x0098E4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string groupName;
			LuaObject.checkType(l, 2, out groupName);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 3, out userIDList);
			FriendGroupCreateNetTask o = new FriendGroupCreateNetTask(groupName, userIDList);
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

	// Token: 0x0601DEEC RID: 122604 RVA: 0x00990308 File Offset: 0x0098E508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupCreateNetTask friendGroupCreateNetTask = (FriendGroupCreateNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupCreateNetTask.ChatGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEED RID: 122605 RVA: 0x0099035C File Offset: 0x0098E55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FailedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupCreateNetTask friendGroupCreateNetTask = (FriendGroupCreateNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupCreateNetTask.FailedUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEEE RID: 122606 RVA: 0x009903B0 File Offset: 0x0098E5B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGroupCreateNetTask");
		string name = "ChatGroupInfo";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.get_ChatGroupInfo);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache0, null, true);
		string name2 = "FailedUser";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.get_FailedUser);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.<>f__mg$cache2, typeof(FriendGroupCreateNetTask), typeof(UINetTask));
	}

	// Token: 0x04014035 RID: 81973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014036 RID: 81974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014037 RID: 81975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
