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
	// Token: 0x02000CF5 RID: 3317
	[HotFix]
	public class GuildManagementUIController : UIControllerBase
	{
		// Token: 0x0600F2D6 RID: 62166 RVA: 0x00406AD0 File Offset: 0x00404CD0
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnImgButtonClick));
			this.m_infoButton.onClick.AddListener(new UnityAction(this.OnInfoButtonClick));
			this.m_guildCoinDescButton.onClick.AddListener(new UnityAction(this.OnGuildCoinButtonClick));
			this.m_sociatyNameChangeButton.onClick.AddListener(new UnityAction(this.OnSociatyNameChangeButtonClick));
			this.m_guildChangeNamePanelBackButton.onClick.AddListener(new UnityAction(this.OnGuildChangeNamePanelBackButtonClick));
			this.m_guildChangeNamePanelChangeNameButton.onClick.AddListener(new UnityAction(this.OnGuildChangeNamePanelChangeNameButtonClick));
			this.m_infoDeclarationButton.onClick.AddListener(new UnityAction(this.OnDeclarationButtonClick));
			this.m_declarationChangePanelBackButton.onClick.AddListener(new UnityAction(this.OnDeclarationChangePanelBackButtonClick));
			this.m_declarationChangePanelCloseButton.onClick.AddListener(new UnityAction(this.OnDeclarationChangePanelBackButtonClick));
			this.m_declarationChangePanelSaveButton.onClick.AddListener(new UnityAction(this.OnDeclarationChangePanelSaveButtonClick));
			this.m_messageButton.onClick.AddListener(new UnityAction(this.OnMessageButtonClick));
			this.m_messagePanelBackButton.onClick.AddListener(new UnityAction(this.OnMessagePanelBackButtonClick));
			this.m_messagePanelApplyToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMessagePanelApplyToggleValueChanged));
			this.m_messagePanelJournalToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMessagePanelJournalToggleValueChanged));
			this.m_messageApplyPanelPowerButton.onClick.AddListener(new UnityAction(this.OnMssageApplyPanelPowerButtonClick));
			this.m_messageApplyPanelAllRefuseButton.onClick.AddListener(new UnityAction(this.OnMessageApplyPanelAllRefuseButtonClick));
			this.m_inviteButton.onClick.AddListener(new UnityAction(this.OnInviteButtonClick));
			this.m_invitePanelBackButton.onClick.AddListener(new UnityAction(this.OnInvitePanelBackButton));
			this.m_invitePanelCloseButton.onClick.AddListener(new UnityAction(this.OnInvitePanelBackButton));
			this.m_invitePanelSetButton.onClick.AddListener(new UnityAction(this.OnInvitePanelSetButtonClick));
			this.m_invitePanelChangeListButton.onClick.AddListener(new UnityAction(this.OnInvitePanelChangeListButtonClick));
			this.m_inviteInfoPanelDeclarationChangeButton.onClick.AddListener(new UnityAction(this.OnInviteInfoPanelDeclarationChangeButtonClick));
			this.m_inviteListPanelPowerButton.onClick.AddListener(new UnityAction(this.OnInviteListPanelPowerButtonClick));
			this.m_guildSetPanelBackButton.onClick.AddListener(new UnityAction(this.OnGuildSetPanelBackButtonClick));
			this.m_guildSetPanelCloseButton.onClick.AddListener(new UnityAction(this.OnGuildSetPanelBackButtonClick));
			this.m_guildSetPanelSaveButton.onClick.AddListener(new UnityAction(this.OnGuildSetPanelSaveButtonClick));
			this.m_guildSetPanelLevelInputFieldLeftButton.onClick.AddListener(new UnityAction(this.OnGuildSetPanelLevelInputFieldLeftButtonClick));
			this.m_guildSetPanelLevelInputFieldRightButton.onClick.AddListener(new UnityAction(this.OnGuildSetPanelLevelInputFieldRightButtonClick));
			this.m_guildSetPanelApproveGroupAutoToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnGuildSetPanelAutoToggleClick));
			this.m_guildSetPanelApproveGroupChairmanToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnGuildSetPanelChairmanToggleClick));
			this.m_recruitPanelBackButton.onClick.AddListener(new UnityAction(this.OnRecruitPanelBackButtonClick));
			this.m_recruitPanelCloseButton.onClick.AddListener(new UnityAction(this.OnRecruitPanelBackButtonClick));
			this.m_recruitPanelSaveButton.onClick.AddListener(new UnityAction(this.OnRecruitPanelSaveButtonClick));
			this.m_guildSetPanelLevelInputField.onEndEdit.AddListener(new UnityAction<string>(this.OnGuildSetPanelLevelInputFieldEditEnd));
			this.m_quitButton.onClick.AddListener(new UnityAction(this.OnQuitButtonClick));
			this.m_wealButton.onClick.AddListener(new UnityAction(this.OnWealButtonClick));
			this.m_shopButton.onClick.AddListener(new UnityAction(this.OnShopButtonClick));
			this.m_sociatyPlayButton.onClick.AddListener(new UnityAction(this.OnSociatyPlayButtonClick));
			this.m_sociatyListPowerButton.onClick.AddListener(new UnityAction(this.OnPowerButtonClick));
			this.m_sociatyListActiveButton.onClick.AddListener(new UnityAction(this.OnActiveButtonClick));
			this.m_sociatyListOnlineButton.onClick.AddListener(new UnityAction(this.OnOnlineButtonClick));
			this.m_quitDialogConfirmButton.onClick.AddListener(new UnityAction(this.OnQuitGuildConfirmButtonClick));
			this.m_quitDialogCancelButton.onClick.AddListener(new UnityAction(this.CloseQuitGuildConfirmPanel));
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600F2D7 RID: 62167 RVA: 0x00407020 File Offset: 0x00405220
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
			UIUtility.SetUIStateOpen(this.m_commonUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600F2D8 RID: 62168 RVA: 0x00407094 File Offset: 0x00405294
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
			this.ClearData();
			this.CloseAllSmallPanel();
		}

		// Token: 0x0600F2D9 RID: 62169 RVA: 0x00407100 File Offset: 0x00405300
		public void UpdateView(Guild guild)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewGuild_hotfix != null)
			{
				this.m_UpdateViewGuild_hotfix.call(new object[]
				{
					this,
					guild
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (guild.Id == this.m_playerContext.GetGuildId())
			{
				this.m_guild = this.m_playerContext.GetGuildInfo();
			}
			else
			{
				this.m_guild = guild;
			}
			this.RefreshGuildTitle();
			this.SetStateByGuildTitle();
			this.SetSociatyInfoPanel();
			List<GuildMemberCacheObject> list = new List<GuildMemberCacheObject>(this.m_guild.Members);
			switch (this.m_guildListSortType)
			{
			case GuildManagementUIController.GuildListSortType.Default:
				this.SortGuildListByDefault(list);
				break;
			case GuildManagementUIController.GuildListSortType.Active:
				list.Sort(new Comparison<GuildMemberCacheObject>(this.SortByActiveType));
				break;
			case GuildManagementUIController.GuildListSortType.BattlePower:
				list.Sort(new Comparison<GuildMemberCacheObject>(this.SortByBattlePowerType));
				break;
			}
			this.SetSociatyListPanel(list);
			this.SetSortButtonState(this.m_guildListSortType);
			if (this.m_guildTitle != GuildTitle.President && this.m_guildTitle != GuildTitle.VP)
			{
				if (this.m_invitePanelStateCtrl.gameObject.activeSelf)
				{
					this.CloseInvitePanel(null);
					if (this.m_recruitPanelStateCtrl.gameObject.activeSelf)
					{
						this.OnRecruitPanelBackButtonClick();
					}
					if (this.m_guildSetPanelStateCtrl.gameObject.activeSelf)
					{
						this.OnGuildSetPanelBackButtonClick();
					}
				}
				if (this.m_messagePanelStateCtrl.gameObject.activeSelf && this.m_messagePanelApplyToggle.gameObject.activeSelf)
				{
					this.CloseMessagePanel(null);
				}
				if (this.m_guildSetPanelStateCtrl.gameObject.activeSelf)
				{
					this.OnGuildSetPanelBackButtonClick();
				}
				if (this.m_declarationChangePanelStateCtrl.gameObject.activeSelf)
				{
					this.OnDeclarationChangePanelBackButtonClick();
				}
			}
		}

		// Token: 0x0600F2DA RID: 62170 RVA: 0x0040730C File Offset: 0x0040550C
		private void RefreshGuildTitle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshGuildTitle_hotfix != null)
			{
				this.m_RefreshGuildTitle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildMemberCacheObject guildMemberCacheObject = this.m_guild.FindMember(this.m_playerContext.GetUserId());
			if (guildMemberCacheObject != null)
			{
				this.m_guildTitle = guildMemberCacheObject.Member.Title;
			}
			else
			{
				this.m_guildTitle = GuildTitle.None;
			}
		}

		// Token: 0x0600F2DB RID: 62171 RVA: 0x004073A8 File Offset: 0x004055A8
		private void SetStateByGuildTitle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStateByGuildTitle_hotfix != null)
			{
				this.m_SetStateByGuildTitle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (this.m_guildTitle)
			{
			case GuildTitle.None:
				this.m_mainPanelStateCtrl.SetToUIState("None", false, true);
				break;
			case GuildTitle.Normal:
			case GuildTitle.Elite:
				this.m_mainPanelStateCtrl.SetToUIState("Normal", false, true);
				break;
			case GuildTitle.VP:
				this.m_mainPanelStateCtrl.SetToUIState("VP", false, true);
				break;
			case GuildTitle.President:
				this.m_mainPanelStateCtrl.SetToUIState("President", false, true);
				break;
			}
		}

		// Token: 0x0600F2DC RID: 62172 RVA: 0x00407490 File Offset: 0x00405690
		private void SetSociatyInfoPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSociatyInfoPanel_hotfix != null)
			{
				this.m_SetSociatyInfoPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sociatyName.text = this.m_guild.Name;
			this.m_guildCoinText.text = this.m_playerContext.GetGuildMedal().ToString();
			int configableConstId_GuildMemberCountMax = this.m_configDataLoader.ConfigableConstId_GuildMemberCountMax;
			string arg = "white";
			if (this.m_guild.Members.Count >= configableConstId_GuildMemberCountMax)
			{
				arg = "red";
			}
			this.m_infoPeopleNumberText.text = string.Format("<color={0}>{1}</color>/{2}", arg, this.m_guild.Members.Count, configableConstId_GuildMemberCountMax);
			this.m_infoPowerText.text = this.m_guild.TotalBattlePower.ToString();
			this.m_infoDeclarationText.text = this.m_guild.Bulletin;
		}

		// Token: 0x0600F2DD RID: 62173 RVA: 0x004075C4 File Offset: 0x004057C4
		private void SetSociatyListPanel(List<GuildMemberCacheObject> memberList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSociatyListPanelList`1_hotfix != null)
			{
				this.m_SetSociatyListPanelList`1_hotfix.call(new object[]
				{
					this,
					memberList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			if (this.m_playerInfoCtrlList == null)
			{
				this.m_playerInfoCtrlList = new List<GuildMemberInfoItemUIController>();
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_sociatyListScrollContent, memberList.Count);
			Transform transform = this.m_sociatyListScrollContent.transform;
			for (int i = 0; i < memberList.Count; i++)
			{
				GuildMember member = memberList[i].Member;
				if (member.Online)
				{
					num++;
				}
				GuildMemberInfoItemUIController guildMemberInfoItemUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildMemberInfoItemUIController = child.GetComponent<GuildMemberInfoItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_playerInfoPrefabItem);
					guildMemberInfoItemUIController = GameObjectUtility.AddControllerToGameObject<GuildMemberInfoItemUIController>(gameObject);
					guildMemberInfoItemUIController.EventOnClick += this.OnGuildManagementListPlayeItemClick;
					gameObject.transform.SetParent(transform, false);
					this.m_playerInfoCtrlList.Add(guildMemberInfoItemUIController);
				}
				if (guildMemberInfoItemUIController != null)
				{
					guildMemberInfoItemUIController.InitItemInfo(member, this.m_playerContext.IsMe(member.UserId));
				}
			}
			this.m_sociatyListOnlineValueText.text = num.ToString();
		}

		// Token: 0x0600F2DE RID: 62174 RVA: 0x00407744 File Offset: 0x00405944
		private void OnGuildManagementListPlayeItemClick(GuildMemberInfoItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildManagementListPlayeItemClickGuildMemberInfoItemUIController_hotfix != null)
			{
				this.m_OnGuildManagementListPlayeItemClickGuildMemberInfoItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerContext.GetGuildId() != null && !this.m_playerContext.IsMe(ctrl.Member.UserId) && this.EventOnGuildMemberClick != null)
			{
				this.EventOnGuildMemberClick(ctrl.Member.UserId, ctrl.gameObject.transform.position, PlayerSimpleInfoUITask.PostionType.Left);
			}
		}

		// Token: 0x0600F2DF RID: 62175 RVA: 0x00407814 File Offset: 0x00405A14
		public void SetMessageRedPoint(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMessageRedPointBoolean_hotfix != null)
			{
				this.m_SetMessageRedPointBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_messageButtonRedPoint.SetActive(isShow);
		}

		// Token: 0x0600F2E0 RID: 62176 RVA: 0x00407890 File Offset: 0x00405A90
		private void OnReturnImgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnImgButtonClick_hotfix != null)
			{
				this.m_OnReturnImgButtonClick_hotfix.call(new object[]
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
			this.Close();
		}

		// Token: 0x0600F2E1 RID: 62177 RVA: 0x0040790C File Offset: 0x00405B0C
		private void OnInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoButtonClick_hotfix != null)
			{
				this.m_OnInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Guild);
		}

		// Token: 0x0600F2E2 RID: 62178 RVA: 0x00407978 File Offset: 0x00405B78
		private void OnGuildCoinButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildCoinButtonClick_hotfix != null)
			{
				this.m_OnGuildCoinButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RewardGoodsDescUITask.StartUITask(this, GoodsType.GoodsType_GuildMedal, 0, 0, this.m_guildCoinDescButton.gameObject, true);
		}

		// Token: 0x0600F2E3 RID: 62179 RVA: 0x004079F0 File Offset: 0x00405BF0
		private void ClearData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearData_hotfix != null)
			{
				this.m_ClearData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isManageListPowerAscend = false;
			this.m_isManageListActiveAscend = false;
			this.m_isMessageApplyListPowerAscend = false;
			this.m_isInviteListPanelPowerAscend = false;
			this.m_isMessageApplyPanelSortByPower = false;
			if (this.m_playerInfoCtrlList != null)
			{
				this.m_playerInfoCtrlList.Clear();
			}
			if (this.m_applyPlayerInfoCtrlList != null)
			{
				this.m_applyPlayerInfoCtrlList.Clear();
			}
			if (this.m_guildJournalItemCtrlList != null)
			{
				this.m_guildJournalItemCtrlList.Clear();
			}
			if (this.m_inviteMemberInfoCtrlList != null)
			{
				this.m_inviteMemberInfoCtrlList.Clear();
			}
			if (this.m_canInvitePlayerList != null)
			{
				this.m_canInvitePlayerList.Clear();
			}
			if (this.m_messageApplyUserSummarys != null)
			{
				this.m_messageApplyUserSummarys.Clear();
			}
			this.m_guild = null;
			this.m_guildListSortType = GuildManagementUIController.GuildListSortType.Default;
		}

		// Token: 0x0600F2E4 RID: 62180 RVA: 0x00407B08 File Offset: 0x00405D08
		private void CloseAllSmallPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAllSmallPanel_hotfix != null)
			{
				this.m_CloseAllSmallPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_messagePanelStateCtrl.gameObject.activeSelf)
			{
				this.CloseMessagePanel(null);
			}
			if (this.m_invitePanelStateCtrl.gameObject.activeSelf)
			{
				this.CloseInvitePanel(null);
			}
			if (this.m_guildSetPanelStateCtrl.gameObject.activeSelf)
			{
				this.CloseGuildSetPanel(null);
			}
			if (this.m_guildChangeNamePanelStateCtrl.gameObject.activeSelf)
			{
				this.OnGuildChangeNamePanelBackButtonClick();
			}
			if (this.m_declarationChangePanelStateCtrl.gameObject.activeSelf)
			{
				this.OnDeclarationChangePanelBackButtonClick();
			}
		}

		// Token: 0x0600F2E5 RID: 62181 RVA: 0x00407BF4 File Offset: 0x00405DF4
		private void OnOnlineButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineButtonClick_hotfix != null)
			{
				this.m_OnOnlineButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildListSortType = GuildManagementUIController.GuildListSortType.Default;
			this.m_isManageListPowerAscend = false;
			this.m_isManageListActiveAscend = false;
			this.UpdateView(this.m_guild);
		}

		// Token: 0x0600F2E6 RID: 62182 RVA: 0x00407C78 File Offset: 0x00405E78
		private void OnActiveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActiveButtonClick_hotfix != null)
			{
				this.m_OnActiveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isManageListActiveAscend = !this.m_isManageListActiveAscend;
			this.m_guildListSortType = GuildManagementUIController.GuildListSortType.Active;
			this.UpdateView(this.m_guild);
		}

		// Token: 0x0600F2E7 RID: 62183 RVA: 0x00407CFC File Offset: 0x00405EFC
		private void OnPowerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPowerButtonClick_hotfix != null)
			{
				this.m_OnPowerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isManageListPowerAscend = !this.m_isManageListPowerAscend;
			this.m_guildListSortType = GuildManagementUIController.GuildListSortType.BattlePower;
			this.UpdateView(this.m_guild);
		}

		// Token: 0x0600F2E8 RID: 62184 RVA: 0x00407D80 File Offset: 0x00405F80
		private void SetSortButtonState(GuildManagementUIController.GuildListSortType sortType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSortButtonStateGuildListSortType_hotfix != null)
			{
				this.m_SetSortButtonStateGuildListSortType_hotfix.call(new object[]
				{
					this,
					sortType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string stateName = (!this.m_isManageListPowerAscend) ? "Down" : "Up";
			string stateName2 = (!this.m_isManageListActiveAscend) ? "Down" : "Up";
			switch (sortType)
			{
			case GuildManagementUIController.GuildListSortType.Default:
				stateName = "Hide";
				stateName2 = "Hide";
				break;
			case GuildManagementUIController.GuildListSortType.Active:
				stateName = "Hide";
				break;
			case GuildManagementUIController.GuildListSortType.BattlePower:
				stateName2 = "Hide";
				break;
			}
			this.m_sociatyListPowerButtonStateCtrl.SetToUIState(stateName, false, true);
			this.m_sociatyListActiveButtonStateCtrl.SetToUIState(stateName2, false, true);
		}

		// Token: 0x0600F2E9 RID: 62185 RVA: 0x00407E88 File Offset: 0x00406088
		private int SortByTitle(GuildMemberCacheObject a, GuildMemberCacheObject b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortByTitleGuildMemberCacheObjectGuildMemberCacheObject_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortByTitleGuildMemberCacheObjectGuildMemberCacheObject_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return b.Member.Title - a.Member.Title;
		}

		// Token: 0x0600F2EA RID: 62186 RVA: 0x00407F2C File Offset: 0x0040612C
		private int SortByPower(GuildMemberCacheObject a, GuildMemberCacheObject b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortByPowerGuildMemberCacheObjectGuildMemberCacheObject_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortByPowerGuildMemberCacheObjectGuildMemberCacheObject_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return b.Member.TopHeroBattlePower - a.Member.TopHeroBattlePower;
		}

		// Token: 0x0600F2EB RID: 62187 RVA: 0x00407FD0 File Offset: 0x004061D0
		private int SortByActive(GuildMemberCacheObject a, GuildMemberCacheObject b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortByActiveGuildMemberCacheObjectGuildMemberCacheObject_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortByActiveGuildMemberCacheObjectGuildMemberCacheObject_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return b.Member.TotalActivities - a.Member.TotalActivities;
		}

		// Token: 0x0600F2EC RID: 62188 RVA: 0x00408074 File Offset: 0x00406274
		private void SortGuildListByDefault(List<GuildMemberCacheObject> guildList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortGuildListByDefaultList`1_hotfix != null)
			{
				this.m_SortGuildListByDefaultList`1_hotfix.call(new object[]
				{
					this,
					guildList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GuildMemberCacheObject> list = new List<GuildMemberCacheObject>();
			List<GuildMemberCacheObject> list2 = new List<GuildMemberCacheObject>();
			foreach (GuildMemberCacheObject guildMemberCacheObject in guildList)
			{
				if (guildMemberCacheObject.Member.Online)
				{
					list.Add(guildMemberCacheObject);
				}
				else
				{
					list2.Add(guildMemberCacheObject);
				}
			}
			list.Sort(delegate(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				int num = this.SortByTitle(a, b);
				if (num != 0)
				{
					return num;
				}
				return this.SortByPower(a, b);
			});
			list2.Sort(delegate(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				int num = this.SortByTitle(a, b);
				if (num != 0)
				{
					return num;
				}
				return this.SortByPower(a, b);
			});
			guildList.Clear();
			guildList.AddRange(list);
			guildList.AddRange(list2);
		}

		// Token: 0x0600F2ED RID: 62189 RVA: 0x00408190 File Offset: 0x00406390
		private int SortByDefaultType(GuildMemberCacheObject a, GuildMemberCacheObject b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortByDefaultTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortByDefaultTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.SortByTitle(a, b);
			if (num != 0)
			{
				return num;
			}
			return this.SortByPower(a, b);
		}

		// Token: 0x0600F2EE RID: 62190 RVA: 0x00408238 File Offset: 0x00406438
		private int SortByActiveType(GuildMemberCacheObject a, GuildMemberCacheObject b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortByActiveTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortByActiveTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = (!this.m_isManageListActiveAscend) ? -1 : 1;
			int num2 = this.SortByActive(a, b);
			if (num2 != 0)
			{
				return num * num2;
			}
			return this.SortByDefaultType(a, b);
		}

		// Token: 0x0600F2EF RID: 62191 RVA: 0x004082F4 File Offset: 0x004064F4
		private int SortByBattlePowerType(GuildMemberCacheObject a, GuildMemberCacheObject b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortByBattlePowerTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortByBattlePowerTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = (!this.m_isManageListPowerAscend) ? -1 : 1;
			int num2 = this.SortByPower(a, b);
			if (num2 != 0)
			{
				return num * num2;
			}
			return this.SortByTitle(a, b);
		}

		// Token: 0x0600F2F0 RID: 62192 RVA: 0x004083B0 File Offset: 0x004065B0
		private void OnSociatyNameChangeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSociatyNameChangeButtonClick_hotfix != null)
			{
				this.m_OnSociatyNameChangeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_guildChangeNamePanelStateCtrl, "Show", null, false, true);
			this.m_guildChangeNamePanelChangeNameButtonStateCtrl.SetToUIState("Normal", false, true);
			this.m_guildChangeNamePanelInputField.text = this.m_guild.Name;
			this.m_guildChangeNamePanelValueText.text = this.m_configDataLoader.ConfigableConstId_GuildChangeNameCrystalCost.ToString();
		}

		// Token: 0x0600F2F1 RID: 62193 RVA: 0x00408470 File Offset: 0x00406670
		private void OnGuildChangeNamePanelChangeNameButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildChangeNamePanelChangeNameButtonClick_hotfix != null)
			{
				this.m_OnGuildChangeNamePanelChangeNameButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_guildChangeNamePanelInputField.text;
			int num = this.m_playerContext.CheckGuildName(text);
			if (num == 0)
			{
				if (this.EventOnChangeGuildName != null)
				{
					this.EventOnChangeGuildName(text, delegate
					{
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_ChangeNameSucceed), 2f, null, true);
						this.OnGuildChangeNamePanelBackButtonClick();
						this.SetSociatyInfoPanel();
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600F2F2 RID: 62194 RVA: 0x0040852C File Offset: 0x0040672C
		private void OnGuildChangeNamePanelBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildChangeNamePanelBackButtonClick_hotfix != null)
			{
				this.m_OnGuildChangeNamePanelBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_guildChangeNamePanelStateCtrl, "Close", null, false, true);
		}

		// Token: 0x0600F2F3 RID: 62195 RVA: 0x004085A0 File Offset: 0x004067A0
		private void OnDeclarationButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDeclarationButtonClick_hotfix != null)
			{
				this.m_OnDeclarationButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_declarationChangePanelStateCtrl, "Show", null, false, true);
			this.m_declarationChangePanelInputField.text = this.m_guild.Bulletin;
		}

		// Token: 0x0600F2F4 RID: 62196 RVA: 0x0040862C File Offset: 0x0040682C
		private void OnDeclarationChangePanelSaveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDeclarationChangePanelSaveButtonClick_hotfix != null)
			{
				this.m_OnDeclarationChangePanelSaveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(this.m_declarationChangePanelInputField.text, '*');
			int num = this.m_playerContext.CanSetGuildAnnouncement(text);
			if (num == 0)
			{
				if (this.EventOnGuildAnnouncementSet != null)
				{
					this.EventOnGuildAnnouncementSet(text, delegate
					{
						this.OnDeclarationChangePanelBackButtonClick();
						this.SetSociatyInfoPanel();
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_SaveAnnouncementSucceed), 2f, null, true);
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600F2F5 RID: 62197 RVA: 0x004086F8 File Offset: 0x004068F8
		private void OnDeclarationChangePanelBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDeclarationChangePanelBackButtonClick_hotfix != null)
			{
				this.m_OnDeclarationChangePanelBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_declarationChangePanelStateCtrl, "Close", null, false, true);
		}

		// Token: 0x0600F2F6 RID: 62198 RVA: 0x0040876C File Offset: 0x0040696C
		private void OnQuitButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnQuitButtonClick_hotfix != null)
			{
				this.m_OnQuitButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_quitDialogTitleText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_QuitTipTitle), this.m_guild.Name);
			TimeSpan timeSpan = new TimeSpan(0, this.m_configDataLoader.ConfigableConstId_GuildReJoinCoolDownTime, 0);
			string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_QuitTipContent);
			string arg = string.Empty;
			int num = timeSpan.Hours;
			if (timeSpan.Days > 0)
			{
				num += timeSpan.Days * 24;
			}
			if (num > 0)
			{
				arg = num + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Hour);
			}
			if (timeSpan.Minutes > 0)
			{
				arg = arg + timeSpan.Minutes + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Minute);
			}
			this.m_quitDialogTipText.text = string.Format(format, arg);
			UIUtility.SetUIStateOpen(this.m_quitDialogStateCtrl, "Show", null, false, true);
		}

		// Token: 0x0600F2F7 RID: 62199 RVA: 0x004088BC File Offset: 0x00406ABC
		private void OnQuitGuildConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnQuitGuildConfirmButtonClick_hotfix != null)
			{
				this.m_OnQuitGuildConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanQuitGuild();
			if (num == 0)
			{
				UIUtility.SetUIStateClose(this.m_quitDialogStateCtrl, "Close", delegate
				{
					if (this.EventOnQuitGuild != null)
					{
						this.EventOnQuitGuild(delegate
						{
							CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_QuitSucceed), 2f, null, true);
						});
					}
				}, true, true);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x00408964 File Offset: 0x00406B64
		private void CloseQuitGuildConfirmPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseQuitGuildConfirmPanel_hotfix != null)
			{
				this.m_CloseQuitGuildConfirmPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_quitDialogStateCtrl, "Close", null, false, true);
		}

		// Token: 0x0600F2F9 RID: 62201 RVA: 0x004089D8 File Offset: 0x00406BD8
		private void OnSociatyPlayButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSociatyPlayButtonClick_hotfix != null)
			{
				this.m_OnSociatyPlayButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoGuildGameListPanel != null)
			{
				this.EventOnGotoGuildGameListPanel();
			}
		}

		// Token: 0x0600F2FA RID: 62202 RVA: 0x00408A50 File Offset: 0x00406C50
		private void OnShopButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShopButtonClick_hotfix != null)
			{
				this.m_OnShopButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoGuildStore != null)
			{
				this.EventOnGotoGuildStore();
			}
		}

		// Token: 0x0600F2FB RID: 62203 RVA: 0x00408AC8 File Offset: 0x00406CC8
		private void OnWealButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWealButtonClick_hotfix != null)
			{
				this.m_OnWealButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoGuildStore != null)
			{
				this.EventOnGotoGuildStore();
			}
		}

		// Token: 0x0600F2FC RID: 62204 RVA: 0x00408B40 File Offset: 0x00406D40
		private void OnMessageButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessageButtonClick_hotfix != null)
			{
				this.m_OnMessageButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RefreshGuildTitle();
			bool flag = this.m_guildTitle == GuildTitle.President || this.m_guildTitle == GuildTitle.VP;
			this.m_messagePanelStateCtrl.gameObject.SetActive(true);
			this.m_messagePanelApplyToggle.gameObject.SetActive(true);
			if (flag)
			{
				this.m_messagePanelApplyToggle.isOn = true;
			}
			else
			{
				this.m_messagePanelJournalToggle.isOn = true;
			}
			this.m_messagePanelApplyToggle.gameObject.SetActive(flag);
			this.SendNtfBeforeOpenMessagePanel(flag, delegate
			{
				if (UIUtility.GetUIStateCurrentStateName(this.m_messagePanelStateCtrl) != "Show")
				{
					UIUtility.SetUIStateOpen(this.m_messagePanelStateCtrl, "Show", null, true, true);
				}
			});
		}

		// Token: 0x0600F2FD RID: 62205 RVA: 0x00408C28 File Offset: 0x00406E28
		private void SendNtfBeforeOpenMessagePanel(bool isManager, Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendNtfBeforeOpenMessagePanelBooleanAction_hotfix != null)
			{
				this.m_SendNtfBeforeOpenMessagePanelBooleanAction_hotfix.call(new object[]
				{
					this,
					isManager,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			GuildManagementUIController $this = this;
			if (isManager)
			{
				if (this.EventOnGetGuildJoinApply != null)
				{
					this.EventOnGetGuildJoinApply(delegate(List<UserSummary> players)
					{
						if ($this.m_messageApplyUserSummarys == null)
						{
							$this.m_messageApplyUserSummarys = players;
						}
						else
						{
							$this.m_messageApplyUserSummarys.Clear();
							$this.m_messageApplyUserSummarys.AddRange(players);
						}
						$this.m_isMessageApplyPanelSortByPower = false;
						$this.SetMessageApplyPanel(players);
						onEnd();
					});
				}
			}
			else if (this.EventOnGetGuildJournal != null)
			{
				this.EventOnGetGuildJournal(delegate(List<GuildLog> journal)
				{
					$this.SetMessageJournalPanel(journal);
					onEnd();
				});
			}
		}

		// Token: 0x0600F2FE RID: 62206 RVA: 0x00408D0C File Offset: 0x00406F0C
		private void SetMessageApplyPanel(List<UserSummary> players)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMessageApplyPanelList`1_hotfix != null)
			{
				this.m_SetMessageApplyPanelList`1_hotfix.call(new object[]
				{
					this,
					players
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isMessageApplyPanelSortByPower)
			{
				this.m_messageApplyPanelPowerButtonStateCtrl.SetToUIState((!this.m_isMessageApplyListPowerAscend) ? "Down" : "Up", false, true);
			}
			else
			{
				this.m_messageApplyPanelPowerButtonStateCtrl.SetToUIState("Hide", false, true);
			}
			int configableConstId_GuildMemberCountMax = this.m_configDataLoader.ConfigableConstId_GuildMemberCountMax;
			string arg = "white";
			if (this.m_guild.Members.Count >= configableConstId_GuildMemberCountMax)
			{
				arg = "red";
			}
			this.m_messageApplyPanelTotalPeopleNumberValueText.text = string.Format("<color={0}>{1}</color>/{2}", arg, this.m_guild.Members.Count, configableConstId_GuildMemberCountMax);
			this.m_messageApplyPanelApplyTotalCountValueText.text = players.Count + "/" + this.m_configDataLoader.ConfigableConstId_GuildJoinApplicationPlayerCountMax;
			if (this.m_applyPlayerInfoCtrlList == null)
			{
				this.m_applyPlayerInfoCtrlList = new List<GuildApplyMemberInfoItemUIController>();
			}
			if (this.m_isMessageApplyPanelSortByPower)
			{
				players.Sort(delegate(UserSummary a, UserSummary b)
				{
					int num = (!this.m_isMessageApplyListPowerAscend) ? -1 : 1;
					return (b.TopHeroBattlePower - a.TopHeroBattlePower) * num;
				});
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_messageApplyPanelMessageListScrollContent, players.Count);
			Transform transform = this.m_messageApplyPanelMessageListScrollContent.transform;
			for (int i = 0; i < players.Count; i++)
			{
				UserSummary player = players[i];
				GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildApplyMemberInfoItemUIController = child.GetComponent<GuildApplyMemberInfoItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_messagePlayerItemPrafeb);
					guildApplyMemberInfoItemUIController = GameObjectUtility.AddControllerToGameObject<GuildApplyMemberInfoItemUIController>(gameObject);
					guildApplyMemberInfoItemUIController.EventOnAcceptResult += this.OnGuildApplyMemberAcceptResult;
					gameObject.transform.SetParent(transform, false);
					this.m_applyPlayerInfoCtrlList.Add(guildApplyMemberInfoItemUIController);
				}
				if (guildApplyMemberInfoItemUIController != null)
				{
					guildApplyMemberInfoItemUIController.InitItemInfo(player);
				}
			}
			this.m_messageNoItemGameObject.SetActive(players.Count == 0);
			this.m_messageApplyPanelMessageListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x0600F2FF RID: 62207 RVA: 0x00408F68 File Offset: 0x00407168
		private void OnGuildApplyMemberAcceptResult(GuildApplyMemberInfoItemUIController ctrl, bool result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildApplyMemberAcceptResultGuildApplyMemberInfoItemUIControllerBoolean_hotfix != null)
			{
				this.m_OnGuildApplyMemberAcceptResultGuildApplyMemberInfoItemUIControllerBoolean_hotfix.call(new object[]
				{
					this,
					ctrl2,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildApplyMemberInfoItemUIController ctrl = ctrl2;
			GuildManagementUIController $this = this;
			if (this.EventOnGuildJoinConfirmOrRefuse != null)
			{
				this.EventOnGuildJoinConfirmOrRefuse(ctrl.Player.UserId, result, delegate
				{
					$this.m_messageApplyUserSummarys.Remove(ctrl.Player);
					$this.SetMessageApplyPanel($this.m_messageApplyUserSummarys);
				});
			}
		}

		// Token: 0x0600F300 RID: 62208 RVA: 0x00409030 File Offset: 0x00407230
		private void SetMessageJournalPanel(List<GuildLog> journal)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMessageJournalPanelList`1_hotfix != null)
			{
				this.m_SetMessageJournalPanelList`1_hotfix.call(new object[]
				{
					this,
					journal
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			journal.Reverse();
			if (this.m_guildJournalItemCtrlList == null)
			{
				this.m_guildJournalItemCtrlList = new List<GuildJournalItemUIController>
				{
					null,
					null,
					null,
					null
				};
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_messageJournalPanelListScrollContent, this.m_guildJournalItemCtrlList.Count);
			Transform transform = this.m_messageJournalPanelListScrollContent.transform;
			for (int i = 0; i < journal.Count; i++)
			{
				GuildLog log = journal[i];
				GuildJournalItemUIController guildJournalItemUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildJournalItemUIController = child.GetComponent<GuildJournalItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_messageJournalItemPrafeb);
					guildJournalItemUIController = GameObjectUtility.AddControllerToGameObject<GuildJournalItemUIController>(gameObject);
					gameObject.transform.SetParent(transform, false);
					this.m_guildJournalItemCtrlList.Add(guildJournalItemUIController);
				}
				if (guildJournalItemUIController != null)
				{
					guildJournalItemUIController.InitItemInfo(log);
				}
			}
			this.m_messageJournalPanelListScrollRect.normalizedPosition = Vector2.one;
			this.m_messageNoItemGameObject.SetActive(false);
		}

		// Token: 0x0600F301 RID: 62209 RVA: 0x004091A4 File Offset: 0x004073A4
		private void OnMssageApplyPanelPowerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMssageApplyPanelPowerButtonClick_hotfix != null)
			{
				this.m_OnMssageApplyPanelPowerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isMessageApplyListPowerAscend = !this.m_isMessageApplyListPowerAscend;
			this.m_isMessageApplyPanelSortByPower = true;
			this.SetMessageApplyPanel(this.m_messageApplyUserSummarys);
		}

		// Token: 0x0600F302 RID: 62210 RVA: 0x00409228 File Offset: 0x00407428
		private void OnMessagePanelBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessagePanelBackButtonClick_hotfix != null)
			{
				this.m_OnMessagePanelBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseMessagePanel(delegate
			{
				this.UpdateView(this.m_guild);
			});
		}

		// Token: 0x0600F303 RID: 62211 RVA: 0x0040929C File Offset: 0x0040749C
		private void CloseMessagePanel(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseMessagePanelAction_hotfix != null)
			{
				this.m_CloseMessagePanelAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			UIUtility.SetUIStateClose(this.m_messagePanelStateCtrl, "Close", delegate
			{
				if (onEnd != null)
				{
					onEnd();
				}
			}, true, true);
		}

		// Token: 0x0600F304 RID: 62212 RVA: 0x00409338 File Offset: 0x00407538
		private void OnMessagePanelApplyToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessagePanelApplyToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMessagePanelApplyToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnGetGuildJoinApply != null)
			{
				this.EventOnGetGuildJoinApply(delegate(List<UserSummary> players)
				{
					if (this.m_messageApplyUserSummarys == null)
					{
						this.m_messageApplyUserSummarys = players;
					}
					else
					{
						this.m_messageApplyUserSummarys.Clear();
						this.m_messageApplyUserSummarys.AddRange(players);
					}
					this.SetMessageApplyPanel(players);
				});
			}
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x004093D0 File Offset: 0x004075D0
		private void OnMessagePanelJournalToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessagePanelJournalToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMessagePanelJournalToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnGetGuildJournal != null)
			{
				this.EventOnGetGuildJournal(delegate(List<GuildLog> journal)
				{
					this.SetMessageJournalPanel(journal);
				});
			}
		}

		// Token: 0x0600F306 RID: 62214 RVA: 0x00409468 File Offset: 0x00407668
		private void OnMessageApplyPanelAllRefuseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessageApplyPanelAllRefuseButtonClick_hotfix != null)
			{
				this.m_OnMessageApplyPanelAllRefuseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAllRefuseButtonClick != null)
			{
				this.EventOnAllRefuseButtonClick(delegate
				{
					GameObjectUtility.DestroyChildrenImmediate(this.m_messageApplyPanelMessageListScrollContent);
				});
			}
		}

		// Token: 0x0600F307 RID: 62215 RVA: 0x004094EC File Offset: 0x004076EC
		private void OnInviteButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteButtonClick_hotfix != null)
			{
				this.m_OnInviteButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetCanInvitePlayerList != null)
			{
				this.EventOnGetCanInvitePlayerList(delegate(List<UserSummary> playerList)
				{
					this.SetInvitePanel(playerList);
					UIUtility.SetUIStateOpen(this.m_invitePanelStateCtrl, "Show", null, false, true);
				}, false);
			}
		}

		// Token: 0x0600F308 RID: 62216 RVA: 0x00409570 File Offset: 0x00407770
		private void SetInvitePanel(List<UserSummary> playerList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInvitePanelList`1_hotfix != null)
			{
				this.m_SetInvitePanelList`1_hotfix.call(new object[]
				{
					this,
					playerList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_canInvitePlayerList = new List<UserSummary>(playerList);
			this.SetInviteInfoPanel();
			this.SetInviteListPanel();
		}

		// Token: 0x0600F309 RID: 62217 RVA: 0x004095F8 File Offset: 0x004077F8
		private void SetInviteInfoPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInviteInfoPanel_hotfix != null)
			{
				this.m_SetInviteInfoPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int configableConstId_GuildMemberCountMax = this.m_configDataLoader.ConfigableConstId_GuildMemberCountMax;
			string arg = "white";
			if (this.m_guild.Members.Count >= configableConstId_GuildMemberCountMax)
			{
				arg = "red";
			}
			this.m_inviteInfoPanelPeopleNumberText.text = string.Format("<color={0}>{1}</color>/{2}", arg, this.m_guild.Members.Count, configableConstId_GuildMemberCountMax);
			this.m_inviteInfoPanelActiveText.text = ((!this.m_guild.AutoJoin) ? this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_ApprovalByPresident) : this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_ApprovalAuto));
			this.m_inviteInfoPanelLevelText.text = this.m_guild.JoinLevel.ToString();
			this.m_inviteInfoPanelDeclarationText.text = this.m_guild.HiringDeclaration;
		}

		// Token: 0x0600F30A RID: 62218 RVA: 0x00409734 File Offset: 0x00407934
		private void SetInviteListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInviteListPanel_hotfix != null)
			{
				this.m_SetInviteListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_inviteListPanelPowerButtonStateCtrl.SetToUIState((!this.m_isInviteListPanelPowerAscend) ? "Down" : "Up", false, true);
			this.m_canInvitePlayerList.Sort(delegate(UserSummary a, UserSummary b)
			{
				int num = (!this.m_isInviteListPanelPowerAscend) ? -1 : 1;
				return (b.TopHeroBattlePower - a.TopHeroBattlePower) * num;
			});
			if (this.m_inviteMemberInfoCtrlList == null)
			{
				this.m_inviteMemberInfoCtrlList = new List<GuildInviteMemberInfoItemUIController>();
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_inviteListPanelSociatyListScrollContent, this.m_canInvitePlayerList.Count);
			Transform transform = this.m_inviteListPanelSociatyListScrollContent.transform;
			for (int i = 0; i < this.m_canInvitePlayerList.Count; i++)
			{
				UserSummary userSummary = this.m_canInvitePlayerList[i];
				GuildInviteMemberInfoItemUIController guildInviteMemberInfoItemUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildInviteMemberInfoItemUIController = child.GetComponent<GuildInviteMemberInfoItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_invitePlayerInfoItemPrefab);
					guildInviteMemberInfoItemUIController = GameObjectUtility.AddControllerToGameObject<GuildInviteMemberInfoItemUIController>(gameObject);
					guildInviteMemberInfoItemUIController.EventOnClick += this.OnInviteMemberInfoItemClick;
					gameObject.transform.SetParent(transform, false);
					this.m_inviteMemberInfoCtrlList.Add(guildInviteMemberInfoItemUIController);
				}
				if (guildInviteMemberInfoItemUIController != null)
				{
					bool isInvited = this.m_playerContext.HasPlayerBeenInvitedByGuild(userSummary.UserId);
					guildInviteMemberInfoItemUIController.InitPlayerInfo(userSummary, isInvited);
				}
			}
			this.m_inviteListPanelSociatyListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x0600F30B RID: 62219 RVA: 0x004098D0 File Offset: 0x00407AD0
		private void OnInviteMemberInfoItemClick(GuildInviteMemberInfoItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteMemberInfoItemClickGuildInviteMemberInfoItemUIController_hotfix != null)
			{
				this.m_OnInviteMemberInfoItemClickGuildInviteMemberInfoItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildInviteMemberInfoItemUIController ctrl = ctrl2;
			GuildManagementUIController $this = this;
			if (this.EventOnGuildInviteMember != null)
			{
				this.EventOnGuildInviteMember(ctrl.InvitePlayer.UserId, delegate
				{
					$this.m_playerContext.AddUserIdToGuildInviteList(ctrl.InvitePlayer.UserId);
					CommonUIController.Instance.ShowTip($this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_InviteSucceed));
				});
			}
		}

		// Token: 0x0600F30C RID: 62220 RVA: 0x00409988 File Offset: 0x00407B88
		private void OnInviteListPanelPowerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteListPanelPowerButtonClick_hotfix != null)
			{
				this.m_OnInviteListPanelPowerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isInviteListPanelPowerAscend = !this.m_isInviteListPanelPowerAscend;
			this.SetInviteListPanel();
		}

		// Token: 0x0600F30D RID: 62221 RVA: 0x00409A00 File Offset: 0x00407C00
		private void OnInvitePanelChangeListButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInvitePanelChangeListButtonClick_hotfix != null)
			{
				this.m_OnInvitePanelChangeListButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetCanInvitePlayerList != null)
			{
				this.EventOnGetCanInvitePlayerList(delegate(List<UserSummary> playerList)
				{
					this.m_canInvitePlayerList = new List<UserSummary>(playerList);
					this.SetInviteListPanel();
				}, true);
			}
		}

		// Token: 0x0600F30E RID: 62222 RVA: 0x00409A84 File Offset: 0x00407C84
		private void OnInvitePanelBackButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInvitePanelBackButton_hotfix != null)
			{
				this.m_OnInvitePanelBackButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_canInvitePlayerList.Clear();
			this.CloseInvitePanel(delegate
			{
				this.UpdateView(this.m_guild);
			});
		}

		// Token: 0x0600F30F RID: 62223 RVA: 0x00409B04 File Offset: 0x00407D04
		private void CloseInvitePanel(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseInvitePanelAction_hotfix != null)
			{
				this.m_CloseInvitePanelAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			UIUtility.SetUIStateClose(this.m_invitePanelStateCtrl, "Close", delegate
			{
				if (onEnd != null)
				{
					onEnd();
				}
			}, true, true);
		}

		// Token: 0x0600F310 RID: 62224 RVA: 0x00409BA0 File Offset: 0x00407DA0
		private void OnInviteInfoPanelDeclarationChangeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInviteInfoPanelDeclarationChangeButtonClick_hotfix != null)
			{
				this.m_OnInviteInfoPanelDeclarationChangeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetRecruitChangeSubPanelInfo();
		}

		// Token: 0x0600F311 RID: 62225 RVA: 0x00409C08 File Offset: 0x00407E08
		private void SetRecruitChangeSubPanelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecruitChangeSubPanelInfo_hotfix != null)
			{
				this.m_SetRecruitChangeSubPanelInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_recruitPanelStateCtrl, "Show", null, false, true);
			this.m_recruitPanelInputField.text = this.m_guild.HiringDeclaration;
		}

		// Token: 0x0600F312 RID: 62226 RVA: 0x00409C94 File Offset: 0x00407E94
		private void OnRecruitPanelSaveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecruitPanelSaveButtonClick_hotfix != null)
			{
				this.m_OnRecruitPanelSaveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(this.m_recruitPanelInputField.text, '*');
			int num = this.m_playerContext.CanSetGuildHiringDeclaration(text);
			if (num == 0)
			{
				if (this.EventOnGuildHiringDeclarationSet != null)
				{
					this.EventOnGuildHiringDeclarationSet(text, delegate
					{
						this.SetInviteInfoPanel();
						this.OnRecruitPanelBackButtonClick();
						CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_SaveAnnouncementSucceed), 2f, null, true);
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600F313 RID: 62227 RVA: 0x00409D60 File Offset: 0x00407F60
		private void OnRecruitPanelBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecruitPanelBackButtonClick_hotfix != null)
			{
				this.m_OnRecruitPanelBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_recruitPanelStateCtrl, "Close", null, false, true);
		}

		// Token: 0x0600F314 RID: 62228 RVA: 0x00409DD4 File Offset: 0x00407FD4
		private void OnInvitePanelSetButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInvitePanelSetButtonClick_hotfix != null)
			{
				this.m_OnInvitePanelSetButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetGuildSetSubPanel();
		}

		// Token: 0x0600F315 RID: 62229 RVA: 0x00409E3C File Offset: 0x0040803C
		private void SetGuildSetSubPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGuildSetSubPanel_hotfix != null)
			{
				this.m_SetGuildSetSubPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_guildSetPanelStateCtrl, "Show", null, false, true);
			this.m_guildJoinLevel = this.m_guild.JoinLevel;
			this.m_isGuildAutoJoin = this.m_guild.AutoJoin;
			if (this.m_isGuildAutoJoin)
			{
				this.m_guildSetPanelApproveGroupAutoToggle.isOn = true;
			}
			else
			{
				this.m_guildSetPanelApproveGroupChairmanToggle.isOn = true;
			}
			if (this.m_guildJoinLevel == 0)
			{
				this.m_guildJoinLevel = 1;
			}
			this.m_guildSetPanelLevelInputField.text = this.m_guildJoinLevel.ToString();
			this.m_guildSetPanelHireDeclarationInputField.text = this.m_guild.HiringDeclaration;
		}

		// Token: 0x0600F316 RID: 62230 RVA: 0x00409F40 File Offset: 0x00408140
		private void OnGuildSetPanelChairmanToggleClick(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelChairmanToggleClickBoolean_hotfix != null)
			{
				this.m_OnGuildSetPanelChairmanToggleClickBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isGuildAutoJoin = !isOn;
		}

		// Token: 0x0600F317 RID: 62231 RVA: 0x00409FBC File Offset: 0x004081BC
		private void OnGuildSetPanelAutoToggleClick(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelAutoToggleClickBoolean_hotfix != null)
			{
				this.m_OnGuildSetPanelAutoToggleClickBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isGuildAutoJoin = isOn;
		}

		// Token: 0x0600F318 RID: 62232 RVA: 0x0040A034 File Offset: 0x00408234
		private void OnGuildSetPanelLevelInputFieldRightButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelLevelInputFieldRightButtonClick_hotfix != null)
			{
				this.m_OnGuildSetPanelLevelInputFieldRightButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildJoinLevel++;
			int value = this.m_configDataLoader.GetConfigDataConfigableConst(270).Value;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_guildJoinLevel = Mathf.Clamp(this.m_guildJoinLevel, value, configableConstId_PlayerLevelMaxLevel);
			this.m_guildSetPanelLevelInputField.text = this.m_guildJoinLevel.ToString();
		}

		// Token: 0x0600F319 RID: 62233 RVA: 0x0040A0F4 File Offset: 0x004082F4
		private void OnGuildSetPanelLevelInputFieldLeftButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelLevelInputFieldLeftButtonClick_hotfix != null)
			{
				this.m_OnGuildSetPanelLevelInputFieldLeftButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildJoinLevel--;
			int value = this.m_configDataLoader.GetConfigDataConfigableConst(270).Value;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_guildJoinLevel = Mathf.Clamp(this.m_guildJoinLevel, value, configableConstId_PlayerLevelMaxLevel);
			this.m_guildSetPanelLevelInputField.text = this.m_guildJoinLevel.ToString();
		}

		// Token: 0x0600F31A RID: 62234 RVA: 0x0040A1B4 File Offset: 0x004083B4
		private void OnGuildSetPanelLevelInputFieldEditEnd(string inputStr)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelLevelInputFieldEditEndString_hotfix != null)
			{
				this.m_OnGuildSetPanelLevelInputFieldEditEndString_hotfix.call(new object[]
				{
					this,
					inputStr
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int value = this.m_configDataLoader.GetConfigDataConfigableConst(270).Value;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_guildJoinLevel = Mathf.Clamp(int.Parse(inputStr), value, configableConstId_PlayerLevelMaxLevel);
			this.m_guildSetPanelLevelInputField.text = this.m_guildJoinLevel.ToString();
		}

		// Token: 0x0600F31B RID: 62235 RVA: 0x0040A278 File Offset: 0x00408478
		private void OnGuildSetPanelSaveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelSaveButtonClick_hotfix != null)
			{
				this.m_OnGuildSetPanelSaveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int value = this.m_configDataLoader.GetConfigDataConfigableConst(270).Value;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_guildJoinLevel = Mathf.Clamp(int.Parse(this.m_guildSetPanelLevelInputField.text), value, configableConstId_PlayerLevelMaxLevel);
			string arg = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(this.m_guildSetPanelHireDeclarationInputField.text, '*');
			if (this.EventOnGuildInfoSet != null)
			{
				this.EventOnGuildInfoSet(this.m_isGuildAutoJoin, this.m_guildJoinLevel, arg, delegate
				{
					this.SetInviteInfoPanel();
					this.OnGuildSetPanelBackButtonClick();
					CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_SaveAnnouncementSucceed), 2f, null, true);
				});
			}
		}

		// Token: 0x0600F31C RID: 62236 RVA: 0x0040A364 File Offset: 0x00408564
		private void OnGuildSetPanelBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildSetPanelBackButtonClick_hotfix != null)
			{
				this.m_OnGuildSetPanelBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseGuildSetPanel(delegate
			{
				this.UpdateView(this.m_guild);
			});
		}

		// Token: 0x0600F31D RID: 62237 RVA: 0x0040A3D8 File Offset: 0x004085D8
		private void CloseGuildSetPanel(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseGuildSetPanelAction_hotfix != null)
			{
				this.m_CloseGuildSetPanelAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			UIUtility.SetUIStateClose(this.m_guildSetPanelStateCtrl, "Close", delegate
			{
				if (onEnd != null)
				{
					onEnd();
				}
			}, true, true);
		}

		// Token: 0x1400032F RID: 815
		// (add) Token: 0x0600F31E RID: 62238 RVA: 0x0040A474 File Offset: 0x00408674
		// (remove) Token: 0x0600F31F RID: 62239 RVA: 0x0040A510 File Offset: 0x00408710
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

		// Token: 0x14000330 RID: 816
		// (add) Token: 0x0600F320 RID: 62240 RVA: 0x0040A5AC File Offset: 0x004087AC
		// (remove) Token: 0x0600F321 RID: 62241 RVA: 0x0040A648 File Offset: 0x00408848
		public event Action<string, Action> EventOnChangeGuildName
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeGuildNameAction`2_hotfix != null)
				{
					this.m_add_EventOnChangeGuildNameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnChangeGuildName;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnChangeGuildName, (Action<string, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeGuildNameAction`2_hotfix != null)
				{
					this.m_remove_EventOnChangeGuildNameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnChangeGuildName;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnChangeGuildName, (Action<string, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000331 RID: 817
		// (add) Token: 0x0600F322 RID: 62242 RVA: 0x0040A6E4 File Offset: 0x004088E4
		// (remove) Token: 0x0600F323 RID: 62243 RVA: 0x0040A780 File Offset: 0x00408980
		public event Action<string, Action> EventOnGuildAnnouncementSet
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildAnnouncementSetAction`2_hotfix != null)
				{
					this.m_add_EventOnGuildAnnouncementSetAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnGuildAnnouncementSet;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnGuildAnnouncementSet, (Action<string, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildAnnouncementSetAction`2_hotfix != null)
				{
					this.m_remove_EventOnGuildAnnouncementSetAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnGuildAnnouncementSet;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnGuildAnnouncementSet, (Action<string, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000332 RID: 818
		// (add) Token: 0x0600F324 RID: 62244 RVA: 0x0040A81C File Offset: 0x00408A1C
		// (remove) Token: 0x0600F325 RID: 62245 RVA: 0x0040A8B8 File Offset: 0x00408AB8
		public event Action<Action> EventOnQuitGuild
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnQuitGuildAction`1_hotfix != null)
				{
					this.m_add_EventOnQuitGuildAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnQuitGuild;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnQuitGuild, (Action<Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnQuitGuildAction`1_hotfix != null)
				{
					this.m_remove_EventOnQuitGuildAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnQuitGuild;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnQuitGuild, (Action<Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000333 RID: 819
		// (add) Token: 0x0600F326 RID: 62246 RVA: 0x0040A954 File Offset: 0x00408B54
		// (remove) Token: 0x0600F327 RID: 62247 RVA: 0x0040A9F0 File Offset: 0x00408BF0
		public event Action<Action<List<UserSummary>>, bool> EventOnGetCanInvitePlayerList
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetCanInvitePlayerListAction`2_hotfix != null)
				{
					this.m_add_EventOnGetCanInvitePlayerListAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action<List<UserSummary>>, bool> action = this.EventOnGetCanInvitePlayerList;
				Action<Action<List<UserSummary>>, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action<List<UserSummary>>, bool>>(ref this.EventOnGetCanInvitePlayerList, (Action<Action<List<UserSummary>>, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetCanInvitePlayerListAction`2_hotfix != null)
				{
					this.m_remove_EventOnGetCanInvitePlayerListAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action<List<UserSummary>>, bool> action = this.EventOnGetCanInvitePlayerList;
				Action<Action<List<UserSummary>>, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action<List<UserSummary>>, bool>>(ref this.EventOnGetCanInvitePlayerList, (Action<Action<List<UserSummary>>, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000334 RID: 820
		// (add) Token: 0x0600F328 RID: 62248 RVA: 0x0040AA8C File Offset: 0x00408C8C
		// (remove) Token: 0x0600F329 RID: 62249 RVA: 0x0040AB28 File Offset: 0x00408D28
		public event Action<string, Action> EventOnGuildHiringDeclarationSet
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildHiringDeclarationSetAction`2_hotfix != null)
				{
					this.m_add_EventOnGuildHiringDeclarationSetAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnGuildHiringDeclarationSet;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnGuildHiringDeclarationSet, (Action<string, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildHiringDeclarationSetAction`2_hotfix != null)
				{
					this.m_remove_EventOnGuildHiringDeclarationSetAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnGuildHiringDeclarationSet;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnGuildHiringDeclarationSet, (Action<string, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000335 RID: 821
		// (add) Token: 0x0600F32A RID: 62250 RVA: 0x0040ABC4 File Offset: 0x00408DC4
		// (remove) Token: 0x0600F32B RID: 62251 RVA: 0x0040AC60 File Offset: 0x00408E60
		public event Action<bool, int, string, Action> EventOnGuildInfoSet
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildInfoSetAction`4_hotfix != null)
				{
					this.m_add_EventOnGuildInfoSetAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, int, string, Action> action = this.EventOnGuildInfoSet;
				Action<bool, int, string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, int, string, Action>>(ref this.EventOnGuildInfoSet, (Action<bool, int, string, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildInfoSetAction`4_hotfix != null)
				{
					this.m_remove_EventOnGuildInfoSetAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, int, string, Action> action = this.EventOnGuildInfoSet;
				Action<bool, int, string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, int, string, Action>>(ref this.EventOnGuildInfoSet, (Action<bool, int, string, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000336 RID: 822
		// (add) Token: 0x0600F32C RID: 62252 RVA: 0x0040ACFC File Offset: 0x00408EFC
		// (remove) Token: 0x0600F32D RID: 62253 RVA: 0x0040AD98 File Offset: 0x00408F98
		public event Action<Action<List<UserSummary>>> EventOnGetGuildJoinApply
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetGuildJoinApplyAction`1_hotfix != null)
				{
					this.m_add_EventOnGetGuildJoinApplyAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action<List<UserSummary>>> action = this.EventOnGetGuildJoinApply;
				Action<Action<List<UserSummary>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action<List<UserSummary>>>>(ref this.EventOnGetGuildJoinApply, (Action<Action<List<UserSummary>>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetGuildJoinApplyAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetGuildJoinApplyAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action<List<UserSummary>>> action = this.EventOnGetGuildJoinApply;
				Action<Action<List<UserSummary>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action<List<UserSummary>>>>(ref this.EventOnGetGuildJoinApply, (Action<Action<List<UserSummary>>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000337 RID: 823
		// (add) Token: 0x0600F32E RID: 62254 RVA: 0x0040AE34 File Offset: 0x00409034
		// (remove) Token: 0x0600F32F RID: 62255 RVA: 0x0040AED0 File Offset: 0x004090D0
		public event Action<Action<List<GuildLog>>> EventOnGetGuildJournal
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetGuildJournalAction`1_hotfix != null)
				{
					this.m_add_EventOnGetGuildJournalAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action<List<GuildLog>>> action = this.EventOnGetGuildJournal;
				Action<Action<List<GuildLog>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action<List<GuildLog>>>>(ref this.EventOnGetGuildJournal, (Action<Action<List<GuildLog>>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetGuildJournalAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetGuildJournalAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action<List<GuildLog>>> action = this.EventOnGetGuildJournal;
				Action<Action<List<GuildLog>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action<List<GuildLog>>>>(ref this.EventOnGetGuildJournal, (Action<Action<List<GuildLog>>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000338 RID: 824
		// (add) Token: 0x0600F330 RID: 62256 RVA: 0x0040AF6C File Offset: 0x0040916C
		// (remove) Token: 0x0600F331 RID: 62257 RVA: 0x0040B008 File Offset: 0x00409208
		public event Action<string, bool, Action> EventOnGuildJoinConfirmOrRefuse
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildJoinConfirmOrRefuseAction`3_hotfix != null)
				{
					this.m_add_EventOnGuildJoinConfirmOrRefuseAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, bool, Action> action = this.EventOnGuildJoinConfirmOrRefuse;
				Action<string, bool, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, bool, Action>>(ref this.EventOnGuildJoinConfirmOrRefuse, (Action<string, bool, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildJoinConfirmOrRefuseAction`3_hotfix != null)
				{
					this.m_remove_EventOnGuildJoinConfirmOrRefuseAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, bool, Action> action = this.EventOnGuildJoinConfirmOrRefuse;
				Action<string, bool, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, bool, Action>>(ref this.EventOnGuildJoinConfirmOrRefuse, (Action<string, bool, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000339 RID: 825
		// (add) Token: 0x0600F332 RID: 62258 RVA: 0x0040B0A4 File Offset: 0x004092A4
		// (remove) Token: 0x0600F333 RID: 62259 RVA: 0x0040B140 File Offset: 0x00409340
		public event Action<string, Action> EventOnGuildInviteMember
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildInviteMemberAction`2_hotfix != null)
				{
					this.m_add_EventOnGuildInviteMemberAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnGuildInviteMember;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnGuildInviteMember, (Action<string, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildInviteMemberAction`2_hotfix != null)
				{
					this.m_remove_EventOnGuildInviteMemberAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Action> action = this.EventOnGuildInviteMember;
				Action<string, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Action>>(ref this.EventOnGuildInviteMember, (Action<string, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400033A RID: 826
		// (add) Token: 0x0600F334 RID: 62260 RVA: 0x0040B1DC File Offset: 0x004093DC
		// (remove) Token: 0x0600F335 RID: 62261 RVA: 0x0040B278 File Offset: 0x00409478
		public event Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> EventOnGuildMemberClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGuildMemberClickAction`3_hotfix != null)
				{
					this.m_add_EventOnGuildMemberClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> action = this.EventOnGuildMemberClick;
				Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Vector3, PlayerSimpleInfoUITask.PostionType>>(ref this.EventOnGuildMemberClick, (Action<string, Vector3, PlayerSimpleInfoUITask.PostionType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGuildMemberClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnGuildMemberClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> action = this.EventOnGuildMemberClick;
				Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, Vector3, PlayerSimpleInfoUITask.PostionType>>(ref this.EventOnGuildMemberClick, (Action<string, Vector3, PlayerSimpleInfoUITask.PostionType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400033B RID: 827
		// (add) Token: 0x0600F336 RID: 62262 RVA: 0x0040B314 File Offset: 0x00409514
		// (remove) Token: 0x0600F337 RID: 62263 RVA: 0x0040B3B0 File Offset: 0x004095B0
		public event Action<Action> EventOnAllRefuseButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAllRefuseButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnAllRefuseButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnAllRefuseButtonClick;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnAllRefuseButtonClick, (Action<Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAllRefuseButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnAllRefuseButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnAllRefuseButtonClick;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnAllRefuseButtonClick, (Action<Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400033C RID: 828
		// (add) Token: 0x0600F338 RID: 62264 RVA: 0x0040B44C File Offset: 0x0040964C
		// (remove) Token: 0x0600F339 RID: 62265 RVA: 0x0040B4E8 File Offset: 0x004096E8
		public event Action EventOnGotoGuildStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoGuildStoreAction_hotfix != null)
				{
					this.m_add_EventOnGotoGuildStoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoGuildStore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoGuildStore, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoGuildStoreAction_hotfix != null)
				{
					this.m_remove_EventOnGotoGuildStoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoGuildStore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoGuildStore, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400033D RID: 829
		// (add) Token: 0x0600F33A RID: 62266 RVA: 0x0040B584 File Offset: 0x00409784
		// (remove) Token: 0x0600F33B RID: 62267 RVA: 0x0040B620 File Offset: 0x00409820
		public event Action EventOnGotoGuildGameListPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoGuildGameListPanelAction_hotfix != null)
				{
					this.m_add_EventOnGotoGuildGameListPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoGuildGameListPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoGuildGameListPanel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoGuildGameListPanelAction_hotfix != null)
				{
					this.m_remove_EventOnGotoGuildGameListPanelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoGuildGameListPanel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoGuildGameListPanel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x0600F33C RID: 62268 RVA: 0x0040B6BC File Offset: 0x004098BC
		// (set) Token: 0x0600F33D RID: 62269 RVA: 0x0040B6DC File Offset: 0x004098DC
		[DoNotToLua]
		public new GuildManagementUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildManagementUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F33E RID: 62270 RVA: 0x0040B6E8 File Offset: 0x004098E8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F33F RID: 62271 RVA: 0x0040B6F4 File Offset: 0x004098F4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F340 RID: 62272 RVA: 0x0040B6FC File Offset: 0x004098FC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F341 RID: 62273 RVA: 0x0040B704 File Offset: 0x00409904
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x0040B718 File Offset: 0x00409918
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F343 RID: 62275 RVA: 0x0040B720 File Offset: 0x00409920
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F344 RID: 62276 RVA: 0x0040B72C File Offset: 0x0040992C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F345 RID: 62277 RVA: 0x0040B738 File Offset: 0x00409938
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F346 RID: 62278 RVA: 0x0040B744 File Offset: 0x00409944
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F347 RID: 62279 RVA: 0x0040B750 File Offset: 0x00409950
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F348 RID: 62280 RVA: 0x0040B75C File Offset: 0x0040995C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F349 RID: 62281 RVA: 0x0040B768 File Offset: 0x00409968
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F34A RID: 62282 RVA: 0x0040B774 File Offset: 0x00409974
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F34B RID: 62283 RVA: 0x0040B780 File Offset: 0x00409980
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F34C RID: 62284 RVA: 0x0040B78C File Offset: 0x0040998C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F34D RID: 62285 RVA: 0x0040B794 File Offset: 0x00409994
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600F34E RID: 62286 RVA: 0x0040B7B4 File Offset: 0x004099B4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600F34F RID: 62287 RVA: 0x0040B7C0 File Offset: 0x004099C0
		private void __callDele_EventOnChangeGuildName(string arg1, Action arg2)
		{
			Action<string, Action> eventOnChangeGuildName = this.EventOnChangeGuildName;
			if (eventOnChangeGuildName != null)
			{
				eventOnChangeGuildName(arg1, arg2);
			}
		}

		// Token: 0x0600F350 RID: 62288 RVA: 0x0040B7E4 File Offset: 0x004099E4
		private void __clearDele_EventOnChangeGuildName(string arg1, Action arg2)
		{
			this.EventOnChangeGuildName = null;
		}

		// Token: 0x0600F351 RID: 62289 RVA: 0x0040B7F0 File Offset: 0x004099F0
		private void __callDele_EventOnGuildAnnouncementSet(string arg1, Action arg2)
		{
			Action<string, Action> eventOnGuildAnnouncementSet = this.EventOnGuildAnnouncementSet;
			if (eventOnGuildAnnouncementSet != null)
			{
				eventOnGuildAnnouncementSet(arg1, arg2);
			}
		}

		// Token: 0x0600F352 RID: 62290 RVA: 0x0040B814 File Offset: 0x00409A14
		private void __clearDele_EventOnGuildAnnouncementSet(string arg1, Action arg2)
		{
			this.EventOnGuildAnnouncementSet = null;
		}

		// Token: 0x0600F353 RID: 62291 RVA: 0x0040B820 File Offset: 0x00409A20
		private void __callDele_EventOnQuitGuild(Action obj)
		{
			Action<Action> eventOnQuitGuild = this.EventOnQuitGuild;
			if (eventOnQuitGuild != null)
			{
				eventOnQuitGuild(obj);
			}
		}

		// Token: 0x0600F354 RID: 62292 RVA: 0x0040B844 File Offset: 0x00409A44
		private void __clearDele_EventOnQuitGuild(Action obj)
		{
			this.EventOnQuitGuild = null;
		}

		// Token: 0x0600F355 RID: 62293 RVA: 0x0040B850 File Offset: 0x00409A50
		private void __callDele_EventOnGetCanInvitePlayerList(Action<List<UserSummary>> arg1, bool arg2)
		{
			Action<Action<List<UserSummary>>, bool> eventOnGetCanInvitePlayerList = this.EventOnGetCanInvitePlayerList;
			if (eventOnGetCanInvitePlayerList != null)
			{
				eventOnGetCanInvitePlayerList(arg1, arg2);
			}
		}

		// Token: 0x0600F356 RID: 62294 RVA: 0x0040B874 File Offset: 0x00409A74
		private void __clearDele_EventOnGetCanInvitePlayerList(Action<List<UserSummary>> arg1, bool arg2)
		{
			this.EventOnGetCanInvitePlayerList = null;
		}

		// Token: 0x0600F357 RID: 62295 RVA: 0x0040B880 File Offset: 0x00409A80
		private void __callDele_EventOnGuildHiringDeclarationSet(string arg1, Action arg2)
		{
			Action<string, Action> eventOnGuildHiringDeclarationSet = this.EventOnGuildHiringDeclarationSet;
			if (eventOnGuildHiringDeclarationSet != null)
			{
				eventOnGuildHiringDeclarationSet(arg1, arg2);
			}
		}

		// Token: 0x0600F358 RID: 62296 RVA: 0x0040B8A4 File Offset: 0x00409AA4
		private void __clearDele_EventOnGuildHiringDeclarationSet(string arg1, Action arg2)
		{
			this.EventOnGuildHiringDeclarationSet = null;
		}

		// Token: 0x0600F359 RID: 62297 RVA: 0x0040B8B0 File Offset: 0x00409AB0
		private void __callDele_EventOnGuildInfoSet(bool arg1, int arg2, string arg3, Action arg4)
		{
			Action<bool, int, string, Action> eventOnGuildInfoSet = this.EventOnGuildInfoSet;
			if (eventOnGuildInfoSet != null)
			{
				eventOnGuildInfoSet(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x0600F35A RID: 62298 RVA: 0x0040B8D8 File Offset: 0x00409AD8
		private void __clearDele_EventOnGuildInfoSet(bool arg1, int arg2, string arg3, Action arg4)
		{
			this.EventOnGuildInfoSet = null;
		}

		// Token: 0x0600F35B RID: 62299 RVA: 0x0040B8E4 File Offset: 0x00409AE4
		private void __callDele_EventOnGetGuildJoinApply(Action<List<UserSummary>> obj)
		{
			Action<Action<List<UserSummary>>> eventOnGetGuildJoinApply = this.EventOnGetGuildJoinApply;
			if (eventOnGetGuildJoinApply != null)
			{
				eventOnGetGuildJoinApply(obj);
			}
		}

		// Token: 0x0600F35C RID: 62300 RVA: 0x0040B908 File Offset: 0x00409B08
		private void __clearDele_EventOnGetGuildJoinApply(Action<List<UserSummary>> obj)
		{
			this.EventOnGetGuildJoinApply = null;
		}

		// Token: 0x0600F35D RID: 62301 RVA: 0x0040B914 File Offset: 0x00409B14
		private void __callDele_EventOnGetGuildJournal(Action<List<GuildLog>> obj)
		{
			Action<Action<List<GuildLog>>> eventOnGetGuildJournal = this.EventOnGetGuildJournal;
			if (eventOnGetGuildJournal != null)
			{
				eventOnGetGuildJournal(obj);
			}
		}

		// Token: 0x0600F35E RID: 62302 RVA: 0x0040B938 File Offset: 0x00409B38
		private void __clearDele_EventOnGetGuildJournal(Action<List<GuildLog>> obj)
		{
			this.EventOnGetGuildJournal = null;
		}

		// Token: 0x0600F35F RID: 62303 RVA: 0x0040B944 File Offset: 0x00409B44
		private void __callDele_EventOnGuildJoinConfirmOrRefuse(string arg1, bool arg2, Action arg3)
		{
			Action<string, bool, Action> eventOnGuildJoinConfirmOrRefuse = this.EventOnGuildJoinConfirmOrRefuse;
			if (eventOnGuildJoinConfirmOrRefuse != null)
			{
				eventOnGuildJoinConfirmOrRefuse(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600F360 RID: 62304 RVA: 0x0040B968 File Offset: 0x00409B68
		private void __clearDele_EventOnGuildJoinConfirmOrRefuse(string arg1, bool arg2, Action arg3)
		{
			this.EventOnGuildJoinConfirmOrRefuse = null;
		}

		// Token: 0x0600F361 RID: 62305 RVA: 0x0040B974 File Offset: 0x00409B74
		private void __callDele_EventOnGuildInviteMember(string arg1, Action arg2)
		{
			Action<string, Action> eventOnGuildInviteMember = this.EventOnGuildInviteMember;
			if (eventOnGuildInviteMember != null)
			{
				eventOnGuildInviteMember(arg1, arg2);
			}
		}

		// Token: 0x0600F362 RID: 62306 RVA: 0x0040B998 File Offset: 0x00409B98
		private void __clearDele_EventOnGuildInviteMember(string arg1, Action arg2)
		{
			this.EventOnGuildInviteMember = null;
		}

		// Token: 0x0600F363 RID: 62307 RVA: 0x0040B9A4 File Offset: 0x00409BA4
		private void __callDele_EventOnGuildMemberClick(string arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
		{
			Action<string, Vector3, PlayerSimpleInfoUITask.PostionType> eventOnGuildMemberClick = this.EventOnGuildMemberClick;
			if (eventOnGuildMemberClick != null)
			{
				eventOnGuildMemberClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600F364 RID: 62308 RVA: 0x0040B9C8 File Offset: 0x00409BC8
		private void __clearDele_EventOnGuildMemberClick(string arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
		{
			this.EventOnGuildMemberClick = null;
		}

		// Token: 0x0600F365 RID: 62309 RVA: 0x0040B9D4 File Offset: 0x00409BD4
		private void __callDele_EventOnAllRefuseButtonClick(Action obj)
		{
			Action<Action> eventOnAllRefuseButtonClick = this.EventOnAllRefuseButtonClick;
			if (eventOnAllRefuseButtonClick != null)
			{
				eventOnAllRefuseButtonClick(obj);
			}
		}

		// Token: 0x0600F366 RID: 62310 RVA: 0x0040B9F8 File Offset: 0x00409BF8
		private void __clearDele_EventOnAllRefuseButtonClick(Action obj)
		{
			this.EventOnAllRefuseButtonClick = null;
		}

		// Token: 0x0600F367 RID: 62311 RVA: 0x0040BA04 File Offset: 0x00409C04
		private void __callDele_EventOnGotoGuildStore()
		{
			Action eventOnGotoGuildStore = this.EventOnGotoGuildStore;
			if (eventOnGotoGuildStore != null)
			{
				eventOnGotoGuildStore();
			}
		}

		// Token: 0x0600F368 RID: 62312 RVA: 0x0040BA24 File Offset: 0x00409C24
		private void __clearDele_EventOnGotoGuildStore()
		{
			this.EventOnGotoGuildStore = null;
		}

		// Token: 0x0600F369 RID: 62313 RVA: 0x0040BA30 File Offset: 0x00409C30
		private void __callDele_EventOnGotoGuildGameListPanel()
		{
			Action eventOnGotoGuildGameListPanel = this.EventOnGotoGuildGameListPanel;
			if (eventOnGotoGuildGameListPanel != null)
			{
				eventOnGotoGuildGameListPanel();
			}
		}

		// Token: 0x0600F36A RID: 62314 RVA: 0x0040BA50 File Offset: 0x00409C50
		private void __clearDele_EventOnGotoGuildGameListPanel()
		{
			this.EventOnGotoGuildGameListPanel = null;
		}

		// Token: 0x0600F37E RID: 62334 RVA: 0x0040BCF8 File Offset: 0x00409EF8
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
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_UpdateViewGuild_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_RefreshGuildTitle_hotfix = (luaObj.RawGet("RefreshGuildTitle") as LuaFunction);
					this.m_SetStateByGuildTitle_hotfix = (luaObj.RawGet("SetStateByGuildTitle") as LuaFunction);
					this.m_SetSociatyInfoPanel_hotfix = (luaObj.RawGet("SetSociatyInfoPanel") as LuaFunction);
					this.m_SetSociatyListPanelList`1_hotfix = (luaObj.RawGet("SetSociatyListPanel") as LuaFunction);
					this.m_OnGuildManagementListPlayeItemClickGuildMemberInfoItemUIController_hotfix = (luaObj.RawGet("OnGuildManagementListPlayeItemClick") as LuaFunction);
					this.m_SetMessageRedPointBoolean_hotfix = (luaObj.RawGet("SetMessageRedPoint") as LuaFunction);
					this.m_OnReturnImgButtonClick_hotfix = (luaObj.RawGet("OnReturnImgButtonClick") as LuaFunction);
					this.m_OnInfoButtonClick_hotfix = (luaObj.RawGet("OnInfoButtonClick") as LuaFunction);
					this.m_OnGuildCoinButtonClick_hotfix = (luaObj.RawGet("OnGuildCoinButtonClick") as LuaFunction);
					this.m_ClearData_hotfix = (luaObj.RawGet("ClearData") as LuaFunction);
					this.m_CloseAllSmallPanel_hotfix = (luaObj.RawGet("CloseAllSmallPanel") as LuaFunction);
					this.m_OnOnlineButtonClick_hotfix = (luaObj.RawGet("OnOnlineButtonClick") as LuaFunction);
					this.m_OnActiveButtonClick_hotfix = (luaObj.RawGet("OnActiveButtonClick") as LuaFunction);
					this.m_OnPowerButtonClick_hotfix = (luaObj.RawGet("OnPowerButtonClick") as LuaFunction);
					this.m_SetSortButtonStateGuildListSortType_hotfix = (luaObj.RawGet("SetSortButtonState") as LuaFunction);
					this.m_SortByTitleGuildMemberCacheObjectGuildMemberCacheObject_hotfix = (luaObj.RawGet("SortByTitle") as LuaFunction);
					this.m_SortByPowerGuildMemberCacheObjectGuildMemberCacheObject_hotfix = (luaObj.RawGet("SortByPower") as LuaFunction);
					this.m_SortByActiveGuildMemberCacheObjectGuildMemberCacheObject_hotfix = (luaObj.RawGet("SortByActive") as LuaFunction);
					this.m_SortGuildListByDefaultList`1_hotfix = (luaObj.RawGet("SortGuildListByDefault") as LuaFunction);
					this.m_SortByDefaultTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix = (luaObj.RawGet("SortByDefaultType") as LuaFunction);
					this.m_SortByActiveTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix = (luaObj.RawGet("SortByActiveType") as LuaFunction);
					this.m_SortByBattlePowerTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix = (luaObj.RawGet("SortByBattlePowerType") as LuaFunction);
					this.m_OnSociatyNameChangeButtonClick_hotfix = (luaObj.RawGet("OnSociatyNameChangeButtonClick") as LuaFunction);
					this.m_OnGuildChangeNamePanelChangeNameButtonClick_hotfix = (luaObj.RawGet("OnGuildChangeNamePanelChangeNameButtonClick") as LuaFunction);
					this.m_OnGuildChangeNamePanelBackButtonClick_hotfix = (luaObj.RawGet("OnGuildChangeNamePanelBackButtonClick") as LuaFunction);
					this.m_OnDeclarationButtonClick_hotfix = (luaObj.RawGet("OnDeclarationButtonClick") as LuaFunction);
					this.m_OnDeclarationChangePanelSaveButtonClick_hotfix = (luaObj.RawGet("OnDeclarationChangePanelSaveButtonClick") as LuaFunction);
					this.m_OnDeclarationChangePanelBackButtonClick_hotfix = (luaObj.RawGet("OnDeclarationChangePanelBackButtonClick") as LuaFunction);
					this.m_OnQuitButtonClick_hotfix = (luaObj.RawGet("OnQuitButtonClick") as LuaFunction);
					this.m_OnQuitGuildConfirmButtonClick_hotfix = (luaObj.RawGet("OnQuitGuildConfirmButtonClick") as LuaFunction);
					this.m_CloseQuitGuildConfirmPanel_hotfix = (luaObj.RawGet("CloseQuitGuildConfirmPanel") as LuaFunction);
					this.m_OnSociatyPlayButtonClick_hotfix = (luaObj.RawGet("OnSociatyPlayButtonClick") as LuaFunction);
					this.m_OnShopButtonClick_hotfix = (luaObj.RawGet("OnShopButtonClick") as LuaFunction);
					this.m_OnWealButtonClick_hotfix = (luaObj.RawGet("OnWealButtonClick") as LuaFunction);
					this.m_OnMessageButtonClick_hotfix = (luaObj.RawGet("OnMessageButtonClick") as LuaFunction);
					this.m_SendNtfBeforeOpenMessagePanelBooleanAction_hotfix = (luaObj.RawGet("SendNtfBeforeOpenMessagePanel") as LuaFunction);
					this.m_SetMessageApplyPanelList`1_hotfix = (luaObj.RawGet("SetMessageApplyPanel") as LuaFunction);
					this.m_OnGuildApplyMemberAcceptResultGuildApplyMemberInfoItemUIControllerBoolean_hotfix = (luaObj.RawGet("OnGuildApplyMemberAcceptResult") as LuaFunction);
					this.m_SetMessageJournalPanelList`1_hotfix = (luaObj.RawGet("SetMessageJournalPanel") as LuaFunction);
					this.m_OnMssageApplyPanelPowerButtonClick_hotfix = (luaObj.RawGet("OnMssageApplyPanelPowerButtonClick") as LuaFunction);
					this.m_OnMessagePanelBackButtonClick_hotfix = (luaObj.RawGet("OnMessagePanelBackButtonClick") as LuaFunction);
					this.m_CloseMessagePanelAction_hotfix = (luaObj.RawGet("CloseMessagePanel") as LuaFunction);
					this.m_OnMessagePanelApplyToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMessagePanelApplyToggleValueChanged") as LuaFunction);
					this.m_OnMessagePanelJournalToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMessagePanelJournalToggleValueChanged") as LuaFunction);
					this.m_OnMessageApplyPanelAllRefuseButtonClick_hotfix = (luaObj.RawGet("OnMessageApplyPanelAllRefuseButtonClick") as LuaFunction);
					this.m_OnInviteButtonClick_hotfix = (luaObj.RawGet("OnInviteButtonClick") as LuaFunction);
					this.m_SetInvitePanelList`1_hotfix = (luaObj.RawGet("SetInvitePanel") as LuaFunction);
					this.m_SetInviteInfoPanel_hotfix = (luaObj.RawGet("SetInviteInfoPanel") as LuaFunction);
					this.m_SetInviteListPanel_hotfix = (luaObj.RawGet("SetInviteListPanel") as LuaFunction);
					this.m_OnInviteMemberInfoItemClickGuildInviteMemberInfoItemUIController_hotfix = (luaObj.RawGet("OnInviteMemberInfoItemClick") as LuaFunction);
					this.m_OnInviteListPanelPowerButtonClick_hotfix = (luaObj.RawGet("OnInviteListPanelPowerButtonClick") as LuaFunction);
					this.m_OnInvitePanelChangeListButtonClick_hotfix = (luaObj.RawGet("OnInvitePanelChangeListButtonClick") as LuaFunction);
					this.m_OnInvitePanelBackButton_hotfix = (luaObj.RawGet("OnInvitePanelBackButton") as LuaFunction);
					this.m_CloseInvitePanelAction_hotfix = (luaObj.RawGet("CloseInvitePanel") as LuaFunction);
					this.m_OnInviteInfoPanelDeclarationChangeButtonClick_hotfix = (luaObj.RawGet("OnInviteInfoPanelDeclarationChangeButtonClick") as LuaFunction);
					this.m_SetRecruitChangeSubPanelInfo_hotfix = (luaObj.RawGet("SetRecruitChangeSubPanelInfo") as LuaFunction);
					this.m_OnRecruitPanelSaveButtonClick_hotfix = (luaObj.RawGet("OnRecruitPanelSaveButtonClick") as LuaFunction);
					this.m_OnRecruitPanelBackButtonClick_hotfix = (luaObj.RawGet("OnRecruitPanelBackButtonClick") as LuaFunction);
					this.m_OnInvitePanelSetButtonClick_hotfix = (luaObj.RawGet("OnInvitePanelSetButtonClick") as LuaFunction);
					this.m_SetGuildSetSubPanel_hotfix = (luaObj.RawGet("SetGuildSetSubPanel") as LuaFunction);
					this.m_OnGuildSetPanelChairmanToggleClickBoolean_hotfix = (luaObj.RawGet("OnGuildSetPanelChairmanToggleClick") as LuaFunction);
					this.m_OnGuildSetPanelAutoToggleClickBoolean_hotfix = (luaObj.RawGet("OnGuildSetPanelAutoToggleClick") as LuaFunction);
					this.m_OnGuildSetPanelLevelInputFieldRightButtonClick_hotfix = (luaObj.RawGet("OnGuildSetPanelLevelInputFieldRightButtonClick") as LuaFunction);
					this.m_OnGuildSetPanelLevelInputFieldLeftButtonClick_hotfix = (luaObj.RawGet("OnGuildSetPanelLevelInputFieldLeftButtonClick") as LuaFunction);
					this.m_OnGuildSetPanelLevelInputFieldEditEndString_hotfix = (luaObj.RawGet("OnGuildSetPanelLevelInputFieldEditEnd") as LuaFunction);
					this.m_OnGuildSetPanelSaveButtonClick_hotfix = (luaObj.RawGet("OnGuildSetPanelSaveButtonClick") as LuaFunction);
					this.m_OnGuildSetPanelBackButtonClick_hotfix = (luaObj.RawGet("OnGuildSetPanelBackButtonClick") as LuaFunction);
					this.m_CloseGuildSetPanelAction_hotfix = (luaObj.RawGet("CloseGuildSetPanel") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnChangeGuildNameAction`2_hotfix = (luaObj.RawGet("add_EventOnChangeGuildName") as LuaFunction);
					this.m_remove_EventOnChangeGuildNameAction`2_hotfix = (luaObj.RawGet("remove_EventOnChangeGuildName") as LuaFunction);
					this.m_add_EventOnGuildAnnouncementSetAction`2_hotfix = (luaObj.RawGet("add_EventOnGuildAnnouncementSet") as LuaFunction);
					this.m_remove_EventOnGuildAnnouncementSetAction`2_hotfix = (luaObj.RawGet("remove_EventOnGuildAnnouncementSet") as LuaFunction);
					this.m_add_EventOnQuitGuildAction`1_hotfix = (luaObj.RawGet("add_EventOnQuitGuild") as LuaFunction);
					this.m_remove_EventOnQuitGuildAction`1_hotfix = (luaObj.RawGet("remove_EventOnQuitGuild") as LuaFunction);
					this.m_add_EventOnGetCanInvitePlayerListAction`2_hotfix = (luaObj.RawGet("add_EventOnGetCanInvitePlayerList") as LuaFunction);
					this.m_remove_EventOnGetCanInvitePlayerListAction`2_hotfix = (luaObj.RawGet("remove_EventOnGetCanInvitePlayerList") as LuaFunction);
					this.m_add_EventOnGuildHiringDeclarationSetAction`2_hotfix = (luaObj.RawGet("add_EventOnGuildHiringDeclarationSet") as LuaFunction);
					this.m_remove_EventOnGuildHiringDeclarationSetAction`2_hotfix = (luaObj.RawGet("remove_EventOnGuildHiringDeclarationSet") as LuaFunction);
					this.m_add_EventOnGuildInfoSetAction`4_hotfix = (luaObj.RawGet("add_EventOnGuildInfoSet") as LuaFunction);
					this.m_remove_EventOnGuildInfoSetAction`4_hotfix = (luaObj.RawGet("remove_EventOnGuildInfoSet") as LuaFunction);
					this.m_add_EventOnGetGuildJoinApplyAction`1_hotfix = (luaObj.RawGet("add_EventOnGetGuildJoinApply") as LuaFunction);
					this.m_remove_EventOnGetGuildJoinApplyAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetGuildJoinApply") as LuaFunction);
					this.m_add_EventOnGetGuildJournalAction`1_hotfix = (luaObj.RawGet("add_EventOnGetGuildJournal") as LuaFunction);
					this.m_remove_EventOnGetGuildJournalAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetGuildJournal") as LuaFunction);
					this.m_add_EventOnGuildJoinConfirmOrRefuseAction`3_hotfix = (luaObj.RawGet("add_EventOnGuildJoinConfirmOrRefuse") as LuaFunction);
					this.m_remove_EventOnGuildJoinConfirmOrRefuseAction`3_hotfix = (luaObj.RawGet("remove_EventOnGuildJoinConfirmOrRefuse") as LuaFunction);
					this.m_add_EventOnGuildInviteMemberAction`2_hotfix = (luaObj.RawGet("add_EventOnGuildInviteMember") as LuaFunction);
					this.m_remove_EventOnGuildInviteMemberAction`2_hotfix = (luaObj.RawGet("remove_EventOnGuildInviteMember") as LuaFunction);
					this.m_add_EventOnGuildMemberClickAction`3_hotfix = (luaObj.RawGet("add_EventOnGuildMemberClick") as LuaFunction);
					this.m_remove_EventOnGuildMemberClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnGuildMemberClick") as LuaFunction);
					this.m_add_EventOnAllRefuseButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAllRefuseButtonClick") as LuaFunction);
					this.m_remove_EventOnAllRefuseButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAllRefuseButtonClick") as LuaFunction);
					this.m_add_EventOnGotoGuildStoreAction_hotfix = (luaObj.RawGet("add_EventOnGotoGuildStore") as LuaFunction);
					this.m_remove_EventOnGotoGuildStoreAction_hotfix = (luaObj.RawGet("remove_EventOnGotoGuildStore") as LuaFunction);
					this.m_add_EventOnGotoGuildGameListPanelAction_hotfix = (luaObj.RawGet("add_EventOnGotoGuildGameListPanel") as LuaFunction);
					this.m_remove_EventOnGotoGuildGameListPanelAction_hotfix = (luaObj.RawGet("remove_EventOnGotoGuildGameListPanel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F37F RID: 62335 RVA: 0x0040C7A0 File Offset: 0x0040A9A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildManagementUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009007 RID: 36871
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateController;

		// Token: 0x04009008 RID: 36872
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009009 RID: 36873
		[AutoBind("./InfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoButton;

		// Token: 0x0400900A RID: 36874
		[AutoBind("./TitleImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_sociatyName;

		// Token: 0x0400900B RID: 36875
		[AutoBind("./TitleImage/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sociatyNameChangeButton;

		// Token: 0x0400900C RID: 36876
		[AutoBind("./MainPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_mainPanelStateCtrl;

		// Token: 0x0400900D RID: 36877
		[AutoBind("./PlayerResource/GuildCoin/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildCoinText;

		// Token: 0x0400900E RID: 36878
		[AutoBind("./PlayerResource/GuildCoin/StatusButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildCoinDescButton;

		// Token: 0x0400900F RID: 36879
		[AutoBind("./MainPanel/ListPanel/SociatyListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_sociatyListScrollRect;

		// Token: 0x04009010 RID: 36880
		[AutoBind("./MainPanel/ListPanel/SociatyListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sociatyListScrollContent;

		// Token: 0x04009011 RID: 36881
		[AutoBind("./MainPanel/ListPanel/TopButtonGroup/PowerButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sociatyListPowerButton;

		// Token: 0x04009012 RID: 36882
		[AutoBind("./MainPanel/ListPanel/TopButtonGroup/PowerButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sociatyListPowerButtonStateCtrl;

		// Token: 0x04009013 RID: 36883
		[AutoBind("./MainPanel/ListPanel/TopButtonGroup/ActiveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sociatyListActiveButton;

		// Token: 0x04009014 RID: 36884
		[AutoBind("./MainPanel/ListPanel/TopButtonGroup/ActiveButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sociatyListActiveButtonStateCtrl;

		// Token: 0x04009015 RID: 36885
		[AutoBind("./MainPanel/ListPanel/TopButtonGroup/OnlineButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sociatyListOnlineButton;

		// Token: 0x04009016 RID: 36886
		[AutoBind("./MainPanel/ListPanel/TopButtonGroup/OnlineButton/OnlineValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_sociatyListOnlineValueText;

		// Token: 0x04009017 RID: 36887
		[AutoBind("./Prefab/ListPlayerInfoItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerInfoPrefabItem;

		// Token: 0x04009018 RID: 36888
		[AutoBind("./MainPanel/InfoPanel/SociatyID/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoSociatyIDText;

		// Token: 0x04009019 RID: 36889
		[AutoBind("./MainPanel/InfoPanel/PeopleNumber/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoPeopleNumberText;

		// Token: 0x0400901A RID: 36890
		[AutoBind("./MainPanel/InfoPanel/Power/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoPowerText;

		// Token: 0x0400901B RID: 36891
		[AutoBind("./MainPanel/InfoPanel/Active/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoActiveText;

		// Token: 0x0400901C RID: 36892
		[AutoBind("./MainPanel/InfoPanel/Coin/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoCoinText;

		// Token: 0x0400901D RID: 36893
		[AutoBind("./MainPanel/InfoPanel/Declaration/DeclarationText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoDeclarationText;

		// Token: 0x0400901E RID: 36894
		[AutoBind("./MainPanel/InfoPanel/Declaration/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoDeclarationButton;

		// Token: 0x0400901F RID: 36895
		[AutoBind("./MainPanel/InfoPanel/MessageButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_messageButton;

		// Token: 0x04009020 RID: 36896
		[AutoBind("./MainPanel/InfoPanel/MessageButton/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageButtonRedPoint;

		// Token: 0x04009021 RID: 36897
		[AutoBind("./MainPanel/InfoPanel/QuiteButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_quitButton;

		// Token: 0x04009022 RID: 36898
		[AutoBind("./MainPanel/ListPanel/BottomButtonPanel/InviteButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteButton;

		// Token: 0x04009023 RID: 36899
		[AutoBind("./MainPanel/ListPanel/BottomButtonPanel/WealButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_wealButton;

		// Token: 0x04009024 RID: 36900
		[AutoBind("./MainPanel/ListPanel/BottomButtonPanel/ShopButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_shopButton;

		// Token: 0x04009025 RID: 36901
		[AutoBind("./MainPanel/ListPanel/BottomButtonPanel/SociatyPlayButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sociatyPlayButton;

		// Token: 0x04009026 RID: 36902
		[AutoBind("./DeclarationChangePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_declarationChangePanelStateCtrl;

		// Token: 0x04009027 RID: 36903
		[AutoBind("./DeclarationChangePanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_declarationChangePanelBackButton;

		// Token: 0x04009028 RID: 36904
		[AutoBind("./DeclarationChangePanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_declarationChangePanelCloseButton;

		// Token: 0x04009029 RID: 36905
		[AutoBind("./DeclarationChangePanel/Detail/SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_declarationChangePanelSaveButton;

		// Token: 0x0400902A RID: 36906
		[AutoBind("./DeclarationChangePanel/Detail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_declarationChangePanelInputField;

		// Token: 0x0400902B RID: 36907
		[AutoBind("./AnnouncementChangePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_recruitPanelStateCtrl;

		// Token: 0x0400902C RID: 36908
		[AutoBind("./AnnouncementChangePanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_recruitPanelBackButton;

		// Token: 0x0400902D RID: 36909
		[AutoBind("./AnnouncementChangePanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_recruitPanelCloseButton;

		// Token: 0x0400902E RID: 36910
		[AutoBind("./AnnouncementChangePanel/Detail/SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_recruitPanelSaveButton;

		// Token: 0x0400902F RID: 36911
		[AutoBind("./AnnouncementChangePanel/Detail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_recruitPanelInputField;

		// Token: 0x04009030 RID: 36912
		[AutoBind("./MainPanel/InfoPanel/SetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_invitePanelSetButton;

		// Token: 0x04009031 RID: 36913
		[AutoBind("./SetPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildSetPanelStateCtrl;

		// Token: 0x04009032 RID: 36914
		[AutoBind("./SetPanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildSetPanelBackButton;

		// Token: 0x04009033 RID: 36915
		[AutoBind("./SetPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildSetPanelCloseButton;

		// Token: 0x04009034 RID: 36916
		[AutoBind("./SetPanel/Detail/SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildSetPanelSaveButton;

		// Token: 0x04009035 RID: 36917
		[AutoBind("./SetPanel/Detail/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_guildSetPanelHireDeclarationInputField;

		// Token: 0x04009036 RID: 36918
		[AutoBind("./SetPanel/Detail/LevelInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_guildSetPanelLevelInputField;

		// Token: 0x04009037 RID: 36919
		[AutoBind("./SetPanel/Detail/LevelInputField/PreButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildSetPanelLevelInputFieldLeftButton;

		// Token: 0x04009038 RID: 36920
		[AutoBind("./SetPanel/Detail/LevelInputField/AftButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildSetPanelLevelInputFieldRightButton;

		// Token: 0x04009039 RID: 36921
		[AutoBind("./SetPanel/Detail/ApproveGroup/AutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_guildSetPanelApproveGroupAutoToggle;

		// Token: 0x0400903A RID: 36922
		[AutoBind("./SetPanel/Detail/ApproveGroup/ChairmanButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_guildSetPanelApproveGroupChairmanToggle;

		// Token: 0x0400903B RID: 36923
		[AutoBind("./SociatyNameChangePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildChangeNamePanelStateCtrl;

		// Token: 0x0400903C RID: 36924
		[AutoBind("./SociatyNameChangePanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildChangeNamePanelBackButton;

		// Token: 0x0400903D RID: 36925
		[AutoBind("./SociatyNameChangePanel/Detail/ChangeNameButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildChangeNamePanelChangeNameButton;

		// Token: 0x0400903E RID: 36926
		[AutoBind("./SociatyNameChangePanel/Detail/ChangeNameButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildChangeNamePanelChangeNameButtonStateCtrl;

		// Token: 0x0400903F RID: 36927
		[AutoBind("./SociatyNameChangePanel/Detail/DeclarationInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_guildChangeNamePanelInputField;

		// Token: 0x04009040 RID: 36928
		[AutoBind("./SociatyNameChangePanel/Detail/ChangeNameButton/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildChangeNamePanelValueText;

		// Token: 0x04009041 RID: 36929
		[AutoBind("./MessagePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_messagePanelStateCtrl;

		// Token: 0x04009042 RID: 36930
		[AutoBind("./MessagePanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_messagePanelBackButton;

		// Token: 0x04009043 RID: 36931
		[AutoBind("./MessagePanel/Detail/SideToggleGroup/ApplyToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_messagePanelApplyToggle;

		// Token: 0x04009044 RID: 36932
		[AutoBind("./MessagePanel/Detail/SideToggleGroup/JournalToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_messagePanelJournalToggle;

		// Token: 0x04009045 RID: 36933
		[AutoBind("./MessagePanel/Detail/ApplyPanel/TopButtonGroup/PowerButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_messageApplyPanelPowerButton;

		// Token: 0x04009046 RID: 36934
		[AutoBind("./MessagePanel/Detail/ApplyPanel/TopButtonGroup/PowerButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_messageApplyPanelPowerButtonStateCtrl;

		// Token: 0x04009047 RID: 36935
		[AutoBind("./MessagePanel/Detail/ApplyPanel/MessageListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_messageApplyPanelMessageListScrollRect;

		// Token: 0x04009048 RID: 36936
		[AutoBind("./MessagePanel/Detail/ApplyPanel/MessageListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageApplyPanelMessageListScrollContent;

		// Token: 0x04009049 RID: 36937
		[AutoBind("./Prefab/MessagePlayerItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messagePlayerItemPrafeb;

		// Token: 0x0400904A RID: 36938
		[AutoBind("./MessagePanel/Detail/ApplyPanel/AllRefuseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_messageApplyPanelAllRefuseButton;

		// Token: 0x0400904B RID: 36939
		[AutoBind("./MessagePanel/Detail/ApplyPanel/CountGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_messageApplyPanelApplyTotalCountValueText;

		// Token: 0x0400904C RID: 36940
		[AutoBind("./MessagePanel/Detail/ApplyPanel/PeopleNumber/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_messageApplyPanelTotalPeopleNumberValueText;

		// Token: 0x0400904D RID: 36941
		[AutoBind("./MessagePanel/Detail/JournalPanel/JournalListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_messageJournalPanelListScrollRect;

		// Token: 0x0400904E RID: 36942
		[AutoBind("./MessagePanel/Detail/JournalPanel/JournalListScrollView/Viewport/Content/JournalInfo", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageJournalPanelListScrollContent;

		// Token: 0x0400904F RID: 36943
		[AutoBind("./MessagePanel/Detail/NoItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageNoItemGameObject;

		// Token: 0x04009050 RID: 36944
		[AutoBind("./Prefab/MessageJournalItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageJournalItemPrafeb;

		// Token: 0x04009051 RID: 36945
		[AutoBind("./InvitePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_invitePanelStateCtrl;

		// Token: 0x04009052 RID: 36946
		[AutoBind("./InvitePanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_invitePanelBackButton;

		// Token: 0x04009053 RID: 36947
		[AutoBind("./InvitePanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_invitePanelCloseButton;

		// Token: 0x04009054 RID: 36948
		[AutoBind("./InvitePanel/Detail/ChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_invitePanelChangeListButton;

		// Token: 0x04009055 RID: 36949
		[AutoBind("./InvitePanel/Detail/InfoPanel/PeopleNumber/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteInfoPanelPeopleNumberText;

		// Token: 0x04009056 RID: 36950
		[AutoBind("./InvitePanel/Detail/InfoPanel/Active/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteInfoPanelActiveText;

		// Token: 0x04009057 RID: 36951
		[AutoBind("./InvitePanel/Detail/InfoPanel/Level/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteInfoPanelLevelText;

		// Token: 0x04009058 RID: 36952
		[AutoBind("./InvitePanel/Detail/InfoPanel/Declaration/DeclarationText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_inviteInfoPanelDeclarationText;

		// Token: 0x04009059 RID: 36953
		[AutoBind("./InvitePanel/Detail/InfoPanel/Declaration/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteInfoPanelDeclarationChangeButton;

		// Token: 0x0400905A RID: 36954
		[AutoBind("./InvitePanel/Detail/ListPanel/SociatyListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_inviteListPanelSociatyListScrollRect;

		// Token: 0x0400905B RID: 36955
		[AutoBind("./InvitePanel/Detail/ListPanel/SociatyListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_inviteListPanelSociatyListScrollContent;

		// Token: 0x0400905C RID: 36956
		[AutoBind("./InvitePanel/Detail/ListPanel/TopButtonGroup/PowerButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inviteListPanelPowerButton;

		// Token: 0x0400905D RID: 36957
		[AutoBind("./InvitePanel/Detail/ListPanel/TopButtonGroup/PowerButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_inviteListPanelPowerButtonStateCtrl;

		// Token: 0x0400905E RID: 36958
		[AutoBind("./Prefab/InvitePlayerInfoItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_invitePlayerInfoItemPrefab;

		// Token: 0x0400905F RID: 36959
		[AutoBind("./QuitDialog", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_quitDialogStateCtrl;

		// Token: 0x04009060 RID: 36960
		[AutoBind("./QuitDialog/Panel/Title", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_quitDialogTitleText;

		// Token: 0x04009061 RID: 36961
		[AutoBind("./QuitDialog/Panel/Tip", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_quitDialogTipText;

		// Token: 0x04009062 RID: 36962
		[AutoBind("./QuitDialog/Panel/ButtonGroup/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_quitDialogConfirmButton;

		// Token: 0x04009063 RID: 36963
		[AutoBind("./QuitDialog/Panel/ButtonGroup/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_quitDialogCancelButton;

		// Token: 0x04009064 RID: 36964
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009065 RID: 36965
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009066 RID: 36966
		private const string StateName_Up = "Up";

		// Token: 0x04009067 RID: 36967
		private const string StateName_Down = "Down";

		// Token: 0x04009068 RID: 36968
		private const string StateName_Hide = "Hide";

		// Token: 0x04009069 RID: 36969
		private bool m_isManageListPowerAscend;

		// Token: 0x0400906A RID: 36970
		private bool m_isManageListActiveAscend;

		// Token: 0x0400906B RID: 36971
		private bool m_isMessageApplyListPowerAscend;

		// Token: 0x0400906C RID: 36972
		private bool m_isInviteListPanelPowerAscend;

		// Token: 0x0400906D RID: 36973
		private bool m_isMessageApplyPanelSortByPower;

		// Token: 0x0400906E RID: 36974
		private List<GuildMemberInfoItemUIController> m_playerInfoCtrlList;

		// Token: 0x0400906F RID: 36975
		private List<GuildApplyMemberInfoItemUIController> m_applyPlayerInfoCtrlList;

		// Token: 0x04009070 RID: 36976
		private List<GuildJournalItemUIController> m_guildJournalItemCtrlList;

		// Token: 0x04009071 RID: 36977
		private List<GuildInviteMemberInfoItemUIController> m_inviteMemberInfoCtrlList;

		// Token: 0x04009072 RID: 36978
		private Guild m_guild;

		// Token: 0x04009073 RID: 36979
		private GuildTitle m_guildTitle;

		// Token: 0x04009074 RID: 36980
		private List<UserSummary> m_canInvitePlayerList;

		// Token: 0x04009075 RID: 36981
		private bool m_isGuildAutoJoin;

		// Token: 0x04009076 RID: 36982
		private int m_guildJoinLevel;

		// Token: 0x04009077 RID: 36983
		private List<UserSummary> m_messageApplyUserSummarys;

		// Token: 0x04009078 RID: 36984
		private GuildManagementUIController.GuildListSortType m_guildListSortType;

		// Token: 0x04009079 RID: 36985
		[DoNotToLua]
		private GuildManagementUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400907A RID: 36986
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400907B RID: 36987
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400907C RID: 36988
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400907D RID: 36989
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400907E RID: 36990
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400907F RID: 36991
		private LuaFunction m_UpdateViewGuild_hotfix;

		// Token: 0x04009080 RID: 36992
		private LuaFunction m_RefreshGuildTitle_hotfix;

		// Token: 0x04009081 RID: 36993
		private LuaFunction m_SetStateByGuildTitle_hotfix;

		// Token: 0x04009082 RID: 36994
		private LuaFunction m_SetSociatyInfoPanel_hotfix;

		// Token: 0x04009083 RID: 36995
		private LuaFunction m_SetSociatyListPanelList;

		// Token: 0x04009084 RID: 36996
		private LuaFunction m_OnGuildManagementListPlayeItemClickGuildMemberInfoItemUIController_hotfix;

		// Token: 0x04009085 RID: 36997
		private LuaFunction m_SetMessageRedPointBoolean_hotfix;

		// Token: 0x04009086 RID: 36998
		private LuaFunction m_OnReturnImgButtonClick_hotfix;

		// Token: 0x04009087 RID: 36999
		private LuaFunction m_OnInfoButtonClick_hotfix;

		// Token: 0x04009088 RID: 37000
		private LuaFunction m_OnGuildCoinButtonClick_hotfix;

		// Token: 0x04009089 RID: 37001
		private LuaFunction m_ClearData_hotfix;

		// Token: 0x0400908A RID: 37002
		private LuaFunction m_CloseAllSmallPanel_hotfix;

		// Token: 0x0400908B RID: 37003
		private LuaFunction m_OnOnlineButtonClick_hotfix;

		// Token: 0x0400908C RID: 37004
		private LuaFunction m_OnActiveButtonClick_hotfix;

		// Token: 0x0400908D RID: 37005
		private LuaFunction m_OnPowerButtonClick_hotfix;

		// Token: 0x0400908E RID: 37006
		private LuaFunction m_SetSortButtonStateGuildListSortType_hotfix;

		// Token: 0x0400908F RID: 37007
		private LuaFunction m_SortByTitleGuildMemberCacheObjectGuildMemberCacheObject_hotfix;

		// Token: 0x04009090 RID: 37008
		private LuaFunction m_SortByPowerGuildMemberCacheObjectGuildMemberCacheObject_hotfix;

		// Token: 0x04009091 RID: 37009
		private LuaFunction m_SortByActiveGuildMemberCacheObjectGuildMemberCacheObject_hotfix;

		// Token: 0x04009092 RID: 37010
		private LuaFunction m_SortGuildListByDefaultList;

		// Token: 0x04009093 RID: 37011
		private LuaFunction m_SortByDefaultTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix;

		// Token: 0x04009094 RID: 37012
		private LuaFunction m_SortByActiveTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix;

		// Token: 0x04009095 RID: 37013
		private LuaFunction m_SortByBattlePowerTypeGuildMemberCacheObjectGuildMemberCacheObject_hotfix;

		// Token: 0x04009096 RID: 37014
		private LuaFunction m_OnSociatyNameChangeButtonClick_hotfix;

		// Token: 0x04009097 RID: 37015
		private LuaFunction m_OnGuildChangeNamePanelChangeNameButtonClick_hotfix;

		// Token: 0x04009098 RID: 37016
		private LuaFunction m_OnGuildChangeNamePanelBackButtonClick_hotfix;

		// Token: 0x04009099 RID: 37017
		private LuaFunction m_OnDeclarationButtonClick_hotfix;

		// Token: 0x0400909A RID: 37018
		private LuaFunction m_OnDeclarationChangePanelSaveButtonClick_hotfix;

		// Token: 0x0400909B RID: 37019
		private LuaFunction m_OnDeclarationChangePanelBackButtonClick_hotfix;

		// Token: 0x0400909C RID: 37020
		private LuaFunction m_OnQuitButtonClick_hotfix;

		// Token: 0x0400909D RID: 37021
		private LuaFunction m_OnQuitGuildConfirmButtonClick_hotfix;

		// Token: 0x0400909E RID: 37022
		private LuaFunction m_CloseQuitGuildConfirmPanel_hotfix;

		// Token: 0x0400909F RID: 37023
		private LuaFunction m_OnSociatyPlayButtonClick_hotfix;

		// Token: 0x040090A0 RID: 37024
		private LuaFunction m_OnShopButtonClick_hotfix;

		// Token: 0x040090A1 RID: 37025
		private LuaFunction m_OnWealButtonClick_hotfix;

		// Token: 0x040090A2 RID: 37026
		private LuaFunction m_OnMessageButtonClick_hotfix;

		// Token: 0x040090A3 RID: 37027
		private LuaFunction m_SendNtfBeforeOpenMessagePanelBooleanAction_hotfix;

		// Token: 0x040090A4 RID: 37028
		private LuaFunction m_SetMessageApplyPanelList;

		// Token: 0x040090A5 RID: 37029
		private LuaFunction m_OnGuildApplyMemberAcceptResultGuildApplyMemberInfoItemUIControllerBoolean_hotfix;

		// Token: 0x040090A6 RID: 37030
		private LuaFunction m_SetMessageJournalPanelList;

		// Token: 0x040090A7 RID: 37031
		private LuaFunction m_OnMssageApplyPanelPowerButtonClick_hotfix;

		// Token: 0x040090A8 RID: 37032
		private LuaFunction m_OnMessagePanelBackButtonClick_hotfix;

		// Token: 0x040090A9 RID: 37033
		private LuaFunction m_CloseMessagePanelAction_hotfix;

		// Token: 0x040090AA RID: 37034
		private LuaFunction m_OnMessagePanelApplyToggleValueChangedBoolean_hotfix;

		// Token: 0x040090AB RID: 37035
		private LuaFunction m_OnMessagePanelJournalToggleValueChangedBoolean_hotfix;

		// Token: 0x040090AC RID: 37036
		private LuaFunction m_OnMessageApplyPanelAllRefuseButtonClick_hotfix;

		// Token: 0x040090AD RID: 37037
		private LuaFunction m_OnInviteButtonClick_hotfix;

		// Token: 0x040090AE RID: 37038
		private LuaFunction m_SetInvitePanelList;

		// Token: 0x040090AF RID: 37039
		private LuaFunction m_SetInviteInfoPanel_hotfix;

		// Token: 0x040090B0 RID: 37040
		private LuaFunction m_SetInviteListPanel_hotfix;

		// Token: 0x040090B1 RID: 37041
		private LuaFunction m_OnInviteMemberInfoItemClickGuildInviteMemberInfoItemUIController_hotfix;

		// Token: 0x040090B2 RID: 37042
		private LuaFunction m_OnInviteListPanelPowerButtonClick_hotfix;

		// Token: 0x040090B3 RID: 37043
		private LuaFunction m_OnInvitePanelChangeListButtonClick_hotfix;

		// Token: 0x040090B4 RID: 37044
		private LuaFunction m_OnInvitePanelBackButton_hotfix;

		// Token: 0x040090B5 RID: 37045
		private LuaFunction m_CloseInvitePanelAction_hotfix;

		// Token: 0x040090B6 RID: 37046
		private LuaFunction m_OnInviteInfoPanelDeclarationChangeButtonClick_hotfix;

		// Token: 0x040090B7 RID: 37047
		private LuaFunction m_SetRecruitChangeSubPanelInfo_hotfix;

		// Token: 0x040090B8 RID: 37048
		private LuaFunction m_OnRecruitPanelSaveButtonClick_hotfix;

		// Token: 0x040090B9 RID: 37049
		private LuaFunction m_OnRecruitPanelBackButtonClick_hotfix;

		// Token: 0x040090BA RID: 37050
		private LuaFunction m_OnInvitePanelSetButtonClick_hotfix;

		// Token: 0x040090BB RID: 37051
		private LuaFunction m_SetGuildSetSubPanel_hotfix;

		// Token: 0x040090BC RID: 37052
		private LuaFunction m_OnGuildSetPanelChairmanToggleClickBoolean_hotfix;

		// Token: 0x040090BD RID: 37053
		private LuaFunction m_OnGuildSetPanelAutoToggleClickBoolean_hotfix;

		// Token: 0x040090BE RID: 37054
		private LuaFunction m_OnGuildSetPanelLevelInputFieldRightButtonClick_hotfix;

		// Token: 0x040090BF RID: 37055
		private LuaFunction m_OnGuildSetPanelLevelInputFieldLeftButtonClick_hotfix;

		// Token: 0x040090C0 RID: 37056
		private LuaFunction m_OnGuildSetPanelLevelInputFieldEditEndString_hotfix;

		// Token: 0x040090C1 RID: 37057
		private LuaFunction m_OnGuildSetPanelSaveButtonClick_hotfix;

		// Token: 0x040090C2 RID: 37058
		private LuaFunction m_OnGuildSetPanelBackButtonClick_hotfix;

		// Token: 0x040090C3 RID: 37059
		private LuaFunction m_CloseGuildSetPanelAction_hotfix;

		// Token: 0x040090C4 RID: 37060
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040090C5 RID: 37061
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040090C6 RID: 37062
		private LuaFunction m_add_EventOnChangeGuildNameAction;

		// Token: 0x040090C7 RID: 37063
		private LuaFunction m_remove_EventOnChangeGuildNameAction;

		// Token: 0x040090C8 RID: 37064
		private LuaFunction m_add_EventOnGuildAnnouncementSetAction;

		// Token: 0x040090C9 RID: 37065
		private LuaFunction m_remove_EventOnGuildAnnouncementSetAction;

		// Token: 0x040090CA RID: 37066
		private LuaFunction m_add_EventOnQuitGuildAction;

		// Token: 0x040090CB RID: 37067
		private LuaFunction m_remove_EventOnQuitGuildAction;

		// Token: 0x040090CC RID: 37068
		private LuaFunction m_add_EventOnGetCanInvitePlayerListAction;

		// Token: 0x040090CD RID: 37069
		private LuaFunction m_remove_EventOnGetCanInvitePlayerListAction;

		// Token: 0x040090CE RID: 37070
		private LuaFunction m_add_EventOnGuildHiringDeclarationSetAction;

		// Token: 0x040090CF RID: 37071
		private LuaFunction m_remove_EventOnGuildHiringDeclarationSetAction;

		// Token: 0x040090D0 RID: 37072
		private LuaFunction m_add_EventOnGuildInfoSetAction;

		// Token: 0x040090D1 RID: 37073
		private LuaFunction m_remove_EventOnGuildInfoSetAction;

		// Token: 0x040090D2 RID: 37074
		private LuaFunction m_add_EventOnGetGuildJoinApplyAction;

		// Token: 0x040090D3 RID: 37075
		private LuaFunction m_remove_EventOnGetGuildJoinApplyAction;

		// Token: 0x040090D4 RID: 37076
		private LuaFunction m_add_EventOnGetGuildJournalAction;

		// Token: 0x040090D5 RID: 37077
		private LuaFunction m_remove_EventOnGetGuildJournalAction;

		// Token: 0x040090D6 RID: 37078
		private LuaFunction m_add_EventOnGuildJoinConfirmOrRefuseAction;

		// Token: 0x040090D7 RID: 37079
		private LuaFunction m_remove_EventOnGuildJoinConfirmOrRefuseAction;

		// Token: 0x040090D8 RID: 37080
		private LuaFunction m_add_EventOnGuildInviteMemberAction;

		// Token: 0x040090D9 RID: 37081
		private LuaFunction m_remove_EventOnGuildInviteMemberAction;

		// Token: 0x040090DA RID: 37082
		private LuaFunction m_add_EventOnGuildMemberClickAction;

		// Token: 0x040090DB RID: 37083
		private LuaFunction m_remove_EventOnGuildMemberClickAction;

		// Token: 0x040090DC RID: 37084
		private LuaFunction m_add_EventOnAllRefuseButtonClickAction;

		// Token: 0x040090DD RID: 37085
		private LuaFunction m_remove_EventOnAllRefuseButtonClickAction;

		// Token: 0x040090DE RID: 37086
		private LuaFunction m_add_EventOnGotoGuildStoreAction_hotfix;

		// Token: 0x040090DF RID: 37087
		private LuaFunction m_remove_EventOnGotoGuildStoreAction_hotfix;

		// Token: 0x040090E0 RID: 37088
		private LuaFunction m_add_EventOnGotoGuildGameListPanelAction_hotfix;

		// Token: 0x040090E1 RID: 37089
		private LuaFunction m_remove_EventOnGotoGuildGameListPanelAction_hotfix;

		// Token: 0x02000CF6 RID: 3318
		public enum GuildListSortType
		{
			// Token: 0x040090E3 RID: 37091
			Default,
			// Token: 0x040090E4 RID: 37092
			Active,
			// Token: 0x040090E5 RID: 37093
			BattlePower
		}

		// Token: 0x02000CF7 RID: 3319
		public new class LuaExportHelper
		{
			// Token: 0x0600F380 RID: 62336 RVA: 0x0040C808 File Offset: 0x0040AA08
			public LuaExportHelper(GuildManagementUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F381 RID: 62337 RVA: 0x0040C818 File Offset: 0x0040AA18
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F382 RID: 62338 RVA: 0x0040C828 File Offset: 0x0040AA28
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F383 RID: 62339 RVA: 0x0040C838 File Offset: 0x0040AA38
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F384 RID: 62340 RVA: 0x0040C848 File Offset: 0x0040AA48
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F385 RID: 62341 RVA: 0x0040C860 File Offset: 0x0040AA60
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F386 RID: 62342 RVA: 0x0040C870 File Offset: 0x0040AA70
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F387 RID: 62343 RVA: 0x0040C880 File Offset: 0x0040AA80
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F388 RID: 62344 RVA: 0x0040C890 File Offset: 0x0040AA90
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F389 RID: 62345 RVA: 0x0040C8A0 File Offset: 0x0040AAA0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F38A RID: 62346 RVA: 0x0040C8B0 File Offset: 0x0040AAB0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F38B RID: 62347 RVA: 0x0040C8C0 File Offset: 0x0040AAC0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F38C RID: 62348 RVA: 0x0040C8D0 File Offset: 0x0040AAD0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F38D RID: 62349 RVA: 0x0040C8E0 File Offset: 0x0040AAE0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F38E RID: 62350 RVA: 0x0040C8F0 File Offset: 0x0040AAF0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F38F RID: 62351 RVA: 0x0040C900 File Offset: 0x0040AB00
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F390 RID: 62352 RVA: 0x0040C910 File Offset: 0x0040AB10
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600F391 RID: 62353 RVA: 0x0040C920 File Offset: 0x0040AB20
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0600F392 RID: 62354 RVA: 0x0040C930 File Offset: 0x0040AB30
			public void __callDele_EventOnChangeGuildName(string arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnChangeGuildName(arg1, arg2);
			}

			// Token: 0x0600F393 RID: 62355 RVA: 0x0040C940 File Offset: 0x0040AB40
			public void __clearDele_EventOnChangeGuildName(string arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnChangeGuildName(arg1, arg2);
			}

			// Token: 0x0600F394 RID: 62356 RVA: 0x0040C950 File Offset: 0x0040AB50
			public void __callDele_EventOnGuildAnnouncementSet(string arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnGuildAnnouncementSet(arg1, arg2);
			}

			// Token: 0x0600F395 RID: 62357 RVA: 0x0040C960 File Offset: 0x0040AB60
			public void __clearDele_EventOnGuildAnnouncementSet(string arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnGuildAnnouncementSet(arg1, arg2);
			}

			// Token: 0x0600F396 RID: 62358 RVA: 0x0040C970 File Offset: 0x0040AB70
			public void __callDele_EventOnQuitGuild(Action obj)
			{
				this.m_owner.__callDele_EventOnQuitGuild(obj);
			}

			// Token: 0x0600F397 RID: 62359 RVA: 0x0040C980 File Offset: 0x0040AB80
			public void __clearDele_EventOnQuitGuild(Action obj)
			{
				this.m_owner.__clearDele_EventOnQuitGuild(obj);
			}

			// Token: 0x0600F398 RID: 62360 RVA: 0x0040C990 File Offset: 0x0040AB90
			public void __callDele_EventOnGetCanInvitePlayerList(Action<List<UserSummary>> arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnGetCanInvitePlayerList(arg1, arg2);
			}

			// Token: 0x0600F399 RID: 62361 RVA: 0x0040C9A0 File Offset: 0x0040ABA0
			public void __clearDele_EventOnGetCanInvitePlayerList(Action<List<UserSummary>> arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnGetCanInvitePlayerList(arg1, arg2);
			}

			// Token: 0x0600F39A RID: 62362 RVA: 0x0040C9B0 File Offset: 0x0040ABB0
			public void __callDele_EventOnGuildHiringDeclarationSet(string arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnGuildHiringDeclarationSet(arg1, arg2);
			}

			// Token: 0x0600F39B RID: 62363 RVA: 0x0040C9C0 File Offset: 0x0040ABC0
			public void __clearDele_EventOnGuildHiringDeclarationSet(string arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnGuildHiringDeclarationSet(arg1, arg2);
			}

			// Token: 0x0600F39C RID: 62364 RVA: 0x0040C9D0 File Offset: 0x0040ABD0
			public void __callDele_EventOnGuildInfoSet(bool arg1, int arg2, string arg3, Action arg4)
			{
				this.m_owner.__callDele_EventOnGuildInfoSet(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600F39D RID: 62365 RVA: 0x0040C9E4 File Offset: 0x0040ABE4
			public void __clearDele_EventOnGuildInfoSet(bool arg1, int arg2, string arg3, Action arg4)
			{
				this.m_owner.__clearDele_EventOnGuildInfoSet(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600F39E RID: 62366 RVA: 0x0040C9F8 File Offset: 0x0040ABF8
			public void __callDele_EventOnGetGuildJoinApply(Action<List<UserSummary>> obj)
			{
				this.m_owner.__callDele_EventOnGetGuildJoinApply(obj);
			}

			// Token: 0x0600F39F RID: 62367 RVA: 0x0040CA08 File Offset: 0x0040AC08
			public void __clearDele_EventOnGetGuildJoinApply(Action<List<UserSummary>> obj)
			{
				this.m_owner.__clearDele_EventOnGetGuildJoinApply(obj);
			}

			// Token: 0x0600F3A0 RID: 62368 RVA: 0x0040CA18 File Offset: 0x0040AC18
			public void __callDele_EventOnGetGuildJournal(Action<List<GuildLog>> obj)
			{
				this.m_owner.__callDele_EventOnGetGuildJournal(obj);
			}

			// Token: 0x0600F3A1 RID: 62369 RVA: 0x0040CA28 File Offset: 0x0040AC28
			public void __clearDele_EventOnGetGuildJournal(Action<List<GuildLog>> obj)
			{
				this.m_owner.__clearDele_EventOnGetGuildJournal(obj);
			}

			// Token: 0x0600F3A2 RID: 62370 RVA: 0x0040CA38 File Offset: 0x0040AC38
			public void __callDele_EventOnGuildJoinConfirmOrRefuse(string arg1, bool arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnGuildJoinConfirmOrRefuse(arg1, arg2, arg3);
			}

			// Token: 0x0600F3A3 RID: 62371 RVA: 0x0040CA48 File Offset: 0x0040AC48
			public void __clearDele_EventOnGuildJoinConfirmOrRefuse(string arg1, bool arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnGuildJoinConfirmOrRefuse(arg1, arg2, arg3);
			}

			// Token: 0x0600F3A4 RID: 62372 RVA: 0x0040CA58 File Offset: 0x0040AC58
			public void __callDele_EventOnGuildInviteMember(string arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnGuildInviteMember(arg1, arg2);
			}

			// Token: 0x0600F3A5 RID: 62373 RVA: 0x0040CA68 File Offset: 0x0040AC68
			public void __clearDele_EventOnGuildInviteMember(string arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnGuildInviteMember(arg1, arg2);
			}

			// Token: 0x0600F3A6 RID: 62374 RVA: 0x0040CA78 File Offset: 0x0040AC78
			public void __callDele_EventOnGuildMemberClick(string arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
			{
				this.m_owner.__callDele_EventOnGuildMemberClick(arg1, arg2, arg3);
			}

			// Token: 0x0600F3A7 RID: 62375 RVA: 0x0040CA88 File Offset: 0x0040AC88
			public void __clearDele_EventOnGuildMemberClick(string arg1, Vector3 arg2, PlayerSimpleInfoUITask.PostionType arg3)
			{
				this.m_owner.__clearDele_EventOnGuildMemberClick(arg1, arg2, arg3);
			}

			// Token: 0x0600F3A8 RID: 62376 RVA: 0x0040CA98 File Offset: 0x0040AC98
			public void __callDele_EventOnAllRefuseButtonClick(Action obj)
			{
				this.m_owner.__callDele_EventOnAllRefuseButtonClick(obj);
			}

			// Token: 0x0600F3A9 RID: 62377 RVA: 0x0040CAA8 File Offset: 0x0040ACA8
			public void __clearDele_EventOnAllRefuseButtonClick(Action obj)
			{
				this.m_owner.__clearDele_EventOnAllRefuseButtonClick(obj);
			}

			// Token: 0x0600F3AA RID: 62378 RVA: 0x0040CAB8 File Offset: 0x0040ACB8
			public void __callDele_EventOnGotoGuildStore()
			{
				this.m_owner.__callDele_EventOnGotoGuildStore();
			}

			// Token: 0x0600F3AB RID: 62379 RVA: 0x0040CAC8 File Offset: 0x0040ACC8
			public void __clearDele_EventOnGotoGuildStore()
			{
				this.m_owner.__clearDele_EventOnGotoGuildStore();
			}

			// Token: 0x0600F3AC RID: 62380 RVA: 0x0040CAD8 File Offset: 0x0040ACD8
			public void __callDele_EventOnGotoGuildGameListPanel()
			{
				this.m_owner.__callDele_EventOnGotoGuildGameListPanel();
			}

			// Token: 0x0600F3AD RID: 62381 RVA: 0x0040CAE8 File Offset: 0x0040ACE8
			public void __clearDele_EventOnGotoGuildGameListPanel()
			{
				this.m_owner.__clearDele_EventOnGotoGuildGameListPanel();
			}

			// Token: 0x17002E99 RID: 11929
			// (get) Token: 0x0600F3AE RID: 62382 RVA: 0x0040CAF8 File Offset: 0x0040ACF8
			// (set) Token: 0x0600F3AF RID: 62383 RVA: 0x0040CB08 File Offset: 0x0040AD08
			public CommonUIStateController m_commonUIStateController
			{
				get
				{
					return this.m_owner.m_commonUIStateController;
				}
				set
				{
					this.m_owner.m_commonUIStateController = value;
				}
			}

			// Token: 0x17002E9A RID: 11930
			// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x0040CB18 File Offset: 0x0040AD18
			// (set) Token: 0x0600F3B1 RID: 62385 RVA: 0x0040CB28 File Offset: 0x0040AD28
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

			// Token: 0x17002E9B RID: 11931
			// (get) Token: 0x0600F3B2 RID: 62386 RVA: 0x0040CB38 File Offset: 0x0040AD38
			// (set) Token: 0x0600F3B3 RID: 62387 RVA: 0x0040CB48 File Offset: 0x0040AD48
			public Button m_infoButton
			{
				get
				{
					return this.m_owner.m_infoButton;
				}
				set
				{
					this.m_owner.m_infoButton = value;
				}
			}

			// Token: 0x17002E9C RID: 11932
			// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x0040CB58 File Offset: 0x0040AD58
			// (set) Token: 0x0600F3B5 RID: 62389 RVA: 0x0040CB68 File Offset: 0x0040AD68
			public Text m_sociatyName
			{
				get
				{
					return this.m_owner.m_sociatyName;
				}
				set
				{
					this.m_owner.m_sociatyName = value;
				}
			}

			// Token: 0x17002E9D RID: 11933
			// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x0040CB78 File Offset: 0x0040AD78
			// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x0040CB88 File Offset: 0x0040AD88
			public Button m_sociatyNameChangeButton
			{
				get
				{
					return this.m_owner.m_sociatyNameChangeButton;
				}
				set
				{
					this.m_owner.m_sociatyNameChangeButton = value;
				}
			}

			// Token: 0x17002E9E RID: 11934
			// (get) Token: 0x0600F3B8 RID: 62392 RVA: 0x0040CB98 File Offset: 0x0040AD98
			// (set) Token: 0x0600F3B9 RID: 62393 RVA: 0x0040CBA8 File Offset: 0x0040ADA8
			public CommonUIStateController m_mainPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_mainPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_mainPanelStateCtrl = value;
				}
			}

			// Token: 0x17002E9F RID: 11935
			// (get) Token: 0x0600F3BA RID: 62394 RVA: 0x0040CBB8 File Offset: 0x0040ADB8
			// (set) Token: 0x0600F3BB RID: 62395 RVA: 0x0040CBC8 File Offset: 0x0040ADC8
			public Text m_guildCoinText
			{
				get
				{
					return this.m_owner.m_guildCoinText;
				}
				set
				{
					this.m_owner.m_guildCoinText = value;
				}
			}

			// Token: 0x17002EA0 RID: 11936
			// (get) Token: 0x0600F3BC RID: 62396 RVA: 0x0040CBD8 File Offset: 0x0040ADD8
			// (set) Token: 0x0600F3BD RID: 62397 RVA: 0x0040CBE8 File Offset: 0x0040ADE8
			public Button m_guildCoinDescButton
			{
				get
				{
					return this.m_owner.m_guildCoinDescButton;
				}
				set
				{
					this.m_owner.m_guildCoinDescButton = value;
				}
			}

			// Token: 0x17002EA1 RID: 11937
			// (get) Token: 0x0600F3BE RID: 62398 RVA: 0x0040CBF8 File Offset: 0x0040ADF8
			// (set) Token: 0x0600F3BF RID: 62399 RVA: 0x0040CC08 File Offset: 0x0040AE08
			public ScrollRect m_sociatyListScrollRect
			{
				get
				{
					return this.m_owner.m_sociatyListScrollRect;
				}
				set
				{
					this.m_owner.m_sociatyListScrollRect = value;
				}
			}

			// Token: 0x17002EA2 RID: 11938
			// (get) Token: 0x0600F3C0 RID: 62400 RVA: 0x0040CC18 File Offset: 0x0040AE18
			// (set) Token: 0x0600F3C1 RID: 62401 RVA: 0x0040CC28 File Offset: 0x0040AE28
			public GameObject m_sociatyListScrollContent
			{
				get
				{
					return this.m_owner.m_sociatyListScrollContent;
				}
				set
				{
					this.m_owner.m_sociatyListScrollContent = value;
				}
			}

			// Token: 0x17002EA3 RID: 11939
			// (get) Token: 0x0600F3C2 RID: 62402 RVA: 0x0040CC38 File Offset: 0x0040AE38
			// (set) Token: 0x0600F3C3 RID: 62403 RVA: 0x0040CC48 File Offset: 0x0040AE48
			public Button m_sociatyListPowerButton
			{
				get
				{
					return this.m_owner.m_sociatyListPowerButton;
				}
				set
				{
					this.m_owner.m_sociatyListPowerButton = value;
				}
			}

			// Token: 0x17002EA4 RID: 11940
			// (get) Token: 0x0600F3C4 RID: 62404 RVA: 0x0040CC58 File Offset: 0x0040AE58
			// (set) Token: 0x0600F3C5 RID: 62405 RVA: 0x0040CC68 File Offset: 0x0040AE68
			public CommonUIStateController m_sociatyListPowerButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_sociatyListPowerButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_sociatyListPowerButtonStateCtrl = value;
				}
			}

			// Token: 0x17002EA5 RID: 11941
			// (get) Token: 0x0600F3C6 RID: 62406 RVA: 0x0040CC78 File Offset: 0x0040AE78
			// (set) Token: 0x0600F3C7 RID: 62407 RVA: 0x0040CC88 File Offset: 0x0040AE88
			public Button m_sociatyListActiveButton
			{
				get
				{
					return this.m_owner.m_sociatyListActiveButton;
				}
				set
				{
					this.m_owner.m_sociatyListActiveButton = value;
				}
			}

			// Token: 0x17002EA6 RID: 11942
			// (get) Token: 0x0600F3C8 RID: 62408 RVA: 0x0040CC98 File Offset: 0x0040AE98
			// (set) Token: 0x0600F3C9 RID: 62409 RVA: 0x0040CCA8 File Offset: 0x0040AEA8
			public CommonUIStateController m_sociatyListActiveButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_sociatyListActiveButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_sociatyListActiveButtonStateCtrl = value;
				}
			}

			// Token: 0x17002EA7 RID: 11943
			// (get) Token: 0x0600F3CA RID: 62410 RVA: 0x0040CCB8 File Offset: 0x0040AEB8
			// (set) Token: 0x0600F3CB RID: 62411 RVA: 0x0040CCC8 File Offset: 0x0040AEC8
			public Button m_sociatyListOnlineButton
			{
				get
				{
					return this.m_owner.m_sociatyListOnlineButton;
				}
				set
				{
					this.m_owner.m_sociatyListOnlineButton = value;
				}
			}

			// Token: 0x17002EA8 RID: 11944
			// (get) Token: 0x0600F3CC RID: 62412 RVA: 0x0040CCD8 File Offset: 0x0040AED8
			// (set) Token: 0x0600F3CD RID: 62413 RVA: 0x0040CCE8 File Offset: 0x0040AEE8
			public Text m_sociatyListOnlineValueText
			{
				get
				{
					return this.m_owner.m_sociatyListOnlineValueText;
				}
				set
				{
					this.m_owner.m_sociatyListOnlineValueText = value;
				}
			}

			// Token: 0x17002EA9 RID: 11945
			// (get) Token: 0x0600F3CE RID: 62414 RVA: 0x0040CCF8 File Offset: 0x0040AEF8
			// (set) Token: 0x0600F3CF RID: 62415 RVA: 0x0040CD08 File Offset: 0x0040AF08
			public GameObject m_playerInfoPrefabItem
			{
				get
				{
					return this.m_owner.m_playerInfoPrefabItem;
				}
				set
				{
					this.m_owner.m_playerInfoPrefabItem = value;
				}
			}

			// Token: 0x17002EAA RID: 11946
			// (get) Token: 0x0600F3D0 RID: 62416 RVA: 0x0040CD18 File Offset: 0x0040AF18
			// (set) Token: 0x0600F3D1 RID: 62417 RVA: 0x0040CD28 File Offset: 0x0040AF28
			public Text m_infoSociatyIDText
			{
				get
				{
					return this.m_owner.m_infoSociatyIDText;
				}
				set
				{
					this.m_owner.m_infoSociatyIDText = value;
				}
			}

			// Token: 0x17002EAB RID: 11947
			// (get) Token: 0x0600F3D2 RID: 62418 RVA: 0x0040CD38 File Offset: 0x0040AF38
			// (set) Token: 0x0600F3D3 RID: 62419 RVA: 0x0040CD48 File Offset: 0x0040AF48
			public Text m_infoPeopleNumberText
			{
				get
				{
					return this.m_owner.m_infoPeopleNumberText;
				}
				set
				{
					this.m_owner.m_infoPeopleNumberText = value;
				}
			}

			// Token: 0x17002EAC RID: 11948
			// (get) Token: 0x0600F3D4 RID: 62420 RVA: 0x0040CD58 File Offset: 0x0040AF58
			// (set) Token: 0x0600F3D5 RID: 62421 RVA: 0x0040CD68 File Offset: 0x0040AF68
			public Text m_infoPowerText
			{
				get
				{
					return this.m_owner.m_infoPowerText;
				}
				set
				{
					this.m_owner.m_infoPowerText = value;
				}
			}

			// Token: 0x17002EAD RID: 11949
			// (get) Token: 0x0600F3D6 RID: 62422 RVA: 0x0040CD78 File Offset: 0x0040AF78
			// (set) Token: 0x0600F3D7 RID: 62423 RVA: 0x0040CD88 File Offset: 0x0040AF88
			public Text m_infoActiveText
			{
				get
				{
					return this.m_owner.m_infoActiveText;
				}
				set
				{
					this.m_owner.m_infoActiveText = value;
				}
			}

			// Token: 0x17002EAE RID: 11950
			// (get) Token: 0x0600F3D8 RID: 62424 RVA: 0x0040CD98 File Offset: 0x0040AF98
			// (set) Token: 0x0600F3D9 RID: 62425 RVA: 0x0040CDA8 File Offset: 0x0040AFA8
			public Text m_infoCoinText
			{
				get
				{
					return this.m_owner.m_infoCoinText;
				}
				set
				{
					this.m_owner.m_infoCoinText = value;
				}
			}

			// Token: 0x17002EAF RID: 11951
			// (get) Token: 0x0600F3DA RID: 62426 RVA: 0x0040CDB8 File Offset: 0x0040AFB8
			// (set) Token: 0x0600F3DB RID: 62427 RVA: 0x0040CDC8 File Offset: 0x0040AFC8
			public Text m_infoDeclarationText
			{
				get
				{
					return this.m_owner.m_infoDeclarationText;
				}
				set
				{
					this.m_owner.m_infoDeclarationText = value;
				}
			}

			// Token: 0x17002EB0 RID: 11952
			// (get) Token: 0x0600F3DC RID: 62428 RVA: 0x0040CDD8 File Offset: 0x0040AFD8
			// (set) Token: 0x0600F3DD RID: 62429 RVA: 0x0040CDE8 File Offset: 0x0040AFE8
			public Button m_infoDeclarationButton
			{
				get
				{
					return this.m_owner.m_infoDeclarationButton;
				}
				set
				{
					this.m_owner.m_infoDeclarationButton = value;
				}
			}

			// Token: 0x17002EB1 RID: 11953
			// (get) Token: 0x0600F3DE RID: 62430 RVA: 0x0040CDF8 File Offset: 0x0040AFF8
			// (set) Token: 0x0600F3DF RID: 62431 RVA: 0x0040CE08 File Offset: 0x0040B008
			public Button m_messageButton
			{
				get
				{
					return this.m_owner.m_messageButton;
				}
				set
				{
					this.m_owner.m_messageButton = value;
				}
			}

			// Token: 0x17002EB2 RID: 11954
			// (get) Token: 0x0600F3E0 RID: 62432 RVA: 0x0040CE18 File Offset: 0x0040B018
			// (set) Token: 0x0600F3E1 RID: 62433 RVA: 0x0040CE28 File Offset: 0x0040B028
			public GameObject m_messageButtonRedPoint
			{
				get
				{
					return this.m_owner.m_messageButtonRedPoint;
				}
				set
				{
					this.m_owner.m_messageButtonRedPoint = value;
				}
			}

			// Token: 0x17002EB3 RID: 11955
			// (get) Token: 0x0600F3E2 RID: 62434 RVA: 0x0040CE38 File Offset: 0x0040B038
			// (set) Token: 0x0600F3E3 RID: 62435 RVA: 0x0040CE48 File Offset: 0x0040B048
			public Button m_quitButton
			{
				get
				{
					return this.m_owner.m_quitButton;
				}
				set
				{
					this.m_owner.m_quitButton = value;
				}
			}

			// Token: 0x17002EB4 RID: 11956
			// (get) Token: 0x0600F3E4 RID: 62436 RVA: 0x0040CE58 File Offset: 0x0040B058
			// (set) Token: 0x0600F3E5 RID: 62437 RVA: 0x0040CE68 File Offset: 0x0040B068
			public Button m_inviteButton
			{
				get
				{
					return this.m_owner.m_inviteButton;
				}
				set
				{
					this.m_owner.m_inviteButton = value;
				}
			}

			// Token: 0x17002EB5 RID: 11957
			// (get) Token: 0x0600F3E6 RID: 62438 RVA: 0x0040CE78 File Offset: 0x0040B078
			// (set) Token: 0x0600F3E7 RID: 62439 RVA: 0x0040CE88 File Offset: 0x0040B088
			public Button m_wealButton
			{
				get
				{
					return this.m_owner.m_wealButton;
				}
				set
				{
					this.m_owner.m_wealButton = value;
				}
			}

			// Token: 0x17002EB6 RID: 11958
			// (get) Token: 0x0600F3E8 RID: 62440 RVA: 0x0040CE98 File Offset: 0x0040B098
			// (set) Token: 0x0600F3E9 RID: 62441 RVA: 0x0040CEA8 File Offset: 0x0040B0A8
			public Button m_shopButton
			{
				get
				{
					return this.m_owner.m_shopButton;
				}
				set
				{
					this.m_owner.m_shopButton = value;
				}
			}

			// Token: 0x17002EB7 RID: 11959
			// (get) Token: 0x0600F3EA RID: 62442 RVA: 0x0040CEB8 File Offset: 0x0040B0B8
			// (set) Token: 0x0600F3EB RID: 62443 RVA: 0x0040CEC8 File Offset: 0x0040B0C8
			public Button m_sociatyPlayButton
			{
				get
				{
					return this.m_owner.m_sociatyPlayButton;
				}
				set
				{
					this.m_owner.m_sociatyPlayButton = value;
				}
			}

			// Token: 0x17002EB8 RID: 11960
			// (get) Token: 0x0600F3EC RID: 62444 RVA: 0x0040CED8 File Offset: 0x0040B0D8
			// (set) Token: 0x0600F3ED RID: 62445 RVA: 0x0040CEE8 File Offset: 0x0040B0E8
			public CommonUIStateController m_declarationChangePanelStateCtrl
			{
				get
				{
					return this.m_owner.m_declarationChangePanelStateCtrl;
				}
				set
				{
					this.m_owner.m_declarationChangePanelStateCtrl = value;
				}
			}

			// Token: 0x17002EB9 RID: 11961
			// (get) Token: 0x0600F3EE RID: 62446 RVA: 0x0040CEF8 File Offset: 0x0040B0F8
			// (set) Token: 0x0600F3EF RID: 62447 RVA: 0x0040CF08 File Offset: 0x0040B108
			public Button m_declarationChangePanelBackButton
			{
				get
				{
					return this.m_owner.m_declarationChangePanelBackButton;
				}
				set
				{
					this.m_owner.m_declarationChangePanelBackButton = value;
				}
			}

			// Token: 0x17002EBA RID: 11962
			// (get) Token: 0x0600F3F0 RID: 62448 RVA: 0x0040CF18 File Offset: 0x0040B118
			// (set) Token: 0x0600F3F1 RID: 62449 RVA: 0x0040CF28 File Offset: 0x0040B128
			public Button m_declarationChangePanelCloseButton
			{
				get
				{
					return this.m_owner.m_declarationChangePanelCloseButton;
				}
				set
				{
					this.m_owner.m_declarationChangePanelCloseButton = value;
				}
			}

			// Token: 0x17002EBB RID: 11963
			// (get) Token: 0x0600F3F2 RID: 62450 RVA: 0x0040CF38 File Offset: 0x0040B138
			// (set) Token: 0x0600F3F3 RID: 62451 RVA: 0x0040CF48 File Offset: 0x0040B148
			public Button m_declarationChangePanelSaveButton
			{
				get
				{
					return this.m_owner.m_declarationChangePanelSaveButton;
				}
				set
				{
					this.m_owner.m_declarationChangePanelSaveButton = value;
				}
			}

			// Token: 0x17002EBC RID: 11964
			// (get) Token: 0x0600F3F4 RID: 62452 RVA: 0x0040CF58 File Offset: 0x0040B158
			// (set) Token: 0x0600F3F5 RID: 62453 RVA: 0x0040CF68 File Offset: 0x0040B168
			public InputField m_declarationChangePanelInputField
			{
				get
				{
					return this.m_owner.m_declarationChangePanelInputField;
				}
				set
				{
					this.m_owner.m_declarationChangePanelInputField = value;
				}
			}

			// Token: 0x17002EBD RID: 11965
			// (get) Token: 0x0600F3F6 RID: 62454 RVA: 0x0040CF78 File Offset: 0x0040B178
			// (set) Token: 0x0600F3F7 RID: 62455 RVA: 0x0040CF88 File Offset: 0x0040B188
			public CommonUIStateController m_recruitPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_recruitPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_recruitPanelStateCtrl = value;
				}
			}

			// Token: 0x17002EBE RID: 11966
			// (get) Token: 0x0600F3F8 RID: 62456 RVA: 0x0040CF98 File Offset: 0x0040B198
			// (set) Token: 0x0600F3F9 RID: 62457 RVA: 0x0040CFA8 File Offset: 0x0040B1A8
			public Button m_recruitPanelBackButton
			{
				get
				{
					return this.m_owner.m_recruitPanelBackButton;
				}
				set
				{
					this.m_owner.m_recruitPanelBackButton = value;
				}
			}

			// Token: 0x17002EBF RID: 11967
			// (get) Token: 0x0600F3FA RID: 62458 RVA: 0x0040CFB8 File Offset: 0x0040B1B8
			// (set) Token: 0x0600F3FB RID: 62459 RVA: 0x0040CFC8 File Offset: 0x0040B1C8
			public Button m_recruitPanelCloseButton
			{
				get
				{
					return this.m_owner.m_recruitPanelCloseButton;
				}
				set
				{
					this.m_owner.m_recruitPanelCloseButton = value;
				}
			}

			// Token: 0x17002EC0 RID: 11968
			// (get) Token: 0x0600F3FC RID: 62460 RVA: 0x0040CFD8 File Offset: 0x0040B1D8
			// (set) Token: 0x0600F3FD RID: 62461 RVA: 0x0040CFE8 File Offset: 0x0040B1E8
			public Button m_recruitPanelSaveButton
			{
				get
				{
					return this.m_owner.m_recruitPanelSaveButton;
				}
				set
				{
					this.m_owner.m_recruitPanelSaveButton = value;
				}
			}

			// Token: 0x17002EC1 RID: 11969
			// (get) Token: 0x0600F3FE RID: 62462 RVA: 0x0040CFF8 File Offset: 0x0040B1F8
			// (set) Token: 0x0600F3FF RID: 62463 RVA: 0x0040D008 File Offset: 0x0040B208
			public InputField m_recruitPanelInputField
			{
				get
				{
					return this.m_owner.m_recruitPanelInputField;
				}
				set
				{
					this.m_owner.m_recruitPanelInputField = value;
				}
			}

			// Token: 0x17002EC2 RID: 11970
			// (get) Token: 0x0600F400 RID: 62464 RVA: 0x0040D018 File Offset: 0x0040B218
			// (set) Token: 0x0600F401 RID: 62465 RVA: 0x0040D028 File Offset: 0x0040B228
			public Button m_invitePanelSetButton
			{
				get
				{
					return this.m_owner.m_invitePanelSetButton;
				}
				set
				{
					this.m_owner.m_invitePanelSetButton = value;
				}
			}

			// Token: 0x17002EC3 RID: 11971
			// (get) Token: 0x0600F402 RID: 62466 RVA: 0x0040D038 File Offset: 0x0040B238
			// (set) Token: 0x0600F403 RID: 62467 RVA: 0x0040D048 File Offset: 0x0040B248
			public CommonUIStateController m_guildSetPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_guildSetPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_guildSetPanelStateCtrl = value;
				}
			}

			// Token: 0x17002EC4 RID: 11972
			// (get) Token: 0x0600F404 RID: 62468 RVA: 0x0040D058 File Offset: 0x0040B258
			// (set) Token: 0x0600F405 RID: 62469 RVA: 0x0040D068 File Offset: 0x0040B268
			public Button m_guildSetPanelBackButton
			{
				get
				{
					return this.m_owner.m_guildSetPanelBackButton;
				}
				set
				{
					this.m_owner.m_guildSetPanelBackButton = value;
				}
			}

			// Token: 0x17002EC5 RID: 11973
			// (get) Token: 0x0600F406 RID: 62470 RVA: 0x0040D078 File Offset: 0x0040B278
			// (set) Token: 0x0600F407 RID: 62471 RVA: 0x0040D088 File Offset: 0x0040B288
			public Button m_guildSetPanelCloseButton
			{
				get
				{
					return this.m_owner.m_guildSetPanelCloseButton;
				}
				set
				{
					this.m_owner.m_guildSetPanelCloseButton = value;
				}
			}

			// Token: 0x17002EC6 RID: 11974
			// (get) Token: 0x0600F408 RID: 62472 RVA: 0x0040D098 File Offset: 0x0040B298
			// (set) Token: 0x0600F409 RID: 62473 RVA: 0x0040D0A8 File Offset: 0x0040B2A8
			public Button m_guildSetPanelSaveButton
			{
				get
				{
					return this.m_owner.m_guildSetPanelSaveButton;
				}
				set
				{
					this.m_owner.m_guildSetPanelSaveButton = value;
				}
			}

			// Token: 0x17002EC7 RID: 11975
			// (get) Token: 0x0600F40A RID: 62474 RVA: 0x0040D0B8 File Offset: 0x0040B2B8
			// (set) Token: 0x0600F40B RID: 62475 RVA: 0x0040D0C8 File Offset: 0x0040B2C8
			public InputField m_guildSetPanelHireDeclarationInputField
			{
				get
				{
					return this.m_owner.m_guildSetPanelHireDeclarationInputField;
				}
				set
				{
					this.m_owner.m_guildSetPanelHireDeclarationInputField = value;
				}
			}

			// Token: 0x17002EC8 RID: 11976
			// (get) Token: 0x0600F40C RID: 62476 RVA: 0x0040D0D8 File Offset: 0x0040B2D8
			// (set) Token: 0x0600F40D RID: 62477 RVA: 0x0040D0E8 File Offset: 0x0040B2E8
			public InputField m_guildSetPanelLevelInputField
			{
				get
				{
					return this.m_owner.m_guildSetPanelLevelInputField;
				}
				set
				{
					this.m_owner.m_guildSetPanelLevelInputField = value;
				}
			}

			// Token: 0x17002EC9 RID: 11977
			// (get) Token: 0x0600F40E RID: 62478 RVA: 0x0040D0F8 File Offset: 0x0040B2F8
			// (set) Token: 0x0600F40F RID: 62479 RVA: 0x0040D108 File Offset: 0x0040B308
			public Button m_guildSetPanelLevelInputFieldLeftButton
			{
				get
				{
					return this.m_owner.m_guildSetPanelLevelInputFieldLeftButton;
				}
				set
				{
					this.m_owner.m_guildSetPanelLevelInputFieldLeftButton = value;
				}
			}

			// Token: 0x17002ECA RID: 11978
			// (get) Token: 0x0600F410 RID: 62480 RVA: 0x0040D118 File Offset: 0x0040B318
			// (set) Token: 0x0600F411 RID: 62481 RVA: 0x0040D128 File Offset: 0x0040B328
			public Button m_guildSetPanelLevelInputFieldRightButton
			{
				get
				{
					return this.m_owner.m_guildSetPanelLevelInputFieldRightButton;
				}
				set
				{
					this.m_owner.m_guildSetPanelLevelInputFieldRightButton = value;
				}
			}

			// Token: 0x17002ECB RID: 11979
			// (get) Token: 0x0600F412 RID: 62482 RVA: 0x0040D138 File Offset: 0x0040B338
			// (set) Token: 0x0600F413 RID: 62483 RVA: 0x0040D148 File Offset: 0x0040B348
			public Toggle m_guildSetPanelApproveGroupAutoToggle
			{
				get
				{
					return this.m_owner.m_guildSetPanelApproveGroupAutoToggle;
				}
				set
				{
					this.m_owner.m_guildSetPanelApproveGroupAutoToggle = value;
				}
			}

			// Token: 0x17002ECC RID: 11980
			// (get) Token: 0x0600F414 RID: 62484 RVA: 0x0040D158 File Offset: 0x0040B358
			// (set) Token: 0x0600F415 RID: 62485 RVA: 0x0040D168 File Offset: 0x0040B368
			public Toggle m_guildSetPanelApproveGroupChairmanToggle
			{
				get
				{
					return this.m_owner.m_guildSetPanelApproveGroupChairmanToggle;
				}
				set
				{
					this.m_owner.m_guildSetPanelApproveGroupChairmanToggle = value;
				}
			}

			// Token: 0x17002ECD RID: 11981
			// (get) Token: 0x0600F416 RID: 62486 RVA: 0x0040D178 File Offset: 0x0040B378
			// (set) Token: 0x0600F417 RID: 62487 RVA: 0x0040D188 File Offset: 0x0040B388
			public CommonUIStateController m_guildChangeNamePanelStateCtrl
			{
				get
				{
					return this.m_owner.m_guildChangeNamePanelStateCtrl;
				}
				set
				{
					this.m_owner.m_guildChangeNamePanelStateCtrl = value;
				}
			}

			// Token: 0x17002ECE RID: 11982
			// (get) Token: 0x0600F418 RID: 62488 RVA: 0x0040D198 File Offset: 0x0040B398
			// (set) Token: 0x0600F419 RID: 62489 RVA: 0x0040D1A8 File Offset: 0x0040B3A8
			public Button m_guildChangeNamePanelBackButton
			{
				get
				{
					return this.m_owner.m_guildChangeNamePanelBackButton;
				}
				set
				{
					this.m_owner.m_guildChangeNamePanelBackButton = value;
				}
			}

			// Token: 0x17002ECF RID: 11983
			// (get) Token: 0x0600F41A RID: 62490 RVA: 0x0040D1B8 File Offset: 0x0040B3B8
			// (set) Token: 0x0600F41B RID: 62491 RVA: 0x0040D1C8 File Offset: 0x0040B3C8
			public Button m_guildChangeNamePanelChangeNameButton
			{
				get
				{
					return this.m_owner.m_guildChangeNamePanelChangeNameButton;
				}
				set
				{
					this.m_owner.m_guildChangeNamePanelChangeNameButton = value;
				}
			}

			// Token: 0x17002ED0 RID: 11984
			// (get) Token: 0x0600F41C RID: 62492 RVA: 0x0040D1D8 File Offset: 0x0040B3D8
			// (set) Token: 0x0600F41D RID: 62493 RVA: 0x0040D1E8 File Offset: 0x0040B3E8
			public CommonUIStateController m_guildChangeNamePanelChangeNameButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_guildChangeNamePanelChangeNameButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_guildChangeNamePanelChangeNameButtonStateCtrl = value;
				}
			}

			// Token: 0x17002ED1 RID: 11985
			// (get) Token: 0x0600F41E RID: 62494 RVA: 0x0040D1F8 File Offset: 0x0040B3F8
			// (set) Token: 0x0600F41F RID: 62495 RVA: 0x0040D208 File Offset: 0x0040B408
			public InputField m_guildChangeNamePanelInputField
			{
				get
				{
					return this.m_owner.m_guildChangeNamePanelInputField;
				}
				set
				{
					this.m_owner.m_guildChangeNamePanelInputField = value;
				}
			}

			// Token: 0x17002ED2 RID: 11986
			// (get) Token: 0x0600F420 RID: 62496 RVA: 0x0040D218 File Offset: 0x0040B418
			// (set) Token: 0x0600F421 RID: 62497 RVA: 0x0040D228 File Offset: 0x0040B428
			public Text m_guildChangeNamePanelValueText
			{
				get
				{
					return this.m_owner.m_guildChangeNamePanelValueText;
				}
				set
				{
					this.m_owner.m_guildChangeNamePanelValueText = value;
				}
			}

			// Token: 0x17002ED3 RID: 11987
			// (get) Token: 0x0600F422 RID: 62498 RVA: 0x0040D238 File Offset: 0x0040B438
			// (set) Token: 0x0600F423 RID: 62499 RVA: 0x0040D248 File Offset: 0x0040B448
			public CommonUIStateController m_messagePanelStateCtrl
			{
				get
				{
					return this.m_owner.m_messagePanelStateCtrl;
				}
				set
				{
					this.m_owner.m_messagePanelStateCtrl = value;
				}
			}

			// Token: 0x17002ED4 RID: 11988
			// (get) Token: 0x0600F424 RID: 62500 RVA: 0x0040D258 File Offset: 0x0040B458
			// (set) Token: 0x0600F425 RID: 62501 RVA: 0x0040D268 File Offset: 0x0040B468
			public Button m_messagePanelBackButton
			{
				get
				{
					return this.m_owner.m_messagePanelBackButton;
				}
				set
				{
					this.m_owner.m_messagePanelBackButton = value;
				}
			}

			// Token: 0x17002ED5 RID: 11989
			// (get) Token: 0x0600F426 RID: 62502 RVA: 0x0040D278 File Offset: 0x0040B478
			// (set) Token: 0x0600F427 RID: 62503 RVA: 0x0040D288 File Offset: 0x0040B488
			public Toggle m_messagePanelApplyToggle
			{
				get
				{
					return this.m_owner.m_messagePanelApplyToggle;
				}
				set
				{
					this.m_owner.m_messagePanelApplyToggle = value;
				}
			}

			// Token: 0x17002ED6 RID: 11990
			// (get) Token: 0x0600F428 RID: 62504 RVA: 0x0040D298 File Offset: 0x0040B498
			// (set) Token: 0x0600F429 RID: 62505 RVA: 0x0040D2A8 File Offset: 0x0040B4A8
			public Toggle m_messagePanelJournalToggle
			{
				get
				{
					return this.m_owner.m_messagePanelJournalToggle;
				}
				set
				{
					this.m_owner.m_messagePanelJournalToggle = value;
				}
			}

			// Token: 0x17002ED7 RID: 11991
			// (get) Token: 0x0600F42A RID: 62506 RVA: 0x0040D2B8 File Offset: 0x0040B4B8
			// (set) Token: 0x0600F42B RID: 62507 RVA: 0x0040D2C8 File Offset: 0x0040B4C8
			public Button m_messageApplyPanelPowerButton
			{
				get
				{
					return this.m_owner.m_messageApplyPanelPowerButton;
				}
				set
				{
					this.m_owner.m_messageApplyPanelPowerButton = value;
				}
			}

			// Token: 0x17002ED8 RID: 11992
			// (get) Token: 0x0600F42C RID: 62508 RVA: 0x0040D2D8 File Offset: 0x0040B4D8
			// (set) Token: 0x0600F42D RID: 62509 RVA: 0x0040D2E8 File Offset: 0x0040B4E8
			public CommonUIStateController m_messageApplyPanelPowerButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_messageApplyPanelPowerButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_messageApplyPanelPowerButtonStateCtrl = value;
				}
			}

			// Token: 0x17002ED9 RID: 11993
			// (get) Token: 0x0600F42E RID: 62510 RVA: 0x0040D2F8 File Offset: 0x0040B4F8
			// (set) Token: 0x0600F42F RID: 62511 RVA: 0x0040D308 File Offset: 0x0040B508
			public ScrollRect m_messageApplyPanelMessageListScrollRect
			{
				get
				{
					return this.m_owner.m_messageApplyPanelMessageListScrollRect;
				}
				set
				{
					this.m_owner.m_messageApplyPanelMessageListScrollRect = value;
				}
			}

			// Token: 0x17002EDA RID: 11994
			// (get) Token: 0x0600F430 RID: 62512 RVA: 0x0040D318 File Offset: 0x0040B518
			// (set) Token: 0x0600F431 RID: 62513 RVA: 0x0040D328 File Offset: 0x0040B528
			public GameObject m_messageApplyPanelMessageListScrollContent
			{
				get
				{
					return this.m_owner.m_messageApplyPanelMessageListScrollContent;
				}
				set
				{
					this.m_owner.m_messageApplyPanelMessageListScrollContent = value;
				}
			}

			// Token: 0x17002EDB RID: 11995
			// (get) Token: 0x0600F432 RID: 62514 RVA: 0x0040D338 File Offset: 0x0040B538
			// (set) Token: 0x0600F433 RID: 62515 RVA: 0x0040D348 File Offset: 0x0040B548
			public GameObject m_messagePlayerItemPrafeb
			{
				get
				{
					return this.m_owner.m_messagePlayerItemPrafeb;
				}
				set
				{
					this.m_owner.m_messagePlayerItemPrafeb = value;
				}
			}

			// Token: 0x17002EDC RID: 11996
			// (get) Token: 0x0600F434 RID: 62516 RVA: 0x0040D358 File Offset: 0x0040B558
			// (set) Token: 0x0600F435 RID: 62517 RVA: 0x0040D368 File Offset: 0x0040B568
			public Button m_messageApplyPanelAllRefuseButton
			{
				get
				{
					return this.m_owner.m_messageApplyPanelAllRefuseButton;
				}
				set
				{
					this.m_owner.m_messageApplyPanelAllRefuseButton = value;
				}
			}

			// Token: 0x17002EDD RID: 11997
			// (get) Token: 0x0600F436 RID: 62518 RVA: 0x0040D378 File Offset: 0x0040B578
			// (set) Token: 0x0600F437 RID: 62519 RVA: 0x0040D388 File Offset: 0x0040B588
			public Text m_messageApplyPanelApplyTotalCountValueText
			{
				get
				{
					return this.m_owner.m_messageApplyPanelApplyTotalCountValueText;
				}
				set
				{
					this.m_owner.m_messageApplyPanelApplyTotalCountValueText = value;
				}
			}

			// Token: 0x17002EDE RID: 11998
			// (get) Token: 0x0600F438 RID: 62520 RVA: 0x0040D398 File Offset: 0x0040B598
			// (set) Token: 0x0600F439 RID: 62521 RVA: 0x0040D3A8 File Offset: 0x0040B5A8
			public Text m_messageApplyPanelTotalPeopleNumberValueText
			{
				get
				{
					return this.m_owner.m_messageApplyPanelTotalPeopleNumberValueText;
				}
				set
				{
					this.m_owner.m_messageApplyPanelTotalPeopleNumberValueText = value;
				}
			}

			// Token: 0x17002EDF RID: 11999
			// (get) Token: 0x0600F43A RID: 62522 RVA: 0x0040D3B8 File Offset: 0x0040B5B8
			// (set) Token: 0x0600F43B RID: 62523 RVA: 0x0040D3C8 File Offset: 0x0040B5C8
			public ScrollRect m_messageJournalPanelListScrollRect
			{
				get
				{
					return this.m_owner.m_messageJournalPanelListScrollRect;
				}
				set
				{
					this.m_owner.m_messageJournalPanelListScrollRect = value;
				}
			}

			// Token: 0x17002EE0 RID: 12000
			// (get) Token: 0x0600F43C RID: 62524 RVA: 0x0040D3D8 File Offset: 0x0040B5D8
			// (set) Token: 0x0600F43D RID: 62525 RVA: 0x0040D3E8 File Offset: 0x0040B5E8
			public GameObject m_messageJournalPanelListScrollContent
			{
				get
				{
					return this.m_owner.m_messageJournalPanelListScrollContent;
				}
				set
				{
					this.m_owner.m_messageJournalPanelListScrollContent = value;
				}
			}

			// Token: 0x17002EE1 RID: 12001
			// (get) Token: 0x0600F43E RID: 62526 RVA: 0x0040D3F8 File Offset: 0x0040B5F8
			// (set) Token: 0x0600F43F RID: 62527 RVA: 0x0040D408 File Offset: 0x0040B608
			public GameObject m_messageNoItemGameObject
			{
				get
				{
					return this.m_owner.m_messageNoItemGameObject;
				}
				set
				{
					this.m_owner.m_messageNoItemGameObject = value;
				}
			}

			// Token: 0x17002EE2 RID: 12002
			// (get) Token: 0x0600F440 RID: 62528 RVA: 0x0040D418 File Offset: 0x0040B618
			// (set) Token: 0x0600F441 RID: 62529 RVA: 0x0040D428 File Offset: 0x0040B628
			public GameObject m_messageJournalItemPrafeb
			{
				get
				{
					return this.m_owner.m_messageJournalItemPrafeb;
				}
				set
				{
					this.m_owner.m_messageJournalItemPrafeb = value;
				}
			}

			// Token: 0x17002EE3 RID: 12003
			// (get) Token: 0x0600F442 RID: 62530 RVA: 0x0040D438 File Offset: 0x0040B638
			// (set) Token: 0x0600F443 RID: 62531 RVA: 0x0040D448 File Offset: 0x0040B648
			public CommonUIStateController m_invitePanelStateCtrl
			{
				get
				{
					return this.m_owner.m_invitePanelStateCtrl;
				}
				set
				{
					this.m_owner.m_invitePanelStateCtrl = value;
				}
			}

			// Token: 0x17002EE4 RID: 12004
			// (get) Token: 0x0600F444 RID: 62532 RVA: 0x0040D458 File Offset: 0x0040B658
			// (set) Token: 0x0600F445 RID: 62533 RVA: 0x0040D468 File Offset: 0x0040B668
			public Button m_invitePanelBackButton
			{
				get
				{
					return this.m_owner.m_invitePanelBackButton;
				}
				set
				{
					this.m_owner.m_invitePanelBackButton = value;
				}
			}

			// Token: 0x17002EE5 RID: 12005
			// (get) Token: 0x0600F446 RID: 62534 RVA: 0x0040D478 File Offset: 0x0040B678
			// (set) Token: 0x0600F447 RID: 62535 RVA: 0x0040D488 File Offset: 0x0040B688
			public Button m_invitePanelCloseButton
			{
				get
				{
					return this.m_owner.m_invitePanelCloseButton;
				}
				set
				{
					this.m_owner.m_invitePanelCloseButton = value;
				}
			}

			// Token: 0x17002EE6 RID: 12006
			// (get) Token: 0x0600F448 RID: 62536 RVA: 0x0040D498 File Offset: 0x0040B698
			// (set) Token: 0x0600F449 RID: 62537 RVA: 0x0040D4A8 File Offset: 0x0040B6A8
			public Button m_invitePanelChangeListButton
			{
				get
				{
					return this.m_owner.m_invitePanelChangeListButton;
				}
				set
				{
					this.m_owner.m_invitePanelChangeListButton = value;
				}
			}

			// Token: 0x17002EE7 RID: 12007
			// (get) Token: 0x0600F44A RID: 62538 RVA: 0x0040D4B8 File Offset: 0x0040B6B8
			// (set) Token: 0x0600F44B RID: 62539 RVA: 0x0040D4C8 File Offset: 0x0040B6C8
			public Text m_inviteInfoPanelPeopleNumberText
			{
				get
				{
					return this.m_owner.m_inviteInfoPanelPeopleNumberText;
				}
				set
				{
					this.m_owner.m_inviteInfoPanelPeopleNumberText = value;
				}
			}

			// Token: 0x17002EE8 RID: 12008
			// (get) Token: 0x0600F44C RID: 62540 RVA: 0x0040D4D8 File Offset: 0x0040B6D8
			// (set) Token: 0x0600F44D RID: 62541 RVA: 0x0040D4E8 File Offset: 0x0040B6E8
			public Text m_inviteInfoPanelActiveText
			{
				get
				{
					return this.m_owner.m_inviteInfoPanelActiveText;
				}
				set
				{
					this.m_owner.m_inviteInfoPanelActiveText = value;
				}
			}

			// Token: 0x17002EE9 RID: 12009
			// (get) Token: 0x0600F44E RID: 62542 RVA: 0x0040D4F8 File Offset: 0x0040B6F8
			// (set) Token: 0x0600F44F RID: 62543 RVA: 0x0040D508 File Offset: 0x0040B708
			public Text m_inviteInfoPanelLevelText
			{
				get
				{
					return this.m_owner.m_inviteInfoPanelLevelText;
				}
				set
				{
					this.m_owner.m_inviteInfoPanelLevelText = value;
				}
			}

			// Token: 0x17002EEA RID: 12010
			// (get) Token: 0x0600F450 RID: 62544 RVA: 0x0040D518 File Offset: 0x0040B718
			// (set) Token: 0x0600F451 RID: 62545 RVA: 0x0040D528 File Offset: 0x0040B728
			public Text m_inviteInfoPanelDeclarationText
			{
				get
				{
					return this.m_owner.m_inviteInfoPanelDeclarationText;
				}
				set
				{
					this.m_owner.m_inviteInfoPanelDeclarationText = value;
				}
			}

			// Token: 0x17002EEB RID: 12011
			// (get) Token: 0x0600F452 RID: 62546 RVA: 0x0040D538 File Offset: 0x0040B738
			// (set) Token: 0x0600F453 RID: 62547 RVA: 0x0040D548 File Offset: 0x0040B748
			public Button m_inviteInfoPanelDeclarationChangeButton
			{
				get
				{
					return this.m_owner.m_inviteInfoPanelDeclarationChangeButton;
				}
				set
				{
					this.m_owner.m_inviteInfoPanelDeclarationChangeButton = value;
				}
			}

			// Token: 0x17002EEC RID: 12012
			// (get) Token: 0x0600F454 RID: 62548 RVA: 0x0040D558 File Offset: 0x0040B758
			// (set) Token: 0x0600F455 RID: 62549 RVA: 0x0040D568 File Offset: 0x0040B768
			public ScrollRect m_inviteListPanelSociatyListScrollRect
			{
				get
				{
					return this.m_owner.m_inviteListPanelSociatyListScrollRect;
				}
				set
				{
					this.m_owner.m_inviteListPanelSociatyListScrollRect = value;
				}
			}

			// Token: 0x17002EED RID: 12013
			// (get) Token: 0x0600F456 RID: 62550 RVA: 0x0040D578 File Offset: 0x0040B778
			// (set) Token: 0x0600F457 RID: 62551 RVA: 0x0040D588 File Offset: 0x0040B788
			public GameObject m_inviteListPanelSociatyListScrollContent
			{
				get
				{
					return this.m_owner.m_inviteListPanelSociatyListScrollContent;
				}
				set
				{
					this.m_owner.m_inviteListPanelSociatyListScrollContent = value;
				}
			}

			// Token: 0x17002EEE RID: 12014
			// (get) Token: 0x0600F458 RID: 62552 RVA: 0x0040D598 File Offset: 0x0040B798
			// (set) Token: 0x0600F459 RID: 62553 RVA: 0x0040D5A8 File Offset: 0x0040B7A8
			public Button m_inviteListPanelPowerButton
			{
				get
				{
					return this.m_owner.m_inviteListPanelPowerButton;
				}
				set
				{
					this.m_owner.m_inviteListPanelPowerButton = value;
				}
			}

			// Token: 0x17002EEF RID: 12015
			// (get) Token: 0x0600F45A RID: 62554 RVA: 0x0040D5B8 File Offset: 0x0040B7B8
			// (set) Token: 0x0600F45B RID: 62555 RVA: 0x0040D5C8 File Offset: 0x0040B7C8
			public CommonUIStateController m_inviteListPanelPowerButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_inviteListPanelPowerButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_inviteListPanelPowerButtonStateCtrl = value;
				}
			}

			// Token: 0x17002EF0 RID: 12016
			// (get) Token: 0x0600F45C RID: 62556 RVA: 0x0040D5D8 File Offset: 0x0040B7D8
			// (set) Token: 0x0600F45D RID: 62557 RVA: 0x0040D5E8 File Offset: 0x0040B7E8
			public GameObject m_invitePlayerInfoItemPrefab
			{
				get
				{
					return this.m_owner.m_invitePlayerInfoItemPrefab;
				}
				set
				{
					this.m_owner.m_invitePlayerInfoItemPrefab = value;
				}
			}

			// Token: 0x17002EF1 RID: 12017
			// (get) Token: 0x0600F45E RID: 62558 RVA: 0x0040D5F8 File Offset: 0x0040B7F8
			// (set) Token: 0x0600F45F RID: 62559 RVA: 0x0040D608 File Offset: 0x0040B808
			public CommonUIStateController m_quitDialogStateCtrl
			{
				get
				{
					return this.m_owner.m_quitDialogStateCtrl;
				}
				set
				{
					this.m_owner.m_quitDialogStateCtrl = value;
				}
			}

			// Token: 0x17002EF2 RID: 12018
			// (get) Token: 0x0600F460 RID: 62560 RVA: 0x0040D618 File Offset: 0x0040B818
			// (set) Token: 0x0600F461 RID: 62561 RVA: 0x0040D628 File Offset: 0x0040B828
			public Text m_quitDialogTitleText
			{
				get
				{
					return this.m_owner.m_quitDialogTitleText;
				}
				set
				{
					this.m_owner.m_quitDialogTitleText = value;
				}
			}

			// Token: 0x17002EF3 RID: 12019
			// (get) Token: 0x0600F462 RID: 62562 RVA: 0x0040D638 File Offset: 0x0040B838
			// (set) Token: 0x0600F463 RID: 62563 RVA: 0x0040D648 File Offset: 0x0040B848
			public Text m_quitDialogTipText
			{
				get
				{
					return this.m_owner.m_quitDialogTipText;
				}
				set
				{
					this.m_owner.m_quitDialogTipText = value;
				}
			}

			// Token: 0x17002EF4 RID: 12020
			// (get) Token: 0x0600F464 RID: 62564 RVA: 0x0040D658 File Offset: 0x0040B858
			// (set) Token: 0x0600F465 RID: 62565 RVA: 0x0040D668 File Offset: 0x0040B868
			public Button m_quitDialogConfirmButton
			{
				get
				{
					return this.m_owner.m_quitDialogConfirmButton;
				}
				set
				{
					this.m_owner.m_quitDialogConfirmButton = value;
				}
			}

			// Token: 0x17002EF5 RID: 12021
			// (get) Token: 0x0600F466 RID: 62566 RVA: 0x0040D678 File Offset: 0x0040B878
			// (set) Token: 0x0600F467 RID: 62567 RVA: 0x0040D688 File Offset: 0x0040B888
			public Button m_quitDialogCancelButton
			{
				get
				{
					return this.m_owner.m_quitDialogCancelButton;
				}
				set
				{
					this.m_owner.m_quitDialogCancelButton = value;
				}
			}

			// Token: 0x17002EF6 RID: 12022
			// (get) Token: 0x0600F468 RID: 62568 RVA: 0x0040D698 File Offset: 0x0040B898
			// (set) Token: 0x0600F469 RID: 62569 RVA: 0x0040D6A8 File Offset: 0x0040B8A8
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

			// Token: 0x17002EF7 RID: 12023
			// (get) Token: 0x0600F46A RID: 62570 RVA: 0x0040D6B8 File Offset: 0x0040B8B8
			// (set) Token: 0x0600F46B RID: 62571 RVA: 0x0040D6C8 File Offset: 0x0040B8C8
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

			// Token: 0x17002EF8 RID: 12024
			// (get) Token: 0x0600F46C RID: 62572 RVA: 0x0040D6D8 File Offset: 0x0040B8D8
			public static string StateName_Up
			{
				get
				{
					return "Up";
				}
			}

			// Token: 0x17002EF9 RID: 12025
			// (get) Token: 0x0600F46D RID: 62573 RVA: 0x0040D6E0 File Offset: 0x0040B8E0
			public static string StateName_Down
			{
				get
				{
					return "Down";
				}
			}

			// Token: 0x17002EFA RID: 12026
			// (get) Token: 0x0600F46E RID: 62574 RVA: 0x0040D6E8 File Offset: 0x0040B8E8
			public static string StateName_Hide
			{
				get
				{
					return "Hide";
				}
			}

			// Token: 0x17002EFB RID: 12027
			// (get) Token: 0x0600F46F RID: 62575 RVA: 0x0040D6F0 File Offset: 0x0040B8F0
			// (set) Token: 0x0600F470 RID: 62576 RVA: 0x0040D700 File Offset: 0x0040B900
			public bool m_isManageListPowerAscend
			{
				get
				{
					return this.m_owner.m_isManageListPowerAscend;
				}
				set
				{
					this.m_owner.m_isManageListPowerAscend = value;
				}
			}

			// Token: 0x17002EFC RID: 12028
			// (get) Token: 0x0600F471 RID: 62577 RVA: 0x0040D710 File Offset: 0x0040B910
			// (set) Token: 0x0600F472 RID: 62578 RVA: 0x0040D720 File Offset: 0x0040B920
			public bool m_isManageListActiveAscend
			{
				get
				{
					return this.m_owner.m_isManageListActiveAscend;
				}
				set
				{
					this.m_owner.m_isManageListActiveAscend = value;
				}
			}

			// Token: 0x17002EFD RID: 12029
			// (get) Token: 0x0600F473 RID: 62579 RVA: 0x0040D730 File Offset: 0x0040B930
			// (set) Token: 0x0600F474 RID: 62580 RVA: 0x0040D740 File Offset: 0x0040B940
			public bool m_isMessageApplyListPowerAscend
			{
				get
				{
					return this.m_owner.m_isMessageApplyListPowerAscend;
				}
				set
				{
					this.m_owner.m_isMessageApplyListPowerAscend = value;
				}
			}

			// Token: 0x17002EFE RID: 12030
			// (get) Token: 0x0600F475 RID: 62581 RVA: 0x0040D750 File Offset: 0x0040B950
			// (set) Token: 0x0600F476 RID: 62582 RVA: 0x0040D760 File Offset: 0x0040B960
			public bool m_isInviteListPanelPowerAscend
			{
				get
				{
					return this.m_owner.m_isInviteListPanelPowerAscend;
				}
				set
				{
					this.m_owner.m_isInviteListPanelPowerAscend = value;
				}
			}

			// Token: 0x17002EFF RID: 12031
			// (get) Token: 0x0600F477 RID: 62583 RVA: 0x0040D770 File Offset: 0x0040B970
			// (set) Token: 0x0600F478 RID: 62584 RVA: 0x0040D780 File Offset: 0x0040B980
			public bool m_isMessageApplyPanelSortByPower
			{
				get
				{
					return this.m_owner.m_isMessageApplyPanelSortByPower;
				}
				set
				{
					this.m_owner.m_isMessageApplyPanelSortByPower = value;
				}
			}

			// Token: 0x17002F00 RID: 12032
			// (get) Token: 0x0600F479 RID: 62585 RVA: 0x0040D790 File Offset: 0x0040B990
			// (set) Token: 0x0600F47A RID: 62586 RVA: 0x0040D7A0 File Offset: 0x0040B9A0
			public List<GuildMemberInfoItemUIController> m_playerInfoCtrlList
			{
				get
				{
					return this.m_owner.m_playerInfoCtrlList;
				}
				set
				{
					this.m_owner.m_playerInfoCtrlList = value;
				}
			}

			// Token: 0x17002F01 RID: 12033
			// (get) Token: 0x0600F47B RID: 62587 RVA: 0x0040D7B0 File Offset: 0x0040B9B0
			// (set) Token: 0x0600F47C RID: 62588 RVA: 0x0040D7C0 File Offset: 0x0040B9C0
			public List<GuildApplyMemberInfoItemUIController> m_applyPlayerInfoCtrlList
			{
				get
				{
					return this.m_owner.m_applyPlayerInfoCtrlList;
				}
				set
				{
					this.m_owner.m_applyPlayerInfoCtrlList = value;
				}
			}

			// Token: 0x17002F02 RID: 12034
			// (get) Token: 0x0600F47D RID: 62589 RVA: 0x0040D7D0 File Offset: 0x0040B9D0
			// (set) Token: 0x0600F47E RID: 62590 RVA: 0x0040D7E0 File Offset: 0x0040B9E0
			public List<GuildJournalItemUIController> m_guildJournalItemCtrlList
			{
				get
				{
					return this.m_owner.m_guildJournalItemCtrlList;
				}
				set
				{
					this.m_owner.m_guildJournalItemCtrlList = value;
				}
			}

			// Token: 0x17002F03 RID: 12035
			// (get) Token: 0x0600F47F RID: 62591 RVA: 0x0040D7F0 File Offset: 0x0040B9F0
			// (set) Token: 0x0600F480 RID: 62592 RVA: 0x0040D800 File Offset: 0x0040BA00
			public List<GuildInviteMemberInfoItemUIController> m_inviteMemberInfoCtrlList
			{
				get
				{
					return this.m_owner.m_inviteMemberInfoCtrlList;
				}
				set
				{
					this.m_owner.m_inviteMemberInfoCtrlList = value;
				}
			}

			// Token: 0x17002F04 RID: 12036
			// (get) Token: 0x0600F481 RID: 62593 RVA: 0x0040D810 File Offset: 0x0040BA10
			// (set) Token: 0x0600F482 RID: 62594 RVA: 0x0040D820 File Offset: 0x0040BA20
			public Guild m_guild
			{
				get
				{
					return this.m_owner.m_guild;
				}
				set
				{
					this.m_owner.m_guild = value;
				}
			}

			// Token: 0x17002F05 RID: 12037
			// (get) Token: 0x0600F483 RID: 62595 RVA: 0x0040D830 File Offset: 0x0040BA30
			// (set) Token: 0x0600F484 RID: 62596 RVA: 0x0040D840 File Offset: 0x0040BA40
			public GuildTitle m_guildTitle
			{
				get
				{
					return this.m_owner.m_guildTitle;
				}
				set
				{
					this.m_owner.m_guildTitle = value;
				}
			}

			// Token: 0x17002F06 RID: 12038
			// (get) Token: 0x0600F485 RID: 62597 RVA: 0x0040D850 File Offset: 0x0040BA50
			// (set) Token: 0x0600F486 RID: 62598 RVA: 0x0040D860 File Offset: 0x0040BA60
			public List<UserSummary> m_canInvitePlayerList
			{
				get
				{
					return this.m_owner.m_canInvitePlayerList;
				}
				set
				{
					this.m_owner.m_canInvitePlayerList = value;
				}
			}

			// Token: 0x17002F07 RID: 12039
			// (get) Token: 0x0600F487 RID: 62599 RVA: 0x0040D870 File Offset: 0x0040BA70
			// (set) Token: 0x0600F488 RID: 62600 RVA: 0x0040D880 File Offset: 0x0040BA80
			public bool m_isGuildAutoJoin
			{
				get
				{
					return this.m_owner.m_isGuildAutoJoin;
				}
				set
				{
					this.m_owner.m_isGuildAutoJoin = value;
				}
			}

			// Token: 0x17002F08 RID: 12040
			// (get) Token: 0x0600F489 RID: 62601 RVA: 0x0040D890 File Offset: 0x0040BA90
			// (set) Token: 0x0600F48A RID: 62602 RVA: 0x0040D8A0 File Offset: 0x0040BAA0
			public int m_guildJoinLevel
			{
				get
				{
					return this.m_owner.m_guildJoinLevel;
				}
				set
				{
					this.m_owner.m_guildJoinLevel = value;
				}
			}

			// Token: 0x17002F09 RID: 12041
			// (get) Token: 0x0600F48B RID: 62603 RVA: 0x0040D8B0 File Offset: 0x0040BAB0
			// (set) Token: 0x0600F48C RID: 62604 RVA: 0x0040D8C0 File Offset: 0x0040BAC0
			public List<UserSummary> m_messageApplyUserSummarys
			{
				get
				{
					return this.m_owner.m_messageApplyUserSummarys;
				}
				set
				{
					this.m_owner.m_messageApplyUserSummarys = value;
				}
			}

			// Token: 0x17002F0A RID: 12042
			// (get) Token: 0x0600F48D RID: 62605 RVA: 0x0040D8D0 File Offset: 0x0040BAD0
			// (set) Token: 0x0600F48E RID: 62606 RVA: 0x0040D8E0 File Offset: 0x0040BAE0
			public GuildManagementUIController.GuildListSortType m_guildListSortType
			{
				get
				{
					return this.m_owner.m_guildListSortType;
				}
				set
				{
					this.m_owner.m_guildListSortType = value;
				}
			}

			// Token: 0x0600F48F RID: 62607 RVA: 0x0040D8F0 File Offset: 0x0040BAF0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F490 RID: 62608 RVA: 0x0040D900 File Offset: 0x0040BB00
			public void RefreshGuildTitle()
			{
				this.m_owner.RefreshGuildTitle();
			}

			// Token: 0x0600F491 RID: 62609 RVA: 0x0040D910 File Offset: 0x0040BB10
			public void SetStateByGuildTitle()
			{
				this.m_owner.SetStateByGuildTitle();
			}

			// Token: 0x0600F492 RID: 62610 RVA: 0x0040D920 File Offset: 0x0040BB20
			public void SetSociatyInfoPanel()
			{
				this.m_owner.SetSociatyInfoPanel();
			}

			// Token: 0x0600F493 RID: 62611 RVA: 0x0040D930 File Offset: 0x0040BB30
			public void SetSociatyListPanel(List<GuildMemberCacheObject> memberList)
			{
				this.m_owner.SetSociatyListPanel(memberList);
			}

			// Token: 0x0600F494 RID: 62612 RVA: 0x0040D940 File Offset: 0x0040BB40
			public void OnGuildManagementListPlayeItemClick(GuildMemberInfoItemUIController ctrl)
			{
				this.m_owner.OnGuildManagementListPlayeItemClick(ctrl);
			}

			// Token: 0x0600F495 RID: 62613 RVA: 0x0040D950 File Offset: 0x0040BB50
			public void OnReturnImgButtonClick()
			{
				this.m_owner.OnReturnImgButtonClick();
			}

			// Token: 0x0600F496 RID: 62614 RVA: 0x0040D960 File Offset: 0x0040BB60
			public void OnInfoButtonClick()
			{
				this.m_owner.OnInfoButtonClick();
			}

			// Token: 0x0600F497 RID: 62615 RVA: 0x0040D970 File Offset: 0x0040BB70
			public void OnGuildCoinButtonClick()
			{
				this.m_owner.OnGuildCoinButtonClick();
			}

			// Token: 0x0600F498 RID: 62616 RVA: 0x0040D980 File Offset: 0x0040BB80
			public void ClearData()
			{
				this.m_owner.ClearData();
			}

			// Token: 0x0600F499 RID: 62617 RVA: 0x0040D990 File Offset: 0x0040BB90
			public void CloseAllSmallPanel()
			{
				this.m_owner.CloseAllSmallPanel();
			}

			// Token: 0x0600F49A RID: 62618 RVA: 0x0040D9A0 File Offset: 0x0040BBA0
			public void OnOnlineButtonClick()
			{
				this.m_owner.OnOnlineButtonClick();
			}

			// Token: 0x0600F49B RID: 62619 RVA: 0x0040D9B0 File Offset: 0x0040BBB0
			public void OnActiveButtonClick()
			{
				this.m_owner.OnActiveButtonClick();
			}

			// Token: 0x0600F49C RID: 62620 RVA: 0x0040D9C0 File Offset: 0x0040BBC0
			public void OnPowerButtonClick()
			{
				this.m_owner.OnPowerButtonClick();
			}

			// Token: 0x0600F49D RID: 62621 RVA: 0x0040D9D0 File Offset: 0x0040BBD0
			public void SetSortButtonState(GuildManagementUIController.GuildListSortType sortType)
			{
				this.m_owner.SetSortButtonState(sortType);
			}

			// Token: 0x0600F49E RID: 62622 RVA: 0x0040D9E0 File Offset: 0x0040BBE0
			public int SortByTitle(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				return this.m_owner.SortByTitle(a, b);
			}

			// Token: 0x0600F49F RID: 62623 RVA: 0x0040D9F0 File Offset: 0x0040BBF0
			public int SortByPower(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				return this.m_owner.SortByPower(a, b);
			}

			// Token: 0x0600F4A0 RID: 62624 RVA: 0x0040DA00 File Offset: 0x0040BC00
			public int SortByActive(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				return this.m_owner.SortByActive(a, b);
			}

			// Token: 0x0600F4A1 RID: 62625 RVA: 0x0040DA10 File Offset: 0x0040BC10
			public void SortGuildListByDefault(List<GuildMemberCacheObject> guildList)
			{
				this.m_owner.SortGuildListByDefault(guildList);
			}

			// Token: 0x0600F4A2 RID: 62626 RVA: 0x0040DA20 File Offset: 0x0040BC20
			public int SortByDefaultType(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				return this.m_owner.SortByDefaultType(a, b);
			}

			// Token: 0x0600F4A3 RID: 62627 RVA: 0x0040DA30 File Offset: 0x0040BC30
			public int SortByActiveType(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				return this.m_owner.SortByActiveType(a, b);
			}

			// Token: 0x0600F4A4 RID: 62628 RVA: 0x0040DA40 File Offset: 0x0040BC40
			public int SortByBattlePowerType(GuildMemberCacheObject a, GuildMemberCacheObject b)
			{
				return this.m_owner.SortByBattlePowerType(a, b);
			}

			// Token: 0x0600F4A5 RID: 62629 RVA: 0x0040DA50 File Offset: 0x0040BC50
			public void OnSociatyNameChangeButtonClick()
			{
				this.m_owner.OnSociatyNameChangeButtonClick();
			}

			// Token: 0x0600F4A6 RID: 62630 RVA: 0x0040DA60 File Offset: 0x0040BC60
			public void OnGuildChangeNamePanelChangeNameButtonClick()
			{
				this.m_owner.OnGuildChangeNamePanelChangeNameButtonClick();
			}

			// Token: 0x0600F4A7 RID: 62631 RVA: 0x0040DA70 File Offset: 0x0040BC70
			public void OnGuildChangeNamePanelBackButtonClick()
			{
				this.m_owner.OnGuildChangeNamePanelBackButtonClick();
			}

			// Token: 0x0600F4A8 RID: 62632 RVA: 0x0040DA80 File Offset: 0x0040BC80
			public void OnDeclarationButtonClick()
			{
				this.m_owner.OnDeclarationButtonClick();
			}

			// Token: 0x0600F4A9 RID: 62633 RVA: 0x0040DA90 File Offset: 0x0040BC90
			public void OnDeclarationChangePanelSaveButtonClick()
			{
				this.m_owner.OnDeclarationChangePanelSaveButtonClick();
			}

			// Token: 0x0600F4AA RID: 62634 RVA: 0x0040DAA0 File Offset: 0x0040BCA0
			public void OnDeclarationChangePanelBackButtonClick()
			{
				this.m_owner.OnDeclarationChangePanelBackButtonClick();
			}

			// Token: 0x0600F4AB RID: 62635 RVA: 0x0040DAB0 File Offset: 0x0040BCB0
			public void OnQuitButtonClick()
			{
				this.m_owner.OnQuitButtonClick();
			}

			// Token: 0x0600F4AC RID: 62636 RVA: 0x0040DAC0 File Offset: 0x0040BCC0
			public void OnQuitGuildConfirmButtonClick()
			{
				this.m_owner.OnQuitGuildConfirmButtonClick();
			}

			// Token: 0x0600F4AD RID: 62637 RVA: 0x0040DAD0 File Offset: 0x0040BCD0
			public void CloseQuitGuildConfirmPanel()
			{
				this.m_owner.CloseQuitGuildConfirmPanel();
			}

			// Token: 0x0600F4AE RID: 62638 RVA: 0x0040DAE0 File Offset: 0x0040BCE0
			public void OnSociatyPlayButtonClick()
			{
				this.m_owner.OnSociatyPlayButtonClick();
			}

			// Token: 0x0600F4AF RID: 62639 RVA: 0x0040DAF0 File Offset: 0x0040BCF0
			public void OnShopButtonClick()
			{
				this.m_owner.OnShopButtonClick();
			}

			// Token: 0x0600F4B0 RID: 62640 RVA: 0x0040DB00 File Offset: 0x0040BD00
			public void OnWealButtonClick()
			{
				this.m_owner.OnWealButtonClick();
			}

			// Token: 0x0600F4B1 RID: 62641 RVA: 0x0040DB10 File Offset: 0x0040BD10
			public void OnMessageButtonClick()
			{
				this.m_owner.OnMessageButtonClick();
			}

			// Token: 0x0600F4B2 RID: 62642 RVA: 0x0040DB20 File Offset: 0x0040BD20
			public void SendNtfBeforeOpenMessagePanel(bool isManager, Action onEnd)
			{
				this.m_owner.SendNtfBeforeOpenMessagePanel(isManager, onEnd);
			}

			// Token: 0x0600F4B3 RID: 62643 RVA: 0x0040DB30 File Offset: 0x0040BD30
			public void SetMessageApplyPanel(List<UserSummary> players)
			{
				this.m_owner.SetMessageApplyPanel(players);
			}

			// Token: 0x0600F4B4 RID: 62644 RVA: 0x0040DB40 File Offset: 0x0040BD40
			public void OnGuildApplyMemberAcceptResult(GuildApplyMemberInfoItemUIController ctrl, bool result)
			{
				this.m_owner.OnGuildApplyMemberAcceptResult(ctrl, result);
			}

			// Token: 0x0600F4B5 RID: 62645 RVA: 0x0040DB50 File Offset: 0x0040BD50
			public void SetMessageJournalPanel(List<GuildLog> journal)
			{
				this.m_owner.SetMessageJournalPanel(journal);
			}

			// Token: 0x0600F4B6 RID: 62646 RVA: 0x0040DB60 File Offset: 0x0040BD60
			public void OnMssageApplyPanelPowerButtonClick()
			{
				this.m_owner.OnMssageApplyPanelPowerButtonClick();
			}

			// Token: 0x0600F4B7 RID: 62647 RVA: 0x0040DB70 File Offset: 0x0040BD70
			public void OnMessagePanelBackButtonClick()
			{
				this.m_owner.OnMessagePanelBackButtonClick();
			}

			// Token: 0x0600F4B8 RID: 62648 RVA: 0x0040DB80 File Offset: 0x0040BD80
			public void CloseMessagePanel(Action onEnd)
			{
				this.m_owner.CloseMessagePanel(onEnd);
			}

			// Token: 0x0600F4B9 RID: 62649 RVA: 0x0040DB90 File Offset: 0x0040BD90
			public void OnMessagePanelApplyToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMessagePanelApplyToggleValueChanged(isOn);
			}

			// Token: 0x0600F4BA RID: 62650 RVA: 0x0040DBA0 File Offset: 0x0040BDA0
			public void OnMessagePanelJournalToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMessagePanelJournalToggleValueChanged(isOn);
			}

			// Token: 0x0600F4BB RID: 62651 RVA: 0x0040DBB0 File Offset: 0x0040BDB0
			public void OnMessageApplyPanelAllRefuseButtonClick()
			{
				this.m_owner.OnMessageApplyPanelAllRefuseButtonClick();
			}

			// Token: 0x0600F4BC RID: 62652 RVA: 0x0040DBC0 File Offset: 0x0040BDC0
			public void OnInviteButtonClick()
			{
				this.m_owner.OnInviteButtonClick();
			}

			// Token: 0x0600F4BD RID: 62653 RVA: 0x0040DBD0 File Offset: 0x0040BDD0
			public void SetInvitePanel(List<UserSummary> playerList)
			{
				this.m_owner.SetInvitePanel(playerList);
			}

			// Token: 0x0600F4BE RID: 62654 RVA: 0x0040DBE0 File Offset: 0x0040BDE0
			public void SetInviteInfoPanel()
			{
				this.m_owner.SetInviteInfoPanel();
			}

			// Token: 0x0600F4BF RID: 62655 RVA: 0x0040DBF0 File Offset: 0x0040BDF0
			public void SetInviteListPanel()
			{
				this.m_owner.SetInviteListPanel();
			}

			// Token: 0x0600F4C0 RID: 62656 RVA: 0x0040DC00 File Offset: 0x0040BE00
			public void OnInviteMemberInfoItemClick(GuildInviteMemberInfoItemUIController ctrl)
			{
				this.m_owner.OnInviteMemberInfoItemClick(ctrl);
			}

			// Token: 0x0600F4C1 RID: 62657 RVA: 0x0040DC10 File Offset: 0x0040BE10
			public void OnInviteListPanelPowerButtonClick()
			{
				this.m_owner.OnInviteListPanelPowerButtonClick();
			}

			// Token: 0x0600F4C2 RID: 62658 RVA: 0x0040DC20 File Offset: 0x0040BE20
			public void OnInvitePanelChangeListButtonClick()
			{
				this.m_owner.OnInvitePanelChangeListButtonClick();
			}

			// Token: 0x0600F4C3 RID: 62659 RVA: 0x0040DC30 File Offset: 0x0040BE30
			public void OnInvitePanelBackButton()
			{
				this.m_owner.OnInvitePanelBackButton();
			}

			// Token: 0x0600F4C4 RID: 62660 RVA: 0x0040DC40 File Offset: 0x0040BE40
			public void CloseInvitePanel(Action onEnd)
			{
				this.m_owner.CloseInvitePanel(onEnd);
			}

			// Token: 0x0600F4C5 RID: 62661 RVA: 0x0040DC50 File Offset: 0x0040BE50
			public void OnInviteInfoPanelDeclarationChangeButtonClick()
			{
				this.m_owner.OnInviteInfoPanelDeclarationChangeButtonClick();
			}

			// Token: 0x0600F4C6 RID: 62662 RVA: 0x0040DC60 File Offset: 0x0040BE60
			public void SetRecruitChangeSubPanelInfo()
			{
				this.m_owner.SetRecruitChangeSubPanelInfo();
			}

			// Token: 0x0600F4C7 RID: 62663 RVA: 0x0040DC70 File Offset: 0x0040BE70
			public void OnRecruitPanelSaveButtonClick()
			{
				this.m_owner.OnRecruitPanelSaveButtonClick();
			}

			// Token: 0x0600F4C8 RID: 62664 RVA: 0x0040DC80 File Offset: 0x0040BE80
			public void OnRecruitPanelBackButtonClick()
			{
				this.m_owner.OnRecruitPanelBackButtonClick();
			}

			// Token: 0x0600F4C9 RID: 62665 RVA: 0x0040DC90 File Offset: 0x0040BE90
			public void OnInvitePanelSetButtonClick()
			{
				this.m_owner.OnInvitePanelSetButtonClick();
			}

			// Token: 0x0600F4CA RID: 62666 RVA: 0x0040DCA0 File Offset: 0x0040BEA0
			public void SetGuildSetSubPanel()
			{
				this.m_owner.SetGuildSetSubPanel();
			}

			// Token: 0x0600F4CB RID: 62667 RVA: 0x0040DCB0 File Offset: 0x0040BEB0
			public void OnGuildSetPanelChairmanToggleClick(bool isOn)
			{
				this.m_owner.OnGuildSetPanelChairmanToggleClick(isOn);
			}

			// Token: 0x0600F4CC RID: 62668 RVA: 0x0040DCC0 File Offset: 0x0040BEC0
			public void OnGuildSetPanelAutoToggleClick(bool isOn)
			{
				this.m_owner.OnGuildSetPanelAutoToggleClick(isOn);
			}

			// Token: 0x0600F4CD RID: 62669 RVA: 0x0040DCD0 File Offset: 0x0040BED0
			public void OnGuildSetPanelLevelInputFieldRightButtonClick()
			{
				this.m_owner.OnGuildSetPanelLevelInputFieldRightButtonClick();
			}

			// Token: 0x0600F4CE RID: 62670 RVA: 0x0040DCE0 File Offset: 0x0040BEE0
			public void OnGuildSetPanelLevelInputFieldLeftButtonClick()
			{
				this.m_owner.OnGuildSetPanelLevelInputFieldLeftButtonClick();
			}

			// Token: 0x0600F4CF RID: 62671 RVA: 0x0040DCF0 File Offset: 0x0040BEF0
			public void OnGuildSetPanelLevelInputFieldEditEnd(string inputStr)
			{
				this.m_owner.OnGuildSetPanelLevelInputFieldEditEnd(inputStr);
			}

			// Token: 0x0600F4D0 RID: 62672 RVA: 0x0040DD00 File Offset: 0x0040BF00
			public void OnGuildSetPanelSaveButtonClick()
			{
				this.m_owner.OnGuildSetPanelSaveButtonClick();
			}

			// Token: 0x0600F4D1 RID: 62673 RVA: 0x0040DD10 File Offset: 0x0040BF10
			public void OnGuildSetPanelBackButtonClick()
			{
				this.m_owner.OnGuildSetPanelBackButtonClick();
			}

			// Token: 0x0600F4D2 RID: 62674 RVA: 0x0040DD20 File Offset: 0x0040BF20
			public void CloseGuildSetPanel(Action onEnd)
			{
				this.m_owner.CloseGuildSetPanel(onEnd);
			}

			// Token: 0x040090E6 RID: 37094
			private GuildManagementUIController m_owner;
		}
	}
}
