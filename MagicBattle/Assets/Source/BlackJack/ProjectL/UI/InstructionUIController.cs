using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BC8 RID: 3016
	[HotFix]
	public class InstructionUIController : UIControllerBase
	{
		// Token: 0x0600CFA0 RID: 53152 RVA: 0x0038F770 File Offset: 0x0038D970
		private InstructionUIController()
		{
		}

		// Token: 0x0600CFA1 RID: 53153 RVA: 0x0038F778 File Offset: 0x0038D978
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

		// Token: 0x0600CFA2 RID: 53154 RVA: 0x0038F7FC File Offset: 0x0038D9FC
		public void Show(string prefabName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowString_hotfix != null)
			{
				this.m_ShowString_hotfix.call(new object[]
				{
					this,
					prefabName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_panelGameObject);
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(prefabName);
			if (asset != null)
			{
				UnityEngine.Object.Instantiate<GameObject>(asset, this.m_panelGameObject.transform, false);
			}
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
			this.m_isOpened = true;
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x0038F8BC File Offset: 0x0038DABC
		private void Close(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", onEnd, false, true);
			this.m_isOpened = false;
		}

		// Token: 0x0600CFA4 RID: 53156 RVA: 0x0038F948 File Offset: 0x0038DB48
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
			if (!this.m_isOpened)
			{
				return;
			}
			this.Close(delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			});
		}

		// Token: 0x1400027C RID: 636
		// (add) Token: 0x0600CFA5 RID: 53157 RVA: 0x0038F9C8 File Offset: 0x0038DBC8
		// (remove) Token: 0x0600CFA6 RID: 53158 RVA: 0x0038FA64 File Offset: 0x0038DC64
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

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600CFA7 RID: 53159 RVA: 0x0038FB00 File Offset: 0x0038DD00
		// (set) Token: 0x0600CFA8 RID: 53160 RVA: 0x0038FB20 File Offset: 0x0038DD20
		[DoNotToLua]
		public new InstructionUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new InstructionUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CFA9 RID: 53161 RVA: 0x0038FB2C File Offset: 0x0038DD2C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CFAA RID: 53162 RVA: 0x0038FB38 File Offset: 0x0038DD38
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CFAB RID: 53163 RVA: 0x0038FB40 File Offset: 0x0038DD40
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CFAC RID: 53164 RVA: 0x0038FB48 File Offset: 0x0038DD48
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CFAD RID: 53165 RVA: 0x0038FB5C File Offset: 0x0038DD5C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CFAE RID: 53166 RVA: 0x0038FB64 File Offset: 0x0038DD64
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x0038FB70 File Offset: 0x0038DD70
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x0038FB7C File Offset: 0x0038DD7C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x0038FB88 File Offset: 0x0038DD88
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x0038FB94 File Offset: 0x0038DD94
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x0038FBA0 File Offset: 0x0038DDA0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x0038FBAC File Offset: 0x0038DDAC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x0038FBB8 File Offset: 0x0038DDB8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x0038FBC4 File Offset: 0x0038DDC4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x0038FBD0 File Offset: 0x0038DDD0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CFB8 RID: 53176 RVA: 0x0038FBD8 File Offset: 0x0038DDD8
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x0038FBF8 File Offset: 0x0038DDF8
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x0038FC1C File Offset: 0x0038DE1C
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
					this.m_ShowString_hotfix = (luaObj.RawGet("Show") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x0038FD64 File Offset: 0x0038DF64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(InstructionUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008184 RID: 33156
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04008185 RID: 33157
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04008186 RID: 33158
		[AutoBind("./Panel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_panelGameObject;

		// Token: 0x04008187 RID: 33159
		private bool m_isOpened;

		// Token: 0x04008188 RID: 33160
		[DoNotToLua]
		private InstructionUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008189 RID: 33161
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400818A RID: 33162
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400818B RID: 33163
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400818C RID: 33164
		private LuaFunction m_ShowString_hotfix;

		// Token: 0x0400818D RID: 33165
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x0400818E RID: 33166
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400818F RID: 33167
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008190 RID: 33168
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000BC9 RID: 3017
		public new class LuaExportHelper
		{
			// Token: 0x0600CFBD RID: 53181 RVA: 0x0038FDCC File Offset: 0x0038DFCC
			public LuaExportHelper(InstructionUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CFBE RID: 53182 RVA: 0x0038FDDC File Offset: 0x0038DFDC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CFBF RID: 53183 RVA: 0x0038FDEC File Offset: 0x0038DFEC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CFC0 RID: 53184 RVA: 0x0038FDFC File Offset: 0x0038DFFC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CFC1 RID: 53185 RVA: 0x0038FE0C File Offset: 0x0038E00C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CFC2 RID: 53186 RVA: 0x0038FE24 File Offset: 0x0038E024
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CFC3 RID: 53187 RVA: 0x0038FE34 File Offset: 0x0038E034
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CFC4 RID: 53188 RVA: 0x0038FE44 File Offset: 0x0038E044
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CFC5 RID: 53189 RVA: 0x0038FE54 File Offset: 0x0038E054
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CFC6 RID: 53190 RVA: 0x0038FE64 File Offset: 0x0038E064
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CFC7 RID: 53191 RVA: 0x0038FE74 File Offset: 0x0038E074
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CFC8 RID: 53192 RVA: 0x0038FE84 File Offset: 0x0038E084
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CFC9 RID: 53193 RVA: 0x0038FE94 File Offset: 0x0038E094
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CFCA RID: 53194 RVA: 0x0038FEA4 File Offset: 0x0038E0A4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CFCB RID: 53195 RVA: 0x0038FEB4 File Offset: 0x0038E0B4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CFCC RID: 53196 RVA: 0x0038FEC4 File Offset: 0x0038E0C4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600CFCD RID: 53197 RVA: 0x0038FED4 File Offset: 0x0038E0D4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600CFCE RID: 53198 RVA: 0x0038FEE4 File Offset: 0x0038E0E4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170028FB RID: 10491
			// (get) Token: 0x0600CFCF RID: 53199 RVA: 0x0038FEF4 File Offset: 0x0038E0F4
			// (set) Token: 0x0600CFD0 RID: 53200 RVA: 0x0038FF04 File Offset: 0x0038E104
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

			// Token: 0x170028FC RID: 10492
			// (get) Token: 0x0600CFD1 RID: 53201 RVA: 0x0038FF14 File Offset: 0x0038E114
			// (set) Token: 0x0600CFD2 RID: 53202 RVA: 0x0038FF24 File Offset: 0x0038E124
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

			// Token: 0x170028FD RID: 10493
			// (get) Token: 0x0600CFD3 RID: 53203 RVA: 0x0038FF34 File Offset: 0x0038E134
			// (set) Token: 0x0600CFD4 RID: 53204 RVA: 0x0038FF44 File Offset: 0x0038E144
			public GameObject m_panelGameObject
			{
				get
				{
					return this.m_owner.m_panelGameObject;
				}
				set
				{
					this.m_owner.m_panelGameObject = value;
				}
			}

			// Token: 0x170028FE RID: 10494
			// (get) Token: 0x0600CFD5 RID: 53205 RVA: 0x0038FF54 File Offset: 0x0038E154
			// (set) Token: 0x0600CFD6 RID: 53206 RVA: 0x0038FF64 File Offset: 0x0038E164
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x0600CFD7 RID: 53207 RVA: 0x0038FF74 File Offset: 0x0038E174
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CFD8 RID: 53208 RVA: 0x0038FF84 File Offset: 0x0038E184
			public void Close(Action onEnd)
			{
				this.m_owner.Close(onEnd);
			}

			// Token: 0x0600CFD9 RID: 53209 RVA: 0x0038FF94 File Offset: 0x0038E194
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04008191 RID: 33169
			private InstructionUIController m_owner;
		}
	}
}
