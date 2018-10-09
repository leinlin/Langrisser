using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200138E RID: 5006
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AutoEquipNetTask : LuaObject
{
	// Token: 0x0601B4C2 RID: 111810 RVA: 0x00840700 File Offset: 0x0083E900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			AutoEquipNetTask o = new AutoEquipNetTask(heroId);
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

	// Token: 0x0601B4C3 RID: 111811 RVA: 0x00840754 File Offset: 0x0083E954
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AutoEquipNetTask");
		if (Lua_BlackJack_ProjectL_UI_AutoEquipNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AutoEquipNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AutoEquipNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AutoEquipNetTask.<>f__mg$cache0, typeof(AutoEquipNetTask), typeof(UINetTask));
	}

	// Token: 0x04011788 RID: 71560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
