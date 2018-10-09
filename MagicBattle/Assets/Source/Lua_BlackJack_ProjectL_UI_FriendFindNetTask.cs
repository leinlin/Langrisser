using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001447 RID: 5191
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendFindNetTask : LuaObject
{
	// Token: 0x0601DEDA RID: 122586 RVA: 0x0098FE34 File Offset: 0x0098E034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int bornChannelID;
			LuaObject.checkType(l, 2, out bornChannelID);
			string partialName;
			LuaObject.checkType(l, 3, out partialName);
			FriendFindNetTask o = new FriendFindNetTask(bornChannelID, partialName);
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

	// Token: 0x0601DEDB RID: 122587 RVA: 0x0098FE94 File Offset: 0x0098E094
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendFindNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendFindNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendFindNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendFindNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendFindNetTask.<>f__mg$cache0, typeof(FriendFindNetTask), typeof(UINetTask));
	}

	// Token: 0x0401402E RID: 81966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
