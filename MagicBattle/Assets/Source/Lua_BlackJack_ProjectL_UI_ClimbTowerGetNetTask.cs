using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F4 RID: 5108
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerGetNetTask : LuaObject
{
	// Token: 0x0601CB46 RID: 117574 RVA: 0x008F33B4 File Offset: 0x008F15B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerGetNetTask o = new ClimbTowerGetNetTask();
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

	// Token: 0x0601CB47 RID: 117575 RVA: 0x008F33FC File Offset: 0x008F15FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerGetNetTask.<>f__mg$cache0, typeof(ClimbTowerGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04012D40 RID: 77120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
