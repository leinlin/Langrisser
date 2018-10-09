using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200144D RID: 5197
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask : LuaObject
{
	// Token: 0x0601DEF0 RID: 122608 RVA: 0x0099045C File Offset: 0x0098E65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string chatGroupID;
			LuaObject.checkType(l, 2, out chatGroupID);
			FriendGroupMemberGetNetTask o = new FriendGroupMemberGetNetTask(chatGroupID);
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

	// Token: 0x0601DEF1 RID: 122609 RVA: 0x009904B0 File Offset: 0x0098E6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupMemberGetNetTask friendGroupMemberGetNetTask = (FriendGroupMemberGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupMemberGetNetTask.ChatGroupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEF2 RID: 122610 RVA: 0x00990504 File Offset: 0x0098E704
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGroupMemberGetNetTask");
		string name = "ChatGroupInfo";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.get_ChatGroupInfo);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.<>f__mg$cache1, typeof(FriendGroupMemberGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04014038 RID: 81976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014039 RID: 81977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
