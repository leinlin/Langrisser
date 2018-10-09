using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011AE RID: 4526
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_Pathfinder : LuaObject
{
	// Token: 0x06017717 RID: 96023 RVA: 0x00665D6C File Offset: 0x00663F6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder o = new Pathfinder();
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

	// Token: 0x06017718 RID: 96024 RVA: 0x00665DB4 File Offset: 0x00663FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			pathfinder.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017719 RID: 96025 RVA: 0x00665E00 File Offset: 0x00664000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AllocatePathNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			PathNode o = pathfinder.AllocatePathNode();
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

	// Token: 0x0601771A RID: 96026 RVA: 0x00665E54 File Offset: 0x00664054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitiatePathfind(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			pathfinder.InitiatePathfind();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601771B RID: 96027 RVA: 0x00665EA0 File Offset: 0x006640A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelSearch(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			pathfinder.CancelSearch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601771C RID: 96028 RVA: 0x00665EEC File Offset: 0x006640EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStartAndGoalStates(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			PathNode start;
			LuaObject.checkType<PathNode>(l, 2, out start);
			PathNode goal;
			LuaObject.checkType<PathNode>(l, 3, out goal);
			pathfinder.SetStartAndGoalStates(start, goal);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601771D RID: 96029 RVA: 0x00665F50 File Offset: 0x00664150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchStep(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.SearchState e = pathfinder.SearchStep();
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

	// Token: 0x0601771E RID: 96030 RVA: 0x00665FA4 File Offset: 0x006641A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSuccessor(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			PathNode state;
			LuaObject.checkType<PathNode>(l, 2, out state);
			pathfinder.AddSuccessor(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601771F RID: 96031 RVA: 0x00665FFC File Offset: 0x006641FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSolutionStart(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			PathNode solutionStart = pathfinder.GetSolutionStart();
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

	// Token: 0x06017720 RID: 96032 RVA: 0x00666050 File Offset: 0x00664250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSolutionNext(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			PathNode solutionNext = pathfinder.GetSolutionNext();
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

	// Token: 0x06017721 RID: 96033 RVA: 0x006660A4 File Offset: 0x006642A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FreeSolutionNodes(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			pathfinder.FreeSolutionNodes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017722 RID: 96034 RVA: 0x006660F0 File Offset: 0x006642F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasStartNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			bool b = pathfinder.HasStartNode();
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

	// Token: 0x06017723 RID: 96035 RVA: 0x00666144 File Offset: 0x00664344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasGoalNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			bool b = pathfinder.HasGoalNode();
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

	// Token: 0x06017724 RID: 96036 RVA: 0x00666198 File Offset: 0x00664398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPath(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			BattleMap map;
			LuaObject.checkType<BattleMap>(l, 2, out map);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 3, out start);
			GridPosition goal;
			LuaObject.checkValueType<GridPosition>(l, 4, out goal);
			int movePoint;
			LuaObject.checkType(l, 5, out movePoint);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 6, out moveType);
			int ignoreTeam;
			LuaObject.checkType(l, 7, out ignoreTeam);
			int overrideMovePointCost;
			LuaObject.checkType(l, 8, out overrideMovePointCost);
			int inRegion;
			LuaObject.checkType(l, 9, out inRegion);
			List<GridPosition> path;
			LuaObject.checkType<List<GridPosition>>(l, 10, out path);
			bool findNearestIfFail;
			LuaObject.checkType(l, 11, out findNearestIfFail);
			bool b = pathfinder.FindPath(map, start, goal, movePoint, moveType, ignoreTeam, overrideMovePointCost, inRegion, path, findNearestIfFail);
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

	// Token: 0x06017725 RID: 96037 RVA: 0x0066626C File Offset: 0x0066446C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindRegion(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			BattleMap map;
			LuaObject.checkType<BattleMap>(l, 2, out map);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 3, out start);
			int movePoint;
			LuaObject.checkType(l, 4, out movePoint);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 5, out moveType);
			int ignoreTeam;
			LuaObject.checkType(l, 6, out ignoreTeam);
			int overrideMoveCost;
			LuaObject.checkType(l, 7, out overrideMoveCost);
			int inRegion;
			LuaObject.checkType(l, 8, out inRegion);
			List<GridPosition> region;
			LuaObject.checkType<List<GridPosition>>(l, 9, out region);
			bool b = pathfinder.FindRegion(map, start, movePoint, moveType, ignoreTeam, overrideMoveCost, inRegion, region);
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

	// Token: 0x06017726 RID: 96038 RVA: 0x00666328 File Offset: 0x00664528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SortedAddToOpenList(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.Node node;
			LuaObject.checkType<Pathfinder.Node>(l, 2, out node);
			pathfinder.m_luaExportHelper.SortedAddToOpenList(node);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017727 RID: 96039 RVA: 0x00666384 File Offset: 0x00664584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocateNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.Node o = pathfinder.m_luaExportHelper.AllocateNode();
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

	// Token: 0x06017728 RID: 96040 RVA: 0x006663E0 File Offset: 0x006645E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRegionStartState(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			PathNode regionStartState;
			LuaObject.checkType<PathNode>(l, 2, out regionStartState);
			pathfinder.m_luaExportHelper.SetRegionStartState(regionStartState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017729 RID: 96041 RVA: 0x0066643C File Offset: 0x0066463C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SearchRegionStep(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.SearchState e = pathfinder.m_luaExportHelper.SearchRegionStep();
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

	// Token: 0x0601772A RID: 96042 RVA: 0x00666498 File Offset: 0x00664698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_OpenList(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_OpenList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601772B RID: 96043 RVA: 0x006664F0 File Offset: 0x006646F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_OpenList(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LinkedList<Pathfinder.Node> openList;
			LuaObject.checkType<LinkedList<Pathfinder.Node>>(l, 2, out openList);
			pathfinder.m_luaExportHelper.m_OpenList = openList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601772C RID: 96044 RVA: 0x0066654C File Offset: 0x0066474C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ClosedList(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_ClosedList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601772D RID: 96045 RVA: 0x006665A4 File Offset: 0x006647A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_ClosedList(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			List<Pathfinder.Node> closedList;
			LuaObject.checkType<List<Pathfinder.Node>>(l, 2, out closedList);
			pathfinder.m_luaExportHelper.m_ClosedList = closedList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601772E RID: 96046 RVA: 0x00666600 File Offset: 0x00664800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_Successors(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_Successors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601772F RID: 96047 RVA: 0x00666658 File Offset: 0x00664858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_Successors(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			List<Pathfinder.Node> successors;
			LuaObject.checkType<List<Pathfinder.Node>>(l, 2, out successors);
			pathfinder.m_luaExportHelper.m_Successors = successors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017730 RID: 96048 RVA: 0x006666B4 File Offset: 0x006648B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_State(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pathfinder.m_luaExportHelper.m_State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017731 RID: 96049 RVA: 0x0066670C File Offset: 0x0066490C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_State(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.SearchState state;
			LuaObject.checkEnum<Pathfinder.SearchState>(l, 2, out state);
			pathfinder.m_luaExportHelper.m_State = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017732 RID: 96050 RVA: 0x00666768 File Offset: 0x00664968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_Steps(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_Steps);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017733 RID: 96051 RVA: 0x006667C0 File Offset: 0x006649C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_Steps(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int steps;
			LuaObject.checkType(l, 2, out steps);
			pathfinder.m_luaExportHelper.m_Steps = steps;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017734 RID: 96052 RVA: 0x0066681C File Offset: 0x00664A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_Start(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_Start);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017735 RID: 96053 RVA: 0x00666874 File Offset: 0x00664A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_Start(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.Node start;
			LuaObject.checkType<Pathfinder.Node>(l, 2, out start);
			pathfinder.m_luaExportHelper.m_Start = start;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017736 RID: 96054 RVA: 0x006668D0 File Offset: 0x00664AD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_Goal(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_Goal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017737 RID: 96055 RVA: 0x00666928 File Offset: 0x00664B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_Goal(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.Node goal;
			LuaObject.checkType<Pathfinder.Node>(l, 2, out goal);
			pathfinder.m_luaExportHelper.m_Goal = goal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017738 RID: 96056 RVA: 0x00666984 File Offset: 0x00664B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_CurrentSolutionNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_CurrentSolutionNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017739 RID: 96057 RVA: 0x006669DC File Offset: 0x00664BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_CurrentSolutionNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			Pathfinder.Node currentSolutionNode;
			LuaObject.checkType<Pathfinder.Node>(l, 2, out currentSolutionNode);
			pathfinder.m_luaExportHelper.m_CurrentSolutionNode = currentSolutionNode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601773A RID: 96058 RVA: 0x00666A38 File Offset: 0x00664C38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_CancelRequest(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_CancelRequest);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601773B RID: 96059 RVA: 0x00666A90 File Offset: 0x00664C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_CancelRequest(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			bool cancelRequest;
			LuaObject.checkType(l, 2, out cancelRequest);
			pathfinder.m_luaExportHelper.m_CancelRequest = cancelRequest;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601773C RID: 96060 RVA: 0x00666AEC File Offset: 0x00664CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_NodePool(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_NodePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601773D RID: 96061 RVA: 0x00666B44 File Offset: 0x00664D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_NodePool(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			List<Pathfinder.Node> nodePool;
			LuaObject.checkType<List<Pathfinder.Node>>(l, 2, out nodePool);
			pathfinder.m_luaExportHelper.m_NodePool = nodePool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601773E RID: 96062 RVA: 0x00666BA0 File Offset: 0x00664DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_AllocateNodeCount(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_AllocateNodeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601773F RID: 96063 RVA: 0x00666BF8 File Offset: 0x00664DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_AllocateNodeCount(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int allocateNodeCount;
			LuaObject.checkType(l, 2, out allocateNodeCount);
			pathfinder.m_luaExportHelper.m_AllocateNodeCount = allocateNodeCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017740 RID: 96064 RVA: 0x00666C54 File Offset: 0x00664E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_PathNodePool(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_PathNodePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017741 RID: 96065 RVA: 0x00666CAC File Offset: 0x00664EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_PathNodePool(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			List<PathNode> pathNodePool;
			LuaObject.checkType<List<PathNode>>(l, 2, out pathNodePool);
			pathfinder.m_luaExportHelper.m_PathNodePool = pathNodePool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017742 RID: 96066 RVA: 0x00666D08 File Offset: 0x00664F08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_AllocatedPathNodeCount(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_AllocatedPathNodeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017743 RID: 96067 RVA: 0x00666D60 File Offset: 0x00664F60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_AllocatedPathNodeCount(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int allocatedPathNodeCount;
			LuaObject.checkType(l, 2, out allocatedPathNodeCount);
			pathfinder.m_luaExportHelper.m_AllocatedPathNodeCount = allocatedPathNodeCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017744 RID: 96068 RVA: 0x00666DBC File Offset: 0x00664FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_kPreallocatedNodes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Pathfinder.LuaExportHelper.kPreallocatedNodes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017745 RID: 96069 RVA: 0x00666E04 File Offset: 0x00665004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_Map(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_Map);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017746 RID: 96070 RVA: 0x00666E5C File Offset: 0x0066505C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_Map(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			BattleMap map;
			LuaObject.checkType<BattleMap>(l, 2, out map);
			pathfinder.m_luaExportHelper.m_Map = map;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017747 RID: 96071 RVA: 0x00666EB8 File Offset: 0x006650B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_MovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017748 RID: 96072 RVA: 0x00666F10 File Offset: 0x00665110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int movePoint;
			LuaObject.checkType(l, 2, out movePoint);
			pathfinder.m_luaExportHelper.m_MovePoint = movePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017749 RID: 96073 RVA: 0x00666F6C File Offset: 0x0066516C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_MoveType(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pathfinder.m_luaExportHelper.m_MoveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601774A RID: 96074 RVA: 0x00666FC4 File Offset: 0x006651C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_MoveType(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 2, out moveType);
			pathfinder.m_luaExportHelper.m_MoveType = moveType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601774B RID: 96075 RVA: 0x00667020 File Offset: 0x00665220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_IgnoreTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_IgnoreTeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601774C RID: 96076 RVA: 0x00667078 File Offset: 0x00665278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_IgnoreTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int ignoreTeamNumber;
			LuaObject.checkType(l, 2, out ignoreTeamNumber);
			pathfinder.m_luaExportHelper.m_IgnoreTeamNumber = ignoreTeamNumber;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601774D RID: 96077 RVA: 0x006670D4 File Offset: 0x006652D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_InRegion(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_InRegion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601774E RID: 96078 RVA: 0x0066712C File Offset: 0x0066532C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_InRegion(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int inRegion;
			LuaObject.checkType(l, 2, out inRegion);
			pathfinder.m_luaExportHelper.m_InRegion = inRegion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601774F RID: 96079 RVA: 0x00667188 File Offset: 0x00665388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_OverrideMovePointCost(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.m_luaExportHelper.m_OverrideMovePointCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017750 RID: 96080 RVA: 0x006671E0 File Offset: 0x006653E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_OverrideMovePointCost(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			int overrideMovePointCost;
			LuaObject.checkType(l, 2, out overrideMovePointCost);
			pathfinder.m_luaExportHelper.m_OverrideMovePointCost = overrideMovePointCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017751 RID: 96081 RVA: 0x0066723C File Offset: 0x0066543C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Map(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.Map);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017752 RID: 96082 RVA: 0x00667290 File Offset: 0x00665490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MoveType(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pathfinder.MoveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017753 RID: 96083 RVA: 0x006672E4 File Offset: 0x006654E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IgnoreTeamNumber(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.IgnoreTeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017754 RID: 96084 RVA: 0x00667338 File Offset: 0x00665538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OverrideMovePointCost(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.OverrideMovePointCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017755 RID: 96085 RVA: 0x0066738C File Offset: 0x0066558C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InRegion(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.InRegion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017756 RID: 96086 RVA: 0x006673E0 File Offset: 0x006655E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.StartNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017757 RID: 96087 RVA: 0x00667434 File Offset: 0x00665634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GoalNode(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder pathfinder = (Pathfinder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pathfinder.GoalNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017758 RID: 96088 RVA: 0x00667488 File Offset: 0x00665688
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.Pathfinder");
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.AllocatePathNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.InitiatePathfind);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.CancelSearch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.SetStartAndGoalStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.SearchStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.AddSuccessor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.GetSolutionStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.GetSolutionNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.FreeSolutionNodes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.HasStartNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.HasGoalNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.FindPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.FindRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.SortedAddToOpenList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.AllocateNode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.SetRegionStartState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.SearchRegionStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache11);
		string name = "m_OpenList";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_OpenList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_OpenList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache13, true);
		string name2 = "m_ClosedList";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_ClosedList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_ClosedList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache15, true);
		string name3 = "m_Successors";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_Successors);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_Successors);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache17, true);
		string name4 = "m_State";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_State);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_State);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache19, true);
		string name5 = "m_Steps";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_Steps);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_Steps);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1B, true);
		string name6 = "m_Start";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_Start);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_Start);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1D, true);
		string name7 = "m_Goal";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_Goal);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_Goal);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache1F, true);
		string name8 = "m_CurrentSolutionNode";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_CurrentSolutionNode);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_CurrentSolutionNode);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache21, true);
		string name9 = "m_CancelRequest";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_CancelRequest);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_CancelRequest);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache23, true);
		string name10 = "m_NodePool";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_NodePool);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_NodePool);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache25, true);
		string name11 = "m_AllocateNodeCount";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_AllocateNodeCount);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_AllocateNodeCount);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache27, true);
		string name12 = "m_PathNodePool";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_PathNodePool);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_PathNodePool);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache29, true);
		string name13 = "m_AllocatedPathNodeCount";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_AllocatedPathNodeCount);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_AllocatedPathNodeCount);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2B, true);
		string name14 = "kPreallocatedNodes";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_kPreallocatedNodes);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2C, null, false);
		string name15 = "m_Map";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_Map);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_Map);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2E, true);
		string name16 = "m_MovePoint";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_MovePoint);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_MovePoint);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache30, true);
		string name17 = "m_MoveType";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_MoveType);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_MoveType);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache32, true);
		string name18 = "m_IgnoreTeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_IgnoreTeamNumber);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_IgnoreTeamNumber);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache34, true);
		string name19 = "m_InRegion";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_InRegion);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_InRegion);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache36, true);
		string name20 = "m_OverrideMovePointCost";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_m_OverrideMovePointCost);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.set_m_OverrideMovePointCost);
		}
		LuaObject.addMember(l, name20, get19, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache38, true);
		string name21 = "Map";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_Map);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache39, null, true);
		string name22 = "MoveType";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_MoveType);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3A, null, true);
		string name23 = "IgnoreTeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_IgnoreTeamNumber);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3B, null, true);
		string name24 = "OverrideMovePointCost";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_OverrideMovePointCost);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3C, null, true);
		string name25 = "InRegion";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_InRegion);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3D, null, true);
		string name26 = "StartNode";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_StartNode);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3E, null, true);
		string name27 = "GoalNode";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.get_GoalNode);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache3F, null, true);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_Pathfinder.<>f__mg$cache40, typeof(Pathfinder));
	}

	// Token: 0x0400DD9D RID: 56733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DD9E RID: 56734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DD9F RID: 56735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DDA0 RID: 56736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DDA1 RID: 56737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DDA2 RID: 56738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DDA3 RID: 56739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DDA4 RID: 56740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DDA5 RID: 56741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DDA6 RID: 56742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DDA7 RID: 56743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DDA8 RID: 56744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DDA9 RID: 56745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DDAA RID: 56746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DDAB RID: 56747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DDAC RID: 56748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DDAD RID: 56749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DDAE RID: 56750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DDAF RID: 56751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DDB0 RID: 56752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DDB1 RID: 56753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DDB2 RID: 56754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DDB3 RID: 56755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DDB4 RID: 56756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DDB5 RID: 56757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DDB6 RID: 56758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DDB7 RID: 56759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DDB8 RID: 56760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DDB9 RID: 56761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DDBA RID: 56762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DDBB RID: 56763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DDBC RID: 56764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DDBD RID: 56765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DDBE RID: 56766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DDBF RID: 56767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400DDC0 RID: 56768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400DDC1 RID: 56769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400DDC2 RID: 56770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400DDC3 RID: 56771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400DDC4 RID: 56772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400DDC5 RID: 56773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400DDC6 RID: 56774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400DDC7 RID: 56775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400DDC8 RID: 56776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400DDC9 RID: 56777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400DDCA RID: 56778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400DDCB RID: 56779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400DDCC RID: 56780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400DDCD RID: 56781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400DDCE RID: 56782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400DDCF RID: 56783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400DDD0 RID: 56784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400DDD1 RID: 56785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400DDD2 RID: 56786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400DDD3 RID: 56787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400DDD4 RID: 56788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400DDD5 RID: 56789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400DDD6 RID: 56790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400DDD7 RID: 56791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400DDD8 RID: 56792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400DDD9 RID: 56793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400DDDA RID: 56794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400DDDB RID: 56795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400DDDC RID: 56796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400DDDD RID: 56797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;
}
