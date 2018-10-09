using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F6 RID: 5366
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask : LuaObject
{
	// Token: 0x0601FB31 RID: 129841 RVA: 0x00A70E94 File Offset: 0x00A6F094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			LevelWayPointBattleFinishNetTask o = new LevelWayPointBattleFinishNetTask(waypointId, battleReport);
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

	// Token: 0x0601FB32 RID: 129842 RVA: 0x00A70EF4 File Offset: 0x00A6F0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			LevelWayPointBattleFinishNetTask levelWayPointBattleFinishNetTask = (LevelWayPointBattleFinishNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelWayPointBattleFinishNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB33 RID: 129843 RVA: 0x00A70F48 File Offset: 0x00A6F148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			LevelWayPointBattleFinishNetTask levelWayPointBattleFinishNetTask = (LevelWayPointBattleFinishNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelWayPointBattleFinishNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB34 RID: 129844 RVA: 0x00A70F9C File Offset: 0x00A6F19C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LevelWayPointBattleFinishNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache0, null, true);
		string name2 = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.<>f__mg$cache2, typeof(LevelWayPointBattleFinishNetTask), typeof(UINetTask));
	}

	// Token: 0x04015B27 RID: 88871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B28 RID: 88872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015B29 RID: 88873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
