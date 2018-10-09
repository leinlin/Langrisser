using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F7 RID: 5367
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask : LuaObject
{
	// Token: 0x0601FB36 RID: 129846 RVA: 0x00A71048 File Offset: 0x00A6F248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int waypointId;
			LuaObject.checkType(l, 2, out waypointId);
			LevelWayPointMoveNetTask o = new LevelWayPointMoveNetTask(waypointId);
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

	// Token: 0x0601FB37 RID: 129847 RVA: 0x00A7109C File Offset: 0x00A6F29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			LevelWayPointMoveNetTask levelWayPointMoveNetTask = (LevelWayPointMoveNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelWayPointMoveNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB38 RID: 129848 RVA: 0x00A710F0 File Offset: 0x00A6F2F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LevelWayPointMoveNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.<>f__mg$cache1, typeof(LevelWayPointMoveNetTask), typeof(UINetTask));
	}

	// Token: 0x04015B2A RID: 88874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B2B RID: 88875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
