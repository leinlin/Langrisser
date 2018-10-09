using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B54 RID: 2900
	[HotFix]
	public class ChatUITask : UITask
	{
		// Token: 0x0600C5BE RID: 50622 RVA: 0x0036BB18 File Offset: 0x00369D18
		public ChatUITask(string name) : base(name)
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

		// Token: 0x0600C5BF RID: 50623 RVA: 0x0036BC9C File Offset: 0x00369E9C
		public static ChatUITask StartChatUITaskWithNormalMode(UIIntent returnToIntent = null)
		{
			UIIntentReturnable intent = new UIIntentReturnable(returnToIntent, typeof(ChatUITask).Name, null);
			UITaskBase uitaskBase = UIManager.Instance.StartUITask(intent, false, false, null);
			if (uitaskBase == null)
			{
				global::Debug.LogError("StartChatUITaskWithNormalMode::StartUITask ChatUITask Fail !");
				return null;
			}
			return uitaskBase as ChatUITask;
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x0036BCE8 File Offset: 0x00369EE8
		public static ChatUITask StartChatUITaskToEnterAppointChannel(ChatChannel channel, UIIntent returnToIntent = null, string id = "")
		{
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(returnToIntent, typeof(ChatUITask).Name, null);
			uiintentReturnable.SetParam("AppointEnterChannel", channel);
			if (channel == ChatChannel.Private)
			{
				uiintentReturnable.SetParam("PrivateChatPlayerGameUserId", id);
			}
			else if (channel == ChatChannel.Group)
			{
				uiintentReturnable.SetParam("GroupChatId", id);
			}
			UITaskBase uitaskBase = UIManager.Instance.StartUITask(uiintentReturnable, false, false, null);
			if (uitaskBase == null)
			{
				global::Debug.LogError("StartChatUITaskToEnterPriavteChannel::StartUITask ChatUITask Fail !");
				return null;
			}
			return uitaskBase as ChatUITask;
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x0036BD70 File Offset: 0x00369F70
		public static void PauseUITask()
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ChatUITask));
			if (uitaskBase != null)
			{
				uitaskBase.Pause();
			}
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x0036BD9C File Offset: 0x00369F9C
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntent intent = intent2;
			ChatUITask $this = this;
			this.GetDataFromIntent(intent);
			Action action = delegate()
			{
				$this.m_currPipeLineCtx = $this.GetPipeLineCtx();
				VoiceRecordHelper.Instance.EventOnVoiceRecordTimeout += $this.OnVoiceRecordTimeout;
				$this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.IsInit);
				if (!$this.<OnStart>__BaseCallProxy0(intent))
				{
					global::Debug.LogError("MailStroeUITask base.OnStart fail");
				}
			};
			List<string> list = new List<string>();
			list.AddRange(this.m_playerCtx.GetRecentPrivateChatIdList());
			if (this.m_currentTableType == ChatChannel.Private && !string.IsNullOrEmpty(this.m_chatTagetID))
			{
				list.Add(this.m_chatTagetID);
			}
			this.TryGetPrivateChatPlayerInfoList(list, action);
			return true;
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x0036BE90 File Offset: 0x0036A090
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnPause();
			this.m_isPrivateShowHistoryRecord = false;
			this.m_isGroupShowHistoryRecord = false;
			this.m_isDragSrcowView = false;
			this.m_playerCtx.EventOnChatMessageNtf -= this.OnChatMessageNtf;
			this.m_playerCtx.EventOnChatMessageAck -= this.OnChatMessageAck;
			this.m_playerCtx.EventOnChatGroupUpdateNtf -= this.OnChatGroupUpdateNtf;
			this.m_playerCtx.EventOnFriendGetSocialRelationAck -= this.EventOnFriendGetSocialRelationNtf;
			if (this.m_playerSimpleInfoUITask != null)
			{
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick -= this.PlayerSimpleInfo_OnPrivateChatButtonClick;
				this.m_playerSimpleInfoUITask.EventOnBlockUser -= this.PlayerSimpleInfo_OnBlockUser;
				this.m_playerSimpleInfoUITask = null;
			}
		}

		// Token: 0x0600C5C4 RID: 50628 RVA: 0x0036BFA8 File Offset: 0x0036A1A8
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnStop();
			VoiceRecordHelper.Instance.EventOnVoiceRecordTimeout -= this.OnVoiceRecordTimeout;
			this.m_playerCtx.EventOnChatMessageNtf -= this.OnChatMessageNtf;
			this.m_playerCtx.EventOnChatMessageAck -= this.OnChatMessageAck;
			this.m_playerCtx.EventOnChatGroupUpdateNtf -= this.OnChatGroupUpdateNtf;
			this.m_playerCtx.EventOnFriendGetSocialRelationAck -= this.EventOnFriendGetSocialRelationNtf;
			if (this.m_playerSimpleInfoUITask != null)
			{
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick -= this.PlayerSimpleInfo_OnPrivateChatButtonClick;
				this.m_playerSimpleInfoUITask.EventOnBlockUser -= this.PlayerSimpleInfo_OnBlockUser;
				this.m_playerSimpleInfoUITask = null;
			}
		}

		// Token: 0x0600C5C5 RID: 50629 RVA: 0x0036C0C0 File Offset: 0x0036A2C0
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntent intent = intent2;
			ChatUITask $this = this;
			this.GetDataFromIntent(intent);
			List<string> list = new List<string>();
			list.AddRange(this.m_playerCtx.GetRecentPrivateChatIdList());
			if (this.m_currentTableType == ChatChannel.Private && !string.IsNullOrEmpty(this.m_chatTagetID))
			{
				list.Add(this.m_chatTagetID);
			}
			this.TryGetChatGroupInfoList(delegate
			{
				$this.OnGetChatTargetInfoEndFroResume(intent);
			});
			this.TryGetPrivateChatPlayerInfoList(list, delegate
			{
				$this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.ChatTargetRefresh);
				$this.StartUpdatePipeLine(null, false, false, true);
			});
			return true;
		}

		// Token: 0x0600C5C6 RID: 50630 RVA: 0x0036C1C4 File Offset: 0x0036A3C4
		private bool OnGetChatTargetInfoEndFroResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetChatTargetInfoEndFroResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnGetChatTargetInfoEndFroResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentChatList = this.GetCurrentChatListByTableType();
			this.m_playerCtx.EventOnChatMessageNtf += this.OnChatMessageNtf;
			this.m_playerCtx.EventOnChatMessageAck += this.OnChatMessageAck;
			this.m_playerCtx.EventOnChatGroupUpdateNtf += this.OnChatGroupUpdateNtf;
			this.m_playerCtx.EventOnFriendGetSocialRelationAck += this.EventOnFriendGetSocialRelationNtf;
			this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.IsInit);
			return base.OnResume(intent);
		}

		// Token: 0x0600C5C7 RID: 50631 RVA: 0x0036C2B8 File Offset: 0x0036A4B8
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_chatUICtrl == null)
			{
				return;
			}
			this.TickForVoiceRecordTime();
			this.TickForHistoryRecordShow();
			this.TickForVoiceAnim();
		}

		// Token: 0x0600C5C8 RID: 50632 RVA: 0x0036C344 File Offset: 0x0036A544
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
			if (this.m_chatUICtrl == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_chatUICtrl = (this.m_uiCtrlArray[0] as ChatUIController);
					this.m_expressionCtrl = (this.m_uiCtrlArray[1] as ChatExpressionUIController);
				}
				if (this.m_chatUICtrl != null)
				{
					this.m_chatUICtrl.EventOnCloseButtonClick += this.OnCloseButtonClick;
					this.m_chatUICtrl.EventOnTableChange += this.OnTableChange;
					this.m_chatUICtrl.EventOnSendButtonClick += this.OnSendButtonClick;
					this.m_chatUICtrl.EventOnRoomIdInputEnd += this.OnRoomIdInputEnd;
					this.m_chatUICtrl.EventOnChatTargetChanged += this.OnChatTargetChanged;
					this.m_chatUICtrl.EventOnExpressionFunctionButtonClick += this.OnExpressionFunctionButtonClick;
					this.m_chatUICtrl.EventOnTalkButtonHold += this.OnTalkButtonHold;
					this.m_chatUICtrl.EventOnTalkButtonClickUp += this.OnTalkButtonClickUp;
					this.m_chatUICtrl.EventOnExitTalkButtonClick += this.OnExitTalkButton;
					this.m_chatUICtrl.EventOnEnterTalkButtonClick += this.OnEnterTalkButton;
					this.m_playerCtx.EventOnChatMessageNtf += this.OnChatMessageNtf;
					this.m_playerCtx.EventOnChatMessageAck += this.OnChatMessageAck;
					this.m_playerCtx.EventOnChatGroupUpdateNtf += this.OnChatGroupUpdateNtf;
					this.m_playerCtx.EventOnFriendGetSocialRelationAck += this.EventOnFriendGetSocialRelationNtf;
					this.m_expressionCtrl.EventOnExpressionBgButtonClick += this.OnExpressionBgButtonClick;
					this.m_expressionCtrl.EventOnSmallExpressionClick += this.OnSmallExpressionClick;
					this.m_chatUICtrl.RegItemButtonClickEvent(new Action<ChatComponent.ChatMessageClient>(this.OnItemVoiceButtonClick), new Action<ChatMessage, GameObject>(this.OnPlayerIconClick));
					this.m_corutineHelper.StartCorutine(this.DelayInstancePrefab());
				}
				else
				{
					global::Debug.LogError("ChatUIController is null");
				}
			}
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x0036C5B4 File Offset: 0x0036A7B4
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
			if (this.m_chatUICtrl != null)
			{
				this.m_chatUICtrl.EventOnCloseButtonClick -= this.OnCloseButtonClick;
				this.m_chatUICtrl.EventOnTableChange -= this.OnTableChange;
				this.m_chatUICtrl.EventOnSendButtonClick -= this.OnSendButtonClick;
				this.m_chatUICtrl.EventOnRoomIdInputEnd -= this.OnRoomIdInputEnd;
				this.m_chatUICtrl.EventOnChatTargetChanged -= this.OnChatTargetChanged;
				this.m_chatUICtrl.EventOnExpressionFunctionButtonClick -= this.OnExpressionFunctionButtonClick;
				this.m_chatUICtrl.EventOnTalkButtonHold -= this.OnTalkButtonHold;
				this.m_chatUICtrl.EventOnTalkButtonClickUp -= this.OnTalkButtonClickUp;
				this.m_chatUICtrl.EventOnExitTalkButtonClick -= this.OnExitTalkButton;
				this.m_chatUICtrl.EventOnEnterTalkButtonClick -= this.OnEnterTalkButton;
				this.m_expressionCtrl.EventOnExpressionBgButtonClick -= this.OnExpressionBgButtonClick;
				this.m_expressionCtrl.EventOnSmallExpressionClick -= this.OnSmallExpressionClick;
				this.m_playerCtx.EventOnChatMessageNtf -= this.OnChatMessageNtf;
				this.m_playerCtx.EventOnChatMessageAck -= this.OnChatMessageAck;
				this.m_playerCtx.EventOnChatGroupUpdateNtf -= this.OnChatGroupUpdateNtf;
				this.m_playerCtx.EventOnFriendGetSocialRelationAck -= this.EventOnFriendGetSocialRelationNtf;
				this.m_chatUICtrl = null;
				this.m_expressionCtrl = null;
			}
		}

		// Token: 0x0600C5CA RID: 50634 RVA: 0x0036C7AC File Offset: 0x0036A9AC
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.IsInit) || this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.NewChatInfo) || this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.TableChange) || this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.ChooseNewChatTarget) || this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.ShowHistoryRecord) || this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.ChatTargetRefresh);
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x0036C864 File Offset: 0x0036AA64
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.IsInit) || this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.TableChange))
			{
				if (this.m_currentTableType == ChatChannel.Private)
				{
					if (!string.IsNullOrEmpty(this.m_chatTagetID))
					{
						this.m_playerCtx.SetPrivateChatTarget(this.m_chatTagetID);
					}
				}
				else if (this.m_currentTableType == ChatChannel.Group && !string.IsNullOrEmpty(this.m_groupChatID))
				{
					this.m_playerCtx.SetGroupChatTarget(this.m_groupChatID);
				}
			}
			this.m_currentChatList = this.GetCurrentChatListByTableType();
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x0036C948 File Offset: 0x0036AB48
		[DebuggerHidden]
		private IEnumerator RequestMicrophonePermission()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RequestMicrophonePermission_hotfix != null)
			{
				return (IEnumerator)this.m_RequestMicrophonePermission_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new ChatUITask.<RequestMicrophonePermission>c__Iterator0();
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x0036C9BC File Offset: 0x0036ABBC
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
			if (this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.IsInit))
			{
				this.m_chatUICtrl.ShowOrHidePanel(true);
				if (!Application.HasUserAuthorization(UserAuthorization.Microphone) && CommonUIController.Instance != null)
				{
					CommonUIController.Instance.StartCoroutine(this.RequestMicrophonePermission());
				}
			}
			if (!this.m_chatUICtrl.GetChannelToggleSelectState(this.m_currentTableType))
			{
				this.m_chatUICtrl.SetChannelToggleSelected(this.m_currentTableType);
			}
			this.m_playerCtx.ReadChat(this.m_currentTableType);
			bool isRefill = true;
			bool isScroll = false;
			if (this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.NewChatInfo))
			{
				isRefill = this.m_chatUICtrl.IsScrollViewInEnd();
				if (this.m_chatUICtrl.IsScrollViewInEnd())
				{
					isScroll = true;
				}
			}
			this.m_chatUICtrl.UpdateChatList(this.m_currentChatList, this.m_currentTableType, isRefill, isScroll, this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.NewChatInfo));
			if (this.m_currentTableType == ChatChannel.Private || this.m_currentTableType == ChatChannel.Group)
			{
				this.m_chatUICtrl.ShowOrHideChooseChatTargetPannel(true);
				KeyValuePair<List<string>, List<string>> recentChatTargetList = this.m_playerCtx.GetRecentChatTargetList(this.m_currentTableType);
				this.m_chatUICtrl.UpdateChooseChatPlayerOrGroupListInfo(this.m_currentTableType, recentChatTargetList.Key, recentChatTargetList.Value);
				if (this.IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType.TableChange))
				{
					if (this.m_currentTableType == ChatChannel.Private)
					{
						if (this.m_playerCtx.GetPrivateUnreadChatMsgCount() > 0)
						{
							this.m_chatUICtrl.ChatTargetChooseDropdown.Show();
							this.m_chatUICtrl.RefreshDropDownList(this.m_currentTableType);
						}
					}
					else if (this.m_currentTableType == ChatChannel.Group && this.m_playerCtx.GetGroupUnreadChatMsgCount() > 0)
					{
						this.m_chatUICtrl.ChatTargetChooseDropdown.Show();
						this.m_chatUICtrl.RefreshDropDownList(this.m_currentTableType);
					}
				}
			}
			else
			{
				this.m_chatUICtrl.ShowOrHideChooseChatTargetPannel(false);
			}
			this.m_expressionCtrl.m_bigExpressionInChatController.SetChannel(this.m_currentTableType);
			this.RefreshRedState();
		}

		// Token: 0x0600C5CE RID: 50638 RVA: 0x0036CBF8 File Offset: 0x0036ADF8
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			base.CollectAsset(UIUtility.GetUIPrefabPath<BigExpressionInChatController>());
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C5CF RID: 50639 RVA: 0x0036CC7C File Offset: 0x0036AE7C
		public void OnSmallExpressionClick(SmallExpressionItemContrller ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix != null)
			{
				this.m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl != null)
			{
				this.m_chatUICtrl.InputFieldTextAppend("#" + ctrl.m_key.ToString());
			}
		}

		// Token: 0x0600C5D0 RID: 50640 RVA: 0x0036CD20 File Offset: 0x0036AF20
		private void OnExpressionBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpressionBgButtonClick_hotfix != null)
			{
				this.m_OnExpressionBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expressionCtrl.ShowOrHideExpressionPanel(false);
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x0036CD8C File Offset: 0x0036AF8C
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
			this.m_expressionCtrl.SwitchExpressionPanel();
		}

		// Token: 0x0600C5D2 RID: 50642 RVA: 0x0036CDF8 File Offset: 0x0036AFF8
		public void OnRoomIdInputEnd(string content)
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
			if (!string.IsNullOrEmpty(content))
			{
				int roomId = int.Parse(content) - 1;
				CommonUIController.Instance.EnableInput(false);
				ChatEnterRoomNetTask chatEnterRoomNetTask = new ChatEnterRoomNetTask(roomId);
				chatEnterRoomNetTask.EventOnStop += delegate(Task task)
				{
					CommonUIController.Instance.EnableInput(true);
					ChatEnterRoomNetTask chatEnterRoomNetTask2 = task as ChatEnterRoomNetTask;
					this.m_chatUICtrl.SetRoomIdTip(chatEnterRoomNetTask2.ResultRoomId + 1);
				};
				chatEnterRoomNetTask.Start(null);
			}
		}

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x0036CEA8 File Offset: 0x0036B0A8
		private void OnItemVoiceButtonClick(ChatComponent.ChatMessageClient voiceInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemVoiceButtonClickChatMessageClient_hotfix != null)
			{
				this.m_OnItemVoiceButtonClickChatMessageClient_hotfix.call(new object[]
				{
					this,
					voiceInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatComponent.ChatMessageClient voiceInfo = voiceInfo2;
			ChatUITask $this = this;
			if (GameManager.Instance.AudioManager.IsPlayerVoicePlaying())
			{
				GameManager.Instance.AudioManager.StopPlayerVoice();
				if (this.m_chatUICtrl.CurrPlayVoiceMsg != null && !this.m_chatUICtrl.CurrPlayVoiceMsg.Equals(voiceInfo))
				{
					this.m_chatUICtrl.CurrPlayVoiceMsg = voiceInfo;
					VoicePlayer.GetVoiceContentAndPlayVoice(voiceInfo.ChatMessageInfo as ChatVoiceMessage, delegate
					{
						$this.OnChatVoiceStartPlay(voiceInfo);
					});
				}
				else
				{
					this.m_chatUICtrl.CurrPlayVoiceMsg = null;
				}
			}
			else
			{
				this.m_chatUICtrl.CurrPlayVoiceMsg = voiceInfo;
				VoicePlayer.GetVoiceContentAndPlayVoice(voiceInfo.ChatMessageInfo as ChatVoiceMessage, delegate
				{
					$this.OnChatVoiceStartPlay(voiceInfo);
				});
			}
		}

		// Token: 0x0600C5D4 RID: 50644 RVA: 0x0036CFF4 File Offset: 0x0036B1F4
		private void OnPlayerIconClick(ChatMessage chatInfo, GameObject playerIcon)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerIconClickChatMessageGameObject_hotfix != null)
			{
				this.m_OnPlayerIconClickChatMessageGameObject_hotfix.call(new object[]
				{
					this,
					chatInfo,
					playerIcon2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject playerIcon = playerIcon2;
			ChatUITask $this = this;
			if (this.m_playerCtx.IsMe(chatInfo.SrcGameUserID))
			{
				return;
			}
			BusinessCardGetNetTask businessCardGetNetTask = new BusinessCardGetNetTask(chatInfo.SrcGameUserID);
			businessCardGetNetTask.EventOnStop += delegate(Task task)
			{
				BusinessCardGetNetTask businessCardGetNetTask2 = task as BusinessCardGetNetTask;
				if (businessCardGetNetTask2.Result == 0)
				{
					$this.ShowPlayerSimpleInfo(playerIcon);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(businessCardGetNetTask2.Result, 2f, null, true);
				}
			};
			businessCardGetNetTask.Start(null);
		}

		// Token: 0x0600C5D5 RID: 50645 RVA: 0x0036D0C8 File Offset: 0x0036B2C8
		private void ShowPlayerSimpleInfo(GameObject playerIcon)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerSimpleInfoGameObject_hotfix != null)
			{
				this.m_ShowPlayerSimpleInfoGameObject_hotfix.call(new object[]
				{
					this,
					playerIcon
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector3[] array = new Vector3[4];
			(playerIcon.transform as RectTransform).GetWorldCorners(array);
			Vector2 vector = new Vector2(Mathf.Abs(array[2].x - array[0].x), Mathf.Abs(array[2].y - array[0].y));
			Vector3 pos = new Vector3(playerIcon.transform.position.x + vector.x / 2f, playerIcon.transform.position.y, playerIcon.transform.position.z);
			bool flag = this.m_playerSimpleInfoUITask != null;
			this.m_playerSimpleInfoUITask = PlayerSimpleInfoUITask.ShowPlayerSimpleInfoPanel(pos, PlayerSimpleInfoUITask.PostionType.Right, this.m_currIntent, false);
			if (!flag && this.m_playerSimpleInfoUITask != null)
			{
				this.m_playerSimpleInfoUITask.EventOnPrivateChatButtonClick += this.PlayerSimpleInfo_OnPrivateChatButtonClick;
				this.m_playerSimpleInfoUITask.EventOnBlockUser += this.PlayerSimpleInfo_OnBlockUser;
			}
		}

		// Token: 0x0600C5D6 RID: 50646 RVA: 0x0036D248 File Offset: 0x0036B448
		private void PlayerSimpleInfo_OnPrivateChatButtonClick(BusinessCard playerInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfo_OnPrivateChatButtonClickBusinessCard_hotfix != null)
			{
				this.m_PlayerSimpleInfo_OnPrivateChatButtonClickBusinessCard_hotfix.call(new object[]
				{
					this,
					playerInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.TryGetPrivateChatPlayerInfoListFilterBlacklist(playerInfo.UserId);
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x0036D2C4 File Offset: 0x0036B4C4
		private void PlayerSimpleInfo_OnBlockUser()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSimpleInfo_OnBlockUser_hotfix != null)
			{
				this.m_PlayerSimpleInfo_OnBlockUser_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x0036D324 File Offset: 0x0036B524
		private void OnTalkButtonHold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonHold_hotfix != null)
			{
				this.m_OnTalkButtonHold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatUICtrl.SetTalkButtonSize(new Vector2(300f, 300f));
			int num = this.m_playerCtx.CanSendChatMessage((int)this.m_currentTableType);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (num != 0)
			{
				ConfigDataErrorCodeStringTable configDataErrorCodeStringTable = configDataLoader.GetConfigDataErrorCodeStringTable(num);
				if (configDataErrorCodeStringTable != null && configDataErrorCodeStringTable.Text != null)
				{
					CommonUIController.Instance.ShowMessage(configDataErrorCodeStringTable.Text, 2f, null, true);
				}
				return;
			}
			if (!VoiceRecordHelper.Instance.IsMicrophoneAvailable())
			{
				string txt = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_MicrophoneNotFound);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				return;
			}
			if (!Application.HasUserAuthorization(UserAuthorization.Microphone))
			{
				if (Application.platform == RuntimePlatform.IPhonePlayer)
				{
					CommonUIController.Instance.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_NoIOSMicrophonePermission), null, string.Empty, string.Empty);
				}
				else if (Application.platform == RuntimePlatform.Android)
				{
					CommonUIController.Instance.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_NoAndroidMicrophonePermission), null, string.Empty, string.Empty);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_MicrophoneNotFound), 2f, null, true);
				}
				return;
			}
			this.m_isTalkButtonDown = true;
			VoiceRecordHelper.Instance.StartRecord(this.m_currentTableType, delegate
			{
				this.m_chatUICtrl.ShowVoiceRecordTip();
			});
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x0036D4D4 File Offset: 0x0036B6D4
		private void OnTalkButtonClickUp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonClickUp_hotfix != null)
			{
				this.m_OnTalkButtonClickUp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatUICtrl.SetTalkButtonSize(new Vector2(100f, 100f));
			if (!this.m_isTalkButtonDown)
			{
				return;
			}
			this.m_isTalkButtonDown = false;
			if (VoiceRecordHelper.Instance.IsRecording() && VoiceRecordHelper.Instance.IsTooShort())
			{
				this.m_chatUICtrl.ShowVoiceShortTip();
				base.ExecAfterTicks(delegate
				{
					if (!VoiceRecordHelper.Instance.IsRecording())
					{
						this.m_chatUICtrl.HideVoiceRecordTip();
					}
				}, (ulong)((1f + Time.smoothDeltaTime) / Time.smoothDeltaTime));
			}
			else
			{
				this.m_chatUICtrl.HideVoiceRecordTip();
			}
			if (this.m_isExitTalkButtonRect)
			{
				this.m_isExitTalkButtonRect = false;
				VoiceRecordHelper.Instance.CancelRecord();
			}
			else
			{
				VoiceRecordHelper.Instance.StopRecord();
			}
		}

		// Token: 0x0600C5DA RID: 50650 RVA: 0x0036D5EC File Offset: 0x0036B7EC
		private void OnExitTalkButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitTalkButton_hotfix != null)
			{
				this.m_OnExitTalkButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTalkButtonDown)
			{
				this.m_chatUICtrl.ShowVoiceCancelTip();
				this.m_isExitTalkButtonRect = true;
			}
		}

		// Token: 0x0600C5DB RID: 50651 RVA: 0x0036D66C File Offset: 0x0036B86C
		private void OnEnterTalkButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnterTalkButton_hotfix != null)
			{
				this.m_OnEnterTalkButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTalkButtonDown)
			{
				this.m_chatUICtrl.ShowVoiceRecordTip();
				this.m_isExitTalkButtonRect = false;
			}
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x0036D6EC File Offset: 0x0036B8EC
		private void OnTableChange(ChatChannel currentTableType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTableChangeChatChannel_hotfix != null)
			{
				this.m_OnTableChangeChatChannel_hotfix.call(new object[]
				{
					this,
					currentTableType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expressionCtrl.ShowOrHideExpressionPanel(false);
			this.m_currentTableType = currentTableType;
			this.m_isGroupShowHistoryRecord = false;
			this.m_isPrivateShowHistoryRecord = false;
			this.m_isDragSrcowView = false;
			this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.TableChange);
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x0036D798 File Offset: 0x0036B998
		private void OnChatTargetChanged(ChatChannel channel, string id, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatTargetChangedChatChannelStringString_hotfix != null)
			{
				this.m_OnChatTargetChangedChatChannelStringString_hotfix.call(new object[]
				{
					this,
					channel,
					id,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (channel == ChatChannel.Private)
			{
				if (this.m_playerCtx.GetPrivateChatPlayerId() != id)
				{
					this.m_isPrivateShowHistoryRecord = false;
					this.m_playerCtx.SetPrivateChatTarget(id);
					this.m_currPipeLineCtx.AddUpdateMask(3);
					base.StartUpdatePipeLine(null, false, false, true);
				}
			}
			else if (channel == ChatChannel.Group && this.m_playerCtx.GetGroupChatId() != id)
			{
				this.m_isGroupShowHistoryRecord = false;
				this.m_playerCtx.SetGroupChatTarget(id);
				this.m_currPipeLineCtx.AddUpdateMask(3);
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x0036D8BC File Offset: 0x0036BABC
		private void OnSendButtonClick(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSendButtonClickString_hotfix != null)
			{
				this.m_OnSendButtonClickString_hotfix.call(new object[]
				{
					this,
					content
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expressionCtrl.ShowOrHideExpressionPanel(false);
			int num = this.m_playerCtx.CanSendChatMessage((int)this.m_currentTableType);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (num == 0)
			{
				this.m_chatUICtrl.ClearChatContent();
				ChatMessageSendNetTask chatMessageSendNetTask = new ChatMessageSendNetTask(this.m_currentTableType, content);
				chatMessageSendNetTask.Start(null);
				return;
			}
			ConfigDataErrorCodeStringTable configDataErrorCodeStringTable = configDataLoader.GetConfigDataErrorCodeStringTable(num);
			if (configDataErrorCodeStringTable != null && configDataErrorCodeStringTable.Text != null)
			{
				CommonUIController.Instance.ShowMessage(configDataErrorCodeStringTable.Text, 2f, null, true);
			}
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x0036D9B4 File Offset: 0x0036BBB4
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
			base.Pause();
			this.ReturnPrevUITask();
		}

		// Token: 0x0600C5E0 RID: 50656 RVA: 0x0036DA20 File Offset: 0x0036BC20
		private new void ReturnPrevUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReturnPrevUITask_hotfix != null)
			{
				this.m_ReturnPrevUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntent prevTaskIntent = (this.m_currIntent as UIIntentReturnable).PrevTaskIntent;
			if (prevTaskIntent.TargetTaskName == typeof(NoticeUITask).Name)
			{
				return;
			}
			base.ReturnPrevUITask();
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x0036DAB8 File Offset: 0x0036BCB8
		private void OnVoiceRecordTimeout(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoiceRecordTimeoutChatChannel_hotfix != null)
			{
				this.m_OnVoiceRecordTimeoutChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isTalkButtonDown = false;
			this.m_chatUICtrl.HideVoiceRecordTip();
			VoiceRecordHelper.Instance.StopRecord();
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x0036DB44 File Offset: 0x0036BD44
		private void GetDataFromIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDataFromIntentUIIntent_hotfix != null)
			{
				this.m_GetDataFromIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				object obj;
				if (uiintentCustom.TryGetParam("AppointEnterChannel", out obj))
				{
					this.m_currentTableType = (ChatChannel)obj;
				}
				object obj2;
				if (uiintentCustom.TryGetParam("PrivateChatPlayerGameUserId", out obj2))
				{
					this.m_chatTagetID = (string)obj2;
				}
				object obj3;
				if (uiintentCustom.TryGetParam("GroupChatId", out obj3))
				{
					this.m_groupChatID = (string)obj3;
				}
			}
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x0036DC1C File Offset: 0x0036BE1C
		private void TryGetPrivateChatPlayerInfoList(List<string> playerIdList, Action action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryGetPrivateChatPlayerInfoListList`1Action_hotfix != null)
			{
				this.m_TryGetPrivateChatPlayerInfoListList`1Action_hotfix.call(new object[]
				{
					this,
					playerIdList,
					action2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action action = action2;
			ChatUITask $this = this;
			ChatGetPlayrInfoListNetTask chatGetPlayrInfoListNetTask = new ChatGetPlayrInfoListNetTask(playerIdList);
			chatGetPlayrInfoListNetTask.EventOnStop += delegate(Task task)
			{
				$this.TryGetChatGroupInfoList(action);
			};
			chatGetPlayrInfoListNetTask.Start(null);
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x0036DCD4 File Offset: 0x0036BED4
		private void TryGetPrivateChatPlayerInfoListFilterBlacklist(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryGetPrivateChatPlayerInfoListFilterBlacklistString_hotfix != null)
			{
				this.m_TryGetPrivateChatPlayerInfoListFilterBlacklistString_hotfix.call(new object[]
				{
					this,
					userID2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string userID = userID2;
			ChatUITask $this = this;
			List<UserSummary> blackList = this.m_playerCtx.GetBlackList();
			foreach (UserSummary userSummary in blackList)
			{
				if (userSummary.UserId == userID)
				{
					string txt = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_UserInBlacklist);
					CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
					return;
				}
			}
			this.TryGetPrivateChatPlayerInfoList(new List<string>
			{
				userID
			}, delegate
			{
				$this.m_currentTableType = ChatChannel.Private;
				$this.m_chatTagetID = userID;
				$this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.TableChange);
				$this.StartUpdatePipeLine(null, false, false, true);
			});
		}

		// Token: 0x0600C5E5 RID: 50661 RVA: 0x0036DE10 File Offset: 0x0036C010
		private void TryGetChatGroupInfoList(Action action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryGetChatGroupInfoListAction_hotfix != null)
			{
				this.m_TryGetChatGroupInfoListAction_hotfix.call(new object[]
				{
					this,
					action2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action action = action2;
			FriendGroupAllGetNetTask friendGroupAllGetNetTask = new FriendGroupAllGetNetTask();
			friendGroupAllGetNetTask.EventOnStop += delegate(Task task)
			{
				if (action != null)
				{
					action();
				}
			};
			friendGroupAllGetNetTask.Start(null);
		}

		// Token: 0x0600C5E6 RID: 50662 RVA: 0x0036DEB0 File Offset: 0x0036C0B0
		private void OnChatMessageNtf(ChatMessage info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatMessageNtfChatMessage_hotfix != null)
			{
				this.m_OnChatMessageNtfChatMessage_hotfix.call(new object[]
				{
					this,
					info
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chatUICtrl == null)
			{
				return;
			}
			this.RefreshRedState();
			if (info.ChannelId != this.m_currentTableType)
			{
				return;
			}
			if (!this.m_chatUICtrl.IsScrollViewInEnd())
			{
				if (info.SrcGameUserID != this.m_playerCtx.GetUserId())
				{
					this.m_chatUICtrl.ShowNewChatTip();
				}
				this.m_chatUICtrl.UpdateChatCacheInfo(this.m_playerCtx.GetChatMessageList(this.m_currentTableType));
			}
			else
			{
				this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.NewChatInfo);
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0600C5E7 RID: 50663 RVA: 0x0036DFB4 File Offset: 0x0036C1B4
		private void OnChatMessageAck(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatMessageAckInt32_hotfix != null)
			{
				this.m_OnChatMessageAckInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result != 0)
			{
				if (result == -1419)
				{
					ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
					string txt = clientConfigDataLoader.UtilityGetErrorCodeString(result);
					CommonUIController.Instance.ShowTip(txt);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
			}
		}

		// Token: 0x0600C5E8 RID: 50664 RVA: 0x0036E070 File Offset: 0x0036C270
		private void OnChatGroupUpdateNtf(ProChatGroupInfo chatGroupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatGroupUpdateNtfProChatGroupInfo_hotfix != null)
			{
				this.m_OnChatGroupUpdateNtfProChatGroupInfo_hotfix.call(new object[]
				{
					this,
					chatGroupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.AddUpdateMask(3);
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600C5E9 RID: 50665 RVA: 0x0036E0F8 File Offset: 0x0036C2F8
		private void EventOnFriendGetSocialRelationNtf(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EventOnFriendGetSocialRelationNtfInt32_hotfix != null)
			{
				this.m_EventOnFriendGetSocialRelationNtfInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isPrivateShowHistoryRecord = false;
			this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.ChooseNewChatTarget);
			this.m_playerCtx.CleanPrivateChatTarget();
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600C5EA RID: 50666 RVA: 0x0036E18C File Offset: 0x0036C38C
		protected bool IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currPipeLineCtx.IsNeedUpdate((int)state);
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x0036E214 File Offset: 0x0036C414
		protected void EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix != null)
			{
				this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.AddUpdateMask((int)state);
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x0036E290 File Offset: 0x0036C490
		private List<ChatComponent.ChatMessageClient> GetCurrentChatListByTableType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentChatListByTableType_hotfix != null)
			{
				return (List<ChatComponent.ChatMessageClient>)this.m_GetCurrentChatListByTableType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatChannel currentTableType = this.m_currentTableType;
			if (currentTableType != ChatChannel.World)
			{
				if (currentTableType != ChatChannel.Private)
				{
					if (currentTableType == ChatChannel.Group)
					{
						List<ChatComponent.ChatMessageClient> chatMessageList = this.m_playerCtx.GetChatMessageList(ChatChannel.Group);
						if (!this.m_isGroupShowHistoryRecord)
						{
							List<ChatComponent.ChatMessageClient> list = new List<ChatComponent.ChatMessageClient>();
							foreach (ChatComponent.ChatMessageClient chatMessageClient in chatMessageList)
							{
								if (!chatMessageClient.isHistoryRecord)
								{
									list.Add(chatMessageClient);
								}
							}
							return list;
						}
					}
				}
				else
				{
					List<ChatComponent.ChatMessageClient> chatMessageList2 = this.m_playerCtx.GetChatMessageList(ChatChannel.Private);
					if (!this.m_isPrivateShowHistoryRecord)
					{
						List<ChatComponent.ChatMessageClient> list2 = new List<ChatComponent.ChatMessageClient>();
						foreach (ChatComponent.ChatMessageClient chatMessageClient2 in chatMessageList2)
						{
							if (!chatMessageClient2.isHistoryRecord)
							{
								list2.Add(chatMessageClient2);
							}
						}
						return list2;
					}
				}
				return this.m_playerCtx.GetChatMessageList(this.m_currentTableType);
			}
			return this.GetChatMsgWithBlacklist(ChatChannel.World);
		}

		// Token: 0x0600C5ED RID: 50669 RVA: 0x0036E430 File Offset: 0x0036C630
		private void TickForVoiceRecordTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickForVoiceRecordTime_hotfix != null)
			{
				this.m_TickForVoiceRecordTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTalkButtonDown && this.m_chatUICtrl != null && VoiceRecordHelper.Instance.IsRecording())
			{
				if (!VoiceRecordHelper.Instance.IsArrivalMaxLength())
				{
					this.m_chatUICtrl.UpdateVoiceRecordTime(VoiceRecordHelper.Instance.GetRecordLength());
				}
				else
				{
					this.m_chatUICtrl.HideVoiceRecordTip();
				}
			}
		}

		// Token: 0x0600C5EE RID: 50670 RVA: 0x0036E4F0 File Offset: 0x0036C6F0
		private void TickForHistoryRecordShow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickForHistoryRecordShow_hotfix != null)
			{
				this.m_TickForHistoryRecordShow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chatUICtrl == null)
			{
				return;
			}
			bool flag = false;
			ChatChannel currentTableType = this.m_currentTableType;
			if (currentTableType != ChatChannel.Group)
			{
				if (currentTableType == ChatChannel.Private)
				{
					flag = !this.m_isPrivateShowHistoryRecord;
				}
			}
			else
			{
				flag = !this.m_isGroupShowHistoryRecord;
			}
			if (flag)
			{
				if (!this.m_isDragSrcowView && this.m_chatUICtrl.ScrollView.content.anchoredPosition.y <= -75f)
				{
					this.m_isDragSrcowView = true;
				}
				if (this.m_isDragSrcowView && this.m_chatUICtrl.ScrollView.content.anchoredPosition.y >= -5f)
				{
					string id = string.Empty;
					ChatChannel currentTableType2 = this.m_currentTableType;
					if (currentTableType2 != ChatChannel.Group)
					{
						if (currentTableType2 == ChatChannel.Private)
						{
							this.m_isPrivateShowHistoryRecord = true;
							id = this.m_playerCtx.GetPrivateChatPlayerId();
						}
					}
					else
					{
						this.m_isGroupShowHistoryRecord = true;
						id = this.m_playerCtx.GetGroupChatId();
					}
					this.m_isDragSrcowView = false;
					if (this.m_playerCtx.GetChatComponent().IsHasHistoryRecord4Chat(this.m_currentTableType, id))
					{
						this.EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType.ShowHistoryRecord);
						base.StartUpdatePipeLine(null, false, false, true);
					}
				}
			}
		}

		// Token: 0x0600C5EF RID: 50671 RVA: 0x0036E69C File Offset: 0x0036C89C
		private void TickForVoiceAnim()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickForVoiceAnim_hotfix != null)
			{
				this.m_TickForVoiceAnim_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chatUICtrl == null)
			{
				return;
			}
			if (!GameManager.Instance.AudioManager.IsPlayerVoicePlaying())
			{
				this.StopAllVoiceAnim();
			}
		}

		// Token: 0x0600C5F0 RID: 50672 RVA: 0x0036E728 File Offset: 0x0036C928
		private void PlayVoiceAnim()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayVoiceAnim_hotfix != null)
			{
				this.m_PlayVoiceAnim_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chatUICtrl != null)
			{
				List<GameObject> activeGameObjectListInContext = this.m_chatUICtrl.ScrollView.GetActiveGameObjectListInContext();
				foreach (GameObject gameObject in activeGameObjectListInContext)
				{
					ChatItemManagerController component = gameObject.GetComponent<ChatItemManagerController>();
					if (component != null && component.m_childPrefab != null)
					{
						PlayerChatItemUIController component2 = component.m_childPrefab.GetComponent<PlayerChatItemUIController>();
						if (component2 != null)
						{
							if (component2.m_currChatInfo != null && component2.m_currChatInfo.Equals(this.m_chatUICtrl.CurrPlayVoiceMsg))
							{
								component2.SetPlayState(true);
							}
							else
							{
								component2.SetPlayState(false);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600C5F1 RID: 50673 RVA: 0x0036E868 File Offset: 0x0036CA68
		private void StopAllVoiceAnim()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopAllVoiceAnim_hotfix != null)
			{
				this.m_StopAllVoiceAnim_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GameObject> activeGameObjectListInContext = this.m_chatUICtrl.ScrollView.GetActiveGameObjectListInContext();
			foreach (GameObject gameObject in activeGameObjectListInContext)
			{
				ChatItemManagerController component = gameObject.GetComponent<ChatItemManagerController>();
				if (component != null && component.m_childPrefab != null)
				{
					PlayerChatItemUIController component2 = component.m_childPrefab.GetComponent<PlayerChatItemUIController>();
					if (component2 != null)
					{
						component2.SetPlayState(false);
					}
				}
			}
		}

		// Token: 0x0600C5F2 RID: 50674 RVA: 0x0036E964 File Offset: 0x0036CB64
		private void OnChatVoiceStartPlay(ChatComponent.ChatMessageClient voiceMsg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatVoiceStartPlayChatMessageClient_hotfix != null)
			{
				this.m_OnChatVoiceStartPlayChatMessageClient_hotfix.call(new object[]
				{
					this,
					voiceMsg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			voiceMsg.isRead = true;
			this.PlayVoiceAnim();
		}

		// Token: 0x0600C5F3 RID: 50675 RVA: 0x0036E9E4 File Offset: 0x0036CBE4
		private List<ChatComponent.ChatMessageClient> GetChatMsgWithBlacklist(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChatMsgWithBlacklistChatChannel_hotfix != null)
			{
				return (List<ChatComponent.ChatMessageClient>)this.m_GetChatMsgWithBlacklistChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ChatComponent.ChatMessageClient> chatMessageList = this.m_playerCtx.GetChatMessageList(channel);
			return chatMessageList.FindAll(delegate(ChatComponent.ChatMessageClient msg)
			{
				List<UserSummary> blackList = this.m_playerCtx.GetBlackList();
				foreach (UserSummary userSummary in blackList)
				{
					if (userSummary.UserId == msg.ChatMessageInfo.SrcGameUserID)
					{
						return false;
					}
				}
				return true;
			});
		}

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x0036EA84 File Offset: 0x0036CC84
		[DebuggerHidden]
		private IEnumerator DelayInstancePrefab()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayInstancePrefab_hotfix != null)
			{
				return (IEnumerator)this.m_DelayInstancePrefab_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatUITask.<DelayInstancePrefab>c__Iterator1 <DelayInstancePrefab>c__Iterator = new ChatUITask.<DelayInstancePrefab>c__Iterator1();
			<DelayInstancePrefab>c__Iterator.$this = this;
			return <DelayInstancePrefab>c__Iterator;
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x0036EB00 File Offset: 0x0036CD00
		private void RefreshRedState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshRedState_hotfix != null)
			{
				this.m_RefreshRedState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatUICtrl.CloseAllTableRedMark();
			if (this.m_playerCtx.GetGroupUnreadChatMsgCount() > 0)
			{
				this.m_chatUICtrl.SetTableRedMark(ChatChannel.Group);
			}
			if (this.m_playerCtx.GetPrivateUnreadChatMsgCount() > 0)
			{
				this.m_chatUICtrl.SetTableRedMark(ChatChannel.Private);
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600C5F6 RID: 50678 RVA: 0x0036EBA8 File Offset: 0x0036CDA8
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

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600C5F7 RID: 50679 RVA: 0x0036EC1C File Offset: 0x0036CE1C
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

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600C5F8 RID: 50680 RVA: 0x0036EC90 File Offset: 0x0036CE90
		// (set) Token: 0x0600C5F9 RID: 50681 RVA: 0x0036ECB0 File Offset: 0x0036CEB0
		[DoNotToLua]
		public new ChatUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x0036ECBC File Offset: 0x0036CEBC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x0036ECC8 File Offset: 0x0036CEC8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x0036ECD0 File Offset: 0x0036CED0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x0036ECD8 File Offset: 0x0036CED8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600C5FE RID: 50686 RVA: 0x0036ECE4 File Offset: 0x0036CEE4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600C5FF RID: 50687 RVA: 0x0036ECF0 File Offset: 0x0036CEF0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600C600 RID: 50688 RVA: 0x0036ECFC File Offset: 0x0036CEFC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x0036ED04 File Offset: 0x0036CF04
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x0036ED0C File Offset: 0x0036CF0C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x0036ED14 File Offset: 0x0036CF14
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600C604 RID: 50692 RVA: 0x0036ED1C File Offset: 0x0036CF1C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x0036ED24 File Offset: 0x0036CF24
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600C606 RID: 50694 RVA: 0x0036ED2C File Offset: 0x0036CF2C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x0036ED34 File Offset: 0x0036CF34
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600C608 RID: 50696 RVA: 0x0036ED40 File Offset: 0x0036CF40
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600C609 RID: 50697 RVA: 0x0036ED4C File Offset: 0x0036CF4C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600C60A RID: 50698 RVA: 0x0036ED58 File Offset: 0x0036CF58
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x0036ED64 File Offset: 0x0036CF64
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600C60C RID: 50700 RVA: 0x0036ED6C File Offset: 0x0036CF6C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600C60D RID: 50701 RVA: 0x0036ED74 File Offset: 0x0036CF74
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600C60E RID: 50702 RVA: 0x0036ED7C File Offset: 0x0036CF7C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x0036ED84 File Offset: 0x0036CF84
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600C610 RID: 50704 RVA: 0x0036ED8C File Offset: 0x0036CF8C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x0036EE84 File Offset: 0x0036D084
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnGetChatTargetInfoEndFroResumeUIIntent_hotfix = (luaObj.RawGet("OnGetChatTargetInfoEndFroResume") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_RequestMicrophonePermission_hotfix = (luaObj.RawGet("RequestMicrophonePermission") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix = (luaObj.RawGet("OnSmallExpressionClick") as LuaFunction);
					this.m_OnExpressionBgButtonClick_hotfix = (luaObj.RawGet("OnExpressionBgButtonClick") as LuaFunction);
					this.m_OnExpressionFunctionButtonClick_hotfix = (luaObj.RawGet("OnExpressionFunctionButtonClick") as LuaFunction);
					this.m_OnRoomIdInputEndString_hotfix = (luaObj.RawGet("OnRoomIdInputEnd") as LuaFunction);
					this.m_OnItemVoiceButtonClickChatMessageClient_hotfix = (luaObj.RawGet("OnItemVoiceButtonClick") as LuaFunction);
					this.m_OnPlayerIconClickChatMessageGameObject_hotfix = (luaObj.RawGet("OnPlayerIconClick") as LuaFunction);
					this.m_ShowPlayerSimpleInfoGameObject_hotfix = (luaObj.RawGet("ShowPlayerSimpleInfo") as LuaFunction);
					this.m_PlayerSimpleInfo_OnPrivateChatButtonClickBusinessCard_hotfix = (luaObj.RawGet("PlayerSimpleInfo_OnPrivateChatButtonClick") as LuaFunction);
					this.m_PlayerSimpleInfo_OnBlockUser_hotfix = (luaObj.RawGet("PlayerSimpleInfo_OnBlockUser") as LuaFunction);
					this.m_OnTalkButtonHold_hotfix = (luaObj.RawGet("OnTalkButtonHold") as LuaFunction);
					this.m_OnTalkButtonClickUp_hotfix = (luaObj.RawGet("OnTalkButtonClickUp") as LuaFunction);
					this.m_OnExitTalkButton_hotfix = (luaObj.RawGet("OnExitTalkButton") as LuaFunction);
					this.m_OnEnterTalkButton_hotfix = (luaObj.RawGet("OnEnterTalkButton") as LuaFunction);
					this.m_OnTableChangeChatChannel_hotfix = (luaObj.RawGet("OnTableChange") as LuaFunction);
					this.m_OnChatTargetChangedChatChannelStringString_hotfix = (luaObj.RawGet("OnChatTargetChanged") as LuaFunction);
					this.m_OnSendButtonClickString_hotfix = (luaObj.RawGet("OnSendButtonClick") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_ReturnPrevUITask_hotfix = (luaObj.RawGet("ReturnPrevUITask") as LuaFunction);
					this.m_OnVoiceRecordTimeoutChatChannel_hotfix = (luaObj.RawGet("OnVoiceRecordTimeout") as LuaFunction);
					this.m_GetDataFromIntentUIIntent_hotfix = (luaObj.RawGet("GetDataFromIntent") as LuaFunction);
					this.m_TryGetPrivateChatPlayerInfoListList`1Action_hotfix = (luaObj.RawGet("TryGetPrivateChatPlayerInfoList") as LuaFunction);
					this.m_TryGetPrivateChatPlayerInfoListFilterBlacklistString_hotfix = (luaObj.RawGet("TryGetPrivateChatPlayerInfoListFilterBlacklist") as LuaFunction);
					this.m_TryGetChatGroupInfoListAction_hotfix = (luaObj.RawGet("TryGetChatGroupInfoList") as LuaFunction);
					this.m_OnChatMessageNtfChatMessage_hotfix = (luaObj.RawGet("OnChatMessageNtf") as LuaFunction);
					this.m_OnChatMessageAckInt32_hotfix = (luaObj.RawGet("OnChatMessageAck") as LuaFunction);
					this.m_OnChatGroupUpdateNtfProChatGroupInfo_hotfix = (luaObj.RawGet("OnChatGroupUpdateNtf") as LuaFunction);
					this.m_EventOnFriendGetSocialRelationNtfInt32_hotfix = (luaObj.RawGet("EventOnFriendGetSocialRelationNtf") as LuaFunction);
					this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix = (luaObj.RawGet("IsPipelineStateMaskNeedUpdate") as LuaFunction);
					this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix = (luaObj.RawGet("EnablePipelineStateMask") as LuaFunction);
					this.m_GetCurrentChatListByTableType_hotfix = (luaObj.RawGet("GetCurrentChatListByTableType") as LuaFunction);
					this.m_TickForVoiceRecordTime_hotfix = (luaObj.RawGet("TickForVoiceRecordTime") as LuaFunction);
					this.m_TickForHistoryRecordShow_hotfix = (luaObj.RawGet("TickForHistoryRecordShow") as LuaFunction);
					this.m_TickForVoiceAnim_hotfix = (luaObj.RawGet("TickForVoiceAnim") as LuaFunction);
					this.m_PlayVoiceAnim_hotfix = (luaObj.RawGet("PlayVoiceAnim") as LuaFunction);
					this.m_StopAllVoiceAnim_hotfix = (luaObj.RawGet("StopAllVoiceAnim") as LuaFunction);
					this.m_OnChatVoiceStartPlayChatMessageClient_hotfix = (luaObj.RawGet("OnChatVoiceStartPlay") as LuaFunction);
					this.m_GetChatMsgWithBlacklistChatChannel_hotfix = (luaObj.RawGet("GetChatMsgWithBlacklist") as LuaFunction);
					this.m_DelayInstancePrefab_hotfix = (luaObj.RawGet("DelayInstancePrefab") as LuaFunction);
					this.m_RefreshRedState_hotfix = (luaObj.RawGet("RefreshRedState") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x0036F498 File Offset: 0x0036D698
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007D32 RID: 32050
		private bool m_isTalkButtonDown;

		// Token: 0x04007D33 RID: 32051
		private bool m_isExitTalkButtonRect;

		// Token: 0x04007D34 RID: 32052
		private ProjectLPlayerContext m_playerCtx = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04007D35 RID: 32053
		private List<ChatComponent.ChatMessageClient> m_currentChatList = new List<ChatComponent.ChatMessageClient>();

		// Token: 0x04007D36 RID: 32054
		private ChatChannel m_currentTableType;

		// Token: 0x04007D37 RID: 32055
		private string m_chatTagetID = string.Empty;

		// Token: 0x04007D38 RID: 32056
		private string m_groupChatID = string.Empty;

		// Token: 0x04007D39 RID: 32057
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007D3A RID: 32058
		private PlayerSimpleInfoUITask m_playerSimpleInfoUITask;

		// Token: 0x04007D3B RID: 32059
		private bool m_isPrivateShowHistoryRecord;

		// Token: 0x04007D3C RID: 32060
		private bool m_isDragSrcowView;

		// Token: 0x04007D3D RID: 32061
		private bool m_isGroupShowHistoryRecord;

		// Token: 0x04007D3E RID: 32062
		private ChatUIController m_chatUICtrl;

		// Token: 0x04007D3F RID: 32063
		private ChatExpressionUIController m_expressionCtrl;

		// Token: 0x04007D40 RID: 32064
		private string m_currentChatUserID = string.Empty;

		// Token: 0x04007D41 RID: 32065
		public const string ParamsKey_AppointChannel = "AppointEnterChannel";

		// Token: 0x04007D42 RID: 32066
		public const string ParamsKey_ChatUserId = "PrivateChatPlayerGameUserId";

		// Token: 0x04007D43 RID: 32067
		public const string ParamsKey_GroupChatId = "GroupChatId";

		// Token: 0x04007D44 RID: 32068
		public const string ExpressionMark = "#";

		// Token: 0x04007D45 RID: 32069
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ChatUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Chat_ABS/Prefab/ChatUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04007D46 RID: 32070
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ChatUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ChatUIController"),
				m_ctrlName = "ChatUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ChatUILayer",
				m_attachPath = "./ChatPanel/ChatDetail/ExpressionPanel",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ChatExpressionUIController"),
				m_ctrlName = "ChatExpressionUIController"
			}
		};

		// Token: 0x04007D47 RID: 32071
		[DoNotToLua]
		private ChatUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04007D48 RID: 32072
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007D49 RID: 32073
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007D4A RID: 32074
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007D4B RID: 32075
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04007D4C RID: 32076
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x04007D4D RID: 32077
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04007D4E RID: 32078
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04007D4F RID: 32079
		private LuaFunction m_OnGetChatTargetInfoEndFroResumeUIIntent_hotfix;

		// Token: 0x04007D50 RID: 32080
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04007D51 RID: 32081
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04007D52 RID: 32082
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04007D53 RID: 32083
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x04007D54 RID: 32084
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x04007D55 RID: 32085
		private LuaFunction m_RequestMicrophonePermission_hotfix;

		// Token: 0x04007D56 RID: 32086
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04007D57 RID: 32087
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04007D58 RID: 32088
		private LuaFunction m_OnSmallExpressionClickSmallExpressionItemContrller_hotfix;

		// Token: 0x04007D59 RID: 32089
		private LuaFunction m_OnExpressionBgButtonClick_hotfix;

		// Token: 0x04007D5A RID: 32090
		private LuaFunction m_OnExpressionFunctionButtonClick_hotfix;

		// Token: 0x04007D5B RID: 32091
		private LuaFunction m_OnRoomIdInputEndString_hotfix;

		// Token: 0x04007D5C RID: 32092
		private LuaFunction m_OnItemVoiceButtonClickChatMessageClient_hotfix;

		// Token: 0x04007D5D RID: 32093
		private LuaFunction m_OnPlayerIconClickChatMessageGameObject_hotfix;

		// Token: 0x04007D5E RID: 32094
		private LuaFunction m_ShowPlayerSimpleInfoGameObject_hotfix;

		// Token: 0x04007D5F RID: 32095
		private LuaFunction m_PlayerSimpleInfo_OnPrivateChatButtonClickBusinessCard_hotfix;

		// Token: 0x04007D60 RID: 32096
		private LuaFunction m_PlayerSimpleInfo_OnBlockUser_hotfix;

		// Token: 0x04007D61 RID: 32097
		private LuaFunction m_OnTalkButtonHold_hotfix;

		// Token: 0x04007D62 RID: 32098
		private LuaFunction m_OnTalkButtonClickUp_hotfix;

		// Token: 0x04007D63 RID: 32099
		private LuaFunction m_OnExitTalkButton_hotfix;

		// Token: 0x04007D64 RID: 32100
		private LuaFunction m_OnEnterTalkButton_hotfix;

		// Token: 0x04007D65 RID: 32101
		private LuaFunction m_OnTableChangeChatChannel_hotfix;

		// Token: 0x04007D66 RID: 32102
		private LuaFunction m_OnChatTargetChangedChatChannelStringString_hotfix;

		// Token: 0x04007D67 RID: 32103
		private LuaFunction m_OnSendButtonClickString_hotfix;

		// Token: 0x04007D68 RID: 32104
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x04007D69 RID: 32105
		private LuaFunction m_ReturnPrevUITask_hotfix;

		// Token: 0x04007D6A RID: 32106
		private LuaFunction m_OnVoiceRecordTimeoutChatChannel_hotfix;

		// Token: 0x04007D6B RID: 32107
		private LuaFunction m_GetDataFromIntentUIIntent_hotfix;

		// Token: 0x04007D6C RID: 32108
		private LuaFunction m_TryGetPrivateChatPlayerInfoListList;

		// Token: 0x04007D6D RID: 32109
		private LuaFunction m_TryGetPrivateChatPlayerInfoListFilterBlacklistString_hotfix;

		// Token: 0x04007D6E RID: 32110
		private LuaFunction m_TryGetChatGroupInfoListAction_hotfix;

		// Token: 0x04007D6F RID: 32111
		private LuaFunction m_OnChatMessageNtfChatMessage_hotfix;

		// Token: 0x04007D70 RID: 32112
		private LuaFunction m_OnChatMessageAckInt32_hotfix;

		// Token: 0x04007D71 RID: 32113
		private LuaFunction m_OnChatGroupUpdateNtfProChatGroupInfo_hotfix;

		// Token: 0x04007D72 RID: 32114
		private LuaFunction m_EventOnFriendGetSocialRelationNtfInt32_hotfix;

		// Token: 0x04007D73 RID: 32115
		private LuaFunction m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix;

		// Token: 0x04007D74 RID: 32116
		private LuaFunction m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix;

		// Token: 0x04007D75 RID: 32117
		private LuaFunction m_GetCurrentChatListByTableType_hotfix;

		// Token: 0x04007D76 RID: 32118
		private LuaFunction m_TickForVoiceRecordTime_hotfix;

		// Token: 0x04007D77 RID: 32119
		private LuaFunction m_TickForHistoryRecordShow_hotfix;

		// Token: 0x04007D78 RID: 32120
		private LuaFunction m_TickForVoiceAnim_hotfix;

		// Token: 0x04007D79 RID: 32121
		private LuaFunction m_PlayVoiceAnim_hotfix;

		// Token: 0x04007D7A RID: 32122
		private LuaFunction m_StopAllVoiceAnim_hotfix;

		// Token: 0x04007D7B RID: 32123
		private LuaFunction m_OnChatVoiceStartPlayChatMessageClient_hotfix;

		// Token: 0x04007D7C RID: 32124
		private LuaFunction m_GetChatMsgWithBlacklistChatChannel_hotfix;

		// Token: 0x04007D7D RID: 32125
		private LuaFunction m_DelayInstancePrefab_hotfix;

		// Token: 0x04007D7E RID: 32126
		private LuaFunction m_RefreshRedState_hotfix;

		// Token: 0x04007D7F RID: 32127
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04007D80 RID: 32128
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000B55 RID: 2901
		public enum PipeLineStateMaskType
		{
			// Token: 0x04007D82 RID: 32130
			IsInit,
			// Token: 0x04007D83 RID: 32131
			NewChatInfo,
			// Token: 0x04007D84 RID: 32132
			TableChange,
			// Token: 0x04007D85 RID: 32133
			ChooseNewChatTarget,
			// Token: 0x04007D86 RID: 32134
			ShowHistoryRecord,
			// Token: 0x04007D87 RID: 32135
			ChatTargetRefresh
		}

		// Token: 0x02000B56 RID: 2902
		public new class LuaExportHelper
		{
			// Token: 0x0600C618 RID: 50712 RVA: 0x0036F500 File Offset: 0x0036D700
			public LuaExportHelper(ChatUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C619 RID: 50713 RVA: 0x0036F510 File Offset: 0x0036D710
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600C61A RID: 50714 RVA: 0x0036F520 File Offset: 0x0036D720
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600C61B RID: 50715 RVA: 0x0036F530 File Offset: 0x0036D730
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600C61C RID: 50716 RVA: 0x0036F540 File Offset: 0x0036D740
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600C61D RID: 50717 RVA: 0x0036F550 File Offset: 0x0036D750
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600C61E RID: 50718 RVA: 0x0036F560 File Offset: 0x0036D760
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600C61F RID: 50719 RVA: 0x0036F570 File Offset: 0x0036D770
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C620 RID: 50720 RVA: 0x0036F580 File Offset: 0x0036D780
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600C621 RID: 50721 RVA: 0x0036F590 File Offset: 0x0036D790
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600C622 RID: 50722 RVA: 0x0036F5A0 File Offset: 0x0036D7A0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600C623 RID: 50723 RVA: 0x0036F5B0 File Offset: 0x0036D7B0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600C624 RID: 50724 RVA: 0x0036F5C0 File Offset: 0x0036D7C0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600C625 RID: 50725 RVA: 0x0036F5D0 File Offset: 0x0036D7D0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600C626 RID: 50726 RVA: 0x0036F5E0 File Offset: 0x0036D7E0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600C627 RID: 50727 RVA: 0x0036F5F0 File Offset: 0x0036D7F0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600C628 RID: 50728 RVA: 0x0036F600 File Offset: 0x0036D800
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600C629 RID: 50729 RVA: 0x0036F610 File Offset: 0x0036D810
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600C62A RID: 50730 RVA: 0x0036F620 File Offset: 0x0036D820
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600C62B RID: 50731 RVA: 0x0036F630 File Offset: 0x0036D830
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600C62C RID: 50732 RVA: 0x0036F640 File Offset: 0x0036D840
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600C62D RID: 50733 RVA: 0x0036F650 File Offset: 0x0036D850
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600C62E RID: 50734 RVA: 0x0036F660 File Offset: 0x0036D860
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600C62F RID: 50735 RVA: 0x0036F670 File Offset: 0x0036D870
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002771 RID: 10097
			// (get) Token: 0x0600C630 RID: 50736 RVA: 0x0036F680 File Offset: 0x0036D880
			// (set) Token: 0x0600C631 RID: 50737 RVA: 0x0036F690 File Offset: 0x0036D890
			public bool m_isTalkButtonDown
			{
				get
				{
					return this.m_owner.m_isTalkButtonDown;
				}
				set
				{
					this.m_owner.m_isTalkButtonDown = value;
				}
			}

			// Token: 0x17002772 RID: 10098
			// (get) Token: 0x0600C632 RID: 50738 RVA: 0x0036F6A0 File Offset: 0x0036D8A0
			// (set) Token: 0x0600C633 RID: 50739 RVA: 0x0036F6B0 File Offset: 0x0036D8B0
			public bool m_isExitTalkButtonRect
			{
				get
				{
					return this.m_owner.m_isExitTalkButtonRect;
				}
				set
				{
					this.m_owner.m_isExitTalkButtonRect = value;
				}
			}

			// Token: 0x17002773 RID: 10099
			// (get) Token: 0x0600C634 RID: 50740 RVA: 0x0036F6C0 File Offset: 0x0036D8C0
			// (set) Token: 0x0600C635 RID: 50741 RVA: 0x0036F6D0 File Offset: 0x0036D8D0
			public ProjectLPlayerContext m_playerCtx
			{
				get
				{
					return this.m_owner.m_playerCtx;
				}
				set
				{
					this.m_owner.m_playerCtx = value;
				}
			}

			// Token: 0x17002774 RID: 10100
			// (get) Token: 0x0600C636 RID: 50742 RVA: 0x0036F6E0 File Offset: 0x0036D8E0
			// (set) Token: 0x0600C637 RID: 50743 RVA: 0x0036F6F0 File Offset: 0x0036D8F0
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

			// Token: 0x17002775 RID: 10101
			// (get) Token: 0x0600C638 RID: 50744 RVA: 0x0036F700 File Offset: 0x0036D900
			// (set) Token: 0x0600C639 RID: 50745 RVA: 0x0036F710 File Offset: 0x0036D910
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

			// Token: 0x17002776 RID: 10102
			// (get) Token: 0x0600C63A RID: 50746 RVA: 0x0036F720 File Offset: 0x0036D920
			// (set) Token: 0x0600C63B RID: 50747 RVA: 0x0036F730 File Offset: 0x0036D930
			public string m_chatTagetID
			{
				get
				{
					return this.m_owner.m_chatTagetID;
				}
				set
				{
					this.m_owner.m_chatTagetID = value;
				}
			}

			// Token: 0x17002777 RID: 10103
			// (get) Token: 0x0600C63C RID: 50748 RVA: 0x0036F740 File Offset: 0x0036D940
			// (set) Token: 0x0600C63D RID: 50749 RVA: 0x0036F750 File Offset: 0x0036D950
			public string m_groupChatID
			{
				get
				{
					return this.m_owner.m_groupChatID;
				}
				set
				{
					this.m_owner.m_groupChatID = value;
				}
			}

			// Token: 0x17002778 RID: 10104
			// (get) Token: 0x0600C63E RID: 50750 RVA: 0x0036F760 File Offset: 0x0036D960
			// (set) Token: 0x0600C63F RID: 50751 RVA: 0x0036F770 File Offset: 0x0036D970
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

			// Token: 0x17002779 RID: 10105
			// (get) Token: 0x0600C640 RID: 50752 RVA: 0x0036F780 File Offset: 0x0036D980
			// (set) Token: 0x0600C641 RID: 50753 RVA: 0x0036F790 File Offset: 0x0036D990
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

			// Token: 0x1700277A RID: 10106
			// (get) Token: 0x0600C642 RID: 50754 RVA: 0x0036F7A0 File Offset: 0x0036D9A0
			// (set) Token: 0x0600C643 RID: 50755 RVA: 0x0036F7B0 File Offset: 0x0036D9B0
			public bool m_isPrivateShowHistoryRecord
			{
				get
				{
					return this.m_owner.m_isPrivateShowHistoryRecord;
				}
				set
				{
					this.m_owner.m_isPrivateShowHistoryRecord = value;
				}
			}

			// Token: 0x1700277B RID: 10107
			// (get) Token: 0x0600C644 RID: 50756 RVA: 0x0036F7C0 File Offset: 0x0036D9C0
			// (set) Token: 0x0600C645 RID: 50757 RVA: 0x0036F7D0 File Offset: 0x0036D9D0
			public bool m_isDragSrcowView
			{
				get
				{
					return this.m_owner.m_isDragSrcowView;
				}
				set
				{
					this.m_owner.m_isDragSrcowView = value;
				}
			}

			// Token: 0x1700277C RID: 10108
			// (get) Token: 0x0600C646 RID: 50758 RVA: 0x0036F7E0 File Offset: 0x0036D9E0
			// (set) Token: 0x0600C647 RID: 50759 RVA: 0x0036F7F0 File Offset: 0x0036D9F0
			public bool m_isGroupShowHistoryRecord
			{
				get
				{
					return this.m_owner.m_isGroupShowHistoryRecord;
				}
				set
				{
					this.m_owner.m_isGroupShowHistoryRecord = value;
				}
			}

			// Token: 0x1700277D RID: 10109
			// (get) Token: 0x0600C648 RID: 50760 RVA: 0x0036F800 File Offset: 0x0036DA00
			// (set) Token: 0x0600C649 RID: 50761 RVA: 0x0036F810 File Offset: 0x0036DA10
			public ChatUIController m_chatUICtrl
			{
				get
				{
					return this.m_owner.m_chatUICtrl;
				}
				set
				{
					this.m_owner.m_chatUICtrl = value;
				}
			}

			// Token: 0x1700277E RID: 10110
			// (get) Token: 0x0600C64A RID: 50762 RVA: 0x0036F820 File Offset: 0x0036DA20
			// (set) Token: 0x0600C64B RID: 50763 RVA: 0x0036F830 File Offset: 0x0036DA30
			public ChatExpressionUIController m_expressionCtrl
			{
				get
				{
					return this.m_owner.m_expressionCtrl;
				}
				set
				{
					this.m_owner.m_expressionCtrl = value;
				}
			}

			// Token: 0x1700277F RID: 10111
			// (get) Token: 0x0600C64C RID: 50764 RVA: 0x0036F840 File Offset: 0x0036DA40
			// (set) Token: 0x0600C64D RID: 50765 RVA: 0x0036F850 File Offset: 0x0036DA50
			public string m_currentChatUserID
			{
				get
				{
					return this.m_owner.m_currentChatUserID;
				}
				set
				{
					this.m_owner.m_currentChatUserID = value;
				}
			}

			// Token: 0x17002780 RID: 10112
			// (get) Token: 0x0600C64E RID: 50766 RVA: 0x0036F860 File Offset: 0x0036DA60
			// (set) Token: 0x0600C64F RID: 50767 RVA: 0x0036F870 File Offset: 0x0036DA70
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

			// Token: 0x17002781 RID: 10113
			// (get) Token: 0x0600C650 RID: 50768 RVA: 0x0036F880 File Offset: 0x0036DA80
			// (set) Token: 0x0600C651 RID: 50769 RVA: 0x0036F890 File Offset: 0x0036DA90
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

			// Token: 0x17002782 RID: 10114
			// (get) Token: 0x0600C652 RID: 50770 RVA: 0x0036F8A0 File Offset: 0x0036DAA0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002783 RID: 10115
			// (get) Token: 0x0600C653 RID: 50771 RVA: 0x0036F8B0 File Offset: 0x0036DAB0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600C654 RID: 50772 RVA: 0x0036F8C0 File Offset: 0x0036DAC0
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600C655 RID: 50773 RVA: 0x0036F8D0 File Offset: 0x0036DAD0
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x0600C656 RID: 50774 RVA: 0x0036F8E0 File Offset: 0x0036DAE0
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600C657 RID: 50775 RVA: 0x0036F8F0 File Offset: 0x0036DAF0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600C658 RID: 50776 RVA: 0x0036F900 File Offset: 0x0036DB00
			public bool OnGetChatTargetInfoEndFroResume(UIIntent intent)
			{
				return this.m_owner.OnGetChatTargetInfoEndFroResume(intent);
			}

			// Token: 0x0600C659 RID: 50777 RVA: 0x0036F910 File Offset: 0x0036DB10
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600C65A RID: 50778 RVA: 0x0036F920 File Offset: 0x0036DB20
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600C65B RID: 50779 RVA: 0x0036F930 File Offset: 0x0036DB30
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600C65C RID: 50780 RVA: 0x0036F940 File Offset: 0x0036DB40
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x0600C65D RID: 50781 RVA: 0x0036F950 File Offset: 0x0036DB50
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x0600C65E RID: 50782 RVA: 0x0036F960 File Offset: 0x0036DB60
			public IEnumerator RequestMicrophonePermission()
			{
				return this.m_owner.RequestMicrophonePermission();
			}

			// Token: 0x0600C65F RID: 50783 RVA: 0x0036F970 File Offset: 0x0036DB70
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600C660 RID: 50784 RVA: 0x0036F980 File Offset: 0x0036DB80
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600C661 RID: 50785 RVA: 0x0036F990 File Offset: 0x0036DB90
			public void OnExpressionBgButtonClick()
			{
				this.m_owner.OnExpressionBgButtonClick();
			}

			// Token: 0x0600C662 RID: 50786 RVA: 0x0036F9A0 File Offset: 0x0036DBA0
			public void OnExpressionFunctionButtonClick()
			{
				this.m_owner.OnExpressionFunctionButtonClick();
			}

			// Token: 0x0600C663 RID: 50787 RVA: 0x0036F9B0 File Offset: 0x0036DBB0
			public void OnItemVoiceButtonClick(ChatComponent.ChatMessageClient voiceInfo)
			{
				this.m_owner.OnItemVoiceButtonClick(voiceInfo);
			}

			// Token: 0x0600C664 RID: 50788 RVA: 0x0036F9C0 File Offset: 0x0036DBC0
			public void OnPlayerIconClick(ChatMessage chatInfo, GameObject playerIcon)
			{
				this.m_owner.OnPlayerIconClick(chatInfo, playerIcon);
			}

			// Token: 0x0600C665 RID: 50789 RVA: 0x0036F9D0 File Offset: 0x0036DBD0
			public void ShowPlayerSimpleInfo(GameObject playerIcon)
			{
				this.m_owner.ShowPlayerSimpleInfo(playerIcon);
			}

			// Token: 0x0600C666 RID: 50790 RVA: 0x0036F9E0 File Offset: 0x0036DBE0
			public void PlayerSimpleInfo_OnPrivateChatButtonClick(BusinessCard playerInfo)
			{
				this.m_owner.PlayerSimpleInfo_OnPrivateChatButtonClick(playerInfo);
			}

			// Token: 0x0600C667 RID: 50791 RVA: 0x0036F9F0 File Offset: 0x0036DBF0
			public void PlayerSimpleInfo_OnBlockUser()
			{
				this.m_owner.PlayerSimpleInfo_OnBlockUser();
			}

			// Token: 0x0600C668 RID: 50792 RVA: 0x0036FA00 File Offset: 0x0036DC00
			public void OnTalkButtonHold()
			{
				this.m_owner.OnTalkButtonHold();
			}

			// Token: 0x0600C669 RID: 50793 RVA: 0x0036FA10 File Offset: 0x0036DC10
			public void OnTalkButtonClickUp()
			{
				this.m_owner.OnTalkButtonClickUp();
			}

			// Token: 0x0600C66A RID: 50794 RVA: 0x0036FA20 File Offset: 0x0036DC20
			public void OnExitTalkButton()
			{
				this.m_owner.OnExitTalkButton();
			}

			// Token: 0x0600C66B RID: 50795 RVA: 0x0036FA30 File Offset: 0x0036DC30
			public void OnEnterTalkButton()
			{
				this.m_owner.OnEnterTalkButton();
			}

			// Token: 0x0600C66C RID: 50796 RVA: 0x0036FA40 File Offset: 0x0036DC40
			public void OnTableChange(ChatChannel currentTableType)
			{
				this.m_owner.OnTableChange(currentTableType);
			}

			// Token: 0x0600C66D RID: 50797 RVA: 0x0036FA50 File Offset: 0x0036DC50
			public void OnChatTargetChanged(ChatChannel channel, string id, string name)
			{
				this.m_owner.OnChatTargetChanged(channel, id, name);
			}

			// Token: 0x0600C66E RID: 50798 RVA: 0x0036FA60 File Offset: 0x0036DC60
			public void OnSendButtonClick(string content)
			{
				this.m_owner.OnSendButtonClick(content);
			}

			// Token: 0x0600C66F RID: 50799 RVA: 0x0036FA70 File Offset: 0x0036DC70
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x0600C670 RID: 50800 RVA: 0x0036FA80 File Offset: 0x0036DC80
			public void ReturnPrevUITask()
			{
				this.m_owner.ReturnPrevUITask();
			}

			// Token: 0x0600C671 RID: 50801 RVA: 0x0036FA90 File Offset: 0x0036DC90
			public void OnVoiceRecordTimeout(ChatChannel channel)
			{
				this.m_owner.OnVoiceRecordTimeout(channel);
			}

			// Token: 0x0600C672 RID: 50802 RVA: 0x0036FAA0 File Offset: 0x0036DCA0
			public void GetDataFromIntent(UIIntent intent)
			{
				this.m_owner.GetDataFromIntent(intent);
			}

			// Token: 0x0600C673 RID: 50803 RVA: 0x0036FAB0 File Offset: 0x0036DCB0
			public void TryGetPrivateChatPlayerInfoList(List<string> playerIdList, Action action)
			{
				this.m_owner.TryGetPrivateChatPlayerInfoList(playerIdList, action);
			}

			// Token: 0x0600C674 RID: 50804 RVA: 0x0036FAC0 File Offset: 0x0036DCC0
			public void TryGetPrivateChatPlayerInfoListFilterBlacklist(string userID)
			{
				this.m_owner.TryGetPrivateChatPlayerInfoListFilterBlacklist(userID);
			}

			// Token: 0x0600C675 RID: 50805 RVA: 0x0036FAD0 File Offset: 0x0036DCD0
			public void TryGetChatGroupInfoList(Action action)
			{
				this.m_owner.TryGetChatGroupInfoList(action);
			}

			// Token: 0x0600C676 RID: 50806 RVA: 0x0036FAE0 File Offset: 0x0036DCE0
			public void OnChatMessageNtf(ChatMessage info)
			{
				this.m_owner.OnChatMessageNtf(info);
			}

			// Token: 0x0600C677 RID: 50807 RVA: 0x0036FAF0 File Offset: 0x0036DCF0
			public void OnChatMessageAck(int result)
			{
				this.m_owner.OnChatMessageAck(result);
			}

			// Token: 0x0600C678 RID: 50808 RVA: 0x0036FB00 File Offset: 0x0036DD00
			public void OnChatGroupUpdateNtf(ProChatGroupInfo chatGroupInfo)
			{
				this.m_owner.OnChatGroupUpdateNtf(chatGroupInfo);
			}

			// Token: 0x0600C679 RID: 50809 RVA: 0x0036FB10 File Offset: 0x0036DD10
			public void EventOnFriendGetSocialRelationNtf(int result)
			{
				this.m_owner.EventOnFriendGetSocialRelationNtf(result);
			}

			// Token: 0x0600C67A RID: 50810 RVA: 0x0036FB20 File Offset: 0x0036DD20
			public bool IsPipelineStateMaskNeedUpdate(ChatUITask.PipeLineStateMaskType state)
			{
				return this.m_owner.IsPipelineStateMaskNeedUpdate(state);
			}

			// Token: 0x0600C67B RID: 50811 RVA: 0x0036FB30 File Offset: 0x0036DD30
			public void EnablePipelineStateMask(ChatUITask.PipeLineStateMaskType state)
			{
				this.m_owner.EnablePipelineStateMask(state);
			}

			// Token: 0x0600C67C RID: 50812 RVA: 0x0036FB40 File Offset: 0x0036DD40
			public List<ChatComponent.ChatMessageClient> GetCurrentChatListByTableType()
			{
				return this.m_owner.GetCurrentChatListByTableType();
			}

			// Token: 0x0600C67D RID: 50813 RVA: 0x0036FB50 File Offset: 0x0036DD50
			public void TickForVoiceRecordTime()
			{
				this.m_owner.TickForVoiceRecordTime();
			}

			// Token: 0x0600C67E RID: 50814 RVA: 0x0036FB60 File Offset: 0x0036DD60
			public void TickForHistoryRecordShow()
			{
				this.m_owner.TickForHistoryRecordShow();
			}

			// Token: 0x0600C67F RID: 50815 RVA: 0x0036FB70 File Offset: 0x0036DD70
			public void TickForVoiceAnim()
			{
				this.m_owner.TickForVoiceAnim();
			}

			// Token: 0x0600C680 RID: 50816 RVA: 0x0036FB80 File Offset: 0x0036DD80
			public void PlayVoiceAnim()
			{
				this.m_owner.PlayVoiceAnim();
			}

			// Token: 0x0600C681 RID: 50817 RVA: 0x0036FB90 File Offset: 0x0036DD90
			public void StopAllVoiceAnim()
			{
				this.m_owner.StopAllVoiceAnim();
			}

			// Token: 0x0600C682 RID: 50818 RVA: 0x0036FBA0 File Offset: 0x0036DDA0
			public void OnChatVoiceStartPlay(ChatComponent.ChatMessageClient voiceMsg)
			{
				this.m_owner.OnChatVoiceStartPlay(voiceMsg);
			}

			// Token: 0x0600C683 RID: 50819 RVA: 0x0036FBB0 File Offset: 0x0036DDB0
			public List<ChatComponent.ChatMessageClient> GetChatMsgWithBlacklist(ChatChannel channel)
			{
				return this.m_owner.GetChatMsgWithBlacklist(channel);
			}

			// Token: 0x0600C684 RID: 50820 RVA: 0x0036FBC0 File Offset: 0x0036DDC0
			public IEnumerator DelayInstancePrefab()
			{
				return this.m_owner.DelayInstancePrefab();
			}

			// Token: 0x0600C685 RID: 50821 RVA: 0x0036FBD0 File Offset: 0x0036DDD0
			public void RefreshRedState()
			{
				this.m_owner.RefreshRedState();
			}

			// Token: 0x04007D88 RID: 32136
			private ChatUITask m_owner;
		}
	}
}
