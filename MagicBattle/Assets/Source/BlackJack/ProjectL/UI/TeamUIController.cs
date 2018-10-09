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
	// Token: 0x02000F7E RID: 3966
	[HotFix]
	public class TeamUIController : UIControllerBase
	{
		// Token: 0x06013C8B RID: 81035 RVA: 0x00509E40 File Offset: 0x00508040
		private TeamUIController()
		{
		}

		// Token: 0x06013C8C RID: 81036 RVA: 0x00509E6C File Offset: 0x0050806C
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_createTeamRoomButton.onClick.AddListener(new UnityAction(this.OnShowCreateTeamRoomButtonClick));
			this.m_refreshTeamRoomButton.onClick.AddListener(new UnityAction(this.OnRefreshTeamRoomButtonClick));
			this.m_autoMatchButton.onClick.AddListener(new UnityAction(this.OnAutoMatchButtonClick));
			this.m_autoMatchCancelButton.onClick.AddListener(new UnityAction(this.OnAutoMatchCancelButtonClick));
			this.m_gameFunctionTypeListDisableButton.onClick.AddListener(new UnityAction(this.OnAutoMatchCancelButtonClick));
			this.m_locationListDisableButton.onClick.AddListener(new UnityAction(this.OnAutoMatchCancelButtonClick));
			this.m_locationListCloseButton.onClick.AddListener(new UnityAction(this.OnLocationListCloseButtonClick));
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x06013C8D RID: 81037 RVA: 0x00509FDC File Offset: 0x005081DC
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
			this.ClearTeamRoomListItems();
			this.SetAutoMatchMode(false);
		}

		// Token: 0x06013C8E RID: 81038 RVA: 0x0050A064 File Offset: 0x00508264
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
			this.AddGameFunctionTypeListItem(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_AllGameFunctionType), GameFunctionType.GameFunctionType_None, 0, false);
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
		}

		// Token: 0x06013C8F RID: 81039 RVA: 0x0050A458 File Offset: 0x00508658
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
			GameObjectUtility.DestroyComponentList<TeamGameFunctionTypeListItemUIController>(this.m_gameFunctionTypeListItems);
			this.m_gameFunctionTypeListItems.Clear();
		}

		// Token: 0x06013C90 RID: 81040 RVA: 0x0050A4D0 File Offset: 0x005086D0
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
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_gameFunctionTypeListItemPrefab, this.m_gameFunctionTypeListScrollRect.content, false);
			TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamGameFunctionTypeListItemUIController>(go);
			teamGameFunctionTypeListItemUIController.SetName(name);
			teamGameFunctionTypeListItemUIController.SetGameFunctionType(gameFunctionType);
			teamGameFunctionTypeListItemUIController.SetChapterId(chapterId);
			teamGameFunctionTypeListItemUIController.SetLocked(isLocked);
			teamGameFunctionTypeListItemUIController.EventOnToggleValueChanged += this.TeamGameFunctionTypeListItem_OnToggleValueChanged;
			this.m_gameFunctionTypeListItems.Add(teamGameFunctionTypeListItemUIController);
		}

		// Token: 0x06013C91 RID: 81041 RVA: 0x0050A5CC File Offset: 0x005087CC
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
			this.AddLocationListItem(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_AllLocation), 0, 0, false);
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
								this.AddLocationListItem(configDataThearchyTrialLevelInfo.TeamName, configDataThearchyTrialLevelInfo.ID, configDataThearchyTrialLevelInfo.TeamEnergyCost, flag);
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
								this.AddLocationListItem(configDataAnikiLevelInfo.TeamName, configDataAnikiLevelInfo.ID, configDataAnikiLevelInfo.TeamEnergyCost, flag2);
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
								this.AddLocationListItem(configDataMemoryCorridorLevelInfo.TeamName, configDataMemoryCorridorLevelInfo.ID, configDataMemoryCorridorLevelInfo.TeamEnergyCost, flag3);
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
								this.AddLocationListItem(configDataHeroTrainningLevelInfo.TeamName, configDataHeroTrainningLevelInfo.ID, configDataHeroTrainningLevelInfo.TeamEnergyCost, flag4);
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
								this.AddLocationListItem(configDataCooperateBattleLevelInfo.TeamName, configDataCooperateBattleLevelInfo.ID, configDataCooperateBattleLevelInfo.EnergySuccess, flag5);
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
									this.AddLocationListItem(configDataScoreLevelInfo.TeamName, configDataScoreLevelInfo.ID, configDataScoreLevelInfo.EnergyTeam, flag6);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06013C92 RID: 81042 RVA: 0x0050AA84 File Offset: 0x00508C84
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
			GameObjectUtility.DestroyComponentList<TeamLocationListItemUIController>(this.m_locationListItems);
			this.m_locationListItems.Clear();
		}

		// Token: 0x06013C93 RID: 81043 RVA: 0x0050AAFC File Offset: 0x00508CFC
		private void AddLocationListItem(string name, int locationId, int energy, bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddLocationListItemStringInt32Int32Boolean_hotfix != null)
			{
				this.m_AddLocationListItemStringInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					name,
					locationId,
					energy,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_locationListItemPrefab, this.m_locationListScrollRect.content, false);
			TeamLocationListItemUIController teamLocationListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamLocationListItemUIController>(go);
			teamLocationListItemUIController.SetName(name);
			teamLocationListItemUIController.SetLocationId(locationId);
			teamLocationListItemUIController.SetEnergy(energy);
			teamLocationListItemUIController.SetLocked(isLocked);
			teamLocationListItemUIController.EventOnToggleValueChanged += this.TeamLocationListItem_OnToggleValueChanged;
			this.m_locationListItems.Add(teamLocationListItemUIController);
		}

		// Token: 0x06013C94 RID: 81044 RVA: 0x0050ABF8 File Offset: 0x00508DF8
		public void SelectGameFunctionTypeAndLocation(GameFunctionType gameFunctionType, int chapterId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectGameFunctionTypeAndLocationGameFunctionTypeInt32Int32_hotfix != null)
			{
				this.m_SelectGameFunctionTypeAndLocationGameFunctionTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					gameFunctionType,
					chapterId,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (locationId != 0)
			{
				this.m_isIgnoreFireSelectEvent = true;
			}
			foreach (TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController in this.m_gameFunctionTypeListItems)
			{
				if (teamGameFunctionTypeListItemUIController.GetGameFunctionType() == gameFunctionType && teamGameFunctionTypeListItemUIController.GetChapterId() == chapterId)
				{
					teamGameFunctionTypeListItemUIController.SetToggleValue(true);
					break;
				}
			}
			if (locationId != 0)
			{
				this.m_isIgnoreFireSelectEvent = false;
				foreach (TeamLocationListItemUIController teamLocationListItemUIController in this.m_locationListItems)
				{
					if (teamLocationListItemUIController.GetLocationId() == locationId)
					{
						teamLocationListItemUIController.SetToggleValue(true);
						break;
					}
				}
			}
		}

		// Token: 0x06013C95 RID: 81045 RVA: 0x0050AD6C File Offset: 0x00508F6C
		private void AddTeamRoomListItem(TeamRoom room)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTeamRoomListItemTeamRoom_hotfix != null)
			{
				this.m_AddTeamRoomListItemTeamRoom_hotfix.call(new object[]
				{
					this,
					room
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_roomListItemPrefab, this.m_roomListScrollRect.content, false);
			TeamRoomListItemUIController teamRoomListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomListItemUIController>(go);
			teamRoomListItemUIController.SetRoomId(room.RoomId);
			teamRoomListItemUIController.SetGameFunctionType(room.Setting.GameFunctionTypeId);
			teamRoomListItemUIController.SetLocationId(room.Setting.LocationId);
			teamRoomListItemUIController.SetGameFunctionTypeName(TeamUIController.GetGameFunctionName(room.Setting.GameFunctionTypeId, room.Setting.LocationId));
			teamRoomListItemUIController.SetLocationName(TeamUIController.GetLocationName(room.Setting.GameFunctionTypeId, room.Setting.LocationId));
			teamRoomListItemUIController.SetPlayerLevelRange(room.Setting.JoinMinLevel, room.Setting.JoinMaxLevel);
			teamRoomListItemUIController.EventOnJoinButtonClick += this.TeamRoomListItem_OnJoinButtonClick;
			for (int i = 0; i < 3; i++)
			{
				TeamRoomPlayer teamRoomPlayer = room.FindTeamRoomPlayerAtPosition(i);
				if (teamRoomPlayer != null)
				{
					teamRoomListItemUIController.SetPlayer(i, teamRoomPlayer.HeadIcon, teamRoomPlayer.Level);
				}
				else
				{
					teamRoomListItemUIController.SetPlayerOff(i);
				}
			}
			this.m_roomListItems.Add(teamRoomListItemUIController);
		}

		// Token: 0x06013C96 RID: 81046 RVA: 0x0050AEE4 File Offset: 0x005090E4
		private void ClearTeamRoomListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearTeamRoomListItems_hotfix != null)
			{
				this.m_ClearTeamRoomListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TeamRoomListItemUIController>(this.m_roomListItems);
			this.m_roomListItems.Clear();
		}

		// Token: 0x06013C97 RID: 81047 RVA: 0x0050AF5C File Offset: 0x0050915C
		public void SetTeamRooms(List<TeamRoom> rooms)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamRoomsList`1_hotfix != null)
			{
				this.m_SetTeamRoomsList`1_hotfix.call(new object[]
				{
					this,
					rooms
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearTeamRoomListItems();
			if (rooms == null || rooms.Count <= 0)
			{
				this.m_noTeamRoomUIStateController.gameObject.SetActive(true);
				this.m_noTeamRoomUIStateController.SetToUIState("NoTeam", false, true);
				return;
			}
			this.m_noTeamRoomUIStateController.gameObject.SetActive(false);
			foreach (TeamRoom room in rooms)
			{
				this.AddTeamRoomListItem(room);
			}
		}

		// Token: 0x06013C98 RID: 81048 RVA: 0x0050B064 File Offset: 0x00509264
		public void SetAutoMatchMode(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAutoMatchModeBoolean_hotfix != null)
			{
				this.m_SetAutoMatchModeBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				this.m_noTeamRoomUIStateController.gameObject.SetActive(true);
				this.m_noTeamRoomUIStateController.SetToUIState("Searching", false, true);
				this.m_autoMatchButton.gameObject.SetActive(false);
				this.m_autoMatchCancelButton.gameObject.SetActive(true);
				this.m_gameFunctionTypeListDisableButton.gameObject.SetActive(true);
				this.m_locationListDisableButton.gameObject.SetActive(true);
			}
			else
			{
				this.m_noTeamRoomUIStateController.gameObject.SetActive(false);
				this.m_autoMatchButton.gameObject.SetActive(this.GetLocationId() != 0);
				this.m_autoMatchCancelButton.gameObject.SetActive(false);
				this.m_gameFunctionTypeListDisableButton.gameObject.SetActive(false);
				this.m_locationListDisableButton.gameObject.SetActive(false);
			}
		}

		// Token: 0x06013C99 RID: 81049 RVA: 0x0050B1A8 File Offset: 0x005093A8
		public void SetAutoMatchWaitCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAutoMatchWaitCountInt32_hotfix != null)
			{
				this.m_SetAutoMatchWaitCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_MatchWaitCount);
			this.m_autoMatchWaitCountText.text = string.Format(format, count);
		}

		// Token: 0x06013C9A RID: 81050 RVA: 0x0050B24C File Offset: 0x0050944C
		public bool IsAutoMatching()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAutoMatching_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAutoMatching_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_autoMatchCancelButton.gameObject.activeSelf;
		}

		// Token: 0x06013C9B RID: 81051 RVA: 0x0050B2C8 File Offset: 0x005094C8
		private void UpdateTitle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTitle_hotfix != null)
			{
				this.m_UpdateTitle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = string.Empty;
			TeamGameFunctionTypeListItemUIController selectedGameFunctionTypeListItem = this.GetSelectedGameFunctionTypeListItem();
			if (selectedGameFunctionTypeListItem != null)
			{
				text = selectedGameFunctionTypeListItem.GetName();
				TeamLocationListItemUIController selectedLocationListItem = this.GetSelectedLocationListItem();
				if (selectedLocationListItem != null && selectedLocationListItem.GetLocationId() != 0)
				{
					text += selectedLocationListItem.GetName();
				}
			}
			this.m_titleText.text = text;
		}

		// Token: 0x06013C9C RID: 81052 RVA: 0x0050B380 File Offset: 0x00509580
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsAutoMatching())
			{
				this.OnAutoMatchCancelButtonClick();
				return;
			}
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06013C9D RID: 81053 RVA: 0x0050B408 File Offset: 0x00509608
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x06013C9E RID: 81054 RVA: 0x0050B480 File Offset: 0x00509680
		private void OnRefreshTeamRoomButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRefreshTeamRoomButtonClick_hotfix != null)
			{
				this.m_OnRefreshTeamRoomButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsAutoMatching())
			{
				this.OnAutoMatchCancelButtonClick();
				return;
			}
			if (this.EventOnRefreshTeamRoom != null)
			{
				this.EventOnRefreshTeamRoom();
			}
		}

		// Token: 0x06013C9F RID: 81055 RVA: 0x0050B508 File Offset: 0x00509708
		private void OnShowCreateTeamRoomButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowCreateTeamRoomButtonClick_hotfix != null)
			{
				this.m_OnShowCreateTeamRoomButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsAutoMatching())
			{
				this.OnAutoMatchCancelButtonClick();
				return;
			}
			if (this.EventOnShowCreateTeamRoom != null)
			{
				this.EventOnShowCreateTeamRoom();
			}
		}

		// Token: 0x06013CA0 RID: 81056 RVA: 0x0050B590 File Offset: 0x00509790
		private void OnAutoMatchButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoMatchButtonClick_hotfix != null)
			{
				this.m_OnAutoMatchButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAutoMatch != null)
			{
				this.EventOnAutoMatch();
			}
		}

		// Token: 0x06013CA1 RID: 81057 RVA: 0x0050B608 File Offset: 0x00509808
		private void OnAutoMatchCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoMatchCancelButtonClick_hotfix != null)
			{
				this.m_OnAutoMatchCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAutoMatchCancel != null)
			{
				this.EventOnAutoMatchCancel();
			}
		}

		// Token: 0x06013CA2 RID: 81058 RVA: 0x0050B680 File Offset: 0x00509880
		private void OnLocationListCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLocationListCloseButtonClick_hotfix != null)
			{
				this.m_OnLocationListCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsAutoMatching())
			{
				return;
			}
			UIUtility.SetUIStateClose(this.m_locationListUiStateController, "Close", null, false, true);
		}

		// Token: 0x06013CA3 RID: 81059 RVA: 0x0050B700 File Offset: 0x00509900
		private void TeamGameFunctionTypeListItem_OnToggleValueChanged(bool isOn, TeamGameFunctionTypeListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamGameFunctionTypeListItem_OnToggleValueChangedBooleanTeamGameFunctionTypeListItemUIController_hotfix != null)
			{
				this.m_TeamGameFunctionTypeListItem_OnToggleValueChangedBooleanTeamGameFunctionTypeListItemUIController_hotfix.call(new object[]
				{
					this,
					isOn,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				GameFunctionType gameFunctionType = ctrl.GetGameFunctionType();
				if (gameFunctionType == GameFunctionType.GameFunctionType_None)
				{
					this.ClearLocationListItems();
					this.m_locationListUiStateController.gameObject.SetActive(false);
				}
				else
				{
					this.AddLocationListItems(gameFunctionType, ctrl.GetChapterId());
					bool isIgnoreFireSelectEvent = this.m_isIgnoreFireSelectEvent;
					this.m_isIgnoreFireSelectEvent = true;
					this.m_locationListItems[0].SetToggleValue(true);
					this.m_isIgnoreFireSelectEvent = isIgnoreFireSelectEvent;
					UIUtility.SetUIStateOpen(this.m_locationListUiStateController, "Show", null, false, true);
				}
				this.UpdateTitle();
				this.m_autoMatchButton.gameObject.SetActive(false);
				if (this.EventOnSelectGameFunctionTypeAndLocation != null && !this.m_isIgnoreFireSelectEvent)
				{
					this.EventOnSelectGameFunctionTypeAndLocation(gameFunctionType, 0);
				}
			}
		}

		// Token: 0x06013CA4 RID: 81060 RVA: 0x0050B830 File Offset: 0x00509A30
		private TeamGameFunctionTypeListItemUIController GetSelectedGameFunctionTypeListItem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSelectedGameFunctionTypeListItem_hotfix != null)
			{
				return (TeamGameFunctionTypeListItemUIController)this.m_GetSelectedGameFunctionTypeListItem_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TeamGameFunctionTypeListItemUIController teamGameFunctionTypeListItemUIController in this.m_gameFunctionTypeListItems)
			{
				if (teamGameFunctionTypeListItemUIController.GetToggleValue())
				{
					return teamGameFunctionTypeListItemUIController;
				}
			}
			return null;
		}

		// Token: 0x06013CA5 RID: 81061 RVA: 0x0050B8FC File Offset: 0x00509AFC
		private TeamLocationListItemUIController GetSelectedLocationListItem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSelectedLocationListItem_hotfix != null)
			{
				return (TeamLocationListItemUIController)this.m_GetSelectedLocationListItem_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TeamLocationListItemUIController teamLocationListItemUIController in this.m_locationListItems)
			{
				if (teamLocationListItemUIController.GetToggleValue())
				{
					return teamLocationListItemUIController;
				}
			}
			return null;
		}

		// Token: 0x06013CA6 RID: 81062 RVA: 0x0050B9C8 File Offset: 0x00509BC8
		private void TeamLocationListItem_OnToggleValueChanged(bool isOn, TeamLocationListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamLocationListItem_OnToggleValueChangedBooleanTeamLocationListItemUIController_hotfix != null)
			{
				this.m_TeamLocationListItem_OnToggleValueChangedBooleanTeamLocationListItemUIController_hotfix.call(new object[]
				{
					this,
					isOn,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				int locationId = ctrl.GetLocationId();
				this.UpdateTitle();
				this.m_autoMatchButton.gameObject.SetActive(locationId != 0);
				if (this.EventOnSelectGameFunctionTypeAndLocation != null && !this.m_isIgnoreFireSelectEvent)
				{
					this.EventOnSelectGameFunctionTypeAndLocation(this.GetGameFunctionType(), locationId);
				}
			}
		}

		// Token: 0x06013CA7 RID: 81063 RVA: 0x0050BA9C File Offset: 0x00509C9C
		private void TeamRoomListItem_OnJoinButtonClick(TeamRoomListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomListItem_OnJoinButtonClickTeamRoomListItemUIController_hotfix != null)
			{
				this.m_TeamRoomListItem_OnJoinButtonClickTeamRoomListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsAutoMatching())
			{
				this.OnAutoMatchCancelButtonClick();
				return;
			}
			if (this.EventOnJoinTeamRoom != null)
			{
				this.EventOnJoinTeamRoom(ctrl.GetRoomId(), ctrl.GetGameFunctionType(), ctrl.GetLocationIdId());
			}
		}

		// Token: 0x06013CA8 RID: 81064 RVA: 0x0050BB48 File Offset: 0x00509D48
		public GameFunctionType GetGameFunctionType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGameFunctionType_hotfix != null)
			{
				return (GameFunctionType)this.m_GetGameFunctionType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamGameFunctionTypeListItemUIController selectedGameFunctionTypeListItem = this.GetSelectedGameFunctionTypeListItem();
			if (selectedGameFunctionTypeListItem != null)
			{
				return selectedGameFunctionTypeListItem.GetGameFunctionType();
			}
			return GameFunctionType.GameFunctionType_None;
		}

		// Token: 0x06013CA9 RID: 81065 RVA: 0x0050BBD0 File Offset: 0x00509DD0
		public int GetChapterId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChapterId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetChapterId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamGameFunctionTypeListItemUIController selectedGameFunctionTypeListItem = this.GetSelectedGameFunctionTypeListItem();
			if (selectedGameFunctionTypeListItem != null)
			{
				return selectedGameFunctionTypeListItem.GetChapterId();
			}
			return 0;
		}

		// Token: 0x06013CAA RID: 81066 RVA: 0x0050BC58 File Offset: 0x00509E58
		public int GetLocationId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLocationId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLocationId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TeamLocationListItemUIController selectedLocationListItem = this.GetSelectedLocationListItem();
			if (selectedLocationListItem != null)
			{
				return selectedLocationListItem.GetLocationId();
			}
			return 0;
		}

		// Token: 0x06013CAB RID: 81067 RVA: 0x0050BCE0 File Offset: 0x00509EE0
		public static string GetGameFunctionName(GameFunctionType gameFunctionType, int locationId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string result = string.Empty;
			if (gameFunctionType == GameFunctionType.GameFunctionType_None)
			{
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_AllGameFunctionType);
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_ThearchyTrial)
			{
				ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = configDataLoader.GetConfigDataThearchyTrialLevelInfo(locationId);
				if (configDataThearchyTrialLevelInfo != null)
				{
					result = configDataThearchyTrialLevelInfo.m_groupInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_AnikiGym)
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = configDataLoader.GetConfigDataAnikiLevelInfo(locationId);
				if (configDataAnikiLevelInfo != null)
				{
					result = configDataAnikiLevelInfo.m_groupInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_MemoryCorridor)
			{
				ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = configDataLoader.GetConfigDataMemoryCorridorLevelInfo(locationId);
				if (configDataMemoryCorridorLevelInfo != null)
				{
					result = configDataMemoryCorridorLevelInfo.m_groupInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_HeroTrainning)
			{
				ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = configDataLoader.GetConfigDataHeroTrainningLevelInfo(locationId);
				if (configDataHeroTrainningLevelInfo != null)
				{
					result = configDataHeroTrainningLevelInfo.m_groupInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_CooperateBattle)
			{
				ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = configDataLoader.GetConfigDataCooperateBattleLevelInfo(locationId);
				if (configDataCooperateBattleLevelInfo != null)
				{
					result = configDataCooperateBattleLevelInfo.m_groupInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
			{
				ConfigDataScoreLevelInfo configDataScoreLevelInfo = configDataLoader.GetConfigDataScoreLevelInfo(locationId);
				if (configDataScoreLevelInfo != null)
				{
					result = configDataScoreLevelInfo.UnchartedScoreInfo.Name;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = configDataLoader.GetConfigDataGuildMassiveCombatLevelInfo(locationId);
				if (configDataGuildMassiveCombatLevelInfo != null)
				{
					result = configDataGuildMassiveCombatLevelInfo.m_strongholdInfo.Name;
				}
			}
			return result;
		}

		// Token: 0x06013CAC RID: 81068 RVA: 0x0050BE38 File Offset: 0x0050A038
		public static string GetLocationName(GameFunctionType gameFunctionType, int locationId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string result = string.Empty;
			if (gameFunctionType == GameFunctionType.GameFunctionType_None)
			{
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_AllLocation);
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_ThearchyTrial)
			{
				ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = configDataLoader.GetConfigDataThearchyTrialLevelInfo(locationId);
				if (configDataThearchyTrialLevelInfo != null)
				{
					result = configDataThearchyTrialLevelInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_AnikiGym)
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = configDataLoader.GetConfigDataAnikiLevelInfo(locationId);
				if (configDataAnikiLevelInfo != null)
				{
					result = configDataAnikiLevelInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_MemoryCorridor)
			{
				ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = configDataLoader.GetConfigDataMemoryCorridorLevelInfo(locationId);
				if (configDataMemoryCorridorLevelInfo != null)
				{
					result = configDataMemoryCorridorLevelInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_HeroTrainning)
			{
				ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = configDataLoader.GetConfigDataHeroTrainningLevelInfo(locationId);
				if (configDataHeroTrainningLevelInfo != null)
				{
					result = configDataHeroTrainningLevelInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_CooperateBattle)
			{
				ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = configDataLoader.GetConfigDataCooperateBattleLevelInfo(locationId);
				if (configDataCooperateBattleLevelInfo != null)
				{
					result = configDataCooperateBattleLevelInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
			{
				ConfigDataScoreLevelInfo configDataScoreLevelInfo = configDataLoader.GetConfigDataScoreLevelInfo(locationId);
				if (configDataScoreLevelInfo != null)
				{
					result = configDataScoreLevelInfo.TeamName;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = configDataLoader.GetConfigDataGuildMassiveCombatLevelInfo(locationId);
				if (configDataGuildMassiveCombatLevelInfo != null)
				{
					result = configDataGuildMassiveCombatLevelInfo.m_battleInfo.Name;
				}
			}
			return result;
		}

		// Token: 0x06013CAD RID: 81069 RVA: 0x0050BF70 File Offset: 0x0050A170
		public static int GetEnergy(GameFunctionType gameFunctionType, int locationId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int result = 0;
			if (gameFunctionType == GameFunctionType.GameFunctionType_ThearchyTrial)
			{
				ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = configDataLoader.GetConfigDataThearchyTrialLevelInfo(locationId);
				if (configDataThearchyTrialLevelInfo != null)
				{
					result = configDataThearchyTrialLevelInfo.TeamEnergyCost;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_AnikiGym)
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = configDataLoader.GetConfigDataAnikiLevelInfo(locationId);
				if (configDataAnikiLevelInfo != null)
				{
					result = configDataAnikiLevelInfo.TeamEnergyCost;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_MemoryCorridor)
			{
				ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = configDataLoader.GetConfigDataMemoryCorridorLevelInfo(locationId);
				if (configDataMemoryCorridorLevelInfo != null)
				{
					result = configDataMemoryCorridorLevelInfo.TeamEnergyCost;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_HeroTrainning)
			{
				ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = configDataLoader.GetConfigDataHeroTrainningLevelInfo(locationId);
				if (configDataHeroTrainningLevelInfo != null)
				{
					result = configDataHeroTrainningLevelInfo.TeamEnergyCost;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_CooperateBattle)
			{
				ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = configDataLoader.GetConfigDataCooperateBattleLevelInfo(locationId);
				if (configDataCooperateBattleLevelInfo != null)
				{
					result = configDataCooperateBattleLevelInfo.EnergySuccess;
				}
			}
			else if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
			{
				ConfigDataScoreLevelInfo configDataScoreLevelInfo = configDataLoader.GetConfigDataScoreLevelInfo(locationId);
				if (configDataScoreLevelInfo != null)
				{
					result = configDataScoreLevelInfo.EnergyTeam;
				}
			}
			return result;
		}

		// Token: 0x14000456 RID: 1110
		// (add) Token: 0x06013CAE RID: 81070 RVA: 0x0050C064 File Offset: 0x0050A264
		// (remove) Token: 0x06013CAF RID: 81071 RVA: 0x0050C100 File Offset: 0x0050A300
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000457 RID: 1111
		// (add) Token: 0x06013CB0 RID: 81072 RVA: 0x0050C19C File Offset: 0x0050A39C
		// (remove) Token: 0x06013CB1 RID: 81073 RVA: 0x0050C238 File Offset: 0x0050A438
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000458 RID: 1112
		// (add) Token: 0x06013CB2 RID: 81074 RVA: 0x0050C2D4 File Offset: 0x0050A4D4
		// (remove) Token: 0x06013CB3 RID: 81075 RVA: 0x0050C370 File Offset: 0x0050A570
		public event Action EventOnRefreshTeamRoom
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRefreshTeamRoomAction_hotfix != null)
				{
					this.m_add_EventOnRefreshTeamRoomAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRefreshTeamRoom;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRefreshTeamRoom, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRefreshTeamRoomAction_hotfix != null)
				{
					this.m_remove_EventOnRefreshTeamRoomAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRefreshTeamRoom;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRefreshTeamRoom, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000459 RID: 1113
		// (add) Token: 0x06013CB4 RID: 81076 RVA: 0x0050C40C File Offset: 0x0050A60C
		// (remove) Token: 0x06013CB5 RID: 81077 RVA: 0x0050C4A8 File Offset: 0x0050A6A8
		public event Action EventOnShowCreateTeamRoom
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowCreateTeamRoomAction_hotfix != null)
				{
					this.m_add_EventOnShowCreateTeamRoomAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowCreateTeamRoom;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowCreateTeamRoom, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowCreateTeamRoomAction_hotfix != null)
				{
					this.m_remove_EventOnShowCreateTeamRoomAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowCreateTeamRoom;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowCreateTeamRoom, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400045A RID: 1114
		// (add) Token: 0x06013CB6 RID: 81078 RVA: 0x0050C544 File Offset: 0x0050A744
		// (remove) Token: 0x06013CB7 RID: 81079 RVA: 0x0050C5E0 File Offset: 0x0050A7E0
		public event Action EventOnAutoMatch
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoMatchAction_hotfix != null)
				{
					this.m_add_EventOnAutoMatchAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAutoMatch;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAutoMatch, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoMatchAction_hotfix != null)
				{
					this.m_remove_EventOnAutoMatchAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAutoMatch;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAutoMatch, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400045B RID: 1115
		// (add) Token: 0x06013CB8 RID: 81080 RVA: 0x0050C67C File Offset: 0x0050A87C
		// (remove) Token: 0x06013CB9 RID: 81081 RVA: 0x0050C718 File Offset: 0x0050A918
		public event Action EventOnAutoMatchCancel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoMatchCancelAction_hotfix != null)
				{
					this.m_add_EventOnAutoMatchCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAutoMatchCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAutoMatchCancel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoMatchCancelAction_hotfix != null)
				{
					this.m_remove_EventOnAutoMatchCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAutoMatchCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAutoMatchCancel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400045C RID: 1116
		// (add) Token: 0x06013CBA RID: 81082 RVA: 0x0050C7B4 File Offset: 0x0050A9B4
		// (remove) Token: 0x06013CBB RID: 81083 RVA: 0x0050C850 File Offset: 0x0050AA50
		public event Action<GameFunctionType, int> EventOnSelectGameFunctionTypeAndLocation
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectGameFunctionTypeAndLocationAction`2_hotfix != null)
				{
					this.m_add_EventOnSelectGameFunctionTypeAndLocationAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GameFunctionType, int> action = this.EventOnSelectGameFunctionTypeAndLocation;
				Action<GameFunctionType, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GameFunctionType, int>>(ref this.EventOnSelectGameFunctionTypeAndLocation, (Action<GameFunctionType, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectGameFunctionTypeAndLocationAction`2_hotfix != null)
				{
					this.m_remove_EventOnSelectGameFunctionTypeAndLocationAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GameFunctionType, int> action = this.EventOnSelectGameFunctionTypeAndLocation;
				Action<GameFunctionType, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GameFunctionType, int>>(ref this.EventOnSelectGameFunctionTypeAndLocation, (Action<GameFunctionType, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400045D RID: 1117
		// (add) Token: 0x06013CBC RID: 81084 RVA: 0x0050C8EC File Offset: 0x0050AAEC
		// (remove) Token: 0x06013CBD RID: 81085 RVA: 0x0050C988 File Offset: 0x0050AB88
		public event Action<int, GameFunctionType, int> EventOnJoinTeamRoom
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJoinTeamRoomAction`3_hotfix != null)
				{
					this.m_add_EventOnJoinTeamRoomAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, GameFunctionType, int> action = this.EventOnJoinTeamRoom;
				Action<int, GameFunctionType, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, GameFunctionType, int>>(ref this.EventOnJoinTeamRoom, (Action<int, GameFunctionType, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJoinTeamRoomAction`3_hotfix != null)
				{
					this.m_remove_EventOnJoinTeamRoomAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, GameFunctionType, int> action = this.EventOnJoinTeamRoom;
				Action<int, GameFunctionType, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, GameFunctionType, int>>(ref this.EventOnJoinTeamRoom, (Action<int, GameFunctionType, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x06013CBE RID: 81086 RVA: 0x0050CA24 File Offset: 0x0050AC24
		// (set) Token: 0x06013CBF RID: 81087 RVA: 0x0050CA44 File Offset: 0x0050AC44
		[DoNotToLua]
		public new TeamUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013CC0 RID: 81088 RVA: 0x0050CA50 File Offset: 0x0050AC50
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013CC1 RID: 81089 RVA: 0x0050CA5C File Offset: 0x0050AC5C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013CC2 RID: 81090 RVA: 0x0050CA64 File Offset: 0x0050AC64
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013CC3 RID: 81091 RVA: 0x0050CA6C File Offset: 0x0050AC6C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013CC4 RID: 81092 RVA: 0x0050CA80 File Offset: 0x0050AC80
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013CC5 RID: 81093 RVA: 0x0050CA88 File Offset: 0x0050AC88
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013CC6 RID: 81094 RVA: 0x0050CA94 File Offset: 0x0050AC94
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013CC7 RID: 81095 RVA: 0x0050CAA0 File Offset: 0x0050ACA0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013CC8 RID: 81096 RVA: 0x0050CAAC File Offset: 0x0050ACAC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013CC9 RID: 81097 RVA: 0x0050CAB8 File Offset: 0x0050ACB8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013CCA RID: 81098 RVA: 0x0050CAC4 File Offset: 0x0050ACC4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013CCB RID: 81099 RVA: 0x0050CAD0 File Offset: 0x0050ACD0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013CCC RID: 81100 RVA: 0x0050CADC File Offset: 0x0050ACDC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013CCD RID: 81101 RVA: 0x0050CAE8 File Offset: 0x0050ACE8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013CCE RID: 81102 RVA: 0x0050CAF4 File Offset: 0x0050ACF4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013CCF RID: 81103 RVA: 0x0050CAFC File Offset: 0x0050ACFC
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06013CD0 RID: 81104 RVA: 0x0050CB1C File Offset: 0x0050AD1C
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06013CD1 RID: 81105 RVA: 0x0050CB28 File Offset: 0x0050AD28
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06013CD2 RID: 81106 RVA: 0x0050CB48 File Offset: 0x0050AD48
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06013CD3 RID: 81107 RVA: 0x0050CB54 File Offset: 0x0050AD54
		private void __callDele_EventOnRefreshTeamRoom()
		{
			Action eventOnRefreshTeamRoom = this.EventOnRefreshTeamRoom;
			if (eventOnRefreshTeamRoom != null)
			{
				eventOnRefreshTeamRoom();
			}
		}

		// Token: 0x06013CD4 RID: 81108 RVA: 0x0050CB74 File Offset: 0x0050AD74
		private void __clearDele_EventOnRefreshTeamRoom()
		{
			this.EventOnRefreshTeamRoom = null;
		}

		// Token: 0x06013CD5 RID: 81109 RVA: 0x0050CB80 File Offset: 0x0050AD80
		private void __callDele_EventOnShowCreateTeamRoom()
		{
			Action eventOnShowCreateTeamRoom = this.EventOnShowCreateTeamRoom;
			if (eventOnShowCreateTeamRoom != null)
			{
				eventOnShowCreateTeamRoom();
			}
		}

		// Token: 0x06013CD6 RID: 81110 RVA: 0x0050CBA0 File Offset: 0x0050ADA0
		private void __clearDele_EventOnShowCreateTeamRoom()
		{
			this.EventOnShowCreateTeamRoom = null;
		}

		// Token: 0x06013CD7 RID: 81111 RVA: 0x0050CBAC File Offset: 0x0050ADAC
		private void __callDele_EventOnAutoMatch()
		{
			Action eventOnAutoMatch = this.EventOnAutoMatch;
			if (eventOnAutoMatch != null)
			{
				eventOnAutoMatch();
			}
		}

		// Token: 0x06013CD8 RID: 81112 RVA: 0x0050CBCC File Offset: 0x0050ADCC
		private void __clearDele_EventOnAutoMatch()
		{
			this.EventOnAutoMatch = null;
		}

		// Token: 0x06013CD9 RID: 81113 RVA: 0x0050CBD8 File Offset: 0x0050ADD8
		private void __callDele_EventOnAutoMatchCancel()
		{
			Action eventOnAutoMatchCancel = this.EventOnAutoMatchCancel;
			if (eventOnAutoMatchCancel != null)
			{
				eventOnAutoMatchCancel();
			}
		}

		// Token: 0x06013CDA RID: 81114 RVA: 0x0050CBF8 File Offset: 0x0050ADF8
		private void __clearDele_EventOnAutoMatchCancel()
		{
			this.EventOnAutoMatchCancel = null;
		}

		// Token: 0x06013CDB RID: 81115 RVA: 0x0050CC04 File Offset: 0x0050AE04
		private void __callDele_EventOnSelectGameFunctionTypeAndLocation(GameFunctionType arg1, int arg2)
		{
			Action<GameFunctionType, int> eventOnSelectGameFunctionTypeAndLocation = this.EventOnSelectGameFunctionTypeAndLocation;
			if (eventOnSelectGameFunctionTypeAndLocation != null)
			{
				eventOnSelectGameFunctionTypeAndLocation(arg1, arg2);
			}
		}

		// Token: 0x06013CDC RID: 81116 RVA: 0x0050CC28 File Offset: 0x0050AE28
		private void __clearDele_EventOnSelectGameFunctionTypeAndLocation(GameFunctionType arg1, int arg2)
		{
			this.EventOnSelectGameFunctionTypeAndLocation = null;
		}

		// Token: 0x06013CDD RID: 81117 RVA: 0x0050CC34 File Offset: 0x0050AE34
		private void __callDele_EventOnJoinTeamRoom(int arg1, GameFunctionType arg2, int arg3)
		{
			Action<int, GameFunctionType, int> eventOnJoinTeamRoom = this.EventOnJoinTeamRoom;
			if (eventOnJoinTeamRoom != null)
			{
				eventOnJoinTeamRoom(arg1, arg2, arg3);
			}
		}

		// Token: 0x06013CDE RID: 81118 RVA: 0x0050CC58 File Offset: 0x0050AE58
		private void __clearDele_EventOnJoinTeamRoom(int arg1, GameFunctionType arg2, int arg3)
		{
			this.EventOnJoinTeamRoom = null;
		}

		// Token: 0x06013CDF RID: 81119 RVA: 0x0050CC64 File Offset: 0x0050AE64
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
					this.m_AddGameFunctionTypeListItems_hotfix = (luaObj.RawGet("AddGameFunctionTypeListItems") as LuaFunction);
					this.m_ClearGameFunctionTypeListItems_hotfix = (luaObj.RawGet("ClearGameFunctionTypeListItems") as LuaFunction);
					this.m_AddGameFunctionTypeListItemStringGameFunctionTypeInt32Boolean_hotfix = (luaObj.RawGet("AddGameFunctionTypeListItem") as LuaFunction);
					this.m_AddLocationListItemsGameFunctionTypeInt32_hotfix = (luaObj.RawGet("AddLocationListItems") as LuaFunction);
					this.m_ClearLocationListItems_hotfix = (luaObj.RawGet("ClearLocationListItems") as LuaFunction);
					this.m_AddLocationListItemStringInt32Int32Boolean_hotfix = (luaObj.RawGet("AddLocationListItem") as LuaFunction);
					this.m_SelectGameFunctionTypeAndLocationGameFunctionTypeInt32Int32_hotfix = (luaObj.RawGet("SelectGameFunctionTypeAndLocation") as LuaFunction);
					this.m_AddTeamRoomListItemTeamRoom_hotfix = (luaObj.RawGet("AddTeamRoomListItem") as LuaFunction);
					this.m_ClearTeamRoomListItems_hotfix = (luaObj.RawGet("ClearTeamRoomListItems") as LuaFunction);
					this.m_SetTeamRoomsList`1_hotfix = (luaObj.RawGet("SetTeamRooms") as LuaFunction);
					this.m_SetAutoMatchModeBoolean_hotfix = (luaObj.RawGet("SetAutoMatchMode") as LuaFunction);
					this.m_SetAutoMatchWaitCountInt32_hotfix = (luaObj.RawGet("SetAutoMatchWaitCount") as LuaFunction);
					this.m_IsAutoMatching_hotfix = (luaObj.RawGet("IsAutoMatching") as LuaFunction);
					this.m_UpdateTitle_hotfix = (luaObj.RawGet("UpdateTitle") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnRefreshTeamRoomButtonClick_hotfix = (luaObj.RawGet("OnRefreshTeamRoomButtonClick") as LuaFunction);
					this.m_OnShowCreateTeamRoomButtonClick_hotfix = (luaObj.RawGet("OnShowCreateTeamRoomButtonClick") as LuaFunction);
					this.m_OnAutoMatchButtonClick_hotfix = (luaObj.RawGet("OnAutoMatchButtonClick") as LuaFunction);
					this.m_OnAutoMatchCancelButtonClick_hotfix = (luaObj.RawGet("OnAutoMatchCancelButtonClick") as LuaFunction);
					this.m_OnLocationListCloseButtonClick_hotfix = (luaObj.RawGet("OnLocationListCloseButtonClick") as LuaFunction);
					this.m_TeamGameFunctionTypeListItem_OnToggleValueChangedBooleanTeamGameFunctionTypeListItemUIController_hotfix = (luaObj.RawGet("TeamGameFunctionTypeListItem_OnToggleValueChanged") as LuaFunction);
					this.m_GetSelectedGameFunctionTypeListItem_hotfix = (luaObj.RawGet("GetSelectedGameFunctionTypeListItem") as LuaFunction);
					this.m_GetSelectedLocationListItem_hotfix = (luaObj.RawGet("GetSelectedLocationListItem") as LuaFunction);
					this.m_TeamLocationListItem_OnToggleValueChangedBooleanTeamLocationListItemUIController_hotfix = (luaObj.RawGet("TeamLocationListItem_OnToggleValueChanged") as LuaFunction);
					this.m_TeamRoomListItem_OnJoinButtonClickTeamRoomListItemUIController_hotfix = (luaObj.RawGet("TeamRoomListItem_OnJoinButtonClick") as LuaFunction);
					this.m_GetGameFunctionType_hotfix = (luaObj.RawGet("GetGameFunctionType") as LuaFunction);
					this.m_GetChapterId_hotfix = (luaObj.RawGet("GetChapterId") as LuaFunction);
					this.m_GetLocationId_hotfix = (luaObj.RawGet("GetLocationId") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnRefreshTeamRoomAction_hotfix = (luaObj.RawGet("add_EventOnRefreshTeamRoom") as LuaFunction);
					this.m_remove_EventOnRefreshTeamRoomAction_hotfix = (luaObj.RawGet("remove_EventOnRefreshTeamRoom") as LuaFunction);
					this.m_add_EventOnShowCreateTeamRoomAction_hotfix = (luaObj.RawGet("add_EventOnShowCreateTeamRoom") as LuaFunction);
					this.m_remove_EventOnShowCreateTeamRoomAction_hotfix = (luaObj.RawGet("remove_EventOnShowCreateTeamRoom") as LuaFunction);
					this.m_add_EventOnAutoMatchAction_hotfix = (luaObj.RawGet("add_EventOnAutoMatch") as LuaFunction);
					this.m_remove_EventOnAutoMatchAction_hotfix = (luaObj.RawGet("remove_EventOnAutoMatch") as LuaFunction);
					this.m_add_EventOnAutoMatchCancelAction_hotfix = (luaObj.RawGet("add_EventOnAutoMatchCancel") as LuaFunction);
					this.m_remove_EventOnAutoMatchCancelAction_hotfix = (luaObj.RawGet("remove_EventOnAutoMatchCancel") as LuaFunction);
					this.m_add_EventOnSelectGameFunctionTypeAndLocationAction`2_hotfix = (luaObj.RawGet("add_EventOnSelectGameFunctionTypeAndLocation") as LuaFunction);
					this.m_remove_EventOnSelectGameFunctionTypeAndLocationAction`2_hotfix = (luaObj.RawGet("remove_EventOnSelectGameFunctionTypeAndLocation") as LuaFunction);
					this.m_add_EventOnJoinTeamRoomAction`3_hotfix = (luaObj.RawGet("add_EventOnJoinTeamRoom") as LuaFunction);
					this.m_remove_EventOnJoinTeamRoomAction`3_hotfix = (luaObj.RawGet("remove_EventOnJoinTeamRoom") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013CE0 RID: 81120 RVA: 0x0050D1B0 File Offset: 0x0050B3B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AF1F RID: 44831
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AF20 RID: 44832
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400AF21 RID: 44833
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400AF22 RID: 44834
		[AutoBind("./ToggleList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_gameFunctionTypeListScrollRect;

		// Token: 0x0400AF23 RID: 44835
		[AutoBind("./ToggleList/DisableButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_gameFunctionTypeListDisableButton;

		// Token: 0x0400AF24 RID: 44836
		[AutoBind("./LevelListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_locationListUiStateController;

		// Token: 0x0400AF25 RID: 44837
		[AutoBind("./LevelListPanel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_locationListScrollRect;

		// Token: 0x0400AF26 RID: 44838
		[AutoBind("./LevelListPanel/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_locationListCloseButton;

		// Token: 0x0400AF27 RID: 44839
		[AutoBind("./LevelListPanel/DisableButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_locationListDisableButton;

		// Token: 0x0400AF28 RID: 44840
		[AutoBind("./TeamRoomList/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_titleText;

		// Token: 0x0400AF29 RID: 44841
		[AutoBind("./TeamRoomList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_roomListScrollRect;

		// Token: 0x0400AF2A RID: 44842
		[AutoBind("./TeamRoomList/CreateTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_createTeamRoomButton;

		// Token: 0x0400AF2B RID: 44843
		[AutoBind("./TeamRoomList/RefreshButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_refreshTeamRoomButton;

		// Token: 0x0400AF2C RID: 44844
		[AutoBind("./TeamRoomList/AutoMatchingButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoMatchButton;

		// Token: 0x0400AF2D RID: 44845
		[AutoBind("./TeamRoomList/NoTeamPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_noTeamRoomUIStateController;

		// Token: 0x0400AF2E RID: 44846
		[AutoBind("./TeamRoomList/NoTeamPanel/MatchingCancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoMatchCancelButton;

		// Token: 0x0400AF2F RID: 44847
		[AutoBind("./TeamRoomList/NoTeamPanel/MatchingCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_autoMatchWaitCountText;

		// Token: 0x0400AF30 RID: 44848
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400AF31 RID: 44849
		[AutoBind("./Prefabs/GameFunctionTypeListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_gameFunctionTypeListItemPrefab;

		// Token: 0x0400AF32 RID: 44850
		[AutoBind("./Prefabs/LocationListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_locationListItemPrefab;

		// Token: 0x0400AF33 RID: 44851
		[AutoBind("./Prefabs/RoomListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_roomListItemPrefab;

		// Token: 0x0400AF34 RID: 44852
		private List<TeamGameFunctionTypeListItemUIController> m_gameFunctionTypeListItems = new List<TeamGameFunctionTypeListItemUIController>();

		// Token: 0x0400AF35 RID: 44853
		private List<TeamLocationListItemUIController> m_locationListItems = new List<TeamLocationListItemUIController>();

		// Token: 0x0400AF36 RID: 44854
		private List<TeamRoomListItemUIController> m_roomListItems = new List<TeamRoomListItemUIController>();

		// Token: 0x0400AF37 RID: 44855
		private bool m_isIgnoreFireSelectEvent;

		// Token: 0x0400AF38 RID: 44856
		[DoNotToLua]
		private TeamUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AF39 RID: 44857
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AF3A RID: 44858
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AF3B RID: 44859
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AF3C RID: 44860
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400AF3D RID: 44861
		private LuaFunction m_AddGameFunctionTypeListItems_hotfix;

		// Token: 0x0400AF3E RID: 44862
		private LuaFunction m_ClearGameFunctionTypeListItems_hotfix;

		// Token: 0x0400AF3F RID: 44863
		private LuaFunction m_AddGameFunctionTypeListItemStringGameFunctionTypeInt32Boolean_hotfix;

		// Token: 0x0400AF40 RID: 44864
		private LuaFunction m_AddLocationListItemsGameFunctionTypeInt32_hotfix;

		// Token: 0x0400AF41 RID: 44865
		private LuaFunction m_ClearLocationListItems_hotfix;

		// Token: 0x0400AF42 RID: 44866
		private LuaFunction m_AddLocationListItemStringInt32Int32Boolean_hotfix;

		// Token: 0x0400AF43 RID: 44867
		private LuaFunction m_SelectGameFunctionTypeAndLocationGameFunctionTypeInt32Int32_hotfix;

		// Token: 0x0400AF44 RID: 44868
		private LuaFunction m_AddTeamRoomListItemTeamRoom_hotfix;

		// Token: 0x0400AF45 RID: 44869
		private LuaFunction m_ClearTeamRoomListItems_hotfix;

		// Token: 0x0400AF46 RID: 44870
		private LuaFunction m_SetTeamRoomsList;

		// Token: 0x0400AF47 RID: 44871
		private LuaFunction m_SetAutoMatchModeBoolean_hotfix;

		// Token: 0x0400AF48 RID: 44872
		private LuaFunction m_SetAutoMatchWaitCountInt32_hotfix;

		// Token: 0x0400AF49 RID: 44873
		private LuaFunction m_IsAutoMatching_hotfix;

		// Token: 0x0400AF4A RID: 44874
		private LuaFunction m_UpdateTitle_hotfix;

		// Token: 0x0400AF4B RID: 44875
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400AF4C RID: 44876
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400AF4D RID: 44877
		private LuaFunction m_OnRefreshTeamRoomButtonClick_hotfix;

		// Token: 0x0400AF4E RID: 44878
		private LuaFunction m_OnShowCreateTeamRoomButtonClick_hotfix;

		// Token: 0x0400AF4F RID: 44879
		private LuaFunction m_OnAutoMatchButtonClick_hotfix;

		// Token: 0x0400AF50 RID: 44880
		private LuaFunction m_OnAutoMatchCancelButtonClick_hotfix;

		// Token: 0x0400AF51 RID: 44881
		private LuaFunction m_OnLocationListCloseButtonClick_hotfix;

		// Token: 0x0400AF52 RID: 44882
		private LuaFunction m_TeamGameFunctionTypeListItem_OnToggleValueChangedBooleanTeamGameFunctionTypeListItemUIController_hotfix;

		// Token: 0x0400AF53 RID: 44883
		private LuaFunction m_GetSelectedGameFunctionTypeListItem_hotfix;

		// Token: 0x0400AF54 RID: 44884
		private LuaFunction m_GetSelectedLocationListItem_hotfix;

		// Token: 0x0400AF55 RID: 44885
		private LuaFunction m_TeamLocationListItem_OnToggleValueChangedBooleanTeamLocationListItemUIController_hotfix;

		// Token: 0x0400AF56 RID: 44886
		private LuaFunction m_TeamRoomListItem_OnJoinButtonClickTeamRoomListItemUIController_hotfix;

		// Token: 0x0400AF57 RID: 44887
		private LuaFunction m_GetGameFunctionType_hotfix;

		// Token: 0x0400AF58 RID: 44888
		private LuaFunction m_GetChapterId_hotfix;

		// Token: 0x0400AF59 RID: 44889
		private LuaFunction m_GetLocationId_hotfix;

		// Token: 0x0400AF5A RID: 44890
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400AF5B RID: 44891
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400AF5C RID: 44892
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400AF5D RID: 44893
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400AF5E RID: 44894
		private LuaFunction m_add_EventOnRefreshTeamRoomAction_hotfix;

		// Token: 0x0400AF5F RID: 44895
		private LuaFunction m_remove_EventOnRefreshTeamRoomAction_hotfix;

		// Token: 0x0400AF60 RID: 44896
		private LuaFunction m_add_EventOnShowCreateTeamRoomAction_hotfix;

		// Token: 0x0400AF61 RID: 44897
		private LuaFunction m_remove_EventOnShowCreateTeamRoomAction_hotfix;

		// Token: 0x0400AF62 RID: 44898
		private LuaFunction m_add_EventOnAutoMatchAction_hotfix;

		// Token: 0x0400AF63 RID: 44899
		private LuaFunction m_remove_EventOnAutoMatchAction_hotfix;

		// Token: 0x0400AF64 RID: 44900
		private LuaFunction m_add_EventOnAutoMatchCancelAction_hotfix;

		// Token: 0x0400AF65 RID: 44901
		private LuaFunction m_remove_EventOnAutoMatchCancelAction_hotfix;

		// Token: 0x0400AF66 RID: 44902
		private LuaFunction m_add_EventOnSelectGameFunctionTypeAndLocationAction;

		// Token: 0x0400AF67 RID: 44903
		private LuaFunction m_remove_EventOnSelectGameFunctionTypeAndLocationAction;

		// Token: 0x0400AF68 RID: 44904
		private LuaFunction m_add_EventOnJoinTeamRoomAction;

		// Token: 0x0400AF69 RID: 44905
		private LuaFunction m_remove_EventOnJoinTeamRoomAction;

		// Token: 0x02000F7F RID: 3967
		public new class LuaExportHelper
		{
			// Token: 0x06013CE1 RID: 81121 RVA: 0x0050D218 File Offset: 0x0050B418
			public LuaExportHelper(TeamUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013CE2 RID: 81122 RVA: 0x0050D228 File Offset: 0x0050B428
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013CE3 RID: 81123 RVA: 0x0050D238 File Offset: 0x0050B438
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013CE4 RID: 81124 RVA: 0x0050D248 File Offset: 0x0050B448
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013CE5 RID: 81125 RVA: 0x0050D258 File Offset: 0x0050B458
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013CE6 RID: 81126 RVA: 0x0050D270 File Offset: 0x0050B470
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013CE7 RID: 81127 RVA: 0x0050D280 File Offset: 0x0050B480
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013CE8 RID: 81128 RVA: 0x0050D290 File Offset: 0x0050B490
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013CE9 RID: 81129 RVA: 0x0050D2A0 File Offset: 0x0050B4A0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013CEA RID: 81130 RVA: 0x0050D2B0 File Offset: 0x0050B4B0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013CEB RID: 81131 RVA: 0x0050D2C0 File Offset: 0x0050B4C0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013CEC RID: 81132 RVA: 0x0050D2D0 File Offset: 0x0050B4D0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013CED RID: 81133 RVA: 0x0050D2E0 File Offset: 0x0050B4E0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013CEE RID: 81134 RVA: 0x0050D2F0 File Offset: 0x0050B4F0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013CEF RID: 81135 RVA: 0x0050D300 File Offset: 0x0050B500
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013CF0 RID: 81136 RVA: 0x0050D310 File Offset: 0x0050B510
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013CF1 RID: 81137 RVA: 0x0050D320 File Offset: 0x0050B520
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06013CF2 RID: 81138 RVA: 0x0050D330 File Offset: 0x0050B530
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06013CF3 RID: 81139 RVA: 0x0050D340 File Offset: 0x0050B540
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06013CF4 RID: 81140 RVA: 0x0050D350 File Offset: 0x0050B550
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x06013CF5 RID: 81141 RVA: 0x0050D360 File Offset: 0x0050B560
			public void __callDele_EventOnRefreshTeamRoom()
			{
				this.m_owner.__callDele_EventOnRefreshTeamRoom();
			}

			// Token: 0x06013CF6 RID: 81142 RVA: 0x0050D370 File Offset: 0x0050B570
			public void __clearDele_EventOnRefreshTeamRoom()
			{
				this.m_owner.__clearDele_EventOnRefreshTeamRoom();
			}

			// Token: 0x06013CF7 RID: 81143 RVA: 0x0050D380 File Offset: 0x0050B580
			public void __callDele_EventOnShowCreateTeamRoom()
			{
				this.m_owner.__callDele_EventOnShowCreateTeamRoom();
			}

			// Token: 0x06013CF8 RID: 81144 RVA: 0x0050D390 File Offset: 0x0050B590
			public void __clearDele_EventOnShowCreateTeamRoom()
			{
				this.m_owner.__clearDele_EventOnShowCreateTeamRoom();
			}

			// Token: 0x06013CF9 RID: 81145 RVA: 0x0050D3A0 File Offset: 0x0050B5A0
			public void __callDele_EventOnAutoMatch()
			{
				this.m_owner.__callDele_EventOnAutoMatch();
			}

			// Token: 0x06013CFA RID: 81146 RVA: 0x0050D3B0 File Offset: 0x0050B5B0
			public void __clearDele_EventOnAutoMatch()
			{
				this.m_owner.__clearDele_EventOnAutoMatch();
			}

			// Token: 0x06013CFB RID: 81147 RVA: 0x0050D3C0 File Offset: 0x0050B5C0
			public void __callDele_EventOnAutoMatchCancel()
			{
				this.m_owner.__callDele_EventOnAutoMatchCancel();
			}

			// Token: 0x06013CFC RID: 81148 RVA: 0x0050D3D0 File Offset: 0x0050B5D0
			public void __clearDele_EventOnAutoMatchCancel()
			{
				this.m_owner.__clearDele_EventOnAutoMatchCancel();
			}

			// Token: 0x06013CFD RID: 81149 RVA: 0x0050D3E0 File Offset: 0x0050B5E0
			public void __callDele_EventOnSelectGameFunctionTypeAndLocation(GameFunctionType arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnSelectGameFunctionTypeAndLocation(arg1, arg2);
			}

			// Token: 0x06013CFE RID: 81150 RVA: 0x0050D3F0 File Offset: 0x0050B5F0
			public void __clearDele_EventOnSelectGameFunctionTypeAndLocation(GameFunctionType arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnSelectGameFunctionTypeAndLocation(arg1, arg2);
			}

			// Token: 0x06013CFF RID: 81151 RVA: 0x0050D400 File Offset: 0x0050B600
			public void __callDele_EventOnJoinTeamRoom(int arg1, GameFunctionType arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnJoinTeamRoom(arg1, arg2, arg3);
			}

			// Token: 0x06013D00 RID: 81152 RVA: 0x0050D410 File Offset: 0x0050B610
			public void __clearDele_EventOnJoinTeamRoom(int arg1, GameFunctionType arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnJoinTeamRoom(arg1, arg2, arg3);
			}

			// Token: 0x17003B33 RID: 15155
			// (get) Token: 0x06013D01 RID: 81153 RVA: 0x0050D420 File Offset: 0x0050B620
			// (set) Token: 0x06013D02 RID: 81154 RVA: 0x0050D430 File Offset: 0x0050B630
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

			// Token: 0x17003B34 RID: 15156
			// (get) Token: 0x06013D03 RID: 81155 RVA: 0x0050D440 File Offset: 0x0050B640
			// (set) Token: 0x06013D04 RID: 81156 RVA: 0x0050D450 File Offset: 0x0050B650
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17003B35 RID: 15157
			// (get) Token: 0x06013D05 RID: 81157 RVA: 0x0050D460 File Offset: 0x0050B660
			// (set) Token: 0x06013D06 RID: 81158 RVA: 0x0050D470 File Offset: 0x0050B670
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17003B36 RID: 15158
			// (get) Token: 0x06013D07 RID: 81159 RVA: 0x0050D480 File Offset: 0x0050B680
			// (set) Token: 0x06013D08 RID: 81160 RVA: 0x0050D490 File Offset: 0x0050B690
			public ScrollRect m_gameFunctionTypeListScrollRect
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeListScrollRect;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeListScrollRect = value;
				}
			}

			// Token: 0x17003B37 RID: 15159
			// (get) Token: 0x06013D09 RID: 81161 RVA: 0x0050D4A0 File Offset: 0x0050B6A0
			// (set) Token: 0x06013D0A RID: 81162 RVA: 0x0050D4B0 File Offset: 0x0050B6B0
			public Button m_gameFunctionTypeListDisableButton
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeListDisableButton;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeListDisableButton = value;
				}
			}

			// Token: 0x17003B38 RID: 15160
			// (get) Token: 0x06013D0B RID: 81163 RVA: 0x0050D4C0 File Offset: 0x0050B6C0
			// (set) Token: 0x06013D0C RID: 81164 RVA: 0x0050D4D0 File Offset: 0x0050B6D0
			public CommonUIStateController m_locationListUiStateController
			{
				get
				{
					return this.m_owner.m_locationListUiStateController;
				}
				set
				{
					this.m_owner.m_locationListUiStateController = value;
				}
			}

			// Token: 0x17003B39 RID: 15161
			// (get) Token: 0x06013D0D RID: 81165 RVA: 0x0050D4E0 File Offset: 0x0050B6E0
			// (set) Token: 0x06013D0E RID: 81166 RVA: 0x0050D4F0 File Offset: 0x0050B6F0
			public ScrollRect m_locationListScrollRect
			{
				get
				{
					return this.m_owner.m_locationListScrollRect;
				}
				set
				{
					this.m_owner.m_locationListScrollRect = value;
				}
			}

			// Token: 0x17003B3A RID: 15162
			// (get) Token: 0x06013D0F RID: 81167 RVA: 0x0050D500 File Offset: 0x0050B700
			// (set) Token: 0x06013D10 RID: 81168 RVA: 0x0050D510 File Offset: 0x0050B710
			public Button m_locationListCloseButton
			{
				get
				{
					return this.m_owner.m_locationListCloseButton;
				}
				set
				{
					this.m_owner.m_locationListCloseButton = value;
				}
			}

			// Token: 0x17003B3B RID: 15163
			// (get) Token: 0x06013D11 RID: 81169 RVA: 0x0050D520 File Offset: 0x0050B720
			// (set) Token: 0x06013D12 RID: 81170 RVA: 0x0050D530 File Offset: 0x0050B730
			public Button m_locationListDisableButton
			{
				get
				{
					return this.m_owner.m_locationListDisableButton;
				}
				set
				{
					this.m_owner.m_locationListDisableButton = value;
				}
			}

			// Token: 0x17003B3C RID: 15164
			// (get) Token: 0x06013D13 RID: 81171 RVA: 0x0050D540 File Offset: 0x0050B740
			// (set) Token: 0x06013D14 RID: 81172 RVA: 0x0050D550 File Offset: 0x0050B750
			public Text m_titleText
			{
				get
				{
					return this.m_owner.m_titleText;
				}
				set
				{
					this.m_owner.m_titleText = value;
				}
			}

			// Token: 0x17003B3D RID: 15165
			// (get) Token: 0x06013D15 RID: 81173 RVA: 0x0050D560 File Offset: 0x0050B760
			// (set) Token: 0x06013D16 RID: 81174 RVA: 0x0050D570 File Offset: 0x0050B770
			public ScrollRect m_roomListScrollRect
			{
				get
				{
					return this.m_owner.m_roomListScrollRect;
				}
				set
				{
					this.m_owner.m_roomListScrollRect = value;
				}
			}

			// Token: 0x17003B3E RID: 15166
			// (get) Token: 0x06013D17 RID: 81175 RVA: 0x0050D580 File Offset: 0x0050B780
			// (set) Token: 0x06013D18 RID: 81176 RVA: 0x0050D590 File Offset: 0x0050B790
			public Button m_createTeamRoomButton
			{
				get
				{
					return this.m_owner.m_createTeamRoomButton;
				}
				set
				{
					this.m_owner.m_createTeamRoomButton = value;
				}
			}

			// Token: 0x17003B3F RID: 15167
			// (get) Token: 0x06013D19 RID: 81177 RVA: 0x0050D5A0 File Offset: 0x0050B7A0
			// (set) Token: 0x06013D1A RID: 81178 RVA: 0x0050D5B0 File Offset: 0x0050B7B0
			public Button m_refreshTeamRoomButton
			{
				get
				{
					return this.m_owner.m_refreshTeamRoomButton;
				}
				set
				{
					this.m_owner.m_refreshTeamRoomButton = value;
				}
			}

			// Token: 0x17003B40 RID: 15168
			// (get) Token: 0x06013D1B RID: 81179 RVA: 0x0050D5C0 File Offset: 0x0050B7C0
			// (set) Token: 0x06013D1C RID: 81180 RVA: 0x0050D5D0 File Offset: 0x0050B7D0
			public Button m_autoMatchButton
			{
				get
				{
					return this.m_owner.m_autoMatchButton;
				}
				set
				{
					this.m_owner.m_autoMatchButton = value;
				}
			}

			// Token: 0x17003B41 RID: 15169
			// (get) Token: 0x06013D1D RID: 81181 RVA: 0x0050D5E0 File Offset: 0x0050B7E0
			// (set) Token: 0x06013D1E RID: 81182 RVA: 0x0050D5F0 File Offset: 0x0050B7F0
			public CommonUIStateController m_noTeamRoomUIStateController
			{
				get
				{
					return this.m_owner.m_noTeamRoomUIStateController;
				}
				set
				{
					this.m_owner.m_noTeamRoomUIStateController = value;
				}
			}

			// Token: 0x17003B42 RID: 15170
			// (get) Token: 0x06013D1F RID: 81183 RVA: 0x0050D600 File Offset: 0x0050B800
			// (set) Token: 0x06013D20 RID: 81184 RVA: 0x0050D610 File Offset: 0x0050B810
			public Button m_autoMatchCancelButton
			{
				get
				{
					return this.m_owner.m_autoMatchCancelButton;
				}
				set
				{
					this.m_owner.m_autoMatchCancelButton = value;
				}
			}

			// Token: 0x17003B43 RID: 15171
			// (get) Token: 0x06013D21 RID: 81185 RVA: 0x0050D620 File Offset: 0x0050B820
			// (set) Token: 0x06013D22 RID: 81186 RVA: 0x0050D630 File Offset: 0x0050B830
			public Text m_autoMatchWaitCountText
			{
				get
				{
					return this.m_owner.m_autoMatchWaitCountText;
				}
				set
				{
					this.m_owner.m_autoMatchWaitCountText = value;
				}
			}

			// Token: 0x17003B44 RID: 15172
			// (get) Token: 0x06013D23 RID: 81187 RVA: 0x0050D640 File Offset: 0x0050B840
			// (set) Token: 0x06013D24 RID: 81188 RVA: 0x0050D650 File Offset: 0x0050B850
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

			// Token: 0x17003B45 RID: 15173
			// (get) Token: 0x06013D25 RID: 81189 RVA: 0x0050D660 File Offset: 0x0050B860
			// (set) Token: 0x06013D26 RID: 81190 RVA: 0x0050D670 File Offset: 0x0050B870
			public GameObject m_gameFunctionTypeListItemPrefab
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeListItemPrefab;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeListItemPrefab = value;
				}
			}

			// Token: 0x17003B46 RID: 15174
			// (get) Token: 0x06013D27 RID: 81191 RVA: 0x0050D680 File Offset: 0x0050B880
			// (set) Token: 0x06013D28 RID: 81192 RVA: 0x0050D690 File Offset: 0x0050B890
			public GameObject m_locationListItemPrefab
			{
				get
				{
					return this.m_owner.m_locationListItemPrefab;
				}
				set
				{
					this.m_owner.m_locationListItemPrefab = value;
				}
			}

			// Token: 0x17003B47 RID: 15175
			// (get) Token: 0x06013D29 RID: 81193 RVA: 0x0050D6A0 File Offset: 0x0050B8A0
			// (set) Token: 0x06013D2A RID: 81194 RVA: 0x0050D6B0 File Offset: 0x0050B8B0
			public GameObject m_roomListItemPrefab
			{
				get
				{
					return this.m_owner.m_roomListItemPrefab;
				}
				set
				{
					this.m_owner.m_roomListItemPrefab = value;
				}
			}

			// Token: 0x17003B48 RID: 15176
			// (get) Token: 0x06013D2B RID: 81195 RVA: 0x0050D6C0 File Offset: 0x0050B8C0
			// (set) Token: 0x06013D2C RID: 81196 RVA: 0x0050D6D0 File Offset: 0x0050B8D0
			public List<TeamGameFunctionTypeListItemUIController> m_gameFunctionTypeListItems
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

			// Token: 0x17003B49 RID: 15177
			// (get) Token: 0x06013D2D RID: 81197 RVA: 0x0050D6E0 File Offset: 0x0050B8E0
			// (set) Token: 0x06013D2E RID: 81198 RVA: 0x0050D6F0 File Offset: 0x0050B8F0
			public List<TeamLocationListItemUIController> m_locationListItems
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

			// Token: 0x17003B4A RID: 15178
			// (get) Token: 0x06013D2F RID: 81199 RVA: 0x0050D700 File Offset: 0x0050B900
			// (set) Token: 0x06013D30 RID: 81200 RVA: 0x0050D710 File Offset: 0x0050B910
			public List<TeamRoomListItemUIController> m_roomListItems
			{
				get
				{
					return this.m_owner.m_roomListItems;
				}
				set
				{
					this.m_owner.m_roomListItems = value;
				}
			}

			// Token: 0x17003B4B RID: 15179
			// (get) Token: 0x06013D31 RID: 81201 RVA: 0x0050D720 File Offset: 0x0050B920
			// (set) Token: 0x06013D32 RID: 81202 RVA: 0x0050D730 File Offset: 0x0050B930
			public bool m_isIgnoreFireSelectEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreFireSelectEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreFireSelectEvent = value;
				}
			}

			// Token: 0x06013D33 RID: 81203 RVA: 0x0050D740 File Offset: 0x0050B940
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013D34 RID: 81204 RVA: 0x0050D750 File Offset: 0x0050B950
			public void AddGameFunctionTypeListItems()
			{
				this.m_owner.AddGameFunctionTypeListItems();
			}

			// Token: 0x06013D35 RID: 81205 RVA: 0x0050D760 File Offset: 0x0050B960
			public void ClearGameFunctionTypeListItems()
			{
				this.m_owner.ClearGameFunctionTypeListItems();
			}

			// Token: 0x06013D36 RID: 81206 RVA: 0x0050D770 File Offset: 0x0050B970
			public void AddGameFunctionTypeListItem(string name, GameFunctionType gameFunctionType, int chapterId, bool isLocked)
			{
				this.m_owner.AddGameFunctionTypeListItem(name, gameFunctionType, chapterId, isLocked);
			}

			// Token: 0x06013D37 RID: 81207 RVA: 0x0050D784 File Offset: 0x0050B984
			public void AddLocationListItems(GameFunctionType gameFunctionType, int chapterId)
			{
				this.m_owner.AddLocationListItems(gameFunctionType, chapterId);
			}

			// Token: 0x06013D38 RID: 81208 RVA: 0x0050D794 File Offset: 0x0050B994
			public void ClearLocationListItems()
			{
				this.m_owner.ClearLocationListItems();
			}

			// Token: 0x06013D39 RID: 81209 RVA: 0x0050D7A4 File Offset: 0x0050B9A4
			public void AddLocationListItem(string name, int locationId, int energy, bool isLocked)
			{
				this.m_owner.AddLocationListItem(name, locationId, energy, isLocked);
			}

			// Token: 0x06013D3A RID: 81210 RVA: 0x0050D7B8 File Offset: 0x0050B9B8
			public void AddTeamRoomListItem(TeamRoom room)
			{
				this.m_owner.AddTeamRoomListItem(room);
			}

			// Token: 0x06013D3B RID: 81211 RVA: 0x0050D7C8 File Offset: 0x0050B9C8
			public void ClearTeamRoomListItems()
			{
				this.m_owner.ClearTeamRoomListItems();
			}

			// Token: 0x06013D3C RID: 81212 RVA: 0x0050D7D8 File Offset: 0x0050B9D8
			public void UpdateTitle()
			{
				this.m_owner.UpdateTitle();
			}

			// Token: 0x06013D3D RID: 81213 RVA: 0x0050D7E8 File Offset: 0x0050B9E8
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06013D3E RID: 81214 RVA: 0x0050D7F8 File Offset: 0x0050B9F8
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06013D3F RID: 81215 RVA: 0x0050D808 File Offset: 0x0050BA08
			public void OnRefreshTeamRoomButtonClick()
			{
				this.m_owner.OnRefreshTeamRoomButtonClick();
			}

			// Token: 0x06013D40 RID: 81216 RVA: 0x0050D818 File Offset: 0x0050BA18
			public void OnShowCreateTeamRoomButtonClick()
			{
				this.m_owner.OnShowCreateTeamRoomButtonClick();
			}

			// Token: 0x06013D41 RID: 81217 RVA: 0x0050D828 File Offset: 0x0050BA28
			public void OnAutoMatchButtonClick()
			{
				this.m_owner.OnAutoMatchButtonClick();
			}

			// Token: 0x06013D42 RID: 81218 RVA: 0x0050D838 File Offset: 0x0050BA38
			public void OnAutoMatchCancelButtonClick()
			{
				this.m_owner.OnAutoMatchCancelButtonClick();
			}

			// Token: 0x06013D43 RID: 81219 RVA: 0x0050D848 File Offset: 0x0050BA48
			public void OnLocationListCloseButtonClick()
			{
				this.m_owner.OnLocationListCloseButtonClick();
			}

			// Token: 0x06013D44 RID: 81220 RVA: 0x0050D858 File Offset: 0x0050BA58
			public void TeamGameFunctionTypeListItem_OnToggleValueChanged(bool isOn, TeamGameFunctionTypeListItemUIController ctrl)
			{
				this.m_owner.TeamGameFunctionTypeListItem_OnToggleValueChanged(isOn, ctrl);
			}

			// Token: 0x06013D45 RID: 81221 RVA: 0x0050D868 File Offset: 0x0050BA68
			public TeamGameFunctionTypeListItemUIController GetSelectedGameFunctionTypeListItem()
			{
				return this.m_owner.GetSelectedGameFunctionTypeListItem();
			}

			// Token: 0x06013D46 RID: 81222 RVA: 0x0050D878 File Offset: 0x0050BA78
			public TeamLocationListItemUIController GetSelectedLocationListItem()
			{
				return this.m_owner.GetSelectedLocationListItem();
			}

			// Token: 0x06013D47 RID: 81223 RVA: 0x0050D888 File Offset: 0x0050BA88
			public void TeamLocationListItem_OnToggleValueChanged(bool isOn, TeamLocationListItemUIController ctrl)
			{
				this.m_owner.TeamLocationListItem_OnToggleValueChanged(isOn, ctrl);
			}

			// Token: 0x06013D48 RID: 81224 RVA: 0x0050D898 File Offset: 0x0050BA98
			public void TeamRoomListItem_OnJoinButtonClick(TeamRoomListItemUIController ctrl)
			{
				this.m_owner.TeamRoomListItem_OnJoinButtonClick(ctrl);
			}

			// Token: 0x0400AF6A RID: 44906
			private TeamUIController m_owner;
		}
	}
}
