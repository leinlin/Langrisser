using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
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
	// Token: 0x02000C56 RID: 3158
	[HotFix]
	public class DrillUIController : UIControllerBase
	{
		// Token: 0x0600DFE3 RID: 57315 RVA: 0x003C6070 File Offset: 0x003C4270
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
			this.m_trainingPanelTrainingButton.onClick.AddListener(new UnityAction(this.OnTrainingButtonClick));
			this.m_fastMaxButton.onClick.AddListener(new UnityAction(this.OnFastMaxButtonClick));
			this.m_soldierInfoButton.onClick.AddListener(new UnityAction(this.OnSoldierInfoButtonClick));
			this.m_trainingToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnTrainingToggleValueChanged));
			this.m_teachingToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnTeachingToggleValueChanged));
			this.m_stopTeachingPanelBackButton.onClick.AddListener(new UnityAction(this.CloseStopTeachingPanel));
			this.m_stopTeachingPanelCancelButton.onClick.AddListener(new UnityAction(this.CloseStopTeachingPanel));
			this.m_stopTeachingPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnStopTeachingPanelConfirmButtonClick));
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_teachingChar);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x003C6238 File Offset: 0x003C4438
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

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x003C62B4 File Offset: 0x003C44B4
		public void UpdateViewInDrill(int drillState = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInDrillInt32_hotfix != null)
			{
				this.m_UpdateViewInDrillInt32_hotfix.call(new object[]
				{
					this,
					drillState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_fastMaxButton.gameObject.SetActive(data.IsDeveloper);
			IEnumerable<KeyValuePair<int, ConfigDataTrainingRoomInfo>> allConfigDataTrainingRoomInfo = this.m_configDataLoader.GetAllConfigDataTrainingRoomInfo();
			Transform transform = this.m_trainingPanelLeftToggleGroup.transform;
			int num = 0;
			foreach (KeyValuePair<int, ConfigDataTrainingRoomInfo> keyValuePair in allConfigDataTrainingRoomInfo)
			{
				int id = keyValuePair.Value.ID;
				GameObject gameObject = transform.GetChild(num).gameObject;
				DrillRoomToggleUIController drillRoomToggleUIController = gameObject.GetComponent<DrillRoomToggleUIController>();
				if (drillRoomToggleUIController == null)
				{
					drillRoomToggleUIController = GameObjectUtility.AddControllerToGameObject<DrillRoomToggleUIController>(gameObject);
					drillRoomToggleUIController.EventOnToggleClick += this.OnRoomToggleClick;
				}
				drillRoomToggleUIController.InitRoomToggleInfo(id);
				num++;
				if (this.m_curTrainingRoom == null)
				{
					this.m_curTrainingRoom = this.m_playerContext.GetTrainingRoomById(id);
				}
				else
				{
					this.m_curTrainingRoom = this.m_playerContext.GetTrainingRoomById(this.m_curTrainingRoom.ConfigId);
				}
			}
			if (drillState >= 0)
			{
				this.m_curDrillState = (DrillUIController.DrillState)drillState;
			}
			DrillUIController.DrillState curDrillState = this.m_curDrillState;
			if (curDrillState != DrillUIController.DrillState.Training)
			{
				if (curDrillState == DrillUIController.DrillState.Teaching)
				{
					this.SetTeachingDetailPanel();
					if (!this.m_teachingToggle.isOn)
					{
						this.m_teachingToggle.isOn = true;
					}
				}
			}
			else
			{
				this.SetTrainingDetailPanel(this.m_curTrainingRoom);
				if (!this.m_trainingToggle.isOn)
				{
					this.m_trainingToggle.isOn = true;
				}
			}
			bool active = this.m_playerContext.HaveFinishedAssistantTask();
			this.m_teachingToggleClickRedMark.SetActive(active);
			this.m_teachingToggleUnClickRedMark.SetActive(active);
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x003C64EC File Offset: 0x003C46EC
		private void SetTrainingDetailPanel(TrainingRoom room)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTrainingDetailPanelTrainingRoom_hotfix != null)
			{
				this.m_SetTrainingDetailPanelTrainingRoom_hotfix.call(new object[]
				{
					this,
					room
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curTrainingRoom = room;
			if (this.m_curTrainingRoom == null)
			{
				return;
			}
			this.m_trainingPanelTitleInfoLvValueText.text = this.m_curTrainingRoom.Level.ToString();
			int num = 0;
			ConfigDataTrainingRoomLevelInfo configDataTrainingRoomLevelInfo = this.m_configDataLoader.GetConfigDataTrainingRoomLevelInfo(this.m_curTrainingRoom.Level);
			if (configDataTrainingRoomLevelInfo != null)
			{
				num = configDataTrainingRoomLevelInfo.ExpToNextLevel;
			}
			this.m_trainingPanelTitleInfoExpValueText.text = this.m_curTrainingRoom.Exp + "/" + num;
			if (num != 0)
			{
				this.m_trainingPanelTitleInfoProgressBar.fillAmount = (float)this.m_curTrainingRoom.Exp / (float)num;
			}
			else
			{
				this.m_trainingPanelTitleInfoProgressBar.fillAmount = 0f;
			}
			List<TrainingCourse> courses = this.m_curTrainingRoom.Courses;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_trainingPanelTrainingEventScrollViewContent, courses.Count);
			Transform transform = this.m_trainingPanelTrainingEventScrollViewContent.transform;
			for (int i = 0; i < courses.Count; i++)
			{
				CourseItemUIController component;
				if (i < transform.childCount)
				{
					GameObject gameObject = transform.GetChild(i).gameObject;
					component = gameObject.GetComponent<CourseItemUIController>();
					if (component == null)
					{
						PrefabControllerCreater.CreateAllControllers(gameObject);
						component = gameObject.GetComponent<CourseItemUIController>();
					}
				}
				else
				{
					GameObject assetInContainer = base.GetAssetInContainer<GameObject>("CourseItem");
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject2);
					component = gameObject2.GetComponent<CourseItemUIController>();
					component.EventOnCourseItemClick += this.OnCourseItemClick;
					gameObject2.transform.SetParent(transform, false);
				}
				component.InitCourseInfo(courses[i]);
			}
			this.SetPropertyAddition();
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x003C670C File Offset: 0x003C490C
		private void OnCourseItemClick(CourseItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCourseItemClickCourseItemUIController_hotfix != null)
			{
				this.m_OnCourseItemClickCourseItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnTrainingButtonClick != null)
			{
				this.EventOnTrainingButtonClick(ctrl.m_trainingCourse.ConfigId);
			}
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x003C67A0 File Offset: 0x003C49A0
		private void OnRoomToggleClick(DrillRoomToggleUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRoomToggleClickDrillRoomToggleUIController_hotfix != null)
			{
				this.m_OnRoomToggleClickDrillRoomToggleUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetTrainingDetailPanel(ctrl.Room);
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x003C681C File Offset: 0x003C4A1C
		private void SetPropertyAddition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropertyAddition_hotfix != null)
			{
				this.m_SetPropertyAddition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ResetAllPropertyState();
			List<ConfigDataBuffInfo> list = new List<ConfigDataBuffInfo>();
			foreach (TrainingCourse trainingCourse in this.m_curTrainingRoom.Courses)
			{
				foreach (TrainingTech trainingTech in trainingCourse.Techs)
				{
					if (trainingTech.Level != 0)
					{
						if (trainingTech.Config.TechType == TechDisplayType.TechDisplayType_SoldierTypeLevelUp)
						{
							int key = trainingTech.Config.TechLevelupInfoList[trainingTech.Level - 1];
							ConfigDataTrainingTechLevelInfo configDataTrainingTechLevelInfo = this.m_configDataLoader.GetConfigDataTrainingTechLevelInfo(key);
							ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataTrainingTechLevelInfo.SoldierSkillID);
							if (configDataSkillInfo != null)
							{
								if (configDataSkillInfo.m_passiveBuffInfos != null)
								{
									list.AddRange(configDataSkillInfo.m_passiveBuffInfos);
								}
							}
						}
					}
				}
			}
			this.m_buffPropArr = new int[8];
			foreach (ConfigDataBuffInfo configDataBuffInfo in list)
			{
				this.CalcSoldierPropertyModifityAddtion(configDataBuffInfo.Property1_ID, configDataBuffInfo.Property1_Value);
				this.CalcSoldierPropertyModifityAddtion(configDataBuffInfo.Property2_ID, configDataBuffInfo.Property2_Value);
				this.CalcSoldierPropertyModifityAddtion(configDataBuffInfo.Property3_ID, configDataBuffInfo.Property3_Value);
			}
			this.m_buffPropArr = null;
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x003C6A30 File Offset: 0x003C4C30
		private void ResetAllPropertyState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetAllPropertyState_hotfix != null)
			{
				this.m_ResetAllPropertyState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.propStateCtrlList == null)
			{
				this.propStateCtrlList = new List<CommonUIStateController>
				{
					this.m_trainingPanelPropretyGroupHPAddStateCtrl,
					this.m_trainingPanelPropretyGroupAttackAddStateCtrl,
					this.m_trainingPanelPropretyGroupDefenseAddStateCtrl,
					this.m_trainingPanelPropretyGroupMagicDFAddStateCtrl,
					this.m_trainingPanelPropretyGroupHPPerStateCtrl,
					this.m_trainingPanelPropretyGroupAttackPerStateCtrl,
					this.m_trainingPanelPropretyGroupDefensePerStateCtrl,
					this.m_trainingPanelPropretyGroupMagicDFPerStateCtrl
				};
			}
			foreach (CommonUIStateController commonUIStateController in this.propStateCtrlList)
			{
				commonUIStateController.SetToUIState("None", false, true);
			}
			if (this.propGoList == null)
			{
				this.propGoList = new List<Text>
				{
					this.m_trainingPanelPropretyGroupHPAddValue,
					this.m_trainingPanelPropretyGroupAttackAddValue,
					this.m_trainingPanelPropretyGroupDefenseAddValue,
					this.m_trainingPanelPropretyGroupMagicDFAddValue,
					this.m_trainingPanelPropretyGroupHPPerValue,
					this.m_trainingPanelPropretyGroupAttackPerValue,
					this.m_trainingPanelPropretyGroupDefensePerValue,
					this.m_trainingPanelPropretyGroupMagicDFPerValue
				};
			}
			foreach (Text text in this.propGoList)
			{
				text.text = "--";
			}
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x003C6C28 File Offset: 0x003C4E28
		private void CalcSoldierPropertyModifityAddtion(PropertyModifyType type, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcSoldierPropertyModifityAddtionPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_CalcSoldierPropertyModifityAddtionPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					type,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Soldier1_HPAdd:
				this.m_buffPropArr[0] += value;
				this.m_trainingPanelPropretyGroupHPAddValue.text = this.m_buffPropArr[0].ToString();
				this.m_trainingPanelPropretyGroupHPAddStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_ATAdd:
				this.m_buffPropArr[1] += value;
				this.m_trainingPanelPropretyGroupAttackAddValue.text = this.m_buffPropArr[1].ToString();
				this.m_trainingPanelPropretyGroupAttackAddStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_DFAdd:
				this.m_buffPropArr[2] += value;
				this.m_trainingPanelPropretyGroupDefenseAddValue.text = this.m_buffPropArr[2].ToString();
				this.m_trainingPanelPropretyGroupDefenseAddStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_MagicDFAdd:
				this.m_buffPropArr[3] += value;
				this.m_trainingPanelPropretyGroupMagicDFAddValue.text = this.m_buffPropArr[3].ToString();
				this.m_trainingPanelPropretyGroupMagicDFAddStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_HPMul:
				this.m_buffPropArr[4] += value;
				this.m_trainingPanelPropretyGroupHPPerValue.text = (float)this.m_buffPropArr[4] / 100f + "%";
				this.m_trainingPanelPropretyGroupHPPerStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_ATMul:
				this.m_buffPropArr[5] += value;
				this.m_trainingPanelPropretyGroupAttackPerValue.text = (float)this.m_buffPropArr[5] / 100f + "%";
				this.m_trainingPanelPropretyGroupAttackPerStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_DFMul:
				this.m_buffPropArr[6] += value;
				this.m_trainingPanelPropretyGroupDefensePerValue.text = (float)this.m_buffPropArr[6] / 100f + "%";
				this.m_trainingPanelPropretyGroupDefensePerStateCtrl.SetToUIState("Normal", false, true);
				break;
			case PropertyModifyType.PropertyModifyType_Soldier1_MagicDFMul:
				this.m_buffPropArr[7] += value;
				this.m_trainingPanelPropretyGroupMagicDFPerValue.text = (float)this.m_buffPropArr[7] / 100f + "%";
				this.m_trainingPanelPropretyGroupMagicDFPerStateCtrl.SetToUIState("Normal", false, true);
				break;
			}
		}

		// Token: 0x0600DFEC RID: 57324 RVA: 0x003C6F58 File Offset: 0x003C5158
		private void SetTeachingDetailPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeachingDetailPanel_hotfix != null)
			{
				this.m_SetTeachingDetailPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GameObject> list = new List<GameObject>();
			list.Add(this.m_teachingDetailTeam1);
			list.Add(this.m_teachingDetailTeam2);
			list.Add(this.m_teachingDetailTeam3);
			List<HeroAssistantsTaskAssignment> list2 = new List<HeroAssistantsTaskAssignment>();
			list2.AddRange(this.m_playerContext.GetAssignedHeroAssistantsTask());
			this.m_assistanceTeamUICtrlList = new List<AssistanceTeamUIController>();
			int i;
			for (i = 0; i < list.Count; i++)
			{
				HeroAssistantsTaskAssignment task = list2.Find((HeroAssistantsTaskAssignment t) => t.Slot == i);
				AssistanceTeamUIController assistanceTeamUIController = list[i].GetComponent<AssistanceTeamUIController>();
				if (assistanceTeamUIController == null)
				{
					assistanceTeamUIController = GameObjectUtility.AddControllerToGameObject<AssistanceTeamUIController>(list[i]);
					assistanceTeamUIController.EventOnTrainingButtonClick += this.OnAssistanceTeamTrainingButtonClick;
					assistanceTeamUIController.EventOnStopButtonClick += this.OnAssistanceTeamStopButtonClick;
					assistanceTeamUIController.EventOnGetRewardButtonClick += this.OnAssistanceTeamGetRewardButtonClick;
				}
				assistanceTeamUIController.InitAssistanceTeamInfo(task, i);
				this.m_assistanceTeamUICtrlList.Add(assistanceTeamUIController);
			}
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(22);
			if (this.m_heroCharUIController.GetCharImageInfo() != configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star))
			{
				this.m_heroCharUIController.CreateGraphic(configDataHeroInfo);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			}
			List<int> list3 = new List<int>();
			List<HeroAssistantsTask> allTodayHeroAssistantsTask = this.m_playerContext.GetAllTodayHeroAssistantsTask();
			if (allTodayHeroAssistantsTask.Count != 0)
			{
				ConfigDataHeroAssistantTaskScheduleInfo schedule = allTodayHeroAssistantsTask[0].Config.m_schedule;
				list3.AddRange(schedule.SoldierTypeList);
			}
			List<Image> list4 = new List<Image>
			{
				this.m_teachingTodayRewardArmyIcon1,
				this.m_teachingTodayRewardArmyIcon2
			};
			for (int j = 0; j < list4.Count; j++)
			{
				Image image = list4[j];
				if (j < list3.Count)
				{
					ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(list3[j]);
					image.gameObject.SetActive(true);
					image.sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon_NoBack);
				}
				else
				{
					image.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x003C7204 File Offset: 0x003C5404
		public void SetTeamTime(int slot, TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamTimeInt32TimeSpan_hotfix != null)
			{
				this.m_SetTeamTimeInt32TimeSpan_hotfix.call(new object[]
				{
					this,
					slot2,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			AssistanceTeamUIController assistanceTeamUIController = this.m_assistanceTeamUICtrlList.Find((AssistanceTeamUIController ctrl) => ctrl.m_heroAssistantsTask != null && ctrl.m_heroAssistantsTask.Slot == slot);
			if (assistanceTeamUIController != null)
			{
				assistanceTeamUIController.SetTimeText(ts);
			}
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x003C72BC File Offset: 0x003C54BC
		private void OnAssistanceTeamTrainingButtonClick(int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAssistanceTeamTrainingButtonClickInt32_hotfix != null)
			{
				this.m_OnAssistanceTeamTrainingButtonClickInt32_hotfix.call(new object[]
				{
					this,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAssistanceTrainingButtonClick != null)
			{
				this.EventOnAssistanceTrainingButtonClick(slot);
			}
		}

		// Token: 0x0600DFEF RID: 57327 RVA: 0x003C7344 File Offset: 0x003C5544
		private void OnAssistanceTeamStopButtonClick(AssistanceTeamUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAssistanceTeamStopButtonClickAssistanceTeamUIController_hotfix != null)
			{
				this.m_OnAssistanceTeamStopButtonClickAssistanceTeamUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stopHeroAssistantsTaskCtrl = ctrl;
			this.OpenStopTeachingPanel();
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x003C73C4 File Offset: 0x003C55C4
		private void OpenStopTeachingPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenStopTeachingPanel_hotfix != null)
			{
				this.m_OpenStopTeachingPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stopTeachingPanelStateCtrl.gameObject.SetActive(true);
			this.m_stopTeachingPanelStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x003C7448 File Offset: 0x003C5648
		private void CloseStopTeachingPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseStopTeachingPanel_hotfix != null)
			{
				this.m_CloseStopTeachingPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stopTeachingPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_stopTeachingPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_stopTeachingPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x003C74D8 File Offset: 0x003C56D8
		private void OnStopTeachingPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopTeachingPanelConfirmButtonClick_hotfix != null)
			{
				this.m_OnStopTeachingPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanCancelTask(this.m_stopHeroAssistantsTaskCtrl.m_heroAssistantsTask.TaskId, this.m_stopHeroAssistantsTaskCtrl.m_slot);
			if (num == 0)
			{
				if (this.EventOnAssistanceStopButtonClick != null)
				{
					this.EventOnAssistanceStopButtonClick(this.m_stopHeroAssistantsTaskCtrl.m_heroAssistantsTask.TaskId, this.m_stopHeroAssistantsTaskCtrl.m_slot, delegate
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_HeroAssistantTaskStop, 2f, null, true);
					});
				}
				this.CloseStopTeachingPanel();
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600DFF3 RID: 57331 RVA: 0x003C75D0 File Offset: 0x003C57D0
		private void OnAssistanceTeamGetRewardButtonClick(AssistanceTeamUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAssistanceTeamGetRewardButtonClickAssistanceTeamUIController_hotfix != null)
			{
				this.m_OnAssistanceTeamGetRewardButtonClickAssistanceTeamUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanClaimRewards(ctrl.m_heroAssistantsTask.TaskId, ctrl.m_slot);
			if (num == 0)
			{
				if (this.EventOnAssistanceGetRewardButtonClick != null)
				{
					this.EventOnAssistanceGetRewardButtonClick(ctrl.m_heroAssistantsTask.TaskId, ctrl.m_slot);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600DFF4 RID: 57332 RVA: 0x003C76A4 File Offset: 0x003C58A4
		private void OnTrainingButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingButtonClick_hotfix != null)
			{
				this.m_OnTrainingButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (TrainingCourse trainingCourse in this.m_curTrainingRoom.Courses)
			{
				if (!trainingCourse.Locked)
				{
					num = trainingCourse.ConfigId;
					break;
				}
			}
			if (this.EventOnTrainingButtonClick != null && num != 0)
			{
				this.EventOnTrainingButtonClick(num);
			}
		}

		// Token: 0x0600DFF5 RID: 57333 RVA: 0x003C7788 File Offset: 0x003C5988
		private void OnSoldierInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierInfoButtonClick_hotfix != null)
			{
				this.m_OnSoldierInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnManualButtonClick != null)
			{
				this.EventOnManualButtonClick();
			}
		}

		// Token: 0x0600DFF6 RID: 57334 RVA: 0x003C7800 File Offset: 0x003C5A00
		private void OnTrainingToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnTrainingToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curDrillState = DrillUIController.DrillState.Training;
				this.UpdateViewInDrill(-1);
				UIStateDesc currentUIState = this.m_trainingStateCtrl.GetCurrentUIState();
				if (currentUIState == null || (currentUIState != null && currentUIState.StateName != "Show"))
				{
					this.m_trainingStateCtrl.gameObject.SetActive(true);
					this.m_trainingStateCtrl.SetToUIState("Show", false, true);
					this.m_teachingStateCtrl.SetActionForUIStateFinshed("Close", delegate
					{
						this.m_teachingStateCtrl.gameObject.SetActive(false);
					});
					this.m_teachingStateCtrl.SetToUIState("Close", false, true);
				}
			}
		}

		// Token: 0x0600DFF7 RID: 57335 RVA: 0x003C7904 File Offset: 0x003C5B04
		private void OnTeachingToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTeachingToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnTeachingToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curDrillState = DrillUIController.DrillState.Teaching;
				this.UpdateViewInDrill(-1);
				UIStateDesc currentUIState = this.m_teachingStateCtrl.GetCurrentUIState();
				if (currentUIState == null || (currentUIState != null && currentUIState.StateName != "Show"))
				{
					this.m_teachingStateCtrl.gameObject.SetActive(true);
					this.m_teachingStateCtrl.SetToUIState("Show", false, true);
					this.m_trainingStateCtrl.SetActionForUIStateFinshed("Close", delegate
					{
						this.m_trainingStateCtrl.gameObject.SetActive(false);
					});
					this.m_trainingStateCtrl.SetToUIState("Close", false, true);
				}
			}
		}

		// Token: 0x0600DFF8 RID: 57336 RVA: 0x003C7A08 File Offset: 0x003C5C08
		private void OnFastMaxButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFastMaxButtonClick_hotfix != null)
			{
				this.m_OnFastMaxButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			string cmd = "SET_MAXTRAININGTECHS " + this.m_curTrainingRoom.ConfigId + ";-1;-1";
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateViewInDrill(-1);
					CommonUIController.Instance.ShowMessage("Succeed!", 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600DFF9 RID: 57337 RVA: 0x003C7AB4 File Offset: 0x003C5CB4
		private void ClearDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearDataCache_hotfix != null)
			{
				this.m_ClearDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curTrainingRoom = null;
			this.m_assistanceTeamUICtrlList.Clear();
		}

		// Token: 0x0600DFFA RID: 57338 RVA: 0x003C7B28 File Offset: 0x003C5D28
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
			this.m_trainingToggle.isOn = true;
			this.ClearDataCache();
		}

		// Token: 0x0600DFFB RID: 57339 RVA: 0x003C7BB0 File Offset: 0x003C5DB0
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

		// Token: 0x140002C9 RID: 713
		// (add) Token: 0x0600DFFC RID: 57340 RVA: 0x003C7C28 File Offset: 0x003C5E28
		// (remove) Token: 0x0600DFFD RID: 57341 RVA: 0x003C7CC4 File Offset: 0x003C5EC4
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

		// Token: 0x140002CA RID: 714
		// (add) Token: 0x0600DFFE RID: 57342 RVA: 0x003C7D60 File Offset: 0x003C5F60
		// (remove) Token: 0x0600DFFF RID: 57343 RVA: 0x003C7DFC File Offset: 0x003C5FFC
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

		// Token: 0x140002CB RID: 715
		// (add) Token: 0x0600E000 RID: 57344 RVA: 0x003C7E98 File Offset: 0x003C6098
		// (remove) Token: 0x0600E001 RID: 57345 RVA: 0x003C7F34 File Offset: 0x003C6134
		public event Action EventOnManualButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnManualButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnManualButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnManualButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnManualButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnManualButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnManualButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnManualButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnManualButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002CC RID: 716
		// (add) Token: 0x0600E002 RID: 57346 RVA: 0x003C7FD0 File Offset: 0x003C61D0
		// (remove) Token: 0x0600E003 RID: 57347 RVA: 0x003C806C File Offset: 0x003C626C
		public event Action<int> EventOnTrainingButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTrainingButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnTrainingButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnTrainingButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnTrainingButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTrainingButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnTrainingButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnTrainingButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnTrainingButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002CD RID: 717
		// (add) Token: 0x0600E004 RID: 57348 RVA: 0x003C8108 File Offset: 0x003C6308
		// (remove) Token: 0x0600E005 RID: 57349 RVA: 0x003C81A4 File Offset: 0x003C63A4
		public event Action<int> EventOnAssistanceTrainingButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAssistanceTrainingButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnAssistanceTrainingButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnAssistanceTrainingButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnAssistanceTrainingButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAssistanceTrainingButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnAssistanceTrainingButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnAssistanceTrainingButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnAssistanceTrainingButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002CE RID: 718
		// (add) Token: 0x0600E006 RID: 57350 RVA: 0x003C8240 File Offset: 0x003C6440
		// (remove) Token: 0x0600E007 RID: 57351 RVA: 0x003C82DC File Offset: 0x003C64DC
		public event Action<int, int, Action> EventOnAssistanceStopButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAssistanceStopButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnAssistanceStopButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnAssistanceStopButtonClick;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnAssistanceStopButtonClick, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAssistanceStopButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnAssistanceStopButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnAssistanceStopButtonClick;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnAssistanceStopButtonClick, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002CF RID: 719
		// (add) Token: 0x0600E008 RID: 57352 RVA: 0x003C8378 File Offset: 0x003C6578
		// (remove) Token: 0x0600E009 RID: 57353 RVA: 0x003C8414 File Offset: 0x003C6614
		public event Action<int, int> EventOnAssistanceGetRewardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAssistanceGetRewardButtonClickAction`2_hotfix != null)
				{
					this.m_add_EventOnAssistanceGetRewardButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnAssistanceGetRewardButtonClick;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnAssistanceGetRewardButtonClick, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAssistanceGetRewardButtonClickAction`2_hotfix != null)
				{
					this.m_remove_EventOnAssistanceGetRewardButtonClickAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnAssistanceGetRewardButtonClick;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnAssistanceGetRewardButtonClick, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600E00A RID: 57354 RVA: 0x003C84B0 File Offset: 0x003C66B0
		// (set) Token: 0x0600E00B RID: 57355 RVA: 0x003C84D0 File Offset: 0x003C66D0
		[DoNotToLua]
		public new DrillUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DrillUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E00C RID: 57356 RVA: 0x003C84DC File Offset: 0x003C66DC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x003C84E8 File Offset: 0x003C66E8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x003C84F0 File Offset: 0x003C66F0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x003C84F8 File Offset: 0x003C66F8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E010 RID: 57360 RVA: 0x003C850C File Offset: 0x003C670C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E011 RID: 57361 RVA: 0x003C8514 File Offset: 0x003C6714
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E012 RID: 57362 RVA: 0x003C8520 File Offset: 0x003C6720
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E013 RID: 57363 RVA: 0x003C852C File Offset: 0x003C672C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E014 RID: 57364 RVA: 0x003C8538 File Offset: 0x003C6738
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E015 RID: 57365 RVA: 0x003C8544 File Offset: 0x003C6744
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x003C8550 File Offset: 0x003C6750
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E017 RID: 57367 RVA: 0x003C855C File Offset: 0x003C675C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E018 RID: 57368 RVA: 0x003C8568 File Offset: 0x003C6768
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E019 RID: 57369 RVA: 0x003C8574 File Offset: 0x003C6774
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E01A RID: 57370 RVA: 0x003C8580 File Offset: 0x003C6780
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E01B RID: 57371 RVA: 0x003C8588 File Offset: 0x003C6788
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600E01C RID: 57372 RVA: 0x003C85A8 File Offset: 0x003C67A8
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600E01D RID: 57373 RVA: 0x003C85B4 File Offset: 0x003C67B4
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600E01E RID: 57374 RVA: 0x003C85D4 File Offset: 0x003C67D4
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600E01F RID: 57375 RVA: 0x003C85E0 File Offset: 0x003C67E0
		private void __callDele_EventOnManualButtonClick()
		{
			Action eventOnManualButtonClick = this.EventOnManualButtonClick;
			if (eventOnManualButtonClick != null)
			{
				eventOnManualButtonClick();
			}
		}

		// Token: 0x0600E020 RID: 57376 RVA: 0x003C8600 File Offset: 0x003C6800
		private void __clearDele_EventOnManualButtonClick()
		{
			this.EventOnManualButtonClick = null;
		}

		// Token: 0x0600E021 RID: 57377 RVA: 0x003C860C File Offset: 0x003C680C
		private void __callDele_EventOnTrainingButtonClick(int obj)
		{
			Action<int> eventOnTrainingButtonClick = this.EventOnTrainingButtonClick;
			if (eventOnTrainingButtonClick != null)
			{
				eventOnTrainingButtonClick(obj);
			}
		}

		// Token: 0x0600E022 RID: 57378 RVA: 0x003C8630 File Offset: 0x003C6830
		private void __clearDele_EventOnTrainingButtonClick(int obj)
		{
			this.EventOnTrainingButtonClick = null;
		}

		// Token: 0x0600E023 RID: 57379 RVA: 0x003C863C File Offset: 0x003C683C
		private void __callDele_EventOnAssistanceTrainingButtonClick(int obj)
		{
			Action<int> eventOnAssistanceTrainingButtonClick = this.EventOnAssistanceTrainingButtonClick;
			if (eventOnAssistanceTrainingButtonClick != null)
			{
				eventOnAssistanceTrainingButtonClick(obj);
			}
		}

		// Token: 0x0600E024 RID: 57380 RVA: 0x003C8660 File Offset: 0x003C6860
		private void __clearDele_EventOnAssistanceTrainingButtonClick(int obj)
		{
			this.EventOnAssistanceTrainingButtonClick = null;
		}

		// Token: 0x0600E025 RID: 57381 RVA: 0x003C866C File Offset: 0x003C686C
		private void __callDele_EventOnAssistanceStopButtonClick(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnAssistanceStopButtonClick = this.EventOnAssistanceStopButtonClick;
			if (eventOnAssistanceStopButtonClick != null)
			{
				eventOnAssistanceStopButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600E026 RID: 57382 RVA: 0x003C8690 File Offset: 0x003C6890
		private void __clearDele_EventOnAssistanceStopButtonClick(int arg1, int arg2, Action arg3)
		{
			this.EventOnAssistanceStopButtonClick = null;
		}

		// Token: 0x0600E027 RID: 57383 RVA: 0x003C869C File Offset: 0x003C689C
		private void __callDele_EventOnAssistanceGetRewardButtonClick(int arg1, int arg2)
		{
			Action<int, int> eventOnAssistanceGetRewardButtonClick = this.EventOnAssistanceGetRewardButtonClick;
			if (eventOnAssistanceGetRewardButtonClick != null)
			{
				eventOnAssistanceGetRewardButtonClick(arg1, arg2);
			}
		}

		// Token: 0x0600E028 RID: 57384 RVA: 0x003C86C0 File Offset: 0x003C68C0
		private void __clearDele_EventOnAssistanceGetRewardButtonClick(int arg1, int arg2)
		{
			this.EventOnAssistanceGetRewardButtonClick = null;
		}

		// Token: 0x0600E02E RID: 57390 RVA: 0x003C8778 File Offset: 0x003C6978
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
					this.m_UpdateViewInDrillInt32_hotfix = (luaObj.RawGet("UpdateViewInDrill") as LuaFunction);
					this.m_SetTrainingDetailPanelTrainingRoom_hotfix = (luaObj.RawGet("SetTrainingDetailPanel") as LuaFunction);
					this.m_OnCourseItemClickCourseItemUIController_hotfix = (luaObj.RawGet("OnCourseItemClick") as LuaFunction);
					this.m_OnRoomToggleClickDrillRoomToggleUIController_hotfix = (luaObj.RawGet("OnRoomToggleClick") as LuaFunction);
					this.m_SetPropertyAddition_hotfix = (luaObj.RawGet("SetPropertyAddition") as LuaFunction);
					this.m_ResetAllPropertyState_hotfix = (luaObj.RawGet("ResetAllPropertyState") as LuaFunction);
					this.m_CalcSoldierPropertyModifityAddtionPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("CalcSoldierPropertyModifityAddtion") as LuaFunction);
					this.m_SetTeachingDetailPanel_hotfix = (luaObj.RawGet("SetTeachingDetailPanel") as LuaFunction);
					this.m_SetTeamTimeInt32TimeSpan_hotfix = (luaObj.RawGet("SetTeamTime") as LuaFunction);
					this.m_OnAssistanceTeamTrainingButtonClickInt32_hotfix = (luaObj.RawGet("OnAssistanceTeamTrainingButtonClick") as LuaFunction);
					this.m_OnAssistanceTeamStopButtonClickAssistanceTeamUIController_hotfix = (luaObj.RawGet("OnAssistanceTeamStopButtonClick") as LuaFunction);
					this.m_OpenStopTeachingPanel_hotfix = (luaObj.RawGet("OpenStopTeachingPanel") as LuaFunction);
					this.m_CloseStopTeachingPanel_hotfix = (luaObj.RawGet("CloseStopTeachingPanel") as LuaFunction);
					this.m_OnStopTeachingPanelConfirmButtonClick_hotfix = (luaObj.RawGet("OnStopTeachingPanelConfirmButtonClick") as LuaFunction);
					this.m_OnAssistanceTeamGetRewardButtonClickAssistanceTeamUIController_hotfix = (luaObj.RawGet("OnAssistanceTeamGetRewardButtonClick") as LuaFunction);
					this.m_OnTrainingButtonClick_hotfix = (luaObj.RawGet("OnTrainingButtonClick") as LuaFunction);
					this.m_OnSoldierInfoButtonClick_hotfix = (luaObj.RawGet("OnSoldierInfoButtonClick") as LuaFunction);
					this.m_OnTrainingToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnTrainingToggleValueChanged") as LuaFunction);
					this.m_OnTeachingToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnTeachingToggleValueChanged") as LuaFunction);
					this.m_OnFastMaxButtonClick_hotfix = (luaObj.RawGet("OnFastMaxButtonClick") as LuaFunction);
					this.m_ClearDataCache_hotfix = (luaObj.RawGet("ClearDataCache") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnManualButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnManualButtonClick") as LuaFunction);
					this.m_remove_EventOnManualButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnManualButtonClick") as LuaFunction);
					this.m_add_EventOnTrainingButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnTrainingButtonClick") as LuaFunction);
					this.m_remove_EventOnTrainingButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnTrainingButtonClick") as LuaFunction);
					this.m_add_EventOnAssistanceTrainingButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAssistanceTrainingButtonClick") as LuaFunction);
					this.m_remove_EventOnAssistanceTrainingButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAssistanceTrainingButtonClick") as LuaFunction);
					this.m_add_EventOnAssistanceStopButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnAssistanceStopButtonClick") as LuaFunction);
					this.m_remove_EventOnAssistanceStopButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnAssistanceStopButtonClick") as LuaFunction);
					this.m_add_EventOnAssistanceGetRewardButtonClickAction`2_hotfix = (luaObj.RawGet("add_EventOnAssistanceGetRewardButtonClick") as LuaFunction);
					this.m_remove_EventOnAssistanceGetRewardButtonClickAction`2_hotfix = (luaObj.RawGet("remove_EventOnAssistanceGetRewardButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E02F RID: 57391 RVA: 0x003C8BFC File Offset: 0x003C6DFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DrillUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400882F RID: 34863
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04008830 RID: 34864
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008831 RID: 34865
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04008832 RID: 34866
		[AutoBind("./FastMaxButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fastMaxButton;

		// Token: 0x04008833 RID: 34867
		[AutoBind("./TrainingPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingStateCtrl;

		// Token: 0x04008834 RID: 34868
		[AutoBind("./TrainingPanel/LeftToggleGroup/Toggles", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_trainingPanelLeftToggleGroup;

		// Token: 0x04008835 RID: 34869
		[AutoBind("./TrainingPanel/DetailPanel/TitleInfoGroup/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelTitleInfoLvValueText;

		// Token: 0x04008836 RID: 34870
		[AutoBind("./TrainingPanel/DetailPanel/TitleInfoGroup/ExpValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelTitleInfoExpValueText;

		// Token: 0x04008837 RID: 34871
		[AutoBind("./TrainingPanel/DetailPanel/TitleInfoGroup/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_trainingPanelTitleInfoProgressBar;

		// Token: 0x04008838 RID: 34872
		[AutoBind("./TrainingPanel/DetailPanel/TrainingEventScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_trainingPanelTrainingEventScrollViewContent;

		// Token: 0x04008839 RID: 34873
		[AutoBind("./TrainingPanel/DetailPanel/TrainingButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_trainingPanelTrainingButton;

		// Token: 0x0400883A RID: 34874
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/HPAdd", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupHPAddStateCtrl;

		// Token: 0x0400883B RID: 34875
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/HPAdd/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupHPAddValue;

		// Token: 0x0400883C RID: 34876
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/AttackAdd", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupAttackAddStateCtrl;

		// Token: 0x0400883D RID: 34877
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/AttackAdd/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupAttackAddValue;

		// Token: 0x0400883E RID: 34878
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/DefenseAdd", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupDefenseAddStateCtrl;

		// Token: 0x0400883F RID: 34879
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/DefenseAdd/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupDefenseAddValue;

		// Token: 0x04008840 RID: 34880
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/MagicDFAdd", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupMagicDFAddStateCtrl;

		// Token: 0x04008841 RID: 34881
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/MagicDFAdd/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupMagicDFAddValue;

		// Token: 0x04008842 RID: 34882
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/HPPer", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupHPPerStateCtrl;

		// Token: 0x04008843 RID: 34883
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/HPPer/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupHPPerValue;

		// Token: 0x04008844 RID: 34884
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/AttackPer", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupAttackPerStateCtrl;

		// Token: 0x04008845 RID: 34885
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/AttackPer/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupAttackPerValue;

		// Token: 0x04008846 RID: 34886
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/DefensePer", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupDefensePerStateCtrl;

		// Token: 0x04008847 RID: 34887
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/DefensePer/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupDefensePerValue;

		// Token: 0x04008848 RID: 34888
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/MagicDFPer", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_trainingPanelPropretyGroupMagicDFPerStateCtrl;

		// Token: 0x04008849 RID: 34889
		[AutoBind("./TrainingPanel/DetailPanel/PropretyGroup/Detail/MagicDFPer/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingPanelPropretyGroupMagicDFPerValue;

		// Token: 0x0400884A RID: 34890
		[AutoBind("./Teaching", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_teachingStateCtrl;

		// Token: 0x0400884B RID: 34891
		[AutoBind("./Teaching", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teachingChar;

		// Token: 0x0400884C RID: 34892
		[AutoBind("./Teaching/Detail/Team1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teachingDetailTeam1;

		// Token: 0x0400884D RID: 34893
		[AutoBind("./Teaching/Detail/Team2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teachingDetailTeam2;

		// Token: 0x0400884E RID: 34894
		[AutoBind("./Teaching/Detail/Team3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teachingDetailTeam3;

		// Token: 0x0400884F RID: 34895
		[AutoBind("./Teaching/TodayReward/IconGroup/ArmyIcon1", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_teachingTodayRewardArmyIcon1;

		// Token: 0x04008850 RID: 34896
		[AutoBind("./Teaching/TodayReward/IconGroup/ArmyIcon2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_teachingTodayRewardArmyIcon2;

		// Token: 0x04008851 RID: 34897
		[AutoBind("./Margin/RightToggle/TrainingToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_trainingToggle;

		// Token: 0x04008852 RID: 34898
		[AutoBind("./Margin/RightToggle/TeachingToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_teachingToggle;

		// Token: 0x04008853 RID: 34899
		[AutoBind("./Margin/RightToggle/TeachingToggle/Click/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teachingToggleClickRedMark;

		// Token: 0x04008854 RID: 34900
		[AutoBind("./Margin/RightToggle/TeachingToggle/UnClick/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teachingToggleUnClickRedMark;

		// Token: 0x04008855 RID: 34901
		[AutoBind("./SoldierInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierInfoButton;

		// Token: 0x04008856 RID: 34902
		[AutoBind("./StopTeachingPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stopTeachingPanelStateCtrl;

		// Token: 0x04008857 RID: 34903
		[AutoBind("./StopTeachingPanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_stopTeachingPanelBackButton;

		// Token: 0x04008858 RID: 34904
		[AutoBind("./StopTeachingPanel/Panel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_stopTeachingPanelConfirmButton;

		// Token: 0x04008859 RID: 34905
		[AutoBind("./StopTeachingPanel/Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_stopTeachingPanelCancelButton;

		// Token: 0x0400885A RID: 34906
		private DrillUIController.DrillState m_curDrillState;

		// Token: 0x0400885B RID: 34907
		private TrainingRoom m_curTrainingRoom;

		// Token: 0x0400885C RID: 34908
		private List<AssistanceTeamUIController> m_assistanceTeamUICtrlList = new List<AssistanceTeamUIController>();

		// Token: 0x0400885D RID: 34909
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400885E RID: 34910
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400885F RID: 34911
		private int[] m_buffPropArr;

		// Token: 0x04008860 RID: 34912
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04008861 RID: 34913
		private AssistanceTeamUIController m_stopHeroAssistantsTaskCtrl;

		// Token: 0x04008862 RID: 34914
		private List<CommonUIStateController> propStateCtrlList;

		// Token: 0x04008863 RID: 34915
		private List<Text> propGoList;

		// Token: 0x04008864 RID: 34916
		[DoNotToLua]
		private DrillUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008866 RID: 34918
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008867 RID: 34919
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008868 RID: 34920
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008869 RID: 34921
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400886A RID: 34922
		private LuaFunction m_UpdateViewInDrillInt32_hotfix;

		// Token: 0x0400886B RID: 34923
		private LuaFunction m_SetTrainingDetailPanelTrainingRoom_hotfix;

		// Token: 0x0400886C RID: 34924
		private LuaFunction m_OnCourseItemClickCourseItemUIController_hotfix;

		// Token: 0x0400886D RID: 34925
		private LuaFunction m_OnRoomToggleClickDrillRoomToggleUIController_hotfix;

		// Token: 0x0400886E RID: 34926
		private LuaFunction m_SetPropertyAddition_hotfix;

		// Token: 0x0400886F RID: 34927
		private LuaFunction m_ResetAllPropertyState_hotfix;

		// Token: 0x04008870 RID: 34928
		private LuaFunction m_CalcSoldierPropertyModifityAddtionPropertyModifyTypeInt32_hotfix;

		// Token: 0x04008871 RID: 34929
		private LuaFunction m_SetTeachingDetailPanel_hotfix;

		// Token: 0x04008872 RID: 34930
		private LuaFunction m_SetTeamTimeInt32TimeSpan_hotfix;

		// Token: 0x04008873 RID: 34931
		private LuaFunction m_OnAssistanceTeamTrainingButtonClickInt32_hotfix;

		// Token: 0x04008874 RID: 34932
		private LuaFunction m_OnAssistanceTeamStopButtonClickAssistanceTeamUIController_hotfix;

		// Token: 0x04008875 RID: 34933
		private LuaFunction m_OpenStopTeachingPanel_hotfix;

		// Token: 0x04008876 RID: 34934
		private LuaFunction m_CloseStopTeachingPanel_hotfix;

		// Token: 0x04008877 RID: 34935
		private LuaFunction m_OnStopTeachingPanelConfirmButtonClick_hotfix;

		// Token: 0x04008878 RID: 34936
		private LuaFunction m_OnAssistanceTeamGetRewardButtonClickAssistanceTeamUIController_hotfix;

		// Token: 0x04008879 RID: 34937
		private LuaFunction m_OnTrainingButtonClick_hotfix;

		// Token: 0x0400887A RID: 34938
		private LuaFunction m_OnSoldierInfoButtonClick_hotfix;

		// Token: 0x0400887B RID: 34939
		private LuaFunction m_OnTrainingToggleValueChangedBoolean_hotfix;

		// Token: 0x0400887C RID: 34940
		private LuaFunction m_OnTeachingToggleValueChangedBoolean_hotfix;

		// Token: 0x0400887D RID: 34941
		private LuaFunction m_OnFastMaxButtonClick_hotfix;

		// Token: 0x0400887E RID: 34942
		private LuaFunction m_ClearDataCache_hotfix;

		// Token: 0x0400887F RID: 34943
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008880 RID: 34944
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04008881 RID: 34945
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008882 RID: 34946
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008883 RID: 34947
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04008884 RID: 34948
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04008885 RID: 34949
		private LuaFunction m_add_EventOnManualButtonClickAction_hotfix;

		// Token: 0x04008886 RID: 34950
		private LuaFunction m_remove_EventOnManualButtonClickAction_hotfix;

		// Token: 0x04008887 RID: 34951
		private LuaFunction m_add_EventOnTrainingButtonClickAction;

		// Token: 0x04008888 RID: 34952
		private LuaFunction m_remove_EventOnTrainingButtonClickAction;

		// Token: 0x04008889 RID: 34953
		private LuaFunction m_add_EventOnAssistanceTrainingButtonClickAction;

		// Token: 0x0400888A RID: 34954
		private LuaFunction m_remove_EventOnAssistanceTrainingButtonClickAction;

		// Token: 0x0400888B RID: 34955
		private LuaFunction m_add_EventOnAssistanceStopButtonClickAction;

		// Token: 0x0400888C RID: 34956
		private LuaFunction m_remove_EventOnAssistanceStopButtonClickAction;

		// Token: 0x0400888D RID: 34957
		private LuaFunction m_add_EventOnAssistanceGetRewardButtonClickAction;

		// Token: 0x0400888E RID: 34958
		private LuaFunction m_remove_EventOnAssistanceGetRewardButtonClickAction;

		// Token: 0x02000C57 RID: 3159
		public enum DrillState
		{
			// Token: 0x04008890 RID: 34960
			Training,
			// Token: 0x04008891 RID: 34961
			Teaching
		}

		// Token: 0x02000C58 RID: 3160
		public new class LuaExportHelper
		{
			// Token: 0x0600E030 RID: 57392 RVA: 0x003C8C64 File Offset: 0x003C6E64
			public LuaExportHelper(DrillUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E031 RID: 57393 RVA: 0x003C8C74 File Offset: 0x003C6E74
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E032 RID: 57394 RVA: 0x003C8C84 File Offset: 0x003C6E84
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E033 RID: 57395 RVA: 0x003C8C94 File Offset: 0x003C6E94
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E034 RID: 57396 RVA: 0x003C8CA4 File Offset: 0x003C6EA4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E035 RID: 57397 RVA: 0x003C8CBC File Offset: 0x003C6EBC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E036 RID: 57398 RVA: 0x003C8CCC File Offset: 0x003C6ECC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E037 RID: 57399 RVA: 0x003C8CDC File Offset: 0x003C6EDC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E038 RID: 57400 RVA: 0x003C8CEC File Offset: 0x003C6EEC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E039 RID: 57401 RVA: 0x003C8CFC File Offset: 0x003C6EFC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E03A RID: 57402 RVA: 0x003C8D0C File Offset: 0x003C6F0C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E03B RID: 57403 RVA: 0x003C8D1C File Offset: 0x003C6F1C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E03C RID: 57404 RVA: 0x003C8D2C File Offset: 0x003C6F2C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E03D RID: 57405 RVA: 0x003C8D3C File Offset: 0x003C6F3C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E03E RID: 57406 RVA: 0x003C8D4C File Offset: 0x003C6F4C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E03F RID: 57407 RVA: 0x003C8D5C File Offset: 0x003C6F5C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E040 RID: 57408 RVA: 0x003C8D6C File Offset: 0x003C6F6C
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600E041 RID: 57409 RVA: 0x003C8D7C File Offset: 0x003C6F7C
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600E042 RID: 57410 RVA: 0x003C8D8C File Offset: 0x003C6F8C
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600E043 RID: 57411 RVA: 0x003C8D9C File Offset: 0x003C6F9C
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600E044 RID: 57412 RVA: 0x003C8DAC File Offset: 0x003C6FAC
			public void __callDele_EventOnManualButtonClick()
			{
				this.m_owner.__callDele_EventOnManualButtonClick();
			}

			// Token: 0x0600E045 RID: 57413 RVA: 0x003C8DBC File Offset: 0x003C6FBC
			public void __clearDele_EventOnManualButtonClick()
			{
				this.m_owner.__clearDele_EventOnManualButtonClick();
			}

			// Token: 0x0600E046 RID: 57414 RVA: 0x003C8DCC File Offset: 0x003C6FCC
			public void __callDele_EventOnTrainingButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnTrainingButtonClick(obj);
			}

			// Token: 0x0600E047 RID: 57415 RVA: 0x003C8DDC File Offset: 0x003C6FDC
			public void __clearDele_EventOnTrainingButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnTrainingButtonClick(obj);
			}

			// Token: 0x0600E048 RID: 57416 RVA: 0x003C8DEC File Offset: 0x003C6FEC
			public void __callDele_EventOnAssistanceTrainingButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnAssistanceTrainingButtonClick(obj);
			}

			// Token: 0x0600E049 RID: 57417 RVA: 0x003C8DFC File Offset: 0x003C6FFC
			public void __clearDele_EventOnAssistanceTrainingButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnAssistanceTrainingButtonClick(obj);
			}

			// Token: 0x0600E04A RID: 57418 RVA: 0x003C8E0C File Offset: 0x003C700C
			public void __callDele_EventOnAssistanceStopButtonClick(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnAssistanceStopButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E04B RID: 57419 RVA: 0x003C8E1C File Offset: 0x003C701C
			public void __clearDele_EventOnAssistanceStopButtonClick(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnAssistanceStopButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E04C RID: 57420 RVA: 0x003C8E2C File Offset: 0x003C702C
			public void __callDele_EventOnAssistanceGetRewardButtonClick(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnAssistanceGetRewardButtonClick(arg1, arg2);
			}

			// Token: 0x0600E04D RID: 57421 RVA: 0x003C8E3C File Offset: 0x003C703C
			public void __clearDele_EventOnAssistanceGetRewardButtonClick(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnAssistanceGetRewardButtonClick(arg1, arg2);
			}

			// Token: 0x17002B7C RID: 11132
			// (get) Token: 0x0600E04E RID: 57422 RVA: 0x003C8E4C File Offset: 0x003C704C
			// (set) Token: 0x0600E04F RID: 57423 RVA: 0x003C8E5C File Offset: 0x003C705C
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

			// Token: 0x17002B7D RID: 11133
			// (get) Token: 0x0600E050 RID: 57424 RVA: 0x003C8E6C File Offset: 0x003C706C
			// (set) Token: 0x0600E051 RID: 57425 RVA: 0x003C8E7C File Offset: 0x003C707C
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

			// Token: 0x17002B7E RID: 11134
			// (get) Token: 0x0600E052 RID: 57426 RVA: 0x003C8E8C File Offset: 0x003C708C
			// (set) Token: 0x0600E053 RID: 57427 RVA: 0x003C8E9C File Offset: 0x003C709C
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

			// Token: 0x17002B7F RID: 11135
			// (get) Token: 0x0600E054 RID: 57428 RVA: 0x003C8EAC File Offset: 0x003C70AC
			// (set) Token: 0x0600E055 RID: 57429 RVA: 0x003C8EBC File Offset: 0x003C70BC
			public Button m_fastMaxButton
			{
				get
				{
					return this.m_owner.m_fastMaxButton;
				}
				set
				{
					this.m_owner.m_fastMaxButton = value;
				}
			}

			// Token: 0x17002B80 RID: 11136
			// (get) Token: 0x0600E056 RID: 57430 RVA: 0x003C8ECC File Offset: 0x003C70CC
			// (set) Token: 0x0600E057 RID: 57431 RVA: 0x003C8EDC File Offset: 0x003C70DC
			public CommonUIStateController m_trainingStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingStateCtrl = value;
				}
			}

			// Token: 0x17002B81 RID: 11137
			// (get) Token: 0x0600E058 RID: 57432 RVA: 0x003C8EEC File Offset: 0x003C70EC
			// (set) Token: 0x0600E059 RID: 57433 RVA: 0x003C8EFC File Offset: 0x003C70FC
			public GameObject m_trainingPanelLeftToggleGroup
			{
				get
				{
					return this.m_owner.m_trainingPanelLeftToggleGroup;
				}
				set
				{
					this.m_owner.m_trainingPanelLeftToggleGroup = value;
				}
			}

			// Token: 0x17002B82 RID: 11138
			// (get) Token: 0x0600E05A RID: 57434 RVA: 0x003C8F0C File Offset: 0x003C710C
			// (set) Token: 0x0600E05B RID: 57435 RVA: 0x003C8F1C File Offset: 0x003C711C
			public Text m_trainingPanelTitleInfoLvValueText
			{
				get
				{
					return this.m_owner.m_trainingPanelTitleInfoLvValueText;
				}
				set
				{
					this.m_owner.m_trainingPanelTitleInfoLvValueText = value;
				}
			}

			// Token: 0x17002B83 RID: 11139
			// (get) Token: 0x0600E05C RID: 57436 RVA: 0x003C8F2C File Offset: 0x003C712C
			// (set) Token: 0x0600E05D RID: 57437 RVA: 0x003C8F3C File Offset: 0x003C713C
			public Text m_trainingPanelTitleInfoExpValueText
			{
				get
				{
					return this.m_owner.m_trainingPanelTitleInfoExpValueText;
				}
				set
				{
					this.m_owner.m_trainingPanelTitleInfoExpValueText = value;
				}
			}

			// Token: 0x17002B84 RID: 11140
			// (get) Token: 0x0600E05E RID: 57438 RVA: 0x003C8F4C File Offset: 0x003C714C
			// (set) Token: 0x0600E05F RID: 57439 RVA: 0x003C8F5C File Offset: 0x003C715C
			public Image m_trainingPanelTitleInfoProgressBar
			{
				get
				{
					return this.m_owner.m_trainingPanelTitleInfoProgressBar;
				}
				set
				{
					this.m_owner.m_trainingPanelTitleInfoProgressBar = value;
				}
			}

			// Token: 0x17002B85 RID: 11141
			// (get) Token: 0x0600E060 RID: 57440 RVA: 0x003C8F6C File Offset: 0x003C716C
			// (set) Token: 0x0600E061 RID: 57441 RVA: 0x003C8F7C File Offset: 0x003C717C
			public GameObject m_trainingPanelTrainingEventScrollViewContent
			{
				get
				{
					return this.m_owner.m_trainingPanelTrainingEventScrollViewContent;
				}
				set
				{
					this.m_owner.m_trainingPanelTrainingEventScrollViewContent = value;
				}
			}

			// Token: 0x17002B86 RID: 11142
			// (get) Token: 0x0600E062 RID: 57442 RVA: 0x003C8F8C File Offset: 0x003C718C
			// (set) Token: 0x0600E063 RID: 57443 RVA: 0x003C8F9C File Offset: 0x003C719C
			public Button m_trainingPanelTrainingButton
			{
				get
				{
					return this.m_owner.m_trainingPanelTrainingButton;
				}
				set
				{
					this.m_owner.m_trainingPanelTrainingButton = value;
				}
			}

			// Token: 0x17002B87 RID: 11143
			// (get) Token: 0x0600E064 RID: 57444 RVA: 0x003C8FAC File Offset: 0x003C71AC
			// (set) Token: 0x0600E065 RID: 57445 RVA: 0x003C8FBC File Offset: 0x003C71BC
			public CommonUIStateController m_trainingPanelPropretyGroupHPAddStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupHPAddStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupHPAddStateCtrl = value;
				}
			}

			// Token: 0x17002B88 RID: 11144
			// (get) Token: 0x0600E066 RID: 57446 RVA: 0x003C8FCC File Offset: 0x003C71CC
			// (set) Token: 0x0600E067 RID: 57447 RVA: 0x003C8FDC File Offset: 0x003C71DC
			public Text m_trainingPanelPropretyGroupHPAddValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupHPAddValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupHPAddValue = value;
				}
			}

			// Token: 0x17002B89 RID: 11145
			// (get) Token: 0x0600E068 RID: 57448 RVA: 0x003C8FEC File Offset: 0x003C71EC
			// (set) Token: 0x0600E069 RID: 57449 RVA: 0x003C8FFC File Offset: 0x003C71FC
			public CommonUIStateController m_trainingPanelPropretyGroupAttackAddStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupAttackAddStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupAttackAddStateCtrl = value;
				}
			}

			// Token: 0x17002B8A RID: 11146
			// (get) Token: 0x0600E06A RID: 57450 RVA: 0x003C900C File Offset: 0x003C720C
			// (set) Token: 0x0600E06B RID: 57451 RVA: 0x003C901C File Offset: 0x003C721C
			public Text m_trainingPanelPropretyGroupAttackAddValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupAttackAddValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupAttackAddValue = value;
				}
			}

			// Token: 0x17002B8B RID: 11147
			// (get) Token: 0x0600E06C RID: 57452 RVA: 0x003C902C File Offset: 0x003C722C
			// (set) Token: 0x0600E06D RID: 57453 RVA: 0x003C903C File Offset: 0x003C723C
			public CommonUIStateController m_trainingPanelPropretyGroupDefenseAddStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupDefenseAddStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupDefenseAddStateCtrl = value;
				}
			}

			// Token: 0x17002B8C RID: 11148
			// (get) Token: 0x0600E06E RID: 57454 RVA: 0x003C904C File Offset: 0x003C724C
			// (set) Token: 0x0600E06F RID: 57455 RVA: 0x003C905C File Offset: 0x003C725C
			public Text m_trainingPanelPropretyGroupDefenseAddValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupDefenseAddValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupDefenseAddValue = value;
				}
			}

			// Token: 0x17002B8D RID: 11149
			// (get) Token: 0x0600E070 RID: 57456 RVA: 0x003C906C File Offset: 0x003C726C
			// (set) Token: 0x0600E071 RID: 57457 RVA: 0x003C907C File Offset: 0x003C727C
			public CommonUIStateController m_trainingPanelPropretyGroupMagicDFAddStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupMagicDFAddStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupMagicDFAddStateCtrl = value;
				}
			}

			// Token: 0x17002B8E RID: 11150
			// (get) Token: 0x0600E072 RID: 57458 RVA: 0x003C908C File Offset: 0x003C728C
			// (set) Token: 0x0600E073 RID: 57459 RVA: 0x003C909C File Offset: 0x003C729C
			public Text m_trainingPanelPropretyGroupMagicDFAddValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupMagicDFAddValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupMagicDFAddValue = value;
				}
			}

			// Token: 0x17002B8F RID: 11151
			// (get) Token: 0x0600E074 RID: 57460 RVA: 0x003C90AC File Offset: 0x003C72AC
			// (set) Token: 0x0600E075 RID: 57461 RVA: 0x003C90BC File Offset: 0x003C72BC
			public CommonUIStateController m_trainingPanelPropretyGroupHPPerStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupHPPerStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupHPPerStateCtrl = value;
				}
			}

			// Token: 0x17002B90 RID: 11152
			// (get) Token: 0x0600E076 RID: 57462 RVA: 0x003C90CC File Offset: 0x003C72CC
			// (set) Token: 0x0600E077 RID: 57463 RVA: 0x003C90DC File Offset: 0x003C72DC
			public Text m_trainingPanelPropretyGroupHPPerValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupHPPerValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupHPPerValue = value;
				}
			}

			// Token: 0x17002B91 RID: 11153
			// (get) Token: 0x0600E078 RID: 57464 RVA: 0x003C90EC File Offset: 0x003C72EC
			// (set) Token: 0x0600E079 RID: 57465 RVA: 0x003C90FC File Offset: 0x003C72FC
			public CommonUIStateController m_trainingPanelPropretyGroupAttackPerStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupAttackPerStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupAttackPerStateCtrl = value;
				}
			}

			// Token: 0x17002B92 RID: 11154
			// (get) Token: 0x0600E07A RID: 57466 RVA: 0x003C910C File Offset: 0x003C730C
			// (set) Token: 0x0600E07B RID: 57467 RVA: 0x003C911C File Offset: 0x003C731C
			public Text m_trainingPanelPropretyGroupAttackPerValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupAttackPerValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupAttackPerValue = value;
				}
			}

			// Token: 0x17002B93 RID: 11155
			// (get) Token: 0x0600E07C RID: 57468 RVA: 0x003C912C File Offset: 0x003C732C
			// (set) Token: 0x0600E07D RID: 57469 RVA: 0x003C913C File Offset: 0x003C733C
			public CommonUIStateController m_trainingPanelPropretyGroupDefensePerStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupDefensePerStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupDefensePerStateCtrl = value;
				}
			}

			// Token: 0x17002B94 RID: 11156
			// (get) Token: 0x0600E07E RID: 57470 RVA: 0x003C914C File Offset: 0x003C734C
			// (set) Token: 0x0600E07F RID: 57471 RVA: 0x003C915C File Offset: 0x003C735C
			public Text m_trainingPanelPropretyGroupDefensePerValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupDefensePerValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupDefensePerValue = value;
				}
			}

			// Token: 0x17002B95 RID: 11157
			// (get) Token: 0x0600E080 RID: 57472 RVA: 0x003C916C File Offset: 0x003C736C
			// (set) Token: 0x0600E081 RID: 57473 RVA: 0x003C917C File Offset: 0x003C737C
			public CommonUIStateController m_trainingPanelPropretyGroupMagicDFPerStateCtrl
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupMagicDFPerStateCtrl;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupMagicDFPerStateCtrl = value;
				}
			}

			// Token: 0x17002B96 RID: 11158
			// (get) Token: 0x0600E082 RID: 57474 RVA: 0x003C918C File Offset: 0x003C738C
			// (set) Token: 0x0600E083 RID: 57475 RVA: 0x003C919C File Offset: 0x003C739C
			public Text m_trainingPanelPropretyGroupMagicDFPerValue
			{
				get
				{
					return this.m_owner.m_trainingPanelPropretyGroupMagicDFPerValue;
				}
				set
				{
					this.m_owner.m_trainingPanelPropretyGroupMagicDFPerValue = value;
				}
			}

			// Token: 0x17002B97 RID: 11159
			// (get) Token: 0x0600E084 RID: 57476 RVA: 0x003C91AC File Offset: 0x003C73AC
			// (set) Token: 0x0600E085 RID: 57477 RVA: 0x003C91BC File Offset: 0x003C73BC
			public CommonUIStateController m_teachingStateCtrl
			{
				get
				{
					return this.m_owner.m_teachingStateCtrl;
				}
				set
				{
					this.m_owner.m_teachingStateCtrl = value;
				}
			}

			// Token: 0x17002B98 RID: 11160
			// (get) Token: 0x0600E086 RID: 57478 RVA: 0x003C91CC File Offset: 0x003C73CC
			// (set) Token: 0x0600E087 RID: 57479 RVA: 0x003C91DC File Offset: 0x003C73DC
			public GameObject m_teachingChar
			{
				get
				{
					return this.m_owner.m_teachingChar;
				}
				set
				{
					this.m_owner.m_teachingChar = value;
				}
			}

			// Token: 0x17002B99 RID: 11161
			// (get) Token: 0x0600E088 RID: 57480 RVA: 0x003C91EC File Offset: 0x003C73EC
			// (set) Token: 0x0600E089 RID: 57481 RVA: 0x003C91FC File Offset: 0x003C73FC
			public GameObject m_teachingDetailTeam1
			{
				get
				{
					return this.m_owner.m_teachingDetailTeam1;
				}
				set
				{
					this.m_owner.m_teachingDetailTeam1 = value;
				}
			}

			// Token: 0x17002B9A RID: 11162
			// (get) Token: 0x0600E08A RID: 57482 RVA: 0x003C920C File Offset: 0x003C740C
			// (set) Token: 0x0600E08B RID: 57483 RVA: 0x003C921C File Offset: 0x003C741C
			public GameObject m_teachingDetailTeam2
			{
				get
				{
					return this.m_owner.m_teachingDetailTeam2;
				}
				set
				{
					this.m_owner.m_teachingDetailTeam2 = value;
				}
			}

			// Token: 0x17002B9B RID: 11163
			// (get) Token: 0x0600E08C RID: 57484 RVA: 0x003C922C File Offset: 0x003C742C
			// (set) Token: 0x0600E08D RID: 57485 RVA: 0x003C923C File Offset: 0x003C743C
			public GameObject m_teachingDetailTeam3
			{
				get
				{
					return this.m_owner.m_teachingDetailTeam3;
				}
				set
				{
					this.m_owner.m_teachingDetailTeam3 = value;
				}
			}

			// Token: 0x17002B9C RID: 11164
			// (get) Token: 0x0600E08E RID: 57486 RVA: 0x003C924C File Offset: 0x003C744C
			// (set) Token: 0x0600E08F RID: 57487 RVA: 0x003C925C File Offset: 0x003C745C
			public Image m_teachingTodayRewardArmyIcon1
			{
				get
				{
					return this.m_owner.m_teachingTodayRewardArmyIcon1;
				}
				set
				{
					this.m_owner.m_teachingTodayRewardArmyIcon1 = value;
				}
			}

			// Token: 0x17002B9D RID: 11165
			// (get) Token: 0x0600E090 RID: 57488 RVA: 0x003C926C File Offset: 0x003C746C
			// (set) Token: 0x0600E091 RID: 57489 RVA: 0x003C927C File Offset: 0x003C747C
			public Image m_teachingTodayRewardArmyIcon2
			{
				get
				{
					return this.m_owner.m_teachingTodayRewardArmyIcon2;
				}
				set
				{
					this.m_owner.m_teachingTodayRewardArmyIcon2 = value;
				}
			}

			// Token: 0x17002B9E RID: 11166
			// (get) Token: 0x0600E092 RID: 57490 RVA: 0x003C928C File Offset: 0x003C748C
			// (set) Token: 0x0600E093 RID: 57491 RVA: 0x003C929C File Offset: 0x003C749C
			public Toggle m_trainingToggle
			{
				get
				{
					return this.m_owner.m_trainingToggle;
				}
				set
				{
					this.m_owner.m_trainingToggle = value;
				}
			}

			// Token: 0x17002B9F RID: 11167
			// (get) Token: 0x0600E094 RID: 57492 RVA: 0x003C92AC File Offset: 0x003C74AC
			// (set) Token: 0x0600E095 RID: 57493 RVA: 0x003C92BC File Offset: 0x003C74BC
			public Toggle m_teachingToggle
			{
				get
				{
					return this.m_owner.m_teachingToggle;
				}
				set
				{
					this.m_owner.m_teachingToggle = value;
				}
			}

			// Token: 0x17002BA0 RID: 11168
			// (get) Token: 0x0600E096 RID: 57494 RVA: 0x003C92CC File Offset: 0x003C74CC
			// (set) Token: 0x0600E097 RID: 57495 RVA: 0x003C92DC File Offset: 0x003C74DC
			public GameObject m_teachingToggleClickRedMark
			{
				get
				{
					return this.m_owner.m_teachingToggleClickRedMark;
				}
				set
				{
					this.m_owner.m_teachingToggleClickRedMark = value;
				}
			}

			// Token: 0x17002BA1 RID: 11169
			// (get) Token: 0x0600E098 RID: 57496 RVA: 0x003C92EC File Offset: 0x003C74EC
			// (set) Token: 0x0600E099 RID: 57497 RVA: 0x003C92FC File Offset: 0x003C74FC
			public GameObject m_teachingToggleUnClickRedMark
			{
				get
				{
					return this.m_owner.m_teachingToggleUnClickRedMark;
				}
				set
				{
					this.m_owner.m_teachingToggleUnClickRedMark = value;
				}
			}

			// Token: 0x17002BA2 RID: 11170
			// (get) Token: 0x0600E09A RID: 57498 RVA: 0x003C930C File Offset: 0x003C750C
			// (set) Token: 0x0600E09B RID: 57499 RVA: 0x003C931C File Offset: 0x003C751C
			public Button m_soldierInfoButton
			{
				get
				{
					return this.m_owner.m_soldierInfoButton;
				}
				set
				{
					this.m_owner.m_soldierInfoButton = value;
				}
			}

			// Token: 0x17002BA3 RID: 11171
			// (get) Token: 0x0600E09C RID: 57500 RVA: 0x003C932C File Offset: 0x003C752C
			// (set) Token: 0x0600E09D RID: 57501 RVA: 0x003C933C File Offset: 0x003C753C
			public CommonUIStateController m_stopTeachingPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_stopTeachingPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_stopTeachingPanelStateCtrl = value;
				}
			}

			// Token: 0x17002BA4 RID: 11172
			// (get) Token: 0x0600E09E RID: 57502 RVA: 0x003C934C File Offset: 0x003C754C
			// (set) Token: 0x0600E09F RID: 57503 RVA: 0x003C935C File Offset: 0x003C755C
			public Button m_stopTeachingPanelBackButton
			{
				get
				{
					return this.m_owner.m_stopTeachingPanelBackButton;
				}
				set
				{
					this.m_owner.m_stopTeachingPanelBackButton = value;
				}
			}

			// Token: 0x17002BA5 RID: 11173
			// (get) Token: 0x0600E0A0 RID: 57504 RVA: 0x003C936C File Offset: 0x003C756C
			// (set) Token: 0x0600E0A1 RID: 57505 RVA: 0x003C937C File Offset: 0x003C757C
			public Button m_stopTeachingPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_stopTeachingPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_stopTeachingPanelConfirmButton = value;
				}
			}

			// Token: 0x17002BA6 RID: 11174
			// (get) Token: 0x0600E0A2 RID: 57506 RVA: 0x003C938C File Offset: 0x003C758C
			// (set) Token: 0x0600E0A3 RID: 57507 RVA: 0x003C939C File Offset: 0x003C759C
			public Button m_stopTeachingPanelCancelButton
			{
				get
				{
					return this.m_owner.m_stopTeachingPanelCancelButton;
				}
				set
				{
					this.m_owner.m_stopTeachingPanelCancelButton = value;
				}
			}

			// Token: 0x17002BA7 RID: 11175
			// (get) Token: 0x0600E0A4 RID: 57508 RVA: 0x003C93AC File Offset: 0x003C75AC
			// (set) Token: 0x0600E0A5 RID: 57509 RVA: 0x003C93BC File Offset: 0x003C75BC
			public DrillUIController.DrillState m_curDrillState
			{
				get
				{
					return this.m_owner.m_curDrillState;
				}
				set
				{
					this.m_owner.m_curDrillState = value;
				}
			}

			// Token: 0x17002BA8 RID: 11176
			// (get) Token: 0x0600E0A6 RID: 57510 RVA: 0x003C93CC File Offset: 0x003C75CC
			// (set) Token: 0x0600E0A7 RID: 57511 RVA: 0x003C93DC File Offset: 0x003C75DC
			public TrainingRoom m_curTrainingRoom
			{
				get
				{
					return this.m_owner.m_curTrainingRoom;
				}
				set
				{
					this.m_owner.m_curTrainingRoom = value;
				}
			}

			// Token: 0x17002BA9 RID: 11177
			// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x003C93EC File Offset: 0x003C75EC
			// (set) Token: 0x0600E0A9 RID: 57513 RVA: 0x003C93FC File Offset: 0x003C75FC
			public List<AssistanceTeamUIController> m_assistanceTeamUICtrlList
			{
				get
				{
					return this.m_owner.m_assistanceTeamUICtrlList;
				}
				set
				{
					this.m_owner.m_assistanceTeamUICtrlList = value;
				}
			}

			// Token: 0x17002BAA RID: 11178
			// (get) Token: 0x0600E0AA RID: 57514 RVA: 0x003C940C File Offset: 0x003C760C
			// (set) Token: 0x0600E0AB RID: 57515 RVA: 0x003C941C File Offset: 0x003C761C
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

			// Token: 0x17002BAB RID: 11179
			// (get) Token: 0x0600E0AC RID: 57516 RVA: 0x003C942C File Offset: 0x003C762C
			// (set) Token: 0x0600E0AD RID: 57517 RVA: 0x003C943C File Offset: 0x003C763C
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

			// Token: 0x17002BAC RID: 11180
			// (get) Token: 0x0600E0AE RID: 57518 RVA: 0x003C944C File Offset: 0x003C764C
			// (set) Token: 0x0600E0AF RID: 57519 RVA: 0x003C945C File Offset: 0x003C765C
			public int[] m_buffPropArr
			{
				get
				{
					return this.m_owner.m_buffPropArr;
				}
				set
				{
					this.m_owner.m_buffPropArr = value;
				}
			}

			// Token: 0x17002BAD RID: 11181
			// (get) Token: 0x0600E0B0 RID: 57520 RVA: 0x003C946C File Offset: 0x003C766C
			// (set) Token: 0x0600E0B1 RID: 57521 RVA: 0x003C947C File Offset: 0x003C767C
			public HeroCharUIController m_heroCharUIController
			{
				get
				{
					return this.m_owner.m_heroCharUIController;
				}
				set
				{
					this.m_owner.m_heroCharUIController = value;
				}
			}

			// Token: 0x17002BAE RID: 11182
			// (get) Token: 0x0600E0B2 RID: 57522 RVA: 0x003C948C File Offset: 0x003C768C
			// (set) Token: 0x0600E0B3 RID: 57523 RVA: 0x003C949C File Offset: 0x003C769C
			public AssistanceTeamUIController m_stopHeroAssistantsTaskCtrl
			{
				get
				{
					return this.m_owner.m_stopHeroAssistantsTaskCtrl;
				}
				set
				{
					this.m_owner.m_stopHeroAssistantsTaskCtrl = value;
				}
			}

			// Token: 0x17002BAF RID: 11183
			// (get) Token: 0x0600E0B4 RID: 57524 RVA: 0x003C94AC File Offset: 0x003C76AC
			// (set) Token: 0x0600E0B5 RID: 57525 RVA: 0x003C94BC File Offset: 0x003C76BC
			public List<CommonUIStateController> propStateCtrlList
			{
				get
				{
					return this.m_owner.propStateCtrlList;
				}
				set
				{
					this.m_owner.propStateCtrlList = value;
				}
			}

			// Token: 0x17002BB0 RID: 11184
			// (get) Token: 0x0600E0B6 RID: 57526 RVA: 0x003C94CC File Offset: 0x003C76CC
			// (set) Token: 0x0600E0B7 RID: 57527 RVA: 0x003C94DC File Offset: 0x003C76DC
			public List<Text> propGoList
			{
				get
				{
					return this.m_owner.propGoList;
				}
				set
				{
					this.m_owner.propGoList = value;
				}
			}

			// Token: 0x0600E0B8 RID: 57528 RVA: 0x003C94EC File Offset: 0x003C76EC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E0B9 RID: 57529 RVA: 0x003C94FC File Offset: 0x003C76FC
			public void SetTrainingDetailPanel(TrainingRoom room)
			{
				this.m_owner.SetTrainingDetailPanel(room);
			}

			// Token: 0x0600E0BA RID: 57530 RVA: 0x003C950C File Offset: 0x003C770C
			public void OnCourseItemClick(CourseItemUIController ctrl)
			{
				this.m_owner.OnCourseItemClick(ctrl);
			}

			// Token: 0x0600E0BB RID: 57531 RVA: 0x003C951C File Offset: 0x003C771C
			public void OnRoomToggleClick(DrillRoomToggleUIController ctrl)
			{
				this.m_owner.OnRoomToggleClick(ctrl);
			}

			// Token: 0x0600E0BC RID: 57532 RVA: 0x003C952C File Offset: 0x003C772C
			public void SetPropertyAddition()
			{
				this.m_owner.SetPropertyAddition();
			}

			// Token: 0x0600E0BD RID: 57533 RVA: 0x003C953C File Offset: 0x003C773C
			public void ResetAllPropertyState()
			{
				this.m_owner.ResetAllPropertyState();
			}

			// Token: 0x0600E0BE RID: 57534 RVA: 0x003C954C File Offset: 0x003C774C
			public void CalcSoldierPropertyModifityAddtion(PropertyModifyType type, int value)
			{
				this.m_owner.CalcSoldierPropertyModifityAddtion(type, value);
			}

			// Token: 0x0600E0BF RID: 57535 RVA: 0x003C955C File Offset: 0x003C775C
			public void SetTeachingDetailPanel()
			{
				this.m_owner.SetTeachingDetailPanel();
			}

			// Token: 0x0600E0C0 RID: 57536 RVA: 0x003C956C File Offset: 0x003C776C
			public void OnAssistanceTeamTrainingButtonClick(int slot)
			{
				this.m_owner.OnAssistanceTeamTrainingButtonClick(slot);
			}

			// Token: 0x0600E0C1 RID: 57537 RVA: 0x003C957C File Offset: 0x003C777C
			public void OnAssistanceTeamStopButtonClick(AssistanceTeamUIController ctrl)
			{
				this.m_owner.OnAssistanceTeamStopButtonClick(ctrl);
			}

			// Token: 0x0600E0C2 RID: 57538 RVA: 0x003C958C File Offset: 0x003C778C
			public void OpenStopTeachingPanel()
			{
				this.m_owner.OpenStopTeachingPanel();
			}

			// Token: 0x0600E0C3 RID: 57539 RVA: 0x003C959C File Offset: 0x003C779C
			public void CloseStopTeachingPanel()
			{
				this.m_owner.CloseStopTeachingPanel();
			}

			// Token: 0x0600E0C4 RID: 57540 RVA: 0x003C95AC File Offset: 0x003C77AC
			public void OnStopTeachingPanelConfirmButtonClick()
			{
				this.m_owner.OnStopTeachingPanelConfirmButtonClick();
			}

			// Token: 0x0600E0C5 RID: 57541 RVA: 0x003C95BC File Offset: 0x003C77BC
			public void OnAssistanceTeamGetRewardButtonClick(AssistanceTeamUIController ctrl)
			{
				this.m_owner.OnAssistanceTeamGetRewardButtonClick(ctrl);
			}

			// Token: 0x0600E0C6 RID: 57542 RVA: 0x003C95CC File Offset: 0x003C77CC
			public void OnTrainingButtonClick()
			{
				this.m_owner.OnTrainingButtonClick();
			}

			// Token: 0x0600E0C7 RID: 57543 RVA: 0x003C95DC File Offset: 0x003C77DC
			public void OnSoldierInfoButtonClick()
			{
				this.m_owner.OnSoldierInfoButtonClick();
			}

			// Token: 0x0600E0C8 RID: 57544 RVA: 0x003C95EC File Offset: 0x003C77EC
			public void OnTrainingToggleValueChanged(bool isOn)
			{
				this.m_owner.OnTrainingToggleValueChanged(isOn);
			}

			// Token: 0x0600E0C9 RID: 57545 RVA: 0x003C95FC File Offset: 0x003C77FC
			public void OnTeachingToggleValueChanged(bool isOn)
			{
				this.m_owner.OnTeachingToggleValueChanged(isOn);
			}

			// Token: 0x0600E0CA RID: 57546 RVA: 0x003C960C File Offset: 0x003C780C
			public void OnFastMaxButtonClick()
			{
				this.m_owner.OnFastMaxButtonClick();
			}

			// Token: 0x0600E0CB RID: 57547 RVA: 0x003C961C File Offset: 0x003C781C
			public void ClearDataCache()
			{
				this.m_owner.ClearDataCache();
			}

			// Token: 0x0600E0CC RID: 57548 RVA: 0x003C962C File Offset: 0x003C782C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600E0CD RID: 57549 RVA: 0x003C963C File Offset: 0x003C783C
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x04008892 RID: 34962
			private DrillUIController m_owner;
		}
	}
}
