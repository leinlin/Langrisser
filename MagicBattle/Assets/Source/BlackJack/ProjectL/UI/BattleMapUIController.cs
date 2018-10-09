using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A7A RID: 2682
	[HotFix]
	public class BattleMapUIController : UIControllerBase
	{
		// Token: 0x0600A8F5 RID: 43253 RVA: 0x002F21A4 File Offset: 0x002F03A4
		private BattleMapUIController()
		{
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x002F21AC File Offset: 0x002F03AC
		public void Initialize(ClientBattle clientBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientBattle_hotfix != null)
			{
				this.m_InitializeClientBattle_hotfix.call(new object[]
				{
					this,
					clientBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = clientBattle;
			this.m_fadeGameObject.SetActive(false);
			this.m_fadeMaterial = this.m_fadeGameObject.GetComponent<Renderer>().material;
			this.m_fadeColor = this.m_fadeMaterial.color;
			this.m_zoomFadeGameObject.SetActive(false);
			this.m_zoomFadeFullGameObject.SetActive(false);
			this.m_moveGridPool = new GameObjectPool<RegionGridEffect>();
			this.m_moveGridPool.Setup(this.m_moveGridPrefab, this.m_gridGameObject);
			this.m_attackGridPool = new GameObjectPool<RegionGridEffect>();
			this.m_attackGridPool.Setup(this.m_attackGridPrefab, this.m_gridGameObject);
			this.m_skillGridPool = new GameObjectPool<RegionGridEffect>();
			this.m_skillGridPool.Setup(this.m_skillGridPrefab, this.m_gridGameObject);
			this.m_teleportGridPool = new GameObjectPool<RegionGridEffect>();
			this.m_teleportGridPool.Setup(this.m_teleportGridPrefab, this.m_gridGameObject);
			this.m_fadeGridPool = new GameObjectPool<RegionGridEffect>();
			this.m_fadeGridPool.Setup(this.m_fadeGridPrefab, this.m_zoomFadeGameObject);
			this.m_dangerEdgeGrid0Pool = new GameObjectPool();
			this.m_dangerEdgeGrid0Pool.Setup(this.m_dangerEdgeGrid0Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid1Pool = new GameObjectPool();
			this.m_dangerEdgeGrid1Pool.Setup(this.m_dangerEdgeGrid1Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid1_1Pool = new GameObjectPool();
			this.m_dangerEdgeGrid1_1Pool.Setup(this.m_dangerEdgeGrid1_1Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid1_2Pool = new GameObjectPool();
			this.m_dangerEdgeGrid1_2Pool.Setup(this.m_dangerEdgeGrid1_2Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid1_3Pool = new GameObjectPool();
			this.m_dangerEdgeGrid1_3Pool.Setup(this.m_dangerEdgeGrid1_3Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid2Pool = new GameObjectPool();
			this.m_dangerEdgeGrid2Pool.Setup(this.m_dangerEdgeGrid2Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid2_1Pool = new GameObjectPool();
			this.m_dangerEdgeGrid2_1Pool.Setup(this.m_dangerEdgeGrid2_1Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid3Pool = new GameObjectPool();
			this.m_dangerEdgeGrid3Pool.Setup(this.m_dangerEdgeGrid3Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid4Pool = new GameObjectPool();
			this.m_dangerEdgeGrid4Pool.Setup(this.m_dangerEdgeGrid4Prefab, this.m_gridGameObject);
			this.m_dangerEdgeGrid5Pool = new GameObjectPool();
			this.m_dangerEdgeGrid5Pool.Setup(this.m_dangerEdgeGrid5Prefab, this.m_gridGameObject);
			this.m_dangerCornerGrid1Pool = new GameObjectPool();
			this.m_dangerCornerGrid1Pool.Setup(this.m_dangerCornerGrid1Prefab, this.m_gridGameObject);
			this.m_dangerCornerGrid2Pool = new GameObjectPool();
			this.m_dangerCornerGrid2Pool.Setup(this.m_dangerCornerGrid2Prefab, this.m_gridGameObject);
			this.m_dangerCornerGrid3Pool = new GameObjectPool();
			this.m_dangerCornerGrid3Pool.Setup(this.m_dangerCornerGrid3Prefab, this.m_gridGameObject);
			this.m_dangerCornerGrid4Pool = new GameObjectPool();
			this.m_dangerCornerGrid4Pool.Setup(this.m_dangerCornerGrid4Prefab, this.m_gridGameObject);
			this.m_dangerCornerGrid5Pool = new GameObjectPool();
			this.m_dangerCornerGrid5Pool.Setup(this.m_dangerCornerGrid5Prefab, this.m_gridGameObject);
			this.m_reachGridPool = new GameObjectPool();
			this.m_reachGridPool.Setup(this.m_reachGridPrefab, this.m_gridGameObject);
			GameObject gameObject = new GameObject("StagePosition0");
			gameObject.transform.SetParent(this.m_prefabsGameObject.transform, false);
			BattleMapUIController.AddChildPrefab(gameObject, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_G.prefab");
			BattleMapUIController.AddChildPrefab(gameObject, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_G.prefab");
			GameObject gameObject2 = new GameObject("StagePosition1");
			gameObject2.transform.SetParent(this.m_prefabsGameObject.transform, false);
			BattleMapUIController.AddChildPrefab(gameObject2, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_R.prefab");
			BattleMapUIController.AddChildPrefab(gameObject2, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_R.prefab");
			GameObject gameObject3 = new GameObject("StagePosition2");
			gameObject3.transform.SetParent(this.m_prefabsGameObject.transform, false);
			BattleMapUIController.AddChildPrefab(gameObject3, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_B.prefab");
			BattleMapUIController.AddChildPrefab(gameObject3, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_B.prefab");
			this.m_stagePosition0Pool = new GameObjectPool();
			this.m_stagePosition0Pool.Setup(gameObject, this.m_gridGameObject);
			this.m_stagePosition1Pool = new GameObjectPool();
			this.m_stagePosition1Pool.Setup(gameObject2, this.m_gridGameObject);
			this.m_stagePosition2Pool = new GameObjectPool();
			this.m_stagePosition2Pool.Setup(gameObject3, this.m_gridGameObject);
			this.m_arrowHeadPool = new GameObjectPool();
			this.m_arrowHeadPool.Setup(this.m_arrowHeadPrefab, this.m_gridGameObject);
			this.m_arrowEndPool = new GameObjectPool();
			this.m_arrowEndPool.Setup(this.m_arrowEndPrefab, this.m_gridGameObject);
			this.m_arrowCornerPool = new GameObjectPool();
			this.m_arrowCornerPool.Setup(this.m_arrowCornerPrefab, this.m_gridGameObject);
			this.m_arrowLinePool = new GameObjectPool();
			this.m_arrowLinePool.Setup(this.m_arrowLinePrefab, this.m_gridGameObject);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x002F26CC File Offset: 0x002F08CC
		private static void AddChildPrefab(GameObject go, string assetName)
		{
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(assetName);
			if (asset != null)
			{
				UnityEngine.Object.Instantiate<GameObject>(asset).transform.SetParent(go.transform, false);
			}
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x002F2708 File Offset: 0x002F0908
		public void PrepareBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareBattle_hotfix != null)
			{
				this.m_PrepareBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRegion();
			this.HideMovePath();
			this.HideDangerRegion();
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x002F277C File Offset: 0x002F097C
		public void StartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattle_hotfix != null)
			{
				this.m_StartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRegion();
			this.HideMovePath();
			this.HideDangerRegion();
			this.HideStagePositions();
			this.HideFade();
			this.HideZoomFade();
		}

		// Token: 0x0600A8FA RID: 43258 RVA: 0x002F2800 File Offset: 0x002F0A00
		public void StopBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopBattle_hotfix != null)
			{
				this.m_StopBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRegion();
			this.HideMovePath();
			this.HideDangerRegion();
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x002F2874 File Offset: 0x002F0A74
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle == null)
			{
				return;
			}
			float deltaTime = Time.deltaTime;
			this.UpdateFade(deltaTime);
			this.UpdateZoomFade(deltaTime);
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x002F28F4 File Offset: 0x002F0AF4
		private void UpdateZoomFade(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateZoomFadeSingle_hotfix != null)
			{
				this.m_UpdateZoomFadeSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_zoomFadeDuration > 0f && this.m_zoomFadeCurTime < this.m_zoomFadeDuration)
			{
				this.m_zoomFadeCurTime += dt;
				float num = Mathf.Clamp01(this.m_zoomFadeCurTime / this.m_zoomFadeDuration);
				if (this.m_isZoomFadeIn)
				{
					if (num >= 1f)
					{
						this.FullZoomFade();
					}
				}
				else if (num >= 1f)
				{
					this.HideZoomFade();
				}
			}
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x002F29D8 File Offset: 0x002F0BD8
		public void ShowRegion(GridPosition startPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRegionGridPosition_hotfix != null)
			{
				this.m_ShowRegionGridPosition_hotfix.call(new object[]
				{
					this,
					startPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRegion();
			BattleMap map = this.m_clientBattle.Battle.Map;
			for (int i = 0; i < map.Height; i++)
			{
				for (int j = 0; j < map.Width; j++)
				{
					GridPosition gridPosition = new GridPosition(j, i);
					int region = map.GetRegion(gridPosition);
					RegionGridEffect regionGridEffect = null;
					if (region == 1)
					{
						regionGridEffect = this.m_moveGridPool.Allocate();
					}
					else if (region == 2)
					{
						regionGridEffect = this.m_attackGridPool.Allocate();
					}
					else if (region == 3)
					{
						regionGridEffect = this.m_skillGridPool.Allocate();
					}
					else if (region == 4)
					{
						regionGridEffect = this.m_teleportGridPool.Allocate();
					}
					if (regionGridEffect != null)
					{
						regionGridEffect.transform.localPosition = this.GridPositionToWorldPosition(gridPosition, 0f);
						regionGridEffect.SetDelay((float)GridPosition.Distance(gridPosition, startPos) * 0.05f);
						regionGridEffect.SetDuration(0.3f);
						regionGridEffect.SetFade(true);
					}
				}
			}
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x002F2B54 File Offset: 0x002F0D54
		public void HideRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideRegion_hotfix != null)
			{
				this.m_HideRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_moveGridPool.Deactive();
			this.m_attackGridPool.Deactive();
			this.m_skillGridPool.Deactive();
			this.m_teleportGridPool.Deactive();
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x002F2BE0 File Offset: 0x002F0DE0
		public void ShowDangerRegion(HashSet<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDangerRegionHashSet`1_hotfix != null)
			{
				this.m_ShowDangerRegionHashSet`1_hotfix.call(new object[]
				{
					this,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideDangerRegion();
			foreach (GridPosition p in region)
			{
				bool flag = !BattleMapUIController.IsInRegion(p.x, p.y - 1, region);
				bool flag2 = !BattleMapUIController.IsInRegion(p.x, p.y + 1, region);
				bool flag3 = !BattleMapUIController.IsInRegion(p.x - 1, p.y, region);
				bool flag4 = !BattleMapUIController.IsInRegion(p.x + 1, p.y, region);
				GameObjectPool gameObjectPool = null;
				float z = 0f;
				if (!flag && !flag2 && !flag3 && !flag4)
				{
					bool flag5 = !BattleMapUIController.IsInRegion(p.x - 1, p.y - 1, region);
					bool flag6 = !BattleMapUIController.IsInRegion(p.x + 1, p.y - 1, region);
					bool flag7 = !BattleMapUIController.IsInRegion(p.x - 1, p.y + 1, region);
					bool flag8 = !BattleMapUIController.IsInRegion(p.x + 1, p.y + 1, region);
					if (!flag5 && !flag6 && !flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerEdgeGrid0Pool;
						z = 0f;
					}
					else if (flag5 && !flag6 && !flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid1Pool;
						z = 0f;
					}
					else if (!flag5 && !flag6 && flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid1Pool;
						z = 90f;
					}
					else if (!flag5 && !flag6 && !flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid1Pool;
						z = 180f;
					}
					else if (!flag5 && flag6 && !flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid1Pool;
						z = 270f;
					}
					else if (flag5 && flag6 && !flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid2Pool;
						z = 0f;
					}
					else if (flag5 && !flag6 && flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid2Pool;
						z = 90f;
					}
					else if (!flag5 && !flag6 && flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid2Pool;
						z = 180f;
					}
					else if (!flag5 && flag6 && !flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid2Pool;
						z = 270f;
					}
					else if (flag5 && !flag6 && !flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid3Pool;
						z = 0f;
					}
					else if (!flag5 && flag6 && flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid3Pool;
						z = 90f;
					}
					else if (flag5 && flag6 && flag7 && !flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid4Pool;
						z = 0f;
					}
					else if (flag5 && !flag6 && flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid4Pool;
						z = 90f;
					}
					else if (!flag5 && flag6 && flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid4Pool;
						z = 180f;
					}
					else if (flag5 && flag6 && !flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid4Pool;
						z = 270f;
					}
					else if (flag5 && flag6 && flag7 && flag8)
					{
						gameObjectPool = this.m_dangerCornerGrid5Pool;
						z = 0f;
					}
				}
				else if (flag && !flag2 && !flag3 && !flag4)
				{
					bool flag9 = !BattleMapUIController.IsInRegion(p.x - 1, p.y + 1, region);
					bool flag10 = !BattleMapUIController.IsInRegion(p.x + 1, p.y + 1, region);
					if (!flag9 && !flag10)
					{
						gameObjectPool = this.m_dangerEdgeGrid1Pool;
						z = 0f;
					}
					else if (flag9 && !flag10)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_1Pool;
						z = 0f;
					}
					else if (!flag9 && flag10)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_2Pool;
						z = 0f;
					}
					else
					{
						gameObjectPool = this.m_dangerEdgeGrid1_3Pool;
						z = 0f;
					}
				}
				else if (!flag && !flag2 && flag3 && !flag4)
				{
					bool flag11 = !BattleMapUIController.IsInRegion(p.x + 1, p.y - 1, region);
					bool flag12 = !BattleMapUIController.IsInRegion(p.x + 1, p.y + 1, region);
					if (!flag11 && !flag12)
					{
						gameObjectPool = this.m_dangerEdgeGrid1Pool;
						z = 90f;
					}
					else if (!flag11 && flag12)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_1Pool;
						z = 90f;
					}
					else if (flag11 && !flag12)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_2Pool;
						z = 90f;
					}
					else if (flag11 && flag12)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_3Pool;
						z = 90f;
					}
				}
				else if (!flag && flag2 && !flag3 && !flag4)
				{
					bool flag13 = !BattleMapUIController.IsInRegion(p.x - 1, p.y - 1, region);
					bool flag14 = !BattleMapUIController.IsInRegion(p.x + 1, p.y - 1, region);
					if (!flag13 && !flag14)
					{
						gameObjectPool = this.m_dangerEdgeGrid1Pool;
						z = 180f;
					}
					else if (!flag13 && flag14)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_1Pool;
						z = 180f;
					}
					else if (flag13 && !flag14)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_2Pool;
						z = 180f;
					}
					else if (flag13 && flag14)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_3Pool;
						z = 180f;
					}
				}
				else if (!flag && !flag2 && !flag3 && flag4)
				{
					bool flag15 = !BattleMapUIController.IsInRegion(p.x - 1, p.y - 1, region);
					bool flag16 = !BattleMapUIController.IsInRegion(p.x - 1, p.y + 1, region);
					if (!flag15 && !flag16)
					{
						gameObjectPool = this.m_dangerEdgeGrid1Pool;
						z = 270f;
					}
					else if (flag15 && !flag16)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_1Pool;
						z = 270f;
					}
					else if (!flag15 && flag16)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_2Pool;
						z = 270f;
					}
					else if (flag15 && flag16)
					{
						gameObjectPool = this.m_dangerEdgeGrid1_3Pool;
						z = 270f;
					}
				}
				else if (flag && !flag2 && flag3 && !flag4)
				{
					if (BattleMapUIController.IsInRegion(p.x + 1, p.y + 1, region))
					{
						gameObjectPool = this.m_dangerEdgeGrid2Pool;
						z = 0f;
					}
					else
					{
						gameObjectPool = this.m_dangerEdgeGrid2_1Pool;
						z = 180f;
					}
				}
				else if (!flag && flag2 && flag3 && !flag4)
				{
					if (BattleMapUIController.IsInRegion(p.x + 1, p.y - 1, region))
					{
						gameObjectPool = this.m_dangerEdgeGrid2Pool;
						z = 90f;
					}
					else
					{
						gameObjectPool = this.m_dangerEdgeGrid2_1Pool;
						z = 270f;
					}
				}
				else if (!flag && flag2 && !flag3 && flag4)
				{
					if (BattleMapUIController.IsInRegion(p.x - 1, p.y - 1, region))
					{
						gameObjectPool = this.m_dangerEdgeGrid2Pool;
						z = 180f;
					}
					else
					{
						gameObjectPool = this.m_dangerEdgeGrid2_1Pool;
						z = 0f;
					}
				}
				else if (flag && !flag2 && !flag3 && flag4)
				{
					if (BattleMapUIController.IsInRegion(p.x - 1, p.y + 1, region))
					{
						gameObjectPool = this.m_dangerEdgeGrid2Pool;
						z = 270f;
					}
					else
					{
						gameObjectPool = this.m_dangerEdgeGrid2_1Pool;
						z = 90f;
					}
				}
				else if (flag && flag2 && !flag3 && !flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid3Pool;
					z = 0f;
				}
				else if (!flag && !flag2 && flag3 && flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid3Pool;
					z = 90f;
				}
				else if (flag && !flag2 && flag3 && flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid4Pool;
					z = 0f;
				}
				else if (flag && flag2 && flag3 && !flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid4Pool;
					z = 90f;
				}
				else if (!flag && flag2 && flag3 && flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid4Pool;
					z = 180f;
				}
				else if (flag && flag2 && !flag3 && flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid4Pool;
					z = 270f;
				}
				else if (flag && flag2 && flag3 && flag4)
				{
					gameObjectPool = this.m_dangerEdgeGrid5Pool;
					z = 0f;
				}
				if (gameObjectPool != null)
				{
					GameObject gameObject = gameObjectPool.Allocate();
					gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, z);
					gameObject.transform.localPosition = this.GridPositionToWorldPosition(p, 0.1f);
				}
			}
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x002F3724 File Offset: 0x002F1924
		private static bool IsInRegion(int x, int y, HashSet<GridPosition> region)
		{
			return region.Contains(new GridPosition(x, y));
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x002F3734 File Offset: 0x002F1934
		public void HideDangerRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideDangerRegion_hotfix != null)
			{
				this.m_HideDangerRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dangerEdgeGrid0Pool.Deactive();
			this.m_dangerEdgeGrid1Pool.Deactive();
			this.m_dangerEdgeGrid1_1Pool.Deactive();
			this.m_dangerEdgeGrid1_2Pool.Deactive();
			this.m_dangerEdgeGrid1_3Pool.Deactive();
			this.m_dangerEdgeGrid2Pool.Deactive();
			this.m_dangerEdgeGrid2_1Pool.Deactive();
			this.m_dangerEdgeGrid3Pool.Deactive();
			this.m_dangerEdgeGrid4Pool.Deactive();
			this.m_dangerEdgeGrid5Pool.Deactive();
			this.m_dangerCornerGrid1Pool.Deactive();
			this.m_dangerCornerGrid2Pool.Deactive();
			this.m_dangerCornerGrid3Pool.Deactive();
			this.m_dangerCornerGrid4Pool.Deactive();
			this.m_dangerCornerGrid5Pool.Deactive();
		}

		// Token: 0x0600A902 RID: 43266 RVA: 0x002F383C File Offset: 0x002F1A3C
		public void ShowReachRegion(List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowReachRegionList`1_hotfix != null)
			{
				this.m_ShowReachRegionList`1_hotfix.call(new object[]
				{
					this,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideReachRegion();
			foreach (GridPosition p in region)
			{
				GameObject gameObject = this.m_reachGridPool.Allocate();
				gameObject.transform.localPosition = this.GridPositionToWorldPosition(p, -0.2f);
			}
		}

		// Token: 0x0600A903 RID: 43267 RVA: 0x002F3918 File Offset: 0x002F1B18
		public void HideReachRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideReachRegion_hotfix != null)
			{
				this.m_HideReachRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_reachGridPool.Deactive();
		}

		// Token: 0x0600A904 RID: 43268 RVA: 0x002F3984 File Offset: 0x002F1B84
		public void ShowMovePath(List<GridPosition> path)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMovePathList`1_hotfix != null)
			{
				this.m_ShowMovePathList`1_hotfix.call(new object[]
				{
					this,
					path
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (path == null || path.Count < 2)
			{
				return;
			}
			this.HideMovePath();
			for (int i = 0; i < path.Count; i++)
			{
				GridPosition p = path[i];
				int num = 0;
				GameObject gameObject;
				if (i == 0)
				{
					gameObject = this.m_arrowEndPool.Allocate();
					int num2 = path[1].x - p.x;
					int num3 = path[1].y - p.y;
					if (num2 < 0)
					{
						num = 90;
					}
					else if (num2 > 0)
					{
						num = -90;
					}
					else if (num3 < 0)
					{
						num = 0;
					}
					else if (num3 > 0)
					{
						num = 180;
					}
				}
				else if (i == path.Count - 1)
				{
					gameObject = this.m_arrowHeadPool.Allocate();
					int num4 = p.x - path[i - 1].x;
					int num5 = p.y - path[i - 1].y;
					if (num4 < 0)
					{
						num = 90;
					}
					else if (num4 > 0)
					{
						num = -90;
					}
					else if (num5 < 0)
					{
						num = 0;
					}
					else if (num5 > 0)
					{
						num = 180;
					}
				}
				else
				{
					int num6 = path[i + 1].x - path[i - 1].x;
					if (path[i + 1].y - path[i - 1].y == 0)
					{
						gameObject = this.m_arrowLinePool.Allocate();
						num = 90;
					}
					else if (num6 == 0)
					{
						gameObject = this.m_arrowLinePool.Allocate();
					}
					else
					{
						gameObject = this.m_arrowCornerPool.Allocate();
						int num7 = p.x - path[i - 1].x;
						int num8 = p.y - path[i - 1].y;
						int num9 = path[i + 1].x - p.x;
						int num10 = path[i + 1].y - p.y;
						if (num7 < 0)
						{
							if (num10 < 0)
							{
								num = 0;
							}
							else
							{
								num = -90;
							}
						}
						else if (num7 > 0)
						{
							if (num10 < 0)
							{
								num = 90;
							}
							else
							{
								num = 180;
							}
						}
						else if (num8 < 0)
						{
							if (num9 < 0)
							{
								num = 180;
							}
							else
							{
								num = -90;
							}
						}
						else if (num8 > 0)
						{
							if (num9 < 0)
							{
								num = 90;
							}
							else
							{
								num = 0;
							}
						}
					}
				}
				if (gameObject != null)
				{
					gameObject.transform.localRotation = Quaternion.Euler(0f, 0f, (float)num);
					gameObject.transform.localPosition = this.GridPositionToWorldPosition(p, -0.1f);
				}
			}
		}

		// Token: 0x0600A905 RID: 43269 RVA: 0x002F3D08 File Offset: 0x002F1F08
		public void HideMovePath()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideMovePath_hotfix != null)
			{
				this.m_HideMovePath_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arrowHeadPool.Deactive();
			this.m_arrowEndPool.Deactive();
			this.m_arrowCornerPool.Deactive();
			this.m_arrowLinePool.Deactive();
		}

		// Token: 0x0600A906 RID: 43270 RVA: 0x002F3D94 File Offset: 0x002F1F94
		public void ShowStagePosition(StagePositionType posType, GridPosition pos, bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStagePositionStagePositionTypeGridPositionBoolean_hotfix != null)
			{
				this.m_ShowStagePositionStagePositionTypeGridPositionBoolean_hotfix.call(new object[]
				{
					this,
					posType,
					pos,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = null;
			if (posType == StagePositionType.Me)
			{
				gameObject = this.m_stagePosition0Pool.Allocate();
			}
			else if (posType == StagePositionType.Enemy)
			{
				gameObject = this.m_stagePosition1Pool.Allocate();
			}
			else if (posType == StagePositionType.Teammate)
			{
				gameObject = this.m_stagePosition2Pool.Allocate();
			}
			if (gameObject != null)
			{
				gameObject.name = string.Format("PositionGrid_{0}_{1}", pos.x, pos.y);
				gameObject.transform.localPosition = this.StagePositionToWorldPosition(pos);
				if (gameObject.transform.childCount > 1)
				{
					gameObject.transform.GetChild(1).gameObject.SetActive(on);
				}
			}
		}

		// Token: 0x0600A907 RID: 43271 RVA: 0x002F3ED8 File Offset: 0x002F20D8
		public void HideStagePositions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideStagePositions_hotfix != null)
			{
				this.m_HideStagePositions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stagePosition0Pool.Deactive();
			this.m_stagePosition1Pool.Deactive();
			this.m_stagePosition2Pool.Deactive();
		}

		// Token: 0x0600A908 RID: 43272 RVA: 0x002F3F5C File Offset: 0x002F215C
		public void PlayOnStageFx(StagePositionType posType, GridPosition pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayOnStageFxStagePositionTypeGridPosition_hotfix != null)
			{
				this.m_PlayOnStageFxStagePositionTypeGridPosition_hotfix.call(new object[]
				{
					this,
					posType,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle == null)
			{
				return;
			}
			string assetName = string.Empty;
			if (posType == StagePositionType.Me)
			{
				assetName = "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_G.prefab";
			}
			else if (posType == StagePositionType.Enemy)
			{
				assetName = "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_R.prefab";
			}
			else if (posType == StagePositionType.Teammate)
			{
				assetName = "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_B.prefab";
			}
			GenericGraphic genericGraphic = this.m_clientBattle.BattleFxPlayer.Play(assetName);
			if (genericGraphic != null)
			{
				genericGraphic.AutoDelete(true);
				genericGraphic.SetPosition(this.StagePositionToWorldPosition(pos));
			}
		}

		// Token: 0x0600A909 RID: 43273 RVA: 0x002F404C File Offset: 0x002F224C
		public void SkillFadeIn(float time, float alpha)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillFadeInSingleSingle_hotfix != null)
			{
				this.m_SkillFadeInSingleSingle_hotfix.call(new object[]
				{
					this,
					time,
					alpha
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fadeGameObject.SetActive(true);
			this.m_isFadeIn = true;
			this.m_fadeCurTime = 0f;
			this.m_fadeDuration = time;
			this.m_fadeColor.a = alpha;
			this.UpdateFade(0f);
		}

		// Token: 0x0600A90A RID: 43274 RVA: 0x002F4108 File Offset: 0x002F2308
		public void SkillFadeOut(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkillFadeOutSingle_hotfix != null)
			{
				this.m_SkillFadeOutSingle_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fadeGameObject.SetActive(true);
			this.m_isFadeIn = false;
			this.m_fadeCurTime = 0f;
			this.m_fadeDuration = time;
			this.UpdateFade(0f);
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x002F41A8 File Offset: 0x002F23A8
		private void HideFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideFade_hotfix != null)
			{
				this.m_HideFade_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fadeGameObject.SetActive(false);
			this.m_fadeCurTime = (this.m_fadeDuration = 0f);
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x002F4228 File Offset: 0x002F2428
		private void SetFade(float a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFadeSingle_hotfix != null)
			{
				this.m_SetFadeSingle_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fadeMaterial != null)
			{
				this.m_fadeMaterial.color = new Color(this.m_fadeColor.r, this.m_fadeColor.g, this.m_fadeColor.b, Mathf.Lerp(0f, this.m_fadeColor.a, a));
			}
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x002F42F0 File Offset: 0x002F24F0
		private void UpdateFade(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFadeSingle_hotfix != null)
			{
				this.m_UpdateFadeSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fadeDuration > 0f && this.m_fadeCurTime < this.m_fadeDuration)
			{
				this.m_fadeCurTime += dt;
				float num = Mathf.Clamp01(this.m_fadeCurTime / this.m_fadeDuration);
				if (this.m_isFadeIn)
				{
					this.SetFade(num);
				}
				else
				{
					this.SetFade(1f - num);
					if (num >= 1f)
					{
						this.HideFade();
					}
				}
			}
		}

		// Token: 0x0600A90E RID: 43278 RVA: 0x002F43D8 File Offset: 0x002F25D8
		public void ShowZoomFade(GridPosition startPos, float fadeDuration, bool fadeIn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowZoomFadeGridPositionSingleBoolean_hotfix != null)
			{
				this.m_ShowZoomFadeGridPositionSingleBoolean_hotfix.call(new object[]
				{
					this,
					startPos,
					fadeDuration,
					fadeIn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle == null)
			{
				return;
			}
			this.m_zoomFadeGameObject.SetActive(true);
			this.m_zoomFadeFullGameObject.SetActive(false);
			this.m_isZoomFadeIn = fadeIn;
			this.m_zoomFadeCurTime = 0f;
			this.m_zoomFadeDuration = fadeDuration + 0.2f;
			this.m_fadeGridPool.Deactive();
			int num = 13;
			for (int i = startPos.y - 10; i <= startPos.y + 10; i++)
			{
				for (int j = startPos.x - num; j <= startPos.x + num; j++)
				{
					GridPosition gridPosition = new GridPosition(j, i);
					RegionGridEffect regionGridEffect = this.m_fadeGridPool.Allocate();
					if (regionGridEffect != null)
					{
						regionGridEffect.transform.localPosition = this.GridPositionToWorldPosition(gridPosition, 0f);
						if (fadeIn)
						{
							regionGridEffect.SetDelay((float)Mathf.Max(num - GridPosition.Distance(gridPosition, startPos), 0) * fadeDuration / (float)num);
						}
						else
						{
							regionGridEffect.SetDelay((float)Mathf.Min(GridPosition.Distance(gridPosition, startPos), num) * 0.03f);
						}
						regionGridEffect.SetDuration(0.2f);
						regionGridEffect.SetFade(fadeIn);
					}
				}
			}
		}

		// Token: 0x0600A90F RID: 43279 RVA: 0x002F4590 File Offset: 0x002F2790
		private void FullZoomFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FullZoomFade_hotfix != null)
			{
				this.m_FullZoomFade_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_zoomFadeFullGameObject.SetActive(true);
			this.m_fadeGridPool.Deactive();
		}

		// Token: 0x0600A910 RID: 43280 RVA: 0x002F4608 File Offset: 0x002F2808
		private void HideZoomFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideZoomFade_hotfix != null)
			{
				this.m_HideZoomFade_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_zoomFadeGameObject.SetActive(false);
			this.m_zoomFadeCurTime = (this.m_zoomFadeDuration = 0f);
		}

		// Token: 0x0600A911 RID: 43281 RVA: 0x002F4688 File Offset: 0x002F2888
		public bool IsShowZoomFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsShowZoomFade_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsShowZoomFade_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_zoomFadeGameObject.activeSelf;
		}

		// Token: 0x0600A912 RID: 43282 RVA: 0x002F4700 File Offset: 0x002F2900
		private Vector3 StagePositionToWorldPosition(GridPosition pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StagePositionToWorldPositionGridPosition_hotfix != null)
			{
				return (Vector3)this.m_StagePositionToWorldPositionGridPosition_hotfix.call(new object[]
				{
					this,
					pos
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GridPositionToWorldPosition(pos, (float)pos.y * -0.01f - 5f);
		}

		// Token: 0x0600A913 RID: 43283 RVA: 0x002F4798 File Offset: 0x002F2998
		private Vector3 GridPositionToWorldPosition(GridPosition p, float z)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToWorldPositionGridPositionSingle_hotfix != null)
			{
				return (Vector3)this.m_GridPositionToWorldPositionGridPositionSingle_hotfix.call(new object[]
				{
					this,
					p,
					z
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 vector = this.m_clientBattle.GridPositionToWorldPosition(p);
			return new Vector3(vector.x, vector.y, z);
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0600A914 RID: 43284 RVA: 0x002F4848 File Offset: 0x002F2A48
		// (set) Token: 0x0600A915 RID: 43285 RVA: 0x002F4868 File Offset: 0x002F2A68
		[DoNotToLua]
		public new BattleMapUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleMapUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A916 RID: 43286 RVA: 0x002F4874 File Offset: 0x002F2A74
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A917 RID: 43287 RVA: 0x002F4880 File Offset: 0x002F2A80
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A918 RID: 43288 RVA: 0x002F4888 File Offset: 0x002F2A88
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A919 RID: 43289 RVA: 0x002F4890 File Offset: 0x002F2A90
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A91A RID: 43290 RVA: 0x002F48A4 File Offset: 0x002F2AA4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A91B RID: 43291 RVA: 0x002F48AC File Offset: 0x002F2AAC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A91C RID: 43292 RVA: 0x002F48B8 File Offset: 0x002F2AB8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A91D RID: 43293 RVA: 0x002F48C4 File Offset: 0x002F2AC4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A91E RID: 43294 RVA: 0x002F48D0 File Offset: 0x002F2AD0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A91F RID: 43295 RVA: 0x002F48DC File Offset: 0x002F2ADC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A920 RID: 43296 RVA: 0x002F48E8 File Offset: 0x002F2AE8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x002F48F4 File Offset: 0x002F2AF4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x002F4900 File Offset: 0x002F2B00
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x002F490C File Offset: 0x002F2B0C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x002F4918 File Offset: 0x002F2B18
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x002F4920 File Offset: 0x002F2B20
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
					this.m_InitializeClientBattle_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_PrepareBattle_hotfix = (luaObj.RawGet("PrepareBattle") as LuaFunction);
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_StopBattle_hotfix = (luaObj.RawGet("StopBattle") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_UpdateZoomFadeSingle_hotfix = (luaObj.RawGet("UpdateZoomFade") as LuaFunction);
					this.m_ShowRegionGridPosition_hotfix = (luaObj.RawGet("ShowRegion") as LuaFunction);
					this.m_HideRegion_hotfix = (luaObj.RawGet("HideRegion") as LuaFunction);
					this.m_ShowDangerRegionHashSet`1_hotfix = (luaObj.RawGet("ShowDangerRegion") as LuaFunction);
					this.m_HideDangerRegion_hotfix = (luaObj.RawGet("HideDangerRegion") as LuaFunction);
					this.m_ShowReachRegionList`1_hotfix = (luaObj.RawGet("ShowReachRegion") as LuaFunction);
					this.m_HideReachRegion_hotfix = (luaObj.RawGet("HideReachRegion") as LuaFunction);
					this.m_ShowMovePathList`1_hotfix = (luaObj.RawGet("ShowMovePath") as LuaFunction);
					this.m_HideMovePath_hotfix = (luaObj.RawGet("HideMovePath") as LuaFunction);
					this.m_ShowStagePositionStagePositionTypeGridPositionBoolean_hotfix = (luaObj.RawGet("ShowStagePosition") as LuaFunction);
					this.m_HideStagePositions_hotfix = (luaObj.RawGet("HideStagePositions") as LuaFunction);
					this.m_PlayOnStageFxStagePositionTypeGridPosition_hotfix = (luaObj.RawGet("PlayOnStageFx") as LuaFunction);
					this.m_SkillFadeInSingleSingle_hotfix = (luaObj.RawGet("SkillFadeIn") as LuaFunction);
					this.m_SkillFadeOutSingle_hotfix = (luaObj.RawGet("SkillFadeOut") as LuaFunction);
					this.m_HideFade_hotfix = (luaObj.RawGet("HideFade") as LuaFunction);
					this.m_SetFadeSingle_hotfix = (luaObj.RawGet("SetFade") as LuaFunction);
					this.m_UpdateFadeSingle_hotfix = (luaObj.RawGet("UpdateFade") as LuaFunction);
					this.m_ShowZoomFadeGridPositionSingleBoolean_hotfix = (luaObj.RawGet("ShowZoomFade") as LuaFunction);
					this.m_FullZoomFade_hotfix = (luaObj.RawGet("FullZoomFade") as LuaFunction);
					this.m_HideZoomFade_hotfix = (luaObj.RawGet("HideZoomFade") as LuaFunction);
					this.m_IsShowZoomFade_hotfix = (luaObj.RawGet("IsShowZoomFade") as LuaFunction);
					this.m_StagePositionToWorldPositionGridPosition_hotfix = (luaObj.RawGet("StagePositionToWorldPosition") as LuaFunction);
					this.m_GridPositionToWorldPositionGridPositionSingle_hotfix = (luaObj.RawGet("GridPositionToWorldPosition") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A926 RID: 43302 RVA: 0x002F4C90 File Offset: 0x002F2E90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleMapUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006F57 RID: 28503
		private ClientBattle m_clientBattle;

		// Token: 0x04006F58 RID: 28504
		private GameObjectPool<RegionGridEffect> m_moveGridPool;

		// Token: 0x04006F59 RID: 28505
		private GameObjectPool<RegionGridEffect> m_attackGridPool;

		// Token: 0x04006F5A RID: 28506
		private GameObjectPool<RegionGridEffect> m_skillGridPool;

		// Token: 0x04006F5B RID: 28507
		private GameObjectPool<RegionGridEffect> m_teleportGridPool;

		// Token: 0x04006F5C RID: 28508
		private GameObjectPool<RegionGridEffect> m_fadeGridPool;

		// Token: 0x04006F5D RID: 28509
		private GameObjectPool m_dangerEdgeGrid0Pool;

		// Token: 0x04006F5E RID: 28510
		private GameObjectPool m_dangerEdgeGrid1Pool;

		// Token: 0x04006F5F RID: 28511
		private GameObjectPool m_dangerEdgeGrid1_1Pool;

		// Token: 0x04006F60 RID: 28512
		private GameObjectPool m_dangerEdgeGrid1_2Pool;

		// Token: 0x04006F61 RID: 28513
		private GameObjectPool m_dangerEdgeGrid1_3Pool;

		// Token: 0x04006F62 RID: 28514
		private GameObjectPool m_dangerEdgeGrid2Pool;

		// Token: 0x04006F63 RID: 28515
		private GameObjectPool m_dangerEdgeGrid2_1Pool;

		// Token: 0x04006F64 RID: 28516
		private GameObjectPool m_dangerEdgeGrid3Pool;

		// Token: 0x04006F65 RID: 28517
		private GameObjectPool m_dangerEdgeGrid4Pool;

		// Token: 0x04006F66 RID: 28518
		private GameObjectPool m_dangerEdgeGrid5Pool;

		// Token: 0x04006F67 RID: 28519
		private GameObjectPool m_dangerCornerGrid1Pool;

		// Token: 0x04006F68 RID: 28520
		private GameObjectPool m_dangerCornerGrid2Pool;

		// Token: 0x04006F69 RID: 28521
		private GameObjectPool m_dangerCornerGrid3Pool;

		// Token: 0x04006F6A RID: 28522
		private GameObjectPool m_dangerCornerGrid4Pool;

		// Token: 0x04006F6B RID: 28523
		private GameObjectPool m_dangerCornerGrid5Pool;

		// Token: 0x04006F6C RID: 28524
		private GameObjectPool m_reachGridPool;

		// Token: 0x04006F6D RID: 28525
		private GameObjectPool m_stagePosition0Pool;

		// Token: 0x04006F6E RID: 28526
		private GameObjectPool m_stagePosition1Pool;

		// Token: 0x04006F6F RID: 28527
		private GameObjectPool m_stagePosition2Pool;

		// Token: 0x04006F70 RID: 28528
		private GameObjectPool m_arrowHeadPool;

		// Token: 0x04006F71 RID: 28529
		private GameObjectPool m_arrowEndPool;

		// Token: 0x04006F72 RID: 28530
		private GameObjectPool m_arrowCornerPool;

		// Token: 0x04006F73 RID: 28531
		private GameObjectPool m_arrowLinePool;

		// Token: 0x04006F74 RID: 28532
		private bool m_isFadeIn;

		// Token: 0x04006F75 RID: 28533
		private float m_fadeCurTime;

		// Token: 0x04006F76 RID: 28534
		private float m_fadeDuration;

		// Token: 0x04006F77 RID: 28535
		private Material m_fadeMaterial;

		// Token: 0x04006F78 RID: 28536
		private Color m_fadeColor;

		// Token: 0x04006F79 RID: 28537
		private bool m_isZoomFadeIn;

		// Token: 0x04006F7A RID: 28538
		private float m_zoomFadeCurTime;

		// Token: 0x04006F7B RID: 28539
		private float m_zoomFadeDuration;

		// Token: 0x04006F7C RID: 28540
		[AutoBind("./Grid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_gridGameObject;

		// Token: 0x04006F7D RID: 28541
		[AutoBind("./Fade", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_fadeGameObject;

		// Token: 0x04006F7E RID: 28542
		[AutoBind("./ZoomFade", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_zoomFadeGameObject;

		// Token: 0x04006F7F RID: 28543
		[AutoBind("./ZoomFade/Full", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_zoomFadeFullGameObject;

		// Token: 0x04006F80 RID: 28544
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04006F81 RID: 28545
		[AutoBind("./Prefabs/MoveGrid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_moveGridPrefab;

		// Token: 0x04006F82 RID: 28546
		[AutoBind("./Prefabs/AttackGrid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_attackGridPrefab;

		// Token: 0x04006F83 RID: 28547
		[AutoBind("./Prefabs/SkillGrid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillGridPrefab;

		// Token: 0x04006F84 RID: 28548
		[AutoBind("./Prefabs/TeleportGrid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teleportGridPrefab;

		// Token: 0x04006F85 RID: 28549
		[AutoBind("./Prefabs/FadeGrid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_fadeGridPrefab;

		// Token: 0x04006F86 RID: 28550
		[AutoBind("./Prefabs/ReachGrid", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_reachGridPrefab;

		// Token: 0x04006F87 RID: 28551
		[AutoBind("./Prefabs/ArrowHead", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arrowHeadPrefab;

		// Token: 0x04006F88 RID: 28552
		[AutoBind("./Prefabs/ArrowEnd", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arrowEndPrefab;

		// Token: 0x04006F89 RID: 28553
		[AutoBind("./Prefabs/ArrowCorner", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arrowCornerPrefab;

		// Token: 0x04006F8A RID: 28554
		[AutoBind("./Prefabs/ArrowLine", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arrowLinePrefab;

		// Token: 0x04006F8B RID: 28555
		[AutoBind("./Prefabs/DangerEdgeGrid0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid0Prefab;

		// Token: 0x04006F8C RID: 28556
		[AutoBind("./Prefabs/DangerEdgeGrid1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid1Prefab;

		// Token: 0x04006F8D RID: 28557
		[AutoBind("./Prefabs/DangerEdgeGrid1_1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid1_1Prefab;

		// Token: 0x04006F8E RID: 28558
		[AutoBind("./Prefabs/DangerEdgeGrid1_2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid1_2Prefab;

		// Token: 0x04006F8F RID: 28559
		[AutoBind("./Prefabs/DangerEdgeGrid1_3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid1_3Prefab;

		// Token: 0x04006F90 RID: 28560
		[AutoBind("./Prefabs/DangerEdgeGrid2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid2Prefab;

		// Token: 0x04006F91 RID: 28561
		[AutoBind("./Prefabs/DangerEdgeGrid2_1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid2_1Prefab;

		// Token: 0x04006F92 RID: 28562
		[AutoBind("./Prefabs/DangerEdgeGrid3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid3Prefab;

		// Token: 0x04006F93 RID: 28563
		[AutoBind("./Prefabs/DangerEdgeGrid4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid4Prefab;

		// Token: 0x04006F94 RID: 28564
		[AutoBind("./Prefabs/DangerEdgeGrid5", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerEdgeGrid5Prefab;

		// Token: 0x04006F95 RID: 28565
		[AutoBind("./Prefabs/DangerCornerGrid1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerCornerGrid1Prefab;

		// Token: 0x04006F96 RID: 28566
		[AutoBind("./Prefabs/DangerCornerGrid2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerCornerGrid2Prefab;

		// Token: 0x04006F97 RID: 28567
		[AutoBind("./Prefabs/DangerCornerGrid3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerCornerGrid3Prefab;

		// Token: 0x04006F98 RID: 28568
		[AutoBind("./Prefabs/DangerCornerGrid4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerCornerGrid4Prefab;

		// Token: 0x04006F99 RID: 28569
		[AutoBind("./Prefabs/DangerCornerGrid5", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dangerCornerGrid5Prefab;

		// Token: 0x04006F9A RID: 28570
		[DoNotToLua]
		private BattleMapUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006F9B RID: 28571
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006F9C RID: 28572
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006F9D RID: 28573
		private LuaFunction m_InitializeClientBattle_hotfix;

		// Token: 0x04006F9E RID: 28574
		private LuaFunction m_PrepareBattle_hotfix;

		// Token: 0x04006F9F RID: 28575
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x04006FA0 RID: 28576
		private LuaFunction m_StopBattle_hotfix;

		// Token: 0x04006FA1 RID: 28577
		private LuaFunction m_Update_hotfix;

		// Token: 0x04006FA2 RID: 28578
		private LuaFunction m_UpdateZoomFadeSingle_hotfix;

		// Token: 0x04006FA3 RID: 28579
		private LuaFunction m_ShowRegionGridPosition_hotfix;

		// Token: 0x04006FA4 RID: 28580
		private LuaFunction m_HideRegion_hotfix;

		// Token: 0x04006FA5 RID: 28581
		private LuaFunction m_ShowDangerRegionHashSet;

		// Token: 0x04006FA6 RID: 28582
		private LuaFunction m_HideDangerRegion_hotfix;

		// Token: 0x04006FA7 RID: 28583
		private LuaFunction m_ShowReachRegionList;

		// Token: 0x04006FA8 RID: 28584
		private LuaFunction m_HideReachRegion_hotfix;

		// Token: 0x04006FA9 RID: 28585
		private LuaFunction m_ShowMovePathList;

		// Token: 0x04006FAA RID: 28586
		private LuaFunction m_HideMovePath_hotfix;

		// Token: 0x04006FAB RID: 28587
		private LuaFunction m_ShowStagePositionStagePositionTypeGridPositionBoolean_hotfix;

		// Token: 0x04006FAC RID: 28588
		private LuaFunction m_HideStagePositions_hotfix;

		// Token: 0x04006FAD RID: 28589
		private LuaFunction m_PlayOnStageFxStagePositionTypeGridPosition_hotfix;

		// Token: 0x04006FAE RID: 28590
		private LuaFunction m_SkillFadeInSingleSingle_hotfix;

		// Token: 0x04006FAF RID: 28591
		private LuaFunction m_SkillFadeOutSingle_hotfix;

		// Token: 0x04006FB0 RID: 28592
		private LuaFunction m_HideFade_hotfix;

		// Token: 0x04006FB1 RID: 28593
		private LuaFunction m_SetFadeSingle_hotfix;

		// Token: 0x04006FB2 RID: 28594
		private LuaFunction m_UpdateFadeSingle_hotfix;

		// Token: 0x04006FB3 RID: 28595
		private LuaFunction m_ShowZoomFadeGridPositionSingleBoolean_hotfix;

		// Token: 0x04006FB4 RID: 28596
		private LuaFunction m_FullZoomFade_hotfix;

		// Token: 0x04006FB5 RID: 28597
		private LuaFunction m_HideZoomFade_hotfix;

		// Token: 0x04006FB6 RID: 28598
		private LuaFunction m_IsShowZoomFade_hotfix;

		// Token: 0x04006FB7 RID: 28599
		private LuaFunction m_StagePositionToWorldPositionGridPosition_hotfix;

		// Token: 0x04006FB8 RID: 28600
		private LuaFunction m_GridPositionToWorldPositionGridPositionSingle_hotfix;

		// Token: 0x02000A7B RID: 2683
		public new class LuaExportHelper
		{
			// Token: 0x0600A927 RID: 43303 RVA: 0x002F4CF8 File Offset: 0x002F2EF8
			public LuaExportHelper(BattleMapUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A928 RID: 43304 RVA: 0x002F4D08 File Offset: 0x002F2F08
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A929 RID: 43305 RVA: 0x002F4D18 File Offset: 0x002F2F18
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A92A RID: 43306 RVA: 0x002F4D28 File Offset: 0x002F2F28
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A92B RID: 43307 RVA: 0x002F4D38 File Offset: 0x002F2F38
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A92C RID: 43308 RVA: 0x002F4D50 File Offset: 0x002F2F50
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A92D RID: 43309 RVA: 0x002F4D60 File Offset: 0x002F2F60
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A92E RID: 43310 RVA: 0x002F4D70 File Offset: 0x002F2F70
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A92F RID: 43311 RVA: 0x002F4D80 File Offset: 0x002F2F80
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A930 RID: 43312 RVA: 0x002F4D90 File Offset: 0x002F2F90
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A931 RID: 43313 RVA: 0x002F4DA0 File Offset: 0x002F2FA0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A932 RID: 43314 RVA: 0x002F4DB0 File Offset: 0x002F2FB0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A933 RID: 43315 RVA: 0x002F4DC0 File Offset: 0x002F2FC0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A934 RID: 43316 RVA: 0x002F4DD0 File Offset: 0x002F2FD0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A935 RID: 43317 RVA: 0x002F4DE0 File Offset: 0x002F2FE0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A936 RID: 43318 RVA: 0x002F4DF0 File Offset: 0x002F2FF0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700222F RID: 8751
			// (get) Token: 0x0600A937 RID: 43319 RVA: 0x002F4E00 File Offset: 0x002F3000
			// (set) Token: 0x0600A938 RID: 43320 RVA: 0x002F4E10 File Offset: 0x002F3010
			public ClientBattle m_clientBattle
			{
				get
				{
					return this.m_owner.m_clientBattle;
				}
				set
				{
					this.m_owner.m_clientBattle = value;
				}
			}

			// Token: 0x17002230 RID: 8752
			// (get) Token: 0x0600A939 RID: 43321 RVA: 0x002F4E20 File Offset: 0x002F3020
			// (set) Token: 0x0600A93A RID: 43322 RVA: 0x002F4E30 File Offset: 0x002F3030
			public GameObjectPool<RegionGridEffect> m_moveGridPool
			{
				get
				{
					return this.m_owner.m_moveGridPool;
				}
				set
				{
					this.m_owner.m_moveGridPool = value;
				}
			}

			// Token: 0x17002231 RID: 8753
			// (get) Token: 0x0600A93B RID: 43323 RVA: 0x002F4E40 File Offset: 0x002F3040
			// (set) Token: 0x0600A93C RID: 43324 RVA: 0x002F4E50 File Offset: 0x002F3050
			public GameObjectPool<RegionGridEffect> m_attackGridPool
			{
				get
				{
					return this.m_owner.m_attackGridPool;
				}
				set
				{
					this.m_owner.m_attackGridPool = value;
				}
			}

			// Token: 0x17002232 RID: 8754
			// (get) Token: 0x0600A93D RID: 43325 RVA: 0x002F4E60 File Offset: 0x002F3060
			// (set) Token: 0x0600A93E RID: 43326 RVA: 0x002F4E70 File Offset: 0x002F3070
			public GameObjectPool<RegionGridEffect> m_skillGridPool
			{
				get
				{
					return this.m_owner.m_skillGridPool;
				}
				set
				{
					this.m_owner.m_skillGridPool = value;
				}
			}

			// Token: 0x17002233 RID: 8755
			// (get) Token: 0x0600A93F RID: 43327 RVA: 0x002F4E80 File Offset: 0x002F3080
			// (set) Token: 0x0600A940 RID: 43328 RVA: 0x002F4E90 File Offset: 0x002F3090
			public GameObjectPool<RegionGridEffect> m_teleportGridPool
			{
				get
				{
					return this.m_owner.m_teleportGridPool;
				}
				set
				{
					this.m_owner.m_teleportGridPool = value;
				}
			}

			// Token: 0x17002234 RID: 8756
			// (get) Token: 0x0600A941 RID: 43329 RVA: 0x002F4EA0 File Offset: 0x002F30A0
			// (set) Token: 0x0600A942 RID: 43330 RVA: 0x002F4EB0 File Offset: 0x002F30B0
			public GameObjectPool<RegionGridEffect> m_fadeGridPool
			{
				get
				{
					return this.m_owner.m_fadeGridPool;
				}
				set
				{
					this.m_owner.m_fadeGridPool = value;
				}
			}

			// Token: 0x17002235 RID: 8757
			// (get) Token: 0x0600A943 RID: 43331 RVA: 0x002F4EC0 File Offset: 0x002F30C0
			// (set) Token: 0x0600A944 RID: 43332 RVA: 0x002F4ED0 File Offset: 0x002F30D0
			public GameObjectPool m_dangerEdgeGrid0Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid0Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid0Pool = value;
				}
			}

			// Token: 0x17002236 RID: 8758
			// (get) Token: 0x0600A945 RID: 43333 RVA: 0x002F4EE0 File Offset: 0x002F30E0
			// (set) Token: 0x0600A946 RID: 43334 RVA: 0x002F4EF0 File Offset: 0x002F30F0
			public GameObjectPool m_dangerEdgeGrid1Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1Pool = value;
				}
			}

			// Token: 0x17002237 RID: 8759
			// (get) Token: 0x0600A947 RID: 43335 RVA: 0x002F4F00 File Offset: 0x002F3100
			// (set) Token: 0x0600A948 RID: 43336 RVA: 0x002F4F10 File Offset: 0x002F3110
			public GameObjectPool m_dangerEdgeGrid1_1Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1_1Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1_1Pool = value;
				}
			}

			// Token: 0x17002238 RID: 8760
			// (get) Token: 0x0600A949 RID: 43337 RVA: 0x002F4F20 File Offset: 0x002F3120
			// (set) Token: 0x0600A94A RID: 43338 RVA: 0x002F4F30 File Offset: 0x002F3130
			public GameObjectPool m_dangerEdgeGrid1_2Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1_2Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1_2Pool = value;
				}
			}

			// Token: 0x17002239 RID: 8761
			// (get) Token: 0x0600A94B RID: 43339 RVA: 0x002F4F40 File Offset: 0x002F3140
			// (set) Token: 0x0600A94C RID: 43340 RVA: 0x002F4F50 File Offset: 0x002F3150
			public GameObjectPool m_dangerEdgeGrid1_3Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1_3Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1_3Pool = value;
				}
			}

			// Token: 0x1700223A RID: 8762
			// (get) Token: 0x0600A94D RID: 43341 RVA: 0x002F4F60 File Offset: 0x002F3160
			// (set) Token: 0x0600A94E RID: 43342 RVA: 0x002F4F70 File Offset: 0x002F3170
			public GameObjectPool m_dangerEdgeGrid2Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid2Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid2Pool = value;
				}
			}

			// Token: 0x1700223B RID: 8763
			// (get) Token: 0x0600A94F RID: 43343 RVA: 0x002F4F80 File Offset: 0x002F3180
			// (set) Token: 0x0600A950 RID: 43344 RVA: 0x002F4F90 File Offset: 0x002F3190
			public GameObjectPool m_dangerEdgeGrid2_1Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid2_1Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid2_1Pool = value;
				}
			}

			// Token: 0x1700223C RID: 8764
			// (get) Token: 0x0600A951 RID: 43345 RVA: 0x002F4FA0 File Offset: 0x002F31A0
			// (set) Token: 0x0600A952 RID: 43346 RVA: 0x002F4FB0 File Offset: 0x002F31B0
			public GameObjectPool m_dangerEdgeGrid3Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid3Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid3Pool = value;
				}
			}

			// Token: 0x1700223D RID: 8765
			// (get) Token: 0x0600A953 RID: 43347 RVA: 0x002F4FC0 File Offset: 0x002F31C0
			// (set) Token: 0x0600A954 RID: 43348 RVA: 0x002F4FD0 File Offset: 0x002F31D0
			public GameObjectPool m_dangerEdgeGrid4Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid4Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid4Pool = value;
				}
			}

			// Token: 0x1700223E RID: 8766
			// (get) Token: 0x0600A955 RID: 43349 RVA: 0x002F4FE0 File Offset: 0x002F31E0
			// (set) Token: 0x0600A956 RID: 43350 RVA: 0x002F4FF0 File Offset: 0x002F31F0
			public GameObjectPool m_dangerEdgeGrid5Pool
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid5Pool;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid5Pool = value;
				}
			}

			// Token: 0x1700223F RID: 8767
			// (get) Token: 0x0600A957 RID: 43351 RVA: 0x002F5000 File Offset: 0x002F3200
			// (set) Token: 0x0600A958 RID: 43352 RVA: 0x002F5010 File Offset: 0x002F3210
			public GameObjectPool m_dangerCornerGrid1Pool
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid1Pool;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid1Pool = value;
				}
			}

			// Token: 0x17002240 RID: 8768
			// (get) Token: 0x0600A959 RID: 43353 RVA: 0x002F5020 File Offset: 0x002F3220
			// (set) Token: 0x0600A95A RID: 43354 RVA: 0x002F5030 File Offset: 0x002F3230
			public GameObjectPool m_dangerCornerGrid2Pool
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid2Pool;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid2Pool = value;
				}
			}

			// Token: 0x17002241 RID: 8769
			// (get) Token: 0x0600A95B RID: 43355 RVA: 0x002F5040 File Offset: 0x002F3240
			// (set) Token: 0x0600A95C RID: 43356 RVA: 0x002F5050 File Offset: 0x002F3250
			public GameObjectPool m_dangerCornerGrid3Pool
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid3Pool;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid3Pool = value;
				}
			}

			// Token: 0x17002242 RID: 8770
			// (get) Token: 0x0600A95D RID: 43357 RVA: 0x002F5060 File Offset: 0x002F3260
			// (set) Token: 0x0600A95E RID: 43358 RVA: 0x002F5070 File Offset: 0x002F3270
			public GameObjectPool m_dangerCornerGrid4Pool
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid4Pool;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid4Pool = value;
				}
			}

			// Token: 0x17002243 RID: 8771
			// (get) Token: 0x0600A95F RID: 43359 RVA: 0x002F5080 File Offset: 0x002F3280
			// (set) Token: 0x0600A960 RID: 43360 RVA: 0x002F5090 File Offset: 0x002F3290
			public GameObjectPool m_dangerCornerGrid5Pool
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid5Pool;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid5Pool = value;
				}
			}

			// Token: 0x17002244 RID: 8772
			// (get) Token: 0x0600A961 RID: 43361 RVA: 0x002F50A0 File Offset: 0x002F32A0
			// (set) Token: 0x0600A962 RID: 43362 RVA: 0x002F50B0 File Offset: 0x002F32B0
			public GameObjectPool m_reachGridPool
			{
				get
				{
					return this.m_owner.m_reachGridPool;
				}
				set
				{
					this.m_owner.m_reachGridPool = value;
				}
			}

			// Token: 0x17002245 RID: 8773
			// (get) Token: 0x0600A963 RID: 43363 RVA: 0x002F50C0 File Offset: 0x002F32C0
			// (set) Token: 0x0600A964 RID: 43364 RVA: 0x002F50D0 File Offset: 0x002F32D0
			public GameObjectPool m_stagePosition0Pool
			{
				get
				{
					return this.m_owner.m_stagePosition0Pool;
				}
				set
				{
					this.m_owner.m_stagePosition0Pool = value;
				}
			}

			// Token: 0x17002246 RID: 8774
			// (get) Token: 0x0600A965 RID: 43365 RVA: 0x002F50E0 File Offset: 0x002F32E0
			// (set) Token: 0x0600A966 RID: 43366 RVA: 0x002F50F0 File Offset: 0x002F32F0
			public GameObjectPool m_stagePosition1Pool
			{
				get
				{
					return this.m_owner.m_stagePosition1Pool;
				}
				set
				{
					this.m_owner.m_stagePosition1Pool = value;
				}
			}

			// Token: 0x17002247 RID: 8775
			// (get) Token: 0x0600A967 RID: 43367 RVA: 0x002F5100 File Offset: 0x002F3300
			// (set) Token: 0x0600A968 RID: 43368 RVA: 0x002F5110 File Offset: 0x002F3310
			public GameObjectPool m_stagePosition2Pool
			{
				get
				{
					return this.m_owner.m_stagePosition2Pool;
				}
				set
				{
					this.m_owner.m_stagePosition2Pool = value;
				}
			}

			// Token: 0x17002248 RID: 8776
			// (get) Token: 0x0600A969 RID: 43369 RVA: 0x002F5120 File Offset: 0x002F3320
			// (set) Token: 0x0600A96A RID: 43370 RVA: 0x002F5130 File Offset: 0x002F3330
			public GameObjectPool m_arrowHeadPool
			{
				get
				{
					return this.m_owner.m_arrowHeadPool;
				}
				set
				{
					this.m_owner.m_arrowHeadPool = value;
				}
			}

			// Token: 0x17002249 RID: 8777
			// (get) Token: 0x0600A96B RID: 43371 RVA: 0x002F5140 File Offset: 0x002F3340
			// (set) Token: 0x0600A96C RID: 43372 RVA: 0x002F5150 File Offset: 0x002F3350
			public GameObjectPool m_arrowEndPool
			{
				get
				{
					return this.m_owner.m_arrowEndPool;
				}
				set
				{
					this.m_owner.m_arrowEndPool = value;
				}
			}

			// Token: 0x1700224A RID: 8778
			// (get) Token: 0x0600A96D RID: 43373 RVA: 0x002F5160 File Offset: 0x002F3360
			// (set) Token: 0x0600A96E RID: 43374 RVA: 0x002F5170 File Offset: 0x002F3370
			public GameObjectPool m_arrowCornerPool
			{
				get
				{
					return this.m_owner.m_arrowCornerPool;
				}
				set
				{
					this.m_owner.m_arrowCornerPool = value;
				}
			}

			// Token: 0x1700224B RID: 8779
			// (get) Token: 0x0600A96F RID: 43375 RVA: 0x002F5180 File Offset: 0x002F3380
			// (set) Token: 0x0600A970 RID: 43376 RVA: 0x002F5190 File Offset: 0x002F3390
			public GameObjectPool m_arrowLinePool
			{
				get
				{
					return this.m_owner.m_arrowLinePool;
				}
				set
				{
					this.m_owner.m_arrowLinePool = value;
				}
			}

			// Token: 0x1700224C RID: 8780
			// (get) Token: 0x0600A971 RID: 43377 RVA: 0x002F51A0 File Offset: 0x002F33A0
			// (set) Token: 0x0600A972 RID: 43378 RVA: 0x002F51B0 File Offset: 0x002F33B0
			public bool m_isFadeIn
			{
				get
				{
					return this.m_owner.m_isFadeIn;
				}
				set
				{
					this.m_owner.m_isFadeIn = value;
				}
			}

			// Token: 0x1700224D RID: 8781
			// (get) Token: 0x0600A973 RID: 43379 RVA: 0x002F51C0 File Offset: 0x002F33C0
			// (set) Token: 0x0600A974 RID: 43380 RVA: 0x002F51D0 File Offset: 0x002F33D0
			public float m_fadeCurTime
			{
				get
				{
					return this.m_owner.m_fadeCurTime;
				}
				set
				{
					this.m_owner.m_fadeCurTime = value;
				}
			}

			// Token: 0x1700224E RID: 8782
			// (get) Token: 0x0600A975 RID: 43381 RVA: 0x002F51E0 File Offset: 0x002F33E0
			// (set) Token: 0x0600A976 RID: 43382 RVA: 0x002F51F0 File Offset: 0x002F33F0
			public float m_fadeDuration
			{
				get
				{
					return this.m_owner.m_fadeDuration;
				}
				set
				{
					this.m_owner.m_fadeDuration = value;
				}
			}

			// Token: 0x1700224F RID: 8783
			// (get) Token: 0x0600A977 RID: 43383 RVA: 0x002F5200 File Offset: 0x002F3400
			// (set) Token: 0x0600A978 RID: 43384 RVA: 0x002F5210 File Offset: 0x002F3410
			public Material m_fadeMaterial
			{
				get
				{
					return this.m_owner.m_fadeMaterial;
				}
				set
				{
					this.m_owner.m_fadeMaterial = value;
				}
			}

			// Token: 0x17002250 RID: 8784
			// (get) Token: 0x0600A979 RID: 43385 RVA: 0x002F5220 File Offset: 0x002F3420
			// (set) Token: 0x0600A97A RID: 43386 RVA: 0x002F5230 File Offset: 0x002F3430
			public Color m_fadeColor
			{
				get
				{
					return this.m_owner.m_fadeColor;
				}
				set
				{
					this.m_owner.m_fadeColor = value;
				}
			}

			// Token: 0x17002251 RID: 8785
			// (get) Token: 0x0600A97B RID: 43387 RVA: 0x002F5240 File Offset: 0x002F3440
			// (set) Token: 0x0600A97C RID: 43388 RVA: 0x002F5250 File Offset: 0x002F3450
			public bool m_isZoomFadeIn
			{
				get
				{
					return this.m_owner.m_isZoomFadeIn;
				}
				set
				{
					this.m_owner.m_isZoomFadeIn = value;
				}
			}

			// Token: 0x17002252 RID: 8786
			// (get) Token: 0x0600A97D RID: 43389 RVA: 0x002F5260 File Offset: 0x002F3460
			// (set) Token: 0x0600A97E RID: 43390 RVA: 0x002F5270 File Offset: 0x002F3470
			public float m_zoomFadeCurTime
			{
				get
				{
					return this.m_owner.m_zoomFadeCurTime;
				}
				set
				{
					this.m_owner.m_zoomFadeCurTime = value;
				}
			}

			// Token: 0x17002253 RID: 8787
			// (get) Token: 0x0600A97F RID: 43391 RVA: 0x002F5280 File Offset: 0x002F3480
			// (set) Token: 0x0600A980 RID: 43392 RVA: 0x002F5290 File Offset: 0x002F3490
			public float m_zoomFadeDuration
			{
				get
				{
					return this.m_owner.m_zoomFadeDuration;
				}
				set
				{
					this.m_owner.m_zoomFadeDuration = value;
				}
			}

			// Token: 0x17002254 RID: 8788
			// (get) Token: 0x0600A981 RID: 43393 RVA: 0x002F52A0 File Offset: 0x002F34A0
			// (set) Token: 0x0600A982 RID: 43394 RVA: 0x002F52B0 File Offset: 0x002F34B0
			public GameObject m_gridGameObject
			{
				get
				{
					return this.m_owner.m_gridGameObject;
				}
				set
				{
					this.m_owner.m_gridGameObject = value;
				}
			}

			// Token: 0x17002255 RID: 8789
			// (get) Token: 0x0600A983 RID: 43395 RVA: 0x002F52C0 File Offset: 0x002F34C0
			// (set) Token: 0x0600A984 RID: 43396 RVA: 0x002F52D0 File Offset: 0x002F34D0
			public GameObject m_fadeGameObject
			{
				get
				{
					return this.m_owner.m_fadeGameObject;
				}
				set
				{
					this.m_owner.m_fadeGameObject = value;
				}
			}

			// Token: 0x17002256 RID: 8790
			// (get) Token: 0x0600A985 RID: 43397 RVA: 0x002F52E0 File Offset: 0x002F34E0
			// (set) Token: 0x0600A986 RID: 43398 RVA: 0x002F52F0 File Offset: 0x002F34F0
			public GameObject m_zoomFadeGameObject
			{
				get
				{
					return this.m_owner.m_zoomFadeGameObject;
				}
				set
				{
					this.m_owner.m_zoomFadeGameObject = value;
				}
			}

			// Token: 0x17002257 RID: 8791
			// (get) Token: 0x0600A987 RID: 43399 RVA: 0x002F5300 File Offset: 0x002F3500
			// (set) Token: 0x0600A988 RID: 43400 RVA: 0x002F5310 File Offset: 0x002F3510
			public GameObject m_zoomFadeFullGameObject
			{
				get
				{
					return this.m_owner.m_zoomFadeFullGameObject;
				}
				set
				{
					this.m_owner.m_zoomFadeFullGameObject = value;
				}
			}

			// Token: 0x17002258 RID: 8792
			// (get) Token: 0x0600A989 RID: 43401 RVA: 0x002F5320 File Offset: 0x002F3520
			// (set) Token: 0x0600A98A RID: 43402 RVA: 0x002F5330 File Offset: 0x002F3530
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17002259 RID: 8793
			// (get) Token: 0x0600A98B RID: 43403 RVA: 0x002F5340 File Offset: 0x002F3540
			// (set) Token: 0x0600A98C RID: 43404 RVA: 0x002F5350 File Offset: 0x002F3550
			public GameObject m_moveGridPrefab
			{
				get
				{
					return this.m_owner.m_moveGridPrefab;
				}
				set
				{
					this.m_owner.m_moveGridPrefab = value;
				}
			}

			// Token: 0x1700225A RID: 8794
			// (get) Token: 0x0600A98D RID: 43405 RVA: 0x002F5360 File Offset: 0x002F3560
			// (set) Token: 0x0600A98E RID: 43406 RVA: 0x002F5370 File Offset: 0x002F3570
			public GameObject m_attackGridPrefab
			{
				get
				{
					return this.m_owner.m_attackGridPrefab;
				}
				set
				{
					this.m_owner.m_attackGridPrefab = value;
				}
			}

			// Token: 0x1700225B RID: 8795
			// (get) Token: 0x0600A98F RID: 43407 RVA: 0x002F5380 File Offset: 0x002F3580
			// (set) Token: 0x0600A990 RID: 43408 RVA: 0x002F5390 File Offset: 0x002F3590
			public GameObject m_skillGridPrefab
			{
				get
				{
					return this.m_owner.m_skillGridPrefab;
				}
				set
				{
					this.m_owner.m_skillGridPrefab = value;
				}
			}

			// Token: 0x1700225C RID: 8796
			// (get) Token: 0x0600A991 RID: 43409 RVA: 0x002F53A0 File Offset: 0x002F35A0
			// (set) Token: 0x0600A992 RID: 43410 RVA: 0x002F53B0 File Offset: 0x002F35B0
			public GameObject m_teleportGridPrefab
			{
				get
				{
					return this.m_owner.m_teleportGridPrefab;
				}
				set
				{
					this.m_owner.m_teleportGridPrefab = value;
				}
			}

			// Token: 0x1700225D RID: 8797
			// (get) Token: 0x0600A993 RID: 43411 RVA: 0x002F53C0 File Offset: 0x002F35C0
			// (set) Token: 0x0600A994 RID: 43412 RVA: 0x002F53D0 File Offset: 0x002F35D0
			public GameObject m_fadeGridPrefab
			{
				get
				{
					return this.m_owner.m_fadeGridPrefab;
				}
				set
				{
					this.m_owner.m_fadeGridPrefab = value;
				}
			}

			// Token: 0x1700225E RID: 8798
			// (get) Token: 0x0600A995 RID: 43413 RVA: 0x002F53E0 File Offset: 0x002F35E0
			// (set) Token: 0x0600A996 RID: 43414 RVA: 0x002F53F0 File Offset: 0x002F35F0
			public GameObject m_reachGridPrefab
			{
				get
				{
					return this.m_owner.m_reachGridPrefab;
				}
				set
				{
					this.m_owner.m_reachGridPrefab = value;
				}
			}

			// Token: 0x1700225F RID: 8799
			// (get) Token: 0x0600A997 RID: 43415 RVA: 0x002F5400 File Offset: 0x002F3600
			// (set) Token: 0x0600A998 RID: 43416 RVA: 0x002F5410 File Offset: 0x002F3610
			public GameObject m_arrowHeadPrefab
			{
				get
				{
					return this.m_owner.m_arrowHeadPrefab;
				}
				set
				{
					this.m_owner.m_arrowHeadPrefab = value;
				}
			}

			// Token: 0x17002260 RID: 8800
			// (get) Token: 0x0600A999 RID: 43417 RVA: 0x002F5420 File Offset: 0x002F3620
			// (set) Token: 0x0600A99A RID: 43418 RVA: 0x002F5430 File Offset: 0x002F3630
			public GameObject m_arrowEndPrefab
			{
				get
				{
					return this.m_owner.m_arrowEndPrefab;
				}
				set
				{
					this.m_owner.m_arrowEndPrefab = value;
				}
			}

			// Token: 0x17002261 RID: 8801
			// (get) Token: 0x0600A99B RID: 43419 RVA: 0x002F5440 File Offset: 0x002F3640
			// (set) Token: 0x0600A99C RID: 43420 RVA: 0x002F5450 File Offset: 0x002F3650
			public GameObject m_arrowCornerPrefab
			{
				get
				{
					return this.m_owner.m_arrowCornerPrefab;
				}
				set
				{
					this.m_owner.m_arrowCornerPrefab = value;
				}
			}

			// Token: 0x17002262 RID: 8802
			// (get) Token: 0x0600A99D RID: 43421 RVA: 0x002F5460 File Offset: 0x002F3660
			// (set) Token: 0x0600A99E RID: 43422 RVA: 0x002F5470 File Offset: 0x002F3670
			public GameObject m_arrowLinePrefab
			{
				get
				{
					return this.m_owner.m_arrowLinePrefab;
				}
				set
				{
					this.m_owner.m_arrowLinePrefab = value;
				}
			}

			// Token: 0x17002263 RID: 8803
			// (get) Token: 0x0600A99F RID: 43423 RVA: 0x002F5480 File Offset: 0x002F3680
			// (set) Token: 0x0600A9A0 RID: 43424 RVA: 0x002F5490 File Offset: 0x002F3690
			public GameObject m_dangerEdgeGrid0Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid0Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid0Prefab = value;
				}
			}

			// Token: 0x17002264 RID: 8804
			// (get) Token: 0x0600A9A1 RID: 43425 RVA: 0x002F54A0 File Offset: 0x002F36A0
			// (set) Token: 0x0600A9A2 RID: 43426 RVA: 0x002F54B0 File Offset: 0x002F36B0
			public GameObject m_dangerEdgeGrid1Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1Prefab = value;
				}
			}

			// Token: 0x17002265 RID: 8805
			// (get) Token: 0x0600A9A3 RID: 43427 RVA: 0x002F54C0 File Offset: 0x002F36C0
			// (set) Token: 0x0600A9A4 RID: 43428 RVA: 0x002F54D0 File Offset: 0x002F36D0
			public GameObject m_dangerEdgeGrid1_1Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1_1Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1_1Prefab = value;
				}
			}

			// Token: 0x17002266 RID: 8806
			// (get) Token: 0x0600A9A5 RID: 43429 RVA: 0x002F54E0 File Offset: 0x002F36E0
			// (set) Token: 0x0600A9A6 RID: 43430 RVA: 0x002F54F0 File Offset: 0x002F36F0
			public GameObject m_dangerEdgeGrid1_2Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1_2Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1_2Prefab = value;
				}
			}

			// Token: 0x17002267 RID: 8807
			// (get) Token: 0x0600A9A7 RID: 43431 RVA: 0x002F5500 File Offset: 0x002F3700
			// (set) Token: 0x0600A9A8 RID: 43432 RVA: 0x002F5510 File Offset: 0x002F3710
			public GameObject m_dangerEdgeGrid1_3Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid1_3Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid1_3Prefab = value;
				}
			}

			// Token: 0x17002268 RID: 8808
			// (get) Token: 0x0600A9A9 RID: 43433 RVA: 0x002F5520 File Offset: 0x002F3720
			// (set) Token: 0x0600A9AA RID: 43434 RVA: 0x002F5530 File Offset: 0x002F3730
			public GameObject m_dangerEdgeGrid2Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid2Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid2Prefab = value;
				}
			}

			// Token: 0x17002269 RID: 8809
			// (get) Token: 0x0600A9AB RID: 43435 RVA: 0x002F5540 File Offset: 0x002F3740
			// (set) Token: 0x0600A9AC RID: 43436 RVA: 0x002F5550 File Offset: 0x002F3750
			public GameObject m_dangerEdgeGrid2_1Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid2_1Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid2_1Prefab = value;
				}
			}

			// Token: 0x1700226A RID: 8810
			// (get) Token: 0x0600A9AD RID: 43437 RVA: 0x002F5560 File Offset: 0x002F3760
			// (set) Token: 0x0600A9AE RID: 43438 RVA: 0x002F5570 File Offset: 0x002F3770
			public GameObject m_dangerEdgeGrid3Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid3Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid3Prefab = value;
				}
			}

			// Token: 0x1700226B RID: 8811
			// (get) Token: 0x0600A9AF RID: 43439 RVA: 0x002F5580 File Offset: 0x002F3780
			// (set) Token: 0x0600A9B0 RID: 43440 RVA: 0x002F5590 File Offset: 0x002F3790
			public GameObject m_dangerEdgeGrid4Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid4Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid4Prefab = value;
				}
			}

			// Token: 0x1700226C RID: 8812
			// (get) Token: 0x0600A9B1 RID: 43441 RVA: 0x002F55A0 File Offset: 0x002F37A0
			// (set) Token: 0x0600A9B2 RID: 43442 RVA: 0x002F55B0 File Offset: 0x002F37B0
			public GameObject m_dangerEdgeGrid5Prefab
			{
				get
				{
					return this.m_owner.m_dangerEdgeGrid5Prefab;
				}
				set
				{
					this.m_owner.m_dangerEdgeGrid5Prefab = value;
				}
			}

			// Token: 0x1700226D RID: 8813
			// (get) Token: 0x0600A9B3 RID: 43443 RVA: 0x002F55C0 File Offset: 0x002F37C0
			// (set) Token: 0x0600A9B4 RID: 43444 RVA: 0x002F55D0 File Offset: 0x002F37D0
			public GameObject m_dangerCornerGrid1Prefab
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid1Prefab;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid1Prefab = value;
				}
			}

			// Token: 0x1700226E RID: 8814
			// (get) Token: 0x0600A9B5 RID: 43445 RVA: 0x002F55E0 File Offset: 0x002F37E0
			// (set) Token: 0x0600A9B6 RID: 43446 RVA: 0x002F55F0 File Offset: 0x002F37F0
			public GameObject m_dangerCornerGrid2Prefab
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid2Prefab;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid2Prefab = value;
				}
			}

			// Token: 0x1700226F RID: 8815
			// (get) Token: 0x0600A9B7 RID: 43447 RVA: 0x002F5600 File Offset: 0x002F3800
			// (set) Token: 0x0600A9B8 RID: 43448 RVA: 0x002F5610 File Offset: 0x002F3810
			public GameObject m_dangerCornerGrid3Prefab
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid3Prefab;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid3Prefab = value;
				}
			}

			// Token: 0x17002270 RID: 8816
			// (get) Token: 0x0600A9B9 RID: 43449 RVA: 0x002F5620 File Offset: 0x002F3820
			// (set) Token: 0x0600A9BA RID: 43450 RVA: 0x002F5630 File Offset: 0x002F3830
			public GameObject m_dangerCornerGrid4Prefab
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid4Prefab;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid4Prefab = value;
				}
			}

			// Token: 0x17002271 RID: 8817
			// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x002F5640 File Offset: 0x002F3840
			// (set) Token: 0x0600A9BC RID: 43452 RVA: 0x002F5650 File Offset: 0x002F3850
			public GameObject m_dangerCornerGrid5Prefab
			{
				get
				{
					return this.m_owner.m_dangerCornerGrid5Prefab;
				}
				set
				{
					this.m_owner.m_dangerCornerGrid5Prefab = value;
				}
			}

			// Token: 0x0600A9BD RID: 43453 RVA: 0x002F5660 File Offset: 0x002F3860
			public static void AddChildPrefab(GameObject go, string assetName)
			{
				BattleMapUIController.AddChildPrefab(go, assetName);
			}

			// Token: 0x0600A9BE RID: 43454 RVA: 0x002F566C File Offset: 0x002F386C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600A9BF RID: 43455 RVA: 0x002F567C File Offset: 0x002F387C
			public void UpdateZoomFade(float dt)
			{
				this.m_owner.UpdateZoomFade(dt);
			}

			// Token: 0x0600A9C0 RID: 43456 RVA: 0x002F568C File Offset: 0x002F388C
			public static bool IsInRegion(int x, int y, HashSet<GridPosition> region)
			{
				return BattleMapUIController.IsInRegion(x, y, region);
			}

			// Token: 0x0600A9C1 RID: 43457 RVA: 0x002F5698 File Offset: 0x002F3898
			public void HideFade()
			{
				this.m_owner.HideFade();
			}

			// Token: 0x0600A9C2 RID: 43458 RVA: 0x002F56A8 File Offset: 0x002F38A8
			public void SetFade(float a)
			{
				this.m_owner.SetFade(a);
			}

			// Token: 0x0600A9C3 RID: 43459 RVA: 0x002F56B8 File Offset: 0x002F38B8
			public void UpdateFade(float dt)
			{
				this.m_owner.UpdateFade(dt);
			}

			// Token: 0x0600A9C4 RID: 43460 RVA: 0x002F56C8 File Offset: 0x002F38C8
			public void FullZoomFade()
			{
				this.m_owner.FullZoomFade();
			}

			// Token: 0x0600A9C5 RID: 43461 RVA: 0x002F56D8 File Offset: 0x002F38D8
			public void HideZoomFade()
			{
				this.m_owner.HideZoomFade();
			}

			// Token: 0x0600A9C6 RID: 43462 RVA: 0x002F56E8 File Offset: 0x002F38E8
			public Vector3 StagePositionToWorldPosition(GridPosition pos)
			{
				return this.m_owner.StagePositionToWorldPosition(pos);
			}

			// Token: 0x0600A9C7 RID: 43463 RVA: 0x002F56F8 File Offset: 0x002F38F8
			public Vector3 GridPositionToWorldPosition(GridPosition p, float z)
			{
				return this.m_owner.GridPositionToWorldPosition(p, z);
			}

			// Token: 0x04006FB9 RID: 28601
			private BattleMapUIController m_owner;
		}
	}
}
