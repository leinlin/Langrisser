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
	// Token: 0x02000B44 RID: 2884
	[HotFix]
	public class SmallExpressionItemContrller : UIControllerBase
	{
		// Token: 0x0600C3FB RID: 50171 RVA: 0x00364D90 File Offset: 0x00362F90
		public static void CollectExpressionAsset()
		{
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x00364D94 File Offset: 0x00362F94
		public void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_button = base.GetComponent<Button>();
			this.m_icon = base.GetComponent<Image>();
			if (this.m_button != null)
			{
				this.m_button.onClick.RemoveAllListeners();
				this.m_button.onClick.AddListener(new UnityAction(this.OnExpressionClick));
			}
		}

		// Token: 0x0600C3FD RID: 50173 RVA: 0x00364E4C File Offset: 0x0036304C
		public void RegisterUIEvent(Action<SmallExpressionItemContrller> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterUIEventAction`1_hotfix != null)
			{
				this.m_RegisterUIEventAction`1_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExpressionClick != null)
			{
				this.EventOnExpressionClick = null;
			}
			this.EventOnExpressionClick = action;
		}

		// Token: 0x0600C3FE RID: 50174 RVA: 0x00364ED8 File Offset: 0x003630D8
		public void SetExpressionIcon(Sprite sprite)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetExpressionIconSprite_hotfix != null)
			{
				this.m_SetExpressionIconSprite_hotfix.call(new object[]
				{
					this,
					sprite
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_icon != null)
			{
				this.m_icon.sprite = sprite;
			}
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x00364F68 File Offset: 0x00363168
		private void OnExpressionClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpressionClick_hotfix != null)
			{
				this.m_OnExpressionClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnExpressionClick != null)
			{
				this.EventOnExpressionClick(this);
			}
		}

		// Token: 0x14000257 RID: 599
		// (add) Token: 0x0600C400 RID: 50176 RVA: 0x00364FE0 File Offset: 0x003631E0
		// (remove) Token: 0x0600C401 RID: 50177 RVA: 0x0036507C File Offset: 0x0036327C
		public event Action<SmallExpressionItemContrller> EventOnExpressionClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExpressionClickAction`1_hotfix != null)
				{
					this.m_add_EventOnExpressionClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SmallExpressionItemContrller> action = this.EventOnExpressionClick;
				Action<SmallExpressionItemContrller> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SmallExpressionItemContrller>>(ref this.EventOnExpressionClick, (Action<SmallExpressionItemContrller>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExpressionClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnExpressionClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SmallExpressionItemContrller> action = this.EventOnExpressionClick;
				Action<SmallExpressionItemContrller> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SmallExpressionItemContrller>>(ref this.EventOnExpressionClick, (Action<SmallExpressionItemContrller>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x0600C402 RID: 50178 RVA: 0x00365118 File Offset: 0x00363318
		// (set) Token: 0x0600C403 RID: 50179 RVA: 0x00365138 File Offset: 0x00363338
		[DoNotToLua]
		public new SmallExpressionItemContrller.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SmallExpressionItemContrller.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C404 RID: 50180 RVA: 0x00365144 File Offset: 0x00363344
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x00365150 File Offset: 0x00363350
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C406 RID: 50182 RVA: 0x00365158 File Offset: 0x00363358
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x00365160 File Offset: 0x00363360
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C408 RID: 50184 RVA: 0x00365174 File Offset: 0x00363374
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C409 RID: 50185 RVA: 0x0036517C File Offset: 0x0036337C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x00365188 File Offset: 0x00363388
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C40B RID: 50187 RVA: 0x00365194 File Offset: 0x00363394
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C40C RID: 50188 RVA: 0x003651A0 File Offset: 0x003633A0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C40D RID: 50189 RVA: 0x003651AC File Offset: 0x003633AC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C40E RID: 50190 RVA: 0x003651B8 File Offset: 0x003633B8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x003651C4 File Offset: 0x003633C4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x003651D0 File Offset: 0x003633D0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x003651DC File Offset: 0x003633DC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x003651E8 File Offset: 0x003633E8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x003651F0 File Offset: 0x003633F0
		private void __callDele_EventOnExpressionClick(SmallExpressionItemContrller obj)
		{
			Action<SmallExpressionItemContrller> eventOnExpressionClick = this.EventOnExpressionClick;
			if (eventOnExpressionClick != null)
			{
				eventOnExpressionClick(obj);
			}
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x00365214 File Offset: 0x00363414
		private void __clearDele_EventOnExpressionClick(SmallExpressionItemContrller obj)
		{
			this.EventOnExpressionClick = null;
		}

		// Token: 0x0600C415 RID: 50197 RVA: 0x00365220 File Offset: 0x00363420
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_RegisterUIEventAction`1_hotfix = (luaObj.RawGet("RegisterUIEvent") as LuaFunction);
					this.m_SetExpressionIconSprite_hotfix = (luaObj.RawGet("SetExpressionIcon") as LuaFunction);
					this.m_OnExpressionClick_hotfix = (luaObj.RawGet("OnExpressionClick") as LuaFunction);
					this.m_add_EventOnExpressionClickAction`1_hotfix = (luaObj.RawGet("add_EventOnExpressionClick") as LuaFunction);
					this.m_remove_EventOnExpressionClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnExpressionClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x00365368 File Offset: 0x00363568
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SmallExpressionItemContrller));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007C49 RID: 31817
		public int m_key;

		// Token: 0x04007C4A RID: 31818
		public string m_assetPath;

		// Token: 0x04007C4B RID: 31819
		private Image m_icon;

		// Token: 0x04007C4C RID: 31820
		private Button m_button;

		// Token: 0x04007C4D RID: 31821
		[DoNotToLua]
		private SmallExpressionItemContrller.LuaExportHelper luaExportHelper;

		// Token: 0x04007C4E RID: 31822
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007C4F RID: 31823
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007C50 RID: 31824
		private LuaFunction m_Init_hotfix;

		// Token: 0x04007C51 RID: 31825
		private LuaFunction m_RegisterUIEventAction;

		// Token: 0x04007C52 RID: 31826
		private LuaFunction m_SetExpressionIconSprite_hotfix;

		// Token: 0x04007C53 RID: 31827
		private LuaFunction m_OnExpressionClick_hotfix;

		// Token: 0x04007C54 RID: 31828
		private LuaFunction m_add_EventOnExpressionClickAction;

		// Token: 0x04007C55 RID: 31829
		private LuaFunction m_remove_EventOnExpressionClickAction;

		// Token: 0x02000B45 RID: 2885
		public new class LuaExportHelper
		{
			// Token: 0x0600C417 RID: 50199 RVA: 0x003653D0 File Offset: 0x003635D0
			public LuaExportHelper(SmallExpressionItemContrller owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C418 RID: 50200 RVA: 0x003653E0 File Offset: 0x003635E0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C419 RID: 50201 RVA: 0x003653F0 File Offset: 0x003635F0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C41A RID: 50202 RVA: 0x00365400 File Offset: 0x00363600
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C41B RID: 50203 RVA: 0x00365410 File Offset: 0x00363610
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C41C RID: 50204 RVA: 0x00365428 File Offset: 0x00363628
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C41D RID: 50205 RVA: 0x00365438 File Offset: 0x00363638
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C41E RID: 50206 RVA: 0x00365448 File Offset: 0x00363648
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C41F RID: 50207 RVA: 0x00365458 File Offset: 0x00363658
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C420 RID: 50208 RVA: 0x00365468 File Offset: 0x00363668
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C421 RID: 50209 RVA: 0x00365478 File Offset: 0x00363678
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C422 RID: 50210 RVA: 0x00365488 File Offset: 0x00363688
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C423 RID: 50211 RVA: 0x00365498 File Offset: 0x00363698
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C424 RID: 50212 RVA: 0x003654A8 File Offset: 0x003636A8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C425 RID: 50213 RVA: 0x003654B8 File Offset: 0x003636B8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C426 RID: 50214 RVA: 0x003654C8 File Offset: 0x003636C8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C427 RID: 50215 RVA: 0x003654D8 File Offset: 0x003636D8
			public void __callDele_EventOnExpressionClick(SmallExpressionItemContrller obj)
			{
				this.m_owner.__callDele_EventOnExpressionClick(obj);
			}

			// Token: 0x0600C428 RID: 50216 RVA: 0x003654E8 File Offset: 0x003636E8
			public void __clearDele_EventOnExpressionClick(SmallExpressionItemContrller obj)
			{
				this.m_owner.__clearDele_EventOnExpressionClick(obj);
			}

			// Token: 0x17002748 RID: 10056
			// (get) Token: 0x0600C429 RID: 50217 RVA: 0x003654F8 File Offset: 0x003636F8
			// (set) Token: 0x0600C42A RID: 50218 RVA: 0x00365508 File Offset: 0x00363708
			public Image m_icon
			{
				get
				{
					return this.m_owner.m_icon;
				}
				set
				{
					this.m_owner.m_icon = value;
				}
			}

			// Token: 0x17002749 RID: 10057
			// (get) Token: 0x0600C42B RID: 50219 RVA: 0x00365518 File Offset: 0x00363718
			// (set) Token: 0x0600C42C RID: 50220 RVA: 0x00365528 File Offset: 0x00363728
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x0600C42D RID: 50221 RVA: 0x00365538 File Offset: 0x00363738
			public void OnExpressionClick()
			{
				this.m_owner.OnExpressionClick();
			}

			// Token: 0x04007C56 RID: 31830
			private SmallExpressionItemContrller m_owner;
		}
	}
}
