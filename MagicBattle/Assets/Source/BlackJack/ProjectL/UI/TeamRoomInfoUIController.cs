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
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F68 RID: 3944
	[HotFix]
	public class TeamRoomInfoUIController : UIControllerBase
	{
		// Token: 0x0601396E RID: 80238 RVA: 0x004FE0D4 File Offset: 0x004FC2D4
		private TeamRoomInfoUIController()
		{
		}

		// Token: 0x0601396F RID: 80239 RVA: 0x004FE0F4 File Offset: 0x004FC2F4
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
			this.m_leaveButton.onClick.AddListener(new UnityAction(this.OnLeaveButtonClick));
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_showChangePlayerPositionButton.onClick.AddListener(new UnityAction(this.OnShowChangePlayerPositionButtonClick));
			this.m_changePlayerPositionCompleteButton.onClick.AddListener(new UnityAction(this.OnChangePlayerPositionCompleteButtonClick));
			this.m_chatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_authorityDropdown.onValueChanged.AddListener(new UnityAction<int>(this.OnAuthorityDropdownValueChanged));
			this.m_authorityLockButton.onClick.AddListener(new UnityAction(this.OnAuthorityLockButtonClick));
			for (int i = 0; i < 3; i++)
			{
				Transform playerInfoParent = this.GetPlayerInfoParent(i, false);
				if (playerInfoParent != null)
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_playerInfoPrefab, playerInfoParent, false);
					TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = this.m_playerInfoUIControllers[i] = GameObjectUtility.AddControllerToGameObject<TeamRoomPlayerInfoUIController>(go);
					teamRoomPlayerInfoUIController.SetIndex(i);
					teamRoomPlayerInfoUIController.SetPlayerIndex(i);
					GameObject gameObject = this.m_expressionResContainer.GetAsset("EmojiShowImage") as GameObject;
					teamRoomPlayerInfoUIController.InitEmojiText(this.m_expressionParseDesc.m_emSpace, gameObject.GetComponent<Image>());
					teamRoomPlayerInfoUIController.EventOnInviteButtonClick += this.TeamRoomPlayerInfoUIController_OnInviteButtonClick;
					teamRoomPlayerInfoUIController.EventOnPlayerButtonClick += this.TeamRoomPlayerInfoUIController_OnPlayerButtonClick;
				}
			}
			for (int j = 0; j < 3; j++)
			{
				Transform playerInfoParent2 = this.GetPlayerInfoParent(j, true);
				if (playerInfoParent2 != null)
				{
					GameObject go2 = UnityEngine.Object.Instantiate<GameObject>(this.m_playerInfoPrefab, playerInfoParent2, false);
					TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController2 = this.m_editPlayerInfoUIControllers[j] = GameObjectUtility.AddControllerToGameObject<TeamRoomPlayerInfoUIController>(go2);
					teamRoomPlayerInfoUIController2.SetIndex(j);
					teamRoomPlayerInfoUIController2.EventOnBeginDrag += this.TeamRoomPlayerInfoUIController_OnBeginDrag;
					teamRoomPlayerInfoUIController2.EventOnEndDrag += this.TeamRoomPlayerInfoUIController_OnEndDrag;
					teamRoomPlayerInfoUIController2.EventOnDrag += this.TeamRoomPlayerInfoUIController_OnDrag;
				}
			}
			this.m_changePlayerPositionPanelGameObject.SetActive(false);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x06013970 RID: 80240 RVA: 0x004FE378 File Offset: 0x004FC578
		private Transform GetPlayerInfoParent(int idx, bool isEdit)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerInfoParentInt32Boolean_hotfix != null)
			{
				return (Transform)this.m_GetPlayerInfoParentInt32Boolean_hotfix.call(new object[]
				{
					this,
					idx,
					isEdit
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = null;
			if (isEdit)
			{
				if (idx == 0)
				{
					gameObject = this.m_changePlayerPositionInfo0GameObject;
				}
				else if (idx == 1)
				{
					gameObject = this.m_changePlayerPositionInfo1GameObject;
				}
				else if (idx == 2)
				{
					gameObject = this.m_changePlayerPositionInfo2GameObject;
				}
			}
			else if (idx == 0)
			{
				gameObject = this.m_playerInfo0GameObject;
			}
			else if (idx == 1)
			{
				gameObject = this.m_playerInfo1GameObject;
			}
			else if (idx == 2)
			{
				gameObject = this.m_playerInfo2GameObject;
			}
			if (gameObject != null)
			{
				return gameObject.transform;
			}
			return null;
		}

		// Token: 0x06013971 RID: 80241 RVA: 0x004FE48C File Offset: 0x004FC68C
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingPlayerInfoUIController != null)
			{
				this.DestroyDragginPlayerInfoUIController();
			}
		}

		// Token: 0x06013972 RID: 80242 RVA: 0x004FE504 File Offset: 0x004FC704
		private void OnApplicationPause(bool isPause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationPauseBoolean_hotfix != null)
			{
				this.m_OnApplicationPauseBoolean_hotfix.call(new object[]
				{
					this,
					isPause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingPlayerInfoUIController != null)
			{
				this.DestroyDragginPlayerInfoUIController();
			}
		}

		// Token: 0x06013973 RID: 80243 RVA: 0x004FE58C File Offset: 0x004FC78C
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
			this.m_waitStartBattleGameObject.SetActive(false);
		}

		// Token: 0x06013974 RID: 80244 RVA: 0x004FE60C File Offset: 0x004FC80C
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

		// Token: 0x06013975 RID: 80245 RVA: 0x004FE690 File Offset: 0x004FC890
		public void SetTeamRoomSetting(TeamRoomSetting setting)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamRoomSettingTeamRoomSetting_hotfix != null)
			{
				this.m_SetTeamRoomSettingTeamRoomSetting_hotfix.call(new object[]
				{
					this,
					setting
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildOrTeamUIStateController.SetToUIState((setting.GameFunctionTypeId != GameFunctionType.GameFunctionType_GuildMassiveCombat) ? "Team" : "Guild", false, true);
			this.SetBattleName(setting.GameFunctionTypeId, setting.LocationId);
			this.SetPlayerLevelRange(setting.JoinMinLevel, setting.JoinMaxLevel);
			this.SetAuthority(setting.Authority);
		}

		// Token: 0x06013976 RID: 80246 RVA: 0x004FE75C File Offset: 0x004FC95C
		public void SetTeamRoomPlayers(List<TeamRoomPlayer> players, bool isLeader)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamRoomPlayersList`1Boolean_hotfix != null)
			{
				this.m_SetTeamRoomPlayersList`1Boolean_hotfix.call(new object[]
				{
					this,
					players,
					isLeader
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int i;
			for (i = 0; i < this.m_playerInfoUIControllers.Length; i++)
			{
				TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = this.m_playerInfoUIControllers[i];
				TeamRoomPlayer teamRoomPlayer = players.Find((TeamRoomPlayer p) => p.Position == i);
				if (teamRoomPlayer != null)
				{
					teamRoomPlayerInfoUIController.SetOn(true);
					teamRoomPlayerInfoUIController.SetPlayer(teamRoomPlayer);
				}
				else
				{
					teamRoomPlayerInfoUIController.SetOn(false);
					teamRoomPlayerInfoUIController.SetPlayer(null);
				}
			}
			if (isLeader && players.Count >= 2)
			{
				this.m_startButtonUIStateController.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_startButtonUIStateController.SetToUIState("Grey", false, true);
			}
			this.m_startButtonUIStateController.gameObject.SetActive(isLeader);
			this.m_authorityLockButton.gameObject.SetActive(!isLeader);
			this.m_showChangePlayerPositionButton.gameObject.SetActive(isLeader);
		}

		// Token: 0x06013977 RID: 80247 RVA: 0x004FE8C8 File Offset: 0x004FCAC8
		private void SetBattleName(GameFunctionType gameFunctionType, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleNameGameFunctionTypeInt32_hotfix != null)
			{
				this.m_SetBattleNameGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionType,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (gameFunctionType == GameFunctionType.GameFunctionType_GuildMassiveCombat)
			{
				this.m_guildMassiveCombatNameText.text = TeamUIController.GetGameFunctionName(gameFunctionType, locationId);
			}
			else
			{
				this.m_gameFunctionTypeNameText.text = TeamUIController.GetGameFunctionName(gameFunctionType, locationId);
				this.m_locationNameText.text = TeamUIController.GetLocationName(gameFunctionType, locationId);
				this.m_energyText.text = TeamUIController.GetEnergy(gameFunctionType, locationId).ToString();
			}
		}

		// Token: 0x06013978 RID: 80248 RVA: 0x004FE9AC File Offset: 0x004FCBAC
		private void SetPlayerLevelRange(int levelMin, int levelMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerLevelRangeInt32Int32_hotfix != null)
			{
				this.m_SetPlayerLevelRangeInt32Int32_hotfix.call(new object[]
				{
					this,
					levelMin,
					levelMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerLevelText.text = string.Format("{0} - {1}", levelMin, levelMax);
		}

		// Token: 0x06013979 RID: 80249 RVA: 0x004FEA50 File Offset: 0x004FCC50
		public void SetAuthority(TeamRoomAuthority authority)
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
			int value = 0;
			if (authority == TeamRoomAuthority.AllPublic)
			{
				value = 0;
			}
			else if (authority == TeamRoomAuthority.FriendAndGuild)
			{
				value = 1;
			}
			else if (authority == TeamRoomAuthority.NonPublic)
			{
				value = 2;
			}
			else if (authority == TeamRoomAuthority.GuildMassiveCombat)
			{
				value = 2;
			}
			this.m_isIgnoreToggleEvent = true;
			this.m_authorityDropdown.value = value;
			this.m_isIgnoreToggleEvent = false;
		}

		// Token: 0x0601397A RID: 80250 RVA: 0x004FEB10 File Offset: 0x004FCD10
		public void SetQuitCountdown(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetQuitCountdownTimeSpan_hotfix != null)
			{
				this.m_SetQuitCountdownTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_RoomCountdown);
			this.m_quitCountdownText.text = string.Format(format, ts.Minutes, ts.Seconds);
		}

		// Token: 0x0601397B RID: 80251 RVA: 0x004FEBC8 File Offset: 0x004FCDC8
		public void ShowWaitStartBattle(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitStartBattleBoolean_hotfix != null)
			{
				this.m_ShowWaitStartBattleBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_waitStartBattleGameObject.SetActive(show);
		}

		// Token: 0x0601397C RID: 80252 RVA: 0x004FEC44 File Offset: 0x004FCE44
		public void ShowChangePlayerPosition(TeamRoom teamRoom)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChangePlayerPositionTeamRoom_hotfix != null)
			{
				this.m_ShowChangePlayerPositionTeamRoom_hotfix.call(new object[]
				{
					this,
					teamRoom
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changePlayerPositionPanelGameObject.SetActive(true);
			for (int i = 0; i < this.m_editPlayerInfoUIControllers.Length; i++)
			{
				TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController = this.m_editPlayerInfoUIControllers[i];
				TeamRoomPlayer teamRoomPlayer = teamRoom.FindTeamRoomPlayerAtPosition(i);
				if (teamRoomPlayer != null)
				{
					teamRoomPlayerInfoUIController.SetEditOn(true);
					teamRoomPlayerInfoUIController.SetPlayer(teamRoomPlayer);
				}
				else
				{
					teamRoomPlayerInfoUIController.SetEditOn(false);
				}
			}
		}

		// Token: 0x0601397D RID: 80253 RVA: 0x004FED0C File Offset: 0x004FCF0C
		public void HideChangePlayerPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideChangePlayerPosition_hotfix != null)
			{
				this.m_HideChangePlayerPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changePlayerPositionPanelGameObject.SetActive(false);
		}

		// Token: 0x0601397E RID: 80254 RVA: 0x004FED78 File Offset: 0x004FCF78
		public int GetPlayerChangedPosition(TeamRoomPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerChangedPositionTeamRoomPlayer_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerChangedPositionTeamRoomPlayer_hotfix.call(new object[]
				{
					this,
					player
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController in this.m_editPlayerInfoUIControllers)
			{
				if (teamRoomPlayerInfoUIController.GetPlayer() == player)
				{
					return teamRoomPlayerInfoUIController.GetIndex();
				}
			}
			return -1;
		}

		// Token: 0x0601397F RID: 80255 RVA: 0x004FEE28 File Offset: 0x004FD028
		public void ShowPlayerChat(int playerIndex, string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerChatInt32String_hotfix != null)
			{
				this.m_ShowPlayerChatInt32String_hotfix.call(new object[]
				{
					this,
					playerIndex,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (playerIndex < 0 || playerIndex >= this.m_playerInfoUIControllers.Length)
			{
				return;
			}
			this.m_playerInfoUIControllers[playerIndex].ShowChat(text);
		}

		// Token: 0x06013980 RID: 80256 RVA: 0x004FEECC File Offset: 0x004FD0CC
		public void ShowPlayerBigExpression(int playerIndex, int expressionID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerBigExpressionInt32Int32_hotfix != null)
			{
				this.m_ShowPlayerBigExpressionInt32Int32_hotfix.call(new object[]
				{
					this,
					playerIndex,
					expressionID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (playerIndex < 0 || playerIndex >= this.m_playerInfoUIControllers.Length)
			{
				return;
			}
			this.m_playerInfoUIControllers[playerIndex].ShowBigExpression(expressionID);
		}

		// Token: 0x06013981 RID: 80257 RVA: 0x004FEF70 File Offset: 0x004FD170
		private void CreateDraggingPlayerInfoUIController(TeamRoomPlayerInfoUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDraggingPlayerInfoUIControllerTeamRoomPlayerInfoUIController_hotfix != null)
			{
				this.m_CreateDraggingPlayerInfoUIControllerTeamRoomPlayerInfoUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginPlayerInfoUIController();
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_playerInfoPrefab, componentInParent.transform, false);
			gameObject.transform.SetAsLastSibling();
			this.m_draggingPlayerInfoUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomPlayerInfoUIController>(gameObject);
			this.m_draggingPlayerInfoUIController.SetIndex(ctrl.GetIndex());
			this.m_draggingPlayerInfoUIController.SetPlayer(ctrl.GetPlayer());
			this.m_draggingPlayerInfoUIController.SetAnimationTime(ctrl.GetAnimationTime());
			this.m_draggingPlayerInfoUIController.SetEditOn(true);
			this.m_draggingPlayerInfoUIController.EventOnDrop += this.TeamRoomPlayerInfoUIController_OnDrop;
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DragHero);
			CommonUIController.Instance.EnableInput(false);
		}

		// Token: 0x06013982 RID: 80258 RVA: 0x004FF080 File Offset: 0x004FD280
		private void DestroyDragginPlayerInfoUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyDragginPlayerInfoUIController_hotfix != null)
			{
				this.m_DestroyDragginPlayerInfoUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingPlayerInfoUIController == null)
			{
				return;
			}
			UnityEngine.Object.Destroy(this.m_draggingPlayerInfoUIController.gameObject);
			this.m_draggingPlayerInfoUIController = null;
			CommonUIController.Instance.EnableInput(true);
		}

		// Token: 0x06013983 RID: 80259 RVA: 0x004FF114 File Offset: 0x004FD314
		private void MoveDraggingPlayerInfoUIController(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveDraggingPlayerInfoUIControllerVector2_hotfix != null)
			{
				this.m_MoveDraggingPlayerInfoUIControllerVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingPlayerInfoUIController == null)
			{
				return;
			}
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			RectTransform rect = componentInParent.transform as RectTransform;
			Camera componentInParent2 = base.GetComponentInParent<Camera>();
			Vector3 position;
			if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, pos, componentInParent2, out position))
			{
				position.y += 0.3f;
				this.m_draggingPlayerInfoUIController.transform.position = position;
			}
		}

		// Token: 0x06013984 RID: 80260 RVA: 0x004FF1E4 File Offset: 0x004FD3E4
		private void DropDraggingPlayerInfoUIController(Vector3 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DropDraggingPlayerInfoUIControllerVector3_hotfix != null)
			{
				this.m_DropDraggingPlayerInfoUIControllerVector3_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingPlayerInfoUIController == null)
			{
				return;
			}
			Camera componentInParent = base.GetComponentInParent<Camera>();
			foreach (TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController in this.m_editPlayerInfoUIControllers)
			{
				RectTransform rect = teamRoomPlayerInfoUIController.transform as RectTransform;
				if (RectTransformUtility.RectangleContainsScreenPoint(rect, pos, componentInParent))
				{
					int index = this.m_draggingPlayerInfoUIController.GetIndex();
					int index2 = teamRoomPlayerInfoUIController.GetIndex();
					TeamRoomPlayerInfoUIController teamRoomPlayerInfoUIController2 = this.m_editPlayerInfoUIControllers[index];
					this.m_editPlayerInfoUIControllers[index] = this.m_editPlayerInfoUIControllers[index2];
					this.m_editPlayerInfoUIControllers[index2] = teamRoomPlayerInfoUIController2;
					AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
					break;
				}
			}
			for (int j = 0; j < this.m_editPlayerInfoUIControllers.Length; j++)
			{
				this.m_editPlayerInfoUIControllers[j].SetIndex(j);
				this.m_editPlayerInfoUIControllers[j].transform.SetParent(this.GetPlayerInfoParent(j, true), false);
			}
			this.DestroyDragginPlayerInfoUIController();
		}

		// Token: 0x06013985 RID: 80261 RVA: 0x004FF344 File Offset: 0x004FD544
		private void OnLeaveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLeaveButtonClick_hotfix != null)
			{
				this.m_OnLeaveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLeave != null)
			{
				this.EventOnLeave();
			}
		}

		// Token: 0x06013986 RID: 80262 RVA: 0x004FF3BC File Offset: 0x004FD5BC
		private void OnStartButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartButtonClick_hotfix != null)
			{
				this.m_OnStartButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_startButtonUIStateController) == "Normal" && this.EventOnStart != null)
			{
				this.EventOnStart();
			}
		}

		// Token: 0x06013987 RID: 80263 RVA: 0x004FF44C File Offset: 0x004FD64C
		private void OnShowChangePlayerPositionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowChangePlayerPositionButtonClick_hotfix != null)
			{
				this.m_OnShowChangePlayerPositionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowChangePlayerPosition != null)
			{
				this.EventOnShowChangePlayerPosition();
			}
		}

		// Token: 0x06013988 RID: 80264 RVA: 0x004FF4C4 File Offset: 0x004FD6C4
		private void OnChangePlayerPositionCompleteButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangePlayerPositionCompleteButtonClick_hotfix != null)
			{
				this.m_OnChangePlayerPositionCompleteButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChangePlayerPositionComplete != null)
			{
				this.EventOnChangePlayerPositionComplete();
			}
		}

		// Token: 0x06013989 RID: 80265 RVA: 0x004FF53C File Offset: 0x004FD73C
		private void OnChatButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatButtonClick_hotfix != null)
			{
				this.m_OnChatButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowChat != null)
			{
				this.EventOnShowChat();
			}
		}

		// Token: 0x0601398A RID: 80266 RVA: 0x004FF5B4 File Offset: 0x004FD7B4
		private void OnAuthorityDropdownValueChanged(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAuthorityDropdownValueChangedInt32_hotfix != null)
			{
				this.m_OnAuthorityDropdownValueChangedInt32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (this.EventOnChangeAuthority != null)
			{
				TeamRoomAuthority obj = TeamRoomAuthority.AllPublic;
				if (value == 0)
				{
					obj = TeamRoomAuthority.AllPublic;
				}
				else if (value == 1)
				{
					obj = TeamRoomAuthority.FriendAndGuild;
				}
				else if (value == 2)
				{
					obj = TeamRoomAuthority.NonPublic;
				}
				this.EventOnChangeAuthority(obj);
			}
		}

		// Token: 0x0601398B RID: 80267 RVA: 0x004FF670 File Offset: 0x004FD870
		private void OnAuthorityLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAuthorityLockButtonClick_hotfix != null)
			{
				this.m_OnAuthorityLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!(UIUtility.GetUIStateCurrentStateName(this.m_guildOrTeamUIStateController) == "Guild"))
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Team_CanNotChangeAuthority, 2f, null, true);
			}
		}

		// Token: 0x0601398C RID: 80268 RVA: 0x004FF708 File Offset: 0x004FD908
		private void TeamRoomPlayerInfoUIController_OnInviteButtonClick(TeamRoomPlayerInfoUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomPlayerInfoUIController_OnInviteButtonClickTeamRoomPlayerInfoUIController_hotfix != null)
			{
				this.m_TeamRoomPlayerInfoUIController_OnInviteButtonClickTeamRoomPlayerInfoUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowInvite != null)
			{
				this.EventOnShowInvite();
			}
		}

		// Token: 0x0601398D RID: 80269 RVA: 0x004FF790 File Offset: 0x004FD990
		private void TeamRoomPlayerInfoUIController_OnPlayerButtonClick(TeamRoomPlayerInfoUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomPlayerInfoUIController_OnPlayerButtonClickTeamRoomPlayerInfoUIController_hotfix != null)
			{
				this.m_TeamRoomPlayerInfoUIController_OnPlayerButtonClickTeamRoomPlayerInfoUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerInfo != null)
			{
				this.EventOnShowPlayerInfo(ctrl.GetIndex(), ctrl.transform as RectTransform);
			}
		}

		// Token: 0x0601398E RID: 80270 RVA: 0x004FF828 File Offset: 0x004FDA28
		private void TeamRoomPlayerInfoUIController_OnBeginDrag(TeamRoomPlayerInfoUIController ctrl, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomPlayerInfoUIController_OnBeginDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix != null)
			{
				this.m_TeamRoomPlayerInfoUIController_OnBeginDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix.call(new object[]
				{
					this,
					ctrl,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.GetPlayer() == null)
			{
				return;
			}
			this.CreateDraggingPlayerInfoUIController(ctrl);
		}

		// Token: 0x0601398F RID: 80271 RVA: 0x004FF8BC File Offset: 0x004FDABC
		private void TeamRoomPlayerInfoUIController_OnEndDrag(TeamRoomPlayerInfoUIController ctrl, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomPlayerInfoUIController_OnEndDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix != null)
			{
				this.m_TeamRoomPlayerInfoUIController_OnEndDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix.call(new object[]
				{
					this,
					ctrl,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginPlayerInfoUIController();
		}

		// Token: 0x06013990 RID: 80272 RVA: 0x004FF944 File Offset: 0x004FDB44
		private void TeamRoomPlayerInfoUIController_OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomPlayerInfoUIController_OnDragPointerEventData_hotfix != null)
			{
				this.m_TeamRoomPlayerInfoUIController_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MoveDraggingPlayerInfoUIController(eventData.position);
		}

		// Token: 0x06013991 RID: 80273 RVA: 0x004FF9C0 File Offset: 0x004FDBC0
		public void TeamRoomPlayerInfoUIController_OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamRoomPlayerInfoUIController_OnDropPointerEventData_hotfix != null)
			{
				this.m_TeamRoomPlayerInfoUIController_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DropDraggingPlayerInfoUIController(eventData.position);
		}

		// Token: 0x14000444 RID: 1092
		// (add) Token: 0x06013992 RID: 80274 RVA: 0x004FFA44 File Offset: 0x004FDC44
		// (remove) Token: 0x06013993 RID: 80275 RVA: 0x004FFAE0 File Offset: 0x004FDCE0
		public event Action EventOnLeave
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLeaveAction_hotfix != null)
				{
					this.m_add_EventOnLeaveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLeave;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLeave, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLeaveAction_hotfix != null)
				{
					this.m_remove_EventOnLeaveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLeave;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLeave, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000445 RID: 1093
		// (add) Token: 0x06013994 RID: 80276 RVA: 0x004FFB7C File Offset: 0x004FDD7C
		// (remove) Token: 0x06013995 RID: 80277 RVA: 0x004FFC18 File Offset: 0x004FDE18
		public event Action EventOnStart
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartAction_hotfix != null)
				{
					this.m_add_EventOnStartAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStart;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStart, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartAction_hotfix != null)
				{
					this.m_remove_EventOnStartAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStart;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStart, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000446 RID: 1094
		// (add) Token: 0x06013996 RID: 80278 RVA: 0x004FFCB4 File Offset: 0x004FDEB4
		// (remove) Token: 0x06013997 RID: 80279 RVA: 0x004FFD50 File Offset: 0x004FDF50
		public event Action EventOnShowChangePlayerPosition
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowChangePlayerPositionAction_hotfix != null)
				{
					this.m_add_EventOnShowChangePlayerPositionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChangePlayerPosition;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChangePlayerPosition, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowChangePlayerPositionAction_hotfix != null)
				{
					this.m_remove_EventOnShowChangePlayerPositionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChangePlayerPosition;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChangePlayerPosition, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000447 RID: 1095
		// (add) Token: 0x06013998 RID: 80280 RVA: 0x004FFDEC File Offset: 0x004FDFEC
		// (remove) Token: 0x06013999 RID: 80281 RVA: 0x004FFE88 File Offset: 0x004FE088
		public event Action EventOnChangePlayerPositionComplete
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangePlayerPositionCompleteAction_hotfix != null)
				{
					this.m_add_EventOnChangePlayerPositionCompleteAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnChangePlayerPositionComplete;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnChangePlayerPositionComplete, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangePlayerPositionCompleteAction_hotfix != null)
				{
					this.m_remove_EventOnChangePlayerPositionCompleteAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnChangePlayerPositionComplete;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnChangePlayerPositionComplete, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000448 RID: 1096
		// (add) Token: 0x0601399A RID: 80282 RVA: 0x004FFF24 File Offset: 0x004FE124
		// (remove) Token: 0x0601399B RID: 80283 RVA: 0x004FFFC0 File Offset: 0x004FE1C0
		public event Action EventOnShowChat
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowChatAction_hotfix != null)
				{
					this.m_add_EventOnShowChatAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChat;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChat, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowChatAction_hotfix != null)
				{
					this.m_remove_EventOnShowChatAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowChat;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowChat, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000449 RID: 1097
		// (add) Token: 0x0601399C RID: 80284 RVA: 0x0050005C File Offset: 0x004FE25C
		// (remove) Token: 0x0601399D RID: 80285 RVA: 0x005000F8 File Offset: 0x004FE2F8
		public event Action<TeamRoomAuthority> EventOnChangeAuthority
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeAuthorityAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeAuthorityAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomAuthority> action = this.EventOnChangeAuthority;
				Action<TeamRoomAuthority> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomAuthority>>(ref this.EventOnChangeAuthority, (Action<TeamRoomAuthority>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeAuthorityAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeAuthorityAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomAuthority> action = this.EventOnChangeAuthority;
				Action<TeamRoomAuthority> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomAuthority>>(ref this.EventOnChangeAuthority, (Action<TeamRoomAuthority>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400044A RID: 1098
		// (add) Token: 0x0601399E RID: 80286 RVA: 0x00500194 File Offset: 0x004FE394
		// (remove) Token: 0x0601399F RID: 80287 RVA: 0x00500230 File Offset: 0x004FE430
		public event Action EventOnShowInvite
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowInviteAction_hotfix != null)
				{
					this.m_add_EventOnShowInviteAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowInvite;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowInvite, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowInviteAction_hotfix != null)
				{
					this.m_remove_EventOnShowInviteAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowInvite;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowInvite, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400044B RID: 1099
		// (add) Token: 0x060139A0 RID: 80288 RVA: 0x005002CC File Offset: 0x004FE4CC
		// (remove) Token: 0x060139A1 RID: 80289 RVA: 0x00500368 File Offset: 0x004FE568
		public event Action<int, RectTransform> EventOnShowPlayerInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPlayerInfoAction`2_hotfix != null)
				{
					this.m_add_EventOnShowPlayerInfoAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, RectTransform> action = this.EventOnShowPlayerInfo;
				Action<int, RectTransform> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, RectTransform>>(ref this.EventOnShowPlayerInfo, (Action<int, RectTransform>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPlayerInfoAction`2_hotfix != null)
				{
					this.m_remove_EventOnShowPlayerInfoAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, RectTransform> action = this.EventOnShowPlayerInfo;
				Action<int, RectTransform> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, RectTransform>>(ref this.EventOnShowPlayerInfo, (Action<int, RectTransform>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x060139A2 RID: 80290 RVA: 0x00500404 File Offset: 0x004FE604
		// (set) Token: 0x060139A3 RID: 80291 RVA: 0x00500424 File Offset: 0x004FE624
		[DoNotToLua]
		public new TeamRoomInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060139A4 RID: 80292 RVA: 0x00500430 File Offset: 0x004FE630
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060139A5 RID: 80293 RVA: 0x0050043C File Offset: 0x004FE63C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060139A6 RID: 80294 RVA: 0x00500444 File Offset: 0x004FE644
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060139A7 RID: 80295 RVA: 0x0050044C File Offset: 0x004FE64C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060139A8 RID: 80296 RVA: 0x00500460 File Offset: 0x004FE660
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060139A9 RID: 80297 RVA: 0x00500468 File Offset: 0x004FE668
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060139AA RID: 80298 RVA: 0x00500474 File Offset: 0x004FE674
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060139AB RID: 80299 RVA: 0x00500480 File Offset: 0x004FE680
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060139AC RID: 80300 RVA: 0x0050048C File Offset: 0x004FE68C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060139AD RID: 80301 RVA: 0x00500498 File Offset: 0x004FE698
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060139AE RID: 80302 RVA: 0x005004A4 File Offset: 0x004FE6A4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060139AF RID: 80303 RVA: 0x005004B0 File Offset: 0x004FE6B0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060139B0 RID: 80304 RVA: 0x005004BC File Offset: 0x004FE6BC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060139B1 RID: 80305 RVA: 0x005004C8 File Offset: 0x004FE6C8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060139B2 RID: 80306 RVA: 0x005004D4 File Offset: 0x004FE6D4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060139B3 RID: 80307 RVA: 0x005004DC File Offset: 0x004FE6DC
		private void __callDele_EventOnLeave()
		{
			Action eventOnLeave = this.EventOnLeave;
			if (eventOnLeave != null)
			{
				eventOnLeave();
			}
		}

		// Token: 0x060139B4 RID: 80308 RVA: 0x005004FC File Offset: 0x004FE6FC
		private void __clearDele_EventOnLeave()
		{
			this.EventOnLeave = null;
		}

		// Token: 0x060139B5 RID: 80309 RVA: 0x00500508 File Offset: 0x004FE708
		private void __callDele_EventOnStart()
		{
			Action eventOnStart = this.EventOnStart;
			if (eventOnStart != null)
			{
				eventOnStart();
			}
		}

		// Token: 0x060139B6 RID: 80310 RVA: 0x00500528 File Offset: 0x004FE728
		private void __clearDele_EventOnStart()
		{
			this.EventOnStart = null;
		}

		// Token: 0x060139B7 RID: 80311 RVA: 0x00500534 File Offset: 0x004FE734
		private void __callDele_EventOnShowChangePlayerPosition()
		{
			Action eventOnShowChangePlayerPosition = this.EventOnShowChangePlayerPosition;
			if (eventOnShowChangePlayerPosition != null)
			{
				eventOnShowChangePlayerPosition();
			}
		}

		// Token: 0x060139B8 RID: 80312 RVA: 0x00500554 File Offset: 0x004FE754
		private void __clearDele_EventOnShowChangePlayerPosition()
		{
			this.EventOnShowChangePlayerPosition = null;
		}

		// Token: 0x060139B9 RID: 80313 RVA: 0x00500560 File Offset: 0x004FE760
		private void __callDele_EventOnChangePlayerPositionComplete()
		{
			Action eventOnChangePlayerPositionComplete = this.EventOnChangePlayerPositionComplete;
			if (eventOnChangePlayerPositionComplete != null)
			{
				eventOnChangePlayerPositionComplete();
			}
		}

		// Token: 0x060139BA RID: 80314 RVA: 0x00500580 File Offset: 0x004FE780
		private void __clearDele_EventOnChangePlayerPositionComplete()
		{
			this.EventOnChangePlayerPositionComplete = null;
		}

		// Token: 0x060139BB RID: 80315 RVA: 0x0050058C File Offset: 0x004FE78C
		private void __callDele_EventOnShowChat()
		{
			Action eventOnShowChat = this.EventOnShowChat;
			if (eventOnShowChat != null)
			{
				eventOnShowChat();
			}
		}

		// Token: 0x060139BC RID: 80316 RVA: 0x005005AC File Offset: 0x004FE7AC
		private void __clearDele_EventOnShowChat()
		{
			this.EventOnShowChat = null;
		}

		// Token: 0x060139BD RID: 80317 RVA: 0x005005B8 File Offset: 0x004FE7B8
		private void __callDele_EventOnChangeAuthority(TeamRoomAuthority obj)
		{
			Action<TeamRoomAuthority> eventOnChangeAuthority = this.EventOnChangeAuthority;
			if (eventOnChangeAuthority != null)
			{
				eventOnChangeAuthority(obj);
			}
		}

		// Token: 0x060139BE RID: 80318 RVA: 0x005005DC File Offset: 0x004FE7DC
		private void __clearDele_EventOnChangeAuthority(TeamRoomAuthority obj)
		{
			this.EventOnChangeAuthority = null;
		}

		// Token: 0x060139BF RID: 80319 RVA: 0x005005E8 File Offset: 0x004FE7E8
		private void __callDele_EventOnShowInvite()
		{
			Action eventOnShowInvite = this.EventOnShowInvite;
			if (eventOnShowInvite != null)
			{
				eventOnShowInvite();
			}
		}

		// Token: 0x060139C0 RID: 80320 RVA: 0x00500608 File Offset: 0x004FE808
		private void __clearDele_EventOnShowInvite()
		{
			this.EventOnShowInvite = null;
		}

		// Token: 0x060139C1 RID: 80321 RVA: 0x00500614 File Offset: 0x004FE814
		private void __callDele_EventOnShowPlayerInfo(int arg1, RectTransform arg2)
		{
			Action<int, RectTransform> eventOnShowPlayerInfo = this.EventOnShowPlayerInfo;
			if (eventOnShowPlayerInfo != null)
			{
				eventOnShowPlayerInfo(arg1, arg2);
			}
		}

		// Token: 0x060139C2 RID: 80322 RVA: 0x00500638 File Offset: 0x004FE838
		private void __clearDele_EventOnShowPlayerInfo(int arg1, RectTransform arg2)
		{
			this.EventOnShowPlayerInfo = null;
		}

		// Token: 0x060139C3 RID: 80323 RVA: 0x00500644 File Offset: 0x004FE844
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
					this.m_GetPlayerInfoParentInt32Boolean_hotfix = (luaObj.RawGet("GetPlayerInfoParent") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnApplicationPauseBoolean_hotfix = (luaObj.RawGet("OnApplicationPause") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetTeamRoomSettingTeamRoomSetting_hotfix = (luaObj.RawGet("SetTeamRoomSetting") as LuaFunction);
					this.m_SetTeamRoomPlayersList`1Boolean_hotfix = (luaObj.RawGet("SetTeamRoomPlayers") as LuaFunction);
					this.m_SetBattleNameGameFunctionTypeInt32_hotfix = (luaObj.RawGet("SetBattleName") as LuaFunction);
					this.m_SetPlayerLevelRangeInt32Int32_hotfix = (luaObj.RawGet("SetPlayerLevelRange") as LuaFunction);
					this.m_SetAuthorityTeamRoomAuthority_hotfix = (luaObj.RawGet("SetAuthority") as LuaFunction);
					this.m_SetQuitCountdownTimeSpan_hotfix = (luaObj.RawGet("SetQuitCountdown") as LuaFunction);
					this.m_ShowWaitStartBattleBoolean_hotfix = (luaObj.RawGet("ShowWaitStartBattle") as LuaFunction);
					this.m_ShowChangePlayerPositionTeamRoom_hotfix = (luaObj.RawGet("ShowChangePlayerPosition") as LuaFunction);
					this.m_HideChangePlayerPosition_hotfix = (luaObj.RawGet("HideChangePlayerPosition") as LuaFunction);
					this.m_GetPlayerChangedPositionTeamRoomPlayer_hotfix = (luaObj.RawGet("GetPlayerChangedPosition") as LuaFunction);
					this.m_ShowPlayerChatInt32String_hotfix = (luaObj.RawGet("ShowPlayerChat") as LuaFunction);
					this.m_ShowPlayerBigExpressionInt32Int32_hotfix = (luaObj.RawGet("ShowPlayerBigExpression") as LuaFunction);
					this.m_CreateDraggingPlayerInfoUIControllerTeamRoomPlayerInfoUIController_hotfix = (luaObj.RawGet("CreateDraggingPlayerInfoUIController") as LuaFunction);
					this.m_DestroyDragginPlayerInfoUIController_hotfix = (luaObj.RawGet("DestroyDragginPlayerInfoUIController") as LuaFunction);
					this.m_MoveDraggingPlayerInfoUIControllerVector2_hotfix = (luaObj.RawGet("MoveDraggingPlayerInfoUIController") as LuaFunction);
					this.m_DropDraggingPlayerInfoUIControllerVector3_hotfix = (luaObj.RawGet("DropDraggingPlayerInfoUIController") as LuaFunction);
					this.m_OnLeaveButtonClick_hotfix = (luaObj.RawGet("OnLeaveButtonClick") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnShowChangePlayerPositionButtonClick_hotfix = (luaObj.RawGet("OnShowChangePlayerPositionButtonClick") as LuaFunction);
					this.m_OnChangePlayerPositionCompleteButtonClick_hotfix = (luaObj.RawGet("OnChangePlayerPositionCompleteButtonClick") as LuaFunction);
					this.m_OnChatButtonClick_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnAuthorityDropdownValueChangedInt32_hotfix = (luaObj.RawGet("OnAuthorityDropdownValueChanged") as LuaFunction);
					this.m_OnAuthorityLockButtonClick_hotfix = (luaObj.RawGet("OnAuthorityLockButtonClick") as LuaFunction);
					this.m_TeamRoomPlayerInfoUIController_OnInviteButtonClickTeamRoomPlayerInfoUIController_hotfix = (luaObj.RawGet("TeamRoomPlayerInfoUIController_OnInviteButtonClick") as LuaFunction);
					this.m_TeamRoomPlayerInfoUIController_OnPlayerButtonClickTeamRoomPlayerInfoUIController_hotfix = (luaObj.RawGet("TeamRoomPlayerInfoUIController_OnPlayerButtonClick") as LuaFunction);
					this.m_TeamRoomPlayerInfoUIController_OnBeginDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix = (luaObj.RawGet("TeamRoomPlayerInfoUIController_OnBeginDrag") as LuaFunction);
					this.m_TeamRoomPlayerInfoUIController_OnEndDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix = (luaObj.RawGet("TeamRoomPlayerInfoUIController_OnEndDrag") as LuaFunction);
					this.m_TeamRoomPlayerInfoUIController_OnDragPointerEventData_hotfix = (luaObj.RawGet("TeamRoomPlayerInfoUIController_OnDrag") as LuaFunction);
					this.m_TeamRoomPlayerInfoUIController_OnDropPointerEventData_hotfix = (luaObj.RawGet("TeamRoomPlayerInfoUIController_OnDrop") as LuaFunction);
					this.m_add_EventOnLeaveAction_hotfix = (luaObj.RawGet("add_EventOnLeave") as LuaFunction);
					this.m_remove_EventOnLeaveAction_hotfix = (luaObj.RawGet("remove_EventOnLeave") as LuaFunction);
					this.m_add_EventOnStartAction_hotfix = (luaObj.RawGet("add_EventOnStart") as LuaFunction);
					this.m_remove_EventOnStartAction_hotfix = (luaObj.RawGet("remove_EventOnStart") as LuaFunction);
					this.m_add_EventOnShowChangePlayerPositionAction_hotfix = (luaObj.RawGet("add_EventOnShowChangePlayerPosition") as LuaFunction);
					this.m_remove_EventOnShowChangePlayerPositionAction_hotfix = (luaObj.RawGet("remove_EventOnShowChangePlayerPosition") as LuaFunction);
					this.m_add_EventOnChangePlayerPositionCompleteAction_hotfix = (luaObj.RawGet("add_EventOnChangePlayerPositionComplete") as LuaFunction);
					this.m_remove_EventOnChangePlayerPositionCompleteAction_hotfix = (luaObj.RawGet("remove_EventOnChangePlayerPositionComplete") as LuaFunction);
					this.m_add_EventOnShowChatAction_hotfix = (luaObj.RawGet("add_EventOnShowChat") as LuaFunction);
					this.m_remove_EventOnShowChatAction_hotfix = (luaObj.RawGet("remove_EventOnShowChat") as LuaFunction);
					this.m_add_EventOnChangeAuthorityAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeAuthority") as LuaFunction);
					this.m_remove_EventOnChangeAuthorityAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeAuthority") as LuaFunction);
					this.m_add_EventOnShowInviteAction_hotfix = (luaObj.RawGet("add_EventOnShowInvite") as LuaFunction);
					this.m_remove_EventOnShowInviteAction_hotfix = (luaObj.RawGet("remove_EventOnShowInvite") as LuaFunction);
					this.m_add_EventOnShowPlayerInfoAction`2_hotfix = (luaObj.RawGet("add_EventOnShowPlayerInfo") as LuaFunction);
					this.m_remove_EventOnShowPlayerInfoAction`2_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060139C4 RID: 80324 RVA: 0x00500BF4 File Offset: 0x004FEDF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400ADCF RID: 44495
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400ADD0 RID: 44496
		[AutoBind("./GuildOrTeamState", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildOrTeamUIStateController;

		// Token: 0x0400ADD1 RID: 44497
		[AutoBind("./WaitStartBattle", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitStartBattleGameObject;

		// Token: 0x0400ADD2 RID: 44498
		[AutoBind("./Panel/StartBattleButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400ADD3 RID: 44499
		[AutoBind("./Panel/StartBattleButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_startButtonUIStateController;

		// Token: 0x0400ADD4 RID: 44500
		[AutoBind("./Panel/TeamLeaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_leaveButton;

		// Token: 0x0400ADD5 RID: 44501
		[AutoBind("./Panel/EditTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_showChangePlayerPositionButton;

		// Token: 0x0400ADD6 RID: 44502
		[AutoBind("./Panel/ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x0400ADD7 RID: 44503
		[AutoBind("./Panel/Texts/TargetText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_gameFunctionTypeNameText;

		// Token: 0x0400ADD8 RID: 44504
		[AutoBind("./Panel/Texts/TargetFloorText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_locationNameText;

		// Token: 0x0400ADD9 RID: 44505
		[AutoBind("./Panel/Texts/LVText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x0400ADDA RID: 44506
		[AutoBind("./Panel/Texts/CountDownText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_quitCountdownText;

		// Token: 0x0400ADDB RID: 44507
		[AutoBind("./Panel/Texts/ConsumeNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400ADDC RID: 44508
		[AutoBind("./Panel/Texts/GuildLvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildMassiveCombatNameText;

		// Token: 0x0400ADDD RID: 44509
		[AutoBind("./Panel/AuthorityDropdown", AutoBindAttribute.InitState.NotInit, false)]
		private Dropdown m_authorityDropdown;

		// Token: 0x0400ADDE RID: 44510
		[AutoBind("./Panel/AuthorityDropdown/LockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_authorityLockButton;

		// Token: 0x0400ADDF RID: 44511
		[AutoBind("./Panel/PlayerInfo0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerInfo0GameObject;

		// Token: 0x0400ADE0 RID: 44512
		[AutoBind("./Panel/PlayerInfo1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerInfo1GameObject;

		// Token: 0x0400ADE1 RID: 44513
		[AutoBind("./Panel/PlayerInfo2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerInfo2GameObject;

		// Token: 0x0400ADE2 RID: 44514
		[AutoBind("./Panel/EditTeamPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changePlayerPositionPanelGameObject;

		// Token: 0x0400ADE3 RID: 44515
		[AutoBind("./Panel/EditTeamPanel/CompleteButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changePlayerPositionCompleteButton;

		// Token: 0x0400ADE4 RID: 44516
		[AutoBind("./Panel/EditTeamPanel/PlayerInfo0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changePlayerPositionInfo0GameObject;

		// Token: 0x0400ADE5 RID: 44517
		[AutoBind("./Panel/EditTeamPanel/PlayerInfo1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changePlayerPositionInfo1GameObject;

		// Token: 0x0400ADE6 RID: 44518
		[AutoBind("./Panel/EditTeamPanel/PlayerInfo2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changePlayerPositionInfo2GameObject;

		// Token: 0x0400ADE7 RID: 44519
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400ADE8 RID: 44520
		[AutoBind("./Prefabs/PlayerInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerInfoPrefab;

		// Token: 0x0400ADE9 RID: 44521
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.NotInit, false)]
		private SmallExpressionParseDesc m_expressionParseDesc;

		// Token: 0x0400ADEA RID: 44522
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_expressionResContainer;

		// Token: 0x0400ADEB RID: 44523
		private TeamRoomPlayerInfoUIController[] m_playerInfoUIControllers = new TeamRoomPlayerInfoUIController[3];

		// Token: 0x0400ADEC RID: 44524
		private TeamRoomPlayerInfoUIController[] m_editPlayerInfoUIControllers = new TeamRoomPlayerInfoUIController[3];

		// Token: 0x0400ADED RID: 44525
		private TeamRoomPlayerInfoUIController m_draggingPlayerInfoUIController;

		// Token: 0x0400ADEE RID: 44526
		private bool m_isIgnoreToggleEvent;

		// Token: 0x0400ADEF RID: 44527
		private Camera m_camera;

		// Token: 0x0400ADF0 RID: 44528
		[DoNotToLua]
		private TeamRoomInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400ADF1 RID: 44529
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400ADF2 RID: 44530
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400ADF3 RID: 44531
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400ADF4 RID: 44532
		private LuaFunction m_GetPlayerInfoParentInt32Boolean_hotfix;

		// Token: 0x0400ADF5 RID: 44533
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x0400ADF6 RID: 44534
		private LuaFunction m_OnApplicationPauseBoolean_hotfix;

		// Token: 0x0400ADF7 RID: 44535
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400ADF8 RID: 44536
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x0400ADF9 RID: 44537
		private LuaFunction m_SetTeamRoomSettingTeamRoomSetting_hotfix;

		// Token: 0x0400ADFA RID: 44538
		private LuaFunction m_SetTeamRoomPlayersList;

		// Token: 0x0400ADFB RID: 44539
		private LuaFunction m_SetBattleNameGameFunctionTypeInt32_hotfix;

		// Token: 0x0400ADFC RID: 44540
		private LuaFunction m_SetPlayerLevelRangeInt32Int32_hotfix;

		// Token: 0x0400ADFD RID: 44541
		private LuaFunction m_SetAuthorityTeamRoomAuthority_hotfix;

		// Token: 0x0400ADFE RID: 44542
		private LuaFunction m_SetQuitCountdownTimeSpan_hotfix;

		// Token: 0x0400ADFF RID: 44543
		private LuaFunction m_ShowWaitStartBattleBoolean_hotfix;

		// Token: 0x0400AE00 RID: 44544
		private LuaFunction m_ShowChangePlayerPositionTeamRoom_hotfix;

		// Token: 0x0400AE01 RID: 44545
		private LuaFunction m_HideChangePlayerPosition_hotfix;

		// Token: 0x0400AE02 RID: 44546
		private LuaFunction m_GetPlayerChangedPositionTeamRoomPlayer_hotfix;

		// Token: 0x0400AE03 RID: 44547
		private LuaFunction m_ShowPlayerChatInt32String_hotfix;

		// Token: 0x0400AE04 RID: 44548
		private LuaFunction m_ShowPlayerBigExpressionInt32Int32_hotfix;

		// Token: 0x0400AE05 RID: 44549
		private LuaFunction m_CreateDraggingPlayerInfoUIControllerTeamRoomPlayerInfoUIController_hotfix;

		// Token: 0x0400AE06 RID: 44550
		private LuaFunction m_DestroyDragginPlayerInfoUIController_hotfix;

		// Token: 0x0400AE07 RID: 44551
		private LuaFunction m_MoveDraggingPlayerInfoUIControllerVector2_hotfix;

		// Token: 0x0400AE08 RID: 44552
		private LuaFunction m_DropDraggingPlayerInfoUIControllerVector3_hotfix;

		// Token: 0x0400AE09 RID: 44553
		private LuaFunction m_OnLeaveButtonClick_hotfix;

		// Token: 0x0400AE0A RID: 44554
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400AE0B RID: 44555
		private LuaFunction m_OnShowChangePlayerPositionButtonClick_hotfix;

		// Token: 0x0400AE0C RID: 44556
		private LuaFunction m_OnChangePlayerPositionCompleteButtonClick_hotfix;

		// Token: 0x0400AE0D RID: 44557
		private LuaFunction m_OnChatButtonClick_hotfix;

		// Token: 0x0400AE0E RID: 44558
		private LuaFunction m_OnAuthorityDropdownValueChangedInt32_hotfix;

		// Token: 0x0400AE0F RID: 44559
		private LuaFunction m_OnAuthorityLockButtonClick_hotfix;

		// Token: 0x0400AE10 RID: 44560
		private LuaFunction m_TeamRoomPlayerInfoUIController_OnInviteButtonClickTeamRoomPlayerInfoUIController_hotfix;

		// Token: 0x0400AE11 RID: 44561
		private LuaFunction m_TeamRoomPlayerInfoUIController_OnPlayerButtonClickTeamRoomPlayerInfoUIController_hotfix;

		// Token: 0x0400AE12 RID: 44562
		private LuaFunction m_TeamRoomPlayerInfoUIController_OnBeginDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix;

		// Token: 0x0400AE13 RID: 44563
		private LuaFunction m_TeamRoomPlayerInfoUIController_OnEndDragTeamRoomPlayerInfoUIControllerPointerEventData_hotfix;

		// Token: 0x0400AE14 RID: 44564
		private LuaFunction m_TeamRoomPlayerInfoUIController_OnDragPointerEventData_hotfix;

		// Token: 0x0400AE15 RID: 44565
		private LuaFunction m_TeamRoomPlayerInfoUIController_OnDropPointerEventData_hotfix;

		// Token: 0x0400AE16 RID: 44566
		private LuaFunction m_add_EventOnLeaveAction_hotfix;

		// Token: 0x0400AE17 RID: 44567
		private LuaFunction m_remove_EventOnLeaveAction_hotfix;

		// Token: 0x0400AE18 RID: 44568
		private LuaFunction m_add_EventOnStartAction_hotfix;

		// Token: 0x0400AE19 RID: 44569
		private LuaFunction m_remove_EventOnStartAction_hotfix;

		// Token: 0x0400AE1A RID: 44570
		private LuaFunction m_add_EventOnShowChangePlayerPositionAction_hotfix;

		// Token: 0x0400AE1B RID: 44571
		private LuaFunction m_remove_EventOnShowChangePlayerPositionAction_hotfix;

		// Token: 0x0400AE1C RID: 44572
		private LuaFunction m_add_EventOnChangePlayerPositionCompleteAction_hotfix;

		// Token: 0x0400AE1D RID: 44573
		private LuaFunction m_remove_EventOnChangePlayerPositionCompleteAction_hotfix;

		// Token: 0x0400AE1E RID: 44574
		private LuaFunction m_add_EventOnShowChatAction_hotfix;

		// Token: 0x0400AE1F RID: 44575
		private LuaFunction m_remove_EventOnShowChatAction_hotfix;

		// Token: 0x0400AE20 RID: 44576
		private LuaFunction m_add_EventOnChangeAuthorityAction;

		// Token: 0x0400AE21 RID: 44577
		private LuaFunction m_remove_EventOnChangeAuthorityAction;

		// Token: 0x0400AE22 RID: 44578
		private LuaFunction m_add_EventOnShowInviteAction_hotfix;

		// Token: 0x0400AE23 RID: 44579
		private LuaFunction m_remove_EventOnShowInviteAction_hotfix;

		// Token: 0x0400AE24 RID: 44580
		private LuaFunction m_add_EventOnShowPlayerInfoAction;

		// Token: 0x0400AE25 RID: 44581
		private LuaFunction m_remove_EventOnShowPlayerInfoAction;

		// Token: 0x02000F69 RID: 3945
		public new class LuaExportHelper
		{
			// Token: 0x060139C5 RID: 80325 RVA: 0x00500C5C File Offset: 0x004FEE5C
			public LuaExportHelper(TeamRoomInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060139C6 RID: 80326 RVA: 0x00500C6C File Offset: 0x004FEE6C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060139C7 RID: 80327 RVA: 0x00500C7C File Offset: 0x004FEE7C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060139C8 RID: 80328 RVA: 0x00500C8C File Offset: 0x004FEE8C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060139C9 RID: 80329 RVA: 0x00500C9C File Offset: 0x004FEE9C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060139CA RID: 80330 RVA: 0x00500CB4 File Offset: 0x004FEEB4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060139CB RID: 80331 RVA: 0x00500CC4 File Offset: 0x004FEEC4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060139CC RID: 80332 RVA: 0x00500CD4 File Offset: 0x004FEED4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060139CD RID: 80333 RVA: 0x00500CE4 File Offset: 0x004FEEE4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060139CE RID: 80334 RVA: 0x00500CF4 File Offset: 0x004FEEF4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060139CF RID: 80335 RVA: 0x00500D04 File Offset: 0x004FEF04
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060139D0 RID: 80336 RVA: 0x00500D14 File Offset: 0x004FEF14
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060139D1 RID: 80337 RVA: 0x00500D24 File Offset: 0x004FEF24
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060139D2 RID: 80338 RVA: 0x00500D34 File Offset: 0x004FEF34
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060139D3 RID: 80339 RVA: 0x00500D44 File Offset: 0x004FEF44
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060139D4 RID: 80340 RVA: 0x00500D54 File Offset: 0x004FEF54
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060139D5 RID: 80341 RVA: 0x00500D64 File Offset: 0x004FEF64
			public void __callDele_EventOnLeave()
			{
				this.m_owner.__callDele_EventOnLeave();
			}

			// Token: 0x060139D6 RID: 80342 RVA: 0x00500D74 File Offset: 0x004FEF74
			public void __clearDele_EventOnLeave()
			{
				this.m_owner.__clearDele_EventOnLeave();
			}

			// Token: 0x060139D7 RID: 80343 RVA: 0x00500D84 File Offset: 0x004FEF84
			public void __callDele_EventOnStart()
			{
				this.m_owner.__callDele_EventOnStart();
			}

			// Token: 0x060139D8 RID: 80344 RVA: 0x00500D94 File Offset: 0x004FEF94
			public void __clearDele_EventOnStart()
			{
				this.m_owner.__clearDele_EventOnStart();
			}

			// Token: 0x060139D9 RID: 80345 RVA: 0x00500DA4 File Offset: 0x004FEFA4
			public void __callDele_EventOnShowChangePlayerPosition()
			{
				this.m_owner.__callDele_EventOnShowChangePlayerPosition();
			}

			// Token: 0x060139DA RID: 80346 RVA: 0x00500DB4 File Offset: 0x004FEFB4
			public void __clearDele_EventOnShowChangePlayerPosition()
			{
				this.m_owner.__clearDele_EventOnShowChangePlayerPosition();
			}

			// Token: 0x060139DB RID: 80347 RVA: 0x00500DC4 File Offset: 0x004FEFC4
			public void __callDele_EventOnChangePlayerPositionComplete()
			{
				this.m_owner.__callDele_EventOnChangePlayerPositionComplete();
			}

			// Token: 0x060139DC RID: 80348 RVA: 0x00500DD4 File Offset: 0x004FEFD4
			public void __clearDele_EventOnChangePlayerPositionComplete()
			{
				this.m_owner.__clearDele_EventOnChangePlayerPositionComplete();
			}

			// Token: 0x060139DD RID: 80349 RVA: 0x00500DE4 File Offset: 0x004FEFE4
			public void __callDele_EventOnShowChat()
			{
				this.m_owner.__callDele_EventOnShowChat();
			}

			// Token: 0x060139DE RID: 80350 RVA: 0x00500DF4 File Offset: 0x004FEFF4
			public void __clearDele_EventOnShowChat()
			{
				this.m_owner.__clearDele_EventOnShowChat();
			}

			// Token: 0x060139DF RID: 80351 RVA: 0x00500E04 File Offset: 0x004FF004
			public void __callDele_EventOnChangeAuthority(TeamRoomAuthority obj)
			{
				this.m_owner.__callDele_EventOnChangeAuthority(obj);
			}

			// Token: 0x060139E0 RID: 80352 RVA: 0x00500E14 File Offset: 0x004FF014
			public void __clearDele_EventOnChangeAuthority(TeamRoomAuthority obj)
			{
				this.m_owner.__clearDele_EventOnChangeAuthority(obj);
			}

			// Token: 0x060139E1 RID: 80353 RVA: 0x00500E24 File Offset: 0x004FF024
			public void __callDele_EventOnShowInvite()
			{
				this.m_owner.__callDele_EventOnShowInvite();
			}

			// Token: 0x060139E2 RID: 80354 RVA: 0x00500E34 File Offset: 0x004FF034
			public void __clearDele_EventOnShowInvite()
			{
				this.m_owner.__clearDele_EventOnShowInvite();
			}

			// Token: 0x060139E3 RID: 80355 RVA: 0x00500E44 File Offset: 0x004FF044
			public void __callDele_EventOnShowPlayerInfo(int arg1, RectTransform arg2)
			{
				this.m_owner.__callDele_EventOnShowPlayerInfo(arg1, arg2);
			}

			// Token: 0x060139E4 RID: 80356 RVA: 0x00500E54 File Offset: 0x004FF054
			public void __clearDele_EventOnShowPlayerInfo(int arg1, RectTransform arg2)
			{
				this.m_owner.__clearDele_EventOnShowPlayerInfo(arg1, arg2);
			}

			// Token: 0x17003ACB RID: 15051
			// (get) Token: 0x060139E5 RID: 80357 RVA: 0x00500E64 File Offset: 0x004FF064
			// (set) Token: 0x060139E6 RID: 80358 RVA: 0x00500E74 File Offset: 0x004FF074
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

			// Token: 0x17003ACC RID: 15052
			// (get) Token: 0x060139E7 RID: 80359 RVA: 0x00500E84 File Offset: 0x004FF084
			// (set) Token: 0x060139E8 RID: 80360 RVA: 0x00500E94 File Offset: 0x004FF094
			public CommonUIStateController m_guildOrTeamUIStateController
			{
				get
				{
					return this.m_owner.m_guildOrTeamUIStateController;
				}
				set
				{
					this.m_owner.m_guildOrTeamUIStateController = value;
				}
			}

			// Token: 0x17003ACD RID: 15053
			// (get) Token: 0x060139E9 RID: 80361 RVA: 0x00500EA4 File Offset: 0x004FF0A4
			// (set) Token: 0x060139EA RID: 80362 RVA: 0x00500EB4 File Offset: 0x004FF0B4
			public GameObject m_waitStartBattleGameObject
			{
				get
				{
					return this.m_owner.m_waitStartBattleGameObject;
				}
				set
				{
					this.m_owner.m_waitStartBattleGameObject = value;
				}
			}

			// Token: 0x17003ACE RID: 15054
			// (get) Token: 0x060139EB RID: 80363 RVA: 0x00500EC4 File Offset: 0x004FF0C4
			// (set) Token: 0x060139EC RID: 80364 RVA: 0x00500ED4 File Offset: 0x004FF0D4
			public Button m_startButton
			{
				get
				{
					return this.m_owner.m_startButton;
				}
				set
				{
					this.m_owner.m_startButton = value;
				}
			}

			// Token: 0x17003ACF RID: 15055
			// (get) Token: 0x060139ED RID: 80365 RVA: 0x00500EE4 File Offset: 0x004FF0E4
			// (set) Token: 0x060139EE RID: 80366 RVA: 0x00500EF4 File Offset: 0x004FF0F4
			public CommonUIStateController m_startButtonUIStateController
			{
				get
				{
					return this.m_owner.m_startButtonUIStateController;
				}
				set
				{
					this.m_owner.m_startButtonUIStateController = value;
				}
			}

			// Token: 0x17003AD0 RID: 15056
			// (get) Token: 0x060139EF RID: 80367 RVA: 0x00500F04 File Offset: 0x004FF104
			// (set) Token: 0x060139F0 RID: 80368 RVA: 0x00500F14 File Offset: 0x004FF114
			public Button m_leaveButton
			{
				get
				{
					return this.m_owner.m_leaveButton;
				}
				set
				{
					this.m_owner.m_leaveButton = value;
				}
			}

			// Token: 0x17003AD1 RID: 15057
			// (get) Token: 0x060139F1 RID: 80369 RVA: 0x00500F24 File Offset: 0x004FF124
			// (set) Token: 0x060139F2 RID: 80370 RVA: 0x00500F34 File Offset: 0x004FF134
			public Button m_showChangePlayerPositionButton
			{
				get
				{
					return this.m_owner.m_showChangePlayerPositionButton;
				}
				set
				{
					this.m_owner.m_showChangePlayerPositionButton = value;
				}
			}

			// Token: 0x17003AD2 RID: 15058
			// (get) Token: 0x060139F3 RID: 80371 RVA: 0x00500F44 File Offset: 0x004FF144
			// (set) Token: 0x060139F4 RID: 80372 RVA: 0x00500F54 File Offset: 0x004FF154
			public Button m_chatButton
			{
				get
				{
					return this.m_owner.m_chatButton;
				}
				set
				{
					this.m_owner.m_chatButton = value;
				}
			}

			// Token: 0x17003AD3 RID: 15059
			// (get) Token: 0x060139F5 RID: 80373 RVA: 0x00500F64 File Offset: 0x004FF164
			// (set) Token: 0x060139F6 RID: 80374 RVA: 0x00500F74 File Offset: 0x004FF174
			public Text m_gameFunctionTypeNameText
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeNameText;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeNameText = value;
				}
			}

			// Token: 0x17003AD4 RID: 15060
			// (get) Token: 0x060139F7 RID: 80375 RVA: 0x00500F84 File Offset: 0x004FF184
			// (set) Token: 0x060139F8 RID: 80376 RVA: 0x00500F94 File Offset: 0x004FF194
			public Text m_locationNameText
			{
				get
				{
					return this.m_owner.m_locationNameText;
				}
				set
				{
					this.m_owner.m_locationNameText = value;
				}
			}

			// Token: 0x17003AD5 RID: 15061
			// (get) Token: 0x060139F9 RID: 80377 RVA: 0x00500FA4 File Offset: 0x004FF1A4
			// (set) Token: 0x060139FA RID: 80378 RVA: 0x00500FB4 File Offset: 0x004FF1B4
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17003AD6 RID: 15062
			// (get) Token: 0x060139FB RID: 80379 RVA: 0x00500FC4 File Offset: 0x004FF1C4
			// (set) Token: 0x060139FC RID: 80380 RVA: 0x00500FD4 File Offset: 0x004FF1D4
			public Text m_quitCountdownText
			{
				get
				{
					return this.m_owner.m_quitCountdownText;
				}
				set
				{
					this.m_owner.m_quitCountdownText = value;
				}
			}

			// Token: 0x17003AD7 RID: 15063
			// (get) Token: 0x060139FD RID: 80381 RVA: 0x00500FE4 File Offset: 0x004FF1E4
			// (set) Token: 0x060139FE RID: 80382 RVA: 0x00500FF4 File Offset: 0x004FF1F4
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x17003AD8 RID: 15064
			// (get) Token: 0x060139FF RID: 80383 RVA: 0x00501004 File Offset: 0x004FF204
			// (set) Token: 0x06013A00 RID: 80384 RVA: 0x00501014 File Offset: 0x004FF214
			public Text m_guildMassiveCombatNameText
			{
				get
				{
					return this.m_owner.m_guildMassiveCombatNameText;
				}
				set
				{
					this.m_owner.m_guildMassiveCombatNameText = value;
				}
			}

			// Token: 0x17003AD9 RID: 15065
			// (get) Token: 0x06013A01 RID: 80385 RVA: 0x00501024 File Offset: 0x004FF224
			// (set) Token: 0x06013A02 RID: 80386 RVA: 0x00501034 File Offset: 0x004FF234
			public Dropdown m_authorityDropdown
			{
				get
				{
					return this.m_owner.m_authorityDropdown;
				}
				set
				{
					this.m_owner.m_authorityDropdown = value;
				}
			}

			// Token: 0x17003ADA RID: 15066
			// (get) Token: 0x06013A03 RID: 80387 RVA: 0x00501044 File Offset: 0x004FF244
			// (set) Token: 0x06013A04 RID: 80388 RVA: 0x00501054 File Offset: 0x004FF254
			public Button m_authorityLockButton
			{
				get
				{
					return this.m_owner.m_authorityLockButton;
				}
				set
				{
					this.m_owner.m_authorityLockButton = value;
				}
			}

			// Token: 0x17003ADB RID: 15067
			// (get) Token: 0x06013A05 RID: 80389 RVA: 0x00501064 File Offset: 0x004FF264
			// (set) Token: 0x06013A06 RID: 80390 RVA: 0x00501074 File Offset: 0x004FF274
			public GameObject m_playerInfo0GameObject
			{
				get
				{
					return this.m_owner.m_playerInfo0GameObject;
				}
				set
				{
					this.m_owner.m_playerInfo0GameObject = value;
				}
			}

			// Token: 0x17003ADC RID: 15068
			// (get) Token: 0x06013A07 RID: 80391 RVA: 0x00501084 File Offset: 0x004FF284
			// (set) Token: 0x06013A08 RID: 80392 RVA: 0x00501094 File Offset: 0x004FF294
			public GameObject m_playerInfo1GameObject
			{
				get
				{
					return this.m_owner.m_playerInfo1GameObject;
				}
				set
				{
					this.m_owner.m_playerInfo1GameObject = value;
				}
			}

			// Token: 0x17003ADD RID: 15069
			// (get) Token: 0x06013A09 RID: 80393 RVA: 0x005010A4 File Offset: 0x004FF2A4
			// (set) Token: 0x06013A0A RID: 80394 RVA: 0x005010B4 File Offset: 0x004FF2B4
			public GameObject m_playerInfo2GameObject
			{
				get
				{
					return this.m_owner.m_playerInfo2GameObject;
				}
				set
				{
					this.m_owner.m_playerInfo2GameObject = value;
				}
			}

			// Token: 0x17003ADE RID: 15070
			// (get) Token: 0x06013A0B RID: 80395 RVA: 0x005010C4 File Offset: 0x004FF2C4
			// (set) Token: 0x06013A0C RID: 80396 RVA: 0x005010D4 File Offset: 0x004FF2D4
			public GameObject m_changePlayerPositionPanelGameObject
			{
				get
				{
					return this.m_owner.m_changePlayerPositionPanelGameObject;
				}
				set
				{
					this.m_owner.m_changePlayerPositionPanelGameObject = value;
				}
			}

			// Token: 0x17003ADF RID: 15071
			// (get) Token: 0x06013A0D RID: 80397 RVA: 0x005010E4 File Offset: 0x004FF2E4
			// (set) Token: 0x06013A0E RID: 80398 RVA: 0x005010F4 File Offset: 0x004FF2F4
			public Button m_changePlayerPositionCompleteButton
			{
				get
				{
					return this.m_owner.m_changePlayerPositionCompleteButton;
				}
				set
				{
					this.m_owner.m_changePlayerPositionCompleteButton = value;
				}
			}

			// Token: 0x17003AE0 RID: 15072
			// (get) Token: 0x06013A0F RID: 80399 RVA: 0x00501104 File Offset: 0x004FF304
			// (set) Token: 0x06013A10 RID: 80400 RVA: 0x00501114 File Offset: 0x004FF314
			public GameObject m_changePlayerPositionInfo0GameObject
			{
				get
				{
					return this.m_owner.m_changePlayerPositionInfo0GameObject;
				}
				set
				{
					this.m_owner.m_changePlayerPositionInfo0GameObject = value;
				}
			}

			// Token: 0x17003AE1 RID: 15073
			// (get) Token: 0x06013A11 RID: 80401 RVA: 0x00501124 File Offset: 0x004FF324
			// (set) Token: 0x06013A12 RID: 80402 RVA: 0x00501134 File Offset: 0x004FF334
			public GameObject m_changePlayerPositionInfo1GameObject
			{
				get
				{
					return this.m_owner.m_changePlayerPositionInfo1GameObject;
				}
				set
				{
					this.m_owner.m_changePlayerPositionInfo1GameObject = value;
				}
			}

			// Token: 0x17003AE2 RID: 15074
			// (get) Token: 0x06013A13 RID: 80403 RVA: 0x00501144 File Offset: 0x004FF344
			// (set) Token: 0x06013A14 RID: 80404 RVA: 0x00501154 File Offset: 0x004FF354
			public GameObject m_changePlayerPositionInfo2GameObject
			{
				get
				{
					return this.m_owner.m_changePlayerPositionInfo2GameObject;
				}
				set
				{
					this.m_owner.m_changePlayerPositionInfo2GameObject = value;
				}
			}

			// Token: 0x17003AE3 RID: 15075
			// (get) Token: 0x06013A15 RID: 80405 RVA: 0x00501164 File Offset: 0x004FF364
			// (set) Token: 0x06013A16 RID: 80406 RVA: 0x00501174 File Offset: 0x004FF374
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

			// Token: 0x17003AE4 RID: 15076
			// (get) Token: 0x06013A17 RID: 80407 RVA: 0x00501184 File Offset: 0x004FF384
			// (set) Token: 0x06013A18 RID: 80408 RVA: 0x00501194 File Offset: 0x004FF394
			public GameObject m_playerInfoPrefab
			{
				get
				{
					return this.m_owner.m_playerInfoPrefab;
				}
				set
				{
					this.m_owner.m_playerInfoPrefab = value;
				}
			}

			// Token: 0x17003AE5 RID: 15077
			// (get) Token: 0x06013A19 RID: 80409 RVA: 0x005011A4 File Offset: 0x004FF3A4
			// (set) Token: 0x06013A1A RID: 80410 RVA: 0x005011B4 File Offset: 0x004FF3B4
			public SmallExpressionParseDesc m_expressionParseDesc
			{
				get
				{
					return this.m_owner.m_expressionParseDesc;
				}
				set
				{
					this.m_owner.m_expressionParseDesc = value;
				}
			}

			// Token: 0x17003AE6 RID: 15078
			// (get) Token: 0x06013A1B RID: 80411 RVA: 0x005011C4 File Offset: 0x004FF3C4
			// (set) Token: 0x06013A1C RID: 80412 RVA: 0x005011D4 File Offset: 0x004FF3D4
			public PrefabResourceContainer m_expressionResContainer
			{
				get
				{
					return this.m_owner.m_expressionResContainer;
				}
				set
				{
					this.m_owner.m_expressionResContainer = value;
				}
			}

			// Token: 0x17003AE7 RID: 15079
			// (get) Token: 0x06013A1D RID: 80413 RVA: 0x005011E4 File Offset: 0x004FF3E4
			// (set) Token: 0x06013A1E RID: 80414 RVA: 0x005011F4 File Offset: 0x004FF3F4
			public TeamRoomPlayerInfoUIController[] m_playerInfoUIControllers
			{
				get
				{
					return this.m_owner.m_playerInfoUIControllers;
				}
				set
				{
					this.m_owner.m_playerInfoUIControllers = value;
				}
			}

			// Token: 0x17003AE8 RID: 15080
			// (get) Token: 0x06013A1F RID: 80415 RVA: 0x00501204 File Offset: 0x004FF404
			// (set) Token: 0x06013A20 RID: 80416 RVA: 0x00501214 File Offset: 0x004FF414
			public TeamRoomPlayerInfoUIController[] m_editPlayerInfoUIControllers
			{
				get
				{
					return this.m_owner.m_editPlayerInfoUIControllers;
				}
				set
				{
					this.m_owner.m_editPlayerInfoUIControllers = value;
				}
			}

			// Token: 0x17003AE9 RID: 15081
			// (get) Token: 0x06013A21 RID: 80417 RVA: 0x00501224 File Offset: 0x004FF424
			// (set) Token: 0x06013A22 RID: 80418 RVA: 0x00501234 File Offset: 0x004FF434
			public TeamRoomPlayerInfoUIController m_draggingPlayerInfoUIController
			{
				get
				{
					return this.m_owner.m_draggingPlayerInfoUIController;
				}
				set
				{
					this.m_owner.m_draggingPlayerInfoUIController = value;
				}
			}

			// Token: 0x17003AEA RID: 15082
			// (get) Token: 0x06013A23 RID: 80419 RVA: 0x00501244 File Offset: 0x004FF444
			// (set) Token: 0x06013A24 RID: 80420 RVA: 0x00501254 File Offset: 0x004FF454
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x17003AEB RID: 15083
			// (get) Token: 0x06013A25 RID: 80421 RVA: 0x00501264 File Offset: 0x004FF464
			// (set) Token: 0x06013A26 RID: 80422 RVA: 0x00501274 File Offset: 0x004FF474
			public Camera m_camera
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

			// Token: 0x06013A27 RID: 80423 RVA: 0x00501284 File Offset: 0x004FF484
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013A28 RID: 80424 RVA: 0x00501294 File Offset: 0x004FF494
			public Transform GetPlayerInfoParent(int idx, bool isEdit)
			{
				return this.m_owner.GetPlayerInfoParent(idx, isEdit);
			}

			// Token: 0x06013A29 RID: 80425 RVA: 0x005012A4 File Offset: 0x004FF4A4
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x06013A2A RID: 80426 RVA: 0x005012B4 File Offset: 0x004FF4B4
			public void OnApplicationPause(bool isPause)
			{
				this.m_owner.OnApplicationPause(isPause);
			}

			// Token: 0x06013A2B RID: 80427 RVA: 0x005012C4 File Offset: 0x004FF4C4
			public void SetBattleName(GameFunctionType gameFunctionType, int locationId)
			{
				this.m_owner.SetBattleName(gameFunctionType, locationId);
			}

			// Token: 0x06013A2C RID: 80428 RVA: 0x005012D4 File Offset: 0x004FF4D4
			public void SetPlayerLevelRange(int levelMin, int levelMax)
			{
				this.m_owner.SetPlayerLevelRange(levelMin, levelMax);
			}

			// Token: 0x06013A2D RID: 80429 RVA: 0x005012E4 File Offset: 0x004FF4E4
			public void CreateDraggingPlayerInfoUIController(TeamRoomPlayerInfoUIController ctrl)
			{
				this.m_owner.CreateDraggingPlayerInfoUIController(ctrl);
			}

			// Token: 0x06013A2E RID: 80430 RVA: 0x005012F4 File Offset: 0x004FF4F4
			public void DestroyDragginPlayerInfoUIController()
			{
				this.m_owner.DestroyDragginPlayerInfoUIController();
			}

			// Token: 0x06013A2F RID: 80431 RVA: 0x00501304 File Offset: 0x004FF504
			public void MoveDraggingPlayerInfoUIController(Vector2 pos)
			{
				this.m_owner.MoveDraggingPlayerInfoUIController(pos);
			}

			// Token: 0x06013A30 RID: 80432 RVA: 0x00501314 File Offset: 0x004FF514
			public void DropDraggingPlayerInfoUIController(Vector3 pos)
			{
				this.m_owner.DropDraggingPlayerInfoUIController(pos);
			}

			// Token: 0x06013A31 RID: 80433 RVA: 0x00501324 File Offset: 0x004FF524
			public void OnLeaveButtonClick()
			{
				this.m_owner.OnLeaveButtonClick();
			}

			// Token: 0x06013A32 RID: 80434 RVA: 0x00501334 File Offset: 0x004FF534
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x06013A33 RID: 80435 RVA: 0x00501344 File Offset: 0x004FF544
			public void OnShowChangePlayerPositionButtonClick()
			{
				this.m_owner.OnShowChangePlayerPositionButtonClick();
			}

			// Token: 0x06013A34 RID: 80436 RVA: 0x00501354 File Offset: 0x004FF554
			public void OnChangePlayerPositionCompleteButtonClick()
			{
				this.m_owner.OnChangePlayerPositionCompleteButtonClick();
			}

			// Token: 0x06013A35 RID: 80437 RVA: 0x00501364 File Offset: 0x004FF564
			public void OnChatButtonClick()
			{
				this.m_owner.OnChatButtonClick();
			}

			// Token: 0x06013A36 RID: 80438 RVA: 0x00501374 File Offset: 0x004FF574
			public void OnAuthorityDropdownValueChanged(int value)
			{
				this.m_owner.OnAuthorityDropdownValueChanged(value);
			}

			// Token: 0x06013A37 RID: 80439 RVA: 0x00501384 File Offset: 0x004FF584
			public void OnAuthorityLockButtonClick()
			{
				this.m_owner.OnAuthorityLockButtonClick();
			}

			// Token: 0x06013A38 RID: 80440 RVA: 0x00501394 File Offset: 0x004FF594
			public void TeamRoomPlayerInfoUIController_OnInviteButtonClick(TeamRoomPlayerInfoUIController ctrl)
			{
				this.m_owner.TeamRoomPlayerInfoUIController_OnInviteButtonClick(ctrl);
			}

			// Token: 0x06013A39 RID: 80441 RVA: 0x005013A4 File Offset: 0x004FF5A4
			public void TeamRoomPlayerInfoUIController_OnPlayerButtonClick(TeamRoomPlayerInfoUIController ctrl)
			{
				this.m_owner.TeamRoomPlayerInfoUIController_OnPlayerButtonClick(ctrl);
			}

			// Token: 0x06013A3A RID: 80442 RVA: 0x005013B4 File Offset: 0x004FF5B4
			public void TeamRoomPlayerInfoUIController_OnBeginDrag(TeamRoomPlayerInfoUIController ctrl, PointerEventData eventData)
			{
				this.m_owner.TeamRoomPlayerInfoUIController_OnBeginDrag(ctrl, eventData);
			}

			// Token: 0x06013A3B RID: 80443 RVA: 0x005013C4 File Offset: 0x004FF5C4
			public void TeamRoomPlayerInfoUIController_OnEndDrag(TeamRoomPlayerInfoUIController ctrl, PointerEventData eventData)
			{
				this.m_owner.TeamRoomPlayerInfoUIController_OnEndDrag(ctrl, eventData);
			}

			// Token: 0x06013A3C RID: 80444 RVA: 0x005013D4 File Offset: 0x004FF5D4
			public void TeamRoomPlayerInfoUIController_OnDrag(PointerEventData eventData)
			{
				this.m_owner.TeamRoomPlayerInfoUIController_OnDrag(eventData);
			}

			// Token: 0x0400AE26 RID: 44582
			private TeamRoomInfoUIController m_owner;
		}
	}
}
