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
	// Token: 0x02000EDB RID: 3803
	[HotFix]
	public class RiftChapterUnlockConditionItemUIController : UIControllerBase
	{
		// Token: 0x06012AFC RID: 76540 RVA: 0x004C8A28 File Offset: 0x004C6C28
		public void SetCondition(RiftChapterUnlockConditionType condition, int param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetConditionRiftChapterUnlockConditionTypeInt32_hotfix != null)
			{
				this.m_SetConditionRiftChapterUnlockConditionTypeInt32_hotfix.call(new object[]
				{
					this,
					condition,
					param
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (condition == RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_PlayerLevel)
			{
				this.m_text.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_PlayerLevel), param);
			}
			else if (condition == RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_Scenario)
			{
				ConfigDataScenarioInfo configDataScenarioInfo = configDataLoader.GetConfigDataScenarioInfo(param);
				if (configDataScenarioInfo != null)
				{
					this.m_text.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_Scenario), configDataScenarioInfo.Chapter);
					this.m_scenarioID = param;
					this.m_goButton.onClick.AddListener(new UnityAction(this.GoScenario));
				}
			}
			this.m_goButton.gameObject.SetActive(false);
		}

		// Token: 0x06012AFD RID: 76541 RVA: 0x004C8B50 File Offset: 0x004C6D50
		private void GoScenario()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoScenario_hotfix != null)
			{
				this.m_GoScenario_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGoToScenario != null)
			{
				this.EventOnGoToScenario(this.m_scenarioID);
			}
		}

		// Token: 0x14000409 RID: 1033
		// (add) Token: 0x06012AFE RID: 76542 RVA: 0x004C8BCC File Offset: 0x004C6DCC
		// (remove) Token: 0x06012AFF RID: 76543 RVA: 0x004C8C68 File Offset: 0x004C6E68
		public event Action<int> EventOnGoToScenario
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToScenarioAction`1_hotfix != null)
				{
					this.m_add_EventOnGoToScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToScenario;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToScenario, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToScenarioAction`1_hotfix != null)
				{
					this.m_remove_EventOnGoToScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToScenario;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToScenario, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x06012B00 RID: 76544 RVA: 0x004C8D04 File Offset: 0x004C6F04
		// (set) Token: 0x06012B01 RID: 76545 RVA: 0x004C8D24 File Offset: 0x004C6F24
		[DoNotToLua]
		public new RiftChapterUnlockConditionItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftChapterUnlockConditionItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012B02 RID: 76546 RVA: 0x004C8D30 File Offset: 0x004C6F30
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012B03 RID: 76547 RVA: 0x004C8D3C File Offset: 0x004C6F3C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012B04 RID: 76548 RVA: 0x004C8D44 File Offset: 0x004C6F44
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012B05 RID: 76549 RVA: 0x004C8D4C File Offset: 0x004C6F4C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012B06 RID: 76550 RVA: 0x004C8D60 File Offset: 0x004C6F60
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012B07 RID: 76551 RVA: 0x004C8D68 File Offset: 0x004C6F68
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012B08 RID: 76552 RVA: 0x004C8D74 File Offset: 0x004C6F74
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012B09 RID: 76553 RVA: 0x004C8D80 File Offset: 0x004C6F80
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012B0A RID: 76554 RVA: 0x004C8D8C File Offset: 0x004C6F8C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012B0B RID: 76555 RVA: 0x004C8D98 File Offset: 0x004C6F98
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012B0C RID: 76556 RVA: 0x004C8DA4 File Offset: 0x004C6FA4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012B0D RID: 76557 RVA: 0x004C8DB0 File Offset: 0x004C6FB0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012B0E RID: 76558 RVA: 0x004C8DBC File Offset: 0x004C6FBC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012B0F RID: 76559 RVA: 0x004C8DC8 File Offset: 0x004C6FC8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012B10 RID: 76560 RVA: 0x004C8DD4 File Offset: 0x004C6FD4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012B11 RID: 76561 RVA: 0x004C8DDC File Offset: 0x004C6FDC
		private void __callDele_EventOnGoToScenario(int obj)
		{
			Action<int> eventOnGoToScenario = this.EventOnGoToScenario;
			if (eventOnGoToScenario != null)
			{
				eventOnGoToScenario(obj);
			}
		}

		// Token: 0x06012B12 RID: 76562 RVA: 0x004C8E00 File Offset: 0x004C7000
		private void __clearDele_EventOnGoToScenario(int obj)
		{
			this.EventOnGoToScenario = null;
		}

		// Token: 0x06012B13 RID: 76563 RVA: 0x004C8E0C File Offset: 0x004C700C
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
					this.m_SetConditionRiftChapterUnlockConditionTypeInt32_hotfix = (luaObj.RawGet("SetCondition") as LuaFunction);
					this.m_GoScenario_hotfix = (luaObj.RawGet("GoScenario") as LuaFunction);
					this.m_add_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToScenario") as LuaFunction);
					this.m_remove_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToScenario") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012B14 RID: 76564 RVA: 0x004C8F24 File Offset: 0x004C7124
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftChapterUnlockConditionItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A77C RID: 42876
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x0400A77D RID: 42877
		[AutoBind("./Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goButton;

		// Token: 0x0400A77E RID: 42878
		private int m_scenarioID;

		// Token: 0x0400A780 RID: 42880
		[DoNotToLua]
		private RiftChapterUnlockConditionItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A781 RID: 42881
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A782 RID: 42882
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A783 RID: 42883
		private LuaFunction m_SetConditionRiftChapterUnlockConditionTypeInt32_hotfix;

		// Token: 0x0400A784 RID: 42884
		private LuaFunction m_GoScenario_hotfix;

		// Token: 0x0400A785 RID: 42885
		private LuaFunction m_add_EventOnGoToScenarioAction;

		// Token: 0x0400A786 RID: 42886
		private LuaFunction m_remove_EventOnGoToScenarioAction;

		// Token: 0x02000EDC RID: 3804
		public new class LuaExportHelper
		{
			// Token: 0x06012B15 RID: 76565 RVA: 0x004C8F8C File Offset: 0x004C718C
			public LuaExportHelper(RiftChapterUnlockConditionItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012B16 RID: 76566 RVA: 0x004C8F9C File Offset: 0x004C719C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012B17 RID: 76567 RVA: 0x004C8FAC File Offset: 0x004C71AC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012B18 RID: 76568 RVA: 0x004C8FBC File Offset: 0x004C71BC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012B19 RID: 76569 RVA: 0x004C8FCC File Offset: 0x004C71CC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012B1A RID: 76570 RVA: 0x004C8FE4 File Offset: 0x004C71E4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012B1B RID: 76571 RVA: 0x004C8FF4 File Offset: 0x004C71F4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012B1C RID: 76572 RVA: 0x004C9004 File Offset: 0x004C7204
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012B1D RID: 76573 RVA: 0x004C9014 File Offset: 0x004C7214
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012B1E RID: 76574 RVA: 0x004C9024 File Offset: 0x004C7224
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012B1F RID: 76575 RVA: 0x004C9034 File Offset: 0x004C7234
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012B20 RID: 76576 RVA: 0x004C9044 File Offset: 0x004C7244
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012B21 RID: 76577 RVA: 0x004C9054 File Offset: 0x004C7254
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012B22 RID: 76578 RVA: 0x004C9064 File Offset: 0x004C7264
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012B23 RID: 76579 RVA: 0x004C9074 File Offset: 0x004C7274
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012B24 RID: 76580 RVA: 0x004C9084 File Offset: 0x004C7284
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012B25 RID: 76581 RVA: 0x004C9094 File Offset: 0x004C7294
			public void __callDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__callDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012B26 RID: 76582 RVA: 0x004C90A4 File Offset: 0x004C72A4
			public void __clearDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__clearDele_EventOnGoToScenario(obj);
			}

			// Token: 0x1700386F RID: 14447
			// (get) Token: 0x06012B27 RID: 76583 RVA: 0x004C90B4 File Offset: 0x004C72B4
			// (set) Token: 0x06012B28 RID: 76584 RVA: 0x004C90C4 File Offset: 0x004C72C4
			public Text m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x17003870 RID: 14448
			// (get) Token: 0x06012B29 RID: 76585 RVA: 0x004C90D4 File Offset: 0x004C72D4
			// (set) Token: 0x06012B2A RID: 76586 RVA: 0x004C90E4 File Offset: 0x004C72E4
			public Button m_goButton
			{
				get
				{
					return this.m_owner.m_goButton;
				}
				set
				{
					this.m_owner.m_goButton = value;
				}
			}

			// Token: 0x17003871 RID: 14449
			// (get) Token: 0x06012B2B RID: 76587 RVA: 0x004C90F4 File Offset: 0x004C72F4
			// (set) Token: 0x06012B2C RID: 76588 RVA: 0x004C9104 File Offset: 0x004C7304
			public int m_scenarioID
			{
				get
				{
					return this.m_owner.m_scenarioID;
				}
				set
				{
					this.m_owner.m_scenarioID = value;
				}
			}

			// Token: 0x06012B2D RID: 76589 RVA: 0x004C9114 File Offset: 0x004C7314
			public void GoScenario()
			{
				this.m_owner.GoScenario();
			}

			// Token: 0x0400A787 RID: 42887
			private RiftChapterUnlockConditionItemUIController m_owner;
		}
	}
}
