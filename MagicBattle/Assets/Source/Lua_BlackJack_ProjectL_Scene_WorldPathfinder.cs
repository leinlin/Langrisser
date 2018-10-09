using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200134C RID: 4940
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_WorldPathfinder : LuaObject
{
	// Token: 0x0601A8AE RID: 108718 RVA: 0x007E0564 File Offset: 0x007DE764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder o = new WorldPathfinder();
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

	// Token: 0x0601A8AF RID: 108719 RVA: 0x007E05AC File Offset: 0x007DE7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			worldPathfinder.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B0 RID: 108720 RVA: 0x007E05F8 File Offset: 0x007DE7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocatePathNode(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			WorldPathNode o = worldPathfinder.AllocatePathNode();
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

	// Token: 0x0601A8B1 RID: 108721 RVA: 0x007E064C File Offset: 0x007DE84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitiatePathfind(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			worldPathfinder.InitiatePathfind();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B2 RID: 108722 RVA: 0x007E0698 File Offset: 0x007DE898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelSearch(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			worldPathfinder.CancelSearch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B3 RID: 108723 RVA: 0x007E06E4 File Offset: 0x007DE8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStartAndGoalStates(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			WorldPathNode start;
			LuaObject.checkType<WorldPathNode>(l, 2, out start);
			WorldPathNode goal;
			LuaObject.checkType<WorldPathNode>(l, 3, out goal);
			worldPathfinder.SetStartAndGoalStates(start, goal);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B4 RID: 108724 RVA: 0x007E0748 File Offset: 0x007DE948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchStep(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			WorldPathfinder.SearchState e = worldPathfinder.SearchStep();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A8B5 RID: 108725 RVA: 0x007E079C File Offset: 0x007DE99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSuccessor(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			WorldPathNode state;
			LuaObject.checkType<WorldPathNode>(l, 2, out state);
			worldPathfinder.AddSuccessor(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B6 RID: 108726 RVA: 0x007E07F4 File Offset: 0x007DE9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSolutionStart(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			WorldPathNode solutionStart = worldPathfinder.GetSolutionStart();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, solutionStart);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B7 RID: 108727 RVA: 0x007E0848 File Offset: 0x007DEA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSolutionNext(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			WorldPathNode solutionNext = worldPathfinder.GetSolutionNext();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, solutionNext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B8 RID: 108728 RVA: 0x007E089C File Offset: 0x007DEA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FreeSolutionNodes(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			worldPathfinder.FreeSolutionNodes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8B9 RID: 108729 RVA: 0x007E08E8 File Offset: 0x007DEAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasStartNode(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			bool b = worldPathfinder.HasStartNode();
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

	// Token: 0x0601A8BA RID: 108730 RVA: 0x007E093C File Offset: 0x007DEB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGoalNode(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			bool b = worldPathfinder.HasGoalNode();
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

	// Token: 0x0601A8BB RID: 108731 RVA: 0x007E0990 File Offset: 0x007DEB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWaypoint(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			ConfigDataWaypointInfo o;
			Vector2 o2;
			bool waypoint = worldPathfinder.GetWaypoint(id, out o, out o2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waypoint);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8BC RID: 108732 RVA: 0x007E0A08 File Offset: 0x007DEC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanMoveToWaypoint(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			bool b = worldPathfinder.CanMoveToWaypoint(id);
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

	// Token: 0x0601A8BD RID: 108733 RVA: 0x007E0A6C File Offset: 0x007DEC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPath(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			ClientWorld world;
			LuaObject.checkType<ClientWorld>(l, 2, out world);
			int start;
			LuaObject.checkType(l, 3, out start);
			int goal;
			LuaObject.checkType(l, 4, out goal);
			List<int> path;
			LuaObject.checkType<List<int>>(l, 5, out path);
			bool checkWaypointStatus;
			LuaObject.checkType(l, 6, out checkWaypointStatus);
			bool b = worldPathfinder.FindPath(world, start, goal, path, checkWaypointStatus);
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

	// Token: 0x0601A8BE RID: 108734 RVA: 0x007E0B00 File Offset: 0x007DED00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartNode(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldPathfinder.StartNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8BF RID: 108735 RVA: 0x007E0B54 File Offset: 0x007DED54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoalNode(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder worldPathfinder = (WorldPathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldPathfinder.GoalNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8C0 RID: 108736 RVA: 0x007E0BA8 File Offset: 0x007DEDA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.WorldPathfinder");
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.AllocatePathNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.InitiatePathfind);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.CancelSearch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.SetStartAndGoalStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.SearchStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.AddSuccessor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.GetSolutionStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.GetSolutionNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.FreeSolutionNodes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.HasStartNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.HasGoalNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.GetWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.CanMoveToWaypoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.FindPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheE);
		string name = "StartNode";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.get_StartNode);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cacheF, null, true);
		string name2 = "GoalNode";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.get_GoalNode);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache10, null, true);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder.<>f__mg$cache11, typeof(WorldPathfinder));
	}

	// Token: 0x04010BF8 RID: 68600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010BF9 RID: 68601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010BFA RID: 68602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010BFB RID: 68603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010BFC RID: 68604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010BFD RID: 68605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010BFE RID: 68606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010BFF RID: 68607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C00 RID: 68608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010C01 RID: 68609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010C02 RID: 68610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010C03 RID: 68611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010C04 RID: 68612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010C05 RID: 68613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010C06 RID: 68614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010C07 RID: 68615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010C08 RID: 68616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010C09 RID: 68617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
