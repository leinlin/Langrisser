using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015CB RID: 5579
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x06021F53 RID: 139091 RVA: 0x00B906EC File Offset: 0x00B8E8EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 4, out battleReport);
			UnchartedScoreScoreLevelBattleFinishedNetTask o = new UnchartedScoreScoreLevelBattleFinishedNetTask(unchartedScoreId, levelId, battleReport);
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

	// Token: 0x06021F54 RID: 139092 RVA: 0x00B9075C File Offset: 0x00B8E95C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreScoreLevelBattleFinishedNetTask unchartedScoreScoreLevelBattleFinishedNetTask = (UnchartedScoreScoreLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreScoreLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F55 RID: 139093 RVA: 0x00B907B0 File Offset: 0x00B8E9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreScoreLevelBattleFinishedNetTask unchartedScoreScoreLevelBattleFinishedNetTask = (UnchartedScoreScoreLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreScoreLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F56 RID: 139094 RVA: 0x00B90804 File Offset: 0x00B8EA04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreScoreLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.<>f__mg$cache2, typeof(UnchartedScoreScoreLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04017D9F RID: 97695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017DA0 RID: 97696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017DA1 RID: 97697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
