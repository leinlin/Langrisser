using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200134E RID: 4942
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_WorldPathNode : LuaObject
{
	// Token: 0x0601A8D2 RID: 108754 RVA: 0x007E1508 File Offset: 0x007DF708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode o = new WorldPathNode();
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

	// Token: 0x0601A8D3 RID: 108755 RVA: 0x007E1550 File Offset: 0x007DF750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSameState(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			WorldPathNode rhs;
			LuaObject.checkType<WorldPathNode>(l, 2, out rhs);
			bool b = worldPathNode.IsSameState(rhs);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8D4 RID: 108756 RVA: 0x007E15B4 File Offset: 0x007DF7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoalHeuristic(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			WorldPathfinder pathfinder;
			LuaObject.checkType<WorldPathfinder>(l, 2, out pathfinder);
			float goalHeuristic = worldPathNode.GetGoalHeuristic(pathfinder);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goalHeuristic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8D5 RID: 108757 RVA: 0x007E1618 File Offset: 0x007DF818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCost(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			WorldPathfinder pathfinder;
			LuaObject.checkType<WorldPathfinder>(l, 2, out pathfinder);
			WorldPathNode successor;
			LuaObject.checkType<WorldPathNode>(l, 3, out successor);
			float cost = worldPathNode.GetCost(pathfinder, successor);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8D6 RID: 108758 RVA: 0x007E1688 File Offset: 0x007DF888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSuccessors(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			WorldPathfinder pathfinder;
			LuaObject.checkType<WorldPathfinder>(l, 2, out pathfinder);
			WorldPathNode parentNode;
			LuaObject.checkType<WorldPathNode>(l, 3, out parentNode);
			worldPathNode.GetSuccessors(pathfinder, parentNode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8D7 RID: 108759 RVA: 0x007E16EC File Offset: 0x007DF8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldPathNode.m_waypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8D8 RID: 108760 RVA: 0x007E1740 File Offset: 0x007DF940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waypointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			worldPathNode.m_waypointInfo = waypointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8D9 RID: 108761 RVA: 0x007E1798 File Offset: 0x007DF998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldPathNode.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8DA RID: 108762 RVA: 0x007E17EC File Offset: 0x007DF9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			WorldPathNode worldPathNode = (WorldPathNode)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			worldPathNode.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8DB RID: 108763 RVA: 0x007E1844 File Offset: 0x007DFA44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.WorldPathNode");
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.IsSameState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.GetGoalHeuristic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.GetCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.GetSuccessors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache3);
		string name = "m_waypointInfo";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.get_m_waypointInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.set_m_waypointInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache5, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathNode.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_WorldPathNode.<>f__mg$cache8, typeof(WorldPathNode));
	}

	// Token: 0x04010C18 RID: 68632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C19 RID: 68633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C1A RID: 68634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C1B RID: 68635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010C1C RID: 68636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010C1D RID: 68637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010C1E RID: 68638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010C1F RID: 68639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C20 RID: 68640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
