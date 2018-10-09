using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200139C RID: 5020
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleCancelNetTask : LuaObject
{
	// Token: 0x0601B7B8 RID: 112568 RVA: 0x00857DA8 File Offset: 0x00855FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleCancelNetTask o = new BattleCancelNetTask();
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

	// Token: 0x0601B7B9 RID: 112569 RVA: 0x00857DF0 File Offset: 0x00855FF0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleCancelNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleCancelNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleCancelNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleCancelNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleCancelNetTask.<>f__mg$cache0, typeof(BattleCancelNetTask), typeof(UINetTask));
	}

	// Token: 0x04011A62 RID: 72290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
