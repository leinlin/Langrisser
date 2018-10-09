using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F82 RID: 3970
	[HotFix]
	public class TeamLocationListItemUIController : UIControllerBase
	{
		// Token: 0x06013D96 RID: 81302 RVA: 0x0050E6A4 File Offset: 0x0050C8A4
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleValueChanged));
			this.m_lockButton.onClick.AddListener(new UnityAction(this.OnLockButtonClick));
		}

		// Token: 0x06013D97 RID: 81303 RVA: 0x0050E744 File Offset: 0x0050C944
		public void SetName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNameString_hotfix != null)
			{
				this.m_SetNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text nameTextChosen = this.m_nameTextChosen;
			this.m_nameTextUnchosen.text = name;
			nameTextChosen.text = name;
		}

		// Token: 0x06013D98 RID: 81304 RVA: 0x0050E7D0 File Offset: 0x0050C9D0
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_nameTextChosen.text;
		}

		// Token: 0x06013D99 RID: 81305 RVA: 0x0050E848 File Offset: 0x0050CA48
		public void SetLocationId(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLocationIdInt32_hotfix != null)
			{
				this.m_SetLocationIdInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_locationId = levelId;
		}

		// Token: 0x06013D9A RID: 81306 RVA: 0x0050E8C0 File Offset: 0x0050CAC0
		public int GetLocationId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLocationId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLocationId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_locationId;
		}

		// Token: 0x06013D9B RID: 81307 RVA: 0x0050E934 File Offset: 0x0050CB34
		public void SetEnergy(int energy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnergyInt32_hotfix != null)
			{
				this.m_SetEnergyInt32_hotfix.call(new object[]
				{
					this,
					energy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text energyTextChosen = this.m_energyTextChosen;
			string text = energy.ToString();
			this.m_energyTextUnchosen.text = text;
			energyTextChosen.text = text;
			bool active = energy > 0;
			this.m_energyIconImage.gameObject.SetActive(active);
			this.m_energyTextChosen.gameObject.SetActive(active);
			this.m_energyXTextChosen.gameObject.SetActive(active);
			this.m_energyTextUnchosen.gameObject.SetActive(active);
			this.m_energyXTextUnchosen.gameObject.SetActive(active);
		}

		// Token: 0x06013D9C RID: 81308 RVA: 0x0050EA24 File Offset: 0x0050CC24
		public void SetLocked(bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState((!isLocked) ? "Normal" : "Lock", false, true);
			this.m_isLocked = isLocked;
		}

		// Token: 0x06013D9D RID: 81309 RVA: 0x0050EAC0 File Offset: 0x0050CCC0
		public bool IsLocked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLocked_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLocked_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isLocked;
		}

		// Token: 0x06013D9E RID: 81310 RVA: 0x0050EB34 File Offset: 0x0050CD34
		public void SetToggleValue(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleValueBoolean_hotfix != null)
			{
				this.m_SetToggleValueBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_toggle.isOn = on;
		}

		// Token: 0x06013D9F RID: 81311 RVA: 0x0050EBB0 File Offset: 0x0050CDB0
		public bool GetToggleValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetToggleValue_hotfix != null)
			{
				return Convert.ToBoolean(this.m_GetToggleValue_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_toggle.isOn;
		}

		// Token: 0x06013DA0 RID: 81312 RVA: 0x0050EC28 File Offset: 0x0050CE28
		private void OnToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnToggleValueChanged != null)
			{
				this.EventOnToggleValueChanged(on, this);
			}
		}

		// Token: 0x06013DA1 RID: 81313 RVA: 0x0050ECB0 File Offset: 0x0050CEB0
		private void OnLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockButtonClick_hotfix != null)
			{
				this.m_OnLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			CommonUIController.Instance.ShowMessage(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_LocationNotOpen), 2f, null, true);
		}

		// Token: 0x1400045F RID: 1119
		// (add) Token: 0x06013DA2 RID: 81314 RVA: 0x0050ED3C File Offset: 0x0050CF3C
		// (remove) Token: 0x06013DA3 RID: 81315 RVA: 0x0050EDD8 File Offset: 0x0050CFD8
		public event Action<bool, TeamLocationListItemUIController> EventOnToggleValueChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnToggleValueChangedAction`2_hotfix != null)
				{
					this.m_add_EventOnToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, TeamLocationListItemUIController> action = this.EventOnToggleValueChanged;
				Action<bool, TeamLocationListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, TeamLocationListItemUIController>>(ref this.EventOnToggleValueChanged, (Action<bool, TeamLocationListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnToggleValueChangedAction`2_hotfix != null)
				{
					this.m_remove_EventOnToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, TeamLocationListItemUIController> action = this.EventOnToggleValueChanged;
				Action<bool, TeamLocationListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, TeamLocationListItemUIController>>(ref this.EventOnToggleValueChanged, (Action<bool, TeamLocationListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x06013DA4 RID: 81316 RVA: 0x0050EE74 File Offset: 0x0050D074
		// (set) Token: 0x06013DA5 RID: 81317 RVA: 0x0050EE94 File Offset: 0x0050D094
		[DoNotToLua]
		public new TeamLocationListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamLocationListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013DA6 RID: 81318 RVA: 0x0050EEA0 File Offset: 0x0050D0A0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013DA7 RID: 81319 RVA: 0x0050EEAC File Offset: 0x0050D0AC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013DA8 RID: 81320 RVA: 0x0050EEB4 File Offset: 0x0050D0B4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013DA9 RID: 81321 RVA: 0x0050EEBC File Offset: 0x0050D0BC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013DAA RID: 81322 RVA: 0x0050EED0 File Offset: 0x0050D0D0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013DAB RID: 81323 RVA: 0x0050EED8 File Offset: 0x0050D0D8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013DAC RID: 81324 RVA: 0x0050EEE4 File Offset: 0x0050D0E4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013DAD RID: 81325 RVA: 0x0050EEF0 File Offset: 0x0050D0F0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013DAE RID: 81326 RVA: 0x0050EEFC File Offset: 0x0050D0FC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013DAF RID: 81327 RVA: 0x0050EF08 File Offset: 0x0050D108
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013DB0 RID: 81328 RVA: 0x0050EF14 File Offset: 0x0050D114
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013DB1 RID: 81329 RVA: 0x0050EF20 File Offset: 0x0050D120
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013DB2 RID: 81330 RVA: 0x0050EF2C File Offset: 0x0050D12C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013DB3 RID: 81331 RVA: 0x0050EF38 File Offset: 0x0050D138
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013DB4 RID: 81332 RVA: 0x0050EF44 File Offset: 0x0050D144
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013DB5 RID: 81333 RVA: 0x0050EF4C File Offset: 0x0050D14C
		private void __callDele_EventOnToggleValueChanged(bool arg1, TeamLocationListItemUIController arg2)
		{
			Action<bool, TeamLocationListItemUIController> eventOnToggleValueChanged = this.EventOnToggleValueChanged;
			if (eventOnToggleValueChanged != null)
			{
				eventOnToggleValueChanged(arg1, arg2);
			}
		}

		// Token: 0x06013DB6 RID: 81334 RVA: 0x0050EF70 File Offset: 0x0050D170
		private void __clearDele_EventOnToggleValueChanged(bool arg1, TeamLocationListItemUIController arg2)
		{
			this.EventOnToggleValueChanged = null;
		}

		// Token: 0x06013DB7 RID: 81335 RVA: 0x0050EF7C File Offset: 0x0050D17C
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
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_SetLocationIdInt32_hotfix = (luaObj.RawGet("SetLocationId") as LuaFunction);
					this.m_GetLocationId_hotfix = (luaObj.RawGet("GetLocationId") as LuaFunction);
					this.m_SetEnergyInt32_hotfix = (luaObj.RawGet("SetEnergy") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_IsLocked_hotfix = (luaObj.RawGet("IsLocked") as LuaFunction);
					this.m_SetToggleValueBoolean_hotfix = (luaObj.RawGet("SetToggleValue") as LuaFunction);
					this.m_GetToggleValue_hotfix = (luaObj.RawGet("GetToggleValue") as LuaFunction);
					this.m_OnToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnToggleValueChanged") as LuaFunction);
					this.m_OnLockButtonClick_hotfix = (luaObj.RawGet("OnLockButtonClick") as LuaFunction);
					this.m_add_EventOnToggleValueChangedAction`2_hotfix = (luaObj.RawGet("add_EventOnToggleValueChanged") as LuaFunction);
					this.m_remove_EventOnToggleValueChangedAction`2_hotfix = (luaObj.RawGet("remove_EventOnToggleValueChanged") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013DB8 RID: 81336 RVA: 0x0050F18C File Offset: 0x0050D38C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamLocationListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AF89 RID: 44937
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400AF8A RID: 44938
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AF8B RID: 44939
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_energyIconImage;

		// Token: 0x0400AF8C RID: 44940
		[AutoBind("./ChosenText/LevelName", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTextChosen;

		// Token: 0x0400AF8D RID: 44941
		[AutoBind("./ChosenText/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyTextChosen;

		// Token: 0x0400AF8E RID: 44942
		[AutoBind("./ChosenText/X", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyXTextChosen;

		// Token: 0x0400AF8F RID: 44943
		[AutoBind("./UnchosenText/LevelName", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTextUnchosen;

		// Token: 0x0400AF90 RID: 44944
		[AutoBind("./UnchosenText/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyTextUnchosen;

		// Token: 0x0400AF91 RID: 44945
		[AutoBind("./UnchosenText/X", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyXTextUnchosen;

		// Token: 0x0400AF92 RID: 44946
		[AutoBind("./LockState", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockButton;

		// Token: 0x0400AF93 RID: 44947
		private bool m_isLocked;

		// Token: 0x0400AF94 RID: 44948
		private int m_locationId;

		// Token: 0x0400AF95 RID: 44949
		[DoNotToLua]
		private TeamLocationListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AF96 RID: 44950
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AF97 RID: 44951
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AF98 RID: 44952
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AF99 RID: 44953
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400AF9A RID: 44954
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400AF9B RID: 44955
		private LuaFunction m_SetLocationIdInt32_hotfix;

		// Token: 0x0400AF9C RID: 44956
		private LuaFunction m_GetLocationId_hotfix;

		// Token: 0x0400AF9D RID: 44957
		private LuaFunction m_SetEnergyInt32_hotfix;

		// Token: 0x0400AF9E RID: 44958
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400AF9F RID: 44959
		private LuaFunction m_IsLocked_hotfix;

		// Token: 0x0400AFA0 RID: 44960
		private LuaFunction m_SetToggleValueBoolean_hotfix;

		// Token: 0x0400AFA1 RID: 44961
		private LuaFunction m_GetToggleValue_hotfix;

		// Token: 0x0400AFA2 RID: 44962
		private LuaFunction m_OnToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AFA3 RID: 44963
		private LuaFunction m_OnLockButtonClick_hotfix;

		// Token: 0x0400AFA4 RID: 44964
		private LuaFunction m_add_EventOnToggleValueChangedAction;

		// Token: 0x0400AFA5 RID: 44965
		private LuaFunction m_remove_EventOnToggleValueChangedAction;

		// Token: 0x02000F83 RID: 3971
		public new class LuaExportHelper
		{
			// Token: 0x06013DB9 RID: 81337 RVA: 0x0050F1F4 File Offset: 0x0050D3F4
			public LuaExportHelper(TeamLocationListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013DBA RID: 81338 RVA: 0x0050F204 File Offset: 0x0050D404
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013DBB RID: 81339 RVA: 0x0050F214 File Offset: 0x0050D414
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013DBC RID: 81340 RVA: 0x0050F224 File Offset: 0x0050D424
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013DBD RID: 81341 RVA: 0x0050F234 File Offset: 0x0050D434
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013DBE RID: 81342 RVA: 0x0050F24C File Offset: 0x0050D44C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013DBF RID: 81343 RVA: 0x0050F25C File Offset: 0x0050D45C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013DC0 RID: 81344 RVA: 0x0050F26C File Offset: 0x0050D46C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013DC1 RID: 81345 RVA: 0x0050F27C File Offset: 0x0050D47C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013DC2 RID: 81346 RVA: 0x0050F28C File Offset: 0x0050D48C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013DC3 RID: 81347 RVA: 0x0050F29C File Offset: 0x0050D49C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013DC4 RID: 81348 RVA: 0x0050F2AC File Offset: 0x0050D4AC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013DC5 RID: 81349 RVA: 0x0050F2BC File Offset: 0x0050D4BC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013DC6 RID: 81350 RVA: 0x0050F2CC File Offset: 0x0050D4CC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013DC7 RID: 81351 RVA: 0x0050F2DC File Offset: 0x0050D4DC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013DC8 RID: 81352 RVA: 0x0050F2EC File Offset: 0x0050D4EC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013DC9 RID: 81353 RVA: 0x0050F2FC File Offset: 0x0050D4FC
			public void __callDele_EventOnToggleValueChanged(bool arg1, TeamLocationListItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnToggleValueChanged(arg1, arg2);
			}

			// Token: 0x06013DCA RID: 81354 RVA: 0x0050F30C File Offset: 0x0050D50C
			public void __clearDele_EventOnToggleValueChanged(bool arg1, TeamLocationListItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnToggleValueChanged(arg1, arg2);
			}

			// Token: 0x17003B57 RID: 15191
			// (get) Token: 0x06013DCB RID: 81355 RVA: 0x0050F31C File Offset: 0x0050D51C
			// (set) Token: 0x06013DCC RID: 81356 RVA: 0x0050F32C File Offset: 0x0050D52C
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

			// Token: 0x17003B58 RID: 15192
			// (get) Token: 0x06013DCD RID: 81357 RVA: 0x0050F33C File Offset: 0x0050D53C
			// (set) Token: 0x06013DCE RID: 81358 RVA: 0x0050F34C File Offset: 0x0050D54C
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

			// Token: 0x17003B59 RID: 15193
			// (get) Token: 0x06013DCF RID: 81359 RVA: 0x0050F35C File Offset: 0x0050D55C
			// (set) Token: 0x06013DD0 RID: 81360 RVA: 0x0050F36C File Offset: 0x0050D56C
			public Image m_energyIconImage
			{
				get
				{
					return this.m_owner.m_energyIconImage;
				}
				set
				{
					this.m_owner.m_energyIconImage = value;
				}
			}

			// Token: 0x17003B5A RID: 15194
			// (get) Token: 0x06013DD1 RID: 81361 RVA: 0x0050F37C File Offset: 0x0050D57C
			// (set) Token: 0x06013DD2 RID: 81362 RVA: 0x0050F38C File Offset: 0x0050D58C
			public Text m_nameTextChosen
			{
				get
				{
					return this.m_owner.m_nameTextChosen;
				}
				set
				{
					this.m_owner.m_nameTextChosen = value;
				}
			}

			// Token: 0x17003B5B RID: 15195
			// (get) Token: 0x06013DD3 RID: 81363 RVA: 0x0050F39C File Offset: 0x0050D59C
			// (set) Token: 0x06013DD4 RID: 81364 RVA: 0x0050F3AC File Offset: 0x0050D5AC
			public Text m_energyTextChosen
			{
				get
				{
					return this.m_owner.m_energyTextChosen;
				}
				set
				{
					this.m_owner.m_energyTextChosen = value;
				}
			}

			// Token: 0x17003B5C RID: 15196
			// (get) Token: 0x06013DD5 RID: 81365 RVA: 0x0050F3BC File Offset: 0x0050D5BC
			// (set) Token: 0x06013DD6 RID: 81366 RVA: 0x0050F3CC File Offset: 0x0050D5CC
			public Text m_energyXTextChosen
			{
				get
				{
					return this.m_owner.m_energyXTextChosen;
				}
				set
				{
					this.m_owner.m_energyXTextChosen = value;
				}
			}

			// Token: 0x17003B5D RID: 15197
			// (get) Token: 0x06013DD7 RID: 81367 RVA: 0x0050F3DC File Offset: 0x0050D5DC
			// (set) Token: 0x06013DD8 RID: 81368 RVA: 0x0050F3EC File Offset: 0x0050D5EC
			public Text m_nameTextUnchosen
			{
				get
				{
					return this.m_owner.m_nameTextUnchosen;
				}
				set
				{
					this.m_owner.m_nameTextUnchosen = value;
				}
			}

			// Token: 0x17003B5E RID: 15198
			// (get) Token: 0x06013DD9 RID: 81369 RVA: 0x0050F3FC File Offset: 0x0050D5FC
			// (set) Token: 0x06013DDA RID: 81370 RVA: 0x0050F40C File Offset: 0x0050D60C
			public Text m_energyTextUnchosen
			{
				get
				{
					return this.m_owner.m_energyTextUnchosen;
				}
				set
				{
					this.m_owner.m_energyTextUnchosen = value;
				}
			}

			// Token: 0x17003B5F RID: 15199
			// (get) Token: 0x06013DDB RID: 81371 RVA: 0x0050F41C File Offset: 0x0050D61C
			// (set) Token: 0x06013DDC RID: 81372 RVA: 0x0050F42C File Offset: 0x0050D62C
			public Text m_energyXTextUnchosen
			{
				get
				{
					return this.m_owner.m_energyXTextUnchosen;
				}
				set
				{
					this.m_owner.m_energyXTextUnchosen = value;
				}
			}

			// Token: 0x17003B60 RID: 15200
			// (get) Token: 0x06013DDD RID: 81373 RVA: 0x0050F43C File Offset: 0x0050D63C
			// (set) Token: 0x06013DDE RID: 81374 RVA: 0x0050F44C File Offset: 0x0050D64C
			public Button m_lockButton
			{
				get
				{
					return this.m_owner.m_lockButton;
				}
				set
				{
					this.m_owner.m_lockButton = value;
				}
			}

			// Token: 0x17003B61 RID: 15201
			// (get) Token: 0x06013DDF RID: 81375 RVA: 0x0050F45C File Offset: 0x0050D65C
			// (set) Token: 0x06013DE0 RID: 81376 RVA: 0x0050F46C File Offset: 0x0050D66C
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

			// Token: 0x17003B62 RID: 15202
			// (get) Token: 0x06013DE1 RID: 81377 RVA: 0x0050F47C File Offset: 0x0050D67C
			// (set) Token: 0x06013DE2 RID: 81378 RVA: 0x0050F48C File Offset: 0x0050D68C
			public int m_locationId
			{
				get
				{
					return this.m_owner.m_locationId;
				}
				set
				{
					this.m_owner.m_locationId = value;
				}
			}

			// Token: 0x06013DE3 RID: 81379 RVA: 0x0050F49C File Offset: 0x0050D69C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013DE4 RID: 81380 RVA: 0x0050F4AC File Offset: 0x0050D6AC
			public void OnToggleValueChanged(bool on)
			{
				this.m_owner.OnToggleValueChanged(on);
			}

			// Token: 0x06013DE5 RID: 81381 RVA: 0x0050F4BC File Offset: 0x0050D6BC
			public void OnLockButtonClick()
			{
				this.m_owner.OnLockButtonClick();
			}

			// Token: 0x0400AFA6 RID: 44966
			private TeamLocationListItemUIController m_owner;
		}
	}
}
