using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200139B RID: 5019
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleArmyRandomSeedGetNetTask : LuaObject
{
	// Token: 0x0601B7B5 RID: 112565 RVA: 0x00857CFC File Offset: 0x00855EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			BattleArmyRandomSeedGetNetTask o = new BattleArmyRandomSeedGetNetTask(battleId);
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

	// Token: 0x0601B7B6 RID: 112566 RVA: 0x00857D50 File Offset: 0x00855F50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleArmyRandomSeedGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleArmyRandomSeedGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleArmyRandomSeedGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleArmyRandomSeedGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleArmyRandomSeedGetNetTask.<>f__mg$cache0, typeof(BattleArmyRandomSeedGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04011A61 RID: 72289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
