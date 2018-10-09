using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001024 RID: 4132
	[HotFix]
	public class WorldMonthCardItemUIController : UIControllerBase
	{
		// Token: 0x06014EDF RID: 85727 RVA: 0x0054C65C File Offset: 0x0054A85C
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
			this.m_itemButton.onClick.AddListener(new UnityAction(this.OnItemButtonClick));
			this.m_buyButton.onClick.AddListener(new UnityAction(this.OnBuyButtonClick));
		}

		// Token: 0x06014EE0 RID: 85728 RVA: 0x0054C6FC File Offset: 0x0054A8FC
		public void UpdateItemInfo(int cardId, string iconName, string titleName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoInt32StringString_hotfix != null)
			{
				this.m_UpdateItemInfoInt32StringString_hotfix.call(new object[]
				{
					this,
					cardId,
					iconName,
					titleName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CardId = cardId;
			this.m_nameText.text = titleName;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(iconName);
		}

		// Token: 0x06014EE1 RID: 85729 RVA: 0x0054C7B8 File Offset: 0x0054A9B8
		public void UpdateRemainTime(string time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRemainTimeString_hotfix != null)
			{
				this.m_UpdateRemainTimeString_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_remainTimeText.text = time;
		}

		// Token: 0x06014EE2 RID: 85730 RVA: 0x0054C834 File Offset: 0x0054AA34
		private void OnItemButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemButtonClick_hotfix != null)
			{
				this.m_OnItemButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnItemButtonClick != null)
			{
				this.EventOnItemButtonClick(this.CardId);
			}
		}

		// Token: 0x06014EE3 RID: 85731 RVA: 0x0054C8B0 File Offset: 0x0054AAB0
		private void OnBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyButtonClick_hotfix != null)
			{
				this.m_OnBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnItemBuyButtonClick != null)
			{
				this.EventOnItemBuyButtonClick(this.CardId);
			}
		}

		// Token: 0x140004A0 RID: 1184
		// (add) Token: 0x06014EE4 RID: 85732 RVA: 0x0054C92C File Offset: 0x0054AB2C
		// (remove) Token: 0x06014EE5 RID: 85733 RVA: 0x0054C9C8 File Offset: 0x0054ABC8
		public event Action<int> EventOnItemButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnItemButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnItemButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnItemButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnItemButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnItemButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnItemButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnItemButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnItemButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004A1 RID: 1185
		// (add) Token: 0x06014EE6 RID: 85734 RVA: 0x0054CA64 File Offset: 0x0054AC64
		// (remove) Token: 0x06014EE7 RID: 85735 RVA: 0x0054CB00 File Offset: 0x0054AD00
		public event Action<int> EventOnItemBuyButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnItemBuyButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnItemBuyButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnItemBuyButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnItemBuyButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnItemBuyButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnItemBuyButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnItemBuyButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnItemBuyButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x06014EE8 RID: 85736 RVA: 0x0054CB9C File Offset: 0x0054AD9C
		// (set) Token: 0x06014EE9 RID: 85737 RVA: 0x0054CBBC File Offset: 0x0054ADBC
		[DoNotToLua]
		public new WorldMonthCardItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldMonthCardItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014EEA RID: 85738 RVA: 0x0054CBC8 File Offset: 0x0054ADC8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014EEB RID: 85739 RVA: 0x0054CBD4 File Offset: 0x0054ADD4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014EEC RID: 85740 RVA: 0x0054CBDC File Offset: 0x0054ADDC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014EED RID: 85741 RVA: 0x0054CBE4 File Offset: 0x0054ADE4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014EEE RID: 85742 RVA: 0x0054CBF8 File Offset: 0x0054ADF8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014EEF RID: 85743 RVA: 0x0054CC00 File Offset: 0x0054AE00
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014EF0 RID: 85744 RVA: 0x0054CC0C File Offset: 0x0054AE0C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014EF1 RID: 85745 RVA: 0x0054CC18 File Offset: 0x0054AE18
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014EF2 RID: 85746 RVA: 0x0054CC24 File Offset: 0x0054AE24
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014EF3 RID: 85747 RVA: 0x0054CC30 File Offset: 0x0054AE30
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014EF4 RID: 85748 RVA: 0x0054CC3C File Offset: 0x0054AE3C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014EF5 RID: 85749 RVA: 0x0054CC48 File Offset: 0x0054AE48
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014EF6 RID: 85750 RVA: 0x0054CC54 File Offset: 0x0054AE54
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014EF7 RID: 85751 RVA: 0x0054CC60 File Offset: 0x0054AE60
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014EF8 RID: 85752 RVA: 0x0054CC6C File Offset: 0x0054AE6C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014EF9 RID: 85753 RVA: 0x0054CC74 File Offset: 0x0054AE74
		private void __callDele_EventOnItemButtonClick(int obj)
		{
			Action<int> eventOnItemButtonClick = this.EventOnItemButtonClick;
			if (eventOnItemButtonClick != null)
			{
				eventOnItemButtonClick(obj);
			}
		}

		// Token: 0x06014EFA RID: 85754 RVA: 0x0054CC98 File Offset: 0x0054AE98
		private void __clearDele_EventOnItemButtonClick(int obj)
		{
			this.EventOnItemButtonClick = null;
		}

		// Token: 0x06014EFB RID: 85755 RVA: 0x0054CCA4 File Offset: 0x0054AEA4
		private void __callDele_EventOnItemBuyButtonClick(int obj)
		{
			Action<int> eventOnItemBuyButtonClick = this.EventOnItemBuyButtonClick;
			if (eventOnItemBuyButtonClick != null)
			{
				eventOnItemBuyButtonClick(obj);
			}
		}

		// Token: 0x06014EFC RID: 85756 RVA: 0x0054CCC8 File Offset: 0x0054AEC8
		private void __clearDele_EventOnItemBuyButtonClick(int obj)
		{
			this.EventOnItemBuyButtonClick = null;
		}

		// Token: 0x06014EFD RID: 85757 RVA: 0x0054CCD4 File Offset: 0x0054AED4
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
					this.m_UpdateItemInfoInt32StringString_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_UpdateRemainTimeString_hotfix = (luaObj.RawGet("UpdateRemainTime") as LuaFunction);
					this.m_OnItemButtonClick_hotfix = (luaObj.RawGet("OnItemButtonClick") as LuaFunction);
					this.m_OnBuyButtonClick_hotfix = (luaObj.RawGet("OnBuyButtonClick") as LuaFunction);
					this.m_add_EventOnItemButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnItemButtonClick") as LuaFunction);
					this.m_remove_EventOnItemButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnItemButtonClick") as LuaFunction);
					this.m_add_EventOnItemBuyButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnItemBuyButtonClick") as LuaFunction);
					this.m_remove_EventOnItemBuyButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnItemBuyButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014EFE RID: 85758 RVA: 0x0054CE68 File Offset: 0x0054B068
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldMonthCardItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B6F6 RID: 46838
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemButton;

		// Token: 0x0400B6F7 RID: 46839
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400B6F8 RID: 46840
		[AutoBind("./Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buyButton;

		// Token: 0x0400B6F9 RID: 46841
		[AutoBind("./CountText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_remainTimeText;

		// Token: 0x0400B6FA RID: 46842
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400B6FB RID: 46843
		public int CardId;

		// Token: 0x0400B6FC RID: 46844
		[DoNotToLua]
		private WorldMonthCardItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B6FD RID: 46845
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B6FE RID: 46846
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B6FF RID: 46847
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B700 RID: 46848
		private LuaFunction m_UpdateItemInfoInt32StringString_hotfix;

		// Token: 0x0400B701 RID: 46849
		private LuaFunction m_UpdateRemainTimeString_hotfix;

		// Token: 0x0400B702 RID: 46850
		private LuaFunction m_OnItemButtonClick_hotfix;

		// Token: 0x0400B703 RID: 46851
		private LuaFunction m_OnBuyButtonClick_hotfix;

		// Token: 0x0400B704 RID: 46852
		private LuaFunction m_add_EventOnItemButtonClickAction;

		// Token: 0x0400B705 RID: 46853
		private LuaFunction m_remove_EventOnItemButtonClickAction;

		// Token: 0x0400B706 RID: 46854
		private LuaFunction m_add_EventOnItemBuyButtonClickAction;

		// Token: 0x0400B707 RID: 46855
		private LuaFunction m_remove_EventOnItemBuyButtonClickAction;

		// Token: 0x02001025 RID: 4133
		public new class LuaExportHelper
		{
			// Token: 0x06014EFF RID: 85759 RVA: 0x0054CED0 File Offset: 0x0054B0D0
			public LuaExportHelper(WorldMonthCardItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014F00 RID: 85760 RVA: 0x0054CEE0 File Offset: 0x0054B0E0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014F01 RID: 85761 RVA: 0x0054CEF0 File Offset: 0x0054B0F0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014F02 RID: 85762 RVA: 0x0054CF00 File Offset: 0x0054B100
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014F03 RID: 85763 RVA: 0x0054CF10 File Offset: 0x0054B110
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014F04 RID: 85764 RVA: 0x0054CF28 File Offset: 0x0054B128
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014F05 RID: 85765 RVA: 0x0054CF38 File Offset: 0x0054B138
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014F06 RID: 85766 RVA: 0x0054CF48 File Offset: 0x0054B148
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014F07 RID: 85767 RVA: 0x0054CF58 File Offset: 0x0054B158
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014F08 RID: 85768 RVA: 0x0054CF68 File Offset: 0x0054B168
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014F09 RID: 85769 RVA: 0x0054CF78 File Offset: 0x0054B178
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014F0A RID: 85770 RVA: 0x0054CF88 File Offset: 0x0054B188
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014F0B RID: 85771 RVA: 0x0054CF98 File Offset: 0x0054B198
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014F0C RID: 85772 RVA: 0x0054CFA8 File Offset: 0x0054B1A8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014F0D RID: 85773 RVA: 0x0054CFB8 File Offset: 0x0054B1B8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014F0E RID: 85774 RVA: 0x0054CFC8 File Offset: 0x0054B1C8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014F0F RID: 85775 RVA: 0x0054CFD8 File Offset: 0x0054B1D8
			public void __callDele_EventOnItemButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnItemButtonClick(obj);
			}

			// Token: 0x06014F10 RID: 85776 RVA: 0x0054CFE8 File Offset: 0x0054B1E8
			public void __clearDele_EventOnItemButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnItemButtonClick(obj);
			}

			// Token: 0x06014F11 RID: 85777 RVA: 0x0054CFF8 File Offset: 0x0054B1F8
			public void __callDele_EventOnItemBuyButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnItemBuyButtonClick(obj);
			}

			// Token: 0x06014F12 RID: 85778 RVA: 0x0054D008 File Offset: 0x0054B208
			public void __clearDele_EventOnItemBuyButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnItemBuyButtonClick(obj);
			}

			// Token: 0x17003DAC RID: 15788
			// (get) Token: 0x06014F13 RID: 85779 RVA: 0x0054D018 File Offset: 0x0054B218
			// (set) Token: 0x06014F14 RID: 85780 RVA: 0x0054D028 File Offset: 0x0054B228
			public Button m_itemButton
			{
				get
				{
					return this.m_owner.m_itemButton;
				}
				set
				{
					this.m_owner.m_itemButton = value;
				}
			}

			// Token: 0x17003DAD RID: 15789
			// (get) Token: 0x06014F15 RID: 85781 RVA: 0x0054D038 File Offset: 0x0054B238
			// (set) Token: 0x06014F16 RID: 85782 RVA: 0x0054D048 File Offset: 0x0054B248
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

			// Token: 0x17003DAE RID: 15790
			// (get) Token: 0x06014F17 RID: 85783 RVA: 0x0054D058 File Offset: 0x0054B258
			// (set) Token: 0x06014F18 RID: 85784 RVA: 0x0054D068 File Offset: 0x0054B268
			public Button m_buyButton
			{
				get
				{
					return this.m_owner.m_buyButton;
				}
				set
				{
					this.m_owner.m_buyButton = value;
				}
			}

			// Token: 0x17003DAF RID: 15791
			// (get) Token: 0x06014F19 RID: 85785 RVA: 0x0054D078 File Offset: 0x0054B278
			// (set) Token: 0x06014F1A RID: 85786 RVA: 0x0054D088 File Offset: 0x0054B288
			public Text m_remainTimeText
			{
				get
				{
					return this.m_owner.m_remainTimeText;
				}
				set
				{
					this.m_owner.m_remainTimeText = value;
				}
			}

			// Token: 0x17003DB0 RID: 15792
			// (get) Token: 0x06014F1B RID: 85787 RVA: 0x0054D098 File Offset: 0x0054B298
			// (set) Token: 0x06014F1C RID: 85788 RVA: 0x0054D0A8 File Offset: 0x0054B2A8
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

			// Token: 0x06014F1D RID: 85789 RVA: 0x0054D0B8 File Offset: 0x0054B2B8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014F1E RID: 85790 RVA: 0x0054D0C8 File Offset: 0x0054B2C8
			public void OnItemButtonClick()
			{
				this.m_owner.OnItemButtonClick();
			}

			// Token: 0x06014F1F RID: 85791 RVA: 0x0054D0D8 File Offset: 0x0054B2D8
			public void OnBuyButtonClick()
			{
				this.m_owner.OnBuyButtonClick();
			}

			// Token: 0x0400B708 RID: 46856
			private WorldMonthCardItemUIController m_owner;
		}
	}
}
