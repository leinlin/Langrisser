using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E81 RID: 3713
	[HotFix]
	public class NoticeUIController : UIControllerBase
	{
		// Token: 0x0601211C RID: 74012 RVA: 0x004A8750 File Offset: 0x004A6950
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
			NoticeUIController.s_instance = this;
			base.gameObject.SetActive(false);
			base.OnBindFiledsCompleted();
			TweenPos[] components = this.m_noticeDetailGo.GetComponents<TweenPos>();
			if (components.Length != 2)
			{
				global::Debug.LogError("NoticeUIController::OnBindFiledsCompleted  Find MoveTween Fail");
				return;
			}
			this.m_noticeShowTween = components[0];
			this.m_noticeShowTween.OnFinished.AddListener(new UnityAction(this.OnNoticeShowTweenFinished));
			this.m_noticeButton.onClick.AddListener(new UnityAction(this.OnNoticeButtonClick));
			this.m_noticeMoveTween = components[1];
			this.m_noticeMoveTween.OnFinished.AddListener(new UnityAction(this.OnNoticeMoveTweenFinished));
			this.m_noticeTextInitPos = this.m_noticeDetailGo.transform.localPosition;
			this.m_noticeTextInitWidth = (this.m_noticeDetailGo.transform.parent as RectTransform).rect.width;
			GameObject gameObject = this.m_expressionResContainer.GetAsset("EmojiShowImage") as GameObject;
			this.m_noticeText.Init(this.m_expressionParseDesc.m_emSpace, gameObject.GetComponent<Image>());
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0601211D RID: 74013 RVA: 0x004A88D4 File Offset: 0x004A6AD4
		public override void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Clear();
			base.gameObject.SetActive(false);
			if (this.m_delayHideNoticeCoroutine != null)
			{
				base.StopCoroutine(this.m_delayHideNoticeCoroutine);
				this.m_delayHideNoticeCoroutine = null;
			}
		}

		// Token: 0x0601211E RID: 74014 RVA: 0x004A8964 File Offset: 0x004A6B64
		public void ShowNotice(string txt, string stateName, ChatChannel chatChannel, bool isVoiceMsg = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNoticeStringStringChatChannelBoolean_hotfix != null)
			{
				this.m_ShowNoticeStringStringChatChannelBoolean_hotfix.call(new object[]
				{
					this,
					txt,
					stateName,
					chatChannel,
					isVoiceMsg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(txt))
			{
				return;
			}
			NoticeText noticeText = new NoticeText();
			noticeText.text = txt;
			noticeText.channel = chatChannel;
			this.m_playerContext.AddNoticeToWaitingNoticeStringList(noticeText);
			if (this.m_playerContext.GetIsShowingNoticeFlag())
			{
				return;
			}
			if (NoticeUIController.IsForceHide)
			{
				return;
			}
			this.m_noticeVoiceImage.SetActive(isVoiceMsg);
			if (!string.IsNullOrEmpty(stateName))
			{
				this.m_stateCtrl.SetToUIState(stateName, false, true);
			}
			this.ShowNextNotice();
		}

		// Token: 0x0601211F RID: 74015 RVA: 0x004A8A78 File Offset: 0x004A6C78
		public void SetPositionState(string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionStateString_hotfix != null)
			{
				this.m_SetPositionStateString_hotfix.call(new object[]
				{
					this,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_stateCtrl) != stateName)
			{
				this.m_stateCtrl.SetToUIState(stateName, false, true);
			}
		}

		// Token: 0x06012120 RID: 74016 RVA: 0x004A8B0C File Offset: 0x004A6D0C
		private void ShowNextNotice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNextNotice_hotfix != null)
			{
				this.m_ShowNextNotice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerContext.GetGetWaitingNoticeStringListCount() == 0)
			{
				return;
			}
			this.m_currentNoticeText = this.m_playerContext.GetWaitingNoticeStringListFirstNotice();
			base.gameObject.SetActive(true);
			if (this.m_delayHideNoticeCoroutine != null)
			{
				base.StopCoroutine(this.m_delayHideNoticeCoroutine);
				this.m_delayHideNoticeCoroutine = null;
			}
			if (this.m_noticeText.gameObject.activeInHierarchy)
			{
				this.m_noticeText.SetContent(this.m_currentNoticeText.text);
			}
			this.m_noticeShowTween.from = (this.m_noticeShowTween.to = this.m_noticeTextInitPos);
			float height = this.m_noticeText.rectTransform.rect.height;
			TweenPos noticeShowTween = this.m_noticeShowTween;
			noticeShowTween.from.y = noticeShowTween.from.y - height;
			this.m_noticeShowTween.duration = height / 100f;
			this.m_noticeShowTween.ResetToBeginning();
			this.m_noticeMoveTween.ResetToBeginning();
			this.m_noticeMoveTween.enabled = false;
			this.m_noticeShowTween.PlayForward();
			this.m_playerContext.SetIsShowingNoticeFlag(true);
		}

		// Token: 0x06012121 RID: 74017 RVA: 0x004A8C80 File Offset: 0x004A6E80
		private void OnNoticeShowTweenFinished()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNoticeShowTweenFinished_hotfix != null)
			{
				this.m_OnNoticeShowTweenFinished_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = this.m_noticeText.preferredWidth - this.m_noticeTextInitWidth;
			if (num <= 0f)
			{
				this.m_delayHideNoticeCoroutine = base.StartCoroutine(this.DelayHideNotice(1f, 0f));
				return;
			}
			float num2 = num / 100f;
			this.m_delayHideNoticeCoroutine = base.StartCoroutine(this.DelayHideNotice(1f, num2));
			this.m_noticeMoveTween.delay = 0f;
			this.m_noticeMoveTween.duration = num2;
			this.m_noticeMoveTween.from = (this.m_noticeMoveTween.to = this.m_noticeTextInitPos);
			TweenPos noticeMoveTween = this.m_noticeMoveTween;
			noticeMoveTween.to.x = noticeMoveTween.to.x - num;
			this.m_noticeMoveTween.ResetToBeginning();
			this.m_noticeMoveTween.PlayForward();
		}

		// Token: 0x06012122 RID: 74018 RVA: 0x004A8DA4 File Offset: 0x004A6FA4
		private void OnNoticeMoveTweenFinished()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNoticeMoveTweenFinished_hotfix != null)
			{
				this.m_OnNoticeMoveTweenFinished_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06012123 RID: 74019 RVA: 0x004A8E04 File Offset: 0x004A7004
		[DebuggerHidden]
		private IEnumerator DelayHideNotice(float time, float additiveTime = 0f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayHideNoticeSingleSingle_hotfix != null)
			{
				return (IEnumerator)this.m_DelayHideNoticeSingleSingle_hotfix.call(new object[]
				{
					this,
					time,
					additiveTime
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			NoticeUIController.<DelayHideNotice>c__Iterator0 <DelayHideNotice>c__Iterator = new NoticeUIController.<DelayHideNotice>c__Iterator0();
			<DelayHideNotice>c__Iterator.time = time;
			<DelayHideNotice>c__Iterator.additiveTime = additiveTime;
			<DelayHideNotice>c__Iterator.$this = this;
			return <DelayHideNotice>c__Iterator;
		}

		// Token: 0x06012124 RID: 74020 RVA: 0x004A8EAC File Offset: 0x004A70AC
		private void OnNoticeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNoticeButtonClick_hotfix != null)
			{
				this.m_OnNoticeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnNoticeClick != null)
			{
				this.EventOnNoticeClick(this.m_currentNoticeText);
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x06012125 RID: 74021 RVA: 0x004A8F28 File Offset: 0x004A7128
		// (set) Token: 0x06012126 RID: 74022 RVA: 0x004A8F30 File Offset: 0x004A7130
		public static bool IsForceHide
		{
			get
			{
				return NoticeUIController.s_isForceHide;
			}
			set
			{
				if (NoticeUIController.s_isForceHide == value)
				{
					return;
				}
				NoticeUIController.s_isForceHide = value;
				if (NoticeUIController.s_instance != null)
				{
					if (NoticeUIController.s_isForceHide)
					{
						NoticeUIController.s_instance.gameObject.SetActive(false);
					}
					else
					{
						NoticeUIController.s_instance.ShowNextNotice();
					}
				}
			}
		}

		// Token: 0x140003E3 RID: 995
		// (add) Token: 0x06012127 RID: 74023 RVA: 0x004A8F88 File Offset: 0x004A7188
		// (remove) Token: 0x06012128 RID: 74024 RVA: 0x004A9024 File Offset: 0x004A7224
		public event Action<NoticeText> EventOnNoticeClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNoticeClickAction`1_hotfix != null)
				{
					this.m_add_EventOnNoticeClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<NoticeText> action = this.EventOnNoticeClick;
				Action<NoticeText> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<NoticeText>>(ref this.EventOnNoticeClick, (Action<NoticeText>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNoticeClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnNoticeClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<NoticeText> action = this.EventOnNoticeClick;
				Action<NoticeText> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<NoticeText>>(ref this.EventOnNoticeClick, (Action<NoticeText>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x06012129 RID: 74025 RVA: 0x004A90C0 File Offset: 0x004A72C0
		// (set) Token: 0x0601212A RID: 74026 RVA: 0x004A90E0 File Offset: 0x004A72E0
		[DoNotToLua]
		public new NoticeUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NoticeUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601212B RID: 74027 RVA: 0x004A90EC File Offset: 0x004A72EC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601212C RID: 74028 RVA: 0x004A90F8 File Offset: 0x004A72F8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601212D RID: 74029 RVA: 0x004A9100 File Offset: 0x004A7300
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601212E RID: 74030 RVA: 0x004A9108 File Offset: 0x004A7308
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601212F RID: 74031 RVA: 0x004A911C File Offset: 0x004A731C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012130 RID: 74032 RVA: 0x004A9124 File Offset: 0x004A7324
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012131 RID: 74033 RVA: 0x004A9130 File Offset: 0x004A7330
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012132 RID: 74034 RVA: 0x004A913C File Offset: 0x004A733C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012133 RID: 74035 RVA: 0x004A9148 File Offset: 0x004A7348
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012134 RID: 74036 RVA: 0x004A9154 File Offset: 0x004A7354
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012135 RID: 74037 RVA: 0x004A9160 File Offset: 0x004A7360
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012136 RID: 74038 RVA: 0x004A916C File Offset: 0x004A736C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012137 RID: 74039 RVA: 0x004A9178 File Offset: 0x004A7378
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012138 RID: 74040 RVA: 0x004A9184 File Offset: 0x004A7384
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012139 RID: 74041 RVA: 0x004A9190 File Offset: 0x004A7390
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601213A RID: 74042 RVA: 0x004A9198 File Offset: 0x004A7398
		private void __callDele_EventOnNoticeClick(NoticeText obj)
		{
			Action<NoticeText> eventOnNoticeClick = this.EventOnNoticeClick;
			if (eventOnNoticeClick != null)
			{
				eventOnNoticeClick(obj);
			}
		}

		// Token: 0x0601213B RID: 74043 RVA: 0x004A91BC File Offset: 0x004A73BC
		private void __clearDele_EventOnNoticeClick(NoticeText obj)
		{
			this.EventOnNoticeClick = null;
		}

		// Token: 0x0601213D RID: 74045 RVA: 0x004A91CC File Offset: 0x004A73CC
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_ShowNoticeStringStringChatChannelBoolean_hotfix = (luaObj.RawGet("ShowNotice") as LuaFunction);
					this.m_SetPositionStateString_hotfix = (luaObj.RawGet("SetPositionState") as LuaFunction);
					this.m_ShowNextNotice_hotfix = (luaObj.RawGet("ShowNextNotice") as LuaFunction);
					this.m_OnNoticeShowTweenFinished_hotfix = (luaObj.RawGet("OnNoticeShowTweenFinished") as LuaFunction);
					this.m_OnNoticeMoveTweenFinished_hotfix = (luaObj.RawGet("OnNoticeMoveTweenFinished") as LuaFunction);
					this.m_DelayHideNoticeSingleSingle_hotfix = (luaObj.RawGet("DelayHideNotice") as LuaFunction);
					this.m_OnNoticeButtonClick_hotfix = (luaObj.RawGet("OnNoticeButtonClick") as LuaFunction);
					this.m_add_EventOnNoticeClickAction`1_hotfix = (luaObj.RawGet("add_EventOnNoticeClick") as LuaFunction);
					this.m_remove_EventOnNoticeClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnNoticeClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601213E RID: 74046 RVA: 0x004A9394 File Offset: 0x004A7594
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NoticeUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A37A RID: 41850
		[AutoBind("./Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_noticeButton;

		// Token: 0x0400A37B RID: 41851
		[AutoBind("./Button/Detail", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noticeDetailGo;

		// Token: 0x0400A37C RID: 41852
		[AutoBind("./Button/Detail/Text", AutoBindAttribute.InitState.NotInit, false)]
		private EmojiText m_noticeText;

		// Token: 0x0400A37D RID: 41853
		[AutoBind("./Button/Detail/VoiceImage", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_noticeVoiceImage;

		// Token: 0x0400A37E RID: 41854
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x0400A37F RID: 41855
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private SmallExpressionParseDesc m_expressionParseDesc;

		// Token: 0x0400A380 RID: 41856
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_expressionResContainer;

		// Token: 0x0400A381 RID: 41857
		private static bool s_isForceHide;

		// Token: 0x0400A382 RID: 41858
		private static NoticeUIController s_instance;

		// Token: 0x0400A383 RID: 41859
		private const float NoticeTweenSpeed = 100f;

		// Token: 0x0400A384 RID: 41860
		private const float ShowNoticeInterval = 1f;

		// Token: 0x0400A385 RID: 41861
		private const float ShowNoticeTime = 5f;

		// Token: 0x0400A386 RID: 41862
		private Vector3 m_noticeTextInitPos;

		// Token: 0x0400A387 RID: 41863
		private float m_noticeTextInitWidth;

		// Token: 0x0400A388 RID: 41864
		private Coroutine m_delayHideNoticeCoroutine;

		// Token: 0x0400A389 RID: 41865
		private TweenPos m_noticeShowTween;

		// Token: 0x0400A38A RID: 41866
		private TweenPos m_noticeMoveTween;

		// Token: 0x0400A38B RID: 41867
		private NoticeText m_currentNoticeText;

		// Token: 0x0400A38C RID: 41868
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400A38D RID: 41869
		[DoNotToLua]
		private NoticeUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A38E RID: 41870
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A38F RID: 41871
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A390 RID: 41872
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A391 RID: 41873
		private LuaFunction m_Clear_hotfix;

		// Token: 0x0400A392 RID: 41874
		private LuaFunction m_ShowNoticeStringStringChatChannelBoolean_hotfix;

		// Token: 0x0400A393 RID: 41875
		private LuaFunction m_SetPositionStateString_hotfix;

		// Token: 0x0400A394 RID: 41876
		private LuaFunction m_ShowNextNotice_hotfix;

		// Token: 0x0400A395 RID: 41877
		private LuaFunction m_OnNoticeShowTweenFinished_hotfix;

		// Token: 0x0400A396 RID: 41878
		private LuaFunction m_OnNoticeMoveTweenFinished_hotfix;

		// Token: 0x0400A397 RID: 41879
		private LuaFunction m_DelayHideNoticeSingleSingle_hotfix;

		// Token: 0x0400A398 RID: 41880
		private LuaFunction m_OnNoticeButtonClick_hotfix;

		// Token: 0x0400A399 RID: 41881
		private LuaFunction m_add_EventOnNoticeClickAction;

		// Token: 0x0400A39A RID: 41882
		private LuaFunction m_remove_EventOnNoticeClickAction;

		// Token: 0x02000E82 RID: 3714
		public new class LuaExportHelper
		{
			// Token: 0x0601213F RID: 74047 RVA: 0x004A93FC File Offset: 0x004A75FC
			public LuaExportHelper(NoticeUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012140 RID: 74048 RVA: 0x004A940C File Offset: 0x004A760C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012141 RID: 74049 RVA: 0x004A941C File Offset: 0x004A761C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012142 RID: 74050 RVA: 0x004A942C File Offset: 0x004A762C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012143 RID: 74051 RVA: 0x004A943C File Offset: 0x004A763C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012144 RID: 74052 RVA: 0x004A9454 File Offset: 0x004A7654
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012145 RID: 74053 RVA: 0x004A9464 File Offset: 0x004A7664
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012146 RID: 74054 RVA: 0x004A9474 File Offset: 0x004A7674
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012147 RID: 74055 RVA: 0x004A9484 File Offset: 0x004A7684
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012148 RID: 74056 RVA: 0x004A9494 File Offset: 0x004A7694
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012149 RID: 74057 RVA: 0x004A94A4 File Offset: 0x004A76A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601214A RID: 74058 RVA: 0x004A94B4 File Offset: 0x004A76B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601214B RID: 74059 RVA: 0x004A94C4 File Offset: 0x004A76C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601214C RID: 74060 RVA: 0x004A94D4 File Offset: 0x004A76D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601214D RID: 74061 RVA: 0x004A94E4 File Offset: 0x004A76E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601214E RID: 74062 RVA: 0x004A94F4 File Offset: 0x004A76F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601214F RID: 74063 RVA: 0x004A9504 File Offset: 0x004A7704
			public void __callDele_EventOnNoticeClick(NoticeText obj)
			{
				this.m_owner.__callDele_EventOnNoticeClick(obj);
			}

			// Token: 0x06012150 RID: 74064 RVA: 0x004A9514 File Offset: 0x004A7714
			public void __clearDele_EventOnNoticeClick(NoticeText obj)
			{
				this.m_owner.__clearDele_EventOnNoticeClick(obj);
			}

			// Token: 0x17003726 RID: 14118
			// (get) Token: 0x06012151 RID: 74065 RVA: 0x004A9524 File Offset: 0x004A7724
			// (set) Token: 0x06012152 RID: 74066 RVA: 0x004A9534 File Offset: 0x004A7734
			public Button m_noticeButton
			{
				get
				{
					return this.m_owner.m_noticeButton;
				}
				set
				{
					this.m_owner.m_noticeButton = value;
				}
			}

			// Token: 0x17003727 RID: 14119
			// (get) Token: 0x06012153 RID: 74067 RVA: 0x004A9544 File Offset: 0x004A7744
			// (set) Token: 0x06012154 RID: 74068 RVA: 0x004A9554 File Offset: 0x004A7754
			public GameObject m_noticeDetailGo
			{
				get
				{
					return this.m_owner.m_noticeDetailGo;
				}
				set
				{
					this.m_owner.m_noticeDetailGo = value;
				}
			}

			// Token: 0x17003728 RID: 14120
			// (get) Token: 0x06012155 RID: 74069 RVA: 0x004A9564 File Offset: 0x004A7764
			// (set) Token: 0x06012156 RID: 74070 RVA: 0x004A9574 File Offset: 0x004A7774
			public EmojiText m_noticeText
			{
				get
				{
					return this.m_owner.m_noticeText;
				}
				set
				{
					this.m_owner.m_noticeText = value;
				}
			}

			// Token: 0x17003729 RID: 14121
			// (get) Token: 0x06012157 RID: 74071 RVA: 0x004A9584 File Offset: 0x004A7784
			// (set) Token: 0x06012158 RID: 74072 RVA: 0x004A9594 File Offset: 0x004A7794
			public GameObject m_noticeVoiceImage
			{
				get
				{
					return this.m_owner.m_noticeVoiceImage;
				}
				set
				{
					this.m_owner.m_noticeVoiceImage = value;
				}
			}

			// Token: 0x1700372A RID: 14122
			// (get) Token: 0x06012159 RID: 74073 RVA: 0x004A95A4 File Offset: 0x004A77A4
			// (set) Token: 0x0601215A RID: 74074 RVA: 0x004A95B4 File Offset: 0x004A77B4
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x1700372B RID: 14123
			// (get) Token: 0x0601215B RID: 74075 RVA: 0x004A95C4 File Offset: 0x004A77C4
			// (set) Token: 0x0601215C RID: 74076 RVA: 0x004A95D4 File Offset: 0x004A77D4
			public SmallExpressionParseDesc m_expressionParseDesc
			{
				get
				{
					return this.m_owner.m_expressionParseDesc;
				}
				set
				{
					this.m_owner.m_expressionParseDesc = value;
				}
			}

			// Token: 0x1700372C RID: 14124
			// (get) Token: 0x0601215D RID: 74077 RVA: 0x004A95E4 File Offset: 0x004A77E4
			// (set) Token: 0x0601215E RID: 74078 RVA: 0x004A95F4 File Offset: 0x004A77F4
			public PrefabResourceContainer m_expressionResContainer
			{
				get
				{
					return this.m_owner.m_expressionResContainer;
				}
				set
				{
					this.m_owner.m_expressionResContainer = value;
				}
			}

			// Token: 0x1700372D RID: 14125
			// (get) Token: 0x0601215F RID: 74079 RVA: 0x004A9604 File Offset: 0x004A7804
			// (set) Token: 0x06012160 RID: 74080 RVA: 0x004A960C File Offset: 0x004A780C
			public static bool s_isForceHide
			{
				get
				{
					return NoticeUIController.s_isForceHide;
				}
				set
				{
					NoticeUIController.s_isForceHide = value;
				}
			}

			// Token: 0x1700372E RID: 14126
			// (get) Token: 0x06012161 RID: 74081 RVA: 0x004A9614 File Offset: 0x004A7814
			// (set) Token: 0x06012162 RID: 74082 RVA: 0x004A961C File Offset: 0x004A781C
			public static NoticeUIController s_instance
			{
				get
				{
					return NoticeUIController.s_instance;
				}
				set
				{
					NoticeUIController.s_instance = value;
				}
			}

			// Token: 0x1700372F RID: 14127
			// (get) Token: 0x06012163 RID: 74083 RVA: 0x004A9624 File Offset: 0x004A7824
			public static float NoticeTweenSpeed
			{
				get
				{
					return 100f;
				}
			}

			// Token: 0x17003730 RID: 14128
			// (get) Token: 0x06012164 RID: 74084 RVA: 0x004A962C File Offset: 0x004A782C
			public static float ShowNoticeInterval
			{
				get
				{
					return 1f;
				}
			}

			// Token: 0x17003731 RID: 14129
			// (get) Token: 0x06012165 RID: 74085 RVA: 0x004A9634 File Offset: 0x004A7834
			public static float ShowNoticeTime
			{
				get
				{
					return 5f;
				}
			}

			// Token: 0x17003732 RID: 14130
			// (get) Token: 0x06012166 RID: 74086 RVA: 0x004A963C File Offset: 0x004A783C
			// (set) Token: 0x06012167 RID: 74087 RVA: 0x004A964C File Offset: 0x004A784C
			public Vector3 m_noticeTextInitPos
			{
				get
				{
					return this.m_owner.m_noticeTextInitPos;
				}
				set
				{
					this.m_owner.m_noticeTextInitPos = value;
				}
			}

			// Token: 0x17003733 RID: 14131
			// (get) Token: 0x06012168 RID: 74088 RVA: 0x004A965C File Offset: 0x004A785C
			// (set) Token: 0x06012169 RID: 74089 RVA: 0x004A966C File Offset: 0x004A786C
			public float m_noticeTextInitWidth
			{
				get
				{
					return this.m_owner.m_noticeTextInitWidth;
				}
				set
				{
					this.m_owner.m_noticeTextInitWidth = value;
				}
			}

			// Token: 0x17003734 RID: 14132
			// (get) Token: 0x0601216A RID: 74090 RVA: 0x004A967C File Offset: 0x004A787C
			// (set) Token: 0x0601216B RID: 74091 RVA: 0x004A968C File Offset: 0x004A788C
			public Coroutine m_delayHideNoticeCoroutine
			{
				get
				{
					return this.m_owner.m_delayHideNoticeCoroutine;
				}
				set
				{
					this.m_owner.m_delayHideNoticeCoroutine = value;
				}
			}

			// Token: 0x17003735 RID: 14133
			// (get) Token: 0x0601216C RID: 74092 RVA: 0x004A969C File Offset: 0x004A789C
			// (set) Token: 0x0601216D RID: 74093 RVA: 0x004A96AC File Offset: 0x004A78AC
			public TweenPos m_noticeShowTween
			{
				get
				{
					return this.m_owner.m_noticeShowTween;
				}
				set
				{
					this.m_owner.m_noticeShowTween = value;
				}
			}

			// Token: 0x17003736 RID: 14134
			// (get) Token: 0x0601216E RID: 74094 RVA: 0x004A96BC File Offset: 0x004A78BC
			// (set) Token: 0x0601216F RID: 74095 RVA: 0x004A96CC File Offset: 0x004A78CC
			public TweenPos m_noticeMoveTween
			{
				get
				{
					return this.m_owner.m_noticeMoveTween;
				}
				set
				{
					this.m_owner.m_noticeMoveTween = value;
				}
			}

			// Token: 0x17003737 RID: 14135
			// (get) Token: 0x06012170 RID: 74096 RVA: 0x004A96DC File Offset: 0x004A78DC
			// (set) Token: 0x06012171 RID: 74097 RVA: 0x004A96EC File Offset: 0x004A78EC
			public NoticeText m_currentNoticeText
			{
				get
				{
					return this.m_owner.m_currentNoticeText;
				}
				set
				{
					this.m_owner.m_currentNoticeText = value;
				}
			}

			// Token: 0x17003738 RID: 14136
			// (get) Token: 0x06012172 RID: 74098 RVA: 0x004A96FC File Offset: 0x004A78FC
			// (set) Token: 0x06012173 RID: 74099 RVA: 0x004A970C File Offset: 0x004A790C
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

			// Token: 0x06012174 RID: 74100 RVA: 0x004A971C File Offset: 0x004A791C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012175 RID: 74101 RVA: 0x004A972C File Offset: 0x004A792C
			public void ShowNextNotice()
			{
				this.m_owner.ShowNextNotice();
			}

			// Token: 0x06012176 RID: 74102 RVA: 0x004A973C File Offset: 0x004A793C
			public void OnNoticeShowTweenFinished()
			{
				this.m_owner.OnNoticeShowTweenFinished();
			}

			// Token: 0x06012177 RID: 74103 RVA: 0x004A974C File Offset: 0x004A794C
			public void OnNoticeMoveTweenFinished()
			{
				this.m_owner.OnNoticeMoveTweenFinished();
			}

			// Token: 0x06012178 RID: 74104 RVA: 0x004A975C File Offset: 0x004A795C
			public IEnumerator DelayHideNotice(float time, float additiveTime)
			{
				return this.m_owner.DelayHideNotice(time, additiveTime);
			}

			// Token: 0x06012179 RID: 74105 RVA: 0x004A976C File Offset: 0x004A796C
			public void OnNoticeButtonClick()
			{
				this.m_owner.OnNoticeButtonClick();
			}

			// Token: 0x0400A39B RID: 41883
			private NoticeUIController m_owner;
		}
	}
}
