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
	// Token: 0x02000C67 RID: 3175
	[HotFix]
	public class FettersConfessionUIController : UIControllerBase
	{
		// Token: 0x0600E25F RID: 57951 RVA: 0x003CEE24 File Offset: 0x003CD024
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
			this.m_playerResourceGoldenAddButton.onClick.AddListener(new UnityAction(this.OnGoldAddButtonClick));
			this.m_playerResourceCrystalAddButton.onClick.AddListener(new UnityAction(this.OnCrystalAddButtonClick));
			this.m_skillDetailUnlockButton.onClick.AddListener(new UnityAction(this.OnSkillUnlockButtonClick));
			this.m_skillDetailUnlockGreyButton.onClick.AddListener(new UnityAction(this.OnSkillDetailUnlockGreyButtonClick));
			this.m_confessionToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnConfessionToggleValueChanged));
			this.m_skillDetailUnlockStateEvolutionButton.onClick.AddListener(new UnityAction(this.OnUnlockStateEvolutionButtonClcik));
			this.m_skillDetailConfessionAndRewardMaleButton.onClick.AddListener(new UnityAction(this.OnConfessionAndRewardButtonClick));
			this.m_skillDetailConfessionAndRewardFemaleButton.onClick.AddListener(new UnityAction(this.OnConfessionAndRewardButtonClick));
			this.m_fastLevelButton.onClick.AddListener(new UnityAction(this.OnFastLevelButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600E260 RID: 57952 RVA: 0x003CF000 File Offset: 0x003CD200
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600E261 RID: 57953 RVA: 0x003CF060 File Offset: 0x003CD260
		public void UpdateViewInFettersConfession(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInFettersConfessionHero_hotfix != null)
			{
				this.m_UpdateViewInFettersConfessionHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_isMale = (this.m_hero.HeroInfo.Sex == 1);
			if (this.isFirstIn)
			{
				this.m_commonUIStateCtrl.SetToUIState("Show", false, true);
				this.isFirstIn = false;
			}
			this.m_playerResourceCrystalText.text = this.m_playerContext.GetCrystal().ToString();
			this.m_playerResourceGoldenText.text = this.m_playerContext.GetGold().ToString();
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_fastLevelButton.gameObject.SetActive(data.IsDeveloper);
			if (!this.m_hero.Confessed)
			{
				this.m_centerSkillStateCtrl.SetToUIState("Lock", false, true);
			}
			else if (this.m_isMale)
			{
				this.m_centerSkillStateCtrl.SetToUIState("MaleNormal", false, true);
			}
			else
			{
				this.m_centerSkillStateCtrl.SetToUIState("FemaleNormal", false, true);
			}
			List<int> heroFetters_ID = this.m_hero.HeroInfo.m_informationInfo.HeroFetters_ID;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_skillGroupContent, heroFetters_ID.Count);
			for (int i = 0; i < heroFetters_ID.Count; i++)
			{
				int num = heroFetters_ID[i];
				GameObject gameObject = this.m_skillGroupContent.transform.GetChild(i).gameObject;
				FettersConfessionSkillItemUIController component = gameObject.GetComponent<FettersConfessionSkillItemUIController>();
				if (component == null)
				{
					PrefabControllerCreater.CreateAllControllers(gameObject);
					component = gameObject.GetComponent<FettersConfessionSkillItemUIController>();
				}
				int favorabilityLevel = this.m_hero.FavorabilityLevel;
				bool hasUnLock = this.m_hero.Fetters.ContainsKey(num);
				int skillLv = 1;
				Dictionary<int, int> fetters = this.m_hero.Fetters;
				if (fetters.ContainsKey(num))
				{
					skillLv = fetters[num];
				}
				component.InitFettersConfessionSkillItem(num, favorabilityLevel, hasUnLock, skillLv);
				component.EventOnClick += this.OnFettersSkillItemClick;
				if (this.m_curFetterSkillCtrl == null)
				{
					this.m_curFetterSkillCtrl = component;
					this.m_curFetterSkillCtrl.ShowSelectImage(true);
				}
				else
				{
					this.m_curFetterSkillCtrl.ShowSelectImage(true);
				}
			}
			if (heroFetters_ID.Count > 0)
			{
				this.SetSkillDetailPanel(this.m_curFetterSkillCtrl.HeroFetterInfo);
			}
		}

		// Token: 0x0600E262 RID: 57954 RVA: 0x003CF324 File Offset: 0x003CD524
		private void SetSkillDetailPanel(ConfigDataHeroFetterInfo heroFetterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillDetailPanelConfigDataHeroFetterInfo_hotfix != null)
			{
				this.m_SetSkillDetailPanelConfigDataHeroFetterInfo_hotfix.call(new object[]
				{
					this,
					heroFetterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (heroFetterInfo == null)
			{
				return;
			}
			Dictionary<int, int> fetters = this.m_hero.Fetters;
			if (fetters.ContainsKey(heroFetterInfo.ID))
			{
				this.m_skillDetailStateCtrl.SetToUIState("Promote", false, true);
				this.SetSkillInfoGroup(heroFetterInfo);
				this.SetUnlockStateInfo(heroFetterInfo);
			}
			else
			{
				this.m_skillDetailStateCtrl.SetToUIState("LockAndUnlock", false, true);
				this.SetSkillInfoGroup(heroFetterInfo);
				this.SetLockStateInfo(heroFetterInfo);
			}
		}

		// Token: 0x0600E263 RID: 57955 RVA: 0x003CF400 File Offset: 0x003CD600
		private void SetSkillInfoGroup(ConfigDataHeroFetterInfo heroFetterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillInfoGroupConfigDataHeroFetterInfo_hotfix != null)
			{
				this.m_SetSkillInfoGroupConfigDataHeroFetterInfo_hotfix.call(new object[]
				{
					this,
					heroFetterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroConfessionInfo confessionInfo = this.m_hero.HeroInfo.m_informationInfo.m_confessionInfo;
			if (confessionInfo == null)
			{
				global::Debug.LogError("ConfessionInfo is null");
				return;
			}
			int num = 0;
			List<HeroConfessionUnlockCondition> unlockConditions = confessionInfo.UnlockConditions;
			foreach (HeroConfessionUnlockCondition heroConfessionUnlockCondition in unlockConditions)
			{
				if (heroConfessionUnlockCondition.FetterId == heroFetterInfo.ID)
				{
					num = heroConfessionUnlockCondition.FetterLevel;
				}
			}
			int maxLevel = heroFetterInfo.MaxLevel;
			bool flag = this.m_hero.FavorabilityLevel >= num;
			if (flag)
			{
				this.m_skillDetailInfoIconImage.sprite = AssetUtility.Instance.GetSprite(heroFetterInfo.Icon);
			}
			this.m_skillDetailInfoIconImage.gameObject.SetActive(flag);
			this.m_skillDetailInfoLockIconGo.SetActive(!flag);
			int num2 = 1;
			Dictionary<int, int> fetters = this.m_hero.Fetters;
			if (fetters.ContainsKey(heroFetterInfo.ID))
			{
				num2 = fetters[heroFetterInfo.ID];
			}
			this.m_skillDetailInfoSkillNameText.text = heroFetterInfo.Name;
			bool flag2 = num2 == maxLevel;
			if (!flag2)
			{
				this.m_skillDetailInfoSkillLvText.text = num2 + "/" + maxLevel;
			}
			this.m_skillDetailInfoSkillLvText.gameObject.SetActive(!flag2);
			this.m_skillDetailInfoSkillLvMaxText.SetActive(flag2);
		}

		// Token: 0x0600E264 RID: 57956 RVA: 0x003CF5F4 File Offset: 0x003CD7F4
		private void SetLockStateInfo(ConfigDataHeroFetterInfo heroFetterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockStateInfoConfigDataHeroFetterInfo_hotfix != null)
			{
				this.m_SetLockStateInfoConfigDataHeroFetterInfo_hotfix.call(new object[]
				{
					this,
					heroFetterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 1;
			Dictionary<int, int> fetters = this.m_hero.Fetters;
			if (fetters.ContainsKey(heroFetterInfo.ID))
			{
				num = fetters[heroFetterInfo.ID];
			}
			List<int> gotSkills_ID = heroFetterInfo.GotSkills_ID;
			ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(gotSkills_ID[num - 1]);
			this.m_skillDetailDescText.text = configDataSkillInfo.Desc;
			bool flag = false;
			List<HeroFetterCompletionCondition> completionConditions = heroFetterInfo.CompletionConditions;
			if (completionConditions.Count > 0)
			{
				this.m_skillDetailCondition1StateCtrl.gameObject.SetActive(true);
				HeroFetterCompletionCondition condition = completionConditions[0];
				this.m_skillDetailConditionUnlockInfoText1.text = this.GetFettersCoditionDesc(condition);
				bool flag2 = this.m_playerContext.CanReachFetterUnlockCondition(condition);
				if (flag2)
				{
					this.m_skillDetailCondition1StateCtrl.SetToUIState("Reach", false, true);
				}
				else
				{
					this.m_skillDetailCondition1StateCtrl.SetToUIState("UnReach", false, true);
				}
				flag = flag2;
			}
			else
			{
				this.m_skillDetailCondition1StateCtrl.gameObject.SetActive(false);
			}
			if (completionConditions.Count > 1)
			{
				this.m_skillDetailCondition2StateCtrl.gameObject.SetActive(true);
				HeroFetterCompletionCondition condition2 = completionConditions[1];
				this.m_skillDetailConditionUnlockInfoText2.text = this.GetFettersCoditionDesc(condition2);
				bool flag3 = this.m_playerContext.CanReachFetterUnlockCondition(completionConditions[1]);
				if (flag3)
				{
					this.m_skillDetailCondition2StateCtrl.SetToUIState("Reach", false, true);
				}
				else
				{
					this.m_skillDetailCondition2StateCtrl.SetToUIState("UnReach", false, true);
				}
				if (flag)
				{
					flag = flag3;
				}
			}
			else
			{
				this.m_skillDetailCondition2StateCtrl.gameObject.SetActive(false);
			}
			if (heroFetterInfo.Reward.Count > 0)
			{
				Goods goods = heroFetterInfo.Reward[0];
				this.m_skillDetailUnlockRewardNameText.text = UIUtility.GetGoodsName(goods.GoodsType, goods.Id);
				RewardGoodsUIController rewardGoodsUIController = this.m_skillDetailUnlockRewardGoods.GetComponent<RewardGoodsUIController>();
				if (rewardGoodsUIController == null)
				{
					rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(this.m_skillDetailUnlockRewardGoods);
				}
				rewardGoodsUIController.SetReward(goods, 1, true);
				rewardGoodsUIController.ShowCount(true);
			}
			if (flag)
			{
				this.m_skillDetailUnlockButtonStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_skillDetailUnlockButtonStateCtrl.SetToUIState("Grey", false, true);
			}
		}

		// Token: 0x0600E265 RID: 57957 RVA: 0x003CF8A4 File Offset: 0x003CDAA4
		private string GetFettersCoditionDesc(HeroFetterCompletionCondition condition)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFettersCoditionDescHeroFetterCompletionCondition_hotfix != null)
			{
				return (string)this.m_GetFettersCoditionDescHeroFetterCompletionCondition_hotfix.call(new object[]
				{
					this,
					condition
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FetterCompleteConditionType conditionType = condition.ConditionType;
			if (conditionType == FetterCompleteConditionType.FetterCompleteConditionType_HeroFavorabilityLevel)
			{
				string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_HeroFavorabilityLimit);
				string name = this.m_configDataLoader.GetConfigDataHeroInfo(condition.Parm1).Name;
				return string.Format(format, name, condition.Parm2);
			}
			if (conditionType != FetterCompleteConditionType.FetterCompleteConditionType_Mission)
			{
				return string.Empty;
			}
			ConfigDataMissionInfo configDataMissionInfo = this.m_configDataLoader.GetConfigDataMissionInfo(condition.Parm1);
			return configDataMissionInfo.Desc;
		}

		// Token: 0x0600E266 RID: 57958 RVA: 0x003CF99C File Offset: 0x003CDB9C
		private void SetUnlockStateInfo(ConfigDataHeroFetterInfo heroFetterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnlockStateInfoConfigDataHeroFetterInfo_hotfix != null)
			{
				this.m_SetUnlockStateInfoConfigDataHeroFetterInfo_hotfix.call(new object[]
				{
					this,
					heroFetterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 1;
			Dictionary<int, int> fetters = this.m_hero.Fetters;
			if (fetters.ContainsKey(heroFetterInfo.ID))
			{
				num = fetters[heroFetterInfo.ID];
			}
			List<int> gotSkills_ID = heroFetterInfo.GotSkills_ID;
			bool flag = num == gotSkills_ID.Count;
			if (flag)
			{
				this.m_skillDetailUnlockStateCtrl.SetToUIState("Max", false, true);
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(gotSkills_ID[gotSkills_ID.Count - 1]);
				this.m_skillDetailUnlockStateNowInfoText.text = configDataSkillInfo.Desc;
			}
			else
			{
				this.m_skillDetailUnlockStateCtrl.SetToUIState("Normal", false, true);
				ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(gotSkills_ID[num - 1]);
				this.m_skillDetailUnlockStateNowInfoText.text = configDataSkillInfo2.Desc;
				ConfigDataSkillInfo configDataSkillInfo3 = this.m_configDataLoader.GetConfigDataSkillInfo(gotSkills_ID[num]);
				this.m_skillDetailUnlockStateAfterText.text = configDataSkillInfo3.Desc;
				int num2 = 0;
				if (heroFetterInfo.LevelUpGold.Count >= num)
				{
					num2 = heroFetterInfo.LevelUpGold[num - 1];
				}
				this.m_skillDetailUnlockStateConsumeValueText.text = num2.ToString();
				if (num2 <= this.m_playerContext.GetGold())
				{
					this.m_skillDetailUnlockStateConsumeTextStateCtrl.SetToUIState("White", false, true);
				}
				else
				{
					this.m_skillDetailUnlockStateConsumeTextStateCtrl.SetToUIState("Red", false, true);
				}
				List<HeroFetterLevelUpCost> list = new List<HeroFetterLevelUpCost>();
				foreach (HeroFetterLevelUpCost heroFetterLevelUpCost in heroFetterInfo.LevelUpMaterials)
				{
					if (heroFetterLevelUpCost.Level == num + 1)
					{
						list.Add(heroFetterLevelUpCost);
					}
				}
				if (list.Count > 0)
				{
					HeroFetterLevelUpCost heroFetterLevelUpCost2 = list[0];
					FettersConfessionEvolutionMaterialUIController component = this.m_skillDetailUnlockEvolutionMaterial1.GetComponent<FettersConfessionEvolutionMaterialUIController>();
					if (component == null)
					{
						PrefabControllerCreater.CreateAllControllers(this.m_skillDetailUnlockEvolutionMaterial1);
						component = this.m_skillDetailUnlockEvolutionMaterial1.GetComponent<FettersConfessionEvolutionMaterialUIController>();
						component.EventOnClick += this.OnEvolutionMaterialClick;
					}
					component.InitFettersConfessionEvolutionMaterial(heroFetterLevelUpCost2.ItemType, heroFetterLevelUpCost2.ItemId, heroFetterLevelUpCost2.Count);
					this.m_skillDetailUnlockEvolutionMaterialStateCtrl1.SetToUIState("Have", false, true);
				}
				else
				{
					this.m_skillDetailUnlockEvolutionMaterialStateCtrl1.SetToUIState("Empty", false, true);
				}
				if (list.Count > 1)
				{
					HeroFetterLevelUpCost heroFetterLevelUpCost3 = list[1];
					FettersConfessionEvolutionMaterialUIController component2 = this.m_skillDetailUnlockEvolutionMaterial2.GetComponent<FettersConfessionEvolutionMaterialUIController>();
					if (component2 == null)
					{
						PrefabControllerCreater.CreateAllControllers(this.m_skillDetailUnlockEvolutionMaterial2);
						component2 = this.m_skillDetailUnlockEvolutionMaterial2.GetComponent<FettersConfessionEvolutionMaterialUIController>();
						component2.EventOnClick += this.OnEvolutionMaterialClick;
					}
					component2.InitFettersConfessionEvolutionMaterial(heroFetterLevelUpCost3.ItemType, heroFetterLevelUpCost3.ItemId, heroFetterLevelUpCost3.Count);
					this.m_skillDetailUnlockEvolutionMaterialStateCtrl2.SetToUIState("Have", false, true);
				}
				else
				{
					this.m_skillDetailUnlockEvolutionMaterialStateCtrl2.SetToUIState("Empty", false, true);
				}
			}
		}

		// Token: 0x0600E267 RID: 57959 RVA: 0x003CFD18 File Offset: 0x003CDF18
		private void SetConfessionAndRewardInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetConfessionAndRewardInfo_hotfix != null)
			{
				this.m_SetConfessionAndRewardInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroConfessionInfo confessionInfo = this.m_hero.HeroInfo.m_informationInfo.m_confessionInfo;
			if (confessionInfo == null)
			{
				return;
			}
			List<HeroConfessionUnlockCondition> unlockConditions = confessionInfo.UnlockConditions;
			GameObjectUtility.DestroyChildren(this.m_skillDetailConfessionAndRewardScrollViewContent);
			Dictionary<int, int> fetters = this.m_hero.Fetters;
			foreach (HeroConfessionUnlockCondition heroConfessionUnlockCondition in unlockConditions)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_skillDetailUnlockStateConditionPrefab);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				FettersConfessionUnlockConditionUIController component = gameObject.GetComponent<FettersConfessionUnlockConditionUIController>();
				int favorabilityLevel = this.m_hero.FavorabilityLevel;
				int curLevel = 1;
				if (fetters.ContainsKey(heroConfessionUnlockCondition.FetterId))
				{
					curLevel = fetters[heroConfessionUnlockCondition.FetterId];
				}
				component.InitFettersConfessionUnlockCondition(heroConfessionUnlockCondition.FetterId, heroConfessionUnlockCondition.FetterLevel, fetters.ContainsKey(heroConfessionUnlockCondition.FetterId), curLevel);
				gameObject.transform.SetParent(this.m_skillDetailConfessionAndRewardScrollViewContent.transform, false);
			}
			Goods goods = confessionInfo.Reward[0];
			if (this.m_isMale)
			{
				this.m_skillDetailConfessionAndRewardStateCtrl.SetToUIState("Male", false, true);
				this.m_skillDetailConfessionAndRewardMaleRewardGoodsNameText.text = UIUtility.GetGoodsName(goods.GoodsType, goods.Id) + " x " + goods.Count;
				RewardGoodsUIController rewardGoodsUIController = this.m_skillDetailConfessionAndRewardMaleRewardGoods.GetComponent<RewardGoodsUIController>();
				if (rewardGoodsUIController == null)
				{
					rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(this.m_skillDetailConfessionAndRewardMaleRewardGoods);
				}
				rewardGoodsUIController.SetReward(goods, 1, true);
				rewardGoodsUIController.ShowCount(false);
			}
			else
			{
				this.m_skillDetailConfessionAndRewardStateCtrl.SetToUIState("Female", false, true);
				this.m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText.text = UIUtility.GetGoodsName(goods.GoodsType, goods.Id) + " x " + goods.Count;
				RewardGoodsUIController rewardGoodsUIController2 = this.m_skillDetailConfessionAndRewardFemaleRewardGoods.GetComponent<RewardGoodsUIController>();
				if (rewardGoodsUIController2 == null)
				{
					rewardGoodsUIController2 = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(this.m_skillDetailConfessionAndRewardFemaleRewardGoods);
				}
				rewardGoodsUIController2.SetReward(goods, 1, true);
				rewardGoodsUIController2.ShowCount(false);
			}
		}

		// Token: 0x0600E268 RID: 57960 RVA: 0x003CFF9C File Offset: 0x003CE19C
		private void OnFettersSkillItemClick(FettersConfessionSkillItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFettersSkillItemClickFettersConfessionSkillItemUIController_hotfix != null)
			{
				this.m_OnFettersSkillItemClickFettersConfessionSkillItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curFetterSkillCtrl = ctrl;
			this.SetSkillDetailPanel(this.m_curFetterSkillCtrl.HeroFetterInfo);
		}

		// Token: 0x0600E269 RID: 57961 RVA: 0x003D0024 File Offset: 0x003CE224
		private void OnConfessionToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfessionToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnConfessionToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_ConfessionFeatureClosed, 2f, null, true);
			}
		}

		// Token: 0x0600E26A RID: 57962 RVA: 0x003D00B0 File Offset: 0x003CE2B0
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

		// Token: 0x0600E26B RID: 57963 RVA: 0x003D015C File Offset: 0x003CE35C
		private void OnSkillUnlockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillUnlockButtonClick_hotfix != null)
			{
				this.m_OnSkillUnlockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanUnlockHeroFetter(this.m_hero.HeroId, this.m_curFetterSkillCtrl.HeroFetterInfo.ID);
			if (num == 0)
			{
				if (this.EventOnSkillUnlockButtonClick != null)
				{
					this.EventOnSkillUnlockButtonClick(this.m_hero.HeroId, this.m_curFetterSkillCtrl.HeroFetterInfo.ID, delegate(List<Goods> rewards)
					{
						if (this.m_curFetterSkillCtrl != null)
						{
							this.m_curFetterSkillCtrl.PlayUnlockEffect(rewards);
						}
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600E26C RID: 57964 RVA: 0x003D0240 File Offset: 0x003CE440
		private void OnSkillDetailUnlockGreyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillDetailUnlockGreyButtonClick_hotfix != null)
			{
				this.m_OnSkillDetailUnlockGreyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanUnlockHeroFetter(this.m_hero.HeroId, this.m_curFetterSkillCtrl.HeroFetterInfo.ID);
			if (num != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600E26D RID: 57965 RVA: 0x003D02E0 File Offset: 0x003CE4E0
		private void OnUnlockStateEvolutionButtonClcik()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUnlockStateEvolutionButtonClcik_hotfix != null)
			{
				this.m_OnUnlockStateEvolutionButtonClcik_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanLevelUpHeroFetter(this.m_hero.HeroId, this.m_curFetterSkillCtrl.HeroFetterInfo.ID);
			if (num == 0)
			{
				if (this.EventOnEvolutionButtonClick != null)
				{
					this.EventOnEvolutionButtonClick(this.m_hero.HeroId, this.m_curFetterSkillCtrl.HeroFetterInfo.ID, delegate
					{
						if (this.m_curFetterSkillCtrl != null)
						{
							this.m_curFetterSkillCtrl.PlayPromoteEffect();
						}
						this.m_skillDetailEnhanceSuccessEffectPanelStateCtrl.gameObject.SetActive(true);
						UIUtility.SetUIStateOpen(this.m_skillDetailEnhanceSuccessEffectPanelStateCtrl, "Show", delegate
						{
							this.m_skillDetailEnhanceSuccessEffectPanelStateCtrl.gameObject.SetActive(false);
						}, true, true);
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600E26E RID: 57966 RVA: 0x003D03C4 File Offset: 0x003CE5C4
		private void OnConfessionAndRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfessionAndRewardButtonClick_hotfix != null)
			{
				this.m_OnConfessionAndRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanConfessHero(this.m_hero.HeroId);
			if (num == 0)
			{
				if (this.EventOnHeroFetterConfess != null)
				{
					this.EventOnHeroFetterConfess(this.m_hero.HeroId);
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0600E26F RID: 57967 RVA: 0x003D047C File Offset: 0x003CE67C
		public void OnConfessionAndRewardSucceedEffect(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfessionAndRewardSucceedEffectList`1_hotfix != null)
			{
				this.m_OnConfessionAndRewardSucceedEffectList`1_hotfix.call(new object[]
				{
					this,
					rewards2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> rewards = rewards2;
			FettersConfessionUIController $this = this;
			if (this.m_isMale)
			{
				this.m_centerSkillStateCtrl.SetActionForUIStateFinshed("ChangeMale", delegate
				{
					if (rewards != null && rewards.Count != 0)
					{
						GetRewardGoodsUITask.StartUITask(rewards);
					}
				});
				this.m_centerSkillStateCtrl.SetToUIState("ChangeMale", false, true);
			}
			else
			{
				this.m_centerSkillStateCtrl.SetActionForUIStateFinshed("ChangeFemale", delegate
				{
					int dialogID = $this.m_hero.HeroInfo.m_informationInfo.m_confessionInfo.DialogID;
				});
				this.m_centerSkillStateCtrl.SetToUIState("ChangeFemale", false, true);
			}
		}

		// Token: 0x0600E270 RID: 57968 RVA: 0x003D0570 File Offset: 0x003CE770
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
			this.isFirstIn = true;
		}

		// Token: 0x0600E271 RID: 57969 RVA: 0x003D05F0 File Offset: 0x003CE7F0
		private void OnFastLevelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFastLevelButtonClick_hotfix != null)
			{
				this.m_OnFastLevelButtonClick_hotfix.call(new object[]
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
			int heroFetterId = this.m_curFetterSkillCtrl.HeroFetterInfo.ID;
			if (!this.m_hero.Fetters.ContainsKey(heroFetterId))
			{
				CommonUIController.Instance.ShowMessage("Unlock!", 2f, null, true);
				return;
			}
			string text = this.m_fastLevelButtonInputField.text;
			int lv = 0;
			if (!int.TryParse(text, out lv))
			{
				CommonUIController.Instance.ShowMessage("Level Illegal!", 2f, null, true);
				return;
			}
			string cmd = string.Concat(new object[]
			{
				"LevelUpHeroFetter ",
				this.m_hero.HeroId,
				";",
				heroFetterId,
				";",
				lv
			});
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.m_playerContext.GmLevelUpHeroFetter2SpecificLevel(this.m_hero.HeroId, heroFetterId, lv);
					CommonUIController.Instance.ShowMessage("Level Succeed!", 2f, null, true);
					this.UpdateViewInFettersConfession(this.m_hero);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600E272 RID: 57970 RVA: 0x003D0764 File Offset: 0x003CE964
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

		// Token: 0x0600E273 RID: 57971 RVA: 0x003D07DC File Offset: 0x003CE9DC
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
			if (this.EventOnGoldAdd != null)
			{
				this.EventOnGoldAdd();
			}
		}

		// Token: 0x0600E274 RID: 57972 RVA: 0x003D0854 File Offset: 0x003CEA54
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

		// Token: 0x140002D5 RID: 725
		// (add) Token: 0x0600E275 RID: 57973 RVA: 0x003D08CC File Offset: 0x003CEACC
		// (remove) Token: 0x0600E276 RID: 57974 RVA: 0x003D0968 File Offset: 0x003CEB68
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

		// Token: 0x140002D6 RID: 726
		// (add) Token: 0x0600E277 RID: 57975 RVA: 0x003D0A04 File Offset: 0x003CEC04
		// (remove) Token: 0x0600E278 RID: 57976 RVA: 0x003D0AA0 File Offset: 0x003CECA0
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

		// Token: 0x140002D7 RID: 727
		// (add) Token: 0x0600E279 RID: 57977 RVA: 0x003D0B3C File Offset: 0x003CED3C
		// (remove) Token: 0x0600E27A RID: 57978 RVA: 0x003D0BD8 File Offset: 0x003CEDD8
		public event Action EventOnGoldAdd
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoldAddAction_hotfix != null)
				{
					this.m_add_EventOnGoldAddAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoldAdd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoldAdd, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoldAddAction_hotfix != null)
				{
					this.m_remove_EventOnGoldAddAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoldAdd;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoldAdd, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002D8 RID: 728
		// (add) Token: 0x0600E27B RID: 57979 RVA: 0x003D0C74 File Offset: 0x003CEE74
		// (remove) Token: 0x0600E27C RID: 57980 RVA: 0x003D0D10 File Offset: 0x003CEF10
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

		// Token: 0x140002D9 RID: 729
		// (add) Token: 0x0600E27D RID: 57981 RVA: 0x003D0DAC File Offset: 0x003CEFAC
		// (remove) Token: 0x0600E27E RID: 57982 RVA: 0x003D0E48 File Offset: 0x003CF048
		public event Action<int> EventOnHeroFetterConfess
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroFetterConfessAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroFetterConfessAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroFetterConfess;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroFetterConfess, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroFetterConfessAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroFetterConfessAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroFetterConfess;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroFetterConfess, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002DA RID: 730
		// (add) Token: 0x0600E27F RID: 57983 RVA: 0x003D0EE4 File Offset: 0x003CF0E4
		// (remove) Token: 0x0600E280 RID: 57984 RVA: 0x003D0F80 File Offset: 0x003CF180
		public event Action<int, int, Action> EventOnEvolutionButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEvolutionButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnEvolutionButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnEvolutionButtonClick;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnEvolutionButtonClick, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEvolutionButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnEvolutionButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnEvolutionButtonClick;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnEvolutionButtonClick, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002DB RID: 731
		// (add) Token: 0x0600E281 RID: 57985 RVA: 0x003D101C File Offset: 0x003CF21C
		// (remove) Token: 0x0600E282 RID: 57986 RVA: 0x003D10B8 File Offset: 0x003CF2B8
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

		// Token: 0x140002DC RID: 732
		// (add) Token: 0x0600E283 RID: 57987 RVA: 0x003D1154 File Offset: 0x003CF354
		// (remove) Token: 0x0600E284 RID: 57988 RVA: 0x003D11F0 File Offset: 0x003CF3F0
		public event Action<int, int, Action<List<Goods>>> EventOnSkillUnlockButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkillUnlockButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnSkillUnlockButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action<List<Goods>>> action = this.EventOnSkillUnlockButtonClick;
				Action<int, int, Action<List<Goods>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action<List<Goods>>>>(ref this.EventOnSkillUnlockButtonClick, (Action<int, int, Action<List<Goods>>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkillUnlockButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnSkillUnlockButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action<List<Goods>>> action = this.EventOnSkillUnlockButtonClick;
				Action<int, int, Action<List<Goods>>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action<List<Goods>>>>(ref this.EventOnSkillUnlockButtonClick, (Action<int, int, Action<List<Goods>>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600E285 RID: 57989 RVA: 0x003D128C File Offset: 0x003CF48C
		// (set) Token: 0x0600E286 RID: 57990 RVA: 0x003D12AC File Offset: 0x003CF4AC
		[DoNotToLua]
		public new FettersConfessionUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersConfessionUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E287 RID: 57991 RVA: 0x003D12B8 File Offset: 0x003CF4B8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E288 RID: 57992 RVA: 0x003D12C4 File Offset: 0x003CF4C4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E289 RID: 57993 RVA: 0x003D12CC File Offset: 0x003CF4CC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E28A RID: 57994 RVA: 0x003D12D4 File Offset: 0x003CF4D4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E28B RID: 57995 RVA: 0x003D12E8 File Offset: 0x003CF4E8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E28C RID: 57996 RVA: 0x003D12F0 File Offset: 0x003CF4F0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E28D RID: 57997 RVA: 0x003D12FC File Offset: 0x003CF4FC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E28E RID: 57998 RVA: 0x003D1308 File Offset: 0x003CF508
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E28F RID: 57999 RVA: 0x003D1314 File Offset: 0x003CF514
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E290 RID: 58000 RVA: 0x003D1320 File Offset: 0x003CF520
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x003D132C File Offset: 0x003CF52C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E292 RID: 58002 RVA: 0x003D1338 File Offset: 0x003CF538
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E293 RID: 58003 RVA: 0x003D1344 File Offset: 0x003CF544
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E294 RID: 58004 RVA: 0x003D1350 File Offset: 0x003CF550
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E295 RID: 58005 RVA: 0x003D135C File Offset: 0x003CF55C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x003D1364 File Offset: 0x003CF564
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x003D1384 File Offset: 0x003CF584
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600E298 RID: 58008 RVA: 0x003D1390 File Offset: 0x003CF590
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600E299 RID: 58009 RVA: 0x003D13B0 File Offset: 0x003CF5B0
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600E29A RID: 58010 RVA: 0x003D13BC File Offset: 0x003CF5BC
		private void __callDele_EventOnGoldAdd()
		{
			Action eventOnGoldAdd = this.EventOnGoldAdd;
			if (eventOnGoldAdd != null)
			{
				eventOnGoldAdd();
			}
		}

		// Token: 0x0600E29B RID: 58011 RVA: 0x003D13DC File Offset: 0x003CF5DC
		private void __clearDele_EventOnGoldAdd()
		{
			this.EventOnGoldAdd = null;
		}

		// Token: 0x0600E29C RID: 58012 RVA: 0x003D13E8 File Offset: 0x003CF5E8
		private void __callDele_EventOnAddCrystal()
		{
			Action eventOnAddCrystal = this.EventOnAddCrystal;
			if (eventOnAddCrystal != null)
			{
				eventOnAddCrystal();
			}
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x003D1408 File Offset: 0x003CF608
		private void __clearDele_EventOnAddCrystal()
		{
			this.EventOnAddCrystal = null;
		}

		// Token: 0x0600E29E RID: 58014 RVA: 0x003D1414 File Offset: 0x003CF614
		private void __callDele_EventOnHeroFetterConfess(int obj)
		{
			Action<int> eventOnHeroFetterConfess = this.EventOnHeroFetterConfess;
			if (eventOnHeroFetterConfess != null)
			{
				eventOnHeroFetterConfess(obj);
			}
		}

		// Token: 0x0600E29F RID: 58015 RVA: 0x003D1438 File Offset: 0x003CF638
		private void __clearDele_EventOnHeroFetterConfess(int obj)
		{
			this.EventOnHeroFetterConfess = null;
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x003D1444 File Offset: 0x003CF644
		private void __callDele_EventOnEvolutionButtonClick(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnEvolutionButtonClick = this.EventOnEvolutionButtonClick;
			if (eventOnEvolutionButtonClick != null)
			{
				eventOnEvolutionButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x003D1468 File Offset: 0x003CF668
		private void __clearDele_EventOnEvolutionButtonClick(int arg1, int arg2, Action arg3)
		{
			this.EventOnEvolutionButtonClick = null;
		}

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x003D1474 File Offset: 0x003CF674
		private void __callDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnEvolutionMaterialClick = this.EventOnEvolutionMaterialClick;
			if (eventOnEvolutionMaterialClick != null)
			{
				eventOnEvolutionMaterialClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600E2A3 RID: 58019 RVA: 0x003D1498 File Offset: 0x003CF698
		private void __clearDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnEvolutionMaterialClick = null;
		}

		// Token: 0x0600E2A4 RID: 58020 RVA: 0x003D14A4 File Offset: 0x003CF6A4
		private void __callDele_EventOnSkillUnlockButtonClick(int arg1, int arg2, Action<List<Goods>> arg3)
		{
			Action<int, int, Action<List<Goods>>> eventOnSkillUnlockButtonClick = this.EventOnSkillUnlockButtonClick;
			if (eventOnSkillUnlockButtonClick != null)
			{
				eventOnSkillUnlockButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600E2A5 RID: 58021 RVA: 0x003D14C8 File Offset: 0x003CF6C8
		private void __clearDele_EventOnSkillUnlockButtonClick(int arg1, int arg2, Action<List<Goods>> arg3)
		{
			this.EventOnSkillUnlockButtonClick = null;
		}

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x003D1560 File Offset: 0x003CF760
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
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_UpdateViewInFettersConfessionHero_hotfix = (luaObj.RawGet("UpdateViewInFettersConfession") as LuaFunction);
					this.m_SetSkillDetailPanelConfigDataHeroFetterInfo_hotfix = (luaObj.RawGet("SetSkillDetailPanel") as LuaFunction);
					this.m_SetSkillInfoGroupConfigDataHeroFetterInfo_hotfix = (luaObj.RawGet("SetSkillInfoGroup") as LuaFunction);
					this.m_SetLockStateInfoConfigDataHeroFetterInfo_hotfix = (luaObj.RawGet("SetLockStateInfo") as LuaFunction);
					this.m_GetFettersCoditionDescHeroFetterCompletionCondition_hotfix = (luaObj.RawGet("GetFettersCoditionDesc") as LuaFunction);
					this.m_SetUnlockStateInfoConfigDataHeroFetterInfo_hotfix = (luaObj.RawGet("SetUnlockStateInfo") as LuaFunction);
					this.m_SetConfessionAndRewardInfo_hotfix = (luaObj.RawGet("SetConfessionAndRewardInfo") as LuaFunction);
					this.m_OnFettersSkillItemClickFettersConfessionSkillItemUIController_hotfix = (luaObj.RawGet("OnFettersSkillItemClick") as LuaFunction);
					this.m_OnConfessionToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnConfessionToggleValueChanged") as LuaFunction);
					this.m_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("OnEvolutionMaterialClick") as LuaFunction);
					this.m_OnSkillUnlockButtonClick_hotfix = (luaObj.RawGet("OnSkillUnlockButtonClick") as LuaFunction);
					this.m_OnSkillDetailUnlockGreyButtonClick_hotfix = (luaObj.RawGet("OnSkillDetailUnlockGreyButtonClick") as LuaFunction);
					this.m_OnUnlockStateEvolutionButtonClcik_hotfix = (luaObj.RawGet("OnUnlockStateEvolutionButtonClcik") as LuaFunction);
					this.m_OnConfessionAndRewardButtonClick_hotfix = (luaObj.RawGet("OnConfessionAndRewardButtonClick") as LuaFunction);
					this.m_OnConfessionAndRewardSucceedEffectList`1_hotfix = (luaObj.RawGet("OnConfessionAndRewardSucceedEffect") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnFastLevelButtonClick_hotfix = (luaObj.RawGet("OnFastLevelButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnGoldAddButtonClick_hotfix = (luaObj.RawGet("OnGoldAddButtonClick") as LuaFunction);
					this.m_OnCrystalAddButtonClick_hotfix = (luaObj.RawGet("OnCrystalAddButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnGoldAddAction_hotfix = (luaObj.RawGet("add_EventOnGoldAdd") as LuaFunction);
					this.m_remove_EventOnGoldAddAction_hotfix = (luaObj.RawGet("remove_EventOnGoldAdd") as LuaFunction);
					this.m_add_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("add_EventOnAddCrystal") as LuaFunction);
					this.m_remove_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("remove_EventOnAddCrystal") as LuaFunction);
					this.m_add_EventOnHeroFetterConfessAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroFetterConfess") as LuaFunction);
					this.m_remove_EventOnHeroFetterConfessAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroFetterConfess") as LuaFunction);
					this.m_add_EventOnEvolutionButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnEvolutionButtonClick") as LuaFunction);
					this.m_remove_EventOnEvolutionButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnEvolutionButtonClick") as LuaFunction);
					this.m_add_EventOnEvolutionMaterialClickAction`3_hotfix = (luaObj.RawGet("add_EventOnEvolutionMaterialClick") as LuaFunction);
					this.m_remove_EventOnEvolutionMaterialClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnEvolutionMaterialClick") as LuaFunction);
					this.m_add_EventOnSkillUnlockButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnSkillUnlockButtonClick") as LuaFunction);
					this.m_remove_EventOnSkillUnlockButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnSkillUnlockButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x003D19C8 File Offset: 0x003CFBC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersConfessionUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400892D RID: 35117
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400892E RID: 35118
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateCtrl;

		// Token: 0x0400892F RID: 35119
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008930 RID: 35120
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04008931 RID: 35121
		[AutoBind("./SkillPanel/Skill5Group", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillGroupContent;

		// Token: 0x04008932 RID: 35122
		[AutoBind("./SkillPanel/CenterEvent", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_centerSkillStateCtrl;

		// Token: 0x04008933 RID: 35123
		[AutoBind("./SkillPanel/CenterEvent", AutoBindAttribute.InitState.NotInit, false)]
		private ToggleEx m_confessionToggle;

		// Token: 0x04008934 RID: 35124
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailStateCtrl;

		// Token: 0x04008935 RID: 35125
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/SkillInfoGroup/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillDetailInfoIconImage;

		// Token: 0x04008936 RID: 35126
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/SkillInfoGroup/LockIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailInfoLockIconGo;

		// Token: 0x04008937 RID: 35127
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/SkillInfoGroup/SkillNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailInfoSkillNameText;

		// Token: 0x04008938 RID: 35128
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/SkillInfoGroup/LvGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailInfoSkillLvText;

		// Token: 0x04008939 RID: 35129
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/SkillInfoGroup/LvGroup/Max", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailInfoSkillLvMaxText;

		// Token: 0x0400893A RID: 35130
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/ConditionGroup/FetterEffect/UnlockInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailDescText;

		// Token: 0x0400893B RID: 35131
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/ConditionGroup/UnlockCondition/ConditionGroup/UnlockInfo1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailCondition1StateCtrl;

		// Token: 0x0400893C RID: 35132
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/ConditionGroup/UnlockCondition/ConditionGroup/UnlockInfo1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailConditionUnlockInfoText1;

		// Token: 0x0400893D RID: 35133
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/ConditionGroup/UnlockCondition/ConditionGroup/UnlockInfo2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailCondition2StateCtrl;

		// Token: 0x0400893E RID: 35134
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/ConditionGroup/UnlockCondition/ConditionGroup/UnlockInfo2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailConditionUnlockInfoText2;

		// Token: 0x0400893F RID: 35135
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/UnlockReward/ItemDummy/RewardGoods", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailUnlockRewardGoods;

		// Token: 0x04008940 RID: 35136
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/UnlockReward/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillDetailUnlockButton;

		// Token: 0x04008941 RID: 35137
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/UnlockReward/Button", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailUnlockButtonStateCtrl;

		// Token: 0x04008942 RID: 35138
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/UnlockReward/Button/Grey", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillDetailUnlockGreyButton;

		// Token: 0x04008943 RID: 35139
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/LockAndUnlockState/UnlockReward/ItemNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailUnlockRewardNameText;

		// Token: 0x04008944 RID: 35140
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailUnlockStateCtrl;

		// Token: 0x04008945 RID: 35141
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/NowInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailUnlockStateNowInfoText;

		// Token: 0x04008946 RID: 35142
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/AfterText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailUnlockStateAfterText;

		// Token: 0x04008947 RID: 35143
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/ConsumeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailUnlockStateConsumeTextStateCtrl;

		// Token: 0x04008948 RID: 35144
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/ConsumeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailUnlockStateConsumeValueText;

		// Token: 0x04008949 RID: 35145
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/EvolutionMaterial1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailUnlockEvolutionMaterial1;

		// Token: 0x0400894A RID: 35146
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/EvolutionMaterial2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailUnlockEvolutionMaterial2;

		// Token: 0x0400894B RID: 35147
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/EvolutionMaterial1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailUnlockEvolutionMaterialStateCtrl1;

		// Token: 0x0400894C RID: 35148
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/EvolutionMaterial2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailUnlockEvolutionMaterialStateCtrl2;

		// Token: 0x0400894D RID: 35149
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/PromoteState/AfterInfoPanel/EvolutionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillDetailUnlockStateEvolutionButton;

		// Token: 0x0400894E RID: 35150
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/EnhanceSuccessEffectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailEnhanceSuccessEffectPanelStateCtrl;

		// Token: 0x0400894F RID: 35151
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_skillDetailConfessionAndRewardStateCtrl;

		// Token: 0x04008950 RID: 35152
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/ConditionScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailConfessionAndRewardScrollViewContent;

		// Token: 0x04008951 RID: 35153
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/Female/RewardGroup/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillDetailConfessionAndRewardFemaleButton;

		// Token: 0x04008952 RID: 35154
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/Female/RewardGroup/ItemDummy/RewardGoods", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailConfessionAndRewardFemaleRewardGoods;

		// Token: 0x04008953 RID: 35155
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/Female/RewardGroup/ItemNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText;

		// Token: 0x04008954 RID: 35156
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/Male/RewardGroup/Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillDetailConfessionAndRewardMaleButton;

		// Token: 0x04008955 RID: 35157
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/Male/RewardGroup/ItemDummy/RewardGoods", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailConfessionAndRewardMaleRewardGoods;

		// Token: 0x04008956 RID: 35158
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/ConfessionAndReward/Male/RewardGroup/ItemNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillDetailConfessionAndRewardMaleRewardGoodsNameText;

		// Token: 0x04008957 RID: 35159
		[AutoBind("./Prefab/Condition", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailUnlockStateConditionPrefab;

		// Token: 0x04008958 RID: 35160
		[AutoBind("./PlayerResource/Crystal/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerResourceCrystalText;

		// Token: 0x04008959 RID: 35161
		[AutoBind("./PlayerResource/Crystal/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerResourceCrystalAddButton;

		// Token: 0x0400895A RID: 35162
		[AutoBind("./PlayerResource/Golden/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerResourceGoldenText;

		// Token: 0x0400895B RID: 35163
		[AutoBind("./PlayerResource/Golden/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerResourceGoldenAddButton;

		// Token: 0x0400895C RID: 35164
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/FastLevelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fastLevelButton;

		// Token: 0x0400895D RID: 35165
		[AutoBind("./Margin/SpiritEventInfoPanel/Detail/FastLevelButton/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_fastLevelButtonInputField;

		// Token: 0x0400895E RID: 35166
		private Hero m_hero;

		// Token: 0x0400895F RID: 35167
		private bool isFirstIn = true;

		// Token: 0x04008960 RID: 35168
		private bool m_isMale;

		// Token: 0x04008961 RID: 35169
		private FettersConfessionSkillItemUIController m_curFetterSkillCtrl;

		// Token: 0x04008962 RID: 35170
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008963 RID: 35171
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008964 RID: 35172
		[DoNotToLua]
		private FettersConfessionUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008965 RID: 35173
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008966 RID: 35174
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008967 RID: 35175
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008968 RID: 35176
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008969 RID: 35177
		private LuaFunction m_UpdateViewInFettersConfessionHero_hotfix;

		// Token: 0x0400896A RID: 35178
		private LuaFunction m_SetSkillDetailPanelConfigDataHeroFetterInfo_hotfix;

		// Token: 0x0400896B RID: 35179
		private LuaFunction m_SetSkillInfoGroupConfigDataHeroFetterInfo_hotfix;

		// Token: 0x0400896C RID: 35180
		private LuaFunction m_SetLockStateInfoConfigDataHeroFetterInfo_hotfix;

		// Token: 0x0400896D RID: 35181
		private LuaFunction m_GetFettersCoditionDescHeroFetterCompletionCondition_hotfix;

		// Token: 0x0400896E RID: 35182
		private LuaFunction m_SetUnlockStateInfoConfigDataHeroFetterInfo_hotfix;

		// Token: 0x0400896F RID: 35183
		private LuaFunction m_SetConfessionAndRewardInfo_hotfix;

		// Token: 0x04008970 RID: 35184
		private LuaFunction m_OnFettersSkillItemClickFettersConfessionSkillItemUIController_hotfix;

		// Token: 0x04008971 RID: 35185
		private LuaFunction m_OnConfessionToggleValueChangedBoolean_hotfix;

		// Token: 0x04008972 RID: 35186
		private LuaFunction m_OnEvolutionMaterialClickGoodsTypeInt32Int32_hotfix;

		// Token: 0x04008973 RID: 35187
		private LuaFunction m_OnSkillUnlockButtonClick_hotfix;

		// Token: 0x04008974 RID: 35188
		private LuaFunction m_OnSkillDetailUnlockGreyButtonClick_hotfix;

		// Token: 0x04008975 RID: 35189
		private LuaFunction m_OnUnlockStateEvolutionButtonClcik_hotfix;

		// Token: 0x04008976 RID: 35190
		private LuaFunction m_OnConfessionAndRewardButtonClick_hotfix;

		// Token: 0x04008977 RID: 35191
		private LuaFunction m_OnConfessionAndRewardSucceedEffectList;

		// Token: 0x04008978 RID: 35192
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008979 RID: 35193
		private LuaFunction m_OnFastLevelButtonClick_hotfix;

		// Token: 0x0400897A RID: 35194
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400897B RID: 35195
		private LuaFunction m_OnGoldAddButtonClick_hotfix;

		// Token: 0x0400897C RID: 35196
		private LuaFunction m_OnCrystalAddButtonClick_hotfix;

		// Token: 0x0400897D RID: 35197
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400897E RID: 35198
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400897F RID: 35199
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04008980 RID: 35200
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04008981 RID: 35201
		private LuaFunction m_add_EventOnGoldAddAction_hotfix;

		// Token: 0x04008982 RID: 35202
		private LuaFunction m_remove_EventOnGoldAddAction_hotfix;

		// Token: 0x04008983 RID: 35203
		private LuaFunction m_add_EventOnAddCrystalAction_hotfix;

		// Token: 0x04008984 RID: 35204
		private LuaFunction m_remove_EventOnAddCrystalAction_hotfix;

		// Token: 0x04008985 RID: 35205
		private LuaFunction m_add_EventOnHeroFetterConfessAction;

		// Token: 0x04008986 RID: 35206
		private LuaFunction m_remove_EventOnHeroFetterConfessAction;

		// Token: 0x04008987 RID: 35207
		private LuaFunction m_add_EventOnEvolutionButtonClickAction;

		// Token: 0x04008988 RID: 35208
		private LuaFunction m_remove_EventOnEvolutionButtonClickAction;

		// Token: 0x04008989 RID: 35209
		private LuaFunction m_add_EventOnEvolutionMaterialClickAction;

		// Token: 0x0400898A RID: 35210
		private LuaFunction m_remove_EventOnEvolutionMaterialClickAction;

		// Token: 0x0400898B RID: 35211
		private LuaFunction m_add_EventOnSkillUnlockButtonClickAction;

		// Token: 0x0400898C RID: 35212
		private LuaFunction m_remove_EventOnSkillUnlockButtonClickAction;

		// Token: 0x02000C68 RID: 3176
		public new class LuaExportHelper
		{
			// Token: 0x0600E2AB RID: 58027 RVA: 0x003D1A30 File Offset: 0x003CFC30
			public LuaExportHelper(FettersConfessionUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E2AC RID: 58028 RVA: 0x003D1A40 File Offset: 0x003CFC40
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E2AD RID: 58029 RVA: 0x003D1A50 File Offset: 0x003CFC50
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E2AE RID: 58030 RVA: 0x003D1A60 File Offset: 0x003CFC60
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E2AF RID: 58031 RVA: 0x003D1A70 File Offset: 0x003CFC70
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E2B0 RID: 58032 RVA: 0x003D1A88 File Offset: 0x003CFC88
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E2B1 RID: 58033 RVA: 0x003D1A98 File Offset: 0x003CFC98
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E2B2 RID: 58034 RVA: 0x003D1AA8 File Offset: 0x003CFCA8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E2B3 RID: 58035 RVA: 0x003D1AB8 File Offset: 0x003CFCB8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E2B4 RID: 58036 RVA: 0x003D1AC8 File Offset: 0x003CFCC8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E2B5 RID: 58037 RVA: 0x003D1AD8 File Offset: 0x003CFCD8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E2B6 RID: 58038 RVA: 0x003D1AE8 File Offset: 0x003CFCE8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E2B7 RID: 58039 RVA: 0x003D1AF8 File Offset: 0x003CFCF8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E2B8 RID: 58040 RVA: 0x003D1B08 File Offset: 0x003CFD08
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E2B9 RID: 58041 RVA: 0x003D1B18 File Offset: 0x003CFD18
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E2BA RID: 58042 RVA: 0x003D1B28 File Offset: 0x003CFD28
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E2BB RID: 58043 RVA: 0x003D1B38 File Offset: 0x003CFD38
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600E2BC RID: 58044 RVA: 0x003D1B48 File Offset: 0x003CFD48
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600E2BD RID: 58045 RVA: 0x003D1B58 File Offset: 0x003CFD58
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600E2BE RID: 58046 RVA: 0x003D1B68 File Offset: 0x003CFD68
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600E2BF RID: 58047 RVA: 0x003D1B78 File Offset: 0x003CFD78
			public void __callDele_EventOnGoldAdd()
			{
				this.m_owner.__callDele_EventOnGoldAdd();
			}

			// Token: 0x0600E2C0 RID: 58048 RVA: 0x003D1B88 File Offset: 0x003CFD88
			public void __clearDele_EventOnGoldAdd()
			{
				this.m_owner.__clearDele_EventOnGoldAdd();
			}

			// Token: 0x0600E2C1 RID: 58049 RVA: 0x003D1B98 File Offset: 0x003CFD98
			public void __callDele_EventOnAddCrystal()
			{
				this.m_owner.__callDele_EventOnAddCrystal();
			}

			// Token: 0x0600E2C2 RID: 58050 RVA: 0x003D1BA8 File Offset: 0x003CFDA8
			public void __clearDele_EventOnAddCrystal()
			{
				this.m_owner.__clearDele_EventOnAddCrystal();
			}

			// Token: 0x0600E2C3 RID: 58051 RVA: 0x003D1BB8 File Offset: 0x003CFDB8
			public void __callDele_EventOnHeroFetterConfess(int obj)
			{
				this.m_owner.__callDele_EventOnHeroFetterConfess(obj);
			}

			// Token: 0x0600E2C4 RID: 58052 RVA: 0x003D1BC8 File Offset: 0x003CFDC8
			public void __clearDele_EventOnHeroFetterConfess(int obj)
			{
				this.m_owner.__clearDele_EventOnHeroFetterConfess(obj);
			}

			// Token: 0x0600E2C5 RID: 58053 RVA: 0x003D1BD8 File Offset: 0x003CFDD8
			public void __callDele_EventOnEvolutionButtonClick(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnEvolutionButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E2C6 RID: 58054 RVA: 0x003D1BE8 File Offset: 0x003CFDE8
			public void __clearDele_EventOnEvolutionButtonClick(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnEvolutionButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E2C7 RID: 58055 RVA: 0x003D1BF8 File Offset: 0x003CFDF8
			public void __callDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnEvolutionMaterialClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E2C8 RID: 58056 RVA: 0x003D1C08 File Offset: 0x003CFE08
			public void __clearDele_EventOnEvolutionMaterialClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnEvolutionMaterialClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E2C9 RID: 58057 RVA: 0x003D1C18 File Offset: 0x003CFE18
			public void __callDele_EventOnSkillUnlockButtonClick(int arg1, int arg2, Action<List<Goods>> arg3)
			{
				this.m_owner.__callDele_EventOnSkillUnlockButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E2CA RID: 58058 RVA: 0x003D1C28 File Offset: 0x003CFE28
			public void __clearDele_EventOnSkillUnlockButtonClick(int arg1, int arg2, Action<List<Goods>> arg3)
			{
				this.m_owner.__clearDele_EventOnSkillUnlockButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x17002BE9 RID: 11241
			// (get) Token: 0x0600E2CB RID: 58059 RVA: 0x003D1C38 File Offset: 0x003CFE38
			// (set) Token: 0x0600E2CC RID: 58060 RVA: 0x003D1C48 File Offset: 0x003CFE48
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

			// Token: 0x17002BEA RID: 11242
			// (get) Token: 0x0600E2CD RID: 58061 RVA: 0x003D1C58 File Offset: 0x003CFE58
			// (set) Token: 0x0600E2CE RID: 58062 RVA: 0x003D1C68 File Offset: 0x003CFE68
			public CommonUIStateController m_commonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_commonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_commonUIStateCtrl = value;
				}
			}

			// Token: 0x17002BEB RID: 11243
			// (get) Token: 0x0600E2CF RID: 58063 RVA: 0x003D1C78 File Offset: 0x003CFE78
			// (set) Token: 0x0600E2D0 RID: 58064 RVA: 0x003D1C88 File Offset: 0x003CFE88
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

			// Token: 0x17002BEC RID: 11244
			// (get) Token: 0x0600E2D1 RID: 58065 RVA: 0x003D1C98 File Offset: 0x003CFE98
			// (set) Token: 0x0600E2D2 RID: 58066 RVA: 0x003D1CA8 File Offset: 0x003CFEA8
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

			// Token: 0x17002BED RID: 11245
			// (get) Token: 0x0600E2D3 RID: 58067 RVA: 0x003D1CB8 File Offset: 0x003CFEB8
			// (set) Token: 0x0600E2D4 RID: 58068 RVA: 0x003D1CC8 File Offset: 0x003CFEC8
			public GameObject m_skillGroupContent
			{
				get
				{
					return this.m_owner.m_skillGroupContent;
				}
				set
				{
					this.m_owner.m_skillGroupContent = value;
				}
			}

			// Token: 0x17002BEE RID: 11246
			// (get) Token: 0x0600E2D5 RID: 58069 RVA: 0x003D1CD8 File Offset: 0x003CFED8
			// (set) Token: 0x0600E2D6 RID: 58070 RVA: 0x003D1CE8 File Offset: 0x003CFEE8
			public CommonUIStateController m_centerSkillStateCtrl
			{
				get
				{
					return this.m_owner.m_centerSkillStateCtrl;
				}
				set
				{
					this.m_owner.m_centerSkillStateCtrl = value;
				}
			}

			// Token: 0x17002BEF RID: 11247
			// (get) Token: 0x0600E2D7 RID: 58071 RVA: 0x003D1CF8 File Offset: 0x003CFEF8
			// (set) Token: 0x0600E2D8 RID: 58072 RVA: 0x003D1D08 File Offset: 0x003CFF08
			public ToggleEx m_confessionToggle
			{
				get
				{
					return this.m_owner.m_confessionToggle;
				}
				set
				{
					this.m_owner.m_confessionToggle = value;
				}
			}

			// Token: 0x17002BF0 RID: 11248
			// (get) Token: 0x0600E2D9 RID: 58073 RVA: 0x003D1D18 File Offset: 0x003CFF18
			// (set) Token: 0x0600E2DA RID: 58074 RVA: 0x003D1D28 File Offset: 0x003CFF28
			public CommonUIStateController m_skillDetailStateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailStateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailStateCtrl = value;
				}
			}

			// Token: 0x17002BF1 RID: 11249
			// (get) Token: 0x0600E2DB RID: 58075 RVA: 0x003D1D38 File Offset: 0x003CFF38
			// (set) Token: 0x0600E2DC RID: 58076 RVA: 0x003D1D48 File Offset: 0x003CFF48
			public Image m_skillDetailInfoIconImage
			{
				get
				{
					return this.m_owner.m_skillDetailInfoIconImage;
				}
				set
				{
					this.m_owner.m_skillDetailInfoIconImage = value;
				}
			}

			// Token: 0x17002BF2 RID: 11250
			// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x003D1D58 File Offset: 0x003CFF58
			// (set) Token: 0x0600E2DE RID: 58078 RVA: 0x003D1D68 File Offset: 0x003CFF68
			public GameObject m_skillDetailInfoLockIconGo
			{
				get
				{
					return this.m_owner.m_skillDetailInfoLockIconGo;
				}
				set
				{
					this.m_owner.m_skillDetailInfoLockIconGo = value;
				}
			}

			// Token: 0x17002BF3 RID: 11251
			// (get) Token: 0x0600E2DF RID: 58079 RVA: 0x003D1D78 File Offset: 0x003CFF78
			// (set) Token: 0x0600E2E0 RID: 58080 RVA: 0x003D1D88 File Offset: 0x003CFF88
			public Text m_skillDetailInfoSkillNameText
			{
				get
				{
					return this.m_owner.m_skillDetailInfoSkillNameText;
				}
				set
				{
					this.m_owner.m_skillDetailInfoSkillNameText = value;
				}
			}

			// Token: 0x17002BF4 RID: 11252
			// (get) Token: 0x0600E2E1 RID: 58081 RVA: 0x003D1D98 File Offset: 0x003CFF98
			// (set) Token: 0x0600E2E2 RID: 58082 RVA: 0x003D1DA8 File Offset: 0x003CFFA8
			public Text m_skillDetailInfoSkillLvText
			{
				get
				{
					return this.m_owner.m_skillDetailInfoSkillLvText;
				}
				set
				{
					this.m_owner.m_skillDetailInfoSkillLvText = value;
				}
			}

			// Token: 0x17002BF5 RID: 11253
			// (get) Token: 0x0600E2E3 RID: 58083 RVA: 0x003D1DB8 File Offset: 0x003CFFB8
			// (set) Token: 0x0600E2E4 RID: 58084 RVA: 0x003D1DC8 File Offset: 0x003CFFC8
			public GameObject m_skillDetailInfoSkillLvMaxText
			{
				get
				{
					return this.m_owner.m_skillDetailInfoSkillLvMaxText;
				}
				set
				{
					this.m_owner.m_skillDetailInfoSkillLvMaxText = value;
				}
			}

			// Token: 0x17002BF6 RID: 11254
			// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x003D1DD8 File Offset: 0x003CFFD8
			// (set) Token: 0x0600E2E6 RID: 58086 RVA: 0x003D1DE8 File Offset: 0x003CFFE8
			public Text m_skillDetailDescText
			{
				get
				{
					return this.m_owner.m_skillDetailDescText;
				}
				set
				{
					this.m_owner.m_skillDetailDescText = value;
				}
			}

			// Token: 0x17002BF7 RID: 11255
			// (get) Token: 0x0600E2E7 RID: 58087 RVA: 0x003D1DF8 File Offset: 0x003CFFF8
			// (set) Token: 0x0600E2E8 RID: 58088 RVA: 0x003D1E08 File Offset: 0x003D0008
			public CommonUIStateController m_skillDetailCondition1StateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailCondition1StateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailCondition1StateCtrl = value;
				}
			}

			// Token: 0x17002BF8 RID: 11256
			// (get) Token: 0x0600E2E9 RID: 58089 RVA: 0x003D1E18 File Offset: 0x003D0018
			// (set) Token: 0x0600E2EA RID: 58090 RVA: 0x003D1E28 File Offset: 0x003D0028
			public Text m_skillDetailConditionUnlockInfoText1
			{
				get
				{
					return this.m_owner.m_skillDetailConditionUnlockInfoText1;
				}
				set
				{
					this.m_owner.m_skillDetailConditionUnlockInfoText1 = value;
				}
			}

			// Token: 0x17002BF9 RID: 11257
			// (get) Token: 0x0600E2EB RID: 58091 RVA: 0x003D1E38 File Offset: 0x003D0038
			// (set) Token: 0x0600E2EC RID: 58092 RVA: 0x003D1E48 File Offset: 0x003D0048
			public CommonUIStateController m_skillDetailCondition2StateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailCondition2StateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailCondition2StateCtrl = value;
				}
			}

			// Token: 0x17002BFA RID: 11258
			// (get) Token: 0x0600E2ED RID: 58093 RVA: 0x003D1E58 File Offset: 0x003D0058
			// (set) Token: 0x0600E2EE RID: 58094 RVA: 0x003D1E68 File Offset: 0x003D0068
			public Text m_skillDetailConditionUnlockInfoText2
			{
				get
				{
					return this.m_owner.m_skillDetailConditionUnlockInfoText2;
				}
				set
				{
					this.m_owner.m_skillDetailConditionUnlockInfoText2 = value;
				}
			}

			// Token: 0x17002BFB RID: 11259
			// (get) Token: 0x0600E2EF RID: 58095 RVA: 0x003D1E78 File Offset: 0x003D0078
			// (set) Token: 0x0600E2F0 RID: 58096 RVA: 0x003D1E88 File Offset: 0x003D0088
			public GameObject m_skillDetailUnlockRewardGoods
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockRewardGoods;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockRewardGoods = value;
				}
			}

			// Token: 0x17002BFC RID: 11260
			// (get) Token: 0x0600E2F1 RID: 58097 RVA: 0x003D1E98 File Offset: 0x003D0098
			// (set) Token: 0x0600E2F2 RID: 58098 RVA: 0x003D1EA8 File Offset: 0x003D00A8
			public Button m_skillDetailUnlockButton
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockButton;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockButton = value;
				}
			}

			// Token: 0x17002BFD RID: 11261
			// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x003D1EB8 File Offset: 0x003D00B8
			// (set) Token: 0x0600E2F4 RID: 58100 RVA: 0x003D1EC8 File Offset: 0x003D00C8
			public CommonUIStateController m_skillDetailUnlockButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockButtonStateCtrl = value;
				}
			}

			// Token: 0x17002BFE RID: 11262
			// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x003D1ED8 File Offset: 0x003D00D8
			// (set) Token: 0x0600E2F6 RID: 58102 RVA: 0x003D1EE8 File Offset: 0x003D00E8
			public Button m_skillDetailUnlockGreyButton
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockGreyButton;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockGreyButton = value;
				}
			}

			// Token: 0x17002BFF RID: 11263
			// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x003D1EF8 File Offset: 0x003D00F8
			// (set) Token: 0x0600E2F8 RID: 58104 RVA: 0x003D1F08 File Offset: 0x003D0108
			public Text m_skillDetailUnlockRewardNameText
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockRewardNameText;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockRewardNameText = value;
				}
			}

			// Token: 0x17002C00 RID: 11264
			// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x003D1F18 File Offset: 0x003D0118
			// (set) Token: 0x0600E2FA RID: 58106 RVA: 0x003D1F28 File Offset: 0x003D0128
			public CommonUIStateController m_skillDetailUnlockStateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateCtrl = value;
				}
			}

			// Token: 0x17002C01 RID: 11265
			// (get) Token: 0x0600E2FB RID: 58107 RVA: 0x003D1F38 File Offset: 0x003D0138
			// (set) Token: 0x0600E2FC RID: 58108 RVA: 0x003D1F48 File Offset: 0x003D0148
			public Text m_skillDetailUnlockStateNowInfoText
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateNowInfoText;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateNowInfoText = value;
				}
			}

			// Token: 0x17002C02 RID: 11266
			// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x003D1F58 File Offset: 0x003D0158
			// (set) Token: 0x0600E2FE RID: 58110 RVA: 0x003D1F68 File Offset: 0x003D0168
			public Text m_skillDetailUnlockStateAfterText
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateAfterText;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateAfterText = value;
				}
			}

			// Token: 0x17002C03 RID: 11267
			// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x003D1F78 File Offset: 0x003D0178
			// (set) Token: 0x0600E300 RID: 58112 RVA: 0x003D1F88 File Offset: 0x003D0188
			public CommonUIStateController m_skillDetailUnlockStateConsumeTextStateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateConsumeTextStateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateConsumeTextStateCtrl = value;
				}
			}

			// Token: 0x17002C04 RID: 11268
			// (get) Token: 0x0600E301 RID: 58113 RVA: 0x003D1F98 File Offset: 0x003D0198
			// (set) Token: 0x0600E302 RID: 58114 RVA: 0x003D1FA8 File Offset: 0x003D01A8
			public Text m_skillDetailUnlockStateConsumeValueText
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateConsumeValueText;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateConsumeValueText = value;
				}
			}

			// Token: 0x17002C05 RID: 11269
			// (get) Token: 0x0600E303 RID: 58115 RVA: 0x003D1FB8 File Offset: 0x003D01B8
			// (set) Token: 0x0600E304 RID: 58116 RVA: 0x003D1FC8 File Offset: 0x003D01C8
			public GameObject m_skillDetailUnlockEvolutionMaterial1
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockEvolutionMaterial1;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockEvolutionMaterial1 = value;
				}
			}

			// Token: 0x17002C06 RID: 11270
			// (get) Token: 0x0600E305 RID: 58117 RVA: 0x003D1FD8 File Offset: 0x003D01D8
			// (set) Token: 0x0600E306 RID: 58118 RVA: 0x003D1FE8 File Offset: 0x003D01E8
			public GameObject m_skillDetailUnlockEvolutionMaterial2
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockEvolutionMaterial2;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockEvolutionMaterial2 = value;
				}
			}

			// Token: 0x17002C07 RID: 11271
			// (get) Token: 0x0600E307 RID: 58119 RVA: 0x003D1FF8 File Offset: 0x003D01F8
			// (set) Token: 0x0600E308 RID: 58120 RVA: 0x003D2008 File Offset: 0x003D0208
			public CommonUIStateController m_skillDetailUnlockEvolutionMaterialStateCtrl1
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockEvolutionMaterialStateCtrl1;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockEvolutionMaterialStateCtrl1 = value;
				}
			}

			// Token: 0x17002C08 RID: 11272
			// (get) Token: 0x0600E309 RID: 58121 RVA: 0x003D2018 File Offset: 0x003D0218
			// (set) Token: 0x0600E30A RID: 58122 RVA: 0x003D2028 File Offset: 0x003D0228
			public CommonUIStateController m_skillDetailUnlockEvolutionMaterialStateCtrl2
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockEvolutionMaterialStateCtrl2;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockEvolutionMaterialStateCtrl2 = value;
				}
			}

			// Token: 0x17002C09 RID: 11273
			// (get) Token: 0x0600E30B RID: 58123 RVA: 0x003D2038 File Offset: 0x003D0238
			// (set) Token: 0x0600E30C RID: 58124 RVA: 0x003D2048 File Offset: 0x003D0248
			public Button m_skillDetailUnlockStateEvolutionButton
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateEvolutionButton;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateEvolutionButton = value;
				}
			}

			// Token: 0x17002C0A RID: 11274
			// (get) Token: 0x0600E30D RID: 58125 RVA: 0x003D2058 File Offset: 0x003D0258
			// (set) Token: 0x0600E30E RID: 58126 RVA: 0x003D2068 File Offset: 0x003D0268
			public CommonUIStateController m_skillDetailEnhanceSuccessEffectPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailEnhanceSuccessEffectPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailEnhanceSuccessEffectPanelStateCtrl = value;
				}
			}

			// Token: 0x17002C0B RID: 11275
			// (get) Token: 0x0600E30F RID: 58127 RVA: 0x003D2078 File Offset: 0x003D0278
			// (set) Token: 0x0600E310 RID: 58128 RVA: 0x003D2088 File Offset: 0x003D0288
			public CommonUIStateController m_skillDetailConfessionAndRewardStateCtrl
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardStateCtrl;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardStateCtrl = value;
				}
			}

			// Token: 0x17002C0C RID: 11276
			// (get) Token: 0x0600E311 RID: 58129 RVA: 0x003D2098 File Offset: 0x003D0298
			// (set) Token: 0x0600E312 RID: 58130 RVA: 0x003D20A8 File Offset: 0x003D02A8
			public GameObject m_skillDetailConfessionAndRewardScrollViewContent
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardScrollViewContent;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardScrollViewContent = value;
				}
			}

			// Token: 0x17002C0D RID: 11277
			// (get) Token: 0x0600E313 RID: 58131 RVA: 0x003D20B8 File Offset: 0x003D02B8
			// (set) Token: 0x0600E314 RID: 58132 RVA: 0x003D20C8 File Offset: 0x003D02C8
			public Button m_skillDetailConfessionAndRewardFemaleButton
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardFemaleButton;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardFemaleButton = value;
				}
			}

			// Token: 0x17002C0E RID: 11278
			// (get) Token: 0x0600E315 RID: 58133 RVA: 0x003D20D8 File Offset: 0x003D02D8
			// (set) Token: 0x0600E316 RID: 58134 RVA: 0x003D20E8 File Offset: 0x003D02E8
			public GameObject m_skillDetailConfessionAndRewardFemaleRewardGoods
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardFemaleRewardGoods;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardFemaleRewardGoods = value;
				}
			}

			// Token: 0x17002C0F RID: 11279
			// (get) Token: 0x0600E317 RID: 58135 RVA: 0x003D20F8 File Offset: 0x003D02F8
			// (set) Token: 0x0600E318 RID: 58136 RVA: 0x003D2108 File Offset: 0x003D0308
			public Text m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText = value;
				}
			}

			// Token: 0x17002C10 RID: 11280
			// (get) Token: 0x0600E319 RID: 58137 RVA: 0x003D2118 File Offset: 0x003D0318
			// (set) Token: 0x0600E31A RID: 58138 RVA: 0x003D2128 File Offset: 0x003D0328
			public Button m_skillDetailConfessionAndRewardMaleButton
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardMaleButton;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardMaleButton = value;
				}
			}

			// Token: 0x17002C11 RID: 11281
			// (get) Token: 0x0600E31B RID: 58139 RVA: 0x003D2138 File Offset: 0x003D0338
			// (set) Token: 0x0600E31C RID: 58140 RVA: 0x003D2148 File Offset: 0x003D0348
			public GameObject m_skillDetailConfessionAndRewardMaleRewardGoods
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardMaleRewardGoods;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardMaleRewardGoods = value;
				}
			}

			// Token: 0x17002C12 RID: 11282
			// (get) Token: 0x0600E31D RID: 58141 RVA: 0x003D2158 File Offset: 0x003D0358
			// (set) Token: 0x0600E31E RID: 58142 RVA: 0x003D2168 File Offset: 0x003D0368
			public Text m_skillDetailConfessionAndRewardMaleRewardGoodsNameText
			{
				get
				{
					return this.m_owner.m_skillDetailConfessionAndRewardMaleRewardGoodsNameText;
				}
				set
				{
					this.m_owner.m_skillDetailConfessionAndRewardMaleRewardGoodsNameText = value;
				}
			}

			// Token: 0x17002C13 RID: 11283
			// (get) Token: 0x0600E31F RID: 58143 RVA: 0x003D2178 File Offset: 0x003D0378
			// (set) Token: 0x0600E320 RID: 58144 RVA: 0x003D2188 File Offset: 0x003D0388
			public GameObject m_skillDetailUnlockStateConditionPrefab
			{
				get
				{
					return this.m_owner.m_skillDetailUnlockStateConditionPrefab;
				}
				set
				{
					this.m_owner.m_skillDetailUnlockStateConditionPrefab = value;
				}
			}

			// Token: 0x17002C14 RID: 11284
			// (get) Token: 0x0600E321 RID: 58145 RVA: 0x003D2198 File Offset: 0x003D0398
			// (set) Token: 0x0600E322 RID: 58146 RVA: 0x003D21A8 File Offset: 0x003D03A8
			public Text m_playerResourceCrystalText
			{
				get
				{
					return this.m_owner.m_playerResourceCrystalText;
				}
				set
				{
					this.m_owner.m_playerResourceCrystalText = value;
				}
			}

			// Token: 0x17002C15 RID: 11285
			// (get) Token: 0x0600E323 RID: 58147 RVA: 0x003D21B8 File Offset: 0x003D03B8
			// (set) Token: 0x0600E324 RID: 58148 RVA: 0x003D21C8 File Offset: 0x003D03C8
			public Button m_playerResourceCrystalAddButton
			{
				get
				{
					return this.m_owner.m_playerResourceCrystalAddButton;
				}
				set
				{
					this.m_owner.m_playerResourceCrystalAddButton = value;
				}
			}

			// Token: 0x17002C16 RID: 11286
			// (get) Token: 0x0600E325 RID: 58149 RVA: 0x003D21D8 File Offset: 0x003D03D8
			// (set) Token: 0x0600E326 RID: 58150 RVA: 0x003D21E8 File Offset: 0x003D03E8
			public Text m_playerResourceGoldenText
			{
				get
				{
					return this.m_owner.m_playerResourceGoldenText;
				}
				set
				{
					this.m_owner.m_playerResourceGoldenText = value;
				}
			}

			// Token: 0x17002C17 RID: 11287
			// (get) Token: 0x0600E327 RID: 58151 RVA: 0x003D21F8 File Offset: 0x003D03F8
			// (set) Token: 0x0600E328 RID: 58152 RVA: 0x003D2208 File Offset: 0x003D0408
			public Button m_playerResourceGoldenAddButton
			{
				get
				{
					return this.m_owner.m_playerResourceGoldenAddButton;
				}
				set
				{
					this.m_owner.m_playerResourceGoldenAddButton = value;
				}
			}

			// Token: 0x17002C18 RID: 11288
			// (get) Token: 0x0600E329 RID: 58153 RVA: 0x003D2218 File Offset: 0x003D0418
			// (set) Token: 0x0600E32A RID: 58154 RVA: 0x003D2228 File Offset: 0x003D0428
			public Button m_fastLevelButton
			{
				get
				{
					return this.m_owner.m_fastLevelButton;
				}
				set
				{
					this.m_owner.m_fastLevelButton = value;
				}
			}

			// Token: 0x17002C19 RID: 11289
			// (get) Token: 0x0600E32B RID: 58155 RVA: 0x003D2238 File Offset: 0x003D0438
			// (set) Token: 0x0600E32C RID: 58156 RVA: 0x003D2248 File Offset: 0x003D0448
			public InputField m_fastLevelButtonInputField
			{
				get
				{
					return this.m_owner.m_fastLevelButtonInputField;
				}
				set
				{
					this.m_owner.m_fastLevelButtonInputField = value;
				}
			}

			// Token: 0x17002C1A RID: 11290
			// (get) Token: 0x0600E32D RID: 58157 RVA: 0x003D2258 File Offset: 0x003D0458
			// (set) Token: 0x0600E32E RID: 58158 RVA: 0x003D2268 File Offset: 0x003D0468
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

			// Token: 0x17002C1B RID: 11291
			// (get) Token: 0x0600E32F RID: 58159 RVA: 0x003D2278 File Offset: 0x003D0478
			// (set) Token: 0x0600E330 RID: 58160 RVA: 0x003D2288 File Offset: 0x003D0488
			public bool isFirstIn
			{
				get
				{
					return this.m_owner.isFirstIn;
				}
				set
				{
					this.m_owner.isFirstIn = value;
				}
			}

			// Token: 0x17002C1C RID: 11292
			// (get) Token: 0x0600E331 RID: 58161 RVA: 0x003D2298 File Offset: 0x003D0498
			// (set) Token: 0x0600E332 RID: 58162 RVA: 0x003D22A8 File Offset: 0x003D04A8
			public bool m_isMale
			{
				get
				{
					return this.m_owner.m_isMale;
				}
				set
				{
					this.m_owner.m_isMale = value;
				}
			}

			// Token: 0x17002C1D RID: 11293
			// (get) Token: 0x0600E333 RID: 58163 RVA: 0x003D22B8 File Offset: 0x003D04B8
			// (set) Token: 0x0600E334 RID: 58164 RVA: 0x003D22C8 File Offset: 0x003D04C8
			public FettersConfessionSkillItemUIController m_curFetterSkillCtrl
			{
				get
				{
					return this.m_owner.m_curFetterSkillCtrl;
				}
				set
				{
					this.m_owner.m_curFetterSkillCtrl = value;
				}
			}

			// Token: 0x17002C1E RID: 11294
			// (get) Token: 0x0600E335 RID: 58165 RVA: 0x003D22D8 File Offset: 0x003D04D8
			// (set) Token: 0x0600E336 RID: 58166 RVA: 0x003D22E8 File Offset: 0x003D04E8
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

			// Token: 0x17002C1F RID: 11295
			// (get) Token: 0x0600E337 RID: 58167 RVA: 0x003D22F8 File Offset: 0x003D04F8
			// (set) Token: 0x0600E338 RID: 58168 RVA: 0x003D2308 File Offset: 0x003D0508
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

			// Token: 0x0600E339 RID: 58169 RVA: 0x003D2318 File Offset: 0x003D0518
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E33A RID: 58170 RVA: 0x003D2328 File Offset: 0x003D0528
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600E33B RID: 58171 RVA: 0x003D2338 File Offset: 0x003D0538
			public void SetSkillDetailPanel(ConfigDataHeroFetterInfo heroFetterInfo)
			{
				this.m_owner.SetSkillDetailPanel(heroFetterInfo);
			}

			// Token: 0x0600E33C RID: 58172 RVA: 0x003D2348 File Offset: 0x003D0548
			public void SetSkillInfoGroup(ConfigDataHeroFetterInfo heroFetterInfo)
			{
				this.m_owner.SetSkillInfoGroup(heroFetterInfo);
			}

			// Token: 0x0600E33D RID: 58173 RVA: 0x003D2358 File Offset: 0x003D0558
			public void SetLockStateInfo(ConfigDataHeroFetterInfo heroFetterInfo)
			{
				this.m_owner.SetLockStateInfo(heroFetterInfo);
			}

			// Token: 0x0600E33E RID: 58174 RVA: 0x003D2368 File Offset: 0x003D0568
			public string GetFettersCoditionDesc(HeroFetterCompletionCondition condition)
			{
				return this.m_owner.GetFettersCoditionDesc(condition);
			}

			// Token: 0x0600E33F RID: 58175 RVA: 0x003D2378 File Offset: 0x003D0578
			public void SetUnlockStateInfo(ConfigDataHeroFetterInfo heroFetterInfo)
			{
				this.m_owner.SetUnlockStateInfo(heroFetterInfo);
			}

			// Token: 0x0600E340 RID: 58176 RVA: 0x003D2388 File Offset: 0x003D0588
			public void SetConfessionAndRewardInfo()
			{
				this.m_owner.SetConfessionAndRewardInfo();
			}

			// Token: 0x0600E341 RID: 58177 RVA: 0x003D2398 File Offset: 0x003D0598
			public void OnFettersSkillItemClick(FettersConfessionSkillItemUIController ctrl)
			{
				this.m_owner.OnFettersSkillItemClick(ctrl);
			}

			// Token: 0x0600E342 RID: 58178 RVA: 0x003D23A8 File Offset: 0x003D05A8
			public void OnConfessionToggleValueChanged(bool isOn)
			{
				this.m_owner.OnConfessionToggleValueChanged(isOn);
			}

			// Token: 0x0600E343 RID: 58179 RVA: 0x003D23B8 File Offset: 0x003D05B8
			public void OnEvolutionMaterialClick(GoodsType goodsType, int id, int needCount)
			{
				this.m_owner.OnEvolutionMaterialClick(goodsType, id, needCount);
			}

			// Token: 0x0600E344 RID: 58180 RVA: 0x003D23C8 File Offset: 0x003D05C8
			public void OnSkillUnlockButtonClick()
			{
				this.m_owner.OnSkillUnlockButtonClick();
			}

			// Token: 0x0600E345 RID: 58181 RVA: 0x003D23D8 File Offset: 0x003D05D8
			public void OnSkillDetailUnlockGreyButtonClick()
			{
				this.m_owner.OnSkillDetailUnlockGreyButtonClick();
			}

			// Token: 0x0600E346 RID: 58182 RVA: 0x003D23E8 File Offset: 0x003D05E8
			public void OnUnlockStateEvolutionButtonClcik()
			{
				this.m_owner.OnUnlockStateEvolutionButtonClcik();
			}

			// Token: 0x0600E347 RID: 58183 RVA: 0x003D23F8 File Offset: 0x003D05F8
			public void OnConfessionAndRewardButtonClick()
			{
				this.m_owner.OnConfessionAndRewardButtonClick();
			}

			// Token: 0x0600E348 RID: 58184 RVA: 0x003D2408 File Offset: 0x003D0608
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600E349 RID: 58185 RVA: 0x003D2418 File Offset: 0x003D0618
			public void OnFastLevelButtonClick()
			{
				this.m_owner.OnFastLevelButtonClick();
			}

			// Token: 0x0600E34A RID: 58186 RVA: 0x003D2428 File Offset: 0x003D0628
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600E34B RID: 58187 RVA: 0x003D2438 File Offset: 0x003D0638
			public void OnGoldAddButtonClick()
			{
				this.m_owner.OnGoldAddButtonClick();
			}

			// Token: 0x0600E34C RID: 58188 RVA: 0x003D2448 File Offset: 0x003D0648
			public void OnCrystalAddButtonClick()
			{
				this.m_owner.OnCrystalAddButtonClick();
			}

			// Token: 0x0400898D RID: 35213
			private FettersConfessionUIController m_owner;
		}
	}
}
