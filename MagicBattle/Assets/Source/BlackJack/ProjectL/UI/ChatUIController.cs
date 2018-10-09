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
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B51 RID: 2897
	[HotFix]
	public class ChatUIController : UIControllerBase
	{
		// Token: 0x0600C4DF RID: 50399 RVA: 0x003676D4 File Offset: 0x003658D4
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
			this.WorldButton.onClick.AddListener(delegate()
			{
				this.OnTableSelected(this.WorldButton);
			});
			this.SystemButton.onClick.AddListener(delegate()
			{
				this.OnTableSelected(this.SystemButton);
			});
			this.TeamButton.onClick.AddListener(delegate()
			{
				this.OnTableSelected(this.TeamButton);
			});
			this.GroupButton.onClick.AddListener(delegate()
			{
				this.OnTableSelected(this.GroupButton);
			});
			this.PrivateButton.onClick.AddListener(delegate()
			{
				this.OnTableSelected(this.PrivateButton);
			});
			this.GuildButton.onClick.AddListener(delegate()
			{
				this.OnTableSelected(this.GuildButton);
			});
			this.SendButton.onClick.AddListener(new UnityAction(this.OnSendButtonClick));
			this.CloseButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.BGButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.NewChatTip.onClick.AddListener(new UnityAction(this.SetScrollViewToBottom));
			this.RoomInput.onEndEdit.AddListener(new UnityAction<string>(this.OnRoomIdInputEnd));
			this.ExpressionFunctionButton.onClick.AddListener(new UnityAction(this.OnExpressionFunctionButtonClick));
			this.ChangeRoomButton.onClick.AddListener(new UnityAction(this.OnChangeRoomButtonClick));
			EventTriggerListener eventTriggerListener = this.TalkButton.gameObject.AddComponent<EventTriggerListener>();
			EventTriggerListener eventTriggerListener2 = eventTriggerListener;
			eventTriggerListener2.onExit = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener2.onExit, new EventTriggerListener.VoidDelegate(this.OnExitTalkButton));
			EventTriggerListener eventTriggerListener3 = eventTriggerListener;
			eventTriggerListener3.onEnter = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener3.onEnter, new EventTriggerListener.VoidDelegate(this.OnEnterTalkButton));
			EventTriggerListener eventTriggerListener4 = eventTriggerListener;
			eventTriggerListener4.onDown = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener4.onDown, new EventTriggerListener.VoidDelegate(this.OnTalkButtonClickDown));
			EventTriggerListener eventTriggerListener5 = eventTriggerListener;
			eventTriggerListener5.onUp = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener5.onUp, new EventTriggerListener.VoidDelegate(this.OnTalkButtonClickUp));
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			PrefabResourceContainer component = this.ScrollView.GetComponent<PrefabResourceContainer>();
			GameObject original = component.GetAsset("ChatManagerItem") as GameObject;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(original);
			gameObject.transform.SetParent(this.UnusedRoot.transform, false);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			PoolInfo poolInfoByName = this.m_objPool.GetPoolInfoByName("ChatManagerPool");
			poolInfoByName.prefab = gameObject;
			gameObject.SetActive(false);
			original = (component.GetAsset("SystemChatItem") as GameObject);
			gameObject = UnityEngine.Object.Instantiate<GameObject>(original);
			gameObject.transform.SetParent(this.UnusedRoot.transform, false);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			poolInfoByName = this.m_objPool.GetPoolInfoByName("SystemPool");
			poolInfoByName.prefab = gameObject;
			gameObject.SetActive(false);
			original = (component.GetAsset("WorldChatItemLeft") as GameObject);
			gameObject = UnityEngine.Object.Instantiate<GameObject>(original);
			gameObject.transform.SetParent(this.UnusedRoot.transform, false);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			poolInfoByName = this.m_objPool.GetPoolInfoByName("WorldLeftPool");
			poolInfoByName.prefab = gameObject;
			gameObject.SetActive(false);
			original = (component.GetAsset("WorldChatItemRight") as GameObject);
			gameObject = UnityEngine.Object.Instantiate<GameObject>(original);
			gameObject.transform.SetParent(this.UnusedRoot.transform, false);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			poolInfoByName = this.m_objPool.GetPoolInfoByName("WorldRightPool");
			poolInfoByName.prefab = gameObject;
			gameObject.SetActive(false);
			this.m_objPool.CreatePools();
			Stack<PoolObject> objectPoolByName = this.m_objPool.GetObjectPoolByName("ChatManagerPool");
			foreach (PoolObject poolObject in objectPoolByName)
			{
				ScrollItemBaseUIController component2 = poolObject.gameObject.GetComponent<ScrollItemBaseUIController>();
				component2.Init(component2, false);
				ScrollItemBaseUIController scrollItemBaseUIController = component2;
				scrollItemBaseUIController.EventOnUIItemNeedFill = (Action<UIControllerBase>)Delegate.Combine(scrollItemBaseUIController.EventOnUIItemNeedFill, new Action<UIControllerBase>(this.OnChatItemFill));
			}
			this.ChatTargetChooseDropdown.onValueChanged.AddListener(new UnityAction<int>(this.OnChatTargetChanged));
			EventTriggerListener eventTriggerListener6 = this.ChatTargetChooseDropdown.gameObject.AddComponent<EventTriggerListener>();
			EventTriggerListener eventTriggerListener7 = eventTriggerListener6;
			eventTriggerListener7.onClick = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener7.onClick, new EventTriggerListener.VoidDelegate(delegate(GameObject go)
			{
				this.OnChooseTargetRootClick();
			}));
			this.InputPanel.characterLimit = UIUtility.GetInputFieldCharacterLimit(50);
			this.InputPanel.onEndEdit.AddListener(new UnityAction<string>(this.InputPanel_OnEndEdit));
			if (this.m_redMarkObjs.Count == 0)
			{
				this.m_redMarkObjs.Add(this.WorldToggleRedMark);
				this.m_redMarkObjs.Add(this.SystemToggleRedMark);
				this.m_redMarkObjs.Add(this.TeamToggleRedMark);
				this.m_redMarkObjs.Add(this.GroupToggleRedMark);
				this.m_redMarkObjs.Add(this.PrivateToggleRedMark);
				this.m_redMarkObjs.Add(this.GuildToggleRedMark);
			}
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
			this.m_lastSelectButton = this.WorldButton;
			this.WorldButton.GetComponent<CommonUIStateController>().SetToUIState("Selected", false, true);
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x00367C80 File Offset: 0x00365E80
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_inited && this.m_currentChatList != null && this.IsScrollViewInEnd())
			{
				this.NewChatTip.gameObject.SetActive(false);
			}
			if (this.m_InputFocused != this.InputPanel.isFocused)
			{
				this.m_InputFocused = this.InputPanel.isFocused;
				if (this.m_InputFocused)
				{
					this.InputPanel.MoveTextEnd(false);
				}
			}
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x00367D50 File Offset: 0x00365F50
		private void OnRoomIdInputEnd(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRoomIdInputEndString_hotfix != null)
			{
				this.m_OnRoomIdInputEndString_hotfix.call(new object[]
				{
					this,
					content
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRoomIdInputEnd != null)
			{
				this.EventOnRoomIdInputEnd(content);
			}
		}

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x00367DD8 File Offset: 0x00365FD8
		private void OnExpressionFunctionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpressionFunctionButtonClick_hotfix != null)
			{
				this.m_OnExpressionFunctionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExpressionFunctionButtonClick != null)
			{
				this.EventOnExpressionFunctionButtonClick();
			}
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x00367E50 File Offset: 0x00366050
		private void OnTalkButtonClickDown(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonClickDownGameObject_hotfix != null)
			{
				this.m_OnTalkButtonClickDownGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_coroutineTalkButtonTestHolding != null)
			{
				base.StopCoroutine(this.m_coroutineTalkButtonTestHolding);
			}
			this.m_coroutineTalkButtonTestHolding = base.StartCoroutine(this.OnTalkButtonTestHoding());
		}

		// Token: 0x0600C4E4 RID: 50404 RVA: 0x00367EEC File Offset: 0x003660EC
		[DebuggerHidden]
		private IEnumerator OnTalkButtonTestHoding()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonTestHoding_hotfix != null)
			{
				return (IEnumerator)this.m_OnTalkButtonTestHoding_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUIController.<OnTalkButtonTestHoding>c__Iterator0 <OnTalkButtonTestHoding>c__Iterator = new ChatUIController.<OnTalkButtonTestHoding>c__Iterator0();
			<OnTalkButtonTestHoding>c__Iterator.$this = this;
			return <OnTalkButtonTestHoding>c__Iterator;
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x00367F68 File Offset: 0x00366168
		private void OnTalkButtonClickUp(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonClickUpGameObject_hotfix != null)
			{
				this.m_OnTalkButtonClickUpGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_coroutineTalkButtonTestHolding != null)
			{
				base.StopCoroutine(this.m_coroutineTalkButtonTestHolding);
				this.m_coroutineTalkButtonTestHolding = null;
			}
			if (this.EventOnTalkButtonClickUp != null)
			{
				this.EventOnTalkButtonClickUp();
			}
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x0036800C File Offset: 0x0036620C
		private void OnExitTalkButton(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitTalkButtonGameObject_hotfix != null)
			{
				this.m_OnExitTalkButtonGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExitTalkButtonClick != null)
			{
				this.EventOnExitTalkButtonClick();
			}
		}

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x00368094 File Offset: 0x00366294
		private void OnEnterTalkButton(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnterTalkButtonGameObject_hotfix != null)
			{
				this.m_OnEnterTalkButtonGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnEnterTalkButtonClick != null)
			{
				this.EventOnEnterTalkButtonClick();
			}
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x0036811C File Offset: 0x0036631C
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
			if (this.EventOnSendButtonClick != null && this.InputPanel.text.Length != 0)
			{
				this.EventOnSendButtonClick(this.InputPanel.text);
			}
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x003681B4 File Offset: 0x003663B4
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
			this.BGButton.interactable = false;
			if (this.EventOnCloseButtonClick != null)
			{
				CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
				component.SetActionForUIStateFinshed("Close", delegate
				{
					this.EventOnCloseButtonClick();
				});
				component.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600C4EA RID: 50410 RVA: 0x0036825C File Offset: 0x0036645C
		private void OnTableSelected(Button currentButton)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTableSelectedButton_hotfix != null)
			{
				this.m_OnTableSelectedButton_hotfix.call(new object[]
				{
					this,
					currentButton
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatChannel chatChannel = ChatChannel.World;
			if (currentButton == this.WorldButton)
			{
				chatChannel = ChatChannel.World;
			}
			else if (currentButton == this.SystemButton)
			{
				chatChannel = ChatChannel.Sys;
			}
			else if (currentButton == this.TeamButton)
			{
				chatChannel = ChatChannel.Team;
			}
			else if (currentButton == this.GroupButton)
			{
				chatChannel = ChatChannel.Group;
			}
			else if (currentButton == this.PrivateButton)
			{
				chatChannel = ChatChannel.Private;
			}
			else if (currentButton == this.GuildButton)
			{
				if (string.IsNullOrEmpty(this.m_playerContext.GetGuildId()))
				{
					string value = this.m_configDataLoader.GetConfigDataStringTable(2012).Value;
					CommonUIController.Instance.ShowMessage(value, 2f, null, true);
					return;
				}
				chatChannel = ChatChannel.Guild;
			}
			this.CantInputObj.SetActive(currentButton == this.SystemButton);
			if (this.m_lastSelectButton != null)
			{
				this.m_lastSelectButton.GetComponent<CommonUIStateController>().SetToUIState("Normal", false, true);
			}
			currentButton.GetComponent<CommonUIStateController>().SetToUIState("Selected", false, true);
			if (this.m_lastSelectButton == this.GuildButton || currentButton == this.GuildButton)
			{
				this.m_playerContext.RefreshGuildChatLastReadTime();
			}
			this.m_currentChannel = chatChannel;
			this.m_lastSelectButton = currentButton;
			if (this.EventOnTableChange != null)
			{
				this.EventOnTableChange(chatChannel);
			}
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x00368440 File Offset: 0x00366640
		private void OnChatTargetChanged(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatTargetChangedInt32_hotfix != null)
			{
				this.m_OnChatTargetChangedInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChatTargetChanged != null && index - 1 >= 0)
			{
				this.EventOnChatTargetChanged(this.m_currentTableType, this.m_idList[index - 1], this.m_nameList[index - 1]);
			}
		}

		// Token: 0x0600C4EC RID: 50412 RVA: 0x003684F4 File Offset: 0x003666F4
		private void OnChooseTargetRootClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChooseTargetRootClick_hotfix != null)
			{
				this.m_OnChooseTargetRootClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RefreshDropDownList(this.m_currentTableType);
		}

		// Token: 0x0600C4ED RID: 50413 RVA: 0x00368560 File Offset: 0x00366760
		private void OnChangeRoomButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeRoomButtonClick_hotfix != null)
			{
				this.m_OnChangeRoomButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RoomInput.ActivateInputField();
		}

		// Token: 0x0600C4EE RID: 50414 RVA: 0x003685CC File Offset: 0x003667CC
		public void RefreshDropDownList(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshDropDownListChatChannel_hotfix != null)
			{
				this.m_RefreshDropDownListChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform transform = this.ChatTargetChooseDropdown.transform.Find("Dropdown List");
			Transform transform2 = transform.Find("Content");
			Transform child = transform2.GetChild(1);
			if (child != null)
			{
				child.GetComponent<Toggle>().interactable = false;
				Image component = child.Find("Detail").Find("ChatIcon").Find("Image").GetComponent<Image>();
				Color color = new Color(component.color.r, component.color.g, component.color.b, 0f);
				component.color = color;
				GameObject gameObject = GameObjectUtility.FindGameObjectByName(child, "UnRead");
				gameObject.SetActive(false);
			}
			for (int i = 0; i < this.m_idList.Count; i++)
			{
				int num = 0;
				if (channel != ChatChannel.Group)
				{
					if (channel == ChatChannel.Private)
					{
						num = this.m_playerContext.GetAssignPrivateUnreadChatMsgCount(this.m_idList[i]);
					}
				}
				else
				{
					num = this.m_playerContext.GetAssignGroupUnreadChatMsgCount(this.m_idList[i]);
				}
				Transform child2 = transform2.GetChild(i + 2);
				Text text = GameObjectUtility.FindComponentByName<Text>(child2, "UnreadText");
				GameObject gameObject2 = GameObjectUtility.FindGameObjectByName(child2, "UnRead");
				if (num > 0)
				{
					gameObject2.SetActive(true);
					if (num > 99)
					{
						num = 99;
					}
					text.text = num.ToString();
				}
				else
				{
					gameObject2.SetActive(false);
				}
			}
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x003687D4 File Offset: 0x003669D4
		private void InputPanel_OnEndEdit(string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InputPanel_OnEndEditString_hotfix != null)
			{
				this.m_InputPanel_OnEndEditString_hotfix.call(new object[]
				{
					this,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (str.Length > 50)
			{
				this.InputPanel.text = str.Substring(0, 50);
			}
		}

		// Token: 0x0600C4F0 RID: 50416 RVA: 0x00368868 File Offset: 0x00366A68
		public void ShowOrHidePanel(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOrHidePanelBoolean_hotfix != null)
			{
				this.m_ShowOrHidePanelBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState((!isShow) ? "Close" : "Show", false, true);
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x00368904 File Offset: 0x00366B04
		public void ShowNewChatTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNewChatTip_hotfix != null)
			{
				this.m_ShowNewChatTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.NewChatTip.gameObject.SetActive(true);
		}

		// Token: 0x0600C4F2 RID: 50418 RVA: 0x00368978 File Offset: 0x00366B78
		public void InputFieldTextAppend(string appendStr)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InputFieldTextAppendString_hotfix != null)
			{
				this.m_InputFieldTextAppendString_hotfix.call(new object[]
				{
					this,
					appendStr
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!string.IsNullOrEmpty(appendStr))
			{
				this.InputPanel.text = string.Format("{0}{1}", this.InputPanel.text, appendStr);
			}
		}

		// Token: 0x0600C4F3 RID: 50419 RVA: 0x00368A14 File Offset: 0x00366C14
		public void UpdateChatList(List<ChatComponent.ChatMessageClient> currentChatList, ChatChannel channel, bool isRefill, bool isScroll = false, bool hasNew = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChatListList`1ChatChannelBooleanBooleanBoolean_hotfix != null)
			{
				this.m_UpdateChatListList`1ChatChannelBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					currentChatList,
					channel,
					isRefill,
					isScroll,
					hasNew
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currentTableType != channel)
			{
				if (channel == ChatChannel.Group || channel == ChatChannel.Private)
				{
					this.ViewPort.offsetMin = new Vector2(this.ViewPort.offsetMin.x, 104f);
				}
				else
				{
					this.ViewPort.offsetMin = new Vector2(this.ViewPort.offsetMin.x, 0f);
				}
			}
			this.m_currentTableType = channel;
			this.m_currentChatList = currentChatList;
			this.ScrollView.totalCount = this.m_currentChatList.Count;
			if (isRefill)
			{
				this.ScrollView.RefillCellsFromEnd(isScroll);
			}
			this.EnableRoomIdShow(this.m_currentTableType == ChatChannel.World);
			this.SetRoomIdTip(this.m_playerContext.GetRoomIndex() + 1);
			this.BGButton.interactable = true;
			this.m_lastUpdateChatInfoListMaxIndex = this.m_currentChatList.Count - 1;
		}

		// Token: 0x0600C4F4 RID: 50420 RVA: 0x00368BAC File Offset: 0x00366DAC
		public void UpdateChatCacheInfo(List<ChatComponent.ChatMessageClient> chatInfoList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChatCacheInfoList`1_hotfix != null)
			{
				this.m_UpdateChatCacheInfoList`1_hotfix.call(new object[]
				{
					this,
					chatInfoList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollView.totalCount = chatInfoList.Count;
			this.m_currentChatList = chatInfoList;
			this.m_lastUpdateChatInfoListMaxIndex = chatInfoList.Count - 1;
		}

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00368C44 File Offset: 0x00366E44
		public bool GetChannelToggleSelectState(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChannelToggleSelectStateChatChannel_hotfix != null)
			{
				return Convert.ToBoolean(this.m_GetChannelToggleSelectStateChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currentChannel == channel;
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x00368CD0 File Offset: 0x00366ED0
		public void SetChannelToggleSelected(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChannelToggleSelectedChatChannel_hotfix != null)
			{
				this.m_SetChannelToggleSelectedChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Button button = this.FindChannelButton(channel);
			if (button != null)
			{
				this.OnTableSelected(button);
			}
			switch (channel)
			{
			case ChatChannel.World:
				this.OnTableSelected(this.WorldButton);
				break;
			case ChatChannel.Sys:
				this.OnTableSelected(this.SystemButton);
				break;
			case ChatChannel.Team:
				this.OnTableSelected(this.TeamButton);
				break;
			case ChatChannel.Group:
				this.OnTableSelected(this.GroupButton);
				break;
			case ChatChannel.Private:
				this.OnTableSelected(this.PrivateButton);
				break;
			case ChatChannel.Guild:
				this.OnTableSelected(this.GuildButton);
				break;
			}
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x00368DEC File Offset: 0x00366FEC
		public bool IsScrollViewInEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsScrollViewInEnd_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsScrollViewInEnd_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.ScrollView.normalizedPosition.y < 0f)
			{
				return true;
			}
			GameObject lastGameObjectInViewRect = this.ScrollView.GetLastGameObjectInViewRect();
			if (lastGameObjectInViewRect == null)
			{
				return true;
			}
			int itemIndex = lastGameObjectInViewRect.GetComponent<ScrollItemBaseUIController>().ItemIndex;
			return itemIndex >= this.m_lastUpdateChatInfoListMaxIndex;
		}

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x00368EAC File Offset: 0x003670AC
		public void UpdateChooseChatPlayerOrGroupListInfo(ChatChannel channel, List<string> idList, List<string> nameList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChooseChatPlayerOrGroupListInfoChatChannelList`1List`1_hotfix != null)
			{
				this.m_UpdateChooseChatPlayerOrGroupListInfoChatChannelList`1List`1_hotfix.call(new object[]
				{
					this,
					channel,
					idList,
					nameList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_idList = idList;
			this.m_nameList = nameList;
			this.m_currentTableType = channel;
			List<Dropdown.OptionData> list = new List<Dropdown.OptionData>();
			Dropdown.OptionData optionData = new Dropdown.OptionData();
			if (channel == ChatChannel.Group)
			{
				optionData.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_ChooseGroupTip);
			}
			else if (channel == ChatChannel.Private)
			{
				optionData.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_ChoosePrivatePlayerTip);
			}
			list.Add(optionData);
			int value = 0;
			for (int i = 0; i < idList.Count; i++)
			{
				if (channel == ChatChannel.Group)
				{
					if (idList[i] == this.m_playerContext.GetGroupChatId())
					{
						value = i + 1;
					}
				}
				else if (channel == ChatChannel.Private && idList[i] == this.m_playerContext.GetPrivateChatPlayerId())
				{
					value = i + 1;
				}
				list.Add(new Dropdown.OptionData
				{
					text = nameList[i]
				});
			}
			this.ChatTargetChooseDropdown.ClearOptions();
			this.ChatTargetChooseDropdown.AddOptions(list);
			this.ChatTargetChooseDropdown.value = value;
			string text = this.PlayerNameLabel.text;
			int num = text.LastIndexOf(' ');
			if (num != -1)
			{
				this.PlayerNameLabel.text = text.Substring(0, num);
			}
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x00369084 File Offset: 0x00367284
		public void ShowOrHideChooseChatTargetPannel(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOrHideChooseChatTargetPannelBoolean_hotfix != null)
			{
				this.m_ShowOrHideChooseChatTargetPannelBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ChooseListRoot.SetActive(isShow);
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x00369100 File Offset: 0x00367300
		public void SetTalkButtonSize(Vector2 size)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTalkButtonSizeVector2_hotfix != null)
			{
				this.m_SetTalkButtonSizeVector2_hotfix.call(new object[]
				{
					this,
					size
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rectTransform = this.TalkButton.transform as RectTransform;
			rectTransform.sizeDelta = size;
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x00369188 File Offset: 0x00367388
		public void ShowVoiceRecordTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceRecordTip_hotfix != null)
			{
				this.m_ShowVoiceRecordTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Send", false, true);
		}

		// Token: 0x0600C4FC RID: 50428 RVA: 0x003691FC File Offset: 0x003673FC
		public void HideVoiceRecordTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideVoiceRecordTip_hotfix != null)
			{
				this.m_HideVoiceRecordTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Hide", false, true);
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x00369270 File Offset: 0x00367470
		public void ShowVoiceCancelTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceCancelTip_hotfix != null)
			{
				this.m_ShowVoiceCancelTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Cancel", false, true);
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x003692E4 File Offset: 0x003674E4
		public void ShowVoiceShortTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceShortTip_hotfix != null)
			{
				this.m_ShowVoiceShortTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Short", false, true);
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x00369358 File Offset: 0x00367558
		public void UpdateVoiceRecordTime(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateVoiceRecordTimeSingle_hotfix != null)
			{
				this.m_UpdateVoiceRecordTimeSingle_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (time > 20f)
			{
				time = 20f;
			}
			if (time < 0f)
			{
				time = 0f;
			}
			this.recordTimeProgressBar.fillAmount = 1f - time / 20f;
			this.voiceTimeText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_VoiceRecordCountDownTip), (int)(20f - time));
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x00369434 File Offset: 0x00367634
		public void RegItemButtonClickEvent(Action<ChatComponent.ChatMessageClient> voiceClickAction, Action<ChatMessage, GameObject> playerIconClickAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegItemButtonClickEventAction`1Action`2_hotfix != null)
			{
				this.m_RegItemButtonClickEventAction`1Action`2_hotfix.call(new object[]
				{
					this,
					voiceClickAction,
					playerIconClickAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemVoiceButtonClickEvent = voiceClickAction;
			this.m_itemPlayerIconClickEvent = playerIconClickAction;
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x003694C4 File Offset: 0x003676C4
		public void SetRoomIdTip(int roomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRoomIdTipInt32_hotfix != null)
			{
				this.m_SetRoomIdTipInt32_hotfix.call(new object[]
				{
					this,
					roomId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RoomIDShowText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_CurrentWorldRoom), roomId);
			this.RoomInput.text = string.Empty;
		}

		// Token: 0x0600C502 RID: 50434 RVA: 0x0036956C File Offset: 0x0036776C
		public void EnableRoomIdShow(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableRoomIdShowBoolean_hotfix != null)
			{
				this.m_EnableRoomIdShowBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RoomIdShowRoot.SetActive(isShow);
		}

		// Token: 0x0600C503 RID: 50435 RVA: 0x003695E8 File Offset: 0x003677E8
		public void CloseAllTableRedMark()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAllTableRedMark_hotfix != null)
			{
				this.m_CloseAllTableRedMark_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_redMarkObjs.Count; i++)
			{
				this.m_redMarkObjs[i].SetActive(false);
			}
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x00369678 File Offset: 0x00367878
		public void SetTableRedMark(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTableRedMarkChatChannel_hotfix != null)
			{
				this.m_SetTableRedMarkChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_redMarkObjs[(int)channel].SetActive(true);
		}

		// Token: 0x0600C505 RID: 50437 RVA: 0x003696FC File Offset: 0x003678FC
		public void ClearChatContent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearChatContent_hotfix != null)
			{
				this.m_ClearChatContent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InputPanel.text = string.Empty;
			this.Placeholder.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_InputLengthLimit);
			IEnumerator enumerator = this.ContentText.transform.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					Transform transform = (Transform)obj;
					transform.gameObject.SetActive(false);
				}
			}
			finally
			{
				IDisposable disposable;
				if ((disposable = (enumerator as IDisposable)) != null)
				{
					disposable.Dispose();
				}
			}
		}

		// Token: 0x0600C506 RID: 50438 RVA: 0x003697EC File Offset: 0x003679EC
		private void OnChatItemFill(UIControllerBase uCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatItemFillUIControllerBase_hotfix != null)
			{
				this.m_OnChatItemFillUIControllerBase_hotfix.call(new object[]
				{
					this,
					uCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ScrollItemBaseUIController scrollItemBaseUIController = uCtrl as ScrollItemBaseUIController;
			int itemIndex = scrollItemBaseUIController.ItemIndex;
			if (itemIndex < this.m_currentChatList.Count)
			{
				ChatComponent.ChatMessageClient chatMessageClient = this.m_currentChatList[itemIndex];
				ChatItemManagerController component = uCtrl.GetComponent<ChatItemManagerController>();
				string showChatItemPoolName4Info = this.GetShowChatItemPoolName4Info(chatMessageClient.ChatMessageInfo);
				if (!component.IsHasNeedChatItemPrefab(showChatItemPoolName4Info))
				{
					if (component.m_childPrefab != null)
					{
						this.m_objPool.ReturnObjectToPool(component.m_childPrefab);
					}
					GameObject objectFromPool = this.m_objPool.GetObjectFromPool(showChatItemPoolName4Info);
					if (objectFromPool != null)
					{
						objectFromPool.transform.SetParent(component.transform, false);
						component.m_childPrefabPoolName = showChatItemPoolName4Info;
						component.m_childPrefab = objectFromPool;
					}
				}
				switch (chatMessageClient.ChatMessageInfo.ChannelId)
				{
				case ChatChannel.World:
				case ChatChannel.Team:
				case ChatChannel.Group:
				case ChatChannel.Private:
				case ChatChannel.Guild:
					if (chatMessageClient.ChatMessageInfo.ChatSrcType == ChatSrcType.ChannelLocalSys)
					{
						SystemChatItemUIController component2 = component.m_childPrefab.GetComponent<SystemChatItemUIController>();
						component2.UpdateChatInfo(chatMessageClient);
					}
					else
					{
						PlayerChatItemUIController component3 = component.m_childPrefab.GetComponent<PlayerChatItemUIController>();
						component3.RegClickEvent(this.m_itemVoiceButtonClickEvent, this.m_itemPlayerIconClickEvent);
						if (!component3.m_isEmojiTextInit)
						{
							GameObject assetInContainer = base.GetAssetInContainer<GameObject>("EmojiShowImage");
							SmallExpressionParseDesc component4 = base.GetComponent<SmallExpressionParseDesc>();
							component3.InitEmojiText(component4.m_emSpace, assetInContainer.GetComponent<Image>());
						}
						component3.UpdateChatInfo(chatMessageClient, false);
					}
					break;
				case ChatChannel.Sys:
				{
					SystemChatItemUIController component5 = component.m_childPrefab.GetComponent<SystemChatItemUIController>();
					component5.UpdateChatInfo(chatMessageClient);
					break;
				}
				}
				component.gameObject.SetActive(true);
				LayoutRebuilder.ForceRebuildLayoutImmediate(this.ScrollView.content);
			}
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x00369A08 File Offset: 0x00367C08
		private string GetShowChatItemPoolName4Info(ChatMessage chatInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetShowChatItemPoolName4InfoChatMessage_hotfix != null)
			{
				return (string)this.m_GetShowChatItemPoolName4InfoChatMessage_hotfix.call(new object[]
				{
					this,
					chatInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (chatInfo.ChannelId)
			{
			case ChatChannel.World:
			case ChatChannel.Team:
			case ChatChannel.Group:
			case ChatChannel.Private:
			case ChatChannel.Guild:
				if (this.m_playerContext.IsMe(chatInfo.SrcGameUserID))
				{
					return "WorldRightPool";
				}
				if (chatInfo.ChatSrcType == ChatSrcType.ChannelLocalSys)
				{
					return "SystemPool";
				}
				return "WorldLeftPool";
			case ChatChannel.Sys:
				return "SystemPool";
			default:
				return string.Empty;
			}
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x00369AF4 File Offset: 0x00367CF4
		private void SetScrollViewToBottom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetScrollViewToBottom_hotfix != null)
			{
				this.m_SetScrollViewToBottom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollView.RefillCellsFromEnd(false);
		}

		// Token: 0x0600C509 RID: 50441 RVA: 0x00369B60 File Offset: 0x00367D60
		public Button FindChannelButton(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindChannelButtonChatChannel_hotfix != null)
			{
				return (Button)this.m_FindChannelButtonChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Button result = null;
			switch (channel)
			{
			case ChatChannel.World:
				result = this.WorldButton;
				break;
			case ChatChannel.Sys:
				result = this.SystemButton;
				break;
			case ChatChannel.Team:
				result = this.TeamButton;
				break;
			case ChatChannel.Group:
				result = this.GroupButton;
				break;
			case ChatChannel.Private:
				result = this.PrivateButton;
				break;
			case ChatChannel.Guild:
				result = this.GuildButton;
				break;
			}
			return result;
		}

		// Token: 0x1400025A RID: 602
		// (add) Token: 0x0600C50A RID: 50442 RVA: 0x00369C50 File Offset: 0x00367E50
		// (remove) Token: 0x0600C50B RID: 50443 RVA: 0x00369CEC File Offset: 0x00367EEC
		public event Action<ChatChannel> EventOnTableChange
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTableChangeAction`1_hotfix != null)
				{
					this.m_add_EventOnTableChangeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatChannel> action = this.EventOnTableChange;
				Action<ChatChannel> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatChannel>>(ref this.EventOnTableChange, (Action<ChatChannel>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTableChangeAction`1_hotfix != null)
				{
					this.m_remove_EventOnTableChangeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatChannel> action = this.EventOnTableChange;
				Action<ChatChannel> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatChannel>>(ref this.EventOnTableChange, (Action<ChatChannel>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400025B RID: 603
		// (add) Token: 0x0600C50C RID: 50444 RVA: 0x00369D88 File Offset: 0x00367F88
		// (remove) Token: 0x0600C50D RID: 50445 RVA: 0x00369E24 File Offset: 0x00368024
		public event Action<string> EventOnSendButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSendButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSendButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSendButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSendButtonClick, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSendButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSendButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSendButtonClick;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSendButtonClick, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400025C RID: 604
		// (add) Token: 0x0600C50E RID: 50446 RVA: 0x00369EC0 File Offset: 0x003680C0
		// (remove) Token: 0x0600C50F RID: 50447 RVA: 0x00369F5C File Offset: 0x0036815C
		public event Action EventOnCloseButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400025D RID: 605
		// (add) Token: 0x0600C510 RID: 50448 RVA: 0x00369FF8 File Offset: 0x003681F8
		// (remove) Token: 0x0600C511 RID: 50449 RVA: 0x0036A094 File Offset: 0x00368294
		public event Action EventOnExpressionFunctionButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExpressionFunctionButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnExpressionFunctionButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExpressionFunctionButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExpressionFunctionButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExpressionFunctionButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnExpressionFunctionButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExpressionFunctionButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExpressionFunctionButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400025E RID: 606
		// (add) Token: 0x0600C512 RID: 50450 RVA: 0x0036A130 File Offset: 0x00368330
		// (remove) Token: 0x0600C513 RID: 50451 RVA: 0x0036A1CC File Offset: 0x003683CC
		public event Action<string> EventOnRoomIdInputEnd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRoomIdInputEndAction`1_hotfix != null)
				{
					this.m_add_EventOnRoomIdInputEndAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnRoomIdInputEnd;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnRoomIdInputEnd, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRoomIdInputEndAction`1_hotfix != null)
				{
					this.m_remove_EventOnRoomIdInputEndAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnRoomIdInputEnd;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnRoomIdInputEnd, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400025F RID: 607
		// (add) Token: 0x0600C514 RID: 50452 RVA: 0x0036A268 File Offset: 0x00368468
		// (remove) Token: 0x0600C515 RID: 50453 RVA: 0x0036A304 File Offset: 0x00368504
		public event Action EventOnTalkButtonHold
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTalkButtonHoldAction_hotfix != null)
				{
					this.m_add_EventOnTalkButtonHoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonHold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonHold, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTalkButtonHoldAction_hotfix != null)
				{
					this.m_remove_EventOnTalkButtonHoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonHold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonHold, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000260 RID: 608
		// (add) Token: 0x0600C516 RID: 50454 RVA: 0x0036A3A0 File Offset: 0x003685A0
		// (remove) Token: 0x0600C517 RID: 50455 RVA: 0x0036A43C File Offset: 0x0036863C
		public event Action EventOnTalkButtonClickUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTalkButtonClickUpAction_hotfix != null)
				{
					this.m_add_EventOnTalkButtonClickUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonClickUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonClickUp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTalkButtonClickUpAction_hotfix != null)
				{
					this.m_remove_EventOnTalkButtonClickUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonClickUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonClickUp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000261 RID: 609
		// (add) Token: 0x0600C518 RID: 50456 RVA: 0x0036A4D8 File Offset: 0x003686D8
		// (remove) Token: 0x0600C519 RID: 50457 RVA: 0x0036A574 File Offset: 0x00368774
		public event Action EventOnExitTalkButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExitTalkButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnExitTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExitTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExitTalkButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExitTalkButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnExitTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExitTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExitTalkButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000262 RID: 610
		// (add) Token: 0x0600C51A RID: 50458 RVA: 0x0036A610 File Offset: 0x00368810
		// (remove) Token: 0x0600C51B RID: 50459 RVA: 0x0036A6AC File Offset: 0x003688AC
		public event Action EventOnEnterTalkButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnterTalkButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnEnterTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterTalkButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnterTalkButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnEnterTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterTalkButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000263 RID: 611
		// (add) Token: 0x0600C51C RID: 50460 RVA: 0x0036A748 File Offset: 0x00368948
		// (remove) Token: 0x0600C51D RID: 50461 RVA: 0x0036A7E4 File Offset: 0x003689E4
		public event Action<ChatChannel, string, string> EventOnChatTargetChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChatTargetChangedAction`3_hotfix != null)
				{
					this.m_add_EventOnChatTargetChangedAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatChannel, string, string> action = this.EventOnChatTargetChanged;
				Action<ChatChannel, string, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatChannel, string, string>>(ref this.EventOnChatTargetChanged, (Action<ChatChannel, string, string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChatTargetChangedAction`3_hotfix != null)
				{
					this.m_remove_EventOnChatTargetChangedAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatChannel, string, string> action = this.EventOnChatTargetChanged;
				Action<ChatChannel, string, string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatChannel, string, string>>(ref this.EventOnChatTargetChanged, (Action<ChatChannel, string, string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x0600C51E RID: 50462 RVA: 0x0036A880 File Offset: 0x00368A80
		// (set) Token: 0x0600C51F RID: 50463 RVA: 0x0036A8F4 File Offset: 0x00368AF4
		public ChatComponent.ChatMessageClient CurrPlayVoiceMsg
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CurrPlayVoiceMsg_hotfix != null)
				{
					return (ChatComponent.ChatMessageClient)this.m_get_CurrPlayVoiceMsg_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_currPlayVoiceMsg;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CurrPlayVoiceMsgChatMessageClient_hotfix != null)
				{
					this.m_set_CurrPlayVoiceMsgChatMessageClient_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_currPlayVoiceMsg = value;
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x0600C520 RID: 50464 RVA: 0x0036A96C File Offset: 0x00368B6C
		// (set) Token: 0x0600C521 RID: 50465 RVA: 0x0036A98C File Offset: 0x00368B8C
		[DoNotToLua]
		public new ChatUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C522 RID: 50466 RVA: 0x0036A998 File Offset: 0x00368B98
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C523 RID: 50467 RVA: 0x0036A9A4 File Offset: 0x00368BA4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x0036A9AC File Offset: 0x00368BAC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x0036A9B4 File Offset: 0x00368BB4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C526 RID: 50470 RVA: 0x0036A9C8 File Offset: 0x00368BC8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C527 RID: 50471 RVA: 0x0036A9D0 File Offset: 0x00368BD0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C528 RID: 50472 RVA: 0x0036A9DC File Offset: 0x00368BDC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C529 RID: 50473 RVA: 0x0036A9E8 File Offset: 0x00368BE8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x0036A9F4 File Offset: 0x00368BF4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x0036AA00 File Offset: 0x00368C00
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C52C RID: 50476 RVA: 0x0036AA0C File Offset: 0x00368C0C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x0036AA18 File Offset: 0x00368C18
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x0036AA24 File Offset: 0x00368C24
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x0036AA30 File Offset: 0x00368C30
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C530 RID: 50480 RVA: 0x0036AA3C File Offset: 0x00368C3C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C531 RID: 50481 RVA: 0x0036AA44 File Offset: 0x00368C44
		private void __callDele_EventOnTableChange(ChatChannel obj)
		{
			Action<ChatChannel> eventOnTableChange = this.EventOnTableChange;
			if (eventOnTableChange != null)
			{
				eventOnTableChange(obj);
			}
		}

		// Token: 0x0600C532 RID: 50482 RVA: 0x0036AA68 File Offset: 0x00368C68
		private void __clearDele_EventOnTableChange(ChatChannel obj)
		{
			this.EventOnTableChange = null;
		}

		// Token: 0x0600C533 RID: 50483 RVA: 0x0036AA74 File Offset: 0x00368C74
		private void __callDele_EventOnSendButtonClick(string obj)
		{
			Action<string> eventOnSendButtonClick = this.EventOnSendButtonClick;
			if (eventOnSendButtonClick != null)
			{
				eventOnSendButtonClick(obj);
			}
		}

		// Token: 0x0600C534 RID: 50484 RVA: 0x0036AA98 File Offset: 0x00368C98
		private void __clearDele_EventOnSendButtonClick(string obj)
		{
			this.EventOnSendButtonClick = null;
		}

		// Token: 0x0600C535 RID: 50485 RVA: 0x0036AAA4 File Offset: 0x00368CA4
		private void __callDele_EventOnCloseButtonClick()
		{
			Action eventOnCloseButtonClick = this.EventOnCloseButtonClick;
			if (eventOnCloseButtonClick != null)
			{
				eventOnCloseButtonClick();
			}
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x0036AAC4 File Offset: 0x00368CC4
		private void __clearDele_EventOnCloseButtonClick()
		{
			this.EventOnCloseButtonClick = null;
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x0036AAD0 File Offset: 0x00368CD0
		private void __callDele_EventOnExpressionFunctionButtonClick()
		{
			Action eventOnExpressionFunctionButtonClick = this.EventOnExpressionFunctionButtonClick;
			if (eventOnExpressionFunctionButtonClick != null)
			{
				eventOnExpressionFunctionButtonClick();
			}
		}

		// Token: 0x0600C538 RID: 50488 RVA: 0x0036AAF0 File Offset: 0x00368CF0
		private void __clearDele_EventOnExpressionFunctionButtonClick()
		{
			this.EventOnExpressionFunctionButtonClick = null;
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x0036AAFC File Offset: 0x00368CFC
		private void __callDele_EventOnRoomIdInputEnd(string obj)
		{
			Action<string> eventOnRoomIdInputEnd = this.EventOnRoomIdInputEnd;
			if (eventOnRoomIdInputEnd != null)
			{
				eventOnRoomIdInputEnd(obj);
			}
		}

		// Token: 0x0600C53A RID: 50490 RVA: 0x0036AB20 File Offset: 0x00368D20
		private void __clearDele_EventOnRoomIdInputEnd(string obj)
		{
			this.EventOnRoomIdInputEnd = null;
		}

		// Token: 0x0600C53B RID: 50491 RVA: 0x0036AB2C File Offset: 0x00368D2C
		private void __callDele_EventOnTalkButtonHold()
		{
			Action eventOnTalkButtonHold = this.EventOnTalkButtonHold;
			if (eventOnTalkButtonHold != null)
			{
				eventOnTalkButtonHold();
			}
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x0036AB4C File Offset: 0x00368D4C
		private void __clearDele_EventOnTalkButtonHold()
		{
			this.EventOnTalkButtonHold = null;
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x0036AB58 File Offset: 0x00368D58
		private void __callDele_EventOnTalkButtonClickUp()
		{
			Action eventOnTalkButtonClickUp = this.EventOnTalkButtonClickUp;
			if (eventOnTalkButtonClickUp != null)
			{
				eventOnTalkButtonClickUp();
			}
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x0036AB78 File Offset: 0x00368D78
		private void __clearDele_EventOnTalkButtonClickUp()
		{
			this.EventOnTalkButtonClickUp = null;
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x0036AB84 File Offset: 0x00368D84
		private void __callDele_EventOnExitTalkButtonClick()
		{
			Action eventOnExitTalkButtonClick = this.EventOnExitTalkButtonClick;
			if (eventOnExitTalkButtonClick != null)
			{
				eventOnExitTalkButtonClick();
			}
		}

		// Token: 0x0600C540 RID: 50496 RVA: 0x0036ABA4 File Offset: 0x00368DA4
		private void __clearDele_EventOnExitTalkButtonClick()
		{
			this.EventOnExitTalkButtonClick = null;
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x0036ABB0 File Offset: 0x00368DB0
		private void __callDele_EventOnEnterTalkButtonClick()
		{
			Action eventOnEnterTalkButtonClick = this.EventOnEnterTalkButtonClick;
			if (eventOnEnterTalkButtonClick != null)
			{
				eventOnEnterTalkButtonClick();
			}
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x0036ABD0 File Offset: 0x00368DD0
		private void __clearDele_EventOnEnterTalkButtonClick()
		{
			this.EventOnEnterTalkButtonClick = null;
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x0036ABDC File Offset: 0x00368DDC
		private void __callDele_EventOnChatTargetChanged(ChatChannel arg1, string arg2, string arg3)
		{
			Action<ChatChannel, string, string> eventOnChatTargetChanged = this.EventOnChatTargetChanged;
			if (eventOnChatTargetChanged != null)
			{
				eventOnChatTargetChanged(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x0036AC00 File Offset: 0x00368E00
		private void __clearDele_EventOnChatTargetChanged(ChatChannel arg1, string arg2, string arg3)
		{
			this.EventOnChatTargetChanged = null;
		}

		// Token: 0x0600C545 RID: 50501 RVA: 0x0036AC0C File Offset: 0x00368E0C
		private void __callDele_m_itemVoiceButtonClickEvent(ChatComponent.ChatMessageClient obj)
		{
			Action<ChatComponent.ChatMessageClient> itemVoiceButtonClickEvent = this.m_itemVoiceButtonClickEvent;
			if (itemVoiceButtonClickEvent != null)
			{
				itemVoiceButtonClickEvent(obj);
			}
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x0036AC30 File Offset: 0x00368E30
		private void __clearDele_m_itemVoiceButtonClickEvent(ChatComponent.ChatMessageClient obj)
		{
			this.m_itemVoiceButtonClickEvent = null;
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x0036AC3C File Offset: 0x00368E3C
		private void __callDele_m_itemPlayerIconClickEvent(ChatMessage arg1, GameObject arg2)
		{
			Action<ChatMessage, GameObject> itemPlayerIconClickEvent = this.m_itemPlayerIconClickEvent;
			if (itemPlayerIconClickEvent != null)
			{
				itemPlayerIconClickEvent(arg1, arg2);
			}
		}

		// Token: 0x0600C548 RID: 50504 RVA: 0x0036AC60 File Offset: 0x00368E60
		private void __clearDele_m_itemPlayerIconClickEvent(ChatMessage arg1, GameObject arg2)
		{
			this.m_itemPlayerIconClickEvent = null;
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x0036ACE4 File Offset: 0x00368EE4
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
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnRoomIdInputEndString_hotfix = (luaObj.RawGet("OnRoomIdInputEnd") as LuaFunction);
					this.m_OnExpressionFunctionButtonClick_hotfix = (luaObj.RawGet("OnExpressionFunctionButtonClick") as LuaFunction);
					this.m_OnTalkButtonClickDownGameObject_hotfix = (luaObj.RawGet("OnTalkButtonClickDown") as LuaFunction);
					this.m_OnTalkButtonTestHoding_hotfix = (luaObj.RawGet("OnTalkButtonTestHoding") as LuaFunction);
					this.m_OnTalkButtonClickUpGameObject_hotfix = (luaObj.RawGet("OnTalkButtonClickUp") as LuaFunction);
					this.m_OnExitTalkButtonGameObject_hotfix = (luaObj.RawGet("OnExitTalkButton") as LuaFunction);
					this.m_OnEnterTalkButtonGameObject_hotfix = (luaObj.RawGet("OnEnterTalkButton") as LuaFunction);
					this.m_OnSendButtonClick_hotfix = (luaObj.RawGet("OnSendButtonClick") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnTableSelectedButton_hotfix = (luaObj.RawGet("OnTableSelected") as LuaFunction);
					this.m_OnChatTargetChangedInt32_hotfix = (luaObj.RawGet("OnChatTargetChanged") as LuaFunction);
					this.m_OnChooseTargetRootClick_hotfix = (luaObj.RawGet("OnChooseTargetRootClick") as LuaFunction);
					this.m_OnChangeRoomButtonClick_hotfix = (luaObj.RawGet("OnChangeRoomButtonClick") as LuaFunction);
					this.m_RefreshDropDownListChatChannel_hotfix = (luaObj.RawGet("RefreshDropDownList") as LuaFunction);
					this.m_InputPanel_OnEndEditString_hotfix = (luaObj.RawGet("InputPanel_OnEndEdit") as LuaFunction);
					this.m_ShowOrHidePanelBoolean_hotfix = (luaObj.RawGet("ShowOrHidePanel") as LuaFunction);
					this.m_ShowNewChatTip_hotfix = (luaObj.RawGet("ShowNewChatTip") as LuaFunction);
					this.m_InputFieldTextAppendString_hotfix = (luaObj.RawGet("InputFieldTextAppend") as LuaFunction);
					this.m_UpdateChatListList`1ChatChannelBooleanBooleanBoolean_hotfix = (luaObj.RawGet("UpdateChatList") as LuaFunction);
					this.m_UpdateChatCacheInfoList`1_hotfix = (luaObj.RawGet("UpdateChatCacheInfo") as LuaFunction);
					this.m_GetChannelToggleSelectStateChatChannel_hotfix = (luaObj.RawGet("GetChannelToggleSelectState") as LuaFunction);
					this.m_SetChannelToggleSelectedChatChannel_hotfix = (luaObj.RawGet("SetChannelToggleSelected") as LuaFunction);
					this.m_IsScrollViewInEnd_hotfix = (luaObj.RawGet("IsScrollViewInEnd") as LuaFunction);
					this.m_UpdateChooseChatPlayerOrGroupListInfoChatChannelList`1List`1_hotfix = (luaObj.RawGet("UpdateChooseChatPlayerOrGroupListInfo") as LuaFunction);
					this.m_ShowOrHideChooseChatTargetPannelBoolean_hotfix = (luaObj.RawGet("ShowOrHideChooseChatTargetPannel") as LuaFunction);
					this.m_SetTalkButtonSizeVector2_hotfix = (luaObj.RawGet("SetTalkButtonSize") as LuaFunction);
					this.m_ShowVoiceRecordTip_hotfix = (luaObj.RawGet("ShowVoiceRecordTip") as LuaFunction);
					this.m_HideVoiceRecordTip_hotfix = (luaObj.RawGet("HideVoiceRecordTip") as LuaFunction);
					this.m_ShowVoiceCancelTip_hotfix = (luaObj.RawGet("ShowVoiceCancelTip") as LuaFunction);
					this.m_ShowVoiceShortTip_hotfix = (luaObj.RawGet("ShowVoiceShortTip") as LuaFunction);
					this.m_UpdateVoiceRecordTimeSingle_hotfix = (luaObj.RawGet("UpdateVoiceRecordTime") as LuaFunction);
					this.m_RegItemButtonClickEventAction`1Action`2_hotfix = (luaObj.RawGet("RegItemButtonClickEvent") as LuaFunction);
					this.m_SetRoomIdTipInt32_hotfix = (luaObj.RawGet("SetRoomIdTip") as LuaFunction);
					this.m_EnableRoomIdShowBoolean_hotfix = (luaObj.RawGet("EnableRoomIdShow") as LuaFunction);
					this.m_CloseAllTableRedMark_hotfix = (luaObj.RawGet("CloseAllTableRedMark") as LuaFunction);
					this.m_SetTableRedMarkChatChannel_hotfix = (luaObj.RawGet("SetTableRedMark") as LuaFunction);
					this.m_ClearChatContent_hotfix = (luaObj.RawGet("ClearChatContent") as LuaFunction);
					this.m_OnChatItemFillUIControllerBase_hotfix = (luaObj.RawGet("OnChatItemFill") as LuaFunction);
					this.m_GetShowChatItemPoolName4InfoChatMessage_hotfix = (luaObj.RawGet("GetShowChatItemPoolName4Info") as LuaFunction);
					this.m_SetScrollViewToBottom_hotfix = (luaObj.RawGet("SetScrollViewToBottom") as LuaFunction);
					this.m_FindChannelButtonChatChannel_hotfix = (luaObj.RawGet("FindChannelButton") as LuaFunction);
					this.m_add_EventOnTableChangeAction`1_hotfix = (luaObj.RawGet("add_EventOnTableChange") as LuaFunction);
					this.m_remove_EventOnTableChangeAction`1_hotfix = (luaObj.RawGet("remove_EventOnTableChange") as LuaFunction);
					this.m_add_EventOnSendButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSendButtonClick") as LuaFunction);
					this.m_remove_EventOnSendButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSendButtonClick") as LuaFunction);
					this.m_add_EventOnCloseButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnCloseButtonClick") as LuaFunction);
					this.m_remove_EventOnCloseButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnCloseButtonClick") as LuaFunction);
					this.m_add_EventOnExpressionFunctionButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnExpressionFunctionButtonClick") as LuaFunction);
					this.m_remove_EventOnExpressionFunctionButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnExpressionFunctionButtonClick") as LuaFunction);
					this.m_add_EventOnRoomIdInputEndAction`1_hotfix = (luaObj.RawGet("add_EventOnRoomIdInputEnd") as LuaFunction);
					this.m_remove_EventOnRoomIdInputEndAction`1_hotfix = (luaObj.RawGet("remove_EventOnRoomIdInputEnd") as LuaFunction);
					this.m_add_EventOnTalkButtonHoldAction_hotfix = (luaObj.RawGet("add_EventOnTalkButtonHold") as LuaFunction);
					this.m_remove_EventOnTalkButtonHoldAction_hotfix = (luaObj.RawGet("remove_EventOnTalkButtonHold") as LuaFunction);
					this.m_add_EventOnTalkButtonClickUpAction_hotfix = (luaObj.RawGet("add_EventOnTalkButtonClickUp") as LuaFunction);
					this.m_remove_EventOnTalkButtonClickUpAction_hotfix = (luaObj.RawGet("remove_EventOnTalkButtonClickUp") as LuaFunction);
					this.m_add_EventOnExitTalkButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnExitTalkButtonClick") as LuaFunction);
					this.m_remove_EventOnExitTalkButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnExitTalkButtonClick") as LuaFunction);
					this.m_add_EventOnEnterTalkButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnEnterTalkButtonClick") as LuaFunction);
					this.m_remove_EventOnEnterTalkButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnEnterTalkButtonClick") as LuaFunction);
					this.m_add_EventOnChatTargetChangedAction`3_hotfix = (luaObj.RawGet("add_EventOnChatTargetChanged") as LuaFunction);
					this.m_remove_EventOnChatTargetChangedAction`3_hotfix = (luaObj.RawGet("remove_EventOnChatTargetChanged") as LuaFunction);
					this.m_get_CurrPlayVoiceMsg_hotfix = (luaObj.RawGet("get_CurrPlayVoiceMsg") as LuaFunction);
					this.m_set_CurrPlayVoiceMsgChatMessageClient_hotfix = (luaObj.RawGet("set_CurrPlayVoiceMsg") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C552 RID: 50514 RVA: 0x0036B3F0 File Offset: 0x003695F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007C9E RID: 31902
		private bool m_InputFocused;

		// Token: 0x04007C9F RID: 31903
		private Action<ChatComponent.ChatMessageClient> m_itemVoiceButtonClickEvent;

		// Token: 0x04007CA0 RID: 31904
		private Action<ChatMessage, GameObject> m_itemPlayerIconClickEvent;

		// Token: 0x04007CA1 RID: 31905
		private ChatChannel m_currentTableType = ChatChannel.Private;

		// Token: 0x04007CA2 RID: 31906
		private List<ChatComponent.ChatMessageClient> m_currentChatList = new List<ChatComponent.ChatMessageClient>();

		// Token: 0x04007CA3 RID: 31907
		private List<GameObject> m_redMarkObjs = new List<GameObject>();

		// Token: 0x04007CA4 RID: 31908
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04007CAB RID: 31915
		private Coroutine m_coroutineTalkButtonTestHolding;

		// Token: 0x04007CB0 RID: 31920
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007CB1 RID: 31921
		private int m_lastUpdateChatInfoListMaxIndex;

		// Token: 0x04007CB2 RID: 31922
		private List<string> m_idList;

		// Token: 0x04007CB3 RID: 31923
		private List<string> m_nameList;

		// Token: 0x04007CB4 RID: 31924
		private ChatComponent.ChatMessageClient m_currPlayVoiceMsg;

		// Token: 0x04007CB5 RID: 31925
		private ChatChannel m_currentChannel;

		// Token: 0x04007CB6 RID: 31926
		private Button m_lastSelectButton;

		// Token: 0x04007CB7 RID: 31927
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04007CB8 RID: 31928
		[AutoBind("./ChatPanel/ChatDetail/RoomIDInput/InputField", AutoBindAttribute.InitState.NotInit, false)]
		public InputField RoomInput;

		// Token: 0x04007CB9 RID: 31929
		[AutoBind("./ChatPanel/ChatDetail/RoomIDInput/InputField/Placeholder", AutoBindAttribute.InitState.NotInit, false)]
		public Text RoomIDShowText;

		// Token: 0x04007CBA RID: 31930
		[AutoBind("./ChatPanel/ChatDetail/RoomIDInput/InputField/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text RoomRequireIDText;

		// Token: 0x04007CBB RID: 31931
		[AutoBind("./ChatPanel/ChatDetail/RoomIDInput", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject RoomIdShowRoot;

		// Token: 0x04007CBC RID: 31932
		[AutoBind("./ChatPanel/ChatDetail/RoomIDInput/ChangeRoomButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ChangeRoomButton;

		// Token: 0x04007CBD RID: 31933
		[AutoBind("./ChatPanel/SoundMessage/Send/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text voiceTimeText;

		// Token: 0x04007CBE RID: 31934
		[AutoBind("./ChatPanel/SoundMessage", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController voiceRecordStateUICtrl;

		// Token: 0x04007CBF RID: 31935
		[AutoBind("./ChatPanel/SoundMessage/Send/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		public Image recordTimeProgressBar;

		// Token: 0x04007CC0 RID: 31936
		[AutoBind("./ChatPanel/ChatDetail/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		public EasyObjectPool m_objPool;

		// Token: 0x04007CC1 RID: 31937
		[AutoBind("./ChatPanel/ChatDetail/UnusedRoot", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject UnusedRoot;

		// Token: 0x04007CC2 RID: 31938
		[AutoBind("./ChatPanel/ChatDetail/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject ListScrollViewContent;

		// Token: 0x04007CC3 RID: 31939
		[AutoBind("./ChatPanel/ChatDetail/ListScrollView/", AutoBindAttribute.InitState.NotInit, false)]
		public ChatLoopVerticalScrollRect ScrollView;

		// Token: 0x04007CC4 RID: 31940
		[AutoBind("./ChatPanel/ChatDetail/ListScrollView/Viewport", AutoBindAttribute.InitState.NotInit, false)]
		public RectTransform ViewPort;

		// Token: 0x04007CC5 RID: 31941
		[AutoBind("./ChatPanel/ChannelPanel/WorldToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Button WorldButton;

		// Token: 0x04007CC6 RID: 31942
		[AutoBind("./ChatPanel/ChannelPanel/SystemToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Button SystemButton;

		// Token: 0x04007CC7 RID: 31943
		[AutoBind("./ChatPanel/ChannelPanel/TeamToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Button TeamButton;

		// Token: 0x04007CC8 RID: 31944
		[AutoBind("./ChatPanel/ChannelPanel/GroupToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Button GroupButton;

		// Token: 0x04007CC9 RID: 31945
		[AutoBind("./ChatPanel/ChannelPanel/PrivateToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Button PrivateButton;

		// Token: 0x04007CCA RID: 31946
		[AutoBind("./ChatPanel/ChannelPanel/SociatyToggle", AutoBindAttribute.InitState.NotInit, false)]
		public Button GuildButton;

		// Token: 0x04007CCB RID: 31947
		[AutoBind("./ChatPanel/ChannelPanel/WorldToggle/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject WorldToggleRedMark;

		// Token: 0x04007CCC RID: 31948
		[AutoBind("./ChatPanel/ChannelPanel/SystemToggle/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject SystemToggleRedMark;

		// Token: 0x04007CCD RID: 31949
		[AutoBind("./ChatPanel/ChannelPanel/TeamToggle/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject TeamToggleRedMark;

		// Token: 0x04007CCE RID: 31950
		[AutoBind("./ChatPanel/ChannelPanel/GroupToggle/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject GroupToggleRedMark;

		// Token: 0x04007CCF RID: 31951
		[AutoBind("./ChatPanel/ChannelPanel/PrivateToggle/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject PrivateToggleRedMark;

		// Token: 0x04007CD0 RID: 31952
		[AutoBind("./ChatPanel/ChannelPanel/SociatyToggle/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject GuildToggleRedMark;

		// Token: 0x04007CD1 RID: 31953
		[AutoBind("./ChatPanel/CloseBtn", AutoBindAttribute.InitState.NotInit, false)]
		public Button CloseButton;

		// Token: 0x04007CD2 RID: 31954
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button BGButton;

		// Token: 0x04007CD3 RID: 31955
		[AutoBind("./EmptyPanel", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject EmptyPanel;

		// Token: 0x04007CD4 RID: 31956
		[AutoBind("./ChatPanel/NewChatTip", AutoBindAttribute.InitState.NotInit, false)]
		public Button NewChatTip;

		// Token: 0x04007CD5 RID: 31957
		[AutoBind("./ChatPanel/InputPanel/TalkButtonImage/TalkButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button TalkButton;

		// Token: 0x04007CD6 RID: 31958
		[AutoBind("./ChatPanel/InputPanel/EmoticonButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button ExpressionFunctionButton;

		// Token: 0x04007CD7 RID: 31959
		[AutoBind("./ChatPanel/InputPanel/InputField", AutoBindAttribute.InitState.NotInit, false)]
		public InputField InputPanel;

		// Token: 0x04007CD8 RID: 31960
		[AutoBind("./ChatPanel/InputPanel/InputField/Placeholder", AutoBindAttribute.InitState.NotInit, false)]
		public Text Placeholder;

		// Token: 0x04007CD9 RID: 31961
		[AutoBind("./ChatPanel/InputPanel/InputField/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text ContentText;

		// Token: 0x04007CDA RID: 31962
		[AutoBind("./ChatPanel/InputPanel/SendButton", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx SendButton;

		// Token: 0x04007CDB RID: 31963
		[AutoBind("./ChatPanel/InputPanel/CantInput", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject CantInputObj;

		// Token: 0x04007CDC RID: 31964
		[AutoBind("./ChatPanel/ChatDetail/PrivatePlayerChoose", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject ChooseListRoot;

		// Token: 0x04007CDD RID: 31965
		[AutoBind("./ChatPanel/ChatDetail/PrivatePlayerChoose", AutoBindAttribute.InitState.NotInit, false)]
		public Dropdown ChatTargetChooseDropdown;

		// Token: 0x04007CDE RID: 31966
		[AutoBind("./ChatPanel/ChatDetail/PrivatePlayerChoose/Label", AutoBindAttribute.InitState.NotInit, false)]
		public Text PlayerNameLabel;

		// Token: 0x04007CDF RID: 31967
		private const string emojiInfoTxtName = "EmojiUnicodeInfo";

		// Token: 0x04007CE0 RID: 31968
		private const string emojiShowAssetName = "EmojiShowImage";

		// Token: 0x04007CE1 RID: 31969
		private const string ChatManagerItem = "ChatManagerItem";

		// Token: 0x04007CE2 RID: 31970
		private const string LeftWorldChatItem = "WorldChatItemLeft";

		// Token: 0x04007CE3 RID: 31971
		private const string RightWorldChatItem = "WorldChatItemRight";

		// Token: 0x04007CE4 RID: 31972
		private const string LeftSystemChatItem = "SystemChatItem";

		// Token: 0x04007CE5 RID: 31973
		private const string ChatManagerItemPoolName = "ChatManagerPool";

		// Token: 0x04007CE6 RID: 31974
		private const string LeftWorldChatItemPoolName = "WorldLeftPool";

		// Token: 0x04007CE7 RID: 31975
		private const string RightWorldChatItemPoolName = "WorldRightPool";

		// Token: 0x04007CE8 RID: 31976
		private const string LeftSystemChatItemPoolName = "SystemPool";

		// Token: 0x04007CE9 RID: 31977
		[DoNotToLua]
		private ChatUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007CEA RID: 31978
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007CEB RID: 31979
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007CEC RID: 31980
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007CED RID: 31981
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007CEE RID: 31982
		private LuaFunction m_OnRoomIdInputEndString_hotfix;

		// Token: 0x04007CEF RID: 31983
		private LuaFunction m_OnExpressionFunctionButtonClick_hotfix;

		// Token: 0x04007CF0 RID: 31984
		private LuaFunction m_OnTalkButtonClickDownGameObject_hotfix;

		// Token: 0x04007CF1 RID: 31985
		private LuaFunction m_OnTalkButtonTestHoding_hotfix;

		// Token: 0x04007CF2 RID: 31986
		private LuaFunction m_OnTalkButtonClickUpGameObject_hotfix;

		// Token: 0x04007CF3 RID: 31987
		private LuaFunction m_OnExitTalkButtonGameObject_hotfix;

		// Token: 0x04007CF4 RID: 31988
		private LuaFunction m_OnEnterTalkButtonGameObject_hotfix;

		// Token: 0x04007CF5 RID: 31989
		private LuaFunction m_OnSendButtonClick_hotfix;

		// Token: 0x04007CF6 RID: 31990
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x04007CF7 RID: 31991
		private LuaFunction m_OnTableSelectedButton_hotfix;

		// Token: 0x04007CF8 RID: 31992
		private LuaFunction m_OnChatTargetChangedInt32_hotfix;

		// Token: 0x04007CF9 RID: 31993
		private LuaFunction m_OnChooseTargetRootClick_hotfix;

		// Token: 0x04007CFA RID: 31994
		private LuaFunction m_OnChangeRoomButtonClick_hotfix;

		// Token: 0x04007CFB RID: 31995
		private LuaFunction m_RefreshDropDownListChatChannel_hotfix;

		// Token: 0x04007CFC RID: 31996
		private LuaFunction m_InputPanel_OnEndEditString_hotfix;

		// Token: 0x04007CFD RID: 31997
		private LuaFunction m_ShowOrHidePanelBoolean_hotfix;

		// Token: 0x04007CFE RID: 31998
		private LuaFunction m_ShowNewChatTip_hotfix;

		// Token: 0x04007CFF RID: 31999
		private LuaFunction m_InputFieldTextAppendString_hotfix;

		// Token: 0x04007D00 RID: 32000
		private LuaFunction m_UpdateChatListList;

		// Token: 0x04007D01 RID: 32001
		private LuaFunction m_UpdateChatCacheInfoList;

		// Token: 0x04007D02 RID: 32002
		private LuaFunction m_GetChannelToggleSelectStateChatChannel_hotfix;

		// Token: 0x04007D03 RID: 32003
		private LuaFunction m_SetChannelToggleSelectedChatChannel_hotfix;

		// Token: 0x04007D04 RID: 32004
		private LuaFunction m_IsScrollViewInEnd_hotfix;

		// Token: 0x04007D05 RID: 32005
		private LuaFunction m_UpdateChooseChatPlayerOrGroupListInfoChatChannelList`1List;

		// Token: 0x04007D06 RID: 32006
		private LuaFunction m_ShowOrHideChooseChatTargetPannelBoolean_hotfix;

		// Token: 0x04007D07 RID: 32007
		private LuaFunction m_SetTalkButtonSizeVector2_hotfix;

		// Token: 0x04007D08 RID: 32008
		private LuaFunction m_ShowVoiceRecordTip_hotfix;

		// Token: 0x04007D09 RID: 32009
		private LuaFunction m_HideVoiceRecordTip_hotfix;

		// Token: 0x04007D0A RID: 32010
		private LuaFunction m_ShowVoiceCancelTip_hotfix;

		// Token: 0x04007D0B RID: 32011
		private LuaFunction m_ShowVoiceShortTip_hotfix;

		// Token: 0x04007D0C RID: 32012
		private LuaFunction m_UpdateVoiceRecordTimeSingle_hotfix;

		// Token: 0x04007D0D RID: 32013
		private LuaFunction m_RegItemButtonClickEventAction`1Action;

		// Token: 0x04007D0E RID: 32014
		private LuaFunction m_SetRoomIdTipInt32_hotfix;

		// Token: 0x04007D0F RID: 32015
		private LuaFunction m_EnableRoomIdShowBoolean_hotfix;

		// Token: 0x04007D10 RID: 32016
		private LuaFunction m_CloseAllTableRedMark_hotfix;

		// Token: 0x04007D11 RID: 32017
		private LuaFunction m_SetTableRedMarkChatChannel_hotfix;

		// Token: 0x04007D12 RID: 32018
		private LuaFunction m_ClearChatContent_hotfix;

		// Token: 0x04007D13 RID: 32019
		private LuaFunction m_OnChatItemFillUIControllerBase_hotfix;

		// Token: 0x04007D14 RID: 32020
		private LuaFunction m_GetShowChatItemPoolName4InfoChatMessage_hotfix;

		// Token: 0x04007D15 RID: 32021
		private LuaFunction m_SetScrollViewToBottom_hotfix;

		// Token: 0x04007D16 RID: 32022
		private LuaFunction m_FindChannelButtonChatChannel_hotfix;

		// Token: 0x04007D17 RID: 32023
		private LuaFunction m_add_EventOnTableChangeAction;

		// Token: 0x04007D18 RID: 32024
		private LuaFunction m_remove_EventOnTableChangeAction;

		// Token: 0x04007D19 RID: 32025
		private LuaFunction m_add_EventOnSendButtonClickAction;

		// Token: 0x04007D1A RID: 32026
		private LuaFunction m_remove_EventOnSendButtonClickAction;

		// Token: 0x04007D1B RID: 32027
		private LuaFunction m_add_EventOnCloseButtonClickAction_hotfix;

		// Token: 0x04007D1C RID: 32028
		private LuaFunction m_remove_EventOnCloseButtonClickAction_hotfix;

		// Token: 0x04007D1D RID: 32029
		private LuaFunction m_add_EventOnExpressionFunctionButtonClickAction_hotfix;

		// Token: 0x04007D1E RID: 32030
		private LuaFunction m_remove_EventOnExpressionFunctionButtonClickAction_hotfix;

		// Token: 0x04007D1F RID: 32031
		private LuaFunction m_add_EventOnRoomIdInputEndAction;

		// Token: 0x04007D20 RID: 32032
		private LuaFunction m_remove_EventOnRoomIdInputEndAction;

		// Token: 0x04007D21 RID: 32033
		private LuaFunction m_add_EventOnTalkButtonHoldAction_hotfix;

		// Token: 0x04007D22 RID: 32034
		private LuaFunction m_remove_EventOnTalkButtonHoldAction_hotfix;

		// Token: 0x04007D23 RID: 32035
		private LuaFunction m_add_EventOnTalkButtonClickUpAction_hotfix;

		// Token: 0x04007D24 RID: 32036
		private LuaFunction m_remove_EventOnTalkButtonClickUpAction_hotfix;

		// Token: 0x04007D25 RID: 32037
		private LuaFunction m_add_EventOnExitTalkButtonClickAction_hotfix;

		// Token: 0x04007D26 RID: 32038
		private LuaFunction m_remove_EventOnExitTalkButtonClickAction_hotfix;

		// Token: 0x04007D27 RID: 32039
		private LuaFunction m_add_EventOnEnterTalkButtonClickAction_hotfix;

		// Token: 0x04007D28 RID: 32040
		private LuaFunction m_remove_EventOnEnterTalkButtonClickAction_hotfix;

		// Token: 0x04007D29 RID: 32041
		private LuaFunction m_add_EventOnChatTargetChangedAction;

		// Token: 0x04007D2A RID: 32042
		private LuaFunction m_remove_EventOnChatTargetChangedAction;

		// Token: 0x04007D2B RID: 32043
		private LuaFunction m_get_CurrPlayVoiceMsg_hotfix;

		// Token: 0x04007D2C RID: 32044
		private LuaFunction m_set_CurrPlayVoiceMsgChatMessageClient_hotfix;

		// Token: 0x02000B52 RID: 2898
		public new class LuaExportHelper
		{
			// Token: 0x0600C553 RID: 50515 RVA: 0x0036B458 File Offset: 0x00369658
			public LuaExportHelper(ChatUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C554 RID: 50516 RVA: 0x0036B468 File Offset: 0x00369668
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C555 RID: 50517 RVA: 0x0036B478 File Offset: 0x00369678
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C556 RID: 50518 RVA: 0x0036B488 File Offset: 0x00369688
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C557 RID: 50519 RVA: 0x0036B498 File Offset: 0x00369698
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C558 RID: 50520 RVA: 0x0036B4B0 File Offset: 0x003696B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C559 RID: 50521 RVA: 0x0036B4C0 File Offset: 0x003696C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C55A RID: 50522 RVA: 0x0036B4D0 File Offset: 0x003696D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C55B RID: 50523 RVA: 0x0036B4E0 File Offset: 0x003696E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C55C RID: 50524 RVA: 0x0036B4F0 File Offset: 0x003696F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C55D RID: 50525 RVA: 0x0036B500 File Offset: 0x00369700
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C55E RID: 50526 RVA: 0x0036B510 File Offset: 0x00369710
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C55F RID: 50527 RVA: 0x0036B520 File Offset: 0x00369720
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C560 RID: 50528 RVA: 0x0036B530 File Offset: 0x00369730
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C561 RID: 50529 RVA: 0x0036B540 File Offset: 0x00369740
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C562 RID: 50530 RVA: 0x0036B550 File Offset: 0x00369750
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C563 RID: 50531 RVA: 0x0036B560 File Offset: 0x00369760
			public void __callDele_EventOnTableChange(ChatChannel obj)
			{
				this.m_owner.__callDele_EventOnTableChange(obj);
			}

			// Token: 0x0600C564 RID: 50532 RVA: 0x0036B570 File Offset: 0x00369770
			public void __clearDele_EventOnTableChange(ChatChannel obj)
			{
				this.m_owner.__clearDele_EventOnTableChange(obj);
			}

			// Token: 0x0600C565 RID: 50533 RVA: 0x0036B580 File Offset: 0x00369780
			public void __callDele_EventOnSendButtonClick(string obj)
			{
				this.m_owner.__callDele_EventOnSendButtonClick(obj);
			}

			// Token: 0x0600C566 RID: 50534 RVA: 0x0036B590 File Offset: 0x00369790
			public void __clearDele_EventOnSendButtonClick(string obj)
			{
				this.m_owner.__clearDele_EventOnSendButtonClick(obj);
			}

			// Token: 0x0600C567 RID: 50535 RVA: 0x0036B5A0 File Offset: 0x003697A0
			public void __callDele_EventOnCloseButtonClick()
			{
				this.m_owner.__callDele_EventOnCloseButtonClick();
			}

			// Token: 0x0600C568 RID: 50536 RVA: 0x0036B5B0 File Offset: 0x003697B0
			public void __clearDele_EventOnCloseButtonClick()
			{
				this.m_owner.__clearDele_EventOnCloseButtonClick();
			}

			// Token: 0x0600C569 RID: 50537 RVA: 0x0036B5C0 File Offset: 0x003697C0
			public void __callDele_EventOnExpressionFunctionButtonClick()
			{
				this.m_owner.__callDele_EventOnExpressionFunctionButtonClick();
			}

			// Token: 0x0600C56A RID: 50538 RVA: 0x0036B5D0 File Offset: 0x003697D0
			public void __clearDele_EventOnExpressionFunctionButtonClick()
			{
				this.m_owner.__clearDele_EventOnExpressionFunctionButtonClick();
			}

			// Token: 0x0600C56B RID: 50539 RVA: 0x0036B5E0 File Offset: 0x003697E0
			public void __callDele_EventOnRoomIdInputEnd(string obj)
			{
				this.m_owner.__callDele_EventOnRoomIdInputEnd(obj);
			}

			// Token: 0x0600C56C RID: 50540 RVA: 0x0036B5F0 File Offset: 0x003697F0
			public void __clearDele_EventOnRoomIdInputEnd(string obj)
			{
				this.m_owner.__clearDele_EventOnRoomIdInputEnd(obj);
			}

			// Token: 0x0600C56D RID: 50541 RVA: 0x0036B600 File Offset: 0x00369800
			public void __callDele_EventOnTalkButtonHold()
			{
				this.m_owner.__callDele_EventOnTalkButtonHold();
			}

			// Token: 0x0600C56E RID: 50542 RVA: 0x0036B610 File Offset: 0x00369810
			public void __clearDele_EventOnTalkButtonHold()
			{
				this.m_owner.__clearDele_EventOnTalkButtonHold();
			}

			// Token: 0x0600C56F RID: 50543 RVA: 0x0036B620 File Offset: 0x00369820
			public void __callDele_EventOnTalkButtonClickUp()
			{
				this.m_owner.__callDele_EventOnTalkButtonClickUp();
			}

			// Token: 0x0600C570 RID: 50544 RVA: 0x0036B630 File Offset: 0x00369830
			public void __clearDele_EventOnTalkButtonClickUp()
			{
				this.m_owner.__clearDele_EventOnTalkButtonClickUp();
			}

			// Token: 0x0600C571 RID: 50545 RVA: 0x0036B640 File Offset: 0x00369840
			public void __callDele_EventOnExitTalkButtonClick()
			{
				this.m_owner.__callDele_EventOnExitTalkButtonClick();
			}

			// Token: 0x0600C572 RID: 50546 RVA: 0x0036B650 File Offset: 0x00369850
			public void __clearDele_EventOnExitTalkButtonClick()
			{
				this.m_owner.__clearDele_EventOnExitTalkButtonClick();
			}

			// Token: 0x0600C573 RID: 50547 RVA: 0x0036B660 File Offset: 0x00369860
			public void __callDele_EventOnEnterTalkButtonClick()
			{
				this.m_owner.__callDele_EventOnEnterTalkButtonClick();
			}

			// Token: 0x0600C574 RID: 50548 RVA: 0x0036B670 File Offset: 0x00369870
			public void __clearDele_EventOnEnterTalkButtonClick()
			{
				this.m_owner.__clearDele_EventOnEnterTalkButtonClick();
			}

			// Token: 0x0600C575 RID: 50549 RVA: 0x0036B680 File Offset: 0x00369880
			public void __callDele_EventOnChatTargetChanged(ChatChannel arg1, string arg2, string arg3)
			{
				this.m_owner.__callDele_EventOnChatTargetChanged(arg1, arg2, arg3);
			}

			// Token: 0x0600C576 RID: 50550 RVA: 0x0036B690 File Offset: 0x00369890
			public void __clearDele_EventOnChatTargetChanged(ChatChannel arg1, string arg2, string arg3)
			{
				this.m_owner.__clearDele_EventOnChatTargetChanged(arg1, arg2, arg3);
			}

			// Token: 0x0600C577 RID: 50551 RVA: 0x0036B6A0 File Offset: 0x003698A0
			public void __callDele_m_itemVoiceButtonClickEvent(ChatComponent.ChatMessageClient obj)
			{
				this.m_owner.__callDele_m_itemVoiceButtonClickEvent(obj);
			}

			// Token: 0x0600C578 RID: 50552 RVA: 0x0036B6B0 File Offset: 0x003698B0
			public void __clearDele_m_itemVoiceButtonClickEvent(ChatComponent.ChatMessageClient obj)
			{
				this.m_owner.__clearDele_m_itemVoiceButtonClickEvent(obj);
			}

			// Token: 0x0600C579 RID: 50553 RVA: 0x0036B6C0 File Offset: 0x003698C0
			public void __callDele_m_itemPlayerIconClickEvent(ChatMessage arg1, GameObject arg2)
			{
				this.m_owner.__callDele_m_itemPlayerIconClickEvent(arg1, arg2);
			}

			// Token: 0x0600C57A RID: 50554 RVA: 0x0036B6D0 File Offset: 0x003698D0
			public void __clearDele_m_itemPlayerIconClickEvent(ChatMessage arg1, GameObject arg2)
			{
				this.m_owner.__clearDele_m_itemPlayerIconClickEvent(arg1, arg2);
			}

			// Token: 0x17002752 RID: 10066
			// (get) Token: 0x0600C57B RID: 50555 RVA: 0x0036B6E0 File Offset: 0x003698E0
			// (set) Token: 0x0600C57C RID: 50556 RVA: 0x0036B6F0 File Offset: 0x003698F0
			public bool m_InputFocused
			{
				get
				{
					return this.m_owner.m_InputFocused;
				}
				set
				{
					this.m_owner.m_InputFocused = value;
				}
			}

			// Token: 0x17002753 RID: 10067
			// (get) Token: 0x0600C57D RID: 50557 RVA: 0x0036B700 File Offset: 0x00369900
			// (set) Token: 0x0600C57E RID: 50558 RVA: 0x0036B710 File Offset: 0x00369910
			public Action<ChatComponent.ChatMessageClient> m_itemVoiceButtonClickEvent
			{
				get
				{
					return this.m_owner.m_itemVoiceButtonClickEvent;
				}
				set
				{
					this.m_owner.m_itemVoiceButtonClickEvent = value;
				}
			}

			// Token: 0x17002754 RID: 10068
			// (get) Token: 0x0600C57F RID: 50559 RVA: 0x0036B720 File Offset: 0x00369920
			// (set) Token: 0x0600C580 RID: 50560 RVA: 0x0036B730 File Offset: 0x00369930
			public Action<ChatMessage, GameObject> m_itemPlayerIconClickEvent
			{
				get
				{
					return this.m_owner.m_itemPlayerIconClickEvent;
				}
				set
				{
					this.m_owner.m_itemPlayerIconClickEvent = value;
				}
			}

			// Token: 0x17002755 RID: 10069
			// (get) Token: 0x0600C581 RID: 50561 RVA: 0x0036B740 File Offset: 0x00369940
			// (set) Token: 0x0600C582 RID: 50562 RVA: 0x0036B750 File Offset: 0x00369950
			public ChatChannel m_currentTableType
			{
				get
				{
					return this.m_owner.m_currentTableType;
				}
				set
				{
					this.m_owner.m_currentTableType = value;
				}
			}

			// Token: 0x17002756 RID: 10070
			// (get) Token: 0x0600C583 RID: 50563 RVA: 0x0036B760 File Offset: 0x00369960
			// (set) Token: 0x0600C584 RID: 50564 RVA: 0x0036B770 File Offset: 0x00369970
			public List<ChatComponent.ChatMessageClient> m_currentChatList
			{
				get
				{
					return this.m_owner.m_currentChatList;
				}
				set
				{
					this.m_owner.m_currentChatList = value;
				}
			}

			// Token: 0x17002757 RID: 10071
			// (get) Token: 0x0600C585 RID: 50565 RVA: 0x0036B780 File Offset: 0x00369980
			// (set) Token: 0x0600C586 RID: 50566 RVA: 0x0036B790 File Offset: 0x00369990
			public List<GameObject> m_redMarkObjs
			{
				get
				{
					return this.m_owner.m_redMarkObjs;
				}
				set
				{
					this.m_owner.m_redMarkObjs = value;
				}
			}

			// Token: 0x17002758 RID: 10072
			// (get) Token: 0x0600C587 RID: 50567 RVA: 0x0036B7A0 File Offset: 0x003699A0
			// (set) Token: 0x0600C588 RID: 50568 RVA: 0x0036B7B0 File Offset: 0x003699B0
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

			// Token: 0x17002759 RID: 10073
			// (get) Token: 0x0600C589 RID: 50569 RVA: 0x0036B7C0 File Offset: 0x003699C0
			// (set) Token: 0x0600C58A RID: 50570 RVA: 0x0036B7D0 File Offset: 0x003699D0
			public Coroutine m_coroutineTalkButtonTestHolding
			{
				get
				{
					return this.m_owner.m_coroutineTalkButtonTestHolding;
				}
				set
				{
					this.m_owner.m_coroutineTalkButtonTestHolding = value;
				}
			}

			// Token: 0x1700275A RID: 10074
			// (get) Token: 0x0600C58B RID: 50571 RVA: 0x0036B7E0 File Offset: 0x003699E0
			// (set) Token: 0x0600C58C RID: 50572 RVA: 0x0036B7F0 File Offset: 0x003699F0
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

			// Token: 0x1700275B RID: 10075
			// (get) Token: 0x0600C58D RID: 50573 RVA: 0x0036B800 File Offset: 0x00369A00
			// (set) Token: 0x0600C58E RID: 50574 RVA: 0x0036B810 File Offset: 0x00369A10
			public int m_lastUpdateChatInfoListMaxIndex
			{
				get
				{
					return this.m_owner.m_lastUpdateChatInfoListMaxIndex;
				}
				set
				{
					this.m_owner.m_lastUpdateChatInfoListMaxIndex = value;
				}
			}

			// Token: 0x1700275C RID: 10076
			// (get) Token: 0x0600C58F RID: 50575 RVA: 0x0036B820 File Offset: 0x00369A20
			// (set) Token: 0x0600C590 RID: 50576 RVA: 0x0036B830 File Offset: 0x00369A30
			public List<string> m_idList
			{
				get
				{
					return this.m_owner.m_idList;
				}
				set
				{
					this.m_owner.m_idList = value;
				}
			}

			// Token: 0x1700275D RID: 10077
			// (get) Token: 0x0600C591 RID: 50577 RVA: 0x0036B840 File Offset: 0x00369A40
			// (set) Token: 0x0600C592 RID: 50578 RVA: 0x0036B850 File Offset: 0x00369A50
			public List<string> m_nameList
			{
				get
				{
					return this.m_owner.m_nameList;
				}
				set
				{
					this.m_owner.m_nameList = value;
				}
			}

			// Token: 0x1700275E RID: 10078
			// (get) Token: 0x0600C593 RID: 50579 RVA: 0x0036B860 File Offset: 0x00369A60
			// (set) Token: 0x0600C594 RID: 50580 RVA: 0x0036B870 File Offset: 0x00369A70
			public ChatComponent.ChatMessageClient m_currPlayVoiceMsg
			{
				get
				{
					return this.m_owner.m_currPlayVoiceMsg;
				}
				set
				{
					this.m_owner.m_currPlayVoiceMsg = value;
				}
			}

			// Token: 0x1700275F RID: 10079
			// (get) Token: 0x0600C595 RID: 50581 RVA: 0x0036B880 File Offset: 0x00369A80
			// (set) Token: 0x0600C596 RID: 50582 RVA: 0x0036B890 File Offset: 0x00369A90
			public ChatChannel m_currentChannel
			{
				get
				{
					return this.m_owner.m_currentChannel;
				}
				set
				{
					this.m_owner.m_currentChannel = value;
				}
			}

			// Token: 0x17002760 RID: 10080
			// (get) Token: 0x0600C597 RID: 50583 RVA: 0x0036B8A0 File Offset: 0x00369AA0
			// (set) Token: 0x0600C598 RID: 50584 RVA: 0x0036B8B0 File Offset: 0x00369AB0
			public Button m_lastSelectButton
			{
				get
				{
					return this.m_owner.m_lastSelectButton;
				}
				set
				{
					this.m_owner.m_lastSelectButton = value;
				}
			}

			// Token: 0x17002761 RID: 10081
			// (get) Token: 0x0600C599 RID: 50585 RVA: 0x0036B8C0 File Offset: 0x00369AC0
			// (set) Token: 0x0600C59A RID: 50586 RVA: 0x0036B8D0 File Offset: 0x00369AD0
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

			// Token: 0x17002762 RID: 10082
			// (get) Token: 0x0600C59B RID: 50587 RVA: 0x0036B8E0 File Offset: 0x00369AE0
			public static string emojiInfoTxtName
			{
				get
				{
					return "EmojiUnicodeInfo";
				}
			}

			// Token: 0x17002763 RID: 10083
			// (get) Token: 0x0600C59C RID: 50588 RVA: 0x0036B8E8 File Offset: 0x00369AE8
			public static string emojiShowAssetName
			{
				get
				{
					return "EmojiShowImage";
				}
			}

			// Token: 0x17002764 RID: 10084
			// (get) Token: 0x0600C59D RID: 50589 RVA: 0x0036B8F0 File Offset: 0x00369AF0
			public static string ChatManagerItem
			{
				get
				{
					return "ChatManagerItem";
				}
			}

			// Token: 0x17002765 RID: 10085
			// (get) Token: 0x0600C59E RID: 50590 RVA: 0x0036B8F8 File Offset: 0x00369AF8
			public static string LeftWorldChatItem
			{
				get
				{
					return "WorldChatItemLeft";
				}
			}

			// Token: 0x17002766 RID: 10086
			// (get) Token: 0x0600C59F RID: 50591 RVA: 0x0036B900 File Offset: 0x00369B00
			public static string RightWorldChatItem
			{
				get
				{
					return "WorldChatItemRight";
				}
			}

			// Token: 0x17002767 RID: 10087
			// (get) Token: 0x0600C5A0 RID: 50592 RVA: 0x0036B908 File Offset: 0x00369B08
			public static string LeftSystemChatItem
			{
				get
				{
					return "SystemChatItem";
				}
			}

			// Token: 0x17002768 RID: 10088
			// (get) Token: 0x0600C5A1 RID: 50593 RVA: 0x0036B910 File Offset: 0x00369B10
			public static string ChatManagerItemPoolName
			{
				get
				{
					return "ChatManagerPool";
				}
			}

			// Token: 0x17002769 RID: 10089
			// (get) Token: 0x0600C5A2 RID: 50594 RVA: 0x0036B918 File Offset: 0x00369B18
			public static string LeftWorldChatItemPoolName
			{
				get
				{
					return "WorldLeftPool";
				}
			}

			// Token: 0x1700276A RID: 10090
			// (get) Token: 0x0600C5A3 RID: 50595 RVA: 0x0036B920 File Offset: 0x00369B20
			public static string RightWorldChatItemPoolName
			{
				get
				{
					return "WorldRightPool";
				}
			}

			// Token: 0x1700276B RID: 10091
			// (get) Token: 0x0600C5A4 RID: 50596 RVA: 0x0036B928 File Offset: 0x00369B28
			public static string LeftSystemChatItemPoolName
			{
				get
				{
					return "SystemPool";
				}
			}

			// Token: 0x0600C5A5 RID: 50597 RVA: 0x0036B930 File Offset: 0x00369B30
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C5A6 RID: 50598 RVA: 0x0036B940 File Offset: 0x00369B40
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600C5A7 RID: 50599 RVA: 0x0036B950 File Offset: 0x00369B50
			public void OnRoomIdInputEnd(string content)
			{
				this.m_owner.OnRoomIdInputEnd(content);
			}

			// Token: 0x0600C5A8 RID: 50600 RVA: 0x0036B960 File Offset: 0x00369B60
			public void OnExpressionFunctionButtonClick()
			{
				this.m_owner.OnExpressionFunctionButtonClick();
			}

			// Token: 0x0600C5A9 RID: 50601 RVA: 0x0036B970 File Offset: 0x00369B70
			public void OnTalkButtonClickDown(GameObject go)
			{
				this.m_owner.OnTalkButtonClickDown(go);
			}

			// Token: 0x0600C5AA RID: 50602 RVA: 0x0036B980 File Offset: 0x00369B80
			public IEnumerator OnTalkButtonTestHoding()
			{
				return this.m_owner.OnTalkButtonTestHoding();
			}

			// Token: 0x0600C5AB RID: 50603 RVA: 0x0036B990 File Offset: 0x00369B90
			public void OnTalkButtonClickUp(GameObject go)
			{
				this.m_owner.OnTalkButtonClickUp(go);
			}

			// Token: 0x0600C5AC RID: 50604 RVA: 0x0036B9A0 File Offset: 0x00369BA0
			public void OnExitTalkButton(GameObject go)
			{
				this.m_owner.OnExitTalkButton(go);
			}

			// Token: 0x0600C5AD RID: 50605 RVA: 0x0036B9B0 File Offset: 0x00369BB0
			public void OnEnterTalkButton(GameObject go)
			{
				this.m_owner.OnEnterTalkButton(go);
			}

			// Token: 0x0600C5AE RID: 50606 RVA: 0x0036B9C0 File Offset: 0x00369BC0
			public void OnSendButtonClick()
			{
				this.m_owner.OnSendButtonClick();
			}

			// Token: 0x0600C5AF RID: 50607 RVA: 0x0036B9D0 File Offset: 0x00369BD0
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x0600C5B0 RID: 50608 RVA: 0x0036B9E0 File Offset: 0x00369BE0
			public void OnTableSelected(Button currentButton)
			{
				this.m_owner.OnTableSelected(currentButton);
			}

			// Token: 0x0600C5B1 RID: 50609 RVA: 0x0036B9F0 File Offset: 0x00369BF0
			public void OnChatTargetChanged(int index)
			{
				this.m_owner.OnChatTargetChanged(index);
			}

			// Token: 0x0600C5B2 RID: 50610 RVA: 0x0036BA00 File Offset: 0x00369C00
			public void OnChooseTargetRootClick()
			{
				this.m_owner.OnChooseTargetRootClick();
			}

			// Token: 0x0600C5B3 RID: 50611 RVA: 0x0036BA10 File Offset: 0x00369C10
			public void OnChangeRoomButtonClick()
			{
				this.m_owner.OnChangeRoomButtonClick();
			}

			// Token: 0x0600C5B4 RID: 50612 RVA: 0x0036BA20 File Offset: 0x00369C20
			public void InputPanel_OnEndEdit(string str)
			{
				this.m_owner.InputPanel_OnEndEdit(str);
			}

			// Token: 0x0600C5B5 RID: 50613 RVA: 0x0036BA30 File Offset: 0x00369C30
			public void OnChatItemFill(UIControllerBase uCtrl)
			{
				this.m_owner.OnChatItemFill(uCtrl);
			}

			// Token: 0x0600C5B6 RID: 50614 RVA: 0x0036BA40 File Offset: 0x00369C40
			public string GetShowChatItemPoolName4Info(ChatMessage chatInfo)
			{
				return this.m_owner.GetShowChatItemPoolName4Info(chatInfo);
			}

			// Token: 0x0600C5B7 RID: 50615 RVA: 0x0036BA50 File Offset: 0x00369C50
			public void SetScrollViewToBottom()
			{
				this.m_owner.SetScrollViewToBottom();
			}

			// Token: 0x04007D2D RID: 32045
			private ChatUIController m_owner;
		}
	}
}
