using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001448 RID: 5192
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask : LuaObject
{
	// Token: 0x0601DEDD RID: 122589 RVA: 0x0098FEEC File Offset: 0x0098E0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> playerIdList;
			LuaObject.checkType<List<string>>(l, 2, out playerIdList);
			FriendGetUserSummaryReqNetTask o = new FriendGetUserSummaryReqNetTask(playerIdList);
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

	// Token: 0x0601DEDE RID: 122590 RVA: 0x0098FF40 File Offset: 0x0098E140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Players(IntPtr l)
	{
		int result;
		try
		{
			FriendGetUserSummaryReqNetTask friendGetUserSummaryReqNetTask = (FriendGetUserSummaryReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGetUserSummaryReqNetTask.Players);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEDF RID: 122591 RVA: 0x0098FF94 File Offset: 0x0098E194
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGetUserSummaryReqNetTask");
		string name = "Players";
		if (Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.get_Players);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.<>f__mg$cache1, typeof(FriendGetUserSummaryReqNetTask), typeof(UINetTask));
	}

	// Token: 0x0401402F RID: 81967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014030 RID: 81968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
