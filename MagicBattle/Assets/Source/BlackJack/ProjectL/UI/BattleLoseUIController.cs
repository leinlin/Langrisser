using System;
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
	// Token: 0x02000A76 RID: 2678
	[HotFix]
	public class BattleLoseUIController : UIControllerBase
	{
		// Token: 0x0600A878 RID: 43128 RVA: 0x002F1060 File Offset: 0x002EF260
		private BattleLoseUIController()
		{
		}

		// Token: 0x0600A879 RID: 43129 RVA: 0x002F1068 File Offset: 0x002EF268
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

		// Token: 0x0600A87A RID: 43130 RVA: 0x002F10EC File Offset: 0x002EF2EC
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
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x140001F4 RID: 500
		// (add) Token: 0x0600A87B RID: 43131 RVA: 0x002F1164 File Offset: 0x002EF364
		// (remove) Token: 0x0600A87C RID: 43132 RVA: 0x002F1200 File Offset: 0x002EF400
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

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600A87D RID: 43133 RVA: 0x002F129C File Offset: 0x002EF49C
		// (set) Token: 0x0600A87E RID: 43134 RVA: 0x002F12BC File Offset: 0x002EF4BC
		[DoNotToLua]
		public new BattleLoseUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleLoseUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A87F RID: 43135 RVA: 0x002F12C8 File Offset: 0x002EF4C8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A880 RID: 43136 RVA: 0x002F12D4 File Offset: 0x002EF4D4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A881 RID: 43137 RVA: 0x002F12DC File Offset: 0x002EF4DC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A882 RID: 43138 RVA: 0x002F12E4 File Offset: 0x002EF4E4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A883 RID: 43139 RVA: 0x002F12F8 File Offset: 0x002EF4F8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A884 RID: 43140 RVA: 0x002F1300 File Offset: 0x002EF500
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A885 RID: 43141 RVA: 0x002F130C File Offset: 0x002EF50C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A886 RID: 43142 RVA: 0x002F1318 File Offset: 0x002EF518
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x002F1324 File Offset: 0x002EF524
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x002F1330 File Offset: 0x002EF530
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A889 RID: 43145 RVA: 0x002F133C File Offset: 0x002EF53C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A88A RID: 43146 RVA: 0x002F1348 File Offset: 0x002EF548
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A88B RID: 43147 RVA: 0x002F1354 File Offset: 0x002EF554
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x002F1360 File Offset: 0x002EF560
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x002F136C File Offset: 0x002EF56C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x002F1374 File Offset: 0x002EF574
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x002F1394 File Offset: 0x002EF594
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x002F13A0 File Offset: 0x002EF5A0
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
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x002F14B8 File Offset: 0x002EF6B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleLoseUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006F3D RID: 28477
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04006F3E RID: 28478
		[DoNotToLua]
		private BattleLoseUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006F3F RID: 28479
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006F40 RID: 28480
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006F41 RID: 28481
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006F42 RID: 28482
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04006F43 RID: 28483
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04006F44 RID: 28484
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000A77 RID: 2679
		public new class LuaExportHelper
		{
			// Token: 0x0600A892 RID: 43154 RVA: 0x002F1520 File Offset: 0x002EF720
			public LuaExportHelper(BattleLoseUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A893 RID: 43155 RVA: 0x002F1530 File Offset: 0x002EF730
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A894 RID: 43156 RVA: 0x002F1540 File Offset: 0x002EF740
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A895 RID: 43157 RVA: 0x002F1550 File Offset: 0x002EF750
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A896 RID: 43158 RVA: 0x002F1560 File Offset: 0x002EF760
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A897 RID: 43159 RVA: 0x002F1578 File Offset: 0x002EF778
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A898 RID: 43160 RVA: 0x002F1588 File Offset: 0x002EF788
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A899 RID: 43161 RVA: 0x002F1598 File Offset: 0x002EF798
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A89A RID: 43162 RVA: 0x002F15A8 File Offset: 0x002EF7A8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A89B RID: 43163 RVA: 0x002F15B8 File Offset: 0x002EF7B8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A89C RID: 43164 RVA: 0x002F15C8 File Offset: 0x002EF7C8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A89D RID: 43165 RVA: 0x002F15D8 File Offset: 0x002EF7D8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A89E RID: 43166 RVA: 0x002F15E8 File Offset: 0x002EF7E8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A89F RID: 43167 RVA: 0x002F15F8 File Offset: 0x002EF7F8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A8A0 RID: 43168 RVA: 0x002F1608 File Offset: 0x002EF808
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A8A1 RID: 43169 RVA: 0x002F1618 File Offset: 0x002EF818
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600A8A2 RID: 43170 RVA: 0x002F1628 File Offset: 0x002EF828
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600A8A3 RID: 43171 RVA: 0x002F1638 File Offset: 0x002EF838
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002225 RID: 8741
			// (get) Token: 0x0600A8A4 RID: 43172 RVA: 0x002F1648 File Offset: 0x002EF848
			// (set) Token: 0x0600A8A5 RID: 43173 RVA: 0x002F1658 File Offset: 0x002EF858
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

			// Token: 0x0600A8A6 RID: 43174 RVA: 0x002F1668 File Offset: 0x002EF868
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A8A7 RID: 43175 RVA: 0x002F1678 File Offset: 0x002EF878
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04006F45 RID: 28485
			private BattleLoseUIController m_owner;
		}
	}
}
