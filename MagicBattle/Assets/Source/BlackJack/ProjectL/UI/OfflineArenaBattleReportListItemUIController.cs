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
	// Token: 0x02000A28 RID: 2600
	[HotFix]
	public class OfflineArenaBattleReportListItemUIController : UIControllerBase
	{
		// Token: 0x06009ED9 RID: 40665 RVA: 0x002CF46C File Offset: 0x002CD66C
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
			this.m_revengeButton.onClick.AddListener(new UnityAction(this.OnRevengeButtonClick));
			this.m_replayButton.onClick.AddListener(new UnityAction(this.OnReplayButtonClick));
			this.m_haveRevengeButton.onClick.AddListener(new UnityAction(this.OnHaveRevengeButtonClick));
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x002CF528 File Offset: 0x002CD728
		public void SetArenaBattleReport(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaBattleReportArenaBattleReport_hotfix != null)
			{
				this.m_SetArenaBattleReportArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.IsMe(battleReport.AttackerUserId);
			int num = configDataLoader.UtilityGetVersion(VersionInfoId.VersionInfoId_BattleReport);
			this.m_replayButton.gameObject.SetActive(battleReport.Status != ArenaBattleReportStatus.Invaild && battleReport.Version == num);
			int num2;
			if (flag)
			{
				this.m_playerNameText.text = battleReport.DefenderName;
				this.m_playerLevelText.text = battleReport.DefenderLevel.ToString();
				this.m_revengeButton.gameObject.SetActive(false);
				this.m_haveRevengeButton.gameObject.SetActive(false);
				num2 = battleReport.AttackerGotArenaPoints;
			}
			else
			{
				this.m_playerNameText.text = battleReport.AttackerName;
				this.m_playerLevelText.text = battleReport.AttackerLevel.ToString();
				if (battleReport.Status == ArenaBattleReportStatus.Defend)
				{
					this.m_haveRevengeButton.gameObject.SetActive(false);
					this.m_revengeButton.gameObject.SetActive(true);
				}
				else if (battleReport.Status == ArenaBattleReportStatus.Revenged)
				{
					this.m_haveRevengeButton.gameObject.SetActive(true);
					this.m_revengeButton.gameObject.SetActive(false);
				}
				else if (battleReport.Status == ArenaBattleReportStatus.RevengeDefend)
				{
					this.m_haveRevengeButton.gameObject.SetActive(false);
					this.m_revengeButton.gameObject.SetActive(false);
				}
				num2 = battleReport.DefenderGotArenaPoints;
			}
			if (num2 >= 0)
			{
				this.m_arenaPointsText.text = UIUtility.AddColorTag(num2.ToString(), new Color(0.13333334f, 0.6745098f, 0.219607845f));
				if (flag)
				{
					this.m_modeUIStateCtrl.SetToUIState("Attack", false, true);
				}
				else
				{
					this.m_modeUIStateCtrl.SetToUIState("Defense", false, true);
				}
			}
			else
			{
				this.m_arenaPointsText.text = UIUtility.AddColorTag(num2.ToString(), Color.red);
				if (flag)
				{
					this.m_modeUIStateCtrl.SetToUIState("AttackFailed", false, true);
				}
				else
				{
					this.m_modeUIStateCtrl.SetToUIState("DefenseFailed", false, true);
				}
			}
			TimeSpan timeSpan = projectLPlayerContext.GetServerTime() - new DateTime(battleReport.CreateTime);
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
			this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(battleReport.OpponentHeadIcon)));
			this.m_battleReport = battleReport;
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x002CF90C File Offset: 0x002CDB0C
		public ArenaBattleReport GetArenaBattleReport()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaBattleReport_hotfix != null)
			{
				return (ArenaBattleReport)this.m_GetArenaBattleReport_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleReport;
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x002CF980 File Offset: 0x002CDB80
		private void OnRevengeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRevengeButtonClick_hotfix != null)
			{
				this.m_OnRevengeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRevengeButtonClick != null)
			{
				this.EventOnRevengeButtonClick(this);
			}
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x002CF9F8 File Offset: 0x002CDBF8
		private void OnHaveRevengeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHaveRevengeButtonClick_hotfix != null)
			{
				this.m_OnHaveRevengeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Arena_HaveRevenge, 2f, null, true);
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x002CFA70 File Offset: 0x002CDC70
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

		// Token: 0x140001D9 RID: 473
		// (add) Token: 0x06009EDF RID: 40671 RVA: 0x002CFAE8 File Offset: 0x002CDCE8
		// (remove) Token: 0x06009EE0 RID: 40672 RVA: 0x002CFB84 File Offset: 0x002CDD84
		public event Action<OfflineArenaBattleReportListItemUIController> EventOnRevengeButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRevengeButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnRevengeButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OfflineArenaBattleReportListItemUIController> action = this.EventOnRevengeButtonClick;
				Action<OfflineArenaBattleReportListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OfflineArenaBattleReportListItemUIController>>(ref this.EventOnRevengeButtonClick, (Action<OfflineArenaBattleReportListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRevengeButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnRevengeButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OfflineArenaBattleReportListItemUIController> action = this.EventOnRevengeButtonClick;
				Action<OfflineArenaBattleReportListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OfflineArenaBattleReportListItemUIController>>(ref this.EventOnRevengeButtonClick, (Action<OfflineArenaBattleReportListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001DA RID: 474
		// (add) Token: 0x06009EE1 RID: 40673 RVA: 0x002CFC20 File Offset: 0x002CDE20
		// (remove) Token: 0x06009EE2 RID: 40674 RVA: 0x002CFCBC File Offset: 0x002CDEBC
		public event Action<OfflineArenaBattleReportListItemUIController> EventOnReplayButtonClick
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
				Action<OfflineArenaBattleReportListItemUIController> action = this.EventOnReplayButtonClick;
				Action<OfflineArenaBattleReportListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OfflineArenaBattleReportListItemUIController>>(ref this.EventOnReplayButtonClick, (Action<OfflineArenaBattleReportListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<OfflineArenaBattleReportListItemUIController> action = this.EventOnReplayButtonClick;
				Action<OfflineArenaBattleReportListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OfflineArenaBattleReportListItemUIController>>(ref this.EventOnReplayButtonClick, (Action<OfflineArenaBattleReportListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x002CFD58 File Offset: 0x002CDF58
		// (set) Token: 0x06009EE4 RID: 40676 RVA: 0x002CFD78 File Offset: 0x002CDF78
		[DoNotToLua]
		public new OfflineArenaBattleReportListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OfflineArenaBattleReportListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009EE5 RID: 40677 RVA: 0x002CFD84 File Offset: 0x002CDF84
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x002CFD90 File Offset: 0x002CDF90
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009EE7 RID: 40679 RVA: 0x002CFD98 File Offset: 0x002CDF98
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009EE8 RID: 40680 RVA: 0x002CFDA0 File Offset: 0x002CDFA0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009EE9 RID: 40681 RVA: 0x002CFDB4 File Offset: 0x002CDFB4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009EEA RID: 40682 RVA: 0x002CFDBC File Offset: 0x002CDFBC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x002CFDC8 File Offset: 0x002CDFC8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x002CFDD4 File Offset: 0x002CDFD4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x002CFDE0 File Offset: 0x002CDFE0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x002CFDEC File Offset: 0x002CDFEC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x002CFDF8 File Offset: 0x002CDFF8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009EF0 RID: 40688 RVA: 0x002CFE04 File Offset: 0x002CE004
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x002CFE10 File Offset: 0x002CE010
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x002CFE1C File Offset: 0x002CE01C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x002CFE28 File Offset: 0x002CE028
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x002CFE30 File Offset: 0x002CE030
		private void __callDele_EventOnRevengeButtonClick(OfflineArenaBattleReportListItemUIController obj)
		{
			Action<OfflineArenaBattleReportListItemUIController> eventOnRevengeButtonClick = this.EventOnRevengeButtonClick;
			if (eventOnRevengeButtonClick != null)
			{
				eventOnRevengeButtonClick(obj);
			}
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x002CFE54 File Offset: 0x002CE054
		private void __clearDele_EventOnRevengeButtonClick(OfflineArenaBattleReportListItemUIController obj)
		{
			this.EventOnRevengeButtonClick = null;
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x002CFE60 File Offset: 0x002CE060
		private void __callDele_EventOnReplayButtonClick(OfflineArenaBattleReportListItemUIController obj)
		{
			Action<OfflineArenaBattleReportListItemUIController> eventOnReplayButtonClick = this.EventOnReplayButtonClick;
			if (eventOnReplayButtonClick != null)
			{
				eventOnReplayButtonClick(obj);
			}
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x002CFE84 File Offset: 0x002CE084
		private void __clearDele_EventOnReplayButtonClick(OfflineArenaBattleReportListItemUIController obj)
		{
			this.EventOnReplayButtonClick = null;
		}

		// Token: 0x06009EF8 RID: 40696 RVA: 0x002CFE90 File Offset: 0x002CE090
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
					this.m_SetArenaBattleReportArenaBattleReport_hotfix = (luaObj.RawGet("SetArenaBattleReport") as LuaFunction);
					this.m_GetArenaBattleReport_hotfix = (luaObj.RawGet("GetArenaBattleReport") as LuaFunction);
					this.m_OnRevengeButtonClick_hotfix = (luaObj.RawGet("OnRevengeButtonClick") as LuaFunction);
					this.m_OnHaveRevengeButtonClick_hotfix = (luaObj.RawGet("OnHaveRevengeButtonClick") as LuaFunction);
					this.m_OnReplayButtonClick_hotfix = (luaObj.RawGet("OnReplayButtonClick") as LuaFunction);
					this.m_add_EventOnRevengeButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnRevengeButtonClick") as LuaFunction);
					this.m_remove_EventOnRevengeButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnRevengeButtonClick") as LuaFunction);
					this.m_add_EventOnReplayButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnReplayButtonClick") as LuaFunction);
					this.m_remove_EventOnReplayButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnReplayButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009EF9 RID: 40697 RVA: 0x002D003C File Offset: 0x002CE23C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OfflineArenaBattleReportListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006B5B RID: 27483
		[AutoBind("./PlayerIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerIconImage;

		// Token: 0x04006B5C RID: 27484
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x04006B5D RID: 27485
		[AutoBind("./PlayerLevel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x04006B5E RID: 27486
		[AutoBind("./ModeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_modeUIStateCtrl;

		// Token: 0x04006B5F RID: 27487
		[AutoBind("./TimeGroup/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x04006B60 RID: 27488
		[AutoBind("./ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_arenaPointsText;

		// Token: 0x04006B61 RID: 27489
		[AutoBind("./ButtonGroup/RevengeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_revengeButton;

		// Token: 0x04006B62 RID: 27490
		[AutoBind("./ButtonGroup/HaveRevengeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_haveRevengeButton;

		// Token: 0x04006B63 RID: 27491
		[AutoBind("./ButtonGroup/ReplayButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_replayButton;

		// Token: 0x04006B64 RID: 27492
		private ArenaBattleReport m_battleReport;

		// Token: 0x04006B65 RID: 27493
		[DoNotToLua]
		private OfflineArenaBattleReportListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006B66 RID: 27494
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006B67 RID: 27495
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006B68 RID: 27496
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006B69 RID: 27497
		private LuaFunction m_SetArenaBattleReportArenaBattleReport_hotfix;

		// Token: 0x04006B6A RID: 27498
		private LuaFunction m_GetArenaBattleReport_hotfix;

		// Token: 0x04006B6B RID: 27499
		private LuaFunction m_OnRevengeButtonClick_hotfix;

		// Token: 0x04006B6C RID: 27500
		private LuaFunction m_OnHaveRevengeButtonClick_hotfix;

		// Token: 0x04006B6D RID: 27501
		private LuaFunction m_OnReplayButtonClick_hotfix;

		// Token: 0x04006B6E RID: 27502
		private LuaFunction m_add_EventOnRevengeButtonClickAction;

		// Token: 0x04006B6F RID: 27503
		private LuaFunction m_remove_EventOnRevengeButtonClickAction;

		// Token: 0x04006B70 RID: 27504
		private LuaFunction m_add_EventOnReplayButtonClickAction;

		// Token: 0x04006B71 RID: 27505
		private LuaFunction m_remove_EventOnReplayButtonClickAction;

		// Token: 0x02000A29 RID: 2601
		public new class LuaExportHelper
		{
			// Token: 0x06009EFA RID: 40698 RVA: 0x002D00A4 File Offset: 0x002CE2A4
			public LuaExportHelper(OfflineArenaBattleReportListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009EFB RID: 40699 RVA: 0x002D00B4 File Offset: 0x002CE2B4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009EFC RID: 40700 RVA: 0x002D00C4 File Offset: 0x002CE2C4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009EFD RID: 40701 RVA: 0x002D00D4 File Offset: 0x002CE2D4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009EFE RID: 40702 RVA: 0x002D00E4 File Offset: 0x002CE2E4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009EFF RID: 40703 RVA: 0x002D00FC File Offset: 0x002CE2FC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009F00 RID: 40704 RVA: 0x002D010C File Offset: 0x002CE30C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009F01 RID: 40705 RVA: 0x002D011C File Offset: 0x002CE31C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009F02 RID: 40706 RVA: 0x002D012C File Offset: 0x002CE32C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009F03 RID: 40707 RVA: 0x002D013C File Offset: 0x002CE33C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009F04 RID: 40708 RVA: 0x002D014C File Offset: 0x002CE34C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009F05 RID: 40709 RVA: 0x002D015C File Offset: 0x002CE35C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009F06 RID: 40710 RVA: 0x002D016C File Offset: 0x002CE36C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009F07 RID: 40711 RVA: 0x002D017C File Offset: 0x002CE37C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009F08 RID: 40712 RVA: 0x002D018C File Offset: 0x002CE38C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009F09 RID: 40713 RVA: 0x002D019C File Offset: 0x002CE39C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009F0A RID: 40714 RVA: 0x002D01AC File Offset: 0x002CE3AC
			public void __callDele_EventOnRevengeButtonClick(OfflineArenaBattleReportListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnRevengeButtonClick(obj);
			}

			// Token: 0x06009F0B RID: 40715 RVA: 0x002D01BC File Offset: 0x002CE3BC
			public void __clearDele_EventOnRevengeButtonClick(OfflineArenaBattleReportListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnRevengeButtonClick(obj);
			}

			// Token: 0x06009F0C RID: 40716 RVA: 0x002D01CC File Offset: 0x002CE3CC
			public void __callDele_EventOnReplayButtonClick(OfflineArenaBattleReportListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnReplayButtonClick(obj);
			}

			// Token: 0x06009F0D RID: 40717 RVA: 0x002D01DC File Offset: 0x002CE3DC
			public void __clearDele_EventOnReplayButtonClick(OfflineArenaBattleReportListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnReplayButtonClick(obj);
			}

			// Token: 0x17002076 RID: 8310
			// (get) Token: 0x06009F0E RID: 40718 RVA: 0x002D01EC File Offset: 0x002CE3EC
			// (set) Token: 0x06009F0F RID: 40719 RVA: 0x002D01FC File Offset: 0x002CE3FC
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

			// Token: 0x17002077 RID: 8311
			// (get) Token: 0x06009F10 RID: 40720 RVA: 0x002D020C File Offset: 0x002CE40C
			// (set) Token: 0x06009F11 RID: 40721 RVA: 0x002D021C File Offset: 0x002CE41C
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

			// Token: 0x17002078 RID: 8312
			// (get) Token: 0x06009F12 RID: 40722 RVA: 0x002D022C File Offset: 0x002CE42C
			// (set) Token: 0x06009F13 RID: 40723 RVA: 0x002D023C File Offset: 0x002CE43C
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

			// Token: 0x17002079 RID: 8313
			// (get) Token: 0x06009F14 RID: 40724 RVA: 0x002D024C File Offset: 0x002CE44C
			// (set) Token: 0x06009F15 RID: 40725 RVA: 0x002D025C File Offset: 0x002CE45C
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

			// Token: 0x1700207A RID: 8314
			// (get) Token: 0x06009F16 RID: 40726 RVA: 0x002D026C File Offset: 0x002CE46C
			// (set) Token: 0x06009F17 RID: 40727 RVA: 0x002D027C File Offset: 0x002CE47C
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

			// Token: 0x1700207B RID: 8315
			// (get) Token: 0x06009F18 RID: 40728 RVA: 0x002D028C File Offset: 0x002CE48C
			// (set) Token: 0x06009F19 RID: 40729 RVA: 0x002D029C File Offset: 0x002CE49C
			public Text m_arenaPointsText
			{
				get
				{
					return this.m_owner.m_arenaPointsText;
				}
				set
				{
					this.m_owner.m_arenaPointsText = value;
				}
			}

			// Token: 0x1700207C RID: 8316
			// (get) Token: 0x06009F1A RID: 40730 RVA: 0x002D02AC File Offset: 0x002CE4AC
			// (set) Token: 0x06009F1B RID: 40731 RVA: 0x002D02BC File Offset: 0x002CE4BC
			public Button m_revengeButton
			{
				get
				{
					return this.m_owner.m_revengeButton;
				}
				set
				{
					this.m_owner.m_revengeButton = value;
				}
			}

			// Token: 0x1700207D RID: 8317
			// (get) Token: 0x06009F1C RID: 40732 RVA: 0x002D02CC File Offset: 0x002CE4CC
			// (set) Token: 0x06009F1D RID: 40733 RVA: 0x002D02DC File Offset: 0x002CE4DC
			public Button m_haveRevengeButton
			{
				get
				{
					return this.m_owner.m_haveRevengeButton;
				}
				set
				{
					this.m_owner.m_haveRevengeButton = value;
				}
			}

			// Token: 0x1700207E RID: 8318
			// (get) Token: 0x06009F1E RID: 40734 RVA: 0x002D02EC File Offset: 0x002CE4EC
			// (set) Token: 0x06009F1F RID: 40735 RVA: 0x002D02FC File Offset: 0x002CE4FC
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

			// Token: 0x1700207F RID: 8319
			// (get) Token: 0x06009F20 RID: 40736 RVA: 0x002D030C File Offset: 0x002CE50C
			// (set) Token: 0x06009F21 RID: 40737 RVA: 0x002D031C File Offset: 0x002CE51C
			public ArenaBattleReport m_battleReport
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

			// Token: 0x06009F22 RID: 40738 RVA: 0x002D032C File Offset: 0x002CE52C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009F23 RID: 40739 RVA: 0x002D033C File Offset: 0x002CE53C
			public void OnRevengeButtonClick()
			{
				this.m_owner.OnRevengeButtonClick();
			}

			// Token: 0x06009F24 RID: 40740 RVA: 0x002D034C File Offset: 0x002CE54C
			public void OnHaveRevengeButtonClick()
			{
				this.m_owner.OnHaveRevengeButtonClick();
			}

			// Token: 0x06009F25 RID: 40741 RVA: 0x002D035C File Offset: 0x002CE55C
			public void OnReplayButtonClick()
			{
				this.m_owner.OnReplayButtonClick();
			}

			// Token: 0x04006B72 RID: 27506
			private OfflineArenaBattleReportListItemUIController m_owner;
		}
	}
}
