using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F8 RID: 5368
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LikeNetTask : LuaObject
{
	// Token: 0x0601FB3A RID: 129850 RVA: 0x00A71174 File Offset: 0x00A6F374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			LikeNetTask o = new LikeNetTask(userID);
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

	// Token: 0x0601FB3B RID: 129851 RVA: 0x00A711C8 File Offset: 0x00A6F3C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LikeNetTask");
		if (Lua_BlackJack_ProjectL_UI_LikeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LikeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LikeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LikeNetTask.<>f__mg$cache0, typeof(LikeNetTask), typeof(UINetTask));
	}

	// Token: 0x04015B2C RID: 88876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
