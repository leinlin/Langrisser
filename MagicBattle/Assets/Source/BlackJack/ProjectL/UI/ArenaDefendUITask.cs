using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A04 RID: 2564
	[HotFix]
	public class ArenaDefendUITask : UITask
	{
		// Token: 0x06009A32 RID: 39474 RVA: 0x002BF090 File Offset: 0x002BD290
		public ArenaDefendUITask(string name) : base(name)
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x002BF27C File Offset: 0x002BD47C
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_trainingTechs = projectLPlayerContext.GetTrainingGroundAvailableTechs();
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = projectLPlayerContext.GetArenaPlayerDefensiveTeam();
			List<int> arenaThisWeekDefendBattleIds = projectLPlayerContext.GetArenaThisWeekDefendBattleIds();
			this.m_arenaBattleInfos.Clear();
			foreach (int num in arenaThisWeekDefendBattleIds)
			{
				ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_configDataLoader.GetConfigDataArenaBattleInfo(num);
				if (configDataArenaBattleInfo != null)
				{
					base.CollectSpriteAsset(configDataArenaBattleInfo.Image);
					if (this.m_curBattleIndex < 0 && num == (int)arenaPlayerDefensiveTeam.BattleId)
					{
						this.m_curBattleIndex = this.m_arenaBattleInfos.Count;
					}
					this.m_arenaBattleInfos.Add(configDataArenaBattleInfo);
				}
			}
			if (this.m_curBattleIndex < 0)
			{
				this.m_curBattleIndex = 0;
			}
			ConfigDataArenaBattleInfo configDataArenaBattleInfo2 = this.m_arenaBattleInfos[this.m_curBattleIndex];
			this.CollectBattlefieldAssets(configDataArenaBattleInfo2.m_battlefieldInfo);
			this.m_defendRuleInfos.Clear();
			foreach (KeyValuePair<int, ConfigDataArenaDefendRuleInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataArenaDefendRuleInfo())
			{
				base.CollectSpriteAsset(keyValuePair.Value.Icon);
				if (this.m_curDefendRuleIndex < 0 && keyValuePair.Key == (int)arenaPlayerDefensiveTeam.ArenaDefenderRuleId)
				{
					this.m_curDefendRuleIndex = this.m_defendRuleInfos.Count;
				}
				this.m_defendRuleInfos.Add(keyValuePair.Value);
			}
			this.m_playerBattleHeros.Clear();
			foreach (Hero hero in projectLPlayerContext.GetHeros())
			{
				BattleHero item = projectLPlayerContext.CreateBattleHeroFromMyHero(hero);
				this.m_playerBattleHeros.Add(item);
			}
			List<BattleHero> playerBattleHeros = this.m_playerBattleHeros;
			if (ArenaDefendUITask.<>f__mg$cache0 == null)
			{
				ArenaDefendUITask.<>f__mg$cache0 = new Comparison<BattleHero>(ArenaDefendUITask.CompareHero);
			}
			playerBattleHeros.Sort(ArenaDefendUITask.<>f__mg$cache0);
			this.m_defendStageHeros.Clear();
			if (arenaPlayerDefensiveTeam.Heroes.Count <= 0)
			{
				int num2 = 0;
				foreach (BattleHero battleHero in this.m_playerBattleHeros)
				{
					if (num2 >= configDataArenaBattleInfo2.DefendNumber)
					{
						break;
					}
					battleHero.ActionPositionIndex = num2;
					battleHero.ActionValue = configDataArenaBattleInfo2.DefendNumber - num2;
					this.m_defendStageHeros.Add(battleHero);
					num2++;
				}
			}
			else
			{
				int num3 = 0;
				using (List<ArenaPlayerDefensiveHero>.Enumerator enumerator5 = arenaPlayerDefensiveTeam.Heroes.GetEnumerator())
				{
					while (enumerator5.MoveNext())
					{
						ArenaPlayerDefensiveHero h = enumerator5.Current;
						if (num3 >= configDataArenaBattleInfo2.DefendNumber)
						{
							break;
						}
						if (h.ActionPositionIndex < configDataArenaBattleInfo2.DefendPositions.Count)
						{
							BattleHero battleHero2 = this.m_playerBattleHeros.Find((BattleHero x) => x.HeroId == h.HeroId);
							if (battleHero2 != null)
							{
								battleHero2.ActionPositionIndex = h.ActionPositionIndex;
								battleHero2.ActionValue = h.ActionValue;
								this.m_defendStageHeros.Add(battleHero2);
								num3++;
							}
						}
					}
				}
			}
			foreach (BattleHero hero2 in this.m_defendStageHeros)
			{
				this.CollectHeroAndSoldierModelAssets(hero2);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x002BF710 File Offset: 0x002BD910
		private void CollectBattlefieldAssets(ConfigDataBattlefieldInfo battlefieldInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix != null)
			{
				this.m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix.call(new object[]
				{
					this,
					battlefieldInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battlefieldInfo == null)
			{
				return;
			}
			base.CollectAsset(battlefieldInfo.BattleMap);
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in battlefieldInfo.Terrains)
			{
				hashSet.Add(item);
			}
			foreach (int key in hashSet)
			{
				ConfigDataTerrainInfo configDataTerrainInfo = this.m_configDataLoader.GetConfigDataTerrainInfo(key);
				if (configDataTerrainInfo != null)
				{
					base.CollectAsset(configDataTerrainInfo.Fx);
				}
			}
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x002BF84C File Offset: 0x002BDA4C
		private void CollectHeroAndSoldierModelAssets(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectHeroAndSoldierModelAssetsBattleHero_hotfix != null)
			{
				this.m_CollectHeroAndSoldierModelAssetsBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			base.CollectAsset(UIUtility.GetHeroModelAssetPath(hero));
			base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(hero, 0));
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x002BF8DC File Offset: 0x002BDADC
		private void CollectHeadImageAssets(ConfigDataCharImageInfo charImageInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix != null)
			{
				this.m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (charImageInfo == null)
			{
				return;
			}
			base.CollectSpriteAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x002BF96C File Offset: 0x002BDB6C
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitLayerStateOnLoadAllResCompleted();
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x002BFA0C File Offset: 0x002BDC0C
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			this.InitArenaDefendUIController();
			UIUtility.ActivateLayer(this.m_battlePrepareActorInfoUIController, false);
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x002BFA84 File Offset: 0x002BDC84
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			this.UninitArenaDefendUIController();
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x002BFAF0 File Offset: 0x002BDCF0
		private void InitArenaDefendUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaDefendUIController_hotfix != null)
			{
				this.m_InitArenaDefendUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject layerPrefabRoot = this.m_layerArray[0].LayerPrefabRoot;
			if (this.m_arenaDefendBattle == null)
			{
				this.m_arenaDefendBattle = new ArenaDefendBattle();
				this.m_arenaDefendBattle.Initialize(layerPrefabRoot);
			}
			if (this.m_arenaDefendUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_arenaDefendUIController = (this.m_uiCtrlArray[0] as ArenaDefendUIController);
				}
				if (!(this.m_arenaDefendUIController != null))
				{
					global::Debug.LogError("ArenaDefendUIController is null");
					return;
				}
				this.m_arenaDefendUIController.Initialize(this.m_arenaDefendBattle);
				this.m_arenaDefendUIController.EventOnReturn += this.ArenaDefendUIController_OnReturn;
				this.m_arenaDefendUIController.EventOnSave += this.ArenaDefendUIController_OnSave;
				this.m_arenaDefendUIController.EventOnShowActionOrderPanel += this.ArenaDefendUIController_OnShowActionOrderPanel;
				this.m_arenaDefendUIController.EventOnShowMapPanel += this.ArenaDefendUIController_OnShowMapPanel;
				this.m_arenaDefendUIController.EventOnShowDefendRulePanel += this.ArenaDefendUIController_OnShowDefendRulePanel;
				this.m_arenaDefendUIController.EventOnConfirmActionOrder += this.ArenaDefendUIController_OnConfirmActionOrder;
				this.m_arenaDefendUIController.EventOnConfirmMap += this.ArenaDefendUIController_OnConfirmMap;
				this.m_arenaDefendUIController.EventOnConfirmDefendRule += this.ArenaDefendUIController_OnConfirmDefendRule;
				this.m_arenaDefendUIController.EventOnShowMyActorInfo += this.ArenaDefendUIController_OnShowMyActorInfo;
				this.m_arenaDefendUIController.EventOnHideActorInfo += this.ArenaDefendUIController_OnHideActorInfo;
				this.m_arenaDefendUIController.EventOnStageActorChange += this.ArenaDefendUIController_OnStageActorChange;
				this.m_arenaDefendUIController.EventOnHeroOnStage += this.ArenaDefendUIController_OnHeroOnStage;
				this.m_arenaDefendUIController.EventOnActorOffStage += this.ArenaDefendUIController_OnActorOffStage;
				this.m_arenaDefendUIController.EventOnStageActorMove += this.ArenaDefendUIController_OnStageActorMove;
				this.m_arenaDefendUIController.EventOnStageActorSwap += this.ArenaDefendUIController_OnStageActorSwap;
				this.m_arenaDefendUIController.EventOnPointerDown += this.ArenaDefendUIController_OnPointerDown;
				this.m_arenaDefendUIController.EventOnPointerUp += this.ArenaDefendUIController_OnPointerUp;
				this.m_arenaDefendUIController.EventOnPointerClick += this.ArenaDefendUIController_OnPointerClick;
			}
			if (this.m_battlePrepareActorInfoUIController == null)
			{
				if (this.m_uiCtrlArray.Length >= 1)
				{
					this.m_battlePrepareActorInfoUIController = (this.m_uiCtrlArray[1] as BattlePrepareActorInfoUIController);
				}
				if (this.m_battlePrepareActorInfoUIController != null)
				{
					this.m_battlePrepareActorInfoUIController.EventOnShowSelectSoldierPanel += this.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel;
					this.m_battlePrepareActorInfoUIController.EventOnChangeSkill += this.BattlePrepareActorInfoUIController_OnChangeSkill;
					this.m_battlePrepareActorInfoUIController.EventOnChangeSoldier += this.BattlePrepareActorInfoUIController_OnChangeSoldier;
				}
				else
				{
					global::Debug.LogError("BattlePrepareActorInfoUIController is null");
				}
			}
			if (this.m_arenaDefendMapUIController == null)
			{
				this.m_arenaDefendMapUIController = GameObjectUtility.AddControllerToGameObject<ArenaDefendMapUIController>(Utility.FindChildGameObject(layerPrefabRoot, "Map", true));
				this.m_arenaDefendMapUIController.Initialize(this.m_arenaDefendBattle);
			}
			if (this.m_arenaDefendSceneUIController == null)
			{
				this.m_arenaDefendSceneUIController = GameObjectUtility.AddControllerToGameObject<ArenaDefendSceneUIController>(Utility.FindChildGameObject(layerPrefabRoot, "Canvas", true));
				this.m_arenaDefendSceneUIController.EventOnPointerDown += this.ArenaDefendSceneUIController_OnPointerDown;
				this.m_arenaDefendSceneUIController.EventOnPointerUp += this.ArenaDefendSceneUIController_OnPointerUp;
				this.m_arenaDefendSceneUIController.EventOnPointerClick += this.ArenaDefendSceneUIController_OnPointerClick;
				this.m_arenaDefendSceneUIController.EventOnBeginDrag += this.ArenaDefendSceneUIController_OnBeginDrag;
				this.m_arenaDefendSceneUIController.EventOnEndDrag += this.ArenaDefendSceneUIController_OnEndDrag;
				this.m_arenaDefendSceneUIController.EventOnDrag += this.ArenaDefendSceneUIController_OnDrag;
			}
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x002BFF04 File Offset: 0x002BE104
		private void UninitArenaDefendUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitArenaDefendUIController_hotfix != null)
			{
				this.m_UninitArenaDefendUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaDefendUIController != null)
			{
				this.m_arenaDefendUIController.EventOnReturn -= this.ArenaDefendUIController_OnReturn;
				this.m_arenaDefendUIController.EventOnSave -= this.ArenaDefendUIController_OnSave;
				this.m_arenaDefendUIController.EventOnShowActionOrderPanel -= this.ArenaDefendUIController_OnShowActionOrderPanel;
				this.m_arenaDefendUIController.EventOnShowMapPanel -= this.ArenaDefendUIController_OnShowMapPanel;
				this.m_arenaDefendUIController.EventOnShowDefendRulePanel -= this.ArenaDefendUIController_OnShowDefendRulePanel;
				this.m_arenaDefendUIController.EventOnConfirmActionOrder -= this.ArenaDefendUIController_OnConfirmActionOrder;
				this.m_arenaDefendUIController.EventOnConfirmMap -= this.ArenaDefendUIController_OnConfirmMap;
				this.m_arenaDefendUIController.EventOnConfirmDefendRule -= this.ArenaDefendUIController_OnConfirmDefendRule;
				this.m_arenaDefendUIController.EventOnShowMyActorInfo -= this.ArenaDefendUIController_OnShowMyActorInfo;
				this.m_arenaDefendUIController.EventOnHideActorInfo -= this.ArenaDefendUIController_OnHideActorInfo;
				this.m_arenaDefendUIController.EventOnStageActorChange -= this.ArenaDefendUIController_OnStageActorChange;
				this.m_arenaDefendUIController.EventOnHeroOnStage -= this.ArenaDefendUIController_OnHeroOnStage;
				this.m_arenaDefendUIController.EventOnActorOffStage -= this.ArenaDefendUIController_OnActorOffStage;
				this.m_arenaDefendUIController.EventOnStageActorMove -= this.ArenaDefendUIController_OnStageActorMove;
				this.m_arenaDefendUIController.EventOnStageActorSwap -= this.ArenaDefendUIController_OnStageActorSwap;
				this.m_arenaDefendUIController.EventOnPointerDown -= this.ArenaDefendUIController_OnPointerDown;
				this.m_arenaDefendUIController.EventOnPointerUp -= this.ArenaDefendUIController_OnPointerUp;
				this.m_arenaDefendUIController.EventOnPointerClick -= this.ArenaDefendUIController_OnPointerClick;
				this.m_arenaDefendUIController = null;
			}
			if (this.m_battlePrepareActorInfoUIController != null)
			{
				this.m_battlePrepareActorInfoUIController.EventOnShowSelectSoldierPanel -= this.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel;
				this.m_battlePrepareActorInfoUIController.EventOnChangeSkill -= this.BattlePrepareActorInfoUIController_OnChangeSkill;
				this.m_battlePrepareActorInfoUIController.EventOnChangeSoldier -= this.BattlePrepareActorInfoUIController_OnChangeSoldier;
				this.m_battlePrepareActorInfoUIController = null;
			}
			if (this.m_arenaDefendMapUIController != null)
			{
				this.m_arenaDefendMapUIController = null;
			}
			if (this.m_arenaDefendSceneUIController != null)
			{
				this.m_arenaDefendSceneUIController.EventOnPointerDown -= this.ArenaDefendSceneUIController_OnPointerDown;
				this.m_arenaDefendSceneUIController.EventOnPointerUp -= this.ArenaDefendSceneUIController_OnPointerUp;
				this.m_arenaDefendSceneUIController.EventOnPointerClick -= this.ArenaDefendSceneUIController_OnPointerClick;
				this.m_arenaDefendSceneUIController.EventOnBeginDrag -= this.ArenaDefendSceneUIController_OnBeginDrag;
				this.m_arenaDefendSceneUIController.EventOnEndDrag -= this.ArenaDefendSceneUIController_OnEndDrag;
				this.m_arenaDefendSceneUIController.EventOnDrag -= this.ArenaDefendSceneUIController_OnDrag;
				this.m_arenaDefendSceneUIController = null;
			}
			if (this.m_arenaDefendBattle != null)
			{
				this.m_arenaDefendBattle.Dispose();
				this.m_arenaDefendBattle = null;
			}
		}

		// Token: 0x06009A3C RID: 39484 RVA: 0x002C0250 File Offset: 0x002BE450
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x002C02B8 File Offset: 0x002BE4B8
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_arenaBattleInfos[this.m_curBattleIndex];
			if (configDataArenaBattleInfo != this.m_arenaDefendBattle.ArenaBattleInfo)
			{
				this.m_arenaDefendBattle.CreateMap(configDataArenaBattleInfo);
			}
			this.SetupStageActors();
			this.m_arenaDefendUIController.SetStageActorCountMax(configDataArenaBattleInfo.DefendNumber);
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x002C0360 File Offset: 0x002BE560
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			float deltaTime = Time.deltaTime;
			if (this.m_arenaDefendBattle != null)
			{
				this.m_arenaDefendBattle.Update(deltaTime);
			}
		}

		// Token: 0x06009A3F RID: 39487 RVA: 0x002C03E4 File Offset: 0x002BE5E4
		private void SetupStageActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupStageActors_hotfix != null)
			{
				this.m_SetupStageActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.ClearHeros();
			this.m_arenaDefendUIController.ClearStageActors();
			this.m_arenaDefendUIController.ClearStagePositions();
			foreach (BattleHero hero in this.m_playerBattleHeros)
			{
				this.m_arenaDefendUIController.AddHero(hero);
			}
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_arenaBattleInfos[this.m_curBattleIndex];
			this.m_attackPositions.Clear();
			this.m_defendPositions.Clear();
			for (int i = 0; i < configDataArenaBattleInfo.AttackPositions.Count; i++)
			{
				ParamPosition paramPosition = configDataArenaBattleInfo.AttackPositions[i];
				GridPosition item = new GridPosition(paramPosition.X, paramPosition.Y);
				this.m_attackPositions.Add(item);
			}
			for (int j = 0; j < configDataArenaBattleInfo.DefendPositions.Count; j++)
			{
				ParamPosition paramPosition2 = configDataArenaBattleInfo.DefendPositions[j];
				GridPosition gridPosition = new GridPosition(paramPosition2.X, paramPosition2.Y);
				int dir = 0;
				if (configDataArenaBattleInfo.DefendDirs.Count > j)
				{
					dir = configDataArenaBattleInfo.DefendDirs[j];
				}
				this.m_arenaDefendUIController.AddStagePosition(gridPosition, dir);
				this.m_defendPositions.Add(gridPosition);
			}
			foreach (BattleHero battleHero in this.m_defendStageHeros)
			{
				ParamPosition paramPosition3 = configDataArenaBattleInfo.DefendPositions[battleHero.ActionPositionIndex];
				GridPosition p = new GridPosition(paramPosition3.X, paramPosition3.Y);
				this.m_arenaDefendUIController.HeroOnStage(battleHero, p);
			}
			this.ShowStagePositions();
			this.m_arenaDefendUIController.CheckStageAtorChange();
			this.UpdateStageHeroActionValues();
		}

		// Token: 0x06009A40 RID: 39488 RVA: 0x002C0648 File Offset: 0x002BE848
		private static int CompareHero(BattleHero h1, BattleHero h2)
		{
			int num = h2.Level - h1.Level;
			if (num != 0)
			{
				return num;
			}
			int num2 = h2.HeroInfo.GetRank(h2.StarLevel) - h1.HeroInfo.GetRank(h1.StarLevel);
			if (num2 != 0)
			{
				return num2;
			}
			return h2.HeroId - h1.HeroId;
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x002C06A4 File Offset: 0x002BE8A4
		private void ShowStagePositions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStagePositions_hotfix != null)
			{
				this.m_ShowStagePositions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendMapUIController.HideStagePositions();
			foreach (GridPosition gridPosition in this.m_defendPositions)
			{
				bool isEmpty = this.m_arenaDefendUIController.GetStageActor(gridPosition) == null;
				this.m_arenaDefendMapUIController.ShowStagePosition(gridPosition, isEmpty);
			}
			foreach (GridPosition pos in this.m_attackPositions)
			{
				this.m_arenaDefendMapUIController.ShowStageAttackerPosition(pos);
			}
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x002C07C8 File Offset: 0x002BE9C8
		private void ClearMapAndActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapAndActors_hotfix != null)
			{
				this.m_ClearMapAndActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaDefendUIController != null)
			{
				this.m_arenaDefendUIController.ClearStageActors();
			}
			if (this.m_arenaDefendBattle != null)
			{
				this.m_arenaDefendBattle.DestroyMap();
			}
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x002C085C File Offset: 0x002BEA5C
		private void ArenaDefendUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnReturn_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curBattleIndex = -1;
			this.m_curDefendRuleIndex = -1;
			this.m_battlePrepareActorInfoUIController.Close();
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				this.ClearMapAndActors();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x002C08F8 File Offset: 0x002BEAF8
		private void ArenaDefendUIController_OnSave()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnSave_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnSave_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaDefendUIController.GetStageActors().Count <= 0)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Arena_NoArenaDefensiveHero, 2f, null, true);
				return;
			}
			this.UpdateStageHeroActionValues();
			List<ArenaPlayerDefensiveHero> list = new List<ArenaPlayerDefensiveHero>();
			foreach (ArenaDefendActor arenaDefendActor in this.m_arenaDefendUIController.GetStageActors())
			{
				BattleHero hero = arenaDefendActor.GetHero();
				list.Add(new ArenaPlayerDefensiveHero
				{
					HeroId = hero.HeroId,
					ActionPositionIndex = this.m_defendPositions.IndexOf(arenaDefendActor.GetPosition()),
					ActionValue = hero.ActionValue
				});
			}
			ArenaPlayerSetDefensiveTeamNetTask arenaPlayerSetDefensiveTeamNetTask = new ArenaPlayerSetDefensiveTeamNetTask(this.m_defendRuleInfos[this.m_curDefendRuleIndex].ID, this.m_arenaBattleInfos[this.m_curBattleIndex].ID, list);
			arenaPlayerSetDefensiveTeamNetTask.EventOnStop += delegate(Task task)
			{
				ArenaPlayerSetDefensiveTeamNetTask arenaPlayerSetDefensiveTeamNetTask2 = task as ArenaPlayerSetDefensiveTeamNetTask;
				if (arenaPlayerSetDefensiveTeamNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(arenaPlayerSetDefensiveTeamNetTask2.Result, 2f, null, true);
				}
				if (arenaPlayerSetDefensiveTeamNetTask2.Result != -99)
				{
					this.ArenaDefendUIController_OnReturn();
				}
			};
			arenaPlayerSetDefensiveTeamNetTask.Start(null);
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x002C0A78 File Offset: 0x002BEC78
		private void ArenaDefendUIController_OnShowActionOrderPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnShowActionOrderPanel_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnShowActionOrderPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareActorInfoUIController.Close();
			List<BattleHero> list = new List<BattleHero>();
			foreach (ArenaDefendActor arenaDefendActor in this.m_arenaDefendUIController.GetStageActors())
			{
				list.Add(arenaDefendActor.GetHero());
			}
			List<BattleHero> list2 = list;
			if (ArenaDefendUITask.<>f__mg$cache1 == null)
			{
				ArenaDefendUITask.<>f__mg$cache1 = new Comparison<BattleHero>(ArenaDefendUITask.CompareHeroActionValue);
			}
			list2.Sort(ArenaDefendUITask.<>f__mg$cache1);
			this.m_arenaDefendUIController.SetHeroActionOrders(list);
			this.m_arenaDefendUIController.ShowActionOrderPanel();
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x002C0B7C File Offset: 0x002BED7C
		private void UpdateStageHeroActionValues()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStageHeroActionValues_hotfix != null)
			{
				this.m_UpdateStageHeroActionValues_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_arenaBattleInfos[this.m_curBattleIndex];
			List<BattleHero> list = new List<BattleHero>();
			foreach (ArenaDefendActor arenaDefendActor in this.m_arenaDefendUIController.GetStageActors())
			{
				list.Add(arenaDefendActor.GetHero());
			}
			List<BattleHero> list2 = list;
			if (ArenaDefendUITask.<>f__mg$cache2 == null)
			{
				ArenaDefendUITask.<>f__mg$cache2 = new Comparison<BattleHero>(ArenaDefendUITask.CompareHeroActionValue);
			}
			list2.Sort(ArenaDefendUITask.<>f__mg$cache2);
			for (int i = 0; i < list.Count; i++)
			{
				list[i].ActionValue = configDataArenaBattleInfo.DefendNumber - i;
			}
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x002C0CA4 File Offset: 0x002BEEA4
		private static int CompareHeroActionValue(BattleHero hero0, BattleHero hero1)
		{
			if (hero0.ActionValue != hero1.ActionValue)
			{
				return hero1.ActionValue - hero0.ActionValue;
			}
			int bf_ActionValue = hero0.GetActiveJob().JobConnectionInfo.m_jobInfo.BF_ActionValue;
			int bf_ActionValue2 = hero1.GetActiveJob().JobConnectionInfo.m_jobInfo.BF_ActionValue;
			if (bf_ActionValue != bf_ActionValue2)
			{
				return bf_ActionValue2 - bf_ActionValue;
			}
			return hero0.HeroId - hero1.HeroId;
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x002C0D14 File Offset: 0x002BEF14
		private void ArenaDefendUIController_OnShowMapPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnShowMapPanel_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnShowMapPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareActorInfoUIController.Close();
			this.m_arenaDefendUIController.ShowMapPanel();
			this.m_arenaDefendUIController.SetMaps(this.m_arenaBattleInfos, this.m_curBattleIndex);
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x002C0DA4 File Offset: 0x002BEFA4
		private void ArenaDefendUIController_OnShowDefendRulePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnShowDefendRulePanel_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnShowDefendRulePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareActorInfoUIController.Close();
			this.m_arenaDefendUIController.ShowDefendRulePanel();
			this.m_arenaDefendUIController.SetDefendRules(this.m_defendRuleInfos, this.m_curDefendRuleIndex);
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x002C0E34 File Offset: 0x002BF034
		private void ArenaDefendUIController_OnConfirmActionOrder()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnConfirmActionOrder_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnConfirmActionOrder_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = this.m_arenaBattleInfos[this.m_curBattleIndex];
			foreach (ArenaDefendActor arenaDefendActor in this.m_arenaDefendUIController.GetStageActors())
			{
				BattleHero hero = arenaDefendActor.GetHero();
				hero.ActionValue = configDataArenaBattleInfo.DefendNumber - this.m_arenaDefendUIController.GetHeroActionOrderIndex(hero);
			}
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x002C0F14 File Offset: 0x002BF114
		private void ArenaDefendUIController_OnConfirmMap(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnConfirmMapInt32_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnConfirmMapInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curBattleIndex != index)
			{
				this.m_curBattleIndex = index;
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x002C0FA4 File Offset: 0x002BF1A4
		private void ArenaDefendUIController_OnConfirmDefendRule(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnConfirmDefendRuleInt32_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnConfirmDefendRuleInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curDefendRuleIndex != index)
			{
				this.m_curDefendRuleIndex = index;
			}
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x002C1028 File Offset: 0x002BF228
		private void ArenaDefendUIController_OnShowMyActorInfo(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnShowMyActorInfoBattleHero_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnShowMyActorInfoBattleHero_hotfix.call(new object[]
				{
					this,
					hero2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero2;
			ArenaDefendUITask $this = this;
			base.ClearAssetList();
			this.CollectHeadImageAssets(hero.HeroInfo.GetCharImageInfo(hero.StarLevel));
			base.CollectAsset(UIUtility.GetSelectedSoldierModelAssetPath(hero, 0));
			base.StartLoadCustomAssets(delegate
			{
				$this.m_battlePrepareActorInfoUIController.SetActorInfo(hero, $this.m_trainingTechs, 0, false, true, null, -1, -1);
				$this.m_battlePrepareActorInfoUIController.Open(false);
			});
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x002C10F8 File Offset: 0x002BF2F8
		private void ArenaDefendUIController_OnHideActorInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnHideActorInfo_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnHideActorInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battlePrepareActorInfoUIController.Close();
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x002C1164 File Offset: 0x002BF364
		private void ArenaDefendUIController_OnStageActorChange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnStageActorChange_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnStageActorChange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateBattlePower();
			this.ShowStagePositions();
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x002C11D0 File Offset: 0x002BF3D0
		private void UpdateBattlePower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBattlePower_hotfix != null)
			{
				this.m_UpdateBattlePower_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = 0;
			foreach (ArenaDefendActor arenaDefendActor in this.m_arenaDefendUIController.GetStageActors())
			{
				num += projectLPlayerContext.ComputeBattlePower(arenaDefendActor.GetHero(), this.m_trainingTechs);
			}
			this.m_arenaDefendUIController.SetBattlePower(num);
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x002C12B0 File Offset: 0x002BF4B0
		private void ArenaDefendUIController_OnHeroOnStage(BattleHero hero, GridPosition pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnHeroOnStageBattleHeroGridPosition_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnHeroOnStageBattleHeroGridPosition_hotfix.call(new object[]
				{
					this,
					hero2,
					pos2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero2;
			GridPosition pos = pos2;
			ArenaDefendUITask $this = this;
			base.ClearAssetList();
			this.CollectHeroAndSoldierModelAssets(hero);
			base.StartLoadCustomAssets(delegate
			{
				$this.m_arenaDefendUIController.HeroOnStage(hero, pos);
				$this.UpdateStageHeroActionValues();
				$this.m_arenaDefendMapUIController.PlayOnStageFx(pos);
				AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
			});
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x002C1370 File Offset: 0x002BF570
		private void ArenaDefendUIController_OnActorOffStage(ArenaDefendActor sa)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnActorOffStageArenaDefendActor_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnActorOffStageArenaDefendActor_hotfix.call(new object[]
				{
					this,
					sa
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.ActorOffStage(sa);
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x002C13EC File Offset: 0x002BF5EC
		private void ArenaDefendUIController_OnStageActorMove(ArenaDefendActor sa, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnStageActorMoveArenaDefendActorGridPosition_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnStageActorMoveArenaDefendActorGridPosition_hotfix.call(new object[]
				{
					this,
					sa,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.ActorOnStageMove(sa, p);
			this.m_arenaDefendMapUIController.PlayOnStageFx(p);
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x002C148C File Offset: 0x002BF68C
		private void ArenaDefendUIController_OnStageActorSwap(ArenaDefendActor sa1, ArenaDefendActor sa2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnStageActorSwapArenaDefendActorArenaDefendActor_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnStageActorSwapArenaDefendActorArenaDefendActor_hotfix.call(new object[]
				{
					this,
					sa1,
					sa2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.ActorOnStageExchange(sa1, sa2);
			this.m_arenaDefendMapUIController.PlayOnStageFx(sa1.GetPosition());
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x002C1530 File Offset: 0x002BF730
		private void ArenaDefendUIController_OnPointerDown(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnPointerDownInputButtonVector2_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnPointerDownInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GridPosition p = this.m_arenaDefendBattle.ScreenPositionToGridPosition(position);
			ArenaDefendActor stageActor = this.m_arenaDefendUIController.GetStageActor(p);
			if (stageActor != null)
			{
				this.m_arenaDefendBattle.Camera.EnableTouchMove(false);
			}
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x002C15E4 File Offset: 0x002BF7E4
		private void ArenaDefendUIController_OnPointerUp(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnPointerUpInputButtonVector2_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnPointerUpInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendBattle.Camera.EnableTouchMove(true);
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x002C1678 File Offset: 0x002BF878
		private void ArenaDefendUIController_OnPointerClick(PointerEventData.InputButton button, Vector2 position)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendUIController_OnPointerClickInputButtonVector2_hotfix != null)
			{
				this.m_ArenaDefendUIController_OnPointerClickInputButtonVector2_hotfix.call(new object[]
				{
					this,
					button,
					position2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 position = position2;
			ArenaDefendUITask $this = this;
			GridPosition p = this.m_arenaDefendBattle.ScreenPositionToGridPosition(position);
			ArenaDefendActor stageActor = this.m_arenaDefendUIController.GetStageActor(p);
			if (stageActor != null)
			{
				BattleHero hero = stageActor.GetHero();
				base.ClearAssetList();
				this.CollectHeadImageAssets(hero.HeroInfo.GetCharImageInfo(hero.StarLevel));
				base.StartLoadCustomAssets(delegate
				{
					$this.m_battlePrepareActorInfoUIController.SetActorInfo(hero, $this.m_trainingTechs, 0, false, true, null, -1, -1);
					$this.m_battlePrepareActorInfoUIController.Open(position.x > (float)Screen.width * 0.5f);
				});
			}
			else
			{
				this.m_battlePrepareActorInfoUIController.Close();
			}
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x002C1794 File Offset: 0x002BF994
		private void BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix != null)
			{
				this.m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Hero hero2 = projectLPlayerContext.GetHero(hero.HeroId);
			if (hero2 == null)
			{
				return;
			}
			base.ClearAssetList();
			foreach (int soldierId in hero2.SoldierIds)
			{
				base.CollectAsset(UIUtility.GetSoldierModelAssetPath(hero2, soldierId));
			}
			base.StartLoadCustomAssets(delegate
			{
				this.m_battlePrepareActorInfoUIController.ShowSelectSoldierPanel();
			});
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x002C1898 File Offset: 0x002BFA98
		private void BattlePrepareActorInfoUIController_OnChangeSkill(BattleHero hero, List<int> skillIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList`1_hotfix != null)
			{
				this.m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList`1_hotfix.call(new object[]
				{
					this,
					hero,
					skillIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x002C1918 File Offset: 0x002BFB18
		private void BattlePrepareActorInfoUIController_OnChangeSoldier(BattleHero hero, int soldierId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix != null)
			{
				this.m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix.call(new object[]
				{
					this,
					hero3,
					soldierId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = hero3;
			ArenaDefendUITask $this = this;
			HeroSoldierSelectNetTask heroSoldierSelectNetTask = new HeroSoldierSelectNetTask(hero.HeroId, soldierId);
			heroSoldierSelectNetTask.EventOnStop += delegate(Task task)
			{
				HeroSoldierSelectNetTask heroSoldierSelectNetTask2 = task as HeroSoldierSelectNetTask;
				if (heroSoldierSelectNetTask2.Result == 0)
				{
					ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					Hero hero2 = projectLPlayerContext.GetHero(hero.HeroId);
					if (hero2 != null)
					{
						hero.SelectedSoldierId = hero2.SelectedSoldierId;
						hero.SelectedSoldierSkinId = hero2.GetSoldierSkinId(hero2.SelectedSoldierId);
						$this.m_battlePrepareActorInfoUIController.SetSoldier();
						$this.m_arenaDefendUIController.UpdateStageActor(hero);
						$this.UpdateBattlePower();
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroSoldierSelectNetTask2.Result, 2f, null, true);
				}
			};
			heroSoldierSelectNetTask.Start(null);
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x002C19D8 File Offset: 0x002BFBD8
		private void ArenaDefendSceneUIController_OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendSceneUIController_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_ArenaDefendSceneUIController_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.OnScenePointerDown(eventData);
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x002C1A54 File Offset: 0x002BFC54
		private void ArenaDefendSceneUIController_OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendSceneUIController_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_ArenaDefendSceneUIController_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.OnScenePointerUp(eventData);
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x002C1AD0 File Offset: 0x002BFCD0
		private void ArenaDefendSceneUIController_OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendSceneUIController_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_ArenaDefendSceneUIController_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.OnScenePointerClick(eventData);
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x002C1B4C File Offset: 0x002BFD4C
		private void ArenaDefendSceneUIController_OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendSceneUIController_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_ArenaDefendSceneUIController_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.OnSceneBeginDrag(eventData);
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x002C1BC8 File Offset: 0x002BFDC8
		private void ArenaDefendSceneUIController_OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendSceneUIController_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_ArenaDefendSceneUIController_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.OnSceneEndDrag(eventData);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x002C1C44 File Offset: 0x002BFE44
		private void ArenaDefendSceneUIController_OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaDefendSceneUIController_OnDragPointerEventData_hotfix != null)
			{
				this.m_ArenaDefendSceneUIController_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaDefendUIController.OnSceneDrag(eventData);
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06009A61 RID: 39521 RVA: 0x002C1CC0 File Offset: 0x002BFEC0
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06009A62 RID: 39522 RVA: 0x002C1D34 File Offset: 0x002BFF34
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06009A63 RID: 39523 RVA: 0x002C1DA8 File Offset: 0x002BFFA8
		// (set) Token: 0x06009A64 RID: 39524 RVA: 0x002C1DC8 File Offset: 0x002BFFC8
		[DoNotToLua]
		public new ArenaDefendUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x002C1DD4 File Offset: 0x002BFFD4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x002C1DE0 File Offset: 0x002BFFE0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x002C1DE8 File Offset: 0x002BFFE8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x002C1DF0 File Offset: 0x002BFFF0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x002C1DFC File Offset: 0x002BFFFC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x002C1E08 File Offset: 0x002C0008
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x002C1E14 File Offset: 0x002C0014
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x002C1E1C File Offset: 0x002C001C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x002C1E24 File Offset: 0x002C0024
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x002C1E2C File Offset: 0x002C002C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x002C1E34 File Offset: 0x002C0034
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x002C1E3C File Offset: 0x002C003C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x002C1E44 File Offset: 0x002C0044
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x002C1E4C File Offset: 0x002C004C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x002C1E58 File Offset: 0x002C0058
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x002C1E64 File Offset: 0x002C0064
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x002C1E70 File Offset: 0x002C0070
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x002C1E7C File Offset: 0x002C007C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x002C1E84 File Offset: 0x002C0084
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x002C1E8C File Offset: 0x002C008C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x002C1E94 File Offset: 0x002C0094
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x002C1E9C File Offset: 0x002C009C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x002C1EA4 File Offset: 0x002C00A4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x002C1F2C File Offset: 0x002C012C
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix = (luaObj.RawGet("CollectBattlefieldAssets") as LuaFunction);
					this.m_CollectHeroAndSoldierModelAssetsBattleHero_hotfix = (luaObj.RawGet("CollectHeroAndSoldierModelAssets") as LuaFunction);
					this.m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix = (luaObj.RawGet("CollectHeadImageAssets") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitArenaDefendUIController_hotfix = (luaObj.RawGet("InitArenaDefendUIController") as LuaFunction);
					this.m_UninitArenaDefendUIController_hotfix = (luaObj.RawGet("UninitArenaDefendUIController") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_SetupStageActors_hotfix = (luaObj.RawGet("SetupStageActors") as LuaFunction);
					this.m_ShowStagePositions_hotfix = (luaObj.RawGet("ShowStagePositions") as LuaFunction);
					this.m_ClearMapAndActors_hotfix = (luaObj.RawGet("ClearMapAndActors") as LuaFunction);
					this.m_ArenaDefendUIController_OnReturn_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnReturn") as LuaFunction);
					this.m_ArenaDefendUIController_OnSave_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnSave") as LuaFunction);
					this.m_ArenaDefendUIController_OnShowActionOrderPanel_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnShowActionOrderPanel") as LuaFunction);
					this.m_UpdateStageHeroActionValues_hotfix = (luaObj.RawGet("UpdateStageHeroActionValues") as LuaFunction);
					this.m_ArenaDefendUIController_OnShowMapPanel_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnShowMapPanel") as LuaFunction);
					this.m_ArenaDefendUIController_OnShowDefendRulePanel_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnShowDefendRulePanel") as LuaFunction);
					this.m_ArenaDefendUIController_OnConfirmActionOrder_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnConfirmActionOrder") as LuaFunction);
					this.m_ArenaDefendUIController_OnConfirmMapInt32_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnConfirmMap") as LuaFunction);
					this.m_ArenaDefendUIController_OnConfirmDefendRuleInt32_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnConfirmDefendRule") as LuaFunction);
					this.m_ArenaDefendUIController_OnShowMyActorInfoBattleHero_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnShowMyActorInfo") as LuaFunction);
					this.m_ArenaDefendUIController_OnHideActorInfo_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnHideActorInfo") as LuaFunction);
					this.m_ArenaDefendUIController_OnStageActorChange_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnStageActorChange") as LuaFunction);
					this.m_UpdateBattlePower_hotfix = (luaObj.RawGet("UpdateBattlePower") as LuaFunction);
					this.m_ArenaDefendUIController_OnHeroOnStageBattleHeroGridPosition_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnHeroOnStage") as LuaFunction);
					this.m_ArenaDefendUIController_OnActorOffStageArenaDefendActor_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnActorOffStage") as LuaFunction);
					this.m_ArenaDefendUIController_OnStageActorMoveArenaDefendActorGridPosition_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnStageActorMove") as LuaFunction);
					this.m_ArenaDefendUIController_OnStageActorSwapArenaDefendActorArenaDefendActor_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnStageActorSwap") as LuaFunction);
					this.m_ArenaDefendUIController_OnPointerDownInputButtonVector2_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnPointerDown") as LuaFunction);
					this.m_ArenaDefendUIController_OnPointerUpInputButtonVector2_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnPointerUp") as LuaFunction);
					this.m_ArenaDefendUIController_OnPointerClickInputButtonVector2_hotfix = (luaObj.RawGet("ArenaDefendUIController_OnPointerClick") as LuaFunction);
					this.m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix = (luaObj.RawGet("BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel") as LuaFunction);
					this.m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList`1_hotfix = (luaObj.RawGet("BattlePrepareActorInfoUIController_OnChangeSkill") as LuaFunction);
					this.m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix = (luaObj.RawGet("BattlePrepareActorInfoUIController_OnChangeSoldier") as LuaFunction);
					this.m_ArenaDefendSceneUIController_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("ArenaDefendSceneUIController_OnPointerDown") as LuaFunction);
					this.m_ArenaDefendSceneUIController_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("ArenaDefendSceneUIController_OnPointerUp") as LuaFunction);
					this.m_ArenaDefendSceneUIController_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("ArenaDefendSceneUIController_OnPointerClick") as LuaFunction);
					this.m_ArenaDefendSceneUIController_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("ArenaDefendSceneUIController_OnBeginDrag") as LuaFunction);
					this.m_ArenaDefendSceneUIController_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("ArenaDefendSceneUIController_OnEndDrag") as LuaFunction);
					this.m_ArenaDefendSceneUIController_OnDragPointerEventData_hotfix = (luaObj.RawGet("ArenaDefendSceneUIController_OnDrag") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x002C2478 File Offset: 0x002C0678
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006964 RID: 26980
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ArenaDefendSceneLayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Arena_ABS/Prefab/ArenaDefendScenePrefab.prefab",
				m_isUILayer = false
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ArenaDefendUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Arena_ABS/Prefab/ArenaDefendUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "ArenaDefendActorInfoUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattlePrepareActorInfoUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006965 RID: 26981
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ArenaDefendUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ArenaDefendUIController"),
				m_ctrlName = "ArenaDefendUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ArenaDefendActorInfoUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattlePrepareActorInfoUIController"),
				m_ctrlName = "BattlePrepareActorInfoUIController"
			}
		};

		// Token: 0x04006966 RID: 26982
		private ArenaDefendUIController m_arenaDefendUIController;

		// Token: 0x04006967 RID: 26983
		private ArenaDefendMapUIController m_arenaDefendMapUIController;

		// Token: 0x04006968 RID: 26984
		private ArenaDefendSceneUIController m_arenaDefendSceneUIController;

		// Token: 0x04006969 RID: 26985
		private BattlePrepareActorInfoUIController m_battlePrepareActorInfoUIController;

		// Token: 0x0400696A RID: 26986
		private ArenaDefendBattle m_arenaDefendBattle;

		// Token: 0x0400696B RID: 26987
		private List<GridPosition> m_defendPositions = new List<GridPosition>();

		// Token: 0x0400696C RID: 26988
		private List<GridPosition> m_attackPositions = new List<GridPosition>();

		// Token: 0x0400696D RID: 26989
		private List<ConfigDataArenaBattleInfo> m_arenaBattleInfos = new List<ConfigDataArenaBattleInfo>();

		// Token: 0x0400696E RID: 26990
		private List<ConfigDataArenaDefendRuleInfo> m_defendRuleInfos = new List<ConfigDataArenaDefendRuleInfo>();

		// Token: 0x0400696F RID: 26991
		private List<BattleHero> m_playerBattleHeros = new List<BattleHero>();

		// Token: 0x04006970 RID: 26992
		private List<BattleHero> m_defendStageHeros = new List<BattleHero>();

		// Token: 0x04006971 RID: 26993
		private List<TrainingTech> m_trainingTechs = new List<TrainingTech>();

		// Token: 0x04006972 RID: 26994
		private int m_curBattleIndex = -1;

		// Token: 0x04006973 RID: 26995
		private int m_curDefendRuleIndex = -1;

		// Token: 0x04006974 RID: 26996
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04006975 RID: 26997
		[DoNotToLua]
		private ArenaDefendUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006976 RID: 26998
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache0;

		// Token: 0x04006977 RID: 26999
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache1;

		// Token: 0x04006978 RID: 27000
		[CompilerGenerated]
		private static Comparison<BattleHero> <>f__mg$cache2;

		// Token: 0x04006979 RID: 27001
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400697A RID: 27002
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400697B RID: 27003
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400697C RID: 27004
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400697D RID: 27005
		private LuaFunction m_CollectBattlefieldAssetsConfigDataBattlefieldInfo_hotfix;

		// Token: 0x0400697E RID: 27006
		private LuaFunction m_CollectHeroAndSoldierModelAssetsBattleHero_hotfix;

		// Token: 0x0400697F RID: 27007
		private LuaFunction m_CollectHeadImageAssetsConfigDataCharImageInfo_hotfix;

		// Token: 0x04006980 RID: 27008
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x04006981 RID: 27009
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006982 RID: 27010
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006983 RID: 27011
		private LuaFunction m_InitArenaDefendUIController_hotfix;

		// Token: 0x04006984 RID: 27012
		private LuaFunction m_UninitArenaDefendUIController_hotfix;

		// Token: 0x04006985 RID: 27013
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04006986 RID: 27014
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006987 RID: 27015
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04006988 RID: 27016
		private LuaFunction m_SetupStageActors_hotfix;

		// Token: 0x04006989 RID: 27017
		private LuaFunction m_ShowStagePositions_hotfix;

		// Token: 0x0400698A RID: 27018
		private LuaFunction m_ClearMapAndActors_hotfix;

		// Token: 0x0400698B RID: 27019
		private LuaFunction m_ArenaDefendUIController_OnReturn_hotfix;

		// Token: 0x0400698C RID: 27020
		private LuaFunction m_ArenaDefendUIController_OnSave_hotfix;

		// Token: 0x0400698D RID: 27021
		private LuaFunction m_ArenaDefendUIController_OnShowActionOrderPanel_hotfix;

		// Token: 0x0400698E RID: 27022
		private LuaFunction m_UpdateStageHeroActionValues_hotfix;

		// Token: 0x0400698F RID: 27023
		private LuaFunction m_ArenaDefendUIController_OnShowMapPanel_hotfix;

		// Token: 0x04006990 RID: 27024
		private LuaFunction m_ArenaDefendUIController_OnShowDefendRulePanel_hotfix;

		// Token: 0x04006991 RID: 27025
		private LuaFunction m_ArenaDefendUIController_OnConfirmActionOrder_hotfix;

		// Token: 0x04006992 RID: 27026
		private LuaFunction m_ArenaDefendUIController_OnConfirmMapInt32_hotfix;

		// Token: 0x04006993 RID: 27027
		private LuaFunction m_ArenaDefendUIController_OnConfirmDefendRuleInt32_hotfix;

		// Token: 0x04006994 RID: 27028
		private LuaFunction m_ArenaDefendUIController_OnShowMyActorInfoBattleHero_hotfix;

		// Token: 0x04006995 RID: 27029
		private LuaFunction m_ArenaDefendUIController_OnHideActorInfo_hotfix;

		// Token: 0x04006996 RID: 27030
		private LuaFunction m_ArenaDefendUIController_OnStageActorChange_hotfix;

		// Token: 0x04006997 RID: 27031
		private LuaFunction m_UpdateBattlePower_hotfix;

		// Token: 0x04006998 RID: 27032
		private LuaFunction m_ArenaDefendUIController_OnHeroOnStageBattleHeroGridPosition_hotfix;

		// Token: 0x04006999 RID: 27033
		private LuaFunction m_ArenaDefendUIController_OnActorOffStageArenaDefendActor_hotfix;

		// Token: 0x0400699A RID: 27034
		private LuaFunction m_ArenaDefendUIController_OnStageActorMoveArenaDefendActorGridPosition_hotfix;

		// Token: 0x0400699B RID: 27035
		private LuaFunction m_ArenaDefendUIController_OnStageActorSwapArenaDefendActorArenaDefendActor_hotfix;

		// Token: 0x0400699C RID: 27036
		private LuaFunction m_ArenaDefendUIController_OnPointerDownInputButtonVector2_hotfix;

		// Token: 0x0400699D RID: 27037
		private LuaFunction m_ArenaDefendUIController_OnPointerUpInputButtonVector2_hotfix;

		// Token: 0x0400699E RID: 27038
		private LuaFunction m_ArenaDefendUIController_OnPointerClickInputButtonVector2_hotfix;

		// Token: 0x0400699F RID: 27039
		private LuaFunction m_BattlePrepareActorInfoUIController_OnShowSelectSoldierPanelBattleHero_hotfix;

		// Token: 0x040069A0 RID: 27040
		private LuaFunction m_BattlePrepareActorInfoUIController_OnChangeSkillBattleHeroList;

		// Token: 0x040069A1 RID: 27041
		private LuaFunction m_BattlePrepareActorInfoUIController_OnChangeSoldierBattleHeroInt32_hotfix;

		// Token: 0x040069A2 RID: 27042
		private LuaFunction m_ArenaDefendSceneUIController_OnPointerDownPointerEventData_hotfix;

		// Token: 0x040069A3 RID: 27043
		private LuaFunction m_ArenaDefendSceneUIController_OnPointerUpPointerEventData_hotfix;

		// Token: 0x040069A4 RID: 27044
		private LuaFunction m_ArenaDefendSceneUIController_OnPointerClickPointerEventData_hotfix;

		// Token: 0x040069A5 RID: 27045
		private LuaFunction m_ArenaDefendSceneUIController_OnBeginDragPointerEventData_hotfix;

		// Token: 0x040069A6 RID: 27046
		private LuaFunction m_ArenaDefendSceneUIController_OnEndDragPointerEventData_hotfix;

		// Token: 0x040069A7 RID: 27047
		private LuaFunction m_ArenaDefendSceneUIController_OnDragPointerEventData_hotfix;

		// Token: 0x040069A8 RID: 27048
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040069A9 RID: 27049
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000A05 RID: 2565
		public new class LuaExportHelper
		{
			// Token: 0x06009A81 RID: 39553 RVA: 0x002C24E0 File Offset: 0x002C06E0
			public LuaExportHelper(ArenaDefendUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009A82 RID: 39554 RVA: 0x002C24F0 File Offset: 0x002C06F0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06009A83 RID: 39555 RVA: 0x002C2500 File Offset: 0x002C0700
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06009A84 RID: 39556 RVA: 0x002C2510 File Offset: 0x002C0710
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06009A85 RID: 39557 RVA: 0x002C2520 File Offset: 0x002C0720
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06009A86 RID: 39558 RVA: 0x002C2530 File Offset: 0x002C0730
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06009A87 RID: 39559 RVA: 0x002C2540 File Offset: 0x002C0740
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06009A88 RID: 39560 RVA: 0x002C2550 File Offset: 0x002C0750
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06009A89 RID: 39561 RVA: 0x002C2560 File Offset: 0x002C0760
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06009A8A RID: 39562 RVA: 0x002C2570 File Offset: 0x002C0770
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06009A8B RID: 39563 RVA: 0x002C2580 File Offset: 0x002C0780
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06009A8C RID: 39564 RVA: 0x002C2590 File Offset: 0x002C0790
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06009A8D RID: 39565 RVA: 0x002C25A0 File Offset: 0x002C07A0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06009A8E RID: 39566 RVA: 0x002C25B0 File Offset: 0x002C07B0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06009A8F RID: 39567 RVA: 0x002C25C0 File Offset: 0x002C07C0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06009A90 RID: 39568 RVA: 0x002C25D0 File Offset: 0x002C07D0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06009A91 RID: 39569 RVA: 0x002C25E0 File Offset: 0x002C07E0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06009A92 RID: 39570 RVA: 0x002C25F0 File Offset: 0x002C07F0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06009A93 RID: 39571 RVA: 0x002C2600 File Offset: 0x002C0800
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06009A94 RID: 39572 RVA: 0x002C2610 File Offset: 0x002C0810
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06009A95 RID: 39573 RVA: 0x002C2620 File Offset: 0x002C0820
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06009A96 RID: 39574 RVA: 0x002C2630 File Offset: 0x002C0830
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06009A97 RID: 39575 RVA: 0x002C2640 File Offset: 0x002C0840
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06009A98 RID: 39576 RVA: 0x002C2650 File Offset: 0x002C0850
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17001F8F RID: 8079
			// (get) Token: 0x06009A99 RID: 39577 RVA: 0x002C2660 File Offset: 0x002C0860
			// (set) Token: 0x06009A9A RID: 39578 RVA: 0x002C2670 File Offset: 0x002C0870
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17001F90 RID: 8080
			// (get) Token: 0x06009A9B RID: 39579 RVA: 0x002C2680 File Offset: 0x002C0880
			// (set) Token: 0x06009A9C RID: 39580 RVA: 0x002C2690 File Offset: 0x002C0890
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17001F91 RID: 8081
			// (get) Token: 0x06009A9D RID: 39581 RVA: 0x002C26A0 File Offset: 0x002C08A0
			// (set) Token: 0x06009A9E RID: 39582 RVA: 0x002C26B0 File Offset: 0x002C08B0
			public ArenaDefendUIController m_arenaDefendUIController
			{
				get
				{
					return this.m_owner.m_arenaDefendUIController;
				}
				set
				{
					this.m_owner.m_arenaDefendUIController = value;
				}
			}

			// Token: 0x17001F92 RID: 8082
			// (get) Token: 0x06009A9F RID: 39583 RVA: 0x002C26C0 File Offset: 0x002C08C0
			// (set) Token: 0x06009AA0 RID: 39584 RVA: 0x002C26D0 File Offset: 0x002C08D0
			public ArenaDefendMapUIController m_arenaDefendMapUIController
			{
				get
				{
					return this.m_owner.m_arenaDefendMapUIController;
				}
				set
				{
					this.m_owner.m_arenaDefendMapUIController = value;
				}
			}

			// Token: 0x17001F93 RID: 8083
			// (get) Token: 0x06009AA1 RID: 39585 RVA: 0x002C26E0 File Offset: 0x002C08E0
			// (set) Token: 0x06009AA2 RID: 39586 RVA: 0x002C26F0 File Offset: 0x002C08F0
			public ArenaDefendSceneUIController m_arenaDefendSceneUIController
			{
				get
				{
					return this.m_owner.m_arenaDefendSceneUIController;
				}
				set
				{
					this.m_owner.m_arenaDefendSceneUIController = value;
				}
			}

			// Token: 0x17001F94 RID: 8084
			// (get) Token: 0x06009AA3 RID: 39587 RVA: 0x002C2700 File Offset: 0x002C0900
			// (set) Token: 0x06009AA4 RID: 39588 RVA: 0x002C2710 File Offset: 0x002C0910
			public BattlePrepareActorInfoUIController m_battlePrepareActorInfoUIController
			{
				get
				{
					return this.m_owner.m_battlePrepareActorInfoUIController;
				}
				set
				{
					this.m_owner.m_battlePrepareActorInfoUIController = value;
				}
			}

			// Token: 0x17001F95 RID: 8085
			// (get) Token: 0x06009AA5 RID: 39589 RVA: 0x002C2720 File Offset: 0x002C0920
			// (set) Token: 0x06009AA6 RID: 39590 RVA: 0x002C2730 File Offset: 0x002C0930
			public ArenaDefendBattle m_arenaDefendBattle
			{
				get
				{
					return this.m_owner.m_arenaDefendBattle;
				}
				set
				{
					this.m_owner.m_arenaDefendBattle = value;
				}
			}

			// Token: 0x17001F96 RID: 8086
			// (get) Token: 0x06009AA7 RID: 39591 RVA: 0x002C2740 File Offset: 0x002C0940
			// (set) Token: 0x06009AA8 RID: 39592 RVA: 0x002C2750 File Offset: 0x002C0950
			public List<GridPosition> m_defendPositions
			{
				get
				{
					return this.m_owner.m_defendPositions;
				}
				set
				{
					this.m_owner.m_defendPositions = value;
				}
			}

			// Token: 0x17001F97 RID: 8087
			// (get) Token: 0x06009AA9 RID: 39593 RVA: 0x002C2760 File Offset: 0x002C0960
			// (set) Token: 0x06009AAA RID: 39594 RVA: 0x002C2770 File Offset: 0x002C0970
			public List<GridPosition> m_attackPositions
			{
				get
				{
					return this.m_owner.m_attackPositions;
				}
				set
				{
					this.m_owner.m_attackPositions = value;
				}
			}

			// Token: 0x17001F98 RID: 8088
			// (get) Token: 0x06009AAB RID: 39595 RVA: 0x002C2780 File Offset: 0x002C0980
			// (set) Token: 0x06009AAC RID: 39596 RVA: 0x002C2790 File Offset: 0x002C0990
			public List<ConfigDataArenaBattleInfo> m_arenaBattleInfos
			{
				get
				{
					return this.m_owner.m_arenaBattleInfos;
				}
				set
				{
					this.m_owner.m_arenaBattleInfos = value;
				}
			}

			// Token: 0x17001F99 RID: 8089
			// (get) Token: 0x06009AAD RID: 39597 RVA: 0x002C27A0 File Offset: 0x002C09A0
			// (set) Token: 0x06009AAE RID: 39598 RVA: 0x002C27B0 File Offset: 0x002C09B0
			public List<ConfigDataArenaDefendRuleInfo> m_defendRuleInfos
			{
				get
				{
					return this.m_owner.m_defendRuleInfos;
				}
				set
				{
					this.m_owner.m_defendRuleInfos = value;
				}
			}

			// Token: 0x17001F9A RID: 8090
			// (get) Token: 0x06009AAF RID: 39599 RVA: 0x002C27C0 File Offset: 0x002C09C0
			// (set) Token: 0x06009AB0 RID: 39600 RVA: 0x002C27D0 File Offset: 0x002C09D0
			public List<BattleHero> m_playerBattleHeros
			{
				get
				{
					return this.m_owner.m_playerBattleHeros;
				}
				set
				{
					this.m_owner.m_playerBattleHeros = value;
				}
			}

			// Token: 0x17001F9B RID: 8091
			// (get) Token: 0x06009AB1 RID: 39601 RVA: 0x002C27E0 File Offset: 0x002C09E0
			// (set) Token: 0x06009AB2 RID: 39602 RVA: 0x002C27F0 File Offset: 0x002C09F0
			public List<BattleHero> m_defendStageHeros
			{
				get
				{
					return this.m_owner.m_defendStageHeros;
				}
				set
				{
					this.m_owner.m_defendStageHeros = value;
				}
			}

			// Token: 0x17001F9C RID: 8092
			// (get) Token: 0x06009AB3 RID: 39603 RVA: 0x002C2800 File Offset: 0x002C0A00
			// (set) Token: 0x06009AB4 RID: 39604 RVA: 0x002C2810 File Offset: 0x002C0A10
			public List<TrainingTech> m_trainingTechs
			{
				get
				{
					return this.m_owner.m_trainingTechs;
				}
				set
				{
					this.m_owner.m_trainingTechs = value;
				}
			}

			// Token: 0x17001F9D RID: 8093
			// (get) Token: 0x06009AB5 RID: 39605 RVA: 0x002C2820 File Offset: 0x002C0A20
			// (set) Token: 0x06009AB6 RID: 39606 RVA: 0x002C2830 File Offset: 0x002C0A30
			public int m_curBattleIndex
			{
				get
				{
					return this.m_owner.m_curBattleIndex;
				}
				set
				{
					this.m_owner.m_curBattleIndex = value;
				}
			}

			// Token: 0x17001F9E RID: 8094
			// (get) Token: 0x06009AB7 RID: 39607 RVA: 0x002C2840 File Offset: 0x002C0A40
			// (set) Token: 0x06009AB8 RID: 39608 RVA: 0x002C2850 File Offset: 0x002C0A50
			public int m_curDefendRuleIndex
			{
				get
				{
					return this.m_owner.m_curDefendRuleIndex;
				}
				set
				{
					this.m_owner.m_curDefendRuleIndex = value;
				}
			}

			// Token: 0x17001F9F RID: 8095
			// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x002C2860 File Offset: 0x002C0A60
			// (set) Token: 0x06009ABA RID: 39610 RVA: 0x002C2870 File Offset: 0x002C0A70
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17001FA0 RID: 8096
			// (get) Token: 0x06009ABB RID: 39611 RVA: 0x002C2880 File Offset: 0x002C0A80
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001FA1 RID: 8097
			// (get) Token: 0x06009ABC RID: 39612 RVA: 0x002C2890 File Offset: 0x002C0A90
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06009ABD RID: 39613 RVA: 0x002C28A0 File Offset: 0x002C0AA0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06009ABE RID: 39614 RVA: 0x002C28B0 File Offset: 0x002C0AB0
			public void CollectBattlefieldAssets(ConfigDataBattlefieldInfo battlefieldInfo)
			{
				this.m_owner.CollectBattlefieldAssets(battlefieldInfo);
			}

			// Token: 0x06009ABF RID: 39615 RVA: 0x002C28C0 File Offset: 0x002C0AC0
			public void CollectHeroAndSoldierModelAssets(BattleHero hero)
			{
				this.m_owner.CollectHeroAndSoldierModelAssets(hero);
			}

			// Token: 0x06009AC0 RID: 39616 RVA: 0x002C28D0 File Offset: 0x002C0AD0
			public void CollectHeadImageAssets(ConfigDataCharImageInfo charImageInfo)
			{
				this.m_owner.CollectHeadImageAssets(charImageInfo);
			}

			// Token: 0x06009AC1 RID: 39617 RVA: 0x002C28E0 File Offset: 0x002C0AE0
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06009AC2 RID: 39618 RVA: 0x002C28F0 File Offset: 0x002C0AF0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06009AC3 RID: 39619 RVA: 0x002C2900 File Offset: 0x002C0B00
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06009AC4 RID: 39620 RVA: 0x002C2910 File Offset: 0x002C0B10
			public void InitArenaDefendUIController()
			{
				this.m_owner.InitArenaDefendUIController();
			}

			// Token: 0x06009AC5 RID: 39621 RVA: 0x002C2920 File Offset: 0x002C0B20
			public void UninitArenaDefendUIController()
			{
				this.m_owner.UninitArenaDefendUIController();
			}

			// Token: 0x06009AC6 RID: 39622 RVA: 0x002C2930 File Offset: 0x002C0B30
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06009AC7 RID: 39623 RVA: 0x002C2940 File Offset: 0x002C0B40
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06009AC8 RID: 39624 RVA: 0x002C2950 File Offset: 0x002C0B50
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06009AC9 RID: 39625 RVA: 0x002C2960 File Offset: 0x002C0B60
			public void SetupStageActors()
			{
				this.m_owner.SetupStageActors();
			}

			// Token: 0x06009ACA RID: 39626 RVA: 0x002C2970 File Offset: 0x002C0B70
			public static int CompareHero(BattleHero h1, BattleHero h2)
			{
				return ArenaDefendUITask.CompareHero(h1, h2);
			}

			// Token: 0x06009ACB RID: 39627 RVA: 0x002C297C File Offset: 0x002C0B7C
			public void ShowStagePositions()
			{
				this.m_owner.ShowStagePositions();
			}

			// Token: 0x06009ACC RID: 39628 RVA: 0x002C298C File Offset: 0x002C0B8C
			public void ClearMapAndActors()
			{
				this.m_owner.ClearMapAndActors();
			}

			// Token: 0x06009ACD RID: 39629 RVA: 0x002C299C File Offset: 0x002C0B9C
			public void ArenaDefendUIController_OnReturn()
			{
				this.m_owner.ArenaDefendUIController_OnReturn();
			}

			// Token: 0x06009ACE RID: 39630 RVA: 0x002C29AC File Offset: 0x002C0BAC
			public void ArenaDefendUIController_OnSave()
			{
				this.m_owner.ArenaDefendUIController_OnSave();
			}

			// Token: 0x06009ACF RID: 39631 RVA: 0x002C29BC File Offset: 0x002C0BBC
			public void ArenaDefendUIController_OnShowActionOrderPanel()
			{
				this.m_owner.ArenaDefendUIController_OnShowActionOrderPanel();
			}

			// Token: 0x06009AD0 RID: 39632 RVA: 0x002C29CC File Offset: 0x002C0BCC
			public void UpdateStageHeroActionValues()
			{
				this.m_owner.UpdateStageHeroActionValues();
			}

			// Token: 0x06009AD1 RID: 39633 RVA: 0x002C29DC File Offset: 0x002C0BDC
			public static int CompareHeroActionValue(BattleHero hero0, BattleHero hero1)
			{
				return ArenaDefendUITask.CompareHeroActionValue(hero0, hero1);
			}

			// Token: 0x06009AD2 RID: 39634 RVA: 0x002C29E8 File Offset: 0x002C0BE8
			public void ArenaDefendUIController_OnShowMapPanel()
			{
				this.m_owner.ArenaDefendUIController_OnShowMapPanel();
			}

			// Token: 0x06009AD3 RID: 39635 RVA: 0x002C29F8 File Offset: 0x002C0BF8
			public void ArenaDefendUIController_OnShowDefendRulePanel()
			{
				this.m_owner.ArenaDefendUIController_OnShowDefendRulePanel();
			}

			// Token: 0x06009AD4 RID: 39636 RVA: 0x002C2A08 File Offset: 0x002C0C08
			public void ArenaDefendUIController_OnConfirmActionOrder()
			{
				this.m_owner.ArenaDefendUIController_OnConfirmActionOrder();
			}

			// Token: 0x06009AD5 RID: 39637 RVA: 0x002C2A18 File Offset: 0x002C0C18
			public void ArenaDefendUIController_OnConfirmMap(int index)
			{
				this.m_owner.ArenaDefendUIController_OnConfirmMap(index);
			}

			// Token: 0x06009AD6 RID: 39638 RVA: 0x002C2A28 File Offset: 0x002C0C28
			public void ArenaDefendUIController_OnConfirmDefendRule(int index)
			{
				this.m_owner.ArenaDefendUIController_OnConfirmDefendRule(index);
			}

			// Token: 0x06009AD7 RID: 39639 RVA: 0x002C2A38 File Offset: 0x002C0C38
			public void ArenaDefendUIController_OnShowMyActorInfo(BattleHero hero)
			{
				this.m_owner.ArenaDefendUIController_OnShowMyActorInfo(hero);
			}

			// Token: 0x06009AD8 RID: 39640 RVA: 0x002C2A48 File Offset: 0x002C0C48
			public void ArenaDefendUIController_OnHideActorInfo()
			{
				this.m_owner.ArenaDefendUIController_OnHideActorInfo();
			}

			// Token: 0x06009AD9 RID: 39641 RVA: 0x002C2A58 File Offset: 0x002C0C58
			public void ArenaDefendUIController_OnStageActorChange()
			{
				this.m_owner.ArenaDefendUIController_OnStageActorChange();
			}

			// Token: 0x06009ADA RID: 39642 RVA: 0x002C2A68 File Offset: 0x002C0C68
			public void UpdateBattlePower()
			{
				this.m_owner.UpdateBattlePower();
			}

			// Token: 0x06009ADB RID: 39643 RVA: 0x002C2A78 File Offset: 0x002C0C78
			public void ArenaDefendUIController_OnHeroOnStage(BattleHero hero, GridPosition pos)
			{
				this.m_owner.ArenaDefendUIController_OnHeroOnStage(hero, pos);
			}

			// Token: 0x06009ADC RID: 39644 RVA: 0x002C2A88 File Offset: 0x002C0C88
			public void ArenaDefendUIController_OnActorOffStage(ArenaDefendActor sa)
			{
				this.m_owner.ArenaDefendUIController_OnActorOffStage(sa);
			}

			// Token: 0x06009ADD RID: 39645 RVA: 0x002C2A98 File Offset: 0x002C0C98
			public void ArenaDefendUIController_OnStageActorMove(ArenaDefendActor sa, GridPosition p)
			{
				this.m_owner.ArenaDefendUIController_OnStageActorMove(sa, p);
			}

			// Token: 0x06009ADE RID: 39646 RVA: 0x002C2AA8 File Offset: 0x002C0CA8
			public void ArenaDefendUIController_OnStageActorSwap(ArenaDefendActor sa1, ArenaDefendActor sa2)
			{
				this.m_owner.ArenaDefendUIController_OnStageActorSwap(sa1, sa2);
			}

			// Token: 0x06009ADF RID: 39647 RVA: 0x002C2AB8 File Offset: 0x002C0CB8
			public void ArenaDefendUIController_OnPointerDown(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.ArenaDefendUIController_OnPointerDown(button, position);
			}

			// Token: 0x06009AE0 RID: 39648 RVA: 0x002C2AC8 File Offset: 0x002C0CC8
			public void ArenaDefendUIController_OnPointerUp(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.ArenaDefendUIController_OnPointerUp(button, position);
			}

			// Token: 0x06009AE1 RID: 39649 RVA: 0x002C2AD8 File Offset: 0x002C0CD8
			public void ArenaDefendUIController_OnPointerClick(PointerEventData.InputButton button, Vector2 position)
			{
				this.m_owner.ArenaDefendUIController_OnPointerClick(button, position);
			}

			// Token: 0x06009AE2 RID: 39650 RVA: 0x002C2AE8 File Offset: 0x002C0CE8
			public void BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(BattleHero hero)
			{
				this.m_owner.BattlePrepareActorInfoUIController_OnShowSelectSoldierPanel(hero);
			}

			// Token: 0x06009AE3 RID: 39651 RVA: 0x002C2AF8 File Offset: 0x002C0CF8
			public void BattlePrepareActorInfoUIController_OnChangeSkill(BattleHero hero, List<int> skillIds)
			{
				this.m_owner.BattlePrepareActorInfoUIController_OnChangeSkill(hero, skillIds);
			}

			// Token: 0x06009AE4 RID: 39652 RVA: 0x002C2B08 File Offset: 0x002C0D08
			public void BattlePrepareActorInfoUIController_OnChangeSoldier(BattleHero hero, int soldierId)
			{
				this.m_owner.BattlePrepareActorInfoUIController_OnChangeSoldier(hero, soldierId);
			}

			// Token: 0x06009AE5 RID: 39653 RVA: 0x002C2B18 File Offset: 0x002C0D18
			public void ArenaDefendSceneUIController_OnPointerDown(PointerEventData eventData)
			{
				this.m_owner.ArenaDefendSceneUIController_OnPointerDown(eventData);
			}

			// Token: 0x06009AE6 RID: 39654 RVA: 0x002C2B28 File Offset: 0x002C0D28
			public void ArenaDefendSceneUIController_OnPointerUp(PointerEventData eventData)
			{
				this.m_owner.ArenaDefendSceneUIController_OnPointerUp(eventData);
			}

			// Token: 0x06009AE7 RID: 39655 RVA: 0x002C2B38 File Offset: 0x002C0D38
			public void ArenaDefendSceneUIController_OnPointerClick(PointerEventData eventData)
			{
				this.m_owner.ArenaDefendSceneUIController_OnPointerClick(eventData);
			}

			// Token: 0x06009AE8 RID: 39656 RVA: 0x002C2B48 File Offset: 0x002C0D48
			public void ArenaDefendSceneUIController_OnBeginDrag(PointerEventData eventData)
			{
				this.m_owner.ArenaDefendSceneUIController_OnBeginDrag(eventData);
			}

			// Token: 0x06009AE9 RID: 39657 RVA: 0x002C2B58 File Offset: 0x002C0D58
			public void ArenaDefendSceneUIController_OnEndDrag(PointerEventData eventData)
			{
				this.m_owner.ArenaDefendSceneUIController_OnEndDrag(eventData);
			}

			// Token: 0x06009AEA RID: 39658 RVA: 0x002C2B68 File Offset: 0x002C0D68
			public void ArenaDefendSceneUIController_OnDrag(PointerEventData eventData)
			{
				this.m_owner.ArenaDefendSceneUIController_OnDrag(eventData);
			}

			// Token: 0x040069AA RID: 27050
			private ArenaDefendUITask m_owner;
		}
	}
}
