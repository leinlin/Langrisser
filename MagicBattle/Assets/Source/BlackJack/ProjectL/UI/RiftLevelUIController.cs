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
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EDD RID: 3805
	[HotFix]
	public class RiftLevelUIController : UIControllerBase
	{
		// Token: 0x06012B2E RID: 76590 RVA: 0x004C9124 File Offset: 0x004C7324
		private RiftLevelUIController()
		{
		}

		// Token: 0x06012B2F RID: 76591 RVA: 0x004C9184 File Offset: 0x004C7384
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
			this.m_worldButton.onClick.AddListener(new UnityAction(this.OnWorldButtonClick));
			this.m_hardButton.onClick.AddListener(new UnityAction(this.OnHardButtonClick));
			this.m_starRewardButtons = new GainRewardButton[3];
			this.m_starRewardButtons[0] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_starRewardButton1GameObject);
			this.m_starRewardButtons[0].SetId(1);
			this.m_starRewardButtons[0].EventOnClick += this.OnStarRewardButtonClick;
			this.m_starRewardButtons[1] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_starRewardButton2GameObject);
			this.m_starRewardButtons[1].SetId(2);
			this.m_starRewardButtons[1].EventOnClick += this.OnStarRewardButtonClick;
			this.m_starRewardButtons[2] = GameObjectUtility.AddControllerToGameObject<GainRewardButton>(this.m_starRewardButton3GameObject);
			this.m_starRewardButtons[2].SetId(3);
			this.m_starRewardButtons[2].EventOnClick += this.OnStarRewardButtonClick;
			this.m_starRewardPreviewUIStateController.gameObject.SetActive(false);
			this.m_starRewardPreviewBackgroundButton.onClick.AddListener(new UnityAction(this.OnStarRewardPreviewBackgroundButtonClick));
			this.m_unlockConditionUIStateController.gameObject.SetActive(false);
			this.m_unlockConditionBackgroundButton.onClick.AddListener(new UnityAction(this.OnUnlockConditionBackgroundButtonClick));
			this.m_riftLevelButtonPrefab.SetActive(true);
			this.m_eventRiftLevelButtonPrefab.SetActive(true);
			this.m_riftLevelUnlockConditionItemPrefab.SetActive(true);
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06012B30 RID: 76592 RVA: 0x004C93AC File Offset: 0x004C75AC
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

		// Token: 0x06012B31 RID: 76593 RVA: 0x004C9420 File Offset: 0x004C7620
		public void SetChapter(ConfigDataRiftChapterInfo chapterInfo, bool canSwitchHard)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChapterConfigDataRiftChapterInfoBoolean_hotfix != null)
			{
				this.m_SetChapterConfigDataRiftChapterInfoBoolean_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					canSwitchHard
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chapterInfo == null)
			{
				return;
			}
			GameObjectUtility.DestroyChildren(this.m_chapterBGObject);
			if (!string.IsNullOrEmpty(chapterInfo.ChapterBGPrefabName))
			{
				GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(chapterInfo.ChapterBGPrefabName);
				this.m_createChapterBGObject = UnityEngine.Object.Instantiate<GameObject>(asset, this.m_chapterBGObject.transform, false);
			}
			this.m_starRewardButtons[0].SetNum(chapterInfo.Reward1Star);
			this.m_starRewardButtons[1].SetNum(chapterInfo.Reward2Star);
			this.m_starRewardButtons[2].SetNum(chapterInfo.Reward3Star);
			if (chapterInfo.Hard == 1)
			{
				this.m_hardUIStateController.SetToUIState("NormalState", false, true);
			}
			else
			{
				this.m_hardUIStateController.SetToUIState("HardState", false, true);
			}
			this.m_hardButtonUIStateController.SetToUIState((!canSwitchHard) ? "Lock" : "Unlock", false, true);
			this.m_chapterInfo = chapterInfo;
		}

		// Token: 0x06012B32 RID: 76594 RVA: 0x004C9584 File Offset: 0x004C7784
		public void SetStarRewardStatus(int idx, GainRewardStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStarRewardStatusInt32GainRewardStatus_hotfix != null)
			{
				this.m_SetStarRewardStatusInt32GainRewardStatus_hotfix.call(new object[]
				{
					this,
					idx,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || idx >= this.m_starRewardButtons.Length)
			{
				return;
			}
			this.m_starRewardButtons[idx].SetStatus(status);
		}

		// Token: 0x06012B33 RID: 76595 RVA: 0x004C9628 File Offset: 0x004C7828
		public void SetStarRewardProress(int star, int allStar)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStarRewardProressInt32Int32_hotfix != null)
			{
				this.m_SetStarRewardProressInt32Int32_hotfix.call(new object[]
				{
					this,
					star,
					allStar
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_starRewardGotText.text = star.ToString();
			this.m_progressBarImage.fillAmount = (float)star / (float)allStar;
		}

		// Token: 0x06012B34 RID: 76596 RVA: 0x004C96D0 File Offset: 0x004C78D0
		public void ClearRiftLevelButtons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRiftLevelButtons_hotfix != null)
			{
				this.m_ClearRiftLevelButtons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<RiftLevelButton>(this.m_riftLevelButtons);
			this.m_riftLevelButtons.Clear();
		}

		// Token: 0x06012B35 RID: 76597 RVA: 0x004C9748 File Offset: 0x004C7948
		public void ClearEventRiftLevelButtons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearEventRiftLevelButtons_hotfix != null)
			{
				this.m_ClearEventRiftLevelButtons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<EventRiftLevelButton>(this.m_eventRiftLevelButtons);
			this.m_eventRiftLevelButtons.Clear();
		}

		// Token: 0x06012B36 RID: 76598 RVA: 0x004C97C0 File Offset: 0x004C79C0
		public void AddRiftLevelButton(ConfigDataRiftLevelInfo riftLevelInfo, RiftLevelStatus status, int challengeCount, int challengeCountMax, bool challenged, int star, int achievementCount, int treasureCount, int treasureCountMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatusInt32Int32BooleanInt32Int32Int32Int32_hotfix != null)
			{
				this.m_AddRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatusInt32Int32BooleanInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					riftLevelInfo,
					status,
					challengeCount,
					challengeCountMax,
					challenged,
					star,
					achievementCount,
					treasureCount,
					treasureCountMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (riftLevelInfo == null)
			{
				return;
			}
			if (this.m_createChapterBGObject == null)
			{
				return;
			}
			GameObject gameObject = Utility.FindChildGameObject(this.m_createChapterBGObject, "Levels/" + riftLevelInfo.OwnNum.ToString("D2"), true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_riftLevelButtonPrefab);
			if (gameObject != null)
			{
				gameObject2.transform.SetParent(gameObject.transform, false);
			}
			else
			{
				gameObject2.transform.SetParent(this.m_createChapterBGObject.transform, false);
				gameObject2.transform.localPosition = new Vector3((float)((riftLevelInfo.IconX - 2) * 280 + 150), (float)((1 - riftLevelInfo.IconY) * 220), 0f);
			}
			RiftLevelButton riftLevelButton = GameObjectUtility.AddControllerToGameObject<RiftLevelButton>(gameObject2);
			bool isNew = status == RiftLevelStatus.Open && !challenged;
			bool isClear = star >= 3 && achievementCount > 0 && achievementCount >= riftLevelInfo.m_achievements.Length;
			bool isAllTreasureGot = treasureCount >= treasureCountMax;
			riftLevelButton.SetRiftLevelInfo(riftLevelInfo);
			riftLevelButton.SetStatus(status, isNew, isClear, isAllTreasureGot);
			riftLevelButton.SetChallengeCount(challengeCount, challengeCountMax);
			riftLevelButton.SetStar(star);
			riftLevelButton.SetAchievementCount(achievementCount, riftLevelInfo.m_achievements.Length);
			riftLevelButton.EventOnClick += this.OnRiftLevelButtonClick;
			this.m_riftLevelButtons.Add(riftLevelButton);
		}

		// Token: 0x06012B37 RID: 76599 RVA: 0x004C9A0C File Offset: 0x004C7C0C
		public void AddEventRiftLevelButton(ConfigDataRiftLevelInfo riftLevelInfo, RiftLevelStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddEventRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatus_hotfix != null)
			{
				this.m_AddEventRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatus_hotfix.call(new object[]
				{
					this,
					riftLevelInfo,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (riftLevelInfo == null)
			{
				return;
			}
			if (this.m_createChapterBGObject == null)
			{
				return;
			}
			GameObject gameObject = Utility.FindChildGameObject(this.m_createChapterBGObject, "Levels/" + riftLevelInfo.OwnNum.ToString("D2"), true);
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_eventRiftLevelButtonPrefab);
			if (gameObject != null)
			{
				gameObject2.transform.SetParent(gameObject.transform, false);
			}
			else
			{
				gameObject2.transform.SetParent(this.m_createChapterBGObject.transform, false);
			}
			EventRiftLevelButton eventRiftLevelButton = GameObjectUtility.AddControllerToGameObject<EventRiftLevelButton>(gameObject2);
			eventRiftLevelButton.SetRiftLevelInfo(riftLevelInfo);
			eventRiftLevelButton.SetStatus(status);
			eventRiftLevelButton.EventOnClick += this.OnEventRiftLevelButtonClick;
			this.m_eventRiftLevelButtons.Add(eventRiftLevelButton);
		}

		// Token: 0x06012B38 RID: 76600 RVA: 0x004C9B48 File Offset: 0x004C7D48
		public void AddEventRiftLevelDummys()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddEventRiftLevelDummys_hotfix != null)
			{
				this.m_AddEventRiftLevelDummys_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_createChapterBGObject == null)
			{
				return;
			}
			GameObject gameObject = Utility.FindChildGameObject(this.m_createChapterBGObject, "Levels", true);
			if (gameObject == null)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				Transform child = gameObject.transform.GetChild(i);
				if (child.childCount == 0)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_eventRiftLevelDummyPrefab, child, false);
					CommonUIStateController component = gameObject2.GetComponent<CommonUIStateController>();
					if (component != null)
					{
						component.SetToUIState(string.Format("Effect{0}", num % 3 + 1), false, true);
					}
					num++;
				}
			}
		}

		// Token: 0x06012B39 RID: 76601 RVA: 0x004C9C58 File Offset: 0x004C7E58
		private void ClearRiftLevelUnlockContitionItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRiftLevelUnlockContitionItems_hotfix != null)
			{
				this.m_ClearRiftLevelUnlockContitionItems_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<RiftLevelUnlockConditionItemUIController>(this.m_riftLevelUnlockConditionItems);
			this.m_riftLevelUnlockConditionItems.Clear();
		}

		// Token: 0x06012B3A RID: 76602 RVA: 0x004C9CD0 File Offset: 0x004C7ED0
		private void AddRiftLevelUnlockContitionItems(ConfigDataRiftLevelInfo riftLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRiftLevelUnlockContitionItemsConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_AddRiftLevelUnlockContitionItemsConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					riftLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearRiftLevelUnlockContitionItems();
			if (riftLevelInfo.UnlockConditions != null)
			{
				foreach (RiftLevelInfoUnlockConditions riftLevelInfoUnlockConditions in riftLevelInfo.UnlockConditions)
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_riftLevelUnlockConditionItemPrefab, this.m_unlockConditionGroupGameObject.transform, false);
					RiftLevelUnlockConditionItemUIController riftLevelUnlockConditionItemUIController = GameObjectUtility.AddControllerToGameObject<RiftLevelUnlockConditionItemUIController>(go);
					riftLevelUnlockConditionItemUIController.SetCondition(riftLevelInfoUnlockConditions.ConditionType, riftLevelInfoUnlockConditions.Param1, riftLevelInfoUnlockConditions.Param2);
					riftLevelUnlockConditionItemUIController.EventOnGoToScenario += this.EventOnGoToScenario;
					riftLevelUnlockConditionItemUIController.EventOnGoToRiftLevel += this.GoToRiftLevel;
					this.m_riftLevelUnlockConditionItems.Add(riftLevelUnlockConditionItemUIController);
				}
			}
		}

		// Token: 0x06012B3B RID: 76603 RVA: 0x004C9DFC File Offset: 0x004C7FFC
		private void GoToRiftLevel(int chapterID, int levelID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoToRiftLevelInt32Int32_hotfix != null)
			{
				this.m_GoToRiftLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					chapterID,
					levelID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_unlockConditionUIStateController, "Close", null, false, true);
			ConfigDataRiftChapterInfo configDataRiftChapterInfo = this.m_configDataLoader.GetConfigDataRiftChapterInfo(chapterID);
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(levelID);
			if (configDataRiftChapterInfo != null && configDataRiftLevelInfo != null)
			{
				CommonUIController.Instance.StartCoroutine(this.Co_ShowRiftLevel(configDataRiftChapterInfo, configDataRiftLevelInfo));
			}
		}

		// Token: 0x06012B3C RID: 76604 RVA: 0x004C9EC8 File Offset: 0x004C80C8
		[DebuggerHidden]
		private IEnumerator Co_ShowRiftLevel(ConfigDataRiftChapterInfo riftChapterInfo, ConfigDataRiftLevelInfo riftLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowRiftLevelConfigDataRiftChapterInfoConfigDataRiftLevelInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowRiftLevelConfigDataRiftChapterInfoConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					riftChapterInfo,
					riftLevelInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevelUIController.<Co_ShowRiftLevel>c__Iterator0 <Co_ShowRiftLevel>c__Iterator = new RiftLevelUIController.<Co_ShowRiftLevel>c__Iterator0();
			<Co_ShowRiftLevel>c__Iterator.riftChapterInfo = riftChapterInfo;
			<Co_ShowRiftLevel>c__Iterator.riftLevelInfo = riftLevelInfo;
			<Co_ShowRiftLevel>c__Iterator.$this = this;
			return <Co_ShowRiftLevel>c__Iterator;
		}

		// Token: 0x06012B3D RID: 76605 RVA: 0x004C9F70 File Offset: 0x004C8170
		private void AddStarRewardPreviewGoods(ConfigDataRiftChapterInfo chapterInfo, int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddStarRewardPreviewGoodsConfigDataRiftChapterInfoInt32_hotfix != null)
			{
				this.m_AddStarRewardPreviewGoodsConfigDataRiftChapterInfoInt32_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chapterInfo == null)
			{
				return;
			}
			GameObjectUtility.DestroyChildren(this.m_starRewardPreviewScrollRect.content.gameObject);
			List<Goods> list = null;
			if (idx == 1)
			{
				list = chapterInfo.Reward1;
			}
			else if (idx == 2)
			{
				list = chapterInfo.Reward2;
			}
			else if (idx == 3)
			{
				list = chapterInfo.Reward3;
			}
			if (list == null)
			{
				return;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_starRewardPreviewScrollRect.content, assetInContainer, null, true, 1, true);
		}

		// Token: 0x06012B3E RID: 76606 RVA: 0x004CA06C File Offset: 0x004C826C
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
			this.m_chapterInfo = null;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06012B3F RID: 76607 RVA: 0x004CA0EC File Offset: 0x004C82EC
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

		// Token: 0x06012B40 RID: 76608 RVA: 0x004CA164 File Offset: 0x004C8364
		private void OnWorldButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWorldButtonClick_hotfix != null)
			{
				this.m_OnWorldButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chapterInfo = null;
			if (this.EventOnReturnToWorld != null)
			{
				this.EventOnReturnToWorld();
			}
		}

		// Token: 0x06012B41 RID: 76609 RVA: 0x004CA1E4 File Offset: 0x004C83E4
		private void OnHardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHardButtonClick_hotfix != null)
			{
				this.m_OnHardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_hardButtonUIStateController) == "Lock")
			{
				if (this.m_chapterInfo.m_hardChapterInfo.UnlockConditions.Count > 0)
				{
					if (this.m_chapterInfo.m_hardChapterInfo.UnlockConditions[0].ConditionType == RiftChapterUnlockConditionType.RiftChapterUnlockConditionType_ChapterStar && this.m_chapterInfo.HardChapter != 0 && this.m_playerContext.GetRiftChapterTotalStars(this.m_chapterInfo.HardChapter) < this.m_chapterInfo.m_hardChapterInfo.UnlockConditions[0].Param)
					{
						CommonUIController.Instance.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Rift_HardModeUnlock), this.m_chapterInfo.m_hardChapterInfo.UnlockConditions[0].Param), 2f, null, true);
					}
					this.m_hardUIStateController.SetToUIState("CanNotSwitch", false, true);
					return;
				}
			}
			else if (this.m_hardUIStateController.GetCurrentUIState().StateName == "NormalState")
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Rift_HardMode, 2f, null, true);
			}
			else if (this.m_hardUIStateController.GetCurrentUIState().StateName == "HardState")
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Rift_NormalMode, 2f, null, true);
			}
			if (this.EventOnChangeHard != null)
			{
				this.EventOnChangeHard();
			}
		}

		// Token: 0x06012B42 RID: 76610 RVA: 0x004CA3C4 File Offset: 0x004C85C4
		private void OnStarRewardButtonClick(GainRewardButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStarRewardButtonClickGainRewardButton_hotfix != null)
			{
				this.m_OnStarRewardButtonClickGainRewardButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (b.GetStatus() == GainRewardStatus.CanNotGet)
			{
				this.AddStarRewardPreviewGoods(this.m_chapterInfo, b.GetId());
				UIUtility.SetUIStateOpen(this.m_starRewardPreviewUIStateController, "PanelOpen", null, false, true);
				return;
			}
			if (this.EventOnGetStarReward != null)
			{
				this.EventOnGetStarReward(b.GetId());
			}
		}

		// Token: 0x06012B43 RID: 76611 RVA: 0x004CA484 File Offset: 0x004C8684
		public void OnRiftLevelButtonClick(RiftLevelButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRiftLevelButtonClickRiftLevelButton_hotfix != null)
			{
				this.m_OnRiftLevelButtonClickRiftLevelButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRiftLevelInfo riftLevel = b.GetRiftLevel();
			RiftLevelStatus status = b.GetStatus();
			if (status == RiftLevelStatus.Close)
			{
				return;
			}
			if (status == RiftLevelStatus.Lock || status == RiftLevelStatus.CloseLock)
			{
				if (this.m_playerContext.GetPlayerLevel() < riftLevel.PlayerLevel)
				{
					CommonUIController.Instance.ShowMessage(string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Rift_LevelUnlock), riftLevel.PlayerLevel), 2f, null, true);
				}
				else if (riftLevel.UnlockConditions.Count > 0)
				{
					this.AddRiftLevelUnlockContitionItems(riftLevel);
					UIUtility.SetUIStateOpen(this.m_unlockConditionUIStateController, "Show", null, false, true);
				}
				return;
			}
			if (this.EventOnSelectRiftLevel != null)
			{
				this.EventOnSelectRiftLevel(b.GetRiftLevel(), null);
			}
		}

		// Token: 0x06012B44 RID: 76612 RVA: 0x004CA5AC File Offset: 0x004C87AC
		private void OnEventRiftLevelButtonClick(EventRiftLevelButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEventRiftLevelButtonClickEventRiftLevelButton_hotfix != null)
			{
				this.m_OnEventRiftLevelButtonClickEventRiftLevelButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RiftLevelStatus status = b.GetStatus();
			if (status == RiftLevelStatus.Open && this.EventOnSelectRiftLevel != null)
			{
				this.EventOnSelectRiftLevel(b.GetRiftLevelInfo(), null);
			}
		}

		// Token: 0x06012B45 RID: 76613 RVA: 0x004CA648 File Offset: 0x004C8848
		private void OnUnlockConditionBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnlockConditionBackgroundButtonClick_hotfix != null)
			{
				this.m_OnUnlockConditionBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_unlockConditionUIStateController, "Close", null, true, true);
		}

		// Token: 0x06012B46 RID: 76614 RVA: 0x004CA6BC File Offset: 0x004C88BC
		private void OnStarRewardPreviewBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStarRewardPreviewBackgroundButtonClick_hotfix != null)
			{
				this.m_OnStarRewardPreviewBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_starRewardPreviewUIStateController, "PanelClose", null, true, true);
		}

		// Token: 0x06012B47 RID: 76615 RVA: 0x004CA730 File Offset: 0x004C8930
		public void SetUnlockConditionClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnlockConditionClose_hotfix != null)
			{
				this.m_SetUnlockConditionClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_unlockConditionUIStateController, "Close", null, true, true);
		}

		// Token: 0x1400040A RID: 1034
		// (add) Token: 0x06012B48 RID: 76616 RVA: 0x004CA7A4 File Offset: 0x004C89A4
		// (remove) Token: 0x06012B49 RID: 76617 RVA: 0x004CA840 File Offset: 0x004C8A40
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

		// Token: 0x1400040B RID: 1035
		// (add) Token: 0x06012B4A RID: 76618 RVA: 0x004CA8DC File Offset: 0x004C8ADC
		// (remove) Token: 0x06012B4B RID: 76619 RVA: 0x004CA978 File Offset: 0x004C8B78
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

		// Token: 0x1400040C RID: 1036
		// (add) Token: 0x06012B4C RID: 76620 RVA: 0x004CAA14 File Offset: 0x004C8C14
		// (remove) Token: 0x06012B4D RID: 76621 RVA: 0x004CAAB0 File Offset: 0x004C8CB0
		public event Action EventOnReturnToWorld
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnToWorldAction_hotfix != null)
				{
					this.m_add_EventOnReturnToWorldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturnToWorld;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturnToWorld, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnToWorldAction_hotfix != null)
				{
					this.m_remove_EventOnReturnToWorldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturnToWorld;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturnToWorld, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400040D RID: 1037
		// (add) Token: 0x06012B4E RID: 76622 RVA: 0x004CAB4C File Offset: 0x004C8D4C
		// (remove) Token: 0x06012B4F RID: 76623 RVA: 0x004CABE8 File Offset: 0x004C8DE8
		public event Action EventOnChangeHard
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeHardAction_hotfix != null)
				{
					this.m_add_EventOnChangeHardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnChangeHard;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnChangeHard, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeHardAction_hotfix != null)
				{
					this.m_remove_EventOnChangeHardAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnChangeHard;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnChangeHard, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400040E RID: 1038
		// (add) Token: 0x06012B50 RID: 76624 RVA: 0x004CAC84 File Offset: 0x004C8E84
		// (remove) Token: 0x06012B51 RID: 76625 RVA: 0x004CAD20 File Offset: 0x004C8F20
		public event Action<ConfigDataRiftLevelInfo, NeedGoods> EventOnSelectRiftLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectRiftLevelAction`2_hotfix != null)
				{
					this.m_add_EventOnSelectRiftLevelAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftLevelInfo, NeedGoods> action = this.EventOnSelectRiftLevel;
				Action<ConfigDataRiftLevelInfo, NeedGoods> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftLevelInfo, NeedGoods>>(ref this.EventOnSelectRiftLevel, (Action<ConfigDataRiftLevelInfo, NeedGoods>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectRiftLevelAction`2_hotfix != null)
				{
					this.m_remove_EventOnSelectRiftLevelAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftLevelInfo, NeedGoods> action = this.EventOnSelectRiftLevel;
				Action<ConfigDataRiftLevelInfo, NeedGoods> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftLevelInfo, NeedGoods>>(ref this.EventOnSelectRiftLevel, (Action<ConfigDataRiftLevelInfo, NeedGoods>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400040F RID: 1039
		// (add) Token: 0x06012B52 RID: 76626 RVA: 0x004CADBC File Offset: 0x004C8FBC
		// (remove) Token: 0x06012B53 RID: 76627 RVA: 0x004CAE58 File Offset: 0x004C9058
		public event Action<int> EventOnGetStarReward
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetStarRewardAction`1_hotfix != null)
				{
					this.m_add_EventOnGetStarRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGetStarReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGetStarReward, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetStarRewardAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetStarRewardAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGetStarReward;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGetStarReward, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000410 RID: 1040
		// (add) Token: 0x06012B54 RID: 76628 RVA: 0x004CAEF4 File Offset: 0x004C90F4
		// (remove) Token: 0x06012B55 RID: 76629 RVA: 0x004CAF90 File Offset: 0x004C9190
		public event Action<int> EventOnGoToScenario
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToScenarioAction`1_hotfix != null)
				{
					this.m_add_EventOnGoToScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToScenario;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToScenario, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToScenarioAction`1_hotfix != null)
				{
					this.m_remove_EventOnGoToScenarioAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGoToScenario;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGoToScenario, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000411 RID: 1041
		// (add) Token: 0x06012B56 RID: 76630 RVA: 0x004CB02C File Offset: 0x004C922C
		// (remove) Token: 0x06012B57 RID: 76631 RVA: 0x004CB0C8 File Offset: 0x004C92C8
		public event Action<ConfigDataRiftChapterInfo> EventOnSelectChapter
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectChapterAction`1_hotfix != null)
				{
					this.m_add_EventOnSelectChapterAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftChapterInfo> action = this.EventOnSelectChapter;
				Action<ConfigDataRiftChapterInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftChapterInfo>>(ref this.EventOnSelectChapter, (Action<ConfigDataRiftChapterInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectChapterAction`1_hotfix != null)
				{
					this.m_remove_EventOnSelectChapterAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftChapterInfo> action = this.EventOnSelectChapter;
				Action<ConfigDataRiftChapterInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftChapterInfo>>(ref this.EventOnSelectChapter, (Action<ConfigDataRiftChapterInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x06012B58 RID: 76632 RVA: 0x004CB164 File Offset: 0x004C9364
		// (set) Token: 0x06012B59 RID: 76633 RVA: 0x004CB184 File Offset: 0x004C9384
		[DoNotToLua]
		public new RiftLevelUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftLevelUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012B5A RID: 76634 RVA: 0x004CB190 File Offset: 0x004C9390
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012B5B RID: 76635 RVA: 0x004CB19C File Offset: 0x004C939C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012B5C RID: 76636 RVA: 0x004CB1A4 File Offset: 0x004C93A4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012B5D RID: 76637 RVA: 0x004CB1AC File Offset: 0x004C93AC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012B5E RID: 76638 RVA: 0x004CB1C0 File Offset: 0x004C93C0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012B5F RID: 76639 RVA: 0x004CB1C8 File Offset: 0x004C93C8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012B60 RID: 76640 RVA: 0x004CB1D4 File Offset: 0x004C93D4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012B61 RID: 76641 RVA: 0x004CB1E0 File Offset: 0x004C93E0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012B62 RID: 76642 RVA: 0x004CB1EC File Offset: 0x004C93EC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012B63 RID: 76643 RVA: 0x004CB1F8 File Offset: 0x004C93F8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012B64 RID: 76644 RVA: 0x004CB204 File Offset: 0x004C9404
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012B65 RID: 76645 RVA: 0x004CB210 File Offset: 0x004C9410
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012B66 RID: 76646 RVA: 0x004CB21C File Offset: 0x004C941C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012B67 RID: 76647 RVA: 0x004CB228 File Offset: 0x004C9428
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012B68 RID: 76648 RVA: 0x004CB234 File Offset: 0x004C9434
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012B69 RID: 76649 RVA: 0x004CB23C File Offset: 0x004C943C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06012B6A RID: 76650 RVA: 0x004CB25C File Offset: 0x004C945C
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06012B6B RID: 76651 RVA: 0x004CB268 File Offset: 0x004C9468
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06012B6C RID: 76652 RVA: 0x004CB288 File Offset: 0x004C9488
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06012B6D RID: 76653 RVA: 0x004CB294 File Offset: 0x004C9494
		private void __callDele_EventOnReturnToWorld()
		{
			Action eventOnReturnToWorld = this.EventOnReturnToWorld;
			if (eventOnReturnToWorld != null)
			{
				eventOnReturnToWorld();
			}
		}

		// Token: 0x06012B6E RID: 76654 RVA: 0x004CB2B4 File Offset: 0x004C94B4
		private void __clearDele_EventOnReturnToWorld()
		{
			this.EventOnReturnToWorld = null;
		}

		// Token: 0x06012B6F RID: 76655 RVA: 0x004CB2C0 File Offset: 0x004C94C0
		private void __callDele_EventOnChangeHard()
		{
			Action eventOnChangeHard = this.EventOnChangeHard;
			if (eventOnChangeHard != null)
			{
				eventOnChangeHard();
			}
		}

		// Token: 0x06012B70 RID: 76656 RVA: 0x004CB2E0 File Offset: 0x004C94E0
		private void __clearDele_EventOnChangeHard()
		{
			this.EventOnChangeHard = null;
		}

		// Token: 0x06012B71 RID: 76657 RVA: 0x004CB2EC File Offset: 0x004C94EC
		private void __callDele_EventOnSelectRiftLevel(ConfigDataRiftLevelInfo arg1, NeedGoods arg2)
		{
			Action<ConfigDataRiftLevelInfo, NeedGoods> eventOnSelectRiftLevel = this.EventOnSelectRiftLevel;
			if (eventOnSelectRiftLevel != null)
			{
				eventOnSelectRiftLevel(arg1, arg2);
			}
		}

		// Token: 0x06012B72 RID: 76658 RVA: 0x004CB310 File Offset: 0x004C9510
		private void __clearDele_EventOnSelectRiftLevel(ConfigDataRiftLevelInfo arg1, NeedGoods arg2)
		{
			this.EventOnSelectRiftLevel = null;
		}

		// Token: 0x06012B73 RID: 76659 RVA: 0x004CB31C File Offset: 0x004C951C
		private void __callDele_EventOnGetStarReward(int obj)
		{
			Action<int> eventOnGetStarReward = this.EventOnGetStarReward;
			if (eventOnGetStarReward != null)
			{
				eventOnGetStarReward(obj);
			}
		}

		// Token: 0x06012B74 RID: 76660 RVA: 0x004CB340 File Offset: 0x004C9540
		private void __clearDele_EventOnGetStarReward(int obj)
		{
			this.EventOnGetStarReward = null;
		}

		// Token: 0x06012B75 RID: 76661 RVA: 0x004CB34C File Offset: 0x004C954C
		private void __callDele_EventOnGoToScenario(int obj)
		{
			Action<int> eventOnGoToScenario = this.EventOnGoToScenario;
			if (eventOnGoToScenario != null)
			{
				eventOnGoToScenario(obj);
			}
		}

		// Token: 0x06012B76 RID: 76662 RVA: 0x004CB370 File Offset: 0x004C9570
		private void __clearDele_EventOnGoToScenario(int obj)
		{
			this.EventOnGoToScenario = null;
		}

		// Token: 0x06012B77 RID: 76663 RVA: 0x004CB37C File Offset: 0x004C957C
		private void __callDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
		{
			Action<ConfigDataRiftChapterInfo> eventOnSelectChapter = this.EventOnSelectChapter;
			if (eventOnSelectChapter != null)
			{
				eventOnSelectChapter(obj);
			}
		}

		// Token: 0x06012B78 RID: 76664 RVA: 0x004CB3A0 File Offset: 0x004C95A0
		private void __clearDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
		{
			this.EventOnSelectChapter = null;
		}

		// Token: 0x06012B79 RID: 76665 RVA: 0x004CB3AC File Offset: 0x004C95AC
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
					this.m_SetChapterConfigDataRiftChapterInfoBoolean_hotfix = (luaObj.RawGet("SetChapter") as LuaFunction);
					this.m_SetStarRewardStatusInt32GainRewardStatus_hotfix = (luaObj.RawGet("SetStarRewardStatus") as LuaFunction);
					this.m_SetStarRewardProressInt32Int32_hotfix = (luaObj.RawGet("SetStarRewardProress") as LuaFunction);
					this.m_ClearRiftLevelButtons_hotfix = (luaObj.RawGet("ClearRiftLevelButtons") as LuaFunction);
					this.m_ClearEventRiftLevelButtons_hotfix = (luaObj.RawGet("ClearEventRiftLevelButtons") as LuaFunction);
					this.m_AddRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatusInt32Int32BooleanInt32Int32Int32Int32_hotfix = (luaObj.RawGet("AddRiftLevelButton") as LuaFunction);
					this.m_AddEventRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatus_hotfix = (luaObj.RawGet("AddEventRiftLevelButton") as LuaFunction);
					this.m_AddEventRiftLevelDummys_hotfix = (luaObj.RawGet("AddEventRiftLevelDummys") as LuaFunction);
					this.m_ClearRiftLevelUnlockContitionItems_hotfix = (luaObj.RawGet("ClearRiftLevelUnlockContitionItems") as LuaFunction);
					this.m_AddRiftLevelUnlockContitionItemsConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("AddRiftLevelUnlockContitionItems") as LuaFunction);
					this.m_GoToRiftLevelInt32Int32_hotfix = (luaObj.RawGet("GoToRiftLevel") as LuaFunction);
					this.m_Co_ShowRiftLevelConfigDataRiftChapterInfoConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("Co_ShowRiftLevel") as LuaFunction);
					this.m_AddStarRewardPreviewGoodsConfigDataRiftChapterInfoInt32_hotfix = (luaObj.RawGet("AddStarRewardPreviewGoods") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnWorldButtonClick_hotfix = (luaObj.RawGet("OnWorldButtonClick") as LuaFunction);
					this.m_OnHardButtonClick_hotfix = (luaObj.RawGet("OnHardButtonClick") as LuaFunction);
					this.m_OnStarRewardButtonClickGainRewardButton_hotfix = (luaObj.RawGet("OnStarRewardButtonClick") as LuaFunction);
					this.m_OnRiftLevelButtonClickRiftLevelButton_hotfix = (luaObj.RawGet("OnRiftLevelButtonClick") as LuaFunction);
					this.m_OnEventRiftLevelButtonClickEventRiftLevelButton_hotfix = (luaObj.RawGet("OnEventRiftLevelButtonClick") as LuaFunction);
					this.m_OnUnlockConditionBackgroundButtonClick_hotfix = (luaObj.RawGet("OnUnlockConditionBackgroundButtonClick") as LuaFunction);
					this.m_OnStarRewardPreviewBackgroundButtonClick_hotfix = (luaObj.RawGet("OnStarRewardPreviewBackgroundButtonClick") as LuaFunction);
					this.m_SetUnlockConditionClose_hotfix = (luaObj.RawGet("SetUnlockConditionClose") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnReturnToWorldAction_hotfix = (luaObj.RawGet("add_EventOnReturnToWorld") as LuaFunction);
					this.m_remove_EventOnReturnToWorldAction_hotfix = (luaObj.RawGet("remove_EventOnReturnToWorld") as LuaFunction);
					this.m_add_EventOnChangeHardAction_hotfix = (luaObj.RawGet("add_EventOnChangeHard") as LuaFunction);
					this.m_remove_EventOnChangeHardAction_hotfix = (luaObj.RawGet("remove_EventOnChangeHard") as LuaFunction);
					this.m_add_EventOnSelectRiftLevelAction`2_hotfix = (luaObj.RawGet("add_EventOnSelectRiftLevel") as LuaFunction);
					this.m_remove_EventOnSelectRiftLevelAction`2_hotfix = (luaObj.RawGet("remove_EventOnSelectRiftLevel") as LuaFunction);
					this.m_add_EventOnGetStarRewardAction`1_hotfix = (luaObj.RawGet("add_EventOnGetStarReward") as LuaFunction);
					this.m_remove_EventOnGetStarRewardAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetStarReward") as LuaFunction);
					this.m_add_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToScenario") as LuaFunction);
					this.m_remove_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToScenario") as LuaFunction);
					this.m_add_EventOnSelectChapterAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectChapter") as LuaFunction);
					this.m_remove_EventOnSelectChapterAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectChapter") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012B7A RID: 76666 RVA: 0x004CB860 File Offset: 0x004C9A60
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A790 RID: 42896
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A791 RID: 42897
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400A792 RID: 42898
		[AutoBind("./ChapterBG", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chapterBGObject;

		// Token: 0x0400A793 RID: 42899
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400A794 RID: 42900
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400A795 RID: 42901
		[AutoBind("./WorldButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_worldButton;

		// Token: 0x0400A796 RID: 42902
		[AutoBind("./Hard", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_hardUIStateController;

		// Token: 0x0400A797 RID: 42903
		[AutoBind("./Hard/SwitchButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_hardButton;

		// Token: 0x0400A798 RID: 42904
		[AutoBind("./Hard/SwitchButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_hardButtonUIStateController;

		// Token: 0x0400A799 RID: 42905
		[AutoBind("./Margin/StarReward/Button1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starRewardButton1GameObject;

		// Token: 0x0400A79A RID: 42906
		[AutoBind("./Margin/StarReward/Button2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starRewardButton2GameObject;

		// Token: 0x0400A79B RID: 42907
		[AutoBind("./Margin/StarReward/Button3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starRewardButton3GameObject;

		// Token: 0x0400A79C RID: 42908
		[AutoBind("./Margin/StarReward/Got/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_starRewardGotText;

		// Token: 0x0400A79D RID: 42909
		[AutoBind("./Margin/StarReward/ProgressBar/ProgressBarImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_progressBarImage;

		// Token: 0x0400A79E RID: 42910
		[AutoBind("./StarRewardPreview", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_starRewardPreviewUIStateController;

		// Token: 0x0400A79F RID: 42911
		[AutoBind("./StarRewardPreview/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_starRewardPreviewBackgroundButton;

		// Token: 0x0400A7A0 RID: 42912
		[AutoBind("./StarRewardPreview/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_starRewardPreviewScrollRect;

		// Token: 0x0400A7A1 RID: 42913
		[AutoBind("./UnlockCondition", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_unlockConditionUIStateController;

		// Token: 0x0400A7A2 RID: 42914
		[AutoBind("./UnlockCondition/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unlockConditionBackgroundButton;

		// Token: 0x0400A7A3 RID: 42915
		[AutoBind("./UnlockCondition/Panel/ItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unlockConditionGroupGameObject;

		// Token: 0x0400A7A4 RID: 42916
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400A7A5 RID: 42917
		[AutoBind("./Prefabs/RiftLevelUnlockConditionItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_riftLevelUnlockConditionItemPrefab;

		// Token: 0x0400A7A6 RID: 42918
		[AutoBind("./Prefabs/RiftLevelButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_riftLevelButtonPrefab;

		// Token: 0x0400A7A7 RID: 42919
		[AutoBind("./Prefabs/EventRiftLevelButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_eventRiftLevelButtonPrefab;

		// Token: 0x0400A7A8 RID: 42920
		[AutoBind("./Prefabs/ElitePoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_eventRiftLevelDummyPrefab;

		// Token: 0x0400A7A9 RID: 42921
		private List<RiftLevelButton> m_riftLevelButtons = new List<RiftLevelButton>();

		// Token: 0x0400A7AA RID: 42922
		private List<EventRiftLevelButton> m_eventRiftLevelButtons = new List<EventRiftLevelButton>();

		// Token: 0x0400A7AB RID: 42923
		private List<RiftLevelUnlockConditionItemUIController> m_riftLevelUnlockConditionItems = new List<RiftLevelUnlockConditionItemUIController>();

		// Token: 0x0400A7AC RID: 42924
		private GameObject m_createChapterBGObject;

		// Token: 0x0400A7AD RID: 42925
		private GainRewardButton[] m_starRewardButtons;

		// Token: 0x0400A7AE RID: 42926
		private ConfigDataRiftChapterInfo m_chapterInfo;

		// Token: 0x0400A7AF RID: 42927
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A7B0 RID: 42928
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400A7B1 RID: 42929
		[DoNotToLua]
		private RiftLevelUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A7B2 RID: 42930
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A7B3 RID: 42931
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A7B4 RID: 42932
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A7B5 RID: 42933
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A7B6 RID: 42934
		private LuaFunction m_SetChapterConfigDataRiftChapterInfoBoolean_hotfix;

		// Token: 0x0400A7B7 RID: 42935
		private LuaFunction m_SetStarRewardStatusInt32GainRewardStatus_hotfix;

		// Token: 0x0400A7B8 RID: 42936
		private LuaFunction m_SetStarRewardProressInt32Int32_hotfix;

		// Token: 0x0400A7B9 RID: 42937
		private LuaFunction m_ClearRiftLevelButtons_hotfix;

		// Token: 0x0400A7BA RID: 42938
		private LuaFunction m_ClearEventRiftLevelButtons_hotfix;

		// Token: 0x0400A7BB RID: 42939
		private LuaFunction m_AddRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatusInt32Int32BooleanInt32Int32Int32Int32_hotfix;

		// Token: 0x0400A7BC RID: 42940
		private LuaFunction m_AddEventRiftLevelButtonConfigDataRiftLevelInfoRiftLevelStatus_hotfix;

		// Token: 0x0400A7BD RID: 42941
		private LuaFunction m_AddEventRiftLevelDummys_hotfix;

		// Token: 0x0400A7BE RID: 42942
		private LuaFunction m_ClearRiftLevelUnlockContitionItems_hotfix;

		// Token: 0x0400A7BF RID: 42943
		private LuaFunction m_AddRiftLevelUnlockContitionItemsConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400A7C0 RID: 42944
		private LuaFunction m_GoToRiftLevelInt32Int32_hotfix;

		// Token: 0x0400A7C1 RID: 42945
		private LuaFunction m_Co_ShowRiftLevelConfigDataRiftChapterInfoConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400A7C2 RID: 42946
		private LuaFunction m_AddStarRewardPreviewGoodsConfigDataRiftChapterInfoInt32_hotfix;

		// Token: 0x0400A7C3 RID: 42947
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400A7C4 RID: 42948
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400A7C5 RID: 42949
		private LuaFunction m_OnWorldButtonClick_hotfix;

		// Token: 0x0400A7C6 RID: 42950
		private LuaFunction m_OnHardButtonClick_hotfix;

		// Token: 0x0400A7C7 RID: 42951
		private LuaFunction m_OnStarRewardButtonClickGainRewardButton_hotfix;

		// Token: 0x0400A7C8 RID: 42952
		private LuaFunction m_OnRiftLevelButtonClickRiftLevelButton_hotfix;

		// Token: 0x0400A7C9 RID: 42953
		private LuaFunction m_OnEventRiftLevelButtonClickEventRiftLevelButton_hotfix;

		// Token: 0x0400A7CA RID: 42954
		private LuaFunction m_OnUnlockConditionBackgroundButtonClick_hotfix;

		// Token: 0x0400A7CB RID: 42955
		private LuaFunction m_OnStarRewardPreviewBackgroundButtonClick_hotfix;

		// Token: 0x0400A7CC RID: 42956
		private LuaFunction m_SetUnlockConditionClose_hotfix;

		// Token: 0x0400A7CD RID: 42957
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400A7CE RID: 42958
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400A7CF RID: 42959
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400A7D0 RID: 42960
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400A7D1 RID: 42961
		private LuaFunction m_add_EventOnReturnToWorldAction_hotfix;

		// Token: 0x0400A7D2 RID: 42962
		private LuaFunction m_remove_EventOnReturnToWorldAction_hotfix;

		// Token: 0x0400A7D3 RID: 42963
		private LuaFunction m_add_EventOnChangeHardAction_hotfix;

		// Token: 0x0400A7D4 RID: 42964
		private LuaFunction m_remove_EventOnChangeHardAction_hotfix;

		// Token: 0x0400A7D5 RID: 42965
		private LuaFunction m_add_EventOnSelectRiftLevelAction;

		// Token: 0x0400A7D6 RID: 42966
		private LuaFunction m_remove_EventOnSelectRiftLevelAction;

		// Token: 0x0400A7D7 RID: 42967
		private LuaFunction m_add_EventOnGetStarRewardAction;

		// Token: 0x0400A7D8 RID: 42968
		private LuaFunction m_remove_EventOnGetStarRewardAction;

		// Token: 0x0400A7D9 RID: 42969
		private LuaFunction m_add_EventOnGoToScenarioAction;

		// Token: 0x0400A7DA RID: 42970
		private LuaFunction m_remove_EventOnGoToScenarioAction;

		// Token: 0x0400A7DB RID: 42971
		private LuaFunction m_add_EventOnSelectChapterAction;

		// Token: 0x0400A7DC RID: 42972
		private LuaFunction m_remove_EventOnSelectChapterAction;

		// Token: 0x02000EDE RID: 3806
		public new class LuaExportHelper
		{
			// Token: 0x06012B7B RID: 76667 RVA: 0x004CB8C8 File Offset: 0x004C9AC8
			public LuaExportHelper(RiftLevelUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012B7C RID: 76668 RVA: 0x004CB8D8 File Offset: 0x004C9AD8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012B7D RID: 76669 RVA: 0x004CB8E8 File Offset: 0x004C9AE8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012B7E RID: 76670 RVA: 0x004CB8F8 File Offset: 0x004C9AF8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012B7F RID: 76671 RVA: 0x004CB908 File Offset: 0x004C9B08
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012B80 RID: 76672 RVA: 0x004CB920 File Offset: 0x004C9B20
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012B81 RID: 76673 RVA: 0x004CB930 File Offset: 0x004C9B30
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012B82 RID: 76674 RVA: 0x004CB940 File Offset: 0x004C9B40
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012B83 RID: 76675 RVA: 0x004CB950 File Offset: 0x004C9B50
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012B84 RID: 76676 RVA: 0x004CB960 File Offset: 0x004C9B60
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012B85 RID: 76677 RVA: 0x004CB970 File Offset: 0x004C9B70
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012B86 RID: 76678 RVA: 0x004CB980 File Offset: 0x004C9B80
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012B87 RID: 76679 RVA: 0x004CB990 File Offset: 0x004C9B90
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012B88 RID: 76680 RVA: 0x004CB9A0 File Offset: 0x004C9BA0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012B89 RID: 76681 RVA: 0x004CB9B0 File Offset: 0x004C9BB0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012B8A RID: 76682 RVA: 0x004CB9C0 File Offset: 0x004C9BC0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012B8B RID: 76683 RVA: 0x004CB9D0 File Offset: 0x004C9BD0
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06012B8C RID: 76684 RVA: 0x004CB9E0 File Offset: 0x004C9BE0
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06012B8D RID: 76685 RVA: 0x004CB9F0 File Offset: 0x004C9BF0
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06012B8E RID: 76686 RVA: 0x004CBA00 File Offset: 0x004C9C00
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x06012B8F RID: 76687 RVA: 0x004CBA10 File Offset: 0x004C9C10
			public void __callDele_EventOnReturnToWorld()
			{
				this.m_owner.__callDele_EventOnReturnToWorld();
			}

			// Token: 0x06012B90 RID: 76688 RVA: 0x004CBA20 File Offset: 0x004C9C20
			public void __clearDele_EventOnReturnToWorld()
			{
				this.m_owner.__clearDele_EventOnReturnToWorld();
			}

			// Token: 0x06012B91 RID: 76689 RVA: 0x004CBA30 File Offset: 0x004C9C30
			public void __callDele_EventOnChangeHard()
			{
				this.m_owner.__callDele_EventOnChangeHard();
			}

			// Token: 0x06012B92 RID: 76690 RVA: 0x004CBA40 File Offset: 0x004C9C40
			public void __clearDele_EventOnChangeHard()
			{
				this.m_owner.__clearDele_EventOnChangeHard();
			}

			// Token: 0x06012B93 RID: 76691 RVA: 0x004CBA50 File Offset: 0x004C9C50
			public void __callDele_EventOnSelectRiftLevel(ConfigDataRiftLevelInfo arg1, NeedGoods arg2)
			{
				this.m_owner.__callDele_EventOnSelectRiftLevel(arg1, arg2);
			}

			// Token: 0x06012B94 RID: 76692 RVA: 0x004CBA60 File Offset: 0x004C9C60
			public void __clearDele_EventOnSelectRiftLevel(ConfigDataRiftLevelInfo arg1, NeedGoods arg2)
			{
				this.m_owner.__clearDele_EventOnSelectRiftLevel(arg1, arg2);
			}

			// Token: 0x06012B95 RID: 76693 RVA: 0x004CBA70 File Offset: 0x004C9C70
			public void __callDele_EventOnGetStarReward(int obj)
			{
				this.m_owner.__callDele_EventOnGetStarReward(obj);
			}

			// Token: 0x06012B96 RID: 76694 RVA: 0x004CBA80 File Offset: 0x004C9C80
			public void __clearDele_EventOnGetStarReward(int obj)
			{
				this.m_owner.__clearDele_EventOnGetStarReward(obj);
			}

			// Token: 0x06012B97 RID: 76695 RVA: 0x004CBA90 File Offset: 0x004C9C90
			public void __callDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__callDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012B98 RID: 76696 RVA: 0x004CBAA0 File Offset: 0x004C9CA0
			public void __clearDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__clearDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012B99 RID: 76697 RVA: 0x004CBAB0 File Offset: 0x004C9CB0
			public void __callDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
			{
				this.m_owner.__callDele_EventOnSelectChapter(obj);
			}

			// Token: 0x06012B9A RID: 76698 RVA: 0x004CBAC0 File Offset: 0x004C9CC0
			public void __clearDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
			{
				this.m_owner.__clearDele_EventOnSelectChapter(obj);
			}

			// Token: 0x17003873 RID: 14451
			// (get) Token: 0x06012B9B RID: 76699 RVA: 0x004CBAD0 File Offset: 0x004C9CD0
			// (set) Token: 0x06012B9C RID: 76700 RVA: 0x004CBAE0 File Offset: 0x004C9CE0
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

			// Token: 0x17003874 RID: 14452
			// (get) Token: 0x06012B9D RID: 76701 RVA: 0x004CBAF0 File Offset: 0x004C9CF0
			// (set) Token: 0x06012B9E RID: 76702 RVA: 0x004CBB00 File Offset: 0x004C9D00
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

			// Token: 0x17003875 RID: 14453
			// (get) Token: 0x06012B9F RID: 76703 RVA: 0x004CBB10 File Offset: 0x004C9D10
			// (set) Token: 0x06012BA0 RID: 76704 RVA: 0x004CBB20 File Offset: 0x004C9D20
			public GameObject m_chapterBGObject
			{
				get
				{
					return this.m_owner.m_chapterBGObject;
				}
				set
				{
					this.m_owner.m_chapterBGObject = value;
				}
			}

			// Token: 0x17003876 RID: 14454
			// (get) Token: 0x06012BA1 RID: 76705 RVA: 0x004CBB30 File Offset: 0x004C9D30
			// (set) Token: 0x06012BA2 RID: 76706 RVA: 0x004CBB40 File Offset: 0x004C9D40
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

			// Token: 0x17003877 RID: 14455
			// (get) Token: 0x06012BA3 RID: 76707 RVA: 0x004CBB50 File Offset: 0x004C9D50
			// (set) Token: 0x06012BA4 RID: 76708 RVA: 0x004CBB60 File Offset: 0x004C9D60
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

			// Token: 0x17003878 RID: 14456
			// (get) Token: 0x06012BA5 RID: 76709 RVA: 0x004CBB70 File Offset: 0x004C9D70
			// (set) Token: 0x06012BA6 RID: 76710 RVA: 0x004CBB80 File Offset: 0x004C9D80
			public Button m_worldButton
			{
				get
				{
					return this.m_owner.m_worldButton;
				}
				set
				{
					this.m_owner.m_worldButton = value;
				}
			}

			// Token: 0x17003879 RID: 14457
			// (get) Token: 0x06012BA7 RID: 76711 RVA: 0x004CBB90 File Offset: 0x004C9D90
			// (set) Token: 0x06012BA8 RID: 76712 RVA: 0x004CBBA0 File Offset: 0x004C9DA0
			public CommonUIStateController m_hardUIStateController
			{
				get
				{
					return this.m_owner.m_hardUIStateController;
				}
				set
				{
					this.m_owner.m_hardUIStateController = value;
				}
			}

			// Token: 0x1700387A RID: 14458
			// (get) Token: 0x06012BA9 RID: 76713 RVA: 0x004CBBB0 File Offset: 0x004C9DB0
			// (set) Token: 0x06012BAA RID: 76714 RVA: 0x004CBBC0 File Offset: 0x004C9DC0
			public Button m_hardButton
			{
				get
				{
					return this.m_owner.m_hardButton;
				}
				set
				{
					this.m_owner.m_hardButton = value;
				}
			}

			// Token: 0x1700387B RID: 14459
			// (get) Token: 0x06012BAB RID: 76715 RVA: 0x004CBBD0 File Offset: 0x004C9DD0
			// (set) Token: 0x06012BAC RID: 76716 RVA: 0x004CBBE0 File Offset: 0x004C9DE0
			public CommonUIStateController m_hardButtonUIStateController
			{
				get
				{
					return this.m_owner.m_hardButtonUIStateController;
				}
				set
				{
					this.m_owner.m_hardButtonUIStateController = value;
				}
			}

			// Token: 0x1700387C RID: 14460
			// (get) Token: 0x06012BAD RID: 76717 RVA: 0x004CBBF0 File Offset: 0x004C9DF0
			// (set) Token: 0x06012BAE RID: 76718 RVA: 0x004CBC00 File Offset: 0x004C9E00
			public GameObject m_starRewardButton1GameObject
			{
				get
				{
					return this.m_owner.m_starRewardButton1GameObject;
				}
				set
				{
					this.m_owner.m_starRewardButton1GameObject = value;
				}
			}

			// Token: 0x1700387D RID: 14461
			// (get) Token: 0x06012BAF RID: 76719 RVA: 0x004CBC10 File Offset: 0x004C9E10
			// (set) Token: 0x06012BB0 RID: 76720 RVA: 0x004CBC20 File Offset: 0x004C9E20
			public GameObject m_starRewardButton2GameObject
			{
				get
				{
					return this.m_owner.m_starRewardButton2GameObject;
				}
				set
				{
					this.m_owner.m_starRewardButton2GameObject = value;
				}
			}

			// Token: 0x1700387E RID: 14462
			// (get) Token: 0x06012BB1 RID: 76721 RVA: 0x004CBC30 File Offset: 0x004C9E30
			// (set) Token: 0x06012BB2 RID: 76722 RVA: 0x004CBC40 File Offset: 0x004C9E40
			public GameObject m_starRewardButton3GameObject
			{
				get
				{
					return this.m_owner.m_starRewardButton3GameObject;
				}
				set
				{
					this.m_owner.m_starRewardButton3GameObject = value;
				}
			}

			// Token: 0x1700387F RID: 14463
			// (get) Token: 0x06012BB3 RID: 76723 RVA: 0x004CBC50 File Offset: 0x004C9E50
			// (set) Token: 0x06012BB4 RID: 76724 RVA: 0x004CBC60 File Offset: 0x004C9E60
			public Text m_starRewardGotText
			{
				get
				{
					return this.m_owner.m_starRewardGotText;
				}
				set
				{
					this.m_owner.m_starRewardGotText = value;
				}
			}

			// Token: 0x17003880 RID: 14464
			// (get) Token: 0x06012BB5 RID: 76725 RVA: 0x004CBC70 File Offset: 0x004C9E70
			// (set) Token: 0x06012BB6 RID: 76726 RVA: 0x004CBC80 File Offset: 0x004C9E80
			public Image m_progressBarImage
			{
				get
				{
					return this.m_owner.m_progressBarImage;
				}
				set
				{
					this.m_owner.m_progressBarImage = value;
				}
			}

			// Token: 0x17003881 RID: 14465
			// (get) Token: 0x06012BB7 RID: 76727 RVA: 0x004CBC90 File Offset: 0x004C9E90
			// (set) Token: 0x06012BB8 RID: 76728 RVA: 0x004CBCA0 File Offset: 0x004C9EA0
			public CommonUIStateController m_starRewardPreviewUIStateController
			{
				get
				{
					return this.m_owner.m_starRewardPreviewUIStateController;
				}
				set
				{
					this.m_owner.m_starRewardPreviewUIStateController = value;
				}
			}

			// Token: 0x17003882 RID: 14466
			// (get) Token: 0x06012BB9 RID: 76729 RVA: 0x004CBCB0 File Offset: 0x004C9EB0
			// (set) Token: 0x06012BBA RID: 76730 RVA: 0x004CBCC0 File Offset: 0x004C9EC0
			public Button m_starRewardPreviewBackgroundButton
			{
				get
				{
					return this.m_owner.m_starRewardPreviewBackgroundButton;
				}
				set
				{
					this.m_owner.m_starRewardPreviewBackgroundButton = value;
				}
			}

			// Token: 0x17003883 RID: 14467
			// (get) Token: 0x06012BBB RID: 76731 RVA: 0x004CBCD0 File Offset: 0x004C9ED0
			// (set) Token: 0x06012BBC RID: 76732 RVA: 0x004CBCE0 File Offset: 0x004C9EE0
			public ScrollRect m_starRewardPreviewScrollRect
			{
				get
				{
					return this.m_owner.m_starRewardPreviewScrollRect;
				}
				set
				{
					this.m_owner.m_starRewardPreviewScrollRect = value;
				}
			}

			// Token: 0x17003884 RID: 14468
			// (get) Token: 0x06012BBD RID: 76733 RVA: 0x004CBCF0 File Offset: 0x004C9EF0
			// (set) Token: 0x06012BBE RID: 76734 RVA: 0x004CBD00 File Offset: 0x004C9F00
			public CommonUIStateController m_unlockConditionUIStateController
			{
				get
				{
					return this.m_owner.m_unlockConditionUIStateController;
				}
				set
				{
					this.m_owner.m_unlockConditionUIStateController = value;
				}
			}

			// Token: 0x17003885 RID: 14469
			// (get) Token: 0x06012BBF RID: 76735 RVA: 0x004CBD10 File Offset: 0x004C9F10
			// (set) Token: 0x06012BC0 RID: 76736 RVA: 0x004CBD20 File Offset: 0x004C9F20
			public Button m_unlockConditionBackgroundButton
			{
				get
				{
					return this.m_owner.m_unlockConditionBackgroundButton;
				}
				set
				{
					this.m_owner.m_unlockConditionBackgroundButton = value;
				}
			}

			// Token: 0x17003886 RID: 14470
			// (get) Token: 0x06012BC1 RID: 76737 RVA: 0x004CBD30 File Offset: 0x004C9F30
			// (set) Token: 0x06012BC2 RID: 76738 RVA: 0x004CBD40 File Offset: 0x004C9F40
			public GameObject m_unlockConditionGroupGameObject
			{
				get
				{
					return this.m_owner.m_unlockConditionGroupGameObject;
				}
				set
				{
					this.m_owner.m_unlockConditionGroupGameObject = value;
				}
			}

			// Token: 0x17003887 RID: 14471
			// (get) Token: 0x06012BC3 RID: 76739 RVA: 0x004CBD50 File Offset: 0x004C9F50
			// (set) Token: 0x06012BC4 RID: 76740 RVA: 0x004CBD60 File Offset: 0x004C9F60
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

			// Token: 0x17003888 RID: 14472
			// (get) Token: 0x06012BC5 RID: 76741 RVA: 0x004CBD70 File Offset: 0x004C9F70
			// (set) Token: 0x06012BC6 RID: 76742 RVA: 0x004CBD80 File Offset: 0x004C9F80
			public GameObject m_riftLevelUnlockConditionItemPrefab
			{
				get
				{
					return this.m_owner.m_riftLevelUnlockConditionItemPrefab;
				}
				set
				{
					this.m_owner.m_riftLevelUnlockConditionItemPrefab = value;
				}
			}

			// Token: 0x17003889 RID: 14473
			// (get) Token: 0x06012BC7 RID: 76743 RVA: 0x004CBD90 File Offset: 0x004C9F90
			// (set) Token: 0x06012BC8 RID: 76744 RVA: 0x004CBDA0 File Offset: 0x004C9FA0
			public GameObject m_riftLevelButtonPrefab
			{
				get
				{
					return this.m_owner.m_riftLevelButtonPrefab;
				}
				set
				{
					this.m_owner.m_riftLevelButtonPrefab = value;
				}
			}

			// Token: 0x1700388A RID: 14474
			// (get) Token: 0x06012BC9 RID: 76745 RVA: 0x004CBDB0 File Offset: 0x004C9FB0
			// (set) Token: 0x06012BCA RID: 76746 RVA: 0x004CBDC0 File Offset: 0x004C9FC0
			public GameObject m_eventRiftLevelButtonPrefab
			{
				get
				{
					return this.m_owner.m_eventRiftLevelButtonPrefab;
				}
				set
				{
					this.m_owner.m_eventRiftLevelButtonPrefab = value;
				}
			}

			// Token: 0x1700388B RID: 14475
			// (get) Token: 0x06012BCB RID: 76747 RVA: 0x004CBDD0 File Offset: 0x004C9FD0
			// (set) Token: 0x06012BCC RID: 76748 RVA: 0x004CBDE0 File Offset: 0x004C9FE0
			public GameObject m_eventRiftLevelDummyPrefab
			{
				get
				{
					return this.m_owner.m_eventRiftLevelDummyPrefab;
				}
				set
				{
					this.m_owner.m_eventRiftLevelDummyPrefab = value;
				}
			}

			// Token: 0x1700388C RID: 14476
			// (get) Token: 0x06012BCD RID: 76749 RVA: 0x004CBDF0 File Offset: 0x004C9FF0
			// (set) Token: 0x06012BCE RID: 76750 RVA: 0x004CBE00 File Offset: 0x004CA000
			public List<RiftLevelButton> m_riftLevelButtons
			{
				get
				{
					return this.m_owner.m_riftLevelButtons;
				}
				set
				{
					this.m_owner.m_riftLevelButtons = value;
				}
			}

			// Token: 0x1700388D RID: 14477
			// (get) Token: 0x06012BCF RID: 76751 RVA: 0x004CBE10 File Offset: 0x004CA010
			// (set) Token: 0x06012BD0 RID: 76752 RVA: 0x004CBE20 File Offset: 0x004CA020
			public List<EventRiftLevelButton> m_eventRiftLevelButtons
			{
				get
				{
					return this.m_owner.m_eventRiftLevelButtons;
				}
				set
				{
					this.m_owner.m_eventRiftLevelButtons = value;
				}
			}

			// Token: 0x1700388E RID: 14478
			// (get) Token: 0x06012BD1 RID: 76753 RVA: 0x004CBE30 File Offset: 0x004CA030
			// (set) Token: 0x06012BD2 RID: 76754 RVA: 0x004CBE40 File Offset: 0x004CA040
			public List<RiftLevelUnlockConditionItemUIController> m_riftLevelUnlockConditionItems
			{
				get
				{
					return this.m_owner.m_riftLevelUnlockConditionItems;
				}
				set
				{
					this.m_owner.m_riftLevelUnlockConditionItems = value;
				}
			}

			// Token: 0x1700388F RID: 14479
			// (get) Token: 0x06012BD3 RID: 76755 RVA: 0x004CBE50 File Offset: 0x004CA050
			// (set) Token: 0x06012BD4 RID: 76756 RVA: 0x004CBE60 File Offset: 0x004CA060
			public GameObject m_createChapterBGObject
			{
				get
				{
					return this.m_owner.m_createChapterBGObject;
				}
				set
				{
					this.m_owner.m_createChapterBGObject = value;
				}
			}

			// Token: 0x17003890 RID: 14480
			// (get) Token: 0x06012BD5 RID: 76757 RVA: 0x004CBE70 File Offset: 0x004CA070
			// (set) Token: 0x06012BD6 RID: 76758 RVA: 0x004CBE80 File Offset: 0x004CA080
			public GainRewardButton[] m_starRewardButtons
			{
				get
				{
					return this.m_owner.m_starRewardButtons;
				}
				set
				{
					this.m_owner.m_starRewardButtons = value;
				}
			}

			// Token: 0x17003891 RID: 14481
			// (get) Token: 0x06012BD7 RID: 76759 RVA: 0x004CBE90 File Offset: 0x004CA090
			// (set) Token: 0x06012BD8 RID: 76760 RVA: 0x004CBEA0 File Offset: 0x004CA0A0
			public ConfigDataRiftChapterInfo m_chapterInfo
			{
				get
				{
					return this.m_owner.m_chapterInfo;
				}
				set
				{
					this.m_owner.m_chapterInfo = value;
				}
			}

			// Token: 0x17003892 RID: 14482
			// (get) Token: 0x06012BD9 RID: 76761 RVA: 0x004CBEB0 File Offset: 0x004CA0B0
			// (set) Token: 0x06012BDA RID: 76762 RVA: 0x004CBEC0 File Offset: 0x004CA0C0
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

			// Token: 0x17003893 RID: 14483
			// (get) Token: 0x06012BDB RID: 76763 RVA: 0x004CBED0 File Offset: 0x004CA0D0
			// (set) Token: 0x06012BDC RID: 76764 RVA: 0x004CBEE0 File Offset: 0x004CA0E0
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

			// Token: 0x06012BDD RID: 76765 RVA: 0x004CBEF0 File Offset: 0x004CA0F0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012BDE RID: 76766 RVA: 0x004CBF00 File Offset: 0x004CA100
			public void ClearRiftLevelUnlockContitionItems()
			{
				this.m_owner.ClearRiftLevelUnlockContitionItems();
			}

			// Token: 0x06012BDF RID: 76767 RVA: 0x004CBF10 File Offset: 0x004CA110
			public void AddRiftLevelUnlockContitionItems(ConfigDataRiftLevelInfo riftLevelInfo)
			{
				this.m_owner.AddRiftLevelUnlockContitionItems(riftLevelInfo);
			}

			// Token: 0x06012BE0 RID: 76768 RVA: 0x004CBF20 File Offset: 0x004CA120
			public void GoToRiftLevel(int chapterID, int levelID)
			{
				this.m_owner.GoToRiftLevel(chapterID, levelID);
			}

			// Token: 0x06012BE1 RID: 76769 RVA: 0x004CBF30 File Offset: 0x004CA130
			public IEnumerator Co_ShowRiftLevel(ConfigDataRiftChapterInfo riftChapterInfo, ConfigDataRiftLevelInfo riftLevelInfo)
			{
				return this.m_owner.Co_ShowRiftLevel(riftChapterInfo, riftLevelInfo);
			}

			// Token: 0x06012BE2 RID: 76770 RVA: 0x004CBF40 File Offset: 0x004CA140
			public void AddStarRewardPreviewGoods(ConfigDataRiftChapterInfo chapterInfo, int idx)
			{
				this.m_owner.AddStarRewardPreviewGoods(chapterInfo, idx);
			}

			// Token: 0x06012BE3 RID: 76771 RVA: 0x004CBF50 File Offset: 0x004CA150
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06012BE4 RID: 76772 RVA: 0x004CBF60 File Offset: 0x004CA160
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06012BE5 RID: 76773 RVA: 0x004CBF70 File Offset: 0x004CA170
			public void OnWorldButtonClick()
			{
				this.m_owner.OnWorldButtonClick();
			}

			// Token: 0x06012BE6 RID: 76774 RVA: 0x004CBF80 File Offset: 0x004CA180
			public void OnHardButtonClick()
			{
				this.m_owner.OnHardButtonClick();
			}

			// Token: 0x06012BE7 RID: 76775 RVA: 0x004CBF90 File Offset: 0x004CA190
			public void OnStarRewardButtonClick(GainRewardButton b)
			{
				this.m_owner.OnStarRewardButtonClick(b);
			}

			// Token: 0x06012BE8 RID: 76776 RVA: 0x004CBFA0 File Offset: 0x004CA1A0
			public void OnEventRiftLevelButtonClick(EventRiftLevelButton b)
			{
				this.m_owner.OnEventRiftLevelButtonClick(b);
			}

			// Token: 0x06012BE9 RID: 76777 RVA: 0x004CBFB0 File Offset: 0x004CA1B0
			public void OnUnlockConditionBackgroundButtonClick()
			{
				this.m_owner.OnUnlockConditionBackgroundButtonClick();
			}

			// Token: 0x06012BEA RID: 76778 RVA: 0x004CBFC0 File Offset: 0x004CA1C0
			public void OnStarRewardPreviewBackgroundButtonClick()
			{
				this.m_owner.OnStarRewardPreviewBackgroundButtonClick();
			}

			// Token: 0x0400A7DD RID: 42973
			private RiftLevelUIController m_owner;
		}
	}
}
