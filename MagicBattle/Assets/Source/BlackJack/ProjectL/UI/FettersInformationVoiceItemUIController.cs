using System;
using System.Collections.Generic;
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
	// Token: 0x02000C84 RID: 3204
	[HotFix]
	public class FettersInformationVoiceItemUIController : UIControllerBase
	{
		// Token: 0x0600E6C6 RID: 59078 RVA: 0x003DE140 File Offset: 0x003DC340
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
			base.gameObject.SetActive(true);
			this.m_voiceButton.onClick.AddListener(new UnityAction(this.OnVoiceButtonClick));
		}

		// Token: 0x0600E6C7 RID: 59079 RVA: 0x003DE1D0 File Offset: 0x003DC3D0
		public void InitVoiceItem(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitVoiceItemInt32_hotfix != null)
			{
				this.m_InitVoiceItemInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.HeroPerformanceInfo = configDataLoader.GetConfigDataHeroPerformanceInfo(heroPerformanceId);
			if (this.HeroPerformanceInfo == null)
			{
				return;
			}
			this.m_isLock = (projectLPlayerContext.CanUnlockHeroPerformance(heroPerformanceId) != 0);
			this.UpdateIsNewValue();
			if (this.m_isLock)
			{
				this.m_uiStateCtrl.SetToUIState("Lock", false, true);
				int param = this.HeroPerformanceInfo.UnlockConditions[0].Param2;
				this.m_lockText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_FavorabilityLimit), param);
			}
			else
			{
				this.m_uiStateCtrl.SetToUIState("Unlock", false, true);
				this.m_unlockNameText.text = this.HeroPerformanceInfo.Name;
				bool? isNew = this.IsNew;
				if (isNew.Value)
				{
					this.m_uiStateCtrl.SetToUIState("New", false, true);
				}
				bool? isNew2 = this.IsNew;
				if (isNew2.Value)
				{
					LocalAccountConfig.Instance.AddHaveReadHeroPerformance(heroPerformanceId);
				}
			}
		}

		// Token: 0x0600E6C8 RID: 59080 RVA: 0x003DE358 File Offset: 0x003DC558
		private bool IsPerformanceRead(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPerformanceReadInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPerformanceReadInt32_hotfix.call(new object[]
				{
					this,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list;
			if (LocalAccountConfig.Instance.Data.HaveReadHeroPerformanceIds != null)
			{
				list = new List<int>(LocalAccountConfig.Instance.Data.HaveReadHeroPerformanceIds);
			}
			else
			{
				list = new List<int>();
			}
			return list.Count != 0 && list.Contains(id);
		}

		// Token: 0x0600E6C9 RID: 59081 RVA: 0x003DE41C File Offset: 0x003DC61C
		private void OnVoiceButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnVoiceButtonClick_hotfix != null)
			{
				this.m_OnVoiceButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HeroPerformanceInfo == null)
			{
				return;
			}
			this.UpdateIsNewValue();
			bool? isNew = this.IsNew;
			if (isNew.Value)
			{
				LocalAccountConfig.Instance.AddHaveReadHeroPerformance(this.HeroPerformanceInfo.ID);
			}
			if (this.EventOnVoiceButtonClick != null)
			{
				this.EventOnVoiceButtonClick(this);
			}
		}

		// Token: 0x0600E6CA RID: 59082 RVA: 0x003DE4D0 File Offset: 0x003DC6D0
		public void UpdateIsNewValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateIsNewValue_hotfix != null)
			{
				this.m_UpdateIsNewValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isLock)
			{
				return;
			}
			if (this.HeroPerformanceInfo != null)
			{
				this.IsNew = new bool?(!this.IsPerformanceRead(this.HeroPerformanceInfo.ID));
			}
		}

		// Token: 0x0600E6CB RID: 59083 RVA: 0x003DE568 File Offset: 0x003DC768
		public bool IsNewTagActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNewTagActive_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNewTagActive_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_uiStateCtrl.GetCurrentUIState();
			return currentUIState != null && currentUIState.StateName == "New";
		}

		// Token: 0x140002F0 RID: 752
		// (add) Token: 0x0600E6CC RID: 59084 RVA: 0x003DE5FC File Offset: 0x003DC7FC
		// (remove) Token: 0x0600E6CD RID: 59085 RVA: 0x003DE698 File Offset: 0x003DC898
		public event Action<FettersInformationVoiceItemUIController> EventOnVoiceButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnVoiceButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnVoiceButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FettersInformationVoiceItemUIController> action = this.EventOnVoiceButtonClick;
				Action<FettersInformationVoiceItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FettersInformationVoiceItemUIController>>(ref this.EventOnVoiceButtonClick, (Action<FettersInformationVoiceItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnVoiceButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnVoiceButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FettersInformationVoiceItemUIController> action = this.EventOnVoiceButtonClick;
				Action<FettersInformationVoiceItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FettersInformationVoiceItemUIController>>(ref this.EventOnVoiceButtonClick, (Action<FettersInformationVoiceItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600E6CE RID: 59086 RVA: 0x003DE734 File Offset: 0x003DC934
		// (set) Token: 0x0600E6CF RID: 59087 RVA: 0x003DE754 File Offset: 0x003DC954
		[DoNotToLua]
		public new FettersInformationVoiceItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersInformationVoiceItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E6D0 RID: 59088 RVA: 0x003DE760 File Offset: 0x003DC960
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E6D1 RID: 59089 RVA: 0x003DE76C File Offset: 0x003DC96C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E6D2 RID: 59090 RVA: 0x003DE774 File Offset: 0x003DC974
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x003DE77C File Offset: 0x003DC97C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x003DE790 File Offset: 0x003DC990
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E6D5 RID: 59093 RVA: 0x003DE798 File Offset: 0x003DC998
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E6D6 RID: 59094 RVA: 0x003DE7A4 File Offset: 0x003DC9A4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x003DE7B0 File Offset: 0x003DC9B0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x003DE7BC File Offset: 0x003DC9BC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x003DE7C8 File Offset: 0x003DC9C8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x003DE7D4 File Offset: 0x003DC9D4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E6DB RID: 59099 RVA: 0x003DE7E0 File Offset: 0x003DC9E0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x003DE7EC File Offset: 0x003DC9EC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E6DD RID: 59101 RVA: 0x003DE7F8 File Offset: 0x003DC9F8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x003DE804 File Offset: 0x003DCA04
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E6DF RID: 59103 RVA: 0x003DE80C File Offset: 0x003DCA0C
		private void __callDele_EventOnVoiceButtonClick(FettersInformationVoiceItemUIController obj)
		{
			Action<FettersInformationVoiceItemUIController> eventOnVoiceButtonClick = this.EventOnVoiceButtonClick;
			if (eventOnVoiceButtonClick != null)
			{
				eventOnVoiceButtonClick(obj);
			}
		}

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x003DE830 File Offset: 0x003DCA30
		private void __clearDele_EventOnVoiceButtonClick(FettersInformationVoiceItemUIController obj)
		{
			this.EventOnVoiceButtonClick = null;
		}

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x003DE83C File Offset: 0x003DCA3C
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
					this.m_InitVoiceItemInt32_hotfix = (luaObj.RawGet("InitVoiceItem") as LuaFunction);
					this.m_IsPerformanceReadInt32_hotfix = (luaObj.RawGet("IsPerformanceRead") as LuaFunction);
					this.m_OnVoiceButtonClick_hotfix = (luaObj.RawGet("OnVoiceButtonClick") as LuaFunction);
					this.m_UpdateIsNewValue_hotfix = (luaObj.RawGet("UpdateIsNewValue") as LuaFunction);
					this.m_IsNewTagActive_hotfix = (luaObj.RawGet("IsNewTagActive") as LuaFunction);
					this.m_add_EventOnVoiceButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnVoiceButtonClick") as LuaFunction);
					this.m_remove_EventOnVoiceButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnVoiceButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x003DE9B8 File Offset: 0x003DCBB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersInformationVoiceItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008B16 RID: 35606
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateCtrl;

		// Token: 0x04008B17 RID: 35607
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockNameText;

		// Token: 0x04008B18 RID: 35608
		[AutoBind("./VoiceButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_voiceButton;

		// Token: 0x04008B19 RID: 35609
		[AutoBind("./Lock/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockText;

		// Token: 0x04008B1A RID: 35610
		public ConfigDataHeroPerformanceInfo HeroPerformanceInfo;

		// Token: 0x04008B1B RID: 35611
		public bool? IsNew;

		// Token: 0x04008B1C RID: 35612
		private bool m_isLock;

		// Token: 0x04008B1D RID: 35613
		[DoNotToLua]
		private FettersInformationVoiceItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008B1E RID: 35614
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008B1F RID: 35615
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008B20 RID: 35616
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008B21 RID: 35617
		private LuaFunction m_InitVoiceItemInt32_hotfix;

		// Token: 0x04008B22 RID: 35618
		private LuaFunction m_IsPerformanceReadInt32_hotfix;

		// Token: 0x04008B23 RID: 35619
		private LuaFunction m_OnVoiceButtonClick_hotfix;

		// Token: 0x04008B24 RID: 35620
		private LuaFunction m_UpdateIsNewValue_hotfix;

		// Token: 0x04008B25 RID: 35621
		private LuaFunction m_IsNewTagActive_hotfix;

		// Token: 0x04008B26 RID: 35622
		private LuaFunction m_add_EventOnVoiceButtonClickAction;

		// Token: 0x04008B27 RID: 35623
		private LuaFunction m_remove_EventOnVoiceButtonClickAction;

		// Token: 0x02000C85 RID: 3205
		public new class LuaExportHelper
		{
			// Token: 0x0600E6E3 RID: 59107 RVA: 0x003DEA20 File Offset: 0x003DCC20
			public LuaExportHelper(FettersInformationVoiceItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E6E4 RID: 59108 RVA: 0x003DEA30 File Offset: 0x003DCC30
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E6E5 RID: 59109 RVA: 0x003DEA40 File Offset: 0x003DCC40
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E6E6 RID: 59110 RVA: 0x003DEA50 File Offset: 0x003DCC50
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E6E7 RID: 59111 RVA: 0x003DEA60 File Offset: 0x003DCC60
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E6E8 RID: 59112 RVA: 0x003DEA78 File Offset: 0x003DCC78
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E6E9 RID: 59113 RVA: 0x003DEA88 File Offset: 0x003DCC88
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E6EA RID: 59114 RVA: 0x003DEA98 File Offset: 0x003DCC98
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E6EB RID: 59115 RVA: 0x003DEAA8 File Offset: 0x003DCCA8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E6EC RID: 59116 RVA: 0x003DEAB8 File Offset: 0x003DCCB8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E6ED RID: 59117 RVA: 0x003DEAC8 File Offset: 0x003DCCC8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E6EE RID: 59118 RVA: 0x003DEAD8 File Offset: 0x003DCCD8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E6EF RID: 59119 RVA: 0x003DEAE8 File Offset: 0x003DCCE8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E6F0 RID: 59120 RVA: 0x003DEAF8 File Offset: 0x003DCCF8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E6F1 RID: 59121 RVA: 0x003DEB08 File Offset: 0x003DCD08
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E6F2 RID: 59122 RVA: 0x003DEB18 File Offset: 0x003DCD18
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E6F3 RID: 59123 RVA: 0x003DEB28 File Offset: 0x003DCD28
			public void __callDele_EventOnVoiceButtonClick(FettersInformationVoiceItemUIController obj)
			{
				this.m_owner.__callDele_EventOnVoiceButtonClick(obj);
			}

			// Token: 0x0600E6F4 RID: 59124 RVA: 0x003DEB38 File Offset: 0x003DCD38
			public void __clearDele_EventOnVoiceButtonClick(FettersInformationVoiceItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnVoiceButtonClick(obj);
			}

			// Token: 0x17002CD4 RID: 11476
			// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x003DEB48 File Offset: 0x003DCD48
			// (set) Token: 0x0600E6F6 RID: 59126 RVA: 0x003DEB58 File Offset: 0x003DCD58
			public CommonUIStateController m_uiStateCtrl
			{
				get
				{
					return this.m_owner.m_uiStateCtrl;
				}
				set
				{
					this.m_owner.m_uiStateCtrl = value;
				}
			}

			// Token: 0x17002CD5 RID: 11477
			// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x003DEB68 File Offset: 0x003DCD68
			// (set) Token: 0x0600E6F8 RID: 59128 RVA: 0x003DEB78 File Offset: 0x003DCD78
			public Text m_unlockNameText
			{
				get
				{
					return this.m_owner.m_unlockNameText;
				}
				set
				{
					this.m_owner.m_unlockNameText = value;
				}
			}

			// Token: 0x17002CD6 RID: 11478
			// (get) Token: 0x0600E6F9 RID: 59129 RVA: 0x003DEB88 File Offset: 0x003DCD88
			// (set) Token: 0x0600E6FA RID: 59130 RVA: 0x003DEB98 File Offset: 0x003DCD98
			public Button m_voiceButton
			{
				get
				{
					return this.m_owner.m_voiceButton;
				}
				set
				{
					this.m_owner.m_voiceButton = value;
				}
			}

			// Token: 0x17002CD7 RID: 11479
			// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x003DEBA8 File Offset: 0x003DCDA8
			// (set) Token: 0x0600E6FC RID: 59132 RVA: 0x003DEBB8 File Offset: 0x003DCDB8
			public Text m_lockText
			{
				get
				{
					return this.m_owner.m_lockText;
				}
				set
				{
					this.m_owner.m_lockText = value;
				}
			}

			// Token: 0x17002CD8 RID: 11480
			// (get) Token: 0x0600E6FD RID: 59133 RVA: 0x003DEBC8 File Offset: 0x003DCDC8
			// (set) Token: 0x0600E6FE RID: 59134 RVA: 0x003DEBD8 File Offset: 0x003DCDD8
			public bool m_isLock
			{
				get
				{
					return this.m_owner.m_isLock;
				}
				set
				{
					this.m_owner.m_isLock = value;
				}
			}

			// Token: 0x0600E6FF RID: 59135 RVA: 0x003DEBE8 File Offset: 0x003DCDE8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E700 RID: 59136 RVA: 0x003DEBF8 File Offset: 0x003DCDF8
			public bool IsPerformanceRead(int id)
			{
				return this.m_owner.IsPerformanceRead(id);
			}

			// Token: 0x0600E701 RID: 59137 RVA: 0x003DEC08 File Offset: 0x003DCE08
			public void OnVoiceButtonClick()
			{
				this.m_owner.OnVoiceButtonClick();
			}

			// Token: 0x04008B28 RID: 35624
			private FettersInformationVoiceItemUIController m_owner;
		}
	}
}
