using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B0 RID: 4528
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_PathNode : LuaObject
{
	// Token: 0x0601776A RID: 96106 RVA: 0x00668480 File Offset: 0x00666680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PathNode o = new PathNode();
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

	// Token: 0x0601776B RID: 96107 RVA: 0x006684C8 File Offset: 0x006666C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSameState(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			PathNode rhs;
			LuaObject.checkType<PathNode>(l, 2, out rhs);
			bool b = pathNode.IsSameState(rhs);
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

	// Token: 0x0601776C RID: 96108 RVA: 0x0066852C File Offset: 0x0066672C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoalHeuristic(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			Pathfinder pathfinder;
			LuaObject.checkType<Pathfinder>(l, 2, out pathfinder);
			int goalHeuristic = pathNode.GetGoalHeuristic(pathfinder);
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

	// Token: 0x0601776D RID: 96109 RVA: 0x00668590 File Offset: 0x00666790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCost(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			Pathfinder pathfinder;
			LuaObject.checkType<Pathfinder>(l, 2, out pathfinder);
			PathNode successor;
			LuaObject.checkType<PathNode>(l, 3, out successor);
			int cost = pathNode.GetCost(pathfinder, successor);
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

	// Token: 0x0601776E RID: 96110 RVA: 0x00668600 File Offset: 0x00666800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSuccessors(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			Pathfinder pathfinder;
			LuaObject.checkType<Pathfinder>(l, 2, out pathfinder);
			PathNode parentNode;
			LuaObject.checkType<PathNode>(l, 3, out parentNode);
			pathNode.GetSuccessors(pathfinder, parentNode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601776F RID: 96111 RVA: 0x00668664 File Offset: 0x00666864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSuccessor(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			Pathfinder pathfinder;
			LuaObject.checkType<Pathfinder>(l, 2, out pathfinder);
			int dx;
			LuaObject.checkType(l, 3, out dx);
			int dy;
			LuaObject.checkType(l, 4, out dy);
			GridPosition parentPos;
			LuaObject.checkValueType<GridPosition>(l, 5, out parentPos);
			pathNode.m_luaExportHelper.AddSuccessor(pathfinder, dx, dy, parentPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017770 RID: 96112 RVA: 0x006686E8 File Offset: 0x006668E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathNode.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017771 RID: 96113 RVA: 0x00668740 File Offset: 0x00666940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			PathNode pathNode = (PathNode)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			pathNode.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017772 RID: 96114 RVA: 0x00668798 File Offset: 0x00666998
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.PathNode");
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.IsSameState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.GetGoalHeuristic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.GetCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.GetSuccessors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.AddSuccessor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache4);
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_PathNode.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_PathNode.<>f__mg$cache7, typeof(PathNode));
	}

	// Token: 0x0400DDEC RID: 56812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DDED RID: 56813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DDEE RID: 56814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DDEF RID: 56815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DDF0 RID: 56816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DDF1 RID: 56817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DDF2 RID: 56818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DDF3 RID: 56819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
