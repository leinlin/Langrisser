using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001380 RID: 4992
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask : LuaObject
{
	// Token: 0x0601B045 RID: 110661 RVA: 0x0081CCD4 File Offset: 0x0081AED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong arenaBattleReportInstanceId;
			LuaObject.checkType(l, 2, out arenaBattleReportInstanceId);
			ArenaRevengeOpponentGetNetTask o = new ArenaRevengeOpponentGetNetTask(arenaBattleReportInstanceId);
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

	// Token: 0x0601B046 RID: 110662 RVA: 0x0081CD28 File Offset: 0x0081AF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heros(IntPtr l)
	{
		int result;
		try
		{
			ArenaRevengeOpponentGetNetTask arenaRevengeOpponentGetNetTask = (ArenaRevengeOpponentGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRevengeOpponentGetNetTask.Heros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B047 RID: 110663 RVA: 0x0081CD7C File Offset: 0x0081AF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePower(IntPtr l)
	{
		int result;
		try
		{
			ArenaRevengeOpponentGetNetTask arenaRevengeOpponentGetNetTask = (ArenaRevengeOpponentGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRevengeOpponentGetNetTask.BattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B048 RID: 110664 RVA: 0x0081CDD0 File Offset: 0x0081AFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaOpponent(IntPtr l)
	{
		int result;
		try
		{
			ArenaRevengeOpponentGetNetTask arenaRevengeOpponentGetNetTask = (ArenaRevengeOpponentGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRevengeOpponentGetNetTask.ArenaOpponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B049 RID: 110665 RVA: 0x0081CE24 File Offset: 0x0081B024
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaRevengeOpponentGetNetTask");
		string name = "Heros";
		if (Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.get_Heros);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache0, null, true);
		string name2 = "BattlePower";
		if (Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.get_BattlePower);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache1, null, true);
		string name3 = "ArenaOpponent";
		if (Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.get_ArenaOpponent);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache2, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.<>f__mg$cache3, typeof(ArenaRevengeOpponentGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04011327 RID: 70439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011328 RID: 70440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011329 RID: 70441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401132A RID: 70442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
