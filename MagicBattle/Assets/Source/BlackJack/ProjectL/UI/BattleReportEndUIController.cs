using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
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
	// Token: 0x02000AA0 RID: 2720
	[HotFix]
	public class BattleReportEndUIController : UIControllerBase
	{
		// Token: 0x0600AEC8 RID: 44744 RVA: 0x00309AA4 File Offset: 0x00307CA4
		private BattleReportEndUIController()
		{
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x00309AAC File Offset: 0x00307CAC
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_playButtonButton.onClick.AddListener(new UnityAction(this.OnPlayButtonClick));
			this.m_exitButtonButton.onClick.AddListener(new UnityAction(this.OnExitButtonClick));
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x00309B68 File Offset: 0x00307D68
		public void Open(ArenaBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenArenaBattleReport_hotfix != null)
			{
				this.m_OpenArenaBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", null, false, true);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (battleReport.AttackerGotArenaPoints > 0)
			{
				this.m_winPlayerName.text = battleReport.AttackerName;
				this.m_winPlayerLV.text = battleReport.AttackerLevel.ToString();
				this.m_losePlayerName.text = battleReport.DefenderName;
				this.m_losePlayerLV.text = battleReport.DefenderLevel.ToString();
				if (projectLPlayerContext.IsMe(battleReport.AttackerUserId))
				{
					this.m_winPlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait()));
					this.m_losePlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(battleReport.OpponentHeadIcon)));
				}
				else
				{
					this.m_winPlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(battleReport.OpponentHeadIcon)));
					this.m_losePlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait()));
				}
			}
			else
			{
				this.m_winPlayerName.text = battleReport.DefenderName;
				this.m_winPlayerLV.text = battleReport.DefenderLevel.ToString();
				this.m_losePlayerName.text = battleReport.AttackerName;
				this.m_losePlayerLV.text = battleReport.AttackerLevel.ToString();
				if (projectLPlayerContext.IsMe(battleReport.DefenderUserId))
				{
					this.m_winPlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait()));
					this.m_losePlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(battleReport.OpponentHeadIcon)));
				}
				else
				{
					this.m_winPlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(battleReport.OpponentHeadIcon)));
					this.m_losePlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(projectLPlayerContext.GetPlayerHeadPortrait()));
				}
			}
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x00309E10 File Offset: 0x00308010
		public void Open(RealTimePVPBattleReport battleReport)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenRealTimePVPBattleReport_hotfix != null)
			{
				this.m_OpenRealTimePVPBattleReport_hotfix.call(new object[]
				{
					this,
					battleReport
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", null, false, true);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = 0;
			if (battleReport.Win)
			{
				if (projectLPlayerContext.IsMe(battleReport.PlayerDatas[1].UserId))
				{
					num = 1;
				}
			}
			else if (projectLPlayerContext.IsMe(battleReport.PlayerDatas[0].UserId))
			{
				num = 1;
			}
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = battleReport.PlayerDatas[num];
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData2 = battleReport.PlayerDatas[1 - num];
			this.m_winPlayerName.text = realTimePVPBattleReportPlayerData.Name;
			this.m_winPlayerLV.text = realTimePVPBattleReportPlayerData.Level.ToString();
			this.m_winPlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(realTimePVPBattleReportPlayerData.HeadIcon)));
			this.m_losePlayerName.text = realTimePVPBattleReportPlayerData2.Name;
			this.m_losePlayerLV.text = realTimePVPBattleReportPlayerData2.Level.ToString();
			this.m_losePlayerIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(realTimePVPBattleReportPlayerData2.HeadIcon)));
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x00309FAC File Offset: 0x003081AC
		public void Close(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", onEnd, true, true);
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x0030A030 File Offset: 0x00308230
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
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x0030A090 File Offset: 0x00308290
		private void OnPlayButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayButtonClick_hotfix != null)
			{
				this.m_OnPlayButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPlayAgain != null)
			{
				this.EventOnPlayAgain();
			}
		}

		// Token: 0x0600AECF RID: 44751 RVA: 0x0030A108 File Offset: 0x00308308
		private void OnExitButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitButtonClick_hotfix != null)
			{
				this.m_OnExitButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x14000214 RID: 532
		// (add) Token: 0x0600AED0 RID: 44752 RVA: 0x0030A180 File Offset: 0x00308380
		// (remove) Token: 0x0600AED1 RID: 44753 RVA: 0x0030A21C File Offset: 0x0030841C
		public event Action EventOnPlayAgain
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPlayAgainAction_hotfix != null)
				{
					this.m_add_EventOnPlayAgainAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPlayAgain;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPlayAgain, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPlayAgainAction_hotfix != null)
				{
					this.m_remove_EventOnPlayAgainAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPlayAgain;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPlayAgain, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000215 RID: 533
		// (add) Token: 0x0600AED2 RID: 44754 RVA: 0x0030A2B8 File Offset: 0x003084B8
		// (remove) Token: 0x0600AED3 RID: 44755 RVA: 0x0030A354 File Offset: 0x00308554
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

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x0600AED4 RID: 44756 RVA: 0x0030A3F0 File Offset: 0x003085F0
		// (set) Token: 0x0600AED5 RID: 44757 RVA: 0x0030A410 File Offset: 0x00308610
		[DoNotToLua]
		public new BattleReportEndUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleReportEndUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x0030A41C File Offset: 0x0030861C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AED7 RID: 44759 RVA: 0x0030A428 File Offset: 0x00308628
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x0030A430 File Offset: 0x00308630
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x0030A438 File Offset: 0x00308638
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x0030A44C File Offset: 0x0030864C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x0030A454 File Offset: 0x00308654
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x0030A460 File Offset: 0x00308660
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x0030A46C File Offset: 0x0030866C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x0030A478 File Offset: 0x00308678
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x0030A484 File Offset: 0x00308684
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x0030A490 File Offset: 0x00308690
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x0030A49C File Offset: 0x0030869C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x0030A4A8 File Offset: 0x003086A8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x0030A4B4 File Offset: 0x003086B4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x0030A4C0 File Offset: 0x003086C0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x0030A4C8 File Offset: 0x003086C8
		private void __callDele_EventOnPlayAgain()
		{
			Action eventOnPlayAgain = this.EventOnPlayAgain;
			if (eventOnPlayAgain != null)
			{
				eventOnPlayAgain();
			}
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x0030A4E8 File Offset: 0x003086E8
		private void __clearDele_EventOnPlayAgain()
		{
			this.EventOnPlayAgain = null;
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x0030A4F4 File Offset: 0x003086F4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600AEE8 RID: 44776 RVA: 0x0030A514 File Offset: 0x00308714
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600AEE9 RID: 44777 RVA: 0x0030A520 File Offset: 0x00308720
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
					this.m_OpenArenaBattleReport_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_OpenRealTimePVPBattleReport_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnPlayButtonClick_hotfix = (luaObj.RawGet("OnPlayButtonClick") as LuaFunction);
					this.m_OnExitButtonClick_hotfix = (luaObj.RawGet("OnExitButtonClick") as LuaFunction);
					this.m_add_EventOnPlayAgainAction_hotfix = (luaObj.RawGet("add_EventOnPlayAgain") as LuaFunction);
					this.m_remove_EventOnPlayAgainAction_hotfix = (luaObj.RawGet("remove_EventOnPlayAgain") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AEEA RID: 44778 RVA: 0x0030A6E8 File Offset: 0x003088E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleReportEndUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007237 RID: 29239
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04007238 RID: 29240
		[AutoBind("./Panel/WinPlayer/PlayerIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_winPlayerIcon;

		// Token: 0x04007239 RID: 29241
		[AutoBind("./Panel/WinPlayer/PlayerLV/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_winPlayerLV;

		// Token: 0x0400723A RID: 29242
		[AutoBind("./Panel/WinPlayer/PlayerName", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_winPlayerName;

		// Token: 0x0400723B RID: 29243
		[AutoBind("./Panel/LosePlayer/PlayerIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_losePlayerIcon;

		// Token: 0x0400723C RID: 29244
		[AutoBind("./Panel/LosePlayer/PlayerLV/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_losePlayerLV;

		// Token: 0x0400723D RID: 29245
		[AutoBind("./Panel/LosePlayer/PlayerName", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_losePlayerName;

		// Token: 0x0400723E RID: 29246
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400723F RID: 29247
		[AutoBind("./Panel/PlayButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playButtonButton;

		// Token: 0x04007240 RID: 29248
		[AutoBind("./Panel/ExitButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_exitButtonButton;

		// Token: 0x04007241 RID: 29249
		[DoNotToLua]
		private BattleReportEndUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007242 RID: 29250
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007243 RID: 29251
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007244 RID: 29252
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007245 RID: 29253
		private LuaFunction m_OpenArenaBattleReport_hotfix;

		// Token: 0x04007246 RID: 29254
		private LuaFunction m_OpenRealTimePVPBattleReport_hotfix;

		// Token: 0x04007247 RID: 29255
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x04007248 RID: 29256
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04007249 RID: 29257
		private LuaFunction m_OnPlayButtonClick_hotfix;

		// Token: 0x0400724A RID: 29258
		private LuaFunction m_OnExitButtonClick_hotfix;

		// Token: 0x0400724B RID: 29259
		private LuaFunction m_add_EventOnPlayAgainAction_hotfix;

		// Token: 0x0400724C RID: 29260
		private LuaFunction m_remove_EventOnPlayAgainAction_hotfix;

		// Token: 0x0400724D RID: 29261
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400724E RID: 29262
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000AA1 RID: 2721
		public new class LuaExportHelper
		{
			// Token: 0x0600AEEB RID: 44779 RVA: 0x0030A750 File Offset: 0x00308950
			public LuaExportHelper(BattleReportEndUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AEEC RID: 44780 RVA: 0x0030A760 File Offset: 0x00308960
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AEED RID: 44781 RVA: 0x0030A770 File Offset: 0x00308970
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AEEE RID: 44782 RVA: 0x0030A780 File Offset: 0x00308980
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AEEF RID: 44783 RVA: 0x0030A790 File Offset: 0x00308990
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AEF0 RID: 44784 RVA: 0x0030A7A8 File Offset: 0x003089A8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AEF1 RID: 44785 RVA: 0x0030A7B8 File Offset: 0x003089B8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AEF2 RID: 44786 RVA: 0x0030A7C8 File Offset: 0x003089C8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AEF3 RID: 44787 RVA: 0x0030A7D8 File Offset: 0x003089D8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AEF4 RID: 44788 RVA: 0x0030A7E8 File Offset: 0x003089E8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AEF5 RID: 44789 RVA: 0x0030A7F8 File Offset: 0x003089F8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AEF6 RID: 44790 RVA: 0x0030A808 File Offset: 0x00308A08
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AEF7 RID: 44791 RVA: 0x0030A818 File Offset: 0x00308A18
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AEF8 RID: 44792 RVA: 0x0030A828 File Offset: 0x00308A28
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AEF9 RID: 44793 RVA: 0x0030A838 File Offset: 0x00308A38
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AEFA RID: 44794 RVA: 0x0030A848 File Offset: 0x00308A48
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600AEFB RID: 44795 RVA: 0x0030A858 File Offset: 0x00308A58
			public void __callDele_EventOnPlayAgain()
			{
				this.m_owner.__callDele_EventOnPlayAgain();
			}

			// Token: 0x0600AEFC RID: 44796 RVA: 0x0030A868 File Offset: 0x00308A68
			public void __clearDele_EventOnPlayAgain()
			{
				this.m_owner.__clearDele_EventOnPlayAgain();
			}

			// Token: 0x0600AEFD RID: 44797 RVA: 0x0030A878 File Offset: 0x00308A78
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600AEFE RID: 44798 RVA: 0x0030A888 File Offset: 0x00308A88
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17002374 RID: 9076
			// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x0030A898 File Offset: 0x00308A98
			// (set) Token: 0x0600AF00 RID: 44800 RVA: 0x0030A8A8 File Offset: 0x00308AA8
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

			// Token: 0x17002375 RID: 9077
			// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x0030A8B8 File Offset: 0x00308AB8
			// (set) Token: 0x0600AF02 RID: 44802 RVA: 0x0030A8C8 File Offset: 0x00308AC8
			public Image m_winPlayerIcon
			{
				get
				{
					return this.m_owner.m_winPlayerIcon;
				}
				set
				{
					this.m_owner.m_winPlayerIcon = value;
				}
			}

			// Token: 0x17002376 RID: 9078
			// (get) Token: 0x0600AF03 RID: 44803 RVA: 0x0030A8D8 File Offset: 0x00308AD8
			// (set) Token: 0x0600AF04 RID: 44804 RVA: 0x0030A8E8 File Offset: 0x00308AE8
			public Text m_winPlayerLV
			{
				get
				{
					return this.m_owner.m_winPlayerLV;
				}
				set
				{
					this.m_owner.m_winPlayerLV = value;
				}
			}

			// Token: 0x17002377 RID: 9079
			// (get) Token: 0x0600AF05 RID: 44805 RVA: 0x0030A8F8 File Offset: 0x00308AF8
			// (set) Token: 0x0600AF06 RID: 44806 RVA: 0x0030A908 File Offset: 0x00308B08
			public Text m_winPlayerName
			{
				get
				{
					return this.m_owner.m_winPlayerName;
				}
				set
				{
					this.m_owner.m_winPlayerName = value;
				}
			}

			// Token: 0x17002378 RID: 9080
			// (get) Token: 0x0600AF07 RID: 44807 RVA: 0x0030A918 File Offset: 0x00308B18
			// (set) Token: 0x0600AF08 RID: 44808 RVA: 0x0030A928 File Offset: 0x00308B28
			public Image m_losePlayerIcon
			{
				get
				{
					return this.m_owner.m_losePlayerIcon;
				}
				set
				{
					this.m_owner.m_losePlayerIcon = value;
				}
			}

			// Token: 0x17002379 RID: 9081
			// (get) Token: 0x0600AF09 RID: 44809 RVA: 0x0030A938 File Offset: 0x00308B38
			// (set) Token: 0x0600AF0A RID: 44810 RVA: 0x0030A948 File Offset: 0x00308B48
			public Text m_losePlayerLV
			{
				get
				{
					return this.m_owner.m_losePlayerLV;
				}
				set
				{
					this.m_owner.m_losePlayerLV = value;
				}
			}

			// Token: 0x1700237A RID: 9082
			// (get) Token: 0x0600AF0B RID: 44811 RVA: 0x0030A958 File Offset: 0x00308B58
			// (set) Token: 0x0600AF0C RID: 44812 RVA: 0x0030A968 File Offset: 0x00308B68
			public Text m_losePlayerName
			{
				get
				{
					return this.m_owner.m_losePlayerName;
				}
				set
				{
					this.m_owner.m_losePlayerName = value;
				}
			}

			// Token: 0x1700237B RID: 9083
			// (get) Token: 0x0600AF0D RID: 44813 RVA: 0x0030A978 File Offset: 0x00308B78
			// (set) Token: 0x0600AF0E RID: 44814 RVA: 0x0030A988 File Offset: 0x00308B88
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x1700237C RID: 9084
			// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x0030A998 File Offset: 0x00308B98
			// (set) Token: 0x0600AF10 RID: 44816 RVA: 0x0030A9A8 File Offset: 0x00308BA8
			public Button m_playButtonButton
			{
				get
				{
					return this.m_owner.m_playButtonButton;
				}
				set
				{
					this.m_owner.m_playButtonButton = value;
				}
			}

			// Token: 0x1700237D RID: 9085
			// (get) Token: 0x0600AF11 RID: 44817 RVA: 0x0030A9B8 File Offset: 0x00308BB8
			// (set) Token: 0x0600AF12 RID: 44818 RVA: 0x0030A9C8 File Offset: 0x00308BC8
			public Button m_exitButtonButton
			{
				get
				{
					return this.m_owner.m_exitButtonButton;
				}
				set
				{
					this.m_owner.m_exitButtonButton = value;
				}
			}

			// Token: 0x0600AF13 RID: 44819 RVA: 0x0030A9D8 File Offset: 0x00308BD8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600AF14 RID: 44820 RVA: 0x0030A9E8 File Offset: 0x00308BE8
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0600AF15 RID: 44821 RVA: 0x0030A9F8 File Offset: 0x00308BF8
			public void OnPlayButtonClick()
			{
				this.m_owner.OnPlayButtonClick();
			}

			// Token: 0x0600AF16 RID: 44822 RVA: 0x0030AA08 File Offset: 0x00308C08
			public void OnExitButtonClick()
			{
				this.m_owner.OnExitButtonClick();
			}

			// Token: 0x0400724F RID: 29263
			private BattleReportEndUIController m_owner;
		}
	}
}
