using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BD8 RID: 3032
	[HotFix]
	public class MonthCardInfoUIController : UIControllerBase
	{
		// Token: 0x0600D136 RID: 53558 RVA: 0x0039476C File Offset: 0x0039296C
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
			this.BackgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x0600D137 RID: 53559 RVA: 0x003947F0 File Offset: 0x003929F0
		public void ShowReward(int monrhCardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardInt32_hotfix != null)
			{
				this.m_ShowRewardInt32_hotfix.call(new object[]
				{
					this,
					monrhCardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.PanelStateController, "Show", null, true, true);
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			ConfigDataMonthCardInfo configDataMonthCardInfo = clientConfigDataLoader.GetConfigDataMonthCardInfo(monrhCardId);
			TimeSpan monthCardLeftTime = (GameManager.Instance.PlayerContext as ProjectLPlayerContext).GetMonthCardLeftTime(monrhCardId);
			this.NameText.text = configDataMonthCardInfo.Name;
			this.IconImage.sprite = AssetUtility.Instance.GetSprite(configDataMonthCardInfo.Icon);
			this.MonthCardOrSubscribeStateCtrl.SetToUIState((!UIUtility.IsIosSubscribe(configDataMonthCardInfo.IsAppleSubscribe)) ? "MonthCard" : "Subscribe", false, true);
			this.DescText.text = configDataMonthCardInfo.Desc;
			if (monthCardLeftTime.TotalMilliseconds < 9.9999997473787516E-05)
			{
				this.LeftDaysGameObject.SetActive(false);
			}
			else
			{
				this.LeftDaysGameObject.SetActive(true);
				this.LeftDays.text = string.Format("{0}{1}", clientConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Common_Remain), UIUtility.TimeSpanToString2(monthCardLeftTime));
			}
		}

		// Token: 0x0600D138 RID: 53560 RVA: 0x00394964 File Offset: 0x00392B64
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
			UIUtility.SetUIStateClose(this.PanelStateController, "Close", this.EventOnClose, true, true);
		}

		// Token: 0x14000286 RID: 646
		// (add) Token: 0x0600D139 RID: 53561 RVA: 0x003949DC File Offset: 0x00392BDC
		// (remove) Token: 0x0600D13A RID: 53562 RVA: 0x00394A78 File Offset: 0x00392C78
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

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x0600D13B RID: 53563 RVA: 0x00394B14 File Offset: 0x00392D14
		// (set) Token: 0x0600D13C RID: 53564 RVA: 0x00394B34 File Offset: 0x00392D34
		[DoNotToLua]
		public new MonthCardInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MonthCardInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D13D RID: 53565 RVA: 0x00394B40 File Offset: 0x00392D40
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D13E RID: 53566 RVA: 0x00394B4C File Offset: 0x00392D4C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D13F RID: 53567 RVA: 0x00394B54 File Offset: 0x00392D54
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D140 RID: 53568 RVA: 0x00394B5C File Offset: 0x00392D5C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D141 RID: 53569 RVA: 0x00394B70 File Offset: 0x00392D70
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D142 RID: 53570 RVA: 0x00394B78 File Offset: 0x00392D78
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x00394B84 File Offset: 0x00392D84
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D144 RID: 53572 RVA: 0x00394B90 File Offset: 0x00392D90
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D145 RID: 53573 RVA: 0x00394B9C File Offset: 0x00392D9C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D146 RID: 53574 RVA: 0x00394BA8 File Offset: 0x00392DA8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D147 RID: 53575 RVA: 0x00394BB4 File Offset: 0x00392DB4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D148 RID: 53576 RVA: 0x00394BC0 File Offset: 0x00392DC0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D149 RID: 53577 RVA: 0x00394BCC File Offset: 0x00392DCC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D14A RID: 53578 RVA: 0x00394BD8 File Offset: 0x00392DD8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D14B RID: 53579 RVA: 0x00394BE4 File Offset: 0x00392DE4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D14C RID: 53580 RVA: 0x00394BEC File Offset: 0x00392DEC
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D14D RID: 53581 RVA: 0x00394C0C File Offset: 0x00392E0C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D14E RID: 53582 RVA: 0x00394C18 File Offset: 0x00392E18
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
					this.m_ShowRewardInt32_hotfix = (luaObj.RawGet("ShowReward") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x00394D48 File Offset: 0x00392F48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MonthCardInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008212 RID: 33298
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController PanelStateController;

		// Token: 0x04008213 RID: 33299
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button BackgroundButton;

		// Token: 0x04008214 RID: 33300
		[AutoBind("./LayoutRoot/ItemDesc/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text NameText;

		// Token: 0x04008215 RID: 33301
		[AutoBind("./LayoutRoot/ItemDesc/Item/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image IconImage;

		// Token: 0x04008216 RID: 33302
		[AutoBind("./LayoutRoot/ItemDesc/LeftDay", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject LeftDaysGameObject;

		// Token: 0x04008217 RID: 33303
		[AutoBind("./LayoutRoot/ItemDesc/LeftDay/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text LeftDays;

		// Token: 0x04008218 RID: 33304
		[AutoBind("./LayoutRoot/ListPanel/TitleImage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController MonthCardOrSubscribeStateCtrl;

		// Token: 0x04008219 RID: 33305
		[AutoBind("./LayoutRoot/ListPanel/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private Text DescText;

		// Token: 0x0400821A RID: 33306
		[DoNotToLua]
		private MonthCardInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400821B RID: 33307
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400821C RID: 33308
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400821D RID: 33309
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400821E RID: 33310
		private LuaFunction m_ShowRewardInt32_hotfix;

		// Token: 0x0400821F RID: 33311
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04008220 RID: 33312
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008221 RID: 33313
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000BD9 RID: 3033
		public new class LuaExportHelper
		{
			// Token: 0x0600D150 RID: 53584 RVA: 0x00394DB0 File Offset: 0x00392FB0
			public LuaExportHelper(MonthCardInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D151 RID: 53585 RVA: 0x00394DC0 File Offset: 0x00392FC0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D152 RID: 53586 RVA: 0x00394DD0 File Offset: 0x00392FD0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D153 RID: 53587 RVA: 0x00394DE0 File Offset: 0x00392FE0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D154 RID: 53588 RVA: 0x00394DF0 File Offset: 0x00392FF0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D155 RID: 53589 RVA: 0x00394E08 File Offset: 0x00393008
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D156 RID: 53590 RVA: 0x00394E18 File Offset: 0x00393018
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D157 RID: 53591 RVA: 0x00394E28 File Offset: 0x00393028
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D158 RID: 53592 RVA: 0x00394E38 File Offset: 0x00393038
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D159 RID: 53593 RVA: 0x00394E48 File Offset: 0x00393048
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D15A RID: 53594 RVA: 0x00394E58 File Offset: 0x00393058
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D15B RID: 53595 RVA: 0x00394E68 File Offset: 0x00393068
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D15C RID: 53596 RVA: 0x00394E78 File Offset: 0x00393078
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D15D RID: 53597 RVA: 0x00394E88 File Offset: 0x00393088
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D15E RID: 53598 RVA: 0x00394E98 File Offset: 0x00393098
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D15F RID: 53599 RVA: 0x00394EA8 File Offset: 0x003930A8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D160 RID: 53600 RVA: 0x00394EB8 File Offset: 0x003930B8
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D161 RID: 53601 RVA: 0x00394EC8 File Offset: 0x003930C8
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x1700292B RID: 10539
			// (get) Token: 0x0600D162 RID: 53602 RVA: 0x00394ED8 File Offset: 0x003930D8
			// (set) Token: 0x0600D163 RID: 53603 RVA: 0x00394EE8 File Offset: 0x003930E8
			public CommonUIStateController PanelStateController
			{
				get
				{
					return this.m_owner.PanelStateController;
				}
				set
				{
					this.m_owner.PanelStateController = value;
				}
			}

			// Token: 0x1700292C RID: 10540
			// (get) Token: 0x0600D164 RID: 53604 RVA: 0x00394EF8 File Offset: 0x003930F8
			// (set) Token: 0x0600D165 RID: 53605 RVA: 0x00394F08 File Offset: 0x00393108
			public Button BackgroundButton
			{
				get
				{
					return this.m_owner.BackgroundButton;
				}
				set
				{
					this.m_owner.BackgroundButton = value;
				}
			}

			// Token: 0x1700292D RID: 10541
			// (get) Token: 0x0600D166 RID: 53606 RVA: 0x00394F18 File Offset: 0x00393118
			// (set) Token: 0x0600D167 RID: 53607 RVA: 0x00394F28 File Offset: 0x00393128
			public Text NameText
			{
				get
				{
					return this.m_owner.NameText;
				}
				set
				{
					this.m_owner.NameText = value;
				}
			}

			// Token: 0x1700292E RID: 10542
			// (get) Token: 0x0600D168 RID: 53608 RVA: 0x00394F38 File Offset: 0x00393138
			// (set) Token: 0x0600D169 RID: 53609 RVA: 0x00394F48 File Offset: 0x00393148
			public Image IconImage
			{
				get
				{
					return this.m_owner.IconImage;
				}
				set
				{
					this.m_owner.IconImage = value;
				}
			}

			// Token: 0x1700292F RID: 10543
			// (get) Token: 0x0600D16A RID: 53610 RVA: 0x00394F58 File Offset: 0x00393158
			// (set) Token: 0x0600D16B RID: 53611 RVA: 0x00394F68 File Offset: 0x00393168
			public GameObject LeftDaysGameObject
			{
				get
				{
					return this.m_owner.LeftDaysGameObject;
				}
				set
				{
					this.m_owner.LeftDaysGameObject = value;
				}
			}

			// Token: 0x17002930 RID: 10544
			// (get) Token: 0x0600D16C RID: 53612 RVA: 0x00394F78 File Offset: 0x00393178
			// (set) Token: 0x0600D16D RID: 53613 RVA: 0x00394F88 File Offset: 0x00393188
			public Text LeftDays
			{
				get
				{
					return this.m_owner.LeftDays;
				}
				set
				{
					this.m_owner.LeftDays = value;
				}
			}

			// Token: 0x17002931 RID: 10545
			// (get) Token: 0x0600D16E RID: 53614 RVA: 0x00394F98 File Offset: 0x00393198
			// (set) Token: 0x0600D16F RID: 53615 RVA: 0x00394FA8 File Offset: 0x003931A8
			public CommonUIStateController MonthCardOrSubscribeStateCtrl
			{
				get
				{
					return this.m_owner.MonthCardOrSubscribeStateCtrl;
				}
				set
				{
					this.m_owner.MonthCardOrSubscribeStateCtrl = value;
				}
			}

			// Token: 0x17002932 RID: 10546
			// (get) Token: 0x0600D170 RID: 53616 RVA: 0x00394FB8 File Offset: 0x003931B8
			// (set) Token: 0x0600D171 RID: 53617 RVA: 0x00394FC8 File Offset: 0x003931C8
			public Text DescText
			{
				get
				{
					return this.m_owner.DescText;
				}
				set
				{
					this.m_owner.DescText = value;
				}
			}

			// Token: 0x0600D172 RID: 53618 RVA: 0x00394FD8 File Offset: 0x003931D8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D173 RID: 53619 RVA: 0x00394FE8 File Offset: 0x003931E8
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04008222 RID: 33314
			private MonthCardInfoUIController m_owner;
		}
	}
}
