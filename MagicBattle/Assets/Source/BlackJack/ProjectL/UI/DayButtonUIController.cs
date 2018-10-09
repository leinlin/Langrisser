using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
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
	// Token: 0x020009AC RID: 2476
	[HotFix]
	public class DayButtonUIController : UIControllerBase
	{
		// Token: 0x06008F7C RID: 36732 RVA: 0x0029C75C File Offset: 0x0029A95C
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnDayButtonClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x0029C7EC File Offset: 0x0029A9EC
		public void InitDayButtonInfo(int day)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDayButtonInfoInt32_hotfix != null)
			{
				this.m_InitDayButtonInfoInt32_hotfix.call(new object[]
				{
					this,
					day
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Day = day;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int daysAfterCreation = projectLPlayerContext.GetDaysAfterCreation();
			this.m_isLocked = (day > daysAfterCreation);
			if (this.m_isLocked)
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
			this.m_redMark.SetActive(!this.m_isLocked && projectLPlayerContext.HaveFinishedNotGetNoiviceMissionsByDay(day));
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x0029C8D8 File Offset: 0x0029AAD8
		public void ShowSelectFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isShow)
			{
				this.m_stateCtrl.SetToUIState("Select", false, true);
			}
			else if (this.m_isLocked)
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x0029C99C File Offset: 0x0029AB9C
		private void OnDayButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDayButtonClick_hotfix != null)
			{
				this.m_OnDayButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isLocked)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_MissionNotOpen, 2f, null, true);
			}
			else if (this.EventOnDayButtonClick != null)
			{
				this.EventOnDayButtonClick(this);
			}
		}

		// Token: 0x1400018F RID: 399
		// (add) Token: 0x06008F80 RID: 36736 RVA: 0x0029CA3C File Offset: 0x0029AC3C
		// (remove) Token: 0x06008F81 RID: 36737 RVA: 0x0029CAD8 File Offset: 0x0029ACD8
		public event Action<DayButtonUIController> EventOnDayButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDayButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnDayButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<DayButtonUIController> action = this.EventOnDayButtonClick;
				Action<DayButtonUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<DayButtonUIController>>(ref this.EventOnDayButtonClick, (Action<DayButtonUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDayButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnDayButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<DayButtonUIController> action = this.EventOnDayButtonClick;
				Action<DayButtonUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<DayButtonUIController>>(ref this.EventOnDayButtonClick, (Action<DayButtonUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x06008F83 RID: 36739 RVA: 0x0029CBEC File Offset: 0x0029ADEC
		// (set) Token: 0x06008F82 RID: 36738 RVA: 0x0029CB74 File Offset: 0x0029AD74
		public int Day
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Day_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Day_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Day>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_DayInt32_hotfix != null)
				{
					this.m_set_DayInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Day>k__BackingField = value;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06008F84 RID: 36740 RVA: 0x0029CC60 File Offset: 0x0029AE60
		// (set) Token: 0x06008F85 RID: 36741 RVA: 0x0029CC80 File Offset: 0x0029AE80
		[DoNotToLua]
		public new DayButtonUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DayButtonUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x0029CC8C File Offset: 0x0029AE8C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x0029CC98 File Offset: 0x0029AE98
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x0029CCA0 File Offset: 0x0029AEA0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0029CCA8 File Offset: 0x0029AEA8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0029CCBC File Offset: 0x0029AEBC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0029CCC4 File Offset: 0x0029AEC4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0029CCD0 File Offset: 0x0029AED0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0029CCDC File Offset: 0x0029AEDC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x0029CCE8 File Offset: 0x0029AEE8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0029CCF4 File Offset: 0x0029AEF4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x0029CD00 File Offset: 0x0029AF00
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x0029CD0C File Offset: 0x0029AF0C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x0029CD18 File Offset: 0x0029AF18
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x0029CD24 File Offset: 0x0029AF24
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x0029CD30 File Offset: 0x0029AF30
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x0029CD38 File Offset: 0x0029AF38
		private void __callDele_EventOnDayButtonClick(DayButtonUIController obj)
		{
			Action<DayButtonUIController> eventOnDayButtonClick = this.EventOnDayButtonClick;
			if (eventOnDayButtonClick != null)
			{
				eventOnDayButtonClick(obj);
			}
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x0029CD5C File Offset: 0x0029AF5C
		private void __clearDele_EventOnDayButtonClick(DayButtonUIController obj)
		{
			this.EventOnDayButtonClick = null;
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0029CD68 File Offset: 0x0029AF68
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
					this.m_InitDayButtonInfoInt32_hotfix = (luaObj.RawGet("InitDayButtonInfo") as LuaFunction);
					this.m_ShowSelectFrameBoolean_hotfix = (luaObj.RawGet("ShowSelectFrame") as LuaFunction);
					this.m_OnDayButtonClick_hotfix = (luaObj.RawGet("OnDayButtonClick") as LuaFunction);
					this.m_add_EventOnDayButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnDayButtonClick") as LuaFunction);
					this.m_remove_EventOnDayButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnDayButtonClick") as LuaFunction);
					this.m_set_DayInt32_hotfix = (luaObj.RawGet("set_Day") as LuaFunction);
					this.m_get_Day_hotfix = (luaObj.RawGet("get_Day") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x0029CEE4 File Offset: 0x0029B0E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DayButtonUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006547 RID: 25927
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04006548 RID: 25928
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04006549 RID: 25929
		[AutoBind("./RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redMark;

		// Token: 0x0400654A RID: 25930
		private bool m_isLocked;

		// Token: 0x0400654C RID: 25932
		[DoNotToLua]
		private DayButtonUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400654D RID: 25933
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400654E RID: 25934
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400654F RID: 25935
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006550 RID: 25936
		private LuaFunction m_InitDayButtonInfoInt32_hotfix;

		// Token: 0x04006551 RID: 25937
		private LuaFunction m_ShowSelectFrameBoolean_hotfix;

		// Token: 0x04006552 RID: 25938
		private LuaFunction m_OnDayButtonClick_hotfix;

		// Token: 0x04006553 RID: 25939
		private LuaFunction m_add_EventOnDayButtonClickAction;

		// Token: 0x04006554 RID: 25940
		private LuaFunction m_remove_EventOnDayButtonClickAction;

		// Token: 0x04006555 RID: 25941
		private LuaFunction m_set_DayInt32_hotfix;

		// Token: 0x04006556 RID: 25942
		private LuaFunction m_get_Day_hotfix;

		// Token: 0x020009AD RID: 2477
		public new class LuaExportHelper
		{
			// Token: 0x06008F99 RID: 36761 RVA: 0x0029CF4C File Offset: 0x0029B14C
			public LuaExportHelper(DayButtonUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008F9A RID: 36762 RVA: 0x0029CF5C File Offset: 0x0029B15C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06008F9B RID: 36763 RVA: 0x0029CF6C File Offset: 0x0029B16C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06008F9C RID: 36764 RVA: 0x0029CF7C File Offset: 0x0029B17C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06008F9D RID: 36765 RVA: 0x0029CF8C File Offset: 0x0029B18C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06008F9E RID: 36766 RVA: 0x0029CFA4 File Offset: 0x0029B1A4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06008F9F RID: 36767 RVA: 0x0029CFB4 File Offset: 0x0029B1B4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06008FA0 RID: 36768 RVA: 0x0029CFC4 File Offset: 0x0029B1C4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06008FA1 RID: 36769 RVA: 0x0029CFD4 File Offset: 0x0029B1D4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06008FA2 RID: 36770 RVA: 0x0029CFE4 File Offset: 0x0029B1E4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06008FA3 RID: 36771 RVA: 0x0029CFF4 File Offset: 0x0029B1F4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06008FA4 RID: 36772 RVA: 0x0029D004 File Offset: 0x0029B204
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06008FA5 RID: 36773 RVA: 0x0029D014 File Offset: 0x0029B214
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06008FA6 RID: 36774 RVA: 0x0029D024 File Offset: 0x0029B224
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06008FA7 RID: 36775 RVA: 0x0029D034 File Offset: 0x0029B234
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06008FA8 RID: 36776 RVA: 0x0029D044 File Offset: 0x0029B244
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06008FA9 RID: 36777 RVA: 0x0029D054 File Offset: 0x0029B254
			public void __callDele_EventOnDayButtonClick(DayButtonUIController obj)
			{
				this.m_owner.__callDele_EventOnDayButtonClick(obj);
			}

			// Token: 0x06008FAA RID: 36778 RVA: 0x0029D064 File Offset: 0x0029B264
			public void __clearDele_EventOnDayButtonClick(DayButtonUIController obj)
			{
				this.m_owner.__clearDele_EventOnDayButtonClick(obj);
			}

			// Token: 0x17001DF2 RID: 7666
			// (get) Token: 0x06008FAB RID: 36779 RVA: 0x0029D074 File Offset: 0x0029B274
			// (set) Token: 0x06008FAC RID: 36780 RVA: 0x0029D084 File Offset: 0x0029B284
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17001DF3 RID: 7667
			// (get) Token: 0x06008FAD RID: 36781 RVA: 0x0029D094 File Offset: 0x0029B294
			// (set) Token: 0x06008FAE RID: 36782 RVA: 0x0029D0A4 File Offset: 0x0029B2A4
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

			// Token: 0x17001DF4 RID: 7668
			// (get) Token: 0x06008FAF RID: 36783 RVA: 0x0029D0B4 File Offset: 0x0029B2B4
			// (set) Token: 0x06008FB0 RID: 36784 RVA: 0x0029D0C4 File Offset: 0x0029B2C4
			public GameObject m_redMark
			{
				get
				{
					return this.m_owner.m_redMark;
				}
				set
				{
					this.m_owner.m_redMark = value;
				}
			}

			// Token: 0x17001DF5 RID: 7669
			// (get) Token: 0x06008FB1 RID: 36785 RVA: 0x0029D0D4 File Offset: 0x0029B2D4
			// (set) Token: 0x06008FB2 RID: 36786 RVA: 0x0029D0E4 File Offset: 0x0029B2E4
			public bool m_isLocked
			{
				get
				{
					return this.m_owner.m_isLocked;
				}
				set
				{
					this.m_owner.m_isLocked = value;
				}
			}

			// Token: 0x17001DF6 RID: 7670
			// (set) Token: 0x06008FB3 RID: 36787 RVA: 0x0029D0F4 File Offset: 0x0029B2F4
			public int Day
			{
				set
				{
					this.m_owner.Day = value;
				}
			}

			// Token: 0x06008FB4 RID: 36788 RVA: 0x0029D104 File Offset: 0x0029B304
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06008FB5 RID: 36789 RVA: 0x0029D114 File Offset: 0x0029B314
			public void OnDayButtonClick()
			{
				this.m_owner.OnDayButtonClick();
			}

			// Token: 0x04006557 RID: 25943
			private DayButtonUIController m_owner;
		}
	}
}
