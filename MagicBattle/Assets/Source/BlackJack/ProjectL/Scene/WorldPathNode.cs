using System;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200098D RID: 2445
	[CustomLuaClass]
	public class WorldPathNode
	{
		// Token: 0x06008D0B RID: 36107 RVA: 0x00292850 File Offset: 0x00290A50
		public bool IsSameState(WorldPathNode rhs)
		{
			return this.m_waypointInfo == rhs.m_waypointInfo;
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x00292860 File Offset: 0x00290A60
		public float GetGoalHeuristic(WorldPathfinder pathfinder)
		{
			return Vector2.Distance(pathfinder.GoalNode.m_position, this.m_position);
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x00292878 File Offset: 0x00290A78
		public float GetCost(WorldPathfinder pathfinder, WorldPathNode successor)
		{
			return Vector2.Distance(this.m_position, successor.m_position);
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x0029288C File Offset: 0x00290A8C
		public void GetSuccessors(WorldPathfinder pathfinder, WorldPathNode parentNode)
		{
			foreach (int id in this.m_waypointInfo.Waypoints_ID)
			{
				this.AddSuccessor(pathfinder, id, parentNode);
			}
		}

		// Token: 0x06008D0F RID: 36111 RVA: 0x002928F0 File Offset: 0x00290AF0
		private void AddSuccessor(WorldPathfinder pathfinder, int id, WorldPathNode parentNode)
		{
			ConfigDataWaypointInfo configDataWaypointInfo;
			Vector2 position;
			if (!pathfinder.GetWaypoint(id, out configDataWaypointInfo, out position))
			{
				return;
			}
			if (parentNode != null && configDataWaypointInfo == parentNode.m_waypointInfo)
			{
				return;
			}
			if ((!pathfinder.HasGoalNode() || configDataWaypointInfo != pathfinder.GoalNode.m_waypointInfo) && !pathfinder.CanMoveToWaypoint(id))
			{
				return;
			}
			WorldPathNode worldPathNode = pathfinder.AllocatePathNode();
			worldPathNode.m_waypointInfo = configDataWaypointInfo;
			worldPathNode.m_position = position;
			pathfinder.AddSuccessor(worldPathNode);
		}

		// Token: 0x04006426 RID: 25638
		public ConfigDataWaypointInfo m_waypointInfo;

		// Token: 0x04006427 RID: 25639
		public Vector2 m_position;
	}
}
