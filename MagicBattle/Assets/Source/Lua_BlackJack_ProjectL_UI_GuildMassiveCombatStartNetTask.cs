using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200148C RID: 5260
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStartNetTask : LuaObject
{
	// Token: 0x0601E6FF RID: 124671 RVA: 0x009CFBD8 File Offset: 0x009CDDD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int difficulty;
			LuaObject.checkType(l, 2, out difficulty);
			GuildMassiveCombatStartNetTask o = new GuildMassiveCombatStartNetTask(difficulty);
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

	// Token: 0x0601E700 RID: 124672 RVA: 0x009CFC2C File Offset: 0x009CDE2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatStartNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStartNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStartNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStartNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStartNetTask.<>f__mg$cache0, typeof(GuildMassiveCombatStartNetTask), typeof(UINetTask));
	}

	// Token: 0x040147C9 RID: 83913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
