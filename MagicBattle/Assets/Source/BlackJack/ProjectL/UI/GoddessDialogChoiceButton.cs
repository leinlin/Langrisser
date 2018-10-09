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
	// Token: 0x02000CD0 RID: 3280
	[HotFix]
	public class GoddessDialogChoiceButton : UIControllerBase
	{
		// Token: 0x0600EE7D RID: 61053 RVA: 0x003FA778 File Offset: 0x003F8978
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
			this.m_buton.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x0600EE7E RID: 61054 RVA: 0x003FA7FC File Offset: 0x003F89FC
		public void SetIndex(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_index = idx;
		}

		// Token: 0x0600EE7F RID: 61055 RVA: 0x003FA874 File Offset: 0x003F8A74
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x0600EE80 RID: 61056 RVA: 0x003FA8E8 File Offset: 0x003F8AE8
		public void SetText(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTextString_hotfix != null)
			{
				this.m_SetTextString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_text.text = txt;
			base.gameObject.SetActive(!string.IsNullOrEmpty(txt));
		}

		// Token: 0x0600EE81 RID: 61057 RVA: 0x003FA978 File Offset: 0x003F8B78
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000327 RID: 807
		// (add) Token: 0x0600EE82 RID: 61058 RVA: 0x003FA9F0 File Offset: 0x003F8BF0
		// (remove) Token: 0x0600EE83 RID: 61059 RVA: 0x003FAA8C File Offset: 0x003F8C8C
		public event Action<GoddessDialogChoiceButton> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoddessDialogChoiceButton> action = this.EventOnClick;
				Action<GoddessDialogChoiceButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoddessDialogChoiceButton>>(ref this.EventOnClick, (Action<GoddessDialogChoiceButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoddessDialogChoiceButton> action = this.EventOnClick;
				Action<GoddessDialogChoiceButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoddessDialogChoiceButton>>(ref this.EventOnClick, (Action<GoddessDialogChoiceButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600EE84 RID: 61060 RVA: 0x003FAB28 File Offset: 0x003F8D28
		// (set) Token: 0x0600EE85 RID: 61061 RVA: 0x003FAB48 File Offset: 0x003F8D48
		[DoNotToLua]
		public new GoddessDialogChoiceButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GoddessDialogChoiceButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EE86 RID: 61062 RVA: 0x003FAB54 File Offset: 0x003F8D54
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EE87 RID: 61063 RVA: 0x003FAB60 File Offset: 0x003F8D60
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EE88 RID: 61064 RVA: 0x003FAB68 File Offset: 0x003F8D68
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EE89 RID: 61065 RVA: 0x003FAB70 File Offset: 0x003F8D70
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EE8A RID: 61066 RVA: 0x003FAB84 File Offset: 0x003F8D84
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EE8B RID: 61067 RVA: 0x003FAB8C File Offset: 0x003F8D8C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EE8C RID: 61068 RVA: 0x003FAB98 File Offset: 0x003F8D98
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EE8D RID: 61069 RVA: 0x003FABA4 File Offset: 0x003F8DA4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EE8E RID: 61070 RVA: 0x003FABB0 File Offset: 0x003F8DB0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EE8F RID: 61071 RVA: 0x003FABBC File Offset: 0x003F8DBC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EE90 RID: 61072 RVA: 0x003FABC8 File Offset: 0x003F8DC8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EE91 RID: 61073 RVA: 0x003FABD4 File Offset: 0x003F8DD4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EE92 RID: 61074 RVA: 0x003FABE0 File Offset: 0x003F8DE0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EE93 RID: 61075 RVA: 0x003FABEC File Offset: 0x003F8DEC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EE94 RID: 61076 RVA: 0x003FABF8 File Offset: 0x003F8DF8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EE95 RID: 61077 RVA: 0x003FAC00 File Offset: 0x003F8E00
		private void __callDele_EventOnClick(GoddessDialogChoiceButton obj)
		{
			Action<GoddessDialogChoiceButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600EE96 RID: 61078 RVA: 0x003FAC24 File Offset: 0x003F8E24
		private void __clearDele_EventOnClick(GoddessDialogChoiceButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600EE97 RID: 61079 RVA: 0x003FAC30 File Offset: 0x003F8E30
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
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_SetTextString_hotfix = (luaObj.RawGet("SetText") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EE98 RID: 61080 RVA: 0x003FAD94 File Offset: 0x003F8F94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GoddessDialogChoiceButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008E6D RID: 36461
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buton;

		// Token: 0x04008E6E RID: 36462
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x04008E6F RID: 36463
		private int m_index;

		// Token: 0x04008E70 RID: 36464
		[DoNotToLua]
		private GoddessDialogChoiceButton.LuaExportHelper luaExportHelper;

		// Token: 0x04008E71 RID: 36465
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008E72 RID: 36466
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008E73 RID: 36467
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008E74 RID: 36468
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x04008E75 RID: 36469
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x04008E76 RID: 36470
		private LuaFunction m_SetTextString_hotfix;

		// Token: 0x04008E77 RID: 36471
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04008E78 RID: 36472
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04008E79 RID: 36473
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000CD1 RID: 3281
		public new class LuaExportHelper
		{
			// Token: 0x0600EE99 RID: 61081 RVA: 0x003FADFC File Offset: 0x003F8FFC
			public LuaExportHelper(GoddessDialogChoiceButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EE9A RID: 61082 RVA: 0x003FAE0C File Offset: 0x003F900C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EE9B RID: 61083 RVA: 0x003FAE1C File Offset: 0x003F901C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EE9C RID: 61084 RVA: 0x003FAE2C File Offset: 0x003F902C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EE9D RID: 61085 RVA: 0x003FAE3C File Offset: 0x003F903C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EE9E RID: 61086 RVA: 0x003FAE54 File Offset: 0x003F9054
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EE9F RID: 61087 RVA: 0x003FAE64 File Offset: 0x003F9064
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EEA0 RID: 61088 RVA: 0x003FAE74 File Offset: 0x003F9074
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EEA1 RID: 61089 RVA: 0x003FAE84 File Offset: 0x003F9084
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EEA2 RID: 61090 RVA: 0x003FAE94 File Offset: 0x003F9094
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EEA3 RID: 61091 RVA: 0x003FAEA4 File Offset: 0x003F90A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EEA4 RID: 61092 RVA: 0x003FAEB4 File Offset: 0x003F90B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EEA5 RID: 61093 RVA: 0x003FAEC4 File Offset: 0x003F90C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EEA6 RID: 61094 RVA: 0x003FAED4 File Offset: 0x003F90D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EEA7 RID: 61095 RVA: 0x003FAEE4 File Offset: 0x003F90E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EEA8 RID: 61096 RVA: 0x003FAEF4 File Offset: 0x003F90F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600EEA9 RID: 61097 RVA: 0x003FAF04 File Offset: 0x003F9104
			public void __callDele_EventOnClick(GoddessDialogChoiceButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600EEAA RID: 61098 RVA: 0x003FAF14 File Offset: 0x003F9114
			public void __clearDele_EventOnClick(GoddessDialogChoiceButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002DFB RID: 11771
			// (get) Token: 0x0600EEAB RID: 61099 RVA: 0x003FAF24 File Offset: 0x003F9124
			// (set) Token: 0x0600EEAC RID: 61100 RVA: 0x003FAF34 File Offset: 0x003F9134
			public Button m_buton
			{
				get
				{
					return this.m_owner.m_buton;
				}
				set
				{
					this.m_owner.m_buton = value;
				}
			}

			// Token: 0x17002DFC RID: 11772
			// (get) Token: 0x0600EEAD RID: 61101 RVA: 0x003FAF44 File Offset: 0x003F9144
			// (set) Token: 0x0600EEAE RID: 61102 RVA: 0x003FAF54 File Offset: 0x003F9154
			public Text m_text
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

			// Token: 0x17002DFD RID: 11773
			// (get) Token: 0x0600EEAF RID: 61103 RVA: 0x003FAF64 File Offset: 0x003F9164
			// (set) Token: 0x0600EEB0 RID: 61104 RVA: 0x003FAF74 File Offset: 0x003F9174
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x0600EEB1 RID: 61105 RVA: 0x003FAF84 File Offset: 0x003F9184
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EEB2 RID: 61106 RVA: 0x003FAF94 File Offset: 0x003F9194
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04008E7A RID: 36474
			private GoddessDialogChoiceButton m_owner;
		}
	}
}
