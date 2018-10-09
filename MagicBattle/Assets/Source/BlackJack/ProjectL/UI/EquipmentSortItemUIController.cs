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
	// Token: 0x02000D57 RID: 3415
	[HotFix]
	public class EquipmentSortItemUIController : UIControllerBase
	{
		// Token: 0x0600FB7F RID: 64383 RVA: 0x0042226C File Offset: 0x0042046C
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
			base.gameObject.GetComponent<ToggleEx>().onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleValueChange));
		}

		// Token: 0x0600FB80 RID: 64384 RVA: 0x004222F4 File Offset: 0x004204F4
		public void InitEquipmentFilterItem(int sortTypeInt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEquipmentFilterItemInt32_hotfix != null)
			{
				this.m_InitEquipmentFilterItemInt32_hotfix.call(new object[]
				{
					this,
					sortTypeInt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sortTypeInt = sortTypeInt;
			this.FilterText = this.m_text.text;
		}

		// Token: 0x0600FB81 RID: 64385 RVA: 0x0042237C File Offset: 0x0042057C
		private void OnToggleValueChange(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleValueChangeBoolean_hotfix != null)
			{
				this.m_OnToggleValueChangeBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this, isOn);
			}
		}

		// Token: 0x14000353 RID: 851
		// (add) Token: 0x0600FB82 RID: 64386 RVA: 0x00422404 File Offset: 0x00420604
		// (remove) Token: 0x0600FB83 RID: 64387 RVA: 0x004224A0 File Offset: 0x004206A0
		public event Action<EquipmentSortItemUIController, bool> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`2_hotfix != null)
				{
					this.m_add_EventOnClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentSortItemUIController, bool> action = this.EventOnClick;
				Action<EquipmentSortItemUIController, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentSortItemUIController, bool>>(ref this.EventOnClick, (Action<EquipmentSortItemUIController, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EquipmentSortItemUIController, bool> action = this.EventOnClick;
				Action<EquipmentSortItemUIController, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EquipmentSortItemUIController, bool>>(ref this.EventOnClick, (Action<EquipmentSortItemUIController, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600FB84 RID: 64388 RVA: 0x0042253C File Offset: 0x0042073C
		// (set) Token: 0x0600FB85 RID: 64389 RVA: 0x0042255C File Offset: 0x0042075C
		[DoNotToLua]
		public new EquipmentSortItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentSortItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FB86 RID: 64390 RVA: 0x00422568 File Offset: 0x00420768
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600FB87 RID: 64391 RVA: 0x00422574 File Offset: 0x00420774
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600FB88 RID: 64392 RVA: 0x0042257C File Offset: 0x0042077C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600FB89 RID: 64393 RVA: 0x00422584 File Offset: 0x00420784
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600FB8A RID: 64394 RVA: 0x00422598 File Offset: 0x00420798
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600FB8B RID: 64395 RVA: 0x004225A0 File Offset: 0x004207A0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600FB8C RID: 64396 RVA: 0x004225AC File Offset: 0x004207AC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600FB8D RID: 64397 RVA: 0x004225B8 File Offset: 0x004207B8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600FB8E RID: 64398 RVA: 0x004225C4 File Offset: 0x004207C4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600FB8F RID: 64399 RVA: 0x004225D0 File Offset: 0x004207D0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600FB90 RID: 64400 RVA: 0x004225DC File Offset: 0x004207DC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600FB91 RID: 64401 RVA: 0x004225E8 File Offset: 0x004207E8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600FB92 RID: 64402 RVA: 0x004225F4 File Offset: 0x004207F4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600FB93 RID: 64403 RVA: 0x00422600 File Offset: 0x00420800
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600FB94 RID: 64404 RVA: 0x0042260C File Offset: 0x0042080C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600FB95 RID: 64405 RVA: 0x00422614 File Offset: 0x00420814
		private void __callDele_EventOnClick(EquipmentSortItemUIController arg1, bool arg2)
		{
			Action<EquipmentSortItemUIController, bool> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(arg1, arg2);
			}
		}

		// Token: 0x0600FB96 RID: 64406 RVA: 0x00422638 File Offset: 0x00420838
		private void __clearDele_EventOnClick(EquipmentSortItemUIController arg1, bool arg2)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600FB97 RID: 64407 RVA: 0x00422644 File Offset: 0x00420844
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
					this.m_InitEquipmentFilterItemInt32_hotfix = (luaObj.RawGet("InitEquipmentFilterItem") as LuaFunction);
					this.m_OnToggleValueChangeBoolean_hotfix = (luaObj.RawGet("OnToggleValueChange") as LuaFunction);
					this.m_add_EventOnClickAction`2_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FB98 RID: 64408 RVA: 0x00422774 File Offset: 0x00420974
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentSortItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009390 RID: 37776
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x04009391 RID: 37777
		public string FilterText;

		// Token: 0x04009392 RID: 37778
		public int m_sortTypeInt;

		// Token: 0x04009393 RID: 37779
		[DoNotToLua]
		private EquipmentSortItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009394 RID: 37780
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009395 RID: 37781
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009396 RID: 37782
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009397 RID: 37783
		private LuaFunction m_InitEquipmentFilterItemInt32_hotfix;

		// Token: 0x04009398 RID: 37784
		private LuaFunction m_OnToggleValueChangeBoolean_hotfix;

		// Token: 0x04009399 RID: 37785
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400939A RID: 37786
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000D58 RID: 3416
		public new class LuaExportHelper
		{
			// Token: 0x0600FB99 RID: 64409 RVA: 0x004227DC File Offset: 0x004209DC
			public LuaExportHelper(EquipmentSortItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FB9A RID: 64410 RVA: 0x004227EC File Offset: 0x004209EC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600FB9B RID: 64411 RVA: 0x004227FC File Offset: 0x004209FC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600FB9C RID: 64412 RVA: 0x0042280C File Offset: 0x00420A0C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600FB9D RID: 64413 RVA: 0x0042281C File Offset: 0x00420A1C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600FB9E RID: 64414 RVA: 0x00422834 File Offset: 0x00420A34
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600FB9F RID: 64415 RVA: 0x00422844 File Offset: 0x00420A44
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600FBA0 RID: 64416 RVA: 0x00422854 File Offset: 0x00420A54
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600FBA1 RID: 64417 RVA: 0x00422864 File Offset: 0x00420A64
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600FBA2 RID: 64418 RVA: 0x00422874 File Offset: 0x00420A74
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600FBA3 RID: 64419 RVA: 0x00422884 File Offset: 0x00420A84
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600FBA4 RID: 64420 RVA: 0x00422894 File Offset: 0x00420A94
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600FBA5 RID: 64421 RVA: 0x004228A4 File Offset: 0x00420AA4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600FBA6 RID: 64422 RVA: 0x004228B4 File Offset: 0x00420AB4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600FBA7 RID: 64423 RVA: 0x004228C4 File Offset: 0x00420AC4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600FBA8 RID: 64424 RVA: 0x004228D4 File Offset: 0x00420AD4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600FBA9 RID: 64425 RVA: 0x004228E4 File Offset: 0x00420AE4
			public void __callDele_EventOnClick(EquipmentSortItemUIController arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnClick(arg1, arg2);
			}

			// Token: 0x0600FBAA RID: 64426 RVA: 0x004228F4 File Offset: 0x00420AF4
			public void __clearDele_EventOnClick(EquipmentSortItemUIController arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnClick(arg1, arg2);
			}

			// Token: 0x17003006 RID: 12294
			// (get) Token: 0x0600FBAB RID: 64427 RVA: 0x00422904 File Offset: 0x00420B04
			// (set) Token: 0x0600FBAC RID: 64428 RVA: 0x00422914 File Offset: 0x00420B14
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

			// Token: 0x0600FBAD RID: 64429 RVA: 0x00422924 File Offset: 0x00420B24
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600FBAE RID: 64430 RVA: 0x00422934 File Offset: 0x00420B34
			public void OnToggleValueChange(bool isOn)
			{
				this.m_owner.OnToggleValueChange(isOn);
			}

			// Token: 0x0400939B RID: 37787
			private EquipmentSortItemUIController m_owner;
		}
	}
}
