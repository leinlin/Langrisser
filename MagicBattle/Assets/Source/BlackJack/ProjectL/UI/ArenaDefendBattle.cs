using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009F2 RID: 2546
	[HotFix]
	public class ArenaDefendBattle
	{
		// Token: 0x06009729 RID: 38697 RVA: 0x002B2C00 File Offset: 0x002B0E00
		public ArenaDefendBattle()
		{
			this.m_graphicPool = new GraphicPool(false);
			this.m_fxPool = new GraphicPool(true);
			this.m_fxPlayer = new FxPlayer(this.m_fxPool);
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

		// Token: 0x0600972A RID: 38698 RVA: 0x002B2CA8 File Offset: 0x002B0EA8
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
			this.DestroyMap();
			if (this.m_fxPlayer != null)
			{
				this.m_fxPlayer.Clear();
				this.m_fxPlayer = null;
			}
			if (this.m_graphicPool != null)
			{
				this.m_graphicPool.Clear();
				this.m_graphicPool = null;
			}
			if (this.m_fxPool != null)
			{
				this.m_fxPool.Clear();
				this.m_fxPool = null;
			}
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x002B2D68 File Offset: 0x002B0F68
		public void Initialize(GameObject root)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeGameObject_hotfix != null)
			{
				this.m_InitializeGameObject_hotfix.call(new object[]
				{
					this,
					root
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_graphicRoot = Utility.FindChildGameObject(root, "Graphics", true);
			this.m_mapRoot = Utility.FindChildGameObject(root, "Map", true);
			this.m_mapTerrainFxRoot = Utility.FindChildGameObject(this.m_mapRoot, "TerrainFx", true);
			this.m_camera.Initialize(Utility.FindChildGameObject(root, "Camera", true));
			GameObject gameObject = Utility.FindChildGameObject(root, "GraphicPool", true);
			gameObject.SetActive(false);
			this.m_graphicPool.SetDefaultParent(gameObject);
			GameObject gameObject2 = Utility.FindChildGameObject(root, "FxPool", true);
			gameObject2.SetActive(false);
			this.m_fxPool.SetDefaultParent(gameObject2);
			this.m_fxPlayer.SetDefaultParent(this.m_graphicRoot);
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x002B2E7C File Offset: 0x002B107C
		public void CreateMap(ConfigDataArenaBattleInfo battleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapConfigDataArenaBattleInfo_hotfix != null)
			{
				this.m_CreateMapConfigDataArenaBattleInfo_hotfix.call(new object[]
				{
					this,
					battleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaBattleInfo = battleInfo;
			this.CreateMapBackground(battleInfo.m_battlefieldInfo, this.m_mapRoot);
			this.CreateMapTerrainFx(battleInfo.m_battlefieldInfo, this.m_mapTerrainFxRoot);
			this.m_camera.PrepareBattle(battleInfo.m_battlefieldInfo);
			this.m_camera.Look(this.GridPositionToWorldPosition(new GridPosition(battleInfo.DefendCameraX, battleInfo.DefendCameraY)));
		}

		// Token: 0x0600972D RID: 38701 RVA: 0x002B2F4C File Offset: 0x002B114C
		public void DestroyMap()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyMap_hotfix != null)
			{
				this.m_DestroyMap_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapBackground();
			this.ClearMapTerrainFx();
			if (this.m_fxPlayer != null)
			{
				this.m_fxPlayer.Clear();
			}
			this.m_arenaBattleInfo = null;
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x002B2FD8 File Offset: 0x002B11D8
		public void Update(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSingle_hotfix != null)
			{
				this.m_UpdateSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fxPlayer != null)
			{
				this.m_fxPlayer.Tick(dt);
			}
			if (this.m_camera != null)
			{
				this.m_camera.Update(dt);
			}
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x002B3078 File Offset: 0x002B1278
		private void CreateMapBackground(ConfigDataBattlefieldInfo battlefieldInfo, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix != null)
			{
				this.m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix.call(new object[]
				{
					this,
					battlefieldInfo,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapBackground();
			if (battlefieldInfo == null || parent == null)
			{
				return;
			}
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(battlefieldInfo.BattleMap);
			if (asset != null)
			{
				this.m_mapBackground = UnityEngine.Object.Instantiate<GameObject>(asset, parent.transform, false);
				this.m_mapBackground.transform.localPosition = new Vector3(-battlefieldInfo.BackgroundOffsetX * 2f, battlefieldInfo.BackgroundOffsetY * 2f, 0f);
			}
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x002B3174 File Offset: 0x002B1374
		private void ClearMapBackground()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapBackground_hotfix != null)
			{
				this.m_ClearMapBackground_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_mapBackground != null)
			{
				UnityEngine.Object.Destroy(this.m_mapBackground);
				this.m_mapBackground = null;
			}
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x002B31F8 File Offset: 0x002B13F8
		private void CreateMapTerrainFx(ConfigDataBattlefieldInfo battlefieldInfo, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapTerrainFxConfigDataBattlefieldInfoGameObject_hotfix != null)
			{
				this.m_CreateMapTerrainFxConfigDataBattlefieldInfoGameObject_hotfix.call(new object[]
				{
					this,
					battlefieldInfo,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapTerrainFx();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = 0;
			for (int i = 0; i < battlefieldInfo.Height; i++)
			{
				for (int j = 0; j < battlefieldInfo.Width; j++)
				{
					int key = battlefieldInfo.Terrains[num++];
					ConfigDataTerrainInfo configDataTerrainInfo = configDataLoader.GetConfigDataTerrainInfo(key);
					if (configDataTerrainInfo != null && !string.IsNullOrEmpty(configDataTerrainInfo.Fx))
					{
						GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(configDataTerrainInfo.Fx);
						if (asset != null)
						{
							GridPosition gridPosition = new GridPosition(j, i);
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset, parent.transform, false);
							gameObject.transform.localPosition = this.GridPositionToWorldPosition(gridPosition);
							this.m_mapTerrainFxs[gridPosition] = gameObject;
						}
					}
				}
			}
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x002B3354 File Offset: 0x002B1554
		private void ClearMapTerrainFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapTerrainFx_hotfix != null)
			{
				this.m_ClearMapTerrainFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<GridPosition, GameObject> keyValuePair in this.m_mapTerrainFxs)
			{
				UnityEngine.Object.Destroy(keyValuePair.Value);
			}
			this.m_mapTerrainFxs.Clear();
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x002B3414 File Offset: 0x002B1614
		public GenericGraphic CreateGraphic(string assetName, float scale)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGraphicStringSingle_hotfix != null)
			{
				return (GenericGraphic)this.m_CreateGraphicStringSingle_hotfix.call(new object[]
				{
					this,
					assetName,
					scale
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GenericGraphic genericGraphic = this.m_graphicPool.Create(assetName);
			if (genericGraphic != null)
			{
				genericGraphic.SetParent(this.m_graphicRoot);
				genericGraphic.SetPrefabScale(scale);
			}
			return genericGraphic;
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x002B34C8 File Offset: 0x002B16C8
		public void DestroyGraphic(GenericGraphic graphic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphicGenericGraphic_hotfix != null)
			{
				this.m_DestroyGraphicGenericGraphic_hotfix.call(new object[]
				{
					this,
					graphic
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_graphicPool.Destroy(graphic);
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x002B3544 File Offset: 0x002B1744
		public Vector2 GridPositionToWorldPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToWorldPositionGridPosition_hotfix != null)
			{
				return (Vector2)this.m_GridPositionToWorldPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 result;
			result.x = ((float)p.x - (float)(this.m_arenaBattleInfo.m_battlefieldInfo.Width - 1) * 0.5f) * 2f;
			result.y = ((float)(this.m_arenaBattleInfo.m_battlefieldInfo.Height - 1) * 0.5f - (float)p.y) * 2f;
			return result;
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x002B3620 File Offset: 0x002B1820
		public GridPosition WorldPositionToGridPosition(Vector2 sp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldPositionToGridPositionVector2_hotfix != null)
			{
				return (GridPosition)this.m_WorldPositionToGridPositionVector2_hotfix.call(new object[]
				{
					this,
					sp
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float fx = sp.x / 2f + (float)(this.m_arenaBattleInfo.m_battlefieldInfo.Width - 1) * 0.5f;
			float fy = (float)(this.m_arenaBattleInfo.m_battlefieldInfo.Height - 1) * 0.5f - sp.y / 2f;
			return GridPosition.Round(fx, fy);
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x002B36F4 File Offset: 0x002B18F4
		public Vector2 ScreenPositionToWorldPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScreenPositionToWorldPositionVector2_hotfix != null)
			{
				return (Vector2)this.m_ScreenPositionToWorldPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_camera.Camera == null)
			{
				return Vector2.zero;
			}
			return this.m_camera.Camera.ScreenToWorldPoint(p);
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x002B37A8 File Offset: 0x002B19A8
		public GridPosition ScreenPositionToGridPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScreenPositionToGridPositionVector2_hotfix != null)
			{
				return (GridPosition)this.m_ScreenPositionToGridPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.WorldPositionToGridPosition(this.ScreenPositionToWorldPosition(p));
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x002B3834 File Offset: 0x002B1A34
		public ConfigDataArenaBattleInfo ArenaBattleInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ArenaBattleInfo_hotfix != null)
				{
					return (ConfigDataArenaBattleInfo)this.m_get_ArenaBattleInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_arenaBattleInfo;
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600973A RID: 38714 RVA: 0x002B38A8 File Offset: 0x002B1AA8
		public BattleCamera Camera
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Camera_hotfix != null)
				{
					return (BattleCamera)this.m_get_Camera_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_camera;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600973B RID: 38715 RVA: 0x002B391C File Offset: 0x002B1B1C
		public FxPlayer FxPlayer
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_FxPlayer_hotfix != null)
				{
					return (FxPlayer)this.m_get_FxPlayer_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_fxPlayer;
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x0600973C RID: 38716 RVA: 0x002B3990 File Offset: 0x002B1B90
		// (set) Token: 0x0600973D RID: 38717 RVA: 0x002B39B0 File Offset: 0x002B1BB0
		[DoNotToLua]
		public ArenaDefendBattle.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendBattle.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x002B39BC File Offset: 0x002B1BBC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_InitializeGameObject_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_CreateMapConfigDataArenaBattleInfo_hotfix = (luaObj.RawGet("CreateMap") as LuaFunction);
					this.m_DestroyMap_hotfix = (luaObj.RawGet("DestroyMap") as LuaFunction);
					this.m_UpdateSingle_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix = (luaObj.RawGet("CreateMapBackground") as LuaFunction);
					this.m_ClearMapBackground_hotfix = (luaObj.RawGet("ClearMapBackground") as LuaFunction);
					this.m_CreateMapTerrainFxConfigDataBattlefieldInfoGameObject_hotfix = (luaObj.RawGet("CreateMapTerrainFx") as LuaFunction);
					this.m_ClearMapTerrainFx_hotfix = (luaObj.RawGet("ClearMapTerrainFx") as LuaFunction);
					this.m_CreateGraphicStringSingle_hotfix = (luaObj.RawGet("CreateGraphic") as LuaFunction);
					this.m_DestroyGraphicGenericGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_GridPositionToWorldPositionGridPosition_hotfix = (luaObj.RawGet("GridPositionToWorldPosition") as LuaFunction);
					this.m_WorldPositionToGridPositionVector2_hotfix = (luaObj.RawGet("WorldPositionToGridPosition") as LuaFunction);
					this.m_ScreenPositionToWorldPositionVector2_hotfix = (luaObj.RawGet("ScreenPositionToWorldPosition") as LuaFunction);
					this.m_ScreenPositionToGridPositionVector2_hotfix = (luaObj.RawGet("ScreenPositionToGridPosition") as LuaFunction);
					this.m_get_ArenaBattleInfo_hotfix = (luaObj.RawGet("get_ArenaBattleInfo") as LuaFunction);
					this.m_get_Camera_hotfix = (luaObj.RawGet("get_Camera") as LuaFunction);
					this.m_get_FxPlayer_hotfix = (luaObj.RawGet("get_FxPlayer") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x002B3C4C File Offset: 0x002B1E4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendBattle));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006800 RID: 26624
		private GameObject m_graphicRoot;

		// Token: 0x04006801 RID: 26625
		private GameObject m_mapRoot;

		// Token: 0x04006802 RID: 26626
		private GameObject m_mapBackground;

		// Token: 0x04006803 RID: 26627
		private GameObject m_mapTerrainFxRoot;

		// Token: 0x04006804 RID: 26628
		private Dictionary<GridPosition, GameObject> m_mapTerrainFxs = new Dictionary<GridPosition, GameObject>();

		// Token: 0x04006805 RID: 26629
		private ConfigDataArenaBattleInfo m_arenaBattleInfo;

		// Token: 0x04006806 RID: 26630
		private BattleCamera m_camera = new BattleCamera();

		// Token: 0x04006807 RID: 26631
		private GraphicPool m_graphicPool;

		// Token: 0x04006808 RID: 26632
		private GraphicPool m_fxPool;

		// Token: 0x04006809 RID: 26633
		private FxPlayer m_fxPlayer;

		// Token: 0x0400680A RID: 26634
		[DoNotToLua]
		private ArenaDefendBattle.LuaExportHelper luaExportHelper;

		// Token: 0x0400680B RID: 26635
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400680C RID: 26636
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400680D RID: 26637
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400680E RID: 26638
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x0400680F RID: 26639
		private LuaFunction m_InitializeGameObject_hotfix;

		// Token: 0x04006810 RID: 26640
		private LuaFunction m_CreateMapConfigDataArenaBattleInfo_hotfix;

		// Token: 0x04006811 RID: 26641
		private LuaFunction m_DestroyMap_hotfix;

		// Token: 0x04006812 RID: 26642
		private LuaFunction m_UpdateSingle_hotfix;

		// Token: 0x04006813 RID: 26643
		private LuaFunction m_CreateMapBackgroundConfigDataBattlefieldInfoGameObject_hotfix;

		// Token: 0x04006814 RID: 26644
		private LuaFunction m_ClearMapBackground_hotfix;

		// Token: 0x04006815 RID: 26645
		private LuaFunction m_CreateMapTerrainFxConfigDataBattlefieldInfoGameObject_hotfix;

		// Token: 0x04006816 RID: 26646
		private LuaFunction m_ClearMapTerrainFx_hotfix;

		// Token: 0x04006817 RID: 26647
		private LuaFunction m_CreateGraphicStringSingle_hotfix;

		// Token: 0x04006818 RID: 26648
		private LuaFunction m_DestroyGraphicGenericGraphic_hotfix;

		// Token: 0x04006819 RID: 26649
		private LuaFunction m_GridPositionToWorldPositionGridPosition_hotfix;

		// Token: 0x0400681A RID: 26650
		private LuaFunction m_WorldPositionToGridPositionVector2_hotfix;

		// Token: 0x0400681B RID: 26651
		private LuaFunction m_ScreenPositionToWorldPositionVector2_hotfix;

		// Token: 0x0400681C RID: 26652
		private LuaFunction m_ScreenPositionToGridPositionVector2_hotfix;

		// Token: 0x0400681D RID: 26653
		private LuaFunction m_get_ArenaBattleInfo_hotfix;

		// Token: 0x0400681E RID: 26654
		private LuaFunction m_get_Camera_hotfix;

		// Token: 0x0400681F RID: 26655
		private LuaFunction m_get_FxPlayer_hotfix;

		// Token: 0x020009F3 RID: 2547
		public class LuaExportHelper
		{
			// Token: 0x06009740 RID: 38720 RVA: 0x002B3CB4 File Offset: 0x002B1EB4
			public LuaExportHelper(ArenaDefendBattle owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001F2E RID: 7982
			// (get) Token: 0x06009741 RID: 38721 RVA: 0x002B3CC4 File Offset: 0x002B1EC4
			// (set) Token: 0x06009742 RID: 38722 RVA: 0x002B3CD4 File Offset: 0x002B1ED4
			public GameObject m_graphicRoot
			{
				get
				{
					return this.m_owner.m_graphicRoot;
				}
				set
				{
					this.m_owner.m_graphicRoot = value;
				}
			}

			// Token: 0x17001F2F RID: 7983
			// (get) Token: 0x06009743 RID: 38723 RVA: 0x002B3CE4 File Offset: 0x002B1EE4
			// (set) Token: 0x06009744 RID: 38724 RVA: 0x002B3CF4 File Offset: 0x002B1EF4
			public GameObject m_mapRoot
			{
				get
				{
					return this.m_owner.m_mapRoot;
				}
				set
				{
					this.m_owner.m_mapRoot = value;
				}
			}

			// Token: 0x17001F30 RID: 7984
			// (get) Token: 0x06009745 RID: 38725 RVA: 0x002B3D04 File Offset: 0x002B1F04
			// (set) Token: 0x06009746 RID: 38726 RVA: 0x002B3D14 File Offset: 0x002B1F14
			public GameObject m_mapBackground
			{
				get
				{
					return this.m_owner.m_mapBackground;
				}
				set
				{
					this.m_owner.m_mapBackground = value;
				}
			}

			// Token: 0x17001F31 RID: 7985
			// (get) Token: 0x06009747 RID: 38727 RVA: 0x002B3D24 File Offset: 0x002B1F24
			// (set) Token: 0x06009748 RID: 38728 RVA: 0x002B3D34 File Offset: 0x002B1F34
			public GameObject m_mapTerrainFxRoot
			{
				get
				{
					return this.m_owner.m_mapTerrainFxRoot;
				}
				set
				{
					this.m_owner.m_mapTerrainFxRoot = value;
				}
			}

			// Token: 0x17001F32 RID: 7986
			// (get) Token: 0x06009749 RID: 38729 RVA: 0x002B3D44 File Offset: 0x002B1F44
			// (set) Token: 0x0600974A RID: 38730 RVA: 0x002B3D54 File Offset: 0x002B1F54
			public Dictionary<GridPosition, GameObject> m_mapTerrainFxs
			{
				get
				{
					return this.m_owner.m_mapTerrainFxs;
				}
				set
				{
					this.m_owner.m_mapTerrainFxs = value;
				}
			}

			// Token: 0x17001F33 RID: 7987
			// (get) Token: 0x0600974B RID: 38731 RVA: 0x002B3D64 File Offset: 0x002B1F64
			// (set) Token: 0x0600974C RID: 38732 RVA: 0x002B3D74 File Offset: 0x002B1F74
			public ConfigDataArenaBattleInfo m_arenaBattleInfo
			{
				get
				{
					return this.m_owner.m_arenaBattleInfo;
				}
				set
				{
					this.m_owner.m_arenaBattleInfo = value;
				}
			}

			// Token: 0x17001F34 RID: 7988
			// (get) Token: 0x0600974D RID: 38733 RVA: 0x002B3D84 File Offset: 0x002B1F84
			// (set) Token: 0x0600974E RID: 38734 RVA: 0x002B3D94 File Offset: 0x002B1F94
			public BattleCamera m_camera
			{
				get
				{
					return this.m_owner.m_camera;
				}
				set
				{
					this.m_owner.m_camera = value;
				}
			}

			// Token: 0x17001F35 RID: 7989
			// (get) Token: 0x0600974F RID: 38735 RVA: 0x002B3DA4 File Offset: 0x002B1FA4
			// (set) Token: 0x06009750 RID: 38736 RVA: 0x002B3DB4 File Offset: 0x002B1FB4
			public GraphicPool m_graphicPool
			{
				get
				{
					return this.m_owner.m_graphicPool;
				}
				set
				{
					this.m_owner.m_graphicPool = value;
				}
			}

			// Token: 0x17001F36 RID: 7990
			// (get) Token: 0x06009751 RID: 38737 RVA: 0x002B3DC4 File Offset: 0x002B1FC4
			// (set) Token: 0x06009752 RID: 38738 RVA: 0x002B3DD4 File Offset: 0x002B1FD4
			public GraphicPool m_fxPool
			{
				get
				{
					return this.m_owner.m_fxPool;
				}
				set
				{
					this.m_owner.m_fxPool = value;
				}
			}

			// Token: 0x17001F37 RID: 7991
			// (get) Token: 0x06009753 RID: 38739 RVA: 0x002B3DE4 File Offset: 0x002B1FE4
			// (set) Token: 0x06009754 RID: 38740 RVA: 0x002B3DF4 File Offset: 0x002B1FF4
			public FxPlayer m_fxPlayer
			{
				get
				{
					return this.m_owner.m_fxPlayer;
				}
				set
				{
					this.m_owner.m_fxPlayer = value;
				}
			}

			// Token: 0x06009755 RID: 38741 RVA: 0x002B3E04 File Offset: 0x002B2004
			public void CreateMapBackground(ConfigDataBattlefieldInfo battlefieldInfo, GameObject parent)
			{
				this.m_owner.CreateMapBackground(battlefieldInfo, parent);
			}

			// Token: 0x06009756 RID: 38742 RVA: 0x002B3E14 File Offset: 0x002B2014
			public void ClearMapBackground()
			{
				this.m_owner.ClearMapBackground();
			}

			// Token: 0x06009757 RID: 38743 RVA: 0x002B3E24 File Offset: 0x002B2024
			public void CreateMapTerrainFx(ConfigDataBattlefieldInfo battlefieldInfo, GameObject parent)
			{
				this.m_owner.CreateMapTerrainFx(battlefieldInfo, parent);
			}

			// Token: 0x06009758 RID: 38744 RVA: 0x002B3E34 File Offset: 0x002B2034
			public void ClearMapTerrainFx()
			{
				this.m_owner.ClearMapTerrainFx();
			}

			// Token: 0x04006820 RID: 26656
			private ArenaDefendBattle m_owner;
		}
	}
}
