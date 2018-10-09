using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015C6 RID: 5574
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x06021EE4 RID: 138980 RVA: 0x00B8CDE4 File Offset: 0x00B8AFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
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
			UnchartedScoreChallengeLevelBattleFinishedNetTask o = new UnchartedScoreChallengeLevelBattleFinishedNetTask(unchartedScoreId, levelId, battleReport);
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

	// Token: 0x06021EE5 RID: 138981 RVA: 0x00B8CE54 File Offset: 0x00B8B054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreChallengeLevelBattleFinishedNetTask unchartedScoreChallengeLevelBattleFinishedNetTask = (UnchartedScoreChallengeLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreChallengeLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EE6 RID: 138982 RVA: 0x00B8CEA8 File Offset: 0x00B8B0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreChallengeLevelBattleFinishedNetTask unchartedScoreChallengeLevelBattleFinishedNetTask = (UnchartedScoreChallengeLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreChallengeLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EE7 RID: 138983 RVA: 0x00B8CEFC File Offset: 0x00B8B0FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreChallengeLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.<>f__mg$cache2, typeof(UnchartedScoreChallengeLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04017D3A RID: 97594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017D3B RID: 97595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017D3C RID: 97596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
