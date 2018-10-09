using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001524 RID: 5412
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerBlockNetTask : LuaObject
{
	// Token: 0x0602021A RID: 131610 RVA: 0x00AA7488 File Offset: 0x00AA5688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			PlayerBlockNetTask o = new PlayerBlockNetTask(userID);
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

	// Token: 0x0602021B RID: 131611 RVA: 0x00AA74DC File Offset: 0x00AA56DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerBlockNetTask");
		if (Lua_BlackJack_ProjectL_UI_PlayerBlockNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerBlockNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerBlockNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerBlockNetTask.<>f__mg$cache0, typeof(PlayerBlockNetTask), typeof(UINetTask));
	}

	// Token: 0x040161B4 RID: 90548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
