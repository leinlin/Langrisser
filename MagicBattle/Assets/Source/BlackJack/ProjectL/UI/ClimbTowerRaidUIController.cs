using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B88 RID: 2952
	[HotFix]
	public class ClimbTowerRaidUIController : UIControllerBase
	{
		// Token: 0x0600C944 RID: 51524 RVA: 0x0037A09C File Offset: 0x0037829C
		private ClimbTowerRaidUIController()
		{
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x0037A0A4 File Offset: 0x003782A4
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
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x0037A128 File Offset: 0x00378328
		public void ShowRaidResult(BattleReward reward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRaidResultBattleReward_hotfix != null)
			{
				this.m_ShowRaidResultBattleReward_hotfix.call(new object[]
				{
					this,
					reward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowRaidResult(reward));
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x0037A1A8 File Offset: 0x003783A8
		[DebuggerHidden]
		private IEnumerator Co_ShowRaidResult(BattleReward reward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowRaidResultBattleReward_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowRaidResultBattleReward_hotfix.call(new object[]
				{
					this,
					reward
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerRaidUIController.<Co_ShowRaidResult>c__Iterator0 <Co_ShowRaidResult>c__Iterator = new ClimbTowerRaidUIController.<Co_ShowRaidResult>c__Iterator0();
			<Co_ShowRaidResult>c__Iterator.reward = reward;
			<Co_ShowRaidResult>c__Iterator.$this = this;
			return <Co_ShowRaidResult>c__Iterator;
		}

		// Token: 0x0600C948 RID: 51528 RVA: 0x0037A23C File Offset: 0x0037843C
		[DebuggerHidden]
		private IEnumerator Co_WaitClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_WaitClick_hotfix != null)
			{
				return (IEnumerator)this.m_Co_WaitClick_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerRaidUIController.<Co_WaitClick>c__Iterator1 <Co_WaitClick>c__Iterator = new ClimbTowerRaidUIController.<Co_WaitClick>c__Iterator1();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x0600C949 RID: 51529 RVA: 0x0037A2B8 File Offset: 0x003784B8
		[DebuggerHidden]
		private IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix.call(new object[]
				{
					this,
					ctrl,
					state
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerRaidUIController.<Co_SetAndWaitUIState>c__Iterator2 <Co_SetAndWaitUIState>c__Iterator = new ClimbTowerRaidUIController.<Co_SetAndWaitUIState>c__Iterator2();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x0037A35C File Offset: 0x0037855C
		[DebuggerHidden]
		private IEnumerator Co_ShowPlayerLevelUp(int oldLevel, int newLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix.call(new object[]
				{
					this,
					oldLevel,
					newLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClimbTowerRaidUIController.<Co_ShowPlayerLevelUp>c__Iterator3 <Co_ShowPlayerLevelUp>c__Iterator = new ClimbTowerRaidUIController.<Co_ShowPlayerLevelUp>c__Iterator3();
			<Co_ShowPlayerLevelUp>c__Iterator.oldLevel = oldLevel;
			<Co_ShowPlayerLevelUp>c__Iterator.newLevel = newLevel;
			<Co_ShowPlayerLevelUp>c__Iterator.$this = this;
			return <Co_ShowPlayerLevelUp>c__Iterator;
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x0037A404 File Offset: 0x00378604
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
			this.m_isClick = true;
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x0037A46C File Offset: 0x0037866C
		private void PlayerLevelUpUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerLevelUpUITask_OnClose_hotfix != null)
			{
				this.m_PlayerLevelUpUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerLevelUpUITask != null)
			{
				this.m_playerLevelUpUITask.EventOnClose -= this.PlayerLevelUpUITask_OnClose;
				this.m_playerLevelUpUITask = null;
			}
		}

		// Token: 0x1400026E RID: 622
		// (add) Token: 0x0600C94D RID: 51533 RVA: 0x0037A4F8 File Offset: 0x003786F8
		// (remove) Token: 0x0600C94E RID: 51534 RVA: 0x0037A594 File Offset: 0x00378794
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

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x0600C94F RID: 51535 RVA: 0x0037A630 File Offset: 0x00378830
		// (set) Token: 0x0600C950 RID: 51536 RVA: 0x0037A650 File Offset: 0x00378850
		[DoNotToLua]
		public new ClimbTowerRaidUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerRaidUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x0037A65C File Offset: 0x0037885C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C952 RID: 51538 RVA: 0x0037A668 File Offset: 0x00378868
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C953 RID: 51539 RVA: 0x0037A670 File Offset: 0x00378870
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C954 RID: 51540 RVA: 0x0037A678 File Offset: 0x00378878
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C955 RID: 51541 RVA: 0x0037A68C File Offset: 0x0037888C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C956 RID: 51542 RVA: 0x0037A694 File Offset: 0x00378894
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x0037A6A0 File Offset: 0x003788A0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C958 RID: 51544 RVA: 0x0037A6AC File Offset: 0x003788AC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x0037A6B8 File Offset: 0x003788B8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C95A RID: 51546 RVA: 0x0037A6C4 File Offset: 0x003788C4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C95B RID: 51547 RVA: 0x0037A6D0 File Offset: 0x003788D0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C95C RID: 51548 RVA: 0x0037A6DC File Offset: 0x003788DC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x0037A6E8 File Offset: 0x003788E8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x0037A6F4 File Offset: 0x003788F4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x0037A700 File Offset: 0x00378900
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x0037A708 File Offset: 0x00378908
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x0037A728 File Offset: 0x00378928
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x0037A734 File Offset: 0x00378934
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
					this.m_ShowRaidResultBattleReward_hotfix = (luaObj.RawGet("ShowRaidResult") as LuaFunction);
					this.m_Co_ShowRaidResultBattleReward_hotfix = (luaObj.RawGet("Co_ShowRaidResult") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix = (luaObj.RawGet("Co_ShowPlayerLevelUp") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_PlayerLevelUpUITask_OnClose_hotfix = (luaObj.RawGet("PlayerLevelUpUITask_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x0037A8E0 File Offset: 0x00378AE0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerRaidUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007EEB RID: 32491
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04007EEC RID: 32492
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04007EED RID: 32493
		[AutoBind("./Panel/EngryAndMission/EngryValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_costEnergyText;

		// Token: 0x04007EEE RID: 32494
		[AutoBind("./Panel/EngryAndMission/MissionValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_floorNameText;

		// Token: 0x04007EEF RID: 32495
		[AutoBind("./Panel/TeamEXP/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x04007EF0 RID: 32496
		[AutoBind("./Panel/TeamEXP/ExpValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerExpText;

		// Token: 0x04007EF1 RID: 32497
		[AutoBind("./Panel/TeamEXP/ExpProgress/ExpProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerExpImage;

		// Token: 0x04007EF2 RID: 32498
		[AutoBind("./Panel/RewardScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_rewardScollRect;

		// Token: 0x04007EF3 RID: 32499
		private bool m_isClick;

		// Token: 0x04007EF4 RID: 32500
		private PlayerLevelUpUITask m_playerLevelUpUITask;

		// Token: 0x04007EF5 RID: 32501
		[DoNotToLua]
		private ClimbTowerRaidUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007EF6 RID: 32502
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007EF7 RID: 32503
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007EF8 RID: 32504
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007EF9 RID: 32505
		private LuaFunction m_ShowRaidResultBattleReward_hotfix;

		// Token: 0x04007EFA RID: 32506
		private LuaFunction m_Co_ShowRaidResultBattleReward_hotfix;

		// Token: 0x04007EFB RID: 32507
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x04007EFC RID: 32508
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x04007EFD RID: 32509
		private LuaFunction m_Co_ShowPlayerLevelUpInt32Int32_hotfix;

		// Token: 0x04007EFE RID: 32510
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04007EFF RID: 32511
		private LuaFunction m_PlayerLevelUpUITask_OnClose_hotfix;

		// Token: 0x04007F00 RID: 32512
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007F01 RID: 32513
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000B89 RID: 2953
		public new class LuaExportHelper
		{
			// Token: 0x0600C964 RID: 51556 RVA: 0x0037A948 File Offset: 0x00378B48
			public LuaExportHelper(ClimbTowerRaidUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C965 RID: 51557 RVA: 0x0037A958 File Offset: 0x00378B58
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C966 RID: 51558 RVA: 0x0037A968 File Offset: 0x00378B68
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C967 RID: 51559 RVA: 0x0037A978 File Offset: 0x00378B78
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C968 RID: 51560 RVA: 0x0037A988 File Offset: 0x00378B88
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C969 RID: 51561 RVA: 0x0037A9A0 File Offset: 0x00378BA0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C96A RID: 51562 RVA: 0x0037A9B0 File Offset: 0x00378BB0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C96B RID: 51563 RVA: 0x0037A9C0 File Offset: 0x00378BC0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C96C RID: 51564 RVA: 0x0037A9D0 File Offset: 0x00378BD0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C96D RID: 51565 RVA: 0x0037A9E0 File Offset: 0x00378BE0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C96E RID: 51566 RVA: 0x0037A9F0 File Offset: 0x00378BF0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C96F RID: 51567 RVA: 0x0037AA00 File Offset: 0x00378C00
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C970 RID: 51568 RVA: 0x0037AA10 File Offset: 0x00378C10
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C971 RID: 51569 RVA: 0x0037AA20 File Offset: 0x00378C20
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C972 RID: 51570 RVA: 0x0037AA30 File Offset: 0x00378C30
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C973 RID: 51571 RVA: 0x0037AA40 File Offset: 0x00378C40
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C974 RID: 51572 RVA: 0x0037AA50 File Offset: 0x00378C50
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600C975 RID: 51573 RVA: 0x0037AA60 File Offset: 0x00378C60
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170027FB RID: 10235
			// (get) Token: 0x0600C976 RID: 51574 RVA: 0x0037AA70 File Offset: 0x00378C70
			// (set) Token: 0x0600C977 RID: 51575 RVA: 0x0037AA80 File Offset: 0x00378C80
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

			// Token: 0x170027FC RID: 10236
			// (get) Token: 0x0600C978 RID: 51576 RVA: 0x0037AA90 File Offset: 0x00378C90
			// (set) Token: 0x0600C979 RID: 51577 RVA: 0x0037AAA0 File Offset: 0x00378CA0
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

			// Token: 0x170027FD RID: 10237
			// (get) Token: 0x0600C97A RID: 51578 RVA: 0x0037AAB0 File Offset: 0x00378CB0
			// (set) Token: 0x0600C97B RID: 51579 RVA: 0x0037AAC0 File Offset: 0x00378CC0
			public Text m_costEnergyText
			{
				get
				{
					return this.m_owner.m_costEnergyText;
				}
				set
				{
					this.m_owner.m_costEnergyText = value;
				}
			}

			// Token: 0x170027FE RID: 10238
			// (get) Token: 0x0600C97C RID: 51580 RVA: 0x0037AAD0 File Offset: 0x00378CD0
			// (set) Token: 0x0600C97D RID: 51581 RVA: 0x0037AAE0 File Offset: 0x00378CE0
			public Text m_floorNameText
			{
				get
				{
					return this.m_owner.m_floorNameText;
				}
				set
				{
					this.m_owner.m_floorNameText = value;
				}
			}

			// Token: 0x170027FF RID: 10239
			// (get) Token: 0x0600C97E RID: 51582 RVA: 0x0037AAF0 File Offset: 0x00378CF0
			// (set) Token: 0x0600C97F RID: 51583 RVA: 0x0037AB00 File Offset: 0x00378D00
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

			// Token: 0x17002800 RID: 10240
			// (get) Token: 0x0600C980 RID: 51584 RVA: 0x0037AB10 File Offset: 0x00378D10
			// (set) Token: 0x0600C981 RID: 51585 RVA: 0x0037AB20 File Offset: 0x00378D20
			public Text m_playerExpText
			{
				get
				{
					return this.m_owner.m_playerExpText;
				}
				set
				{
					this.m_owner.m_playerExpText = value;
				}
			}

			// Token: 0x17002801 RID: 10241
			// (get) Token: 0x0600C982 RID: 51586 RVA: 0x0037AB30 File Offset: 0x00378D30
			// (set) Token: 0x0600C983 RID: 51587 RVA: 0x0037AB40 File Offset: 0x00378D40
			public Image m_playerExpImage
			{
				get
				{
					return this.m_owner.m_playerExpImage;
				}
				set
				{
					this.m_owner.m_playerExpImage = value;
				}
			}

			// Token: 0x17002802 RID: 10242
			// (get) Token: 0x0600C984 RID: 51588 RVA: 0x0037AB50 File Offset: 0x00378D50
			// (set) Token: 0x0600C985 RID: 51589 RVA: 0x0037AB60 File Offset: 0x00378D60
			public ScrollRect m_rewardScollRect
			{
				get
				{
					return this.m_owner.m_rewardScollRect;
				}
				set
				{
					this.m_owner.m_rewardScollRect = value;
				}
			}

			// Token: 0x17002803 RID: 10243
			// (get) Token: 0x0600C986 RID: 51590 RVA: 0x0037AB70 File Offset: 0x00378D70
			// (set) Token: 0x0600C987 RID: 51591 RVA: 0x0037AB80 File Offset: 0x00378D80
			public bool m_isClick
			{
				get
				{
					return this.m_owner.m_isClick;
				}
				set
				{
					this.m_owner.m_isClick = value;
				}
			}

			// Token: 0x17002804 RID: 10244
			// (get) Token: 0x0600C988 RID: 51592 RVA: 0x0037AB90 File Offset: 0x00378D90
			// (set) Token: 0x0600C989 RID: 51593 RVA: 0x0037ABA0 File Offset: 0x00378DA0
			public PlayerLevelUpUITask m_playerLevelUpUITask
			{
				get
				{
					return this.m_owner.m_playerLevelUpUITask;
				}
				set
				{
					this.m_owner.m_playerLevelUpUITask = value;
				}
			}

			// Token: 0x0600C98A RID: 51594 RVA: 0x0037ABB0 File Offset: 0x00378DB0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C98B RID: 51595 RVA: 0x0037ABC0 File Offset: 0x00378DC0
			public IEnumerator Co_ShowRaidResult(BattleReward reward)
			{
				return this.m_owner.Co_ShowRaidResult(reward);
			}

			// Token: 0x0600C98C RID: 51596 RVA: 0x0037ABD0 File Offset: 0x00378DD0
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0600C98D RID: 51597 RVA: 0x0037ABE0 File Offset: 0x00378DE0
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0600C98E RID: 51598 RVA: 0x0037ABF0 File Offset: 0x00378DF0
			public IEnumerator Co_ShowPlayerLevelUp(int oldLevel, int newLevel)
			{
				return this.m_owner.Co_ShowPlayerLevelUp(oldLevel, newLevel);
			}

			// Token: 0x0600C98F RID: 51599 RVA: 0x0037AC00 File Offset: 0x00378E00
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0600C990 RID: 51600 RVA: 0x0037AC10 File Offset: 0x00378E10
			public void PlayerLevelUpUITask_OnClose()
			{
				this.m_owner.PlayerLevelUpUITask_OnClose();
			}

			// Token: 0x04007F02 RID: 32514
			private ClimbTowerRaidUIController m_owner;
		}
	}
}
