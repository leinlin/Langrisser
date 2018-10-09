using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FE3 RID: 4067
	[HotFix]
	public class UnchartedUIController : UIControllerBase
	{
		// Token: 0x060145DF RID: 83423 RVA: 0x0052DD14 File Offset: 0x0052BF14
		private UnchartedUIController()
		{
		}

		// Token: 0x060145E0 RID: 83424 RVA: 0x0052DD48 File Offset: 0x0052BF48
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
			this.m_dailyToggle.isOn = false;
			this.m_limitTimeToggle.isOn = false;
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_teamButton.onClick.AddListener(new UnityAction(this.OnTeamButtonClick));
			this.m_dailyToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnDailyToggleValueChanged));
			this.m_limitTimeToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnLimitTimeToggleValueChanged));
			this.m_thearchyButton.onClick.AddListener(new UnityAction(this.OnThearchyButtonClick));
			this.m_anikiButton.onClick.AddListener(new UnityAction(this.OnAnikiButtonClick));
			this.m_treasureMapButton.onClick.AddListener(new UnityAction(this.OnTreasureMapButtonClick));
			this.m_memoryCorridorButton.onClick.AddListener(new UnityAction(this.OnMemoryCorridorButtonClick));
			this.m_heroTrainingButton.onClick.AddListener(new UnityAction(this.OnHeroTrainingButtonClick));
			this.m_climbTowerButton.onClick.AddListener(new UnityAction(this.OnClimbTowerButtonClick));
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x060145E1 RID: 83425 RVA: 0x0052DEEC File Offset: 0x0052C0EC
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState("Show", false, true);
		}

		// Token: 0x060145E2 RID: 83426 RVA: 0x0052DF60 File Offset: 0x0052C160
		public void SetUnchartedInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedInfo_hotfix != null)
			{
				this.m_SetUnchartedInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetButtonOpened(this.m_anikiUIStateController, GameFunctionType.GameFunctionType_AnikiGym);
			this.SetButtonOpened(this.m_thearchyUIStateController, GameFunctionType.GameFunctionType_ThearchyTrial);
			this.SetButtonOpened(this.m_memoryCorridorUIStateController, GameFunctionType.GameFunctionType_MemoryCorridor);
			this.SetButtonOpened(this.m_heroTrainingUIStateController, GameFunctionType.GameFunctionType_HeroTrainning);
			this.SetButtonOpened(this.m_treasureMapUIStateController, GameFunctionType.GameFunctionType_TreasureMap);
			this.SetButtonOpened(this.m_climbTowerUIStateController, GameFunctionType.GameFunctionType_ClimbTower);
			UIUtility.SetDailyRewardCount(this.m_anikiDailyRewardText, this.m_playerContext.GetAnikiDailyRewardRestCount(), this.m_playerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_AnikiGym));
			UIUtility.SetDailyRewardCount(this.m_thearchyDailyRewardText, this.m_playerContext.GetThearchyDailyRewardRestCount(), this.m_playerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_ThearchyTrial));
			UIUtility.SetDailyRewardCount(this.m_memoryCorridorDailyRewardText, this.m_playerContext.GetMemoryCorridorDailyRewardRestCount(), this.m_playerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_MemoryCorridor));
			UIUtility.SetDailyRewardCount(this.m_heroTrainingDailyRewardText, this.m_playerContext.GetHeroTrainingDailyRewardRestCount(), this.m_playerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_HeroTrainning));
			this.SetTreasureMapDailyCount(this.m_playerContext.GetTreasureTicketCount(), this.m_configDataLoader.GetConfigDataTicketLimitInfo(41).MaxNums);
			this.SetLimitTimeItems();
		}

		// Token: 0x060145E3 RID: 83427 RVA: 0x0052E0CC File Offset: 0x0052C2CC
		public void SetClimbTowerFlushTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetClimbTowerFlushTimeTimeSpan_hotfix != null)
			{
				this.m_SetClimbTowerFlushTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_climbTowerFlushtText.text = UIUtility.TimeSpanToString(ts);
		}

		// Token: 0x060145E4 RID: 83428 RVA: 0x0052E150 File Offset: 0x0052C350
		private void SetButtonOpened(CommonUIStateController ctrl, GameFunctionType gameFunctionType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetButtonOpenedCommonUIStateControllerGameFunctionType_hotfix != null)
			{
				this.m_SetButtonOpenedCommonUIStateControllerGameFunctionType_hotfix.call(new object[]
				{
					this,
					ctrl,
					gameFunctionType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerContext.IsGameFunctionOpened(gameFunctionType);
			ctrl.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
		}

		// Token: 0x060145E5 RID: 83429 RVA: 0x0052E1FC File Offset: 0x0052C3FC
		private void SetTreasureMapDailyCount(int haveCount, int allCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTreasureMapDailyCountInt32Int32_hotfix != null)
			{
				this.m_SetTreasureMapDailyCountInt32Int32_hotfix.call(new object[]
				{
					this,
					haveCount,
					allCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (haveCount == 0)
			{
				if (allCount == 0)
				{
					this.m_treasureMapCountText.text = UIUtility.AddColorTag(haveCount.ToString(), new Color32(220, 10, 10, byte.MaxValue)) + "/∞";
				}
				else
				{
					this.m_treasureMapCountText.text = UIUtility.AddColorTag(haveCount.ToString(), new Color32(220, 10, 10, byte.MaxValue)) + "/" + allCount;
				}
			}
			else if (allCount == 0)
			{
				this.m_treasureMapCountText.text = haveCount + "/∞";
			}
			else
			{
				this.m_treasureMapCountText.text = haveCount + "/" + allCount;
			}
		}

		// Token: 0x060145E6 RID: 83430 RVA: 0x0052E360 File Offset: 0x0052C560
		public void SetUnchartedToggle(int tabIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedToggleInt32_hotfix != null)
			{
				this.m_SetUnchartedToggleInt32_hotfix.call(new object[]
				{
					this,
					tabIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (tabIndex == 1)
			{
				this.m_dailyToggle.isOn = true;
				this.m_limitTimeToggle.isOn = false;
			}
			else if (tabIndex == 2)
			{
				this.m_dailyToggle.isOn = false;
				this.m_limitTimeToggle.isOn = true;
			}
		}

		// Token: 0x060145E7 RID: 83431 RVA: 0x0052E414 File Offset: 0x0052C614
		private void FireEventOnShowUncharted(BattleType battleType, int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FireEventOnShowUnchartedBattleTypeInt32_hotfix != null)
			{
				this.m_FireEventOnShowUnchartedBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					battleType,
					chapterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowUncharted != null)
			{
				this.EventOnShowUncharted(battleType, chapterId);
			}
		}

		// Token: 0x060145E8 RID: 83432 RVA: 0x0052E4AC File Offset: 0x0052C6AC
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x060145E9 RID: 83433 RVA: 0x0052E524 File Offset: 0x0052C724
		private void OnTeamButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTeamButtonClick_hotfix != null)
			{
				this.m_OnTeamButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowTeam != null)
			{
				this.EventOnShowTeam();
			}
		}

		// Token: 0x060145EA RID: 83434 RVA: 0x0052E59C File Offset: 0x0052C79C
		private void OnDailyToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDailyToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnDailyToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dailyScrollRect.gameObject.SetActive(isOn);
			this.m_limitTimeScrollRect.gameObject.SetActive(!isOn);
			if (isOn)
			{
				this.m_dailyScrollRect.normalizedPosition = Vector2.one;
			}
		}

		// Token: 0x060145EB RID: 83435 RVA: 0x0052E648 File Offset: 0x0052C848
		private void OnLimitTimeToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLimitTimeToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnLimitTimeToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dailyScrollRect.gameObject.SetActive(!isOn);
			this.m_limitTimeScrollRect.gameObject.SetActive(isOn);
			if (isOn)
			{
				this.SetLimitTimeItems();
				this.m_limitTimeScrollRect.normalizedPosition = Vector2.one;
			}
		}

		// Token: 0x060145EC RID: 83436 RVA: 0x0052E6FC File Offset: 0x0052C8FC
		private void SetLimitTimeItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitTimeItems_hotfix != null)
			{
				this.m_SetLimitTimeItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_limitTimeScrollRect.content.gameObject);
			foreach (KeyValuePair<int, ConfigDataCooperateBattleInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataCooperateBattleInfo())
			{
				if (this.m_playerContext.IsCooperateBattleDisplayable(keyValuePair.Key))
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_cooperateBattleButtonPrefab, this.m_limitTimeScrollRect.content.transform, false);
					CooperateBattleButton cooperateBattleButton = GameObjectUtility.AddControllerToGameObject<CooperateBattleButton>(go);
					cooperateBattleButton.SetCooperateBattleInfo(keyValuePair.Value);
					cooperateBattleButton.EventOnStartCooperateBattle += this.OnCooperateBattleButtonClick;
				}
			}
			foreach (KeyValuePair<int, ConfigDataHeroPhantomInfo> keyValuePair2 in this.m_configDataLoader.GetAllConfigDataHeroPhantomInfo())
			{
				if (this.m_playerContext.IsHeroPhantomDisplay(keyValuePair2.Key))
				{
					GameObject go2 = UnityEngine.Object.Instantiate<GameObject>(this.m_heroPhantomButtonPrefab, this.m_limitTimeScrollRect.content.transform, false);
					HeroPhantomButton heroPhantomButton = GameObjectUtility.AddControllerToGameObject<HeroPhantomButton>(go2);
					heroPhantomButton.SetHeroPhantomInfo(keyValuePair2.Value);
					heroPhantomButton.EventOnStartHeroPhantom += this.OnHeroPhantomButtonClick;
				}
			}
			foreach (KeyValuePair<int, ConfigDataUnchartedScoreInfo> keyValuePair3 in this.m_configDataLoader.GetAllConfigDataUnchartedScoreInfo())
			{
				if (this.m_playerContext.IsUnchartedScoreDisplay(keyValuePair3.Key))
				{
					GameObject go3 = UnityEngine.Object.Instantiate<GameObject>(this.m_unchartedScoreButtonPrefab, this.m_limitTimeScrollRect.content.transform, false);
					UnchartedScoreButton unchartedScoreButton = GameObjectUtility.AddControllerToGameObject<UnchartedScoreButton>(go3);
					unchartedScoreButton.SetUnchartedScoreInfo(keyValuePair3.Value);
					unchartedScoreButton.EventOnStartUnchartedScore += this.OnUnchartedScoreButtonClick;
				}
			}
		}

		// Token: 0x060145ED RID: 83437 RVA: 0x0052E96C File Offset: 0x0052CB6C
		private void OnAnikiButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAnikiButtonClick_hotfix != null)
			{
				this.m_OnAnikiButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AnikiGym))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_AnikiGym), 2f, null, true);
			}
			else
			{
				this.FireEventOnShowUncharted(BattleType.AnikiGym, 0);
			}
		}

		// Token: 0x060145EE RID: 83438 RVA: 0x0052EA04 File Offset: 0x0052CC04
		private void OnThearchyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnThearchyButtonClick_hotfix != null)
			{
				this.m_OnThearchyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ThearchyTrial))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_ThearchyTrial), 2f, null, true);
			}
			else
			{
				this.FireEventOnShowUncharted(BattleType.ThearchyTrial, 0);
			}
		}

		// Token: 0x060145EF RID: 83439 RVA: 0x0052EA9C File Offset: 0x0052CC9C
		private void OnTreasureMapButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTreasureMapButtonClick_hotfix != null)
			{
				this.m_OnTreasureMapButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TreasureMap))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_TreasureMap), 2f, null, true);
			}
			else
			{
				this.FireEventOnShowUncharted(BattleType.TreasureMap, 0);
			}
		}

		// Token: 0x060145F0 RID: 83440 RVA: 0x0052EB34 File Offset: 0x0052CD34
		private void OnMemoryCorridorButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryCorridorButtonClick_hotfix != null)
			{
				this.m_OnMemoryCorridorButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_MemoryCorridor))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_MemoryCorridor), 2f, null, true);
			}
			else
			{
				this.FireEventOnShowUncharted(BattleType.MemoryCorridor, 0);
			}
		}

		// Token: 0x060145F1 RID: 83441 RVA: 0x0052EBCC File Offset: 0x0052CDCC
		private void OnHeroTrainingButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroTrainingButtonClick_hotfix != null)
			{
				this.m_OnHeroTrainingButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroTrainning))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_HeroTrainning), 2f, null, true);
			}
			else
			{
				this.FireEventOnShowUncharted(BattleType.HeroTrainning, 0);
			}
		}

		// Token: 0x060145F2 RID: 83442 RVA: 0x0052EC64 File Offset: 0x0052CE64
		private void OnClimbTowerButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClimbTowerButtonClick_hotfix != null)
			{
				this.m_OnClimbTowerButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ClimbTower))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_ClimbTower), 2f, null, true);
			}
			else
			{
				this.FireEventOnShowUncharted(BattleType.ClimbTower, 0);
			}
		}

		// Token: 0x060145F3 RID: 83443 RVA: 0x0052ECFC File Offset: 0x0052CEFC
		private void OnHeroPhantomButtonClick(HeroPhantomButton ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroPhantomButtonClickHeroPhantomButton_hotfix != null)
			{
				this.m_OnHeroPhantomButtonClickHeroPhantomButton_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.FireEventOnShowUncharted(BattleType.HeroPhantom, ctrl.GetHeroPhantomInfo().ID);
		}

		// Token: 0x060145F4 RID: 83444 RVA: 0x0052ED80 File Offset: 0x0052CF80
		private void OnCooperateBattleButtonClick(CooperateBattleButton ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCooperateBattleButtonClickCooperateBattleButton_hotfix != null)
			{
				this.m_OnCooperateBattleButtonClickCooperateBattleButton_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.FireEventOnShowUncharted(BattleType.CooperateBattle, ctrl.GetCooperateBattleInfo().ID);
		}

		// Token: 0x060145F5 RID: 83445 RVA: 0x0052EE04 File Offset: 0x0052D004
		private void OnUnchartedScoreButtonClick(UnchartedScoreButton ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnchartedScoreButtonClickUnchartedScoreButton_hotfix != null)
			{
				this.m_OnUnchartedScoreButtonClickUnchartedScoreButton_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.FireEventOnShowUncharted(BattleType.UnchartedScore_ScoreLevel, ctrl.GetUnchartedScoreInfo().ID);
		}

		// Token: 0x1400047B RID: 1147
		// (add) Token: 0x060145F6 RID: 83446 RVA: 0x0052EE88 File Offset: 0x0052D088
		// (remove) Token: 0x060145F7 RID: 83447 RVA: 0x0052EF24 File Offset: 0x0052D124
		public event Action<BattleType, int> EventOnShowUncharted
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowUnchartedAction`2_hotfix != null)
				{
					this.m_add_EventOnShowUnchartedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int> action = this.EventOnShowUncharted;
				Action<BattleType, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int>>(ref this.EventOnShowUncharted, (Action<BattleType, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowUnchartedAction`2_hotfix != null)
				{
					this.m_remove_EventOnShowUnchartedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int> action = this.EventOnShowUncharted;
				Action<BattleType, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int>>(ref this.EventOnShowUncharted, (Action<BattleType, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400047C RID: 1148
		// (add) Token: 0x060145F8 RID: 83448 RVA: 0x0052EFC0 File Offset: 0x0052D1C0
		// (remove) Token: 0x060145F9 RID: 83449 RVA: 0x0052F05C File Offset: 0x0052D25C
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400047D RID: 1149
		// (add) Token: 0x060145FA RID: 83450 RVA: 0x0052F0F8 File Offset: 0x0052D2F8
		// (remove) Token: 0x060145FB RID: 83451 RVA: 0x0052F194 File Offset: 0x0052D394
		public event Action EventOnShowTeam
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowTeamAction_hotfix != null)
				{
					this.m_add_EventOnShowTeamAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTeam;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTeam, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowTeamAction_hotfix != null)
				{
					this.m_remove_EventOnShowTeamAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTeam;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTeam, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x060145FC RID: 83452 RVA: 0x0052F230 File Offset: 0x0052D430
		// (set) Token: 0x060145FD RID: 83453 RVA: 0x0052F250 File Offset: 0x0052D450
		[DoNotToLua]
		public new UnchartedUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060145FE RID: 83454 RVA: 0x0052F25C File Offset: 0x0052D45C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060145FF RID: 83455 RVA: 0x0052F268 File Offset: 0x0052D468
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014600 RID: 83456 RVA: 0x0052F270 File Offset: 0x0052D470
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014601 RID: 83457 RVA: 0x0052F278 File Offset: 0x0052D478
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014602 RID: 83458 RVA: 0x0052F28C File Offset: 0x0052D48C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014603 RID: 83459 RVA: 0x0052F294 File Offset: 0x0052D494
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014604 RID: 83460 RVA: 0x0052F2A0 File Offset: 0x0052D4A0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014605 RID: 83461 RVA: 0x0052F2AC File Offset: 0x0052D4AC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014606 RID: 83462 RVA: 0x0052F2B8 File Offset: 0x0052D4B8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014607 RID: 83463 RVA: 0x0052F2C4 File Offset: 0x0052D4C4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014608 RID: 83464 RVA: 0x0052F2D0 File Offset: 0x0052D4D0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014609 RID: 83465 RVA: 0x0052F2DC File Offset: 0x0052D4DC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601460A RID: 83466 RVA: 0x0052F2E8 File Offset: 0x0052D4E8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601460B RID: 83467 RVA: 0x0052F2F4 File Offset: 0x0052D4F4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601460C RID: 83468 RVA: 0x0052F300 File Offset: 0x0052D500
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601460D RID: 83469 RVA: 0x0052F308 File Offset: 0x0052D508
		private void __callDele_EventOnShowUncharted(BattleType arg1, int arg2)
		{
			Action<BattleType, int> eventOnShowUncharted = this.EventOnShowUncharted;
			if (eventOnShowUncharted != null)
			{
				eventOnShowUncharted(arg1, arg2);
			}
		}

		// Token: 0x0601460E RID: 83470 RVA: 0x0052F32C File Offset: 0x0052D52C
		private void __clearDele_EventOnShowUncharted(BattleType arg1, int arg2)
		{
			this.EventOnShowUncharted = null;
		}

		// Token: 0x0601460F RID: 83471 RVA: 0x0052F338 File Offset: 0x0052D538
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06014610 RID: 83472 RVA: 0x0052F358 File Offset: 0x0052D558
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06014611 RID: 83473 RVA: 0x0052F364 File Offset: 0x0052D564
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x06014612 RID: 83474 RVA: 0x0052F384 File Offset: 0x0052D584
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x06014613 RID: 83475 RVA: 0x0052F390 File Offset: 0x0052D590
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SetUnchartedInfo_hotfix = (luaObj.RawGet("SetUnchartedInfo") as LuaFunction);
					this.m_SetClimbTowerFlushTimeTimeSpan_hotfix = (luaObj.RawGet("SetClimbTowerFlushTime") as LuaFunction);
					this.m_SetButtonOpenedCommonUIStateControllerGameFunctionType_hotfix = (luaObj.RawGet("SetButtonOpened") as LuaFunction);
					this.m_SetTreasureMapDailyCountInt32Int32_hotfix = (luaObj.RawGet("SetTreasureMapDailyCount") as LuaFunction);
					this.m_SetUnchartedToggleInt32_hotfix = (luaObj.RawGet("SetUnchartedToggle") as LuaFunction);
					this.m_FireEventOnShowUnchartedBattleTypeInt32_hotfix = (luaObj.RawGet("FireEventOnShowUncharted") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_OnDailyToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnDailyToggleValueChanged") as LuaFunction);
					this.m_OnLimitTimeToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnLimitTimeToggleValueChanged") as LuaFunction);
					this.m_SetLimitTimeItems_hotfix = (luaObj.RawGet("SetLimitTimeItems") as LuaFunction);
					this.m_OnAnikiButtonClick_hotfix = (luaObj.RawGet("OnAnikiButtonClick") as LuaFunction);
					this.m_OnThearchyButtonClick_hotfix = (luaObj.RawGet("OnThearchyButtonClick") as LuaFunction);
					this.m_OnTreasureMapButtonClick_hotfix = (luaObj.RawGet("OnTreasureMapButtonClick") as LuaFunction);
					this.m_OnMemoryCorridorButtonClick_hotfix = (luaObj.RawGet("OnMemoryCorridorButtonClick") as LuaFunction);
					this.m_OnHeroTrainingButtonClick_hotfix = (luaObj.RawGet("OnHeroTrainingButtonClick") as LuaFunction);
					this.m_OnClimbTowerButtonClick_hotfix = (luaObj.RawGet("OnClimbTowerButtonClick") as LuaFunction);
					this.m_OnHeroPhantomButtonClickHeroPhantomButton_hotfix = (luaObj.RawGet("OnHeroPhantomButtonClick") as LuaFunction);
					this.m_OnCooperateBattleButtonClickCooperateBattleButton_hotfix = (luaObj.RawGet("OnCooperateBattleButtonClick") as LuaFunction);
					this.m_OnUnchartedScoreButtonClickUnchartedScoreButton_hotfix = (luaObj.RawGet("OnUnchartedScoreButtonClick") as LuaFunction);
					this.m_add_EventOnShowUnchartedAction`2_hotfix = (luaObj.RawGet("add_EventOnShowUncharted") as LuaFunction);
					this.m_remove_EventOnShowUnchartedAction`2_hotfix = (luaObj.RawGet("remove_EventOnShowUncharted") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014614 RID: 83476 RVA: 0x0052F700 File Offset: 0x0052D900
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B39E RID: 45982
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B39F RID: 45983
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400B3A0 RID: 45984
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400B3A1 RID: 45985
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x0400B3A2 RID: 45986
		[AutoBind("./Margin/Toggle/DailyToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_dailyToggle;

		// Token: 0x0400B3A3 RID: 45987
		[AutoBind("./Margin/Toggle/LimitTimeToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_limitTimeToggle;

		// Token: 0x0400B3A4 RID: 45988
		[AutoBind("./UnchartedList/DailyUnchartedList", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_dailyScrollRect;

		// Token: 0x0400B3A5 RID: 45989
		[AutoBind("./UnchartedList/LimitTimeUnchartedList", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_limitTimeScrollRect;

		// Token: 0x0400B3A6 RID: 45990
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Aniki", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_anikiButton;

		// Token: 0x0400B3A7 RID: 45991
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Aniki", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_anikiUIStateController;

		// Token: 0x0400B3A8 RID: 45992
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Aniki/DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_anikiDailyRewardText;

		// Token: 0x0400B3A9 RID: 45993
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Thearchy", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_thearchyButton;

		// Token: 0x0400B3AA RID: 45994
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Thearchy", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_thearchyUIStateController;

		// Token: 0x0400B3AB RID: 45995
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Thearchy/DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_thearchyDailyRewardText;

		// Token: 0x0400B3AC RID: 45996
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/TreasureMap", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_treasureMapButton;

		// Token: 0x0400B3AD RID: 45997
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/TreasureMap", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_treasureMapUIStateController;

		// Token: 0x0400B3AE RID: 45998
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/TreasureMap/DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_treasureMapCountText;

		// Token: 0x0400B3AF RID: 45999
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/MemoryCorridor", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryCorridorButton;

		// Token: 0x0400B3B0 RID: 46000
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/MemoryCorridor", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_memoryCorridorUIStateController;

		// Token: 0x0400B3B1 RID: 46001
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/MemoryCorridor/DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_memoryCorridorDailyRewardText;

		// Token: 0x0400B3B2 RID: 46002
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Training", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroTrainingButton;

		// Token: 0x0400B3B3 RID: 46003
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Training", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroTrainingUIStateController;

		// Token: 0x0400B3B4 RID: 46004
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/Training/DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroTrainingDailyRewardText;

		// Token: 0x0400B3B5 RID: 46005
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/ClimbTower", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_climbTowerButton;

		// Token: 0x0400B3B6 RID: 46006
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/ClimbTower", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_climbTowerUIStateController;

		// Token: 0x0400B3B7 RID: 46007
		[AutoBind("./UnchartedList/DailyUnchartedList/Viewport/Content/ClimbTower/DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_climbTowerFlushtText;

		// Token: 0x0400B3B8 RID: 46008
		[AutoBind("./Prefabs/HeroPhantom", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroPhantomButtonPrefab;

		// Token: 0x0400B3B9 RID: 46009
		[AutoBind("./Prefabs/CooperateBattle", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_cooperateBattleButtonPrefab;

		// Token: 0x0400B3BA RID: 46010
		[AutoBind("./Prefabs/UnchartedScore", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unchartedScoreButtonPrefab;

		// Token: 0x0400B3BB RID: 46011
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400B3BC RID: 46012
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400B3BD RID: 46013
		[DoNotToLua]
		private UnchartedUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B3BE RID: 46014
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B3BF RID: 46015
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B3C0 RID: 46016
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B3C1 RID: 46017
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B3C2 RID: 46018
		private LuaFunction m_SetUnchartedInfo_hotfix;

		// Token: 0x0400B3C3 RID: 46019
		private LuaFunction m_SetClimbTowerFlushTimeTimeSpan_hotfix;

		// Token: 0x0400B3C4 RID: 46020
		private LuaFunction m_SetButtonOpenedCommonUIStateControllerGameFunctionType_hotfix;

		// Token: 0x0400B3C5 RID: 46021
		private LuaFunction m_SetTreasureMapDailyCountInt32Int32_hotfix;

		// Token: 0x0400B3C6 RID: 46022
		private LuaFunction m_SetUnchartedToggleInt32_hotfix;

		// Token: 0x0400B3C7 RID: 46023
		private LuaFunction m_FireEventOnShowUnchartedBattleTypeInt32_hotfix;

		// Token: 0x0400B3C8 RID: 46024
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400B3C9 RID: 46025
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x0400B3CA RID: 46026
		private LuaFunction m_OnDailyToggleValueChangedBoolean_hotfix;

		// Token: 0x0400B3CB RID: 46027
		private LuaFunction m_OnLimitTimeToggleValueChangedBoolean_hotfix;

		// Token: 0x0400B3CC RID: 46028
		private LuaFunction m_SetLimitTimeItems_hotfix;

		// Token: 0x0400B3CD RID: 46029
		private LuaFunction m_OnAnikiButtonClick_hotfix;

		// Token: 0x0400B3CE RID: 46030
		private LuaFunction m_OnThearchyButtonClick_hotfix;

		// Token: 0x0400B3CF RID: 46031
		private LuaFunction m_OnTreasureMapButtonClick_hotfix;

		// Token: 0x0400B3D0 RID: 46032
		private LuaFunction m_OnMemoryCorridorButtonClick_hotfix;

		// Token: 0x0400B3D1 RID: 46033
		private LuaFunction m_OnHeroTrainingButtonClick_hotfix;

		// Token: 0x0400B3D2 RID: 46034
		private LuaFunction m_OnClimbTowerButtonClick_hotfix;

		// Token: 0x0400B3D3 RID: 46035
		private LuaFunction m_OnHeroPhantomButtonClickHeroPhantomButton_hotfix;

		// Token: 0x0400B3D4 RID: 46036
		private LuaFunction m_OnCooperateBattleButtonClickCooperateBattleButton_hotfix;

		// Token: 0x0400B3D5 RID: 46037
		private LuaFunction m_OnUnchartedScoreButtonClickUnchartedScoreButton_hotfix;

		// Token: 0x0400B3D6 RID: 46038
		private LuaFunction m_add_EventOnShowUnchartedAction;

		// Token: 0x0400B3D7 RID: 46039
		private LuaFunction m_remove_EventOnShowUnchartedAction;

		// Token: 0x0400B3D8 RID: 46040
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400B3D9 RID: 46041
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400B3DA RID: 46042
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x0400B3DB RID: 46043
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x02000FE4 RID: 4068
		public new class LuaExportHelper
		{
			// Token: 0x06014615 RID: 83477 RVA: 0x0052F768 File Offset: 0x0052D968
			public LuaExportHelper(UnchartedUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014616 RID: 83478 RVA: 0x0052F778 File Offset: 0x0052D978
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014617 RID: 83479 RVA: 0x0052F788 File Offset: 0x0052D988
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014618 RID: 83480 RVA: 0x0052F798 File Offset: 0x0052D998
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014619 RID: 83481 RVA: 0x0052F7A8 File Offset: 0x0052D9A8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601461A RID: 83482 RVA: 0x0052F7C0 File Offset: 0x0052D9C0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601461B RID: 83483 RVA: 0x0052F7D0 File Offset: 0x0052D9D0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601461C RID: 83484 RVA: 0x0052F7E0 File Offset: 0x0052D9E0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601461D RID: 83485 RVA: 0x0052F7F0 File Offset: 0x0052D9F0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601461E RID: 83486 RVA: 0x0052F800 File Offset: 0x0052DA00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601461F RID: 83487 RVA: 0x0052F810 File Offset: 0x0052DA10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014620 RID: 83488 RVA: 0x0052F820 File Offset: 0x0052DA20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014621 RID: 83489 RVA: 0x0052F830 File Offset: 0x0052DA30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014622 RID: 83490 RVA: 0x0052F840 File Offset: 0x0052DA40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014623 RID: 83491 RVA: 0x0052F850 File Offset: 0x0052DA50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014624 RID: 83492 RVA: 0x0052F860 File Offset: 0x0052DA60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014625 RID: 83493 RVA: 0x0052F870 File Offset: 0x0052DA70
			public void __callDele_EventOnShowUncharted(BattleType arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnShowUncharted(arg1, arg2);
			}

			// Token: 0x06014626 RID: 83494 RVA: 0x0052F880 File Offset: 0x0052DA80
			public void __clearDele_EventOnShowUncharted(BattleType arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnShowUncharted(arg1, arg2);
			}

			// Token: 0x06014627 RID: 83495 RVA: 0x0052F890 File Offset: 0x0052DA90
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06014628 RID: 83496 RVA: 0x0052F8A0 File Offset: 0x0052DAA0
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06014629 RID: 83497 RVA: 0x0052F8B0 File Offset: 0x0052DAB0
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x0601462A RID: 83498 RVA: 0x0052F8C0 File Offset: 0x0052DAC0
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x17003C6C RID: 15468
			// (get) Token: 0x0601462B RID: 83499 RVA: 0x0052F8D0 File Offset: 0x0052DAD0
			// (set) Token: 0x0601462C RID: 83500 RVA: 0x0052F8E0 File Offset: 0x0052DAE0
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

			// Token: 0x17003C6D RID: 15469
			// (get) Token: 0x0601462D RID: 83501 RVA: 0x0052F8F0 File Offset: 0x0052DAF0
			// (set) Token: 0x0601462E RID: 83502 RVA: 0x0052F900 File Offset: 0x0052DB00
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17003C6E RID: 15470
			// (get) Token: 0x0601462F RID: 83503 RVA: 0x0052F910 File Offset: 0x0052DB10
			// (set) Token: 0x06014630 RID: 83504 RVA: 0x0052F920 File Offset: 0x0052DB20
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17003C6F RID: 15471
			// (get) Token: 0x06014631 RID: 83505 RVA: 0x0052F930 File Offset: 0x0052DB30
			// (set) Token: 0x06014632 RID: 83506 RVA: 0x0052F940 File Offset: 0x0052DB40
			public Button m_teamButton
			{
				get
				{
					return this.m_owner.m_teamButton;
				}
				set
				{
					this.m_owner.m_teamButton = value;
				}
			}

			// Token: 0x17003C70 RID: 15472
			// (get) Token: 0x06014633 RID: 83507 RVA: 0x0052F950 File Offset: 0x0052DB50
			// (set) Token: 0x06014634 RID: 83508 RVA: 0x0052F960 File Offset: 0x0052DB60
			public Toggle m_dailyToggle
			{
				get
				{
					return this.m_owner.m_dailyToggle;
				}
				set
				{
					this.m_owner.m_dailyToggle = value;
				}
			}

			// Token: 0x17003C71 RID: 15473
			// (get) Token: 0x06014635 RID: 83509 RVA: 0x0052F970 File Offset: 0x0052DB70
			// (set) Token: 0x06014636 RID: 83510 RVA: 0x0052F980 File Offset: 0x0052DB80
			public Toggle m_limitTimeToggle
			{
				get
				{
					return this.m_owner.m_limitTimeToggle;
				}
				set
				{
					this.m_owner.m_limitTimeToggle = value;
				}
			}

			// Token: 0x17003C72 RID: 15474
			// (get) Token: 0x06014637 RID: 83511 RVA: 0x0052F990 File Offset: 0x0052DB90
			// (set) Token: 0x06014638 RID: 83512 RVA: 0x0052F9A0 File Offset: 0x0052DBA0
			public ScrollRect m_dailyScrollRect
			{
				get
				{
					return this.m_owner.m_dailyScrollRect;
				}
				set
				{
					this.m_owner.m_dailyScrollRect = value;
				}
			}

			// Token: 0x17003C73 RID: 15475
			// (get) Token: 0x06014639 RID: 83513 RVA: 0x0052F9B0 File Offset: 0x0052DBB0
			// (set) Token: 0x0601463A RID: 83514 RVA: 0x0052F9C0 File Offset: 0x0052DBC0
			public ScrollRect m_limitTimeScrollRect
			{
				get
				{
					return this.m_owner.m_limitTimeScrollRect;
				}
				set
				{
					this.m_owner.m_limitTimeScrollRect = value;
				}
			}

			// Token: 0x17003C74 RID: 15476
			// (get) Token: 0x0601463B RID: 83515 RVA: 0x0052F9D0 File Offset: 0x0052DBD0
			// (set) Token: 0x0601463C RID: 83516 RVA: 0x0052F9E0 File Offset: 0x0052DBE0
			public Button m_anikiButton
			{
				get
				{
					return this.m_owner.m_anikiButton;
				}
				set
				{
					this.m_owner.m_anikiButton = value;
				}
			}

			// Token: 0x17003C75 RID: 15477
			// (get) Token: 0x0601463D RID: 83517 RVA: 0x0052F9F0 File Offset: 0x0052DBF0
			// (set) Token: 0x0601463E RID: 83518 RVA: 0x0052FA00 File Offset: 0x0052DC00
			public CommonUIStateController m_anikiUIStateController
			{
				get
				{
					return this.m_owner.m_anikiUIStateController;
				}
				set
				{
					this.m_owner.m_anikiUIStateController = value;
				}
			}

			// Token: 0x17003C76 RID: 15478
			// (get) Token: 0x0601463F RID: 83519 RVA: 0x0052FA10 File Offset: 0x0052DC10
			// (set) Token: 0x06014640 RID: 83520 RVA: 0x0052FA20 File Offset: 0x0052DC20
			public Text m_anikiDailyRewardText
			{
				get
				{
					return this.m_owner.m_anikiDailyRewardText;
				}
				set
				{
					this.m_owner.m_anikiDailyRewardText = value;
				}
			}

			// Token: 0x17003C77 RID: 15479
			// (get) Token: 0x06014641 RID: 83521 RVA: 0x0052FA30 File Offset: 0x0052DC30
			// (set) Token: 0x06014642 RID: 83522 RVA: 0x0052FA40 File Offset: 0x0052DC40
			public Button m_thearchyButton
			{
				get
				{
					return this.m_owner.m_thearchyButton;
				}
				set
				{
					this.m_owner.m_thearchyButton = value;
				}
			}

			// Token: 0x17003C78 RID: 15480
			// (get) Token: 0x06014643 RID: 83523 RVA: 0x0052FA50 File Offset: 0x0052DC50
			// (set) Token: 0x06014644 RID: 83524 RVA: 0x0052FA60 File Offset: 0x0052DC60
			public CommonUIStateController m_thearchyUIStateController
			{
				get
				{
					return this.m_owner.m_thearchyUIStateController;
				}
				set
				{
					this.m_owner.m_thearchyUIStateController = value;
				}
			}

			// Token: 0x17003C79 RID: 15481
			// (get) Token: 0x06014645 RID: 83525 RVA: 0x0052FA70 File Offset: 0x0052DC70
			// (set) Token: 0x06014646 RID: 83526 RVA: 0x0052FA80 File Offset: 0x0052DC80
			public Text m_thearchyDailyRewardText
			{
				get
				{
					return this.m_owner.m_thearchyDailyRewardText;
				}
				set
				{
					this.m_owner.m_thearchyDailyRewardText = value;
				}
			}

			// Token: 0x17003C7A RID: 15482
			// (get) Token: 0x06014647 RID: 83527 RVA: 0x0052FA90 File Offset: 0x0052DC90
			// (set) Token: 0x06014648 RID: 83528 RVA: 0x0052FAA0 File Offset: 0x0052DCA0
			public Button m_treasureMapButton
			{
				get
				{
					return this.m_owner.m_treasureMapButton;
				}
				set
				{
					this.m_owner.m_treasureMapButton = value;
				}
			}

			// Token: 0x17003C7B RID: 15483
			// (get) Token: 0x06014649 RID: 83529 RVA: 0x0052FAB0 File Offset: 0x0052DCB0
			// (set) Token: 0x0601464A RID: 83530 RVA: 0x0052FAC0 File Offset: 0x0052DCC0
			public CommonUIStateController m_treasureMapUIStateController
			{
				get
				{
					return this.m_owner.m_treasureMapUIStateController;
				}
				set
				{
					this.m_owner.m_treasureMapUIStateController = value;
				}
			}

			// Token: 0x17003C7C RID: 15484
			// (get) Token: 0x0601464B RID: 83531 RVA: 0x0052FAD0 File Offset: 0x0052DCD0
			// (set) Token: 0x0601464C RID: 83532 RVA: 0x0052FAE0 File Offset: 0x0052DCE0
			public Text m_treasureMapCountText
			{
				get
				{
					return this.m_owner.m_treasureMapCountText;
				}
				set
				{
					this.m_owner.m_treasureMapCountText = value;
				}
			}

			// Token: 0x17003C7D RID: 15485
			// (get) Token: 0x0601464D RID: 83533 RVA: 0x0052FAF0 File Offset: 0x0052DCF0
			// (set) Token: 0x0601464E RID: 83534 RVA: 0x0052FB00 File Offset: 0x0052DD00
			public Button m_memoryCorridorButton
			{
				get
				{
					return this.m_owner.m_memoryCorridorButton;
				}
				set
				{
					this.m_owner.m_memoryCorridorButton = value;
				}
			}

			// Token: 0x17003C7E RID: 15486
			// (get) Token: 0x0601464F RID: 83535 RVA: 0x0052FB10 File Offset: 0x0052DD10
			// (set) Token: 0x06014650 RID: 83536 RVA: 0x0052FB20 File Offset: 0x0052DD20
			public CommonUIStateController m_memoryCorridorUIStateController
			{
				get
				{
					return this.m_owner.m_memoryCorridorUIStateController;
				}
				set
				{
					this.m_owner.m_memoryCorridorUIStateController = value;
				}
			}

			// Token: 0x17003C7F RID: 15487
			// (get) Token: 0x06014651 RID: 83537 RVA: 0x0052FB30 File Offset: 0x0052DD30
			// (set) Token: 0x06014652 RID: 83538 RVA: 0x0052FB40 File Offset: 0x0052DD40
			public Text m_memoryCorridorDailyRewardText
			{
				get
				{
					return this.m_owner.m_memoryCorridorDailyRewardText;
				}
				set
				{
					this.m_owner.m_memoryCorridorDailyRewardText = value;
				}
			}

			// Token: 0x17003C80 RID: 15488
			// (get) Token: 0x06014653 RID: 83539 RVA: 0x0052FB50 File Offset: 0x0052DD50
			// (set) Token: 0x06014654 RID: 83540 RVA: 0x0052FB60 File Offset: 0x0052DD60
			public Button m_heroTrainingButton
			{
				get
				{
					return this.m_owner.m_heroTrainingButton;
				}
				set
				{
					this.m_owner.m_heroTrainingButton = value;
				}
			}

			// Token: 0x17003C81 RID: 15489
			// (get) Token: 0x06014655 RID: 83541 RVA: 0x0052FB70 File Offset: 0x0052DD70
			// (set) Token: 0x06014656 RID: 83542 RVA: 0x0052FB80 File Offset: 0x0052DD80
			public CommonUIStateController m_heroTrainingUIStateController
			{
				get
				{
					return this.m_owner.m_heroTrainingUIStateController;
				}
				set
				{
					this.m_owner.m_heroTrainingUIStateController = value;
				}
			}

			// Token: 0x17003C82 RID: 15490
			// (get) Token: 0x06014657 RID: 83543 RVA: 0x0052FB90 File Offset: 0x0052DD90
			// (set) Token: 0x06014658 RID: 83544 RVA: 0x0052FBA0 File Offset: 0x0052DDA0
			public Text m_heroTrainingDailyRewardText
			{
				get
				{
					return this.m_owner.m_heroTrainingDailyRewardText;
				}
				set
				{
					this.m_owner.m_heroTrainingDailyRewardText = value;
				}
			}

			// Token: 0x17003C83 RID: 15491
			// (get) Token: 0x06014659 RID: 83545 RVA: 0x0052FBB0 File Offset: 0x0052DDB0
			// (set) Token: 0x0601465A RID: 83546 RVA: 0x0052FBC0 File Offset: 0x0052DDC0
			public Button m_climbTowerButton
			{
				get
				{
					return this.m_owner.m_climbTowerButton;
				}
				set
				{
					this.m_owner.m_climbTowerButton = value;
				}
			}

			// Token: 0x17003C84 RID: 15492
			// (get) Token: 0x0601465B RID: 83547 RVA: 0x0052FBD0 File Offset: 0x0052DDD0
			// (set) Token: 0x0601465C RID: 83548 RVA: 0x0052FBE0 File Offset: 0x0052DDE0
			public CommonUIStateController m_climbTowerUIStateController
			{
				get
				{
					return this.m_owner.m_climbTowerUIStateController;
				}
				set
				{
					this.m_owner.m_climbTowerUIStateController = value;
				}
			}

			// Token: 0x17003C85 RID: 15493
			// (get) Token: 0x0601465D RID: 83549 RVA: 0x0052FBF0 File Offset: 0x0052DDF0
			// (set) Token: 0x0601465E RID: 83550 RVA: 0x0052FC00 File Offset: 0x0052DE00
			public Text m_climbTowerFlushtText
			{
				get
				{
					return this.m_owner.m_climbTowerFlushtText;
				}
				set
				{
					this.m_owner.m_climbTowerFlushtText = value;
				}
			}

			// Token: 0x17003C86 RID: 15494
			// (get) Token: 0x0601465F RID: 83551 RVA: 0x0052FC10 File Offset: 0x0052DE10
			// (set) Token: 0x06014660 RID: 83552 RVA: 0x0052FC20 File Offset: 0x0052DE20
			public GameObject m_heroPhantomButtonPrefab
			{
				get
				{
					return this.m_owner.m_heroPhantomButtonPrefab;
				}
				set
				{
					this.m_owner.m_heroPhantomButtonPrefab = value;
				}
			}

			// Token: 0x17003C87 RID: 15495
			// (get) Token: 0x06014661 RID: 83553 RVA: 0x0052FC30 File Offset: 0x0052DE30
			// (set) Token: 0x06014662 RID: 83554 RVA: 0x0052FC40 File Offset: 0x0052DE40
			public GameObject m_cooperateBattleButtonPrefab
			{
				get
				{
					return this.m_owner.m_cooperateBattleButtonPrefab;
				}
				set
				{
					this.m_owner.m_cooperateBattleButtonPrefab = value;
				}
			}

			// Token: 0x17003C88 RID: 15496
			// (get) Token: 0x06014663 RID: 83555 RVA: 0x0052FC50 File Offset: 0x0052DE50
			// (set) Token: 0x06014664 RID: 83556 RVA: 0x0052FC60 File Offset: 0x0052DE60
			public GameObject m_unchartedScoreButtonPrefab
			{
				get
				{
					return this.m_owner.m_unchartedScoreButtonPrefab;
				}
				set
				{
					this.m_owner.m_unchartedScoreButtonPrefab = value;
				}
			}

			// Token: 0x17003C89 RID: 15497
			// (get) Token: 0x06014665 RID: 83557 RVA: 0x0052FC70 File Offset: 0x0052DE70
			// (set) Token: 0x06014666 RID: 83558 RVA: 0x0052FC80 File Offset: 0x0052DE80
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

			// Token: 0x17003C8A RID: 15498
			// (get) Token: 0x06014667 RID: 83559 RVA: 0x0052FC90 File Offset: 0x0052DE90
			// (set) Token: 0x06014668 RID: 83560 RVA: 0x0052FCA0 File Offset: 0x0052DEA0
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

			// Token: 0x06014669 RID: 83561 RVA: 0x0052FCB0 File Offset: 0x0052DEB0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601466A RID: 83562 RVA: 0x0052FCC0 File Offset: 0x0052DEC0
			public void SetButtonOpened(CommonUIStateController ctrl, GameFunctionType gameFunctionType)
			{
				this.m_owner.SetButtonOpened(ctrl, gameFunctionType);
			}

			// Token: 0x0601466B RID: 83563 RVA: 0x0052FCD0 File Offset: 0x0052DED0
			public void SetTreasureMapDailyCount(int haveCount, int allCount)
			{
				this.m_owner.SetTreasureMapDailyCount(haveCount, allCount);
			}

			// Token: 0x0601466C RID: 83564 RVA: 0x0052FCE0 File Offset: 0x0052DEE0
			public void FireEventOnShowUncharted(BattleType battleType, int chapterId)
			{
				this.m_owner.FireEventOnShowUncharted(battleType, chapterId);
			}

			// Token: 0x0601466D RID: 83565 RVA: 0x0052FCF0 File Offset: 0x0052DEF0
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0601466E RID: 83566 RVA: 0x0052FD00 File Offset: 0x0052DF00
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x0601466F RID: 83567 RVA: 0x0052FD10 File Offset: 0x0052DF10
			public void OnDailyToggleValueChanged(bool isOn)
			{
				this.m_owner.OnDailyToggleValueChanged(isOn);
			}

			// Token: 0x06014670 RID: 83568 RVA: 0x0052FD20 File Offset: 0x0052DF20
			public void OnLimitTimeToggleValueChanged(bool isOn)
			{
				this.m_owner.OnLimitTimeToggleValueChanged(isOn);
			}

			// Token: 0x06014671 RID: 83569 RVA: 0x0052FD30 File Offset: 0x0052DF30
			public void SetLimitTimeItems()
			{
				this.m_owner.SetLimitTimeItems();
			}

			// Token: 0x06014672 RID: 83570 RVA: 0x0052FD40 File Offset: 0x0052DF40
			public void OnAnikiButtonClick()
			{
				this.m_owner.OnAnikiButtonClick();
			}

			// Token: 0x06014673 RID: 83571 RVA: 0x0052FD50 File Offset: 0x0052DF50
			public void OnThearchyButtonClick()
			{
				this.m_owner.OnThearchyButtonClick();
			}

			// Token: 0x06014674 RID: 83572 RVA: 0x0052FD60 File Offset: 0x0052DF60
			public void OnTreasureMapButtonClick()
			{
				this.m_owner.OnTreasureMapButtonClick();
			}

			// Token: 0x06014675 RID: 83573 RVA: 0x0052FD70 File Offset: 0x0052DF70
			public void OnMemoryCorridorButtonClick()
			{
				this.m_owner.OnMemoryCorridorButtonClick();
			}

			// Token: 0x06014676 RID: 83574 RVA: 0x0052FD80 File Offset: 0x0052DF80
			public void OnHeroTrainingButtonClick()
			{
				this.m_owner.OnHeroTrainingButtonClick();
			}

			// Token: 0x06014677 RID: 83575 RVA: 0x0052FD90 File Offset: 0x0052DF90
			public void OnClimbTowerButtonClick()
			{
				this.m_owner.OnClimbTowerButtonClick();
			}

			// Token: 0x06014678 RID: 83576 RVA: 0x0052FDA0 File Offset: 0x0052DFA0
			public void OnHeroPhantomButtonClick(HeroPhantomButton ctrl)
			{
				this.m_owner.OnHeroPhantomButtonClick(ctrl);
			}

			// Token: 0x06014679 RID: 83577 RVA: 0x0052FDB0 File Offset: 0x0052DFB0
			public void OnCooperateBattleButtonClick(CooperateBattleButton ctrl)
			{
				this.m_owner.OnCooperateBattleButtonClick(ctrl);
			}

			// Token: 0x0601467A RID: 83578 RVA: 0x0052FDC0 File Offset: 0x0052DFC0
			public void OnUnchartedScoreButtonClick(UnchartedScoreButton ctrl)
			{
				this.m_owner.OnUnchartedScoreButtonClick(ctrl);
			}

			// Token: 0x0400B3DC RID: 46044
			private UnchartedUIController m_owner;
		}
	}
}
