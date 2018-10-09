using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014BB RID: 5307
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x0601F01E RID: 127006 RVA: 0x00A183E8 File Offset: 0x00A165E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroDungeonLevelID;
			LuaObject.checkType(l, 2, out heroDungeonLevelID);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			HeroDungeonLevelBattleFinishedNetTask o = new HeroDungeonLevelBattleFinishedNetTask(heroDungeonLevelID, battleReport);
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

	// Token: 0x0601F01F RID: 127007 RVA: 0x00A18448 File Offset: 0x00A16648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Stars(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelBattleFinishedNetTask heroDungeonLevelBattleFinishedNetTask = (HeroDungeonLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelBattleFinishedNetTask.Stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F020 RID: 127008 RVA: 0x00A1849C File Offset: 0x00A1669C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFirstWin(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelBattleFinishedNetTask heroDungeonLevelBattleFinishedNetTask = (HeroDungeonLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelBattleFinishedNetTask.IsFirstWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F021 RID: 127009 RVA: 0x00A184F0 File Offset: 0x00A166F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelBattleFinishedNetTask heroDungeonLevelBattleFinishedNetTask = (HeroDungeonLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F022 RID: 127010 RVA: 0x00A18544 File Offset: 0x00A16744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievements(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevelBattleFinishedNetTask heroDungeonLevelBattleFinishedNetTask = (HeroDungeonLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevelBattleFinishedNetTask.Achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F023 RID: 127011 RVA: 0x00A18598 File Offset: 0x00A16798
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonLevelBattleFinishedNetTask");
		string name = "Stars";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.get_Stars);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "IsFirstWin";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.get_IsFirstWin);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		string name3 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache2, null, true);
		string name4 = "Achievements";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.get_Achievements);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache3, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.<>f__mg$cache4, typeof(HeroDungeonLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x0401508A RID: 86154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401508B RID: 86155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401508C RID: 86156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401508D RID: 86157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401508E RID: 86158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
