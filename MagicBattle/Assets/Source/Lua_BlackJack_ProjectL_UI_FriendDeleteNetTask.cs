using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001446 RID: 5190
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendDeleteNetTask : LuaObject
{
	// Token: 0x0601DED7 RID: 122583 RVA: 0x0098FD88 File Offset: 0x0098DF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			FriendDeleteNetTask o = new FriendDeleteNetTask(userID);
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

	// Token: 0x0601DED8 RID: 122584 RVA: 0x0098FDDC File Offset: 0x0098DFDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendDeleteNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendDeleteNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendDeleteNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendDeleteNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendDeleteNetTask.<>f__mg$cache0, typeof(FriendDeleteNetTask), typeof(UINetTask));
	}

	// Token: 0x0401402D RID: 81965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
