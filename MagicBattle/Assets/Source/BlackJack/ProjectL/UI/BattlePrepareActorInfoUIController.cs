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
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A93 RID: 2707
	[HotFix]
	public class BattlePrepareActorInfoUIController : UIControllerBase
	{
		// Token: 0x0600AB1F RID: 43807 RVA: 0x002F9BF8 File Offset: 0x002F7DF8
		private BattlePrepareActorInfoUIController()
		{
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x002F9C0C File Offset: 0x002F7E0C
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
			this.m_skillChangeButton.onClick.AddListener(new UnityAction(this.OnChangeSkillButtonClick));
			this.m_selectSkillConfirmButton.onClick.AddListener(new UnityAction(this.OnConfirmSelectSkillsButtonClick));
			this.m_soldierChangeButton.onClick.AddListener(new UnityAction(this.OnChangeSoldierButtonClick));
			this.m_closeSelectSkillButton.onClick.AddListener(new UnityAction(this.CloseSelectSkillPanel));
			this.m_closeSelectSoldierButton.onClick.AddListener(new UnityAction(this.CloseSelectSoldierPanel));
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_heroSkillInfoButton.onClick.AddListener(delegate()
			{
				this.m_skillDetailObj.SetActive(true);
			});
			PointDescComponent pointDescComponent = this.m_skillDetailObj.gameObject.AddComponent<PointDescComponent>();
			pointDescComponent.SetGameObject(this.m_skillDetailListObj, false, this.m_skillDetailObj, null);
			pointDescComponent.EventOnClose += delegate()
			{
				this.m_skillDetailObj.SetActive(false);
			};
			this.m_soldierInfoBtn.onClick.AddListener(delegate()
			{
				UIUtility.SetUIStateOpen(this.m_soldierDetailPanelUIStateController, "Show", null, false, true);
			});
			PointDescComponent pointDescComponent2 = this.m_soldierDetailPanelUIStateController.gameObject.AddComponent<PointDescComponent>();
			pointDescComponent2.SetGameObject(this.m_soldierDetailPanelUIStateController.gameObject, false, null, null);
			pointDescComponent2.EventOnClose += delegate()
			{
				UIUtility.SetUIStateClose(this.m_soldierDetailPanelUIStateController, "Close", null, false, true);
			};
			this.m_skillDescPool = new GameObjectPool<SkillDesc>();
			this.m_skillDescPool.Setup(this.m_skillDescPrefabObj, this.m_skillListContentListObj);
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x002F9DF0 File Offset: 0x002F7FF0
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
			if (this.m_soldierGraphic != null)
			{
				this.DestroySpineGraphic(this.m_soldierGraphic);
				this.m_soldierGraphic = null;
			}
			if (this.m_soldierDetailGraphic != null)
			{
				this.DestroySpineGraphic(this.m_soldierDetailGraphic);
				this.m_soldierDetailGraphic = null;
			}
			this.m_isOpened = false;
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x002F9E94 File Offset: 0x002F8094
		public void Open(bool left)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenBoolean_hotfix != null)
			{
				this.m_OpenBoolean_hotfix.call(new object[]
				{
					this,
					left
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (left)
			{
				component.SetToUIState("Left", false, true);
			}
			else
			{
				component.SetToUIState("Right", false, true);
			}
			CommonUIStateController component2 = this.m_heroGameObject.GetComponent<CommonUIStateController>();
			component2.SetToUIState("Show", false, true);
			AudioUtility.PlaySound(SoundTableId.SoundTableId_SelectHero);
			this.m_isOpened = true;
			this.m_soldierDetailPanelUIStateController.gameObject.SetActive(false);
			this.m_skillDetailObj.SetActive(false);
			this.m_soldierGo.SetActive(this.m_hero.SelectedSoldierId != 0);
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x002F9FA0 File Offset: 0x002F81A0
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			CommonUIStateController component = this.m_heroGameObject.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				base.gameObject.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
			this.m_soldierGo.SetActive(this.m_hero.SelectedSoldierId != 0);
			this.m_isOpened = false;
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x002FA060 File Offset: 0x002F8260
		public bool IsOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpened;
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x002FA0D4 File Offset: 0x002F82D4
		public void SetActorInfo(BattleHero hero, List<TrainingTech> techs, int team, bool isNpc, bool canChangeSoldier, ConfigDataSkillInfo extraTalentSkillInfo = null, int heroHp = -1, int soldierHp = -1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActorInfoBattleHeroList`1Int32BooleanBooleanConfigDataSkillInfoInt32Int32_hotfix != null)
			{
				this.m_SetActorInfoBattleHeroList`1Int32BooleanBooleanConfigDataSkillInfoInt32Int32_hotfix.call(new object[]
				{
					this,
					hero,
					techs,
					team,
					isNpc,
					canChangeSoldier,
					extraTalentSkillInfo,
					heroHp,
					soldierHp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			this.m_hero = hero;
			this.m_trainingTechs = techs;
			this.m_team = team;
			this.m_isNpc = isNpc;
			this.m_canChangeSoldier = canChangeSoldier;
			this.m_extraTalentSkillInfo = extraTalentSkillInfo;
			this.m_heroHp = heroHp;
			this.m_soldierHp = soldierHp;
			BattleHeroJob activeJob = hero.GetActiveJob();
			ConfigDataJobInfo jobInfo = activeJob.JobConnectionInfo.m_jobInfo;
			ConfigDataArmyInfo armyInfo = jobInfo.m_armyInfo;
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeHeroProperties(hero);
			HeroPropertyComputer heroPropertyComputer2 = new HeroPropertyComputer();
			if (hero.SelectedSoldierInfo != null)
			{
				heroPropertyComputer2.Init(this.m_configDataLoader);
				heroPropertyComputer2.ComputeSoldierCommandProperties(hero, hero.SelectedSoldierInfo, this.m_trainingTechs, hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader));
			}
			this.m_heroNameText.text = hero.HeroInfo.Name;
			this.m_heroLevelText.text = hero.Level.ToString();
			this.m_heroJobText.text = jobInfo.Name;
			this.m_heroArmyIcon.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon);
			if (isNpc)
			{
				this.m_heroPanelGroupCtrl.SetToUIState("NeutralRight", false, true);
			}
			else if (team == 0)
			{
				this.m_heroPanelGroupCtrl.SetToUIState("WeRight", false, true);
			}
			else
			{
				this.m_heroPanelGroupCtrl.SetToUIState("EnemyRight", false, true);
			}
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_heroIcon.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
			}
			int num = (this.m_heroHp < 0) ? heroPropertyComputer.Property0.HealthPointMax : this.m_heroHp;
			this.m_heroHPText.text = num + " / " + heroPropertyComputer.Property0.HealthPointMax;
			if (num > 0 && heroPropertyComputer.Property0.HealthPointMax > 0)
			{
				this.m_heroHPImage.fillAmount = (float)num / (float)heroPropertyComputer.Property0.HealthPointMax;
			}
			else
			{
				this.m_heroHPImage.fillAmount = 0f;
			}
			this.m_heroHPImage.sprite = AssetUtility.Instance.GetSprite((this.m_team != 0) ? "UI/Common_New_ABS/Pattern_Blood_Red01.png" : "UI/Common_New_ABS/Pattern_Blood_Green01.png");
			this.m_heroAttackText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_heroDefenseText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_heroMagicText.text = heroPropertyComputer.Property0.Magic.ToString();
			this.m_heroMagicDefenseText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_heroDEXText.text = heroPropertyComputer.Property0.Dexterity.ToString();
			int num2;
			if (hero.SelectedSoldierInfo == null)
			{
				num2 = heroPropertyComputer.Property0.AttackDistance;
			}
			else
			{
				num2 = Mathf.Max(heroPropertyComputer.Property0.AttackDistance, heroPropertyComputer2.Property0.AttackDistance);
			}
			this.m_heroRangeText.text = num2.ToString();
			int num3;
			if (hero.SelectedSoldierInfo == null)
			{
				num3 = heroPropertyComputer.Property0.MovePoint;
			}
			else
			{
				num3 = Mathf.Min(heroPropertyComputer.Property0.MovePoint, heroPropertyComputer2.Property0.MovePoint);
			}
			this.m_heroMoveText.text = num3.ToString();
			this.SetSkills();
			this.m_soldierGo.SetActive(hero.SelectedSoldierInfo != null);
			if (hero.SelectedSoldierInfo != null)
			{
				this.SetSoldier();
			}
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_skillChangeButton.gameObject.SetActive(team == 0 && !isNpc && this.m_canChangeSoldier && data.IsDeveloper);
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x002FA5D8 File Offset: 0x002F87D8
		public int GetHeroId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero != null)
			{
				return this.m_hero.HeroId;
			}
			return 0;
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x002FA65C File Offset: 0x002F885C
		public int GetTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeam_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTeam_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_team;
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x002FA6D0 File Offset: 0x002F88D0
		public bool CanChangeSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanChangeSoldier_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanChangeSoldier_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_canChangeSoldier;
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x002FA744 File Offset: 0x002F8944
		public void SetSkills()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkills_hotfix != null)
			{
				this.m_SetSkills_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectSkillIds.Clear();
			this.m_selectSkillIds.AddRange(this.m_hero.SelectedSkillList);
			this.m_maxSkillCost = this.m_playerContext.GetHeroSkillPointMax(this.m_hero.Level);
			this.SetSkillsAndTalentList();
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x002FA7E8 File Offset: 0x002F89E8
		private void SetSkillsAndTalentList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillsAndTalentList_hotfix != null)
			{
				this.m_SetSkillsAndTalentList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			foreach (int key in this.m_selectSkillIds)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(key);
				list.Add(configDataSkillInfo);
			}
			this.m_skillDescPool.Deactive();
			foreach (ConfigDataSkillInfo skill in list)
			{
				SkillDesc skillDesc = this.m_skillDescPool.Allocate();
				if (skillDesc != null)
				{
					skillDesc.SetSkill(skill);
				}
			}
			List<GameObject> list2 = new List<GameObject>
			{
				this.m_skillInfoGroupSkillGo,
				this.m_skillInfoGroupSkillGo2,
				this.m_skillInfoGroupSkillGo3
			};
			for (int i = 0; i < list2.Count; i++)
			{
				GameObject gameObject = list2[i];
				CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
				if (i < list.Count)
				{
					component.SetToUIState("Have", false, true);
					GameObject gameObject2 = Utility.FindChildGameObject(gameObject, "IconImage", true);
					gameObject2.GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(list[i].Icon);
				}
				else
				{
					component.SetToUIState("NoHave", false, true);
				}
			}
			ConfigDataSkillInfo configDataSkillInfo2 = this.m_extraTalentSkillInfo;
			if (configDataSkillInfo2 == null)
			{
				configDataSkillInfo2 = this.m_hero.GetActiveJob().JobConnectionInfo.GetTalentSkillInfo(this.m_hero.StarLevel);
			}
			if (configDataSkillInfo2 != null)
			{
				this.m_skillListContentTalentIcon.sprite = AssetUtility.Instance.GetSprite(configDataSkillInfo2.Icon);
				this.m_skillListContentTalentNameText.text = configDataSkillInfo2.Name;
				this.m_skillListContentTalentDescText.text = configDataSkillInfo2.Desc;
				this.m_skillInfoGroupTalentSkillImage.sprite = AssetUtility.Instance.GetSprite(configDataSkillInfo2.Icon);
			}
			this.m_skillListContentTalentObj.SetActive(configDataSkillInfo2 != null);
			this.m_skillInfoGroupTalentSkillImage.gameObject.SetActive(configDataSkillInfo2 != null);
			this.m_skillListContentLineImage.gameObject.SetActive(list.Count != 0 && configDataSkillInfo2 != null);
			this.m_skillListContentObj.SetActive(list.Count != 0 || configDataSkillInfo2 != null);
			this.m_skillListNoSkillsObj.SetActive(list.Count == 0 && configDataSkillInfo2 == null);
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x002FAB00 File Offset: 0x002F8D00
		private void ShowSelectSkillPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectSkillPanel_hotfix != null)
			{
				this.m_ShowSelectSkillPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectSkillPanelGo.SetActive(true);
			Hero hero = this.m_playerContext.GetHero(this.m_hero.HeroId);
			if (hero == null)
			{
				return;
			}
			GameObjectUtility.DestroyChildren(this.m_allSkillsContent);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("skillItem");
			List<int> skillIds = hero.SkillIds;
			List<int> selectedSkillList = this.m_hero.SelectedSkillList;
			this.m_selectSkillIds.Clear();
			this.m_selectSkillIds.AddRange(selectedSkillList);
			foreach (KeyValuePair<int, ConfigDataSkillInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataSkillInfo())
			{
				ConfigDataSkillInfo value = keyValuePair.Value;
				if (skillIds.Contains(value.ID))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					HeroSkillItemUIController component = gameObject.GetComponent<HeroSkillItemUIController>();
					component.EventOnShowDesc += this.OnSkillItemClick;
					component.InitSkillItem(value);
					bool limitTagObjActive = this.m_playerContext.IsSkillLimitToHeroJob(this.m_hero.ActiveHeroJobRelatedId, value.ID);
					component.SetLimitTagObjActive(limitTagObjActive);
					gameObject.transform.SetParent(this.m_allSkillsContent.transform, false);
					if (selectedSkillList.Contains(value.ID))
					{
						component.SetSelectPanelActive(true);
					}
				}
			}
			GameObjectUtility.DestroyChildren(this.m_selectSkillsContent);
			foreach (KeyValuePair<int, ConfigDataSkillInfo> keyValuePair2 in this.m_configDataLoader.GetAllConfigDataSkillInfo())
			{
				ConfigDataSkillInfo value2 = keyValuePair2.Value;
				if (selectedSkillList.Contains(value2.ID))
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject2);
					HeroSkillItemUIController component2 = gameObject2.GetComponent<HeroSkillItemUIController>();
					component2.EventOnShowDesc += this.OnSkillItemClick;
					component2.InitSkillItem(value2);
					gameObject2.transform.SetParent(this.m_selectSkillsContent.transform, false);
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_selectSkillsCost, this.GetCostFromSkillList(selectedSkillList));
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x002FADA0 File Offset: 0x002F8FA0
		private void CloseSelectSkillPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSelectSkillPanel_hotfix != null)
			{
				this.m_CloseSelectSkillPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectSkillPanelGo.SetActive(false);
			this.m_skillItemDetailPanel.SetActive(false);
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x002FAE18 File Offset: 0x002F9018
		private void OnSkillItemClick(HeroSkillItemUIController skillCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemClickHeroSkillItemUIController_hotfix != null)
			{
				this.m_OnSkillItemClickHeroSkillItemUIController_hotfix.call(new object[]
				{
					this,
					skillCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = skillCtrl.gameObject;
			Transform parent = gameObject.transform.parent;
			ConfigDataSkillInfo skillInfo = skillCtrl.m_skillInfo;
			if (parent.gameObject == this.m_allSkillsContent)
			{
				HeroSkillItemUIController component = gameObject.GetComponent<HeroSkillItemUIController>();
				if (!this.m_selectSkillIds.Contains(skillInfo.ID))
				{
					this.m_selectSkillIds.Add(skillInfo.ID);
					int costFromSkillList = this.GetCostFromSkillList(this.m_selectSkillIds);
					if (costFromSkillList > this.m_maxSkillCost)
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_SkillPointNotEnough, 2f, null, true);
						this.m_selectSkillIds.Remove(skillInfo.ID);
						return;
					}
					component.SetSelectPanelActive(true);
					GameObject assetInContainer = base.GetAssetInContainer<GameObject>("skillItem");
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject2);
					HeroSkillItemUIController component2 = gameObject2.GetComponent<HeroSkillItemUIController>();
					component2.EventOnShowDesc += this.OnSkillItemClick;
					component2.InitSkillItem(skillInfo);
					gameObject2.transform.SetParent(this.m_selectSkillsContent.transform, false);
				}
				else
				{
					component.SetSelectPanelActive(false);
					for (int i = 0; i < this.m_selectSkillsContent.transform.childCount; i++)
					{
						HeroSkillItemUIController component3 = this.m_selectSkillsContent.transform.GetChild(i).GetComponent<HeroSkillItemUIController>();
						if (component3.m_skillInfo == skillInfo)
						{
							this.m_selectSkillIds.Remove(component3.m_skillInfo.ID);
							UnityEngine.Object.Destroy(this.m_selectSkillsContent.transform.GetChild(i).gameObject);
						}
					}
				}
			}
			else if (parent.gameObject == this.m_selectSkillsContent)
			{
				for (int j = 0; j < this.m_allSkillsContent.transform.childCount; j++)
				{
					HeroSkillItemUIController component4 = this.m_allSkillsContent.transform.GetChild(j).GetComponent<HeroSkillItemUIController>();
					if (component4.m_skillInfo == skillInfo)
					{
						component4.SetSelectPanelActive(false);
						this.m_selectSkillIds.Remove(component4.m_skillInfo.ID);
					}
				}
				UnityEngine.Object.Destroy(gameObject);
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_selectSkillsCost, this.GetCostFromSkillList(this.m_selectSkillIds));
			if (parent.gameObject == this.m_allSkillsContent)
			{
				if (!this.m_skillItemDetailPanel.activeSelf)
				{
					this.m_skillItemDetailPanel.SetActive(true);
				}
				SkillDescUIController skillDescUIController = null;
				GameObject gameObject3 = this.m_skillItemDetailPanel.gameObject;
				for (int k = 0; k < gameObject3.transform.childCount; k++)
				{
					Transform child = gameObject3.transform.GetChild(k);
					skillDescUIController = child.GetComponent<SkillDescUIController>();
					if (skillDescUIController != null)
					{
						break;
					}
				}
				if (skillDescUIController == null)
				{
					GameObject assetInContainer2 = base.GetAssetInContainer<GameObject>("commonSkillDesc");
					GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer2);
					PrefabControllerCreater.CreateAllControllers(gameObject4);
					skillDescUIController = gameObject4.GetComponent<SkillDescUIController>();
					gameObject4.transform.SetParent(gameObject3.transform, false);
					gameObject4.name = "CommonSkillDesc";
				}
				skillDescUIController.InitSkillDesc(skillInfo);
			}
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x002FB1A4 File Offset: 0x002F93A4
		private void OnConfirmSelectSkillsButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmSelectSkillsButtonClick_hotfix != null)
			{
				this.m_OnConfirmSelectSkillsButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChangeSkill != null)
			{
				this.EventOnChangeSkill(this.m_hero, this.m_selectSkillIds);
			}
			this.CloseSelectSkillPanel();
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x002FB22C File Offset: 0x002F942C
		private int GetCostFromSkillList(List<int> skillIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCostFromSkillListList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCostFromSkillListList`1_hotfix.call(new object[]
				{
					this,
					skillIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (KeyValuePair<int, ConfigDataSkillInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataSkillInfo())
			{
				ConfigDataSkillInfo value = keyValuePair.Value;
				if (skillIds.Contains(value.ID))
				{
					num += value.SkillCost;
				}
			}
			return num;
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x002FB31C File Offset: 0x002F951C
		public void SetSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldier_hotfix != null)
			{
				this.m_SetSoldier_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierChangeButton.gameObject.SetActive(this.m_team == 0 && !this.m_isNpc && this.m_canChangeSoldier);
			ConfigDataSoldierInfo selectedSoldierInfo = this.m_hero.SelectedSoldierInfo;
			this.m_soldierArmyTypeImg.sprite = AssetUtility.Instance.GetSprite(selectedSoldierInfo.m_armyInfo.Icon);
			this.m_soldierNameText.text = selectedSoldierInfo.Name;
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeSoldierCommandProperties(this.m_hero, selectedSoldierInfo, this.m_trainingTechs, this.m_hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader));
			int num = (this.m_soldierHp < 0) ? heroPropertyComputer.Property0.HealthPointMax : this.m_soldierHp;
			this.m_soldierPropHPText.text = num + "/" + heroPropertyComputer.Property0.HealthPointMax;
			if (num > 0 && heroPropertyComputer.Property0.HealthPointMax > 0)
			{
				this.m_soldierPropHPImage.fillAmount = (float)num / (float)heroPropertyComputer.Property0.HealthPointMax;
			}
			else
			{
				this.m_soldierPropHPImage.fillAmount = 0f;
			}
			this.m_soldierPropHPImage.sprite = AssetUtility.Instance.GetSprite((this.m_team != 0) ? "UI/Common_New_ABS/Pattern_Blood_Red01.png" : "UI/Common_New_ABS/Pattern_Blood_Green01.png");
			this.m_soldierPropDFText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_soldierPropATText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_soldierMagicDFText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_soldierDFAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.Defense, heroPropertyComputer.Property1.Defense);
			this.m_soldierATAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.Attack, heroPropertyComputer.Property1.Attack);
			this.m_soldierMagicDFAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.MagicDefense, heroPropertyComputer.Property1.MagicDefense);
			string text = string.Empty;
			ConfigDataModelSkinResourceInfo selectedSoldierModelSkinResourceInfo = this.m_hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader);
			if (selectedSoldierModelSkinResourceInfo != null)
			{
				text = selectedSoldierModelSkinResourceInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = ((this.m_team != 0) ? selectedSoldierInfo.Model2 : selectedSoldierInfo.Model);
			}
			float scale = (float)selectedSoldierInfo.UI_ModelScale * 0.01f;
			Vector2 offset = new Vector2((float)selectedSoldierInfo.UI_ModelOffsetX, (float)selectedSoldierInfo.UI_ModelOffsetY);
			this.DestroySpineGraphic(this.m_soldierGraphic);
			this.m_soldierGraphic = this.CreateSpineGraphic(text, scale, offset, this.m_soldierGraphicGo, selectedSoldierInfo.ReplaceAnims);
			this.SetSoldierDetailPanel();
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x002FB660 File Offset: 0x002F9860
		private void SetSoldierDetailPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierDetailPanel_hotfix != null)
			{
				this.m_SetSoldierDetailPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSoldierInfo selectedSoldierInfo = this.m_hero.SelectedSoldierInfo;
			this.m_soldierDetailTitleText.text = selectedSoldierInfo.Name;
			this.m_soldierDetailIconImg.sprite = AssetUtility.Instance.GetSprite(selectedSoldierInfo.m_armyInfo.Icon);
			string text = string.Empty;
			ConfigDataModelSkinResourceInfo selectedSoldierModelSkinResourceInfo = this.m_hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader);
			if (selectedSoldierModelSkinResourceInfo != null)
			{
				text = selectedSoldierModelSkinResourceInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = ((this.m_team != 0) ? selectedSoldierInfo.Model2 : selectedSoldierInfo.Model);
			}
			float scale = (float)selectedSoldierInfo.UI_ModelScale * 0.01f;
			Vector2 offset = new Vector2((float)selectedSoldierInfo.UI_ModelOffsetX, (float)selectedSoldierInfo.UI_ModelOffsetY);
			this.DestroySpineGraphic(this.m_soldierDetailGraphic);
			this.m_soldierDetailGraphic = this.CreateSpineGraphic(text, scale, offset, this.m_soldierDetailGraphicGo, selectedSoldierInfo.ReplaceAnims);
			if (selectedSoldierInfo.IsMelee)
			{
				this.m_soldierDetailTypeBgImg.gameObject.SetActive(true);
				this.m_soldierDetailTypeBgImg2.gameObject.SetActive(false);
			}
			else
			{
				this.m_soldierDetailTypeBgImg.gameObject.SetActive(false);
				this.m_soldierDetailTypeBgImg2.gameObject.SetActive(true);
			}
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeSoldierCommandProperties(this.m_hero, selectedSoldierInfo, this.m_trainingTechs, this.m_hero.GetSelectedSoldierModelSkinResourceInfo(this.m_configDataLoader));
			this.m_soldierDetailRangeText.text = heroPropertyComputer.Property0.AttackDistance.ToString();
			this.m_soldierDetailMoveText.text = heroPropertyComputer.Property0.MovePoint.ToString();
			this.m_soldierDetailHPText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.m_soldierDetailDFText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_soldierDetailATText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_soldierDetailMagicDFText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_soldierDetailHPAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.HealthPointMax, heroPropertyComputer.Property1.HealthPointMax);
			this.m_soldierDetailDFAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.Defense, heroPropertyComputer.Property1.Defense);
			this.m_soldierDetailATAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.Attack, heroPropertyComputer.Property1.Attack);
			this.m_soldierDetailMagicDFAddText.text = this.CalcPropAddValue(heroPropertyComputer.Property0.MagicDefense, heroPropertyComputer.Property1.MagicDefense);
			this.m_soldierDetailDescText.text = UIUtility.GetSoldierCurSkillDesc(selectedSoldierInfo);
			this.m_soldierDetailWeakText.text = selectedSoldierInfo.Weak;
			this.m_soldierDetailStrongText.text = selectedSoldierInfo.Strong;
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x002FB9C8 File Offset: 0x002F9BC8
		public void ShowSelectSoldierPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectSoldierPanel_hotfix != null)
			{
				this.m_ShowSelectSoldierPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_selectSoldierPanelUIStateController, "Show", null, false, true);
			Hero hero = this.m_playerContext.GetHero(this.m_hero.HeroId);
			if (hero == null)
			{
				return;
			}
			GameObjectUtility.DestroyChildren(this.m_soldiersContent);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("soldierItem");
			List<int> soldierIds = hero.SoldierIds;
			foreach (KeyValuePair<int, ConfigDataSoldierInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataSoldierInfo())
			{
				ConfigDataSoldierInfo value = keyValuePair.Value;
				if (soldierIds.Contains(value.ID))
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					BattleSoldierItemUIController component = gameObject.GetComponent<BattleSoldierItemUIController>();
					component.EventOnSoldierItemClick += this.OnSoldierItemClick;
					component.InitSoldierItem(value, hero.GetSoldierModelSkinResourceInfo(value.ID));
					component.EventOnSelectButtonClick += this.OnSoldierDetailSelectButtonClick;
					gameObject.transform.SetParent(this.m_soldiersContent.transform, false);
					if (this.m_hero.SelectedSoldierId == value.ID)
					{
						component.SetSelectPanel(true);
						this.m_lastClickSoldierItem = component;
					}
				}
			}
		}

		// Token: 0x0600AB33 RID: 43827 RVA: 0x002FBB7C File Offset: 0x002F9D7C
		private void CloseSelectSoldierPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSelectSoldierPanel_hotfix != null)
			{
				this.m_CloseSelectSoldierPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_selectSoldierPanelUIStateController, "Close", null, false, true);
			if (this.m_selectSoldierDetailPanel.transform.childCount != 0 && this.m_selectSoldierDetailPanel.transform.GetChild(0) != null)
			{
				this.m_selectSoldierDetailPanel.transform.GetChild(0).gameObject.SetActive(false);
			}
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x002FBC3C File Offset: 0x002F9E3C
		private void OnSoldierDetailSelectButtonClick(BattleSoldierItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierDetailSelectButtonClickBattleSoldierItemUIController_hotfix != null)
			{
				this.m_OnSoldierDetailSelectButtonClickBattleSoldierItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChangeSoldier != null)
			{
				this.EventOnChangeSoldier(this.m_hero, ctrl.SoldierInfo.ID);
			}
			this.CloseSelectSoldierPanel();
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x002FBCDC File Offset: 0x002F9EDC
		private void OnSoldierItemClick(BattleSoldierItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemClickBattleSoldierItemUIController_hotfix != null)
			{
				this.m_OnSoldierItemClickBattleSoldierItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.SoldierInfo == null)
			{
				return;
			}
			Hero hero = this.m_playerContext.GetHero(this.m_hero.HeroId);
			if (hero == null)
			{
				return;
			}
			SoldierDescUIController soldierDescUIController = null;
			bool flag = false;
			for (int i = 0; i < this.m_selectSoldierDetailPanel.transform.childCount; i++)
			{
				Transform child = this.m_selectSoldierDetailPanel.transform.GetChild(i);
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
				gameObject.transform.SetParent(this.m_selectSoldierDetailPanel.transform, false);
				gameObject.name = "CommonSoldierDesc";
			}
			soldierDescUIController.InitSoldierDesc(ctrl.SoldierInfo, this.m_hero, this.m_trainingTechs, hero.GetSoldierModelSkinResourceInfo(ctrl.SoldierInfo.ID));
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x002FBE54 File Offset: 0x002FA054
		private string CalcPropAddValue(int v0, int v1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcPropAddValueInt32Int32_hotfix != null)
			{
				return (string)this.m_CalcPropAddValueInt32Int32_hotfix.call(new object[]
				{
					this,
					v0,
					v1
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (v1 - v0 == 0)
			{
				return string.Empty;
			}
			if (v1 - v0 < 0)
			{
				return (v1 - v0).ToString();
			}
			return "+" + (v1 - v0);
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x002FBF1C File Offset: 0x002FA11C
		public RectTransform GetSoliderSelectButtonRectTransform(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoliderSelectButtonRectTransformInt32_hotfix != null)
			{
				return (RectTransform)this.m_GetSoliderSelectButtonRectTransformInt32_hotfix.call(new object[]
				{
					this,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_soldiersContent.transform.GetChild(index).transform.Find("SelectButton") as RectTransform;
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x002FBFC0 File Offset: 0x002FA1C0
		public void SelectSolider(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectSoliderInt32_hotfix != null)
			{
				this.m_SelectSoliderInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleSoldierItemUIController component = this.m_soldiersContent.transform.GetChild(index).transform.GetComponent<BattleSoldierItemUIController>();
			if (component != null)
			{
				this.OnSoldierDetailSelectButtonClick(component);
			}
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x002FC060 File Offset: 0x002FA260
		private void SetPropLevelItemImg(Image img, char level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropLevelItemImgImageChar_hotfix != null)
			{
				this.m_SetPropLevelItemImgImageChar_hotfix.call(new object[]
				{
					this,
					img,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string name = null;
			switch (level)
			{
			case 'A':
				name = "UI/Common_New_ABS/Font/Font_A.png";
				break;
			case 'B':
				name = "UI/Common_New_ABS/Font/Font_B.png";
				break;
			case 'C':
				name = "UI/Common_New_ABS/Font/Font_C.png";
				break;
			case 'D':
				name = "UI/Common_New_ABS/Font/Font_D.png";
				break;
			case 'E':
				name = "UI/Common_New_ABS/Font/Font_E.png";
				break;
			default:
				if (level == 'S')
				{
					name = "UI/Common_New_ABS/Font/Font_S.png";
				}
				break;
			}
			img.sprite = AssetUtility.Instance.GetSprite(name);
		}

		// Token: 0x0600AB3A RID: 43834 RVA: 0x002FC164 File Offset: 0x002FA364
		private UISpineGraphic CreateSpineGraphic(string assetName, float scale, Vector2 offset, GameObject parent, List<ReplaceAnim> replaceAnims)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix != null)
			{
				return (UISpineGraphic)this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix.call(new object[]
				{
					this,
					assetName,
					scale,
					offset,
					parent,
					replaceAnims
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UISpineGraphic uispineGraphic = new UISpineGraphic();
			uispineGraphic.Create(assetName);
			uispineGraphic.SetParent(parent);
			uispineGraphic.SetDirection(1);
			uispineGraphic.SetPosition(offset);
			uispineGraphic.SetScale(scale);
			uispineGraphic.SetReplaceAnimations(replaceAnims);
			uispineGraphic.PlayAnimation("idle", true, 0);
			uispineGraphic.ForceUpdate();
			return uispineGraphic;
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x002FC268 File Offset: 0x002FA468
		private void DestroySpineGraphic(UISpineGraphic g)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphicUISpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphicUISpineGraphic_hotfix.call(new object[]
				{
					this,
					g
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (g != null)
			{
				g.Destroy();
			}
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x002FC2E4 File Offset: 0x002FA4E4
		private void OnChangeSkillButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeSkillButtonClick_hotfix != null)
			{
				this.m_OnChangeSkillButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			this.ShowSelectSkillPanel();
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x002FC358 File Offset: 0x002FA558
		private void OnChangeSoldierButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeSoldierButtonClick_hotfix != null)
			{
				this.m_OnChangeSoldierButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			if (this.EventOnShowSelectSoldierPanel != null)
			{
				this.EventOnShowSelectSoldierPanel(this.m_hero);
			}
		}

		// Token: 0x140001F9 RID: 505
		// (add) Token: 0x0600AB3E RID: 43838 RVA: 0x002FC3E0 File Offset: 0x002FA5E0
		// (remove) Token: 0x0600AB3F RID: 43839 RVA: 0x002FC47C File Offset: 0x002FA67C
		public event Action<BattleHero> EventOnShowSelectSoldierPanel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowSelectSoldierPanelAction`1_hotfix != null)
				{
					this.m_add_EventOnShowSelectSoldierPanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero> action = this.EventOnShowSelectSoldierPanel;
				Action<BattleHero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero>>(ref this.EventOnShowSelectSoldierPanel, (Action<BattleHero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowSelectSoldierPanelAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowSelectSoldierPanelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero> action = this.EventOnShowSelectSoldierPanel;
				Action<BattleHero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero>>(ref this.EventOnShowSelectSoldierPanel, (Action<BattleHero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001FA RID: 506
		// (add) Token: 0x0600AB40 RID: 43840 RVA: 0x002FC518 File Offset: 0x002FA718
		// (remove) Token: 0x0600AB41 RID: 43841 RVA: 0x002FC5B4 File Offset: 0x002FA7B4
		public event Action<BattleHero, List<int>> EventOnChangeSkill
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeSkillAction`2_hotfix != null)
				{
					this.m_add_EventOnChangeSkillAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, List<int>> action = this.EventOnChangeSkill;
				Action<BattleHero, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, List<int>>>(ref this.EventOnChangeSkill, (Action<BattleHero, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeSkillAction`2_hotfix != null)
				{
					this.m_remove_EventOnChangeSkillAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, List<int>> action = this.EventOnChangeSkill;
				Action<BattleHero, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, List<int>>>(ref this.EventOnChangeSkill, (Action<BattleHero, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001FB RID: 507
		// (add) Token: 0x0600AB42 RID: 43842 RVA: 0x002FC650 File Offset: 0x002FA850
		// (remove) Token: 0x0600AB43 RID: 43843 RVA: 0x002FC6EC File Offset: 0x002FA8EC
		public event Action<BattleHero, int> EventOnChangeSoldier
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeSoldierAction`2_hotfix != null)
				{
					this.m_add_EventOnChangeSoldierAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, int> action = this.EventOnChangeSoldier;
				Action<BattleHero, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, int>>(ref this.EventOnChangeSoldier, (Action<BattleHero, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeSoldierAction`2_hotfix != null)
				{
					this.m_remove_EventOnChangeSoldierAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleHero, int> action = this.EventOnChangeSoldier;
				Action<BattleHero, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleHero, int>>(ref this.EventOnChangeSoldier, (Action<BattleHero, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x0600AB44 RID: 43844 RVA: 0x002FC788 File Offset: 0x002FA988
		// (set) Token: 0x0600AB45 RID: 43845 RVA: 0x002FC7A8 File Offset: 0x002FA9A8
		[DoNotToLua]
		public new BattlePrepareActorInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePrepareActorInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x002FC7B4 File Offset: 0x002FA9B4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x002FC7C0 File Offset: 0x002FA9C0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x002FC7C8 File Offset: 0x002FA9C8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x002FC7D0 File Offset: 0x002FA9D0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x002FC7E4 File Offset: 0x002FA9E4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x002FC7EC File Offset: 0x002FA9EC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x002FC7F8 File Offset: 0x002FA9F8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x002FC804 File Offset: 0x002FAA04
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x002FC810 File Offset: 0x002FAA10
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x002FC81C File Offset: 0x002FAA1C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x002FC828 File Offset: 0x002FAA28
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x002FC834 File Offset: 0x002FAA34
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x002FC840 File Offset: 0x002FAA40
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x002FC84C File Offset: 0x002FAA4C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x002FC858 File Offset: 0x002FAA58
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x002FC860 File Offset: 0x002FAA60
		private void __callDele_EventOnShowSelectSoldierPanel(BattleHero obj)
		{
			Action<BattleHero> eventOnShowSelectSoldierPanel = this.EventOnShowSelectSoldierPanel;
			if (eventOnShowSelectSoldierPanel != null)
			{
				eventOnShowSelectSoldierPanel(obj);
			}
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x002FC884 File Offset: 0x002FAA84
		private void __clearDele_EventOnShowSelectSoldierPanel(BattleHero obj)
		{
			this.EventOnShowSelectSoldierPanel = null;
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x002FC890 File Offset: 0x002FAA90
		private void __callDele_EventOnChangeSkill(BattleHero arg1, List<int> arg2)
		{
			Action<BattleHero, List<int>> eventOnChangeSkill = this.EventOnChangeSkill;
			if (eventOnChangeSkill != null)
			{
				eventOnChangeSkill(arg1, arg2);
			}
		}

		// Token: 0x0600AB58 RID: 43864 RVA: 0x002FC8B4 File Offset: 0x002FAAB4
		private void __clearDele_EventOnChangeSkill(BattleHero arg1, List<int> arg2)
		{
			this.EventOnChangeSkill = null;
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x002FC8C0 File Offset: 0x002FAAC0
		private void __callDele_EventOnChangeSoldier(BattleHero arg1, int arg2)
		{
			Action<BattleHero, int> eventOnChangeSoldier = this.EventOnChangeSoldier;
			if (eventOnChangeSoldier != null)
			{
				eventOnChangeSoldier(arg1, arg2);
			}
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x002FC8E4 File Offset: 0x002FAAE4
		private void __clearDele_EventOnChangeSoldier(BattleHero arg1, int arg2)
		{
			this.EventOnChangeSoldier = null;
		}

		// Token: 0x0600AB60 RID: 43872 RVA: 0x002FC950 File Offset: 0x002FAB50
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
					this.m_OpenBoolean_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_SetActorInfoBattleHeroList`1Int32BooleanBooleanConfigDataSkillInfoInt32Int32_hotfix = (luaObj.RawGet("SetActorInfo") as LuaFunction);
					this.m_GetHeroId_hotfix = (luaObj.RawGet("GetHeroId") as LuaFunction);
					this.m_GetTeam_hotfix = (luaObj.RawGet("GetTeam") as LuaFunction);
					this.m_CanChangeSoldier_hotfix = (luaObj.RawGet("CanChangeSoldier") as LuaFunction);
					this.m_SetSkills_hotfix = (luaObj.RawGet("SetSkills") as LuaFunction);
					this.m_SetSkillsAndTalentList_hotfix = (luaObj.RawGet("SetSkillsAndTalentList") as LuaFunction);
					this.m_ShowSelectSkillPanel_hotfix = (luaObj.RawGet("ShowSelectSkillPanel") as LuaFunction);
					this.m_CloseSelectSkillPanel_hotfix = (luaObj.RawGet("CloseSelectSkillPanel") as LuaFunction);
					this.m_OnSkillItemClickHeroSkillItemUIController_hotfix = (luaObj.RawGet("OnSkillItemClick") as LuaFunction);
					this.m_OnConfirmSelectSkillsButtonClick_hotfix = (luaObj.RawGet("OnConfirmSelectSkillsButtonClick") as LuaFunction);
					this.m_GetCostFromSkillListList`1_hotfix = (luaObj.RawGet("GetCostFromSkillList") as LuaFunction);
					this.m_SetSoldier_hotfix = (luaObj.RawGet("SetSoldier") as LuaFunction);
					this.m_SetSoldierDetailPanel_hotfix = (luaObj.RawGet("SetSoldierDetailPanel") as LuaFunction);
					this.m_ShowSelectSoldierPanel_hotfix = (luaObj.RawGet("ShowSelectSoldierPanel") as LuaFunction);
					this.m_CloseSelectSoldierPanel_hotfix = (luaObj.RawGet("CloseSelectSoldierPanel") as LuaFunction);
					this.m_OnSoldierDetailSelectButtonClickBattleSoldierItemUIController_hotfix = (luaObj.RawGet("OnSoldierDetailSelectButtonClick") as LuaFunction);
					this.m_OnSoldierItemClickBattleSoldierItemUIController_hotfix = (luaObj.RawGet("OnSoldierItemClick") as LuaFunction);
					this.m_CalcPropAddValueInt32Int32_hotfix = (luaObj.RawGet("CalcPropAddValue") as LuaFunction);
					this.m_GetSoliderSelectButtonRectTransformInt32_hotfix = (luaObj.RawGet("GetSoliderSelectButtonRectTransform") as LuaFunction);
					this.m_SelectSoliderInt32_hotfix = (luaObj.RawGet("SelectSolider") as LuaFunction);
					this.m_SetPropLevelItemImgImageChar_hotfix = (luaObj.RawGet("SetPropLevelItemImg") as LuaFunction);
					this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphicUISpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_OnChangeSkillButtonClick_hotfix = (luaObj.RawGet("OnChangeSkillButtonClick") as LuaFunction);
					this.m_OnChangeSoldierButtonClick_hotfix = (luaObj.RawGet("OnChangeSoldierButtonClick") as LuaFunction);
					this.m_add_EventOnShowSelectSoldierPanelAction`1_hotfix = (luaObj.RawGet("add_EventOnShowSelectSoldierPanel") as LuaFunction);
					this.m_remove_EventOnShowSelectSoldierPanelAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowSelectSoldierPanel") as LuaFunction);
					this.m_add_EventOnChangeSkillAction`2_hotfix = (luaObj.RawGet("add_EventOnChangeSkill") as LuaFunction);
					this.m_remove_EventOnChangeSkillAction`2_hotfix = (luaObj.RawGet("remove_EventOnChangeSkill") as LuaFunction);
					this.m_add_EventOnChangeSoldierAction`2_hotfix = (luaObj.RawGet("add_EventOnChangeSoldier") as LuaFunction);
					this.m_remove_EventOnChangeSoldierAction`2_hotfix = (luaObj.RawGet("remove_EventOnChangeSoldier") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x002FCD88 File Offset: 0x002FAF88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePrepareActorInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007043 RID: 28739
		[AutoBind("./Hero", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroGameObject;

		// Token: 0x04007044 RID: 28740
		[AutoBind("./Hero/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameText;

		// Token: 0x04007045 RID: 28741
		[AutoBind("./Hero/Army/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroArmyIcon;

		// Token: 0x04007046 RID: 28742
		[AutoBind("./Hero/Job/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroJobText;

		// Token: 0x04007047 RID: 28743
		[AutoBind("./Hero/Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLevelText;

		// Token: 0x04007048 RID: 28744
		[AutoBind("./Hero/Range/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroRangeText;

		// Token: 0x04007049 RID: 28745
		[AutoBind("./Hero/Move/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroMoveText;

		// Token: 0x0400704A RID: 28746
		[AutoBind("./HeroPanelGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroPanelGroupCtrl;

		// Token: 0x0400704B RID: 28747
		[AutoBind("./HeroPanelGroup/HeroIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIcon;

		// Token: 0x0400704C RID: 28748
		[AutoBind("./Hero/HP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroHPText;

		// Token: 0x0400704D RID: 28749
		[AutoBind("./Hero/HP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroHPImage;

		// Token: 0x0400704E RID: 28750
		[AutoBind("./Hero/DEX/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroDEXText;

		// Token: 0x0400704F RID: 28751
		[AutoBind("./Hero/Attack/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroAttackText;

		// Token: 0x04007050 RID: 28752
		[AutoBind("./Hero/Defense/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroDefenseText;

		// Token: 0x04007051 RID: 28753
		[AutoBind("./Hero/Magic/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroMagicText;

		// Token: 0x04007052 RID: 28754
		[AutoBind("./Hero/MagicDefense/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroMagicDefenseText;

		// Token: 0x04007053 RID: 28755
		[AutoBind("./Hero/SkillInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroSkillInfoButton;

		// Token: 0x04007054 RID: 28756
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/TalentSkill", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillInfoGroupTalentSkillImage;

		// Token: 0x04007055 RID: 28757
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/SkillIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillInfoGroupSkillGo;

		// Token: 0x04007056 RID: 28758
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/SkillIcon2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillInfoGroupSkillGo2;

		// Token: 0x04007057 RID: 28759
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/SkillIcon3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillInfoGroupSkillGo3;

		// Token: 0x04007058 RID: 28760
		[AutoBind("./Hero/ChangeSkillButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillChangeButton;

		// Token: 0x04007059 RID: 28761
		[AutoBind("./SelectSkill", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectSkillPanelGo;

		// Token: 0x0400705A RID: 28762
		[AutoBind("./SelectSkill/SkillItemScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_allSkillsContent;

		// Token: 0x0400705B RID: 28763
		[AutoBind("./SelectSkill/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectSkillsContent;

		// Token: 0x0400705C RID: 28764
		[AutoBind("./SelectSkill/Costs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectSkillsCost;

		// Token: 0x0400705D RID: 28765
		[AutoBind("./SelectSkill/ReturnBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeSelectSkillButton;

		// Token: 0x0400705E RID: 28766
		[AutoBind("./SelectSkill/SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectSkillConfirmButton;

		// Token: 0x0400705F RID: 28767
		[AutoBind("./SkillList", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailObj;

		// Token: 0x04007060 RID: 28768
		[AutoBind("./SkillList/List", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailListObj;

		// Token: 0x04007061 RID: 28769
		[AutoBind("./SkillList/List/Content/Talent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListContentTalentObj;

		// Token: 0x04007062 RID: 28770
		[AutoBind("./SkillList/List/Content/Talent/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillListContentTalentIcon;

		// Token: 0x04007063 RID: 28771
		[AutoBind("./SkillList/List/Content/Talent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillListContentTalentNameText;

		// Token: 0x04007064 RID: 28772
		[AutoBind("./SkillList/List/Content/Talent/DescTextScrollRect/Mask/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillListContentTalentDescText;

		// Token: 0x04007065 RID: 28773
		[AutoBind("./SkillList/List/Content/LineImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillListContentLineImage;

		// Token: 0x04007066 RID: 28774
		[AutoBind("./SkillList/List/Content/List", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListContentListObj;

		// Token: 0x04007067 RID: 28775
		[AutoBind("./SkillList/List/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListContentObj;

		// Token: 0x04007068 RID: 28776
		[AutoBind("./SkillList/List/NoSkills", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListNoSkillsObj;

		// Token: 0x04007069 RID: 28777
		[AutoBind("./Prefabs/SkillDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDescPrefabObj;

		// Token: 0x0400706A RID: 28778
		[AutoBind("./SelectSkill/SkillItemDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillItemDetailPanel;

		// Token: 0x0400706B RID: 28779
		[AutoBind("./Soldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGo;

		// Token: 0x0400706C RID: 28780
		[AutoBind("./Soldier/ChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierChangeButton;

		// Token: 0x0400706D RID: 28781
		[AutoBind("./SelectSoldier/ReturnBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeSelectSoldierButton;

		// Token: 0x0400706E RID: 28782
		[AutoBind("./SelectSoldier", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_selectSoldierPanelUIStateController;

		// Token: 0x0400706F RID: 28783
		[AutoBind("./SelectSoldier/SoldierItemScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldiersContent;

		// Token: 0x04007070 RID: 28784
		[AutoBind("./SelectSoldier/SoldierDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectSoldierDetailPanel;

		// Token: 0x04007071 RID: 28785
		[AutoBind("./Soldier/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphicGo;

		// Token: 0x04007072 RID: 28786
		[AutoBind("./Soldier/Army/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierArmyTypeImg;

		// Token: 0x04007073 RID: 28787
		[AutoBind("./Soldier/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x04007074 RID: 28788
		[AutoBind("./Soldier/Info", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierInfoBtn;

		// Token: 0x04007075 RID: 28789
		[AutoBind("./Soldier/HP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropHPText;

		// Token: 0x04007076 RID: 28790
		[AutoBind("./Soldier/HP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierPropHPImage;

		// Token: 0x04007077 RID: 28791
		[AutoBind("./Soldier/Prop/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropDFText;

		// Token: 0x04007078 RID: 28792
		[AutoBind("./Soldier/Prop/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropATText;

		// Token: 0x04007079 RID: 28793
		[AutoBind("./Soldier/Prop/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFText;

		// Token: 0x0400707A RID: 28794
		[AutoBind("./Soldier/Prop/DF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDFAddText;

		// Token: 0x0400707B RID: 28795
		[AutoBind("./Soldier/Prop/AT/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierATAddText;

		// Token: 0x0400707C RID: 28796
		[AutoBind("./Soldier/Prop/MagicDF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFAddText;

		// Token: 0x0400707D RID: 28797
		[AutoBind("./Soldier/SoldierDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierDetailPanelUIStateController;

		// Token: 0x0400707E RID: 28798
		[AutoBind("./Soldier/SoldierDetailPanel/SoldierIconImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierDetailIconImg;

		// Token: 0x0400707F RID: 28799
		[AutoBind("./Soldier/SoldierDetailPanel/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDetailGraphicGo;

		// Token: 0x04007080 RID: 28800
		[AutoBind("./Soldier/SoldierDetailPanel/Faction/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailRangeText;

		// Token: 0x04007081 RID: 28801
		[AutoBind("./Soldier/SoldierDetailPanel/Faction/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailMoveText;

		// Token: 0x04007082 RID: 28802
		[AutoBind("./Soldier/SoldierDetailPanel/Faction/TypeBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierDetailTypeBgImg;

		// Token: 0x04007083 RID: 28803
		[AutoBind("./Soldier/SoldierDetailPanel/Faction/TypeBgImage2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierDetailTypeBgImg2;

		// Token: 0x04007084 RID: 28804
		[AutoBind("./Soldier/SoldierDetailPanel/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailTitleText;

		// Token: 0x04007085 RID: 28805
		[AutoBind("./Soldier/SoldierDetailPanel/Desc/DescTextScroll/Mask/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailDescText;

		// Token: 0x04007086 RID: 28806
		[AutoBind("./Soldier/SoldierDetailPanel/Desc/Weak/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailWeakText;

		// Token: 0x04007087 RID: 28807
		[AutoBind("./Soldier/SoldierDetailPanel/Desc/Restrain/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailStrongText;

		// Token: 0x04007088 RID: 28808
		[AutoBind("./Soldier/SoldierDetailPanel/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailHPText;

		// Token: 0x04007089 RID: 28809
		[AutoBind("./Soldier/SoldierDetailPanel/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailDFText;

		// Token: 0x0400708A RID: 28810
		[AutoBind("./Soldier/SoldierDetailPanel/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailATText;

		// Token: 0x0400708B RID: 28811
		[AutoBind("./Soldier/SoldierDetailPanel/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailMagicDFText;

		// Token: 0x0400708C RID: 28812
		[AutoBind("./Soldier/SoldierDetailPanel/HP/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailHPAddText;

		// Token: 0x0400708D RID: 28813
		[AutoBind("./Soldier/SoldierDetailPanel/DF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailDFAddText;

		// Token: 0x0400708E RID: 28814
		[AutoBind("./Soldier/SoldierDetailPanel/AT/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailATAddText;

		// Token: 0x0400708F RID: 28815
		[AutoBind("./Soldier/SoldierDetailPanel/MagicDF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDetailMagicDFAddText;

		// Token: 0x04007090 RID: 28816
		private BattleHero m_hero;

		// Token: 0x04007091 RID: 28817
		private List<TrainingTech> m_trainingTechs;

		// Token: 0x04007092 RID: 28818
		private int m_team;

		// Token: 0x04007093 RID: 28819
		private bool m_isNpc;

		// Token: 0x04007094 RID: 28820
		private bool m_canChangeSoldier;

		// Token: 0x04007095 RID: 28821
		private int m_heroHp;

		// Token: 0x04007096 RID: 28822
		private int m_soldierHp;

		// Token: 0x04007097 RID: 28823
		private ConfigDataSkillInfo m_extraTalentSkillInfo;

		// Token: 0x04007098 RID: 28824
		private bool m_isOpened;

		// Token: 0x04007099 RID: 28825
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400709A RID: 28826
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400709B RID: 28827
		private List<int> m_selectSkillIds = new List<int>();

		// Token: 0x0400709C RID: 28828
		private BattleSoldierItemUIController m_lastClickSoldierItem;

		// Token: 0x0400709D RID: 28829
		private int m_maxSkillCost;

		// Token: 0x0400709E RID: 28830
		private UISpineGraphic m_soldierGraphic;

		// Token: 0x0400709F RID: 28831
		private UISpineGraphic m_soldierDetailGraphic;

		// Token: 0x040070A0 RID: 28832
		private GameObjectPool<SkillDesc> m_skillDescPool;

		// Token: 0x040070A1 RID: 28833
		[DoNotToLua]
		private BattlePrepareActorInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040070A2 RID: 28834
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040070A3 RID: 28835
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040070A4 RID: 28836
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040070A5 RID: 28837
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x040070A6 RID: 28838
		private LuaFunction m_OpenBoolean_hotfix;

		// Token: 0x040070A7 RID: 28839
		private LuaFunction m_Close_hotfix;

		// Token: 0x040070A8 RID: 28840
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x040070A9 RID: 28841
		private LuaFunction m_SetActorInfoBattleHeroList;

		// Token: 0x040070AA RID: 28842
		private LuaFunction m_GetHeroId_hotfix;

		// Token: 0x040070AB RID: 28843
		private LuaFunction m_GetTeam_hotfix;

		// Token: 0x040070AC RID: 28844
		private LuaFunction m_CanChangeSoldier_hotfix;

		// Token: 0x040070AD RID: 28845
		private LuaFunction m_SetSkills_hotfix;

		// Token: 0x040070AE RID: 28846
		private LuaFunction m_SetSkillsAndTalentList_hotfix;

		// Token: 0x040070AF RID: 28847
		private LuaFunction m_ShowSelectSkillPanel_hotfix;

		// Token: 0x040070B0 RID: 28848
		private LuaFunction m_CloseSelectSkillPanel_hotfix;

		// Token: 0x040070B1 RID: 28849
		private LuaFunction m_OnSkillItemClickHeroSkillItemUIController_hotfix;

		// Token: 0x040070B2 RID: 28850
		private LuaFunction m_OnConfirmSelectSkillsButtonClick_hotfix;

		// Token: 0x040070B3 RID: 28851
		private LuaFunction m_GetCostFromSkillListList;

		// Token: 0x040070B4 RID: 28852
		private LuaFunction m_SetSoldier_hotfix;

		// Token: 0x040070B5 RID: 28853
		private LuaFunction m_SetSoldierDetailPanel_hotfix;

		// Token: 0x040070B6 RID: 28854
		private LuaFunction m_ShowSelectSoldierPanel_hotfix;

		// Token: 0x040070B7 RID: 28855
		private LuaFunction m_CloseSelectSoldierPanel_hotfix;

		// Token: 0x040070B8 RID: 28856
		private LuaFunction m_OnSoldierDetailSelectButtonClickBattleSoldierItemUIController_hotfix;

		// Token: 0x040070B9 RID: 28857
		private LuaFunction m_OnSoldierItemClickBattleSoldierItemUIController_hotfix;

		// Token: 0x040070BA RID: 28858
		private LuaFunction m_CalcPropAddValueInt32Int32_hotfix;

		// Token: 0x040070BB RID: 28859
		private LuaFunction m_GetSoliderSelectButtonRectTransformInt32_hotfix;

		// Token: 0x040070BC RID: 28860
		private LuaFunction m_SelectSoliderInt32_hotfix;

		// Token: 0x040070BD RID: 28861
		private LuaFunction m_SetPropLevelItemImgImageChar_hotfix;

		// Token: 0x040070BE RID: 28862
		private LuaFunction m_CreateSpineGraphicStringSingleVector2GameObjectList;

		// Token: 0x040070BF RID: 28863
		private LuaFunction m_DestroySpineGraphicUISpineGraphic_hotfix;

		// Token: 0x040070C0 RID: 28864
		private LuaFunction m_OnChangeSkillButtonClick_hotfix;

		// Token: 0x040070C1 RID: 28865
		private LuaFunction m_OnChangeSoldierButtonClick_hotfix;

		// Token: 0x040070C2 RID: 28866
		private LuaFunction m_add_EventOnShowSelectSoldierPanelAction;

		// Token: 0x040070C3 RID: 28867
		private LuaFunction m_remove_EventOnShowSelectSoldierPanelAction;

		// Token: 0x040070C4 RID: 28868
		private LuaFunction m_add_EventOnChangeSkillAction;

		// Token: 0x040070C5 RID: 28869
		private LuaFunction m_remove_EventOnChangeSkillAction;

		// Token: 0x040070C6 RID: 28870
		private LuaFunction m_add_EventOnChangeSoldierAction;

		// Token: 0x040070C7 RID: 28871
		private LuaFunction m_remove_EventOnChangeSoldierAction;

		// Token: 0x02000A94 RID: 2708
		public new class LuaExportHelper
		{
			// Token: 0x0600AB62 RID: 43874 RVA: 0x002FCDF0 File Offset: 0x002FAFF0
			public LuaExportHelper(BattlePrepareActorInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AB63 RID: 43875 RVA: 0x002FCE00 File Offset: 0x002FB000
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AB64 RID: 43876 RVA: 0x002FCE10 File Offset: 0x002FB010
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AB65 RID: 43877 RVA: 0x002FCE20 File Offset: 0x002FB020
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AB66 RID: 43878 RVA: 0x002FCE30 File Offset: 0x002FB030
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AB67 RID: 43879 RVA: 0x002FCE48 File Offset: 0x002FB048
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AB68 RID: 43880 RVA: 0x002FCE58 File Offset: 0x002FB058
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AB69 RID: 43881 RVA: 0x002FCE68 File Offset: 0x002FB068
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AB6A RID: 43882 RVA: 0x002FCE78 File Offset: 0x002FB078
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AB6B RID: 43883 RVA: 0x002FCE88 File Offset: 0x002FB088
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AB6C RID: 43884 RVA: 0x002FCE98 File Offset: 0x002FB098
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AB6D RID: 43885 RVA: 0x002FCEA8 File Offset: 0x002FB0A8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AB6E RID: 43886 RVA: 0x002FCEB8 File Offset: 0x002FB0B8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AB6F RID: 43887 RVA: 0x002FCEC8 File Offset: 0x002FB0C8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AB70 RID: 43888 RVA: 0x002FCED8 File Offset: 0x002FB0D8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AB71 RID: 43889 RVA: 0x002FCEE8 File Offset: 0x002FB0E8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600AB72 RID: 43890 RVA: 0x002FCEF8 File Offset: 0x002FB0F8
			public void __callDele_EventOnShowSelectSoldierPanel(BattleHero obj)
			{
				this.m_owner.__callDele_EventOnShowSelectSoldierPanel(obj);
			}

			// Token: 0x0600AB73 RID: 43891 RVA: 0x002FCF08 File Offset: 0x002FB108
			public void __clearDele_EventOnShowSelectSoldierPanel(BattleHero obj)
			{
				this.m_owner.__clearDele_EventOnShowSelectSoldierPanel(obj);
			}

			// Token: 0x0600AB74 RID: 43892 RVA: 0x002FCF18 File Offset: 0x002FB118
			public void __callDele_EventOnChangeSkill(BattleHero arg1, List<int> arg2)
			{
				this.m_owner.__callDele_EventOnChangeSkill(arg1, arg2);
			}

			// Token: 0x0600AB75 RID: 43893 RVA: 0x002FCF28 File Offset: 0x002FB128
			public void __clearDele_EventOnChangeSkill(BattleHero arg1, List<int> arg2)
			{
				this.m_owner.__clearDele_EventOnChangeSkill(arg1, arg2);
			}

			// Token: 0x0600AB76 RID: 43894 RVA: 0x002FCF38 File Offset: 0x002FB138
			public void __callDele_EventOnChangeSoldier(BattleHero arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnChangeSoldier(arg1, arg2);
			}

			// Token: 0x0600AB77 RID: 43895 RVA: 0x002FCF48 File Offset: 0x002FB148
			public void __clearDele_EventOnChangeSoldier(BattleHero arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnChangeSoldier(arg1, arg2);
			}

			// Token: 0x170022A7 RID: 8871
			// (get) Token: 0x0600AB78 RID: 43896 RVA: 0x002FCF58 File Offset: 0x002FB158
			// (set) Token: 0x0600AB79 RID: 43897 RVA: 0x002FCF68 File Offset: 0x002FB168
			public GameObject m_heroGameObject
			{
				get
				{
					return this.m_owner.m_heroGameObject;
				}
				set
				{
					this.m_owner.m_heroGameObject = value;
				}
			}

			// Token: 0x170022A8 RID: 8872
			// (get) Token: 0x0600AB7A RID: 43898 RVA: 0x002FCF78 File Offset: 0x002FB178
			// (set) Token: 0x0600AB7B RID: 43899 RVA: 0x002FCF88 File Offset: 0x002FB188
			public Text m_heroNameText
			{
				get
				{
					return this.m_owner.m_heroNameText;
				}
				set
				{
					this.m_owner.m_heroNameText = value;
				}
			}

			// Token: 0x170022A9 RID: 8873
			// (get) Token: 0x0600AB7C RID: 43900 RVA: 0x002FCF98 File Offset: 0x002FB198
			// (set) Token: 0x0600AB7D RID: 43901 RVA: 0x002FCFA8 File Offset: 0x002FB1A8
			public Image m_heroArmyIcon
			{
				get
				{
					return this.m_owner.m_heroArmyIcon;
				}
				set
				{
					this.m_owner.m_heroArmyIcon = value;
				}
			}

			// Token: 0x170022AA RID: 8874
			// (get) Token: 0x0600AB7E RID: 43902 RVA: 0x002FCFB8 File Offset: 0x002FB1B8
			// (set) Token: 0x0600AB7F RID: 43903 RVA: 0x002FCFC8 File Offset: 0x002FB1C8
			public Text m_heroJobText
			{
				get
				{
					return this.m_owner.m_heroJobText;
				}
				set
				{
					this.m_owner.m_heroJobText = value;
				}
			}

			// Token: 0x170022AB RID: 8875
			// (get) Token: 0x0600AB80 RID: 43904 RVA: 0x002FCFD8 File Offset: 0x002FB1D8
			// (set) Token: 0x0600AB81 RID: 43905 RVA: 0x002FCFE8 File Offset: 0x002FB1E8
			public Text m_heroLevelText
			{
				get
				{
					return this.m_owner.m_heroLevelText;
				}
				set
				{
					this.m_owner.m_heroLevelText = value;
				}
			}

			// Token: 0x170022AC RID: 8876
			// (get) Token: 0x0600AB82 RID: 43906 RVA: 0x002FCFF8 File Offset: 0x002FB1F8
			// (set) Token: 0x0600AB83 RID: 43907 RVA: 0x002FD008 File Offset: 0x002FB208
			public Text m_heroRangeText
			{
				get
				{
					return this.m_owner.m_heroRangeText;
				}
				set
				{
					this.m_owner.m_heroRangeText = value;
				}
			}

			// Token: 0x170022AD RID: 8877
			// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x002FD018 File Offset: 0x002FB218
			// (set) Token: 0x0600AB85 RID: 43909 RVA: 0x002FD028 File Offset: 0x002FB228
			public Text m_heroMoveText
			{
				get
				{
					return this.m_owner.m_heroMoveText;
				}
				set
				{
					this.m_owner.m_heroMoveText = value;
				}
			}

			// Token: 0x170022AE RID: 8878
			// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x002FD038 File Offset: 0x002FB238
			// (set) Token: 0x0600AB87 RID: 43911 RVA: 0x002FD048 File Offset: 0x002FB248
			public CommonUIStateController m_heroPanelGroupCtrl
			{
				get
				{
					return this.m_owner.m_heroPanelGroupCtrl;
				}
				set
				{
					this.m_owner.m_heroPanelGroupCtrl = value;
				}
			}

			// Token: 0x170022AF RID: 8879
			// (get) Token: 0x0600AB88 RID: 43912 RVA: 0x002FD058 File Offset: 0x002FB258
			// (set) Token: 0x0600AB89 RID: 43913 RVA: 0x002FD068 File Offset: 0x002FB268
			public Image m_heroIcon
			{
				get
				{
					return this.m_owner.m_heroIcon;
				}
				set
				{
					this.m_owner.m_heroIcon = value;
				}
			}

			// Token: 0x170022B0 RID: 8880
			// (get) Token: 0x0600AB8A RID: 43914 RVA: 0x002FD078 File Offset: 0x002FB278
			// (set) Token: 0x0600AB8B RID: 43915 RVA: 0x002FD088 File Offset: 0x002FB288
			public Text m_heroHPText
			{
				get
				{
					return this.m_owner.m_heroHPText;
				}
				set
				{
					this.m_owner.m_heroHPText = value;
				}
			}

			// Token: 0x170022B1 RID: 8881
			// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x002FD098 File Offset: 0x002FB298
			// (set) Token: 0x0600AB8D RID: 43917 RVA: 0x002FD0A8 File Offset: 0x002FB2A8
			public Image m_heroHPImage
			{
				get
				{
					return this.m_owner.m_heroHPImage;
				}
				set
				{
					this.m_owner.m_heroHPImage = value;
				}
			}

			// Token: 0x170022B2 RID: 8882
			// (get) Token: 0x0600AB8E RID: 43918 RVA: 0x002FD0B8 File Offset: 0x002FB2B8
			// (set) Token: 0x0600AB8F RID: 43919 RVA: 0x002FD0C8 File Offset: 0x002FB2C8
			public Text m_heroDEXText
			{
				get
				{
					return this.m_owner.m_heroDEXText;
				}
				set
				{
					this.m_owner.m_heroDEXText = value;
				}
			}

			// Token: 0x170022B3 RID: 8883
			// (get) Token: 0x0600AB90 RID: 43920 RVA: 0x002FD0D8 File Offset: 0x002FB2D8
			// (set) Token: 0x0600AB91 RID: 43921 RVA: 0x002FD0E8 File Offset: 0x002FB2E8
			public Text m_heroAttackText
			{
				get
				{
					return this.m_owner.m_heroAttackText;
				}
				set
				{
					this.m_owner.m_heroAttackText = value;
				}
			}

			// Token: 0x170022B4 RID: 8884
			// (get) Token: 0x0600AB92 RID: 43922 RVA: 0x002FD0F8 File Offset: 0x002FB2F8
			// (set) Token: 0x0600AB93 RID: 43923 RVA: 0x002FD108 File Offset: 0x002FB308
			public Text m_heroDefenseText
			{
				get
				{
					return this.m_owner.m_heroDefenseText;
				}
				set
				{
					this.m_owner.m_heroDefenseText = value;
				}
			}

			// Token: 0x170022B5 RID: 8885
			// (get) Token: 0x0600AB94 RID: 43924 RVA: 0x002FD118 File Offset: 0x002FB318
			// (set) Token: 0x0600AB95 RID: 43925 RVA: 0x002FD128 File Offset: 0x002FB328
			public Text m_heroMagicText
			{
				get
				{
					return this.m_owner.m_heroMagicText;
				}
				set
				{
					this.m_owner.m_heroMagicText = value;
				}
			}

			// Token: 0x170022B6 RID: 8886
			// (get) Token: 0x0600AB96 RID: 43926 RVA: 0x002FD138 File Offset: 0x002FB338
			// (set) Token: 0x0600AB97 RID: 43927 RVA: 0x002FD148 File Offset: 0x002FB348
			public Text m_heroMagicDefenseText
			{
				get
				{
					return this.m_owner.m_heroMagicDefenseText;
				}
				set
				{
					this.m_owner.m_heroMagicDefenseText = value;
				}
			}

			// Token: 0x170022B7 RID: 8887
			// (get) Token: 0x0600AB98 RID: 43928 RVA: 0x002FD158 File Offset: 0x002FB358
			// (set) Token: 0x0600AB99 RID: 43929 RVA: 0x002FD168 File Offset: 0x002FB368
			public Button m_heroSkillInfoButton
			{
				get
				{
					return this.m_owner.m_heroSkillInfoButton;
				}
				set
				{
					this.m_owner.m_heroSkillInfoButton = value;
				}
			}

			// Token: 0x170022B8 RID: 8888
			// (get) Token: 0x0600AB9A RID: 43930 RVA: 0x002FD178 File Offset: 0x002FB378
			// (set) Token: 0x0600AB9B RID: 43931 RVA: 0x002FD188 File Offset: 0x002FB388
			public Image m_skillInfoGroupTalentSkillImage
			{
				get
				{
					return this.m_owner.m_skillInfoGroupTalentSkillImage;
				}
				set
				{
					this.m_owner.m_skillInfoGroupTalentSkillImage = value;
				}
			}

			// Token: 0x170022B9 RID: 8889
			// (get) Token: 0x0600AB9C RID: 43932 RVA: 0x002FD198 File Offset: 0x002FB398
			// (set) Token: 0x0600AB9D RID: 43933 RVA: 0x002FD1A8 File Offset: 0x002FB3A8
			public GameObject m_skillInfoGroupSkillGo
			{
				get
				{
					return this.m_owner.m_skillInfoGroupSkillGo;
				}
				set
				{
					this.m_owner.m_skillInfoGroupSkillGo = value;
				}
			}

			// Token: 0x170022BA RID: 8890
			// (get) Token: 0x0600AB9E RID: 43934 RVA: 0x002FD1B8 File Offset: 0x002FB3B8
			// (set) Token: 0x0600AB9F RID: 43935 RVA: 0x002FD1C8 File Offset: 0x002FB3C8
			public GameObject m_skillInfoGroupSkillGo2
			{
				get
				{
					return this.m_owner.m_skillInfoGroupSkillGo2;
				}
				set
				{
					this.m_owner.m_skillInfoGroupSkillGo2 = value;
				}
			}

			// Token: 0x170022BB RID: 8891
			// (get) Token: 0x0600ABA0 RID: 43936 RVA: 0x002FD1D8 File Offset: 0x002FB3D8
			// (set) Token: 0x0600ABA1 RID: 43937 RVA: 0x002FD1E8 File Offset: 0x002FB3E8
			public GameObject m_skillInfoGroupSkillGo3
			{
				get
				{
					return this.m_owner.m_skillInfoGroupSkillGo3;
				}
				set
				{
					this.m_owner.m_skillInfoGroupSkillGo3 = value;
				}
			}

			// Token: 0x170022BC RID: 8892
			// (get) Token: 0x0600ABA2 RID: 43938 RVA: 0x002FD1F8 File Offset: 0x002FB3F8
			// (set) Token: 0x0600ABA3 RID: 43939 RVA: 0x002FD208 File Offset: 0x002FB408
			public Button m_skillChangeButton
			{
				get
				{
					return this.m_owner.m_skillChangeButton;
				}
				set
				{
					this.m_owner.m_skillChangeButton = value;
				}
			}

			// Token: 0x170022BD RID: 8893
			// (get) Token: 0x0600ABA4 RID: 43940 RVA: 0x002FD218 File Offset: 0x002FB418
			// (set) Token: 0x0600ABA5 RID: 43941 RVA: 0x002FD228 File Offset: 0x002FB428
			public GameObject m_selectSkillPanelGo
			{
				get
				{
					return this.m_owner.m_selectSkillPanelGo;
				}
				set
				{
					this.m_owner.m_selectSkillPanelGo = value;
				}
			}

			// Token: 0x170022BE RID: 8894
			// (get) Token: 0x0600ABA6 RID: 43942 RVA: 0x002FD238 File Offset: 0x002FB438
			// (set) Token: 0x0600ABA7 RID: 43943 RVA: 0x002FD248 File Offset: 0x002FB448
			public GameObject m_allSkillsContent
			{
				get
				{
					return this.m_owner.m_allSkillsContent;
				}
				set
				{
					this.m_owner.m_allSkillsContent = value;
				}
			}

			// Token: 0x170022BF RID: 8895
			// (get) Token: 0x0600ABA8 RID: 43944 RVA: 0x002FD258 File Offset: 0x002FB458
			// (set) Token: 0x0600ABA9 RID: 43945 RVA: 0x002FD268 File Offset: 0x002FB468
			public GameObject m_selectSkillsContent
			{
				get
				{
					return this.m_owner.m_selectSkillsContent;
				}
				set
				{
					this.m_owner.m_selectSkillsContent = value;
				}
			}

			// Token: 0x170022C0 RID: 8896
			// (get) Token: 0x0600ABAA RID: 43946 RVA: 0x002FD278 File Offset: 0x002FB478
			// (set) Token: 0x0600ABAB RID: 43947 RVA: 0x002FD288 File Offset: 0x002FB488
			public GameObject m_selectSkillsCost
			{
				get
				{
					return this.m_owner.m_selectSkillsCost;
				}
				set
				{
					this.m_owner.m_selectSkillsCost = value;
				}
			}

			// Token: 0x170022C1 RID: 8897
			// (get) Token: 0x0600ABAC RID: 43948 RVA: 0x002FD298 File Offset: 0x002FB498
			// (set) Token: 0x0600ABAD RID: 43949 RVA: 0x002FD2A8 File Offset: 0x002FB4A8
			public Button m_closeSelectSkillButton
			{
				get
				{
					return this.m_owner.m_closeSelectSkillButton;
				}
				set
				{
					this.m_owner.m_closeSelectSkillButton = value;
				}
			}

			// Token: 0x170022C2 RID: 8898
			// (get) Token: 0x0600ABAE RID: 43950 RVA: 0x002FD2B8 File Offset: 0x002FB4B8
			// (set) Token: 0x0600ABAF RID: 43951 RVA: 0x002FD2C8 File Offset: 0x002FB4C8
			public Button m_selectSkillConfirmButton
			{
				get
				{
					return this.m_owner.m_selectSkillConfirmButton;
				}
				set
				{
					this.m_owner.m_selectSkillConfirmButton = value;
				}
			}

			// Token: 0x170022C3 RID: 8899
			// (get) Token: 0x0600ABB0 RID: 43952 RVA: 0x002FD2D8 File Offset: 0x002FB4D8
			// (set) Token: 0x0600ABB1 RID: 43953 RVA: 0x002FD2E8 File Offset: 0x002FB4E8
			public GameObject m_skillDetailObj
			{
				get
				{
					return this.m_owner.m_skillDetailObj;
				}
				set
				{
					this.m_owner.m_skillDetailObj = value;
				}
			}

			// Token: 0x170022C4 RID: 8900
			// (get) Token: 0x0600ABB2 RID: 43954 RVA: 0x002FD2F8 File Offset: 0x002FB4F8
			// (set) Token: 0x0600ABB3 RID: 43955 RVA: 0x002FD308 File Offset: 0x002FB508
			public GameObject m_skillDetailListObj
			{
				get
				{
					return this.m_owner.m_skillDetailListObj;
				}
				set
				{
					this.m_owner.m_skillDetailListObj = value;
				}
			}

			// Token: 0x170022C5 RID: 8901
			// (get) Token: 0x0600ABB4 RID: 43956 RVA: 0x002FD318 File Offset: 0x002FB518
			// (set) Token: 0x0600ABB5 RID: 43957 RVA: 0x002FD328 File Offset: 0x002FB528
			public GameObject m_skillListContentTalentObj
			{
				get
				{
					return this.m_owner.m_skillListContentTalentObj;
				}
				set
				{
					this.m_owner.m_skillListContentTalentObj = value;
				}
			}

			// Token: 0x170022C6 RID: 8902
			// (get) Token: 0x0600ABB6 RID: 43958 RVA: 0x002FD338 File Offset: 0x002FB538
			// (set) Token: 0x0600ABB7 RID: 43959 RVA: 0x002FD348 File Offset: 0x002FB548
			public Image m_skillListContentTalentIcon
			{
				get
				{
					return this.m_owner.m_skillListContentTalentIcon;
				}
				set
				{
					this.m_owner.m_skillListContentTalentIcon = value;
				}
			}

			// Token: 0x170022C7 RID: 8903
			// (get) Token: 0x0600ABB8 RID: 43960 RVA: 0x002FD358 File Offset: 0x002FB558
			// (set) Token: 0x0600ABB9 RID: 43961 RVA: 0x002FD368 File Offset: 0x002FB568
			public Text m_skillListContentTalentNameText
			{
				get
				{
					return this.m_owner.m_skillListContentTalentNameText;
				}
				set
				{
					this.m_owner.m_skillListContentTalentNameText = value;
				}
			}

			// Token: 0x170022C8 RID: 8904
			// (get) Token: 0x0600ABBA RID: 43962 RVA: 0x002FD378 File Offset: 0x002FB578
			// (set) Token: 0x0600ABBB RID: 43963 RVA: 0x002FD388 File Offset: 0x002FB588
			public Text m_skillListContentTalentDescText
			{
				get
				{
					return this.m_owner.m_skillListContentTalentDescText;
				}
				set
				{
					this.m_owner.m_skillListContentTalentDescText = value;
				}
			}

			// Token: 0x170022C9 RID: 8905
			// (get) Token: 0x0600ABBC RID: 43964 RVA: 0x002FD398 File Offset: 0x002FB598
			// (set) Token: 0x0600ABBD RID: 43965 RVA: 0x002FD3A8 File Offset: 0x002FB5A8
			public Image m_skillListContentLineImage
			{
				get
				{
					return this.m_owner.m_skillListContentLineImage;
				}
				set
				{
					this.m_owner.m_skillListContentLineImage = value;
				}
			}

			// Token: 0x170022CA RID: 8906
			// (get) Token: 0x0600ABBE RID: 43966 RVA: 0x002FD3B8 File Offset: 0x002FB5B8
			// (set) Token: 0x0600ABBF RID: 43967 RVA: 0x002FD3C8 File Offset: 0x002FB5C8
			public GameObject m_skillListContentListObj
			{
				get
				{
					return this.m_owner.m_skillListContentListObj;
				}
				set
				{
					this.m_owner.m_skillListContentListObj = value;
				}
			}

			// Token: 0x170022CB RID: 8907
			// (get) Token: 0x0600ABC0 RID: 43968 RVA: 0x002FD3D8 File Offset: 0x002FB5D8
			// (set) Token: 0x0600ABC1 RID: 43969 RVA: 0x002FD3E8 File Offset: 0x002FB5E8
			public GameObject m_skillListContentObj
			{
				get
				{
					return this.m_owner.m_skillListContentObj;
				}
				set
				{
					this.m_owner.m_skillListContentObj = value;
				}
			}

			// Token: 0x170022CC RID: 8908
			// (get) Token: 0x0600ABC2 RID: 43970 RVA: 0x002FD3F8 File Offset: 0x002FB5F8
			// (set) Token: 0x0600ABC3 RID: 43971 RVA: 0x002FD408 File Offset: 0x002FB608
			public GameObject m_skillListNoSkillsObj
			{
				get
				{
					return this.m_owner.m_skillListNoSkillsObj;
				}
				set
				{
					this.m_owner.m_skillListNoSkillsObj = value;
				}
			}

			// Token: 0x170022CD RID: 8909
			// (get) Token: 0x0600ABC4 RID: 43972 RVA: 0x002FD418 File Offset: 0x002FB618
			// (set) Token: 0x0600ABC5 RID: 43973 RVA: 0x002FD428 File Offset: 0x002FB628
			public GameObject m_skillDescPrefabObj
			{
				get
				{
					return this.m_owner.m_skillDescPrefabObj;
				}
				set
				{
					this.m_owner.m_skillDescPrefabObj = value;
				}
			}

			// Token: 0x170022CE RID: 8910
			// (get) Token: 0x0600ABC6 RID: 43974 RVA: 0x002FD438 File Offset: 0x002FB638
			// (set) Token: 0x0600ABC7 RID: 43975 RVA: 0x002FD448 File Offset: 0x002FB648
			public GameObject m_skillItemDetailPanel
			{
				get
				{
					return this.m_owner.m_skillItemDetailPanel;
				}
				set
				{
					this.m_owner.m_skillItemDetailPanel = value;
				}
			}

			// Token: 0x170022CF RID: 8911
			// (get) Token: 0x0600ABC8 RID: 43976 RVA: 0x002FD458 File Offset: 0x002FB658
			// (set) Token: 0x0600ABC9 RID: 43977 RVA: 0x002FD468 File Offset: 0x002FB668
			public GameObject m_soldierGo
			{
				get
				{
					return this.m_owner.m_soldierGo;
				}
				set
				{
					this.m_owner.m_soldierGo = value;
				}
			}

			// Token: 0x170022D0 RID: 8912
			// (get) Token: 0x0600ABCA RID: 43978 RVA: 0x002FD478 File Offset: 0x002FB678
			// (set) Token: 0x0600ABCB RID: 43979 RVA: 0x002FD488 File Offset: 0x002FB688
			public Button m_soldierChangeButton
			{
				get
				{
					return this.m_owner.m_soldierChangeButton;
				}
				set
				{
					this.m_owner.m_soldierChangeButton = value;
				}
			}

			// Token: 0x170022D1 RID: 8913
			// (get) Token: 0x0600ABCC RID: 43980 RVA: 0x002FD498 File Offset: 0x002FB698
			// (set) Token: 0x0600ABCD RID: 43981 RVA: 0x002FD4A8 File Offset: 0x002FB6A8
			public Button m_closeSelectSoldierButton
			{
				get
				{
					return this.m_owner.m_closeSelectSoldierButton;
				}
				set
				{
					this.m_owner.m_closeSelectSoldierButton = value;
				}
			}

			// Token: 0x170022D2 RID: 8914
			// (get) Token: 0x0600ABCE RID: 43982 RVA: 0x002FD4B8 File Offset: 0x002FB6B8
			// (set) Token: 0x0600ABCF RID: 43983 RVA: 0x002FD4C8 File Offset: 0x002FB6C8
			public CommonUIStateController m_selectSoldierPanelUIStateController
			{
				get
				{
					return this.m_owner.m_selectSoldierPanelUIStateController;
				}
				set
				{
					this.m_owner.m_selectSoldierPanelUIStateController = value;
				}
			}

			// Token: 0x170022D3 RID: 8915
			// (get) Token: 0x0600ABD0 RID: 43984 RVA: 0x002FD4D8 File Offset: 0x002FB6D8
			// (set) Token: 0x0600ABD1 RID: 43985 RVA: 0x002FD4E8 File Offset: 0x002FB6E8
			public GameObject m_soldiersContent
			{
				get
				{
					return this.m_owner.m_soldiersContent;
				}
				set
				{
					this.m_owner.m_soldiersContent = value;
				}
			}

			// Token: 0x170022D4 RID: 8916
			// (get) Token: 0x0600ABD2 RID: 43986 RVA: 0x002FD4F8 File Offset: 0x002FB6F8
			// (set) Token: 0x0600ABD3 RID: 43987 RVA: 0x002FD508 File Offset: 0x002FB708
			public GameObject m_selectSoldierDetailPanel
			{
				get
				{
					return this.m_owner.m_selectSoldierDetailPanel;
				}
				set
				{
					this.m_owner.m_selectSoldierDetailPanel = value;
				}
			}

			// Token: 0x170022D5 RID: 8917
			// (get) Token: 0x0600ABD4 RID: 43988 RVA: 0x002FD518 File Offset: 0x002FB718
			// (set) Token: 0x0600ABD5 RID: 43989 RVA: 0x002FD528 File Offset: 0x002FB728
			public GameObject m_soldierGraphicGo
			{
				get
				{
					return this.m_owner.m_soldierGraphicGo;
				}
				set
				{
					this.m_owner.m_soldierGraphicGo = value;
				}
			}

			// Token: 0x170022D6 RID: 8918
			// (get) Token: 0x0600ABD6 RID: 43990 RVA: 0x002FD538 File Offset: 0x002FB738
			// (set) Token: 0x0600ABD7 RID: 43991 RVA: 0x002FD548 File Offset: 0x002FB748
			public Image m_soldierArmyTypeImg
			{
				get
				{
					return this.m_owner.m_soldierArmyTypeImg;
				}
				set
				{
					this.m_owner.m_soldierArmyTypeImg = value;
				}
			}

			// Token: 0x170022D7 RID: 8919
			// (get) Token: 0x0600ABD8 RID: 43992 RVA: 0x002FD558 File Offset: 0x002FB758
			// (set) Token: 0x0600ABD9 RID: 43993 RVA: 0x002FD568 File Offset: 0x002FB768
			public Text m_soldierNameText
			{
				get
				{
					return this.m_owner.m_soldierNameText;
				}
				set
				{
					this.m_owner.m_soldierNameText = value;
				}
			}

			// Token: 0x170022D8 RID: 8920
			// (get) Token: 0x0600ABDA RID: 43994 RVA: 0x002FD578 File Offset: 0x002FB778
			// (set) Token: 0x0600ABDB RID: 43995 RVA: 0x002FD588 File Offset: 0x002FB788
			public Button m_soldierInfoBtn
			{
				get
				{
					return this.m_owner.m_soldierInfoBtn;
				}
				set
				{
					this.m_owner.m_soldierInfoBtn = value;
				}
			}

			// Token: 0x170022D9 RID: 8921
			// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x002FD598 File Offset: 0x002FB798
			// (set) Token: 0x0600ABDD RID: 43997 RVA: 0x002FD5A8 File Offset: 0x002FB7A8
			public Text m_soldierPropHPText
			{
				get
				{
					return this.m_owner.m_soldierPropHPText;
				}
				set
				{
					this.m_owner.m_soldierPropHPText = value;
				}
			}

			// Token: 0x170022DA RID: 8922
			// (get) Token: 0x0600ABDE RID: 43998 RVA: 0x002FD5B8 File Offset: 0x002FB7B8
			// (set) Token: 0x0600ABDF RID: 43999 RVA: 0x002FD5C8 File Offset: 0x002FB7C8
			public Image m_soldierPropHPImage
			{
				get
				{
					return this.m_owner.m_soldierPropHPImage;
				}
				set
				{
					this.m_owner.m_soldierPropHPImage = value;
				}
			}

			// Token: 0x170022DB RID: 8923
			// (get) Token: 0x0600ABE0 RID: 44000 RVA: 0x002FD5D8 File Offset: 0x002FB7D8
			// (set) Token: 0x0600ABE1 RID: 44001 RVA: 0x002FD5E8 File Offset: 0x002FB7E8
			public Text m_soldierPropDFText
			{
				get
				{
					return this.m_owner.m_soldierPropDFText;
				}
				set
				{
					this.m_owner.m_soldierPropDFText = value;
				}
			}

			// Token: 0x170022DC RID: 8924
			// (get) Token: 0x0600ABE2 RID: 44002 RVA: 0x002FD5F8 File Offset: 0x002FB7F8
			// (set) Token: 0x0600ABE3 RID: 44003 RVA: 0x002FD608 File Offset: 0x002FB808
			public Text m_soldierPropATText
			{
				get
				{
					return this.m_owner.m_soldierPropATText;
				}
				set
				{
					this.m_owner.m_soldierPropATText = value;
				}
			}

			// Token: 0x170022DD RID: 8925
			// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x002FD618 File Offset: 0x002FB818
			// (set) Token: 0x0600ABE5 RID: 44005 RVA: 0x002FD628 File Offset: 0x002FB828
			public Text m_soldierMagicDFText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFText = value;
				}
			}

			// Token: 0x170022DE RID: 8926
			// (get) Token: 0x0600ABE6 RID: 44006 RVA: 0x002FD638 File Offset: 0x002FB838
			// (set) Token: 0x0600ABE7 RID: 44007 RVA: 0x002FD648 File Offset: 0x002FB848
			public Text m_soldierDFAddText
			{
				get
				{
					return this.m_owner.m_soldierDFAddText;
				}
				set
				{
					this.m_owner.m_soldierDFAddText = value;
				}
			}

			// Token: 0x170022DF RID: 8927
			// (get) Token: 0x0600ABE8 RID: 44008 RVA: 0x002FD658 File Offset: 0x002FB858
			// (set) Token: 0x0600ABE9 RID: 44009 RVA: 0x002FD668 File Offset: 0x002FB868
			public Text m_soldierATAddText
			{
				get
				{
					return this.m_owner.m_soldierATAddText;
				}
				set
				{
					this.m_owner.m_soldierATAddText = value;
				}
			}

			// Token: 0x170022E0 RID: 8928
			// (get) Token: 0x0600ABEA RID: 44010 RVA: 0x002FD678 File Offset: 0x002FB878
			// (set) Token: 0x0600ABEB RID: 44011 RVA: 0x002FD688 File Offset: 0x002FB888
			public Text m_soldierMagicDFAddText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFAddText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFAddText = value;
				}
			}

			// Token: 0x170022E1 RID: 8929
			// (get) Token: 0x0600ABEC RID: 44012 RVA: 0x002FD698 File Offset: 0x002FB898
			// (set) Token: 0x0600ABED RID: 44013 RVA: 0x002FD6A8 File Offset: 0x002FB8A8
			public CommonUIStateController m_soldierDetailPanelUIStateController
			{
				get
				{
					return this.m_owner.m_soldierDetailPanelUIStateController;
				}
				set
				{
					this.m_owner.m_soldierDetailPanelUIStateController = value;
				}
			}

			// Token: 0x170022E2 RID: 8930
			// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x002FD6B8 File Offset: 0x002FB8B8
			// (set) Token: 0x0600ABEF RID: 44015 RVA: 0x002FD6C8 File Offset: 0x002FB8C8
			public Image m_soldierDetailIconImg
			{
				get
				{
					return this.m_owner.m_soldierDetailIconImg;
				}
				set
				{
					this.m_owner.m_soldierDetailIconImg = value;
				}
			}

			// Token: 0x170022E3 RID: 8931
			// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x002FD6D8 File Offset: 0x002FB8D8
			// (set) Token: 0x0600ABF1 RID: 44017 RVA: 0x002FD6E8 File Offset: 0x002FB8E8
			public GameObject m_soldierDetailGraphicGo
			{
				get
				{
					return this.m_owner.m_soldierDetailGraphicGo;
				}
				set
				{
					this.m_owner.m_soldierDetailGraphicGo = value;
				}
			}

			// Token: 0x170022E4 RID: 8932
			// (get) Token: 0x0600ABF2 RID: 44018 RVA: 0x002FD6F8 File Offset: 0x002FB8F8
			// (set) Token: 0x0600ABF3 RID: 44019 RVA: 0x002FD708 File Offset: 0x002FB908
			public Text m_soldierDetailRangeText
			{
				get
				{
					return this.m_owner.m_soldierDetailRangeText;
				}
				set
				{
					this.m_owner.m_soldierDetailRangeText = value;
				}
			}

			// Token: 0x170022E5 RID: 8933
			// (get) Token: 0x0600ABF4 RID: 44020 RVA: 0x002FD718 File Offset: 0x002FB918
			// (set) Token: 0x0600ABF5 RID: 44021 RVA: 0x002FD728 File Offset: 0x002FB928
			public Text m_soldierDetailMoveText
			{
				get
				{
					return this.m_owner.m_soldierDetailMoveText;
				}
				set
				{
					this.m_owner.m_soldierDetailMoveText = value;
				}
			}

			// Token: 0x170022E6 RID: 8934
			// (get) Token: 0x0600ABF6 RID: 44022 RVA: 0x002FD738 File Offset: 0x002FB938
			// (set) Token: 0x0600ABF7 RID: 44023 RVA: 0x002FD748 File Offset: 0x002FB948
			public Image m_soldierDetailTypeBgImg
			{
				get
				{
					return this.m_owner.m_soldierDetailTypeBgImg;
				}
				set
				{
					this.m_owner.m_soldierDetailTypeBgImg = value;
				}
			}

			// Token: 0x170022E7 RID: 8935
			// (get) Token: 0x0600ABF8 RID: 44024 RVA: 0x002FD758 File Offset: 0x002FB958
			// (set) Token: 0x0600ABF9 RID: 44025 RVA: 0x002FD768 File Offset: 0x002FB968
			public Image m_soldierDetailTypeBgImg2
			{
				get
				{
					return this.m_owner.m_soldierDetailTypeBgImg2;
				}
				set
				{
					this.m_owner.m_soldierDetailTypeBgImg2 = value;
				}
			}

			// Token: 0x170022E8 RID: 8936
			// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x002FD778 File Offset: 0x002FB978
			// (set) Token: 0x0600ABFB RID: 44027 RVA: 0x002FD788 File Offset: 0x002FB988
			public Text m_soldierDetailTitleText
			{
				get
				{
					return this.m_owner.m_soldierDetailTitleText;
				}
				set
				{
					this.m_owner.m_soldierDetailTitleText = value;
				}
			}

			// Token: 0x170022E9 RID: 8937
			// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x002FD798 File Offset: 0x002FB998
			// (set) Token: 0x0600ABFD RID: 44029 RVA: 0x002FD7A8 File Offset: 0x002FB9A8
			public Text m_soldierDetailDescText
			{
				get
				{
					return this.m_owner.m_soldierDetailDescText;
				}
				set
				{
					this.m_owner.m_soldierDetailDescText = value;
				}
			}

			// Token: 0x170022EA RID: 8938
			// (get) Token: 0x0600ABFE RID: 44030 RVA: 0x002FD7B8 File Offset: 0x002FB9B8
			// (set) Token: 0x0600ABFF RID: 44031 RVA: 0x002FD7C8 File Offset: 0x002FB9C8
			public Text m_soldierDetailWeakText
			{
				get
				{
					return this.m_owner.m_soldierDetailWeakText;
				}
				set
				{
					this.m_owner.m_soldierDetailWeakText = value;
				}
			}

			// Token: 0x170022EB RID: 8939
			// (get) Token: 0x0600AC00 RID: 44032 RVA: 0x002FD7D8 File Offset: 0x002FB9D8
			// (set) Token: 0x0600AC01 RID: 44033 RVA: 0x002FD7E8 File Offset: 0x002FB9E8
			public Text m_soldierDetailStrongText
			{
				get
				{
					return this.m_owner.m_soldierDetailStrongText;
				}
				set
				{
					this.m_owner.m_soldierDetailStrongText = value;
				}
			}

			// Token: 0x170022EC RID: 8940
			// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x002FD7F8 File Offset: 0x002FB9F8
			// (set) Token: 0x0600AC03 RID: 44035 RVA: 0x002FD808 File Offset: 0x002FBA08
			public Text m_soldierDetailHPText
			{
				get
				{
					return this.m_owner.m_soldierDetailHPText;
				}
				set
				{
					this.m_owner.m_soldierDetailHPText = value;
				}
			}

			// Token: 0x170022ED RID: 8941
			// (get) Token: 0x0600AC04 RID: 44036 RVA: 0x002FD818 File Offset: 0x002FBA18
			// (set) Token: 0x0600AC05 RID: 44037 RVA: 0x002FD828 File Offset: 0x002FBA28
			public Text m_soldierDetailDFText
			{
				get
				{
					return this.m_owner.m_soldierDetailDFText;
				}
				set
				{
					this.m_owner.m_soldierDetailDFText = value;
				}
			}

			// Token: 0x170022EE RID: 8942
			// (get) Token: 0x0600AC06 RID: 44038 RVA: 0x002FD838 File Offset: 0x002FBA38
			// (set) Token: 0x0600AC07 RID: 44039 RVA: 0x002FD848 File Offset: 0x002FBA48
			public Text m_soldierDetailATText
			{
				get
				{
					return this.m_owner.m_soldierDetailATText;
				}
				set
				{
					this.m_owner.m_soldierDetailATText = value;
				}
			}

			// Token: 0x170022EF RID: 8943
			// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x002FD858 File Offset: 0x002FBA58
			// (set) Token: 0x0600AC09 RID: 44041 RVA: 0x002FD868 File Offset: 0x002FBA68
			public Text m_soldierDetailMagicDFText
			{
				get
				{
					return this.m_owner.m_soldierDetailMagicDFText;
				}
				set
				{
					this.m_owner.m_soldierDetailMagicDFText = value;
				}
			}

			// Token: 0x170022F0 RID: 8944
			// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x002FD878 File Offset: 0x002FBA78
			// (set) Token: 0x0600AC0B RID: 44043 RVA: 0x002FD888 File Offset: 0x002FBA88
			public Text m_soldierDetailHPAddText
			{
				get
				{
					return this.m_owner.m_soldierDetailHPAddText;
				}
				set
				{
					this.m_owner.m_soldierDetailHPAddText = value;
				}
			}

			// Token: 0x170022F1 RID: 8945
			// (get) Token: 0x0600AC0C RID: 44044 RVA: 0x002FD898 File Offset: 0x002FBA98
			// (set) Token: 0x0600AC0D RID: 44045 RVA: 0x002FD8A8 File Offset: 0x002FBAA8
			public Text m_soldierDetailDFAddText
			{
				get
				{
					return this.m_owner.m_soldierDetailDFAddText;
				}
				set
				{
					this.m_owner.m_soldierDetailDFAddText = value;
				}
			}

			// Token: 0x170022F2 RID: 8946
			// (get) Token: 0x0600AC0E RID: 44046 RVA: 0x002FD8B8 File Offset: 0x002FBAB8
			// (set) Token: 0x0600AC0F RID: 44047 RVA: 0x002FD8C8 File Offset: 0x002FBAC8
			public Text m_soldierDetailATAddText
			{
				get
				{
					return this.m_owner.m_soldierDetailATAddText;
				}
				set
				{
					this.m_owner.m_soldierDetailATAddText = value;
				}
			}

			// Token: 0x170022F3 RID: 8947
			// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x002FD8D8 File Offset: 0x002FBAD8
			// (set) Token: 0x0600AC11 RID: 44049 RVA: 0x002FD8E8 File Offset: 0x002FBAE8
			public Text m_soldierDetailMagicDFAddText
			{
				get
				{
					return this.m_owner.m_soldierDetailMagicDFAddText;
				}
				set
				{
					this.m_owner.m_soldierDetailMagicDFAddText = value;
				}
			}

			// Token: 0x170022F4 RID: 8948
			// (get) Token: 0x0600AC12 RID: 44050 RVA: 0x002FD8F8 File Offset: 0x002FBAF8
			// (set) Token: 0x0600AC13 RID: 44051 RVA: 0x002FD908 File Offset: 0x002FBB08
			public BattleHero m_hero
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

			// Token: 0x170022F5 RID: 8949
			// (get) Token: 0x0600AC14 RID: 44052 RVA: 0x002FD918 File Offset: 0x002FBB18
			// (set) Token: 0x0600AC15 RID: 44053 RVA: 0x002FD928 File Offset: 0x002FBB28
			public List<TrainingTech> m_trainingTechs
			{
				get
				{
					return this.m_owner.m_trainingTechs;
				}
				set
				{
					this.m_owner.m_trainingTechs = value;
				}
			}

			// Token: 0x170022F6 RID: 8950
			// (get) Token: 0x0600AC16 RID: 44054 RVA: 0x002FD938 File Offset: 0x002FBB38
			// (set) Token: 0x0600AC17 RID: 44055 RVA: 0x002FD948 File Offset: 0x002FBB48
			public int m_team
			{
				get
				{
					return this.m_owner.m_team;
				}
				set
				{
					this.m_owner.m_team = value;
				}
			}

			// Token: 0x170022F7 RID: 8951
			// (get) Token: 0x0600AC18 RID: 44056 RVA: 0x002FD958 File Offset: 0x002FBB58
			// (set) Token: 0x0600AC19 RID: 44057 RVA: 0x002FD968 File Offset: 0x002FBB68
			public bool m_isNpc
			{
				get
				{
					return this.m_owner.m_isNpc;
				}
				set
				{
					this.m_owner.m_isNpc = value;
				}
			}

			// Token: 0x170022F8 RID: 8952
			// (get) Token: 0x0600AC1A RID: 44058 RVA: 0x002FD978 File Offset: 0x002FBB78
			// (set) Token: 0x0600AC1B RID: 44059 RVA: 0x002FD988 File Offset: 0x002FBB88
			public bool m_canChangeSoldier
			{
				get
				{
					return this.m_owner.m_canChangeSoldier;
				}
				set
				{
					this.m_owner.m_canChangeSoldier = value;
				}
			}

			// Token: 0x170022F9 RID: 8953
			// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x002FD998 File Offset: 0x002FBB98
			// (set) Token: 0x0600AC1D RID: 44061 RVA: 0x002FD9A8 File Offset: 0x002FBBA8
			public int m_heroHp
			{
				get
				{
					return this.m_owner.m_heroHp;
				}
				set
				{
					this.m_owner.m_heroHp = value;
				}
			}

			// Token: 0x170022FA RID: 8954
			// (get) Token: 0x0600AC1E RID: 44062 RVA: 0x002FD9B8 File Offset: 0x002FBBB8
			// (set) Token: 0x0600AC1F RID: 44063 RVA: 0x002FD9C8 File Offset: 0x002FBBC8
			public int m_soldierHp
			{
				get
				{
					return this.m_owner.m_soldierHp;
				}
				set
				{
					this.m_owner.m_soldierHp = value;
				}
			}

			// Token: 0x170022FB RID: 8955
			// (get) Token: 0x0600AC20 RID: 44064 RVA: 0x002FD9D8 File Offset: 0x002FBBD8
			// (set) Token: 0x0600AC21 RID: 44065 RVA: 0x002FD9E8 File Offset: 0x002FBBE8
			public ConfigDataSkillInfo m_extraTalentSkillInfo
			{
				get
				{
					return this.m_owner.m_extraTalentSkillInfo;
				}
				set
				{
					this.m_owner.m_extraTalentSkillInfo = value;
				}
			}

			// Token: 0x170022FC RID: 8956
			// (get) Token: 0x0600AC22 RID: 44066 RVA: 0x002FD9F8 File Offset: 0x002FBBF8
			// (set) Token: 0x0600AC23 RID: 44067 RVA: 0x002FDA08 File Offset: 0x002FBC08
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x170022FD RID: 8957
			// (get) Token: 0x0600AC24 RID: 44068 RVA: 0x002FDA18 File Offset: 0x002FBC18
			// (set) Token: 0x0600AC25 RID: 44069 RVA: 0x002FDA28 File Offset: 0x002FBC28
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

			// Token: 0x170022FE RID: 8958
			// (get) Token: 0x0600AC26 RID: 44070 RVA: 0x002FDA38 File Offset: 0x002FBC38
			// (set) Token: 0x0600AC27 RID: 44071 RVA: 0x002FDA48 File Offset: 0x002FBC48
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

			// Token: 0x170022FF RID: 8959
			// (get) Token: 0x0600AC28 RID: 44072 RVA: 0x002FDA58 File Offset: 0x002FBC58
			// (set) Token: 0x0600AC29 RID: 44073 RVA: 0x002FDA68 File Offset: 0x002FBC68
			public List<int> m_selectSkillIds
			{
				get
				{
					return this.m_owner.m_selectSkillIds;
				}
				set
				{
					this.m_owner.m_selectSkillIds = value;
				}
			}

			// Token: 0x17002300 RID: 8960
			// (get) Token: 0x0600AC2A RID: 44074 RVA: 0x002FDA78 File Offset: 0x002FBC78
			// (set) Token: 0x0600AC2B RID: 44075 RVA: 0x002FDA88 File Offset: 0x002FBC88
			public BattleSoldierItemUIController m_lastClickSoldierItem
			{
				get
				{
					return this.m_owner.m_lastClickSoldierItem;
				}
				set
				{
					this.m_owner.m_lastClickSoldierItem = value;
				}
			}

			// Token: 0x17002301 RID: 8961
			// (get) Token: 0x0600AC2C RID: 44076 RVA: 0x002FDA98 File Offset: 0x002FBC98
			// (set) Token: 0x0600AC2D RID: 44077 RVA: 0x002FDAA8 File Offset: 0x002FBCA8
			public int m_maxSkillCost
			{
				get
				{
					return this.m_owner.m_maxSkillCost;
				}
				set
				{
					this.m_owner.m_maxSkillCost = value;
				}
			}

			// Token: 0x17002302 RID: 8962
			// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x002FDAB8 File Offset: 0x002FBCB8
			// (set) Token: 0x0600AC2F RID: 44079 RVA: 0x002FDAC8 File Offset: 0x002FBCC8
			public UISpineGraphic m_soldierGraphic
			{
				get
				{
					return this.m_owner.m_soldierGraphic;
				}
				set
				{
					this.m_owner.m_soldierGraphic = value;
				}
			}

			// Token: 0x17002303 RID: 8963
			// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x002FDAD8 File Offset: 0x002FBCD8
			// (set) Token: 0x0600AC31 RID: 44081 RVA: 0x002FDAE8 File Offset: 0x002FBCE8
			public UISpineGraphic m_soldierDetailGraphic
			{
				get
				{
					return this.m_owner.m_soldierDetailGraphic;
				}
				set
				{
					this.m_owner.m_soldierDetailGraphic = value;
				}
			}

			// Token: 0x17002304 RID: 8964
			// (get) Token: 0x0600AC32 RID: 44082 RVA: 0x002FDAF8 File Offset: 0x002FBCF8
			// (set) Token: 0x0600AC33 RID: 44083 RVA: 0x002FDB08 File Offset: 0x002FBD08
			public GameObjectPool<SkillDesc> m_skillDescPool
			{
				get
				{
					return this.m_owner.m_skillDescPool;
				}
				set
				{
					this.m_owner.m_skillDescPool = value;
				}
			}

			// Token: 0x0600AC34 RID: 44084 RVA: 0x002FDB18 File Offset: 0x002FBD18
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600AC35 RID: 44085 RVA: 0x002FDB28 File Offset: 0x002FBD28
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600AC36 RID: 44086 RVA: 0x002FDB38 File Offset: 0x002FBD38
			public void SetSkillsAndTalentList()
			{
				this.m_owner.SetSkillsAndTalentList();
			}

			// Token: 0x0600AC37 RID: 44087 RVA: 0x002FDB48 File Offset: 0x002FBD48
			public void ShowSelectSkillPanel()
			{
				this.m_owner.ShowSelectSkillPanel();
			}

			// Token: 0x0600AC38 RID: 44088 RVA: 0x002FDB58 File Offset: 0x002FBD58
			public void CloseSelectSkillPanel()
			{
				this.m_owner.CloseSelectSkillPanel();
			}

			// Token: 0x0600AC39 RID: 44089 RVA: 0x002FDB68 File Offset: 0x002FBD68
			public void OnSkillItemClick(HeroSkillItemUIController skillCtrl)
			{
				this.m_owner.OnSkillItemClick(skillCtrl);
			}

			// Token: 0x0600AC3A RID: 44090 RVA: 0x002FDB78 File Offset: 0x002FBD78
			public void OnConfirmSelectSkillsButtonClick()
			{
				this.m_owner.OnConfirmSelectSkillsButtonClick();
			}

			// Token: 0x0600AC3B RID: 44091 RVA: 0x002FDB88 File Offset: 0x002FBD88
			public int GetCostFromSkillList(List<int> skillIds)
			{
				return this.m_owner.GetCostFromSkillList(skillIds);
			}

			// Token: 0x0600AC3C RID: 44092 RVA: 0x002FDB98 File Offset: 0x002FBD98
			public void SetSoldierDetailPanel()
			{
				this.m_owner.SetSoldierDetailPanel();
			}

			// Token: 0x0600AC3D RID: 44093 RVA: 0x002FDBA8 File Offset: 0x002FBDA8
			public void CloseSelectSoldierPanel()
			{
				this.m_owner.CloseSelectSoldierPanel();
			}

			// Token: 0x0600AC3E RID: 44094 RVA: 0x002FDBB8 File Offset: 0x002FBDB8
			public void OnSoldierDetailSelectButtonClick(BattleSoldierItemUIController ctrl)
			{
				this.m_owner.OnSoldierDetailSelectButtonClick(ctrl);
			}

			// Token: 0x0600AC3F RID: 44095 RVA: 0x002FDBC8 File Offset: 0x002FBDC8
			public void OnSoldierItemClick(BattleSoldierItemUIController ctrl)
			{
				this.m_owner.OnSoldierItemClick(ctrl);
			}

			// Token: 0x0600AC40 RID: 44096 RVA: 0x002FDBD8 File Offset: 0x002FBDD8
			public string CalcPropAddValue(int v0, int v1)
			{
				return this.m_owner.CalcPropAddValue(v0, v1);
			}

			// Token: 0x0600AC41 RID: 44097 RVA: 0x002FDBE8 File Offset: 0x002FBDE8
			public void SetPropLevelItemImg(Image img, char level)
			{
				this.m_owner.SetPropLevelItemImg(img, level);
			}

			// Token: 0x0600AC42 RID: 44098 RVA: 0x002FDBF8 File Offset: 0x002FBDF8
			public UISpineGraphic CreateSpineGraphic(string assetName, float scale, Vector2 offset, GameObject parent, List<ReplaceAnim> replaceAnims)
			{
				return this.m_owner.CreateSpineGraphic(assetName, scale, offset, parent, replaceAnims);
			}

			// Token: 0x0600AC43 RID: 44099 RVA: 0x002FDC0C File Offset: 0x002FBE0C
			public void DestroySpineGraphic(UISpineGraphic g)
			{
				this.m_owner.DestroySpineGraphic(g);
			}

			// Token: 0x0600AC44 RID: 44100 RVA: 0x002FDC1C File Offset: 0x002FBE1C
			public void OnChangeSkillButtonClick()
			{
				this.m_owner.OnChangeSkillButtonClick();
			}

			// Token: 0x0600AC45 RID: 44101 RVA: 0x002FDC2C File Offset: 0x002FBE2C
			public void OnChangeSoldierButtonClick()
			{
				this.m_owner.OnChangeSoldierButtonClick();
			}

			// Token: 0x040070C8 RID: 28872
			private BattlePrepareActorInfoUIController m_owner;
		}
	}
}
