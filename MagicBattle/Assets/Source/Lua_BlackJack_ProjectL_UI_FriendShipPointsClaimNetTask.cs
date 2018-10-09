using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001454 RID: 5204
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask : LuaObject
{
	// Token: 0x0601DF30 RID: 122672 RVA: 0x0099209C File Offset: 0x0099029C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			FriendShipPointsClaimNetTask o = new FriendShipPointsClaimNetTask(userIDList);
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

	// Token: 0x0601DF31 RID: 122673 RVA: 0x009920F0 File Offset: 0x009902F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetFriendshipPointPlayerCount(IntPtr l)
	{
		int result;
		try
		{
			FriendShipPointsClaimNetTask friendShipPointsClaimNetTask = (FriendShipPointsClaimNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendShipPointsClaimNetTask.GetFriendshipPointPlayerCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF32 RID: 122674 RVA: 0x00992144 File Offset: 0x00990344
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendShipPointsClaimNetTask");
		string name = "GetFriendshipPointPlayerCount";
		if (Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.get_GetFriendshipPointPlayerCount);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.<>f__mg$cache1, typeof(FriendShipPointsClaimNetTask), typeof(UINetTask));
	}

	// Token: 0x0401406A RID: 82026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401406B RID: 82027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
