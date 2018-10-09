using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CB4 RID: 3252
	[HotFix]
	public class FriendBigItemUIController : UIControllerBase
	{
		// Token: 0x0600EB13 RID: 60179 RVA: 0x003EDB4C File Offset: 0x003EBD4C
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
			this.m_itemButton.onClick.AddListener(new UnityAction(this.OnItemButtonClick));
			this.m_addButton.onClick.AddListener(new UnityAction(this.OnAddButtonClick));
			this.m_unblockButton.onClick.AddListener(new UnityAction(this.OnUnblockButtonClick));
			this.m_kickButton.onClick.AddListener(new UnityAction(this.OnKickButtonClick));
			this.m_bigChatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_chatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_sendButton.onClick.AddListener(new UnityAction(this.OnSendButtonClick));
			this.m_getButton.onClick.AddListener(new UnityAction(this.OnGetButtonClick));
			this.m_doneButton.onClick.AddListener(new UnityAction(this.OnDoneButtonClick));
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x003EDCB0 File Offset: 0x003EBEB0
		public void SetFriendInfo(UserSummary userSummy, FriendInfoType friendInfoType, bool isChatGroupOwner = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFriendInfoUserSummaryFriendInfoTypeBoolean_hotfix != null)
			{
				this.m_SetFriendInfoUserSummaryFriendInfoTypeBoolean_hotfix.call(new object[]
				{
					this,
					userSummy,
					friendInfoType,
					isChatGroupOwner
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (friendInfoType)
			{
			case FriendInfoType.Friend:
				this.m_friendServerText.gameObject.SetActive(false);
				this.m_chatButton.gameObject.SetActive(true);
				if (this.m_playerContext.HasReceivedFriendShipPoints(userSummy.UserId))
				{
					this.m_buttonGroupUIStateController.SetToUIState("Get", false, true);
				}
				else if (this.m_playerContext.CanSendFriendshipPoint(userSummy.UserId))
				{
					this.m_buttonGroupUIStateController.SetToUIState("Send", false, true);
				}
				else
				{
					this.m_buttonGroupUIStateController.SetToUIState("Done", false, true);
				}
				break;
			case FriendInfoType.AcrossServerFriend:
				this.m_friendServerText.gameObject.SetActive(true);
				this.m_chatButton.gameObject.SetActive(false);
				this.m_buttonGroupUIStateController.SetToUIState("BigChat", false, true);
				break;
			case FriendInfoType.Shield:
				this.m_friendServerText.gameObject.SetActive(false);
				this.m_chatButton.gameObject.SetActive(false);
				this.m_buttonGroupUIStateController.SetToUIState("Unblock", false, true);
				break;
			case FriendInfoType.Recent:
				this.m_friendServerText.gameObject.SetActive(false);
				this.m_chatButton.gameObject.SetActive(false);
				if (this.m_playerContext.IsFriend(userSummy.UserId))
				{
					this.m_buttonGroupUIStateController.SetToUIState("BigChat", false, true);
				}
				else
				{
					this.m_buttonGroupUIStateController.SetToUIState("Add", false, true);
				}
				break;
			case FriendInfoType.Group:
				this.m_buttonGroupUIStateController.SetToUIState((!isChatGroupOwner || this.m_playerContext.IsMe(userSummy.UserId)) ? "None" : "Delete", false, true);
				break;
			}
			if (userSummy.Online)
			{
				this.m_friendIconImage.gameObject.SetActive(true);
				this.m_friendIconGreyImage.gameObject.SetActive(false);
				this.m_friendOnlineUIStateController.SetToUIState("NormalShort", false, true);
			}
			else
			{
				this.m_friendIconImage.gameObject.SetActive(false);
				this.m_friendIconGreyImage.gameObject.SetActive(true);
				TimeSpan timeSpan = this.m_playerContext.GetServerTime() - userSummy.LogoutTime;
				if (timeSpan.TotalHours < 1.0)
				{
					this.m_friendOnlineLongText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_InOneHour);
				}
				else if (timeSpan.TotalDays < 1.0 && timeSpan.TotalHours >= 1.0)
				{
					this.m_friendOnlineLongText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_HoursAgo), Math.Floor(timeSpan.TotalHours).ToString());
				}
				else if (timeSpan.TotalDays >= 1.0)
				{
					this.m_friendOnlineLongText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_DaysAgo), Math.Floor(timeSpan.TotalDays).ToString());
				}
				this.m_friendOnlineUIStateController.SetToUIState("GreyLong", false, true);
			}
			this.m_userSummy = userSummy;
			this.m_userID = userSummy.UserId;
			this.m_friendLevelText.text = userSummy.Level.ToString();
			this.m_friendNameText.text = userSummy.Name;
			this.m_friendServerText.text = this.GetServerName(userSummy.UserId);
			Image friendIconImage = this.m_friendIconImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(userSummy.HeadIcon)));
			this.m_friendIconGreyImage.sprite = sprite;
			friendIconImage.sprite = sprite;
			UIUtility.SetPlayerHeadFrame(this.m_friendHeadFrameTransform, HeadIconTools.GetHeadFrame(userSummy.HeadIcon), true, (!userSummy.Online) ? "Offline" : "Normal");
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x003EE150 File Offset: 0x003EC350
		private string GetServerName(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetServerNameString_hotfix != null)
			{
				return (string)this.m_GetServerNameString_hotfix.call(new object[]
				{
					this,
					userId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LoginUITask.ServerInfo serverInfoByBornChannelID = LoginUITask.GetServerInfoByBornChannelID(RoleGenerator.GetBornChannelIdFromUserId(userId));
			if (serverInfoByBornChannelID != null)
			{
				return serverInfoByBornChannelID.m_name;
			}
			return string.Empty;
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x003EE1EC File Offset: 0x003EC3EC
		public string GetUserID()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUserID_hotfix != null)
			{
				return (string)this.m_GetUserID_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_userID;
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x003EE260 File Offset: 0x003EC460
		public UserSummary GetUserSummy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUserSummy_hotfix != null)
			{
				return (UserSummary)this.m_GetUserSummy_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_userSummy;
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x003EE2D4 File Offset: 0x003EC4D4
		public PlayerSimpleInfoUITask.PostionType GetSimpleInfoPostionType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSimpleInfoPostionType_hotfix != null)
			{
				return (PlayerSimpleInfoUITask.PostionType)this.m_GetSimpleInfoPostionType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rectTransform = this.m_itemButton.transform as RectTransform;
			if (rectTransform.position.x < 0f)
			{
				return PlayerSimpleInfoUITask.PostionType.Right;
			}
			return PlayerSimpleInfoUITask.PostionType.Left;
		}

		// Token: 0x0600EB19 RID: 60185 RVA: 0x003EE36C File Offset: 0x003EC56C
		public Vector3 GetPlayerSimpleInfoPos()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerSimpleInfoPos_hotfix != null)
			{
				return (Vector3)this.m_GetPlayerSimpleInfoPos_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rectTransform = this.m_itemButton.transform as RectTransform;
			Vector3[] array = new Vector3[4];
			rectTransform.GetWorldCorners(array);
			if (rectTransform.position.x < 0f)
			{
				return rectTransform.position + new Vector3((array[3].x - array[0].x) / 2f, (array[1].y - array[0].y) / 2f, 0f);
			}
			return rectTransform.position + new Vector3(-(array[3].x - array[0].x) / 2f, (array[1].y - array[0].y) / 2f, 0f);
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x003EE4B8 File Offset: 0x003EC6B8
		private void OnItemButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemButtonClick_hotfix != null)
			{
				this.m_OnItemButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerSimpleInfo != null)
			{
				this.EventOnShowPlayerSimpleInfo(this);
			}
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x003EE530 File Offset: 0x003EC730
		private void OnAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddButtonClick_hotfix != null)
			{
				this.m_OnAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAdd != null)
			{
				this.EventOnAdd(this);
			}
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x003EE5A8 File Offset: 0x003EC7A8
		private void OnKickButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnKickButtonClick_hotfix != null)
			{
				this.m_OnKickButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnKickFromGroup != null)
			{
				this.EventOnKickFromGroup(this);
			}
		}

		// Token: 0x0600EB1D RID: 60189 RVA: 0x003EE620 File Offset: 0x003EC820
		private void OnUnblockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnblockButtonClick_hotfix != null)
			{
				this.m_OnUnblockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnUnblock != null)
			{
				this.EventOnUnblock(this);
			}
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x003EE698 File Offset: 0x003EC898
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
			if (this.EventOnChat != null)
			{
				this.EventOnChat(this);
			}
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x003EE710 File Offset: 0x003EC910
		private void OnSendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSendButtonClick_hotfix != null)
			{
				this.m_OnSendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSendFriendShipPoints != null)
			{
				this.EventOnSendFriendShipPoints(this);
			}
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x003EE788 File Offset: 0x003EC988
		private void OnGetButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetButtonClick_hotfix != null)
			{
				this.m_OnGetButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetFriendShipPoints != null)
			{
				this.EventOnGetFriendShipPoints(this);
			}
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x003EE800 File Offset: 0x003ECA00
		private void OnDoneButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDoneButtonClick_hotfix != null)
			{
				this.m_OnDoneButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFriendShipPointsDone != null)
			{
				this.EventOnFriendShipPointsDone(this);
			}
		}

		// Token: 0x1400030E RID: 782
		// (add) Token: 0x0600EB22 RID: 60194 RVA: 0x003EE878 File Offset: 0x003ECA78
		// (remove) Token: 0x0600EB23 RID: 60195 RVA: 0x003EE914 File Offset: 0x003ECB14
		public event Action<FriendBigItemUIController> EventOnShowPlayerSimpleInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPlayerSimpleInfoAction`1_hotfix != null)
				{
					this.m_add_EventOnShowPlayerSimpleInfoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnShowPlayerSimpleInfo;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnShowPlayerSimpleInfo, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPlayerSimpleInfoAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowPlayerSimpleInfoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnShowPlayerSimpleInfo;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnShowPlayerSimpleInfo, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400030F RID: 783
		// (add) Token: 0x0600EB24 RID: 60196 RVA: 0x003EE9B0 File Offset: 0x003ECBB0
		// (remove) Token: 0x0600EB25 RID: 60197 RVA: 0x003EEA4C File Offset: 0x003ECC4C
		public event Action<FriendBigItemUIController> EventOnAdd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddAction`1_hotfix != null)
				{
					this.m_add_EventOnAddAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnAdd;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnAdd, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnAdd;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnAdd, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000310 RID: 784
		// (add) Token: 0x0600EB26 RID: 60198 RVA: 0x003EEAE8 File Offset: 0x003ECCE8
		// (remove) Token: 0x0600EB27 RID: 60199 RVA: 0x003EEB84 File Offset: 0x003ECD84
		public event Action<FriendBigItemUIController> EventOnKickFromGroup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnKickFromGroupAction`1_hotfix != null)
				{
					this.m_add_EventOnKickFromGroupAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnKickFromGroup;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnKickFromGroup, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnKickFromGroupAction`1_hotfix != null)
				{
					this.m_remove_EventOnKickFromGroupAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnKickFromGroup;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnKickFromGroup, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000311 RID: 785
		// (add) Token: 0x0600EB28 RID: 60200 RVA: 0x003EEC20 File Offset: 0x003ECE20
		// (remove) Token: 0x0600EB29 RID: 60201 RVA: 0x003EECBC File Offset: 0x003ECEBC
		public event Action<FriendBigItemUIController> EventOnUnblock
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUnblockAction`1_hotfix != null)
				{
					this.m_add_EventOnUnblockAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnUnblock;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnUnblock, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUnblockAction`1_hotfix != null)
				{
					this.m_remove_EventOnUnblockAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnUnblock;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnUnblock, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000312 RID: 786
		// (add) Token: 0x0600EB2A RID: 60202 RVA: 0x003EED58 File Offset: 0x003ECF58
		// (remove) Token: 0x0600EB2B RID: 60203 RVA: 0x003EEDF4 File Offset: 0x003ECFF4
		public event Action<FriendBigItemUIController> EventOnChat
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChatAction`1_hotfix != null)
				{
					this.m_add_EventOnChatAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnChat;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnChat, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChatAction`1_hotfix != null)
				{
					this.m_remove_EventOnChatAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnChat;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnChat, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000313 RID: 787
		// (add) Token: 0x0600EB2C RID: 60204 RVA: 0x003EEE90 File Offset: 0x003ED090
		// (remove) Token: 0x0600EB2D RID: 60205 RVA: 0x003EEF2C File Offset: 0x003ED12C
		public event Action<FriendBigItemUIController> EventOnSendFriendShipPoints
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSendFriendShipPointsAction`1_hotfix != null)
				{
					this.m_add_EventOnSendFriendShipPointsAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnSendFriendShipPoints;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnSendFriendShipPoints, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSendFriendShipPointsAction`1_hotfix != null)
				{
					this.m_remove_EventOnSendFriendShipPointsAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnSendFriendShipPoints;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnSendFriendShipPoints, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000314 RID: 788
		// (add) Token: 0x0600EB2E RID: 60206 RVA: 0x003EEFC8 File Offset: 0x003ED1C8
		// (remove) Token: 0x0600EB2F RID: 60207 RVA: 0x003EF064 File Offset: 0x003ED264
		public event Action<FriendBigItemUIController> EventOnGetFriendShipPoints
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetFriendShipPointsAction`1_hotfix != null)
				{
					this.m_add_EventOnGetFriendShipPointsAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnGetFriendShipPoints;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnGetFriendShipPoints, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetFriendShipPointsAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetFriendShipPointsAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnGetFriendShipPoints;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnGetFriendShipPoints, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000315 RID: 789
		// (add) Token: 0x0600EB30 RID: 60208 RVA: 0x003EF100 File Offset: 0x003ED300
		// (remove) Token: 0x0600EB31 RID: 60209 RVA: 0x003EF19C File Offset: 0x003ED39C
		public event Action<FriendBigItemUIController> EventOnFriendShipPointsDone
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFriendShipPointsDoneAction`1_hotfix != null)
				{
					this.m_add_EventOnFriendShipPointsDoneAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnFriendShipPointsDone;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnFriendShipPointsDone, (Action<FriendBigItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFriendShipPointsDoneAction`1_hotfix != null)
				{
					this.m_remove_EventOnFriendShipPointsDoneAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendBigItemUIController> action = this.EventOnFriendShipPointsDone;
				Action<FriendBigItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendBigItemUIController>>(ref this.EventOnFriendShipPointsDone, (Action<FriendBigItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x0600EB32 RID: 60210 RVA: 0x003EF238 File Offset: 0x003ED438
		// (set) Token: 0x0600EB33 RID: 60211 RVA: 0x003EF258 File Offset: 0x003ED458
		[DoNotToLua]
		public new FriendBigItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendBigItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x003EF264 File Offset: 0x003ED464
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x003EF270 File Offset: 0x003ED470
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EB36 RID: 60214 RVA: 0x003EF278 File Offset: 0x003ED478
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EB37 RID: 60215 RVA: 0x003EF280 File Offset: 0x003ED480
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x003EF294 File Offset: 0x003ED494
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EB39 RID: 60217 RVA: 0x003EF29C File Offset: 0x003ED49C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EB3A RID: 60218 RVA: 0x003EF2A8 File Offset: 0x003ED4A8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EB3B RID: 60219 RVA: 0x003EF2B4 File Offset: 0x003ED4B4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x003EF2C0 File Offset: 0x003ED4C0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EB3D RID: 60221 RVA: 0x003EF2CC File Offset: 0x003ED4CC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EB3E RID: 60222 RVA: 0x003EF2D8 File Offset: 0x003ED4D8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x003EF2E4 File Offset: 0x003ED4E4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x003EF2F0 File Offset: 0x003ED4F0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x003EF2FC File Offset: 0x003ED4FC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x003EF308 File Offset: 0x003ED508
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x003EF310 File Offset: 0x003ED510
		private void __callDele_EventOnShowPlayerSimpleInfo(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnShowPlayerSimpleInfo = this.EventOnShowPlayerSimpleInfo;
			if (eventOnShowPlayerSimpleInfo != null)
			{
				eventOnShowPlayerSimpleInfo(obj);
			}
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x003EF334 File Offset: 0x003ED534
		private void __clearDele_EventOnShowPlayerSimpleInfo(FriendBigItemUIController obj)
		{
			this.EventOnShowPlayerSimpleInfo = null;
		}

		// Token: 0x0600EB45 RID: 60229 RVA: 0x003EF340 File Offset: 0x003ED540
		private void __callDele_EventOnAdd(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnAdd = this.EventOnAdd;
			if (eventOnAdd != null)
			{
				eventOnAdd(obj);
			}
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x003EF364 File Offset: 0x003ED564
		private void __clearDele_EventOnAdd(FriendBigItemUIController obj)
		{
			this.EventOnAdd = null;
		}

		// Token: 0x0600EB47 RID: 60231 RVA: 0x003EF370 File Offset: 0x003ED570
		private void __callDele_EventOnKickFromGroup(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnKickFromGroup = this.EventOnKickFromGroup;
			if (eventOnKickFromGroup != null)
			{
				eventOnKickFromGroup(obj);
			}
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x003EF394 File Offset: 0x003ED594
		private void __clearDele_EventOnKickFromGroup(FriendBigItemUIController obj)
		{
			this.EventOnKickFromGroup = null;
		}

		// Token: 0x0600EB49 RID: 60233 RVA: 0x003EF3A0 File Offset: 0x003ED5A0
		private void __callDele_EventOnUnblock(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnUnblock = this.EventOnUnblock;
			if (eventOnUnblock != null)
			{
				eventOnUnblock(obj);
			}
		}

		// Token: 0x0600EB4A RID: 60234 RVA: 0x003EF3C4 File Offset: 0x003ED5C4
		private void __clearDele_EventOnUnblock(FriendBigItemUIController obj)
		{
			this.EventOnUnblock = null;
		}

		// Token: 0x0600EB4B RID: 60235 RVA: 0x003EF3D0 File Offset: 0x003ED5D0
		private void __callDele_EventOnChat(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnChat = this.EventOnChat;
			if (eventOnChat != null)
			{
				eventOnChat(obj);
			}
		}

		// Token: 0x0600EB4C RID: 60236 RVA: 0x003EF3F4 File Offset: 0x003ED5F4
		private void __clearDele_EventOnChat(FriendBigItemUIController obj)
		{
			this.EventOnChat = null;
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x003EF400 File Offset: 0x003ED600
		private void __callDele_EventOnSendFriendShipPoints(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnSendFriendShipPoints = this.EventOnSendFriendShipPoints;
			if (eventOnSendFriendShipPoints != null)
			{
				eventOnSendFriendShipPoints(obj);
			}
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x003EF424 File Offset: 0x003ED624
		private void __clearDele_EventOnSendFriendShipPoints(FriendBigItemUIController obj)
		{
			this.EventOnSendFriendShipPoints = null;
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x003EF430 File Offset: 0x003ED630
		private void __callDele_EventOnGetFriendShipPoints(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnGetFriendShipPoints = this.EventOnGetFriendShipPoints;
			if (eventOnGetFriendShipPoints != null)
			{
				eventOnGetFriendShipPoints(obj);
			}
		}

		// Token: 0x0600EB50 RID: 60240 RVA: 0x003EF454 File Offset: 0x003ED654
		private void __clearDele_EventOnGetFriendShipPoints(FriendBigItemUIController obj)
		{
			this.EventOnGetFriendShipPoints = null;
		}

		// Token: 0x0600EB51 RID: 60241 RVA: 0x003EF460 File Offset: 0x003ED660
		private void __callDele_EventOnFriendShipPointsDone(FriendBigItemUIController obj)
		{
			Action<FriendBigItemUIController> eventOnFriendShipPointsDone = this.EventOnFriendShipPointsDone;
			if (eventOnFriendShipPointsDone != null)
			{
				eventOnFriendShipPointsDone(obj);
			}
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x003EF484 File Offset: 0x003ED684
		private void __clearDele_EventOnFriendShipPointsDone(FriendBigItemUIController obj)
		{
			this.EventOnFriendShipPointsDone = null;
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x003EF490 File Offset: 0x003ED690
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
					this.m_SetFriendInfoUserSummaryFriendInfoTypeBoolean_hotfix = (luaObj.RawGet("SetFriendInfo") as LuaFunction);
					this.m_GetServerNameString_hotfix = (luaObj.RawGet("GetServerName") as LuaFunction);
					this.m_GetUserID_hotfix = (luaObj.RawGet("GetUserID") as LuaFunction);
					this.m_GetUserSummy_hotfix = (luaObj.RawGet("GetUserSummy") as LuaFunction);
					this.m_GetSimpleInfoPostionType_hotfix = (luaObj.RawGet("GetSimpleInfoPostionType") as LuaFunction);
					this.m_GetPlayerSimpleInfoPos_hotfix = (luaObj.RawGet("GetPlayerSimpleInfoPos") as LuaFunction);
					this.m_OnItemButtonClick_hotfix = (luaObj.RawGet("OnItemButtonClick") as LuaFunction);
					this.m_OnAddButtonClick_hotfix = (luaObj.RawGet("OnAddButtonClick") as LuaFunction);
					this.m_OnKickButtonClick_hotfix = (luaObj.RawGet("OnKickButtonClick") as LuaFunction);
					this.m_OnUnblockButtonClick_hotfix = (luaObj.RawGet("OnUnblockButtonClick") as LuaFunction);
					this.m_OnChatButtonClick_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnSendButtonClick_hotfix = (luaObj.RawGet("OnSendButtonClick") as LuaFunction);
					this.m_OnGetButtonClick_hotfix = (luaObj.RawGet("OnGetButtonClick") as LuaFunction);
					this.m_OnDoneButtonClick_hotfix = (luaObj.RawGet("OnDoneButtonClick") as LuaFunction);
					this.m_add_EventOnShowPlayerSimpleInfoAction`1_hotfix = (luaObj.RawGet("add_EventOnShowPlayerSimpleInfo") as LuaFunction);
					this.m_remove_EventOnShowPlayerSimpleInfoAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerSimpleInfo") as LuaFunction);
					this.m_add_EventOnAddAction`1_hotfix = (luaObj.RawGet("add_EventOnAdd") as LuaFunction);
					this.m_remove_EventOnAddAction`1_hotfix = (luaObj.RawGet("remove_EventOnAdd") as LuaFunction);
					this.m_add_EventOnKickFromGroupAction`1_hotfix = (luaObj.RawGet("add_EventOnKickFromGroup") as LuaFunction);
					this.m_remove_EventOnKickFromGroupAction`1_hotfix = (luaObj.RawGet("remove_EventOnKickFromGroup") as LuaFunction);
					this.m_add_EventOnUnblockAction`1_hotfix = (luaObj.RawGet("add_EventOnUnblock") as LuaFunction);
					this.m_remove_EventOnUnblockAction`1_hotfix = (luaObj.RawGet("remove_EventOnUnblock") as LuaFunction);
					this.m_add_EventOnChatAction`1_hotfix = (luaObj.RawGet("add_EventOnChat") as LuaFunction);
					this.m_remove_EventOnChatAction`1_hotfix = (luaObj.RawGet("remove_EventOnChat") as LuaFunction);
					this.m_add_EventOnSendFriendShipPointsAction`1_hotfix = (luaObj.RawGet("add_EventOnSendFriendShipPoints") as LuaFunction);
					this.m_remove_EventOnSendFriendShipPointsAction`1_hotfix = (luaObj.RawGet("remove_EventOnSendFriendShipPoints") as LuaFunction);
					this.m_add_EventOnGetFriendShipPointsAction`1_hotfix = (luaObj.RawGet("add_EventOnGetFriendShipPoints") as LuaFunction);
					this.m_remove_EventOnGetFriendShipPointsAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetFriendShipPoints") as LuaFunction);
					this.m_add_EventOnFriendShipPointsDoneAction`1_hotfix = (luaObj.RawGet("add_EventOnFriendShipPointsDone") as LuaFunction);
					this.m_remove_EventOnFriendShipPointsDoneAction`1_hotfix = (luaObj.RawGet("remove_EventOnFriendShipPointsDone") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EB54 RID: 60244 RVA: 0x003EF84C File Offset: 0x003EDA4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendBigItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008CF1 RID: 36081
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemButton;

		// Token: 0x04008CF2 RID: 36082
		[AutoBind("./ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x04008CF3 RID: 36083
		[AutoBind("./ButtonGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_buttonGroupUIStateController;

		// Token: 0x04008CF4 RID: 36084
		[AutoBind("./StateGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_friendOnlineUIStateController;

		// Token: 0x04008CF5 RID: 36085
		[AutoBind("./PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_friendIconImage;

		// Token: 0x04008CF6 RID: 36086
		[AutoBind("./PlayerIconImageGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_friendIconGreyImage;

		// Token: 0x04008CF7 RID: 36087
		[AutoBind("./HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_friendHeadFrameTransform;

		// Token: 0x04008CF8 RID: 36088
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendNameText;

		// Token: 0x04008CF9 RID: 36089
		[AutoBind("./LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendLevelText;

		// Token: 0x04008CFA RID: 36090
		[AutoBind("./ServerText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendServerText;

		// Token: 0x04008CFB RID: 36091
		[AutoBind("./StateGroup/OnLineText2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendOnlineLongText;

		// Token: 0x04008CFC RID: 36092
		[AutoBind("./ButtonGroup/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addButton;

		// Token: 0x04008CFD RID: 36093
		[AutoBind("./ButtonGroup/UnblockButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unblockButton;

		// Token: 0x04008CFE RID: 36094
		[AutoBind("./ButtonGroup/DeleteButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_kickButton;

		// Token: 0x04008CFF RID: 36095
		[AutoBind("./ButtonGroup/BigChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bigChatButton;

		// Token: 0x04008D00 RID: 36096
		[AutoBind("./ButtonGroup/SendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sendButton;

		// Token: 0x04008D01 RID: 36097
		[AutoBind("./ButtonGroup/GetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getButton;

		// Token: 0x04008D02 RID: 36098
		[AutoBind("./ButtonGroup/DoneButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_doneButton;

		// Token: 0x04008D03 RID: 36099
		private string m_userID;

		// Token: 0x04008D04 RID: 36100
		private UserSummary m_userSummy;

		// Token: 0x04008D05 RID: 36101
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04008D06 RID: 36102
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04008D07 RID: 36103
		[DoNotToLua]
		private FriendBigItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008D08 RID: 36104
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008D09 RID: 36105
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008D0A RID: 36106
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008D0B RID: 36107
		private LuaFunction m_SetFriendInfoUserSummaryFriendInfoTypeBoolean_hotfix;

		// Token: 0x04008D0C RID: 36108
		private LuaFunction m_GetServerNameString_hotfix;

		// Token: 0x04008D0D RID: 36109
		private LuaFunction m_GetUserID_hotfix;

		// Token: 0x04008D0E RID: 36110
		private LuaFunction m_GetUserSummy_hotfix;

		// Token: 0x04008D0F RID: 36111
		private LuaFunction m_GetSimpleInfoPostionType_hotfix;

		// Token: 0x04008D10 RID: 36112
		private LuaFunction m_GetPlayerSimpleInfoPos_hotfix;

		// Token: 0x04008D11 RID: 36113
		private LuaFunction m_OnItemButtonClick_hotfix;

		// Token: 0x04008D12 RID: 36114
		private LuaFunction m_OnAddButtonClick_hotfix;

		// Token: 0x04008D13 RID: 36115
		private LuaFunction m_OnKickButtonClick_hotfix;

		// Token: 0x04008D14 RID: 36116
		private LuaFunction m_OnUnblockButtonClick_hotfix;

		// Token: 0x04008D15 RID: 36117
		private LuaFunction m_OnChatButtonClick_hotfix;

		// Token: 0x04008D16 RID: 36118
		private LuaFunction m_OnSendButtonClick_hotfix;

		// Token: 0x04008D17 RID: 36119
		private LuaFunction m_OnGetButtonClick_hotfix;

		// Token: 0x04008D18 RID: 36120
		private LuaFunction m_OnDoneButtonClick_hotfix;

		// Token: 0x04008D19 RID: 36121
		private LuaFunction m_add_EventOnShowPlayerSimpleInfoAction;

		// Token: 0x04008D1A RID: 36122
		private LuaFunction m_remove_EventOnShowPlayerSimpleInfoAction;

		// Token: 0x04008D1B RID: 36123
		private LuaFunction m_add_EventOnAddAction;

		// Token: 0x04008D1C RID: 36124
		private LuaFunction m_remove_EventOnAddAction;

		// Token: 0x04008D1D RID: 36125
		private LuaFunction m_add_EventOnKickFromGroupAction;

		// Token: 0x04008D1E RID: 36126
		private LuaFunction m_remove_EventOnKickFromGroupAction;

		// Token: 0x04008D1F RID: 36127
		private LuaFunction m_add_EventOnUnblockAction;

		// Token: 0x04008D20 RID: 36128
		private LuaFunction m_remove_EventOnUnblockAction;

		// Token: 0x04008D21 RID: 36129
		private LuaFunction m_add_EventOnChatAction;

		// Token: 0x04008D22 RID: 36130
		private LuaFunction m_remove_EventOnChatAction;

		// Token: 0x04008D23 RID: 36131
		private LuaFunction m_add_EventOnSendFriendShipPointsAction;

		// Token: 0x04008D24 RID: 36132
		private LuaFunction m_remove_EventOnSendFriendShipPointsAction;

		// Token: 0x04008D25 RID: 36133
		private LuaFunction m_add_EventOnGetFriendShipPointsAction;

		// Token: 0x04008D26 RID: 36134
		private LuaFunction m_remove_EventOnGetFriendShipPointsAction;

		// Token: 0x04008D27 RID: 36135
		private LuaFunction m_add_EventOnFriendShipPointsDoneAction;

		// Token: 0x04008D28 RID: 36136
		private LuaFunction m_remove_EventOnFriendShipPointsDoneAction;

		// Token: 0x02000CB5 RID: 3253
		public new class LuaExportHelper
		{
			// Token: 0x0600EB55 RID: 60245 RVA: 0x003EF8B4 File Offset: 0x003EDAB4
			public LuaExportHelper(FriendBigItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EB56 RID: 60246 RVA: 0x003EF8C4 File Offset: 0x003EDAC4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EB57 RID: 60247 RVA: 0x003EF8D4 File Offset: 0x003EDAD4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EB58 RID: 60248 RVA: 0x003EF8E4 File Offset: 0x003EDAE4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EB59 RID: 60249 RVA: 0x003EF8F4 File Offset: 0x003EDAF4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EB5A RID: 60250 RVA: 0x003EF90C File Offset: 0x003EDB0C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EB5B RID: 60251 RVA: 0x003EF91C File Offset: 0x003EDB1C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EB5C RID: 60252 RVA: 0x003EF92C File Offset: 0x003EDB2C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EB5D RID: 60253 RVA: 0x003EF93C File Offset: 0x003EDB3C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EB5E RID: 60254 RVA: 0x003EF94C File Offset: 0x003EDB4C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EB5F RID: 60255 RVA: 0x003EF95C File Offset: 0x003EDB5C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EB60 RID: 60256 RVA: 0x003EF96C File Offset: 0x003EDB6C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EB61 RID: 60257 RVA: 0x003EF97C File Offset: 0x003EDB7C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EB62 RID: 60258 RVA: 0x003EF98C File Offset: 0x003EDB8C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EB63 RID: 60259 RVA: 0x003EF99C File Offset: 0x003EDB9C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EB64 RID: 60260 RVA: 0x003EF9AC File Offset: 0x003EDBAC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600EB65 RID: 60261 RVA: 0x003EF9BC File Offset: 0x003EDBBC
			public void __callDele_EventOnShowPlayerSimpleInfo(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnShowPlayerSimpleInfo(obj);
			}

			// Token: 0x0600EB66 RID: 60262 RVA: 0x003EF9CC File Offset: 0x003EDBCC
			public void __clearDele_EventOnShowPlayerSimpleInfo(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnShowPlayerSimpleInfo(obj);
			}

			// Token: 0x0600EB67 RID: 60263 RVA: 0x003EF9DC File Offset: 0x003EDBDC
			public void __callDele_EventOnAdd(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnAdd(obj);
			}

			// Token: 0x0600EB68 RID: 60264 RVA: 0x003EF9EC File Offset: 0x003EDBEC
			public void __clearDele_EventOnAdd(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnAdd(obj);
			}

			// Token: 0x0600EB69 RID: 60265 RVA: 0x003EF9FC File Offset: 0x003EDBFC
			public void __callDele_EventOnKickFromGroup(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnKickFromGroup(obj);
			}

			// Token: 0x0600EB6A RID: 60266 RVA: 0x003EFA0C File Offset: 0x003EDC0C
			public void __clearDele_EventOnKickFromGroup(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnKickFromGroup(obj);
			}

			// Token: 0x0600EB6B RID: 60267 RVA: 0x003EFA1C File Offset: 0x003EDC1C
			public void __callDele_EventOnUnblock(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnUnblock(obj);
			}

			// Token: 0x0600EB6C RID: 60268 RVA: 0x003EFA2C File Offset: 0x003EDC2C
			public void __clearDele_EventOnUnblock(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnUnblock(obj);
			}

			// Token: 0x0600EB6D RID: 60269 RVA: 0x003EFA3C File Offset: 0x003EDC3C
			public void __callDele_EventOnChat(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnChat(obj);
			}

			// Token: 0x0600EB6E RID: 60270 RVA: 0x003EFA4C File Offset: 0x003EDC4C
			public void __clearDele_EventOnChat(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnChat(obj);
			}

			// Token: 0x0600EB6F RID: 60271 RVA: 0x003EFA5C File Offset: 0x003EDC5C
			public void __callDele_EventOnSendFriendShipPoints(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnSendFriendShipPoints(obj);
			}

			// Token: 0x0600EB70 RID: 60272 RVA: 0x003EFA6C File Offset: 0x003EDC6C
			public void __clearDele_EventOnSendFriendShipPoints(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnSendFriendShipPoints(obj);
			}

			// Token: 0x0600EB71 RID: 60273 RVA: 0x003EFA7C File Offset: 0x003EDC7C
			public void __callDele_EventOnGetFriendShipPoints(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnGetFriendShipPoints(obj);
			}

			// Token: 0x0600EB72 RID: 60274 RVA: 0x003EFA8C File Offset: 0x003EDC8C
			public void __clearDele_EventOnGetFriendShipPoints(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnGetFriendShipPoints(obj);
			}

			// Token: 0x0600EB73 RID: 60275 RVA: 0x003EFA9C File Offset: 0x003EDC9C
			public void __callDele_EventOnFriendShipPointsDone(FriendBigItemUIController obj)
			{
				this.m_owner.__callDele_EventOnFriendShipPointsDone(obj);
			}

			// Token: 0x0600EB74 RID: 60276 RVA: 0x003EFAAC File Offset: 0x003EDCAC
			public void __clearDele_EventOnFriendShipPointsDone(FriendBigItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnFriendShipPointsDone(obj);
			}

			// Token: 0x17002D79 RID: 11641
			// (get) Token: 0x0600EB75 RID: 60277 RVA: 0x003EFABC File Offset: 0x003EDCBC
			// (set) Token: 0x0600EB76 RID: 60278 RVA: 0x003EFACC File Offset: 0x003EDCCC
			public Button m_itemButton
			{
				get
				{
					return this.m_owner.m_itemButton;
				}
				set
				{
					this.m_owner.m_itemButton = value;
				}
			}

			// Token: 0x17002D7A RID: 11642
			// (get) Token: 0x0600EB77 RID: 60279 RVA: 0x003EFADC File Offset: 0x003EDCDC
			// (set) Token: 0x0600EB78 RID: 60280 RVA: 0x003EFAEC File Offset: 0x003EDCEC
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

			// Token: 0x17002D7B RID: 11643
			// (get) Token: 0x0600EB79 RID: 60281 RVA: 0x003EFAFC File Offset: 0x003EDCFC
			// (set) Token: 0x0600EB7A RID: 60282 RVA: 0x003EFB0C File Offset: 0x003EDD0C
			public CommonUIStateController m_buttonGroupUIStateController
			{
				get
				{
					return this.m_owner.m_buttonGroupUIStateController;
				}
				set
				{
					this.m_owner.m_buttonGroupUIStateController = value;
				}
			}

			// Token: 0x17002D7C RID: 11644
			// (get) Token: 0x0600EB7B RID: 60283 RVA: 0x003EFB1C File Offset: 0x003EDD1C
			// (set) Token: 0x0600EB7C RID: 60284 RVA: 0x003EFB2C File Offset: 0x003EDD2C
			public CommonUIStateController m_friendOnlineUIStateController
			{
				get
				{
					return this.m_owner.m_friendOnlineUIStateController;
				}
				set
				{
					this.m_owner.m_friendOnlineUIStateController = value;
				}
			}

			// Token: 0x17002D7D RID: 11645
			// (get) Token: 0x0600EB7D RID: 60285 RVA: 0x003EFB3C File Offset: 0x003EDD3C
			// (set) Token: 0x0600EB7E RID: 60286 RVA: 0x003EFB4C File Offset: 0x003EDD4C
			public Image m_friendIconImage
			{
				get
				{
					return this.m_owner.m_friendIconImage;
				}
				set
				{
					this.m_owner.m_friendIconImage = value;
				}
			}

			// Token: 0x17002D7E RID: 11646
			// (get) Token: 0x0600EB7F RID: 60287 RVA: 0x003EFB5C File Offset: 0x003EDD5C
			// (set) Token: 0x0600EB80 RID: 60288 RVA: 0x003EFB6C File Offset: 0x003EDD6C
			public Image m_friendIconGreyImage
			{
				get
				{
					return this.m_owner.m_friendIconGreyImage;
				}
				set
				{
					this.m_owner.m_friendIconGreyImage = value;
				}
			}

			// Token: 0x17002D7F RID: 11647
			// (get) Token: 0x0600EB81 RID: 60289 RVA: 0x003EFB7C File Offset: 0x003EDD7C
			// (set) Token: 0x0600EB82 RID: 60290 RVA: 0x003EFB8C File Offset: 0x003EDD8C
			public Transform m_friendHeadFrameTransform
			{
				get
				{
					return this.m_owner.m_friendHeadFrameTransform;
				}
				set
				{
					this.m_owner.m_friendHeadFrameTransform = value;
				}
			}

			// Token: 0x17002D80 RID: 11648
			// (get) Token: 0x0600EB83 RID: 60291 RVA: 0x003EFB9C File Offset: 0x003EDD9C
			// (set) Token: 0x0600EB84 RID: 60292 RVA: 0x003EFBAC File Offset: 0x003EDDAC
			public Text m_friendNameText
			{
				get
				{
					return this.m_owner.m_friendNameText;
				}
				set
				{
					this.m_owner.m_friendNameText = value;
				}
			}

			// Token: 0x17002D81 RID: 11649
			// (get) Token: 0x0600EB85 RID: 60293 RVA: 0x003EFBBC File Offset: 0x003EDDBC
			// (set) Token: 0x0600EB86 RID: 60294 RVA: 0x003EFBCC File Offset: 0x003EDDCC
			public Text m_friendLevelText
			{
				get
				{
					return this.m_owner.m_friendLevelText;
				}
				set
				{
					this.m_owner.m_friendLevelText = value;
				}
			}

			// Token: 0x17002D82 RID: 11650
			// (get) Token: 0x0600EB87 RID: 60295 RVA: 0x003EFBDC File Offset: 0x003EDDDC
			// (set) Token: 0x0600EB88 RID: 60296 RVA: 0x003EFBEC File Offset: 0x003EDDEC
			public Text m_friendServerText
			{
				get
				{
					return this.m_owner.m_friendServerText;
				}
				set
				{
					this.m_owner.m_friendServerText = value;
				}
			}

			// Token: 0x17002D83 RID: 11651
			// (get) Token: 0x0600EB89 RID: 60297 RVA: 0x003EFBFC File Offset: 0x003EDDFC
			// (set) Token: 0x0600EB8A RID: 60298 RVA: 0x003EFC0C File Offset: 0x003EDE0C
			public Text m_friendOnlineLongText
			{
				get
				{
					return this.m_owner.m_friendOnlineLongText;
				}
				set
				{
					this.m_owner.m_friendOnlineLongText = value;
				}
			}

			// Token: 0x17002D84 RID: 11652
			// (get) Token: 0x0600EB8B RID: 60299 RVA: 0x003EFC1C File Offset: 0x003EDE1C
			// (set) Token: 0x0600EB8C RID: 60300 RVA: 0x003EFC2C File Offset: 0x003EDE2C
			public Button m_addButton
			{
				get
				{
					return this.m_owner.m_addButton;
				}
				set
				{
					this.m_owner.m_addButton = value;
				}
			}

			// Token: 0x17002D85 RID: 11653
			// (get) Token: 0x0600EB8D RID: 60301 RVA: 0x003EFC3C File Offset: 0x003EDE3C
			// (set) Token: 0x0600EB8E RID: 60302 RVA: 0x003EFC4C File Offset: 0x003EDE4C
			public Button m_unblockButton
			{
				get
				{
					return this.m_owner.m_unblockButton;
				}
				set
				{
					this.m_owner.m_unblockButton = value;
				}
			}

			// Token: 0x17002D86 RID: 11654
			// (get) Token: 0x0600EB8F RID: 60303 RVA: 0x003EFC5C File Offset: 0x003EDE5C
			// (set) Token: 0x0600EB90 RID: 60304 RVA: 0x003EFC6C File Offset: 0x003EDE6C
			public Button m_kickButton
			{
				get
				{
					return this.m_owner.m_kickButton;
				}
				set
				{
					this.m_owner.m_kickButton = value;
				}
			}

			// Token: 0x17002D87 RID: 11655
			// (get) Token: 0x0600EB91 RID: 60305 RVA: 0x003EFC7C File Offset: 0x003EDE7C
			// (set) Token: 0x0600EB92 RID: 60306 RVA: 0x003EFC8C File Offset: 0x003EDE8C
			public Button m_bigChatButton
			{
				get
				{
					return this.m_owner.m_bigChatButton;
				}
				set
				{
					this.m_owner.m_bigChatButton = value;
				}
			}

			// Token: 0x17002D88 RID: 11656
			// (get) Token: 0x0600EB93 RID: 60307 RVA: 0x003EFC9C File Offset: 0x003EDE9C
			// (set) Token: 0x0600EB94 RID: 60308 RVA: 0x003EFCAC File Offset: 0x003EDEAC
			public Button m_sendButton
			{
				get
				{
					return this.m_owner.m_sendButton;
				}
				set
				{
					this.m_owner.m_sendButton = value;
				}
			}

			// Token: 0x17002D89 RID: 11657
			// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x003EFCBC File Offset: 0x003EDEBC
			// (set) Token: 0x0600EB96 RID: 60310 RVA: 0x003EFCCC File Offset: 0x003EDECC
			public Button m_getButton
			{
				get
				{
					return this.m_owner.m_getButton;
				}
				set
				{
					this.m_owner.m_getButton = value;
				}
			}

			// Token: 0x17002D8A RID: 11658
			// (get) Token: 0x0600EB97 RID: 60311 RVA: 0x003EFCDC File Offset: 0x003EDEDC
			// (set) Token: 0x0600EB98 RID: 60312 RVA: 0x003EFCEC File Offset: 0x003EDEEC
			public Button m_doneButton
			{
				get
				{
					return this.m_owner.m_doneButton;
				}
				set
				{
					this.m_owner.m_doneButton = value;
				}
			}

			// Token: 0x17002D8B RID: 11659
			// (get) Token: 0x0600EB99 RID: 60313 RVA: 0x003EFCFC File Offset: 0x003EDEFC
			// (set) Token: 0x0600EB9A RID: 60314 RVA: 0x003EFD0C File Offset: 0x003EDF0C
			public string m_userID
			{
				get
				{
					return this.m_owner.m_userID;
				}
				set
				{
					this.m_owner.m_userID = value;
				}
			}

			// Token: 0x17002D8C RID: 11660
			// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x003EFD1C File Offset: 0x003EDF1C
			// (set) Token: 0x0600EB9C RID: 60316 RVA: 0x003EFD2C File Offset: 0x003EDF2C
			public UserSummary m_userSummy
			{
				get
				{
					return this.m_owner.m_userSummy;
				}
				set
				{
					this.m_owner.m_userSummy = value;
				}
			}

			// Token: 0x17002D8D RID: 11661
			// (get) Token: 0x0600EB9D RID: 60317 RVA: 0x003EFD3C File Offset: 0x003EDF3C
			// (set) Token: 0x0600EB9E RID: 60318 RVA: 0x003EFD4C File Offset: 0x003EDF4C
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

			// Token: 0x17002D8E RID: 11662
			// (get) Token: 0x0600EB9F RID: 60319 RVA: 0x003EFD5C File Offset: 0x003EDF5C
			// (set) Token: 0x0600EBA0 RID: 60320 RVA: 0x003EFD6C File Offset: 0x003EDF6C
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x0600EBA1 RID: 60321 RVA: 0x003EFD7C File Offset: 0x003EDF7C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EBA2 RID: 60322 RVA: 0x003EFD8C File Offset: 0x003EDF8C
			public string GetServerName(string userId)
			{
				return this.m_owner.GetServerName(userId);
			}

			// Token: 0x0600EBA3 RID: 60323 RVA: 0x003EFD9C File Offset: 0x003EDF9C
			public void OnItemButtonClick()
			{
				this.m_owner.OnItemButtonClick();
			}

			// Token: 0x0600EBA4 RID: 60324 RVA: 0x003EFDAC File Offset: 0x003EDFAC
			public void OnAddButtonClick()
			{
				this.m_owner.OnAddButtonClick();
			}

			// Token: 0x0600EBA5 RID: 60325 RVA: 0x003EFDBC File Offset: 0x003EDFBC
			public void OnKickButtonClick()
			{
				this.m_owner.OnKickButtonClick();
			}

			// Token: 0x0600EBA6 RID: 60326 RVA: 0x003EFDCC File Offset: 0x003EDFCC
			public void OnUnblockButtonClick()
			{
				this.m_owner.OnUnblockButtonClick();
			}

			// Token: 0x0600EBA7 RID: 60327 RVA: 0x003EFDDC File Offset: 0x003EDFDC
			public void OnChatButtonClick()
			{
				this.m_owner.OnChatButtonClick();
			}

			// Token: 0x0600EBA8 RID: 60328 RVA: 0x003EFDEC File Offset: 0x003EDFEC
			public void OnSendButtonClick()
			{
				this.m_owner.OnSendButtonClick();
			}

			// Token: 0x0600EBA9 RID: 60329 RVA: 0x003EFDFC File Offset: 0x003EDFFC
			public void OnGetButtonClick()
			{
				this.m_owner.OnGetButtonClick();
			}

			// Token: 0x0600EBAA RID: 60330 RVA: 0x003EFE0C File Offset: 0x003EE00C
			public void OnDoneButtonClick()
			{
				this.m_owner.OnDoneButtonClick();
			}

			// Token: 0x04008D29 RID: 36137
			private FriendBigItemUIController m_owner;
		}
	}
}
