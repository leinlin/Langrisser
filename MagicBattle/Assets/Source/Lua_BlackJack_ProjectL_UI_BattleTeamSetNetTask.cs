using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013C6 RID: 5062
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleTeamSetNetTask : LuaObject
{
	// Token: 0x0601C0AF RID: 114863 RVA: 0x0089F074 File Offset: 0x0089D274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			List<int> heros;
			LuaObject.checkType<List<int>>(l, 4, out heros);
			BattleTeamSetNetTask o = new BattleTeamSetNetTask(battleType, battleId, heros);
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

	// Token: 0x0601C0B0 RID: 114864 RVA: 0x0089F0E4 File Offset: 0x0089D2E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleTeamSetNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleTeamSetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleTeamSetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleTeamSetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleTeamSetNetTask.<>f__mg$cache0, typeof(BattleTeamSetNetTask), typeof(UINetTask));
	}

	// Token: 0x04012305 RID: 74501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
