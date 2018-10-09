using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013B8 RID: 5048
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomGetNetTask : LuaObject
{
	// Token: 0x0601BEEA RID: 114410 RVA: 0x00891300 File Offset: 0x0088F500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomGetNetTask o = new BattleRoomGetNetTask();
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

	// Token: 0x0601BEEB RID: 114411 RVA: 0x00891348 File Offset: 0x0088F548
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomGetNetTask.<>f__mg$cache0, typeof(BattleRoomGetNetTask), typeof(UINetTask));
	}

	// Token: 0x0401215C RID: 74076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
