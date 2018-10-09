using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AC6 RID: 2758
	[HotFix]
	public class BattleTeamPlayerUIController : UIControllerBase
	{
		// Token: 0x0600B297 RID: 45719 RVA: 0x00315ED8 File Offset: 0x003140D8
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
			this.m_chatUIStateController.gameObject.SetActive(false);
			this.m_voiceButton.onClick.AddListener(new UnityAction(this.OnVoiceTimeButtonClick));
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x00315F6C File Offset: 0x0031416C
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
			this.m_dialogText.Init(fontSize, image);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x00315FFC File Offset: 0x003141FC
		public void SetStatus(PlayerBattleStatus status, bool isOffline)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusPlayerBattleStatusBoolean_hotfix != null)
			{
				this.m_SetStatusPlayerBattleStatusBoolean_hotfix.call(new object[]
				{
					this,
					status,
					isOffline
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_statusReadyGameObject.SetActive(status == PlayerBattleStatus.Ready);
			this.m_statusAutoGameObject.SetActive(status == PlayerBattleStatus.Auto && !isOffline);
			this.m_statusOfflineGameObject.SetActive(isOffline);
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x003160B0 File Offset: 0x003142B0
		public void SetAction(bool isAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActionBoolean_hotfix != null)
			{
				this.m_SetActionBoolean_hotfix.call(new object[]
				{
					this,
					isAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_statusActionGameObject.SetActive(isAction);
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x0031612C File Offset: 0x0031432C
		public void SetHeadIcon(int headIconId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeadIconInt32_hotfix != null)
			{
				this.m_SetHeadIconInt32_hotfix.call(new object[]
				{
					this,
					headIconId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_headIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerRoundHeadIconImageName(HeadIconTools.GetHeadPortrait(headIconId)));
			UIUtility.SetPlayerHeadFrame(this.m_headFrameTransform, HeadIconTools.GetHeadFrame(headIconId), true, "Normal");
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x003161D4 File Offset: 0x003143D4
		public void SetName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNameString_hotfix != null)
			{
				this.m_SetNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = name;
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x00316250 File Offset: 0x00314450
		public void SetLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInt32_hotfix != null)
			{
				this.m_SetLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelText.text = level.ToString();
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x003162D8 File Offset: 0x003144D8
		public void SetPlayerIndex(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerIndexInt32_hotfix != null)
			{
				this.m_SetPlayerIndexInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerTagImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetBattlePlayerTagImageName(idx));
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x00316364 File Offset: 0x00314564
		public void ShowPlayerIndex(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerIndexBoolean_hotfix != null)
			{
				this.m_ShowPlayerIndexBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerTagImage.gameObject.SetActive(show);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x003163E8 File Offset: 0x003145E8
		public void SetHeroCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroCountInt32_hotfix != null)
			{
				this.m_SetHeroCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < 3; i++)
			{
				GameObject heroPointBGGameObject = this.GetHeroPointBGGameObject(i);
				if (heroPointBGGameObject != null)
				{
					heroPointBGGameObject.SetActive(count > i);
				}
			}
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x00316488 File Offset: 0x00314688
		public void SetHeroAlive(int heroIdx, bool isAlive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroAliveInt32Boolean_hotfix != null)
			{
				this.m_SetHeroAliveInt32Boolean_hotfix.call(new object[]
				{
					this,
					heroIdx,
					isAlive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = this.GetHeroPointGameObject(heroIdx);
			if (gameObject != null)
			{
				gameObject.SetActive(isAlive);
			}
			gameObject = this.GetHeroRedPointGameObject(heroIdx);
			if (gameObject != null)
			{
				gameObject.SetActive(!isAlive);
			}
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x00316544 File Offset: 0x00314744
		public void ShowChat(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChatString_hotfix != null)
			{
				this.m_ShowChatString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogText.gameObject.SetActive(true);
			this.m_expressionImage.gameObject.SetActive(false);
			this.m_voiceButton.gameObject.SetActive(false);
			this.m_dialogText.SetContent(txt);
			this.m_chatUIStateController.SetToUIState("Show", false, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_hideChatTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamChatBubbleStayTime) * 0.001f;
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x00316630 File Offset: 0x00314830
		public void ShowBigExpression(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBigExpressionInt32_hotfix != null)
			{
				this.m_ShowBigExpressionInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogText.gameObject.SetActive(false);
			this.m_expressionImage.gameObject.SetActive(true);
			this.m_voiceButton.gameObject.SetActive(false);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataBigExpressionInfo configDataBigExpressionInfo = configDataLoader.GetConfigDataBigExpressionInfo(id);
			this.m_expressionImage.sprite = AssetUtility.Instance.GetSprite(configDataBigExpressionInfo.ExpressionIconPath);
			this.m_chatUIStateController.SetToUIState("Show", false, true);
			this.m_hideChatTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamChatBubbleStayTime) * 0.001f;
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x00316730 File Offset: 0x00314930
		public void ShowVoice(ChatVoiceMessage voiceMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceChatVoiceMessage_hotfix != null)
			{
				this.m_ShowVoiceChatVoiceMessage_hotfix.call(new object[]
				{
					this,
					voiceMessage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogText.gameObject.SetActive(false);
			this.m_expressionImage.gameObject.SetActive(false);
			this.m_voiceButton.gameObject.SetActive(true);
			this.m_voiceMessage = voiceMessage;
			this.m_voiceTimeButtonText.text = voiceMessage.VoiceLength + "'";
			string translateText = voiceMessage.TranslateText;
			bool active = translateText != string.Empty && translateText != null;
			this.m_voiceContentText.gameObject.SetActive(active);
			this.m_voiceContentText.text = translateText;
			this.m_chatUIStateController.SetToUIState("Show", false, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_hideChatTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_TeamChatBubbleStayTime) * 0.001f;
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x00316874 File Offset: 0x00314A74
		private void OnVoiceTimeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoiceTimeButtonClick_hotfix != null)
			{
				this.m_OnVoiceTimeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_voiceSpeakImageStateCtrl.SetToUIState("Show", false, true);
			if (GameManager.Instance.AudioManager.IsPlayerVoicePlaying())
			{
				GameManager.Instance.AudioManager.StopPlayerVoice();
				if (this.m_voiceMessage != null)
				{
					VoicePlayer.GetVoiceContentAndPlayVoice(this.m_voiceMessage, delegate
					{
						this.m_voiceSpeakImageStateCtrl.SetToUIState("Close", false, true);
					});
				}
				else
				{
					this.m_voiceSpeakImageStateCtrl.SetToUIState("Close", false, true);
				}
			}
			else
			{
				VoicePlayer.GetVoiceContentAndPlayVoice(this.m_voiceMessage, delegate
				{
					this.m_voiceSpeakImageStateCtrl.SetToUIState("Close", false, true);
				});
			}
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x00316960 File Offset: 0x00314B60
		private void HideChat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideChat_hotfix != null)
			{
				this.m_HideChat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatUIStateController.SetToUIState("Close", false, true);
			this.m_hideChatTime = 0f;
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x003169E0 File Offset: 0x00314BE0
		private void HideBigExpression()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideBigExpression_hotfix != null)
			{
				this.m_HideBigExpression_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatUIStateController.SetToUIState("Close", false, true);
			this.m_hideChatTime = 0f;
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x00316A60 File Offset: 0x00314C60
		private GameObject GetHeroPointBGGameObject(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroPointBGGameObjectInt32_hotfix != null)
			{
				return (GameObject)this.m_GetHeroPointBGGameObjectInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Utility.FindChildGameObject(base.gameObject, string.Format("PointBG{0}", idx + 1), true);
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x00316AFC File Offset: 0x00314CFC
		private GameObject GetHeroPointGameObject(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroPointGameObjectInt32_hotfix != null)
			{
				return (GameObject)this.m_GetHeroPointGameObjectInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Utility.FindChildGameObject(base.gameObject, string.Format("PointBG{0}/Point", idx + 1), true);
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x00316B98 File Offset: 0x00314D98
		private GameObject GetHeroRedPointGameObject(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroRedPointGameObjectInt32_hotfix != null)
			{
				return (GameObject)this.m_GetHeroRedPointGameObjectInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Utility.FindChildGameObject(base.gameObject, string.Format("PointBG{0}/RedPoint", idx + 1), true);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x00316C34 File Offset: 0x00314E34
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
			if (this.m_hideChatTime > 0f)
			{
				this.m_hideChatTime -= Time.unscaledDeltaTime;
				if (this.m_hideChatTime <= 0f)
				{
					this.m_hideChatTime = 0f;
					this.HideChat();
				}
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600B2AC RID: 45740 RVA: 0x00316CD8 File Offset: 0x00314ED8
		// (set) Token: 0x0600B2AD RID: 45741 RVA: 0x00316CF8 File Offset: 0x00314EF8
		[DoNotToLua]
		public new BattleTeamPlayerUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleTeamPlayerUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x00316D04 File Offset: 0x00314F04
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x00316D10 File Offset: 0x00314F10
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x00316D18 File Offset: 0x00314F18
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x00316D20 File Offset: 0x00314F20
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x00316D34 File Offset: 0x00314F34
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x00316D3C File Offset: 0x00314F3C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x00316D48 File Offset: 0x00314F48
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x00316D54 File Offset: 0x00314F54
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x00316D60 File Offset: 0x00314F60
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x00316D6C File Offset: 0x00314F6C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x00316D78 File Offset: 0x00314F78
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x00316D84 File Offset: 0x00314F84
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x00316D90 File Offset: 0x00314F90
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x00316D9C File Offset: 0x00314F9C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x00316DA8 File Offset: 0x00314FA8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x00316DD8 File Offset: 0x00314FD8
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
					this.m_InitEmojiTextInt32Image_hotfix = (luaObj.RawGet("InitEmojiText") as LuaFunction);
					this.m_SetStatusPlayerBattleStatusBoolean_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_SetActionBoolean_hotfix = (luaObj.RawGet("SetAction") as LuaFunction);
					this.m_SetHeadIconInt32_hotfix = (luaObj.RawGet("SetHeadIcon") as LuaFunction);
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_SetLevelInt32_hotfix = (luaObj.RawGet("SetLevel") as LuaFunction);
					this.m_SetPlayerIndexInt32_hotfix = (luaObj.RawGet("SetPlayerIndex") as LuaFunction);
					this.m_ShowPlayerIndexBoolean_hotfix = (luaObj.RawGet("ShowPlayerIndex") as LuaFunction);
					this.m_SetHeroCountInt32_hotfix = (luaObj.RawGet("SetHeroCount") as LuaFunction);
					this.m_SetHeroAliveInt32Boolean_hotfix = (luaObj.RawGet("SetHeroAlive") as LuaFunction);
					this.m_ShowChatString_hotfix = (luaObj.RawGet("ShowChat") as LuaFunction);
					this.m_ShowBigExpressionInt32_hotfix = (luaObj.RawGet("ShowBigExpression") as LuaFunction);
					this.m_ShowVoiceChatVoiceMessage_hotfix = (luaObj.RawGet("ShowVoice") as LuaFunction);
					this.m_OnVoiceTimeButtonClick_hotfix = (luaObj.RawGet("OnVoiceTimeButtonClick") as LuaFunction);
					this.m_HideChat_hotfix = (luaObj.RawGet("HideChat") as LuaFunction);
					this.m_HideBigExpression_hotfix = (luaObj.RawGet("HideBigExpression") as LuaFunction);
					this.m_GetHeroPointBGGameObjectInt32_hotfix = (luaObj.RawGet("GetHeroPointBGGameObject") as LuaFunction);
					this.m_GetHeroPointGameObjectInt32_hotfix = (luaObj.RawGet("GetHeroPointGameObject") as LuaFunction);
					this.m_GetHeroRedPointGameObjectInt32_hotfix = (luaObj.RawGet("GetHeroRedPointGameObject") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x00317098 File Offset: 0x00315298
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTeamPlayerUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040073ED RID: 29677
		[AutoBind("./PlayerIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconImage;

		// Token: 0x040073EE RID: 29678
		[AutoBind("./PlayerIcon/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameTransform;

		// Token: 0x040073EF RID: 29679
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x040073F0 RID: 29680
		[AutoBind("./LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x040073F1 RID: 29681
		[AutoBind("./PlayerTag", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerTagImage;

		// Token: 0x040073F2 RID: 29682
		[AutoBind("./Chat", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_chatUIStateController;

		// Token: 0x040073F3 RID: 29683
		[AutoBind("./Chat/BGImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private EmojiText m_dialogText;

		// Token: 0x040073F4 RID: 29684
		[AutoBind("./Chat/BGImage/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_expressionImage;

		// Token: 0x040073F5 RID: 29685
		[AutoBind("./Chat/BGImage/Voice", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_voiceButton;

		// Token: 0x040073F6 RID: 29686
		[AutoBind("./Chat/BGImage/Voice/Voice/SpeakImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_voiceSpeakImageStateCtrl;

		// Token: 0x040073F7 RID: 29687
		[AutoBind("./Chat/BGImage/Voice/Voice/TimeButton/ContentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_voiceTimeButtonText;

		// Token: 0x040073F8 RID: 29688
		[AutoBind("./Chat/BGImage/Voice/ContentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_voiceContentText;

		// Token: 0x040073F9 RID: 29689
		[AutoBind("./StateGroup/ActionImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_statusActionGameObject;

		// Token: 0x040073FA RID: 29690
		[AutoBind("./StateGroup/ReadyImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_statusReadyGameObject;

		// Token: 0x040073FB RID: 29691
		[AutoBind("./StateGroup/AutoImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_statusAutoGameObject;

		// Token: 0x040073FC RID: 29692
		[AutoBind("./StateGroup/OfflineImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_statusOfflineGameObject;

		// Token: 0x040073FD RID: 29693
		private float m_hideChatTime;

		// Token: 0x040073FE RID: 29694
		private ChatVoiceMessage m_voiceMessage;

		// Token: 0x040073FF RID: 29695
		[DoNotToLua]
		private BattleTeamPlayerUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007400 RID: 29696
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007401 RID: 29697
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007402 RID: 29698
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007403 RID: 29699
		private LuaFunction m_InitEmojiTextInt32Image_hotfix;

		// Token: 0x04007404 RID: 29700
		private LuaFunction m_SetStatusPlayerBattleStatusBoolean_hotfix;

		// Token: 0x04007405 RID: 29701
		private LuaFunction m_SetActionBoolean_hotfix;

		// Token: 0x04007406 RID: 29702
		private LuaFunction m_SetHeadIconInt32_hotfix;

		// Token: 0x04007407 RID: 29703
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x04007408 RID: 29704
		private LuaFunction m_SetLevelInt32_hotfix;

		// Token: 0x04007409 RID: 29705
		private LuaFunction m_SetPlayerIndexInt32_hotfix;

		// Token: 0x0400740A RID: 29706
		private LuaFunction m_ShowPlayerIndexBoolean_hotfix;

		// Token: 0x0400740B RID: 29707
		private LuaFunction m_SetHeroCountInt32_hotfix;

		// Token: 0x0400740C RID: 29708
		private LuaFunction m_SetHeroAliveInt32Boolean_hotfix;

		// Token: 0x0400740D RID: 29709
		private LuaFunction m_ShowChatString_hotfix;

		// Token: 0x0400740E RID: 29710
		private LuaFunction m_ShowBigExpressionInt32_hotfix;

		// Token: 0x0400740F RID: 29711
		private LuaFunction m_ShowVoiceChatVoiceMessage_hotfix;

		// Token: 0x04007410 RID: 29712
		private LuaFunction m_OnVoiceTimeButtonClick_hotfix;

		// Token: 0x04007411 RID: 29713
		private LuaFunction m_HideChat_hotfix;

		// Token: 0x04007412 RID: 29714
		private LuaFunction m_HideBigExpression_hotfix;

		// Token: 0x04007413 RID: 29715
		private LuaFunction m_GetHeroPointBGGameObjectInt32_hotfix;

		// Token: 0x04007414 RID: 29716
		private LuaFunction m_GetHeroPointGameObjectInt32_hotfix;

		// Token: 0x04007415 RID: 29717
		private LuaFunction m_GetHeroRedPointGameObjectInt32_hotfix;

		// Token: 0x04007416 RID: 29718
		private LuaFunction m_Update_hotfix;

		// Token: 0x02000AC7 RID: 2759
		public new class LuaExportHelper
		{
			// Token: 0x0600B2C1 RID: 45761 RVA: 0x00317100 File Offset: 0x00315300
			public LuaExportHelper(BattleTeamPlayerUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B2C2 RID: 45762 RVA: 0x00317110 File Offset: 0x00315310
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B2C3 RID: 45763 RVA: 0x00317120 File Offset: 0x00315320
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B2C4 RID: 45764 RVA: 0x00317130 File Offset: 0x00315330
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B2C5 RID: 45765 RVA: 0x00317140 File Offset: 0x00315340
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B2C6 RID: 45766 RVA: 0x00317158 File Offset: 0x00315358
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B2C7 RID: 45767 RVA: 0x00317168 File Offset: 0x00315368
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B2C8 RID: 45768 RVA: 0x00317178 File Offset: 0x00315378
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B2C9 RID: 45769 RVA: 0x00317188 File Offset: 0x00315388
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B2CA RID: 45770 RVA: 0x00317198 File Offset: 0x00315398
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B2CB RID: 45771 RVA: 0x003171A8 File Offset: 0x003153A8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B2CC RID: 45772 RVA: 0x003171B8 File Offset: 0x003153B8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B2CD RID: 45773 RVA: 0x003171C8 File Offset: 0x003153C8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B2CE RID: 45774 RVA: 0x003171D8 File Offset: 0x003153D8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B2CF RID: 45775 RVA: 0x003171E8 File Offset: 0x003153E8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B2D0 RID: 45776 RVA: 0x003171F8 File Offset: 0x003153F8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700242B RID: 9259
			// (get) Token: 0x0600B2D1 RID: 45777 RVA: 0x00317208 File Offset: 0x00315408
			// (set) Token: 0x0600B2D2 RID: 45778 RVA: 0x00317218 File Offset: 0x00315418
			public Image m_headIconImage
			{
				get
				{
					return this.m_owner.m_headIconImage;
				}
				set
				{
					this.m_owner.m_headIconImage = value;
				}
			}

			// Token: 0x1700242C RID: 9260
			// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x00317228 File Offset: 0x00315428
			// (set) Token: 0x0600B2D4 RID: 45780 RVA: 0x00317238 File Offset: 0x00315438
			public Transform m_headFrameTransform
			{
				get
				{
					return this.m_owner.m_headFrameTransform;
				}
				set
				{
					this.m_owner.m_headFrameTransform = value;
				}
			}

			// Token: 0x1700242D RID: 9261
			// (get) Token: 0x0600B2D5 RID: 45781 RVA: 0x00317248 File Offset: 0x00315448
			// (set) Token: 0x0600B2D6 RID: 45782 RVA: 0x00317258 File Offset: 0x00315458
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x1700242E RID: 9262
			// (get) Token: 0x0600B2D7 RID: 45783 RVA: 0x00317268 File Offset: 0x00315468
			// (set) Token: 0x0600B2D8 RID: 45784 RVA: 0x00317278 File Offset: 0x00315478
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x1700242F RID: 9263
			// (get) Token: 0x0600B2D9 RID: 45785 RVA: 0x00317288 File Offset: 0x00315488
			// (set) Token: 0x0600B2DA RID: 45786 RVA: 0x00317298 File Offset: 0x00315498
			public Image m_playerTagImage
			{
				get
				{
					return this.m_owner.m_playerTagImage;
				}
				set
				{
					this.m_owner.m_playerTagImage = value;
				}
			}

			// Token: 0x17002430 RID: 9264
			// (get) Token: 0x0600B2DB RID: 45787 RVA: 0x003172A8 File Offset: 0x003154A8
			// (set) Token: 0x0600B2DC RID: 45788 RVA: 0x003172B8 File Offset: 0x003154B8
			public CommonUIStateController m_chatUIStateController
			{
				get
				{
					return this.m_owner.m_chatUIStateController;
				}
				set
				{
					this.m_owner.m_chatUIStateController = value;
				}
			}

			// Token: 0x17002431 RID: 9265
			// (get) Token: 0x0600B2DD RID: 45789 RVA: 0x003172C8 File Offset: 0x003154C8
			// (set) Token: 0x0600B2DE RID: 45790 RVA: 0x003172D8 File Offset: 0x003154D8
			public EmojiText m_dialogText
			{
				get
				{
					return this.m_owner.m_dialogText;
				}
				set
				{
					this.m_owner.m_dialogText = value;
				}
			}

			// Token: 0x17002432 RID: 9266
			// (get) Token: 0x0600B2DF RID: 45791 RVA: 0x003172E8 File Offset: 0x003154E8
			// (set) Token: 0x0600B2E0 RID: 45792 RVA: 0x003172F8 File Offset: 0x003154F8
			public Image m_expressionImage
			{
				get
				{
					return this.m_owner.m_expressionImage;
				}
				set
				{
					this.m_owner.m_expressionImage = value;
				}
			}

			// Token: 0x17002433 RID: 9267
			// (get) Token: 0x0600B2E1 RID: 45793 RVA: 0x00317308 File Offset: 0x00315508
			// (set) Token: 0x0600B2E2 RID: 45794 RVA: 0x00317318 File Offset: 0x00315518
			public Button m_voiceButton
			{
				get
				{
					return this.m_owner.m_voiceButton;
				}
				set
				{
					this.m_owner.m_voiceButton = value;
				}
			}

			// Token: 0x17002434 RID: 9268
			// (get) Token: 0x0600B2E3 RID: 45795 RVA: 0x00317328 File Offset: 0x00315528
			// (set) Token: 0x0600B2E4 RID: 45796 RVA: 0x00317338 File Offset: 0x00315538
			public CommonUIStateController m_voiceSpeakImageStateCtrl
			{
				get
				{
					return this.m_owner.m_voiceSpeakImageStateCtrl;
				}
				set
				{
					this.m_owner.m_voiceSpeakImageStateCtrl = value;
				}
			}

			// Token: 0x17002435 RID: 9269
			// (get) Token: 0x0600B2E5 RID: 45797 RVA: 0x00317348 File Offset: 0x00315548
			// (set) Token: 0x0600B2E6 RID: 45798 RVA: 0x00317358 File Offset: 0x00315558
			public Text m_voiceTimeButtonText
			{
				get
				{
					return this.m_owner.m_voiceTimeButtonText;
				}
				set
				{
					this.m_owner.m_voiceTimeButtonText = value;
				}
			}

			// Token: 0x17002436 RID: 9270
			// (get) Token: 0x0600B2E7 RID: 45799 RVA: 0x00317368 File Offset: 0x00315568
			// (set) Token: 0x0600B2E8 RID: 45800 RVA: 0x00317378 File Offset: 0x00315578
			public Text m_voiceContentText
			{
				get
				{
					return this.m_owner.m_voiceContentText;
				}
				set
				{
					this.m_owner.m_voiceContentText = value;
				}
			}

			// Token: 0x17002437 RID: 9271
			// (get) Token: 0x0600B2E9 RID: 45801 RVA: 0x00317388 File Offset: 0x00315588
			// (set) Token: 0x0600B2EA RID: 45802 RVA: 0x00317398 File Offset: 0x00315598
			public GameObject m_statusActionGameObject
			{
				get
				{
					return this.m_owner.m_statusActionGameObject;
				}
				set
				{
					this.m_owner.m_statusActionGameObject = value;
				}
			}

			// Token: 0x17002438 RID: 9272
			// (get) Token: 0x0600B2EB RID: 45803 RVA: 0x003173A8 File Offset: 0x003155A8
			// (set) Token: 0x0600B2EC RID: 45804 RVA: 0x003173B8 File Offset: 0x003155B8
			public GameObject m_statusReadyGameObject
			{
				get
				{
					return this.m_owner.m_statusReadyGameObject;
				}
				set
				{
					this.m_owner.m_statusReadyGameObject = value;
				}
			}

			// Token: 0x17002439 RID: 9273
			// (get) Token: 0x0600B2ED RID: 45805 RVA: 0x003173C8 File Offset: 0x003155C8
			// (set) Token: 0x0600B2EE RID: 45806 RVA: 0x003173D8 File Offset: 0x003155D8
			public GameObject m_statusAutoGameObject
			{
				get
				{
					return this.m_owner.m_statusAutoGameObject;
				}
				set
				{
					this.m_owner.m_statusAutoGameObject = value;
				}
			}

			// Token: 0x1700243A RID: 9274
			// (get) Token: 0x0600B2EF RID: 45807 RVA: 0x003173E8 File Offset: 0x003155E8
			// (set) Token: 0x0600B2F0 RID: 45808 RVA: 0x003173F8 File Offset: 0x003155F8
			public GameObject m_statusOfflineGameObject
			{
				get
				{
					return this.m_owner.m_statusOfflineGameObject;
				}
				set
				{
					this.m_owner.m_statusOfflineGameObject = value;
				}
			}

			// Token: 0x1700243B RID: 9275
			// (get) Token: 0x0600B2F1 RID: 45809 RVA: 0x00317408 File Offset: 0x00315608
			// (set) Token: 0x0600B2F2 RID: 45810 RVA: 0x00317418 File Offset: 0x00315618
			public float m_hideChatTime
			{
				get
				{
					return this.m_owner.m_hideChatTime;
				}
				set
				{
					this.m_owner.m_hideChatTime = value;
				}
			}

			// Token: 0x1700243C RID: 9276
			// (get) Token: 0x0600B2F3 RID: 45811 RVA: 0x00317428 File Offset: 0x00315628
			// (set) Token: 0x0600B2F4 RID: 45812 RVA: 0x00317438 File Offset: 0x00315638
			public ChatVoiceMessage m_voiceMessage
			{
				get
				{
					return this.m_owner.m_voiceMessage;
				}
				set
				{
					this.m_owner.m_voiceMessage = value;
				}
			}

			// Token: 0x0600B2F5 RID: 45813 RVA: 0x00317448 File Offset: 0x00315648
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B2F6 RID: 45814 RVA: 0x00317458 File Offset: 0x00315658
			public void OnVoiceTimeButtonClick()
			{
				this.m_owner.OnVoiceTimeButtonClick();
			}

			// Token: 0x0600B2F7 RID: 45815 RVA: 0x00317468 File Offset: 0x00315668
			public void HideChat()
			{
				this.m_owner.HideChat();
			}

			// Token: 0x0600B2F8 RID: 45816 RVA: 0x00317478 File Offset: 0x00315678
			public void HideBigExpression()
			{
				this.m_owner.HideBigExpression();
			}

			// Token: 0x0600B2F9 RID: 45817 RVA: 0x00317488 File Offset: 0x00315688
			public GameObject GetHeroPointBGGameObject(int idx)
			{
				return this.m_owner.GetHeroPointBGGameObject(idx);
			}

			// Token: 0x0600B2FA RID: 45818 RVA: 0x00317498 File Offset: 0x00315698
			public GameObject GetHeroPointGameObject(int idx)
			{
				return this.m_owner.GetHeroPointGameObject(idx);
			}

			// Token: 0x0600B2FB RID: 45819 RVA: 0x003174A8 File Offset: 0x003156A8
			public GameObject GetHeroRedPointGameObject(int idx)
			{
				return this.m_owner.GetHeroRedPointGameObject(idx);
			}

			// Token: 0x0600B2FC RID: 45820 RVA: 0x003174B8 File Offset: 0x003156B8
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04007417 RID: 29719
			private BattleTeamPlayerUIController m_owner;
		}
	}
}
