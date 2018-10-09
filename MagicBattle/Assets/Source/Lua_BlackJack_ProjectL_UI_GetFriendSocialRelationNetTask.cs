using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200145B RID: 5211
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetFriendSocialRelationNetTask : LuaObject
{
	// Token: 0x0601E16F RID: 123247 RVA: 0x009A4170 File Offset: 0x009A2370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FriendSocialRelationFlag friendSocialRelationFlag;
			LuaObject.checkEnum<FriendSocialRelationFlag>(l, 2, out friendSocialRelationFlag);
			GetFriendSocialRelationNetTask o = new GetFriendSocialRelationNetTask(friendSocialRelationFlag);
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

	// Token: 0x0601E170 RID: 123248 RVA: 0x009A41C4 File Offset: 0x009A23C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetFriendSocialRelationNetTask");
		if (Lua_BlackJack_ProjectL_UI_GetFriendSocialRelationNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetFriendSocialRelationNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetFriendSocialRelationNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GetFriendSocialRelationNetTask.<>f__mg$cache0, typeof(GetFriendSocialRelationNetTask), typeof(UINetTask));
	}

	// Token: 0x0401429B RID: 82587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
