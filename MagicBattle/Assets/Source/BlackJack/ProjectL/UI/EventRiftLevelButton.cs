using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EE2 RID: 3810
	[HotFix]
	public class EventRiftLevelButton : UIControllerBase
	{
		// Token: 0x06012C3F RID: 76863 RVA: 0x004CCE58 File Offset: 0x004CB058
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x06012C40 RID: 76864 RVA: 0x004CCEDC File Offset: 0x004CB0DC
		public void SetRiftLevelInfo(ConfigDataRiftLevelInfo riftLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					riftLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (riftLevelInfo == null)
			{
				return;
			}
			this.m_riftLevelInfo = riftLevelInfo;
		}

		// Token: 0x06012C41 RID: 76865 RVA: 0x004CCF5C File Offset: 0x004CB15C
		public ConfigDataRiftLevelInfo GetRiftLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRiftLevelInfo_hotfix != null)
			{
				return (ConfigDataRiftLevelInfo)this.m_GetRiftLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftLevelInfo;
		}

		// Token: 0x06012C42 RID: 76866 RVA: 0x004CCFD0 File Offset: 0x004CB1D0
		public void SetStatus(RiftLevelStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusRiftLevelStatus_hotfix != null)
			{
				this.m_SetStatusRiftLevelStatus_hotfix.call(new object[]
				{
					this,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (status == RiftLevelStatus.Close)
			{
				this.m_uiStateController.SetToUIState("Close", false, true);
			}
			else if (status == RiftLevelStatus.Lock)
			{
				this.m_uiStateController.SetToUIState("Lock", false, true);
			}
			else if (status == RiftLevelStatus.Open)
			{
				this.m_uiStateController.SetToUIState("Open", false, true);
			}
			this.m_status = status;
		}

		// Token: 0x06012C43 RID: 76867 RVA: 0x004CD09C File Offset: 0x004CB29C
		public RiftLevelStatus GetStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStatus_hotfix != null)
			{
				return (RiftLevelStatus)this.m_GetStatus_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_status;
		}

		// Token: 0x06012C44 RID: 76868 RVA: 0x004CD110 File Offset: 0x004CB310
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000413 RID: 1043
		// (add) Token: 0x06012C45 RID: 76869 RVA: 0x004CD188 File Offset: 0x004CB388
		// (remove) Token: 0x06012C46 RID: 76870 RVA: 0x004CD224 File Offset: 0x004CB424
		public event Action<EventRiftLevelButton> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EventRiftLevelButton> action = this.EventOnClick;
				Action<EventRiftLevelButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EventRiftLevelButton>>(ref this.EventOnClick, (Action<EventRiftLevelButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<EventRiftLevelButton> action = this.EventOnClick;
				Action<EventRiftLevelButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<EventRiftLevelButton>>(ref this.EventOnClick, (Action<EventRiftLevelButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x06012C47 RID: 76871 RVA: 0x004CD2C0 File Offset: 0x004CB4C0
		// (set) Token: 0x06012C48 RID: 76872 RVA: 0x004CD2E0 File Offset: 0x004CB4E0
		[DoNotToLua]
		public new EventRiftLevelButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EventRiftLevelButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012C49 RID: 76873 RVA: 0x004CD2EC File Offset: 0x004CB4EC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012C4A RID: 76874 RVA: 0x004CD2F8 File Offset: 0x004CB4F8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x004CD300 File Offset: 0x004CB500
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012C4C RID: 76876 RVA: 0x004CD308 File Offset: 0x004CB508
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012C4D RID: 76877 RVA: 0x004CD31C File Offset: 0x004CB51C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012C4E RID: 76878 RVA: 0x004CD324 File Offset: 0x004CB524
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012C4F RID: 76879 RVA: 0x004CD330 File Offset: 0x004CB530
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012C50 RID: 76880 RVA: 0x004CD33C File Offset: 0x004CB53C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x004CD348 File Offset: 0x004CB548
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012C52 RID: 76882 RVA: 0x004CD354 File Offset: 0x004CB554
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x004CD360 File Offset: 0x004CB560
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x004CD36C File Offset: 0x004CB56C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012C55 RID: 76885 RVA: 0x004CD378 File Offset: 0x004CB578
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012C56 RID: 76886 RVA: 0x004CD384 File Offset: 0x004CB584
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012C57 RID: 76887 RVA: 0x004CD390 File Offset: 0x004CB590
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012C58 RID: 76888 RVA: 0x004CD398 File Offset: 0x004CB598
		private void __callDele_EventOnClick(EventRiftLevelButton obj)
		{
			Action<EventRiftLevelButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x06012C59 RID: 76889 RVA: 0x004CD3BC File Offset: 0x004CB5BC
		private void __clearDele_EventOnClick(EventRiftLevelButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x06012C5A RID: 76890 RVA: 0x004CD3C8 File Offset: 0x004CB5C8
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
					this.m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("SetRiftLevelInfo") as LuaFunction);
					this.m_GetRiftLevelInfo_hotfix = (luaObj.RawGet("GetRiftLevelInfo") as LuaFunction);
					this.m_SetStatusRiftLevelStatus_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_GetStatus_hotfix = (luaObj.RawGet("GetStatus") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012C5B RID: 76891 RVA: 0x004CD544 File Offset: 0x004CB744
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EventRiftLevelButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A801 RID: 43009
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400A802 RID: 43010
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A803 RID: 43011
		private RiftLevelStatus m_status;

		// Token: 0x0400A804 RID: 43012
		private ConfigDataRiftLevelInfo m_riftLevelInfo;

		// Token: 0x0400A805 RID: 43013
		[DoNotToLua]
		private EventRiftLevelButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400A806 RID: 43014
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A807 RID: 43015
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A808 RID: 43016
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A809 RID: 43017
		private LuaFunction m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400A80A RID: 43018
		private LuaFunction m_GetRiftLevelInfo_hotfix;

		// Token: 0x0400A80B RID: 43019
		private LuaFunction m_SetStatusRiftLevelStatus_hotfix;

		// Token: 0x0400A80C RID: 43020
		private LuaFunction m_GetStatus_hotfix;

		// Token: 0x0400A80D RID: 43021
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400A80E RID: 43022
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400A80F RID: 43023
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000EE3 RID: 3811
		public new class LuaExportHelper
		{
			// Token: 0x06012C5C RID: 76892 RVA: 0x004CD5AC File Offset: 0x004CB7AC
			public LuaExportHelper(EventRiftLevelButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012C5D RID: 76893 RVA: 0x004CD5BC File Offset: 0x004CB7BC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012C5E RID: 76894 RVA: 0x004CD5CC File Offset: 0x004CB7CC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012C5F RID: 76895 RVA: 0x004CD5DC File Offset: 0x004CB7DC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012C60 RID: 76896 RVA: 0x004CD5EC File Offset: 0x004CB7EC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012C61 RID: 76897 RVA: 0x004CD604 File Offset: 0x004CB804
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012C62 RID: 76898 RVA: 0x004CD614 File Offset: 0x004CB814
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012C63 RID: 76899 RVA: 0x004CD624 File Offset: 0x004CB824
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012C64 RID: 76900 RVA: 0x004CD634 File Offset: 0x004CB834
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012C65 RID: 76901 RVA: 0x004CD644 File Offset: 0x004CB844
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012C66 RID: 76902 RVA: 0x004CD654 File Offset: 0x004CB854
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012C67 RID: 76903 RVA: 0x004CD664 File Offset: 0x004CB864
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012C68 RID: 76904 RVA: 0x004CD674 File Offset: 0x004CB874
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012C69 RID: 76905 RVA: 0x004CD684 File Offset: 0x004CB884
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012C6A RID: 76906 RVA: 0x004CD694 File Offset: 0x004CB894
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012C6B RID: 76907 RVA: 0x004CD6A4 File Offset: 0x004CB8A4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012C6C RID: 76908 RVA: 0x004CD6B4 File Offset: 0x004CB8B4
			public void __callDele_EventOnClick(EventRiftLevelButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06012C6D RID: 76909 RVA: 0x004CD6C4 File Offset: 0x004CB8C4
			public void __clearDele_EventOnClick(EventRiftLevelButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x170038A4 RID: 14500
			// (get) Token: 0x06012C6E RID: 76910 RVA: 0x004CD6D4 File Offset: 0x004CB8D4
			// (set) Token: 0x06012C6F RID: 76911 RVA: 0x004CD6E4 File Offset: 0x004CB8E4
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

			// Token: 0x170038A5 RID: 14501
			// (get) Token: 0x06012C70 RID: 76912 RVA: 0x004CD6F4 File Offset: 0x004CB8F4
			// (set) Token: 0x06012C71 RID: 76913 RVA: 0x004CD704 File Offset: 0x004CB904
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

			// Token: 0x170038A6 RID: 14502
			// (get) Token: 0x06012C72 RID: 76914 RVA: 0x004CD714 File Offset: 0x004CB914
			// (set) Token: 0x06012C73 RID: 76915 RVA: 0x004CD724 File Offset: 0x004CB924
			public RiftLevelStatus m_status
			{
				get
				{
					return this.m_owner.m_status;
				}
				set
				{
					this.m_owner.m_status = value;
				}
			}

			// Token: 0x170038A7 RID: 14503
			// (get) Token: 0x06012C74 RID: 76916 RVA: 0x004CD734 File Offset: 0x004CB934
			// (set) Token: 0x06012C75 RID: 76917 RVA: 0x004CD744 File Offset: 0x004CB944
			public ConfigDataRiftLevelInfo m_riftLevelInfo
			{
				get
				{
					return this.m_owner.m_riftLevelInfo;
				}
				set
				{
					this.m_owner.m_riftLevelInfo = value;
				}
			}

			// Token: 0x06012C76 RID: 76918 RVA: 0x004CD754 File Offset: 0x004CB954
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012C77 RID: 76919 RVA: 0x004CD764 File Offset: 0x004CB964
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400A810 RID: 43024
			private EventRiftLevelButton m_owner;
		}
	}
}
