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
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C43 RID: 3139
	[HotFix]
	public class DrillTrainingUIController : UIControllerBase
	{
		// Token: 0x0600DD13 RID: 56595 RVA: 0x003BD404 File Offset: 0x003BB604
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
			this.m_crystalAddButton.onClick.AddListener(new UnityAction(this.OnCrystalAddButtonClick));
			this.m_goldAddButton.onClick.AddListener(new UnityAction(this.OnGoldAddButtonClick));
			this.m_skillItemInfoPanelBGButton.onClick.AddListener(new UnityAction(this.OnSkillItemInfoPanelBGButtonClick));
			this.m_skillItemInfoPanelCloseButton.onClick.AddListener(new UnityAction(this.OnSkillItemInfoPanelBGButtonClick));
			this.m_skillItemInfoPanelFastMaxButton.onClick.AddListener(new UnityAction(this.OnSkillItemInfoPanelFastMaxButtonClick));
			this.m_skillItemInfoPanelFastLevelButton.onClick.AddListener(new UnityAction(this.OnSkillItemInfoPanelFastLevelButtonClick));
			this.m_soldierAndSkillInfoPanelPromoteButton.onClick.AddListener(new UnityAction(this.OnInfoPanelPromoteButtonClick));
			this.m_soldierAndSkillInfoPanelWatchDetailButton.onClick.AddListener(new UnityAction(this.OnShowSoldierDetailButtonClick));
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600DD14 RID: 56596 RVA: 0x003BD590 File Offset: 0x003BB790
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

		// Token: 0x0600DD15 RID: 56597 RVA: 0x003BD60C File Offset: 0x003BB80C
		public void UpdateViewInDrillTraining(int courseId, int techId = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInDrillTrainingInt32Int32_hotfix != null)
			{
				this.m_UpdateViewInDrillTrainingInt32Int32_hotfix.call(new object[]
				{
					this,
					courseId2,
					techId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int courseId = courseId2;
			if (this.m_isFirstIn)
			{
				this.Open();
				this.m_isFirstIn = false;
			}
			this.m_crystalText.text = this.m_playerContext.GetCrystal().ToString();
			this.m_goldText.text = this.m_playerContext.GetGold().ToString();
			ConfigDataTrainingCourseInfo configDataTrainingCourseInfo = this.m_configDataLoader.GetConfigDataTrainingCourseInfo(courseId);
			this.m_curTrainingRoom = this.m_playerContext.GetTrainingRoomById(configDataTrainingCourseInfo.RoomID);
			if (this.m_curTrainingRoom == null)
			{
				return;
			}
			this.m_trainingNameText.text = this.m_curTrainingRoom.Config.Name;
			this.m_curTrainingCourse = this.m_curTrainingRoom.Courses.Find((TrainingCourse c) => c.ConfigId == courseId);
			this.SetRoomCoachInfoPanel();
			this.SetCoursesListPanel();
			this.SetSkillPanel();
			if (this.m_skillItemInfoPanelStateCtrl.gameObject.activeSelf)
			{
				this.SetSkillItemInfoPanel(this.m_curTrainingSkillItemCtrl);
			}
			if (techId != 0)
			{
				this.ShowTechClickPanelByTechId(techId);
			}
		}

		// Token: 0x0600DD16 RID: 56598 RVA: 0x003BD7AC File Offset: 0x003BB9AC
		private void ShowTechClickPanelByTechId(int techId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTechClickPanelByTechIdInt32_hotfix != null)
			{
				this.m_ShowTechClickPanelByTechIdInt32_hotfix.call(new object[]
				{
					this,
					techId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int techId = techId2;
			TrainingSkillItemUIController trainingSkillItemUIController = this.m_trainingSkillItemUICtrlList.Find((TrainingSkillItemUIController c) => c.TrainingTech.ConfigId == techId);
			if (trainingSkillItemUIController == null)
			{
				return;
			}
			this.OnTrainingSkillItemClick(trainingSkillItemUIController);
		}

		// Token: 0x0600DD17 RID: 56599 RVA: 0x003BD858 File Offset: 0x003BBA58
		private void SetRoomCoachInfoPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRoomCoachInfoPanel_hotfix != null)
			{
				this.m_SetRoomCoachInfoPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_roomInfoImageStateCtrl.SetToUIState(this.m_curTrainingRoom.ConfigId.ToString(), false, true);
			this.m_roomInfoLvValueText.text = this.m_curTrainingRoom.Level.ToString();
			int num = 0;
			ConfigDataTrainingRoomLevelInfo configDataTrainingRoomLevelInfo = null;
			foreach (KeyValuePair<int, ConfigDataTrainingRoomLevelInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataTrainingRoomLevelInfo())
			{
				if (keyValuePair.Value.CurrentLevel == this.m_curTrainingRoom.Level)
				{
					configDataTrainingRoomLevelInfo = keyValuePair.Value;
					break;
				}
			}
			if (configDataTrainingRoomLevelInfo != null)
			{
				num = configDataTrainingRoomLevelInfo.ExpToNextLevel;
			}
			this.m_roomInfoExpValueText.text = this.m_curTrainingRoom.Exp + "/" + num;
			if (num != 0)
			{
				this.m_roomInfoProgressBar.fillAmount = (float)this.m_curTrainingRoom.Exp / (float)num;
			}
			else
			{
				this.m_roomInfoProgressBar.fillAmount = 0f;
			}
		}

		// Token: 0x0600DD18 RID: 56600 RVA: 0x003BD9EC File Offset: 0x003BBBEC
		private void SetCoursesListPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCoursesListPanel_hotfix != null)
			{
				this.m_SetCoursesListPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<TrainingCourse> courses = this.m_curTrainingRoom.Courses;
			GameObjectUtility.DestroyChildren(this.m_trainingCourseScrollViewContent);
			foreach (TrainingCourse trainingCourse in courses)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("CourseItem");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				CourseItemUIController component = gameObject.GetComponent<CourseItemUIController>();
				component.InitCourseInfo(trainingCourse);
				component.EventOnCourseItemClick += this.OnCourseItemClick;
				gameObject.transform.SetParent(this.m_trainingCourseScrollViewContent.transform, false);
				if (trainingCourse == this.m_curTrainingCourse)
				{
					component.ShowSelectFrame(true);
					this.m_lastCourseItemCtrl = component;
				}
			}
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x003BDB1C File Offset: 0x003BBD1C
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
			if (this.m_lastCourseItemCtrl != null)
			{
				this.m_lastCourseItemCtrl.ShowSelectFrame(false);
			}
			this.m_lastCourseItemCtrl = ctrl;
			ctrl.ShowSelectFrame(true);
			this.m_curTrainingCourse = ctrl.m_trainingCourse;
			this.SetSkillPanel();
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x003BDBCC File Offset: 0x003BBDCC
		private void SetSkillPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillPanel_hotfix != null)
			{
				this.m_SetSkillPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curTrainingCourse == null)
			{
				return;
			}
			List<TrainingTech> techs = this.m_curTrainingCourse.Techs;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>(this.m_curTrainingCourse.Config.SkillTreeName);
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			GameObjectUtility.DestroyChildren(this.m_skillPanelGameObject);
			gameObject.transform.SetParent(this.m_skillPanelGameObject.transform, false);
			GameObject gameObject2 = null;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				Transform child = gameObject.transform.GetChild(i);
				if (child.name == "SkillItemGroup")
				{
					gameObject2 = child.gameObject;
				}
			}
			int childCount = gameObject2.transform.childCount;
			int num = (techs.Count > childCount) ? childCount : techs.Count;
			this.m_trainingSkillItemUICtrlList.Clear();
			for (int j = 0; j < num; j++)
			{
				Transform child2 = gameObject2.transform.GetChild(j);
				if (child2.childCount == 0)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.m_skillItemPrefab);
					TrainingSkillItemUIController trainingSkillItemUIController = GameObjectUtility.AddControllerToGameObject<TrainingSkillItemUIController>(gameObject3);
					trainingSkillItemUIController.InitTrainingSkillItemInfo(techs[j]);
					trainingSkillItemUIController.EventOnTrainingSkillItemClick += this.OnTrainingSkillItemClick;
					gameObject3.transform.SetParent(child2.transform, false);
					this.m_trainingSkillItemUICtrlList.Add(trainingSkillItemUIController);
				}
				else
				{
					Transform child3 = child2.GetChild(0);
					TrainingSkillItemUIController component = child3.GetComponent<TrainingSkillItemUIController>();
					component.InitTrainingSkillItemInfo(techs[j]);
					this.m_trainingSkillItemUICtrlList.Add(component);
				}
			}
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x003BDDC8 File Offset: 0x003BBFC8
		private void OnTrainingSkillItemClick(TrainingSkillItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingSkillItemClickTrainingSkillItemUIController_hotfix != null)
			{
				this.m_OnTrainingSkillItemClickTrainingSkillItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curTrainingSkillItemCtrl = ctrl;
			this.SetSkillItemInfoPanel(ctrl);
			this.m_skillItemInfoPanelStateCtrl.gameObject.SetActive(true);
			this.m_skillItemInfoPanelStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x003BDE6C File Offset: 0x003BC06C
		private void SetSkillItemInfoPanel(TrainingSkillItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillItemInfoPanelTrainingSkillItemUIController_hotfix != null)
			{
				this.m_SetSkillItemInfoPanelTrainingSkillItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DrillTrainingUIController.<SetSkillItemInfoPanel>c__AnonStorey2 <SetSkillItemInfoPanel>c__AnonStorey = new DrillTrainingUIController.<SetSkillItemInfoPanel>c__AnonStorey2();
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_skillItemInfoPanelFastMaxButton.gameObject.SetActive(data.IsDeveloper);
			TrainingTech trainingTech = ctrl.TrainingTech;
			int techMaxLv = ctrl.TechMaxLv;
			string text;
			if (trainingTech.Level > 0)
			{
				text = trainingTech.Level + "/" + techMaxLv;
			}
			else
			{
				text = "1/" + techMaxLv;
			}
			string text2 = null;
			if (trainingTech.Level < techMaxLv)
			{
				text2 = trainingTech.Level + 1 + "/" + techMaxLv;
			}
			this.m_soldierAndSkillInfoPanelNowLvValueText.text = text;
			this.m_soldierAndSkillInfoPanelIntensifyLvValueText.text = text;
			this.m_soldierAndSkillInfoPanelAfterIntensifyLvValueText.text = text2;
			string description;
			if (trainingTech.Level > 0)
			{
				description = trainingTech.Infos[trainingTech.Level - 1].Config.Description;
			}
			else
			{
				description = trainingTech.Infos[0].Config.Description;
			}
			string text3 = null;
			if (trainingTech.Level < techMaxLv)
			{
				text3 = trainingTech.Infos[trainingTech.Level].Config.Description;
			}
			this.m_soldierAndSkillInfoPanelNowEffectText.text = description;
			this.m_soldierAndSkillInfoPanelIntensifyNowEffectText.text = description;
			this.m_soldierAndSkillInfoPanelAfterIntensifyEffectText.text = text3;
			if (trainingTech.Config.TechType == TechDisplayType.TechDisplayType_SoldierLevelUp)
			{
				if (trainingTech.Level < techMaxLv)
				{
					if (trainingTech.Level == 0)
					{
						this.m_soldierAndSkillInfoPanelStateCtrl.SetToUIState("SoldierNowEffect", false, true);
					}
					else
					{
						this.m_soldierAndSkillInfoPanelStateCtrl.SetToUIState("SoldierIntensify", false, true);
					}
				}
				else
				{
					this.m_soldierAndSkillInfoPanelStateCtrl.SetToUIState("SoldierMaxEffect", false, true);
				}
				ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(trainingTech.Config.SoldierIDRelated[0]);
				this.SetSoldierDetailPanel(configDataSoldierInfo);
				if (configDataSoldierInfo != null)
				{
					float scale = (float)configDataSoldierInfo.UI_ModelScale * 0.018f;
					Vector2 offset = new Vector2((float)configDataSoldierInfo.UI_ModelOffsetX, (float)configDataSoldierInfo.UI_ModelOffsetY) * 1.5f;
					HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierInfoGraphic, configDataSoldierInfo.Model, this.m_soldierAndSkillInfoSoldierGraphic, 1, offset, scale, configDataSoldierInfo.ReplaceAnims);
					this.m_soldierAndSkillInfoSoldierNameText.text = configDataSoldierInfo.Name;
				}
			}
			else
			{
				if (trainingTech.Level < techMaxLv)
				{
					if (trainingTech.Level == 0)
					{
						this.m_soldierAndSkillInfoPanelStateCtrl.SetToUIState("SkillNowEffect", false, true);
					}
					else
					{
						this.m_soldierAndSkillInfoPanelStateCtrl.SetToUIState("SkillIntensify", false, true);
					}
				}
				else
				{
					this.m_soldierAndSkillInfoPanelStateCtrl.SetToUIState("SkillMaxEffect", false, true);
				}
				this.m_soldierAndSkillInfoSkillIconImage.sprite = AssetUtility.Instance.GetSprite(trainingTech.Config.Resource);
				this.m_soldierAndSkillInfoSkillNameText.text = trainingTech.Config.Name;
				this.m_soldierAndSkillInfoSkillUpdateEffectGroup.SetActive(false);
			}
			this.m_soldierAndSkillInfoPanelWatchDetailButton.gameObject.SetActive(trainingTech.Config.TechType == TechDisplayType.TechDisplayType_SoldierLevelUp);
			if (trainingTech.Level >= techMaxLv)
			{
				return;
			}
			ConfigDataTrainingTechLevelInfo config = trainingTech.Infos[trainingTech.Level].Config;
			List<Goods> levelupMaterialsCost = config.LevelupMaterialsCost;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_soldierAndSkillInfoPanelItemGroup, levelupMaterialsCost.Count);
			Transform transform = this.m_soldierAndSkillInfoPanelItemGroup.transform;
			for (int j = 0; j < levelupMaterialsCost.Count; j++)
			{
				Goods goods = levelupMaterialsCost[j];
				Transform child = transform.GetChild(j);
				TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = child.GetComponent<TrainingSkillEvolutionMaterialUIController>();
				if (trainingSkillEvolutionMaterialUIController == null)
				{
					trainingSkillEvolutionMaterialUIController = GameObjectUtility.AddControllerToGameObject<TrainingSkillEvolutionMaterialUIController>(child.gameObject);
					trainingSkillEvolutionMaterialUIController.EventOnClick += this.OnEvolutionMaterialClick;
				}
				trainingSkillEvolutionMaterialUIController.InitTrainingSkillEvolutionMaterial(goods.GoodsType, goods.Id, goods.Count);
			}
			bool flag = this.m_playerContext.CanTechLevelup(trainingTech.ConfigId) == 0;
			if (flag)
			{
				this.m_soldierAndSkillInfoPanelPromoteButtonStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_soldierAndSkillInfoPanelPromoteButtonStateCtrl.SetToUIState("Grey", false, true);
			}
			this.m_soldierAndSkillInfoPanelGoldenValueText.text = config.LevelupGoldCost.ToString();
			if (config.LevelupGoldCost <= this.m_playerContext.GetGold())
			{
				this.m_soldierAndSkillInfoPanelGoldenStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_soldierAndSkillInfoPanelGoldenStateCtrl.SetToUIState("Red", false, true);
			}
			<SetSkillItemInfoPanel>c__AnonStorey.preTechIds = new List<int>(trainingTech.Config.PreTechIDs);
			List<int> list = new List<int>(trainingTech.Config.PreTechLevel);
			int num = trainingTech.Config.RoomLevelRequired;
			if (trainingTech.Level != 0)
			{
				<SetSkillItemInfoPanel>c__AnonStorey.preTechIds.Clear();
				list.Clear();
				num = 0;
			}
			int num2 = <SetSkillItemInfoPanel>c__AnonStorey.preTechIds.Count + ((num == 0) ? 0 : 1);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_soldierAndSkillInfoPanelConditionGroup, num2);
			Transform transform2 = this.m_soldierAndSkillInfoPanelConditionGroup.transform;
			int i;
			for (i = 0; i < <SetSkillItemInfoPanel>c__AnonStorey.preTechIds.Count; i++)
			{
				Transform child2 = transform2.GetChild(i);
				Text component = child2.GetChild(2).GetComponent<Text>();
				TrainingTech trainingTech2 = this.m_curTrainingCourse.Techs.Find((TrainingTech t) => t.ConfigId == <SetSkillItemInfoPanel>c__AnonStorey.preTechIds[i]);
				component.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_TrainingNeedLevel), trainingTech2.Config.Name, list[i]);
				CommonUIStateController component2 = child2.GetComponent<CommonUIStateController>();
				if (trainingTech2.Level >= list[i])
				{
					component2.SetToUIState("Unlock", false, true);
				}
				else
				{
					component2.SetToUIState("Lock", false, true);
				}
			}
			if (num != 0)
			{
				Transform child3 = transform2.GetChild(<SetSkillItemInfoPanel>c__AnonStorey.preTechIds.Count);
				Text component3 = child3.GetChild(2).GetComponent<Text>();
				int trainingRoomIdByTechId = this.m_playerContext.GetTrainingRoomIdByTechId(trainingTech.ConfigId);
				ConfigDataTrainingRoomInfo configDataTrainingRoomInfo = this.m_configDataLoader.GetConfigDataTrainingRoomInfo(trainingRoomIdByTechId);
				TrainingRoom trainingRoomById = this.m_playerContext.GetTrainingRoomById(trainingRoomIdByTechId);
				component3.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_TrainingNeedLevel), configDataTrainingRoomInfo.Name, num);
				CommonUIStateController component4 = child3.GetComponent<CommonUIStateController>();
				if (trainingRoomById.Level >= num)
				{
					component4.SetToUIState("Unlock", false, true);
				}
				else
				{
					component4.SetToUIState("Lock", false, true);
				}
			}
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x003BE5C0 File Offset: 0x003BC7C0
		private void OnEvolutionMaterialClick(GoodsType goodsType, int id, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					id,
					needCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnEvolutionMaterialClick != null)
			{
				this.EventOnEvolutionMaterialClick(goodsType, id, needCount);
			}
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x003BE66C File Offset: 0x003BC86C
		private void SetSoldierDetailPanel(ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierDetailPanelConfigDataSoldierInfo_hotfix != null)
			{
				this.m_SetSoldierDetailPanelConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null)
			{
				CommonUIController.Instance.ShowMessage("Soldier is null", 2f, null, true);
				return;
			}
			this.m_soldierDetailPanelSoldierTypeIcon.sprite = AssetUtility.Instance.GetSprite(soldierInfo.m_armyInfo.Icon);
			this.m_soldierDetailPanelSoldierQualityIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetSoldierRankImage(soldierInfo.Rank));
			this.m_soldierDetailPanelSoldierNameText.text = soldierInfo.Name;
			this.m_soldierDetailPanelPorpretyGroupHPValueText.text = soldierInfo.HP_INI.ToString();
			this.m_soldierDetailPanelPorpretyGroupATValueText.text = soldierInfo.AT_INI.ToString();
			this.m_soldierDetailPanelPorpretyGroupDFValueText.text = soldierInfo.DF_INI.ToString();
			this.m_soldierDetailPanelPorpretyGroupMagicDFValueText.text = soldierInfo.MagicDF_INI.ToString();
			this.m_soldierDetailPanelPorpretyGroupRangeValueText.text = soldierInfo.BF_AttackDistance.ToString();
			this.m_soldierDetailPanelPorpretyGroupMoveValueText.text = soldierInfo.BF_MovePoint.ToString();
			this.m_soldierDetailPanelPorpretyGroupRestrainValueText.text = soldierInfo.Strong;
			this.m_soldierDetailPanelPorpretyGroupWeakValueText.text = soldierInfo.Weak;
			this.m_soldierDetailPanelPorpretyGroupDescText.text = soldierInfo.Desc;
			if (soldierInfo.IsMelee)
			{
				this.m_soldierDetailPanelPorpretyGroupTypeStateCtrl.SetToUIState("Melee", false, true);
			}
			else
			{
				this.m_soldierDetailPanelPorpretyGroupTypeStateCtrl.SetToUIState("NotMelee", false, true);
			}
			List<int> list = new List<int>(soldierInfo.GetSoldierHeros_ID);
			if (list.Count > 0)
			{
				this.m_soldierDetailPanelHeroListStateCtrl.SetToUIState("Have", false, true);
			}
			else
			{
				this.m_soldierDetailPanelHeroListStateCtrl.SetToUIState("None", false, true);
			}
			Transform transform = this.m_soldierDetailPanelHeroListContent.transform;
			if (list.Count >= transform.childCount)
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_soldierDetailPanelHeroListContent, transform.childCount);
				for (int i = 0; i < list.Count; i++)
				{
					ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(list[i]);
					if (i < transform.childCount)
					{
						Image component = transform.GetChild(i).GetComponent<Image>();
						component.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo.m_charImageInfo.SummonHeadImage);
					}
					else
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(transform.GetChild(0).gameObject);
						Image component2 = gameObject.GetComponent<Image>();
						component2.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo.m_charImageInfo.SummonHeadImage);
						gameObject.transform.SetParent(this.m_soldierDetailPanelHeroListContent.transform, false);
					}
				}
			}
			else
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_soldierDetailPanelHeroListContent, list.Count);
				for (int j = 0; j < list.Count; j++)
				{
					ConfigDataHeroInfo configDataHeroInfo2 = this.m_configDataLoader.GetConfigDataHeroInfo(list[j]);
					Image component3 = transform.GetChild(j).GetComponent<Image>();
					component3.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo2.m_charImageInfo.SummonHeadImage);
				}
			}
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x003BEA1C File Offset: 0x003BCC1C
		private void OnInfoPanelPromoteButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoPanelPromoteButtonClick_hotfix != null)
			{
				this.m_OnInfoPanelPromoteButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int configId = this.m_curTrainingSkillItemCtrl.TrainingTech.ConfigId;
			int num = this.m_playerContext.CanTechLevelup(configId);
			if (num == 0)
			{
				if (this.EventOnTechLevelup != null)
				{
					this.EventOnTechLevelup(configId, delegate
					{
						this.m_soldierAndSkillInfoSkillUpdateEffectGroup.SetActive(true);
						this.m_enhanceSuccessEffectPanelStateCtrl.gameObject.SetActive(true);
						UIUtility.SetUIStateOpen(this.m_enhanceSuccessEffectPanelStateCtrl, "Show", delegate
						{
							this.m_enhanceSuccessEffectPanelStateCtrl.gameObject.SetActive(false);
						}, true, true);
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x003BEADC File Offset: 0x003BCCDC
		private void OnShowSoldierDetailButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowSoldierDetailButtonClick_hotfix != null)
			{
				this.m_OnShowSoldierDetailButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_infoPanelDetailStateCtrl.GetCurrentUIState();
			if (currentUIState == null || currentUIState.StateName == "Right")
			{
				this.m_soldierDetailPanel.SetActive(true);
				this.m_soldierDetailPanelStateCtrl.SetToUIState("Show", false, true);
				this.m_infoPanelDetailStateCtrl.SetToUIState("Left", false, true);
			}
			else
			{
				this.m_infoPanelDetailStateCtrl.SetToUIState("Right", false, true);
				this.m_soldierDetailPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
				{
					this.m_soldierDetailPanel.SetActive(false);
				});
				this.m_soldierDetailPanelStateCtrl.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x003BEBDC File Offset: 0x003BCDDC
		private void OnSkillItemInfoPanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemInfoPanelBGButtonClick_hotfix != null)
			{
				this.m_OnSkillItemInfoPanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_infoPanelDetailStateCtrl.GetCurrentUIState();
			if (currentUIState == null || currentUIState.StateName == "Right")
			{
				this.m_skillItemInfoPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
				{
					this.m_skillItemInfoPanelStateCtrl.gameObject.SetActive(false);
				});
				this.m_skillItemInfoPanelStateCtrl.SetToUIState("Close", false, true);
			}
			else
			{
				this.m_skillItemInfoPanelStateCtrl.SetActionForUIStateFinshed("CloseWithDetail", delegate
				{
					this.m_infoPanelDetailStateCtrl.SetToUIState("Right", false, true);
					this.m_soldierDetailPanel.SetActive(false);
					this.m_skillItemInfoPanelStateCtrl.gameObject.SetActive(false);
				});
				this.m_skillItemInfoPanelStateCtrl.SetToUIState("CloseWithDetail", false, true);
			}
			this.m_soldierAndSkillInfoSkillUpdateEffectGroup.SetActive(false);
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x003BECD4 File Offset: 0x003BCED4
		private void OnGoldAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGoldAddButtonClick_hotfix != null)
			{
				this.m_OnGoldAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddGold != null)
			{
				this.EventOnAddGold();
			}
		}

		// Token: 0x0600DD23 RID: 56611 RVA: 0x003BED4C File Offset: 0x003BCF4C
		private void OnCrystalAddButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCrystalAddButtonClick_hotfix != null)
			{
				this.m_OnCrystalAddButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddCrystal != null)
			{
				this.EventOnAddCrystal();
			}
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x003BEDC4 File Offset: 0x003BCFC4
		private void OnSkillItemInfoPanelFastMaxButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemInfoPanelFastMaxButtonClick_hotfix != null)
			{
				this.m_OnSkillItemInfoPanelFastMaxButtonClick_hotfix.call(new object[]
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
			string cmd = string.Concat(new object[]
			{
				"SET_MAXTRAININGTECHS ",
				this.m_curTrainingRoom.ConfigId,
				";",
				this.m_curTrainingSkillItemCtrl.TrainingTech.ConfigId,
				";-1"
			});
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateViewInDrillTraining(this.m_curTrainingCourse.ConfigId, this.m_curTrainingSkillItemCtrl.TrainingTech.ConfigId);
					CommonUIController.Instance.ShowTip("退出练兵场后需要重启!");
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600DD25 RID: 56613 RVA: 0x003BEEA0 File Offset: 0x003BD0A0
		private void OnSkillItemInfoPanelFastLevelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemInfoPanelFastLevelButtonClick_hotfix != null)
			{
				this.m_OnSkillItemInfoPanelFastLevelButtonClick_hotfix.call(new object[]
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
			int num = 0;
			string text = this.m_skillItemInfoPanelFastLevelInputField.text;
			if (string.IsNullOrEmpty(text) || !int.TryParse(text, out num))
			{
				return;
			}
			string cmd = string.Concat(new object[]
			{
				"SET_MAXTRAININGTECHS ",
				this.m_curTrainingRoom.ConfigId,
				";",
				this.m_curTrainingSkillItemCtrl.TrainingTech.ConfigId,
				";",
				num
			});
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateViewInDrillTraining(this.m_curTrainingCourse.ConfigId, this.m_curTrainingSkillItemCtrl.TrainingTech.ConfigId);
					CommonUIController.Instance.ShowTip("退出练兵场后需要重启!");
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600DD26 RID: 56614 RVA: 0x003BEFAC File Offset: 0x003BD1AC
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
			this.m_curTrainingCourse = null;
			this.m_curTrainingRoom = null;
			this.m_isFirstIn = true;
		}

		// Token: 0x140002BD RID: 701
		// (add) Token: 0x0600DD27 RID: 56615 RVA: 0x003BF038 File Offset: 0x003BD238
		// (remove) Token: 0x0600DD28 RID: 56616 RVA: 0x003BF0D4 File Offset: 0x003BD2D4
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

		// Token: 0x140002BE RID: 702
		// (add) Token: 0x0600DD29 RID: 56617 RVA: 0x003BF170 File Offset: 0x003BD370
		// (remove) Token: 0x0600DD2A RID: 56618 RVA: 0x003BF20C File Offset: 0x003BD40C
		public event Action EventOnAddGold
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddGoldAction_hotfix != null)
				{
					this.m_add_EventOnAddGoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddGold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddGold, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddGoldAction_hotfix != null)
				{
					this.m_remove_EventOnAddGoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddGold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddGold, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002BF RID: 703
		// (add) Token: 0x0600DD2B RID: 56619 RVA: 0x003BF2A8 File Offset: 0x003BD4A8
		// (remove) Token: 0x0600DD2C RID: 56620 RVA: 0x003BF344 File Offset: 0x003BD544
		public event Action EventOnAddCrystal
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddCrystalAction_hotfix != null)
				{
					this.m_add_EventOnAddCrystalAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddCrystal;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddCrystal, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddCrystalAction_hotfix != null)
				{
					this.m_remove_EventOnAddCrystalAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddCrystal;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddCrystal, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002C0 RID: 704
		// (add) Token: 0x0600DD2D RID: 56621 RVA: 0x003BF3E0 File Offset: 0x003BD5E0
		// (remove) Token: 0x0600DD2E RID: 56622 RVA: 0x003BF47C File Offset: 0x003BD67C
		public event Action<int, Action> EventOnTechLevelup
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTechLevelupAction`2_hotfix != null)
				{
					this.m_add_EventOnTechLevelupAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnTechLevelup;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnTechLevelup, (Action<int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTechLevelupAction`2_hotfix != null)
				{
					this.m_remove_EventOnTechLevelupAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnTechLevelup;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnTechLevelup, (Action<int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002C1 RID: 705
		// (add) Token: 0x0600DD2F RID: 56623 RVA: 0x003BF518 File Offset: 0x003BD718
		// (remove) Token: 0x0600DD30 RID: 56624 RVA: 0x003BF5B4 File Offset: 0x003BD7B4
		public event Action<GoodsType, int, int> EventOnEvolutionMaterialClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEvolutionMaterialClickAction`3_hotfix != null)
				{
					this.m_add_EventOnEvolutionMaterialClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnEvolutionMaterialClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnEvolutionMaterialClick, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEvolutionMaterialClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnEvolutionMaterialClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnEvolutionMaterialClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnEvolutionMaterialClick, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0600DD31 RID: 56625 RVA: 0x003BF650 File Offset: 0x003BD850
		// (set) Token: 0x0600DD32 RID: 56626 RVA: 0x003BF670 File Offset: 0x003BD870
		[DoNotToLua]
		public new DrillTrainingUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DrillTrainingUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DD33 RID: 56627 RVA: 0x003BF67C File Offset: 0x003BD87C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x003BF688 File Offset: 0x003BD888
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DD35 RID: 56629 RVA: 0x003BF690 File Offset: 0x003BD890
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DD36 RID: 56630 RVA: 0x003BF698 File Offset: 0x003BD898
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DD37 RID: 56631 RVA: 0x003BF6AC File Offset: 0x003BD8AC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DD38 RID: 56632 RVA: 0x003BF6B4 File Offset: 0x003BD8B4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x003BF6C0 File Offset: 0x003BD8C0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x003BF6CC File Offset: 0x003BD8CC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x003BF6D8 File Offset: 0x003BD8D8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DD3C RID: 56636 RVA: 0x003BF6E4 File Offset: 0x003BD8E4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DD3D RID: 56637 RVA: 0x003BF6F0 File Offset: 0x003BD8F0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DD3E RID: 56638 RVA: 0x003BF6FC File Offset: 0x003BD8FC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DD3F RID: 56639 RVA: 0x003BF708 File Offset: 0x003BD908
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DD40 RID: 56640 RVA: 0x003BF714 File Offset: 0x003BD914
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DD41 RID: 56641 RVA: 0x003BF720 File Offset: 0x003BD920
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DD42 RID: 56642 RVA: 0x003BF728 File Offset: 0x003BD928
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600DD43 RID: 56643 RVA: 0x003BF748 File Offset: 0x003BD948
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600DD44 RID: 56644 RVA: 0x003BF754 File Offset: 0x003BD954
		private void __callDele_EventOnAddGold()
		{
			Action eventOnAddGold = this.EventOnAddGold;
			if (eventOnAddGold != null)
			{
				eventOnAddGold();
			}
		}

		// Token: 0x0600DD45 RID: 56645 RVA: 0x003BF774 File Offset: 0x003BD974
		private void __clearDele_EventOnAddGold()
		{
			this.EventOnAddGold = null;
		}

		// Token: 0x0600DD46 RID: 56646 RVA: 0x003BF780 File Offset: 0x003BD980
		private void __callDele_EventOnAddCrystal()
		{
			Action eventOnAddCrystal = this.EventOnAddCrystal;
			if (eventOnAddCrystal != null)
			{
				eventOnAddCrystal();
			}
		}

		// Token: 0x0600DD47 RID: 56647 RVA: 0x003BF7A0 File Offset: 0x003BD9A0
		private void __clearDele_EventOnAddCrystal()
		{
			this.EventOnAddCrystal = null;
		}

		// Token: 0x0600DD48 RID: 56648 RVA: 0x003BF7AC File Offset: 0x003BD9AC
		private void __callDele_EventOnTechLevelup(int arg1, Action arg2)
		{
			Action<int, Action> eventOnTechLevelup = this.EventOnTechLevelup;
			if (eventOnTechLevelup != null)
			{
				eventOnTechLevelup(arg1, arg2);
			}
		}

		// Token: 0x0600DD49 RID: 56649 RVA: 0x003BF7D0 File Offset: 0x003BD9D0
		private void __clearDele_EventOnTechLevelup(int arg1, Action arg2)
		{
			this.EventOnTechLevelup = null;
		}

		// Token: 0x0600DD4A RID: 56650 RVA: 0x003BF7DC File Offset: 0x003BD9DC
		private void __callDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnEvolutionMaterialClick = this.EventOnEvolutionMaterialClick;
			if (eventOnEvolutionMaterialClick != null)
			{
				eventOnEvolutionMaterialClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600DD4B RID: 56651 RVA: 0x003BF800 File Offset: 0x003BDA00
		private void __clearDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnEvolutionMaterialClick = null;
		}

		// Token: 0x0600DD53 RID: 56659 RVA: 0x003BF990 File Offset: 0x003BDB90
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
					this.m_UpdateViewInDrillTrainingInt32Int32_hotfix = (luaObj.RawGet("UpdateViewInDrillTraining") as LuaFunction);
					this.m_ShowTechClickPanelByTechIdInt32_hotfix = (luaObj.RawGet("ShowTechClickPanelByTechId") as LuaFunction);
					this.m_SetRoomCoachInfoPanel_hotfix = (luaObj.RawGet("SetRoomCoachInfoPanel") as LuaFunction);
					this.m_SetCoursesListPanel_hotfix = (luaObj.RawGet("SetCoursesListPanel") as LuaFunction);
					this.m_OnCourseItemClickCourseItemUIController_hotfix = (luaObj.RawGet("OnCourseItemClick") as LuaFunction);
					this.m_SetSkillPanel_hotfix = (luaObj.RawGet("SetSkillPanel") as LuaFunction);
					this.m_OnTrainingSkillItemClickTrainingSkillItemUIController_hotfix = (luaObj.RawGet("OnTrainingSkillItemClick") as LuaFunction);
					this.m_SetSkillItemInfoPanelTrainingSkillItemUIController_hotfix = (luaObj.RawGet("SetSkillItemInfoPanel") as LuaFunction);
					this.m_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("OnEvolutionMaterialClick") as LuaFunction);
					this.m_SetSoldierDetailPanelConfigDataSoldierInfo_hotfix = (luaObj.RawGet("SetSoldierDetailPanel") as LuaFunction);
					this.m_OnInfoPanelPromoteButtonClick_hotfix = (luaObj.RawGet("OnInfoPanelPromoteButtonClick") as LuaFunction);
					this.m_OnShowSoldierDetailButtonClick_hotfix = (luaObj.RawGet("OnShowSoldierDetailButtonClick") as LuaFunction);
					this.m_OnSkillItemInfoPanelBGButtonClick_hotfix = (luaObj.RawGet("OnSkillItemInfoPanelBGButtonClick") as LuaFunction);
					this.m_OnGoldAddButtonClick_hotfix = (luaObj.RawGet("OnGoldAddButtonClick") as LuaFunction);
					this.m_OnCrystalAddButtonClick_hotfix = (luaObj.RawGet("OnCrystalAddButtonClick") as LuaFunction);
					this.m_OnSkillItemInfoPanelFastMaxButtonClick_hotfix = (luaObj.RawGet("OnSkillItemInfoPanelFastMaxButtonClick") as LuaFunction);
					this.m_OnSkillItemInfoPanelFastLevelButtonClick_hotfix = (luaObj.RawGet("OnSkillItemInfoPanelFastLevelButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnAddGoldAction_hotfix = (luaObj.RawGet("add_EventOnAddGold") as LuaFunction);
					this.m_remove_EventOnAddGoldAction_hotfix = (luaObj.RawGet("remove_EventOnAddGold") as LuaFunction);
					this.m_add_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("add_EventOnAddCrystal") as LuaFunction);
					this.m_remove_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("remove_EventOnAddCrystal") as LuaFunction);
					this.m_add_EventOnTechLevelupAction`2_hotfix = (luaObj.RawGet("add_EventOnTechLevelup") as LuaFunction);
					this.m_remove_EventOnTechLevelupAction`2_hotfix = (luaObj.RawGet("remove_EventOnTechLevelup") as LuaFunction);
					this.m_add_EventOnEvolutionMaterialClickAction`3_hotfix = (luaObj.RawGet("add_EventOnEvolutionMaterialClick") as LuaFunction);
					this.m_remove_EventOnEvolutionMaterialClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnEvolutionMaterialClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DD54 RID: 56660 RVA: 0x003BFD30 File Offset: 0x003BDF30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DrillTrainingUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400870D RID: 34573
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400870E RID: 34574
		[AutoBind("./PlayerResource/Crystal/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_crystalText;

		// Token: 0x0400870F RID: 34575
		[AutoBind("./PlayerResource/Crystal/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_crystalAddButton;

		// Token: 0x04008710 RID: 34576
		[AutoBind("./PlayerResource/Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldText;

		// Token: 0x04008711 RID: 34577
		[AutoBind("./PlayerResource/Gold/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goldAddButton;

		// Token: 0x04008712 RID: 34578
		[AutoBind("./TrainingNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trainingNameText;

		// Token: 0x04008713 RID: 34579
		[AutoBind("./TitleInfoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_roomInfoImageStateCtrl;

		// Token: 0x04008714 RID: 34580
		[AutoBind("./TitleInfoGroup/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_roomInfoLvValueText;

		// Token: 0x04008715 RID: 34581
		[AutoBind("./TitleInfoGroup/ExpValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_roomInfoExpValueText;

		// Token: 0x04008716 RID: 34582
		[AutoBind("./TitleInfoGroup/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_roomInfoProgressBar;

		// Token: 0x04008717 RID: 34583
		[AutoBind("./TrainingEventScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_trainingCourseScrollViewContent;

		// Token: 0x04008718 RID: 34584
		[AutoBind("./SkillPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillPanelGameObject;

		// Token: 0x04008719 RID: 34585
		[AutoBind("./Prefab/SkillItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillItemPrefab;

		// Token: 0x0400871A RID: 34586
		[AutoBind("./SkillItemInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillItemInfoPanelStateCtrl;

		// Token: 0x0400871B RID: 34587
		[AutoBind("./SkillItemInfoPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillItemInfoPanelBGButton;

		// Token: 0x0400871C RID: 34588
		[AutoBind("./SkillItemInfoPanel/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillItemInfoPanelCloseButton;

		// Token: 0x0400871D RID: 34589
		[AutoBind("./SkillItemInfoPanel/FastMaxButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillItemInfoPanelFastMaxButton;

		// Token: 0x0400871E RID: 34590
		[AutoBind("./SkillItemInfoPanel/FastMaxButton/FastLevelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillItemInfoPanelFastLevelButton;

		// Token: 0x0400871F RID: 34591
		[AutoBind("./SkillItemInfoPanel/FastMaxButton/FastLevelButton/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_skillItemInfoPanelFastLevelInputField;

		// Token: 0x04008720 RID: 34592
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDetailPanel;

		// Token: 0x04008721 RID: 34593
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierDetailPanelStateCtrl;

		// Token: 0x04008722 RID: 34594
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/TypeAndQuality/TypeIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierDetailPanelSoldierTypeIcon;

		// Token: 0x04008723 RID: 34595
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/TypeAndQuality/QualityIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierDetailPanelSoldierQualityIcon;

		// Token: 0x04008724 RID: 34596
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/TypeAndQuality/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelSoldierNameText;

		// Token: 0x04008725 RID: 34597
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupHPValueText;

		// Token: 0x04008726 RID: 34598
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupATValueText;

		// Token: 0x04008727 RID: 34599
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupDFValueText;

		// Token: 0x04008728 RID: 34600
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupMagicDFValueText;

		// Token: 0x04008729 RID: 34601
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/Range/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupRangeValueText;

		// Token: 0x0400872A RID: 34602
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/Move/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupMoveValueText;

		// Token: 0x0400872B RID: 34603
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/Restrain/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupRestrainValueText;

		// Token: 0x0400872C RID: 34604
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/Week/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupWeakValueText;

		// Token: 0x0400872D RID: 34605
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/PorpretyGroup/Type", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierDetailPanelPorpretyGroupTypeStateCtrl;

		// Token: 0x0400872E RID: 34606
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/SoldierDetail/Desc/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailPanelPorpretyGroupDescText;

		// Token: 0x0400872F RID: 34607
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/HeroList", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierDetailPanelHeroListStateCtrl;

		// Token: 0x04008730 RID: 34608
		[AutoBind("./SkillItemInfoPanel/SoldierDetailPanel/HeroList/HeroList/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDetailPanelHeroListContent;

		// Token: 0x04008731 RID: 34609
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/SkillAndSoldierShowPanel/SkillGroup/SkillIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierAndSkillInfoSkillIconImage;

		// Token: 0x04008732 RID: 34610
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/SkillAndSoldierShowPanel/SkillGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoSkillNameText;

		// Token: 0x04008733 RID: 34611
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/SkillAndSoldierShowPanel/SoldierGroup/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierAndSkillInfoSoldierGraphic;

		// Token: 0x04008734 RID: 34612
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/SkillAndSoldierShowPanel/SoldierGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoSoldierNameText;

		// Token: 0x04008735 RID: 34613
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/SkillAndSoldierShowPanel/SkillGroup/FrameImage/EffectGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierAndSkillInfoSkillUpdateEffectGroup;

		// Token: 0x04008736 RID: 34614
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierAndSkillInfoPanelStateCtrl;

		// Token: 0x04008737 RID: 34615
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/WatchDetailButton/WatchDetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierAndSkillInfoPanelWatchDetailButton;

		// Token: 0x04008738 RID: 34616
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/WatchDetailButton/WatchDetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_infoPanelDetailStateCtrl;

		// Token: 0x04008739 RID: 34617
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/NowEffectGroup/NowLvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelNowLvValueText;

		// Token: 0x0400873A RID: 34618
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/NowEffectGroup/NowEffectTextScroll/Mask/NowEffectText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelNowEffectText;

		// Token: 0x0400873B RID: 34619
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/IntensifyEffectGroup/IntensifyLvValueTexxt", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelIntensifyLvValueText;

		// Token: 0x0400873C RID: 34620
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/IntensifyEffectGroup/NowEffectTextScroll/Mask/NowEffectText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelIntensifyNowEffectText;

		// Token: 0x0400873D RID: 34621
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/AfterIntensifyEffectGroup/AfterIntensifyLvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelAfterIntensifyLvValueText;

		// Token: 0x0400873E RID: 34622
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/AfterIntensifyEffectGroup/TextScroll/Mask/AfterEffectText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelAfterIntensifyEffectText;

		// Token: 0x0400873F RID: 34623
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/ItemGroup/ItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierAndSkillInfoPanelItemGroup;

		// Token: 0x04008740 RID: 34624
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/PromoteGroup/PromoteButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierAndSkillInfoPanelPromoteButton;

		// Token: 0x04008741 RID: 34625
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/PromoteGroup/PromoteButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierAndSkillInfoPanelPromoteButtonStateCtrl;

		// Token: 0x04008742 RID: 34626
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/PromoteGroup/GoldenValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAndSkillInfoPanelGoldenValueText;

		// Token: 0x04008743 RID: 34627
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/PromoteGroup/GoldenValueText", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierAndSkillInfoPanelGoldenStateCtrl;

		// Token: 0x04008744 RID: 34628
		[AutoBind("./SkillItemInfoPanel/SoldierAndSkillInfoPanel/InfoPanel/BGImage/FrameImage/PromoteGroup/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierAndSkillInfoPanelConditionGroup;

		// Token: 0x04008745 RID: 34629
		[AutoBind("./SkillItemInfoPanel/EnhanceSuccessEffectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_enhanceSuccessEffectPanelStateCtrl;

		// Token: 0x04008746 RID: 34630
		private bool m_isFirstIn = true;

		// Token: 0x04008747 RID: 34631
		private UISpineGraphic m_soldierInfoGraphic;

		// Token: 0x04008748 RID: 34632
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008749 RID: 34633
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400874A RID: 34634
		private TrainingRoom m_curTrainingRoom;

		// Token: 0x0400874B RID: 34635
		private TrainingCourse m_curTrainingCourse;

		// Token: 0x0400874C RID: 34636
		private TrainingSkillItemUIController m_curTrainingSkillItemCtrl;

		// Token: 0x0400874D RID: 34637
		private CourseItemUIController m_lastCourseItemCtrl;

		// Token: 0x0400874E RID: 34638
		private List<TrainingSkillItemUIController> m_trainingSkillItemUICtrlList = new List<TrainingSkillItemUIController>();

		// Token: 0x0400874F RID: 34639
		[DoNotToLua]
		private DrillTrainingUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008750 RID: 34640
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008751 RID: 34641
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008752 RID: 34642
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008753 RID: 34643
		private LuaFunction m_Open_hotfix;

		// Token: 0x04008754 RID: 34644
		private LuaFunction m_UpdateViewInDrillTrainingInt32Int32_hotfix;

		// Token: 0x04008755 RID: 34645
		private LuaFunction m_ShowTechClickPanelByTechIdInt32_hotfix;

		// Token: 0x04008756 RID: 34646
		private LuaFunction m_SetRoomCoachInfoPanel_hotfix;

		// Token: 0x04008757 RID: 34647
		private LuaFunction m_SetCoursesListPanel_hotfix;

		// Token: 0x04008758 RID: 34648
		private LuaFunction m_OnCourseItemClickCourseItemUIController_hotfix;

		// Token: 0x04008759 RID: 34649
		private LuaFunction m_SetSkillPanel_hotfix;

		// Token: 0x0400875A RID: 34650
		private LuaFunction m_OnTrainingSkillItemClickTrainingSkillItemUIController_hotfix;

		// Token: 0x0400875B RID: 34651
		private LuaFunction m_SetSkillItemInfoPanelTrainingSkillItemUIController_hotfix;

		// Token: 0x0400875C RID: 34652
		private LuaFunction m_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x0400875D RID: 34653
		private LuaFunction m_SetSoldierDetailPanelConfigDataSoldierInfo_hotfix;

		// Token: 0x0400875E RID: 34654
		private LuaFunction m_OnInfoPanelPromoteButtonClick_hotfix;

		// Token: 0x0400875F RID: 34655
		private LuaFunction m_OnShowSoldierDetailButtonClick_hotfix;

		// Token: 0x04008760 RID: 34656
		private LuaFunction m_OnSkillItemInfoPanelBGButtonClick_hotfix;

		// Token: 0x04008761 RID: 34657
		private LuaFunction m_OnGoldAddButtonClick_hotfix;

		// Token: 0x04008762 RID: 34658
		private LuaFunction m_OnCrystalAddButtonClick_hotfix;

		// Token: 0x04008763 RID: 34659
		private LuaFunction m_OnSkillItemInfoPanelFastMaxButtonClick_hotfix;

		// Token: 0x04008764 RID: 34660
		private LuaFunction m_OnSkillItemInfoPanelFastLevelButtonClick_hotfix;

		// Token: 0x04008765 RID: 34661
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008766 RID: 34662
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008767 RID: 34663
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008768 RID: 34664
		private LuaFunction m_add_EventOnAddGoldAction_hotfix;

		// Token: 0x04008769 RID: 34665
		private LuaFunction m_remove_EventOnAddGoldAction_hotfix;

		// Token: 0x0400876A RID: 34666
		private LuaFunction m_add_EventOnAddCrystalAction_hotfix;

		// Token: 0x0400876B RID: 34667
		private LuaFunction m_remove_EventOnAddCrystalAction_hotfix;

		// Token: 0x0400876C RID: 34668
		private LuaFunction m_add_EventOnTechLevelupAction;

		// Token: 0x0400876D RID: 34669
		private LuaFunction m_remove_EventOnTechLevelupAction;

		// Token: 0x0400876E RID: 34670
		private LuaFunction m_add_EventOnEvolutionMaterialClickAction;

		// Token: 0x0400876F RID: 34671
		private LuaFunction m_remove_EventOnEvolutionMaterialClickAction;

		// Token: 0x02000C44 RID: 3140
		public new class LuaExportHelper
		{
			// Token: 0x0600DD55 RID: 56661 RVA: 0x003BFD98 File Offset: 0x003BDF98
			public LuaExportHelper(DrillTrainingUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DD56 RID: 56662 RVA: 0x003BFDA8 File Offset: 0x003BDFA8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DD57 RID: 56663 RVA: 0x003BFDB8 File Offset: 0x003BDFB8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DD58 RID: 56664 RVA: 0x003BFDC8 File Offset: 0x003BDFC8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DD59 RID: 56665 RVA: 0x003BFDD8 File Offset: 0x003BDFD8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DD5A RID: 56666 RVA: 0x003BFDF0 File Offset: 0x003BDFF0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DD5B RID: 56667 RVA: 0x003BFE00 File Offset: 0x003BE000
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DD5C RID: 56668 RVA: 0x003BFE10 File Offset: 0x003BE010
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DD5D RID: 56669 RVA: 0x003BFE20 File Offset: 0x003BE020
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DD5E RID: 56670 RVA: 0x003BFE30 File Offset: 0x003BE030
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DD5F RID: 56671 RVA: 0x003BFE40 File Offset: 0x003BE040
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DD60 RID: 56672 RVA: 0x003BFE50 File Offset: 0x003BE050
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DD61 RID: 56673 RVA: 0x003BFE60 File Offset: 0x003BE060
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DD62 RID: 56674 RVA: 0x003BFE70 File Offset: 0x003BE070
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DD63 RID: 56675 RVA: 0x003BFE80 File Offset: 0x003BE080
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DD64 RID: 56676 RVA: 0x003BFE90 File Offset: 0x003BE090
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DD65 RID: 56677 RVA: 0x003BFEA0 File Offset: 0x003BE0A0
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600DD66 RID: 56678 RVA: 0x003BFEB0 File Offset: 0x003BE0B0
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600DD67 RID: 56679 RVA: 0x003BFEC0 File Offset: 0x003BE0C0
			public void __callDele_EventOnAddGold()
			{
				this.m_owner.__callDele_EventOnAddGold();
			}

			// Token: 0x0600DD68 RID: 56680 RVA: 0x003BFED0 File Offset: 0x003BE0D0
			public void __clearDele_EventOnAddGold()
			{
				this.m_owner.__clearDele_EventOnAddGold();
			}

			// Token: 0x0600DD69 RID: 56681 RVA: 0x003BFEE0 File Offset: 0x003BE0E0
			public void __callDele_EventOnAddCrystal()
			{
				this.m_owner.__callDele_EventOnAddCrystal();
			}

			// Token: 0x0600DD6A RID: 56682 RVA: 0x003BFEF0 File Offset: 0x003BE0F0
			public void __clearDele_EventOnAddCrystal()
			{
				this.m_owner.__clearDele_EventOnAddCrystal();
			}

			// Token: 0x0600DD6B RID: 56683 RVA: 0x003BFF00 File Offset: 0x003BE100
			public void __callDele_EventOnTechLevelup(int arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnTechLevelup(arg1, arg2);
			}

			// Token: 0x0600DD6C RID: 56684 RVA: 0x003BFF10 File Offset: 0x003BE110
			public void __clearDele_EventOnTechLevelup(int arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnTechLevelup(arg1, arg2);
			}

			// Token: 0x0600DD6D RID: 56685 RVA: 0x003BFF20 File Offset: 0x003BE120
			public void __callDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnEvolutionMaterialClick(arg1, arg2, arg3);
			}

			// Token: 0x0600DD6E RID: 56686 RVA: 0x003BFF30 File Offset: 0x003BE130
			public void __clearDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnEvolutionMaterialClick(arg1, arg2, arg3);
			}

			// Token: 0x17002AE4 RID: 10980
			// (get) Token: 0x0600DD6F RID: 56687 RVA: 0x003BFF40 File Offset: 0x003BE140
			// (set) Token: 0x0600DD70 RID: 56688 RVA: 0x003BFF50 File Offset: 0x003BE150
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

			// Token: 0x17002AE5 RID: 10981
			// (get) Token: 0x0600DD71 RID: 56689 RVA: 0x003BFF60 File Offset: 0x003BE160
			// (set) Token: 0x0600DD72 RID: 56690 RVA: 0x003BFF70 File Offset: 0x003BE170
			public Text m_crystalText
			{
				get
				{
					return this.m_owner.m_crystalText;
				}
				set
				{
					this.m_owner.m_crystalText = value;
				}
			}

			// Token: 0x17002AE6 RID: 10982
			// (get) Token: 0x0600DD73 RID: 56691 RVA: 0x003BFF80 File Offset: 0x003BE180
			// (set) Token: 0x0600DD74 RID: 56692 RVA: 0x003BFF90 File Offset: 0x003BE190
			public Button m_crystalAddButton
			{
				get
				{
					return this.m_owner.m_crystalAddButton;
				}
				set
				{
					this.m_owner.m_crystalAddButton = value;
				}
			}

			// Token: 0x17002AE7 RID: 10983
			// (get) Token: 0x0600DD75 RID: 56693 RVA: 0x003BFFA0 File Offset: 0x003BE1A0
			// (set) Token: 0x0600DD76 RID: 56694 RVA: 0x003BFFB0 File Offset: 0x003BE1B0
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

			// Token: 0x17002AE8 RID: 10984
			// (get) Token: 0x0600DD77 RID: 56695 RVA: 0x003BFFC0 File Offset: 0x003BE1C0
			// (set) Token: 0x0600DD78 RID: 56696 RVA: 0x003BFFD0 File Offset: 0x003BE1D0
			public Button m_goldAddButton
			{
				get
				{
					return this.m_owner.m_goldAddButton;
				}
				set
				{
					this.m_owner.m_goldAddButton = value;
				}
			}

			// Token: 0x17002AE9 RID: 10985
			// (get) Token: 0x0600DD79 RID: 56697 RVA: 0x003BFFE0 File Offset: 0x003BE1E0
			// (set) Token: 0x0600DD7A RID: 56698 RVA: 0x003BFFF0 File Offset: 0x003BE1F0
			public Text m_trainingNameText
			{
				get
				{
					return this.m_owner.m_trainingNameText;
				}
				set
				{
					this.m_owner.m_trainingNameText = value;
				}
			}

			// Token: 0x17002AEA RID: 10986
			// (get) Token: 0x0600DD7B RID: 56699 RVA: 0x003C0000 File Offset: 0x003BE200
			// (set) Token: 0x0600DD7C RID: 56700 RVA: 0x003C0010 File Offset: 0x003BE210
			public CommonUIStateController m_roomInfoImageStateCtrl
			{
				get
				{
					return this.m_owner.m_roomInfoImageStateCtrl;
				}
				set
				{
					this.m_owner.m_roomInfoImageStateCtrl = value;
				}
			}

			// Token: 0x17002AEB RID: 10987
			// (get) Token: 0x0600DD7D RID: 56701 RVA: 0x003C0020 File Offset: 0x003BE220
			// (set) Token: 0x0600DD7E RID: 56702 RVA: 0x003C0030 File Offset: 0x003BE230
			public Text m_roomInfoLvValueText
			{
				get
				{
					return this.m_owner.m_roomInfoLvValueText;
				}
				set
				{
					this.m_owner.m_roomInfoLvValueText = value;
				}
			}

			// Token: 0x17002AEC RID: 10988
			// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x003C0040 File Offset: 0x003BE240
			// (set) Token: 0x0600DD80 RID: 56704 RVA: 0x003C0050 File Offset: 0x003BE250
			public Text m_roomInfoExpValueText
			{
				get
				{
					return this.m_owner.m_roomInfoExpValueText;
				}
				set
				{
					this.m_owner.m_roomInfoExpValueText = value;
				}
			}

			// Token: 0x17002AED RID: 10989
			// (get) Token: 0x0600DD81 RID: 56705 RVA: 0x003C0060 File Offset: 0x003BE260
			// (set) Token: 0x0600DD82 RID: 56706 RVA: 0x003C0070 File Offset: 0x003BE270
			public Image m_roomInfoProgressBar
			{
				get
				{
					return this.m_owner.m_roomInfoProgressBar;
				}
				set
				{
					this.m_owner.m_roomInfoProgressBar = value;
				}
			}

			// Token: 0x17002AEE RID: 10990
			// (get) Token: 0x0600DD83 RID: 56707 RVA: 0x003C0080 File Offset: 0x003BE280
			// (set) Token: 0x0600DD84 RID: 56708 RVA: 0x003C0090 File Offset: 0x003BE290
			public GameObject m_trainingCourseScrollViewContent
			{
				get
				{
					return this.m_owner.m_trainingCourseScrollViewContent;
				}
				set
				{
					this.m_owner.m_trainingCourseScrollViewContent = value;
				}
			}

			// Token: 0x17002AEF RID: 10991
			// (get) Token: 0x0600DD85 RID: 56709 RVA: 0x003C00A0 File Offset: 0x003BE2A0
			// (set) Token: 0x0600DD86 RID: 56710 RVA: 0x003C00B0 File Offset: 0x003BE2B0
			public GameObject m_skillPanelGameObject
			{
				get
				{
					return this.m_owner.m_skillPanelGameObject;
				}
				set
				{
					this.m_owner.m_skillPanelGameObject = value;
				}
			}

			// Token: 0x17002AF0 RID: 10992
			// (get) Token: 0x0600DD87 RID: 56711 RVA: 0x003C00C0 File Offset: 0x003BE2C0
			// (set) Token: 0x0600DD88 RID: 56712 RVA: 0x003C00D0 File Offset: 0x003BE2D0
			public GameObject m_skillItemPrefab
			{
				get
				{
					return this.m_owner.m_skillItemPrefab;
				}
				set
				{
					this.m_owner.m_skillItemPrefab = value;
				}
			}

			// Token: 0x17002AF1 RID: 10993
			// (get) Token: 0x0600DD89 RID: 56713 RVA: 0x003C00E0 File Offset: 0x003BE2E0
			// (set) Token: 0x0600DD8A RID: 56714 RVA: 0x003C00F0 File Offset: 0x003BE2F0
			public CommonUIStateController m_skillItemInfoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_skillItemInfoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_skillItemInfoPanelStateCtrl = value;
				}
			}

			// Token: 0x17002AF2 RID: 10994
			// (get) Token: 0x0600DD8B RID: 56715 RVA: 0x003C0100 File Offset: 0x003BE300
			// (set) Token: 0x0600DD8C RID: 56716 RVA: 0x003C0110 File Offset: 0x003BE310
			public Button m_skillItemInfoPanelBGButton
			{
				get
				{
					return this.m_owner.m_skillItemInfoPanelBGButton;
				}
				set
				{
					this.m_owner.m_skillItemInfoPanelBGButton = value;
				}
			}

			// Token: 0x17002AF3 RID: 10995
			// (get) Token: 0x0600DD8D RID: 56717 RVA: 0x003C0120 File Offset: 0x003BE320
			// (set) Token: 0x0600DD8E RID: 56718 RVA: 0x003C0130 File Offset: 0x003BE330
			public Button m_skillItemInfoPanelCloseButton
			{
				get
				{
					return this.m_owner.m_skillItemInfoPanelCloseButton;
				}
				set
				{
					this.m_owner.m_skillItemInfoPanelCloseButton = value;
				}
			}

			// Token: 0x17002AF4 RID: 10996
			// (get) Token: 0x0600DD8F RID: 56719 RVA: 0x003C0140 File Offset: 0x003BE340
			// (set) Token: 0x0600DD90 RID: 56720 RVA: 0x003C0150 File Offset: 0x003BE350
			public Button m_skillItemInfoPanelFastMaxButton
			{
				get
				{
					return this.m_owner.m_skillItemInfoPanelFastMaxButton;
				}
				set
				{
					this.m_owner.m_skillItemInfoPanelFastMaxButton = value;
				}
			}

			// Token: 0x17002AF5 RID: 10997
			// (get) Token: 0x0600DD91 RID: 56721 RVA: 0x003C0160 File Offset: 0x003BE360
			// (set) Token: 0x0600DD92 RID: 56722 RVA: 0x003C0170 File Offset: 0x003BE370
			public Button m_skillItemInfoPanelFastLevelButton
			{
				get
				{
					return this.m_owner.m_skillItemInfoPanelFastLevelButton;
				}
				set
				{
					this.m_owner.m_skillItemInfoPanelFastLevelButton = value;
				}
			}

			// Token: 0x17002AF6 RID: 10998
			// (get) Token: 0x0600DD93 RID: 56723 RVA: 0x003C0180 File Offset: 0x003BE380
			// (set) Token: 0x0600DD94 RID: 56724 RVA: 0x003C0190 File Offset: 0x003BE390
			public InputField m_skillItemInfoPanelFastLevelInputField
			{
				get
				{
					return this.m_owner.m_skillItemInfoPanelFastLevelInputField;
				}
				set
				{
					this.m_owner.m_skillItemInfoPanelFastLevelInputField = value;
				}
			}

			// Token: 0x17002AF7 RID: 10999
			// (get) Token: 0x0600DD95 RID: 56725 RVA: 0x003C01A0 File Offset: 0x003BE3A0
			// (set) Token: 0x0600DD96 RID: 56726 RVA: 0x003C01B0 File Offset: 0x003BE3B0
			public GameObject m_soldierDetailPanel
			{
				get
				{
					return this.m_owner.m_soldierDetailPanel;
				}
				set
				{
					this.m_owner.m_soldierDetailPanel = value;
				}
			}

			// Token: 0x17002AF8 RID: 11000
			// (get) Token: 0x0600DD97 RID: 56727 RVA: 0x003C01C0 File Offset: 0x003BE3C0
			// (set) Token: 0x0600DD98 RID: 56728 RVA: 0x003C01D0 File Offset: 0x003BE3D0
			public CommonUIStateController m_soldierDetailPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelStateCtrl = value;
				}
			}

			// Token: 0x17002AF9 RID: 11001
			// (get) Token: 0x0600DD99 RID: 56729 RVA: 0x003C01E0 File Offset: 0x003BE3E0
			// (set) Token: 0x0600DD9A RID: 56730 RVA: 0x003C01F0 File Offset: 0x003BE3F0
			public Image m_soldierDetailPanelSoldierTypeIcon
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelSoldierTypeIcon;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelSoldierTypeIcon = value;
				}
			}

			// Token: 0x17002AFA RID: 11002
			// (get) Token: 0x0600DD9B RID: 56731 RVA: 0x003C0200 File Offset: 0x003BE400
			// (set) Token: 0x0600DD9C RID: 56732 RVA: 0x003C0210 File Offset: 0x003BE410
			public Image m_soldierDetailPanelSoldierQualityIcon
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelSoldierQualityIcon;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelSoldierQualityIcon = value;
				}
			}

			// Token: 0x17002AFB RID: 11003
			// (get) Token: 0x0600DD9D RID: 56733 RVA: 0x003C0220 File Offset: 0x003BE420
			// (set) Token: 0x0600DD9E RID: 56734 RVA: 0x003C0230 File Offset: 0x003BE430
			public Text m_soldierDetailPanelSoldierNameText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelSoldierNameText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelSoldierNameText = value;
				}
			}

			// Token: 0x17002AFC RID: 11004
			// (get) Token: 0x0600DD9F RID: 56735 RVA: 0x003C0240 File Offset: 0x003BE440
			// (set) Token: 0x0600DDA0 RID: 56736 RVA: 0x003C0250 File Offset: 0x003BE450
			public Text m_soldierDetailPanelPorpretyGroupHPValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupHPValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupHPValueText = value;
				}
			}

			// Token: 0x17002AFD RID: 11005
			// (get) Token: 0x0600DDA1 RID: 56737 RVA: 0x003C0260 File Offset: 0x003BE460
			// (set) Token: 0x0600DDA2 RID: 56738 RVA: 0x003C0270 File Offset: 0x003BE470
			public Text m_soldierDetailPanelPorpretyGroupATValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupATValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupATValueText = value;
				}
			}

			// Token: 0x17002AFE RID: 11006
			// (get) Token: 0x0600DDA3 RID: 56739 RVA: 0x003C0280 File Offset: 0x003BE480
			// (set) Token: 0x0600DDA4 RID: 56740 RVA: 0x003C0290 File Offset: 0x003BE490
			public Text m_soldierDetailPanelPorpretyGroupDFValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupDFValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupDFValueText = value;
				}
			}

			// Token: 0x17002AFF RID: 11007
			// (get) Token: 0x0600DDA5 RID: 56741 RVA: 0x003C02A0 File Offset: 0x003BE4A0
			// (set) Token: 0x0600DDA6 RID: 56742 RVA: 0x003C02B0 File Offset: 0x003BE4B0
			public Text m_soldierDetailPanelPorpretyGroupMagicDFValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupMagicDFValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupMagicDFValueText = value;
				}
			}

			// Token: 0x17002B00 RID: 11008
			// (get) Token: 0x0600DDA7 RID: 56743 RVA: 0x003C02C0 File Offset: 0x003BE4C0
			// (set) Token: 0x0600DDA8 RID: 56744 RVA: 0x003C02D0 File Offset: 0x003BE4D0
			public Text m_soldierDetailPanelPorpretyGroupRangeValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupRangeValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupRangeValueText = value;
				}
			}

			// Token: 0x17002B01 RID: 11009
			// (get) Token: 0x0600DDA9 RID: 56745 RVA: 0x003C02E0 File Offset: 0x003BE4E0
			// (set) Token: 0x0600DDAA RID: 56746 RVA: 0x003C02F0 File Offset: 0x003BE4F0
			public Text m_soldierDetailPanelPorpretyGroupMoveValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupMoveValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupMoveValueText = value;
				}
			}

			// Token: 0x17002B02 RID: 11010
			// (get) Token: 0x0600DDAB RID: 56747 RVA: 0x003C0300 File Offset: 0x003BE500
			// (set) Token: 0x0600DDAC RID: 56748 RVA: 0x003C0310 File Offset: 0x003BE510
			public Text m_soldierDetailPanelPorpretyGroupRestrainValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupRestrainValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupRestrainValueText = value;
				}
			}

			// Token: 0x17002B03 RID: 11011
			// (get) Token: 0x0600DDAD RID: 56749 RVA: 0x003C0320 File Offset: 0x003BE520
			// (set) Token: 0x0600DDAE RID: 56750 RVA: 0x003C0330 File Offset: 0x003BE530
			public Text m_soldierDetailPanelPorpretyGroupWeakValueText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupWeakValueText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupWeakValueText = value;
				}
			}

			// Token: 0x17002B04 RID: 11012
			// (get) Token: 0x0600DDAF RID: 56751 RVA: 0x003C0340 File Offset: 0x003BE540
			// (set) Token: 0x0600DDB0 RID: 56752 RVA: 0x003C0350 File Offset: 0x003BE550
			public CommonUIStateController m_soldierDetailPanelPorpretyGroupTypeStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupTypeStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupTypeStateCtrl = value;
				}
			}

			// Token: 0x17002B05 RID: 11013
			// (get) Token: 0x0600DDB1 RID: 56753 RVA: 0x003C0360 File Offset: 0x003BE560
			// (set) Token: 0x0600DDB2 RID: 56754 RVA: 0x003C0370 File Offset: 0x003BE570
			public Text m_soldierDetailPanelPorpretyGroupDescText
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelPorpretyGroupDescText;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelPorpretyGroupDescText = value;
				}
			}

			// Token: 0x17002B06 RID: 11014
			// (get) Token: 0x0600DDB3 RID: 56755 RVA: 0x003C0380 File Offset: 0x003BE580
			// (set) Token: 0x0600DDB4 RID: 56756 RVA: 0x003C0390 File Offset: 0x003BE590
			public CommonUIStateController m_soldierDetailPanelHeroListStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelHeroListStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelHeroListStateCtrl = value;
				}
			}

			// Token: 0x17002B07 RID: 11015
			// (get) Token: 0x0600DDB5 RID: 56757 RVA: 0x003C03A0 File Offset: 0x003BE5A0
			// (set) Token: 0x0600DDB6 RID: 56758 RVA: 0x003C03B0 File Offset: 0x003BE5B0
			public GameObject m_soldierDetailPanelHeroListContent
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelHeroListContent;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelHeroListContent = value;
				}
			}

			// Token: 0x17002B08 RID: 11016
			// (get) Token: 0x0600DDB7 RID: 56759 RVA: 0x003C03C0 File Offset: 0x003BE5C0
			// (set) Token: 0x0600DDB8 RID: 56760 RVA: 0x003C03D0 File Offset: 0x003BE5D0
			public Image m_soldierAndSkillInfoSkillIconImage
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoSkillIconImage;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoSkillIconImage = value;
				}
			}

			// Token: 0x17002B09 RID: 11017
			// (get) Token: 0x0600DDB9 RID: 56761 RVA: 0x003C03E0 File Offset: 0x003BE5E0
			// (set) Token: 0x0600DDBA RID: 56762 RVA: 0x003C03F0 File Offset: 0x003BE5F0
			public Text m_soldierAndSkillInfoSkillNameText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoSkillNameText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoSkillNameText = value;
				}
			}

			// Token: 0x17002B0A RID: 11018
			// (get) Token: 0x0600DDBB RID: 56763 RVA: 0x003C0400 File Offset: 0x003BE600
			// (set) Token: 0x0600DDBC RID: 56764 RVA: 0x003C0410 File Offset: 0x003BE610
			public GameObject m_soldierAndSkillInfoSoldierGraphic
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoSoldierGraphic;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoSoldierGraphic = value;
				}
			}

			// Token: 0x17002B0B RID: 11019
			// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x003C0420 File Offset: 0x003BE620
			// (set) Token: 0x0600DDBE RID: 56766 RVA: 0x003C0430 File Offset: 0x003BE630
			public Text m_soldierAndSkillInfoSoldierNameText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoSoldierNameText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoSoldierNameText = value;
				}
			}

			// Token: 0x17002B0C RID: 11020
			// (get) Token: 0x0600DDBF RID: 56767 RVA: 0x003C0440 File Offset: 0x003BE640
			// (set) Token: 0x0600DDC0 RID: 56768 RVA: 0x003C0450 File Offset: 0x003BE650
			public GameObject m_soldierAndSkillInfoSkillUpdateEffectGroup
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoSkillUpdateEffectGroup;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoSkillUpdateEffectGroup = value;
				}
			}

			// Token: 0x17002B0D RID: 11021
			// (get) Token: 0x0600DDC1 RID: 56769 RVA: 0x003C0460 File Offset: 0x003BE660
			// (set) Token: 0x0600DDC2 RID: 56770 RVA: 0x003C0470 File Offset: 0x003BE670
			public CommonUIStateController m_soldierAndSkillInfoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelStateCtrl = value;
				}
			}

			// Token: 0x17002B0E RID: 11022
			// (get) Token: 0x0600DDC3 RID: 56771 RVA: 0x003C0480 File Offset: 0x003BE680
			// (set) Token: 0x0600DDC4 RID: 56772 RVA: 0x003C0490 File Offset: 0x003BE690
			public Button m_soldierAndSkillInfoPanelWatchDetailButton
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelWatchDetailButton;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelWatchDetailButton = value;
				}
			}

			// Token: 0x17002B0F RID: 11023
			// (get) Token: 0x0600DDC5 RID: 56773 RVA: 0x003C04A0 File Offset: 0x003BE6A0
			// (set) Token: 0x0600DDC6 RID: 56774 RVA: 0x003C04B0 File Offset: 0x003BE6B0
			public CommonUIStateController m_infoPanelDetailStateCtrl
			{
				get
				{
					return this.m_owner.m_infoPanelDetailStateCtrl;
				}
				set
				{
					this.m_owner.m_infoPanelDetailStateCtrl = value;
				}
			}

			// Token: 0x17002B10 RID: 11024
			// (get) Token: 0x0600DDC7 RID: 56775 RVA: 0x003C04C0 File Offset: 0x003BE6C0
			// (set) Token: 0x0600DDC8 RID: 56776 RVA: 0x003C04D0 File Offset: 0x003BE6D0
			public Text m_soldierAndSkillInfoPanelNowLvValueText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelNowLvValueText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelNowLvValueText = value;
				}
			}

			// Token: 0x17002B11 RID: 11025
			// (get) Token: 0x0600DDC9 RID: 56777 RVA: 0x003C04E0 File Offset: 0x003BE6E0
			// (set) Token: 0x0600DDCA RID: 56778 RVA: 0x003C04F0 File Offset: 0x003BE6F0
			public Text m_soldierAndSkillInfoPanelNowEffectText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelNowEffectText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelNowEffectText = value;
				}
			}

			// Token: 0x17002B12 RID: 11026
			// (get) Token: 0x0600DDCB RID: 56779 RVA: 0x003C0500 File Offset: 0x003BE700
			// (set) Token: 0x0600DDCC RID: 56780 RVA: 0x003C0510 File Offset: 0x003BE710
			public Text m_soldierAndSkillInfoPanelIntensifyLvValueText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelIntensifyLvValueText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelIntensifyLvValueText = value;
				}
			}

			// Token: 0x17002B13 RID: 11027
			// (get) Token: 0x0600DDCD RID: 56781 RVA: 0x003C0520 File Offset: 0x003BE720
			// (set) Token: 0x0600DDCE RID: 56782 RVA: 0x003C0530 File Offset: 0x003BE730
			public Text m_soldierAndSkillInfoPanelIntensifyNowEffectText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelIntensifyNowEffectText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelIntensifyNowEffectText = value;
				}
			}

			// Token: 0x17002B14 RID: 11028
			// (get) Token: 0x0600DDCF RID: 56783 RVA: 0x003C0540 File Offset: 0x003BE740
			// (set) Token: 0x0600DDD0 RID: 56784 RVA: 0x003C0550 File Offset: 0x003BE750
			public Text m_soldierAndSkillInfoPanelAfterIntensifyLvValueText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelAfterIntensifyLvValueText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelAfterIntensifyLvValueText = value;
				}
			}

			// Token: 0x17002B15 RID: 11029
			// (get) Token: 0x0600DDD1 RID: 56785 RVA: 0x003C0560 File Offset: 0x003BE760
			// (set) Token: 0x0600DDD2 RID: 56786 RVA: 0x003C0570 File Offset: 0x003BE770
			public Text m_soldierAndSkillInfoPanelAfterIntensifyEffectText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelAfterIntensifyEffectText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelAfterIntensifyEffectText = value;
				}
			}

			// Token: 0x17002B16 RID: 11030
			// (get) Token: 0x0600DDD3 RID: 56787 RVA: 0x003C0580 File Offset: 0x003BE780
			// (set) Token: 0x0600DDD4 RID: 56788 RVA: 0x003C0590 File Offset: 0x003BE790
			public GameObject m_soldierAndSkillInfoPanelItemGroup
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelItemGroup;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelItemGroup = value;
				}
			}

			// Token: 0x17002B17 RID: 11031
			// (get) Token: 0x0600DDD5 RID: 56789 RVA: 0x003C05A0 File Offset: 0x003BE7A0
			// (set) Token: 0x0600DDD6 RID: 56790 RVA: 0x003C05B0 File Offset: 0x003BE7B0
			public Button m_soldierAndSkillInfoPanelPromoteButton
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelPromoteButton;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelPromoteButton = value;
				}
			}

			// Token: 0x17002B18 RID: 11032
			// (get) Token: 0x0600DDD7 RID: 56791 RVA: 0x003C05C0 File Offset: 0x003BE7C0
			// (set) Token: 0x0600DDD8 RID: 56792 RVA: 0x003C05D0 File Offset: 0x003BE7D0
			public CommonUIStateController m_soldierAndSkillInfoPanelPromoteButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelPromoteButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelPromoteButtonStateCtrl = value;
				}
			}

			// Token: 0x17002B19 RID: 11033
			// (get) Token: 0x0600DDD9 RID: 56793 RVA: 0x003C05E0 File Offset: 0x003BE7E0
			// (set) Token: 0x0600DDDA RID: 56794 RVA: 0x003C05F0 File Offset: 0x003BE7F0
			public Text m_soldierAndSkillInfoPanelGoldenValueText
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelGoldenValueText;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelGoldenValueText = value;
				}
			}

			// Token: 0x17002B1A RID: 11034
			// (get) Token: 0x0600DDDB RID: 56795 RVA: 0x003C0600 File Offset: 0x003BE800
			// (set) Token: 0x0600DDDC RID: 56796 RVA: 0x003C0610 File Offset: 0x003BE810
			public CommonUIStateController m_soldierAndSkillInfoPanelGoldenStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelGoldenStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelGoldenStateCtrl = value;
				}
			}

			// Token: 0x17002B1B RID: 11035
			// (get) Token: 0x0600DDDD RID: 56797 RVA: 0x003C0620 File Offset: 0x003BE820
			// (set) Token: 0x0600DDDE RID: 56798 RVA: 0x003C0630 File Offset: 0x003BE830
			public GameObject m_soldierAndSkillInfoPanelConditionGroup
			{
				get
				{
					return this.m_owner.m_soldierAndSkillInfoPanelConditionGroup;
				}
				set
				{
					this.m_owner.m_soldierAndSkillInfoPanelConditionGroup = value;
				}
			}

			// Token: 0x17002B1C RID: 11036
			// (get) Token: 0x0600DDDF RID: 56799 RVA: 0x003C0640 File Offset: 0x003BE840
			// (set) Token: 0x0600DDE0 RID: 56800 RVA: 0x003C0650 File Offset: 0x003BE850
			public CommonUIStateController m_enhanceSuccessEffectPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_enhanceSuccessEffectPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_enhanceSuccessEffectPanelStateCtrl = value;
				}
			}

			// Token: 0x17002B1D RID: 11037
			// (get) Token: 0x0600DDE1 RID: 56801 RVA: 0x003C0660 File Offset: 0x003BE860
			// (set) Token: 0x0600DDE2 RID: 56802 RVA: 0x003C0670 File Offset: 0x003BE870
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

			// Token: 0x17002B1E RID: 11038
			// (get) Token: 0x0600DDE3 RID: 56803 RVA: 0x003C0680 File Offset: 0x003BE880
			// (set) Token: 0x0600DDE4 RID: 56804 RVA: 0x003C0690 File Offset: 0x003BE890
			public UISpineGraphic m_soldierInfoGraphic
			{
				get
				{
					return this.m_owner.m_soldierInfoGraphic;
				}
				set
				{
					this.m_owner.m_soldierInfoGraphic = value;
				}
			}

			// Token: 0x17002B1F RID: 11039
			// (get) Token: 0x0600DDE5 RID: 56805 RVA: 0x003C06A0 File Offset: 0x003BE8A0
			// (set) Token: 0x0600DDE6 RID: 56806 RVA: 0x003C06B0 File Offset: 0x003BE8B0
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

			// Token: 0x17002B20 RID: 11040
			// (get) Token: 0x0600DDE7 RID: 56807 RVA: 0x003C06C0 File Offset: 0x003BE8C0
			// (set) Token: 0x0600DDE8 RID: 56808 RVA: 0x003C06D0 File Offset: 0x003BE8D0
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

			// Token: 0x17002B21 RID: 11041
			// (get) Token: 0x0600DDE9 RID: 56809 RVA: 0x003C06E0 File Offset: 0x003BE8E0
			// (set) Token: 0x0600DDEA RID: 56810 RVA: 0x003C06F0 File Offset: 0x003BE8F0
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

			// Token: 0x17002B22 RID: 11042
			// (get) Token: 0x0600DDEB RID: 56811 RVA: 0x003C0700 File Offset: 0x003BE900
			// (set) Token: 0x0600DDEC RID: 56812 RVA: 0x003C0710 File Offset: 0x003BE910
			public TrainingCourse m_curTrainingCourse
			{
				get
				{
					return this.m_owner.m_curTrainingCourse;
				}
				set
				{
					this.m_owner.m_curTrainingCourse = value;
				}
			}

			// Token: 0x17002B23 RID: 11043
			// (get) Token: 0x0600DDED RID: 56813 RVA: 0x003C0720 File Offset: 0x003BE920
			// (set) Token: 0x0600DDEE RID: 56814 RVA: 0x003C0730 File Offset: 0x003BE930
			public TrainingSkillItemUIController m_curTrainingSkillItemCtrl
			{
				get
				{
					return this.m_owner.m_curTrainingSkillItemCtrl;
				}
				set
				{
					this.m_owner.m_curTrainingSkillItemCtrl = value;
				}
			}

			// Token: 0x17002B24 RID: 11044
			// (get) Token: 0x0600DDEF RID: 56815 RVA: 0x003C0740 File Offset: 0x003BE940
			// (set) Token: 0x0600DDF0 RID: 56816 RVA: 0x003C0750 File Offset: 0x003BE950
			public CourseItemUIController m_lastCourseItemCtrl
			{
				get
				{
					return this.m_owner.m_lastCourseItemCtrl;
				}
				set
				{
					this.m_owner.m_lastCourseItemCtrl = value;
				}
			}

			// Token: 0x17002B25 RID: 11045
			// (get) Token: 0x0600DDF1 RID: 56817 RVA: 0x003C0760 File Offset: 0x003BE960
			// (set) Token: 0x0600DDF2 RID: 56818 RVA: 0x003C0770 File Offset: 0x003BE970
			public List<TrainingSkillItemUIController> m_trainingSkillItemUICtrlList
			{
				get
				{
					return this.m_owner.m_trainingSkillItemUICtrlList;
				}
				set
				{
					this.m_owner.m_trainingSkillItemUICtrlList = value;
				}
			}

			// Token: 0x0600DDF3 RID: 56819 RVA: 0x003C0780 File Offset: 0x003BE980
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DDF4 RID: 56820 RVA: 0x003C0790 File Offset: 0x003BE990
			public void ShowTechClickPanelByTechId(int techId)
			{
				this.m_owner.ShowTechClickPanelByTechId(techId);
			}

			// Token: 0x0600DDF5 RID: 56821 RVA: 0x003C07A0 File Offset: 0x003BE9A0
			public void SetRoomCoachInfoPanel()
			{
				this.m_owner.SetRoomCoachInfoPanel();
			}

			// Token: 0x0600DDF6 RID: 56822 RVA: 0x003C07B0 File Offset: 0x003BE9B0
			public void SetCoursesListPanel()
			{
				this.m_owner.SetCoursesListPanel();
			}

			// Token: 0x0600DDF7 RID: 56823 RVA: 0x003C07C0 File Offset: 0x003BE9C0
			public void OnCourseItemClick(CourseItemUIController ctrl)
			{
				this.m_owner.OnCourseItemClick(ctrl);
			}

			// Token: 0x0600DDF8 RID: 56824 RVA: 0x003C07D0 File Offset: 0x003BE9D0
			public void SetSkillPanel()
			{
				this.m_owner.SetSkillPanel();
			}

			// Token: 0x0600DDF9 RID: 56825 RVA: 0x003C07E0 File Offset: 0x003BE9E0
			public void OnTrainingSkillItemClick(TrainingSkillItemUIController ctrl)
			{
				this.m_owner.OnTrainingSkillItemClick(ctrl);
			}

			// Token: 0x0600DDFA RID: 56826 RVA: 0x003C07F0 File Offset: 0x003BE9F0
			public void SetSkillItemInfoPanel(TrainingSkillItemUIController ctrl)
			{
				this.m_owner.SetSkillItemInfoPanel(ctrl);
			}

			// Token: 0x0600DDFB RID: 56827 RVA: 0x003C0800 File Offset: 0x003BEA00
			public void OnEvolutionMaterialClick(GoodsType goodsType, int id, int needCount)
			{
				this.m_owner.OnEvolutionMaterialClick(goodsType, id, needCount);
			}

			// Token: 0x0600DDFC RID: 56828 RVA: 0x003C0810 File Offset: 0x003BEA10
			public void SetSoldierDetailPanel(ConfigDataSoldierInfo soldierInfo)
			{
				this.m_owner.SetSoldierDetailPanel(soldierInfo);
			}

			// Token: 0x0600DDFD RID: 56829 RVA: 0x003C0820 File Offset: 0x003BEA20
			public void OnInfoPanelPromoteButtonClick()
			{
				this.m_owner.OnInfoPanelPromoteButtonClick();
			}

			// Token: 0x0600DDFE RID: 56830 RVA: 0x003C0830 File Offset: 0x003BEA30
			public void OnShowSoldierDetailButtonClick()
			{
				this.m_owner.OnShowSoldierDetailButtonClick();
			}

			// Token: 0x0600DDFF RID: 56831 RVA: 0x003C0840 File Offset: 0x003BEA40
			public void OnSkillItemInfoPanelBGButtonClick()
			{
				this.m_owner.OnSkillItemInfoPanelBGButtonClick();
			}

			// Token: 0x0600DE00 RID: 56832 RVA: 0x003C0850 File Offset: 0x003BEA50
			public void OnGoldAddButtonClick()
			{
				this.m_owner.OnGoldAddButtonClick();
			}

			// Token: 0x0600DE01 RID: 56833 RVA: 0x003C0860 File Offset: 0x003BEA60
			public void OnCrystalAddButtonClick()
			{
				this.m_owner.OnCrystalAddButtonClick();
			}

			// Token: 0x0600DE02 RID: 56834 RVA: 0x003C0870 File Offset: 0x003BEA70
			public void OnSkillItemInfoPanelFastMaxButtonClick()
			{
				this.m_owner.OnSkillItemInfoPanelFastMaxButtonClick();
			}

			// Token: 0x0600DE03 RID: 56835 RVA: 0x003C0880 File Offset: 0x003BEA80
			public void OnSkillItemInfoPanelFastLevelButtonClick()
			{
				this.m_owner.OnSkillItemInfoPanelFastLevelButtonClick();
			}

			// Token: 0x0600DE04 RID: 56836 RVA: 0x003C0890 File Offset: 0x003BEA90
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x04008770 RID: 34672
			private DrillTrainingUIController m_owner;
		}
	}
}
