using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200144F RID: 5199
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask : LuaObject
{
	// Token: 0x0601DF1E RID: 122654 RVA: 0x00991BAC File Offset: 0x0098FDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			FriendInviteAcceptNetTask o = new FriendInviteAcceptNetTask(userIDList);
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

	// Token: 0x0601DF1F RID: 122655 RVA: 0x00991C00 File Offset: 0x0098FE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FailedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendInviteAcceptNetTask friendInviteAcceptNetTask = (FriendInviteAcceptNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendInviteAcceptNetTask.FailedUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF20 RID: 122656 RVA: 0x00991C54 File Offset: 0x0098FE54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendInviteAcceptNetTask");
		string name = "FailedUser";
		if (Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.get_FailedUser);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.<>f__mg$cache1, typeof(FriendInviteAcceptNetTask), typeof(UINetTask));
	}

	// Token: 0x04014062 RID: 82018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014063 RID: 82019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
