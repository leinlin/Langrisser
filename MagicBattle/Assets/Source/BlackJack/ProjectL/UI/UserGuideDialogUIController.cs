using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FFF RID: 4095
	[HotFix]
	public class UserGuideDialogUIController : UIControllerBase
	{
		// Token: 0x060149E7 RID: 84455 RVA: 0x0053A594 File Offset: 0x00538794
		private UserGuideDialogUIController()
		{
		}

		// Token: 0x060149E8 RID: 84456 RVA: 0x0053A5A8 File Offset: 0x005387A8
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
			this.m_skipButton.onClick.AddListener(new UnityAction(this.OnSkipButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_dialogCharUIControllers[0] = GameObjectUtility.AddControllerToGameObject<DialogCharUIController>(this.m_char0GameObject);
			this.m_dialogCharUIControllers[1] = GameObjectUtility.AddControllerToGameObject<DialogCharUIController>(this.m_char1GameObject);
			this.m_dialogBoxUIController = GameObjectUtility.AddControllerToGameObject<UserGuideDialogBoxUIController>(this.m_wordsGameObject);
		}

		// Token: 0x060149E9 RID: 84457 RVA: 0x0053A680 File Offset: 0x00538880
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
			if (this.m_showDialogBoxTime > 0f)
			{
				this.m_showDialogBoxTime -= deltaTime;
				if (this.m_showDialogBoxTime <= 0f)
				{
					this.m_showDialogBoxTime = 0f;
					this.ShowDialogBox();
				}
			}
		}

		// Token: 0x060149EA RID: 84458 RVA: 0x0053A728 File Offset: 0x00538928
		public void DialogOpenTweenPlay()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DialogOpenTweenPlay_hotfix != null)
			{
				this.m_DialogOpenTweenPlay_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_backgroundUIStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x060149EB RID: 84459 RVA: 0x0053A79C File Offset: 0x0053899C
		public void SetDialog(ConfigDataUserGuideDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDialogConfigDataUserGuideDialogInfo_hotfix != null)
			{
				this.m_SetDialogConfigDataUserGuideDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			this.m_dialogInfo = dialogInfo;
			DialogCharUIController dialogCharUIController = this.m_dialogCharUIControllers[dialogInfo.Position];
			if (dialogInfo.m_charImageInfo != dialogCharUIController.GetCharImageInfo())
			{
				dialogCharUIController.CreateGraphic(dialogInfo.m_charImageInfo);
				if (dialogInfo.m_charImageInfo != null)
				{
					dialogCharUIController.SetScaleOffet((float)dialogInfo.m_charImageInfo.BattleDialogScale * 0.01f, (float)dialogInfo.m_charImageInfo.BattleDialogYOffset);
					bool flag = (dialogInfo.Position == 0 && dialogInfo.m_charImageInfo.Direction == 0) || (dialogInfo.Position == 1 && dialogInfo.m_charImageInfo.Direction == 1);
					dialogCharUIController.SetDirection((!flag) ? -1 : 1);
				}
				dialogCharUIController.Enter(dialogInfo.EnterType, null);
				this.m_showDialogBoxTime = 0.5f;
			}
			else
			{
				this.m_showDialogBoxTime = 0.1f;
			}
			if (!string.IsNullOrEmpty(dialogInfo.PreAnimation))
			{
				this.m_showDialogBoxTime += dialogCharUIController.GetAnimationDuration(dialogInfo.PreAnimation);
			}
			for (int i = 0; i < this.m_dialogCharUIControllers.Length; i++)
			{
				Color c = (i != dialogInfo.Position) ? new Color(0.5f, 0.5f, 0.5f, 1f) : Color.white;
				this.m_dialogCharUIControllers[i].TweenColor(c, 0.3f);
			}
			dialogCharUIController.SetAnimation(dialogInfo.PreAnimation, dialogInfo.PreFacialAnimation, dialogInfo.IdleAnimation, dialogInfo.IdleFacialAnimation);
			this.m_dialogBoxUIController.Show(false);
		}

		// Token: 0x060149EC RID: 84460 RVA: 0x0053A99C File Offset: 0x00538B9C
		public void CloseDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseDialog_hotfix != null)
			{
				this.m_CloseDialog_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_CloseDialog());
		}

		// Token: 0x060149ED RID: 84461 RVA: 0x0053AA0C File Offset: 0x00538C0C
		[DebuggerHidden]
		private IEnumerator Co_CloseDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_CloseDialog_hotfix != null)
			{
				return (IEnumerator)this.m_Co_CloseDialog_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideDialogUIController.<Co_CloseDialog>c__Iterator0 <Co_CloseDialog>c__Iterator = new UserGuideDialogUIController.<Co_CloseDialog>c__Iterator0();
			<Co_CloseDialog>c__Iterator.$this = this;
			return <Co_CloseDialog>c__Iterator;
		}

		// Token: 0x060149EE RID: 84462 RVA: 0x0053AA88 File Offset: 0x00538C88
		private void ShowDialogBox()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDialogBox_hotfix != null)
			{
				this.m_ShowDialogBox_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogInfo == null)
			{
				return;
			}
			this.m_dialogBoxUIController.Show(true);
			this.m_dialogBoxUIController.SetStyle(this.m_dialogInfo.Position, this.m_dialogInfo.FrameType);
			this.m_dialogBoxUIController.SetWords(this.m_dialogInfo.Words);
			this.m_dialogBoxUIController.SetName(this.m_dialogInfo.CharName);
			this.m_dialogBoxUIController.Open(null);
			IAudioPlayback audioPlayback = this.PlayVoice(this.m_dialogInfo.Voice);
			this.m_currentAudio = audioPlayback;
			float num;
			if (audioPlayback != null)
			{
				num = audioPlayback.Seconds;
				this.m_dialogBoxUIController.SetVoicePlayTime(num);
			}
			else
			{
				num = this.m_dialogBoxUIController.GetWordsDisplayTime();
				this.m_dialogBoxUIController.SetVoicePlayTime(0f);
			}
			num = Mathf.Max(num, 1f);
			DialogCharUIController dialogCharUIController = this.m_dialogCharUIControllers[this.m_dialogInfo.Position];
			dialogCharUIController.StartFacialAnimation(num);
		}

		// Token: 0x060149EF RID: 84463 RVA: 0x0053ABD8 File Offset: 0x00538DD8
		private IAudioPlayback PlayVoice(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayVoiceString_hotfix != null)
			{
				return (IAudioPlayback)this.m_PlayVoiceString_hotfix.call(new object[]
				{
					this,
					name
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return AudioUtility.PlaySound(name);
		}

		// Token: 0x060149F0 RID: 84464 RVA: 0x0053AC5C File Offset: 0x00538E5C
		private void StopVoice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopVoice_hotfix != null)
			{
				this.m_StopVoice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (DialogCharUIController dialogCharUIController in this.m_dialogCharUIControllers)
			{
				if (dialogCharUIController != null)
				{
					dialogCharUIController.StopMouthAnimation();
				}
			}
		}

		// Token: 0x060149F1 RID: 84465 RVA: 0x0053ACF0 File Offset: 0x00538EF0
		[DebuggerHidden]
		private IEnumerator Co_NextDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_NextDialog_hotfix != null)
			{
				return (IEnumerator)this.m_Co_NextDialog_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideDialogUIController.<Co_NextDialog>c__Iterator1 <Co_NextDialog>c__Iterator = new UserGuideDialogUIController.<Co_NextDialog>c__Iterator1();
			<Co_NextDialog>c__Iterator.$this = this;
			return <Co_NextDialog>c__Iterator;
		}

		// Token: 0x060149F2 RID: 84466 RVA: 0x0053AD6C File Offset: 0x00538F6C
		private void OnSkipButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkipButtonClick_hotfix != null)
			{
				this.m_OnSkipButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkip != null)
			{
				this.EventOnSkip();
			}
		}

		// Token: 0x060149F3 RID: 84467 RVA: 0x0053ADE4 File Offset: 0x00538FE4
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_showDialogBoxTime > 0f)
			{
				return;
			}
			if (this.m_dialogBoxUIController.IsOpened())
			{
				base.StartCoroutine(this.Co_NextDialog());
			}
		}

		// Token: 0x1400048A RID: 1162
		// (add) Token: 0x060149F4 RID: 84468 RVA: 0x0053AE74 File Offset: 0x00539074
		// (remove) Token: 0x060149F5 RID: 84469 RVA: 0x0053AF10 File Offset: 0x00539110
		public event Action EventOnSkip
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkipAction_hotfix != null)
				{
					this.m_add_EventOnSkipAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkip;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkip, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkipAction_hotfix != null)
				{
					this.m_remove_EventOnSkipAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkip;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkip, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400048B RID: 1163
		// (add) Token: 0x060149F6 RID: 84470 RVA: 0x0053AFAC File Offset: 0x005391AC
		// (remove) Token: 0x060149F7 RID: 84471 RVA: 0x0053B048 File Offset: 0x00539248
		public event Action EventOnNext
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNextAction_hotfix != null)
				{
					this.m_add_EventOnNextAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNext;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNext, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNextAction_hotfix != null)
				{
					this.m_remove_EventOnNextAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNext;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNext, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400048C RID: 1164
		// (add) Token: 0x060149F8 RID: 84472 RVA: 0x0053B0E4 File Offset: 0x005392E4
		// (remove) Token: 0x060149F9 RID: 84473 RVA: 0x0053B180 File Offset: 0x00539380
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

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x060149FA RID: 84474 RVA: 0x0053B21C File Offset: 0x0053941C
		// (set) Token: 0x060149FB RID: 84475 RVA: 0x0053B23C File Offset: 0x0053943C
		[DoNotToLua]
		public new UserGuideDialogUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UserGuideDialogUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060149FC RID: 84476 RVA: 0x0053B248 File Offset: 0x00539448
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060149FD RID: 84477 RVA: 0x0053B254 File Offset: 0x00539454
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060149FE RID: 84478 RVA: 0x0053B25C File Offset: 0x0053945C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060149FF RID: 84479 RVA: 0x0053B264 File Offset: 0x00539464
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014A00 RID: 84480 RVA: 0x0053B278 File Offset: 0x00539478
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014A01 RID: 84481 RVA: 0x0053B280 File Offset: 0x00539480
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014A02 RID: 84482 RVA: 0x0053B28C File Offset: 0x0053948C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014A03 RID: 84483 RVA: 0x0053B298 File Offset: 0x00539498
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014A04 RID: 84484 RVA: 0x0053B2A4 File Offset: 0x005394A4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014A05 RID: 84485 RVA: 0x0053B2B0 File Offset: 0x005394B0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014A06 RID: 84486 RVA: 0x0053B2BC File Offset: 0x005394BC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014A07 RID: 84487 RVA: 0x0053B2C8 File Offset: 0x005394C8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014A08 RID: 84488 RVA: 0x0053B2D4 File Offset: 0x005394D4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014A09 RID: 84489 RVA: 0x0053B2E0 File Offset: 0x005394E0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014A0A RID: 84490 RVA: 0x0053B2EC File Offset: 0x005394EC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014A0B RID: 84491 RVA: 0x0053B2F4 File Offset: 0x005394F4
		private void __callDele_EventOnSkip()
		{
			Action eventOnSkip = this.EventOnSkip;
			if (eventOnSkip != null)
			{
				eventOnSkip();
			}
		}

		// Token: 0x06014A0C RID: 84492 RVA: 0x0053B314 File Offset: 0x00539514
		private void __clearDele_EventOnSkip()
		{
			this.EventOnSkip = null;
		}

		// Token: 0x06014A0D RID: 84493 RVA: 0x0053B320 File Offset: 0x00539520
		private void __callDele_EventOnNext()
		{
			Action eventOnNext = this.EventOnNext;
			if (eventOnNext != null)
			{
				eventOnNext();
			}
		}

		// Token: 0x06014A0E RID: 84494 RVA: 0x0053B340 File Offset: 0x00539540
		private void __clearDele_EventOnNext()
		{
			this.EventOnNext = null;
		}

		// Token: 0x06014A0F RID: 84495 RVA: 0x0053B34C File Offset: 0x0053954C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06014A10 RID: 84496 RVA: 0x0053B36C File Offset: 0x0053956C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06014A11 RID: 84497 RVA: 0x0053B378 File Offset: 0x00539578
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
					this.m_DialogOpenTweenPlay_hotfix = (luaObj.RawGet("DialogOpenTweenPlay") as LuaFunction);
					this.m_SetDialogConfigDataUserGuideDialogInfo_hotfix = (luaObj.RawGet("SetDialog") as LuaFunction);
					this.m_CloseDialog_hotfix = (luaObj.RawGet("CloseDialog") as LuaFunction);
					this.m_Co_CloseDialog_hotfix = (luaObj.RawGet("Co_CloseDialog") as LuaFunction);
					this.m_ShowDialogBox_hotfix = (luaObj.RawGet("ShowDialogBox") as LuaFunction);
					this.m_PlayVoiceString_hotfix = (luaObj.RawGet("PlayVoice") as LuaFunction);
					this.m_StopVoice_hotfix = (luaObj.RawGet("StopVoice") as LuaFunction);
					this.m_Co_NextDialog_hotfix = (luaObj.RawGet("Co_NextDialog") as LuaFunction);
					this.m_OnSkipButtonClick_hotfix = (luaObj.RawGet("OnSkipButtonClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnSkipAction_hotfix = (luaObj.RawGet("add_EventOnSkip") as LuaFunction);
					this.m_remove_EventOnSkipAction_hotfix = (luaObj.RawGet("remove_EventOnSkip") as LuaFunction);
					this.m_add_EventOnNextAction_hotfix = (luaObj.RawGet("add_EventOnNext") as LuaFunction);
					this.m_remove_EventOnNextAction_hotfix = (luaObj.RawGet("remove_EventOnNext") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014A12 RID: 84498 RVA: 0x0053B5EC File Offset: 0x005397EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideDialogUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B504 RID: 46340
		[AutoBind("./SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skipButton;

		// Token: 0x0400B505 RID: 46341
		[AutoBind("./Background", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_backgroundUIStateCtrl;

		// Token: 0x0400B506 RID: 46342
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400B507 RID: 46343
		[AutoBind("./WordPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_wordsGameObject;

		// Token: 0x0400B508 RID: 46344
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char0GameObject;

		// Token: 0x0400B509 RID: 46345
		[AutoBind("./Char/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char1GameObject;

		// Token: 0x0400B50A RID: 46346
		private DialogCharUIController[] m_dialogCharUIControllers = new DialogCharUIController[2];

		// Token: 0x0400B50B RID: 46347
		private UserGuideDialogBoxUIController m_dialogBoxUIController;

		// Token: 0x0400B50C RID: 46348
		private ConfigDataUserGuideDialogInfo m_dialogInfo;

		// Token: 0x0400B50D RID: 46349
		private float m_showDialogBoxTime;

		// Token: 0x0400B50E RID: 46350
		private IAudioPlayback m_currentAudio;

		// Token: 0x0400B50F RID: 46351
		[DoNotToLua]
		private UserGuideDialogUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B510 RID: 46352
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B511 RID: 46353
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B512 RID: 46354
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B513 RID: 46355
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400B514 RID: 46356
		private LuaFunction m_DialogOpenTweenPlay_hotfix;

		// Token: 0x0400B515 RID: 46357
		private LuaFunction m_SetDialogConfigDataUserGuideDialogInfo_hotfix;

		// Token: 0x0400B516 RID: 46358
		private LuaFunction m_CloseDialog_hotfix;

		// Token: 0x0400B517 RID: 46359
		private LuaFunction m_Co_CloseDialog_hotfix;

		// Token: 0x0400B518 RID: 46360
		private LuaFunction m_ShowDialogBox_hotfix;

		// Token: 0x0400B519 RID: 46361
		private LuaFunction m_PlayVoiceString_hotfix;

		// Token: 0x0400B51A RID: 46362
		private LuaFunction m_StopVoice_hotfix;

		// Token: 0x0400B51B RID: 46363
		private LuaFunction m_Co_NextDialog_hotfix;

		// Token: 0x0400B51C RID: 46364
		private LuaFunction m_OnSkipButtonClick_hotfix;

		// Token: 0x0400B51D RID: 46365
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400B51E RID: 46366
		private LuaFunction m_add_EventOnSkipAction_hotfix;

		// Token: 0x0400B51F RID: 46367
		private LuaFunction m_remove_EventOnSkipAction_hotfix;

		// Token: 0x0400B520 RID: 46368
		private LuaFunction m_add_EventOnNextAction_hotfix;

		// Token: 0x0400B521 RID: 46369
		private LuaFunction m_remove_EventOnNextAction_hotfix;

		// Token: 0x0400B522 RID: 46370
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400B523 RID: 46371
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02001000 RID: 4096
		public new class LuaExportHelper
		{
			// Token: 0x06014A13 RID: 84499 RVA: 0x0053B654 File Offset: 0x00539854
			public LuaExportHelper(UserGuideDialogUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014A14 RID: 84500 RVA: 0x0053B664 File Offset: 0x00539864
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014A15 RID: 84501 RVA: 0x0053B674 File Offset: 0x00539874
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014A16 RID: 84502 RVA: 0x0053B684 File Offset: 0x00539884
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014A17 RID: 84503 RVA: 0x0053B694 File Offset: 0x00539894
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014A18 RID: 84504 RVA: 0x0053B6AC File Offset: 0x005398AC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014A19 RID: 84505 RVA: 0x0053B6BC File Offset: 0x005398BC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014A1A RID: 84506 RVA: 0x0053B6CC File Offset: 0x005398CC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014A1B RID: 84507 RVA: 0x0053B6DC File Offset: 0x005398DC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014A1C RID: 84508 RVA: 0x0053B6EC File Offset: 0x005398EC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014A1D RID: 84509 RVA: 0x0053B6FC File Offset: 0x005398FC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014A1E RID: 84510 RVA: 0x0053B70C File Offset: 0x0053990C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014A1F RID: 84511 RVA: 0x0053B71C File Offset: 0x0053991C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014A20 RID: 84512 RVA: 0x0053B72C File Offset: 0x0053992C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014A21 RID: 84513 RVA: 0x0053B73C File Offset: 0x0053993C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014A22 RID: 84514 RVA: 0x0053B74C File Offset: 0x0053994C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014A23 RID: 84515 RVA: 0x0053B75C File Offset: 0x0053995C
			public void __callDele_EventOnSkip()
			{
				this.m_owner.__callDele_EventOnSkip();
			}

			// Token: 0x06014A24 RID: 84516 RVA: 0x0053B76C File Offset: 0x0053996C
			public void __clearDele_EventOnSkip()
			{
				this.m_owner.__clearDele_EventOnSkip();
			}

			// Token: 0x06014A25 RID: 84517 RVA: 0x0053B77C File Offset: 0x0053997C
			public void __callDele_EventOnNext()
			{
				this.m_owner.__callDele_EventOnNext();
			}

			// Token: 0x06014A26 RID: 84518 RVA: 0x0053B78C File Offset: 0x0053998C
			public void __clearDele_EventOnNext()
			{
				this.m_owner.__clearDele_EventOnNext();
			}

			// Token: 0x06014A27 RID: 84519 RVA: 0x0053B79C File Offset: 0x0053999C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06014A28 RID: 84520 RVA: 0x0053B7AC File Offset: 0x005399AC
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003CFF RID: 15615
			// (get) Token: 0x06014A29 RID: 84521 RVA: 0x0053B7BC File Offset: 0x005399BC
			// (set) Token: 0x06014A2A RID: 84522 RVA: 0x0053B7CC File Offset: 0x005399CC
			public Button m_skipButton
			{
				get
				{
					return this.m_owner.m_skipButton;
				}
				set
				{
					this.m_owner.m_skipButton = value;
				}
			}

			// Token: 0x17003D00 RID: 15616
			// (get) Token: 0x06014A2B RID: 84523 RVA: 0x0053B7DC File Offset: 0x005399DC
			// (set) Token: 0x06014A2C RID: 84524 RVA: 0x0053B7EC File Offset: 0x005399EC
			public CommonUIStateController m_backgroundUIStateCtrl
			{
				get
				{
					return this.m_owner.m_backgroundUIStateCtrl;
				}
				set
				{
					this.m_owner.m_backgroundUIStateCtrl = value;
				}
			}

			// Token: 0x17003D01 RID: 15617
			// (get) Token: 0x06014A2D RID: 84525 RVA: 0x0053B7FC File Offset: 0x005399FC
			// (set) Token: 0x06014A2E RID: 84526 RVA: 0x0053B80C File Offset: 0x00539A0C
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17003D02 RID: 15618
			// (get) Token: 0x06014A2F RID: 84527 RVA: 0x0053B81C File Offset: 0x00539A1C
			// (set) Token: 0x06014A30 RID: 84528 RVA: 0x0053B82C File Offset: 0x00539A2C
			public GameObject m_wordsGameObject
			{
				get
				{
					return this.m_owner.m_wordsGameObject;
				}
				set
				{
					this.m_owner.m_wordsGameObject = value;
				}
			}

			// Token: 0x17003D03 RID: 15619
			// (get) Token: 0x06014A31 RID: 84529 RVA: 0x0053B83C File Offset: 0x00539A3C
			// (set) Token: 0x06014A32 RID: 84530 RVA: 0x0053B84C File Offset: 0x00539A4C
			public GameObject m_char0GameObject
			{
				get
				{
					return this.m_owner.m_char0GameObject;
				}
				set
				{
					this.m_owner.m_char0GameObject = value;
				}
			}

			// Token: 0x17003D04 RID: 15620
			// (get) Token: 0x06014A33 RID: 84531 RVA: 0x0053B85C File Offset: 0x00539A5C
			// (set) Token: 0x06014A34 RID: 84532 RVA: 0x0053B86C File Offset: 0x00539A6C
			public GameObject m_char1GameObject
			{
				get
				{
					return this.m_owner.m_char1GameObject;
				}
				set
				{
					this.m_owner.m_char1GameObject = value;
				}
			}

			// Token: 0x17003D05 RID: 15621
			// (get) Token: 0x06014A35 RID: 84533 RVA: 0x0053B87C File Offset: 0x00539A7C
			// (set) Token: 0x06014A36 RID: 84534 RVA: 0x0053B88C File Offset: 0x00539A8C
			public DialogCharUIController[] m_dialogCharUIControllers
			{
				get
				{
					return this.m_owner.m_dialogCharUIControllers;
				}
				set
				{
					this.m_owner.m_dialogCharUIControllers = value;
				}
			}

			// Token: 0x17003D06 RID: 15622
			// (get) Token: 0x06014A37 RID: 84535 RVA: 0x0053B89C File Offset: 0x00539A9C
			// (set) Token: 0x06014A38 RID: 84536 RVA: 0x0053B8AC File Offset: 0x00539AAC
			public UserGuideDialogBoxUIController m_dialogBoxUIController
			{
				get
				{
					return this.m_owner.m_dialogBoxUIController;
				}
				set
				{
					this.m_owner.m_dialogBoxUIController = value;
				}
			}

			// Token: 0x17003D07 RID: 15623
			// (get) Token: 0x06014A39 RID: 84537 RVA: 0x0053B8BC File Offset: 0x00539ABC
			// (set) Token: 0x06014A3A RID: 84538 RVA: 0x0053B8CC File Offset: 0x00539ACC
			public ConfigDataUserGuideDialogInfo m_dialogInfo
			{
				get
				{
					return this.m_owner.m_dialogInfo;
				}
				set
				{
					this.m_owner.m_dialogInfo = value;
				}
			}

			// Token: 0x17003D08 RID: 15624
			// (get) Token: 0x06014A3B RID: 84539 RVA: 0x0053B8DC File Offset: 0x00539ADC
			// (set) Token: 0x06014A3C RID: 84540 RVA: 0x0053B8EC File Offset: 0x00539AEC
			public float m_showDialogBoxTime
			{
				get
				{
					return this.m_owner.m_showDialogBoxTime;
				}
				set
				{
					this.m_owner.m_showDialogBoxTime = value;
				}
			}

			// Token: 0x17003D09 RID: 15625
			// (get) Token: 0x06014A3D RID: 84541 RVA: 0x0053B8FC File Offset: 0x00539AFC
			// (set) Token: 0x06014A3E RID: 84542 RVA: 0x0053B90C File Offset: 0x00539B0C
			public IAudioPlayback m_currentAudio
			{
				get
				{
					return this.m_owner.m_currentAudio;
				}
				set
				{
					this.m_owner.m_currentAudio = value;
				}
			}

			// Token: 0x06014A3F RID: 84543 RVA: 0x0053B91C File Offset: 0x00539B1C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014A40 RID: 84544 RVA: 0x0053B92C File Offset: 0x00539B2C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x06014A41 RID: 84545 RVA: 0x0053B93C File Offset: 0x00539B3C
			public IEnumerator Co_CloseDialog()
			{
				return this.m_owner.Co_CloseDialog();
			}

			// Token: 0x06014A42 RID: 84546 RVA: 0x0053B94C File Offset: 0x00539B4C
			public void ShowDialogBox()
			{
				this.m_owner.ShowDialogBox();
			}

			// Token: 0x06014A43 RID: 84547 RVA: 0x0053B95C File Offset: 0x00539B5C
			public IAudioPlayback PlayVoice(string name)
			{
				return this.m_owner.PlayVoice(name);
			}

			// Token: 0x06014A44 RID: 84548 RVA: 0x0053B96C File Offset: 0x00539B6C
			public void StopVoice()
			{
				this.m_owner.StopVoice();
			}

			// Token: 0x06014A45 RID: 84549 RVA: 0x0053B97C File Offset: 0x00539B7C
			public IEnumerator Co_NextDialog()
			{
				return this.m_owner.Co_NextDialog();
			}

			// Token: 0x06014A46 RID: 84550 RVA: 0x0053B98C File Offset: 0x00539B8C
			public void OnSkipButtonClick()
			{
				this.m_owner.OnSkipButtonClick();
			}

			// Token: 0x06014A47 RID: 84551 RVA: 0x0053B99C File Offset: 0x00539B9C
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0400B524 RID: 46372
			private UserGuideDialogUIController m_owner;
		}
	}
}
