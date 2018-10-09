using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ED7 RID: 3799
	[HotFix]
	public class RiftChapterUIController : UIControllerBase
	{
		// Token: 0x06012A1C RID: 76316 RVA: 0x004C5CB0 File Offset: 0x004C3EB0
		private RiftChapterUIController()
		{
		}

		// Token: 0x06012A1D RID: 76317 RVA: 0x004C5CD0 File Offset: 0x004C3ED0
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
			this.m_unlockConditionBGButton.onClick.AddListener(new UnityAction(this.OnUnlockConditionBGButtonClick));
			this.m_chaptersScrollSnapCenter = this.m_chaptersScrollRect.gameObject.AddComponent<ScrollSnapCenter>();
			this.m_chaptersScrollSnapCenter.m_itemSize = 700f;
			this.m_chaptersScrollSnapCenter.m_scrollSnapDir = ScrollSnapDirection.Horizontal;
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06012A1E RID: 76318 RVA: 0x004C5DF0 File Offset: 0x004C3FF0
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

		// Token: 0x06012A1F RID: 76319 RVA: 0x004C5E64 File Offset: 0x004C4064
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
			Camera componentInParent = base.GetComponentInParent<Camera>();
			if (componentInParent == null)
			{
				return;
			}
			if (this.m_chapterButtons.Count <= 0)
			{
				return;
			}
			Vector2 center = this.m_chaptersScrollRect.viewport.rect.center;
			RiftChapterButton riftChapterButton = this.m_chapterButtons[this.m_chaptersScrollSnapCenter.GetCenterItemIndex()];
			foreach (RiftChapterButton riftChapterButton2 in this.m_chapterButtons)
			{
				float num = Mathf.Abs(UIUtility.WorldToLocalPosition(riftChapterButton2.transform.position, componentInParent, this.m_chaptersScrollRect.viewport, componentInParent).x - center.x);
				float num2 = Mathf.Clamp01((1000f - num) / 1000f);
				float num3 = num2 * 0.4f + 0.6f;
				RectTransform rectTransform = riftChapterButton2.transform as RectTransform;
				rectTransform.localScale = new Vector3(num3, num3, num3);
				rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, (num2 - 1f) * 50f);
				if (this.m_curChapterIndex != riftChapterButton.GetIndex())
				{
					riftChapterButton2.SetStatus(riftChapterButton2.IsLocked(), riftChapterButton2.IsNew(), riftChapterButton == riftChapterButton2);
				}
			}
			if (this.m_curChapterIndex != riftChapterButton.GetIndex())
			{
				this.m_curChapterIndex = riftChapterButton.GetIndex();
				if (this.EventOnSwitchChapter != null)
				{
					this.EventOnSwitchChapter(riftChapterButton.GetChapter());
				}
			}
		}

		// Token: 0x06012A20 RID: 76320 RVA: 0x004C6070 File Offset: 0x004C4270
		public void ClearChapterButtons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearChapterButtons_hotfix != null)
			{
				this.m_ClearChapterButtons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<RiftChapterButton>(this.m_chapterButtons);
			this.m_chapterButtons.Clear();
			this.m_chaptersScrollSnapCenter.SetItemCount(0);
			this.HideChapterProgress();
			this.HideChapterUnlockConditions();
		}

		// Token: 0x06012A21 RID: 76321 RVA: 0x004C6100 File Offset: 0x004C4300
		public void AddChapterButton(ConfigDataRiftChapterInfo chapterInfo, bool locked, bool newChapter)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddChapterButtonConfigDataRiftChapterInfoBooleanBoolean_hotfix != null)
			{
				this.m_AddChapterButtonConfigDataRiftChapterInfoBooleanBoolean_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					locked,
					newChapter
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chapterInfo == null)
			{
				return;
			}
			int count = this.m_chapterButtons.Count;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_riftChapterButtonPrefab, this.m_chaptersScrollRect.content, false);
			gameObject.name = count.ToString();
			RiftChapterButton riftChapterButton = GameObjectUtility.AddControllerToGameObject<RiftChapterButton>(gameObject);
			riftChapterButton.SetChapter(chapterInfo);
			riftChapterButton.SetIndex(count);
			riftChapterButton.SetStatus(locked, newChapter, count == this.m_curChapterIndex);
			riftChapterButton.EventOnClick += this.OnChapterButtonClick;
			this.m_chapterButtons.Add(riftChapterButton);
			this.m_chaptersScrollSnapCenter.SetItemCount(this.m_chapterButtons.Count);
			RectTransform rectTransform = gameObject.transform as RectTransform;
			rectTransform.anchoredPosition = this.m_chaptersScrollSnapCenter.ComputeItemPosition(count);
		}

		// Token: 0x06012A22 RID: 76322 RVA: 0x004C6248 File Offset: 0x004C4448
		public void SetCurrentChapter(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentChapterConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_SetCurrentChapterConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curChapterIndex = 0;
			foreach (RiftChapterButton riftChapterButton in this.m_chapterButtons)
			{
				if (riftChapterButton.GetChapter() == chapterInfo)
				{
					this.m_curChapterIndex = riftChapterButton.GetIndex();
					riftChapterButton.SetStatus(riftChapterButton.IsLocked(), riftChapterButton.IsNew(), true);
				}
				else
				{
					riftChapterButton.SetStatus(riftChapterButton.IsLocked(), riftChapterButton.IsNew(), false);
				}
			}
			this.m_chaptersScrollSnapCenter.Snap(this.m_curChapterIndex, false);
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x004C635C File Offset: 0x004C455C
		public void ShowChapterProgress(ConfigDataRiftChapterInfo chapterInfo, int normalStarCount, int normalStarCountMax, int normalAchivementCount, int normalAchievementCountMax, int normalTreasureCount, int normalTreasureCountMax, int hardStarCount, int hardStarCountMax, int hardAchivementCount, int hardAchievementCountMax, int hardTreasureCount, int hardTreasureCountMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChapterProgressConfigDataRiftChapterInfoInt32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32_hotfix != null)
			{
				this.m_ShowChapterProgressConfigDataRiftChapterInfoInt32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					chapterInfo,
					normalStarCount,
					normalStarCountMax,
					normalAchivementCount,
					normalAchievementCountMax,
					normalTreasureCount,
					normalTreasureCountMax,
					hardStarCount,
					hardStarCountMax,
					hardAchivementCount,
					hardAchievementCountMax,
					hardTreasureCount,
					hardTreasureCountMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideChapterUnlockConditions();
			this.m_progressGameObject.SetActive(true);
			this.m_progressTitleText.text = chapterInfo.TitleName;
			this.m_progressNameText.text = chapterInfo.Name;
			this.m_progressPlaceText.text = chapterInfo.Place;
			this.m_progressNormalStarText.text = normalStarCount + "/" + normalStarCountMax;
			this.m_progressNormalAchievementText.text = normalAchivementCount + "/" + normalAchievementCountMax;
			this.m_progressNormalTreasureText.text = normalTreasureCount + "/" + normalTreasureCountMax;
			this.m_progressHardStarText.text = hardStarCount + "/" + hardStarCountMax;
			this.m_progressHardAchievementText.text = hardAchivementCount + "/" + hardAchievementCountMax;
			this.m_progressHardTreasureText.text = hardTreasureCount + "/" + hardTreasureCountMax;
		}

		// Token: 0x06012A24 RID: 76324 RVA: 0x004C65A4 File Offset: 0x004C47A4
		private void OnUnlockConditionBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnlockConditionBGButtonClick_hotfix != null)
			{
				this.m_OnUnlockConditionBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_unlockConditionUIStateCtrl, "Close", null, false, true);
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x004C6618 File Offset: 0x004C4818
		public void SetChapterUnlockConditionClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChapterUnlockConditionClose_hotfix != null)
			{
				this.m_SetChapterUnlockConditionClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_unlockConditionUIStateCtrl, "Close", null, false, true);
		}

		// Token: 0x06012A26 RID: 76326 RVA: 0x004C668C File Offset: 0x004C488C
		public void HideChapterProgress()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideChapterProgress_hotfix != null)
			{
				this.m_HideChapterProgress_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_progressGameObject.SetActive(false);
		}

		// Token: 0x06012A27 RID: 76327 RVA: 0x004C66F8 File Offset: 0x004C48F8
		public void ShowChapterUnlockConditions(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChapterUnlockConditionsConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_ShowChapterUnlockConditionsConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideChapterProgress();
			this.ClearRiftLevelUnlockContitionItems();
			foreach (RiftChapterInfoUnlockConditions riftChapterInfoUnlockConditions in chapterInfo.UnlockConditions)
			{
				GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_riftChapterUnlockConditionItemPrefab, this.m_unlockConditionGroup.transform, false);
				RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = GameObjectUtility.AddControllerToGameObject<RiftChapterUnlockConditionItemUIController>(go);
				riftChapterUnlockConditionItemUIController.SetCondition(riftChapterInfoUnlockConditions.ConditionType, riftChapterInfoUnlockConditions.Param);
				riftChapterUnlockConditionItemUIController.EventOnGoToScenario += this.EventOnGoToScenario;
				this.m_riftChapterUnlockConditionItems.Add(riftChapterUnlockConditionItemUIController);
			}
			UIUtility.SetUIStateOpen(this.m_unlockConditionUIStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06012A28 RID: 76328 RVA: 0x004C6818 File Offset: 0x004C4A18
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
			GameObjectUtility.DestroyComponentList<RiftChapterUnlockConditionItemUIController>(this.m_riftChapterUnlockConditionItems);
			this.m_riftChapterUnlockConditionItems.Clear();
		}

		// Token: 0x06012A29 RID: 76329 RVA: 0x004C6890 File Offset: 0x004C4A90
		private void HideChapterUnlockConditions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideChapterUnlockConditions_hotfix != null)
			{
				this.m_HideChapterUnlockConditions_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unlockConditionGameObject.SetActive(false);
		}

		// Token: 0x06012A2A RID: 76330 RVA: 0x004C68FC File Offset: 0x004C4AFC
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

		// Token: 0x06012A2B RID: 76331 RVA: 0x004C6974 File Offset: 0x004C4B74
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

		// Token: 0x06012A2C RID: 76332 RVA: 0x004C69EC File Offset: 0x004C4BEC
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
			if (this.EventOnReturnToWorld != null)
			{
				this.EventOnReturnToWorld();
			}
		}

		// Token: 0x06012A2D RID: 76333 RVA: 0x004C6A64 File Offset: 0x004C4C64
		private void OnChapterButtonClick(RiftChapterButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChapterButtonClickRiftChapterButton_hotfix != null)
			{
				this.m_OnChapterButtonClickRiftChapterButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (b.GetIndex() == this.m_curChapterIndex)
			{
				if (this.EventOnSelectChapter != null)
				{
					this.EventOnSelectChapter(b.GetChapter());
				}
			}
			else
			{
				this.m_chaptersScrollSnapCenter.Snap(b.GetIndex(), true);
			}
		}

		// Token: 0x14000402 RID: 1026
		// (add) Token: 0x06012A2E RID: 76334 RVA: 0x004C6B18 File Offset: 0x004C4D18
		// (remove) Token: 0x06012A2F RID: 76335 RVA: 0x004C6BB4 File Offset: 0x004C4DB4
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

		// Token: 0x14000403 RID: 1027
		// (add) Token: 0x06012A30 RID: 76336 RVA: 0x004C6C50 File Offset: 0x004C4E50
		// (remove) Token: 0x06012A31 RID: 76337 RVA: 0x004C6CEC File Offset: 0x004C4EEC
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

		// Token: 0x14000404 RID: 1028
		// (add) Token: 0x06012A32 RID: 76338 RVA: 0x004C6D88 File Offset: 0x004C4F88
		// (remove) Token: 0x06012A33 RID: 76339 RVA: 0x004C6E24 File Offset: 0x004C5024
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

		// Token: 0x14000405 RID: 1029
		// (add) Token: 0x06012A34 RID: 76340 RVA: 0x004C6EC0 File Offset: 0x004C50C0
		// (remove) Token: 0x06012A35 RID: 76341 RVA: 0x004C6F5C File Offset: 0x004C515C
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

		// Token: 0x14000406 RID: 1030
		// (add) Token: 0x06012A36 RID: 76342 RVA: 0x004C6FF8 File Offset: 0x004C51F8
		// (remove) Token: 0x06012A37 RID: 76343 RVA: 0x004C7094 File Offset: 0x004C5294
		public event Action<ConfigDataRiftChapterInfo> EventOnSwitchChapter
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSwitchChapterAction`1_hotfix != null)
				{
					this.m_add_EventOnSwitchChapterAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftChapterInfo> action = this.EventOnSwitchChapter;
				Action<ConfigDataRiftChapterInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftChapterInfo>>(ref this.EventOnSwitchChapter, (Action<ConfigDataRiftChapterInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSwitchChapterAction`1_hotfix != null)
				{
					this.m_remove_EventOnSwitchChapterAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataRiftChapterInfo> action = this.EventOnSwitchChapter;
				Action<ConfigDataRiftChapterInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataRiftChapterInfo>>(ref this.EventOnSwitchChapter, (Action<ConfigDataRiftChapterInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000407 RID: 1031
		// (add) Token: 0x06012A38 RID: 76344 RVA: 0x004C7130 File Offset: 0x004C5330
		// (remove) Token: 0x06012A39 RID: 76345 RVA: 0x004C71CC File Offset: 0x004C53CC
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

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x06012A3A RID: 76346 RVA: 0x004C7268 File Offset: 0x004C5468
		// (set) Token: 0x06012A3B RID: 76347 RVA: 0x004C7288 File Offset: 0x004C5488
		[DoNotToLua]
		public new RiftChapterUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftChapterUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012A3C RID: 76348 RVA: 0x004C7294 File Offset: 0x004C5494
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012A3D RID: 76349 RVA: 0x004C72A0 File Offset: 0x004C54A0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012A3E RID: 76350 RVA: 0x004C72A8 File Offset: 0x004C54A8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012A3F RID: 76351 RVA: 0x004C72B0 File Offset: 0x004C54B0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x004C72C4 File Offset: 0x004C54C4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x004C72CC File Offset: 0x004C54CC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012A42 RID: 76354 RVA: 0x004C72D8 File Offset: 0x004C54D8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012A43 RID: 76355 RVA: 0x004C72E4 File Offset: 0x004C54E4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012A44 RID: 76356 RVA: 0x004C72F0 File Offset: 0x004C54F0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x004C72FC File Offset: 0x004C54FC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012A46 RID: 76358 RVA: 0x004C7308 File Offset: 0x004C5508
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012A47 RID: 76359 RVA: 0x004C7314 File Offset: 0x004C5514
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012A48 RID: 76360 RVA: 0x004C7320 File Offset: 0x004C5520
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012A49 RID: 76361 RVA: 0x004C732C File Offset: 0x004C552C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012A4A RID: 76362 RVA: 0x004C7338 File Offset: 0x004C5538
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x004C7340 File Offset: 0x004C5540
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06012A4C RID: 76364 RVA: 0x004C7360 File Offset: 0x004C5560
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06012A4D RID: 76365 RVA: 0x004C736C File Offset: 0x004C556C
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06012A4E RID: 76366 RVA: 0x004C738C File Offset: 0x004C558C
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06012A4F RID: 76367 RVA: 0x004C7398 File Offset: 0x004C5598
		private void __callDele_EventOnReturnToWorld()
		{
			Action eventOnReturnToWorld = this.EventOnReturnToWorld;
			if (eventOnReturnToWorld != null)
			{
				eventOnReturnToWorld();
			}
		}

		// Token: 0x06012A50 RID: 76368 RVA: 0x004C73B8 File Offset: 0x004C55B8
		private void __clearDele_EventOnReturnToWorld()
		{
			this.EventOnReturnToWorld = null;
		}

		// Token: 0x06012A51 RID: 76369 RVA: 0x004C73C4 File Offset: 0x004C55C4
		private void __callDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
		{
			Action<ConfigDataRiftChapterInfo> eventOnSelectChapter = this.EventOnSelectChapter;
			if (eventOnSelectChapter != null)
			{
				eventOnSelectChapter(obj);
			}
		}

		// Token: 0x06012A52 RID: 76370 RVA: 0x004C73E8 File Offset: 0x004C55E8
		private void __clearDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
		{
			this.EventOnSelectChapter = null;
		}

		// Token: 0x06012A53 RID: 76371 RVA: 0x004C73F4 File Offset: 0x004C55F4
		private void __callDele_EventOnSwitchChapter(ConfigDataRiftChapterInfo obj)
		{
			Action<ConfigDataRiftChapterInfo> eventOnSwitchChapter = this.EventOnSwitchChapter;
			if (eventOnSwitchChapter != null)
			{
				eventOnSwitchChapter(obj);
			}
		}

		// Token: 0x06012A54 RID: 76372 RVA: 0x004C7418 File Offset: 0x004C5618
		private void __clearDele_EventOnSwitchChapter(ConfigDataRiftChapterInfo obj)
		{
			this.EventOnSwitchChapter = null;
		}

		// Token: 0x06012A55 RID: 76373 RVA: 0x004C7424 File Offset: 0x004C5624
		private void __callDele_EventOnGoToScenario(int obj)
		{
			Action<int> eventOnGoToScenario = this.EventOnGoToScenario;
			if (eventOnGoToScenario != null)
			{
				eventOnGoToScenario(obj);
			}
		}

		// Token: 0x06012A56 RID: 76374 RVA: 0x004C7448 File Offset: 0x004C5648
		private void __clearDele_EventOnGoToScenario(int obj)
		{
			this.EventOnGoToScenario = null;
		}

		// Token: 0x06012A57 RID: 76375 RVA: 0x004C7454 File Offset: 0x004C5654
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
					this.m_LateUpdate_hotfix = (luaObj.RawGet("LateUpdate") as LuaFunction);
					this.m_ClearChapterButtons_hotfix = (luaObj.RawGet("ClearChapterButtons") as LuaFunction);
					this.m_AddChapterButtonConfigDataRiftChapterInfoBooleanBoolean_hotfix = (luaObj.RawGet("AddChapterButton") as LuaFunction);
					this.m_SetCurrentChapterConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("SetCurrentChapter") as LuaFunction);
					this.m_ShowChapterProgressConfigDataRiftChapterInfoInt32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32_hotfix = (luaObj.RawGet("ShowChapterProgress") as LuaFunction);
					this.m_OnUnlockConditionBGButtonClick_hotfix = (luaObj.RawGet("OnUnlockConditionBGButtonClick") as LuaFunction);
					this.m_SetChapterUnlockConditionClose_hotfix = (luaObj.RawGet("SetChapterUnlockConditionClose") as LuaFunction);
					this.m_HideChapterProgress_hotfix = (luaObj.RawGet("HideChapterProgress") as LuaFunction);
					this.m_ShowChapterUnlockConditionsConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("ShowChapterUnlockConditions") as LuaFunction);
					this.m_ClearRiftLevelUnlockContitionItems_hotfix = (luaObj.RawGet("ClearRiftLevelUnlockContitionItems") as LuaFunction);
					this.m_HideChapterUnlockConditions_hotfix = (luaObj.RawGet("HideChapterUnlockConditions") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnWorldButtonClick_hotfix = (luaObj.RawGet("OnWorldButtonClick") as LuaFunction);
					this.m_OnChapterButtonClickRiftChapterButton_hotfix = (luaObj.RawGet("OnChapterButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnReturnToWorldAction_hotfix = (luaObj.RawGet("add_EventOnReturnToWorld") as LuaFunction);
					this.m_remove_EventOnReturnToWorldAction_hotfix = (luaObj.RawGet("remove_EventOnReturnToWorld") as LuaFunction);
					this.m_add_EventOnSelectChapterAction`1_hotfix = (luaObj.RawGet("add_EventOnSelectChapter") as LuaFunction);
					this.m_remove_EventOnSelectChapterAction`1_hotfix = (luaObj.RawGet("remove_EventOnSelectChapter") as LuaFunction);
					this.m_add_EventOnSwitchChapterAction`1_hotfix = (luaObj.RawGet("add_EventOnSwitchChapter") as LuaFunction);
					this.m_remove_EventOnSwitchChapterAction`1_hotfix = (luaObj.RawGet("remove_EventOnSwitchChapter") as LuaFunction);
					this.m_add_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("add_EventOnGoToScenario") as LuaFunction);
					this.m_remove_EventOnGoToScenarioAction`1_hotfix = (luaObj.RawGet("remove_EventOnGoToScenario") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012A58 RID: 76376 RVA: 0x004C77DC File Offset: 0x004C59DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftChapterUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A727 RID: 42791
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A728 RID: 42792
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400A729 RID: 42793
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400A72A RID: 42794
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400A72B RID: 42795
		[AutoBind("./WorldButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_worldButton;

		// Token: 0x0400A72C RID: 42796
		[AutoBind("./Chapters/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_chaptersScrollRect;

		// Token: 0x0400A72D RID: 42797
		[AutoBind("./UnlockCondition", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_unlockConditionUIStateCtrl;

		// Token: 0x0400A72E RID: 42798
		[AutoBind("./UnlockCondition", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unlockConditionGameObject;

		// Token: 0x0400A72F RID: 42799
		[AutoBind("./UnlockCondition/Panel/ItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unlockConditionGroup;

		// Token: 0x0400A730 RID: 42800
		[AutoBind("./UnlockCondition/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_unlockConditionBGButton;

		// Token: 0x0400A731 RID: 42801
		[AutoBind("./Margin/Progress", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressGameObject;

		// Token: 0x0400A732 RID: 42802
		[AutoBind("./Margin/Progress/BGImages/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressTitleText;

		// Token: 0x0400A733 RID: 42803
		[AutoBind("./Margin/Progress/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressNameText;

		// Token: 0x0400A734 RID: 42804
		[AutoBind("./Margin/Progress/PlaceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressPlaceText;

		// Token: 0x0400A735 RID: 42805
		[AutoBind("./Margin/Progress/Normal/StarText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressNormalStarText;

		// Token: 0x0400A736 RID: 42806
		[AutoBind("./Margin/Progress/Normal/CupText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressNormalAchievementText;

		// Token: 0x0400A737 RID: 42807
		[AutoBind("./Margin/Progress/Normal/ChestText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressNormalTreasureText;

		// Token: 0x0400A738 RID: 42808
		[AutoBind("./Margin/Progress/Elite/StarText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressHardStarText;

		// Token: 0x0400A739 RID: 42809
		[AutoBind("./Margin/Progress/Elite/CupText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressHardAchievementText;

		// Token: 0x0400A73A RID: 42810
		[AutoBind("./Margin/Progress/Elite/ChestText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressHardTreasureText;

		// Token: 0x0400A73B RID: 42811
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400A73C RID: 42812
		[AutoBind("./Prefabs/RiftChapterButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_riftChapterButtonPrefab;

		// Token: 0x0400A73D RID: 42813
		[AutoBind("./Prefabs/RiftChapterUnlockConditionItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_riftChapterUnlockConditionItemPrefab;

		// Token: 0x0400A73E RID: 42814
		private List<RiftChapterButton> m_chapterButtons = new List<RiftChapterButton>();

		// Token: 0x0400A73F RID: 42815
		private List<RiftChapterUnlockConditionItemUIController> m_riftChapterUnlockConditionItems = new List<RiftChapterUnlockConditionItemUIController>();

		// Token: 0x0400A740 RID: 42816
		private int m_curChapterIndex;

		// Token: 0x0400A741 RID: 42817
		private ScrollSnapCenter m_chaptersScrollSnapCenter;

		// Token: 0x0400A742 RID: 42818
		[DoNotToLua]
		private RiftChapterUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A743 RID: 42819
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A744 RID: 42820
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A745 RID: 42821
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A746 RID: 42822
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A747 RID: 42823
		private LuaFunction m_LateUpdate_hotfix;

		// Token: 0x0400A748 RID: 42824
		private LuaFunction m_ClearChapterButtons_hotfix;

		// Token: 0x0400A749 RID: 42825
		private LuaFunction m_AddChapterButtonConfigDataRiftChapterInfoBooleanBoolean_hotfix;

		// Token: 0x0400A74A RID: 42826
		private LuaFunction m_SetCurrentChapterConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A74B RID: 42827
		private LuaFunction m_ShowChapterProgressConfigDataRiftChapterInfoInt32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32Int32_hotfix;

		// Token: 0x0400A74C RID: 42828
		private LuaFunction m_OnUnlockConditionBGButtonClick_hotfix;

		// Token: 0x0400A74D RID: 42829
		private LuaFunction m_SetChapterUnlockConditionClose_hotfix;

		// Token: 0x0400A74E RID: 42830
		private LuaFunction m_HideChapterProgress_hotfix;

		// Token: 0x0400A74F RID: 42831
		private LuaFunction m_ShowChapterUnlockConditionsConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A750 RID: 42832
		private LuaFunction m_ClearRiftLevelUnlockContitionItems_hotfix;

		// Token: 0x0400A751 RID: 42833
		private LuaFunction m_HideChapterUnlockConditions_hotfix;

		// Token: 0x0400A752 RID: 42834
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400A753 RID: 42835
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400A754 RID: 42836
		private LuaFunction m_OnWorldButtonClick_hotfix;

		// Token: 0x0400A755 RID: 42837
		private LuaFunction m_OnChapterButtonClickRiftChapterButton_hotfix;

		// Token: 0x0400A756 RID: 42838
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400A757 RID: 42839
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400A758 RID: 42840
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400A759 RID: 42841
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400A75A RID: 42842
		private LuaFunction m_add_EventOnReturnToWorldAction_hotfix;

		// Token: 0x0400A75B RID: 42843
		private LuaFunction m_remove_EventOnReturnToWorldAction_hotfix;

		// Token: 0x0400A75C RID: 42844
		private LuaFunction m_add_EventOnSelectChapterAction;

		// Token: 0x0400A75D RID: 42845
		private LuaFunction m_remove_EventOnSelectChapterAction;

		// Token: 0x0400A75E RID: 42846
		private LuaFunction m_add_EventOnSwitchChapterAction;

		// Token: 0x0400A75F RID: 42847
		private LuaFunction m_remove_EventOnSwitchChapterAction;

		// Token: 0x0400A760 RID: 42848
		private LuaFunction m_add_EventOnGoToScenarioAction;

		// Token: 0x0400A761 RID: 42849
		private LuaFunction m_remove_EventOnGoToScenarioAction;

		// Token: 0x02000ED8 RID: 3800
		public new class LuaExportHelper
		{
			// Token: 0x06012A59 RID: 76377 RVA: 0x004C7844 File Offset: 0x004C5A44
			public LuaExportHelper(RiftChapterUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012A5A RID: 76378 RVA: 0x004C7854 File Offset: 0x004C5A54
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012A5B RID: 76379 RVA: 0x004C7864 File Offset: 0x004C5A64
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012A5C RID: 76380 RVA: 0x004C7874 File Offset: 0x004C5A74
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012A5D RID: 76381 RVA: 0x004C7884 File Offset: 0x004C5A84
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012A5E RID: 76382 RVA: 0x004C789C File Offset: 0x004C5A9C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012A5F RID: 76383 RVA: 0x004C78AC File Offset: 0x004C5AAC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012A60 RID: 76384 RVA: 0x004C78BC File Offset: 0x004C5ABC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012A61 RID: 76385 RVA: 0x004C78CC File Offset: 0x004C5ACC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012A62 RID: 76386 RVA: 0x004C78DC File Offset: 0x004C5ADC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012A63 RID: 76387 RVA: 0x004C78EC File Offset: 0x004C5AEC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012A64 RID: 76388 RVA: 0x004C78FC File Offset: 0x004C5AFC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012A65 RID: 76389 RVA: 0x004C790C File Offset: 0x004C5B0C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012A66 RID: 76390 RVA: 0x004C791C File Offset: 0x004C5B1C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012A67 RID: 76391 RVA: 0x004C792C File Offset: 0x004C5B2C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012A68 RID: 76392 RVA: 0x004C793C File Offset: 0x004C5B3C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012A69 RID: 76393 RVA: 0x004C794C File Offset: 0x004C5B4C
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06012A6A RID: 76394 RVA: 0x004C795C File Offset: 0x004C5B5C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06012A6B RID: 76395 RVA: 0x004C796C File Offset: 0x004C5B6C
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x06012A6C RID: 76396 RVA: 0x004C797C File Offset: 0x004C5B7C
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x06012A6D RID: 76397 RVA: 0x004C798C File Offset: 0x004C5B8C
			public void __callDele_EventOnReturnToWorld()
			{
				this.m_owner.__callDele_EventOnReturnToWorld();
			}

			// Token: 0x06012A6E RID: 76398 RVA: 0x004C799C File Offset: 0x004C5B9C
			public void __clearDele_EventOnReturnToWorld()
			{
				this.m_owner.__clearDele_EventOnReturnToWorld();
			}

			// Token: 0x06012A6F RID: 76399 RVA: 0x004C79AC File Offset: 0x004C5BAC
			public void __callDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
			{
				this.m_owner.__callDele_EventOnSelectChapter(obj);
			}

			// Token: 0x06012A70 RID: 76400 RVA: 0x004C79BC File Offset: 0x004C5BBC
			public void __clearDele_EventOnSelectChapter(ConfigDataRiftChapterInfo obj)
			{
				this.m_owner.__clearDele_EventOnSelectChapter(obj);
			}

			// Token: 0x06012A71 RID: 76401 RVA: 0x004C79CC File Offset: 0x004C5BCC
			public void __callDele_EventOnSwitchChapter(ConfigDataRiftChapterInfo obj)
			{
				this.m_owner.__callDele_EventOnSwitchChapter(obj);
			}

			// Token: 0x06012A72 RID: 76402 RVA: 0x004C79DC File Offset: 0x004C5BDC
			public void __clearDele_EventOnSwitchChapter(ConfigDataRiftChapterInfo obj)
			{
				this.m_owner.__clearDele_EventOnSwitchChapter(obj);
			}

			// Token: 0x06012A73 RID: 76403 RVA: 0x004C79EC File Offset: 0x004C5BEC
			public void __callDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__callDele_EventOnGoToScenario(obj);
			}

			// Token: 0x06012A74 RID: 76404 RVA: 0x004C79FC File Offset: 0x004C5BFC
			public void __clearDele_EventOnGoToScenario(int obj)
			{
				this.m_owner.__clearDele_EventOnGoToScenario(obj);
			}

			// Token: 0x17003849 RID: 14409
			// (get) Token: 0x06012A75 RID: 76405 RVA: 0x004C7A0C File Offset: 0x004C5C0C
			// (set) Token: 0x06012A76 RID: 76406 RVA: 0x004C7A1C File Offset: 0x004C5C1C
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

			// Token: 0x1700384A RID: 14410
			// (get) Token: 0x06012A77 RID: 76407 RVA: 0x004C7A2C File Offset: 0x004C5C2C
			// (set) Token: 0x06012A78 RID: 76408 RVA: 0x004C7A3C File Offset: 0x004C5C3C
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

			// Token: 0x1700384B RID: 14411
			// (get) Token: 0x06012A79 RID: 76409 RVA: 0x004C7A4C File Offset: 0x004C5C4C
			// (set) Token: 0x06012A7A RID: 76410 RVA: 0x004C7A5C File Offset: 0x004C5C5C
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

			// Token: 0x1700384C RID: 14412
			// (get) Token: 0x06012A7B RID: 76411 RVA: 0x004C7A6C File Offset: 0x004C5C6C
			// (set) Token: 0x06012A7C RID: 76412 RVA: 0x004C7A7C File Offset: 0x004C5C7C
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

			// Token: 0x1700384D RID: 14413
			// (get) Token: 0x06012A7D RID: 76413 RVA: 0x004C7A8C File Offset: 0x004C5C8C
			// (set) Token: 0x06012A7E RID: 76414 RVA: 0x004C7A9C File Offset: 0x004C5C9C
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

			// Token: 0x1700384E RID: 14414
			// (get) Token: 0x06012A7F RID: 76415 RVA: 0x004C7AAC File Offset: 0x004C5CAC
			// (set) Token: 0x06012A80 RID: 76416 RVA: 0x004C7ABC File Offset: 0x004C5CBC
			public ScrollRect m_chaptersScrollRect
			{
				get
				{
					return this.m_owner.m_chaptersScrollRect;
				}
				set
				{
					this.m_owner.m_chaptersScrollRect = value;
				}
			}

			// Token: 0x1700384F RID: 14415
			// (get) Token: 0x06012A81 RID: 76417 RVA: 0x004C7ACC File Offset: 0x004C5CCC
			// (set) Token: 0x06012A82 RID: 76418 RVA: 0x004C7ADC File Offset: 0x004C5CDC
			public CommonUIStateController m_unlockConditionUIStateCtrl
			{
				get
				{
					return this.m_owner.m_unlockConditionUIStateCtrl;
				}
				set
				{
					this.m_owner.m_unlockConditionUIStateCtrl = value;
				}
			}

			// Token: 0x17003850 RID: 14416
			// (get) Token: 0x06012A83 RID: 76419 RVA: 0x004C7AEC File Offset: 0x004C5CEC
			// (set) Token: 0x06012A84 RID: 76420 RVA: 0x004C7AFC File Offset: 0x004C5CFC
			public GameObject m_unlockConditionGameObject
			{
				get
				{
					return this.m_owner.m_unlockConditionGameObject;
				}
				set
				{
					this.m_owner.m_unlockConditionGameObject = value;
				}
			}

			// Token: 0x17003851 RID: 14417
			// (get) Token: 0x06012A85 RID: 76421 RVA: 0x004C7B0C File Offset: 0x004C5D0C
			// (set) Token: 0x06012A86 RID: 76422 RVA: 0x004C7B1C File Offset: 0x004C5D1C
			public GameObject m_unlockConditionGroup
			{
				get
				{
					return this.m_owner.m_unlockConditionGroup;
				}
				set
				{
					this.m_owner.m_unlockConditionGroup = value;
				}
			}

			// Token: 0x17003852 RID: 14418
			// (get) Token: 0x06012A87 RID: 76423 RVA: 0x004C7B2C File Offset: 0x004C5D2C
			// (set) Token: 0x06012A88 RID: 76424 RVA: 0x004C7B3C File Offset: 0x004C5D3C
			public Button m_unlockConditionBGButton
			{
				get
				{
					return this.m_owner.m_unlockConditionBGButton;
				}
				set
				{
					this.m_owner.m_unlockConditionBGButton = value;
				}
			}

			// Token: 0x17003853 RID: 14419
			// (get) Token: 0x06012A89 RID: 76425 RVA: 0x004C7B4C File Offset: 0x004C5D4C
			// (set) Token: 0x06012A8A RID: 76426 RVA: 0x004C7B5C File Offset: 0x004C5D5C
			public GameObject m_progressGameObject
			{
				get
				{
					return this.m_owner.m_progressGameObject;
				}
				set
				{
					this.m_owner.m_progressGameObject = value;
				}
			}

			// Token: 0x17003854 RID: 14420
			// (get) Token: 0x06012A8B RID: 76427 RVA: 0x004C7B6C File Offset: 0x004C5D6C
			// (set) Token: 0x06012A8C RID: 76428 RVA: 0x004C7B7C File Offset: 0x004C5D7C
			public Text m_progressTitleText
			{
				get
				{
					return this.m_owner.m_progressTitleText;
				}
				set
				{
					this.m_owner.m_progressTitleText = value;
				}
			}

			// Token: 0x17003855 RID: 14421
			// (get) Token: 0x06012A8D RID: 76429 RVA: 0x004C7B8C File Offset: 0x004C5D8C
			// (set) Token: 0x06012A8E RID: 76430 RVA: 0x004C7B9C File Offset: 0x004C5D9C
			public Text m_progressNameText
			{
				get
				{
					return this.m_owner.m_progressNameText;
				}
				set
				{
					this.m_owner.m_progressNameText = value;
				}
			}

			// Token: 0x17003856 RID: 14422
			// (get) Token: 0x06012A8F RID: 76431 RVA: 0x004C7BAC File Offset: 0x004C5DAC
			// (set) Token: 0x06012A90 RID: 76432 RVA: 0x004C7BBC File Offset: 0x004C5DBC
			public Text m_progressPlaceText
			{
				get
				{
					return this.m_owner.m_progressPlaceText;
				}
				set
				{
					this.m_owner.m_progressPlaceText = value;
				}
			}

			// Token: 0x17003857 RID: 14423
			// (get) Token: 0x06012A91 RID: 76433 RVA: 0x004C7BCC File Offset: 0x004C5DCC
			// (set) Token: 0x06012A92 RID: 76434 RVA: 0x004C7BDC File Offset: 0x004C5DDC
			public Text m_progressNormalStarText
			{
				get
				{
					return this.m_owner.m_progressNormalStarText;
				}
				set
				{
					this.m_owner.m_progressNormalStarText = value;
				}
			}

			// Token: 0x17003858 RID: 14424
			// (get) Token: 0x06012A93 RID: 76435 RVA: 0x004C7BEC File Offset: 0x004C5DEC
			// (set) Token: 0x06012A94 RID: 76436 RVA: 0x004C7BFC File Offset: 0x004C5DFC
			public Text m_progressNormalAchievementText
			{
				get
				{
					return this.m_owner.m_progressNormalAchievementText;
				}
				set
				{
					this.m_owner.m_progressNormalAchievementText = value;
				}
			}

			// Token: 0x17003859 RID: 14425
			// (get) Token: 0x06012A95 RID: 76437 RVA: 0x004C7C0C File Offset: 0x004C5E0C
			// (set) Token: 0x06012A96 RID: 76438 RVA: 0x004C7C1C File Offset: 0x004C5E1C
			public Text m_progressNormalTreasureText
			{
				get
				{
					return this.m_owner.m_progressNormalTreasureText;
				}
				set
				{
					this.m_owner.m_progressNormalTreasureText = value;
				}
			}

			// Token: 0x1700385A RID: 14426
			// (get) Token: 0x06012A97 RID: 76439 RVA: 0x004C7C2C File Offset: 0x004C5E2C
			// (set) Token: 0x06012A98 RID: 76440 RVA: 0x004C7C3C File Offset: 0x004C5E3C
			public Text m_progressHardStarText
			{
				get
				{
					return this.m_owner.m_progressHardStarText;
				}
				set
				{
					this.m_owner.m_progressHardStarText = value;
				}
			}

			// Token: 0x1700385B RID: 14427
			// (get) Token: 0x06012A99 RID: 76441 RVA: 0x004C7C4C File Offset: 0x004C5E4C
			// (set) Token: 0x06012A9A RID: 76442 RVA: 0x004C7C5C File Offset: 0x004C5E5C
			public Text m_progressHardAchievementText
			{
				get
				{
					return this.m_owner.m_progressHardAchievementText;
				}
				set
				{
					this.m_owner.m_progressHardAchievementText = value;
				}
			}

			// Token: 0x1700385C RID: 14428
			// (get) Token: 0x06012A9B RID: 76443 RVA: 0x004C7C6C File Offset: 0x004C5E6C
			// (set) Token: 0x06012A9C RID: 76444 RVA: 0x004C7C7C File Offset: 0x004C5E7C
			public Text m_progressHardTreasureText
			{
				get
				{
					return this.m_owner.m_progressHardTreasureText;
				}
				set
				{
					this.m_owner.m_progressHardTreasureText = value;
				}
			}

			// Token: 0x1700385D RID: 14429
			// (get) Token: 0x06012A9D RID: 76445 RVA: 0x004C7C8C File Offset: 0x004C5E8C
			// (set) Token: 0x06012A9E RID: 76446 RVA: 0x004C7C9C File Offset: 0x004C5E9C
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

			// Token: 0x1700385E RID: 14430
			// (get) Token: 0x06012A9F RID: 76447 RVA: 0x004C7CAC File Offset: 0x004C5EAC
			// (set) Token: 0x06012AA0 RID: 76448 RVA: 0x004C7CBC File Offset: 0x004C5EBC
			public GameObject m_riftChapterButtonPrefab
			{
				get
				{
					return this.m_owner.m_riftChapterButtonPrefab;
				}
				set
				{
					this.m_owner.m_riftChapterButtonPrefab = value;
				}
			}

			// Token: 0x1700385F RID: 14431
			// (get) Token: 0x06012AA1 RID: 76449 RVA: 0x004C7CCC File Offset: 0x004C5ECC
			// (set) Token: 0x06012AA2 RID: 76450 RVA: 0x004C7CDC File Offset: 0x004C5EDC
			public GameObject m_riftChapterUnlockConditionItemPrefab
			{
				get
				{
					return this.m_owner.m_riftChapterUnlockConditionItemPrefab;
				}
				set
				{
					this.m_owner.m_riftChapterUnlockConditionItemPrefab = value;
				}
			}

			// Token: 0x17003860 RID: 14432
			// (get) Token: 0x06012AA3 RID: 76451 RVA: 0x004C7CEC File Offset: 0x004C5EEC
			// (set) Token: 0x06012AA4 RID: 76452 RVA: 0x004C7CFC File Offset: 0x004C5EFC
			public List<RiftChapterButton> m_chapterButtons
			{
				get
				{
					return this.m_owner.m_chapterButtons;
				}
				set
				{
					this.m_owner.m_chapterButtons = value;
				}
			}

			// Token: 0x17003861 RID: 14433
			// (get) Token: 0x06012AA5 RID: 76453 RVA: 0x004C7D0C File Offset: 0x004C5F0C
			// (set) Token: 0x06012AA6 RID: 76454 RVA: 0x004C7D1C File Offset: 0x004C5F1C
			public List<RiftChapterUnlockConditionItemUIController> m_riftChapterUnlockConditionItems
			{
				get
				{
					return this.m_owner.m_riftChapterUnlockConditionItems;
				}
				set
				{
					this.m_owner.m_riftChapterUnlockConditionItems = value;
				}
			}

			// Token: 0x17003862 RID: 14434
			// (get) Token: 0x06012AA7 RID: 76455 RVA: 0x004C7D2C File Offset: 0x004C5F2C
			// (set) Token: 0x06012AA8 RID: 76456 RVA: 0x004C7D3C File Offset: 0x004C5F3C
			public int m_curChapterIndex
			{
				get
				{
					return this.m_owner.m_curChapterIndex;
				}
				set
				{
					this.m_owner.m_curChapterIndex = value;
				}
			}

			// Token: 0x17003863 RID: 14435
			// (get) Token: 0x06012AA9 RID: 76457 RVA: 0x004C7D4C File Offset: 0x004C5F4C
			// (set) Token: 0x06012AAA RID: 76458 RVA: 0x004C7D5C File Offset: 0x004C5F5C
			public ScrollSnapCenter m_chaptersScrollSnapCenter
			{
				get
				{
					return this.m_owner.m_chaptersScrollSnapCenter;
				}
				set
				{
					this.m_owner.m_chaptersScrollSnapCenter = value;
				}
			}

			// Token: 0x06012AAB RID: 76459 RVA: 0x004C7D6C File Offset: 0x004C5F6C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012AAC RID: 76460 RVA: 0x004C7D7C File Offset: 0x004C5F7C
			public void LateUpdate()
			{
				this.m_owner.LateUpdate();
			}

			// Token: 0x06012AAD RID: 76461 RVA: 0x004C7D8C File Offset: 0x004C5F8C
			public void OnUnlockConditionBGButtonClick()
			{
				this.m_owner.OnUnlockConditionBGButtonClick();
			}

			// Token: 0x06012AAE RID: 76462 RVA: 0x004C7D9C File Offset: 0x004C5F9C
			public void ClearRiftLevelUnlockContitionItems()
			{
				this.m_owner.ClearRiftLevelUnlockContitionItems();
			}

			// Token: 0x06012AAF RID: 76463 RVA: 0x004C7DAC File Offset: 0x004C5FAC
			public void HideChapterUnlockConditions()
			{
				this.m_owner.HideChapterUnlockConditions();
			}

			// Token: 0x06012AB0 RID: 76464 RVA: 0x004C7DBC File Offset: 0x004C5FBC
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06012AB1 RID: 76465 RVA: 0x004C7DCC File Offset: 0x004C5FCC
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x06012AB2 RID: 76466 RVA: 0x004C7DDC File Offset: 0x004C5FDC
			public void OnWorldButtonClick()
			{
				this.m_owner.OnWorldButtonClick();
			}

			// Token: 0x06012AB3 RID: 76467 RVA: 0x004C7DEC File Offset: 0x004C5FEC
			public void OnChapterButtonClick(RiftChapterButton b)
			{
				this.m_owner.OnChapterButtonClick(b);
			}

			// Token: 0x0400A762 RID: 42850
			private RiftChapterUIController m_owner;
		}
	}
}
