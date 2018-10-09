using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200098E RID: 2446
	[CustomLuaClass]
	public class WorldPathfinder
	{
		// Token: 0x06008D10 RID: 36112 RVA: 0x00292968 File Offset: 0x00290B68
		public WorldPathfinder()
		{
			this.m_OpenList = new LinkedList<WorldPathfinder.Node>();
			this.m_ClosedList = new List<WorldPathfinder.Node>();
			this.m_Successors = new List<WorldPathfinder.Node>();
			this.m_NodePool = new List<WorldPathfinder.Node>(64);
			this.m_PathNodePool = new List<WorldPathNode>(64);
			for (int i = 0; i < 64; i++)
			{
				this.m_NodePool.Add(new WorldPathfinder.Node());
				this.m_PathNodePool.Add(new WorldPathNode());
			}
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x002929EC File Offset: 0x00290BEC
		public void Dispose()
		{
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
			this.m_clientWorld = null;
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x00292A94 File Offset: 0x00290C94
		private void SortedAddToOpenList(WorldPathfinder.Node node)
		{
			LinkedListNode<WorldPathfinder.Node> linkedListNode;
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

		// Token: 0x06008D13 RID: 36115 RVA: 0x00292B00 File Offset: 0x00290D00
		private WorldPathfinder.Node AllocateNode()
		{
			if (this.m_AllocateNodeCount >= this.m_NodePool.Count)
			{
				this.m_NodePool.Add(new WorldPathfinder.Node());
			}
			WorldPathfinder.Node node = this.m_NodePool[this.m_AllocateNodeCount++];
			node.Reinitialize();
			return node;
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x00292B58 File Offset: 0x00290D58
		public WorldPathNode AllocatePathNode()
		{
			if (this.m_AllocatedPathNodeCount >= this.m_PathNodePool.Count)
			{
				this.m_PathNodePool.Add(new WorldPathNode());
			}
			return this.m_PathNodePool[this.m_AllocatedPathNodeCount++];
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x00292BA8 File Offset: 0x00290DA8
		public void InitiatePathfind()
		{
			this.m_CancelRequest = false;
			this.m_AllocateNodeCount = 0;
			this.m_AllocatedPathNodeCount = 0;
		}

		// Token: 0x06008D16 RID: 36118 RVA: 0x00292BC0 File Offset: 0x00290DC0
		public void CancelSearch()
		{
			this.m_CancelRequest = true;
		}

		// Token: 0x06008D17 RID: 36119 RVA: 0x00292BCC File Offset: 0x00290DCC
		public void SetStartAndGoalStates(WorldPathNode start, WorldPathNode goal)
		{
			this.m_Start = this.AllocateNode();
			this.m_Goal = this.AllocateNode();
			this.m_Start.m_UserState = start;
			this.m_Goal.m_UserState = goal;
			this.m_State = WorldPathfinder.SearchState.Searching;
			this.m_Start.g = 0f;
			this.m_Start.h = this.m_Start.m_UserState.GetGoalHeuristic(this);
			this.m_Start.f = this.m_Start.g + this.m_Start.h;
			this.m_Start.parent = null;
			this.m_OpenList.AddLast(this.m_Start);
			this.m_Steps = 0;
		}

		// Token: 0x06008D18 RID: 36120 RVA: 0x00292C84 File Offset: 0x00290E84
		public WorldPathfinder.SearchState SearchStep()
		{
			if (this.m_State == WorldPathfinder.SearchState.NotInitialized || this.m_State == WorldPathfinder.SearchState.Succeeded || this.m_State == WorldPathfinder.SearchState.Failed)
			{
				return this.m_State;
			}
			if (this.m_OpenList.Count == 0 || this.m_CancelRequest)
			{
				this.FreeSolutionNodes();
				this.m_State = WorldPathfinder.SearchState.Failed;
				return this.m_State;
			}
			this.m_Steps++;
			WorldPathfinder.Node value = this.m_OpenList.First.Value;
			this.m_OpenList.RemoveFirst();
			if (value.m_UserState.IsSameState(this.m_Goal.m_UserState))
			{
				this.m_Goal.parent = value.parent;
				this.m_Goal.g = value.g;
				if (!value.m_UserState.IsSameState(this.m_Start.m_UserState))
				{
					WorldPathfinder.Node node = this.m_Goal;
					WorldPathfinder.Node parent = this.m_Goal.parent;
					do
					{
						parent.child = node;
						node = parent;
						parent = parent.parent;
					}
					while (node != this.m_Start);
				}
				this.m_State = WorldPathfinder.SearchState.Succeeded;
				return this.m_State;
			}
			this.m_Successors.Clear();
			value.m_UserState.GetSuccessors(this, (value.parent == null) ? null : value.parent.m_UserState);
			WorldPathfinder.Node node2 = null;
			int count = this.m_Successors.Count;
			for (int i = 0; i < count; i++)
			{
				node2 = this.m_Successors[i];
				float num = value.g + value.m_UserState.GetCost(this, node2.m_UserState);
				WorldPathfinder.Node node3 = null;
				foreach (WorldPathfinder.Node node4 in this.m_OpenList)
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
			this.m_ClosedList.Add(value);
			return this.m_State;
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x00292FA4 File Offset: 0x002911A4
		public void AddSuccessor(WorldPathNode state)
		{
			WorldPathfinder.Node node = this.AllocateNode();
			node.m_UserState = state;
			this.m_Successors.Add(node);
		}

		// Token: 0x06008D1A RID: 36122 RVA: 0x00292FCC File Offset: 0x002911CC
		public WorldPathNode GetSolutionStart()
		{
			this.m_CurrentSolutionNode = this.m_Start;
			if (this.m_Start != null)
			{
				return this.m_Start.m_UserState;
			}
			return null;
		}

		// Token: 0x06008D1B RID: 36123 RVA: 0x00292FF4 File Offset: 0x002911F4
		public WorldPathNode GetSolutionNext()
		{
			if (this.m_CurrentSolutionNode != null && this.m_CurrentSolutionNode.child != null)
			{
				WorldPathfinder.Node child = this.m_CurrentSolutionNode.child;
				this.m_CurrentSolutionNode = this.m_CurrentSolutionNode.child;
				return child.m_UserState;
			}
			return null;
		}

		// Token: 0x06008D1C RID: 36124 RVA: 0x00293044 File Offset: 0x00291244
		public void FreeSolutionNodes()
		{
			this.m_OpenList.Clear();
			this.m_ClosedList.Clear();
			this.m_Successors.Clear();
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06008D1D RID: 36125 RVA: 0x00293068 File Offset: 0x00291268
		public WorldPathNode StartNode
		{
			get
			{
				return this.m_Start.m_UserState;
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06008D1E RID: 36126 RVA: 0x00293078 File Offset: 0x00291278
		public WorldPathNode GoalNode
		{
			get
			{
				return this.m_Goal.m_UserState;
			}
		}

		// Token: 0x06008D1F RID: 36127 RVA: 0x00293088 File Offset: 0x00291288
		public bool HasStartNode()
		{
			return this.m_Start != null;
		}

		// Token: 0x06008D20 RID: 36128 RVA: 0x00293098 File Offset: 0x00291298
		public bool HasGoalNode()
		{
			return this.m_Goal != null;
		}

		// Token: 0x06008D21 RID: 36129 RVA: 0x002930A8 File Offset: 0x002912A8
		public bool GetWaypoint(int id, out ConfigDataWaypointInfo waypointInfo, out Vector2 position)
		{
			ClientWorldWaypoint waypoint = this.m_clientWorld.GetWaypoint(id);
			if (waypoint != null)
			{
				waypointInfo = waypoint.WaypointInfo;
				position = waypoint.Position;
				return true;
			}
			waypointInfo = null;
			position = Vector2.zero;
			return false;
		}

		// Token: 0x06008D22 RID: 36130 RVA: 0x002930F0 File Offset: 0x002912F0
		public bool CanMoveToWaypoint(int id)
		{
			WayPointStatus waypointStatus = this.m_clientWorld.PlayerContext.GetWaypointStatus(id);
			if (this.m_isCheckWaypointStatus)
			{
				return waypointStatus == WayPointStatus.Arrived || waypointStatus == WayPointStatus.Public;
			}
			return waypointStatus == WayPointStatus.Arrived || waypointStatus == WayPointStatus.Public || waypointStatus == WayPointStatus.Open;
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00293140 File Offset: 0x00291340
		public bool FindPath(ClientWorld world, int start, int goal, List<int> path, bool checkWaypointStatus)
		{
			this.InitiatePathfind();
			this.m_clientWorld = world;
			this.m_isCheckWaypointStatus = checkWaypointStatus;
			ConfigDataWaypointInfo waypointInfo;
			Vector2 position;
			if (!this.GetWaypoint(start, out waypointInfo, out position))
			{
				return false;
			}
			ConfigDataWaypointInfo waypointInfo2;
			Vector2 position2;
			if (!this.GetWaypoint(goal, out waypointInfo2, out position2))
			{
				return false;
			}
			WorldPathNode worldPathNode = this.AllocatePathNode();
			worldPathNode.m_waypointInfo = waypointInfo;
			worldPathNode.m_position = position;
			WorldPathNode worldPathNode2 = this.AllocatePathNode();
			worldPathNode2.m_waypointInfo = waypointInfo2;
			worldPathNode2.m_position = position2;
			this.SetStartAndGoalStates(worldPathNode, worldPathNode2);
			do
			{
				this.SearchStep();
			}
			while (this.m_State == WorldPathfinder.SearchState.Searching);
			if (this.m_State == WorldPathfinder.SearchState.Succeeded)
			{
				WorldPathNode worldPathNode3 = this.GetSolutionStart();
				path.Add(worldPathNode3.m_waypointInfo.ID);
				for (;;)
				{
					worldPathNode3 = this.GetSolutionNext();
					if (worldPathNode3 == null)
					{
						break;
					}
					path.Add(worldPathNode3.m_waypointInfo.ID);
				}
				this.FreeSolutionNodes();
				return true;
			}
			return false;
		}

		// Token: 0x04006428 RID: 25640
		private LinkedList<WorldPathfinder.Node> m_OpenList;

		// Token: 0x04006429 RID: 25641
		private List<WorldPathfinder.Node> m_ClosedList;

		// Token: 0x0400642A RID: 25642
		private List<WorldPathfinder.Node> m_Successors;

		// Token: 0x0400642B RID: 25643
		private WorldPathfinder.SearchState m_State;

		// Token: 0x0400642C RID: 25644
		private int m_Steps;

		// Token: 0x0400642D RID: 25645
		private WorldPathfinder.Node m_Start;

		// Token: 0x0400642E RID: 25646
		private WorldPathfinder.Node m_Goal;

		// Token: 0x0400642F RID: 25647
		private WorldPathfinder.Node m_CurrentSolutionNode;

		// Token: 0x04006430 RID: 25648
		private bool m_CancelRequest;

		// Token: 0x04006431 RID: 25649
		private List<WorldPathfinder.Node> m_NodePool;

		// Token: 0x04006432 RID: 25650
		private int m_AllocateNodeCount;

		// Token: 0x04006433 RID: 25651
		private List<WorldPathNode> m_PathNodePool;

		// Token: 0x04006434 RID: 25652
		private int m_AllocatedPathNodeCount;

		// Token: 0x04006435 RID: 25653
		private const int kPreallocatedNodes = 64;

		// Token: 0x04006436 RID: 25654
		private ClientWorld m_clientWorld;

		// Token: 0x04006437 RID: 25655
		private bool m_isCheckWaypointStatus;

		// Token: 0x0200098F RID: 2447
		public enum SearchState
		{
			// Token: 0x04006439 RID: 25657
			NotInitialized,
			// Token: 0x0400643A RID: 25658
			Searching,
			// Token: 0x0400643B RID: 25659
			Succeeded,
			// Token: 0x0400643C RID: 25660
			Failed
		}

		// Token: 0x02000990 RID: 2448
		[CustomLuaClass]
		public class Node
		{
			// Token: 0x06008D24 RID: 36132 RVA: 0x00293230 File Offset: 0x00291430
			public Node()
			{
				this.Reinitialize();
			}

			// Token: 0x06008D25 RID: 36133 RVA: 0x00293240 File Offset: 0x00291440
			public void Reinitialize()
			{
				this.parent = null;
				this.child = null;
				this.g = 0f;
				this.h = 0f;
				this.f = 0f;
			}

			// Token: 0x0400643D RID: 25661
			public WorldPathfinder.Node parent;

			// Token: 0x0400643E RID: 25662
			public WorldPathfinder.Node child;

			// Token: 0x0400643F RID: 25663
			public float g;

			// Token: 0x04006440 RID: 25664
			public float h;

			// Token: 0x04006441 RID: 25665
			public float f;

			// Token: 0x04006442 RID: 25666
			public WorldPathNode m_UserState;
		}
	}
}
