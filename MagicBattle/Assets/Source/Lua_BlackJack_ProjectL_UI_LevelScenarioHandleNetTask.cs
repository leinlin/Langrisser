using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F5 RID: 5365
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask : LuaObject
{
	// Token: 0x0601FB2D RID: 129837 RVA: 0x00A70D68 File Offset: 0x00A6EF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int scenarioId;
			LuaObject.checkType(l, 2, out scenarioId);
			LevelScenarioHandleNetTask o = new LevelScenarioHandleNetTask(scenarioId);
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

	// Token: 0x0601FB2E RID: 129838 RVA: 0x00A70DBC File Offset: 0x00A6EFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			LevelScenarioHandleNetTask levelScenarioHandleNetTask = (LevelScenarioHandleNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelScenarioHandleNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB2F RID: 129839 RVA: 0x00A70E10 File Offset: 0x00A6F010
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LevelScenarioHandleNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.<>f__mg$cache1, typeof(LevelScenarioHandleNetTask), typeof(UINetTask));
	}

	// Token: 0x04015B25 RID: 88869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B26 RID: 88870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
