using System;
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
	// Token: 0x02000EE6 RID: 3814
	[HotFix]
	public class RiftLevelUnlockConditionItemUIController : UIControllerBase
	{
		// Token: 0x06012CBB RID: 76987 RVA: 0x004CE22C File Offset: 0x004CC42C
		public void SetCondition(RiftLevelUnlockConditionType condition, int param1, int param2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetConditionRiftLevelUnlockConditionTypeInt32Int32_hotfix != null)
			{
				this.m_SetConditionRiftLevelUnlockConditionTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					condition,
					param1,
					param2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Scenario)
			{
				ConfigDataScenarioInfo configDataScenarioInfo = configDataLoader.GetConfigDataScenarioInfo(param1);
				if (configDataScenarioInfo != null)
				{
					this.m_text.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_Scenario), configDataScenarioInfo.Chapter);
					this.m_scenarioID = param1;
					this.m_goButton.onClick.AddListener(new UnityAction(this.GoScenario));
					this.m_goButton.gameObject.SetActive(true);
				}
			}
			else if (condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Achievement)
			{
				ConfigDataBattleAchievementRelatedInfo configDataBattleAchievementRelatedInfo = configDataLoader.GetConfigDataBattleAchievementRelatedInfo(param1);
				if (configDataBattleAchievementRelatedInfo != null)
				{
					this.m_achievementRiftLevelID = param2;
					string nameNum = this.m_configDataLoader.GetConfigDataRiftLevelInfo(this.m_achievementRiftLevelID).NameNum;
					string name = this.m_configDataLoader.GetConfigDataBattleAchievementInfo(configDataBattleAchievementRelatedInfo.Achievement_ID).Name;
					this.m_text.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_Achievement), nameNum, name);
					this.m_goButton.onClick.AddListener(new UnityAction(this.GoAchievement));
					this.m_goButton.gameObject.SetActive(true);
				}
			}
			else if (condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_Hero)
			{
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(param1);
				if (configDataHeroInfo != null)
				{
					this.m_text.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_Hero), configDataHeroInfo.Name);
					this.m_goButton.gameObject.SetActive(false);
				}
			}
			else if (condition == RiftLevelUnlockConditionType.RiftLevelUnlockConditionType_RiftLevel)
			{
				ConfigDataRiftLevelInfo configDataRiftLevelInfo = configDataLoader.GetConfigDataRiftLevelInfo(param1);
				if (configDataRiftLevelInfo != null)
				{
					this.m_text.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_RiftLevel), configDataRiftLevelInfo.Name);
					this.m_riftLevelID = param1;
					this.m_goButton.onClick.AddListener(new UnityAction(this.GoRiftLevel));
					this.m_goButton.gameObject.SetActive(true);
				}
			}
		}

		// Token: 0x06012CBC RID: 76988 RVA: 0x004CE494 File Offset: 0x004CC694
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
			if (this.m_playerContext.CanUnlockScenario(this.m_scenarioID) == 0)
			{
				if (this.EventOnGoToScenario != null)
				{
					this.EventOnGoToScenario(this.m_scenarioID);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Rift_Close, 2f, null, true);
			}
		}

		// Token: 0x06012CBD RID: 76989 RVA: 0x004CE544 File Offset: 0x004CC744
		private void GoAchievement()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoAchievement_hotfix != null)
			{
				this.m_GoAchievement_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(this.m_achievementRiftLevelID);
			if (configDataRiftLevelInfo != null)
			{
				int chapterID = configDataRiftLevelInfo.ChapterID;
				if (this.m_playerContext.CanUnlockRiftLevel(this.m_achievementRiftLevelID) == 0)
				{
					if (this.EventOnGoToRiftLevel != null)
					{
						this.EventOnGoToRiftLevel(chapterID, this.m_achievementRiftLevelID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Rift_Close, 2f, null, true);
				}
			}
			else
			{
				global::Debug.LogError("Don't have this RiftLevel!");
			}
		}

		// Token: 0x06012CBE RID: 76990 RVA: 0x004CE624 File Offset: 0x004CC824
		private void GoRiftLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoRiftLevel_hotfix != null)
			{
				this.m_GoRiftLevel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(this.m_riftLevelID);
			if (configDataRiftLevelInfo != null)
			{
				int chapterID = configDataRiftLevelInfo.ChapterID;
				if (this.m_playerContext.CanUnlockRiftLevel(this.m_riftLevelID) == 0)
				{
					if (this.EventOnGoToRiftLevel != null)
					{
						this.EventOnGoToRiftLevel(chapterID, this.m_riftLevelID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Rift_Close, 2f, null, true);
				}
			}
			else
			{
				global::Debug.LogError("Don't have this RiftLevel!");
			}
		}

		// Token: 0x14000415 RID: 1045
		// (add) Token: 0x06012CBF RID: 76991 RVA: 0x004CE704 File Offset: 0x004CC904
		// (remove) Token: 0x06012CC0 RID: 76992 RVA: 0x004CE7A0 File Offset: 0x004CC9A0
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

		// Token: 0x14000416 RID: 1046
		// (add) Token: 0x06012CC1 RID: 76993 RVA: 0x004CE83C File Offset: 0x004CCA3C
		// (remove) Token: 0x06012CC2 RID: 76994 RVA: 0x004CE8D8 File Offset: 0x004CCAD8
		public event Action<int, int> EventOnGoToRiftLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToRiftLevelAction`2_hotfix != null)
				{
					this.m_add_EventOnGoToRiftLevelAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnGoToRiftLevel;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnGoToRiftLevel, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToRiftLevelAction`2_hotfix != null)
				{
					this.m_remove_EventOnGoToRiftLevelAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnGoToRiftLevel;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnGoToRiftLevel, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170038B0 RID: 14512
		// (get) Token: 0x06012CC3 RID: 76995 RVA: 0x004CE974 File Offset: 0x004CCB74
		// (set) Token: 0x06012CC4 RID: 76996 RVA: 0x004CE994 File Offset: 0x004CCB94
		[DoNotToLua]
		public new RiftLevelUnlockConditionItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftLevelUnlockConditionItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012CC5 RID: 76997 RVA: 0x004CE9A0 File Offset: 0x004CCBA0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012CC6 RID: 76998 RVA: 0x004CE9AC File Offset: 0x004CCBAC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012CC7 RID: 76999 RVA: 0x004CE9B4 File Offset: 0x004CCBB4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012CC8 RID: 77000 RVA: 0x004CE9BC File Offset: 0x004CCBBC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012CC9 RID: 77001 RVA: 0x004CE9D0 File Offset: 0x004CCBD0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012CCA RID: 77002 RVA: 0x004CE9D8 File Offset: 0x004CCBD8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012CCB RID: 77003 RVA: 0x004CE9E4 File Offset: 0x004CCBE4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012CCC RID: 77004 RVA: 0x004CE9F0 File Offset: 0x004CCBF0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012CCD RID: 77005 RVA: 0x004CE9FC File Offset: 0x004CCBFC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012CCE RID: 77006 RVA: 0x004CEA08 File Offset: 0x004CCC08
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012CCF RID: 77007 RVA: 0x004CEA14 File Offset: 0x004CCC14
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012CD0 RID: 77008 RVA: 0x004CEA20 File Offset: 0x004CCC20
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012CD1 RID: 77009 RVA: 0x004CEA2C File Offset: 0x004CCC2C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012CD2 RID: 77010 RVA: 0x004CEA38 File Offset: 0x004CCC38
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012CD3 RID: 77011 RVA: 0x004CEA44 File Offset: 0x004CCC44
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012CD4 RID: 77012 RVA: 0x004CEA4C File Offset: 0x004CCC4C
		private void __callDele_EventOnGoToScenario(int obj)
		{
			Action<int> eventOnGoToScenario = this.EventOnGoToScenario;
			if (eventOnGoToScenario != null)
			{
				eventOnGoToScenario(obj);
			}
		}

		// Token: 0x06012CD5 RID: 77013 RVA: 0x004CEA70 File Offset: 0x004CCC70
		private void __clearDele_EventOnGoToScenario(int obj)
		{
			this.EventOnGoToScenario = null;
		}

		// Token: 0x06012CD6 RID: 77014 RVA: 0x004CEA7C File Offset: 0x004CCC7C
		private void __callDele_EventOnGoToRiftLevel(int arg1, int arg2)
		{
			Action<int, int> eventOnGoToRiftLevel = this.EventOnGoToRiftLevel;
			if (eventOnGoToRiftLevel != null)
			{
				eventOnGoToRiftLevel(arg1, arg2);
			}
		}

		// Token: 0x06012CD7 RID: 77015 RVA: 0x004CEAA0 File Offset: 0x004CCCA0
		private void __clearDele_EventOnGoToRiftLevel(int arg1, int arg2)
		{
			this.EventOnGoToRiftLevel = null;
		}

		// Token: 0x06012CD8 RID: 77016 RVA: 0x004CEAAC File Offset: 0x004CCCAC
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
					this.m_SetConditionRiftLevelUnlockConditionTypeInt32Int32_hotfix = (luaObj.RawGet("SetCondition") as LuaFunction);
					this.m_GoScenario_hotfix = (luaObj.RawGet("GoScenario") as LuaFunction);
					this.m_GoAchievement_hotfix = (luaObj.RawGet("GoAchievement") as LuaFunction);
					this.m_GoRiftLevel_hotfix = (luaObj.RawGet("GoRiftLevel") as LuaFunction);
					this.m_add_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToScenario") as LuaFunction);
					this.m_remove_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToScenario") as LuaFunction);
					this.m_add_EventOnGoToRiftLevelAction`2_hotfix = (luaObj.RawGet("add_EventOnGoToRiftLevel") as LuaFunction);
					this.m_remove_EventOnGoToRiftLevelAction`2_hotfix = (luaObj.RawGet("remove_EventOnGoToRiftLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012CD9 RID: 77017 RVA: 0x004CEC28 File Offset: 0x004CCE28
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelUnlockConditionItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A827 RID: 43047
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x0400A828 RID: 43048
		[AutoBind("./Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goButton;

		// Token: 0x0400A829 RID: 43049
		private int m_riftLevelID;

		// Token: 0x0400A82A RID: 43050
		private int m_achievementRiftLevelID;

		// Token: 0x0400A82B RID: 43051
		private int m_scenarioID;

		// Token: 0x0400A82C RID: 43052
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A82D RID: 43053
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400A830 RID: 43056
		[DoNotToLua]
		private RiftLevelUnlockConditionItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A831 RID: 43057
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A832 RID: 43058
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A833 RID: 43059
		private LuaFunction m_SetConditionRiftLevelUnlockConditionTypeInt32Int32_hotfix;

		// Token: 0x0400A834 RID: 43060
		private LuaFunction m_GoScenario_hotfix;

		// Token: 0x0400A835 RID: 43061
		private LuaFunction m_GoAchievement_hotfix;

		// Token: 0x0400A836 RID: 43062
		private LuaFunction m_GoRiftLevel_hotfix;

		// Token: 0x0400A837 RID: 43063
		private LuaFunction m_add_EventOnGoToScenarioAction;

		// Token: 0x0400A838 RID: 43064
		private LuaFunction m_remove_EventOnGoToScenarioAction;

		// Token: 0x0400A839 RID: 43065
		private LuaFunction m_add_EventOnGoToRiftLevelAction;

		// Token: 0x0400A83A RID: 43066
		private LuaFunction m_remove_EventOnGoToRiftLevelAction;

		// Token: 0x02000EE7 RID: 3815
		public new class LuaExportHelper
		{
			// Token: 0x06012CDA RID: 77018 RVA: 0x004CEC90 File Offset: 0x004CCE90
			public LuaExportHelper(RiftLevelUnlockConditionItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012CDB RID: 77019 RVA: 0x004CECA0 File Offset: 0x004CCEA0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012CDC RID: 77020 RVA: 0x004CECB0 File Offset: 0x004CCEB0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012CDD RID: 77021 RVA: 0x004CECC0 File Offset: 0x004CCEC0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012CDE RID: 77022 RVA: 0x004CECD0 File Offset: 0x004CCED0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012CDF RID: 77023 RVA: 0x004CECE8 File Offset: 0x004CCEE8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012CE0 RID: 77024 RVA: 0x004CECF8 File Offset: 0x004CCEF8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012CE1 RID: 77025 RVA: 0x004CED08 File Offset: 0x004CCF08
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012CE2 RID: 77026 RVA: 0x004CED18 File Offset: 0x004CCF18
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012CE3 RID: 77027 RVA: 0x004CED28 File Offset: 0x004CCF28
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012CE4 RID: 77028 RVA: 0x004CED38 File Offset: 0x004CCF38
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012CE5 RID: 77029 RVA: 0x004CED48 File Offset: 0x004CCF48
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012CE6 RID: 77030 RVA: 0x004CED58 File Offset: 0x004CCF58
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012CE7 RID: 77031 RVA: 0x004CED68 File Offset: 0x004CCF68
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012CE8 RID: 77032 RVA: 0x004CED78 File Offset: 0x004CCF78
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012CE9 RID: 77033 RVA: 0x004CED88 File Offset: 0x004CCF88
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012CEA RID: 77034 RVA: 0x004CED98 File Offset: 0x004CCF98
			public void __callDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__callDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012CEB RID: 77035 RVA: 0x004CEDA8 File Offset: 0x004CCFA8
			public void __clearDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__clearDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012CEC RID: 77036 RVA: 0x004CEDB8 File Offset: 0x004CCFB8
			public void __callDele_EventOnGoToRiftLevel(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnGoToRiftLevel(arg1, arg2);
			}

			// Token: 0x06012CED RID: 77037 RVA: 0x004CEDC8 File Offset: 0x004CCFC8
			public void __clearDele_EventOnGoToRiftLevel(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnGoToRiftLevel(arg1, arg2);
			}

			// Token: 0x170038B1 RID: 14513
			// (get) Token: 0x06012CEE RID: 77038 RVA: 0x004CEDD8 File Offset: 0x004CCFD8
			// (set) Token: 0x06012CEF RID: 77039 RVA: 0x004CEDE8 File Offset: 0x004CCFE8
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

			// Token: 0x170038B2 RID: 14514
			// (get) Token: 0x06012CF0 RID: 77040 RVA: 0x004CEDF8 File Offset: 0x004CCFF8
			// (set) Token: 0x06012CF1 RID: 77041 RVA: 0x004CEE08 File Offset: 0x004CD008
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

			// Token: 0x170038B3 RID: 14515
			// (get) Token: 0x06012CF2 RID: 77042 RVA: 0x004CEE18 File Offset: 0x004CD018
			// (set) Token: 0x06012CF3 RID: 77043 RVA: 0x004CEE28 File Offset: 0x004CD028
			public int m_riftLevelID
			{
				get
				{
					return this.m_owner.m_riftLevelID;
				}
				set
				{
					this.m_owner.m_riftLevelID = value;
				}
			}

			// Token: 0x170038B4 RID: 14516
			// (get) Token: 0x06012CF4 RID: 77044 RVA: 0x004CEE38 File Offset: 0x004CD038
			// (set) Token: 0x06012CF5 RID: 77045 RVA: 0x004CEE48 File Offset: 0x004CD048
			public int m_achievementRiftLevelID
			{
				get
				{
					return this.m_owner.m_achievementRiftLevelID;
				}
				set
				{
					this.m_owner.m_achievementRiftLevelID = value;
				}
			}

			// Token: 0x170038B5 RID: 14517
			// (get) Token: 0x06012CF6 RID: 77046 RVA: 0x004CEE58 File Offset: 0x004CD058
			// (set) Token: 0x06012CF7 RID: 77047 RVA: 0x004CEE68 File Offset: 0x004CD068
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

			// Token: 0x170038B6 RID: 14518
			// (get) Token: 0x06012CF8 RID: 77048 RVA: 0x004CEE78 File Offset: 0x004CD078
			// (set) Token: 0x06012CF9 RID: 77049 RVA: 0x004CEE88 File Offset: 0x004CD088
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x170038B7 RID: 14519
			// (get) Token: 0x06012CFA RID: 77050 RVA: 0x004CEE98 File Offset: 0x004CD098
			// (set) Token: 0x06012CFB RID: 77051 RVA: 0x004CEEA8 File Offset: 0x004CD0A8
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x06012CFC RID: 77052 RVA: 0x004CEEB8 File Offset: 0x004CD0B8
			public void GoScenario()
			{
				this.m_owner.GoScenario();
			}

			// Token: 0x06012CFD RID: 77053 RVA: 0x004CEEC8 File Offset: 0x004CD0C8
			public void GoAchievement()
			{
				this.m_owner.GoAchievement();
			}

			// Token: 0x06012CFE RID: 77054 RVA: 0x004CEED8 File Offset: 0x004CD0D8
			public void GoRiftLevel()
			{
				this.m_owner.GoRiftLevel();
			}

			// Token: 0x0400A83B RID: 43067
			private RiftLevelUnlockConditionItemUIController m_owner;
		}
	}
}
