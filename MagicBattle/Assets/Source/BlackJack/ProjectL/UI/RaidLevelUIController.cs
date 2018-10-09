using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
	// Token: 0x02000ECA RID: 3786
	[HotFix]
	public class RaidLevelUIController : UIControllerBase
	{
		// Token: 0x060128E8 RID: 76008 RVA: 0x004C2704 File Offset: 0x004C0904
		private RaidLevelUIController()
		{
		}

		// Token: 0x060128E9 RID: 76009 RVA: 0x004C272C File Offset: 0x004C092C
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
			this.m_raidAgainButton.onClick.AddListener(new UnityAction(this.OnRaidAgainButtonClick));
			this.m_cannelButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x060128EA RID: 76010 RVA: 0x004C27E8 File Offset: 0x004C09E8
		public void ShowReward(BattleReward reward, List<Goods> extraReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardBattleRewardList`1_hotfix != null)
			{
				this.m_ShowRewardBattleRewardList`1_hotfix.call(new object[]
				{
					this,
					reward,
					extraReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_ShowReward(reward, extraReward));
		}

		// Token: 0x060128EB RID: 76011 RVA: 0x004C2878 File Offset: 0x004C0A78
		[DebuggerHidden]
		private IEnumerator Co_ShowReward(BattleReward reward, List<Goods> extraReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowRewardBattleRewardList`1_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowRewardBattleRewardList`1_hotfix.call(new object[]
				{
					this,
					reward,
					extraReward
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RaidLevelUIController.<Co_ShowReward>c__Iterator0 <Co_ShowReward>c__Iterator = new RaidLevelUIController.<Co_ShowReward>c__Iterator0();
			<Co_ShowReward>c__Iterator.reward = reward;
			<Co_ShowReward>c__Iterator.extraReward = extraReward;
			<Co_ShowReward>c__Iterator.$this = this;
			return <Co_ShowReward>c__Iterator;
		}

		// Token: 0x060128EC RID: 76012 RVA: 0x004C2920 File Offset: 0x004C0B20
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
			RaidLevelUIController.<Co_WaitClick>c__Iterator1 <Co_WaitClick>c__Iterator = new RaidLevelUIController.<Co_WaitClick>c__Iterator1();
			<Co_WaitClick>c__Iterator.$this = this;
			return <Co_WaitClick>c__Iterator;
		}

		// Token: 0x060128ED RID: 76013 RVA: 0x004C299C File Offset: 0x004C0B9C
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
			RaidLevelUIController.<Co_SetAndWaitUIState>c__Iterator2 <Co_SetAndWaitUIState>c__Iterator = new RaidLevelUIController.<Co_SetAndWaitUIState>c__Iterator2();
			<Co_SetAndWaitUIState>c__Iterator.ctrl = ctrl;
			<Co_SetAndWaitUIState>c__Iterator.state = state;
			return <Co_SetAndWaitUIState>c__Iterator;
		}

		// Token: 0x060128EE RID: 76014 RVA: 0x004C2A40 File Offset: 0x004C0C40
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
			RaidLevelUIController.<Co_ShowPlayerLevelUp>c__Iterator3 <Co_ShowPlayerLevelUp>c__Iterator = new RaidLevelUIController.<Co_ShowPlayerLevelUp>c__Iterator3();
			<Co_ShowPlayerLevelUp>c__Iterator.oldLevel = oldLevel;
			<Co_ShowPlayerLevelUp>c__Iterator.newLevel = newLevel;
			<Co_ShowPlayerLevelUp>c__Iterator.$this = this;
			return <Co_ShowPlayerLevelUp>c__Iterator;
		}

		// Token: 0x060128EF RID: 76015 RVA: 0x004C2AE8 File Offset: 0x004C0CE8
		private void ClearRewardGoods()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRewardGoods_hotfix != null)
			{
				this.m_ClearRewardGoods_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<RewardGoodsUIController>(this.m_rewardGoods);
			this.m_rewardGoods.Clear();
		}

		// Token: 0x060128F0 RID: 76016 RVA: 0x004C2B60 File Offset: 0x004C0D60
		public void SetRaidTicketCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRaidTicketCountInt32_hotfix != null)
			{
				this.m_SetRaidTicketCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_raidTicketText.text = count.ToString();
		}

		// Token: 0x060128F1 RID: 76017 RVA: 0x004C2BE8 File Offset: 0x004C0DE8
		public void SetNeedGoods(NeedGoods needGoods, BattleReward battleReward, List<Goods> extraReward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNeedGoodsNeedGoodsBattleRewardList`1_hotfix != null)
			{
				this.m_SetNeedGoodsNeedGoodsBattleRewardList`1_hotfix.call(new object[]
				{
					this,
					needGoods,
					battleReward,
					extraReward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (needGoods != null)
			{
				this.m_gainNeedGoodsCount = 0;
				this.m_needGoodsNameText.text = UIUtility.GetGoodsName(needGoods.goodsType, needGoods.goodsID);
				this.m_needGoodsIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(needGoods.goodsType, needGoods.goodsID));
				this.m_needGoodsIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(needGoods.goodsType, needGoods.goodsID));
				int num = needGoods.goodsNeedCount - this.m_playerContext.GetBagItemCountByType(needGoods.goodsType, needGoods.goodsID);
				this.m_needGoodsLackText.text = num.ToString();
				this.m_needGoodsLackText.gameObject.SetActive(num > 0);
				this.m_lackBGImageGameObject.SetActive(num > 0);
				this.m_lackTitleGameObject.SetActive(num > 0);
				this.m_needGoodsEnoughGameObject.SetActive(num <= 0);
				foreach (Goods goods in battleReward.Goods)
				{
					if (needGoods.goodsType == goods.GoodsType && needGoods.goodsID == goods.Id)
					{
						this.m_gainNeedGoodsCount += goods.Count;
					}
				}
				foreach (Goods goods2 in extraReward)
				{
					if (needGoods.goodsType == goods2.GoodsType && needGoods.goodsID == goods2.Id)
					{
						this.m_gainNeedGoodsCount += goods2.Count;
					}
				}
				this.m_needGoodsGainText.text = this.m_gainNeedGoodsCount.ToString();
				UIUtility.SetUIStateOpen(this.m_needGoodsPanelCommonUIStateCtrl, "Show", null, false, true);
			}
			else
			{
				this.m_needGoodsPanel.SetActive(false);
			}
		}

		// Token: 0x060128F2 RID: 76018 RVA: 0x004C2E9C File Offset: 0x004C109C
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
			this.m_gainNeedGoodsCount = 0;
			UIUtility.SetUIStateClose(this.m_needGoodsPanelCommonUIStateCtrl, "Close", null, false, true);
		}

		// Token: 0x060128F3 RID: 76019 RVA: 0x004C2F20 File Offset: 0x004C1120
		private void OnRaidAgainButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRaidAgainButtonClick_hotfix != null)
			{
				this.m_OnRaidAgainButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRaidAgain != null)
			{
				this.EventOnRaidAgain();
			}
		}

		// Token: 0x060128F4 RID: 76020 RVA: 0x004C2F98 File Offset: 0x004C1198
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

		// Token: 0x140003FD RID: 1021
		// (add) Token: 0x060128F5 RID: 76021 RVA: 0x004C3024 File Offset: 0x004C1224
		// (remove) Token: 0x060128F6 RID: 76022 RVA: 0x004C30C0 File Offset: 0x004C12C0
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

		// Token: 0x140003FE RID: 1022
		// (add) Token: 0x060128F7 RID: 76023 RVA: 0x004C315C File Offset: 0x004C135C
		// (remove) Token: 0x060128F8 RID: 76024 RVA: 0x004C31F8 File Offset: 0x004C13F8
		public event Action EventOnRaidAgain
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRaidAgainAction_hotfix != null)
				{
					this.m_add_EventOnRaidAgainAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRaidAgain;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRaidAgain, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRaidAgainAction_hotfix != null)
				{
					this.m_remove_EventOnRaidAgainAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRaidAgain;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRaidAgain, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x060128F9 RID: 76025 RVA: 0x004C3294 File Offset: 0x004C1494
		// (set) Token: 0x060128FA RID: 76026 RVA: 0x004C32B4 File Offset: 0x004C14B4
		[DoNotToLua]
		public new RaidLevelUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaidLevelUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060128FB RID: 76027 RVA: 0x004C32C0 File Offset: 0x004C14C0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060128FC RID: 76028 RVA: 0x004C32CC File Offset: 0x004C14CC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060128FD RID: 76029 RVA: 0x004C32D4 File Offset: 0x004C14D4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060128FE RID: 76030 RVA: 0x004C32DC File Offset: 0x004C14DC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060128FF RID: 76031 RVA: 0x004C32F0 File Offset: 0x004C14F0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012900 RID: 76032 RVA: 0x004C32F8 File Offset: 0x004C14F8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012901 RID: 76033 RVA: 0x004C3304 File Offset: 0x004C1504
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012902 RID: 76034 RVA: 0x004C3310 File Offset: 0x004C1510
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012903 RID: 76035 RVA: 0x004C331C File Offset: 0x004C151C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012904 RID: 76036 RVA: 0x004C3328 File Offset: 0x004C1528
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012905 RID: 76037 RVA: 0x004C3334 File Offset: 0x004C1534
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012906 RID: 76038 RVA: 0x004C3340 File Offset: 0x004C1540
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012907 RID: 76039 RVA: 0x004C334C File Offset: 0x004C154C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012908 RID: 76040 RVA: 0x004C3358 File Offset: 0x004C1558
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012909 RID: 76041 RVA: 0x004C3364 File Offset: 0x004C1564
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601290A RID: 76042 RVA: 0x004C336C File Offset: 0x004C156C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0601290B RID: 76043 RVA: 0x004C338C File Offset: 0x004C158C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0601290C RID: 76044 RVA: 0x004C3398 File Offset: 0x004C1598
		private void __callDele_EventOnRaidAgain()
		{
			Action eventOnRaidAgain = this.EventOnRaidAgain;
			if (eventOnRaidAgain != null)
			{
				eventOnRaidAgain();
			}
		}

		// Token: 0x0601290D RID: 76045 RVA: 0x004C33B8 File Offset: 0x004C15B8
		private void __clearDele_EventOnRaidAgain()
		{
			this.EventOnRaidAgain = null;
		}

		// Token: 0x0601290E RID: 76046 RVA: 0x004C33C4 File Offset: 0x004C15C4
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
					this.m_ShowRewardBattleRewardList`1_hotfix = (luaObj.RawGet("ShowReward") as LuaFunction);
					this.m_Co_ShowRewardBattleRewardList`1_hotfix = (luaObj.RawGet("Co_ShowReward") as LuaFunction);
					this.m_Co_WaitClick_hotfix = (luaObj.RawGet("Co_WaitClick") as LuaFunction);
					this.m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix = (luaObj.RawGet("Co_SetAndWaitUIState") as LuaFunction);
					this.m_Co_ShowPlayerLevelUpInt32Int32_hotfix = (luaObj.RawGet("Co_ShowPlayerLevelUp") as LuaFunction);
					this.m_ClearRewardGoods_hotfix = (luaObj.RawGet("ClearRewardGoods") as LuaFunction);
					this.m_SetRaidTicketCountInt32_hotfix = (luaObj.RawGet("SetRaidTicketCount") as LuaFunction);
					this.m_SetNeedGoodsNeedGoodsBattleRewardList`1_hotfix = (luaObj.RawGet("SetNeedGoods") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnRaidAgainButtonClick_hotfix = (luaObj.RawGet("OnRaidAgainButtonClick") as LuaFunction);
					this.m_PlayerLevelUpUITask_OnClose_hotfix = (luaObj.RawGet("PlayerLevelUpUITask_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnRaidAgainAction_hotfix = (luaObj.RawGet("add_EventOnRaidAgain") as LuaFunction);
					this.m_remove_EventOnRaidAgainAction_hotfix = (luaObj.RawGet("remove_EventOnRaidAgain") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601290F RID: 76047 RVA: 0x004C3608 File Offset: 0x004C1808
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaidLevelUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A6A8 RID: 42664
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A6A9 RID: 42665
		[AutoBind("./Panel/Exp/LevelUpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_levelUpEffectObj;

		// Token: 0x0400A6AA RID: 42666
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400A6AB RID: 42667
		[AutoBind("./Panel/RaidAgainButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_raidAgainButton;

		// Token: 0x0400A6AC RID: 42668
		[AutoBind("./Panel/CannelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cannelButton;

		// Token: 0x0400A6AD RID: 42669
		[AutoBind("./Panel/Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x0400A6AE RID: 42670
		[AutoBind("./Panel/Exp/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerExpText;

		// Token: 0x0400A6AF RID: 42671
		[AutoBind("./Panel/Exp/Bar/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerExpImage;

		// Token: 0x0400A6B0 RID: 42672
		[AutoBind("./Panel/Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldText;

		// Token: 0x0400A6B1 RID: 42673
		[AutoBind("./Panel/Rewards/Group", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGoodsGroupGameObject;

		// Token: 0x0400A6B2 RID: 42674
		[AutoBind("./Panel/ExtraRewards/Group", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_extraRewardGoodsGroupGameObject;

		// Token: 0x0400A6B3 RID: 42675
		[AutoBind("./Panel/RaidTicketGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_raidTicketText;

		// Token: 0x0400A6B4 RID: 42676
		[AutoBind("./NeedGoodsPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_needGoodsPanelCommonUIStateCtrl;

		// Token: 0x0400A6B5 RID: 42677
		[AutoBind("./NeedGoodsPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_needGoodsPanel;

		// Token: 0x0400A6B6 RID: 42678
		[AutoBind("./NeedGoodsPanel/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_needGoodsIconImage;

		// Token: 0x0400A6B7 RID: 42679
		[AutoBind("./NeedGoodsPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_needGoodsNameText;

		// Token: 0x0400A6B8 RID: 42680
		[AutoBind("./NeedGoodsPanel/LackAndEnoughGroup/BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lackBGImageGameObject;

		// Token: 0x0400A6B9 RID: 42681
		[AutoBind("./NeedGoodsPanel/LackAndEnoughGroup/LackTitleText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lackTitleGameObject;

		// Token: 0x0400A6BA RID: 42682
		[AutoBind("./NeedGoodsPanel/LackAndEnoughGroup/LackText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_needGoodsLackText;

		// Token: 0x0400A6BB RID: 42683
		[AutoBind("./NeedGoodsPanel/LackAndEnoughGroup/EnoughText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_needGoodsEnoughGameObject;

		// Token: 0x0400A6BC RID: 42684
		[AutoBind("./NeedGoodsPanel/GainText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_needGoodsGainText;

		// Token: 0x0400A6BD RID: 42685
		private List<RewardGoodsUIController> m_rewardGoods = new List<RewardGoodsUIController>();

		// Token: 0x0400A6BE RID: 42686
		private bool m_isClick;

		// Token: 0x0400A6BF RID: 42687
		private PlayerLevelUpUITask m_playerLevelUpUITask;

		// Token: 0x0400A6C0 RID: 42688
		private int m_gainNeedGoodsCount;

		// Token: 0x0400A6C1 RID: 42689
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A6C2 RID: 42690
		[DoNotToLua]
		private RaidLevelUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A6C3 RID: 42691
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A6C4 RID: 42692
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A6C5 RID: 42693
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A6C6 RID: 42694
		private LuaFunction m_ShowRewardBattleRewardList;

		// Token: 0x0400A6C7 RID: 42695
		private LuaFunction m_Co_ShowRewardBattleRewardList;

		// Token: 0x0400A6C8 RID: 42696
		private LuaFunction m_Co_WaitClick_hotfix;

		// Token: 0x0400A6C9 RID: 42697
		private LuaFunction m_Co_SetAndWaitUIStateCommonUIStateControllerString_hotfix;

		// Token: 0x0400A6CA RID: 42698
		private LuaFunction m_Co_ShowPlayerLevelUpInt32Int32_hotfix;

		// Token: 0x0400A6CB RID: 42699
		private LuaFunction m_ClearRewardGoods_hotfix;

		// Token: 0x0400A6CC RID: 42700
		private LuaFunction m_SetRaidTicketCountInt32_hotfix;

		// Token: 0x0400A6CD RID: 42701
		private LuaFunction m_SetNeedGoodsNeedGoodsBattleRewardList;

		// Token: 0x0400A6CE RID: 42702
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400A6CF RID: 42703
		private LuaFunction m_OnRaidAgainButtonClick_hotfix;

		// Token: 0x0400A6D0 RID: 42704
		private LuaFunction m_PlayerLevelUpUITask_OnClose_hotfix;

		// Token: 0x0400A6D1 RID: 42705
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A6D2 RID: 42706
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400A6D3 RID: 42707
		private LuaFunction m_add_EventOnRaidAgainAction_hotfix;

		// Token: 0x0400A6D4 RID: 42708
		private LuaFunction m_remove_EventOnRaidAgainAction_hotfix;

		// Token: 0x02000ECB RID: 3787
		public new class LuaExportHelper
		{
			// Token: 0x06012910 RID: 76048 RVA: 0x004C3670 File Offset: 0x004C1870
			public LuaExportHelper(RaidLevelUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012911 RID: 76049 RVA: 0x004C3680 File Offset: 0x004C1880
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012912 RID: 76050 RVA: 0x004C3690 File Offset: 0x004C1890
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012913 RID: 76051 RVA: 0x004C36A0 File Offset: 0x004C18A0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012914 RID: 76052 RVA: 0x004C36B0 File Offset: 0x004C18B0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012915 RID: 76053 RVA: 0x004C36C8 File Offset: 0x004C18C8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012916 RID: 76054 RVA: 0x004C36D8 File Offset: 0x004C18D8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012917 RID: 76055 RVA: 0x004C36E8 File Offset: 0x004C18E8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012918 RID: 76056 RVA: 0x004C36F8 File Offset: 0x004C18F8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012919 RID: 76057 RVA: 0x004C3708 File Offset: 0x004C1908
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601291A RID: 76058 RVA: 0x004C3718 File Offset: 0x004C1918
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601291B RID: 76059 RVA: 0x004C3728 File Offset: 0x004C1928
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601291C RID: 76060 RVA: 0x004C3738 File Offset: 0x004C1938
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601291D RID: 76061 RVA: 0x004C3748 File Offset: 0x004C1948
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601291E RID: 76062 RVA: 0x004C3758 File Offset: 0x004C1958
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601291F RID: 76063 RVA: 0x004C3768 File Offset: 0x004C1968
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012920 RID: 76064 RVA: 0x004C3778 File Offset: 0x004C1978
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06012921 RID: 76065 RVA: 0x004C3788 File Offset: 0x004C1988
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x06012922 RID: 76066 RVA: 0x004C3798 File Offset: 0x004C1998
			public void __callDele_EventOnRaidAgain()
			{
				this.m_owner.__callDele_EventOnRaidAgain();
			}

			// Token: 0x06012923 RID: 76067 RVA: 0x004C37A8 File Offset: 0x004C19A8
			public void __clearDele_EventOnRaidAgain()
			{
				this.m_owner.__clearDele_EventOnRaidAgain();
			}

			// Token: 0x17003814 RID: 14356
			// (get) Token: 0x06012924 RID: 76068 RVA: 0x004C37B8 File Offset: 0x004C19B8
			// (set) Token: 0x06012925 RID: 76069 RVA: 0x004C37C8 File Offset: 0x004C19C8
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

			// Token: 0x17003815 RID: 14357
			// (get) Token: 0x06012926 RID: 76070 RVA: 0x004C37D8 File Offset: 0x004C19D8
			// (set) Token: 0x06012927 RID: 76071 RVA: 0x004C37E8 File Offset: 0x004C19E8
			public GameObject m_levelUpEffectObj
			{
				get
				{
					return this.m_owner.m_levelUpEffectObj;
				}
				set
				{
					this.m_owner.m_levelUpEffectObj = value;
				}
			}

			// Token: 0x17003816 RID: 14358
			// (get) Token: 0x06012928 RID: 76072 RVA: 0x004C37F8 File Offset: 0x004C19F8
			// (set) Token: 0x06012929 RID: 76073 RVA: 0x004C3808 File Offset: 0x004C1A08
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

			// Token: 0x17003817 RID: 14359
			// (get) Token: 0x0601292A RID: 76074 RVA: 0x004C3818 File Offset: 0x004C1A18
			// (set) Token: 0x0601292B RID: 76075 RVA: 0x004C3828 File Offset: 0x004C1A28
			public Button m_raidAgainButton
			{
				get
				{
					return this.m_owner.m_raidAgainButton;
				}
				set
				{
					this.m_owner.m_raidAgainButton = value;
				}
			}

			// Token: 0x17003818 RID: 14360
			// (get) Token: 0x0601292C RID: 76076 RVA: 0x004C3838 File Offset: 0x004C1A38
			// (set) Token: 0x0601292D RID: 76077 RVA: 0x004C3848 File Offset: 0x004C1A48
			public Button m_cannelButton
			{
				get
				{
					return this.m_owner.m_cannelButton;
				}
				set
				{
					this.m_owner.m_cannelButton = value;
				}
			}

			// Token: 0x17003819 RID: 14361
			// (get) Token: 0x0601292E RID: 76078 RVA: 0x004C3858 File Offset: 0x004C1A58
			// (set) Token: 0x0601292F RID: 76079 RVA: 0x004C3868 File Offset: 0x004C1A68
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

			// Token: 0x1700381A RID: 14362
			// (get) Token: 0x06012930 RID: 76080 RVA: 0x004C3878 File Offset: 0x004C1A78
			// (set) Token: 0x06012931 RID: 76081 RVA: 0x004C3888 File Offset: 0x004C1A88
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

			// Token: 0x1700381B RID: 14363
			// (get) Token: 0x06012932 RID: 76082 RVA: 0x004C3898 File Offset: 0x004C1A98
			// (set) Token: 0x06012933 RID: 76083 RVA: 0x004C38A8 File Offset: 0x004C1AA8
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

			// Token: 0x1700381C RID: 14364
			// (get) Token: 0x06012934 RID: 76084 RVA: 0x004C38B8 File Offset: 0x004C1AB8
			// (set) Token: 0x06012935 RID: 76085 RVA: 0x004C38C8 File Offset: 0x004C1AC8
			public Text m_goldText
			{
				get
				{
					return this.m_owner.m_goldText;
				}
				set
				{
					this.m_owner.m_goldText = value;
				}
			}

			// Token: 0x1700381D RID: 14365
			// (get) Token: 0x06012936 RID: 76086 RVA: 0x004C38D8 File Offset: 0x004C1AD8
			// (set) Token: 0x06012937 RID: 76087 RVA: 0x004C38E8 File Offset: 0x004C1AE8
			public GameObject m_rewardGoodsGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGoodsGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGoodsGroupGameObject = value;
				}
			}

			// Token: 0x1700381E RID: 14366
			// (get) Token: 0x06012938 RID: 76088 RVA: 0x004C38F8 File Offset: 0x004C1AF8
			// (set) Token: 0x06012939 RID: 76089 RVA: 0x004C3908 File Offset: 0x004C1B08
			public GameObject m_extraRewardGoodsGroupGameObject
			{
				get
				{
					return this.m_owner.m_extraRewardGoodsGroupGameObject;
				}
				set
				{
					this.m_owner.m_extraRewardGoodsGroupGameObject = value;
				}
			}

			// Token: 0x1700381F RID: 14367
			// (get) Token: 0x0601293A RID: 76090 RVA: 0x004C3918 File Offset: 0x004C1B18
			// (set) Token: 0x0601293B RID: 76091 RVA: 0x004C3928 File Offset: 0x004C1B28
			public Text m_raidTicketText
			{
				get
				{
					return this.m_owner.m_raidTicketText;
				}
				set
				{
					this.m_owner.m_raidTicketText = value;
				}
			}

			// Token: 0x17003820 RID: 14368
			// (get) Token: 0x0601293C RID: 76092 RVA: 0x004C3938 File Offset: 0x004C1B38
			// (set) Token: 0x0601293D RID: 76093 RVA: 0x004C3948 File Offset: 0x004C1B48
			public CommonUIStateController m_needGoodsPanelCommonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_needGoodsPanelCommonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_needGoodsPanelCommonUIStateCtrl = value;
				}
			}

			// Token: 0x17003821 RID: 14369
			// (get) Token: 0x0601293E RID: 76094 RVA: 0x004C3958 File Offset: 0x004C1B58
			// (set) Token: 0x0601293F RID: 76095 RVA: 0x004C3968 File Offset: 0x004C1B68
			public GameObject m_needGoodsPanel
			{
				get
				{
					return this.m_owner.m_needGoodsPanel;
				}
				set
				{
					this.m_owner.m_needGoodsPanel = value;
				}
			}

			// Token: 0x17003822 RID: 14370
			// (get) Token: 0x06012940 RID: 76096 RVA: 0x004C3978 File Offset: 0x004C1B78
			// (set) Token: 0x06012941 RID: 76097 RVA: 0x004C3988 File Offset: 0x004C1B88
			public Image m_needGoodsIconImage
			{
				get
				{
					return this.m_owner.m_needGoodsIconImage;
				}
				set
				{
					this.m_owner.m_needGoodsIconImage = value;
				}
			}

			// Token: 0x17003823 RID: 14371
			// (get) Token: 0x06012942 RID: 76098 RVA: 0x004C3998 File Offset: 0x004C1B98
			// (set) Token: 0x06012943 RID: 76099 RVA: 0x004C39A8 File Offset: 0x004C1BA8
			public Text m_needGoodsNameText
			{
				get
				{
					return this.m_owner.m_needGoodsNameText;
				}
				set
				{
					this.m_owner.m_needGoodsNameText = value;
				}
			}

			// Token: 0x17003824 RID: 14372
			// (get) Token: 0x06012944 RID: 76100 RVA: 0x004C39B8 File Offset: 0x004C1BB8
			// (set) Token: 0x06012945 RID: 76101 RVA: 0x004C39C8 File Offset: 0x004C1BC8
			public GameObject m_lackBGImageGameObject
			{
				get
				{
					return this.m_owner.m_lackBGImageGameObject;
				}
				set
				{
					this.m_owner.m_lackBGImageGameObject = value;
				}
			}

			// Token: 0x17003825 RID: 14373
			// (get) Token: 0x06012946 RID: 76102 RVA: 0x004C39D8 File Offset: 0x004C1BD8
			// (set) Token: 0x06012947 RID: 76103 RVA: 0x004C39E8 File Offset: 0x004C1BE8
			public GameObject m_lackTitleGameObject
			{
				get
				{
					return this.m_owner.m_lackTitleGameObject;
				}
				set
				{
					this.m_owner.m_lackTitleGameObject = value;
				}
			}

			// Token: 0x17003826 RID: 14374
			// (get) Token: 0x06012948 RID: 76104 RVA: 0x004C39F8 File Offset: 0x004C1BF8
			// (set) Token: 0x06012949 RID: 76105 RVA: 0x004C3A08 File Offset: 0x004C1C08
			public Text m_needGoodsLackText
			{
				get
				{
					return this.m_owner.m_needGoodsLackText;
				}
				set
				{
					this.m_owner.m_needGoodsLackText = value;
				}
			}

			// Token: 0x17003827 RID: 14375
			// (get) Token: 0x0601294A RID: 76106 RVA: 0x004C3A18 File Offset: 0x004C1C18
			// (set) Token: 0x0601294B RID: 76107 RVA: 0x004C3A28 File Offset: 0x004C1C28
			public GameObject m_needGoodsEnoughGameObject
			{
				get
				{
					return this.m_owner.m_needGoodsEnoughGameObject;
				}
				set
				{
					this.m_owner.m_needGoodsEnoughGameObject = value;
				}
			}

			// Token: 0x17003828 RID: 14376
			// (get) Token: 0x0601294C RID: 76108 RVA: 0x004C3A38 File Offset: 0x004C1C38
			// (set) Token: 0x0601294D RID: 76109 RVA: 0x004C3A48 File Offset: 0x004C1C48
			public Text m_needGoodsGainText
			{
				get
				{
					return this.m_owner.m_needGoodsGainText;
				}
				set
				{
					this.m_owner.m_needGoodsGainText = value;
				}
			}

			// Token: 0x17003829 RID: 14377
			// (get) Token: 0x0601294E RID: 76110 RVA: 0x004C3A58 File Offset: 0x004C1C58
			// (set) Token: 0x0601294F RID: 76111 RVA: 0x004C3A68 File Offset: 0x004C1C68
			public List<RewardGoodsUIController> m_rewardGoods
			{
				get
				{
					return this.m_owner.m_rewardGoods;
				}
				set
				{
					this.m_owner.m_rewardGoods = value;
				}
			}

			// Token: 0x1700382A RID: 14378
			// (get) Token: 0x06012950 RID: 76112 RVA: 0x004C3A78 File Offset: 0x004C1C78
			// (set) Token: 0x06012951 RID: 76113 RVA: 0x004C3A88 File Offset: 0x004C1C88
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

			// Token: 0x1700382B RID: 14379
			// (get) Token: 0x06012952 RID: 76114 RVA: 0x004C3A98 File Offset: 0x004C1C98
			// (set) Token: 0x06012953 RID: 76115 RVA: 0x004C3AA8 File Offset: 0x004C1CA8
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

			// Token: 0x1700382C RID: 14380
			// (get) Token: 0x06012954 RID: 76116 RVA: 0x004C3AB8 File Offset: 0x004C1CB8
			// (set) Token: 0x06012955 RID: 76117 RVA: 0x004C3AC8 File Offset: 0x004C1CC8
			public int m_gainNeedGoodsCount
			{
				get
				{
					return this.m_owner.m_gainNeedGoodsCount;
				}
				set
				{
					this.m_owner.m_gainNeedGoodsCount = value;
				}
			}

			// Token: 0x1700382D RID: 14381
			// (get) Token: 0x06012956 RID: 76118 RVA: 0x004C3AD8 File Offset: 0x004C1CD8
			// (set) Token: 0x06012957 RID: 76119 RVA: 0x004C3AE8 File Offset: 0x004C1CE8
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

			// Token: 0x06012958 RID: 76120 RVA: 0x004C3AF8 File Offset: 0x004C1CF8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012959 RID: 76121 RVA: 0x004C3B08 File Offset: 0x004C1D08
			public IEnumerator Co_ShowReward(BattleReward reward, List<Goods> extraReward)
			{
				return this.m_owner.Co_ShowReward(reward, extraReward);
			}

			// Token: 0x0601295A RID: 76122 RVA: 0x004C3B18 File Offset: 0x004C1D18
			public IEnumerator Co_WaitClick()
			{
				return this.m_owner.Co_WaitClick();
			}

			// Token: 0x0601295B RID: 76123 RVA: 0x004C3B28 File Offset: 0x004C1D28
			public IEnumerator Co_SetAndWaitUIState(CommonUIStateController ctrl, string state)
			{
				return this.m_owner.Co_SetAndWaitUIState(ctrl, state);
			}

			// Token: 0x0601295C RID: 76124 RVA: 0x004C3B38 File Offset: 0x004C1D38
			public IEnumerator Co_ShowPlayerLevelUp(int oldLevel, int newLevel)
			{
				return this.m_owner.Co_ShowPlayerLevelUp(oldLevel, newLevel);
			}

			// Token: 0x0601295D RID: 76125 RVA: 0x004C3B48 File Offset: 0x004C1D48
			public void ClearRewardGoods()
			{
				this.m_owner.ClearRewardGoods();
			}

			// Token: 0x0601295E RID: 76126 RVA: 0x004C3B58 File Offset: 0x004C1D58
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0601295F RID: 76127 RVA: 0x004C3B68 File Offset: 0x004C1D68
			public void OnRaidAgainButtonClick()
			{
				this.m_owner.OnRaidAgainButtonClick();
			}

			// Token: 0x06012960 RID: 76128 RVA: 0x004C3B78 File Offset: 0x004C1D78
			public void PlayerLevelUpUITask_OnClose()
			{
				this.m_owner.PlayerLevelUpUITask_OnClose();
			}

			// Token: 0x0400A6D5 RID: 42709
			private RaidLevelUIController m_owner;
		}
	}
}
