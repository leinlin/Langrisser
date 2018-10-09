using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200150A RID: 5386
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x0601FE4D RID: 130637 RVA: 0x00A89030 File Offset: 0x00A87230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int memoryCorridorLevelID;
			LuaObject.checkType(l, 2, out memoryCorridorLevelID);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			MemoryCorridorLevelBattleFinishedNetTask o = new MemoryCorridorLevelBattleFinishedNetTask(memoryCorridorLevelID, battleReport);
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

	// Token: 0x0601FE4E RID: 130638 RVA: 0x00A89090 File Offset: 0x00A87290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelBattleFinishedNetTask memoryCorridorLevelBattleFinishedNetTask = (MemoryCorridorLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE4F RID: 130639 RVA: 0x00A890E4 File Offset: 0x00A872E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelBattleFinishedNetTask memoryCorridorLevelBattleFinishedNetTask = (MemoryCorridorLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE50 RID: 130640 RVA: 0x00A89138 File Offset: 0x00A87338
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MemoryCorridorLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.<>f__mg$cache2, typeof(MemoryCorridorLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04015E1B RID: 89627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015E1C RID: 89628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015E1D RID: 89629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
