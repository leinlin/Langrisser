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
	// Token: 0x0200102D RID: 4141
	[HotFix]
	public class WorldScenarioUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06014F67 RID: 85863 RVA: 0x0054D8FC File Offset: 0x0054BAFC
		private WorldScenarioUIController()
		{
		}

		// Token: 0x06014F68 RID: 85864 RVA: 0x0054D904 File Offset: 0x0054BB04
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

		// Token: 0x06014F69 RID: 85865 RVA: 0x0054D96C File Offset: 0x0054BB6C
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

		// Token: 0x06014F6A RID: 85866 RVA: 0x0054D9F4 File Offset: 0x0054BBF4
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

		// Token: 0x06014F6B RID: 85867 RVA: 0x0054DA7C File Offset: 0x0054BC7C
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

		// Token: 0x140004A2 RID: 1186
		// (add) Token: 0x06014F6C RID: 85868 RVA: 0x0054DB04 File Offset: 0x0054BD04
		// (remove) Token: 0x06014F6D RID: 85869 RVA: 0x0054DBA0 File Offset: 0x0054BDA0
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

		// Token: 0x140004A3 RID: 1187
		// (add) Token: 0x06014F6E RID: 85870 RVA: 0x0054DC3C File Offset: 0x0054BE3C
		// (remove) Token: 0x06014F6F RID: 85871 RVA: 0x0054DCD8 File Offset: 0x0054BED8
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

		// Token: 0x140004A4 RID: 1188
		// (add) Token: 0x06014F70 RID: 85872 RVA: 0x0054DD74 File Offset: 0x0054BF74
		// (remove) Token: 0x06014F71 RID: 85873 RVA: 0x0054DE10 File Offset: 0x0054C010
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

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x06014F72 RID: 85874 RVA: 0x0054DEAC File Offset: 0x0054C0AC
		// (set) Token: 0x06014F73 RID: 85875 RVA: 0x0054DECC File Offset: 0x0054C0CC
		[DoNotToLua]
		public new WorldScenarioUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldScenarioUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014F74 RID: 85876 RVA: 0x0054DED8 File Offset: 0x0054C0D8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014F75 RID: 85877 RVA: 0x0054DEE4 File Offset: 0x0054C0E4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014F76 RID: 85878 RVA: 0x0054DEEC File Offset: 0x0054C0EC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014F77 RID: 85879 RVA: 0x0054DEF4 File Offset: 0x0054C0F4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014F78 RID: 85880 RVA: 0x0054DF08 File Offset: 0x0054C108
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014F79 RID: 85881 RVA: 0x0054DF10 File Offset: 0x0054C110
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014F7A RID: 85882 RVA: 0x0054DF1C File Offset: 0x0054C11C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014F7B RID: 85883 RVA: 0x0054DF28 File Offset: 0x0054C128
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014F7C RID: 85884 RVA: 0x0054DF34 File Offset: 0x0054C134
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014F7D RID: 85885 RVA: 0x0054DF40 File Offset: 0x0054C140
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014F7E RID: 85886 RVA: 0x0054DF4C File Offset: 0x0054C14C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014F7F RID: 85887 RVA: 0x0054DF58 File Offset: 0x0054C158
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014F80 RID: 85888 RVA: 0x0054DF64 File Offset: 0x0054C164
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014F81 RID: 85889 RVA: 0x0054DF70 File Offset: 0x0054C170
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014F82 RID: 85890 RVA: 0x0054DF7C File Offset: 0x0054C17C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014F83 RID: 85891 RVA: 0x0054DF84 File Offset: 0x0054C184
		private void __callDele_EventOnPointerDown()
		{
			Action eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown();
			}
		}

		// Token: 0x06014F84 RID: 85892 RVA: 0x0054DFA4 File Offset: 0x0054C1A4
		private void __clearDele_EventOnPointerDown()
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x06014F85 RID: 85893 RVA: 0x0054DFB0 File Offset: 0x0054C1B0
		private void __callDele_EventOnPointerUp()
		{
			Action eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp();
			}
		}

		// Token: 0x06014F86 RID: 85894 RVA: 0x0054DFD0 File Offset: 0x0054C1D0
		private void __clearDele_EventOnPointerUp()
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x06014F87 RID: 85895 RVA: 0x0054DFDC File Offset: 0x0054C1DC
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x06014F88 RID: 85896 RVA: 0x0054DFFC File Offset: 0x0054C1FC
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x06014F89 RID: 85897 RVA: 0x0054E008 File Offset: 0x0054C208
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

		// Token: 0x06014F8A RID: 85898 RVA: 0x0054E1B4 File Offset: 0x0054C3B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldScenarioUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B71A RID: 46874
		[DoNotToLua]
		private WorldScenarioUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B71B RID: 46875
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B71C RID: 46876
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B71D RID: 46877
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B71E RID: 46878
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400B71F RID: 46879
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x0400B720 RID: 46880
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400B721 RID: 46881
		private LuaFunction m_add_EventOnPointerDownAction_hotfix;

		// Token: 0x0400B722 RID: 46882
		private LuaFunction m_remove_EventOnPointerDownAction_hotfix;

		// Token: 0x0400B723 RID: 46883
		private LuaFunction m_add_EventOnPointerUpAction_hotfix;

		// Token: 0x0400B724 RID: 46884
		private LuaFunction m_remove_EventOnPointerUpAction_hotfix;

		// Token: 0x0400B725 RID: 46885
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x0400B726 RID: 46886
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x0200102E RID: 4142
		public new class LuaExportHelper
		{
			// Token: 0x06014F8B RID: 85899 RVA: 0x0054E21C File Offset: 0x0054C41C
			public LuaExportHelper(WorldScenarioUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014F8C RID: 85900 RVA: 0x0054E22C File Offset: 0x0054C42C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014F8D RID: 85901 RVA: 0x0054E23C File Offset: 0x0054C43C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014F8E RID: 85902 RVA: 0x0054E24C File Offset: 0x0054C44C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014F8F RID: 85903 RVA: 0x0054E25C File Offset: 0x0054C45C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014F90 RID: 85904 RVA: 0x0054E274 File Offset: 0x0054C474
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014F91 RID: 85905 RVA: 0x0054E284 File Offset: 0x0054C484
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014F92 RID: 85906 RVA: 0x0054E294 File Offset: 0x0054C494
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014F93 RID: 85907 RVA: 0x0054E2A4 File Offset: 0x0054C4A4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014F94 RID: 85908 RVA: 0x0054E2B4 File Offset: 0x0054C4B4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014F95 RID: 85909 RVA: 0x0054E2C4 File Offset: 0x0054C4C4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014F96 RID: 85910 RVA: 0x0054E2D4 File Offset: 0x0054C4D4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014F97 RID: 85911 RVA: 0x0054E2E4 File Offset: 0x0054C4E4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014F98 RID: 85912 RVA: 0x0054E2F4 File Offset: 0x0054C4F4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014F99 RID: 85913 RVA: 0x0054E304 File Offset: 0x0054C504
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014F9A RID: 85914 RVA: 0x0054E314 File Offset: 0x0054C514
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014F9B RID: 85915 RVA: 0x0054E324 File Offset: 0x0054C524
			public void __callDele_EventOnPointerDown()
			{
				this.m_owner.__callDele_EventOnPointerDown();
			}

			// Token: 0x06014F9C RID: 85916 RVA: 0x0054E334 File Offset: 0x0054C534
			public void __clearDele_EventOnPointerDown()
			{
				this.m_owner.__clearDele_EventOnPointerDown();
			}

			// Token: 0x06014F9D RID: 85917 RVA: 0x0054E344 File Offset: 0x0054C544
			public void __callDele_EventOnPointerUp()
			{
				this.m_owner.__callDele_EventOnPointerUp();
			}

			// Token: 0x06014F9E RID: 85918 RVA: 0x0054E354 File Offset: 0x0054C554
			public void __clearDele_EventOnPointerUp()
			{
				this.m_owner.__clearDele_EventOnPointerUp();
			}

			// Token: 0x06014F9F RID: 85919 RVA: 0x0054E364 File Offset: 0x0054C564
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x06014FA0 RID: 85920 RVA: 0x0054E374 File Offset: 0x0054C574
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x06014FA1 RID: 85921 RVA: 0x0054E384 File Offset: 0x0054C584
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400B727 RID: 46887
			private WorldScenarioUIController m_owner;
		}
	}
}
