using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A8E RID: 2702
	[HotFix]
	public class BattlePauseUIController : UIControllerBase
	{
		// Token: 0x0600AA2F RID: 43567 RVA: 0x002F69C8 File Offset: 0x002F4BC8
		private BattlePauseUIController()
		{
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x002F69E8 File Offset: 0x002F4BE8
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_exitButton.onClick.AddListener(new UnityAction(this.OnExitButtonClick));
			this.m_achievementButton.onClick.AddListener(new UnityAction(this.OnAchievementButtonClick));
			this.m_settingButton.onClick.AddListener(new UnityAction(this.OnSetButtonClick));
			this.m_strategyButton.onClick.AddListener(new UnityAction(this.OnStrategyButtonClick));
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_achievementBackgroundButton.onClick.AddListener(new UnityAction(this.OnAchievementBackgroundButtonClick));
			this.m_strategyBackgroundButton.onClick.AddListener(new UnityAction(this.OnStrategyBackgroundButtonClick));
			this.m_mapTileSize = (this.m_mapTerrainPrefab.transform as RectTransform).sizeDelta;
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x002F6B58 File Offset: 0x002F4D58
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = true;
			this.m_achievementUIStateController.gameObject.SetActive(false);
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", null, false, true);
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x002F6BE4 File Offset: 0x002F4DE4
		public bool IsOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpened;
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x002F6C58 File Offset: 0x002F4E58
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			this.m_isOpened = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, true, true);
		}

		// Token: 0x0600AA34 RID: 43572 RVA: 0x002F6CE0 File Offset: 0x002F4EE0
		public void ShowStrategyButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStrategyButtonBoolean_hotfix != null)
			{
				this.m_ShowStrategyButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_strategyButton.gameObject.SetActive(show);
		}

		// Token: 0x0600AA35 RID: 43573 RVA: 0x002F6D64 File Offset: 0x002F4F64
		public void SetWinLoseConditions(string winDesc, string loseDesc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWinLoseConditionsStringString_hotfix != null)
			{
				this.m_SetWinLoseConditionsStringString_hotfix.call(new object[]
				{
					this,
					winDesc,
					loseDesc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetConditionInfo(this.m_winConditionGroupGameObject, winDesc);
			this.SetConditionInfo(this.m_loseConditionGroupGameObject, loseDesc);
		}

		// Token: 0x0600AA36 RID: 43574 RVA: 0x002F6E00 File Offset: 0x002F5000
		private void SetConditionInfo(GameObject parent, string conditionStrs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetConditionInfoGameObjectString_hotfix != null)
			{
				this.m_SetConditionInfoGameObjectString_hotfix.call(new object[]
				{
					this,
					parent,
					conditionStrs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(parent);
			char[] separator = new char[]
			{
				'\r',
				'\n'
			};
			string[] array = conditionStrs.Split(separator);
			foreach (string str in array)
			{
				this.AddCondition(parent, str);
			}
		}

		// Token: 0x0600AA37 RID: 43575 RVA: 0x002F6EC8 File Offset: 0x002F50C8
		private void AddCondition(GameObject parent, string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddConditionGameObjectString_hotfix != null)
			{
				this.m_AddConditionGameObjectString_hotfix.call(new object[]
				{
					this,
					parent,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_conditionPrefab, parent.transform, false);
			Text text = Utility.FindChildComponent<Text>(go, "Text", true);
			if (text != null)
			{
				text.text = str;
			}
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x002F6F7C File Offset: 0x002F517C
		public void SetStarCondition(BattleType battleType, int starTurnMax, int starDeadMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStarConditionBattleTypeInt32Int32_hotfix != null)
			{
				this.m_SetStarConditionBattleTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					battleType,
					starTurnMax,
					starDeadMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			GameObjectUtility.DestroyChildren(this.m_starConditionGroupGameObject);
			if (starTurnMax >= 0 && starDeadMax >= 0)
			{
				this.AddCondition(this.m_starConditionGroupGameObject, string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_BattleWin_StarTurnMax), starTurnMax));
				if (starDeadMax > 0)
				{
					if (battleType == BattleType.Rift)
					{
						this.AddCondition(this.m_starConditionGroupGameObject, string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_BattleWin_RiftStarDeadMax), starDeadMax));
					}
					else if (battleType == BattleType.HeroDungeon)
					{
						this.AddCondition(this.m_starConditionGroupGameObject, string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_BattleWin_HeroDungeonStarDeadMax), starDeadMax));
					}
				}
				else
				{
					this.AddCondition(this.m_starConditionGroupGameObject, configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_BattleWin_StarNoDead));
				}
			}
			else
			{
				this.AddCondition(this.m_starConditionGroupGameObject, configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_BattleWin_NoStarCondition));
			}
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x002F70F0 File Offset: 0x002F52F0
		public void SetAchievement(BattleLevelAchievement[] achievements, BattleType battleType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAchievementBattleLevelAchievementbeBattleType_hotfix != null)
			{
				this.m_SetAchievementBattleLevelAchievementbeBattleType_hotfix.call(new object[]
				{
					this,
					achievements,
					battleType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearAchievementItems();
			if (achievements == null || achievements.Length <= 0)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("BattleAchievementItem");
			if (battleType == BattleType.Rift)
			{
				for (int i = 0; i < 2; i++)
				{
					foreach (BattleLevelAchievement battleLevelAchievement in achievements)
					{
						bool flag = projectLPlayerContext.HasRiftLevelAchievement(battleLevelAchievement.m_achievementRelatedInfo.ID);
						if (flag == (i == 1))
						{
							this.AddAchievementItem(battleLevelAchievement.m_achievementRelatedInfo.m_achievementInfo, battleLevelAchievement.m_rewards, assetInContainer, flag);
						}
					}
				}
			}
			else if (battleType == BattleType.HeroDungeon)
			{
				for (int k = 0; k < 2; k++)
				{
					foreach (BattleLevelAchievement battleLevelAchievement2 in achievements)
					{
						bool flag2 = projectLPlayerContext.HasHeroDungeonLevelAchievement(battleLevelAchievement2.m_achievementRelatedInfo.ID);
						if (flag2 == (k == 1))
						{
							this.AddAchievementItem(battleLevelAchievement2.m_achievementRelatedInfo.m_achievementInfo, battleLevelAchievement2.m_rewards, assetInContainer, flag2);
						}
					}
				}
			}
			else if (battleType == BattleType.HeroPhantom)
			{
				for (int m = 0; m < 2; m++)
				{
					foreach (BattleLevelAchievement battleLevelAchievement3 in achievements)
					{
						bool flag3 = projectLPlayerContext.IsCompleteHeroPhantomLevelAchievement(battleLevelAchievement3.m_achievementRelatedInfo.ID);
						if (flag3 == (m == 1))
						{
							this.AddAchievementItem(battleLevelAchievement3.m_achievementRelatedInfo.m_achievementInfo, battleLevelAchievement3.m_rewards, assetInContainer, flag3);
						}
					}
				}
			}
			this.m_achievementScrollRect.verticalNormalizedPosition = 1f;
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x002F7328 File Offset: 0x002F5528
		public void SetAchievementCount(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAchievementCountInt32Int32_hotfix != null)
			{
				this.m_SetAchievementCountInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_achievementButtonText.text = count + "/" + countMax;
			this.m_achievementCountMax = countMax;
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x002F73D0 File Offset: 0x002F55D0
		private void ShowAchievement()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAchievement_hotfix != null)
			{
				this.m_ShowAchievement_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_achievementUIStateController, "Open", null, false, true);
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x002F7444 File Offset: 0x002F5644
		private void HideAchievement()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideAchievement_hotfix != null)
			{
				this.m_HideAchievement_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_achievementUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600AA3D RID: 43581 RVA: 0x002F74B8 File Offset: 0x002F56B8
		private void AddAchievementItem(ConfigDataBattleAchievementInfo achievementInfo, List<Goods> rewards, GameObject prefab, bool complete)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix != null)
			{
				this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix.call(new object[]
				{
					this,
					achievementInfo,
					rewards,
					prefab,
					complete
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(prefab);
			gameObject.transform.SetParent(this.m_achievementScrollRect.content, false);
			BattleAchievementItemUIController battleAchievementItemUIController = GameObjectUtility.AddControllerToGameObject<BattleAchievementItemUIController>(gameObject);
			battleAchievementItemUIController.SetAchievement(achievementInfo);
			battleAchievementItemUIController.SetRewards(rewards);
			battleAchievementItemUIController.SetComplete(complete);
			this.m_achievementItems.Add(battleAchievementItemUIController);
		}

		// Token: 0x0600AA3E RID: 43582 RVA: 0x002F75A0 File Offset: 0x002F57A0
		private void ClearAchievementItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAchievementItems_hotfix != null)
			{
				this.m_ClearAchievementItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<BattleAchievementItemUIController>(this.m_achievementItems);
			this.m_achievementItems.Clear();
		}

		// Token: 0x0600AA3F RID: 43583 RVA: 0x002F7618 File Offset: 0x002F5818
		public void SetTurn(int turn, int turnMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTurnInt32Int32_hotfix != null)
			{
				this.m_SetTurnInt32Int32_hotfix.call(new object[]
				{
					this,
					turn,
					turnMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_turnGameObject.SetActive(turnMax > 0);
			this.m_turnText.text = turn + " / " + turnMax;
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x002F76C8 File Offset: 0x002F58C8
		public void SetMap(BattleMap map)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMapBattleMap_hotfix != null)
			{
				this.m_SetMapBattleMap_hotfix.call(new object[]
				{
					this,
					map
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMap();
			if (map == null)
			{
				return;
			}
			this.m_mapWidth = map.Width;
			this.m_mapHeight = map.Height;
			for (int i = 0; i < map.Height; i++)
			{
				for (int j = 0; j < map.Width; j++)
				{
					ConfigDataTerrainInfo terrain = map.GetTerrain(new GridPosition(j, i));
					if (terrain != null)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_mapTerrainPrefab, this.m_mapTerrainGameObject.transform, false);
						Image component = gameObject.GetComponent<Image>();
						component.sprite = AssetUtility.Instance.GetSprite(terrain.MapTileImage);
						component.rectTransform.anchoredPosition = this.GridPositionToMapPosition(j, i);
					}
				}
			}
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x002F77F0 File Offset: 0x002F59F0
		private void ClearMap()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMap_hotfix != null)
			{
				this.m_ClearMap_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_mapTerrainGameObject);
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x002F785C File Offset: 0x002F5A5C
		public void SetMapActors(List<GridPosition> team0, List<GridPosition> team1, List<GridPosition> teamNpc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMapActorsList`1List`1List`1_hotfix != null)
			{
				this.m_SetMapActorsList`1List`1List`1_hotfix.call(new object[]
				{
					this,
					team0,
					team1,
					teamNpc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapActors();
			this.CreateMapActors(team0, this.m_mapActor0Prefab);
			this.CreateMapActors(team1, this.m_mapActor1Prefab);
			this.CreateMapActors(teamNpc, this.m_mapActor2Prefab);
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x002F791C File Offset: 0x002F5B1C
		private void CreateMapActors(List<GridPosition> positions, GameObject prefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMapActorsList`1GameObject_hotfix != null)
			{
				this.m_CreateMapActorsList`1GameObject_hotfix.call(new object[]
				{
					this,
					positions,
					prefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (positions == null)
			{
				return;
			}
			foreach (GridPosition gridPosition in positions)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(prefab, this.m_mapActorGameObject.transform, false);
				RectTransform rectTransform = gameObject.transform as RectTransform;
				rectTransform.anchoredPosition = this.GridPositionToMapPosition(gridPosition.x, gridPosition.y);
			}
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x002F7A20 File Offset: 0x002F5C20
		private void ClearMapActors()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapActors_hotfix != null)
			{
				this.m_ClearMapActors_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_mapActorGameObject);
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x002F7A8C File Offset: 0x002F5C8C
		public void SetMapReachRegion(List<GridPosition> region)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMapReachRegionList`1_hotfix != null)
			{
				this.m_SetMapReachRegionList`1_hotfix.call(new object[]
				{
					this,
					region
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMapReachRegion();
			if (region != null)
			{
				foreach (GridPosition gridPosition in region)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_mapReachPrefab, this.m_mapRegionGameObject.transform, false);
					RectTransform rectTransform = gameObject.transform as RectTransform;
					rectTransform.anchoredPosition = this.GridPositionToMapPosition(gridPosition.x, gridPosition.y);
				}
			}
		}

		// Token: 0x0600AA46 RID: 43590 RVA: 0x002F7B8C File Offset: 0x002F5D8C
		private void ClearMapReachRegion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapReachRegion_hotfix != null)
			{
				this.m_ClearMapReachRegion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_mapRegionGameObject);
		}

		// Token: 0x0600AA47 RID: 43591 RVA: 0x002F7BF8 File Offset: 0x002F5DF8
		public void ClearMapAll()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearMapAll_hotfix != null)
			{
				this.m_ClearMapAll_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearMap();
			this.ClearMapActors();
			this.ClearMapReachRegion();
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x002F7C6C File Offset: 0x002F5E6C
		private Vector2 GridPositionToMapPosition(int x, int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GridPositionToMapPositionInt32Int32_hotfix != null)
			{
				return (Vector2)this.m_GridPositionToMapPositionInt32Int32_hotfix.call(new object[]
				{
					this,
					x,
					y
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = (float)(this.m_mapWidth - 1) * 0.5f;
			float num2 = (float)(this.m_mapHeight - 1) * 0.5f;
			return new Vector2(((float)x - num) * this.m_mapTileSize.x, (num2 - (float)y) * this.m_mapTileSize.y);
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x002F7D40 File Offset: 0x002F5F40
		private void OnExitButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitButtonClick_hotfix != null)
			{
				this.m_OnExitButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExit != null)
			{
				this.EventOnExit();
			}
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x002F7DB8 File Offset: 0x002F5FB8
		private void OnAchievementButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementButtonClick_hotfix != null)
			{
				this.m_OnAchievementButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_achievementCountMax <= 0)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_NoAchievement, 2f, null, true);
				return;
			}
			this.ShowAchievement();
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x002F7E44 File Offset: 0x002F6044
		private void OnStrategyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStrategyButtonClick_hotfix != null)
			{
				this.m_OnStrategyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateStrategyPanel();
			UIUtility.SetUIStateOpen(this.m_strategyUIStateController, "Open", null, false, true);
			this.m_strategyUIStateController.gameObject.SetActive(true);
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x002F7ED0 File Offset: 0x002F60D0
		private void UpdateStrategyPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStrategyPanel_hotfix != null)
			{
				this.m_UpdateStrategyPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string text = string.Empty;
			if (projectLPlayerContext.Happening.Step == HappeningStep.Battle)
			{
				text = projectLPlayerContext.Happening.GetStrategy();
			}
			if (!string.IsNullOrEmpty(text))
			{
				this.m_strategyContentText.text = text;
			}
			else
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.m_strategyContentText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Battle_NoStrategy);
			}
			this.m_danmakuItemUICtrlList.Clear();
			GameObjectUtility.DestroyChildren(this.m_danmakuContent);
			LevelDanmaku levelDanmaku = projectLPlayerContext.GetLevelDanmaku();
			if (levelDanmaku != null)
			{
				List<TurnDanmaku> list = new List<TurnDanmaku>();
				list.AddRange(levelDanmaku.Turns);
				list.Sort((TurnDanmaku a, TurnDanmaku b) => a.Turn - b.Turn);
				foreach (TurnDanmaku turnDanmaku in list)
				{
					List<DanmakuEntry> list2 = new List<DanmakuEntry>();
					list2.AddRange(turnDanmaku.Entries);
					list2.Reverse();
					foreach (DanmakuEntry danmakuEntry in list2)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_danmakuItemPrefab);
						PrefabControllerCreater.CreateAllControllers(gameObject);
						DanmakuItemUIController component = gameObject.GetComponent<DanmakuItemUIController>();
						component.InitDanmakuItem(danmakuEntry.Content, turnDanmaku.Turn);
						gameObject.transform.SetParent(this.m_danmakuContent.transform, false);
						this.m_danmakuItemUICtrlList.Add(component);
					}
				}
			}
			base.StartCoroutine(this.Co_StartDanmakuItemsTweenPos());
		}

		// Token: 0x0600AA4D RID: 43597 RVA: 0x002F810C File Offset: 0x002F630C
		[DebuggerHidden]
		private IEnumerator Co_StartDanmakuItemsTweenPos()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_StartDanmakuItemsTweenPos_hotfix != null)
			{
				return (IEnumerator)this.m_Co_StartDanmakuItemsTweenPos_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattlePauseUIController.<Co_StartDanmakuItemsTweenPos>c__Iterator0 <Co_StartDanmakuItemsTweenPos>c__Iterator = new BattlePauseUIController.<Co_StartDanmakuItemsTweenPos>c__Iterator0();
			<Co_StartDanmakuItemsTweenPos>c__Iterator.$this = this;
			return <Co_StartDanmakuItemsTweenPos>c__Iterator;
		}

		// Token: 0x0600AA4E RID: 43598 RVA: 0x002F8188 File Offset: 0x002F6388
		private void OnStrategyBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStrategyBackgroundButtonClick_hotfix != null)
			{
				this.m_OnStrategyBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_strategyUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x002F81FC File Offset: 0x002F63FC
		private void OnSetButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSetButtonClick_hotfix != null)
			{
				this.m_OnSetButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerSetting != null)
			{
				this.EventOnShowPlayerSetting();
			}
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x002F8274 File Offset: 0x002F6474
		private void OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClick_hotfix != null)
			{
				this.m_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x002F82EC File Offset: 0x002F64EC
		private void OnAchievementBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementBackgroundButtonClick_hotfix != null)
			{
				this.m_OnAchievementBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideAchievement();
		}

		// Token: 0x140001F6 RID: 502
		// (add) Token: 0x0600AA52 RID: 43602 RVA: 0x002F8354 File Offset: 0x002F6554
		// (remove) Token: 0x0600AA53 RID: 43603 RVA: 0x002F83F0 File Offset: 0x002F65F0
		public event Action EventOnExit
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExitAction_hotfix != null)
				{
					this.m_add_EventOnExitAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExit;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExit, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExitAction_hotfix != null)
				{
					this.m_remove_EventOnExitAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExit;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExit, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001F7 RID: 503
		// (add) Token: 0x0600AA54 RID: 43604 RVA: 0x002F848C File Offset: 0x002F668C
		// (remove) Token: 0x0600AA55 RID: 43605 RVA: 0x002F8528 File Offset: 0x002F6728
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001F8 RID: 504
		// (add) Token: 0x0600AA56 RID: 43606 RVA: 0x002F85C4 File Offset: 0x002F67C4
		// (remove) Token: 0x0600AA57 RID: 43607 RVA: 0x002F8660 File Offset: 0x002F6860
		public event Action EventOnShowPlayerSetting
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPlayerSettingAction_hotfix != null)
				{
					this.m_add_EventOnShowPlayerSettingAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowPlayerSetting;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowPlayerSetting, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPlayerSettingAction_hotfix != null)
				{
					this.m_remove_EventOnShowPlayerSettingAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowPlayerSetting;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowPlayerSetting, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x0600AA58 RID: 43608 RVA: 0x002F86FC File Offset: 0x002F68FC
		// (set) Token: 0x0600AA59 RID: 43609 RVA: 0x002F871C File Offset: 0x002F691C
		[DoNotToLua]
		public new BattlePauseUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePauseUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x002F8728 File Offset: 0x002F6928
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x002F8734 File Offset: 0x002F6934
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x002F873C File Offset: 0x002F693C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x002F8744 File Offset: 0x002F6944
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x002F8758 File Offset: 0x002F6958
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AA5F RID: 43615 RVA: 0x002F8760 File Offset: 0x002F6960
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x002F876C File Offset: 0x002F696C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x002F8778 File Offset: 0x002F6978
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x002F8784 File Offset: 0x002F6984
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AA63 RID: 43619 RVA: 0x002F8790 File Offset: 0x002F6990
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x002F879C File Offset: 0x002F699C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x002F87A8 File Offset: 0x002F69A8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AA66 RID: 43622 RVA: 0x002F87B4 File Offset: 0x002F69B4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x002F87C0 File Offset: 0x002F69C0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x002F87CC File Offset: 0x002F69CC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x002F87D4 File Offset: 0x002F69D4
		private void __callDele_EventOnExit()
		{
			Action eventOnExit = this.EventOnExit;
			if (eventOnExit != null)
			{
				eventOnExit();
			}
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x002F87F4 File Offset: 0x002F69F4
		private void __clearDele_EventOnExit()
		{
			this.EventOnExit = null;
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x002F8800 File Offset: 0x002F6A00
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x002F8820 File Offset: 0x002F6A20
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x002F882C File Offset: 0x002F6A2C
		private void __callDele_EventOnShowPlayerSetting()
		{
			Action eventOnShowPlayerSetting = this.EventOnShowPlayerSetting;
			if (eventOnShowPlayerSetting != null)
			{
				eventOnShowPlayerSetting();
			}
		}

		// Token: 0x0600AA6E RID: 43630 RVA: 0x002F884C File Offset: 0x002F6A4C
		private void __clearDele_EventOnShowPlayerSetting()
		{
			this.EventOnShowPlayerSetting = null;
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x002F8868 File Offset: 0x002F6A68
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_ShowStrategyButtonBoolean_hotfix = (luaObj.RawGet("ShowStrategyButton") as LuaFunction);
					this.m_SetWinLoseConditionsStringString_hotfix = (luaObj.RawGet("SetWinLoseConditions") as LuaFunction);
					this.m_SetConditionInfoGameObjectString_hotfix = (luaObj.RawGet("SetConditionInfo") as LuaFunction);
					this.m_AddConditionGameObjectString_hotfix = (luaObj.RawGet("AddCondition") as LuaFunction);
					this.m_SetStarConditionBattleTypeInt32Int32_hotfix = (luaObj.RawGet("SetStarCondition") as LuaFunction);
					this.m_SetAchievementBattleLevelAchievementbeBattleType_hotfix = (luaObj.RawGet("SetAchievement") as LuaFunction);
					this.m_SetAchievementCountInt32Int32_hotfix = (luaObj.RawGet("SetAchievementCount") as LuaFunction);
					this.m_ShowAchievement_hotfix = (luaObj.RawGet("ShowAchievement") as LuaFunction);
					this.m_HideAchievement_hotfix = (luaObj.RawGet("HideAchievement") as LuaFunction);
					this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix = (luaObj.RawGet("AddAchievementItem") as LuaFunction);
					this.m_ClearAchievementItems_hotfix = (luaObj.RawGet("ClearAchievementItems") as LuaFunction);
					this.m_SetTurnInt32Int32_hotfix = (luaObj.RawGet("SetTurn") as LuaFunction);
					this.m_SetMapBattleMap_hotfix = (luaObj.RawGet("SetMap") as LuaFunction);
					this.m_ClearMap_hotfix = (luaObj.RawGet("ClearMap") as LuaFunction);
					this.m_SetMapActorsList`1List`1List`1_hotfix = (luaObj.RawGet("SetMapActors") as LuaFunction);
					this.m_CreateMapActorsList`1GameObject_hotfix = (luaObj.RawGet("CreateMapActors") as LuaFunction);
					this.m_ClearMapActors_hotfix = (luaObj.RawGet("ClearMapActors") as LuaFunction);
					this.m_SetMapReachRegionList`1_hotfix = (luaObj.RawGet("SetMapReachRegion") as LuaFunction);
					this.m_ClearMapReachRegion_hotfix = (luaObj.RawGet("ClearMapReachRegion") as LuaFunction);
					this.m_ClearMapAll_hotfix = (luaObj.RawGet("ClearMapAll") as LuaFunction);
					this.m_GridPositionToMapPositionInt32Int32_hotfix = (luaObj.RawGet("GridPositionToMapPosition") as LuaFunction);
					this.m_OnExitButtonClick_hotfix = (luaObj.RawGet("OnExitButtonClick") as LuaFunction);
					this.m_OnAchievementButtonClick_hotfix = (luaObj.RawGet("OnAchievementButtonClick") as LuaFunction);
					this.m_OnStrategyButtonClick_hotfix = (luaObj.RawGet("OnStrategyButtonClick") as LuaFunction);
					this.m_UpdateStrategyPanel_hotfix = (luaObj.RawGet("UpdateStrategyPanel") as LuaFunction);
					this.m_Co_StartDanmakuItemsTweenPos_hotfix = (luaObj.RawGet("Co_StartDanmakuItemsTweenPos") as LuaFunction);
					this.m_OnStrategyBackgroundButtonClick_hotfix = (luaObj.RawGet("OnStrategyBackgroundButtonClick") as LuaFunction);
					this.m_OnSetButtonClick_hotfix = (luaObj.RawGet("OnSetButtonClick") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnAchievementBackgroundButtonClick_hotfix = (luaObj.RawGet("OnAchievementBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnExitAction_hotfix = (luaObj.RawGet("add_EventOnExit") as LuaFunction);
					this.m_remove_EventOnExitAction_hotfix = (luaObj.RawGet("remove_EventOnExit") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnShowPlayerSettingAction_hotfix = (luaObj.RawGet("add_EventOnShowPlayerSetting") as LuaFunction);
					this.m_remove_EventOnShowPlayerSettingAction_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerSetting") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x002F8D04 File Offset: 0x002F6F04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePauseUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006FDD RID: 28637
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04006FDE RID: 28638
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04006FDF RID: 28639
		[AutoBind("./Objective/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x04006FE0 RID: 28640
		[AutoBind("./Objective/ExitButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_exitButton;

		// Token: 0x04006FE1 RID: 28641
		[AutoBind("./Objective/AchievementButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_achievementButton;

		// Token: 0x04006FE2 RID: 28642
		[AutoBind("./Objective/SetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_settingButton;

		// Token: 0x04006FE3 RID: 28643
		[AutoBind("./Objective/StrategyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_strategyButton;

		// Token: 0x04006FE4 RID: 28644
		[AutoBind("./Objective/AchievementButton/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementButtonText;

		// Token: 0x04006FE5 RID: 28645
		[AutoBind("./Objective/Turn", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_turnGameObject;

		// Token: 0x04006FE6 RID: 28646
		[AutoBind("./Objective/Turn/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_turnText;

		// Token: 0x04006FE7 RID: 28647
		[AutoBind("./Objective/WinDesc/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_winConditionGroupGameObject;

		// Token: 0x04006FE8 RID: 28648
		[AutoBind("./Objective/LoseDesc/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_loseConditionGroupGameObject;

		// Token: 0x04006FE9 RID: 28649
		[AutoBind("./Objective/StarDesc/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starConditionGroupGameObject;

		// Token: 0x04006FEA RID: 28650
		[AutoBind("./Objective/Map/Terrain", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapTerrainGameObject;

		// Token: 0x04006FEB RID: 28651
		[AutoBind("./Objective/Map/Region", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapRegionGameObject;

		// Token: 0x04006FEC RID: 28652
		[AutoBind("./Objective/Map/Actor", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapActorGameObject;

		// Token: 0x04006FED RID: 28653
		[AutoBind("./Achievement", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_achievementUIStateController;

		// Token: 0x04006FEE RID: 28654
		[AutoBind("./Achievement/Panel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_achievementScrollRect;

		// Token: 0x04006FEF RID: 28655
		[AutoBind("./Achievement/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_achievementBackgroundButton;

		// Token: 0x04006FF0 RID: 28656
		[AutoBind("./Strategy", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_strategyUIStateController;

		// Token: 0x04006FF1 RID: 28657
		[AutoBind("./Strategy/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_strategyBackgroundButton;

		// Token: 0x04006FF2 RID: 28658
		[AutoBind("./Strategy/Panel/Left/Content", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_strategyContentText;

		// Token: 0x04006FF3 RID: 28659
		[AutoBind("./Strategy/Panel/Right/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_danmakuContent;

		// Token: 0x04006FF4 RID: 28660
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04006FF5 RID: 28661
		[AutoBind("./Prefabs/Terrain", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapTerrainPrefab;

		// Token: 0x04006FF6 RID: 28662
		[AutoBind("./Prefabs/Actor0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapActor0Prefab;

		// Token: 0x04006FF7 RID: 28663
		[AutoBind("./Prefabs/Actor1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapActor1Prefab;

		// Token: 0x04006FF8 RID: 28664
		[AutoBind("./Prefabs/Actor2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapActor2Prefab;

		// Token: 0x04006FF9 RID: 28665
		[AutoBind("./Prefabs/Reach", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mapReachPrefab;

		// Token: 0x04006FFA RID: 28666
		[AutoBind("./Prefabs/ConditionInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_conditionPrefab;

		// Token: 0x04006FFB RID: 28667
		[AutoBind("./Prefabs/DanmakuItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_danmakuItemPrefab;

		// Token: 0x04006FFC RID: 28668
		private List<DanmakuItemUIController> m_danmakuItemUICtrlList = new List<DanmakuItemUIController>();

		// Token: 0x04006FFD RID: 28669
		private List<BattleAchievementItemUIController> m_achievementItems = new List<BattleAchievementItemUIController>();

		// Token: 0x04006FFE RID: 28670
		private int m_achievementCountMax;

		// Token: 0x04006FFF RID: 28671
		private int m_mapWidth;

		// Token: 0x04007000 RID: 28672
		private int m_mapHeight;

		// Token: 0x04007001 RID: 28673
		private Vector2 m_mapTileSize;

		// Token: 0x04007002 RID: 28674
		private bool m_isOpened;

		// Token: 0x04007003 RID: 28675
		[DoNotToLua]
		private BattlePauseUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007005 RID: 28677
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007006 RID: 28678
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007007 RID: 28679
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007008 RID: 28680
		private LuaFunction m_Open_hotfix;

		// Token: 0x04007009 RID: 28681
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x0400700A RID: 28682
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400700B RID: 28683
		private LuaFunction m_ShowStrategyButtonBoolean_hotfix;

		// Token: 0x0400700C RID: 28684
		private LuaFunction m_SetWinLoseConditionsStringString_hotfix;

		// Token: 0x0400700D RID: 28685
		private LuaFunction m_SetConditionInfoGameObjectString_hotfix;

		// Token: 0x0400700E RID: 28686
		private LuaFunction m_AddConditionGameObjectString_hotfix;

		// Token: 0x0400700F RID: 28687
		private LuaFunction m_SetStarConditionBattleTypeInt32Int32_hotfix;

		// Token: 0x04007010 RID: 28688
		private LuaFunction m_SetAchievementBattleLevelAchievementbeBattleType_hotfix;

		// Token: 0x04007011 RID: 28689
		private LuaFunction m_SetAchievementCountInt32Int32_hotfix;

		// Token: 0x04007012 RID: 28690
		private LuaFunction m_ShowAchievement_hotfix;

		// Token: 0x04007013 RID: 28691
		private LuaFunction m_HideAchievement_hotfix;

		// Token: 0x04007014 RID: 28692
		private LuaFunction m_AddAchievementItemConfigDataBattleAchievementInfoList;

		// Token: 0x04007015 RID: 28693
		private LuaFunction m_ClearAchievementItems_hotfix;

		// Token: 0x04007016 RID: 28694
		private LuaFunction m_SetTurnInt32Int32_hotfix;

		// Token: 0x04007017 RID: 28695
		private LuaFunction m_SetMapBattleMap_hotfix;

		// Token: 0x04007018 RID: 28696
		private LuaFunction m_ClearMap_hotfix;

		// Token: 0x04007019 RID: 28697
		private LuaFunction m_SetMapActorsList`1List`1List;

		// Token: 0x0400701A RID: 28698
		private LuaFunction m_CreateMapActorsList;

		// Token: 0x0400701B RID: 28699
		private LuaFunction m_ClearMapActors_hotfix;

		// Token: 0x0400701C RID: 28700
		private LuaFunction m_SetMapReachRegionList;

		// Token: 0x0400701D RID: 28701
		private LuaFunction m_ClearMapReachRegion_hotfix;

		// Token: 0x0400701E RID: 28702
		private LuaFunction m_ClearMapAll_hotfix;

		// Token: 0x0400701F RID: 28703
		private LuaFunction m_GridPositionToMapPositionInt32Int32_hotfix;

		// Token: 0x04007020 RID: 28704
		private LuaFunction m_OnExitButtonClick_hotfix;

		// Token: 0x04007021 RID: 28705
		private LuaFunction m_OnAchievementButtonClick_hotfix;

		// Token: 0x04007022 RID: 28706
		private LuaFunction m_OnStrategyButtonClick_hotfix;

		// Token: 0x04007023 RID: 28707
		private LuaFunction m_UpdateStrategyPanel_hotfix;

		// Token: 0x04007024 RID: 28708
		private LuaFunction m_Co_StartDanmakuItemsTweenPos_hotfix;

		// Token: 0x04007025 RID: 28709
		private LuaFunction m_OnStrategyBackgroundButtonClick_hotfix;

		// Token: 0x04007026 RID: 28710
		private LuaFunction m_OnSetButtonClick_hotfix;

		// Token: 0x04007027 RID: 28711
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x04007028 RID: 28712
		private LuaFunction m_OnAchievementBackgroundButtonClick_hotfix;

		// Token: 0x04007029 RID: 28713
		private LuaFunction m_add_EventOnExitAction_hotfix;

		// Token: 0x0400702A RID: 28714
		private LuaFunction m_remove_EventOnExitAction_hotfix;

		// Token: 0x0400702B RID: 28715
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400702C RID: 28716
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400702D RID: 28717
		private LuaFunction m_add_EventOnShowPlayerSettingAction_hotfix;

		// Token: 0x0400702E RID: 28718
		private LuaFunction m_remove_EventOnShowPlayerSettingAction_hotfix;

		// Token: 0x02000A8F RID: 2703
		public new class LuaExportHelper
		{
			// Token: 0x0600AA72 RID: 43634 RVA: 0x002F8D6C File Offset: 0x002F6F6C
			public LuaExportHelper(BattlePauseUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AA73 RID: 43635 RVA: 0x002F8D7C File Offset: 0x002F6F7C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AA74 RID: 43636 RVA: 0x002F8D8C File Offset: 0x002F6F8C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AA75 RID: 43637 RVA: 0x002F8D9C File Offset: 0x002F6F9C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AA76 RID: 43638 RVA: 0x002F8DAC File Offset: 0x002F6FAC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AA77 RID: 43639 RVA: 0x002F8DC4 File Offset: 0x002F6FC4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AA78 RID: 43640 RVA: 0x002F8DD4 File Offset: 0x002F6FD4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AA79 RID: 43641 RVA: 0x002F8DE4 File Offset: 0x002F6FE4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AA7A RID: 43642 RVA: 0x002F8DF4 File Offset: 0x002F6FF4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AA7B RID: 43643 RVA: 0x002F8E04 File Offset: 0x002F7004
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AA7C RID: 43644 RVA: 0x002F8E14 File Offset: 0x002F7014
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AA7D RID: 43645 RVA: 0x002F8E24 File Offset: 0x002F7024
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AA7E RID: 43646 RVA: 0x002F8E34 File Offset: 0x002F7034
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AA7F RID: 43647 RVA: 0x002F8E44 File Offset: 0x002F7044
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AA80 RID: 43648 RVA: 0x002F8E54 File Offset: 0x002F7054
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AA81 RID: 43649 RVA: 0x002F8E64 File Offset: 0x002F7064
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600AA82 RID: 43650 RVA: 0x002F8E74 File Offset: 0x002F7074
			public void __callDele_EventOnExit()
			{
				this.m_owner.__callDele_EventOnExit();
			}

			// Token: 0x0600AA83 RID: 43651 RVA: 0x002F8E84 File Offset: 0x002F7084
			public void __clearDele_EventOnExit()
			{
				this.m_owner.__clearDele_EventOnExit();
			}

			// Token: 0x0600AA84 RID: 43652 RVA: 0x002F8E94 File Offset: 0x002F7094
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600AA85 RID: 43653 RVA: 0x002F8EA4 File Offset: 0x002F70A4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0600AA86 RID: 43654 RVA: 0x002F8EB4 File Offset: 0x002F70B4
			public void __callDele_EventOnShowPlayerSetting()
			{
				this.m_owner.__callDele_EventOnShowPlayerSetting();
			}

			// Token: 0x0600AA87 RID: 43655 RVA: 0x002F8EC4 File Offset: 0x002F70C4
			public void __clearDele_EventOnShowPlayerSetting()
			{
				this.m_owner.__clearDele_EventOnShowPlayerSetting();
			}

			// Token: 0x17002279 RID: 8825
			// (get) Token: 0x0600AA88 RID: 43656 RVA: 0x002F8ED4 File Offset: 0x002F70D4
			// (set) Token: 0x0600AA89 RID: 43657 RVA: 0x002F8EE4 File Offset: 0x002F70E4
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x1700227A RID: 8826
			// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x002F8EF4 File Offset: 0x002F70F4
			// (set) Token: 0x0600AA8B RID: 43659 RVA: 0x002F8F04 File Offset: 0x002F7104
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x1700227B RID: 8827
			// (get) Token: 0x0600AA8C RID: 43660 RVA: 0x002F8F14 File Offset: 0x002F7114
			// (set) Token: 0x0600AA8D RID: 43661 RVA: 0x002F8F24 File Offset: 0x002F7124
			public Button m_closeButton
			{
				get
				{
					return this.m_owner.m_closeButton;
				}
				set
				{
					this.m_owner.m_closeButton = value;
				}
			}

			// Token: 0x1700227C RID: 8828
			// (get) Token: 0x0600AA8E RID: 43662 RVA: 0x002F8F34 File Offset: 0x002F7134
			// (set) Token: 0x0600AA8F RID: 43663 RVA: 0x002F8F44 File Offset: 0x002F7144
			public Button m_exitButton
			{
				get
				{
					return this.m_owner.m_exitButton;
				}
				set
				{
					this.m_owner.m_exitButton = value;
				}
			}

			// Token: 0x1700227D RID: 8829
			// (get) Token: 0x0600AA90 RID: 43664 RVA: 0x002F8F54 File Offset: 0x002F7154
			// (set) Token: 0x0600AA91 RID: 43665 RVA: 0x002F8F64 File Offset: 0x002F7164
			public Button m_achievementButton
			{
				get
				{
					return this.m_owner.m_achievementButton;
				}
				set
				{
					this.m_owner.m_achievementButton = value;
				}
			}

			// Token: 0x1700227E RID: 8830
			// (get) Token: 0x0600AA92 RID: 43666 RVA: 0x002F8F74 File Offset: 0x002F7174
			// (set) Token: 0x0600AA93 RID: 43667 RVA: 0x002F8F84 File Offset: 0x002F7184
			public Button m_settingButton
			{
				get
				{
					return this.m_owner.m_settingButton;
				}
				set
				{
					this.m_owner.m_settingButton = value;
				}
			}

			// Token: 0x1700227F RID: 8831
			// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x002F8F94 File Offset: 0x002F7194
			// (set) Token: 0x0600AA95 RID: 43669 RVA: 0x002F8FA4 File Offset: 0x002F71A4
			public Button m_strategyButton
			{
				get
				{
					return this.m_owner.m_strategyButton;
				}
				set
				{
					this.m_owner.m_strategyButton = value;
				}
			}

			// Token: 0x17002280 RID: 8832
			// (get) Token: 0x0600AA96 RID: 43670 RVA: 0x002F8FB4 File Offset: 0x002F71B4
			// (set) Token: 0x0600AA97 RID: 43671 RVA: 0x002F8FC4 File Offset: 0x002F71C4
			public Text m_achievementButtonText
			{
				get
				{
					return this.m_owner.m_achievementButtonText;
				}
				set
				{
					this.m_owner.m_achievementButtonText = value;
				}
			}

			// Token: 0x17002281 RID: 8833
			// (get) Token: 0x0600AA98 RID: 43672 RVA: 0x002F8FD4 File Offset: 0x002F71D4
			// (set) Token: 0x0600AA99 RID: 43673 RVA: 0x002F8FE4 File Offset: 0x002F71E4
			public GameObject m_turnGameObject
			{
				get
				{
					return this.m_owner.m_turnGameObject;
				}
				set
				{
					this.m_owner.m_turnGameObject = value;
				}
			}

			// Token: 0x17002282 RID: 8834
			// (get) Token: 0x0600AA9A RID: 43674 RVA: 0x002F8FF4 File Offset: 0x002F71F4
			// (set) Token: 0x0600AA9B RID: 43675 RVA: 0x002F9004 File Offset: 0x002F7204
			public Text m_turnText
			{
				get
				{
					return this.m_owner.m_turnText;
				}
				set
				{
					this.m_owner.m_turnText = value;
				}
			}

			// Token: 0x17002283 RID: 8835
			// (get) Token: 0x0600AA9C RID: 43676 RVA: 0x002F9014 File Offset: 0x002F7214
			// (set) Token: 0x0600AA9D RID: 43677 RVA: 0x002F9024 File Offset: 0x002F7224
			public GameObject m_winConditionGroupGameObject
			{
				get
				{
					return this.m_owner.m_winConditionGroupGameObject;
				}
				set
				{
					this.m_owner.m_winConditionGroupGameObject = value;
				}
			}

			// Token: 0x17002284 RID: 8836
			// (get) Token: 0x0600AA9E RID: 43678 RVA: 0x002F9034 File Offset: 0x002F7234
			// (set) Token: 0x0600AA9F RID: 43679 RVA: 0x002F9044 File Offset: 0x002F7244
			public GameObject m_loseConditionGroupGameObject
			{
				get
				{
					return this.m_owner.m_loseConditionGroupGameObject;
				}
				set
				{
					this.m_owner.m_loseConditionGroupGameObject = value;
				}
			}

			// Token: 0x17002285 RID: 8837
			// (get) Token: 0x0600AAA0 RID: 43680 RVA: 0x002F9054 File Offset: 0x002F7254
			// (set) Token: 0x0600AAA1 RID: 43681 RVA: 0x002F9064 File Offset: 0x002F7264
			public GameObject m_starConditionGroupGameObject
			{
				get
				{
					return this.m_owner.m_starConditionGroupGameObject;
				}
				set
				{
					this.m_owner.m_starConditionGroupGameObject = value;
				}
			}

			// Token: 0x17002286 RID: 8838
			// (get) Token: 0x0600AAA2 RID: 43682 RVA: 0x002F9074 File Offset: 0x002F7274
			// (set) Token: 0x0600AAA3 RID: 43683 RVA: 0x002F9084 File Offset: 0x002F7284
			public GameObject m_mapTerrainGameObject
			{
				get
				{
					return this.m_owner.m_mapTerrainGameObject;
				}
				set
				{
					this.m_owner.m_mapTerrainGameObject = value;
				}
			}

			// Token: 0x17002287 RID: 8839
			// (get) Token: 0x0600AAA4 RID: 43684 RVA: 0x002F9094 File Offset: 0x002F7294
			// (set) Token: 0x0600AAA5 RID: 43685 RVA: 0x002F90A4 File Offset: 0x002F72A4
			public GameObject m_mapRegionGameObject
			{
				get
				{
					return this.m_owner.m_mapRegionGameObject;
				}
				set
				{
					this.m_owner.m_mapRegionGameObject = value;
				}
			}

			// Token: 0x17002288 RID: 8840
			// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x002F90B4 File Offset: 0x002F72B4
			// (set) Token: 0x0600AAA7 RID: 43687 RVA: 0x002F90C4 File Offset: 0x002F72C4
			public GameObject m_mapActorGameObject
			{
				get
				{
					return this.m_owner.m_mapActorGameObject;
				}
				set
				{
					this.m_owner.m_mapActorGameObject = value;
				}
			}

			// Token: 0x17002289 RID: 8841
			// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x002F90D4 File Offset: 0x002F72D4
			// (set) Token: 0x0600AAA9 RID: 43689 RVA: 0x002F90E4 File Offset: 0x002F72E4
			public CommonUIStateController m_achievementUIStateController
			{
				get
				{
					return this.m_owner.m_achievementUIStateController;
				}
				set
				{
					this.m_owner.m_achievementUIStateController = value;
				}
			}

			// Token: 0x1700228A RID: 8842
			// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x002F90F4 File Offset: 0x002F72F4
			// (set) Token: 0x0600AAAB RID: 43691 RVA: 0x002F9104 File Offset: 0x002F7304
			public ScrollRect m_achievementScrollRect
			{
				get
				{
					return this.m_owner.m_achievementScrollRect;
				}
				set
				{
					this.m_owner.m_achievementScrollRect = value;
				}
			}

			// Token: 0x1700228B RID: 8843
			// (get) Token: 0x0600AAAC RID: 43692 RVA: 0x002F9114 File Offset: 0x002F7314
			// (set) Token: 0x0600AAAD RID: 43693 RVA: 0x002F9124 File Offset: 0x002F7324
			public Button m_achievementBackgroundButton
			{
				get
				{
					return this.m_owner.m_achievementBackgroundButton;
				}
				set
				{
					this.m_owner.m_achievementBackgroundButton = value;
				}
			}

			// Token: 0x1700228C RID: 8844
			// (get) Token: 0x0600AAAE RID: 43694 RVA: 0x002F9134 File Offset: 0x002F7334
			// (set) Token: 0x0600AAAF RID: 43695 RVA: 0x002F9144 File Offset: 0x002F7344
			public CommonUIStateController m_strategyUIStateController
			{
				get
				{
					return this.m_owner.m_strategyUIStateController;
				}
				set
				{
					this.m_owner.m_strategyUIStateController = value;
				}
			}

			// Token: 0x1700228D RID: 8845
			// (get) Token: 0x0600AAB0 RID: 43696 RVA: 0x002F9154 File Offset: 0x002F7354
			// (set) Token: 0x0600AAB1 RID: 43697 RVA: 0x002F9164 File Offset: 0x002F7364
			public Button m_strategyBackgroundButton
			{
				get
				{
					return this.m_owner.m_strategyBackgroundButton;
				}
				set
				{
					this.m_owner.m_strategyBackgroundButton = value;
				}
			}

			// Token: 0x1700228E RID: 8846
			// (get) Token: 0x0600AAB2 RID: 43698 RVA: 0x002F9174 File Offset: 0x002F7374
			// (set) Token: 0x0600AAB3 RID: 43699 RVA: 0x002F9184 File Offset: 0x002F7384
			public Text m_strategyContentText
			{
				get
				{
					return this.m_owner.m_strategyContentText;
				}
				set
				{
					this.m_owner.m_strategyContentText = value;
				}
			}

			// Token: 0x1700228F RID: 8847
			// (get) Token: 0x0600AAB4 RID: 43700 RVA: 0x002F9194 File Offset: 0x002F7394
			// (set) Token: 0x0600AAB5 RID: 43701 RVA: 0x002F91A4 File Offset: 0x002F73A4
			public GameObject m_danmakuContent
			{
				get
				{
					return this.m_owner.m_danmakuContent;
				}
				set
				{
					this.m_owner.m_danmakuContent = value;
				}
			}

			// Token: 0x17002290 RID: 8848
			// (get) Token: 0x0600AAB6 RID: 43702 RVA: 0x002F91B4 File Offset: 0x002F73B4
			// (set) Token: 0x0600AAB7 RID: 43703 RVA: 0x002F91C4 File Offset: 0x002F73C4
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

			// Token: 0x17002291 RID: 8849
			// (get) Token: 0x0600AAB8 RID: 43704 RVA: 0x002F91D4 File Offset: 0x002F73D4
			// (set) Token: 0x0600AAB9 RID: 43705 RVA: 0x002F91E4 File Offset: 0x002F73E4
			public GameObject m_mapTerrainPrefab
			{
				get
				{
					return this.m_owner.m_mapTerrainPrefab;
				}
				set
				{
					this.m_owner.m_mapTerrainPrefab = value;
				}
			}

			// Token: 0x17002292 RID: 8850
			// (get) Token: 0x0600AABA RID: 43706 RVA: 0x002F91F4 File Offset: 0x002F73F4
			// (set) Token: 0x0600AABB RID: 43707 RVA: 0x002F9204 File Offset: 0x002F7404
			public GameObject m_mapActor0Prefab
			{
				get
				{
					return this.m_owner.m_mapActor0Prefab;
				}
				set
				{
					this.m_owner.m_mapActor0Prefab = value;
				}
			}

			// Token: 0x17002293 RID: 8851
			// (get) Token: 0x0600AABC RID: 43708 RVA: 0x002F9214 File Offset: 0x002F7414
			// (set) Token: 0x0600AABD RID: 43709 RVA: 0x002F9224 File Offset: 0x002F7424
			public GameObject m_mapActor1Prefab
			{
				get
				{
					return this.m_owner.m_mapActor1Prefab;
				}
				set
				{
					this.m_owner.m_mapActor1Prefab = value;
				}
			}

			// Token: 0x17002294 RID: 8852
			// (get) Token: 0x0600AABE RID: 43710 RVA: 0x002F9234 File Offset: 0x002F7434
			// (set) Token: 0x0600AABF RID: 43711 RVA: 0x002F9244 File Offset: 0x002F7444
			public GameObject m_mapActor2Prefab
			{
				get
				{
					return this.m_owner.m_mapActor2Prefab;
				}
				set
				{
					this.m_owner.m_mapActor2Prefab = value;
				}
			}

			// Token: 0x17002295 RID: 8853
			// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x002F9254 File Offset: 0x002F7454
			// (set) Token: 0x0600AAC1 RID: 43713 RVA: 0x002F9264 File Offset: 0x002F7464
			public GameObject m_mapReachPrefab
			{
				get
				{
					return this.m_owner.m_mapReachPrefab;
				}
				set
				{
					this.m_owner.m_mapReachPrefab = value;
				}
			}

			// Token: 0x17002296 RID: 8854
			// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x002F9274 File Offset: 0x002F7474
			// (set) Token: 0x0600AAC3 RID: 43715 RVA: 0x002F9284 File Offset: 0x002F7484
			public GameObject m_conditionPrefab
			{
				get
				{
					return this.m_owner.m_conditionPrefab;
				}
				set
				{
					this.m_owner.m_conditionPrefab = value;
				}
			}

			// Token: 0x17002297 RID: 8855
			// (get) Token: 0x0600AAC4 RID: 43716 RVA: 0x002F9294 File Offset: 0x002F7494
			// (set) Token: 0x0600AAC5 RID: 43717 RVA: 0x002F92A4 File Offset: 0x002F74A4
			public GameObject m_danmakuItemPrefab
			{
				get
				{
					return this.m_owner.m_danmakuItemPrefab;
				}
				set
				{
					this.m_owner.m_danmakuItemPrefab = value;
				}
			}

			// Token: 0x17002298 RID: 8856
			// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x002F92B4 File Offset: 0x002F74B4
			// (set) Token: 0x0600AAC7 RID: 43719 RVA: 0x002F92C4 File Offset: 0x002F74C4
			public List<DanmakuItemUIController> m_danmakuItemUICtrlList
			{
				get
				{
					return this.m_owner.m_danmakuItemUICtrlList;
				}
				set
				{
					this.m_owner.m_danmakuItemUICtrlList = value;
				}
			}

			// Token: 0x17002299 RID: 8857
			// (get) Token: 0x0600AAC8 RID: 43720 RVA: 0x002F92D4 File Offset: 0x002F74D4
			// (set) Token: 0x0600AAC9 RID: 43721 RVA: 0x002F92E4 File Offset: 0x002F74E4
			public List<BattleAchievementItemUIController> m_achievementItems
			{
				get
				{
					return this.m_owner.m_achievementItems;
				}
				set
				{
					this.m_owner.m_achievementItems = value;
				}
			}

			// Token: 0x1700229A RID: 8858
			// (get) Token: 0x0600AACA RID: 43722 RVA: 0x002F92F4 File Offset: 0x002F74F4
			// (set) Token: 0x0600AACB RID: 43723 RVA: 0x002F9304 File Offset: 0x002F7504
			public int m_achievementCountMax
			{
				get
				{
					return this.m_owner.m_achievementCountMax;
				}
				set
				{
					this.m_owner.m_achievementCountMax = value;
				}
			}

			// Token: 0x1700229B RID: 8859
			// (get) Token: 0x0600AACC RID: 43724 RVA: 0x002F9314 File Offset: 0x002F7514
			// (set) Token: 0x0600AACD RID: 43725 RVA: 0x002F9324 File Offset: 0x002F7524
			public int m_mapWidth
			{
				get
				{
					return this.m_owner.m_mapWidth;
				}
				set
				{
					this.m_owner.m_mapWidth = value;
				}
			}

			// Token: 0x1700229C RID: 8860
			// (get) Token: 0x0600AACE RID: 43726 RVA: 0x002F9334 File Offset: 0x002F7534
			// (set) Token: 0x0600AACF RID: 43727 RVA: 0x002F9344 File Offset: 0x002F7544
			public int m_mapHeight
			{
				get
				{
					return this.m_owner.m_mapHeight;
				}
				set
				{
					this.m_owner.m_mapHeight = value;
				}
			}

			// Token: 0x1700229D RID: 8861
			// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x002F9354 File Offset: 0x002F7554
			// (set) Token: 0x0600AAD1 RID: 43729 RVA: 0x002F9364 File Offset: 0x002F7564
			public Vector2 m_mapTileSize
			{
				get
				{
					return this.m_owner.m_mapTileSize;
				}
				set
				{
					this.m_owner.m_mapTileSize = value;
				}
			}

			// Token: 0x1700229E RID: 8862
			// (get) Token: 0x0600AAD2 RID: 43730 RVA: 0x002F9374 File Offset: 0x002F7574
			// (set) Token: 0x0600AAD3 RID: 43731 RVA: 0x002F9384 File Offset: 0x002F7584
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x0600AAD4 RID: 43732 RVA: 0x002F9394 File Offset: 0x002F7594
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600AAD5 RID: 43733 RVA: 0x002F93A4 File Offset: 0x002F75A4
			public void SetConditionInfo(GameObject parent, string conditionStrs)
			{
				this.m_owner.SetConditionInfo(parent, conditionStrs);
			}

			// Token: 0x0600AAD6 RID: 43734 RVA: 0x002F93B4 File Offset: 0x002F75B4
			public void AddCondition(GameObject parent, string str)
			{
				this.m_owner.AddCondition(parent, str);
			}

			// Token: 0x0600AAD7 RID: 43735 RVA: 0x002F93C4 File Offset: 0x002F75C4
			public void ShowAchievement()
			{
				this.m_owner.ShowAchievement();
			}

			// Token: 0x0600AAD8 RID: 43736 RVA: 0x002F93D4 File Offset: 0x002F75D4
			public void HideAchievement()
			{
				this.m_owner.HideAchievement();
			}

			// Token: 0x0600AAD9 RID: 43737 RVA: 0x002F93E4 File Offset: 0x002F75E4
			public void AddAchievementItem(ConfigDataBattleAchievementInfo achievementInfo, List<Goods> rewards, GameObject prefab, bool complete)
			{
				this.m_owner.AddAchievementItem(achievementInfo, rewards, prefab, complete);
			}

			// Token: 0x0600AADA RID: 43738 RVA: 0x002F93F8 File Offset: 0x002F75F8
			public void ClearAchievementItems()
			{
				this.m_owner.ClearAchievementItems();
			}

			// Token: 0x0600AADB RID: 43739 RVA: 0x002F9408 File Offset: 0x002F7608
			public void ClearMap()
			{
				this.m_owner.ClearMap();
			}

			// Token: 0x0600AADC RID: 43740 RVA: 0x002F9418 File Offset: 0x002F7618
			public void CreateMapActors(List<GridPosition> positions, GameObject prefab)
			{
				this.m_owner.CreateMapActors(positions, prefab);
			}

			// Token: 0x0600AADD RID: 43741 RVA: 0x002F9428 File Offset: 0x002F7628
			public void ClearMapActors()
			{
				this.m_owner.ClearMapActors();
			}

			// Token: 0x0600AADE RID: 43742 RVA: 0x002F9438 File Offset: 0x002F7638
			public void ClearMapReachRegion()
			{
				this.m_owner.ClearMapReachRegion();
			}

			// Token: 0x0600AADF RID: 43743 RVA: 0x002F9448 File Offset: 0x002F7648
			public Vector2 GridPositionToMapPosition(int x, int y)
			{
				return this.m_owner.GridPositionToMapPosition(x, y);
			}

			// Token: 0x0600AAE0 RID: 43744 RVA: 0x002F9458 File Offset: 0x002F7658
			public void OnExitButtonClick()
			{
				this.m_owner.OnExitButtonClick();
			}

			// Token: 0x0600AAE1 RID: 43745 RVA: 0x002F9468 File Offset: 0x002F7668
			public void OnAchievementButtonClick()
			{
				this.m_owner.OnAchievementButtonClick();
			}

			// Token: 0x0600AAE2 RID: 43746 RVA: 0x002F9478 File Offset: 0x002F7678
			public void OnStrategyButtonClick()
			{
				this.m_owner.OnStrategyButtonClick();
			}

			// Token: 0x0600AAE3 RID: 43747 RVA: 0x002F9488 File Offset: 0x002F7688
			public void UpdateStrategyPanel()
			{
				this.m_owner.UpdateStrategyPanel();
			}

			// Token: 0x0600AAE4 RID: 43748 RVA: 0x002F9498 File Offset: 0x002F7698
			public IEnumerator Co_StartDanmakuItemsTweenPos()
			{
				return this.m_owner.Co_StartDanmakuItemsTweenPos();
			}

			// Token: 0x0600AAE5 RID: 43749 RVA: 0x002F94A8 File Offset: 0x002F76A8
			public void OnStrategyBackgroundButtonClick()
			{
				this.m_owner.OnStrategyBackgroundButtonClick();
			}

			// Token: 0x0600AAE6 RID: 43750 RVA: 0x002F94B8 File Offset: 0x002F76B8
			public void OnSetButtonClick()
			{
				this.m_owner.OnSetButtonClick();
			}

			// Token: 0x0600AAE7 RID: 43751 RVA: 0x002F94C8 File Offset: 0x002F76C8
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x0600AAE8 RID: 43752 RVA: 0x002F94D8 File Offset: 0x002F76D8
			public void OnAchievementBackgroundButtonClick()
			{
				this.m_owner.OnAchievementBackgroundButtonClick();
			}

			// Token: 0x0400702F RID: 28719
			private BattlePauseUIController m_owner;
		}
	}
}
