using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200148E RID: 5262
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSurrenderNetTask : LuaObject
{
	// Token: 0x0601E728 RID: 124712 RVA: 0x009D1078 File Offset: 0x009CF278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildMassiveCombatSurrenderNetTask o = new GuildMassiveCombatSurrenderNetTask();
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

	// Token: 0x0601E729 RID: 124713 RVA: 0x009D10C0 File Offset: 0x009CF2C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildMassiveCombatSurrenderNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSurrenderNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSurrenderNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSurrenderNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSurrenderNetTask.<>f__mg$cache0, typeof(GuildMassiveCombatSurrenderNetTask), typeof(UINetTask));
	}

	// Token: 0x040147EE RID: 83950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
