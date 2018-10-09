using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B04 RID: 2820
	[HotFix]
	public class PVPBattlePrepareUIController : UIControllerBase
	{
		// Token: 0x0600BD61 RID: 48481 RVA: 0x0034FBE4 File Offset: 0x0034DDE4
		private PVPBattlePrepareUIController()
		{
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x0034FBEC File Offset: 0x0034DDEC
		protected override void Finalize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Finalize_hotfix != null)
			{
				this.m_Finalize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x0034FC68 File Offset: 0x0034DE68
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
			this.m_prepareConfirmButton.onClick.AddListener(new UnityAction(this.OnPrepareConfirmButtonClick));
			this.m_orderUIStateController.gameObject.SetActive(false);
			this.m_orderFirstGameObject.SetActive(false);
			this.m_orderAfterGameObject.SetActive(false);
			this.m_prepareMyStateUIStateController.gameObject.SetActive(false);
			this.m_prepareMyTimeUIStateController.gameObject.SetActive(false);
			this.m_prepareOpponentUIStateController.gameObject.SetActive(false);
			this.m_protectBanGroupUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x0034FD58 File Offset: 0x0034DF58
		public void ShowOrder(bool isFirst, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOrderBooleanAction_hotfix != null)
			{
				this.m_ShowOrderBooleanAction_hotfix.call(new object[]
				{
					this,
					isFirst,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			PVPBattlePrepareUIController $this = this;
			string text = (!isFirst) ? "AfterLeft" : "FirstLeft";
			if (UIUtility.GetUIStateCurrentStateName(this.m_orderUIStateController) == text)
			{
				if (onEnd != null)
				{
					onEnd();
				}
				return;
			}
			this.m_orderUIStateController.gameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_orderUIStateController, text, delegate
			{
				$this.m_orderUIStateController.gameObject.SetActive(false);
				if (onEnd != null)
				{
					onEnd();
				}
			}, false, true);
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x0034FE5C File Offset: 0x0034E05C
		public void ShowPrepareState(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPrepareStateBoolean_hotfix != null)
			{
				this.m_ShowPrepareStateBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_prepareStateGameObject.SetActive(show);
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x0034FED8 File Offset: 0x0034E0D8
		public void ShowPickMyHero(int heroCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPickMyHeroInt32_hotfix != null)
			{
				this.m_ShowPickMyHeroInt32_hotfix.call(new object[]
				{
					this,
					heroCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_prepareMyStateUIStateController, "Show", null, false, false);
			UIUtility.SetUIStateOpen(this.m_prepareMyTimeUIStateController, "Show", null, false, false);
			UIUtility.SetUIStateClose(this.m_prepareOpponentUIStateController, "Close", null, false, false);
			string stateName;
			if (heroCount == 1)
			{
				stateName = "ChooseOneHero";
			}
			else if (heroCount == 2)
			{
				stateName = "ChooseTwoHero";
			}
			else
			{
				stateName = "ChooseBattleHero";
			}
			this.m_prepareMyStateTextUIStateController.SetToUIState(stateName, false, false);
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x0034FFBC File Offset: 0x0034E1BC
		public void ShowWaitOpponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowWaitOpponent_hotfix != null)
			{
				this.m_ShowWaitOpponent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_prepareMyStateUIStateController, "Close", null, false, false);
			UIUtility.SetUIStateClose(this.m_prepareMyTimeUIStateController, "Close", null, false, false);
			UIUtility.SetUIStateOpen(this.m_prepareOpponentUIStateController, "Show", null, false, false);
			if (UIUtility.GetUIStateCurrentStateName(this.m_protectUIStateController) == "Show")
			{
				this.m_protectUIStateController.SetToUIState("Close", false, true);
			}
			if (UIUtility.GetUIStateCurrentStateName(this.m_banUIStateController) == "Show")
			{
				this.m_banUIStateController.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x003500B0 File Offset: 0x0034E2B0
		public void ShowProtectIndicator(int side)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowProtectIndicatorInt32_hotfix != null)
			{
				this.m_ShowProtectIndicatorInt32_hotfix.call(new object[]
				{
					this,
					side2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int side = side2;
			PVPBattlePrepareUIController $this = this;
			if (UIUtility.GetUIStateCurrentStateName(this.m_prepareMyStateTextUIStateController) == "Protect")
			{
				return;
			}
			UIUtility.SetUIStateClose(this.m_prepareOpponentUIStateController, "Close", null, false, true);
			this.m_prepareMyStateTextUIStateController.SetToUIState("Protect", false, true);
			this.m_prepareMyTimeUIStateController.gameObject.SetActive(false);
			UIUtility.SetUIStateOpen(this.m_prepareMyStateUIStateController, "Show2", delegate
			{
				UIUtility.SetUIStateOpen($this.m_prepareMyTimeUIStateController, "Show", null, false, true);
				string stateName = (side != 0) ? "RightProtect" : "LeftProtect";
				UIUtility.SetUIStateOpen($this.m_protectBanGroupUIStateController, stateName, null, false, true);
				$this.m_protectUIStateController.SetToUIState("Show", false, true);
			}, false, true);
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x003501A4 File Offset: 0x0034E3A4
		public void ShowBanIndicator(int side)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBanIndicatorInt32_hotfix != null)
			{
				this.m_ShowBanIndicatorInt32_hotfix.call(new object[]
				{
					this,
					side2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int side = side2;
			PVPBattlePrepareUIController $this = this;
			if (UIUtility.GetUIStateCurrentStateName(this.m_prepareMyStateTextUIStateController) == "KickOut")
			{
				return;
			}
			UIUtility.SetUIStateClose(this.m_prepareOpponentUIStateController, "Close", null, false, true);
			this.m_prepareMyStateTextUIStateController.SetToUIState("KickOut", false, true);
			this.m_prepareMyTimeUIStateController.gameObject.SetActive(false);
			UIUtility.SetUIStateOpen(this.m_prepareMyStateUIStateController, "Show2", delegate
			{
				UIUtility.SetUIStateOpen($this.m_prepareMyTimeUIStateController, "Show", null, false, true);
				string stateName = (side != 0) ? "RightKickOut" : "LeftKickOut";
				UIUtility.SetUIStateOpen($this.m_protectBanGroupUIStateController, stateName, null, false, true);
				$this.m_banUIStateController.SetToUIState("Show", false, true);
			}, false, true);
		}

		// Token: 0x0600BD6A RID: 48490 RVA: 0x00350298 File Offset: 0x0034E498
		public void ShowPrepareCompleteCountdown(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPrepareCompleteCountdownAction_hotfix != null)
			{
				this.m_ShowPrepareCompleteCountdownAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_prepareMyStateUIStateController, "Show", null, false, false);
			UIUtility.SetUIStateClose(this.m_prepareMyTimeUIStateController, "Close", null, false, false);
			UIUtility.SetUIStateClose(this.m_prepareOpponentUIStateController, "Close", null, false, false);
			this.m_protectBanGroupUIStateController.gameObject.SetActive(false);
			this.m_prepareMyStateTextUIStateController.SetActionForUIStateFinshed("Start", onEnd);
			this.m_prepareMyStateTextUIStateController.SetToUIState("Start", false, false);
		}

		// Token: 0x0600BD6B RID: 48491 RVA: 0x00350378 File Offset: 0x0034E578
		public void SetPickHeroCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPickHeroCountInt32_hotfix != null)
			{
				this.m_SetPickHeroCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetFigureState(0, (count <= 0) ? "Grey" : "Green");
			this.SetFigureState(1, (count <= 1) ? "Grey" : "Green");
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x00350424 File Offset: 0x0034E624
		public void SetProtectHeroCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetProtectHeroCountInt32_hotfix != null)
			{
				this.m_SetProtectHeroCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetFigureState(0, (count <= 0) ? "Grey" : "Blue");
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x003504B4 File Offset: 0x0034E6B4
		public void SetBanHeroCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBanHeroCountInt32_hotfix != null)
			{
				this.m_SetBanHeroCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetFigureState(0, (count <= 0) ? "Grey" : "Red");
		}

		// Token: 0x0600BD6E RID: 48494 RVA: 0x00350544 File Offset: 0x0034E744
		private void SetFigureState(int idx, string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFigureStateInt32String_hotfix != null)
			{
				this.m_SetFigureStateInt32String_hotfix.call(new object[]
				{
					this,
					idx,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx == 0)
			{
				this.m_prepareMyFigure1UIStateController.SetToUIState(stateName, false, true);
			}
			else if (idx == 1)
			{
				this.m_prepareMyFigure2UIStateController.SetToUIState(stateName, false, true);
			}
		}

		// Token: 0x0600BD6F RID: 48495 RVA: 0x003505F4 File Offset: 0x0034E7F4
		public void SetPrepareConfirmButtonState(bool isEenable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPrepareConfirmButtonStateBoolean_hotfix != null)
			{
				this.m_SetPrepareConfirmButtonStateBoolean_hotfix.call(new object[]
				{
					this,
					isEenable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_prepareConfirmButtonUIStateController.SetToUIState((!isEenable) ? "Grey" : "Change", false, false);
		}

		// Token: 0x0600BD70 RID: 48496 RVA: 0x00350688 File Offset: 0x0034E888
		public void SetPrepareCountdown(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPrepareCountdownTimeSpan_hotfix != null)
			{
				this.m_SetPrepareCountdownTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text prepareMyTimeText = this.m_prepareMyTimeText;
			string text = Mathf.CeilToInt((float)ts.TotalSeconds).ToString();
			this.m_prepareOpponentTimeText.text = text;
			prepareMyTimeText.text = text;
		}

		// Token: 0x0600BD71 RID: 48497 RVA: 0x0035072C File Offset: 0x0034E92C
		private void OnPrepareConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPrepareConfirmButtonClick_hotfix != null)
			{
				this.m_OnPrepareConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_prepareConfirmButtonUIStateController) == "Grey")
			{
				return;
			}
			if (this.EventOnPrepareConfirm != null)
			{
				this.EventOnPrepareConfirm();
			}
		}

		// Token: 0x14000248 RID: 584
		// (add) Token: 0x0600BD72 RID: 48498 RVA: 0x003507C0 File Offset: 0x0034E9C0
		// (remove) Token: 0x0600BD73 RID: 48499 RVA: 0x0035085C File Offset: 0x0034EA5C
		public event Action EventOnPrepareConfirm
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPrepareConfirmAction_hotfix != null)
				{
					this.m_add_EventOnPrepareConfirmAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrepareConfirm;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrepareConfirm, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPrepareConfirmAction_hotfix != null)
				{
					this.m_remove_EventOnPrepareConfirmAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrepareConfirm;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrepareConfirm, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x0600BD74 RID: 48500 RVA: 0x003508F8 File Offset: 0x0034EAF8
		// (set) Token: 0x0600BD75 RID: 48501 RVA: 0x00350918 File Offset: 0x0034EB18
		[DoNotToLua]
		public new PVPBattlePrepareUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PVPBattlePrepareUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x00350924 File Offset: 0x0034EB24
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x00350930 File Offset: 0x0034EB30
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x00350938 File Offset: 0x0034EB38
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x00350940 File Offset: 0x0034EB40
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BD7A RID: 48506 RVA: 0x00350954 File Offset: 0x0034EB54
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x0035095C File Offset: 0x0034EB5C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BD7C RID: 48508 RVA: 0x00350968 File Offset: 0x0034EB68
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BD7D RID: 48509 RVA: 0x00350974 File Offset: 0x0034EB74
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x00350980 File Offset: 0x0034EB80
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x0035098C File Offset: 0x0034EB8C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x00350998 File Offset: 0x0034EB98
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x003509A4 File Offset: 0x0034EBA4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x003509B0 File Offset: 0x0034EBB0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x003509BC File Offset: 0x0034EBBC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BD84 RID: 48516 RVA: 0x003509C8 File Offset: 0x0034EBC8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x003509D0 File Offset: 0x0034EBD0
		private void __callDele_EventOnPrepareConfirm()
		{
			Action eventOnPrepareConfirm = this.EventOnPrepareConfirm;
			if (eventOnPrepareConfirm != null)
			{
				eventOnPrepareConfirm();
			}
		}

		// Token: 0x0600BD86 RID: 48518 RVA: 0x003509F0 File Offset: 0x0034EBF0
		private void __clearDele_EventOnPrepareConfirm()
		{
			this.EventOnPrepareConfirm = null;
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x003509FC File Offset: 0x0034EBFC
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
					this.m_Finalize_hotfix = (luaObj.RawGet("Finalize") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_ShowOrderBooleanAction_hotfix = (luaObj.RawGet("ShowOrder") as LuaFunction);
					this.m_ShowPrepareStateBoolean_hotfix = (luaObj.RawGet("ShowPrepareState") as LuaFunction);
					this.m_ShowPickMyHeroInt32_hotfix = (luaObj.RawGet("ShowPickMyHero") as LuaFunction);
					this.m_ShowWaitOpponent_hotfix = (luaObj.RawGet("ShowWaitOpponent") as LuaFunction);
					this.m_ShowProtectIndicatorInt32_hotfix = (luaObj.RawGet("ShowProtectIndicator") as LuaFunction);
					this.m_ShowBanIndicatorInt32_hotfix = (luaObj.RawGet("ShowBanIndicator") as LuaFunction);
					this.m_ShowPrepareCompleteCountdownAction_hotfix = (luaObj.RawGet("ShowPrepareCompleteCountdown") as LuaFunction);
					this.m_SetPickHeroCountInt32_hotfix = (luaObj.RawGet("SetPickHeroCount") as LuaFunction);
					this.m_SetProtectHeroCountInt32_hotfix = (luaObj.RawGet("SetProtectHeroCount") as LuaFunction);
					this.m_SetBanHeroCountInt32_hotfix = (luaObj.RawGet("SetBanHeroCount") as LuaFunction);
					this.m_SetFigureStateInt32String_hotfix = (luaObj.RawGet("SetFigureState") as LuaFunction);
					this.m_SetPrepareConfirmButtonStateBoolean_hotfix = (luaObj.RawGet("SetPrepareConfirmButtonState") as LuaFunction);
					this.m_SetPrepareCountdownTimeSpan_hotfix = (luaObj.RawGet("SetPrepareCountdown") as LuaFunction);
					this.m_OnPrepareConfirmButtonClick_hotfix = (luaObj.RawGet("OnPrepareConfirmButtonClick") as LuaFunction);
					this.m_add_EventOnPrepareConfirmAction_hotfix = (luaObj.RawGet("add_EventOnPrepareConfirm") as LuaFunction);
					this.m_remove_EventOnPrepareConfirmAction_hotfix = (luaObj.RawGet("remove_EventOnPrepareConfirm") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x00350C70 File Offset: 0x0034EE70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PVPBattlePrepareUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007973 RID: 31091
		[AutoBind("./Panel/FirstOrAfter", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_orderUIStateController;

		// Token: 0x04007974 RID: 31092
		[AutoBind("./Panel/ShowFirst", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_orderFirstGameObject;

		// Token: 0x04007975 RID: 31093
		[AutoBind("./Panel/ShowAfter", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_orderAfterGameObject;

		// Token: 0x04007976 RID: 31094
		[AutoBind("./Panel/PrepareState", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_prepareStateGameObject;

		// Token: 0x04007977 RID: 31095
		[AutoBind("./Panel/PrepareState/TimeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareMyTimeUIStateController;

		// Token: 0x04007978 RID: 31096
		[AutoBind("./Panel/PrepareState/TimeGroup/Detail/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_prepareMyTimeText;

		// Token: 0x04007979 RID: 31097
		[AutoBind("./Panel/PrepareState/DetailGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareMyStateUIStateController;

		// Token: 0x0400797A RID: 31098
		[AutoBind("./Panel/PrepareState/DetailGroup/TextAndFigure", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareMyStateTextUIStateController;

		// Token: 0x0400797B RID: 31099
		[AutoBind("./Panel/PrepareState/DetailGroup/TextAndFigure/EffecctImage/Figure1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareMyFigure1UIStateController;

		// Token: 0x0400797C RID: 31100
		[AutoBind("./Panel/PrepareState/DetailGroup/TextAndFigure/EffecctImage/Figure2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareMyFigure2UIStateController;

		// Token: 0x0400797D RID: 31101
		[AutoBind("./Panel/PrepareState/DetailGroup/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_prepareConfirmButton;

		// Token: 0x0400797E RID: 31102
		[AutoBind("./Panel/PrepareState/DetailGroup/Button", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareConfirmButtonUIStateController;

		// Token: 0x0400797F RID: 31103
		[AutoBind("./Panel/OpponentPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_prepareOpponentUIStateController;

		// Token: 0x04007980 RID: 31104
		[AutoBind("./Panel/OpponentPanel/TimeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_prepareOpponentTimeText;

		// Token: 0x04007981 RID: 31105
		[AutoBind("./ActionArrowGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_protectBanGroupUIStateController;

		// Token: 0x04007982 RID: 31106
		[AutoBind("./ActionArrowGroup/Protect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_protectUIStateController;

		// Token: 0x04007983 RID: 31107
		[AutoBind("./ActionArrowGroup/KickOut", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_banUIStateController;

		// Token: 0x04007984 RID: 31108
		[DoNotToLua]
		private PVPBattlePrepareUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007985 RID: 31109
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007986 RID: 31110
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007987 RID: 31111
		private LuaFunction m_Finalize_hotfix;

		// Token: 0x04007988 RID: 31112
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007989 RID: 31113
		private LuaFunction m_ShowOrderBooleanAction_hotfix;

		// Token: 0x0400798A RID: 31114
		private LuaFunction m_ShowPrepareStateBoolean_hotfix;

		// Token: 0x0400798B RID: 31115
		private LuaFunction m_ShowPickMyHeroInt32_hotfix;

		// Token: 0x0400798C RID: 31116
		private LuaFunction m_ShowWaitOpponent_hotfix;

		// Token: 0x0400798D RID: 31117
		private LuaFunction m_ShowProtectIndicatorInt32_hotfix;

		// Token: 0x0400798E RID: 31118
		private LuaFunction m_ShowBanIndicatorInt32_hotfix;

		// Token: 0x0400798F RID: 31119
		private LuaFunction m_ShowPrepareCompleteCountdownAction_hotfix;

		// Token: 0x04007990 RID: 31120
		private LuaFunction m_SetPickHeroCountInt32_hotfix;

		// Token: 0x04007991 RID: 31121
		private LuaFunction m_SetProtectHeroCountInt32_hotfix;

		// Token: 0x04007992 RID: 31122
		private LuaFunction m_SetBanHeroCountInt32_hotfix;

		// Token: 0x04007993 RID: 31123
		private LuaFunction m_SetFigureStateInt32String_hotfix;

		// Token: 0x04007994 RID: 31124
		private LuaFunction m_SetPrepareConfirmButtonStateBoolean_hotfix;

		// Token: 0x04007995 RID: 31125
		private LuaFunction m_SetPrepareCountdownTimeSpan_hotfix;

		// Token: 0x04007996 RID: 31126
		private LuaFunction m_OnPrepareConfirmButtonClick_hotfix;

		// Token: 0x04007997 RID: 31127
		private LuaFunction m_add_EventOnPrepareConfirmAction_hotfix;

		// Token: 0x04007998 RID: 31128
		private LuaFunction m_remove_EventOnPrepareConfirmAction_hotfix;

		// Token: 0x02000B05 RID: 2821
		public new class LuaExportHelper
		{
			// Token: 0x0600BD89 RID: 48521 RVA: 0x00350CD8 File Offset: 0x0034EED8
			public LuaExportHelper(PVPBattlePrepareUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BD8A RID: 48522 RVA: 0x00350CE8 File Offset: 0x0034EEE8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BD8B RID: 48523 RVA: 0x00350CF8 File Offset: 0x0034EEF8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BD8C RID: 48524 RVA: 0x00350D08 File Offset: 0x0034EF08
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BD8D RID: 48525 RVA: 0x00350D18 File Offset: 0x0034EF18
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BD8E RID: 48526 RVA: 0x00350D30 File Offset: 0x0034EF30
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BD8F RID: 48527 RVA: 0x00350D40 File Offset: 0x0034EF40
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BD90 RID: 48528 RVA: 0x00350D50 File Offset: 0x0034EF50
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BD91 RID: 48529 RVA: 0x00350D60 File Offset: 0x0034EF60
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BD92 RID: 48530 RVA: 0x00350D70 File Offset: 0x0034EF70
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BD93 RID: 48531 RVA: 0x00350D80 File Offset: 0x0034EF80
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BD94 RID: 48532 RVA: 0x00350D90 File Offset: 0x0034EF90
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BD95 RID: 48533 RVA: 0x00350DA0 File Offset: 0x0034EFA0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BD96 RID: 48534 RVA: 0x00350DB0 File Offset: 0x0034EFB0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BD97 RID: 48535 RVA: 0x00350DC0 File Offset: 0x0034EFC0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BD98 RID: 48536 RVA: 0x00350DD0 File Offset: 0x0034EFD0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600BD99 RID: 48537 RVA: 0x00350DE0 File Offset: 0x0034EFE0
			public void __callDele_EventOnPrepareConfirm()
			{
				this.m_owner.__callDele_EventOnPrepareConfirm();
			}

			// Token: 0x0600BD9A RID: 48538 RVA: 0x00350DF0 File Offset: 0x0034EFF0
			public void __clearDele_EventOnPrepareConfirm()
			{
				this.m_owner.__clearDele_EventOnPrepareConfirm();
			}

			// Token: 0x17002608 RID: 9736
			// (get) Token: 0x0600BD9B RID: 48539 RVA: 0x00350E00 File Offset: 0x0034F000
			// (set) Token: 0x0600BD9C RID: 48540 RVA: 0x00350E10 File Offset: 0x0034F010
			public CommonUIStateController m_orderUIStateController
			{
				get
				{
					return this.m_owner.m_orderUIStateController;
				}
				set
				{
					this.m_owner.m_orderUIStateController = value;
				}
			}

			// Token: 0x17002609 RID: 9737
			// (get) Token: 0x0600BD9D RID: 48541 RVA: 0x00350E20 File Offset: 0x0034F020
			// (set) Token: 0x0600BD9E RID: 48542 RVA: 0x00350E30 File Offset: 0x0034F030
			public GameObject m_orderFirstGameObject
			{
				get
				{
					return this.m_owner.m_orderFirstGameObject;
				}
				set
				{
					this.m_owner.m_orderFirstGameObject = value;
				}
			}

			// Token: 0x1700260A RID: 9738
			// (get) Token: 0x0600BD9F RID: 48543 RVA: 0x00350E40 File Offset: 0x0034F040
			// (set) Token: 0x0600BDA0 RID: 48544 RVA: 0x00350E50 File Offset: 0x0034F050
			public GameObject m_orderAfterGameObject
			{
				get
				{
					return this.m_owner.m_orderAfterGameObject;
				}
				set
				{
					this.m_owner.m_orderAfterGameObject = value;
				}
			}

			// Token: 0x1700260B RID: 9739
			// (get) Token: 0x0600BDA1 RID: 48545 RVA: 0x00350E60 File Offset: 0x0034F060
			// (set) Token: 0x0600BDA2 RID: 48546 RVA: 0x00350E70 File Offset: 0x0034F070
			public GameObject m_prepareStateGameObject
			{
				get
				{
					return this.m_owner.m_prepareStateGameObject;
				}
				set
				{
					this.m_owner.m_prepareStateGameObject = value;
				}
			}

			// Token: 0x1700260C RID: 9740
			// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x00350E80 File Offset: 0x0034F080
			// (set) Token: 0x0600BDA4 RID: 48548 RVA: 0x00350E90 File Offset: 0x0034F090
			public CommonUIStateController m_prepareMyTimeUIStateController
			{
				get
				{
					return this.m_owner.m_prepareMyTimeUIStateController;
				}
				set
				{
					this.m_owner.m_prepareMyTimeUIStateController = value;
				}
			}

			// Token: 0x1700260D RID: 9741
			// (get) Token: 0x0600BDA5 RID: 48549 RVA: 0x00350EA0 File Offset: 0x0034F0A0
			// (set) Token: 0x0600BDA6 RID: 48550 RVA: 0x00350EB0 File Offset: 0x0034F0B0
			public Text m_prepareMyTimeText
			{
				get
				{
					return this.m_owner.m_prepareMyTimeText;
				}
				set
				{
					this.m_owner.m_prepareMyTimeText = value;
				}
			}

			// Token: 0x1700260E RID: 9742
			// (get) Token: 0x0600BDA7 RID: 48551 RVA: 0x00350EC0 File Offset: 0x0034F0C0
			// (set) Token: 0x0600BDA8 RID: 48552 RVA: 0x00350ED0 File Offset: 0x0034F0D0
			public CommonUIStateController m_prepareMyStateUIStateController
			{
				get
				{
					return this.m_owner.m_prepareMyStateUIStateController;
				}
				set
				{
					this.m_owner.m_prepareMyStateUIStateController = value;
				}
			}

			// Token: 0x1700260F RID: 9743
			// (get) Token: 0x0600BDA9 RID: 48553 RVA: 0x00350EE0 File Offset: 0x0034F0E0
			// (set) Token: 0x0600BDAA RID: 48554 RVA: 0x00350EF0 File Offset: 0x0034F0F0
			public CommonUIStateController m_prepareMyStateTextUIStateController
			{
				get
				{
					return this.m_owner.m_prepareMyStateTextUIStateController;
				}
				set
				{
					this.m_owner.m_prepareMyStateTextUIStateController = value;
				}
			}

			// Token: 0x17002610 RID: 9744
			// (get) Token: 0x0600BDAB RID: 48555 RVA: 0x00350F00 File Offset: 0x0034F100
			// (set) Token: 0x0600BDAC RID: 48556 RVA: 0x00350F10 File Offset: 0x0034F110
			public CommonUIStateController m_prepareMyFigure1UIStateController
			{
				get
				{
					return this.m_owner.m_prepareMyFigure1UIStateController;
				}
				set
				{
					this.m_owner.m_prepareMyFigure1UIStateController = value;
				}
			}

			// Token: 0x17002611 RID: 9745
			// (get) Token: 0x0600BDAD RID: 48557 RVA: 0x00350F20 File Offset: 0x0034F120
			// (set) Token: 0x0600BDAE RID: 48558 RVA: 0x00350F30 File Offset: 0x0034F130
			public CommonUIStateController m_prepareMyFigure2UIStateController
			{
				get
				{
					return this.m_owner.m_prepareMyFigure2UIStateController;
				}
				set
				{
					this.m_owner.m_prepareMyFigure2UIStateController = value;
				}
			}

			// Token: 0x17002612 RID: 9746
			// (get) Token: 0x0600BDAF RID: 48559 RVA: 0x00350F40 File Offset: 0x0034F140
			// (set) Token: 0x0600BDB0 RID: 48560 RVA: 0x00350F50 File Offset: 0x0034F150
			public Button m_prepareConfirmButton
			{
				get
				{
					return this.m_owner.m_prepareConfirmButton;
				}
				set
				{
					this.m_owner.m_prepareConfirmButton = value;
				}
			}

			// Token: 0x17002613 RID: 9747
			// (get) Token: 0x0600BDB1 RID: 48561 RVA: 0x00350F60 File Offset: 0x0034F160
			// (set) Token: 0x0600BDB2 RID: 48562 RVA: 0x00350F70 File Offset: 0x0034F170
			public CommonUIStateController m_prepareConfirmButtonUIStateController
			{
				get
				{
					return this.m_owner.m_prepareConfirmButtonUIStateController;
				}
				set
				{
					this.m_owner.m_prepareConfirmButtonUIStateController = value;
				}
			}

			// Token: 0x17002614 RID: 9748
			// (get) Token: 0x0600BDB3 RID: 48563 RVA: 0x00350F80 File Offset: 0x0034F180
			// (set) Token: 0x0600BDB4 RID: 48564 RVA: 0x00350F90 File Offset: 0x0034F190
			public CommonUIStateController m_prepareOpponentUIStateController
			{
				get
				{
					return this.m_owner.m_prepareOpponentUIStateController;
				}
				set
				{
					this.m_owner.m_prepareOpponentUIStateController = value;
				}
			}

			// Token: 0x17002615 RID: 9749
			// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x00350FA0 File Offset: 0x0034F1A0
			// (set) Token: 0x0600BDB6 RID: 48566 RVA: 0x00350FB0 File Offset: 0x0034F1B0
			public Text m_prepareOpponentTimeText
			{
				get
				{
					return this.m_owner.m_prepareOpponentTimeText;
				}
				set
				{
					this.m_owner.m_prepareOpponentTimeText = value;
				}
			}

			// Token: 0x17002616 RID: 9750
			// (get) Token: 0x0600BDB7 RID: 48567 RVA: 0x00350FC0 File Offset: 0x0034F1C0
			// (set) Token: 0x0600BDB8 RID: 48568 RVA: 0x00350FD0 File Offset: 0x0034F1D0
			public CommonUIStateController m_protectBanGroupUIStateController
			{
				get
				{
					return this.m_owner.m_protectBanGroupUIStateController;
				}
				set
				{
					this.m_owner.m_protectBanGroupUIStateController = value;
				}
			}

			// Token: 0x17002617 RID: 9751
			// (get) Token: 0x0600BDB9 RID: 48569 RVA: 0x00350FE0 File Offset: 0x0034F1E0
			// (set) Token: 0x0600BDBA RID: 48570 RVA: 0x00350FF0 File Offset: 0x0034F1F0
			public CommonUIStateController m_protectUIStateController
			{
				get
				{
					return this.m_owner.m_protectUIStateController;
				}
				set
				{
					this.m_owner.m_protectUIStateController = value;
				}
			}

			// Token: 0x17002618 RID: 9752
			// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x00351000 File Offset: 0x0034F200
			// (set) Token: 0x0600BDBC RID: 48572 RVA: 0x00351010 File Offset: 0x0034F210
			public CommonUIStateController m_banUIStateController
			{
				get
				{
					return this.m_owner.m_banUIStateController;
				}
				set
				{
					this.m_owner.m_banUIStateController = value;
				}
			}

			// Token: 0x0600BDBD RID: 48573 RVA: 0x00351020 File Offset: 0x0034F220
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BDBE RID: 48574 RVA: 0x00351030 File Offset: 0x0034F230
			public void SetFigureState(int idx, string stateName)
			{
				this.m_owner.SetFigureState(idx, stateName);
			}

			// Token: 0x0600BDBF RID: 48575 RVA: 0x00351040 File Offset: 0x0034F240
			public void OnPrepareConfirmButtonClick()
			{
				this.m_owner.OnPrepareConfirmButtonClick();
			}

			// Token: 0x04007999 RID: 31129
			private PVPBattlePrepareUIController m_owner;
		}
	}
}
