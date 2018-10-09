using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
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
	// Token: 0x02000DAF RID: 3503
	[HotFix]
	public class HeroDetailSoldierUIController : UIControllerBase
	{
		// Token: 0x06010965 RID: 67941 RVA: 0x0044F740 File Offset: 0x0044D940
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
			this.m_skinInfoButton.onClick.AddListener(new UnityAction(this.OnSkinInfoButtonClick));
			this.m_soldierGetConditionGotoButton.onClick.AddListener(new UnityAction(this.OnSoldierGetConditionGotoButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06010966 RID: 67942 RVA: 0x0044F820 File Offset: 0x0044DA20
		public void UpdateViewInSoldierState(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInSoldierStateHero_hotfix != null)
			{
				this.m_UpdateViewInSoldierStateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero != hero)
			{
				this.m_hero = hero;
				this.CleanSoldierPanelDataOnHeroChanged();
			}
			ConfigDataSoldierInfo configDataSoldierInfo = (this.m_lastClickSoldierInfo == null) ? this.m_hero.SelectedSoldierInfo : this.m_lastClickSoldierInfo;
			this.ShowSoldierInfoPanel(configDataSoldierInfo, this.m_hero.SoldierIds.Contains(configDataSoldierInfo.ID));
			this.ShowSoldierSelectPanel(this.m_hero);
		}

		// Token: 0x06010967 RID: 67943 RVA: 0x0044F8F4 File Offset: 0x0044DAF4
		private void ShowSoldierInfoPanel(ConfigDataSoldierInfo soldierInfo, bool isSoldierGet)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSoldierInfoPanelConfigDataSoldierInfoBoolean_hotfix != null)
			{
				this.m_ShowSoldierInfoPanelConfigDataSoldierInfoBoolean_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					isSoldierGet
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (soldierInfo == null)
			{
				HeroDetailUIController.DestroySpineGraphic(ref this.m_soldierInfoGraphic);
				return;
			}
			this.m_soldierIconImage.sprite = AssetUtility.Instance.GetSprite(soldierInfo.m_armyInfo.Icon);
			this.m_soldierNameText.text = soldierInfo.Name;
			this.m_soldierQualityIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetSoldierRankImage(soldierInfo.Rank));
			float scale = (float)soldierInfo.UI_ModelScale * 0.013f;
			Vector2 offset = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY) * 1.5f;
			string soldierModelAssetPath = UIUtility.GetSoldierModelAssetPath(this.m_hero, soldierInfo.ID);
			HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierInfoGraphic, soldierModelAssetPath, this.m_soldierGraphic, 1, offset, scale, soldierInfo.ReplaceAnims);
			if (isSoldierGet)
			{
				this.m_soldierInfoGraphic.SetColor(Color.white);
			}
			else
			{
				this.m_soldierInfoGraphic.SetColor(UIUtility.MyGrayColor);
			}
			this.m_soldierFactionRangeText.text = soldierInfo.BF_AttackDistance.ToString();
			this.m_soldierFactionMoveText.text = soldierInfo.BF_MovePoint.ToString();
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			heroPropertyComputer.ComputeSoldierCommandProperties(this.m_hero, soldierInfo);
			BattleProperty property = heroPropertyComputer.Property0;
			BattleProperty property2 = heroPropertyComputer.Property1;
			this.m_soldierHPValueText.text = property.HealthPointMax.ToString();
			this.m_soldierATValueText.text = property.Attack.ToString();
			this.m_soldierDFValueText.text = property.Defense.ToString();
			this.m_soldierMagicDFValueText.text = property.MagicDefense.ToString();
			this.m_soldierHPAddValueText.text = "+" + (property2.HealthPointMax - property.HealthPointMax);
			this.m_soldierATAddValueText.text = "+" + (property2.Attack - property.Attack);
			this.m_soldierDFAddValueText.text = "+" + (property2.Defense - property.Defense);
			this.m_soldierMagicDFAddValueText.text = "+" + (property2.MagicDefense - property.MagicDefense);
			this.m_soldierHPAddPercentText.text = "( " + property2.Cmd_HealthPoint / 100 + "% )";
			this.m_soldierATAddPercentText.text = "( " + property2.Cmd_Attack / 100 + "% )";
			this.m_soldierDFAddPercentText.text = "( " + property2.Cmd_Defense / 100 + "% )";
			this.m_soldierMagicDFAddPercentText.text = "( " + property2.Cmd_MagicDefense / 100 + "% )";
			this.m_soldierHPAddPercentText.gameObject.SetActive(property2.HealthPointMax - property.HealthPointMax != 0 && property2.Cmd_HealthPoint != 0);
			this.m_soldierATAddPercentText.gameObject.SetActive(property2.Attack - property.Attack != 0 && property2.Cmd_Attack != 0);
			this.m_soldierDFAddPercentText.gameObject.SetActive(property2.Defense - property.Defense != 0 && property2.Cmd_Defense != 0);
			this.m_soldierMagicDFAddPercentText.gameObject.SetActive(property2.MagicDefense - property.MagicDefense != 0 && property2.Cmd_MagicDefense != 0);
			this.m_soldierStrongText.text = soldierInfo.Strong;
			this.m_soldierWeakText.text = soldierInfo.Weak;
			this.m_soldierDescText.text = UIUtility.GetSoldierCurSkillDesc(soldierInfo);
			int num = 0;
			foreach (int num2 in soldierInfo.SoldierSkins_ID)
			{
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = this.m_configDataLoader.GetConfigDataSoldierSkinInfo(num2);
				if (this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, num2) || configDataSoldierSkinInfo.IsShowBeforeGet)
				{
					if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataSoldierSkinInfo.FixedStoreItemId, false))
					{
						num++;
					}
				}
			}
			this.m_skinInfoButton.gameObject.SetActive(num > 0);
		}

		// Token: 0x06010968 RID: 67944 RVA: 0x0044FE48 File Offset: 0x0044E048
		private void ShowSoldierSelectPanel(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSoldierSelectPanelHero_hotfix != null)
			{
				this.m_ShowSoldierSelectPanelHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierIDToJobInfoDict = new Dictionary<int, ConfigDataJobConnectionInfo>();
			List<int> list = new List<int>();
			if (hero.HeroInfo.Soldier_ID != 0)
			{
				this.m_soldierIDToJobInfoDict[hero.HeroInfo.Soldier_ID] = hero.HeroInfo.m_jobConnectionInfo;
			}
			list.Add(hero.HeroInfo.JobConnection_ID);
			list.AddRange(this.m_playerContext.GetUseableJobConnectionInfos(this.m_hero.HeroId));
			foreach (int key in list)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = this.m_configDataLoader.GetConfigDataJobConnectionInfo(key);
				if (configDataJobConnectionInfo.IsJobOpen)
				{
					foreach (ConfigDataJobLevelInfo configDataJobLevelInfo in configDataJobConnectionInfo.m_jobLevelInfos)
					{
						if (configDataJobLevelInfo.GotSoldier_ID != 0 && !this.m_soldierIDToJobInfoDict.ContainsKey(configDataJobLevelInfo.GotSoldier_ID))
						{
							this.m_soldierIDToJobInfoDict[configDataJobLevelInfo.GotSoldier_ID] = configDataJobConnectionInfo;
						}
					}
				}
			}
			List<ConfigDataSoldierInfo> list2 = new List<ConfigDataSoldierInfo>();
			List<ConfigDataSoldierInfo> list3 = new List<ConfigDataSoldierInfo>();
			foreach (int key2 in this.m_soldierIDToJobInfoDict.Keys)
			{
				ConfigDataSoldierInfo configDataSoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(key2);
				if (hero.SoldierIds.Contains(configDataSoldierInfo.ID))
				{
					if (!list2.Contains(configDataSoldierInfo))
					{
						list2.Add(configDataSoldierInfo);
					}
				}
				else if (!list3.Contains(configDataSoldierInfo))
				{
					list3.Add(configDataSoldierInfo);
				}
			}
			foreach (int key3 in this.m_hero.HeroInfo.TechCanLearnSoldiers_ID)
			{
				ConfigDataSoldierInfo configDataSoldierInfo2 = this.m_configDataLoader.GetConfigDataSoldierInfo(key3);
				if (hero.SoldierIds.Contains(configDataSoldierInfo2.ID))
				{
					if (!list2.Contains(configDataSoldierInfo2))
					{
						list2.Add(configDataSoldierInfo2);
					}
				}
				else if (!list3.Contains(configDataSoldierInfo2))
				{
					list3.Add(configDataSoldierInfo2);
				}
			}
			list2.Sort(new Comparison<ConfigDataSoldierInfo>(this.GetSoliderSortComparar));
			list3.Sort(new Comparison<ConfigDataSoldierInfo>(this.NotGetSoliderSortComparar));
			List<ConfigDataSoldierInfo> list4 = new List<ConfigDataSoldierInfo>();
			list4.AddRange(list2);
			list4.AddRange(list3);
			this.m_soliderItemListCtrl.Clear();
			UIUtility.SetGameObjectChildrenActiveCount(this.m_soldierSelectContentObj, list4.Count);
			Transform transform = this.m_soldierSelectContentObj.transform;
			for (int j = 0; j < list4.Count; j++)
			{
				SoldierItemUIController component;
				if (j < transform.childCount)
				{
					GameObject gameObject = transform.GetChild(j).gameObject;
					component = gameObject.GetComponent<SoldierItemUIController>();
				}
				else
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_soldierItemPrefabObj);
					PrefabControllerCreater.CreateAllControllers(gameObject2);
					component = gameObject2.GetComponent<SoldierItemUIController>();
					component.EventOnSoldierItemClick += this.OnSoldierItemClick;
					component.EventOnAttackButtonClick += this.OnSoldierItemAttackButtonClick;
					gameObject2.transform.SetParent(this.m_soldierSelectContentObj.transform, false);
				}
				ConfigDataSoldierInfo configDataSoldierInfo3 = list4[j];
				ConfigDataJobConnectionInfo jci = null;
				if (this.m_soldierIDToJobInfoDict.ContainsKey(configDataSoldierInfo3.ID))
				{
					jci = this.m_soldierIDToJobInfoDict[configDataSoldierInfo3.ID];
				}
				int soldierSkinId = hero.GetSoldierSkinId(configDataSoldierInfo3.ID);
				component.InitSoldierItem(configDataSoldierInfo3, jci, hero.SoldierIds.Contains(configDataSoldierInfo3.ID), soldierSkinId);
				component.SetFrameImgActive(false);
				component.SetAttackingPanelActive(false);
				component.SetAttackButtonActive(false);
				if (this.m_lastClickSoldierInfo != null)
				{
					if (this.m_lastClickSoldierInfo.ID == configDataSoldierInfo3.ID)
					{
						this.m_lastClickSoldierItemCtrl = component;
						bool flag = this.m_hero.SoldierIds.Contains(this.m_lastClickSoldierInfo.ID);
						if (flag && this.m_lastClickSoldierInfo.ID != hero.SelectedSoldierId)
						{
							component.SetAttackButtonActive(true);
						}
					}
				}
				else if (hero.SelectedSoldierId == configDataSoldierInfo3.ID)
				{
					this.m_lastClickSoldierInfo = configDataSoldierInfo3;
					this.m_lastClickSoldierItemCtrl = component;
				}
				if (hero.SelectedSoldierId == configDataSoldierInfo3.ID)
				{
					component.SetAttackingPanelActive(true);
				}
				this.m_soliderItemListCtrl.Add(component);
			}
			if (this.m_lastClickSoldierItemCtrl != null)
			{
				this.m_lastClickSoldierItemCtrl.SetFrameImgActive(true);
			}
			else if (this.m_soliderItemListCtrl.Count > 0)
			{
				this.m_lastClickSoldierItemCtrl = this.m_soliderItemListCtrl[0];
				this.m_lastClickSoldierInfo = this.m_lastClickSoldierItemCtrl.SoldierInfo;
				this.m_lastClickSoldierItemCtrl.SetFrameImgActive(true);
			}
			this.m_soldierGetCondition.SetActive(false);
		}

		// Token: 0x06010969 RID: 67945 RVA: 0x004503F8 File Offset: 0x0044E5F8
		private int GetSoliderSortComparar(ConfigDataSoldierInfo s1, ConfigDataSoldierInfo s2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					s1,
					s2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = s2.Rank - s1.Rank;
			if (num == 0)
			{
				return s2.ID - s1.ID;
			}
			return num;
		}

		// Token: 0x0601096A RID: 67946 RVA: 0x004504A8 File Offset: 0x0044E6A8
		private int NotGetSoliderSortComparar(ConfigDataSoldierInfo s1, ConfigDataSoldierInfo s2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotGetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_NotGetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					s1,
					s2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = s1.Rank - s2.Rank;
			if (num == 0)
			{
				return s2.ID - s1.ID;
			}
			return num;
		}

		// Token: 0x0601096B RID: 67947 RVA: 0x00450558 File Offset: 0x0044E758
		private void OnSoldierItemClick(SoldierItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemClickSoldierItemUIController_hotfix != null)
			{
				this.m_OnSoldierItemClickSoldierItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_lastClickSoldierItemCtrl != ctrl)
			{
				this.m_lastClickSoldierItemCtrl = ctrl;
				this.m_lastClickSoldierInfo = this.m_lastClickSoldierItemCtrl.SoldierInfo;
				bool flag = this.m_hero.SoldierIds.Contains(ctrl.SoldierInfo.ID);
				if (!flag)
				{
					this.m_soldierGetCondition.SetActive(true);
					CommonUIStateController component = this.m_soldierGetCondition.GetComponent<CommonUIStateController>();
					component.SetToUIState("Show", false, true);
					if (this.m_hero.HeroInfo.TechCanLearnSoldiers_ID.Contains(ctrl.SoldierInfo.ID))
					{
						this.m_soldierGetConditionDescStateCtrl.SetToUIState("1", false, true);
						this.m_soldierGetConditionDescText.text = this.m_lastClickSoldierItemCtrl.SoldierInfo.GetSoldierDesc;
					}
					else
					{
						this.m_soldierGetConditionDescStateCtrl.SetToUIState("3", false, true);
						this.m_soldierGetConditionDescJobNameText.text = this.m_lastClickSoldierItemCtrl.JobConnectionInfo.m_jobInfo.Name;
					}
				}
				else
				{
					this.m_soldierGetCondition.SetActive(false);
				}
				this.ShowSoldierInfoPanel(ctrl.SoldierInfo, flag);
				foreach (SoldierItemUIController soldierItemUIController in this.m_soliderItemListCtrl)
				{
					soldierItemUIController.SetAttackButtonActive(flag && soldierItemUIController.SoldierInfo == ctrl.SoldierInfo && ctrl.SoldierInfo != this.m_hero.SelectedSoldierInfo);
					soldierItemUIController.SetFrameImgActive(soldierItemUIController.SoldierInfo == ctrl.SoldierInfo);
				}
			}
		}

		// Token: 0x0601096C RID: 67948 RVA: 0x00450774 File Offset: 0x0044E974
		private void OnSoldierGetConditionGotoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierGetConditionGotoButtonClick_hotfix != null)
			{
				this.m_OnSoldierGetConditionGotoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero.HeroInfo.TechCanLearnSoldiers_ID.Contains(this.m_lastClickSoldierItemCtrl.SoldierInfo.ID))
			{
				int getSoldierTechId = this.m_lastClickSoldierItemCtrl.SoldierInfo.GetSoldierTechId;
				if (!this.m_playerContext.CanGoToGetSoldierTech(getSoldierTechId))
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_DrillNotOpen, 2f, null, true);
					return;
				}
				if (this.EventOnGotoDrill != null)
				{
					this.EventOnGotoDrill(getSoldierTechId);
				}
			}
			else if (this.EventOnGotoJobTransfer != null)
			{
				this.EventOnGotoJobTransfer(this.m_lastClickSoldierItemCtrl.JobConnectionInfo);
			}
		}

		// Token: 0x0601096D RID: 67949 RVA: 0x00450878 File Offset: 0x0044EA78
		private void OnSoldierItemAttackButtonClick(ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemAttackButtonClickConfigDataSoldierInfo_hotfix != null)
			{
				this.m_OnSoldierItemAttackButtonClickConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSoldierInfo soldierInfo = soldierInfo2;
			HeroDetailSoldierUIController $this = this;
			if (this.m_hero.SelectedSoldierId == soldierInfo.ID)
			{
				return;
			}
			int num = this.m_playerContext.CanHeroSelectSolider(this.m_hero, soldierInfo.ID);
			if (num == 0)
			{
				if (this.EventOnSoldierAttackButtonClick != null)
				{
					this.EventOnSoldierAttackButtonClick(this.m_hero.HeroId, soldierInfo.ID, delegate
					{
						foreach (SoldierItemUIController soldierItemUIController in $this.m_soliderItemListCtrl)
						{
							soldierItemUIController.SetAttackButtonActive(false);
							soldierItemUIController.SetAttackingPanelActive(false);
						}
						$this.m_soliderItemListCtrl.Find((SoldierItemUIController a) => a.SoldierInfo == soldierInfo).SetAttackingPanelActive(true);
					});
				}
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x0601096E RID: 67950 RVA: 0x0045098C File Offset: 0x0044EB8C
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

		// Token: 0x0601096F RID: 67951 RVA: 0x00450A14 File Offset: 0x0044EC14
		private void CleanSoldierPanelDataOnHeroChanged()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CleanSoldierPanelDataOnHeroChanged_hotfix != null)
			{
				this.m_CleanSoldierPanelDataOnHeroChanged_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierIDToJobInfoDict = null;
			this.m_lastClickSoldierItemCtrl = null;
			this.m_lastClickSoldierInfo = null;
			this.m_soldierSelectContentScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06010970 RID: 67952 RVA: 0x00450A9C File Offset: 0x0044EC9C
		private void OnSkinInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinInfoButtonClick_hotfix != null)
			{
				this.m_OnSkinInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkinInfoButtonClick != null)
			{
				this.EventOnSkinInfoButtonClick(this.m_lastClickSoldierItemCtrl.SoldierInfo);
			}
		}

		// Token: 0x14000382 RID: 898
		// (add) Token: 0x06010971 RID: 67953 RVA: 0x00450B20 File Offset: 0x0044ED20
		// (remove) Token: 0x06010972 RID: 67954 RVA: 0x00450BBC File Offset: 0x0044EDBC
		public event Action<int, int, Action> EventOnSoldierAttackButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSoldierAttackButtonClickAction`3_hotfix != null)
				{
					this.m_add_EventOnSoldierAttackButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnSoldierAttackButtonClick;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnSoldierAttackButtonClick, (Action<int, int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSoldierAttackButtonClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnSoldierAttackButtonClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int, Action> action = this.EventOnSoldierAttackButtonClick;
				Action<int, int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int, Action>>(ref this.EventOnSoldierAttackButtonClick, (Action<int, int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000383 RID: 899
		// (add) Token: 0x06010973 RID: 67955 RVA: 0x00450C58 File Offset: 0x0044EE58
		// (remove) Token: 0x06010974 RID: 67956 RVA: 0x00450CF4 File Offset: 0x0044EEF4
		public event Action<int> EventOnGotoDrill
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoDrillAction`1_hotfix != null)
				{
					this.m_add_EventOnGotoDrillAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGotoDrill;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGotoDrill, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoDrillAction`1_hotfix != null)
				{
					this.m_remove_EventOnGotoDrillAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnGotoDrill;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGotoDrill, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000384 RID: 900
		// (add) Token: 0x06010975 RID: 67957 RVA: 0x00450D90 File Offset: 0x0044EF90
		// (remove) Token: 0x06010976 RID: 67958 RVA: 0x00450E2C File Offset: 0x0044F02C
		public event Action<ConfigDataJobConnectionInfo> EventOnGotoJobTransfer
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoJobTransferAction`1_hotfix != null)
				{
					this.m_add_EventOnGotoJobTransferAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataJobConnectionInfo> action = this.EventOnGotoJobTransfer;
				Action<ConfigDataJobConnectionInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataJobConnectionInfo>>(ref this.EventOnGotoJobTransfer, (Action<ConfigDataJobConnectionInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoJobTransferAction`1_hotfix != null)
				{
					this.m_remove_EventOnGotoJobTransferAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataJobConnectionInfo> action = this.EventOnGotoJobTransfer;
				Action<ConfigDataJobConnectionInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataJobConnectionInfo>>(ref this.EventOnGotoJobTransfer, (Action<ConfigDataJobConnectionInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000385 RID: 901
		// (add) Token: 0x06010977 RID: 67959 RVA: 0x00450EC8 File Offset: 0x0044F0C8
		// (remove) Token: 0x06010978 RID: 67960 RVA: 0x00450F64 File Offset: 0x0044F164
		public event Action<ConfigDataSoldierInfo> EventOnSkinInfoButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkinInfoButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSkinInfoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataSoldierInfo> action = this.EventOnSkinInfoButtonClick;
				Action<ConfigDataSoldierInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataSoldierInfo>>(ref this.EventOnSkinInfoButtonClick, (Action<ConfigDataSoldierInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkinInfoButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSkinInfoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataSoldierInfo> action = this.EventOnSkinInfoButtonClick;
				Action<ConfigDataSoldierInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataSoldierInfo>>(ref this.EventOnSkinInfoButtonClick, (Action<ConfigDataSoldierInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x06010979 RID: 67961 RVA: 0x00451000 File Offset: 0x0044F200
		// (set) Token: 0x0601097A RID: 67962 RVA: 0x00451020 File Offset: 0x0044F220
		[DoNotToLua]
		public new HeroDetailSoldierUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailSoldierUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601097B RID: 67963 RVA: 0x0045102C File Offset: 0x0044F22C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601097C RID: 67964 RVA: 0x00451038 File Offset: 0x0044F238
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601097D RID: 67965 RVA: 0x00451040 File Offset: 0x0044F240
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601097E RID: 67966 RVA: 0x00451048 File Offset: 0x0044F248
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601097F RID: 67967 RVA: 0x0045105C File Offset: 0x0044F25C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010980 RID: 67968 RVA: 0x00451064 File Offset: 0x0044F264
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010981 RID: 67969 RVA: 0x00451070 File Offset: 0x0044F270
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010982 RID: 67970 RVA: 0x0045107C File Offset: 0x0044F27C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010983 RID: 67971 RVA: 0x00451088 File Offset: 0x0044F288
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010984 RID: 67972 RVA: 0x00451094 File Offset: 0x0044F294
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010985 RID: 67973 RVA: 0x004510A0 File Offset: 0x0044F2A0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010986 RID: 67974 RVA: 0x004510AC File Offset: 0x0044F2AC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010987 RID: 67975 RVA: 0x004510B8 File Offset: 0x0044F2B8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010988 RID: 67976 RVA: 0x004510C4 File Offset: 0x0044F2C4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010989 RID: 67977 RVA: 0x004510D0 File Offset: 0x0044F2D0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601098A RID: 67978 RVA: 0x004510D8 File Offset: 0x0044F2D8
		private void __callDele_EventOnSoldierAttackButtonClick(int arg1, int arg2, Action arg3)
		{
			Action<int, int, Action> eventOnSoldierAttackButtonClick = this.EventOnSoldierAttackButtonClick;
			if (eventOnSoldierAttackButtonClick != null)
			{
				eventOnSoldierAttackButtonClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0601098B RID: 67979 RVA: 0x004510FC File Offset: 0x0044F2FC
		private void __clearDele_EventOnSoldierAttackButtonClick(int arg1, int arg2, Action arg3)
		{
			this.EventOnSoldierAttackButtonClick = null;
		}

		// Token: 0x0601098C RID: 67980 RVA: 0x00451108 File Offset: 0x0044F308
		private void __callDele_EventOnGotoDrill(int obj)
		{
			Action<int> eventOnGotoDrill = this.EventOnGotoDrill;
			if (eventOnGotoDrill != null)
			{
				eventOnGotoDrill(obj);
			}
		}

		// Token: 0x0601098D RID: 67981 RVA: 0x0045112C File Offset: 0x0044F32C
		private void __clearDele_EventOnGotoDrill(int obj)
		{
			this.EventOnGotoDrill = null;
		}

		// Token: 0x0601098E RID: 67982 RVA: 0x00451138 File Offset: 0x0044F338
		private void __callDele_EventOnGotoJobTransfer(ConfigDataJobConnectionInfo obj)
		{
			Action<ConfigDataJobConnectionInfo> eventOnGotoJobTransfer = this.EventOnGotoJobTransfer;
			if (eventOnGotoJobTransfer != null)
			{
				eventOnGotoJobTransfer(obj);
			}
		}

		// Token: 0x0601098F RID: 67983 RVA: 0x0045115C File Offset: 0x0044F35C
		private void __clearDele_EventOnGotoJobTransfer(ConfigDataJobConnectionInfo obj)
		{
			this.EventOnGotoJobTransfer = null;
		}

		// Token: 0x06010990 RID: 67984 RVA: 0x00451168 File Offset: 0x0044F368
		private void __callDele_EventOnSkinInfoButtonClick(ConfigDataSoldierInfo obj)
		{
			Action<ConfigDataSoldierInfo> eventOnSkinInfoButtonClick = this.EventOnSkinInfoButtonClick;
			if (eventOnSkinInfoButtonClick != null)
			{
				eventOnSkinInfoButtonClick(obj);
			}
		}

		// Token: 0x06010991 RID: 67985 RVA: 0x0045118C File Offset: 0x0044F38C
		private void __clearDele_EventOnSkinInfoButtonClick(ConfigDataSoldierInfo obj)
		{
			this.EventOnSkinInfoButtonClick = null;
		}

		// Token: 0x06010992 RID: 67986 RVA: 0x00451198 File Offset: 0x0044F398
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
					this.m_UpdateViewInSoldierStateHero_hotfix = (luaObj.RawGet("UpdateViewInSoldierState") as LuaFunction);
					this.m_ShowSoldierInfoPanelConfigDataSoldierInfoBoolean_hotfix = (luaObj.RawGet("ShowSoldierInfoPanel") as LuaFunction);
					this.m_ShowSoldierSelectPanelHero_hotfix = (luaObj.RawGet("ShowSoldierSelectPanel") as LuaFunction);
					this.m_GetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix = (luaObj.RawGet("GetSoliderSortComparar") as LuaFunction);
					this.m_NotGetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix = (luaObj.RawGet("NotGetSoliderSortComparar") as LuaFunction);
					this.m_OnSoldierItemClickSoldierItemUIController_hotfix = (luaObj.RawGet("OnSoldierItemClick") as LuaFunction);
					this.m_OnSoldierGetConditionGotoButtonClick_hotfix = (luaObj.RawGet("OnSoldierGetConditionGotoButtonClick") as LuaFunction);
					this.m_OnSoldierItemAttackButtonClickConfigDataSoldierInfo_hotfix = (luaObj.RawGet("OnSoldierItemAttackButtonClick") as LuaFunction);
					this.m_SetCommonUIStateString_hotfix = (luaObj.RawGet("SetCommonUIState") as LuaFunction);
					this.m_CleanSoldierPanelDataOnHeroChanged_hotfix = (luaObj.RawGet("CleanSoldierPanelDataOnHeroChanged") as LuaFunction);
					this.m_OnSkinInfoButtonClick_hotfix = (luaObj.RawGet("OnSkinInfoButtonClick") as LuaFunction);
					this.m_add_EventOnSoldierAttackButtonClickAction`3_hotfix = (luaObj.RawGet("add_EventOnSoldierAttackButtonClick") as LuaFunction);
					this.m_remove_EventOnSoldierAttackButtonClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnSoldierAttackButtonClick") as LuaFunction);
					this.m_add_EventOnGotoDrillAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoDrill") as LuaFunction);
					this.m_remove_EventOnGotoDrillAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoDrill") as LuaFunction);
					this.m_add_EventOnGotoJobTransferAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoJobTransfer") as LuaFunction);
					this.m_remove_EventOnGotoJobTransferAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoJobTransfer") as LuaFunction);
					this.m_add_EventOnSkinInfoButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSkinInfoButtonClick") as LuaFunction);
					this.m_remove_EventOnSkinInfoButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSkinInfoButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010993 RID: 67987 RVA: 0x00451440 File Offset: 0x0044F640
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailSoldierUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009987 RID: 39303
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04009988 RID: 39304
		[AutoBind("./SoldierInfo/SoldierIconImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierIconImage;

		// Token: 0x04009989 RID: 39305
		[AutoBind("./SoldierInfo/QualityBGImage/QualityIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierQualityIcon;

		// Token: 0x0400998A RID: 39306
		[AutoBind("./SoldierInfo/SoldierNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x0400998B RID: 39307
		[AutoBind("./SoldierInfo/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphic;

		// Token: 0x0400998C RID: 39308
		[AutoBind("./SoldierInfo/Faction/RangeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierFactionRangeText;

		// Token: 0x0400998D RID: 39309
		[AutoBind("./SoldierInfo/Faction/MoveValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierFactionMoveText;

		// Token: 0x0400998E RID: 39310
		[AutoBind("./SoldierInfo/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHPValueText;

		// Token: 0x0400998F RID: 39311
		[AutoBind("./SoldierInfo/HP/AddPercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHPAddPercentText;

		// Token: 0x04009990 RID: 39312
		[AutoBind("./SoldierInfo/HP/AddPercentText/AddValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHPAddValueText;

		// Token: 0x04009991 RID: 39313
		[AutoBind("./SoldierInfo/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierATValueText;

		// Token: 0x04009992 RID: 39314
		[AutoBind("./SoldierInfo/AT/AddPercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierATAddPercentText;

		// Token: 0x04009993 RID: 39315
		[AutoBind("./SoldierInfo/AT/AddPercentText/AddValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierATAddValueText;

		// Token: 0x04009994 RID: 39316
		[AutoBind("./SoldierInfo/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDFValueText;

		// Token: 0x04009995 RID: 39317
		[AutoBind("./SoldierInfo/DF/AddPercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDFAddPercentText;

		// Token: 0x04009996 RID: 39318
		[AutoBind("./SoldierInfo/DF/AddPercentText/AddValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDFAddValueText;

		// Token: 0x04009997 RID: 39319
		[AutoBind("./SoldierInfo/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFValueText;

		// Token: 0x04009998 RID: 39320
		[AutoBind("./SoldierInfo/MagicDF/AddPercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFAddPercentText;

		// Token: 0x04009999 RID: 39321
		[AutoBind("./SoldierInfo/MagicDF/AddPercentText/AddValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierMagicDFAddValueText;

		// Token: 0x0400999A RID: 39322
		[AutoBind("./SoldierInfo/Strong/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierStrongText;

		// Token: 0x0400999B RID: 39323
		[AutoBind("./SoldierInfo/Weak/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierWeakText;

		// Token: 0x0400999C RID: 39324
		[AutoBind("./SoldierInfo/DescTextScroll/Mask/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierDescText;

		// Token: 0x0400999D RID: 39325
		[AutoBind("./SoldierSelet/SoldierItemScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_soldierSelectContentScrollRect;

		// Token: 0x0400999E RID: 39326
		[AutoBind("./SoldierSelet/SoldierItemScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierSelectContentObj;

		// Token: 0x0400999F RID: 39327
		[AutoBind("./SoldierSelet/SoldierGetCondition", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGetCondition;

		// Token: 0x040099A0 RID: 39328
		[AutoBind("./SoldierSelet/SoldierGetCondition/Texts", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_soldierGetConditionDescStateCtrl;

		// Token: 0x040099A1 RID: 39329
		[AutoBind("./SoldierSelet/SoldierGetCondition/Texts/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierGetConditionDescJobNameText;

		// Token: 0x040099A2 RID: 39330
		[AutoBind("./SoldierSelet/SoldierGetCondition/Texts/Text4", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierGetConditionDescText;

		// Token: 0x040099A3 RID: 39331
		[AutoBind("./SoldierSelet/SoldierGetCondition/GotoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_soldierGetConditionGotoButton;

		// Token: 0x040099A4 RID: 39332
		[AutoBind("./Prefab/SoldierItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierItemPrefabObj;

		// Token: 0x040099A5 RID: 39333
		[AutoBind("./SoldierInfo/SkinInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_skinInfoButton;

		// Token: 0x040099AA RID: 39338
		private Hero m_hero;

		// Token: 0x040099AB RID: 39339
		private UISpineGraphic m_soldierInfoGraphic;

		// Token: 0x040099AC RID: 39340
		private Dictionary<int, ConfigDataJobConnectionInfo> m_soldierIDToJobInfoDict;

		// Token: 0x040099AD RID: 39341
		private SoldierItemUIController m_lastClickSoldierItemCtrl;

		// Token: 0x040099AE RID: 39342
		private ConfigDataSoldierInfo m_lastClickSoldierInfo;

		// Token: 0x040099AF RID: 39343
		private List<SoldierItemUIController> m_soliderItemListCtrl = new List<SoldierItemUIController>();

		// Token: 0x040099B0 RID: 39344
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040099B1 RID: 39345
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040099B2 RID: 39346
		[DoNotToLua]
		private HeroDetailSoldierUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040099B3 RID: 39347
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040099B4 RID: 39348
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040099B5 RID: 39349
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040099B6 RID: 39350
		private LuaFunction m_UpdateViewInSoldierStateHero_hotfix;

		// Token: 0x040099B7 RID: 39351
		private LuaFunction m_ShowSoldierInfoPanelConfigDataSoldierInfoBoolean_hotfix;

		// Token: 0x040099B8 RID: 39352
		private LuaFunction m_ShowSoldierSelectPanelHero_hotfix;

		// Token: 0x040099B9 RID: 39353
		private LuaFunction m_GetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix;

		// Token: 0x040099BA RID: 39354
		private LuaFunction m_NotGetSoliderSortCompararConfigDataSoldierInfoConfigDataSoldierInfo_hotfix;

		// Token: 0x040099BB RID: 39355
		private LuaFunction m_OnSoldierItemClickSoldierItemUIController_hotfix;

		// Token: 0x040099BC RID: 39356
		private LuaFunction m_OnSoldierGetConditionGotoButtonClick_hotfix;

		// Token: 0x040099BD RID: 39357
		private LuaFunction m_OnSoldierItemAttackButtonClickConfigDataSoldierInfo_hotfix;

		// Token: 0x040099BE RID: 39358
		private LuaFunction m_SetCommonUIStateString_hotfix;

		// Token: 0x040099BF RID: 39359
		private LuaFunction m_CleanSoldierPanelDataOnHeroChanged_hotfix;

		// Token: 0x040099C0 RID: 39360
		private LuaFunction m_OnSkinInfoButtonClick_hotfix;

		// Token: 0x040099C1 RID: 39361
		private LuaFunction m_add_EventOnSoldierAttackButtonClickAction;

		// Token: 0x040099C2 RID: 39362
		private LuaFunction m_remove_EventOnSoldierAttackButtonClickAction;

		// Token: 0x040099C3 RID: 39363
		private LuaFunction m_add_EventOnGotoDrillAction;

		// Token: 0x040099C4 RID: 39364
		private LuaFunction m_remove_EventOnGotoDrillAction;

		// Token: 0x040099C5 RID: 39365
		private LuaFunction m_add_EventOnGotoJobTransferAction;

		// Token: 0x040099C6 RID: 39366
		private LuaFunction m_remove_EventOnGotoJobTransferAction;

		// Token: 0x040099C7 RID: 39367
		private LuaFunction m_add_EventOnSkinInfoButtonClickAction;

		// Token: 0x040099C8 RID: 39368
		private LuaFunction m_remove_EventOnSkinInfoButtonClickAction;

		// Token: 0x02000DB0 RID: 3504
		public new class LuaExportHelper
		{
			// Token: 0x06010994 RID: 67988 RVA: 0x004514A8 File Offset: 0x0044F6A8
			public LuaExportHelper(HeroDetailSoldierUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010995 RID: 67989 RVA: 0x004514B8 File Offset: 0x0044F6B8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010996 RID: 67990 RVA: 0x004514C8 File Offset: 0x0044F6C8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010997 RID: 67991 RVA: 0x004514D8 File Offset: 0x0044F6D8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010998 RID: 67992 RVA: 0x004514E8 File Offset: 0x0044F6E8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010999 RID: 67993 RVA: 0x00451500 File Offset: 0x0044F700
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601099A RID: 67994 RVA: 0x00451510 File Offset: 0x0044F710
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601099B RID: 67995 RVA: 0x00451520 File Offset: 0x0044F720
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601099C RID: 67996 RVA: 0x00451530 File Offset: 0x0044F730
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601099D RID: 67997 RVA: 0x00451540 File Offset: 0x0044F740
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601099E RID: 67998 RVA: 0x00451550 File Offset: 0x0044F750
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601099F RID: 67999 RVA: 0x00451560 File Offset: 0x0044F760
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060109A0 RID: 68000 RVA: 0x00451570 File Offset: 0x0044F770
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060109A1 RID: 68001 RVA: 0x00451580 File Offset: 0x0044F780
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060109A2 RID: 68002 RVA: 0x00451590 File Offset: 0x0044F790
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060109A3 RID: 68003 RVA: 0x004515A0 File Offset: 0x0044F7A0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060109A4 RID: 68004 RVA: 0x004515B0 File Offset: 0x0044F7B0
			public void __callDele_EventOnSoldierAttackButtonClick(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__callDele_EventOnSoldierAttackButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x060109A5 RID: 68005 RVA: 0x004515C0 File Offset: 0x0044F7C0
			public void __clearDele_EventOnSoldierAttackButtonClick(int arg1, int arg2, Action arg3)
			{
				this.m_owner.__clearDele_EventOnSoldierAttackButtonClick(arg1, arg2, arg3);
			}

			// Token: 0x060109A6 RID: 68006 RVA: 0x004515D0 File Offset: 0x0044F7D0
			public void __callDele_EventOnGotoDrill(int obj)
			{
				this.m_owner.__callDele_EventOnGotoDrill(obj);
			}

			// Token: 0x060109A7 RID: 68007 RVA: 0x004515E0 File Offset: 0x0044F7E0
			public void __clearDele_EventOnGotoDrill(int obj)
			{
				this.m_owner.__clearDele_EventOnGotoDrill(obj);
			}

			// Token: 0x060109A8 RID: 68008 RVA: 0x004515F0 File Offset: 0x0044F7F0
			public void __callDele_EventOnGotoJobTransfer(ConfigDataJobConnectionInfo obj)
			{
				this.m_owner.__callDele_EventOnGotoJobTransfer(obj);
			}

			// Token: 0x060109A9 RID: 68009 RVA: 0x00451600 File Offset: 0x0044F800
			public void __clearDele_EventOnGotoJobTransfer(ConfigDataJobConnectionInfo obj)
			{
				this.m_owner.__clearDele_EventOnGotoJobTransfer(obj);
			}

			// Token: 0x060109AA RID: 68010 RVA: 0x00451610 File Offset: 0x0044F810
			public void __callDele_EventOnSkinInfoButtonClick(ConfigDataSoldierInfo obj)
			{
				this.m_owner.__callDele_EventOnSkinInfoButtonClick(obj);
			}

			// Token: 0x060109AB RID: 68011 RVA: 0x00451620 File Offset: 0x0044F820
			public void __clearDele_EventOnSkinInfoButtonClick(ConfigDataSoldierInfo obj)
			{
				this.m_owner.__clearDele_EventOnSkinInfoButtonClick(obj);
			}

			// Token: 0x1700334B RID: 13131
			// (get) Token: 0x060109AC RID: 68012 RVA: 0x00451630 File Offset: 0x0044F830
			// (set) Token: 0x060109AD RID: 68013 RVA: 0x00451640 File Offset: 0x0044F840
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

			// Token: 0x1700334C RID: 13132
			// (get) Token: 0x060109AE RID: 68014 RVA: 0x00451650 File Offset: 0x0044F850
			// (set) Token: 0x060109AF RID: 68015 RVA: 0x00451660 File Offset: 0x0044F860
			public Image m_soldierIconImage
			{
				get
				{
					return this.m_owner.m_soldierIconImage;
				}
				set
				{
					this.m_owner.m_soldierIconImage = value;
				}
			}

			// Token: 0x1700334D RID: 13133
			// (get) Token: 0x060109B0 RID: 68016 RVA: 0x00451670 File Offset: 0x0044F870
			// (set) Token: 0x060109B1 RID: 68017 RVA: 0x00451680 File Offset: 0x0044F880
			public Image m_soldierQualityIcon
			{
				get
				{
					return this.m_owner.m_soldierQualityIcon;
				}
				set
				{
					this.m_owner.m_soldierQualityIcon = value;
				}
			}

			// Token: 0x1700334E RID: 13134
			// (get) Token: 0x060109B2 RID: 68018 RVA: 0x00451690 File Offset: 0x0044F890
			// (set) Token: 0x060109B3 RID: 68019 RVA: 0x004516A0 File Offset: 0x0044F8A0
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

			// Token: 0x1700334F RID: 13135
			// (get) Token: 0x060109B4 RID: 68020 RVA: 0x004516B0 File Offset: 0x0044F8B0
			// (set) Token: 0x060109B5 RID: 68021 RVA: 0x004516C0 File Offset: 0x0044F8C0
			public GameObject m_soldierGraphic
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

			// Token: 0x17003350 RID: 13136
			// (get) Token: 0x060109B6 RID: 68022 RVA: 0x004516D0 File Offset: 0x0044F8D0
			// (set) Token: 0x060109B7 RID: 68023 RVA: 0x004516E0 File Offset: 0x0044F8E0
			public Text m_soldierFactionRangeText
			{
				get
				{
					return this.m_owner.m_soldierFactionRangeText;
				}
				set
				{
					this.m_owner.m_soldierFactionRangeText = value;
				}
			}

			// Token: 0x17003351 RID: 13137
			// (get) Token: 0x060109B8 RID: 68024 RVA: 0x004516F0 File Offset: 0x0044F8F0
			// (set) Token: 0x060109B9 RID: 68025 RVA: 0x00451700 File Offset: 0x0044F900
			public Text m_soldierFactionMoveText
			{
				get
				{
					return this.m_owner.m_soldierFactionMoveText;
				}
				set
				{
					this.m_owner.m_soldierFactionMoveText = value;
				}
			}

			// Token: 0x17003352 RID: 13138
			// (get) Token: 0x060109BA RID: 68026 RVA: 0x00451710 File Offset: 0x0044F910
			// (set) Token: 0x060109BB RID: 68027 RVA: 0x00451720 File Offset: 0x0044F920
			public Text m_soldierHPValueText
			{
				get
				{
					return this.m_owner.m_soldierHPValueText;
				}
				set
				{
					this.m_owner.m_soldierHPValueText = value;
				}
			}

			// Token: 0x17003353 RID: 13139
			// (get) Token: 0x060109BC RID: 68028 RVA: 0x00451730 File Offset: 0x0044F930
			// (set) Token: 0x060109BD RID: 68029 RVA: 0x00451740 File Offset: 0x0044F940
			public Text m_soldierHPAddPercentText
			{
				get
				{
					return this.m_owner.m_soldierHPAddPercentText;
				}
				set
				{
					this.m_owner.m_soldierHPAddPercentText = value;
				}
			}

			// Token: 0x17003354 RID: 13140
			// (get) Token: 0x060109BE RID: 68030 RVA: 0x00451750 File Offset: 0x0044F950
			// (set) Token: 0x060109BF RID: 68031 RVA: 0x00451760 File Offset: 0x0044F960
			public Text m_soldierHPAddValueText
			{
				get
				{
					return this.m_owner.m_soldierHPAddValueText;
				}
				set
				{
					this.m_owner.m_soldierHPAddValueText = value;
				}
			}

			// Token: 0x17003355 RID: 13141
			// (get) Token: 0x060109C0 RID: 68032 RVA: 0x00451770 File Offset: 0x0044F970
			// (set) Token: 0x060109C1 RID: 68033 RVA: 0x00451780 File Offset: 0x0044F980
			public Text m_soldierATValueText
			{
				get
				{
					return this.m_owner.m_soldierATValueText;
				}
				set
				{
					this.m_owner.m_soldierATValueText = value;
				}
			}

			// Token: 0x17003356 RID: 13142
			// (get) Token: 0x060109C2 RID: 68034 RVA: 0x00451790 File Offset: 0x0044F990
			// (set) Token: 0x060109C3 RID: 68035 RVA: 0x004517A0 File Offset: 0x0044F9A0
			public Text m_soldierATAddPercentText
			{
				get
				{
					return this.m_owner.m_soldierATAddPercentText;
				}
				set
				{
					this.m_owner.m_soldierATAddPercentText = value;
				}
			}

			// Token: 0x17003357 RID: 13143
			// (get) Token: 0x060109C4 RID: 68036 RVA: 0x004517B0 File Offset: 0x0044F9B0
			// (set) Token: 0x060109C5 RID: 68037 RVA: 0x004517C0 File Offset: 0x0044F9C0
			public Text m_soldierATAddValueText
			{
				get
				{
					return this.m_owner.m_soldierATAddValueText;
				}
				set
				{
					this.m_owner.m_soldierATAddValueText = value;
				}
			}

			// Token: 0x17003358 RID: 13144
			// (get) Token: 0x060109C6 RID: 68038 RVA: 0x004517D0 File Offset: 0x0044F9D0
			// (set) Token: 0x060109C7 RID: 68039 RVA: 0x004517E0 File Offset: 0x0044F9E0
			public Text m_soldierDFValueText
			{
				get
				{
					return this.m_owner.m_soldierDFValueText;
				}
				set
				{
					this.m_owner.m_soldierDFValueText = value;
				}
			}

			// Token: 0x17003359 RID: 13145
			// (get) Token: 0x060109C8 RID: 68040 RVA: 0x004517F0 File Offset: 0x0044F9F0
			// (set) Token: 0x060109C9 RID: 68041 RVA: 0x00451800 File Offset: 0x0044FA00
			public Text m_soldierDFAddPercentText
			{
				get
				{
					return this.m_owner.m_soldierDFAddPercentText;
				}
				set
				{
					this.m_owner.m_soldierDFAddPercentText = value;
				}
			}

			// Token: 0x1700335A RID: 13146
			// (get) Token: 0x060109CA RID: 68042 RVA: 0x00451810 File Offset: 0x0044FA10
			// (set) Token: 0x060109CB RID: 68043 RVA: 0x00451820 File Offset: 0x0044FA20
			public Text m_soldierDFAddValueText
			{
				get
				{
					return this.m_owner.m_soldierDFAddValueText;
				}
				set
				{
					this.m_owner.m_soldierDFAddValueText = value;
				}
			}

			// Token: 0x1700335B RID: 13147
			// (get) Token: 0x060109CC RID: 68044 RVA: 0x00451830 File Offset: 0x0044FA30
			// (set) Token: 0x060109CD RID: 68045 RVA: 0x00451840 File Offset: 0x0044FA40
			public Text m_soldierMagicDFValueText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFValueText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFValueText = value;
				}
			}

			// Token: 0x1700335C RID: 13148
			// (get) Token: 0x060109CE RID: 68046 RVA: 0x00451850 File Offset: 0x0044FA50
			// (set) Token: 0x060109CF RID: 68047 RVA: 0x00451860 File Offset: 0x0044FA60
			public Text m_soldierMagicDFAddPercentText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFAddPercentText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFAddPercentText = value;
				}
			}

			// Token: 0x1700335D RID: 13149
			// (get) Token: 0x060109D0 RID: 68048 RVA: 0x00451870 File Offset: 0x0044FA70
			// (set) Token: 0x060109D1 RID: 68049 RVA: 0x00451880 File Offset: 0x0044FA80
			public Text m_soldierMagicDFAddValueText
			{
				get
				{
					return this.m_owner.m_soldierMagicDFAddValueText;
				}
				set
				{
					this.m_owner.m_soldierMagicDFAddValueText = value;
				}
			}

			// Token: 0x1700335E RID: 13150
			// (get) Token: 0x060109D2 RID: 68050 RVA: 0x00451890 File Offset: 0x0044FA90
			// (set) Token: 0x060109D3 RID: 68051 RVA: 0x004518A0 File Offset: 0x0044FAA0
			public Text m_soldierStrongText
			{
				get
				{
					return this.m_owner.m_soldierStrongText;
				}
				set
				{
					this.m_owner.m_soldierStrongText = value;
				}
			}

			// Token: 0x1700335F RID: 13151
			// (get) Token: 0x060109D4 RID: 68052 RVA: 0x004518B0 File Offset: 0x0044FAB0
			// (set) Token: 0x060109D5 RID: 68053 RVA: 0x004518C0 File Offset: 0x0044FAC0
			public Text m_soldierWeakText
			{
				get
				{
					return this.m_owner.m_soldierWeakText;
				}
				set
				{
					this.m_owner.m_soldierWeakText = value;
				}
			}

			// Token: 0x17003360 RID: 13152
			// (get) Token: 0x060109D6 RID: 68054 RVA: 0x004518D0 File Offset: 0x0044FAD0
			// (set) Token: 0x060109D7 RID: 68055 RVA: 0x004518E0 File Offset: 0x0044FAE0
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

			// Token: 0x17003361 RID: 13153
			// (get) Token: 0x060109D8 RID: 68056 RVA: 0x004518F0 File Offset: 0x0044FAF0
			// (set) Token: 0x060109D9 RID: 68057 RVA: 0x00451900 File Offset: 0x0044FB00
			public ScrollRect m_soldierSelectContentScrollRect
			{
				get
				{
					return this.m_owner.m_soldierSelectContentScrollRect;
				}
				set
				{
					this.m_owner.m_soldierSelectContentScrollRect = value;
				}
			}

			// Token: 0x17003362 RID: 13154
			// (get) Token: 0x060109DA RID: 68058 RVA: 0x00451910 File Offset: 0x0044FB10
			// (set) Token: 0x060109DB RID: 68059 RVA: 0x00451920 File Offset: 0x0044FB20
			public GameObject m_soldierSelectContentObj
			{
				get
				{
					return this.m_owner.m_soldierSelectContentObj;
				}
				set
				{
					this.m_owner.m_soldierSelectContentObj = value;
				}
			}

			// Token: 0x17003363 RID: 13155
			// (get) Token: 0x060109DC RID: 68060 RVA: 0x00451930 File Offset: 0x0044FB30
			// (set) Token: 0x060109DD RID: 68061 RVA: 0x00451940 File Offset: 0x0044FB40
			public GameObject m_soldierGetCondition
			{
				get
				{
					return this.m_owner.m_soldierGetCondition;
				}
				set
				{
					this.m_owner.m_soldierGetCondition = value;
				}
			}

			// Token: 0x17003364 RID: 13156
			// (get) Token: 0x060109DE RID: 68062 RVA: 0x00451950 File Offset: 0x0044FB50
			// (set) Token: 0x060109DF RID: 68063 RVA: 0x00451960 File Offset: 0x0044FB60
			public CommonUIStateController m_soldierGetConditionDescStateCtrl
			{
				get
				{
					return this.m_owner.m_soldierGetConditionDescStateCtrl;
				}
				set
				{
					this.m_owner.m_soldierGetConditionDescStateCtrl = value;
				}
			}

			// Token: 0x17003365 RID: 13157
			// (get) Token: 0x060109E0 RID: 68064 RVA: 0x00451970 File Offset: 0x0044FB70
			// (set) Token: 0x060109E1 RID: 68065 RVA: 0x00451980 File Offset: 0x0044FB80
			public Text m_soldierGetConditionDescJobNameText
			{
				get
				{
					return this.m_owner.m_soldierGetConditionDescJobNameText;
				}
				set
				{
					this.m_owner.m_soldierGetConditionDescJobNameText = value;
				}
			}

			// Token: 0x17003366 RID: 13158
			// (get) Token: 0x060109E2 RID: 68066 RVA: 0x00451990 File Offset: 0x0044FB90
			// (set) Token: 0x060109E3 RID: 68067 RVA: 0x004519A0 File Offset: 0x0044FBA0
			public Text m_soldierGetConditionDescText
			{
				get
				{
					return this.m_owner.m_soldierGetConditionDescText;
				}
				set
				{
					this.m_owner.m_soldierGetConditionDescText = value;
				}
			}

			// Token: 0x17003367 RID: 13159
			// (get) Token: 0x060109E4 RID: 68068 RVA: 0x004519B0 File Offset: 0x0044FBB0
			// (set) Token: 0x060109E5 RID: 68069 RVA: 0x004519C0 File Offset: 0x0044FBC0
			public Button m_soldierGetConditionGotoButton
			{
				get
				{
					return this.m_owner.m_soldierGetConditionGotoButton;
				}
				set
				{
					this.m_owner.m_soldierGetConditionGotoButton = value;
				}
			}

			// Token: 0x17003368 RID: 13160
			// (get) Token: 0x060109E6 RID: 68070 RVA: 0x004519D0 File Offset: 0x0044FBD0
			// (set) Token: 0x060109E7 RID: 68071 RVA: 0x004519E0 File Offset: 0x0044FBE0
			public GameObject m_soldierItemPrefabObj
			{
				get
				{
					return this.m_owner.m_soldierItemPrefabObj;
				}
				set
				{
					this.m_owner.m_soldierItemPrefabObj = value;
				}
			}

			// Token: 0x17003369 RID: 13161
			// (get) Token: 0x060109E8 RID: 68072 RVA: 0x004519F0 File Offset: 0x0044FBF0
			// (set) Token: 0x060109E9 RID: 68073 RVA: 0x00451A00 File Offset: 0x0044FC00
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

			// Token: 0x1700336A RID: 13162
			// (get) Token: 0x060109EA RID: 68074 RVA: 0x00451A10 File Offset: 0x0044FC10
			// (set) Token: 0x060109EB RID: 68075 RVA: 0x00451A20 File Offset: 0x0044FC20
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

			// Token: 0x1700336B RID: 13163
			// (get) Token: 0x060109EC RID: 68076 RVA: 0x00451A30 File Offset: 0x0044FC30
			// (set) Token: 0x060109ED RID: 68077 RVA: 0x00451A40 File Offset: 0x0044FC40
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

			// Token: 0x1700336C RID: 13164
			// (get) Token: 0x060109EE RID: 68078 RVA: 0x00451A50 File Offset: 0x0044FC50
			// (set) Token: 0x060109EF RID: 68079 RVA: 0x00451A60 File Offset: 0x0044FC60
			public Dictionary<int, ConfigDataJobConnectionInfo> m_soldierIDToJobInfoDict
			{
				get
				{
					return this.m_owner.m_soldierIDToJobInfoDict;
				}
				set
				{
					this.m_owner.m_soldierIDToJobInfoDict = value;
				}
			}

			// Token: 0x1700336D RID: 13165
			// (get) Token: 0x060109F0 RID: 68080 RVA: 0x00451A70 File Offset: 0x0044FC70
			// (set) Token: 0x060109F1 RID: 68081 RVA: 0x00451A80 File Offset: 0x0044FC80
			public SoldierItemUIController m_lastClickSoldierItemCtrl
			{
				get
				{
					return this.m_owner.m_lastClickSoldierItemCtrl;
				}
				set
				{
					this.m_owner.m_lastClickSoldierItemCtrl = value;
				}
			}

			// Token: 0x1700336E RID: 13166
			// (get) Token: 0x060109F2 RID: 68082 RVA: 0x00451A90 File Offset: 0x0044FC90
			// (set) Token: 0x060109F3 RID: 68083 RVA: 0x00451AA0 File Offset: 0x0044FCA0
			public ConfigDataSoldierInfo m_lastClickSoldierInfo
			{
				get
				{
					return this.m_owner.m_lastClickSoldierInfo;
				}
				set
				{
					this.m_owner.m_lastClickSoldierInfo = value;
				}
			}

			// Token: 0x1700336F RID: 13167
			// (get) Token: 0x060109F4 RID: 68084 RVA: 0x00451AB0 File Offset: 0x0044FCB0
			// (set) Token: 0x060109F5 RID: 68085 RVA: 0x00451AC0 File Offset: 0x0044FCC0
			public List<SoldierItemUIController> m_soliderItemListCtrl
			{
				get
				{
					return this.m_owner.m_soliderItemListCtrl;
				}
				set
				{
					this.m_owner.m_soliderItemListCtrl = value;
				}
			}

			// Token: 0x17003370 RID: 13168
			// (get) Token: 0x060109F6 RID: 68086 RVA: 0x00451AD0 File Offset: 0x0044FCD0
			// (set) Token: 0x060109F7 RID: 68087 RVA: 0x00451AE0 File Offset: 0x0044FCE0
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

			// Token: 0x17003371 RID: 13169
			// (get) Token: 0x060109F8 RID: 68088 RVA: 0x00451AF0 File Offset: 0x0044FCF0
			// (set) Token: 0x060109F9 RID: 68089 RVA: 0x00451B00 File Offset: 0x0044FD00
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

			// Token: 0x060109FA RID: 68090 RVA: 0x00451B10 File Offset: 0x0044FD10
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060109FB RID: 68091 RVA: 0x00451B20 File Offset: 0x0044FD20
			public void ShowSoldierInfoPanel(ConfigDataSoldierInfo soldierInfo, bool isSoldierGet)
			{
				this.m_owner.ShowSoldierInfoPanel(soldierInfo, isSoldierGet);
			}

			// Token: 0x060109FC RID: 68092 RVA: 0x00451B30 File Offset: 0x0044FD30
			public void ShowSoldierSelectPanel(Hero hero)
			{
				this.m_owner.ShowSoldierSelectPanel(hero);
			}

			// Token: 0x060109FD RID: 68093 RVA: 0x00451B40 File Offset: 0x0044FD40
			public int GetSoliderSortComparar(ConfigDataSoldierInfo s1, ConfigDataSoldierInfo s2)
			{
				return this.m_owner.GetSoliderSortComparar(s1, s2);
			}

			// Token: 0x060109FE RID: 68094 RVA: 0x00451B50 File Offset: 0x0044FD50
			public int NotGetSoliderSortComparar(ConfigDataSoldierInfo s1, ConfigDataSoldierInfo s2)
			{
				return this.m_owner.NotGetSoliderSortComparar(s1, s2);
			}

			// Token: 0x060109FF RID: 68095 RVA: 0x00451B60 File Offset: 0x0044FD60
			public void OnSoldierItemClick(SoldierItemUIController ctrl)
			{
				this.m_owner.OnSoldierItemClick(ctrl);
			}

			// Token: 0x06010A00 RID: 68096 RVA: 0x00451B70 File Offset: 0x0044FD70
			public void OnSoldierGetConditionGotoButtonClick()
			{
				this.m_owner.OnSoldierGetConditionGotoButtonClick();
			}

			// Token: 0x06010A01 RID: 68097 RVA: 0x00451B80 File Offset: 0x0044FD80
			public void OnSoldierItemAttackButtonClick(ConfigDataSoldierInfo soldierInfo)
			{
				this.m_owner.OnSoldierItemAttackButtonClick(soldierInfo);
			}

			// Token: 0x06010A02 RID: 68098 RVA: 0x00451B90 File Offset: 0x0044FD90
			public void CleanSoldierPanelDataOnHeroChanged()
			{
				this.m_owner.CleanSoldierPanelDataOnHeroChanged();
			}

			// Token: 0x06010A03 RID: 68099 RVA: 0x00451BA0 File Offset: 0x0044FDA0
			public void OnSkinInfoButtonClick()
			{
				this.m_owner.OnSkinInfoButtonClick();
			}

			// Token: 0x040099C9 RID: 39369
			private HeroDetailSoldierUIController m_owner;
		}
	}
}
