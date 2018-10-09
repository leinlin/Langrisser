using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C61 RID: 3169
	[HotFix]
	public class DrillUITask : UITask
	{
		// Token: 0x0600E1A7 RID: 57767 RVA: 0x003CBB40 File Offset: 0x003C9D40
		public DrillUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600E1A8 RID: 57768 RVA: 0x003CBD8C File Offset: 0x003C9F8C
		public static void StartUITask(UIIntent uiIntent, int techId)
		{
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(uiIntent, typeof(DrillUITask).Name, null);
				DrillUITask.m_getSoldierTechId = techId;
				DrillUITask.m_curMode = DrillUITask.TrainingMode;
				DrillUITask.m_trainingModeFrom = "HeroDetail";
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				DrillUITask.m_courseId = projectLPlayerContext.GetTrainingCourseIdByTechId(DrillUITask.m_getSoldierTechId);
				UIManager instance = UIManager.Instance;
				UIIntent intent = uiintentReturnable;
				bool pushIntentToStack = true;
				bool clearIntentStack = false;
				if (DrillUITask.<>f__mg$cache0 == null)
				{
					DrillUITask.<>f__mg$cache0 = new Action(DrillUITask.DrillUITask_OnLoadAllResCompleted);
				}
				instance.StartUITask(intent, pushIntentToStack, clearIntentStack, DrillUITask.<>f__mg$cache0);
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x0600E1A9 RID: 57769 RVA: 0x003CBDD0 File Offset: 0x003C9FD0
		public static void DrillUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(DrillUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600E1AA RID: 57770 RVA: 0x003CBE04 File Offset: 0x003CA004
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			if (DrillUITask.m_curMode == DrillUITask.DrillMode)
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(22);
				ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
				if (charImageInfo != null)
				{
					base.CollectAsset(charImageInfo.Spine);
					base.CollectSpriteAsset(charImageInfo.Image);
				}
				List<HeroAssistantsTaskAssignment> assignedHeroAssistantsTask = this.m_playerContext.GetAssignedHeroAssistantsTask();
				foreach (HeroAssistantsTaskAssignment heroAssistantsTaskAssignment in assignedHeroAssistantsTask)
				{
					int heroId = heroAssistantsTaskAssignment.AssignedHeroIds[0];
					Hero hero = this.m_playerContext.GetHero(heroId);
					ConfigDataJobConnectionInfo jobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
					if (jobConnectionInfo != null)
					{
						base.CollectAsset(jobConnectionInfo.Model);
					}
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.ManualMode)
			{
				this.SetTotalSoldierInfoListWithFilter();
				this.m_totalSoldierManualPage = (int)Math.Ceiling((double)this.m_totalSoldierInfoList.Count / 12.0);
				this.m_curSoldierInfoList.Clear();
				int count = 12;
				if (this.m_curSoldierManualPage >= this.m_totalSoldierManualPage - 1)
				{
					count = this.m_totalSoldierInfoList.Count - this.m_curSoldierManualPage * 12;
				}
				this.m_curSoldierInfoList.AddRange(this.m_totalSoldierInfoList.GetRange(this.m_curSoldierManualPage * 12, count));
				foreach (ConfigDataSoldierInfo configDataSoldierInfo in this.m_curSoldierInfoList)
				{
					base.CollectAsset(configDataSoldierInfo.Model);
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TrainingMode)
			{
				ConfigDataTrainingCourseInfo configDataTrainingCourseInfo = this.m_configDataLoader.GetConfigDataTrainingCourseInfo(DrillUITask.m_courseId);
				TrainingRoom trainingRoomById = this.m_playerContext.GetTrainingRoomById(configDataTrainingCourseInfo.RoomID);
				foreach (TrainingCourse trainingCourse in trainingRoomById.Courses)
				{
					List<TrainingTech> techs = trainingCourse.Techs;
					foreach (TrainingTech trainingTech in techs)
					{
						base.CollectSpriteAsset(trainingTech.Config.Resource);
						if (trainingTech.Config.TechType == TechDisplayType.TechDisplayType_SoldierLevelUp)
						{
							ConfigDataSoldierInfo configDataSoldierInfo2 = this.m_configDataLoader.GetConfigDataSoldierInfo(trainingTech.Config.SoldierIDRelated[0]);
							base.CollectAsset(configDataSoldierInfo2.Model);
						}
					}
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TutorMode)
			{
				base.CollectSpriteAsset("UI/Drill_ABS/1/1.png");
				base.CollectSpriteAsset("UI/Drill_ABS/1/2.png");
				base.CollectSpriteAsset("UI/Drill_ABS/1/3.png");
				List<Hero> heros = this.m_playerContext.GetHeros();
				if (heros.Count > 0)
				{
					foreach (Hero hero2 in heros)
					{
						ConfigDataCharImageInfo charImageInfo2 = hero2.HeroInfo.GetCharImageInfo(hero2.StarLevel);
						if (charImageInfo2 != null)
						{
							base.CollectAsset(AssetUtility.MakeSpriteAssetName(charImageInfo2.CardHeadImage, "_1"));
						}
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600E1AB RID: 57771 RVA: 0x003CC25C File Offset: 0x003CA45C
		private void SetTotalSoldierInfoListWithFilter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTotalSoldierInfoListWithFilter_hotfix != null)
			{
				this.m_SetTotalSoldierInfoListWithFilter_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_totalSoldierInfoList.Clear();
			foreach (KeyValuePair<int, ConfigDataSoldierInfo> keyValuePair in configDataLoader.GetAllConfigDataSoldierInfo())
			{
				ConfigDataSoldierInfo value = keyValuePair.Value;
				if (!value.IsEnemy)
				{
					if (this.m_armyTag == ArmyTag.ArmyTag_None || value.m_armyInfo.ArmyTag == this.m_armyTag)
					{
						if (this.m_soldierFilterRank == 0)
						{
							this.m_totalSoldierInfoList.Add(value);
						}
						else if (keyValuePair.Value.Rank == this.m_soldierFilterRank)
						{
							this.m_totalSoldierInfoList.Add(value);
						}
					}
				}
			}
		}

		// Token: 0x0600E1AC RID: 57772 RVA: 0x003CC394 File Offset: 0x003CA594
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600E1AD RID: 57773 RVA: 0x003CC3F4 File Offset: 0x003CA5F4
		protected override bool IsNeedLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadStaticRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadStaticRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (DrillUITask.m_curMode == DrillUITask.DrillMode)
			{
				if (this.m_drillUIController == null)
				{
					return true;
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.ManualMode)
			{
				if (this.m_drillSoldierManualUIController == null)
				{
					return true;
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TrainingMode)
			{
				if (this.m_drillTrainingUIController == null)
				{
					return true;
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TutorMode && this.m_drillTutorUIController == null)
			{
				return true;
			}
			return base.IsNeedLoadStaticRes();
		}

		// Token: 0x0600E1AE RID: 57774 RVA: 0x003CC514 File Offset: 0x003CA714
		protected override List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllStaticResDescForLoad_hotfix != null)
			{
				return (List<UITaskBase.LayerDesc>)this.m_CollectAllStaticResDescForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<UITaskBase.LayerDesc> list = new List<UITaskBase.LayerDesc>();
			if (DrillUITask.m_curMode == DrillUITask.DrillMode)
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[0].m_layerName,
					m_layerResPath = this.LayerDescArray[0].m_layerResPath,
					m_isUILayer = this.LayerDescArray[0].m_isUILayer,
					m_index = this.LayerDescArray[0].m_index
				});
				return list;
			}
			if (DrillUITask.m_curMode == DrillUITask.ManualMode)
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[1].m_layerName,
					m_layerResPath = this.LayerDescArray[1].m_layerResPath,
					m_isUILayer = this.LayerDescArray[1].m_isUILayer,
					m_index = this.LayerDescArray[1].m_index
				});
				return list;
			}
			if (DrillUITask.m_curMode == DrillUITask.TrainingMode)
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[2].m_layerName,
					m_layerResPath = this.LayerDescArray[2].m_layerResPath,
					m_isUILayer = this.LayerDescArray[2].m_isUILayer,
					m_index = this.LayerDescArray[2].m_index
				});
				return list;
			}
			if (DrillUITask.m_curMode == DrillUITask.TutorMode)
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[3].m_layerName,
					m_layerResPath = this.LayerDescArray[3].m_layerResPath,
					m_isUILayer = this.LayerDescArray[3].m_isUILayer,
					m_index = this.LayerDescArray[3].m_index
				});
				return list;
			}
			return base.CollectAllStaticResDescForLoad();
		}

		// Token: 0x0600E1AF RID: 57775 RVA: 0x003CC750 File Offset: 0x003CA950
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (DrillUITask.m_curMode == DrillUITask.DrillMode)
			{
				if (this.m_drillUIController == null)
				{
					this.m_drillUIController = (this.m_uiCtrlArray[0] as DrillUIController);
					if (!(this.m_drillUIController != null))
					{
						Debug.LogError("DrillUIController is null");
						return;
					}
					this.m_drillUIController.EventOnReturn += this.DrillUIController_OnReturn;
					this.m_drillUIController.EventOnShowHelp += this.DrillUIController_OnShowHelp;
					this.m_drillUIController.EventOnManualButtonClick += this.DrillUIController_OnManualButtonClick;
					this.m_drillUIController.EventOnTrainingButtonClick += this.DrillUIController_OnTrainingButtonClick;
					this.m_drillUIController.EventOnAssistanceTrainingButtonClick += this.DrillUIController_OnAssistanceTrainingButtonClick;
					this.m_drillUIController.EventOnAssistanceStopButtonClick += this.DrillUIController_OnAssistanceStop;
					this.m_drillUIController.EventOnAssistanceGetRewardButtonClick += this.DrillUIController_OnAssistanceGetReward;
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.ManualMode)
			{
				if (this.m_drillSoldierManualUIController == null)
				{
					this.m_drillSoldierManualUIController = (this.m_uiCtrlArray[1] as DrillSoldierManualUIController);
					if (!(this.m_drillSoldierManualUIController != null))
					{
						Debug.LogError("DrillSoldierManualUIController is null");
						return;
					}
					this.m_drillSoldierManualUIController.EventOnReturn += this.DrillSoldierManualUIController_OnReturn;
					this.m_drillSoldierManualUIController.EventOnNeedUpdateView += this.DrillSoldierManualUIController_OnNeedUpdateView;
					this.m_drillSoldierManualUIController.EventOnGoToTraingTech += this.DrillSoldierManualUIController_OnGoToTraingTech;
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TrainingMode)
			{
				if (this.m_drillTrainingUIController == null)
				{
					this.m_drillTrainingUIController = (this.m_uiCtrlArray[2] as DrillTrainingUIController);
					if (!(this.m_drillTrainingUIController != null))
					{
						Debug.LogError("DrillTrainingUIController is null");
						return;
					}
					this.m_drillTrainingUIController.EventOnReturn += this.DrillTrainingUIController_OnReturn;
					this.m_drillTrainingUIController.EventOnAddGold += this.DrillTrainingUIController_OnAddGold;
					this.m_drillTrainingUIController.EventOnAddCrystal += this.DrillTrainingUIController_OnAddCrystal;
					this.m_drillTrainingUIController.EventOnTechLevelup += this.DrillTrainingUIController_OnTechLevelup;
					this.m_drillTrainingUIController.EventOnEvolutionMaterialClick += this.DrillTrainingUIController_OnEvolutionMaterialClick;
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TutorMode && this.m_drillTutorUIController == null)
			{
				this.m_drillTutorUIController = (this.m_uiCtrlArray[3] as DrillTutorUIController);
				if (!(this.m_drillTutorUIController != null))
				{
					Debug.LogError("DrillTutorUIController is null");
					return;
				}
				this.m_drillTutorUIController.EventOnReturn += this.DrillTutorUIController_OnReturn;
				this.m_drillTutorUIController.EventOnShowTutorHelp += this.DrillTutorUIController_OnShowTutorHelp;
				this.m_drillTutorUIController.EventOnConfirmAssistant += this.DrillTutorUIController_OnConfirmAssistant;
			}
		}

		// Token: 0x0600E1B0 RID: 57776 RVA: 0x003CCAC8 File Offset: 0x003CACC8
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_drillUIController != null)
			{
				this.m_drillUIController.EventOnReturn -= this.DrillUIController_OnReturn;
				this.m_drillUIController.EventOnManualButtonClick -= this.DrillUIController_OnManualButtonClick;
				this.m_drillUIController.EventOnTrainingButtonClick -= this.DrillUIController_OnTrainingButtonClick;
				this.m_drillUIController.EventOnAssistanceTrainingButtonClick -= this.DrillUIController_OnAssistanceTrainingButtonClick;
				this.m_drillUIController.EventOnAssistanceStopButtonClick -= this.DrillUIController_OnAssistanceStop;
				this.m_drillUIController.EventOnAssistanceGetRewardButtonClick -= this.DrillUIController_OnAssistanceGetReward;
				this.m_drillUIController.EventOnShowHelp -= this.DrillUIController_OnShowHelp;
				this.m_drillUIController = null;
			}
			if (this.m_drillSoldierManualUIController != null)
			{
				this.m_drillSoldierManualUIController.EventOnReturn -= this.DrillSoldierManualUIController_OnReturn;
				this.m_drillSoldierManualUIController.EventOnNeedUpdateView -= this.DrillSoldierManualUIController_OnNeedUpdateView;
				this.m_drillSoldierManualUIController.EventOnGoToTraingTech -= this.DrillSoldierManualUIController_OnGoToTraingTech;
				this.m_drillSoldierManualUIController = null;
			}
			if (this.m_drillTrainingUIController != null)
			{
				this.m_drillTrainingUIController.EventOnReturn -= this.DrillTrainingUIController_OnReturn;
				this.m_drillTrainingUIController.EventOnAddGold -= this.DrillTrainingUIController_OnAddGold;
				this.m_drillTrainingUIController.EventOnAddCrystal -= this.DrillTrainingUIController_OnAddCrystal;
				this.m_drillTrainingUIController.EventOnTechLevelup -= this.DrillTrainingUIController_OnTechLevelup;
				this.m_drillTrainingUIController.EventOnEvolutionMaterialClick -= this.DrillTrainingUIController_OnEvolutionMaterialClick;
				this.m_drillTrainingUIController = null;
			}
			if (this.m_drillTutorUIController != null)
			{
				this.m_drillTutorUIController.EventOnReturn -= this.DrillTutorUIController_OnReturn;
				this.m_drillTutorUIController.EventOnShowTutorHelp -= this.DrillTutorUIController_OnShowTutorHelp;
				this.m_drillTutorUIController.EventOnConfirmAssistant -= this.DrillTutorUIController_OnConfirmAssistant;
				this.m_drillTutorUIController = null;
			}
		}

		// Token: 0x0600E1B1 RID: 57777 RVA: 0x003CCD2C File Offset: 0x003CAF2C
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600E1B2 RID: 57778 RVA: 0x003CCD94 File Offset: 0x003CAF94
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isNeedShowFadeIn)
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_isNeedShowFadeIn = false;
			}
			this.PushAndPopLayerByState();
			if (DrillUITask.m_curMode == DrillUITask.DrillMode)
			{
				if (base.IsOpeningUI())
				{
					this.m_drillUIController.Open();
				}
				UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
				int structParam = uiintentReturnable.GetStructParam<int>("DrillState");
				uiintentReturnable.SetParam("DrillState", -1);
				this.m_drillUIController.UpdateViewInDrill(structParam);
			}
			else if (DrillUITask.m_curMode == DrillUITask.ManualMode)
			{
				this.m_drillSoldierManualUIController.UpdateViewInDrillSoliderManual(this.m_curSoldierInfoList, this.m_totalSoldierManualPage);
			}
			else if (DrillUITask.m_curMode == DrillUITask.TrainingMode)
			{
				if (DrillUITask.m_getSoldierTechId != 0)
				{
					this.m_drillTrainingUIController.UpdateViewInDrillTraining(DrillUITask.m_courseId, DrillUITask.m_getSoldierTechId);
					DrillUITask.m_getSoldierTechId = 0;
				}
				else
				{
					this.m_drillTrainingUIController.UpdateViewInDrillTraining(DrillUITask.m_courseId, 0);
				}
			}
			else if (DrillUITask.m_curMode == DrillUITask.TutorMode)
			{
				this.m_drillTutorUIController.UpdateViewInDrillTutor(this.m_slot);
			}
		}

		// Token: 0x0600E1B3 RID: 57779 RVA: 0x003CCF24 File Offset: 0x003CB124
		private void PushAndPopLayerByState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PushAndPopLayerByState_hotfix != null)
			{
				this.m_PushAndPopLayerByState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (DrillUITask.m_curMode == DrillUITask.DrillMode)
			{
				SceneLayerBase sceneLayerBase = this.m_layerArray[0];
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
				this.m_curLayerDescIndex = 0;
			}
			else if (DrillUITask.m_curMode == DrillUITask.ManualMode)
			{
				SceneLayerBase sceneLayerBase2 = this.m_layerArray[1];
				if (sceneLayerBase2.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase2);
				}
				this.m_curLayerDescIndex = 1;
			}
			else if (DrillUITask.m_curMode == DrillUITask.TrainingMode)
			{
				SceneLayerBase sceneLayerBase3 = this.m_layerArray[2];
				if (sceneLayerBase3.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase3);
				}
				this.m_curLayerDescIndex = 2;
			}
			else if (DrillUITask.m_curMode == DrillUITask.TutorMode)
			{
				SceneLayerBase sceneLayerBase4 = this.m_layerArray[3];
				if (sceneLayerBase4.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase4);
				}
				this.m_curLayerDescIndex = 3;
			}
			for (int i = 0; i < this.m_layerArray.Length; i++)
			{
				if (i != this.m_curLayerDescIndex)
				{
					SceneLayerBase sceneLayerBase5 = this.m_layerArray[i];
					if (sceneLayerBase5 != null && sceneLayerBase5.State == SceneLayerBase.LayerState.InStack)
					{
						SceneManager.Instance.PopLayer(sceneLayerBase5);
					}
				}
			}
		}

		// Token: 0x0600E1B4 RID: 57780 RVA: 0x003CD0E4 File Offset: 0x003CB2E4
		private void DrillUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnReturn_hotfix != null)
			{
				this.m_DrillUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				DrillUITask.m_curMode = DrillUITask.DrillMode;
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E1B5 RID: 57781 RVA: 0x003CD168 File Offset: 0x003CB368
		private void DrillUIController_OnManualButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnManualButtonClick_hotfix != null)
			{
				this.m_DrillUIController_OnManualButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_isNeedShowFadeIn = true;
				this.m_isNeedShowFadeIn = true;
				DrillUITask.m_curMode = DrillUITask.ManualMode;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E1B6 RID: 57782 RVA: 0x003CD1EC File Offset: 0x003CB3EC
		private void DrillUIController_OnTrainingButtonClick(int courseId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnTrainingButtonClickInt32_hotfix != null)
			{
				this.m_DrillUIController_OnTrainingButtonClickInt32_hotfix.call(new object[]
				{
					this,
					courseId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DrillUITask.m_courseId = courseId;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_isNeedShowFadeIn = true;
				DrillUITask.m_curMode = DrillUITask.TrainingMode;
				DrillUITask.m_trainingModeFrom = DrillUITask.DrillMode;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E1B7 RID: 57783 RVA: 0x003CD284 File Offset: 0x003CB484
		private void DrillUIController_OnAssistanceTrainingButtonClick(int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnAssistanceTrainingButtonClickInt32_hotfix != null)
			{
				this.m_DrillUIController_OnAssistanceTrainingButtonClickInt32_hotfix.call(new object[]
				{
					this,
					slot2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			DrillUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				$this.m_isNeedShowFadeIn = true;
				DrillUITask.m_curMode = DrillUITask.TutorMode;
				$this.m_slot = slot;
				$this.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E1B8 RID: 57784 RVA: 0x003CD32C File Offset: 0x003CB52C
		private void DrillUIController_OnAssistanceStop(int taskId, int slot, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnAssistanceStopInt32Int32Action_hotfix != null)
			{
				this.m_DrillUIController_OnAssistanceStopInt32Int32Action_hotfix.call(new object[]
				{
					this,
					taskId,
					slot,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			DrillUITask $this = this;
			HeroAssistantCancelTaskNetTask heroAssistantCancelTaskNetTask = new HeroAssistantCancelTaskNetTask(taskId, slot);
			heroAssistantCancelTaskNetTask.EventOnStop += delegate(Task task)
			{
				HeroAssistantCancelTaskNetTask heroAssistantCancelTaskNetTask2 = task as HeroAssistantCancelTaskNetTask;
				if (heroAssistantCancelTaskNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroAssistantCancelTaskNetTask2.Result, 2f, null, true);
				}
			};
			heroAssistantCancelTaskNetTask.Start(null);
		}

		// Token: 0x0600E1B9 RID: 57785 RVA: 0x003CD3F4 File Offset: 0x003CB5F4
		private void DrillUIController_OnAssistanceGetReward(int taskId, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnAssistanceGetRewardInt32Int32_hotfix != null)
			{
				this.m_DrillUIController_OnAssistanceGetRewardInt32Int32_hotfix.call(new object[]
				{
					this,
					taskId,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroAssistantClaimRewardNetTask heroAssistantClaimRewardNetTask = new HeroAssistantClaimRewardNetTask(taskId, slot);
			heroAssistantClaimRewardNetTask.EventOnStop += delegate(Task task)
			{
				HeroAssistantClaimRewardNetTask heroAssistantClaimRewardNetTask2 = task as HeroAssistantClaimRewardNetTask;
				if (heroAssistantClaimRewardNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
					List<Goods> rewards = heroAssistantClaimRewardNetTask2.Rewards;
					if (rewards != null && rewards.Count != 0)
					{
						GetRewardGoodsUITask.StartUITask(rewards);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroAssistantClaimRewardNetTask2.Result, 2f, null, true);
				}
			};
			heroAssistantClaimRewardNetTask.Start(null);
		}

		// Token: 0x0600E1BA RID: 57786 RVA: 0x003CD498 File Offset: 0x003CB698
		private void DrillSoldierManualUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillSoldierManualUIController_OnReturn_hotfix != null)
			{
				this.m_DrillSoldierManualUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_drillSoldierManualUIController.ResetData();
				this.m_isNeedShowFadeIn = true;
				DrillUITask.m_curMode = DrillUITask.DrillMode;
				this.m_curSoldierManualPage = 0;
				this.m_soldierFilterRank = 0;
				this.m_armyTag = ArmyTag.ArmyTag_None;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E1BB RID: 57787 RVA: 0x003CD51C File Offset: 0x003CB71C
		private void DrillUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillUIController_OnShowHelp_hotfix != null)
			{
				this.m_DrillUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Drill);
		}

		// Token: 0x0600E1BC RID: 57788 RVA: 0x003CD588 File Offset: 0x003CB788
		private void DrillSoldierManualUIController_OnNeedUpdateView(int curPage, int rank, ArmyTag armyTag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillSoldierManualUIController_OnNeedUpdateViewInt32Int32ArmyTag_hotfix != null)
			{
				this.m_DrillSoldierManualUIController_OnNeedUpdateViewInt32Int32ArmyTag_hotfix.call(new object[]
				{
					this,
					curPage,
					rank,
					armyTag
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curSoldierManualPage = curPage;
			this.m_soldierFilterRank = rank;
			this.m_armyTag = armyTag;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600E1BD RID: 57789 RVA: 0x003CD638 File Offset: 0x003CB838
		private void DrillSoldierManualUIController_OnGoToTraingTech(int techId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillSoldierManualUIController_OnGoToTraingTechInt32_hotfix != null)
			{
				this.m_DrillSoldierManualUIController_OnGoToTraingTechInt32_hotfix.call(new object[]
				{
					this,
					techId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DrillUITask.m_getSoldierTechId = techId;
			DrillUITask.m_curMode = DrillUITask.TrainingMode;
			DrillUITask.m_trainingModeFrom = DrillUITask.ManualMode;
			DrillUITask.m_courseId = this.m_playerContext.GetTrainingCourseIdByTechId(DrillUITask.m_getSoldierTechId);
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x0600E1BE RID: 57790 RVA: 0x003CD6E4 File Offset: 0x003CB8E4
		private void DrillTrainingUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTrainingUIController_OnReturn_hotfix != null)
			{
				this.m_DrillTrainingUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (DrillUITask.m_trainingModeFrom == DrillUITask.DrillMode)
			{
				CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
				{
					this.m_isNeedShowFadeIn = true;
					DrillUITask.m_curMode = DrillUITask.DrillMode;
					base.StartUpdatePipeLine(null, false, false, true);
				}, FadeStyle.Black, -1f, -1f);
			}
			else if (DrillUITask.m_trainingModeFrom == DrillUITask.ManualMode)
			{
				CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
				{
					this.m_isNeedShowFadeIn = true;
					DrillUITask.m_curMode = DrillUITask.ManualMode;
					base.StartUpdatePipeLine(null, false, false, true);
				}, FadeStyle.Black, -1f, -1f);
			}
			else if (DrillUITask.m_trainingModeFrom == "HeroDetail")
			{
				this.DrillUIController_OnReturn();
			}
		}

		// Token: 0x0600E1BF RID: 57791 RVA: 0x003CD7D4 File Offset: 0x003CB9D4
		private void DrillTrainingUIController_OnAddGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTrainingUIController_OnAddGold_hotfix != null)
			{
				this.m_DrillTrainingUIController_OnAddGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x0600E1C0 RID: 57792 RVA: 0x003CD84C File Offset: 0x003CBA4C
		private void DrillTrainingUIController_OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTrainingUIController_OnAddCrystal_hotfix != null)
			{
				this.m_DrillTrainingUIController_OnAddCrystal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
		}

		// Token: 0x0600E1C1 RID: 57793 RVA: 0x003CD8C4 File Offset: 0x003CBAC4
		private void DrillTrainingUIController_OnTechLevelup(int techId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTrainingUIController_OnTechLevelupInt32Action_hotfix != null)
			{
				this.m_DrillTrainingUIController_OnTechLevelupInt32Action_hotfix.call(new object[]
				{
					this,
					techId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			DrillUITask $this = this;
			TechLevelupNetTask techLevelupNetTask = new TechLevelupNetTask(techId);
			techLevelupNetTask.EventOnStop += delegate(Task task)
			{
				TechLevelupNetTask techLevelupNetTask2 = task as TechLevelupNetTask;
				if (techLevelupNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(techLevelupNetTask2.Result, 2f, null, true);
				}
			};
			techLevelupNetTask.Start(null);
		}

		// Token: 0x0600E1C2 RID: 57794 RVA: 0x003CD97C File Offset: 0x003CBB7C
		private void DrillTrainingUIController_OnEvolutionMaterialClick(GoodsType goodsType, int goodsId, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTrainingUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_DrillTrainingUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId,
					needCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathUITask.StartUITask(goodsType, goodsId, new Action<GetPathData, NeedGoods>(this.DrillTrainingUIController_OnGotoGetPath), needCount);
		}

		// Token: 0x0600E1C3 RID: 57795 RVA: 0x003CDA24 File Offset: 0x003CBC24
		private void DrillTrainingUIController_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTrainingUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix != null)
			{
				this.m_DrillTrainingUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix.call(new object[]
				{
					this,
					getPath,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			WorldUITask.StartGetPathTargetUITask(getPath, this.m_currIntent, needGoods);
		}

		// Token: 0x0600E1C4 RID: 57796 RVA: 0x003CDAB8 File Offset: 0x003CBCB8
		private void DrillTutorUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTutorUIController_OnReturn_hotfix != null)
			{
				this.m_DrillTutorUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				ChatUITask.PauseUITask();
				this.m_isNeedShowFadeIn = true;
				DrillUITask.m_curMode = DrillUITask.DrillMode;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x003CDB3C File Offset: 0x003CBD3C
		private void DrillTutorUIController_OnShowTutorHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTutorUIController_OnShowTutorHelp_hotfix != null)
			{
				this.m_DrillTutorUIController_OnShowTutorHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_DrillTutor);
		}

		// Token: 0x0600E1C6 RID: 57798 RVA: 0x003CDBA8 File Offset: 0x003CBDA8
		private void DrillTutorUIController_OnConfirmAssistant(int taskId, List<int> heroId, int workSeconds, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrillTutorUIController_OnConfirmAssistantInt32List`1Int32Int32_hotfix != null)
			{
				this.m_DrillTutorUIController_OnConfirmAssistantInt32List`1Int32Int32_hotfix.call(new object[]
				{
					this,
					taskId,
					heroId,
					workSeconds,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroAssistantAssignToTaskNetTask heroAssistantAssignToTaskNetTask = new HeroAssistantAssignToTaskNetTask(taskId, heroId, workSeconds, slot);
			heroAssistantAssignToTaskNetTask.EventOnStop += delegate(Task task)
			{
				HeroAssistantAssignToTaskNetTask heroAssistantAssignToTaskNetTask2 = task as HeroAssistantAssignToTaskNetTask;
				if (heroAssistantAssignToTaskNetTask2.Result == 0)
				{
					this.m_drillTutorUIController.PlayStartTeachEffect(delegate
					{
						this.DrillTutorUIController_OnReturn();
					});
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroAssistantAssignToTaskNetTask2.Result, 2f, null, true);
				}
			};
			heroAssistantAssignToTaskNetTask.Start(null);
		}

		// Token: 0x0600E1C7 RID: 57799 RVA: 0x003CDC70 File Offset: 0x003CBE70
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_drillUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateTimeText();
			}
		}

		// Token: 0x0600E1C8 RID: 57800 RVA: 0x003CDD10 File Offset: 0x003CBF10
		private void UpdateTimeText()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTimeText_hotfix != null)
			{
				this.m_UpdateTimeText_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroAssistantsTaskAssignment> assignedHeroAssistantsTask = this.m_playerContext.GetAssignedHeroAssistantsTask();
			foreach (HeroAssistantsTaskAssignment heroAssistantsTaskAssignment in assignedHeroAssistantsTask)
			{
				TimeSpan taskRemainingTime = this.m_playerContext.GetTaskRemainingTime(heroAssistantsTaskAssignment.TaskId, heroAssistantsTaskAssignment.Slot);
				this.m_drillUIController.SetTeamTime(heroAssistantsTaskAssignment.Slot, taskRemainingTime);
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x0600E1C9 RID: 57801 RVA: 0x003CDDEC File Offset: 0x003CBFEC
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x0600E1CA RID: 57802 RVA: 0x003CDE60 File Offset: 0x003CC060
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x0600E1CB RID: 57803 RVA: 0x003CDED4 File Offset: 0x003CC0D4
		// (set) Token: 0x0600E1CC RID: 57804 RVA: 0x003CDEF4 File Offset: 0x003CC0F4
		[DoNotToLua]
		public new DrillUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DrillUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E1CD RID: 57805 RVA: 0x003CDF00 File Offset: 0x003CC100
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600E1CE RID: 57806 RVA: 0x003CDF0C File Offset: 0x003CC10C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600E1CF RID: 57807 RVA: 0x003CDF14 File Offset: 0x003CC114
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600E1D0 RID: 57808 RVA: 0x003CDF1C File Offset: 0x003CC11C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600E1D1 RID: 57809 RVA: 0x003CDF28 File Offset: 0x003CC128
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600E1D2 RID: 57810 RVA: 0x003CDF34 File Offset: 0x003CC134
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600E1D3 RID: 57811 RVA: 0x003CDF40 File Offset: 0x003CC140
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x003CDF48 File Offset: 0x003CC148
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x003CDF50 File Offset: 0x003CC150
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x003CDF58 File Offset: 0x003CC158
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x003CDF60 File Offset: 0x003CC160
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x003CDF68 File Offset: 0x003CC168
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x003CDF70 File Offset: 0x003CC170
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600E1DA RID: 57818 RVA: 0x003CDF78 File Offset: 0x003CC178
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600E1DB RID: 57819 RVA: 0x003CDF84 File Offset: 0x003CC184
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600E1DC RID: 57820 RVA: 0x003CDF90 File Offset: 0x003CC190
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x003CDF9C File Offset: 0x003CC19C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x003CDFA8 File Offset: 0x003CC1A8
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x003CDFB0 File Offset: 0x003CC1B0
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x003CDFB8 File Offset: 0x003CC1B8
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x003CDFC0 File Offset: 0x003CC1C0
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x003CDFC8 File Offset: 0x003CC1C8
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600E1E3 RID: 57827 RVA: 0x003CDFD0 File Offset: 0x003CC1D0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600E1EF RID: 57839 RVA: 0x003CE1F4 File Offset: 0x003CC3F4
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_SetTotalSoldierInfoListWithFilter_hotfix = (luaObj.RawGet("SetTotalSoldierInfoListWithFilter") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_CollectAllStaticResDescForLoad_hotfix = (luaObj.RawGet("CollectAllStaticResDescForLoad") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PushAndPopLayerByState_hotfix = (luaObj.RawGet("PushAndPopLayerByState") as LuaFunction);
					this.m_DrillUIController_OnReturn_hotfix = (luaObj.RawGet("DrillUIController_OnReturn") as LuaFunction);
					this.m_DrillUIController_OnManualButtonClick_hotfix = (luaObj.RawGet("DrillUIController_OnManualButtonClick") as LuaFunction);
					this.m_DrillUIController_OnTrainingButtonClickInt32_hotfix = (luaObj.RawGet("DrillUIController_OnTrainingButtonClick") as LuaFunction);
					this.m_DrillUIController_OnAssistanceTrainingButtonClickInt32_hotfix = (luaObj.RawGet("DrillUIController_OnAssistanceTrainingButtonClick") as LuaFunction);
					this.m_DrillUIController_OnAssistanceStopInt32Int32Action_hotfix = (luaObj.RawGet("DrillUIController_OnAssistanceStop") as LuaFunction);
					this.m_DrillUIController_OnAssistanceGetRewardInt32Int32_hotfix = (luaObj.RawGet("DrillUIController_OnAssistanceGetReward") as LuaFunction);
					this.m_DrillSoldierManualUIController_OnReturn_hotfix = (luaObj.RawGet("DrillSoldierManualUIController_OnReturn") as LuaFunction);
					this.m_DrillUIController_OnShowHelp_hotfix = (luaObj.RawGet("DrillUIController_OnShowHelp") as LuaFunction);
					this.m_DrillSoldierManualUIController_OnNeedUpdateViewInt32Int32ArmyTag_hotfix = (luaObj.RawGet("DrillSoldierManualUIController_OnNeedUpdateView") as LuaFunction);
					this.m_DrillSoldierManualUIController_OnGoToTraingTechInt32_hotfix = (luaObj.RawGet("DrillSoldierManualUIController_OnGoToTraingTech") as LuaFunction);
					this.m_DrillTrainingUIController_OnReturn_hotfix = (luaObj.RawGet("DrillTrainingUIController_OnReturn") as LuaFunction);
					this.m_DrillTrainingUIController_OnAddGold_hotfix = (luaObj.RawGet("DrillTrainingUIController_OnAddGold") as LuaFunction);
					this.m_DrillTrainingUIController_OnAddCrystal_hotfix = (luaObj.RawGet("DrillTrainingUIController_OnAddCrystal") as LuaFunction);
					this.m_DrillTrainingUIController_OnTechLevelupInt32Action_hotfix = (luaObj.RawGet("DrillTrainingUIController_OnTechLevelup") as LuaFunction);
					this.m_DrillTrainingUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("DrillTrainingUIController_OnEvolutionMaterialClick") as LuaFunction);
					this.m_DrillTrainingUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix = (luaObj.RawGet("DrillTrainingUIController_OnGotoGetPath") as LuaFunction);
					this.m_DrillTutorUIController_OnReturn_hotfix = (luaObj.RawGet("DrillTutorUIController_OnReturn") as LuaFunction);
					this.m_DrillTutorUIController_OnShowTutorHelp_hotfix = (luaObj.RawGet("DrillTutorUIController_OnShowTutorHelp") as LuaFunction);
					this.m_DrillTutorUIController_OnConfirmAssistantInt32List`1Int32Int32_hotfix = (luaObj.RawGet("DrillTutorUIController_OnConfirmAssistant") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateTimeText_hotfix = (luaObj.RawGet("UpdateTimeText") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E1F0 RID: 57840 RVA: 0x003CE5F8 File Offset: 0x003CC7F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DrillUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040088DC RID: 35036
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "DrillUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Drill_ABS/Prefab/DrillUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "SoldierManualUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Drill_ABS/Prefab/SoldierManualUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "TrainingSkillUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Drill_ABS/Prefab/TrainingSkillUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "TutorUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Drill_ABS/Prefab/TutorUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			}
		};

		// Token: 0x040088DD RID: 35037
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "DrillUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.DrillUIController"),
				m_ctrlName = "DrillUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "SoldierManualUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.DrillSoldierManualUIController"),
				m_ctrlName = "DrillSoldierManualUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TrainingSkillUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.DrillTrainingUIController"),
				m_ctrlName = "DrillTrainingUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TutorUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.DrillTutorUIController"),
				m_ctrlName = "DrillTutorUIController"
			}
		};

		// Token: 0x040088DE RID: 35038
		public static string DrillMode = "Drill";

		// Token: 0x040088DF RID: 35039
		public static string ManualMode = "Manual";

		// Token: 0x040088E0 RID: 35040
		public static string TrainingMode = "Training";

		// Token: 0x040088E1 RID: 35041
		public static string TutorMode = "Tutor";

		// Token: 0x040088E2 RID: 35042
		private static string m_curMode = "Drill";

		// Token: 0x040088E3 RID: 35043
		private DrillUIController m_drillUIController;

		// Token: 0x040088E4 RID: 35044
		private DrillSoldierManualUIController m_drillSoldierManualUIController;

		// Token: 0x040088E5 RID: 35045
		private DrillTrainingUIController m_drillTrainingUIController;

		// Token: 0x040088E6 RID: 35046
		private DrillTutorUIController m_drillTutorUIController;

		// Token: 0x040088E7 RID: 35047
		private static string m_trainingModeFrom = DrillUITask.DrillMode;

		// Token: 0x040088E8 RID: 35048
		private static int m_courseId;

		// Token: 0x040088E9 RID: 35049
		private int m_curLayerDescIndex;

		// Token: 0x040088EA RID: 35050
		private List<ConfigDataSoldierInfo> m_totalSoldierInfoList = new List<ConfigDataSoldierInfo>();

		// Token: 0x040088EB RID: 35051
		private List<ConfigDataSoldierInfo> m_curSoldierInfoList = new List<ConfigDataSoldierInfo>();

		// Token: 0x040088EC RID: 35052
		private int m_totalSoldierManualPage;

		// Token: 0x040088ED RID: 35053
		private int m_curSoldierManualPage;

		// Token: 0x040088EE RID: 35054
		private int m_soldierFilterRank;

		// Token: 0x040088EF RID: 35055
		private ArmyTag m_armyTag;

		// Token: 0x040088F0 RID: 35056
		private int m_nowSeconds;

		// Token: 0x040088F1 RID: 35057
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040088F2 RID: 35058
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040088F3 RID: 35059
		private int m_slot;

		// Token: 0x040088F4 RID: 35060
		private static int m_getSoldierTechId;

		// Token: 0x040088F5 RID: 35061
		private bool m_isNeedShowFadeIn;

		// Token: 0x040088F6 RID: 35062
		[DoNotToLua]
		private DrillUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040088F7 RID: 35063
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x040088F8 RID: 35064
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040088F9 RID: 35065
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040088FA RID: 35066
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040088FB RID: 35067
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040088FC RID: 35068
		private LuaFunction m_SetTotalSoldierInfoListWithFilter_hotfix;

		// Token: 0x040088FD RID: 35069
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x040088FE RID: 35070
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x040088FF RID: 35071
		private LuaFunction m_CollectAllStaticResDescForLoad_hotfix;

		// Token: 0x04008900 RID: 35072
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008901 RID: 35073
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008902 RID: 35074
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04008903 RID: 35075
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008904 RID: 35076
		private LuaFunction m_PushAndPopLayerByState_hotfix;

		// Token: 0x04008905 RID: 35077
		private LuaFunction m_DrillUIController_OnReturn_hotfix;

		// Token: 0x04008906 RID: 35078
		private LuaFunction m_DrillUIController_OnManualButtonClick_hotfix;

		// Token: 0x04008907 RID: 35079
		private LuaFunction m_DrillUIController_OnTrainingButtonClickInt32_hotfix;

		// Token: 0x04008908 RID: 35080
		private LuaFunction m_DrillUIController_OnAssistanceTrainingButtonClickInt32_hotfix;

		// Token: 0x04008909 RID: 35081
		private LuaFunction m_DrillUIController_OnAssistanceStopInt32Int32Action_hotfix;

		// Token: 0x0400890A RID: 35082
		private LuaFunction m_DrillUIController_OnAssistanceGetRewardInt32Int32_hotfix;

		// Token: 0x0400890B RID: 35083
		private LuaFunction m_DrillSoldierManualUIController_OnReturn_hotfix;

		// Token: 0x0400890C RID: 35084
		private LuaFunction m_DrillUIController_OnShowHelp_hotfix;

		// Token: 0x0400890D RID: 35085
		private LuaFunction m_DrillSoldierManualUIController_OnNeedUpdateViewInt32Int32ArmyTag_hotfix;

		// Token: 0x0400890E RID: 35086
		private LuaFunction m_DrillSoldierManualUIController_OnGoToTraingTechInt32_hotfix;

		// Token: 0x0400890F RID: 35087
		private LuaFunction m_DrillTrainingUIController_OnReturn_hotfix;

		// Token: 0x04008910 RID: 35088
		private LuaFunction m_DrillTrainingUIController_OnAddGold_hotfix;

		// Token: 0x04008911 RID: 35089
		private LuaFunction m_DrillTrainingUIController_OnAddCrystal_hotfix;

		// Token: 0x04008912 RID: 35090
		private LuaFunction m_DrillTrainingUIController_OnTechLevelupInt32Action_hotfix;

		// Token: 0x04008913 RID: 35091
		private LuaFunction m_DrillTrainingUIController_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x04008914 RID: 35092
		private LuaFunction m_DrillTrainingUIController_OnGotoGetPathGetPathDataNeedGoods_hotfix;

		// Token: 0x04008915 RID: 35093
		private LuaFunction m_DrillTutorUIController_OnReturn_hotfix;

		// Token: 0x04008916 RID: 35094
		private LuaFunction m_DrillTutorUIController_OnShowTutorHelp_hotfix;

		// Token: 0x04008917 RID: 35095
		private LuaFunction m_DrillTutorUIController_OnConfirmAssistantInt32List;

		// Token: 0x04008918 RID: 35096
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x04008919 RID: 35097
		private LuaFunction m_UpdateTimeText_hotfix;

		// Token: 0x0400891A RID: 35098
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400891B RID: 35099
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000C62 RID: 3170
		public new class LuaExportHelper
		{
			// Token: 0x0600E1F1 RID: 57841 RVA: 0x003CE660 File Offset: 0x003CC860
			public LuaExportHelper(DrillUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E1F2 RID: 57842 RVA: 0x003CE670 File Offset: 0x003CC870
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600E1F3 RID: 57843 RVA: 0x003CE680 File Offset: 0x003CC880
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600E1F4 RID: 57844 RVA: 0x003CE690 File Offset: 0x003CC890
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600E1F5 RID: 57845 RVA: 0x003CE6A0 File Offset: 0x003CC8A0
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600E1F6 RID: 57846 RVA: 0x003CE6B0 File Offset: 0x003CC8B0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600E1F7 RID: 57847 RVA: 0x003CE6C0 File Offset: 0x003CC8C0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600E1F8 RID: 57848 RVA: 0x003CE6D0 File Offset: 0x003CC8D0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600E1F9 RID: 57849 RVA: 0x003CE6E0 File Offset: 0x003CC8E0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600E1FA RID: 57850 RVA: 0x003CE6F0 File Offset: 0x003CC8F0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600E1FB RID: 57851 RVA: 0x003CE700 File Offset: 0x003CC900
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600E1FC RID: 57852 RVA: 0x003CE710 File Offset: 0x003CC910
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600E1FD RID: 57853 RVA: 0x003CE720 File Offset: 0x003CC920
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600E1FE RID: 57854 RVA: 0x003CE730 File Offset: 0x003CC930
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600E1FF RID: 57855 RVA: 0x003CE740 File Offset: 0x003CC940
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600E200 RID: 57856 RVA: 0x003CE750 File Offset: 0x003CC950
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600E201 RID: 57857 RVA: 0x003CE760 File Offset: 0x003CC960
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600E202 RID: 57858 RVA: 0x003CE770 File Offset: 0x003CC970
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600E203 RID: 57859 RVA: 0x003CE780 File Offset: 0x003CC980
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600E204 RID: 57860 RVA: 0x003CE790 File Offset: 0x003CC990
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600E205 RID: 57861 RVA: 0x003CE7A0 File Offset: 0x003CC9A0
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600E206 RID: 57862 RVA: 0x003CE7B0 File Offset: 0x003CC9B0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600E207 RID: 57863 RVA: 0x003CE7C0 File Offset: 0x003CC9C0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600E208 RID: 57864 RVA: 0x003CE7D0 File Offset: 0x003CC9D0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002BD0 RID: 11216
			// (get) Token: 0x0600E209 RID: 57865 RVA: 0x003CE7E0 File Offset: 0x003CC9E0
			// (set) Token: 0x0600E20A RID: 57866 RVA: 0x003CE7F0 File Offset: 0x003CC9F0
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17002BD1 RID: 11217
			// (get) Token: 0x0600E20B RID: 57867 RVA: 0x003CE800 File Offset: 0x003CCA00
			// (set) Token: 0x0600E20C RID: 57868 RVA: 0x003CE810 File Offset: 0x003CCA10
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17002BD2 RID: 11218
			// (get) Token: 0x0600E20D RID: 57869 RVA: 0x003CE820 File Offset: 0x003CCA20
			// (set) Token: 0x0600E20E RID: 57870 RVA: 0x003CE828 File Offset: 0x003CCA28
			public static string m_curMode
			{
				get
				{
					return DrillUITask.m_curMode;
				}
				set
				{
					DrillUITask.m_curMode = value;
				}
			}

			// Token: 0x17002BD3 RID: 11219
			// (get) Token: 0x0600E20F RID: 57871 RVA: 0x003CE830 File Offset: 0x003CCA30
			// (set) Token: 0x0600E210 RID: 57872 RVA: 0x003CE840 File Offset: 0x003CCA40
			public DrillUIController m_drillUIController
			{
				get
				{
					return this.m_owner.m_drillUIController;
				}
				set
				{
					this.m_owner.m_drillUIController = value;
				}
			}

			// Token: 0x17002BD4 RID: 11220
			// (get) Token: 0x0600E211 RID: 57873 RVA: 0x003CE850 File Offset: 0x003CCA50
			// (set) Token: 0x0600E212 RID: 57874 RVA: 0x003CE860 File Offset: 0x003CCA60
			public DrillSoldierManualUIController m_drillSoldierManualUIController
			{
				get
				{
					return this.m_owner.m_drillSoldierManualUIController;
				}
				set
				{
					this.m_owner.m_drillSoldierManualUIController = value;
				}
			}

			// Token: 0x17002BD5 RID: 11221
			// (get) Token: 0x0600E213 RID: 57875 RVA: 0x003CE870 File Offset: 0x003CCA70
			// (set) Token: 0x0600E214 RID: 57876 RVA: 0x003CE880 File Offset: 0x003CCA80
			public DrillTrainingUIController m_drillTrainingUIController
			{
				get
				{
					return this.m_owner.m_drillTrainingUIController;
				}
				set
				{
					this.m_owner.m_drillTrainingUIController = value;
				}
			}

			// Token: 0x17002BD6 RID: 11222
			// (get) Token: 0x0600E215 RID: 57877 RVA: 0x003CE890 File Offset: 0x003CCA90
			// (set) Token: 0x0600E216 RID: 57878 RVA: 0x003CE8A0 File Offset: 0x003CCAA0
			public DrillTutorUIController m_drillTutorUIController
			{
				get
				{
					return this.m_owner.m_drillTutorUIController;
				}
				set
				{
					this.m_owner.m_drillTutorUIController = value;
				}
			}

			// Token: 0x17002BD7 RID: 11223
			// (get) Token: 0x0600E217 RID: 57879 RVA: 0x003CE8B0 File Offset: 0x003CCAB0
			// (set) Token: 0x0600E218 RID: 57880 RVA: 0x003CE8B8 File Offset: 0x003CCAB8
			public static string m_trainingModeFrom
			{
				get
				{
					return DrillUITask.m_trainingModeFrom;
				}
				set
				{
					DrillUITask.m_trainingModeFrom = value;
				}
			}

			// Token: 0x17002BD8 RID: 11224
			// (get) Token: 0x0600E219 RID: 57881 RVA: 0x003CE8C0 File Offset: 0x003CCAC0
			// (set) Token: 0x0600E21A RID: 57882 RVA: 0x003CE8C8 File Offset: 0x003CCAC8
			public static int m_courseId
			{
				get
				{
					return DrillUITask.m_courseId;
				}
				set
				{
					DrillUITask.m_courseId = value;
				}
			}

			// Token: 0x17002BD9 RID: 11225
			// (get) Token: 0x0600E21B RID: 57883 RVA: 0x003CE8D0 File Offset: 0x003CCAD0
			// (set) Token: 0x0600E21C RID: 57884 RVA: 0x003CE8E0 File Offset: 0x003CCAE0
			public int m_curLayerDescIndex
			{
				get
				{
					return this.m_owner.m_curLayerDescIndex;
				}
				set
				{
					this.m_owner.m_curLayerDescIndex = value;
				}
			}

			// Token: 0x17002BDA RID: 11226
			// (get) Token: 0x0600E21D RID: 57885 RVA: 0x003CE8F0 File Offset: 0x003CCAF0
			// (set) Token: 0x0600E21E RID: 57886 RVA: 0x003CE900 File Offset: 0x003CCB00
			public List<ConfigDataSoldierInfo> m_totalSoldierInfoList
			{
				get
				{
					return this.m_owner.m_totalSoldierInfoList;
				}
				set
				{
					this.m_owner.m_totalSoldierInfoList = value;
				}
			}

			// Token: 0x17002BDB RID: 11227
			// (get) Token: 0x0600E21F RID: 57887 RVA: 0x003CE910 File Offset: 0x003CCB10
			// (set) Token: 0x0600E220 RID: 57888 RVA: 0x003CE920 File Offset: 0x003CCB20
			public List<ConfigDataSoldierInfo> m_curSoldierInfoList
			{
				get
				{
					return this.m_owner.m_curSoldierInfoList;
				}
				set
				{
					this.m_owner.m_curSoldierInfoList = value;
				}
			}

			// Token: 0x17002BDC RID: 11228
			// (get) Token: 0x0600E221 RID: 57889 RVA: 0x003CE930 File Offset: 0x003CCB30
			// (set) Token: 0x0600E222 RID: 57890 RVA: 0x003CE940 File Offset: 0x003CCB40
			public int m_totalSoldierManualPage
			{
				get
				{
					return this.m_owner.m_totalSoldierManualPage;
				}
				set
				{
					this.m_owner.m_totalSoldierManualPage = value;
				}
			}

			// Token: 0x17002BDD RID: 11229
			// (get) Token: 0x0600E223 RID: 57891 RVA: 0x003CE950 File Offset: 0x003CCB50
			// (set) Token: 0x0600E224 RID: 57892 RVA: 0x003CE960 File Offset: 0x003CCB60
			public int m_curSoldierManualPage
			{
				get
				{
					return this.m_owner.m_curSoldierManualPage;
				}
				set
				{
					this.m_owner.m_curSoldierManualPage = value;
				}
			}

			// Token: 0x17002BDE RID: 11230
			// (get) Token: 0x0600E225 RID: 57893 RVA: 0x003CE970 File Offset: 0x003CCB70
			// (set) Token: 0x0600E226 RID: 57894 RVA: 0x003CE980 File Offset: 0x003CCB80
			public int m_soldierFilterRank
			{
				get
				{
					return this.m_owner.m_soldierFilterRank;
				}
				set
				{
					this.m_owner.m_soldierFilterRank = value;
				}
			}

			// Token: 0x17002BDF RID: 11231
			// (get) Token: 0x0600E227 RID: 57895 RVA: 0x003CE990 File Offset: 0x003CCB90
			// (set) Token: 0x0600E228 RID: 57896 RVA: 0x003CE9A0 File Offset: 0x003CCBA0
			public ArmyTag m_armyTag
			{
				get
				{
					return this.m_owner.m_armyTag;
				}
				set
				{
					this.m_owner.m_armyTag = value;
				}
			}

			// Token: 0x17002BE0 RID: 11232
			// (get) Token: 0x0600E229 RID: 57897 RVA: 0x003CE9B0 File Offset: 0x003CCBB0
			// (set) Token: 0x0600E22A RID: 57898 RVA: 0x003CE9C0 File Offset: 0x003CCBC0
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x17002BE1 RID: 11233
			// (get) Token: 0x0600E22B RID: 57899 RVA: 0x003CE9D0 File Offset: 0x003CCBD0
			// (set) Token: 0x0600E22C RID: 57900 RVA: 0x003CE9E0 File Offset: 0x003CCBE0
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

			// Token: 0x17002BE2 RID: 11234
			// (get) Token: 0x0600E22D RID: 57901 RVA: 0x003CE9F0 File Offset: 0x003CCBF0
			// (set) Token: 0x0600E22E RID: 57902 RVA: 0x003CEA00 File Offset: 0x003CCC00
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

			// Token: 0x17002BE3 RID: 11235
			// (get) Token: 0x0600E22F RID: 57903 RVA: 0x003CEA10 File Offset: 0x003CCC10
			// (set) Token: 0x0600E230 RID: 57904 RVA: 0x003CEA20 File Offset: 0x003CCC20
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

			// Token: 0x17002BE4 RID: 11236
			// (get) Token: 0x0600E231 RID: 57905 RVA: 0x003CEA30 File Offset: 0x003CCC30
			// (set) Token: 0x0600E232 RID: 57906 RVA: 0x003CEA38 File Offset: 0x003CCC38
			public static int m_getSoldierTechId
			{
				get
				{
					return DrillUITask.m_getSoldierTechId;
				}
				set
				{
					DrillUITask.m_getSoldierTechId = value;
				}
			}

			// Token: 0x17002BE5 RID: 11237
			// (get) Token: 0x0600E233 RID: 57907 RVA: 0x003CEA40 File Offset: 0x003CCC40
			// (set) Token: 0x0600E234 RID: 57908 RVA: 0x003CEA50 File Offset: 0x003CCC50
			public bool m_isNeedShowFadeIn
			{
				get
				{
					return this.m_owner.m_isNeedShowFadeIn;
				}
				set
				{
					this.m_owner.m_isNeedShowFadeIn = value;
				}
			}

			// Token: 0x17002BE6 RID: 11238
			// (get) Token: 0x0600E235 RID: 57909 RVA: 0x003CEA60 File Offset: 0x003CCC60
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002BE7 RID: 11239
			// (get) Token: 0x0600E236 RID: 57910 RVA: 0x003CEA70 File Offset: 0x003CCC70
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600E237 RID: 57911 RVA: 0x003CEA80 File Offset: 0x003CCC80
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600E238 RID: 57912 RVA: 0x003CEA90 File Offset: 0x003CCC90
			public void SetTotalSoldierInfoListWithFilter()
			{
				this.m_owner.SetTotalSoldierInfoListWithFilter();
			}

			// Token: 0x0600E239 RID: 57913 RVA: 0x003CEAA0 File Offset: 0x003CCCA0
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x0600E23A RID: 57914 RVA: 0x003CEAB0 File Offset: 0x003CCCB0
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x0600E23B RID: 57915 RVA: 0x003CEAC0 File Offset: 0x003CCCC0
			public List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
			{
				return this.m_owner.CollectAllStaticResDescForLoad();
			}

			// Token: 0x0600E23C RID: 57916 RVA: 0x003CEAD0 File Offset: 0x003CCCD0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600E23D RID: 57917 RVA: 0x003CEAE0 File Offset: 0x003CCCE0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600E23E RID: 57918 RVA: 0x003CEAF0 File Offset: 0x003CCCF0
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600E23F RID: 57919 RVA: 0x003CEB00 File Offset: 0x003CCD00
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600E240 RID: 57920 RVA: 0x003CEB10 File Offset: 0x003CCD10
			public void PushAndPopLayerByState()
			{
				this.m_owner.PushAndPopLayerByState();
			}

			// Token: 0x0600E241 RID: 57921 RVA: 0x003CEB20 File Offset: 0x003CCD20
			public void DrillUIController_OnReturn()
			{
				this.m_owner.DrillUIController_OnReturn();
			}

			// Token: 0x0600E242 RID: 57922 RVA: 0x003CEB30 File Offset: 0x003CCD30
			public void DrillUIController_OnManualButtonClick()
			{
				this.m_owner.DrillUIController_OnManualButtonClick();
			}

			// Token: 0x0600E243 RID: 57923 RVA: 0x003CEB40 File Offset: 0x003CCD40
			public void DrillUIController_OnTrainingButtonClick(int courseId)
			{
				this.m_owner.DrillUIController_OnTrainingButtonClick(courseId);
			}

			// Token: 0x0600E244 RID: 57924 RVA: 0x003CEB50 File Offset: 0x003CCD50
			public void DrillUIController_OnAssistanceTrainingButtonClick(int slot)
			{
				this.m_owner.DrillUIController_OnAssistanceTrainingButtonClick(slot);
			}

			// Token: 0x0600E245 RID: 57925 RVA: 0x003CEB60 File Offset: 0x003CCD60
			public void DrillUIController_OnAssistanceStop(int taskId, int slot, Action OnSucceed)
			{
				this.m_owner.DrillUIController_OnAssistanceStop(taskId, slot, OnSucceed);
			}

			// Token: 0x0600E246 RID: 57926 RVA: 0x003CEB70 File Offset: 0x003CCD70
			public void DrillUIController_OnAssistanceGetReward(int taskId, int slot)
			{
				this.m_owner.DrillUIController_OnAssistanceGetReward(taskId, slot);
			}

			// Token: 0x0600E247 RID: 57927 RVA: 0x003CEB80 File Offset: 0x003CCD80
			public void DrillSoldierManualUIController_OnReturn()
			{
				this.m_owner.DrillSoldierManualUIController_OnReturn();
			}

			// Token: 0x0600E248 RID: 57928 RVA: 0x003CEB90 File Offset: 0x003CCD90
			public void DrillUIController_OnShowHelp()
			{
				this.m_owner.DrillUIController_OnShowHelp();
			}

			// Token: 0x0600E249 RID: 57929 RVA: 0x003CEBA0 File Offset: 0x003CCDA0
			public void DrillSoldierManualUIController_OnNeedUpdateView(int curPage, int rank, ArmyTag armyTag)
			{
				this.m_owner.DrillSoldierManualUIController_OnNeedUpdateView(curPage, rank, armyTag);
			}

			// Token: 0x0600E24A RID: 57930 RVA: 0x003CEBB0 File Offset: 0x003CCDB0
			public void DrillSoldierManualUIController_OnGoToTraingTech(int techId)
			{
				this.m_owner.DrillSoldierManualUIController_OnGoToTraingTech(techId);
			}

			// Token: 0x0600E24B RID: 57931 RVA: 0x003CEBC0 File Offset: 0x003CCDC0
			public void DrillTrainingUIController_OnReturn()
			{
				this.m_owner.DrillTrainingUIController_OnReturn();
			}

			// Token: 0x0600E24C RID: 57932 RVA: 0x003CEBD0 File Offset: 0x003CCDD0
			public void DrillTrainingUIController_OnAddGold()
			{
				this.m_owner.DrillTrainingUIController_OnAddGold();
			}

			// Token: 0x0600E24D RID: 57933 RVA: 0x003CEBE0 File Offset: 0x003CCDE0
			public void DrillTrainingUIController_OnAddCrystal()
			{
				this.m_owner.DrillTrainingUIController_OnAddCrystal();
			}

			// Token: 0x0600E24E RID: 57934 RVA: 0x003CEBF0 File Offset: 0x003CCDF0
			public void DrillTrainingUIController_OnTechLevelup(int techId, Action OnSucceed)
			{
				this.m_owner.DrillTrainingUIController_OnTechLevelup(techId, OnSucceed);
			}

			// Token: 0x0600E24F RID: 57935 RVA: 0x003CEC00 File Offset: 0x003CCE00
			public void DrillTrainingUIController_OnEvolutionMaterialClick(GoodsType goodsType, int goodsId, int needCount)
			{
				this.m_owner.DrillTrainingUIController_OnEvolutionMaterialClick(goodsType, goodsId, needCount);
			}

			// Token: 0x0600E250 RID: 57936 RVA: 0x003CEC10 File Offset: 0x003CCE10
			public void DrillTrainingUIController_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods)
			{
				this.m_owner.DrillTrainingUIController_OnGotoGetPath(getPath, needGoods);
			}

			// Token: 0x0600E251 RID: 57937 RVA: 0x003CEC20 File Offset: 0x003CCE20
			public void DrillTutorUIController_OnReturn()
			{
				this.m_owner.DrillTutorUIController_OnReturn();
			}

			// Token: 0x0600E252 RID: 57938 RVA: 0x003CEC30 File Offset: 0x003CCE30
			public void DrillTutorUIController_OnShowTutorHelp()
			{
				this.m_owner.DrillTutorUIController_OnShowTutorHelp();
			}

			// Token: 0x0600E253 RID: 57939 RVA: 0x003CEC40 File Offset: 0x003CCE40
			public void DrillTutorUIController_OnConfirmAssistant(int taskId, List<int> heroId, int workSeconds, int slot)
			{
				this.m_owner.DrillTutorUIController_OnConfirmAssistant(taskId, heroId, workSeconds, slot);
			}

			// Token: 0x0600E254 RID: 57940 RVA: 0x003CEC54 File Offset: 0x003CCE54
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600E255 RID: 57941 RVA: 0x003CEC64 File Offset: 0x003CCE64
			public void UpdateTimeText()
			{
				this.m_owner.UpdateTimeText();
			}

			// Token: 0x0400891C RID: 35100
			private DrillUITask m_owner;
		}
	}
}
