using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001534 RID: 5428
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerUnblockNetTask : LuaObject
{
	// Token: 0x060205E1 RID: 132577 RVA: 0x00AC5A84 File Offset: 0x00AC3C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			PlayerUnblockNetTask o = new PlayerUnblockNetTask(userID);
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

	// Token: 0x060205E2 RID: 132578 RVA: 0x00AC5AD8 File Offset: 0x00AC3CD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerUnblockNetTask");
		if (Lua_BlackJack_ProjectL_UI_PlayerUnblockNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerUnblockNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerUnblockNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerUnblockNetTask.<>f__mg$cache0, typeof(PlayerUnblockNetTask), typeof(UINetTask));
	}

	// Token: 0x0401655B RID: 91483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
