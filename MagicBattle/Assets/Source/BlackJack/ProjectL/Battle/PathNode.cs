using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003CA RID: 970
	[HotFix]
	public class PathNode
	{
		// Token: 0x06003A32 RID: 14898 RVA: 0x00109DA4 File Offset: 0x00107FA4
		public PathNode()
		{
			this.m_position.Set(-1, -1);
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

		// Token: 0x06003A33 RID: 14899 RVA: 0x00109E18 File Offset: 0x00108018
		public bool IsSameState(PathNode rhs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSameStatePathNode_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSameStatePathNode_hotfix.call(new object[]
				{
					this,
					rhs
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_position == rhs.m_position;
		}

		// Token: 0x06003A34 RID: 14900 RVA: 0x00109EA8 File Offset: 0x001080A8
		public int GetGoalHeuristic(Pathfinder pathfinder)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGoalHeuristicPathfinder_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGoalHeuristicPathfinder_hotfix.call(new object[]
				{
					this,
					pathfinder
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return GridPosition.Distance(pathfinder.GoalNode.m_position, this.m_position);
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x00109F3C File Offset: 0x0010813C
		public int GetCost(Pathfinder pathfinder, PathNode successor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCostPathfinderPathNode_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCostPathfinderPathNode_hotfix.call(new object[]
				{
					this,
					pathfinder,
					successor
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = pathfinder.Map.GetMovePointCost(successor.m_position, pathfinder.MoveType);
			if (num > 0 && pathfinder.OverrideMovePointCost > 0)
			{
				num = pathfinder.OverrideMovePointCost;
			}
			return num;
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x00109FFC File Offset: 0x001081FC
		public void GetSuccessors(Pathfinder pathfinder, PathNode parentNode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSuccessorsPathfinderPathNode_hotfix != null)
			{
				this.m_GetSuccessorsPathfinderPathNode_hotfix.call(new object[]
				{
					this,
					pathfinder,
					parentNode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition position = new GridPosition(-1, -1);
			if (parentNode != null)
			{
				position = parentNode.m_position;
			}
			this.AddSuccessor(pathfinder, 0, 1, position);
			this.AddSuccessor(pathfinder, 0, -1, position);
			this.AddSuccessor(pathfinder, 1, 0, position);
			this.AddSuccessor(pathfinder, -1, 0, position);
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x0010A0BC File Offset: 0x001082BC
		private void AddSuccessor(Pathfinder pathfinder, int dx, int dy, GridPosition parentPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSuccessorPathfinderInt32Int32GridPosition_hotfix != null)
			{
				this.m_AddSuccessorPathfinderInt32Int32GridPosition_hotfix.call(new object[]
				{
					this,
					pathfinder,
					dx,
					dy,
					parentPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition gridPosition = new GridPosition(this.m_position.x + dx, this.m_position.y + dy);
			if (gridPosition == parentPos)
			{
				return;
			}
			if (!pathfinder.Map.IsValidPosition(gridPosition))
			{
				return;
			}
			if (pathfinder.Map.GetMovePointCost(gridPosition, pathfinder.MoveType) <= 0)
			{
				return;
			}
			if (!pathfinder.HasGoalNode() || gridPosition != pathfinder.GoalNode.m_position)
			{
				if (pathfinder.InRegion != 0 && pathfinder.Map.GetRegion(gridPosition) != pathfinder.InRegion)
				{
					return;
				}
				if (pathfinder.IgnoreTeamNumber >= 0)
				{
					BattleActor actor = pathfinder.Map.GetActor(gridPosition);
					if (actor != null && actor.TeamNumber != pathfinder.IgnoreTeamNumber)
					{
						return;
					}
				}
			}
			PathNode pathNode = pathfinder.AllocatePathNode();
			pathNode.m_position = gridPosition;
			pathfinder.AddSuccessor(pathNode);
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x0010A240 File Offset: 0x00108440
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x0010A260 File Offset: 0x00108460
		[DoNotToLua]
		public PathNode.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PathNode.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x0010A26C File Offset: 0x0010846C
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
					this.m_IsSameStatePathNode_hotfix = (luaObj.RawGet("IsSameState") as LuaFunction);
					this.m_GetGoalHeuristicPathfinder_hotfix = (luaObj.RawGet("GetGoalHeuristic") as LuaFunction);
					this.m_GetCostPathfinderPathNode_hotfix = (luaObj.RawGet("GetCost") as LuaFunction);
					this.m_GetSuccessorsPathfinderPathNode_hotfix = (luaObj.RawGet("GetSuccessors") as LuaFunction);
					this.m_AddSuccessorPathfinderInt32Int32GridPosition_hotfix = (luaObj.RawGet("AddSuccessor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x0010A3B4 File Offset: 0x001085B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PathNode));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002C91 RID: 11409
		public GridPosition m_position;

		// Token: 0x04002C92 RID: 11410
		[DoNotToLua]
		private PathNode.LuaExportHelper luaExportHelper;

		// Token: 0x04002C93 RID: 11411
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002C94 RID: 11412
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002C95 RID: 11413
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002C96 RID: 11414
		private LuaFunction m_IsSameStatePathNode_hotfix;

		// Token: 0x04002C97 RID: 11415
		private LuaFunction m_GetGoalHeuristicPathfinder_hotfix;

		// Token: 0x04002C98 RID: 11416
		private LuaFunction m_GetCostPathfinderPathNode_hotfix;

		// Token: 0x04002C99 RID: 11417
		private LuaFunction m_GetSuccessorsPathfinderPathNode_hotfix;

		// Token: 0x04002C9A RID: 11418
		private LuaFunction m_AddSuccessorPathfinderInt32Int32GridPosition_hotfix;

		// Token: 0x020003CB RID: 971
		public class LuaExportHelper
		{
			// Token: 0x06003A3C RID: 14908 RVA: 0x0010A41C File Offset: 0x0010861C
			public LuaExportHelper(PathNode owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06003A3D RID: 14909 RVA: 0x0010A42C File Offset: 0x0010862C
			public void AddSuccessor(Pathfinder pathfinder, int dx, int dy, GridPosition parentPos)
			{
				this.m_owner.AddSuccessor(pathfinder, dx, dy, parentPos);
			}

			// Token: 0x04002C9B RID: 11419
			private PathNode m_owner;
		}
	}
}
