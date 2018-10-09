using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E99 RID: 3737
	[HotFix]
	public class PreloadUIController : UIControllerBase
	{
		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x06012421 RID: 74785 RVA: 0x004B197C File Offset: 0x004AFB7C
		// (set) Token: 0x06012422 RID: 74786 RVA: 0x004B199C File Offset: 0x004AFB9C
		[DoNotToLua]
		public new PreloadUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PreloadUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012423 RID: 74787 RVA: 0x004B19A8 File Offset: 0x004AFBA8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012424 RID: 74788 RVA: 0x004B19B4 File Offset: 0x004AFBB4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012425 RID: 74789 RVA: 0x004B19BC File Offset: 0x004AFBBC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012426 RID: 74790 RVA: 0x004B19C4 File Offset: 0x004AFBC4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012427 RID: 74791 RVA: 0x004B19D8 File Offset: 0x004AFBD8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012428 RID: 74792 RVA: 0x004B19E0 File Offset: 0x004AFBE0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012429 RID: 74793 RVA: 0x004B19EC File Offset: 0x004AFBEC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601242A RID: 74794 RVA: 0x004B19F8 File Offset: 0x004AFBF8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601242B RID: 74795 RVA: 0x004B1A04 File Offset: 0x004AFC04
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601242C RID: 74796 RVA: 0x004B1A10 File Offset: 0x004AFC10
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601242D RID: 74797 RVA: 0x004B1A1C File Offset: 0x004AFC1C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601242E RID: 74798 RVA: 0x004B1A28 File Offset: 0x004AFC28
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601242F RID: 74799 RVA: 0x004B1A34 File Offset: 0x004AFC34
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012430 RID: 74800 RVA: 0x004B1A40 File Offset: 0x004AFC40
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012431 RID: 74801 RVA: 0x004B1A4C File Offset: 0x004AFC4C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012432 RID: 74802 RVA: 0x004B1A54 File Offset: 0x004AFC54
		private bool InitHotFix(LuaTable A_1)
		{
			for (;;)
			{
				this.m_luaObjHelper = new BJLuaObjHelper();
				this.m_luaObjHelper.InitInCS(this, A_1);
				LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
				if (luaFunction == null)
				{
					break;
				}
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					goto Block_1;
				}
			}
			global::Debug.LogError("Can't find HotFixObject Func");
			return false;
			Block_1:
			return false;
		}

		// Token: 0x06012433 RID: 74803 RVA: 0x004B1B08 File Offset: 0x004AFD08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PreloadUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A494 RID: 42132
		[DoNotToLua]
		private PreloadUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A495 RID: 42133
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A496 RID: 42134
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x02000E9A RID: 3738
		public new class LuaExportHelper
		{
			// Token: 0x06012434 RID: 74804 RVA: 0x004B1B70 File Offset: 0x004AFD70
			public LuaExportHelper(PreloadUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012435 RID: 74805 RVA: 0x004B1B80 File Offset: 0x004AFD80
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012436 RID: 74806 RVA: 0x004B1B90 File Offset: 0x004AFD90
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012437 RID: 74807 RVA: 0x004B1BA0 File Offset: 0x004AFDA0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012438 RID: 74808 RVA: 0x004B1BB0 File Offset: 0x004AFDB0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012439 RID: 74809 RVA: 0x004B1BC8 File Offset: 0x004AFDC8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601243A RID: 74810 RVA: 0x004B1BD8 File Offset: 0x004AFDD8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601243B RID: 74811 RVA: 0x004B1BE8 File Offset: 0x004AFDE8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601243C RID: 74812 RVA: 0x004B1BF8 File Offset: 0x004AFDF8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601243D RID: 74813 RVA: 0x004B1C08 File Offset: 0x004AFE08
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601243E RID: 74814 RVA: 0x004B1C18 File Offset: 0x004AFE18
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601243F RID: 74815 RVA: 0x004B1C28 File Offset: 0x004AFE28
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012440 RID: 74816 RVA: 0x004B1C38 File Offset: 0x004AFE38
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012441 RID: 74817 RVA: 0x004B1C48 File Offset: 0x004AFE48
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012442 RID: 74818 RVA: 0x004B1C58 File Offset: 0x004AFE58
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012443 RID: 74819 RVA: 0x004B1C68 File Offset: 0x004AFE68
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0400A497 RID: 42135
			private PreloadUIController m_owner;
		}
	}
}
