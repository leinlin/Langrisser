using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200144A RID: 5194
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGroupChangeNameNetTask : LuaObject
{
	// Token: 0x0601DEE5 RID: 122597 RVA: 0x00990138 File Offset: 0x0098E338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string chatGroupID;
			LuaObject.checkType(l, 2, out chatGroupID);
			string newName;
			LuaObject.checkType(l, 3, out newName);
			FriendGroupChangeNameNetTask o = new FriendGroupChangeNameNetTask(chatGroupID, newName);
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

	// Token: 0x0601DEE6 RID: 122598 RVA: 0x00990198 File Offset: 0x0098E398
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGroupChangeNameNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendGroupChangeNameNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupChangeNameNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupChangeNameNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendGroupChangeNameNetTask.<>f__mg$cache0, typeof(FriendGroupChangeNameNetTask), typeof(UINetTask));
	}

	// Token: 0x04014033 RID: 81971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
