using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CBC RID: 3260
	[HotFix]
	public class FriendUITask : UITask
	{
		// Token: 0x0600EC7C RID: 60540 RVA: 0x003F2790 File Offset: 0x003F0990
		public FriendUITask(string name) : base(name)
		{
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

		// Token: 0x0600EC7D RID: 60541 RVA: 0x003F28E4 File Offset: 0x003F0AE4
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
			if (this.m_friendUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_friendUIController = (this.m_uiCtrlArray[0] as FriendUIController);
				}
				if (!(this.m_friendUIController != null))
				{
					global::Debug.LogError("FriendUIController is null");
					return;
				}
				this.m_friendUIController.EventOnReturn += this.FriendUIController_OnReturn;
				this.m_friendUIController.EventOnShowHelp += this.FriendUIController_OnShowHelp;
				this.m_friendUIController.EventOnShowPanel += this.FriendUIController_OnShowPanel;
				this.m_friendUIController.EventOnShowPlayerSimpleInfo += this.FriendUIController_OnShowPlayerInfo;
				this.m_friendUIController.EventOnAddFriend += this.FriendUIController_OnAddFriend;
				this.m_friendUIController.EventOnUnblockPlayer += this.FriendUIController_OnUnblockPlayer;
				this.m_friendUIController.EventOnChat += this.FriendUIController_OnChat;
				this.m_friendUIController.EventOnSendFriendshipPoint += this.FriendUIController_OnSendFriendshipPoint;
				this.m_friendUIController.EventOnGetFriendshipPoint += this.FriendUIController_OnGetFriendshipPoint;
				this.m_friendUIController.EventOnSendAllFriendshipPoint += this.FriendUIController_OnSendAllFriendshipPoint;
				this.m_friendUIController.EventOnGetAllFriendshipPoint += this.FriendUIController_OnGetAllFriendshipPoint;
				this.m_friendUIController.EventOnFindFriend += this.FriendUIController_OnFindFriend;
				this.m_friendUIController.EventOnGetRecommendFriendsList += this.FriendUIController_OnGetRecommendFriendList;
				this.m_friendUIController.EventOnFriendApplyAceept += this.FriendUIController_OnFriendInviteAceept;
				this.m_friendUIController.EventOnFriendApplyDecline += this.FriendUIController_OnFriendInviteDecline;
				this.m_friendUIController.EventOnGroupChat += this.FriendUIController_OnGroupChat;
				this.m_friendUIController.EventOnWatchGroupStaff += this.FriendUIController_OnWatchGroupStaff;
				this.m_friendUIController.EventOnCreateNewGroup += this.FriendUIController_OnCreateNewGroup;
				this.m_friendUIController.EventOnInviteFriendToGroup += this.FriendUIController_OnInviteFriendToGroup;
				this.m_friendUIController.EventOnChangeGroupName += this.FriendUIController_OnChangeGroupName;
				this.m_friendUIController.EventOnLeaveGroup += this.FriendUIController_OnLeaveGroup;
				this.m_friendUIController.EventOnKickFromGroup += this.FriendUIController_OnKickGroup;
			}
		}

		// Token: 0x0600EC7E RID: 60542 RVA: 0x003F2B98 File Offset: 0x003F0D98
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
			if (this.m_friendUIController != null)
			{
				this.m_friendUIController.EventOnReturn -= this.FriendUIController_OnReturn;
				this.m_friendUIController.EventOnShowHelp -= this.FriendUIController_OnShowHelp;
				this.m_friendUIController.EventOnShowPanel -= this.FriendUIController_OnShowPanel;
				this.m_friendUIController.EventOnShowPlayerSimpleInfo -= this.FriendUIController_OnShowPlayerInfo;
				this.m_friendUIController.EventOnAddFriend -= this.FriendUIController_OnAddFriend;
				this.m_friendUIController.EventOnUnblockPlayer -= this.FriendUIController_OnUnblockPlayer;
				this.m_friendUIController.EventOnChat -= this.FriendUIController_OnChat;
				this.m_friendUIController.EventOnSendFriendshipPoint -= this.FriendUIController_OnSendFriendshipPoint;
				this.m_friendUIController.EventOnGetFriendshipPoint -= this.FriendUIController_OnGetFriendshipPoint;
				this.m_friendUIController.EventOnSendAllFriendshipPoint -= this.FriendUIController_OnSendAllFriendshipPoint;
				this.m_friendUIController.EventOnGetAllFriendshipPoint -= this.FriendUIController_OnGetAllFriendshipPoint;
				this.m_friendUIController.EventOnFindFriend -= this.FriendUIController_OnFindFriend;
				this.m_friendUIController.EventOnGetRecommendFriendsList -= this.FriendUIController_OnGetRecommendFriendList;
				this.m_friendUIController.EventOnFriendApplyAceept -= this.FriendUIController_OnFriendInviteAceept;
				this.m_friendUIController.EventOnFriendApplyDecline -= this.FriendUIController_OnFriendInviteDecline;
				this.m_friendUIController.EventOnGroupChat -= this.FriendUIController_OnGroupChat;
				this.m_friendUIController.EventOnWatchGroupStaff -= this.FriendUIController_OnWatchGroupStaff;
				this.m_friendUIController.EventOnCreateNewGroup -= this.FriendUIController_OnCreateNewGroup;
				this.m_friendUIController.EventOnInviteFriendToGroup -= this.FriendUIController_OnInviteFriendToGroup;
				this.m_friendUIController.EventOnChangeGroupName -= this.FriendUIController_OnChangeGroupName;
				this.m_friendUIController.EventOnLeaveGroup -= this.FriendUIController_OnLeaveGroup;
				this.m_friendUIController.EventOnKickFromGroup -= this.FriendUIController_OnKickGroup;
				this.m_friendUIController = null;
			}
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x003F2E10 File Offset: 0x003F1010
		protected override void RegisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterPlayerContextEvents_hotfix != null)
			{
				this.m_RegisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.RegisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatGroupUpdateNtf += this.PlayerContext_OnChatGroupUpdateNtf;
			}
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x003F2EA0 File Offset: 0x003F10A0
		protected override void UnregisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterPlayerContextEvents_hotfix != null)
			{
				this.m_UnregisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UnregisterPlayerContextEvents();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatGroupUpdateNtf -= this.PlayerContext_OnChatGroupUpdateNtf;
			}
		}

		// Token: 0x0600EC81 RID: 60545 RVA: 0x003F2F30 File Offset: 0x003F1130
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
			if (base.IsOpeningUI())
			{
				this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.All);
				this.m_friendUIController.SetFirstToggleOn();
				this.m_friendUIController.SetPanelScrollViewReset();
			}
			this.UpdatePanel();
		}

		// Token: 0x0600EC82 RID: 60546 RVA: 0x003F2FC0 File Offset: 0x003F11C0
		private void UpdatePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdatePanel_hotfix != null)
			{
				this.m_UpdatePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_panelType == FriendPanelType.Friend)
			{
				this.m_friendUIController.SetFriendPanel(this.m_playerContext.GetFriendList());
			}
			else if (this.m_panelType == FriendPanelType.AcrossServerFriend)
			{
				this.m_friendUIController.SetAcrossServerFriendPanel(this.m_playerContext.GetAcrossServerFriendList());
			}
			else if (this.m_panelType == FriendPanelType.Recent)
			{
				IEnumerable<UserSummary> source = this.m_playerContext.GetRecentTeamBattlePlayerList().Union(this.m_playerContext.GetRecentChatPlayerList(), new UserSummaryEqualityComparer());
				this.m_friendUIController.SetRecentPanel(source.ToList<UserSummary>());
			}
			else if (this.m_panelType == FriendPanelType.Group)
			{
				this.FriendUIController_OnGetAllGroup();
			}
			else if (this.m_panelType == FriendPanelType.Shield)
			{
				this.m_friendUIController.SetShieldPanel(this.m_playerContext.GetBlackList());
			}
			else if (this.m_panelType == FriendPanelType.AddFriend)
			{
				if (this.m_friendUIController.m_isFindFriend)
				{
					this.SetCurrentFindFriendList();
				}
				if (this.m_friendUIController.m_isRecommendFriend)
				{
					this.SetCurrentRecommedFriendList();
				}
				this.m_friendUIController.SetApplyFriendsList(this.m_playerContext.GetFriendInvitedList());
			}
			else if (this.m_panelType == FriendPanelType.FriendInviteToGroup)
			{
				this.m_friendUIController.SetInviteFriendToGroupPanel();
			}
			this.m_friendUIController.IsAddFriendRedMarkShow(this.m_playerContext.GetFriendInvitedList().Count > 0);
		}

		// Token: 0x0600EC83 RID: 60547 RVA: 0x003F3178 File Offset: 0x003F1378
		private void FriendUIController_OnShowPanel(FriendPanelType panelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnShowPanelFriendPanelType_hotfix != null)
			{
				this.m_FriendUIController_OnShowPanelFriendPanelType_hotfix.call(new object[]
				{
					this,
					panelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_panelType = panelType;
			switch (this.m_panelType)
			{
			case FriendPanelType.Friend:
				this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Friend);
				break;
			case FriendPanelType.AcrossServerFriend:
				this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Friend);
				break;
			case FriendPanelType.Shield:
				this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Blacklist);
				break;
			case FriendPanelType.AddFriend:
				this.FriendUIController_OnGetSocialRelation((FriendSocialRelationFlag)13);
				break;
			case FriendPanelType.FriendInviteToGroup:
				this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Friend);
				break;
			case FriendPanelType.Recent:
				this.FriendUIController_OnGetSocialRelation((FriendSocialRelationFlag)48);
				break;
			case FriendPanelType.Group:
				this.UpdatePanel();
				break;
			}
		}

		// Token: 0x0600EC84 RID: 60548 RVA: 0x003F3274 File Offset: 0x003F1474
		private void FriendUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnReturn_hotfix != null)
			{
				this.m_FriendUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600EC85 RID: 60549 RVA: 0x003F32F8 File Offset: 0x003F14F8
		private void FriendUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnShowHelp_hotfix != null)
			{
				this.m_FriendUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Friend);
		}

		// Token: 0x0600EC86 RID: 60550 RVA: 0x003F3364 File Offset: 0x003F1564
		private void FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag friendSocialRelationFlag = FriendSocialRelationFlag.All)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnGetSocialRelationFriendSocialRelationFlag_hotfix != null)
			{
				this.m_FriendUIController_OnGetSocialRelationFriendSocialRelationFlag_hotfix.call(new object[]
				{
					this,
					friendSocialRelationFlag
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetFriendSocialRelationNetTask getFriendSocialRelationNetTask = new GetFriendSocialRelationNetTask(friendSocialRelationFlag);
			getFriendSocialRelationNetTask.EventOnStop += delegate(Task task)
			{
				GetFriendSocialRelationNetTask getFriendSocialRelationNetTask2 = task as GetFriendSocialRelationNetTask;
				if (getFriendSocialRelationNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					this.ShowErrorMessage(getFriendSocialRelationNetTask2.Result);
				}
			};
			getFriendSocialRelationNetTask.Start(null);
		}

		// Token: 0x0600EC87 RID: 60551 RVA: 0x003F33F8 File Offset: 0x003F15F8
		private void FriendUIController_OnShowPlayerInfo(UserSummary userSummy, Vector3 pos, PlayerSimpleInfoUITask.PostionType posType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnShowPlayerInfoUserSummaryVector3PostionType_hotfix != null)
			{
				this.m_FriendUIController_OnShowPlayerInfoUserSummaryVector3PostionType_hotfix.call(new object[]
				{
					this,
					userSummy,
					pos2,
					posType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3 pos = pos2;
			PlayerSimpleInfoUITask.PostionType posType = posType2;
			FriendUITask $this = this;
			if (!this.m_playerContext.IsMe(userSummy.UserId))
			{
				BusinessCardGetNetTask businessCardGetNetTask = new BusinessCardGetNetTask(userSummy.UserId);
				businessCardGetNetTask.EventOnStop += delegate(Task task)
				{
					BusinessCardGetNetTask businessCardGetNetTask2 = task as BusinessCardGetNetTask;
					if (businessCardGetNetTask2.Result == 0)
					{
						$this.OnShowPlayerSimpleInfo(pos, posType);
					}
					else
					{
						$this.ShowErrorMessage(businessCardGetNetTask2.Result);
					}
				};
				businessCardGetNetTask.Start(null);
			}
		}

		// Token: 0x0600EC88 RID: 60552 RVA: 0x003F34E0 File Offset: 0x003F16E0
		private void OnShowPlayerSimpleInfo(Vector3 pos, PlayerSimpleInfoUITask.PostionType posType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowPlayerSimpleInfoVector3PostionType_hotfix != null)
			{
				this.m_OnShowPlayerSimpleInfoVector3PostionType_hotfix.call(new object[]
				{
					this,
					pos,
					posType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerSimpleInfoUITask playerSimpleInfoUITask = PlayerSimpleInfoUITask.ShowPlayerSimpleInfoPanel(pos, posType, this.m_currIntent, false);
			if (this.m_playerSimpleInfoUITask == null)
			{
				this.m_playerSimpleInfoUITask = playerSimpleInfoUITask;
				this.m_playerSimpleInfoUITask.EventOnClose += this.PlayerSimpleInfoUITask_OnClose;
				this.m_playerSimpleInfoUITask.EventOnGetSocialRelation += this.PlayerSimpleInfoUITask_GetSocialRelation;
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick += this.PlayerSimpleInfoUITask_OnPrivateChatButtonClick;
			}
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x003F35C8 File Offset: 0x003F17C8
		private void PlayerSimpleInfoUITask_GetSocialRelation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUITask_GetSocialRelation_hotfix != null)
			{
				this.m_PlayerSimpleInfoUITask_GetSocialRelation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.All);
		}

		// Token: 0x0600EC8A RID: 60554 RVA: 0x003F3630 File Offset: 0x003F1830
		private void PlayerSimpleInfoUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUITask_OnClose_hotfix != null)
			{
				this.m_PlayerSimpleInfoUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerSimpleInfoUITask != null)
			{
				this.m_playerSimpleInfoUITask.EventOnClose -= this.PlayerSimpleInfoUITask_OnClose;
				this.m_playerSimpleInfoUITask.EventOnGetSocialRelation -= this.PlayerSimpleInfoUITask_GetSocialRelation;
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick -= this.PlayerSimpleInfoUITask_OnPrivateChatButtonClick;
				this.m_playerSimpleInfoUITask = null;
			}
		}

		// Token: 0x0600EC8B RID: 60555 RVA: 0x003F36E8 File Offset: 0x003F18E8
		private void PlayerSimpleInfoUITask_OnPrivateChatButtonClick(BusinessCard playerInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix != null)
			{
				this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix.call(new object[]
				{
					this,
					playerInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUITask.StartChatUITaskToEnterAppointChannel(ChatChannel.Private, this.m_currIntent, playerInfo.UserId);
		}

		// Token: 0x0600EC8C RID: 60556 RVA: 0x003F376C File Offset: 0x003F196C
		private void FriendUIController_OnAddFriend(List<string> userIDList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnAddFriendList`1_hotfix != null)
			{
				this.m_FriendUIController_OnAddFriendList`1_hotfix.call(new object[]
				{
					this,
					userIDList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendAddNetTask friendAddNetTask = new FriendAddNetTask(userIDList);
			friendAddNetTask.EventOnStop += delegate(Task task)
			{
				FriendAddNetTask friendAddNetTask2 = task as FriendAddNetTask;
				this.m_invitedRecommendFriendIDList.AddRange(friendAddNetTask2.GetUserIdLIst());
				if (friendAddNetTask2.Result == 0)
				{
					this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Invite);
					this.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_InviteFriendSuccess));
				}
				else if (friendAddNetTask2.Result == -4029)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_FriendIsFull), friendAddNetTask2.FailedUser.Name));
				}
				else if (friendAddNetTask2.Result == -4031)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_AlreadyIsFriend), friendAddNetTask2.FailedUser.Name));
				}
				else if (friendAddNetTask2.Result == -4032)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_AlreadyBlock), friendAddNetTask2.FailedUser.Name));
				}
				else if (friendAddNetTask2.Result == -4033)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BeBlockedInvite), friendAddNetTask2.FailedUser.Name));
				}
				else if (friendAddNetTask2.Result == -4036)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BeInvited), friendAddNetTask2.FailedUser.Name));
				}
				else if (friendAddNetTask2.Result == -4038)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BeBlockedFriend), friendAddNetTask2.FailedUser.Name));
				}
				else
				{
					this.ShowErrorMessage(friendAddNetTask2.Result);
				}
			};
			friendAddNetTask.Start(null);
		}

		// Token: 0x0600EC8D RID: 60557 RVA: 0x003F3800 File Offset: 0x003F1A00
		private void FriendUIController_OnFriendInviteAceept(List<string> userIDList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnFriendInviteAceeptList`1_hotfix != null)
			{
				this.m_FriendUIController_OnFriendInviteAceeptList`1_hotfix.call(new object[]
				{
					this,
					userIDList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendInviteAcceptNetTask friendInviteAcceptNetTask = new FriendInviteAcceptNetTask(userIDList);
			friendInviteAcceptNetTask.EventOnStop += delegate(Task task)
			{
				FriendInviteAcceptNetTask friendInviteAcceptNetTask2 = task as FriendInviteAcceptNetTask;
				if (friendInviteAcceptNetTask2.Result == 0)
				{
					this.FriendUIController_OnGetSocialRelation((FriendSocialRelationFlag)9);
				}
				else if (friendInviteAcceptNetTask2.Result == -4029)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_FriendIsFull), friendInviteAcceptNetTask2.FailedUser.Name));
				}
				else if (friendInviteAcceptNetTask2.Result == -4031)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_AlreadyIsFriend), friendInviteAcceptNetTask2.FailedUser.Name));
				}
				else if (friendInviteAcceptNetTask2.Result == -4032)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_AlreadyBlock), friendInviteAcceptNetTask2.FailedUser.Name));
				}
				else if (friendInviteAcceptNetTask2.Result == -4033)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BeBlockedInvite), friendInviteAcceptNetTask2.FailedUser.Name));
				}
				else if (friendInviteAcceptNetTask2.Result == -4036)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BeInvited), friendInviteAcceptNetTask2.FailedUser.Name));
				}
				else if (friendInviteAcceptNetTask2.Result == -4038)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_BeBlockedFriend), friendInviteAcceptNetTask2.FailedUser.Name));
				}
				else
				{
					this.ShowErrorMessage(friendInviteAcceptNetTask2.Result);
				}
			};
			friendInviteAcceptNetTask.Start(null);
		}

		// Token: 0x0600EC8E RID: 60558 RVA: 0x003F3894 File Offset: 0x003F1A94
		private void FriendUIController_OnFriendInviteDecline(List<string> userIDList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnFriendInviteDeclineList`1_hotfix != null)
			{
				this.m_FriendUIController_OnFriendInviteDeclineList`1_hotfix.call(new object[]
				{
					this,
					userIDList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendInviteDeclineNetTask friendInviteDeclineNetTask = new FriendInviteDeclineNetTask(userIDList);
			friendInviteDeclineNetTask.EventOnStop += delegate(Task task)
			{
				FriendInviteDeclineNetTask friendInviteDeclineNetTask2 = task as FriendInviteDeclineNetTask;
				if (friendInviteDeclineNetTask2.Result == 0)
				{
					this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Invited);
				}
				else
				{
					this.ShowErrorMessage(friendInviteDeclineNetTask2.Result);
				}
			};
			friendInviteDeclineNetTask.Start(null);
		}

		// Token: 0x0600EC8F RID: 60559 RVA: 0x003F3928 File Offset: 0x003F1B28
		private void FriendUIController_OnUnblockPlayer(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnUnblockPlayerString_hotfix != null)
			{
				this.m_FriendUIController_OnUnblockPlayerString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unblockPlayerUserID = userID;
			CommonUIController.Instance.ShowDialogBox(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_ConfirmUnblockPlayer), new Action<DialogBoxResult>(this.UnblockPlayerCallback), string.Empty, null);
		}

		// Token: 0x0600EC90 RID: 60560 RVA: 0x003F39CC File Offset: 0x003F1BCC
		private void UnblockPlayerCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnblockPlayerCallbackDialogBoxResult_hotfix != null)
			{
				this.m_UnblockPlayerCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				PlayerUnblockNetTask playerUnblockNetTask = new PlayerUnblockNetTask(this.m_unblockPlayerUserID);
				playerUnblockNetTask.EventOnStop += delegate(Task task)
				{
					PlayerUnblockNetTask playerUnblockNetTask2 = task as PlayerUnblockNetTask;
					if (playerUnblockNetTask2.Result == 0)
					{
						this.FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag.Blacklist);
						this.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_UnblockPlayerSuccess));
					}
					else
					{
						this.ShowErrorMessage(playerUnblockNetTask2.Result);
					}
				};
				playerUnblockNetTask.Start(null);
			}
		}

		// Token: 0x0600EC91 RID: 60561 RVA: 0x003F3A6C File Offset: 0x003F1C6C
		private void FriendUIController_OnFindFriend(int bornChannelID, string partialName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnFindFriendInt32String_hotfix != null)
			{
				this.m_FriendUIController_OnFindFriendInt32String_hotfix.call(new object[]
				{
					this,
					bornChannelID,
					partialName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendFindNetTask friendFindNetTask = new FriendFindNetTask(bornChannelID, partialName);
			friendFindNetTask.EventOnStop += delegate(Task task)
			{
				FriendFindNetTask friendFindNetTask2 = task as FriendFindNetTask;
				if (friendFindNetTask2.Result == 0)
				{
					this.m_friendUIController.SetFindFriendList(this.m_playerContext.GetFindFriendList());
				}
				else
				{
					this.ShowErrorMessage(friendFindNetTask2.Result);
				}
			};
			friendFindNetTask.Start(null);
		}

		// Token: 0x0600EC92 RID: 60562 RVA: 0x003F3B10 File Offset: 0x003F1D10
		private void SetCurrentFindFriendList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentFindFriendList_hotfix != null)
			{
				this.m_SetCurrentFindFriendList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_findFriendList.Clear();
			using (List<UserSummary>.Enumerator enumerator = this.m_playerContext.GetFindFriendList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					UserSummary i = enumerator.Current;
					if (this.m_playerContext.GetFriendInviteList().FindIndex((UserSummary f) => f.UserId == i.UserId) < 0)
					{
						this.m_findFriendList.Add(i);
					}
				}
			}
			this.m_friendUIController.SetFindFriendList(this.m_findFriendList);
		}

		// Token: 0x0600EC93 RID: 60563 RVA: 0x003F3C18 File Offset: 0x003F1E18
		private void FriendUIController_OnGetRecommendFriendList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnGetRecommendFriendList_hotfix != null)
			{
				this.m_FriendUIController_OnGetRecommendFriendList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendSuggestedNetTask friendSuggestedNetTask = new FriendSuggestedNetTask();
			friendSuggestedNetTask.EventOnStop += delegate(Task task)
			{
				FriendSuggestedNetTask friendSuggestedNetTask2 = task as FriendSuggestedNetTask;
				if (friendSuggestedNetTask2.Result == 0)
				{
					this.m_invitedRecommendFriendIDList.Clear();
					this.m_friendUIController.SetRecommendFriendsList(this.m_playerContext.GetRecommendFriendList());
				}
				else
				{
					this.ShowErrorMessage(friendSuggestedNetTask2.Result);
				}
			};
			friendSuggestedNetTask.Start(null);
		}

		// Token: 0x0600EC94 RID: 60564 RVA: 0x003F3C98 File Offset: 0x003F1E98
		private void SetCurrentRecommedFriendList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentRecommedFriendList_hotfix != null)
			{
				this.m_SetCurrentRecommedFriendList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_recommendFriendList.Clear();
			using (List<UserSummary>.Enumerator enumerator = this.m_playerContext.GetRecommendFriendList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					UserSummary i = enumerator.Current;
					if (this.m_invitedRecommendFriendIDList.FindIndex((string f) => f == i.UserId) < 0)
					{
						this.m_recommendFriendList.Add(i);
					}
				}
			}
			this.m_friendUIController.SetRecommendFriendsList(this.m_recommendFriendList);
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x003F3D9C File Offset: 0x003F1F9C
		private void FriendUIController_OnGetAllGroup()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnGetAllGroup_hotfix != null)
			{
				this.m_FriendUIController_OnGetAllGroup_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendGroupAllGetNetTask friendGroupAllGetNetTask = new FriendGroupAllGetNetTask();
			friendGroupAllGetNetTask.EventOnStop += delegate(Task task)
			{
				FriendGroupAllGetNetTask friendGroupAllGetNetTask2 = task as FriendGroupAllGetNetTask;
				if (friendGroupAllGetNetTask2.Result == 0)
				{
					this.m_friendUIController.SetGroupPanel(friendGroupAllGetNetTask2.ChatGroupList);
				}
				else
				{
					this.ShowErrorMessage(friendGroupAllGetNetTask2.Result);
				}
			};
			friendGroupAllGetNetTask.Start(null);
		}

		// Token: 0x0600EC96 RID: 60566 RVA: 0x003F3E1C File Offset: 0x003F201C
		private void FriendUIController_OnGroupChat(string groupID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnGroupChatString_hotfix != null)
			{
				this.m_FriendUIController_OnGroupChatString_hotfix.call(new object[]
				{
					this,
					groupID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUITask.StartChatUITaskToEnterAppointChannel(ChatChannel.Group, this.m_currIntent, groupID);
		}

		// Token: 0x0600EC97 RID: 60567 RVA: 0x003F3E9C File Offset: 0x003F209C
		private void FriendUIController_OnWatchGroupStaff(string groupID, bool needOpenTween)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnWatchGroupStaffStringBoolean_hotfix != null)
			{
				this.m_FriendUIController_OnWatchGroupStaffStringBoolean_hotfix.call(new object[]
				{
					this,
					groupID,
					needOpenTween2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool needOpenTween = needOpenTween2;
			FriendUITask $this = this;
			FriendGroupMemberGetNetTask friendGroupMemberGetNetTask = new FriendGroupMemberGetNetTask(groupID);
			friendGroupMemberGetNetTask.EventOnStop += delegate(Task task)
			{
				FriendGroupMemberGetNetTask friendGroupMemberGetNetTask2 = task as FriendGroupMemberGetNetTask;
				if (friendGroupMemberGetNetTask2.Result == 0)
				{
					$this.m_friendUIController.SetWatchGroupStaffPanel(friendGroupMemberGetNetTask2.ChatGroupInfo, needOpenTween);
				}
				else
				{
					if (friendGroupMemberGetNetTask2.Result == -4309)
					{
						$this.FriendUIController_OnGetAllGroup();
						$this.m_friendUIController.GroupDissolved(friendGroupMemberGetNetTask2.ChatGroupInfo);
					}
					$this.ShowErrorMessage(friendGroupMemberGetNetTask2.Result);
				}
			};
			friendGroupMemberGetNetTask.Start(null);
		}

		// Token: 0x0600EC98 RID: 60568 RVA: 0x003F3F54 File Offset: 0x003F2154
		private void FriendUIController_OnCreateNewGroup(List<string> userIDList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnCreateNewGroupList`1_hotfix != null)
			{
				this.m_FriendUIController_OnCreateNewGroupList`1_hotfix.call(new object[]
				{
					this,
					userIDList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FriendGroupCreateNetTask friendGroupCreateNetTask = new FriendGroupCreateNetTask(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_DefaultGroupName), userIDList);
			friendGroupCreateNetTask.EventOnStop += delegate(Task task)
			{
				FriendGroupCreateNetTask friendGroupCreateNetTask2 = task as FriendGroupCreateNetTask;
				if (friendGroupCreateNetTask2.Result == 0)
				{
					this.FriendUIController_OnGetAllGroup();
					this.m_friendUIController.InviteFriendToGoupPanelClose();
					this.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_CreateGroupSuccess));
				}
				else if (friendGroupCreateNetTask2.Result == -4310)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_GroupMemberHaveRestCount), this.m_configDataLoader.ConfigableConstId_MaxGroupMembers));
				}
				else if (friendGroupCreateNetTask2.Result == -4311)
				{
					this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_GroupIsFull), friendGroupCreateNetTask2.FailedUser.CompactInfo.Name));
				}
				else
				{
					this.ShowErrorMessage(friendGroupCreateNetTask2.Result);
				}
			};
			friendGroupCreateNetTask.Start(null);
		}

		// Token: 0x0600EC99 RID: 60569 RVA: 0x003F3FF8 File Offset: 0x003F21F8
		private void FriendUIController_OnInviteFriendToGroup(string groupID, List<string> userIDList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnInviteFriendToGroupStringList`1_hotfix != null)
			{
				this.m_FriendUIController_OnInviteFriendToGroupStringList`1_hotfix.call(new object[]
				{
					this,
					groupID2,
					userIDList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string groupID = groupID2;
			FriendUITask $this = this;
			FriendInviteToGroupGetNetTask friendInviteToGroupGetNetTask = new FriendInviteToGroupGetNetTask(groupID, userIDList);
			friendInviteToGroupGetNetTask.EventOnStop += delegate(Task task)
			{
				FriendInviteToGroupGetNetTask friendInviteToGroupGetNetTask2 = task as FriendInviteToGroupGetNetTask;
				if (friendInviteToGroupGetNetTask2.Result == 0)
				{
					$this.FriendUIController_OnWatchGroupStaff(groupID, false);
					$this.m_friendUIController.InviteFriendToGoupPanelClose();
				}
				else if (friendInviteToGroupGetNetTask2.Result == -4310)
				{
					$this.ShowMessage(string.Format($this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_GroupMemberHaveRestCount), $this.m_configDataLoader.ConfigableConstId_MaxGroupMembers - friendInviteToGroupGetNetTask2.ChatGroupInfo.CompactInfo.UserCount));
				}
				else if (friendInviteToGroupGetNetTask2.Result == -4311)
				{
					$this.ShowMessage(string.Format($this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_GroupIsFull), friendInviteToGroupGetNetTask2.FailedUser.CompactInfo.Name));
				}
				else
				{
					$this.ShowErrorMessage(friendInviteToGroupGetNetTask2.Result);
				}
			};
			friendInviteToGroupGetNetTask.Start(null);
		}

		// Token: 0x0600EC9A RID: 60570 RVA: 0x003F40B4 File Offset: 0x003F22B4
		private void FriendUIController_OnChangeGroupName(string groupID, string newName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnChangeGroupNameStringString_hotfix != null)
			{
				this.m_FriendUIController_OnChangeGroupNameStringString_hotfix.call(new object[]
				{
					this,
					groupID2,
					newName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string groupID = groupID2;
			FriendUITask $this = this;
			FriendGroupChangeNameNetTask friendGroupChangeNameNetTask = new FriendGroupChangeNameNetTask(groupID, newName);
			friendGroupChangeNameNetTask.EventOnStop += delegate(Task task)
			{
				FriendGroupChangeNameNetTask friendGroupChangeNameNetTask2 = task as FriendGroupChangeNameNetTask;
				if (friendGroupChangeNameNetTask2.Result == 0)
				{
					$this.m_friendUIController.OnWatchGroupStaffPanelChangeNamePanelBGButtonClick();
					$this.FriendUIController_OnWatchGroupStaff(groupID, false);
				}
				else
				{
					$this.ShowErrorMessage(friendGroupChangeNameNetTask2.Result);
				}
			};
			friendGroupChangeNameNetTask.Start(null);
		}

		// Token: 0x0600EC9B RID: 60571 RVA: 0x003F4170 File Offset: 0x003F2370
		private void FriendUIController_OnLeaveGroup(ProChatGroupInfo chatGroupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnLeaveGroupProChatGroupInfo_hotfix != null)
			{
				this.m_FriendUIController_OnLeaveGroupProChatGroupInfo_hotfix.call(new object[]
				{
					this,
					chatGroupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentGroupInfo = chatGroupInfo;
			this.m_playerContext.ClearGroupChatTarget();
			CommonUIController.Instance.ShowDialogBox(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_ConfirmLeaveGroup), chatGroupInfo.CompactInfo.ChatGroupName), new Action<DialogBoxResult>(this.OnLeaveGroupDialogBoxCallback), string.Empty, null);
		}

		// Token: 0x0600EC9C RID: 60572 RVA: 0x003F4230 File Offset: 0x003F2430
		private void OnLeaveGroupDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLeaveGroupDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_OnLeaveGroupDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				string userId = this.m_playerContext.GetUserId();
				if (userId == this.m_currentGroupInfo.CompactInfo.Owner.UserId)
				{
					string userID = string.Empty;
					List<ProChatUserInfo> list = new List<ProChatUserInfo>();
					foreach (ProChatUserInfo proChatUserInfo in this.m_currentGroupInfo.Members)
					{
						if (!(proChatUserInfo.CompactInfo.UserId == userId))
						{
							list.InsertInOrder(proChatUserInfo, delegate(ProChatUserInfo x, ProChatUserInfo y)
							{
								if (x.CompactInfo.Online && !y.CompactInfo.Online)
								{
									return -1;
								}
								if (!x.CompactInfo.Online && y.CompactInfo.Online)
								{
									return 1;
								}
								if (x.LogoutTime == y.LogoutTime)
								{
									return x.GetHashCode() - y.GetHashCode();
								}
								return (x.LogoutTime >= y.LogoutTime) ? 1 : -1;
							}, true);
							if (list.Count > 0)
							{
								userID = list[0].CompactInfo.UserId;
							}
						}
					}
					FriendGroupChangeOwnerNetTask friendGroupChangeOwnerNetTask = new FriendGroupChangeOwnerNetTask(this.m_currentGroupInfo.CompactInfo.ChatGroupId, userID);
					friendGroupChangeOwnerNetTask.EventOnStop += delegate(Task taskChangeOwner)
					{
						FriendGroupChangeOwnerNetTask friendGroupChangeOwnerNetTask2 = taskChangeOwner as FriendGroupChangeOwnerNetTask;
						if (friendGroupChangeOwnerNetTask2.Result == 0)
						{
							FriendLeaveChatGroupNetTask friendLeaveChatGroupNetTask2 = new FriendLeaveChatGroupNetTask(this.m_currentGroupInfo.CompactInfo.ChatGroupId);
							friendLeaveChatGroupNetTask2.EventOnStop += delegate(Task taskLeave)
							{
								FriendLeaveChatGroupNetTask friendLeaveChatGroupNetTask3 = taskLeave as FriendLeaveChatGroupNetTask;
								if (friendLeaveChatGroupNetTask3.Result == 0)
								{
									this.FriendUIController_OnShowPanel(FriendPanelType.Group);
									this.m_friendUIController.WatchGroupStaffPanelClose();
									this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_LeaveGroupSuccess), this.m_currentGroupInfo.CompactInfo.ChatGroupName));
								}
								else
								{
									this.ShowErrorMessage(friendLeaveChatGroupNetTask3.Result);
								}
							};
							friendLeaveChatGroupNetTask2.Start(null);
						}
						else
						{
							this.ShowErrorMessage(friendGroupChangeOwnerNetTask2.Result);
						}
					};
					friendGroupChangeOwnerNetTask.Start(null);
				}
				else
				{
					FriendLeaveChatGroupNetTask friendLeaveChatGroupNetTask = new FriendLeaveChatGroupNetTask(this.m_currentGroupInfo.CompactInfo.ChatGroupId);
					friendLeaveChatGroupNetTask.EventOnStop += delegate(Task task)
					{
						FriendLeaveChatGroupNetTask friendLeaveChatGroupNetTask2 = task as FriendLeaveChatGroupNetTask;
						if (friendLeaveChatGroupNetTask2.Result == 0)
						{
							this.FriendUIController_OnShowPanel(FriendPanelType.Group);
							this.m_friendUIController.WatchGroupStaffPanelClose();
							this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_LeaveGroupSuccess), this.m_currentGroupInfo.CompactInfo.ChatGroupName));
						}
						else
						{
							this.ShowErrorMessage(friendLeaveChatGroupNetTask2.Result);
						}
					};
					friendLeaveChatGroupNetTask.Start(null);
				}
			}
		}

		// Token: 0x0600EC9D RID: 60573 RVA: 0x003F43F8 File Offset: 0x003F25F8
		private void FriendUIController_OnKickGroup(ProChatGroupInfo chatGroupInfo, UserSummary userSummy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnKickGroupProChatGroupInfoUserSummary_hotfix != null)
			{
				this.m_FriendUIController_OnKickGroupProChatGroupInfoUserSummary_hotfix.call(new object[]
				{
					this,
					chatGroupInfo,
					userSummy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentGroupInfo = chatGroupInfo;
			this.m_kickPlayerUserID = userSummy.UserId;
			this.m_kickPlayerUserName = userSummy.Name;
			CommonUIController.Instance.ShowDialogBox(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_ConfirmKickGroup), userSummy.Name), new Action<DialogBoxResult>(this.OnKickFromGroupDialogBoxCallback), string.Empty, null);
		}

		// Token: 0x0600EC9E RID: 60574 RVA: 0x003F44D0 File Offset: 0x003F26D0
		private void OnKickFromGroupDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnKickFromGroupDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_OnKickFromGroupDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				int oldChatGroupMemberCount = this.m_currentGroupInfo.Members.Count;
				FriendKickChatGroupNetTask friendKickChatGroupNetTask = new FriendKickChatGroupNetTask(this.m_currentGroupInfo.CompactInfo.ChatGroupId, this.m_kickPlayerUserID);
				friendKickChatGroupNetTask.EventOnStop += delegate(Task task)
				{
					FriendKickChatGroupNetTask friendKickChatGroupNetTask2 = task as FriendKickChatGroupNetTask;
					if (friendKickChatGroupNetTask2.Result == 0)
					{
						this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_KickGroupSuccess), this.m_kickPlayerUserName));
						if (oldChatGroupMemberCount > this.m_configDataLoader.ConfigableConstId_ChatGroupDisbandUserCount)
						{
							this.FriendUIController_OnWatchGroupStaff(this.m_currentGroupInfo.CompactInfo.ChatGroupId, false);
						}
					}
					else
					{
						this.ShowErrorMessage(friendKickChatGroupNetTask2.Result);
					}
				};
				friendKickChatGroupNetTask.Start(null);
			}
		}

		// Token: 0x0600EC9F RID: 60575 RVA: 0x003F45A0 File Offset: 0x003F27A0
		private void FriendUIController_OnChat(UserSummary userSummy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnChatUserSummary_hotfix != null)
			{
				this.m_FriendUIController_OnChatUserSummary_hotfix.call(new object[]
				{
					this,
					userSummy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUITask.StartChatUITaskToEnterAppointChannel(ChatChannel.Private, this.m_currIntent, userSummy.UserId);
		}

		// Token: 0x0600ECA0 RID: 60576 RVA: 0x003F4624 File Offset: 0x003F2824
		private void FriendUIController_OnSendFriendshipPoint(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnSendFriendshipPointString_hotfix != null)
			{
				this.m_FriendUIController_OnSendFriendshipPointString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sendFriendshipPointUserIDList.Clear();
			this.m_sendFriendshipPointUserIDList.Add(userID);
			FriendShipPointsSendNetTask friendShipPointsSendNetTask = new FriendShipPointsSendNetTask(this.m_sendFriendshipPointUserIDList);
			friendShipPointsSendNetTask.EventOnStop += delegate(Task task)
			{
				FriendShipPointsSendNetTask friendShipPointsSendNetTask2 = task as FriendShipPointsSendNetTask;
				if (friendShipPointsSendNetTask2.Result == 0)
				{
					this.m_friendUIController.SetFriendPanel(this.m_playerContext.GetFriendList());
					this.m_friendUIController.ShowFriendShipPointTip(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_SendFriendShipPointSuccess));
				}
				else
				{
					this.FriendUIController_OnShowPanel(FriendPanelType.Friend);
					this.m_friendUIController.ShowFriendShipPointTip((this.m_configDataLoader as ClientConfigDataLoader).UtilityGetErrorCodeString(friendShipPointsSendNetTask2.Result));
				}
			};
			friendShipPointsSendNetTask.Start(null);
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x003F46D4 File Offset: 0x003F28D4
		private void FriendUIController_OnGetFriendshipPoint(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnGetFriendshipPointString_hotfix != null)
			{
				this.m_FriendUIController_OnGetFriendshipPointString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_getFriendshipPointUserIDList.Clear();
			this.m_getFriendshipPointUserIDList.Add(userID);
			FriendShipPointsClaimNetTask friendShipPointsClaimNetTask = new FriendShipPointsClaimNetTask(this.m_getFriendshipPointUserIDList);
			friendShipPointsClaimNetTask.EventOnStop += delegate(Task task)
			{
				FriendShipPointsClaimNetTask friendShipPointsClaimNetTask2 = task as FriendShipPointsClaimNetTask;
				if (friendShipPointsClaimNetTask2.Result == 0)
				{
					this.m_friendUIController.SetFriendPanel(this.m_playerContext.GetFriendList());
					this.m_friendUIController.ShowFriendShipPointTip(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_ReceiveFriendShipPoint), this.m_configDataLoader.ConfigableConstId_SendFriendShipPointsEverytime));
				}
				else
				{
					this.FriendUIController_OnShowPanel(FriendPanelType.Friend);
					this.m_friendUIController.ShowFriendShipPointTip((this.m_configDataLoader as ClientConfigDataLoader).UtilityGetErrorCodeString(friendShipPointsClaimNetTask2.Result));
				}
			};
			friendShipPointsClaimNetTask.Start(null);
		}

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x003F4784 File Offset: 0x003F2984
		private void FriendUIController_OnSendAllFriendshipPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnSendAllFriendshipPoint_hotfix != null)
			{
				this.m_FriendUIController_OnSendAllFriendshipPoint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sendFriendshipPointUserIDList.Clear();
			foreach (UserSummary userSummary in this.m_playerContext.GetFriendList())
			{
				if (!this.m_playerContext.HasSentFriendShipPoints(userSummary.UserId))
				{
					this.m_sendFriendshipPointUserIDList.Add(userSummary.UserId);
				}
			}
			FriendShipPointsSendNetTask friendShipPointsSendNetTask = new FriendShipPointsSendNetTask(this.m_sendFriendshipPointUserIDList);
			friendShipPointsSendNetTask.EventOnStop += delegate(Task task)
			{
				FriendShipPointsSendNetTask friendShipPointsSendNetTask2 = task as FriendShipPointsSendNetTask;
				if (friendShipPointsSendNetTask2.Result == 0)
				{
					this.m_friendUIController.SetFriendPanel(this.m_playerContext.GetFriendList());
					this.m_friendUIController.ShowFriendShipPointTip(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_SendFriendShipPointSuccess));
				}
				else
				{
					this.FriendUIController_OnShowPanel(FriendPanelType.Friend);
					this.m_friendUIController.ShowFriendShipPointTip((this.m_configDataLoader as ClientConfigDataLoader).UtilityGetErrorCodeString(friendShipPointsSendNetTask2.Result));
				}
			};
			friendShipPointsSendNetTask.Start(null);
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x003F488C File Offset: 0x003F2A8C
		private void FriendUIController_OnGetAllFriendshipPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FriendUIController_OnGetAllFriendshipPoint_hotfix != null)
			{
				this.m_FriendUIController_OnGetAllFriendshipPoint_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_getFriendshipPointUserIDList.Clear();
			foreach (UserSummary userSummary in this.m_playerContext.GetFriendList())
			{
				if (this.m_playerContext.HasReceivedFriendShipPoints(userSummary.UserId))
				{
					this.m_getFriendshipPointUserIDList.Add(userSummary.UserId);
				}
			}
			FriendShipPointsClaimNetTask friendShipPointsClaimNetTask = new FriendShipPointsClaimNetTask(this.m_getFriendshipPointUserIDList);
			friendShipPointsClaimNetTask.EventOnStop += delegate(Task task)
			{
				FriendShipPointsClaimNetTask friendShipPointsClaimNetTask2 = task as FriendShipPointsClaimNetTask;
				if (friendShipPointsClaimNetTask2.Result == 0)
				{
					this.m_friendUIController.SetFriendPanel(this.m_playerContext.GetFriendList());
					this.m_friendUIController.ShowFriendShipPointTip(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_ReceiveFriendShipPoint), this.m_configDataLoader.ConfigableConstId_SendFriendShipPointsEverytime * friendShipPointsClaimNetTask2.GetFriendshipPointPlayerCount));
				}
				else
				{
					this.FriendUIController_OnShowPanel(FriendPanelType.Friend);
					this.m_friendUIController.ShowFriendShipPointTip((this.m_configDataLoader as ClientConfigDataLoader).UtilityGetErrorCodeString(friendShipPointsClaimNetTask2.Result));
				}
			};
			friendShipPointsClaimNetTask.Start(null);
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x003F4994 File Offset: 0x003F2B94
		private void PlayerContext_OnChatGroupUpdateNtf(ProChatGroupInfo chatGroupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnChatGroupUpdateNtfProChatGroupInfo_hotfix != null)
			{
				this.m_PlayerContext_OnChatGroupUpdateNtfProChatGroupInfo_hotfix.call(new object[]
				{
					this,
					chatGroupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatGroupInfo.Members.Count <= 1)
			{
				this.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_GroupDissolved), chatGroupInfo.CompactInfo.ChatGroupName));
				this.m_friendUIController.GroupDissolved(chatGroupInfo);
				this.FriendUIController_OnShowPanel(FriendPanelType.Group);
			}
			if (!this.isMeInTheGroup(chatGroupInfo))
			{
				this.m_friendUIController.GroupDissolved(chatGroupInfo);
				this.FriendUIController_OnShowPanel(FriendPanelType.Group);
			}
		}

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x003F4A70 File Offset: 0x003F2C70
		private bool isMeInTheGroup(ProChatGroupInfo chatGroupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_isMeInTheGroupProChatGroupInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_isMeInTheGroupProChatGroupInfo_hotfix.call(new object[]
				{
					this,
					chatGroupInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ProChatUserInfo proChatUserInfo in chatGroupInfo.Members)
			{
				if (proChatUserInfo.CompactInfo.UserId == this.m_playerContext.GetUserId())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600ECA6 RID: 60582 RVA: 0x003F4B60 File Offset: 0x003F2D60
		private void ShowErrorMessage(int errorCode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowErrorMessageInt32_hotfix != null)
			{
				this.m_ShowErrorMessageInt32_hotfix.call(new object[]
				{
					this,
					errorCode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			this.m_friendUIController.ShowFriendShipPointTip(clientConfigDataLoader.UtilityGetErrorCodeString(errorCode));
		}

		// Token: 0x0600ECA7 RID: 60583 RVA: 0x003F4BF4 File Offset: 0x003F2DF4
		private void ShowMessage(string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageString_hotfix != null)
			{
				this.m_ShowMessageString_hotfix.call(new object[]
				{
					this,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_friendUIController.ShowFriendShipPointTip(text);
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x0600ECA8 RID: 60584 RVA: 0x003F4C70 File Offset: 0x003F2E70
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

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x0600ECA9 RID: 60585 RVA: 0x003F4CE4 File Offset: 0x003F2EE4
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

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x0600ECAA RID: 60586 RVA: 0x003F4D58 File Offset: 0x003F2F58
		// (set) Token: 0x0600ECAB RID: 60587 RVA: 0x003F4D78 File Offset: 0x003F2F78
		[DoNotToLua]
		public new FriendUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600ECAC RID: 60588 RVA: 0x003F4D84 File Offset: 0x003F2F84
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600ECAD RID: 60589 RVA: 0x003F4D90 File Offset: 0x003F2F90
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600ECAE RID: 60590 RVA: 0x003F4D98 File Offset: 0x003F2F98
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600ECAF RID: 60591 RVA: 0x003F4DA0 File Offset: 0x003F2FA0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600ECB0 RID: 60592 RVA: 0x003F4DAC File Offset: 0x003F2FAC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600ECB1 RID: 60593 RVA: 0x003F4DB8 File Offset: 0x003F2FB8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600ECB2 RID: 60594 RVA: 0x003F4DC4 File Offset: 0x003F2FC4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600ECB3 RID: 60595 RVA: 0x003F4DCC File Offset: 0x003F2FCC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600ECB4 RID: 60596 RVA: 0x003F4DD4 File Offset: 0x003F2FD4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600ECB5 RID: 60597 RVA: 0x003F4DDC File Offset: 0x003F2FDC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600ECB6 RID: 60598 RVA: 0x003F4DE4 File Offset: 0x003F2FE4
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600ECB7 RID: 60599 RVA: 0x003F4DEC File Offset: 0x003F2FEC
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600ECB8 RID: 60600 RVA: 0x003F4DF4 File Offset: 0x003F2FF4
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600ECB9 RID: 60601 RVA: 0x003F4DFC File Offset: 0x003F2FFC
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600ECBA RID: 60602 RVA: 0x003F4E08 File Offset: 0x003F3008
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600ECBB RID: 60603 RVA: 0x003F4E14 File Offset: 0x003F3014
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600ECBC RID: 60604 RVA: 0x003F4E20 File Offset: 0x003F3020
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600ECBD RID: 60605 RVA: 0x003F4E2C File Offset: 0x003F302C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600ECBE RID: 60606 RVA: 0x003F4E34 File Offset: 0x003F3034
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600ECBF RID: 60607 RVA: 0x003F4E3C File Offset: 0x003F303C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600ECC0 RID: 60608 RVA: 0x003F4E44 File Offset: 0x003F3044
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600ECC1 RID: 60609 RVA: 0x003F4E4C File Offset: 0x003F304C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600ECC2 RID: 60610 RVA: 0x003F4E54 File Offset: 0x003F3054
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600ECD5 RID: 60629 RVA: 0x003F5848 File Offset: 0x003F3A48
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdatePanel_hotfix = (luaObj.RawGet("UpdatePanel") as LuaFunction);
					this.m_FriendUIController_OnShowPanelFriendPanelType_hotfix = (luaObj.RawGet("FriendUIController_OnShowPanel") as LuaFunction);
					this.m_FriendUIController_OnReturn_hotfix = (luaObj.RawGet("FriendUIController_OnReturn") as LuaFunction);
					this.m_FriendUIController_OnShowHelp_hotfix = (luaObj.RawGet("FriendUIController_OnShowHelp") as LuaFunction);
					this.m_FriendUIController_OnGetSocialRelationFriendSocialRelationFlag_hotfix = (luaObj.RawGet("FriendUIController_OnGetSocialRelation") as LuaFunction);
					this.m_FriendUIController_OnShowPlayerInfoUserSummaryVector3PostionType_hotfix = (luaObj.RawGet("FriendUIController_OnShowPlayerInfo") as LuaFunction);
					this.m_OnShowPlayerSimpleInfoVector3PostionType_hotfix = (luaObj.RawGet("OnShowPlayerSimpleInfo") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_GetSocialRelation_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_GetSocialRelation") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_OnClose_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_OnClose") as LuaFunction);
					this.m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix = (luaObj.RawGet("PlayerSimpleInfoUITask_OnPrivateChatButtonClick") as LuaFunction);
					this.m_FriendUIController_OnAddFriendList`1_hotfix = (luaObj.RawGet("FriendUIController_OnAddFriend") as LuaFunction);
					this.m_FriendUIController_OnFriendInviteAceeptList`1_hotfix = (luaObj.RawGet("FriendUIController_OnFriendInviteAceept") as LuaFunction);
					this.m_FriendUIController_OnFriendInviteDeclineList`1_hotfix = (luaObj.RawGet("FriendUIController_OnFriendInviteDecline") as LuaFunction);
					this.m_FriendUIController_OnUnblockPlayerString_hotfix = (luaObj.RawGet("FriendUIController_OnUnblockPlayer") as LuaFunction);
					this.m_UnblockPlayerCallbackDialogBoxResult_hotfix = (luaObj.RawGet("UnblockPlayerCallback") as LuaFunction);
					this.m_FriendUIController_OnFindFriendInt32String_hotfix = (luaObj.RawGet("FriendUIController_OnFindFriend") as LuaFunction);
					this.m_SetCurrentFindFriendList_hotfix = (luaObj.RawGet("SetCurrentFindFriendList") as LuaFunction);
					this.m_FriendUIController_OnGetRecommendFriendList_hotfix = (luaObj.RawGet("FriendUIController_OnGetRecommendFriendList") as LuaFunction);
					this.m_SetCurrentRecommedFriendList_hotfix = (luaObj.RawGet("SetCurrentRecommedFriendList") as LuaFunction);
					this.m_FriendUIController_OnGetAllGroup_hotfix = (luaObj.RawGet("FriendUIController_OnGetAllGroup") as LuaFunction);
					this.m_FriendUIController_OnGroupChatString_hotfix = (luaObj.RawGet("FriendUIController_OnGroupChat") as LuaFunction);
					this.m_FriendUIController_OnWatchGroupStaffStringBoolean_hotfix = (luaObj.RawGet("FriendUIController_OnWatchGroupStaff") as LuaFunction);
					this.m_FriendUIController_OnCreateNewGroupList`1_hotfix = (luaObj.RawGet("FriendUIController_OnCreateNewGroup") as LuaFunction);
					this.m_FriendUIController_OnInviteFriendToGroupStringList`1_hotfix = (luaObj.RawGet("FriendUIController_OnInviteFriendToGroup") as LuaFunction);
					this.m_FriendUIController_OnChangeGroupNameStringString_hotfix = (luaObj.RawGet("FriendUIController_OnChangeGroupName") as LuaFunction);
					this.m_FriendUIController_OnLeaveGroupProChatGroupInfo_hotfix = (luaObj.RawGet("FriendUIController_OnLeaveGroup") as LuaFunction);
					this.m_OnLeaveGroupDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("OnLeaveGroupDialogBoxCallback") as LuaFunction);
					this.m_FriendUIController_OnKickGroupProChatGroupInfoUserSummary_hotfix = (luaObj.RawGet("FriendUIController_OnKickGroup") as LuaFunction);
					this.m_OnKickFromGroupDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("OnKickFromGroupDialogBoxCallback") as LuaFunction);
					this.m_FriendUIController_OnChatUserSummary_hotfix = (luaObj.RawGet("FriendUIController_OnChat") as LuaFunction);
					this.m_FriendUIController_OnSendFriendshipPointString_hotfix = (luaObj.RawGet("FriendUIController_OnSendFriendshipPoint") as LuaFunction);
					this.m_FriendUIController_OnGetFriendshipPointString_hotfix = (luaObj.RawGet("FriendUIController_OnGetFriendshipPoint") as LuaFunction);
					this.m_FriendUIController_OnSendAllFriendshipPoint_hotfix = (luaObj.RawGet("FriendUIController_OnSendAllFriendshipPoint") as LuaFunction);
					this.m_FriendUIController_OnGetAllFriendshipPoint_hotfix = (luaObj.RawGet("FriendUIController_OnGetAllFriendshipPoint") as LuaFunction);
					this.m_PlayerContext_OnChatGroupUpdateNtfProChatGroupInfo_hotfix = (luaObj.RawGet("PlayerContext_OnChatGroupUpdateNtf") as LuaFunction);
					this.m_isMeInTheGroupProChatGroupInfo_hotfix = (luaObj.RawGet("isMeInTheGroup") as LuaFunction);
					this.m_ShowErrorMessageInt32_hotfix = (luaObj.RawGet("ShowErrorMessage") as LuaFunction);
					this.m_ShowMessageString_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600ECD6 RID: 60630 RVA: 0x003F5D78 File Offset: 0x003F3F78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008D8D RID: 36237
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "FriendUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Friend_ABS/Prefab/FriendUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008D8E RID: 36238
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "FriendUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.FriendUIController"),
				m_ctrlName = "FriendUIController"
			}
		};

		// Token: 0x04008D8F RID: 36239
		private PlayerSimpleInfoUITask m_playerSimpleInfoUITask;

		// Token: 0x04008D90 RID: 36240
		private FriendUIController m_friendUIController;

		// Token: 0x04008D91 RID: 36241
		private FriendPanelType m_panelType;

		// Token: 0x04008D92 RID: 36242
		private List<string> m_invitedRecommendFriendIDList = new List<string>();

		// Token: 0x04008D93 RID: 36243
		private List<UserSummary> m_recommendFriendList = new List<UserSummary>();

		// Token: 0x04008D94 RID: 36244
		private List<UserSummary> m_findFriendList = new List<UserSummary>();

		// Token: 0x04008D95 RID: 36245
		private List<string> m_sendFriendshipPointUserIDList = new List<string>();

		// Token: 0x04008D96 RID: 36246
		private List<string> m_getFriendshipPointUserIDList = new List<string>();

		// Token: 0x04008D97 RID: 36247
		private string m_unblockPlayerUserID;

		// Token: 0x04008D98 RID: 36248
		private string m_kickPlayerUserID;

		// Token: 0x04008D99 RID: 36249
		private string m_kickPlayerUserName;

		// Token: 0x04008D9A RID: 36250
		private ProChatGroupInfo m_currentGroupInfo;

		// Token: 0x04008D9B RID: 36251
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04008D9C RID: 36252
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04008D9D RID: 36253
		[DoNotToLua]
		private FriendUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008D9F RID: 36255
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008DA0 RID: 36256
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008DA1 RID: 36257
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008DA2 RID: 36258
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008DA3 RID: 36259
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008DA4 RID: 36260
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x04008DA5 RID: 36261
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x04008DA6 RID: 36262
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008DA7 RID: 36263
		private LuaFunction m_UpdatePanel_hotfix;

		// Token: 0x04008DA8 RID: 36264
		private LuaFunction m_FriendUIController_OnShowPanelFriendPanelType_hotfix;

		// Token: 0x04008DA9 RID: 36265
		private LuaFunction m_FriendUIController_OnReturn_hotfix;

		// Token: 0x04008DAA RID: 36266
		private LuaFunction m_FriendUIController_OnShowHelp_hotfix;

		// Token: 0x04008DAB RID: 36267
		private LuaFunction m_FriendUIController_OnGetSocialRelationFriendSocialRelationFlag_hotfix;

		// Token: 0x04008DAC RID: 36268
		private LuaFunction m_FriendUIController_OnShowPlayerInfoUserSummaryVector3PostionType_hotfix;

		// Token: 0x04008DAD RID: 36269
		private LuaFunction m_OnShowPlayerSimpleInfoVector3PostionType_hotfix;

		// Token: 0x04008DAE RID: 36270
		private LuaFunction m_PlayerSimpleInfoUITask_GetSocialRelation_hotfix;

		// Token: 0x04008DAF RID: 36271
		private LuaFunction m_PlayerSimpleInfoUITask_OnClose_hotfix;

		// Token: 0x04008DB0 RID: 36272
		private LuaFunction m_PlayerSimpleInfoUITask_OnPrivateChatButtonClickBusinessCard_hotfix;

		// Token: 0x04008DB1 RID: 36273
		private LuaFunction m_FriendUIController_OnAddFriendList;

		// Token: 0x04008DB2 RID: 36274
		private LuaFunction m_FriendUIController_OnFriendInviteAceeptList;

		// Token: 0x04008DB3 RID: 36275
		private LuaFunction m_FriendUIController_OnFriendInviteDeclineList;

		// Token: 0x04008DB4 RID: 36276
		private LuaFunction m_FriendUIController_OnUnblockPlayerString_hotfix;

		// Token: 0x04008DB5 RID: 36277
		private LuaFunction m_UnblockPlayerCallbackDialogBoxResult_hotfix;

		// Token: 0x04008DB6 RID: 36278
		private LuaFunction m_FriendUIController_OnFindFriendInt32String_hotfix;

		// Token: 0x04008DB7 RID: 36279
		private LuaFunction m_SetCurrentFindFriendList_hotfix;

		// Token: 0x04008DB8 RID: 36280
		private LuaFunction m_FriendUIController_OnGetRecommendFriendList_hotfix;

		// Token: 0x04008DB9 RID: 36281
		private LuaFunction m_SetCurrentRecommedFriendList_hotfix;

		// Token: 0x04008DBA RID: 36282
		private LuaFunction m_FriendUIController_OnGetAllGroup_hotfix;

		// Token: 0x04008DBB RID: 36283
		private LuaFunction m_FriendUIController_OnGroupChatString_hotfix;

		// Token: 0x04008DBC RID: 36284
		private LuaFunction m_FriendUIController_OnWatchGroupStaffStringBoolean_hotfix;

		// Token: 0x04008DBD RID: 36285
		private LuaFunction m_FriendUIController_OnCreateNewGroupList;

		// Token: 0x04008DBE RID: 36286
		private LuaFunction m_FriendUIController_OnInviteFriendToGroupStringList;

		// Token: 0x04008DBF RID: 36287
		private LuaFunction m_FriendUIController_OnChangeGroupNameStringString_hotfix;

		// Token: 0x04008DC0 RID: 36288
		private LuaFunction m_FriendUIController_OnLeaveGroupProChatGroupInfo_hotfix;

		// Token: 0x04008DC1 RID: 36289
		private LuaFunction m_OnLeaveGroupDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x04008DC2 RID: 36290
		private LuaFunction m_FriendUIController_OnKickGroupProChatGroupInfoUserSummary_hotfix;

		// Token: 0x04008DC3 RID: 36291
		private LuaFunction m_OnKickFromGroupDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x04008DC4 RID: 36292
		private LuaFunction m_FriendUIController_OnChatUserSummary_hotfix;

		// Token: 0x04008DC5 RID: 36293
		private LuaFunction m_FriendUIController_OnSendFriendshipPointString_hotfix;

		// Token: 0x04008DC6 RID: 36294
		private LuaFunction m_FriendUIController_OnGetFriendshipPointString_hotfix;

		// Token: 0x04008DC7 RID: 36295
		private LuaFunction m_FriendUIController_OnSendAllFriendshipPoint_hotfix;

		// Token: 0x04008DC8 RID: 36296
		private LuaFunction m_FriendUIController_OnGetAllFriendshipPoint_hotfix;

		// Token: 0x04008DC9 RID: 36297
		private LuaFunction m_PlayerContext_OnChatGroupUpdateNtfProChatGroupInfo_hotfix;

		// Token: 0x04008DCA RID: 36298
		private LuaFunction m_isMeInTheGroupProChatGroupInfo_hotfix;

		// Token: 0x04008DCB RID: 36299
		private LuaFunction m_ShowErrorMessageInt32_hotfix;

		// Token: 0x04008DCC RID: 36300
		private LuaFunction m_ShowMessageString_hotfix;

		// Token: 0x04008DCD RID: 36301
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008DCE RID: 36302
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000CBD RID: 3261
		public new class LuaExportHelper
		{
			// Token: 0x0600ECD7 RID: 60631 RVA: 0x003F5DE0 File Offset: 0x003F3FE0
			public LuaExportHelper(FriendUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600ECD8 RID: 60632 RVA: 0x003F5DF0 File Offset: 0x003F3FF0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600ECD9 RID: 60633 RVA: 0x003F5E00 File Offset: 0x003F4000
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600ECDA RID: 60634 RVA: 0x003F5E10 File Offset: 0x003F4010
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600ECDB RID: 60635 RVA: 0x003F5E20 File Offset: 0x003F4020
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600ECDC RID: 60636 RVA: 0x003F5E30 File Offset: 0x003F4030
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600ECDD RID: 60637 RVA: 0x003F5E40 File Offset: 0x003F4040
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600ECDE RID: 60638 RVA: 0x003F5E50 File Offset: 0x003F4050
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600ECDF RID: 60639 RVA: 0x003F5E60 File Offset: 0x003F4060
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600ECE0 RID: 60640 RVA: 0x003F5E70 File Offset: 0x003F4070
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600ECE1 RID: 60641 RVA: 0x003F5E80 File Offset: 0x003F4080
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600ECE2 RID: 60642 RVA: 0x003F5E90 File Offset: 0x003F4090
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600ECE3 RID: 60643 RVA: 0x003F5EA0 File Offset: 0x003F40A0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600ECE4 RID: 60644 RVA: 0x003F5EB0 File Offset: 0x003F40B0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600ECE5 RID: 60645 RVA: 0x003F5EC0 File Offset: 0x003F40C0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600ECE6 RID: 60646 RVA: 0x003F5ED0 File Offset: 0x003F40D0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600ECE7 RID: 60647 RVA: 0x003F5EE0 File Offset: 0x003F40E0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600ECE8 RID: 60648 RVA: 0x003F5EF0 File Offset: 0x003F40F0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600ECE9 RID: 60649 RVA: 0x003F5F00 File Offset: 0x003F4100
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600ECEA RID: 60650 RVA: 0x003F5F10 File Offset: 0x003F4110
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600ECEB RID: 60651 RVA: 0x003F5F20 File Offset: 0x003F4120
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600ECEC RID: 60652 RVA: 0x003F5F30 File Offset: 0x003F4130
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600ECED RID: 60653 RVA: 0x003F5F40 File Offset: 0x003F4140
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600ECEE RID: 60654 RVA: 0x003F5F50 File Offset: 0x003F4150
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002DB1 RID: 11697
			// (get) Token: 0x0600ECEF RID: 60655 RVA: 0x003F5F60 File Offset: 0x003F4160
			// (set) Token: 0x0600ECF0 RID: 60656 RVA: 0x003F5F70 File Offset: 0x003F4170
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

			// Token: 0x17002DB2 RID: 11698
			// (get) Token: 0x0600ECF1 RID: 60657 RVA: 0x003F5F80 File Offset: 0x003F4180
			// (set) Token: 0x0600ECF2 RID: 60658 RVA: 0x003F5F90 File Offset: 0x003F4190
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

			// Token: 0x17002DB3 RID: 11699
			// (get) Token: 0x0600ECF3 RID: 60659 RVA: 0x003F5FA0 File Offset: 0x003F41A0
			// (set) Token: 0x0600ECF4 RID: 60660 RVA: 0x003F5FB0 File Offset: 0x003F41B0
			public PlayerSimpleInfoUITask m_playerSimpleInfoUITask
			{
				get
				{
					return this.m_owner.m_playerSimpleInfoUITask;
				}
				set
				{
					this.m_owner.m_playerSimpleInfoUITask = value;
				}
			}

			// Token: 0x17002DB4 RID: 11700
			// (get) Token: 0x0600ECF5 RID: 60661 RVA: 0x003F5FC0 File Offset: 0x003F41C0
			// (set) Token: 0x0600ECF6 RID: 60662 RVA: 0x003F5FD0 File Offset: 0x003F41D0
			public FriendUIController m_friendUIController
			{
				get
				{
					return this.m_owner.m_friendUIController;
				}
				set
				{
					this.m_owner.m_friendUIController = value;
				}
			}

			// Token: 0x17002DB5 RID: 11701
			// (get) Token: 0x0600ECF7 RID: 60663 RVA: 0x003F5FE0 File Offset: 0x003F41E0
			// (set) Token: 0x0600ECF8 RID: 60664 RVA: 0x003F5FF0 File Offset: 0x003F41F0
			public FriendPanelType m_panelType
			{
				get
				{
					return this.m_owner.m_panelType;
				}
				set
				{
					this.m_owner.m_panelType = value;
				}
			}

			// Token: 0x17002DB6 RID: 11702
			// (get) Token: 0x0600ECF9 RID: 60665 RVA: 0x003F6000 File Offset: 0x003F4200
			// (set) Token: 0x0600ECFA RID: 60666 RVA: 0x003F6010 File Offset: 0x003F4210
			public List<string> m_invitedRecommendFriendIDList
			{
				get
				{
					return this.m_owner.m_invitedRecommendFriendIDList;
				}
				set
				{
					this.m_owner.m_invitedRecommendFriendIDList = value;
				}
			}

			// Token: 0x17002DB7 RID: 11703
			// (get) Token: 0x0600ECFB RID: 60667 RVA: 0x003F6020 File Offset: 0x003F4220
			// (set) Token: 0x0600ECFC RID: 60668 RVA: 0x003F6030 File Offset: 0x003F4230
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

			// Token: 0x17002DB8 RID: 11704
			// (get) Token: 0x0600ECFD RID: 60669 RVA: 0x003F6040 File Offset: 0x003F4240
			// (set) Token: 0x0600ECFE RID: 60670 RVA: 0x003F6050 File Offset: 0x003F4250
			public List<UserSummary> m_findFriendList
			{
				get
				{
					return this.m_owner.m_findFriendList;
				}
				set
				{
					this.m_owner.m_findFriendList = value;
				}
			}

			// Token: 0x17002DB9 RID: 11705
			// (get) Token: 0x0600ECFF RID: 60671 RVA: 0x003F6060 File Offset: 0x003F4260
			// (set) Token: 0x0600ED00 RID: 60672 RVA: 0x003F6070 File Offset: 0x003F4270
			public List<string> m_sendFriendshipPointUserIDList
			{
				get
				{
					return this.m_owner.m_sendFriendshipPointUserIDList;
				}
				set
				{
					this.m_owner.m_sendFriendshipPointUserIDList = value;
				}
			}

			// Token: 0x17002DBA RID: 11706
			// (get) Token: 0x0600ED01 RID: 60673 RVA: 0x003F6080 File Offset: 0x003F4280
			// (set) Token: 0x0600ED02 RID: 60674 RVA: 0x003F6090 File Offset: 0x003F4290
			public List<string> m_getFriendshipPointUserIDList
			{
				get
				{
					return this.m_owner.m_getFriendshipPointUserIDList;
				}
				set
				{
					this.m_owner.m_getFriendshipPointUserIDList = value;
				}
			}

			// Token: 0x17002DBB RID: 11707
			// (get) Token: 0x0600ED03 RID: 60675 RVA: 0x003F60A0 File Offset: 0x003F42A0
			// (set) Token: 0x0600ED04 RID: 60676 RVA: 0x003F60B0 File Offset: 0x003F42B0
			public string m_unblockPlayerUserID
			{
				get
				{
					return this.m_owner.m_unblockPlayerUserID;
				}
				set
				{
					this.m_owner.m_unblockPlayerUserID = value;
				}
			}

			// Token: 0x17002DBC RID: 11708
			// (get) Token: 0x0600ED05 RID: 60677 RVA: 0x003F60C0 File Offset: 0x003F42C0
			// (set) Token: 0x0600ED06 RID: 60678 RVA: 0x003F60D0 File Offset: 0x003F42D0
			public string m_kickPlayerUserID
			{
				get
				{
					return this.m_owner.m_kickPlayerUserID;
				}
				set
				{
					this.m_owner.m_kickPlayerUserID = value;
				}
			}

			// Token: 0x17002DBD RID: 11709
			// (get) Token: 0x0600ED07 RID: 60679 RVA: 0x003F60E0 File Offset: 0x003F42E0
			// (set) Token: 0x0600ED08 RID: 60680 RVA: 0x003F60F0 File Offset: 0x003F42F0
			public string m_kickPlayerUserName
			{
				get
				{
					return this.m_owner.m_kickPlayerUserName;
				}
				set
				{
					this.m_owner.m_kickPlayerUserName = value;
				}
			}

			// Token: 0x17002DBE RID: 11710
			// (get) Token: 0x0600ED09 RID: 60681 RVA: 0x003F6100 File Offset: 0x003F4300
			// (set) Token: 0x0600ED0A RID: 60682 RVA: 0x003F6110 File Offset: 0x003F4310
			public ProChatGroupInfo m_currentGroupInfo
			{
				get
				{
					return this.m_owner.m_currentGroupInfo;
				}
				set
				{
					this.m_owner.m_currentGroupInfo = value;
				}
			}

			// Token: 0x17002DBF RID: 11711
			// (get) Token: 0x0600ED0B RID: 60683 RVA: 0x003F6120 File Offset: 0x003F4320
			// (set) Token: 0x0600ED0C RID: 60684 RVA: 0x003F6130 File Offset: 0x003F4330
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

			// Token: 0x17002DC0 RID: 11712
			// (get) Token: 0x0600ED0D RID: 60685 RVA: 0x003F6140 File Offset: 0x003F4340
			// (set) Token: 0x0600ED0E RID: 60686 RVA: 0x003F6150 File Offset: 0x003F4350
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

			// Token: 0x17002DC1 RID: 11713
			// (get) Token: 0x0600ED0F RID: 60687 RVA: 0x003F6160 File Offset: 0x003F4360
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002DC2 RID: 11714
			// (get) Token: 0x0600ED10 RID: 60688 RVA: 0x003F6170 File Offset: 0x003F4370
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600ED11 RID: 60689 RVA: 0x003F6180 File Offset: 0x003F4380
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600ED12 RID: 60690 RVA: 0x003F6190 File Offset: 0x003F4390
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600ED13 RID: 60691 RVA: 0x003F61A0 File Offset: 0x003F43A0
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x0600ED14 RID: 60692 RVA: 0x003F61B0 File Offset: 0x003F43B0
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x0600ED15 RID: 60693 RVA: 0x003F61C0 File Offset: 0x003F43C0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600ED16 RID: 60694 RVA: 0x003F61D0 File Offset: 0x003F43D0
			public void UpdatePanel()
			{
				this.m_owner.UpdatePanel();
			}

			// Token: 0x0600ED17 RID: 60695 RVA: 0x003F61E0 File Offset: 0x003F43E0
			public void FriendUIController_OnShowPanel(FriendPanelType panelType)
			{
				this.m_owner.FriendUIController_OnShowPanel(panelType);
			}

			// Token: 0x0600ED18 RID: 60696 RVA: 0x003F61F0 File Offset: 0x003F43F0
			public void FriendUIController_OnReturn()
			{
				this.m_owner.FriendUIController_OnReturn();
			}

			// Token: 0x0600ED19 RID: 60697 RVA: 0x003F6200 File Offset: 0x003F4400
			public void FriendUIController_OnShowHelp()
			{
				this.m_owner.FriendUIController_OnShowHelp();
			}

			// Token: 0x0600ED1A RID: 60698 RVA: 0x003F6210 File Offset: 0x003F4410
			public void FriendUIController_OnGetSocialRelation(FriendSocialRelationFlag friendSocialRelationFlag)
			{
				this.m_owner.FriendUIController_OnGetSocialRelation(friendSocialRelationFlag);
			}

			// Token: 0x0600ED1B RID: 60699 RVA: 0x003F6220 File Offset: 0x003F4420
			public void FriendUIController_OnShowPlayerInfo(UserSummary userSummy, Vector3 pos, PlayerSimpleInfoUITask.PostionType posType)
			{
				this.m_owner.FriendUIController_OnShowPlayerInfo(userSummy, pos, posType);
			}

			// Token: 0x0600ED1C RID: 60700 RVA: 0x003F6230 File Offset: 0x003F4430
			public void OnShowPlayerSimpleInfo(Vector3 pos, PlayerSimpleInfoUITask.PostionType posType)
			{
				this.m_owner.OnShowPlayerSimpleInfo(pos, posType);
			}

			// Token: 0x0600ED1D RID: 60701 RVA: 0x003F6240 File Offset: 0x003F4440
			public void PlayerSimpleInfoUITask_GetSocialRelation()
			{
				this.m_owner.PlayerSimpleInfoUITask_GetSocialRelation();
			}

			// Token: 0x0600ED1E RID: 60702 RVA: 0x003F6250 File Offset: 0x003F4450
			public void PlayerSimpleInfoUITask_OnClose()
			{
				this.m_owner.PlayerSimpleInfoUITask_OnClose();
			}

			// Token: 0x0600ED1F RID: 60703 RVA: 0x003F6260 File Offset: 0x003F4460
			public void PlayerSimpleInfoUITask_OnPrivateChatButtonClick(BusinessCard playerInfo)
			{
				this.m_owner.PlayerSimpleInfoUITask_OnPrivateChatButtonClick(playerInfo);
			}

			// Token: 0x0600ED20 RID: 60704 RVA: 0x003F6270 File Offset: 0x003F4470
			public void FriendUIController_OnAddFriend(List<string> userIDList)
			{
				this.m_owner.FriendUIController_OnAddFriend(userIDList);
			}

			// Token: 0x0600ED21 RID: 60705 RVA: 0x003F6280 File Offset: 0x003F4480
			public void FriendUIController_OnFriendInviteAceept(List<string> userIDList)
			{
				this.m_owner.FriendUIController_OnFriendInviteAceept(userIDList);
			}

			// Token: 0x0600ED22 RID: 60706 RVA: 0x003F6290 File Offset: 0x003F4490
			public void FriendUIController_OnFriendInviteDecline(List<string> userIDList)
			{
				this.m_owner.FriendUIController_OnFriendInviteDecline(userIDList);
			}

			// Token: 0x0600ED23 RID: 60707 RVA: 0x003F62A0 File Offset: 0x003F44A0
			public void FriendUIController_OnUnblockPlayer(string userID)
			{
				this.m_owner.FriendUIController_OnUnblockPlayer(userID);
			}

			// Token: 0x0600ED24 RID: 60708 RVA: 0x003F62B0 File Offset: 0x003F44B0
			public void UnblockPlayerCallback(DialogBoxResult r)
			{
				this.m_owner.UnblockPlayerCallback(r);
			}

			// Token: 0x0600ED25 RID: 60709 RVA: 0x003F62C0 File Offset: 0x003F44C0
			public void FriendUIController_OnFindFriend(int bornChannelID, string partialName)
			{
				this.m_owner.FriendUIController_OnFindFriend(bornChannelID, partialName);
			}

			// Token: 0x0600ED26 RID: 60710 RVA: 0x003F62D0 File Offset: 0x003F44D0
			public void SetCurrentFindFriendList()
			{
				this.m_owner.SetCurrentFindFriendList();
			}

			// Token: 0x0600ED27 RID: 60711 RVA: 0x003F62E0 File Offset: 0x003F44E0
			public void FriendUIController_OnGetRecommendFriendList()
			{
				this.m_owner.FriendUIController_OnGetRecommendFriendList();
			}

			// Token: 0x0600ED28 RID: 60712 RVA: 0x003F62F0 File Offset: 0x003F44F0
			public void SetCurrentRecommedFriendList()
			{
				this.m_owner.SetCurrentRecommedFriendList();
			}

			// Token: 0x0600ED29 RID: 60713 RVA: 0x003F6300 File Offset: 0x003F4500
			public void FriendUIController_OnGetAllGroup()
			{
				this.m_owner.FriendUIController_OnGetAllGroup();
			}

			// Token: 0x0600ED2A RID: 60714 RVA: 0x003F6310 File Offset: 0x003F4510
			public void FriendUIController_OnGroupChat(string groupID)
			{
				this.m_owner.FriendUIController_OnGroupChat(groupID);
			}

			// Token: 0x0600ED2B RID: 60715 RVA: 0x003F6320 File Offset: 0x003F4520
			public void FriendUIController_OnWatchGroupStaff(string groupID, bool needOpenTween)
			{
				this.m_owner.FriendUIController_OnWatchGroupStaff(groupID, needOpenTween);
			}

			// Token: 0x0600ED2C RID: 60716 RVA: 0x003F6330 File Offset: 0x003F4530
			public void FriendUIController_OnCreateNewGroup(List<string> userIDList)
			{
				this.m_owner.FriendUIController_OnCreateNewGroup(userIDList);
			}

			// Token: 0x0600ED2D RID: 60717 RVA: 0x003F6340 File Offset: 0x003F4540
			public void FriendUIController_OnInviteFriendToGroup(string groupID, List<string> userIDList)
			{
				this.m_owner.FriendUIController_OnInviteFriendToGroup(groupID, userIDList);
			}

			// Token: 0x0600ED2E RID: 60718 RVA: 0x003F6350 File Offset: 0x003F4550
			public void FriendUIController_OnChangeGroupName(string groupID, string newName)
			{
				this.m_owner.FriendUIController_OnChangeGroupName(groupID, newName);
			}

			// Token: 0x0600ED2F RID: 60719 RVA: 0x003F6360 File Offset: 0x003F4560
			public void FriendUIController_OnLeaveGroup(ProChatGroupInfo chatGroupInfo)
			{
				this.m_owner.FriendUIController_OnLeaveGroup(chatGroupInfo);
			}

			// Token: 0x0600ED30 RID: 60720 RVA: 0x003F6370 File Offset: 0x003F4570
			public void OnLeaveGroupDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.OnLeaveGroupDialogBoxCallback(r);
			}

			// Token: 0x0600ED31 RID: 60721 RVA: 0x003F6380 File Offset: 0x003F4580
			public void FriendUIController_OnKickGroup(ProChatGroupInfo chatGroupInfo, UserSummary userSummy)
			{
				this.m_owner.FriendUIController_OnKickGroup(chatGroupInfo, userSummy);
			}

			// Token: 0x0600ED32 RID: 60722 RVA: 0x003F6390 File Offset: 0x003F4590
			public void OnKickFromGroupDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.OnKickFromGroupDialogBoxCallback(r);
			}

			// Token: 0x0600ED33 RID: 60723 RVA: 0x003F63A0 File Offset: 0x003F45A0
			public void FriendUIController_OnChat(UserSummary userSummy)
			{
				this.m_owner.FriendUIController_OnChat(userSummy);
			}

			// Token: 0x0600ED34 RID: 60724 RVA: 0x003F63B0 File Offset: 0x003F45B0
			public void FriendUIController_OnSendFriendshipPoint(string userID)
			{
				this.m_owner.FriendUIController_OnSendFriendshipPoint(userID);
			}

			// Token: 0x0600ED35 RID: 60725 RVA: 0x003F63C0 File Offset: 0x003F45C0
			public void FriendUIController_OnGetFriendshipPoint(string userID)
			{
				this.m_owner.FriendUIController_OnGetFriendshipPoint(userID);
			}

			// Token: 0x0600ED36 RID: 60726 RVA: 0x003F63D0 File Offset: 0x003F45D0
			public void FriendUIController_OnSendAllFriendshipPoint()
			{
				this.m_owner.FriendUIController_OnSendAllFriendshipPoint();
			}

			// Token: 0x0600ED37 RID: 60727 RVA: 0x003F63E0 File Offset: 0x003F45E0
			public void FriendUIController_OnGetAllFriendshipPoint()
			{
				this.m_owner.FriendUIController_OnGetAllFriendshipPoint();
			}

			// Token: 0x0600ED38 RID: 60728 RVA: 0x003F63F0 File Offset: 0x003F45F0
			public void PlayerContext_OnChatGroupUpdateNtf(ProChatGroupInfo chatGroupInfo)
			{
				this.m_owner.PlayerContext_OnChatGroupUpdateNtf(chatGroupInfo);
			}

			// Token: 0x0600ED39 RID: 60729 RVA: 0x003F6400 File Offset: 0x003F4600
			public bool isMeInTheGroup(ProChatGroupInfo chatGroupInfo)
			{
				return this.m_owner.isMeInTheGroup(chatGroupInfo);
			}

			// Token: 0x0600ED3A RID: 60730 RVA: 0x003F6410 File Offset: 0x003F4610
			public void ShowErrorMessage(int errorCode)
			{
				this.m_owner.ShowErrorMessage(errorCode);
			}

			// Token: 0x0600ED3B RID: 60731 RVA: 0x003F6420 File Offset: 0x003F4620
			public void ShowMessage(string text)
			{
				this.m_owner.ShowMessage(text);
			}

			// Token: 0x04008DCF RID: 36303
			private FriendUITask m_owner;
		}
	}
}
