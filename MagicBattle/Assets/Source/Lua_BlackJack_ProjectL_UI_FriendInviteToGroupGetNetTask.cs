using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001451 RID: 5201
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask : LuaObject
{
	// Token: 0x0601DF25 RID: 122661 RVA: 0x00991D84 File Offset: 0x0098FF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string chatGroupID;
			LuaObject.checkType(l, 2, out chatGroupID);
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 3, out userIDList);
			FriendInviteToGroupGetNetTask o = new FriendInviteToGroupGetNetTask(chatGroupID, userIDList);
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

	// Token: 0x0601DF26 RID: 122662 RVA: 0x00991DE4 File Offset: 0x0098FFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendInviteToGroupGetNetTask friendInviteToGroupGetNetTask = (FriendInviteToGroupGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendInviteToGroupGetNetTask.ChatGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF27 RID: 122663 RVA: 0x00991E38 File Offset: 0x00990038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FailedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendInviteToGroupGetNetTask friendInviteToGroupGetNetTask = (FriendInviteToGroupGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendInviteToGroupGetNetTask.FailedUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF28 RID: 122664 RVA: 0x00991E8C File Offset: 0x0099008C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendInviteToGroupGetNetTask");
		string name = "ChatGroupInfo";
		if (Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.get_ChatGroupInfo);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache0, null, true);
		string name2 = "FailedUser";
		if (Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.get_FailedUser);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.<>f__mg$cache2, typeof(FriendInviteToGroupGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04014065 RID: 82021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014066 RID: 82022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014067 RID: 82023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
