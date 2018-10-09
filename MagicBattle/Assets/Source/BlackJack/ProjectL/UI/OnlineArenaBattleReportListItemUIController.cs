using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A2A RID: 2602
	[HotFix]
	public class OnlineArenaBattleReportListItemUIController : UIControllerBase
	{
		// Token: 0x06009F27 RID: 40743 RVA: 0x002D0374 File Offset: 0x002CE574
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
			this.m_replayButton.onClick.AddListener(new UnityAction(this.OnReplayButtonClick));
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x002D03F8 File Offset: 0x002CE5F8
		public void SetRealTimePVPBattleReport(RealTimePVPBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRealTimePVPBattleReportRealTimePVPBattleReport_hotfix != null)
			{
				this.m_SetRealTimePVPBattleReportRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = configDataLoader.UtilityGetVersion(VersionInfoId.VersionInfoId_BattleReport);
			this.m_replayButton.gameObject.SetActive(battleReport.ReportType != RealTimePVPBattleReportType.Invaild && battleReport.Version == num);
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData;
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData2;
			if (projectLPlayerContext.IsMe(battleReport.PlayerDatas[0].UserId))
			{
				realTimePVPBattleReportPlayerData = battleReport.PlayerDatas[0];
				realTimePVPBattleReportPlayerData2 = battleReport.PlayerDatas[1];
			}
			else
			{
				realTimePVPBattleReportPlayerData = battleReport.PlayerDatas[1];
				realTimePVPBattleReportPlayerData2 = battleReport.PlayerDatas[0];
			}
			this.m_playerNameText.text = realTimePVPBattleReportPlayerData2.Name;
			this.m_playerLevelText.text = realTimePVPBattleReportPlayerData2.Level.ToString();
			if (battleReport.Win)
			{
				this.m_scoreText.text = UIUtility.AddColorTag(realTimePVPBattleReportPlayerData.ScoreDiff.ToString(), new Color(0.13333334f, 0.6745098f, 0.219607845f));
				this.m_modeUIStateCtrl.SetToUIState("Succeed", false, true);
			}
			else
			{
				this.m_scoreText.text = UIUtility.AddColorTag(realTimePVPBattleReportPlayerData.ScoreDiff.ToString(), Color.red);
				this.m_modeUIStateCtrl.SetToUIState("Failed", false, true);
			}
			this.m_typeUIStateCtrl.SetToUIState((battleReport.ReportType != RealTimePVPBattleReportType.Friendly) ? "Ladder" : "Casual", false, true);
			TimeSpan timeSpan = projectLPlayerContext.GetServerTime() - battleReport.CreateTime;
			if (timeSpan.TotalHours < 1.0)
			{
				this.m_timeText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_InOneHour);
			}
			else if (timeSpan.TotalDays < 1.0 && timeSpan.TotalHours >= 1.0)
			{
				this.m_timeText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_HoursAgo), Math.Floor(timeSpan.TotalHours).ToString());
			}
			else if (timeSpan.TotalDays >= 1.0)
			{
				this.m_timeText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_DaysAgo), Math.Floor(timeSpan.TotalDays).ToString());
			}
			this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(realTimePVPBattleReportPlayerData2.HeadIcon)));
			this.m_battleReport = battleReport;
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x002D0704 File Offset: 0x002CE904
		public RealTimePVPBattleReport GetRealTimePVPBattleReport()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRealTimePVPBattleReport_hotfix != null)
			{
				return (RealTimePVPBattleReport)this.m_GetRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleReport;
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x002D0778 File Offset: 0x002CE978
		private void OnReplayButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReplayButtonClick_hotfix != null)
			{
				this.m_OnReplayButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReplayButtonClick != null)
			{
				this.EventOnReplayButtonClick(this);
			}
		}

		// Token: 0x140001DB RID: 475
		// (add) Token: 0x06009F2B RID: 40747 RVA: 0x002D07F0 File Offset: 0x002CE9F0
		// (remove) Token: 0x06009F2C RID: 40748 RVA: 0x002D088C File Offset: 0x002CEA8C
		public event Action<OnlineArenaBattleReportListItemUIController> EventOnReplayButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReplayButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnReplayButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OnlineArenaBattleReportListItemUIController> action = this.EventOnReplayButtonClick;
				Action<OnlineArenaBattleReportListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OnlineArenaBattleReportListItemUIController>>(ref this.EventOnReplayButtonClick, (Action<OnlineArenaBattleReportListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReplayButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnReplayButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OnlineArenaBattleReportListItemUIController> action = this.EventOnReplayButtonClick;
				Action<OnlineArenaBattleReportListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OnlineArenaBattleReportListItemUIController>>(ref this.EventOnReplayButtonClick, (Action<OnlineArenaBattleReportListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06009F2D RID: 40749 RVA: 0x002D0928 File Offset: 0x002CEB28
		// (set) Token: 0x06009F2E RID: 40750 RVA: 0x002D0948 File Offset: 0x002CEB48
		[DoNotToLua]
		public new OnlineArenaBattleReportListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OnlineArenaBattleReportListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x002D0954 File Offset: 0x002CEB54
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x002D0960 File Offset: 0x002CEB60
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x002D0968 File Offset: 0x002CEB68
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x002D0970 File Offset: 0x002CEB70
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x002D0984 File Offset: 0x002CEB84
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x002D098C File Offset: 0x002CEB8C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x002D0998 File Offset: 0x002CEB98
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x002D09A4 File Offset: 0x002CEBA4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x002D09B0 File Offset: 0x002CEBB0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x002D09BC File Offset: 0x002CEBBC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x002D09C8 File Offset: 0x002CEBC8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x002D09D4 File Offset: 0x002CEBD4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x002D09E0 File Offset: 0x002CEBE0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x002D09EC File Offset: 0x002CEBEC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x002D09F8 File Offset: 0x002CEBF8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x002D0A00 File Offset: 0x002CEC00
		private void __callDele_EventOnReplayButtonClick(OnlineArenaBattleReportListItemUIController obj)
		{
			Action<OnlineArenaBattleReportListItemUIController> eventOnReplayButtonClick = this.EventOnReplayButtonClick;
			if (eventOnReplayButtonClick != null)
			{
				eventOnReplayButtonClick(obj);
			}
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x002D0A24 File Offset: 0x002CEC24
		private void __clearDele_EventOnReplayButtonClick(OnlineArenaBattleReportListItemUIController obj)
		{
			this.EventOnReplayButtonClick = null;
		}

		// Token: 0x06009F40 RID: 40768 RVA: 0x002D0A30 File Offset: 0x002CEC30
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
					this.m_SetRealTimePVPBattleReportRealTimePVPBattleReport_hotfix = (luaObj.RawGet("SetRealTimePVPBattleReport") as LuaFunction);
					this.m_GetRealTimePVPBattleReport_hotfix = (luaObj.RawGet("GetRealTimePVPBattleReport") as LuaFunction);
					this.m_OnReplayButtonClick_hotfix = (luaObj.RawGet("OnReplayButtonClick") as LuaFunction);
					this.m_add_EventOnReplayButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnReplayButtonClick") as LuaFunction);
					this.m_remove_EventOnReplayButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnReplayButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x002D0B78 File Offset: 0x002CED78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OnlineArenaBattleReportListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006B74 RID: 27508
		[AutoBind("./PlayerIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerIconImage;

		// Token: 0x04006B75 RID: 27509
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x04006B76 RID: 27510
		[AutoBind("./PlayerLevel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x04006B77 RID: 27511
		[AutoBind("./ModeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_modeUIStateCtrl;

		// Token: 0x04006B78 RID: 27512
		[AutoBind("./TypeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_typeUIStateCtrl;

		// Token: 0x04006B79 RID: 27513
		[AutoBind("./TimeGroup/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x04006B7A RID: 27514
		[AutoBind("./ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scoreText;

		// Token: 0x04006B7B RID: 27515
		[AutoBind("./ButtonGroup/ReplayButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_replayButton;

		// Token: 0x04006B7C RID: 27516
		private RealTimePVPBattleReport m_battleReport;

		// Token: 0x04006B7D RID: 27517
		[DoNotToLua]
		private OnlineArenaBattleReportListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006B7E RID: 27518
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006B7F RID: 27519
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006B80 RID: 27520
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006B81 RID: 27521
		private LuaFunction m_SetRealTimePVPBattleReportRealTimePVPBattleReport_hotfix;

		// Token: 0x04006B82 RID: 27522
		private LuaFunction m_GetRealTimePVPBattleReport_hotfix;

		// Token: 0x04006B83 RID: 27523
		private LuaFunction m_OnReplayButtonClick_hotfix;

		// Token: 0x04006B84 RID: 27524
		private LuaFunction m_add_EventOnReplayButtonClickAction;

		// Token: 0x04006B85 RID: 27525
		private LuaFunction m_remove_EventOnReplayButtonClickAction;

		// Token: 0x02000A2B RID: 2603
		public new class LuaExportHelper
		{
			// Token: 0x06009F42 RID: 40770 RVA: 0x002D0BE0 File Offset: 0x002CEDE0
			public LuaExportHelper(OnlineArenaBattleReportListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009F43 RID: 40771 RVA: 0x002D0BF0 File Offset: 0x002CEDF0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009F44 RID: 40772 RVA: 0x002D0C00 File Offset: 0x002CEE00
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009F45 RID: 40773 RVA: 0x002D0C10 File Offset: 0x002CEE10
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009F46 RID: 40774 RVA: 0x002D0C20 File Offset: 0x002CEE20
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009F47 RID: 40775 RVA: 0x002D0C38 File Offset: 0x002CEE38
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009F48 RID: 40776 RVA: 0x002D0C48 File Offset: 0x002CEE48
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009F49 RID: 40777 RVA: 0x002D0C58 File Offset: 0x002CEE58
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009F4A RID: 40778 RVA: 0x002D0C68 File Offset: 0x002CEE68
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009F4B RID: 40779 RVA: 0x002D0C78 File Offset: 0x002CEE78
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009F4C RID: 40780 RVA: 0x002D0C88 File Offset: 0x002CEE88
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009F4D RID: 40781 RVA: 0x002D0C98 File Offset: 0x002CEE98
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009F4E RID: 40782 RVA: 0x002D0CA8 File Offset: 0x002CEEA8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009F4F RID: 40783 RVA: 0x002D0CB8 File Offset: 0x002CEEB8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009F50 RID: 40784 RVA: 0x002D0CC8 File Offset: 0x002CEEC8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009F51 RID: 40785 RVA: 0x002D0CD8 File Offset: 0x002CEED8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009F52 RID: 40786 RVA: 0x002D0CE8 File Offset: 0x002CEEE8
			public void __callDele_EventOnReplayButtonClick(OnlineArenaBattleReportListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnReplayButtonClick(obj);
			}

			// Token: 0x06009F53 RID: 40787 RVA: 0x002D0CF8 File Offset: 0x002CEEF8
			public void __clearDele_EventOnReplayButtonClick(OnlineArenaBattleReportListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnReplayButtonClick(obj);
			}

			// Token: 0x17002081 RID: 8321
			// (get) Token: 0x06009F54 RID: 40788 RVA: 0x002D0D08 File Offset: 0x002CEF08
			// (set) Token: 0x06009F55 RID: 40789 RVA: 0x002D0D18 File Offset: 0x002CEF18
			public Image m_playerIconImage
			{
				get
				{
					return this.m_owner.m_playerIconImage;
				}
				set
				{
					this.m_owner.m_playerIconImage = value;
				}
			}

			// Token: 0x17002082 RID: 8322
			// (get) Token: 0x06009F56 RID: 40790 RVA: 0x002D0D28 File Offset: 0x002CEF28
			// (set) Token: 0x06009F57 RID: 40791 RVA: 0x002D0D38 File Offset: 0x002CEF38
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x17002083 RID: 8323
			// (get) Token: 0x06009F58 RID: 40792 RVA: 0x002D0D48 File Offset: 0x002CEF48
			// (set) Token: 0x06009F59 RID: 40793 RVA: 0x002D0D58 File Offset: 0x002CEF58
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17002084 RID: 8324
			// (get) Token: 0x06009F5A RID: 40794 RVA: 0x002D0D68 File Offset: 0x002CEF68
			// (set) Token: 0x06009F5B RID: 40795 RVA: 0x002D0D78 File Offset: 0x002CEF78
			public CommonUIStateController m_modeUIStateCtrl
			{
				get
				{
					return this.m_owner.m_modeUIStateCtrl;
				}
				set
				{
					this.m_owner.m_modeUIStateCtrl = value;
				}
			}

			// Token: 0x17002085 RID: 8325
			// (get) Token: 0x06009F5C RID: 40796 RVA: 0x002D0D88 File Offset: 0x002CEF88
			// (set) Token: 0x06009F5D RID: 40797 RVA: 0x002D0D98 File Offset: 0x002CEF98
			public CommonUIStateController m_typeUIStateCtrl
			{
				get
				{
					return this.m_owner.m_typeUIStateCtrl;
				}
				set
				{
					this.m_owner.m_typeUIStateCtrl = value;
				}
			}

			// Token: 0x17002086 RID: 8326
			// (get) Token: 0x06009F5E RID: 40798 RVA: 0x002D0DA8 File Offset: 0x002CEFA8
			// (set) Token: 0x06009F5F RID: 40799 RVA: 0x002D0DB8 File Offset: 0x002CEFB8
			public Text m_timeText
			{
				get
				{
					return this.m_owner.m_timeText;
				}
				set
				{
					this.m_owner.m_timeText = value;
				}
			}

			// Token: 0x17002087 RID: 8327
			// (get) Token: 0x06009F60 RID: 40800 RVA: 0x002D0DC8 File Offset: 0x002CEFC8
			// (set) Token: 0x06009F61 RID: 40801 RVA: 0x002D0DD8 File Offset: 0x002CEFD8
			public Text m_scoreText
			{
				get
				{
					return this.m_owner.m_scoreText;
				}
				set
				{
					this.m_owner.m_scoreText = value;
				}
			}

			// Token: 0x17002088 RID: 8328
			// (get) Token: 0x06009F62 RID: 40802 RVA: 0x002D0DE8 File Offset: 0x002CEFE8
			// (set) Token: 0x06009F63 RID: 40803 RVA: 0x002D0DF8 File Offset: 0x002CEFF8
			public Button m_replayButton
			{
				get
				{
					return this.m_owner.m_replayButton;
				}
				set
				{
					this.m_owner.m_replayButton = value;
				}
			}

			// Token: 0x17002089 RID: 8329
			// (get) Token: 0x06009F64 RID: 40804 RVA: 0x002D0E08 File Offset: 0x002CF008
			// (set) Token: 0x06009F65 RID: 40805 RVA: 0x002D0E18 File Offset: 0x002CF018
			public RealTimePVPBattleReport m_battleReport
			{
				get
				{
					return this.m_owner.m_battleReport;
				}
				set
				{
					this.m_owner.m_battleReport = value;
				}
			}

			// Token: 0x06009F66 RID: 40806 RVA: 0x002D0E28 File Offset: 0x002CF028
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009F67 RID: 40807 RVA: 0x002D0E38 File Offset: 0x002CF038
			public void OnReplayButtonClick()
			{
				this.m_owner.OnReplayButtonClick();
			}

			// Token: 0x04006B86 RID: 27526
			private OnlineArenaBattleReportListItemUIController m_owner;
		}
	}
}
