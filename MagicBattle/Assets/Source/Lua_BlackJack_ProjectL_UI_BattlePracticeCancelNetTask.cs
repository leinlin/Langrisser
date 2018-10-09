using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013A9 RID: 5033
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePracticeCancelNetTask : LuaObject
{
	// Token: 0x0601BACC RID: 113356 RVA: 0x00870828 File Offset: 0x0086EA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattlePracticeCancelNetTask o = new BattlePracticeCancelNetTask();
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

	// Token: 0x0601BACD RID: 113357 RVA: 0x00870870 File Offset: 0x0086EA70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePracticeCancelNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattlePracticeCancelNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePracticeCancelNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePracticeCancelNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattlePracticeCancelNetTask.<>f__mg$cache0, typeof(BattlePracticeCancelNetTask), typeof(UINetTask));
	}

	// Token: 0x04011D5C RID: 73052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
