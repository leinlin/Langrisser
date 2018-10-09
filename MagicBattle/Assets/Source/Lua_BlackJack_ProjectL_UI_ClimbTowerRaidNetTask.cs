using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F9 RID: 5113
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask : LuaObject
{
	// Token: 0x0601CBC3 RID: 117699 RVA: 0x008F6FC4 File Offset: 0x008F51C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidNetTask o = new ClimbTowerRaidNetTask();
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

	// Token: 0x0601CBC4 RID: 117700 RVA: 0x008F700C File Offset: 0x008F520C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRaidNetTask climbTowerRaidNetTask = (ClimbTowerRaidNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRaidNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CBC5 RID: 117701 RVA: 0x008F7060 File Offset: 0x008F5260
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerRaidNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.<>f__mg$cache1, typeof(ClimbTowerRaidNetTask), typeof(UINetTask));
	}

	// Token: 0x04012DB3 RID: 77235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012DB4 RID: 77236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
