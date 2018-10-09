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
	// Token: 0x02000A6D RID: 2669
	[HotFix]
	public class BattleDialogUIController : UIControllerBase
	{
		// Token: 0x0600A75C RID: 42844 RVA: 0x002ED968 File Offset: 0x002EBB68
		private BattleDialogUIController()
		{
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x002ED97C File Offset: 0x002EBB7C
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
			this.m_dialogBoxUIController = GameObjectUtility.AddControllerToGameObject<BattleDialogBoxUIController>(this.m_wordsGameObject);
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x002EDA54 File Offset: 0x002EBC54
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
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			if (this.m_showDialogBoxTime > 0f)
			{
				this.m_showDialogBoxTime -= unscaledDeltaTime;
				if (this.m_showDialogBoxTime <= 0f)
				{
					this.m_showDialogBoxTime = 0f;
					this.ShowDialogBox();
				}
			}
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x002EDAFC File Offset: 0x002EBCFC
		public void SetDialog(ConfigDataBattleDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDialogConfigDataBattleDialogInfo_hotfix != null)
			{
				this.m_SetDialogConfigDataBattleDialogInfo_hotfix.call(new object[]
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
			this.m_skipButton.gameObject.SetActive(true);
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

		// Token: 0x0600A760 RID: 42848 RVA: 0x002EDD0C File Offset: 0x002EBF0C
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

		// Token: 0x0600A761 RID: 42849 RVA: 0x002EDD7C File Offset: 0x002EBF7C
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
			BattleDialogUIController.<Co_CloseDialog>c__Iterator0 <Co_CloseDialog>c__Iterator = new BattleDialogUIController.<Co_CloseDialog>c__Iterator0();
			<Co_CloseDialog>c__Iterator.$this = this;
			return <Co_CloseDialog>c__Iterator;
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x002EDDF8 File Offset: 0x002EBFF8
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

		// Token: 0x0600A763 RID: 42851 RVA: 0x002EDF48 File Offset: 0x002EC148
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

		// Token: 0x0600A764 RID: 42852 RVA: 0x002EDFCC File Offset: 0x002EC1CC
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

		// Token: 0x0600A765 RID: 42853 RVA: 0x002EE060 File Offset: 0x002EC260
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
			BattleDialogUIController.<Co_NextDialog>c__Iterator1 <Co_NextDialog>c__Iterator = new BattleDialogUIController.<Co_NextDialog>c__Iterator1();
			<Co_NextDialog>c__Iterator.$this = this;
			return <Co_NextDialog>c__Iterator;
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x002EE0DC File Offset: 0x002EC2DC
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

		// Token: 0x0600A767 RID: 42855 RVA: 0x002EE154 File Offset: 0x002EC354
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

		// Token: 0x140001EF RID: 495
		// (add) Token: 0x0600A768 RID: 42856 RVA: 0x002EE1E4 File Offset: 0x002EC3E4
		// (remove) Token: 0x0600A769 RID: 42857 RVA: 0x002EE280 File Offset: 0x002EC480
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

		// Token: 0x140001F0 RID: 496
		// (add) Token: 0x0600A76A RID: 42858 RVA: 0x002EE31C File Offset: 0x002EC51C
		// (remove) Token: 0x0600A76B RID: 42859 RVA: 0x002EE3B8 File Offset: 0x002EC5B8
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

		// Token: 0x140001F1 RID: 497
		// (add) Token: 0x0600A76C RID: 42860 RVA: 0x002EE454 File Offset: 0x002EC654
		// (remove) Token: 0x0600A76D RID: 42861 RVA: 0x002EE4F0 File Offset: 0x002EC6F0
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

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x0600A76E RID: 42862 RVA: 0x002EE58C File Offset: 0x002EC78C
		// (set) Token: 0x0600A76F RID: 42863 RVA: 0x002EE5AC File Offset: 0x002EC7AC
		[DoNotToLua]
		public new BattleDialogUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleDialogUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x002EE5B8 File Offset: 0x002EC7B8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x002EE5C4 File Offset: 0x002EC7C4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x002EE5CC File Offset: 0x002EC7CC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x002EE5D4 File Offset: 0x002EC7D4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x002EE5E8 File Offset: 0x002EC7E8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x002EE5F0 File Offset: 0x002EC7F0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x002EE5FC File Offset: 0x002EC7FC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x002EE608 File Offset: 0x002EC808
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x002EE614 File Offset: 0x002EC814
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x002EE620 File Offset: 0x002EC820
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x002EE62C File Offset: 0x002EC82C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x002EE638 File Offset: 0x002EC838
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x002EE644 File Offset: 0x002EC844
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x002EE650 File Offset: 0x002EC850
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x002EE65C File Offset: 0x002EC85C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x002EE664 File Offset: 0x002EC864
		private void __callDele_EventOnSkip()
		{
			Action eventOnSkip = this.EventOnSkip;
			if (eventOnSkip != null)
			{
				eventOnSkip();
			}
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x002EE684 File Offset: 0x002EC884
		private void __clearDele_EventOnSkip()
		{
			this.EventOnSkip = null;
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x002EE690 File Offset: 0x002EC890
		private void __callDele_EventOnNext()
		{
			Action eventOnNext = this.EventOnNext;
			if (eventOnNext != null)
			{
				eventOnNext();
			}
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x002EE6B0 File Offset: 0x002EC8B0
		private void __clearDele_EventOnNext()
		{
			this.EventOnNext = null;
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x002EE6BC File Offset: 0x002EC8BC
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x002EE6DC File Offset: 0x002EC8DC
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x002EE6E8 File Offset: 0x002EC8E8
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
					this.m_SetDialogConfigDataBattleDialogInfo_hotfix = (luaObj.RawGet("SetDialog") as LuaFunction);
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

		// Token: 0x0600A786 RID: 42886 RVA: 0x002EE944 File Offset: 0x002ECB44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleDialogUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006ED4 RID: 28372
		[AutoBind("./SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skipButton;

		// Token: 0x04006ED5 RID: 28373
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04006ED6 RID: 28374
		[AutoBind("./WordPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_wordsGameObject;

		// Token: 0x04006ED7 RID: 28375
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char0GameObject;

		// Token: 0x04006ED8 RID: 28376
		[AutoBind("./Char/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char1GameObject;

		// Token: 0x04006ED9 RID: 28377
		private DialogCharUIController[] m_dialogCharUIControllers = new DialogCharUIController[2];

		// Token: 0x04006EDA RID: 28378
		private BattleDialogBoxUIController m_dialogBoxUIController;

		// Token: 0x04006EDB RID: 28379
		private IAudioPlayback m_currentAudio;

		// Token: 0x04006EDC RID: 28380
		private ConfigDataBattleDialogInfo m_dialogInfo;

		// Token: 0x04006EDD RID: 28381
		private float m_showDialogBoxTime;

		// Token: 0x04006EDE RID: 28382
		[DoNotToLua]
		private BattleDialogUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006EDF RID: 28383
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006EE0 RID: 28384
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006EE1 RID: 28385
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006EE2 RID: 28386
		private LuaFunction m_Update_hotfix;

		// Token: 0x04006EE3 RID: 28387
		private LuaFunction m_SetDialogConfigDataBattleDialogInfo_hotfix;

		// Token: 0x04006EE4 RID: 28388
		private LuaFunction m_CloseDialog_hotfix;

		// Token: 0x04006EE5 RID: 28389
		private LuaFunction m_Co_CloseDialog_hotfix;

		// Token: 0x04006EE6 RID: 28390
		private LuaFunction m_ShowDialogBox_hotfix;

		// Token: 0x04006EE7 RID: 28391
		private LuaFunction m_PlayVoiceString_hotfix;

		// Token: 0x04006EE8 RID: 28392
		private LuaFunction m_StopVoice_hotfix;

		// Token: 0x04006EE9 RID: 28393
		private LuaFunction m_Co_NextDialog_hotfix;

		// Token: 0x04006EEA RID: 28394
		private LuaFunction m_OnSkipButtonClick_hotfix;

		// Token: 0x04006EEB RID: 28395
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04006EEC RID: 28396
		private LuaFunction m_add_EventOnSkipAction_hotfix;

		// Token: 0x04006EED RID: 28397
		private LuaFunction m_remove_EventOnSkipAction_hotfix;

		// Token: 0x04006EEE RID: 28398
		private LuaFunction m_add_EventOnNextAction_hotfix;

		// Token: 0x04006EEF RID: 28399
		private LuaFunction m_remove_EventOnNextAction_hotfix;

		// Token: 0x04006EF0 RID: 28400
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04006EF1 RID: 28401
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000A6E RID: 2670
		public new class LuaExportHelper
		{
			// Token: 0x0600A787 RID: 42887 RVA: 0x002EE9AC File Offset: 0x002ECBAC
			public LuaExportHelper(BattleDialogUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A788 RID: 42888 RVA: 0x002EE9BC File Offset: 0x002ECBBC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A789 RID: 42889 RVA: 0x002EE9CC File Offset: 0x002ECBCC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A78A RID: 42890 RVA: 0x002EE9DC File Offset: 0x002ECBDC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A78B RID: 42891 RVA: 0x002EE9EC File Offset: 0x002ECBEC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A78C RID: 42892 RVA: 0x002EEA04 File Offset: 0x002ECC04
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A78D RID: 42893 RVA: 0x002EEA14 File Offset: 0x002ECC14
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A78E RID: 42894 RVA: 0x002EEA24 File Offset: 0x002ECC24
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A78F RID: 42895 RVA: 0x002EEA34 File Offset: 0x002ECC34
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A790 RID: 42896 RVA: 0x002EEA44 File Offset: 0x002ECC44
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A791 RID: 42897 RVA: 0x002EEA54 File Offset: 0x002ECC54
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A792 RID: 42898 RVA: 0x002EEA64 File Offset: 0x002ECC64
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A793 RID: 42899 RVA: 0x002EEA74 File Offset: 0x002ECC74
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A794 RID: 42900 RVA: 0x002EEA84 File Offset: 0x002ECC84
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A795 RID: 42901 RVA: 0x002EEA94 File Offset: 0x002ECC94
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A796 RID: 42902 RVA: 0x002EEAA4 File Offset: 0x002ECCA4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600A797 RID: 42903 RVA: 0x002EEAB4 File Offset: 0x002ECCB4
			public void __callDele_EventOnSkip()
			{
				this.m_owner.__callDele_EventOnSkip();
			}

			// Token: 0x0600A798 RID: 42904 RVA: 0x002EEAC4 File Offset: 0x002ECCC4
			public void __clearDele_EventOnSkip()
			{
				this.m_owner.__clearDele_EventOnSkip();
			}

			// Token: 0x0600A799 RID: 42905 RVA: 0x002EEAD4 File Offset: 0x002ECCD4
			public void __callDele_EventOnNext()
			{
				this.m_owner.__callDele_EventOnNext();
			}

			// Token: 0x0600A79A RID: 42906 RVA: 0x002EEAE4 File Offset: 0x002ECCE4
			public void __clearDele_EventOnNext()
			{
				this.m_owner.__clearDele_EventOnNext();
			}

			// Token: 0x0600A79B RID: 42907 RVA: 0x002EEAF4 File Offset: 0x002ECCF4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600A79C RID: 42908 RVA: 0x002EEB04 File Offset: 0x002ECD04
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170021FF RID: 8703
			// (get) Token: 0x0600A79D RID: 42909 RVA: 0x002EEB14 File Offset: 0x002ECD14
			// (set) Token: 0x0600A79E RID: 42910 RVA: 0x002EEB24 File Offset: 0x002ECD24
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

			// Token: 0x17002200 RID: 8704
			// (get) Token: 0x0600A79F RID: 42911 RVA: 0x002EEB34 File Offset: 0x002ECD34
			// (set) Token: 0x0600A7A0 RID: 42912 RVA: 0x002EEB44 File Offset: 0x002ECD44
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

			// Token: 0x17002201 RID: 8705
			// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x002EEB54 File Offset: 0x002ECD54
			// (set) Token: 0x0600A7A2 RID: 42914 RVA: 0x002EEB64 File Offset: 0x002ECD64
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

			// Token: 0x17002202 RID: 8706
			// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x002EEB74 File Offset: 0x002ECD74
			// (set) Token: 0x0600A7A4 RID: 42916 RVA: 0x002EEB84 File Offset: 0x002ECD84
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

			// Token: 0x17002203 RID: 8707
			// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x002EEB94 File Offset: 0x002ECD94
			// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x002EEBA4 File Offset: 0x002ECDA4
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

			// Token: 0x17002204 RID: 8708
			// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x002EEBB4 File Offset: 0x002ECDB4
			// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x002EEBC4 File Offset: 0x002ECDC4
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

			// Token: 0x17002205 RID: 8709
			// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x002EEBD4 File Offset: 0x002ECDD4
			// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x002EEBE4 File Offset: 0x002ECDE4
			public BattleDialogBoxUIController m_dialogBoxUIController
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

			// Token: 0x17002206 RID: 8710
			// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x002EEBF4 File Offset: 0x002ECDF4
			// (set) Token: 0x0600A7AC RID: 42924 RVA: 0x002EEC04 File Offset: 0x002ECE04
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

			// Token: 0x17002207 RID: 8711
			// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002EEC14 File Offset: 0x002ECE14
			// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x002EEC24 File Offset: 0x002ECE24
			public ConfigDataBattleDialogInfo m_dialogInfo
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

			// Token: 0x17002208 RID: 8712
			// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x002EEC34 File Offset: 0x002ECE34
			// (set) Token: 0x0600A7B0 RID: 42928 RVA: 0x002EEC44 File Offset: 0x002ECE44
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

			// Token: 0x0600A7B1 RID: 42929 RVA: 0x002EEC54 File Offset: 0x002ECE54
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A7B2 RID: 42930 RVA: 0x002EEC64 File Offset: 0x002ECE64
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600A7B3 RID: 42931 RVA: 0x002EEC74 File Offset: 0x002ECE74
			public IEnumerator Co_CloseDialog()
			{
				return this.m_owner.Co_CloseDialog();
			}

			// Token: 0x0600A7B4 RID: 42932 RVA: 0x002EEC84 File Offset: 0x002ECE84
			public void ShowDialogBox()
			{
				this.m_owner.ShowDialogBox();
			}

			// Token: 0x0600A7B5 RID: 42933 RVA: 0x002EEC94 File Offset: 0x002ECE94
			public IAudioPlayback PlayVoice(string name)
			{
				return this.m_owner.PlayVoice(name);
			}

			// Token: 0x0600A7B6 RID: 42934 RVA: 0x002EECA4 File Offset: 0x002ECEA4
			public void StopVoice()
			{
				this.m_owner.StopVoice();
			}

			// Token: 0x0600A7B7 RID: 42935 RVA: 0x002EECB4 File Offset: 0x002ECEB4
			public IEnumerator Co_NextDialog()
			{
				return this.m_owner.Co_NextDialog();
			}

			// Token: 0x0600A7B8 RID: 42936 RVA: 0x002EECC4 File Offset: 0x002ECEC4
			public void OnSkipButtonClick()
			{
				this.m_owner.OnSkipButtonClick();
			}

			// Token: 0x0600A7B9 RID: 42937 RVA: 0x002EECD4 File Offset: 0x002ECED4
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04006EF2 RID: 28402
			private BattleDialogUIController m_owner;
		}
	}
}
