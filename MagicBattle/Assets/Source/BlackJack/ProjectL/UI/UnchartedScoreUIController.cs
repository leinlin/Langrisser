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
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FF2 RID: 4082
	[HotFix]
	public class UnchartedScoreUIController : UIControllerBase
	{
		// Token: 0x060147B5 RID: 83893 RVA: 0x0053352C File Offset: 0x0053172C
		private UnchartedScoreUIController()
		{
		}

		// Token: 0x060147B6 RID: 83894 RVA: 0x00533534 File Offset: 0x00531734
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
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_teamButton.onClick.AddListener(new UnityAction(this.OnTeamButtonClick));
			this.m_rewardButton.onClick.AddListener(new UnityAction(this.OnRewardButtonClick));
			this.m_recommendHeroButton.onClick.AddListener(new UnityAction(this.OnRecommendHeroButtonClick));
			this.m_scoreLevelToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnScoreLevelToggleValueChanged));
			this.m_challengeLevelToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnChallengeLevelToggleValueChanged));
			this.m_scoreRewardBGButton.onClick.AddListener(new UnityAction(this.OnScoreRewardCloseButtonClick));
			this.m_scoreRewardUIStateController.gameObject.SetActive(false);
			this.m_recommendHeroBGButton.onClick.AddListener(new UnityAction(this.OnRecommendHeroBGButtonClick));
			this.m_recommendHeroUIStateController.gameObject.SetActive(false);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x060147B7 RID: 83895 RVA: 0x005336C4 File Offset: 0x005318C4
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x060147B8 RID: 83896 RVA: 0x00533738 File Offset: 0x00531938
		public void SetBattleType(BattleType battleType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleTypeBattleType_hotfix != null)
			{
				this.m_SetBattleTypeBattleType_hotfix.call(new object[]
				{
					this,
					battleType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isIgnoreToggleEvent = true;
			this.m_scoreLevelToggle.isOn = (battleType == BattleType.UnchartedScore_ScoreLevel);
			this.m_challengeLevelToggle.isOn = (battleType == BattleType.UnchartedScore_ChallengeLevel);
			this.m_isIgnoreToggleEvent = false;
		}

		// Token: 0x060147B9 RID: 83897 RVA: 0x005337D8 File Offset: 0x005319D8
		public void SetScore(int score)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetScoreInt32_hotfix != null)
			{
				this.m_SetScoreInt32_hotfix.call(new object[]
				{
					this,
					score
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Text scoreText = this.m_scoreText;
			string text = score.ToString();
			this.m_scoreRewardScoreText.text = text;
			scoreText.text = text;
		}

		// Token: 0x060147BA RID: 83898 RVA: 0x00533870 File Offset: 0x00531A70
		public void SetUnchartedScoreInfo(ConfigDataUnchartedScoreInfo unchartedScoreInfo, ConfigDataUnchartedScoreModelInfo unchartedScoreModelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfoConfigDataUnchartedScoreModelInfo_hotfix != null)
			{
				this.m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfoConfigDataUnchartedScoreModelInfo_hotfix.call(new object[]
				{
					this,
					unchartedScoreInfo,
					unchartedScoreModelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unchartedScoreInfo = unchartedScoreInfo;
			this.m_activityNameText.text = unchartedScoreInfo.Name;
			this.m_activityUIStateController.SetToUIState(unchartedScoreInfo.UIState, false, true);
			this.CreateSpineGraphic(unchartedScoreModelInfo);
		}

		// Token: 0x060147BB RID: 83899 RVA: 0x00533924 File Offset: 0x00531B24
		public void SetAllUnchartedScoreLevelListItems(IEnumerable<ConfigDataScoreLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAllUnchartedScoreLevelListItemsIEnumerable`1_hotfix != null)
			{
				this.m_SetAllUnchartedScoreLevelListItemsIEnumerable`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = 0;
			foreach (ConfigDataScoreLevelInfo configDataScoreLevelInfo in levelInfos)
			{
				if (projectLPlayerContext.IsUnchartedScoreLevelTimeUnlock(configDataScoreLevelInfo.UnchartedScoreInfo.ID, configDataScoreLevelInfo.ID))
				{
					UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController;
					if (num < this.m_levelListScrollRect.content.childCount)
					{
						unchartedScoreLevelListItemUIController = this.m_levelListScrollRect.content.GetChild(num).GetComponent<UnchartedScoreLevelListItemUIController>();
					}
					else
					{
						GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_unchartedScoreLevelListItemPrefab, this.m_levelListScrollRect.content, false);
						unchartedScoreLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<UnchartedScoreLevelListItemUIController>(go);
						unchartedScoreLevelListItemUIController.EventOnStartButtonClick += this.UnchartedScoreLevelListItem_OnStartButtonClick;
					}
					unchartedScoreLevelListItemUIController.SetUnchartedScoreLevelInfo(configDataScoreLevelInfo);
					unchartedScoreLevelListItemUIController.SetLocked(!projectLPlayerContext.IsUnchartedScoreLevelPlayerLevelVaild(configDataScoreLevelInfo.ID));
					num++;
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_levelListScrollRect.content.gameObject, num);
		}

		// Token: 0x060147BC RID: 83900 RVA: 0x00533AAC File Offset: 0x00531CAC
		public void SetAllUnchartedChallengeLevelListItems(IEnumerable<ConfigDataChallengeLevelInfo> levelInfos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAllUnchartedChallengeLevelListItemsIEnumerable`1_hotfix != null)
			{
				this.m_SetAllUnchartedChallengeLevelListItemsIEnumerable`1_hotfix.call(new object[]
				{
					this,
					levelInfos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = 0;
			for (int i = 0; i < 2; i++)
			{
				foreach (ConfigDataChallengeLevelInfo configDataChallengeLevelInfo in levelInfos)
				{
					bool flag = projectLPlayerContext.IsUnchartedChallengeLevelFinished(configDataChallengeLevelInfo.UnchartedScoreInfo.ID, configDataChallengeLevelInfo.ID);
					if (i == 0)
					{
						if (flag)
						{
							continue;
						}
					}
					else if (i == 1 && !flag)
					{
						continue;
					}
					UnchartedScoreLevelListItemUIController unchartedScoreLevelListItemUIController;
					if (num < this.m_levelListScrollRect.content.childCount)
					{
						unchartedScoreLevelListItemUIController = this.m_levelListScrollRect.content.GetChild(num).GetComponent<UnchartedScoreLevelListItemUIController>();
					}
					else
					{
						GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_unchartedScoreLevelListItemPrefab, this.m_levelListScrollRect.content, false);
						unchartedScoreLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<UnchartedScoreLevelListItemUIController>(go);
						unchartedScoreLevelListItemUIController.EventOnStartButtonClick += this.UnchartedScoreLevelListItem_OnStartButtonClick;
					}
					unchartedScoreLevelListItemUIController.SetUnchartedChallengeLevelInfo(configDataChallengeLevelInfo);
					if (i == 0)
					{
						int unchartedChallengeLevelTimeUnlockDay = projectLPlayerContext.GetUnchartedChallengeLevelTimeUnlockDay(configDataChallengeLevelInfo.UnchartedScoreInfo.ID, configDataChallengeLevelInfo.ID);
						if (unchartedChallengeLevelTimeUnlockDay <= 0)
						{
							unchartedScoreLevelListItemUIController.SetLocked(!projectLPlayerContext.IsUnchartedChallengePrevLevelComplete(configDataChallengeLevelInfo.UnchartedScoreInfo.ID, configDataChallengeLevelInfo.ID));
						}
						else
						{
							unchartedScoreLevelListItemUIController.SetOpenDayLocked(unchartedChallengeLevelTimeUnlockDay);
						}
					}
					else if (i == 1)
					{
						unchartedScoreLevelListItemUIController.SetCompleted();
					}
					num++;
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_levelListScrollRect.content.gameObject, num);
		}

		// Token: 0x060147BD RID: 83901 RVA: 0x00533CCC File Offset: 0x00531ECC
		private void CreateSpineGraphic(ConfigDataUnchartedScoreModelInfo unchartedScoreModelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataUnchartedScoreModelInfo_hotfix != null)
			{
				this.m_CreateSpineGraphicConfigDataUnchartedScoreModelInfo_hotfix.call(new object[]
				{
					this,
					unchartedScoreModelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			if (unchartedScoreModelInfo == null)
			{
				return;
			}
			float num = (float)unchartedScoreModelInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)unchartedScoreModelInfo.UI_ModelOffsetX, (float)unchartedScoreModelInfo.UI_ModelOffsetY);
			this.m_graphic = new UISpineGraphic();
			this.m_graphic.Create(unchartedScoreModelInfo.Model);
			this.m_graphic.SetParent(this.m_charGo);
			this.m_graphic.SetDirection(unchartedScoreModelInfo.UI_ModelDir);
			this.m_graphic.SetPosition(position);
			this.m_graphic.SetScale(num);
			this.m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			this.m_graphic.PlayAnimation("idle_Normal", true, 0);
			this.m_graphic.ForceUpdate();
		}

		// Token: 0x060147BE RID: 83902 RVA: 0x00533E00 File Offset: 0x00532000
		private void DestroySpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_graphic.Destroy();
				this.m_graphic = null;
			}
		}

		// Token: 0x060147BF RID: 83903 RVA: 0x00533E80 File Offset: 0x00532080
		public void SetDailyRewardCount(int restCount, int allCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDailyRewardCountInt32Int32_hotfix != null)
			{
				this.m_SetDailyRewardCountInt32Int32_hotfix.call(new object[]
				{
					this,
					restCount,
					allCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetDailyRewardCount(this.m_dailyRewardCountText, restCount, allCount);
		}

		// Token: 0x060147C0 RID: 83904 RVA: 0x00533F10 File Offset: 0x00532110
		public void ShowScoreReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowScoreReward_hotfix != null)
			{
				this.m_ShowScoreReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreInfo == null)
			{
				return;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = 0;
			int num2 = -1;
			foreach (KeyValuePair<int, ConfigDataUnchartedScoreRewardGroupInfo> keyValuePair in configDataLoader.GetAllConfigDataUnchartedScoreRewardGroupInfo())
			{
				if (keyValuePair.Value.GroupId == this.m_unchartedScoreInfo.UnchartedScoreRewardGroupId)
				{
					UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController;
					if (num < this.m_scoreRewardScollRect.content.childCount)
					{
						unchartedScoreRewardListItemUIController = this.m_scoreRewardScollRect.content.GetChild(num).GetComponent<UnchartedScoreRewardListItemUIController>();
					}
					else
					{
						GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_scoreRewardItemPrefab, this.m_scoreRewardScollRect.content, false);
						unchartedScoreRewardListItemUIController = GameObjectUtility.AddControllerToGameObject<UnchartedScoreRewardListItemUIController>(go);
					}
					unchartedScoreRewardListItemUIController.SetUnchartedScoreRewardGroupInfo(keyValuePair.Value, this.m_unchartedScoreInfo.ScoreName);
					bool flag = projectLPlayerContext.IsUnchartedScoreRewardGot(this.m_unchartedScoreInfo.ID, keyValuePair.Key);
					unchartedScoreRewardListItemUIController.SetGot(flag);
					if (flag && num2 < 0)
					{
						num2 = num;
					}
					num++;
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_scoreRewardScollRect.content.gameObject, num);
			base.StartCoroutine(this.Co_ScrollToItem(this.m_scoreRewardScollRect, num, num2 - 3));
			this.m_scoreRewardScoreNameText.text = this.m_unchartedScoreInfo.ScoreName;
			UIUtility.SetUIStateOpen(this.m_scoreRewardUIStateController, "Show", null, false, true);
		}

		// Token: 0x060147C1 RID: 83905 RVA: 0x0053410C File Offset: 0x0053230C
		[DebuggerHidden]
		private IEnumerator Co_ScrollToItem(ScrollRect scrollRect, int itemCount, int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ScrollToItemScrollRectInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ScrollToItemScrollRectInt32Int32_hotfix.call(new object[]
				{
					this,
					scrollRect,
					itemCount,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnchartedScoreUIController.<Co_ScrollToItem>c__Iterator0 <Co_ScrollToItem>c__Iterator = new UnchartedScoreUIController.<Co_ScrollToItem>c__Iterator0();
			<Co_ScrollToItem>c__Iterator.scrollRect = scrollRect;
			<Co_ScrollToItem>c__Iterator.itemCount = itemCount;
			<Co_ScrollToItem>c__Iterator.idx = idx;
			return <Co_ScrollToItem>c__Iterator;
		}

		// Token: 0x060147C2 RID: 83906 RVA: 0x005341C4 File Offset: 0x005323C4
		private static void ScrollToItem(ScrollRect scrollRect, int itemCount, int idx)
		{
			if (itemCount <= 0)
			{
				return;
			}
			float num = scrollRect.content.sizeDelta.y / (float)itemCount;
			float num2 = scrollRect.viewport.rect.height / num;
			float verticalNormalizedPosition = Mathf.Clamp01(1f - (float)idx / ((float)itemCount - num2));
			scrollRect.verticalNormalizedPosition = verticalNormalizedPosition;
		}

		// Token: 0x060147C3 RID: 83907 RVA: 0x00534224 File Offset: 0x00532424
		private void HideScoreReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideScoreReward_hotfix != null)
			{
				this.m_HideScoreReward_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_scoreRewardUIStateController, "Close", null, false, true);
		}

		// Token: 0x060147C4 RID: 83908 RVA: 0x00534298 File Offset: 0x00532498
		public void ShowRecommendHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRecommendHero_hotfix != null)
			{
				this.m_ShowRecommendHero_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedScoreInfo == null)
			{
				return;
			}
			List<Int32Pair> bonusHeroIdList = this.m_unchartedScoreInfo.BonusHeroIdList;
			int num = 0;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_recommendHeroGroupScrollRect.content.gameObject, bonusHeroIdList.Count);
			for (int i = 0; i < bonusHeroIdList.Count; i++)
			{
				UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController;
				if (i < this.m_recommendHeroGroupScrollRect.content.childCount)
				{
					unchartedScoreRecommendHeroListItemUIController = this.m_recommendHeroGroupScrollRect.content.GetChild(i).GetComponent<UnchartedScoreRecommendHeroListItemUIController>();
				}
				else
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_recommendHeroItemPrefab, this.m_recommendHeroGroupScrollRect.content, false);
					unchartedScoreRecommendHeroListItemUIController = GameObjectUtility.AddControllerToGameObject<UnchartedScoreRecommendHeroListItemUIController>(go);
				}
				unchartedScoreRecommendHeroListItemUIController.SetHero(bonusHeroIdList[i].Key);
				if (num == 0)
				{
					num = bonusHeroIdList[i].Value;
				}
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_recommendHeroDescText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnchartedScore_RecommendHeroDesc), num);
			UIUtility.SetUIStateOpen(this.m_recommendHeroUIStateController, "Show", null, false, true);
		}

		// Token: 0x060147C5 RID: 83909 RVA: 0x00534404 File Offset: 0x00532604
		private void HideRecommendHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideRecommendHero_hotfix != null)
			{
				this.m_HideRecommendHero_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_recommendHeroUIStateController, "Close", null, false, true);
		}

		// Token: 0x060147C6 RID: 83910 RVA: 0x00534478 File Offset: 0x00532678
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

		// Token: 0x060147C7 RID: 83911 RVA: 0x005344F0 File Offset: 0x005326F0
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x060147C8 RID: 83912 RVA: 0x00534568 File Offset: 0x00532768
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

		// Token: 0x060147C9 RID: 83913 RVA: 0x005345E0 File Offset: 0x005327E0
		private void OnRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardButtonClick_hotfix != null)
			{
				this.m_OnRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowScoreReward();
		}

		// Token: 0x060147CA RID: 83914 RVA: 0x00534648 File Offset: 0x00532848
		private void OnRecommendHeroButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecommendHeroButtonClick_hotfix != null)
			{
				this.m_OnRecommendHeroButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowRecommendHero();
		}

		// Token: 0x060147CB RID: 83915 RVA: 0x005346B0 File Offset: 0x005328B0
		private void OnScoreLevelToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScoreLevelToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnScoreLevelToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnChangeBattleType != null)
			{
				this.EventOnChangeBattleType(BattleType.UnchartedScore_ScoreLevel);
			}
		}

		// Token: 0x060147CC RID: 83916 RVA: 0x0053474C File Offset: 0x0053294C
		private void OnChallengeLevelToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChallengeLevelToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnChallengeLevelToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnChangeBattleType != null)
			{
				this.EventOnChangeBattleType(BattleType.UnchartedScore_ChallengeLevel);
			}
		}

		// Token: 0x060147CD RID: 83917 RVA: 0x005347E8 File Offset: 0x005329E8
		private void OnScoreRewardCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScoreRewardCloseButtonClick_hotfix != null)
			{
				this.m_OnScoreRewardCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideScoreReward();
		}

		// Token: 0x060147CE RID: 83918 RVA: 0x00534850 File Offset: 0x00532A50
		private void OnRecommendHeroBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRecommendHeroBGButtonClick_hotfix != null)
			{
				this.m_OnRecommendHeroBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideRecommendHero();
		}

		// Token: 0x060147CF RID: 83919 RVA: 0x005348B8 File Offset: 0x00532AB8
		private void UnchartedScoreLevelListItem_OnStartButtonClick(UnchartedScoreLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedScoreLevelListItem_OnStartButtonClickUnchartedScoreLevelListItemUIController_hotfix != null)
			{
				this.m_UnchartedScoreLevelListItem_OnStartButtonClickUnchartedScoreLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartUnchartedScoreLevel != null)
			{
				if (ctrl.GetUnchartedScoreLevelInfo() != null)
				{
					this.EventOnStartUnchartedScoreLevel(ctrl.GetUnchartedScoreLevelInfo());
				}
				else
				{
					this.EventOnStartUnchartedChallengeLevel(ctrl.GetUnchartedChallengeLevelInfo());
				}
			}
		}

		// Token: 0x14000481 RID: 1153
		// (add) Token: 0x060147D0 RID: 83920 RVA: 0x00534968 File Offset: 0x00532B68
		// (remove) Token: 0x060147D1 RID: 83921 RVA: 0x00534A04 File Offset: 0x00532C04
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

		// Token: 0x14000482 RID: 1154
		// (add) Token: 0x060147D2 RID: 83922 RVA: 0x00534AA0 File Offset: 0x00532CA0
		// (remove) Token: 0x060147D3 RID: 83923 RVA: 0x00534B3C File Offset: 0x00532D3C
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000483 RID: 1155
		// (add) Token: 0x060147D4 RID: 83924 RVA: 0x00534BD8 File Offset: 0x00532DD8
		// (remove) Token: 0x060147D5 RID: 83925 RVA: 0x00534C74 File Offset: 0x00532E74
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

		// Token: 0x14000484 RID: 1156
		// (add) Token: 0x060147D6 RID: 83926 RVA: 0x00534D10 File Offset: 0x00532F10
		// (remove) Token: 0x060147D7 RID: 83927 RVA: 0x00534DAC File Offset: 0x00532FAC
		public event Action<BattleType> EventOnChangeBattleType
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeBattleTypeAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeBattleTypeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType> action = this.EventOnChangeBattleType;
				Action<BattleType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType>>(ref this.EventOnChangeBattleType, (Action<BattleType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeBattleTypeAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeBattleTypeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType> action = this.EventOnChangeBattleType;
				Action<BattleType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType>>(ref this.EventOnChangeBattleType, (Action<BattleType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000485 RID: 1157
		// (add) Token: 0x060147D8 RID: 83928 RVA: 0x00534E48 File Offset: 0x00533048
		// (remove) Token: 0x060147D9 RID: 83929 RVA: 0x00534EE4 File Offset: 0x005330E4
		public event Action<ConfigDataScoreLevelInfo> EventOnStartUnchartedScoreLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartUnchartedScoreLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartUnchartedScoreLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataScoreLevelInfo> action = this.EventOnStartUnchartedScoreLevel;
				Action<ConfigDataScoreLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataScoreLevelInfo>>(ref this.EventOnStartUnchartedScoreLevel, (Action<ConfigDataScoreLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartUnchartedScoreLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartUnchartedScoreLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataScoreLevelInfo> action = this.EventOnStartUnchartedScoreLevel;
				Action<ConfigDataScoreLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataScoreLevelInfo>>(ref this.EventOnStartUnchartedScoreLevel, (Action<ConfigDataScoreLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000486 RID: 1158
		// (add) Token: 0x060147DA RID: 83930 RVA: 0x00534F80 File Offset: 0x00533180
		// (remove) Token: 0x060147DB RID: 83931 RVA: 0x0053501C File Offset: 0x0053321C
		public event Action<ConfigDataChallengeLevelInfo> EventOnStartUnchartedChallengeLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartUnchartedChallengeLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartUnchartedChallengeLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataChallengeLevelInfo> action = this.EventOnStartUnchartedChallengeLevel;
				Action<ConfigDataChallengeLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataChallengeLevelInfo>>(ref this.EventOnStartUnchartedChallengeLevel, (Action<ConfigDataChallengeLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartUnchartedChallengeLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartUnchartedChallengeLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataChallengeLevelInfo> action = this.EventOnStartUnchartedChallengeLevel;
				Action<ConfigDataChallengeLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataChallengeLevelInfo>>(ref this.EventOnStartUnchartedChallengeLevel, (Action<ConfigDataChallengeLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x060147DC RID: 83932 RVA: 0x005350B8 File Offset: 0x005332B8
		// (set) Token: 0x060147DD RID: 83933 RVA: 0x005350D8 File Offset: 0x005332D8
		[DoNotToLua]
		public new UnchartedScoreUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060147DE RID: 83934 RVA: 0x005350E4 File Offset: 0x005332E4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060147DF RID: 83935 RVA: 0x005350F0 File Offset: 0x005332F0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060147E0 RID: 83936 RVA: 0x005350F8 File Offset: 0x005332F8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060147E1 RID: 83937 RVA: 0x00535100 File Offset: 0x00533300
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060147E2 RID: 83938 RVA: 0x00535114 File Offset: 0x00533314
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060147E3 RID: 83939 RVA: 0x0053511C File Offset: 0x0053331C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060147E4 RID: 83940 RVA: 0x00535128 File Offset: 0x00533328
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060147E5 RID: 83941 RVA: 0x00535134 File Offset: 0x00533334
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060147E6 RID: 83942 RVA: 0x00535140 File Offset: 0x00533340
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060147E7 RID: 83943 RVA: 0x0053514C File Offset: 0x0053334C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060147E8 RID: 83944 RVA: 0x00535158 File Offset: 0x00533358
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060147E9 RID: 83945 RVA: 0x00535164 File Offset: 0x00533364
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060147EA RID: 83946 RVA: 0x00535170 File Offset: 0x00533370
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060147EB RID: 83947 RVA: 0x0053517C File Offset: 0x0053337C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060147EC RID: 83948 RVA: 0x00535188 File Offset: 0x00533388
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060147ED RID: 83949 RVA: 0x00535190 File Offset: 0x00533390
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x060147EE RID: 83950 RVA: 0x005351B0 File Offset: 0x005333B0
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060147EF RID: 83951 RVA: 0x005351BC File Offset: 0x005333BC
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x060147F0 RID: 83952 RVA: 0x005351DC File Offset: 0x005333DC
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x060147F1 RID: 83953 RVA: 0x005351E8 File Offset: 0x005333E8
		private void __callDele_EventOnShowTeam()
		{
			Action eventOnShowTeam = this.EventOnShowTeam;
			if (eventOnShowTeam != null)
			{
				eventOnShowTeam();
			}
		}

		// Token: 0x060147F2 RID: 83954 RVA: 0x00535208 File Offset: 0x00533408
		private void __clearDele_EventOnShowTeam()
		{
			this.EventOnShowTeam = null;
		}

		// Token: 0x060147F3 RID: 83955 RVA: 0x00535214 File Offset: 0x00533414
		private void __callDele_EventOnChangeBattleType(BattleType obj)
		{
			Action<BattleType> eventOnChangeBattleType = this.EventOnChangeBattleType;
			if (eventOnChangeBattleType != null)
			{
				eventOnChangeBattleType(obj);
			}
		}

		// Token: 0x060147F4 RID: 83956 RVA: 0x00535238 File Offset: 0x00533438
		private void __clearDele_EventOnChangeBattleType(BattleType obj)
		{
			this.EventOnChangeBattleType = null;
		}

		// Token: 0x060147F5 RID: 83957 RVA: 0x00535244 File Offset: 0x00533444
		private void __callDele_EventOnStartUnchartedScoreLevel(ConfigDataScoreLevelInfo obj)
		{
			Action<ConfigDataScoreLevelInfo> eventOnStartUnchartedScoreLevel = this.EventOnStartUnchartedScoreLevel;
			if (eventOnStartUnchartedScoreLevel != null)
			{
				eventOnStartUnchartedScoreLevel(obj);
			}
		}

		// Token: 0x060147F6 RID: 83958 RVA: 0x00535268 File Offset: 0x00533468
		private void __clearDele_EventOnStartUnchartedScoreLevel(ConfigDataScoreLevelInfo obj)
		{
			this.EventOnStartUnchartedScoreLevel = null;
		}

		// Token: 0x060147F7 RID: 83959 RVA: 0x00535274 File Offset: 0x00533474
		private void __callDele_EventOnStartUnchartedChallengeLevel(ConfigDataChallengeLevelInfo obj)
		{
			Action<ConfigDataChallengeLevelInfo> eventOnStartUnchartedChallengeLevel = this.EventOnStartUnchartedChallengeLevel;
			if (eventOnStartUnchartedChallengeLevel != null)
			{
				eventOnStartUnchartedChallengeLevel(obj);
			}
		}

		// Token: 0x060147F8 RID: 83960 RVA: 0x00535298 File Offset: 0x00533498
		private void __clearDele_EventOnStartUnchartedChallengeLevel(ConfigDataChallengeLevelInfo obj)
		{
			this.EventOnStartUnchartedChallengeLevel = null;
		}

		// Token: 0x060147F9 RID: 83961 RVA: 0x005352A4 File Offset: 0x005334A4
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
					this.m_SetBattleTypeBattleType_hotfix = (luaObj.RawGet("SetBattleType") as LuaFunction);
					this.m_SetScoreInt32_hotfix = (luaObj.RawGet("SetScore") as LuaFunction);
					this.m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfoConfigDataUnchartedScoreModelInfo_hotfix = (luaObj.RawGet("SetUnchartedScoreInfo") as LuaFunction);
					this.m_SetAllUnchartedScoreLevelListItemsIEnumerable`1_hotfix = (luaObj.RawGet("SetAllUnchartedScoreLevelListItems") as LuaFunction);
					this.m_SetAllUnchartedChallengeLevelListItemsIEnumerable`1_hotfix = (luaObj.RawGet("SetAllUnchartedChallengeLevelListItems") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataUnchartedScoreModelInfo_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_SetDailyRewardCountInt32Int32_hotfix = (luaObj.RawGet("SetDailyRewardCount") as LuaFunction);
					this.m_ShowScoreReward_hotfix = (luaObj.RawGet("ShowScoreReward") as LuaFunction);
					this.m_Co_ScrollToItemScrollRectInt32Int32_hotfix = (luaObj.RawGet("Co_ScrollToItem") as LuaFunction);
					this.m_HideScoreReward_hotfix = (luaObj.RawGet("HideScoreReward") as LuaFunction);
					this.m_ShowRecommendHero_hotfix = (luaObj.RawGet("ShowRecommendHero") as LuaFunction);
					this.m_HideRecommendHero_hotfix = (luaObj.RawGet("HideRecommendHero") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnTeamButtonClick_hotfix = (luaObj.RawGet("OnTeamButtonClick") as LuaFunction);
					this.m_OnRewardButtonClick_hotfix = (luaObj.RawGet("OnRewardButtonClick") as LuaFunction);
					this.m_OnRecommendHeroButtonClick_hotfix = (luaObj.RawGet("OnRecommendHeroButtonClick") as LuaFunction);
					this.m_OnScoreLevelToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnScoreLevelToggleValueChanged") as LuaFunction);
					this.m_OnChallengeLevelToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnChallengeLevelToggleValueChanged") as LuaFunction);
					this.m_OnScoreRewardCloseButtonClick_hotfix = (luaObj.RawGet("OnScoreRewardCloseButtonClick") as LuaFunction);
					this.m_OnRecommendHeroBGButtonClick_hotfix = (luaObj.RawGet("OnRecommendHeroBGButtonClick") as LuaFunction);
					this.m_UnchartedScoreLevelListItem_OnStartButtonClickUnchartedScoreLevelListItemUIController_hotfix = (luaObj.RawGet("UnchartedScoreLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnShowTeamAction_hotfix = (luaObj.RawGet("add_EventOnShowTeam") as LuaFunction);
					this.m_remove_EventOnShowTeamAction_hotfix = (luaObj.RawGet("remove_EventOnShowTeam") as LuaFunction);
					this.m_add_EventOnChangeBattleTypeAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeBattleType") as LuaFunction);
					this.m_remove_EventOnChangeBattleTypeAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeBattleType") as LuaFunction);
					this.m_add_EventOnStartUnchartedScoreLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartUnchartedScoreLevel") as LuaFunction);
					this.m_remove_EventOnStartUnchartedScoreLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartUnchartedScoreLevel") as LuaFunction);
					this.m_add_EventOnStartUnchartedChallengeLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartUnchartedChallengeLevel") as LuaFunction);
					this.m_remove_EventOnStartUnchartedChallengeLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartUnchartedChallengeLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060147FA RID: 83962 RVA: 0x005356F4 File Offset: 0x005338F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B445 RID: 46149
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B446 RID: 46150
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400B447 RID: 46151
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400B448 RID: 46152
		[AutoBind("./OrganizeTeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_teamButton;

		// Token: 0x0400B449 RID: 46153
		[AutoBind("./PlayerResource/DailyReward/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dailyRewardCountText;

		// Token: 0x0400B44A RID: 46154
		[AutoBind("./ActivitiesName/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_activityNameText;

		// Token: 0x0400B44B RID: 46155
		[AutoBind("./ActivityInfo", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_activityUIStateController;

		// Token: 0x0400B44C RID: 46156
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGo;

		// Token: 0x0400B44D RID: 46157
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x0400B44E RID: 46158
		[AutoBind("./LevelList/ToggleGroup/ScoreToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_scoreLevelToggle;

		// Token: 0x0400B44F RID: 46159
		[AutoBind("./LevelList/ToggleGroup/ChallengeToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_challengeLevelToggle;

		// Token: 0x0400B450 RID: 46160
		[AutoBind("./RewardGroup/RewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rewardButton;

		// Token: 0x0400B451 RID: 46161
		[AutoBind("./RewardGroup/RecommendHeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_recommendHeroButton;

		// Token: 0x0400B452 RID: 46162
		[AutoBind("./RewardGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scoreText;

		// Token: 0x0400B453 RID: 46163
		[AutoBind("./RewardPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_scoreRewardUIStateController;

		// Token: 0x0400B454 RID: 46164
		[AutoBind("./RewardPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_scoreRewardBGButton;

		// Token: 0x0400B455 RID: 46165
		[AutoBind("./RewardPanel/Detail/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_scoreRewardScollRect;

		// Token: 0x0400B456 RID: 46166
		[AutoBind("./RewardPanel/Detail/CountScore/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scoreRewardScoreNameText;

		// Token: 0x0400B457 RID: 46167
		[AutoBind("./RewardPanel/Detail/CountScore/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_scoreRewardScoreText;

		// Token: 0x0400B458 RID: 46168
		[AutoBind("./RecommendHeroPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_recommendHeroUIStateController;

		// Token: 0x0400B459 RID: 46169
		[AutoBind("./RecommendHeroPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_recommendHeroBGButton;

		// Token: 0x0400B45A RID: 46170
		[AutoBind("./RecommendHeroPanel/Detail/HeroGroupScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_recommendHeroGroupScrollRect;

		// Token: 0x0400B45B RID: 46171
		[AutoBind("./RecommendHeroPanel/Detail/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_recommendHeroDescText;

		// Token: 0x0400B45C RID: 46172
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400B45D RID: 46173
		[AutoBind("./Prefabs/UnchartedScoreLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unchartedScoreLevelListItemPrefab;

		// Token: 0x0400B45E RID: 46174
		[AutoBind("./Prefabs/RewardItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scoreRewardItemPrefab;

		// Token: 0x0400B45F RID: 46175
		[AutoBind("./Prefabs/RecommendHeroItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_recommendHeroItemPrefab;

		// Token: 0x0400B460 RID: 46176
		private bool m_isIgnoreToggleEvent;

		// Token: 0x0400B461 RID: 46177
		private ConfigDataUnchartedScoreInfo m_unchartedScoreInfo;

		// Token: 0x0400B462 RID: 46178
		private UISpineGraphic m_graphic;

		// Token: 0x0400B463 RID: 46179
		[DoNotToLua]
		private UnchartedScoreUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B464 RID: 46180
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B465 RID: 46181
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B466 RID: 46182
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B467 RID: 46183
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B468 RID: 46184
		private LuaFunction m_SetBattleTypeBattleType_hotfix;

		// Token: 0x0400B469 RID: 46185
		private LuaFunction m_SetScoreInt32_hotfix;

		// Token: 0x0400B46A RID: 46186
		private LuaFunction m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfoConfigDataUnchartedScoreModelInfo_hotfix;

		// Token: 0x0400B46B RID: 46187
		private LuaFunction m_SetAllUnchartedScoreLevelListItemsIEnumerable;

		// Token: 0x0400B46C RID: 46188
		private LuaFunction m_SetAllUnchartedChallengeLevelListItemsIEnumerable;

		// Token: 0x0400B46D RID: 46189
		private LuaFunction m_CreateSpineGraphicConfigDataUnchartedScoreModelInfo_hotfix;

		// Token: 0x0400B46E RID: 46190
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x0400B46F RID: 46191
		private LuaFunction m_SetDailyRewardCountInt32Int32_hotfix;

		// Token: 0x0400B470 RID: 46192
		private LuaFunction m_ShowScoreReward_hotfix;

		// Token: 0x0400B471 RID: 46193
		private LuaFunction m_Co_ScrollToItemScrollRectInt32Int32_hotfix;

		// Token: 0x0400B472 RID: 46194
		private LuaFunction m_HideScoreReward_hotfix;

		// Token: 0x0400B473 RID: 46195
		private LuaFunction m_ShowRecommendHero_hotfix;

		// Token: 0x0400B474 RID: 46196
		private LuaFunction m_HideRecommendHero_hotfix;

		// Token: 0x0400B475 RID: 46197
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400B476 RID: 46198
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400B477 RID: 46199
		private LuaFunction m_OnTeamButtonClick_hotfix;

		// Token: 0x0400B478 RID: 46200
		private LuaFunction m_OnRewardButtonClick_hotfix;

		// Token: 0x0400B479 RID: 46201
		private LuaFunction m_OnRecommendHeroButtonClick_hotfix;

		// Token: 0x0400B47A RID: 46202
		private LuaFunction m_OnScoreLevelToggleValueChangedBoolean_hotfix;

		// Token: 0x0400B47B RID: 46203
		private LuaFunction m_OnChallengeLevelToggleValueChangedBoolean_hotfix;

		// Token: 0x0400B47C RID: 46204
		private LuaFunction m_OnScoreRewardCloseButtonClick_hotfix;

		// Token: 0x0400B47D RID: 46205
		private LuaFunction m_OnRecommendHeroBGButtonClick_hotfix;

		// Token: 0x0400B47E RID: 46206
		private LuaFunction m_UnchartedScoreLevelListItem_OnStartButtonClickUnchartedScoreLevelListItemUIController_hotfix;

		// Token: 0x0400B47F RID: 46207
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400B480 RID: 46208
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400B481 RID: 46209
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400B482 RID: 46210
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400B483 RID: 46211
		private LuaFunction m_add_EventOnShowTeamAction_hotfix;

		// Token: 0x0400B484 RID: 46212
		private LuaFunction m_remove_EventOnShowTeamAction_hotfix;

		// Token: 0x0400B485 RID: 46213
		private LuaFunction m_add_EventOnChangeBattleTypeAction;

		// Token: 0x0400B486 RID: 46214
		private LuaFunction m_remove_EventOnChangeBattleTypeAction;

		// Token: 0x0400B487 RID: 46215
		private LuaFunction m_add_EventOnStartUnchartedScoreLevelAction;

		// Token: 0x0400B488 RID: 46216
		private LuaFunction m_remove_EventOnStartUnchartedScoreLevelAction;

		// Token: 0x0400B489 RID: 46217
		private LuaFunction m_add_EventOnStartUnchartedChallengeLevelAction;

		// Token: 0x0400B48A RID: 46218
		private LuaFunction m_remove_EventOnStartUnchartedChallengeLevelAction;

		// Token: 0x02000FF3 RID: 4083
		public new class LuaExportHelper
		{
			// Token: 0x060147FB RID: 83963 RVA: 0x0053575C File Offset: 0x0053395C
			public LuaExportHelper(UnchartedScoreUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060147FC RID: 83964 RVA: 0x0053576C File Offset: 0x0053396C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060147FD RID: 83965 RVA: 0x0053577C File Offset: 0x0053397C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060147FE RID: 83966 RVA: 0x0053578C File Offset: 0x0053398C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060147FF RID: 83967 RVA: 0x0053579C File Offset: 0x0053399C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014800 RID: 83968 RVA: 0x005357B4 File Offset: 0x005339B4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014801 RID: 83969 RVA: 0x005357C4 File Offset: 0x005339C4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014802 RID: 83970 RVA: 0x005357D4 File Offset: 0x005339D4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014803 RID: 83971 RVA: 0x005357E4 File Offset: 0x005339E4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014804 RID: 83972 RVA: 0x005357F4 File Offset: 0x005339F4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014805 RID: 83973 RVA: 0x00535804 File Offset: 0x00533A04
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014806 RID: 83974 RVA: 0x00535814 File Offset: 0x00533A14
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014807 RID: 83975 RVA: 0x00535824 File Offset: 0x00533A24
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014808 RID: 83976 RVA: 0x00535834 File Offset: 0x00533A34
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014809 RID: 83977 RVA: 0x00535844 File Offset: 0x00533A44
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601480A RID: 83978 RVA: 0x00535854 File Offset: 0x00533A54
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601480B RID: 83979 RVA: 0x00535864 File Offset: 0x00533A64
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0601480C RID: 83980 RVA: 0x00535874 File Offset: 0x00533A74
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0601480D RID: 83981 RVA: 0x00535884 File Offset: 0x00533A84
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0601480E RID: 83982 RVA: 0x00535894 File Offset: 0x00533A94
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0601480F RID: 83983 RVA: 0x005358A4 File Offset: 0x00533AA4
			public void __callDele_EventOnShowTeam()
			{
				this.m_owner.__callDele_EventOnShowTeam();
			}

			// Token: 0x06014810 RID: 83984 RVA: 0x005358B4 File Offset: 0x00533AB4
			public void __clearDele_EventOnShowTeam()
			{
				this.m_owner.__clearDele_EventOnShowTeam();
			}

			// Token: 0x06014811 RID: 83985 RVA: 0x005358C4 File Offset: 0x00533AC4
			public void __callDele_EventOnChangeBattleType(BattleType obj)
			{
				this.m_owner.__callDele_EventOnChangeBattleType(obj);
			}

			// Token: 0x06014812 RID: 83986 RVA: 0x005358D4 File Offset: 0x00533AD4
			public void __clearDele_EventOnChangeBattleType(BattleType obj)
			{
				this.m_owner.__clearDele_EventOnChangeBattleType(obj);
			}

			// Token: 0x06014813 RID: 83987 RVA: 0x005358E4 File Offset: 0x00533AE4
			public void __callDele_EventOnStartUnchartedScoreLevel(ConfigDataScoreLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartUnchartedScoreLevel(obj);
			}

			// Token: 0x06014814 RID: 83988 RVA: 0x005358F4 File Offset: 0x00533AF4
			public void __clearDele_EventOnStartUnchartedScoreLevel(ConfigDataScoreLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartUnchartedScoreLevel(obj);
			}

			// Token: 0x06014815 RID: 83989 RVA: 0x00535904 File Offset: 0x00533B04
			public void __callDele_EventOnStartUnchartedChallengeLevel(ConfigDataChallengeLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartUnchartedChallengeLevel(obj);
			}

			// Token: 0x06014816 RID: 83990 RVA: 0x00535914 File Offset: 0x00533B14
			public void __clearDele_EventOnStartUnchartedChallengeLevel(ConfigDataChallengeLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartUnchartedChallengeLevel(obj);
			}

			// Token: 0x17003CB3 RID: 15539
			// (get) Token: 0x06014817 RID: 83991 RVA: 0x00535924 File Offset: 0x00533B24
			// (set) Token: 0x06014818 RID: 83992 RVA: 0x00535934 File Offset: 0x00533B34
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

			// Token: 0x17003CB4 RID: 15540
			// (get) Token: 0x06014819 RID: 83993 RVA: 0x00535944 File Offset: 0x00533B44
			// (set) Token: 0x0601481A RID: 83994 RVA: 0x00535954 File Offset: 0x00533B54
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

			// Token: 0x17003CB5 RID: 15541
			// (get) Token: 0x0601481B RID: 83995 RVA: 0x00535964 File Offset: 0x00533B64
			// (set) Token: 0x0601481C RID: 83996 RVA: 0x00535974 File Offset: 0x00533B74
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17003CB6 RID: 15542
			// (get) Token: 0x0601481D RID: 83997 RVA: 0x00535984 File Offset: 0x00533B84
			// (set) Token: 0x0601481E RID: 83998 RVA: 0x00535994 File Offset: 0x00533B94
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

			// Token: 0x17003CB7 RID: 15543
			// (get) Token: 0x0601481F RID: 83999 RVA: 0x005359A4 File Offset: 0x00533BA4
			// (set) Token: 0x06014820 RID: 84000 RVA: 0x005359B4 File Offset: 0x00533BB4
			public Text m_dailyRewardCountText
			{
				get
				{
					return this.m_owner.m_dailyRewardCountText;
				}
				set
				{
					this.m_owner.m_dailyRewardCountText = value;
				}
			}

			// Token: 0x17003CB8 RID: 15544
			// (get) Token: 0x06014821 RID: 84001 RVA: 0x005359C4 File Offset: 0x00533BC4
			// (set) Token: 0x06014822 RID: 84002 RVA: 0x005359D4 File Offset: 0x00533BD4
			public Text m_activityNameText
			{
				get
				{
					return this.m_owner.m_activityNameText;
				}
				set
				{
					this.m_owner.m_activityNameText = value;
				}
			}

			// Token: 0x17003CB9 RID: 15545
			// (get) Token: 0x06014823 RID: 84003 RVA: 0x005359E4 File Offset: 0x00533BE4
			// (set) Token: 0x06014824 RID: 84004 RVA: 0x005359F4 File Offset: 0x00533BF4
			public CommonUIStateController m_activityUIStateController
			{
				get
				{
					return this.m_owner.m_activityUIStateController;
				}
				set
				{
					this.m_owner.m_activityUIStateController = value;
				}
			}

			// Token: 0x17003CBA RID: 15546
			// (get) Token: 0x06014825 RID: 84005 RVA: 0x00535A04 File Offset: 0x00533C04
			// (set) Token: 0x06014826 RID: 84006 RVA: 0x00535A14 File Offset: 0x00533C14
			public GameObject m_charGo
			{
				get
				{
					return this.m_owner.m_charGo;
				}
				set
				{
					this.m_owner.m_charGo = value;
				}
			}

			// Token: 0x17003CBB RID: 15547
			// (get) Token: 0x06014827 RID: 84007 RVA: 0x00535A24 File Offset: 0x00533C24
			// (set) Token: 0x06014828 RID: 84008 RVA: 0x00535A34 File Offset: 0x00533C34
			public ScrollRect m_levelListScrollRect
			{
				get
				{
					return this.m_owner.m_levelListScrollRect;
				}
				set
				{
					this.m_owner.m_levelListScrollRect = value;
				}
			}

			// Token: 0x17003CBC RID: 15548
			// (get) Token: 0x06014829 RID: 84009 RVA: 0x00535A44 File Offset: 0x00533C44
			// (set) Token: 0x0601482A RID: 84010 RVA: 0x00535A54 File Offset: 0x00533C54
			public Toggle m_scoreLevelToggle
			{
				get
				{
					return this.m_owner.m_scoreLevelToggle;
				}
				set
				{
					this.m_owner.m_scoreLevelToggle = value;
				}
			}

			// Token: 0x17003CBD RID: 15549
			// (get) Token: 0x0601482B RID: 84011 RVA: 0x00535A64 File Offset: 0x00533C64
			// (set) Token: 0x0601482C RID: 84012 RVA: 0x00535A74 File Offset: 0x00533C74
			public Toggle m_challengeLevelToggle
			{
				get
				{
					return this.m_owner.m_challengeLevelToggle;
				}
				set
				{
					this.m_owner.m_challengeLevelToggle = value;
				}
			}

			// Token: 0x17003CBE RID: 15550
			// (get) Token: 0x0601482D RID: 84013 RVA: 0x00535A84 File Offset: 0x00533C84
			// (set) Token: 0x0601482E RID: 84014 RVA: 0x00535A94 File Offset: 0x00533C94
			public Button m_rewardButton
			{
				get
				{
					return this.m_owner.m_rewardButton;
				}
				set
				{
					this.m_owner.m_rewardButton = value;
				}
			}

			// Token: 0x17003CBF RID: 15551
			// (get) Token: 0x0601482F RID: 84015 RVA: 0x00535AA4 File Offset: 0x00533CA4
			// (set) Token: 0x06014830 RID: 84016 RVA: 0x00535AB4 File Offset: 0x00533CB4
			public Button m_recommendHeroButton
			{
				get
				{
					return this.m_owner.m_recommendHeroButton;
				}
				set
				{
					this.m_owner.m_recommendHeroButton = value;
				}
			}

			// Token: 0x17003CC0 RID: 15552
			// (get) Token: 0x06014831 RID: 84017 RVA: 0x00535AC4 File Offset: 0x00533CC4
			// (set) Token: 0x06014832 RID: 84018 RVA: 0x00535AD4 File Offset: 0x00533CD4
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

			// Token: 0x17003CC1 RID: 15553
			// (get) Token: 0x06014833 RID: 84019 RVA: 0x00535AE4 File Offset: 0x00533CE4
			// (set) Token: 0x06014834 RID: 84020 RVA: 0x00535AF4 File Offset: 0x00533CF4
			public CommonUIStateController m_scoreRewardUIStateController
			{
				get
				{
					return this.m_owner.m_scoreRewardUIStateController;
				}
				set
				{
					this.m_owner.m_scoreRewardUIStateController = value;
				}
			}

			// Token: 0x17003CC2 RID: 15554
			// (get) Token: 0x06014835 RID: 84021 RVA: 0x00535B04 File Offset: 0x00533D04
			// (set) Token: 0x06014836 RID: 84022 RVA: 0x00535B14 File Offset: 0x00533D14
			public Button m_scoreRewardBGButton
			{
				get
				{
					return this.m_owner.m_scoreRewardBGButton;
				}
				set
				{
					this.m_owner.m_scoreRewardBGButton = value;
				}
			}

			// Token: 0x17003CC3 RID: 15555
			// (get) Token: 0x06014837 RID: 84023 RVA: 0x00535B24 File Offset: 0x00533D24
			// (set) Token: 0x06014838 RID: 84024 RVA: 0x00535B34 File Offset: 0x00533D34
			public ScrollRect m_scoreRewardScollRect
			{
				get
				{
					return this.m_owner.m_scoreRewardScollRect;
				}
				set
				{
					this.m_owner.m_scoreRewardScollRect = value;
				}
			}

			// Token: 0x17003CC4 RID: 15556
			// (get) Token: 0x06014839 RID: 84025 RVA: 0x00535B44 File Offset: 0x00533D44
			// (set) Token: 0x0601483A RID: 84026 RVA: 0x00535B54 File Offset: 0x00533D54
			public Text m_scoreRewardScoreNameText
			{
				get
				{
					return this.m_owner.m_scoreRewardScoreNameText;
				}
				set
				{
					this.m_owner.m_scoreRewardScoreNameText = value;
				}
			}

			// Token: 0x17003CC5 RID: 15557
			// (get) Token: 0x0601483B RID: 84027 RVA: 0x00535B64 File Offset: 0x00533D64
			// (set) Token: 0x0601483C RID: 84028 RVA: 0x00535B74 File Offset: 0x00533D74
			public Text m_scoreRewardScoreText
			{
				get
				{
					return this.m_owner.m_scoreRewardScoreText;
				}
				set
				{
					this.m_owner.m_scoreRewardScoreText = value;
				}
			}

			// Token: 0x17003CC6 RID: 15558
			// (get) Token: 0x0601483D RID: 84029 RVA: 0x00535B84 File Offset: 0x00533D84
			// (set) Token: 0x0601483E RID: 84030 RVA: 0x00535B94 File Offset: 0x00533D94
			public CommonUIStateController m_recommendHeroUIStateController
			{
				get
				{
					return this.m_owner.m_recommendHeroUIStateController;
				}
				set
				{
					this.m_owner.m_recommendHeroUIStateController = value;
				}
			}

			// Token: 0x17003CC7 RID: 15559
			// (get) Token: 0x0601483F RID: 84031 RVA: 0x00535BA4 File Offset: 0x00533DA4
			// (set) Token: 0x06014840 RID: 84032 RVA: 0x00535BB4 File Offset: 0x00533DB4
			public Button m_recommendHeroBGButton
			{
				get
				{
					return this.m_owner.m_recommendHeroBGButton;
				}
				set
				{
					this.m_owner.m_recommendHeroBGButton = value;
				}
			}

			// Token: 0x17003CC8 RID: 15560
			// (get) Token: 0x06014841 RID: 84033 RVA: 0x00535BC4 File Offset: 0x00533DC4
			// (set) Token: 0x06014842 RID: 84034 RVA: 0x00535BD4 File Offset: 0x00533DD4
			public ScrollRect m_recommendHeroGroupScrollRect
			{
				get
				{
					return this.m_owner.m_recommendHeroGroupScrollRect;
				}
				set
				{
					this.m_owner.m_recommendHeroGroupScrollRect = value;
				}
			}

			// Token: 0x17003CC9 RID: 15561
			// (get) Token: 0x06014843 RID: 84035 RVA: 0x00535BE4 File Offset: 0x00533DE4
			// (set) Token: 0x06014844 RID: 84036 RVA: 0x00535BF4 File Offset: 0x00533DF4
			public Text m_recommendHeroDescText
			{
				get
				{
					return this.m_owner.m_recommendHeroDescText;
				}
				set
				{
					this.m_owner.m_recommendHeroDescText = value;
				}
			}

			// Token: 0x17003CCA RID: 15562
			// (get) Token: 0x06014845 RID: 84037 RVA: 0x00535C04 File Offset: 0x00533E04
			// (set) Token: 0x06014846 RID: 84038 RVA: 0x00535C14 File Offset: 0x00533E14
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

			// Token: 0x17003CCB RID: 15563
			// (get) Token: 0x06014847 RID: 84039 RVA: 0x00535C24 File Offset: 0x00533E24
			// (set) Token: 0x06014848 RID: 84040 RVA: 0x00535C34 File Offset: 0x00533E34
			public GameObject m_unchartedScoreLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_unchartedScoreLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_unchartedScoreLevelListItemPrefab = value;
				}
			}

			// Token: 0x17003CCC RID: 15564
			// (get) Token: 0x06014849 RID: 84041 RVA: 0x00535C44 File Offset: 0x00533E44
			// (set) Token: 0x0601484A RID: 84042 RVA: 0x00535C54 File Offset: 0x00533E54
			public GameObject m_scoreRewardItemPrefab
			{
				get
				{
					return this.m_owner.m_scoreRewardItemPrefab;
				}
				set
				{
					this.m_owner.m_scoreRewardItemPrefab = value;
				}
			}

			// Token: 0x17003CCD RID: 15565
			// (get) Token: 0x0601484B RID: 84043 RVA: 0x00535C64 File Offset: 0x00533E64
			// (set) Token: 0x0601484C RID: 84044 RVA: 0x00535C74 File Offset: 0x00533E74
			public GameObject m_recommendHeroItemPrefab
			{
				get
				{
					return this.m_owner.m_recommendHeroItemPrefab;
				}
				set
				{
					this.m_owner.m_recommendHeroItemPrefab = value;
				}
			}

			// Token: 0x17003CCE RID: 15566
			// (get) Token: 0x0601484D RID: 84045 RVA: 0x00535C84 File Offset: 0x00533E84
			// (set) Token: 0x0601484E RID: 84046 RVA: 0x00535C94 File Offset: 0x00533E94
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x17003CCF RID: 15567
			// (get) Token: 0x0601484F RID: 84047 RVA: 0x00535CA4 File Offset: 0x00533EA4
			// (set) Token: 0x06014850 RID: 84048 RVA: 0x00535CB4 File Offset: 0x00533EB4
			public ConfigDataUnchartedScoreInfo m_unchartedScoreInfo
			{
				get
				{
					return this.m_owner.m_unchartedScoreInfo;
				}
				set
				{
					this.m_owner.m_unchartedScoreInfo = value;
				}
			}

			// Token: 0x17003CD0 RID: 15568
			// (get) Token: 0x06014851 RID: 84049 RVA: 0x00535CC4 File Offset: 0x00533EC4
			// (set) Token: 0x06014852 RID: 84050 RVA: 0x00535CD4 File Offset: 0x00533ED4
			public UISpineGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x06014853 RID: 84051 RVA: 0x00535CE4 File Offset: 0x00533EE4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014854 RID: 84052 RVA: 0x00535CF4 File Offset: 0x00533EF4
			public void CreateSpineGraphic(ConfigDataUnchartedScoreModelInfo unchartedScoreModelInfo)
			{
				this.m_owner.CreateSpineGraphic(unchartedScoreModelInfo);
			}

			// Token: 0x06014855 RID: 84053 RVA: 0x00535D04 File Offset: 0x00533F04
			public void DestroySpineGraphic()
			{
				this.m_owner.DestroySpineGraphic();
			}

			// Token: 0x06014856 RID: 84054 RVA: 0x00535D14 File Offset: 0x00533F14
			public IEnumerator Co_ScrollToItem(ScrollRect scrollRect, int itemCount, int idx)
			{
				return this.m_owner.Co_ScrollToItem(scrollRect, itemCount, idx);
			}

			// Token: 0x06014857 RID: 84055 RVA: 0x00535D24 File Offset: 0x00533F24
			public static void ScrollToItem(ScrollRect scrollRect, int itemCount, int idx)
			{
				UnchartedScoreUIController.ScrollToItem(scrollRect, itemCount, idx);
			}

			// Token: 0x06014858 RID: 84056 RVA: 0x00535D30 File Offset: 0x00533F30
			public void HideScoreReward()
			{
				this.m_owner.HideScoreReward();
			}

			// Token: 0x06014859 RID: 84057 RVA: 0x00535D40 File Offset: 0x00533F40
			public void HideRecommendHero()
			{
				this.m_owner.HideRecommendHero();
			}

			// Token: 0x0601485A RID: 84058 RVA: 0x00535D50 File Offset: 0x00533F50
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0601485B RID: 84059 RVA: 0x00535D60 File Offset: 0x00533F60
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0601485C RID: 84060 RVA: 0x00535D70 File Offset: 0x00533F70
			public void OnTeamButtonClick()
			{
				this.m_owner.OnTeamButtonClick();
			}

			// Token: 0x0601485D RID: 84061 RVA: 0x00535D80 File Offset: 0x00533F80
			public void OnRewardButtonClick()
			{
				this.m_owner.OnRewardButtonClick();
			}

			// Token: 0x0601485E RID: 84062 RVA: 0x00535D90 File Offset: 0x00533F90
			public void OnRecommendHeroButtonClick()
			{
				this.m_owner.OnRecommendHeroButtonClick();
			}

			// Token: 0x0601485F RID: 84063 RVA: 0x00535DA0 File Offset: 0x00533FA0
			public void OnScoreLevelToggleValueChanged(bool on)
			{
				this.m_owner.OnScoreLevelToggleValueChanged(on);
			}

			// Token: 0x06014860 RID: 84064 RVA: 0x00535DB0 File Offset: 0x00533FB0
			public void OnChallengeLevelToggleValueChanged(bool on)
			{
				this.m_owner.OnChallengeLevelToggleValueChanged(on);
			}

			// Token: 0x06014861 RID: 84065 RVA: 0x00535DC0 File Offset: 0x00533FC0
			public void OnScoreRewardCloseButtonClick()
			{
				this.m_owner.OnScoreRewardCloseButtonClick();
			}

			// Token: 0x06014862 RID: 84066 RVA: 0x00535DD0 File Offset: 0x00533FD0
			public void OnRecommendHeroBGButtonClick()
			{
				this.m_owner.OnRecommendHeroBGButtonClick();
			}

			// Token: 0x06014863 RID: 84067 RVA: 0x00535DE0 File Offset: 0x00533FE0
			public void UnchartedScoreLevelListItem_OnStartButtonClick(UnchartedScoreLevelListItemUIController ctrl)
			{
				this.m_owner.UnchartedScoreLevelListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x0400B48B RID: 46219
			private UnchartedScoreUIController m_owner;
		}
	}
}
