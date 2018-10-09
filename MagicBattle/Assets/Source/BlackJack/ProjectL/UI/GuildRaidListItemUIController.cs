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
	// Token: 0x02000D42 RID: 3394
	[HotFix]
	public class GuildRaidListItemUIController : UIControllerBase
	{
		// Token: 0x0600F901 RID: 63745 RVA: 0x00419E7C File Offset: 0x0041807C
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
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x00419F00 File Offset: 0x00418100
		public void InitGuildRaidListItemInfo(ConfigDataGuildMassiveCombatDifficultyInfo info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGuildRaidListItemInfoConfigDataGuildMassiveCombatDifficultyInfo_hotfix != null)
			{
				this.m_InitGuildRaidListItemInfoConfigDataGuildMassiveCombatDifficultyInfo_hotfix.call(new object[]
				{
					this,
					info
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.GuildMassiveCombatDifficultyInfo = info;
			bool flag = true;
			this.m_stateCtrl.SetToUIState((!flag) ? "Locked" : "Normal", false, true);
			this.m_levelText.text = "Lv" + info.SuggestedLevel;
			int num = 1;
			this.m_countText.text = num.ToString();
			this.m_conditionDescText.text = info.Desc;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_GuildRaidLevelUnlockDesc);
			LevelAndMembers levelAndMembers = info.Requirements[0];
			int id = info.ID;
			this.m_difficultTextStateCtrl.SetToUIState("DiLV" + id, false, true);
			this.m_lockedText.text = string.Format(format, levelAndMembers.Level, levelAndMembers.Members);
		}

		// Token: 0x0600F903 RID: 63747 RVA: 0x0041A05C File Offset: 0x0041825C
		private void OnStartButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartButtonClick_hotfix != null)
			{
				this.m_OnStartButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartButtonClick != null)
			{
				this.EventOnStartButtonClick(this);
			}
		}

		// Token: 0x14000349 RID: 841
		// (add) Token: 0x0600F904 RID: 63748 RVA: 0x0041A0D4 File Offset: 0x004182D4
		// (remove) Token: 0x0600F905 RID: 63749 RVA: 0x0041A170 File Offset: 0x00418370
		public event Action<GuildRaidListItemUIController> EventOnStartButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildRaidListItemUIController> action = this.EventOnStartButtonClick;
				Action<GuildRaidListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildRaidListItemUIController>>(ref this.EventOnStartButtonClick, (Action<GuildRaidListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildRaidListItemUIController> action = this.EventOnStartButtonClick;
				Action<GuildRaidListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildRaidListItemUIController>>(ref this.EventOnStartButtonClick, (Action<GuildRaidListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x0600F906 RID: 63750 RVA: 0x0041A20C File Offset: 0x0041840C
		// (set) Token: 0x0600F907 RID: 63751 RVA: 0x0041A22C File Offset: 0x0041842C
		[DoNotToLua]
		public new GuildRaidListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildRaidListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x0041A238 File Offset: 0x00418438
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x0041A244 File Offset: 0x00418444
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x0041A24C File Offset: 0x0041844C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x0041A254 File Offset: 0x00418454
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x0041A268 File Offset: 0x00418468
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x0041A270 File Offset: 0x00418470
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F90E RID: 63758 RVA: 0x0041A27C File Offset: 0x0041847C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F90F RID: 63759 RVA: 0x0041A288 File Offset: 0x00418488
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x0041A294 File Offset: 0x00418494
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F911 RID: 63761 RVA: 0x0041A2A0 File Offset: 0x004184A0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F912 RID: 63762 RVA: 0x0041A2AC File Offset: 0x004184AC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F913 RID: 63763 RVA: 0x0041A2B8 File Offset: 0x004184B8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F914 RID: 63764 RVA: 0x0041A2C4 File Offset: 0x004184C4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F915 RID: 63765 RVA: 0x0041A2D0 File Offset: 0x004184D0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F916 RID: 63766 RVA: 0x0041A2DC File Offset: 0x004184DC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F917 RID: 63767 RVA: 0x0041A2E4 File Offset: 0x004184E4
		private void __callDele_EventOnStartButtonClick(GuildRaidListItemUIController obj)
		{
			Action<GuildRaidListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x0600F918 RID: 63768 RVA: 0x0041A308 File Offset: 0x00418508
		private void __clearDele_EventOnStartButtonClick(GuildRaidListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x0600F919 RID: 63769 RVA: 0x0041A314 File Offset: 0x00418514
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
					this.m_InitGuildRaidListItemInfoConfigDataGuildMassiveCombatDifficultyInfo_hotfix = (luaObj.RawGet("InitGuildRaidListItemInfo") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStartButtonClick") as LuaFunction);
					this.m_remove_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F91A RID: 63770 RVA: 0x0041A444 File Offset: 0x00418644
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildRaidListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009264 RID: 37476
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009265 RID: 37477
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04009266 RID: 37478
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04009267 RID: 37479
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countText;

		// Token: 0x04009268 RID: 37480
		[AutoBind("./ModoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_difficultTextStateCtrl;

		// Token: 0x04009269 RID: 37481
		[AutoBind("./ConditionDescScrollView/Viewport/Content/ConditionDescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_conditionDescText;

		// Token: 0x0400926A RID: 37482
		[AutoBind("./Locked/TextGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x0400926B RID: 37483
		public ConfigDataGuildMassiveCombatDifficultyInfo GuildMassiveCombatDifficultyInfo;

		// Token: 0x0400926C RID: 37484
		[DoNotToLua]
		private GuildRaidListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400926D RID: 37485
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400926E RID: 37486
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400926F RID: 37487
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009270 RID: 37488
		private LuaFunction m_InitGuildRaidListItemInfoConfigDataGuildMassiveCombatDifficultyInfo_hotfix;

		// Token: 0x04009271 RID: 37489
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x04009272 RID: 37490
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x04009273 RID: 37491
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000D43 RID: 3395
		public new class LuaExportHelper
		{
			// Token: 0x0600F91B RID: 63771 RVA: 0x0041A4AC File Offset: 0x004186AC
			public LuaExportHelper(GuildRaidListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F91C RID: 63772 RVA: 0x0041A4BC File Offset: 0x004186BC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F91D RID: 63773 RVA: 0x0041A4CC File Offset: 0x004186CC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F91E RID: 63774 RVA: 0x0041A4DC File Offset: 0x004186DC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F91F RID: 63775 RVA: 0x0041A4EC File Offset: 0x004186EC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F920 RID: 63776 RVA: 0x0041A504 File Offset: 0x00418704
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F921 RID: 63777 RVA: 0x0041A514 File Offset: 0x00418714
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F922 RID: 63778 RVA: 0x0041A524 File Offset: 0x00418724
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F923 RID: 63779 RVA: 0x0041A534 File Offset: 0x00418734
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F924 RID: 63780 RVA: 0x0041A544 File Offset: 0x00418744
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F925 RID: 63781 RVA: 0x0041A554 File Offset: 0x00418754
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F926 RID: 63782 RVA: 0x0041A564 File Offset: 0x00418764
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F927 RID: 63783 RVA: 0x0041A574 File Offset: 0x00418774
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F928 RID: 63784 RVA: 0x0041A584 File Offset: 0x00418784
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F929 RID: 63785 RVA: 0x0041A594 File Offset: 0x00418794
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F92A RID: 63786 RVA: 0x0041A5A4 File Offset: 0x004187A4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F92B RID: 63787 RVA: 0x0041A5B4 File Offset: 0x004187B4
			public void __callDele_EventOnStartButtonClick(GuildRaidListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x0600F92C RID: 63788 RVA: 0x0041A5C4 File Offset: 0x004187C4
			public void __clearDele_EventOnStartButtonClick(GuildRaidListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x17002F91 RID: 12177
			// (get) Token: 0x0600F92D RID: 63789 RVA: 0x0041A5D4 File Offset: 0x004187D4
			// (set) Token: 0x0600F92E RID: 63790 RVA: 0x0041A5E4 File Offset: 0x004187E4
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

			// Token: 0x17002F92 RID: 12178
			// (get) Token: 0x0600F92F RID: 63791 RVA: 0x0041A5F4 File Offset: 0x004187F4
			// (set) Token: 0x0600F930 RID: 63792 RVA: 0x0041A604 File Offset: 0x00418804
			public Button m_startButton
			{
				get
				{
					return this.m_owner.m_startButton;
				}
				set
				{
					this.m_owner.m_startButton = value;
				}
			}

			// Token: 0x17002F93 RID: 12179
			// (get) Token: 0x0600F931 RID: 63793 RVA: 0x0041A614 File Offset: 0x00418814
			// (set) Token: 0x0600F932 RID: 63794 RVA: 0x0041A624 File Offset: 0x00418824
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17002F94 RID: 12180
			// (get) Token: 0x0600F933 RID: 63795 RVA: 0x0041A634 File Offset: 0x00418834
			// (set) Token: 0x0600F934 RID: 63796 RVA: 0x0041A644 File Offset: 0x00418844
			public Text m_countText
			{
				get
				{
					return this.m_owner.m_countText;
				}
				set
				{
					this.m_owner.m_countText = value;
				}
			}

			// Token: 0x17002F95 RID: 12181
			// (get) Token: 0x0600F935 RID: 63797 RVA: 0x0041A654 File Offset: 0x00418854
			// (set) Token: 0x0600F936 RID: 63798 RVA: 0x0041A664 File Offset: 0x00418864
			public CommonUIStateController m_difficultTextStateCtrl
			{
				get
				{
					return this.m_owner.m_difficultTextStateCtrl;
				}
				set
				{
					this.m_owner.m_difficultTextStateCtrl = value;
				}
			}

			// Token: 0x17002F96 RID: 12182
			// (get) Token: 0x0600F937 RID: 63799 RVA: 0x0041A674 File Offset: 0x00418874
			// (set) Token: 0x0600F938 RID: 63800 RVA: 0x0041A684 File Offset: 0x00418884
			public Text m_conditionDescText
			{
				get
				{
					return this.m_owner.m_conditionDescText;
				}
				set
				{
					this.m_owner.m_conditionDescText = value;
				}
			}

			// Token: 0x17002F97 RID: 12183
			// (get) Token: 0x0600F939 RID: 63801 RVA: 0x0041A694 File Offset: 0x00418894
			// (set) Token: 0x0600F93A RID: 63802 RVA: 0x0041A6A4 File Offset: 0x004188A4
			public Text m_lockedText
			{
				get
				{
					return this.m_owner.m_lockedText;
				}
				set
				{
					this.m_owner.m_lockedText = value;
				}
			}

			// Token: 0x0600F93B RID: 63803 RVA: 0x0041A6B4 File Offset: 0x004188B4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F93C RID: 63804 RVA: 0x0041A6C4 File Offset: 0x004188C4
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x04009274 RID: 37492
			private GuildRaidListItemUIController m_owner;
		}
	}
}
