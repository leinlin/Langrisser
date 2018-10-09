using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003A5 RID: 933
	[HotFix]
	public class BattleMap
	{
		// Token: 0x060036ED RID: 14061 RVA: 0x000F413C File Offset: 0x000F233C
		public BattleMap()
		{
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

		// Token: 0x060036EE RID: 14062 RVA: 0x000F41A4 File Offset: 0x000F23A4
		public void Initialize(int w, int h)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeInt32Int32_hotfix != null)
			{
				this.m_InitializeInt32Int32_hotfix.call(new object[]
				{
					this,
					w,
					h
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_width = w;
			this.m_height = h;
			this.m_cells = new BattleMapCell[h, w];
			for (int i = 0; i < h; i++)
			{
				for (int j = 0; j < w; j++)
				{
					BattleMapCell battleMapCell = new BattleMapCell();
					this.m_cells[i, j] = battleMapCell;
				}
			}
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x000F4278 File Offset: 0x000F2478
		public bool InitializeTerrain(ConfigDataBattlefieldInfo battlefieldInfo, IConfigDataLoader configDataLoader)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeTerrainConfigDataBattlefieldInfoIConfigDataLoader_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InitializeTerrainConfigDataBattlefieldInfoIConfigDataLoader_hotfix.call(new object[]
				{
					this,
					battlefieldInfo,
					configDataLoader
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battlefieldInfo.Terrains.Count != battlefieldInfo.Width * battlefieldInfo.Height)
			{
				return false;
			}
			if (battlefieldInfo.Width != this.m_width || battlefieldInfo.Height != this.m_height)
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < this.m_height; i++)
			{
				for (int j = 0; j < this.m_width; j++)
				{
					int key = battlefieldInfo.Terrains[num++];
					BattleMapCell battleMapCell = this.m_cells[i, j];
					battleMapCell.m_terrain = configDataLoader.GetConfigDataTerrainInfo(key);
					battleMapCell.m_actor = null;
					battleMapCell.m_region = 0;
				}
			}
			return true;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x000F43B8 File Offset: 0x000F25B8
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
			this.m_width = (this.m_height = 0);
			this.m_cells = null;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x000F4430 File Offset: 0x000F2630
		public void ClearActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearActors_hotfix != null)
			{
				this.m_ClearActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_height; i++)
			{
				for (int j = 0; j < this.m_width; j++)
				{
					this.m_cells[i, j].m_actor = null;
				}
			}
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x000F44D4 File Offset: 0x000F26D4
		public void ClearRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRegion_hotfix != null)
			{
				this.m_ClearRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_height; i++)
			{
				for (int j = 0; j < this.m_width; j++)
				{
					this.m_cells[i, j].m_region = 0;
				}
			}
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x000F4578 File Offset: 0x000F2778
		public bool IsValidPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsValidPositionGridPosition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsValidPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return p.x >= 0 && p.x < this.m_width && p.y >= 0 && p.y < this.m_height;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x000F4638 File Offset: 0x000F2838
		public void SetActor(GridPosition p, BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActorGridPositionBattleActor_hotfix != null)
			{
				this.m_SetActorGridPositionBattleActor_hotfix.call(new object[]
				{
					this,
					p,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return;
			}
			if (actor != null && cell.m_actor != null)
			{
				DebugUtility.LogError(string.Format("BattleMap.SetActor() error, {0} already has actor {1}", p, cell.m_actor.Id));
			}
			cell.m_actor = actor;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000F4704 File Offset: 0x000F2904
		public BattleActor GetActor(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActorGridPosition_hotfix != null)
			{
				return (BattleActor)this.m_GetActorGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return null;
			}
			return cell.m_actor;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x000F4798 File Offset: 0x000F2998
		public void SetTerrain(GridPosition p, ConfigDataTerrainInfo terrainInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTerrainGridPositionConfigDataTerrainInfo_hotfix != null)
			{
				this.m_SetTerrainGridPositionConfigDataTerrainInfo_hotfix.call(new object[]
				{
					this,
					p,
					terrainInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (terrainInfo == null)
			{
				return;
			}
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return;
			}
			cell.m_terrain = terrainInfo;
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x000F4838 File Offset: 0x000F2A38
		public ConfigDataTerrainInfo GetTerrain(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTerrainGridPosition_hotfix != null)
			{
				return (ConfigDataTerrainInfo)this.m_GetTerrainGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return null;
			}
			return cell.m_terrain;
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x000F48CC File Offset: 0x000F2ACC
		public void SetRegion(GridPosition p, int region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRegionGridPositionInt32_hotfix != null)
			{
				this.m_SetRegionGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return;
			}
			cell.m_region = region;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000F4964 File Offset: 0x000F2B64
		public int GetRegion(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRegionGridPosition_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRegionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return 0;
			}
			return cell.m_region;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x000F49F8 File Offset: 0x000F2BF8
		public void SetRegionBit(GridPosition p, int bit)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRegionBitGridPositionInt32_hotfix != null)
			{
				this.m_SetRegionBitGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					bit
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return;
			}
			int num = 1 << bit;
			cell.m_region |= num;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x000F4A9C File Offset: 0x000F2C9C
		public void ClearRegionBit(GridPosition p, int bit)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRegionBitGridPositionInt32_hotfix != null)
			{
				this.m_ClearRegionBitGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					bit
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return;
			}
			int num = 1 << bit;
			cell.m_region &= ~num;
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x000F4B44 File Offset: 0x000F2D44
		public bool HasRegionBit(GridPosition p, int bit)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasRegionBitGridPositionInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasRegionBitGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					bit
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return false;
			}
			int num = 1 << bit;
			return (cell.m_region & num) != 0;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x000F4BF8 File Offset: 0x000F2DF8
		public int GetMovePointCost(GridPosition p, MoveType moveType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMovePointCostGridPositionMoveType_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMovePointCostGridPositionMoveType_hotfix.call(new object[]
				{
					this,
					p,
					moveType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleMapCell cell = this.GetCell(p);
			if (cell == null)
			{
				return 0;
			}
			return BattleMap.GetMovePointCost(cell.m_terrain, moveType);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x000F4CA0 File Offset: 0x000F2EA0
		public static int GetMovePointCost(ConfigDataTerrainInfo terrain, MoveType moveType)
		{
			if (terrain == null)
			{
				return 0;
			}
			switch (moveType)
			{
			case MoveType.MoveType_Ride:
				return terrain.MovePoint_Ride;
			case MoveType.MoveType_Walk:
				return terrain.MovePoint_Walk;
			case MoveType.MoveType_Water:
				return terrain.MovePoint_Water;
			case MoveType.MoveType_Fly:
				return terrain.MovePoint_Fly;
			default:
				return 0;
			}
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x000F4CF0 File Offset: 0x000F2EF0
		private BattleMapCell GetCell(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCellGridPosition_hotfix != null)
			{
				return (BattleMapCell)this.m_GetCellGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (p.x < 0 || p.x >= this.m_width || p.y < 0 || p.y >= this.m_height)
			{
				return null;
			}
			return this.m_cells[p.y, p.x];
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x000F4DC8 File Offset: 0x000F2FC8
		public int Width
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Width_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Width_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_width;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x000F4E3C File Offset: 0x000F303C
		public int Height
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Height_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Height_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_height;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x000F4EB0 File Offset: 0x000F30B0
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x000F4ED0 File Offset: 0x000F30D0
		[DoNotToLua]
		public BattleMap.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleMap.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x000F4EDC File Offset: 0x000F30DC
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
					this.m_InitializeInt32Int32_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_InitializeTerrainConfigDataBattlefieldInfoIConfigDataLoader_hotfix = (luaObj.RawGet("InitializeTerrain") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_ClearActors_hotfix = (luaObj.RawGet("ClearActors") as LuaFunction);
					this.m_ClearRegion_hotfix = (luaObj.RawGet("ClearRegion") as LuaFunction);
					this.m_IsValidPositionGridPosition_hotfix = (luaObj.RawGet("IsValidPosition") as LuaFunction);
					this.m_SetActorGridPositionBattleActor_hotfix = (luaObj.RawGet("SetActor") as LuaFunction);
					this.m_GetActorGridPosition_hotfix = (luaObj.RawGet("GetActor") as LuaFunction);
					this.m_SetTerrainGridPositionConfigDataTerrainInfo_hotfix = (luaObj.RawGet("SetTerrain") as LuaFunction);
					this.m_GetTerrainGridPosition_hotfix = (luaObj.RawGet("GetTerrain") as LuaFunction);
					this.m_SetRegionGridPositionInt32_hotfix = (luaObj.RawGet("SetRegion") as LuaFunction);
					this.m_GetRegionGridPosition_hotfix = (luaObj.RawGet("GetRegion") as LuaFunction);
					this.m_SetRegionBitGridPositionInt32_hotfix = (luaObj.RawGet("SetRegionBit") as LuaFunction);
					this.m_ClearRegionBitGridPositionInt32_hotfix = (luaObj.RawGet("ClearRegionBit") as LuaFunction);
					this.m_HasRegionBitGridPositionInt32_hotfix = (luaObj.RawGet("HasRegionBit") as LuaFunction);
					this.m_GetMovePointCostGridPositionMoveType_hotfix = (luaObj.RawGet("GetMovePointCost") as LuaFunction);
					this.m_GetCellGridPosition_hotfix = (luaObj.RawGet("GetCell") as LuaFunction);
					this.m_get_Width_hotfix = (luaObj.RawGet("get_Width") as LuaFunction);
					this.m_get_Height_hotfix = (luaObj.RawGet("get_Height") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x000F5184 File Offset: 0x000F3384
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleMap));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A2F RID: 10799
		public const int MoveRegion = 1;

		// Token: 0x04002A30 RID: 10800
		public const int AttackRegion = 2;

		// Token: 0x04002A31 RID: 10801
		public const int SkillRegion = 3;

		// Token: 0x04002A32 RID: 10802
		public const int TeleportRegion = 4;

		// Token: 0x04002A33 RID: 10803
		private int m_width;

		// Token: 0x04002A34 RID: 10804
		private int m_height;

		// Token: 0x04002A35 RID: 10805
		[DoNotToLua]
		private BattleMapCell[,] m_cells;

		// Token: 0x04002A36 RID: 10806
		[DoNotToLua]
		private BattleMap.LuaExportHelper luaExportHelper;

		// Token: 0x04002A37 RID: 10807
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A38 RID: 10808
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A39 RID: 10809
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002A3A RID: 10810
		private LuaFunction m_InitializeInt32Int32_hotfix;

		// Token: 0x04002A3B RID: 10811
		private LuaFunction m_InitializeTerrainConfigDataBattlefieldInfoIConfigDataLoader_hotfix;

		// Token: 0x04002A3C RID: 10812
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04002A3D RID: 10813
		private LuaFunction m_ClearActors_hotfix;

		// Token: 0x04002A3E RID: 10814
		private LuaFunction m_ClearRegion_hotfix;

		// Token: 0x04002A3F RID: 10815
		private LuaFunction m_IsValidPositionGridPosition_hotfix;

		// Token: 0x04002A40 RID: 10816
		private LuaFunction m_SetActorGridPositionBattleActor_hotfix;

		// Token: 0x04002A41 RID: 10817
		private LuaFunction m_GetActorGridPosition_hotfix;

		// Token: 0x04002A42 RID: 10818
		private LuaFunction m_SetTerrainGridPositionConfigDataTerrainInfo_hotfix;

		// Token: 0x04002A43 RID: 10819
		private LuaFunction m_GetTerrainGridPosition_hotfix;

		// Token: 0x04002A44 RID: 10820
		private LuaFunction m_SetRegionGridPositionInt32_hotfix;

		// Token: 0x04002A45 RID: 10821
		private LuaFunction m_GetRegionGridPosition_hotfix;

		// Token: 0x04002A46 RID: 10822
		private LuaFunction m_SetRegionBitGridPositionInt32_hotfix;

		// Token: 0x04002A47 RID: 10823
		private LuaFunction m_ClearRegionBitGridPositionInt32_hotfix;

		// Token: 0x04002A48 RID: 10824
		private LuaFunction m_HasRegionBitGridPositionInt32_hotfix;

		// Token: 0x04002A49 RID: 10825
		private LuaFunction m_GetMovePointCostGridPositionMoveType_hotfix;

		// Token: 0x04002A4A RID: 10826
		private LuaFunction m_GetCellGridPosition_hotfix;

		// Token: 0x04002A4B RID: 10827
		private LuaFunction m_get_Width_hotfix;

		// Token: 0x04002A4C RID: 10828
		private LuaFunction m_get_Height_hotfix;

		// Token: 0x020003A6 RID: 934
		public class LuaExportHelper
		{
			// Token: 0x06003706 RID: 14086 RVA: 0x000F51EC File Offset: 0x000F33EC
			public LuaExportHelper(BattleMap owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000F28 RID: 3880
			// (get) Token: 0x06003707 RID: 14087 RVA: 0x000F51FC File Offset: 0x000F33FC
			// (set) Token: 0x06003708 RID: 14088 RVA: 0x000F520C File Offset: 0x000F340C
			public int m_width
			{
				get
				{
					return this.m_owner.m_width;
				}
				set
				{
					this.m_owner.m_width = value;
				}
			}

			// Token: 0x17000F29 RID: 3881
			// (get) Token: 0x06003709 RID: 14089 RVA: 0x000F521C File Offset: 0x000F341C
			// (set) Token: 0x0600370A RID: 14090 RVA: 0x000F522C File Offset: 0x000F342C
			public int m_height
			{
				get
				{
					return this.m_owner.m_height;
				}
				set
				{
					this.m_owner.m_height = value;
				}
			}

			// Token: 0x0600370B RID: 14091 RVA: 0x000F523C File Offset: 0x000F343C
			public BattleMapCell GetCell(GridPosition p)
			{
				return this.m_owner.GetCell(p);
			}

			// Token: 0x04002A4D RID: 10829
			private BattleMap m_owner;
		}
	}
}
