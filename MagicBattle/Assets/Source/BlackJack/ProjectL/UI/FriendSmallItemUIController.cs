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
	// Token: 0x02000CB6 RID: 3254
	[HotFix]
	public class FriendSmallItemUIController : UIControllerBase
	{
		// Token: 0x0600EBAC RID: 60332 RVA: 0x003EFE50 File Offset: 0x003EE050
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
			this.m_chatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_addButton.onClick.AddListener(new UnityAction(this.OnAddButtonClick));
			this.m_agreeButton.onClick.AddListener(new UnityAction(this.OnAgreeButtonClick));
			this.m_disagreeButton.onClick.AddListener(new UnityAction(this.OnDisagreeButtonClick));
			this.m_inGroupButton.onClick.AddListener(new UnityAction(this.OnInGroupButtonClick));
			this.m_selectToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSelectToggleValueChanged));
		}

		// Token: 0x0600EBAD RID: 60333 RVA: 0x003EFF7C File Offset: 0x003EE17C
		public void SetFriendInfo(UserSummary userSummy, FriendInfoType friendInfoType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFriendInfoUserSummaryFriendInfoType_hotfix != null)
			{
				this.m_SetFriendInfoUserSummaryFriendInfoType_hotfix.call(new object[]
				{
					this,
					userSummy,
					friendInfoType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (friendInfoType)
			{
			case FriendInfoType.AddFriend:
			case FriendInfoType.RecommendFriend:
				this.m_uiStateController.SetToUIState("Normal", false, true);
				this.m_buttonGroupUIStateController.SetToUIState("Add", false, true);
				break;
			case FriendInfoType.FriendApply:
				this.m_uiStateController.SetToUIState("Normal", false, true);
				this.m_buttonGroupUIStateController.SetToUIState("AgreeOrNot", false, true);
				break;
			case FriendInfoType.FriendInviteToGroup:
				this.m_buttonGroupUIStateController.SetToUIState("Select", false, true);
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
			if (LoginUITask.GetServerInfoByBornChannelID(RoleGenerator.GetBornChannelIdFromUserId(userSummy.UserId)) == null)
			{
				this.m_serverText.gameObject.SetActive(false);
			}
			else
			{
				this.m_serverText.text = LoginUITask.GetServerInfoByBornChannelID(RoleGenerator.GetBornChannelIdFromUserId(userSummy.UserId)).m_name;
				this.m_serverText.gameObject.SetActive(true);
			}
			this.m_friendLevelText.text = userSummy.Level.ToString();
			this.m_friendNameText.text = userSummy.Name;
			Image friendIconImage = this.m_friendIconImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(userSummy.HeadIcon)));
			this.m_friendIconGreyImage.sprite = sprite;
			friendIconImage.sprite = sprite;
			UIUtility.SetPlayerHeadFrame(this.m_friendHeadFrameTransform, HeadIconTools.GetHeadFrame(userSummy.HeadIcon), true, (!userSummy.Online) ? "Offline" : "Normal");
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x003F0300 File Offset: 0x003EE500
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

		// Token: 0x0600EBAF RID: 60335 RVA: 0x003F0374 File Offset: 0x003EE574
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

		// Token: 0x0600EBB0 RID: 60336 RVA: 0x003F03E8 File Offset: 0x003EE5E8
		public void SetUserSelect(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUserSelectBoolean_hotfix != null)
			{
				this.m_SetUserSelectBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectToggle.isOn = isOn;
		}

		// Token: 0x0600EBB1 RID: 60337 RVA: 0x003F0464 File Offset: 0x003EE664
		public void SetUserInGroup(bool isIn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUserInGroupBoolean_hotfix != null)
			{
				this.m_SetUserInGroupBoolean_hotfix.call(new object[]
				{
					this,
					isIn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isIn)
			{
				this.m_buttonGroupUIStateController.SetToUIState("None", false, true);
				this.m_uiStateController.SetToUIState("InGroup", false, true);
			}
			else
			{
				this.m_uiStateController.SetToUIState("Normal", false, true);
			}
		}

		// Token: 0x0600EBB2 RID: 60338 RVA: 0x003F0518 File Offset: 0x003EE718
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

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x003F05B0 File Offset: 0x003EE7B0
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

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x003F06FC File Offset: 0x003EE8FC
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

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x003F0774 File Offset: 0x003EE974
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

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x003F07EC File Offset: 0x003EE9EC
		private void OnAgreeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAgreeButtonClick_hotfix != null)
			{
				this.m_OnAgreeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAgree != null)
			{
				this.EventOnAgree(this);
			}
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x003F0864 File Offset: 0x003EEA64
		private void OnDisagreeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisagreeButtonClick_hotfix != null)
			{
				this.m_OnDisagreeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDisagree != null)
			{
				this.EventOnDisagree(this);
			}
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x003F08DC File Offset: 0x003EEADC
		private void OnInGroupButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInGroupButtonClick_hotfix != null)
			{
				this.m_OnInGroupButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_AlreadyInGroup), 2f, null, true);
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x003F0960 File Offset: 0x003EEB60
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

		// Token: 0x0600EBBA RID: 60346 RVA: 0x003F09D8 File Offset: 0x003EEBD8
		private void OnSelectToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSelectToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectToggleValueChanged != null)
			{
				this.EventOnSelectToggleValueChanged(isOn, this);
			}
		}

		// Token: 0x14000316 RID: 790
		// (add) Token: 0x0600EBBB RID: 60347 RVA: 0x003F0A60 File Offset: 0x003EEC60
		// (remove) Token: 0x0600EBBC RID: 60348 RVA: 0x003F0AFC File Offset: 0x003EECFC
		public event Action<FriendSmallItemUIController> EventOnShowPlayerSimpleInfo
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
				Action<FriendSmallItemUIController> action = this.EventOnShowPlayerSimpleInfo;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnShowPlayerSimpleInfo, (Action<FriendSmallItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<FriendSmallItemUIController> action = this.EventOnShowPlayerSimpleInfo;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnShowPlayerSimpleInfo, (Action<FriendSmallItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000317 RID: 791
		// (add) Token: 0x0600EBBD RID: 60349 RVA: 0x003F0B98 File Offset: 0x003EED98
		// (remove) Token: 0x0600EBBE RID: 60350 RVA: 0x003F0C34 File Offset: 0x003EEE34
		public event Action<FriendSmallItemUIController> EventOnAgree
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAgreeAction`1_hotfix != null)
				{
					this.m_add_EventOnAgreeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendSmallItemUIController> action = this.EventOnAgree;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnAgree, (Action<FriendSmallItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAgreeAction`1_hotfix != null)
				{
					this.m_remove_EventOnAgreeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendSmallItemUIController> action = this.EventOnAgree;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnAgree, (Action<FriendSmallItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000318 RID: 792
		// (add) Token: 0x0600EBBF RID: 60351 RVA: 0x003F0CD0 File Offset: 0x003EEED0
		// (remove) Token: 0x0600EBC0 RID: 60352 RVA: 0x003F0D6C File Offset: 0x003EEF6C
		public event Action<FriendSmallItemUIController> EventOnDisagree
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDisagreeAction`1_hotfix != null)
				{
					this.m_add_EventOnDisagreeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendSmallItemUIController> action = this.EventOnDisagree;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnDisagree, (Action<FriendSmallItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDisagreeAction`1_hotfix != null)
				{
					this.m_remove_EventOnDisagreeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendSmallItemUIController> action = this.EventOnDisagree;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnDisagree, (Action<FriendSmallItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000319 RID: 793
		// (add) Token: 0x0600EBC1 RID: 60353 RVA: 0x003F0E08 File Offset: 0x003EF008
		// (remove) Token: 0x0600EBC2 RID: 60354 RVA: 0x003F0EA4 File Offset: 0x003EF0A4
		public event Action<FriendSmallItemUIController> EventOnAdd
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
				Action<FriendSmallItemUIController> action = this.EventOnAdd;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnAdd, (Action<FriendSmallItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<FriendSmallItemUIController> action = this.EventOnAdd;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnAdd, (Action<FriendSmallItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400031A RID: 794
		// (add) Token: 0x0600EBC3 RID: 60355 RVA: 0x003F0F40 File Offset: 0x003EF140
		// (remove) Token: 0x0600EBC4 RID: 60356 RVA: 0x003F0FDC File Offset: 0x003EF1DC
		public event Action<bool, FriendSmallItemUIController> EventOnSelectToggleValueChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix != null)
				{
					this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, FriendSmallItemUIController> action = this.EventOnSelectToggleValueChanged;
				Action<bool, FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, FriendSmallItemUIController>>(ref this.EventOnSelectToggleValueChanged, (Action<bool, FriendSmallItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix != null)
				{
					this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, FriendSmallItemUIController> action = this.EventOnSelectToggleValueChanged;
				Action<bool, FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, FriendSmallItemUIController>>(ref this.EventOnSelectToggleValueChanged, (Action<bool, FriendSmallItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400031B RID: 795
		// (add) Token: 0x0600EBC5 RID: 60357 RVA: 0x003F1078 File Offset: 0x003EF278
		// (remove) Token: 0x0600EBC6 RID: 60358 RVA: 0x003F1114 File Offset: 0x003EF314
		public event Action<FriendSmallItemUIController> EventOnChat
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
				Action<FriendSmallItemUIController> action = this.EventOnChat;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnChat, (Action<FriendSmallItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<FriendSmallItemUIController> action = this.EventOnChat;
				Action<FriendSmallItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendSmallItemUIController>>(ref this.EventOnChat, (Action<FriendSmallItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0600EBC7 RID: 60359 RVA: 0x003F11B0 File Offset: 0x003EF3B0
		// (set) Token: 0x0600EBC8 RID: 60360 RVA: 0x003F11D0 File Offset: 0x003EF3D0
		[DoNotToLua]
		public new FriendSmallItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendSmallItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x003F11DC File Offset: 0x003EF3DC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EBCA RID: 60362 RVA: 0x003F11E8 File Offset: 0x003EF3E8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x003F11F0 File Offset: 0x003EF3F0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x003F11F8 File Offset: 0x003EF3F8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x003F120C File Offset: 0x003EF40C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EBCE RID: 60366 RVA: 0x003F1214 File Offset: 0x003EF414
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EBCF RID: 60367 RVA: 0x003F1220 File Offset: 0x003EF420
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EBD0 RID: 60368 RVA: 0x003F122C File Offset: 0x003EF42C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EBD1 RID: 60369 RVA: 0x003F1238 File Offset: 0x003EF438
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EBD2 RID: 60370 RVA: 0x003F1244 File Offset: 0x003EF444
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EBD3 RID: 60371 RVA: 0x003F1250 File Offset: 0x003EF450
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x003F125C File Offset: 0x003EF45C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EBD5 RID: 60373 RVA: 0x003F1268 File Offset: 0x003EF468
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EBD6 RID: 60374 RVA: 0x003F1274 File Offset: 0x003EF474
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EBD7 RID: 60375 RVA: 0x003F1280 File Offset: 0x003EF480
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EBD8 RID: 60376 RVA: 0x003F1288 File Offset: 0x003EF488
		private void __callDele_EventOnShowPlayerSimpleInfo(FriendSmallItemUIController obj)
		{
			Action<FriendSmallItemUIController> eventOnShowPlayerSimpleInfo = this.EventOnShowPlayerSimpleInfo;
			if (eventOnShowPlayerSimpleInfo != null)
			{
				eventOnShowPlayerSimpleInfo(obj);
			}
		}

		// Token: 0x0600EBD9 RID: 60377 RVA: 0x003F12AC File Offset: 0x003EF4AC
		private void __clearDele_EventOnShowPlayerSimpleInfo(FriendSmallItemUIController obj)
		{
			this.EventOnShowPlayerSimpleInfo = null;
		}

		// Token: 0x0600EBDA RID: 60378 RVA: 0x003F12B8 File Offset: 0x003EF4B8
		private void __callDele_EventOnAgree(FriendSmallItemUIController obj)
		{
			Action<FriendSmallItemUIController> eventOnAgree = this.EventOnAgree;
			if (eventOnAgree != null)
			{
				eventOnAgree(obj);
			}
		}

		// Token: 0x0600EBDB RID: 60379 RVA: 0x003F12DC File Offset: 0x003EF4DC
		private void __clearDele_EventOnAgree(FriendSmallItemUIController obj)
		{
			this.EventOnAgree = null;
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x003F12E8 File Offset: 0x003EF4E8
		private void __callDele_EventOnDisagree(FriendSmallItemUIController obj)
		{
			Action<FriendSmallItemUIController> eventOnDisagree = this.EventOnDisagree;
			if (eventOnDisagree != null)
			{
				eventOnDisagree(obj);
			}
		}

		// Token: 0x0600EBDD RID: 60381 RVA: 0x003F130C File Offset: 0x003EF50C
		private void __clearDele_EventOnDisagree(FriendSmallItemUIController obj)
		{
			this.EventOnDisagree = null;
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x003F1318 File Offset: 0x003EF518
		private void __callDele_EventOnAdd(FriendSmallItemUIController obj)
		{
			Action<FriendSmallItemUIController> eventOnAdd = this.EventOnAdd;
			if (eventOnAdd != null)
			{
				eventOnAdd(obj);
			}
		}

		// Token: 0x0600EBDF RID: 60383 RVA: 0x003F133C File Offset: 0x003EF53C
		private void __clearDele_EventOnAdd(FriendSmallItemUIController obj)
		{
			this.EventOnAdd = null;
		}

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x003F1348 File Offset: 0x003EF548
		private void __callDele_EventOnSelectToggleValueChanged(bool arg1, FriendSmallItemUIController arg2)
		{
			Action<bool, FriendSmallItemUIController> eventOnSelectToggleValueChanged = this.EventOnSelectToggleValueChanged;
			if (eventOnSelectToggleValueChanged != null)
			{
				eventOnSelectToggleValueChanged(arg1, arg2);
			}
		}

		// Token: 0x0600EBE1 RID: 60385 RVA: 0x003F136C File Offset: 0x003EF56C
		private void __clearDele_EventOnSelectToggleValueChanged(bool arg1, FriendSmallItemUIController arg2)
		{
			this.EventOnSelectToggleValueChanged = null;
		}

		// Token: 0x0600EBE2 RID: 60386 RVA: 0x003F1378 File Offset: 0x003EF578
		private void __callDele_EventOnChat(FriendSmallItemUIController obj)
		{
			Action<FriendSmallItemUIController> eventOnChat = this.EventOnChat;
			if (eventOnChat != null)
			{
				eventOnChat(obj);
			}
		}

		// Token: 0x0600EBE3 RID: 60387 RVA: 0x003F139C File Offset: 0x003EF59C
		private void __clearDele_EventOnChat(FriendSmallItemUIController obj)
		{
			this.EventOnChat = null;
		}

		// Token: 0x0600EBE4 RID: 60388 RVA: 0x003F13A8 File Offset: 0x003EF5A8
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
					this.m_SetFriendInfoUserSummaryFriendInfoType_hotfix = (luaObj.RawGet("SetFriendInfo") as LuaFunction);
					this.m_GetUserID_hotfix = (luaObj.RawGet("GetUserID") as LuaFunction);
					this.m_GetUserSummy_hotfix = (luaObj.RawGet("GetUserSummy") as LuaFunction);
					this.m_SetUserSelectBoolean_hotfix = (luaObj.RawGet("SetUserSelect") as LuaFunction);
					this.m_SetUserInGroupBoolean_hotfix = (luaObj.RawGet("SetUserInGroup") as LuaFunction);
					this.m_GetSimpleInfoPostionType_hotfix = (luaObj.RawGet("GetSimpleInfoPostionType") as LuaFunction);
					this.m_GetPlayerSimpleInfoPos_hotfix = (luaObj.RawGet("GetPlayerSimpleInfoPos") as LuaFunction);
					this.m_OnItemButtonClick_hotfix = (luaObj.RawGet("OnItemButtonClick") as LuaFunction);
					this.m_OnChatButtonClick_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnAgreeButtonClick_hotfix = (luaObj.RawGet("OnAgreeButtonClick") as LuaFunction);
					this.m_OnDisagreeButtonClick_hotfix = (luaObj.RawGet("OnDisagreeButtonClick") as LuaFunction);
					this.m_OnInGroupButtonClick_hotfix = (luaObj.RawGet("OnInGroupButtonClick") as LuaFunction);
					this.m_OnAddButtonClick_hotfix = (luaObj.RawGet("OnAddButtonClick") as LuaFunction);
					this.m_OnSelectToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSelectToggleValueChanged") as LuaFunction);
					this.m_add_EventOnShowPlayerSimpleInfoAction`1_hotfix = (luaObj.RawGet("add_EventOnShowPlayerSimpleInfo") as LuaFunction);
					this.m_remove_EventOnShowPlayerSimpleInfoAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowPlayerSimpleInfo") as LuaFunction);
					this.m_add_EventOnAgreeAction`1_hotfix = (luaObj.RawGet("add_EventOnAgree") as LuaFunction);
					this.m_remove_EventOnAgreeAction`1_hotfix = (luaObj.RawGet("remove_EventOnAgree") as LuaFunction);
					this.m_add_EventOnDisagreeAction`1_hotfix = (luaObj.RawGet("add_EventOnDisagree") as LuaFunction);
					this.m_remove_EventOnDisagreeAction`1_hotfix = (luaObj.RawGet("remove_EventOnDisagree") as LuaFunction);
					this.m_add_EventOnAddAction`1_hotfix = (luaObj.RawGet("add_EventOnAdd") as LuaFunction);
					this.m_remove_EventOnAddAction`1_hotfix = (luaObj.RawGet("remove_EventOnAdd") as LuaFunction);
					this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix = (luaObj.RawGet("add_EventOnSelectToggleValueChanged") as LuaFunction);
					this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix = (luaObj.RawGet("remove_EventOnSelectToggleValueChanged") as LuaFunction);
					this.m_add_EventOnChatAction`1_hotfix = (luaObj.RawGet("add_EventOnChat") as LuaFunction);
					this.m_remove_EventOnChatAction`1_hotfix = (luaObj.RawGet("remove_EventOnChat") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x003F1700 File Offset: 0x003EF900
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendSmallItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008D30 RID: 36144
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04008D31 RID: 36145
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemButton;

		// Token: 0x04008D32 RID: 36146
		[AutoBind("./ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x04008D33 RID: 36147
		[AutoBind("./ButtonGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_buttonGroupUIStateController;

		// Token: 0x04008D34 RID: 36148
		[AutoBind("./StateGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_friendOnlineUIStateController;

		// Token: 0x04008D35 RID: 36149
		[AutoBind("./StateGroup/OnLineText2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendOnlineLongText;

		// Token: 0x04008D36 RID: 36150
		[AutoBind("./PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_friendIconImage;

		// Token: 0x04008D37 RID: 36151
		[AutoBind("./PlayerIconImageGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_friendIconGreyImage;

		// Token: 0x04008D38 RID: 36152
		[AutoBind("./HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_friendHeadFrameTransform;

		// Token: 0x04008D39 RID: 36153
		[AutoBind("./ButtonGroup/AgreeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_agreeButton;

		// Token: 0x04008D3A RID: 36154
		[AutoBind("./ButtonGroup/DisagreeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_disagreeButton;

		// Token: 0x04008D3B RID: 36155
		[AutoBind("./ButtonGroup/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addButton;

		// Token: 0x04008D3C RID: 36156
		[AutoBind("./ButtonGroup/SelectToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_selectToggle;

		// Token: 0x04008D3D RID: 36157
		[AutoBind("./LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendLevelText;

		// Token: 0x04008D3E RID: 36158
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_friendNameText;

		// Token: 0x04008D3F RID: 36159
		[AutoBind("./ServerText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_serverText;

		// Token: 0x04008D40 RID: 36160
		[AutoBind("./InGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_inGroupButton;

		// Token: 0x04008D41 RID: 36161
		private string m_userID;

		// Token: 0x04008D42 RID: 36162
		private UserSummary m_userSummy;

		// Token: 0x04008D43 RID: 36163
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04008D44 RID: 36164
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04008D45 RID: 36165
		[DoNotToLua]
		private FriendSmallItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008D46 RID: 36166
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008D47 RID: 36167
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008D48 RID: 36168
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008D49 RID: 36169
		private LuaFunction m_SetFriendInfoUserSummaryFriendInfoType_hotfix;

		// Token: 0x04008D4A RID: 36170
		private LuaFunction m_GetUserID_hotfix;

		// Token: 0x04008D4B RID: 36171
		private LuaFunction m_GetUserSummy_hotfix;

		// Token: 0x04008D4C RID: 36172
		private LuaFunction m_SetUserSelectBoolean_hotfix;

		// Token: 0x04008D4D RID: 36173
		private LuaFunction m_SetUserInGroupBoolean_hotfix;

		// Token: 0x04008D4E RID: 36174
		private LuaFunction m_GetSimpleInfoPostionType_hotfix;

		// Token: 0x04008D4F RID: 36175
		private LuaFunction m_GetPlayerSimpleInfoPos_hotfix;

		// Token: 0x04008D50 RID: 36176
		private LuaFunction m_OnItemButtonClick_hotfix;

		// Token: 0x04008D51 RID: 36177
		private LuaFunction m_OnChatButtonClick_hotfix;

		// Token: 0x04008D52 RID: 36178
		private LuaFunction m_OnAgreeButtonClick_hotfix;

		// Token: 0x04008D53 RID: 36179
		private LuaFunction m_OnDisagreeButtonClick_hotfix;

		// Token: 0x04008D54 RID: 36180
		private LuaFunction m_OnInGroupButtonClick_hotfix;

		// Token: 0x04008D55 RID: 36181
		private LuaFunction m_OnAddButtonClick_hotfix;

		// Token: 0x04008D56 RID: 36182
		private LuaFunction m_OnSelectToggleValueChangedBoolean_hotfix;

		// Token: 0x04008D57 RID: 36183
		private LuaFunction m_add_EventOnShowPlayerSimpleInfoAction;

		// Token: 0x04008D58 RID: 36184
		private LuaFunction m_remove_EventOnShowPlayerSimpleInfoAction;

		// Token: 0x04008D59 RID: 36185
		private LuaFunction m_add_EventOnAgreeAction;

		// Token: 0x04008D5A RID: 36186
		private LuaFunction m_remove_EventOnAgreeAction;

		// Token: 0x04008D5B RID: 36187
		private LuaFunction m_add_EventOnDisagreeAction;

		// Token: 0x04008D5C RID: 36188
		private LuaFunction m_remove_EventOnDisagreeAction;

		// Token: 0x04008D5D RID: 36189
		private LuaFunction m_add_EventOnAddAction;

		// Token: 0x04008D5E RID: 36190
		private LuaFunction m_remove_EventOnAddAction;

		// Token: 0x04008D5F RID: 36191
		private LuaFunction m_add_EventOnSelectToggleValueChangedAction;

		// Token: 0x04008D60 RID: 36192
		private LuaFunction m_remove_EventOnSelectToggleValueChangedAction;

		// Token: 0x04008D61 RID: 36193
		private LuaFunction m_add_EventOnChatAction;

		// Token: 0x04008D62 RID: 36194
		private LuaFunction m_remove_EventOnChatAction;

		// Token: 0x02000CB7 RID: 3255
		public new class LuaExportHelper
		{
			// Token: 0x0600EBE6 RID: 60390 RVA: 0x003F1768 File Offset: 0x003EF968
			public LuaExportHelper(FriendSmallItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EBE7 RID: 60391 RVA: 0x003F1778 File Offset: 0x003EF978
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EBE8 RID: 60392 RVA: 0x003F1788 File Offset: 0x003EF988
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EBE9 RID: 60393 RVA: 0x003F1798 File Offset: 0x003EF998
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EBEA RID: 60394 RVA: 0x003F17A8 File Offset: 0x003EF9A8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EBEB RID: 60395 RVA: 0x003F17C0 File Offset: 0x003EF9C0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EBEC RID: 60396 RVA: 0x003F17D0 File Offset: 0x003EF9D0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EBED RID: 60397 RVA: 0x003F17E0 File Offset: 0x003EF9E0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EBEE RID: 60398 RVA: 0x003F17F0 File Offset: 0x003EF9F0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EBEF RID: 60399 RVA: 0x003F1800 File Offset: 0x003EFA00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EBF0 RID: 60400 RVA: 0x003F1810 File Offset: 0x003EFA10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EBF1 RID: 60401 RVA: 0x003F1820 File Offset: 0x003EFA20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EBF2 RID: 60402 RVA: 0x003F1830 File Offset: 0x003EFA30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EBF3 RID: 60403 RVA: 0x003F1840 File Offset: 0x003EFA40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EBF4 RID: 60404 RVA: 0x003F1850 File Offset: 0x003EFA50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EBF5 RID: 60405 RVA: 0x003F1860 File Offset: 0x003EFA60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600EBF6 RID: 60406 RVA: 0x003F1870 File Offset: 0x003EFA70
			public void __callDele_EventOnShowPlayerSimpleInfo(FriendSmallItemUIController obj)
			{
				this.m_owner.__callDele_EventOnShowPlayerSimpleInfo(obj);
			}

			// Token: 0x0600EBF7 RID: 60407 RVA: 0x003F1880 File Offset: 0x003EFA80
			public void __clearDele_EventOnShowPlayerSimpleInfo(FriendSmallItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnShowPlayerSimpleInfo(obj);
			}

			// Token: 0x0600EBF8 RID: 60408 RVA: 0x003F1890 File Offset: 0x003EFA90
			public void __callDele_EventOnAgree(FriendSmallItemUIController obj)
			{
				this.m_owner.__callDele_EventOnAgree(obj);
			}

			// Token: 0x0600EBF9 RID: 60409 RVA: 0x003F18A0 File Offset: 0x003EFAA0
			public void __clearDele_EventOnAgree(FriendSmallItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnAgree(obj);
			}

			// Token: 0x0600EBFA RID: 60410 RVA: 0x003F18B0 File Offset: 0x003EFAB0
			public void __callDele_EventOnDisagree(FriendSmallItemUIController obj)
			{
				this.m_owner.__callDele_EventOnDisagree(obj);
			}

			// Token: 0x0600EBFB RID: 60411 RVA: 0x003F18C0 File Offset: 0x003EFAC0
			public void __clearDele_EventOnDisagree(FriendSmallItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnDisagree(obj);
			}

			// Token: 0x0600EBFC RID: 60412 RVA: 0x003F18D0 File Offset: 0x003EFAD0
			public void __callDele_EventOnAdd(FriendSmallItemUIController obj)
			{
				this.m_owner.__callDele_EventOnAdd(obj);
			}

			// Token: 0x0600EBFD RID: 60413 RVA: 0x003F18E0 File Offset: 0x003EFAE0
			public void __clearDele_EventOnAdd(FriendSmallItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnAdd(obj);
			}

			// Token: 0x0600EBFE RID: 60414 RVA: 0x003F18F0 File Offset: 0x003EFAF0
			public void __callDele_EventOnSelectToggleValueChanged(bool arg1, FriendSmallItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnSelectToggleValueChanged(arg1, arg2);
			}

			// Token: 0x0600EBFF RID: 60415 RVA: 0x003F1900 File Offset: 0x003EFB00
			public void __clearDele_EventOnSelectToggleValueChanged(bool arg1, FriendSmallItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnSelectToggleValueChanged(arg1, arg2);
			}

			// Token: 0x0600EC00 RID: 60416 RVA: 0x003F1910 File Offset: 0x003EFB10
			public void __callDele_EventOnChat(FriendSmallItemUIController obj)
			{
				this.m_owner.__callDele_EventOnChat(obj);
			}

			// Token: 0x0600EC01 RID: 60417 RVA: 0x003F1920 File Offset: 0x003EFB20
			public void __clearDele_EventOnChat(FriendSmallItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnChat(obj);
			}

			// Token: 0x17002D90 RID: 11664
			// (get) Token: 0x0600EC02 RID: 60418 RVA: 0x003F1930 File Offset: 0x003EFB30
			// (set) Token: 0x0600EC03 RID: 60419 RVA: 0x003F1940 File Offset: 0x003EFB40
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

			// Token: 0x17002D91 RID: 11665
			// (get) Token: 0x0600EC04 RID: 60420 RVA: 0x003F1950 File Offset: 0x003EFB50
			// (set) Token: 0x0600EC05 RID: 60421 RVA: 0x003F1960 File Offset: 0x003EFB60
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

			// Token: 0x17002D92 RID: 11666
			// (get) Token: 0x0600EC06 RID: 60422 RVA: 0x003F1970 File Offset: 0x003EFB70
			// (set) Token: 0x0600EC07 RID: 60423 RVA: 0x003F1980 File Offset: 0x003EFB80
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

			// Token: 0x17002D93 RID: 11667
			// (get) Token: 0x0600EC08 RID: 60424 RVA: 0x003F1990 File Offset: 0x003EFB90
			// (set) Token: 0x0600EC09 RID: 60425 RVA: 0x003F19A0 File Offset: 0x003EFBA0
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

			// Token: 0x17002D94 RID: 11668
			// (get) Token: 0x0600EC0A RID: 60426 RVA: 0x003F19B0 File Offset: 0x003EFBB0
			// (set) Token: 0x0600EC0B RID: 60427 RVA: 0x003F19C0 File Offset: 0x003EFBC0
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

			// Token: 0x17002D95 RID: 11669
			// (get) Token: 0x0600EC0C RID: 60428 RVA: 0x003F19D0 File Offset: 0x003EFBD0
			// (set) Token: 0x0600EC0D RID: 60429 RVA: 0x003F19E0 File Offset: 0x003EFBE0
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

			// Token: 0x17002D96 RID: 11670
			// (get) Token: 0x0600EC0E RID: 60430 RVA: 0x003F19F0 File Offset: 0x003EFBF0
			// (set) Token: 0x0600EC0F RID: 60431 RVA: 0x003F1A00 File Offset: 0x003EFC00
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

			// Token: 0x17002D97 RID: 11671
			// (get) Token: 0x0600EC10 RID: 60432 RVA: 0x003F1A10 File Offset: 0x003EFC10
			// (set) Token: 0x0600EC11 RID: 60433 RVA: 0x003F1A20 File Offset: 0x003EFC20
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

			// Token: 0x17002D98 RID: 11672
			// (get) Token: 0x0600EC12 RID: 60434 RVA: 0x003F1A30 File Offset: 0x003EFC30
			// (set) Token: 0x0600EC13 RID: 60435 RVA: 0x003F1A40 File Offset: 0x003EFC40
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

			// Token: 0x17002D99 RID: 11673
			// (get) Token: 0x0600EC14 RID: 60436 RVA: 0x003F1A50 File Offset: 0x003EFC50
			// (set) Token: 0x0600EC15 RID: 60437 RVA: 0x003F1A60 File Offset: 0x003EFC60
			public Button m_agreeButton
			{
				get
				{
					return this.m_owner.m_agreeButton;
				}
				set
				{
					this.m_owner.m_agreeButton = value;
				}
			}

			// Token: 0x17002D9A RID: 11674
			// (get) Token: 0x0600EC16 RID: 60438 RVA: 0x003F1A70 File Offset: 0x003EFC70
			// (set) Token: 0x0600EC17 RID: 60439 RVA: 0x003F1A80 File Offset: 0x003EFC80
			public Button m_disagreeButton
			{
				get
				{
					return this.m_owner.m_disagreeButton;
				}
				set
				{
					this.m_owner.m_disagreeButton = value;
				}
			}

			// Token: 0x17002D9B RID: 11675
			// (get) Token: 0x0600EC18 RID: 60440 RVA: 0x003F1A90 File Offset: 0x003EFC90
			// (set) Token: 0x0600EC19 RID: 60441 RVA: 0x003F1AA0 File Offset: 0x003EFCA0
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

			// Token: 0x17002D9C RID: 11676
			// (get) Token: 0x0600EC1A RID: 60442 RVA: 0x003F1AB0 File Offset: 0x003EFCB0
			// (set) Token: 0x0600EC1B RID: 60443 RVA: 0x003F1AC0 File Offset: 0x003EFCC0
			public Toggle m_selectToggle
			{
				get
				{
					return this.m_owner.m_selectToggle;
				}
				set
				{
					this.m_owner.m_selectToggle = value;
				}
			}

			// Token: 0x17002D9D RID: 11677
			// (get) Token: 0x0600EC1C RID: 60444 RVA: 0x003F1AD0 File Offset: 0x003EFCD0
			// (set) Token: 0x0600EC1D RID: 60445 RVA: 0x003F1AE0 File Offset: 0x003EFCE0
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

			// Token: 0x17002D9E RID: 11678
			// (get) Token: 0x0600EC1E RID: 60446 RVA: 0x003F1AF0 File Offset: 0x003EFCF0
			// (set) Token: 0x0600EC1F RID: 60447 RVA: 0x003F1B00 File Offset: 0x003EFD00
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

			// Token: 0x17002D9F RID: 11679
			// (get) Token: 0x0600EC20 RID: 60448 RVA: 0x003F1B10 File Offset: 0x003EFD10
			// (set) Token: 0x0600EC21 RID: 60449 RVA: 0x003F1B20 File Offset: 0x003EFD20
			public Text m_serverText
			{
				get
				{
					return this.m_owner.m_serverText;
				}
				set
				{
					this.m_owner.m_serverText = value;
				}
			}

			// Token: 0x17002DA0 RID: 11680
			// (get) Token: 0x0600EC22 RID: 60450 RVA: 0x003F1B30 File Offset: 0x003EFD30
			// (set) Token: 0x0600EC23 RID: 60451 RVA: 0x003F1B40 File Offset: 0x003EFD40
			public Button m_inGroupButton
			{
				get
				{
					return this.m_owner.m_inGroupButton;
				}
				set
				{
					this.m_owner.m_inGroupButton = value;
				}
			}

			// Token: 0x17002DA1 RID: 11681
			// (get) Token: 0x0600EC24 RID: 60452 RVA: 0x003F1B50 File Offset: 0x003EFD50
			// (set) Token: 0x0600EC25 RID: 60453 RVA: 0x003F1B60 File Offset: 0x003EFD60
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

			// Token: 0x17002DA2 RID: 11682
			// (get) Token: 0x0600EC26 RID: 60454 RVA: 0x003F1B70 File Offset: 0x003EFD70
			// (set) Token: 0x0600EC27 RID: 60455 RVA: 0x003F1B80 File Offset: 0x003EFD80
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

			// Token: 0x17002DA3 RID: 11683
			// (get) Token: 0x0600EC28 RID: 60456 RVA: 0x003F1B90 File Offset: 0x003EFD90
			// (set) Token: 0x0600EC29 RID: 60457 RVA: 0x003F1BA0 File Offset: 0x003EFDA0
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

			// Token: 0x17002DA4 RID: 11684
			// (get) Token: 0x0600EC2A RID: 60458 RVA: 0x003F1BB0 File Offset: 0x003EFDB0
			// (set) Token: 0x0600EC2B RID: 60459 RVA: 0x003F1BC0 File Offset: 0x003EFDC0
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

			// Token: 0x0600EC2C RID: 60460 RVA: 0x003F1BD0 File Offset: 0x003EFDD0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EC2D RID: 60461 RVA: 0x003F1BE0 File Offset: 0x003EFDE0
			public void OnItemButtonClick()
			{
				this.m_owner.OnItemButtonClick();
			}

			// Token: 0x0600EC2E RID: 60462 RVA: 0x003F1BF0 File Offset: 0x003EFDF0
			public void OnChatButtonClick()
			{
				this.m_owner.OnChatButtonClick();
			}

			// Token: 0x0600EC2F RID: 60463 RVA: 0x003F1C00 File Offset: 0x003EFE00
			public void OnAgreeButtonClick()
			{
				this.m_owner.OnAgreeButtonClick();
			}

			// Token: 0x0600EC30 RID: 60464 RVA: 0x003F1C10 File Offset: 0x003EFE10
			public void OnDisagreeButtonClick()
			{
				this.m_owner.OnDisagreeButtonClick();
			}

			// Token: 0x0600EC31 RID: 60465 RVA: 0x003F1C20 File Offset: 0x003EFE20
			public void OnInGroupButtonClick()
			{
				this.m_owner.OnInGroupButtonClick();
			}

			// Token: 0x0600EC32 RID: 60466 RVA: 0x003F1C30 File Offset: 0x003EFE30
			public void OnAddButtonClick()
			{
				this.m_owner.OnAddButtonClick();
			}

			// Token: 0x0600EC33 RID: 60467 RVA: 0x003F1C40 File Offset: 0x003EFE40
			public void OnSelectToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSelectToggleValueChanged(isOn);
			}

			// Token: 0x04008D63 RID: 36195
			private FriendSmallItemUIController m_owner;
		}
	}
}
