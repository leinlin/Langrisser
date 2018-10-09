using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BDC RID: 3036
	[HotFix]
	public class PlayerLevelUpUIController : UIControllerBase
	{
		// Token: 0x0600D1CE RID: 53710 RVA: 0x00395ED4 File Offset: 0x003940D4
		private PlayerLevelUpUIController()
		{
		}

		// Token: 0x0600D1CF RID: 53711 RVA: 0x00395EDC File Offset: 0x003940DC
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

		// Token: 0x0600D1D0 RID: 53712 RVA: 0x00395F60 File Offset: 0x00394160
		public void ShowPlayerLevelUp(int oldLevel, int newLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerLevelUpInt32Int32_hotfix != null)
			{
				this.m_ShowPlayerLevelUpInt32Int32_hotfix.call(new object[]
				{
					this,
					oldLevel,
					newLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_Open(oldLevel, newLevel));
		}

		// Token: 0x0600D1D1 RID: 53713 RVA: 0x00395FF0 File Offset: 0x003941F0
		[DebuggerHidden]
		private IEnumerator Co_Open(int oldLevel, int newLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_OpenInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_OpenInt32Int32_hotfix.call(new object[]
				{
					this,
					oldLevel,
					newLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerLevelUpUIController.<Co_Open>c__Iterator0 <Co_Open>c__Iterator = new PlayerLevelUpUIController.<Co_Open>c__Iterator0();
			<Co_Open>c__Iterator.oldLevel = oldLevel;
			<Co_Open>c__Iterator.newLevel = newLevel;
			<Co_Open>c__Iterator.$this = this;
			return <Co_Open>c__Iterator;
		}

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x00396098 File Offset: 0x00394298
		[DebuggerHidden]
		private IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix.call(new object[]
				{
					this,
					ctrl,
					state
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerLevelUpUIController.<Co_SetAndWaitUIState>c__Iterator1 <Co_SetAndWaitUIState>c__Iterator = new PlayerLevelUpUIController.<Co_SetAndWaitUIState>c__Iterator1();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x0039613C File Offset: 0x0039433C
		[DebuggerHidden]
		private IEnumerator Co_WaitClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitClick_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitClick_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerLevelUpUIController.<Co_WaitClick>c__Iterator2 <Co_WaitClick>c__Iterator = new PlayerLevelUpUIController.<Co_WaitClick>c__Iterator2();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x003961B8 File Offset: 0x003943B8
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
			this.m_isClick = true;
		}

		// Token: 0x14000288 RID: 648
		// (add) Token: 0x0600D1D5 RID: 53717 RVA: 0x00396220 File Offset: 0x00394420
		// (remove) Token: 0x0600D1D6 RID: 53718 RVA: 0x003962BC File Offset: 0x003944BC
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

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600D1D7 RID: 53719 RVA: 0x00396358 File Offset: 0x00394558
		// (set) Token: 0x0600D1D8 RID: 53720 RVA: 0x00396378 File Offset: 0x00394578
		[DoNotToLua]
		public new PlayerLevelUpUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerLevelUpUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x00396384 File Offset: 0x00394584
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x00396390 File Offset: 0x00394590
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x00396398 File Offset: 0x00394598
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x003963A0 File Offset: 0x003945A0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x003963B4 File Offset: 0x003945B4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x003963BC File Offset: 0x003945BC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x003963C8 File Offset: 0x003945C8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x003963D4 File Offset: 0x003945D4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x003963E0 File Offset: 0x003945E0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x003963EC File Offset: 0x003945EC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x003963F8 File Offset: 0x003945F8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x00396404 File Offset: 0x00394604
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x00396410 File Offset: 0x00394610
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x0039641C File Offset: 0x0039461C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x00396428 File Offset: 0x00394628
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x00396430 File Offset: 0x00394630
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x00396450 File Offset: 0x00394650
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x0039645C File Offset: 0x0039465C
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
					this.m_ShowPlayerLevelUpInt32Int32_hotfix = (luaObj.RawGet("ShowPlayerLevelUp") as LuaFunction);
					this.m_Co_OpenInt32Int32_hotfix = (luaObj.RawGet("Co_Open") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x003965D8 File Offset: 0x003947D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerLevelUpUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400823C RID: 33340
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400823D RID: 33341
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400823E RID: 33342
		[AutoBind("./LevelUpInfo/LevelGroup/FromValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_oldLevelText;

		// Token: 0x0400823F RID: 33343
		[AutoBind("./LevelUpInfo/LevelGroup/AfterValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_newLevelText;

		// Token: 0x04008240 RID: 33344
		[AutoBind("./LevelUpInfo/HeroLevelText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addHeroLevelText;

		// Token: 0x04008241 RID: 33345
		[AutoBind("./LevelUpInfo/APLevelText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_addEnergyText;

		// Token: 0x04008242 RID: 33346
		private bool m_isClick;

		// Token: 0x04008243 RID: 33347
		[DoNotToLua]
		private PlayerLevelUpUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008244 RID: 33348
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008245 RID: 33349
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008246 RID: 33350
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008247 RID: 33351
		private LuaFunction m_ShowPlayerLevelUpInt32Int32_hotfix;

		// Token: 0x04008248 RID: 33352
		private LuaFunction m_Co_OpenInt32Int32_hotfix;

		// Token: 0x04008249 RID: 33353
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x0400824A RID: 33354
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x0400824B RID: 33355
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400824C RID: 33356
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400824D RID: 33357
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000BDD RID: 3037
		public new class LuaExportHelper
		{
			// Token: 0x0600D1EC RID: 53740 RVA: 0x00396640 File Offset: 0x00394840
			public LuaExportHelper(PlayerLevelUpUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D1ED RID: 53741 RVA: 0x00396650 File Offset: 0x00394850
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D1EE RID: 53742 RVA: 0x00396660 File Offset: 0x00394860
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D1EF RID: 53743 RVA: 0x00396670 File Offset: 0x00394870
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D1F0 RID: 53744 RVA: 0x00396680 File Offset: 0x00394880
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D1F1 RID: 53745 RVA: 0x00396698 File Offset: 0x00394898
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D1F2 RID: 53746 RVA: 0x003966A8 File Offset: 0x003948A8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D1F3 RID: 53747 RVA: 0x003966B8 File Offset: 0x003948B8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D1F4 RID: 53748 RVA: 0x003966C8 File Offset: 0x003948C8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D1F5 RID: 53749 RVA: 0x003966D8 File Offset: 0x003948D8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D1F6 RID: 53750 RVA: 0x003966E8 File Offset: 0x003948E8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D1F7 RID: 53751 RVA: 0x003966F8 File Offset: 0x003948F8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D1F8 RID: 53752 RVA: 0x00396708 File Offset: 0x00394908
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D1F9 RID: 53753 RVA: 0x00396718 File Offset: 0x00394918
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D1FA RID: 53754 RVA: 0x00396728 File Offset: 0x00394928
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D1FB RID: 53755 RVA: 0x00396738 File Offset: 0x00394938
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D1FC RID: 53756 RVA: 0x00396748 File Offset: 0x00394948
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D1FD RID: 53757 RVA: 0x00396758 File Offset: 0x00394958
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700293E RID: 10558
			// (get) Token: 0x0600D1FE RID: 53758 RVA: 0x00396768 File Offset: 0x00394968
			// (set) Token: 0x0600D1FF RID: 53759 RVA: 0x00396778 File Offset: 0x00394978
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

			// Token: 0x1700293F RID: 10559
			// (get) Token: 0x0600D200 RID: 53760 RVA: 0x00396788 File Offset: 0x00394988
			// (set) Token: 0x0600D201 RID: 53761 RVA: 0x00396798 File Offset: 0x00394998
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

			// Token: 0x17002940 RID: 10560
			// (get) Token: 0x0600D202 RID: 53762 RVA: 0x003967A8 File Offset: 0x003949A8
			// (set) Token: 0x0600D203 RID: 53763 RVA: 0x003967B8 File Offset: 0x003949B8
			public Text m_oldLevelText
			{
				get
				{
					return this.m_owner.m_oldLevelText;
				}
				set
				{
					this.m_owner.m_oldLevelText = value;
				}
			}

			// Token: 0x17002941 RID: 10561
			// (get) Token: 0x0600D204 RID: 53764 RVA: 0x003967C8 File Offset: 0x003949C8
			// (set) Token: 0x0600D205 RID: 53765 RVA: 0x003967D8 File Offset: 0x003949D8
			public Text m_newLevelText
			{
				get
				{
					return this.m_owner.m_newLevelText;
				}
				set
				{
					this.m_owner.m_newLevelText = value;
				}
			}

			// Token: 0x17002942 RID: 10562
			// (get) Token: 0x0600D206 RID: 53766 RVA: 0x003967E8 File Offset: 0x003949E8
			// (set) Token: 0x0600D207 RID: 53767 RVA: 0x003967F8 File Offset: 0x003949F8
			public Text m_addHeroLevelText
			{
				get
				{
					return this.m_owner.m_addHeroLevelText;
				}
				set
				{
					this.m_owner.m_addHeroLevelText = value;
				}
			}

			// Token: 0x17002943 RID: 10563
			// (get) Token: 0x0600D208 RID: 53768 RVA: 0x00396808 File Offset: 0x00394A08
			// (set) Token: 0x0600D209 RID: 53769 RVA: 0x00396818 File Offset: 0x00394A18
			public Text m_addEnergyText
			{
				get
				{
					return this.m_owner.m_addEnergyText;
				}
				set
				{
					this.m_owner.m_addEnergyText = value;
				}
			}

			// Token: 0x17002944 RID: 10564
			// (get) Token: 0x0600D20A RID: 53770 RVA: 0x00396828 File Offset: 0x00394A28
			// (set) Token: 0x0600D20B RID: 53771 RVA: 0x00396838 File Offset: 0x00394A38
			public bool m_isClick
			{
				get
				{
					return this.m_owner.m_isClick;
				}
				set
				{
					this.m_owner.m_isClick = value;
				}
			}

			// Token: 0x0600D20C RID: 53772 RVA: 0x00396848 File Offset: 0x00394A48
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D20D RID: 53773 RVA: 0x00396858 File Offset: 0x00394A58
			public IEnumerator Co_Open(int oldLevel, int newLevel)
			{
				return this.m_owner.Co_Open(oldLevel, newLevel);
			}

			// Token: 0x0600D20E RID: 53774 RVA: 0x00396868 File Offset: 0x00394A68
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0600D20F RID: 53775 RVA: 0x00396878 File Offset: 0x00394A78
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0600D210 RID: 53776 RVA: 0x00396888 File Offset: 0x00394A88
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0400824E RID: 33358
			private PlayerLevelUpUIController m_owner;
		}
	}
}
