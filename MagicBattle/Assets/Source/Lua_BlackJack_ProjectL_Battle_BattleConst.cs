using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001193 RID: 4499
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleConst : LuaObject
{
	// Token: 0x060173AF RID: 95151 RVA: 0x0064C3EC File Offset: 0x0064A5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleConst o = new BattleConst();
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

	// Token: 0x060173B0 RID: 95152 RVA: 0x0064C434 File Offset: 0x0064A634
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleConst");
		if (Lua_BlackJack_ProjectL_Battle_BattleConst.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleConst.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleConst.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleConst.<>f__mg$cache0, typeof(BattleConst));
	}

	// Token: 0x0400DA6B RID: 55915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
