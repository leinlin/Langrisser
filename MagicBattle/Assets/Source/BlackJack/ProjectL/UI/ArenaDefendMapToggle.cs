using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A00 RID: 2560
	[HotFix]
	public class ArenaDefendMapToggle : UIControllerBase
	{
		// Token: 0x060099D3 RID: 39379 RVA: 0x002BE4C4 File Offset: 0x002BC6C4
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

		// Token: 0x060099D4 RID: 39380 RVA: 0x002BE52C File Offset: 0x002BC72C
		public void SetArenaBattleInfo(ConfigDataArenaBattleInfo battleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaBattleInfoConfigDataArenaBattleInfo_hotfix != null)
			{
				this.m_SetArenaBattleInfoConfigDataArenaBattleInfo_hotfix.call(new object[]
				{
					this,
					battleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_image.sprite = AssetUtility.Instance.GetSprite(battleInfo.Image);
			this.m_nameText.text = battleInfo.Name;
		}

		// Token: 0x060099D5 RID: 39381 RVA: 0x002BE5C8 File Offset: 0x002BC7C8
		public void SetSelected(bool selected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectedBoolean_hotfix != null)
			{
				this.m_SetSelectedBoolean_hotfix.call(new object[]
				{
					this,
					selected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_toggle.isOn = selected;
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x002BE644 File Offset: 0x002BC844
		public bool IsSelected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSelected_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSelected_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_toggle.isOn;
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x060099D7 RID: 39383 RVA: 0x002BE6BC File Offset: 0x002BC8BC
		// (set) Token: 0x060099D8 RID: 39384 RVA: 0x002BE6DC File Offset: 0x002BC8DC
		[DoNotToLua]
		public new ArenaDefendMapToggle.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendMapToggle.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x002BE6E8 File Offset: 0x002BC8E8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x002BE6F4 File Offset: 0x002BC8F4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x002BE6FC File Offset: 0x002BC8FC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x002BE704 File Offset: 0x002BC904
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x002BE718 File Offset: 0x002BC918
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x002BE720 File Offset: 0x002BC920
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060099DF RID: 39391 RVA: 0x002BE72C File Offset: 0x002BC92C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x002BE738 File Offset: 0x002BC938
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x002BE744 File Offset: 0x002BC944
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x002BE750 File Offset: 0x002BC950
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060099E3 RID: 39395 RVA: 0x002BE75C File Offset: 0x002BC95C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x002BE768 File Offset: 0x002BC968
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060099E5 RID: 39397 RVA: 0x002BE774 File Offset: 0x002BC974
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060099E6 RID: 39398 RVA: 0x002BE780 File Offset: 0x002BC980
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060099E7 RID: 39399 RVA: 0x002BE78C File Offset: 0x002BC98C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060099E8 RID: 39400 RVA: 0x002BE794 File Offset: 0x002BC994
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
					this.m_SetArenaBattleInfoConfigDataArenaBattleInfo_hotfix = (luaObj.RawGet("SetArenaBattleInfo") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_IsSelected_hotfix = (luaObj.RawGet("IsSelected") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x002BE8AC File Offset: 0x002BCAAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendMapToggle));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400694D RID: 26957
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400694E RID: 26958
		[AutoBind("./MapImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400694F RID: 26959
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04006950 RID: 26960
		[DoNotToLua]
		private ArenaDefendMapToggle.LuaExportHelper luaExportHelper;

		// Token: 0x04006951 RID: 26961
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006952 RID: 26962
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006953 RID: 26963
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006954 RID: 26964
		private LuaFunction m_SetArenaBattleInfoConfigDataArenaBattleInfo_hotfix;

		// Token: 0x04006955 RID: 26965
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x04006956 RID: 26966
		private LuaFunction m_IsSelected_hotfix;

		// Token: 0x02000A01 RID: 2561
		public new class LuaExportHelper
		{
			// Token: 0x060099EA RID: 39402 RVA: 0x002BE914 File Offset: 0x002BCB14
			public LuaExportHelper(ArenaDefendMapToggle owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060099EB RID: 39403 RVA: 0x002BE924 File Offset: 0x002BCB24
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060099EC RID: 39404 RVA: 0x002BE934 File Offset: 0x002BCB34
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060099ED RID: 39405 RVA: 0x002BE944 File Offset: 0x002BCB44
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060099EE RID: 39406 RVA: 0x002BE954 File Offset: 0x002BCB54
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060099EF RID: 39407 RVA: 0x002BE96C File Offset: 0x002BCB6C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060099F0 RID: 39408 RVA: 0x002BE97C File Offset: 0x002BCB7C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060099F1 RID: 39409 RVA: 0x002BE98C File Offset: 0x002BCB8C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060099F2 RID: 39410 RVA: 0x002BE99C File Offset: 0x002BCB9C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060099F3 RID: 39411 RVA: 0x002BE9AC File Offset: 0x002BCBAC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060099F4 RID: 39412 RVA: 0x002BE9BC File Offset: 0x002BCBBC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060099F5 RID: 39413 RVA: 0x002BE9CC File Offset: 0x002BCBCC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060099F6 RID: 39414 RVA: 0x002BE9DC File Offset: 0x002BCBDC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060099F7 RID: 39415 RVA: 0x002BE9EC File Offset: 0x002BCBEC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060099F8 RID: 39416 RVA: 0x002BE9FC File Offset: 0x002BCBFC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060099F9 RID: 39417 RVA: 0x002BEA0C File Offset: 0x002BCC0C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001F84 RID: 8068
			// (get) Token: 0x060099FA RID: 39418 RVA: 0x002BEA1C File Offset: 0x002BCC1C
			// (set) Token: 0x060099FB RID: 39419 RVA: 0x002BEA2C File Offset: 0x002BCC2C
			public Toggle m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17001F85 RID: 8069
			// (get) Token: 0x060099FC RID: 39420 RVA: 0x002BEA3C File Offset: 0x002BCC3C
			// (set) Token: 0x060099FD RID: 39421 RVA: 0x002BEA4C File Offset: 0x002BCC4C
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x17001F86 RID: 8070
			// (get) Token: 0x060099FE RID: 39422 RVA: 0x002BEA5C File Offset: 0x002BCC5C
			// (set) Token: 0x060099FF RID: 39423 RVA: 0x002BEA6C File Offset: 0x002BCC6C
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x06009A00 RID: 39424 RVA: 0x002BEA7C File Offset: 0x002BCC7C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006957 RID: 26967
			private ArenaDefendMapToggle m_owner;
		}
	}
}
