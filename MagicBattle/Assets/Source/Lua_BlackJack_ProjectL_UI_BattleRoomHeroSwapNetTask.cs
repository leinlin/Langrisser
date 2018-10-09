using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013BD RID: 5053
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomHeroSwapNetTask : LuaObject
{
	// Token: 0x0601BEF9 RID: 114425 RVA: 0x0089165C File Offset: 0x0088F85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int fromPosition;
			LuaObject.checkType(l, 2, out fromPosition);
			int toPosition;
			LuaObject.checkType(l, 3, out toPosition);
			BattleRoomHeroSwapNetTask o = new BattleRoomHeroSwapNetTask(fromPosition, toPosition);
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

	// Token: 0x0601BEFA RID: 114426 RVA: 0x008916BC File Offset: 0x0088F8BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomHeroSwapNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomHeroSwapNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomHeroSwapNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomHeroSwapNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomHeroSwapNetTask.<>f__mg$cache0, typeof(BattleRoomHeroSwapNetTask), typeof(UINetTask));
	}

	// Token: 0x04012161 RID: 74081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
