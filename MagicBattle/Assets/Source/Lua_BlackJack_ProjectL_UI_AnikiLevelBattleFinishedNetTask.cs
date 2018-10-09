using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200135F RID: 4959
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x0601AB67 RID: 109415 RVA: 0x007F5C28 File Offset: 0x007F3E28
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
			AnikiLevelBattleFinishedNetTask o = new AnikiLevelBattleFinishedNetTask(levelId, battleReport);
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

	// Token: 0x0601AB68 RID: 109416 RVA: 0x007F5C88 File Offset: 0x007F3E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelBattleFinishedNetTask anikiLevelBattleFinishedNetTask = (AnikiLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB69 RID: 109417 RVA: 0x007F5CDC File Offset: 0x007F3EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelBattleFinishedNetTask anikiLevelBattleFinishedNetTask = (AnikiLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB6A RID: 109418 RVA: 0x007F5D30 File Offset: 0x007F3F30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AnikiLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.<>f__mg$cache2, typeof(AnikiLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04010E8B RID: 69259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010E8C RID: 69260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010E8D RID: 69261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
