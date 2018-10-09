using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001022 RID: 4130
	[HotFix]
	public class WorldMapUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06014EA3 RID: 85667 RVA: 0x0054BBBC File Offset: 0x00549DBC
		private WorldMapUIController()
		{
		}

		// Token: 0x06014EA4 RID: 85668 RVA: 0x0054BBC4 File Offset: 0x00549DC4
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
		}

		// Token: 0x06014EA5 RID: 85669 RVA: 0x0054BC2C File Offset: 0x00549E2C
		public void OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPointerDown != null)
			{
				this.EventOnPointerDown();
			}
		}

		// Token: 0x06014EA6 RID: 85670 RVA: 0x0054BCB4 File Offset: 0x00549EB4
		public void OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPointerUp != null)
			{
				this.EventOnPointerUp();
			}
		}

		// Token: 0x06014EA7 RID: 85671 RVA: 0x0054BD3C File Offset: 0x00549F3C
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick();
			}
		}

		// Token: 0x1400049D RID: 1181
		// (add) Token: 0x06014EA8 RID: 85672 RVA: 0x0054BDC4 File Offset: 0x00549FC4
		// (remove) Token: 0x06014EA9 RID: 85673 RVA: 0x0054BE60 File Offset: 0x0054A060
		public event Action EventOnPointerDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerDownAction_hotfix != null)
				{
					this.m_add_EventOnPointerDownAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerDown;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerDown, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerDownAction_hotfix != null)
				{
					this.m_remove_EventOnPointerDownAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerDown;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerDown, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400049E RID: 1182
		// (add) Token: 0x06014EAA RID: 85674 RVA: 0x0054BEFC File Offset: 0x0054A0FC
		// (remove) Token: 0x06014EAB RID: 85675 RVA: 0x0054BF98 File Offset: 0x0054A198
		public event Action EventOnPointerUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerUpAction_hotfix != null)
				{
					this.m_add_EventOnPointerUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerUp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerUpAction_hotfix != null)
				{
					this.m_remove_EventOnPointerUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerUp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400049F RID: 1183
		// (add) Token: 0x06014EAC RID: 85676 RVA: 0x0054C034 File Offset: 0x0054A234
		// (remove) Token: 0x06014EAD RID: 85677 RVA: 0x0054C0D0 File Offset: 0x0054A2D0
		public event Action EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction_hotfix != null)
				{
					this.m_add_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction_hotfix != null)
				{
					this.m_remove_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x06014EAE RID: 85678 RVA: 0x0054C16C File Offset: 0x0054A36C
		// (set) Token: 0x06014EAF RID: 85679 RVA: 0x0054C18C File Offset: 0x0054A38C
		[DoNotToLua]
		public new WorldMapUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldMapUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014EB0 RID: 85680 RVA: 0x0054C198 File Offset: 0x0054A398
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014EB1 RID: 85681 RVA: 0x0054C1A4 File Offset: 0x0054A3A4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014EB2 RID: 85682 RVA: 0x0054C1AC File Offset: 0x0054A3AC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014EB3 RID: 85683 RVA: 0x0054C1B4 File Offset: 0x0054A3B4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014EB4 RID: 85684 RVA: 0x0054C1C8 File Offset: 0x0054A3C8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014EB5 RID: 85685 RVA: 0x0054C1D0 File Offset: 0x0054A3D0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014EB6 RID: 85686 RVA: 0x0054C1DC File Offset: 0x0054A3DC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014EB7 RID: 85687 RVA: 0x0054C1E8 File Offset: 0x0054A3E8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014EB8 RID: 85688 RVA: 0x0054C1F4 File Offset: 0x0054A3F4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014EB9 RID: 85689 RVA: 0x0054C200 File Offset: 0x0054A400
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014EBA RID: 85690 RVA: 0x0054C20C File Offset: 0x0054A40C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014EBB RID: 85691 RVA: 0x0054C218 File Offset: 0x0054A418
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014EBC RID: 85692 RVA: 0x0054C224 File Offset: 0x0054A424
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014EBD RID: 85693 RVA: 0x0054C230 File Offset: 0x0054A430
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014EBE RID: 85694 RVA: 0x0054C23C File Offset: 0x0054A43C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014EBF RID: 85695 RVA: 0x0054C244 File Offset: 0x0054A444
		private void __callDele_EventOnPointerDown()
		{
			Action eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown();
			}
		}

		// Token: 0x06014EC0 RID: 85696 RVA: 0x0054C264 File Offset: 0x0054A464
		private void __clearDele_EventOnPointerDown()
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x06014EC1 RID: 85697 RVA: 0x0054C270 File Offset: 0x0054A470
		private void __callDele_EventOnPointerUp()
		{
			Action eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp();
			}
		}

		// Token: 0x06014EC2 RID: 85698 RVA: 0x0054C290 File Offset: 0x0054A490
		private void __clearDele_EventOnPointerUp()
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x06014EC3 RID: 85699 RVA: 0x0054C29C File Offset: 0x0054A49C
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x06014EC4 RID: 85700 RVA: 0x0054C2BC File Offset: 0x0054A4BC
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x06014EC5 RID: 85701 RVA: 0x0054C2C8 File Offset: 0x0054A4C8
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
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_add_EventOnPointerDownAction_hotfix = (luaObj.RawGet("add_EventOnPointerDown") as LuaFunction);
					this.m_remove_EventOnPointerDownAction_hotfix = (luaObj.RawGet("remove_EventOnPointerDown") as LuaFunction);
					this.m_add_EventOnPointerUpAction_hotfix = (luaObj.RawGet("add_EventOnPointerUp") as LuaFunction);
					this.m_remove_EventOnPointerUpAction_hotfix = (luaObj.RawGet("remove_EventOnPointerUp") as LuaFunction);
					this.m_add_EventOnClickAction_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014EC6 RID: 85702 RVA: 0x0054C474 File Offset: 0x0054A674
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldMapUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B6E6 RID: 46822
		[DoNotToLua]
		private WorldMapUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B6E7 RID: 46823
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B6E8 RID: 46824
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B6E9 RID: 46825
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B6EA RID: 46826
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400B6EB RID: 46827
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x0400B6EC RID: 46828
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400B6ED RID: 46829
		private LuaFunction m_add_EventOnPointerDownAction_hotfix;

		// Token: 0x0400B6EE RID: 46830
		private LuaFunction m_remove_EventOnPointerDownAction_hotfix;

		// Token: 0x0400B6EF RID: 46831
		private LuaFunction m_add_EventOnPointerUpAction_hotfix;

		// Token: 0x0400B6F0 RID: 46832
		private LuaFunction m_remove_EventOnPointerUpAction_hotfix;

		// Token: 0x0400B6F1 RID: 46833
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x0400B6F2 RID: 46834
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x02001023 RID: 4131
		public new class LuaExportHelper
		{
			// Token: 0x06014EC7 RID: 85703 RVA: 0x0054C4DC File Offset: 0x0054A6DC
			public LuaExportHelper(WorldMapUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014EC8 RID: 85704 RVA: 0x0054C4EC File Offset: 0x0054A6EC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014EC9 RID: 85705 RVA: 0x0054C4FC File Offset: 0x0054A6FC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014ECA RID: 85706 RVA: 0x0054C50C File Offset: 0x0054A70C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014ECB RID: 85707 RVA: 0x0054C51C File Offset: 0x0054A71C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014ECC RID: 85708 RVA: 0x0054C534 File Offset: 0x0054A734
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014ECD RID: 85709 RVA: 0x0054C544 File Offset: 0x0054A744
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014ECE RID: 85710 RVA: 0x0054C554 File Offset: 0x0054A754
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014ECF RID: 85711 RVA: 0x0054C564 File Offset: 0x0054A764
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014ED0 RID: 85712 RVA: 0x0054C574 File Offset: 0x0054A774
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014ED1 RID: 85713 RVA: 0x0054C584 File Offset: 0x0054A784
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014ED2 RID: 85714 RVA: 0x0054C594 File Offset: 0x0054A794
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014ED3 RID: 85715 RVA: 0x0054C5A4 File Offset: 0x0054A7A4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014ED4 RID: 85716 RVA: 0x0054C5B4 File Offset: 0x0054A7B4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014ED5 RID: 85717 RVA: 0x0054C5C4 File Offset: 0x0054A7C4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014ED6 RID: 85718 RVA: 0x0054C5D4 File Offset: 0x0054A7D4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014ED7 RID: 85719 RVA: 0x0054C5E4 File Offset: 0x0054A7E4
			public void __callDele_EventOnPointerDown()
			{
				this.m_owner.__callDele_EventOnPointerDown();
			}

			// Token: 0x06014ED8 RID: 85720 RVA: 0x0054C5F4 File Offset: 0x0054A7F4
			public void __clearDele_EventOnPointerDown()
			{
				this.m_owner.__clearDele_EventOnPointerDown();
			}

			// Token: 0x06014ED9 RID: 85721 RVA: 0x0054C604 File Offset: 0x0054A804
			public void __callDele_EventOnPointerUp()
			{
				this.m_owner.__callDele_EventOnPointerUp();
			}

			// Token: 0x06014EDA RID: 85722 RVA: 0x0054C614 File Offset: 0x0054A814
			public void __clearDele_EventOnPointerUp()
			{
				this.m_owner.__clearDele_EventOnPointerUp();
			}

			// Token: 0x06014EDB RID: 85723 RVA: 0x0054C624 File Offset: 0x0054A824
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x06014EDC RID: 85724 RVA: 0x0054C634 File Offset: 0x0054A834
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x06014EDD RID: 85725 RVA: 0x0054C644 File Offset: 0x0054A844
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400B6F3 RID: 46835
			private WorldMapUIController m_owner;
		}
	}
}
