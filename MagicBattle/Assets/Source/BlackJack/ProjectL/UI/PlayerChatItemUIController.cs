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
	// Token: 0x02000B48 RID: 2888
	[HotFix]
	public class PlayerChatItemUIController : UIControllerBase
	{
		// Token: 0x0600C456 RID: 50262 RVA: 0x003659A8 File Offset: 0x00363BA8
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
		}

		// Token: 0x0600C457 RID: 50263 RVA: 0x00365A10 File Offset: 0x00363C10
		public void UpdateChatInfo(ChatComponent.ChatMessageClient chatClientInfo, bool isPlaying = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChatInfoChatMessageClientBoolean_hotfix != null)
			{
				this.m_UpdateChatInfoChatMessageClientBoolean_hotfix.call(new object[]
				{
					this,
					chatClientInfo,
					isPlaying
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currChatInfo = chatClientInfo;
			ChatMessage chatMessageInfo = chatClientInfo.ChatMessageInfo;
			ChatContentType chatContentType = chatMessageInfo.ChatContentType;
			if (chatContentType != ChatContentType.Text)
			{
				if (chatContentType != ChatContentType.Voice)
				{
					if (chatContentType == ChatContentType.CustomBigExpression)
					{
						this.PlayerNameText.text = chatMessageInfo.SrcName;
						ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
						this.SendTimeText.text = this.SetChatMsgTime(projectLPlayerContext.ServerTimeToLocalTime(chatMessageInfo.SendTime));
						ChatChannel channelId = chatMessageInfo.ChannelId;
						if (channelId != ChatChannel.Sys)
						{
							this.PlayerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(chatMessageInfo.AvatarId)));
							UIUtility.SetPlayerHeadFrame(this.PlayerHeadFrameTransform, HeadIconTools.GetHeadFrame(chatMessageInfo.AvatarId), true, "Normal");
							this.PlayerLevelText.text = chatMessageInfo.SrcPlayerLevel.ToString();
						}
						string text = (chatMessageInfo as ChatTextMessage).Text;
						int key = int.Parse(text);
						IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
						ConfigDataBigExpressionInfo configDataBigExpressionInfo = configDataLoader.GetConfigDataBigExpressionInfo(key);
						this.FaceIcon.sprite = AssetUtility.Instance.GetSprite(configDataBigExpressionInfo.ExpressionIconPath);
						this.SetToBigExpressionMode();
					}
				}
				else
				{
					this.PlayerNameText.text = chatMessageInfo.SrcName;
					ProjectLPlayerContext projectLPlayerContext2 = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					this.SendTimeText.text = this.SetChatMsgTime(projectLPlayerContext2.ServerTimeToLocalTime(chatMessageInfo.SendTime));
					ChatChannel channelId2 = chatMessageInfo.ChannelId;
					if (channelId2 != ChatChannel.Sys)
					{
						this.PlayerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(chatMessageInfo.AvatarId)));
						UIUtility.SetPlayerHeadFrame(this.PlayerHeadFrameTransform, HeadIconTools.GetHeadFrame(chatMessageInfo.AvatarId), true, "Normal");
						this.PlayerLevelText.text = chatMessageInfo.SrcPlayerLevel.ToString();
					}
					ChatVoiceMessage chatVoiceMessage = chatMessageInfo as ChatVoiceMessage;
					this.VoiceLengthText.text = chatVoiceMessage.VoiceLength.ToString() + "'";
					this.VoiceContentText.text = chatVoiceMessage.TranslateText;
					if (string.IsNullOrEmpty(chatVoiceMessage.TranslateText))
					{
						this.VoiceContentText.gameObject.SetActive(false);
					}
					else
					{
						this.VoiceContentText.gameObject.SetActive(true);
					}
					this.SetToVoiceMode();
				}
			}
			else
			{
				this.PlayerNameText.text = chatMessageInfo.SrcName;
				ProjectLPlayerContext projectLPlayerContext3 = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				this.SendTimeText.text = this.SetChatMsgTime(projectLPlayerContext3.ServerTimeToLocalTime(chatMessageInfo.SendTime));
				ChatChannel channelId3 = chatMessageInfo.ChannelId;
				if (channelId3 != ChatChannel.Sys)
				{
					this.PlayerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(chatMessageInfo.AvatarId)));
					UIUtility.SetPlayerHeadFrame(this.PlayerHeadFrameTransform, HeadIconTools.GetHeadFrame(chatMessageInfo.AvatarId), true, "Normal");
					this.PlayerLevelText.text = chatMessageInfo.SrcPlayerLevel.ToString();
				}
				string text2 = (chatMessageInfo as ChatTextMessage).Text;
				if (this.m_isEmojiTextInit)
				{
					this.ContentText.SetContent(text2);
				}
				else
				{
					this.ContentText.text = text2;
				}
				this.SetToTextMode();
			}
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600C458 RID: 50264 RVA: 0x00365E00 File Offset: 0x00364000
		public void InitEmojiText(int fontSize, Image image)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEmojiTextInt32Image_hotfix != null)
			{
				this.m_InitEmojiTextInt32Image_hotfix.call(new object[]
				{
					this,
					fontSize,
					image
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ContentText.Init(fontSize, image);
			this.m_isEmojiTextInit = true;
		}

		// Token: 0x0600C459 RID: 50265 RVA: 0x00365E94 File Offset: 0x00364094
		public bool IsPlaying()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPlaying_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPlaying_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.VoicePlayerStateCtrl.GetCurrentUIState();
			return currentUIState == null || currentUIState.StateName == "Show";
		}

		// Token: 0x0600C45A RID: 50266 RVA: 0x00365F2C File Offset: 0x0036412C
		public void SetPlayState(bool play)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayStateBoolean_hotfix != null)
			{
				this.m_SetPlayStateBoolean_hotfix.call(new object[]
				{
					this,
					play
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (play == this.IsPlaying())
			{
				return;
			}
			this.VoicePlayerStateCtrl.SetToUIState((!play) ? "Close" : "Show", false, true);
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x00365FCC File Offset: 0x003641CC
		public void RegClickEvent(Action<ChatComponent.ChatMessageClient> voiceAction, Action<ChatMessage, GameObject> playeIconAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegClickEventAction`1Action`2_hotfix != null)
			{
				this.m_RegClickEventAction`1Action`2_hotfix.call(new object[]
				{
					this,
					voiceAction,
					playeIconAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isUIEventInited)
			{
				this.m_isUIEventInited = true;
				this.VoiceButton.onClick.RemoveAllListeners();
				this.VoiceButton.onClick.AddListener(new UnityAction(this.OnVoiceButtonClick));
				this.PlayerIconButton.onClick.RemoveAllListeners();
				this.PlayerIconButton.onClick.AddListener(new UnityAction(this.OnPlayerHeadClick));
			}
			this.EventOnVoiceButtonClick = null;
			if (voiceAction != null)
			{
				this.EventOnVoiceButtonClick += voiceAction;
			}
			this.EventOnPlayerHeadClick = null;
			if (playeIconAction != null)
			{
				this.EventOnPlayerHeadClick += playeIconAction;
			}
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x003660E0 File Offset: 0x003642E0
		private void SetToVoiceMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToVoiceMode_hotfix != null)
			{
				this.m_SetToVoiceMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.itemStateCtrl.SetToUIState("Voice", false, true);
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x00366154 File Offset: 0x00364354
		private void SetToTextMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToTextMode_hotfix != null)
			{
				this.m_SetToTextMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.itemStateCtrl.SetToUIState("Word", false, true);
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x003661C8 File Offset: 0x003643C8
		private void SetToBigExpressionMode()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToBigExpressionMode_hotfix != null)
			{
				this.m_SetToBigExpressionMode_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.itemStateCtrl.SetToUIState("Image", false, true);
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x0036623C File Offset: 0x0036443C
		private string SetChatMsgTime(DateTime time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChatMsgTimeDateTime_hotfix != null)
			{
				return (string)this.m_SetChatMsgTimeDateTime_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			DateTime localTime = projectLPlayerContext.GetLocalTime();
			TimeSpan timeSpan = new TimeSpan(time.Ticks);
			TimeSpan ts = new TimeSpan(localTime.Ticks);
			TimeSpan timeSpan2 = timeSpan.Subtract(ts).Duration();
			string result = time.ToString(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_TimeSpanLessThanAnHour));
			if (timeSpan2.Days > 1)
			{
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_TimeSpanMoreThanADay);
			}
			else if (timeSpan2.Hours > 1)
			{
				result = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_TimeSpanLessThanADay), timeSpan2.Hours);
			}
			return result;
		}

		// Token: 0x0600C460 RID: 50272 RVA: 0x00366370 File Offset: 0x00364570
		private void OnVoiceButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoiceButtonClick_hotfix != null)
			{
				this.m_OnVoiceButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatVoiceMessage chatVoiceMessage = this.m_currChatInfo.ChatMessageInfo as ChatVoiceMessage;
			if (this.EventOnVoiceButtonClick != null && chatVoiceMessage != null)
			{
				this.EventOnVoiceButtonClick(this.m_currChatInfo);
			}
			else
			{
				global::Debug.LogError("WorldChatItemUIController::OnVoiceButtonClick::Event Null Or VoiceInfo Null");
			}
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x00366414 File Offset: 0x00364614
		private void OnPlayerHeadClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerHeadClick_hotfix != null)
			{
				this.m_OnPlayerHeadClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPlayerHeadClick != null && this.m_currChatInfo != null)
			{
				this.EventOnPlayerHeadClick(this.m_currChatInfo.ChatMessageInfo, this.PlayerIconImage.gameObject);
			}
		}

		// Token: 0x14000258 RID: 600
		// (add) Token: 0x0600C462 RID: 50274 RVA: 0x003664AC File Offset: 0x003646AC
		// (remove) Token: 0x0600C463 RID: 50275 RVA: 0x00366548 File Offset: 0x00364748
		public event Action<ChatComponent.ChatMessageClient> EventOnVoiceButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnVoiceButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnVoiceButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatComponent.ChatMessageClient> action = this.EventOnVoiceButtonClick;
				Action<ChatComponent.ChatMessageClient> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatComponent.ChatMessageClient>>(ref this.EventOnVoiceButtonClick, (Action<ChatComponent.ChatMessageClient>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnVoiceButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnVoiceButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatComponent.ChatMessageClient> action = this.EventOnVoiceButtonClick;
				Action<ChatComponent.ChatMessageClient> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatComponent.ChatMessageClient>>(ref this.EventOnVoiceButtonClick, (Action<ChatComponent.ChatMessageClient>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000259 RID: 601
		// (add) Token: 0x0600C464 RID: 50276 RVA: 0x003665E4 File Offset: 0x003647E4
		// (remove) Token: 0x0600C465 RID: 50277 RVA: 0x00366680 File Offset: 0x00364880
		public event Action<ChatMessage, GameObject> EventOnPlayerHeadClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPlayerHeadClickAction`2_hotfix != null)
				{
					this.m_add_EventOnPlayerHeadClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatMessage, GameObject> action = this.EventOnPlayerHeadClick;
				Action<ChatMessage, GameObject> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatMessage, GameObject>>(ref this.EventOnPlayerHeadClick, (Action<ChatMessage, GameObject>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPlayerHeadClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnPlayerHeadClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatMessage, GameObject> action = this.EventOnPlayerHeadClick;
				Action<ChatMessage, GameObject> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatMessage, GameObject>>(ref this.EventOnPlayerHeadClick, (Action<ChatMessage, GameObject>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600C466 RID: 50278 RVA: 0x0036671C File Offset: 0x0036491C
		// (set) Token: 0x0600C467 RID: 50279 RVA: 0x0036673C File Offset: 0x0036493C
		[DoNotToLua]
		public new PlayerChatItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerChatItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x00366748 File Offset: 0x00364948
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x00366754 File Offset: 0x00364954
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x0036675C File Offset: 0x0036495C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x00366764 File Offset: 0x00364964
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x00366778 File Offset: 0x00364978
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x00366780 File Offset: 0x00364980
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C46E RID: 50286 RVA: 0x0036678C File Offset: 0x0036498C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C46F RID: 50287 RVA: 0x00366798 File Offset: 0x00364998
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C470 RID: 50288 RVA: 0x003667A4 File Offset: 0x003649A4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C471 RID: 50289 RVA: 0x003667B0 File Offset: 0x003649B0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C472 RID: 50290 RVA: 0x003667BC File Offset: 0x003649BC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x003667C8 File Offset: 0x003649C8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C474 RID: 50292 RVA: 0x003667D4 File Offset: 0x003649D4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C475 RID: 50293 RVA: 0x003667E0 File Offset: 0x003649E0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C476 RID: 50294 RVA: 0x003667EC File Offset: 0x003649EC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C477 RID: 50295 RVA: 0x003667F4 File Offset: 0x003649F4
		private void __callDele_EventOnVoiceButtonClick(ChatComponent.ChatMessageClient obj)
		{
			Action<ChatComponent.ChatMessageClient> eventOnVoiceButtonClick = this.EventOnVoiceButtonClick;
			if (eventOnVoiceButtonClick != null)
			{
				eventOnVoiceButtonClick(obj);
			}
		}

		// Token: 0x0600C478 RID: 50296 RVA: 0x00366818 File Offset: 0x00364A18
		private void __clearDele_EventOnVoiceButtonClick(ChatComponent.ChatMessageClient obj)
		{
			this.EventOnVoiceButtonClick = null;
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x00366824 File Offset: 0x00364A24
		private void __callDele_EventOnPlayerHeadClick(ChatMessage arg1, GameObject arg2)
		{
			Action<ChatMessage, GameObject> eventOnPlayerHeadClick = this.EventOnPlayerHeadClick;
			if (eventOnPlayerHeadClick != null)
			{
				eventOnPlayerHeadClick(arg1, arg2);
			}
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x00366848 File Offset: 0x00364A48
		private void __clearDele_EventOnPlayerHeadClick(ChatMessage arg1, GameObject arg2)
		{
			this.EventOnPlayerHeadClick = null;
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x00366854 File Offset: 0x00364A54
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
					this.m_UpdateChatInfoChatMessageClientBoolean_hotfix = (luaObj.RawGet("UpdateChatInfo") as LuaFunction);
					this.m_InitEmojiTextInt32Image_hotfix = (luaObj.RawGet("InitEmojiText") as LuaFunction);
					this.m_IsPlaying_hotfix = (luaObj.RawGet("IsPlaying") as LuaFunction);
					this.m_SetPlayStateBoolean_hotfix = (luaObj.RawGet("SetPlayState") as LuaFunction);
					this.m_RegClickEventAction`1Action`2_hotfix = (luaObj.RawGet("RegClickEvent") as LuaFunction);
					this.m_SetToVoiceMode_hotfix = (luaObj.RawGet("SetToVoiceMode") as LuaFunction);
					this.m_SetToTextMode_hotfix = (luaObj.RawGet("SetToTextMode") as LuaFunction);
					this.m_SetToBigExpressionMode_hotfix = (luaObj.RawGet("SetToBigExpressionMode") as LuaFunction);
					this.m_SetChatMsgTimeDateTime_hotfix = (luaObj.RawGet("SetChatMsgTime") as LuaFunction);
					this.m_OnVoiceButtonClick_hotfix = (luaObj.RawGet("OnVoiceButtonClick") as LuaFunction);
					this.m_OnPlayerHeadClick_hotfix = (luaObj.RawGet("OnPlayerHeadClick") as LuaFunction);
					this.m_add_EventOnVoiceButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnVoiceButtonClick") as LuaFunction);
					this.m_remove_EventOnVoiceButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnVoiceButtonClick") as LuaFunction);
					this.m_add_EventOnPlayerHeadClickAction`2_hotfix = (luaObj.RawGet("add_EventOnPlayerHeadClick") as LuaFunction);
					this.m_remove_EventOnPlayerHeadClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnPlayerHeadClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x00366A98 File Offset: 0x00364C98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerChatItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007C61 RID: 31841
		private bool m_isUIEventInited;

		// Token: 0x04007C62 RID: 31842
		public bool m_isEmojiTextInit;

		// Token: 0x04007C63 RID: 31843
		public ChatComponent.ChatMessageClient m_currChatInfo;

		// Token: 0x04007C64 RID: 31844
		[AutoBind("./TimeAndPlayerName/PlayerNameText", AutoBindAttribute.InitState.Active, false)]
		public Text PlayerNameText;

		// Token: 0x04007C65 RID: 31845
		[AutoBind("./TimeAndPlayerName/SendTimeText", AutoBindAttribute.InitState.Active, false)]
		public Text SendTimeText;

		// Token: 0x04007C66 RID: 31846
		[AutoBind("./PlayerIcon/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image PlayerIconImage;

		// Token: 0x04007C67 RID: 31847
		[AutoBind("./PlayerIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		public Transform PlayerHeadFrameTransform;

		// Token: 0x04007C68 RID: 31848
		[AutoBind("./PlayerIcon/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		public Text PlayerLevelText;

		// Token: 0x04007C69 RID: 31849
		[AutoBind("./PlayerIcon/PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		public Button PlayerIconButton;

		// Token: 0x04007C6A RID: 31850
		[AutoBind("./ContentBG/ContentText", AutoBindAttribute.InitState.Active, false)]
		public EmojiText ContentText;

		// Token: 0x04007C6B RID: 31851
		[AutoBind("./ContentBG", AutoBindAttribute.InitState.Active, false)]
		public GameObject ContentGo;

		// Token: 0x04007C6C RID: 31852
		[AutoBind("./Voice/Voice/SpeakImage", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController VoicePlayerStateCtrl;

		// Token: 0x04007C6D RID: 31853
		[AutoBind("./Voice", AutoBindAttribute.InitState.NotInit, false)]
		public Button VoiceButton;

		// Token: 0x04007C6E RID: 31854
		[AutoBind("./Voice/Voice/TimeButton/ContentText", AutoBindAttribute.InitState.Active, false)]
		public Text VoiceLengthText;

		// Token: 0x04007C6F RID: 31855
		[AutoBind("./Voice/ContentText", AutoBindAttribute.InitState.Active, false)]
		public Text VoiceContentText;

		// Token: 0x04007C70 RID: 31856
		[AutoBind("./Voice", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject VoiceRoot;

		// Token: 0x04007C71 RID: 31857
		[AutoBind("./Face", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject FaceRoot;

		// Token: 0x04007C72 RID: 31858
		[AutoBind("./Face/Image", AutoBindAttribute.InitState.NotInit, false)]
		public Image FaceIcon;

		// Token: 0x04007C73 RID: 31859
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController itemStateCtrl;

		// Token: 0x04007C74 RID: 31860
		[DoNotToLua]
		private PlayerChatItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007C75 RID: 31861
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007C76 RID: 31862
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007C77 RID: 31863
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007C78 RID: 31864
		private LuaFunction m_UpdateChatInfoChatMessageClientBoolean_hotfix;

		// Token: 0x04007C79 RID: 31865
		private LuaFunction m_InitEmojiTextInt32Image_hotfix;

		// Token: 0x04007C7A RID: 31866
		private LuaFunction m_IsPlaying_hotfix;

		// Token: 0x04007C7B RID: 31867
		private LuaFunction m_SetPlayStateBoolean_hotfix;

		// Token: 0x04007C7C RID: 31868
		private LuaFunction m_RegClickEventAction`1Action;

		// Token: 0x04007C7D RID: 31869
		private LuaFunction m_SetToVoiceMode_hotfix;

		// Token: 0x04007C7E RID: 31870
		private LuaFunction m_SetToTextMode_hotfix;

		// Token: 0x04007C7F RID: 31871
		private LuaFunction m_SetToBigExpressionMode_hotfix;

		// Token: 0x04007C80 RID: 31872
		private LuaFunction m_SetChatMsgTimeDateTime_hotfix;

		// Token: 0x04007C81 RID: 31873
		private LuaFunction m_OnVoiceButtonClick_hotfix;

		// Token: 0x04007C82 RID: 31874
		private LuaFunction m_OnPlayerHeadClick_hotfix;

		// Token: 0x04007C83 RID: 31875
		private LuaFunction m_add_EventOnVoiceButtonClickAction;

		// Token: 0x04007C84 RID: 31876
		private LuaFunction m_remove_EventOnVoiceButtonClickAction;

		// Token: 0x04007C85 RID: 31877
		private LuaFunction m_add_EventOnPlayerHeadClickAction;

		// Token: 0x04007C86 RID: 31878
		private LuaFunction m_remove_EventOnPlayerHeadClickAction;

		// Token: 0x02000B49 RID: 2889
		public new class LuaExportHelper
		{
			// Token: 0x0600C47D RID: 50301 RVA: 0x00366B00 File Offset: 0x00364D00
			public LuaExportHelper(PlayerChatItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C47E RID: 50302 RVA: 0x00366B10 File Offset: 0x00364D10
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C47F RID: 50303 RVA: 0x00366B20 File Offset: 0x00364D20
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C480 RID: 50304 RVA: 0x00366B30 File Offset: 0x00364D30
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C481 RID: 50305 RVA: 0x00366B40 File Offset: 0x00364D40
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C482 RID: 50306 RVA: 0x00366B58 File Offset: 0x00364D58
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C483 RID: 50307 RVA: 0x00366B68 File Offset: 0x00364D68
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C484 RID: 50308 RVA: 0x00366B78 File Offset: 0x00364D78
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C485 RID: 50309 RVA: 0x00366B88 File Offset: 0x00364D88
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C486 RID: 50310 RVA: 0x00366B98 File Offset: 0x00364D98
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C487 RID: 50311 RVA: 0x00366BA8 File Offset: 0x00364DA8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C488 RID: 50312 RVA: 0x00366BB8 File Offset: 0x00364DB8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C489 RID: 50313 RVA: 0x00366BC8 File Offset: 0x00364DC8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C48A RID: 50314 RVA: 0x00366BD8 File Offset: 0x00364DD8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C48B RID: 50315 RVA: 0x00366BE8 File Offset: 0x00364DE8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C48C RID: 50316 RVA: 0x00366BF8 File Offset: 0x00364DF8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C48D RID: 50317 RVA: 0x00366C08 File Offset: 0x00364E08
			public void __callDele_EventOnVoiceButtonClick(ChatComponent.ChatMessageClient obj)
			{
				this.m_owner.__callDele_EventOnVoiceButtonClick(obj);
			}

			// Token: 0x0600C48E RID: 50318 RVA: 0x00366C18 File Offset: 0x00364E18
			public void __clearDele_EventOnVoiceButtonClick(ChatComponent.ChatMessageClient obj)
			{
				this.m_owner.__clearDele_EventOnVoiceButtonClick(obj);
			}

			// Token: 0x0600C48F RID: 50319 RVA: 0x00366C28 File Offset: 0x00364E28
			public void __callDele_EventOnPlayerHeadClick(ChatMessage arg1, GameObject arg2)
			{
				this.m_owner.__callDele_EventOnPlayerHeadClick(arg1, arg2);
			}

			// Token: 0x0600C490 RID: 50320 RVA: 0x00366C38 File Offset: 0x00364E38
			public void __clearDele_EventOnPlayerHeadClick(ChatMessage arg1, GameObject arg2)
			{
				this.m_owner.__clearDele_EventOnPlayerHeadClick(arg1, arg2);
			}

			// Token: 0x1700274C RID: 10060
			// (get) Token: 0x0600C491 RID: 50321 RVA: 0x00366C48 File Offset: 0x00364E48
			// (set) Token: 0x0600C492 RID: 50322 RVA: 0x00366C58 File Offset: 0x00364E58
			public bool m_isUIEventInited
			{
				get
				{
					return this.m_owner.m_isUIEventInited;
				}
				set
				{
					this.m_owner.m_isUIEventInited = value;
				}
			}

			// Token: 0x0600C493 RID: 50323 RVA: 0x00366C68 File Offset: 0x00364E68
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C494 RID: 50324 RVA: 0x00366C78 File Offset: 0x00364E78
			public void SetToVoiceMode()
			{
				this.m_owner.SetToVoiceMode();
			}

			// Token: 0x0600C495 RID: 50325 RVA: 0x00366C88 File Offset: 0x00364E88
			public void SetToTextMode()
			{
				this.m_owner.SetToTextMode();
			}

			// Token: 0x0600C496 RID: 50326 RVA: 0x00366C98 File Offset: 0x00364E98
			public void SetToBigExpressionMode()
			{
				this.m_owner.SetToBigExpressionMode();
			}

			// Token: 0x0600C497 RID: 50327 RVA: 0x00366CA8 File Offset: 0x00364EA8
			public string SetChatMsgTime(DateTime time)
			{
				return this.m_owner.SetChatMsgTime(time);
			}

			// Token: 0x0600C498 RID: 50328 RVA: 0x00366CB8 File Offset: 0x00364EB8
			public void OnVoiceButtonClick()
			{
				this.m_owner.OnVoiceButtonClick();
			}

			// Token: 0x0600C499 RID: 50329 RVA: 0x00366CC8 File Offset: 0x00364EC8
			public void OnPlayerHeadClick()
			{
				this.m_owner.OnPlayerHeadClick();
			}

			// Token: 0x04007C87 RID: 31879
			private PlayerChatItemUIController m_owner;
		}
	}
}
