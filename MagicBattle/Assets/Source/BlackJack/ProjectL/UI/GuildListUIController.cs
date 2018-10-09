using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CF3 RID: 3315
	[HotFix]
	public class GuildListUIController : UIControllerBase
	{
		// Token: 0x0600F2AC RID: 62124 RVA: 0x004066D4 File Offset: 0x004048D4
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600F2AD RID: 62125 RVA: 0x00406764 File Offset: 0x00404964
		// (set) Token: 0x0600F2AE RID: 62126 RVA: 0x00406784 File Offset: 0x00404984
		[DoNotToLua]
		public new GuildListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F2AF RID: 62127 RVA: 0x00406790 File Offset: 0x00404990
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x0040679C File Offset: 0x0040499C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F2B1 RID: 62129 RVA: 0x004067A4 File Offset: 0x004049A4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F2B2 RID: 62130 RVA: 0x004067AC File Offset: 0x004049AC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F2B3 RID: 62131 RVA: 0x004067C0 File Offset: 0x004049C0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F2B4 RID: 62132 RVA: 0x004067C8 File Offset: 0x004049C8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x004067D4 File Offset: 0x004049D4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x004067E0 File Offset: 0x004049E0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F2B7 RID: 62135 RVA: 0x004067EC File Offset: 0x004049EC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F2B8 RID: 62136 RVA: 0x004067F8 File Offset: 0x004049F8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F2B9 RID: 62137 RVA: 0x00406804 File Offset: 0x00404A04
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F2BA RID: 62138 RVA: 0x00406810 File Offset: 0x00404A10
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F2BB RID: 62139 RVA: 0x0040681C File Offset: 0x00404A1C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F2BC RID: 62140 RVA: 0x00406828 File Offset: 0x00404A28
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F2BD RID: 62141 RVA: 0x00406834 File Offset: 0x00404A34
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F2BE RID: 62142 RVA: 0x0040683C File Offset: 0x00404A3C
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

		// Token: 0x0600F2BF RID: 62143 RVA: 0x00406908 File Offset: 0x00404B08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008FF1 RID: 36849
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008FF2 RID: 36850
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008FF3 RID: 36851
		[DoNotToLua]
		private GuildListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008FF4 RID: 36852
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008FF5 RID: 36853
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008FF6 RID: 36854
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x02000CF4 RID: 3316
		public new class LuaExportHelper
		{
			// Token: 0x0600F2C0 RID: 62144 RVA: 0x00406970 File Offset: 0x00404B70
			public LuaExportHelper(GuildListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F2C1 RID: 62145 RVA: 0x00406980 File Offset: 0x00404B80
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F2C2 RID: 62146 RVA: 0x00406990 File Offset: 0x00404B90
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F2C3 RID: 62147 RVA: 0x004069A0 File Offset: 0x00404BA0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F2C4 RID: 62148 RVA: 0x004069B0 File Offset: 0x00404BB0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F2C5 RID: 62149 RVA: 0x004069C8 File Offset: 0x00404BC8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F2C6 RID: 62150 RVA: 0x004069D8 File Offset: 0x00404BD8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F2C7 RID: 62151 RVA: 0x004069E8 File Offset: 0x00404BE8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F2C8 RID: 62152 RVA: 0x004069F8 File Offset: 0x00404BF8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F2C9 RID: 62153 RVA: 0x00406A08 File Offset: 0x00404C08
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F2CA RID: 62154 RVA: 0x00406A18 File Offset: 0x00404C18
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F2CB RID: 62155 RVA: 0x00406A28 File Offset: 0x00404C28
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F2CC RID: 62156 RVA: 0x00406A38 File Offset: 0x00404C38
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F2CD RID: 62157 RVA: 0x00406A48 File Offset: 0x00404C48
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F2CE RID: 62158 RVA: 0x00406A58 File Offset: 0x00404C58
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F2CF RID: 62159 RVA: 0x00406A68 File Offset: 0x00404C68
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002E96 RID: 11926
			// (get) Token: 0x0600F2D0 RID: 62160 RVA: 0x00406A78 File Offset: 0x00404C78
			// (set) Token: 0x0600F2D1 RID: 62161 RVA: 0x00406A88 File Offset: 0x00404C88
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002E97 RID: 11927
			// (get) Token: 0x0600F2D2 RID: 62162 RVA: 0x00406A98 File Offset: 0x00404C98
			// (set) Token: 0x0600F2D3 RID: 62163 RVA: 0x00406AA8 File Offset: 0x00404CA8
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x0600F2D4 RID: 62164 RVA: 0x00406AB8 File Offset: 0x00404CB8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04008FF7 RID: 36855
			private GuildListUIController m_owner;
		}
	}
}
