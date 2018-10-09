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
	// Token: 0x02000DA3 RID: 3491
	[HotFix]
	public class HeroDetailJobUIController : UIControllerBase
	{
		// Token: 0x06010749 RID: 67401 RVA: 0x00449138 File Offset: 0x00447338
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
			this.m_learnedPanelCloseBtn.onClick.AddListener(new UnityAction(this.CloseLearnedPanel));
			this.m_jobLvUpgradeButton.onClick.AddListener(new UnityAction(this.OnJobLvUpgradeButtonClick));
			this.m_learnedPanelSkillCloseBtn.onClick.AddListener(new UnityAction(this.CloseLearnedSkillPanel));
			this.m_jobUpgradeGroupGoContinueBGButton.onClick.AddListener(new UnityAction(this.OnJobUpgradeGroupGoContinueBGButtonClick));
			this.m_jobMasterRewardGroupGoReturnButton.onClick.AddListener(new UnityAction(this.OnJobMasterRewardGroupGoReturnButtonClick));
			this.m_jobLearnedSkill.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnJobLearnedSkillClick));
			this.m_jobLearnedMaster.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnJobLearnedMasterClick));
			this.m_jobLearnedSoldier.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnJobLearnedSoldierClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0601074A RID: 67402 RVA: 0x004492D0 File Offset: 0x004474D0
		public void UpdateViewInJobState(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInJobStateHero_hotfix != null)
			{
				this.m_UpdateViewInJobStateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.ShowJobDetailPanel();
			this.ShowJobUpgradePanel();
			this.ShowJobMaterialPanel();
		}

		// Token: 0x0601074B RID: 67403 RVA: 0x0044935C File Offset: 0x0044755C
		private void ShowJobDetailPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowJobDetailPanel_hotfix != null)
			{
				this.m_ShowJobDetailPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobInfo jobInfo = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobInfo;
			this.m_jobNameText.text = jobInfo.Name;
			this.m_jobDescText.text = jobInfo.Desc;
			this.m_jobArmyImage.sprite = AssetUtility.Instance.GetSprite(jobInfo.m_armyInfo.Icon_NoBack);
		}

		// Token: 0x0601074C RID: 67404 RVA: 0x00449414 File Offset: 0x00447614
		private void ShowJobUpgradePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowJobUpgradePanel_hotfix != null)
			{
				this.m_ShowJobUpgradePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetUpperLimitBreak();
			this.SetPropertyLearned();
		}

		// Token: 0x0601074D RID: 67405 RVA: 0x00449480 File Offset: 0x00447680
		private void SetUpperLimitBreak()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUpperLimitBreak_hotfix != null)
			{
				this.m_SetUpperLimitBreak_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int jobLevel = this.m_hero.GetActiveJob().JobLevel;
			int num = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobLevelInfos.Length - 1;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_curJobLv, jobLevel);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_curJobLvBg, num);
			CommonUIStateController component = this.m_curJobUpgradeGo.GetComponent<CommonUIStateController>();
			if (jobLevel < num)
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_nextJobLv, jobLevel + 1);
				UIUtility.SetGameObjectChildrenActiveCount(this.m_nextJobLvBg, num);
				this.m_nextJobLvObj.SetActive(true);
				this.m_jobLvArrowObj.SetActive(true);
				this.m_jobMasterImg.SetActive(false);
				component.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_nextJobLvObj.SetActive(false);
				this.m_jobLvArrowObj.SetActive(false);
				this.m_jobMasterImg.SetActive(true);
				component.SetToUIState("Master", false, true);
			}
		}

		// Token: 0x0601074E RID: 67406 RVA: 0x004495B8 File Offset: 0x004477B8
		private void SetPropertyLearned()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropertyLearned_hotfix != null)
			{
				this.m_SetPropertyLearned_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int jobLevel = this.m_hero.GetActiveJob().JobLevel;
			ConfigDataJobLevelInfo[] jobLevelInfos = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobLevelInfos;
			int num = jobLevelInfos.Length - 1;
			this.m_jobLearnedMaster.SetActive(jobLevel == num - 1);
			if (jobLevel < num - 1)
			{
				ConfigDataJobLevelInfo configDataJobLevelInfo = jobLevelInfos[jobLevel + 1];
				this.m_learnSkillInfo = configDataJobLevelInfo.m_gotSkillInfo;
				this.m_learnSoliderInfo = configDataJobLevelInfo.m_gotSoldierInfo;
			}
			else
			{
				this.m_learnSkillInfo = null;
				this.m_learnSoliderInfo = null;
			}
			this.m_jobLearnedSkill.SetActive(this.m_learnSkillInfo != null);
			if (this.m_learnSkillInfo != null)
			{
				this.m_jobLearnedSkillNameText.text = this.m_learnSkillInfo.Name;
				this.m_jobLearnedSkillIconImage.sprite = AssetUtility.Instance.GetSprite(this.m_learnSkillInfo.Icon);
			}
			this.m_jobLearnedSoldier.SetActive(this.m_learnSoliderInfo != null);
			if (this.m_learnSoliderInfo != null)
			{
				this.m_jobLearnedSoldierNameText.text = this.m_learnSoliderInfo.Name;
				this.m_jobLearnedSoldierIconImage.sprite = AssetUtility.Instance.GetSprite(this.m_learnSoliderInfo.m_armyInfo.Icon);
			}
		}

		// Token: 0x0601074F RID: 67407 RVA: 0x00449748 File Offset: 0x00447948
		private void OnJobLearnedSkillClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobLearnedSkillClick_hotfix != null)
			{
				this.m_OnJobLearnedSkillClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SkillDescUIController skillDescUIController = null;
			bool flag = false;
			for (int i = 0; i < this.m_jobDescContent.transform.childCount; i++)
			{
				Transform child = this.m_jobDescContent.transform.GetChild(i);
				if (child.name == "CommonSkillDesc")
				{
					flag = true;
					skillDescUIController = child.gameObject.GetComponent<SkillDescUIController>();
					break;
				}
			}
			if (!flag)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("commonSkillDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				skillDescUIController = gameObject.GetComponent<SkillDescUIController>();
				gameObject.transform.SetParent(this.m_jobDescContent.transform, false);
				gameObject.name = "CommonSkillDesc";
			}
			skillDescUIController.InitSkillDesc(this.m_learnSkillInfo);
		}

		// Token: 0x06010750 RID: 67408 RVA: 0x00449864 File Offset: 0x00447A64
		private void OnJobLearnedSoldierClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobLearnedSoldierClick_hotfix != null)
			{
				this.m_OnJobLearnedSoldierClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SoldierDescUIController soldierDescUIController = null;
			bool flag = false;
			for (int i = 0; i < this.m_jobDescContent.transform.childCount; i++)
			{
				Transform child = this.m_jobDescContent.transform.GetChild(i);
				if (child.name == "CommonSoldierDesc")
				{
					flag = true;
					soldierDescUIController = child.gameObject.GetComponent<SoldierDescUIController>();
					break;
				}
			}
			if (!flag)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("commonSoldierDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				soldierDescUIController = gameObject.GetComponent<SoldierDescUIController>();
				gameObject.transform.SetParent(this.m_jobDescContent.transform, false);
				gameObject.name = "CommonSoldierDesc";
			}
			soldierDescUIController.InitSoldierDesc(this.m_learnSoliderInfo, this.m_hero);
		}

		// Token: 0x06010751 RID: 67409 RVA: 0x00449988 File Offset: 0x00447B88
		private void OnJobLearnedMasterClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobLearnedMasterClick_hotfix != null)
			{
				this.m_OnJobLearnedMasterClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetJobLvMasterInfo();
			this.m_masterRewardPanel.SetActive(true);
			CommonUIStateController stateCtrl = this.m_masterRewardPanel.GetComponent<CommonUIStateController>();
			stateCtrl.SetToUIState("Show", false, true);
			stateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_masterRewardPanel.SetActive(false);
			});
			PointDescComponent pointDescComponent = this.m_masterRewardPanel.GetComponent<PointDescComponent>();
			if (pointDescComponent == null)
			{
				pointDescComponent = this.m_masterRewardPanel.AddComponent<PointDescComponent>();
				pointDescComponent.SetGameObject(this.m_masterRewardPanel, true, null, null);
				pointDescComponent.EventOnClose += delegate()
				{
					stateCtrl.SetToUIState("Close", false, true);
				};
			}
		}

		// Token: 0x06010752 RID: 67410 RVA: 0x00449A8C File Offset: 0x00447C8C
		private void SetJobLvMasterInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetJobLvMasterInfo_hotfix != null)
			{
				this.m_SetJobLvMasterInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_propAddObj, 0);
			ConfigDataJobInfo jobInfo = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobInfo;
			this.m_masterRewardPanelJobIcon.sprite = AssetUtility.Instance.GetSprite(jobInfo.JobIcon);
			this.m_masterRewardPanelNameText.text = jobInfo.Name;
			this.SetMasterRewardProperty(jobInfo.Property1_ID, jobInfo.Property1_Value);
			this.SetMasterRewardProperty(jobInfo.Property2_ID, jobInfo.Property2_Value);
			this.SetMasterRewardProperty(jobInfo.Property3_ID, jobInfo.Property3_Value);
		}

		// Token: 0x06010753 RID: 67411 RVA: 0x00449B70 File Offset: 0x00447D70
		private void SetMasterRewardProperty(PropertyModifyType type, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix.call(new object[]
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
			case PropertyModifyType.PropertyModifyType_Hero3_HPAdd:
				this.m_propHPAddValueText.text = "+" + value;
				this.m_propHPAddObj.SetActive(true);
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_ATAdd:
				this.m_propATAddValueText.text = "+" + value;
				this.m_propATAddObj.SetActive(true);
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_DFAdd:
				this.m_propDFAddValueText.text = "+" + value;
				this.m_propDFAddObj.SetActive(true);
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_MagicAdd:
				this.m_propMagicAddValueText.text = "+" + value;
				this.m_propMagicAddObj.gameObject.SetActive(true);
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_MagicDFAdd:
				this.m_propMagicDFAddValueText.text = "+" + value;
				this.m_propMagicDFAddObj.SetActive(true);
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_DEXAdd:
				this.m_propDEXAddValueText.text = "+" + value;
				this.m_propDEXAddObj.SetActive(true);
				break;
			}
		}

		// Token: 0x06010754 RID: 67412 RVA: 0x00449D28 File Offset: 0x00447F28
		private void ShowJobMaterialPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowJobMaterialPanel_hotfix != null)
			{
				this.m_ShowJobMaterialPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_jobMaterialObjList == null)
			{
				this.m_jobMaterialObjList = new List<GameObject>();
				this.m_jobMaterialObjList.Add(this.m_jobMaterialObj);
				this.m_jobMaterialObjList.Add(this.m_jobMaterialObj1);
				this.m_jobMaterialObjList.Add(this.m_jobMaterialObj2);
				this.m_jobMaterialObjList.Add(this.m_jobMaterialObj3);
			}
			int jobLevel = this.m_hero.GetActiveJob().JobLevel;
			ConfigDataJobLevelInfo[] jobLevelInfos = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobLevelInfos;
			ConfigDataJobLevelInfo configDataJobLevelInfo = jobLevelInfos[jobLevel];
			if (this.m_hero.Level >= configDataJobLevelInfo.JobLevelUpHeroLevel)
			{
				this.m_jobMaterialLvLimitCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_jobMaterialLvLimitCtrl.SetToUIState("Limit", false, true);
			}
			this.m_jobMaterialLvLimitText.text = configDataJobLevelInfo.JobLevelUpHeroLevel.ToString();
			this.m_jobUpGameObject.SetActive(this.m_playerContext.IsShowJobLevelCanUpTip(this.m_hero));
			List<Goods> materials = configDataJobLevelInfo.Materials;
			for (int i = 0; i < this.m_jobMaterialObjList.Count; i++)
			{
				if (i >= materials.Count)
				{
					this.m_jobMaterialObjList[i].SetActive(false);
				}
				else
				{
					this.m_jobMaterialObjList[i].SetActive(true);
					JobMaterialEquipedUIController component = this.m_jobMaterialObjList[i].GetComponent<JobMaterialEquipedUIController>();
					if (component == null)
					{
						PrefabControllerCreater.CreateAllControllers(this.m_jobMaterialObjList[i]);
						component = this.m_jobMaterialObjList[i].GetComponent<JobMaterialEquipedUIController>();
						component.EventOnJobMaterialClick += this.OnJobMaterialClick;
					}
					component.InitJobMaterial(materials[i]);
				}
			}
			if (this.m_playerContext.CanLevelUpHeroJobLevel(this.m_hero.HeroId, this.m_hero.GetActiveJob().JobConnectionInfo.ID) == 0)
			{
				this.m_jobLvUpgradeBtnArtEffect.SetActive(true);
				UIUtility.ReplayTween(this.m_jobLvUpgradeBtnArtEffect, null);
			}
			else
			{
				this.m_jobLvUpgradeBtnArtEffect.SetActive(false);
			}
		}

		// Token: 0x06010755 RID: 67413 RVA: 0x00449FAC File Offset: 0x004481AC
		private void OnJobMaterialClick(JobMaterialEquipedUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobMaterialClickJobMaterialEquipedUIController_hotfix != null)
			{
				this.m_OnJobMaterialClickJobMaterialEquipedUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowGetPath != null)
			{
				this.EventOnShowGetPath(GoodsType.GoodsType_JobMaterial, ctrl.JobMaterialInfo.ID, ctrl.NeedCount);
			}
		}

		// Token: 0x06010756 RID: 67414 RVA: 0x0044A044 File Offset: 0x00448244
		private void OnJobLvUpgradeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobLvUpgradeButtonClick_hotfix != null)
			{
				this.m_OnJobLvUpgradeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroJobLevelUp))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_HeroJobLevelUp), 2f, null, true);
			}
			else
			{
				int heroId = this.m_hero.HeroId;
				int id = this.m_hero.GetActiveJob().JobConnectionInfo.ID;
				int num = this.m_playerContext.CanLevelUpHeroJobLevel(heroId, id);
				if (num == 0)
				{
					int jobLevel = this.m_hero.GetActiveJob().JobLevel;
					ConfigDataJobLevelInfo[] jobLevelInfos = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobLevelInfos;
					ConfigDataJobLevelInfo configDataJobLevelInfo = jobLevelInfos[jobLevel];
					this.m_curjobNeedMaterials = configDataJobLevelInfo.Materials;
					if (this.EventOnJobLvUpgrade != null)
					{
						this.EventOnJobLvUpgrade(heroId, id, new Action(this.OnJobLvUpgradeSucceed));
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				}
			}
		}

		// Token: 0x06010757 RID: 67415 RVA: 0x0044A180 File Offset: 0x00448380
		private void OnJobLvUpgradeSucceed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobLvUpgradeSucceed_hotfix != null)
			{
				this.m_OnJobLvUpgradeSucceed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.JobLVUpgradeEffect());
		}

		// Token: 0x06010758 RID: 67416 RVA: 0x0044A1F0 File Offset: 0x004483F0
		[DebuggerHidden]
		private IEnumerator JobLVUpgradeEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JobLVUpgradeEffect_hotfix != null)
			{
				return (IEnumerator)this.m_JobLVUpgradeEffect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDetailJobUIController.<JobLVUpgradeEffect>c__Iterator0 <JobLVUpgradeEffect>c__Iterator = new HeroDetailJobUIController.<JobLVUpgradeEffect>c__Iterator0();
			<JobLVUpgradeEffect>c__Iterator.$this = this;
			return <JobLVUpgradeEffect>c__Iterator;
		}

		// Token: 0x06010759 RID: 67417 RVA: 0x0044A26C File Offset: 0x0044846C
		private void SetJobUpgradeInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetJobUpgradeInfo_hotfix != null)
			{
				this.m_SetJobUpgradeInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			HeroPropertyComputer heroPropertyComputer2 = heroPropertyComputer;
			Hero hero = this.m_hero;
			int jobRelatedId = this.m_hero.GetActiveJob().JobRelatedId;
			int jobLevel = this.m_hero.GetActiveJob().JobLevel - 1;
			int jobLevel2 = this.m_hero.GetActiveJob().JobLevel;
			heroPropertyComputer2.ComputeHeroProperties(hero, jobRelatedId, -1, -1, -1, -1, jobLevel, jobLevel2);
			this.m_jobUpgradeSuccessInfoPanelHpText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.m_jobUpgradeSuccessInfoPanelHpAddText.text = (heroPropertyComputer.Property1.HealthPointMax - heroPropertyComputer.Property0.HealthPointMax).ToString();
			this.m_jobUpgradeSuccessInfoPanelATText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_jobUpgradeSuccessInfoPanelATAddText.text = (heroPropertyComputer.Property1.Attack - heroPropertyComputer.Property0.Attack).ToString();
			this.m_jobUpgradeSuccessInfoPanelMagicText.text = heroPropertyComputer.Property0.Magic.ToString();
			this.m_jobUpgradeSuccessInfoPanelMagicAddText.text = (heroPropertyComputer.Property1.Magic - heroPropertyComputer.Property0.Magic).ToString();
			this.m_jobUpgradeSuccessInfoPanelDFText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_jobUpgradeSuccessInfoPanelDFAddText.text = (heroPropertyComputer.Property1.Defense - heroPropertyComputer.Property0.Defense).ToString();
			this.m_jobUpgradeSuccessInfoPanelMagicDFText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_jobUpgradeSuccessInfoPanelMagicDFAddText.text = (heroPropertyComputer.Property1.MagicDefense - heroPropertyComputer.Property0.MagicDefense).ToString();
			this.m_jobUpgradeSuccessInfoPanelDexText.text = heroPropertyComputer.Property0.Dexterity.ToString();
			this.m_jobUpgradeSuccessInfoPanelDexAddText.text = (heroPropertyComputer.Property1.Dexterity - heroPropertyComputer.Property0.Dexterity).ToString();
		}

		// Token: 0x0601075A RID: 67418 RVA: 0x0044A514 File Offset: 0x00448714
		private void ShowLearnedSkillAndSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowLearnedSkillAndSoldier_hotfix != null)
			{
				this.m_ShowLearnedSkillAndSoldier_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobLevelInfo configDataJobLevelInfo = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobLevelInfos[this.m_hero.GetActiveJob().JobLevel];
			if (configDataJobLevelInfo.GotSkill_ID != 0 || configDataJobLevelInfo.GotSoldier_ID != 0)
			{
				this.m_learnedPanel.SetActive(true);
			}
			if (configDataJobLevelInfo.GotSkill_ID != 0)
			{
				if (configDataJobLevelInfo.GotSoldier_ID != 0)
				{
					this.m_learnedPanelSkillCloseBtn.gameObject.SetActive(true);
				}
				else
				{
					this.m_learnedPanelSkillCloseBtn.gameObject.SetActive(false);
				}
				this.m_learnedPanelSkillPanel.SetActive(true);
				UIUtility.ReplayTween(this.m_learnedPanelSkillPanel, null);
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataJobLevelInfo.GotSkill_ID);
				this.m_learnedPanelSkillIcon.sprite = AssetUtility.Instance.GetSprite(configDataSkillInfo.Icon);
				this.m_learnedPanelSkillName.text = configDataSkillInfo.Name;
			}
			if (configDataJobLevelInfo.GotSoldier_ID != 0)
			{
				if (configDataJobLevelInfo.GotSkill_ID == 0)
				{
					this.m_learnedPanelSoldierPanel.SetActive(true);
					UIUtility.ReplayTween(this.m_learnedPanelSoldierPanel, null);
				}
				ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(configDataJobLevelInfo.GotSoldier_ID);
				float scale = (float)configDataSoldierInfo.UI_ModelScale * 0.02f;
				Vector2 offset = new Vector2((float)configDataSoldierInfo.UI_ModelOffsetX, (float)configDataSoldierInfo.UI_ModelOffsetY) * 2f;
				HeroDetailUIController.CreateSpineGraphic(ref this.m_learndSoldierGraphic, configDataSoldierInfo.Model, this.m_learnedPanelSoldierGraphicObj, 1, offset, scale, configDataSoldierInfo.ReplaceAnims);
				this.m_learnedPanelSoldierName.text = configDataSoldierInfo.Name;
			}
		}

		// Token: 0x0601075B RID: 67419 RVA: 0x0044A6F0 File Offset: 0x004488F0
		private void CloseLearnedSkillPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseLearnedSkillPanel_hotfix != null)
			{
				this.m_CloseLearnedSkillPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_learnedPanelSkillPanel.SetActive(false);
			this.m_learnedPanelSoldierPanel.SetActive(true);
			UIUtility.ReplayTween(this.m_learnedPanelSoldierPanel, null);
		}

		// Token: 0x0601075C RID: 67420 RVA: 0x0044A774 File Offset: 0x00448974
		private void OnJobUpgradeGroupGoContinueBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobUpgradeGroupGoContinueBGButtonClick_hotfix != null)
			{
				this.m_OnJobUpgradeGroupGoContinueBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isCloseJobUpgradePanel = true;
			CommonUIController.Instance.EnableInput(false);
		}

		// Token: 0x0601075D RID: 67421 RVA: 0x0044A7E8 File Offset: 0x004489E8
		private void OnJobMasterRewardGroupGoReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobMasterRewardGroupGoReturnButtonClick_hotfix != null)
			{
				this.m_OnJobMasterRewardGroupGoReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isCloseJobMasterRewardPanel = true;
		}

		// Token: 0x0601075E RID: 67422 RVA: 0x0044A850 File Offset: 0x00448A50
		private void CloseLearnedPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseLearnedPanel_hotfix != null)
			{
				this.m_CloseLearnedPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_learnedPanel.SetActive(false);
			this.m_learnedPanelSkillPanel.SetActive(false);
			this.m_learnedPanelSoldierPanel.SetActive(false);
		}

		// Token: 0x0601075F RID: 67423 RVA: 0x0044A8D4 File Offset: 0x00448AD4
		public bool IsJobLvUpgradeFinished()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsJobLvUpgradeFinished_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsJobLvUpgradeFinished_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_jobLvUpgradeButton.interactable;
		}

		// Token: 0x06010760 RID: 67424 RVA: 0x0044A94C File Offset: 0x00448B4C
		private void StopAndCloseUIEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopAndCloseUIEffect_hotfix != null)
			{
				this.m_StopAndCloseUIEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_jobMasterImg.SetActive(false);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_jobLvUpgradeFrameEffect, 0);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_jobLvUpgradeFlyEffect, 0);
			this.m_jobLvUpgradeStarUpEffect.SetActive(false);
		}

		// Token: 0x06010761 RID: 67425 RVA: 0x0044A9DC File Offset: 0x00448BDC
		public void SetCommonUIState(string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonUIStateString_hotfix != null)
			{
				this.m_SetCommonUIStateString_hotfix.call(new object[]
				{
					this,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_infoPanelStateCtrl, stateName, null, true, true);
		}

		// Token: 0x1400037C RID: 892
		// (add) Token: 0x06010762 RID: 67426 RVA: 0x0044AA5C File Offset: 0x00448C5C
		// (remove) Token: 0x06010763 RID: 67427 RVA: 0x0044AAF8 File Offset: 0x00448CF8
		public event Action<int, int, Action> EventOnJobLvUpgrade
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJobLvUpgradeAction`3_hotfix != null)
				{
					this.m_add_EventOnJobLvUpgradeAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnJobLvUpgrade;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnJobLvUpgrade, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJobLvUpgradeAction`3_hotfix != null)
				{
					this.m_remove_EventOnJobLvUpgradeAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnJobLvUpgrade;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnJobLvUpgrade, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400037D RID: 893
		// (add) Token: 0x06010764 RID: 67428 RVA: 0x0044AB94 File Offset: 0x00448D94
		// (remove) Token: 0x06010765 RID: 67429 RVA: 0x0044AC30 File Offset: 0x00448E30
		public event Action<GoodsType, int, int> EventOnShowGetPath
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowGetPathAction`3_hotfix != null)
				{
					this.m_add_EventOnShowGetPathAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnShowGetPath;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnShowGetPath, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowGetPathAction`3_hotfix != null)
				{
					this.m_remove_EventOnShowGetPathAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnShowGetPath;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnShowGetPath, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400037E RID: 894
		// (add) Token: 0x06010766 RID: 67430 RVA: 0x0044ACCC File Offset: 0x00448ECC
		// (remove) Token: 0x06010767 RID: 67431 RVA: 0x0044AD68 File Offset: 0x00448F68
		public event Action EventOnUpdateView
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUpdateViewAction_hotfix != null)
				{
					this.m_add_EventOnUpdateViewAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUpdateView;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUpdateView, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUpdateViewAction_hotfix != null)
				{
					this.m_remove_EventOnUpdateViewAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUpdateView;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUpdateView, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x06010768 RID: 67432 RVA: 0x0044AE04 File Offset: 0x00449004
		// (set) Token: 0x06010769 RID: 67433 RVA: 0x0044AE24 File Offset: 0x00449024
		[DoNotToLua]
		public new HeroDetailJobUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailJobUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601076A RID: 67434 RVA: 0x0044AE30 File Offset: 0x00449030
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601076B RID: 67435 RVA: 0x0044AE3C File Offset: 0x0044903C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601076C RID: 67436 RVA: 0x0044AE44 File Offset: 0x00449044
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601076D RID: 67437 RVA: 0x0044AE4C File Offset: 0x0044904C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601076E RID: 67438 RVA: 0x0044AE60 File Offset: 0x00449060
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601076F RID: 67439 RVA: 0x0044AE68 File Offset: 0x00449068
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010770 RID: 67440 RVA: 0x0044AE74 File Offset: 0x00449074
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010771 RID: 67441 RVA: 0x0044AE80 File Offset: 0x00449080
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010772 RID: 67442 RVA: 0x0044AE8C File Offset: 0x0044908C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010773 RID: 67443 RVA: 0x0044AE98 File Offset: 0x00449098
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010774 RID: 67444 RVA: 0x0044AEA4 File Offset: 0x004490A4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010775 RID: 67445 RVA: 0x0044AEB0 File Offset: 0x004490B0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010776 RID: 67446 RVA: 0x0044AEBC File Offset: 0x004490BC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010777 RID: 67447 RVA: 0x0044AEC8 File Offset: 0x004490C8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010778 RID: 67448 RVA: 0x0044AED4 File Offset: 0x004490D4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010779 RID: 67449 RVA: 0x0044AEDC File Offset: 0x004490DC
		private void __callDele_EventOnJobLvUpgrade(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnJobLvUpgrade = this.EventOnJobLvUpgrade;
			if (eventOnJobLvUpgrade != null)
			{
				eventOnJobLvUpgrade(arg1, arg2, arg3);
			}
		}

		// Token: 0x0601077A RID: 67450 RVA: 0x0044AF00 File Offset: 0x00449100
		private void __clearDele_EventOnJobLvUpgrade(int arg1, int arg2, Action arg3)
		{
			this.EventOnJobLvUpgrade = null;
		}

		// Token: 0x0601077B RID: 67451 RVA: 0x0044AF0C File Offset: 0x0044910C
		private void __callDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnShowGetPath = this.EventOnShowGetPath;
			if (eventOnShowGetPath != null)
			{
				eventOnShowGetPath(arg1, arg2, arg3);
			}
		}

		// Token: 0x0601077C RID: 67452 RVA: 0x0044AF30 File Offset: 0x00449130
		private void __clearDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnShowGetPath = null;
		}

		// Token: 0x0601077D RID: 67453 RVA: 0x0044AF3C File Offset: 0x0044913C
		private void __callDele_EventOnUpdateView()
		{
			Action eventOnUpdateView = this.EventOnUpdateView;
			if (eventOnUpdateView != null)
			{
				eventOnUpdateView();
			}
		}

		// Token: 0x0601077E RID: 67454 RVA: 0x0044AF5C File Offset: 0x0044915C
		private void __clearDele_EventOnUpdateView()
		{
			this.EventOnUpdateView = null;
		}

		// Token: 0x0601077F RID: 67455 RVA: 0x0044AF68 File Offset: 0x00449168
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
					this.m_UpdateViewInJobStateHero_hotfix = (luaObj.RawGet("UpdateViewInJobState") as LuaFunction);
					this.m_ShowJobDetailPanel_hotfix = (luaObj.RawGet("ShowJobDetailPanel") as LuaFunction);
					this.m_ShowJobUpgradePanel_hotfix = (luaObj.RawGet("ShowJobUpgradePanel") as LuaFunction);
					this.m_SetUpperLimitBreak_hotfix = (luaObj.RawGet("SetUpperLimitBreak") as LuaFunction);
					this.m_SetPropertyLearned_hotfix = (luaObj.RawGet("SetPropertyLearned") as LuaFunction);
					this.m_OnJobLearnedSkillClick_hotfix = (luaObj.RawGet("OnJobLearnedSkillClick") as LuaFunction);
					this.m_OnJobLearnedSoldierClick_hotfix = (luaObj.RawGet("OnJobLearnedSoldierClick") as LuaFunction);
					this.m_OnJobLearnedMasterClick_hotfix = (luaObj.RawGet("OnJobLearnedMasterClick") as LuaFunction);
					this.m_SetJobLvMasterInfo_hotfix = (luaObj.RawGet("SetJobLvMasterInfo") as LuaFunction);
					this.m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("SetMasterRewardProperty") as LuaFunction);
					this.m_ShowJobMaterialPanel_hotfix = (luaObj.RawGet("ShowJobMaterialPanel") as LuaFunction);
					this.m_OnJobMaterialClickJobMaterialEquipedUIController_hotfix = (luaObj.RawGet("OnJobMaterialClick") as LuaFunction);
					this.m_OnJobLvUpgradeButtonClick_hotfix = (luaObj.RawGet("OnJobLvUpgradeButtonClick") as LuaFunction);
					this.m_OnJobLvUpgradeSucceed_hotfix = (luaObj.RawGet("OnJobLvUpgradeSucceed") as LuaFunction);
					this.m_JobLVUpgradeEffect_hotfix = (luaObj.RawGet("JobLVUpgradeEffect") as LuaFunction);
					this.m_SetJobUpgradeInfo_hotfix = (luaObj.RawGet("SetJobUpgradeInfo") as LuaFunction);
					this.m_ShowLearnedSkillAndSoldier_hotfix = (luaObj.RawGet("ShowLearnedSkillAndSoldier") as LuaFunction);
					this.m_CloseLearnedSkillPanel_hotfix = (luaObj.RawGet("CloseLearnedSkillPanel") as LuaFunction);
					this.m_OnJobUpgradeGroupGoContinueBGButtonClick_hotfix = (luaObj.RawGet("OnJobUpgradeGroupGoContinueBGButtonClick") as LuaFunction);
					this.m_OnJobMasterRewardGroupGoReturnButtonClick_hotfix = (luaObj.RawGet("OnJobMasterRewardGroupGoReturnButtonClick") as LuaFunction);
					this.m_CloseLearnedPanel_hotfix = (luaObj.RawGet("CloseLearnedPanel") as LuaFunction);
					this.m_IsJobLvUpgradeFinished_hotfix = (luaObj.RawGet("IsJobLvUpgradeFinished") as LuaFunction);
					this.m_StopAndCloseUIEffect_hotfix = (luaObj.RawGet("StopAndCloseUIEffect") as LuaFunction);
					this.m_SetCommonUIStateString_hotfix = (luaObj.RawGet("SetCommonUIState") as LuaFunction);
					this.m_add_EventOnJobLvUpgradeAction`3_hotfix = (luaObj.RawGet("add_EventOnJobLvUpgrade") as LuaFunction);
					this.m_remove_EventOnJobLvUpgradeAction`3_hotfix = (luaObj.RawGet("remove_EventOnJobLvUpgrade") as LuaFunction);
					this.m_add_EventOnShowGetPathAction`3_hotfix = (luaObj.RawGet("add_EventOnShowGetPath") as LuaFunction);
					this.m_remove_EventOnShowGetPathAction`3_hotfix = (luaObj.RawGet("remove_EventOnShowGetPath") as LuaFunction);
					this.m_add_EventOnUpdateViewAction_hotfix = (luaObj.RawGet("add_EventOnUpdateView") as LuaFunction);
					this.m_remove_EventOnUpdateViewAction_hotfix = (luaObj.RawGet("remove_EventOnUpdateView") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010780 RID: 67456 RVA: 0x0044B324 File Offset: 0x00449524
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailJobUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040098A0 RID: 39072
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040098A1 RID: 39073
		[AutoBind("./InfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_infoPanelStateCtrl;

		// Token: 0x040098A2 RID: 39074
		[AutoBind("./InfoPanel/JobDetail/JobNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobNameText;

		// Token: 0x040098A3 RID: 39075
		[AutoBind("./InfoPanel/JobDetail/JobDescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobDescText;

		// Token: 0x040098A4 RID: 39076
		[AutoBind("./InfoPanel/JobDetail/ArmyImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobArmyImage;

		// Token: 0x040098A5 RID: 39077
		[AutoBind("./InfoPanel/JobUpgrade", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_curJobUpgradeGo;

		// Token: 0x040098A6 RID: 39078
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/CurLv/LvImgs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_curJobLv;

		// Token: 0x040098A7 RID: 39079
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/CurLv/LvImgsBg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_curJobLvBg;

		// Token: 0x040098A8 RID: 39080
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/NextLv", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_nextJobLvObj;

		// Token: 0x040098A9 RID: 39081
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/NextLv/LvImgs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_nextJobLv;

		// Token: 0x040098AA RID: 39082
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/NextLv/LvImgsBg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_nextJobLvBg;

		// Token: 0x040098AB RID: 39083
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/Master", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobMasterImg;

		// Token: 0x040098AC RID: 39084
		[AutoBind("./InfoPanel/JobUpgrade/JobLV/Arrow", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvArrowObj;

		// Token: 0x040098AD RID: 39085
		[AutoBind("./InfoPanel/JobUpButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobUpGameObject;

		// Token: 0x040098AE RID: 39086
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Skill", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLearnedSkill;

		// Token: 0x040098AF RID: 39087
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Skill/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobLearnedSkillIconImage;

		// Token: 0x040098B0 RID: 39088
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Skill/SkillNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobLearnedSkillNameText;

		// Token: 0x040098B1 RID: 39089
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Soldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLearnedSoldier;

		// Token: 0x040098B2 RID: 39090
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Soldier/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobLearnedSoldierIconImage;

		// Token: 0x040098B3 RID: 39091
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Soldier/SoldierNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobLearnedSoldierNameText;

		// Token: 0x040098B4 RID: 39092
		[AutoBind("./InfoPanel/JobUpgrade/Learned/Content/Master", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLearnedMaster;

		// Token: 0x040098B5 RID: 39093
		[AutoBind("./InfoPanel/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobDescContent;

		// Token: 0x040098B6 RID: 39094
		[AutoBind("./JobEffectGroup/MasterRewardPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_masterRewardPanel;

		// Token: 0x040098B7 RID: 39095
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propAddObj;

		// Token: 0x040098B8 RID: 39096
		[AutoBind("./JobEffectGroup/MasterRewardPanel/JobIconGroup/JobIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_masterRewardPanelJobIcon;

		// Token: 0x040098B9 RID: 39097
		[AutoBind("./JobEffectGroup/MasterRewardPanel/JobIconGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_masterRewardPanelNameText;

		// Token: 0x040098BA RID: 39098
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propHPAddValueText;

		// Token: 0x040098BB RID: 39099
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propATAddValueText;

		// Token: 0x040098BC RID: 39100
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propDFAddValueText;

		// Token: 0x040098BD RID: 39101
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propMagicAddValueText;

		// Token: 0x040098BE RID: 39102
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propMagicDFAddValueText;

		// Token: 0x040098BF RID: 39103
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/DEX/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propDEXAddValueText;

		// Token: 0x040098C0 RID: 39104
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propHPAddObj;

		// Token: 0x040098C1 RID: 39105
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propATAddObj;

		// Token: 0x040098C2 RID: 39106
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propDFAddObj;

		// Token: 0x040098C3 RID: 39107
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propMagicAddObj;

		// Token: 0x040098C4 RID: 39108
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propMagicDFAddObj;

		// Token: 0x040098C5 RID: 39109
		[AutoBind("./JobEffectGroup/MasterRewardPanel/Property/DEX", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propDEXAddObj;

		// Token: 0x040098C6 RID: 39110
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/JobMaterial", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobMaterialObj;

		// Token: 0x040098C7 RID: 39111
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/JobMaterial1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobMaterialObj1;

		// Token: 0x040098C8 RID: 39112
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/JobMaterial2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobMaterialObj2;

		// Token: 0x040098C9 RID: 39113
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/JobMaterial3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobMaterialObj3;

		// Token: 0x040098CA RID: 39114
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/UpgradeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobLvUpgradeButton;

		// Token: 0x040098CB RID: 39115
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/LvLimit", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_jobMaterialLvLimitCtrl;

		// Token: 0x040098CC RID: 39116
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/LvLimit/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobMaterialLvLimitText;

		// Token: 0x040098CD RID: 39117
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/UpgradeButton/ArtEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvUpgradeBtnArtEffect;

		// Token: 0x040098CE RID: 39118
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/FrameEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvUpgradeFrameEffect;

		// Token: 0x040098CF RID: 39119
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/FlyEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvUpgradeFlyEffect;

		// Token: 0x040098D0 RID: 39120
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/FlyEffect/FlyEffect1/ItemIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobLvUpgradeFlyEffectIcon1;

		// Token: 0x040098D1 RID: 39121
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/FlyEffect/FlyEffect2/ItemIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobLvUpgradeFlyEffectIcon2;

		// Token: 0x040098D2 RID: 39122
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/FlyEffect/FlyEffect3/ItemIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobLvUpgradeFlyEffectIcon3;

		// Token: 0x040098D3 RID: 39123
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/FlyEffect/FlyEffect4/ItemIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_jobLvUpgradeFlyEffectIcon4;

		// Token: 0x040098D4 RID: 39124
		[AutoBind("./InfoPanel/JobUpgrade/JobMaterial/EquipmentRoundUpArtEffect/StarUpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobLvUpgradeStarUpEffect;

		// Token: 0x040098D5 RID: 39125
		[AutoBind("./JobEffectGroup/MasterRewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobMasterRewardGroupGo;

		// Token: 0x040098D6 RID: 39126
		[AutoBind("./JobEffectGroup/MasterRewardGroup/ReturnBGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobMasterRewardGroupGoReturnButton;

		// Token: 0x040098D7 RID: 39127
		[AutoBind("./JobEffectGroup/JobUpgradeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobUpgradeGroupGo;

		// Token: 0x040098D8 RID: 39128
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/ContinueBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobUpgradeGroupGoContinueBGButton;

		// Token: 0x040098D9 RID: 39129
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/Hp/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelHpText;

		// Token: 0x040098DA RID: 39130
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/Hp/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelHpAddText;

		// Token: 0x040098DB RID: 39131
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/AT/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelATText;

		// Token: 0x040098DC RID: 39132
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/AT/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelATAddText;

		// Token: 0x040098DD RID: 39133
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/Magic/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelMagicText;

		// Token: 0x040098DE RID: 39134
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/Magic/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelMagicAddText;

		// Token: 0x040098DF RID: 39135
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/DF/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelDFText;

		// Token: 0x040098E0 RID: 39136
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/DF/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelDFAddText;

		// Token: 0x040098E1 RID: 39137
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/MagicDF/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelMagicDFText;

		// Token: 0x040098E2 RID: 39138
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/MagicDF/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelMagicDFAddText;

		// Token: 0x040098E3 RID: 39139
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/Dex/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelDexText;

		// Token: 0x040098E4 RID: 39140
		[AutoBind("./JobEffectGroup/JobUpgradeGroup/JobUpgradeSuccessInfoPanel/Detail/Dex/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_jobUpgradeSuccessInfoPanelDexAddText;

		// Token: 0x040098E5 RID: 39141
		[AutoBind("./LearnedPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanel;

		// Token: 0x040098E6 RID: 39142
		[AutoBind("./LearnedPanel/CloseImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_learnedPanelCloseBtn;

		// Token: 0x040098E7 RID: 39143
		[AutoBind("./LearnedPanel/Skill/ReturnImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_learnedPanelSkillCloseBtn;

		// Token: 0x040098E8 RID: 39144
		[AutoBind("./LearnedPanel/Skill", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanelSkillPanel;

		// Token: 0x040098E9 RID: 39145
		[AutoBind("./LearnedPanel/Soldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanelSoldierPanel;

		// Token: 0x040098EA RID: 39146
		[AutoBind("./LearnedPanel/Skill/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_learnedPanelSkillIcon;

		// Token: 0x040098EB RID: 39147
		[AutoBind("./LearnedPanel/Soldier/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_learnedPanelSoldierGraphicObj;

		// Token: 0x040098EC RID: 39148
		[AutoBind("./LearnedPanel/Skill/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_learnedPanelSkillName;

		// Token: 0x040098ED RID: 39149
		[AutoBind("./LearnedPanel/Soldier/Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_learnedPanelSoldierName;

		// Token: 0x040098F1 RID: 39153
		private Hero m_hero;

		// Token: 0x040098F2 RID: 39154
		private List<GameObject> m_jobMaterialObjList;

		// Token: 0x040098F3 RID: 39155
		private UISpineGraphic m_learndSoldierGraphic;

		// Token: 0x040098F4 RID: 39156
		private ConfigDataSkillInfo m_learnSkillInfo;

		// Token: 0x040098F5 RID: 39157
		private ConfigDataSoldierInfo m_learnSoliderInfo;

		// Token: 0x040098F6 RID: 39158
		private List<Goods> m_curjobNeedMaterials;

		// Token: 0x040098F7 RID: 39159
		private bool m_isCloseJobUpgradePanel;

		// Token: 0x040098F8 RID: 39160
		private bool m_isCloseJobMasterRewardPanel;

		// Token: 0x040098F9 RID: 39161
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040098FA RID: 39162
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040098FB RID: 39163
		[DoNotToLua]
		private HeroDetailJobUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040098FC RID: 39164
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040098FD RID: 39165
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040098FE RID: 39166
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040098FF RID: 39167
		private LuaFunction m_UpdateViewInJobStateHero_hotfix;

		// Token: 0x04009900 RID: 39168
		private LuaFunction m_ShowJobDetailPanel_hotfix;

		// Token: 0x04009901 RID: 39169
		private LuaFunction m_ShowJobUpgradePanel_hotfix;

		// Token: 0x04009902 RID: 39170
		private LuaFunction m_SetUpperLimitBreak_hotfix;

		// Token: 0x04009903 RID: 39171
		private LuaFunction m_SetPropertyLearned_hotfix;

		// Token: 0x04009904 RID: 39172
		private LuaFunction m_OnJobLearnedSkillClick_hotfix;

		// Token: 0x04009905 RID: 39173
		private LuaFunction m_OnJobLearnedSoldierClick_hotfix;

		// Token: 0x04009906 RID: 39174
		private LuaFunction m_OnJobLearnedMasterClick_hotfix;

		// Token: 0x04009907 RID: 39175
		private LuaFunction m_SetJobLvMasterInfo_hotfix;

		// Token: 0x04009908 RID: 39176
		private LuaFunction m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix;

		// Token: 0x04009909 RID: 39177
		private LuaFunction m_ShowJobMaterialPanel_hotfix;

		// Token: 0x0400990A RID: 39178
		private LuaFunction m_OnJobMaterialClickJobMaterialEquipedUIController_hotfix;

		// Token: 0x0400990B RID: 39179
		private LuaFunction m_OnJobLvUpgradeButtonClick_hotfix;

		// Token: 0x0400990C RID: 39180
		private LuaFunction m_OnJobLvUpgradeSucceed_hotfix;

		// Token: 0x0400990D RID: 39181
		private LuaFunction m_JobLVUpgradeEffect_hotfix;

		// Token: 0x0400990E RID: 39182
		private LuaFunction m_SetJobUpgradeInfo_hotfix;

		// Token: 0x0400990F RID: 39183
		private LuaFunction m_ShowLearnedSkillAndSoldier_hotfix;

		// Token: 0x04009910 RID: 39184
		private LuaFunction m_CloseLearnedSkillPanel_hotfix;

		// Token: 0x04009911 RID: 39185
		private LuaFunction m_OnJobUpgradeGroupGoContinueBGButtonClick_hotfix;

		// Token: 0x04009912 RID: 39186
		private LuaFunction m_OnJobMasterRewardGroupGoReturnButtonClick_hotfix;

		// Token: 0x04009913 RID: 39187
		private LuaFunction m_CloseLearnedPanel_hotfix;

		// Token: 0x04009914 RID: 39188
		private LuaFunction m_IsJobLvUpgradeFinished_hotfix;

		// Token: 0x04009915 RID: 39189
		private LuaFunction m_StopAndCloseUIEffect_hotfix;

		// Token: 0x04009916 RID: 39190
		private LuaFunction m_SetCommonUIStateString_hotfix;

		// Token: 0x04009917 RID: 39191
		private LuaFunction m_add_EventOnJobLvUpgradeAction;

		// Token: 0x04009918 RID: 39192
		private LuaFunction m_remove_EventOnJobLvUpgradeAction;

		// Token: 0x04009919 RID: 39193
		private LuaFunction m_add_EventOnShowGetPathAction;

		// Token: 0x0400991A RID: 39194
		private LuaFunction m_remove_EventOnShowGetPathAction;

		// Token: 0x0400991B RID: 39195
		private LuaFunction m_add_EventOnUpdateViewAction_hotfix;

		// Token: 0x0400991C RID: 39196
		private LuaFunction m_remove_EventOnUpdateViewAction_hotfix;

		// Token: 0x02000DA4 RID: 3492
		public new class LuaExportHelper
		{
			// Token: 0x06010781 RID: 67457 RVA: 0x0044B38C File Offset: 0x0044958C
			public LuaExportHelper(HeroDetailJobUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010782 RID: 67458 RVA: 0x0044B39C File Offset: 0x0044959C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010783 RID: 67459 RVA: 0x0044B3AC File Offset: 0x004495AC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010784 RID: 67460 RVA: 0x0044B3BC File Offset: 0x004495BC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010785 RID: 67461 RVA: 0x0044B3CC File Offset: 0x004495CC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010786 RID: 67462 RVA: 0x0044B3E4 File Offset: 0x004495E4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010787 RID: 67463 RVA: 0x0044B3F4 File Offset: 0x004495F4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010788 RID: 67464 RVA: 0x0044B404 File Offset: 0x00449604
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010789 RID: 67465 RVA: 0x0044B414 File Offset: 0x00449614
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601078A RID: 67466 RVA: 0x0044B424 File Offset: 0x00449624
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601078B RID: 67467 RVA: 0x0044B434 File Offset: 0x00449634
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601078C RID: 67468 RVA: 0x0044B444 File Offset: 0x00449644
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601078D RID: 67469 RVA: 0x0044B454 File Offset: 0x00449654
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601078E RID: 67470 RVA: 0x0044B464 File Offset: 0x00449664
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601078F RID: 67471 RVA: 0x0044B474 File Offset: 0x00449674
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010790 RID: 67472 RVA: 0x0044B484 File Offset: 0x00449684
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010791 RID: 67473 RVA: 0x0044B494 File Offset: 0x00449694
			public void __callDele_EventOnJobLvUpgrade(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnJobLvUpgrade(arg1, arg2, arg3);
			}

			// Token: 0x06010792 RID: 67474 RVA: 0x0044B4A4 File Offset: 0x004496A4
			public void __clearDele_EventOnJobLvUpgrade(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnJobLvUpgrade(arg1, arg2, arg3);
			}

			// Token: 0x06010793 RID: 67475 RVA: 0x0044B4B4 File Offset: 0x004496B4
			public void __callDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnShowGetPath(arg1, arg2, arg3);
			}

			// Token: 0x06010794 RID: 67476 RVA: 0x0044B4C4 File Offset: 0x004496C4
			public void __clearDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnShowGetPath(arg1, arg2, arg3);
			}

			// Token: 0x06010795 RID: 67477 RVA: 0x0044B4D4 File Offset: 0x004496D4
			public void __callDele_EventOnUpdateView()
			{
				this.m_owner.__callDele_EventOnUpdateView();
			}

			// Token: 0x06010796 RID: 67478 RVA: 0x0044B4E4 File Offset: 0x004496E4
			public void __clearDele_EventOnUpdateView()
			{
				this.m_owner.__clearDele_EventOnUpdateView();
			}

			// Token: 0x170032C5 RID: 12997
			// (get) Token: 0x06010797 RID: 67479 RVA: 0x0044B4F4 File Offset: 0x004496F4
			// (set) Token: 0x06010798 RID: 67480 RVA: 0x0044B504 File Offset: 0x00449704
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

			// Token: 0x170032C6 RID: 12998
			// (get) Token: 0x06010799 RID: 67481 RVA: 0x0044B514 File Offset: 0x00449714
			// (set) Token: 0x0601079A RID: 67482 RVA: 0x0044B524 File Offset: 0x00449724
			public CommonUIStateController m_infoPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_infoPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_infoPanelStateCtrl = value;
				}
			}

			// Token: 0x170032C7 RID: 12999
			// (get) Token: 0x0601079B RID: 67483 RVA: 0x0044B534 File Offset: 0x00449734
			// (set) Token: 0x0601079C RID: 67484 RVA: 0x0044B544 File Offset: 0x00449744
			public Text m_jobNameText
			{
				get
				{
					return this.m_owner.m_jobNameText;
				}
				set
				{
					this.m_owner.m_jobNameText = value;
				}
			}

			// Token: 0x170032C8 RID: 13000
			// (get) Token: 0x0601079D RID: 67485 RVA: 0x0044B554 File Offset: 0x00449754
			// (set) Token: 0x0601079E RID: 67486 RVA: 0x0044B564 File Offset: 0x00449764
			public Text m_jobDescText
			{
				get
				{
					return this.m_owner.m_jobDescText;
				}
				set
				{
					this.m_owner.m_jobDescText = value;
				}
			}

			// Token: 0x170032C9 RID: 13001
			// (get) Token: 0x0601079F RID: 67487 RVA: 0x0044B574 File Offset: 0x00449774
			// (set) Token: 0x060107A0 RID: 67488 RVA: 0x0044B584 File Offset: 0x00449784
			public Image m_jobArmyImage
			{
				get
				{
					return this.m_owner.m_jobArmyImage;
				}
				set
				{
					this.m_owner.m_jobArmyImage = value;
				}
			}

			// Token: 0x170032CA RID: 13002
			// (get) Token: 0x060107A1 RID: 67489 RVA: 0x0044B594 File Offset: 0x00449794
			// (set) Token: 0x060107A2 RID: 67490 RVA: 0x0044B5A4 File Offset: 0x004497A4
			public GameObject m_curJobUpgradeGo
			{
				get
				{
					return this.m_owner.m_curJobUpgradeGo;
				}
				set
				{
					this.m_owner.m_curJobUpgradeGo = value;
				}
			}

			// Token: 0x170032CB RID: 13003
			// (get) Token: 0x060107A3 RID: 67491 RVA: 0x0044B5B4 File Offset: 0x004497B4
			// (set) Token: 0x060107A4 RID: 67492 RVA: 0x0044B5C4 File Offset: 0x004497C4
			public GameObject m_curJobLv
			{
				get
				{
					return this.m_owner.m_curJobLv;
				}
				set
				{
					this.m_owner.m_curJobLv = value;
				}
			}

			// Token: 0x170032CC RID: 13004
			// (get) Token: 0x060107A5 RID: 67493 RVA: 0x0044B5D4 File Offset: 0x004497D4
			// (set) Token: 0x060107A6 RID: 67494 RVA: 0x0044B5E4 File Offset: 0x004497E4
			public GameObject m_curJobLvBg
			{
				get
				{
					return this.m_owner.m_curJobLvBg;
				}
				set
				{
					this.m_owner.m_curJobLvBg = value;
				}
			}

			// Token: 0x170032CD RID: 13005
			// (get) Token: 0x060107A7 RID: 67495 RVA: 0x0044B5F4 File Offset: 0x004497F4
			// (set) Token: 0x060107A8 RID: 67496 RVA: 0x0044B604 File Offset: 0x00449804
			public GameObject m_nextJobLvObj
			{
				get
				{
					return this.m_owner.m_nextJobLvObj;
				}
				set
				{
					this.m_owner.m_nextJobLvObj = value;
				}
			}

			// Token: 0x170032CE RID: 13006
			// (get) Token: 0x060107A9 RID: 67497 RVA: 0x0044B614 File Offset: 0x00449814
			// (set) Token: 0x060107AA RID: 67498 RVA: 0x0044B624 File Offset: 0x00449824
			public GameObject m_nextJobLv
			{
				get
				{
					return this.m_owner.m_nextJobLv;
				}
				set
				{
					this.m_owner.m_nextJobLv = value;
				}
			}

			// Token: 0x170032CF RID: 13007
			// (get) Token: 0x060107AB RID: 67499 RVA: 0x0044B634 File Offset: 0x00449834
			// (set) Token: 0x060107AC RID: 67500 RVA: 0x0044B644 File Offset: 0x00449844
			public GameObject m_nextJobLvBg
			{
				get
				{
					return this.m_owner.m_nextJobLvBg;
				}
				set
				{
					this.m_owner.m_nextJobLvBg = value;
				}
			}

			// Token: 0x170032D0 RID: 13008
			// (get) Token: 0x060107AD RID: 67501 RVA: 0x0044B654 File Offset: 0x00449854
			// (set) Token: 0x060107AE RID: 67502 RVA: 0x0044B664 File Offset: 0x00449864
			public GameObject m_jobMasterImg
			{
				get
				{
					return this.m_owner.m_jobMasterImg;
				}
				set
				{
					this.m_owner.m_jobMasterImg = value;
				}
			}

			// Token: 0x170032D1 RID: 13009
			// (get) Token: 0x060107AF RID: 67503 RVA: 0x0044B674 File Offset: 0x00449874
			// (set) Token: 0x060107B0 RID: 67504 RVA: 0x0044B684 File Offset: 0x00449884
			public GameObject m_jobLvArrowObj
			{
				get
				{
					return this.m_owner.m_jobLvArrowObj;
				}
				set
				{
					this.m_owner.m_jobLvArrowObj = value;
				}
			}

			// Token: 0x170032D2 RID: 13010
			// (get) Token: 0x060107B1 RID: 67505 RVA: 0x0044B694 File Offset: 0x00449894
			// (set) Token: 0x060107B2 RID: 67506 RVA: 0x0044B6A4 File Offset: 0x004498A4
			public GameObject m_jobUpGameObject
			{
				get
				{
					return this.m_owner.m_jobUpGameObject;
				}
				set
				{
					this.m_owner.m_jobUpGameObject = value;
				}
			}

			// Token: 0x170032D3 RID: 13011
			// (get) Token: 0x060107B3 RID: 67507 RVA: 0x0044B6B4 File Offset: 0x004498B4
			// (set) Token: 0x060107B4 RID: 67508 RVA: 0x0044B6C4 File Offset: 0x004498C4
			public GameObject m_jobLearnedSkill
			{
				get
				{
					return this.m_owner.m_jobLearnedSkill;
				}
				set
				{
					this.m_owner.m_jobLearnedSkill = value;
				}
			}

			// Token: 0x170032D4 RID: 13012
			// (get) Token: 0x060107B5 RID: 67509 RVA: 0x0044B6D4 File Offset: 0x004498D4
			// (set) Token: 0x060107B6 RID: 67510 RVA: 0x0044B6E4 File Offset: 0x004498E4
			public Image m_jobLearnedSkillIconImage
			{
				get
				{
					return this.m_owner.m_jobLearnedSkillIconImage;
				}
				set
				{
					this.m_owner.m_jobLearnedSkillIconImage = value;
				}
			}

			// Token: 0x170032D5 RID: 13013
			// (get) Token: 0x060107B7 RID: 67511 RVA: 0x0044B6F4 File Offset: 0x004498F4
			// (set) Token: 0x060107B8 RID: 67512 RVA: 0x0044B704 File Offset: 0x00449904
			public Text m_jobLearnedSkillNameText
			{
				get
				{
					return this.m_owner.m_jobLearnedSkillNameText;
				}
				set
				{
					this.m_owner.m_jobLearnedSkillNameText = value;
				}
			}

			// Token: 0x170032D6 RID: 13014
			// (get) Token: 0x060107B9 RID: 67513 RVA: 0x0044B714 File Offset: 0x00449914
			// (set) Token: 0x060107BA RID: 67514 RVA: 0x0044B724 File Offset: 0x00449924
			public GameObject m_jobLearnedSoldier
			{
				get
				{
					return this.m_owner.m_jobLearnedSoldier;
				}
				set
				{
					this.m_owner.m_jobLearnedSoldier = value;
				}
			}

			// Token: 0x170032D7 RID: 13015
			// (get) Token: 0x060107BB RID: 67515 RVA: 0x0044B734 File Offset: 0x00449934
			// (set) Token: 0x060107BC RID: 67516 RVA: 0x0044B744 File Offset: 0x00449944
			public Image m_jobLearnedSoldierIconImage
			{
				get
				{
					return this.m_owner.m_jobLearnedSoldierIconImage;
				}
				set
				{
					this.m_owner.m_jobLearnedSoldierIconImage = value;
				}
			}

			// Token: 0x170032D8 RID: 13016
			// (get) Token: 0x060107BD RID: 67517 RVA: 0x0044B754 File Offset: 0x00449954
			// (set) Token: 0x060107BE RID: 67518 RVA: 0x0044B764 File Offset: 0x00449964
			public Text m_jobLearnedSoldierNameText
			{
				get
				{
					return this.m_owner.m_jobLearnedSoldierNameText;
				}
				set
				{
					this.m_owner.m_jobLearnedSoldierNameText = value;
				}
			}

			// Token: 0x170032D9 RID: 13017
			// (get) Token: 0x060107BF RID: 67519 RVA: 0x0044B774 File Offset: 0x00449974
			// (set) Token: 0x060107C0 RID: 67520 RVA: 0x0044B784 File Offset: 0x00449984
			public GameObject m_jobLearnedMaster
			{
				get
				{
					return this.m_owner.m_jobLearnedMaster;
				}
				set
				{
					this.m_owner.m_jobLearnedMaster = value;
				}
			}

			// Token: 0x170032DA RID: 13018
			// (get) Token: 0x060107C1 RID: 67521 RVA: 0x0044B794 File Offset: 0x00449994
			// (set) Token: 0x060107C2 RID: 67522 RVA: 0x0044B7A4 File Offset: 0x004499A4
			public GameObject m_jobDescContent
			{
				get
				{
					return this.m_owner.m_jobDescContent;
				}
				set
				{
					this.m_owner.m_jobDescContent = value;
				}
			}

			// Token: 0x170032DB RID: 13019
			// (get) Token: 0x060107C3 RID: 67523 RVA: 0x0044B7B4 File Offset: 0x004499B4
			// (set) Token: 0x060107C4 RID: 67524 RVA: 0x0044B7C4 File Offset: 0x004499C4
			public GameObject m_masterRewardPanel
			{
				get
				{
					return this.m_owner.m_masterRewardPanel;
				}
				set
				{
					this.m_owner.m_masterRewardPanel = value;
				}
			}

			// Token: 0x170032DC RID: 13020
			// (get) Token: 0x060107C5 RID: 67525 RVA: 0x0044B7D4 File Offset: 0x004499D4
			// (set) Token: 0x060107C6 RID: 67526 RVA: 0x0044B7E4 File Offset: 0x004499E4
			public GameObject m_propAddObj
			{
				get
				{
					return this.m_owner.m_propAddObj;
				}
				set
				{
					this.m_owner.m_propAddObj = value;
				}
			}

			// Token: 0x170032DD RID: 13021
			// (get) Token: 0x060107C7 RID: 67527 RVA: 0x0044B7F4 File Offset: 0x004499F4
			// (set) Token: 0x060107C8 RID: 67528 RVA: 0x0044B804 File Offset: 0x00449A04
			public Image m_masterRewardPanelJobIcon
			{
				get
				{
					return this.m_owner.m_masterRewardPanelJobIcon;
				}
				set
				{
					this.m_owner.m_masterRewardPanelJobIcon = value;
				}
			}

			// Token: 0x170032DE RID: 13022
			// (get) Token: 0x060107C9 RID: 67529 RVA: 0x0044B814 File Offset: 0x00449A14
			// (set) Token: 0x060107CA RID: 67530 RVA: 0x0044B824 File Offset: 0x00449A24
			public Text m_masterRewardPanelNameText
			{
				get
				{
					return this.m_owner.m_masterRewardPanelNameText;
				}
				set
				{
					this.m_owner.m_masterRewardPanelNameText = value;
				}
			}

			// Token: 0x170032DF RID: 13023
			// (get) Token: 0x060107CB RID: 67531 RVA: 0x0044B834 File Offset: 0x00449A34
			// (set) Token: 0x060107CC RID: 67532 RVA: 0x0044B844 File Offset: 0x00449A44
			public Text m_propHPAddValueText
			{
				get
				{
					return this.m_owner.m_propHPAddValueText;
				}
				set
				{
					this.m_owner.m_propHPAddValueText = value;
				}
			}

			// Token: 0x170032E0 RID: 13024
			// (get) Token: 0x060107CD RID: 67533 RVA: 0x0044B854 File Offset: 0x00449A54
			// (set) Token: 0x060107CE RID: 67534 RVA: 0x0044B864 File Offset: 0x00449A64
			public Text m_propATAddValueText
			{
				get
				{
					return this.m_owner.m_propATAddValueText;
				}
				set
				{
					this.m_owner.m_propATAddValueText = value;
				}
			}

			// Token: 0x170032E1 RID: 13025
			// (get) Token: 0x060107CF RID: 67535 RVA: 0x0044B874 File Offset: 0x00449A74
			// (set) Token: 0x060107D0 RID: 67536 RVA: 0x0044B884 File Offset: 0x00449A84
			public Text m_propDFAddValueText
			{
				get
				{
					return this.m_owner.m_propDFAddValueText;
				}
				set
				{
					this.m_owner.m_propDFAddValueText = value;
				}
			}

			// Token: 0x170032E2 RID: 13026
			// (get) Token: 0x060107D1 RID: 67537 RVA: 0x0044B894 File Offset: 0x00449A94
			// (set) Token: 0x060107D2 RID: 67538 RVA: 0x0044B8A4 File Offset: 0x00449AA4
			public Text m_propMagicAddValueText
			{
				get
				{
					return this.m_owner.m_propMagicAddValueText;
				}
				set
				{
					this.m_owner.m_propMagicAddValueText = value;
				}
			}

			// Token: 0x170032E3 RID: 13027
			// (get) Token: 0x060107D3 RID: 67539 RVA: 0x0044B8B4 File Offset: 0x00449AB4
			// (set) Token: 0x060107D4 RID: 67540 RVA: 0x0044B8C4 File Offset: 0x00449AC4
			public Text m_propMagicDFAddValueText
			{
				get
				{
					return this.m_owner.m_propMagicDFAddValueText;
				}
				set
				{
					this.m_owner.m_propMagicDFAddValueText = value;
				}
			}

			// Token: 0x170032E4 RID: 13028
			// (get) Token: 0x060107D5 RID: 67541 RVA: 0x0044B8D4 File Offset: 0x00449AD4
			// (set) Token: 0x060107D6 RID: 67542 RVA: 0x0044B8E4 File Offset: 0x00449AE4
			public Text m_propDEXAddValueText
			{
				get
				{
					return this.m_owner.m_propDEXAddValueText;
				}
				set
				{
					this.m_owner.m_propDEXAddValueText = value;
				}
			}

			// Token: 0x170032E5 RID: 13029
			// (get) Token: 0x060107D7 RID: 67543 RVA: 0x0044B8F4 File Offset: 0x00449AF4
			// (set) Token: 0x060107D8 RID: 67544 RVA: 0x0044B904 File Offset: 0x00449B04
			public GameObject m_propHPAddObj
			{
				get
				{
					return this.m_owner.m_propHPAddObj;
				}
				set
				{
					this.m_owner.m_propHPAddObj = value;
				}
			}

			// Token: 0x170032E6 RID: 13030
			// (get) Token: 0x060107D9 RID: 67545 RVA: 0x0044B914 File Offset: 0x00449B14
			// (set) Token: 0x060107DA RID: 67546 RVA: 0x0044B924 File Offset: 0x00449B24
			public GameObject m_propATAddObj
			{
				get
				{
					return this.m_owner.m_propATAddObj;
				}
				set
				{
					this.m_owner.m_propATAddObj = value;
				}
			}

			// Token: 0x170032E7 RID: 13031
			// (get) Token: 0x060107DB RID: 67547 RVA: 0x0044B934 File Offset: 0x00449B34
			// (set) Token: 0x060107DC RID: 67548 RVA: 0x0044B944 File Offset: 0x00449B44
			public GameObject m_propDFAddObj
			{
				get
				{
					return this.m_owner.m_propDFAddObj;
				}
				set
				{
					this.m_owner.m_propDFAddObj = value;
				}
			}

			// Token: 0x170032E8 RID: 13032
			// (get) Token: 0x060107DD RID: 67549 RVA: 0x0044B954 File Offset: 0x00449B54
			// (set) Token: 0x060107DE RID: 67550 RVA: 0x0044B964 File Offset: 0x00449B64
			public GameObject m_propMagicAddObj
			{
				get
				{
					return this.m_owner.m_propMagicAddObj;
				}
				set
				{
					this.m_owner.m_propMagicAddObj = value;
				}
			}

			// Token: 0x170032E9 RID: 13033
			// (get) Token: 0x060107DF RID: 67551 RVA: 0x0044B974 File Offset: 0x00449B74
			// (set) Token: 0x060107E0 RID: 67552 RVA: 0x0044B984 File Offset: 0x00449B84
			public GameObject m_propMagicDFAddObj
			{
				get
				{
					return this.m_owner.m_propMagicDFAddObj;
				}
				set
				{
					this.m_owner.m_propMagicDFAddObj = value;
				}
			}

			// Token: 0x170032EA RID: 13034
			// (get) Token: 0x060107E1 RID: 67553 RVA: 0x0044B994 File Offset: 0x00449B94
			// (set) Token: 0x060107E2 RID: 67554 RVA: 0x0044B9A4 File Offset: 0x00449BA4
			public GameObject m_propDEXAddObj
			{
				get
				{
					return this.m_owner.m_propDEXAddObj;
				}
				set
				{
					this.m_owner.m_propDEXAddObj = value;
				}
			}

			// Token: 0x170032EB RID: 13035
			// (get) Token: 0x060107E3 RID: 67555 RVA: 0x0044B9B4 File Offset: 0x00449BB4
			// (set) Token: 0x060107E4 RID: 67556 RVA: 0x0044B9C4 File Offset: 0x00449BC4
			public GameObject m_jobMaterialObj
			{
				get
				{
					return this.m_owner.m_jobMaterialObj;
				}
				set
				{
					this.m_owner.m_jobMaterialObj = value;
				}
			}

			// Token: 0x170032EC RID: 13036
			// (get) Token: 0x060107E5 RID: 67557 RVA: 0x0044B9D4 File Offset: 0x00449BD4
			// (set) Token: 0x060107E6 RID: 67558 RVA: 0x0044B9E4 File Offset: 0x00449BE4
			public GameObject m_jobMaterialObj1
			{
				get
				{
					return this.m_owner.m_jobMaterialObj1;
				}
				set
				{
					this.m_owner.m_jobMaterialObj1 = value;
				}
			}

			// Token: 0x170032ED RID: 13037
			// (get) Token: 0x060107E7 RID: 67559 RVA: 0x0044B9F4 File Offset: 0x00449BF4
			// (set) Token: 0x060107E8 RID: 67560 RVA: 0x0044BA04 File Offset: 0x00449C04
			public GameObject m_jobMaterialObj2
			{
				get
				{
					return this.m_owner.m_jobMaterialObj2;
				}
				set
				{
					this.m_owner.m_jobMaterialObj2 = value;
				}
			}

			// Token: 0x170032EE RID: 13038
			// (get) Token: 0x060107E9 RID: 67561 RVA: 0x0044BA14 File Offset: 0x00449C14
			// (set) Token: 0x060107EA RID: 67562 RVA: 0x0044BA24 File Offset: 0x00449C24
			public GameObject m_jobMaterialObj3
			{
				get
				{
					return this.m_owner.m_jobMaterialObj3;
				}
				set
				{
					this.m_owner.m_jobMaterialObj3 = value;
				}
			}

			// Token: 0x170032EF RID: 13039
			// (get) Token: 0x060107EB RID: 67563 RVA: 0x0044BA34 File Offset: 0x00449C34
			// (set) Token: 0x060107EC RID: 67564 RVA: 0x0044BA44 File Offset: 0x00449C44
			public Button m_jobLvUpgradeButton
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeButton;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeButton = value;
				}
			}

			// Token: 0x170032F0 RID: 13040
			// (get) Token: 0x060107ED RID: 67565 RVA: 0x0044BA54 File Offset: 0x00449C54
			// (set) Token: 0x060107EE RID: 67566 RVA: 0x0044BA64 File Offset: 0x00449C64
			public CommonUIStateController m_jobMaterialLvLimitCtrl
			{
				get
				{
					return this.m_owner.m_jobMaterialLvLimitCtrl;
				}
				set
				{
					this.m_owner.m_jobMaterialLvLimitCtrl = value;
				}
			}

			// Token: 0x170032F1 RID: 13041
			// (get) Token: 0x060107EF RID: 67567 RVA: 0x0044BA74 File Offset: 0x00449C74
			// (set) Token: 0x060107F0 RID: 67568 RVA: 0x0044BA84 File Offset: 0x00449C84
			public Text m_jobMaterialLvLimitText
			{
				get
				{
					return this.m_owner.m_jobMaterialLvLimitText;
				}
				set
				{
					this.m_owner.m_jobMaterialLvLimitText = value;
				}
			}

			// Token: 0x170032F2 RID: 13042
			// (get) Token: 0x060107F1 RID: 67569 RVA: 0x0044BA94 File Offset: 0x00449C94
			// (set) Token: 0x060107F2 RID: 67570 RVA: 0x0044BAA4 File Offset: 0x00449CA4
			public GameObject m_jobLvUpgradeBtnArtEffect
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeBtnArtEffect;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeBtnArtEffect = value;
				}
			}

			// Token: 0x170032F3 RID: 13043
			// (get) Token: 0x060107F3 RID: 67571 RVA: 0x0044BAB4 File Offset: 0x00449CB4
			// (set) Token: 0x060107F4 RID: 67572 RVA: 0x0044BAC4 File Offset: 0x00449CC4
			public GameObject m_jobLvUpgradeFrameEffect
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeFrameEffect;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeFrameEffect = value;
				}
			}

			// Token: 0x170032F4 RID: 13044
			// (get) Token: 0x060107F5 RID: 67573 RVA: 0x0044BAD4 File Offset: 0x00449CD4
			// (set) Token: 0x060107F6 RID: 67574 RVA: 0x0044BAE4 File Offset: 0x00449CE4
			public GameObject m_jobLvUpgradeFlyEffect
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeFlyEffect;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeFlyEffect = value;
				}
			}

			// Token: 0x170032F5 RID: 13045
			// (get) Token: 0x060107F7 RID: 67575 RVA: 0x0044BAF4 File Offset: 0x00449CF4
			// (set) Token: 0x060107F8 RID: 67576 RVA: 0x0044BB04 File Offset: 0x00449D04
			public Image m_jobLvUpgradeFlyEffectIcon1
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeFlyEffectIcon1;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeFlyEffectIcon1 = value;
				}
			}

			// Token: 0x170032F6 RID: 13046
			// (get) Token: 0x060107F9 RID: 67577 RVA: 0x0044BB14 File Offset: 0x00449D14
			// (set) Token: 0x060107FA RID: 67578 RVA: 0x0044BB24 File Offset: 0x00449D24
			public Image m_jobLvUpgradeFlyEffectIcon2
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeFlyEffectIcon2;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeFlyEffectIcon2 = value;
				}
			}

			// Token: 0x170032F7 RID: 13047
			// (get) Token: 0x060107FB RID: 67579 RVA: 0x0044BB34 File Offset: 0x00449D34
			// (set) Token: 0x060107FC RID: 67580 RVA: 0x0044BB44 File Offset: 0x00449D44
			public Image m_jobLvUpgradeFlyEffectIcon3
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeFlyEffectIcon3;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeFlyEffectIcon3 = value;
				}
			}

			// Token: 0x170032F8 RID: 13048
			// (get) Token: 0x060107FD RID: 67581 RVA: 0x0044BB54 File Offset: 0x00449D54
			// (set) Token: 0x060107FE RID: 67582 RVA: 0x0044BB64 File Offset: 0x00449D64
			public Image m_jobLvUpgradeFlyEffectIcon4
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeFlyEffectIcon4;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeFlyEffectIcon4 = value;
				}
			}

			// Token: 0x170032F9 RID: 13049
			// (get) Token: 0x060107FF RID: 67583 RVA: 0x0044BB74 File Offset: 0x00449D74
			// (set) Token: 0x06010800 RID: 67584 RVA: 0x0044BB84 File Offset: 0x00449D84
			public GameObject m_jobLvUpgradeStarUpEffect
			{
				get
				{
					return this.m_owner.m_jobLvUpgradeStarUpEffect;
				}
				set
				{
					this.m_owner.m_jobLvUpgradeStarUpEffect = value;
				}
			}

			// Token: 0x170032FA RID: 13050
			// (get) Token: 0x06010801 RID: 67585 RVA: 0x0044BB94 File Offset: 0x00449D94
			// (set) Token: 0x06010802 RID: 67586 RVA: 0x0044BBA4 File Offset: 0x00449DA4
			public GameObject m_jobMasterRewardGroupGo
			{
				get
				{
					return this.m_owner.m_jobMasterRewardGroupGo;
				}
				set
				{
					this.m_owner.m_jobMasterRewardGroupGo = value;
				}
			}

			// Token: 0x170032FB RID: 13051
			// (get) Token: 0x06010803 RID: 67587 RVA: 0x0044BBB4 File Offset: 0x00449DB4
			// (set) Token: 0x06010804 RID: 67588 RVA: 0x0044BBC4 File Offset: 0x00449DC4
			public Button m_jobMasterRewardGroupGoReturnButton
			{
				get
				{
					return this.m_owner.m_jobMasterRewardGroupGoReturnButton;
				}
				set
				{
					this.m_owner.m_jobMasterRewardGroupGoReturnButton = value;
				}
			}

			// Token: 0x170032FC RID: 13052
			// (get) Token: 0x06010805 RID: 67589 RVA: 0x0044BBD4 File Offset: 0x00449DD4
			// (set) Token: 0x06010806 RID: 67590 RVA: 0x0044BBE4 File Offset: 0x00449DE4
			public GameObject m_jobUpgradeGroupGo
			{
				get
				{
					return this.m_owner.m_jobUpgradeGroupGo;
				}
				set
				{
					this.m_owner.m_jobUpgradeGroupGo = value;
				}
			}

			// Token: 0x170032FD RID: 13053
			// (get) Token: 0x06010807 RID: 67591 RVA: 0x0044BBF4 File Offset: 0x00449DF4
			// (set) Token: 0x06010808 RID: 67592 RVA: 0x0044BC04 File Offset: 0x00449E04
			public Button m_jobUpgradeGroupGoContinueBGButton
			{
				get
				{
					return this.m_owner.m_jobUpgradeGroupGoContinueBGButton;
				}
				set
				{
					this.m_owner.m_jobUpgradeGroupGoContinueBGButton = value;
				}
			}

			// Token: 0x170032FE RID: 13054
			// (get) Token: 0x06010809 RID: 67593 RVA: 0x0044BC14 File Offset: 0x00449E14
			// (set) Token: 0x0601080A RID: 67594 RVA: 0x0044BC24 File Offset: 0x00449E24
			public Text m_jobUpgradeSuccessInfoPanelHpText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelHpText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelHpText = value;
				}
			}

			// Token: 0x170032FF RID: 13055
			// (get) Token: 0x0601080B RID: 67595 RVA: 0x0044BC34 File Offset: 0x00449E34
			// (set) Token: 0x0601080C RID: 67596 RVA: 0x0044BC44 File Offset: 0x00449E44
			public Text m_jobUpgradeSuccessInfoPanelHpAddText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelHpAddText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelHpAddText = value;
				}
			}

			// Token: 0x17003300 RID: 13056
			// (get) Token: 0x0601080D RID: 67597 RVA: 0x0044BC54 File Offset: 0x00449E54
			// (set) Token: 0x0601080E RID: 67598 RVA: 0x0044BC64 File Offset: 0x00449E64
			public Text m_jobUpgradeSuccessInfoPanelATText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelATText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelATText = value;
				}
			}

			// Token: 0x17003301 RID: 13057
			// (get) Token: 0x0601080F RID: 67599 RVA: 0x0044BC74 File Offset: 0x00449E74
			// (set) Token: 0x06010810 RID: 67600 RVA: 0x0044BC84 File Offset: 0x00449E84
			public Text m_jobUpgradeSuccessInfoPanelATAddText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelATAddText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelATAddText = value;
				}
			}

			// Token: 0x17003302 RID: 13058
			// (get) Token: 0x06010811 RID: 67601 RVA: 0x0044BC94 File Offset: 0x00449E94
			// (set) Token: 0x06010812 RID: 67602 RVA: 0x0044BCA4 File Offset: 0x00449EA4
			public Text m_jobUpgradeSuccessInfoPanelMagicText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelMagicText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelMagicText = value;
				}
			}

			// Token: 0x17003303 RID: 13059
			// (get) Token: 0x06010813 RID: 67603 RVA: 0x0044BCB4 File Offset: 0x00449EB4
			// (set) Token: 0x06010814 RID: 67604 RVA: 0x0044BCC4 File Offset: 0x00449EC4
			public Text m_jobUpgradeSuccessInfoPanelMagicAddText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelMagicAddText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelMagicAddText = value;
				}
			}

			// Token: 0x17003304 RID: 13060
			// (get) Token: 0x06010815 RID: 67605 RVA: 0x0044BCD4 File Offset: 0x00449ED4
			// (set) Token: 0x06010816 RID: 67606 RVA: 0x0044BCE4 File Offset: 0x00449EE4
			public Text m_jobUpgradeSuccessInfoPanelDFText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelDFText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelDFText = value;
				}
			}

			// Token: 0x17003305 RID: 13061
			// (get) Token: 0x06010817 RID: 67607 RVA: 0x0044BCF4 File Offset: 0x00449EF4
			// (set) Token: 0x06010818 RID: 67608 RVA: 0x0044BD04 File Offset: 0x00449F04
			public Text m_jobUpgradeSuccessInfoPanelDFAddText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelDFAddText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelDFAddText = value;
				}
			}

			// Token: 0x17003306 RID: 13062
			// (get) Token: 0x06010819 RID: 67609 RVA: 0x0044BD14 File Offset: 0x00449F14
			// (set) Token: 0x0601081A RID: 67610 RVA: 0x0044BD24 File Offset: 0x00449F24
			public Text m_jobUpgradeSuccessInfoPanelMagicDFText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelMagicDFText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelMagicDFText = value;
				}
			}

			// Token: 0x17003307 RID: 13063
			// (get) Token: 0x0601081B RID: 67611 RVA: 0x0044BD34 File Offset: 0x00449F34
			// (set) Token: 0x0601081C RID: 67612 RVA: 0x0044BD44 File Offset: 0x00449F44
			public Text m_jobUpgradeSuccessInfoPanelMagicDFAddText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelMagicDFAddText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelMagicDFAddText = value;
				}
			}

			// Token: 0x17003308 RID: 13064
			// (get) Token: 0x0601081D RID: 67613 RVA: 0x0044BD54 File Offset: 0x00449F54
			// (set) Token: 0x0601081E RID: 67614 RVA: 0x0044BD64 File Offset: 0x00449F64
			public Text m_jobUpgradeSuccessInfoPanelDexText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelDexText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelDexText = value;
				}
			}

			// Token: 0x17003309 RID: 13065
			// (get) Token: 0x0601081F RID: 67615 RVA: 0x0044BD74 File Offset: 0x00449F74
			// (set) Token: 0x06010820 RID: 67616 RVA: 0x0044BD84 File Offset: 0x00449F84
			public Text m_jobUpgradeSuccessInfoPanelDexAddText
			{
				get
				{
					return this.m_owner.m_jobUpgradeSuccessInfoPanelDexAddText;
				}
				set
				{
					this.m_owner.m_jobUpgradeSuccessInfoPanelDexAddText = value;
				}
			}

			// Token: 0x1700330A RID: 13066
			// (get) Token: 0x06010821 RID: 67617 RVA: 0x0044BD94 File Offset: 0x00449F94
			// (set) Token: 0x06010822 RID: 67618 RVA: 0x0044BDA4 File Offset: 0x00449FA4
			public GameObject m_learnedPanel
			{
				get
				{
					return this.m_owner.m_learnedPanel;
				}
				set
				{
					this.m_owner.m_learnedPanel = value;
				}
			}

			// Token: 0x1700330B RID: 13067
			// (get) Token: 0x06010823 RID: 67619 RVA: 0x0044BDB4 File Offset: 0x00449FB4
			// (set) Token: 0x06010824 RID: 67620 RVA: 0x0044BDC4 File Offset: 0x00449FC4
			public Button m_learnedPanelCloseBtn
			{
				get
				{
					return this.m_owner.m_learnedPanelCloseBtn;
				}
				set
				{
					this.m_owner.m_learnedPanelCloseBtn = value;
				}
			}

			// Token: 0x1700330C RID: 13068
			// (get) Token: 0x06010825 RID: 67621 RVA: 0x0044BDD4 File Offset: 0x00449FD4
			// (set) Token: 0x06010826 RID: 67622 RVA: 0x0044BDE4 File Offset: 0x00449FE4
			public Button m_learnedPanelSkillCloseBtn
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillCloseBtn;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillCloseBtn = value;
				}
			}

			// Token: 0x1700330D RID: 13069
			// (get) Token: 0x06010827 RID: 67623 RVA: 0x0044BDF4 File Offset: 0x00449FF4
			// (set) Token: 0x06010828 RID: 67624 RVA: 0x0044BE04 File Offset: 0x0044A004
			public GameObject m_learnedPanelSkillPanel
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillPanel;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillPanel = value;
				}
			}

			// Token: 0x1700330E RID: 13070
			// (get) Token: 0x06010829 RID: 67625 RVA: 0x0044BE14 File Offset: 0x0044A014
			// (set) Token: 0x0601082A RID: 67626 RVA: 0x0044BE24 File Offset: 0x0044A024
			public GameObject m_learnedPanelSoldierPanel
			{
				get
				{
					return this.m_owner.m_learnedPanelSoldierPanel;
				}
				set
				{
					this.m_owner.m_learnedPanelSoldierPanel = value;
				}
			}

			// Token: 0x1700330F RID: 13071
			// (get) Token: 0x0601082B RID: 67627 RVA: 0x0044BE34 File Offset: 0x0044A034
			// (set) Token: 0x0601082C RID: 67628 RVA: 0x0044BE44 File Offset: 0x0044A044
			public Image m_learnedPanelSkillIcon
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillIcon;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillIcon = value;
				}
			}

			// Token: 0x17003310 RID: 13072
			// (get) Token: 0x0601082D RID: 67629 RVA: 0x0044BE54 File Offset: 0x0044A054
			// (set) Token: 0x0601082E RID: 67630 RVA: 0x0044BE64 File Offset: 0x0044A064
			public GameObject m_learnedPanelSoldierGraphicObj
			{
				get
				{
					return this.m_owner.m_learnedPanelSoldierGraphicObj;
				}
				set
				{
					this.m_owner.m_learnedPanelSoldierGraphicObj = value;
				}
			}

			// Token: 0x17003311 RID: 13073
			// (get) Token: 0x0601082F RID: 67631 RVA: 0x0044BE74 File Offset: 0x0044A074
			// (set) Token: 0x06010830 RID: 67632 RVA: 0x0044BE84 File Offset: 0x0044A084
			public Text m_learnedPanelSkillName
			{
				get
				{
					return this.m_owner.m_learnedPanelSkillName;
				}
				set
				{
					this.m_owner.m_learnedPanelSkillName = value;
				}
			}

			// Token: 0x17003312 RID: 13074
			// (get) Token: 0x06010831 RID: 67633 RVA: 0x0044BE94 File Offset: 0x0044A094
			// (set) Token: 0x06010832 RID: 67634 RVA: 0x0044BEA4 File Offset: 0x0044A0A4
			public Text m_learnedPanelSoldierName
			{
				get
				{
					return this.m_owner.m_learnedPanelSoldierName;
				}
				set
				{
					this.m_owner.m_learnedPanelSoldierName = value;
				}
			}

			// Token: 0x17003313 RID: 13075
			// (get) Token: 0x06010833 RID: 67635 RVA: 0x0044BEB4 File Offset: 0x0044A0B4
			// (set) Token: 0x06010834 RID: 67636 RVA: 0x0044BEC4 File Offset: 0x0044A0C4
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17003314 RID: 13076
			// (get) Token: 0x06010835 RID: 67637 RVA: 0x0044BED4 File Offset: 0x0044A0D4
			// (set) Token: 0x06010836 RID: 67638 RVA: 0x0044BEE4 File Offset: 0x0044A0E4
			public List<GameObject> m_jobMaterialObjList
			{
				get
				{
					return this.m_owner.m_jobMaterialObjList;
				}
				set
				{
					this.m_owner.m_jobMaterialObjList = value;
				}
			}

			// Token: 0x17003315 RID: 13077
			// (get) Token: 0x06010837 RID: 67639 RVA: 0x0044BEF4 File Offset: 0x0044A0F4
			// (set) Token: 0x06010838 RID: 67640 RVA: 0x0044BF04 File Offset: 0x0044A104
			public UISpineGraphic m_learndSoldierGraphic
			{
				get
				{
					return this.m_owner.m_learndSoldierGraphic;
				}
				set
				{
					this.m_owner.m_learndSoldierGraphic = value;
				}
			}

			// Token: 0x17003316 RID: 13078
			// (get) Token: 0x06010839 RID: 67641 RVA: 0x0044BF14 File Offset: 0x0044A114
			// (set) Token: 0x0601083A RID: 67642 RVA: 0x0044BF24 File Offset: 0x0044A124
			public ConfigDataSkillInfo m_learnSkillInfo
			{
				get
				{
					return this.m_owner.m_learnSkillInfo;
				}
				set
				{
					this.m_owner.m_learnSkillInfo = value;
				}
			}

			// Token: 0x17003317 RID: 13079
			// (get) Token: 0x0601083B RID: 67643 RVA: 0x0044BF34 File Offset: 0x0044A134
			// (set) Token: 0x0601083C RID: 67644 RVA: 0x0044BF44 File Offset: 0x0044A144
			public ConfigDataSoldierInfo m_learnSoliderInfo
			{
				get
				{
					return this.m_owner.m_learnSoliderInfo;
				}
				set
				{
					this.m_owner.m_learnSoliderInfo = value;
				}
			}

			// Token: 0x17003318 RID: 13080
			// (get) Token: 0x0601083D RID: 67645 RVA: 0x0044BF54 File Offset: 0x0044A154
			// (set) Token: 0x0601083E RID: 67646 RVA: 0x0044BF64 File Offset: 0x0044A164
			public List<Goods> m_curjobNeedMaterials
			{
				get
				{
					return this.m_owner.m_curjobNeedMaterials;
				}
				set
				{
					this.m_owner.m_curjobNeedMaterials = value;
				}
			}

			// Token: 0x17003319 RID: 13081
			// (get) Token: 0x0601083F RID: 67647 RVA: 0x0044BF74 File Offset: 0x0044A174
			// (set) Token: 0x06010840 RID: 67648 RVA: 0x0044BF84 File Offset: 0x0044A184
			public bool m_isCloseJobUpgradePanel
			{
				get
				{
					return this.m_owner.m_isCloseJobUpgradePanel;
				}
				set
				{
					this.m_owner.m_isCloseJobUpgradePanel = value;
				}
			}

			// Token: 0x1700331A RID: 13082
			// (get) Token: 0x06010841 RID: 67649 RVA: 0x0044BF94 File Offset: 0x0044A194
			// (set) Token: 0x06010842 RID: 67650 RVA: 0x0044BFA4 File Offset: 0x0044A1A4
			public bool m_isCloseJobMasterRewardPanel
			{
				get
				{
					return this.m_owner.m_isCloseJobMasterRewardPanel;
				}
				set
				{
					this.m_owner.m_isCloseJobMasterRewardPanel = value;
				}
			}

			// Token: 0x1700331B RID: 13083
			// (get) Token: 0x06010843 RID: 67651 RVA: 0x0044BFB4 File Offset: 0x0044A1B4
			// (set) Token: 0x06010844 RID: 67652 RVA: 0x0044BFC4 File Offset: 0x0044A1C4
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

			// Token: 0x1700331C RID: 13084
			// (get) Token: 0x06010845 RID: 67653 RVA: 0x0044BFD4 File Offset: 0x0044A1D4
			// (set) Token: 0x06010846 RID: 67654 RVA: 0x0044BFE4 File Offset: 0x0044A1E4
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

			// Token: 0x06010847 RID: 67655 RVA: 0x0044BFF4 File Offset: 0x0044A1F4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010848 RID: 67656 RVA: 0x0044C004 File Offset: 0x0044A204
			public void ShowJobDetailPanel()
			{
				this.m_owner.ShowJobDetailPanel();
			}

			// Token: 0x06010849 RID: 67657 RVA: 0x0044C014 File Offset: 0x0044A214
			public void ShowJobUpgradePanel()
			{
				this.m_owner.ShowJobUpgradePanel();
			}

			// Token: 0x0601084A RID: 67658 RVA: 0x0044C024 File Offset: 0x0044A224
			public void SetUpperLimitBreak()
			{
				this.m_owner.SetUpperLimitBreak();
			}

			// Token: 0x0601084B RID: 67659 RVA: 0x0044C034 File Offset: 0x0044A234
			public void SetPropertyLearned()
			{
				this.m_owner.SetPropertyLearned();
			}

			// Token: 0x0601084C RID: 67660 RVA: 0x0044C044 File Offset: 0x0044A244
			public void OnJobLearnedSkillClick()
			{
				this.m_owner.OnJobLearnedSkillClick();
			}

			// Token: 0x0601084D RID: 67661 RVA: 0x0044C054 File Offset: 0x0044A254
			public void OnJobLearnedSoldierClick()
			{
				this.m_owner.OnJobLearnedSoldierClick();
			}

			// Token: 0x0601084E RID: 67662 RVA: 0x0044C064 File Offset: 0x0044A264
			public void OnJobLearnedMasterClick()
			{
				this.m_owner.OnJobLearnedMasterClick();
			}

			// Token: 0x0601084F RID: 67663 RVA: 0x0044C074 File Offset: 0x0044A274
			public void SetJobLvMasterInfo()
			{
				this.m_owner.SetJobLvMasterInfo();
			}

			// Token: 0x06010850 RID: 67664 RVA: 0x0044C084 File Offset: 0x0044A284
			public void SetMasterRewardProperty(PropertyModifyType type, int value)
			{
				this.m_owner.SetMasterRewardProperty(type, value);
			}

			// Token: 0x06010851 RID: 67665 RVA: 0x0044C094 File Offset: 0x0044A294
			public void ShowJobMaterialPanel()
			{
				this.m_owner.ShowJobMaterialPanel();
			}

			// Token: 0x06010852 RID: 67666 RVA: 0x0044C0A4 File Offset: 0x0044A2A4
			public void OnJobMaterialClick(JobMaterialEquipedUIController ctrl)
			{
				this.m_owner.OnJobMaterialClick(ctrl);
			}

			// Token: 0x06010853 RID: 67667 RVA: 0x0044C0B4 File Offset: 0x0044A2B4
			public void OnJobLvUpgradeButtonClick()
			{
				this.m_owner.OnJobLvUpgradeButtonClick();
			}

			// Token: 0x06010854 RID: 67668 RVA: 0x0044C0C4 File Offset: 0x0044A2C4
			public void OnJobLvUpgradeSucceed()
			{
				this.m_owner.OnJobLvUpgradeSucceed();
			}

			// Token: 0x06010855 RID: 67669 RVA: 0x0044C0D4 File Offset: 0x0044A2D4
			public IEnumerator JobLVUpgradeEffect()
			{
				return this.m_owner.JobLVUpgradeEffect();
			}

			// Token: 0x06010856 RID: 67670 RVA: 0x0044C0E4 File Offset: 0x0044A2E4
			public void SetJobUpgradeInfo()
			{
				this.m_owner.SetJobUpgradeInfo();
			}

			// Token: 0x06010857 RID: 67671 RVA: 0x0044C0F4 File Offset: 0x0044A2F4
			public void ShowLearnedSkillAndSoldier()
			{
				this.m_owner.ShowLearnedSkillAndSoldier();
			}

			// Token: 0x06010858 RID: 67672 RVA: 0x0044C104 File Offset: 0x0044A304
			public void CloseLearnedSkillPanel()
			{
				this.m_owner.CloseLearnedSkillPanel();
			}

			// Token: 0x06010859 RID: 67673 RVA: 0x0044C114 File Offset: 0x0044A314
			public void OnJobUpgradeGroupGoContinueBGButtonClick()
			{
				this.m_owner.OnJobUpgradeGroupGoContinueBGButtonClick();
			}

			// Token: 0x0601085A RID: 67674 RVA: 0x0044C124 File Offset: 0x0044A324
			public void OnJobMasterRewardGroupGoReturnButtonClick()
			{
				this.m_owner.OnJobMasterRewardGroupGoReturnButtonClick();
			}

			// Token: 0x0601085B RID: 67675 RVA: 0x0044C134 File Offset: 0x0044A334
			public void CloseLearnedPanel()
			{
				this.m_owner.CloseLearnedPanel();
			}

			// Token: 0x0601085C RID: 67676 RVA: 0x0044C144 File Offset: 0x0044A344
			public void StopAndCloseUIEffect()
			{
				this.m_owner.StopAndCloseUIEffect();
			}

			// Token: 0x0400991D RID: 39197
			private HeroDetailJobUIController m_owner;
		}
	}
}
