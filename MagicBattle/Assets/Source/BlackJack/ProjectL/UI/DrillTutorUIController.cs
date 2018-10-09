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
	// Token: 0x02000C4D RID: 3149
	[HotFix]
	public class DrillTutorUIController : UIControllerBase
	{
		// Token: 0x0600DE91 RID: 56977 RVA: 0x003C1CA4 File Offset: 0x003BFEA4
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
			this.m_heroGroupButton.onClick.AddListener(new UnityAction(this.OnChooseHeroButtonClick));
			this.m_heroListPanelBGBackButton.onClick.AddListener(new UnityAction(this.OnHeroListPanelBGBackButtonClick));
			this.m_heroListConfirmButton.onClick.AddListener(new UnityAction(this.OnHeroListConfirmButtonClick));
			this.m_detailConfirmButton.onClick.AddListener(new UnityAction(this.OnDetailConfirmButtonClick));
			this.m_heroListSortButton.onClick.AddListener(new UnityAction(this.OnHeroSortButtonClick));
			this.m_heroListSortTypesLevelToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnLevelToggleChanged));
			this.m_heroListSortTypesStarLvToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnStarLvToggleChanged));
			this.m_heroListSortTypesAchievementToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnAchievementToggleChanged));
			PointDescComponent pointDescComponent = this.m_heroListSortTypesStateCtrl.gameObject.AddComponent<PointDescComponent>();
			pointDescComponent.SetGameObject(this.m_heroListSortTypesStateCtrl.gameObject, true, this.m_heroListSortTypesStateCtrl.gameObject, null);
			pointDescComponent.EventOnClose += delegate()
			{
				this.CloseSortTypesPanel();
			};
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x003C1E90 File Offset: 0x003C0090
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
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, "Show", null, false, true);
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x003C1F0C File Offset: 0x003C010C
		public void UpdateViewInDrillTutor(int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInDrillTutorInt32_hotfix != null)
			{
				this.m_UpdateViewInDrillTutorInt32_hotfix.call(new object[]
				{
					this,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_slot = slot;
			if (this.m_allTaskList.Count == 0)
			{
				this.m_allTaskList.Clear();
				this.m_allTaskList.AddRange(this.m_playerContext.GetAllTodayHeroAssistantsTask());
			}
			if (this.m_curDifficultLevel == 0)
			{
				int playerLevel = this.m_playerContext.GetPlayerLevel();
				for (int i = 0; i < this.m_allTaskList.Count; i++)
				{
					HeroAssistantsTask heroAssistantsTask = this.m_allTaskList[i];
					if (playerLevel < heroAssistantsTask.RequiredUserLevel)
					{
						this.m_curDifficultLevel = i;
						break;
					}
				}
				if (this.m_curDifficultLevel == 0)
				{
					this.m_curDifficultLevel = this.m_allTaskList.Count;
				}
				this.SetDifficultScrollViewPosition();
			}
			if (this.m_curDifficultLevel <= this.m_allTaskList.Count)
			{
				this.m_curHeroAssistantsTask = this.m_allTaskList[this.m_curDifficultLevel - 1];
			}
			else
			{
				this.m_curHeroAssistantsTask = null;
			}
			if (this.m_curHeroAssistantsTask == null)
			{
				CommonUIController.Instance.ShowMessage("HeroAssistantsTask is Null", 2f, null, true);
				return;
			}
			this.SetCurChooseHeros();
			this.SetRewardGroupList();
			this.SetDifficultInfo();
			this.SetConfirmButtonState();
			if (this.m_isFirstIn)
			{
				this.Open();
				this.SetRecommendHeroGroup(this.m_recommendHeroGroup);
				this.SetWorkHour();
				this.SetDifficultBgBySlot();
				this.m_isFirstIn = false;
			}
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x003C20D4 File Offset: 0x003C02D4
		private void SetDifficultScrollViewPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDifficultScrollViewPosition_hotfix != null)
			{
				this.m_SetDifficultScrollViewPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 normalizedPosition = this.m_detailDifficultyGroupScrollRect.normalizedPosition;
			float x = 0f;
			if (this.m_allTaskList.Count > 3)
			{
				if (this.m_allTaskList.Count <= 4)
				{
					if (this.m_curDifficultLevel >= 2)
					{
						x = 1f;
					}
					else
					{
						x = 0f;
					}
				}
				else if (this.m_curDifficultLevel <= 2)
				{
					x = 0f;
				}
				else if (this.m_allTaskList.Count - this.m_curDifficultLevel < 2)
				{
					x = 1f;
				}
				else
				{
					float num = 1f / (float)(this.m_allTaskList.Count - 3);
					x = num * (float)(this.m_curDifficultLevel - 2);
				}
			}
			this.m_detailDifficultyGroupScrollRect.normalizedPosition = new Vector2(x, normalizedPosition.y);
		}

		// Token: 0x0600DE95 RID: 56981 RVA: 0x003C2200 File Offset: 0x003C0400
		private void SetConfirmButtonState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetConfirmButtonState_hotfix != null)
			{
				this.m_SetConfirmButtonState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_curChooseHeroIds.Count > 0;
			if (flag)
			{
				this.m_detailConfirmButtonStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_detailConfirmButtonStateCtrl.SetToUIState("Grey", false, true);
			}
		}

		// Token: 0x0600DE96 RID: 56982 RVA: 0x003C22A0 File Offset: 0x003C04A0
		private void SetDifficultBgBySlot()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDifficultBgBySlot_hotfix != null)
			{
				this.m_SetDifficultBgBySlot_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string name = null;
			switch (this.m_slot)
			{
			case 0:
				name = "UI/Drill_ABS/1/1.png";
				break;
			case 1:
				name = "UI/Drill_ABS/1/2.png";
				break;
			case 2:
				name = "UI/Drill_ABS/1/3.png";
				break;
			}
			this.m_detailDifficultyLevelBGImage.sprite = AssetUtility.Instance.GetSprite(name);
			this.m_teamNumberText.text = (this.m_slot + 1).ToString();
		}

		// Token: 0x0600DE97 RID: 56983 RVA: 0x003C2380 File Offset: 0x003C0580
		private void SetDifficultInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDifficultInfo_hotfix != null)
			{
				this.m_SetDifficultInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int playerLevel = this.m_playerContext.GetPlayerLevel();
			Transform transform = this.m_detailDifficultyGroupContent.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				GameObject gameObject = transform.GetChild(i).gameObject;
				if (i >= this.m_allTaskList.Count)
				{
					gameObject.SetActive(false);
				}
				else
				{
					HeroAssistantsTask heroAssistantsTask = this.m_allTaskList[i];
					TrainingDifficultItemUIController trainingDifficultItemUIController = gameObject.GetComponent<TrainingDifficultItemUIController>();
					if (trainingDifficultItemUIController == null)
					{
						trainingDifficultItemUIController = GameObjectUtility.AddControllerToGameObject<TrainingDifficultItemUIController>(gameObject);
						trainingDifficultItemUIController.EventOnItemClick += this.OnDifficultItemClick;
					}
					trainingDifficultItemUIController.InitDifficultItem(heroAssistantsTask.RequiredUserLevel, i + 1);
					trainingDifficultItemUIController.ShowSelectFrame(playerLevel >= heroAssistantsTask.RequiredUserLevel && trainingDifficultItemUIController.DifficultLevel == this.m_curDifficultLevel);
				}
			}
		}

		// Token: 0x0600DE98 RID: 56984 RVA: 0x003C24B0 File Offset: 0x003C06B0
		private void OnDifficultItemClick(TrainingDifficultItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDifficultItemClickTrainingDifficultItemUIController_hotfix != null)
			{
				this.m_OnDifficultItemClickTrainingDifficultItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.DifficultLevel == this.m_curDifficultLevel)
			{
				return;
			}
			this.m_curDifficultLevel = ctrl.DifficultLevel;
			this.UpdateViewInDrillTutor(this.m_slot);
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x003C254C File Offset: 0x003C074C
		private void SetWorkHour()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWorkHour_hotfix != null)
			{
				this.m_SetWorkHour_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Toggle> list = new List<Toggle>
			{
				this.m_detailTeachingTimeToggle1,
				this.m_detailTeachingTimeToggle2,
				this.m_detailTeachingTimeToggle3
			};
			List<int> rewardWorkSeconds = this.m_curHeroAssistantsTask.RewardWorkSeconds;
			for (int i = 0; i < list.Count; i++)
			{
				Toggle toggle = list[i];
				int workSeconds = rewardWorkSeconds[i];
				for (int j = 0; j < toggle.transform.childCount; j++)
				{
					Transform child = toggle.transform.GetChild(j);
					if (child.name == "TimeText")
					{
						child.GetComponent<Text>().text = (workSeconds / 60 / 60).ToString();
					}
				}
				toggle.onValueChanged.AddListener(delegate(bool isOn)
				{
					if (isOn)
					{
						this.m_curWorkSeconds = workSeconds;
					}
				});
			}
			if (this.m_curWorkSeconds == 0)
			{
				this.m_curWorkSeconds = rewardWorkSeconds[0];
			}
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x003C26C4 File Offset: 0x003C08C4
		private void SetRecommendHeroGroup(GameObject parentGameObject)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecommendHeroGroupGameObject_hotfix != null)
			{
				this.m_SetRecommendHeroGroupGameObject_hotfix.call(new object[]
				{
					this,
					parentGameObject
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (parentGameObject == null)
			{
				return;
			}
			List<int> recommendHeroIds = this.m_curHeroAssistantsTask.RecommendHeroIds;
			int childCount = parentGameObject.transform.childCount;
			if (recommendHeroIds.Count < childCount)
			{
				UIUtility.SetGameObjectChildrenActiveCount(parentGameObject, recommendHeroIds.Count);
				for (int i = 0; i < recommendHeroIds.Count; i++)
				{
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(recommendHeroIds[i]);
					Transform child = parentGameObject.transform.GetChild(i);
					Image component = child.GetComponent<Image>();
					component.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo.m_charImageInfo.SummonHeadImage);
				}
			}
			else
			{
				UIUtility.SetGameObjectChildrenActiveCount(parentGameObject, childCount);
				for (int j = 0; j < recommendHeroIds.Count; j++)
				{
					ConfigDataHeroInfo configDataHeroInfo2 = this.m_configDataLoader.GetConfigDataHeroInfo(recommendHeroIds[j]);
					if (j < childCount)
					{
						Transform child2 = parentGameObject.transform.GetChild(j);
						Image component2 = child2.GetComponent<Image>();
						component2.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo2.m_charImageInfo.SummonHeadImage);
					}
					else
					{
						Transform transform = UnityEngine.Object.Instantiate<Transform>(parentGameObject.transform.GetChild(0));
						Image component3 = transform.GetComponent<Image>();
						component3.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo2.m_charImageInfo.SummonHeadImage);
						transform.transform.SetParent(parentGameObject.transform, false);
					}
				}
			}
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x003C2898 File Offset: 0x003C0A98
		private void SetCurChooseHeros()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurChooseHeros_hotfix != null)
			{
				this.m_SetCurChooseHeros_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> recommendHeroIds = this.m_curHeroAssistantsTask.RecommendHeroIds;
			List<GameObject> list = new List<GameObject>
			{
				this.m_chooseHeroDummy1,
				this.m_chooseHeroDummy2,
				this.m_chooseHeroDummy3
			};
			for (int i = 0; i < list.Count; i++)
			{
				GameObject gameObject = list[i];
				if (i < this.m_curChooseHeroIds.Count)
				{
					Hero hero = this.m_playerContext.GetHero(this.m_curChooseHeroIds[i]);
					if (gameObject.transform.childCount == 0)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_heroItemprefab);
						PrefabControllerCreater.CreateAllControllers(gameObject2);
						gameObject2.transform.SetParent(gameObject.transform, false);
						TrainingHeroItemUIController component = gameObject2.GetComponent<TrainingHeroItemUIController>();
						component.InitTrainingHeroItem(hero, recommendHeroIds.Contains(hero.HeroId));
					}
					else
					{
						Transform child = gameObject.transform.GetChild(0);
						TrainingHeroItemUIController component2 = child.GetComponent<TrainingHeroItemUIController>();
						component2.InitTrainingHeroItem(hero, recommendHeroIds.Contains(hero.HeroId));
						component2.gameObject.SetActive(true);
					}
				}
				else
				{
					UIUtility.SetGameObjectChildrenActiveCount(gameObject, 0);
				}
			}
			this.m_heroDetailAchivementValueText.text = this.CalcHeroTotalAchievementvalue(this.m_curChooseHeroIds) + "%";
		}

		// Token: 0x0600DE9C RID: 56988 RVA: 0x003C2A48 File Offset: 0x003C0C48
		private void SetRewardGroupList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardGroupList_hotfix != null)
			{
				this.m_SetRewardGroupList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> rewardsList = this.GetRewardsList();
			UIUtility.SetGameObjectChildrenActiveCount(this.m_detailRewardGroup, rewardsList.Count);
			if (rewardsList.Count == 0)
			{
				return;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			for (int i = 0; i < rewardsList.Count; i++)
			{
				if (i < this.m_detailRewardGroup.transform.childCount)
				{
					Transform child = this.m_detailRewardGroup.transform.GetChild(i);
					RewardGoodsUIController component = child.GetComponent<RewardGoodsUIController>();
					component.SetReward(rewardsList[i], 0, true);
					component.ShowCount(false);
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					RewardGoodsUIController rewardGoodsUIController = gameObject.GetComponent<RewardGoodsUIController>();
					if (rewardGoodsUIController == null)
					{
						rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(gameObject);
					}
					rewardGoodsUIController.SetReward(rewardsList[i], 0, true);
					rewardGoodsUIController.ShowCount(false);
					gameObject.transform.SetParent(this.m_detailRewardGroup.transform, false);
				}
			}
		}

		// Token: 0x0600DE9D RID: 56989 RVA: 0x003C2B94 File Offset: 0x003C0D94
		private List<Goods> GetRewardsList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardsList_hotfix != null)
			{
				return (List<Goods>)this.m_GetRewardsList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> list = new List<Goods>();
			int num = this.CalcHeroTotalAchievementvalue(this.m_curChooseHeroIds);
			if (num == 0)
			{
				return list;
			}
			int dropIdByTaskCompleteRate = this.m_playerContext.GetDropIdByTaskCompleteRate(this.m_curHeroAssistantsTask.ConfigId, num);
			UIUtility.AppendRandomDropRewardGoodsToList(dropIdByTaskCompleteRate, list);
			if (list.Count > 4)
			{
				list.RemoveRange(4, list.Count - 4);
			}
			return list;
		}

		// Token: 0x0600DE9E RID: 56990 RVA: 0x003C2C58 File Offset: 0x003C0E58
		private void SetChooseHeroListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChooseHeroListPanel_hotfix != null)
			{
				this.m_SetChooseHeroListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetRecommendHeroGroup(this.m_heroListPanelHeroGroup);
			List<Hero> list = new List<Hero>();
			List<Hero> list2 = new List<Hero>();
			List<Hero> list3 = new List<Hero>();
			foreach (Hero hero in this.m_playerContext.GetHeros())
			{
				if (this.m_tempChooseHeroIds.Contains(hero.HeroId))
				{
					list2.Add(hero);
				}
				else
				{
					list3.Add(hero);
				}
			}
			list2.Sort(new Comparison<Hero>(this.HeroListItemComparator));
			list3.Sort(new Comparison<Hero>(this.HeroListItemComparator));
			list.AddRange(list2);
			list.AddRange(list3);
			GameObjectUtility.DestroyChildren(this.m_heroListScrollViewContent);
			List<int> recommendHeroIds = this.m_curHeroAssistantsTask.RecommendHeroIds;
			foreach (Hero hero2 in list)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroItemprefab);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				TrainingHeroItemUIController component = gameObject.GetComponent<TrainingHeroItemUIController>();
				component.InitTrainingHeroItem(hero2, recommendHeroIds.Contains(hero2.HeroId));
				component.EventOnHeroItemClick += this.OnTrainingHeroItemClick;
				if (this.m_tempChooseHeroIds.Contains(hero2.HeroId))
				{
					component.ShowSelectFrameImage(true);
				}
				gameObject.transform.SetParent(this.m_heroListScrollViewContent.transform, false);
			}
			this.SetHeroListResultDetailPanel();
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x003C2E60 File Offset: 0x003C1060
		private int HeroListItemComparator(Hero h1, Hero h2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListItemComparatorHeroHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_HeroListItemComparatorHeroHero_hotfix.call(new object[]
				{
					this,
					h1,
					h2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			switch (this.m_curHeroSortType)
			{
			case DrillTutorUIController.HeroSortType.Level:
				num = h2.Level - h1.Level;
				break;
			case DrillTutorUIController.HeroSortType.StarLv:
				num = h2.StarLevel - h1.StarLevel;
				break;
			case DrillTutorUIController.HeroSortType.Achievement:
				num = this.m_curHeroAssistantsTask.GetHeroAssignPoints(h2) - this.m_curHeroAssistantsTask.GetHeroAssignPoints(h1);
				break;
			}
			if (num != 0)
			{
				return num;
			}
			num = h2.HeroInfo.GetRank(h2.StarLevel) - h1.HeroInfo.GetRank(h1.StarLevel);
			if (num != 0)
			{
				return num;
			}
			return h1.HeroId - h2.HeroId;
		}

		// Token: 0x0600DEA0 RID: 56992 RVA: 0x003C2F98 File Offset: 0x003C1198
		private void OnTrainingHeroItemClick(TrainingHeroItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingHeroItemClickTrainingHeroItemUIController_hotfix != null)
			{
				this.m_OnTrainingHeroItemClickTrainingHeroItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroId = ctrl.m_hero.HeroId;
			if (this.m_tempChooseHeroIds.Contains(heroId))
			{
				ctrl.ShowSelectFrameImage(false);
				this.m_tempChooseHeroIds.Remove(heroId);
			}
			else
			{
				if (this.m_tempChooseHeroIds.Count == 3)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_AlreadyHaveThreeHero, 2f, null, true);
					return;
				}
				ctrl.ShowSelectFrameImage(true);
				this.m_tempChooseHeroIds.Add(heroId);
			}
			this.SetHeroListResultDetailPanel();
		}

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x003C3080 File Offset: 0x003C1280
		private void SetHeroListResultDetailPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroListResultDetailPanel_hotfix != null)
			{
				this.m_SetHeroListResultDetailPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroListChooseCountValueText.text = this.m_tempChooseHeroIds.Count + "/3";
			this.m_heroListAchivementValueText.text = this.CalcHeroTotalAchievementvalue(this.m_tempChooseHeroIds).ToString();
		}

		// Token: 0x0600DEA2 RID: 56994 RVA: 0x003C312C File Offset: 0x003C132C
		private int CalcHeroTotalAchievementvalue(List<int> heroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcHeroTotalAchievementvalueList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalcHeroTotalAchievementvalueList`1_hotfix.call(new object[]
				{
					this,
					heroIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroAssignPoints = this.m_curHeroAssistantsTask.GetHeroAssignPoints(heroIds);
			return Math.Min(100, heroAssignPoints * 100 / this.m_curHeroAssistantsTask.CompletePoints);
		}

		// Token: 0x0600DEA3 RID: 56995 RVA: 0x003C31D0 File Offset: 0x003C13D0
		private void OnChooseHeroButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChooseHeroButtonClick_hotfix != null)
			{
				this.m_OnChooseHeroButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curHeroAssistantsTask == null)
			{
				return;
			}
			this.m_tempChooseHeroIds.Clear();
			this.m_tempChooseHeroIds.AddRange(this.m_curChooseHeroIds);
			this.SetChooseHeroListPanel();
			this.m_heroListPanelStateCtrl.gameObject.SetActive(true);
			this.m_heroListPanelStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x003C3284 File Offset: 0x003C1484
		private void OnHeroListConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroListConfirmButtonClick_hotfix != null)
			{
				this.m_OnHeroListConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curChooseHeroIds.Clear();
			this.m_curChooseHeroIds.AddRange(this.m_tempChooseHeroIds);
			this.m_heroListPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_heroListScrollRect.normalizedPosition = Vector2.one;
				this.m_heroListPanelStateCtrl.gameObject.SetActive(false);
				this.SetCurChooseHeros();
				this.SetRewardGroupList();
				this.SetConfirmButtonState();
			});
			this.m_heroListPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x003C3330 File Offset: 0x003C1530
		private void OnHeroListPanelBGBackButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroListPanelBGBackButtonClick_hotfix != null)
			{
				this.m_OnHeroListPanelBGBackButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroListPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_heroListScrollRect.normalizedPosition = Vector2.one;
				this.m_heroListPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_heroListPanelStateCtrl.SetToUIState("Close", false, true);
			this.m_tempChooseHeroIds.Clear();
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x003C33CC File Offset: 0x003C15CC
		private void OnDetailConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDetailConfirmButtonClick_hotfix != null)
			{
				this.m_OnDetailConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanAssignHero(this.m_curChooseHeroIds, this.m_curHeroAssistantsTask.ConfigId, this.m_slot, this.m_curWorkSeconds);
			if (num == 0)
			{
				if (this.EventOnConfirmAssistant != null)
				{
					this.EventOnConfirmAssistant(this.m_curHeroAssistantsTask.ConfigId, this.m_curChooseHeroIds, this.m_curWorkSeconds, this.m_slot);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x003C34A8 File Offset: 0x003C16A8
		public void PlayStartTeachEffect(Action OnEffectFinish)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayStartTeachEffectAction_hotfix != null)
			{
				this.m_PlayStartTeachEffectAction_hotfix.call(new object[]
				{
					this,
					OnEffectFinish2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnEffectFinish = OnEffectFinish2;
			DrillTutorUIController $this = this;
			this.ResetData();
			UIUtility.SetUIStateOpen(this.m_teachStartPanelStateCtrl, "Show", delegate
			{
				$this.m_teachStartPanelStateCtrl.gameObject.SetActive(false);
				OnEffectFinish();
			}, true, true);
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x003C3550 File Offset: 0x003C1750
		private void OnLevelToggleChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelToggleChangedBoolean_hotfix != null)
			{
				this.m_OnLevelToggleChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curHeroSortType = DrillTutorUIController.HeroSortType.Level;
				this.SetChooseHeroListPanel();
				this.m_heroListSortButtonTypeText.text = this.m_heroListSortTypesLevelToggle.transform.GetComponentInChildren<Text>().text;
			}
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x003C35F4 File Offset: 0x003C17F4
		private void OnStarLvToggleChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStarLvToggleChangedBoolean_hotfix != null)
			{
				this.m_OnStarLvToggleChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curHeroSortType = DrillTutorUIController.HeroSortType.StarLv;
				this.SetChooseHeroListPanel();
				this.m_heroListSortButtonTypeText.text = this.m_heroListSortTypesStarLvToggle.transform.GetComponentInChildren<Text>().text;
			}
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x003C3698 File Offset: 0x003C1898
		private void OnAchievementToggleChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementToggleChangedBoolean_hotfix != null)
			{
				this.m_OnAchievementToggleChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curHeroSortType = DrillTutorUIController.HeroSortType.Achievement;
				this.SetChooseHeroListPanel();
				this.m_heroListSortButtonTypeText.text = this.m_heroListSortTypesAchievementToggle.transform.GetComponentInChildren<Text>().text;
			}
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x003C373C File Offset: 0x003C193C
		private void OnHeroSortButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroSortButtonClick_hotfix != null)
			{
				this.m_OnHeroSortButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroListSortTypesStateCtrl.gameObject.SetActive(true);
			this.m_heroListSortTypesStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600DEAC RID: 57004 RVA: 0x003C37C0 File Offset: 0x003C19C0
		private void CloseSortTypesPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSortTypesPanel_hotfix != null)
			{
				this.m_CloseSortTypesPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroListSortTypesStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_heroListSortTypesStateCtrl.gameObject.SetActive(false);
			});
			this.m_heroListSortTypesStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600DEAD RID: 57005 RVA: 0x003C3850 File Offset: 0x003C1A50
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
			this.ResetData();
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x003C38CC File Offset: 0x003C1ACC
		private void ResetData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetData_hotfix != null)
			{
				this.m_ResetData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_allTaskList.Clear();
			this.m_curChooseHeroIds.Clear();
			this.m_tempChooseHeroIds.Clear();
			this.m_curDifficultLevel = 0;
			this.m_curHeroAssistantsTask = null;
			this.m_isFirstIn = true;
		}

		// Token: 0x0600DEAF RID: 57007 RVA: 0x003C3964 File Offset: 0x003C1B64
		public void OnHelpButtonClick()
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
			if (this.EventOnShowTutorHelp != null)
			{
				this.EventOnShowTutorHelp();
			}
		}

		// Token: 0x140002C4 RID: 708
		// (add) Token: 0x0600DEB0 RID: 57008 RVA: 0x003C39DC File Offset: 0x003C1BDC
		// (remove) Token: 0x0600DEB1 RID: 57009 RVA: 0x003C3A78 File Offset: 0x003C1C78
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

		// Token: 0x140002C5 RID: 709
		// (add) Token: 0x0600DEB2 RID: 57010 RVA: 0x003C3B14 File Offset: 0x003C1D14
		// (remove) Token: 0x0600DEB3 RID: 57011 RVA: 0x003C3BB0 File Offset: 0x003C1DB0
		public event Action EventOnShowTutorHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowTutorHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowTutorHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTutorHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTutorHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowTutorHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowTutorHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowTutorHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowTutorHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002C6 RID: 710
		// (add) Token: 0x0600DEB4 RID: 57012 RVA: 0x003C3C4C File Offset: 0x003C1E4C
		// (remove) Token: 0x0600DEB5 RID: 57013 RVA: 0x003C3CE8 File Offset: 0x003C1EE8
		public event Action<int, List<int>, int, int> EventOnConfirmAssistant
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmAssistantAction`4_hotfix != null)
				{
					this.m_add_EventOnConfirmAssistantAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, List<int>, int, int> action = this.EventOnConfirmAssistant;
				Action<int, List<int>, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, List<int>, int, int>>(ref this.EventOnConfirmAssistant, (Action<int, List<int>, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmAssistantAction`4_hotfix != null)
				{
					this.m_remove_EventOnConfirmAssistantAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, List<int>, int, int> action = this.EventOnConfirmAssistant;
				Action<int, List<int>, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, List<int>, int, int>>(ref this.EventOnConfirmAssistant, (Action<int, List<int>, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x0600DEB6 RID: 57014 RVA: 0x003C3D84 File Offset: 0x003C1F84
		// (set) Token: 0x0600DEB7 RID: 57015 RVA: 0x003C3DA4 File Offset: 0x003C1FA4
		[DoNotToLua]
		public new DrillTutorUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DrillTutorUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x003C3DB0 File Offset: 0x003C1FB0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x003C3DBC File Offset: 0x003C1FBC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DEBA RID: 57018 RVA: 0x003C3DC4 File Offset: 0x003C1FC4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x003C3DCC File Offset: 0x003C1FCC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x003C3DE0 File Offset: 0x003C1FE0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x003C3DE8 File Offset: 0x003C1FE8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x003C3DF4 File Offset: 0x003C1FF4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DEBF RID: 57023 RVA: 0x003C3E00 File Offset: 0x003C2000
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DEC0 RID: 57024 RVA: 0x003C3E0C File Offset: 0x003C200C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x003C3E18 File Offset: 0x003C2018
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DEC2 RID: 57026 RVA: 0x003C3E24 File Offset: 0x003C2024
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x003C3E30 File Offset: 0x003C2030
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x003C3E3C File Offset: 0x003C203C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DEC5 RID: 57029 RVA: 0x003C3E48 File Offset: 0x003C2048
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x003C3E54 File Offset: 0x003C2054
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x003C3E5C File Offset: 0x003C205C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x003C3E7C File Offset: 0x003C207C
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x003C3E88 File Offset: 0x003C2088
		private void __callDele_EventOnShowTutorHelp()
		{
			Action eventOnShowTutorHelp = this.EventOnShowTutorHelp;
			if (eventOnShowTutorHelp != null)
			{
				eventOnShowTutorHelp();
			}
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x003C3EA8 File Offset: 0x003C20A8
		private void __clearDele_EventOnShowTutorHelp()
		{
			this.EventOnShowTutorHelp = null;
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x003C3EB4 File Offset: 0x003C20B4
		private void __callDele_EventOnConfirmAssistant(int arg1, List<int> arg2, int arg3, int arg4)
		{
			Action<int, List<int>, int, int> eventOnConfirmAssistant = this.EventOnConfirmAssistant;
			if (eventOnConfirmAssistant != null)
			{
				eventOnConfirmAssistant(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x003C3EDC File Offset: 0x003C20DC
		private void __clearDele_EventOnConfirmAssistant(int arg1, List<int> arg2, int arg3, int arg4)
		{
			this.EventOnConfirmAssistant = null;
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x003C3F60 File Offset: 0x003C2160
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
					this.m_UpdateViewInDrillTutorInt32_hotfix = (luaObj.RawGet("UpdateViewInDrillTutor") as LuaFunction);
					this.m_SetDifficultScrollViewPosition_hotfix = (luaObj.RawGet("SetDifficultScrollViewPosition") as LuaFunction);
					this.m_SetConfirmButtonState_hotfix = (luaObj.RawGet("SetConfirmButtonState") as LuaFunction);
					this.m_SetDifficultBgBySlot_hotfix = (luaObj.RawGet("SetDifficultBgBySlot") as LuaFunction);
					this.m_SetDifficultInfo_hotfix = (luaObj.RawGet("SetDifficultInfo") as LuaFunction);
					this.m_OnDifficultItemClickTrainingDifficultItemUIController_hotfix = (luaObj.RawGet("OnDifficultItemClick") as LuaFunction);
					this.m_SetWorkHour_hotfix = (luaObj.RawGet("SetWorkHour") as LuaFunction);
					this.m_SetRecommendHeroGroupGameObject_hotfix = (luaObj.RawGet("SetRecommendHeroGroup") as LuaFunction);
					this.m_SetCurChooseHeros_hotfix = (luaObj.RawGet("SetCurChooseHeros") as LuaFunction);
					this.m_SetRewardGroupList_hotfix = (luaObj.RawGet("SetRewardGroupList") as LuaFunction);
					this.m_GetRewardsList_hotfix = (luaObj.RawGet("GetRewardsList") as LuaFunction);
					this.m_SetChooseHeroListPanel_hotfix = (luaObj.RawGet("SetChooseHeroListPanel") as LuaFunction);
					this.m_HeroListItemComparatorHeroHero_hotfix = (luaObj.RawGet("HeroListItemComparator") as LuaFunction);
					this.m_OnTrainingHeroItemClickTrainingHeroItemUIController_hotfix = (luaObj.RawGet("OnTrainingHeroItemClick") as LuaFunction);
					this.m_SetHeroListResultDetailPanel_hotfix = (luaObj.RawGet("SetHeroListResultDetailPanel") as LuaFunction);
					this.m_CalcHeroTotalAchievementvalueList`1_hotfix = (luaObj.RawGet("CalcHeroTotalAchievementvalue") as LuaFunction);
					this.m_OnChooseHeroButtonClick_hotfix = (luaObj.RawGet("OnChooseHeroButtonClick") as LuaFunction);
					this.m_OnHeroListConfirmButtonClick_hotfix = (luaObj.RawGet("OnHeroListConfirmButtonClick") as LuaFunction);
					this.m_OnHeroListPanelBGBackButtonClick_hotfix = (luaObj.RawGet("OnHeroListPanelBGBackButtonClick") as LuaFunction);
					this.m_OnDetailConfirmButtonClick_hotfix = (luaObj.RawGet("OnDetailConfirmButtonClick") as LuaFunction);
					this.m_PlayStartTeachEffectAction_hotfix = (luaObj.RawGet("PlayStartTeachEffect") as LuaFunction);
					this.m_OnLevelToggleChangedBoolean_hotfix = (luaObj.RawGet("OnLevelToggleChanged") as LuaFunction);
					this.m_OnStarLvToggleChangedBoolean_hotfix = (luaObj.RawGet("OnStarLvToggleChanged") as LuaFunction);
					this.m_OnAchievementToggleChangedBoolean_hotfix = (luaObj.RawGet("OnAchievementToggleChanged") as LuaFunction);
					this.m_OnHeroSortButtonClick_hotfix = (luaObj.RawGet("OnHeroSortButtonClick") as LuaFunction);
					this.m_CloseSortTypesPanel_hotfix = (luaObj.RawGet("CloseSortTypesPanel") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_ResetData_hotfix = (luaObj.RawGet("ResetData") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowTutorHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowTutorHelp") as LuaFunction);
					this.m_remove_EventOnShowTutorHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowTutorHelp") as LuaFunction);
					this.m_add_EventOnConfirmAssistantAction`4_hotfix = (luaObj.RawGet("add_EventOnConfirmAssistant") as LuaFunction);
					this.m_remove_EventOnConfirmAssistantAction`4_hotfix = (luaObj.RawGet("remove_EventOnConfirmAssistant") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DED2 RID: 57042 RVA: 0x003C43B0 File Offset: 0x003C25B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DrillTutorUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040087A2 RID: 34722
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040087A3 RID: 34723
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x040087A4 RID: 34724
		[AutoBind("./LeftPanel/HeroGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_recommendHeroGroup;

		// Token: 0x040087A5 RID: 34725
		[AutoBind("./Detail/HeroGroupButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroGroupButton;

		// Token: 0x040087A6 RID: 34726
		[AutoBind("./Detail/HeroGroup/HeroEmptyButton1/HeroItemDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chooseHeroDummy1;

		// Token: 0x040087A7 RID: 34727
		[AutoBind("./Detail/HeroGroup/HeroEmptyButton2/HeroItemDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chooseHeroDummy2;

		// Token: 0x040087A8 RID: 34728
		[AutoBind("./Detail/HeroGroup/HeroEmptyButton3/HeroItemDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chooseHeroDummy3;

		// Token: 0x040087A9 RID: 34729
		[AutoBind("./Detail/AchivementValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroDetailAchivementValueText;

		// Token: 0x040087AA RID: 34730
		[AutoBind("./HeroListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroListPanelStateCtrl;

		// Token: 0x040087AB RID: 34731
		[AutoBind("./HeroListPanel/BGBackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroListPanelBGBackButton;

		// Token: 0x040087AC RID: 34732
		[AutoBind("./HeroListPanel/LeftPanel/HeroGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroListPanelHeroGroup;

		// Token: 0x040087AD RID: 34733
		[AutoBind("./HeroListPanel/HeroList/HeroListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_heroListScrollRect;

		// Token: 0x040087AE RID: 34734
		[AutoBind("./HeroListPanel/HeroList/HeroListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroListScrollViewContent;

		// Token: 0x040087AF RID: 34735
		[AutoBind("./HeroListPanel/HeroList/ResultDetailPanel/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroListConfirmButton;

		// Token: 0x040087B0 RID: 34736
		[AutoBind("./HeroListPanel/HeroList/ResultDetailPanel/ChooseValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroListChooseCountValueText;

		// Token: 0x040087B1 RID: 34737
		[AutoBind("./HeroListPanel/HeroList/ResultDetailPanel/AchivementValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroListAchivementValueText;

		// Token: 0x040087B2 RID: 34738
		[AutoBind("./HeroListPanel/HeroList/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroListSortButton;

		// Token: 0x040087B3 RID: 34739
		[AutoBind("./HeroListPanel/HeroList/SortButton/SortTypeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroListSortButtonTypeText;

		// Token: 0x040087B4 RID: 34740
		[AutoBind("./HeroListPanel/HeroList/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroListSortTypesStateCtrl;

		// Token: 0x040087B5 RID: 34741
		[AutoBind("./HeroListPanel/HeroList/SortTypes/GridLayout/Level", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_heroListSortTypesLevelToggle;

		// Token: 0x040087B6 RID: 34742
		[AutoBind("./HeroListPanel/HeroList/SortTypes/GridLayout/Star", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_heroListSortTypesStarLvToggle;

		// Token: 0x040087B7 RID: 34743
		[AutoBind("./HeroListPanel/HeroList/SortTypes/GridLayout/Achievement", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_heroListSortTypesAchievementToggle;

		// Token: 0x040087B8 RID: 34744
		[AutoBind("./Detail/DifficultyGroup/LevelBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_detailDifficultyLevelBGImage;

		// Token: 0x040087B9 RID: 34745
		[AutoBind("./Detail/TeamNumber/TeamNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_teamNumberText;

		// Token: 0x040087BA RID: 34746
		[AutoBind("./Detail/DifficultyGroup/DifficultyGroup", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_detailDifficultyGroupScrollRect;

		// Token: 0x040087BB RID: 34747
		[AutoBind("./Detail/DifficultyGroup/DifficultyGroup/Viewport/Group", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_detailDifficultyGroupContent;

		// Token: 0x040087BC RID: 34748
		[AutoBind("./Detail/TodayRewardGroup/RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_detailRewardGroup;

		// Token: 0x040087BD RID: 34749
		[AutoBind("./Detail/TeachingTimeGroup/Time1", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_detailTeachingTimeToggle1;

		// Token: 0x040087BE RID: 34750
		[AutoBind("./Detail/TeachingTimeGroup/Time2", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_detailTeachingTimeToggle2;

		// Token: 0x040087BF RID: 34751
		[AutoBind("./Detail/TeachingTimeGroup/Time3", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_detailTeachingTimeToggle3;

		// Token: 0x040087C0 RID: 34752
		[AutoBind("./Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detailConfirmButton;

		// Token: 0x040087C1 RID: 34753
		[AutoBind("./Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_detailConfirmButtonStateCtrl;

		// Token: 0x040087C2 RID: 34754
		[AutoBind("./TeachStart", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_teachStartPanelStateCtrl;

		// Token: 0x040087C3 RID: 34755
		[AutoBind("./Prefab/HeroItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroItemprefab;

		// Token: 0x040087C4 RID: 34756
		private DrillTutorUIController.HeroSortType m_curHeroSortType = DrillTutorUIController.HeroSortType.Achievement;

		// Token: 0x040087C5 RID: 34757
		private List<int> m_curChooseHeroIds = new List<int>();

		// Token: 0x040087C6 RID: 34758
		private List<int> m_tempChooseHeroIds = new List<int>();

		// Token: 0x040087C7 RID: 34759
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040087C8 RID: 34760
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040087C9 RID: 34761
		private HeroAssistantsTask m_curHeroAssistantsTask;

		// Token: 0x040087CA RID: 34762
		private int m_curDifficultLevel;

		// Token: 0x040087CB RID: 34763
		private int m_curWorkSeconds;

		// Token: 0x040087CC RID: 34764
		private List<HeroAssistantsTask> m_allTaskList = new List<HeroAssistantsTask>();

		// Token: 0x040087CD RID: 34765
		private int m_slot;

		// Token: 0x040087CE RID: 34766
		private bool m_isFirstIn = true;

		// Token: 0x040087CF RID: 34767
		[DoNotToLua]
		private DrillTutorUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040087D0 RID: 34768
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040087D1 RID: 34769
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040087D2 RID: 34770
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040087D3 RID: 34771
		private LuaFunction m_Open_hotfix;

		// Token: 0x040087D4 RID: 34772
		private LuaFunction m_UpdateViewInDrillTutorInt32_hotfix;

		// Token: 0x040087D5 RID: 34773
		private LuaFunction m_SetDifficultScrollViewPosition_hotfix;

		// Token: 0x040087D6 RID: 34774
		private LuaFunction m_SetConfirmButtonState_hotfix;

		// Token: 0x040087D7 RID: 34775
		private LuaFunction m_SetDifficultBgBySlot_hotfix;

		// Token: 0x040087D8 RID: 34776
		private LuaFunction m_SetDifficultInfo_hotfix;

		// Token: 0x040087D9 RID: 34777
		private LuaFunction m_OnDifficultItemClickTrainingDifficultItemUIController_hotfix;

		// Token: 0x040087DA RID: 34778
		private LuaFunction m_SetWorkHour_hotfix;

		// Token: 0x040087DB RID: 34779
		private LuaFunction m_SetRecommendHeroGroupGameObject_hotfix;

		// Token: 0x040087DC RID: 34780
		private LuaFunction m_SetCurChooseHeros_hotfix;

		// Token: 0x040087DD RID: 34781
		private LuaFunction m_SetRewardGroupList_hotfix;

		// Token: 0x040087DE RID: 34782
		private LuaFunction m_GetRewardsList_hotfix;

		// Token: 0x040087DF RID: 34783
		private LuaFunction m_SetChooseHeroListPanel_hotfix;

		// Token: 0x040087E0 RID: 34784
		private LuaFunction m_HeroListItemComparatorHeroHero_hotfix;

		// Token: 0x040087E1 RID: 34785
		private LuaFunction m_OnTrainingHeroItemClickTrainingHeroItemUIController_hotfix;

		// Token: 0x040087E2 RID: 34786
		private LuaFunction m_SetHeroListResultDetailPanel_hotfix;

		// Token: 0x040087E3 RID: 34787
		private LuaFunction m_CalcHeroTotalAchievementvalueList;

		// Token: 0x040087E4 RID: 34788
		private LuaFunction m_OnChooseHeroButtonClick_hotfix;

		// Token: 0x040087E5 RID: 34789
		private LuaFunction m_OnHeroListConfirmButtonClick_hotfix;

		// Token: 0x040087E6 RID: 34790
		private LuaFunction m_OnHeroListPanelBGBackButtonClick_hotfix;

		// Token: 0x040087E7 RID: 34791
		private LuaFunction m_OnDetailConfirmButtonClick_hotfix;

		// Token: 0x040087E8 RID: 34792
		private LuaFunction m_PlayStartTeachEffectAction_hotfix;

		// Token: 0x040087E9 RID: 34793
		private LuaFunction m_OnLevelToggleChangedBoolean_hotfix;

		// Token: 0x040087EA RID: 34794
		private LuaFunction m_OnStarLvToggleChangedBoolean_hotfix;

		// Token: 0x040087EB RID: 34795
		private LuaFunction m_OnAchievementToggleChangedBoolean_hotfix;

		// Token: 0x040087EC RID: 34796
		private LuaFunction m_OnHeroSortButtonClick_hotfix;

		// Token: 0x040087ED RID: 34797
		private LuaFunction m_CloseSortTypesPanel_hotfix;

		// Token: 0x040087EE RID: 34798
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040087EF RID: 34799
		private LuaFunction m_ResetData_hotfix;

		// Token: 0x040087F0 RID: 34800
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x040087F1 RID: 34801
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040087F2 RID: 34802
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x040087F3 RID: 34803
		private LuaFunction m_add_EventOnShowTutorHelpAction_hotfix;

		// Token: 0x040087F4 RID: 34804
		private LuaFunction m_remove_EventOnShowTutorHelpAction_hotfix;

		// Token: 0x040087F5 RID: 34805
		private LuaFunction m_add_EventOnConfirmAssistantAction;

		// Token: 0x040087F6 RID: 34806
		private LuaFunction m_remove_EventOnConfirmAssistantAction;

		// Token: 0x02000C4E RID: 3150
		public enum HeroSortType
		{
			// Token: 0x040087F8 RID: 34808
			Level,
			// Token: 0x040087F9 RID: 34809
			StarLv,
			// Token: 0x040087FA RID: 34810
			Achievement
		}

		// Token: 0x02000C4F RID: 3151
		public new class LuaExportHelper
		{
			// Token: 0x0600DED3 RID: 57043 RVA: 0x003C4418 File Offset: 0x003C2618
			public LuaExportHelper(DrillTutorUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DED4 RID: 57044 RVA: 0x003C4428 File Offset: 0x003C2628
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DED5 RID: 57045 RVA: 0x003C4438 File Offset: 0x003C2638
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DED6 RID: 57046 RVA: 0x003C4448 File Offset: 0x003C2648
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DED7 RID: 57047 RVA: 0x003C4458 File Offset: 0x003C2658
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DED8 RID: 57048 RVA: 0x003C4470 File Offset: 0x003C2670
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DED9 RID: 57049 RVA: 0x003C4480 File Offset: 0x003C2680
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DEDA RID: 57050 RVA: 0x003C4490 File Offset: 0x003C2690
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DEDB RID: 57051 RVA: 0x003C44A0 File Offset: 0x003C26A0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DEDC RID: 57052 RVA: 0x003C44B0 File Offset: 0x003C26B0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DEDD RID: 57053 RVA: 0x003C44C0 File Offset: 0x003C26C0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DEDE RID: 57054 RVA: 0x003C44D0 File Offset: 0x003C26D0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DEDF RID: 57055 RVA: 0x003C44E0 File Offset: 0x003C26E0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DEE0 RID: 57056 RVA: 0x003C44F0 File Offset: 0x003C26F0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DEE1 RID: 57057 RVA: 0x003C4500 File Offset: 0x003C2700
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DEE2 RID: 57058 RVA: 0x003C4510 File Offset: 0x003C2710
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DEE3 RID: 57059 RVA: 0x003C4520 File Offset: 0x003C2720
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600DEE4 RID: 57060 RVA: 0x003C4530 File Offset: 0x003C2730
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600DEE5 RID: 57061 RVA: 0x003C4540 File Offset: 0x003C2740
			public void __callDele_EventOnShowTutorHelp()
			{
				this.m_owner.__callDele_EventOnShowTutorHelp();
			}

			// Token: 0x0600DEE6 RID: 57062 RVA: 0x003C4550 File Offset: 0x003C2750
			public void __clearDele_EventOnShowTutorHelp()
			{
				this.m_owner.__clearDele_EventOnShowTutorHelp();
			}

			// Token: 0x0600DEE7 RID: 57063 RVA: 0x003C4560 File Offset: 0x003C2760
			public void __callDele_EventOnConfirmAssistant(int arg1, List<int> arg2, int arg3, int arg4)
			{
				this.m_owner.__callDele_EventOnConfirmAssistant(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0600DEE8 RID: 57064 RVA: 0x003C4574 File Offset: 0x003C2774
			public void __clearDele_EventOnConfirmAssistant(int arg1, List<int> arg2, int arg3, int arg4)
			{
				this.m_owner.__clearDele_EventOnConfirmAssistant(arg1, arg2, arg3, arg4);
			}

			// Token: 0x17002B3C RID: 11068
			// (get) Token: 0x0600DEE9 RID: 57065 RVA: 0x003C4588 File Offset: 0x003C2788
			// (set) Token: 0x0600DEEA RID: 57066 RVA: 0x003C4598 File Offset: 0x003C2798
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

			// Token: 0x17002B3D RID: 11069
			// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x003C45A8 File Offset: 0x003C27A8
			// (set) Token: 0x0600DEEC RID: 57068 RVA: 0x003C45B8 File Offset: 0x003C27B8
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

			// Token: 0x17002B3E RID: 11070
			// (get) Token: 0x0600DEED RID: 57069 RVA: 0x003C45C8 File Offset: 0x003C27C8
			// (set) Token: 0x0600DEEE RID: 57070 RVA: 0x003C45D8 File Offset: 0x003C27D8
			public GameObject m_recommendHeroGroup
			{
				get
				{
					return this.m_owner.m_recommendHeroGroup;
				}
				set
				{
					this.m_owner.m_recommendHeroGroup = value;
				}
			}

			// Token: 0x17002B3F RID: 11071
			// (get) Token: 0x0600DEEF RID: 57071 RVA: 0x003C45E8 File Offset: 0x003C27E8
			// (set) Token: 0x0600DEF0 RID: 57072 RVA: 0x003C45F8 File Offset: 0x003C27F8
			public Button m_heroGroupButton
			{
				get
				{
					return this.m_owner.m_heroGroupButton;
				}
				set
				{
					this.m_owner.m_heroGroupButton = value;
				}
			}

			// Token: 0x17002B40 RID: 11072
			// (get) Token: 0x0600DEF1 RID: 57073 RVA: 0x003C4608 File Offset: 0x003C2808
			// (set) Token: 0x0600DEF2 RID: 57074 RVA: 0x003C4618 File Offset: 0x003C2818
			public GameObject m_chooseHeroDummy1
			{
				get
				{
					return this.m_owner.m_chooseHeroDummy1;
				}
				set
				{
					this.m_owner.m_chooseHeroDummy1 = value;
				}
			}

			// Token: 0x17002B41 RID: 11073
			// (get) Token: 0x0600DEF3 RID: 57075 RVA: 0x003C4628 File Offset: 0x003C2828
			// (set) Token: 0x0600DEF4 RID: 57076 RVA: 0x003C4638 File Offset: 0x003C2838
			public GameObject m_chooseHeroDummy2
			{
				get
				{
					return this.m_owner.m_chooseHeroDummy2;
				}
				set
				{
					this.m_owner.m_chooseHeroDummy2 = value;
				}
			}

			// Token: 0x17002B42 RID: 11074
			// (get) Token: 0x0600DEF5 RID: 57077 RVA: 0x003C4648 File Offset: 0x003C2848
			// (set) Token: 0x0600DEF6 RID: 57078 RVA: 0x003C4658 File Offset: 0x003C2858
			public GameObject m_chooseHeroDummy3
			{
				get
				{
					return this.m_owner.m_chooseHeroDummy3;
				}
				set
				{
					this.m_owner.m_chooseHeroDummy3 = value;
				}
			}

			// Token: 0x17002B43 RID: 11075
			// (get) Token: 0x0600DEF7 RID: 57079 RVA: 0x003C4668 File Offset: 0x003C2868
			// (set) Token: 0x0600DEF8 RID: 57080 RVA: 0x003C4678 File Offset: 0x003C2878
			public Text m_heroDetailAchivementValueText
			{
				get
				{
					return this.m_owner.m_heroDetailAchivementValueText;
				}
				set
				{
					this.m_owner.m_heroDetailAchivementValueText = value;
				}
			}

			// Token: 0x17002B44 RID: 11076
			// (get) Token: 0x0600DEF9 RID: 57081 RVA: 0x003C4688 File Offset: 0x003C2888
			// (set) Token: 0x0600DEFA RID: 57082 RVA: 0x003C4698 File Offset: 0x003C2898
			public CommonUIStateController m_heroListPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_heroListPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_heroListPanelStateCtrl = value;
				}
			}

			// Token: 0x17002B45 RID: 11077
			// (get) Token: 0x0600DEFB RID: 57083 RVA: 0x003C46A8 File Offset: 0x003C28A8
			// (set) Token: 0x0600DEFC RID: 57084 RVA: 0x003C46B8 File Offset: 0x003C28B8
			public Button m_heroListPanelBGBackButton
			{
				get
				{
					return this.m_owner.m_heroListPanelBGBackButton;
				}
				set
				{
					this.m_owner.m_heroListPanelBGBackButton = value;
				}
			}

			// Token: 0x17002B46 RID: 11078
			// (get) Token: 0x0600DEFD RID: 57085 RVA: 0x003C46C8 File Offset: 0x003C28C8
			// (set) Token: 0x0600DEFE RID: 57086 RVA: 0x003C46D8 File Offset: 0x003C28D8
			public GameObject m_heroListPanelHeroGroup
			{
				get
				{
					return this.m_owner.m_heroListPanelHeroGroup;
				}
				set
				{
					this.m_owner.m_heroListPanelHeroGroup = value;
				}
			}

			// Token: 0x17002B47 RID: 11079
			// (get) Token: 0x0600DEFF RID: 57087 RVA: 0x003C46E8 File Offset: 0x003C28E8
			// (set) Token: 0x0600DF00 RID: 57088 RVA: 0x003C46F8 File Offset: 0x003C28F8
			public ScrollRect m_heroListScrollRect
			{
				get
				{
					return this.m_owner.m_heroListScrollRect;
				}
				set
				{
					this.m_owner.m_heroListScrollRect = value;
				}
			}

			// Token: 0x17002B48 RID: 11080
			// (get) Token: 0x0600DF01 RID: 57089 RVA: 0x003C4708 File Offset: 0x003C2908
			// (set) Token: 0x0600DF02 RID: 57090 RVA: 0x003C4718 File Offset: 0x003C2918
			public GameObject m_heroListScrollViewContent
			{
				get
				{
					return this.m_owner.m_heroListScrollViewContent;
				}
				set
				{
					this.m_owner.m_heroListScrollViewContent = value;
				}
			}

			// Token: 0x17002B49 RID: 11081
			// (get) Token: 0x0600DF03 RID: 57091 RVA: 0x003C4728 File Offset: 0x003C2928
			// (set) Token: 0x0600DF04 RID: 57092 RVA: 0x003C4738 File Offset: 0x003C2938
			public Button m_heroListConfirmButton
			{
				get
				{
					return this.m_owner.m_heroListConfirmButton;
				}
				set
				{
					this.m_owner.m_heroListConfirmButton = value;
				}
			}

			// Token: 0x17002B4A RID: 11082
			// (get) Token: 0x0600DF05 RID: 57093 RVA: 0x003C4748 File Offset: 0x003C2948
			// (set) Token: 0x0600DF06 RID: 57094 RVA: 0x003C4758 File Offset: 0x003C2958
			public Text m_heroListChooseCountValueText
			{
				get
				{
					return this.m_owner.m_heroListChooseCountValueText;
				}
				set
				{
					this.m_owner.m_heroListChooseCountValueText = value;
				}
			}

			// Token: 0x17002B4B RID: 11083
			// (get) Token: 0x0600DF07 RID: 57095 RVA: 0x003C4768 File Offset: 0x003C2968
			// (set) Token: 0x0600DF08 RID: 57096 RVA: 0x003C4778 File Offset: 0x003C2978
			public Text m_heroListAchivementValueText
			{
				get
				{
					return this.m_owner.m_heroListAchivementValueText;
				}
				set
				{
					this.m_owner.m_heroListAchivementValueText = value;
				}
			}

			// Token: 0x17002B4C RID: 11084
			// (get) Token: 0x0600DF09 RID: 57097 RVA: 0x003C4788 File Offset: 0x003C2988
			// (set) Token: 0x0600DF0A RID: 57098 RVA: 0x003C4798 File Offset: 0x003C2998
			public Button m_heroListSortButton
			{
				get
				{
					return this.m_owner.m_heroListSortButton;
				}
				set
				{
					this.m_owner.m_heroListSortButton = value;
				}
			}

			// Token: 0x17002B4D RID: 11085
			// (get) Token: 0x0600DF0B RID: 57099 RVA: 0x003C47A8 File Offset: 0x003C29A8
			// (set) Token: 0x0600DF0C RID: 57100 RVA: 0x003C47B8 File Offset: 0x003C29B8
			public Text m_heroListSortButtonTypeText
			{
				get
				{
					return this.m_owner.m_heroListSortButtonTypeText;
				}
				set
				{
					this.m_owner.m_heroListSortButtonTypeText = value;
				}
			}

			// Token: 0x17002B4E RID: 11086
			// (get) Token: 0x0600DF0D RID: 57101 RVA: 0x003C47C8 File Offset: 0x003C29C8
			// (set) Token: 0x0600DF0E RID: 57102 RVA: 0x003C47D8 File Offset: 0x003C29D8
			public CommonUIStateController m_heroListSortTypesStateCtrl
			{
				get
				{
					return this.m_owner.m_heroListSortTypesStateCtrl;
				}
				set
				{
					this.m_owner.m_heroListSortTypesStateCtrl = value;
				}
			}

			// Token: 0x17002B4F RID: 11087
			// (get) Token: 0x0600DF0F RID: 57103 RVA: 0x003C47E8 File Offset: 0x003C29E8
			// (set) Token: 0x0600DF10 RID: 57104 RVA: 0x003C47F8 File Offset: 0x003C29F8
			public Toggle m_heroListSortTypesLevelToggle
			{
				get
				{
					return this.m_owner.m_heroListSortTypesLevelToggle;
				}
				set
				{
					this.m_owner.m_heroListSortTypesLevelToggle = value;
				}
			}

			// Token: 0x17002B50 RID: 11088
			// (get) Token: 0x0600DF11 RID: 57105 RVA: 0x003C4808 File Offset: 0x003C2A08
			// (set) Token: 0x0600DF12 RID: 57106 RVA: 0x003C4818 File Offset: 0x003C2A18
			public Toggle m_heroListSortTypesStarLvToggle
			{
				get
				{
					return this.m_owner.m_heroListSortTypesStarLvToggle;
				}
				set
				{
					this.m_owner.m_heroListSortTypesStarLvToggle = value;
				}
			}

			// Token: 0x17002B51 RID: 11089
			// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x003C4828 File Offset: 0x003C2A28
			// (set) Token: 0x0600DF14 RID: 57108 RVA: 0x003C4838 File Offset: 0x003C2A38
			public Toggle m_heroListSortTypesAchievementToggle
			{
				get
				{
					return this.m_owner.m_heroListSortTypesAchievementToggle;
				}
				set
				{
					this.m_owner.m_heroListSortTypesAchievementToggle = value;
				}
			}

			// Token: 0x17002B52 RID: 11090
			// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x003C4848 File Offset: 0x003C2A48
			// (set) Token: 0x0600DF16 RID: 57110 RVA: 0x003C4858 File Offset: 0x003C2A58
			public Image m_detailDifficultyLevelBGImage
			{
				get
				{
					return this.m_owner.m_detailDifficultyLevelBGImage;
				}
				set
				{
					this.m_owner.m_detailDifficultyLevelBGImage = value;
				}
			}

			// Token: 0x17002B53 RID: 11091
			// (get) Token: 0x0600DF17 RID: 57111 RVA: 0x003C4868 File Offset: 0x003C2A68
			// (set) Token: 0x0600DF18 RID: 57112 RVA: 0x003C4878 File Offset: 0x003C2A78
			public Text m_teamNumberText
			{
				get
				{
					return this.m_owner.m_teamNumberText;
				}
				set
				{
					this.m_owner.m_teamNumberText = value;
				}
			}

			// Token: 0x17002B54 RID: 11092
			// (get) Token: 0x0600DF19 RID: 57113 RVA: 0x003C4888 File Offset: 0x003C2A88
			// (set) Token: 0x0600DF1A RID: 57114 RVA: 0x003C4898 File Offset: 0x003C2A98
			public ScrollRect m_detailDifficultyGroupScrollRect
			{
				get
				{
					return this.m_owner.m_detailDifficultyGroupScrollRect;
				}
				set
				{
					this.m_owner.m_detailDifficultyGroupScrollRect = value;
				}
			}

			// Token: 0x17002B55 RID: 11093
			// (get) Token: 0x0600DF1B RID: 57115 RVA: 0x003C48A8 File Offset: 0x003C2AA8
			// (set) Token: 0x0600DF1C RID: 57116 RVA: 0x003C48B8 File Offset: 0x003C2AB8
			public GameObject m_detailDifficultyGroupContent
			{
				get
				{
					return this.m_owner.m_detailDifficultyGroupContent;
				}
				set
				{
					this.m_owner.m_detailDifficultyGroupContent = value;
				}
			}

			// Token: 0x17002B56 RID: 11094
			// (get) Token: 0x0600DF1D RID: 57117 RVA: 0x003C48C8 File Offset: 0x003C2AC8
			// (set) Token: 0x0600DF1E RID: 57118 RVA: 0x003C48D8 File Offset: 0x003C2AD8
			public GameObject m_detailRewardGroup
			{
				get
				{
					return this.m_owner.m_detailRewardGroup;
				}
				set
				{
					this.m_owner.m_detailRewardGroup = value;
				}
			}

			// Token: 0x17002B57 RID: 11095
			// (get) Token: 0x0600DF1F RID: 57119 RVA: 0x003C48E8 File Offset: 0x003C2AE8
			// (set) Token: 0x0600DF20 RID: 57120 RVA: 0x003C48F8 File Offset: 0x003C2AF8
			public Toggle m_detailTeachingTimeToggle1
			{
				get
				{
					return this.m_owner.m_detailTeachingTimeToggle1;
				}
				set
				{
					this.m_owner.m_detailTeachingTimeToggle1 = value;
				}
			}

			// Token: 0x17002B58 RID: 11096
			// (get) Token: 0x0600DF21 RID: 57121 RVA: 0x003C4908 File Offset: 0x003C2B08
			// (set) Token: 0x0600DF22 RID: 57122 RVA: 0x003C4918 File Offset: 0x003C2B18
			public Toggle m_detailTeachingTimeToggle2
			{
				get
				{
					return this.m_owner.m_detailTeachingTimeToggle2;
				}
				set
				{
					this.m_owner.m_detailTeachingTimeToggle2 = value;
				}
			}

			// Token: 0x17002B59 RID: 11097
			// (get) Token: 0x0600DF23 RID: 57123 RVA: 0x003C4928 File Offset: 0x003C2B28
			// (set) Token: 0x0600DF24 RID: 57124 RVA: 0x003C4938 File Offset: 0x003C2B38
			public Toggle m_detailTeachingTimeToggle3
			{
				get
				{
					return this.m_owner.m_detailTeachingTimeToggle3;
				}
				set
				{
					this.m_owner.m_detailTeachingTimeToggle3 = value;
				}
			}

			// Token: 0x17002B5A RID: 11098
			// (get) Token: 0x0600DF25 RID: 57125 RVA: 0x003C4948 File Offset: 0x003C2B48
			// (set) Token: 0x0600DF26 RID: 57126 RVA: 0x003C4958 File Offset: 0x003C2B58
			public Button m_detailConfirmButton
			{
				get
				{
					return this.m_owner.m_detailConfirmButton;
				}
				set
				{
					this.m_owner.m_detailConfirmButton = value;
				}
			}

			// Token: 0x17002B5B RID: 11099
			// (get) Token: 0x0600DF27 RID: 57127 RVA: 0x003C4968 File Offset: 0x003C2B68
			// (set) Token: 0x0600DF28 RID: 57128 RVA: 0x003C4978 File Offset: 0x003C2B78
			public CommonUIStateController m_detailConfirmButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_detailConfirmButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_detailConfirmButtonStateCtrl = value;
				}
			}

			// Token: 0x17002B5C RID: 11100
			// (get) Token: 0x0600DF29 RID: 57129 RVA: 0x003C4988 File Offset: 0x003C2B88
			// (set) Token: 0x0600DF2A RID: 57130 RVA: 0x003C4998 File Offset: 0x003C2B98
			public CommonUIStateController m_teachStartPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_teachStartPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_teachStartPanelStateCtrl = value;
				}
			}

			// Token: 0x17002B5D RID: 11101
			// (get) Token: 0x0600DF2B RID: 57131 RVA: 0x003C49A8 File Offset: 0x003C2BA8
			// (set) Token: 0x0600DF2C RID: 57132 RVA: 0x003C49B8 File Offset: 0x003C2BB8
			public GameObject m_heroItemprefab
			{
				get
				{
					return this.m_owner.m_heroItemprefab;
				}
				set
				{
					this.m_owner.m_heroItemprefab = value;
				}
			}

			// Token: 0x17002B5E RID: 11102
			// (get) Token: 0x0600DF2D RID: 57133 RVA: 0x003C49C8 File Offset: 0x003C2BC8
			// (set) Token: 0x0600DF2E RID: 57134 RVA: 0x003C49D8 File Offset: 0x003C2BD8
			public DrillTutorUIController.HeroSortType m_curHeroSortType
			{
				get
				{
					return this.m_owner.m_curHeroSortType;
				}
				set
				{
					this.m_owner.m_curHeroSortType = value;
				}
			}

			// Token: 0x17002B5F RID: 11103
			// (get) Token: 0x0600DF2F RID: 57135 RVA: 0x003C49E8 File Offset: 0x003C2BE8
			// (set) Token: 0x0600DF30 RID: 57136 RVA: 0x003C49F8 File Offset: 0x003C2BF8
			public List<int> m_curChooseHeroIds
			{
				get
				{
					return this.m_owner.m_curChooseHeroIds;
				}
				set
				{
					this.m_owner.m_curChooseHeroIds = value;
				}
			}

			// Token: 0x17002B60 RID: 11104
			// (get) Token: 0x0600DF31 RID: 57137 RVA: 0x003C4A08 File Offset: 0x003C2C08
			// (set) Token: 0x0600DF32 RID: 57138 RVA: 0x003C4A18 File Offset: 0x003C2C18
			public List<int> m_tempChooseHeroIds
			{
				get
				{
					return this.m_owner.m_tempChooseHeroIds;
				}
				set
				{
					this.m_owner.m_tempChooseHeroIds = value;
				}
			}

			// Token: 0x17002B61 RID: 11105
			// (get) Token: 0x0600DF33 RID: 57139 RVA: 0x003C4A28 File Offset: 0x003C2C28
			// (set) Token: 0x0600DF34 RID: 57140 RVA: 0x003C4A38 File Offset: 0x003C2C38
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

			// Token: 0x17002B62 RID: 11106
			// (get) Token: 0x0600DF35 RID: 57141 RVA: 0x003C4A48 File Offset: 0x003C2C48
			// (set) Token: 0x0600DF36 RID: 57142 RVA: 0x003C4A58 File Offset: 0x003C2C58
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

			// Token: 0x17002B63 RID: 11107
			// (get) Token: 0x0600DF37 RID: 57143 RVA: 0x003C4A68 File Offset: 0x003C2C68
			// (set) Token: 0x0600DF38 RID: 57144 RVA: 0x003C4A78 File Offset: 0x003C2C78
			public HeroAssistantsTask m_curHeroAssistantsTask
			{
				get
				{
					return this.m_owner.m_curHeroAssistantsTask;
				}
				set
				{
					this.m_owner.m_curHeroAssistantsTask = value;
				}
			}

			// Token: 0x17002B64 RID: 11108
			// (get) Token: 0x0600DF39 RID: 57145 RVA: 0x003C4A88 File Offset: 0x003C2C88
			// (set) Token: 0x0600DF3A RID: 57146 RVA: 0x003C4A98 File Offset: 0x003C2C98
			public int m_curDifficultLevel
			{
				get
				{
					return this.m_owner.m_curDifficultLevel;
				}
				set
				{
					this.m_owner.m_curDifficultLevel = value;
				}
			}

			// Token: 0x17002B65 RID: 11109
			// (get) Token: 0x0600DF3B RID: 57147 RVA: 0x003C4AA8 File Offset: 0x003C2CA8
			// (set) Token: 0x0600DF3C RID: 57148 RVA: 0x003C4AB8 File Offset: 0x003C2CB8
			public int m_curWorkSeconds
			{
				get
				{
					return this.m_owner.m_curWorkSeconds;
				}
				set
				{
					this.m_owner.m_curWorkSeconds = value;
				}
			}

			// Token: 0x17002B66 RID: 11110
			// (get) Token: 0x0600DF3D RID: 57149 RVA: 0x003C4AC8 File Offset: 0x003C2CC8
			// (set) Token: 0x0600DF3E RID: 57150 RVA: 0x003C4AD8 File Offset: 0x003C2CD8
			public List<HeroAssistantsTask> m_allTaskList
			{
				get
				{
					return this.m_owner.m_allTaskList;
				}
				set
				{
					this.m_owner.m_allTaskList = value;
				}
			}

			// Token: 0x17002B67 RID: 11111
			// (get) Token: 0x0600DF3F RID: 57151 RVA: 0x003C4AE8 File Offset: 0x003C2CE8
			// (set) Token: 0x0600DF40 RID: 57152 RVA: 0x003C4AF8 File Offset: 0x003C2CF8
			public int m_slot
			{
				get
				{
					return this.m_owner.m_slot;
				}
				set
				{
					this.m_owner.m_slot = value;
				}
			}

			// Token: 0x17002B68 RID: 11112
			// (get) Token: 0x0600DF41 RID: 57153 RVA: 0x003C4B08 File Offset: 0x003C2D08
			// (set) Token: 0x0600DF42 RID: 57154 RVA: 0x003C4B18 File Offset: 0x003C2D18
			public bool m_isFirstIn
			{
				get
				{
					return this.m_owner.m_isFirstIn;
				}
				set
				{
					this.m_owner.m_isFirstIn = value;
				}
			}

			// Token: 0x0600DF43 RID: 57155 RVA: 0x003C4B28 File Offset: 0x003C2D28
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DF44 RID: 57156 RVA: 0x003C4B38 File Offset: 0x003C2D38
			public void SetDifficultScrollViewPosition()
			{
				this.m_owner.SetDifficultScrollViewPosition();
			}

			// Token: 0x0600DF45 RID: 57157 RVA: 0x003C4B48 File Offset: 0x003C2D48
			public void SetConfirmButtonState()
			{
				this.m_owner.SetConfirmButtonState();
			}

			// Token: 0x0600DF46 RID: 57158 RVA: 0x003C4B58 File Offset: 0x003C2D58
			public void SetDifficultBgBySlot()
			{
				this.m_owner.SetDifficultBgBySlot();
			}

			// Token: 0x0600DF47 RID: 57159 RVA: 0x003C4B68 File Offset: 0x003C2D68
			public void SetDifficultInfo()
			{
				this.m_owner.SetDifficultInfo();
			}

			// Token: 0x0600DF48 RID: 57160 RVA: 0x003C4B78 File Offset: 0x003C2D78
			public void OnDifficultItemClick(TrainingDifficultItemUIController ctrl)
			{
				this.m_owner.OnDifficultItemClick(ctrl);
			}

			// Token: 0x0600DF49 RID: 57161 RVA: 0x003C4B88 File Offset: 0x003C2D88
			public void SetWorkHour()
			{
				this.m_owner.SetWorkHour();
			}

			// Token: 0x0600DF4A RID: 57162 RVA: 0x003C4B98 File Offset: 0x003C2D98
			public void SetRecommendHeroGroup(GameObject parentGameObject)
			{
				this.m_owner.SetRecommendHeroGroup(parentGameObject);
			}

			// Token: 0x0600DF4B RID: 57163 RVA: 0x003C4BA8 File Offset: 0x003C2DA8
			public void SetCurChooseHeros()
			{
				this.m_owner.SetCurChooseHeros();
			}

			// Token: 0x0600DF4C RID: 57164 RVA: 0x003C4BB8 File Offset: 0x003C2DB8
			public void SetRewardGroupList()
			{
				this.m_owner.SetRewardGroupList();
			}

			// Token: 0x0600DF4D RID: 57165 RVA: 0x003C4BC8 File Offset: 0x003C2DC8
			public List<Goods> GetRewardsList()
			{
				return this.m_owner.GetRewardsList();
			}

			// Token: 0x0600DF4E RID: 57166 RVA: 0x003C4BD8 File Offset: 0x003C2DD8
			public void SetChooseHeroListPanel()
			{
				this.m_owner.SetChooseHeroListPanel();
			}

			// Token: 0x0600DF4F RID: 57167 RVA: 0x003C4BE8 File Offset: 0x003C2DE8
			public int HeroListItemComparator(Hero h1, Hero h2)
			{
				return this.m_owner.HeroListItemComparator(h1, h2);
			}

			// Token: 0x0600DF50 RID: 57168 RVA: 0x003C4BF8 File Offset: 0x003C2DF8
			public void OnTrainingHeroItemClick(TrainingHeroItemUIController ctrl)
			{
				this.m_owner.OnTrainingHeroItemClick(ctrl);
			}

			// Token: 0x0600DF51 RID: 57169 RVA: 0x003C4C08 File Offset: 0x003C2E08
			public void SetHeroListResultDetailPanel()
			{
				this.m_owner.SetHeroListResultDetailPanel();
			}

			// Token: 0x0600DF52 RID: 57170 RVA: 0x003C4C18 File Offset: 0x003C2E18
			public int CalcHeroTotalAchievementvalue(List<int> heroIds)
			{
				return this.m_owner.CalcHeroTotalAchievementvalue(heroIds);
			}

			// Token: 0x0600DF53 RID: 57171 RVA: 0x003C4C28 File Offset: 0x003C2E28
			public void OnChooseHeroButtonClick()
			{
				this.m_owner.OnChooseHeroButtonClick();
			}

			// Token: 0x0600DF54 RID: 57172 RVA: 0x003C4C38 File Offset: 0x003C2E38
			public void OnHeroListConfirmButtonClick()
			{
				this.m_owner.OnHeroListConfirmButtonClick();
			}

			// Token: 0x0600DF55 RID: 57173 RVA: 0x003C4C48 File Offset: 0x003C2E48
			public void OnHeroListPanelBGBackButtonClick()
			{
				this.m_owner.OnHeroListPanelBGBackButtonClick();
			}

			// Token: 0x0600DF56 RID: 57174 RVA: 0x003C4C58 File Offset: 0x003C2E58
			public void OnDetailConfirmButtonClick()
			{
				this.m_owner.OnDetailConfirmButtonClick();
			}

			// Token: 0x0600DF57 RID: 57175 RVA: 0x003C4C68 File Offset: 0x003C2E68
			public void OnLevelToggleChanged(bool isOn)
			{
				this.m_owner.OnLevelToggleChanged(isOn);
			}

			// Token: 0x0600DF58 RID: 57176 RVA: 0x003C4C78 File Offset: 0x003C2E78
			public void OnStarLvToggleChanged(bool isOn)
			{
				this.m_owner.OnStarLvToggleChanged(isOn);
			}

			// Token: 0x0600DF59 RID: 57177 RVA: 0x003C4C88 File Offset: 0x003C2E88
			public void OnAchievementToggleChanged(bool isOn)
			{
				this.m_owner.OnAchievementToggleChanged(isOn);
			}

			// Token: 0x0600DF5A RID: 57178 RVA: 0x003C4C98 File Offset: 0x003C2E98
			public void OnHeroSortButtonClick()
			{
				this.m_owner.OnHeroSortButtonClick();
			}

			// Token: 0x0600DF5B RID: 57179 RVA: 0x003C4CA8 File Offset: 0x003C2EA8
			public void CloseSortTypesPanel()
			{
				this.m_owner.CloseSortTypesPanel();
			}

			// Token: 0x0600DF5C RID: 57180 RVA: 0x003C4CB8 File Offset: 0x003C2EB8
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600DF5D RID: 57181 RVA: 0x003C4CC8 File Offset: 0x003C2EC8
			public void ResetData()
			{
				this.m_owner.ResetData();
			}

			// Token: 0x040087FB RID: 34811
			private DrillTutorUIController m_owner;
		}
	}
}
