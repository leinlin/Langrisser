using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003CC RID: 972
	[HotFix]
	public class Pathfinder
	{
		// Token: 0x06003A3E RID: 14910 RVA: 0x0010A440 File Offset: 0x00108640
		public Pathfinder()
		{
			this.m_OpenList = new LinkedList<Pathfinder.Node>();
			this.m_ClosedList = new List<Pathfinder.Node>();
			this.m_Successors = new List<Pathfinder.Node>();
			this.m_NodePool = new List<Pathfinder.Node>(64);
			this.m_PathNodePool = new List<PathNode>(64);
			for (int i = 0; i < 64; i++)
			{
				this.m_NodePool.Add(new Pathfinder.Node());
				this.m_PathNodePool.Add(new PathNode());
			}
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x0010A514 File Offset: 0x00108714
		public void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_OpenList != null)
			{
				this.m_OpenList.Clear();
				this.m_OpenList = null;
			}
			if (this.m_ClosedList != null)
			{
				this.m_ClosedList.Clear();
				this.m_ClosedList = null;
			}
			if (this.m_Successors != null)
			{
				this.m_Successors.Clear();
				this.m_Successors = null;
			}
			if (this.m_NodePool != null)
			{
				this.m_NodePool.Clear();
				this.m_NodePool = null;
			}
			if (this.m_PathNodePool != null)
			{
				this.m_PathNodePool.Clear();
				this.m_PathNodePool = null;
			}
			this.m_Map = null;
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x0010A60C File Offset: 0x0010880C
		private void SortedAddToOpenList(Pathfinder.Node node)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortedAddToOpenListNode_hotfix != null)
			{
				this.m_SortedAddToOpenListNode_hotfix.call(new object[]
				{
					this,
					node
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LinkedListNode<Pathfinder.Node> linkedListNode;
			for (linkedListNode = this.m_OpenList.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (node.f < linkedListNode.Value.f)
				{
					break;
				}
			}
			if (linkedListNode != null)
			{
				this.m_OpenList.AddBefore(linkedListNode, node);
			}
			else
			{
				this.m_OpenList.AddLast(node);
			}
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x0010A6DC File Offset: 0x001088DC
		private Pathfinder.Node AllocateNode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocateNode_hotfix != null)
			{
				return (Pathfinder.Node)this.m_AllocateNode_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_AllocateNodeCount >= this.m_NodePool.Count)
			{
				this.m_NodePool.Add(new Pathfinder.Node());
			}
			Pathfinder.Node node = this.m_NodePool[this.m_AllocateNodeCount++];
			node.Reinitialize();
			return node;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x0010A794 File Offset: 0x00108994
		public PathNode AllocatePathNode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocatePathNode_hotfix != null)
			{
				return (PathNode)this.m_AllocatePathNode_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_AllocatedPathNodeCount >= this.m_PathNodePool.Count)
			{
				this.m_PathNodePool.Add(new PathNode());
			}
			return this.m_PathNodePool[this.m_AllocatedPathNodeCount++];
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x0010A844 File Offset: 0x00108A44
		public void InitiatePathfind()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitiatePathfind_hotfix != null)
			{
				this.m_InitiatePathfind_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_CancelRequest = false;
			this.m_AllocateNodeCount = 0;
			this.m_AllocatedPathNodeCount = 0;
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x0010A8BC File Offset: 0x00108ABC
		public void CancelSearch()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelSearch_hotfix != null)
			{
				this.m_CancelSearch_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_CancelRequest = true;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x0010A924 File Offset: 0x00108B24
		public void SetStartAndGoalStates(PathNode start, PathNode goal)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStartAndGoalStatesPathNodePathNode_hotfix != null)
			{
				this.m_SetStartAndGoalStatesPathNodePathNode_hotfix.call(new object[]
				{
					this,
					start,
					goal
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_Start = this.AllocateNode();
			this.m_Goal = this.AllocateNode();
			this.m_Start.m_UserState = start;
			this.m_Goal.m_UserState = goal;
			this.m_State = Pathfinder.SearchState.Searching;
			this.m_Start.g = 0;
			this.m_Start.h = this.m_Start.m_UserState.GetGoalHeuristic(this);
			this.m_Start.f = this.m_Start.g + this.m_Start.h;
			this.m_Start.parent = null;
			this.m_OpenList.AddLast(this.m_Start);
			this.m_Steps = 0;
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x0010AA4C File Offset: 0x00108C4C
		public Pathfinder.SearchState SearchStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchStep_hotfix != null)
			{
				return (Pathfinder.SearchState)this.m_SearchStep_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_State == Pathfinder.SearchState.NotInitialized || this.m_State == Pathfinder.SearchState.Succeeded || this.m_State == Pathfinder.SearchState.Failed)
			{
				return this.m_State;
			}
			if (this.m_OpenList.Count == 0 || this.m_CancelRequest)
			{
				this.m_State = Pathfinder.SearchState.Failed;
				return this.m_State;
			}
			this.m_Steps++;
			Pathfinder.Node value = this.m_OpenList.First.Value;
			this.m_OpenList.RemoveFirst();
			if (value.m_UserState.IsSameState(this.m_Goal.m_UserState))
			{
				this.m_Goal.parent = value.parent;
				this.m_Goal.g = value.g;
				if (!value.m_UserState.IsSameState(this.m_Start.m_UserState))
				{
					Pathfinder.Node node = this.m_Goal;
					Pathfinder.Node parent = this.m_Goal.parent;
					do
					{
						parent.child = node;
						node = parent;
						parent = parent.parent;
					}
					while (node != this.m_Start);
				}
				this.m_State = Pathfinder.SearchState.Succeeded;
				return this.m_State;
			}
			this.m_Successors.Clear();
			value.m_UserState.GetSuccessors(this, (value.parent == null) ? null : value.parent.m_UserState);
			Pathfinder.Node node2 = null;
			int count = this.m_Successors.Count;
			for (int i = 0; i < count; i++)
			{
				node2 = this.m_Successors[i];
				int num = value.g + value.m_UserState.GetCost(this, node2.m_UserState);
				if (num <= this.m_MovePoint)
				{
					Pathfinder.Node node3 = null;
					foreach (Pathfinder.Node node4 in this.m_OpenList)
					{
						if (node4.m_UserState.IsSameState(node2.m_UserState))
						{
							node3 = node4;
							break;
						}
					}
					if (node3 == null || node3.g > num)
					{
						int num2 = -1;
						int count2 = this.m_ClosedList.Count;
						for (int j = 0; j < count2; j++)
						{
							if (this.m_ClosedList[j].m_UserState.IsSameState(node2.m_UserState))
							{
								num2 = j;
								break;
							}
						}
						if (num2 < 0 || this.m_ClosedList[num2].g > num)
						{
							node2.parent = value;
							node2.g = num;
							node2.h = node2.m_UserState.GetGoalHeuristic(this);
							node2.f = node2.g + node2.h;
							if (num2 >= 0)
							{
								this.m_ClosedList.RemoveAt(num2);
							}
							if (node3 != null)
							{
								this.m_OpenList.Remove(node3);
							}
							this.SortedAddToOpenList(node2);
						}
					}
				}
			}
			this.m_ClosedList.Add(value);
			return this.m_State;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x0010ADD4 File Offset: 0x00108FD4
		private void SetRegionStartState(PathNode start)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRegionStartStatePathNode_hotfix != null)
			{
				this.m_SetRegionStartStatePathNode_hotfix.call(new object[]
				{
					this,
					start
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_Start = this.AllocateNode();
			this.m_Goal = null;
			this.m_Start.m_UserState = start;
			this.m_State = Pathfinder.SearchState.Searching;
			this.m_Start.g = 0;
			this.m_Start.h = 0;
			this.m_Start.f = this.m_Start.g + this.m_Start.h;
			this.m_Start.parent = null;
			this.m_OpenList.AddLast(this.m_Start);
			this.m_Steps = 0;
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x0010AECC File Offset: 0x001090CC
		private Pathfinder.SearchState SearchRegionStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SearchRegionStep_hotfix != null)
			{
				return (Pathfinder.SearchState)this.m_SearchRegionStep_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_State == Pathfinder.SearchState.NotInitialized || this.m_State == Pathfinder.SearchState.Succeeded || this.m_State == Pathfinder.SearchState.Failed)
			{
				return this.m_State;
			}
			if (this.m_OpenList.Count == 0)
			{
				this.m_State = Pathfinder.SearchState.Succeeded;
				return this.m_State;
			}
			if (this.m_CancelRequest)
			{
				this.m_State = Pathfinder.SearchState.Failed;
				return this.m_State;
			}
			this.m_Steps++;
			Pathfinder.Node value = this.m_OpenList.First.Value;
			this.m_OpenList.RemoveFirst();
			this.m_Successors.Clear();
			value.m_UserState.GetSuccessors(this, (value.parent == null) ? null : value.parent.m_UserState);
			Pathfinder.Node node = null;
			int count = this.m_Successors.Count;
			for (int i = 0; i < count; i++)
			{
				node = this.m_Successors[i];
				int num = value.g + value.m_UserState.GetCost(this, node.m_UserState);
				if (num <= this.m_MovePoint)
				{
					Pathfinder.Node node2 = null;
					foreach (Pathfinder.Node node3 in this.m_OpenList)
					{
						if (node3.m_UserState.IsSameState(node.m_UserState))
						{
							node2 = node3;
							break;
						}
					}
					if (node2 == null || node2.g > num)
					{
						int num2 = -1;
						int count2 = this.m_ClosedList.Count;
						for (int j = 0; j < count2; j++)
						{
							if (this.m_ClosedList[j].m_UserState.IsSameState(node.m_UserState))
							{
								num2 = j;
								break;
							}
						}
						if (num2 < 0 || this.m_ClosedList[num2].g > num)
						{
							node.parent = value;
							node.g = num;
							node.h = 0;
							node.f = node.g + node.h;
							if (num2 >= 0)
							{
								this.m_ClosedList.RemoveAt(num2);
							}
							if (node2 != null)
							{
								this.m_OpenList.Remove(node2);
							}
							this.m_OpenList.AddLast(node);
						}
					}
				}
			}
			this.m_ClosedList.Add(value);
			return this.m_State;
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x0010B1C4 File Offset: 0x001093C4
		public void AddSuccessor(PathNode state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSuccessorPathNode_hotfix != null)
			{
				this.m_AddSuccessorPathNode_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Pathfinder.Node node = this.AllocateNode();
			node.m_UserState = state;
			this.m_Successors.Add(node);
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x0010B250 File Offset: 0x00109450
		public PathNode GetSolutionStart()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSolutionStart_hotfix != null)
			{
				return (PathNode)this.m_GetSolutionStart_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_CurrentSolutionNode = this.m_Start;
			if (this.m_Start != null)
			{
				return this.m_Start.m_UserState;
			}
			return null;
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x0010B2E0 File Offset: 0x001094E0
		public PathNode GetSolutionNext()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSolutionNext_hotfix != null)
			{
				return (PathNode)this.m_GetSolutionNext_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_CurrentSolutionNode != null && this.m_CurrentSolutionNode.child != null)
			{
				Pathfinder.Node child = this.m_CurrentSolutionNode.child;
				this.m_CurrentSolutionNode = this.m_CurrentSolutionNode.child;
				return child.m_UserState;
			}
			return null;
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x0010B38C File Offset: 0x0010958C
		public void FreeSolutionNodes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FreeSolutionNodes_hotfix != null)
			{
				this.m_FreeSolutionNodes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_OpenList.Clear();
			this.m_ClosedList.Clear();
			this.m_Successors.Clear();
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x0010B410 File Offset: 0x00109610
		public BattleMap Map
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Map_hotfix != null)
				{
					return (BattleMap)this.m_get_Map_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_Map;
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x0010B484 File Offset: 0x00109684
		public MoveType MoveType
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_MoveType_hotfix != null)
				{
					return (MoveType)this.m_get_MoveType_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_MoveType;
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x0010B4F8 File Offset: 0x001096F8
		public int IgnoreTeamNumber
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IgnoreTeamNumber_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_IgnoreTeamNumber_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_IgnoreTeamNumber;
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003A50 RID: 14928 RVA: 0x0010B56C File Offset: 0x0010976C
		public int OverrideMovePointCost
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_OverrideMovePointCost_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_OverrideMovePointCost_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_OverrideMovePointCost;
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x0010B5E0 File Offset: 0x001097E0
		public int InRegion
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_InRegion_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_InRegion_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_InRegion;
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003A52 RID: 14930 RVA: 0x0010B654 File Offset: 0x00109854
		public PathNode StartNode
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_StartNode_hotfix != null)
				{
					return (PathNode)this.m_get_StartNode_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_Start.m_UserState;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x0010B6CC File Offset: 0x001098CC
		public PathNode GoalNode
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GoalNode_hotfix != null)
				{
					return (PathNode)this.m_get_GoalNode_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_Goal.m_UserState;
			}
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x0010B744 File Offset: 0x00109944
		public bool HasStartNode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasStartNode_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasStartNode_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_Start != null;
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x0010B7BC File Offset: 0x001099BC
		public bool HasGoalNode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasGoalNode_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasGoalNode_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_Goal != null;
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x0010B834 File Offset: 0x00109A34
		public bool FindPath(BattleMap map, GridPosition start, GridPosition goal, int movePoint, MoveType moveType, int ignoreTeam, int overrideMovePointCost, int inRegion, List<GridPosition> path, bool findNearestIfFail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPathBattleMapGridPositionGridPositionInt32MoveTypeInt32Int32Int32List`1Boolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FindPathBattleMapGridPositionGridPositionInt32MoveTypeInt32Int32Int32List`1Boolean_hotfix.call(new object[]
				{
					this,
					map,
					start,
					goal,
					movePoint,
					moveType,
					ignoreTeam,
					overrideMovePointCost,
					inRegion,
					path,
					findNearestIfFail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			path.Clear();
			this.InitiatePathfind();
			this.m_Map = map;
			this.m_MovePoint = movePoint;
			this.m_MoveType = moveType;
			this.m_IgnoreTeamNumber = ignoreTeam;
			this.m_OverrideMovePointCost = overrideMovePointCost;
			this.m_InRegion = inRegion;
			PathNode pathNode = this.AllocatePathNode();
			pathNode.m_position = start;
			PathNode pathNode2 = this.AllocatePathNode();
			pathNode2.m_position = goal;
			this.SetStartAndGoalStates(pathNode, pathNode2);
			do
			{
				this.SearchStep();
			}
			while (this.m_State == Pathfinder.SearchState.Searching);
			if (this.m_State != Pathfinder.SearchState.Succeeded && findNearestIfFail)
			{
				Pathfinder.Node node = null;
				int num = int.MaxValue;
				int num2 = int.MaxValue;
				foreach (Pathfinder.Node node2 in this.m_ClosedList)
				{
					int num3 = GridPosition.Distance(node2.m_UserState.m_position, this.m_Goal.m_UserState.m_position);
					if (num3 < num)
					{
						node = node2;
						num = num3;
						num2 = node2.f;
					}
					else if (num3 == num && node2.f < num2)
					{
						node = node2;
						num2 = node2.f;
					}
				}
				if (node != null && node.parent != null)
				{
					Pathfinder.Node node3 = node;
					Pathfinder.Node parent = node.parent;
					do
					{
						parent.child = node3;
						node3 = parent;
						parent = parent.parent;
					}
					while (node3 != this.m_Start);
					this.m_State = Pathfinder.SearchState.Succeeded;
				}
			}
			if (this.m_State == Pathfinder.SearchState.Succeeded)
			{
				PathNode pathNode3 = this.GetSolutionStart();
				path.Add(pathNode3.m_position);
				for (;;)
				{
					pathNode3 = this.GetSolutionNext();
					if (pathNode3 == null)
					{
						break;
					}
					path.Add(pathNode3.m_position);
				}
				this.FreeSolutionNodes();
				return true;
			}
			this.FreeSolutionNodes();
			return false;
		}

		// Token: 0x06003A57 RID: 14935 RVA: 0x0010BB20 File Offset: 0x00109D20
		public bool FindRegion(BattleMap map, GridPosition start, int movePoint, MoveType moveType, int ignoreTeam, int overrideMoveCost, int inRegion, List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindRegionBattleMapGridPositionInt32MoveTypeInt32Int32Int32List`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FindRegionBattleMapGridPositionInt32MoveTypeInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					map,
					start,
					movePoint,
					moveType,
					ignoreTeam,
					overrideMoveCost,
					inRegion,
					region
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitiatePathfind();
			this.m_Map = map;
			this.m_MovePoint = movePoint;
			this.m_MoveType = moveType;
			this.m_IgnoreTeamNumber = ignoreTeam;
			this.m_OverrideMovePointCost = overrideMoveCost;
			this.m_InRegion = inRegion;
			PathNode pathNode = this.AllocatePathNode();
			pathNode.m_position = start;
			this.SetRegionStartState(pathNode);
			do
			{
				this.SearchRegionStep();
			}
			while (this.m_State == Pathfinder.SearchState.Searching);
			if (this.m_State == Pathfinder.SearchState.Succeeded)
			{
				foreach (Pathfinder.Node node in this.m_ClosedList)
				{
					region.Add(node.m_UserState.m_position);
				}
				this.FreeSolutionNodes();
				return true;
			}
			this.FreeSolutionNodes();
			return false;
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06003A58 RID: 14936 RVA: 0x0010BCE0 File Offset: 0x00109EE0
		// (set) Token: 0x06003A59 RID: 14937 RVA: 0x0010BD00 File Offset: 0x00109F00
		[DoNotToLua]
		public Pathfinder.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Pathfinder.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x0010BD0C File Offset: 0x00109F0C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_SortedAddToOpenListNode_hotfix = (luaObj.RawGet("SortedAddToOpenList") as LuaFunction);
					this.m_AllocateNode_hotfix = (luaObj.RawGet("AllocateNode") as LuaFunction);
					this.m_AllocatePathNode_hotfix = (luaObj.RawGet("AllocatePathNode") as LuaFunction);
					this.m_InitiatePathfind_hotfix = (luaObj.RawGet("InitiatePathfind") as LuaFunction);
					this.m_CancelSearch_hotfix = (luaObj.RawGet("CancelSearch") as LuaFunction);
					this.m_SetStartAndGoalStatesPathNodePathNode_hotfix = (luaObj.RawGet("SetStartAndGoalStates") as LuaFunction);
					this.m_SearchStep_hotfix = (luaObj.RawGet("SearchStep") as LuaFunction);
					this.m_SetRegionStartStatePathNode_hotfix = (luaObj.RawGet("SetRegionStartState") as LuaFunction);
					this.m_SearchRegionStep_hotfix = (luaObj.RawGet("SearchRegionStep") as LuaFunction);
					this.m_AddSuccessorPathNode_hotfix = (luaObj.RawGet("AddSuccessor") as LuaFunction);
					this.m_GetSolutionStart_hotfix = (luaObj.RawGet("GetSolutionStart") as LuaFunction);
					this.m_GetSolutionNext_hotfix = (luaObj.RawGet("GetSolutionNext") as LuaFunction);
					this.m_FreeSolutionNodes_hotfix = (luaObj.RawGet("FreeSolutionNodes") as LuaFunction);
					this.m_get_Map_hotfix = (luaObj.RawGet("get_Map") as LuaFunction);
					this.m_get_MoveType_hotfix = (luaObj.RawGet("get_MoveType") as LuaFunction);
					this.m_get_IgnoreTeamNumber_hotfix = (luaObj.RawGet("get_IgnoreTeamNumber") as LuaFunction);
					this.m_get_OverrideMovePointCost_hotfix = (luaObj.RawGet("get_OverrideMovePointCost") as LuaFunction);
					this.m_get_InRegion_hotfix = (luaObj.RawGet("get_InRegion") as LuaFunction);
					this.m_get_StartNode_hotfix = (luaObj.RawGet("get_StartNode") as LuaFunction);
					this.m_get_GoalNode_hotfix = (luaObj.RawGet("get_GoalNode") as LuaFunction);
					this.m_HasStartNode_hotfix = (luaObj.RawGet("HasStartNode") as LuaFunction);
					this.m_HasGoalNode_hotfix = (luaObj.RawGet("HasGoalNode") as LuaFunction);
					this.m_FindPathBattleMapGridPositionGridPositionInt32MoveTypeInt32Int32Int32List`1Boolean_hotfix = (luaObj.RawGet("FindPath") as LuaFunction);
					this.m_FindRegionBattleMapGridPositionInt32MoveTypeInt32Int32Int32List`1_hotfix = (luaObj.RawGet("FindRegion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x0010C048 File Offset: 0x0010A248
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Pathfinder));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002C9C RID: 11420
		private LinkedList<Pathfinder.Node> m_OpenList;

		// Token: 0x04002C9D RID: 11421
		private List<Pathfinder.Node> m_ClosedList;

		// Token: 0x04002C9E RID: 11422
		private List<Pathfinder.Node> m_Successors;

		// Token: 0x04002C9F RID: 11423
		private Pathfinder.SearchState m_State;

		// Token: 0x04002CA0 RID: 11424
		private int m_Steps;

		// Token: 0x04002CA1 RID: 11425
		private Pathfinder.Node m_Start;

		// Token: 0x04002CA2 RID: 11426
		private Pathfinder.Node m_Goal;

		// Token: 0x04002CA3 RID: 11427
		private Pathfinder.Node m_CurrentSolutionNode;

		// Token: 0x04002CA4 RID: 11428
		private bool m_CancelRequest;

		// Token: 0x04002CA5 RID: 11429
		private List<Pathfinder.Node> m_NodePool;

		// Token: 0x04002CA6 RID: 11430
		private int m_AllocateNodeCount;

		// Token: 0x04002CA7 RID: 11431
		private List<PathNode> m_PathNodePool;

		// Token: 0x04002CA8 RID: 11432
		private int m_AllocatedPathNodeCount;

		// Token: 0x04002CA9 RID: 11433
		private const int kPreallocatedNodes = 64;

		// Token: 0x04002CAA RID: 11434
		private BattleMap m_Map;

		// Token: 0x04002CAB RID: 11435
		private int m_MovePoint;

		// Token: 0x04002CAC RID: 11436
		private MoveType m_MoveType;

		// Token: 0x04002CAD RID: 11437
		private int m_IgnoreTeamNumber;

		// Token: 0x04002CAE RID: 11438
		private int m_InRegion;

		// Token: 0x04002CAF RID: 11439
		private int m_OverrideMovePointCost;

		// Token: 0x04002CB0 RID: 11440
		[DoNotToLua]
		private Pathfinder.LuaExportHelper luaExportHelper;

		// Token: 0x04002CB1 RID: 11441
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002CB2 RID: 11442
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002CB3 RID: 11443
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002CB4 RID: 11444
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04002CB5 RID: 11445
		private LuaFunction m_SortedAddToOpenListNode_hotfix;

		// Token: 0x04002CB6 RID: 11446
		private LuaFunction m_AllocateNode_hotfix;

		// Token: 0x04002CB7 RID: 11447
		private LuaFunction m_AllocatePathNode_hotfix;

		// Token: 0x04002CB8 RID: 11448
		private LuaFunction m_InitiatePathfind_hotfix;

		// Token: 0x04002CB9 RID: 11449
		private LuaFunction m_CancelSearch_hotfix;

		// Token: 0x04002CBA RID: 11450
		private LuaFunction m_SetStartAndGoalStatesPathNodePathNode_hotfix;

		// Token: 0x04002CBB RID: 11451
		private LuaFunction m_SearchStep_hotfix;

		// Token: 0x04002CBC RID: 11452
		private LuaFunction m_SetRegionStartStatePathNode_hotfix;

		// Token: 0x04002CBD RID: 11453
		private LuaFunction m_SearchRegionStep_hotfix;

		// Token: 0x04002CBE RID: 11454
		private LuaFunction m_AddSuccessorPathNode_hotfix;

		// Token: 0x04002CBF RID: 11455
		private LuaFunction m_GetSolutionStart_hotfix;

		// Token: 0x04002CC0 RID: 11456
		private LuaFunction m_GetSolutionNext_hotfix;

		// Token: 0x04002CC1 RID: 11457
		private LuaFunction m_FreeSolutionNodes_hotfix;

		// Token: 0x04002CC2 RID: 11458
		private LuaFunction m_get_Map_hotfix;

		// Token: 0x04002CC3 RID: 11459
		private LuaFunction m_get_MoveType_hotfix;

		// Token: 0x04002CC4 RID: 11460
		private LuaFunction m_get_IgnoreTeamNumber_hotfix;

		// Token: 0x04002CC5 RID: 11461
		private LuaFunction m_get_OverrideMovePointCost_hotfix;

		// Token: 0x04002CC6 RID: 11462
		private LuaFunction m_get_InRegion_hotfix;

		// Token: 0x04002CC7 RID: 11463
		private LuaFunction m_get_StartNode_hotfix;

		// Token: 0x04002CC8 RID: 11464
		private LuaFunction m_get_GoalNode_hotfix;

		// Token: 0x04002CC9 RID: 11465
		private LuaFunction m_HasStartNode_hotfix;

		// Token: 0x04002CCA RID: 11466
		private LuaFunction m_HasGoalNode_hotfix;

		// Token: 0x04002CCB RID: 11467
		private LuaFunction m_FindPathBattleMapGridPositionGridPositionInt32MoveTypeInt32Int32Int32List;

		// Token: 0x04002CCC RID: 11468
		private LuaFunction m_FindRegionBattleMapGridPositionInt32MoveTypeInt32Int32Int32List;

		// Token: 0x020003CD RID: 973
		public enum SearchState
		{
			// Token: 0x04002CCE RID: 11470
			NotInitialized,
			// Token: 0x04002CCF RID: 11471
			Searching,
			// Token: 0x04002CD0 RID: 11472
			Succeeded,
			// Token: 0x04002CD1 RID: 11473
			Failed
		}

		// Token: 0x020003CE RID: 974
		[HotFix]
		public class Node
		{
			// Token: 0x06003A5C RID: 14940 RVA: 0x0010C0B0 File Offset: 0x0010A2B0
			public Node()
			{
				this.Reinitialize();
			}

			// Token: 0x06003A5D RID: 14941 RVA: 0x0010C0C0 File Offset: 0x0010A2C0
			public void Reinitialize()
			{
				this.parent = null;
				this.child = null;
				this.g = 0;
				this.h = 0;
				this.f = 0;
			}

			// Token: 0x04002CD2 RID: 11474
			public Pathfinder.Node parent;

			// Token: 0x04002CD3 RID: 11475
			public Pathfinder.Node child;

			// Token: 0x04002CD4 RID: 11476
			public int g;

			// Token: 0x04002CD5 RID: 11477
			public int h;

			// Token: 0x04002CD6 RID: 11478
			public int f;

			// Token: 0x04002CD7 RID: 11479
			public PathNode m_UserState;
		}

		// Token: 0x020003CF RID: 975
		public class LuaExportHelper
		{
			// Token: 0x06003A5E RID: 14942 RVA: 0x0010C0E8 File Offset: 0x0010A2E8
			public LuaExportHelper(Pathfinder owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000FDE RID: 4062
			// (get) Token: 0x06003A5F RID: 14943 RVA: 0x0010C0F8 File Offset: 0x0010A2F8
			// (set) Token: 0x06003A60 RID: 14944 RVA: 0x0010C108 File Offset: 0x0010A308
			public LinkedList<Pathfinder.Node> m_OpenList
			{
				get
				{
					return this.m_owner.m_OpenList;
				}
				set
				{
					this.m_owner.m_OpenList = value;
				}
			}

			// Token: 0x17000FDF RID: 4063
			// (get) Token: 0x06003A61 RID: 14945 RVA: 0x0010C118 File Offset: 0x0010A318
			// (set) Token: 0x06003A62 RID: 14946 RVA: 0x0010C128 File Offset: 0x0010A328
			public List<Pathfinder.Node> m_ClosedList
			{
				get
				{
					return this.m_owner.m_ClosedList;
				}
				set
				{
					this.m_owner.m_ClosedList = value;
				}
			}

			// Token: 0x17000FE0 RID: 4064
			// (get) Token: 0x06003A63 RID: 14947 RVA: 0x0010C138 File Offset: 0x0010A338
			// (set) Token: 0x06003A64 RID: 14948 RVA: 0x0010C148 File Offset: 0x0010A348
			public List<Pathfinder.Node> m_Successors
			{
				get
				{
					return this.m_owner.m_Successors;
				}
				set
				{
					this.m_owner.m_Successors = value;
				}
			}

			// Token: 0x17000FE1 RID: 4065
			// (get) Token: 0x06003A65 RID: 14949 RVA: 0x0010C158 File Offset: 0x0010A358
			// (set) Token: 0x06003A66 RID: 14950 RVA: 0x0010C168 File Offset: 0x0010A368
			public Pathfinder.SearchState m_State
			{
				get
				{
					return this.m_owner.m_State;
				}
				set
				{
					this.m_owner.m_State = value;
				}
			}

			// Token: 0x17000FE2 RID: 4066
			// (get) Token: 0x06003A67 RID: 14951 RVA: 0x0010C178 File Offset: 0x0010A378
			// (set) Token: 0x06003A68 RID: 14952 RVA: 0x0010C188 File Offset: 0x0010A388
			public int m_Steps
			{
				get
				{
					return this.m_owner.m_Steps;
				}
				set
				{
					this.m_owner.m_Steps = value;
				}
			}

			// Token: 0x17000FE3 RID: 4067
			// (get) Token: 0x06003A69 RID: 14953 RVA: 0x0010C198 File Offset: 0x0010A398
			// (set) Token: 0x06003A6A RID: 14954 RVA: 0x0010C1A8 File Offset: 0x0010A3A8
			public Pathfinder.Node m_Start
			{
				get
				{
					return this.m_owner.m_Start;
				}
				set
				{
					this.m_owner.m_Start = value;
				}
			}

			// Token: 0x17000FE4 RID: 4068
			// (get) Token: 0x06003A6B RID: 14955 RVA: 0x0010C1B8 File Offset: 0x0010A3B8
			// (set) Token: 0x06003A6C RID: 14956 RVA: 0x0010C1C8 File Offset: 0x0010A3C8
			public Pathfinder.Node m_Goal
			{
				get
				{
					return this.m_owner.m_Goal;
				}
				set
				{
					this.m_owner.m_Goal = value;
				}
			}

			// Token: 0x17000FE5 RID: 4069
			// (get) Token: 0x06003A6D RID: 14957 RVA: 0x0010C1D8 File Offset: 0x0010A3D8
			// (set) Token: 0x06003A6E RID: 14958 RVA: 0x0010C1E8 File Offset: 0x0010A3E8
			public Pathfinder.Node m_CurrentSolutionNode
			{
				get
				{
					return this.m_owner.m_CurrentSolutionNode;
				}
				set
				{
					this.m_owner.m_CurrentSolutionNode = value;
				}
			}

			// Token: 0x17000FE6 RID: 4070
			// (get) Token: 0x06003A6F RID: 14959 RVA: 0x0010C1F8 File Offset: 0x0010A3F8
			// (set) Token: 0x06003A70 RID: 14960 RVA: 0x0010C208 File Offset: 0x0010A408
			public bool m_CancelRequest
			{
				get
				{
					return this.m_owner.m_CancelRequest;
				}
				set
				{
					this.m_owner.m_CancelRequest = value;
				}
			}

			// Token: 0x17000FE7 RID: 4071
			// (get) Token: 0x06003A71 RID: 14961 RVA: 0x0010C218 File Offset: 0x0010A418
			// (set) Token: 0x06003A72 RID: 14962 RVA: 0x0010C228 File Offset: 0x0010A428
			public List<Pathfinder.Node> m_NodePool
			{
				get
				{
					return this.m_owner.m_NodePool;
				}
				set
				{
					this.m_owner.m_NodePool = value;
				}
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x06003A73 RID: 14963 RVA: 0x0010C238 File Offset: 0x0010A438
			// (set) Token: 0x06003A74 RID: 14964 RVA: 0x0010C248 File Offset: 0x0010A448
			public int m_AllocateNodeCount
			{
				get
				{
					return this.m_owner.m_AllocateNodeCount;
				}
				set
				{
					this.m_owner.m_AllocateNodeCount = value;
				}
			}

			// Token: 0x17000FE9 RID: 4073
			// (get) Token: 0x06003A75 RID: 14965 RVA: 0x0010C258 File Offset: 0x0010A458
			// (set) Token: 0x06003A76 RID: 14966 RVA: 0x0010C268 File Offset: 0x0010A468
			public List<PathNode> m_PathNodePool
			{
				get
				{
					return this.m_owner.m_PathNodePool;
				}
				set
				{
					this.m_owner.m_PathNodePool = value;
				}
			}

			// Token: 0x17000FEA RID: 4074
			// (get) Token: 0x06003A77 RID: 14967 RVA: 0x0010C278 File Offset: 0x0010A478
			// (set) Token: 0x06003A78 RID: 14968 RVA: 0x0010C288 File Offset: 0x0010A488
			public int m_AllocatedPathNodeCount
			{
				get
				{
					return this.m_owner.m_AllocatedPathNodeCount;
				}
				set
				{
					this.m_owner.m_AllocatedPathNodeCount = value;
				}
			}

			// Token: 0x17000FEB RID: 4075
			// (get) Token: 0x06003A79 RID: 14969 RVA: 0x0010C298 File Offset: 0x0010A498
			public static int kPreallocatedNodes
			{
				get
				{
					return 64;
				}
			}

			// Token: 0x17000FEC RID: 4076
			// (get) Token: 0x06003A7A RID: 14970 RVA: 0x0010C29C File Offset: 0x0010A49C
			// (set) Token: 0x06003A7B RID: 14971 RVA: 0x0010C2AC File Offset: 0x0010A4AC
			public BattleMap m_Map
			{
				get
				{
					return this.m_owner.m_Map;
				}
				set
				{
					this.m_owner.m_Map = value;
				}
			}

			// Token: 0x17000FED RID: 4077
			// (get) Token: 0x06003A7C RID: 14972 RVA: 0x0010C2BC File Offset: 0x0010A4BC
			// (set) Token: 0x06003A7D RID: 14973 RVA: 0x0010C2CC File Offset: 0x0010A4CC
			public int m_MovePoint
			{
				get
				{
					return this.m_owner.m_MovePoint;
				}
				set
				{
					this.m_owner.m_MovePoint = value;
				}
			}

			// Token: 0x17000FEE RID: 4078
			// (get) Token: 0x06003A7E RID: 14974 RVA: 0x0010C2DC File Offset: 0x0010A4DC
			// (set) Token: 0x06003A7F RID: 14975 RVA: 0x0010C2EC File Offset: 0x0010A4EC
			public MoveType m_MoveType
			{
				get
				{
					return this.m_owner.m_MoveType;
				}
				set
				{
					this.m_owner.m_MoveType = value;
				}
			}

			// Token: 0x17000FEF RID: 4079
			// (get) Token: 0x06003A80 RID: 14976 RVA: 0x0010C2FC File Offset: 0x0010A4FC
			// (set) Token: 0x06003A81 RID: 14977 RVA: 0x0010C30C File Offset: 0x0010A50C
			public int m_IgnoreTeamNumber
			{
				get
				{
					return this.m_owner.m_IgnoreTeamNumber;
				}
				set
				{
					this.m_owner.m_IgnoreTeamNumber = value;
				}
			}

			// Token: 0x17000FF0 RID: 4080
			// (get) Token: 0x06003A82 RID: 14978 RVA: 0x0010C31C File Offset: 0x0010A51C
			// (set) Token: 0x06003A83 RID: 14979 RVA: 0x0010C32C File Offset: 0x0010A52C
			public int m_InRegion
			{
				get
				{
					return this.m_owner.m_InRegion;
				}
				set
				{
					this.m_owner.m_InRegion = value;
				}
			}

			// Token: 0x17000FF1 RID: 4081
			// (get) Token: 0x06003A84 RID: 14980 RVA: 0x0010C33C File Offset: 0x0010A53C
			// (set) Token: 0x06003A85 RID: 14981 RVA: 0x0010C34C File Offset: 0x0010A54C
			public int m_OverrideMovePointCost
			{
				get
				{
					return this.m_owner.m_OverrideMovePointCost;
				}
				set
				{
					this.m_owner.m_OverrideMovePointCost = value;
				}
			}

			// Token: 0x06003A86 RID: 14982 RVA: 0x0010C35C File Offset: 0x0010A55C
			public void SortedAddToOpenList(Pathfinder.Node node)
			{
				this.m_owner.SortedAddToOpenList(node);
			}

			// Token: 0x06003A87 RID: 14983 RVA: 0x0010C36C File Offset: 0x0010A56C
			public Pathfinder.Node AllocateNode()
			{
				return this.m_owner.AllocateNode();
			}

			// Token: 0x06003A88 RID: 14984 RVA: 0x0010C37C File Offset: 0x0010A57C
			public void SetRegionStartState(PathNode start)
			{
				this.m_owner.SetRegionStartState(start);
			}

			// Token: 0x06003A89 RID: 14985 RVA: 0x0010C38C File Offset: 0x0010A58C
			public Pathfinder.SearchState SearchRegionStep()
			{
				return this.m_owner.SearchRegionStep();
			}

			// Token: 0x04002CD8 RID: 11480
			private Pathfinder m_owner;
		}
	}
}
