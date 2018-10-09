using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013B7 RID: 5047
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomEndCurrentBPTurnNetTask : LuaObject
{
	// Token: 0x0601BEE7 RID: 114407 RVA: 0x00891260 File Offset: 0x0088F460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomEndCurrentBPTurnNetTask o = new BattleRoomEndCurrentBPTurnNetTask();
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

	// Token: 0x0601BEE8 RID: 114408 RVA: 0x008912A8 File Offset: 0x0088F4A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomEndCurrentBPTurnNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomEndCurrentBPTurnNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomEndCurrentBPTurnNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomEndCurrentBPTurnNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomEndCurrentBPTurnNetTask.<>f__mg$cache0, typeof(BattleRoomEndCurrentBPTurnNetTask), typeof(UINetTask));
	}

	// Token: 0x0401215B RID: 74075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
