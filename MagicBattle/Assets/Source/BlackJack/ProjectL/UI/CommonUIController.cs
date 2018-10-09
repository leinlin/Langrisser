using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BA6 RID: 2982
	[HotFix]
	public class CommonUIController : UIControllerBase
	{
		// Token: 0x0600CC70 RID: 52336 RVA: 0x00383FDC File Offset: 0x003821DC
		public static void StaticLateUpdate()
		{
			if (CommonUIController.m_hasFinishAndroidBackEvent)
			{
				CommonUIController.m_hasFinishAndroidBackEvent = false;
				return;
			}
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				CommonUIController.OnAndroidBackKeyUp();
			}
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x00384000 File Offset: 0x00382200
		public static void OnAndroidBackKeyUp()
		{
			global::Debug.Log("[OnAndroidBackKeyUp]");
			PDSDK.Instance.StartCoroutine(CommonUIController.MessageBoxAndQuitApp());
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x0038401C File Offset: 0x0038221C
		private static IEnumerator MessageBoxAndQuitApp()
		{
			global::Debug.Log("[MessageBoxAndQuitApp] QuitAppFunction Start");
			if (CommonUIController.m_isRunningMessageBoxAndQuitApp)
			{
				yield break;
			}
			CommonUIController.m_isRunningMessageBoxAndQuitApp = true;
			PDSDK.Instance.exit();
			float timeoutTime = Time.unscaledTime + 1f;
			bool isTimeout = false;
			yield return new WaitUntil(delegate()
			{
				if (PDSDK.Instance.isExitSuccess)
				{
					return true;
				}
				if (timeoutTime < Time.unscaledTime)
				{
					isTimeout = true;
					return true;
				}
				return false;
			});
			if (isTimeout)
			{
				CommonUIController.m_isRunningMessageBoxAndQuitApp = false;
				yield break;
			}
			global::Debug.Log("[MessageBoxAndQuitApp] PDSDK quit finish");
			if (CommonUIController.Instance != null && CommonUIController.Instance.CancelDialogBox())
			{
				CommonUIController.m_isRunningMessageBoxAndQuitApp = false;
				yield break;
			}
			if (SceneManager.Instance == null || SceneManager.Instance.RootCanvasGo == null)
			{
				CommonUIController.m_isRunningMessageBoxAndQuitApp = false;
				yield break;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			yield return DialogBox.Show(SceneManager.Instance.RootCanvasGo, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab", configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_QuitApplicationOrNot), configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Cancel), delegate(DialogBoxResult ret)
			{
				if (ret == DialogBoxResult.Ok)
				{
					global::Debug.Log("[MessageBoxAndQuitApp] Application.Quit(),start");
					Application.Quit();
					global::Debug.Log("[MessageBoxAndQuitApp] Application.Quit(),end");
				}
			});
			CommonUIController.m_isRunningMessageBoxAndQuitApp = false;
			global::Debug.Log("[MessageBoxAndQuitApp] QuitAppFunction End");
			yield break;
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x00384030 File Offset: 0x00382230
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
			CommonUIController.s_instance = this;
			this.m_fadeImage.gameObject.SetActive(false);
			this.m_disableInputGameObject.SetActive(false);
			this.m_transparentMaskGameObject.SetActive(false);
			this.m_blackFrameGameObject.SetActive(false);
			this.m_messageUIStateController.gameObject.SetActive(false);
			this.m_noticeGameObject.SetActive(false);
			this.m_testUIBackgroundGameObject.gameObject.SetActive(false);
			this.m_explanationUIStateController.gameObject.SetActive(false);
			this.m_explanationBackgroundButton.onClick.AddListener(new UnityAction(this.OnExplanationBackgroundButtonClick));
			this.TestUI = base.gameObject.AddComponent<TestUI>();
			this.m_screenFade = new ScreenFade();
			this.m_screenFade.Setup(this.m_fadeImage);
			GameObjectUtility.AddControllerToGameObject<ScreenRecorderUI>(this.m_screenRecorderGameObject);
			GameObject gameObject = UnityEngine.Object.Instantiate(base.GetAssetInContainer("DialogBox")) as GameObject;
			gameObject.transform.SetParent(base.gameObject.transform, false);
			this.m_dialogBox = gameObject.AddComponent<DialogBox>();
			this.m_dialogBox.Initialize();
			TweenPos[] components = this.m_noticeText.GetComponents<TweenPos>();
			this.m_noticeShowTween = components[0];
			this.m_noticeShowTween.OnFinished.AddListener(new UnityAction(this.OnNoticeShowTweenFinished));
			this.m_noticeMoveTween = components[1];
			this.m_noticeMoveTween.OnFinished.AddListener(new UnityAction(this.OnNoticeMoveTweenFinished));
			PDSDK.m_eventOnWebViewOpen = new Action(this.OnPDSDKWebViewOpen);
			PDSDK.m_eventOnWebViewClose = new Action(this.OnPDSDKWebViewClose);
			this.m_noticeTextInitPos = this.m_noticeText.rectTransform.localPosition;
			this.m_noticeTextInitWidth = (this.m_noticeText.transform.parent as RectTransform).rect.width;
			GameObject gameObject2 = UnityEngine.Object.Instantiate(base.GetAssetInContainer("NetworkWaitingUI")) as GameObject;
			gameObject2.transform.SetParent(base.gameObject.transform, false);
			gameObject2.SetActive(false);
			this.m_networkWatingStateController = gameObject2.GetComponent<CommonUIStateController>();
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("Loading1");
			GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer, this.m_loadingGameObject.transform, false);
			gameObject3.SetActive(false);
			assetInContainer = base.GetAssetInContainer<GameObject>("Loading2");
			gameObject3 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer, this.m_loadingGameObject.transform, false);
			gameObject3.SetActive(false);
			this.m_loadingGameObject.SetActive(false);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_defaultFadeOutTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_OpenUILoadingFadeoutTime) * 0.001f;
			this.m_defaultFadeInTime = (float)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_OpenUILoadingFadeinTime) * 0.001f;
			this.ShowiPhoneXTest(LocalConfig.Instance.Data.TestMarginFix);
			if (this.AutoInitLocalizedString)
			{
				UIControllerBase.InitLocalizedString(base.gameObject);
			}
		}

		// Token: 0x0600CC74 RID: 52340 RVA: 0x00384368 File Offset: 0x00382568
		private void OnDestroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDestroy_hotfix != null)
			{
				this.m_OnDestroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.m_eventOnWebViewOpen = null;
			PDSDK.m_eventOnWebViewClose = null;
			CommonUIController.s_instance = null;
		}

		// Token: 0x0600CC75 RID: 52341 RVA: 0x003843DC File Offset: 0x003825DC
		public void InitTouchFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTouchFx_hotfix != null)
			{
				this.m_InitTouchFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_touchFx != null)
			{
				return;
			}
			this.m_touchFx = new TouchFx();
			Camera componentInParent = base.GetComponentInParent<Camera>();
			Transform transform = componentInParent.transform.Find("TouchFx");
			if (transform == null)
			{
				transform = new GameObject("TouchFx").transform;
				transform.transform.localPosition = new Vector3(0f, 0f, 10f);
				transform.transform.SetParent(componentInParent.transform, false);
			}
			this.m_touchFx.Init(transform.gameObject, componentInParent);
			this.m_touchFx.SetHitFxName("FX/UI_ABS/UI_Fx/U_click_down.prefab");
			this.m_touchFx.SetLoopFxName("FX/UI_ABS/UI_Fx/U_click.prefab");
			this.m_touchFx.SetDisableInputGameObject(this.m_disableInputGameObject);
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x003844FC File Offset: 0x003826FC
		public void DisposeTouchFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DisposeTouchFx_hotfix != null)
			{
				this.m_DisposeTouchFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_touchFx != null)
			{
				this.m_touchFx.Dispose();
				this.m_touchFx = null;
			}
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x0038457C File Offset: 0x0038277C
		public void SetTouchFxStyle(int style)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTouchFxStyleInt32_hotfix != null)
			{
				this.m_SetTouchFxStyleInt32_hotfix.call(new object[]
				{
					this,
					style
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_touchFx != null)
			{
				if (style == 2)
				{
					this.m_touchFx.SetHitFxName("FX/UI_ABS/UI_Fx/U_click_down.prefab");
					this.m_touchFx.SetLoopFxName("FX/UI_ABS/UI_Fx/U_click_open.prefab");
				}
				else
				{
					this.m_touchFx.SetHitFxName("FX/UI_ABS/UI_Fx/U_click_down.prefab");
					this.m_touchFx.SetLoopFxName("FX/UI_ABS/UI_Fx/U_click.prefab");
				}
			}
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x00384644 File Offset: 0x00382844
		public void SetTouchFXParentActive(bool isActive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTouchFXParentActiveBoolean_hotfix != null)
			{
				this.m_SetTouchFXParentActiveBoolean_hotfix.call(new object[]
				{
					this,
					isActive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_touchFx.SetTouchFXParentActive(isActive);
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x003846C0 File Offset: 0x003828C0
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
			float deltaTime = Time.deltaTime;
			if (this.m_screenFade != null)
			{
				this.m_screenFade.Update(deltaTime);
			}
			if (this.m_touchFx != null)
			{
				this.m_touchFx.Tick(deltaTime);
			}
			if (this.m_unfocusDateTime != DateTime.MinValue)
			{
				this.m_unfocusTimer += (double)Time.unscaledDeltaTime;
			}
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x0038477C File Offset: 0x0038297C
		public void ShowMessage(string txt, float time = 2f, Action onEnd = null, bool disableInput = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageStringSingleActionBoolean_hotfix != null)
			{
				this.m_ShowMessageStringSingleActionBoolean_hotfix.call(new object[]
				{
					this,
					txt,
					time,
					onEnd,
					disableInput
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowMessage(txt, time, onEnd, disableInput));
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x00384830 File Offset: 0x00382A30
		[DebuggerHidden]
		private IEnumerator Co_ShowMessage(string txt, float time, Action onEnd, bool disableInput)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowMessageStringSingleActionBoolean_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowMessageStringSingleActionBoolean_hotfix.call(new object[]
				{
					this,
					txt,
					time,
					onEnd,
					disableInput
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.<Co_ShowMessage>c__Iterator1 <Co_ShowMessage>c__Iterator = new CommonUIController.<Co_ShowMessage>c__Iterator1();
			<Co_ShowMessage>c__Iterator.disableInput = disableInput;
			<Co_ShowMessage>c__Iterator.txt = txt;
			<Co_ShowMessage>c__Iterator.time = time;
			<Co_ShowMessage>c__Iterator.onEnd = onEnd;
			<Co_ShowMessage>c__Iterator.$this = this;
			return <Co_ShowMessage>c__Iterator;
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x00384908 File Offset: 0x00382B08
		public void ShowMessage(StringTableId id, float time = 2f, Action onEnd = null, bool disableInput = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageStringTableIdSingleActionBoolean_hotfix != null)
			{
				this.m_ShowMessageStringTableIdSingleActionBoolean_hotfix.call(new object[]
				{
					this,
					id,
					time,
					onEnd,
					disableInput
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string txt = configDataLoader.UtilityGetStringByStringTable(id);
			this.ShowMessage(txt, time, onEnd, disableInput);
		}

		// Token: 0x0600CC7D RID: 52349 RVA: 0x003849CC File Offset: 0x00382BCC
		public void ShowErrorMessage(int errorCode, float time = 2f, Action onEnd = null, bool disableInput = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowErrorMessageInt32SingleActionBoolean_hotfix != null)
			{
				this.m_ShowErrorMessageInt32SingleActionBoolean_hotfix.call(new object[]
				{
					this,
					errorCode,
					time,
					onEnd,
					disableInput
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (errorCode == -99)
			{
				global::Debug.LogWarning("ShowErrorMessage ErrCodeNetworkError");
				return;
			}
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			string text = clientConfigDataLoader.UtilityGetErrorCodeString(errorCode);
			this.ShowMessage(text, time, onEnd, disableInput);
			global::Debug.LogWarning(string.Format("ShowErrorMessage, error code {0}: {1}", errorCode, text));
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x00384AB8 File Offset: 0x00382CB8
		public void ShowDialogBox(string msgText, Action<DialogBoxResult> callback, string okText = "", string cancelText = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDialogBoxStringAction`1StringString_hotfix != null)
			{
				this.m_ShowDialogBoxStringAction`1StringString_hotfix.call(new object[]
				{
					this,
					msgText,
					callback,
					okText,
					cancelText
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (string.IsNullOrEmpty(okText))
			{
				okText = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok);
			}
			if (cancelText == null)
			{
				cancelText = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Cancel);
			}
			this.m_dialogBox.Show(msgText, okText, cancelText, callback);
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00384BA4 File Offset: 0x00382DA4
		public bool CancelDialogBox()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelDialogBox_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CancelDialogBox_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_dialogBox != null && this.m_dialogBox.Cancel();
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00384C30 File Offset: 0x00382E30
		public void ShowDialogBox(StringTableId msgId, Action<DialogBoxResult> callback, StringTableId okId = (StringTableId)0, StringTableId cancelId = (StringTableId)0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDialogBoxStringTableIdAction`1StringTableIdStringTableId_hotfix != null)
			{
				this.m_ShowDialogBoxStringTableIdAction`1StringTableIdStringTableId_hotfix.call(new object[]
				{
					this,
					msgId,
					callback,
					okId,
					cancelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string msgText = configDataLoader.UtilityGetStringByStringTable(msgId);
			string okText = configDataLoader.UtilityGetStringByStringTable(okId);
			string text = configDataLoader.UtilityGetStringByStringTable(cancelId);
			if (string.IsNullOrEmpty(text))
			{
				text = null;
			}
			this.ShowDialogBox(msgText, callback, okText, text);
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x00384D10 File Offset: 0x00382F10
		public void ShowExplanation(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowExplanationString_hotfix != null)
			{
				this.m_ShowExplanationString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_explanationUIStateController, "Show", null, false, true);
			this.m_explanationText.text = txt;
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x00384DA0 File Offset: 0x00382FA0
		public void ShowExplanation(ExplanationId id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowExplanationExplanationId_hotfix != null)
			{
				this.m_ShowExplanationExplanationId_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string value = configDataLoader.GetConfigDataExplanationInfo((int)id).Value;
			this.ShowExplanation(value);
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x00384E34 File Offset: 0x00383034
		public void ShowTip(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTipString_hotfix != null)
			{
				this.m_ShowTipString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tipUIStateController.gameObject.SetActive(true);
			this.m_tipText.text = txt;
			this.m_tipUIStateController.SetToUIState("Show", false, true);
		}

		// Token: 0x0600CC84 RID: 52356 RVA: 0x00384ED4 File Offset: 0x003830D4
		public void ShowNotice(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNoticeString_hotfix != null)
			{
				this.m_ShowNoticeString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(txt))
			{
				return;
			}
			this.m_waitingNotices.Add(txt);
			if (this.m_isShowingNotice)
			{
				return;
			}
			this.ShowNextNotice();
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x00384F70 File Offset: 0x00383170
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
			if (this.m_waitingNotices.Count == 0)
			{
				return;
			}
			string text = this.m_waitingNotices[0];
			this.m_waitingNotices.RemoveAt(0);
			this.m_noticeGameObject.SetActive(true);
			if (this.m_delayHideNoticeCoroutine != null)
			{
				base.StopCoroutine(this.m_delayHideNoticeCoroutine);
				this.m_delayHideNoticeCoroutine = null;
			}
			this.m_noticeText.text = text;
			this.m_noticeShowTween.from = (this.m_noticeShowTween.to = this.m_noticeTextInitPos);
			float height = this.m_noticeText.rectTransform.rect.height;
			TweenPos noticeShowTween = this.m_noticeShowTween;
			noticeShowTween.from.y = noticeShowTween.from.y - height;
			this.m_noticeShowTween.duration = height / 100f;
			this.m_noticeShowTween.ResetToBeginning();
			this.m_noticeMoveTween.ResetToBeginning();
			this.m_noticeMoveTween.enabled = false;
			this.m_noticeShowTween.PlayForward();
			this.m_isShowingNotice = true;
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x003850C8 File Offset: 0x003832C8
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
				this.m_delayHideNoticeCoroutine = base.StartCoroutine(this.DelayHideNotice(2f));
				return;
			}
			this.m_noticeMoveTween.delay = 1f;
			this.m_noticeMoveTween.duration = num / 100f;
			this.m_noticeMoveTween.from = (this.m_noticeMoveTween.to = this.m_noticeTextInitPos);
			TweenPos noticeMoveTween = this.m_noticeMoveTween;
			noticeMoveTween.to.x = noticeMoveTween.to.x - num;
			this.m_noticeMoveTween.ResetToBeginning();
			this.m_noticeMoveTween.PlayForward();
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x003851D0 File Offset: 0x003833D0
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
			this.m_delayHideNoticeCoroutine = base.StartCoroutine(this.DelayHideNotice(2f));
		}

		// Token: 0x0600CC88 RID: 52360 RVA: 0x00385248 File Offset: 0x00383448
		[DebuggerHidden]
		private IEnumerator DelayHideNotice(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DelayHideNoticeSingle_hotfix != null)
			{
				return (IEnumerator)this.m_DelayHideNoticeSingle_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.<DelayHideNotice>c__Iterator2 <DelayHideNotice>c__Iterator = new CommonUIController.<DelayHideNotice>c__Iterator2();
			<DelayHideNotice>c__Iterator.time = time;
			<DelayHideNotice>c__Iterator.$this = this;
			return <DelayHideNotice>c__Iterator;
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x003852DC File Offset: 0x003834DC
		public void ShowLoading(FadeStyle style)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowLoadingFadeStyle_hotfix != null)
			{
				this.m_ShowLoadingFadeStyle_hotfix.call(new object[]
				{
					this,
					style
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loadingGameObject.SetActive(true);
			for (int i = 0; i < this.m_loadingGameObject.transform.childCount; i++)
			{
				this.m_loadingGameObject.transform.GetChild(i).gameObject.SetActive(i + FadeStyle.Black == style);
			}
		}

		// Token: 0x0600CC8A RID: 52362 RVA: 0x0038539C File Offset: 0x0038359C
		public void HideLoading()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideLoading_hotfix != null)
			{
				this.m_HideLoading_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_loadingGameObject.SetActive(false);
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x00385408 File Offset: 0x00383608
		public void ShowWaitingNet(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitingNetBoolean_hotfix != null)
			{
				this.m_ShowWaitingNetBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (show)
			{
				UIUtility.SetUIStateOpen(this.m_networkWatingStateController, "Open", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateClose(this.m_networkWatingStateController, "Close", null, false, true);
			}
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x003854AC File Offset: 0x003836AC
		public void EnableInput(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableInputBoolean_hotfix != null)
			{
				this.m_EnableInputBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isGameDisableInput = !enable;
			this.UpdateDisableInput();
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x0038552C File Offset: 0x0038372C
		public bool IsEnableInput()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnableInput_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnableInput_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.m_isGameDisableInput;
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x003855A4 File Offset: 0x003837A4
		public void FrameworkUITaskEnableInput(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FrameworkUITaskEnableInputBoolean_hotfix != null)
			{
				this.m_FrameworkUITaskEnableInputBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFrameworkUITaskDisableInput = !enable;
			this.UpdateDisableInput();
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x00385624 File Offset: 0x00383824
		public bool IsFrameworkUITaskDisableInput()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFrameworkUITaskDisableInput_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFrameworkUITaskDisableInput_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isFrameworkUITaskDisableInput;
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x00385698 File Offset: 0x00383898
		public void FrameworkNetTaskEnableInput(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FrameworkNetTaskEnableInputBoolean_hotfix != null)
			{
				this.m_FrameworkNetTaskEnableInputBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isFrameworkNetTaskDisableInput = !enable;
			this.UpdateDisableInput();
		}

		// Token: 0x0600CC91 RID: 52369 RVA: 0x00385718 File Offset: 0x00383918
		public bool IsFrameworkNetTaskDisableInput()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFrameworkNetTaskDisableInput_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFrameworkNetTaskDisableInput_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isFrameworkNetTaskDisableInput;
		}

		// Token: 0x0600CC92 RID: 52370 RVA: 0x0038578C File Offset: 0x0038398C
		public void PDSDKEnableInput(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PDSDKEnableInputBoolean_hotfix != null)
			{
				this.m_PDSDKEnableInputBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isPDSDKDisableInput = !enable;
			this.m_transparentMaskGameObject.SetActive(this.m_isPDSDKDisableInput);
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00385818 File Offset: 0x00383A18
		private void UpdateDisableInput()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDisableInput_hotfix != null)
			{
				this.m_UpdateDisableInput_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_isGameDisableInput || this.m_isFrameworkUITaskDisableInput || this.m_isFrameworkNetTaskDisableInput;
			this.m_disableInputGameObject.SetActive(flag);
			if (flag)
			{
				this.m_disableInputHintImage.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper);
				if (this.m_isFrameworkNetTaskDisableInput)
				{
					this.SetDisableInputHintColor(Color.green);
				}
				else if (this.m_isFrameworkUITaskDisableInput)
				{
					this.SetDisableInputHintColor(Color.blue);
				}
				else
				{
					this.SetDisableInputHintColor(Color.white);
				}
			}
		}

		// Token: 0x0600CC94 RID: 52372 RVA: 0x0038590C File Offset: 0x00383B0C
		public bool IsAnyDisableInput()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAnyDisableInput_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAnyDisableInput_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isGameDisableInput || this.m_isFrameworkUITaskDisableInput || this.m_isFrameworkNetTaskDisableInput || this.m_isPDSDKDisableInput;
		}

		// Token: 0x0600CC95 RID: 52373 RVA: 0x003859A4 File Offset: 0x00383BA4
		public bool IsDisableInputObject(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDisableInputObjectGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDisableInputObjectGameObject_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_disableInputGameObject == obj;
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x00385A2C File Offset: 0x00383C2C
		public bool IsTestToolbarObject(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTestToolbarObjectGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTestToolbarObjectGameObject_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_testUIBackgroundToolBarGameObject == obj;
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x00385AB4 File Offset: 0x00383CB4
		private void OnPDSDKWebViewOpen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPDSDKWebViewOpen_hotfix != null)
			{
				this.m_OnPDSDKWebViewOpen_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("CommonUIController.OnPDSDKWebViewOpen");
			this.PDSDKEnableInput(false);
		}

		// Token: 0x0600CC98 RID: 52376 RVA: 0x00385B28 File Offset: 0x00383D28
		private void OnPDSDKWebViewClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPDSDKWebViewClose_hotfix != null)
			{
				this.m_OnPDSDKWebViewClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("CommonUIController.OnPDSDKWebViewClose");
			this.PDSDKEnableInput(true);
		}

		// Token: 0x0600CC99 RID: 52377 RVA: 0x00385B9C File Offset: 0x00383D9C
		private void SetDisableInputHintColor(Color c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDisableInputHintColorColor_hotfix != null)
			{
				this.m_SetDisableInputHintColorColor_hotfix.call(new object[]
				{
					this,
					c
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_disableInputHintImage.color = c;
		}

		// Token: 0x0600CC9A RID: 52378 RVA: 0x00385C18 File Offset: 0x00383E18
		public void ShowBlackFrame(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBlackFrameBoolean_hotfix != null)
			{
				this.m_ShowBlackFrameBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_blackFrameGameObject.SetActive(show);
		}

		// Token: 0x0600CC9B RID: 52379 RVA: 0x00385C94 File Offset: 0x00383E94
		public void ShowTestUIBackground(bool showToggle, bool showBar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTestUIBackgroundBooleanBoolean_hotfix != null)
			{
				this.m_ShowTestUIBackgroundBooleanBoolean_hotfix.call(new object[]
				{
					this,
					showToggle,
					showBar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_testUIBackgroundGameObject.SetActive(showToggle || showBar);
			this.m_testUIBackgroundToolToggleGameObject.SetActive(showToggle && !showBar);
			this.m_testUIBackgroundToolBarGameObject.SetActive(showBar);
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x00385D50 File Offset: 0x00383F50
		public void ShowiPhoneXTest(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowiPhoneXTestBoolean_hotfix != null)
			{
				this.m_ShowiPhoneXTestBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_iPhoneXTestGameObject.SetActive(show);
		}

		// Token: 0x0600CC9D RID: 52381 RVA: 0x00385DCC File Offset: 0x00383FCC
		public void StartFadeOut(Action fadeoutEnd, FadeStyle style = FadeStyle.Black, float fadeOutTime = -1f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartFadeOutActionFadeStyleSingle_hotfix != null)
			{
				this.m_StartFadeOutActionFadeStyleSingle_hotfix.call(new object[]
				{
					this,
					fadeoutEnd,
					style,
					fadeOutTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (fadeOutTime < 0f)
			{
				fadeOutTime = this.m_defaultFadeOutTime;
			}
			Color color = Color.black;
			if (style == FadeStyle.White)
			{
				color = Color.white;
			}
			this.FadeOut(fadeOutTime, color, fadeoutEnd);
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x00385E8C File Offset: 0x0038408C
		public void StartShowFadeOutLoadingFadeIn(Action fadeOutEnd, FadeStyle style = FadeStyle.Black, float fadeOutTime = -1f, float fadeInTime = -1f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix != null)
			{
				this.m_StartShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix.call(new object[]
				{
					this,
					fadeOutEnd,
					style,
					fadeOutTime,
					fadeInTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsFading())
			{
				fadeOutTime = 0f;
			}
			base.StartCoroutine(this.ShowFadeOutLoadingFadeIn(fadeOutEnd, style, fadeOutTime, fadeInTime));
		}

		// Token: 0x0600CC9F RID: 52383 RVA: 0x00385F50 File Offset: 0x00384150
		[DebuggerHidden]
		private IEnumerator ShowFadeOutLoadingFadeIn(Action fadeOutEnd, FadeStyle style, float fadeOutTime, float fadeInTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix != null)
			{
				return (IEnumerator)this.m_ShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix.call(new object[]
				{
					this,
					fadeOutEnd,
					style,
					fadeOutTime,
					fadeInTime
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.<ShowFadeOutLoadingFadeIn>c__Iterator3 <ShowFadeOutLoadingFadeIn>c__Iterator = new CommonUIController.<ShowFadeOutLoadingFadeIn>c__Iterator3();
			<ShowFadeOutLoadingFadeIn>c__Iterator.fadeOutTime = fadeOutTime;
			<ShowFadeOutLoadingFadeIn>c__Iterator.fadeInTime = fadeInTime;
			<ShowFadeOutLoadingFadeIn>c__Iterator.style = style;
			<ShowFadeOutLoadingFadeIn>c__Iterator.fadeOutEnd = fadeOutEnd;
			<ShowFadeOutLoadingFadeIn>c__Iterator.$this = this;
			return <ShowFadeOutLoadingFadeIn>c__Iterator;
		}

		// Token: 0x0600CCA0 RID: 52384 RVA: 0x00386028 File Offset: 0x00384228
		public void HideFadeOutLoadingFadeIn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideFadeOutLoadingFadeIn_hotfix != null)
			{
				this.m_HideFadeOutLoadingFadeIn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hideFadeOutLoadingFadeIn = true;
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x00386090 File Offset: 0x00384290
		public void FadeIn(float time, Color color, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeInSingleColorAction_hotfix != null)
			{
				this.m_FadeInSingleColorAction_hotfix.call(new object[]
				{
					this,
					time,
					color,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_screenFade.FadeIn(time, color, onEnd);
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x00386130 File Offset: 0x00384330
		public void FadeOut(float time, Color color, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeOutSingleColorAction_hotfix != null)
			{
				this.m_FadeOutSingleColorAction_hotfix.call(new object[]
				{
					this,
					time,
					color,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_screenFade.FadeOut(time, color, onEnd);
		}

		// Token: 0x0600CCA3 RID: 52387 RVA: 0x003861D0 File Offset: 0x003843D0
		public bool IsFading()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFading_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFading_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_fadeImage.gameObject.activeSelf;
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x0600CCA5 RID: 52389 RVA: 0x003862C8 File Offset: 0x003844C8
		// (set) Token: 0x0600CCA4 RID: 52388 RVA: 0x0038624C File Offset: 0x0038444C
		public bool EnableScreenRecordFunction
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EnableScreenRecordFunction_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_EnableScreenRecordFunction_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_screenRecorderGameObject.activeSelf;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_EnableScreenRecordFunctionBoolean_hotfix != null)
				{
					this.m_set_EnableScreenRecordFunctionBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_screenRecorderGameObject.SetActive(value);
			}
		}

		// Token: 0x0600CCA6 RID: 52390 RVA: 0x00386340 File Offset: 0x00384540
		private void OnApplicationFocus(bool focus)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationFocusBoolean_hotfix != null)
			{
				this.m_OnApplicationFocusBoolean_hotfix.call(new object[]
				{
					this,
					focus
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("CommonUIController.OnApplicationFocus {0}", focus));
			if (!focus && this.m_touchFx != null)
			{
				this.m_touchFx.ClearFx();
			}
			if (focus)
			{
				if (this.m_unfocusDateTime != DateTime.MinValue)
				{
					double num = Math.Abs(Math.Abs((this.m_unfocusDateTime - DateTime.Now).TotalSeconds) - this.m_unfocusTimer);
					if (num > 60.0)
					{
						global::Debug.LogError(string.Format("CommonUIController.OnApplicationFocus system timer was changed {0}", num));
						IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
						ReloginUITask.Enable = false;
						this.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ClientPauseReloginTimeout), delegate(DialogBoxResult ret)
						{
							GameManager.Instance.Return2Login(true);
							ReloginUITask.Enable = true;
						}, configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty);
					}
					this.m_unfocusDateTime = DateTime.MinValue;
					this.m_unfocusTimer = 0.0;
				}
			}
			else
			{
				this.m_unfocusDateTime = DateTime.Now;
			}
		}

		// Token: 0x0600CCA7 RID: 52391 RVA: 0x003864C8 File Offset: 0x003846C8
		private void OnApplicationPause(bool isPause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationPauseBoolean_hotfix != null)
			{
				this.m_OnApplicationPauseBoolean_hotfix.call(new object[]
				{
					this,
					isPause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log(string.Format("CommonUIController.OnApplicationPause {0}", isPause));
			bool flag = PDSDK.Instance != null && PDSDK.Instance.m_isCallWebView;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (isPause)
			{
				if (this.m_touchFx != null)
				{
					this.m_touchFx.ClearFx();
				}
				if (projectLPlayerContext != null && projectLPlayerContext.GetChatComponent().DataDirty)
				{
					projectLPlayerContext.GetChatComponent().SaveChatHistoryData();
				}
				this.m_pauseTime = DateTime.Now;
			}
			else if (this.m_pauseTime != DateTime.MinValue)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				if (!flag && (DateTime.Now - this.m_pauseTime).TotalSeconds >= (double)configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ClientPauseReloginTimeout))
				{
					ReloginUITask.Enable = false;
					this.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ClientPauseReloginTimeout), delegate(DialogBoxResult ret)
					{
						GameManager.Instance.Return2Login(true);
						ReloginUITask.Enable = true;
					}, configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty);
				}
				else
				{
					base.StartCoroutine(LoginUITask.CheckClientVersion());
				}
				if (PDSDK.Instance != null)
				{
					PDSDK.Instance.m_isCallWebView = false;
				}
				this.m_pauseTime = DateTime.MinValue;
			}
		}

		// Token: 0x0600CCA8 RID: 52392 RVA: 0x00386698 File Offset: 0x00384898
		private void OnExplanationBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExplanationBackgroundButtonClick_hotfix != null)
			{
				this.m_OnExplanationBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_explanationUIStateController, "Close", null, false, true);
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x0600CCA9 RID: 52393 RVA: 0x0038670C File Offset: 0x0038490C
		public static CommonUIController Instance
		{
			get
			{
				return CommonUIController.s_instance;
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600CCAA RID: 52394 RVA: 0x00386714 File Offset: 0x00384914
		// (set) Token: 0x0600CCAB RID: 52395 RVA: 0x00386734 File Offset: 0x00384934
		[DoNotToLua]
		public new CommonUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CommonUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CCAC RID: 52396 RVA: 0x00386740 File Offset: 0x00384940
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CCAD RID: 52397 RVA: 0x0038674C File Offset: 0x0038494C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CCAE RID: 52398 RVA: 0x00386754 File Offset: 0x00384954
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CCAF RID: 52399 RVA: 0x0038675C File Offset: 0x0038495C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CCB0 RID: 52400 RVA: 0x00386770 File Offset: 0x00384970
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CCB1 RID: 52401 RVA: 0x00386778 File Offset: 0x00384978
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CCB2 RID: 52402 RVA: 0x00386784 File Offset: 0x00384984
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CCB3 RID: 52403 RVA: 0x00386790 File Offset: 0x00384990
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CCB4 RID: 52404 RVA: 0x0038679C File Offset: 0x0038499C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CCB5 RID: 52405 RVA: 0x003867A8 File Offset: 0x003849A8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x003867B4 File Offset: 0x003849B4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x003867C0 File Offset: 0x003849C0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x003867CC File Offset: 0x003849CC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CCB9 RID: 52409 RVA: 0x003867D8 File Offset: 0x003849D8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CCBA RID: 52410 RVA: 0x003867E4 File Offset: 0x003849E4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CCBE RID: 52414 RVA: 0x00386818 File Offset: 0x00384A18
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
					this.m_OnDestroy_hotfix = (luaObj.RawGet("OnDestroy") as LuaFunction);
					this.m_InitTouchFx_hotfix = (luaObj.RawGet("InitTouchFx") as LuaFunction);
					this.m_DisposeTouchFx_hotfix = (luaObj.RawGet("DisposeTouchFx") as LuaFunction);
					this.m_SetTouchFxStyleInt32_hotfix = (luaObj.RawGet("SetTouchFxStyle") as LuaFunction);
					this.m_SetTouchFXParentActiveBoolean_hotfix = (luaObj.RawGet("SetTouchFXParentActive") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_ShowMessageStringSingleActionBoolean_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_Co_ShowMessageStringSingleActionBoolean_hotfix = (luaObj.RawGet("Co_ShowMessage") as LuaFunction);
					this.m_ShowMessageStringTableIdSingleActionBoolean_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_ShowErrorMessageInt32SingleActionBoolean_hotfix = (luaObj.RawGet("ShowErrorMessage") as LuaFunction);
					this.m_ShowDialogBoxStringAction`1StringString_hotfix = (luaObj.RawGet("ShowDialogBox") as LuaFunction);
					this.m_CancelDialogBox_hotfix = (luaObj.RawGet("CancelDialogBox") as LuaFunction);
					this.m_ShowDialogBoxStringTableIdAction`1StringTableIdStringTableId_hotfix = (luaObj.RawGet("ShowDialogBox") as LuaFunction);
					this.m_ShowExplanationString_hotfix = (luaObj.RawGet("ShowExplanation") as LuaFunction);
					this.m_ShowExplanationExplanationId_hotfix = (luaObj.RawGet("ShowExplanation") as LuaFunction);
					this.m_ShowTipString_hotfix = (luaObj.RawGet("ShowTip") as LuaFunction);
					this.m_ShowNoticeString_hotfix = (luaObj.RawGet("ShowNotice") as LuaFunction);
					this.m_ShowNextNotice_hotfix = (luaObj.RawGet("ShowNextNotice") as LuaFunction);
					this.m_OnNoticeShowTweenFinished_hotfix = (luaObj.RawGet("OnNoticeShowTweenFinished") as LuaFunction);
					this.m_OnNoticeMoveTweenFinished_hotfix = (luaObj.RawGet("OnNoticeMoveTweenFinished") as LuaFunction);
					this.m_DelayHideNoticeSingle_hotfix = (luaObj.RawGet("DelayHideNotice") as LuaFunction);
					this.m_ShowLoadingFadeStyle_hotfix = (luaObj.RawGet("ShowLoading") as LuaFunction);
					this.m_HideLoading_hotfix = (luaObj.RawGet("HideLoading") as LuaFunction);
					this.m_ShowWaitingNetBoolean_hotfix = (luaObj.RawGet("ShowWaitingNet") as LuaFunction);
					this.m_EnableInputBoolean_hotfix = (luaObj.RawGet("EnableInput") as LuaFunction);
					this.m_IsEnableInput_hotfix = (luaObj.RawGet("IsEnableInput") as LuaFunction);
					this.m_FrameworkUITaskEnableInputBoolean_hotfix = (luaObj.RawGet("FrameworkUITaskEnableInput") as LuaFunction);
					this.m_IsFrameworkUITaskDisableInput_hotfix = (luaObj.RawGet("IsFrameworkUITaskDisableInput") as LuaFunction);
					this.m_FrameworkNetTaskEnableInputBoolean_hotfix = (luaObj.RawGet("FrameworkNetTaskEnableInput") as LuaFunction);
					this.m_IsFrameworkNetTaskDisableInput_hotfix = (luaObj.RawGet("IsFrameworkNetTaskDisableInput") as LuaFunction);
					this.m_PDSDKEnableInputBoolean_hotfix = (luaObj.RawGet("PDSDKEnableInput") as LuaFunction);
					this.m_UpdateDisableInput_hotfix = (luaObj.RawGet("UpdateDisableInput") as LuaFunction);
					this.m_IsAnyDisableInput_hotfix = (luaObj.RawGet("IsAnyDisableInput") as LuaFunction);
					this.m_IsDisableInputObjectGameObject_hotfix = (luaObj.RawGet("IsDisableInputObject") as LuaFunction);
					this.m_IsTestToolbarObjectGameObject_hotfix = (luaObj.RawGet("IsTestToolbarObject") as LuaFunction);
					this.m_OnPDSDKWebViewOpen_hotfix = (luaObj.RawGet("OnPDSDKWebViewOpen") as LuaFunction);
					this.m_OnPDSDKWebViewClose_hotfix = (luaObj.RawGet("OnPDSDKWebViewClose") as LuaFunction);
					this.m_SetDisableInputHintColorColor_hotfix = (luaObj.RawGet("SetDisableInputHintColor") as LuaFunction);
					this.m_ShowBlackFrameBoolean_hotfix = (luaObj.RawGet("ShowBlackFrame") as LuaFunction);
					this.m_ShowTestUIBackgroundBooleanBoolean_hotfix = (luaObj.RawGet("ShowTestUIBackground") as LuaFunction);
					this.m_ShowiPhoneXTestBoolean_hotfix = (luaObj.RawGet("ShowiPhoneXTest") as LuaFunction);
					this.m_StartFadeOutActionFadeStyleSingle_hotfix = (luaObj.RawGet("StartFadeOut") as LuaFunction);
					this.m_StartShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix = (luaObj.RawGet("StartShowFadeOutLoadingFadeIn") as LuaFunction);
					this.m_ShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix = (luaObj.RawGet("ShowFadeOutLoadingFadeIn") as LuaFunction);
					this.m_HideFadeOutLoadingFadeIn_hotfix = (luaObj.RawGet("HideFadeOutLoadingFadeIn") as LuaFunction);
					this.m_FadeInSingleColorAction_hotfix = (luaObj.RawGet("FadeIn") as LuaFunction);
					this.m_FadeOutSingleColorAction_hotfix = (luaObj.RawGet("FadeOut") as LuaFunction);
					this.m_IsFading_hotfix = (luaObj.RawGet("IsFading") as LuaFunction);
					this.m_set_EnableScreenRecordFunctionBoolean_hotfix = (luaObj.RawGet("set_EnableScreenRecordFunction") as LuaFunction);
					this.m_get_EnableScreenRecordFunction_hotfix = (luaObj.RawGet("get_EnableScreenRecordFunction") as LuaFunction);
					this.m_OnApplicationFocusBoolean_hotfix = (luaObj.RawGet("OnApplicationFocus") as LuaFunction);
					this.m_OnApplicationPauseBoolean_hotfix = (luaObj.RawGet("OnApplicationPause") as LuaFunction);
					this.m_OnExplanationBackgroundButtonClick_hotfix = (luaObj.RawGet("OnExplanationBackgroundButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x00386E10 File Offset: 0x00385010
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CommonUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400802F RID: 32815
		public static bool m_hasFinishAndroidBackEvent;

		// Token: 0x04008030 RID: 32816
		private static bool m_isRunningMessageBoxAndQuitApp;

		// Token: 0x04008031 RID: 32817
		private static CommonUIController s_instance;

		// Token: 0x04008032 RID: 32818
		public TestUI TestUI;

		// Token: 0x04008033 RID: 32819
		[AutoBind("./ASRRoot", AutoBindAttribute.InitState.NotInit, false)]
		public XunfeiSDKWrapper m_xfWrapper;

		// Token: 0x04008034 RID: 32820
		[AutoBind("./Loading", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_loadingGameObject;

		// Token: 0x04008035 RID: 32821
		[AutoBind("./DisableInput", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_disableInputGameObject;

		// Token: 0x04008036 RID: 32822
		[AutoBind("./DisableInput/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_disableInputHintImage;

		// Token: 0x04008037 RID: 32823
		[AutoBind("./TransparentMask", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_transparentMaskGameObject;

		// Token: 0x04008038 RID: 32824
		[AutoBind("./BlackFrame", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_blackFrameGameObject;

		// Token: 0x04008039 RID: 32825
		[AutoBind("./Fade", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_fadeImage;

		// Token: 0x0400803A RID: 32826
		[AutoBind("./TestUIBackground", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_testUIBackgroundGameObject;

		// Token: 0x0400803B RID: 32827
		[AutoBind("./TestUIBackground/ToolBar", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_testUIBackgroundToolBarGameObject;

		// Token: 0x0400803C RID: 32828
		[AutoBind("./TestUIBackground/ToolToggle", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_testUIBackgroundToolToggleGameObject;

		// Token: 0x0400803D RID: 32829
		[AutoBind("./iPhoneXTest", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_iPhoneXTestGameObject;

		// Token: 0x0400803E RID: 32830
		[AutoBind("./Message", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_messageUIStateController;

		// Token: 0x0400803F RID: 32831
		[AutoBind("./Message/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_messageText;

		// Token: 0x04008040 RID: 32832
		[AutoBind("./Explanation", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_explanationUIStateController;

		// Token: 0x04008041 RID: 32833
		[AutoBind("./Explanation/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_explanationBackgroundButton;

		// Token: 0x04008042 RID: 32834
		[AutoBind("./Explanation/Panel/BGImage/FrameImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_explanationText;

		// Token: 0x04008043 RID: 32835
		[AutoBind("./Notice", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noticeGameObject;

		// Token: 0x04008044 RID: 32836
		[AutoBind("./Notice/Mask/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_noticeText;

		// Token: 0x04008045 RID: 32837
		[AutoBind("./Recorder", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_screenRecorderGameObject;

		// Token: 0x04008046 RID: 32838
		[AutoBind("./Tip", AutoBindAttribute.InitState.Inactive, false)]
		private CommonUIStateController m_tipUIStateController;

		// Token: 0x04008047 RID: 32839
		[AutoBind("./Tip/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_tipText;

		// Token: 0x04008048 RID: 32840
		private DialogBox m_dialogBox;

		// Token: 0x04008049 RID: 32841
		private CommonUIStateController m_networkWatingStateController;

		// Token: 0x0400804A RID: 32842
		private ScreenFade m_screenFade;

		// Token: 0x0400804B RID: 32843
		private bool m_hideFadeOutLoadingFadeIn = true;

		// Token: 0x0400804C RID: 32844
		private float m_defaultFadeOutTime = 0.3f;

		// Token: 0x0400804D RID: 32845
		private float m_defaultFadeInTime = 0.3f;

		// Token: 0x0400804E RID: 32846
		private const float NoticeTweenSpeed = 100f;

		// Token: 0x0400804F RID: 32847
		private const float ShowNoticeInterval = 2f;

		// Token: 0x04008050 RID: 32848
		private const float ShowNoticeTime = 10f;

		// Token: 0x04008051 RID: 32849
		private bool m_isShowingNotice;

		// Token: 0x04008052 RID: 32850
		private List<string> m_waitingNotices = new List<string>();

		// Token: 0x04008053 RID: 32851
		private Vector3 m_noticeTextInitPos;

		// Token: 0x04008054 RID: 32852
		private float m_noticeTextInitWidth;

		// Token: 0x04008055 RID: 32853
		private Coroutine m_delayHideNoticeCoroutine;

		// Token: 0x04008056 RID: 32854
		private TweenPos m_noticeShowTween;

		// Token: 0x04008057 RID: 32855
		private TweenPos m_noticeMoveTween;

		// Token: 0x04008058 RID: 32856
		private bool m_isGameDisableInput;

		// Token: 0x04008059 RID: 32857
		private bool m_isFrameworkUITaskDisableInput;

		// Token: 0x0400805A RID: 32858
		private bool m_isFrameworkNetTaskDisableInput;

		// Token: 0x0400805B RID: 32859
		private bool m_isPDSDKDisableInput;

		// Token: 0x0400805C RID: 32860
		private DateTime m_pauseTime = DateTime.MinValue;

		// Token: 0x0400805D RID: 32861
		private DateTime m_unfocusDateTime = DateTime.MinValue;

		// Token: 0x0400805E RID: 32862
		private double m_unfocusTimer;

		// Token: 0x0400805F RID: 32863
		private TouchFx m_touchFx;

		// Token: 0x04008060 RID: 32864
		[DoNotToLua]
		private CommonUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008063 RID: 32867
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008064 RID: 32868
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008065 RID: 32869
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008066 RID: 32870
		private LuaFunction m_OnDestroy_hotfix;

		// Token: 0x04008067 RID: 32871
		private LuaFunction m_InitTouchFx_hotfix;

		// Token: 0x04008068 RID: 32872
		private LuaFunction m_DisposeTouchFx_hotfix;

		// Token: 0x04008069 RID: 32873
		private LuaFunction m_SetTouchFxStyleInt32_hotfix;

		// Token: 0x0400806A RID: 32874
		private LuaFunction m_SetTouchFXParentActiveBoolean_hotfix;

		// Token: 0x0400806B RID: 32875
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400806C RID: 32876
		private LuaFunction m_ShowMessageStringSingleActionBoolean_hotfix;

		// Token: 0x0400806D RID: 32877
		private LuaFunction m_Co_ShowMessageStringSingleActionBoolean_hotfix;

		// Token: 0x0400806E RID: 32878
		private LuaFunction m_ShowMessageStringTableIdSingleActionBoolean_hotfix;

		// Token: 0x0400806F RID: 32879
		private LuaFunction m_ShowErrorMessageInt32SingleActionBoolean_hotfix;

		// Token: 0x04008070 RID: 32880
		private LuaFunction m_ShowDialogBoxStringAction;

		// Token: 0x04008071 RID: 32881
		private LuaFunction m_CancelDialogBox_hotfix;

		// Token: 0x04008072 RID: 32882
		private LuaFunction m_ShowDialogBoxStringTableIdAction;

		// Token: 0x04008073 RID: 32883
		private LuaFunction m_ShowExplanationString_hotfix;

		// Token: 0x04008074 RID: 32884
		private LuaFunction m_ShowExplanationExplanationId_hotfix;

		// Token: 0x04008075 RID: 32885
		private LuaFunction m_ShowTipString_hotfix;

		// Token: 0x04008076 RID: 32886
		private LuaFunction m_ShowNoticeString_hotfix;

		// Token: 0x04008077 RID: 32887
		private LuaFunction m_ShowNextNotice_hotfix;

		// Token: 0x04008078 RID: 32888
		private LuaFunction m_OnNoticeShowTweenFinished_hotfix;

		// Token: 0x04008079 RID: 32889
		private LuaFunction m_OnNoticeMoveTweenFinished_hotfix;

		// Token: 0x0400807A RID: 32890
		private LuaFunction m_DelayHideNoticeSingle_hotfix;

		// Token: 0x0400807B RID: 32891
		private LuaFunction m_ShowLoadingFadeStyle_hotfix;

		// Token: 0x0400807C RID: 32892
		private LuaFunction m_HideLoading_hotfix;

		// Token: 0x0400807D RID: 32893
		private LuaFunction m_ShowWaitingNetBoolean_hotfix;

		// Token: 0x0400807E RID: 32894
		private LuaFunction m_EnableInputBoolean_hotfix;

		// Token: 0x0400807F RID: 32895
		private LuaFunction m_IsEnableInput_hotfix;

		// Token: 0x04008080 RID: 32896
		private LuaFunction m_FrameworkUITaskEnableInputBoolean_hotfix;

		// Token: 0x04008081 RID: 32897
		private LuaFunction m_IsFrameworkUITaskDisableInput_hotfix;

		// Token: 0x04008082 RID: 32898
		private LuaFunction m_FrameworkNetTaskEnableInputBoolean_hotfix;

		// Token: 0x04008083 RID: 32899
		private LuaFunction m_IsFrameworkNetTaskDisableInput_hotfix;

		// Token: 0x04008084 RID: 32900
		private LuaFunction m_PDSDKEnableInputBoolean_hotfix;

		// Token: 0x04008085 RID: 32901
		private LuaFunction m_UpdateDisableInput_hotfix;

		// Token: 0x04008086 RID: 32902
		private LuaFunction m_IsAnyDisableInput_hotfix;

		// Token: 0x04008087 RID: 32903
		private LuaFunction m_IsDisableInputObjectGameObject_hotfix;

		// Token: 0x04008088 RID: 32904
		private LuaFunction m_IsTestToolbarObjectGameObject_hotfix;

		// Token: 0x04008089 RID: 32905
		private LuaFunction m_OnPDSDKWebViewOpen_hotfix;

		// Token: 0x0400808A RID: 32906
		private LuaFunction m_OnPDSDKWebViewClose_hotfix;

		// Token: 0x0400808B RID: 32907
		private LuaFunction m_SetDisableInputHintColorColor_hotfix;

		// Token: 0x0400808C RID: 32908
		private LuaFunction m_ShowBlackFrameBoolean_hotfix;

		// Token: 0x0400808D RID: 32909
		private LuaFunction m_ShowTestUIBackgroundBooleanBoolean_hotfix;

		// Token: 0x0400808E RID: 32910
		private LuaFunction m_ShowiPhoneXTestBoolean_hotfix;

		// Token: 0x0400808F RID: 32911
		private LuaFunction m_StartFadeOutActionFadeStyleSingle_hotfix;

		// Token: 0x04008090 RID: 32912
		private LuaFunction m_StartShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix;

		// Token: 0x04008091 RID: 32913
		private LuaFunction m_ShowFadeOutLoadingFadeInActionFadeStyleSingleSingle_hotfix;

		// Token: 0x04008092 RID: 32914
		private LuaFunction m_HideFadeOutLoadingFadeIn_hotfix;

		// Token: 0x04008093 RID: 32915
		private LuaFunction m_FadeInSingleColorAction_hotfix;

		// Token: 0x04008094 RID: 32916
		private LuaFunction m_FadeOutSingleColorAction_hotfix;

		// Token: 0x04008095 RID: 32917
		private LuaFunction m_IsFading_hotfix;

		// Token: 0x04008096 RID: 32918
		private LuaFunction m_set_EnableScreenRecordFunctionBoolean_hotfix;

		// Token: 0x04008097 RID: 32919
		private LuaFunction m_get_EnableScreenRecordFunction_hotfix;

		// Token: 0x04008098 RID: 32920
		private LuaFunction m_OnApplicationFocusBoolean_hotfix;

		// Token: 0x04008099 RID: 32921
		private LuaFunction m_OnApplicationPauseBoolean_hotfix;

		// Token: 0x0400809A RID: 32922
		private LuaFunction m_OnExplanationBackgroundButtonClick_hotfix;

		// Token: 0x02000BA7 RID: 2983
		public new class LuaExportHelper
		{
			// Token: 0x0600CCC0 RID: 52416 RVA: 0x00386E78 File Offset: 0x00385078
			public LuaExportHelper(CommonUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CCC1 RID: 52417 RVA: 0x00386E88 File Offset: 0x00385088
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CCC2 RID: 52418 RVA: 0x00386E98 File Offset: 0x00385098
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CCC3 RID: 52419 RVA: 0x00386EA8 File Offset: 0x003850A8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CCC4 RID: 52420 RVA: 0x00386EB8 File Offset: 0x003850B8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CCC5 RID: 52421 RVA: 0x00386ED0 File Offset: 0x003850D0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CCC6 RID: 52422 RVA: 0x00386EE0 File Offset: 0x003850E0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CCC7 RID: 52423 RVA: 0x00386EF0 File Offset: 0x003850F0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CCC8 RID: 52424 RVA: 0x00386F00 File Offset: 0x00385100
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CCC9 RID: 52425 RVA: 0x00386F10 File Offset: 0x00385110
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CCCA RID: 52426 RVA: 0x00386F20 File Offset: 0x00385120
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CCCB RID: 52427 RVA: 0x00386F30 File Offset: 0x00385130
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CCCC RID: 52428 RVA: 0x00386F40 File Offset: 0x00385140
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CCCD RID: 52429 RVA: 0x00386F50 File Offset: 0x00385150
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CCCE RID: 52430 RVA: 0x00386F60 File Offset: 0x00385160
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CCCF RID: 52431 RVA: 0x00386F70 File Offset: 0x00385170
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700287C RID: 10364
			// (get) Token: 0x0600CCD0 RID: 52432 RVA: 0x00386F80 File Offset: 0x00385180
			// (set) Token: 0x0600CCD1 RID: 52433 RVA: 0x00386F88 File Offset: 0x00385188
			public static bool m_isRunningMessageBoxAndQuitApp
			{
				get
				{
					return CommonUIController.m_isRunningMessageBoxAndQuitApp;
				}
				set
				{
					CommonUIController.m_isRunningMessageBoxAndQuitApp = value;
				}
			}

			// Token: 0x1700287D RID: 10365
			// (get) Token: 0x0600CCD2 RID: 52434 RVA: 0x00386F90 File Offset: 0x00385190
			// (set) Token: 0x0600CCD3 RID: 52435 RVA: 0x00386F98 File Offset: 0x00385198
			public static CommonUIController s_instance
			{
				get
				{
					return CommonUIController.s_instance;
				}
				set
				{
					CommonUIController.s_instance = value;
				}
			}

			// Token: 0x1700287E RID: 10366
			// (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x00386FA0 File Offset: 0x003851A0
			// (set) Token: 0x0600CCD5 RID: 52437 RVA: 0x00386FB0 File Offset: 0x003851B0
			public GameObject m_loadingGameObject
			{
				get
				{
					return this.m_owner.m_loadingGameObject;
				}
				set
				{
					this.m_owner.m_loadingGameObject = value;
				}
			}

			// Token: 0x1700287F RID: 10367
			// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x00386FC0 File Offset: 0x003851C0
			// (set) Token: 0x0600CCD7 RID: 52439 RVA: 0x00386FD0 File Offset: 0x003851D0
			public GameObject m_disableInputGameObject
			{
				get
				{
					return this.m_owner.m_disableInputGameObject;
				}
				set
				{
					this.m_owner.m_disableInputGameObject = value;
				}
			}

			// Token: 0x17002880 RID: 10368
			// (get) Token: 0x0600CCD8 RID: 52440 RVA: 0x00386FE0 File Offset: 0x003851E0
			// (set) Token: 0x0600CCD9 RID: 52441 RVA: 0x00386FF0 File Offset: 0x003851F0
			public Image m_disableInputHintImage
			{
				get
				{
					return this.m_owner.m_disableInputHintImage;
				}
				set
				{
					this.m_owner.m_disableInputHintImage = value;
				}
			}

			// Token: 0x17002881 RID: 10369
			// (get) Token: 0x0600CCDA RID: 52442 RVA: 0x00387000 File Offset: 0x00385200
			// (set) Token: 0x0600CCDB RID: 52443 RVA: 0x00387010 File Offset: 0x00385210
			public GameObject m_transparentMaskGameObject
			{
				get
				{
					return this.m_owner.m_transparentMaskGameObject;
				}
				set
				{
					this.m_owner.m_transparentMaskGameObject = value;
				}
			}

			// Token: 0x17002882 RID: 10370
			// (get) Token: 0x0600CCDC RID: 52444 RVA: 0x00387020 File Offset: 0x00385220
			// (set) Token: 0x0600CCDD RID: 52445 RVA: 0x00387030 File Offset: 0x00385230
			public GameObject m_blackFrameGameObject
			{
				get
				{
					return this.m_owner.m_blackFrameGameObject;
				}
				set
				{
					this.m_owner.m_blackFrameGameObject = value;
				}
			}

			// Token: 0x17002883 RID: 10371
			// (get) Token: 0x0600CCDE RID: 52446 RVA: 0x00387040 File Offset: 0x00385240
			// (set) Token: 0x0600CCDF RID: 52447 RVA: 0x00387050 File Offset: 0x00385250
			public Image m_fadeImage
			{
				get
				{
					return this.m_owner.m_fadeImage;
				}
				set
				{
					this.m_owner.m_fadeImage = value;
				}
			}

			// Token: 0x17002884 RID: 10372
			// (get) Token: 0x0600CCE0 RID: 52448 RVA: 0x00387060 File Offset: 0x00385260
			// (set) Token: 0x0600CCE1 RID: 52449 RVA: 0x00387070 File Offset: 0x00385270
			public GameObject m_testUIBackgroundGameObject
			{
				get
				{
					return this.m_owner.m_testUIBackgroundGameObject;
				}
				set
				{
					this.m_owner.m_testUIBackgroundGameObject = value;
				}
			}

			// Token: 0x17002885 RID: 10373
			// (get) Token: 0x0600CCE2 RID: 52450 RVA: 0x00387080 File Offset: 0x00385280
			// (set) Token: 0x0600CCE3 RID: 52451 RVA: 0x00387090 File Offset: 0x00385290
			public GameObject m_testUIBackgroundToolBarGameObject
			{
				get
				{
					return this.m_owner.m_testUIBackgroundToolBarGameObject;
				}
				set
				{
					this.m_owner.m_testUIBackgroundToolBarGameObject = value;
				}
			}

			// Token: 0x17002886 RID: 10374
			// (get) Token: 0x0600CCE4 RID: 52452 RVA: 0x003870A0 File Offset: 0x003852A0
			// (set) Token: 0x0600CCE5 RID: 52453 RVA: 0x003870B0 File Offset: 0x003852B0
			public GameObject m_testUIBackgroundToolToggleGameObject
			{
				get
				{
					return this.m_owner.m_testUIBackgroundToolToggleGameObject;
				}
				set
				{
					this.m_owner.m_testUIBackgroundToolToggleGameObject = value;
				}
			}

			// Token: 0x17002887 RID: 10375
			// (get) Token: 0x0600CCE6 RID: 52454 RVA: 0x003870C0 File Offset: 0x003852C0
			// (set) Token: 0x0600CCE7 RID: 52455 RVA: 0x003870D0 File Offset: 0x003852D0
			public GameObject m_iPhoneXTestGameObject
			{
				get
				{
					return this.m_owner.m_iPhoneXTestGameObject;
				}
				set
				{
					this.m_owner.m_iPhoneXTestGameObject = value;
				}
			}

			// Token: 0x17002888 RID: 10376
			// (get) Token: 0x0600CCE8 RID: 52456 RVA: 0x003870E0 File Offset: 0x003852E0
			// (set) Token: 0x0600CCE9 RID: 52457 RVA: 0x003870F0 File Offset: 0x003852F0
			public CommonUIStateController m_messageUIStateController
			{
				get
				{
					return this.m_owner.m_messageUIStateController;
				}
				set
				{
					this.m_owner.m_messageUIStateController = value;
				}
			}

			// Token: 0x17002889 RID: 10377
			// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x00387100 File Offset: 0x00385300
			// (set) Token: 0x0600CCEB RID: 52459 RVA: 0x00387110 File Offset: 0x00385310
			public Text m_messageText
			{
				get
				{
					return this.m_owner.m_messageText;
				}
				set
				{
					this.m_owner.m_messageText = value;
				}
			}

			// Token: 0x1700288A RID: 10378
			// (get) Token: 0x0600CCEC RID: 52460 RVA: 0x00387120 File Offset: 0x00385320
			// (set) Token: 0x0600CCED RID: 52461 RVA: 0x00387130 File Offset: 0x00385330
			public CommonUIStateController m_explanationUIStateController
			{
				get
				{
					return this.m_owner.m_explanationUIStateController;
				}
				set
				{
					this.m_owner.m_explanationUIStateController = value;
				}
			}

			// Token: 0x1700288B RID: 10379
			// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x00387140 File Offset: 0x00385340
			// (set) Token: 0x0600CCEF RID: 52463 RVA: 0x00387150 File Offset: 0x00385350
			public Button m_explanationBackgroundButton
			{
				get
				{
					return this.m_owner.m_explanationBackgroundButton;
				}
				set
				{
					this.m_owner.m_explanationBackgroundButton = value;
				}
			}

			// Token: 0x1700288C RID: 10380
			// (get) Token: 0x0600CCF0 RID: 52464 RVA: 0x00387160 File Offset: 0x00385360
			// (set) Token: 0x0600CCF1 RID: 52465 RVA: 0x00387170 File Offset: 0x00385370
			public Text m_explanationText
			{
				get
				{
					return this.m_owner.m_explanationText;
				}
				set
				{
					this.m_owner.m_explanationText = value;
				}
			}

			// Token: 0x1700288D RID: 10381
			// (get) Token: 0x0600CCF2 RID: 52466 RVA: 0x00387180 File Offset: 0x00385380
			// (set) Token: 0x0600CCF3 RID: 52467 RVA: 0x00387190 File Offset: 0x00385390
			public GameObject m_noticeGameObject
			{
				get
				{
					return this.m_owner.m_noticeGameObject;
				}
				set
				{
					this.m_owner.m_noticeGameObject = value;
				}
			}

			// Token: 0x1700288E RID: 10382
			// (get) Token: 0x0600CCF4 RID: 52468 RVA: 0x003871A0 File Offset: 0x003853A0
			// (set) Token: 0x0600CCF5 RID: 52469 RVA: 0x003871B0 File Offset: 0x003853B0
			public Text m_noticeText
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

			// Token: 0x1700288F RID: 10383
			// (get) Token: 0x0600CCF6 RID: 52470 RVA: 0x003871C0 File Offset: 0x003853C0
			// (set) Token: 0x0600CCF7 RID: 52471 RVA: 0x003871D0 File Offset: 0x003853D0
			public GameObject m_screenRecorderGameObject
			{
				get
				{
					return this.m_owner.m_screenRecorderGameObject;
				}
				set
				{
					this.m_owner.m_screenRecorderGameObject = value;
				}
			}

			// Token: 0x17002890 RID: 10384
			// (get) Token: 0x0600CCF8 RID: 52472 RVA: 0x003871E0 File Offset: 0x003853E0
			// (set) Token: 0x0600CCF9 RID: 52473 RVA: 0x003871F0 File Offset: 0x003853F0
			public CommonUIStateController m_tipUIStateController
			{
				get
				{
					return this.m_owner.m_tipUIStateController;
				}
				set
				{
					this.m_owner.m_tipUIStateController = value;
				}
			}

			// Token: 0x17002891 RID: 10385
			// (get) Token: 0x0600CCFA RID: 52474 RVA: 0x00387200 File Offset: 0x00385400
			// (set) Token: 0x0600CCFB RID: 52475 RVA: 0x00387210 File Offset: 0x00385410
			public Text m_tipText
			{
				get
				{
					return this.m_owner.m_tipText;
				}
				set
				{
					this.m_owner.m_tipText = value;
				}
			}

			// Token: 0x17002892 RID: 10386
			// (get) Token: 0x0600CCFC RID: 52476 RVA: 0x00387220 File Offset: 0x00385420
			// (set) Token: 0x0600CCFD RID: 52477 RVA: 0x00387230 File Offset: 0x00385430
			public DialogBox m_dialogBox
			{
				get
				{
					return this.m_owner.m_dialogBox;
				}
				set
				{
					this.m_owner.m_dialogBox = value;
				}
			}

			// Token: 0x17002893 RID: 10387
			// (get) Token: 0x0600CCFE RID: 52478 RVA: 0x00387240 File Offset: 0x00385440
			// (set) Token: 0x0600CCFF RID: 52479 RVA: 0x00387250 File Offset: 0x00385450
			public CommonUIStateController m_networkWatingStateController
			{
				get
				{
					return this.m_owner.m_networkWatingStateController;
				}
				set
				{
					this.m_owner.m_networkWatingStateController = value;
				}
			}

			// Token: 0x17002894 RID: 10388
			// (get) Token: 0x0600CD00 RID: 52480 RVA: 0x00387260 File Offset: 0x00385460
			// (set) Token: 0x0600CD01 RID: 52481 RVA: 0x00387270 File Offset: 0x00385470
			public ScreenFade m_screenFade
			{
				get
				{
					return this.m_owner.m_screenFade;
				}
				set
				{
					this.m_owner.m_screenFade = value;
				}
			}

			// Token: 0x17002895 RID: 10389
			// (get) Token: 0x0600CD02 RID: 52482 RVA: 0x00387280 File Offset: 0x00385480
			// (set) Token: 0x0600CD03 RID: 52483 RVA: 0x00387290 File Offset: 0x00385490
			public bool m_hideFadeOutLoadingFadeIn
			{
				get
				{
					return this.m_owner.m_hideFadeOutLoadingFadeIn;
				}
				set
				{
					this.m_owner.m_hideFadeOutLoadingFadeIn = value;
				}
			}

			// Token: 0x17002896 RID: 10390
			// (get) Token: 0x0600CD04 RID: 52484 RVA: 0x003872A0 File Offset: 0x003854A0
			// (set) Token: 0x0600CD05 RID: 52485 RVA: 0x003872B0 File Offset: 0x003854B0
			public float m_defaultFadeOutTime
			{
				get
				{
					return this.m_owner.m_defaultFadeOutTime;
				}
				set
				{
					this.m_owner.m_defaultFadeOutTime = value;
				}
			}

			// Token: 0x17002897 RID: 10391
			// (get) Token: 0x0600CD06 RID: 52486 RVA: 0x003872C0 File Offset: 0x003854C0
			// (set) Token: 0x0600CD07 RID: 52487 RVA: 0x003872D0 File Offset: 0x003854D0
			public float m_defaultFadeInTime
			{
				get
				{
					return this.m_owner.m_defaultFadeInTime;
				}
				set
				{
					this.m_owner.m_defaultFadeInTime = value;
				}
			}

			// Token: 0x17002898 RID: 10392
			// (get) Token: 0x0600CD08 RID: 52488 RVA: 0x003872E0 File Offset: 0x003854E0
			public static float NoticeTweenSpeed
			{
				get
				{
					return 100f;
				}
			}

			// Token: 0x17002899 RID: 10393
			// (get) Token: 0x0600CD09 RID: 52489 RVA: 0x003872E8 File Offset: 0x003854E8
			public static float ShowNoticeInterval
			{
				get
				{
					return 2f;
				}
			}

			// Token: 0x1700289A RID: 10394
			// (get) Token: 0x0600CD0A RID: 52490 RVA: 0x003872F0 File Offset: 0x003854F0
			public static float ShowNoticeTime
			{
				get
				{
					return 10f;
				}
			}

			// Token: 0x1700289B RID: 10395
			// (get) Token: 0x0600CD0B RID: 52491 RVA: 0x003872F8 File Offset: 0x003854F8
			// (set) Token: 0x0600CD0C RID: 52492 RVA: 0x00387308 File Offset: 0x00385508
			public bool m_isShowingNotice
			{
				get
				{
					return this.m_owner.m_isShowingNotice;
				}
				set
				{
					this.m_owner.m_isShowingNotice = value;
				}
			}

			// Token: 0x1700289C RID: 10396
			// (get) Token: 0x0600CD0D RID: 52493 RVA: 0x00387318 File Offset: 0x00385518
			// (set) Token: 0x0600CD0E RID: 52494 RVA: 0x00387328 File Offset: 0x00385528
			public List<string> m_waitingNotices
			{
				get
				{
					return this.m_owner.m_waitingNotices;
				}
				set
				{
					this.m_owner.m_waitingNotices = value;
				}
			}

			// Token: 0x1700289D RID: 10397
			// (get) Token: 0x0600CD0F RID: 52495 RVA: 0x00387338 File Offset: 0x00385538
			// (set) Token: 0x0600CD10 RID: 52496 RVA: 0x00387348 File Offset: 0x00385548
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

			// Token: 0x1700289E RID: 10398
			// (get) Token: 0x0600CD11 RID: 52497 RVA: 0x00387358 File Offset: 0x00385558
			// (set) Token: 0x0600CD12 RID: 52498 RVA: 0x00387368 File Offset: 0x00385568
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

			// Token: 0x1700289F RID: 10399
			// (get) Token: 0x0600CD13 RID: 52499 RVA: 0x00387378 File Offset: 0x00385578
			// (set) Token: 0x0600CD14 RID: 52500 RVA: 0x00387388 File Offset: 0x00385588
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

			// Token: 0x170028A0 RID: 10400
			// (get) Token: 0x0600CD15 RID: 52501 RVA: 0x00387398 File Offset: 0x00385598
			// (set) Token: 0x0600CD16 RID: 52502 RVA: 0x003873A8 File Offset: 0x003855A8
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

			// Token: 0x170028A1 RID: 10401
			// (get) Token: 0x0600CD17 RID: 52503 RVA: 0x003873B8 File Offset: 0x003855B8
			// (set) Token: 0x0600CD18 RID: 52504 RVA: 0x003873C8 File Offset: 0x003855C8
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

			// Token: 0x170028A2 RID: 10402
			// (get) Token: 0x0600CD19 RID: 52505 RVA: 0x003873D8 File Offset: 0x003855D8
			// (set) Token: 0x0600CD1A RID: 52506 RVA: 0x003873E8 File Offset: 0x003855E8
			public bool m_isGameDisableInput
			{
				get
				{
					return this.m_owner.m_isGameDisableInput;
				}
				set
				{
					this.m_owner.m_isGameDisableInput = value;
				}
			}

			// Token: 0x170028A3 RID: 10403
			// (get) Token: 0x0600CD1B RID: 52507 RVA: 0x003873F8 File Offset: 0x003855F8
			// (set) Token: 0x0600CD1C RID: 52508 RVA: 0x00387408 File Offset: 0x00385608
			public bool m_isFrameworkUITaskDisableInput
			{
				get
				{
					return this.m_owner.m_isFrameworkUITaskDisableInput;
				}
				set
				{
					this.m_owner.m_isFrameworkUITaskDisableInput = value;
				}
			}

			// Token: 0x170028A4 RID: 10404
			// (get) Token: 0x0600CD1D RID: 52509 RVA: 0x00387418 File Offset: 0x00385618
			// (set) Token: 0x0600CD1E RID: 52510 RVA: 0x00387428 File Offset: 0x00385628
			public bool m_isFrameworkNetTaskDisableInput
			{
				get
				{
					return this.m_owner.m_isFrameworkNetTaskDisableInput;
				}
				set
				{
					this.m_owner.m_isFrameworkNetTaskDisableInput = value;
				}
			}

			// Token: 0x170028A5 RID: 10405
			// (get) Token: 0x0600CD1F RID: 52511 RVA: 0x00387438 File Offset: 0x00385638
			// (set) Token: 0x0600CD20 RID: 52512 RVA: 0x00387448 File Offset: 0x00385648
			public bool m_isPDSDKDisableInput
			{
				get
				{
					return this.m_owner.m_isPDSDKDisableInput;
				}
				set
				{
					this.m_owner.m_isPDSDKDisableInput = value;
				}
			}

			// Token: 0x170028A6 RID: 10406
			// (get) Token: 0x0600CD21 RID: 52513 RVA: 0x00387458 File Offset: 0x00385658
			// (set) Token: 0x0600CD22 RID: 52514 RVA: 0x00387468 File Offset: 0x00385668
			public DateTime m_pauseTime
			{
				get
				{
					return this.m_owner.m_pauseTime;
				}
				set
				{
					this.m_owner.m_pauseTime = value;
				}
			}

			// Token: 0x170028A7 RID: 10407
			// (get) Token: 0x0600CD23 RID: 52515 RVA: 0x00387478 File Offset: 0x00385678
			// (set) Token: 0x0600CD24 RID: 52516 RVA: 0x00387488 File Offset: 0x00385688
			public DateTime m_unfocusDateTime
			{
				get
				{
					return this.m_owner.m_unfocusDateTime;
				}
				set
				{
					this.m_owner.m_unfocusDateTime = value;
				}
			}

			// Token: 0x170028A8 RID: 10408
			// (get) Token: 0x0600CD25 RID: 52517 RVA: 0x00387498 File Offset: 0x00385698
			// (set) Token: 0x0600CD26 RID: 52518 RVA: 0x003874A8 File Offset: 0x003856A8
			public double m_unfocusTimer
			{
				get
				{
					return this.m_owner.m_unfocusTimer;
				}
				set
				{
					this.m_owner.m_unfocusTimer = value;
				}
			}

			// Token: 0x170028A9 RID: 10409
			// (get) Token: 0x0600CD27 RID: 52519 RVA: 0x003874B8 File Offset: 0x003856B8
			// (set) Token: 0x0600CD28 RID: 52520 RVA: 0x003874C8 File Offset: 0x003856C8
			public TouchFx m_touchFx
			{
				get
				{
					return this.m_owner.m_touchFx;
				}
				set
				{
					this.m_owner.m_touchFx = value;
				}
			}

			// Token: 0x0600CD29 RID: 52521 RVA: 0x003874D8 File Offset: 0x003856D8
			public static IEnumerator MessageBoxAndQuitApp()
			{
				return CommonUIController.MessageBoxAndQuitApp();
			}

			// Token: 0x0600CD2A RID: 52522 RVA: 0x003874E0 File Offset: 0x003856E0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CD2B RID: 52523 RVA: 0x003874F0 File Offset: 0x003856F0
			public void OnDestroy()
			{
				this.m_owner.OnDestroy();
			}

			// Token: 0x0600CD2C RID: 52524 RVA: 0x00387500 File Offset: 0x00385700
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600CD2D RID: 52525 RVA: 0x00387510 File Offset: 0x00385710
			public IEnumerator Co_ShowMessage(string txt, float time, Action onEnd, bool disableInput)
			{
				return this.m_owner.Co_ShowMessage(txt, time, onEnd, disableInput);
			}

			// Token: 0x0600CD2E RID: 52526 RVA: 0x00387524 File Offset: 0x00385724
			public void ShowNextNotice()
			{
				this.m_owner.ShowNextNotice();
			}

			// Token: 0x0600CD2F RID: 52527 RVA: 0x00387534 File Offset: 0x00385734
			public void OnNoticeShowTweenFinished()
			{
				this.m_owner.OnNoticeShowTweenFinished();
			}

			// Token: 0x0600CD30 RID: 52528 RVA: 0x00387544 File Offset: 0x00385744
			public void OnNoticeMoveTweenFinished()
			{
				this.m_owner.OnNoticeMoveTweenFinished();
			}

			// Token: 0x0600CD31 RID: 52529 RVA: 0x00387554 File Offset: 0x00385754
			public IEnumerator DelayHideNotice(float time)
			{
				return this.m_owner.DelayHideNotice(time);
			}

			// Token: 0x0600CD32 RID: 52530 RVA: 0x00387564 File Offset: 0x00385764
			public void UpdateDisableInput()
			{
				this.m_owner.UpdateDisableInput();
			}

			// Token: 0x0600CD33 RID: 52531 RVA: 0x00387574 File Offset: 0x00385774
			public void OnPDSDKWebViewOpen()
			{
				this.m_owner.OnPDSDKWebViewOpen();
			}

			// Token: 0x0600CD34 RID: 52532 RVA: 0x00387584 File Offset: 0x00385784
			public void OnPDSDKWebViewClose()
			{
				this.m_owner.OnPDSDKWebViewClose();
			}

			// Token: 0x0600CD35 RID: 52533 RVA: 0x00387594 File Offset: 0x00385794
			public void SetDisableInputHintColor(Color c)
			{
				this.m_owner.SetDisableInputHintColor(c);
			}

			// Token: 0x0600CD36 RID: 52534 RVA: 0x003875A4 File Offset: 0x003857A4
			public IEnumerator ShowFadeOutLoadingFadeIn(Action fadeOutEnd, FadeStyle style, float fadeOutTime, float fadeInTime)
			{
				return this.m_owner.ShowFadeOutLoadingFadeIn(fadeOutEnd, style, fadeOutTime, fadeInTime);
			}

			// Token: 0x0600CD37 RID: 52535 RVA: 0x003875B8 File Offset: 0x003857B8
			public void OnApplicationFocus(bool focus)
			{
				this.m_owner.OnApplicationFocus(focus);
			}

			// Token: 0x0600CD38 RID: 52536 RVA: 0x003875C8 File Offset: 0x003857C8
			public void OnApplicationPause(bool isPause)
			{
				this.m_owner.OnApplicationPause(isPause);
			}

			// Token: 0x0600CD39 RID: 52537 RVA: 0x003875D8 File Offset: 0x003857D8
			public void OnExplanationBackgroundButtonClick()
			{
				this.m_owner.OnExplanationBackgroundButtonClick();
			}

			// Token: 0x0400809B RID: 32923
			private CommonUIController m_owner;
		}
	}
}
