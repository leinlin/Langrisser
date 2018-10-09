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
	// Token: 0x02000F72 RID: 3954
	[HotFix]
	public class TeamRoomInviteUIController : UIControllerBase
	{
		// Token: 0x06013B64 RID: 80740 RVA: 0x00505EE8 File Offset: 0x005040E8
		private TeamRoomInviteUIController()
		{
		}

		// Token: 0x06013B65 RID: 80741 RVA: 0x00505EFC File Offset: 0x005040FC
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
			this.m_friendToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnFriendToggleValueChanged));
			this.m_recentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRecentToggleValueChanged));
			this.m_guildToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnGuildToggleValueChanged));
			this.m_guildToggleUnopenMask.onClick.AddListener(new UnityAction(this.OnGuildUnopenMaskClick));
			this.m_confirmButton.onClick.AddListener(new UnityAction(this.OnConfirmButtonClick));
			this.m_cancelButton.onClick.AddListener(new UnityAction(this.OnCancelButtonClick));
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x06013B66 RID: 80742 RVA: 0x00506018 File Offset: 0x00504218
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
		}

		// Token: 0x06013B67 RID: 80743 RVA: 0x0050608C File Offset: 0x0050428C
		public void SetPlayerType(TeamRoomInvitePlayerType playerType, bool canChangePlayerType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerTypeTeamRoomInvitePlayerTypeBoolean_hotfix != null)
			{
				this.m_SetPlayerTypeTeamRoomInvitePlayerTypeBoolean_hotfix.call(new object[]
				{
					this,
					playerType,
					canChangePlayerType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isIgnoreToggleEvent = true;
			this.m_friendToggle.isOn = (playerType == TeamRoomInvitePlayerType.Friend);
			this.m_recentToggle.isOn = (playerType == TeamRoomInvitePlayerType.Recent);
			this.m_guildToggle.isOn = (playerType == TeamRoomInvitePlayerType.Guild);
			this.m_isIgnoreToggleEvent = false;
			if (canChangePlayerType)
			{
				this.m_friendToggle.interactable = true;
				this.m_recentToggle.interactable = true;
				this.m_guildToggle.interactable = true;
			}
			else
			{
				this.m_friendToggle.interactable = (playerType == TeamRoomInvitePlayerType.Friend);
				this.m_recentToggle.interactable = (playerType == TeamRoomInvitePlayerType.Recent);
				this.m_guildToggle.interactable = (playerType == TeamRoomInvitePlayerType.Guild);
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (playerType == TeamRoomInvitePlayerType.Friend)
			{
				this.m_inviteCountTitleText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_OnlineFriend);
			}
			else if (playerType == TeamRoomInvitePlayerType.Recent)
			{
				this.m_inviteCountTitleText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_OnlineRecent);
			}
			else if (playerType == TeamRoomInvitePlayerType.Guild)
			{
				this.m_inviteCountTitleText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_OnlineGuildMember);
			}
		}

		// Token: 0x06013B68 RID: 80744 RVA: 0x00506214 File Offset: 0x00504414
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

		// Token: 0x06013B69 RID: 80745 RVA: 0x00506298 File Offset: 0x00504498
		public void SetPlayers(List<UserSummary> players)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayersList`1_hotfix != null)
			{
				this.m_SetPlayersList`1_hotfix.call(new object[]
				{
					this,
					players
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearPlayerListItems();
			this.m_inviteCountValueText.text = players.Count.ToString();
			foreach (UserSummary userSummary in players)
			{
				bool isRecent = this.IsRecentTeamBattlePlayer(userSummary.UserId);
				this.AddPlayerListItem(userSummary.UserId, userSummary.Name, userSummary.HeadIcon, userSummary.Level, isRecent);
			}
		}

		// Token: 0x06013B6A RID: 80746 RVA: 0x0050639C File Offset: 0x0050459C
		private bool IsRecentTeamBattlePlayer(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRecentTeamBattlePlayerString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRecentTeamBattlePlayerString_hotfix.call(new object[]
				{
					this,
					userId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			BattleRoom battleRoom = projectLPlayerContext.GetBattleRoom();
			return battleRoom != null && battleRoom.FindPlayerByUserId(userId) != null;
		}

		// Token: 0x06013B6B RID: 80747 RVA: 0x00506444 File Offset: 0x00504644
		private void AddPlayerListItem(string userId, string name, int headIconId, int level, bool isRecent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayerListItemStringStringInt32Int32Boolean_hotfix != null)
			{
				this.m_AddPlayerListItemStringStringInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					userId,
					name,
					headIconId,
					level,
					isRecent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_invitePlayerListItemPrefab, this.m_inviteScrollRect.content, false);
			TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController = GameObjectUtility.AddControllerToGameObject<TeamRoomInvitePlayerListItemUIController>(go);
			teamRoomInvitePlayerListItemUIController.SetUserId(userId);
			teamRoomInvitePlayerListItemUIController.SetName(name);
			teamRoomInvitePlayerListItemUIController.SetHeadIcon(headIconId);
			teamRoomInvitePlayerListItemUIController.SetLevel(level);
			teamRoomInvitePlayerListItemUIController.SetIsRecent(isRecent);
			teamRoomInvitePlayerListItemUIController.SetSelected(false);
			teamRoomInvitePlayerListItemUIController.SetInviteState(TeamRoomPlayerInviteState.CanInvite);
			this.m_playerListItems.Add(teamRoomInvitePlayerListItemUIController);
		}

		// Token: 0x06013B6C RID: 80748 RVA: 0x00506554 File Offset: 0x00504754
		private void ClearPlayerListItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPlayerListItems_hotfix != null)
			{
				this.m_ClearPlayerListItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TeamRoomInvitePlayerListItemUIController>(this.m_playerListItems);
			this.m_playerListItems.Clear();
		}

		// Token: 0x06013B6D RID: 80749 RVA: 0x005065CC File Offset: 0x005047CC
		public void UpdatePlayerStatus(string userId, TeamRoomPlayerInviteState inviteState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdatePlayerStatusStringTeamRoomPlayerInviteState_hotfix != null)
			{
				this.m_UpdatePlayerStatusStringTeamRoomPlayerInviteState_hotfix.call(new object[]
				{
					this,
					userId,
					inviteState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController in this.m_playerListItems)
			{
				if (teamRoomInvitePlayerListItemUIController.GetUserId() == userId)
				{
					teamRoomInvitePlayerListItemUIController.SetInviteState(inviteState);
					break;
				}
			}
		}

		// Token: 0x06013B6E RID: 80750 RVA: 0x005066B4 File Offset: 0x005048B4
		public void ShowGildToggleUnopenMask(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGildToggleUnopenMaskBoolean_hotfix != null)
			{
				this.m_ShowGildToggleUnopenMaskBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildToggleUnopenMask.gameObject.SetActive(isShow);
		}

		// Token: 0x06013B6F RID: 80751 RVA: 0x00506738 File Offset: 0x00504938
		private void OnFriendToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFriendToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnFriendToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn && this.EventOnChangePlayerType != null)
			{
				this.EventOnChangePlayerType(TeamRoomInvitePlayerType.Friend);
			}
		}

		// Token: 0x06013B70 RID: 80752 RVA: 0x005067D4 File Offset: 0x005049D4
		private void OnRecentToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecentToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRecentToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn && this.EventOnChangePlayerType != null)
			{
				this.EventOnChangePlayerType(TeamRoomInvitePlayerType.Recent);
			}
		}

		// Token: 0x06013B71 RID: 80753 RVA: 0x00506870 File Offset: 0x00504A70
		private void OnGuildToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnGuildToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn && this.EventOnChangePlayerType != null)
			{
				this.EventOnChangePlayerType(TeamRoomInvitePlayerType.Guild);
			}
		}

		// Token: 0x06013B72 RID: 80754 RVA: 0x0050690C File Offset: 0x00504B0C
		private void OnGuildUnopenMaskClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildUnopenMaskClick_hotfix != null)
			{
				this.m_OnGuildUnopenMaskClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			CommonUIController.Instance.ShowMessage(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_GuildTeamInviteUnopen), 2f, null, true);
		}

		// Token: 0x06013B73 RID: 80755 RVA: 0x00506998 File Offset: 0x00504B98
		private void OnConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmButtonClick_hotfix != null)
			{
				this.m_OnConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnConfirm != null)
			{
				List<string> list = new List<string>();
				foreach (TeamRoomInvitePlayerListItemUIController teamRoomInvitePlayerListItemUIController in this.m_playerListItems)
				{
					if (teamRoomInvitePlayerListItemUIController.IsSelected())
					{
						list.Add(teamRoomInvitePlayerListItemUIController.GetUserId());
					}
				}
				this.EventOnConfirm(list);
			}
		}

		// Token: 0x06013B74 RID: 80756 RVA: 0x00506A74 File Offset: 0x00504C74
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
			if (this.EventOnCancel != null)
			{
				this.EventOnCancel();
			}
		}

		// Token: 0x14000453 RID: 1107
		// (add) Token: 0x06013B75 RID: 80757 RVA: 0x00506AEC File Offset: 0x00504CEC
		// (remove) Token: 0x06013B76 RID: 80758 RVA: 0x00506B88 File Offset: 0x00504D88
		public event Action<List<string>> EventOnConfirm
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmAction`1_hotfix != null)
				{
					this.m_add_EventOnConfirmAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnConfirm;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnConfirm, (Action<List<string>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmAction`1_hotfix != null)
				{
					this.m_remove_EventOnConfirmAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnConfirm;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnConfirm, (Action<List<string>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000454 RID: 1108
		// (add) Token: 0x06013B77 RID: 80759 RVA: 0x00506C24 File Offset: 0x00504E24
		// (remove) Token: 0x06013B78 RID: 80760 RVA: 0x00506CC0 File Offset: 0x00504EC0
		public event Action EventOnCancel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCancelAction_hotfix != null)
				{
					this.m_add_EventOnCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCancelAction_hotfix != null)
				{
					this.m_remove_EventOnCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000455 RID: 1109
		// (add) Token: 0x06013B79 RID: 80761 RVA: 0x00506D5C File Offset: 0x00504F5C
		// (remove) Token: 0x06013B7A RID: 80762 RVA: 0x00506DF8 File Offset: 0x00504FF8
		public event Action<TeamRoomInvitePlayerType> EventOnChangePlayerType
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangePlayerTypeAction`1_hotfix != null)
				{
					this.m_add_EventOnChangePlayerTypeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomInvitePlayerType> action = this.EventOnChangePlayerType;
				Action<TeamRoomInvitePlayerType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomInvitePlayerType>>(ref this.EventOnChangePlayerType, (Action<TeamRoomInvitePlayerType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangePlayerTypeAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangePlayerTypeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomInvitePlayerType> action = this.EventOnChangePlayerType;
				Action<TeamRoomInvitePlayerType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomInvitePlayerType>>(ref this.EventOnChangePlayerType, (Action<TeamRoomInvitePlayerType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x06013B7B RID: 80763 RVA: 0x00506E94 File Offset: 0x00505094
		// (set) Token: 0x06013B7C RID: 80764 RVA: 0x00506EB4 File Offset: 0x005050B4
		[DoNotToLua]
		public new TeamRoomInviteUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomInviteUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013B7D RID: 80765 RVA: 0x00506EC0 File Offset: 0x005050C0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013B7E RID: 80766 RVA: 0x00506ECC File Offset: 0x005050CC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013B7F RID: 80767 RVA: 0x00506ED4 File Offset: 0x005050D4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013B80 RID: 80768 RVA: 0x00506EDC File Offset: 0x005050DC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013B81 RID: 80769 RVA: 0x00506EF0 File Offset: 0x005050F0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013B82 RID: 80770 RVA: 0x00506EF8 File Offset: 0x005050F8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013B83 RID: 80771 RVA: 0x00506F04 File Offset: 0x00505104
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013B84 RID: 80772 RVA: 0x00506F10 File Offset: 0x00505110
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013B85 RID: 80773 RVA: 0x00506F1C File Offset: 0x0050511C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013B86 RID: 80774 RVA: 0x00506F28 File Offset: 0x00505128
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013B87 RID: 80775 RVA: 0x00506F34 File Offset: 0x00505134
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013B88 RID: 80776 RVA: 0x00506F40 File Offset: 0x00505140
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013B89 RID: 80777 RVA: 0x00506F4C File Offset: 0x0050514C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013B8A RID: 80778 RVA: 0x00506F58 File Offset: 0x00505158
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013B8B RID: 80779 RVA: 0x00506F64 File Offset: 0x00505164
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013B8C RID: 80780 RVA: 0x00506F6C File Offset: 0x0050516C
		private void __callDele_EventOnConfirm(List<string> obj)
		{
			Action<List<string>> eventOnConfirm = this.EventOnConfirm;
			if (eventOnConfirm != null)
			{
				eventOnConfirm(obj);
			}
		}

		// Token: 0x06013B8D RID: 80781 RVA: 0x00506F90 File Offset: 0x00505190
		private void __clearDele_EventOnConfirm(List<string> obj)
		{
			this.EventOnConfirm = null;
		}

		// Token: 0x06013B8E RID: 80782 RVA: 0x00506F9C File Offset: 0x0050519C
		private void __callDele_EventOnCancel()
		{
			Action eventOnCancel = this.EventOnCancel;
			if (eventOnCancel != null)
			{
				eventOnCancel();
			}
		}

		// Token: 0x06013B8F RID: 80783 RVA: 0x00506FBC File Offset: 0x005051BC
		private void __clearDele_EventOnCancel()
		{
			this.EventOnCancel = null;
		}

		// Token: 0x06013B90 RID: 80784 RVA: 0x00506FC8 File Offset: 0x005051C8
		private void __callDele_EventOnChangePlayerType(TeamRoomInvitePlayerType obj)
		{
			Action<TeamRoomInvitePlayerType> eventOnChangePlayerType = this.EventOnChangePlayerType;
			if (eventOnChangePlayerType != null)
			{
				eventOnChangePlayerType(obj);
			}
		}

		// Token: 0x06013B91 RID: 80785 RVA: 0x00506FEC File Offset: 0x005051EC
		private void __clearDele_EventOnChangePlayerType(TeamRoomInvitePlayerType obj)
		{
			this.EventOnChangePlayerType = null;
		}

		// Token: 0x06013B92 RID: 80786 RVA: 0x00506FF8 File Offset: 0x005051F8
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
					this.m_SetPlayerTypeTeamRoomInvitePlayerTypeBoolean_hotfix = (luaObj.RawGet("SetPlayerType") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetPlayersList`1_hotfix = (luaObj.RawGet("SetPlayers") as LuaFunction);
					this.m_IsRecentTeamBattlePlayerString_hotfix = (luaObj.RawGet("IsRecentTeamBattlePlayer") as LuaFunction);
					this.m_AddPlayerListItemStringStringInt32Int32Boolean_hotfix = (luaObj.RawGet("AddPlayerListItem") as LuaFunction);
					this.m_ClearPlayerListItems_hotfix = (luaObj.RawGet("ClearPlayerListItems") as LuaFunction);
					this.m_UpdatePlayerStatusStringTeamRoomPlayerInviteState_hotfix = (luaObj.RawGet("UpdatePlayerStatus") as LuaFunction);
					this.m_ShowGildToggleUnopenMaskBoolean_hotfix = (luaObj.RawGet("ShowGildToggleUnopenMask") as LuaFunction);
					this.m_OnFriendToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnFriendToggleValueChanged") as LuaFunction);
					this.m_OnRecentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRecentToggleValueChanged") as LuaFunction);
					this.m_OnGuildToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnGuildToggleValueChanged") as LuaFunction);
					this.m_OnGuildUnopenMaskClick_hotfix = (luaObj.RawGet("OnGuildUnopenMaskClick") as LuaFunction);
					this.m_OnConfirmButtonClick_hotfix = (luaObj.RawGet("OnConfirmButtonClick") as LuaFunction);
					this.m_OnCancelButtonClick_hotfix = (luaObj.RawGet("OnCancelButtonClick") as LuaFunction);
					this.m_add_EventOnConfirmAction`1_hotfix = (luaObj.RawGet("add_EventOnConfirm") as LuaFunction);
					this.m_remove_EventOnConfirmAction`1_hotfix = (luaObj.RawGet("remove_EventOnConfirm") as LuaFunction);
					this.m_add_EventOnCancelAction_hotfix = (luaObj.RawGet("add_EventOnCancel") as LuaFunction);
					this.m_remove_EventOnCancelAction_hotfix = (luaObj.RawGet("remove_EventOnCancel") as LuaFunction);
					this.m_add_EventOnChangePlayerTypeAction`1_hotfix = (luaObj.RawGet("add_EventOnChangePlayerType") as LuaFunction);
					this.m_remove_EventOnChangePlayerTypeAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangePlayerType") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013B93 RID: 80787 RVA: 0x005072D0 File Offset: 0x005054D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AEA4 RID: 44708
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AEA5 RID: 44709
		[AutoBind("./Panel/ToggleGroup/Friend", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_friendToggle;

		// Token: 0x0400AEA6 RID: 44710
		[AutoBind("./Panel/ToggleGroup/Nearly", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_recentToggle;

		// Token: 0x0400AEA7 RID: 44711
		[AutoBind("./Panel/ToggleGroup/Sociaty", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_guildToggle;

		// Token: 0x0400AEA8 RID: 44712
		[AutoBind("./Panel/ToggleGroup/Sociaty/UnopenMask", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildToggleUnopenMask;

		// Token: 0x0400AEA9 RID: 44713
		[AutoBind("./Panel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmButton;

		// Token: 0x0400AEAA RID: 44714
		[AutoBind("./Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelButton;

		// Token: 0x0400AEAB RID: 44715
		[AutoBind("./Panel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_inviteScrollRect;

		// Token: 0x0400AEAC RID: 44716
		[AutoBind("./Panel/InvitedCount/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteCountTitleText;

		// Token: 0x0400AEAD RID: 44717
		[AutoBind("./Panel/InvitedCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteCountValueText;

		// Token: 0x0400AEAE RID: 44718
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400AEAF RID: 44719
		[AutoBind("./Prefabs/PlayerListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_invitePlayerListItemPrefab;

		// Token: 0x0400AEB0 RID: 44720
		private List<TeamRoomInvitePlayerListItemUIController> m_playerListItems = new List<TeamRoomInvitePlayerListItemUIController>();

		// Token: 0x0400AEB1 RID: 44721
		private bool m_isIgnoreToggleEvent;

		// Token: 0x0400AEB2 RID: 44722
		[DoNotToLua]
		private TeamRoomInviteUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AEB3 RID: 44723
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AEB4 RID: 44724
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AEB5 RID: 44725
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AEB6 RID: 44726
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400AEB7 RID: 44727
		private LuaFunction m_SetPlayerTypeTeamRoomInvitePlayerTypeBoolean_hotfix;

		// Token: 0x0400AEB8 RID: 44728
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x0400AEB9 RID: 44729
		private LuaFunction m_SetPlayersList;

		// Token: 0x0400AEBA RID: 44730
		private LuaFunction m_IsRecentTeamBattlePlayerString_hotfix;

		// Token: 0x0400AEBB RID: 44731
		private LuaFunction m_AddPlayerListItemStringStringInt32Int32Boolean_hotfix;

		// Token: 0x0400AEBC RID: 44732
		private LuaFunction m_ClearPlayerListItems_hotfix;

		// Token: 0x0400AEBD RID: 44733
		private LuaFunction m_UpdatePlayerStatusStringTeamRoomPlayerInviteState_hotfix;

		// Token: 0x0400AEBE RID: 44734
		private LuaFunction m_ShowGildToggleUnopenMaskBoolean_hotfix;

		// Token: 0x0400AEBF RID: 44735
		private LuaFunction m_OnFriendToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AEC0 RID: 44736
		private LuaFunction m_OnRecentToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AEC1 RID: 44737
		private LuaFunction m_OnGuildToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AEC2 RID: 44738
		private LuaFunction m_OnGuildUnopenMaskClick_hotfix;

		// Token: 0x0400AEC3 RID: 44739
		private LuaFunction m_OnConfirmButtonClick_hotfix;

		// Token: 0x0400AEC4 RID: 44740
		private LuaFunction m_OnCancelButtonClick_hotfix;

		// Token: 0x0400AEC5 RID: 44741
		private LuaFunction m_add_EventOnConfirmAction;

		// Token: 0x0400AEC6 RID: 44742
		private LuaFunction m_remove_EventOnConfirmAction;

		// Token: 0x0400AEC7 RID: 44743
		private LuaFunction m_add_EventOnCancelAction_hotfix;

		// Token: 0x0400AEC8 RID: 44744
		private LuaFunction m_remove_EventOnCancelAction_hotfix;

		// Token: 0x0400AEC9 RID: 44745
		private LuaFunction m_add_EventOnChangePlayerTypeAction;

		// Token: 0x0400AECA RID: 44746
		private LuaFunction m_remove_EventOnChangePlayerTypeAction;

		// Token: 0x02000F73 RID: 3955
		public new class LuaExportHelper
		{
			// Token: 0x06013B94 RID: 80788 RVA: 0x00507338 File Offset: 0x00505538
			public LuaExportHelper(TeamRoomInviteUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013B95 RID: 80789 RVA: 0x00507348 File Offset: 0x00505548
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013B96 RID: 80790 RVA: 0x00507358 File Offset: 0x00505558
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013B97 RID: 80791 RVA: 0x00507368 File Offset: 0x00505568
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013B98 RID: 80792 RVA: 0x00507378 File Offset: 0x00505578
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013B99 RID: 80793 RVA: 0x00507390 File Offset: 0x00505590
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013B9A RID: 80794 RVA: 0x005073A0 File Offset: 0x005055A0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013B9B RID: 80795 RVA: 0x005073B0 File Offset: 0x005055B0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013B9C RID: 80796 RVA: 0x005073C0 File Offset: 0x005055C0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013B9D RID: 80797 RVA: 0x005073D0 File Offset: 0x005055D0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013B9E RID: 80798 RVA: 0x005073E0 File Offset: 0x005055E0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013B9F RID: 80799 RVA: 0x005073F0 File Offset: 0x005055F0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013BA0 RID: 80800 RVA: 0x00507400 File Offset: 0x00505600
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013BA1 RID: 80801 RVA: 0x00507410 File Offset: 0x00505610
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013BA2 RID: 80802 RVA: 0x00507420 File Offset: 0x00505620
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013BA3 RID: 80803 RVA: 0x00507430 File Offset: 0x00505630
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013BA4 RID: 80804 RVA: 0x00507440 File Offset: 0x00505640
			public void __callDele_EventOnConfirm(List<string> obj)
			{
				this.m_owner.__callDele_EventOnConfirm(obj);
			}

			// Token: 0x06013BA5 RID: 80805 RVA: 0x00507450 File Offset: 0x00505650
			public void __clearDele_EventOnConfirm(List<string> obj)
			{
				this.m_owner.__clearDele_EventOnConfirm(obj);
			}

			// Token: 0x06013BA6 RID: 80806 RVA: 0x00507460 File Offset: 0x00505660
			public void __callDele_EventOnCancel()
			{
				this.m_owner.__callDele_EventOnCancel();
			}

			// Token: 0x06013BA7 RID: 80807 RVA: 0x00507470 File Offset: 0x00505670
			public void __clearDele_EventOnCancel()
			{
				this.m_owner.__clearDele_EventOnCancel();
			}

			// Token: 0x06013BA8 RID: 80808 RVA: 0x00507480 File Offset: 0x00505680
			public void __callDele_EventOnChangePlayerType(TeamRoomInvitePlayerType obj)
			{
				this.m_owner.__callDele_EventOnChangePlayerType(obj);
			}

			// Token: 0x06013BA9 RID: 80809 RVA: 0x00507490 File Offset: 0x00505690
			public void __clearDele_EventOnChangePlayerType(TeamRoomInvitePlayerType obj)
			{
				this.m_owner.__clearDele_EventOnChangePlayerType(obj);
			}

			// Token: 0x17003B0B RID: 15115
			// (get) Token: 0x06013BAA RID: 80810 RVA: 0x005074A0 File Offset: 0x005056A0
			// (set) Token: 0x06013BAB RID: 80811 RVA: 0x005074B0 File Offset: 0x005056B0
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

			// Token: 0x17003B0C RID: 15116
			// (get) Token: 0x06013BAC RID: 80812 RVA: 0x005074C0 File Offset: 0x005056C0
			// (set) Token: 0x06013BAD RID: 80813 RVA: 0x005074D0 File Offset: 0x005056D0
			public Toggle m_friendToggle
			{
				get
				{
					return this.m_owner.m_friendToggle;
				}
				set
				{
					this.m_owner.m_friendToggle = value;
				}
			}

			// Token: 0x17003B0D RID: 15117
			// (get) Token: 0x06013BAE RID: 80814 RVA: 0x005074E0 File Offset: 0x005056E0
			// (set) Token: 0x06013BAF RID: 80815 RVA: 0x005074F0 File Offset: 0x005056F0
			public Toggle m_recentToggle
			{
				get
				{
					return this.m_owner.m_recentToggle;
				}
				set
				{
					this.m_owner.m_recentToggle = value;
				}
			}

			// Token: 0x17003B0E RID: 15118
			// (get) Token: 0x06013BB0 RID: 80816 RVA: 0x00507500 File Offset: 0x00505700
			// (set) Token: 0x06013BB1 RID: 80817 RVA: 0x00507510 File Offset: 0x00505710
			public Toggle m_guildToggle
			{
				get
				{
					return this.m_owner.m_guildToggle;
				}
				set
				{
					this.m_owner.m_guildToggle = value;
				}
			}

			// Token: 0x17003B0F RID: 15119
			// (get) Token: 0x06013BB2 RID: 80818 RVA: 0x00507520 File Offset: 0x00505720
			// (set) Token: 0x06013BB3 RID: 80819 RVA: 0x00507530 File Offset: 0x00505730
			public Button m_guildToggleUnopenMask
			{
				get
				{
					return this.m_owner.m_guildToggleUnopenMask;
				}
				set
				{
					this.m_owner.m_guildToggleUnopenMask = value;
				}
			}

			// Token: 0x17003B10 RID: 15120
			// (get) Token: 0x06013BB4 RID: 80820 RVA: 0x00507540 File Offset: 0x00505740
			// (set) Token: 0x06013BB5 RID: 80821 RVA: 0x00507550 File Offset: 0x00505750
			public Button m_confirmButton
			{
				get
				{
					return this.m_owner.m_confirmButton;
				}
				set
				{
					this.m_owner.m_confirmButton = value;
				}
			}

			// Token: 0x17003B11 RID: 15121
			// (get) Token: 0x06013BB6 RID: 80822 RVA: 0x00507560 File Offset: 0x00505760
			// (set) Token: 0x06013BB7 RID: 80823 RVA: 0x00507570 File Offset: 0x00505770
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

			// Token: 0x17003B12 RID: 15122
			// (get) Token: 0x06013BB8 RID: 80824 RVA: 0x00507580 File Offset: 0x00505780
			// (set) Token: 0x06013BB9 RID: 80825 RVA: 0x00507590 File Offset: 0x00505790
			public ScrollRect m_inviteScrollRect
			{
				get
				{
					return this.m_owner.m_inviteScrollRect;
				}
				set
				{
					this.m_owner.m_inviteScrollRect = value;
				}
			}

			// Token: 0x17003B13 RID: 15123
			// (get) Token: 0x06013BBA RID: 80826 RVA: 0x005075A0 File Offset: 0x005057A0
			// (set) Token: 0x06013BBB RID: 80827 RVA: 0x005075B0 File Offset: 0x005057B0
			public Text m_inviteCountTitleText
			{
				get
				{
					return this.m_owner.m_inviteCountTitleText;
				}
				set
				{
					this.m_owner.m_inviteCountTitleText = value;
				}
			}

			// Token: 0x17003B14 RID: 15124
			// (get) Token: 0x06013BBC RID: 80828 RVA: 0x005075C0 File Offset: 0x005057C0
			// (set) Token: 0x06013BBD RID: 80829 RVA: 0x005075D0 File Offset: 0x005057D0
			public Text m_inviteCountValueText
			{
				get
				{
					return this.m_owner.m_inviteCountValueText;
				}
				set
				{
					this.m_owner.m_inviteCountValueText = value;
				}
			}

			// Token: 0x17003B15 RID: 15125
			// (get) Token: 0x06013BBE RID: 80830 RVA: 0x005075E0 File Offset: 0x005057E0
			// (set) Token: 0x06013BBF RID: 80831 RVA: 0x005075F0 File Offset: 0x005057F0
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

			// Token: 0x17003B16 RID: 15126
			// (get) Token: 0x06013BC0 RID: 80832 RVA: 0x00507600 File Offset: 0x00505800
			// (set) Token: 0x06013BC1 RID: 80833 RVA: 0x00507610 File Offset: 0x00505810
			public GameObject m_invitePlayerListItemPrefab
			{
				get
				{
					return this.m_owner.m_invitePlayerListItemPrefab;
				}
				set
				{
					this.m_owner.m_invitePlayerListItemPrefab = value;
				}
			}

			// Token: 0x17003B17 RID: 15127
			// (get) Token: 0x06013BC2 RID: 80834 RVA: 0x00507620 File Offset: 0x00505820
			// (set) Token: 0x06013BC3 RID: 80835 RVA: 0x00507630 File Offset: 0x00505830
			public List<TeamRoomInvitePlayerListItemUIController> m_playerListItems
			{
				get
				{
					return this.m_owner.m_playerListItems;
				}
				set
				{
					this.m_owner.m_playerListItems = value;
				}
			}

			// Token: 0x17003B18 RID: 15128
			// (get) Token: 0x06013BC4 RID: 80836 RVA: 0x00507640 File Offset: 0x00505840
			// (set) Token: 0x06013BC5 RID: 80837 RVA: 0x00507650 File Offset: 0x00505850
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

			// Token: 0x06013BC6 RID: 80838 RVA: 0x00507660 File Offset: 0x00505860
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013BC7 RID: 80839 RVA: 0x00507670 File Offset: 0x00505870
			public bool IsRecentTeamBattlePlayer(string userId)
			{
				return this.m_owner.IsRecentTeamBattlePlayer(userId);
			}

			// Token: 0x06013BC8 RID: 80840 RVA: 0x00507680 File Offset: 0x00505880
			public void AddPlayerListItem(string userId, string name, int headIconId, int level, bool isRecent)
			{
				this.m_owner.AddPlayerListItem(userId, name, headIconId, level, isRecent);
			}

			// Token: 0x06013BC9 RID: 80841 RVA: 0x00507694 File Offset: 0x00505894
			public void ClearPlayerListItems()
			{
				this.m_owner.ClearPlayerListItems();
			}

			// Token: 0x06013BCA RID: 80842 RVA: 0x005076A4 File Offset: 0x005058A4
			public void OnFriendToggleValueChanged(bool isOn)
			{
				this.m_owner.OnFriendToggleValueChanged(isOn);
			}

			// Token: 0x06013BCB RID: 80843 RVA: 0x005076B4 File Offset: 0x005058B4
			public void OnRecentToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRecentToggleValueChanged(isOn);
			}

			// Token: 0x06013BCC RID: 80844 RVA: 0x005076C4 File Offset: 0x005058C4
			public void OnGuildToggleValueChanged(bool isOn)
			{
				this.m_owner.OnGuildToggleValueChanged(isOn);
			}

			// Token: 0x06013BCD RID: 80845 RVA: 0x005076D4 File Offset: 0x005058D4
			public void OnGuildUnopenMaskClick()
			{
				this.m_owner.OnGuildUnopenMaskClick();
			}

			// Token: 0x06013BCE RID: 80846 RVA: 0x005076E4 File Offset: 0x005058E4
			public void OnConfirmButtonClick()
			{
				this.m_owner.OnConfirmButtonClick();
			}

			// Token: 0x06013BCF RID: 80847 RVA: 0x005076F4 File Offset: 0x005058F4
			public void OnCancelButtonClick()
			{
				this.m_owner.OnCancelButtonClick();
			}

			// Token: 0x0400AECB RID: 44747
			private TeamRoomInviteUIController m_owner;
		}
	}
}
