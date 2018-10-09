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
	// Token: 0x02000EC4 RID: 3780
	[HotFix]
	public class BattleLevelInfoUIController : UIControllerBase
	{
		// Token: 0x060127C0 RID: 75712 RVA: 0x004BDFCC File Offset: 0x004BC1CC
		private BattleLevelInfoUIController()
		{
		}

		// Token: 0x060127C1 RID: 75713 RVA: 0x004BDFE0 File Offset: 0x004BC1E0
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
			this.m_raidButton.onClick.AddListener(new UnityAction(this.OnRaidButtonClick));
			this.m_achievementButton.onClick.AddListener(new UnityAction(this.OnAchievementButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_achievementUIStateController.gameObject.SetActive(false);
			this.m_achievementBackgroundButton.onClick.AddListener(new UnityAction(this.OnAchievementBackgroundButtonClick));
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x060127C2 RID: 75714 RVA: 0x004BE0F0 File Offset: 0x004BC2F0
		public void SetRiftLevel(ConfigDataRiftLevelInfo riftLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRiftLevelConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_SetRiftLevelConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					riftLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (riftLevelInfo == null)
			{
				return;
			}
			this.m_nameText.text = riftLevelInfo.Name;
			this.m_nameNumberText.text = riftLevelInfo.NameNum;
			this.m_descText.text = riftLevelInfo.Desc;
			this.m_hardText.text = riftLevelInfo.MonsterLevel.ToString();
			this.m_image.sprite = AssetUtility.Instance.GetSprite(riftLevelInfo.Image);
			if (riftLevelInfo.m_battleInfo != null)
			{
				this.SetWinCondition(riftLevelInfo.m_battleInfo.WinDesc);
			}
			else
			{
				this.SetWinCondition(string.Empty);
			}
			this.m_energyText.text = riftLevelInfo.EnergySuccess.ToString();
		}

		// Token: 0x060127C3 RID: 75715 RVA: 0x004BE220 File Offset: 0x004BC420
		public void SetHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo heroDungeonLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_SetHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					heroDungeonLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroDungeonLevelInfo == null)
			{
				return;
			}
			this.m_nameText.text = heroDungeonLevelInfo.Name;
			this.m_nameNumberText.text = heroDungeonLevelInfo.NameNum;
			this.m_descText.text = heroDungeonLevelInfo.Desc;
			this.m_hardText.text = heroDungeonLevelInfo.MonsterLevel.ToString();
			this.m_image.sprite = AssetUtility.Instance.GetSprite(heroDungeonLevelInfo.Resource);
			if (heroDungeonLevelInfo.m_battleInfo != null)
			{
				this.SetWinCondition(heroDungeonLevelInfo.m_battleInfo.WinDesc);
			}
			else
			{
				this.SetWinCondition(string.Empty);
			}
			this.m_energyText.text = heroDungeonLevelInfo.EnergySuccess.ToString();
		}

		// Token: 0x060127C4 RID: 75716 RVA: 0x004BE350 File Offset: 0x004BC550
		private void SetWinCondition(string conditionStrs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWinConditionString_hotfix != null)
			{
				this.m_SetWinConditionString_hotfix.call(new object[]
				{
					this,
					conditionStrs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_winConditionGroup);
			char[] separator = new char[]
			{
				'\r',
				'\n'
			};
			string[] array = conditionStrs.Split(separator);
			foreach (string text in array)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_conditionPrefab, this.m_winConditionGroup.transform, false);
				Text component = gameObject.GetComponent<Text>();
				if (component != null)
				{
					component.text = text;
				}
			}
		}

		// Token: 0x060127C5 RID: 75717 RVA: 0x004BE43C File Offset: 0x004BC63C
		public void SetStars(int stars)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStarsInt32_hotfix != null)
			{
				this.m_SetStarsInt32_hotfix.call(new object[]
				{
					this,
					stars
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_star1GameObject.SetActive(stars >= 1);
			this.m_star2GameObject.SetActive(stars >= 2);
			this.m_star3GameObject.SetActive(stars >= 3);
		}

		// Token: 0x060127C6 RID: 75718 RVA: 0x004BE4E4 File Offset: 0x004BC6E4
		public void SetCanChallengeCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanChallengeCountInt32_hotfix != null)
			{
				this.m_SetCanChallengeCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_challengeCountText.text = count.ToString();
		}

		// Token: 0x060127C7 RID: 75719 RVA: 0x004BE56C File Offset: 0x004BC76C
		public void SetBattleTreasureCount(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleTreasureCountInt32Int32_hotfix != null)
			{
				this.m_SetBattleTreasureCountInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (countMax > 0)
			{
				this.m_treasureGameObject.SetActive(true);
				this.m_treasureCountText.text = string.Format("{0} / {1}", count, countMax);
			}
			else
			{
				this.m_treasureGameObject.SetActive(false);
			}
		}

		// Token: 0x060127C8 RID: 75720 RVA: 0x004BE634 File Offset: 0x004BC834
		public void SetAchievementCount(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAchievementCountInt32Int32_hotfix != null)
			{
				this.m_SetAchievementCountInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (countMax > 0)
			{
				this.m_achievementButton.gameObject.SetActive(true);
				this.m_achievementButtonText.text = string.Format("{0}/{1}", count, countMax);
			}
			else
			{
				this.m_achievementButton.gameObject.SetActive(false);
			}
		}

		// Token: 0x060127C9 RID: 75721 RVA: 0x004BE704 File Offset: 0x004BC904
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

		// Token: 0x060127CA RID: 75722 RVA: 0x004BE78C File Offset: 0x004BC98C
		public void SetReward(List<Goods> goodList, bool firstWin)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardList`1Boolean_hotfix != null)
			{
				this.m_SetRewardList`1Boolean_hotfix.call(new object[]
				{
					this,
					goodList,
					firstWin
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rewardTitleGameObject.SetActive(firstWin);
			this.m_rewardTitle2GameObject.SetActive(!firstWin);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			if (goodList != null)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
				RewardGoodsUIController.CreateRewardGoodsList(goodList, this.m_rewardGroupGameObject.transform, assetInContainer, null, firstWin, 0, true);
			}
		}

		// Token: 0x060127CB RID: 75723 RVA: 0x004BE85C File Offset: 0x004BCA5C
		public void ShowAchievement(BattleLevelAchievement[] achievements, BattleType battleType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAchievementBattleLevelAchievementbeBattleType_hotfix != null)
			{
				this.m_ShowAchievementBattleLevelAchievementbeBattleType_hotfix.call(new object[]
				{
					this,
					achievements,
					battleType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearAchievementItems();
			if (achievements == null || achievements.Length <= 0)
			{
				return;
			}
			UIUtility.SetUIStateOpen(this.m_achievementUIStateController, "Open", null, false, true);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("BattleAchievementItem");
			if (battleType == BattleType.Rift)
			{
				for (int i = 0; i < 2; i++)
				{
					foreach (BattleLevelAchievement battleLevelAchievement in achievements)
					{
						bool flag = projectLPlayerContext.HasRiftLevelAchievement(battleLevelAchievement.m_achievementRelatedInfo.ID);
						if (flag == (i == 1))
						{
							this.AddAchievementItem(battleLevelAchievement.m_achievementRelatedInfo.m_achievementInfo, battleLevelAchievement.m_rewards, assetInContainer, flag);
						}
					}
				}
			}
			else if (battleType == BattleType.HeroDungeon)
			{
				for (int k = 0; k < 2; k++)
				{
					foreach (BattleLevelAchievement battleLevelAchievement2 in achievements)
					{
						bool flag2 = projectLPlayerContext.HasHeroDungeonLevelAchievement(battleLevelAchievement2.m_achievementRelatedInfo.ID);
						if (flag2 == (k == 1))
						{
							this.AddAchievementItem(battleLevelAchievement2.m_achievementRelatedInfo.m_achievementInfo, battleLevelAchievement2.m_rewards, assetInContainer, flag2);
						}
					}
				}
			}
			this.m_achievementScrollRect.verticalNormalizedPosition = 1f;
		}

		// Token: 0x060127CC RID: 75724 RVA: 0x004BEA28 File Offset: 0x004BCC28
		private void AddAchievementItem(ConfigDataBattleAchievementInfo achievementInfo, List<Goods> rewards, GameObject prefab, bool complete)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix != null)
			{
				this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix.call(new object[]
				{
					this,
					achievementInfo,
					rewards,
					prefab,
					complete
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(prefab, this.m_achievementScrollRect.content, false);
			BattleAchievementItemUIController battleAchievementItemUIController = GameObjectUtility.AddControllerToGameObject<BattleAchievementItemUIController>(go);
			battleAchievementItemUIController.SetAchievement(achievementInfo);
			battleAchievementItemUIController.SetRewards(rewards);
			battleAchievementItemUIController.SetComplete(complete);
			this.m_achievementItems.Add(battleAchievementItemUIController);
		}

		// Token: 0x060127CD RID: 75725 RVA: 0x004BEB04 File Offset: 0x004BCD04
		private void ClearAchievementItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAchievementItems_hotfix != null)
			{
				this.m_ClearAchievementItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<BattleAchievementItemUIController>(this.m_achievementItems);
			this.m_achievementItems.Clear();
		}

		// Token: 0x060127CE RID: 75726 RVA: 0x004BEB7C File Offset: 0x004BCD7C
		public void SetRiftLevelShowByType(RiftLevelType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRiftLevelShowByTypeRiftLevelType_hotfix != null)
			{
				this.m_SetRiftLevelShowByTypeRiftLevelType_hotfix.call(new object[]
				{
					this,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (type == RiftLevelType.RiftLevelType_Event)
			{
				this.m_nameGameObject.SetActive(false);
				this.m_allStarsGameObject.SetActive(false);
				this.m_achievementButton.gameObject.SetActive(false);
				this.m_treasureGameObject.SetActive(false);
				this.m_raidButton.gameObject.SetActive(false);
				this.m_challengeGroupGameObject.SetActive(false);
			}
			else if (type == RiftLevelType.RiftLevelType_Scenario)
			{
				this.m_nameGameObject.SetActive(true);
				this.m_allStarsGameObject.SetActive(true);
				this.m_achievementButton.gameObject.SetActive(true);
				this.m_treasureGameObject.SetActive(true);
				this.m_raidButton.gameObject.SetActive(true);
				this.m_challengeGroupGameObject.SetActive(true);
			}
		}

		// Token: 0x060127CF RID: 75727 RVA: 0x004BECA4 File Offset: 0x004BCEA4
		public void LevelInfoOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelInfoOpenTween_hotfix != null)
			{
				this.m_LevelInfoOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", null, false, true);
		}

		// Token: 0x060127D0 RID: 75728 RVA: 0x004BED18 File Offset: 0x004BCF18
		public void EventLevelInfoOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EventLevelInfoOpenTween_hotfix != null)
			{
				this.m_EventLevelInfoOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "NoNameOpen", null, false, true);
		}

		// Token: 0x060127D1 RID: 75729 RVA: 0x004BED8C File Offset: 0x004BCF8C
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
			if (UIUtility.GetUIStateCurrentStateName(this.m_uiStateController) == "Open")
			{
				UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
				{
					if (this.EventOnClose != null)
					{
						this.EventOnClose();
					}
				}, false, true);
			}
			else if (UIUtility.GetUIStateCurrentStateName(this.m_uiStateController) == "NoNameOpen")
			{
				UIUtility.SetUIStateClose(this.m_uiStateController, "NoNameClose", delegate
				{
					if (this.EventOnClose != null)
					{
						this.EventOnClose();
					}
				}, false, true);
			}
		}

		// Token: 0x060127D2 RID: 75730 RVA: 0x004BEE64 File Offset: 0x004BD064
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
			if (this.EventOnStartBattle != null)
			{
				this.EventOnStartBattle();
			}
		}

		// Token: 0x060127D3 RID: 75731 RVA: 0x004BEEDC File Offset: 0x004BD0DC
		private void OnRaidButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRaidButtonClick_hotfix != null)
			{
				this.m_OnRaidButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRaidBattle != null)
			{
				this.EventOnRaidBattle(1);
			}
		}

		// Token: 0x060127D4 RID: 75732 RVA: 0x004BEF54 File Offset: 0x004BD154
		private void OnAchievementButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementButtonClick_hotfix != null)
			{
				this.m_OnAchievementButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowAchievement != null)
			{
				this.EventOnShowAchievement();
			}
		}

		// Token: 0x060127D5 RID: 75733 RVA: 0x004BEFCC File Offset: 0x004BD1CC
		private void OnAchievementBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementBackgroundButtonClick_hotfix != null)
			{
				this.m_OnAchievementBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_achievementUIStateController, "Close", null, false, true);
		}

		// Token: 0x140003F6 RID: 1014
		// (add) Token: 0x060127D6 RID: 75734 RVA: 0x004BF040 File Offset: 0x004BD240
		// (remove) Token: 0x060127D7 RID: 75735 RVA: 0x004BF0DC File Offset: 0x004BD2DC
		public event Action EventOnStartBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartBattleAction_hotfix != null)
				{
					this.m_add_EventOnStartBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStartBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStartBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartBattleAction_hotfix != null)
				{
					this.m_remove_EventOnStartBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStartBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStartBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003F7 RID: 1015
		// (add) Token: 0x060127D8 RID: 75736 RVA: 0x004BF178 File Offset: 0x004BD378
		// (remove) Token: 0x060127D9 RID: 75737 RVA: 0x004BF214 File Offset: 0x004BD414
		public event Action<int> EventOnRaidBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRaidBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnRaidBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRaidBattle;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRaidBattle, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRaidBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnRaidBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRaidBattle;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRaidBattle, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003F8 RID: 1016
		// (add) Token: 0x060127DA RID: 75738 RVA: 0x004BF2B0 File Offset: 0x004BD4B0
		// (remove) Token: 0x060127DB RID: 75739 RVA: 0x004BF34C File Offset: 0x004BD54C
		public event Action EventOnShowAchievement
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowAchievementAction_hotfix != null)
				{
					this.m_add_EventOnShowAchievementAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowAchievement;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowAchievement, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowAchievementAction_hotfix != null)
				{
					this.m_remove_EventOnShowAchievementAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowAchievement;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowAchievement, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003F9 RID: 1017
		// (add) Token: 0x060127DC RID: 75740 RVA: 0x004BF3E8 File Offset: 0x004BD5E8
		// (remove) Token: 0x060127DD RID: 75741 RVA: 0x004BF484 File Offset: 0x004BD684
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

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x060127DE RID: 75742 RVA: 0x004BF520 File Offset: 0x004BD720
		// (set) Token: 0x060127DF RID: 75743 RVA: 0x004BF540 File Offset: 0x004BD740
		[DoNotToLua]
		public new BattleLevelInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleLevelInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060127E0 RID: 75744 RVA: 0x004BF54C File Offset: 0x004BD74C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060127E1 RID: 75745 RVA: 0x004BF558 File Offset: 0x004BD758
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060127E2 RID: 75746 RVA: 0x004BF560 File Offset: 0x004BD760
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060127E3 RID: 75747 RVA: 0x004BF568 File Offset: 0x004BD768
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060127E4 RID: 75748 RVA: 0x004BF57C File Offset: 0x004BD77C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060127E5 RID: 75749 RVA: 0x004BF584 File Offset: 0x004BD784
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060127E6 RID: 75750 RVA: 0x004BF590 File Offset: 0x004BD790
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060127E7 RID: 75751 RVA: 0x004BF59C File Offset: 0x004BD79C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060127E8 RID: 75752 RVA: 0x004BF5A8 File Offset: 0x004BD7A8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060127E9 RID: 75753 RVA: 0x004BF5B4 File Offset: 0x004BD7B4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060127EA RID: 75754 RVA: 0x004BF5C0 File Offset: 0x004BD7C0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060127EB RID: 75755 RVA: 0x004BF5CC File Offset: 0x004BD7CC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060127EC RID: 75756 RVA: 0x004BF5D8 File Offset: 0x004BD7D8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060127ED RID: 75757 RVA: 0x004BF5E4 File Offset: 0x004BD7E4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060127EE RID: 75758 RVA: 0x004BF5F0 File Offset: 0x004BD7F0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060127EF RID: 75759 RVA: 0x004BF5F8 File Offset: 0x004BD7F8
		private void __callDele_EventOnStartBattle()
		{
			Action eventOnStartBattle = this.EventOnStartBattle;
			if (eventOnStartBattle != null)
			{
				eventOnStartBattle();
			}
		}

		// Token: 0x060127F0 RID: 75760 RVA: 0x004BF618 File Offset: 0x004BD818
		private void __clearDele_EventOnStartBattle()
		{
			this.EventOnStartBattle = null;
		}

		// Token: 0x060127F1 RID: 75761 RVA: 0x004BF624 File Offset: 0x004BD824
		private void __callDele_EventOnRaidBattle(int obj)
		{
			Action<int> eventOnRaidBattle = this.EventOnRaidBattle;
			if (eventOnRaidBattle != null)
			{
				eventOnRaidBattle(obj);
			}
		}

		// Token: 0x060127F2 RID: 75762 RVA: 0x004BF648 File Offset: 0x004BD848
		private void __clearDele_EventOnRaidBattle(int obj)
		{
			this.EventOnRaidBattle = null;
		}

		// Token: 0x060127F3 RID: 75763 RVA: 0x004BF654 File Offset: 0x004BD854
		private void __callDele_EventOnShowAchievement()
		{
			Action eventOnShowAchievement = this.EventOnShowAchievement;
			if (eventOnShowAchievement != null)
			{
				eventOnShowAchievement();
			}
		}

		// Token: 0x060127F4 RID: 75764 RVA: 0x004BF674 File Offset: 0x004BD874
		private void __clearDele_EventOnShowAchievement()
		{
			this.EventOnShowAchievement = null;
		}

		// Token: 0x060127F5 RID: 75765 RVA: 0x004BF680 File Offset: 0x004BD880
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x060127F6 RID: 75766 RVA: 0x004BF6A0 File Offset: 0x004BD8A0
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x060127F9 RID: 75769 RVA: 0x004BF6DC File Offset: 0x004BD8DC
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
					this.m_SetRiftLevelConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("SetRiftLevel") as LuaFunction);
					this.m_SetHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("SetHeroDungeonLevel") as LuaFunction);
					this.m_SetWinConditionString_hotfix = (luaObj.RawGet("SetWinCondition") as LuaFunction);
					this.m_SetStarsInt32_hotfix = (luaObj.RawGet("SetStars") as LuaFunction);
					this.m_SetCanChallengeCountInt32_hotfix = (luaObj.RawGet("SetCanChallengeCount") as LuaFunction);
					this.m_SetBattleTreasureCountInt32Int32_hotfix = (luaObj.RawGet("SetBattleTreasureCount") as LuaFunction);
					this.m_SetAchievementCountInt32Int32_hotfix = (luaObj.RawGet("SetAchievementCount") as LuaFunction);
					this.m_SetRaidTicketCountInt32_hotfix = (luaObj.RawGet("SetRaidTicketCount") as LuaFunction);
					this.m_SetRewardList`1Boolean_hotfix = (luaObj.RawGet("SetReward") as LuaFunction);
					this.m_ShowAchievementBattleLevelAchievementbeBattleType_hotfix = (luaObj.RawGet("ShowAchievement") as LuaFunction);
					this.m_AddAchievementItemConfigDataBattleAchievementInfoList`1GameObjectBoolean_hotfix = (luaObj.RawGet("AddAchievementItem") as LuaFunction);
					this.m_ClearAchievementItems_hotfix = (luaObj.RawGet("ClearAchievementItems") as LuaFunction);
					this.m_SetRiftLevelShowByTypeRiftLevelType_hotfix = (luaObj.RawGet("SetRiftLevelShowByType") as LuaFunction);
					this.m_LevelInfoOpenTween_hotfix = (luaObj.RawGet("LevelInfoOpenTween") as LuaFunction);
					this.m_EventLevelInfoOpenTween_hotfix = (luaObj.RawGet("EventLevelInfoOpenTween") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnRaidButtonClick_hotfix = (luaObj.RawGet("OnRaidButtonClick") as LuaFunction);
					this.m_OnAchievementButtonClick_hotfix = (luaObj.RawGet("OnAchievementButtonClick") as LuaFunction);
					this.m_OnAchievementBackgroundButtonClick_hotfix = (luaObj.RawGet("OnAchievementBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnStartBattleAction_hotfix = (luaObj.RawGet("add_EventOnStartBattle") as LuaFunction);
					this.m_remove_EventOnStartBattleAction_hotfix = (luaObj.RawGet("remove_EventOnStartBattle") as LuaFunction);
					this.m_add_EventOnRaidBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnRaidBattle") as LuaFunction);
					this.m_remove_EventOnRaidBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnRaidBattle") as LuaFunction);
					this.m_add_EventOnShowAchievementAction_hotfix = (luaObj.RawGet("add_EventOnShowAchievement") as LuaFunction);
					this.m_remove_EventOnShowAchievementAction_hotfix = (luaObj.RawGet("remove_EventOnShowAchievement") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060127FA RID: 75770 RVA: 0x004BFA64 File Offset: 0x004BDC64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleLevelInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A632 RID: 42546
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A633 RID: 42547
		[AutoBind("./Name", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_nameGameObject;

		// Token: 0x0400A634 RID: 42548
		[AutoBind("./Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400A635 RID: 42549
		[AutoBind("./Name/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameNumberText;

		// Token: 0x0400A636 RID: 42550
		[AutoBind("./Panel/Desc/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x0400A637 RID: 42551
		[AutoBind("./Panel/Hard/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_hardText;

		// Token: 0x0400A638 RID: 42552
		[AutoBind("./Panel/WinCondition/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_winConditionGroup;

		// Token: 0x0400A639 RID: 42553
		[AutoBind("./Panel/HiddenChest", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_treasureGameObject;

		// Token: 0x0400A63A RID: 42554
		[AutoBind("./Panel/HiddenChest/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_treasureCountText;

		// Token: 0x0400A63B RID: 42555
		[AutoBind("./Panel/Stars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allStarsGameObject;

		// Token: 0x0400A63C RID: 42556
		[AutoBind("./Panel/Stars/1/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star1GameObject;

		// Token: 0x0400A63D RID: 42557
		[AutoBind("./Panel/Stars/2/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star2GameObject;

		// Token: 0x0400A63E RID: 42558
		[AutoBind("./Panel/Stars/3/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star3GameObject;

		// Token: 0x0400A63F RID: 42559
		[AutoBind("./Panel/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400A640 RID: 42560
		[AutoBind("./Panel/RewardTitleImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardTitleGameObject;

		// Token: 0x0400A641 RID: 42561
		[AutoBind("./Panel/RewardTitleImage2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardTitle2GameObject;

		// Token: 0x0400A642 RID: 42562
		[AutoBind("./Panel/Reward/RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x0400A643 RID: 42563
		[AutoBind("./Panel/ChallengeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_challengeGroupGameObject;

		// Token: 0x0400A644 RID: 42564
		[AutoBind("./Panel/ChallengeGroup/ChallengeCount/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_challengeCountText;

		// Token: 0x0400A645 RID: 42565
		[AutoBind("./Panel/AchievementButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_achievementButton;

		// Token: 0x0400A646 RID: 42566
		[AutoBind("./Panel/AchievementButton/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementButtonText;

		// Token: 0x0400A647 RID: 42567
		[AutoBind("./Panel/StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400A648 RID: 42568
		[AutoBind("./Panel/StartButton/EnergyText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400A649 RID: 42569
		[AutoBind("./Panel/RaidTicketGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_raidTicketText;

		// Token: 0x0400A64A RID: 42570
		[AutoBind("./Panel/RaidButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_raidButton;

		// Token: 0x0400A64B RID: 42571
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400A64C RID: 42572
		[AutoBind("./Achievement", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_achievementUIStateController;

		// Token: 0x0400A64D RID: 42573
		[AutoBind("./Achievement/Panel/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_achievementScrollRect;

		// Token: 0x0400A64E RID: 42574
		[AutoBind("./Achievement/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_achievementBackgroundButton;

		// Token: 0x0400A64F RID: 42575
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400A650 RID: 42576
		[AutoBind("./Prefabs/ConditionText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_conditionPrefab;

		// Token: 0x0400A651 RID: 42577
		private List<BattleAchievementItemUIController> m_achievementItems = new List<BattleAchievementItemUIController>();

		// Token: 0x0400A652 RID: 42578
		[DoNotToLua]
		private BattleLevelInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A653 RID: 42579
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A654 RID: 42580
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A655 RID: 42581
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A656 RID: 42582
		private LuaFunction m_SetRiftLevelConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400A657 RID: 42583
		private LuaFunction m_SetHeroDungeonLevelConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x0400A658 RID: 42584
		private LuaFunction m_SetWinConditionString_hotfix;

		// Token: 0x0400A659 RID: 42585
		private LuaFunction m_SetStarsInt32_hotfix;

		// Token: 0x0400A65A RID: 42586
		private LuaFunction m_SetCanChallengeCountInt32_hotfix;

		// Token: 0x0400A65B RID: 42587
		private LuaFunction m_SetBattleTreasureCountInt32Int32_hotfix;

		// Token: 0x0400A65C RID: 42588
		private LuaFunction m_SetAchievementCountInt32Int32_hotfix;

		// Token: 0x0400A65D RID: 42589
		private LuaFunction m_SetRaidTicketCountInt32_hotfix;

		// Token: 0x0400A65E RID: 42590
		private LuaFunction m_SetRewardList;

		// Token: 0x0400A65F RID: 42591
		private LuaFunction m_ShowAchievementBattleLevelAchievementbeBattleType_hotfix;

		// Token: 0x0400A660 RID: 42592
		private LuaFunction m_AddAchievementItemConfigDataBattleAchievementInfoList;

		// Token: 0x0400A661 RID: 42593
		private LuaFunction m_ClearAchievementItems_hotfix;

		// Token: 0x0400A662 RID: 42594
		private LuaFunction m_SetRiftLevelShowByTypeRiftLevelType_hotfix;

		// Token: 0x0400A663 RID: 42595
		private LuaFunction m_LevelInfoOpenTween_hotfix;

		// Token: 0x0400A664 RID: 42596
		private LuaFunction m_EventLevelInfoOpenTween_hotfix;

		// Token: 0x0400A665 RID: 42597
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400A666 RID: 42598
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400A667 RID: 42599
		private LuaFunction m_OnRaidButtonClick_hotfix;

		// Token: 0x0400A668 RID: 42600
		private LuaFunction m_OnAchievementButtonClick_hotfix;

		// Token: 0x0400A669 RID: 42601
		private LuaFunction m_OnAchievementBackgroundButtonClick_hotfix;

		// Token: 0x0400A66A RID: 42602
		private LuaFunction m_add_EventOnStartBattleAction_hotfix;

		// Token: 0x0400A66B RID: 42603
		private LuaFunction m_remove_EventOnStartBattleAction_hotfix;

		// Token: 0x0400A66C RID: 42604
		private LuaFunction m_add_EventOnRaidBattleAction;

		// Token: 0x0400A66D RID: 42605
		private LuaFunction m_remove_EventOnRaidBattleAction;

		// Token: 0x0400A66E RID: 42606
		private LuaFunction m_add_EventOnShowAchievementAction_hotfix;

		// Token: 0x0400A66F RID: 42607
		private LuaFunction m_remove_EventOnShowAchievementAction_hotfix;

		// Token: 0x0400A670 RID: 42608
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A671 RID: 42609
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000EC5 RID: 3781
		public new class LuaExportHelper
		{
			// Token: 0x060127FB RID: 75771 RVA: 0x004BFACC File Offset: 0x004BDCCC
			public LuaExportHelper(BattleLevelInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060127FC RID: 75772 RVA: 0x004BFADC File Offset: 0x004BDCDC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060127FD RID: 75773 RVA: 0x004BFAEC File Offset: 0x004BDCEC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060127FE RID: 75774 RVA: 0x004BFAFC File Offset: 0x004BDCFC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060127FF RID: 75775 RVA: 0x004BFB0C File Offset: 0x004BDD0C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012800 RID: 75776 RVA: 0x004BFB24 File Offset: 0x004BDD24
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012801 RID: 75777 RVA: 0x004BFB34 File Offset: 0x004BDD34
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012802 RID: 75778 RVA: 0x004BFB44 File Offset: 0x004BDD44
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012803 RID: 75779 RVA: 0x004BFB54 File Offset: 0x004BDD54
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012804 RID: 75780 RVA: 0x004BFB64 File Offset: 0x004BDD64
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012805 RID: 75781 RVA: 0x004BFB74 File Offset: 0x004BDD74
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012806 RID: 75782 RVA: 0x004BFB84 File Offset: 0x004BDD84
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012807 RID: 75783 RVA: 0x004BFB94 File Offset: 0x004BDD94
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012808 RID: 75784 RVA: 0x004BFBA4 File Offset: 0x004BDDA4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012809 RID: 75785 RVA: 0x004BFBB4 File Offset: 0x004BDDB4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601280A RID: 75786 RVA: 0x004BFBC4 File Offset: 0x004BDDC4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601280B RID: 75787 RVA: 0x004BFBD4 File Offset: 0x004BDDD4
			public void __callDele_EventOnStartBattle()
			{
				this.m_owner.__callDele_EventOnStartBattle();
			}

			// Token: 0x0601280C RID: 75788 RVA: 0x004BFBE4 File Offset: 0x004BDDE4
			public void __clearDele_EventOnStartBattle()
			{
				this.m_owner.__clearDele_EventOnStartBattle();
			}

			// Token: 0x0601280D RID: 75789 RVA: 0x004BFBF4 File Offset: 0x004BDDF4
			public void __callDele_EventOnRaidBattle(int obj)
			{
				this.m_owner.__callDele_EventOnRaidBattle(obj);
			}

			// Token: 0x0601280E RID: 75790 RVA: 0x004BFC04 File Offset: 0x004BDE04
			public void __clearDele_EventOnRaidBattle(int obj)
			{
				this.m_owner.__clearDele_EventOnRaidBattle(obj);
			}

			// Token: 0x0601280F RID: 75791 RVA: 0x004BFC14 File Offset: 0x004BDE14
			public void __callDele_EventOnShowAchievement()
			{
				this.m_owner.__callDele_EventOnShowAchievement();
			}

			// Token: 0x06012810 RID: 75792 RVA: 0x004BFC24 File Offset: 0x004BDE24
			public void __clearDele_EventOnShowAchievement()
			{
				this.m_owner.__clearDele_EventOnShowAchievement();
			}

			// Token: 0x06012811 RID: 75793 RVA: 0x004BFC34 File Offset: 0x004BDE34
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06012812 RID: 75794 RVA: 0x004BFC44 File Offset: 0x004BDE44
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170037E5 RID: 14309
			// (get) Token: 0x06012813 RID: 75795 RVA: 0x004BFC54 File Offset: 0x004BDE54
			// (set) Token: 0x06012814 RID: 75796 RVA: 0x004BFC64 File Offset: 0x004BDE64
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

			// Token: 0x170037E6 RID: 14310
			// (get) Token: 0x06012815 RID: 75797 RVA: 0x004BFC74 File Offset: 0x004BDE74
			// (set) Token: 0x06012816 RID: 75798 RVA: 0x004BFC84 File Offset: 0x004BDE84
			public GameObject m_nameGameObject
			{
				get
				{
					return this.m_owner.m_nameGameObject;
				}
				set
				{
					this.m_owner.m_nameGameObject = value;
				}
			}

			// Token: 0x170037E7 RID: 14311
			// (get) Token: 0x06012817 RID: 75799 RVA: 0x004BFC94 File Offset: 0x004BDE94
			// (set) Token: 0x06012818 RID: 75800 RVA: 0x004BFCA4 File Offset: 0x004BDEA4
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x170037E8 RID: 14312
			// (get) Token: 0x06012819 RID: 75801 RVA: 0x004BFCB4 File Offset: 0x004BDEB4
			// (set) Token: 0x0601281A RID: 75802 RVA: 0x004BFCC4 File Offset: 0x004BDEC4
			public Text m_nameNumberText
			{
				get
				{
					return this.m_owner.m_nameNumberText;
				}
				set
				{
					this.m_owner.m_nameNumberText = value;
				}
			}

			// Token: 0x170037E9 RID: 14313
			// (get) Token: 0x0601281B RID: 75803 RVA: 0x004BFCD4 File Offset: 0x004BDED4
			// (set) Token: 0x0601281C RID: 75804 RVA: 0x004BFCE4 File Offset: 0x004BDEE4
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x170037EA RID: 14314
			// (get) Token: 0x0601281D RID: 75805 RVA: 0x004BFCF4 File Offset: 0x004BDEF4
			// (set) Token: 0x0601281E RID: 75806 RVA: 0x004BFD04 File Offset: 0x004BDF04
			public Text m_hardText
			{
				get
				{
					return this.m_owner.m_hardText;
				}
				set
				{
					this.m_owner.m_hardText = value;
				}
			}

			// Token: 0x170037EB RID: 14315
			// (get) Token: 0x0601281F RID: 75807 RVA: 0x004BFD14 File Offset: 0x004BDF14
			// (set) Token: 0x06012820 RID: 75808 RVA: 0x004BFD24 File Offset: 0x004BDF24
			public GameObject m_winConditionGroup
			{
				get
				{
					return this.m_owner.m_winConditionGroup;
				}
				set
				{
					this.m_owner.m_winConditionGroup = value;
				}
			}

			// Token: 0x170037EC RID: 14316
			// (get) Token: 0x06012821 RID: 75809 RVA: 0x004BFD34 File Offset: 0x004BDF34
			// (set) Token: 0x06012822 RID: 75810 RVA: 0x004BFD44 File Offset: 0x004BDF44
			public GameObject m_treasureGameObject
			{
				get
				{
					return this.m_owner.m_treasureGameObject;
				}
				set
				{
					this.m_owner.m_treasureGameObject = value;
				}
			}

			// Token: 0x170037ED RID: 14317
			// (get) Token: 0x06012823 RID: 75811 RVA: 0x004BFD54 File Offset: 0x004BDF54
			// (set) Token: 0x06012824 RID: 75812 RVA: 0x004BFD64 File Offset: 0x004BDF64
			public Text m_treasureCountText
			{
				get
				{
					return this.m_owner.m_treasureCountText;
				}
				set
				{
					this.m_owner.m_treasureCountText = value;
				}
			}

			// Token: 0x170037EE RID: 14318
			// (get) Token: 0x06012825 RID: 75813 RVA: 0x004BFD74 File Offset: 0x004BDF74
			// (set) Token: 0x06012826 RID: 75814 RVA: 0x004BFD84 File Offset: 0x004BDF84
			public GameObject m_allStarsGameObject
			{
				get
				{
					return this.m_owner.m_allStarsGameObject;
				}
				set
				{
					this.m_owner.m_allStarsGameObject = value;
				}
			}

			// Token: 0x170037EF RID: 14319
			// (get) Token: 0x06012827 RID: 75815 RVA: 0x004BFD94 File Offset: 0x004BDF94
			// (set) Token: 0x06012828 RID: 75816 RVA: 0x004BFDA4 File Offset: 0x004BDFA4
			public GameObject m_star1GameObject
			{
				get
				{
					return this.m_owner.m_star1GameObject;
				}
				set
				{
					this.m_owner.m_star1GameObject = value;
				}
			}

			// Token: 0x170037F0 RID: 14320
			// (get) Token: 0x06012829 RID: 75817 RVA: 0x004BFDB4 File Offset: 0x004BDFB4
			// (set) Token: 0x0601282A RID: 75818 RVA: 0x004BFDC4 File Offset: 0x004BDFC4
			public GameObject m_star2GameObject
			{
				get
				{
					return this.m_owner.m_star2GameObject;
				}
				set
				{
					this.m_owner.m_star2GameObject = value;
				}
			}

			// Token: 0x170037F1 RID: 14321
			// (get) Token: 0x0601282B RID: 75819 RVA: 0x004BFDD4 File Offset: 0x004BDFD4
			// (set) Token: 0x0601282C RID: 75820 RVA: 0x004BFDE4 File Offset: 0x004BDFE4
			public GameObject m_star3GameObject
			{
				get
				{
					return this.m_owner.m_star3GameObject;
				}
				set
				{
					this.m_owner.m_star3GameObject = value;
				}
			}

			// Token: 0x170037F2 RID: 14322
			// (get) Token: 0x0601282D RID: 75821 RVA: 0x004BFDF4 File Offset: 0x004BDFF4
			// (set) Token: 0x0601282E RID: 75822 RVA: 0x004BFE04 File Offset: 0x004BE004
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x170037F3 RID: 14323
			// (get) Token: 0x0601282F RID: 75823 RVA: 0x004BFE14 File Offset: 0x004BE014
			// (set) Token: 0x06012830 RID: 75824 RVA: 0x004BFE24 File Offset: 0x004BE024
			public GameObject m_rewardTitleGameObject
			{
				get
				{
					return this.m_owner.m_rewardTitleGameObject;
				}
				set
				{
					this.m_owner.m_rewardTitleGameObject = value;
				}
			}

			// Token: 0x170037F4 RID: 14324
			// (get) Token: 0x06012831 RID: 75825 RVA: 0x004BFE34 File Offset: 0x004BE034
			// (set) Token: 0x06012832 RID: 75826 RVA: 0x004BFE44 File Offset: 0x004BE044
			public GameObject m_rewardTitle2GameObject
			{
				get
				{
					return this.m_owner.m_rewardTitle2GameObject;
				}
				set
				{
					this.m_owner.m_rewardTitle2GameObject = value;
				}
			}

			// Token: 0x170037F5 RID: 14325
			// (get) Token: 0x06012833 RID: 75827 RVA: 0x004BFE54 File Offset: 0x004BE054
			// (set) Token: 0x06012834 RID: 75828 RVA: 0x004BFE64 File Offset: 0x004BE064
			public GameObject m_rewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGroupGameObject = value;
				}
			}

			// Token: 0x170037F6 RID: 14326
			// (get) Token: 0x06012835 RID: 75829 RVA: 0x004BFE74 File Offset: 0x004BE074
			// (set) Token: 0x06012836 RID: 75830 RVA: 0x004BFE84 File Offset: 0x004BE084
			public GameObject m_challengeGroupGameObject
			{
				get
				{
					return this.m_owner.m_challengeGroupGameObject;
				}
				set
				{
					this.m_owner.m_challengeGroupGameObject = value;
				}
			}

			// Token: 0x170037F7 RID: 14327
			// (get) Token: 0x06012837 RID: 75831 RVA: 0x004BFE94 File Offset: 0x004BE094
			// (set) Token: 0x06012838 RID: 75832 RVA: 0x004BFEA4 File Offset: 0x004BE0A4
			public Text m_challengeCountText
			{
				get
				{
					return this.m_owner.m_challengeCountText;
				}
				set
				{
					this.m_owner.m_challengeCountText = value;
				}
			}

			// Token: 0x170037F8 RID: 14328
			// (get) Token: 0x06012839 RID: 75833 RVA: 0x004BFEB4 File Offset: 0x004BE0B4
			// (set) Token: 0x0601283A RID: 75834 RVA: 0x004BFEC4 File Offset: 0x004BE0C4
			public Button m_achievementButton
			{
				get
				{
					return this.m_owner.m_achievementButton;
				}
				set
				{
					this.m_owner.m_achievementButton = value;
				}
			}

			// Token: 0x170037F9 RID: 14329
			// (get) Token: 0x0601283B RID: 75835 RVA: 0x004BFED4 File Offset: 0x004BE0D4
			// (set) Token: 0x0601283C RID: 75836 RVA: 0x004BFEE4 File Offset: 0x004BE0E4
			public Text m_achievementButtonText
			{
				get
				{
					return this.m_owner.m_achievementButtonText;
				}
				set
				{
					this.m_owner.m_achievementButtonText = value;
				}
			}

			// Token: 0x170037FA RID: 14330
			// (get) Token: 0x0601283D RID: 75837 RVA: 0x004BFEF4 File Offset: 0x004BE0F4
			// (set) Token: 0x0601283E RID: 75838 RVA: 0x004BFF04 File Offset: 0x004BE104
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

			// Token: 0x170037FB RID: 14331
			// (get) Token: 0x0601283F RID: 75839 RVA: 0x004BFF14 File Offset: 0x004BE114
			// (set) Token: 0x06012840 RID: 75840 RVA: 0x004BFF24 File Offset: 0x004BE124
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x170037FC RID: 14332
			// (get) Token: 0x06012841 RID: 75841 RVA: 0x004BFF34 File Offset: 0x004BE134
			// (set) Token: 0x06012842 RID: 75842 RVA: 0x004BFF44 File Offset: 0x004BE144
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

			// Token: 0x170037FD RID: 14333
			// (get) Token: 0x06012843 RID: 75843 RVA: 0x004BFF54 File Offset: 0x004BE154
			// (set) Token: 0x06012844 RID: 75844 RVA: 0x004BFF64 File Offset: 0x004BE164
			public Button m_raidButton
			{
				get
				{
					return this.m_owner.m_raidButton;
				}
				set
				{
					this.m_owner.m_raidButton = value;
				}
			}

			// Token: 0x170037FE RID: 14334
			// (get) Token: 0x06012845 RID: 75845 RVA: 0x004BFF74 File Offset: 0x004BE174
			// (set) Token: 0x06012846 RID: 75846 RVA: 0x004BFF84 File Offset: 0x004BE184
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

			// Token: 0x170037FF RID: 14335
			// (get) Token: 0x06012847 RID: 75847 RVA: 0x004BFF94 File Offset: 0x004BE194
			// (set) Token: 0x06012848 RID: 75848 RVA: 0x004BFFA4 File Offset: 0x004BE1A4
			public CommonUIStateController m_achievementUIStateController
			{
				get
				{
					return this.m_owner.m_achievementUIStateController;
				}
				set
				{
					this.m_owner.m_achievementUIStateController = value;
				}
			}

			// Token: 0x17003800 RID: 14336
			// (get) Token: 0x06012849 RID: 75849 RVA: 0x004BFFB4 File Offset: 0x004BE1B4
			// (set) Token: 0x0601284A RID: 75850 RVA: 0x004BFFC4 File Offset: 0x004BE1C4
			public ScrollRect m_achievementScrollRect
			{
				get
				{
					return this.m_owner.m_achievementScrollRect;
				}
				set
				{
					this.m_owner.m_achievementScrollRect = value;
				}
			}

			// Token: 0x17003801 RID: 14337
			// (get) Token: 0x0601284B RID: 75851 RVA: 0x004BFFD4 File Offset: 0x004BE1D4
			// (set) Token: 0x0601284C RID: 75852 RVA: 0x004BFFE4 File Offset: 0x004BE1E4
			public Button m_achievementBackgroundButton
			{
				get
				{
					return this.m_owner.m_achievementBackgroundButton;
				}
				set
				{
					this.m_owner.m_achievementBackgroundButton = value;
				}
			}

			// Token: 0x17003802 RID: 14338
			// (get) Token: 0x0601284D RID: 75853 RVA: 0x004BFFF4 File Offset: 0x004BE1F4
			// (set) Token: 0x0601284E RID: 75854 RVA: 0x004C0004 File Offset: 0x004BE204
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17003803 RID: 14339
			// (get) Token: 0x0601284F RID: 75855 RVA: 0x004C0014 File Offset: 0x004BE214
			// (set) Token: 0x06012850 RID: 75856 RVA: 0x004C0024 File Offset: 0x004BE224
			public GameObject m_conditionPrefab
			{
				get
				{
					return this.m_owner.m_conditionPrefab;
				}
				set
				{
					this.m_owner.m_conditionPrefab = value;
				}
			}

			// Token: 0x17003804 RID: 14340
			// (get) Token: 0x06012851 RID: 75857 RVA: 0x004C0034 File Offset: 0x004BE234
			// (set) Token: 0x06012852 RID: 75858 RVA: 0x004C0044 File Offset: 0x004BE244
			public List<BattleAchievementItemUIController> m_achievementItems
			{
				get
				{
					return this.m_owner.m_achievementItems;
				}
				set
				{
					this.m_owner.m_achievementItems = value;
				}
			}

			// Token: 0x06012853 RID: 75859 RVA: 0x004C0054 File Offset: 0x004BE254
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012854 RID: 75860 RVA: 0x004C0064 File Offset: 0x004BE264
			public void SetWinCondition(string conditionStrs)
			{
				this.m_owner.SetWinCondition(conditionStrs);
			}

			// Token: 0x06012855 RID: 75861 RVA: 0x004C0074 File Offset: 0x004BE274
			public void AddAchievementItem(ConfigDataBattleAchievementInfo achievementInfo, List<Goods> rewards, GameObject prefab, bool complete)
			{
				this.m_owner.AddAchievementItem(achievementInfo, rewards, prefab, complete);
			}

			// Token: 0x06012856 RID: 75862 RVA: 0x004C0088 File Offset: 0x004BE288
			public void ClearAchievementItems()
			{
				this.m_owner.ClearAchievementItems();
			}

			// Token: 0x06012857 RID: 75863 RVA: 0x004C0098 File Offset: 0x004BE298
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x06012858 RID: 75864 RVA: 0x004C00A8 File Offset: 0x004BE2A8
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x06012859 RID: 75865 RVA: 0x004C00B8 File Offset: 0x004BE2B8
			public void OnRaidButtonClick()
			{
				this.m_owner.OnRaidButtonClick();
			}

			// Token: 0x0601285A RID: 75866 RVA: 0x004C00C8 File Offset: 0x004BE2C8
			public void OnAchievementButtonClick()
			{
				this.m_owner.OnAchievementButtonClick();
			}

			// Token: 0x0601285B RID: 75867 RVA: 0x004C00D8 File Offset: 0x004BE2D8
			public void OnAchievementBackgroundButtonClick()
			{
				this.m_owner.OnAchievementBackgroundButtonClick();
			}

			// Token: 0x0400A672 RID: 42610
			private BattleLevelInfoUIController m_owner;
		}
	}
}
