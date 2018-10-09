using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Art;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ACE RID: 2766
	[HotFix]
	public class BattleTreasureDialogUIController : UIControllerBase
	{
		// Token: 0x0600B434 RID: 46132 RVA: 0x0031BE8C File Offset: 0x0031A08C
		private BattleTreasureDialogUIController()
		{
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x0031BE94 File Offset: 0x0031A094
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x0031BF18 File Offset: 0x0031A118
		public void Open(Action onFinished = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenAction_hotfix != null)
			{
				this.m_OpenAction_hotfix.call(new object[]
				{
					this,
					onFinished
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", onFinished, false, true);
		}

		// Token: 0x0600B437 RID: 46135 RVA: 0x0031BF9C File Offset: 0x0031A19C
		public void Close(Action onFinished = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onFinished
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", onFinished, false, true);
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x0031C020 File Offset: 0x0031A220
		public void SetWords(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWordsString_hotfix != null)
			{
				this.m_SetWordsString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_text.text = txt;
			this.m_text.SetDisplayCharacterCount(0);
			this.m_time = 0f;
			this.m_wordsDisplayLength = 0;
			this.m_wordsDisplayLengthMax = this.m_text.GetDisplayCharacterCountMax(txt);
			this.m_waitGameObject.SetActive(false);
		}

		// Token: 0x0600B439 RID: 46137 RVA: 0x0031C0D8 File Offset: 0x0031A2D8
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
			this.m_time += Time.unscaledDeltaTime;
			int num = (int)(this.m_time * 30f);
			if (num > this.m_wordsDisplayLengthMax)
			{
				num = this.m_wordsDisplayLengthMax;
			}
			if (num != this.m_wordsDisplayLength)
			{
				this.m_wordsDisplayLength = num;
				this.m_text.SetDisplayCharacterCount(num);
				if (num >= this.m_wordsDisplayLengthMax)
				{
					this.m_waitGameObject.SetActive(true);
				}
			}
		}

		// Token: 0x0600B43A RID: 46138 RVA: 0x0031C1A4 File Offset: 0x0031A3A4
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
			this.Close(delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			});
		}

		// Token: 0x14000225 RID: 549
		// (add) Token: 0x0600B43B RID: 46139 RVA: 0x0031C218 File Offset: 0x0031A418
		// (remove) Token: 0x0600B43C RID: 46140 RVA: 0x0031C2B4 File Offset: 0x0031A4B4
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

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600B43D RID: 46141 RVA: 0x0031C350 File Offset: 0x0031A550
		// (set) Token: 0x0600B43E RID: 46142 RVA: 0x0031C370 File Offset: 0x0031A570
		[DoNotToLua]
		public new BattleTreasureDialogUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleTreasureDialogUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x0031C37C File Offset: 0x0031A57C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B440 RID: 46144 RVA: 0x0031C388 File Offset: 0x0031A588
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x0031C390 File Offset: 0x0031A590
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B442 RID: 46146 RVA: 0x0031C398 File Offset: 0x0031A598
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x0031C3AC File Offset: 0x0031A5AC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x0031C3B4 File Offset: 0x0031A5B4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x0031C3C0 File Offset: 0x0031A5C0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x0031C3CC File Offset: 0x0031A5CC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x0031C3D8 File Offset: 0x0031A5D8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x0031C3E4 File Offset: 0x0031A5E4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x0031C3F0 File Offset: 0x0031A5F0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x0031C3FC File Offset: 0x0031A5FC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x0031C408 File Offset: 0x0031A608
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B44C RID: 46156 RVA: 0x0031C414 File Offset: 0x0031A614
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x0031C420 File Offset: 0x0031A620
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x0031C428 File Offset: 0x0031A628
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600B44F RID: 46159 RVA: 0x0031C448 File Offset: 0x0031A648
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x0031C46C File Offset: 0x0031A66C
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
					this.m_OpenAction_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetWordsString_hotfix = (luaObj.RawGet("SetWords") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B452 RID: 46162 RVA: 0x0031C5E8 File Offset: 0x0031A7E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTreasureDialogUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040074AB RID: 29867
		private const int WordsSpeed = 30;

		// Token: 0x040074AC RID: 29868
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x040074AD RID: 29869
		[AutoBind("./WordPanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private DialogText m_text;

		// Token: 0x040074AE RID: 29870
		[AutoBind("./WordPanel/PenGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitGameObject;

		// Token: 0x040074AF RID: 29871
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x040074B0 RID: 29872
		private float m_time;

		// Token: 0x040074B1 RID: 29873
		private int m_wordsDisplayLength;

		// Token: 0x040074B2 RID: 29874
		private int m_wordsDisplayLengthMax;

		// Token: 0x040074B3 RID: 29875
		[DoNotToLua]
		private BattleTreasureDialogUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040074B4 RID: 29876
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040074B5 RID: 29877
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040074B6 RID: 29878
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040074B7 RID: 29879
		private LuaFunction m_OpenAction_hotfix;

		// Token: 0x040074B8 RID: 29880
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x040074B9 RID: 29881
		private LuaFunction m_SetWordsString_hotfix;

		// Token: 0x040074BA RID: 29882
		private LuaFunction m_Update_hotfix;

		// Token: 0x040074BB RID: 29883
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x040074BC RID: 29884
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040074BD RID: 29885
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000ACF RID: 2767
		public new class LuaExportHelper
		{
			// Token: 0x0600B453 RID: 46163 RVA: 0x0031C650 File Offset: 0x0031A850
			public LuaExportHelper(BattleTreasureDialogUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B454 RID: 46164 RVA: 0x0031C660 File Offset: 0x0031A860
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B455 RID: 46165 RVA: 0x0031C670 File Offset: 0x0031A870
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B456 RID: 46166 RVA: 0x0031C680 File Offset: 0x0031A880
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B457 RID: 46167 RVA: 0x0031C690 File Offset: 0x0031A890
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B458 RID: 46168 RVA: 0x0031C6A8 File Offset: 0x0031A8A8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B459 RID: 46169 RVA: 0x0031C6B8 File Offset: 0x0031A8B8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B45A RID: 46170 RVA: 0x0031C6C8 File Offset: 0x0031A8C8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B45B RID: 46171 RVA: 0x0031C6D8 File Offset: 0x0031A8D8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B45C RID: 46172 RVA: 0x0031C6E8 File Offset: 0x0031A8E8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B45D RID: 46173 RVA: 0x0031C6F8 File Offset: 0x0031A8F8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B45E RID: 46174 RVA: 0x0031C708 File Offset: 0x0031A908
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B45F RID: 46175 RVA: 0x0031C718 File Offset: 0x0031A918
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B460 RID: 46176 RVA: 0x0031C728 File Offset: 0x0031A928
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B461 RID: 46177 RVA: 0x0031C738 File Offset: 0x0031A938
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B462 RID: 46178 RVA: 0x0031C748 File Offset: 0x0031A948
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600B463 RID: 46179 RVA: 0x0031C758 File Offset: 0x0031A958
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600B464 RID: 46180 RVA: 0x0031C768 File Offset: 0x0031A968
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700247C RID: 9340
			// (get) Token: 0x0600B465 RID: 46181 RVA: 0x0031C778 File Offset: 0x0031A978
			public static int WordsSpeed
			{
				get
				{
					return 30;
				}
			}

			// Token: 0x1700247D RID: 9341
			// (get) Token: 0x0600B466 RID: 46182 RVA: 0x0031C77C File Offset: 0x0031A97C
			// (set) Token: 0x0600B467 RID: 46183 RVA: 0x0031C78C File Offset: 0x0031A98C
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

			// Token: 0x1700247E RID: 9342
			// (get) Token: 0x0600B468 RID: 46184 RVA: 0x0031C79C File Offset: 0x0031A99C
			// (set) Token: 0x0600B469 RID: 46185 RVA: 0x0031C7AC File Offset: 0x0031A9AC
			public DialogText m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x1700247F RID: 9343
			// (get) Token: 0x0600B46A RID: 46186 RVA: 0x0031C7BC File Offset: 0x0031A9BC
			// (set) Token: 0x0600B46B RID: 46187 RVA: 0x0031C7CC File Offset: 0x0031A9CC
			public GameObject m_waitGameObject
			{
				get
				{
					return this.m_owner.m_waitGameObject;
				}
				set
				{
					this.m_owner.m_waitGameObject = value;
				}
			}

			// Token: 0x17002480 RID: 9344
			// (get) Token: 0x0600B46C RID: 46188 RVA: 0x0031C7DC File Offset: 0x0031A9DC
			// (set) Token: 0x0600B46D RID: 46189 RVA: 0x0031C7EC File Offset: 0x0031A9EC
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

			// Token: 0x17002481 RID: 9345
			// (get) Token: 0x0600B46E RID: 46190 RVA: 0x0031C7FC File Offset: 0x0031A9FC
			// (set) Token: 0x0600B46F RID: 46191 RVA: 0x0031C80C File Offset: 0x0031AA0C
			public float m_time
			{
				get
				{
					return this.m_owner.m_time;
				}
				set
				{
					this.m_owner.m_time = value;
				}
			}

			// Token: 0x17002482 RID: 9346
			// (get) Token: 0x0600B470 RID: 46192 RVA: 0x0031C81C File Offset: 0x0031AA1C
			// (set) Token: 0x0600B471 RID: 46193 RVA: 0x0031C82C File Offset: 0x0031AA2C
			public int m_wordsDisplayLength
			{
				get
				{
					return this.m_owner.m_wordsDisplayLength;
				}
				set
				{
					this.m_owner.m_wordsDisplayLength = value;
				}
			}

			// Token: 0x17002483 RID: 9347
			// (get) Token: 0x0600B472 RID: 46194 RVA: 0x0031C83C File Offset: 0x0031AA3C
			// (set) Token: 0x0600B473 RID: 46195 RVA: 0x0031C84C File Offset: 0x0031AA4C
			public int m_wordsDisplayLengthMax
			{
				get
				{
					return this.m_owner.m_wordsDisplayLengthMax;
				}
				set
				{
					this.m_owner.m_wordsDisplayLengthMax = value;
				}
			}

			// Token: 0x0600B474 RID: 46196 RVA: 0x0031C85C File Offset: 0x0031AA5C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B475 RID: 46197 RVA: 0x0031C86C File Offset: 0x0031AA6C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0600B476 RID: 46198 RVA: 0x0031C87C File Offset: 0x0031AA7C
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x040074BE RID: 29886
			private BattleTreasureDialogUIController m_owner;
		}
	}
}
