using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A5E RID: 2654
	[HotFix]
	public class BattleActorInfoUIController : UIControllerBase
	{
		// Token: 0x0600A5A3 RID: 42403 RVA: 0x002E8A20 File Offset: 0x002E6C20
		private BattleActorInfoUIController()
		{
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x002E8A28 File Offset: 0x002E6C28
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
			this.m_isOpened = false;
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x002E8A90 File Offset: 0x002E6C90
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
			this.m_skillDescPool = new GameObjectPool<SkillDesc>();
			this.m_skillDescPool.Setup(this.m_skillDescPrefab, this.m_skillListGameObject);
			this.m_buffDescPool = new GameObjectPool<BuffDesc>();
			this.m_buffDescPool.Setup(this.m_buffDescPrefab, this.m_buffsDescContentGameObject);
			PointDescComponent pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(this.m_soldierDetailPanelUIStateController.gameObject);
			pointDescComponent.SetGameObject(this.m_soldierDetailPanelUIStateController.gameObject, false, null, null);
			pointDescComponent.EventOnClose += delegate()
			{
				UIUtility.SetUIStateClose(this.m_soldierDetailPanelUIStateController, "Close", null, false, true);
			};
			pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(this.m_skillDetailPanel);
			pointDescComponent.SetGameObject(this.m_skillDetailListGameObject, false, this.m_skillDetailPanel, null);
			pointDescComponent.EventOnClose += delegate()
			{
				this.m_skillDetailPanel.SetActive(false);
			};
			pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(this.m_buffDescDetailGameObject);
			pointDescComponent.SetGameObject(this.m_buffsDescDetailListGameObject, false, this.m_buffDescDetailGameObject, null);
			pointDescComponent.EventOnClose += delegate()
			{
				this.m_buffDescDetailGameObject.SetActive(false);
			};
			this.m_soldierDetailButton.onClick.AddListener(delegate()
			{
				UIUtility.SetUIStateOpen(this.m_soldierDetailPanelUIStateController, "Show", null, false, true);
			});
			this.m_skillInfoButtonGo.onClick.AddListener(delegate()
			{
				this.m_skillDetailPanel.SetActive(true);
			});
			this.m_buffsListGameObject.onClick.AddListener(delegate()
			{
				this.m_buffDescDetailGameObject.SetActive(true);
			});
			this.m_noBuffsGameObject.SetActive(false);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x002E8C44 File Offset: 0x002E6E44
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
			base.gameObject.SetActive(true);
			if (!this.m_isOpened)
			{
				bool activeSelf = this.m_soldierGameObject.activeSelf;
				UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
				this.m_soldierGameObject.SetActive(activeSelf);
			}
			AudioUtility.PlaySound(SoundTableId.SoundTableId_SelectHero);
			this.m_isOpened = true;
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x002E8CF4 File Offset: 0x002E6EF4
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
			bool activeSelf = this.m_soldierGameObject.activeSelf;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
			{
				if (this.m_soldierGraphic != null)
				{
					this.DestroySpineGraphic(this.m_soldierGraphic);
					this.m_soldierGraphic = null;
				}
				if (this.m_soldierDetailGraphic != null)
				{
					this.DestroySpineGraphic(this.m_soldierDetailGraphic);
					this.m_soldierGraphic = null;
				}
			}, false, true);
			this.m_soldierGameObject.SetActive(activeSelf);
			this.m_isOpened = false;
			this.m_skillDescPool.Deactive();
			this.m_soldierDetailPanelUIStateController.gameObject.SetActive(false);
			this.m_skillDetailPanel.SetActive(false);
			this.m_buffDescDetailGameObject.SetActive(false);
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x002E8DD4 File Offset: 0x002E6FD4
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

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x002E8E48 File Offset: 0x002E7048
		public void SetActorInfo(BattleActor a, int myPlayerTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActorInfoBattleActorInt32_hotfix != null)
			{
				this.m_SetActorInfoBattleActorInt32_hotfix.call(new object[]
				{
					this,
					a,
					myPlayerTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (a == null)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (a.HeroInfo != null)
			{
				this.m_heroNameText.text = a.HeroInfo.Name;
				this.m_heroLevelText.text = a.HeroLevel.ToString();
				this.m_heroJobText.text = a.JobInfo.Name;
				this.m_heroArmyText.text = a.HeroArmyInfo.Name;
				ConfigDataCharImageInfo charImageInfo = a.HeroInfo.GetCharImageInfo(a.HeroStar);
				if (charImageInfo != null)
				{
					this.m_heroIcon.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
				}
				if (a.IsNpc())
				{
					this.m_heroPanelGroupCtrl.SetToUIState("NeutralRight", false, true);
				}
				else if (a.TeamNumber == myPlayerTeam)
				{
					this.m_heroPanelGroupCtrl.SetToUIState("WeRight", false, true);
				}
				else
				{
					this.m_heroPanelGroupCtrl.SetToUIState("EnemyRight", false, true);
				}
				this.m_heroArmyIcon.sprite = AssetUtility.Instance.GetSprite(a.HeroArmyInfo.Icon);
				this.m_heroHPText.text = a.HeroHealthPoint + " / " + a.HeroBattleProperty.HealthPointMax;
				if (a.HeroHealthPoint > 0 && a.HeroBattleProperty.HealthPointMax > 0)
				{
					this.m_heroHPImage.fillAmount = (float)a.HeroHealthPoint / (float)a.HeroBattleProperty.HealthPointMax;
				}
				else
				{
					this.m_heroHPImage.fillAmount = 0f;
				}
				this.m_heroHPImage.sprite = AssetUtility.Instance.GetSprite((a.TeamNumber != myPlayerTeam) ? "UI/Common_New_ABS/Pattern_Blood_Red01.png" : "UI/Common_New_ABS/Pattern_Blood_Green01.png");
				HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
				heroPropertyComputer.Init(configDataLoader);
				heroPropertyComputer.ComputeHeroBuffProperties(a);
				HeroPropertyComputer heroPropertyComputer2 = new HeroPropertyComputer();
				if (a.SoldierInfo != null)
				{
					heroPropertyComputer2.Init(configDataLoader);
					heroPropertyComputer2.ComputeSoldierBuffCommandProperties(a);
				}
				this.m_heroAttackText.text = this.CalcPropValue(heroPropertyComputer.Property0.Attack, heroPropertyComputer.Property1.Attack, false);
				this.m_heroDefenseText.text = this.CalcPropValue(heroPropertyComputer.Property0.Defense, heroPropertyComputer.Property1.Defense, false);
				this.m_heroMagicText.text = this.CalcPropValue(heroPropertyComputer.Property0.Magic, heroPropertyComputer.Property1.Magic, false);
				this.m_heroMagicDefenseText.text = this.CalcPropValue(heroPropertyComputer.Property0.MagicDefense, heroPropertyComputer.Property1.MagicDefense, false);
				this.m_heroDEXText.text = this.CalcPropValue(heroPropertyComputer.Property0.Dexterity, heroPropertyComputer.Property1.Dexterity, false);
				int v;
				int v2;
				if (a.SoldierInfo == null || a.SoldierTotalHealthPoint <= 0)
				{
					v = heroPropertyComputer.Property0.AttackDistance;
					v2 = heroPropertyComputer.Property1.AttackDistance;
				}
				else
				{
					v = Mathf.Max(heroPropertyComputer.Property0.AttackDistance, heroPropertyComputer2.Property0.AttackDistance);
					v2 = Mathf.Max(heroPropertyComputer.Property1.AttackDistance, heroPropertyComputer2.Property1.AttackDistance);
				}
				this.m_heroRangeText.text = this.CalcPropValue(v, v2, false);
				int v3;
				int v4;
				if (a.SoldierInfo == null)
				{
					v3 = heroPropertyComputer.Property0.MovePoint;
					v4 = heroPropertyComputer.Property1.MovePoint;
				}
				else
				{
					v3 = Mathf.Min(heroPropertyComputer.Property0.MovePoint, heroPropertyComputer2.Property0.MovePoint);
					v4 = Mathf.Min(heroPropertyComputer.Property1.MovePoint, heroPropertyComputer2.Property1.MovePoint);
				}
				this.m_heroMoveText.text = this.CalcPropValue(v3, v4, false);
			}
			else
			{
				this.m_heroNameText.text = string.Empty;
				this.m_heroLevelText.text = string.Empty;
				this.m_heroJobText.text = string.Empty;
				this.m_heroArmyText.text = string.Empty;
				this.m_heroHPText.text = string.Empty;
				this.m_heroHPImage.fillAmount = 0f;
				this.m_heroAttackText.text = string.Empty;
				this.m_heroDefenseText.text = string.Empty;
				this.m_heroMagicText.text = string.Empty;
				this.m_heroMagicDefenseText.text = string.Empty;
				this.m_heroDEXText.text = string.Empty;
				this.m_heroRangeText.text = string.Empty;
				this.m_heroMoveText.text = string.Empty;
			}
			this.m_soldierGameObject.SetActive(a.SoldierInfo != null);
			if (a.SoldierInfo != null)
			{
				this.m_soldierNameText.text = a.SoldierInfo.Name;
				this.m_soldierArmyIcon.sprite = AssetUtility.Instance.GetSprite(a.SoldierArmyInfo.Icon);
				HeroPropertyComputer heroPropertyComputer3 = new HeroPropertyComputer();
				heroPropertyComputer3.Init(configDataLoader);
				heroPropertyComputer3.ComputeSoldierBuffCommandProperties(a);
				this.m_soldierDefenseText.text = this.CalcPropValue(heroPropertyComputer3.Property0.Defense, heroPropertyComputer3.Property1.Defense, false);
				this.m_soldierAttackText.text = this.CalcPropValue(heroPropertyComputer3.Property0.Attack, heroPropertyComputer3.Property1.Attack, false);
				this.m_soldierMagicDFText.text = this.CalcPropValue(heroPropertyComputer3.Property0.MagicDefense, heroPropertyComputer3.Property1.MagicDefense, false);
				this.m_soldierDefenseAddText.text = this.CalcPropValue(heroPropertyComputer3.Property1.Defense, heroPropertyComputer3.Property2.Defense, true);
				this.m_soldierAttackAddText.text = this.CalcPropValue(heroPropertyComputer3.Property1.Attack, heroPropertyComputer3.Property2.Attack, true);
				this.m_soldierMagicDFAddText.text = this.CalcPropValue(heroPropertyComputer3.Property1.MagicDefense, heroPropertyComputer3.Property2.MagicDefense, true);
				this.m_soldierHPImage.fillAmount = (float)a.SoldierTotalHealthPoint / (float)a.SoldierBattleProperty.HealthPointMax;
				this.m_soldierHPText.text = a.SoldierTotalHealthPoint + "/" + a.SoldierBattleProperty.HealthPointMax;
				this.m_soldierHPImage.sprite = AssetUtility.Instance.GetSprite((a.TeamNumber != myPlayerTeam) ? "UI/Common_New_ABS/Pattern_Blood_Red01.png" : "UI/Common_New_ABS/Pattern_Blood_Green01.png");
				string text = string.Empty;
				if (a.SoldierModelSkinResourceInfo != null)
				{
					text = a.SoldierModelSkinResourceInfo.Model;
				}
				if (string.IsNullOrEmpty(text))
				{
					if (a.TeamNumber == myPlayerTeam)
					{
						text = a.SoldierInfo.Model;
					}
					else
					{
						text = a.SoldierInfo.Model2;
					}
				}
				float scale = (float)a.SoldierInfo.UI_ModelScale * 0.012f;
				Vector2 offset = new Vector2((float)a.SoldierInfo.UI_ModelOffsetX, (float)a.SoldierInfo.UI_ModelOffsetY);
				this.DestroySpineGraphic(this.m_soldierGraphic);
				this.m_soldierGraphic = this.CreateSpineGraphic(text, scale, offset, this.m_soldierGraphicGameObject, a.SoldierInfo.ReplaceAnims);
			}
			else
			{
				this.m_soldierNameText.text = string.Empty;
				this.m_soldierHPText.text = string.Empty;
				this.m_soldierAttackText.text = string.Empty;
				this.m_soldierDefenseText.text = string.Empty;
				this.m_soldierMagicDFText.text = string.Empty;
				this.DestroySpineGraphic(this.m_soldierGraphic);
				this.m_soldierGraphic = null;
			}
			this.m_skillDescPool.Deactive();
			List<BattleSkillState> skillStates = a.GetSkillStates();
			this.m_skillListGameObject.SetActive(skillStates.Count != 0);
			if (skillStates.Count != 0)
			{
				foreach (BattleSkillState battleSkillState in a.GetSkillStates())
				{
					SkillDesc skillDesc = this.m_skillDescPool.Allocate();
					if (skillDesc != null)
					{
						skillDesc.SetSkill(battleSkillState.m_skillInfo);
					}
				}
			}
			List<GameObject> list = new List<GameObject>
			{
				this.m_skillInfoGroupSkillGo,
				this.m_skillInfoGroupSkillGo2,
				this.m_skillInfoGroupSkillGo3
			};
			for (int i = 0; i < list.Count; i++)
			{
				GameObject gameObject = list[i];
				CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
				if (i < skillStates.Count)
				{
					component.SetToUIState("Have", false, true);
					GameObject gameObject2 = Utility.FindChildGameObject(gameObject, "IconImage", true);
					gameObject2.GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(skillStates[i].m_skillInfo.Icon);
				}
				else
				{
					component.SetToUIState("NoHave", false, true);
				}
			}
			ConfigDataSkillInfo talentSkillInfo = a.GetTalentSkillInfo();
			if (talentSkillInfo != null)
			{
				this.m_skillTalentGameObject.SetActive(true);
				this.m_skillTalentIcon.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo.Icon);
				this.m_skillTalentNameText.text = talentSkillInfo.Name;
				this.m_skillTalentDescText.text = talentSkillInfo.Desc;
				this.m_skillInfoGroupTalentSkillImage.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo.Icon);
			}
			this.m_skillTalentGameObject.SetActive(talentSkillInfo != null);
			this.m_skillInfoGroupTalentSkillImage.gameObject.SetActive(talentSkillInfo != null);
			this.m_skillLineImage.gameObject.SetActive(a.GetSkillStates().Count != 0 && talentSkillInfo != null);
			this.m_skillListContentGameObject.SetActive(a.GetSkillStates().Count != 0 || talentSkillInfo != null);
			this.m_noSkillsAndTalentGameObject.SetActive(a.GetSkillStates().Count == 0 && talentSkillInfo == null);
			this.m_debugBuffToggle.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper);
			bool flag = this.m_debugBuffToggle.gameObject.activeSelf && this.m_debugBuffToggle.isOn;
			int num = 0;
			Transform transform = this.m_buffsListGameObject.transform;
			for (int j = 0; j < transform.childCount; j++)
			{
				transform.GetChild(j).gameObject.SetActive(false);
			}
			List<BuffState> buffStates = a.GetBuffStates();
			for (int k = 0; k < buffStates.Count; k++)
			{
				BuffState buffState = buffStates[k];
				if (buffState.m_buffInfo.IconDisplay)
				{
					if (a.IsBuffEffective(buffState))
					{
						num++;
						GameObject gameObject3;
						if (k >= transform.childCount)
						{
							gameObject3 = UnityEngine.Object.Instantiate<GameObject>(this.m_buffIconPrefab);
							gameObject3.transform.SetParent(this.m_buffsListGameObject.transform, false);
						}
						else
						{
							gameObject3 = transform.GetChild(k).gameObject;
						}
						gameObject3.GetComponent<Image>().sprite = AssetUtility.Instance.GetSprite(buffState.m_buffInfo.Icon);
						string text2 = (buffState.m_time <= 500) ? buffState.m_time.ToString() : string.Empty;
						gameObject3.GetComponentsInChildren<Text>()[0].text = text2;
						gameObject3.SetActive(true);
					}
				}
			}
			this.m_buffsListGameObject.gameObject.SetActive(num != 0 || flag);
			this.m_buffDescPool.Deactive();
			num = 0;
			foreach (BuffState buffState2 in a.GetBuffStates())
			{
				if (buffState2.m_buffInfo.IconDisplay || flag)
				{
					if (a.IsBuffEffective(buffState2))
					{
						BuffDesc buffDesc = this.m_buffDescPool.Allocate();
						if (buffDesc != null)
						{
							buffDesc.SetBuff(buffState2.m_buffInfo);
							buffDesc.SetTime(buffState2.m_time);
							if (flag)
							{
								buffDesc.AppendDebugText(string.Format(" [{0}]", buffState2.m_buffInfo.ID));
							}
						}
						num++;
					}
				}
			}
			this.m_buffsDescContentGameObject.SetActive(num != 0);
			this.m_noBuffsGameObject.SetActive(num == 0);
			if (a.SoldierInfo != null)
			{
				this.SetSoldierDetailInfo(a, a.SoldierInfo, myPlayerTeam);
			}
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x002E9BF0 File Offset: 0x002E7DF0
		private void SetSoldierDetailInfo(BattleActor a, ConfigDataSoldierInfo soldierInfo, int myPlayerTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierDetailInfoBattleActorConfigDataSoldierInfoInt32_hotfix != null)
			{
				this.m_SetSoldierDetailInfoBattleActorConfigDataSoldierInfoInt32_hotfix.call(new object[]
				{
					this,
					a,
					soldierInfo,
					myPlayerTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierTitleText.text = soldierInfo.Name;
			this.m_soldierIconImg.sprite = AssetUtility.Instance.GetSprite(soldierInfo.m_armyInfo.Icon);
			string text = string.Empty;
			if (a.SoldierModelSkinResourceInfo != null)
			{
				text = a.SoldierModelSkinResourceInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				if (a.TeamNumber == myPlayerTeam)
				{
					text = soldierInfo.Model;
				}
				else
				{
					text = soldierInfo.Model2;
				}
			}
			float scale = (float)soldierInfo.UI_ModelScale * 0.009f;
			Vector2 offset = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY) * 0.9f;
			this.DestroySpineGraphic(this.m_soldierDetailGraphic);
			this.m_soldierDetailGraphic = this.CreateSpineGraphic(text, scale, offset, this.m_soldierGraphicObj, soldierInfo.ReplaceAnims);
			this.m_soldierDescText.text = UIUtility.GetSoldierCurSkillDesc(soldierInfo);
			this.m_soldierDescMeleeGo.SetActive(soldierInfo.IsMelee);
			this.m_soldierDescNotMeleeGo.SetActive(!soldierInfo.IsMelee);
			this.m_soldierDescRestrainValueText.text = soldierInfo.Strong;
			this.m_soldierDescWeakValueText.text = soldierInfo.Weak;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(configDataLoader);
			heroPropertyComputer.ComputeSoldierBuffCommandProperties(a);
			this.m_soldierDescRangeValueText.text = this.CalcPropValue(heroPropertyComputer.Property0.AttackDistance, heroPropertyComputer.Property1.AttackDistance, false);
			this.m_soldierDescMoveValueText.text = this.CalcPropValue(heroPropertyComputer.Property0.MovePoint, heroPropertyComputer.Property1.MovePoint, false);
			this.m_soldierPropHPValueText.text = this.CalcPropValue(heroPropertyComputer.Property0.HealthPointMax, heroPropertyComputer.Property1.HealthPointMax, false);
			this.m_soldierPropDFValueText.text = this.CalcPropValue(heroPropertyComputer.Property0.Defense, heroPropertyComputer.Property1.Defense, false);
			this.m_soldierPropATValueText.text = this.CalcPropValue(heroPropertyComputer.Property0.Attack, heroPropertyComputer.Property1.Attack, false);
			this.m_soldierPropMagicDFValueText.text = this.CalcPropValue(heroPropertyComputer.Property0.MagicDefense, heroPropertyComputer.Property1.MagicDefense, false);
			this.m_soldierPropHPAddText.text = this.CalcPropValue(heroPropertyComputer.Property1.HealthPointMax, heroPropertyComputer.Property2.HealthPointMax, true);
			this.m_soldierPropDFAddText.text = this.CalcPropValue(heroPropertyComputer.Property1.Defense, heroPropertyComputer.Property2.Defense, true);
			this.m_soldierPropATAddText.text = this.CalcPropValue(heroPropertyComputer.Property1.Attack, heroPropertyComputer.Property2.Attack, true);
			this.m_soldierPropMagicDFAddText.text = this.CalcPropValue(heroPropertyComputer.Property1.MagicDefense, heroPropertyComputer.Property2.MagicDefense, true);
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x002E9F70 File Offset: 0x002E8170
		private string CalcPropValue(int v0, int v1, bool isAdd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcPropValueInt32Int32Boolean_hotfix != null)
			{
				return (string)this.m_CalcPropValueInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					v0,
					v1,
					isAdd
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!isAdd)
			{
				if (v1 - v0 > 0)
				{
					return UIUtility.AddColorTag(v1.ToString(), UIUtility.MyGreenColor);
				}
				if (v1 - v0 < 0)
				{
					return UIUtility.AddColorTag(v1.ToString(), Color.red);
				}
				return v1.ToString();
			}
			else
			{
				if (v1 - v0 == 0)
				{
					return string.Empty;
				}
				if (v1 - v0 > 0)
				{
					return UIUtility.AddColorTag("+" + (v1 - v0), UIUtility.MyGreenColor);
				}
				return UIUtility.AddColorTag((v1 - v0).ToString(), Color.red);
			}
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x002EA0B4 File Offset: 0x002E82B4
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
			uispineGraphic.SetRectTransformSize(new Vector2(500f / scale, 500f / scale));
			uispineGraphic.SetReplaceAnimations(replaceAnims);
			uispineGraphic.PlayAnimation("idle", true, 0);
			uispineGraphic.ForceUpdate();
			return uispineGraphic;
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x002EA1D0 File Offset: 0x002E83D0
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

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x0600A5AE RID: 42414 RVA: 0x002EA24C File Offset: 0x002E844C
		// (set) Token: 0x0600A5AF RID: 42415 RVA: 0x002EA26C File Offset: 0x002E846C
		[DoNotToLua]
		public new BattleActorInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleActorInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x002EA278 File Offset: 0x002E8478
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x002EA284 File Offset: 0x002E8484
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x002EA28C File Offset: 0x002E848C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x002EA294 File Offset: 0x002E8494
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x002EA2A8 File Offset: 0x002E84A8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x002EA2B0 File Offset: 0x002E84B0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x002EA2BC File Offset: 0x002E84BC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x002EA2C8 File Offset: 0x002E84C8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x002EA2D4 File Offset: 0x002E84D4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x002EA2E0 File Offset: 0x002E84E0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x002EA2EC File Offset: 0x002E84EC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x002EA2F8 File Offset: 0x002E84F8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x002EA304 File Offset: 0x002E8504
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x002EA310 File Offset: 0x002E8510
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x002EA31C File Offset: 0x002E851C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x002EA3D4 File Offset: 0x002E85D4
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
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_SetActorInfoBattleActorInt32_hotfix = (luaObj.RawGet("SetActorInfo") as LuaFunction);
					this.m_SetSoldierDetailInfoBattleActorConfigDataSoldierInfoInt32_hotfix = (luaObj.RawGet("SetSoldierDetailInfo") as LuaFunction);
					this.m_CalcPropValueInt32Int32Boolean_hotfix = (luaObj.RawGet("CalcPropValue") as LuaFunction);
					this.m_CreateSpineGraphicStringSingleVector2GameObjectList`1_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphicUISpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x002EA580 File Offset: 0x002E8780
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleActorInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006E1D RID: 28189
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04006E1E RID: 28190
		[AutoBind("./Hero/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameText;

		// Token: 0x04006E1F RID: 28191
		[AutoBind("./Hero/Army/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroArmyText;

		// Token: 0x04006E20 RID: 28192
		[AutoBind("./HeroPanelGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroPanelGroupCtrl;

		// Token: 0x04006E21 RID: 28193
		[AutoBind("./HeroPanelGroup/HeroIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIcon;

		// Token: 0x04006E22 RID: 28194
		[AutoBind("./Hero/Army/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroArmyIcon;

		// Token: 0x04006E23 RID: 28195
		[AutoBind("./Hero/Job/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroJobText;

		// Token: 0x04006E24 RID: 28196
		[AutoBind("./Hero/Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLevelText;

		// Token: 0x04006E25 RID: 28197
		[AutoBind("./Hero/HP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroHPText;

		// Token: 0x04006E26 RID: 28198
		[AutoBind("./Hero/DEX/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroDEXText;

		// Token: 0x04006E27 RID: 28199
		[AutoBind("./Hero/HP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroHPImage;

		// Token: 0x04006E28 RID: 28200
		[AutoBind("./Hero/Attack/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroAttackText;

		// Token: 0x04006E29 RID: 28201
		[AutoBind("./Hero/Defense/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroDefenseText;

		// Token: 0x04006E2A RID: 28202
		[AutoBind("./Hero/Magic/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroMagicText;

		// Token: 0x04006E2B RID: 28203
		[AutoBind("./Hero/MagicDefense/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroMagicDefenseText;

		// Token: 0x04006E2C RID: 28204
		[AutoBind("./Hero/Range/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroRangeText;

		// Token: 0x04006E2D RID: 28205
		[AutoBind("./Hero/Move/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroMoveText;

		// Token: 0x04006E2E RID: 28206
		[AutoBind("./Soldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGameObject;

		// Token: 0x04006E2F RID: 28207
		[AutoBind("./Soldier/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x04006E30 RID: 28208
		[AutoBind("./Soldier/Army/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierArmyIcon;

		// Token: 0x04006E31 RID: 28209
		[AutoBind("./Soldier/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphicGameObject;

		// Token: 0x04006E32 RID: 28210
		[AutoBind("./Soldier/HP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierHPImage;

		// Token: 0x04006E33 RID: 28211
		[AutoBind("./Soldier/HP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHPText;

		// Token: 0x04006E34 RID: 28212
		[AutoBind("./Soldier/Prop/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAttackText;

		// Token: 0x04006E35 RID: 28213
		[AutoBind("./Soldier/Prop/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDefenseText;

		// Token: 0x04006E36 RID: 28214
		[AutoBind("./Soldier/Prop/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFText;

		// Token: 0x04006E37 RID: 28215
		[AutoBind("./Soldier/Prop/AT/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierAttackAddText;

		// Token: 0x04006E38 RID: 28216
		[AutoBind("./Soldier/Prop/DF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDefenseAddText;

		// Token: 0x04006E39 RID: 28217
		[AutoBind("./Soldier/Prop/MagicDF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFAddText;

		// Token: 0x04006E3A RID: 28218
		[AutoBind("./Hero/SkillInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skillInfoButtonGo;

		// Token: 0x04006E3B RID: 28219
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/TalentSkill", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillInfoGroupTalentSkillImage;

		// Token: 0x04006E3C RID: 28220
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/SkillIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillInfoGroupSkillGo;

		// Token: 0x04006E3D RID: 28221
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/SkillIcon2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillInfoGroupSkillGo2;

		// Token: 0x04006E3E RID: 28222
		[AutoBind("./Hero/SkillInfoButton/SkillGroup/SkillIcon3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillInfoGroupSkillGo3;

		// Token: 0x04006E3F RID: 28223
		[AutoBind("./SkillDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailPanel;

		// Token: 0x04006E40 RID: 28224
		[AutoBind("./SkillDetailPanel/List", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDetailListGameObject;

		// Token: 0x04006E41 RID: 28225
		[AutoBind("./SkillDetailPanel/List/Content/Talent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillTalentGameObject;

		// Token: 0x04006E42 RID: 28226
		[AutoBind("./SkillDetailPanel/List/Content/Talent/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillTalentIcon;

		// Token: 0x04006E43 RID: 28227
		[AutoBind("./SkillDetailPanel/List/Content/Talent/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillTalentNameText;

		// Token: 0x04006E44 RID: 28228
		[AutoBind("./SkillDetailPanel/List/Content/Talent/DescTextScrollRect/Mask/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillTalentDescText;

		// Token: 0x04006E45 RID: 28229
		[AutoBind("./SkillDetailPanel/List/Content/LineImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillLineImage;

		// Token: 0x04006E46 RID: 28230
		[AutoBind("./SkillDetailPanel/List/Content/List", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListGameObject;

		// Token: 0x04006E47 RID: 28231
		[AutoBind("./SkillDetailPanel/List/NoSkills", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noSkillsAndTalentGameObject;

		// Token: 0x04006E48 RID: 28232
		[AutoBind("./SkillDetailPanel/List/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillListContentGameObject;

		// Token: 0x04006E49 RID: 28233
		[AutoBind("./DebugBuffToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_debugBuffToggle;

		// Token: 0x04006E4A RID: 28234
		[AutoBind("./BuffList", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buffsListGameObject;

		// Token: 0x04006E4B RID: 28235
		[AutoBind("./BuffsDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_buffDescDetailGameObject;

		// Token: 0x04006E4C RID: 28236
		[AutoBind("./BuffsDetailPanel/List", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_buffsDescDetailListGameObject;

		// Token: 0x04006E4D RID: 28237
		[AutoBind("./BuffsDetailPanel/List/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_buffsDescContentGameObject;

		// Token: 0x04006E4E RID: 28238
		[AutoBind("./BuffsDetailPanel/List/NoBuff", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noBuffsGameObject;

		// Token: 0x04006E4F RID: 28239
		[AutoBind("./Soldier/Info", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierDetailButton;

		// Token: 0x04006E50 RID: 28240
		[AutoBind("./SoldierDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierDetailPanelUIStateController;

		// Token: 0x04006E51 RID: 28241
		[AutoBind("./SoldierDetailPanel/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphicObj;

		// Token: 0x04006E52 RID: 28242
		[AutoBind("./SoldierDetailPanel/SoldierIconImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierIconImg;

		// Token: 0x04006E53 RID: 28243
		[AutoBind("./SoldierDetailPanel/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierTitleText;

		// Token: 0x04006E54 RID: 28244
		[AutoBind("./SoldierDetailPanel/Desc/DescTextScroll/Mask/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescText;

		// Token: 0x04006E55 RID: 28245
		[AutoBind("./SoldierDetailPanel/Faction/Melee", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDescMeleeGo;

		// Token: 0x04006E56 RID: 28246
		[AutoBind("./SoldierDetailPanel/Faction/NotMelee", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierDescNotMeleeGo;

		// Token: 0x04006E57 RID: 28247
		[AutoBind("./SoldierDetailPanel/Faction/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescRangeValueText;

		// Token: 0x04006E58 RID: 28248
		[AutoBind("./SoldierDetailPanel/Faction/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescMoveValueText;

		// Token: 0x04006E59 RID: 28249
		[AutoBind("./SoldierDetailPanel/Desc/Restrain/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescRestrainValueText;

		// Token: 0x04006E5A RID: 28250
		[AutoBind("./SoldierDetailPanel/Desc/Weak/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescWeakValueText;

		// Token: 0x04006E5B RID: 28251
		[AutoBind("./SoldierDetailPanel/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropHPValueText;

		// Token: 0x04006E5C RID: 28252
		[AutoBind("./SoldierDetailPanel/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropDFValueText;

		// Token: 0x04006E5D RID: 28253
		[AutoBind("./SoldierDetailPanel/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropATValueText;

		// Token: 0x04006E5E RID: 28254
		[AutoBind("./SoldierDetailPanel/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropMagicDFValueText;

		// Token: 0x04006E5F RID: 28255
		[AutoBind("./SoldierDetailPanel/HP/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropHPAddText;

		// Token: 0x04006E60 RID: 28256
		[AutoBind("./SoldierDetailPanel/DF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropDFAddText;

		// Token: 0x04006E61 RID: 28257
		[AutoBind("./SoldierDetailPanel/AT/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropATAddText;

		// Token: 0x04006E62 RID: 28258
		[AutoBind("./SoldierDetailPanel/MagicDF/AddText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierPropMagicDFAddText;

		// Token: 0x04006E63 RID: 28259
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04006E64 RID: 28260
		[AutoBind("./Prefabs/BuffDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_buffDescPrefab;

		// Token: 0x04006E65 RID: 28261
		[AutoBind("./Prefabs/SkillDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillDescPrefab;

		// Token: 0x04006E66 RID: 28262
		[AutoBind("./Prefabs/BuffIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_buffIconPrefab;

		// Token: 0x04006E67 RID: 28263
		private GameObjectPool<SkillDesc> m_skillDescPool;

		// Token: 0x04006E68 RID: 28264
		private GameObjectPool<BuffDesc> m_buffDescPool;

		// Token: 0x04006E69 RID: 28265
		private UISpineGraphic m_soldierGraphic;

		// Token: 0x04006E6A RID: 28266
		private UISpineGraphic m_soldierDetailGraphic;

		// Token: 0x04006E6B RID: 28267
		private bool m_isOpened;

		// Token: 0x04006E6C RID: 28268
		[DoNotToLua]
		private BattleActorInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006E6D RID: 28269
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006E6E RID: 28270
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006E6F RID: 28271
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04006E70 RID: 28272
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006E71 RID: 28273
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006E72 RID: 28274
		private LuaFunction m_Close_hotfix;

		// Token: 0x04006E73 RID: 28275
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x04006E74 RID: 28276
		private LuaFunction m_SetActorInfoBattleActorInt32_hotfix;

		// Token: 0x04006E75 RID: 28277
		private LuaFunction m_SetSoldierDetailInfoBattleActorConfigDataSoldierInfoInt32_hotfix;

		// Token: 0x04006E76 RID: 28278
		private LuaFunction m_CalcPropValueInt32Int32Boolean_hotfix;

		// Token: 0x04006E77 RID: 28279
		private LuaFunction m_CreateSpineGraphicStringSingleVector2GameObjectList;

		// Token: 0x04006E78 RID: 28280
		private LuaFunction m_DestroySpineGraphicUISpineGraphic_hotfix;

		// Token: 0x02000A5F RID: 2655
		public new class LuaExportHelper
		{
			// Token: 0x0600A5C8 RID: 42440 RVA: 0x002EA5E8 File Offset: 0x002E87E8
			public LuaExportHelper(BattleActorInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A5C9 RID: 42441 RVA: 0x002EA5F8 File Offset: 0x002E87F8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A5CA RID: 42442 RVA: 0x002EA608 File Offset: 0x002E8808
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A5CB RID: 42443 RVA: 0x002EA618 File Offset: 0x002E8818
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A5CC RID: 42444 RVA: 0x002EA628 File Offset: 0x002E8828
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A5CD RID: 42445 RVA: 0x002EA640 File Offset: 0x002E8840
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A5CE RID: 42446 RVA: 0x002EA650 File Offset: 0x002E8850
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A5CF RID: 42447 RVA: 0x002EA660 File Offset: 0x002E8860
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A5D0 RID: 42448 RVA: 0x002EA670 File Offset: 0x002E8870
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A5D1 RID: 42449 RVA: 0x002EA680 File Offset: 0x002E8880
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A5D2 RID: 42450 RVA: 0x002EA690 File Offset: 0x002E8890
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A5D3 RID: 42451 RVA: 0x002EA6A0 File Offset: 0x002E88A0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A5D4 RID: 42452 RVA: 0x002EA6B0 File Offset: 0x002E88B0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A5D5 RID: 42453 RVA: 0x002EA6C0 File Offset: 0x002E88C0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A5D6 RID: 42454 RVA: 0x002EA6D0 File Offset: 0x002E88D0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A5D7 RID: 42455 RVA: 0x002EA6E0 File Offset: 0x002E88E0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700218A RID: 8586
			// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x002EA6F0 File Offset: 0x002E88F0
			// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x002EA700 File Offset: 0x002E8900
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x1700218B RID: 8587
			// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x002EA710 File Offset: 0x002E8910
			// (set) Token: 0x0600A5DB RID: 42459 RVA: 0x002EA720 File Offset: 0x002E8920
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

			// Token: 0x1700218C RID: 8588
			// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x002EA730 File Offset: 0x002E8930
			// (set) Token: 0x0600A5DD RID: 42461 RVA: 0x002EA740 File Offset: 0x002E8940
			public Text m_heroArmyText
			{
				get
				{
					return this.m_owner.m_heroArmyText;
				}
				set
				{
					this.m_owner.m_heroArmyText = value;
				}
			}

			// Token: 0x1700218D RID: 8589
			// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x002EA750 File Offset: 0x002E8950
			// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x002EA760 File Offset: 0x002E8960
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

			// Token: 0x1700218E RID: 8590
			// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x002EA770 File Offset: 0x002E8970
			// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x002EA780 File Offset: 0x002E8980
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

			// Token: 0x1700218F RID: 8591
			// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002EA790 File Offset: 0x002E8990
			// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x002EA7A0 File Offset: 0x002E89A0
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

			// Token: 0x17002190 RID: 8592
			// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x002EA7B0 File Offset: 0x002E89B0
			// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x002EA7C0 File Offset: 0x002E89C0
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

			// Token: 0x17002191 RID: 8593
			// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x002EA7D0 File Offset: 0x002E89D0
			// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x002EA7E0 File Offset: 0x002E89E0
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

			// Token: 0x17002192 RID: 8594
			// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x002EA7F0 File Offset: 0x002E89F0
			// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x002EA800 File Offset: 0x002E8A00
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

			// Token: 0x17002193 RID: 8595
			// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x002EA810 File Offset: 0x002E8A10
			// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x002EA820 File Offset: 0x002E8A20
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

			// Token: 0x17002194 RID: 8596
			// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x002EA830 File Offset: 0x002E8A30
			// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x002EA840 File Offset: 0x002E8A40
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

			// Token: 0x17002195 RID: 8597
			// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x002EA850 File Offset: 0x002E8A50
			// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x002EA860 File Offset: 0x002E8A60
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

			// Token: 0x17002196 RID: 8598
			// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x002EA870 File Offset: 0x002E8A70
			// (set) Token: 0x0600A5F1 RID: 42481 RVA: 0x002EA880 File Offset: 0x002E8A80
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

			// Token: 0x17002197 RID: 8599
			// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x002EA890 File Offset: 0x002E8A90
			// (set) Token: 0x0600A5F3 RID: 42483 RVA: 0x002EA8A0 File Offset: 0x002E8AA0
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

			// Token: 0x17002198 RID: 8600
			// (get) Token: 0x0600A5F4 RID: 42484 RVA: 0x002EA8B0 File Offset: 0x002E8AB0
			// (set) Token: 0x0600A5F5 RID: 42485 RVA: 0x002EA8C0 File Offset: 0x002E8AC0
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

			// Token: 0x17002199 RID: 8601
			// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x002EA8D0 File Offset: 0x002E8AD0
			// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x002EA8E0 File Offset: 0x002E8AE0
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

			// Token: 0x1700219A RID: 8602
			// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x002EA8F0 File Offset: 0x002E8AF0
			// (set) Token: 0x0600A5F9 RID: 42489 RVA: 0x002EA900 File Offset: 0x002E8B00
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

			// Token: 0x1700219B RID: 8603
			// (get) Token: 0x0600A5FA RID: 42490 RVA: 0x002EA910 File Offset: 0x002E8B10
			// (set) Token: 0x0600A5FB RID: 42491 RVA: 0x002EA920 File Offset: 0x002E8B20
			public GameObject m_soldierGameObject
			{
				get
				{
					return this.m_owner.m_soldierGameObject;
				}
				set
				{
					this.m_owner.m_soldierGameObject = value;
				}
			}

			// Token: 0x1700219C RID: 8604
			// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x002EA930 File Offset: 0x002E8B30
			// (set) Token: 0x0600A5FD RID: 42493 RVA: 0x002EA940 File Offset: 0x002E8B40
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

			// Token: 0x1700219D RID: 8605
			// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x002EA950 File Offset: 0x002E8B50
			// (set) Token: 0x0600A5FF RID: 42495 RVA: 0x002EA960 File Offset: 0x002E8B60
			public Image m_soldierArmyIcon
			{
				get
				{
					return this.m_owner.m_soldierArmyIcon;
				}
				set
				{
					this.m_owner.m_soldierArmyIcon = value;
				}
			}

			// Token: 0x1700219E RID: 8606
			// (get) Token: 0x0600A600 RID: 42496 RVA: 0x002EA970 File Offset: 0x002E8B70
			// (set) Token: 0x0600A601 RID: 42497 RVA: 0x002EA980 File Offset: 0x002E8B80
			public GameObject m_soldierGraphicGameObject
			{
				get
				{
					return this.m_owner.m_soldierGraphicGameObject;
				}
				set
				{
					this.m_owner.m_soldierGraphicGameObject = value;
				}
			}

			// Token: 0x1700219F RID: 8607
			// (get) Token: 0x0600A602 RID: 42498 RVA: 0x002EA990 File Offset: 0x002E8B90
			// (set) Token: 0x0600A603 RID: 42499 RVA: 0x002EA9A0 File Offset: 0x002E8BA0
			public Image m_soldierHPImage
			{
				get
				{
					return this.m_owner.m_soldierHPImage;
				}
				set
				{
					this.m_owner.m_soldierHPImage = value;
				}
			}

			// Token: 0x170021A0 RID: 8608
			// (get) Token: 0x0600A604 RID: 42500 RVA: 0x002EA9B0 File Offset: 0x002E8BB0
			// (set) Token: 0x0600A605 RID: 42501 RVA: 0x002EA9C0 File Offset: 0x002E8BC0
			public Text m_soldierHPText
			{
				get
				{
					return this.m_owner.m_soldierHPText;
				}
				set
				{
					this.m_owner.m_soldierHPText = value;
				}
			}

			// Token: 0x170021A1 RID: 8609
			// (get) Token: 0x0600A606 RID: 42502 RVA: 0x002EA9D0 File Offset: 0x002E8BD0
			// (set) Token: 0x0600A607 RID: 42503 RVA: 0x002EA9E0 File Offset: 0x002E8BE0
			public Text m_soldierAttackText
			{
				get
				{
					return this.m_owner.m_soldierAttackText;
				}
				set
				{
					this.m_owner.m_soldierAttackText = value;
				}
			}

			// Token: 0x170021A2 RID: 8610
			// (get) Token: 0x0600A608 RID: 42504 RVA: 0x002EA9F0 File Offset: 0x002E8BF0
			// (set) Token: 0x0600A609 RID: 42505 RVA: 0x002EAA00 File Offset: 0x002E8C00
			public Text m_soldierDefenseText
			{
				get
				{
					return this.m_owner.m_soldierDefenseText;
				}
				set
				{
					this.m_owner.m_soldierDefenseText = value;
				}
			}

			// Token: 0x170021A3 RID: 8611
			// (get) Token: 0x0600A60A RID: 42506 RVA: 0x002EAA10 File Offset: 0x002E8C10
			// (set) Token: 0x0600A60B RID: 42507 RVA: 0x002EAA20 File Offset: 0x002E8C20
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

			// Token: 0x170021A4 RID: 8612
			// (get) Token: 0x0600A60C RID: 42508 RVA: 0x002EAA30 File Offset: 0x002E8C30
			// (set) Token: 0x0600A60D RID: 42509 RVA: 0x002EAA40 File Offset: 0x002E8C40
			public Text m_soldierAttackAddText
			{
				get
				{
					return this.m_owner.m_soldierAttackAddText;
				}
				set
				{
					this.m_owner.m_soldierAttackAddText = value;
				}
			}

			// Token: 0x170021A5 RID: 8613
			// (get) Token: 0x0600A60E RID: 42510 RVA: 0x002EAA50 File Offset: 0x002E8C50
			// (set) Token: 0x0600A60F RID: 42511 RVA: 0x002EAA60 File Offset: 0x002E8C60
			public Text m_soldierDefenseAddText
			{
				get
				{
					return this.m_owner.m_soldierDefenseAddText;
				}
				set
				{
					this.m_owner.m_soldierDefenseAddText = value;
				}
			}

			// Token: 0x170021A6 RID: 8614
			// (get) Token: 0x0600A610 RID: 42512 RVA: 0x002EAA70 File Offset: 0x002E8C70
			// (set) Token: 0x0600A611 RID: 42513 RVA: 0x002EAA80 File Offset: 0x002E8C80
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

			// Token: 0x170021A7 RID: 8615
			// (get) Token: 0x0600A612 RID: 42514 RVA: 0x002EAA90 File Offset: 0x002E8C90
			// (set) Token: 0x0600A613 RID: 42515 RVA: 0x002EAAA0 File Offset: 0x002E8CA0
			public Button m_skillInfoButtonGo
			{
				get
				{
					return this.m_owner.m_skillInfoButtonGo;
				}
				set
				{
					this.m_owner.m_skillInfoButtonGo = value;
				}
			}

			// Token: 0x170021A8 RID: 8616
			// (get) Token: 0x0600A614 RID: 42516 RVA: 0x002EAAB0 File Offset: 0x002E8CB0
			// (set) Token: 0x0600A615 RID: 42517 RVA: 0x002EAAC0 File Offset: 0x002E8CC0
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

			// Token: 0x170021A9 RID: 8617
			// (get) Token: 0x0600A616 RID: 42518 RVA: 0x002EAAD0 File Offset: 0x002E8CD0
			// (set) Token: 0x0600A617 RID: 42519 RVA: 0x002EAAE0 File Offset: 0x002E8CE0
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

			// Token: 0x170021AA RID: 8618
			// (get) Token: 0x0600A618 RID: 42520 RVA: 0x002EAAF0 File Offset: 0x002E8CF0
			// (set) Token: 0x0600A619 RID: 42521 RVA: 0x002EAB00 File Offset: 0x002E8D00
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

			// Token: 0x170021AB RID: 8619
			// (get) Token: 0x0600A61A RID: 42522 RVA: 0x002EAB10 File Offset: 0x002E8D10
			// (set) Token: 0x0600A61B RID: 42523 RVA: 0x002EAB20 File Offset: 0x002E8D20
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

			// Token: 0x170021AC RID: 8620
			// (get) Token: 0x0600A61C RID: 42524 RVA: 0x002EAB30 File Offset: 0x002E8D30
			// (set) Token: 0x0600A61D RID: 42525 RVA: 0x002EAB40 File Offset: 0x002E8D40
			public GameObject m_skillDetailPanel
			{
				get
				{
					return this.m_owner.m_skillDetailPanel;
				}
				set
				{
					this.m_owner.m_skillDetailPanel = value;
				}
			}

			// Token: 0x170021AD RID: 8621
			// (get) Token: 0x0600A61E RID: 42526 RVA: 0x002EAB50 File Offset: 0x002E8D50
			// (set) Token: 0x0600A61F RID: 42527 RVA: 0x002EAB60 File Offset: 0x002E8D60
			public GameObject m_skillDetailListGameObject
			{
				get
				{
					return this.m_owner.m_skillDetailListGameObject;
				}
				set
				{
					this.m_owner.m_skillDetailListGameObject = value;
				}
			}

			// Token: 0x170021AE RID: 8622
			// (get) Token: 0x0600A620 RID: 42528 RVA: 0x002EAB70 File Offset: 0x002E8D70
			// (set) Token: 0x0600A621 RID: 42529 RVA: 0x002EAB80 File Offset: 0x002E8D80
			public GameObject m_skillTalentGameObject
			{
				get
				{
					return this.m_owner.m_skillTalentGameObject;
				}
				set
				{
					this.m_owner.m_skillTalentGameObject = value;
				}
			}

			// Token: 0x170021AF RID: 8623
			// (get) Token: 0x0600A622 RID: 42530 RVA: 0x002EAB90 File Offset: 0x002E8D90
			// (set) Token: 0x0600A623 RID: 42531 RVA: 0x002EABA0 File Offset: 0x002E8DA0
			public Image m_skillTalentIcon
			{
				get
				{
					return this.m_owner.m_skillTalentIcon;
				}
				set
				{
					this.m_owner.m_skillTalentIcon = value;
				}
			}

			// Token: 0x170021B0 RID: 8624
			// (get) Token: 0x0600A624 RID: 42532 RVA: 0x002EABB0 File Offset: 0x002E8DB0
			// (set) Token: 0x0600A625 RID: 42533 RVA: 0x002EABC0 File Offset: 0x002E8DC0
			public Text m_skillTalentNameText
			{
				get
				{
					return this.m_owner.m_skillTalentNameText;
				}
				set
				{
					this.m_owner.m_skillTalentNameText = value;
				}
			}

			// Token: 0x170021B1 RID: 8625
			// (get) Token: 0x0600A626 RID: 42534 RVA: 0x002EABD0 File Offset: 0x002E8DD0
			// (set) Token: 0x0600A627 RID: 42535 RVA: 0x002EABE0 File Offset: 0x002E8DE0
			public Text m_skillTalentDescText
			{
				get
				{
					return this.m_owner.m_skillTalentDescText;
				}
				set
				{
					this.m_owner.m_skillTalentDescText = value;
				}
			}

			// Token: 0x170021B2 RID: 8626
			// (get) Token: 0x0600A628 RID: 42536 RVA: 0x002EABF0 File Offset: 0x002E8DF0
			// (set) Token: 0x0600A629 RID: 42537 RVA: 0x002EAC00 File Offset: 0x002E8E00
			public Image m_skillLineImage
			{
				get
				{
					return this.m_owner.m_skillLineImage;
				}
				set
				{
					this.m_owner.m_skillLineImage = value;
				}
			}

			// Token: 0x170021B3 RID: 8627
			// (get) Token: 0x0600A62A RID: 42538 RVA: 0x002EAC10 File Offset: 0x002E8E10
			// (set) Token: 0x0600A62B RID: 42539 RVA: 0x002EAC20 File Offset: 0x002E8E20
			public GameObject m_skillListGameObject
			{
				get
				{
					return this.m_owner.m_skillListGameObject;
				}
				set
				{
					this.m_owner.m_skillListGameObject = value;
				}
			}

			// Token: 0x170021B4 RID: 8628
			// (get) Token: 0x0600A62C RID: 42540 RVA: 0x002EAC30 File Offset: 0x002E8E30
			// (set) Token: 0x0600A62D RID: 42541 RVA: 0x002EAC40 File Offset: 0x002E8E40
			public GameObject m_noSkillsAndTalentGameObject
			{
				get
				{
					return this.m_owner.m_noSkillsAndTalentGameObject;
				}
				set
				{
					this.m_owner.m_noSkillsAndTalentGameObject = value;
				}
			}

			// Token: 0x170021B5 RID: 8629
			// (get) Token: 0x0600A62E RID: 42542 RVA: 0x002EAC50 File Offset: 0x002E8E50
			// (set) Token: 0x0600A62F RID: 42543 RVA: 0x002EAC60 File Offset: 0x002E8E60
			public GameObject m_skillListContentGameObject
			{
				get
				{
					return this.m_owner.m_skillListContentGameObject;
				}
				set
				{
					this.m_owner.m_skillListContentGameObject = value;
				}
			}

			// Token: 0x170021B6 RID: 8630
			// (get) Token: 0x0600A630 RID: 42544 RVA: 0x002EAC70 File Offset: 0x002E8E70
			// (set) Token: 0x0600A631 RID: 42545 RVA: 0x002EAC80 File Offset: 0x002E8E80
			public Toggle m_debugBuffToggle
			{
				get
				{
					return this.m_owner.m_debugBuffToggle;
				}
				set
				{
					this.m_owner.m_debugBuffToggle = value;
				}
			}

			// Token: 0x170021B7 RID: 8631
			// (get) Token: 0x0600A632 RID: 42546 RVA: 0x002EAC90 File Offset: 0x002E8E90
			// (set) Token: 0x0600A633 RID: 42547 RVA: 0x002EACA0 File Offset: 0x002E8EA0
			public Button m_buffsListGameObject
			{
				get
				{
					return this.m_owner.m_buffsListGameObject;
				}
				set
				{
					this.m_owner.m_buffsListGameObject = value;
				}
			}

			// Token: 0x170021B8 RID: 8632
			// (get) Token: 0x0600A634 RID: 42548 RVA: 0x002EACB0 File Offset: 0x002E8EB0
			// (set) Token: 0x0600A635 RID: 42549 RVA: 0x002EACC0 File Offset: 0x002E8EC0
			public GameObject m_buffDescDetailGameObject
			{
				get
				{
					return this.m_owner.m_buffDescDetailGameObject;
				}
				set
				{
					this.m_owner.m_buffDescDetailGameObject = value;
				}
			}

			// Token: 0x170021B9 RID: 8633
			// (get) Token: 0x0600A636 RID: 42550 RVA: 0x002EACD0 File Offset: 0x002E8ED0
			// (set) Token: 0x0600A637 RID: 42551 RVA: 0x002EACE0 File Offset: 0x002E8EE0
			public GameObject m_buffsDescDetailListGameObject
			{
				get
				{
					return this.m_owner.m_buffsDescDetailListGameObject;
				}
				set
				{
					this.m_owner.m_buffsDescDetailListGameObject = value;
				}
			}

			// Token: 0x170021BA RID: 8634
			// (get) Token: 0x0600A638 RID: 42552 RVA: 0x002EACF0 File Offset: 0x002E8EF0
			// (set) Token: 0x0600A639 RID: 42553 RVA: 0x002EAD00 File Offset: 0x002E8F00
			public GameObject m_buffsDescContentGameObject
			{
				get
				{
					return this.m_owner.m_buffsDescContentGameObject;
				}
				set
				{
					this.m_owner.m_buffsDescContentGameObject = value;
				}
			}

			// Token: 0x170021BB RID: 8635
			// (get) Token: 0x0600A63A RID: 42554 RVA: 0x002EAD10 File Offset: 0x002E8F10
			// (set) Token: 0x0600A63B RID: 42555 RVA: 0x002EAD20 File Offset: 0x002E8F20
			public GameObject m_noBuffsGameObject
			{
				get
				{
					return this.m_owner.m_noBuffsGameObject;
				}
				set
				{
					this.m_owner.m_noBuffsGameObject = value;
				}
			}

			// Token: 0x170021BC RID: 8636
			// (get) Token: 0x0600A63C RID: 42556 RVA: 0x002EAD30 File Offset: 0x002E8F30
			// (set) Token: 0x0600A63D RID: 42557 RVA: 0x002EAD40 File Offset: 0x002E8F40
			public Button m_soldierDetailButton
			{
				get
				{
					return this.m_owner.m_soldierDetailButton;
				}
				set
				{
					this.m_owner.m_soldierDetailButton = value;
				}
			}

			// Token: 0x170021BD RID: 8637
			// (get) Token: 0x0600A63E RID: 42558 RVA: 0x002EAD50 File Offset: 0x002E8F50
			// (set) Token: 0x0600A63F RID: 42559 RVA: 0x002EAD60 File Offset: 0x002E8F60
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

			// Token: 0x170021BE RID: 8638
			// (get) Token: 0x0600A640 RID: 42560 RVA: 0x002EAD70 File Offset: 0x002E8F70
			// (set) Token: 0x0600A641 RID: 42561 RVA: 0x002EAD80 File Offset: 0x002E8F80
			public GameObject m_soldierGraphicObj
			{
				get
				{
					return this.m_owner.m_soldierGraphicObj;
				}
				set
				{
					this.m_owner.m_soldierGraphicObj = value;
				}
			}

			// Token: 0x170021BF RID: 8639
			// (get) Token: 0x0600A642 RID: 42562 RVA: 0x002EAD90 File Offset: 0x002E8F90
			// (set) Token: 0x0600A643 RID: 42563 RVA: 0x002EADA0 File Offset: 0x002E8FA0
			public Image m_soldierIconImg
			{
				get
				{
					return this.m_owner.m_soldierIconImg;
				}
				set
				{
					this.m_owner.m_soldierIconImg = value;
				}
			}

			// Token: 0x170021C0 RID: 8640
			// (get) Token: 0x0600A644 RID: 42564 RVA: 0x002EADB0 File Offset: 0x002E8FB0
			// (set) Token: 0x0600A645 RID: 42565 RVA: 0x002EADC0 File Offset: 0x002E8FC0
			public Text m_soldierTitleText
			{
				get
				{
					return this.m_owner.m_soldierTitleText;
				}
				set
				{
					this.m_owner.m_soldierTitleText = value;
				}
			}

			// Token: 0x170021C1 RID: 8641
			// (get) Token: 0x0600A646 RID: 42566 RVA: 0x002EADD0 File Offset: 0x002E8FD0
			// (set) Token: 0x0600A647 RID: 42567 RVA: 0x002EADE0 File Offset: 0x002E8FE0
			public Text m_soldierDescText
			{
				get
				{
					return this.m_owner.m_soldierDescText;
				}
				set
				{
					this.m_owner.m_soldierDescText = value;
				}
			}

			// Token: 0x170021C2 RID: 8642
			// (get) Token: 0x0600A648 RID: 42568 RVA: 0x002EADF0 File Offset: 0x002E8FF0
			// (set) Token: 0x0600A649 RID: 42569 RVA: 0x002EAE00 File Offset: 0x002E9000
			public GameObject m_soldierDescMeleeGo
			{
				get
				{
					return this.m_owner.m_soldierDescMeleeGo;
				}
				set
				{
					this.m_owner.m_soldierDescMeleeGo = value;
				}
			}

			// Token: 0x170021C3 RID: 8643
			// (get) Token: 0x0600A64A RID: 42570 RVA: 0x002EAE10 File Offset: 0x002E9010
			// (set) Token: 0x0600A64B RID: 42571 RVA: 0x002EAE20 File Offset: 0x002E9020
			public GameObject m_soldierDescNotMeleeGo
			{
				get
				{
					return this.m_owner.m_soldierDescNotMeleeGo;
				}
				set
				{
					this.m_owner.m_soldierDescNotMeleeGo = value;
				}
			}

			// Token: 0x170021C4 RID: 8644
			// (get) Token: 0x0600A64C RID: 42572 RVA: 0x002EAE30 File Offset: 0x002E9030
			// (set) Token: 0x0600A64D RID: 42573 RVA: 0x002EAE40 File Offset: 0x002E9040
			public Text m_soldierDescRangeValueText
			{
				get
				{
					return this.m_owner.m_soldierDescRangeValueText;
				}
				set
				{
					this.m_owner.m_soldierDescRangeValueText = value;
				}
			}

			// Token: 0x170021C5 RID: 8645
			// (get) Token: 0x0600A64E RID: 42574 RVA: 0x002EAE50 File Offset: 0x002E9050
			// (set) Token: 0x0600A64F RID: 42575 RVA: 0x002EAE60 File Offset: 0x002E9060
			public Text m_soldierDescMoveValueText
			{
				get
				{
					return this.m_owner.m_soldierDescMoveValueText;
				}
				set
				{
					this.m_owner.m_soldierDescMoveValueText = value;
				}
			}

			// Token: 0x170021C6 RID: 8646
			// (get) Token: 0x0600A650 RID: 42576 RVA: 0x002EAE70 File Offset: 0x002E9070
			// (set) Token: 0x0600A651 RID: 42577 RVA: 0x002EAE80 File Offset: 0x002E9080
			public Text m_soldierDescRestrainValueText
			{
				get
				{
					return this.m_owner.m_soldierDescRestrainValueText;
				}
				set
				{
					this.m_owner.m_soldierDescRestrainValueText = value;
				}
			}

			// Token: 0x170021C7 RID: 8647
			// (get) Token: 0x0600A652 RID: 42578 RVA: 0x002EAE90 File Offset: 0x002E9090
			// (set) Token: 0x0600A653 RID: 42579 RVA: 0x002EAEA0 File Offset: 0x002E90A0
			public Text m_soldierDescWeakValueText
			{
				get
				{
					return this.m_owner.m_soldierDescWeakValueText;
				}
				set
				{
					this.m_owner.m_soldierDescWeakValueText = value;
				}
			}

			// Token: 0x170021C8 RID: 8648
			// (get) Token: 0x0600A654 RID: 42580 RVA: 0x002EAEB0 File Offset: 0x002E90B0
			// (set) Token: 0x0600A655 RID: 42581 RVA: 0x002EAEC0 File Offset: 0x002E90C0
			public Text m_soldierPropHPValueText
			{
				get
				{
					return this.m_owner.m_soldierPropHPValueText;
				}
				set
				{
					this.m_owner.m_soldierPropHPValueText = value;
				}
			}

			// Token: 0x170021C9 RID: 8649
			// (get) Token: 0x0600A656 RID: 42582 RVA: 0x002EAED0 File Offset: 0x002E90D0
			// (set) Token: 0x0600A657 RID: 42583 RVA: 0x002EAEE0 File Offset: 0x002E90E0
			public Text m_soldierPropDFValueText
			{
				get
				{
					return this.m_owner.m_soldierPropDFValueText;
				}
				set
				{
					this.m_owner.m_soldierPropDFValueText = value;
				}
			}

			// Token: 0x170021CA RID: 8650
			// (get) Token: 0x0600A658 RID: 42584 RVA: 0x002EAEF0 File Offset: 0x002E90F0
			// (set) Token: 0x0600A659 RID: 42585 RVA: 0x002EAF00 File Offset: 0x002E9100
			public Text m_soldierPropATValueText
			{
				get
				{
					return this.m_owner.m_soldierPropATValueText;
				}
				set
				{
					this.m_owner.m_soldierPropATValueText = value;
				}
			}

			// Token: 0x170021CB RID: 8651
			// (get) Token: 0x0600A65A RID: 42586 RVA: 0x002EAF10 File Offset: 0x002E9110
			// (set) Token: 0x0600A65B RID: 42587 RVA: 0x002EAF20 File Offset: 0x002E9120
			public Text m_soldierPropMagicDFValueText
			{
				get
				{
					return this.m_owner.m_soldierPropMagicDFValueText;
				}
				set
				{
					this.m_owner.m_soldierPropMagicDFValueText = value;
				}
			}

			// Token: 0x170021CC RID: 8652
			// (get) Token: 0x0600A65C RID: 42588 RVA: 0x002EAF30 File Offset: 0x002E9130
			// (set) Token: 0x0600A65D RID: 42589 RVA: 0x002EAF40 File Offset: 0x002E9140
			public Text m_soldierPropHPAddText
			{
				get
				{
					return this.m_owner.m_soldierPropHPAddText;
				}
				set
				{
					this.m_owner.m_soldierPropHPAddText = value;
				}
			}

			// Token: 0x170021CD RID: 8653
			// (get) Token: 0x0600A65E RID: 42590 RVA: 0x002EAF50 File Offset: 0x002E9150
			// (set) Token: 0x0600A65F RID: 42591 RVA: 0x002EAF60 File Offset: 0x002E9160
			public Text m_soldierPropDFAddText
			{
				get
				{
					return this.m_owner.m_soldierPropDFAddText;
				}
				set
				{
					this.m_owner.m_soldierPropDFAddText = value;
				}
			}

			// Token: 0x170021CE RID: 8654
			// (get) Token: 0x0600A660 RID: 42592 RVA: 0x002EAF70 File Offset: 0x002E9170
			// (set) Token: 0x0600A661 RID: 42593 RVA: 0x002EAF80 File Offset: 0x002E9180
			public Text m_soldierPropATAddText
			{
				get
				{
					return this.m_owner.m_soldierPropATAddText;
				}
				set
				{
					this.m_owner.m_soldierPropATAddText = value;
				}
			}

			// Token: 0x170021CF RID: 8655
			// (get) Token: 0x0600A662 RID: 42594 RVA: 0x002EAF90 File Offset: 0x002E9190
			// (set) Token: 0x0600A663 RID: 42595 RVA: 0x002EAFA0 File Offset: 0x002E91A0
			public Text m_soldierPropMagicDFAddText
			{
				get
				{
					return this.m_owner.m_soldierPropMagicDFAddText;
				}
				set
				{
					this.m_owner.m_soldierPropMagicDFAddText = value;
				}
			}

			// Token: 0x170021D0 RID: 8656
			// (get) Token: 0x0600A664 RID: 42596 RVA: 0x002EAFB0 File Offset: 0x002E91B0
			// (set) Token: 0x0600A665 RID: 42597 RVA: 0x002EAFC0 File Offset: 0x002E91C0
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x170021D1 RID: 8657
			// (get) Token: 0x0600A666 RID: 42598 RVA: 0x002EAFD0 File Offset: 0x002E91D0
			// (set) Token: 0x0600A667 RID: 42599 RVA: 0x002EAFE0 File Offset: 0x002E91E0
			public GameObject m_buffDescPrefab
			{
				get
				{
					return this.m_owner.m_buffDescPrefab;
				}
				set
				{
					this.m_owner.m_buffDescPrefab = value;
				}
			}

			// Token: 0x170021D2 RID: 8658
			// (get) Token: 0x0600A668 RID: 42600 RVA: 0x002EAFF0 File Offset: 0x002E91F0
			// (set) Token: 0x0600A669 RID: 42601 RVA: 0x002EB000 File Offset: 0x002E9200
			public GameObject m_skillDescPrefab
			{
				get
				{
					return this.m_owner.m_skillDescPrefab;
				}
				set
				{
					this.m_owner.m_skillDescPrefab = value;
				}
			}

			// Token: 0x170021D3 RID: 8659
			// (get) Token: 0x0600A66A RID: 42602 RVA: 0x002EB010 File Offset: 0x002E9210
			// (set) Token: 0x0600A66B RID: 42603 RVA: 0x002EB020 File Offset: 0x002E9220
			public GameObject m_buffIconPrefab
			{
				get
				{
					return this.m_owner.m_buffIconPrefab;
				}
				set
				{
					this.m_owner.m_buffIconPrefab = value;
				}
			}

			// Token: 0x170021D4 RID: 8660
			// (get) Token: 0x0600A66C RID: 42604 RVA: 0x002EB030 File Offset: 0x002E9230
			// (set) Token: 0x0600A66D RID: 42605 RVA: 0x002EB040 File Offset: 0x002E9240
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

			// Token: 0x170021D5 RID: 8661
			// (get) Token: 0x0600A66E RID: 42606 RVA: 0x002EB050 File Offset: 0x002E9250
			// (set) Token: 0x0600A66F RID: 42607 RVA: 0x002EB060 File Offset: 0x002E9260
			public GameObjectPool<BuffDesc> m_buffDescPool
			{
				get
				{
					return this.m_owner.m_buffDescPool;
				}
				set
				{
					this.m_owner.m_buffDescPool = value;
				}
			}

			// Token: 0x170021D6 RID: 8662
			// (get) Token: 0x0600A670 RID: 42608 RVA: 0x002EB070 File Offset: 0x002E9270
			// (set) Token: 0x0600A671 RID: 42609 RVA: 0x002EB080 File Offset: 0x002E9280
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

			// Token: 0x170021D7 RID: 8663
			// (get) Token: 0x0600A672 RID: 42610 RVA: 0x002EB090 File Offset: 0x002E9290
			// (set) Token: 0x0600A673 RID: 42611 RVA: 0x002EB0A0 File Offset: 0x002E92A0
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

			// Token: 0x170021D8 RID: 8664
			// (get) Token: 0x0600A674 RID: 42612 RVA: 0x002EB0B0 File Offset: 0x002E92B0
			// (set) Token: 0x0600A675 RID: 42613 RVA: 0x002EB0C0 File Offset: 0x002E92C0
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

			// Token: 0x0600A676 RID: 42614 RVA: 0x002EB0D0 File Offset: 0x002E92D0
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600A677 RID: 42615 RVA: 0x002EB0E0 File Offset: 0x002E92E0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A678 RID: 42616 RVA: 0x002EB0F0 File Offset: 0x002E92F0
			public void SetSoldierDetailInfo(BattleActor a, ConfigDataSoldierInfo soldierInfo, int myPlayerTeam)
			{
				this.m_owner.SetSoldierDetailInfo(a, soldierInfo, myPlayerTeam);
			}

			// Token: 0x0600A679 RID: 42617 RVA: 0x002EB100 File Offset: 0x002E9300
			public string CalcPropValue(int v0, int v1, bool isAdd)
			{
				return this.m_owner.CalcPropValue(v0, v1, isAdd);
			}

			// Token: 0x0600A67A RID: 42618 RVA: 0x002EB110 File Offset: 0x002E9310
			public UISpineGraphic CreateSpineGraphic(string assetName, float scale, Vector2 offset, GameObject parent, List<ReplaceAnim> replaceAnims)
			{
				return this.m_owner.CreateSpineGraphic(assetName, scale, offset, parent, replaceAnims);
			}

			// Token: 0x0600A67B RID: 42619 RVA: 0x002EB124 File Offset: 0x002E9324
			public void DestroySpineGraphic(UISpineGraphic g)
			{
				this.m_owner.DestroySpineGraphic(g);
			}

			// Token: 0x04006E79 RID: 28281
			private BattleActorInfoUIController m_owner;
		}
	}
}
