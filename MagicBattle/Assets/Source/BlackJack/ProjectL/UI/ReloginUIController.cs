using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E56 RID: 3670
	[HotFix]
	public class ReloginUIController : UIControllerBase
	{
		// Token: 0x06011C4A RID: 72778 RVA: 0x00499518 File Offset: 0x00497718
		private ReloginUIController()
		{
		}

		// Token: 0x06011C4B RID: 72779 RVA: 0x00499520 File Offset: 0x00497720
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

		// Token: 0x06011C4C RID: 72780 RVA: 0x00499588 File Offset: 0x00497788
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", null, false, true);
		}

		// Token: 0x06011C4D RID: 72781 RVA: 0x004995FC File Offset: 0x004977FC
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
		}

		// Token: 0x06011C4E RID: 72782 RVA: 0x00499670 File Offset: 0x00497870
		public void ShowWaitForReloginConfirm()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitForReloginConfirm_hotfix != null)
			{
				this.m_ShowWaitForReloginConfirm_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_waitingGameObject.SetActive(false);
			this.m_dialogBoxGameObject.SetActive(true);
			this.RetryLoginButton.gameObject.SetActive(true);
			this.ReturnToLoginButton.gameObject.SetActive(true);
		}

		// Token: 0x06011C4F RID: 72783 RVA: 0x0049970C File Offset: 0x0049790C
		public void ShowWaitForReloginProcessing()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitForReloginProcessing_hotfix != null)
			{
				this.m_ShowWaitForReloginProcessing_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dialogBoxGameObject.SetActive(false);
			this.m_waitingGameObject.SetActive(true);
			UIUtility.ReplayTween(this.m_waitingGameObject, null);
		}

		// Token: 0x06011C50 RID: 72784 RVA: 0x00499790 File Offset: 0x00497990
		public void ShowWaitReturnToLoginConfirm()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitReturnToLoginConfirm_hotfix != null)
			{
				this.m_ShowWaitReturnToLoginConfirm_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_waitingGameObject.SetActive(false);
			this.m_dialogBoxGameObject.SetActive(true);
			this.RetryLoginButton.gameObject.SetActive(false);
			this.ReturnToLoginButton.gameObject.SetActive(true);
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x06011C51 RID: 72785 RVA: 0x0049982C File Offset: 0x00497A2C
		// (set) Token: 0x06011C52 RID: 72786 RVA: 0x0049984C File Offset: 0x00497A4C
		[DoNotToLua]
		public new ReloginUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ReloginUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011C53 RID: 72787 RVA: 0x00499858 File Offset: 0x00497A58
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011C54 RID: 72788 RVA: 0x00499864 File Offset: 0x00497A64
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011C55 RID: 72789 RVA: 0x0049986C File Offset: 0x00497A6C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011C56 RID: 72790 RVA: 0x00499874 File Offset: 0x00497A74
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011C57 RID: 72791 RVA: 0x00499888 File Offset: 0x00497A88
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011C58 RID: 72792 RVA: 0x00499890 File Offset: 0x00497A90
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011C59 RID: 72793 RVA: 0x0049989C File Offset: 0x00497A9C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011C5A RID: 72794 RVA: 0x004998A8 File Offset: 0x00497AA8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011C5B RID: 72795 RVA: 0x004998B4 File Offset: 0x00497AB4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011C5C RID: 72796 RVA: 0x004998C0 File Offset: 0x00497AC0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011C5D RID: 72797 RVA: 0x004998CC File Offset: 0x00497ACC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011C5E RID: 72798 RVA: 0x004998D8 File Offset: 0x00497AD8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011C5F RID: 72799 RVA: 0x004998E4 File Offset: 0x00497AE4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011C60 RID: 72800 RVA: 0x004998F0 File Offset: 0x00497AF0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011C61 RID: 72801 RVA: 0x004998FC File Offset: 0x00497AFC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011C62 RID: 72802 RVA: 0x00499904 File Offset: 0x00497B04
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_ShowWaitForReloginConfirm_hotfix = (luaObj.RawGet("ShowWaitForReloginConfirm") as LuaFunction);
					this.m_ShowWaitForReloginProcessing_hotfix = (luaObj.RawGet("ShowWaitForReloginProcessing") as LuaFunction);
					this.m_ShowWaitReturnToLoginConfirm_hotfix = (luaObj.RawGet("ShowWaitReturnToLoginConfirm") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011C63 RID: 72803 RVA: 0x00499A4C File Offset: 0x00497C4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ReloginUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A1C8 RID: 41416
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A1C9 RID: 41417
		[AutoBind("./DialogBox", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dialogBoxGameObject;

		// Token: 0x0400A1CA RID: 41418
		[AutoBind("./DialogBox/Buttons/RetryButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button RetryLoginButton;

		// Token: 0x0400A1CB RID: 41419
		[AutoBind("./DialogBox/Buttons/LoginButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button ReturnToLoginButton;

		// Token: 0x0400A1CC RID: 41420
		[AutoBind("./Waiting", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitingGameObject;

		// Token: 0x0400A1CD RID: 41421
		[DoNotToLua]
		private ReloginUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A1CE RID: 41422
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A1CF RID: 41423
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A1D0 RID: 41424
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A1D1 RID: 41425
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A1D2 RID: 41426
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400A1D3 RID: 41427
		private LuaFunction m_ShowWaitForReloginConfirm_hotfix;

		// Token: 0x0400A1D4 RID: 41428
		private LuaFunction m_ShowWaitForReloginProcessing_hotfix;

		// Token: 0x0400A1D5 RID: 41429
		private LuaFunction m_ShowWaitReturnToLoginConfirm_hotfix;

		// Token: 0x02000E57 RID: 3671
		public new class LuaExportHelper
		{
			// Token: 0x06011C64 RID: 72804 RVA: 0x00499AB4 File Offset: 0x00497CB4
			public LuaExportHelper(ReloginUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011C65 RID: 72805 RVA: 0x00499AC4 File Offset: 0x00497CC4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011C66 RID: 72806 RVA: 0x00499AD4 File Offset: 0x00497CD4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011C67 RID: 72807 RVA: 0x00499AE4 File Offset: 0x00497CE4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011C68 RID: 72808 RVA: 0x00499AF4 File Offset: 0x00497CF4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011C69 RID: 72809 RVA: 0x00499B0C File Offset: 0x00497D0C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011C6A RID: 72810 RVA: 0x00499B1C File Offset: 0x00497D1C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011C6B RID: 72811 RVA: 0x00499B2C File Offset: 0x00497D2C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011C6C RID: 72812 RVA: 0x00499B3C File Offset: 0x00497D3C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011C6D RID: 72813 RVA: 0x00499B4C File Offset: 0x00497D4C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011C6E RID: 72814 RVA: 0x00499B5C File Offset: 0x00497D5C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011C6F RID: 72815 RVA: 0x00499B6C File Offset: 0x00497D6C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011C70 RID: 72816 RVA: 0x00499B7C File Offset: 0x00497D7C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011C71 RID: 72817 RVA: 0x00499B8C File Offset: 0x00497D8C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011C72 RID: 72818 RVA: 0x00499B9C File Offset: 0x00497D9C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011C73 RID: 72819 RVA: 0x00499BAC File Offset: 0x00497DAC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003683 RID: 13955
			// (get) Token: 0x06011C74 RID: 72820 RVA: 0x00499BBC File Offset: 0x00497DBC
			// (set) Token: 0x06011C75 RID: 72821 RVA: 0x00499BCC File Offset: 0x00497DCC
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17003684 RID: 13956
			// (get) Token: 0x06011C76 RID: 72822 RVA: 0x00499BDC File Offset: 0x00497DDC
			// (set) Token: 0x06011C77 RID: 72823 RVA: 0x00499BEC File Offset: 0x00497DEC
			public GameObject m_dialogBoxGameObject
			{
				get
				{
					return this.m_owner.m_dialogBoxGameObject;
				}
				set
				{
					this.m_owner.m_dialogBoxGameObject = value;
				}
			}

			// Token: 0x17003685 RID: 13957
			// (get) Token: 0x06011C78 RID: 72824 RVA: 0x00499BFC File Offset: 0x00497DFC
			// (set) Token: 0x06011C79 RID: 72825 RVA: 0x00499C0C File Offset: 0x00497E0C
			public Button RetryLoginButton
			{
				get
				{
					return this.m_owner.RetryLoginButton;
				}
				set
				{
					this.m_owner.RetryLoginButton = value;
				}
			}

			// Token: 0x17003686 RID: 13958
			// (get) Token: 0x06011C7A RID: 72826 RVA: 0x00499C1C File Offset: 0x00497E1C
			// (set) Token: 0x06011C7B RID: 72827 RVA: 0x00499C2C File Offset: 0x00497E2C
			public Button ReturnToLoginButton
			{
				get
				{
					return this.m_owner.ReturnToLoginButton;
				}
				set
				{
					this.m_owner.ReturnToLoginButton = value;
				}
			}

			// Token: 0x17003687 RID: 13959
			// (get) Token: 0x06011C7C RID: 72828 RVA: 0x00499C3C File Offset: 0x00497E3C
			// (set) Token: 0x06011C7D RID: 72829 RVA: 0x00499C4C File Offset: 0x00497E4C
			public GameObject m_waitingGameObject
			{
				get
				{
					return this.m_owner.m_waitingGameObject;
				}
				set
				{
					this.m_owner.m_waitingGameObject = value;
				}
			}

			// Token: 0x06011C7E RID: 72830 RVA: 0x00499C5C File Offset: 0x00497E5C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400A1D6 RID: 41430
			private ReloginUIController m_owner;
		}
	}
}
