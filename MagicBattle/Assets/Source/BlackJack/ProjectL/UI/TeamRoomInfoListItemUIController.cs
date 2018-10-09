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
	// Token: 0x02000F59 RID: 3929
	[HotFix]
	public class TeamRoomInfoListItemUIController : UIControllerBase
	{
		// Token: 0x060138E0 RID: 80096 RVA: 0x004FC910 File Offset: 0x004FAB10
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnButtonClick));
		}

		// Token: 0x060138E1 RID: 80097 RVA: 0x004FC994 File Offset: 0x004FAB94
		public void SetText(string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTextString_hotfix != null)
			{
				this.m_SetTextString_hotfix.call(new object[]
				{
					this,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_text.text = text;
		}

		// Token: 0x060138E2 RID: 80098 RVA: 0x004FCA10 File Offset: 0x004FAC10
		public void SetTextAlpha(float a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTextAlphaSingle_hotfix != null)
			{
				this.m_SetTextAlphaSingle_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Color color = this.m_text.color;
			color.a = a;
			this.m_text.color = color;
		}

		// Token: 0x060138E3 RID: 80099 RVA: 0x004FCAA0 File Offset: 0x004FACA0
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

		// Token: 0x060138E4 RID: 80100 RVA: 0x004FCB18 File Offset: 0x004FAD18
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

		// Token: 0x060138E5 RID: 80101 RVA: 0x004FCB8C File Offset: 0x004FAD8C
		public void SetValue(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetValueInt32_hotfix != null)
			{
				this.m_SetValueInt32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_value = value;
		}

		// Token: 0x060138E6 RID: 80102 RVA: 0x004FCC04 File Offset: 0x004FAE04
		public int GetValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetValue_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetValue_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_value;
		}

		// Token: 0x060138E7 RID: 80103 RVA: 0x004FCC78 File Offset: 0x004FAE78
		public void SetValue2(int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetValue2Int32_hotfix != null)
			{
				this.m_SetValue2Int32_hotfix.call(new object[]
				{
					this,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_value2 = value;
		}

		// Token: 0x060138E8 RID: 80104 RVA: 0x004FCCF0 File Offset: 0x004FAEF0
		public int GetValue2()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetValue2_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetValue2_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_value2;
		}

		// Token: 0x060138E9 RID: 80105 RVA: 0x004FCD64 File Offset: 0x004FAF64
		public void SetLocked(bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lockGameObject.SetActive(isLocked);
			this.m_isLocked = isLocked;
		}

		// Token: 0x060138EA RID: 80106 RVA: 0x004FCDE8 File Offset: 0x004FAFE8
		public bool IsLocked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLocked_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLocked_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isLocked;
		}

		// Token: 0x060138EB RID: 80107 RVA: 0x004FCE5C File Offset: 0x004FB05C
		private void OnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnButtonClick_hotfix != null)
			{
				this.m_OnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnButtonClick != null)
			{
				this.EventOnButtonClick(this);
			}
		}

		// Token: 0x14000443 RID: 1091
		// (add) Token: 0x060138EC RID: 80108 RVA: 0x004FCED4 File Offset: 0x004FB0D4
		// (remove) Token: 0x060138ED RID: 80109 RVA: 0x004FCF70 File Offset: 0x004FB170
		public event Action<TeamRoomInfoListItemUIController> EventOnButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomInfoListItemUIController> action = this.EventOnButtonClick;
				Action<TeamRoomInfoListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomInfoListItemUIController>>(ref this.EventOnButtonClick, (Action<TeamRoomInfoListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomInfoListItemUIController> action = this.EventOnButtonClick;
				Action<TeamRoomInfoListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomInfoListItemUIController>>(ref this.EventOnButtonClick, (Action<TeamRoomInfoListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x060138EE RID: 80110 RVA: 0x004FD00C File Offset: 0x004FB20C
		// (set) Token: 0x060138EF RID: 80111 RVA: 0x004FD02C File Offset: 0x004FB22C
		[DoNotToLua]
		public new TeamRoomInfoListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomInfoListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060138F0 RID: 80112 RVA: 0x004FD038 File Offset: 0x004FB238
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060138F1 RID: 80113 RVA: 0x004FD044 File Offset: 0x004FB244
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060138F2 RID: 80114 RVA: 0x004FD04C File Offset: 0x004FB24C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060138F3 RID: 80115 RVA: 0x004FD054 File Offset: 0x004FB254
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060138F4 RID: 80116 RVA: 0x004FD068 File Offset: 0x004FB268
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060138F5 RID: 80117 RVA: 0x004FD070 File Offset: 0x004FB270
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060138F6 RID: 80118 RVA: 0x004FD07C File Offset: 0x004FB27C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060138F7 RID: 80119 RVA: 0x004FD088 File Offset: 0x004FB288
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060138F8 RID: 80120 RVA: 0x004FD094 File Offset: 0x004FB294
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060138F9 RID: 80121 RVA: 0x004FD0A0 File Offset: 0x004FB2A0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060138FA RID: 80122 RVA: 0x004FD0AC File Offset: 0x004FB2AC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060138FB RID: 80123 RVA: 0x004FD0B8 File Offset: 0x004FB2B8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060138FC RID: 80124 RVA: 0x004FD0C4 File Offset: 0x004FB2C4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060138FD RID: 80125 RVA: 0x004FD0D0 File Offset: 0x004FB2D0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060138FE RID: 80126 RVA: 0x004FD0DC File Offset: 0x004FB2DC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060138FF RID: 80127 RVA: 0x004FD0E4 File Offset: 0x004FB2E4
		private void __callDele_EventOnButtonClick(TeamRoomInfoListItemUIController obj)
		{
			Action<TeamRoomInfoListItemUIController> eventOnButtonClick = this.EventOnButtonClick;
			if (eventOnButtonClick != null)
			{
				eventOnButtonClick(obj);
			}
		}

		// Token: 0x06013900 RID: 80128 RVA: 0x004FD108 File Offset: 0x004FB308
		private void __clearDele_EventOnButtonClick(TeamRoomInfoListItemUIController obj)
		{
			this.EventOnButtonClick = null;
		}

		// Token: 0x06013901 RID: 80129 RVA: 0x004FD114 File Offset: 0x004FB314
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
					this.m_SetTextString_hotfix = (luaObj.RawGet("SetText") as LuaFunction);
					this.m_SetTextAlphaSingle_hotfix = (luaObj.RawGet("SetTextAlpha") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_SetValueInt32_hotfix = (luaObj.RawGet("SetValue") as LuaFunction);
					this.m_GetValue_hotfix = (luaObj.RawGet("GetValue") as LuaFunction);
					this.m_SetValue2Int32_hotfix = (luaObj.RawGet("SetValue2") as LuaFunction);
					this.m_GetValue2_hotfix = (luaObj.RawGet("GetValue2") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_IsLocked_hotfix = (luaObj.RawGet("IsLocked") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnButtonClick") as LuaFunction);
					this.m_remove_EventOnButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013902 RID: 80130 RVA: 0x004FD324 File Offset: 0x004FB524
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInfoListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AD98 RID: 44440
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400AD99 RID: 44441
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x0400AD9A RID: 44442
		[AutoBind("./LockImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lockGameObject;

		// Token: 0x0400AD9B RID: 44443
		private int m_index;

		// Token: 0x0400AD9C RID: 44444
		private int m_value;

		// Token: 0x0400AD9D RID: 44445
		private int m_value2;

		// Token: 0x0400AD9E RID: 44446
		private bool m_isLocked;

		// Token: 0x0400AD9F RID: 44447
		[DoNotToLua]
		private TeamRoomInfoListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400ADA0 RID: 44448
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400ADA1 RID: 44449
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400ADA2 RID: 44450
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400ADA3 RID: 44451
		private LuaFunction m_SetTextString_hotfix;

		// Token: 0x0400ADA4 RID: 44452
		private LuaFunction m_SetTextAlphaSingle_hotfix;

		// Token: 0x0400ADA5 RID: 44453
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x0400ADA6 RID: 44454
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x0400ADA7 RID: 44455
		private LuaFunction m_SetValueInt32_hotfix;

		// Token: 0x0400ADA8 RID: 44456
		private LuaFunction m_GetValue_hotfix;

		// Token: 0x0400ADA9 RID: 44457
		private LuaFunction m_SetValue2Int32_hotfix;

		// Token: 0x0400ADAA RID: 44458
		private LuaFunction m_GetValue2_hotfix;

		// Token: 0x0400ADAB RID: 44459
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400ADAC RID: 44460
		private LuaFunction m_IsLocked_hotfix;

		// Token: 0x0400ADAD RID: 44461
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x0400ADAE RID: 44462
		private LuaFunction m_add_EventOnButtonClickAction;

		// Token: 0x0400ADAF RID: 44463
		private LuaFunction m_remove_EventOnButtonClickAction;

		// Token: 0x02000F5A RID: 3930
		public new class LuaExportHelper
		{
			// Token: 0x06013903 RID: 80131 RVA: 0x004FD38C File Offset: 0x004FB58C
			public LuaExportHelper(TeamRoomInfoListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013904 RID: 80132 RVA: 0x004FD39C File Offset: 0x004FB59C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013905 RID: 80133 RVA: 0x004FD3AC File Offset: 0x004FB5AC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013906 RID: 80134 RVA: 0x004FD3BC File Offset: 0x004FB5BC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013907 RID: 80135 RVA: 0x004FD3CC File Offset: 0x004FB5CC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013908 RID: 80136 RVA: 0x004FD3E4 File Offset: 0x004FB5E4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013909 RID: 80137 RVA: 0x004FD3F4 File Offset: 0x004FB5F4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601390A RID: 80138 RVA: 0x004FD404 File Offset: 0x004FB604
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601390B RID: 80139 RVA: 0x004FD414 File Offset: 0x004FB614
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601390C RID: 80140 RVA: 0x004FD424 File Offset: 0x004FB624
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601390D RID: 80141 RVA: 0x004FD434 File Offset: 0x004FB634
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601390E RID: 80142 RVA: 0x004FD444 File Offset: 0x004FB644
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601390F RID: 80143 RVA: 0x004FD454 File Offset: 0x004FB654
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013910 RID: 80144 RVA: 0x004FD464 File Offset: 0x004FB664
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013911 RID: 80145 RVA: 0x004FD474 File Offset: 0x004FB674
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013912 RID: 80146 RVA: 0x004FD484 File Offset: 0x004FB684
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013913 RID: 80147 RVA: 0x004FD494 File Offset: 0x004FB694
			public void __callDele_EventOnButtonClick(TeamRoomInfoListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnButtonClick(obj);
			}

			// Token: 0x06013914 RID: 80148 RVA: 0x004FD4A4 File Offset: 0x004FB6A4
			public void __clearDele_EventOnButtonClick(TeamRoomInfoListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnButtonClick(obj);
			}

			// Token: 0x17003ABF RID: 15039
			// (get) Token: 0x06013915 RID: 80149 RVA: 0x004FD4B4 File Offset: 0x004FB6B4
			// (set) Token: 0x06013916 RID: 80150 RVA: 0x004FD4C4 File Offset: 0x004FB6C4
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

			// Token: 0x17003AC0 RID: 15040
			// (get) Token: 0x06013917 RID: 80151 RVA: 0x004FD4D4 File Offset: 0x004FB6D4
			// (set) Token: 0x06013918 RID: 80152 RVA: 0x004FD4E4 File Offset: 0x004FB6E4
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

			// Token: 0x17003AC1 RID: 15041
			// (get) Token: 0x06013919 RID: 80153 RVA: 0x004FD4F4 File Offset: 0x004FB6F4
			// (set) Token: 0x0601391A RID: 80154 RVA: 0x004FD504 File Offset: 0x004FB704
			public GameObject m_lockGameObject
			{
				get
				{
					return this.m_owner.m_lockGameObject;
				}
				set
				{
					this.m_owner.m_lockGameObject = value;
				}
			}

			// Token: 0x17003AC2 RID: 15042
			// (get) Token: 0x0601391B RID: 80155 RVA: 0x004FD514 File Offset: 0x004FB714
			// (set) Token: 0x0601391C RID: 80156 RVA: 0x004FD524 File Offset: 0x004FB724
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

			// Token: 0x17003AC3 RID: 15043
			// (get) Token: 0x0601391D RID: 80157 RVA: 0x004FD534 File Offset: 0x004FB734
			// (set) Token: 0x0601391E RID: 80158 RVA: 0x004FD544 File Offset: 0x004FB744
			public int m_value
			{
				get
				{
					return this.m_owner.m_value;
				}
				set
				{
					this.m_owner.m_value = value;
				}
			}

			// Token: 0x17003AC4 RID: 15044
			// (get) Token: 0x0601391F RID: 80159 RVA: 0x004FD554 File Offset: 0x004FB754
			// (set) Token: 0x06013920 RID: 80160 RVA: 0x004FD564 File Offset: 0x004FB764
			public int m_value2
			{
				get
				{
					return this.m_owner.m_value2;
				}
				set
				{
					this.m_owner.m_value2 = value;
				}
			}

			// Token: 0x17003AC5 RID: 15045
			// (get) Token: 0x06013921 RID: 80161 RVA: 0x004FD574 File Offset: 0x004FB774
			// (set) Token: 0x06013922 RID: 80162 RVA: 0x004FD584 File Offset: 0x004FB784
			public bool m_isLocked
			{
				get
				{
					return this.m_owner.m_isLocked;
				}
				set
				{
					this.m_owner.m_isLocked = value;
				}
			}

			// Token: 0x06013923 RID: 80163 RVA: 0x004FD594 File Offset: 0x004FB794
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013924 RID: 80164 RVA: 0x004FD5A4 File Offset: 0x004FB7A4
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x0400ADB0 RID: 44464
			private TeamRoomInfoListItemUIController m_owner;
		}
	}
}
