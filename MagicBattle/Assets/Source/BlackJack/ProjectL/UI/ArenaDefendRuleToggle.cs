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
	// Token: 0x02000A02 RID: 2562
	[HotFix]
	public class ArenaDefendRuleToggle : UIControllerBase
	{
		// Token: 0x06009A02 RID: 39426 RVA: 0x002BEA94 File Offset: 0x002BCC94
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

		// Token: 0x06009A03 RID: 39427 RVA: 0x002BEAFC File Offset: 0x002BCCFC
		public void SetArenaDefendRuleInfo(ConfigDataArenaDefendRuleInfo ruleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaDefendRuleInfoConfigDataArenaDefendRuleInfo_hotfix != null)
			{
				this.m_SetArenaDefendRuleInfoConfigDataArenaDefendRuleInfo_hotfix.call(new object[]
				{
					this,
					ruleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = ruleInfo.Name;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(ruleInfo.Icon);
			this.m_descText.text = ruleInfo.WinDesc;
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x002BEBAC File Offset: 0x002BCDAC
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

		// Token: 0x06009A05 RID: 39429 RVA: 0x002BEC28 File Offset: 0x002BCE28
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

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06009A06 RID: 39430 RVA: 0x002BECA0 File Offset: 0x002BCEA0
		// (set) Token: 0x06009A07 RID: 39431 RVA: 0x002BECC0 File Offset: 0x002BCEC0
		[DoNotToLua]
		public new ArenaDefendRuleToggle.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendRuleToggle.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x002BECCC File Offset: 0x002BCECC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009A09 RID: 39433 RVA: 0x002BECD8 File Offset: 0x002BCED8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x002BECE0 File Offset: 0x002BCEE0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x002BECE8 File Offset: 0x002BCEE8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009A0C RID: 39436 RVA: 0x002BECFC File Offset: 0x002BCEFC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x002BED04 File Offset: 0x002BCF04
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x002BED10 File Offset: 0x002BCF10
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x002BED1C File Offset: 0x002BCF1C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x002BED28 File Offset: 0x002BCF28
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x002BED34 File Offset: 0x002BCF34
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x002BED40 File Offset: 0x002BCF40
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x002BED4C File Offset: 0x002BCF4C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x002BED58 File Offset: 0x002BCF58
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x002BED64 File Offset: 0x002BCF64
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x002BED70 File Offset: 0x002BCF70
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x002BED78 File Offset: 0x002BCF78
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
					this.m_SetArenaDefendRuleInfoConfigDataArenaDefendRuleInfo_hotfix = (luaObj.RawGet("SetArenaDefendRuleInfo") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_IsSelected_hotfix = (luaObj.RawGet("IsSelected") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x002BEE90 File Offset: 0x002BD090
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendRuleToggle));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006958 RID: 26968
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x04006959 RID: 26969
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400695A RID: 26970
		[AutoBind("./Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400695B RID: 26971
		[AutoBind("./DetailText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x0400695C RID: 26972
		[DoNotToLua]
		private ArenaDefendRuleToggle.LuaExportHelper luaExportHelper;

		// Token: 0x0400695D RID: 26973
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400695E RID: 26974
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400695F RID: 26975
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006960 RID: 26976
		private LuaFunction m_SetArenaDefendRuleInfoConfigDataArenaDefendRuleInfo_hotfix;

		// Token: 0x04006961 RID: 26977
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x04006962 RID: 26978
		private LuaFunction m_IsSelected_hotfix;

		// Token: 0x02000A03 RID: 2563
		public new class LuaExportHelper
		{
			// Token: 0x06009A19 RID: 39449 RVA: 0x002BEEF8 File Offset: 0x002BD0F8
			public LuaExportHelper(ArenaDefendRuleToggle owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009A1A RID: 39450 RVA: 0x002BEF08 File Offset: 0x002BD108
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009A1B RID: 39451 RVA: 0x002BEF18 File Offset: 0x002BD118
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009A1C RID: 39452 RVA: 0x002BEF28 File Offset: 0x002BD128
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009A1D RID: 39453 RVA: 0x002BEF38 File Offset: 0x002BD138
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009A1E RID: 39454 RVA: 0x002BEF50 File Offset: 0x002BD150
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009A1F RID: 39455 RVA: 0x002BEF60 File Offset: 0x002BD160
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009A20 RID: 39456 RVA: 0x002BEF70 File Offset: 0x002BD170
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009A21 RID: 39457 RVA: 0x002BEF80 File Offset: 0x002BD180
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009A22 RID: 39458 RVA: 0x002BEF90 File Offset: 0x002BD190
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009A23 RID: 39459 RVA: 0x002BEFA0 File Offset: 0x002BD1A0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009A24 RID: 39460 RVA: 0x002BEFB0 File Offset: 0x002BD1B0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009A25 RID: 39461 RVA: 0x002BEFC0 File Offset: 0x002BD1C0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009A26 RID: 39462 RVA: 0x002BEFD0 File Offset: 0x002BD1D0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009A27 RID: 39463 RVA: 0x002BEFE0 File Offset: 0x002BD1E0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009A28 RID: 39464 RVA: 0x002BEFF0 File Offset: 0x002BD1F0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001F88 RID: 8072
			// (get) Token: 0x06009A29 RID: 39465 RVA: 0x002BF000 File Offset: 0x002BD200
			// (set) Token: 0x06009A2A RID: 39466 RVA: 0x002BF010 File Offset: 0x002BD210
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

			// Token: 0x17001F89 RID: 8073
			// (get) Token: 0x06009A2B RID: 39467 RVA: 0x002BF020 File Offset: 0x002BD220
			// (set) Token: 0x06009A2C RID: 39468 RVA: 0x002BF030 File Offset: 0x002BD230
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

			// Token: 0x17001F8A RID: 8074
			// (get) Token: 0x06009A2D RID: 39469 RVA: 0x002BF040 File Offset: 0x002BD240
			// (set) Token: 0x06009A2E RID: 39470 RVA: 0x002BF050 File Offset: 0x002BD250
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x17001F8B RID: 8075
			// (get) Token: 0x06009A2F RID: 39471 RVA: 0x002BF060 File Offset: 0x002BD260
			// (set) Token: 0x06009A30 RID: 39472 RVA: 0x002BF070 File Offset: 0x002BD270
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x06009A31 RID: 39473 RVA: 0x002BF080 File Offset: 0x002BD280
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006963 RID: 26979
			private ArenaDefendRuleToggle m_owner;
		}
	}
}
