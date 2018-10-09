using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001387 RID: 4999
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask : LuaObject
{
	// Token: 0x0601B33F RID: 111423 RVA: 0x00834390 File Offset: 0x00832590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 2, out id);
			ArenaVictoryPointsRewardGainNetTask o = new ArenaVictoryPointsRewardGainNetTask(id);
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

	// Token: 0x0601B340 RID: 111424 RVA: 0x008343E4 File Offset: 0x008325E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			ArenaVictoryPointsRewardGainNetTask arenaVictoryPointsRewardGainNetTask = (ArenaVictoryPointsRewardGainNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaVictoryPointsRewardGainNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B341 RID: 111425 RVA: 0x00834438 File Offset: 0x00832638
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaVictoryPointsRewardGainNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.<>f__mg$cache1, typeof(ArenaVictoryPointsRewardGainNetTask), typeof(UINetTask));
	}

	// Token: 0x04011613 RID: 71187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011614 RID: 71188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
