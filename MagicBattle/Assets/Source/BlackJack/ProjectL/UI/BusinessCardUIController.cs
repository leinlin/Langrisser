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
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B23 RID: 2851
	[HotFix]
	public class BusinessCardUIController : UIControllerBase
	{
		// Token: 0x0600C02F RID: 49199 RVA: 0x0035862C File Offset: 0x0035682C
		private BusinessCardUIController()
		{
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x003586AC File Offset: 0x003568AC
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
			this.m_likeButton.onClick.AddListener(new UnityAction(this.OnLikeButtonClick));
			this.m_randomShowToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRandowShowToggleValueChanged));
			this.m_playerInputField.onEndEdit.AddListener(delegate(string A_1)
			{
				this.OnPlayerSignEditEnd(this.m_playerInputField);
			});
			this.m_changeSignButton.onClick.AddListener(new UnityAction(this.OnChangeSignButtonClick));
			this.m_charActiveDropdown.onValueChanged.AddListener(new UnityAction<int>(this.OnCharAnimationValueChanged));
			this.m_charFaceDropdown.onValueChanged.AddListener(new UnityAction<int>(this.OnCharDiretionValueChanged));
			this.m_talentButton.onClick.AddListener(new UnityAction(this.OnTalentItemClick));
			this.m_equipItemDescBGButton.onClick.AddListener(new UnityAction(this.OnEquipmentItemBGButtonClick));
			this.m_setPanelBGButton.onClick.AddListener(new UnityAction(this.OnSetPanelBGButtonClick));
			this.m_heroInfoPanelSettingButton.onClick.AddListener(new UnityAction(this.OnHeroInfoPanelSettingButtonClick));
			this.m_heroInfoPanelChangeButton.onClick.AddListener(new UnityAction(this.OnHeroInfoPanelChangeButtonClick));
			this.m_setCharInfoPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnSetCharPanelConfirmButtonClick));
			this.m_heroSelectPanelConfirmButton.onClick.AddListener(new UnityAction(this.OnHeroSelectPanelConfirmButtonClick));
			this.m_arButton.onClick.AddListener(new UnityAction(this.OnArButtonClick));
			bool active = this.CheckARState();
			this.m_arButton.gameObject.SetActive(active);
		}

		// Token: 0x0600C031 RID: 49201 RVA: 0x003588D0 File Offset: 0x00356AD0
		public void ShowOpenState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOpenState_hotfix != null)
			{
				this.m_ShowOpenState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_commonUIStateController.SetToUIState("Show", false, true);
		}

		// Token: 0x0600C032 RID: 49202 RVA: 0x00358944 File Offset: 0x00356B44
		public void SetPlayerInfo(BusinessCard businessCard, bool isMe, bool canSendLike, bool isRandomShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerInfoBusinessCardBooleanBooleanBoolean_hotfix != null)
			{
				this.m_SetPlayerInfoBusinessCardBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					businessCard,
					isMe,
					canSendLike,
					isRandomShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changeSignButton.gameObject.SetActive(isMe);
			this.m_randomShowToggle.gameObject.SetActive(isMe);
			this.m_randomShowToggle.isOn = isRandomShow;
			this.m_businessCard = businessCard;
			this.m_isMe = isMe;
			this.m_currentHeroSetList.Clear();
			this.m_currentHeroSetList.AddRange(businessCard.SetInfo.Heroes);
			this.m_likeUIStateController.SetToUIState((!canSendLike) ? "Normal" : "Grey", false, true);
			this.m_playerHeadIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(businessCard.HeadIcon)));
			this.m_playerNameText.text = businessCard.Name;
			this.m_playerLevelText.text = businessCard.Level.ToString();
			this.m_playerPointText.text = businessCard.ArenaPoints.ToString();
			this.m_playerLikesCountText.text = businessCard.Likes.ToString();
			this.m_playerSignText.text = businessCard.SetInfo.Desc;
			GameObjectUtility.DestroyChildren(this.m_heroGroupObj);
			using (List<BattleHero>.Enumerator enumerator = businessCard.MostSkilledHeroes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BattleHero v = enumerator.Current;
					BusinessCardUIController $this = this;
					if (v != null)
					{
						GameObject go = GameObjectUtility.CloneGameObject(this.m_heroGroupItemPrefab, this.m_heroGroupObj.transform);
						BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = GameObjectUtility.AddControllerToGameObject<BusinessCardOftenUsedHeroItemController>(go);
						businessCardOftenUsedHeroItemController.UpdateItemInfo(UIUtility.GetPlayerSmallHeadIconImageName(v.HeroId), v.HeroId);
						businessCardOftenUsedHeroItemController.EventOnClick += delegate(int heroId)
						{
							$this.SetHeroInfoPanel(v, false);
							$this.m_heroInfoPanelUIStateController.gameObject.SetActive(true);
							UIUtility.SetUIStateOpen($this.m_setPanelUIStateController, "Show", null, false, true);
						};
					}
				}
			}
			this.m_playerAllHeroPowerText.text = businessCard.StatisticalData.HeroTotalPower.ToString();
			this.m_playerReachedAchievementText.text = businessCard.StatisticalData.AchievementMissionNums.ToString();
			this.m_playerMasterJobCountText.text = businessCard.StatisticalData.MasterJobNums.ToString();
			this.m_stageGoalText.text = string.Empty;
			this.m_riftGoalText.text = businessCard.StatisticalData.RiftAchievementNums.ToString();
			this.SetTeam(businessCard, isRandomShow);
			if (this.CheckARState() && isMe)
			{
				this.m_arButton.gameObject.SetActive(true);
			}
			else
			{
				this.m_arButton.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x00358CC4 File Offset: 0x00356EC4
		private bool CheckARState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckARState_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckARState_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x00358D34 File Offset: 0x00356F34
		private void SetTeam(BusinessCard businessCard, bool isRandomShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamBusinessCardBoolean_hotfix != null)
			{
				this.m_SetTeamBusinessCardBoolean_hotfix.call(new object[]
				{
					this,
					businessCard,
					isRandomShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearTeam();
			int i;
			for (i = 0; i < 5; i++)
			{
				Transform transform = this.m_teamGraphicsParentGameObject.transform.Find(i.ToString());
				if (transform == null)
				{
					break;
				}
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroCharItemPrefab);
				gameObject.transform.SetParent(transform, false);
				BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = GameObjectUtility.AddControllerToGameObject<BusinessCardHeroCharItemUIController>(gameObject);
				businessCardHeroCharItemUIController.EventOnClick += this.OnHeroCharClick;
				BusinessCardHeroSet heroSet = businessCard.SetInfo.Heroes.Find((BusinessCardHeroSet hs) => hs.PositionIndex == i);
				if (heroSet != null)
				{
					BattleHero battleHero = businessCard.Heroes.Find((BattleHero h) => h.HeroId == heroSet.HeroId);
					if (battleHero != null)
					{
						ConfigDataJobConnectionInfo jobConnectionInfo = battleHero.GetActiveJob().JobConnectionInfo;
						if (jobConnectionInfo != null)
						{
							ConfigDataModelSkinResourceInfo heroActiveJobModelSkinResourceInfo = battleHero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader);
							UISpineGraphic uispineGraphic = this.CreateSpineGraphic(jobConnectionInfo, heroActiveJobModelSkinResourceInfo, false, heroSet.Direction, heroSet.Action);
							if (uispineGraphic != null)
							{
								uispineGraphic.SetParent(gameObject);
								this.m_graphicList.Add(new BusinessCardUIController.GraphicInfo(uispineGraphic, heroSet.Direction, heroSet.Action));
								if (isRandomShow)
								{
									this.SetCharAction(uispineGraphic, (HeroDirectionType)UnityEngine.Random.Range(0, 2), (HeroActionType)UnityEngine.Random.Range(0, 8));
								}
							}
						}
						businessCardHeroCharItemUIController.SetHeroCharItem(battleHero, i);
					}
				}
				else
				{
					businessCardHeroCharItemUIController.SetNoHeroChar(i, this.m_isMe);
				}
			}
		}

		// Token: 0x0600C035 RID: 49205 RVA: 0x00358F68 File Offset: 0x00357168
		private void OnHeroCharClick(BusinessCardHeroCharItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroCharClickBusinessCardHeroCharItemUIController_hotfix != null)
			{
				this.m_OnHeroCharClickBusinessCardHeroCharItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentSelectPositionIndex = ctrl.GetPositionIndex();
			if (this.m_isMe)
			{
				if (ctrl.IsEmpty())
				{
					this.SetHeroSelectPanel(this.m_businessCard);
					this.m_setCharInfoPanelUIStateController.gameObject.SetActive(false);
					this.m_heroInfoPanelUIStateController.gameObject.SetActive(false);
					this.m_heroSelectPanelUIStateController.gameObject.SetActive(true);
					UIUtility.SetUIStateOpen(this.m_setPanelUIStateController, "NoHeroInfoShow", null, false, true);
				}
				else
				{
					this.SetHeroInfoPanel(ctrl.GetBattleHero(), this.m_isMe);
					this.m_setCharInfoPanelUIStateController.gameObject.SetActive(false);
					this.m_heroSelectPanelUIStateController.gameObject.SetActive(false);
					this.m_heroInfoPanelUIStateController.gameObject.SetActive(true);
					UIUtility.SetUIStateOpen(this.m_setPanelUIStateController, "Show", null, false, true);
				}
			}
			else
			{
				this.SetHeroInfoPanel(ctrl.GetBattleHero(), this.m_isMe);
				this.m_setCharInfoPanelUIStateController.gameObject.SetActive(false);
				this.m_heroSelectPanelUIStateController.gameObject.SetActive(false);
				this.m_heroInfoPanelUIStateController.gameObject.SetActive(true);
				UIUtility.SetUIStateOpen(this.m_setPanelUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x0600C036 RID: 49206 RVA: 0x00359108 File Offset: 0x00357308
		private void ClearTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearTeam_hotfix != null)
			{
				this.m_ClearTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_graphicList.Clear();
			GameObjectUtility.DestroyChildren(this.m_char0Dummy);
			GameObjectUtility.DestroyChildren(this.m_char1Dummy);
			GameObjectUtility.DestroyChildren(this.m_char2Dummy);
			GameObjectUtility.DestroyChildren(this.m_char3Dummy);
			GameObjectUtility.DestroyChildren(this.m_char4Dummy);
		}

		// Token: 0x0600C037 RID: 49207 RVA: 0x003591AC File Offset: 0x003573AC
		public void SetRandomShowToggleOff()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRandomShowToggleOff_hotfix != null)
			{
				this.m_SetRandomShowToggleOff_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_randomShowToggle.isOn = false;
		}

		// Token: 0x0600C038 RID: 49208 RVA: 0x00359218 File Offset: 0x00357418
		private void SetHeroInfoPanel(BattleHero hero, bool canSetAndChange)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroInfoPanelBattleHeroBoolean_hotfix != null)
			{
				this.m_SetHeroInfoPanelBattleHeroBoolean_hotfix.call(new object[]
				{
					this,
					hero,
					canSetAndChange
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			ConfigDataJobConnectionInfo jobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
			if (jobConnectionInfo != null)
			{
				this.m_currentSelectBattleHero = hero;
				this.m_heroInfoPanelSettingButton.gameObject.SetActive(canSetAndChange);
				this.m_heroInfoPanelChangeButton.gameObject.SetActive(canSetAndChange);
				ConfigDataArmyInfo armyInfo = jobConnectionInfo.m_jobInfo.m_armyInfo;
				this.m_heroInfoArmyImage.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon_NoBack);
				this.m_heroInfoLevelText.text = hero.Level.ToString();
				this.m_heroInfoJobText.text = jobConnectionInfo.m_jobInfo.Name;
				this.m_heroInfoNameText.text = hero.HeroInfo.Name;
				this.m_heroInfoPowerText.text = hero.Power.ToString();
				GameObjectUtility.DestroyChildren(this.m_heroInfoGraphicDummy);
				ConfigDataModelSkinResourceInfo heroActiveJobModelSkinResourceInfo = hero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader);
				UISpineGraphic uispineGraphic = this.CreateSpineGraphic(jobConnectionInfo, heroActiveJobModelSkinResourceInfo, true, HeroDirectionType.Right, HeroActionType.Idle);
				if (uispineGraphic != null)
				{
					uispineGraphic.SetParent(this.m_heroInfoGraphicDummy);
				}
				this.SetHeroProperty(hero);
				this.SetHeroTalent(hero);
				this.SetCurSelectSkills(hero);
				this.SetEquipment(hero.Equipments);
			}
		}

		// Token: 0x0600C039 RID: 49209 RVA: 0x003593C8 File Offset: 0x003575C8
		private void SetHeroTalent(BattleHero battleHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroTalentBattleHero_hotfix != null)
			{
				this.m_SetHeroTalentBattleHero_hotfix.call(new object[]
				{
					this,
					battleHero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(battleHero.ActiveHeroJobRelatedId);
			this.m_talentIconImage.sprite = AssetUtility.Instance.GetSprite(configDataJobConnectionInfo.GetTalentSkillInfo(battleHero.StarLevel).Icon);
		}

		// Token: 0x0600C03A RID: 49210 RVA: 0x00359470 File Offset: 0x00357670
		private void SetHeroProperty(BattleHero battleHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroPropertyBattleHero_hotfix != null)
			{
				this.m_SetHeroPropertyBattleHero_hotfix.call(new object[]
				{
					this,
					battleHero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(battleHero.ActiveHeroJobRelatedId);
			char[] array = configDataJobConnectionInfo.PropertyRating.ToCharArray();
			List<Image> list = new List<Image>();
			list.Add(this.m_heroInfoPropHPImg);
			list.Add(this.m_heroInfoPropATImg);
			list.Add(this.m_heroInfoPropMagicImg);
			list.Add(this.m_heroInfoPropDFImg);
			list.Add(this.m_heroInfoPropMagicDFImg);
			list.Add(this.m_heroInfoPropDEXImg);
			for (int i = 0; i < array.Length; i++)
			{
				string propertyRatingImageName = UIUtility.GetPropertyRatingImageName(array[i]);
				list[i].sprite = AssetUtility.Instance.GetSprite(propertyRatingImageName);
			}
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeHeroEquipmentProperties(battleHero);
			this.m_heroInfoPropHPValueText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.m_heroInfoPropDFValueText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_heroInfoPropATValueText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_heroInfoPropMagicDFValueText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_heroInfoPropMagicValueText.text = heroPropertyComputer.Property0.Magic.ToString();
			this.m_heroInfoPropDEXValueText.text = heroPropertyComputer.Property0.Dexterity.ToString();
			int num = heroPropertyComputer.Property1.HealthPointMax - heroPropertyComputer.Property0.HealthPointMax;
			this.m_heroInfoPropHPAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Defense - heroPropertyComputer.Property0.Defense;
			this.m_heroInfoPropDFAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Attack - heroPropertyComputer.Property0.Attack;
			this.m_heroInfoPropATAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.MagicDefense - heroPropertyComputer.Property0.MagicDefense;
			this.m_heroInfoPropMagicDFAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Magic - heroPropertyComputer.Property0.Magic;
			this.m_heroInfoPropMagicAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Dexterity - heroPropertyComputer.Property0.Dexterity;
			this.m_heroInfoPropDEXAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
		}

		// Token: 0x0600C03B RID: 49211 RVA: 0x0035981C File Offset: 0x00357A1C
		private void SetCurSelectSkills(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurSelectSkillsBattleHero_hotfix != null)
			{
				this.m_SetCurSelectSkillsBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skillDummyList.Clear();
			for (int i = 0; i < 3; i++)
			{
				Transform transform = this.m_heroCurSkillGroup.transform.Find(i.ToString());
				GameObjectUtility.DestroyChildren(transform.gameObject);
				this.m_skillDummyList.Add(transform.gameObject);
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("SkillItem");
			List<int> selectedSkillList = hero.SelectedSkillList;
			List<int> list = new List<int>();
			list.AddRange(selectedSkillList);
			for (int j = 0; j < list.Count; j++)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(list[j]);
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroSkillItemUIController component = gameObject.GetComponent<HeroSkillItemUIController>();
				component.EventOnShowDesc += this.OnSkillItemClick;
				component.InitSkillItem(configDataSkillInfo);
				component.SetCostPanelActive(true);
				gameObject.transform.SetParent(this.m_skillDummyList[j].transform, false);
			}
		}

		// Token: 0x0600C03C RID: 49212 RVA: 0x00359994 File Offset: 0x00357B94
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
			SkillDescUIController skillDescUIController = null;
			for (int i = 0; i < this.m_heroInfoCurSkillDescPanel.transform.childCount; i++)
			{
				Transform child = this.m_heroInfoCurSkillDescPanel.transform.GetChild(i);
				skillDescUIController = child.GetComponent<SkillDescUIController>();
				if (skillDescUIController != null)
				{
					break;
				}
			}
			if (skillDescUIController == null)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("CommonSkillDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				skillDescUIController = gameObject.GetComponent<SkillDescUIController>();
				gameObject.transform.SetParent(this.m_heroInfoCurSkillDescPanel.transform, false);
			}
			skillDescUIController.InitSkillDesc(skillCtrl.m_skillInfo);
		}

		// Token: 0x0600C03D RID: 49213 RVA: 0x00359AA8 File Offset: 0x00357CA8
		private void OnTalentItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalentItemClick_hotfix != null)
			{
				this.m_OnTalentItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SkillDescUIController skillDescUIController = null;
			for (int i = 0; i < this.m_heroInfoCurSkillDescPanel.transform.childCount; i++)
			{
				Transform child = this.m_heroInfoCurSkillDescPanel.transform.GetChild(i);
				skillDescUIController = child.GetComponent<SkillDescUIController>();
				if (skillDescUIController != null)
				{
					break;
				}
			}
			if (skillDescUIController == null)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("CommonSkillDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				skillDescUIController = gameObject.GetComponent<SkillDescUIController>();
				gameObject.transform.SetParent(this.m_heroInfoCurSkillDescPanel.transform, false);
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(this.m_currentSelectBattleHero.ActiveHeroJobRelatedId);
			ConfigDataSkillInfo talentSkillInfo = configDataJobConnectionInfo.GetTalentSkillInfo(this.m_currentSelectBattleHero.StarLevel);
			skillDescUIController.InitSkillDesc(talentSkillInfo);
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x00359BD4 File Offset: 0x00357DD4
		private void SetEquipment(List<BattleHeroEquipment> equipments)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentList`1_hotfix != null)
			{
				this.m_SetEquipmentList`1_hotfix.call(new object[]
				{
					this,
					equipments
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearEquipmentItem();
			foreach (BattleHeroEquipment battleHeroEquipment in equipments)
			{
				switch (battleHeroEquipment.EquipmentInfo.EquipmentType)
				{
				case EquipmentType.EquipmentType_Weapon:
					this.SetEquipmentItemInfo(battleHeroEquipment, this.m_equipment1Dummy);
					break;
				case EquipmentType.EquipmentType_Armor:
					this.SetEquipmentItemInfo(battleHeroEquipment, this.m_equipment2Dummy);
					break;
				case EquipmentType.EquipmentType_Helmet:
					this.SetEquipmentItemInfo(battleHeroEquipment, this.m_equipment3Dummy);
					break;
				case EquipmentType.EquipmentType_Ornament:
					this.SetEquipmentItemInfo(battleHeroEquipment, this.m_equipment4Dummy);
					break;
				}
			}
		}

		// Token: 0x0600C03F RID: 49215 RVA: 0x00359CFC File Offset: 0x00357EFC
		private void ClearEquipmentItem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearEquipmentItem_hotfix != null)
			{
				this.m_ClearEquipmentItem_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_equipment1Dummy);
			GameObjectUtility.DestroyChildren(this.m_equipment2Dummy);
			GameObjectUtility.DestroyChildren(this.m_equipment3Dummy);
			GameObjectUtility.DestroyChildren(this.m_equipment4Dummy);
		}

		// Token: 0x0600C040 RID: 49216 RVA: 0x00359D88 File Offset: 0x00357F88
		private void SetEquipmentItemInfo(BattleHeroEquipment equipment, GameObject parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentItemInfoBattleHeroEquipmentGameObject_hotfix != null)
			{
				this.m_SetEquipmentItemInfoBattleHeroEquipmentGameObject_hotfix.call(new object[]
				{
					this,
					equipment,
					parent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_equipmentItemPrefab);
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = GameObjectUtility.AddControllerToGameObject<BusinessCardHeroEquipmentItemController>(gameObject);
			businessCardHeroEquipmentItemController.SetEquipmentInfo(equipment);
			businessCardHeroEquipmentItemController.EventOnClick += this.OnEquipmentItemClick;
			gameObject.transform.SetParent(parent.transform, false);
		}

		// Token: 0x0600C041 RID: 49217 RVA: 0x00359E48 File Offset: 0x00358048
		private void OnEquipmentItemClick(BusinessCardHeroEquipmentItemController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentItemClickBusinessCardHeroEquipmentItemController_hotfix != null)
			{
				this.m_OnEquipmentItemClickBusinessCardHeroEquipmentItemController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetEquipmentItemDesc(ctrl.GetEquipment());
			UIUtility.SetUIStateOpen(this.m_equipItemDescStateController, "Show", null, false, true);
		}

		// Token: 0x0600C042 RID: 49218 RVA: 0x00359ED8 File Offset: 0x003580D8
		private void OnEquipmentItemBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentItemBGButtonClick_hotfix != null)
			{
				this.m_OnEquipmentItemBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_equipItemDescStateController, "Close", null, false, true);
		}

		// Token: 0x0600C043 RID: 49219 RVA: 0x00359F4C File Offset: 0x0035814C
		private void SetEquipmentItemDesc(BattleHeroEquipment equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentItemDescBattleHeroEquipment_hotfix != null)
			{
				this.m_SetEquipmentItemDescBattleHeroEquipment_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (equipment == null)
			{
				return;
			}
			this.m_equipItemDescTitleText.text = equipment.EquipmentInfo.Name;
			this.m_equipItemDescLvText.text = "Lv." + equipment.Level.ToString();
			this.m_equipItemDescIconImage.sprite = AssetUtility.Instance.GetSprite(equipment.EquipmentInfo.Icon);
			this.m_equipItemDescIconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipment.EquipmentInfo.Rank));
			this.m_equipItemDescSSREffect.SetActive(UIUtility.IsRankSSR(equipment.EquipmentInfo.Rank));
			int num = this.m_playerContext.CaculateEquipmentNextLevelExp(equipment.Id, equipment.Level);
			this.m_equipItemDescExpText.text = (num - equipment.Exp).ToString();
			this.m_equipItemDescProgressImage.fillAmount = (float)equipment.Exp / (float)num;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_equipItemDescStarGroup, equipment.StarLevel);
			List<int> armyIds = equipment.EquipmentInfo.ArmyIds;
			CommonUIStateController component = this.m_equipItemDescEquipLimitContent.GetComponent<CommonUIStateController>();
			if (armyIds.Count == 0)
			{
				component.SetToUIState("Unlimit", false, true);
			}
			else if (armyIds[0] == -1)
			{
				component.SetToUIState("CanNotUse", false, true);
			}
			else
			{
				component.SetToUIState("EquipLimit", false, true);
				for (int i = 0; i < this.m_equipItemDescEquipLimitContent.transform.childCount; i++)
				{
					Transform child = this.m_equipItemDescEquipLimitContent.transform.GetChild(i);
					child.gameObject.SetActive(false);
				}
				for (int j = 0; j < armyIds.Count; j++)
				{
					ConfigDataArmyInfo configDataArmyInfo = this.m_configDataLoader.GetConfigDataArmyInfo(armyIds[j]);
					if (j < this.m_equipItemDescEquipLimitContent.transform.childCount)
					{
						Transform child2 = this.m_equipItemDescEquipLimitContent.transform.GetChild(j);
						child2.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
						child2.gameObject.SetActive(true);
					}
					else
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_equipItemDescEquipLimitContent.transform.GetChild(0).gameObject, this.m_equipItemDescEquipLimitContent.transform, true);
						gameObject.transform.GetChild(0).GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
						gameObject.SetActive(true);
					}
				}
			}
			for (int k = 0; k < this.m_equipItemDescPropContent.transform.childCount; k++)
			{
				Transform child3 = this.m_equipItemDescPropContent.transform.GetChild(k);
				child3.gameObject.SetActive(false);
			}
			this.SetPropItems(equipment.EquipmentInfo.Property1_ID, equipment.EquipmentInfo.Property1_Value, equipment.EquipmentInfo.Property1_LevelUpValue, equipment.Level);
			this.SetPropItems(equipment.EquipmentInfo.Property2_ID, equipment.EquipmentInfo.Property2_Value, equipment.EquipmentInfo.Property2_LevelUpValue, equipment.Level);
			if (equipment.EquipmentInfo.SkillIds.Count != 0)
			{
				string text = null;
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(UIUtility.GetSkillIdFromEquipment(equipment.EquipmentInfo, equipment.Level, ref text));
				if (configDataSkillInfo != null)
				{
					this.m_equipItemDescSkillNameText.text = configDataSkillInfo.Name;
					if (text == null)
					{
						if (equipment.EquipmentInfo.SkillLevels != null && equipment.EquipmentInfo.SkillLevels.Count > 0)
						{
							this.m_equipItemDescSkillLvText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_EnchantToLevel), equipment.EquipmentInfo.SkillLevels[0]);
						}
						else
						{
							this.m_equipItemDescSkillLvText.text = string.Empty;
						}
					}
					else
					{
						this.m_equipItemDescSkillLvText.text = string.Format("Lv.{0}", text);
					}
					this.m_equipItemDescSkillDescText.text = configDataSkillInfo.Desc;
					if (equipment.EquipmentInfo.SkillHero != 0)
					{
						this.m_equipItemDescSkillOwnerText.text = this.m_configDataLoader.GetConfigDataHeroInfo(equipment.EquipmentInfo.SkillHero).Name;
					}
					else
					{
						this.m_equipItemDescSkillOwnerText.text = null;
					}
				}
				else
				{
					this.m_equipItemDescSkillNameText.text = null;
					this.m_equipItemDescSkillLvText.text = null;
					this.m_equipItemDescSkillDescText.text = null;
					this.m_equipItemDescSkillOwnerText.text = null;
				}
			}
			this.m_equipItemDescSkillContent.SetActive(equipment.EquipmentInfo.SkillIds.Count != 0);
			this.m_equipItemDescNotEquipSkillTip.SetActive(equipment.EquipmentInfo.SkillIds.Count == 0);
		}

		// Token: 0x0600C044 RID: 49220 RVA: 0x0035A4A8 File Offset: 0x003586A8
		private void SetPropItems(PropertyModifyType type, int value, int addValue, int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix != null)
			{
				this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					type,
					value,
					addValue,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			value += addValue * (level - 1) / 10;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.m_equipItemDescPropHPGo.SetActive(true);
				this.m_equipItemDescPropHPValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.m_equipItemDescPropATGo.SetActive(true);
				this.m_equipItemDescPropATValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.m_equipItemDescPropDFGo.SetActive(true);
				this.m_equipItemDescPropDFValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.m_equipItemDescPropMagiccGo.SetActive(true);
				this.m_equipItemDescPropMagicValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.m_equipItemDescPropMagicDFGo.SetActive(true);
				this.m_equipItemDescPropMagicDFValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.m_equipItemDescPropDexGo.SetActive(true);
				this.m_equipItemDescPropDexValueText.text = "+" + value;
				break;
			}
		}

		// Token: 0x0600C045 RID: 49221 RVA: 0x0035A684 File Offset: 0x00358884
		private void SetCharInfoPanel(BattleHero hero, int positionIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharInfoPanelBattleHeroInt32_hotfix != null)
			{
				this.m_SetCharInfoPanelBattleHeroInt32_hotfix.call(new object[]
				{
					this,
					hero,
					positionIndex2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int positionIndex = positionIndex2;
			BusinessCardHeroSet businessCardHeroSet = this.m_businessCard.SetInfo.Heroes.Find((BusinessCardHeroSet hs) => hs.PositionIndex == positionIndex);
			if (businessCardHeroSet != null)
			{
				GameObjectUtility.DestroyChildren(this.m_charGraphicParentDummy);
				if (hero.HeroId == businessCardHeroSet.HeroId)
				{
					ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(hero.ActiveHeroJobRelatedId);
					if (configDataJobConnectionInfo != null)
					{
						ConfigDataModelSkinResourceInfo heroActiveJobModelSkinResourceInfo = hero.GetHeroActiveJobModelSkinResourceInfo(this.m_configDataLoader);
						UISpineGraphic uispineGraphic = this.CreateSpineGraphic(configDataJobConnectionInfo, heroActiveJobModelSkinResourceInfo, true, businessCardHeroSet.Direction, businessCardHeroSet.Action);
						if (uispineGraphic != null)
						{
							this.m_currentCharSpineGraphic = uispineGraphic;
							uispineGraphic.SetParent(this.m_charGraphicParentDummy);
							this.m_charNameText.text = hero.HeroInfo.Name;
							this.m_charFaceDropdown.value = (int)businessCardHeroSet.Direction;
							this.m_charActiveDropdown.value = (int)businessCardHeroSet.Action;
						}
					}
				}
			}
		}

		// Token: 0x0600C046 RID: 49222 RVA: 0x0035A7E8 File Offset: 0x003589E8
		private void OnCharDiretionValueChanged(int direction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharDiretionValueChangedInt32_hotfix != null)
			{
				this.m_OnCharDiretionValueChangedInt32_hotfix.call(new object[]
				{
					this,
					direction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Enum.IsDefined(typeof(HeroDirectionType), direction))
			{
				this.m_currentHeroDirectionType = (HeroDirectionType)direction;
				this.SetCharAction(this.m_currentCharSpineGraphic, this.m_currentHeroDirectionType, this.m_currentHeroAnimationType);
			}
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x0035A894 File Offset: 0x00358A94
		private void OnCharAnimationValueChanged(int animation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCharAnimationValueChangedInt32_hotfix != null)
			{
				this.m_OnCharAnimationValueChangedInt32_hotfix.call(new object[]
				{
					this,
					animation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Enum.IsDefined(typeof(HeroActionType), animation))
			{
				this.m_currentHeroAnimationType = (HeroActionType)animation;
				this.SetCharAction(this.m_currentCharSpineGraphic, this.m_currentHeroDirectionType, this.m_currentHeroAnimationType);
			}
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x0035A940 File Offset: 0x00358B40
		private UISpineGraphic CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo heroSkinResInfo, bool isUIModelScale, HeroDirectionType directionType = HeroDirectionType.Left, HeroActionType actionType = HeroActionType.Idle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoBooleanHeroDirectionTypeHeroActionType_hotfix != null)
			{
				return (UISpineGraphic)this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoBooleanHeroDirectionTypeHeroActionType_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo,
					heroSkinResInfo,
					isUIModelScale,
					directionType,
					actionType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (jobConnectionInfo == null)
			{
				return null;
			}
			string text = string.Empty;
			if (heroSkinResInfo != null)
			{
				text = heroSkinResInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = jobConnectionInfo.Model;
			}
			float scale = (!isUIModelScale) ? ((float)jobConnectionInfo.ModelScale * 0.01f * 1.23f) : ((float)jobConnectionInfo.UI_ModelScale * 0.014f);
			UISpineGraphic uispineGraphic = new UISpineGraphic();
			uispineGraphic.Create(text);
			uispineGraphic.SetScale(scale);
			uispineGraphic.SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
			this.SetCharAction(uispineGraphic, directionType, actionType);
			uispineGraphic.ForceUpdate();
			return uispineGraphic;
		}

		// Token: 0x0600C049 RID: 49225 RVA: 0x0035AA88 File Offset: 0x00358C88
		private void SetCharAction(UISpineGraphic g, HeroDirectionType direction, HeroActionType animation)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharActionUISpineGraphicHeroDirectionTypeHeroActionType_hotfix != null)
			{
				this.m_SetCharActionUISpineGraphicHeroDirectionTypeHeroActionType_hotfix.call(new object[]
				{
					this,
					g,
					direction,
					animation
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			g.SetDirection((direction != HeroDirectionType.Left) ? 1 : -1);
			switch (animation)
			{
			case HeroActionType.Idle:
				g.PlayAnimation("idle", true, 0);
				break;
			case HeroActionType.Attack:
				g.PlayAnimation("attack1", true, 0);
				break;
			case HeroActionType.SuperAttack:
				g.PlayAnimation("superattack", true, 0);
				break;
			case HeroActionType.Cast:
				g.PlayAnimation("cast", true, 0);
				break;
			case HeroActionType.Dead:
				g.PlayAnimation("death", false, 0);
				break;
			case HeroActionType.Sing:
				g.PlayAnimation("sing", true, 0);
				break;
			case HeroActionType.Stun:
				g.PlayAnimation("stun", true, 0);
				break;
			case HeroActionType.Run:
				g.PlayAnimation("run", true, 0);
				break;
			}
		}

		// Token: 0x0600C04A RID: 49226 RVA: 0x0035ABE8 File Offset: 0x00358DE8
		private void SetHeroSelectPanel(BusinessCard businessCard)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroSelectPanelBusinessCard_hotfix != null)
			{
				this.m_SetHeroSelectPanelBusinessCard_hotfix.call(new object[]
				{
					this,
					businessCard
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int childCount = this.m_heroListContent.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				this.m_heroListContent.transform.GetChild(i).gameObject.SetActive(false);
			}
			for (int j = 0; j < this.m_isSelectArray.Length; j++)
			{
				this.m_isSelectArray[j] = false;
			}
			this.m_heroSortList.Clear();
			int positionIndex;
			for (positionIndex = 0; positionIndex < 5; positionIndex++)
			{
				BusinessCardHeroSet businessCardHeroSet = businessCard.SetInfo.Heroes.Find((BusinessCardHeroSet h) => h.PositionIndex == positionIndex);
				if (businessCardHeroSet != null)
				{
					this.m_heroSortList.Add(this.m_playerContext.GetHero(businessCardHeroSet.HeroId));
					this.m_isSelectArray[positionIndex] = true;
				}
			}
			this.m_heroSortList.Sort(new Comparison<Hero>(this.HeroListItemCompare));
			List<Hero> list = new List<Hero>();
			using (List<Hero>.Enumerator enumerator = this.m_playerContext.GetHeros().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Hero hero = enumerator.Current;
					if (this.m_heroSortList.Find((Hero h) => h.HeroId == hero.HeroId) == null)
					{
						list.Add(hero);
					}
				}
			}
			list.Sort(new Comparison<Hero>(this.HeroListItemCompare));
			this.m_heroSortList.AddRange(list);
			for (int k = 0; k < this.m_heroSortList.Count; k++)
			{
				Hero hero2 = this.m_heroSortList[k];
				BusinessCardHeroListItemUIController businessCardHeroListItemUIController;
				if (k >= childCount)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroListItemPrefab);
					businessCardHeroListItemUIController = GameObjectUtility.AddControllerToGameObject<BusinessCardHeroListItemUIController>(gameObject);
					businessCardHeroListItemUIController.EventOnSelectHeroItem += this.OnHeroItemClick;
					gameObject.transform.SetParent(this.m_heroListContent.transform, false);
				}
				else
				{
					businessCardHeroListItemUIController = this.m_heroListContent.transform.GetChild(k).gameObject.GetComponent<BusinessCardHeroListItemUIController>();
				}
				businessCardHeroListItemUIController.SetHeroListItemInfo(hero2, businessCard);
			}
		}

		// Token: 0x0600C04B RID: 49227 RVA: 0x0035AEAC File Offset: 0x003590AC
		private int HeroListItemCompare(Hero h1, Hero h2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListItemCompareHeroHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_HeroListItemCompareHeroHero_hotfix.call(new object[]
				{
					this,
					h1,
					h2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = h2.Level - h1.Level;
			int num2 = h2.HeroInfo.GetRank(h2.StarLevel) - h1.HeroInfo.GetRank(h1.StarLevel);
			int num3 = h2.StarLevel - h1.StarLevel;
			int num4 = h2.BattlePower - h1.BattlePower;
			if (num != 0)
			{
				return num;
			}
			if (num3 != 0)
			{
				return num3;
			}
			if (num2 != 0)
			{
				return num2;
			}
			if (num4 != 0)
			{
				return num4;
			}
			return h1.HeroId - h2.HeroId;
		}

		// Token: 0x0600C04C RID: 49228 RVA: 0x0035AFB4 File Offset: 0x003591B4
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
				this.EventOnReturn(this.m_randomShowToggle.isOn != this.m_playerContext.BusinessCard.SetInfo.IsActionRandom);
			}
		}

		// Token: 0x0600C04D RID: 49229 RVA: 0x0035B050 File Offset: 0x00359250
		private void OnLikeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLikeButtonClick_hotfix != null)
			{
				this.m_OnLikeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnLike != null)
			{
				this.EventOnLike(this.m_businessCard.UserId);
			}
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x0035B0D4 File Offset: 0x003592D4
		private void OnRandowShowToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRandowShowToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRandowShowToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				foreach (BusinessCardUIController.GraphicInfo graphicInfo in this.m_graphicList)
				{
					this.SetCharAction(graphicInfo.m_graphic, (HeroDirectionType)UnityEngine.Random.Range(0, 2), (HeroActionType)UnityEngine.Random.Range(0, 8));
				}
			}
			else
			{
				foreach (BusinessCardUIController.GraphicInfo graphicInfo2 in this.m_graphicList)
				{
					this.SetCharAction(graphicInfo2.m_graphic, graphicInfo2.m_directionType, graphicInfo2.m_actionType);
				}
			}
		}

		// Token: 0x0600C04F RID: 49231 RVA: 0x0035B210 File Offset: 0x00359410
		private void OnSetPanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSetPanelBGButtonClick_hotfix != null)
			{
				this.m_OnSetPanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_setPanelUIStateController.GetCurrentUIState().StateName == "Show")
			{
				UIUtility.SetUIStateClose(this.m_setPanelUIStateController, "Close", null, false, true);
			}
			else if (this.m_setPanelUIStateController.GetCurrentUIState().StateName == "NoHeroInfoShow")
			{
				UIUtility.SetUIStateClose(this.m_setPanelUIStateController, "NoHeroInfoClose", null, false, true);
			}
			else if (this.m_setPanelUIStateController.GetCurrentUIState().StateName == "SetCharPanelShow")
			{
				UIUtility.SetUIStateClose(this.m_setPanelUIStateController, "SetCharPanelClose", null, false, true);
			}
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x0035B310 File Offset: 0x00359510
		private void OnChangeSignButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeSignButtonClick_hotfix != null)
			{
				this.m_OnChangeSignButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerSignText.gameObject.SetActive(false);
			this.m_playerInputField.gameObject.SetActive(true);
			this.m_playerInputField.ActivateInputField();
		}

		// Token: 0x0600C051 RID: 49233 RVA: 0x0035B3A0 File Offset: 0x003595A0
		private void OnArButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArButtonClick_hotfix != null)
			{
				this.m_OnArButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnArClick != null)
			{
				this.EventOnArClick();
			}
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x0035B418 File Offset: 0x00359618
		private void OnPlayerSignEditEnd(InputField input)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerSignEditEndInputField_hotfix != null)
			{
				this.m_OnPlayerSignEditEndInputField_hotfix.call(new object[]
				{
					this,
					input
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (input.text.Length > 0)
			{
				this.EventOnChangeSign(input.text);
			}
			this.PlayerSignUpdateEnd();
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x0035B4B0 File Offset: 0x003596B0
		public void PlayerSignUpdateSuccess(string sign)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSignUpdateSuccessString_hotfix != null)
			{
				this.m_PlayerSignUpdateSuccessString_hotfix.call(new object[]
				{
					this,
					sign
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerSignText.text = sign;
			this.PlayerSignUpdateEnd();
		}

		// Token: 0x0600C054 RID: 49236 RVA: 0x0035B534 File Offset: 0x00359734
		public void PlayerSignUpdateEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerSignUpdateEnd_hotfix != null)
			{
				this.m_PlayerSignUpdateEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerInputField.gameObject.SetActive(false);
			this.m_playerSignText.gameObject.SetActive(true);
		}

		// Token: 0x0600C055 RID: 49237 RVA: 0x0035B5B8 File Offset: 0x003597B8
		private void OnHeroItemClick(BusinessCardHeroListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroItemClickBusinessCardHeroListItemUIController_hotfix != null)
			{
				this.m_OnHeroItemClickBusinessCardHeroListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BusinessCardHeroListItemUIController ctrl = ctrl2;
			int num = -1;
			if (ctrl.IsSelect())
			{
				int positionIndex = ctrl.GetPositionIndex();
				if (positionIndex >= 0)
				{
					this.m_isSelectArray[positionIndex] = false;
					int num2 = this.m_currentHeroSetList.FindIndex((BusinessCardHeroSet hs) => hs.HeroId == ctrl.GetHeroID());
					if (num2 >= 0)
					{
						this.m_currentHeroSetList.RemoveAt(num2);
					}
					ctrl.SetNormalState();
				}
			}
			else
			{
				for (int i = 0; i < 5; i++)
				{
					if (!this.m_isSelectArray[i])
					{
						num = i;
						break;
					}
				}
				if (num >= 0)
				{
					BusinessCardHeroSet businessCardHeroSet = new BusinessCardHeroSet();
					businessCardHeroSet.HeroId = ctrl.GetHeroID();
					businessCardHeroSet.PositionIndex = num;
					businessCardHeroSet.Direction = HeroDirectionType.Left;
					businessCardHeroSet.Action = HeroActionType.Idle;
					this.m_currentHeroSetList.Add(businessCardHeroSet);
					this.m_isSelectArray[num] = true;
					ctrl.SetSelectState(num);
				}
			}
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x0035B724 File Offset: 0x00359924
		private void OnHeroInfoPanelSettingButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroInfoPanelSettingButtonClick_hotfix != null)
			{
				this.m_OnHeroInfoPanelSettingButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetCharInfoPanel(this.m_currentSelectBattleHero, this.m_currentSelectPositionIndex);
			UIUtility.SetUIStateClose(this.m_heroInfoPanelUIStateController, "Close", delegate
			{
				UIUtility.SetUIStateOpen(this.m_setPanelUIStateController, "SetCharPanelShow", null, false, true);
			}, false, true);
		}

		// Token: 0x0600C057 RID: 49239 RVA: 0x0035B7B4 File Offset: 0x003599B4
		private void OnHeroInfoPanelChangeButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroInfoPanelChangeButtonClick_hotfix != null)
			{
				this.m_OnHeroInfoPanelChangeButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetHeroSelectPanel(this.m_businessCard);
			UIUtility.SetUIStateClose(this.m_heroInfoPanelUIStateController, "Close", delegate
			{
				UIUtility.SetUIStateOpen(this.m_heroSelectPanelUIStateController, "Show", null, false, true);
			}, false, true);
		}

		// Token: 0x0600C058 RID: 49240 RVA: 0x0035B840 File Offset: 0x00359A40
		private void OnSetCharPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSetCharPanelConfirmButtonClick_hotfix != null)
			{
				this.m_OnSetCharPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BusinessCardHeroSet businessCardHeroSet = this.m_currentHeroSetList.Find((BusinessCardHeroSet hs) => hs.PositionIndex == this.m_currentSelectPositionIndex);
			if (businessCardHeroSet != null)
			{
				businessCardHeroSet.Action = this.m_currentHeroAnimationType;
				businessCardHeroSet.Direction = this.m_currentHeroDirectionType;
				if (this.EventOnUpdateHeroSet != null)
				{
					this.EventOnUpdateHeroSet(this.m_currentHeroSetList);
				}
				UIUtility.SetUIStateClose(this.m_setCharInfoPanelUIStateController, "Close", delegate
				{
					UIUtility.SetUIStateClose(this.m_setPanelUIStateController, "Close", null, false, true);
				}, false, true);
			}
		}

		// Token: 0x0600C059 RID: 49241 RVA: 0x0035B910 File Offset: 0x00359B10
		private void OnHeroSelectPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroSelectPanelConfirmButtonClick_hotfix != null)
			{
				this.m_OnHeroSelectPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnUpdateHeroSet != null)
			{
				this.EventOnUpdateHeroSet(this.m_currentHeroSetList);
			}
			UIUtility.SetUIStateClose(this.m_setPanelUIStateController, "NoHeroInfoClose", null, false, true);
		}

		// Token: 0x0600C05A RID: 49242 RVA: 0x0035B9A0 File Offset: 0x00359BA0
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!Input.GetMouseButton(0) || !Input.GetMouseButton(1) || !Input.GetKey(KeyCode.LeftShift))
			{
				this.m_fDebugReportTime = Time.realtimeSinceStartup;
			}
			if (Time.realtimeSinceStartup - this.m_fDebugReportTime > 10f)
			{
				base.StartCoroutine(TestUITask.ReportBug("UploadLogByTouches", 24.0));
				this.m_fDebugReportTime = Time.realtimeSinceStartup;
			}
		}

		// Token: 0x1400024B RID: 587
		// (add) Token: 0x0600C05B RID: 49243 RVA: 0x0035BA70 File Offset: 0x00359C70
		// (remove) Token: 0x0600C05C RID: 49244 RVA: 0x0035BB0C File Offset: 0x00359D0C
		public event Action EventOnArClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnArClickAction_hotfix != null)
				{
					this.m_add_EventOnArClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnArClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnArClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnArClickAction_hotfix != null)
				{
					this.m_remove_EventOnArClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnArClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnArClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400024C RID: 588
		// (add) Token: 0x0600C05D RID: 49245 RVA: 0x0035BBA8 File Offset: 0x00359DA8
		// (remove) Token: 0x0600C05E RID: 49246 RVA: 0x0035BC44 File Offset: 0x00359E44
		public event Action<bool> EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction`1_hotfix != null)
				{
					this.m_add_EventOnReturnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnReturn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnReturn, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction`1_hotfix != null)
				{
					this.m_remove_EventOnReturnAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnReturn;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnReturn, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400024D RID: 589
		// (add) Token: 0x0600C05F RID: 49247 RVA: 0x0035BCE0 File Offset: 0x00359EE0
		// (remove) Token: 0x0600C060 RID: 49248 RVA: 0x0035BD7C File Offset: 0x00359F7C
		public event Action<string> EventOnLike
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLikeAction`1_hotfix != null)
				{
					this.m_add_EventOnLikeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnLike;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnLike, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLikeAction`1_hotfix != null)
				{
					this.m_remove_EventOnLikeAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnLike;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnLike, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400024E RID: 590
		// (add) Token: 0x0600C061 RID: 49249 RVA: 0x0035BE18 File Offset: 0x0035A018
		// (remove) Token: 0x0600C062 RID: 49250 RVA: 0x0035BEB4 File Offset: 0x0035A0B4
		public event Action<string> EventOnChangeSign
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeSignAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeSignAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChangeSign;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChangeSign, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeSignAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeSignAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnChangeSign;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnChangeSign, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400024F RID: 591
		// (add) Token: 0x0600C063 RID: 49251 RVA: 0x0035BF50 File Offset: 0x0035A150
		// (remove) Token: 0x0600C064 RID: 49252 RVA: 0x0035BFEC File Offset: 0x0035A1EC
		public event Action<List<BusinessCardHeroSet>> EventOnUpdateHeroSet
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUpdateHeroSetAction`1_hotfix != null)
				{
					this.m_add_EventOnUpdateHeroSetAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<BusinessCardHeroSet>> action = this.EventOnUpdateHeroSet;
				Action<List<BusinessCardHeroSet>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<BusinessCardHeroSet>>>(ref this.EventOnUpdateHeroSet, (Action<List<BusinessCardHeroSet>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUpdateHeroSetAction`1_hotfix != null)
				{
					this.m_remove_EventOnUpdateHeroSetAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<BusinessCardHeroSet>> action = this.EventOnUpdateHeroSet;
				Action<List<BusinessCardHeroSet>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<BusinessCardHeroSet>>>(ref this.EventOnUpdateHeroSet, (Action<List<BusinessCardHeroSet>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600C065 RID: 49253 RVA: 0x0035C088 File Offset: 0x0035A288
		// (set) Token: 0x0600C066 RID: 49254 RVA: 0x0035C0A8 File Offset: 0x0035A2A8
		[DoNotToLua]
		public new BusinessCardUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BusinessCardUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C067 RID: 49255 RVA: 0x0035C0B4 File Offset: 0x0035A2B4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C068 RID: 49256 RVA: 0x0035C0C0 File Offset: 0x0035A2C0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C069 RID: 49257 RVA: 0x0035C0C8 File Offset: 0x0035A2C8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x0035C0D0 File Offset: 0x0035A2D0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x0035C0E4 File Offset: 0x0035A2E4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x0035C0EC File Offset: 0x0035A2EC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x0035C0F8 File Offset: 0x0035A2F8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x0035C104 File Offset: 0x0035A304
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C06F RID: 49263 RVA: 0x0035C110 File Offset: 0x0035A310
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C070 RID: 49264 RVA: 0x0035C11C File Offset: 0x0035A31C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x0035C128 File Offset: 0x0035A328
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C072 RID: 49266 RVA: 0x0035C134 File Offset: 0x0035A334
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C073 RID: 49267 RVA: 0x0035C140 File Offset: 0x0035A340
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C074 RID: 49268 RVA: 0x0035C14C File Offset: 0x0035A34C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x0035C158 File Offset: 0x0035A358
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C076 RID: 49270 RVA: 0x0035C160 File Offset: 0x0035A360
		private void __callDele_EventOnArClick()
		{
			Action eventOnArClick = this.EventOnArClick;
			if (eventOnArClick != null)
			{
				eventOnArClick();
			}
		}

		// Token: 0x0600C077 RID: 49271 RVA: 0x0035C180 File Offset: 0x0035A380
		private void __clearDele_EventOnArClick()
		{
			this.EventOnArClick = null;
		}

		// Token: 0x0600C078 RID: 49272 RVA: 0x0035C18C File Offset: 0x0035A38C
		private void __callDele_EventOnReturn(bool obj)
		{
			Action<bool> eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn(obj);
			}
		}

		// Token: 0x0600C079 RID: 49273 RVA: 0x0035C1B0 File Offset: 0x0035A3B0
		private void __clearDele_EventOnReturn(bool obj)
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600C07A RID: 49274 RVA: 0x0035C1BC File Offset: 0x0035A3BC
		private void __callDele_EventOnLike(string obj)
		{
			Action<string> eventOnLike = this.EventOnLike;
			if (eventOnLike != null)
			{
				eventOnLike(obj);
			}
		}

		// Token: 0x0600C07B RID: 49275 RVA: 0x0035C1E0 File Offset: 0x0035A3E0
		private void __clearDele_EventOnLike(string obj)
		{
			this.EventOnLike = null;
		}

		// Token: 0x0600C07C RID: 49276 RVA: 0x0035C1EC File Offset: 0x0035A3EC
		private void __callDele_EventOnChangeSign(string obj)
		{
			Action<string> eventOnChangeSign = this.EventOnChangeSign;
			if (eventOnChangeSign != null)
			{
				eventOnChangeSign(obj);
			}
		}

		// Token: 0x0600C07D RID: 49277 RVA: 0x0035C210 File Offset: 0x0035A410
		private void __clearDele_EventOnChangeSign(string obj)
		{
			this.EventOnChangeSign = null;
		}

		// Token: 0x0600C07E RID: 49278 RVA: 0x0035C21C File Offset: 0x0035A41C
		private void __callDele_EventOnUpdateHeroSet(List<BusinessCardHeroSet> obj)
		{
			Action<List<BusinessCardHeroSet>> eventOnUpdateHeroSet = this.EventOnUpdateHeroSet;
			if (eventOnUpdateHeroSet != null)
			{
				eventOnUpdateHeroSet(obj);
			}
		}

		// Token: 0x0600C07F RID: 49279 RVA: 0x0035C240 File Offset: 0x0035A440
		private void __clearDele_EventOnUpdateHeroSet(List<BusinessCardHeroSet> obj)
		{
			this.EventOnUpdateHeroSet = null;
		}

		// Token: 0x0600C085 RID: 49285 RVA: 0x0035C2B4 File Offset: 0x0035A4B4
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
					this.m_ShowOpenState_hotfix = (luaObj.RawGet("ShowOpenState") as LuaFunction);
					this.m_SetPlayerInfoBusinessCardBooleanBooleanBoolean_hotfix = (luaObj.RawGet("SetPlayerInfo") as LuaFunction);
					this.m_CheckARState_hotfix = (luaObj.RawGet("CheckARState") as LuaFunction);
					this.m_SetTeamBusinessCardBoolean_hotfix = (luaObj.RawGet("SetTeam") as LuaFunction);
					this.m_OnHeroCharClickBusinessCardHeroCharItemUIController_hotfix = (luaObj.RawGet("OnHeroCharClick") as LuaFunction);
					this.m_ClearTeam_hotfix = (luaObj.RawGet("ClearTeam") as LuaFunction);
					this.m_SetRandomShowToggleOff_hotfix = (luaObj.RawGet("SetRandomShowToggleOff") as LuaFunction);
					this.m_SetHeroInfoPanelBattleHeroBoolean_hotfix = (luaObj.RawGet("SetHeroInfoPanel") as LuaFunction);
					this.m_SetHeroTalentBattleHero_hotfix = (luaObj.RawGet("SetHeroTalent") as LuaFunction);
					this.m_SetHeroPropertyBattleHero_hotfix = (luaObj.RawGet("SetHeroProperty") as LuaFunction);
					this.m_SetCurSelectSkillsBattleHero_hotfix = (luaObj.RawGet("SetCurSelectSkills") as LuaFunction);
					this.m_OnSkillItemClickHeroSkillItemUIController_hotfix = (luaObj.RawGet("OnSkillItemClick") as LuaFunction);
					this.m_OnTalentItemClick_hotfix = (luaObj.RawGet("OnTalentItemClick") as LuaFunction);
					this.m_SetEquipmentList`1_hotfix = (luaObj.RawGet("SetEquipment") as LuaFunction);
					this.m_ClearEquipmentItem_hotfix = (luaObj.RawGet("ClearEquipmentItem") as LuaFunction);
					this.m_SetEquipmentItemInfoBattleHeroEquipmentGameObject_hotfix = (luaObj.RawGet("SetEquipmentItemInfo") as LuaFunction);
					this.m_OnEquipmentItemClickBusinessCardHeroEquipmentItemController_hotfix = (luaObj.RawGet("OnEquipmentItemClick") as LuaFunction);
					this.m_OnEquipmentItemBGButtonClick_hotfix = (luaObj.RawGet("OnEquipmentItemBGButtonClick") as LuaFunction);
					this.m_SetEquipmentItemDescBattleHeroEquipment_hotfix = (luaObj.RawGet("SetEquipmentItemDesc") as LuaFunction);
					this.m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix = (luaObj.RawGet("SetPropItems") as LuaFunction);
					this.m_SetCharInfoPanelBattleHeroInt32_hotfix = (luaObj.RawGet("SetCharInfoPanel") as LuaFunction);
					this.m_OnCharDiretionValueChangedInt32_hotfix = (luaObj.RawGet("OnCharDiretionValueChanged") as LuaFunction);
					this.m_OnCharAnimationValueChangedInt32_hotfix = (luaObj.RawGet("OnCharAnimationValueChanged") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoBooleanHeroDirectionTypeHeroActionType_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_SetCharActionUISpineGraphicHeroDirectionTypeHeroActionType_hotfix = (luaObj.RawGet("SetCharAction") as LuaFunction);
					this.m_SetHeroSelectPanelBusinessCard_hotfix = (luaObj.RawGet("SetHeroSelectPanel") as LuaFunction);
					this.m_HeroListItemCompareHeroHero_hotfix = (luaObj.RawGet("HeroListItemCompare") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnLikeButtonClick_hotfix = (luaObj.RawGet("OnLikeButtonClick") as LuaFunction);
					this.m_OnRandowShowToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRandowShowToggleValueChanged") as LuaFunction);
					this.m_OnSetPanelBGButtonClick_hotfix = (luaObj.RawGet("OnSetPanelBGButtonClick") as LuaFunction);
					this.m_OnChangeSignButtonClick_hotfix = (luaObj.RawGet("OnChangeSignButtonClick") as LuaFunction);
					this.m_OnArButtonClick_hotfix = (luaObj.RawGet("OnArButtonClick") as LuaFunction);
					this.m_OnPlayerSignEditEndInputField_hotfix = (luaObj.RawGet("OnPlayerSignEditEnd") as LuaFunction);
					this.m_PlayerSignUpdateSuccessString_hotfix = (luaObj.RawGet("PlayerSignUpdateSuccess") as LuaFunction);
					this.m_PlayerSignUpdateEnd_hotfix = (luaObj.RawGet("PlayerSignUpdateEnd") as LuaFunction);
					this.m_OnHeroItemClickBusinessCardHeroListItemUIController_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_OnHeroInfoPanelSettingButtonClick_hotfix = (luaObj.RawGet("OnHeroInfoPanelSettingButtonClick") as LuaFunction);
					this.m_OnHeroInfoPanelChangeButtonClick_hotfix = (luaObj.RawGet("OnHeroInfoPanelChangeButtonClick") as LuaFunction);
					this.m_OnSetCharPanelConfirmButtonClick_hotfix = (luaObj.RawGet("OnSetCharPanelConfirmButtonClick") as LuaFunction);
					this.m_OnHeroSelectPanelConfirmButtonClick_hotfix = (luaObj.RawGet("OnHeroSelectPanelConfirmButtonClick") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_add_EventOnArClickAction_hotfix = (luaObj.RawGet("add_EventOnArClick") as LuaFunction);
					this.m_remove_EventOnArClickAction_hotfix = (luaObj.RawGet("remove_EventOnArClick") as LuaFunction);
					this.m_add_EventOnReturnAction`1_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction`1_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnLikeAction`1_hotfix = (luaObj.RawGet("add_EventOnLike") as LuaFunction);
					this.m_remove_EventOnLikeAction`1_hotfix = (luaObj.RawGet("remove_EventOnLike") as LuaFunction);
					this.m_add_EventOnChangeSignAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeSign") as LuaFunction);
					this.m_remove_EventOnChangeSignAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeSign") as LuaFunction);
					this.m_add_EventOnUpdateHeroSetAction`1_hotfix = (luaObj.RawGet("add_EventOnUpdateHeroSet") as LuaFunction);
					this.m_remove_EventOnUpdateHeroSetAction`1_hotfix = (luaObj.RawGet("remove_EventOnUpdateHeroSet") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C086 RID: 49286 RVA: 0x0035C894 File Offset: 0x0035AA94
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007A9C RID: 31388
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateController;

		// Token: 0x04007A9D RID: 31389
		[AutoBind("./PlayerInfoPanel/Detail/Title/PlayerImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerHeadIcon;

		// Token: 0x04007A9E RID: 31390
		[AutoBind("./PlayerInfoPanel/Detail/Title/PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x04007A9F RID: 31391
		[AutoBind("./PlayerInfoPanel/Detail/Title/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x04007AA0 RID: 31392
		[AutoBind("./PlayerInfoPanel/Detail/Title/PointValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerPointText;

		// Token: 0x04007AA1 RID: 31393
		[AutoBind("./PlayerInfoPanel/Detail/Title/LikeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLikesCountText;

		// Token: 0x04007AA2 RID: 31394
		[AutoBind("./PlayerInfoPanel/Detail/UnderGroup/RandomToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_randomShowToggle;

		// Token: 0x04007AA3 RID: 31395
		[AutoBind("./PlayerInfoPanel/Detail/GoodImageButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_likeButton;

		// Token: 0x04007AA4 RID: 31396
		[AutoBind("./PlayerInfoPanel/Detail/GoodImageButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_likeUIStateController;

		// Token: 0x04007AA5 RID: 31397
		[AutoBind("./PlayerInfoPanel/Detail/Graphics", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_teamGraphicsParentGameObject;

		// Token: 0x04007AA6 RID: 31398
		[AutoBind("./PlayerInfoPanel/Detail/Graphics/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char0Dummy;

		// Token: 0x04007AA7 RID: 31399
		[AutoBind("./PlayerInfoPanel/Detail/Graphics/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char1Dummy;

		// Token: 0x04007AA8 RID: 31400
		[AutoBind("./PlayerInfoPanel/Detail/Graphics/2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char2Dummy;

		// Token: 0x04007AA9 RID: 31401
		[AutoBind("./PlayerInfoPanel/Detail/Graphics/3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char3Dummy;

		// Token: 0x04007AAA RID: 31402
		[AutoBind("./PlayerInfoPanel/Detail/Graphics/4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char4Dummy;

		// Token: 0x04007AAB RID: 31403
		[AutoBind("./PersonalSign/SignDetailText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerSignText;

		// Token: 0x04007AAC RID: 31404
		[AutoBind("./PersonalSign/SignInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_playerInputField;

		// Token: 0x04007AAD RID: 31405
		[AutoBind("./PersonalSign/ChangeSignButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeSignButton;

		// Token: 0x04007AAE RID: 31406
		[AutoBind("./PersonalPanel/HeroGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroGroupObj;

		// Token: 0x04007AAF RID: 31407
		[AutoBind("./PersonalPanel/AllHeroPower", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerAllHeroPowerText;

		// Token: 0x04007AB0 RID: 31408
		[AutoBind("./PersonalPanel/ReachedAchievement", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerReachedAchievementText;

		// Token: 0x04007AB1 RID: 31409
		[AutoBind("./PersonalPanel/MasterJob", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerMasterJobCountText;

		// Token: 0x04007AB2 RID: 31410
		[AutoBind("./PersonalPanel/Stage", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_stageGoalText;

		// Token: 0x04007AB3 RID: 31411
		[AutoBind("./PersonalPanel/Rift", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_riftGoalText;

		// Token: 0x04007AB4 RID: 31412
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04007AB5 RID: 31413
		[AutoBind("./ARHeroListPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_arHeroListPanel;

		// Token: 0x04007AB6 RID: 31414
		[AutoBind("./PlayerInfoPanel/ARButton", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx m_arButton;

		// Token: 0x04007AB7 RID: 31415
		[AutoBind("./SetPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_setPanelUIStateController;

		// Token: 0x04007AB8 RID: 31416
		[AutoBind("./SetPanel/BlackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_setPanelBGButton;

		// Token: 0x04007AB9 RID: 31417
		[AutoBind("./SetPanel/HeroInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroInfoPanelUIStateController;

		// Token: 0x04007ABA RID: 31418
		[AutoBind("./SetPanel/HeroInfoPanel/SetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroInfoPanelSettingButton;

		// Token: 0x04007ABB RID: 31419
		[AutoBind("./SetPanel/HeroInfoPanel/ChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroInfoPanelChangeButton;

		// Token: 0x04007ABC RID: 31420
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/ArmyImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoArmyImage;

		// Token: 0x04007ABD RID: 31421
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Lv/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoLevelText;

		// Token: 0x04007ABE RID: 31422
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoNameText;

		// Token: 0x04007ABF RID: 31423
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Job/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoJobText;

		// Token: 0x04007AC0 RID: 31424
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Power/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPowerText;

		// Token: 0x04007AC1 RID: 31425
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroInfoGraphicDummy;

		// Token: 0x04007AC2 RID: 31426
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Equip/EquipmentListGroup/Equipment1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipment1Dummy;

		// Token: 0x04007AC3 RID: 31427
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Equip/EquipmentListGroup/Equipment2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipment2Dummy;

		// Token: 0x04007AC4 RID: 31428
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Equip/EquipmentListGroup/Equipment3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipment3Dummy;

		// Token: 0x04007AC5 RID: 31429
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Equip/EquipmentListGroup/Equipment4", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipment4Dummy;

		// Token: 0x04007AC6 RID: 31430
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/HP/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoPropHPImg;

		// Token: 0x04007AC7 RID: 31431
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/DF/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoPropDFImg;

		// Token: 0x04007AC8 RID: 31432
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/AT/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoPropATImg;

		// Token: 0x04007AC9 RID: 31433
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/MagicDF/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoPropMagicDFImg;

		// Token: 0x04007ACA RID: 31434
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/Magic/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoPropMagicImg;

		// Token: 0x04007ACB RID: 31435
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/DEX/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroInfoPropDEXImg;

		// Token: 0x04007ACC RID: 31436
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/HP/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropHPValueText;

		// Token: 0x04007ACD RID: 31437
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/DF/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropDFValueText;

		// Token: 0x04007ACE RID: 31438
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/AT/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropATValueText;

		// Token: 0x04007ACF RID: 31439
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/MagicDF/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropMagicDFValueText;

		// Token: 0x04007AD0 RID: 31440
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/Magic/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropMagicValueText;

		// Token: 0x04007AD1 RID: 31441
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/DEX/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropDEXValueText;

		// Token: 0x04007AD2 RID: 31442
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/HP/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropHPAddText;

		// Token: 0x04007AD3 RID: 31443
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/DF/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropDFAddText;

		// Token: 0x04007AD4 RID: 31444
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/AT/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropATAddText;

		// Token: 0x04007AD5 RID: 31445
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/MagicDF/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropMagicDFAddText;

		// Token: 0x04007AD6 RID: 31446
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/Magic/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropMagicAddText;

		// Token: 0x04007AD7 RID: 31447
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Property/DEX/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroInfoPropDEXAddText;

		// Token: 0x04007AD8 RID: 31448
		[AutoBind("./Prefab/EquipmentItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentItemPrefab;

		// Token: 0x04007AD9 RID: 31449
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipItemDescBGButton;

		// Token: 0x04007ADA RID: 31450
		[AutoBind("./SetPanel/HeroInfoPanel/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_equipItemDescStateController;

		// Token: 0x04007ADB RID: 31451
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescTitleText;

		// Token: 0x04007ADC RID: 31452
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescLvText;

		// Token: 0x04007ADD RID: 31453
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/ExpText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescExpText;

		// Token: 0x04007ADE RID: 31454
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipItemDescIconImage;

		// Token: 0x04007ADF RID: 31455
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipItemDescIconBg;

		// Token: 0x04007AE0 RID: 31456
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescSSREffect;

		// Token: 0x04007AE1 RID: 31457
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/ProgressImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipItemDescProgressImage;

		// Token: 0x04007AE2 RID: 31458
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescStarGroup;

		// Token: 0x04007AE3 RID: 31459
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/EquipLimitContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescEquipLimitContent;

		// Token: 0x04007AE4 RID: 31460
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropContent;

		// Token: 0x04007AE5 RID: 31461
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropATGo;

		// Token: 0x04007AE6 RID: 31462
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropATValueText;

		// Token: 0x04007AE7 RID: 31463
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropDFGo;

		// Token: 0x04007AE8 RID: 31464
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropDFValueText;

		// Token: 0x04007AE9 RID: 31465
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropHPGo;

		// Token: 0x04007AEA RID: 31466
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropHPValueText;

		// Token: 0x04007AEB RID: 31467
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropMagiccGo;

		// Token: 0x04007AEC RID: 31468
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropMagicValueText;

		// Token: 0x04007AED RID: 31469
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropMagicDFGo;

		// Token: 0x04007AEE RID: 31470
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropMagicDFValueText;

		// Token: 0x04007AEF RID: 31471
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/Dex", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescPropDexGo;

		// Token: 0x04007AF0 RID: 31472
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/PropContent/Dex/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescPropDexValueText;

		// Token: 0x04007AF1 RID: 31473
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescSkillContent;

		// Token: 0x04007AF2 RID: 31474
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/SkillContent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillNameText;

		// Token: 0x04007AF3 RID: 31475
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/SkillContent/LvText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillLvText;

		// Token: 0x04007AF4 RID: 31476
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/SkillContent/Owner", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillOwnerText;

		// Token: 0x04007AF5 RID: 31477
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/SkillContent/DescScrollView/Viewport/Content/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_equipItemDescSkillDescText;

		// Token: 0x04007AF6 RID: 31478
		[AutoBind("./SetPanel/HeroInfoPanel/Desc/NotEquipSkillTip", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipItemDescNotEquipSkillTip;

		// Token: 0x04007AF7 RID: 31479
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Talent&Skill/Talent", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_talentIconImage;

		// Token: 0x04007AF8 RID: 31480
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Talent&Skill/Talent", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_talentButton;

		// Token: 0x04007AF9 RID: 31481
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Talent&Skill/HeroSkillItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroCurSkillGroup;

		// Token: 0x04007AFA RID: 31482
		[AutoBind("./SetPanel/HeroInfoPanel/HeroDetailInfo/Talent&Skill/SkillItemDescPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroInfoCurSkillDescPanel;

		// Token: 0x04007AFB RID: 31483
		[AutoBind("./SetPanel/SetCharPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_setCharInfoPanelUIStateController;

		// Token: 0x04007AFC RID: 31484
		[AutoBind("./SetPanel/SetCharPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_setCharInfoPanelConfirmButton;

		// Token: 0x04007AFD RID: 31485
		[AutoBind("./SetPanel/SetCharPanel/CharFace", AutoBindAttribute.InitState.NotInit, false)]
		private Dropdown m_charFaceDropdown;

		// Token: 0x04007AFE RID: 31486
		[AutoBind("./SetPanel/SetCharPanel/CharActive", AutoBindAttribute.InitState.NotInit, false)]
		private Dropdown m_charActiveDropdown;

		// Token: 0x04007AFF RID: 31487
		[AutoBind("./SetPanel/SetCharPanel/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGraphicParentDummy;

		// Token: 0x04007B00 RID: 31488
		[AutoBind("./SetPanel/SetCharPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_charNameText;

		// Token: 0x04007B01 RID: 31489
		[AutoBind("./SetPanel/HeroSelectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroSelectPanelUIStateController;

		// Token: 0x04007B02 RID: 31490
		[AutoBind("./SetPanel/HeroSelectPanel/HeroListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroListContent;

		// Token: 0x04007B03 RID: 31491
		[AutoBind("./SetPanel/HeroSelectPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroSelectPanelConfirmButton;

		// Token: 0x04007B04 RID: 31492
		[AutoBind("./Prefab/HeroListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroListItemPrefab;

		// Token: 0x04007B05 RID: 31493
		[AutoBind("./Prefab/HeroCharItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroCharItemPrefab;

		// Token: 0x04007B06 RID: 31494
		[AutoBind("./Prefab/HeroIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroGroupItemPrefab;

		// Token: 0x04007B07 RID: 31495
		private UISpineGraphic m_currentCharSpineGraphic;

		// Token: 0x04007B08 RID: 31496
		private HeroDirectionType m_currentHeroDirectionType;

		// Token: 0x04007B09 RID: 31497
		private HeroActionType m_currentHeroAnimationType;

		// Token: 0x04007B0A RID: 31498
		private BusinessCard m_businessCard;

		// Token: 0x04007B0B RID: 31499
		private bool m_isMe;

		// Token: 0x04007B0C RID: 31500
		private int m_currentSelectPositionIndex;

		// Token: 0x04007B0D RID: 31501
		private BattleHero m_currentSelectBattleHero;

		// Token: 0x04007B0E RID: 31502
		private List<GameObject> m_skillDummyList = new List<GameObject>();

		// Token: 0x04007B0F RID: 31503
		private List<BusinessCardHeroSet> m_currentHeroSetList = new List<BusinessCardHeroSet>();

		// Token: 0x04007B10 RID: 31504
		private List<BusinessCardUIController.GraphicInfo> m_graphicList = new List<BusinessCardUIController.GraphicInfo>();

		// Token: 0x04007B11 RID: 31505
		private List<Hero> m_heroSortList = new List<Hero>();

		// Token: 0x04007B12 RID: 31506
		private bool[] m_isSelectArray = new bool[5];

		// Token: 0x04007B13 RID: 31507
		private const int HeroTeamMaxCount = 5;

		// Token: 0x04007B14 RID: 31508
		private float m_fDebugReportTime = float.MaxValue;

		// Token: 0x04007B15 RID: 31509
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04007B16 RID: 31510
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007B17 RID: 31511
		[DoNotToLua]
		private BusinessCardUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007B18 RID: 31512
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007B19 RID: 31513
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007B1A RID: 31514
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007B1B RID: 31515
		private LuaFunction m_ShowOpenState_hotfix;

		// Token: 0x04007B1C RID: 31516
		private LuaFunction m_SetPlayerInfoBusinessCardBooleanBooleanBoolean_hotfix;

		// Token: 0x04007B1D RID: 31517
		private LuaFunction m_CheckARState_hotfix;

		// Token: 0x04007B1E RID: 31518
		private LuaFunction m_SetTeamBusinessCardBoolean_hotfix;

		// Token: 0x04007B1F RID: 31519
		private LuaFunction m_OnHeroCharClickBusinessCardHeroCharItemUIController_hotfix;

		// Token: 0x04007B20 RID: 31520
		private LuaFunction m_ClearTeam_hotfix;

		// Token: 0x04007B21 RID: 31521
		private LuaFunction m_SetRandomShowToggleOff_hotfix;

		// Token: 0x04007B22 RID: 31522
		private LuaFunction m_SetHeroInfoPanelBattleHeroBoolean_hotfix;

		// Token: 0x04007B23 RID: 31523
		private LuaFunction m_SetHeroTalentBattleHero_hotfix;

		// Token: 0x04007B24 RID: 31524
		private LuaFunction m_SetHeroPropertyBattleHero_hotfix;

		// Token: 0x04007B25 RID: 31525
		private LuaFunction m_SetCurSelectSkillsBattleHero_hotfix;

		// Token: 0x04007B26 RID: 31526
		private LuaFunction m_OnSkillItemClickHeroSkillItemUIController_hotfix;

		// Token: 0x04007B27 RID: 31527
		private LuaFunction m_OnTalentItemClick_hotfix;

		// Token: 0x04007B28 RID: 31528
		private LuaFunction m_SetEquipmentList;

		// Token: 0x04007B29 RID: 31529
		private LuaFunction m_ClearEquipmentItem_hotfix;

		// Token: 0x04007B2A RID: 31530
		private LuaFunction m_SetEquipmentItemInfoBattleHeroEquipmentGameObject_hotfix;

		// Token: 0x04007B2B RID: 31531
		private LuaFunction m_OnEquipmentItemClickBusinessCardHeroEquipmentItemController_hotfix;

		// Token: 0x04007B2C RID: 31532
		private LuaFunction m_OnEquipmentItemBGButtonClick_hotfix;

		// Token: 0x04007B2D RID: 31533
		private LuaFunction m_SetEquipmentItemDescBattleHeroEquipment_hotfix;

		// Token: 0x04007B2E RID: 31534
		private LuaFunction m_SetPropItemsPropertyModifyTypeInt32Int32Int32_hotfix;

		// Token: 0x04007B2F RID: 31535
		private LuaFunction m_SetCharInfoPanelBattleHeroInt32_hotfix;

		// Token: 0x04007B30 RID: 31536
		private LuaFunction m_OnCharDiretionValueChangedInt32_hotfix;

		// Token: 0x04007B31 RID: 31537
		private LuaFunction m_OnCharAnimationValueChangedInt32_hotfix;

		// Token: 0x04007B32 RID: 31538
		private LuaFunction m_CreateSpineGraphicConfigDataJobConnectionInfoConfigDataModelSkinResourceInfoBooleanHeroDirectionTypeHeroActionType_hotfix;

		// Token: 0x04007B33 RID: 31539
		private LuaFunction m_SetCharActionUISpineGraphicHeroDirectionTypeHeroActionType_hotfix;

		// Token: 0x04007B34 RID: 31540
		private LuaFunction m_SetHeroSelectPanelBusinessCard_hotfix;

		// Token: 0x04007B35 RID: 31541
		private LuaFunction m_HeroListItemCompareHeroHero_hotfix;

		// Token: 0x04007B36 RID: 31542
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04007B37 RID: 31543
		private LuaFunction m_OnLikeButtonClick_hotfix;

		// Token: 0x04007B38 RID: 31544
		private LuaFunction m_OnRandowShowToggleValueChangedBoolean_hotfix;

		// Token: 0x04007B39 RID: 31545
		private LuaFunction m_OnSetPanelBGButtonClick_hotfix;

		// Token: 0x04007B3A RID: 31546
		private LuaFunction m_OnChangeSignButtonClick_hotfix;

		// Token: 0x04007B3B RID: 31547
		private LuaFunction m_OnArButtonClick_hotfix;

		// Token: 0x04007B3C RID: 31548
		private LuaFunction m_OnPlayerSignEditEndInputField_hotfix;

		// Token: 0x04007B3D RID: 31549
		private LuaFunction m_PlayerSignUpdateSuccessString_hotfix;

		// Token: 0x04007B3E RID: 31550
		private LuaFunction m_PlayerSignUpdateEnd_hotfix;

		// Token: 0x04007B3F RID: 31551
		private LuaFunction m_OnHeroItemClickBusinessCardHeroListItemUIController_hotfix;

		// Token: 0x04007B40 RID: 31552
		private LuaFunction m_OnHeroInfoPanelSettingButtonClick_hotfix;

		// Token: 0x04007B41 RID: 31553
		private LuaFunction m_OnHeroInfoPanelChangeButtonClick_hotfix;

		// Token: 0x04007B42 RID: 31554
		private LuaFunction m_OnSetCharPanelConfirmButtonClick_hotfix;

		// Token: 0x04007B43 RID: 31555
		private LuaFunction m_OnHeroSelectPanelConfirmButtonClick_hotfix;

		// Token: 0x04007B44 RID: 31556
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007B45 RID: 31557
		private LuaFunction m_add_EventOnArClickAction_hotfix;

		// Token: 0x04007B46 RID: 31558
		private LuaFunction m_remove_EventOnArClickAction_hotfix;

		// Token: 0x04007B47 RID: 31559
		private LuaFunction m_add_EventOnReturnAction;

		// Token: 0x04007B48 RID: 31560
		private LuaFunction m_remove_EventOnReturnAction;

		// Token: 0x04007B49 RID: 31561
		private LuaFunction m_add_EventOnLikeAction;

		// Token: 0x04007B4A RID: 31562
		private LuaFunction m_remove_EventOnLikeAction;

		// Token: 0x04007B4B RID: 31563
		private LuaFunction m_add_EventOnChangeSignAction;

		// Token: 0x04007B4C RID: 31564
		private LuaFunction m_remove_EventOnChangeSignAction;

		// Token: 0x04007B4D RID: 31565
		private LuaFunction m_add_EventOnUpdateHeroSetAction;

		// Token: 0x04007B4E RID: 31566
		private LuaFunction m_remove_EventOnUpdateHeroSetAction;

		// Token: 0x02000B24 RID: 2852
		[HotFix]
		public class GraphicInfo
		{
			// Token: 0x0600C087 RID: 49287 RVA: 0x0035C8FC File Offset: 0x0035AAFC
			public GraphicInfo(UISpineGraphic graphic, HeroDirectionType directionType, HeroActionType actionType)
			{
				this.m_graphic = graphic;
				this.m_directionType = directionType;
				this.m_actionType = actionType;
			}

			// Token: 0x04007B4F RID: 31567
			public UISpineGraphic m_graphic;

			// Token: 0x04007B50 RID: 31568
			public HeroDirectionType m_directionType;

			// Token: 0x04007B51 RID: 31569
			public HeroActionType m_actionType;
		}

		// Token: 0x02000B25 RID: 2853
		public new class LuaExportHelper
		{
			// Token: 0x0600C088 RID: 49288 RVA: 0x0035C91C File Offset: 0x0035AB1C
			public LuaExportHelper(BusinessCardUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C089 RID: 49289 RVA: 0x0035C92C File Offset: 0x0035AB2C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C08A RID: 49290 RVA: 0x0035C93C File Offset: 0x0035AB3C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C08B RID: 49291 RVA: 0x0035C94C File Offset: 0x0035AB4C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C08C RID: 49292 RVA: 0x0035C95C File Offset: 0x0035AB5C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C08D RID: 49293 RVA: 0x0035C974 File Offset: 0x0035AB74
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C08E RID: 49294 RVA: 0x0035C984 File Offset: 0x0035AB84
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C08F RID: 49295 RVA: 0x0035C994 File Offset: 0x0035AB94
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C090 RID: 49296 RVA: 0x0035C9A4 File Offset: 0x0035ABA4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C091 RID: 49297 RVA: 0x0035C9B4 File Offset: 0x0035ABB4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C092 RID: 49298 RVA: 0x0035C9C4 File Offset: 0x0035ABC4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C093 RID: 49299 RVA: 0x0035C9D4 File Offset: 0x0035ABD4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C094 RID: 49300 RVA: 0x0035C9E4 File Offset: 0x0035ABE4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C095 RID: 49301 RVA: 0x0035C9F4 File Offset: 0x0035ABF4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C096 RID: 49302 RVA: 0x0035CA04 File Offset: 0x0035AC04
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C097 RID: 49303 RVA: 0x0035CA14 File Offset: 0x0035AC14
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C098 RID: 49304 RVA: 0x0035CA24 File Offset: 0x0035AC24
			public void __callDele_EventOnArClick()
			{
				this.m_owner.__callDele_EventOnArClick();
			}

			// Token: 0x0600C099 RID: 49305 RVA: 0x0035CA34 File Offset: 0x0035AC34
			public void __clearDele_EventOnArClick()
			{
				this.m_owner.__clearDele_EventOnArClick();
			}

			// Token: 0x0600C09A RID: 49306 RVA: 0x0035CA44 File Offset: 0x0035AC44
			public void __callDele_EventOnReturn(bool obj)
			{
				this.m_owner.__callDele_EventOnReturn(obj);
			}

			// Token: 0x0600C09B RID: 49307 RVA: 0x0035CA54 File Offset: 0x0035AC54
			public void __clearDele_EventOnReturn(bool obj)
			{
				this.m_owner.__clearDele_EventOnReturn(obj);
			}

			// Token: 0x0600C09C RID: 49308 RVA: 0x0035CA64 File Offset: 0x0035AC64
			public void __callDele_EventOnLike(string obj)
			{
				this.m_owner.__callDele_EventOnLike(obj);
			}

			// Token: 0x0600C09D RID: 49309 RVA: 0x0035CA74 File Offset: 0x0035AC74
			public void __clearDele_EventOnLike(string obj)
			{
				this.m_owner.__clearDele_EventOnLike(obj);
			}

			// Token: 0x0600C09E RID: 49310 RVA: 0x0035CA84 File Offset: 0x0035AC84
			public void __callDele_EventOnChangeSign(string obj)
			{
				this.m_owner.__callDele_EventOnChangeSign(obj);
			}

			// Token: 0x0600C09F RID: 49311 RVA: 0x0035CA94 File Offset: 0x0035AC94
			public void __clearDele_EventOnChangeSign(string obj)
			{
				this.m_owner.__clearDele_EventOnChangeSign(obj);
			}

			// Token: 0x0600C0A0 RID: 49312 RVA: 0x0035CAA4 File Offset: 0x0035ACA4
			public void __callDele_EventOnUpdateHeroSet(List<BusinessCardHeroSet> obj)
			{
				this.m_owner.__callDele_EventOnUpdateHeroSet(obj);
			}

			// Token: 0x0600C0A1 RID: 49313 RVA: 0x0035CAB4 File Offset: 0x0035ACB4
			public void __clearDele_EventOnUpdateHeroSet(List<BusinessCardHeroSet> obj)
			{
				this.m_owner.__clearDele_EventOnUpdateHeroSet(obj);
			}

			// Token: 0x17002687 RID: 9863
			// (get) Token: 0x0600C0A2 RID: 49314 RVA: 0x0035CAC4 File Offset: 0x0035ACC4
			// (set) Token: 0x0600C0A3 RID: 49315 RVA: 0x0035CAD4 File Offset: 0x0035ACD4
			public CommonUIStateController m_commonUIStateController
			{
				get
				{
					return this.m_owner.m_commonUIStateController;
				}
				set
				{
					this.m_owner.m_commonUIStateController = value;
				}
			}

			// Token: 0x17002688 RID: 9864
			// (get) Token: 0x0600C0A4 RID: 49316 RVA: 0x0035CAE4 File Offset: 0x0035ACE4
			// (set) Token: 0x0600C0A5 RID: 49317 RVA: 0x0035CAF4 File Offset: 0x0035ACF4
			public Image m_playerHeadIcon
			{
				get
				{
					return this.m_owner.m_playerHeadIcon;
				}
				set
				{
					this.m_owner.m_playerHeadIcon = value;
				}
			}

			// Token: 0x17002689 RID: 9865
			// (get) Token: 0x0600C0A6 RID: 49318 RVA: 0x0035CB04 File Offset: 0x0035AD04
			// (set) Token: 0x0600C0A7 RID: 49319 RVA: 0x0035CB14 File Offset: 0x0035AD14
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x1700268A RID: 9866
			// (get) Token: 0x0600C0A8 RID: 49320 RVA: 0x0035CB24 File Offset: 0x0035AD24
			// (set) Token: 0x0600C0A9 RID: 49321 RVA: 0x0035CB34 File Offset: 0x0035AD34
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x1700268B RID: 9867
			// (get) Token: 0x0600C0AA RID: 49322 RVA: 0x0035CB44 File Offset: 0x0035AD44
			// (set) Token: 0x0600C0AB RID: 49323 RVA: 0x0035CB54 File Offset: 0x0035AD54
			public Text m_playerPointText
			{
				get
				{
					return this.m_owner.m_playerPointText;
				}
				set
				{
					this.m_owner.m_playerPointText = value;
				}
			}

			// Token: 0x1700268C RID: 9868
			// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x0035CB64 File Offset: 0x0035AD64
			// (set) Token: 0x0600C0AD RID: 49325 RVA: 0x0035CB74 File Offset: 0x0035AD74
			public Text m_playerLikesCountText
			{
				get
				{
					return this.m_owner.m_playerLikesCountText;
				}
				set
				{
					this.m_owner.m_playerLikesCountText = value;
				}
			}

			// Token: 0x1700268D RID: 9869
			// (get) Token: 0x0600C0AE RID: 49326 RVA: 0x0035CB84 File Offset: 0x0035AD84
			// (set) Token: 0x0600C0AF RID: 49327 RVA: 0x0035CB94 File Offset: 0x0035AD94
			public Toggle m_randomShowToggle
			{
				get
				{
					return this.m_owner.m_randomShowToggle;
				}
				set
				{
					this.m_owner.m_randomShowToggle = value;
				}
			}

			// Token: 0x1700268E RID: 9870
			// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x0035CBA4 File Offset: 0x0035ADA4
			// (set) Token: 0x0600C0B1 RID: 49329 RVA: 0x0035CBB4 File Offset: 0x0035ADB4
			public Button m_likeButton
			{
				get
				{
					return this.m_owner.m_likeButton;
				}
				set
				{
					this.m_owner.m_likeButton = value;
				}
			}

			// Token: 0x1700268F RID: 9871
			// (get) Token: 0x0600C0B2 RID: 49330 RVA: 0x0035CBC4 File Offset: 0x0035ADC4
			// (set) Token: 0x0600C0B3 RID: 49331 RVA: 0x0035CBD4 File Offset: 0x0035ADD4
			public CommonUIStateController m_likeUIStateController
			{
				get
				{
					return this.m_owner.m_likeUIStateController;
				}
				set
				{
					this.m_owner.m_likeUIStateController = value;
				}
			}

			// Token: 0x17002690 RID: 9872
			// (get) Token: 0x0600C0B4 RID: 49332 RVA: 0x0035CBE4 File Offset: 0x0035ADE4
			// (set) Token: 0x0600C0B5 RID: 49333 RVA: 0x0035CBF4 File Offset: 0x0035ADF4
			public GameObject m_teamGraphicsParentGameObject
			{
				get
				{
					return this.m_owner.m_teamGraphicsParentGameObject;
				}
				set
				{
					this.m_owner.m_teamGraphicsParentGameObject = value;
				}
			}

			// Token: 0x17002691 RID: 9873
			// (get) Token: 0x0600C0B6 RID: 49334 RVA: 0x0035CC04 File Offset: 0x0035AE04
			// (set) Token: 0x0600C0B7 RID: 49335 RVA: 0x0035CC14 File Offset: 0x0035AE14
			public GameObject m_char0Dummy
			{
				get
				{
					return this.m_owner.m_char0Dummy;
				}
				set
				{
					this.m_owner.m_char0Dummy = value;
				}
			}

			// Token: 0x17002692 RID: 9874
			// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x0035CC24 File Offset: 0x0035AE24
			// (set) Token: 0x0600C0B9 RID: 49337 RVA: 0x0035CC34 File Offset: 0x0035AE34
			public GameObject m_char1Dummy
			{
				get
				{
					return this.m_owner.m_char1Dummy;
				}
				set
				{
					this.m_owner.m_char1Dummy = value;
				}
			}

			// Token: 0x17002693 RID: 9875
			// (get) Token: 0x0600C0BA RID: 49338 RVA: 0x0035CC44 File Offset: 0x0035AE44
			// (set) Token: 0x0600C0BB RID: 49339 RVA: 0x0035CC54 File Offset: 0x0035AE54
			public GameObject m_char2Dummy
			{
				get
				{
					return this.m_owner.m_char2Dummy;
				}
				set
				{
					this.m_owner.m_char2Dummy = value;
				}
			}

			// Token: 0x17002694 RID: 9876
			// (get) Token: 0x0600C0BC RID: 49340 RVA: 0x0035CC64 File Offset: 0x0035AE64
			// (set) Token: 0x0600C0BD RID: 49341 RVA: 0x0035CC74 File Offset: 0x0035AE74
			public GameObject m_char3Dummy
			{
				get
				{
					return this.m_owner.m_char3Dummy;
				}
				set
				{
					this.m_owner.m_char3Dummy = value;
				}
			}

			// Token: 0x17002695 RID: 9877
			// (get) Token: 0x0600C0BE RID: 49342 RVA: 0x0035CC84 File Offset: 0x0035AE84
			// (set) Token: 0x0600C0BF RID: 49343 RVA: 0x0035CC94 File Offset: 0x0035AE94
			public GameObject m_char4Dummy
			{
				get
				{
					return this.m_owner.m_char4Dummy;
				}
				set
				{
					this.m_owner.m_char4Dummy = value;
				}
			}

			// Token: 0x17002696 RID: 9878
			// (get) Token: 0x0600C0C0 RID: 49344 RVA: 0x0035CCA4 File Offset: 0x0035AEA4
			// (set) Token: 0x0600C0C1 RID: 49345 RVA: 0x0035CCB4 File Offset: 0x0035AEB4
			public Text m_playerSignText
			{
				get
				{
					return this.m_owner.m_playerSignText;
				}
				set
				{
					this.m_owner.m_playerSignText = value;
				}
			}

			// Token: 0x17002697 RID: 9879
			// (get) Token: 0x0600C0C2 RID: 49346 RVA: 0x0035CCC4 File Offset: 0x0035AEC4
			// (set) Token: 0x0600C0C3 RID: 49347 RVA: 0x0035CCD4 File Offset: 0x0035AED4
			public InputField m_playerInputField
			{
				get
				{
					return this.m_owner.m_playerInputField;
				}
				set
				{
					this.m_owner.m_playerInputField = value;
				}
			}

			// Token: 0x17002698 RID: 9880
			// (get) Token: 0x0600C0C4 RID: 49348 RVA: 0x0035CCE4 File Offset: 0x0035AEE4
			// (set) Token: 0x0600C0C5 RID: 49349 RVA: 0x0035CCF4 File Offset: 0x0035AEF4
			public Button m_changeSignButton
			{
				get
				{
					return this.m_owner.m_changeSignButton;
				}
				set
				{
					this.m_owner.m_changeSignButton = value;
				}
			}

			// Token: 0x17002699 RID: 9881
			// (get) Token: 0x0600C0C6 RID: 49350 RVA: 0x0035CD04 File Offset: 0x0035AF04
			// (set) Token: 0x0600C0C7 RID: 49351 RVA: 0x0035CD14 File Offset: 0x0035AF14
			public GameObject m_heroGroupObj
			{
				get
				{
					return this.m_owner.m_heroGroupObj;
				}
				set
				{
					this.m_owner.m_heroGroupObj = value;
				}
			}

			// Token: 0x1700269A RID: 9882
			// (get) Token: 0x0600C0C8 RID: 49352 RVA: 0x0035CD24 File Offset: 0x0035AF24
			// (set) Token: 0x0600C0C9 RID: 49353 RVA: 0x0035CD34 File Offset: 0x0035AF34
			public Text m_playerAllHeroPowerText
			{
				get
				{
					return this.m_owner.m_playerAllHeroPowerText;
				}
				set
				{
					this.m_owner.m_playerAllHeroPowerText = value;
				}
			}

			// Token: 0x1700269B RID: 9883
			// (get) Token: 0x0600C0CA RID: 49354 RVA: 0x0035CD44 File Offset: 0x0035AF44
			// (set) Token: 0x0600C0CB RID: 49355 RVA: 0x0035CD54 File Offset: 0x0035AF54
			public Text m_playerReachedAchievementText
			{
				get
				{
					return this.m_owner.m_playerReachedAchievementText;
				}
				set
				{
					this.m_owner.m_playerReachedAchievementText = value;
				}
			}

			// Token: 0x1700269C RID: 9884
			// (get) Token: 0x0600C0CC RID: 49356 RVA: 0x0035CD64 File Offset: 0x0035AF64
			// (set) Token: 0x0600C0CD RID: 49357 RVA: 0x0035CD74 File Offset: 0x0035AF74
			public Text m_playerMasterJobCountText
			{
				get
				{
					return this.m_owner.m_playerMasterJobCountText;
				}
				set
				{
					this.m_owner.m_playerMasterJobCountText = value;
				}
			}

			// Token: 0x1700269D RID: 9885
			// (get) Token: 0x0600C0CE RID: 49358 RVA: 0x0035CD84 File Offset: 0x0035AF84
			// (set) Token: 0x0600C0CF RID: 49359 RVA: 0x0035CD94 File Offset: 0x0035AF94
			public Text m_stageGoalText
			{
				get
				{
					return this.m_owner.m_stageGoalText;
				}
				set
				{
					this.m_owner.m_stageGoalText = value;
				}
			}

			// Token: 0x1700269E RID: 9886
			// (get) Token: 0x0600C0D0 RID: 49360 RVA: 0x0035CDA4 File Offset: 0x0035AFA4
			// (set) Token: 0x0600C0D1 RID: 49361 RVA: 0x0035CDB4 File Offset: 0x0035AFB4
			public Text m_riftGoalText
			{
				get
				{
					return this.m_owner.m_riftGoalText;
				}
				set
				{
					this.m_owner.m_riftGoalText = value;
				}
			}

			// Token: 0x1700269F RID: 9887
			// (get) Token: 0x0600C0D2 RID: 49362 RVA: 0x0035CDC4 File Offset: 0x0035AFC4
			// (set) Token: 0x0600C0D3 RID: 49363 RVA: 0x0035CDD4 File Offset: 0x0035AFD4
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

			// Token: 0x170026A0 RID: 9888
			// (get) Token: 0x0600C0D4 RID: 49364 RVA: 0x0035CDE4 File Offset: 0x0035AFE4
			// (set) Token: 0x0600C0D5 RID: 49365 RVA: 0x0035CDF4 File Offset: 0x0035AFF4
			public GameObject m_arHeroListPanel
			{
				get
				{
					return this.m_owner.m_arHeroListPanel;
				}
				set
				{
					this.m_owner.m_arHeroListPanel = value;
				}
			}

			// Token: 0x170026A1 RID: 9889
			// (get) Token: 0x0600C0D6 RID: 49366 RVA: 0x0035CE04 File Offset: 0x0035B004
			// (set) Token: 0x0600C0D7 RID: 49367 RVA: 0x0035CE14 File Offset: 0x0035B014
			public ButtonEx m_arButton
			{
				get
				{
					return this.m_owner.m_arButton;
				}
				set
				{
					this.m_owner.m_arButton = value;
				}
			}

			// Token: 0x170026A2 RID: 9890
			// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x0035CE24 File Offset: 0x0035B024
			// (set) Token: 0x0600C0D9 RID: 49369 RVA: 0x0035CE34 File Offset: 0x0035B034
			public CommonUIStateController m_setPanelUIStateController
			{
				get
				{
					return this.m_owner.m_setPanelUIStateController;
				}
				set
				{
					this.m_owner.m_setPanelUIStateController = value;
				}
			}

			// Token: 0x170026A3 RID: 9891
			// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x0035CE44 File Offset: 0x0035B044
			// (set) Token: 0x0600C0DB RID: 49371 RVA: 0x0035CE54 File Offset: 0x0035B054
			public Button m_setPanelBGButton
			{
				get
				{
					return this.m_owner.m_setPanelBGButton;
				}
				set
				{
					this.m_owner.m_setPanelBGButton = value;
				}
			}

			// Token: 0x170026A4 RID: 9892
			// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x0035CE64 File Offset: 0x0035B064
			// (set) Token: 0x0600C0DD RID: 49373 RVA: 0x0035CE74 File Offset: 0x0035B074
			public CommonUIStateController m_heroInfoPanelUIStateController
			{
				get
				{
					return this.m_owner.m_heroInfoPanelUIStateController;
				}
				set
				{
					this.m_owner.m_heroInfoPanelUIStateController = value;
				}
			}

			// Token: 0x170026A5 RID: 9893
			// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x0035CE84 File Offset: 0x0035B084
			// (set) Token: 0x0600C0DF RID: 49375 RVA: 0x0035CE94 File Offset: 0x0035B094
			public Button m_heroInfoPanelSettingButton
			{
				get
				{
					return this.m_owner.m_heroInfoPanelSettingButton;
				}
				set
				{
					this.m_owner.m_heroInfoPanelSettingButton = value;
				}
			}

			// Token: 0x170026A6 RID: 9894
			// (get) Token: 0x0600C0E0 RID: 49376 RVA: 0x0035CEA4 File Offset: 0x0035B0A4
			// (set) Token: 0x0600C0E1 RID: 49377 RVA: 0x0035CEB4 File Offset: 0x0035B0B4
			public Button m_heroInfoPanelChangeButton
			{
				get
				{
					return this.m_owner.m_heroInfoPanelChangeButton;
				}
				set
				{
					this.m_owner.m_heroInfoPanelChangeButton = value;
				}
			}

			// Token: 0x170026A7 RID: 9895
			// (get) Token: 0x0600C0E2 RID: 49378 RVA: 0x0035CEC4 File Offset: 0x0035B0C4
			// (set) Token: 0x0600C0E3 RID: 49379 RVA: 0x0035CED4 File Offset: 0x0035B0D4
			public Image m_heroInfoArmyImage
			{
				get
				{
					return this.m_owner.m_heroInfoArmyImage;
				}
				set
				{
					this.m_owner.m_heroInfoArmyImage = value;
				}
			}

			// Token: 0x170026A8 RID: 9896
			// (get) Token: 0x0600C0E4 RID: 49380 RVA: 0x0035CEE4 File Offset: 0x0035B0E4
			// (set) Token: 0x0600C0E5 RID: 49381 RVA: 0x0035CEF4 File Offset: 0x0035B0F4
			public Text m_heroInfoLevelText
			{
				get
				{
					return this.m_owner.m_heroInfoLevelText;
				}
				set
				{
					this.m_owner.m_heroInfoLevelText = value;
				}
			}

			// Token: 0x170026A9 RID: 9897
			// (get) Token: 0x0600C0E6 RID: 49382 RVA: 0x0035CF04 File Offset: 0x0035B104
			// (set) Token: 0x0600C0E7 RID: 49383 RVA: 0x0035CF14 File Offset: 0x0035B114
			public Text m_heroInfoNameText
			{
				get
				{
					return this.m_owner.m_heroInfoNameText;
				}
				set
				{
					this.m_owner.m_heroInfoNameText = value;
				}
			}

			// Token: 0x170026AA RID: 9898
			// (get) Token: 0x0600C0E8 RID: 49384 RVA: 0x0035CF24 File Offset: 0x0035B124
			// (set) Token: 0x0600C0E9 RID: 49385 RVA: 0x0035CF34 File Offset: 0x0035B134
			public Text m_heroInfoJobText
			{
				get
				{
					return this.m_owner.m_heroInfoJobText;
				}
				set
				{
					this.m_owner.m_heroInfoJobText = value;
				}
			}

			// Token: 0x170026AB RID: 9899
			// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x0035CF44 File Offset: 0x0035B144
			// (set) Token: 0x0600C0EB RID: 49387 RVA: 0x0035CF54 File Offset: 0x0035B154
			public Text m_heroInfoPowerText
			{
				get
				{
					return this.m_owner.m_heroInfoPowerText;
				}
				set
				{
					this.m_owner.m_heroInfoPowerText = value;
				}
			}

			// Token: 0x170026AC RID: 9900
			// (get) Token: 0x0600C0EC RID: 49388 RVA: 0x0035CF64 File Offset: 0x0035B164
			// (set) Token: 0x0600C0ED RID: 49389 RVA: 0x0035CF74 File Offset: 0x0035B174
			public GameObject m_heroInfoGraphicDummy
			{
				get
				{
					return this.m_owner.m_heroInfoGraphicDummy;
				}
				set
				{
					this.m_owner.m_heroInfoGraphicDummy = value;
				}
			}

			// Token: 0x170026AD RID: 9901
			// (get) Token: 0x0600C0EE RID: 49390 RVA: 0x0035CF84 File Offset: 0x0035B184
			// (set) Token: 0x0600C0EF RID: 49391 RVA: 0x0035CF94 File Offset: 0x0035B194
			public GameObject m_equipment1Dummy
			{
				get
				{
					return this.m_owner.m_equipment1Dummy;
				}
				set
				{
					this.m_owner.m_equipment1Dummy = value;
				}
			}

			// Token: 0x170026AE RID: 9902
			// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x0035CFA4 File Offset: 0x0035B1A4
			// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x0035CFB4 File Offset: 0x0035B1B4
			public GameObject m_equipment2Dummy
			{
				get
				{
					return this.m_owner.m_equipment2Dummy;
				}
				set
				{
					this.m_owner.m_equipment2Dummy = value;
				}
			}

			// Token: 0x170026AF RID: 9903
			// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x0035CFC4 File Offset: 0x0035B1C4
			// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x0035CFD4 File Offset: 0x0035B1D4
			public GameObject m_equipment3Dummy
			{
				get
				{
					return this.m_owner.m_equipment3Dummy;
				}
				set
				{
					this.m_owner.m_equipment3Dummy = value;
				}
			}

			// Token: 0x170026B0 RID: 9904
			// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x0035CFE4 File Offset: 0x0035B1E4
			// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x0035CFF4 File Offset: 0x0035B1F4
			public GameObject m_equipment4Dummy
			{
				get
				{
					return this.m_owner.m_equipment4Dummy;
				}
				set
				{
					this.m_owner.m_equipment4Dummy = value;
				}
			}

			// Token: 0x170026B1 RID: 9905
			// (get) Token: 0x0600C0F6 RID: 49398 RVA: 0x0035D004 File Offset: 0x0035B204
			// (set) Token: 0x0600C0F7 RID: 49399 RVA: 0x0035D014 File Offset: 0x0035B214
			public Image m_heroInfoPropHPImg
			{
				get
				{
					return this.m_owner.m_heroInfoPropHPImg;
				}
				set
				{
					this.m_owner.m_heroInfoPropHPImg = value;
				}
			}

			// Token: 0x170026B2 RID: 9906
			// (get) Token: 0x0600C0F8 RID: 49400 RVA: 0x0035D024 File Offset: 0x0035B224
			// (set) Token: 0x0600C0F9 RID: 49401 RVA: 0x0035D034 File Offset: 0x0035B234
			public Image m_heroInfoPropDFImg
			{
				get
				{
					return this.m_owner.m_heroInfoPropDFImg;
				}
				set
				{
					this.m_owner.m_heroInfoPropDFImg = value;
				}
			}

			// Token: 0x170026B3 RID: 9907
			// (get) Token: 0x0600C0FA RID: 49402 RVA: 0x0035D044 File Offset: 0x0035B244
			// (set) Token: 0x0600C0FB RID: 49403 RVA: 0x0035D054 File Offset: 0x0035B254
			public Image m_heroInfoPropATImg
			{
				get
				{
					return this.m_owner.m_heroInfoPropATImg;
				}
				set
				{
					this.m_owner.m_heroInfoPropATImg = value;
				}
			}

			// Token: 0x170026B4 RID: 9908
			// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x0035D064 File Offset: 0x0035B264
			// (set) Token: 0x0600C0FD RID: 49405 RVA: 0x0035D074 File Offset: 0x0035B274
			public Image m_heroInfoPropMagicDFImg
			{
				get
				{
					return this.m_owner.m_heroInfoPropMagicDFImg;
				}
				set
				{
					this.m_owner.m_heroInfoPropMagicDFImg = value;
				}
			}

			// Token: 0x170026B5 RID: 9909
			// (get) Token: 0x0600C0FE RID: 49406 RVA: 0x0035D084 File Offset: 0x0035B284
			// (set) Token: 0x0600C0FF RID: 49407 RVA: 0x0035D094 File Offset: 0x0035B294
			public Image m_heroInfoPropMagicImg
			{
				get
				{
					return this.m_owner.m_heroInfoPropMagicImg;
				}
				set
				{
					this.m_owner.m_heroInfoPropMagicImg = value;
				}
			}

			// Token: 0x170026B6 RID: 9910
			// (get) Token: 0x0600C100 RID: 49408 RVA: 0x0035D0A4 File Offset: 0x0035B2A4
			// (set) Token: 0x0600C101 RID: 49409 RVA: 0x0035D0B4 File Offset: 0x0035B2B4
			public Image m_heroInfoPropDEXImg
			{
				get
				{
					return this.m_owner.m_heroInfoPropDEXImg;
				}
				set
				{
					this.m_owner.m_heroInfoPropDEXImg = value;
				}
			}

			// Token: 0x170026B7 RID: 9911
			// (get) Token: 0x0600C102 RID: 49410 RVA: 0x0035D0C4 File Offset: 0x0035B2C4
			// (set) Token: 0x0600C103 RID: 49411 RVA: 0x0035D0D4 File Offset: 0x0035B2D4
			public Text m_heroInfoPropHPValueText
			{
				get
				{
					return this.m_owner.m_heroInfoPropHPValueText;
				}
				set
				{
					this.m_owner.m_heroInfoPropHPValueText = value;
				}
			}

			// Token: 0x170026B8 RID: 9912
			// (get) Token: 0x0600C104 RID: 49412 RVA: 0x0035D0E4 File Offset: 0x0035B2E4
			// (set) Token: 0x0600C105 RID: 49413 RVA: 0x0035D0F4 File Offset: 0x0035B2F4
			public Text m_heroInfoPropDFValueText
			{
				get
				{
					return this.m_owner.m_heroInfoPropDFValueText;
				}
				set
				{
					this.m_owner.m_heroInfoPropDFValueText = value;
				}
			}

			// Token: 0x170026B9 RID: 9913
			// (get) Token: 0x0600C106 RID: 49414 RVA: 0x0035D104 File Offset: 0x0035B304
			// (set) Token: 0x0600C107 RID: 49415 RVA: 0x0035D114 File Offset: 0x0035B314
			public Text m_heroInfoPropATValueText
			{
				get
				{
					return this.m_owner.m_heroInfoPropATValueText;
				}
				set
				{
					this.m_owner.m_heroInfoPropATValueText = value;
				}
			}

			// Token: 0x170026BA RID: 9914
			// (get) Token: 0x0600C108 RID: 49416 RVA: 0x0035D124 File Offset: 0x0035B324
			// (set) Token: 0x0600C109 RID: 49417 RVA: 0x0035D134 File Offset: 0x0035B334
			public Text m_heroInfoPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_heroInfoPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_heroInfoPropMagicDFValueText = value;
				}
			}

			// Token: 0x170026BB RID: 9915
			// (get) Token: 0x0600C10A RID: 49418 RVA: 0x0035D144 File Offset: 0x0035B344
			// (set) Token: 0x0600C10B RID: 49419 RVA: 0x0035D154 File Offset: 0x0035B354
			public Text m_heroInfoPropMagicValueText
			{
				get
				{
					return this.m_owner.m_heroInfoPropMagicValueText;
				}
				set
				{
					this.m_owner.m_heroInfoPropMagicValueText = value;
				}
			}

			// Token: 0x170026BC RID: 9916
			// (get) Token: 0x0600C10C RID: 49420 RVA: 0x0035D164 File Offset: 0x0035B364
			// (set) Token: 0x0600C10D RID: 49421 RVA: 0x0035D174 File Offset: 0x0035B374
			public Text m_heroInfoPropDEXValueText
			{
				get
				{
					return this.m_owner.m_heroInfoPropDEXValueText;
				}
				set
				{
					this.m_owner.m_heroInfoPropDEXValueText = value;
				}
			}

			// Token: 0x170026BD RID: 9917
			// (get) Token: 0x0600C10E RID: 49422 RVA: 0x0035D184 File Offset: 0x0035B384
			// (set) Token: 0x0600C10F RID: 49423 RVA: 0x0035D194 File Offset: 0x0035B394
			public Text m_heroInfoPropHPAddText
			{
				get
				{
					return this.m_owner.m_heroInfoPropHPAddText;
				}
				set
				{
					this.m_owner.m_heroInfoPropHPAddText = value;
				}
			}

			// Token: 0x170026BE RID: 9918
			// (get) Token: 0x0600C110 RID: 49424 RVA: 0x0035D1A4 File Offset: 0x0035B3A4
			// (set) Token: 0x0600C111 RID: 49425 RVA: 0x0035D1B4 File Offset: 0x0035B3B4
			public Text m_heroInfoPropDFAddText
			{
				get
				{
					return this.m_owner.m_heroInfoPropDFAddText;
				}
				set
				{
					this.m_owner.m_heroInfoPropDFAddText = value;
				}
			}

			// Token: 0x170026BF RID: 9919
			// (get) Token: 0x0600C112 RID: 49426 RVA: 0x0035D1C4 File Offset: 0x0035B3C4
			// (set) Token: 0x0600C113 RID: 49427 RVA: 0x0035D1D4 File Offset: 0x0035B3D4
			public Text m_heroInfoPropATAddText
			{
				get
				{
					return this.m_owner.m_heroInfoPropATAddText;
				}
				set
				{
					this.m_owner.m_heroInfoPropATAddText = value;
				}
			}

			// Token: 0x170026C0 RID: 9920
			// (get) Token: 0x0600C114 RID: 49428 RVA: 0x0035D1E4 File Offset: 0x0035B3E4
			// (set) Token: 0x0600C115 RID: 49429 RVA: 0x0035D1F4 File Offset: 0x0035B3F4
			public Text m_heroInfoPropMagicDFAddText
			{
				get
				{
					return this.m_owner.m_heroInfoPropMagicDFAddText;
				}
				set
				{
					this.m_owner.m_heroInfoPropMagicDFAddText = value;
				}
			}

			// Token: 0x170026C1 RID: 9921
			// (get) Token: 0x0600C116 RID: 49430 RVA: 0x0035D204 File Offset: 0x0035B404
			// (set) Token: 0x0600C117 RID: 49431 RVA: 0x0035D214 File Offset: 0x0035B414
			public Text m_heroInfoPropMagicAddText
			{
				get
				{
					return this.m_owner.m_heroInfoPropMagicAddText;
				}
				set
				{
					this.m_owner.m_heroInfoPropMagicAddText = value;
				}
			}

			// Token: 0x170026C2 RID: 9922
			// (get) Token: 0x0600C118 RID: 49432 RVA: 0x0035D224 File Offset: 0x0035B424
			// (set) Token: 0x0600C119 RID: 49433 RVA: 0x0035D234 File Offset: 0x0035B434
			public Text m_heroInfoPropDEXAddText
			{
				get
				{
					return this.m_owner.m_heroInfoPropDEXAddText;
				}
				set
				{
					this.m_owner.m_heroInfoPropDEXAddText = value;
				}
			}

			// Token: 0x170026C3 RID: 9923
			// (get) Token: 0x0600C11A RID: 49434 RVA: 0x0035D244 File Offset: 0x0035B444
			// (set) Token: 0x0600C11B RID: 49435 RVA: 0x0035D254 File Offset: 0x0035B454
			public GameObject m_equipmentItemPrefab
			{
				get
				{
					return this.m_owner.m_equipmentItemPrefab;
				}
				set
				{
					this.m_owner.m_equipmentItemPrefab = value;
				}
			}

			// Token: 0x170026C4 RID: 9924
			// (get) Token: 0x0600C11C RID: 49436 RVA: 0x0035D264 File Offset: 0x0035B464
			// (set) Token: 0x0600C11D RID: 49437 RVA: 0x0035D274 File Offset: 0x0035B474
			public Button m_equipItemDescBGButton
			{
				get
				{
					return this.m_owner.m_equipItemDescBGButton;
				}
				set
				{
					this.m_owner.m_equipItemDescBGButton = value;
				}
			}

			// Token: 0x170026C5 RID: 9925
			// (get) Token: 0x0600C11E RID: 49438 RVA: 0x0035D284 File Offset: 0x0035B484
			// (set) Token: 0x0600C11F RID: 49439 RVA: 0x0035D294 File Offset: 0x0035B494
			public CommonUIStateController m_equipItemDescStateController
			{
				get
				{
					return this.m_owner.m_equipItemDescStateController;
				}
				set
				{
					this.m_owner.m_equipItemDescStateController = value;
				}
			}

			// Token: 0x170026C6 RID: 9926
			// (get) Token: 0x0600C120 RID: 49440 RVA: 0x0035D2A4 File Offset: 0x0035B4A4
			// (set) Token: 0x0600C121 RID: 49441 RVA: 0x0035D2B4 File Offset: 0x0035B4B4
			public Text m_equipItemDescTitleText
			{
				get
				{
					return this.m_owner.m_equipItemDescTitleText;
				}
				set
				{
					this.m_owner.m_equipItemDescTitleText = value;
				}
			}

			// Token: 0x170026C7 RID: 9927
			// (get) Token: 0x0600C122 RID: 49442 RVA: 0x0035D2C4 File Offset: 0x0035B4C4
			// (set) Token: 0x0600C123 RID: 49443 RVA: 0x0035D2D4 File Offset: 0x0035B4D4
			public Text m_equipItemDescLvText
			{
				get
				{
					return this.m_owner.m_equipItemDescLvText;
				}
				set
				{
					this.m_owner.m_equipItemDescLvText = value;
				}
			}

			// Token: 0x170026C8 RID: 9928
			// (get) Token: 0x0600C124 RID: 49444 RVA: 0x0035D2E4 File Offset: 0x0035B4E4
			// (set) Token: 0x0600C125 RID: 49445 RVA: 0x0035D2F4 File Offset: 0x0035B4F4
			public Text m_equipItemDescExpText
			{
				get
				{
					return this.m_owner.m_equipItemDescExpText;
				}
				set
				{
					this.m_owner.m_equipItemDescExpText = value;
				}
			}

			// Token: 0x170026C9 RID: 9929
			// (get) Token: 0x0600C126 RID: 49446 RVA: 0x0035D304 File Offset: 0x0035B504
			// (set) Token: 0x0600C127 RID: 49447 RVA: 0x0035D314 File Offset: 0x0035B514
			public Image m_equipItemDescIconImage
			{
				get
				{
					return this.m_owner.m_equipItemDescIconImage;
				}
				set
				{
					this.m_owner.m_equipItemDescIconImage = value;
				}
			}

			// Token: 0x170026CA RID: 9930
			// (get) Token: 0x0600C128 RID: 49448 RVA: 0x0035D324 File Offset: 0x0035B524
			// (set) Token: 0x0600C129 RID: 49449 RVA: 0x0035D334 File Offset: 0x0035B534
			public Image m_equipItemDescIconBg
			{
				get
				{
					return this.m_owner.m_equipItemDescIconBg;
				}
				set
				{
					this.m_owner.m_equipItemDescIconBg = value;
				}
			}

			// Token: 0x170026CB RID: 9931
			// (get) Token: 0x0600C12A RID: 49450 RVA: 0x0035D344 File Offset: 0x0035B544
			// (set) Token: 0x0600C12B RID: 49451 RVA: 0x0035D354 File Offset: 0x0035B554
			public GameObject m_equipItemDescSSREffect
			{
				get
				{
					return this.m_owner.m_equipItemDescSSREffect;
				}
				set
				{
					this.m_owner.m_equipItemDescSSREffect = value;
				}
			}

			// Token: 0x170026CC RID: 9932
			// (get) Token: 0x0600C12C RID: 49452 RVA: 0x0035D364 File Offset: 0x0035B564
			// (set) Token: 0x0600C12D RID: 49453 RVA: 0x0035D374 File Offset: 0x0035B574
			public Image m_equipItemDescProgressImage
			{
				get
				{
					return this.m_owner.m_equipItemDescProgressImage;
				}
				set
				{
					this.m_owner.m_equipItemDescProgressImage = value;
				}
			}

			// Token: 0x170026CD RID: 9933
			// (get) Token: 0x0600C12E RID: 49454 RVA: 0x0035D384 File Offset: 0x0035B584
			// (set) Token: 0x0600C12F RID: 49455 RVA: 0x0035D394 File Offset: 0x0035B594
			public GameObject m_equipItemDescStarGroup
			{
				get
				{
					return this.m_owner.m_equipItemDescStarGroup;
				}
				set
				{
					this.m_owner.m_equipItemDescStarGroup = value;
				}
			}

			// Token: 0x170026CE RID: 9934
			// (get) Token: 0x0600C130 RID: 49456 RVA: 0x0035D3A4 File Offset: 0x0035B5A4
			// (set) Token: 0x0600C131 RID: 49457 RVA: 0x0035D3B4 File Offset: 0x0035B5B4
			public GameObject m_equipItemDescEquipLimitContent
			{
				get
				{
					return this.m_owner.m_equipItemDescEquipLimitContent;
				}
				set
				{
					this.m_owner.m_equipItemDescEquipLimitContent = value;
				}
			}

			// Token: 0x170026CF RID: 9935
			// (get) Token: 0x0600C132 RID: 49458 RVA: 0x0035D3C4 File Offset: 0x0035B5C4
			// (set) Token: 0x0600C133 RID: 49459 RVA: 0x0035D3D4 File Offset: 0x0035B5D4
			public GameObject m_equipItemDescPropContent
			{
				get
				{
					return this.m_owner.m_equipItemDescPropContent;
				}
				set
				{
					this.m_owner.m_equipItemDescPropContent = value;
				}
			}

			// Token: 0x170026D0 RID: 9936
			// (get) Token: 0x0600C134 RID: 49460 RVA: 0x0035D3E4 File Offset: 0x0035B5E4
			// (set) Token: 0x0600C135 RID: 49461 RVA: 0x0035D3F4 File Offset: 0x0035B5F4
			public GameObject m_equipItemDescPropATGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropATGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropATGo = value;
				}
			}

			// Token: 0x170026D1 RID: 9937
			// (get) Token: 0x0600C136 RID: 49462 RVA: 0x0035D404 File Offset: 0x0035B604
			// (set) Token: 0x0600C137 RID: 49463 RVA: 0x0035D414 File Offset: 0x0035B614
			public Text m_equipItemDescPropATValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropATValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropATValueText = value;
				}
			}

			// Token: 0x170026D2 RID: 9938
			// (get) Token: 0x0600C138 RID: 49464 RVA: 0x0035D424 File Offset: 0x0035B624
			// (set) Token: 0x0600C139 RID: 49465 RVA: 0x0035D434 File Offset: 0x0035B634
			public GameObject m_equipItemDescPropDFGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDFGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDFGo = value;
				}
			}

			// Token: 0x170026D3 RID: 9939
			// (get) Token: 0x0600C13A RID: 49466 RVA: 0x0035D444 File Offset: 0x0035B644
			// (set) Token: 0x0600C13B RID: 49467 RVA: 0x0035D454 File Offset: 0x0035B654
			public Text m_equipItemDescPropDFValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDFValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDFValueText = value;
				}
			}

			// Token: 0x170026D4 RID: 9940
			// (get) Token: 0x0600C13C RID: 49468 RVA: 0x0035D464 File Offset: 0x0035B664
			// (set) Token: 0x0600C13D RID: 49469 RVA: 0x0035D474 File Offset: 0x0035B674
			public GameObject m_equipItemDescPropHPGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropHPGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropHPGo = value;
				}
			}

			// Token: 0x170026D5 RID: 9941
			// (get) Token: 0x0600C13E RID: 49470 RVA: 0x0035D484 File Offset: 0x0035B684
			// (set) Token: 0x0600C13F RID: 49471 RVA: 0x0035D494 File Offset: 0x0035B694
			public Text m_equipItemDescPropHPValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropHPValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropHPValueText = value;
				}
			}

			// Token: 0x170026D6 RID: 9942
			// (get) Token: 0x0600C140 RID: 49472 RVA: 0x0035D4A4 File Offset: 0x0035B6A4
			// (set) Token: 0x0600C141 RID: 49473 RVA: 0x0035D4B4 File Offset: 0x0035B6B4
			public GameObject m_equipItemDescPropMagiccGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagiccGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagiccGo = value;
				}
			}

			// Token: 0x170026D7 RID: 9943
			// (get) Token: 0x0600C142 RID: 49474 RVA: 0x0035D4C4 File Offset: 0x0035B6C4
			// (set) Token: 0x0600C143 RID: 49475 RVA: 0x0035D4D4 File Offset: 0x0035B6D4
			public Text m_equipItemDescPropMagicValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagicValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagicValueText = value;
				}
			}

			// Token: 0x170026D8 RID: 9944
			// (get) Token: 0x0600C144 RID: 49476 RVA: 0x0035D4E4 File Offset: 0x0035B6E4
			// (set) Token: 0x0600C145 RID: 49477 RVA: 0x0035D4F4 File Offset: 0x0035B6F4
			public GameObject m_equipItemDescPropMagicDFGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagicDFGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagicDFGo = value;
				}
			}

			// Token: 0x170026D9 RID: 9945
			// (get) Token: 0x0600C146 RID: 49478 RVA: 0x0035D504 File Offset: 0x0035B704
			// (set) Token: 0x0600C147 RID: 49479 RVA: 0x0035D514 File Offset: 0x0035B714
			public Text m_equipItemDescPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropMagicDFValueText = value;
				}
			}

			// Token: 0x170026DA RID: 9946
			// (get) Token: 0x0600C148 RID: 49480 RVA: 0x0035D524 File Offset: 0x0035B724
			// (set) Token: 0x0600C149 RID: 49481 RVA: 0x0035D534 File Offset: 0x0035B734
			public GameObject m_equipItemDescPropDexGo
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDexGo;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDexGo = value;
				}
			}

			// Token: 0x170026DB RID: 9947
			// (get) Token: 0x0600C14A RID: 49482 RVA: 0x0035D544 File Offset: 0x0035B744
			// (set) Token: 0x0600C14B RID: 49483 RVA: 0x0035D554 File Offset: 0x0035B754
			public Text m_equipItemDescPropDexValueText
			{
				get
				{
					return this.m_owner.m_equipItemDescPropDexValueText;
				}
				set
				{
					this.m_owner.m_equipItemDescPropDexValueText = value;
				}
			}

			// Token: 0x170026DC RID: 9948
			// (get) Token: 0x0600C14C RID: 49484 RVA: 0x0035D564 File Offset: 0x0035B764
			// (set) Token: 0x0600C14D RID: 49485 RVA: 0x0035D574 File Offset: 0x0035B774
			public GameObject m_equipItemDescSkillContent
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillContent;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillContent = value;
				}
			}

			// Token: 0x170026DD RID: 9949
			// (get) Token: 0x0600C14E RID: 49486 RVA: 0x0035D584 File Offset: 0x0035B784
			// (set) Token: 0x0600C14F RID: 49487 RVA: 0x0035D594 File Offset: 0x0035B794
			public Text m_equipItemDescSkillNameText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillNameText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillNameText = value;
				}
			}

			// Token: 0x170026DE RID: 9950
			// (get) Token: 0x0600C150 RID: 49488 RVA: 0x0035D5A4 File Offset: 0x0035B7A4
			// (set) Token: 0x0600C151 RID: 49489 RVA: 0x0035D5B4 File Offset: 0x0035B7B4
			public Text m_equipItemDescSkillLvText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillLvText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillLvText = value;
				}
			}

			// Token: 0x170026DF RID: 9951
			// (get) Token: 0x0600C152 RID: 49490 RVA: 0x0035D5C4 File Offset: 0x0035B7C4
			// (set) Token: 0x0600C153 RID: 49491 RVA: 0x0035D5D4 File Offset: 0x0035B7D4
			public Text m_equipItemDescSkillOwnerText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillOwnerText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillOwnerText = value;
				}
			}

			// Token: 0x170026E0 RID: 9952
			// (get) Token: 0x0600C154 RID: 49492 RVA: 0x0035D5E4 File Offset: 0x0035B7E4
			// (set) Token: 0x0600C155 RID: 49493 RVA: 0x0035D5F4 File Offset: 0x0035B7F4
			public Text m_equipItemDescSkillDescText
			{
				get
				{
					return this.m_owner.m_equipItemDescSkillDescText;
				}
				set
				{
					this.m_owner.m_equipItemDescSkillDescText = value;
				}
			}

			// Token: 0x170026E1 RID: 9953
			// (get) Token: 0x0600C156 RID: 49494 RVA: 0x0035D604 File Offset: 0x0035B804
			// (set) Token: 0x0600C157 RID: 49495 RVA: 0x0035D614 File Offset: 0x0035B814
			public GameObject m_equipItemDescNotEquipSkillTip
			{
				get
				{
					return this.m_owner.m_equipItemDescNotEquipSkillTip;
				}
				set
				{
					this.m_owner.m_equipItemDescNotEquipSkillTip = value;
				}
			}

			// Token: 0x170026E2 RID: 9954
			// (get) Token: 0x0600C158 RID: 49496 RVA: 0x0035D624 File Offset: 0x0035B824
			// (set) Token: 0x0600C159 RID: 49497 RVA: 0x0035D634 File Offset: 0x0035B834
			public Image m_talentIconImage
			{
				get
				{
					return this.m_owner.m_talentIconImage;
				}
				set
				{
					this.m_owner.m_talentIconImage = value;
				}
			}

			// Token: 0x170026E3 RID: 9955
			// (get) Token: 0x0600C15A RID: 49498 RVA: 0x0035D644 File Offset: 0x0035B844
			// (set) Token: 0x0600C15B RID: 49499 RVA: 0x0035D654 File Offset: 0x0035B854
			public Button m_talentButton
			{
				get
				{
					return this.m_owner.m_talentButton;
				}
				set
				{
					this.m_owner.m_talentButton = value;
				}
			}

			// Token: 0x170026E4 RID: 9956
			// (get) Token: 0x0600C15C RID: 49500 RVA: 0x0035D664 File Offset: 0x0035B864
			// (set) Token: 0x0600C15D RID: 49501 RVA: 0x0035D674 File Offset: 0x0035B874
			public GameObject m_heroCurSkillGroup
			{
				get
				{
					return this.m_owner.m_heroCurSkillGroup;
				}
				set
				{
					this.m_owner.m_heroCurSkillGroup = value;
				}
			}

			// Token: 0x170026E5 RID: 9957
			// (get) Token: 0x0600C15E RID: 49502 RVA: 0x0035D684 File Offset: 0x0035B884
			// (set) Token: 0x0600C15F RID: 49503 RVA: 0x0035D694 File Offset: 0x0035B894
			public GameObject m_heroInfoCurSkillDescPanel
			{
				get
				{
					return this.m_owner.m_heroInfoCurSkillDescPanel;
				}
				set
				{
					this.m_owner.m_heroInfoCurSkillDescPanel = value;
				}
			}

			// Token: 0x170026E6 RID: 9958
			// (get) Token: 0x0600C160 RID: 49504 RVA: 0x0035D6A4 File Offset: 0x0035B8A4
			// (set) Token: 0x0600C161 RID: 49505 RVA: 0x0035D6B4 File Offset: 0x0035B8B4
			public CommonUIStateController m_setCharInfoPanelUIStateController
			{
				get
				{
					return this.m_owner.m_setCharInfoPanelUIStateController;
				}
				set
				{
					this.m_owner.m_setCharInfoPanelUIStateController = value;
				}
			}

			// Token: 0x170026E7 RID: 9959
			// (get) Token: 0x0600C162 RID: 49506 RVA: 0x0035D6C4 File Offset: 0x0035B8C4
			// (set) Token: 0x0600C163 RID: 49507 RVA: 0x0035D6D4 File Offset: 0x0035B8D4
			public Button m_setCharInfoPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_setCharInfoPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_setCharInfoPanelConfirmButton = value;
				}
			}

			// Token: 0x170026E8 RID: 9960
			// (get) Token: 0x0600C164 RID: 49508 RVA: 0x0035D6E4 File Offset: 0x0035B8E4
			// (set) Token: 0x0600C165 RID: 49509 RVA: 0x0035D6F4 File Offset: 0x0035B8F4
			public Dropdown m_charFaceDropdown
			{
				get
				{
					return this.m_owner.m_charFaceDropdown;
				}
				set
				{
					this.m_owner.m_charFaceDropdown = value;
				}
			}

			// Token: 0x170026E9 RID: 9961
			// (get) Token: 0x0600C166 RID: 49510 RVA: 0x0035D704 File Offset: 0x0035B904
			// (set) Token: 0x0600C167 RID: 49511 RVA: 0x0035D714 File Offset: 0x0035B914
			public Dropdown m_charActiveDropdown
			{
				get
				{
					return this.m_owner.m_charActiveDropdown;
				}
				set
				{
					this.m_owner.m_charActiveDropdown = value;
				}
			}

			// Token: 0x170026EA RID: 9962
			// (get) Token: 0x0600C168 RID: 49512 RVA: 0x0035D724 File Offset: 0x0035B924
			// (set) Token: 0x0600C169 RID: 49513 RVA: 0x0035D734 File Offset: 0x0035B934
			public GameObject m_charGraphicParentDummy
			{
				get
				{
					return this.m_owner.m_charGraphicParentDummy;
				}
				set
				{
					this.m_owner.m_charGraphicParentDummy = value;
				}
			}

			// Token: 0x170026EB RID: 9963
			// (get) Token: 0x0600C16A RID: 49514 RVA: 0x0035D744 File Offset: 0x0035B944
			// (set) Token: 0x0600C16B RID: 49515 RVA: 0x0035D754 File Offset: 0x0035B954
			public Text m_charNameText
			{
				get
				{
					return this.m_owner.m_charNameText;
				}
				set
				{
					this.m_owner.m_charNameText = value;
				}
			}

			// Token: 0x170026EC RID: 9964
			// (get) Token: 0x0600C16C RID: 49516 RVA: 0x0035D764 File Offset: 0x0035B964
			// (set) Token: 0x0600C16D RID: 49517 RVA: 0x0035D774 File Offset: 0x0035B974
			public CommonUIStateController m_heroSelectPanelUIStateController
			{
				get
				{
					return this.m_owner.m_heroSelectPanelUIStateController;
				}
				set
				{
					this.m_owner.m_heroSelectPanelUIStateController = value;
				}
			}

			// Token: 0x170026ED RID: 9965
			// (get) Token: 0x0600C16E RID: 49518 RVA: 0x0035D784 File Offset: 0x0035B984
			// (set) Token: 0x0600C16F RID: 49519 RVA: 0x0035D794 File Offset: 0x0035B994
			public GameObject m_heroListContent
			{
				get
				{
					return this.m_owner.m_heroListContent;
				}
				set
				{
					this.m_owner.m_heroListContent = value;
				}
			}

			// Token: 0x170026EE RID: 9966
			// (get) Token: 0x0600C170 RID: 49520 RVA: 0x0035D7A4 File Offset: 0x0035B9A4
			// (set) Token: 0x0600C171 RID: 49521 RVA: 0x0035D7B4 File Offset: 0x0035B9B4
			public Button m_heroSelectPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_heroSelectPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_heroSelectPanelConfirmButton = value;
				}
			}

			// Token: 0x170026EF RID: 9967
			// (get) Token: 0x0600C172 RID: 49522 RVA: 0x0035D7C4 File Offset: 0x0035B9C4
			// (set) Token: 0x0600C173 RID: 49523 RVA: 0x0035D7D4 File Offset: 0x0035B9D4
			public GameObject m_heroListItemPrefab
			{
				get
				{
					return this.m_owner.m_heroListItemPrefab;
				}
				set
				{
					this.m_owner.m_heroListItemPrefab = value;
				}
			}

			// Token: 0x170026F0 RID: 9968
			// (get) Token: 0x0600C174 RID: 49524 RVA: 0x0035D7E4 File Offset: 0x0035B9E4
			// (set) Token: 0x0600C175 RID: 49525 RVA: 0x0035D7F4 File Offset: 0x0035B9F4
			public GameObject m_heroCharItemPrefab
			{
				get
				{
					return this.m_owner.m_heroCharItemPrefab;
				}
				set
				{
					this.m_owner.m_heroCharItemPrefab = value;
				}
			}

			// Token: 0x170026F1 RID: 9969
			// (get) Token: 0x0600C176 RID: 49526 RVA: 0x0035D804 File Offset: 0x0035BA04
			// (set) Token: 0x0600C177 RID: 49527 RVA: 0x0035D814 File Offset: 0x0035BA14
			public GameObject m_heroGroupItemPrefab
			{
				get
				{
					return this.m_owner.m_heroGroupItemPrefab;
				}
				set
				{
					this.m_owner.m_heroGroupItemPrefab = value;
				}
			}

			// Token: 0x170026F2 RID: 9970
			// (get) Token: 0x0600C178 RID: 49528 RVA: 0x0035D824 File Offset: 0x0035BA24
			// (set) Token: 0x0600C179 RID: 49529 RVA: 0x0035D834 File Offset: 0x0035BA34
			public UISpineGraphic m_currentCharSpineGraphic
			{
				get
				{
					return this.m_owner.m_currentCharSpineGraphic;
				}
				set
				{
					this.m_owner.m_currentCharSpineGraphic = value;
				}
			}

			// Token: 0x170026F3 RID: 9971
			// (get) Token: 0x0600C17A RID: 49530 RVA: 0x0035D844 File Offset: 0x0035BA44
			// (set) Token: 0x0600C17B RID: 49531 RVA: 0x0035D854 File Offset: 0x0035BA54
			public HeroDirectionType m_currentHeroDirectionType
			{
				get
				{
					return this.m_owner.m_currentHeroDirectionType;
				}
				set
				{
					this.m_owner.m_currentHeroDirectionType = value;
				}
			}

			// Token: 0x170026F4 RID: 9972
			// (get) Token: 0x0600C17C RID: 49532 RVA: 0x0035D864 File Offset: 0x0035BA64
			// (set) Token: 0x0600C17D RID: 49533 RVA: 0x0035D874 File Offset: 0x0035BA74
			public HeroActionType m_currentHeroAnimationType
			{
				get
				{
					return this.m_owner.m_currentHeroAnimationType;
				}
				set
				{
					this.m_owner.m_currentHeroAnimationType = value;
				}
			}

			// Token: 0x170026F5 RID: 9973
			// (get) Token: 0x0600C17E RID: 49534 RVA: 0x0035D884 File Offset: 0x0035BA84
			// (set) Token: 0x0600C17F RID: 49535 RVA: 0x0035D894 File Offset: 0x0035BA94
			public BusinessCard m_businessCard
			{
				get
				{
					return this.m_owner.m_businessCard;
				}
				set
				{
					this.m_owner.m_businessCard = value;
				}
			}

			// Token: 0x170026F6 RID: 9974
			// (get) Token: 0x0600C180 RID: 49536 RVA: 0x0035D8A4 File Offset: 0x0035BAA4
			// (set) Token: 0x0600C181 RID: 49537 RVA: 0x0035D8B4 File Offset: 0x0035BAB4
			public bool m_isMe
			{
				get
				{
					return this.m_owner.m_isMe;
				}
				set
				{
					this.m_owner.m_isMe = value;
				}
			}

			// Token: 0x170026F7 RID: 9975
			// (get) Token: 0x0600C182 RID: 49538 RVA: 0x0035D8C4 File Offset: 0x0035BAC4
			// (set) Token: 0x0600C183 RID: 49539 RVA: 0x0035D8D4 File Offset: 0x0035BAD4
			public int m_currentSelectPositionIndex
			{
				get
				{
					return this.m_owner.m_currentSelectPositionIndex;
				}
				set
				{
					this.m_owner.m_currentSelectPositionIndex = value;
				}
			}

			// Token: 0x170026F8 RID: 9976
			// (get) Token: 0x0600C184 RID: 49540 RVA: 0x0035D8E4 File Offset: 0x0035BAE4
			// (set) Token: 0x0600C185 RID: 49541 RVA: 0x0035D8F4 File Offset: 0x0035BAF4
			public BattleHero m_currentSelectBattleHero
			{
				get
				{
					return this.m_owner.m_currentSelectBattleHero;
				}
				set
				{
					this.m_owner.m_currentSelectBattleHero = value;
				}
			}

			// Token: 0x170026F9 RID: 9977
			// (get) Token: 0x0600C186 RID: 49542 RVA: 0x0035D904 File Offset: 0x0035BB04
			// (set) Token: 0x0600C187 RID: 49543 RVA: 0x0035D914 File Offset: 0x0035BB14
			public List<GameObject> m_skillDummyList
			{
				get
				{
					return this.m_owner.m_skillDummyList;
				}
				set
				{
					this.m_owner.m_skillDummyList = value;
				}
			}

			// Token: 0x170026FA RID: 9978
			// (get) Token: 0x0600C188 RID: 49544 RVA: 0x0035D924 File Offset: 0x0035BB24
			// (set) Token: 0x0600C189 RID: 49545 RVA: 0x0035D934 File Offset: 0x0035BB34
			public List<BusinessCardHeroSet> m_currentHeroSetList
			{
				get
				{
					return this.m_owner.m_currentHeroSetList;
				}
				set
				{
					this.m_owner.m_currentHeroSetList = value;
				}
			}

			// Token: 0x170026FB RID: 9979
			// (get) Token: 0x0600C18A RID: 49546 RVA: 0x0035D944 File Offset: 0x0035BB44
			// (set) Token: 0x0600C18B RID: 49547 RVA: 0x0035D954 File Offset: 0x0035BB54
			public List<BusinessCardUIController.GraphicInfo> m_graphicList
			{
				get
				{
					return this.m_owner.m_graphicList;
				}
				set
				{
					this.m_owner.m_graphicList = value;
				}
			}

			// Token: 0x170026FC RID: 9980
			// (get) Token: 0x0600C18C RID: 49548 RVA: 0x0035D964 File Offset: 0x0035BB64
			// (set) Token: 0x0600C18D RID: 49549 RVA: 0x0035D974 File Offset: 0x0035BB74
			public List<Hero> m_heroSortList
			{
				get
				{
					return this.m_owner.m_heroSortList;
				}
				set
				{
					this.m_owner.m_heroSortList = value;
				}
			}

			// Token: 0x170026FD RID: 9981
			// (get) Token: 0x0600C18E RID: 49550 RVA: 0x0035D984 File Offset: 0x0035BB84
			// (set) Token: 0x0600C18F RID: 49551 RVA: 0x0035D994 File Offset: 0x0035BB94
			public bool[] m_isSelectArray
			{
				get
				{
					return this.m_owner.m_isSelectArray;
				}
				set
				{
					this.m_owner.m_isSelectArray = value;
				}
			}

			// Token: 0x170026FE RID: 9982
			// (get) Token: 0x0600C190 RID: 49552 RVA: 0x0035D9A4 File Offset: 0x0035BBA4
			public static int HeroTeamMaxCount
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x170026FF RID: 9983
			// (get) Token: 0x0600C191 RID: 49553 RVA: 0x0035D9A8 File Offset: 0x0035BBA8
			// (set) Token: 0x0600C192 RID: 49554 RVA: 0x0035D9B8 File Offset: 0x0035BBB8
			public float m_fDebugReportTime
			{
				get
				{
					return this.m_owner.m_fDebugReportTime;
				}
				set
				{
					this.m_owner.m_fDebugReportTime = value;
				}
			}

			// Token: 0x17002700 RID: 9984
			// (get) Token: 0x0600C193 RID: 49555 RVA: 0x0035D9C8 File Offset: 0x0035BBC8
			// (set) Token: 0x0600C194 RID: 49556 RVA: 0x0035D9D8 File Offset: 0x0035BBD8
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

			// Token: 0x17002701 RID: 9985
			// (get) Token: 0x0600C195 RID: 49557 RVA: 0x0035D9E8 File Offset: 0x0035BBE8
			// (set) Token: 0x0600C196 RID: 49558 RVA: 0x0035D9F8 File Offset: 0x0035BBF8
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

			// Token: 0x0600C197 RID: 49559 RVA: 0x0035DA08 File Offset: 0x0035BC08
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C198 RID: 49560 RVA: 0x0035DA18 File Offset: 0x0035BC18
			public bool CheckARState()
			{
				return this.m_owner.CheckARState();
			}

			// Token: 0x0600C199 RID: 49561 RVA: 0x0035DA28 File Offset: 0x0035BC28
			public void SetTeam(BusinessCard businessCard, bool isRandomShow)
			{
				this.m_owner.SetTeam(businessCard, isRandomShow);
			}

			// Token: 0x0600C19A RID: 49562 RVA: 0x0035DA38 File Offset: 0x0035BC38
			public void OnHeroCharClick(BusinessCardHeroCharItemUIController ctrl)
			{
				this.m_owner.OnHeroCharClick(ctrl);
			}

			// Token: 0x0600C19B RID: 49563 RVA: 0x0035DA48 File Offset: 0x0035BC48
			public void ClearTeam()
			{
				this.m_owner.ClearTeam();
			}

			// Token: 0x0600C19C RID: 49564 RVA: 0x0035DA58 File Offset: 0x0035BC58
			public void SetHeroInfoPanel(BattleHero hero, bool canSetAndChange)
			{
				this.m_owner.SetHeroInfoPanel(hero, canSetAndChange);
			}

			// Token: 0x0600C19D RID: 49565 RVA: 0x0035DA68 File Offset: 0x0035BC68
			public void SetHeroTalent(BattleHero battleHero)
			{
				this.m_owner.SetHeroTalent(battleHero);
			}

			// Token: 0x0600C19E RID: 49566 RVA: 0x0035DA78 File Offset: 0x0035BC78
			public void SetHeroProperty(BattleHero battleHero)
			{
				this.m_owner.SetHeroProperty(battleHero);
			}

			// Token: 0x0600C19F RID: 49567 RVA: 0x0035DA88 File Offset: 0x0035BC88
			public void SetCurSelectSkills(BattleHero hero)
			{
				this.m_owner.SetCurSelectSkills(hero);
			}

			// Token: 0x0600C1A0 RID: 49568 RVA: 0x0035DA98 File Offset: 0x0035BC98
			public void OnSkillItemClick(HeroSkillItemUIController skillCtrl)
			{
				this.m_owner.OnSkillItemClick(skillCtrl);
			}

			// Token: 0x0600C1A1 RID: 49569 RVA: 0x0035DAA8 File Offset: 0x0035BCA8
			public void OnTalentItemClick()
			{
				this.m_owner.OnTalentItemClick();
			}

			// Token: 0x0600C1A2 RID: 49570 RVA: 0x0035DAB8 File Offset: 0x0035BCB8
			public void SetEquipment(List<BattleHeroEquipment> equipments)
			{
				this.m_owner.SetEquipment(equipments);
			}

			// Token: 0x0600C1A3 RID: 49571 RVA: 0x0035DAC8 File Offset: 0x0035BCC8
			public void ClearEquipmentItem()
			{
				this.m_owner.ClearEquipmentItem();
			}

			// Token: 0x0600C1A4 RID: 49572 RVA: 0x0035DAD8 File Offset: 0x0035BCD8
			public void SetEquipmentItemInfo(BattleHeroEquipment equipment, GameObject parent)
			{
				this.m_owner.SetEquipmentItemInfo(equipment, parent);
			}

			// Token: 0x0600C1A5 RID: 49573 RVA: 0x0035DAE8 File Offset: 0x0035BCE8
			public void OnEquipmentItemClick(BusinessCardHeroEquipmentItemController ctrl)
			{
				this.m_owner.OnEquipmentItemClick(ctrl);
			}

			// Token: 0x0600C1A6 RID: 49574 RVA: 0x0035DAF8 File Offset: 0x0035BCF8
			public void OnEquipmentItemBGButtonClick()
			{
				this.m_owner.OnEquipmentItemBGButtonClick();
			}

			// Token: 0x0600C1A7 RID: 49575 RVA: 0x0035DB08 File Offset: 0x0035BD08
			public void SetEquipmentItemDesc(BattleHeroEquipment equipment)
			{
				this.m_owner.SetEquipmentItemDesc(equipment);
			}

			// Token: 0x0600C1A8 RID: 49576 RVA: 0x0035DB18 File Offset: 0x0035BD18
			public void SetPropItems(PropertyModifyType type, int value, int addValue, int level)
			{
				this.m_owner.SetPropItems(type, value, addValue, level);
			}

			// Token: 0x0600C1A9 RID: 49577 RVA: 0x0035DB2C File Offset: 0x0035BD2C
			public void SetCharInfoPanel(BattleHero hero, int positionIndex)
			{
				this.m_owner.SetCharInfoPanel(hero, positionIndex);
			}

			// Token: 0x0600C1AA RID: 49578 RVA: 0x0035DB3C File Offset: 0x0035BD3C
			public void OnCharDiretionValueChanged(int direction)
			{
				this.m_owner.OnCharDiretionValueChanged(direction);
			}

			// Token: 0x0600C1AB RID: 49579 RVA: 0x0035DB4C File Offset: 0x0035BD4C
			public void OnCharAnimationValueChanged(int animation)
			{
				this.m_owner.OnCharAnimationValueChanged(animation);
			}

			// Token: 0x0600C1AC RID: 49580 RVA: 0x0035DB5C File Offset: 0x0035BD5C
			public UISpineGraphic CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ConfigDataModelSkinResourceInfo heroSkinResInfo, bool isUIModelScale, HeroDirectionType directionType, HeroActionType actionType)
			{
				return this.m_owner.CreateSpineGraphic(jobConnectionInfo, heroSkinResInfo, isUIModelScale, directionType, actionType);
			}

			// Token: 0x0600C1AD RID: 49581 RVA: 0x0035DB70 File Offset: 0x0035BD70
			public void SetCharAction(UISpineGraphic g, HeroDirectionType direction, HeroActionType animation)
			{
				this.m_owner.SetCharAction(g, direction, animation);
			}

			// Token: 0x0600C1AE RID: 49582 RVA: 0x0035DB80 File Offset: 0x0035BD80
			public void SetHeroSelectPanel(BusinessCard businessCard)
			{
				this.m_owner.SetHeroSelectPanel(businessCard);
			}

			// Token: 0x0600C1AF RID: 49583 RVA: 0x0035DB90 File Offset: 0x0035BD90
			public int HeroListItemCompare(Hero h1, Hero h2)
			{
				return this.m_owner.HeroListItemCompare(h1, h2);
			}

			// Token: 0x0600C1B0 RID: 49584 RVA: 0x0035DBA0 File Offset: 0x0035BDA0
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600C1B1 RID: 49585 RVA: 0x0035DBB0 File Offset: 0x0035BDB0
			public void OnLikeButtonClick()
			{
				this.m_owner.OnLikeButtonClick();
			}

			// Token: 0x0600C1B2 RID: 49586 RVA: 0x0035DBC0 File Offset: 0x0035BDC0
			public void OnRandowShowToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRandowShowToggleValueChanged(isOn);
			}

			// Token: 0x0600C1B3 RID: 49587 RVA: 0x0035DBD0 File Offset: 0x0035BDD0
			public void OnSetPanelBGButtonClick()
			{
				this.m_owner.OnSetPanelBGButtonClick();
			}

			// Token: 0x0600C1B4 RID: 49588 RVA: 0x0035DBE0 File Offset: 0x0035BDE0
			public void OnChangeSignButtonClick()
			{
				this.m_owner.OnChangeSignButtonClick();
			}

			// Token: 0x0600C1B5 RID: 49589 RVA: 0x0035DBF0 File Offset: 0x0035BDF0
			public void OnArButtonClick()
			{
				this.m_owner.OnArButtonClick();
			}

			// Token: 0x0600C1B6 RID: 49590 RVA: 0x0035DC00 File Offset: 0x0035BE00
			public void OnPlayerSignEditEnd(InputField input)
			{
				this.m_owner.OnPlayerSignEditEnd(input);
			}

			// Token: 0x0600C1B7 RID: 49591 RVA: 0x0035DC10 File Offset: 0x0035BE10
			public void OnHeroItemClick(BusinessCardHeroListItemUIController ctrl)
			{
				this.m_owner.OnHeroItemClick(ctrl);
			}

			// Token: 0x0600C1B8 RID: 49592 RVA: 0x0035DC20 File Offset: 0x0035BE20
			public void OnHeroInfoPanelSettingButtonClick()
			{
				this.m_owner.OnHeroInfoPanelSettingButtonClick();
			}

			// Token: 0x0600C1B9 RID: 49593 RVA: 0x0035DC30 File Offset: 0x0035BE30
			public void OnHeroInfoPanelChangeButtonClick()
			{
				this.m_owner.OnHeroInfoPanelChangeButtonClick();
			}

			// Token: 0x0600C1BA RID: 49594 RVA: 0x0035DC40 File Offset: 0x0035BE40
			public void OnSetCharPanelConfirmButtonClick()
			{
				this.m_owner.OnSetCharPanelConfirmButtonClick();
			}

			// Token: 0x0600C1BB RID: 49595 RVA: 0x0035DC50 File Offset: 0x0035BE50
			public void OnHeroSelectPanelConfirmButtonClick()
			{
				this.m_owner.OnHeroSelectPanelConfirmButtonClick();
			}

			// Token: 0x0600C1BC RID: 49596 RVA: 0x0035DC60 File Offset: 0x0035BE60
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04007B52 RID: 31570
			private BusinessCardUIController m_owner;
		}
	}
}
