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
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D9C RID: 3484
	[HotFix]
	public class HeroDetailInfoUIController : UIControllerBase
	{
		// Token: 0x0601060F RID: 67087 RVA: 0x00445AC8 File Offset: 0x00443CC8
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
			this.m_infoHeroCurSkillChangeButton.onClick.AddListener(new UnityAction(this.OnChangeSkillButtonClick));
			this.m_infoAddExpButton.onClick.AddListener(new UnityAction(this.OnAddExpButtonClick));
			this.m_skinInfoButton.onClick.AddListener(new UnityAction(this.OnSkinInfoButtonClcik));
			this.m_propertyMsgButton.onClick.AddListener(new UnityAction(this.OnPropertyMsgButtonClick));
			this.m_explanationBackgroundButton.onClick.AddListener(new UnityAction(this.OnExplanationBackgroundButtonClick));
			this.m_tagPanelBGButton.onClick.AddListener(new UnityAction(this.CloseTagPanel));
			this.m_tagPanelCloseBtn.onClick.AddListener(new UnityAction(this.CloseTagPanel));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06010610 RID: 67088 RVA: 0x00445C34 File Offset: 0x00443E34
		public void UpdateViewInInfoState(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInInfoStateHero_hotfix != null)
			{
				this.m_UpdateViewInInfoStateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.ShowHeroInfo();
		}

		// Token: 0x06010611 RID: 67089 RVA: 0x00445CB4 File Offset: 0x00443EB4
		private void ShowHeroInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowHeroInfo_hotfix != null)
			{
				this.m_ShowHeroInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataArmyInfo armyInfo = this.m_hero.GetActiveJob().JobConnectionInfo.m_jobInfo.m_armyInfo;
			this.m_infoHeroArmyImg.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon_NoBack);
			this.m_infoHeroLvText.text = this.m_hero.Level.ToString();
			int num = this.m_playerContext.GetPlayerLevel() + this.m_configDataLoader.ConfigableConstId_HeroLevelUpCeiling;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_infoHeroLvMaxText.text = ((num >= configableConstId_PlayerLevelMaxLevel) ? configableConstId_PlayerLevelMaxLevel : num).ToString();
			this.m_infoHeroExpText.text = this.m_hero.Exp + "/" + this.m_playerContext.GetHeroNextLevelExp(this.m_hero.Level);
			float fillAmount = (float)this.m_hero.Exp / (float)this.m_playerContext.GetHeroNextLevelExp(this.m_hero.Level);
			this.m_infoHeroExpImg.fillAmount = fillAmount;
			HeroJob activeJob = this.m_hero.GetActiveJob();
			this.m_infoHeroGraphic.SetActive(true);
			ConfigDataJobConnectionInfo jobConnectionInfo = activeJob.JobConnectionInfo;
			string heroModelAssetPath = UIUtility.GetHeroModelAssetPath(this.m_hero);
			float scale = (float)jobConnectionInfo.UI_ModelScale * 0.014f;
			Vector2 offset = new Vector2((float)jobConnectionInfo.UI_ModelOffsetX, (float)jobConnectionInfo.UI_ModelOffsetY) * 1.4f;
			List<ReplaceAnim> replaceAnims = jobConnectionInfo.ReplaceAnims;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_playerHeroGraphic, heroModelAssetPath, this.m_infoHeroGraphic, 1, offset, scale, replaceAnims);
			if (this.m_playerHeroGraphic != null)
			{
				this.m_playerHeroGraphic.EnableCanvasGroupAlpha(false);
			}
			this.SetHeroProperty(this.m_hero);
			this.SetHeroTalent(this.m_hero);
			this.SetCurSelectSkills();
			int num2 = 0;
			foreach (int key in this.m_hero.HeroInfo.Skins_ID)
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(key);
				if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataHeroSkinInfo.FixedStoreItemId, true))
				{
					num2++;
				}
			}
			this.m_skinInfoButton.gameObject.SetActive(num2 > 0);
			this.SetHeroTagInfo();
		}

		// Token: 0x06010612 RID: 67090 RVA: 0x00445F8C File Offset: 0x0044418C
		private void SetHeroTagInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroTagInfo_hotfix != null)
			{
				this.m_SetHeroTagInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>(this.m_hero.HeroInfo.m_heroTagIds);
			Transform transform = this.m_tagButtonsContent.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				if (i < list.Count)
				{
					ConfigDataHeroTagInfo tagInfo = this.m_configDataLoader.GetConfigDataHeroTagInfo(list[i]);
					child.gameObject.SetActive(true);
					child.GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(tagInfo.Icon);
					child.GetComponent<Button>().onClick.AddListener(delegate()
					{
						this.OpenTagPanel(tagInfo);
					});
				}
				else
				{
					child.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x06010613 RID: 67091 RVA: 0x004460BC File Offset: 0x004442BC
		private void OpenTagPanel(ConfigDataHeroTagInfo tagInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenTagPanelConfigDataHeroTagInfo_hotfix != null)
			{
				this.m_OpenTagPanelConfigDataHeroTagInfo_hotfix.call(new object[]
				{
					this,
					tagInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tagPanelStateCtrl.gameObject.SetActive(true);
			UIUtility.SetUIStateOpen(this.m_tagPanelStateCtrl, "Show", null, true, true);
			this.SetTagPanelInfo(tagInfo);
		}

		// Token: 0x06010614 RID: 67092 RVA: 0x00446158 File Offset: 0x00444358
		private void SetTagPanelInfo(ConfigDataHeroTagInfo tagInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTagPanelInfoConfigDataHeroTagInfo_hotfix != null)
			{
				this.m_SetTagPanelInfoConfigDataHeroTagInfo_hotfix.call(new object[]
				{
					this,
					tagInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tagPanelTitleText.text = tagInfo.Name;
			this.m_tagPanelDescText.text = tagInfo.Desc;
			this.m_tagPanelIconImage.sprite = AssetUtility.Instance.GetSprite(tagInfo.Icon);
			List<int> list = new List<int>();
			list.AddRange(tagInfo.RelatedHeros_ID);
			list.Sort(new Comparison<int>(this.SortRelatedHeroIdByRank));
			Transform transform = this.m_tagPanelListScrollViewContent.transform;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_tagPanelListScrollViewContent, 0);
			for (int i = 0; i < list.Count; i++)
			{
				TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController;
				if (i < transform.childCount)
				{
					tagPanelHeroIconItemUIController = transform.GetChild(i).GetComponent<TagPanelHeroIconItemUIController>();
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_tagPanelHeroIconImagePrefab);
					tagPanelHeroIconItemUIController = GameObjectUtility.AddControllerToGameObject<TagPanelHeroIconItemUIController>(gameObject);
					gameObject.transform.SetParent(transform, false);
				}
				tagPanelHeroIconItemUIController.InitTagHeroIconItem(list[i]);
			}
			this.m_tagPanelListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06010615 RID: 67093 RVA: 0x004462B8 File Offset: 0x004444B8
		private int SortRelatedHeroIdByRank(int heroId1, int heroId2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortRelatedHeroIdByRankInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortRelatedHeroIdByRankInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId1,
					heroId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(heroId1);
			ConfigDataHeroInfo configDataHeroInfo2 = this.m_configDataLoader.GetConfigDataHeroInfo(heroId2);
			return configDataHeroInfo2.Rank - configDataHeroInfo.Rank;
		}

		// Token: 0x06010616 RID: 67094 RVA: 0x0044636C File Offset: 0x0044456C
		private void CloseTagPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseTagPanel_hotfix != null)
			{
				this.m_CloseTagPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_tagPanelStateCtrl, "Close", delegate
			{
				this.m_tagPanelStateCtrl.gameObject.SetActive(false);
			}, true, true);
		}

		// Token: 0x06010617 RID: 67095 RVA: 0x004463EC File Offset: 0x004445EC
		private void SetHeroProperty(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroPropertyHero_hotfix != null)
			{
				this.m_SetHeroPropertyHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			char[] array = hero.GetActiveJob().JobConnectionInfo.PropertyRating.ToCharArray();
			List<Image> list = new List<Image>();
			list.Add(this.m_infoHeroPropHPImg);
			list.Add(this.m_infoHeroPropATImg);
			list.Add(this.m_infoHeroPropMagicImg);
			list.Add(this.m_infoHeroPropDFImg);
			list.Add(this.m_infoHeroPropMagicDFImg);
			list.Add(this.m_infoHeroPropDEXImg);
			for (int i = 0; i < array.Length; i++)
			{
				string propertyRatingImageName = UIUtility.GetPropertyRatingImageName(array[i]);
				list[i].sprite = AssetUtility.Instance.GetSprite(propertyRatingImageName);
			}
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeHeroEquipmentProperties(hero);
			this.m_infoHeroPropHPValueText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.m_infoHeroPropDFValueText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_infoHeroPropATValueText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_infoHeroPropMagicDFValueText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_infoHeroPropMagicValueText.text = heroPropertyComputer.Property0.Magic.ToString();
			this.m_infoHeroPropDEXValueText.text = heroPropertyComputer.Property0.Dexterity.ToString();
			int num = heroPropertyComputer.Property1.HealthPointMax - heroPropertyComputer.Property0.HealthPointMax;
			this.m_infoHeroPropHPAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Defense - heroPropertyComputer.Property0.Defense;
			this.m_infoHeroPropDFAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Attack - heroPropertyComputer.Property0.Attack;
			this.m_infoHeroPropATAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.MagicDefense - heroPropertyComputer.Property0.MagicDefense;
			this.m_infoHeroPropMagicDFAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Magic - heroPropertyComputer.Property0.Magic;
			this.m_infoHeroPropMagicAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
			num = heroPropertyComputer.Property1.Dexterity - heroPropertyComputer.Property0.Dexterity;
			this.m_infoHeroPropDEXAddText.text = ((num != 0) ? ("+" + num) : string.Empty);
		}

		// Token: 0x06010618 RID: 67096 RVA: 0x0044678C File Offset: 0x0044498C
		private void SetHeroTalent(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroTalentHero_hotfix != null)
			{
				this.m_SetHeroTalentHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSkillInfo talentSkillInfo = hero.GetActiveJob().JobConnectionInfo.GetTalentSkillInfo(hero.StarLevel);
			if (talentSkillInfo == null)
			{
				return;
			}
			this.m_infoHeroTalentIcon.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo.Icon);
			this.m_infoHeroTalentNameText.text = talentSkillInfo.Name;
			this.m_infoHeroTalentDescText.text = talentSkillInfo.Desc;
		}

		// Token: 0x06010619 RID: 67097 RVA: 0x00446858 File Offset: 0x00444A58
		private void SetCurSelectSkills()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurSelectSkills_hotfix != null)
			{
				this.m_SetCurSelectSkills_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_infoHeroCurSkillContent);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("skillItem");
			List<int> selectedSkills = this.m_hero.SelectedSkills;
			List<int> list = new List<int>();
			list.AddRange(selectedSkills);
			int num = 0;
			foreach (int key in list)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(key);
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroSkillItemUIController component = gameObject.GetComponent<HeroSkillItemUIController>();
				component.EventOnShowDesc += this.OnSkillItemClick;
				component.InitSkillItem(configDataSkillInfo);
				component.SetCostPanelActive(true);
				gameObject.transform.SetParent(this.m_infoHeroCurSkillContent.transform, false);
				num += configDataSkillInfo.SkillCost;
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_infoHeroCurSkillCostsObj, num);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_infoHeroCurSkillContentBg, 3 - list.Count);
		}

		// Token: 0x0601061A RID: 67098 RVA: 0x004469BC File Offset: 0x00444BBC
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
			for (int i = 0; i < this.m_infoCurSkillDescPanel.transform.childCount; i++)
			{
				Transform child = this.m_infoCurSkillDescPanel.transform.GetChild(i);
				skillDescUIController = child.GetComponent<SkillDescUIController>();
				if (skillDescUIController != null)
				{
					break;
				}
			}
			if (skillDescUIController == null)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("commonSkillDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				skillDescUIController = gameObject.GetComponent<SkillDescUIController>();
				gameObject.transform.SetParent(this.m_infoCurSkillDescPanel.transform, false);
			}
			skillDescUIController.InitSkillDesc(skillCtrl.m_skillInfo);
		}

		// Token: 0x0601061B RID: 67099 RVA: 0x00446AD0 File Offset: 0x00444CD0
		private void OnAddExpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddExpButtonClick_hotfix != null)
			{
				this.m_OnAddExpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSetDetailState != null)
			{
				this.EventOnSetDetailState("DetailAddExp");
			}
		}

		// Token: 0x0601061C RID: 67100 RVA: 0x00446B4C File Offset: 0x00444D4C
		private void OnSkinInfoButtonClcik()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinInfoButtonClcik_hotfix != null)
			{
				this.m_OnSkinInfoButtonClcik_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkinInfoButtonClick != null)
			{
				this.EventOnSkinInfoButtonClick();
			}
		}

		// Token: 0x0601061D RID: 67101 RVA: 0x00446BC4 File Offset: 0x00444DC4
		private void OnJobUpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobUpButtonClick_hotfix != null)
			{
				this.m_OnJobUpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnJobUpButtonClick != null)
			{
				this.EventOnJobUpButtonClick();
			}
		}

		// Token: 0x0601061E RID: 67102 RVA: 0x00446C3C File Offset: 0x00444E3C
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
			if (this.EventOnSetDetailState != null)
			{
				this.EventOnSetDetailState("DetailSelectSkill");
			}
		}

		// Token: 0x0601061F RID: 67103 RVA: 0x00446CB8 File Offset: 0x00444EB8
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
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, stateName, null, true, true);
		}

		// Token: 0x06010620 RID: 67104 RVA: 0x00446D40 File Offset: 0x00444F40
		private void OnPropertyMsgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPropertyMsgButtonClick_hotfix != null)
			{
				this.m_OnPropertyMsgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string value = this.m_configDataLoader.GetConfigDataExplanationInfo(19).Value;
			this.m_explanationText.text = value;
			this.m_explanationStateCtrl.gameObject.SetActive(true);
			this.m_explanationStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x06010621 RID: 67105 RVA: 0x00446DE4 File Offset: 0x00444FE4
		private void OnExplanationBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExplanationBackgroundButtonClick_hotfix != null)
			{
				this.m_OnExplanationBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_explanationStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_explanationStateCtrl.gameObject.SetActive(false);
			});
			this.m_explanationStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x06010622 RID: 67106 RVA: 0x00446E74 File Offset: 0x00445074
		public void IsShowHeroLittleSpine(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsShowHeroLittleSpineBoolean_hotfix != null)
			{
				this.m_IsShowHeroLittleSpineBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_infoHeroGraphic.SetActive(isShow);
		}

		// Token: 0x14000378 RID: 888
		// (add) Token: 0x06010623 RID: 67107 RVA: 0x00446EF0 File Offset: 0x004450F0
		// (remove) Token: 0x06010624 RID: 67108 RVA: 0x00446F8C File Offset: 0x0044518C
		public event Action<string> EventOnSetDetailState
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSetDetailStateAction`1_hotfix != null)
				{
					this.m_add_EventOnSetDetailStateAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSetDetailState;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSetDetailState, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSetDetailStateAction`1_hotfix != null)
				{
					this.m_remove_EventOnSetDetailStateAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSetDetailState;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSetDetailState, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000379 RID: 889
		// (add) Token: 0x06010625 RID: 67109 RVA: 0x00447028 File Offset: 0x00445228
		// (remove) Token: 0x06010626 RID: 67110 RVA: 0x004470C4 File Offset: 0x004452C4
		public event Action EventOnSkinInfoButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkinInfoButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnSkinInfoButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinInfoButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinInfoButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkinInfoButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnSkinInfoButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinInfoButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinInfoButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400037A RID: 890
		// (add) Token: 0x06010627 RID: 67111 RVA: 0x00447160 File Offset: 0x00445360
		// (remove) Token: 0x06010628 RID: 67112 RVA: 0x004471FC File Offset: 0x004453FC
		public event Action EventOnJobUpButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJobUpButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnJobUpButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnJobUpButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnJobUpButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJobUpButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnJobUpButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnJobUpButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnJobUpButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x06010629 RID: 67113 RVA: 0x00447298 File Offset: 0x00445498
		// (set) Token: 0x0601062A RID: 67114 RVA: 0x004472B8 File Offset: 0x004454B8
		[DoNotToLua]
		public new HeroDetailInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601062B RID: 67115 RVA: 0x004472C4 File Offset: 0x004454C4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601062C RID: 67116 RVA: 0x004472D0 File Offset: 0x004454D0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601062D RID: 67117 RVA: 0x004472D8 File Offset: 0x004454D8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601062E RID: 67118 RVA: 0x004472E0 File Offset: 0x004454E0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601062F RID: 67119 RVA: 0x004472F4 File Offset: 0x004454F4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010630 RID: 67120 RVA: 0x004472FC File Offset: 0x004454FC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010631 RID: 67121 RVA: 0x00447308 File Offset: 0x00445508
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010632 RID: 67122 RVA: 0x00447314 File Offset: 0x00445514
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010633 RID: 67123 RVA: 0x00447320 File Offset: 0x00445520
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010634 RID: 67124 RVA: 0x0044732C File Offset: 0x0044552C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010635 RID: 67125 RVA: 0x00447338 File Offset: 0x00445538
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010636 RID: 67126 RVA: 0x00447344 File Offset: 0x00445544
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010637 RID: 67127 RVA: 0x00447350 File Offset: 0x00445550
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010638 RID: 67128 RVA: 0x0044735C File Offset: 0x0044555C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010639 RID: 67129 RVA: 0x00447368 File Offset: 0x00445568
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601063A RID: 67130 RVA: 0x00447370 File Offset: 0x00445570
		private void __callDele_EventOnSetDetailState(string obj)
		{
			Action<string> eventOnSetDetailState = this.EventOnSetDetailState;
			if (eventOnSetDetailState != null)
			{
				eventOnSetDetailState(obj);
			}
		}

		// Token: 0x0601063B RID: 67131 RVA: 0x00447394 File Offset: 0x00445594
		private void __clearDele_EventOnSetDetailState(string obj)
		{
			this.EventOnSetDetailState = null;
		}

		// Token: 0x0601063C RID: 67132 RVA: 0x004473A0 File Offset: 0x004455A0
		private void __callDele_EventOnSkinInfoButtonClick()
		{
			Action eventOnSkinInfoButtonClick = this.EventOnSkinInfoButtonClick;
			if (eventOnSkinInfoButtonClick != null)
			{
				eventOnSkinInfoButtonClick();
			}
		}

		// Token: 0x0601063D RID: 67133 RVA: 0x004473C0 File Offset: 0x004455C0
		private void __clearDele_EventOnSkinInfoButtonClick()
		{
			this.EventOnSkinInfoButtonClick = null;
		}

		// Token: 0x0601063E RID: 67134 RVA: 0x004473CC File Offset: 0x004455CC
		private void __callDele_EventOnJobUpButtonClick()
		{
			Action eventOnJobUpButtonClick = this.EventOnJobUpButtonClick;
			if (eventOnJobUpButtonClick != null)
			{
				eventOnJobUpButtonClick();
			}
		}

		// Token: 0x0601063F RID: 67135 RVA: 0x004473EC File Offset: 0x004455EC
		private void __clearDele_EventOnJobUpButtonClick()
		{
			this.EventOnJobUpButtonClick = null;
		}

		// Token: 0x06010642 RID: 67138 RVA: 0x00447420 File Offset: 0x00445620
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
					this.m_UpdateViewInInfoStateHero_hotfix = (luaObj.RawGet("UpdateViewInInfoState") as LuaFunction);
					this.m_ShowHeroInfo_hotfix = (luaObj.RawGet("ShowHeroInfo") as LuaFunction);
					this.m_SetHeroTagInfo_hotfix = (luaObj.RawGet("SetHeroTagInfo") as LuaFunction);
					this.m_OpenTagPanelConfigDataHeroTagInfo_hotfix = (luaObj.RawGet("OpenTagPanel") as LuaFunction);
					this.m_SetTagPanelInfoConfigDataHeroTagInfo_hotfix = (luaObj.RawGet("SetTagPanelInfo") as LuaFunction);
					this.m_SortRelatedHeroIdByRankInt32Int32_hotfix = (luaObj.RawGet("SortRelatedHeroIdByRank") as LuaFunction);
					this.m_CloseTagPanel_hotfix = (luaObj.RawGet("CloseTagPanel") as LuaFunction);
					this.m_SetHeroPropertyHero_hotfix = (luaObj.RawGet("SetHeroProperty") as LuaFunction);
					this.m_SetHeroTalentHero_hotfix = (luaObj.RawGet("SetHeroTalent") as LuaFunction);
					this.m_SetCurSelectSkills_hotfix = (luaObj.RawGet("SetCurSelectSkills") as LuaFunction);
					this.m_OnSkillItemClickHeroSkillItemUIController_hotfix = (luaObj.RawGet("OnSkillItemClick") as LuaFunction);
					this.m_OnAddExpButtonClick_hotfix = (luaObj.RawGet("OnAddExpButtonClick") as LuaFunction);
					this.m_OnSkinInfoButtonClcik_hotfix = (luaObj.RawGet("OnSkinInfoButtonClcik") as LuaFunction);
					this.m_OnJobUpButtonClick_hotfix = (luaObj.RawGet("OnJobUpButtonClick") as LuaFunction);
					this.m_OnChangeSkillButtonClick_hotfix = (luaObj.RawGet("OnChangeSkillButtonClick") as LuaFunction);
					this.m_SetCommonUIStateString_hotfix = (luaObj.RawGet("SetCommonUIState") as LuaFunction);
					this.m_OnPropertyMsgButtonClick_hotfix = (luaObj.RawGet("OnPropertyMsgButtonClick") as LuaFunction);
					this.m_OnExplanationBackgroundButtonClick_hotfix = (luaObj.RawGet("OnExplanationBackgroundButtonClick") as LuaFunction);
					this.m_IsShowHeroLittleSpineBoolean_hotfix = (luaObj.RawGet("IsShowHeroLittleSpine") as LuaFunction);
					this.m_add_EventOnSetDetailStateAction`1_hotfix = (luaObj.RawGet("add_EventOnSetDetailState") as LuaFunction);
					this.m_remove_EventOnSetDetailStateAction`1_hotfix = (luaObj.RawGet("remove_EventOnSetDetailState") as LuaFunction);
					this.m_add_EventOnSkinInfoButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnSkinInfoButtonClick") as LuaFunction);
					this.m_remove_EventOnSkinInfoButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnSkinInfoButtonClick") as LuaFunction);
					this.m_add_EventOnJobUpButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnJobUpButtonClick") as LuaFunction);
					this.m_remove_EventOnJobUpButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnJobUpButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010643 RID: 67139 RVA: 0x0044775C File Offset: 0x0044595C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009827 RID: 38951
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04009828 RID: 38952
		[AutoBind("./ArmyImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroArmyImg;

		// Token: 0x04009829 RID: 38953
		[AutoBind("./Lv/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroLvText;

		// Token: 0x0400982A RID: 38954
		[AutoBind("./Lv/ValueText/MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroLvMaxText;

		// Token: 0x0400982B RID: 38955
		[AutoBind("./Exp/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroExpText;

		// Token: 0x0400982C RID: 38956
		[AutoBind("./Exp/ProgressImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroExpImg;

		// Token: 0x0400982D RID: 38957
		[AutoBind("./Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoHeroGraphic;

		// Token: 0x0400982E RID: 38958
		[AutoBind("./PropertyMsgButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_propertyMsgButton;

		// Token: 0x0400982F RID: 38959
		[AutoBind("./Explanation", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_explanationStateCtrl;

		// Token: 0x04009830 RID: 38960
		[AutoBind("./Explanation/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_explanationBackgroundButton;

		// Token: 0x04009831 RID: 38961
		[AutoBind("./Explanation/Panel/BGImage/FrameImage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_explanationText;

		// Token: 0x04009832 RID: 38962
		[AutoBind("./Keyword", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tagButtonsContent;

		// Token: 0x04009833 RID: 38963
		[AutoBind("./KeywordPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_tagPanelStateCtrl;

		// Token: 0x04009834 RID: 38964
		[AutoBind("./KeywordPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_tagPanelBGButton;

		// Token: 0x04009835 RID: 38965
		[AutoBind("./KeywordPanel/KeywordPanelDetil/InfoPanel/TitleText1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_tagPanelTitleText;

		// Token: 0x04009836 RID: 38966
		[AutoBind("./KeywordPanel/KeywordPanelDetil/InfoPanel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_tagPanelDescText;

		// Token: 0x04009837 RID: 38967
		[AutoBind("./KeywordPanel/KeywordPanelDetil/InfoPanel/KeywordIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_tagPanelIconImage;

		// Token: 0x04009838 RID: 38968
		[AutoBind("./KeywordPanel/KeywordPanelDetil/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tagPanelListScrollViewContent;

		// Token: 0x04009839 RID: 38969
		[AutoBind("./KeywordPanel/KeywordPanelDetil/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_tagPanelListScrollRect;

		// Token: 0x0400983A RID: 38970
		[AutoBind("./KeywordPanel/KeywordPanelDetil/Prefab/HeroIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tagPanelHeroIconImagePrefab;

		// Token: 0x0400983B RID: 38971
		[AutoBind("./KeywordPanel/KeywordPanelDetil/CloseBth", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_tagPanelCloseBtn;

		// Token: 0x0400983C RID: 38972
		[AutoBind("./Property/HP/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroPropHPImg;

		// Token: 0x0400983D RID: 38973
		[AutoBind("./Property/DF/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroPropDFImg;

		// Token: 0x0400983E RID: 38974
		[AutoBind("./Property/AT/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroPropATImg;

		// Token: 0x0400983F RID: 38975
		[AutoBind("./Property/MagicDF/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroPropMagicDFImg;

		// Token: 0x04009840 RID: 38976
		[AutoBind("./Property/Magic/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroPropMagicImg;

		// Token: 0x04009841 RID: 38977
		[AutoBind("./Property/DEX/EvaluateImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroPropDEXImg;

		// Token: 0x04009842 RID: 38978
		[AutoBind("./Property/HP/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropHPValueText;

		// Token: 0x04009843 RID: 38979
		[AutoBind("./Property/DF/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropDFValueText;

		// Token: 0x04009844 RID: 38980
		[AutoBind("./Property/AT/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropATValueText;

		// Token: 0x04009845 RID: 38981
		[AutoBind("./Property/MagicDF/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropMagicDFValueText;

		// Token: 0x04009846 RID: 38982
		[AutoBind("./Property/Magic/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropMagicValueText;

		// Token: 0x04009847 RID: 38983
		[AutoBind("./Property/DEX/Text/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropDEXValueText;

		// Token: 0x04009848 RID: 38984
		[AutoBind("./Property/HP/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropHPAddText;

		// Token: 0x04009849 RID: 38985
		[AutoBind("./Property/DF/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropDFAddText;

		// Token: 0x0400984A RID: 38986
		[AutoBind("./Property/AT/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropATAddText;

		// Token: 0x0400984B RID: 38987
		[AutoBind("./Property/MagicDF/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropMagicDFAddText;

		// Token: 0x0400984C RID: 38988
		[AutoBind("./Property/Magic/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropMagicAddText;

		// Token: 0x0400984D RID: 38989
		[AutoBind("./Property/DEX/Text/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroPropDEXAddText;

		// Token: 0x0400984E RID: 38990
		[AutoBind("./Talent/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_infoHeroTalentIcon;

		// Token: 0x0400984F RID: 38991
		[AutoBind("./Talent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroTalentNameText;

		// Token: 0x04009850 RID: 38992
		[AutoBind("./Talent/DescScrollView/Viewport/Content/Desc", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoHeroTalentDescText;

		// Token: 0x04009851 RID: 38993
		[AutoBind("./Skill/Costs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoHeroCurSkillCostsObj;

		// Token: 0x04009852 RID: 38994
		[AutoBind("./Skill/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoHeroCurSkillContent;

		// Token: 0x04009853 RID: 38995
		[AutoBind("./Skill/SkillBg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoHeroCurSkillContentBg;

		// Token: 0x04009854 RID: 38996
		[AutoBind("./Skill/ChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoHeroCurSkillChangeButton;

		// Token: 0x04009855 RID: 38997
		[AutoBind("./Skill/SkillItemDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoCurSkillDescPanel;

		// Token: 0x04009856 RID: 38998
		[AutoBind("./AddExpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoAddExpButton;

		// Token: 0x04009857 RID: 38999
		[AutoBind("./SkinInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skinInfoButton;

		// Token: 0x0400985B RID: 39003
		private Hero m_hero;

		// Token: 0x0400985C RID: 39004
		private UISpineGraphic m_playerHeroGraphic;

		// Token: 0x0400985D RID: 39005
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400985E RID: 39006
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400985F RID: 39007
		[DoNotToLua]
		private HeroDetailInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009860 RID: 39008
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009861 RID: 39009
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009862 RID: 39010
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009863 RID: 39011
		private LuaFunction m_UpdateViewInInfoStateHero_hotfix;

		// Token: 0x04009864 RID: 39012
		private LuaFunction m_ShowHeroInfo_hotfix;

		// Token: 0x04009865 RID: 39013
		private LuaFunction m_SetHeroTagInfo_hotfix;

		// Token: 0x04009866 RID: 39014
		private LuaFunction m_OpenTagPanelConfigDataHeroTagInfo_hotfix;

		// Token: 0x04009867 RID: 39015
		private LuaFunction m_SetTagPanelInfoConfigDataHeroTagInfo_hotfix;

		// Token: 0x04009868 RID: 39016
		private LuaFunction m_SortRelatedHeroIdByRankInt32Int32_hotfix;

		// Token: 0x04009869 RID: 39017
		private LuaFunction m_CloseTagPanel_hotfix;

		// Token: 0x0400986A RID: 39018
		private LuaFunction m_SetHeroPropertyHero_hotfix;

		// Token: 0x0400986B RID: 39019
		private LuaFunction m_SetHeroTalentHero_hotfix;

		// Token: 0x0400986C RID: 39020
		private LuaFunction m_SetCurSelectSkills_hotfix;

		// Token: 0x0400986D RID: 39021
		private LuaFunction m_OnSkillItemClickHeroSkillItemUIController_hotfix;

		// Token: 0x0400986E RID: 39022
		private LuaFunction m_OnAddExpButtonClick_hotfix;

		// Token: 0x0400986F RID: 39023
		private LuaFunction m_OnSkinInfoButtonClcik_hotfix;

		// Token: 0x04009870 RID: 39024
		private LuaFunction m_OnJobUpButtonClick_hotfix;

		// Token: 0x04009871 RID: 39025
		private LuaFunction m_OnChangeSkillButtonClick_hotfix;

		// Token: 0x04009872 RID: 39026
		private LuaFunction m_SetCommonUIStateString_hotfix;

		// Token: 0x04009873 RID: 39027
		private LuaFunction m_OnPropertyMsgButtonClick_hotfix;

		// Token: 0x04009874 RID: 39028
		private LuaFunction m_OnExplanationBackgroundButtonClick_hotfix;

		// Token: 0x04009875 RID: 39029
		private LuaFunction m_IsShowHeroLittleSpineBoolean_hotfix;

		// Token: 0x04009876 RID: 39030
		private LuaFunction m_add_EventOnSetDetailStateAction;

		// Token: 0x04009877 RID: 39031
		private LuaFunction m_remove_EventOnSetDetailStateAction;

		// Token: 0x04009878 RID: 39032
		private LuaFunction m_add_EventOnSkinInfoButtonClickAction_hotfix;

		// Token: 0x04009879 RID: 39033
		private LuaFunction m_remove_EventOnSkinInfoButtonClickAction_hotfix;

		// Token: 0x0400987A RID: 39034
		private LuaFunction m_add_EventOnJobUpButtonClickAction_hotfix;

		// Token: 0x0400987B RID: 39035
		private LuaFunction m_remove_EventOnJobUpButtonClickAction_hotfix;

		// Token: 0x02000D9D RID: 3485
		public new class LuaExportHelper
		{
			// Token: 0x06010644 RID: 67140 RVA: 0x004477C4 File Offset: 0x004459C4
			public LuaExportHelper(HeroDetailInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010645 RID: 67141 RVA: 0x004477D4 File Offset: 0x004459D4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010646 RID: 67142 RVA: 0x004477E4 File Offset: 0x004459E4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010647 RID: 67143 RVA: 0x004477F4 File Offset: 0x004459F4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010648 RID: 67144 RVA: 0x00447804 File Offset: 0x00445A04
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010649 RID: 67145 RVA: 0x0044781C File Offset: 0x00445A1C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601064A RID: 67146 RVA: 0x0044782C File Offset: 0x00445A2C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601064B RID: 67147 RVA: 0x0044783C File Offset: 0x00445A3C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601064C RID: 67148 RVA: 0x0044784C File Offset: 0x00445A4C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601064D RID: 67149 RVA: 0x0044785C File Offset: 0x00445A5C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601064E RID: 67150 RVA: 0x0044786C File Offset: 0x00445A6C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601064F RID: 67151 RVA: 0x0044787C File Offset: 0x00445A7C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010650 RID: 67152 RVA: 0x0044788C File Offset: 0x00445A8C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010651 RID: 67153 RVA: 0x0044789C File Offset: 0x00445A9C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010652 RID: 67154 RVA: 0x004478AC File Offset: 0x00445AAC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010653 RID: 67155 RVA: 0x004478BC File Offset: 0x00445ABC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010654 RID: 67156 RVA: 0x004478CC File Offset: 0x00445ACC
			public void __callDele_EventOnSetDetailState(string obj)
			{
				this.m_owner.__callDele_EventOnSetDetailState(obj);
			}

			// Token: 0x06010655 RID: 67157 RVA: 0x004478DC File Offset: 0x00445ADC
			public void __clearDele_EventOnSetDetailState(string obj)
			{
				this.m_owner.__clearDele_EventOnSetDetailState(obj);
			}

			// Token: 0x06010656 RID: 67158 RVA: 0x004478EC File Offset: 0x00445AEC
			public void __callDele_EventOnSkinInfoButtonClick()
			{
				this.m_owner.__callDele_EventOnSkinInfoButtonClick();
			}

			// Token: 0x06010657 RID: 67159 RVA: 0x004478FC File Offset: 0x00445AFC
			public void __clearDele_EventOnSkinInfoButtonClick()
			{
				this.m_owner.__clearDele_EventOnSkinInfoButtonClick();
			}

			// Token: 0x06010658 RID: 67160 RVA: 0x0044790C File Offset: 0x00445B0C
			public void __callDele_EventOnJobUpButtonClick()
			{
				this.m_owner.__callDele_EventOnJobUpButtonClick();
			}

			// Token: 0x06010659 RID: 67161 RVA: 0x0044791C File Offset: 0x00445B1C
			public void __clearDele_EventOnJobUpButtonClick()
			{
				this.m_owner.__clearDele_EventOnJobUpButtonClick();
			}

			// Token: 0x17003282 RID: 12930
			// (get) Token: 0x0601065A RID: 67162 RVA: 0x0044792C File Offset: 0x00445B2C
			// (set) Token: 0x0601065B RID: 67163 RVA: 0x0044793C File Offset: 0x00445B3C
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

			// Token: 0x17003283 RID: 12931
			// (get) Token: 0x0601065C RID: 67164 RVA: 0x0044794C File Offset: 0x00445B4C
			// (set) Token: 0x0601065D RID: 67165 RVA: 0x0044795C File Offset: 0x00445B5C
			public Image m_infoHeroArmyImg
			{
				get
				{
					return this.m_owner.m_infoHeroArmyImg;
				}
				set
				{
					this.m_owner.m_infoHeroArmyImg = value;
				}
			}

			// Token: 0x17003284 RID: 12932
			// (get) Token: 0x0601065E RID: 67166 RVA: 0x0044796C File Offset: 0x00445B6C
			// (set) Token: 0x0601065F RID: 67167 RVA: 0x0044797C File Offset: 0x00445B7C
			public Text m_infoHeroLvText
			{
				get
				{
					return this.m_owner.m_infoHeroLvText;
				}
				set
				{
					this.m_owner.m_infoHeroLvText = value;
				}
			}

			// Token: 0x17003285 RID: 12933
			// (get) Token: 0x06010660 RID: 67168 RVA: 0x0044798C File Offset: 0x00445B8C
			// (set) Token: 0x06010661 RID: 67169 RVA: 0x0044799C File Offset: 0x00445B9C
			public Text m_infoHeroLvMaxText
			{
				get
				{
					return this.m_owner.m_infoHeroLvMaxText;
				}
				set
				{
					this.m_owner.m_infoHeroLvMaxText = value;
				}
			}

			// Token: 0x17003286 RID: 12934
			// (get) Token: 0x06010662 RID: 67170 RVA: 0x004479AC File Offset: 0x00445BAC
			// (set) Token: 0x06010663 RID: 67171 RVA: 0x004479BC File Offset: 0x00445BBC
			public Text m_infoHeroExpText
			{
				get
				{
					return this.m_owner.m_infoHeroExpText;
				}
				set
				{
					this.m_owner.m_infoHeroExpText = value;
				}
			}

			// Token: 0x17003287 RID: 12935
			// (get) Token: 0x06010664 RID: 67172 RVA: 0x004479CC File Offset: 0x00445BCC
			// (set) Token: 0x06010665 RID: 67173 RVA: 0x004479DC File Offset: 0x00445BDC
			public Image m_infoHeroExpImg
			{
				get
				{
					return this.m_owner.m_infoHeroExpImg;
				}
				set
				{
					this.m_owner.m_infoHeroExpImg = value;
				}
			}

			// Token: 0x17003288 RID: 12936
			// (get) Token: 0x06010666 RID: 67174 RVA: 0x004479EC File Offset: 0x00445BEC
			// (set) Token: 0x06010667 RID: 67175 RVA: 0x004479FC File Offset: 0x00445BFC
			public GameObject m_infoHeroGraphic
			{
				get
				{
					return this.m_owner.m_infoHeroGraphic;
				}
				set
				{
					this.m_owner.m_infoHeroGraphic = value;
				}
			}

			// Token: 0x17003289 RID: 12937
			// (get) Token: 0x06010668 RID: 67176 RVA: 0x00447A0C File Offset: 0x00445C0C
			// (set) Token: 0x06010669 RID: 67177 RVA: 0x00447A1C File Offset: 0x00445C1C
			public Button m_propertyMsgButton
			{
				get
				{
					return this.m_owner.m_propertyMsgButton;
				}
				set
				{
					this.m_owner.m_propertyMsgButton = value;
				}
			}

			// Token: 0x1700328A RID: 12938
			// (get) Token: 0x0601066A RID: 67178 RVA: 0x00447A2C File Offset: 0x00445C2C
			// (set) Token: 0x0601066B RID: 67179 RVA: 0x00447A3C File Offset: 0x00445C3C
			public CommonUIStateController m_explanationStateCtrl
			{
				get
				{
					return this.m_owner.m_explanationStateCtrl;
				}
				set
				{
					this.m_owner.m_explanationStateCtrl = value;
				}
			}

			// Token: 0x1700328B RID: 12939
			// (get) Token: 0x0601066C RID: 67180 RVA: 0x00447A4C File Offset: 0x00445C4C
			// (set) Token: 0x0601066D RID: 67181 RVA: 0x00447A5C File Offset: 0x00445C5C
			public Button m_explanationBackgroundButton
			{
				get
				{
					return this.m_owner.m_explanationBackgroundButton;
				}
				set
				{
					this.m_owner.m_explanationBackgroundButton = value;
				}
			}

			// Token: 0x1700328C RID: 12940
			// (get) Token: 0x0601066E RID: 67182 RVA: 0x00447A6C File Offset: 0x00445C6C
			// (set) Token: 0x0601066F RID: 67183 RVA: 0x00447A7C File Offset: 0x00445C7C
			public Text m_explanationText
			{
				get
				{
					return this.m_owner.m_explanationText;
				}
				set
				{
					this.m_owner.m_explanationText = value;
				}
			}

			// Token: 0x1700328D RID: 12941
			// (get) Token: 0x06010670 RID: 67184 RVA: 0x00447A8C File Offset: 0x00445C8C
			// (set) Token: 0x06010671 RID: 67185 RVA: 0x00447A9C File Offset: 0x00445C9C
			public GameObject m_tagButtonsContent
			{
				get
				{
					return this.m_owner.m_tagButtonsContent;
				}
				set
				{
					this.m_owner.m_tagButtonsContent = value;
				}
			}

			// Token: 0x1700328E RID: 12942
			// (get) Token: 0x06010672 RID: 67186 RVA: 0x00447AAC File Offset: 0x00445CAC
			// (set) Token: 0x06010673 RID: 67187 RVA: 0x00447ABC File Offset: 0x00445CBC
			public CommonUIStateController m_tagPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_tagPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_tagPanelStateCtrl = value;
				}
			}

			// Token: 0x1700328F RID: 12943
			// (get) Token: 0x06010674 RID: 67188 RVA: 0x00447ACC File Offset: 0x00445CCC
			// (set) Token: 0x06010675 RID: 67189 RVA: 0x00447ADC File Offset: 0x00445CDC
			public Button m_tagPanelBGButton
			{
				get
				{
					return this.m_owner.m_tagPanelBGButton;
				}
				set
				{
					this.m_owner.m_tagPanelBGButton = value;
				}
			}

			// Token: 0x17003290 RID: 12944
			// (get) Token: 0x06010676 RID: 67190 RVA: 0x00447AEC File Offset: 0x00445CEC
			// (set) Token: 0x06010677 RID: 67191 RVA: 0x00447AFC File Offset: 0x00445CFC
			public Text m_tagPanelTitleText
			{
				get
				{
					return this.m_owner.m_tagPanelTitleText;
				}
				set
				{
					this.m_owner.m_tagPanelTitleText = value;
				}
			}

			// Token: 0x17003291 RID: 12945
			// (get) Token: 0x06010678 RID: 67192 RVA: 0x00447B0C File Offset: 0x00445D0C
			// (set) Token: 0x06010679 RID: 67193 RVA: 0x00447B1C File Offset: 0x00445D1C
			public Text m_tagPanelDescText
			{
				get
				{
					return this.m_owner.m_tagPanelDescText;
				}
				set
				{
					this.m_owner.m_tagPanelDescText = value;
				}
			}

			// Token: 0x17003292 RID: 12946
			// (get) Token: 0x0601067A RID: 67194 RVA: 0x00447B2C File Offset: 0x00445D2C
			// (set) Token: 0x0601067B RID: 67195 RVA: 0x00447B3C File Offset: 0x00445D3C
			public Image m_tagPanelIconImage
			{
				get
				{
					return this.m_owner.m_tagPanelIconImage;
				}
				set
				{
					this.m_owner.m_tagPanelIconImage = value;
				}
			}

			// Token: 0x17003293 RID: 12947
			// (get) Token: 0x0601067C RID: 67196 RVA: 0x00447B4C File Offset: 0x00445D4C
			// (set) Token: 0x0601067D RID: 67197 RVA: 0x00447B5C File Offset: 0x00445D5C
			public GameObject m_tagPanelListScrollViewContent
			{
				get
				{
					return this.m_owner.m_tagPanelListScrollViewContent;
				}
				set
				{
					this.m_owner.m_tagPanelListScrollViewContent = value;
				}
			}

			// Token: 0x17003294 RID: 12948
			// (get) Token: 0x0601067E RID: 67198 RVA: 0x00447B6C File Offset: 0x00445D6C
			// (set) Token: 0x0601067F RID: 67199 RVA: 0x00447B7C File Offset: 0x00445D7C
			public ScrollRect m_tagPanelListScrollRect
			{
				get
				{
					return this.m_owner.m_tagPanelListScrollRect;
				}
				set
				{
					this.m_owner.m_tagPanelListScrollRect = value;
				}
			}

			// Token: 0x17003295 RID: 12949
			// (get) Token: 0x06010680 RID: 67200 RVA: 0x00447B8C File Offset: 0x00445D8C
			// (set) Token: 0x06010681 RID: 67201 RVA: 0x00447B9C File Offset: 0x00445D9C
			public GameObject m_tagPanelHeroIconImagePrefab
			{
				get
				{
					return this.m_owner.m_tagPanelHeroIconImagePrefab;
				}
				set
				{
					this.m_owner.m_tagPanelHeroIconImagePrefab = value;
				}
			}

			// Token: 0x17003296 RID: 12950
			// (get) Token: 0x06010682 RID: 67202 RVA: 0x00447BAC File Offset: 0x00445DAC
			// (set) Token: 0x06010683 RID: 67203 RVA: 0x00447BBC File Offset: 0x00445DBC
			public Button m_tagPanelCloseBtn
			{
				get
				{
					return this.m_owner.m_tagPanelCloseBtn;
				}
				set
				{
					this.m_owner.m_tagPanelCloseBtn = value;
				}
			}

			// Token: 0x17003297 RID: 12951
			// (get) Token: 0x06010684 RID: 67204 RVA: 0x00447BCC File Offset: 0x00445DCC
			// (set) Token: 0x06010685 RID: 67205 RVA: 0x00447BDC File Offset: 0x00445DDC
			public Image m_infoHeroPropHPImg
			{
				get
				{
					return this.m_owner.m_infoHeroPropHPImg;
				}
				set
				{
					this.m_owner.m_infoHeroPropHPImg = value;
				}
			}

			// Token: 0x17003298 RID: 12952
			// (get) Token: 0x06010686 RID: 67206 RVA: 0x00447BEC File Offset: 0x00445DEC
			// (set) Token: 0x06010687 RID: 67207 RVA: 0x00447BFC File Offset: 0x00445DFC
			public Image m_infoHeroPropDFImg
			{
				get
				{
					return this.m_owner.m_infoHeroPropDFImg;
				}
				set
				{
					this.m_owner.m_infoHeroPropDFImg = value;
				}
			}

			// Token: 0x17003299 RID: 12953
			// (get) Token: 0x06010688 RID: 67208 RVA: 0x00447C0C File Offset: 0x00445E0C
			// (set) Token: 0x06010689 RID: 67209 RVA: 0x00447C1C File Offset: 0x00445E1C
			public Image m_infoHeroPropATImg
			{
				get
				{
					return this.m_owner.m_infoHeroPropATImg;
				}
				set
				{
					this.m_owner.m_infoHeroPropATImg = value;
				}
			}

			// Token: 0x1700329A RID: 12954
			// (get) Token: 0x0601068A RID: 67210 RVA: 0x00447C2C File Offset: 0x00445E2C
			// (set) Token: 0x0601068B RID: 67211 RVA: 0x00447C3C File Offset: 0x00445E3C
			public Image m_infoHeroPropMagicDFImg
			{
				get
				{
					return this.m_owner.m_infoHeroPropMagicDFImg;
				}
				set
				{
					this.m_owner.m_infoHeroPropMagicDFImg = value;
				}
			}

			// Token: 0x1700329B RID: 12955
			// (get) Token: 0x0601068C RID: 67212 RVA: 0x00447C4C File Offset: 0x00445E4C
			// (set) Token: 0x0601068D RID: 67213 RVA: 0x00447C5C File Offset: 0x00445E5C
			public Image m_infoHeroPropMagicImg
			{
				get
				{
					return this.m_owner.m_infoHeroPropMagicImg;
				}
				set
				{
					this.m_owner.m_infoHeroPropMagicImg = value;
				}
			}

			// Token: 0x1700329C RID: 12956
			// (get) Token: 0x0601068E RID: 67214 RVA: 0x00447C6C File Offset: 0x00445E6C
			// (set) Token: 0x0601068F RID: 67215 RVA: 0x00447C7C File Offset: 0x00445E7C
			public Image m_infoHeroPropDEXImg
			{
				get
				{
					return this.m_owner.m_infoHeroPropDEXImg;
				}
				set
				{
					this.m_owner.m_infoHeroPropDEXImg = value;
				}
			}

			// Token: 0x1700329D RID: 12957
			// (get) Token: 0x06010690 RID: 67216 RVA: 0x00447C8C File Offset: 0x00445E8C
			// (set) Token: 0x06010691 RID: 67217 RVA: 0x00447C9C File Offset: 0x00445E9C
			public Text m_infoHeroPropHPValueText
			{
				get
				{
					return this.m_owner.m_infoHeroPropHPValueText;
				}
				set
				{
					this.m_owner.m_infoHeroPropHPValueText = value;
				}
			}

			// Token: 0x1700329E RID: 12958
			// (get) Token: 0x06010692 RID: 67218 RVA: 0x00447CAC File Offset: 0x00445EAC
			// (set) Token: 0x06010693 RID: 67219 RVA: 0x00447CBC File Offset: 0x00445EBC
			public Text m_infoHeroPropDFValueText
			{
				get
				{
					return this.m_owner.m_infoHeroPropDFValueText;
				}
				set
				{
					this.m_owner.m_infoHeroPropDFValueText = value;
				}
			}

			// Token: 0x1700329F RID: 12959
			// (get) Token: 0x06010694 RID: 67220 RVA: 0x00447CCC File Offset: 0x00445ECC
			// (set) Token: 0x06010695 RID: 67221 RVA: 0x00447CDC File Offset: 0x00445EDC
			public Text m_infoHeroPropATValueText
			{
				get
				{
					return this.m_owner.m_infoHeroPropATValueText;
				}
				set
				{
					this.m_owner.m_infoHeroPropATValueText = value;
				}
			}

			// Token: 0x170032A0 RID: 12960
			// (get) Token: 0x06010696 RID: 67222 RVA: 0x00447CEC File Offset: 0x00445EEC
			// (set) Token: 0x06010697 RID: 67223 RVA: 0x00447CFC File Offset: 0x00445EFC
			public Text m_infoHeroPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_infoHeroPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_infoHeroPropMagicDFValueText = value;
				}
			}

			// Token: 0x170032A1 RID: 12961
			// (get) Token: 0x06010698 RID: 67224 RVA: 0x00447D0C File Offset: 0x00445F0C
			// (set) Token: 0x06010699 RID: 67225 RVA: 0x00447D1C File Offset: 0x00445F1C
			public Text m_infoHeroPropMagicValueText
			{
				get
				{
					return this.m_owner.m_infoHeroPropMagicValueText;
				}
				set
				{
					this.m_owner.m_infoHeroPropMagicValueText = value;
				}
			}

			// Token: 0x170032A2 RID: 12962
			// (get) Token: 0x0601069A RID: 67226 RVA: 0x00447D2C File Offset: 0x00445F2C
			// (set) Token: 0x0601069B RID: 67227 RVA: 0x00447D3C File Offset: 0x00445F3C
			public Text m_infoHeroPropDEXValueText
			{
				get
				{
					return this.m_owner.m_infoHeroPropDEXValueText;
				}
				set
				{
					this.m_owner.m_infoHeroPropDEXValueText = value;
				}
			}

			// Token: 0x170032A3 RID: 12963
			// (get) Token: 0x0601069C RID: 67228 RVA: 0x00447D4C File Offset: 0x00445F4C
			// (set) Token: 0x0601069D RID: 67229 RVA: 0x00447D5C File Offset: 0x00445F5C
			public Text m_infoHeroPropHPAddText
			{
				get
				{
					return this.m_owner.m_infoHeroPropHPAddText;
				}
				set
				{
					this.m_owner.m_infoHeroPropHPAddText = value;
				}
			}

			// Token: 0x170032A4 RID: 12964
			// (get) Token: 0x0601069E RID: 67230 RVA: 0x00447D6C File Offset: 0x00445F6C
			// (set) Token: 0x0601069F RID: 67231 RVA: 0x00447D7C File Offset: 0x00445F7C
			public Text m_infoHeroPropDFAddText
			{
				get
				{
					return this.m_owner.m_infoHeroPropDFAddText;
				}
				set
				{
					this.m_owner.m_infoHeroPropDFAddText = value;
				}
			}

			// Token: 0x170032A5 RID: 12965
			// (get) Token: 0x060106A0 RID: 67232 RVA: 0x00447D8C File Offset: 0x00445F8C
			// (set) Token: 0x060106A1 RID: 67233 RVA: 0x00447D9C File Offset: 0x00445F9C
			public Text m_infoHeroPropATAddText
			{
				get
				{
					return this.m_owner.m_infoHeroPropATAddText;
				}
				set
				{
					this.m_owner.m_infoHeroPropATAddText = value;
				}
			}

			// Token: 0x170032A6 RID: 12966
			// (get) Token: 0x060106A2 RID: 67234 RVA: 0x00447DAC File Offset: 0x00445FAC
			// (set) Token: 0x060106A3 RID: 67235 RVA: 0x00447DBC File Offset: 0x00445FBC
			public Text m_infoHeroPropMagicDFAddText
			{
				get
				{
					return this.m_owner.m_infoHeroPropMagicDFAddText;
				}
				set
				{
					this.m_owner.m_infoHeroPropMagicDFAddText = value;
				}
			}

			// Token: 0x170032A7 RID: 12967
			// (get) Token: 0x060106A4 RID: 67236 RVA: 0x00447DCC File Offset: 0x00445FCC
			// (set) Token: 0x060106A5 RID: 67237 RVA: 0x00447DDC File Offset: 0x00445FDC
			public Text m_infoHeroPropMagicAddText
			{
				get
				{
					return this.m_owner.m_infoHeroPropMagicAddText;
				}
				set
				{
					this.m_owner.m_infoHeroPropMagicAddText = value;
				}
			}

			// Token: 0x170032A8 RID: 12968
			// (get) Token: 0x060106A6 RID: 67238 RVA: 0x00447DEC File Offset: 0x00445FEC
			// (set) Token: 0x060106A7 RID: 67239 RVA: 0x00447DFC File Offset: 0x00445FFC
			public Text m_infoHeroPropDEXAddText
			{
				get
				{
					return this.m_owner.m_infoHeroPropDEXAddText;
				}
				set
				{
					this.m_owner.m_infoHeroPropDEXAddText = value;
				}
			}

			// Token: 0x170032A9 RID: 12969
			// (get) Token: 0x060106A8 RID: 67240 RVA: 0x00447E0C File Offset: 0x0044600C
			// (set) Token: 0x060106A9 RID: 67241 RVA: 0x00447E1C File Offset: 0x0044601C
			public Image m_infoHeroTalentIcon
			{
				get
				{
					return this.m_owner.m_infoHeroTalentIcon;
				}
				set
				{
					this.m_owner.m_infoHeroTalentIcon = value;
				}
			}

			// Token: 0x170032AA RID: 12970
			// (get) Token: 0x060106AA RID: 67242 RVA: 0x00447E2C File Offset: 0x0044602C
			// (set) Token: 0x060106AB RID: 67243 RVA: 0x00447E3C File Offset: 0x0044603C
			public Text m_infoHeroTalentNameText
			{
				get
				{
					return this.m_owner.m_infoHeroTalentNameText;
				}
				set
				{
					this.m_owner.m_infoHeroTalentNameText = value;
				}
			}

			// Token: 0x170032AB RID: 12971
			// (get) Token: 0x060106AC RID: 67244 RVA: 0x00447E4C File Offset: 0x0044604C
			// (set) Token: 0x060106AD RID: 67245 RVA: 0x00447E5C File Offset: 0x0044605C
			public Text m_infoHeroTalentDescText
			{
				get
				{
					return this.m_owner.m_infoHeroTalentDescText;
				}
				set
				{
					this.m_owner.m_infoHeroTalentDescText = value;
				}
			}

			// Token: 0x170032AC RID: 12972
			// (get) Token: 0x060106AE RID: 67246 RVA: 0x00447E6C File Offset: 0x0044606C
			// (set) Token: 0x060106AF RID: 67247 RVA: 0x00447E7C File Offset: 0x0044607C
			public GameObject m_infoHeroCurSkillCostsObj
			{
				get
				{
					return this.m_owner.m_infoHeroCurSkillCostsObj;
				}
				set
				{
					this.m_owner.m_infoHeroCurSkillCostsObj = value;
				}
			}

			// Token: 0x170032AD RID: 12973
			// (get) Token: 0x060106B0 RID: 67248 RVA: 0x00447E8C File Offset: 0x0044608C
			// (set) Token: 0x060106B1 RID: 67249 RVA: 0x00447E9C File Offset: 0x0044609C
			public GameObject m_infoHeroCurSkillContent
			{
				get
				{
					return this.m_owner.m_infoHeroCurSkillContent;
				}
				set
				{
					this.m_owner.m_infoHeroCurSkillContent = value;
				}
			}

			// Token: 0x170032AE RID: 12974
			// (get) Token: 0x060106B2 RID: 67250 RVA: 0x00447EAC File Offset: 0x004460AC
			// (set) Token: 0x060106B3 RID: 67251 RVA: 0x00447EBC File Offset: 0x004460BC
			public GameObject m_infoHeroCurSkillContentBg
			{
				get
				{
					return this.m_owner.m_infoHeroCurSkillContentBg;
				}
				set
				{
					this.m_owner.m_infoHeroCurSkillContentBg = value;
				}
			}

			// Token: 0x170032AF RID: 12975
			// (get) Token: 0x060106B4 RID: 67252 RVA: 0x00447ECC File Offset: 0x004460CC
			// (set) Token: 0x060106B5 RID: 67253 RVA: 0x00447EDC File Offset: 0x004460DC
			public Button m_infoHeroCurSkillChangeButton
			{
				get
				{
					return this.m_owner.m_infoHeroCurSkillChangeButton;
				}
				set
				{
					this.m_owner.m_infoHeroCurSkillChangeButton = value;
				}
			}

			// Token: 0x170032B0 RID: 12976
			// (get) Token: 0x060106B6 RID: 67254 RVA: 0x00447EEC File Offset: 0x004460EC
			// (set) Token: 0x060106B7 RID: 67255 RVA: 0x00447EFC File Offset: 0x004460FC
			public GameObject m_infoCurSkillDescPanel
			{
				get
				{
					return this.m_owner.m_infoCurSkillDescPanel;
				}
				set
				{
					this.m_owner.m_infoCurSkillDescPanel = value;
				}
			}

			// Token: 0x170032B1 RID: 12977
			// (get) Token: 0x060106B8 RID: 67256 RVA: 0x00447F0C File Offset: 0x0044610C
			// (set) Token: 0x060106B9 RID: 67257 RVA: 0x00447F1C File Offset: 0x0044611C
			public Button m_infoAddExpButton
			{
				get
				{
					return this.m_owner.m_infoAddExpButton;
				}
				set
				{
					this.m_owner.m_infoAddExpButton = value;
				}
			}

			// Token: 0x170032B2 RID: 12978
			// (get) Token: 0x060106BA RID: 67258 RVA: 0x00447F2C File Offset: 0x0044612C
			// (set) Token: 0x060106BB RID: 67259 RVA: 0x00447F3C File Offset: 0x0044613C
			public Button m_skinInfoButton
			{
				get
				{
					return this.m_owner.m_skinInfoButton;
				}
				set
				{
					this.m_owner.m_skinInfoButton = value;
				}
			}

			// Token: 0x170032B3 RID: 12979
			// (get) Token: 0x060106BC RID: 67260 RVA: 0x00447F4C File Offset: 0x0044614C
			// (set) Token: 0x060106BD RID: 67261 RVA: 0x00447F5C File Offset: 0x0044615C
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

			// Token: 0x170032B4 RID: 12980
			// (get) Token: 0x060106BE RID: 67262 RVA: 0x00447F6C File Offset: 0x0044616C
			// (set) Token: 0x060106BF RID: 67263 RVA: 0x00447F7C File Offset: 0x0044617C
			public UISpineGraphic m_playerHeroGraphic
			{
				get
				{
					return this.m_owner.m_playerHeroGraphic;
				}
				set
				{
					this.m_owner.m_playerHeroGraphic = value;
				}
			}

			// Token: 0x170032B5 RID: 12981
			// (get) Token: 0x060106C0 RID: 67264 RVA: 0x00447F8C File Offset: 0x0044618C
			// (set) Token: 0x060106C1 RID: 67265 RVA: 0x00447F9C File Offset: 0x0044619C
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

			// Token: 0x170032B6 RID: 12982
			// (get) Token: 0x060106C2 RID: 67266 RVA: 0x00447FAC File Offset: 0x004461AC
			// (set) Token: 0x060106C3 RID: 67267 RVA: 0x00447FBC File Offset: 0x004461BC
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

			// Token: 0x060106C4 RID: 67268 RVA: 0x00447FCC File Offset: 0x004461CC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060106C5 RID: 67269 RVA: 0x00447FDC File Offset: 0x004461DC
			public void ShowHeroInfo()
			{
				this.m_owner.ShowHeroInfo();
			}

			// Token: 0x060106C6 RID: 67270 RVA: 0x00447FEC File Offset: 0x004461EC
			public void SetHeroTagInfo()
			{
				this.m_owner.SetHeroTagInfo();
			}

			// Token: 0x060106C7 RID: 67271 RVA: 0x00447FFC File Offset: 0x004461FC
			public void OpenTagPanel(ConfigDataHeroTagInfo tagInfo)
			{
				this.m_owner.OpenTagPanel(tagInfo);
			}

			// Token: 0x060106C8 RID: 67272 RVA: 0x0044800C File Offset: 0x0044620C
			public void SetTagPanelInfo(ConfigDataHeroTagInfo tagInfo)
			{
				this.m_owner.SetTagPanelInfo(tagInfo);
			}

			// Token: 0x060106C9 RID: 67273 RVA: 0x0044801C File Offset: 0x0044621C
			public int SortRelatedHeroIdByRank(int heroId1, int heroId2)
			{
				return this.m_owner.SortRelatedHeroIdByRank(heroId1, heroId2);
			}

			// Token: 0x060106CA RID: 67274 RVA: 0x0044802C File Offset: 0x0044622C
			public void CloseTagPanel()
			{
				this.m_owner.CloseTagPanel();
			}

			// Token: 0x060106CB RID: 67275 RVA: 0x0044803C File Offset: 0x0044623C
			public void SetHeroProperty(Hero hero)
			{
				this.m_owner.SetHeroProperty(hero);
			}

			// Token: 0x060106CC RID: 67276 RVA: 0x0044804C File Offset: 0x0044624C
			public void SetHeroTalent(Hero hero)
			{
				this.m_owner.SetHeroTalent(hero);
			}

			// Token: 0x060106CD RID: 67277 RVA: 0x0044805C File Offset: 0x0044625C
			public void SetCurSelectSkills()
			{
				this.m_owner.SetCurSelectSkills();
			}

			// Token: 0x060106CE RID: 67278 RVA: 0x0044806C File Offset: 0x0044626C
			public void OnSkillItemClick(HeroSkillItemUIController skillCtrl)
			{
				this.m_owner.OnSkillItemClick(skillCtrl);
			}

			// Token: 0x060106CF RID: 67279 RVA: 0x0044807C File Offset: 0x0044627C
			public void OnAddExpButtonClick()
			{
				this.m_owner.OnAddExpButtonClick();
			}

			// Token: 0x060106D0 RID: 67280 RVA: 0x0044808C File Offset: 0x0044628C
			public void OnSkinInfoButtonClcik()
			{
				this.m_owner.OnSkinInfoButtonClcik();
			}

			// Token: 0x060106D1 RID: 67281 RVA: 0x0044809C File Offset: 0x0044629C
			public void OnJobUpButtonClick()
			{
				this.m_owner.OnJobUpButtonClick();
			}

			// Token: 0x060106D2 RID: 67282 RVA: 0x004480AC File Offset: 0x004462AC
			public void OnChangeSkillButtonClick()
			{
				this.m_owner.OnChangeSkillButtonClick();
			}

			// Token: 0x060106D3 RID: 67283 RVA: 0x004480BC File Offset: 0x004462BC
			public void OnPropertyMsgButtonClick()
			{
				this.m_owner.OnPropertyMsgButtonClick();
			}

			// Token: 0x060106D4 RID: 67284 RVA: 0x004480CC File Offset: 0x004462CC
			public void OnExplanationBackgroundButtonClick()
			{
				this.m_owner.OnExplanationBackgroundButtonClick();
			}

			// Token: 0x0400987C RID: 39036
			private HeroDetailInfoUIController m_owner;
		}
	}
}
