using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F57 RID: 3927
	[HotFix]
	public class CreateTeamRoomUIController : UIControllerBase
	{
		// Token: 0x06013845 RID: 79941 RVA: 0x004F9944 File Offset: 0x004F7B44
		private CreateTeamRoomUIController()
		{
		}

		// Token: 0x06013846 RID: 79942 RVA: 0x004F9978 File Offset: 0x004F7B78
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
			this.m_createButton.onClick.AddListener(new UnityAction(this.OnCreateButtonClick));
			this.m_cancelButton.onClick.AddListener(new UnityAction(this.OnCancelButtonClick));
			this.m_gameFunctionTypeScrollSnapCenter = this.m_gameFunctionTypeScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_gameFunctionTypeScrollSnapCenter.m_itemSize = 70f;
			this.m_gameFunctionTypeScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Vertical;
			this.m_gameFunctionTypeScrollSnapCenter.EventOnCenterItemChanged += this.GameFunctionTypeScrollSnapCenter_OnCenterItemChanged;
			this.m_gameFunctionTypeScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.GameFunctionTypeScrollRect_OnValueChaged));
			this.m_locationScrollSnapCenter = this.m_locationScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_locationScrollSnapCenter.m_itemSize = 70f;
			this.m_locationScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Vertical;
			this.m_locationScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.LocationScrollRect_OnValueChaged));
			this.m_playerLevelMinScrollSnapCenter = this.m_playerLevelMinScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_playerLevelMinScrollSnapCenter.m_itemSize = 70f;
			this.m_playerLevelMinScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Vertical;
			this.m_playerLevelMinScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.PlayerLevelMinScrollRect_OnValueChaged));
			this.m_playerLevelMaxScrollSnapCenter = this.m_playerLevelMaxScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_playerLevelMaxScrollSnapCenter.m_itemSize = 70f;
			this.m_playerLevelMaxScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Vertical;
			this.m_playerLevelMaxScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.PlayerLevelMaxScrollRect_OnValueChaged));
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			for (int i = 1; i <= configDataLoader.ConfigableConstId_PlayerLevelMaxLevel; i++)
			{
				this.AddPlayerLevelMinListItem(i);
				this.AddPlayerLevelMaxListItem(i);
			}
			this.m_playerLevelMinScrollSnapCenter.SetItemCount(this.m_playerLevelMinListItems.Count);
			this.m_playerLevelMaxScrollSnapCenter.SetItemCount(this.m_playerLevelMaxListItems.Count);
			this.ScaleListItem(this.m_playerLevelMinScrollRect, this.m_playerLevelMinListItems);
			this.ScaleListItem(this.m_playerLevelMaxScrollRect, this.m_playerLevelMaxListItems);
			LocalAccountConfig instance = LocalAccountConfig.Instance;
			int num = instance.Data.TeamPlayerLevelMin;
			int num2 = instance.Data.TeamPlayerLevelMax;
			if (num < 1 || num > configDataLoader.ConfigableConstId_PlayerLevelMaxLevel)
			{
				num = 1;
			}
			if (num2 < 1 || num2 > configDataLoader.ConfigableConstId_PlayerLevelMaxLevel)
			{
				num2 = configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			}
			this.SetPlayerLevelMin(num);
			this.SetPlayerLevelMax(num2);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x06013847 RID: 79943 RVA: 0x004F9C58 File Offset: 0x004F7E58
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
			this.AddGameFunctionTypeListItems();
			this.SetAuthority(TeamRoomAuthority.AllPublic);
		}

		// Token: 0x06013848 RID: 79944 RVA: 0x004F9CD8 File Offset: 0x004F7ED8
		public void Close(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", onEnd, true, true);
		}

		// Token: 0x06013849 RID: 79945 RVA: 0x004F9D5C File Offset: 0x004F7F5C
		private void AddGameFunctionTypeListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGameFunctionTypeListItems_hotfix != null)
			{
				this.m_AddGameFunctionTypeListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ClearGameFunctionTypeListItems();
			for (int i = 0; i < 2; i++)
			{
				bool flag = !projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ThearchyTrial);
				if (flag == (i == 1))
				{
					foreach (KeyValuePair<int, ConfigDataThearchyTrialInfo> keyValuePair in configDataLoader.GetAllConfigDataThearchyTrialInfo())
					{
						if (projectLPlayerContext.IsThearchyOpened(keyValuePair.Key))
						{
							this.AddGameFunctionTypeListItem(keyValuePair.Value.TeamName, GameFunctionType.GameFunctionType_ThearchyTrial, keyValuePair.Key, flag);
						}
					}
				}
				flag = !projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AnikiGym);
				if (flag == (i == 1))
				{
					foreach (KeyValuePair<int, ConfigDataAnikiGymInfo> keyValuePair2 in configDataLoader.GetAllConfigDataAnikiGymInfo())
					{
						if (projectLPlayerContext.IsAnikiGymOpened(keyValuePair2.Key))
						{
							this.AddGameFunctionTypeListItem(keyValuePair2.Value.TeamName, GameFunctionType.GameFunctionType_AnikiGym, keyValuePair2.Key, flag);
						}
					}
				}
				flag = !projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_MemoryCorridor);
				if (flag == (i == 1))
				{
					foreach (KeyValuePair<int, ConfigDataMemoryCorridorInfo> keyValuePair3 in configDataLoader.GetAllConfigDataMemoryCorridorInfo())
					{
						if (projectLPlayerContext.IsMemoryCorridorOpened(keyValuePair3.Key))
						{
							this.AddGameFunctionTypeListItem(keyValuePair3.Value.TeamName, GameFunctionType.GameFunctionType_MemoryCorridor, keyValuePair3.Key, flag);
						}
					}
				}
				flag = !projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroTrainning);
				if (flag == (i == 1))
				{
					foreach (KeyValuePair<int, ConfigDataHeroTrainningInfo> keyValuePair4 in configDataLoader.GetAllConfigDataHeroTrainningInfo())
					{
						if (projectLPlayerContext.IsHeroTrainningOpened(keyValuePair4.Key))
						{
							this.AddGameFunctionTypeListItem(keyValuePair4.Value.TeamName, GameFunctionType.GameFunctionType_HeroTrainning, keyValuePair4.Key, flag);
						}
					}
				}
				flag = !projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_CooperateBattle);
				if (flag == (i == 1))
				{
					foreach (KeyValuePair<int, ConfigDataCooperateBattleInfo> keyValuePair5 in configDataLoader.GetAllConfigDataCooperateBattleInfo())
					{
						if (projectLPlayerContext.IsCooperateBattleOpened(keyValuePair5.Key))
						{
							this.AddGameFunctionTypeListItem(keyValuePair5.Value.TeamName, GameFunctionType.GameFunctionType_CooperateBattle, keyValuePair5.Key, flag);
						}
					}
				}
				flag = !projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel);
				if (flag == (i == 1))
				{
					foreach (KeyValuePair<int, ConfigDataUnchartedScoreInfo> keyValuePair6 in configDataLoader.GetAllConfigDataUnchartedScoreInfo())
					{
						if (projectLPlayerContext.IsUnchartedScoreOpened(keyValuePair6.Key))
						{
							this.AddGameFunctionTypeListItem(keyValuePair6.Value.Name, GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel, keyValuePair6.Key, flag);
						}
					}
				}
			}
			int num = 0;
			foreach (TeamRoomInfoListItemUIController teamRoomInfoListItemUIController in this.m_gameFunctionTypeListItems)
			{
				if (!teamRoomInfoListItemUIController.IsLocked())
				{
					num++;
				}
			}
			this.m_gameFunctionTypeScrollSnapCenter.SetItemCount(num);
		}

		// Token: 0x0601384A RID: 79946 RVA: 0x004FA1A4 File Offset: 0x004F83A4
		private void ClearGameFunctionTypeListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGameFunctionTypeListItems_hotfix != null)
			{
				this.m_ClearGameFunctionTypeListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TeamRoomInfoListItemUIController>(this.m_gameFunctionTypeListItems);
			this.m_gameFunctionTypeListItems.Clear();
			this.m_gameFunctionTypeScrollSnapCenter.SetItemCount(0);
		}

		// Token: 0x0601384B RID: 79947 RVA: 0x004FA228 File Offset: 0x004F8428
		private void AddGameFunctionTypeListItem(string name, GameFunctionType gameFunctionType, int chapterId, bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGameFunctionTypeListItemStringGameFunctionTypeInt32Boolean_hotfix != null)
			{
				this.m_AddGameFunctionTypeListItemStringGameFunctionTypeInt32Boolean_hotfix.call(new object[]
				{
					this,
					name,
					gameFunctionType,
					chapterId,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int count = this.m_gameFunctionTypeListItems.Count;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_roomInfoListItemPrefab, this.m_gameFunctionTypeScrollRect.content, false);
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomInfoListItemUIController>(gameObject);
			teamRoomInfoListItemUIController.SetIndex(count);
			teamRoomInfoListItemUIController.SetText(name);
			teamRoomInfoListItemUIController.SetValue((int)gameFunctionType);
			teamRoomInfoListItemUIController.SetValue2(chapterId);
			teamRoomInfoListItemUIController.SetLocked(isLocked);
			teamRoomInfoListItemUIController.EventOnButtonClick += this.GameFunctionTypeListItem_OnButtonClick;
			this.m_gameFunctionTypeListItems.Add(teamRoomInfoListItemUIController);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_gameFunctionTypeScrollSnapCenter.ComputeItemPosition(count);
			this.ScaleListItem(this.m_gameFunctionTypeScrollRect, this.m_gameFunctionTypeListItems);
		}

		// Token: 0x0601384C RID: 79948 RVA: 0x004FA368 File Offset: 0x004F8568
		private void AddLocationListItems(GameFunctionType gameFunctionType, int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddLocationListItemsGameFunctionTypeInt32_hotfix != null)
			{
				this.m_AddLocationListItemsGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionType,
					chapterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ClearLocationListItems();
			for (int i = 0; i < 2; i++)
			{
				if (gameFunctionType == GameFunctionType.GameFunctionType_ThearchyTrial)
				{
					ConfigDataThearchyTrialInfo configDataThearchyTrialInfo = configDataLoader.GetConfigDataThearchyTrialInfo(chapterId);
					if (configDataThearchyTrialInfo != null)
					{
						foreach (ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo in configDataThearchyTrialInfo.m_levelInfos)
						{
							bool flag = projectLPlayerContext.CanUnlockTeamBattle(gameFunctionType, configDataThearchyTrialLevelInfo.ID) != 0;
							if (flag == (i == 1))
							{
								this.AddLocationListItem(configDataThearchyTrialLevelInfo.TeamName, configDataThearchyTrialLevelInfo.ID, flag);
							}
						}
					}
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_AnikiGym)
				{
					ConfigDataAnikiGymInfo configDataAnikiGymInfo = configDataLoader.GetConfigDataAnikiGymInfo(chapterId);
					if (configDataAnikiGymInfo != null)
					{
						foreach (ConfigDataAnikiLevelInfo configDataAnikiLevelInfo in configDataAnikiGymInfo.m_levelInfos)
						{
							bool flag2 = projectLPlayerContext.CanUnlockTeamBattle(gameFunctionType, configDataAnikiLevelInfo.ID) != 0;
							if (flag2 == (i == 1))
							{
								this.AddLocationListItem(configDataAnikiLevelInfo.TeamName, configDataAnikiLevelInfo.ID, flag2);
							}
						}
					}
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_MemoryCorridor)
				{
					ConfigDataMemoryCorridorInfo configDataMemoryCorridorInfo = configDataLoader.GetConfigDataMemoryCorridorInfo(chapterId);
					if (configDataMemoryCorridorInfo != null)
					{
						foreach (ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo in configDataMemoryCorridorInfo.m_levelInfos)
						{
							bool flag3 = projectLPlayerContext.CanUnlockTeamBattle(gameFunctionType, configDataMemoryCorridorLevelInfo.ID) != 0;
							if (flag3 == (i == 1))
							{
								this.AddLocationListItem(configDataMemoryCorridorLevelInfo.TeamName, configDataMemoryCorridorLevelInfo.ID, flag3);
							}
						}
					}
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_HeroTrainning)
				{
					ConfigDataHeroTrainningInfo configDataHeroTrainningInfo = configDataLoader.GetConfigDataHeroTrainningInfo(chapterId);
					if (configDataHeroTrainningInfo != null)
					{
						foreach (ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo in configDataHeroTrainningInfo.m_levelInfos)
						{
							bool flag4 = projectLPlayerContext.CanUnlockTeamBattle(gameFunctionType, configDataHeroTrainningLevelInfo.ID) != 0;
							if (flag4 == (i == 1))
							{
								this.AddLocationListItem(configDataHeroTrainningLevelInfo.TeamName, configDataHeroTrainningLevelInfo.ID, flag4);
							}
						}
					}
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_CooperateBattle)
				{
					ConfigDataCooperateBattleInfo configDataCooperateBattleInfo = configDataLoader.GetConfigDataCooperateBattleInfo(chapterId);
					if (configDataCooperateBattleInfo != null)
					{
						foreach (ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo in configDataCooperateBattleInfo.m_levelInfos)
						{
							bool flag5 = projectLPlayerContext.CanUnlockTeamBattle(gameFunctionType, configDataCooperateBattleLevelInfo.ID) != 0;
							if (flag5 == (i == 1))
							{
								this.AddLocationListItem(configDataCooperateBattleLevelInfo.TeamName, configDataCooperateBattleLevelInfo.ID, flag5);
							}
						}
					}
				}
				else if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
				{
					ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = configDataLoader.GetConfigDataUnchartedScoreInfo(chapterId);
					if (configDataUnchartedScoreInfo != null)
					{
						foreach (ConfigDataScoreLevelInfo configDataScoreLevelInfo in configDataUnchartedScoreInfo.Id2ScoreLevelInfos.Values)
						{
							if (projectLPlayerContext.IsUnchartedScoreLevelTimeUnlock(configDataUnchartedScoreInfo.ID, configDataScoreLevelInfo.ID))
							{
								bool flag6 = projectLPlayerContext.CanUnlockTeamBattle(gameFunctionType, configDataScoreLevelInfo.ID) != 0;
								if (flag6 == (i == 1))
								{
									this.AddLocationListItem(configDataScoreLevelInfo.TeamName, configDataScoreLevelInfo.ID, flag6);
								}
							}
						}
					}
				}
			}
			int num = 0;
			foreach (TeamRoomInfoListItemUIController teamRoomInfoListItemUIController in this.m_locationListItems)
			{
				if (!teamRoomInfoListItemUIController.IsLocked())
				{
					num++;
				}
			}
			this.m_locationScrollSnapCenter.SetItemCount(num);
			this.ScaleListItem(this.m_locationScrollRect, this.m_locationListItems);
		}

		// Token: 0x0601384D RID: 79949 RVA: 0x004FA85C File Offset: 0x004F8A5C
		private void ClearLocationListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearLocationListItems_hotfix != null)
			{
				this.m_ClearLocationListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TeamRoomInfoListItemUIController>(this.m_locationListItems);
			this.m_locationListItems.Clear();
			this.m_locationScrollSnapCenter.SetItemCount(0);
		}

		// Token: 0x0601384E RID: 79950 RVA: 0x004FA8E0 File Offset: 0x004F8AE0
		private void AddLocationListItem(string name, int id, bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddLocationListItemStringInt32Boolean_hotfix != null)
			{
				this.m_AddLocationListItemStringInt32Boolean_hotfix.call(new object[]
				{
					this,
					name,
					id,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int count = this.m_locationListItems.Count;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_roomInfoListItemPrefab, this.m_locationScrollRect.content, false);
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomInfoListItemUIController>(gameObject);
			teamRoomInfoListItemUIController.SetIndex(count);
			teamRoomInfoListItemUIController.SetText(name);
			teamRoomInfoListItemUIController.SetValue(id);
			teamRoomInfoListItemUIController.SetLocked(isLocked);
			teamRoomInfoListItemUIController.EventOnButtonClick += this.LocationListItem_OnButtonClick;
			this.m_locationListItems.Add(teamRoomInfoListItemUIController);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_locationScrollSnapCenter.ComputeItemPosition(count);
		}

		// Token: 0x0601384F RID: 79951 RVA: 0x004FA9F4 File Offset: 0x004F8BF4
		private void AddPlayerLevelMinListItem(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayerLevelMinListItemInt32_hotfix != null)
			{
				this.m_AddPlayerLevelMinListItemInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int count = this.m_playerLevelMinListItems.Count;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_roomInfoListItemPrefab);
			gameObject.transform.SetParent(this.m_playerLevelMinScrollRect.content, false);
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomInfoListItemUIController>(gameObject);
			teamRoomInfoListItemUIController.SetIndex(count);
			teamRoomInfoListItemUIController.SetText(level.ToString());
			teamRoomInfoListItemUIController.SetValue(level);
			teamRoomInfoListItemUIController.SetLocked(false);
			teamRoomInfoListItemUIController.EventOnButtonClick += this.PlayerLevelMinListItem_OnButtonClick;
			this.m_playerLevelMinListItems.Add(teamRoomInfoListItemUIController);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_playerLevelMinScrollSnapCenter.ComputeItemPosition(count);
		}

		// Token: 0x06013850 RID: 79952 RVA: 0x004FAB00 File Offset: 0x004F8D00
		private void ClearPlayerLevelMinListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPlayerLevelMinListItems_hotfix != null)
			{
				this.m_ClearPlayerLevelMinListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TeamRoomInfoListItemUIController>(this.m_playerLevelMinListItems);
			this.m_playerLevelMinListItems.Clear();
			this.m_playerLevelMinScrollSnapCenter.SetItemCount(0);
		}

		// Token: 0x06013851 RID: 79953 RVA: 0x004FAB84 File Offset: 0x004F8D84
		private void AddPlayerLevelMaxListItem(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayerLevelMaxListItemInt32_hotfix != null)
			{
				this.m_AddPlayerLevelMaxListItemInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int count = this.m_playerLevelMaxListItems.Count;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_roomInfoListItemPrefab, this.m_playerLevelMaxScrollRect.content, false);
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomInfoListItemUIController>(gameObject);
			teamRoomInfoListItemUIController.SetIndex(count);
			teamRoomInfoListItemUIController.SetText(level.ToString());
			teamRoomInfoListItemUIController.SetValue(level);
			teamRoomInfoListItemUIController.SetLocked(false);
			teamRoomInfoListItemUIController.EventOnButtonClick += this.PlayerLevelMaxListItem_OnButtonClick;
			this.m_playerLevelMaxListItems.Add(teamRoomInfoListItemUIController);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_playerLevelMaxScrollSnapCenter.ComputeItemPosition(count);
		}

		// Token: 0x06013852 RID: 79954 RVA: 0x004FAC84 File Offset: 0x004F8E84
		private void ClearPlayerLevelMaxListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPlayerLevelMaxListItems_hotfix != null)
			{
				this.m_ClearPlayerLevelMaxListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TeamRoomInfoListItemUIController>(this.m_playerLevelMaxListItems);
			this.m_playerLevelMaxListItems.Clear();
			this.m_playerLevelMaxScrollSnapCenter.SetItemCount(0);
		}

		// Token: 0x06013853 RID: 79955 RVA: 0x004FAD08 File Offset: 0x004F8F08
		private static int GetRoomInfoListItemIndexByValue(List<TeamRoomInfoListItemUIController> list, int value, int value2 = 0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].GetValue() == value && list[i].GetValue2() == value2)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06013854 RID: 79956 RVA: 0x004FAD54 File Offset: 0x004F8F54
		public void SetGameFunctionType(GameFunctionType gameFunctionType, int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGameFunctionTypeGameFunctionTypeInt32_hotfix != null)
			{
				this.m_SetGameFunctionTypeGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionType,
					chapterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int roomInfoListItemIndexByValue = CreateTeamRoomUIController.GetRoomInfoListItemIndexByValue(this.m_gameFunctionTypeListItems, (int)gameFunctionType, chapterId);
			if (roomInfoListItemIndexByValue >= 0)
			{
				this.m_gameFunctionTypeScrollSnapCenter.Snap(roomInfoListItemIndexByValue, false);
			}
		}

		// Token: 0x06013855 RID: 79957 RVA: 0x004FADF8 File Offset: 0x004F8FF8
		private GameFunctionType GetGameFunctionType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGameFunctionType_hotfix != null)
			{
				return (GameFunctionType)this.m_GetGameFunctionType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (GameFunctionType)this.m_gameFunctionTypeListItems[this.m_gameFunctionTypeScrollSnapCenter.GetCenterItemIndex()].GetValue();
		}

		// Token: 0x06013856 RID: 79958 RVA: 0x004FAE80 File Offset: 0x004F9080
		public void SetLocation(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLocationInt32_hotfix != null)
			{
				this.m_SetLocationInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int roomInfoListItemIndexByValue = CreateTeamRoomUIController.GetRoomInfoListItemIndexByValue(this.m_locationListItems, id, 0);
			if (roomInfoListItemIndexByValue >= 0)
			{
				this.m_locationScrollSnapCenter.Snap(roomInfoListItemIndexByValue, false);
			}
		}

		// Token: 0x06013857 RID: 79959 RVA: 0x004FAF14 File Offset: 0x004F9114
		private int GetLocationId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLocationId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLocationId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_locationListItems[this.m_locationScrollSnapCenter.GetCenterItemIndex()].GetValue();
		}

		// Token: 0x06013858 RID: 79960 RVA: 0x004FAF9C File Offset: 0x004F919C
		private void SetPlayerLevelMin(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerLevelMinInt32_hotfix != null)
			{
				this.m_SetPlayerLevelMinInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int roomInfoListItemIndexByValue = CreateTeamRoomUIController.GetRoomInfoListItemIndexByValue(this.m_playerLevelMinListItems, level, 0);
			if (roomInfoListItemIndexByValue >= 0)
			{
				this.m_playerLevelMinScrollSnapCenter.Snap(roomInfoListItemIndexByValue, false);
			}
		}

		// Token: 0x06013859 RID: 79961 RVA: 0x004FB030 File Offset: 0x004F9230
		private int GetPlayerLevelMin()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerLevelMin_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerLevelMin_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerLevelMinListItems[this.m_playerLevelMinScrollSnapCenter.GetCenterItemIndex()].GetValue();
		}

		// Token: 0x0601385A RID: 79962 RVA: 0x004FB0B8 File Offset: 0x004F92B8
		private void SetPlayerLevelMax(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerLevelMaxInt32_hotfix != null)
			{
				this.m_SetPlayerLevelMaxInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int roomInfoListItemIndexByValue = CreateTeamRoomUIController.GetRoomInfoListItemIndexByValue(this.m_playerLevelMaxListItems, level, 0);
			if (roomInfoListItemIndexByValue >= 0)
			{
				this.m_playerLevelMaxScrollSnapCenter.Snap(roomInfoListItemIndexByValue, false);
			}
		}

		// Token: 0x0601385B RID: 79963 RVA: 0x004FB14C File Offset: 0x004F934C
		private int GetPlayerLevelMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerLevelMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerLevelMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerLevelMaxListItems[this.m_playerLevelMaxScrollSnapCenter.GetCenterItemIndex()].GetValue();
		}

		// Token: 0x0601385C RID: 79964 RVA: 0x004FB1D4 File Offset: 0x004F93D4
		private void SetAuthority(TeamRoomAuthority authority)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAuthorityTeamRoomAuthority_hotfix != null)
			{
				this.m_SetAuthorityTeamRoomAuthority_hotfix.call(new object[]
				{
					this,
					authority
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_authorityAllToggle.isOn = (authority == TeamRoomAuthority.AllPublic);
			this.m_authorityFriendToggle.isOn = (authority == TeamRoomAuthority.FriendAndGuild);
			this.m_authorityNonPublicToggle.isOn = (authority == TeamRoomAuthority.NonPublic);
		}

		// Token: 0x0601385D RID: 79965 RVA: 0x004FB274 File Offset: 0x004F9474
		private TeamRoomAuthority GetAuthority()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAuthority_hotfix != null)
			{
				return (TeamRoomAuthority)this.m_GetAuthority_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomAuthority result = TeamRoomAuthority.AllPublic;
			if (this.m_authorityAllToggle.isOn)
			{
				result = TeamRoomAuthority.AllPublic;
			}
			else if (this.m_authorityFriendToggle.isOn)
			{
				result = TeamRoomAuthority.FriendAndGuild;
			}
			else if (this.m_authorityNonPublicToggle.isOn)
			{
				result = TeamRoomAuthority.NonPublic;
			}
			return result;
		}

		// Token: 0x0601385E RID: 79966 RVA: 0x004FB324 File Offset: 0x004F9524
		private void SaveTeamRoomSetting(TeamRoomSetting setting)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveTeamRoomSettingTeamRoomSetting_hotfix != null)
			{
				this.m_SaveTeamRoomSettingTeamRoomSetting_hotfix.call(new object[]
				{
					this,
					setting
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalAccountConfig instance = LocalAccountConfig.Instance;
			instance.Data.TeamPlayerLevelMin = setting.JoinMinLevel;
			instance.Data.TeamPlayerLevelMax = setting.JoinMaxLevel;
			instance.Save();
		}

		// Token: 0x0601385F RID: 79967 RVA: 0x004FB3C4 File Offset: 0x004F95C4
		private void OnCreateButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateButtonClick_hotfix != null)
			{
				this.m_OnCreateButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCreateTeamRoom != null)
			{
				TeamRoomSetting teamRoomSetting = new TeamRoomSetting();
				teamRoomSetting.GameFunctionTypeId = this.GetGameFunctionType();
				teamRoomSetting.LocationId = this.GetLocationId();
				teamRoomSetting.JoinMinLevel = this.GetPlayerLevelMin();
				teamRoomSetting.JoinMaxLevel = this.GetPlayerLevelMax();
				if (teamRoomSetting.JoinMinLevel > teamRoomSetting.JoinMaxLevel)
				{
					int joinMinLevel = teamRoomSetting.JoinMinLevel;
					teamRoomSetting.JoinMinLevel = teamRoomSetting.JoinMaxLevel;
					teamRoomSetting.JoinMaxLevel = joinMinLevel;
				}
				teamRoomSetting.Authority = this.GetAuthority();
				this.SaveTeamRoomSetting(teamRoomSetting);
				this.EventOnCreateTeamRoom(teamRoomSetting);
			}
		}

		// Token: 0x06013860 RID: 79968 RVA: 0x004FB4B0 File Offset: 0x004F96B0
		private void OnCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelButtonClick_hotfix != null)
			{
				this.m_OnCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
		}

		// Token: 0x06013861 RID: 79969 RVA: 0x004FB524 File Offset: 0x004F9724
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnCancelButtonClick();
		}

		// Token: 0x06013862 RID: 79970 RVA: 0x004FB58C File Offset: 0x004F978C
		private void GameFunctionTypeListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GameFunctionTypeListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix != null)
			{
				this.m_GameFunctionTypeListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!ctrl.IsLocked())
			{
				this.m_gameFunctionTypeScrollSnapCenter.Snap(ctrl.GetIndex(), true);
			}
		}

		// Token: 0x06013863 RID: 79971 RVA: 0x004FB61C File Offset: 0x004F981C
		private void LocationListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocationListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix != null)
			{
				this.m_LocationListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!ctrl.IsLocked())
			{
				this.m_locationScrollSnapCenter.Snap(ctrl.GetIndex(), true);
			}
		}

		// Token: 0x06013864 RID: 79972 RVA: 0x004FB6AC File Offset: 0x004F98AC
		private void PlayerLevelMinListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerLevelMinListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix != null)
			{
				this.m_PlayerLevelMinListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!ctrl.IsLocked())
			{
				this.m_playerLevelMinScrollSnapCenter.Snap(ctrl.GetIndex(), true);
			}
		}

		// Token: 0x06013865 RID: 79973 RVA: 0x004FB73C File Offset: 0x004F993C
		private void PlayerLevelMaxListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerLevelMaxListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix != null)
			{
				this.m_PlayerLevelMaxListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!ctrl.IsLocked())
			{
				this.m_playerLevelMaxScrollSnapCenter.Snap(ctrl.GetIndex(), true);
			}
		}

		// Token: 0x06013866 RID: 79974 RVA: 0x004FB7CC File Offset: 0x004F99CC
		private void GameFunctionTypeScrollSnapCenter_OnCenterItemChanged(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GameFunctionTypeScrollSnapCenter_OnCenterItemChangedInt32_hotfix != null)
			{
				this.m_GameFunctionTypeScrollSnapCenter_OnCenterItemChangedInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamRoomInfoListItemUIController teamRoomInfoListItemUIController = this.m_gameFunctionTypeListItems[idx];
			this.AddLocationListItems((GameFunctionType)teamRoomInfoListItemUIController.GetValue(), teamRoomInfoListItemUIController.GetValue2());
			int itemCount = this.m_locationScrollSnapCenter.GetItemCount();
			if (itemCount > 0 && this.m_locationScrollSnapCenter.GetCenterItemIndexUnclamped() >= itemCount)
			{
				this.m_locationScrollSnapCenter.Snap(itemCount - 1, false);
			}
		}

		// Token: 0x06013867 RID: 79975 RVA: 0x004FB890 File Offset: 0x004F9A90
		private void GameFunctionTypeScrollRect_OnValueChaged(Vector2 value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GameFunctionTypeScrollRect_OnValueChagedVector2_hotfix != null)
			{
				this.m_GameFunctionTypeScrollRect_OnValueChagedVector2_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScaleListItem(this.m_gameFunctionTypeScrollRect, this.m_gameFunctionTypeListItems);
		}

		// Token: 0x06013868 RID: 79976 RVA: 0x004FB914 File Offset: 0x004F9B14
		private void LocationScrollRect_OnValueChaged(Vector2 value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocationScrollRect_OnValueChagedVector2_hotfix != null)
			{
				this.m_LocationScrollRect_OnValueChagedVector2_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScaleListItem(this.m_locationScrollRect, this.m_locationListItems);
		}

		// Token: 0x06013869 RID: 79977 RVA: 0x004FB998 File Offset: 0x004F9B98
		private void PlayerLevelMinScrollRect_OnValueChaged(Vector2 value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerLevelMinScrollRect_OnValueChagedVector2_hotfix != null)
			{
				this.m_PlayerLevelMinScrollRect_OnValueChagedVector2_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScaleListItem(this.m_playerLevelMinScrollRect, this.m_playerLevelMinListItems);
		}

		// Token: 0x0601386A RID: 79978 RVA: 0x004FBA1C File Offset: 0x004F9C1C
		private void PlayerLevelMaxScrollRect_OnValueChaged(Vector2 value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerLevelMaxScrollRect_OnValueChagedVector2_hotfix != null)
			{
				this.m_PlayerLevelMaxScrollRect_OnValueChagedVector2_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScaleListItem(this.m_playerLevelMaxScrollRect, this.m_playerLevelMaxListItems);
		}

		// Token: 0x0601386B RID: 79979 RVA: 0x004FBAA0 File Offset: 0x004F9CA0
		private void ScaleListItem(ScrollRect scrollRect, List<TeamRoomInfoListItemUIController> listItems)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScaleListItemScrollRectList`1_hotfix != null)
			{
				this.m_ScaleListItemScrollRectList`1_hotfix.call(new object[]
				{
					this,
					scrollRect,
					listItems
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Camera componentInParent = base.GetComponentInParent<Camera>();
			if (componentInParent == null)
			{
				return;
			}
			Vector2 center = scrollRect.viewport.rect.center;
			foreach (TeamRoomInfoListItemUIController teamRoomInfoListItemUIController in listItems)
			{
				float num = Mathf.Abs(UIUtility.WorldToLocalPosition(teamRoomInfoListItemUIController.transform.position, componentInParent, scrollRect.viewport, componentInParent).y - center.y);
				float num2 = Mathf.Clamp01((150f - num) / 150f);
				float num3 = num2 * 0.2f + 0.8f;
				teamRoomInfoListItemUIController.SetTextAlpha(num2 * 0.6f + 0.4f);
				RectTransform rectTransform = teamRoomInfoListItemUIController.transform as RectTransform;
				rectTransform.localScale = new Vector3(num3, num3, num3);
			}
		}

		// Token: 0x14000442 RID: 1090
		// (add) Token: 0x0601386C RID: 79980 RVA: 0x004FBC14 File Offset: 0x004F9E14
		// (remove) Token: 0x0601386D RID: 79981 RVA: 0x004FBCB0 File Offset: 0x004F9EB0
		public event Action<TeamRoomSetting> EventOnCreateTeamRoom
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCreateTeamRoomAction`1_hotfix != null)
				{
					this.m_add_EventOnCreateTeamRoomAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomSetting> action = this.EventOnCreateTeamRoom;
				Action<TeamRoomSetting> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomSetting>>(ref this.EventOnCreateTeamRoom, (Action<TeamRoomSetting>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCreateTeamRoomAction`1_hotfix != null)
				{
					this.m_remove_EventOnCreateTeamRoomAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomSetting> action = this.EventOnCreateTeamRoom;
				Action<TeamRoomSetting> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomSetting>>(ref this.EventOnCreateTeamRoom, (Action<TeamRoomSetting>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0601386E RID: 79982 RVA: 0x004FBD4C File Offset: 0x004F9F4C
		// (set) Token: 0x0601386F RID: 79983 RVA: 0x004FBD6C File Offset: 0x004F9F6C
		[DoNotToLua]
		public new CreateTeamRoomUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CreateTeamRoomUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013870 RID: 79984 RVA: 0x004FBD78 File Offset: 0x004F9F78
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013871 RID: 79985 RVA: 0x004FBD84 File Offset: 0x004F9F84
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013872 RID: 79986 RVA: 0x004FBD8C File Offset: 0x004F9F8C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013873 RID: 79987 RVA: 0x004FBD94 File Offset: 0x004F9F94
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013874 RID: 79988 RVA: 0x004FBDA8 File Offset: 0x004F9FA8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013875 RID: 79989 RVA: 0x004FBDB0 File Offset: 0x004F9FB0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013876 RID: 79990 RVA: 0x004FBDBC File Offset: 0x004F9FBC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013877 RID: 79991 RVA: 0x004FBDC8 File Offset: 0x004F9FC8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013878 RID: 79992 RVA: 0x004FBDD4 File Offset: 0x004F9FD4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013879 RID: 79993 RVA: 0x004FBDE0 File Offset: 0x004F9FE0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601387A RID: 79994 RVA: 0x004FBDEC File Offset: 0x004F9FEC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601387B RID: 79995 RVA: 0x004FBDF8 File Offset: 0x004F9FF8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601387C RID: 79996 RVA: 0x004FBE04 File Offset: 0x004FA004
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601387D RID: 79997 RVA: 0x004FBE10 File Offset: 0x004FA010
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601387E RID: 79998 RVA: 0x004FBE1C File Offset: 0x004FA01C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601387F RID: 79999 RVA: 0x004FBE24 File Offset: 0x004FA024
		private void __callDele_EventOnCreateTeamRoom(TeamRoomSetting obj)
		{
			Action<TeamRoomSetting> eventOnCreateTeamRoom = this.EventOnCreateTeamRoom;
			if (eventOnCreateTeamRoom != null)
			{
				eventOnCreateTeamRoom(obj);
			}
		}

		// Token: 0x06013880 RID: 80000 RVA: 0x004FBE48 File Offset: 0x004FA048
		private void __clearDele_EventOnCreateTeamRoom(TeamRoomSetting obj)
		{
			this.EventOnCreateTeamRoom = null;
		}

		// Token: 0x06013881 RID: 80001 RVA: 0x004FBE54 File Offset: 0x004FA054
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
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_AddGameFunctionTypeListItems_hotfix = (luaObj.RawGet("AddGameFunctionTypeListItems") as LuaFunction);
					this.m_ClearGameFunctionTypeListItems_hotfix = (luaObj.RawGet("ClearGameFunctionTypeListItems") as LuaFunction);
					this.m_AddGameFunctionTypeListItemStringGameFunctionTypeInt32Boolean_hotfix = (luaObj.RawGet("AddGameFunctionTypeListItem") as LuaFunction);
					this.m_AddLocationListItemsGameFunctionTypeInt32_hotfix = (luaObj.RawGet("AddLocationListItems") as LuaFunction);
					this.m_ClearLocationListItems_hotfix = (luaObj.RawGet("ClearLocationListItems") as LuaFunction);
					this.m_AddLocationListItemStringInt32Boolean_hotfix = (luaObj.RawGet("AddLocationListItem") as LuaFunction);
					this.m_AddPlayerLevelMinListItemInt32_hotfix = (luaObj.RawGet("AddPlayerLevelMinListItem") as LuaFunction);
					this.m_ClearPlayerLevelMinListItems_hotfix = (luaObj.RawGet("ClearPlayerLevelMinListItems") as LuaFunction);
					this.m_AddPlayerLevelMaxListItemInt32_hotfix = (luaObj.RawGet("AddPlayerLevelMaxListItem") as LuaFunction);
					this.m_ClearPlayerLevelMaxListItems_hotfix = (luaObj.RawGet("ClearPlayerLevelMaxListItems") as LuaFunction);
					this.m_SetGameFunctionTypeGameFunctionTypeInt32_hotfix = (luaObj.RawGet("SetGameFunctionType") as LuaFunction);
					this.m_GetGameFunctionType_hotfix = (luaObj.RawGet("GetGameFunctionType") as LuaFunction);
					this.m_SetLocationInt32_hotfix = (luaObj.RawGet("SetLocation") as LuaFunction);
					this.m_GetLocationId_hotfix = (luaObj.RawGet("GetLocationId") as LuaFunction);
					this.m_SetPlayerLevelMinInt32_hotfix = (luaObj.RawGet("SetPlayerLevelMin") as LuaFunction);
					this.m_GetPlayerLevelMin_hotfix = (luaObj.RawGet("GetPlayerLevelMin") as LuaFunction);
					this.m_SetPlayerLevelMaxInt32_hotfix = (luaObj.RawGet("SetPlayerLevelMax") as LuaFunction);
					this.m_GetPlayerLevelMax_hotfix = (luaObj.RawGet("GetPlayerLevelMax") as LuaFunction);
					this.m_SetAuthorityTeamRoomAuthority_hotfix = (luaObj.RawGet("SetAuthority") as LuaFunction);
					this.m_GetAuthority_hotfix = (luaObj.RawGet("GetAuthority") as LuaFunction);
					this.m_SaveTeamRoomSettingTeamRoomSetting_hotfix = (luaObj.RawGet("SaveTeamRoomSetting") as LuaFunction);
					this.m_OnCreateButtonClick_hotfix = (luaObj.RawGet("OnCreateButtonClick") as LuaFunction);
					this.m_OnCancelButtonClick_hotfix = (luaObj.RawGet("OnCancelButtonClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_GameFunctionTypeListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix = (luaObj.RawGet("GameFunctionTypeListItem_OnButtonClick") as LuaFunction);
					this.m_LocationListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix = (luaObj.RawGet("LocationListItem_OnButtonClick") as LuaFunction);
					this.m_PlayerLevelMinListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix = (luaObj.RawGet("PlayerLevelMinListItem_OnButtonClick") as LuaFunction);
					this.m_PlayerLevelMaxListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix = (luaObj.RawGet("PlayerLevelMaxListItem_OnButtonClick") as LuaFunction);
					this.m_GameFunctionTypeScrollSnapCenter_OnCenterItemChangedInt32_hotfix = (luaObj.RawGet("GameFunctionTypeScrollSnapCenter_OnCenterItemChanged") as LuaFunction);
					this.m_GameFunctionTypeScrollRect_OnValueChagedVector2_hotfix = (luaObj.RawGet("GameFunctionTypeScrollRect_OnValueChaged") as LuaFunction);
					this.m_LocationScrollRect_OnValueChagedVector2_hotfix = (luaObj.RawGet("LocationScrollRect_OnValueChaged") as LuaFunction);
					this.m_PlayerLevelMinScrollRect_OnValueChagedVector2_hotfix = (luaObj.RawGet("PlayerLevelMinScrollRect_OnValueChaged") as LuaFunction);
					this.m_PlayerLevelMaxScrollRect_OnValueChagedVector2_hotfix = (luaObj.RawGet("PlayerLevelMaxScrollRect_OnValueChaged") as LuaFunction);
					this.m_ScaleListItemScrollRectList`1_hotfix = (luaObj.RawGet("ScaleListItem") as LuaFunction);
					this.m_add_EventOnCreateTeamRoomAction`1_hotfix = (luaObj.RawGet("add_EventOnCreateTeamRoom") as LuaFunction);
					this.m_remove_EventOnCreateTeamRoomAction`1_hotfix = (luaObj.RawGet("remove_EventOnCreateTeamRoom") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013882 RID: 80002 RVA: 0x004FC2D8 File Offset: 0x004FA4D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CreateTeamRoomUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AD58 RID: 44376
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AD59 RID: 44377
		[AutoBind("./Panel/CreateButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_createButton;

		// Token: 0x0400AD5A RID: 44378
		[AutoBind("./Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelButton;

		// Token: 0x0400AD5B RID: 44379
		[AutoBind("./Panel/AuthorityToggle/AllPeopleToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_authorityAllToggle;

		// Token: 0x0400AD5C RID: 44380
		[AutoBind("./Panel/AuthorityToggle/FriendAndGuildToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_authorityFriendToggle;

		// Token: 0x0400AD5D RID: 44381
		[AutoBind("./Panel/AuthorityToggle/NotpublicToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_authorityNonPublicToggle;

		// Token: 0x0400AD5E RID: 44382
		[AutoBind("./Panel/Info/GameFunctionType/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_gameFunctionTypeScrollRect;

		// Token: 0x0400AD5F RID: 44383
		[AutoBind("./Panel/Info/Location/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_locationScrollRect;

		// Token: 0x0400AD60 RID: 44384
		[AutoBind("./Panel/Info/PlayerLevel/LeftScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_playerLevelMinScrollRect;

		// Token: 0x0400AD61 RID: 44385
		[AutoBind("./Panel/Info/PlayerLevel/RightScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_playerLevelMaxScrollRect;

		// Token: 0x0400AD62 RID: 44386
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400AD63 RID: 44387
		[AutoBind("./Prefabs/RoomInfoListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_roomInfoListItemPrefab;

		// Token: 0x0400AD64 RID: 44388
		private ScrollSnapCenter m_gameFunctionTypeScrollSnapCenter;

		// Token: 0x0400AD65 RID: 44389
		private ScrollSnapCenter m_locationScrollSnapCenter;

		// Token: 0x0400AD66 RID: 44390
		private ScrollSnapCenter m_playerLevelMinScrollSnapCenter;

		// Token: 0x0400AD67 RID: 44391
		private ScrollSnapCenter m_playerLevelMaxScrollSnapCenter;

		// Token: 0x0400AD68 RID: 44392
		private List<TeamRoomInfoListItemUIController> m_gameFunctionTypeListItems = new List<TeamRoomInfoListItemUIController>();

		// Token: 0x0400AD69 RID: 44393
		private List<TeamRoomInfoListItemUIController> m_locationListItems = new List<TeamRoomInfoListItemUIController>();

		// Token: 0x0400AD6A RID: 44394
		private List<TeamRoomInfoListItemUIController> m_playerLevelMinListItems = new List<TeamRoomInfoListItemUIController>();

		// Token: 0x0400AD6B RID: 44395
		private List<TeamRoomInfoListItemUIController> m_playerLevelMaxListItems = new List<TeamRoomInfoListItemUIController>();

		// Token: 0x0400AD6C RID: 44396
		[DoNotToLua]
		private CreateTeamRoomUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AD6D RID: 44397
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AD6E RID: 44398
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AD6F RID: 44399
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AD70 RID: 44400
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400AD71 RID: 44401
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x0400AD72 RID: 44402
		private LuaFunction m_AddGameFunctionTypeListItems_hotfix;

		// Token: 0x0400AD73 RID: 44403
		private LuaFunction m_ClearGameFunctionTypeListItems_hotfix;

		// Token: 0x0400AD74 RID: 44404
		private LuaFunction m_AddGameFunctionTypeListItemStringGameFunctionTypeInt32Boolean_hotfix;

		// Token: 0x0400AD75 RID: 44405
		private LuaFunction m_AddLocationListItemsGameFunctionTypeInt32_hotfix;

		// Token: 0x0400AD76 RID: 44406
		private LuaFunction m_ClearLocationListItems_hotfix;

		// Token: 0x0400AD77 RID: 44407
		private LuaFunction m_AddLocationListItemStringInt32Boolean_hotfix;

		// Token: 0x0400AD78 RID: 44408
		private LuaFunction m_AddPlayerLevelMinListItemInt32_hotfix;

		// Token: 0x0400AD79 RID: 44409
		private LuaFunction m_ClearPlayerLevelMinListItems_hotfix;

		// Token: 0x0400AD7A RID: 44410
		private LuaFunction m_AddPlayerLevelMaxListItemInt32_hotfix;

		// Token: 0x0400AD7B RID: 44411
		private LuaFunction m_ClearPlayerLevelMaxListItems_hotfix;

		// Token: 0x0400AD7C RID: 44412
		private LuaFunction m_SetGameFunctionTypeGameFunctionTypeInt32_hotfix;

		// Token: 0x0400AD7D RID: 44413
		private LuaFunction m_GetGameFunctionType_hotfix;

		// Token: 0x0400AD7E RID: 44414
		private LuaFunction m_SetLocationInt32_hotfix;

		// Token: 0x0400AD7F RID: 44415
		private LuaFunction m_GetLocationId_hotfix;

		// Token: 0x0400AD80 RID: 44416
		private LuaFunction m_SetPlayerLevelMinInt32_hotfix;

		// Token: 0x0400AD81 RID: 44417
		private LuaFunction m_GetPlayerLevelMin_hotfix;

		// Token: 0x0400AD82 RID: 44418
		private LuaFunction m_SetPlayerLevelMaxInt32_hotfix;

		// Token: 0x0400AD83 RID: 44419
		private LuaFunction m_GetPlayerLevelMax_hotfix;

		// Token: 0x0400AD84 RID: 44420
		private LuaFunction m_SetAuthorityTeamRoomAuthority_hotfix;

		// Token: 0x0400AD85 RID: 44421
		private LuaFunction m_GetAuthority_hotfix;

		// Token: 0x0400AD86 RID: 44422
		private LuaFunction m_SaveTeamRoomSettingTeamRoomSetting_hotfix;

		// Token: 0x0400AD87 RID: 44423
		private LuaFunction m_OnCreateButtonClick_hotfix;

		// Token: 0x0400AD88 RID: 44424
		private LuaFunction m_OnCancelButtonClick_hotfix;

		// Token: 0x0400AD89 RID: 44425
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400AD8A RID: 44426
		private LuaFunction m_GameFunctionTypeListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix;

		// Token: 0x0400AD8B RID: 44427
		private LuaFunction m_LocationListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix;

		// Token: 0x0400AD8C RID: 44428
		private LuaFunction m_PlayerLevelMinListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix;

		// Token: 0x0400AD8D RID: 44429
		private LuaFunction m_PlayerLevelMaxListItem_OnButtonClickTeamRoomInfoListItemUIController_hotfix;

		// Token: 0x0400AD8E RID: 44430
		private LuaFunction m_GameFunctionTypeScrollSnapCenter_OnCenterItemChangedInt32_hotfix;

		// Token: 0x0400AD8F RID: 44431
		private LuaFunction m_GameFunctionTypeScrollRect_OnValueChagedVector2_hotfix;

		// Token: 0x0400AD90 RID: 44432
		private LuaFunction m_LocationScrollRect_OnValueChagedVector2_hotfix;

		// Token: 0x0400AD91 RID: 44433
		private LuaFunction m_PlayerLevelMinScrollRect_OnValueChagedVector2_hotfix;

		// Token: 0x0400AD92 RID: 44434
		private LuaFunction m_PlayerLevelMaxScrollRect_OnValueChagedVector2_hotfix;

		// Token: 0x0400AD93 RID: 44435
		private LuaFunction m_ScaleListItemScrollRectList;

		// Token: 0x0400AD94 RID: 44436
		private LuaFunction m_add_EventOnCreateTeamRoomAction;

		// Token: 0x0400AD95 RID: 44437
		private LuaFunction m_remove_EventOnCreateTeamRoomAction;

		// Token: 0x02000F58 RID: 3928
		public new class LuaExportHelper
		{
			// Token: 0x06013883 RID: 80003 RVA: 0x004FC340 File Offset: 0x004FA540
			public LuaExportHelper(CreateTeamRoomUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013884 RID: 80004 RVA: 0x004FC350 File Offset: 0x004FA550
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013885 RID: 80005 RVA: 0x004FC360 File Offset: 0x004FA560
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013886 RID: 80006 RVA: 0x004FC370 File Offset: 0x004FA570
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013887 RID: 80007 RVA: 0x004FC380 File Offset: 0x004FA580
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013888 RID: 80008 RVA: 0x004FC398 File Offset: 0x004FA598
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013889 RID: 80009 RVA: 0x004FC3A8 File Offset: 0x004FA5A8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601388A RID: 80010 RVA: 0x004FC3B8 File Offset: 0x004FA5B8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601388B RID: 80011 RVA: 0x004FC3C8 File Offset: 0x004FA5C8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601388C RID: 80012 RVA: 0x004FC3D8 File Offset: 0x004FA5D8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601388D RID: 80013 RVA: 0x004FC3E8 File Offset: 0x004FA5E8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601388E RID: 80014 RVA: 0x004FC3F8 File Offset: 0x004FA5F8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601388F RID: 80015 RVA: 0x004FC408 File Offset: 0x004FA608
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013890 RID: 80016 RVA: 0x004FC418 File Offset: 0x004FA618
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013891 RID: 80017 RVA: 0x004FC428 File Offset: 0x004FA628
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013892 RID: 80018 RVA: 0x004FC438 File Offset: 0x004FA638
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013893 RID: 80019 RVA: 0x004FC448 File Offset: 0x004FA648
			public void __callDele_EventOnCreateTeamRoom(TeamRoomSetting obj)
			{
				this.m_owner.__callDele_EventOnCreateTeamRoom(obj);
			}

			// Token: 0x06013894 RID: 80020 RVA: 0x004FC458 File Offset: 0x004FA658
			public void __clearDele_EventOnCreateTeamRoom(TeamRoomSetting obj)
			{
				this.m_owner.__clearDele_EventOnCreateTeamRoom(obj);
			}

			// Token: 0x17003AAA RID: 15018
			// (get) Token: 0x06013895 RID: 80021 RVA: 0x004FC468 File Offset: 0x004FA668
			// (set) Token: 0x06013896 RID: 80022 RVA: 0x004FC478 File Offset: 0x004FA678
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

			// Token: 0x17003AAB RID: 15019
			// (get) Token: 0x06013897 RID: 80023 RVA: 0x004FC488 File Offset: 0x004FA688
			// (set) Token: 0x06013898 RID: 80024 RVA: 0x004FC498 File Offset: 0x004FA698
			public Button m_createButton
			{
				get
				{
					return this.m_owner.m_createButton;
				}
				set
				{
					this.m_owner.m_createButton = value;
				}
			}

			// Token: 0x17003AAC RID: 15020
			// (get) Token: 0x06013899 RID: 80025 RVA: 0x004FC4A8 File Offset: 0x004FA6A8
			// (set) Token: 0x0601389A RID: 80026 RVA: 0x004FC4B8 File Offset: 0x004FA6B8
			public Button m_cancelButton
			{
				get
				{
					return this.m_owner.m_cancelButton;
				}
				set
				{
					this.m_owner.m_cancelButton = value;
				}
			}

			// Token: 0x17003AAD RID: 15021
			// (get) Token: 0x0601389B RID: 80027 RVA: 0x004FC4C8 File Offset: 0x004FA6C8
			// (set) Token: 0x0601389C RID: 80028 RVA: 0x004FC4D8 File Offset: 0x004FA6D8
			public Toggle m_authorityAllToggle
			{
				get
				{
					return this.m_owner.m_authorityAllToggle;
				}
				set
				{
					this.m_owner.m_authorityAllToggle = value;
				}
			}

			// Token: 0x17003AAE RID: 15022
			// (get) Token: 0x0601389D RID: 80029 RVA: 0x004FC4E8 File Offset: 0x004FA6E8
			// (set) Token: 0x0601389E RID: 80030 RVA: 0x004FC4F8 File Offset: 0x004FA6F8
			public Toggle m_authorityFriendToggle
			{
				get
				{
					return this.m_owner.m_authorityFriendToggle;
				}
				set
				{
					this.m_owner.m_authorityFriendToggle = value;
				}
			}

			// Token: 0x17003AAF RID: 15023
			// (get) Token: 0x0601389F RID: 80031 RVA: 0x004FC508 File Offset: 0x004FA708
			// (set) Token: 0x060138A0 RID: 80032 RVA: 0x004FC518 File Offset: 0x004FA718
			public Toggle m_authorityNonPublicToggle
			{
				get
				{
					return this.m_owner.m_authorityNonPublicToggle;
				}
				set
				{
					this.m_owner.m_authorityNonPublicToggle = value;
				}
			}

			// Token: 0x17003AB0 RID: 15024
			// (get) Token: 0x060138A1 RID: 80033 RVA: 0x004FC528 File Offset: 0x004FA728
			// (set) Token: 0x060138A2 RID: 80034 RVA: 0x004FC538 File Offset: 0x004FA738
			public ScrollRect m_gameFunctionTypeScrollRect
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeScrollRect;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeScrollRect = value;
				}
			}

			// Token: 0x17003AB1 RID: 15025
			// (get) Token: 0x060138A3 RID: 80035 RVA: 0x004FC548 File Offset: 0x004FA748
			// (set) Token: 0x060138A4 RID: 80036 RVA: 0x004FC558 File Offset: 0x004FA758
			public ScrollRect m_locationScrollRect
			{
				get
				{
					return this.m_owner.m_locationScrollRect;
				}
				set
				{
					this.m_owner.m_locationScrollRect = value;
				}
			}

			// Token: 0x17003AB2 RID: 15026
			// (get) Token: 0x060138A5 RID: 80037 RVA: 0x004FC568 File Offset: 0x004FA768
			// (set) Token: 0x060138A6 RID: 80038 RVA: 0x004FC578 File Offset: 0x004FA778
			public ScrollRect m_playerLevelMinScrollRect
			{
				get
				{
					return this.m_owner.m_playerLevelMinScrollRect;
				}
				set
				{
					this.m_owner.m_playerLevelMinScrollRect = value;
				}
			}

			// Token: 0x17003AB3 RID: 15027
			// (get) Token: 0x060138A7 RID: 80039 RVA: 0x004FC588 File Offset: 0x004FA788
			// (set) Token: 0x060138A8 RID: 80040 RVA: 0x004FC598 File Offset: 0x004FA798
			public ScrollRect m_playerLevelMaxScrollRect
			{
				get
				{
					return this.m_owner.m_playerLevelMaxScrollRect;
				}
				set
				{
					this.m_owner.m_playerLevelMaxScrollRect = value;
				}
			}

			// Token: 0x17003AB4 RID: 15028
			// (get) Token: 0x060138A9 RID: 80041 RVA: 0x004FC5A8 File Offset: 0x004FA7A8
			// (set) Token: 0x060138AA RID: 80042 RVA: 0x004FC5B8 File Offset: 0x004FA7B8
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

			// Token: 0x17003AB5 RID: 15029
			// (get) Token: 0x060138AB RID: 80043 RVA: 0x004FC5C8 File Offset: 0x004FA7C8
			// (set) Token: 0x060138AC RID: 80044 RVA: 0x004FC5D8 File Offset: 0x004FA7D8
			public GameObject m_roomInfoListItemPrefab
			{
				get
				{
					return this.m_owner.m_roomInfoListItemPrefab;
				}
				set
				{
					this.m_owner.m_roomInfoListItemPrefab = value;
				}
			}

			// Token: 0x17003AB6 RID: 15030
			// (get) Token: 0x060138AD RID: 80045 RVA: 0x004FC5E8 File Offset: 0x004FA7E8
			// (set) Token: 0x060138AE RID: 80046 RVA: 0x004FC5F8 File Offset: 0x004FA7F8
			public ScrollSnapCenter m_gameFunctionTypeScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeScrollSnapCenter = value;
				}
			}

			// Token: 0x17003AB7 RID: 15031
			// (get) Token: 0x060138AF RID: 80047 RVA: 0x004FC608 File Offset: 0x004FA808
			// (set) Token: 0x060138B0 RID: 80048 RVA: 0x004FC618 File Offset: 0x004FA818
			public ScrollSnapCenter m_locationScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_locationScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_locationScrollSnapCenter = value;
				}
			}

			// Token: 0x17003AB8 RID: 15032
			// (get) Token: 0x060138B1 RID: 80049 RVA: 0x004FC628 File Offset: 0x004FA828
			// (set) Token: 0x060138B2 RID: 80050 RVA: 0x004FC638 File Offset: 0x004FA838
			public ScrollSnapCenter m_playerLevelMinScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_playerLevelMinScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_playerLevelMinScrollSnapCenter = value;
				}
			}

			// Token: 0x17003AB9 RID: 15033
			// (get) Token: 0x060138B3 RID: 80051 RVA: 0x004FC648 File Offset: 0x004FA848
			// (set) Token: 0x060138B4 RID: 80052 RVA: 0x004FC658 File Offset: 0x004FA858
			public ScrollSnapCenter m_playerLevelMaxScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_playerLevelMaxScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_playerLevelMaxScrollSnapCenter = value;
				}
			}

			// Token: 0x17003ABA RID: 15034
			// (get) Token: 0x060138B5 RID: 80053 RVA: 0x004FC668 File Offset: 0x004FA868
			// (set) Token: 0x060138B6 RID: 80054 RVA: 0x004FC678 File Offset: 0x004FA878
			public List<TeamRoomInfoListItemUIController> m_gameFunctionTypeListItems
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeListItems;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeListItems = value;
				}
			}

			// Token: 0x17003ABB RID: 15035
			// (get) Token: 0x060138B7 RID: 80055 RVA: 0x004FC688 File Offset: 0x004FA888
			// (set) Token: 0x060138B8 RID: 80056 RVA: 0x004FC698 File Offset: 0x004FA898
			public List<TeamRoomInfoListItemUIController> m_locationListItems
			{
				get
				{
					return this.m_owner.m_locationListItems;
				}
				set
				{
					this.m_owner.m_locationListItems = value;
				}
			}

			// Token: 0x17003ABC RID: 15036
			// (get) Token: 0x060138B9 RID: 80057 RVA: 0x004FC6A8 File Offset: 0x004FA8A8
			// (set) Token: 0x060138BA RID: 80058 RVA: 0x004FC6B8 File Offset: 0x004FA8B8
			public List<TeamRoomInfoListItemUIController> m_playerLevelMinListItems
			{
				get
				{
					return this.m_owner.m_playerLevelMinListItems;
				}
				set
				{
					this.m_owner.m_playerLevelMinListItems = value;
				}
			}

			// Token: 0x17003ABD RID: 15037
			// (get) Token: 0x060138BB RID: 80059 RVA: 0x004FC6C8 File Offset: 0x004FA8C8
			// (set) Token: 0x060138BC RID: 80060 RVA: 0x004FC6D8 File Offset: 0x004FA8D8
			public List<TeamRoomInfoListItemUIController> m_playerLevelMaxListItems
			{
				get
				{
					return this.m_owner.m_playerLevelMaxListItems;
				}
				set
				{
					this.m_owner.m_playerLevelMaxListItems = value;
				}
			}

			// Token: 0x060138BD RID: 80061 RVA: 0x004FC6E8 File Offset: 0x004FA8E8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060138BE RID: 80062 RVA: 0x004FC6F8 File Offset: 0x004FA8F8
			public void AddGameFunctionTypeListItems()
			{
				this.m_owner.AddGameFunctionTypeListItems();
			}

			// Token: 0x060138BF RID: 80063 RVA: 0x004FC708 File Offset: 0x004FA908
			public void ClearGameFunctionTypeListItems()
			{
				this.m_owner.ClearGameFunctionTypeListItems();
			}

			// Token: 0x060138C0 RID: 80064 RVA: 0x004FC718 File Offset: 0x004FA918
			public void AddGameFunctionTypeListItem(string name, GameFunctionType gameFunctionType, int chapterId, bool isLocked)
			{
				this.m_owner.AddGameFunctionTypeListItem(name, gameFunctionType, chapterId, isLocked);
			}

			// Token: 0x060138C1 RID: 80065 RVA: 0x004FC72C File Offset: 0x004FA92C
			public void AddLocationListItems(GameFunctionType gameFunctionType, int chapterId)
			{
				this.m_owner.AddLocationListItems(gameFunctionType, chapterId);
			}

			// Token: 0x060138C2 RID: 80066 RVA: 0x004FC73C File Offset: 0x004FA93C
			public void ClearLocationListItems()
			{
				this.m_owner.ClearLocationListItems();
			}

			// Token: 0x060138C3 RID: 80067 RVA: 0x004FC74C File Offset: 0x004FA94C
			public void AddLocationListItem(string name, int id, bool isLocked)
			{
				this.m_owner.AddLocationListItem(name, id, isLocked);
			}

			// Token: 0x060138C4 RID: 80068 RVA: 0x004FC75C File Offset: 0x004FA95C
			public void AddPlayerLevelMinListItem(int level)
			{
				this.m_owner.AddPlayerLevelMinListItem(level);
			}

			// Token: 0x060138C5 RID: 80069 RVA: 0x004FC76C File Offset: 0x004FA96C
			public void ClearPlayerLevelMinListItems()
			{
				this.m_owner.ClearPlayerLevelMinListItems();
			}

			// Token: 0x060138C6 RID: 80070 RVA: 0x004FC77C File Offset: 0x004FA97C
			public void AddPlayerLevelMaxListItem(int level)
			{
				this.m_owner.AddPlayerLevelMaxListItem(level);
			}

			// Token: 0x060138C7 RID: 80071 RVA: 0x004FC78C File Offset: 0x004FA98C
			public void ClearPlayerLevelMaxListItems()
			{
				this.m_owner.ClearPlayerLevelMaxListItems();
			}

			// Token: 0x060138C8 RID: 80072 RVA: 0x004FC79C File Offset: 0x004FA99C
			public static int GetRoomInfoListItemIndexByValue(List<TeamRoomInfoListItemUIController> list, int value, int value2)
			{
				return CreateTeamRoomUIController.GetRoomInfoListItemIndexByValue(list, value, value2);
			}

			// Token: 0x060138C9 RID: 80073 RVA: 0x004FC7A8 File Offset: 0x004FA9A8
			public GameFunctionType GetGameFunctionType()
			{
				return this.m_owner.GetGameFunctionType();
			}

			// Token: 0x060138CA RID: 80074 RVA: 0x004FC7B8 File Offset: 0x004FA9B8
			public int GetLocationId()
			{
				return this.m_owner.GetLocationId();
			}

			// Token: 0x060138CB RID: 80075 RVA: 0x004FC7C8 File Offset: 0x004FA9C8
			public void SetPlayerLevelMin(int level)
			{
				this.m_owner.SetPlayerLevelMin(level);
			}

			// Token: 0x060138CC RID: 80076 RVA: 0x004FC7D8 File Offset: 0x004FA9D8
			public int GetPlayerLevelMin()
			{
				return this.m_owner.GetPlayerLevelMin();
			}

			// Token: 0x060138CD RID: 80077 RVA: 0x004FC7E8 File Offset: 0x004FA9E8
			public void SetPlayerLevelMax(int level)
			{
				this.m_owner.SetPlayerLevelMax(level);
			}

			// Token: 0x060138CE RID: 80078 RVA: 0x004FC7F8 File Offset: 0x004FA9F8
			public int GetPlayerLevelMax()
			{
				return this.m_owner.GetPlayerLevelMax();
			}

			// Token: 0x060138CF RID: 80079 RVA: 0x004FC808 File Offset: 0x004FAA08
			public void SetAuthority(TeamRoomAuthority authority)
			{
				this.m_owner.SetAuthority(authority);
			}

			// Token: 0x060138D0 RID: 80080 RVA: 0x004FC818 File Offset: 0x004FAA18
			public TeamRoomAuthority GetAuthority()
			{
				return this.m_owner.GetAuthority();
			}

			// Token: 0x060138D1 RID: 80081 RVA: 0x004FC828 File Offset: 0x004FAA28
			public void SaveTeamRoomSetting(TeamRoomSetting setting)
			{
				this.m_owner.SaveTeamRoomSetting(setting);
			}

			// Token: 0x060138D2 RID: 80082 RVA: 0x004FC838 File Offset: 0x004FAA38
			public void OnCreateButtonClick()
			{
				this.m_owner.OnCreateButtonClick();
			}

			// Token: 0x060138D3 RID: 80083 RVA: 0x004FC848 File Offset: 0x004FAA48
			public void OnCancelButtonClick()
			{
				this.m_owner.OnCancelButtonClick();
			}

			// Token: 0x060138D4 RID: 80084 RVA: 0x004FC858 File Offset: 0x004FAA58
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x060138D5 RID: 80085 RVA: 0x004FC868 File Offset: 0x004FAA68
			public void GameFunctionTypeListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
			{
				this.m_owner.GameFunctionTypeListItem_OnButtonClick(ctrl);
			}

			// Token: 0x060138D6 RID: 80086 RVA: 0x004FC878 File Offset: 0x004FAA78
			public void LocationListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
			{
				this.m_owner.LocationListItem_OnButtonClick(ctrl);
			}

			// Token: 0x060138D7 RID: 80087 RVA: 0x004FC888 File Offset: 0x004FAA88
			public void PlayerLevelMinListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
			{
				this.m_owner.PlayerLevelMinListItem_OnButtonClick(ctrl);
			}

			// Token: 0x060138D8 RID: 80088 RVA: 0x004FC898 File Offset: 0x004FAA98
			public void PlayerLevelMaxListItem_OnButtonClick(TeamRoomInfoListItemUIController ctrl)
			{
				this.m_owner.PlayerLevelMaxListItem_OnButtonClick(ctrl);
			}

			// Token: 0x060138D9 RID: 80089 RVA: 0x004FC8A8 File Offset: 0x004FAAA8
			public void GameFunctionTypeScrollSnapCenter_OnCenterItemChanged(int idx)
			{
				this.m_owner.GameFunctionTypeScrollSnapCenter_OnCenterItemChanged(idx);
			}

			// Token: 0x060138DA RID: 80090 RVA: 0x004FC8B8 File Offset: 0x004FAAB8
			public void GameFunctionTypeScrollRect_OnValueChaged(Vector2 value)
			{
				this.m_owner.GameFunctionTypeScrollRect_OnValueChaged(value);
			}

			// Token: 0x060138DB RID: 80091 RVA: 0x004FC8C8 File Offset: 0x004FAAC8
			public void LocationScrollRect_OnValueChaged(Vector2 value)
			{
				this.m_owner.LocationScrollRect_OnValueChaged(value);
			}

			// Token: 0x060138DC RID: 80092 RVA: 0x004FC8D8 File Offset: 0x004FAAD8
			public void PlayerLevelMinScrollRect_OnValueChaged(Vector2 value)
			{
				this.m_owner.PlayerLevelMinScrollRect_OnValueChaged(value);
			}

			// Token: 0x060138DD RID: 80093 RVA: 0x004FC8E8 File Offset: 0x004FAAE8
			public void PlayerLevelMaxScrollRect_OnValueChaged(Vector2 value)
			{
				this.m_owner.PlayerLevelMaxScrollRect_OnValueChaged(value);
			}

			// Token: 0x060138DE RID: 80094 RVA: 0x004FC8F8 File Offset: 0x004FAAF8
			public void ScaleListItem(ScrollRect scrollRect, List<TeamRoomInfoListItemUIController> listItems)
			{
				this.m_owner.ScaleListItem(scrollRect, listItems);
			}

			// Token: 0x0400AD96 RID: 44438
			private CreateTeamRoomUIController m_owner;
		}
	}
}
