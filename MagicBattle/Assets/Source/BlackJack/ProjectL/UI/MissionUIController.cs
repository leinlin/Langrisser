using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E78 RID: 3704
	[HotFix]
	public class MissionUIController : UIControllerBase
	{
		// Token: 0x06011FDC RID: 73692 RVA: 0x004A4924 File Offset: 0x004A2B24
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
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_tipsCancelButton.onClick.AddListener(new UnityAction(this.OnTipsBackgroundButtonClick));
			this.m_tipsCancelButton.onClick.AddListener(new UnityAction(this.OnTipsBackgroundButtonClick));
			this.m_tipsConfirmButton.onClick.AddListener(new UnityAction(this.OnTipsConfirmButtonClick));
			this.m_dayMissionToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnDayMissionToggleValueChanged));
			this.m_challengeMissionToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnChallengeToggleValueChanged));
			this.m_achievementToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnAchievementToggleValueChanged));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06011FDD RID: 73693 RVA: 0x004A4A90 File Offset: 0x004A2C90
		public void ShowMissionListByMissionColumnType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMissionListByMissionColumnType_hotfix != null)
			{
				this.m_ShowMissionListByMissionColumnType_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_missionListContentObj, 0);
			this.ResetRedTagNum();
			this.ResetScrollViewToTop();
			Transform transform = this.m_missionListContentObj.transform;
			List<Mission> list = new List<Mission>();
			List<Mission> list2 = new List<Mission>();
			foreach (Mission mission in this.m_playerContext.GetAllCompletedMissionList())
			{
				if (mission != null && mission.Config != null)
				{
					this.AddMissionColumnRedTagNum(mission);
					if (mission.Config.MissionColumn == this.m_curMissionColumnType)
					{
						list2.Add(mission);
					}
				}
			}
			list2.Sort(new Comparison<Mission>(this.CompareMissionBySortId));
			list.AddRange(list2);
			int count = list.Count;
			list2.Clear();
			foreach (Mission mission2 in this.m_playerContext.GetAllProcessingMissionList())
			{
				if (mission2 != null && mission2.Config != null && mission2.Config.MissionColumn == this.m_curMissionColumnType)
				{
					list2.Add(mission2);
				}
			}
			list2.Sort(new Comparison<Mission>(this.CompareMissionBySortId));
			list.AddRange(list2);
			int count2 = list.Count;
			list2.Clear();
			foreach (Mission mission3 in this.m_playerContext.GetAllFinishedMissionList())
			{
				if (mission3 != null && mission3.Config != null && mission3.Config.MissionColumn == this.m_curMissionColumnType)
				{
					list2.Add(mission3);
				}
			}
			list2.Sort(new Comparison<Mission>(this.CompareMissionBySortId));
			list.AddRange(list2);
			for (int i = 0; i < list.Count; i++)
			{
				Mission mission4 = list[i];
				bool isMissionFinished = i >= count2;
				bool isMissionCompleted = i < count || i >= count2;
				GameObject childGo = null;
				if (i < transform.childCount)
				{
					childGo = transform.GetChild(i).gameObject;
				}
				this.CreateMissionItem(mission4, isMissionFinished, isMissionCompleted, childGo);
			}
			Text dayMissionToggleClickTagNum = this.m_dayMissionToggleClickTagNum;
			string text = (this.m_dayCompleteNum >= 99) ? "99+" : this.m_dayCompleteNum.ToString();
			this.m_dayMissionToggleUnClickTagNum.text = text;
			dayMissionToggleClickTagNum.text = text;
			Text challengeMissionToggleClickTagNum = this.m_challengeMissionToggleClickTagNum;
			text = ((this.m_challengeCompleteNum >= 99) ? "99+" : this.m_challengeCompleteNum.ToString());
			this.m_challengeMissionToggleUnClickTagNum.text = text;
			challengeMissionToggleClickTagNum.text = text;
			Text achievementToggleClickTagNum = this.m_achievementToggleClickTagNum;
			text = ((this.m_achievementCompleteNum >= 99) ? "99+" : this.m_achievementCompleteNum.ToString());
			this.m_achievementToggleUnClickTagNum.text = text;
			achievementToggleClickTagNum.text = text;
			switch (this.m_curMissionColumnType)
			{
			case MissionColumnType.MissionColumnType_Everyday:
				this.ShowToggleTagNumText(true, false, false);
				break;
			case MissionColumnType.MissionColumnType_Challenge:
				this.ShowToggleTagNumText(false, true, false);
				break;
			case MissionColumnType.MissionColumnType_Achievements:
				this.ShowToggleTagNumText(false, false, true);
				break;
			}
		}

		// Token: 0x06011FDE RID: 73694 RVA: 0x004A4EA4 File Offset: 0x004A30A4
		private void ShowToggleTagNumText(bool day, bool challenge, bool achievement)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowToggleTagNumTextBooleanBooleanBoolean_hotfix != null)
			{
				this.m_ShowToggleTagNumTextBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					day,
					challenge,
					achievement
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dayMissionToggleClickTag.SetActive(day && this.m_dayCompleteNum != 0);
			this.m_dayMissionToggleUnClickTag.SetActive(!day && this.m_dayCompleteNum != 0);
			this.m_challengeMissionToggleClickTag.SetActive(challenge && this.m_challengeCompleteNum != 0);
			this.m_challengeMissionToggleUnClickTag.SetActive(!challenge && this.m_challengeCompleteNum != 0);
			this.m_achievementToggleClickTag.SetActive(achievement && this.m_achievementCompleteNum != 0);
			this.m_achievementToggleUnClickTag.SetActive(!achievement && this.m_achievementCompleteNum != 0);
		}

		// Token: 0x06011FDF RID: 73695 RVA: 0x004A4FF4 File Offset: 0x004A31F4
		private void CreateMissionItem(Mission mission, bool isMissionFinished, bool isMissionCompleted, GameObject childGo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateMissionItemMissionBooleanBooleanGameObject_hotfix != null)
			{
				this.m_CreateMissionItemMissionBooleanBooleanGameObject_hotfix.call(new object[]
				{
					this,
					mission,
					isMissionFinished,
					isMissionCompleted,
					childGo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MissionItemUIController component;
			if (childGo == null)
			{
				childGo = UnityEngine.Object.Instantiate<GameObject>(this.m_missionItemPrefab);
				PrefabControllerCreater.CreateAllControllers(childGo);
				component = childGo.GetComponent<MissionItemUIController>();
				component.EventOnGetButtonClick += this.OnGetRewardButtonClick;
				component.EventOnGotoButtonClick += this.OnGotoLayerButtonClick;
				childGo.transform.SetParent(this.m_missionListContentObj.transform, false);
			}
			else
			{
				component = childGo.GetComponent<MissionItemUIController>();
				if (component == null)
				{
					PrefabControllerCreater.CreateAllControllers(childGo);
					component = childGo.GetComponent<MissionItemUIController>();
				}
			}
			childGo.SetActive(true);
			component.InitMissionItem(mission, isMissionFinished, isMissionCompleted);
		}

		// Token: 0x06011FE0 RID: 73696 RVA: 0x004A5138 File Offset: 0x004A3338
		private int CompareMissionBySortId(Mission m1, Mission m2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CompareMissionBySortIdMissionMission_hotfix != null)
			{
				return Convert.ToInt32(this.m_CompareMissionBySortIdMissionMission_hotfix.call(new object[]
				{
					this,
					m1,
					m2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (m1.Config == null || m2.Config == null)
			{
				return 0;
			}
			if (m1.Config.SortID > m2.Config.SortID)
			{
				return 1;
			}
			if (m1.Config.SortID < m2.Config.SortID)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06011FE1 RID: 73697 RVA: 0x004A5218 File Offset: 0x004A3418
		private void AddMissionColumnRedTagNum(Mission mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMissionColumnRedTagNumMission_hotfix != null)
			{
				this.m_AddMissionColumnRedTagNumMission_hotfix.call(new object[]
				{
					this,
					mission
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (mission.Config.MissionColumn)
			{
			case MissionColumnType.MissionColumnType_Everyday:
				this.m_dayCompleteNum++;
				break;
			case MissionColumnType.MissionColumnType_Challenge:
				this.m_challengeCompleteNum++;
				break;
			case MissionColumnType.MissionColumnType_Achievements:
				this.m_achievementCompleteNum++;
				break;
			}
		}

		// Token: 0x06011FE2 RID: 73698 RVA: 0x004A52EC File Offset: 0x004A34EC
		private void ResetRedTagNum()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetRedTagNum_hotfix != null)
			{
				this.m_ResetRedTagNum_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_dayCompleteNum = 0;
			this.m_challengeCompleteNum = 0;
			this.m_achievementCompleteNum = 0;
		}

		// Token: 0x06011FE3 RID: 73699 RVA: 0x004A5364 File Offset: 0x004A3564
		private void OnGetRewardButtonClick(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetRewardButtonClickInt32_hotfix != null)
			{
				this.m_OnGetRewardButtonClickInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetRewardButtonClick != null)
			{
				this.m_oldPlayerLevel = this.m_playerContext.GetPlayerLevel();
				ConfigDataMissionInfo mission = this.m_configDataLoader.GetConfigDataMissionInfo(id);
				if (!this.m_playerContext.IsLevelTicketsMaxInMission(mission.Reward))
				{
					this.EventOnGetRewardButtonClick(id, delegate
					{
						this.ShowRewards(mission.Reward);
					});
				}
				else
				{
					this.m_missionID = id;
					this.m_rewardList = mission.Reward;
					UIUtility.SetUIStateOpen(this.m_tipsUIStateController, "Open", null, false, true);
				}
			}
		}

		// Token: 0x06011FE4 RID: 73700 RVA: 0x004A5474 File Offset: 0x004A3674
		private void ShowRewards(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardsList`1_hotfix != null)
			{
				this.m_ShowRewardsList`1_hotfix.call(new object[]
				{
					this,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetRewardGoodsUITask getRewardGoodsUITask = GetRewardGoodsUITask.StartUITask(rewards);
			if (this.m_getRewardGoodsUITask == null)
			{
				this.m_getRewardGoodsUITask = getRewardGoodsUITask;
				this.m_getRewardGoodsUITask.EventOnClose += this.GetRewardGoodsUITask_OnClose;
			}
		}

		// Token: 0x06011FE5 RID: 73701 RVA: 0x004A5514 File Offset: 0x004A3714
		private void GetRewardGoodsUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardGoodsUITask_OnClose_hotfix != null)
			{
				this.m_GetRewardGoodsUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_getRewardGoodsUITask == null)
			{
				return;
			}
			this.m_getRewardGoodsUITask.EventOnClose -= this.GetRewardGoodsUITask_OnClose;
			this.m_getRewardGoodsUITask = null;
			if (this.m_oldPlayerLevel != this.m_playerContext.GetPlayerLevel())
			{
				PlayerLevelUpUITask.StartUITask(this.m_oldPlayerLevel, this.m_playerContext.GetPlayerLevel());
			}
		}

		// Token: 0x06011FE6 RID: 73702 RVA: 0x004A55CC File Offset: 0x004A37CC
		private void OnGotoLayerButtonClick(GetPathData pathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGotoLayerButtonClickGetPathData_hotfix != null)
			{
				this.m_OnGotoLayerButtonClickGetPathData_hotfix.call(new object[]
				{
					this,
					pathInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoLayerButtonClick != null)
			{
				this.EventOnGotoLayerButtonClick(pathInfo);
			}
		}

		// Token: 0x06011FE7 RID: 73703 RVA: 0x004A5654 File Offset: 0x004A3854
		private void OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClick_hotfix != null)
			{
				this.m_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x06011FE8 RID: 73704 RVA: 0x004A56CC File Offset: 0x004A38CC
		private void OnTipsBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTipsBackgroundButtonClick_hotfix != null)
			{
				this.m_OnTipsBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_tipsUIStateController, "Close", null, false, true);
		}

		// Token: 0x06011FE9 RID: 73705 RVA: 0x004A5740 File Offset: 0x004A3940
		private void OnTipsConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTipsConfirmButtonClick_hotfix != null)
			{
				this.m_OnTipsConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetRewardButtonClick != null)
			{
				this.EventOnGetRewardButtonClick(this.m_missionID, delegate
				{
					this.ShowRewards(this.m_rewardList);
				});
			}
			UIUtility.SetUIStateClose(this.m_tipsUIStateController, "Close", null, false, true);
		}

		// Token: 0x06011FEA RID: 73706 RVA: 0x004A57DC File Offset: 0x004A39DC
		private void ResetScrollViewToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewToTop_hotfix != null)
			{
				this.m_ResetScrollViewToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_missionListScrollView.normalizedPosition = Vector2.one;
		}

		// Token: 0x06011FEB RID: 73707 RVA: 0x004A584C File Offset: 0x004A3A4C
		private void OnDayMissionToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDayMissionToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnDayMissionToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_curMissionColumnType == MissionColumnType.MissionColumnType_Everyday)
				{
					return;
				}
				this.m_curMissionColumnType = MissionColumnType.MissionColumnType_Everyday;
				this.ShowMissionListByMissionColumnType();
			}
		}

		// Token: 0x06011FEC RID: 73708 RVA: 0x004A58DC File Offset: 0x004A3ADC
		private void OnChallengeToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChallengeToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnChallengeToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_curMissionColumnType == MissionColumnType.MissionColumnType_Challenge)
				{
					return;
				}
				this.m_curMissionColumnType = MissionColumnType.MissionColumnType_Challenge;
				this.ShowMissionListByMissionColumnType();
			}
		}

		// Token: 0x06011FED RID: 73709 RVA: 0x004A596C File Offset: 0x004A3B6C
		private void OnAchievementToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnAchievementToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				if (this.m_curMissionColumnType == MissionColumnType.MissionColumnType_Achievements)
				{
					return;
				}
				this.m_curMissionColumnType = MissionColumnType.MissionColumnType_Achievements;
				this.ShowMissionListByMissionColumnType();
			}
		}

		// Token: 0x140003DE RID: 990
		// (add) Token: 0x06011FEE RID: 73710 RVA: 0x004A59FC File Offset: 0x004A3BFC
		// (remove) Token: 0x06011FEF RID: 73711 RVA: 0x004A5A98 File Offset: 0x004A3C98
		public event Action<int, Action> EventOnGetRewardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetRewardButtonClickAction`2_hotfix != null)
				{
					this.m_add_EventOnGetRewardButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnGetRewardButtonClick;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnGetRewardButtonClick, (Action<int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetRewardButtonClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnGetRewardButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnGetRewardButtonClick;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnGetRewardButtonClick, (Action<int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003DF RID: 991
		// (add) Token: 0x06011FF0 RID: 73712 RVA: 0x004A5B34 File Offset: 0x004A3D34
		// (remove) Token: 0x06011FF1 RID: 73713 RVA: 0x004A5BD0 File Offset: 0x004A3DD0
		public event Action<GetPathData> EventOnGotoLayerButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoLayerButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGotoLayerButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoLayerButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoLayerButtonClick, (Action<GetPathData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoLayerButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGotoLayerButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoLayerButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoLayerButtonClick, (Action<GetPathData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003E0 RID: 992
		// (add) Token: 0x06011FF2 RID: 73714 RVA: 0x004A5C6C File Offset: 0x004A3E6C
		// (remove) Token: 0x06011FF3 RID: 73715 RVA: 0x004A5D08 File Offset: 0x004A3F08
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

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x06011FF4 RID: 73716 RVA: 0x004A5DA4 File Offset: 0x004A3FA4
		// (set) Token: 0x06011FF5 RID: 73717 RVA: 0x004A5DC4 File Offset: 0x004A3FC4
		[DoNotToLua]
		public new MissionUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MissionUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011FF6 RID: 73718 RVA: 0x004A5DD0 File Offset: 0x004A3FD0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011FF7 RID: 73719 RVA: 0x004A5DDC File Offset: 0x004A3FDC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011FF8 RID: 73720 RVA: 0x004A5DE4 File Offset: 0x004A3FE4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011FF9 RID: 73721 RVA: 0x004A5DEC File Offset: 0x004A3FEC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011FFA RID: 73722 RVA: 0x004A5E00 File Offset: 0x004A4000
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011FFB RID: 73723 RVA: 0x004A5E08 File Offset: 0x004A4008
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011FFC RID: 73724 RVA: 0x004A5E14 File Offset: 0x004A4014
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011FFD RID: 73725 RVA: 0x004A5E20 File Offset: 0x004A4020
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011FFE RID: 73726 RVA: 0x004A5E2C File Offset: 0x004A402C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011FFF RID: 73727 RVA: 0x004A5E38 File Offset: 0x004A4038
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012000 RID: 73728 RVA: 0x004A5E44 File Offset: 0x004A4044
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012001 RID: 73729 RVA: 0x004A5E50 File Offset: 0x004A4050
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012002 RID: 73730 RVA: 0x004A5E5C File Offset: 0x004A405C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012003 RID: 73731 RVA: 0x004A5E68 File Offset: 0x004A4068
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012004 RID: 73732 RVA: 0x004A5E74 File Offset: 0x004A4074
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012005 RID: 73733 RVA: 0x004A5E7C File Offset: 0x004A407C
		private void __callDele_EventOnGetRewardButtonClick(int arg1, Action arg2)
		{
			Action<int, Action> eventOnGetRewardButtonClick = this.EventOnGetRewardButtonClick;
			if (eventOnGetRewardButtonClick != null)
			{
				eventOnGetRewardButtonClick(arg1, arg2);
			}
		}

		// Token: 0x06012006 RID: 73734 RVA: 0x004A5EA0 File Offset: 0x004A40A0
		private void __clearDele_EventOnGetRewardButtonClick(int arg1, Action arg2)
		{
			this.EventOnGetRewardButtonClick = null;
		}

		// Token: 0x06012007 RID: 73735 RVA: 0x004A5EAC File Offset: 0x004A40AC
		private void __callDele_EventOnGotoLayerButtonClick(GetPathData obj)
		{
			Action<GetPathData> eventOnGotoLayerButtonClick = this.EventOnGotoLayerButtonClick;
			if (eventOnGotoLayerButtonClick != null)
			{
				eventOnGotoLayerButtonClick(obj);
			}
		}

		// Token: 0x06012008 RID: 73736 RVA: 0x004A5ED0 File Offset: 0x004A40D0
		private void __clearDele_EventOnGotoLayerButtonClick(GetPathData obj)
		{
			this.EventOnGotoLayerButtonClick = null;
		}

		// Token: 0x06012009 RID: 73737 RVA: 0x004A5EDC File Offset: 0x004A40DC
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0601200A RID: 73738 RVA: 0x004A5EFC File Offset: 0x004A40FC
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0601200C RID: 73740 RVA: 0x004A5F18 File Offset: 0x004A4118
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
					this.m_ShowMissionListByMissionColumnType_hotfix = (luaObj.RawGet("ShowMissionListByMissionColumnType") as LuaFunction);
					this.m_ShowToggleTagNumTextBooleanBooleanBoolean_hotfix = (luaObj.RawGet("ShowToggleTagNumText") as LuaFunction);
					this.m_CreateMissionItemMissionBooleanBooleanGameObject_hotfix = (luaObj.RawGet("CreateMissionItem") as LuaFunction);
					this.m_CompareMissionBySortIdMissionMission_hotfix = (luaObj.RawGet("CompareMissionBySortId") as LuaFunction);
					this.m_AddMissionColumnRedTagNumMission_hotfix = (luaObj.RawGet("AddMissionColumnRedTagNum") as LuaFunction);
					this.m_ResetRedTagNum_hotfix = (luaObj.RawGet("ResetRedTagNum") as LuaFunction);
					this.m_OnGetRewardButtonClickInt32_hotfix = (luaObj.RawGet("OnGetRewardButtonClick") as LuaFunction);
					this.m_ShowRewardsList`1_hotfix = (luaObj.RawGet("ShowRewards") as LuaFunction);
					this.m_GetRewardGoodsUITask_OnClose_hotfix = (luaObj.RawGet("GetRewardGoodsUITask_OnClose") as LuaFunction);
					this.m_OnGotoLayerButtonClickGetPathData_hotfix = (luaObj.RawGet("OnGotoLayerButtonClick") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnTipsBackgroundButtonClick_hotfix = (luaObj.RawGet("OnTipsBackgroundButtonClick") as LuaFunction);
					this.m_OnTipsConfirmButtonClick_hotfix = (luaObj.RawGet("OnTipsConfirmButtonClick") as LuaFunction);
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_OnDayMissionToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnDayMissionToggleValueChanged") as LuaFunction);
					this.m_OnChallengeToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnChallengeToggleValueChanged") as LuaFunction);
					this.m_OnAchievementToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnAchievementToggleValueChanged") as LuaFunction);
					this.m_add_EventOnGetRewardButtonClickAction`2_hotfix = (luaObj.RawGet("add_EventOnGetRewardButtonClick") as LuaFunction);
					this.m_remove_EventOnGetRewardButtonClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnGetRewardButtonClick") as LuaFunction);
					this.m_add_EventOnGotoLayerButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoLayerButtonClick") as LuaFunction);
					this.m_remove_EventOnGotoLayerButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoLayerButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601200D RID: 73741 RVA: 0x004A6224 File Offset: 0x004A4424
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MissionUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A306 RID: 41734
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400A307 RID: 41735
		[AutoBind("./CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x0400A308 RID: 41736
		[AutoBind("./Margin/FilterToggles/DayMission", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_dayMissionToggle;

		// Token: 0x0400A309 RID: 41737
		[AutoBind("./Margin/FilterToggles/DayMission/Click/RedTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dayMissionToggleClickTag;

		// Token: 0x0400A30A RID: 41738
		[AutoBind("./Margin/FilterToggles/DayMission/Click/RedTag/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dayMissionToggleClickTagNum;

		// Token: 0x0400A30B RID: 41739
		[AutoBind("./Margin/FilterToggles/DayMission/UnClick/RedTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dayMissionToggleUnClickTag;

		// Token: 0x0400A30C RID: 41740
		[AutoBind("./Margin/FilterToggles/DayMission/UnClick/RedTag/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_dayMissionToggleUnClickTagNum;

		// Token: 0x0400A30D RID: 41741
		[AutoBind("./Margin/FilterToggles/ChallengeMission", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_challengeMissionToggle;

		// Token: 0x0400A30E RID: 41742
		[AutoBind("./Margin/FilterToggles/ChallengeMission/Click/RedTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_challengeMissionToggleClickTag;

		// Token: 0x0400A30F RID: 41743
		[AutoBind("./Margin/FilterToggles/ChallengeMission/Click/RedTag/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_challengeMissionToggleClickTagNum;

		// Token: 0x0400A310 RID: 41744
		[AutoBind("./Margin/FilterToggles/ChallengeMission/UnClick/RedTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_challengeMissionToggleUnClickTag;

		// Token: 0x0400A311 RID: 41745
		[AutoBind("./Margin/FilterToggles/ChallengeMission/UnClick/RedTag/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_challengeMissionToggleUnClickTagNum;

		// Token: 0x0400A312 RID: 41746
		[AutoBind("./Margin/FilterToggles/Achievement", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_achievementToggle;

		// Token: 0x0400A313 RID: 41747
		[AutoBind("./Margin/FilterToggles/Achievement/Click/RedTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_achievementToggleClickTag;

		// Token: 0x0400A314 RID: 41748
		[AutoBind("./Margin/FilterToggles/Achievement/Click/RedTag/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementToggleClickTagNum;

		// Token: 0x0400A315 RID: 41749
		[AutoBind("./Margin/FilterToggles/Achievement/UnClick/RedTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_achievementToggleUnClickTag;

		// Token: 0x0400A316 RID: 41750
		[AutoBind("./Margin/FilterToggles/Achievement/UnClick/RedTag/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementToggleUnClickTagNum;

		// Token: 0x0400A317 RID: 41751
		[AutoBind("./MissionList", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_missionListScrollView;

		// Token: 0x0400A318 RID: 41752
		[AutoBind("./MissionList/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_missionListContentObj;

		// Token: 0x0400A319 RID: 41753
		[AutoBind("./Tips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_tipsUIStateController;

		// Token: 0x0400A31A RID: 41754
		[AutoBind("./Tips/Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_tipsCancelButton;

		// Token: 0x0400A31B RID: 41755
		[AutoBind("./Tips/Panel/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_tipsConfirmButton;

		// Token: 0x0400A31C RID: 41756
		[AutoBind("./Prefab/MissionItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_missionItemPrefab;

		// Token: 0x0400A320 RID: 41760
		private int m_dayCompleteNum;

		// Token: 0x0400A321 RID: 41761
		private int m_challengeCompleteNum;

		// Token: 0x0400A322 RID: 41762
		private int m_achievementCompleteNum;

		// Token: 0x0400A323 RID: 41763
		private MissionColumnType m_curMissionColumnType = MissionColumnType.MissionColumnType_Everyday;

		// Token: 0x0400A324 RID: 41764
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400A325 RID: 41765
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400A326 RID: 41766
		private GetRewardGoodsUITask m_getRewardGoodsUITask;

		// Token: 0x0400A327 RID: 41767
		private int m_oldPlayerLevel;

		// Token: 0x0400A328 RID: 41768
		private int m_missionID;

		// Token: 0x0400A329 RID: 41769
		private List<Goods> m_rewardList;

		// Token: 0x0400A32A RID: 41770
		[DoNotToLua]
		private MissionUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A32B RID: 41771
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A32C RID: 41772
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A32D RID: 41773
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A32E RID: 41774
		private LuaFunction m_ShowMissionListByMissionColumnType_hotfix;

		// Token: 0x0400A32F RID: 41775
		private LuaFunction m_ShowToggleTagNumTextBooleanBooleanBoolean_hotfix;

		// Token: 0x0400A330 RID: 41776
		private LuaFunction m_CreateMissionItemMissionBooleanBooleanGameObject_hotfix;

		// Token: 0x0400A331 RID: 41777
		private LuaFunction m_CompareMissionBySortIdMissionMission_hotfix;

		// Token: 0x0400A332 RID: 41778
		private LuaFunction m_AddMissionColumnRedTagNumMission_hotfix;

		// Token: 0x0400A333 RID: 41779
		private LuaFunction m_ResetRedTagNum_hotfix;

		// Token: 0x0400A334 RID: 41780
		private LuaFunction m_OnGetRewardButtonClickInt32_hotfix;

		// Token: 0x0400A335 RID: 41781
		private LuaFunction m_ShowRewardsList;

		// Token: 0x0400A336 RID: 41782
		private LuaFunction m_GetRewardGoodsUITask_OnClose_hotfix;

		// Token: 0x0400A337 RID: 41783
		private LuaFunction m_OnGotoLayerButtonClickGetPathData_hotfix;

		// Token: 0x0400A338 RID: 41784
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x0400A339 RID: 41785
		private LuaFunction m_OnTipsBackgroundButtonClick_hotfix;

		// Token: 0x0400A33A RID: 41786
		private LuaFunction m_OnTipsConfirmButtonClick_hotfix;

		// Token: 0x0400A33B RID: 41787
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x0400A33C RID: 41788
		private LuaFunction m_OnDayMissionToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A33D RID: 41789
		private LuaFunction m_OnChallengeToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A33E RID: 41790
		private LuaFunction m_OnAchievementToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A33F RID: 41791
		private LuaFunction m_add_EventOnGetRewardButtonClickAction;

		// Token: 0x0400A340 RID: 41792
		private LuaFunction m_remove_EventOnGetRewardButtonClickAction;

		// Token: 0x0400A341 RID: 41793
		private LuaFunction m_add_EventOnGotoLayerButtonClickAction;

		// Token: 0x0400A342 RID: 41794
		private LuaFunction m_remove_EventOnGotoLayerButtonClickAction;

		// Token: 0x0400A343 RID: 41795
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A344 RID: 41796
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000E79 RID: 3705
		public new class LuaExportHelper
		{
			// Token: 0x0601200E RID: 73742 RVA: 0x004A628C File Offset: 0x004A448C
			public LuaExportHelper(MissionUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601200F RID: 73743 RVA: 0x004A629C File Offset: 0x004A449C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012010 RID: 73744 RVA: 0x004A62AC File Offset: 0x004A44AC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012011 RID: 73745 RVA: 0x004A62BC File Offset: 0x004A44BC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012012 RID: 73746 RVA: 0x004A62CC File Offset: 0x004A44CC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012013 RID: 73747 RVA: 0x004A62E4 File Offset: 0x004A44E4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012014 RID: 73748 RVA: 0x004A62F4 File Offset: 0x004A44F4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012015 RID: 73749 RVA: 0x004A6304 File Offset: 0x004A4504
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012016 RID: 73750 RVA: 0x004A6314 File Offset: 0x004A4514
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012017 RID: 73751 RVA: 0x004A6324 File Offset: 0x004A4524
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012018 RID: 73752 RVA: 0x004A6334 File Offset: 0x004A4534
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012019 RID: 73753 RVA: 0x004A6344 File Offset: 0x004A4544
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601201A RID: 73754 RVA: 0x004A6354 File Offset: 0x004A4554
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601201B RID: 73755 RVA: 0x004A6364 File Offset: 0x004A4564
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601201C RID: 73756 RVA: 0x004A6374 File Offset: 0x004A4574
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601201D RID: 73757 RVA: 0x004A6384 File Offset: 0x004A4584
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601201E RID: 73758 RVA: 0x004A6394 File Offset: 0x004A4594
			public void __callDele_EventOnGetRewardButtonClick(int arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnGetRewardButtonClick(arg1, arg2);
			}

			// Token: 0x0601201F RID: 73759 RVA: 0x004A63A4 File Offset: 0x004A45A4
			public void __clearDele_EventOnGetRewardButtonClick(int arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnGetRewardButtonClick(arg1, arg2);
			}

			// Token: 0x06012020 RID: 73760 RVA: 0x004A63B4 File Offset: 0x004A45B4
			public void __callDele_EventOnGotoLayerButtonClick(GetPathData obj)
			{
				this.m_owner.__callDele_EventOnGotoLayerButtonClick(obj);
			}

			// Token: 0x06012021 RID: 73761 RVA: 0x004A63C4 File Offset: 0x004A45C4
			public void __clearDele_EventOnGotoLayerButtonClick(GetPathData obj)
			{
				this.m_owner.__clearDele_EventOnGotoLayerButtonClick(obj);
			}

			// Token: 0x06012022 RID: 73762 RVA: 0x004A63D4 File Offset: 0x004A45D4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06012023 RID: 73763 RVA: 0x004A63E4 File Offset: 0x004A45E4
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170036F0 RID: 14064
			// (get) Token: 0x06012024 RID: 73764 RVA: 0x004A63F4 File Offset: 0x004A45F4
			// (set) Token: 0x06012025 RID: 73765 RVA: 0x004A6404 File Offset: 0x004A4604
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

			// Token: 0x170036F1 RID: 14065
			// (get) Token: 0x06012026 RID: 73766 RVA: 0x004A6414 File Offset: 0x004A4614
			// (set) Token: 0x06012027 RID: 73767 RVA: 0x004A6424 File Offset: 0x004A4624
			public Button m_closeButton
			{
				get
				{
					return this.m_owner.m_closeButton;
				}
				set
				{
					this.m_owner.m_closeButton = value;
				}
			}

			// Token: 0x170036F2 RID: 14066
			// (get) Token: 0x06012028 RID: 73768 RVA: 0x004A6434 File Offset: 0x004A4634
			// (set) Token: 0x06012029 RID: 73769 RVA: 0x004A6444 File Offset: 0x004A4644
			public Toggle m_dayMissionToggle
			{
				get
				{
					return this.m_owner.m_dayMissionToggle;
				}
				set
				{
					this.m_owner.m_dayMissionToggle = value;
				}
			}

			// Token: 0x170036F3 RID: 14067
			// (get) Token: 0x0601202A RID: 73770 RVA: 0x004A6454 File Offset: 0x004A4654
			// (set) Token: 0x0601202B RID: 73771 RVA: 0x004A6464 File Offset: 0x004A4664
			public GameObject m_dayMissionToggleClickTag
			{
				get
				{
					return this.m_owner.m_dayMissionToggleClickTag;
				}
				set
				{
					this.m_owner.m_dayMissionToggleClickTag = value;
				}
			}

			// Token: 0x170036F4 RID: 14068
			// (get) Token: 0x0601202C RID: 73772 RVA: 0x004A6474 File Offset: 0x004A4674
			// (set) Token: 0x0601202D RID: 73773 RVA: 0x004A6484 File Offset: 0x004A4684
			public Text m_dayMissionToggleClickTagNum
			{
				get
				{
					return this.m_owner.m_dayMissionToggleClickTagNum;
				}
				set
				{
					this.m_owner.m_dayMissionToggleClickTagNum = value;
				}
			}

			// Token: 0x170036F5 RID: 14069
			// (get) Token: 0x0601202E RID: 73774 RVA: 0x004A6494 File Offset: 0x004A4694
			// (set) Token: 0x0601202F RID: 73775 RVA: 0x004A64A4 File Offset: 0x004A46A4
			public GameObject m_dayMissionToggleUnClickTag
			{
				get
				{
					return this.m_owner.m_dayMissionToggleUnClickTag;
				}
				set
				{
					this.m_owner.m_dayMissionToggleUnClickTag = value;
				}
			}

			// Token: 0x170036F6 RID: 14070
			// (get) Token: 0x06012030 RID: 73776 RVA: 0x004A64B4 File Offset: 0x004A46B4
			// (set) Token: 0x06012031 RID: 73777 RVA: 0x004A64C4 File Offset: 0x004A46C4
			public Text m_dayMissionToggleUnClickTagNum
			{
				get
				{
					return this.m_owner.m_dayMissionToggleUnClickTagNum;
				}
				set
				{
					this.m_owner.m_dayMissionToggleUnClickTagNum = value;
				}
			}

			// Token: 0x170036F7 RID: 14071
			// (get) Token: 0x06012032 RID: 73778 RVA: 0x004A64D4 File Offset: 0x004A46D4
			// (set) Token: 0x06012033 RID: 73779 RVA: 0x004A64E4 File Offset: 0x004A46E4
			public Toggle m_challengeMissionToggle
			{
				get
				{
					return this.m_owner.m_challengeMissionToggle;
				}
				set
				{
					this.m_owner.m_challengeMissionToggle = value;
				}
			}

			// Token: 0x170036F8 RID: 14072
			// (get) Token: 0x06012034 RID: 73780 RVA: 0x004A64F4 File Offset: 0x004A46F4
			// (set) Token: 0x06012035 RID: 73781 RVA: 0x004A6504 File Offset: 0x004A4704
			public GameObject m_challengeMissionToggleClickTag
			{
				get
				{
					return this.m_owner.m_challengeMissionToggleClickTag;
				}
				set
				{
					this.m_owner.m_challengeMissionToggleClickTag = value;
				}
			}

			// Token: 0x170036F9 RID: 14073
			// (get) Token: 0x06012036 RID: 73782 RVA: 0x004A6514 File Offset: 0x004A4714
			// (set) Token: 0x06012037 RID: 73783 RVA: 0x004A6524 File Offset: 0x004A4724
			public Text m_challengeMissionToggleClickTagNum
			{
				get
				{
					return this.m_owner.m_challengeMissionToggleClickTagNum;
				}
				set
				{
					this.m_owner.m_challengeMissionToggleClickTagNum = value;
				}
			}

			// Token: 0x170036FA RID: 14074
			// (get) Token: 0x06012038 RID: 73784 RVA: 0x004A6534 File Offset: 0x004A4734
			// (set) Token: 0x06012039 RID: 73785 RVA: 0x004A6544 File Offset: 0x004A4744
			public GameObject m_challengeMissionToggleUnClickTag
			{
				get
				{
					return this.m_owner.m_challengeMissionToggleUnClickTag;
				}
				set
				{
					this.m_owner.m_challengeMissionToggleUnClickTag = value;
				}
			}

			// Token: 0x170036FB RID: 14075
			// (get) Token: 0x0601203A RID: 73786 RVA: 0x004A6554 File Offset: 0x004A4754
			// (set) Token: 0x0601203B RID: 73787 RVA: 0x004A6564 File Offset: 0x004A4764
			public Text m_challengeMissionToggleUnClickTagNum
			{
				get
				{
					return this.m_owner.m_challengeMissionToggleUnClickTagNum;
				}
				set
				{
					this.m_owner.m_challengeMissionToggleUnClickTagNum = value;
				}
			}

			// Token: 0x170036FC RID: 14076
			// (get) Token: 0x0601203C RID: 73788 RVA: 0x004A6574 File Offset: 0x004A4774
			// (set) Token: 0x0601203D RID: 73789 RVA: 0x004A6584 File Offset: 0x004A4784
			public Toggle m_achievementToggle
			{
				get
				{
					return this.m_owner.m_achievementToggle;
				}
				set
				{
					this.m_owner.m_achievementToggle = value;
				}
			}

			// Token: 0x170036FD RID: 14077
			// (get) Token: 0x0601203E RID: 73790 RVA: 0x004A6594 File Offset: 0x004A4794
			// (set) Token: 0x0601203F RID: 73791 RVA: 0x004A65A4 File Offset: 0x004A47A4
			public GameObject m_achievementToggleClickTag
			{
				get
				{
					return this.m_owner.m_achievementToggleClickTag;
				}
				set
				{
					this.m_owner.m_achievementToggleClickTag = value;
				}
			}

			// Token: 0x170036FE RID: 14078
			// (get) Token: 0x06012040 RID: 73792 RVA: 0x004A65B4 File Offset: 0x004A47B4
			// (set) Token: 0x06012041 RID: 73793 RVA: 0x004A65C4 File Offset: 0x004A47C4
			public Text m_achievementToggleClickTagNum
			{
				get
				{
					return this.m_owner.m_achievementToggleClickTagNum;
				}
				set
				{
					this.m_owner.m_achievementToggleClickTagNum = value;
				}
			}

			// Token: 0x170036FF RID: 14079
			// (get) Token: 0x06012042 RID: 73794 RVA: 0x004A65D4 File Offset: 0x004A47D4
			// (set) Token: 0x06012043 RID: 73795 RVA: 0x004A65E4 File Offset: 0x004A47E4
			public GameObject m_achievementToggleUnClickTag
			{
				get
				{
					return this.m_owner.m_achievementToggleUnClickTag;
				}
				set
				{
					this.m_owner.m_achievementToggleUnClickTag = value;
				}
			}

			// Token: 0x17003700 RID: 14080
			// (get) Token: 0x06012044 RID: 73796 RVA: 0x004A65F4 File Offset: 0x004A47F4
			// (set) Token: 0x06012045 RID: 73797 RVA: 0x004A6604 File Offset: 0x004A4804
			public Text m_achievementToggleUnClickTagNum
			{
				get
				{
					return this.m_owner.m_achievementToggleUnClickTagNum;
				}
				set
				{
					this.m_owner.m_achievementToggleUnClickTagNum = value;
				}
			}

			// Token: 0x17003701 RID: 14081
			// (get) Token: 0x06012046 RID: 73798 RVA: 0x004A6614 File Offset: 0x004A4814
			// (set) Token: 0x06012047 RID: 73799 RVA: 0x004A6624 File Offset: 0x004A4824
			public ScrollRect m_missionListScrollView
			{
				get
				{
					return this.m_owner.m_missionListScrollView;
				}
				set
				{
					this.m_owner.m_missionListScrollView = value;
				}
			}

			// Token: 0x17003702 RID: 14082
			// (get) Token: 0x06012048 RID: 73800 RVA: 0x004A6634 File Offset: 0x004A4834
			// (set) Token: 0x06012049 RID: 73801 RVA: 0x004A6644 File Offset: 0x004A4844
			public GameObject m_missionListContentObj
			{
				get
				{
					return this.m_owner.m_missionListContentObj;
				}
				set
				{
					this.m_owner.m_missionListContentObj = value;
				}
			}

			// Token: 0x17003703 RID: 14083
			// (get) Token: 0x0601204A RID: 73802 RVA: 0x004A6654 File Offset: 0x004A4854
			// (set) Token: 0x0601204B RID: 73803 RVA: 0x004A6664 File Offset: 0x004A4864
			public CommonUIStateController m_tipsUIStateController
			{
				get
				{
					return this.m_owner.m_tipsUIStateController;
				}
				set
				{
					this.m_owner.m_tipsUIStateController = value;
				}
			}

			// Token: 0x17003704 RID: 14084
			// (get) Token: 0x0601204C RID: 73804 RVA: 0x004A6674 File Offset: 0x004A4874
			// (set) Token: 0x0601204D RID: 73805 RVA: 0x004A6684 File Offset: 0x004A4884
			public Button m_tipsCancelButton
			{
				get
				{
					return this.m_owner.m_tipsCancelButton;
				}
				set
				{
					this.m_owner.m_tipsCancelButton = value;
				}
			}

			// Token: 0x17003705 RID: 14085
			// (get) Token: 0x0601204E RID: 73806 RVA: 0x004A6694 File Offset: 0x004A4894
			// (set) Token: 0x0601204F RID: 73807 RVA: 0x004A66A4 File Offset: 0x004A48A4
			public Button m_tipsConfirmButton
			{
				get
				{
					return this.m_owner.m_tipsConfirmButton;
				}
				set
				{
					this.m_owner.m_tipsConfirmButton = value;
				}
			}

			// Token: 0x17003706 RID: 14086
			// (get) Token: 0x06012050 RID: 73808 RVA: 0x004A66B4 File Offset: 0x004A48B4
			// (set) Token: 0x06012051 RID: 73809 RVA: 0x004A66C4 File Offset: 0x004A48C4
			public GameObject m_missionItemPrefab
			{
				get
				{
					return this.m_owner.m_missionItemPrefab;
				}
				set
				{
					this.m_owner.m_missionItemPrefab = value;
				}
			}

			// Token: 0x17003707 RID: 14087
			// (get) Token: 0x06012052 RID: 73810 RVA: 0x004A66D4 File Offset: 0x004A48D4
			// (set) Token: 0x06012053 RID: 73811 RVA: 0x004A66E4 File Offset: 0x004A48E4
			public int m_dayCompleteNum
			{
				get
				{
					return this.m_owner.m_dayCompleteNum;
				}
				set
				{
					this.m_owner.m_dayCompleteNum = value;
				}
			}

			// Token: 0x17003708 RID: 14088
			// (get) Token: 0x06012054 RID: 73812 RVA: 0x004A66F4 File Offset: 0x004A48F4
			// (set) Token: 0x06012055 RID: 73813 RVA: 0x004A6704 File Offset: 0x004A4904
			public int m_challengeCompleteNum
			{
				get
				{
					return this.m_owner.m_challengeCompleteNum;
				}
				set
				{
					this.m_owner.m_challengeCompleteNum = value;
				}
			}

			// Token: 0x17003709 RID: 14089
			// (get) Token: 0x06012056 RID: 73814 RVA: 0x004A6714 File Offset: 0x004A4914
			// (set) Token: 0x06012057 RID: 73815 RVA: 0x004A6724 File Offset: 0x004A4924
			public int m_achievementCompleteNum
			{
				get
				{
					return this.m_owner.m_achievementCompleteNum;
				}
				set
				{
					this.m_owner.m_achievementCompleteNum = value;
				}
			}

			// Token: 0x1700370A RID: 14090
			// (get) Token: 0x06012058 RID: 73816 RVA: 0x004A6734 File Offset: 0x004A4934
			// (set) Token: 0x06012059 RID: 73817 RVA: 0x004A6744 File Offset: 0x004A4944
			public MissionColumnType m_curMissionColumnType
			{
				get
				{
					return this.m_owner.m_curMissionColumnType;
				}
				set
				{
					this.m_owner.m_curMissionColumnType = value;
				}
			}

			// Token: 0x1700370B RID: 14091
			// (get) Token: 0x0601205A RID: 73818 RVA: 0x004A6754 File Offset: 0x004A4954
			// (set) Token: 0x0601205B RID: 73819 RVA: 0x004A6764 File Offset: 0x004A4964
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

			// Token: 0x1700370C RID: 14092
			// (get) Token: 0x0601205C RID: 73820 RVA: 0x004A6774 File Offset: 0x004A4974
			// (set) Token: 0x0601205D RID: 73821 RVA: 0x004A6784 File Offset: 0x004A4984
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

			// Token: 0x1700370D RID: 14093
			// (get) Token: 0x0601205E RID: 73822 RVA: 0x004A6794 File Offset: 0x004A4994
			// (set) Token: 0x0601205F RID: 73823 RVA: 0x004A67A4 File Offset: 0x004A49A4
			public GetRewardGoodsUITask m_getRewardGoodsUITask
			{
				get
				{
					return this.m_owner.m_getRewardGoodsUITask;
				}
				set
				{
					this.m_owner.m_getRewardGoodsUITask = value;
				}
			}

			// Token: 0x1700370E RID: 14094
			// (get) Token: 0x06012060 RID: 73824 RVA: 0x004A67B4 File Offset: 0x004A49B4
			// (set) Token: 0x06012061 RID: 73825 RVA: 0x004A67C4 File Offset: 0x004A49C4
			public int m_oldPlayerLevel
			{
				get
				{
					return this.m_owner.m_oldPlayerLevel;
				}
				set
				{
					this.m_owner.m_oldPlayerLevel = value;
				}
			}

			// Token: 0x1700370F RID: 14095
			// (get) Token: 0x06012062 RID: 73826 RVA: 0x004A67D4 File Offset: 0x004A49D4
			// (set) Token: 0x06012063 RID: 73827 RVA: 0x004A67E4 File Offset: 0x004A49E4
			public int m_missionID
			{
				get
				{
					return this.m_owner.m_missionID;
				}
				set
				{
					this.m_owner.m_missionID = value;
				}
			}

			// Token: 0x17003710 RID: 14096
			// (get) Token: 0x06012064 RID: 73828 RVA: 0x004A67F4 File Offset: 0x004A49F4
			// (set) Token: 0x06012065 RID: 73829 RVA: 0x004A6804 File Offset: 0x004A4A04
			public List<Goods> m_rewardList
			{
				get
				{
					return this.m_owner.m_rewardList;
				}
				set
				{
					this.m_owner.m_rewardList = value;
				}
			}

			// Token: 0x06012066 RID: 73830 RVA: 0x004A6814 File Offset: 0x004A4A14
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012067 RID: 73831 RVA: 0x004A6824 File Offset: 0x004A4A24
			public void ShowToggleTagNumText(bool day, bool challenge, bool achievement)
			{
				this.m_owner.ShowToggleTagNumText(day, challenge, achievement);
			}

			// Token: 0x06012068 RID: 73832 RVA: 0x004A6834 File Offset: 0x004A4A34
			public void CreateMissionItem(Mission mission, bool isMissionFinished, bool isMissionCompleted, GameObject childGo)
			{
				this.m_owner.CreateMissionItem(mission, isMissionFinished, isMissionCompleted, childGo);
			}

			// Token: 0x06012069 RID: 73833 RVA: 0x004A6848 File Offset: 0x004A4A48
			public int CompareMissionBySortId(Mission m1, Mission m2)
			{
				return this.m_owner.CompareMissionBySortId(m1, m2);
			}

			// Token: 0x0601206A RID: 73834 RVA: 0x004A6858 File Offset: 0x004A4A58
			public void AddMissionColumnRedTagNum(Mission mission)
			{
				this.m_owner.AddMissionColumnRedTagNum(mission);
			}

			// Token: 0x0601206B RID: 73835 RVA: 0x004A6868 File Offset: 0x004A4A68
			public void ResetRedTagNum()
			{
				this.m_owner.ResetRedTagNum();
			}

			// Token: 0x0601206C RID: 73836 RVA: 0x004A6878 File Offset: 0x004A4A78
			public void OnGetRewardButtonClick(int id)
			{
				this.m_owner.OnGetRewardButtonClick(id);
			}

			// Token: 0x0601206D RID: 73837 RVA: 0x004A6888 File Offset: 0x004A4A88
			public void ShowRewards(List<Goods> rewards)
			{
				this.m_owner.ShowRewards(rewards);
			}

			// Token: 0x0601206E RID: 73838 RVA: 0x004A6898 File Offset: 0x004A4A98
			public void GetRewardGoodsUITask_OnClose()
			{
				this.m_owner.GetRewardGoodsUITask_OnClose();
			}

			// Token: 0x0601206F RID: 73839 RVA: 0x004A68A8 File Offset: 0x004A4AA8
			public void OnGotoLayerButtonClick(GetPathData pathInfo)
			{
				this.m_owner.OnGotoLayerButtonClick(pathInfo);
			}

			// Token: 0x06012070 RID: 73840 RVA: 0x004A68B8 File Offset: 0x004A4AB8
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x06012071 RID: 73841 RVA: 0x004A68C8 File Offset: 0x004A4AC8
			public void OnTipsBackgroundButtonClick()
			{
				this.m_owner.OnTipsBackgroundButtonClick();
			}

			// Token: 0x06012072 RID: 73842 RVA: 0x004A68D8 File Offset: 0x004A4AD8
			public void OnTipsConfirmButtonClick()
			{
				this.m_owner.OnTipsConfirmButtonClick();
			}

			// Token: 0x06012073 RID: 73843 RVA: 0x004A68E8 File Offset: 0x004A4AE8
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x06012074 RID: 73844 RVA: 0x004A68F8 File Offset: 0x004A4AF8
			public void OnDayMissionToggleValueChanged(bool on)
			{
				this.m_owner.OnDayMissionToggleValueChanged(on);
			}

			// Token: 0x06012075 RID: 73845 RVA: 0x004A6908 File Offset: 0x004A4B08
			public void OnChallengeToggleValueChanged(bool on)
			{
				this.m_owner.OnChallengeToggleValueChanged(on);
			}

			// Token: 0x06012076 RID: 73846 RVA: 0x004A6918 File Offset: 0x004A4B18
			public void OnAchievementToggleValueChanged(bool on)
			{
				this.m_owner.OnAchievementToggleValueChanged(on);
			}

			// Token: 0x0400A345 RID: 41797
			private MissionUIController m_owner;
		}
	}
}
