using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200137C RID: 4988
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaPlayerSetDefensiveTeamNetTask : LuaObject
{
	// Token: 0x0601AFE8 RID: 110568 RVA: 0x00819B94 File Offset: 0x00817D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int arenaDefenderRuleId;
			LuaObject.checkType(l, 2, out arenaDefenderRuleId);
			int battleId;
			LuaObject.checkType(l, 3, out battleId);
			List<ArenaPlayerDefensiveHero> defensiveHeroes;
			LuaObject.checkType<List<ArenaPlayerDefensiveHero>>(l, 4, out defensiveHeroes);
			ArenaPlayerSetDefensiveTeamNetTask o = new ArenaPlayerSetDefensiveTeamNetTask(arenaDefenderRuleId, battleId, defensiveHeroes);
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

	// Token: 0x0601AFE9 RID: 110569 RVA: 0x00819C04 File Offset: 0x00817E04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaPlayerSetDefensiveTeamNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaPlayerSetDefensiveTeamNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPlayerSetDefensiveTeamNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPlayerSetDefensiveTeamNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaPlayerSetDefensiveTeamNetTask.<>f__mg$cache0, typeof(ArenaPlayerSetDefensiveTeamNetTask), typeof(UINetTask));
	}

	// Token: 0x040112D2 RID: 70354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
