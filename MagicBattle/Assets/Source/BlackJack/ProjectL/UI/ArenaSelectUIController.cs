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
	// Token: 0x02000A1F RID: 2591
	[HotFix]
	public class ArenaSelectUIController : UIControllerBase
	{
		// Token: 0x06009B70 RID: 39792 RVA: 0x002C3EF0 File Offset: 0x002C20F0
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_onlineButton.onClick.AddListener(new UnityAction(this.OnOnlineButtonClick));
			this.m_offlineButton.onClick.AddListener(new UnityAction(this.OnOffineButtonClick));
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x002C3FAC File Offset: 0x002C21AC
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
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x002C4020 File Offset: 0x002C2220
		public void Close(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
			{
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x002C40BC File Offset: 0x002C22BC
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x002C4134 File Offset: 0x002C2334
		private void OnOnlineButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOnlineButtonClick_hotfix != null)
			{
				this.m_OnOnlineButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowOnlineArena != null)
			{
				this.EventOnShowOnlineArena();
			}
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x002C41AC File Offset: 0x002C23AC
		private void OnOffineButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOffineButtonClick_hotfix != null)
			{
				this.m_OnOffineButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowOfflineArena != null)
			{
				this.EventOnShowOfflineArena();
			}
		}

		// Token: 0x140001C1 RID: 449
		// (add) Token: 0x06009B76 RID: 39798 RVA: 0x002C4224 File Offset: 0x002C2424
		// (remove) Token: 0x06009B77 RID: 39799 RVA: 0x002C42C0 File Offset: 0x002C24C0
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C2 RID: 450
		// (add) Token: 0x06009B78 RID: 39800 RVA: 0x002C435C File Offset: 0x002C255C
		// (remove) Token: 0x06009B79 RID: 39801 RVA: 0x002C43F8 File Offset: 0x002C25F8
		public event Action EventOnShowOnlineArena
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOnlineArenaAction_hotfix != null)
				{
					this.m_add_EventOnShowOnlineArenaAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowOnlineArena;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowOnlineArena, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOnlineArenaAction_hotfix != null)
				{
					this.m_remove_EventOnShowOnlineArenaAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowOnlineArena;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowOnlineArena, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C3 RID: 451
		// (add) Token: 0x06009B7A RID: 39802 RVA: 0x002C4494 File Offset: 0x002C2694
		// (remove) Token: 0x06009B7B RID: 39803 RVA: 0x002C4530 File Offset: 0x002C2730
		public event Action EventOnShowOfflineArena
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowOfflineArenaAction_hotfix != null)
				{
					this.m_add_EventOnShowOfflineArenaAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowOfflineArena;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowOfflineArena, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowOfflineArenaAction_hotfix != null)
				{
					this.m_remove_EventOnShowOfflineArenaAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowOfflineArena;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowOfflineArena, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x002C45CC File Offset: 0x002C27CC
		// (set) Token: 0x06009B7D RID: 39805 RVA: 0x002C45EC File Offset: 0x002C27EC
		[DoNotToLua]
		public new ArenaSelectUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaSelectUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009B7E RID: 39806 RVA: 0x002C45F8 File Offset: 0x002C27F8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009B7F RID: 39807 RVA: 0x002C4604 File Offset: 0x002C2804
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009B80 RID: 39808 RVA: 0x002C460C File Offset: 0x002C280C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009B81 RID: 39809 RVA: 0x002C4614 File Offset: 0x002C2814
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009B82 RID: 39810 RVA: 0x002C4628 File Offset: 0x002C2828
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009B83 RID: 39811 RVA: 0x002C4630 File Offset: 0x002C2830
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x002C463C File Offset: 0x002C283C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x002C4648 File Offset: 0x002C2848
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x002C4654 File Offset: 0x002C2854
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x002C4660 File Offset: 0x002C2860
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x002C466C File Offset: 0x002C286C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x002C4678 File Offset: 0x002C2878
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x002C4684 File Offset: 0x002C2884
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x002C4690 File Offset: 0x002C2890
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x002C469C File Offset: 0x002C289C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x002C46A4 File Offset: 0x002C28A4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x002C46C4 File Offset: 0x002C28C4
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x002C46D0 File Offset: 0x002C28D0
		private void __callDele_EventOnShowOnlineArena()
		{
			Action eventOnShowOnlineArena = this.EventOnShowOnlineArena;
			if (eventOnShowOnlineArena != null)
			{
				eventOnShowOnlineArena();
			}
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x002C46F0 File Offset: 0x002C28F0
		private void __clearDele_EventOnShowOnlineArena()
		{
			this.EventOnShowOnlineArena = null;
		}

		// Token: 0x06009B91 RID: 39825 RVA: 0x002C46FC File Offset: 0x002C28FC
		private void __callDele_EventOnShowOfflineArena()
		{
			Action eventOnShowOfflineArena = this.EventOnShowOfflineArena;
			if (eventOnShowOfflineArena != null)
			{
				eventOnShowOfflineArena();
			}
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x002C471C File Offset: 0x002C291C
		private void __clearDele_EventOnShowOfflineArena()
		{
			this.EventOnShowOfflineArena = null;
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x002C4728 File Offset: 0x002C2928
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
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnOnlineButtonClick_hotfix = (luaObj.RawGet("OnOnlineButtonClick") as LuaFunction);
					this.m_OnOffineButtonClick_hotfix = (luaObj.RawGet("OnOffineButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnShowOnlineArenaAction_hotfix = (luaObj.RawGet("add_EventOnShowOnlineArena") as LuaFunction);
					this.m_remove_EventOnShowOnlineArenaAction_hotfix = (luaObj.RawGet("remove_EventOnShowOnlineArena") as LuaFunction);
					this.m_add_EventOnShowOfflineArenaAction_hotfix = (luaObj.RawGet("add_EventOnShowOfflineArena") as LuaFunction);
					this.m_remove_EventOnShowOfflineArenaAction_hotfix = (luaObj.RawGet("remove_EventOnShowOfflineArena") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x002C4908 File Offset: 0x002C2B08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaSelectUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040069D3 RID: 27091
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x040069D4 RID: 27092
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x040069D5 RID: 27093
		[AutoBind("./Panel/OnlineButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_onlineButton;

		// Token: 0x040069D6 RID: 27094
		[AutoBind("./Panel/OfflineButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_offlineButton;

		// Token: 0x040069D7 RID: 27095
		[DoNotToLua]
		private ArenaSelectUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040069D8 RID: 27096
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040069D9 RID: 27097
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040069DA RID: 27098
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040069DB RID: 27099
		private LuaFunction m_Open_hotfix;

		// Token: 0x040069DC RID: 27100
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x040069DD RID: 27101
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x040069DE RID: 27102
		private LuaFunction m_OnOnlineButtonClick_hotfix;

		// Token: 0x040069DF RID: 27103
		private LuaFunction m_OnOffineButtonClick_hotfix;

		// Token: 0x040069E0 RID: 27104
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040069E1 RID: 27105
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040069E2 RID: 27106
		private LuaFunction m_add_EventOnShowOnlineArenaAction_hotfix;

		// Token: 0x040069E3 RID: 27107
		private LuaFunction m_remove_EventOnShowOnlineArenaAction_hotfix;

		// Token: 0x040069E4 RID: 27108
		private LuaFunction m_add_EventOnShowOfflineArenaAction_hotfix;

		// Token: 0x040069E5 RID: 27109
		private LuaFunction m_remove_EventOnShowOfflineArenaAction_hotfix;

		// Token: 0x02000A20 RID: 2592
		public new class LuaExportHelper
		{
			// Token: 0x06009B95 RID: 39829 RVA: 0x002C4970 File Offset: 0x002C2B70
			public LuaExportHelper(ArenaSelectUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009B96 RID: 39830 RVA: 0x002C4980 File Offset: 0x002C2B80
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009B97 RID: 39831 RVA: 0x002C4990 File Offset: 0x002C2B90
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009B98 RID: 39832 RVA: 0x002C49A0 File Offset: 0x002C2BA0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009B99 RID: 39833 RVA: 0x002C49B0 File Offset: 0x002C2BB0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009B9A RID: 39834 RVA: 0x002C49C8 File Offset: 0x002C2BC8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009B9B RID: 39835 RVA: 0x002C49D8 File Offset: 0x002C2BD8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009B9C RID: 39836 RVA: 0x002C49E8 File Offset: 0x002C2BE8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009B9D RID: 39837 RVA: 0x002C49F8 File Offset: 0x002C2BF8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009B9E RID: 39838 RVA: 0x002C4A08 File Offset: 0x002C2C08
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009B9F RID: 39839 RVA: 0x002C4A18 File Offset: 0x002C2C18
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009BA0 RID: 39840 RVA: 0x002C4A28 File Offset: 0x002C2C28
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009BA1 RID: 39841 RVA: 0x002C4A38 File Offset: 0x002C2C38
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009BA2 RID: 39842 RVA: 0x002C4A48 File Offset: 0x002C2C48
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009BA3 RID: 39843 RVA: 0x002C4A58 File Offset: 0x002C2C58
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009BA4 RID: 39844 RVA: 0x002C4A68 File Offset: 0x002C2C68
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009BA5 RID: 39845 RVA: 0x002C4A78 File Offset: 0x002C2C78
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06009BA6 RID: 39846 RVA: 0x002C4A88 File Offset: 0x002C2C88
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x06009BA7 RID: 39847 RVA: 0x002C4A98 File Offset: 0x002C2C98
			public void __callDele_EventOnShowOnlineArena()
			{
				this.m_owner.__callDele_EventOnShowOnlineArena();
			}

			// Token: 0x06009BA8 RID: 39848 RVA: 0x002C4AA8 File Offset: 0x002C2CA8
			public void __clearDele_EventOnShowOnlineArena()
			{
				this.m_owner.__clearDele_EventOnShowOnlineArena();
			}

			// Token: 0x06009BA9 RID: 39849 RVA: 0x002C4AB8 File Offset: 0x002C2CB8
			public void __callDele_EventOnShowOfflineArena()
			{
				this.m_owner.__callDele_EventOnShowOfflineArena();
			}

			// Token: 0x06009BAA RID: 39850 RVA: 0x002C4AC8 File Offset: 0x002C2CC8
			public void __clearDele_EventOnShowOfflineArena()
			{
				this.m_owner.__clearDele_EventOnShowOfflineArena();
			}

			// Token: 0x17001FAD RID: 8109
			// (get) Token: 0x06009BAB RID: 39851 RVA: 0x002C4AD8 File Offset: 0x002C2CD8
			// (set) Token: 0x06009BAC RID: 39852 RVA: 0x002C4AE8 File Offset: 0x002C2CE8
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

			// Token: 0x17001FAE RID: 8110
			// (get) Token: 0x06009BAD RID: 39853 RVA: 0x002C4AF8 File Offset: 0x002C2CF8
			// (set) Token: 0x06009BAE RID: 39854 RVA: 0x002C4B08 File Offset: 0x002C2D08
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17001FAF RID: 8111
			// (get) Token: 0x06009BAF RID: 39855 RVA: 0x002C4B18 File Offset: 0x002C2D18
			// (set) Token: 0x06009BB0 RID: 39856 RVA: 0x002C4B28 File Offset: 0x002C2D28
			public Button m_onlineButton
			{
				get
				{
					return this.m_owner.m_onlineButton;
				}
				set
				{
					this.m_owner.m_onlineButton = value;
				}
			}

			// Token: 0x17001FB0 RID: 8112
			// (get) Token: 0x06009BB1 RID: 39857 RVA: 0x002C4B38 File Offset: 0x002C2D38
			// (set) Token: 0x06009BB2 RID: 39858 RVA: 0x002C4B48 File Offset: 0x002C2D48
			public Button m_offlineButton
			{
				get
				{
					return this.m_owner.m_offlineButton;
				}
				set
				{
					this.m_owner.m_offlineButton = value;
				}
			}

			// Token: 0x06009BB3 RID: 39859 RVA: 0x002C4B58 File Offset: 0x002C2D58
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009BB4 RID: 39860 RVA: 0x002C4B68 File Offset: 0x002C2D68
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x06009BB5 RID: 39861 RVA: 0x002C4B78 File Offset: 0x002C2D78
			public void OnOnlineButtonClick()
			{
				this.m_owner.OnOnlineButtonClick();
			}

			// Token: 0x06009BB6 RID: 39862 RVA: 0x002C4B88 File Offset: 0x002C2D88
			public void OnOffineButtonClick()
			{
				this.m_owner.OnOffineButtonClick();
			}

			// Token: 0x040069E6 RID: 27110
			private ArenaSelectUIController m_owner;
		}
	}
}
