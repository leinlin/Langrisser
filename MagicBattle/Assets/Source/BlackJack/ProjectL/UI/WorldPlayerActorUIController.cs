using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x0200102B RID: 4139
	[HotFix]
	public class WorldPlayerActorUIController : UIControllerBase
	{
		// Token: 0x06014F41 RID: 85825 RVA: 0x0054D568 File Offset: 0x0054B768
		private WorldPlayerActorUIController()
		{
		}

		// Token: 0x06014F42 RID: 85826 RVA: 0x0054D570 File Offset: 0x0054B770
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

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x06014F43 RID: 85827 RVA: 0x0054D5D8 File Offset: 0x0054B7D8
		// (set) Token: 0x06014F44 RID: 85828 RVA: 0x0054D5F8 File Offset: 0x0054B7F8
		[DoNotToLua]
		public new WorldPlayerActorUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldPlayerActorUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014F45 RID: 85829 RVA: 0x0054D604 File Offset: 0x0054B804
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014F46 RID: 85830 RVA: 0x0054D610 File Offset: 0x0054B810
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014F47 RID: 85831 RVA: 0x0054D618 File Offset: 0x0054B818
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014F48 RID: 85832 RVA: 0x0054D620 File Offset: 0x0054B820
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014F49 RID: 85833 RVA: 0x0054D634 File Offset: 0x0054B834
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014F4A RID: 85834 RVA: 0x0054D63C File Offset: 0x0054B83C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014F4B RID: 85835 RVA: 0x0054D648 File Offset: 0x0054B848
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014F4C RID: 85836 RVA: 0x0054D654 File Offset: 0x0054B854
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014F4D RID: 85837 RVA: 0x0054D660 File Offset: 0x0054B860
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014F4E RID: 85838 RVA: 0x0054D66C File Offset: 0x0054B86C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014F4F RID: 85839 RVA: 0x0054D678 File Offset: 0x0054B878
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014F50 RID: 85840 RVA: 0x0054D684 File Offset: 0x0054B884
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014F51 RID: 85841 RVA: 0x0054D690 File Offset: 0x0054B890
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014F52 RID: 85842 RVA: 0x0054D69C File Offset: 0x0054B89C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014F53 RID: 85843 RVA: 0x0054D6A8 File Offset: 0x0054B8A8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014F54 RID: 85844 RVA: 0x0054D6B0 File Offset: 0x0054B8B0
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014F55 RID: 85845 RVA: 0x0054D77C File Offset: 0x0054B97C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldPlayerActorUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B712 RID: 46866
		[DoNotToLua]
		private WorldPlayerActorUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B713 RID: 46867
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B714 RID: 46868
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B715 RID: 46869
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0200102C RID: 4140
		public new class LuaExportHelper
		{
			// Token: 0x06014F56 RID: 85846 RVA: 0x0054D7E4 File Offset: 0x0054B9E4
			public LuaExportHelper(WorldPlayerActorUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014F57 RID: 85847 RVA: 0x0054D7F4 File Offset: 0x0054B9F4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014F58 RID: 85848 RVA: 0x0054D804 File Offset: 0x0054BA04
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014F59 RID: 85849 RVA: 0x0054D814 File Offset: 0x0054BA14
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014F5A RID: 85850 RVA: 0x0054D824 File Offset: 0x0054BA24
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014F5B RID: 85851 RVA: 0x0054D83C File Offset: 0x0054BA3C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014F5C RID: 85852 RVA: 0x0054D84C File Offset: 0x0054BA4C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014F5D RID: 85853 RVA: 0x0054D85C File Offset: 0x0054BA5C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014F5E RID: 85854 RVA: 0x0054D86C File Offset: 0x0054BA6C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014F5F RID: 85855 RVA: 0x0054D87C File Offset: 0x0054BA7C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014F60 RID: 85856 RVA: 0x0054D88C File Offset: 0x0054BA8C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014F61 RID: 85857 RVA: 0x0054D89C File Offset: 0x0054BA9C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014F62 RID: 85858 RVA: 0x0054D8AC File Offset: 0x0054BAAC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014F63 RID: 85859 RVA: 0x0054D8BC File Offset: 0x0054BABC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014F64 RID: 85860 RVA: 0x0054D8CC File Offset: 0x0054BACC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014F65 RID: 85861 RVA: 0x0054D8DC File Offset: 0x0054BADC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014F66 RID: 85862 RVA: 0x0054D8EC File Offset: 0x0054BAEC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400B716 RID: 46870
			private WorldPlayerActorUIController m_owner;
		}
	}
}
