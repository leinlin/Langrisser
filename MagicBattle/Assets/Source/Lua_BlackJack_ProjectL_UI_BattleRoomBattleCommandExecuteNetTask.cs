using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013B6 RID: 5046
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomBattleCommandExecuteNetTask : LuaObject
{
	// Token: 0x0601BEE4 RID: 114404 RVA: 0x008911B4 File Offset: 0x0088F3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LinkedList<BattleCommand> commands;
			LuaObject.checkType<LinkedList<BattleCommand>>(l, 2, out commands);
			BattleRoomBattleCommandExecuteNetTask o = new BattleRoomBattleCommandExecuteNetTask(commands);
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

	// Token: 0x0601BEE5 RID: 114405 RVA: 0x00891208 File Offset: 0x0088F408
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomBattleCommandExecuteNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomBattleCommandExecuteNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomBattleCommandExecuteNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomBattleCommandExecuteNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomBattleCommandExecuteNetTask.<>f__mg$cache0, typeof(BattleRoomBattleCommandExecuteNetTask), typeof(UINetTask));
	}

	// Token: 0x0401215A RID: 74074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
