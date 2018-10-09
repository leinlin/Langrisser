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
	// Token: 0x02000C0C RID: 3084
	[HotFix]
	public class WaitPVPInviteUIController : UIControllerBase
	{
		// Token: 0x0600D81F RID: 55327 RVA: 0x003ACA70 File Offset: 0x003AAC70
		private WaitPVPInviteUIController()
		{
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x003ACA78 File Offset: 0x003AAC78
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
			this.m_cancelButton.onClick.AddListener(new UnityAction(this.OnCancelButtonClick));
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x003ACAFC File Offset: 0x003AACFC
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
			this.m_isOpened = true;
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x003ACB78 File Offset: 0x003AAD78
		public void Close(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", onEnd, false, true);
			this.m_isOpened = false;
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x003ACC04 File Offset: 0x003AAE04
		private void OnCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelButtonClick_hotfix != null)
			{
				this.m_OnCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			if (this.EventOnCancel != null)
			{
				this.EventOnCancel();
			}
		}

		// Token: 0x140002AE RID: 686
		// (add) Token: 0x0600D824 RID: 55332 RVA: 0x003ACC88 File Offset: 0x003AAE88
		// (remove) Token: 0x0600D825 RID: 55333 RVA: 0x003ACD24 File Offset: 0x003AAF24
		public event Action EventOnCancel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCancelAction_hotfix != null)
				{
					this.m_add_EventOnCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCancelAction_hotfix != null)
				{
					this.m_remove_EventOnCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600D826 RID: 55334 RVA: 0x003ACDC0 File Offset: 0x003AAFC0
		// (set) Token: 0x0600D827 RID: 55335 RVA: 0x003ACDE0 File Offset: 0x003AAFE0
		[DoNotToLua]
		public new WaitPVPInviteUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WaitPVPInviteUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x003ACDEC File Offset: 0x003AAFEC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x003ACDF8 File Offset: 0x003AAFF8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D82A RID: 55338 RVA: 0x003ACE00 File Offset: 0x003AB000
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D82B RID: 55339 RVA: 0x003ACE08 File Offset: 0x003AB008
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D82C RID: 55340 RVA: 0x003ACE1C File Offset: 0x003AB01C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D82D RID: 55341 RVA: 0x003ACE24 File Offset: 0x003AB024
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D82E RID: 55342 RVA: 0x003ACE30 File Offset: 0x003AB030
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D82F RID: 55343 RVA: 0x003ACE3C File Offset: 0x003AB03C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D830 RID: 55344 RVA: 0x003ACE48 File Offset: 0x003AB048
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D831 RID: 55345 RVA: 0x003ACE54 File Offset: 0x003AB054
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x003ACE60 File Offset: 0x003AB060
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D833 RID: 55347 RVA: 0x003ACE6C File Offset: 0x003AB06C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x003ACE78 File Offset: 0x003AB078
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D835 RID: 55349 RVA: 0x003ACE84 File Offset: 0x003AB084
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D836 RID: 55350 RVA: 0x003ACE90 File Offset: 0x003AB090
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D837 RID: 55351 RVA: 0x003ACE98 File Offset: 0x003AB098
		private void __callDele_EventOnCancel()
		{
			Action eventOnCancel = this.EventOnCancel;
			if (eventOnCancel != null)
			{
				eventOnCancel();
			}
		}

		// Token: 0x0600D838 RID: 55352 RVA: 0x003ACEB8 File Offset: 0x003AB0B8
		private void __clearDele_EventOnCancel()
		{
			this.EventOnCancel = null;
		}

		// Token: 0x0600D839 RID: 55353 RVA: 0x003ACEC4 File Offset: 0x003AB0C4
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
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_OnCancelButtonClick_hotfix = (luaObj.RawGet("OnCancelButtonClick") as LuaFunction);
					this.m_add_EventOnCancelAction_hotfix = (luaObj.RawGet("add_EventOnCancel") as LuaFunction);
					this.m_remove_EventOnCancelAction_hotfix = (luaObj.RawGet("remove_EventOnCancel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D83A RID: 55354 RVA: 0x003AD00C File Offset: 0x003AB20C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WaitPVPInviteUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040084E2 RID: 34018
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x040084E3 RID: 34019
		[AutoBind("./Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelButton;

		// Token: 0x040084E4 RID: 34020
		private bool m_isOpened;

		// Token: 0x040084E5 RID: 34021
		[DoNotToLua]
		private WaitPVPInviteUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040084E6 RID: 34022
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040084E7 RID: 34023
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040084E8 RID: 34024
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040084E9 RID: 34025
		private LuaFunction m_Open_hotfix;

		// Token: 0x040084EA RID: 34026
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x040084EB RID: 34027
		private LuaFunction m_OnCancelButtonClick_hotfix;

		// Token: 0x040084EC RID: 34028
		private LuaFunction m_add_EventOnCancelAction_hotfix;

		// Token: 0x040084ED RID: 34029
		private LuaFunction m_remove_EventOnCancelAction_hotfix;

		// Token: 0x02000C0D RID: 3085
		public new class LuaExportHelper
		{
			// Token: 0x0600D83B RID: 55355 RVA: 0x003AD074 File Offset: 0x003AB274
			public LuaExportHelper(WaitPVPInviteUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D83C RID: 55356 RVA: 0x003AD084 File Offset: 0x003AB284
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D83D RID: 55357 RVA: 0x003AD094 File Offset: 0x003AB294
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D83E RID: 55358 RVA: 0x003AD0A4 File Offset: 0x003AB2A4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D83F RID: 55359 RVA: 0x003AD0B4 File Offset: 0x003AB2B4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D840 RID: 55360 RVA: 0x003AD0CC File Offset: 0x003AB2CC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D841 RID: 55361 RVA: 0x003AD0DC File Offset: 0x003AB2DC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D842 RID: 55362 RVA: 0x003AD0EC File Offset: 0x003AB2EC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D843 RID: 55363 RVA: 0x003AD0FC File Offset: 0x003AB2FC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D844 RID: 55364 RVA: 0x003AD10C File Offset: 0x003AB30C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D845 RID: 55365 RVA: 0x003AD11C File Offset: 0x003AB31C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D846 RID: 55366 RVA: 0x003AD12C File Offset: 0x003AB32C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D847 RID: 55367 RVA: 0x003AD13C File Offset: 0x003AB33C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D848 RID: 55368 RVA: 0x003AD14C File Offset: 0x003AB34C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D849 RID: 55369 RVA: 0x003AD15C File Offset: 0x003AB35C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D84A RID: 55370 RVA: 0x003AD16C File Offset: 0x003AB36C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D84B RID: 55371 RVA: 0x003AD17C File Offset: 0x003AB37C
			public void __callDele_EventOnCancel()
			{
				this.m_owner.__callDele_EventOnCancel();
			}

			// Token: 0x0600D84C RID: 55372 RVA: 0x003AD18C File Offset: 0x003AB38C
			public void __clearDele_EventOnCancel()
			{
				this.m_owner.__clearDele_EventOnCancel();
			}

			// Token: 0x17002A20 RID: 10784
			// (get) Token: 0x0600D84D RID: 55373 RVA: 0x003AD19C File Offset: 0x003AB39C
			// (set) Token: 0x0600D84E RID: 55374 RVA: 0x003AD1AC File Offset: 0x003AB3AC
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

			// Token: 0x17002A21 RID: 10785
			// (get) Token: 0x0600D84F RID: 55375 RVA: 0x003AD1BC File Offset: 0x003AB3BC
			// (set) Token: 0x0600D850 RID: 55376 RVA: 0x003AD1CC File Offset: 0x003AB3CC
			public Button m_cancelButton
			{
				get
				{
					return this.m_owner.m_cancelButton;
				}
				set
				{
					this.m_owner.m_cancelButton = value;
				}
			}

			// Token: 0x17002A22 RID: 10786
			// (get) Token: 0x0600D851 RID: 55377 RVA: 0x003AD1DC File Offset: 0x003AB3DC
			// (set) Token: 0x0600D852 RID: 55378 RVA: 0x003AD1EC File Offset: 0x003AB3EC
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x0600D853 RID: 55379 RVA: 0x003AD1FC File Offset: 0x003AB3FC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D854 RID: 55380 RVA: 0x003AD20C File Offset: 0x003AB40C
			public void OnCancelButtonClick()
			{
				this.m_owner.OnCancelButtonClick();
			}

			// Token: 0x040084EE RID: 34030
			private WaitPVPInviteUIController m_owner;
		}
	}
}
