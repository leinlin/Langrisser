using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015B0 RID: 5552
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x06021B65 RID: 138085 RVA: 0x00B7172C File Offset: 0x00B6F92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			ThearchyLevelBattleFinishedNetTask o = new ThearchyLevelBattleFinishedNetTask(levelId, battleReport);
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

	// Token: 0x06021B66 RID: 138086 RVA: 0x00B7178C File Offset: 0x00B6F98C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelBattleFinishedNetTask thearchyLevelBattleFinishedNetTask = (ThearchyLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B67 RID: 138087 RVA: 0x00B717E0 File Offset: 0x00B6F9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			ThearchyLevelBattleFinishedNetTask thearchyLevelBattleFinishedNetTask = (ThearchyLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, thearchyLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021B68 RID: 138088 RVA: 0x00B71834 File Offset: 0x00B6FA34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ThearchyLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.<>f__mg$cache2, typeof(ThearchyLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x040179E7 RID: 96743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040179E8 RID: 96744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040179E9 RID: 96745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
