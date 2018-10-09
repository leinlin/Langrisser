using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001489 RID: 5257
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatAttackNetTask : LuaObject
{
	// Token: 0x0601E6D8 RID: 124632 RVA: 0x009CE8B0 File Offset: 0x009CCAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 3, out heroIds);
			GuildMassiveCombatAttackNetTask o = new GuildMassiveCombatAttackNetTask(levelId, heroIds);
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

	// Token: 0x0601E6D9 RID: 124633 RVA: 0x009CE910 File Offset: 0x009CCB10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatAttackNetTask.<>f__mg$cache0, typeof(GuildMassiveCombatAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x040147A8 RID: 83880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
