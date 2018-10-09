using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F6 RID: 5110
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x0601CB4C RID: 117580 RVA: 0x008F3500 File Offset: 0x008F1700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			ClimbTowerLevelBattleFinishedNetTask o = new ClimbTowerLevelBattleFinishedNetTask(floorId, battleReport);
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

	// Token: 0x0601CB4D RID: 117581 RVA: 0x008F3560 File Offset: 0x008F1760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelBattleFinishedNetTask climbTowerLevelBattleFinishedNetTask = (ClimbTowerLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB4E RID: 117582 RVA: 0x008F35B4 File Offset: 0x008F17B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerLevelBattleFinishedNetTask climbTowerLevelBattleFinishedNetTask = (ClimbTowerLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB4F RID: 117583 RVA: 0x008F3608 File Offset: 0x008F1808
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.<>f__mg$cache2, typeof(ClimbTowerLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04012D42 RID: 77122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012D43 RID: 77123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012D44 RID: 77124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
