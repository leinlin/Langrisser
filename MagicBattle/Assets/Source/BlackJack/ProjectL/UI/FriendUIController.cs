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
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CAF RID: 3247
	[HotFix]
	public class FriendUIController : UIControllerBase
	{
		// Token: 0x0600E935 RID: 59701 RVA: 0x003E6248 File Offset: 0x003E4448
		private FriendUIController()
		{
		}

		// Token: 0x0600E936 RID: 59702 RVA: 0x003E62D4 File Offset: 0x003E44D4
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
			this.m_getAllFriendshipPointButton.onClick.AddListener(new UnityAction(this.OnGetAllFriendshipPointButtonClick));
			this.m_sendAllFriendshipPointButton.onClick.AddListener(new UnityAction(this.OnSendAllFriendshipPointButtonClick));
			this.m_friendToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnFriendToggle));
			this.m_acrossServerToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnAcrossServerToggle));
			this.m_recentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRecentToggle));
			this.m_groupToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnGroupToggle));
			this.m_shieldButton.onClick.AddListener(new UnityAction(this.OnShieldButtonClick));
			this.m_shieldPanelCloseButton.onClick.AddListener(new UnityAction(this.OnShieldPanelCloseButtonClick));
			this.m_shieldPanelBackgroundButton.onClick.AddListener(new UnityAction(this.OnShieldPanelCloseButtonClick));
			this.m_addFriendButton.onClick.AddListener(new UnityAction(this.OnAddFriendButtonClick));
			this.m_addFriendPanelCloseButton.onClick.AddListener(new UnityAction(this.OnAddFriendPanelCloseButtonClick));
			this.m_addFriendPanelBackgroundButton.onClick.AddListener(new UnityAction(this.OnAddFriendPanelCloseButtonClick));
			this.m_addFriendPanelSearchButton.onClick.AddListener(new UnityAction(this.OnAddFriendPanelSearchButtonClick));
			this.m_addFriendPanelChangeButton.onClick.AddListener(new UnityAction(this.OnAddFriendPanelChangeRecommendFriendButtonClick));
			this.m_addFriendPanelRefuseAllButton.onClick.AddListener(new UnityAction(this.OnAddFriendPanelRefuseAllButtonClick));
			this.m_addFriendPanelSelectServerButton.onClick.AddListener(new UnityAction(this.OnSelectServerButtonClick));
			this.m_serverListPanelBGButton.onClick.AddListener(new UnityAction(this.OnServerListPanelBGButtonClick));
			this.m_watchGroupStaffPanelCloseButton.onClick.AddListener(new UnityAction(this.OnWatchGroupStaffPanelCloseButtonClick));
			this.m_watchGroupStaffPanelBackgroundButton.onClick.AddListener(new UnityAction(this.OnWatchGroupStaffPanelCloseButtonClick));
			this.m_watchGroupStaffPanelChangeGroupNameButton.onClick.AddListener(new UnityAction(this.OnWatchGroupStaffPanelChangeNameButtonClick));
			this.m_watchGroupStaffPanelQuitGroupButton.onClick.AddListener(new UnityAction(this.OnQuitGroupButtonClick));
			this.m_changeGroupNameBackgroundButton.onClick.AddListener(new UnityAction(this.OnWatchGroupStaffPanelChangeNamePanelBGButtonClick));
			this.m_changeGroupNameConfirmButton.onClick.AddListener(new UnityAction(this.OnWatchGroupStaffPanelChangeNameConfirmButtonClick));
			this.m_createNewGroupButton.onClick.AddListener(new UnityAction(this.OnCreateNewGroupButtonClick));
			this.m_watchGroupStaffPanelInviteFriendButton.onClick.AddListener(new UnityAction(this.OnInviteFriendToGroupButtonClick));
			this.m_inviteFriendToGroupPanelCancelButton.onClick.AddListener(new UnityAction(this.InviteFriendToGoupPanelClose));
			this.m_inviteFriendToGroupPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnInviteFriendToGoupPanelConfirmButtonClick));
			this.m_inviteFriendToGroupPanelBackgroundButton.onClick.AddListener(new UnityAction(this.InviteFriendToGoupPanelClose));
			this.m_inviteFriendToGroupPanelServerFriendToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnInviteFriendToGroupPanelServerFriendToggle));
			this.m_inviteFriendToGroupPanelFriendToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnInviteFriendToGroupPanelFriendToggle));
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600E937 RID: 59703 RVA: 0x003E66C8 File Offset: 0x003E48C8
		public void SetFriendPanel(List<UserSummary> userList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFriendPanelList`1_hotfix != null)
			{
				this.m_SetFriendPanelList`1_hotfix.call(new object[]
				{
					this,
					userList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelUIStateController.SetToUIState("FriendServerNearly", false, true);
			this.m_friendTypeCount.text = userList.Count + "/" + (GameManager.Instance.ConfigDataLoader as IConfigDataLoader).ConfigableConstId_MaxDomesticFriends;
			this.m_friendCountUIStateController.SetToUIState("Friend", false, true);
			this.SetBasicBigFriendInfo(this.m_friendScrollViewContent, userList, FriendInfoType.Friend, false);
			this.SetSendAllFriendshipPointButtonState();
			this.SetGetAllFriendshipPointButtonState();
		}

		// Token: 0x0600E938 RID: 59704 RVA: 0x003E67B0 File Offset: 0x003E49B0
		public void SetAcrossServerFriendPanel(List<UserSummary> userList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAcrossServerFriendPanelList`1_hotfix != null)
			{
				this.m_SetAcrossServerFriendPanelList`1_hotfix.call(new object[]
				{
					this,
					userList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelUIStateController.SetToUIState("FriendServerNearly", false, true);
			this.m_friendTypeCount.text = userList.Count + "/" + (GameManager.Instance.ConfigDataLoader as IConfigDataLoader).ConfigableConstId_MaxForeignFriends;
			this.m_friendCountUIStateController.SetToUIState("AcrossServer", false, true);
			this.SetBasicBigFriendInfo(this.m_friendScrollViewContent, userList, FriendInfoType.AcrossServerFriend, false);
		}

		// Token: 0x0600E939 RID: 59705 RVA: 0x003E688C File Offset: 0x003E4A8C
		public void SetRecentPanel(List<UserSummary> userList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecentPanelList`1_hotfix != null)
			{
				this.m_SetRecentPanelList`1_hotfix.call(new object[]
				{
					this,
					userList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelUIStateController.SetToUIState("FriendServerNearly", false, true);
			this.m_friendCountUIStateController.SetToUIState("None", false, true);
			this.SetBasicBigFriendInfo(this.m_friendScrollViewContent, userList, FriendInfoType.Recent, false);
		}

		// Token: 0x0600E93A RID: 59706 RVA: 0x003E6930 File Offset: 0x003E4B30
		public void SetGroupPanel(List<ProChatGroupCompactInfo> chatGroupList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGroupPanelList`1_hotfix != null)
			{
				this.m_SetGroupPanelList`1_hotfix.call(new object[]
				{
					this,
					chatGroupList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelUIStateController.SetToUIState("Group", false, true);
			this.m_friendTypeCount.text = chatGroupList.Count + "/" + (GameManager.Instance.ConfigDataLoader as IConfigDataLoader).ConfigableConstId_MaxGroupsPerUser;
			this.m_friendCountUIStateController.SetToUIState("Group", false, true);
			int childCount = this.m_groupScrollViewContent.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				this.m_groupScrollViewContent.transform.GetChild(i).gameObject.SetActive(false);
			}
			int count = chatGroupList.Count;
			for (int j = 0; j < count; j++)
			{
				FriendGroupUIController friendGroupUIController;
				if (j >= childCount)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_groupItemPrefab);
					friendGroupUIController = GameObjectUtility.AddControllerToGameObject<FriendGroupUIController>(gameObject);
					friendGroupUIController.EventOnChatButtonClick += this.OnGroupChatButtonClick;
					friendGroupUIController.EventOnWatchGroupStaffButtonClick += this.OnWatchGroupStaffButtonClick;
					gameObject.transform.SetParent(this.m_groupScrollViewContent.transform, false);
				}
				else
				{
					friendGroupUIController = this.m_groupScrollViewContent.transform.GetChild(j).GetComponent<FriendGroupUIController>();
				}
				friendGroupUIController.SetGroupInfo(chatGroupList[j]);
				friendGroupUIController.gameObject.SetActive(true);
			}
		}

		// Token: 0x0600E93B RID: 59707 RVA: 0x003E6AEC File Offset: 0x003E4CEC
		private void SetAddFriendPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAddFriendPanel_hotfix != null)
			{
				this.m_SetAddFriendPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_addFriendPanelInputText.text = string.Empty;
			this.m_currentServerID = LoginUITask.GetCurrentSelectServerInfo().m_bornChannelId;
			this.m_addFriendPanelServerNameText.text = LoginUITask.GetCurrentSelectServerInfo().m_name;
		}

		// Token: 0x0600E93C RID: 59708 RVA: 0x003E6B84 File Offset: 0x003E4D84
		public void SetFirstToggleOn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFirstToggleOn_hotfix != null)
			{
				this.m_SetFirstToggleOn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendToggle.isOn = true;
		}

		// Token: 0x0600E93D RID: 59709 RVA: 0x003E6BF0 File Offset: 0x003E4DF0
		public void SetPanelScrollViewReset()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPanelScrollViewReset_hotfix != null)
			{
				this.m_SetPanelScrollViewReset_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
			this.m_groupScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x0600E93E RID: 59710 RVA: 0x003E6C7C File Offset: 0x003E4E7C
		public void IsAddFriendRedMarkShow(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAddFriendRedMarkShowBoolean_hotfix != null)
			{
				this.m_IsAddFriendRedMarkShowBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_addFriendRedMark.SetActive(isShow);
		}

		// Token: 0x0600E93F RID: 59711 RVA: 0x003E6CF8 File Offset: 0x003E4EF8
		public void ShowFriendShipPointTip(string s)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFriendShipPointTipString_hotfix != null)
			{
				this.m_ShowFriendShipPointTipString_hotfix.call(new object[]
				{
					this,
					s
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendShipPointTipText.text = s;
			UIUtility.SetUIStateOpen(this.m_friendShipPointTipStateCtrl, "Show", null, false, true);
		}

		// Token: 0x0600E940 RID: 59712 RVA: 0x003E6D88 File Offset: 0x003E4F88
		public void SetShieldPanel(List<UserSummary> userSummy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetShieldPanelList`1_hotfix != null)
			{
				this.m_SetShieldPanelList`1_hotfix.call(new object[]
				{
					this,
					userSummy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_shieldPanelShieldCount.text = userSummy.Count + "/" + (GameManager.Instance.ConfigDataLoader as IConfigDataLoader).ConfigableConstId_MaxBlacklist;
			this.SetBasicBigFriendInfo(this.m_shieldPanelScrollViewContent, userSummy, FriendInfoType.Shield, false);
			this.m_shieldPanelScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x0600E941 RID: 59713 RVA: 0x003E6E58 File Offset: 0x003E5058
		public void SetFindFriendList(List<UserSummary> userList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFindFriendListList`1_hotfix != null)
			{
				this.m_SetFindFriendListList`1_hotfix.call(new object[]
				{
					this,
					userList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFindFriend = true;
			this.m_isRecommendFriend = false;
			this.m_addFriendPanelFindFriendTextGameObject.SetActive(true);
			this.m_addFriendPanelRecommendTextGameObject.SetActive(false);
			this.m_addFriendPanelChangeButton.gameObject.SetActive(!this.m_isFindFriend);
			if (userList.Count > 0)
			{
				this.m_addFriendPanelNotFindFriendGameObject.SetActive(false);
				this.SetBasicSmallFriendInfo(this.m_addFriendPanelRecommendScrollViewContent, userList, FriendInfoType.AddFriend);
				this.m_addFriendPanelRecommendScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
			}
			else
			{
				this.m_addFriendPanelNotFindFriendGameObject.SetActive(true);
				this.SetBasicSmallFriendInfo(this.m_addFriendPanelRecommendScrollViewContent, userList, FriendInfoType.AddFriend);
				this.m_addFriendPanelRecommendScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
			}
		}

		// Token: 0x0600E942 RID: 59714 RVA: 0x003E6F78 File Offset: 0x003E5178
		public void SetRecommendFriendsList(List<UserSummary> userList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecommendFriendsListList`1_hotfix != null)
			{
				this.m_SetRecommendFriendsListList`1_hotfix.call(new object[]
				{
					this,
					userList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFindFriend = false;
			this.m_isRecommendFriend = true;
			this.m_addFriendPanelNotFindFriendGameObject.SetActive(false);
			this.m_addFriendPanelChangeButton.gameObject.SetActive(this.m_isRecommendFriend);
			if (userList == null)
			{
				return;
			}
			this.m_recommendFriendList.Clear();
			this.m_recommendFriendList.AddRange(userList);
			this.m_addFriendPanelFindFriendTextGameObject.SetActive(false);
			this.m_addFriendPanelRecommendTextGameObject.SetActive(true);
			this.SetBasicSmallFriendInfo(this.m_addFriendPanelRecommendScrollViewContent, userList, FriendInfoType.RecommendFriend);
			this.m_addFriendPanelRecommendScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x0600E943 RID: 59715 RVA: 0x003E7074 File Offset: 0x003E5274
		public void SetApplyFriendsList(List<UserSummary> userList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetApplyFriendsListList`1_hotfix != null)
			{
				this.m_SetApplyFriendsListList`1_hotfix.call(new object[]
				{
					this,
					userList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (userList == null)
			{
				return;
			}
			this.m_applyFriendList.Clear();
			this.m_applyFriendList.AddRange(userList);
			this.SetBasicSmallFriendInfo(this.m_addFriendPanelApplyScrollViewContent, userList, FriendInfoType.FriendApply);
			this.m_addFriendPanelApplyScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x0600E944 RID: 59716 RVA: 0x003E7128 File Offset: 0x003E5328
		public void SetInviteFriendToGroupPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInviteFriendToGroupPanel_hotfix != null)
			{
				this.m_SetInviteFriendToGroupPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_inviteToGroupList.Clear();
			this.m_inviteFriendToGroupPanelFriendToggle.isOn = true;
			this.m_inviteFriendToGroupPanelServerFriendToggle.isOn = false;
			this.SetInviteFriendToGroupList();
			this.m_inviteFriendToGroupPanelCountText.text = "0";
		}

		// Token: 0x0600E945 RID: 59717 RVA: 0x003E71C4 File Offset: 0x003E53C4
		private void SetInviteFriendToGroupList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInviteFriendToGroupList_hotfix != null)
			{
				this.m_SetInviteFriendToGroupList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetBasicSmallFriendInfo(this.m_inviteFriendToGroupPanelScrollViewContent, this.m_playerContext.GetFriendList(), FriendInfoType.FriendInviteToGroup);
			this.m_inviteFriendToGroupPanelScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x0600E946 RID: 59718 RVA: 0x003E7254 File Offset: 0x003E5454
		private void SetInviteAcrossServerFriendToGroupList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInviteAcrossServerFriendToGroupList_hotfix != null)
			{
				this.m_SetInviteAcrossServerFriendToGroupList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetBasicSmallFriendInfo(this.m_inviteFriendToGroupPanelScrollViewContent, this.m_playerContext.GetAcrossServerFriendList(), FriendInfoType.FriendInviteToGroup);
			this.m_inviteFriendToGroupPanelScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
		}

		// Token: 0x0600E947 RID: 59719 RVA: 0x003E72E4 File Offset: 0x003E54E4
		public void SetWatchGroupStaffPanel(ProChatGroupInfo chatGroupInfo, bool needOpenTween)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWatchGroupStaffPanelProChatGroupInfoBoolean_hotfix != null)
			{
				this.m_SetWatchGroupStaffPanelProChatGroupInfoBoolean_hotfix.call(new object[]
				{
					this,
					chatGroupInfo,
					needOpenTween
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_groupStaffList.Clear();
			for (int i = 0; i < 2; i++)
			{
				foreach (ProChatUserInfo proChatUserInfo in chatGroupInfo.Members)
				{
					bool flag = proChatUserInfo.CompactInfo.UserId == chatGroupInfo.CompactInfo.Owner.UserId;
					if (i == 0 == flag)
					{
						UserSummary userSummary = new UserSummary();
						userSummary.UserId = proChatUserInfo.CompactInfo.UserId;
						userSummary.HeadIcon = proChatUserInfo.CompactInfo.HeadIcon;
						userSummary.Level = proChatUserInfo.Level;
						userSummary.LogoutTime = new DateTime(proChatUserInfo.LogoutTime);
						userSummary.Name = proChatUserInfo.CompactInfo.Name;
						userSummary.Online = proChatUserInfo.CompactInfo.Online;
						this.m_groupStaffList.Add(userSummary);
					}
				}
			}
			bool flag2 = this.m_playerContext.IsMe(chatGroupInfo.CompactInfo.Owner.UserId);
			this.m_currentChatGroupInfo = chatGroupInfo;
			this.SetBasicBigFriendInfo(this.m_watchGroupStaffPanelScrollViewContent, this.m_groupStaffList, FriendInfoType.Group, flag2);
			this.m_watchGroupStaffPanelCountText.text = chatGroupInfo.Members.Count + "/" + (GameManager.Instance.ConfigDataLoader as IConfigDataLoader).ConfigableConstId_MaxGroupMembers;
			this.m_groupTitleName.text = chatGroupInfo.CompactInfo.ChatGroupName;
			this.m_watchGroupStaffPanelScrollView.GetComponent<ScrollRect>().normalizedPosition = Vector2.one;
			this.m_watchGroupStaffPanelChangeGroupNameButton.gameObject.SetActive(flag2);
			if (needOpenTween)
			{
				UIUtility.SetUIStateOpen(this.m_watchGroupStaffPanelUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x0600E948 RID: 59720 RVA: 0x003E753C File Offset: 0x003E573C
		private void SetBasicBigFriendInfo(GameObject parentScrollViewContent, List<UserSummary> userList, FriendInfoType friendInfoType, bool isChatGroupOwner = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBasicBigFriendInfoGameObjectList`1FriendInfoTypeBoolean_hotfix != null)
			{
				this.m_SetBasicBigFriendInfoGameObjectList`1FriendInfoTypeBoolean_hotfix.call(new object[]
				{
					this,
					parentScrollViewContent,
					userList,
					friendInfoType,
					isChatGroupOwner
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int childCount = parentScrollViewContent.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				parentScrollViewContent.transform.GetChild(i).gameObject.SetActive(false);
			}
			int count = userList.Count;
			for (int j = 0; j < count; j++)
			{
				FriendBigItemUIController friendBigItemUIController;
				if (j >= childCount)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_friendBigItemPrefab);
					friendBigItemUIController = GameObjectUtility.AddControllerToGameObject<FriendBigItemUIController>(gameObject);
					friendBigItemUIController.EventOnShowPlayerSimpleInfo += this.OnPlayerItemButtonClick;
					friendBigItemUIController.EventOnAdd += this.OnItemAddFriendButtonClick;
					friendBigItemUIController.EventOnKickFromGroup += this.OnItemKickFromGroupButtonClick;
					friendBigItemUIController.EventOnUnblock += this.OnUnblockPlayerButtonClick;
					friendBigItemUIController.EventOnChat += this.OnChatButtonClick;
					friendBigItemUIController.EventOnSendFriendShipPoints += this.OnSendFriendshipPointButtonClick;
					friendBigItemUIController.EventOnGetFriendShipPoints += this.OnGetFriendshipPointButtonClick;
					friendBigItemUIController.EventOnFriendShipPointsDone += this.OnFriendshipPointDoneButtonClick;
					gameObject.transform.SetParent(parentScrollViewContent.transform, false);
				}
				else
				{
					friendBigItemUIController = parentScrollViewContent.transform.GetChild(j).GetComponent<FriendBigItemUIController>();
				}
				friendBigItemUIController.SetFriendInfo(userList[j], friendInfoType, isChatGroupOwner);
				friendBigItemUIController.gameObject.SetActive(true);
			}
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x003E772C File Offset: 0x003E592C
		private void SetBasicSmallFriendInfo(GameObject parentScrollViewContent, List<UserSummary> userList, FriendInfoType friendInfoType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBasicSmallFriendInfoGameObjectList`1FriendInfoType_hotfix != null)
			{
				this.m_SetBasicSmallFriendInfoGameObjectList`1FriendInfoType_hotfix.call(new object[]
				{
					this,
					parentScrollViewContent,
					userList,
					friendInfoType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendUIController.<SetBasicSmallFriendInfo>c__AnonStorey0 <SetBasicSmallFriendInfo>c__AnonStorey = new FriendUIController.<SetBasicSmallFriendInfo>c__AnonStorey0();
			<SetBasicSmallFriendInfo>c__AnonStorey.userList = userList;
			int childCount = parentScrollViewContent.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				parentScrollViewContent.transform.GetChild(i).gameObject.SetActive(false);
			}
			int count = <SetBasicSmallFriendInfo>c__AnonStorey.userList.Count;
			int itemIndex;
			for (itemIndex = 0; itemIndex < count; itemIndex++)
			{
				FriendSmallItemUIController friendSmallItemUIController;
				if (itemIndex >= childCount)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_friendSmallItemPrefab);
					friendSmallItemUIController = GameObjectUtility.AddControllerToGameObject<FriendSmallItemUIController>(gameObject);
					friendSmallItemUIController.EventOnShowPlayerSimpleInfo += this.OnPlayerItemButtonClick;
					friendSmallItemUIController.EventOnAdd += this.OnItemAddFriendButtonClick;
					friendSmallItemUIController.EventOnChat += this.OnChatButtonClick;
					friendSmallItemUIController.EventOnAgree += this.OnFriendApplyAceeptButtonClick;
					friendSmallItemUIController.EventOnDisagree += this.OnFriendApplyDeclineButtonClick;
					friendSmallItemUIController.EventOnSelectToggleValueChanged += this.OnInviteFriendToGroupToggleValueChanged;
					gameObject.transform.SetParent(parentScrollViewContent.transform, false);
				}
				else
				{
					friendSmallItemUIController = parentScrollViewContent.transform.GetChild(itemIndex).GetComponent<FriendSmallItemUIController>();
				}
				friendSmallItemUIController.SetFriendInfo(<SetBasicSmallFriendInfo>c__AnonStorey.userList[itemIndex], friendInfoType);
				if (friendInfoType == FriendInfoType.FriendInviteToGroup)
				{
					friendSmallItemUIController.SetUserSelect(this.m_inviteToGroupList.Contains(<SetBasicSmallFriendInfo>c__AnonStorey.userList[itemIndex].UserId));
					friendSmallItemUIController.SetUserInGroup(!this.m_isCreateNewGroup && this.m_currentChatGroupInfo.Members.FindIndex((ProChatUserInfo f) => f.CompactInfo.UserId == <SetBasicSmallFriendInfo>c__AnonStorey.userList[itemIndex].UserId) >= 0);
				}
				friendSmallItemUIController.gameObject.SetActive(true);
			}
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x003E79A0 File Offset: 0x003E5BA0
		private void SetServerListInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetServerListInfo_hotfix != null)
			{
				this.m_SetServerListInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_serverListGroup);
			LoginUITask.ServerInfo currentSelectServerInfo = LoginUITask.GetCurrentSelectServerInfo();
			using (List<LoginUITask.ServerInfo>.Enumerator enumerator = LoginUITask.ServerList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					LoginUITask.ServerInfo serverInfo = enumerator.Current;
					FriendUIController $this = this;
					if (!(serverInfo.m_areaName != currentSelectServerInfo.m_areaName))
					{
						this.m_serverItemName.text = serverInfo.m_name;
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_serverItemGameObject);
						Button component = gameObject.GetComponent<Button>();
						component.onClick.AddListener(delegate()
						{
							$this.m_currentServerID = serverInfo.m_bornChannelId;
							$this.m_addFriendPanelServerNameText.text = serverInfo.m_name;
							$this.OnServerListPanelBGButtonClick();
						});
						gameObject.transform.SetParent(this.m_serverListGroup.transform, false);
						gameObject.SetActive(true);
					}
				}
			}
		}

		// Token: 0x0600E94B RID: 59723 RVA: 0x003E7AEC File Offset: 0x003E5CEC
		private void OnFriendToggle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFriendToggleBoolean_hotfix != null)
			{
				this.m_OnFriendToggleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnShowPanel != null)
			{
				this.m_panelUIStateController.SetToUIState("FriendServerNearly", false, true);
				this.SetPanelScrollViewReset();
				this.EventOnShowPanel(FriendPanelType.Friend);
			}
		}

		// Token: 0x0600E94C RID: 59724 RVA: 0x003E7B94 File Offset: 0x003E5D94
		private void OnAcrossServerToggle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAcrossServerToggleBoolean_hotfix != null)
			{
				this.m_OnAcrossServerToggleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnShowPanel != null)
			{
				this.m_panelUIStateController.SetToUIState("FriendServerNearly", false, true);
				this.SetPanelScrollViewReset();
				this.EventOnShowPanel(FriendPanelType.AcrossServerFriend);
			}
		}

		// Token: 0x0600E94D RID: 59725 RVA: 0x003E7C3C File Offset: 0x003E5E3C
		private void OnRecentToggle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecentToggleBoolean_hotfix != null)
			{
				this.m_OnRecentToggleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnShowPanel != null)
			{
				this.m_panelUIStateController.SetToUIState("FriendServerNearly", false, true);
				this.SetPanelScrollViewReset();
				this.EventOnShowPanel(FriendPanelType.Recent);
			}
		}

		// Token: 0x0600E94E RID: 59726 RVA: 0x003E7CE4 File Offset: 0x003E5EE4
		private void OnGroupToggle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGroupToggleBoolean_hotfix != null)
			{
				this.m_OnGroupToggleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnShowPanel != null)
			{
				this.m_panelUIStateController.SetToUIState("Group", false, true);
				this.SetPanelScrollViewReset();
				this.EventOnShowPanel(FriendPanelType.Group);
			}
		}

		// Token: 0x0600E94F RID: 59727 RVA: 0x003E7D8C File Offset: 0x003E5F8C
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
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600E950 RID: 59728 RVA: 0x003E7E04 File Offset: 0x003E6004
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

		// Token: 0x0600E951 RID: 59729 RVA: 0x003E7E7C File Offset: 0x003E607C
		private void OnShieldButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShieldButtonClick_hotfix != null)
			{
				this.m_OnShieldButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPanel != null)
			{
				this.EventOnShowPanel(FriendPanelType.Shield);
			}
			UIUtility.SetUIStateOpen(this.m_shieldPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600E952 RID: 59730 RVA: 0x003E7F08 File Offset: 0x003E6108
		private void OnShieldPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShieldPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnShieldPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_shieldPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600E953 RID: 59731 RVA: 0x003E7F7C File Offset: 0x003E617C
		private void OnSendAllFriendshipPointButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSendAllFriendshipPointButtonClick_hotfix != null)
			{
				this.m_OnSendAllFriendshipPointButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_sendAllFriendshipPointButtonUIStateCtrl.GetCurrentUIState().StateName == "Normal" && this.EventOnSendAllFriendshipPoint != null)
			{
				this.EventOnSendAllFriendshipPoint();
			}
		}

		// Token: 0x0600E954 RID: 59732 RVA: 0x003E8014 File Offset: 0x003E6214
		private void OnGetAllFriendshipPointButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetAllFriendshipPointButtonClick_hotfix != null)
			{
				this.m_OnGetAllFriendshipPointButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_getAllFriendshipPointButtonUIStateCtrl.GetCurrentUIState().StateName == "Normal" && this.EventOnGetAllFriendshipPoint != null)
			{
				this.EventOnGetAllFriendshipPoint();
			}
		}

		// Token: 0x0600E955 RID: 59733 RVA: 0x003E80AC File Offset: 0x003E62AC
		private void OnAddFriendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendButtonClick_hotfix != null)
			{
				this.m_OnAddFriendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetRecommendFriendsList != null)
			{
				this.EventOnGetRecommendFriendsList();
			}
			if (this.EventOnShowPanel != null)
			{
				this.EventOnShowPanel(FriendPanelType.AddFriend);
			}
			this.SetAddFriendPanel();
			UIUtility.SetUIStateOpen(this.m_addFriendPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600E956 RID: 59734 RVA: 0x003E8154 File Offset: 0x003E6354
		private void OnAddFriendPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnAddFriendPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_friendToggle.isOn)
			{
				this.EventOnShowPanel(FriendPanelType.Friend);
			}
			else if (this.m_acrossServerToggle.isOn)
			{
				this.EventOnShowPanel(FriendPanelType.AcrossServerFriend);
			}
			else if (this.m_recentToggle.isOn)
			{
				this.EventOnShowPanel(FriendPanelType.Recent);
			}
			UIUtility.SetUIStateClose(this.m_addFriendPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600E957 RID: 59735 RVA: 0x003E8228 File Offset: 0x003E6428
		private void OnSelectServerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectServerButtonClick_hotfix != null)
			{
				this.m_OnSelectServerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetServerListInfo();
			UIUtility.SetUIStateOpen(this.m_serverListPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600E958 RID: 59736 RVA: 0x003E82A4 File Offset: 0x003E64A4
		private void OnServerListPanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnServerListPanelBGButtonClick_hotfix != null)
			{
				this.m_OnServerListPanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_serverListPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x003E8318 File Offset: 0x003E6518
		private void SetSendAllFriendshipPointButtonState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSendAllFriendshipPointButtonState_hotfix != null)
			{
				this.m_SetSendAllFriendshipPointButtonState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sendAllFriendshipPointButtonUIStateCtrl.SetToUIState("Grey", false, true);
			foreach (UserSummary userSummary in this.m_playerContext.GetFriendList())
			{
				if (this.m_playerContext.CanSendFriendshipPoint(userSummary.UserId))
				{
					this.m_sendAllFriendshipPointButtonUIStateCtrl.SetToUIState("Normal", false, true);
					break;
				}
			}
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x003E8404 File Offset: 0x003E6604
		private void SetGetAllFriendshipPointButtonState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGetAllFriendshipPointButtonState_hotfix != null)
			{
				this.m_SetGetAllFriendshipPointButtonState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_getAllFriendshipPointButtonUIStateCtrl.SetToUIState("Grey", false, true);
			foreach (UserSummary userSummary in this.m_playerContext.GetFriendList())
			{
				if (this.m_playerContext.CanGetFriendshipPoint(userSummary.UserId))
				{
					this.m_getAllFriendshipPointButtonUIStateCtrl.SetToUIState("Normal", false, true);
					break;
				}
			}
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x003E84F0 File Offset: 0x003E66F0
		private void OnAddFriendPanelSearchButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendPanelSearchButtonClick_hotfix != null)
			{
				this.m_OnAddFriendPanelSearchButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(this.m_addFriendPanelInputText.text))
			{
				CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_SearchFriendNameEmpty), 2f, null, true);
				return;
			}
			if (this.m_currentServerID <= 0)
			{
				CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_SelectServerError), 2f, null, true);
				return;
			}
			if (this.EventOnFindFriend != null)
			{
				this.EventOnFindFriend(this.m_currentServerID, this.m_addFriendPanelInputText.text);
			}
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x003E85DC File Offset: 0x003E67DC
		private void OnAddFriendPanelChangeRecommendFriendButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendPanelChangeRecommendFriendButtonClick_hotfix != null)
			{
				this.m_OnAddFriendPanelChangeRecommendFriendButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetRecommendFriendsList != null)
			{
				this.EventOnGetRecommendFriendsList();
			}
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x003E8654 File Offset: 0x003E6854
		private void OnAddFriendPanelAddAllButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendPanelAddAllButtonClick_hotfix != null)
			{
				this.m_OnAddFriendPanelAddAllButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_recommendFriendList != null && this.m_recommendFriendList.Count > 0 && this.EventOnAddFriend != null)
			{
				this.m_friendAddList.Clear();
				foreach (UserSummary userSummary in this.m_recommendFriendList)
				{
					this.m_friendAddList.Add(userSummary.UserId);
				}
				this.EventOnAddFriend(this.m_friendAddList);
			}
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x003E8750 File Offset: 0x003E6950
		private void OnAddFriendPanelAcceptAllButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendPanelAcceptAllButtonClick_hotfix != null)
			{
				this.m_OnAddFriendPanelAcceptAllButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_applyFriendList != null && this.m_applyFriendList.Count > 0 && this.EventOnFriendApplyAceept != null)
			{
				this.m_friendApplyAcceptList.Clear();
				foreach (UserSummary userSummary in this.m_applyFriendList)
				{
					this.m_friendApplyAcceptList.Add(userSummary.UserId);
				}
				this.EventOnFriendApplyAceept(this.m_friendApplyAcceptList);
			}
		}

		// Token: 0x0600E95F RID: 59743 RVA: 0x003E884C File Offset: 0x003E6A4C
		private void OnAddFriendPanelRefuseAllButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddFriendPanelRefuseAllButtonClick_hotfix != null)
			{
				this.m_OnAddFriendPanelRefuseAllButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_applyFriendList != null && this.m_applyFriendList.Count > 0 && this.EventOnFriendApplyDecline != null)
			{
				this.m_friendApplyDeclineList.Clear();
				foreach (UserSummary userSummary in this.m_applyFriendList)
				{
					this.m_friendApplyDeclineList.Add(userSummary.UserId);
				}
				this.EventOnFriendApplyDecline(this.m_friendApplyDeclineList);
			}
		}

		// Token: 0x0600E960 RID: 59744 RVA: 0x003E8948 File Offset: 0x003E6B48
		private void OnWatchGroupStaffPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchGroupStaffPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnWatchGroupStaffPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPanel != null)
			{
				this.EventOnShowPanel(FriendPanelType.Group);
			}
			UIUtility.SetUIStateClose(this.m_watchGroupStaffPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600E961 RID: 59745 RVA: 0x003E89D4 File Offset: 0x003E6BD4
		public void WatchGroupStaffPanelClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WatchGroupStaffPanelClose_hotfix != null)
			{
				this.m_WatchGroupStaffPanelClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_watchGroupStaffPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x003E8A48 File Offset: 0x003E6C48
		public void GroupDissolved(ProChatGroupInfo chatGroupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GroupDissolvedProChatGroupInfo_hotfix != null)
			{
				this.m_GroupDissolvedProChatGroupInfo_hotfix.call(new object[]
				{
					this,
					chatGroupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currentChatGroupInfo != null && this.m_currentChatGroupInfo.CompactInfo.ChatGroupId == chatGroupInfo.CompactInfo.ChatGroupId)
			{
				if (this.m_changeGroupNameUIStateController.gameObject.activeSelf && this.m_changeGroupNameUIStateController.GetCurrentUIState().StateName == "Show")
				{
					UIUtility.SetUIStateClose(this.m_changeGroupNameUIStateController, "Close", null, false, true);
				}
				if (!this.m_isCreateNewGroup && this.m_inviteFriendToGroupPanelUIStateController.gameObject.activeSelf && this.m_inviteFriendToGroupPanelUIStateController.GetCurrentUIState().StateName == "Show")
				{
					UIUtility.SetUIStateClose(this.m_inviteFriendToGroupPanelUIStateController, "Close", null, false, true);
				}
				if (this.m_watchGroupStaffPanelUIStateController.gameObject.activeSelf && this.m_watchGroupStaffPanelUIStateController.GetCurrentUIState().StateName == "Show")
				{
					UIUtility.SetUIStateClose(this.m_watchGroupStaffPanelUIStateController, "Close", null, false, true);
				}
			}
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x003E8BC8 File Offset: 0x003E6DC8
		private void OnWatchGroupStaffPanelChangeNameButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchGroupStaffPanelChangeNameButtonClick_hotfix != null)
			{
				this.m_OnWatchGroupStaffPanelChangeNameButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_changeGroupNameUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600E964 RID: 59748 RVA: 0x003E8C3C File Offset: 0x003E6E3C
		public void OnWatchGroupStaffPanelChangeNamePanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchGroupStaffPanelChangeNamePanelBGButtonClick_hotfix != null)
			{
				this.m_OnWatchGroupStaffPanelChangeNamePanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_changeGroupNameUIStateController, "Close", delegate
			{
				this.m_changeNamePanelInputField.text = string.Empty;
			}, false, true);
		}

		// Token: 0x0600E965 RID: 59749 RVA: 0x003E8CBC File Offset: 0x003E6EBC
		private void OnWatchGroupStaffPanelChangeNameConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchGroupStaffPanelChangeNameConfirmButtonClick_hotfix != null)
			{
				this.m_OnWatchGroupStaffPanelChangeNameConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_changeNamePanelInputField.text.IsValidName(this.m_configDataLoader);
			if (num == 0)
			{
				if (this.EventOnChangeGroupName != null && this.m_currentChatGroupInfo != null)
				{
					this.EventOnChangeGroupName(this.m_currentChatGroupInfo.CompactInfo.ChatGroupId, this.m_changeNamePanelInputField.text);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x003E8D8C File Offset: 0x003E6F8C
		private void OnQuitGroupButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnQuitGroupButtonClick_hotfix != null)
			{
				this.m_OnQuitGroupButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLeaveGroup != null && this.m_currentChatGroupInfo != null)
			{
				this.EventOnLeaveGroup(this.m_currentChatGroupInfo);
			}
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x003E8E14 File Offset: 0x003E7014
		private void OnCreateNewGroupButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateNewGroupButtonClick_hotfix != null)
			{
				this.m_OnCreateNewGroupButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isCreateNewGroup = true;
			if (this.EventOnShowPanel != null)
			{
				this.EventOnShowPanel(FriendPanelType.FriendInviteToGroup);
			}
			UIUtility.SetUIStateOpen(this.m_inviteFriendToGroupPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x003E8EA8 File Offset: 0x003E70A8
		private void OnInviteFriendToGroupButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendToGroupButtonClick_hotfix != null)
			{
				this.m_OnInviteFriendToGroupButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isCreateNewGroup = false;
			if (this.EventOnShowPanel != null)
			{
				this.EventOnShowPanel(FriendPanelType.FriendInviteToGroup);
			}
			UIUtility.SetUIStateOpen(this.m_inviteFriendToGroupPanelUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x003E8F3C File Offset: 0x003E713C
		public void InviteFriendToGoupPanelClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InviteFriendToGoupPanelClose_hotfix != null)
			{
				this.m_InviteFriendToGoupPanelClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_inviteFriendToGroupPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0600E96A RID: 59754 RVA: 0x003E8FB0 File Offset: 0x003E71B0
		private void OnInviteFriendToGoupPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendToGoupPanelConfirmButtonClick_hotfix != null)
			{
				this.m_OnInviteFriendToGoupPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isCreateNewGroup)
			{
				if (this.m_inviteToGroupList.Count >= 2)
				{
					this.EventOnCreateNewGroup(this.m_inviteToGroupList);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_InvitePlayerAtLeastTwo), 2f, null, true);
				}
			}
			else if (this.m_inviteToGroupList.Count >= 1 && this.m_currentChatGroupInfo != null)
			{
				this.EventOnInviteFriendToGroup(this.m_currentChatGroupInfo.CompactInfo.ChatGroupId, this.m_inviteToGroupList);
			}
			else
			{
				CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_InvitePlayerCountZero), 2f, null, true);
			}
		}

		// Token: 0x0600E96B RID: 59755 RVA: 0x003E90CC File Offset: 0x003E72CC
		private void OnInviteFriendToGroupPanelServerFriendToggle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendToGroupPanelServerFriendToggleBoolean_hotfix != null)
			{
				this.m_OnInviteFriendToGroupPanelServerFriendToggleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.SetInviteAcrossServerFriendToGroupList();
			}
		}

		// Token: 0x0600E96C RID: 59756 RVA: 0x003E9148 File Offset: 0x003E7348
		private void OnInviteFriendToGroupPanelFriendToggle(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendToGroupPanelFriendToggleBoolean_hotfix != null)
			{
				this.m_OnInviteFriendToGroupPanelFriendToggleBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.SetInviteFriendToGroupList();
			}
		}

		// Token: 0x0600E96D RID: 59757 RVA: 0x003E91C4 File Offset: 0x003E73C4
		private void OnPlayerItemButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerItemButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnPlayerItemButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerSimpleInfo != null)
			{
				this.EventOnShowPlayerSimpleInfo(ctrl.GetUserSummy(), ctrl.GetPlayerSimpleInfoPos(), ctrl.GetSimpleInfoPostionType());
			}
		}

		// Token: 0x0600E96E RID: 59758 RVA: 0x003E925C File Offset: 0x003E745C
		private void OnPlayerItemButtonClick(FriendSmallItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerItemButtonClickFriendSmallItemUIController_hotfix != null)
			{
				this.m_OnPlayerItemButtonClickFriendSmallItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowPlayerSimpleInfo != null)
			{
				this.EventOnShowPlayerSimpleInfo(ctrl.GetUserSummy(), ctrl.GetPlayerSimpleInfoPos(), ctrl.GetSimpleInfoPostionType());
			}
		}

		// Token: 0x0600E96F RID: 59759 RVA: 0x003E92F4 File Offset: 0x003E74F4
		private void OnItemAddFriendButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemAddFriendButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnItemAddFriendButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddFriend != null)
			{
				this.m_friendAddList.Clear();
				this.m_friendAddList.Add(ctrl.GetUserID());
				this.EventOnAddFriend(this.m_friendAddList);
			}
		}

		// Token: 0x0600E970 RID: 59760 RVA: 0x003E939C File Offset: 0x003E759C
		private void OnItemKickFromGroupButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemKickFromGroupButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnItemKickFromGroupButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnKickFromGroup != null && this.m_currentChatGroupInfo != null)
			{
				this.EventOnKickFromGroup(this.m_currentChatGroupInfo, ctrl.GetUserSummy());
			}
		}

		// Token: 0x0600E971 RID: 59761 RVA: 0x003E943C File Offset: 0x003E763C
		private void OnUnblockPlayerButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnblockPlayerButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnUnblockPlayerButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnUnblockPlayer != null)
			{
				this.EventOnUnblockPlayer(ctrl.GetUserID());
			}
		}

		// Token: 0x0600E972 RID: 59762 RVA: 0x003E94C8 File Offset: 0x003E76C8
		private void OnChatButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnChatButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChat != null)
			{
				this.EventOnChat(ctrl.GetUserSummy());
			}
		}

		// Token: 0x0600E973 RID: 59763 RVA: 0x003E9554 File Offset: 0x003E7754
		private void OnSendFriendshipPointButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSendFriendshipPointButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnSendFriendshipPointButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSendFriendshipPoint != null)
			{
				this.EventOnSendFriendshipPoint(ctrl.GetUserID());
			}
		}

		// Token: 0x0600E974 RID: 59764 RVA: 0x003E95E0 File Offset: 0x003E77E0
		private void OnGetFriendshipPointButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetFriendshipPointButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnGetFriendshipPointButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetFriendshipPoint != null)
			{
				this.EventOnGetFriendshipPoint(ctrl.GetUserID());
			}
		}

		// Token: 0x0600E975 RID: 59765 RVA: 0x003E966C File Offset: 0x003E786C
		private void OnFriendshipPointDoneButtonClick(FriendBigItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFriendshipPointDoneButtonClickFriendBigItemUIController_hotfix != null)
			{
				this.m_OnFriendshipPointDoneButtonClickFriendBigItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerContext.GetSendFriendShipPointsCountToday() >= this.m_configDataLoader.ConfigableConstId_SendFriendShipPointsMaxTimes)
			{
				this.ShowFriendShipPointTip(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_SendFriendShipPointTopLimit));
			}
			else if (this.m_playerContext.HasSentFriendShipPoints(ctrl.GetUserID()))
			{
				this.ShowFriendShipPointTip(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_AlreadySendFriendShipPoint));
			}
		}

		// Token: 0x0600E976 RID: 59766 RVA: 0x003E9740 File Offset: 0x003E7940
		private void OnItemAddFriendButtonClick(FriendSmallItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemAddFriendButtonClickFriendSmallItemUIController_hotfix != null)
			{
				this.m_OnItemAddFriendButtonClickFriendSmallItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddFriend != null)
			{
				this.m_friendAddList.Clear();
				this.m_friendAddList.Add(ctrl.GetUserID());
				this.EventOnAddFriend(this.m_friendAddList);
			}
		}

		// Token: 0x0600E977 RID: 59767 RVA: 0x003E97E8 File Offset: 0x003E79E8
		private void OnChatButtonClick(FriendSmallItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatButtonClickFriendSmallItemUIController_hotfix != null)
			{
				this.m_OnChatButtonClickFriendSmallItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChat != null)
			{
				this.EventOnChat(ctrl.GetUserSummy());
			}
		}

		// Token: 0x0600E978 RID: 59768 RVA: 0x003E9874 File Offset: 0x003E7A74
		private void OnFriendApplyAceeptButtonClick(FriendSmallItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFriendApplyAceeptButtonClickFriendSmallItemUIController_hotfix != null)
			{
				this.m_OnFriendApplyAceeptButtonClickFriendSmallItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFriendApplyAceept != null)
			{
				this.m_friendApplyAcceptList.Clear();
				this.m_friendApplyAcceptList.Add(ctrl.GetUserID());
				this.EventOnFriendApplyAceept(this.m_friendApplyAcceptList);
			}
		}

		// Token: 0x0600E979 RID: 59769 RVA: 0x003E991C File Offset: 0x003E7B1C
		private void OnFriendApplyDeclineButtonClick(FriendSmallItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFriendApplyDeclineButtonClickFriendSmallItemUIController_hotfix != null)
			{
				this.m_OnFriendApplyDeclineButtonClickFriendSmallItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFriendApplyDecline != null)
			{
				this.m_friendApplyDeclineList.Clear();
				this.m_friendApplyDeclineList.Add(ctrl.GetUserID());
				this.EventOnFriendApplyDecline(this.m_friendApplyDeclineList);
			}
		}

		// Token: 0x0600E97A RID: 59770 RVA: 0x003E99C4 File Offset: 0x003E7BC4
		private void OnInviteFriendToGroupToggleValueChanged(bool isOn, FriendSmallItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteFriendToGroupToggleValueChangedBooleanFriendSmallItemUIController_hotfix != null)
			{
				this.m_OnInviteFriendToGroupToggleValueChangedBooleanFriendSmallItemUIController_hotfix.call(new object[]
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
				if (this.m_inviteToGroupList.Count == 10)
				{
					ctrl.SetUserSelect(false);
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Friend_AlreadyMaxInviteCount, 2f, null, true);
				}
				else if (this.m_inviteToGroupList.Count < 10 && !this.m_inviteToGroupList.Contains(ctrl.GetUserID()))
				{
					this.m_inviteToGroupList.Add(ctrl.GetUserID());
				}
			}
			else if (this.m_inviteToGroupList.Contains(ctrl.GetUserID()))
			{
				this.m_inviteToGroupList.Remove(ctrl.GetUserID());
			}
			this.m_inviteFriendToGroupPanelCountText.text = this.m_inviteToGroupList.Count.ToString();
		}

		// Token: 0x0600E97B RID: 59771 RVA: 0x003E9B08 File Offset: 0x003E7D08
		private void OnGroupChatButtonClick(FriendGroupUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGroupChatButtonClickFriendGroupUIController_hotfix != null)
			{
				this.m_OnGroupChatButtonClickFriendGroupUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGroupChat != null)
			{
				this.EventOnGroupChat(ctrl.GetGroupInfo().ChatGroupId);
			}
		}

		// Token: 0x0600E97C RID: 59772 RVA: 0x003E9B9C File Offset: 0x003E7D9C
		private void OnWatchGroupStaffButtonClick(FriendGroupUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchGroupStaffButtonClickFriendGroupUIController_hotfix != null)
			{
				this.m_OnWatchGroupStaffButtonClickFriendGroupUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnWatchGroupStaff != null)
			{
				this.EventOnWatchGroupStaff(ctrl.GetGroupInfo().ChatGroupId, true);
			}
		}

		// Token: 0x140002F8 RID: 760
		// (add) Token: 0x0600E97D RID: 59773 RVA: 0x003E9C30 File Offset: 0x003E7E30
		// (remove) Token: 0x0600E97E RID: 59774 RVA: 0x003E9CCC File Offset: 0x003E7ECC
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

		// Token: 0x140002F9 RID: 761
		// (add) Token: 0x0600E97F RID: 59775 RVA: 0x003E9D68 File Offset: 0x003E7F68
		// (remove) Token: 0x0600E980 RID: 59776 RVA: 0x003E9E04 File Offset: 0x003E8004
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

		// Token: 0x140002FA RID: 762
		// (add) Token: 0x0600E981 RID: 59777 RVA: 0x003E9EA0 File Offset: 0x003E80A0
		// (remove) Token: 0x0600E982 RID: 59778 RVA: 0x003E9F3C File Offset: 0x003E813C
		public event Action<FriendPanelType> EventOnShowPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPanelAction`1_hotfix != null)
				{
					this.m_add_EventOnShowPanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendPanelType> action = this.EventOnShowPanel;
				Action<FriendPanelType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendPanelType>>(ref this.EventOnShowPanel, (Action<FriendPanelType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPanelAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowPanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendPanelType> action = this.EventOnShowPanel;
				Action<FriendPanelType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendPanelType>>(ref this.EventOnShowPanel, (Action<FriendPanelType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002FB RID: 763
		// (add) Token: 0x0600E983 RID: 59779 RVA: 0x003E9FD8 File Offset: 0x003E81D8
		// (remove) Token: 0x0600E984 RID: 59780 RVA: 0x003EA074 File Offset: 0x003E8274
		public event Action<List<string>> EventOnAddFriend
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddFriendAction`1_hotfix != null)
				{
					this.m_add_EventOnAddFriendAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnAddFriend;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnAddFriend, (Action<List<string>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddFriendAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddFriendAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnAddFriend;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnAddFriend, (Action<List<string>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002FC RID: 764
		// (add) Token: 0x0600E985 RID: 59781 RVA: 0x003EA110 File Offset: 0x003E8310
		// (remove) Token: 0x0600E986 RID: 59782 RVA: 0x003EA1AC File Offset: 0x003E83AC
		public event Action<ProChatGroupInfo, UserSummary> EventOnKickFromGroup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnKickFromGroupAction`2_hotfix != null)
				{
					this.m_add_EventOnKickFromGroupAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ProChatGroupInfo, UserSummary> action = this.EventOnKickFromGroup;
				Action<ProChatGroupInfo, UserSummary> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ProChatGroupInfo, UserSummary>>(ref this.EventOnKickFromGroup, (Action<ProChatGroupInfo, UserSummary>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnKickFromGroupAction`2_hotfix != null)
				{
					this.m_remove_EventOnKickFromGroupAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ProChatGroupInfo, UserSummary> action = this.EventOnKickFromGroup;
				Action<ProChatGroupInfo, UserSummary> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ProChatGroupInfo, UserSummary>>(ref this.EventOnKickFromGroup, (Action<ProChatGroupInfo, UserSummary>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002FD RID: 765
		// (add) Token: 0x0600E987 RID: 59783 RVA: 0x003EA248 File Offset: 0x003E8448
		// (remove) Token: 0x0600E988 RID: 59784 RVA: 0x003EA2E4 File Offset: 0x003E84E4
		public event Action<string> EventOnUnblockPlayer
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUnblockPlayerAction`1_hotfix != null)
				{
					this.m_add_EventOnUnblockPlayerAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnUnblockPlayer;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnUnblockPlayer, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUnblockPlayerAction`1_hotfix != null)
				{
					this.m_remove_EventOnUnblockPlayerAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnUnblockPlayer;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnUnblockPlayer, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002FE RID: 766
		// (add) Token: 0x0600E989 RID: 59785 RVA: 0x003EA380 File Offset: 0x003E8580
		// (remove) Token: 0x0600E98A RID: 59786 RVA: 0x003EA41C File Offset: 0x003E861C
		public event Action<UserSummary> EventOnChat
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
				Action<UserSummary> action = this.EventOnChat;
				Action<UserSummary> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UserSummary>>(ref this.EventOnChat, (Action<UserSummary>)Delegate.Combine(action2, value), action);
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
				Action<UserSummary> action = this.EventOnChat;
				Action<UserSummary> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UserSummary>>(ref this.EventOnChat, (Action<UserSummary>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002FF RID: 767
		// (add) Token: 0x0600E98B RID: 59787 RVA: 0x003EA4B8 File Offset: 0x003E86B8
		// (remove) Token: 0x0600E98C RID: 59788 RVA: 0x003EA554 File Offset: 0x003E8754
		public event Action<string> EventOnSendFriendshipPoint
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSendFriendshipPointAction`1_hotfix != null)
				{
					this.m_add_EventOnSendFriendshipPointAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSendFriendshipPoint;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSendFriendshipPoint, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSendFriendshipPointAction`1_hotfix != null)
				{
					this.m_remove_EventOnSendFriendshipPointAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSendFriendshipPoint;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSendFriendshipPoint, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000300 RID: 768
		// (add) Token: 0x0600E98D RID: 59789 RVA: 0x003EA5F0 File Offset: 0x003E87F0
		// (remove) Token: 0x0600E98E RID: 59790 RVA: 0x003EA68C File Offset: 0x003E888C
		public event Action<string> EventOnGetFriendshipPoint
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetFriendshipPointAction`1_hotfix != null)
				{
					this.m_add_EventOnGetFriendshipPointAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnGetFriendshipPoint;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnGetFriendshipPoint, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetFriendshipPointAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetFriendshipPointAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnGetFriendshipPoint;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnGetFriendshipPoint, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000301 RID: 769
		// (add) Token: 0x0600E98F RID: 59791 RVA: 0x003EA728 File Offset: 0x003E8928
		// (remove) Token: 0x0600E990 RID: 59792 RVA: 0x003EA7C4 File Offset: 0x003E89C4
		public event Action<int, string> EventOnFindFriend
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFindFriendAction`2_hotfix != null)
				{
					this.m_add_EventOnFindFriendAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, string> action = this.EventOnFindFriend;
				Action<int, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, string>>(ref this.EventOnFindFriend, (Action<int, string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFindFriendAction`2_hotfix != null)
				{
					this.m_remove_EventOnFindFriendAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, string> action = this.EventOnFindFriend;
				Action<int, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, string>>(ref this.EventOnFindFriend, (Action<int, string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000302 RID: 770
		// (add) Token: 0x0600E991 RID: 59793 RVA: 0x003EA860 File Offset: 0x003E8A60
		// (remove) Token: 0x0600E992 RID: 59794 RVA: 0x003EA8FC File Offset: 0x003E8AFC
		public event Action EventOnSendAllFriendshipPoint
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSendAllFriendshipPointAction_hotfix != null)
				{
					this.m_add_EventOnSendAllFriendshipPointAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSendAllFriendshipPoint;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSendAllFriendshipPoint, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSendAllFriendshipPointAction_hotfix != null)
				{
					this.m_remove_EventOnSendAllFriendshipPointAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSendAllFriendshipPoint;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSendAllFriendshipPoint, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000303 RID: 771
		// (add) Token: 0x0600E993 RID: 59795 RVA: 0x003EA998 File Offset: 0x003E8B98
		// (remove) Token: 0x0600E994 RID: 59796 RVA: 0x003EAA34 File Offset: 0x003E8C34
		public event Action EventOnGetAllFriendshipPoint
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetAllFriendshipPointAction_hotfix != null)
				{
					this.m_add_EventOnGetAllFriendshipPointAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetAllFriendshipPoint;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetAllFriendshipPoint, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetAllFriendshipPointAction_hotfix != null)
				{
					this.m_remove_EventOnGetAllFriendshipPointAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetAllFriendshipPoint;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetAllFriendshipPoint, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000304 RID: 772
		// (add) Token: 0x0600E995 RID: 59797 RVA: 0x003EAAD0 File Offset: 0x003E8CD0
		// (remove) Token: 0x0600E996 RID: 59798 RVA: 0x003EAB6C File Offset: 0x003E8D6C
		public event Action EventOnGetRecommendFriendsList
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetRecommendFriendsListAction_hotfix != null)
				{
					this.m_add_EventOnGetRecommendFriendsListAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetRecommendFriendsList;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetRecommendFriendsList, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetRecommendFriendsListAction_hotfix != null)
				{
					this.m_remove_EventOnGetRecommendFriendsListAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetRecommendFriendsList;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetRecommendFriendsList, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000305 RID: 773
		// (add) Token: 0x0600E997 RID: 59799 RVA: 0x003EAC08 File Offset: 0x003E8E08
		// (remove) Token: 0x0600E998 RID: 59800 RVA: 0x003EACA4 File Offset: 0x003E8EA4
		public event Action<List<string>> EventOnFriendApplyAceept
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFriendApplyAceeptAction`1_hotfix != null)
				{
					this.m_add_EventOnFriendApplyAceeptAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnFriendApplyAceept;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnFriendApplyAceept, (Action<List<string>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFriendApplyAceeptAction`1_hotfix != null)
				{
					this.m_remove_EventOnFriendApplyAceeptAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnFriendApplyAceept;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnFriendApplyAceept, (Action<List<string>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000306 RID: 774
		// (add) Token: 0x0600E999 RID: 59801 RVA: 0x003EAD40 File Offset: 0x003E8F40
		// (remove) Token: 0x0600E99A RID: 59802 RVA: 0x003EADDC File Offset: 0x003E8FDC
		public event Action<List<string>> EventOnFriendApplyDecline
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFriendApplyDeclineAction`1_hotfix != null)
				{
					this.m_add_EventOnFriendApplyDeclineAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnFriendApplyDecline;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnFriendApplyDecline, (Action<List<string>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFriendApplyDeclineAction`1_hotfix != null)
				{
					this.m_remove_EventOnFriendApplyDeclineAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnFriendApplyDecline;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnFriendApplyDecline, (Action<List<string>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000307 RID: 775
		// (add) Token: 0x0600E99B RID: 59803 RVA: 0x003EAE78 File Offset: 0x003E9078
		// (remove) Token: 0x0600E99C RID: 59804 RVA: 0x003EAF14 File Offset: 0x003E9114
		public event Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> EventOnShowPlayerSimpleInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowPlayerSimpleInfoAction`3_hotfix != null)
				{
					this.m_add_EventOnShowPlayerSimpleInfoAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> action = this.EventOnShowPlayerSimpleInfo;
				Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType>>(ref this.EventOnShowPlayerSimpleInfo, (Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowPlayerSimpleInfoAction`3_hotfix != null)
				{
					this.m_remove_EventOnShowPlayerSimpleInfoAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> action = this.EventOnShowPlayerSimpleInfo;
				Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType>>(ref this.EventOnShowPlayerSimpleInfo, (Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000308 RID: 776
		// (add) Token: 0x0600E99D RID: 59805 RVA: 0x003EAFB0 File Offset: 0x003E91B0
		// (remove) Token: 0x0600E99E RID: 59806 RVA: 0x003EB04C File Offset: 0x003E924C
		public event Action<string> EventOnGroupChat
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGroupChatAction`1_hotfix != null)
				{
					this.m_add_EventOnGroupChatAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnGroupChat;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnGroupChat, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGroupChatAction`1_hotfix != null)
				{
					this.m_remove_EventOnGroupChatAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnGroupChat;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnGroupChat, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000309 RID: 777
		// (add) Token: 0x0600E99F RID: 59807 RVA: 0x003EB0E8 File Offset: 0x003E92E8
		// (remove) Token: 0x0600E9A0 RID: 59808 RVA: 0x003EB184 File Offset: 0x003E9384
		public event Action<string, bool> EventOnWatchGroupStaff
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWatchGroupStaffAction`2_hotfix != null)
				{
					this.m_add_EventOnWatchGroupStaffAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, bool> action = this.EventOnWatchGroupStaff;
				Action<string, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, bool>>(ref this.EventOnWatchGroupStaff, (Action<string, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWatchGroupStaffAction`2_hotfix != null)
				{
					this.m_remove_EventOnWatchGroupStaffAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, bool> action = this.EventOnWatchGroupStaff;
				Action<string, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, bool>>(ref this.EventOnWatchGroupStaff, (Action<string, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400030A RID: 778
		// (add) Token: 0x0600E9A1 RID: 59809 RVA: 0x003EB220 File Offset: 0x003E9420
		// (remove) Token: 0x0600E9A2 RID: 59810 RVA: 0x003EB2BC File Offset: 0x003E94BC
		public event Action<List<string>> EventOnCreateNewGroup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCreateNewGroupAction`1_hotfix != null)
				{
					this.m_add_EventOnCreateNewGroupAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnCreateNewGroup;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnCreateNewGroup, (Action<List<string>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCreateNewGroupAction`1_hotfix != null)
				{
					this.m_remove_EventOnCreateNewGroupAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<string>> action = this.EventOnCreateNewGroup;
				Action<List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<string>>>(ref this.EventOnCreateNewGroup, (Action<List<string>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400030B RID: 779
		// (add) Token: 0x0600E9A3 RID: 59811 RVA: 0x003EB358 File Offset: 0x003E9558
		// (remove) Token: 0x0600E9A4 RID: 59812 RVA: 0x003EB3F4 File Offset: 0x003E95F4
		public event Action<string, List<string>> EventOnInviteFriendToGroup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnInviteFriendToGroupAction`2_hotfix != null)
				{
					this.m_add_EventOnInviteFriendToGroupAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, List<string>> action = this.EventOnInviteFriendToGroup;
				Action<string, List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, List<string>>>(ref this.EventOnInviteFriendToGroup, (Action<string, List<string>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnInviteFriendToGroupAction`2_hotfix != null)
				{
					this.m_remove_EventOnInviteFriendToGroupAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, List<string>> action = this.EventOnInviteFriendToGroup;
				Action<string, List<string>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, List<string>>>(ref this.EventOnInviteFriendToGroup, (Action<string, List<string>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400030C RID: 780
		// (add) Token: 0x0600E9A5 RID: 59813 RVA: 0x003EB490 File Offset: 0x003E9690
		// (remove) Token: 0x0600E9A6 RID: 59814 RVA: 0x003EB52C File Offset: 0x003E972C
		public event Action<string, string> EventOnChangeGroupName
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeGroupNameAction`2_hotfix != null)
				{
					this.m_add_EventOnChangeGroupNameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, string> action = this.EventOnChangeGroupName;
				Action<string, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, string>>(ref this.EventOnChangeGroupName, (Action<string, string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeGroupNameAction`2_hotfix != null)
				{
					this.m_remove_EventOnChangeGroupNameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, string> action = this.EventOnChangeGroupName;
				Action<string, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, string>>(ref this.EventOnChangeGroupName, (Action<string, string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400030D RID: 781
		// (add) Token: 0x0600E9A7 RID: 59815 RVA: 0x003EB5C8 File Offset: 0x003E97C8
		// (remove) Token: 0x0600E9A8 RID: 59816 RVA: 0x003EB664 File Offset: 0x003E9864
		public event Action<ProChatGroupInfo> EventOnLeaveGroup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLeaveGroupAction`1_hotfix != null)
				{
					this.m_add_EventOnLeaveGroupAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ProChatGroupInfo> action = this.EventOnLeaveGroup;
				Action<ProChatGroupInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ProChatGroupInfo>>(ref this.EventOnLeaveGroup, (Action<ProChatGroupInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLeaveGroupAction`1_hotfix != null)
				{
					this.m_remove_EventOnLeaveGroupAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ProChatGroupInfo> action = this.EventOnLeaveGroup;
				Action<ProChatGroupInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ProChatGroupInfo>>(ref this.EventOnLeaveGroup, (Action<ProChatGroupInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600E9A9 RID: 59817 RVA: 0x003EB700 File Offset: 0x003E9900
		// (set) Token: 0x0600E9AA RID: 59818 RVA: 0x003EB720 File Offset: 0x003E9920
		[DoNotToLua]
		public new FriendUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E9AB RID: 59819 RVA: 0x003EB72C File Offset: 0x003E992C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E9AC RID: 59820 RVA: 0x003EB738 File Offset: 0x003E9938
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E9AD RID: 59821 RVA: 0x003EB740 File Offset: 0x003E9940
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E9AE RID: 59822 RVA: 0x003EB748 File Offset: 0x003E9948
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x003EB75C File Offset: 0x003E995C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E9B0 RID: 59824 RVA: 0x003EB764 File Offset: 0x003E9964
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E9B1 RID: 59825 RVA: 0x003EB770 File Offset: 0x003E9970
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E9B2 RID: 59826 RVA: 0x003EB77C File Offset: 0x003E997C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E9B3 RID: 59827 RVA: 0x003EB788 File Offset: 0x003E9988
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x003EB794 File Offset: 0x003E9994
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E9B5 RID: 59829 RVA: 0x003EB7A0 File Offset: 0x003E99A0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E9B6 RID: 59830 RVA: 0x003EB7AC File Offset: 0x003E99AC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E9B7 RID: 59831 RVA: 0x003EB7B8 File Offset: 0x003E99B8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E9B8 RID: 59832 RVA: 0x003EB7C4 File Offset: 0x003E99C4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E9B9 RID: 59833 RVA: 0x003EB7D0 File Offset: 0x003E99D0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E9BA RID: 59834 RVA: 0x003EB7D8 File Offset: 0x003E99D8
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600E9BB RID: 59835 RVA: 0x003EB7F8 File Offset: 0x003E99F8
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600E9BC RID: 59836 RVA: 0x003EB804 File Offset: 0x003E9A04
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600E9BD RID: 59837 RVA: 0x003EB824 File Offset: 0x003E9A24
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600E9BE RID: 59838 RVA: 0x003EB830 File Offset: 0x003E9A30
		private void __callDele_EventOnShowPanel(FriendPanelType obj)
		{
			Action<FriendPanelType> eventOnShowPanel = this.EventOnShowPanel;
			if (eventOnShowPanel != null)
			{
				eventOnShowPanel(obj);
			}
		}

		// Token: 0x0600E9BF RID: 59839 RVA: 0x003EB854 File Offset: 0x003E9A54
		private void __clearDele_EventOnShowPanel(FriendPanelType obj)
		{
			this.EventOnShowPanel = null;
		}

		// Token: 0x0600E9C0 RID: 59840 RVA: 0x003EB860 File Offset: 0x003E9A60
		private void __callDele_EventOnAddFriend(List<string> obj)
		{
			Action<List<string>> eventOnAddFriend = this.EventOnAddFriend;
			if (eventOnAddFriend != null)
			{
				eventOnAddFriend(obj);
			}
		}

		// Token: 0x0600E9C1 RID: 59841 RVA: 0x003EB884 File Offset: 0x003E9A84
		private void __clearDele_EventOnAddFriend(List<string> obj)
		{
			this.EventOnAddFriend = null;
		}

		// Token: 0x0600E9C2 RID: 59842 RVA: 0x003EB890 File Offset: 0x003E9A90
		private void __callDele_EventOnKickFromGroup(ProChatGroupInfo arg1, UserSummary arg2)
		{
			Action<ProChatGroupInfo, UserSummary> eventOnKickFromGroup = this.EventOnKickFromGroup;
			if (eventOnKickFromGroup != null)
			{
				eventOnKickFromGroup(arg1, arg2);
			}
		}

		// Token: 0x0600E9C3 RID: 59843 RVA: 0x003EB8B4 File Offset: 0x003E9AB4
		private void __clearDele_EventOnKickFromGroup(ProChatGroupInfo arg1, UserSummary arg2)
		{
			this.EventOnKickFromGroup = null;
		}

		// Token: 0x0600E9C4 RID: 59844 RVA: 0x003EB8C0 File Offset: 0x003E9AC0
		private void __callDele_EventOnUnblockPlayer(string obj)
		{
			Action<string> eventOnUnblockPlayer = this.EventOnUnblockPlayer;
			if (eventOnUnblockPlayer != null)
			{
				eventOnUnblockPlayer(obj);
			}
		}

		// Token: 0x0600E9C5 RID: 59845 RVA: 0x003EB8E4 File Offset: 0x003E9AE4
		private void __clearDele_EventOnUnblockPlayer(string obj)
		{
			this.EventOnUnblockPlayer = null;
		}

		// Token: 0x0600E9C6 RID: 59846 RVA: 0x003EB8F0 File Offset: 0x003E9AF0
		private void __callDele_EventOnChat(UserSummary obj)
		{
			Action<UserSummary> eventOnChat = this.EventOnChat;
			if (eventOnChat != null)
			{
				eventOnChat(obj);
			}
		}

		// Token: 0x0600E9C7 RID: 59847 RVA: 0x003EB914 File Offset: 0x003E9B14
		private void __clearDele_EventOnChat(UserSummary obj)
		{
			this.EventOnChat = null;
		}

		// Token: 0x0600E9C8 RID: 59848 RVA: 0x003EB920 File Offset: 0x003E9B20
		private void __callDele_EventOnSendFriendshipPoint(string obj)
		{
			Action<string> eventOnSendFriendshipPoint = this.EventOnSendFriendshipPoint;
			if (eventOnSendFriendshipPoint != null)
			{
				eventOnSendFriendshipPoint(obj);
			}
		}

		// Token: 0x0600E9C9 RID: 59849 RVA: 0x003EB944 File Offset: 0x003E9B44
		private void __clearDele_EventOnSendFriendshipPoint(string obj)
		{
			this.EventOnSendFriendshipPoint = null;
		}

		// Token: 0x0600E9CA RID: 59850 RVA: 0x003EB950 File Offset: 0x003E9B50
		private void __callDele_EventOnGetFriendshipPoint(string obj)
		{
			Action<string> eventOnGetFriendshipPoint = this.EventOnGetFriendshipPoint;
			if (eventOnGetFriendshipPoint != null)
			{
				eventOnGetFriendshipPoint(obj);
			}
		}

		// Token: 0x0600E9CB RID: 59851 RVA: 0x003EB974 File Offset: 0x003E9B74
		private void __clearDele_EventOnGetFriendshipPoint(string obj)
		{
			this.EventOnGetFriendshipPoint = null;
		}

		// Token: 0x0600E9CC RID: 59852 RVA: 0x003EB980 File Offset: 0x003E9B80
		private void __callDele_EventOnFindFriend(int arg1, string arg2)
		{
			Action<int, string> eventOnFindFriend = this.EventOnFindFriend;
			if (eventOnFindFriend != null)
			{
				eventOnFindFriend(arg1, arg2);
			}
		}

		// Token: 0x0600E9CD RID: 59853 RVA: 0x003EB9A4 File Offset: 0x003E9BA4
		private void __clearDele_EventOnFindFriend(int arg1, string arg2)
		{
			this.EventOnFindFriend = null;
		}

		// Token: 0x0600E9CE RID: 59854 RVA: 0x003EB9B0 File Offset: 0x003E9BB0
		private void __callDele_EventOnSendAllFriendshipPoint()
		{
			Action eventOnSendAllFriendshipPoint = this.EventOnSendAllFriendshipPoint;
			if (eventOnSendAllFriendshipPoint != null)
			{
				eventOnSendAllFriendshipPoint();
			}
		}

		// Token: 0x0600E9CF RID: 59855 RVA: 0x003EB9D0 File Offset: 0x003E9BD0
		private void __clearDele_EventOnSendAllFriendshipPoint()
		{
			this.EventOnSendAllFriendshipPoint = null;
		}

		// Token: 0x0600E9D0 RID: 59856 RVA: 0x003EB9DC File Offset: 0x003E9BDC
		private void __callDele_EventOnGetAllFriendshipPoint()
		{
			Action eventOnGetAllFriendshipPoint = this.EventOnGetAllFriendshipPoint;
			if (eventOnGetAllFriendshipPoint != null)
			{
				eventOnGetAllFriendshipPoint();
			}
		}

		// Token: 0x0600E9D1 RID: 59857 RVA: 0x003EB9FC File Offset: 0x003E9BFC
		private void __clearDele_EventOnGetAllFriendshipPoint()
		{
			this.EventOnGetAllFriendshipPoint = null;
		}

		// Token: 0x0600E9D2 RID: 59858 RVA: 0x003EBA08 File Offset: 0x003E9C08
		private void __callDele_EventOnGetRecommendFriendsList()
		{
			Action eventOnGetRecommendFriendsList = this.EventOnGetRecommendFriendsList;
			if (eventOnGetRecommendFriendsList != null)
			{
				eventOnGetRecommendFriendsList();
			}
		}

		// Token: 0x0600E9D3 RID: 59859 RVA: 0x003EBA28 File Offset: 0x003E9C28
		private void __clearDele_EventOnGetRecommendFriendsList()
		{
			this.EventOnGetRecommendFriendsList = null;
		}

		// Token: 0x0600E9D4 RID: 59860 RVA: 0x003EBA34 File Offset: 0x003E9C34
		private void __callDele_EventOnFriendApplyAceept(List<string> obj)
		{
			Action<List<string>> eventOnFriendApplyAceept = this.EventOnFriendApplyAceept;
			if (eventOnFriendApplyAceept != null)
			{
				eventOnFriendApplyAceept(obj);
			}
		}

		// Token: 0x0600E9D5 RID: 59861 RVA: 0x003EBA58 File Offset: 0x003E9C58
		private void __clearDele_EventOnFriendApplyAceept(List<string> obj)
		{
			this.EventOnFriendApplyAceept = null;
		}

		// Token: 0x0600E9D6 RID: 59862 RVA: 0x003EBA64 File Offset: 0x003E9C64
		private void __callDele_EventOnFriendApplyDecline(List<string> obj)
		{
			Action<List<string>> eventOnFriendApplyDecline = this.EventOnFriendApplyDecline;
			if (eventOnFriendApplyDecline != null)
			{
				eventOnFriendApplyDecline(obj);
			}
		}

		// Token: 0x0600E9D7 RID: 59863 RVA: 0x003EBA88 File Offset: 0x003E9C88
		private void __clearDele_EventOnFriendApplyDecline(List<string> obj)
		{
			this.EventOnFriendApplyDecline = null;
		}

		// Token: 0x0600E9D8 RID: 59864 RVA: 0x003EBA94 File Offset: 0x003E9C94
		private void __callDele_EventOnShowPlayerSimpleInfo(UserSummary arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
		{
			Action<UserSummary, Vector3, PlayerSimpleInfoUITask.PostionType> eventOnShowPlayerSimpleInfo = this.EventOnShowPlayerSimpleInfo;
			if (eventOnShowPlayerSimpleInfo != null)
			{
				eventOnShowPlayerSimpleInfo(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600E9D9 RID: 59865 RVA: 0x003EBAB8 File Offset: 0x003E9CB8
		private void __clearDele_EventOnShowPlayerSimpleInfo(UserSummary arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
		{
			this.EventOnShowPlayerSimpleInfo = null;
		}

		// Token: 0x0600E9DA RID: 59866 RVA: 0x003EBAC4 File Offset: 0x003E9CC4
		private void __callDele_EventOnGroupChat(string obj)
		{
			Action<string> eventOnGroupChat = this.EventOnGroupChat;
			if (eventOnGroupChat != null)
			{
				eventOnGroupChat(obj);
			}
		}

		// Token: 0x0600E9DB RID: 59867 RVA: 0x003EBAE8 File Offset: 0x003E9CE8
		private void __clearDele_EventOnGroupChat(string obj)
		{
			this.EventOnGroupChat = null;
		}

		// Token: 0x0600E9DC RID: 59868 RVA: 0x003EBAF4 File Offset: 0x003E9CF4
		private void __callDele_EventOnWatchGroupStaff(string arg1, bool arg2)
		{
			Action<string, bool> eventOnWatchGroupStaff = this.EventOnWatchGroupStaff;
			if (eventOnWatchGroupStaff != null)
			{
				eventOnWatchGroupStaff(arg1, arg2);
			}
		}

		// Token: 0x0600E9DD RID: 59869 RVA: 0x003EBB18 File Offset: 0x003E9D18
		private void __clearDele_EventOnWatchGroupStaff(string arg1, bool arg2)
		{
			this.EventOnWatchGroupStaff = null;
		}

		// Token: 0x0600E9DE RID: 59870 RVA: 0x003EBB24 File Offset: 0x003E9D24
		private void __callDele_EventOnCreateNewGroup(List<string> obj)
		{
			Action<List<string>> eventOnCreateNewGroup = this.EventOnCreateNewGroup;
			if (eventOnCreateNewGroup != null)
			{
				eventOnCreateNewGroup(obj);
			}
		}

		// Token: 0x0600E9DF RID: 59871 RVA: 0x003EBB48 File Offset: 0x003E9D48
		private void __clearDele_EventOnCreateNewGroup(List<string> obj)
		{
			this.EventOnCreateNewGroup = null;
		}

		// Token: 0x0600E9E0 RID: 59872 RVA: 0x003EBB54 File Offset: 0x003E9D54
		private void __callDele_EventOnInviteFriendToGroup(string arg1, List<string> arg2)
		{
			Action<string, List<string>> eventOnInviteFriendToGroup = this.EventOnInviteFriendToGroup;
			if (eventOnInviteFriendToGroup != null)
			{
				eventOnInviteFriendToGroup(arg1, arg2);
			}
		}

		// Token: 0x0600E9E1 RID: 59873 RVA: 0x003EBB78 File Offset: 0x003E9D78
		private void __clearDele_EventOnInviteFriendToGroup(string arg1, List<string> arg2)
		{
			this.EventOnInviteFriendToGroup = null;
		}

		// Token: 0x0600E9E2 RID: 59874 RVA: 0x003EBB84 File Offset: 0x003E9D84
		private void __callDele_EventOnChangeGroupName(string arg1, string arg2)
		{
			Action<string, string> eventOnChangeGroupName = this.EventOnChangeGroupName;
			if (eventOnChangeGroupName != null)
			{
				eventOnChangeGroupName(arg1, arg2);
			}
		}

		// Token: 0x0600E9E3 RID: 59875 RVA: 0x003EBBA8 File Offset: 0x003E9DA8
		private void __clearDele_EventOnChangeGroupName(string arg1, string arg2)
		{
			this.EventOnChangeGroupName = null;
		}

		// Token: 0x0600E9E4 RID: 59876 RVA: 0x003EBBB4 File Offset: 0x003E9DB4
		private void __callDele_EventOnLeaveGroup(ProChatGroupInfo obj)
		{
			Action<ProChatGroupInfo> eventOnLeaveGroup = this.EventOnLeaveGroup;
			if (eventOnLeaveGroup != null)
			{
				eventOnLeaveGroup(obj);
			}
		}

		// Token: 0x0600E9E5 RID: 59877 RVA: 0x003EBBD8 File Offset: 0x003E9DD8
		private void __clearDele_EventOnLeaveGroup(ProChatGroupInfo obj)
		{
			this.EventOnLeaveGroup = null;
		}

		// Token: 0x0600E9E7 RID: 59879 RVA: 0x003EBBF8 File Offset: 0x003E9DF8
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
					this.m_SetFriendPanelList`1_hotfix = (luaObj.RawGet("SetFriendPanel") as LuaFunction);
					this.m_SetAcrossServerFriendPanelList`1_hotfix = (luaObj.RawGet("SetAcrossServerFriendPanel") as LuaFunction);
					this.m_SetRecentPanelList`1_hotfix = (luaObj.RawGet("SetRecentPanel") as LuaFunction);
					this.m_SetGroupPanelList`1_hotfix = (luaObj.RawGet("SetGroupPanel") as LuaFunction);
					this.m_SetAddFriendPanel_hotfix = (luaObj.RawGet("SetAddFriendPanel") as LuaFunction);
					this.m_SetFirstToggleOn_hotfix = (luaObj.RawGet("SetFirstToggleOn") as LuaFunction);
					this.m_SetPanelScrollViewReset_hotfix = (luaObj.RawGet("SetPanelScrollViewReset") as LuaFunction);
					this.m_IsAddFriendRedMarkShowBoolean_hotfix = (luaObj.RawGet("IsAddFriendRedMarkShow") as LuaFunction);
					this.m_ShowFriendShipPointTipString_hotfix = (luaObj.RawGet("ShowFriendShipPointTip") as LuaFunction);
					this.m_SetShieldPanelList`1_hotfix = (luaObj.RawGet("SetShieldPanel") as LuaFunction);
					this.m_SetFindFriendListList`1_hotfix = (luaObj.RawGet("SetFindFriendList") as LuaFunction);
					this.m_SetRecommendFriendsListList`1_hotfix = (luaObj.RawGet("SetRecommendFriendsList") as LuaFunction);
					this.m_SetApplyFriendsListList`1_hotfix = (luaObj.RawGet("SetApplyFriendsList") as LuaFunction);
					this.m_SetInviteFriendToGroupPanel_hotfix = (luaObj.RawGet("SetInviteFriendToGroupPanel") as LuaFunction);
					this.m_SetInviteFriendToGroupList_hotfix = (luaObj.RawGet("SetInviteFriendToGroupList") as LuaFunction);
					this.m_SetInviteAcrossServerFriendToGroupList_hotfix = (luaObj.RawGet("SetInviteAcrossServerFriendToGroupList") as LuaFunction);
					this.m_SetWatchGroupStaffPanelProChatGroupInfoBoolean_hotfix = (luaObj.RawGet("SetWatchGroupStaffPanel") as LuaFunction);
					this.m_SetBasicBigFriendInfoGameObjectList`1FriendInfoTypeBoolean_hotfix = (luaObj.RawGet("SetBasicBigFriendInfo") as LuaFunction);
					this.m_SetBasicSmallFriendInfoGameObjectList`1FriendInfoType_hotfix = (luaObj.RawGet("SetBasicSmallFriendInfo") as LuaFunction);
					this.m_SetServerListInfo_hotfix = (luaObj.RawGet("SetServerListInfo") as LuaFunction);
					this.m_OnFriendToggleBoolean_hotfix = (luaObj.RawGet("OnFriendToggle") as LuaFunction);
					this.m_OnAcrossServerToggleBoolean_hotfix = (luaObj.RawGet("OnAcrossServerToggle") as LuaFunction);
					this.m_OnRecentToggleBoolean_hotfix = (luaObj.RawGet("OnRecentToggle") as LuaFunction);
					this.m_OnGroupToggleBoolean_hotfix = (luaObj.RawGet("OnGroupToggle") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnShieldButtonClick_hotfix = (luaObj.RawGet("OnShieldButtonClick") as LuaFunction);
					this.m_OnShieldPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnShieldPanelCloseButtonClick") as LuaFunction);
					this.m_OnSendAllFriendshipPointButtonClick_hotfix = (luaObj.RawGet("OnSendAllFriendshipPointButtonClick") as LuaFunction);
					this.m_OnGetAllFriendshipPointButtonClick_hotfix = (luaObj.RawGet("OnGetAllFriendshipPointButtonClick") as LuaFunction);
					this.m_OnAddFriendButtonClick_hotfix = (luaObj.RawGet("OnAddFriendButtonClick") as LuaFunction);
					this.m_OnAddFriendPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnAddFriendPanelCloseButtonClick") as LuaFunction);
					this.m_OnSelectServerButtonClick_hotfix = (luaObj.RawGet("OnSelectServerButtonClick") as LuaFunction);
					this.m_OnServerListPanelBGButtonClick_hotfix = (luaObj.RawGet("OnServerListPanelBGButtonClick") as LuaFunction);
					this.m_SetSendAllFriendshipPointButtonState_hotfix = (luaObj.RawGet("SetSendAllFriendshipPointButtonState") as LuaFunction);
					this.m_SetGetAllFriendshipPointButtonState_hotfix = (luaObj.RawGet("SetGetAllFriendshipPointButtonState") as LuaFunction);
					this.m_OnAddFriendPanelSearchButtonClick_hotfix = (luaObj.RawGet("OnAddFriendPanelSearchButtonClick") as LuaFunction);
					this.m_OnAddFriendPanelChangeRecommendFriendButtonClick_hotfix = (luaObj.RawGet("OnAddFriendPanelChangeRecommendFriendButtonClick") as LuaFunction);
					this.m_OnAddFriendPanelAddAllButtonClick_hotfix = (luaObj.RawGet("OnAddFriendPanelAddAllButtonClick") as LuaFunction);
					this.m_OnAddFriendPanelAcceptAllButtonClick_hotfix = (luaObj.RawGet("OnAddFriendPanelAcceptAllButtonClick") as LuaFunction);
					this.m_OnAddFriendPanelRefuseAllButtonClick_hotfix = (luaObj.RawGet("OnAddFriendPanelRefuseAllButtonClick") as LuaFunction);
					this.m_OnWatchGroupStaffPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnWatchGroupStaffPanelCloseButtonClick") as LuaFunction);
					this.m_WatchGroupStaffPanelClose_hotfix = (luaObj.RawGet("WatchGroupStaffPanelClose") as LuaFunction);
					this.m_GroupDissolvedProChatGroupInfo_hotfix = (luaObj.RawGet("GroupDissolved") as LuaFunction);
					this.m_OnWatchGroupStaffPanelChangeNameButtonClick_hotfix = (luaObj.RawGet("OnWatchGroupStaffPanelChangeNameButtonClick") as LuaFunction);
					this.m_OnWatchGroupStaffPanelChangeNamePanelBGButtonClick_hotfix = (luaObj.RawGet("OnWatchGroupStaffPanelChangeNamePanelBGButtonClick") as LuaFunction);
					this.m_OnWatchGroupStaffPanelChangeNameConfirmButtonClick_hotfix = (luaObj.RawGet("OnWatchGroupStaffPanelChangeNameConfirmButtonClick") as LuaFunction);
					this.m_OnQuitGroupButtonClick_hotfix = (luaObj.RawGet("OnQuitGroupButtonClick") as LuaFunction);
					this.m_OnCreateNewGroupButtonClick_hotfix = (luaObj.RawGet("OnCreateNewGroupButtonClick") as LuaFunction);
					this.m_OnInviteFriendToGroupButtonClick_hotfix = (luaObj.RawGet("OnInviteFriendToGroupButtonClick") as LuaFunction);
					this.m_InviteFriendToGoupPanelClose_hotfix = (luaObj.RawGet("InviteFriendToGoupPanelClose") as LuaFunction);
					this.m_OnInviteFriendToGoupPanelConfirmButtonClick_hotfix = (luaObj.RawGet("OnInviteFriendToGoupPanelConfirmButtonClick") as LuaFunction);
					this.m_OnInviteFriendToGroupPanelServerFriendToggleBoolean_hotfix = (luaObj.RawGet("OnInviteFriendToGroupPanelServerFriendToggle") as LuaFunction);
					this.m_OnInviteFriendToGroupPanelFriendToggleBoolean_hotfix = (luaObj.RawGet("OnInviteFriendToGroupPanelFriendToggle") as LuaFunction);
					this.m_OnPlayerItemButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnPlayerItemButtonClick") as LuaFunction);
					this.m_OnPlayerItemButtonClickFriendSmallItemUIController_hotfix = (luaObj.RawGet("OnPlayerItemButtonClick") as LuaFunction);
					this.m_OnItemAddFriendButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnItemAddFriendButtonClick") as LuaFunction);
					this.m_OnItemKickFromGroupButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnItemKickFromGroupButtonClick") as LuaFunction);
					this.m_OnUnblockPlayerButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnUnblockPlayerButtonClick") as LuaFunction);
					this.m_OnChatButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnSendFriendshipPointButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnSendFriendshipPointButtonClick") as LuaFunction);
					this.m_OnGetFriendshipPointButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnGetFriendshipPointButtonClick") as LuaFunction);
					this.m_OnFriendshipPointDoneButtonClickFriendBigItemUIController_hotfix = (luaObj.RawGet("OnFriendshipPointDoneButtonClick") as LuaFunction);
					this.m_OnItemAddFriendButtonClickFriendSmallItemUIController_hotfix = (luaObj.RawGet("OnItemAddFriendButtonClick") as LuaFunction);
					this.m_OnChatButtonClickFriendSmallItemUIController_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnFriendApplyAceeptButtonClickFriendSmallItemUIController_hotfix = (luaObj.RawGet("OnFriendApplyAceeptButtonClick") as LuaFunction);
					this.m_OnFriendApplyDeclineButtonClickFriendSmallItemUIController_hotfix = (luaObj.RawGet("OnFriendApplyDeclineButtonClick") as LuaFunction);
					this.m_OnInviteFriendToGroupToggleValueChangedBooleanFriendSmallItemUIController_hotfix = (luaObj.RawGet("OnInviteFriendToGroupToggleValueChanged") as LuaFunction);
					this.m_OnGroupChatButtonClickFriendGroupUIController_hotfix = (luaObj.RawGet("OnGroupChatButtonClick") as LuaFunction);
					this.m_OnWatchGroupStaffButtonClickFriendGroupUIController_hotfix = (luaObj.RawGet("OnWatchGroupStaffButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnShowPanelAction`1_hotfix = (luaObj.RawGet("add_EventOnShowPanel") as LuaFunction);
					this.m_remove_EventOnShowPanelAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowPanel") as LuaFunction);
					this.m_add_EventOnAddFriendAction`1_hotfix = (luaObj.RawGet("add_EventOnAddFriend") as LuaFunction);
					this.m_remove_EventOnAddFriendAction`1_hotfix = (luaObj.RawGet("remove_EventOnAddFriend") as LuaFunction);
					this.m_add_EventOnKickFromGroupAction`2_hotfix = (luaObj.RawGet("add_EventOnKickFromGroup") as LuaFunction);
					this.m_remove_EventOnKickFromGroupAction`2_hotfix = (luaObj.RawGet("remove_EventOnKickFromGroup") as LuaFunction);
					this.m_add_EventOnUnblockPlayerAction`1_hotfix = (luaObj.RawGet("add_EventOnUnblockPlayer") as LuaFunction);
					this.m_remove_EventOnUnblockPlayerAction`1_hotfix = (luaObj.RawGet("remove_EventOnUnblockPlayer") as LuaFunction);
					this.m_add_EventOnChatAction`1_hotfix = (luaObj.RawGet("add_EventOnChat") as LuaFunction);
					this.m_remove_EventOnChatAction`1_hotfix = (luaObj.RawGet("remove_EventOnChat") as LuaFunction);
					this.m_add_EventOnSendFriendshipPointAction`1_hotfix = (luaObj.RawGet("add_EventOnSendFriendshipPoint") as LuaFunction);
					this.m_remove_EventOnSendFriendshipPointAction`1_hotfix = (luaObj.RawGet("remove_EventOnSendFriendshipPoint") as LuaFunction);
					this.m_add_EventOnGetFriendshipPointAction`1_hotfix = (luaObj.RawGet("add_EventOnGetFriendshipPoint") as LuaFunction);
					this.m_remove_EventOnGetFriendshipPointAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetFriendshipPoint") as LuaFunction);
					this.m_add_EventOnFindFriendAction`2_hotfix = (luaObj.RawGet("add_EventOnFindFriend") as LuaFunction);
					this.m_remove_EventOnFindFriendAction`2_hotfix = (luaObj.RawGet("remove_EventOnFindFriend") as LuaFunction);
					this.m_add_EventOnSendAllFriendshipPointAction_hotfix = (luaObj.RawGet("add_EventOnSendAllFriendshipPoint") as LuaFunction);
					this.m_remove_EventOnSendAllFriendshipPointAction_hotfix = (luaObj.RawGet("remove_EventOnSendAllFriendshipPoint") as LuaFunction);
					this.m_add_EventOnGetAllFriendshipPointAction_hotfix = (luaObj.RawGet("add_EventOnGetAllFriendshipPoint") as LuaFunction);
					this.m_remove_EventOnGetAllFriendshipPointAction_hotfix = (luaObj.RawGet("remove_EventOnGetAllFriendshipPoint") as LuaFunction);
					this.m_add_EventOnGetRecommendFriendsListAction_hotfix = (luaObj.RawGet("add_EventOnGetRecommendFriendsList") as LuaFunction);
					this.m_remove_EventOnGetRecommendFriendsListAction_hotfix = (luaObj.RawGet("remove_EventOnGetRecommendFriendsList") as LuaFunction);
					this.m_add_EventOnFriendApplyAceeptAction`1_hotfix = (luaObj.RawGet("add_EventOnFriendApplyAceept") as LuaFunction);
					this.m_remove_EventOnFriendApplyAceeptAction`1_hotfix = (luaObj.RawGet("remove_EventOnFriendApplyAceept") as LuaFunction);
					this.m_add_EventOnFriendApplyDeclineAction`1_hotfix = (luaObj.RawGet("add_EventOnFriendApplyDecline") as LuaFunction);
					this.m_remove_EventOnFriendApplyDeclineAction`1_hotfix = (luaObj.RawGet("remove_EventOnFriendApplyDecline") as LuaFunction);
					this.m_add_EventOnShowPlayerSimpleInfoAction`3_hotfix = (luaObj.RawGet("add_EventOnShowPlayerSimpleInfo") as LuaFunction);
					this.m_remove_EventOnShowPlayerSimpleInfoAction`3_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerSimpleInfo") as LuaFunction);
					this.m_add_EventOnGroupChatAction`1_hotfix = (luaObj.RawGet("add_EventOnGroupChat") as LuaFunction);
					this.m_remove_EventOnGroupChatAction`1_hotfix = (luaObj.RawGet("remove_EventOnGroupChat") as LuaFunction);
					this.m_add_EventOnWatchGroupStaffAction`2_hotfix = (luaObj.RawGet("add_EventOnWatchGroupStaff") as LuaFunction);
					this.m_remove_EventOnWatchGroupStaffAction`2_hotfix = (luaObj.RawGet("remove_EventOnWatchGroupStaff") as LuaFunction);
					this.m_add_EventOnCreateNewGroupAction`1_hotfix = (luaObj.RawGet("add_EventOnCreateNewGroup") as LuaFunction);
					this.m_remove_EventOnCreateNewGroupAction`1_hotfix = (luaObj.RawGet("remove_EventOnCreateNewGroup") as LuaFunction);
					this.m_add_EventOnInviteFriendToGroupAction`2_hotfix = (luaObj.RawGet("add_EventOnInviteFriendToGroup") as LuaFunction);
					this.m_remove_EventOnInviteFriendToGroupAction`2_hotfix = (luaObj.RawGet("remove_EventOnInviteFriendToGroup") as LuaFunction);
					this.m_add_EventOnChangeGroupNameAction`2_hotfix = (luaObj.RawGet("add_EventOnChangeGroupName") as LuaFunction);
					this.m_remove_EventOnChangeGroupNameAction`2_hotfix = (luaObj.RawGet("remove_EventOnChangeGroupName") as LuaFunction);
					this.m_add_EventOnLeaveGroupAction`1_hotfix = (luaObj.RawGet("add_EventOnLeaveGroup") as LuaFunction);
					this.m_remove_EventOnLeaveGroupAction`1_hotfix = (luaObj.RawGet("remove_EventOnLeaveGroup") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E9E8 RID: 59880 RVA: 0x003EC7E8 File Offset: 0x003EA9E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008C11 RID: 35857
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04008C12 RID: 35858
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008C13 RID: 35859
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04008C14 RID: 35860
		[AutoBind("./Panel/ShieldButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_shieldButton;

		// Token: 0x04008C15 RID: 35861
		[AutoBind("./Panel/AddFriendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendButton;

		// Token: 0x04008C16 RID: 35862
		[AutoBind("./Panel/AddFriendButton/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendRedMark;

		// Token: 0x04008C17 RID: 35863
		[AutoBind("./Panel/CreateNewGroupButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_createNewGroupButton;

		// Token: 0x04008C18 RID: 35864
		[AutoBind("./FriendPanelTypeCount", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_friendCountUIStateController;

		// Token: 0x04008C19 RID: 35865
		[AutoBind("./FriendPanelTypeCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendTypeCount;

		// Token: 0x04008C1A RID: 35866
		[AutoBind("./Panel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_panelUIStateController;

		// Token: 0x04008C1B RID: 35867
		[AutoBind("./FriendShipPointTip", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_friendShipPointTipStateCtrl;

		// Token: 0x04008C1C RID: 35868
		[AutoBind("./FriendShipPointTip/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendShipPointTipText;

		// Token: 0x04008C1D RID: 35869
		[AutoBind("./Panel/GetAllFriendshipPointButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getAllFriendshipPointButton;

		// Token: 0x04008C1E RID: 35870
		[AutoBind("./Panel/GetAllFriendshipPointButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_getAllFriendshipPointButtonUIStateCtrl;

		// Token: 0x04008C1F RID: 35871
		[AutoBind("./Panel/SendAllFriendshipPointButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sendAllFriendshipPointButton;

		// Token: 0x04008C20 RID: 35872
		[AutoBind("./Panel/SendAllFriendshipPointButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sendAllFriendshipPointButtonUIStateCtrl;

		// Token: 0x04008C21 RID: 35873
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Friend", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_friendToggle;

		// Token: 0x04008C22 RID: 35874
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Server", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_acrossServerToggle;

		// Token: 0x04008C23 RID: 35875
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Recent", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_recentToggle;

		// Token: 0x04008C24 RID: 35876
		[AutoBind("./Margin/ToggleListGroup/FilterButtons/Group", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_groupToggle;

		// Token: 0x04008C25 RID: 35877
		[AutoBind("./AddFriendPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_addFriendPanelUIStateController;

		// Token: 0x04008C26 RID: 35878
		[AutoBind("./AddFriendPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendPanelCloseButton;

		// Token: 0x04008C27 RID: 35879
		[AutoBind("./AddFriendPanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendPanelBackgroundButton;

		// Token: 0x04008C28 RID: 35880
		[AutoBind("./AddFriendPanel/Detail/ServerSelectButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendPanelSelectServerButton;

		// Token: 0x04008C29 RID: 35881
		[AutoBind("./AddFriendPanel/Detail/ServerSelectButton/ServerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addFriendPanelServerNameText;

		// Token: 0x04008C2A RID: 35882
		[AutoBind("./AddFriendPanel/Detail/SearchButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendPanelSearchButton;

		// Token: 0x04008C2B RID: 35883
		[AutoBind("./AddFriendPanel/Detail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_addFriendPanelInputText;

		// Token: 0x04008C2C RID: 35884
		[AutoBind("./AddFriendPanel/Detail/ChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendPanelChangeButton;

		// Token: 0x04008C2D RID: 35885
		[AutoBind("./AddFriendPanel/Detail/AllRefuseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addFriendPanelRefuseAllButton;

		// Token: 0x04008C2E RID: 35886
		[AutoBind("./AddFriendPanel/Detail/RecommendListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelRecommendScrollView;

		// Token: 0x04008C2F RID: 35887
		[AutoBind("./AddFriendPanel/Detail/RecommendListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelRecommendScrollViewContent;

		// Token: 0x04008C30 RID: 35888
		[AutoBind("./AddFriendPanel/Detail/ApplyListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelApplyScrollView;

		// Token: 0x04008C31 RID: 35889
		[AutoBind("./AddFriendPanel/Detail/ApplyListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelApplyScrollViewContent;

		// Token: 0x04008C32 RID: 35890
		[AutoBind("/AddFriendPanel/Detail/RecommendText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelRecommendTextGameObject;

		// Token: 0x04008C33 RID: 35891
		[AutoBind("/AddFriendPanel/Detail/FindFriendText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelFindFriendTextGameObject;

		// Token: 0x04008C34 RID: 35892
		[AutoBind("./AddFriendPanel/Detail/NotFound", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_addFriendPanelNotFindFriendGameObject;

		// Token: 0x04008C35 RID: 35893
		[AutoBind("./AddFriendPanel/ServerListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_serverListPanelUIStateController;

		// Token: 0x04008C36 RID: 35894
		[AutoBind("./AddFriendPanel/ServerListPanel/Prefab/ServerItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_serverItemGameObject;

		// Token: 0x04008C37 RID: 35895
		[AutoBind("./AddFriendPanel/ServerListPanel/Prefab/ServerItem/ServerNameGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_serverItemName;

		// Token: 0x04008C38 RID: 35896
		[AutoBind("./AddFriendPanel/ServerListPanel/Detail/ServerScrollView/Viewport/Content/ServerListGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_serverListGroup;

		// Token: 0x04008C39 RID: 35897
		[AutoBind("./AddFriendPanel/ServerListPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_serverListPanelBGButton;

		// Token: 0x04008C3A RID: 35898
		[AutoBind("./WatchGroupStaffPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_watchGroupStaffPanelUIStateController;

		// Token: 0x04008C3B RID: 35899
		[AutoBind("./WatchGroupStaffPanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchGroupStaffPanelBackgroundButton;

		// Token: 0x04008C3C RID: 35900
		[AutoBind("./WatchGroupStaffPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchGroupStaffPanelCloseButton;

		// Token: 0x04008C3D RID: 35901
		[AutoBind("./WatchGroupStaffPanel/Detail/ChangeNameButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchGroupStaffPanelChangeGroupNameButton;

		// Token: 0x04008C3E RID: 35902
		[AutoBind("./WatchGroupStaffPanel/Detail/QuitGroupButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchGroupStaffPanelQuitGroupButton;

		// Token: 0x04008C3F RID: 35903
		[AutoBind("./WatchGroupStaffPanel/Detail/InviteFriendButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchGroupStaffPanelInviteFriendButton;

		// Token: 0x04008C40 RID: 35904
		[AutoBind("./WatchGroupStaffPanel/Detail/PlayerListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_watchGroupStaffPanelScrollView;

		// Token: 0x04008C41 RID: 35905
		[AutoBind("./WatchGroupStaffPanel/Detail/PlayerListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_watchGroupStaffPanelScrollViewContent;

		// Token: 0x04008C42 RID: 35906
		[AutoBind("./WatchGroupStaffPanel/Detail/GroupStaffCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_watchGroupStaffPanelCountText;

		// Token: 0x04008C43 RID: 35907
		[AutoBind("./WatchGroupStaffPanel/Detail/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_groupTitleName;

		// Token: 0x04008C44 RID: 35908
		[AutoBind("./WatchGroupStaffPanel/ChangeNamePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_changeGroupNameUIStateController;

		// Token: 0x04008C45 RID: 35909
		[AutoBind("./WatchGroupStaffPanel/ChangeNamePanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeGroupNameBackgroundButton;

		// Token: 0x04008C46 RID: 35910
		[AutoBind("./WatchGroupStaffPanel/ChangeNamePanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeGroupNameConfirmButton;

		// Token: 0x04008C47 RID: 35911
		[AutoBind("./WatchGroupStaffPanel/ChangeNamePanel/Detail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_changeNamePanelInputField;

		// Token: 0x04008C48 RID: 35912
		[AutoBind("./InviteFriendPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_inviteFriendToGroupPanelUIStateController;

		// Token: 0x04008C49 RID: 35913
		[AutoBind("./InviteFriendPanel/Detail/PlayerListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_inviteFriendToGroupPanelScrollView;

		// Token: 0x04008C4A RID: 35914
		[AutoBind("./InviteFriendPanel/Detail/PlayerListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_inviteFriendToGroupPanelScrollViewContent;

		// Token: 0x04008C4B RID: 35915
		[AutoBind("./InviteFriendPanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteFriendToGroupPanelConfirmButton;

		// Token: 0x04008C4C RID: 35916
		[AutoBind("./InviteFriendPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteFriendToGroupPanelCancelButton;

		// Token: 0x04008C4D RID: 35917
		[AutoBind("./InviteFriendPanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteFriendToGroupPanelBackgroundButton;

		// Token: 0x04008C4E RID: 35918
		[AutoBind("./InviteFriendPanel/Detail/InvitedCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteFriendToGroupPanelCountText;

		// Token: 0x04008C4F RID: 35919
		[AutoBind("./InviteFriendPanel/Detail/ToggleGroup/ServerFriend", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_inviteFriendToGroupPanelServerFriendToggle;

		// Token: 0x04008C50 RID: 35920
		[AutoBind("./InviteFriendPanel/Detail/ToggleGroup/Friend", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_inviteFriendToGroupPanelFriendToggle;

		// Token: 0x04008C51 RID: 35921
		[AutoBind("./ShieldPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_shieldPanelUIStateController;

		// Token: 0x04008C52 RID: 35922
		[AutoBind("./ShieldPanel/Detail/PlayListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_shieldPanelScrollView;

		// Token: 0x04008C53 RID: 35923
		[AutoBind("./ShieldPanel/Detail/PlayListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_shieldPanelScrollViewContent;

		// Token: 0x04008C54 RID: 35924
		[AutoBind("./ShieldPanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_shieldPanelBackgroundButton;

		// Token: 0x04008C55 RID: 35925
		[AutoBind("./ShieldPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_shieldPanelCloseButton;

		// Token: 0x04008C56 RID: 35926
		[AutoBind("./ShieldPanel/Detail/ShieldCount/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_shieldPanelShieldCount;

		// Token: 0x04008C57 RID: 35927
		[AutoBind("./Panel/FriendListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_friendScrollView;

		// Token: 0x04008C58 RID: 35928
		[AutoBind("./Panel/FriendListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_friendScrollViewContent;

		// Token: 0x04008C59 RID: 35929
		[AutoBind("./Panel/GroupListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_groupScrollView;

		// Token: 0x04008C5A RID: 35930
		[AutoBind("./Panel/GroupListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_groupScrollViewContent;

		// Token: 0x04008C5B RID: 35931
		[AutoBind("./Prefab/PlayerBigListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_friendBigItemPrefab;

		// Token: 0x04008C5C RID: 35932
		[AutoBind("./Prefab/PlayerSmallListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_friendSmallItemPrefab;

		// Token: 0x04008C5D RID: 35933
		[AutoBind("./Prefab/GroupListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_groupItemPrefab;

		// Token: 0x04008C5E RID: 35934
		private int m_currentServerID;

		// Token: 0x04008C5F RID: 35935
		private ProChatGroupInfo m_currentChatGroupInfo;

		// Token: 0x04008C60 RID: 35936
		private bool m_isCreateNewGroup;

		// Token: 0x04008C61 RID: 35937
		private const int m_maxInviteToGroupCount = 10;

		// Token: 0x04008C62 RID: 35938
		public bool m_isFindFriend;

		// Token: 0x04008C63 RID: 35939
		public bool m_isRecommendFriend;

		// Token: 0x04008C64 RID: 35940
		private List<UserSummary> m_recommendFriendList = new List<UserSummary>();

		// Token: 0x04008C65 RID: 35941
		private List<UserSummary> m_applyFriendList = new List<UserSummary>();

		// Token: 0x04008C66 RID: 35942
		private List<string> m_inviteToGroupList = new List<string>();

		// Token: 0x04008C67 RID: 35943
		private List<UserSummary> m_groupStaffList = new List<UserSummary>();

		// Token: 0x04008C68 RID: 35944
		private List<string> m_friendApplyAcceptList = new List<string>();

		// Token: 0x04008C69 RID: 35945
		private List<string> m_friendApplyDeclineList = new List<string>();

		// Token: 0x04008C6A RID: 35946
		private List<string> m_friendAddList = new List<string>();

		// Token: 0x04008C6B RID: 35947
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04008C6C RID: 35948
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04008C6D RID: 35949
		[DoNotToLua]
		private FriendUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008C6E RID: 35950
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008C6F RID: 35951
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008C70 RID: 35952
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008C71 RID: 35953
		private LuaFunction m_SetFriendPanelList;

		// Token: 0x04008C72 RID: 35954
		private LuaFunction m_SetAcrossServerFriendPanelList;

		// Token: 0x04008C73 RID: 35955
		private LuaFunction m_SetRecentPanelList;

		// Token: 0x04008C74 RID: 35956
		private LuaFunction m_SetGroupPanelList;

		// Token: 0x04008C75 RID: 35957
		private LuaFunction m_SetAddFriendPanel_hotfix;

		// Token: 0x04008C76 RID: 35958
		private LuaFunction m_SetFirstToggleOn_hotfix;

		// Token: 0x04008C77 RID: 35959
		private LuaFunction m_SetPanelScrollViewReset_hotfix;

		// Token: 0x04008C78 RID: 35960
		private LuaFunction m_IsAddFriendRedMarkShowBoolean_hotfix;

		// Token: 0x04008C79 RID: 35961
		private LuaFunction m_ShowFriendShipPointTipString_hotfix;

		// Token: 0x04008C7A RID: 35962
		private LuaFunction m_SetShieldPanelList;

		// Token: 0x04008C7B RID: 35963
		private LuaFunction m_SetFindFriendListList;

		// Token: 0x04008C7C RID: 35964
		private LuaFunction m_SetRecommendFriendsListList;

		// Token: 0x04008C7D RID: 35965
		private LuaFunction m_SetApplyFriendsListList;

		// Token: 0x04008C7E RID: 35966
		private LuaFunction m_SetInviteFriendToGroupPanel_hotfix;

		// Token: 0x04008C7F RID: 35967
		private LuaFunction m_SetInviteFriendToGroupList_hotfix;

		// Token: 0x04008C80 RID: 35968
		private LuaFunction m_SetInviteAcrossServerFriendToGroupList_hotfix;

		// Token: 0x04008C81 RID: 35969
		private LuaFunction m_SetWatchGroupStaffPanelProChatGroupInfoBoolean_hotfix;

		// Token: 0x04008C82 RID: 35970
		private LuaFunction m_SetBasicBigFriendInfoGameObjectList;

		// Token: 0x04008C83 RID: 35971
		private LuaFunction m_SetBasicSmallFriendInfoGameObjectList;

		// Token: 0x04008C84 RID: 35972
		private LuaFunction m_SetServerListInfo_hotfix;

		// Token: 0x04008C85 RID: 35973
		private LuaFunction m_OnFriendToggleBoolean_hotfix;

		// Token: 0x04008C86 RID: 35974
		private LuaFunction m_OnAcrossServerToggleBoolean_hotfix;

		// Token: 0x04008C87 RID: 35975
		private LuaFunction m_OnRecentToggleBoolean_hotfix;

		// Token: 0x04008C88 RID: 35976
		private LuaFunction m_OnGroupToggleBoolean_hotfix;

		// Token: 0x04008C89 RID: 35977
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008C8A RID: 35978
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04008C8B RID: 35979
		private LuaFunction m_OnShieldButtonClick_hotfix;

		// Token: 0x04008C8C RID: 35980
		private LuaFunction m_OnShieldPanelCloseButtonClick_hotfix;

		// Token: 0x04008C8D RID: 35981
		private LuaFunction m_OnSendAllFriendshipPointButtonClick_hotfix;

		// Token: 0x04008C8E RID: 35982
		private LuaFunction m_OnGetAllFriendshipPointButtonClick_hotfix;

		// Token: 0x04008C8F RID: 35983
		private LuaFunction m_OnAddFriendButtonClick_hotfix;

		// Token: 0x04008C90 RID: 35984
		private LuaFunction m_OnAddFriendPanelCloseButtonClick_hotfix;

		// Token: 0x04008C91 RID: 35985
		private LuaFunction m_OnSelectServerButtonClick_hotfix;

		// Token: 0x04008C92 RID: 35986
		private LuaFunction m_OnServerListPanelBGButtonClick_hotfix;

		// Token: 0x04008C93 RID: 35987
		private LuaFunction m_SetSendAllFriendshipPointButtonState_hotfix;

		// Token: 0x04008C94 RID: 35988
		private LuaFunction m_SetGetAllFriendshipPointButtonState_hotfix;

		// Token: 0x04008C95 RID: 35989
		private LuaFunction m_OnAddFriendPanelSearchButtonClick_hotfix;

		// Token: 0x04008C96 RID: 35990
		private LuaFunction m_OnAddFriendPanelChangeRecommendFriendButtonClick_hotfix;

		// Token: 0x04008C97 RID: 35991
		private LuaFunction m_OnAddFriendPanelAddAllButtonClick_hotfix;

		// Token: 0x04008C98 RID: 35992
		private LuaFunction m_OnAddFriendPanelAcceptAllButtonClick_hotfix;

		// Token: 0x04008C99 RID: 35993
		private LuaFunction m_OnAddFriendPanelRefuseAllButtonClick_hotfix;

		// Token: 0x04008C9A RID: 35994
		private LuaFunction m_OnWatchGroupStaffPanelCloseButtonClick_hotfix;

		// Token: 0x04008C9B RID: 35995
		private LuaFunction m_WatchGroupStaffPanelClose_hotfix;

		// Token: 0x04008C9C RID: 35996
		private LuaFunction m_GroupDissolvedProChatGroupInfo_hotfix;

		// Token: 0x04008C9D RID: 35997
		private LuaFunction m_OnWatchGroupStaffPanelChangeNameButtonClick_hotfix;

		// Token: 0x04008C9E RID: 35998
		private LuaFunction m_OnWatchGroupStaffPanelChangeNamePanelBGButtonClick_hotfix;

		// Token: 0x04008C9F RID: 35999
		private LuaFunction m_OnWatchGroupStaffPanelChangeNameConfirmButtonClick_hotfix;

		// Token: 0x04008CA0 RID: 36000
		private LuaFunction m_OnQuitGroupButtonClick_hotfix;

		// Token: 0x04008CA1 RID: 36001
		private LuaFunction m_OnCreateNewGroupButtonClick_hotfix;

		// Token: 0x04008CA2 RID: 36002
		private LuaFunction m_OnInviteFriendToGroupButtonClick_hotfix;

		// Token: 0x04008CA3 RID: 36003
		private LuaFunction m_InviteFriendToGoupPanelClose_hotfix;

		// Token: 0x04008CA4 RID: 36004
		private LuaFunction m_OnInviteFriendToGoupPanelConfirmButtonClick_hotfix;

		// Token: 0x04008CA5 RID: 36005
		private LuaFunction m_OnInviteFriendToGroupPanelServerFriendToggleBoolean_hotfix;

		// Token: 0x04008CA6 RID: 36006
		private LuaFunction m_OnInviteFriendToGroupPanelFriendToggleBoolean_hotfix;

		// Token: 0x04008CA7 RID: 36007
		private LuaFunction m_OnPlayerItemButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CA8 RID: 36008
		private LuaFunction m_OnPlayerItemButtonClickFriendSmallItemUIController_hotfix;

		// Token: 0x04008CA9 RID: 36009
		private LuaFunction m_OnItemAddFriendButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CAA RID: 36010
		private LuaFunction m_OnItemKickFromGroupButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CAB RID: 36011
		private LuaFunction m_OnUnblockPlayerButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CAC RID: 36012
		private LuaFunction m_OnChatButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CAD RID: 36013
		private LuaFunction m_OnSendFriendshipPointButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CAE RID: 36014
		private LuaFunction m_OnGetFriendshipPointButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CAF RID: 36015
		private LuaFunction m_OnFriendshipPointDoneButtonClickFriendBigItemUIController_hotfix;

		// Token: 0x04008CB0 RID: 36016
		private LuaFunction m_OnItemAddFriendButtonClickFriendSmallItemUIController_hotfix;

		// Token: 0x04008CB1 RID: 36017
		private LuaFunction m_OnChatButtonClickFriendSmallItemUIController_hotfix;

		// Token: 0x04008CB2 RID: 36018
		private LuaFunction m_OnFriendApplyAceeptButtonClickFriendSmallItemUIController_hotfix;

		// Token: 0x04008CB3 RID: 36019
		private LuaFunction m_OnFriendApplyDeclineButtonClickFriendSmallItemUIController_hotfix;

		// Token: 0x04008CB4 RID: 36020
		private LuaFunction m_OnInviteFriendToGroupToggleValueChangedBooleanFriendSmallItemUIController_hotfix;

		// Token: 0x04008CB5 RID: 36021
		private LuaFunction m_OnGroupChatButtonClickFriendGroupUIController_hotfix;

		// Token: 0x04008CB6 RID: 36022
		private LuaFunction m_OnWatchGroupStaffButtonClickFriendGroupUIController_hotfix;

		// Token: 0x04008CB7 RID: 36023
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008CB8 RID: 36024
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008CB9 RID: 36025
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04008CBA RID: 36026
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04008CBB RID: 36027
		private LuaFunction m_add_EventOnShowPanelAction;

		// Token: 0x04008CBC RID: 36028
		private LuaFunction m_remove_EventOnShowPanelAction;

		// Token: 0x04008CBD RID: 36029
		private LuaFunction m_add_EventOnAddFriendAction;

		// Token: 0x04008CBE RID: 36030
		private LuaFunction m_remove_EventOnAddFriendAction;

		// Token: 0x04008CBF RID: 36031
		private LuaFunction m_add_EventOnKickFromGroupAction;

		// Token: 0x04008CC0 RID: 36032
		private LuaFunction m_remove_EventOnKickFromGroupAction;

		// Token: 0x04008CC1 RID: 36033
		private LuaFunction m_add_EventOnUnblockPlayerAction;

		// Token: 0x04008CC2 RID: 36034
		private LuaFunction m_remove_EventOnUnblockPlayerAction;

		// Token: 0x04008CC3 RID: 36035
		private LuaFunction m_add_EventOnChatAction;

		// Token: 0x04008CC4 RID: 36036
		private LuaFunction m_remove_EventOnChatAction;

		// Token: 0x04008CC5 RID: 36037
		private LuaFunction m_add_EventOnSendFriendshipPointAction;

		// Token: 0x04008CC6 RID: 36038
		private LuaFunction m_remove_EventOnSendFriendshipPointAction;

		// Token: 0x04008CC7 RID: 36039
		private LuaFunction m_add_EventOnGetFriendshipPointAction;

		// Token: 0x04008CC8 RID: 36040
		private LuaFunction m_remove_EventOnGetFriendshipPointAction;

		// Token: 0x04008CC9 RID: 36041
		private LuaFunction m_add_EventOnFindFriendAction;

		// Token: 0x04008CCA RID: 36042
		private LuaFunction m_remove_EventOnFindFriendAction;

		// Token: 0x04008CCB RID: 36043
		private LuaFunction m_add_EventOnSendAllFriendshipPointAction_hotfix;

		// Token: 0x04008CCC RID: 36044
		private LuaFunction m_remove_EventOnSendAllFriendshipPointAction_hotfix;

		// Token: 0x04008CCD RID: 36045
		private LuaFunction m_add_EventOnGetAllFriendshipPointAction_hotfix;

		// Token: 0x04008CCE RID: 36046
		private LuaFunction m_remove_EventOnGetAllFriendshipPointAction_hotfix;

		// Token: 0x04008CCF RID: 36047
		private LuaFunction m_add_EventOnGetRecommendFriendsListAction_hotfix;

		// Token: 0x04008CD0 RID: 36048
		private LuaFunction m_remove_EventOnGetRecommendFriendsListAction_hotfix;

		// Token: 0x04008CD1 RID: 36049
		private LuaFunction m_add_EventOnFriendApplyAceeptAction;

		// Token: 0x04008CD2 RID: 36050
		private LuaFunction m_remove_EventOnFriendApplyAceeptAction;

		// Token: 0x04008CD3 RID: 36051
		private LuaFunction m_add_EventOnFriendApplyDeclineAction;

		// Token: 0x04008CD4 RID: 36052
		private LuaFunction m_remove_EventOnFriendApplyDeclineAction;

		// Token: 0x04008CD5 RID: 36053
		private LuaFunction m_add_EventOnShowPlayerSimpleInfoAction;

		// Token: 0x04008CD6 RID: 36054
		private LuaFunction m_remove_EventOnShowPlayerSimpleInfoAction;

		// Token: 0x04008CD7 RID: 36055
		private LuaFunction m_add_EventOnGroupChatAction;

		// Token: 0x04008CD8 RID: 36056
		private LuaFunction m_remove_EventOnGroupChatAction;

		// Token: 0x04008CD9 RID: 36057
		private LuaFunction m_add_EventOnWatchGroupStaffAction;

		// Token: 0x04008CDA RID: 36058
		private LuaFunction m_remove_EventOnWatchGroupStaffAction;

		// Token: 0x04008CDB RID: 36059
		private LuaFunction m_add_EventOnCreateNewGroupAction;

		// Token: 0x04008CDC RID: 36060
		private LuaFunction m_remove_EventOnCreateNewGroupAction;

		// Token: 0x04008CDD RID: 36061
		private LuaFunction m_add_EventOnInviteFriendToGroupAction;

		// Token: 0x04008CDE RID: 36062
		private LuaFunction m_remove_EventOnInviteFriendToGroupAction;

		// Token: 0x04008CDF RID: 36063
		private LuaFunction m_add_EventOnChangeGroupNameAction;

		// Token: 0x04008CE0 RID: 36064
		private LuaFunction m_remove_EventOnChangeGroupNameAction;

		// Token: 0x04008CE1 RID: 36065
		private LuaFunction m_add_EventOnLeaveGroupAction;

		// Token: 0x04008CE2 RID: 36066
		private LuaFunction m_remove_EventOnLeaveGroupAction;

		// Token: 0x02000CB0 RID: 3248
		public new class LuaExportHelper
		{
			// Token: 0x0600E9E9 RID: 59881 RVA: 0x003EC850 File Offset: 0x003EAA50
			public LuaExportHelper(FriendUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E9EA RID: 59882 RVA: 0x003EC860 File Offset: 0x003EAA60
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E9EB RID: 59883 RVA: 0x003EC870 File Offset: 0x003EAA70
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E9EC RID: 59884 RVA: 0x003EC880 File Offset: 0x003EAA80
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E9ED RID: 59885 RVA: 0x003EC890 File Offset: 0x003EAA90
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E9EE RID: 59886 RVA: 0x003EC8A8 File Offset: 0x003EAAA8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E9EF RID: 59887 RVA: 0x003EC8B8 File Offset: 0x003EAAB8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E9F0 RID: 59888 RVA: 0x003EC8C8 File Offset: 0x003EAAC8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E9F1 RID: 59889 RVA: 0x003EC8D8 File Offset: 0x003EAAD8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E9F2 RID: 59890 RVA: 0x003EC8E8 File Offset: 0x003EAAE8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E9F3 RID: 59891 RVA: 0x003EC8F8 File Offset: 0x003EAAF8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E9F4 RID: 59892 RVA: 0x003EC908 File Offset: 0x003EAB08
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E9F5 RID: 59893 RVA: 0x003EC918 File Offset: 0x003EAB18
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E9F6 RID: 59894 RVA: 0x003EC928 File Offset: 0x003EAB28
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E9F7 RID: 59895 RVA: 0x003EC938 File Offset: 0x003EAB38
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E9F8 RID: 59896 RVA: 0x003EC948 File Offset: 0x003EAB48
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E9F9 RID: 59897 RVA: 0x003EC958 File Offset: 0x003EAB58
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600E9FA RID: 59898 RVA: 0x003EC968 File Offset: 0x003EAB68
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600E9FB RID: 59899 RVA: 0x003EC978 File Offset: 0x003EAB78
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600E9FC RID: 59900 RVA: 0x003EC988 File Offset: 0x003EAB88
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600E9FD RID: 59901 RVA: 0x003EC998 File Offset: 0x003EAB98
			public void __callDele_EventOnShowPanel(FriendPanelType obj)
			{
				this.m_owner.__callDele_EventOnShowPanel(obj);
			}

			// Token: 0x0600E9FE RID: 59902 RVA: 0x003EC9A8 File Offset: 0x003EABA8
			public void __clearDele_EventOnShowPanel(FriendPanelType obj)
			{
				this.m_owner.__clearDele_EventOnShowPanel(obj);
			}

			// Token: 0x0600E9FF RID: 59903 RVA: 0x003EC9B8 File Offset: 0x003EABB8
			public void __callDele_EventOnAddFriend(List<string> obj)
			{
				this.m_owner.__callDele_EventOnAddFriend(obj);
			}

			// Token: 0x0600EA00 RID: 59904 RVA: 0x003EC9C8 File Offset: 0x003EABC8
			public void __clearDele_EventOnAddFriend(List<string> obj)
			{
				this.m_owner.__clearDele_EventOnAddFriend(obj);
			}

			// Token: 0x0600EA01 RID: 59905 RVA: 0x003EC9D8 File Offset: 0x003EABD8
			public void __callDele_EventOnKickFromGroup(ProChatGroupInfo arg1, UserSummary arg2)
			{
				this.m_owner.__callDele_EventOnKickFromGroup(arg1, arg2);
			}

			// Token: 0x0600EA02 RID: 59906 RVA: 0x003EC9E8 File Offset: 0x003EABE8
			public void __clearDele_EventOnKickFromGroup(ProChatGroupInfo arg1, UserSummary arg2)
			{
				this.m_owner.__clearDele_EventOnKickFromGroup(arg1, arg2);
			}

			// Token: 0x0600EA03 RID: 59907 RVA: 0x003EC9F8 File Offset: 0x003EABF8
			public void __callDele_EventOnUnblockPlayer(string obj)
			{
				this.m_owner.__callDele_EventOnUnblockPlayer(obj);
			}

			// Token: 0x0600EA04 RID: 59908 RVA: 0x003ECA08 File Offset: 0x003EAC08
			public void __clearDele_EventOnUnblockPlayer(string obj)
			{
				this.m_owner.__clearDele_EventOnUnblockPlayer(obj);
			}

			// Token: 0x0600EA05 RID: 59909 RVA: 0x003ECA18 File Offset: 0x003EAC18
			public void __callDele_EventOnChat(UserSummary obj)
			{
				this.m_owner.__callDele_EventOnChat(obj);
			}

			// Token: 0x0600EA06 RID: 59910 RVA: 0x003ECA28 File Offset: 0x003EAC28
			public void __clearDele_EventOnChat(UserSummary obj)
			{
				this.m_owner.__clearDele_EventOnChat(obj);
			}

			// Token: 0x0600EA07 RID: 59911 RVA: 0x003ECA38 File Offset: 0x003EAC38
			public void __callDele_EventOnSendFriendshipPoint(string obj)
			{
				this.m_owner.__callDele_EventOnSendFriendshipPoint(obj);
			}

			// Token: 0x0600EA08 RID: 59912 RVA: 0x003ECA48 File Offset: 0x003EAC48
			public void __clearDele_EventOnSendFriendshipPoint(string obj)
			{
				this.m_owner.__clearDele_EventOnSendFriendshipPoint(obj);
			}

			// Token: 0x0600EA09 RID: 59913 RVA: 0x003ECA58 File Offset: 0x003EAC58
			public void __callDele_EventOnGetFriendshipPoint(string obj)
			{
				this.m_owner.__callDele_EventOnGetFriendshipPoint(obj);
			}

			// Token: 0x0600EA0A RID: 59914 RVA: 0x003ECA68 File Offset: 0x003EAC68
			public void __clearDele_EventOnGetFriendshipPoint(string obj)
			{
				this.m_owner.__clearDele_EventOnGetFriendshipPoint(obj);
			}

			// Token: 0x0600EA0B RID: 59915 RVA: 0x003ECA78 File Offset: 0x003EAC78
			public void __callDele_EventOnFindFriend(int arg1, string arg2)
			{
				this.m_owner.__callDele_EventOnFindFriend(arg1, arg2);
			}

			// Token: 0x0600EA0C RID: 59916 RVA: 0x003ECA88 File Offset: 0x003EAC88
			public void __clearDele_EventOnFindFriend(int arg1, string arg2)
			{
				this.m_owner.__clearDele_EventOnFindFriend(arg1, arg2);
			}

			// Token: 0x0600EA0D RID: 59917 RVA: 0x003ECA98 File Offset: 0x003EAC98
			public void __callDele_EventOnSendAllFriendshipPoint()
			{
				this.m_owner.__callDele_EventOnSendAllFriendshipPoint();
			}

			// Token: 0x0600EA0E RID: 59918 RVA: 0x003ECAA8 File Offset: 0x003EACA8
			public void __clearDele_EventOnSendAllFriendshipPoint()
			{
				this.m_owner.__clearDele_EventOnSendAllFriendshipPoint();
			}

			// Token: 0x0600EA0F RID: 59919 RVA: 0x003ECAB8 File Offset: 0x003EACB8
			public void __callDele_EventOnGetAllFriendshipPoint()
			{
				this.m_owner.__callDele_EventOnGetAllFriendshipPoint();
			}

			// Token: 0x0600EA10 RID: 59920 RVA: 0x003ECAC8 File Offset: 0x003EACC8
			public void __clearDele_EventOnGetAllFriendshipPoint()
			{
				this.m_owner.__clearDele_EventOnGetAllFriendshipPoint();
			}

			// Token: 0x0600EA11 RID: 59921 RVA: 0x003ECAD8 File Offset: 0x003EACD8
			public void __callDele_EventOnGetRecommendFriendsList()
			{
				this.m_owner.__callDele_EventOnGetRecommendFriendsList();
			}

			// Token: 0x0600EA12 RID: 59922 RVA: 0x003ECAE8 File Offset: 0x003EACE8
			public void __clearDele_EventOnGetRecommendFriendsList()
			{
				this.m_owner.__clearDele_EventOnGetRecommendFriendsList();
			}

			// Token: 0x0600EA13 RID: 59923 RVA: 0x003ECAF8 File Offset: 0x003EACF8
			public void __callDele_EventOnFriendApplyAceept(List<string> obj)
			{
				this.m_owner.__callDele_EventOnFriendApplyAceept(obj);
			}

			// Token: 0x0600EA14 RID: 59924 RVA: 0x003ECB08 File Offset: 0x003EAD08
			public void __clearDele_EventOnFriendApplyAceept(List<string> obj)
			{
				this.m_owner.__clearDele_EventOnFriendApplyAceept(obj);
			}

			// Token: 0x0600EA15 RID: 59925 RVA: 0x003ECB18 File Offset: 0x003EAD18
			public void __callDele_EventOnFriendApplyDecline(List<string> obj)
			{
				this.m_owner.__callDele_EventOnFriendApplyDecline(obj);
			}

			// Token: 0x0600EA16 RID: 59926 RVA: 0x003ECB28 File Offset: 0x003EAD28
			public void __clearDele_EventOnFriendApplyDecline(List<string> obj)
			{
				this.m_owner.__clearDele_EventOnFriendApplyDecline(obj);
			}

			// Token: 0x0600EA17 RID: 59927 RVA: 0x003ECB38 File Offset: 0x003EAD38
			public void __callDele_EventOnShowPlayerSimpleInfo(UserSummary arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
			{
				this.m_owner.__callDele_EventOnShowPlayerSimpleInfo(arg1, arg2, arg3);
			}

			// Token: 0x0600EA18 RID: 59928 RVA: 0x003ECB48 File Offset: 0x003EAD48
			public void __clearDele_EventOnShowPlayerSimpleInfo(UserSummary arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
			{
				this.m_owner.__clearDele_EventOnShowPlayerSimpleInfo(arg1, arg2, arg3);
			}

			// Token: 0x0600EA19 RID: 59929 RVA: 0x003ECB58 File Offset: 0x003EAD58
			public void __callDele_EventOnGroupChat(string obj)
			{
				this.m_owner.__callDele_EventOnGroupChat(obj);
			}

			// Token: 0x0600EA1A RID: 59930 RVA: 0x003ECB68 File Offset: 0x003EAD68
			public void __clearDele_EventOnGroupChat(string obj)
			{
				this.m_owner.__clearDele_EventOnGroupChat(obj);
			}

			// Token: 0x0600EA1B RID: 59931 RVA: 0x003ECB78 File Offset: 0x003EAD78
			public void __callDele_EventOnWatchGroupStaff(string arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnWatchGroupStaff(arg1, arg2);
			}

			// Token: 0x0600EA1C RID: 59932 RVA: 0x003ECB88 File Offset: 0x003EAD88
			public void __clearDele_EventOnWatchGroupStaff(string arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnWatchGroupStaff(arg1, arg2);
			}

			// Token: 0x0600EA1D RID: 59933 RVA: 0x003ECB98 File Offset: 0x003EAD98
			public void __callDele_EventOnCreateNewGroup(List<string> obj)
			{
				this.m_owner.__callDele_EventOnCreateNewGroup(obj);
			}

			// Token: 0x0600EA1E RID: 59934 RVA: 0x003ECBA8 File Offset: 0x003EADA8
			public void __clearDele_EventOnCreateNewGroup(List<string> obj)
			{
				this.m_owner.__clearDele_EventOnCreateNewGroup(obj);
			}

			// Token: 0x0600EA1F RID: 59935 RVA: 0x003ECBB8 File Offset: 0x003EADB8
			public void __callDele_EventOnInviteFriendToGroup(string arg1, List<string> arg2)
			{
				this.m_owner.__callDele_EventOnInviteFriendToGroup(arg1, arg2);
			}

			// Token: 0x0600EA20 RID: 59936 RVA: 0x003ECBC8 File Offset: 0x003EADC8
			public void __clearDele_EventOnInviteFriendToGroup(string arg1, List<string> arg2)
			{
				this.m_owner.__clearDele_EventOnInviteFriendToGroup(arg1, arg2);
			}

			// Token: 0x0600EA21 RID: 59937 RVA: 0x003ECBD8 File Offset: 0x003EADD8
			public void __callDele_EventOnChangeGroupName(string arg1, string arg2)
			{
				this.m_owner.__callDele_EventOnChangeGroupName(arg1, arg2);
			}

			// Token: 0x0600EA22 RID: 59938 RVA: 0x003ECBE8 File Offset: 0x003EADE8
			public void __clearDele_EventOnChangeGroupName(string arg1, string arg2)
			{
				this.m_owner.__clearDele_EventOnChangeGroupName(arg1, arg2);
			}

			// Token: 0x0600EA23 RID: 59939 RVA: 0x003ECBF8 File Offset: 0x003EADF8
			public void __callDele_EventOnLeaveGroup(ProChatGroupInfo obj)
			{
				this.m_owner.__callDele_EventOnLeaveGroup(obj);
			}

			// Token: 0x0600EA24 RID: 59940 RVA: 0x003ECC08 File Offset: 0x003EAE08
			public void __clearDele_EventOnLeaveGroup(ProChatGroupInfo obj)
			{
				this.m_owner.__clearDele_EventOnLeaveGroup(obj);
			}

			// Token: 0x17002D1E RID: 11550
			// (get) Token: 0x0600EA25 RID: 59941 RVA: 0x003ECC18 File Offset: 0x003EAE18
			// (set) Token: 0x0600EA26 RID: 59942 RVA: 0x003ECC28 File Offset: 0x003EAE28
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17002D1F RID: 11551
			// (get) Token: 0x0600EA27 RID: 59943 RVA: 0x003ECC38 File Offset: 0x003EAE38
			// (set) Token: 0x0600EA28 RID: 59944 RVA: 0x003ECC48 File Offset: 0x003EAE48
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

			// Token: 0x17002D20 RID: 11552
			// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x003ECC58 File Offset: 0x003EAE58
			// (set) Token: 0x0600EA2A RID: 59946 RVA: 0x003ECC68 File Offset: 0x003EAE68
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

			// Token: 0x17002D21 RID: 11553
			// (get) Token: 0x0600EA2B RID: 59947 RVA: 0x003ECC78 File Offset: 0x003EAE78
			// (set) Token: 0x0600EA2C RID: 59948 RVA: 0x003ECC88 File Offset: 0x003EAE88
			public Button m_shieldButton
			{
				get
				{
					return this.m_owner.m_shieldButton;
				}
				set
				{
					this.m_owner.m_shieldButton = value;
				}
			}

			// Token: 0x17002D22 RID: 11554
			// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x003ECC98 File Offset: 0x003EAE98
			// (set) Token: 0x0600EA2E RID: 59950 RVA: 0x003ECCA8 File Offset: 0x003EAEA8
			public Button m_addFriendButton
			{
				get
				{
					return this.m_owner.m_addFriendButton;
				}
				set
				{
					this.m_owner.m_addFriendButton = value;
				}
			}

			// Token: 0x17002D23 RID: 11555
			// (get) Token: 0x0600EA2F RID: 59951 RVA: 0x003ECCB8 File Offset: 0x003EAEB8
			// (set) Token: 0x0600EA30 RID: 59952 RVA: 0x003ECCC8 File Offset: 0x003EAEC8
			public GameObject m_addFriendRedMark
			{
				get
				{
					return this.m_owner.m_addFriendRedMark;
				}
				set
				{
					this.m_owner.m_addFriendRedMark = value;
				}
			}

			// Token: 0x17002D24 RID: 11556
			// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x003ECCD8 File Offset: 0x003EAED8
			// (set) Token: 0x0600EA32 RID: 59954 RVA: 0x003ECCE8 File Offset: 0x003EAEE8
			public Button m_createNewGroupButton
			{
				get
				{
					return this.m_owner.m_createNewGroupButton;
				}
				set
				{
					this.m_owner.m_createNewGroupButton = value;
				}
			}

			// Token: 0x17002D25 RID: 11557
			// (get) Token: 0x0600EA33 RID: 59955 RVA: 0x003ECCF8 File Offset: 0x003EAEF8
			// (set) Token: 0x0600EA34 RID: 59956 RVA: 0x003ECD08 File Offset: 0x003EAF08
			public CommonUIStateController m_friendCountUIStateController
			{
				get
				{
					return this.m_owner.m_friendCountUIStateController;
				}
				set
				{
					this.m_owner.m_friendCountUIStateController = value;
				}
			}

			// Token: 0x17002D26 RID: 11558
			// (get) Token: 0x0600EA35 RID: 59957 RVA: 0x003ECD18 File Offset: 0x003EAF18
			// (set) Token: 0x0600EA36 RID: 59958 RVA: 0x003ECD28 File Offset: 0x003EAF28
			public Text m_friendTypeCount
			{
				get
				{
					return this.m_owner.m_friendTypeCount;
				}
				set
				{
					this.m_owner.m_friendTypeCount = value;
				}
			}

			// Token: 0x17002D27 RID: 11559
			// (get) Token: 0x0600EA37 RID: 59959 RVA: 0x003ECD38 File Offset: 0x003EAF38
			// (set) Token: 0x0600EA38 RID: 59960 RVA: 0x003ECD48 File Offset: 0x003EAF48
			public CommonUIStateController m_panelUIStateController
			{
				get
				{
					return this.m_owner.m_panelUIStateController;
				}
				set
				{
					this.m_owner.m_panelUIStateController = value;
				}
			}

			// Token: 0x17002D28 RID: 11560
			// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x003ECD58 File Offset: 0x003EAF58
			// (set) Token: 0x0600EA3A RID: 59962 RVA: 0x003ECD68 File Offset: 0x003EAF68
			public CommonUIStateController m_friendShipPointTipStateCtrl
			{
				get
				{
					return this.m_owner.m_friendShipPointTipStateCtrl;
				}
				set
				{
					this.m_owner.m_friendShipPointTipStateCtrl = value;
				}
			}

			// Token: 0x17002D29 RID: 11561
			// (get) Token: 0x0600EA3B RID: 59963 RVA: 0x003ECD78 File Offset: 0x003EAF78
			// (set) Token: 0x0600EA3C RID: 59964 RVA: 0x003ECD88 File Offset: 0x003EAF88
			public Text m_friendShipPointTipText
			{
				get
				{
					return this.m_owner.m_friendShipPointTipText;
				}
				set
				{
					this.m_owner.m_friendShipPointTipText = value;
				}
			}

			// Token: 0x17002D2A RID: 11562
			// (get) Token: 0x0600EA3D RID: 59965 RVA: 0x003ECD98 File Offset: 0x003EAF98
			// (set) Token: 0x0600EA3E RID: 59966 RVA: 0x003ECDA8 File Offset: 0x003EAFA8
			public Button m_getAllFriendshipPointButton
			{
				get
				{
					return this.m_owner.m_getAllFriendshipPointButton;
				}
				set
				{
					this.m_owner.m_getAllFriendshipPointButton = value;
				}
			}

			// Token: 0x17002D2B RID: 11563
			// (get) Token: 0x0600EA3F RID: 59967 RVA: 0x003ECDB8 File Offset: 0x003EAFB8
			// (set) Token: 0x0600EA40 RID: 59968 RVA: 0x003ECDC8 File Offset: 0x003EAFC8
			public CommonUIStateController m_getAllFriendshipPointButtonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_getAllFriendshipPointButtonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_getAllFriendshipPointButtonUIStateCtrl = value;
				}
			}

			// Token: 0x17002D2C RID: 11564
			// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x003ECDD8 File Offset: 0x003EAFD8
			// (set) Token: 0x0600EA42 RID: 59970 RVA: 0x003ECDE8 File Offset: 0x003EAFE8
			public Button m_sendAllFriendshipPointButton
			{
				get
				{
					return this.m_owner.m_sendAllFriendshipPointButton;
				}
				set
				{
					this.m_owner.m_sendAllFriendshipPointButton = value;
				}
			}

			// Token: 0x17002D2D RID: 11565
			// (get) Token: 0x0600EA43 RID: 59971 RVA: 0x003ECDF8 File Offset: 0x003EAFF8
			// (set) Token: 0x0600EA44 RID: 59972 RVA: 0x003ECE08 File Offset: 0x003EB008
			public CommonUIStateController m_sendAllFriendshipPointButtonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_sendAllFriendshipPointButtonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_sendAllFriendshipPointButtonUIStateCtrl = value;
				}
			}

			// Token: 0x17002D2E RID: 11566
			// (get) Token: 0x0600EA45 RID: 59973 RVA: 0x003ECE18 File Offset: 0x003EB018
			// (set) Token: 0x0600EA46 RID: 59974 RVA: 0x003ECE28 File Offset: 0x003EB028
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

			// Token: 0x17002D2F RID: 11567
			// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x003ECE38 File Offset: 0x003EB038
			// (set) Token: 0x0600EA48 RID: 59976 RVA: 0x003ECE48 File Offset: 0x003EB048
			public Toggle m_acrossServerToggle
			{
				get
				{
					return this.m_owner.m_acrossServerToggle;
				}
				set
				{
					this.m_owner.m_acrossServerToggle = value;
				}
			}

			// Token: 0x17002D30 RID: 11568
			// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x003ECE58 File Offset: 0x003EB058
			// (set) Token: 0x0600EA4A RID: 59978 RVA: 0x003ECE68 File Offset: 0x003EB068
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

			// Token: 0x17002D31 RID: 11569
			// (get) Token: 0x0600EA4B RID: 59979 RVA: 0x003ECE78 File Offset: 0x003EB078
			// (set) Token: 0x0600EA4C RID: 59980 RVA: 0x003ECE88 File Offset: 0x003EB088
			public Toggle m_groupToggle
			{
				get
				{
					return this.m_owner.m_groupToggle;
				}
				set
				{
					this.m_owner.m_groupToggle = value;
				}
			}

			// Token: 0x17002D32 RID: 11570
			// (get) Token: 0x0600EA4D RID: 59981 RVA: 0x003ECE98 File Offset: 0x003EB098
			// (set) Token: 0x0600EA4E RID: 59982 RVA: 0x003ECEA8 File Offset: 0x003EB0A8
			public CommonUIStateController m_addFriendPanelUIStateController
			{
				get
				{
					return this.m_owner.m_addFriendPanelUIStateController;
				}
				set
				{
					this.m_owner.m_addFriendPanelUIStateController = value;
				}
			}

			// Token: 0x17002D33 RID: 11571
			// (get) Token: 0x0600EA4F RID: 59983 RVA: 0x003ECEB8 File Offset: 0x003EB0B8
			// (set) Token: 0x0600EA50 RID: 59984 RVA: 0x003ECEC8 File Offset: 0x003EB0C8
			public Button m_addFriendPanelCloseButton
			{
				get
				{
					return this.m_owner.m_addFriendPanelCloseButton;
				}
				set
				{
					this.m_owner.m_addFriendPanelCloseButton = value;
				}
			}

			// Token: 0x17002D34 RID: 11572
			// (get) Token: 0x0600EA51 RID: 59985 RVA: 0x003ECED8 File Offset: 0x003EB0D8
			// (set) Token: 0x0600EA52 RID: 59986 RVA: 0x003ECEE8 File Offset: 0x003EB0E8
			public Button m_addFriendPanelBackgroundButton
			{
				get
				{
					return this.m_owner.m_addFriendPanelBackgroundButton;
				}
				set
				{
					this.m_owner.m_addFriendPanelBackgroundButton = value;
				}
			}

			// Token: 0x17002D35 RID: 11573
			// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x003ECEF8 File Offset: 0x003EB0F8
			// (set) Token: 0x0600EA54 RID: 59988 RVA: 0x003ECF08 File Offset: 0x003EB108
			public Button m_addFriendPanelSelectServerButton
			{
				get
				{
					return this.m_owner.m_addFriendPanelSelectServerButton;
				}
				set
				{
					this.m_owner.m_addFriendPanelSelectServerButton = value;
				}
			}

			// Token: 0x17002D36 RID: 11574
			// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x003ECF18 File Offset: 0x003EB118
			// (set) Token: 0x0600EA56 RID: 59990 RVA: 0x003ECF28 File Offset: 0x003EB128
			public Text m_addFriendPanelServerNameText
			{
				get
				{
					return this.m_owner.m_addFriendPanelServerNameText;
				}
				set
				{
					this.m_owner.m_addFriendPanelServerNameText = value;
				}
			}

			// Token: 0x17002D37 RID: 11575
			// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x003ECF38 File Offset: 0x003EB138
			// (set) Token: 0x0600EA58 RID: 59992 RVA: 0x003ECF48 File Offset: 0x003EB148
			public Button m_addFriendPanelSearchButton
			{
				get
				{
					return this.m_owner.m_addFriendPanelSearchButton;
				}
				set
				{
					this.m_owner.m_addFriendPanelSearchButton = value;
				}
			}

			// Token: 0x17002D38 RID: 11576
			// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x003ECF58 File Offset: 0x003EB158
			// (set) Token: 0x0600EA5A RID: 59994 RVA: 0x003ECF68 File Offset: 0x003EB168
			public InputField m_addFriendPanelInputText
			{
				get
				{
					return this.m_owner.m_addFriendPanelInputText;
				}
				set
				{
					this.m_owner.m_addFriendPanelInputText = value;
				}
			}

			// Token: 0x17002D39 RID: 11577
			// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x003ECF78 File Offset: 0x003EB178
			// (set) Token: 0x0600EA5C RID: 59996 RVA: 0x003ECF88 File Offset: 0x003EB188
			public Button m_addFriendPanelChangeButton
			{
				get
				{
					return this.m_owner.m_addFriendPanelChangeButton;
				}
				set
				{
					this.m_owner.m_addFriendPanelChangeButton = value;
				}
			}

			// Token: 0x17002D3A RID: 11578
			// (get) Token: 0x0600EA5D RID: 59997 RVA: 0x003ECF98 File Offset: 0x003EB198
			// (set) Token: 0x0600EA5E RID: 59998 RVA: 0x003ECFA8 File Offset: 0x003EB1A8
			public Button m_addFriendPanelRefuseAllButton
			{
				get
				{
					return this.m_owner.m_addFriendPanelRefuseAllButton;
				}
				set
				{
					this.m_owner.m_addFriendPanelRefuseAllButton = value;
				}
			}

			// Token: 0x17002D3B RID: 11579
			// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x003ECFB8 File Offset: 0x003EB1B8
			// (set) Token: 0x0600EA60 RID: 60000 RVA: 0x003ECFC8 File Offset: 0x003EB1C8
			public GameObject m_addFriendPanelRecommendScrollView
			{
				get
				{
					return this.m_owner.m_addFriendPanelRecommendScrollView;
				}
				set
				{
					this.m_owner.m_addFriendPanelRecommendScrollView = value;
				}
			}

			// Token: 0x17002D3C RID: 11580
			// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x003ECFD8 File Offset: 0x003EB1D8
			// (set) Token: 0x0600EA62 RID: 60002 RVA: 0x003ECFE8 File Offset: 0x003EB1E8
			public GameObject m_addFriendPanelRecommendScrollViewContent
			{
				get
				{
					return this.m_owner.m_addFriendPanelRecommendScrollViewContent;
				}
				set
				{
					this.m_owner.m_addFriendPanelRecommendScrollViewContent = value;
				}
			}

			// Token: 0x17002D3D RID: 11581
			// (get) Token: 0x0600EA63 RID: 60003 RVA: 0x003ECFF8 File Offset: 0x003EB1F8
			// (set) Token: 0x0600EA64 RID: 60004 RVA: 0x003ED008 File Offset: 0x003EB208
			public GameObject m_addFriendPanelApplyScrollView
			{
				get
				{
					return this.m_owner.m_addFriendPanelApplyScrollView;
				}
				set
				{
					this.m_owner.m_addFriendPanelApplyScrollView = value;
				}
			}

			// Token: 0x17002D3E RID: 11582
			// (get) Token: 0x0600EA65 RID: 60005 RVA: 0x003ED018 File Offset: 0x003EB218
			// (set) Token: 0x0600EA66 RID: 60006 RVA: 0x003ED028 File Offset: 0x003EB228
			public GameObject m_addFriendPanelApplyScrollViewContent
			{
				get
				{
					return this.m_owner.m_addFriendPanelApplyScrollViewContent;
				}
				set
				{
					this.m_owner.m_addFriendPanelApplyScrollViewContent = value;
				}
			}

			// Token: 0x17002D3F RID: 11583
			// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x003ED038 File Offset: 0x003EB238
			// (set) Token: 0x0600EA68 RID: 60008 RVA: 0x003ED048 File Offset: 0x003EB248
			public GameObject m_addFriendPanelRecommendTextGameObject
			{
				get
				{
					return this.m_owner.m_addFriendPanelRecommendTextGameObject;
				}
				set
				{
					this.m_owner.m_addFriendPanelRecommendTextGameObject = value;
				}
			}

			// Token: 0x17002D40 RID: 11584
			// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x003ED058 File Offset: 0x003EB258
			// (set) Token: 0x0600EA6A RID: 60010 RVA: 0x003ED068 File Offset: 0x003EB268
			public GameObject m_addFriendPanelFindFriendTextGameObject
			{
				get
				{
					return this.m_owner.m_addFriendPanelFindFriendTextGameObject;
				}
				set
				{
					this.m_owner.m_addFriendPanelFindFriendTextGameObject = value;
				}
			}

			// Token: 0x17002D41 RID: 11585
			// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x003ED078 File Offset: 0x003EB278
			// (set) Token: 0x0600EA6C RID: 60012 RVA: 0x003ED088 File Offset: 0x003EB288
			public GameObject m_addFriendPanelNotFindFriendGameObject
			{
				get
				{
					return this.m_owner.m_addFriendPanelNotFindFriendGameObject;
				}
				set
				{
					this.m_owner.m_addFriendPanelNotFindFriendGameObject = value;
				}
			}

			// Token: 0x17002D42 RID: 11586
			// (get) Token: 0x0600EA6D RID: 60013 RVA: 0x003ED098 File Offset: 0x003EB298
			// (set) Token: 0x0600EA6E RID: 60014 RVA: 0x003ED0A8 File Offset: 0x003EB2A8
			public CommonUIStateController m_serverListPanelUIStateController
			{
				get
				{
					return this.m_owner.m_serverListPanelUIStateController;
				}
				set
				{
					this.m_owner.m_serverListPanelUIStateController = value;
				}
			}

			// Token: 0x17002D43 RID: 11587
			// (get) Token: 0x0600EA6F RID: 60015 RVA: 0x003ED0B8 File Offset: 0x003EB2B8
			// (set) Token: 0x0600EA70 RID: 60016 RVA: 0x003ED0C8 File Offset: 0x003EB2C8
			public GameObject m_serverItemGameObject
			{
				get
				{
					return this.m_owner.m_serverItemGameObject;
				}
				set
				{
					this.m_owner.m_serverItemGameObject = value;
				}
			}

			// Token: 0x17002D44 RID: 11588
			// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x003ED0D8 File Offset: 0x003EB2D8
			// (set) Token: 0x0600EA72 RID: 60018 RVA: 0x003ED0E8 File Offset: 0x003EB2E8
			public Text m_serverItemName
			{
				get
				{
					return this.m_owner.m_serverItemName;
				}
				set
				{
					this.m_owner.m_serverItemName = value;
				}
			}

			// Token: 0x17002D45 RID: 11589
			// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x003ED0F8 File Offset: 0x003EB2F8
			// (set) Token: 0x0600EA74 RID: 60020 RVA: 0x003ED108 File Offset: 0x003EB308
			public GameObject m_serverListGroup
			{
				get
				{
					return this.m_owner.m_serverListGroup;
				}
				set
				{
					this.m_owner.m_serverListGroup = value;
				}
			}

			// Token: 0x17002D46 RID: 11590
			// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x003ED118 File Offset: 0x003EB318
			// (set) Token: 0x0600EA76 RID: 60022 RVA: 0x003ED128 File Offset: 0x003EB328
			public Button m_serverListPanelBGButton
			{
				get
				{
					return this.m_owner.m_serverListPanelBGButton;
				}
				set
				{
					this.m_owner.m_serverListPanelBGButton = value;
				}
			}

			// Token: 0x17002D47 RID: 11591
			// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x003ED138 File Offset: 0x003EB338
			// (set) Token: 0x0600EA78 RID: 60024 RVA: 0x003ED148 File Offset: 0x003EB348
			public CommonUIStateController m_watchGroupStaffPanelUIStateController
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelUIStateController;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelUIStateController = value;
				}
			}

			// Token: 0x17002D48 RID: 11592
			// (get) Token: 0x0600EA79 RID: 60025 RVA: 0x003ED158 File Offset: 0x003EB358
			// (set) Token: 0x0600EA7A RID: 60026 RVA: 0x003ED168 File Offset: 0x003EB368
			public Button m_watchGroupStaffPanelBackgroundButton
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelBackgroundButton;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelBackgroundButton = value;
				}
			}

			// Token: 0x17002D49 RID: 11593
			// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x003ED178 File Offset: 0x003EB378
			// (set) Token: 0x0600EA7C RID: 60028 RVA: 0x003ED188 File Offset: 0x003EB388
			public Button m_watchGroupStaffPanelCloseButton
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelCloseButton;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelCloseButton = value;
				}
			}

			// Token: 0x17002D4A RID: 11594
			// (get) Token: 0x0600EA7D RID: 60029 RVA: 0x003ED198 File Offset: 0x003EB398
			// (set) Token: 0x0600EA7E RID: 60030 RVA: 0x003ED1A8 File Offset: 0x003EB3A8
			public Button m_watchGroupStaffPanelChangeGroupNameButton
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelChangeGroupNameButton;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelChangeGroupNameButton = value;
				}
			}

			// Token: 0x17002D4B RID: 11595
			// (get) Token: 0x0600EA7F RID: 60031 RVA: 0x003ED1B8 File Offset: 0x003EB3B8
			// (set) Token: 0x0600EA80 RID: 60032 RVA: 0x003ED1C8 File Offset: 0x003EB3C8
			public Button m_watchGroupStaffPanelQuitGroupButton
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelQuitGroupButton;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelQuitGroupButton = value;
				}
			}

			// Token: 0x17002D4C RID: 11596
			// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x003ED1D8 File Offset: 0x003EB3D8
			// (set) Token: 0x0600EA82 RID: 60034 RVA: 0x003ED1E8 File Offset: 0x003EB3E8
			public Button m_watchGroupStaffPanelInviteFriendButton
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelInviteFriendButton;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelInviteFriendButton = value;
				}
			}

			// Token: 0x17002D4D RID: 11597
			// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x003ED1F8 File Offset: 0x003EB3F8
			// (set) Token: 0x0600EA84 RID: 60036 RVA: 0x003ED208 File Offset: 0x003EB408
			public GameObject m_watchGroupStaffPanelScrollView
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelScrollView;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelScrollView = value;
				}
			}

			// Token: 0x17002D4E RID: 11598
			// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x003ED218 File Offset: 0x003EB418
			// (set) Token: 0x0600EA86 RID: 60038 RVA: 0x003ED228 File Offset: 0x003EB428
			public GameObject m_watchGroupStaffPanelScrollViewContent
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelScrollViewContent;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelScrollViewContent = value;
				}
			}

			// Token: 0x17002D4F RID: 11599
			// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x003ED238 File Offset: 0x003EB438
			// (set) Token: 0x0600EA88 RID: 60040 RVA: 0x003ED248 File Offset: 0x003EB448
			public Text m_watchGroupStaffPanelCountText
			{
				get
				{
					return this.m_owner.m_watchGroupStaffPanelCountText;
				}
				set
				{
					this.m_owner.m_watchGroupStaffPanelCountText = value;
				}
			}

			// Token: 0x17002D50 RID: 11600
			// (get) Token: 0x0600EA89 RID: 60041 RVA: 0x003ED258 File Offset: 0x003EB458
			// (set) Token: 0x0600EA8A RID: 60042 RVA: 0x003ED268 File Offset: 0x003EB468
			public Text m_groupTitleName
			{
				get
				{
					return this.m_owner.m_groupTitleName;
				}
				set
				{
					this.m_owner.m_groupTitleName = value;
				}
			}

			// Token: 0x17002D51 RID: 11601
			// (get) Token: 0x0600EA8B RID: 60043 RVA: 0x003ED278 File Offset: 0x003EB478
			// (set) Token: 0x0600EA8C RID: 60044 RVA: 0x003ED288 File Offset: 0x003EB488
			public CommonUIStateController m_changeGroupNameUIStateController
			{
				get
				{
					return this.m_owner.m_changeGroupNameUIStateController;
				}
				set
				{
					this.m_owner.m_changeGroupNameUIStateController = value;
				}
			}

			// Token: 0x17002D52 RID: 11602
			// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x003ED298 File Offset: 0x003EB498
			// (set) Token: 0x0600EA8E RID: 60046 RVA: 0x003ED2A8 File Offset: 0x003EB4A8
			public Button m_changeGroupNameBackgroundButton
			{
				get
				{
					return this.m_owner.m_changeGroupNameBackgroundButton;
				}
				set
				{
					this.m_owner.m_changeGroupNameBackgroundButton = value;
				}
			}

			// Token: 0x17002D53 RID: 11603
			// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x003ED2B8 File Offset: 0x003EB4B8
			// (set) Token: 0x0600EA90 RID: 60048 RVA: 0x003ED2C8 File Offset: 0x003EB4C8
			public Button m_changeGroupNameConfirmButton
			{
				get
				{
					return this.m_owner.m_changeGroupNameConfirmButton;
				}
				set
				{
					this.m_owner.m_changeGroupNameConfirmButton = value;
				}
			}

			// Token: 0x17002D54 RID: 11604
			// (get) Token: 0x0600EA91 RID: 60049 RVA: 0x003ED2D8 File Offset: 0x003EB4D8
			// (set) Token: 0x0600EA92 RID: 60050 RVA: 0x003ED2E8 File Offset: 0x003EB4E8
			public InputField m_changeNamePanelInputField
			{
				get
				{
					return this.m_owner.m_changeNamePanelInputField;
				}
				set
				{
					this.m_owner.m_changeNamePanelInputField = value;
				}
			}

			// Token: 0x17002D55 RID: 11605
			// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x003ED2F8 File Offset: 0x003EB4F8
			// (set) Token: 0x0600EA94 RID: 60052 RVA: 0x003ED308 File Offset: 0x003EB508
			public CommonUIStateController m_inviteFriendToGroupPanelUIStateController
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelUIStateController;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelUIStateController = value;
				}
			}

			// Token: 0x17002D56 RID: 11606
			// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x003ED318 File Offset: 0x003EB518
			// (set) Token: 0x0600EA96 RID: 60054 RVA: 0x003ED328 File Offset: 0x003EB528
			public GameObject m_inviteFriendToGroupPanelScrollView
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelScrollView;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelScrollView = value;
				}
			}

			// Token: 0x17002D57 RID: 11607
			// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x003ED338 File Offset: 0x003EB538
			// (set) Token: 0x0600EA98 RID: 60056 RVA: 0x003ED348 File Offset: 0x003EB548
			public GameObject m_inviteFriendToGroupPanelScrollViewContent
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelScrollViewContent;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelScrollViewContent = value;
				}
			}

			// Token: 0x17002D58 RID: 11608
			// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x003ED358 File Offset: 0x003EB558
			// (set) Token: 0x0600EA9A RID: 60058 RVA: 0x003ED368 File Offset: 0x003EB568
			public Button m_inviteFriendToGroupPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelConfirmButton = value;
				}
			}

			// Token: 0x17002D59 RID: 11609
			// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x003ED378 File Offset: 0x003EB578
			// (set) Token: 0x0600EA9C RID: 60060 RVA: 0x003ED388 File Offset: 0x003EB588
			public Button m_inviteFriendToGroupPanelCancelButton
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelCancelButton;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelCancelButton = value;
				}
			}

			// Token: 0x17002D5A RID: 11610
			// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x003ED398 File Offset: 0x003EB598
			// (set) Token: 0x0600EA9E RID: 60062 RVA: 0x003ED3A8 File Offset: 0x003EB5A8
			public Button m_inviteFriendToGroupPanelBackgroundButton
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelBackgroundButton;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelBackgroundButton = value;
				}
			}

			// Token: 0x17002D5B RID: 11611
			// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x003ED3B8 File Offset: 0x003EB5B8
			// (set) Token: 0x0600EAA0 RID: 60064 RVA: 0x003ED3C8 File Offset: 0x003EB5C8
			public Text m_inviteFriendToGroupPanelCountText
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelCountText;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelCountText = value;
				}
			}

			// Token: 0x17002D5C RID: 11612
			// (get) Token: 0x0600EAA1 RID: 60065 RVA: 0x003ED3D8 File Offset: 0x003EB5D8
			// (set) Token: 0x0600EAA2 RID: 60066 RVA: 0x003ED3E8 File Offset: 0x003EB5E8
			public Toggle m_inviteFriendToGroupPanelServerFriendToggle
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelServerFriendToggle;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelServerFriendToggle = value;
				}
			}

			// Token: 0x17002D5D RID: 11613
			// (get) Token: 0x0600EAA3 RID: 60067 RVA: 0x003ED3F8 File Offset: 0x003EB5F8
			// (set) Token: 0x0600EAA4 RID: 60068 RVA: 0x003ED408 File Offset: 0x003EB608
			public Toggle m_inviteFriendToGroupPanelFriendToggle
			{
				get
				{
					return this.m_owner.m_inviteFriendToGroupPanelFriendToggle;
				}
				set
				{
					this.m_owner.m_inviteFriendToGroupPanelFriendToggle = value;
				}
			}

			// Token: 0x17002D5E RID: 11614
			// (get) Token: 0x0600EAA5 RID: 60069 RVA: 0x003ED418 File Offset: 0x003EB618
			// (set) Token: 0x0600EAA6 RID: 60070 RVA: 0x003ED428 File Offset: 0x003EB628
			public CommonUIStateController m_shieldPanelUIStateController
			{
				get
				{
					return this.m_owner.m_shieldPanelUIStateController;
				}
				set
				{
					this.m_owner.m_shieldPanelUIStateController = value;
				}
			}

			// Token: 0x17002D5F RID: 11615
			// (get) Token: 0x0600EAA7 RID: 60071 RVA: 0x003ED438 File Offset: 0x003EB638
			// (set) Token: 0x0600EAA8 RID: 60072 RVA: 0x003ED448 File Offset: 0x003EB648
			public GameObject m_shieldPanelScrollView
			{
				get
				{
					return this.m_owner.m_shieldPanelScrollView;
				}
				set
				{
					this.m_owner.m_shieldPanelScrollView = value;
				}
			}

			// Token: 0x17002D60 RID: 11616
			// (get) Token: 0x0600EAA9 RID: 60073 RVA: 0x003ED458 File Offset: 0x003EB658
			// (set) Token: 0x0600EAAA RID: 60074 RVA: 0x003ED468 File Offset: 0x003EB668
			public GameObject m_shieldPanelScrollViewContent
			{
				get
				{
					return this.m_owner.m_shieldPanelScrollViewContent;
				}
				set
				{
					this.m_owner.m_shieldPanelScrollViewContent = value;
				}
			}

			// Token: 0x17002D61 RID: 11617
			// (get) Token: 0x0600EAAB RID: 60075 RVA: 0x003ED478 File Offset: 0x003EB678
			// (set) Token: 0x0600EAAC RID: 60076 RVA: 0x003ED488 File Offset: 0x003EB688
			public Button m_shieldPanelBackgroundButton
			{
				get
				{
					return this.m_owner.m_shieldPanelBackgroundButton;
				}
				set
				{
					this.m_owner.m_shieldPanelBackgroundButton = value;
				}
			}

			// Token: 0x17002D62 RID: 11618
			// (get) Token: 0x0600EAAD RID: 60077 RVA: 0x003ED498 File Offset: 0x003EB698
			// (set) Token: 0x0600EAAE RID: 60078 RVA: 0x003ED4A8 File Offset: 0x003EB6A8
			public Button m_shieldPanelCloseButton
			{
				get
				{
					return this.m_owner.m_shieldPanelCloseButton;
				}
				set
				{
					this.m_owner.m_shieldPanelCloseButton = value;
				}
			}

			// Token: 0x17002D63 RID: 11619
			// (get) Token: 0x0600EAAF RID: 60079 RVA: 0x003ED4B8 File Offset: 0x003EB6B8
			// (set) Token: 0x0600EAB0 RID: 60080 RVA: 0x003ED4C8 File Offset: 0x003EB6C8
			public Text m_shieldPanelShieldCount
			{
				get
				{
					return this.m_owner.m_shieldPanelShieldCount;
				}
				set
				{
					this.m_owner.m_shieldPanelShieldCount = value;
				}
			}

			// Token: 0x17002D64 RID: 11620
			// (get) Token: 0x0600EAB1 RID: 60081 RVA: 0x003ED4D8 File Offset: 0x003EB6D8
			// (set) Token: 0x0600EAB2 RID: 60082 RVA: 0x003ED4E8 File Offset: 0x003EB6E8
			public GameObject m_friendScrollView
			{
				get
				{
					return this.m_owner.m_friendScrollView;
				}
				set
				{
					this.m_owner.m_friendScrollView = value;
				}
			}

			// Token: 0x17002D65 RID: 11621
			// (get) Token: 0x0600EAB3 RID: 60083 RVA: 0x003ED4F8 File Offset: 0x003EB6F8
			// (set) Token: 0x0600EAB4 RID: 60084 RVA: 0x003ED508 File Offset: 0x003EB708
			public GameObject m_friendScrollViewContent
			{
				get
				{
					return this.m_owner.m_friendScrollViewContent;
				}
				set
				{
					this.m_owner.m_friendScrollViewContent = value;
				}
			}

			// Token: 0x17002D66 RID: 11622
			// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x003ED518 File Offset: 0x003EB718
			// (set) Token: 0x0600EAB6 RID: 60086 RVA: 0x003ED528 File Offset: 0x003EB728
			public GameObject m_groupScrollView
			{
				get
				{
					return this.m_owner.m_groupScrollView;
				}
				set
				{
					this.m_owner.m_groupScrollView = value;
				}
			}

			// Token: 0x17002D67 RID: 11623
			// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x003ED538 File Offset: 0x003EB738
			// (set) Token: 0x0600EAB8 RID: 60088 RVA: 0x003ED548 File Offset: 0x003EB748
			public GameObject m_groupScrollViewContent
			{
				get
				{
					return this.m_owner.m_groupScrollViewContent;
				}
				set
				{
					this.m_owner.m_groupScrollViewContent = value;
				}
			}

			// Token: 0x17002D68 RID: 11624
			// (get) Token: 0x0600EAB9 RID: 60089 RVA: 0x003ED558 File Offset: 0x003EB758
			// (set) Token: 0x0600EABA RID: 60090 RVA: 0x003ED568 File Offset: 0x003EB768
			public GameObject m_friendBigItemPrefab
			{
				get
				{
					return this.m_owner.m_friendBigItemPrefab;
				}
				set
				{
					this.m_owner.m_friendBigItemPrefab = value;
				}
			}

			// Token: 0x17002D69 RID: 11625
			// (get) Token: 0x0600EABB RID: 60091 RVA: 0x003ED578 File Offset: 0x003EB778
			// (set) Token: 0x0600EABC RID: 60092 RVA: 0x003ED588 File Offset: 0x003EB788
			public GameObject m_friendSmallItemPrefab
			{
				get
				{
					return this.m_owner.m_friendSmallItemPrefab;
				}
				set
				{
					this.m_owner.m_friendSmallItemPrefab = value;
				}
			}

			// Token: 0x17002D6A RID: 11626
			// (get) Token: 0x0600EABD RID: 60093 RVA: 0x003ED598 File Offset: 0x003EB798
			// (set) Token: 0x0600EABE RID: 60094 RVA: 0x003ED5A8 File Offset: 0x003EB7A8
			public GameObject m_groupItemPrefab
			{
				get
				{
					return this.m_owner.m_groupItemPrefab;
				}
				set
				{
					this.m_owner.m_groupItemPrefab = value;
				}
			}

			// Token: 0x17002D6B RID: 11627
			// (get) Token: 0x0600EABF RID: 60095 RVA: 0x003ED5B8 File Offset: 0x003EB7B8
			// (set) Token: 0x0600EAC0 RID: 60096 RVA: 0x003ED5C8 File Offset: 0x003EB7C8
			public int m_currentServerID
			{
				get
				{
					return this.m_owner.m_currentServerID;
				}
				set
				{
					this.m_owner.m_currentServerID = value;
				}
			}

			// Token: 0x17002D6C RID: 11628
			// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x003ED5D8 File Offset: 0x003EB7D8
			// (set) Token: 0x0600EAC2 RID: 60098 RVA: 0x003ED5E8 File Offset: 0x003EB7E8
			public ProChatGroupInfo m_currentChatGroupInfo
			{
				get
				{
					return this.m_owner.m_currentChatGroupInfo;
				}
				set
				{
					this.m_owner.m_currentChatGroupInfo = value;
				}
			}

			// Token: 0x17002D6D RID: 11629
			// (get) Token: 0x0600EAC3 RID: 60099 RVA: 0x003ED5F8 File Offset: 0x003EB7F8
			// (set) Token: 0x0600EAC4 RID: 60100 RVA: 0x003ED608 File Offset: 0x003EB808
			public bool m_isCreateNewGroup
			{
				get
				{
					return this.m_owner.m_isCreateNewGroup;
				}
				set
				{
					this.m_owner.m_isCreateNewGroup = value;
				}
			}

			// Token: 0x17002D6E RID: 11630
			// (get) Token: 0x0600EAC5 RID: 60101 RVA: 0x003ED618 File Offset: 0x003EB818
			public static int m_maxInviteToGroupCount
			{
				get
				{
					return 10;
				}
			}

			// Token: 0x17002D6F RID: 11631
			// (get) Token: 0x0600EAC6 RID: 60102 RVA: 0x003ED61C File Offset: 0x003EB81C
			// (set) Token: 0x0600EAC7 RID: 60103 RVA: 0x003ED62C File Offset: 0x003EB82C
			public List<UserSummary> m_recommendFriendList
			{
				get
				{
					return this.m_owner.m_recommendFriendList;
				}
				set
				{
					this.m_owner.m_recommendFriendList = value;
				}
			}

			// Token: 0x17002D70 RID: 11632
			// (get) Token: 0x0600EAC8 RID: 60104 RVA: 0x003ED63C File Offset: 0x003EB83C
			// (set) Token: 0x0600EAC9 RID: 60105 RVA: 0x003ED64C File Offset: 0x003EB84C
			public List<UserSummary> m_applyFriendList
			{
				get
				{
					return this.m_owner.m_applyFriendList;
				}
				set
				{
					this.m_owner.m_applyFriendList = value;
				}
			}

			// Token: 0x17002D71 RID: 11633
			// (get) Token: 0x0600EACA RID: 60106 RVA: 0x003ED65C File Offset: 0x003EB85C
			// (set) Token: 0x0600EACB RID: 60107 RVA: 0x003ED66C File Offset: 0x003EB86C
			public List<string> m_inviteToGroupList
			{
				get
				{
					return this.m_owner.m_inviteToGroupList;
				}
				set
				{
					this.m_owner.m_inviteToGroupList = value;
				}
			}

			// Token: 0x17002D72 RID: 11634
			// (get) Token: 0x0600EACC RID: 60108 RVA: 0x003ED67C File Offset: 0x003EB87C
			// (set) Token: 0x0600EACD RID: 60109 RVA: 0x003ED68C File Offset: 0x003EB88C
			public List<UserSummary> m_groupStaffList
			{
				get
				{
					return this.m_owner.m_groupStaffList;
				}
				set
				{
					this.m_owner.m_groupStaffList = value;
				}
			}

			// Token: 0x17002D73 RID: 11635
			// (get) Token: 0x0600EACE RID: 60110 RVA: 0x003ED69C File Offset: 0x003EB89C
			// (set) Token: 0x0600EACF RID: 60111 RVA: 0x003ED6AC File Offset: 0x003EB8AC
			public List<string> m_friendApplyAcceptList
			{
				get
				{
					return this.m_owner.m_friendApplyAcceptList;
				}
				set
				{
					this.m_owner.m_friendApplyAcceptList = value;
				}
			}

			// Token: 0x17002D74 RID: 11636
			// (get) Token: 0x0600EAD0 RID: 60112 RVA: 0x003ED6BC File Offset: 0x003EB8BC
			// (set) Token: 0x0600EAD1 RID: 60113 RVA: 0x003ED6CC File Offset: 0x003EB8CC
			public List<string> m_friendApplyDeclineList
			{
				get
				{
					return this.m_owner.m_friendApplyDeclineList;
				}
				set
				{
					this.m_owner.m_friendApplyDeclineList = value;
				}
			}

			// Token: 0x17002D75 RID: 11637
			// (get) Token: 0x0600EAD2 RID: 60114 RVA: 0x003ED6DC File Offset: 0x003EB8DC
			// (set) Token: 0x0600EAD3 RID: 60115 RVA: 0x003ED6EC File Offset: 0x003EB8EC
			public List<string> m_friendAddList
			{
				get
				{
					return this.m_owner.m_friendAddList;
				}
				set
				{
					this.m_owner.m_friendAddList = value;
				}
			}

			// Token: 0x17002D76 RID: 11638
			// (get) Token: 0x0600EAD4 RID: 60116 RVA: 0x003ED6FC File Offset: 0x003EB8FC
			// (set) Token: 0x0600EAD5 RID: 60117 RVA: 0x003ED70C File Offset: 0x003EB90C
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

			// Token: 0x17002D77 RID: 11639
			// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x003ED71C File Offset: 0x003EB91C
			// (set) Token: 0x0600EAD7 RID: 60119 RVA: 0x003ED72C File Offset: 0x003EB92C
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

			// Token: 0x0600EAD8 RID: 60120 RVA: 0x003ED73C File Offset: 0x003EB93C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EAD9 RID: 60121 RVA: 0x003ED74C File Offset: 0x003EB94C
			public void SetAddFriendPanel()
			{
				this.m_owner.SetAddFriendPanel();
			}

			// Token: 0x0600EADA RID: 60122 RVA: 0x003ED75C File Offset: 0x003EB95C
			public void SetInviteFriendToGroupList()
			{
				this.m_owner.SetInviteFriendToGroupList();
			}

			// Token: 0x0600EADB RID: 60123 RVA: 0x003ED76C File Offset: 0x003EB96C
			public void SetInviteAcrossServerFriendToGroupList()
			{
				this.m_owner.SetInviteAcrossServerFriendToGroupList();
			}

			// Token: 0x0600EADC RID: 60124 RVA: 0x003ED77C File Offset: 0x003EB97C
			public void SetBasicBigFriendInfo(GameObject parentScrollViewContent, List<UserSummary> userList, FriendInfoType friendInfoType, bool isChatGroupOwner)
			{
				this.m_owner.SetBasicBigFriendInfo(parentScrollViewContent, userList, friendInfoType, isChatGroupOwner);
			}

			// Token: 0x0600EADD RID: 60125 RVA: 0x003ED790 File Offset: 0x003EB990
			public void SetBasicSmallFriendInfo(GameObject parentScrollViewContent, List<UserSummary> userList, FriendInfoType friendInfoType)
			{
				this.m_owner.SetBasicSmallFriendInfo(parentScrollViewContent, userList, friendInfoType);
			}

			// Token: 0x0600EADE RID: 60126 RVA: 0x003ED7A0 File Offset: 0x003EB9A0
			public void SetServerListInfo()
			{
				this.m_owner.SetServerListInfo();
			}

			// Token: 0x0600EADF RID: 60127 RVA: 0x003ED7B0 File Offset: 0x003EB9B0
			public void OnFriendToggle(bool isOn)
			{
				this.m_owner.OnFriendToggle(isOn);
			}

			// Token: 0x0600EAE0 RID: 60128 RVA: 0x003ED7C0 File Offset: 0x003EB9C0
			public void OnAcrossServerToggle(bool isOn)
			{
				this.m_owner.OnAcrossServerToggle(isOn);
			}

			// Token: 0x0600EAE1 RID: 60129 RVA: 0x003ED7D0 File Offset: 0x003EB9D0
			public void OnRecentToggle(bool isOn)
			{
				this.m_owner.OnRecentToggle(isOn);
			}

			// Token: 0x0600EAE2 RID: 60130 RVA: 0x003ED7E0 File Offset: 0x003EB9E0
			public void OnGroupToggle(bool isOn)
			{
				this.m_owner.OnGroupToggle(isOn);
			}

			// Token: 0x0600EAE3 RID: 60131 RVA: 0x003ED7F0 File Offset: 0x003EB9F0
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600EAE4 RID: 60132 RVA: 0x003ED800 File Offset: 0x003EBA00
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600EAE5 RID: 60133 RVA: 0x003ED810 File Offset: 0x003EBA10
			public void OnShieldButtonClick()
			{
				this.m_owner.OnShieldButtonClick();
			}

			// Token: 0x0600EAE6 RID: 60134 RVA: 0x003ED820 File Offset: 0x003EBA20
			public void OnShieldPanelCloseButtonClick()
			{
				this.m_owner.OnShieldPanelCloseButtonClick();
			}

			// Token: 0x0600EAE7 RID: 60135 RVA: 0x003ED830 File Offset: 0x003EBA30
			public void OnSendAllFriendshipPointButtonClick()
			{
				this.m_owner.OnSendAllFriendshipPointButtonClick();
			}

			// Token: 0x0600EAE8 RID: 60136 RVA: 0x003ED840 File Offset: 0x003EBA40
			public void OnGetAllFriendshipPointButtonClick()
			{
				this.m_owner.OnGetAllFriendshipPointButtonClick();
			}

			// Token: 0x0600EAE9 RID: 60137 RVA: 0x003ED850 File Offset: 0x003EBA50
			public void OnAddFriendButtonClick()
			{
				this.m_owner.OnAddFriendButtonClick();
			}

			// Token: 0x0600EAEA RID: 60138 RVA: 0x003ED860 File Offset: 0x003EBA60
			public void OnAddFriendPanelCloseButtonClick()
			{
				this.m_owner.OnAddFriendPanelCloseButtonClick();
			}

			// Token: 0x0600EAEB RID: 60139 RVA: 0x003ED870 File Offset: 0x003EBA70
			public void OnSelectServerButtonClick()
			{
				this.m_owner.OnSelectServerButtonClick();
			}

			// Token: 0x0600EAEC RID: 60140 RVA: 0x003ED880 File Offset: 0x003EBA80
			public void OnServerListPanelBGButtonClick()
			{
				this.m_owner.OnServerListPanelBGButtonClick();
			}

			// Token: 0x0600EAED RID: 60141 RVA: 0x003ED890 File Offset: 0x003EBA90
			public void SetSendAllFriendshipPointButtonState()
			{
				this.m_owner.SetSendAllFriendshipPointButtonState();
			}

			// Token: 0x0600EAEE RID: 60142 RVA: 0x003ED8A0 File Offset: 0x003EBAA0
			public void SetGetAllFriendshipPointButtonState()
			{
				this.m_owner.SetGetAllFriendshipPointButtonState();
			}

			// Token: 0x0600EAEF RID: 60143 RVA: 0x003ED8B0 File Offset: 0x003EBAB0
			public void OnAddFriendPanelSearchButtonClick()
			{
				this.m_owner.OnAddFriendPanelSearchButtonClick();
			}

			// Token: 0x0600EAF0 RID: 60144 RVA: 0x003ED8C0 File Offset: 0x003EBAC0
			public void OnAddFriendPanelChangeRecommendFriendButtonClick()
			{
				this.m_owner.OnAddFriendPanelChangeRecommendFriendButtonClick();
			}

			// Token: 0x0600EAF1 RID: 60145 RVA: 0x003ED8D0 File Offset: 0x003EBAD0
			public void OnAddFriendPanelAddAllButtonClick()
			{
				this.m_owner.OnAddFriendPanelAddAllButtonClick();
			}

			// Token: 0x0600EAF2 RID: 60146 RVA: 0x003ED8E0 File Offset: 0x003EBAE0
			public void OnAddFriendPanelAcceptAllButtonClick()
			{
				this.m_owner.OnAddFriendPanelAcceptAllButtonClick();
			}

			// Token: 0x0600EAF3 RID: 60147 RVA: 0x003ED8F0 File Offset: 0x003EBAF0
			public void OnAddFriendPanelRefuseAllButtonClick()
			{
				this.m_owner.OnAddFriendPanelRefuseAllButtonClick();
			}

			// Token: 0x0600EAF4 RID: 60148 RVA: 0x003ED900 File Offset: 0x003EBB00
			public void OnWatchGroupStaffPanelCloseButtonClick()
			{
				this.m_owner.OnWatchGroupStaffPanelCloseButtonClick();
			}

			// Token: 0x0600EAF5 RID: 60149 RVA: 0x003ED910 File Offset: 0x003EBB10
			public void OnWatchGroupStaffPanelChangeNameButtonClick()
			{
				this.m_owner.OnWatchGroupStaffPanelChangeNameButtonClick();
			}

			// Token: 0x0600EAF6 RID: 60150 RVA: 0x003ED920 File Offset: 0x003EBB20
			public void OnWatchGroupStaffPanelChangeNameConfirmButtonClick()
			{
				this.m_owner.OnWatchGroupStaffPanelChangeNameConfirmButtonClick();
			}

			// Token: 0x0600EAF7 RID: 60151 RVA: 0x003ED930 File Offset: 0x003EBB30
			public void OnQuitGroupButtonClick()
			{
				this.m_owner.OnQuitGroupButtonClick();
			}

			// Token: 0x0600EAF8 RID: 60152 RVA: 0x003ED940 File Offset: 0x003EBB40
			public void OnCreateNewGroupButtonClick()
			{
				this.m_owner.OnCreateNewGroupButtonClick();
			}

			// Token: 0x0600EAF9 RID: 60153 RVA: 0x003ED950 File Offset: 0x003EBB50
			public void OnInviteFriendToGroupButtonClick()
			{
				this.m_owner.OnInviteFriendToGroupButtonClick();
			}

			// Token: 0x0600EAFA RID: 60154 RVA: 0x003ED960 File Offset: 0x003EBB60
			public void OnInviteFriendToGoupPanelConfirmButtonClick()
			{
				this.m_owner.OnInviteFriendToGoupPanelConfirmButtonClick();
			}

			// Token: 0x0600EAFB RID: 60155 RVA: 0x003ED970 File Offset: 0x003EBB70
			public void OnInviteFriendToGroupPanelServerFriendToggle(bool isOn)
			{
				this.m_owner.OnInviteFriendToGroupPanelServerFriendToggle(isOn);
			}

			// Token: 0x0600EAFC RID: 60156 RVA: 0x003ED980 File Offset: 0x003EBB80
			public void OnInviteFriendToGroupPanelFriendToggle(bool isOn)
			{
				this.m_owner.OnInviteFriendToGroupPanelFriendToggle(isOn);
			}

			// Token: 0x0600EAFD RID: 60157 RVA: 0x003ED990 File Offset: 0x003EBB90
			public void OnPlayerItemButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnPlayerItemButtonClick(ctrl);
			}

			// Token: 0x0600EAFE RID: 60158 RVA: 0x003ED9A0 File Offset: 0x003EBBA0
			public void OnPlayerItemButtonClick(FriendSmallItemUIController ctrl)
			{
				this.m_owner.OnPlayerItemButtonClick(ctrl);
			}

			// Token: 0x0600EAFF RID: 60159 RVA: 0x003ED9B0 File Offset: 0x003EBBB0
			public void OnItemAddFriendButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnItemAddFriendButtonClick(ctrl);
			}

			// Token: 0x0600EB00 RID: 60160 RVA: 0x003ED9C0 File Offset: 0x003EBBC0
			public void OnItemKickFromGroupButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnItemKickFromGroupButtonClick(ctrl);
			}

			// Token: 0x0600EB01 RID: 60161 RVA: 0x003ED9D0 File Offset: 0x003EBBD0
			public void OnUnblockPlayerButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnUnblockPlayerButtonClick(ctrl);
			}

			// Token: 0x0600EB02 RID: 60162 RVA: 0x003ED9E0 File Offset: 0x003EBBE0
			public void OnChatButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnChatButtonClick(ctrl);
			}

			// Token: 0x0600EB03 RID: 60163 RVA: 0x003ED9F0 File Offset: 0x003EBBF0
			public void OnSendFriendshipPointButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnSendFriendshipPointButtonClick(ctrl);
			}

			// Token: 0x0600EB04 RID: 60164 RVA: 0x003EDA00 File Offset: 0x003EBC00
			public void OnGetFriendshipPointButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnGetFriendshipPointButtonClick(ctrl);
			}

			// Token: 0x0600EB05 RID: 60165 RVA: 0x003EDA10 File Offset: 0x003EBC10
			public void OnFriendshipPointDoneButtonClick(FriendBigItemUIController ctrl)
			{
				this.m_owner.OnFriendshipPointDoneButtonClick(ctrl);
			}

			// Token: 0x0600EB06 RID: 60166 RVA: 0x003EDA20 File Offset: 0x003EBC20
			public void OnItemAddFriendButtonClick(FriendSmallItemUIController ctrl)
			{
				this.m_owner.OnItemAddFriendButtonClick(ctrl);
			}

			// Token: 0x0600EB07 RID: 60167 RVA: 0x003EDA30 File Offset: 0x003EBC30
			public void OnChatButtonClick(FriendSmallItemUIController ctrl)
			{
				this.m_owner.OnChatButtonClick(ctrl);
			}

			// Token: 0x0600EB08 RID: 60168 RVA: 0x003EDA40 File Offset: 0x003EBC40
			public void OnFriendApplyAceeptButtonClick(FriendSmallItemUIController ctrl)
			{
				this.m_owner.OnFriendApplyAceeptButtonClick(ctrl);
			}

			// Token: 0x0600EB09 RID: 60169 RVA: 0x003EDA50 File Offset: 0x003EBC50
			public void OnFriendApplyDeclineButtonClick(FriendSmallItemUIController ctrl)
			{
				this.m_owner.OnFriendApplyDeclineButtonClick(ctrl);
			}

			// Token: 0x0600EB0A RID: 60170 RVA: 0x003EDA60 File Offset: 0x003EBC60
			public void OnInviteFriendToGroupToggleValueChanged(bool isOn, FriendSmallItemUIController ctrl)
			{
				this.m_owner.OnInviteFriendToGroupToggleValueChanged(isOn, ctrl);
			}

			// Token: 0x0600EB0B RID: 60171 RVA: 0x003EDA70 File Offset: 0x003EBC70
			public void OnGroupChatButtonClick(FriendGroupUIController ctrl)
			{
				this.m_owner.OnGroupChatButtonClick(ctrl);
			}

			// Token: 0x0600EB0C RID: 60172 RVA: 0x003EDA80 File Offset: 0x003EBC80
			public void OnWatchGroupStaffButtonClick(FriendGroupUIController ctrl)
			{
				this.m_owner.OnWatchGroupStaffButtonClick(ctrl);
			}

			// Token: 0x04008CE3 RID: 36067
			private FriendUIController m_owner;
		}
	}
}
