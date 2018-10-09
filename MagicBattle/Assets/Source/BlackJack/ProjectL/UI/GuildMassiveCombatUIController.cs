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
	// Token: 0x02000D1A RID: 3354
	[HotFix]
	public class GuildMassiveCombatUIController : UIControllerBase
	{
		// Token: 0x0600F6A6 RID: 63142 RVA: 0x004136F4 File Offset: 0x004118F4
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_rankingButton.onClick.AddListener(new UnityAction(this.OnRankingButtonClick));
			this.m_rewardsButton.onClick.AddListener(new UnityAction(this.OnRewardsButtonClick));
			this.m_giveUpButton.onClick.AddListener(new UnityAction(this.OnGiveUpButtonClick));
			this.m_questInfoPanelBackBGButton.onClick.AddListener(new UnityAction(this.OnQuestInfoPanelBackBgButtonClick));
			this.m_questInfoPanelTeamButton.onClick.AddListener(new UnityAction(this.OnQuestInfoPanelTeamButtonClick));
			this.m_questInfoPanelPersonalButton.onClick.AddListener(new UnityAction(this.OnQuestInfoPanelPersonalButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600F6A7 RID: 63143 RVA: 0x00413854 File Offset: 0x00411A54
		private void LateUpdate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LateUpdate_hotfix != null)
			{
				this.m_LateUpdate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_strongHoldsCtrlList == null)
			{
				return;
			}
			foreach (GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController in this.m_strongHoldsCtrlList)
			{
				if (guildMassiveCombatStrongHoldUIController != null)
				{
					guildMassiveCombatStrongHoldUIController.SetSuppressText();
				}
			}
		}

		// Token: 0x0600F6A8 RID: 63144 RVA: 0x0041391C File Offset: 0x00411B1C
		public void GuildMassiveCombatUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildMassiveCombatUpdateView_hotfix != null)
			{
				this.m_GuildMassiveCombatUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Guild guildInfo = this.m_playerContext.GetGuildInfo();
			if (guildInfo.MassiveCombat.RecentCombat == null)
			{
				global::Debug.Log("In Function :GuildMassiveCombatUpdateView , RecentCombat is Null");
				return;
			}
			this.m_curCombatInfo = guildInfo.MassiveCombat.RecentCombat;
			this.m_difficultLevelStateCtrl.SetToUIState("DiLV" + this.m_curCombatInfo.Difficulty, false, true);
			this.m_guildCoinText.text = this.m_playerContext.GetGuildMedal().ToString();
			this.m_guildIntegralText.text = "0";
			this.UpdateStrongHolds();
		}

		// Token: 0x0600F6A9 RID: 63145 RVA: 0x00413A18 File Offset: 0x00411C18
		private void UpdateStrongHolds()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStrongHolds_hotfix != null)
			{
				this.m_UpdateStrongHolds_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_strongHoldsCtrlList = new List<GuildMassiveCombatStrongHoldUIController>();
			List<GuildMassiveCombatStronghold> list = new List<GuildMassiveCombatStronghold>(this.m_curCombatInfo.Strongholds);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_questPanelGo, list.Count);
			Transform transform = this.m_questPanelGo.transform;
			for (int i = 0; i < list.Count; i++)
			{
				Transform child = transform.GetChild(i);
				GuildMassiveCombatStrongHoldUIController guildMassiveCombatStrongHoldUIController = child.GetComponent<GuildMassiveCombatStrongHoldUIController>();
				if (guildMassiveCombatStrongHoldUIController == null)
				{
					guildMassiveCombatStrongHoldUIController = GameObjectUtility.AddControllerToGameObject<GuildMassiveCombatStrongHoldUIController>(child.gameObject);
					guildMassiveCombatStrongHoldUIController.EventOnClick += this.OnGuildMassiveCombatStrongHoldClick;
				}
				guildMassiveCombatStrongHoldUIController.InitGuildMassiveCombatStrongHoldInfo(list[i]);
				this.m_strongHoldsCtrlList.Add(guildMassiveCombatStrongHoldUIController);
			}
		}

		// Token: 0x0600F6AA RID: 63146 RVA: 0x00413B20 File Offset: 0x00411D20
		private void OnGuildMassiveCombatStrongHoldClick(GuildMassiveCombatStrongHoldUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildMassiveCombatStrongHoldClickGuildMassiveCombatStrongHoldUIController_hotfix != null)
			{
				this.m_OnGuildMassiveCombatStrongHoldClickGuildMassiveCombatStrongHoldUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curSelectStrongHold = ctrl.m_strongHold;
			int guildMassiveCombatStrongholdEliminateRate = this.m_playerContext.GetGuildMassiveCombatStrongholdEliminateRate(this.m_curSelectStrongHold);
			if (guildMassiveCombatStrongholdEliminateRate == 100)
			{
				string txt = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_GuildMassiveCombatStrongHoldComplete);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				return;
			}
			this.SetQuestInfoPanel(ctrl.m_strongHold);
			UIUtility.SetUIStateOpen(this.m_questInfoPanelStateCtrl, "Show", null, true, true);
		}

		// Token: 0x0600F6AB RID: 63147 RVA: 0x00413BFC File Offset: 0x00411DFC
		private void SetQuestInfoPanel(GuildMassiveCombatStronghold strongHold)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetQuestInfoPanelGuildMassiveCombatStronghold_hotfix != null)
			{
				this.m_SetQuestInfoPanelGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					strongHold
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGuildMassiveCombatStrongholdInfo configDataGuildMassiveCombatStrongholdInfo = this.m_configDataLoader.GetConfigDataGuildMassiveCombatStrongholdInfo(strongHold.ConfigId);
			this.m_questInfoPanelHardText.text = "Lv" + configDataGuildMassiveCombatStrongholdInfo.EnemyLevel;
			int guildMassiveCombatStrongholdEliminateRate = this.m_playerContext.GetGuildMassiveCombatStrongholdEliminateRate(strongHold);
			this.m_questInfoPanelSuppressValueText.text = guildMassiveCombatStrongholdEliminateRate + "%";
			ConfigDataHeroTagInfo configDataHeroTagInfo = this.m_configDataLoader.GetConfigDataHeroTagInfo(strongHold.PreferredHeroTagIds[0]);
			string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_GuildMassiveCombatPowerUpDesc);
			this.m_questInfoPanelBuffText.text = string.Format(format, configDataHeroTagInfo.Name);
			this.m_questInfoPanelBuffIconImage.sprite = AssetUtility.Instance.GetSprite(configDataHeroTagInfo.Icon);
			this.SetHeroListPanel(strongHold);
			this.SetRewardGroup(configDataGuildMassiveCombatStrongholdInfo.Bonus);
		}

		// Token: 0x0600F6AC RID: 63148 RVA: 0x00413D34 File Offset: 0x00411F34
		private void SetRewardGroup(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardGroupList`1_hotfix != null)
			{
				this.m_SetRewardGroupList`1_hotfix.call(new object[]
				{
					this,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_questInfoPanelRewardGroup, rewards.Count);
			if (rewards.Count == 0)
			{
				return;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			Transform transform = this.m_questInfoPanelRewardGroup.transform;
			for (int i = 0; i < rewards.Count; i++)
			{
				RewardGoodsUIController rewardGoodsUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					rewardGoodsUIController = child.GetComponent<RewardGoodsUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					rewardGoodsUIController = gameObject.GetComponent<RewardGoodsUIController>();
					if (rewardGoodsUIController == null)
					{
						rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(gameObject);
					}
					gameObject.transform.SetParent(transform, false);
				}
				rewardGoodsUIController.SetReward(rewards[i], 0, true);
				rewardGoodsUIController.ShowCount(false);
			}
		}

		// Token: 0x0600F6AD RID: 63149 RVA: 0x00413E5C File Offset: 0x0041205C
		private void SetHeroListPanel(GuildMassiveCombatStronghold strongHoldInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroListPanelGuildMassiveCombatStronghold_hotfix != null)
			{
				this.m_SetHeroListPanelGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					strongHoldInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_questInfoPanelHeroListScrollContent, 0);
			List<int> list = new List<int>(this.m_playerContext.GetGuildPlayerMassiveCombatInfo().UsedHeroIds);
			List<int> list2 = new List<int>(this.m_configDataLoader.GetConfigDataHeroTagInfo(strongHoldInfo.PreferredHeroTagIds[0]).RelatedHeros_ID);
			List<Hero> combatHeroList = this.GetCombatHeroList(strongHoldInfo);
			Transform transform = this.m_questInfoPanelHeroListScrollContent.transform;
			for (int i = 0; i < combatHeroList.Count; i++)
			{
				GuildMassiveCombatLastHeroUIController guildMassiveCombatLastHeroUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					guildMassiveCombatLastHeroUIController = child.GetComponent<GuildMassiveCombatLastHeroUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_questInfoPanelHeroListItemPrefab);
					guildMassiveCombatLastHeroUIController = GameObjectUtility.AddControllerToGameObject<GuildMassiveCombatLastHeroUIController>(gameObject);
					gameObject.transform.SetParent(transform, false);
				}
				Hero hero = combatHeroList[i];
				guildMassiveCombatLastHeroUIController.InitGuildMassiveCombatLastHeroInfo(hero, list.Contains(hero.HeroId), list2.Contains(hero.HeroId));
			}
			this.m_questInfoPanelHeroListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x0600F6AE RID: 63150 RVA: 0x00413FC8 File Offset: 0x004121C8
		private List<Hero> GetCombatHeroList(GuildMassiveCombatStronghold strongHoldInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCombatHeroListGuildMassiveCombatStronghold_hotfix != null)
			{
				return (List<Hero>)this.m_GetCombatHeroListGuildMassiveCombatStronghold_hotfix.call(new object[]
				{
					this,
					strongHoldInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.m_playerContext.GetGuildPlayerMassiveCombatInfo();
			List<Hero> list = new List<Hero>();
			List<Hero> list2 = new List<Hero>();
			List<Hero> list3 = new List<Hero>();
			List<Hero> list4 = new List<Hero>();
			List<int> list5 = new List<int>(this.m_configDataLoader.GetConfigDataHeroTagInfo(strongHoldInfo.PreferredHeroTagIds[0]).RelatedHeros_ID);
			foreach (Hero hero in this.m_playerContext.GetHeros())
			{
				if (!guildPlayerMassiveCombatInfo.UsedHeroIds.Contains(hero.HeroId))
				{
					if (list5.Contains(hero.HeroId))
					{
						list2.Add(hero);
					}
					else
					{
						list3.Add(hero);
					}
				}
				else
				{
					list4.Add(hero);
				}
			}
			list2.Sort(new Comparison<Hero>(this.ComparerCombatHeroByPower));
			list3.Sort(new Comparison<Hero>(this.ComparerCombatHeroByPower));
			list4.Sort(new Comparison<Hero>(this.ComparerCombatHeroByPower));
			list.AddRange(list2);
			list.AddRange(list3);
			list.AddRange(list4);
			return list;
		}

		// Token: 0x0600F6AF RID: 63151 RVA: 0x00414178 File Offset: 0x00412378
		private int ComparerCombatHeroByPower(Hero h1, Hero h2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComparerCombatHeroByPowerHeroHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComparerCombatHeroByPowerHeroHero_hotfix.call(new object[]
				{
					this,
					h1,
					h2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return h2.BattlePower - h1.BattlePower;
		}

		// Token: 0x0600F6B0 RID: 63152 RVA: 0x00414214 File Offset: 0x00412414
		private void OnQuestInfoPanelBackBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnQuestInfoPanelBackBgButtonClick_hotfix != null)
			{
				this.m_OnQuestInfoPanelBackBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_questInfoPanelStateCtrl, "Close", null, true, true);
		}

		// Token: 0x0600F6B1 RID: 63153 RVA: 0x00414288 File Offset: 0x00412488
		public void ShowCombatResultEffect(bool isWin, Action onFinish = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCombatResultEffectBooleanAction_hotfix != null)
			{
				this.m_ShowCombatResultEffectBooleanAction_hotfix.call(new object[]
				{
					this,
					isWin,
					onFinish2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onFinish = onFinish2;
			GuildMassiveCombatUIController $this = this;
			this.m_guildMassiveCombatResultStateCtrl.gameObject.SetActive(true);
			string stateName = (!isWin) ? "Fail" : "Win";
			UIUtility.SetUIState(this.m_guildMassiveCombatResultStateCtrl, stateName, delegate
			{
				$this.m_guildMassiveCombatResultStateCtrl.gameObject.SetActive(false);
				if (onFinish != null)
				{
					onFinish();
				}
			}, true, true);
		}

		// Token: 0x0600F6B2 RID: 63154 RVA: 0x00414360 File Offset: 0x00412560
		private void OnQuestInfoPanelPersonalButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnQuestInfoPanelPersonalButtonClick_hotfix != null)
			{
				this.m_OnQuestInfoPanelPersonalButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSingleBattle != null)
			{
				this.EventOnSingleBattle(this.m_curSelectStrongHold);
			}
		}

		// Token: 0x0600F6B3 RID: 63155 RVA: 0x004143DC File Offset: 0x004125DC
		private void OnQuestInfoPanelTeamButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnQuestInfoPanelTeamButtonClick_hotfix != null)
			{
				this.m_OnQuestInfoPanelTeamButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnQuestInfoPanelBackBgButtonClick();
			if (this.EventOnTeamBattle != null)
			{
				this.EventOnTeamBattle(this.m_curSelectStrongHold);
			}
		}

		// Token: 0x0600F6B4 RID: 63156 RVA: 0x00414460 File Offset: 0x00412660
		private void OnRankingButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankingButtonClick_hotfix != null)
			{
				this.m_OnRankingButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_contributionPanelStateCtrl, "Show", null, true, true);
		}

		// Token: 0x0600F6B5 RID: 63157 RVA: 0x004144D4 File Offset: 0x004126D4
		private void OnRewardsButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardsButtonClick_hotfix != null)
			{
				this.m_OnRewardsButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_rewardInfoPanelStateCtrl, "Show", null, true, true);
		}

		// Token: 0x0600F6B6 RID: 63158 RVA: 0x00414548 File Offset: 0x00412748
		private void OnGiveUpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGiveUpButtonClick_hotfix != null)
			{
				this.m_OnGiveUpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGiveUpButtonClick != null)
			{
				this.EventOnGiveUpButtonClick();
			}
		}

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x004145C0 File Offset: 0x004127C0
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

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x00414638 File Offset: 0x00412838
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
			UIUtility.SetUIStateOpen(this.m_stateCtrl, "Show", null, true, true);
		}

		// Token: 0x0600F6B9 RID: 63161 RVA: 0x004146AC File Offset: 0x004128AC
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curCombatInfo = null;
			this.m_curSelectStrongHold = null;
		}

		// Token: 0x14000341 RID: 833
		// (add) Token: 0x0600F6BA RID: 63162 RVA: 0x0041471C File Offset: 0x0041291C
		// (remove) Token: 0x0600F6BB RID: 63163 RVA: 0x004147B8 File Offset: 0x004129B8
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

		// Token: 0x14000342 RID: 834
		// (add) Token: 0x0600F6BC RID: 63164 RVA: 0x00414854 File Offset: 0x00412A54
		// (remove) Token: 0x0600F6BD RID: 63165 RVA: 0x004148F0 File Offset: 0x00412AF0
		public event Action EventOnGiveUpButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGiveUpButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnGiveUpButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGiveUpButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGiveUpButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGiveUpButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnGiveUpButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGiveUpButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGiveUpButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000343 RID: 835
		// (add) Token: 0x0600F6BE RID: 63166 RVA: 0x0041498C File Offset: 0x00412B8C
		// (remove) Token: 0x0600F6BF RID: 63167 RVA: 0x00414A28 File Offset: 0x00412C28
		public event Action<GuildMassiveCombatStronghold> EventOnSingleBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSingleBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnSingleBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildMassiveCombatStronghold> action = this.EventOnSingleBattle;
				Action<GuildMassiveCombatStronghold> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatStronghold>>(ref this.EventOnSingleBattle, (Action<GuildMassiveCombatStronghold>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSingleBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnSingleBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildMassiveCombatStronghold> action = this.EventOnSingleBattle;
				Action<GuildMassiveCombatStronghold> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatStronghold>>(ref this.EventOnSingleBattle, (Action<GuildMassiveCombatStronghold>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000344 RID: 836
		// (add) Token: 0x0600F6C0 RID: 63168 RVA: 0x00414AC4 File Offset: 0x00412CC4
		// (remove) Token: 0x0600F6C1 RID: 63169 RVA: 0x00414B60 File Offset: 0x00412D60
		public event Action<GuildMassiveCombatStronghold> EventOnTeamBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTeamBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnTeamBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildMassiveCombatStronghold> action = this.EventOnTeamBattle;
				Action<GuildMassiveCombatStronghold> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatStronghold>>(ref this.EventOnTeamBattle, (Action<GuildMassiveCombatStronghold>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTeamBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnTeamBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GuildMassiveCombatStronghold> action = this.EventOnTeamBattle;
				Action<GuildMassiveCombatStronghold> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatStronghold>>(ref this.EventOnTeamBattle, (Action<GuildMassiveCombatStronghold>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0600F6C2 RID: 63170 RVA: 0x00414BFC File Offset: 0x00412DFC
		// (set) Token: 0x0600F6C3 RID: 63171 RVA: 0x00414C1C File Offset: 0x00412E1C
		[DoNotToLua]
		public new GuildMassiveCombatUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildMassiveCombatUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F6C4 RID: 63172 RVA: 0x00414C28 File Offset: 0x00412E28
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x00414C34 File Offset: 0x00412E34
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x00414C3C File Offset: 0x00412E3C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F6C7 RID: 63175 RVA: 0x00414C44 File Offset: 0x00412E44
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F6C8 RID: 63176 RVA: 0x00414C58 File Offset: 0x00412E58
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F6C9 RID: 63177 RVA: 0x00414C60 File Offset: 0x00412E60
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F6CA RID: 63178 RVA: 0x00414C6C File Offset: 0x00412E6C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F6CB RID: 63179 RVA: 0x00414C78 File Offset: 0x00412E78
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x00414C84 File Offset: 0x00412E84
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F6CD RID: 63181 RVA: 0x00414C90 File Offset: 0x00412E90
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x00414C9C File Offset: 0x00412E9C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F6CF RID: 63183 RVA: 0x00414CA8 File Offset: 0x00412EA8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F6D0 RID: 63184 RVA: 0x00414CB4 File Offset: 0x00412EB4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F6D1 RID: 63185 RVA: 0x00414CC0 File Offset: 0x00412EC0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F6D2 RID: 63186 RVA: 0x00414CCC File Offset: 0x00412ECC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F6D3 RID: 63187 RVA: 0x00414CD4 File Offset: 0x00412ED4
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600F6D4 RID: 63188 RVA: 0x00414CF4 File Offset: 0x00412EF4
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600F6D5 RID: 63189 RVA: 0x00414D00 File Offset: 0x00412F00
		private void __callDele_EventOnGiveUpButtonClick()
		{
			Action eventOnGiveUpButtonClick = this.EventOnGiveUpButtonClick;
			if (eventOnGiveUpButtonClick != null)
			{
				eventOnGiveUpButtonClick();
			}
		}

		// Token: 0x0600F6D6 RID: 63190 RVA: 0x00414D20 File Offset: 0x00412F20
		private void __clearDele_EventOnGiveUpButtonClick()
		{
			this.EventOnGiveUpButtonClick = null;
		}

		// Token: 0x0600F6D7 RID: 63191 RVA: 0x00414D2C File Offset: 0x00412F2C
		private void __callDele_EventOnSingleBattle(GuildMassiveCombatStronghold obj)
		{
			Action<GuildMassiveCombatStronghold> eventOnSingleBattle = this.EventOnSingleBattle;
			if (eventOnSingleBattle != null)
			{
				eventOnSingleBattle(obj);
			}
		}

		// Token: 0x0600F6D8 RID: 63192 RVA: 0x00414D50 File Offset: 0x00412F50
		private void __clearDele_EventOnSingleBattle(GuildMassiveCombatStronghold obj)
		{
			this.EventOnSingleBattle = null;
		}

		// Token: 0x0600F6D9 RID: 63193 RVA: 0x00414D5C File Offset: 0x00412F5C
		private void __callDele_EventOnTeamBattle(GuildMassiveCombatStronghold obj)
		{
			Action<GuildMassiveCombatStronghold> eventOnTeamBattle = this.EventOnTeamBattle;
			if (eventOnTeamBattle != null)
			{
				eventOnTeamBattle(obj);
			}
		}

		// Token: 0x0600F6DA RID: 63194 RVA: 0x00414D80 File Offset: 0x00412F80
		private void __clearDele_EventOnTeamBattle(GuildMassiveCombatStronghold obj)
		{
			this.EventOnTeamBattle = null;
		}

		// Token: 0x0600F6DB RID: 63195 RVA: 0x00414D8C File Offset: 0x00412F8C
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
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_GuildMassiveCombatUpdateView_hotfix = (luaObj.RawGet("GuildMassiveCombatUpdateView") as LuaFunction);
					this.m_UpdateStrongHolds_hotfix = (luaObj.RawGet("UpdateStrongHolds") as LuaFunction);
					this.m_OnGuildMassiveCombatStrongHoldClickGuildMassiveCombatStrongHoldUIController_hotfix = (luaObj.RawGet("OnGuildMassiveCombatStrongHoldClick") as LuaFunction);
					this.m_SetQuestInfoPanelGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("SetQuestInfoPanel") as LuaFunction);
					this.m_SetRewardGroupList`1_hotfix = (luaObj.RawGet("SetRewardGroup") as LuaFunction);
					this.m_SetHeroListPanelGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("SetHeroListPanel") as LuaFunction);
					this.m_GetCombatHeroListGuildMassiveCombatStronghold_hotfix = (luaObj.RawGet("GetCombatHeroList") as LuaFunction);
					this.m_ComparerCombatHeroByPowerHeroHero_hotfix = (luaObj.RawGet("ComparerCombatHeroByPower") as LuaFunction);
					this.m_OnQuestInfoPanelBackBgButtonClick_hotfix = (luaObj.RawGet("OnQuestInfoPanelBackBgButtonClick") as LuaFunction);
					this.m_ShowCombatResultEffectBooleanAction_hotfix = (luaObj.RawGet("ShowCombatResultEffect") as LuaFunction);
					this.m_OnQuestInfoPanelPersonalButtonClick_hotfix = (luaObj.RawGet("OnQuestInfoPanelPersonalButtonClick") as LuaFunction);
					this.m_OnQuestInfoPanelTeamButtonClick_hotfix = (luaObj.RawGet("OnQuestInfoPanelTeamButtonClick") as LuaFunction);
					this.m_OnRankingButtonClick_hotfix = (luaObj.RawGet("OnRankingButtonClick") as LuaFunction);
					this.m_OnRewardsButtonClick_hotfix = (luaObj.RawGet("OnRewardsButtonClick") as LuaFunction);
					this.m_OnGiveUpButtonClick_hotfix = (luaObj.RawGet("OnGiveUpButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnGiveUpButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnGiveUpButtonClick") as LuaFunction);
					this.m_remove_EventOnGiveUpButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnGiveUpButtonClick") as LuaFunction);
					this.m_add_EventOnSingleBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnSingleBattle") as LuaFunction);
					this.m_remove_EventOnSingleBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnSingleBattle") as LuaFunction);
					this.m_add_EventOnTeamBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnTeamBattle") as LuaFunction);
					this.m_remove_EventOnTeamBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnTeamBattle") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F6DC RID: 63196 RVA: 0x004150FC File Offset: 0x004132FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040091AB RID: 37291
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040091AC RID: 37292
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040091AD RID: 37293
		[AutoBind("./Margin/RankingButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rankingButton;

		// Token: 0x040091AE RID: 37294
		[AutoBind("./Margin/RewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rewardsButton;

		// Token: 0x040091AF RID: 37295
		[AutoBind("./RightButtom/GiveUpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_giveUpButton;

		// Token: 0x040091B0 RID: 37296
		[AutoBind("./DifficultLevel/ModoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_difficultLevelStateCtrl;

		// Token: 0x040091B1 RID: 37297
		[AutoBind("./GuildCoinPanel/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildCoinText;

		// Token: 0x040091B2 RID: 37298
		[AutoBind("./IntegralPanel/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_guildIntegralText;

		// Token: 0x040091B3 RID: 37299
		[AutoBind("./QuestPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_questPanelGo;

		// Token: 0x040091B4 RID: 37300
		[AutoBind("./ContributionPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_contributionPanelStateCtrl;

		// Token: 0x040091B5 RID: 37301
		[AutoBind("./ContributionPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_contributionPanelBackBGButton;

		// Token: 0x040091B6 RID: 37302
		[AutoBind("./RewardInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_rewardInfoPanelStateCtrl;

		// Token: 0x040091B7 RID: 37303
		[AutoBind("./RewardInfoPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rewardInfoBackBGButton;

		// Token: 0x040091B8 RID: 37304
		[AutoBind("./QuestInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_questInfoPanelStateCtrl;

		// Token: 0x040091B9 RID: 37305
		[AutoBind("./QuestInfoPanel/BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_questInfoPanelBackBGButton;

		// Token: 0x040091BA RID: 37306
		[AutoBind("./QuestInfoPanel/Detail/LeftPart/RewardGroup/RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_questInfoPanelRewardGroup;

		// Token: 0x040091BB RID: 37307
		[AutoBind("./QuestInfoPanel/Detail/LeftPart/Hard/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_questInfoPanelHardText;

		// Token: 0x040091BC RID: 37308
		[AutoBind("./QuestInfoPanel/Detail/LeftPart/SuppressValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_questInfoPanelSuppressValueText;

		// Token: 0x040091BD RID: 37309
		[AutoBind("./QuestInfoPanel/Detail/RightPart/HeroListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_questInfoPanelHeroListScrollRect;

		// Token: 0x040091BE RID: 37310
		[AutoBind("./QuestInfoPanel/Detail/RightPart/HeroListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_questInfoPanelHeroListScrollContent;

		// Token: 0x040091BF RID: 37311
		[AutoBind("./QuestInfoPanel/Detail/RightPart/TeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_questInfoPanelTeamButton;

		// Token: 0x040091C0 RID: 37312
		[AutoBind("./QuestInfoPanel/Detail/RightPart/PersonalButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_questInfoPanelPersonalButton;

		// Token: 0x040091C1 RID: 37313
		[AutoBind("./QuestInfoPanel/Detail/RightPart/BuffDesc/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_questInfoPanelBuffIconImage;

		// Token: 0x040091C2 RID: 37314
		[AutoBind("./QuestInfoPanel/Detail/RightPart/BuffDesc/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_questInfoPanelBuffText;

		// Token: 0x040091C3 RID: 37315
		[AutoBind("./Prefab/HeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_questInfoPanelHeroListItemPrefab;

		// Token: 0x040091C4 RID: 37316
		[AutoBind("./WinOrFailedEffectGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_guildMassiveCombatResultStateCtrl;

		// Token: 0x040091C9 RID: 37321
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040091CA RID: 37322
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040091CB RID: 37323
		private GuildMassiveCombatInfo m_curCombatInfo;

		// Token: 0x040091CC RID: 37324
		private GuildMassiveCombatStronghold m_curSelectStrongHold;

		// Token: 0x040091CD RID: 37325
		private List<GuildMassiveCombatStrongHoldUIController> m_strongHoldsCtrlList;

		// Token: 0x040091CE RID: 37326
		[DoNotToLua]
		private GuildMassiveCombatUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040091CF RID: 37327
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040091D0 RID: 37328
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040091D1 RID: 37329
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040091D2 RID: 37330
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x040091D3 RID: 37331
		private LuaFunction m_GuildMassiveCombatUpdateView_hotfix;

		// Token: 0x040091D4 RID: 37332
		private LuaFunction m_UpdateStrongHolds_hotfix;

		// Token: 0x040091D5 RID: 37333
		private LuaFunction m_OnGuildMassiveCombatStrongHoldClickGuildMassiveCombatStrongHoldUIController_hotfix;

		// Token: 0x040091D6 RID: 37334
		private LuaFunction m_SetQuestInfoPanelGuildMassiveCombatStronghold_hotfix;

		// Token: 0x040091D7 RID: 37335
		private LuaFunction m_SetRewardGroupList;

		// Token: 0x040091D8 RID: 37336
		private LuaFunction m_SetHeroListPanelGuildMassiveCombatStronghold_hotfix;

		// Token: 0x040091D9 RID: 37337
		private LuaFunction m_GetCombatHeroListGuildMassiveCombatStronghold_hotfix;

		// Token: 0x040091DA RID: 37338
		private LuaFunction m_ComparerCombatHeroByPowerHeroHero_hotfix;

		// Token: 0x040091DB RID: 37339
		private LuaFunction m_OnQuestInfoPanelBackBgButtonClick_hotfix;

		// Token: 0x040091DC RID: 37340
		private LuaFunction m_ShowCombatResultEffectBooleanAction_hotfix;

		// Token: 0x040091DD RID: 37341
		private LuaFunction m_OnQuestInfoPanelPersonalButtonClick_hotfix;

		// Token: 0x040091DE RID: 37342
		private LuaFunction m_OnQuestInfoPanelTeamButtonClick_hotfix;

		// Token: 0x040091DF RID: 37343
		private LuaFunction m_OnRankingButtonClick_hotfix;

		// Token: 0x040091E0 RID: 37344
		private LuaFunction m_OnRewardsButtonClick_hotfix;

		// Token: 0x040091E1 RID: 37345
		private LuaFunction m_OnGiveUpButtonClick_hotfix;

		// Token: 0x040091E2 RID: 37346
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040091E3 RID: 37347
		private LuaFunction m_Open_hotfix;

		// Token: 0x040091E4 RID: 37348
		private LuaFunction m_Close_hotfix;

		// Token: 0x040091E5 RID: 37349
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040091E6 RID: 37350
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x040091E7 RID: 37351
		private LuaFunction m_add_EventOnGiveUpButtonClickAction_hotfix;

		// Token: 0x040091E8 RID: 37352
		private LuaFunction m_remove_EventOnGiveUpButtonClickAction_hotfix;

		// Token: 0x040091E9 RID: 37353
		private LuaFunction m_add_EventOnSingleBattleAction;

		// Token: 0x040091EA RID: 37354
		private LuaFunction m_remove_EventOnSingleBattleAction;

		// Token: 0x040091EB RID: 37355
		private LuaFunction m_add_EventOnTeamBattleAction;

		// Token: 0x040091EC RID: 37356
		private LuaFunction m_remove_EventOnTeamBattleAction;

		// Token: 0x02000D1B RID: 3355
		public new class LuaExportHelper
		{
			// Token: 0x0600F6DD RID: 63197 RVA: 0x00415164 File Offset: 0x00413364
			public LuaExportHelper(GuildMassiveCombatUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F6DE RID: 63198 RVA: 0x00415174 File Offset: 0x00413374
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F6DF RID: 63199 RVA: 0x00415184 File Offset: 0x00413384
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F6E0 RID: 63200 RVA: 0x00415194 File Offset: 0x00413394
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F6E1 RID: 63201 RVA: 0x004151A4 File Offset: 0x004133A4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F6E2 RID: 63202 RVA: 0x004151BC File Offset: 0x004133BC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F6E3 RID: 63203 RVA: 0x004151CC File Offset: 0x004133CC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F6E4 RID: 63204 RVA: 0x004151DC File Offset: 0x004133DC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F6E5 RID: 63205 RVA: 0x004151EC File Offset: 0x004133EC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F6E6 RID: 63206 RVA: 0x004151FC File Offset: 0x004133FC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F6E7 RID: 63207 RVA: 0x0041520C File Offset: 0x0041340C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F6E8 RID: 63208 RVA: 0x0041521C File Offset: 0x0041341C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F6E9 RID: 63209 RVA: 0x0041522C File Offset: 0x0041342C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F6EA RID: 63210 RVA: 0x0041523C File Offset: 0x0041343C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F6EB RID: 63211 RVA: 0x0041524C File Offset: 0x0041344C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F6EC RID: 63212 RVA: 0x0041525C File Offset: 0x0041345C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F6ED RID: 63213 RVA: 0x0041526C File Offset: 0x0041346C
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600F6EE RID: 63214 RVA: 0x0041527C File Offset: 0x0041347C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600F6EF RID: 63215 RVA: 0x0041528C File Offset: 0x0041348C
			public void __callDele_EventOnGiveUpButtonClick()
			{
				this.m_owner.__callDele_EventOnGiveUpButtonClick();
			}

			// Token: 0x0600F6F0 RID: 63216 RVA: 0x0041529C File Offset: 0x0041349C
			public void __clearDele_EventOnGiveUpButtonClick()
			{
				this.m_owner.__clearDele_EventOnGiveUpButtonClick();
			}

			// Token: 0x0600F6F1 RID: 63217 RVA: 0x004152AC File Offset: 0x004134AC
			public void __callDele_EventOnSingleBattle(GuildMassiveCombatStronghold obj)
			{
				this.m_owner.__callDele_EventOnSingleBattle(obj);
			}

			// Token: 0x0600F6F2 RID: 63218 RVA: 0x004152BC File Offset: 0x004134BC
			public void __clearDele_EventOnSingleBattle(GuildMassiveCombatStronghold obj)
			{
				this.m_owner.__clearDele_EventOnSingleBattle(obj);
			}

			// Token: 0x0600F6F3 RID: 63219 RVA: 0x004152CC File Offset: 0x004134CC
			public void __callDele_EventOnTeamBattle(GuildMassiveCombatStronghold obj)
			{
				this.m_owner.__callDele_EventOnTeamBattle(obj);
			}

			// Token: 0x0600F6F4 RID: 63220 RVA: 0x004152DC File Offset: 0x004134DC
			public void __clearDele_EventOnTeamBattle(GuildMassiveCombatStronghold obj)
			{
				this.m_owner.__clearDele_EventOnTeamBattle(obj);
			}

			// Token: 0x17002F47 RID: 12103
			// (get) Token: 0x0600F6F5 RID: 63221 RVA: 0x004152EC File Offset: 0x004134EC
			// (set) Token: 0x0600F6F6 RID: 63222 RVA: 0x004152FC File Offset: 0x004134FC
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

			// Token: 0x17002F48 RID: 12104
			// (get) Token: 0x0600F6F7 RID: 63223 RVA: 0x0041530C File Offset: 0x0041350C
			// (set) Token: 0x0600F6F8 RID: 63224 RVA: 0x0041531C File Offset: 0x0041351C
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

			// Token: 0x17002F49 RID: 12105
			// (get) Token: 0x0600F6F9 RID: 63225 RVA: 0x0041532C File Offset: 0x0041352C
			// (set) Token: 0x0600F6FA RID: 63226 RVA: 0x0041533C File Offset: 0x0041353C
			public Button m_rankingButton
			{
				get
				{
					return this.m_owner.m_rankingButton;
				}
				set
				{
					this.m_owner.m_rankingButton = value;
				}
			}

			// Token: 0x17002F4A RID: 12106
			// (get) Token: 0x0600F6FB RID: 63227 RVA: 0x0041534C File Offset: 0x0041354C
			// (set) Token: 0x0600F6FC RID: 63228 RVA: 0x0041535C File Offset: 0x0041355C
			public Button m_rewardsButton
			{
				get
				{
					return this.m_owner.m_rewardsButton;
				}
				set
				{
					this.m_owner.m_rewardsButton = value;
				}
			}

			// Token: 0x17002F4B RID: 12107
			// (get) Token: 0x0600F6FD RID: 63229 RVA: 0x0041536C File Offset: 0x0041356C
			// (set) Token: 0x0600F6FE RID: 63230 RVA: 0x0041537C File Offset: 0x0041357C
			public Button m_giveUpButton
			{
				get
				{
					return this.m_owner.m_giveUpButton;
				}
				set
				{
					this.m_owner.m_giveUpButton = value;
				}
			}

			// Token: 0x17002F4C RID: 12108
			// (get) Token: 0x0600F6FF RID: 63231 RVA: 0x0041538C File Offset: 0x0041358C
			// (set) Token: 0x0600F700 RID: 63232 RVA: 0x0041539C File Offset: 0x0041359C
			public CommonUIStateController m_difficultLevelStateCtrl
			{
				get
				{
					return this.m_owner.m_difficultLevelStateCtrl;
				}
				set
				{
					this.m_owner.m_difficultLevelStateCtrl = value;
				}
			}

			// Token: 0x17002F4D RID: 12109
			// (get) Token: 0x0600F701 RID: 63233 RVA: 0x004153AC File Offset: 0x004135AC
			// (set) Token: 0x0600F702 RID: 63234 RVA: 0x004153BC File Offset: 0x004135BC
			public Text m_guildCoinText
			{
				get
				{
					return this.m_owner.m_guildCoinText;
				}
				set
				{
					this.m_owner.m_guildCoinText = value;
				}
			}

			// Token: 0x17002F4E RID: 12110
			// (get) Token: 0x0600F703 RID: 63235 RVA: 0x004153CC File Offset: 0x004135CC
			// (set) Token: 0x0600F704 RID: 63236 RVA: 0x004153DC File Offset: 0x004135DC
			public Text m_guildIntegralText
			{
				get
				{
					return this.m_owner.m_guildIntegralText;
				}
				set
				{
					this.m_owner.m_guildIntegralText = value;
				}
			}

			// Token: 0x17002F4F RID: 12111
			// (get) Token: 0x0600F705 RID: 63237 RVA: 0x004153EC File Offset: 0x004135EC
			// (set) Token: 0x0600F706 RID: 63238 RVA: 0x004153FC File Offset: 0x004135FC
			public GameObject m_questPanelGo
			{
				get
				{
					return this.m_owner.m_questPanelGo;
				}
				set
				{
					this.m_owner.m_questPanelGo = value;
				}
			}

			// Token: 0x17002F50 RID: 12112
			// (get) Token: 0x0600F707 RID: 63239 RVA: 0x0041540C File Offset: 0x0041360C
			// (set) Token: 0x0600F708 RID: 63240 RVA: 0x0041541C File Offset: 0x0041361C
			public CommonUIStateController m_contributionPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_contributionPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_contributionPanelStateCtrl = value;
				}
			}

			// Token: 0x17002F51 RID: 12113
			// (get) Token: 0x0600F709 RID: 63241 RVA: 0x0041542C File Offset: 0x0041362C
			// (set) Token: 0x0600F70A RID: 63242 RVA: 0x0041543C File Offset: 0x0041363C
			public Button m_contributionPanelBackBGButton
			{
				get
				{
					return this.m_owner.m_contributionPanelBackBGButton;
				}
				set
				{
					this.m_owner.m_contributionPanelBackBGButton = value;
				}
			}

			// Token: 0x17002F52 RID: 12114
			// (get) Token: 0x0600F70B RID: 63243 RVA: 0x0041544C File Offset: 0x0041364C
			// (set) Token: 0x0600F70C RID: 63244 RVA: 0x0041545C File Offset: 0x0041365C
			public CommonUIStateController m_rewardInfoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_rewardInfoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_rewardInfoPanelStateCtrl = value;
				}
			}

			// Token: 0x17002F53 RID: 12115
			// (get) Token: 0x0600F70D RID: 63245 RVA: 0x0041546C File Offset: 0x0041366C
			// (set) Token: 0x0600F70E RID: 63246 RVA: 0x0041547C File Offset: 0x0041367C
			public Button m_rewardInfoBackBGButton
			{
				get
				{
					return this.m_owner.m_rewardInfoBackBGButton;
				}
				set
				{
					this.m_owner.m_rewardInfoBackBGButton = value;
				}
			}

			// Token: 0x17002F54 RID: 12116
			// (get) Token: 0x0600F70F RID: 63247 RVA: 0x0041548C File Offset: 0x0041368C
			// (set) Token: 0x0600F710 RID: 63248 RVA: 0x0041549C File Offset: 0x0041369C
			public CommonUIStateController m_questInfoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_questInfoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_questInfoPanelStateCtrl = value;
				}
			}

			// Token: 0x17002F55 RID: 12117
			// (get) Token: 0x0600F711 RID: 63249 RVA: 0x004154AC File Offset: 0x004136AC
			// (set) Token: 0x0600F712 RID: 63250 RVA: 0x004154BC File Offset: 0x004136BC
			public Button m_questInfoPanelBackBGButton
			{
				get
				{
					return this.m_owner.m_questInfoPanelBackBGButton;
				}
				set
				{
					this.m_owner.m_questInfoPanelBackBGButton = value;
				}
			}

			// Token: 0x17002F56 RID: 12118
			// (get) Token: 0x0600F713 RID: 63251 RVA: 0x004154CC File Offset: 0x004136CC
			// (set) Token: 0x0600F714 RID: 63252 RVA: 0x004154DC File Offset: 0x004136DC
			public GameObject m_questInfoPanelRewardGroup
			{
				get
				{
					return this.m_owner.m_questInfoPanelRewardGroup;
				}
				set
				{
					this.m_owner.m_questInfoPanelRewardGroup = value;
				}
			}

			// Token: 0x17002F57 RID: 12119
			// (get) Token: 0x0600F715 RID: 63253 RVA: 0x004154EC File Offset: 0x004136EC
			// (set) Token: 0x0600F716 RID: 63254 RVA: 0x004154FC File Offset: 0x004136FC
			public Text m_questInfoPanelHardText
			{
				get
				{
					return this.m_owner.m_questInfoPanelHardText;
				}
				set
				{
					this.m_owner.m_questInfoPanelHardText = value;
				}
			}

			// Token: 0x17002F58 RID: 12120
			// (get) Token: 0x0600F717 RID: 63255 RVA: 0x0041550C File Offset: 0x0041370C
			// (set) Token: 0x0600F718 RID: 63256 RVA: 0x0041551C File Offset: 0x0041371C
			public Text m_questInfoPanelSuppressValueText
			{
				get
				{
					return this.m_owner.m_questInfoPanelSuppressValueText;
				}
				set
				{
					this.m_owner.m_questInfoPanelSuppressValueText = value;
				}
			}

			// Token: 0x17002F59 RID: 12121
			// (get) Token: 0x0600F719 RID: 63257 RVA: 0x0041552C File Offset: 0x0041372C
			// (set) Token: 0x0600F71A RID: 63258 RVA: 0x0041553C File Offset: 0x0041373C
			public ScrollRect m_questInfoPanelHeroListScrollRect
			{
				get
				{
					return this.m_owner.m_questInfoPanelHeroListScrollRect;
				}
				set
				{
					this.m_owner.m_questInfoPanelHeroListScrollRect = value;
				}
			}

			// Token: 0x17002F5A RID: 12122
			// (get) Token: 0x0600F71B RID: 63259 RVA: 0x0041554C File Offset: 0x0041374C
			// (set) Token: 0x0600F71C RID: 63260 RVA: 0x0041555C File Offset: 0x0041375C
			public GameObject m_questInfoPanelHeroListScrollContent
			{
				get
				{
					return this.m_owner.m_questInfoPanelHeroListScrollContent;
				}
				set
				{
					this.m_owner.m_questInfoPanelHeroListScrollContent = value;
				}
			}

			// Token: 0x17002F5B RID: 12123
			// (get) Token: 0x0600F71D RID: 63261 RVA: 0x0041556C File Offset: 0x0041376C
			// (set) Token: 0x0600F71E RID: 63262 RVA: 0x0041557C File Offset: 0x0041377C
			public Button m_questInfoPanelTeamButton
			{
				get
				{
					return this.m_owner.m_questInfoPanelTeamButton;
				}
				set
				{
					this.m_owner.m_questInfoPanelTeamButton = value;
				}
			}

			// Token: 0x17002F5C RID: 12124
			// (get) Token: 0x0600F71F RID: 63263 RVA: 0x0041558C File Offset: 0x0041378C
			// (set) Token: 0x0600F720 RID: 63264 RVA: 0x0041559C File Offset: 0x0041379C
			public Button m_questInfoPanelPersonalButton
			{
				get
				{
					return this.m_owner.m_questInfoPanelPersonalButton;
				}
				set
				{
					this.m_owner.m_questInfoPanelPersonalButton = value;
				}
			}

			// Token: 0x17002F5D RID: 12125
			// (get) Token: 0x0600F721 RID: 63265 RVA: 0x004155AC File Offset: 0x004137AC
			// (set) Token: 0x0600F722 RID: 63266 RVA: 0x004155BC File Offset: 0x004137BC
			public Image m_questInfoPanelBuffIconImage
			{
				get
				{
					return this.m_owner.m_questInfoPanelBuffIconImage;
				}
				set
				{
					this.m_owner.m_questInfoPanelBuffIconImage = value;
				}
			}

			// Token: 0x17002F5E RID: 12126
			// (get) Token: 0x0600F723 RID: 63267 RVA: 0x004155CC File Offset: 0x004137CC
			// (set) Token: 0x0600F724 RID: 63268 RVA: 0x004155DC File Offset: 0x004137DC
			public Text m_questInfoPanelBuffText
			{
				get
				{
					return this.m_owner.m_questInfoPanelBuffText;
				}
				set
				{
					this.m_owner.m_questInfoPanelBuffText = value;
				}
			}

			// Token: 0x17002F5F RID: 12127
			// (get) Token: 0x0600F725 RID: 63269 RVA: 0x004155EC File Offset: 0x004137EC
			// (set) Token: 0x0600F726 RID: 63270 RVA: 0x004155FC File Offset: 0x004137FC
			public GameObject m_questInfoPanelHeroListItemPrefab
			{
				get
				{
					return this.m_owner.m_questInfoPanelHeroListItemPrefab;
				}
				set
				{
					this.m_owner.m_questInfoPanelHeroListItemPrefab = value;
				}
			}

			// Token: 0x17002F60 RID: 12128
			// (get) Token: 0x0600F727 RID: 63271 RVA: 0x0041560C File Offset: 0x0041380C
			// (set) Token: 0x0600F728 RID: 63272 RVA: 0x0041561C File Offset: 0x0041381C
			public CommonUIStateController m_guildMassiveCombatResultStateCtrl
			{
				get
				{
					return this.m_owner.m_guildMassiveCombatResultStateCtrl;
				}
				set
				{
					this.m_owner.m_guildMassiveCombatResultStateCtrl = value;
				}
			}

			// Token: 0x17002F61 RID: 12129
			// (get) Token: 0x0600F729 RID: 63273 RVA: 0x0041562C File Offset: 0x0041382C
			// (set) Token: 0x0600F72A RID: 63274 RVA: 0x0041563C File Offset: 0x0041383C
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

			// Token: 0x17002F62 RID: 12130
			// (get) Token: 0x0600F72B RID: 63275 RVA: 0x0041564C File Offset: 0x0041384C
			// (set) Token: 0x0600F72C RID: 63276 RVA: 0x0041565C File Offset: 0x0041385C
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

			// Token: 0x17002F63 RID: 12131
			// (get) Token: 0x0600F72D RID: 63277 RVA: 0x0041566C File Offset: 0x0041386C
			// (set) Token: 0x0600F72E RID: 63278 RVA: 0x0041567C File Offset: 0x0041387C
			public GuildMassiveCombatInfo m_curCombatInfo
			{
				get
				{
					return this.m_owner.m_curCombatInfo;
				}
				set
				{
					this.m_owner.m_curCombatInfo = value;
				}
			}

			// Token: 0x17002F64 RID: 12132
			// (get) Token: 0x0600F72F RID: 63279 RVA: 0x0041568C File Offset: 0x0041388C
			// (set) Token: 0x0600F730 RID: 63280 RVA: 0x0041569C File Offset: 0x0041389C
			public GuildMassiveCombatStronghold m_curSelectStrongHold
			{
				get
				{
					return this.m_owner.m_curSelectStrongHold;
				}
				set
				{
					this.m_owner.m_curSelectStrongHold = value;
				}
			}

			// Token: 0x17002F65 RID: 12133
			// (get) Token: 0x0600F731 RID: 63281 RVA: 0x004156AC File Offset: 0x004138AC
			// (set) Token: 0x0600F732 RID: 63282 RVA: 0x004156BC File Offset: 0x004138BC
			public List<GuildMassiveCombatStrongHoldUIController> m_strongHoldsCtrlList
			{
				get
				{
					return this.m_owner.m_strongHoldsCtrlList;
				}
				set
				{
					this.m_owner.m_strongHoldsCtrlList = value;
				}
			}

			// Token: 0x0600F733 RID: 63283 RVA: 0x004156CC File Offset: 0x004138CC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F734 RID: 63284 RVA: 0x004156DC File Offset: 0x004138DC
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x0600F735 RID: 63285 RVA: 0x004156EC File Offset: 0x004138EC
			public void UpdateStrongHolds()
			{
				this.m_owner.UpdateStrongHolds();
			}

			// Token: 0x0600F736 RID: 63286 RVA: 0x004156FC File Offset: 0x004138FC
			public void OnGuildMassiveCombatStrongHoldClick(GuildMassiveCombatStrongHoldUIController ctrl)
			{
				this.m_owner.OnGuildMassiveCombatStrongHoldClick(ctrl);
			}

			// Token: 0x0600F737 RID: 63287 RVA: 0x0041570C File Offset: 0x0041390C
			public void SetQuestInfoPanel(GuildMassiveCombatStronghold strongHold)
			{
				this.m_owner.SetQuestInfoPanel(strongHold);
			}

			// Token: 0x0600F738 RID: 63288 RVA: 0x0041571C File Offset: 0x0041391C
			public void SetRewardGroup(List<Goods> rewards)
			{
				this.m_owner.SetRewardGroup(rewards);
			}

			// Token: 0x0600F739 RID: 63289 RVA: 0x0041572C File Offset: 0x0041392C
			public void SetHeroListPanel(GuildMassiveCombatStronghold strongHoldInfo)
			{
				this.m_owner.SetHeroListPanel(strongHoldInfo);
			}

			// Token: 0x0600F73A RID: 63290 RVA: 0x0041573C File Offset: 0x0041393C
			public List<Hero> GetCombatHeroList(GuildMassiveCombatStronghold strongHoldInfo)
			{
				return this.m_owner.GetCombatHeroList(strongHoldInfo);
			}

			// Token: 0x0600F73B RID: 63291 RVA: 0x0041574C File Offset: 0x0041394C
			public int ComparerCombatHeroByPower(Hero h1, Hero h2)
			{
				return this.m_owner.ComparerCombatHeroByPower(h1, h2);
			}

			// Token: 0x0600F73C RID: 63292 RVA: 0x0041575C File Offset: 0x0041395C
			public void OnQuestInfoPanelBackBgButtonClick()
			{
				this.m_owner.OnQuestInfoPanelBackBgButtonClick();
			}

			// Token: 0x0600F73D RID: 63293 RVA: 0x0041576C File Offset: 0x0041396C
			public void OnQuestInfoPanelPersonalButtonClick()
			{
				this.m_owner.OnQuestInfoPanelPersonalButtonClick();
			}

			// Token: 0x0600F73E RID: 63294 RVA: 0x0041577C File Offset: 0x0041397C
			public void OnQuestInfoPanelTeamButtonClick()
			{
				this.m_owner.OnQuestInfoPanelTeamButtonClick();
			}

			// Token: 0x0600F73F RID: 63295 RVA: 0x0041578C File Offset: 0x0041398C
			public void OnRankingButtonClick()
			{
				this.m_owner.OnRankingButtonClick();
			}

			// Token: 0x0600F740 RID: 63296 RVA: 0x0041579C File Offset: 0x0041399C
			public void OnRewardsButtonClick()
			{
				this.m_owner.OnRewardsButtonClick();
			}

			// Token: 0x0600F741 RID: 63297 RVA: 0x004157AC File Offset: 0x004139AC
			public void OnGiveUpButtonClick()
			{
				this.m_owner.OnGiveUpButtonClick();
			}

			// Token: 0x0600F742 RID: 63298 RVA: 0x004157BC File Offset: 0x004139BC
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x040091ED RID: 37357
			private GuildMassiveCombatUIController m_owner;
		}
	}
}
