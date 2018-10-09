using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200137A RID: 4986
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask : LuaObject
{
	// Token: 0x0601AFE0 RID: 110560 RVA: 0x0081994C File Offset: 0x00817B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int opponentIndex;
			LuaObject.checkType(l, 2, out opponentIndex);
			ArenaOpponentViewNetTask o = new ArenaOpponentViewNetTask(opponentIndex);
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

	// Token: 0x0601AFE1 RID: 110561 RVA: 0x008199A0 File Offset: 0x00817BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heros(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentViewNetTask arenaOpponentViewNetTask = (ArenaOpponentViewNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentViewNetTask.Heros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFE2 RID: 110562 RVA: 0x008199F4 File Offset: 0x00817BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePower(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponentViewNetTask arenaOpponentViewNetTask = (ArenaOpponentViewNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponentViewNetTask.BattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFE3 RID: 110563 RVA: 0x00819A48 File Offset: 0x00817C48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaOpponentViewNetTask");
		string name = "Heros";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.get_Heros);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache0, null, true);
		string name2 = "BattlePower";
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.get_BattlePower);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.<>f__mg$cache2, typeof(ArenaOpponentViewNetTask), typeof(UINetTask));
	}

	// Token: 0x040112CE RID: 70350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040112CF RID: 70351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040112D0 RID: 70352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
