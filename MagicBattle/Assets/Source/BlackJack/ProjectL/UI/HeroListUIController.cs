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
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DD0 RID: 3536
	[HotFix]
	public class HeroListUIController : UIControllerBase
	{
		// Token: 0x06010E76 RID: 69238 RVA: 0x0045FA48 File Offset: 0x0045DC48
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
			this.m_sortButton.onClick.AddListener(new UnityAction(this.OnSortButtonClick));
			this.m_breakButton.onClick.AddListener(new UnityAction(this.OnBreakButtonClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_filterButton.onClick.AddListener(new UnityAction(this.OnFilterButtonClick));
			this.m_detailButton.onClick.AddListener(new UnityAction(this.OnDetailButtonClick));
			this.m_summonButton.onClick.AddListener(new UnityAction(this.OnSummonButtonClick));
			this.m_commentButton.onClick.AddListener(new UnityAction(this.OnCommentButtonClick));
			this.m_addheroButton.onClick.AddListener(new UnityAction(this.OnAddHeroButtonClick));
			this.m_speedUpHeroButton.onClick.AddListener(new UnityAction(this.OnSpeedUpHeroButtonClick));
			this.m_resetHeroButton.onClick.AddListener(new UnityAction(this.OnResetHeroButtonClick));
			this.m_composeConfirmButton.onClick.AddListener(new UnityAction(this.ConfirmComposeHero));
			this.m_composeCancelButton.onClick.AddListener(new UnityAction(this.CloseComposeHeroPanel));
			this.m_sortTypesReturnBgImage.onClick.AddListener(new UnityAction(this.CloseSortTypesPanel));
			this.m_breakAddBtn.onClick.AddListener(new UnityAction(this.OnHeroFragmentSearchButtonClick));
			this.m_heroEquipmentsButton.onClick.AddListener(new UnityAction(this.OnEquipmentsButtonClick));
			this.m_heroJobUpButton.onClick.AddListener(new UnityAction(this.OnHeroJobUpButtonClick));
			this.m_heroCharSkinChangeButton.onClick.AddListener(new UnityAction(this.OnHeroCharSkinChangeButton));
			this.m_extractionButton.onClick.AddListener(new UnityAction(this.OnExtractionButtonClick));
			this.m_sortTypesLevelToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnLevelToggleValueChanged));
			this.m_sortTypesRarityToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRankToggleValueChanged));
			this.m_sortTypesStarToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnStarLevelToggleValueChanged));
			this.m_sortTypesPowerToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnPowerToggleValueChanged));
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_charGameObjectRoot);
			this.m_heroCharUIController.EventOnClick += this.HeroCharUIController_OnClick;
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState("StartState", false, true);
		}

		// Token: 0x06010E77 RID: 69239 RVA: 0x0045FD90 File Offset: 0x0045DF90
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

		// Token: 0x06010E78 RID: 69240 RVA: 0x0045FDF0 File Offset: 0x0045DFF0
		public void UpdateViewInHeroList(bool isNeedRebuildHeroList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInHeroListBoolean_hotfix != null)
			{
				this.m_UpdateViewInHeroListBoolean_hotfix.call(new object[]
				{
					this,
					isNeedRebuildHeroList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfigData data = LocalConfig.Instance.Data;
			this.m_addheroButton.gameObject.SetActive(data.IsDeveloper);
			this.m_heroIdInputField.gameObject.SetActive(data.IsDeveloper);
			this.m_speedUpHeroButton.gameObject.SetActive(data.IsDeveloper);
			this.m_resetHeroButton.gameObject.SetActive(data.IsDeveloper);
			if (this.EventOnInitHeroList != null)
			{
				this.EventOnInitHeroList(this.m_unLockedHeroList, this.m_lockedHeroList);
			}
			if (isNeedRebuildHeroList)
			{
				this.CreateHeroList();
			}
			else
			{
				this.InactiveCharWordPanel();
			}
			Hero hero = this.GetCurHeroList()[this.m_curSelectedHeroIndex];
			CommonUIStateController component = this.m_heroInfoPanel.GetComponent<CommonUIStateController>();
			if (this.m_isUnLockHero)
			{
				component.SetToUIState("Unlock", false, true);
			}
			else
			{
				component.SetToUIState("Lock", false, true);
			}
			if (this.m_heroCharUIController.GetCharImageInfo() != hero.HeroInfo.GetCharImageInfo(hero.StarLevel) || hero.CharSkinId != this.m_heroCharUIController.GetHeroCharSkinId())
			{
				HeroCharUIController heroCharUIController = this.m_heroCharUIController;
				Hero hero2 = hero;
				bool isUnLockHero = this.m_isUnLockHero;
				heroCharUIController.CreateGraphic(hero2, HeroCharUIController.PerformanceState.All, isUnLockHero, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			}
			this.m_heroCharUIController.SetCanClick(this.m_isUnLockHero);
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_cvText.text = charImageInfo.CVName;
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_heroStar, hero.StarLevel);
			this.m_heroNameTextCh.text = hero.HeroInfo.Name;
			this.m_heroNameTextEn.text = hero.HeroInfo.Name_Eng;
			this.m_heroRankImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetRankImage(hero.HeroInfo.GetRank(hero.StarLevel)));
			if (this.m_isUnLockHero)
			{
				this.m_heroCharUIController.SetSpineColor(Color.white);
			}
			else
			{
				this.m_heroCharUIController.SetSpineColor(Color.black);
			}
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID);
			ConfigDataHeroStarInfo configDataHeroStarInfo;
			if (hero.StarLevel == this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax)
			{
				configDataHeroStarInfo = this.m_configDataLoader.GetConfigDataHeroStarInfo(hero.StarLevel);
			}
			else
			{
				configDataHeroStarInfo = this.m_configDataLoader.GetConfigDataHeroStarInfo(hero.StarLevel + 1);
			}
			ConfigDataHeroStarInfo configDataHeroStarInfo2 = this.m_configDataLoader.GetConfigDataHeroStarInfo(hero.StarLevel);
			this.m_curHeroNeedFragmentCount = 0;
			if (this.m_isUnLockHero)
			{
				this.m_curHeroNeedFragmentCount = configDataHeroStarInfo.Fragment - configDataHeroStarInfo2.Fragment;
			}
			else
			{
				this.m_curHeroNeedFragmentCount = configDataHeroStarInfo2.Fragment;
			}
			this.m_breakNumText.text = bagItemCountByType + "/" + this.m_curHeroNeedFragmentCount;
			this.m_breakIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID));
			this.m_breakIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID));
			this.m_breakButton.gameObject.SetActive(this.m_isUnLockHero);
			bool flag = bagItemCountByType >= this.m_curHeroNeedFragmentCount && this.m_curHeroNeedFragmentCount != 0;
			if (this.m_breakButtonReadyEffect.activeSelf != flag)
			{
				this.m_breakButtonReadyEffect.SetActive(flag);
			}
			if (this.m_summonButtonReadyEffect.activeSelf != flag)
			{
				this.m_summonButtonReadyEffect.SetActive(flag);
			}
			bool flag2 = hero.StarLevel >= this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax;
			bool flag3 = UIUtility.GetGoodsCount(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID) > 0;
			this.m_extractionButton.gameObject.SetActive(flag2);
			if (flag2 && flag3 && !LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction)
			{
				UIUtility.SetUIStateOpen(this.m_extractionTipsStateCtrl, "Show", null, false, true);
			}
			else
			{
				this.m_extractionTipsStateCtrl.gameObject.SetActive(false);
			}
			bool active = this.m_unLockedHeroList != null && this.m_unLockedHeroList.Count != 0 && this.m_isUnLockHero;
			this.m_detailButton.gameObject.SetActive(active);
			ulong[] equipmentIds = hero.EquipmentIds;
			Transform transform = this.m_heroEquipmentsContent.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				CommonUIStateController component2 = transform.GetChild(i).GetComponent<CommonUIStateController>();
				if (equipmentIds[i] == 0UL)
				{
					component2.SetToUIState("Dark", false, true);
				}
				else
				{
					component2.SetToUIState("Normal", false, true);
				}
			}
			bool flag4 = this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Equipment);
			this.m_heroEquipmentsRedPointImage.SetActive(flag4 && this.m_isUnLockHero && this.m_playerContext.HasBetterEquipmentByHero(hero));
			this.m_heroJobUpButton.gameObject.SetActive(this.m_playerContext.IsShowJobLevelCanUpTip(hero));
			bool active2 = this.m_playerContext.CanLevelUpHeroJobLevel(hero.HeroId, hero.ActiveHeroJobRelatedId) == 0;
			this.m_detailButtonRedPointImage.SetActive(active2);
		}

		// Token: 0x06010E79 RID: 69241 RVA: 0x004603BC File Offset: 0x0045E5BC
		private void CreateHeroList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateHeroList_hotfix != null)
			{
				this.m_CreateHeroList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetSortTypeButtonAndToggles();
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("heroItem");
			UIUtility.SetGameObjectChildrenActiveCount(this.m_scrollViewUnlockedHeroContent, this.m_unLockedHeroList.Count);
			this.m_unLockedHeroCtrlList.Clear();
			this.m_lockedHeroCtrlList.Clear();
			if (this.m_unLockedHeroList != null && this.m_unLockedHeroList.Count != 0)
			{
				Transform transform = this.m_scrollViewUnlockedHeroContent.transform;
				for (int i = 0; i < this.m_unLockedHeroList.Count; i++)
				{
					Hero hero = this.m_unLockedHeroList[i];
					HeroItemUIController component;
					if (i < transform.childCount)
					{
						GameObject gameObject = transform.GetChild(i).gameObject;
						component = gameObject.GetComponent<HeroItemUIController>();
					}
					else
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
						gameObject2.name = string.Format("HeroListItem_{0}", hero.HeroId);
						PrefabControllerCreater.CreateAllControllers(gameObject2);
						component = gameObject2.GetComponent<HeroItemUIController>();
						component.EventOnHeroItemClick += this.OnHeroItemClick;
						gameObject2.transform.SetParent(this.m_scrollViewUnlockedHeroContent.transform, false);
					}
					component.InitValuesInHeroItemUnlocked(hero, hero.Level, hero.StarLevel);
					this.m_unLockedHeroCtrlList.Add(component);
				}
				foreach (HeroItemUIController heroItemUIController in this.m_unLockedHeroCtrlList)
				{
					if (this.m_isUnLockHero)
					{
						heroItemUIController.ShowSelectFrameImage(heroItemUIController == this.m_unLockedHeroCtrlList[this.m_curSelectedHeroIndex]);
					}
					else
					{
						heroItemUIController.ShowSelectFrameImage(false);
					}
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_scrollViewLockedHeroContent, this.m_lockedHeroList.Count);
			if (this.m_lockedHeroList != null && this.m_lockedHeroList.Count != 0)
			{
				Transform transform2 = this.m_scrollViewLockedHeroContent.transform;
				for (int j = 0; j < this.m_lockedHeroList.Count; j++)
				{
					Hero hero2 = this.m_lockedHeroList[j];
					HeroItemUIController component2;
					if (j < transform2.childCount)
					{
						GameObject gameObject3 = transform2.GetChild(j).gameObject;
						component2 = gameObject3.GetComponent<HeroItemUIController>();
					}
					else
					{
						GameObject gameObject4 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
						gameObject4.name = string.Format("HeroListItem_{0}", hero2.HeroId);
						PrefabControllerCreater.CreateAllControllers(gameObject4);
						component2 = gameObject4.GetComponent<HeroItemUIController>();
						component2.EventOnHeroItemClick += this.OnHeroItemClick;
						gameObject4.transform.SetParent(this.m_scrollViewLockedHeroContent.transform, false);
					}
					int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, hero2.HeroInfo.FragmentItem_ID);
					int fragment = this.m_configDataLoader.GetConfigDataHeroStarInfo(hero2.StarLevel).Fragment;
					component2.InitValuesInHeroItemLocked(hero2, hero2.StarLevel, bagItemCountByType, fragment);
					this.m_lockedHeroCtrlList.Add(component2);
				}
				foreach (HeroItemUIController heroItemUIController2 in this.m_lockedHeroCtrlList)
				{
					if (!this.m_isUnLockHero)
					{
						heroItemUIController2.ShowSelectFrameImage(heroItemUIController2 == this.m_lockedHeroCtrlList[this.m_curSelectedHeroIndex]);
					}
					else
					{
						heroItemUIController2.ShowSelectFrameImage(false);
					}
				}
			}
		}

		// Token: 0x06010E7A RID: 69242 RVA: 0x004607A8 File Offset: 0x0045E9A8
		public void SetHeroPowerValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroPowerValue_hotfix != null)
			{
				this.m_SetHeroPowerValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isUnLockHero)
			{
				this.m_powerValueStateCtrl.gameObject.SetActive(true);
				Hero hero = this.GetCurHeroList()[this.m_curSelectedHeroIndex];
				int battlePower = hero.BattlePower;
				if (this.m_heroPowerValue == 0)
				{
					this.m_powerArrowGo.SetActive(false);
					this.m_powerValueText.text = battlePower.ToString();
				}
				else if (this.m_heroPowerValue != battlePower)
				{
					base.StartCoroutine(this.Co_SetPowerValue((float)battlePower, (float)this.m_heroPowerValue));
				}
				else
				{
					this.m_powerArrowGo.SetActive(false);
				}
				this.m_heroPowerValue = battlePower;
			}
			else
			{
				this.m_powerValueStateCtrl.gameObject.SetActive(false);
			}
		}

		// Token: 0x06010E7B RID: 69243 RVA: 0x004608C4 File Offset: 0x0045EAC4
		public void ResetHeroPowerValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetHeroPowerValue_hotfix != null)
			{
				this.m_ResetHeroPowerValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroPowerValue = 0;
		}

		// Token: 0x06010E7C RID: 69244 RVA: 0x0046092C File Offset: 0x0045EB2C
		public void StopAllCoroutineInHeroList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopAllCoroutineInHeroList_hotfix != null)
			{
				this.m_StopAllCoroutineInHeroList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
		}

		// Token: 0x06010E7D RID: 69245 RVA: 0x00460994 File Offset: 0x0045EB94
		public void SetHeroCharSkinPreview(string spinePath, int heroSkinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroCharSkinPreviewStringInt32_hotfix != null)
			{
				this.m_SetHeroCharSkinPreviewStringInt32_hotfix.call(new object[]
				{
					this,
					spinePath,
					heroSkinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.GetCurHeroList()[this.m_curSelectedHeroIndex];
			this.m_heroCharUIController.CreateGraphic(hero.HeroInfo, spinePath, heroSkinId);
			this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
		}

		// Token: 0x06010E7E RID: 69246 RVA: 0x00460A4C File Offset: 0x0045EC4C
		[DebuggerHidden]
		private IEnumerator Co_SetPowerValue(float newValue, float oldValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_SetPowerValueSingleSingle_hotfix != null)
			{
				return (IEnumerator)this.m_Co_SetPowerValueSingleSingle_hotfix.call(new object[]
				{
					this,
					newValue,
					oldValue
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroListUIController.<Co_SetPowerValue>c__Iterator0 <Co_SetPowerValue>c__Iterator = new HeroListUIController.<Co_SetPowerValue>c__Iterator0();
			<Co_SetPowerValue>c__Iterator.newValue = newValue;
			<Co_SetPowerValue>c__Iterator.oldValue = oldValue;
			<Co_SetPowerValue>c__Iterator.$this = this;
			return <Co_SetPowerValue>c__Iterator;
		}

		// Token: 0x06010E7F RID: 69247 RVA: 0x00460AF4 File Offset: 0x0045ECF4
		public void SetCurHeroList(List<Hero> unlockedList, List<Hero> lockedList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurHeroListList`1List`1_hotfix != null)
			{
				this.m_SetCurHeroListList`1List`1_hotfix.call(new object[]
				{
					this,
					unlockedList,
					lockedList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unLockedHeroList.Clear();
			this.m_unLockedHeroList.AddRange(unlockedList);
			this.m_lockedHeroList.Clear();
			this.m_lockedHeroList.AddRange(lockedList);
		}

		// Token: 0x06010E80 RID: 69248 RVA: 0x00460BA4 File Offset: 0x0045EDA4
		public void SetToInitState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToInitState_hotfix != null)
			{
				this.m_SetToInitState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState("StartState", false, true);
		}

		// Token: 0x06010E81 RID: 69249 RVA: 0x00460C20 File Offset: 0x0045EE20
		public void SetToAtLeftState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToAtLeftState_hotfix != null)
			{
				this.m_SetToAtLeftState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState("AtLeft", false, true);
		}

		// Token: 0x06010E82 RID: 69250 RVA: 0x00460C9C File Offset: 0x0045EE9C
		private void OnHeroItemClick(HeroItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroItemClickHeroItemUIController_hotfix != null)
			{
				this.m_OnHeroItemClickHeroItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_charSummonEffect.activeSelf)
			{
				return;
			}
			GameObject gameObject = goCtrl.gameObject;
			GameObject gameObject2 = gameObject.transform.parent.gameObject;
			if (gameObject2 == this.m_scrollViewUnlockedHeroContent)
			{
				int heroItemPosInList = this.GetHeroItemPosInList(gameObject, this.m_unLockedHeroCtrlList);
				if (this.m_curSelectedHeroIndex == heroItemPosInList && this.m_curSeletedHeroList == this.m_scrollViewUnlockedHeroContent)
				{
					return;
				}
				this.m_curSelectedHeroIndex = heroItemPosInList;
				this.m_curSeletedHeroList = this.m_scrollViewUnlockedHeroContent;
				this.m_isUnLockHero = true;
				if (this.EventOnUpdateViewInListAndDetail != null)
				{
					this.EventOnUpdateViewInListAndDetail(this.m_curSelectedHeroIndex, true, true, goCtrl.m_hero.HeroId);
				}
			}
			else if (gameObject2 == this.m_scrollViewLockedHeroContent)
			{
				int heroItemPosInList2 = this.GetHeroItemPosInList(gameObject, this.m_lockedHeroCtrlList);
				if (this.m_curSelectedHeroIndex == heroItemPosInList2 && this.m_curSeletedHeroList == this.m_scrollViewLockedHeroContent)
				{
					return;
				}
				this.m_curSelectedHeroIndex = heroItemPosInList2;
				this.m_curSeletedHeroList = this.m_scrollViewLockedHeroContent;
				this.m_isUnLockHero = false;
				if (this.EventOnUpdateViewInListAndDetail != null)
				{
					this.EventOnUpdateViewInListAndDetail(this.m_curSelectedHeroIndex, false, true, goCtrl.m_hero.HeroId);
				}
			}
		}

		// Token: 0x06010E83 RID: 69251 RVA: 0x00460E44 File Offset: 0x0045F044
		private void OnHeroFragmentSearchButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroFragmentSearchButtonClick_hotfix != null)
			{
				this.m_OnHeroFragmentSearchButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.GetCurHeroList()[this.m_curSelectedHeroIndex];
			if (this.EventOnShowGetPath != null)
			{
				this.EventOnShowGetPath(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID, this.m_curHeroNeedFragmentCount);
			}
		}

		// Token: 0x06010E84 RID: 69252 RVA: 0x00460EE0 File Offset: 0x0045F0E0
		private void OnBreakButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBreakButtonClick_hotfix != null)
			{
				this.m_OnBreakButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroId = this.GetCurHeroList()[this.m_curSelectedHeroIndex].HeroId;
			int num = this.m_playerContext.CanLevelUpHeroStarLevel(heroId);
			if (num == 0)
			{
				base.StartCoroutine(this.PlayBreakButtonClickEffect(heroId));
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06010E85 RID: 69253 RVA: 0x00460F90 File Offset: 0x0045F190
		[DebuggerHidden]
		private IEnumerator PlayBreakButtonClickEffect(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayBreakButtonClickEffectInt32_hotfix != null)
			{
				return (IEnumerator)this.m_PlayBreakButtonClickEffectInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroListUIController.<PlayBreakButtonClickEffect>c__Iterator1 <PlayBreakButtonClickEffect>c__Iterator = new HeroListUIController.<PlayBreakButtonClickEffect>c__Iterator1();
			<PlayBreakButtonClickEffect>c__Iterator.heroId = heroId;
			<PlayBreakButtonClickEffect>c__Iterator.$this = this;
			return <PlayBreakButtonClickEffect>c__Iterator;
		}

		// Token: 0x06010E86 RID: 69254 RVA: 0x00461024 File Offset: 0x0045F224
		private void ComposeLockedHero(Hero h)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComposeLockedHeroHero_hotfix != null)
			{
				this.m_ComposeLockedHeroHero_hotfix.call(new object[]
				{
					this,
					h
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_composeCostText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_ComposeHero), configDataLoader.GetConfigDataHeroStarInfo(h.StarLevel).Gold);
			this.m_composeConfirmPanel.SetActive(true);
			this.m_composeConfirmPanel.GetComponent<CommonUIStateController>().SetToUIState("Show", false, true);
		}

		// Token: 0x06010E87 RID: 69255 RVA: 0x004610F8 File Offset: 0x0045F2F8
		private void CloseComposeHeroPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseComposeHeroPanel_hotfix != null)
			{
				this.m_CloseComposeHeroPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_composeConfirmPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_composeConfirmPanel.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x06010E88 RID: 69256 RVA: 0x0046118C File Offset: 0x0045F38C
		private void ConfirmComposeHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ConfirmComposeHero_hotfix != null)
			{
				this.m_ConfirmComposeHero_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroId = this.m_lockedHeroList[this.m_curSelectedHeroIndex].HeroId;
			int num = this.m_playerContext.CanComposeHero(heroId);
			if (num == 0)
			{
				if (this.EventOnComposeHero != null)
				{
					this.EventOnComposeHero(heroId, new Action(this.OnComposeHeroSucceed));
				}
				this.m_curSeletedHeroList = this.m_scrollViewUnlockedHeroContent;
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06010E89 RID: 69257 RVA: 0x0046125C File Offset: 0x0045F45C
		private void OnComposeHeroSucceed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnComposeHeroSucceed_hotfix != null)
			{
				this.m_OnComposeHeroSucceed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseComposeHeroPanel();
			this.m_heroCharUIController.SetCanClick(true);
			base.StartCoroutine(this.PlayHeroGetEffect());
		}

		// Token: 0x06010E8A RID: 69258 RVA: 0x004612DC File Offset: 0x0045F4DC
		[DebuggerHidden]
		private IEnumerator PlayHeroGetEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayHeroGetEffect_hotfix != null)
			{
				return (IEnumerator)this.m_PlayHeroGetEffect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroListUIController.<PlayHeroGetEffect>c__Iterator2 <PlayHeroGetEffect>c__Iterator = new HeroListUIController.<PlayHeroGetEffect>c__Iterator2();
			<PlayHeroGetEffect>c__Iterator.$this = this;
			return <PlayHeroGetEffect>c__Iterator;
		}

		// Token: 0x06010E8B RID: 69259 RVA: 0x00461358 File Offset: 0x0045F558
		private void OnExtractionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExtractionButtonClick_hotfix != null)
			{
				this.m_OnExtractionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Hero hero = this.GetCurHeroList()[this.m_curSelectedHeroIndex];
			bool flag = UIUtility.GetGoodsCount(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID) > 0;
			if (flag)
			{
				if (this.EventOnGoToMemoryExtractionStore != null)
				{
					this.EventOnGoToMemoryExtractionStore();
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ExtractionFragmentNotEnough, 2f, null, true);
			}
		}

		// Token: 0x06010E8C RID: 69260 RVA: 0x00461418 File Offset: 0x0045F618
		private void OnEquipmentsButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentsButtonClick_hotfix != null)
			{
				this.m_OnEquipmentsButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Equipment))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_Equipment), 2f, null, true);
			}
			else
			{
				if (this.EventOnEquipment != null)
				{
					this.EventOnEquipment();
				}
				CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
				component.SetToUIState("ToLeft", false, true);
				this.InactiveCharWordPanel();
			}
		}

		// Token: 0x06010E8D RID: 69261 RVA: 0x004614DC File Offset: 0x0045F6DC
		private void OnHeroJobUpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroJobUpButtonClick_hotfix != null)
			{
				this.m_OnHeroJobUpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnJob != null)
			{
				this.EventOnJob();
			}
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState("ToLeft", false, true);
			this.InactiveCharWordPanel();
		}

		// Token: 0x06010E8E RID: 69262 RVA: 0x00461574 File Offset: 0x0045F774
		private void OnHeroCharSkinChangeButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroCharSkinChangeButton_hotfix != null)
			{
				this.m_OnHeroCharSkinChangeButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnHeroCharSkinChangeButtonClick != null)
			{
				this.EventOnHeroCharSkinChangeButtonClick();
			}
		}

		// Token: 0x06010E8F RID: 69263 RVA: 0x004615EC File Offset: 0x0045F7EC
		private void HeroCharUIController_OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroCharUIController_OnClick_hotfix != null)
			{
				this.m_HeroCharUIController_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnHeroCharClick != null)
			{
				this.EventOnHeroCharClick();
			}
		}

		// Token: 0x06010E90 RID: 69264 RVA: 0x00461664 File Offset: 0x0045F864
		public void ClickHeroByIdForUserGuide(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickHeroByIdForUserGuideInt32_hotfix != null)
			{
				this.m_ClickHeroByIdForUserGuideInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_unLockedHeroCtrlList.Count; i++)
			{
				HeroItemUIController heroItemUIController = this.m_unLockedHeroCtrlList[i];
				if (heroItemUIController.m_hero.HeroId == heroId)
				{
					this.OnHeroItemClick(heroItemUIController);
				}
			}
		}

		// Token: 0x06010E91 RID: 69265 RVA: 0x00461718 File Offset: 0x0045F918
		public void ClickLowLevelHeroForUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickLowLevelHeroForUserGuide_hotfix != null)
			{
				this.m_ClickLowLevelHeroForUserGuide_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unLockedHeroCtrlList != null && this.m_unLockedHeroCtrlList.Count > 0)
			{
				int index = 0;
				for (int i = 0; i < this.m_unLockedHeroCtrlList.Count; i++)
				{
					if (i + 1 < this.m_unLockedHeroCtrlList.Count)
					{
						if (this.m_unLockedHeroCtrlList[i].m_hero.Level <= this.m_unLockedHeroCtrlList[i + 1].m_hero.Level)
						{
							index = i;
						}
						else
						{
							index = i + 1;
						}
					}
				}
				this.OnHeroItemClick(this.m_unLockedHeroCtrlList[index]);
			}
		}

		// Token: 0x06010E92 RID: 69266 RVA: 0x00461818 File Offset: 0x0045FA18
		public bool ClickLockedHeroForUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickLockedHeroForUserGuide_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ClickLockedHeroForUserGuide_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_lockedHeroCtrlList != null && this.m_lockedHeroCtrlList.Count > 0)
			{
				for (int i = 0; i < this.m_lockedHeroCtrlList.Count; i++)
				{
					if (this.m_lockedHeroCtrlList[i].m_curHeroItemState == HeroItemUIController.HeroItemState.NotGetAndGlowing)
					{
						this.OnHeroItemClick(this.m_lockedHeroCtrlList[i]);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06010E93 RID: 69267 RVA: 0x004618E8 File Offset: 0x0045FAE8
		private int GetHeroItemPosInList(GameObject child, List<HeroItemUIController> parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroItemPosInListGameObjectList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroItemPosInListGameObjectList`1_hotfix.call(new object[]
				{
					this,
					child,
					parent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < parent.Count; i++)
			{
				if (parent[i].gameObject == child)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06010E94 RID: 69268 RVA: 0x004619A8 File Offset: 0x0045FBA8
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
			this.ResetHeroPowerValue();
			this.m_isUnLockHero = true;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06010E95 RID: 69269 RVA: 0x00461A2C File Offset: 0x0045FC2C
		private void SetSortTypeButtonAndToggles()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSortTypeButtonAndToggles_hotfix != null)
			{
				this.m_SetSortTypeButtonAndToggles_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroListUIController.HeroSortType heroListSortType = (HeroListUIController.HeroSortType)LocalConfig.Instance.Data.HeroListSortType;
			string stateName = string.Empty;
			switch (heroListSortType)
			{
			case HeroListUIController.HeroSortType.Level:
				stateName = "Level";
				break;
			case HeroListUIController.HeroSortType.StarLevel:
				stateName = "StarLevel";
				break;
			case HeroListUIController.HeroSortType.Rank:
				stateName = "Rank";
				break;
			case HeroListUIController.HeroSortType.Power:
				stateName = "Power";
				break;
			}
			this.m_sortButtonStateCtrl.SetToUIState(stateName, false, true);
		}

		// Token: 0x06010E96 RID: 69270 RVA: 0x00461AF8 File Offset: 0x0045FCF8
		private void ResetData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetData_hotfix != null)
			{
				this.m_ResetData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ResetScrollViewPosition();
		}

		// Token: 0x06010E97 RID: 69271 RVA: 0x00461B60 File Offset: 0x0045FD60
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
			this.ResetData();
		}

		// Token: 0x06010E98 RID: 69272 RVA: 0x00461BC8 File Offset: 0x0045FDC8
		private void OnFilterButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFilterButtonClick_hotfix != null)
			{
				this.m_OnFilterButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFilter != null)
			{
				this.EventOnFilter();
			}
		}

		// Token: 0x06010E99 RID: 69273 RVA: 0x00461C40 File Offset: 0x0045FE40
		private void ResetScrollViewPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewPosition_hotfix != null)
			{
				this.m_ResetScrollViewPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_scrollView.normalizedPosition = Vector2.one;
		}

		// Token: 0x06010E9A RID: 69274 RVA: 0x00461CB0 File Offset: 0x0045FEB0
		private void OnDetailButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDetailButtonClick_hotfix != null)
			{
				this.m_OnDetailButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDetail != null)
			{
				this.EventOnDetail();
			}
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState("ToLeft", false, true);
			this.InactiveCharWordPanel();
		}

		// Token: 0x06010E9B RID: 69275 RVA: 0x00461D48 File Offset: 0x0045FF48
		private void OnSummonButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSummonButtonClick_hotfix != null)
			{
				this.m_OnSummonButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.PlaySummonButtonClickEffect());
			HeroItemUIController heroItemUIController = this.m_lockedHeroCtrlList[this.m_curSelectedHeroIndex];
			if (heroItemUIController.m_curHeroItemState == HeroItemUIController.HeroItemState.NotGetAndGlowing)
			{
				this.ComposeLockedHero(heroItemUIController.m_hero);
			}
			else
			{
				this.OnHeroFragmentSearchButtonClick();
			}
		}

		// Token: 0x06010E9C RID: 69276 RVA: 0x00461DEC File Offset: 0x0045FFEC
		[DebuggerHidden]
		private IEnumerator PlaySummonButtonClickEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySummonButtonClickEffect_hotfix != null)
			{
				return (IEnumerator)this.m_PlaySummonButtonClickEffect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroListUIController.<PlaySummonButtonClickEffect>c__Iterator3 <PlaySummonButtonClickEffect>c__Iterator = new HeroListUIController.<PlaySummonButtonClickEffect>c__Iterator3();
			<PlaySummonButtonClickEffect>c__Iterator.$this = this;
			return <PlaySummonButtonClickEffect>c__Iterator;
		}

		// Token: 0x06010E9D RID: 69277 RVA: 0x00461E68 File Offset: 0x00460068
		public void ShowButtonGameObject(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowButtonGameObjectBoolean_hotfix != null)
			{
				this.m_ShowButtonGameObjectBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_breakButton.gameObject.SetActive(isShow);
			this.m_heroEquipmentsButton.gameObject.SetActive(isShow && this.m_isUnLockHero);
			Hero hero = this.GetCurHeroList()[this.m_curSelectedHeroIndex];
			int num = 0;
			foreach (int key in hero.HeroInfo.Skins_ID)
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(key);
				if (this.m_playerContext.IsShowSkinBeforeOnSale(configDataHeroSkinInfo.FixedStoreItemId, true))
				{
					num++;
				}
			}
			this.m_heroCharSkinChangeButton.gameObject.SetActive(!isShow && this.m_isUnLockHero && num > 0);
			bool flag = hero.StarLevel >= this.m_configDataLoader.ConfigableConstId_HeroStarLevelMax;
			bool flag2 = UIUtility.GetGoodsCount(GoodsType.GoodsType_Item, hero.HeroInfo.FragmentItem_ID) > 0;
			this.m_extractionButton.gameObject.SetActive(isShow && flag);
			if (flag && flag2 && !LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction)
			{
				UIUtility.SetUIStateOpen(this.m_extractionTipsStateCtrl, "Show", null, false, true);
			}
			else
			{
				this.m_extractionTipsStateCtrl.gameObject.SetActive(false);
			}
		}

		// Token: 0x06010E9E RID: 69278 RVA: 0x00462054 File Offset: 0x00460254
		private void OnCommentButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCommentButtonClick_hotfix != null)
			{
				this.m_OnCommentButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_breakButton.gameObject.SetActive(false);
			if (this.EventOnComment != null)
			{
				this.EventOnComment();
			}
		}

		// Token: 0x06010E9F RID: 69279 RVA: 0x004620DC File Offset: 0x004602DC
		private void OnAddHeroButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddHeroButtonClick_hotfix != null)
			{
				this.m_OnAddHeroButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddHero != null)
			{
				this.EventOnAddHero(this.m_heroIdInputField.text);
			}
		}

		// Token: 0x06010EA0 RID: 69280 RVA: 0x00462160 File Offset: 0x00460360
		private void OnSpeedUpHeroButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSpeedUpHeroButtonClick_hotfix != null)
			{
				this.m_OnSpeedUpHeroButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			if (clientConfigDataLoader == null)
			{
				return;
			}
			base.StartCoroutine(TestUIController.SpeedUpHero(this.GetCurHeroList()[this.m_curSelectedHeroIndex].HeroId, TestUIController.MaxPlayerLevel, clientConfigDataLoader.ConfigableConstId_HeroStarLevelMax));
		}

		// Token: 0x06010EA1 RID: 69281 RVA: 0x00462204 File Offset: 0x00460404
		private void OnResetHeroButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResetHeroButtonClick_hotfix != null)
			{
				this.m_OnResetHeroButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(TestUIController.ResetHero(this.GetCurHeroList()[this.m_curSelectedHeroIndex].HeroId));
		}

		// Token: 0x06010EA2 RID: 69282 RVA: 0x00462288 File Offset: 0x00460488
		public void ResetPanelPos()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetPanelPos_hotfix != null)
			{
				this.m_ResetPanelPos_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			component.SetToUIState("ToRight", false, true);
			this.InactiveCharWordPanel();
		}

		// Token: 0x06010EA3 RID: 69283 RVA: 0x00462308 File Offset: 0x00460508
		public void InactiveCharWordPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InactiveCharWordPanel_hotfix != null)
			{
				this.m_InactiveCharWordPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_charWordGameObject.SetActive(false);
		}

		// Token: 0x06010EA4 RID: 69284 RVA: 0x00462374 File Offset: 0x00460574
		public List<Hero> GetCurHeroList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurHeroList_hotfix != null)
			{
				return (List<Hero>)this.m_GetCurHeroList_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isUnLockHero)
			{
				return this.m_unLockedHeroList;
			}
			return this.m_lockedHeroList;
		}

		// Token: 0x06010EA5 RID: 69285 RVA: 0x004623F8 File Offset: 0x004605F8
		public bool HaveHeroCanCompose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HaveHeroCanCompose_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HaveHeroCanCompose_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (HeroItemUIController heroItemUIController in this.m_lockedHeroCtrlList)
			{
				if (heroItemUIController.m_curHeroItemState == HeroItemUIController.HeroItemState.NotGetAndGlowing)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06010EA6 RID: 69286 RVA: 0x004624C4 File Offset: 0x004606C4
		public void PlayHeroPerformance(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayHeroPerformanceInt32_hotfix != null)
			{
				this.m_PlayHeroPerformanceInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroCharUIController.PlayOneSpecifiedPerformance(heroPerformanceId);
		}

		// Token: 0x06010EA7 RID: 69287 RVA: 0x00462544 File Offset: 0x00460744
		private void OnLevelToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnLevelToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.EventOnSortToggleClick != null)
				{
					this.EventOnSortToggleClick(HeroListUIController.HeroSortType.Level);
				}
				this.m_sortButtonStateCtrl.SetToUIState("Level", false, true);
				this.CloseSortTypesPanel();
			}
		}

		// Token: 0x06010EA8 RID: 69288 RVA: 0x004625EC File Offset: 0x004607EC
		private void OnStarLevelToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStarLevelToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnStarLevelToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.EventOnSortToggleClick != null)
				{
					this.EventOnSortToggleClick(HeroListUIController.HeroSortType.StarLevel);
				}
				this.m_sortButtonStateCtrl.SetToUIState("StarLevel", false, true);
				this.CloseSortTypesPanel();
			}
		}

		// Token: 0x06010EA9 RID: 69289 RVA: 0x00462694 File Offset: 0x00460894
		private void OnRankToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRankToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.EventOnSortToggleClick != null)
				{
					this.EventOnSortToggleClick(HeroListUIController.HeroSortType.Rank);
				}
				this.m_sortButtonStateCtrl.SetToUIState("Rank", false, true);
				this.CloseSortTypesPanel();
			}
		}

		// Token: 0x06010EAA RID: 69290 RVA: 0x0046273C File Offset: 0x0046093C
		private void OnPowerToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPowerToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnPowerToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				if (this.EventOnSortToggleClick != null)
				{
					this.EventOnSortToggleClick(HeroListUIController.HeroSortType.Power);
				}
				this.m_sortButtonStateCtrl.SetToUIState("Power", false, true);
				this.CloseSortTypesPanel();
			}
		}

		// Token: 0x06010EAB RID: 69291 RVA: 0x004627E4 File Offset: 0x004609E4
		private void OnSortButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSortButtonClick_hotfix != null)
			{
				this.m_OnSortButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sortTypesPanelStateCtrl.gameObject.SetActive(true);
			HeroListUIController.HeroSortType heroListSortType = (HeroListUIController.HeroSortType)LocalConfig.Instance.Data.HeroListSortType;
			this.m_sortTypesLevelToggle.isOn = (heroListSortType == HeroListUIController.HeroSortType.Level);
			this.m_sortTypesStarToggle.isOn = (heroListSortType == HeroListUIController.HeroSortType.StarLevel);
			this.m_sortTypesRarityToggle.isOn = (heroListSortType == HeroListUIController.HeroSortType.Rank);
			this.m_sortTypesPowerToggle.isOn = (heroListSortType == HeroListUIController.HeroSortType.Power);
			this.m_sortTypesPanelStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x06010EAC RID: 69292 RVA: 0x004628B4 File Offset: 0x00460AB4
		private void CloseSortTypesPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSortTypesPanel_hotfix != null)
			{
				this.m_CloseSortTypesPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_sortTypesPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_sortTypesPanelStateCtrl.gameObject.SetActive(false);
			});
			this.m_sortTypesPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x14000394 RID: 916
		// (add) Token: 0x06010EAD RID: 69293 RVA: 0x00462944 File Offset: 0x00460B44
		// (remove) Token: 0x06010EAE RID: 69294 RVA: 0x004629E0 File Offset: 0x00460BE0
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

		// Token: 0x14000395 RID: 917
		// (add) Token: 0x06010EAF RID: 69295 RVA: 0x00462A7C File Offset: 0x00460C7C
		// (remove) Token: 0x06010EB0 RID: 69296 RVA: 0x00462B18 File Offset: 0x00460D18
		public event Action EventOnFilter
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFilterAction_hotfix != null)
				{
					this.m_add_EventOnFilterAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnFilter;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnFilter, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFilterAction_hotfix != null)
				{
					this.m_remove_EventOnFilterAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnFilter;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnFilter, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000396 RID: 918
		// (add) Token: 0x06010EB1 RID: 69297 RVA: 0x00462BB4 File Offset: 0x00460DB4
		// (remove) Token: 0x06010EB2 RID: 69298 RVA: 0x00462C50 File Offset: 0x00460E50
		public event Action EventOnDetail
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDetailAction_hotfix != null)
				{
					this.m_add_EventOnDetailAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnDetail;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnDetail, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDetailAction_hotfix != null)
				{
					this.m_remove_EventOnDetailAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnDetail;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnDetail, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000397 RID: 919
		// (add) Token: 0x06010EB3 RID: 69299 RVA: 0x00462CEC File Offset: 0x00460EEC
		// (remove) Token: 0x06010EB4 RID: 69300 RVA: 0x00462D88 File Offset: 0x00460F88
		public event Action EventOnComment
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCommentAction_hotfix != null)
				{
					this.m_add_EventOnCommentAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnComment;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnComment, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCommentAction_hotfix != null)
				{
					this.m_remove_EventOnCommentAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnComment;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnComment, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000398 RID: 920
		// (add) Token: 0x06010EB5 RID: 69301 RVA: 0x00462E24 File Offset: 0x00461024
		// (remove) Token: 0x06010EB6 RID: 69302 RVA: 0x00462EC0 File Offset: 0x004610C0
		public event Action EventOnEquipment
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEquipmentAction_hotfix != null)
				{
					this.m_add_EventOnEquipmentAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEquipment;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEquipment, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEquipmentAction_hotfix != null)
				{
					this.m_remove_EventOnEquipmentAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEquipment;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEquipment, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000399 RID: 921
		// (add) Token: 0x06010EB7 RID: 69303 RVA: 0x00462F5C File Offset: 0x0046115C
		// (remove) Token: 0x06010EB8 RID: 69304 RVA: 0x00462FF8 File Offset: 0x004611F8
		public event Action EventOnJob
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJobAction_hotfix != null)
				{
					this.m_add_EventOnJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnJob, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJobAction_hotfix != null)
				{
					this.m_remove_EventOnJobAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnJob;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnJob, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400039A RID: 922
		// (add) Token: 0x06010EB9 RID: 69305 RVA: 0x00463094 File Offset: 0x00461294
		// (remove) Token: 0x06010EBA RID: 69306 RVA: 0x00463130 File Offset: 0x00461330
		public event Action EventOnHeroCharClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroCharClickAction_hotfix != null)
				{
					this.m_add_EventOnHeroCharClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHeroCharClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHeroCharClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroCharClickAction_hotfix != null)
				{
					this.m_remove_EventOnHeroCharClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHeroCharClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHeroCharClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400039B RID: 923
		// (add) Token: 0x06010EBB RID: 69307 RVA: 0x004631CC File Offset: 0x004613CC
		// (remove) Token: 0x06010EBC RID: 69308 RVA: 0x00463268 File Offset: 0x00461468
		public event Action<int> EventOnHeroBreak
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroBreakAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroBreakAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroBreak;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroBreak, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroBreakAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroBreakAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroBreak;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroBreak, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400039C RID: 924
		// (add) Token: 0x06010EBD RID: 69309 RVA: 0x00463304 File Offset: 0x00461504
		// (remove) Token: 0x06010EBE RID: 69310 RVA: 0x004633A0 File Offset: 0x004615A0
		public event Action<string> EventOnAddHero
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddHeroAction`1_hotfix != null)
				{
					this.m_add_EventOnAddHeroAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddHero;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddHero, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddHeroAction`1_hotfix != null)
				{
					this.m_remove_EventOnAddHeroAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnAddHero;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnAddHero, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400039D RID: 925
		// (add) Token: 0x06010EBF RID: 69311 RVA: 0x0046343C File Offset: 0x0046163C
		// (remove) Token: 0x06010EC0 RID: 69312 RVA: 0x004634D8 File Offset: 0x004616D8
		public event Action<int, Action> EventOnComposeHero
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnComposeHeroAction`2_hotfix != null)
				{
					this.m_add_EventOnComposeHeroAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnComposeHero;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnComposeHero, (Action<int, Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnComposeHeroAction`2_hotfix != null)
				{
					this.m_remove_EventOnComposeHeroAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, Action> action = this.EventOnComposeHero;
				Action<int, Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, Action>>(ref this.EventOnComposeHero, (Action<int, Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400039E RID: 926
		// (add) Token: 0x06010EC1 RID: 69313 RVA: 0x00463574 File Offset: 0x00461774
		// (remove) Token: 0x06010EC2 RID: 69314 RVA: 0x00463610 File Offset: 0x00461810
		public event Action<HeroListUIController.HeroSortType> EventOnSortToggleClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSortToggleClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSortToggleClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroListUIController.HeroSortType> action = this.EventOnSortToggleClick;
				Action<HeroListUIController.HeroSortType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroListUIController.HeroSortType>>(ref this.EventOnSortToggleClick, (Action<HeroListUIController.HeroSortType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSortToggleClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSortToggleClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroListUIController.HeroSortType> action = this.EventOnSortToggleClick;
				Action<HeroListUIController.HeroSortType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroListUIController.HeroSortType>>(ref this.EventOnSortToggleClick, (Action<HeroListUIController.HeroSortType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400039F RID: 927
		// (add) Token: 0x06010EC3 RID: 69315 RVA: 0x004636AC File Offset: 0x004618AC
		// (remove) Token: 0x06010EC4 RID: 69316 RVA: 0x00463748 File Offset: 0x00461948
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

		// Token: 0x140003A0 RID: 928
		// (add) Token: 0x06010EC5 RID: 69317 RVA: 0x004637E4 File Offset: 0x004619E4
		// (remove) Token: 0x06010EC6 RID: 69318 RVA: 0x00463880 File Offset: 0x00461A80
		public event Action<List<Hero>, List<Hero>> EventOnInitHeroList
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnInitHeroListAction`2_hotfix != null)
				{
					this.m_add_EventOnInitHeroListAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<Hero>, List<Hero>> action = this.EventOnInitHeroList;
				Action<List<Hero>, List<Hero>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<Hero>, List<Hero>>>(ref this.EventOnInitHeroList, (Action<List<Hero>, List<Hero>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnInitHeroListAction`2_hotfix != null)
				{
					this.m_remove_EventOnInitHeroListAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<List<Hero>, List<Hero>> action = this.EventOnInitHeroList;
				Action<List<Hero>, List<Hero>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<List<Hero>, List<Hero>>>(ref this.EventOnInitHeroList, (Action<List<Hero>, List<Hero>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003A1 RID: 929
		// (add) Token: 0x06010EC7 RID: 69319 RVA: 0x0046391C File Offset: 0x00461B1C
		// (remove) Token: 0x06010EC8 RID: 69320 RVA: 0x004639B8 File Offset: 0x00461BB8
		public event Action<int, bool, bool, int> EventOnUpdateViewInListAndDetail
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUpdateViewInListAndDetailAction`4_hotfix != null)
				{
					this.m_add_EventOnUpdateViewInListAndDetailAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool, bool, int> action = this.EventOnUpdateViewInListAndDetail;
				Action<int, bool, bool, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool, bool, int>>(ref this.EventOnUpdateViewInListAndDetail, (Action<int, bool, bool, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUpdateViewInListAndDetailAction`4_hotfix != null)
				{
					this.m_remove_EventOnUpdateViewInListAndDetailAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool, bool, int> action = this.EventOnUpdateViewInListAndDetail;
				Action<int, bool, bool, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool, bool, int>>(ref this.EventOnUpdateViewInListAndDetail, (Action<int, bool, bool, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003A2 RID: 930
		// (add) Token: 0x06010EC9 RID: 69321 RVA: 0x00463A54 File Offset: 0x00461C54
		// (remove) Token: 0x06010ECA RID: 69322 RVA: 0x00463AF0 File Offset: 0x00461CF0
		public event Action EventOnHeroCharSkinChangeButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroCharSkinChangeButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnHeroCharSkinChangeButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHeroCharSkinChangeButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHeroCharSkinChangeButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroCharSkinChangeButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnHeroCharSkinChangeButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnHeroCharSkinChangeButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnHeroCharSkinChangeButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003A3 RID: 931
		// (add) Token: 0x06010ECB RID: 69323 RVA: 0x00463B8C File Offset: 0x00461D8C
		// (remove) Token: 0x06010ECC RID: 69324 RVA: 0x00463C28 File Offset: 0x00461E28
		public event Action EventOnGoToMemoryExtractionStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoToMemoryExtractionStoreAction_hotfix != null)
				{
					this.m_add_EventOnGoToMemoryExtractionStoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoToMemoryExtractionStore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoToMemoryExtractionStore, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoToMemoryExtractionStoreAction_hotfix != null)
				{
					this.m_remove_EventOnGoToMemoryExtractionStoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoToMemoryExtractionStore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoToMemoryExtractionStore, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x06010ECD RID: 69325 RVA: 0x00463CC4 File Offset: 0x00461EC4
		// (set) Token: 0x06010ECE RID: 69326 RVA: 0x00463CE4 File Offset: 0x00461EE4
		[DoNotToLua]
		public new HeroListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010ECF RID: 69327 RVA: 0x00463CF0 File Offset: 0x00461EF0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010ED0 RID: 69328 RVA: 0x00463CFC File Offset: 0x00461EFC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010ED1 RID: 69329 RVA: 0x00463D04 File Offset: 0x00461F04
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010ED2 RID: 69330 RVA: 0x00463D0C File Offset: 0x00461F0C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010ED3 RID: 69331 RVA: 0x00463D20 File Offset: 0x00461F20
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010ED4 RID: 69332 RVA: 0x00463D28 File Offset: 0x00461F28
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010ED5 RID: 69333 RVA: 0x00463D34 File Offset: 0x00461F34
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010ED6 RID: 69334 RVA: 0x00463D40 File Offset: 0x00461F40
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010ED7 RID: 69335 RVA: 0x00463D4C File Offset: 0x00461F4C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010ED8 RID: 69336 RVA: 0x00463D58 File Offset: 0x00461F58
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010ED9 RID: 69337 RVA: 0x00463D64 File Offset: 0x00461F64
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010EDA RID: 69338 RVA: 0x00463D70 File Offset: 0x00461F70
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010EDB RID: 69339 RVA: 0x00463D7C File Offset: 0x00461F7C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010EDC RID: 69340 RVA: 0x00463D88 File Offset: 0x00461F88
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010EDD RID: 69341 RVA: 0x00463D94 File Offset: 0x00461F94
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010EDE RID: 69342 RVA: 0x00463D9C File Offset: 0x00461F9C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06010EDF RID: 69343 RVA: 0x00463DBC File Offset: 0x00461FBC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06010EE0 RID: 69344 RVA: 0x00463DC8 File Offset: 0x00461FC8
		private void __callDele_EventOnFilter()
		{
			Action eventOnFilter = this.EventOnFilter;
			if (eventOnFilter != null)
			{
				eventOnFilter();
			}
		}

		// Token: 0x06010EE1 RID: 69345 RVA: 0x00463DE8 File Offset: 0x00461FE8
		private void __clearDele_EventOnFilter()
		{
			this.EventOnFilter = null;
		}

		// Token: 0x06010EE2 RID: 69346 RVA: 0x00463DF4 File Offset: 0x00461FF4
		private void __callDele_EventOnDetail()
		{
			Action eventOnDetail = this.EventOnDetail;
			if (eventOnDetail != null)
			{
				eventOnDetail();
			}
		}

		// Token: 0x06010EE3 RID: 69347 RVA: 0x00463E14 File Offset: 0x00462014
		private void __clearDele_EventOnDetail()
		{
			this.EventOnDetail = null;
		}

		// Token: 0x06010EE4 RID: 69348 RVA: 0x00463E20 File Offset: 0x00462020
		private void __callDele_EventOnComment()
		{
			Action eventOnComment = this.EventOnComment;
			if (eventOnComment != null)
			{
				eventOnComment();
			}
		}

		// Token: 0x06010EE5 RID: 69349 RVA: 0x00463E40 File Offset: 0x00462040
		private void __clearDele_EventOnComment()
		{
			this.EventOnComment = null;
		}

		// Token: 0x06010EE6 RID: 69350 RVA: 0x00463E4C File Offset: 0x0046204C
		private void __callDele_EventOnEquipment()
		{
			Action eventOnEquipment = this.EventOnEquipment;
			if (eventOnEquipment != null)
			{
				eventOnEquipment();
			}
		}

		// Token: 0x06010EE7 RID: 69351 RVA: 0x00463E6C File Offset: 0x0046206C
		private void __clearDele_EventOnEquipment()
		{
			this.EventOnEquipment = null;
		}

		// Token: 0x06010EE8 RID: 69352 RVA: 0x00463E78 File Offset: 0x00462078
		private void __callDele_EventOnJob()
		{
			Action eventOnJob = this.EventOnJob;
			if (eventOnJob != null)
			{
				eventOnJob();
			}
		}

		// Token: 0x06010EE9 RID: 69353 RVA: 0x00463E98 File Offset: 0x00462098
		private void __clearDele_EventOnJob()
		{
			this.EventOnJob = null;
		}

		// Token: 0x06010EEA RID: 69354 RVA: 0x00463EA4 File Offset: 0x004620A4
		private void __callDele_EventOnHeroCharClick()
		{
			Action eventOnHeroCharClick = this.EventOnHeroCharClick;
			if (eventOnHeroCharClick != null)
			{
				eventOnHeroCharClick();
			}
		}

		// Token: 0x06010EEB RID: 69355 RVA: 0x00463EC4 File Offset: 0x004620C4
		private void __clearDele_EventOnHeroCharClick()
		{
			this.EventOnHeroCharClick = null;
		}

		// Token: 0x06010EEC RID: 69356 RVA: 0x00463ED0 File Offset: 0x004620D0
		private void __callDele_EventOnHeroBreak(int obj)
		{
			Action<int> eventOnHeroBreak = this.EventOnHeroBreak;
			if (eventOnHeroBreak != null)
			{
				eventOnHeroBreak(obj);
			}
		}

		// Token: 0x06010EED RID: 69357 RVA: 0x00463EF4 File Offset: 0x004620F4
		private void __clearDele_EventOnHeroBreak(int obj)
		{
			this.EventOnHeroBreak = null;
		}

		// Token: 0x06010EEE RID: 69358 RVA: 0x00463F00 File Offset: 0x00462100
		private void __callDele_EventOnAddHero(string obj)
		{
			Action<string> eventOnAddHero = this.EventOnAddHero;
			if (eventOnAddHero != null)
			{
				eventOnAddHero(obj);
			}
		}

		// Token: 0x06010EEF RID: 69359 RVA: 0x00463F24 File Offset: 0x00462124
		private void __clearDele_EventOnAddHero(string obj)
		{
			this.EventOnAddHero = null;
		}

		// Token: 0x06010EF0 RID: 69360 RVA: 0x00463F30 File Offset: 0x00462130
		private void __callDele_EventOnComposeHero(int arg1, Action arg2)
		{
			Action<int, Action> eventOnComposeHero = this.EventOnComposeHero;
			if (eventOnComposeHero != null)
			{
				eventOnComposeHero(arg1, arg2);
			}
		}

		// Token: 0x06010EF1 RID: 69361 RVA: 0x00463F54 File Offset: 0x00462154
		private void __clearDele_EventOnComposeHero(int arg1, Action arg2)
		{
			this.EventOnComposeHero = null;
		}

		// Token: 0x06010EF2 RID: 69362 RVA: 0x00463F60 File Offset: 0x00462160
		private void __callDele_EventOnSortToggleClick(HeroListUIController.HeroSortType obj)
		{
			Action<HeroListUIController.HeroSortType> eventOnSortToggleClick = this.EventOnSortToggleClick;
			if (eventOnSortToggleClick != null)
			{
				eventOnSortToggleClick(obj);
			}
		}

		// Token: 0x06010EF3 RID: 69363 RVA: 0x00463F84 File Offset: 0x00462184
		private void __clearDele_EventOnSortToggleClick(HeroListUIController.HeroSortType obj)
		{
			this.EventOnSortToggleClick = null;
		}

		// Token: 0x06010EF4 RID: 69364 RVA: 0x00463F90 File Offset: 0x00462190
		private void __callDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnShowGetPath = this.EventOnShowGetPath;
			if (eventOnShowGetPath != null)
			{
				eventOnShowGetPath(arg1, arg2, arg3);
			}
		}

		// Token: 0x06010EF5 RID: 69365 RVA: 0x00463FB4 File Offset: 0x004621B4
		private void __clearDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnShowGetPath = null;
		}

		// Token: 0x06010EF6 RID: 69366 RVA: 0x00463FC0 File Offset: 0x004621C0
		private void __callDele_EventOnInitHeroList(List<Hero> arg1, List<Hero> arg2)
		{
			Action<List<Hero>, List<Hero>> eventOnInitHeroList = this.EventOnInitHeroList;
			if (eventOnInitHeroList != null)
			{
				eventOnInitHeroList(arg1, arg2);
			}
		}

		// Token: 0x06010EF7 RID: 69367 RVA: 0x00463FE4 File Offset: 0x004621E4
		private void __clearDele_EventOnInitHeroList(List<Hero> arg1, List<Hero> arg2)
		{
			this.EventOnInitHeroList = null;
		}

		// Token: 0x06010EF8 RID: 69368 RVA: 0x00463FF0 File Offset: 0x004621F0
		private void __callDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
		{
			Action<int, bool, bool, int> eventOnUpdateViewInListAndDetail = this.EventOnUpdateViewInListAndDetail;
			if (eventOnUpdateViewInListAndDetail != null)
			{
				eventOnUpdateViewInListAndDetail(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x06010EF9 RID: 69369 RVA: 0x00464018 File Offset: 0x00462218
		private void __clearDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
		{
			this.EventOnUpdateViewInListAndDetail = null;
		}

		// Token: 0x06010EFA RID: 69370 RVA: 0x00464024 File Offset: 0x00462224
		private void __callDele_EventOnHeroCharSkinChangeButtonClick()
		{
			Action eventOnHeroCharSkinChangeButtonClick = this.EventOnHeroCharSkinChangeButtonClick;
			if (eventOnHeroCharSkinChangeButtonClick != null)
			{
				eventOnHeroCharSkinChangeButtonClick();
			}
		}

		// Token: 0x06010EFB RID: 69371 RVA: 0x00464044 File Offset: 0x00462244
		private void __clearDele_EventOnHeroCharSkinChangeButtonClick()
		{
			this.EventOnHeroCharSkinChangeButtonClick = null;
		}

		// Token: 0x06010EFC RID: 69372 RVA: 0x00464050 File Offset: 0x00462250
		private void __callDele_EventOnGoToMemoryExtractionStore()
		{
			Action eventOnGoToMemoryExtractionStore = this.EventOnGoToMemoryExtractionStore;
			if (eventOnGoToMemoryExtractionStore != null)
			{
				eventOnGoToMemoryExtractionStore();
			}
		}

		// Token: 0x06010EFD RID: 69373 RVA: 0x00464070 File Offset: 0x00462270
		private void __clearDele_EventOnGoToMemoryExtractionStore()
		{
			this.EventOnGoToMemoryExtractionStore = null;
		}

		// Token: 0x06010F00 RID: 69376 RVA: 0x004640A0 File Offset: 0x004622A0
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
					this.m_UpdateViewInHeroListBoolean_hotfix = (luaObj.RawGet("UpdateViewInHeroList") as LuaFunction);
					this.m_CreateHeroList_hotfix = (luaObj.RawGet("CreateHeroList") as LuaFunction);
					this.m_SetHeroPowerValue_hotfix = (luaObj.RawGet("SetHeroPowerValue") as LuaFunction);
					this.m_ResetHeroPowerValue_hotfix = (luaObj.RawGet("ResetHeroPowerValue") as LuaFunction);
					this.m_StopAllCoroutineInHeroList_hotfix = (luaObj.RawGet("StopAllCoroutineInHeroList") as LuaFunction);
					this.m_SetHeroCharSkinPreviewStringInt32_hotfix = (luaObj.RawGet("SetHeroCharSkinPreview") as LuaFunction);
					this.m_Co_SetPowerValueSingleSingle_hotfix = (luaObj.RawGet("Co_SetPowerValue") as LuaFunction);
					this.m_SetCurHeroListList`1List`1_hotfix = (luaObj.RawGet("SetCurHeroList") as LuaFunction);
					this.m_SetToInitState_hotfix = (luaObj.RawGet("SetToInitState") as LuaFunction);
					this.m_SetToAtLeftState_hotfix = (luaObj.RawGet("SetToAtLeftState") as LuaFunction);
					this.m_OnHeroItemClickHeroItemUIController_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_OnHeroFragmentSearchButtonClick_hotfix = (luaObj.RawGet("OnHeroFragmentSearchButtonClick") as LuaFunction);
					this.m_OnBreakButtonClick_hotfix = (luaObj.RawGet("OnBreakButtonClick") as LuaFunction);
					this.m_PlayBreakButtonClickEffectInt32_hotfix = (luaObj.RawGet("PlayBreakButtonClickEffect") as LuaFunction);
					this.m_ComposeLockedHeroHero_hotfix = (luaObj.RawGet("ComposeLockedHero") as LuaFunction);
					this.m_CloseComposeHeroPanel_hotfix = (luaObj.RawGet("CloseComposeHeroPanel") as LuaFunction);
					this.m_ConfirmComposeHero_hotfix = (luaObj.RawGet("ConfirmComposeHero") as LuaFunction);
					this.m_OnComposeHeroSucceed_hotfix = (luaObj.RawGet("OnComposeHeroSucceed") as LuaFunction);
					this.m_PlayHeroGetEffect_hotfix = (luaObj.RawGet("PlayHeroGetEffect") as LuaFunction);
					this.m_OnExtractionButtonClick_hotfix = (luaObj.RawGet("OnExtractionButtonClick") as LuaFunction);
					this.m_OnEquipmentsButtonClick_hotfix = (luaObj.RawGet("OnEquipmentsButtonClick") as LuaFunction);
					this.m_OnHeroJobUpButtonClick_hotfix = (luaObj.RawGet("OnHeroJobUpButtonClick") as LuaFunction);
					this.m_OnHeroCharSkinChangeButton_hotfix = (luaObj.RawGet("OnHeroCharSkinChangeButton") as LuaFunction);
					this.m_HeroCharUIController_OnClick_hotfix = (luaObj.RawGet("HeroCharUIController_OnClick") as LuaFunction);
					this.m_ClickHeroByIdForUserGuideInt32_hotfix = (luaObj.RawGet("ClickHeroByIdForUserGuide") as LuaFunction);
					this.m_ClickLowLevelHeroForUserGuide_hotfix = (luaObj.RawGet("ClickLowLevelHeroForUserGuide") as LuaFunction);
					this.m_ClickLockedHeroForUserGuide_hotfix = (luaObj.RawGet("ClickLockedHeroForUserGuide") as LuaFunction);
					this.m_GetHeroItemPosInListGameObjectList`1_hotfix = (luaObj.RawGet("GetHeroItemPosInList") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_SetSortTypeButtonAndToggles_hotfix = (luaObj.RawGet("SetSortTypeButtonAndToggles") as LuaFunction);
					this.m_ResetData_hotfix = (luaObj.RawGet("ResetData") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_OnFilterButtonClick_hotfix = (luaObj.RawGet("OnFilterButtonClick") as LuaFunction);
					this.m_ResetScrollViewPosition_hotfix = (luaObj.RawGet("ResetScrollViewPosition") as LuaFunction);
					this.m_OnDetailButtonClick_hotfix = (luaObj.RawGet("OnDetailButtonClick") as LuaFunction);
					this.m_OnSummonButtonClick_hotfix = (luaObj.RawGet("OnSummonButtonClick") as LuaFunction);
					this.m_PlaySummonButtonClickEffect_hotfix = (luaObj.RawGet("PlaySummonButtonClickEffect") as LuaFunction);
					this.m_ShowButtonGameObjectBoolean_hotfix = (luaObj.RawGet("ShowButtonGameObject") as LuaFunction);
					this.m_OnCommentButtonClick_hotfix = (luaObj.RawGet("OnCommentButtonClick") as LuaFunction);
					this.m_OnAddHeroButtonClick_hotfix = (luaObj.RawGet("OnAddHeroButtonClick") as LuaFunction);
					this.m_OnSpeedUpHeroButtonClick_hotfix = (luaObj.RawGet("OnSpeedUpHeroButtonClick") as LuaFunction);
					this.m_OnResetHeroButtonClick_hotfix = (luaObj.RawGet("OnResetHeroButtonClick") as LuaFunction);
					this.m_ResetPanelPos_hotfix = (luaObj.RawGet("ResetPanelPos") as LuaFunction);
					this.m_InactiveCharWordPanel_hotfix = (luaObj.RawGet("InactiveCharWordPanel") as LuaFunction);
					this.m_GetCurHeroList_hotfix = (luaObj.RawGet("GetCurHeroList") as LuaFunction);
					this.m_HaveHeroCanCompose_hotfix = (luaObj.RawGet("HaveHeroCanCompose") as LuaFunction);
					this.m_PlayHeroPerformanceInt32_hotfix = (luaObj.RawGet("PlayHeroPerformance") as LuaFunction);
					this.m_OnLevelToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnLevelToggleValueChanged") as LuaFunction);
					this.m_OnStarLevelToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnStarLevelToggleValueChanged") as LuaFunction);
					this.m_OnRankToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRankToggleValueChanged") as LuaFunction);
					this.m_OnPowerToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnPowerToggleValueChanged") as LuaFunction);
					this.m_OnSortButtonClick_hotfix = (luaObj.RawGet("OnSortButtonClick") as LuaFunction);
					this.m_CloseSortTypesPanel_hotfix = (luaObj.RawGet("CloseSortTypesPanel") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnFilterAction_hotfix = (luaObj.RawGet("add_EventOnFilter") as LuaFunction);
					this.m_remove_EventOnFilterAction_hotfix = (luaObj.RawGet("remove_EventOnFilter") as LuaFunction);
					this.m_add_EventOnDetailAction_hotfix = (luaObj.RawGet("add_EventOnDetail") as LuaFunction);
					this.m_remove_EventOnDetailAction_hotfix = (luaObj.RawGet("remove_EventOnDetail") as LuaFunction);
					this.m_add_EventOnCommentAction_hotfix = (luaObj.RawGet("add_EventOnComment") as LuaFunction);
					this.m_remove_EventOnCommentAction_hotfix = (luaObj.RawGet("remove_EventOnComment") as LuaFunction);
					this.m_add_EventOnEquipmentAction_hotfix = (luaObj.RawGet("add_EventOnEquipment") as LuaFunction);
					this.m_remove_EventOnEquipmentAction_hotfix = (luaObj.RawGet("remove_EventOnEquipment") as LuaFunction);
					this.m_add_EventOnJobAction_hotfix = (luaObj.RawGet("add_EventOnJob") as LuaFunction);
					this.m_remove_EventOnJobAction_hotfix = (luaObj.RawGet("remove_EventOnJob") as LuaFunction);
					this.m_add_EventOnHeroCharClickAction_hotfix = (luaObj.RawGet("add_EventOnHeroCharClick") as LuaFunction);
					this.m_remove_EventOnHeroCharClickAction_hotfix = (luaObj.RawGet("remove_EventOnHeroCharClick") as LuaFunction);
					this.m_add_EventOnHeroBreakAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroBreak") as LuaFunction);
					this.m_remove_EventOnHeroBreakAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroBreak") as LuaFunction);
					this.m_add_EventOnAddHeroAction`1_hotfix = (luaObj.RawGet("add_EventOnAddHero") as LuaFunction);
					this.m_remove_EventOnAddHeroAction`1_hotfix = (luaObj.RawGet("remove_EventOnAddHero") as LuaFunction);
					this.m_add_EventOnComposeHeroAction`2_hotfix = (luaObj.RawGet("add_EventOnComposeHero") as LuaFunction);
					this.m_remove_EventOnComposeHeroAction`2_hotfix = (luaObj.RawGet("remove_EventOnComposeHero") as LuaFunction);
					this.m_add_EventOnSortToggleClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSortToggleClick") as LuaFunction);
					this.m_remove_EventOnSortToggleClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSortToggleClick") as LuaFunction);
					this.m_add_EventOnShowGetPathAction`3_hotfix = (luaObj.RawGet("add_EventOnShowGetPath") as LuaFunction);
					this.m_remove_EventOnShowGetPathAction`3_hotfix = (luaObj.RawGet("remove_EventOnShowGetPath") as LuaFunction);
					this.m_add_EventOnInitHeroListAction`2_hotfix = (luaObj.RawGet("add_EventOnInitHeroList") as LuaFunction);
					this.m_remove_EventOnInitHeroListAction`2_hotfix = (luaObj.RawGet("remove_EventOnInitHeroList") as LuaFunction);
					this.m_add_EventOnUpdateViewInListAndDetailAction`4_hotfix = (luaObj.RawGet("add_EventOnUpdateViewInListAndDetail") as LuaFunction);
					this.m_remove_EventOnUpdateViewInListAndDetailAction`4_hotfix = (luaObj.RawGet("remove_EventOnUpdateViewInListAndDetail") as LuaFunction);
					this.m_add_EventOnHeroCharSkinChangeButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnHeroCharSkinChangeButtonClick") as LuaFunction);
					this.m_remove_EventOnHeroCharSkinChangeButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnHeroCharSkinChangeButtonClick") as LuaFunction);
					this.m_add_EventOnGoToMemoryExtractionStoreAction_hotfix = (luaObj.RawGet("add_EventOnGoToMemoryExtractionStore") as LuaFunction);
					this.m_remove_EventOnGoToMemoryExtractionStoreAction_hotfix = (luaObj.RawGet("remove_EventOnGoToMemoryExtractionStore") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010F01 RID: 69377 RVA: 0x004649D4 File Offset: 0x00462BD4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009BAE RID: 39854
		[AutoBind("./HeroListPanel/HeroListScrollView/Viewport/Content/UnlockedHeroContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewUnlockedHeroContent;

		// Token: 0x04009BAF RID: 39855
		[AutoBind("./HeroListPanel/HeroListScrollView/Viewport/Content/LockedHeroContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewLockedHeroContent;

		// Token: 0x04009BB0 RID: 39856
		[AutoBind("./HeroListPanel/HeroListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_scrollView;

		// Token: 0x04009BB1 RID: 39857
		[AutoBind("./HeroInfoPanel/CVPanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_cvText;

		// Token: 0x04009BB2 RID: 39858
		[AutoBind("./HeroInfoPanel/CommentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_commentButton;

		// Token: 0x04009BB3 RID: 39859
		[AutoBind("./HeroInfoPanel/DetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detailButton;

		// Token: 0x04009BB4 RID: 39860
		[AutoBind("./HeroInfoPanel/DetailButton/RedPointImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_detailButtonRedPointImage;

		// Token: 0x04009BB5 RID: 39861
		[AutoBind("./HeroInfoPanel/SummonPanel/SummonButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_summonButton;

		// Token: 0x04009BB6 RID: 39862
		[AutoBind("./HeroInfoPanel/SummonPanel/SummonButton/U_SummonButton_ Press", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_summonButtonPressEffect;

		// Token: 0x04009BB7 RID: 39863
		[AutoBind("./HeroInfoPanel/SummonPanel/SummonButton/U_Button_ready", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_summonButtonReadyEffect;

		// Token: 0x04009BB8 RID: 39864
		[AutoBind("./HeroListPanel/FilterButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_filterButton;

		// Token: 0x04009BB9 RID: 39865
		[AutoBind("./HeroListPanel/AddHeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addheroButton;

		// Token: 0x04009BBA RID: 39866
		[AutoBind("./HeroListPanel/SpeedUpHeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_speedUpHeroButton;

		// Token: 0x04009BBB RID: 39867
		[AutoBind("./HeroListPanel/ResetHeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_resetHeroButton;

		// Token: 0x04009BBC RID: 39868
		[AutoBind("./HeroListPanel/HeroIdInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_heroIdInputField;

		// Token: 0x04009BBD RID: 39869
		[AutoBind("./ComposeConfirmPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_composeConfirmPanel;

		// Token: 0x04009BBE RID: 39870
		[AutoBind("./ComposeConfirmPanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_composeCostText;

		// Token: 0x04009BBF RID: 39871
		[AutoBind("./ComposeConfirmPanel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_composeCancelButton;

		// Token: 0x04009BC0 RID: 39872
		[AutoBind("./ComposeConfirmPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_composeConfirmButton;

		// Token: 0x04009BC1 RID: 39873
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04009BC2 RID: 39874
		[AutoBind("./HeroInfoPanel/HeroName/NameTextCh", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameTextCh;

		// Token: 0x04009BC3 RID: 39875
		[AutoBind("./HeroInfoPanel/HeroName/NameTextEn", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameTextEn;

		// Token: 0x04009BC4 RID: 39876
		[AutoBind("./HeroInfoPanel/HeroName/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroRankImage;

		// Token: 0x04009BC5 RID: 39877
		[AutoBind("./HeroInfoPanel/HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStar;

		// Token: 0x04009BC6 RID: 39878
		[AutoBind("./HeroInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObjectRoot;

		// Token: 0x04009BC7 RID: 39879
		[AutoBind("./HeroInfoPanel/Word", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charWordGameObject;

		// Token: 0x04009BC8 RID: 39880
		[AutoBind("./HeroInfoPanel/Char/U_Summonout", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charSummonEffect;

		// Token: 0x04009BC9 RID: 39881
		[AutoBind("./HeroInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroInfoPanel;

		// Token: 0x04009BCA RID: 39882
		[AutoBind("./HeroInfoPanel/SkinChangeButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroCharSkinChangeButton;

		// Token: 0x04009BCB RID: 39883
		[AutoBind("./HeroListPanel/JobUpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroJobUpButton;

		// Token: 0x04009BCC RID: 39884
		[AutoBind("./HeroInfoPanel/Equipments", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroEquipmentsButton;

		// Token: 0x04009BCD RID: 39885
		[AutoBind("./HeroInfoPanel/Equipments/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroEquipmentsContent;

		// Token: 0x04009BCE RID: 39886
		[AutoBind("./HeroInfoPanel/Equipments/RedPointImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroEquipmentsRedPointImage;

		// Token: 0x04009BCF RID: 39887
		[AutoBind("./HeroInfoPanel/PowerValue", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_powerValueStateCtrl;

		// Token: 0x04009BD0 RID: 39888
		[AutoBind("./HeroInfoPanel/PowerValue/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_powerValueText;

		// Token: 0x04009BD1 RID: 39889
		[AutoBind("./HeroInfoPanel/PowerValue/Arrow", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_powerArrowGo;

		// Token: 0x04009BD2 RID: 39890
		[AutoBind("./HeroInfoPanel/BreakPanel/BreakButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_breakButton;

		// Token: 0x04009BD3 RID: 39891
		[AutoBind("./HeroInfoPanel/BreakPanel/BreakButton/U_Button_ready", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakButtonReadyEffect;

		// Token: 0x04009BD4 RID: 39892
		[AutoBind("./HeroInfoPanel/BreakPanel/BreakButton/U_BreakButton_ Press", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_breakButtonPressEffect;

		// Token: 0x04009BD5 RID: 39893
		[AutoBind("./HeroInfoPanel/BreakPanel/Fragment/AddImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_breakAddBtn;

		// Token: 0x04009BD6 RID: 39894
		[AutoBind("./HeroInfoPanel/BreakPanel/Fragment/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_breakNumText;

		// Token: 0x04009BD7 RID: 39895
		[AutoBind("./HeroInfoPanel/BreakPanel/Fragment/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_breakIconImage;

		// Token: 0x04009BD8 RID: 39896
		[AutoBind("./HeroInfoPanel/BreakPanel/ExtractionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_extractionButton;

		// Token: 0x04009BD9 RID: 39897
		[AutoBind("./HeroInfoPanel/BreakPanel/ExtractionTips", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_extractionTipsStateCtrl;

		// Token: 0x04009BDA RID: 39898
		[AutoBind("./HeroListPanel/SortGroup/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sortButton;

		// Token: 0x04009BDB RID: 39899
		[AutoBind("./HeroListPanel/SortGroup/SortButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sortButtonStateCtrl;

		// Token: 0x04009BDC RID: 39900
		[AutoBind("./HeroListPanel/SortGroup/SortTypes", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sortTypesPanelStateCtrl;

		// Token: 0x04009BDD RID: 39901
		[AutoBind("./HeroListPanel/SortGroup/SortTypes/BGImages/ReturnBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_sortTypesReturnBgImage;

		// Token: 0x04009BDE RID: 39902
		[AutoBind("./HeroListPanel/SortGroup/SortTypes/GridLayout/Level", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_sortTypesLevelToggle;

		// Token: 0x04009BDF RID: 39903
		[AutoBind("./HeroListPanel/SortGroup/SortTypes/GridLayout/Star", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_sortTypesStarToggle;

		// Token: 0x04009BE0 RID: 39904
		[AutoBind("./HeroListPanel/SortGroup/SortTypes/GridLayout/Rarity", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_sortTypesRarityToggle;

		// Token: 0x04009BE1 RID: 39905
		[AutoBind("./HeroListPanel/SortGroup/SortTypes/GridLayout/Power", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_sortTypesPowerToggle;

		// Token: 0x04009BE2 RID: 39906
		public const string LevelType = "Level";

		// Token: 0x04009BE3 RID: 39907
		public const string StarLevelType = "StarLevel";

		// Token: 0x04009BE4 RID: 39908
		public const string RankType = "Rank";

		// Token: 0x04009BE5 RID: 39909
		public const string PowerType = "Power";

		// Token: 0x04009BE6 RID: 39910
		public bool m_isUnLockHero = true;

		// Token: 0x04009BE7 RID: 39911
		private int m_heroPowerValue;

		// Token: 0x04009BE8 RID: 39912
		private int m_curHeroNeedFragmentCount;

		// Token: 0x04009BE9 RID: 39913
		public int m_curSelectedHeroIndex;

		// Token: 0x04009BEA RID: 39914
		public GameObject m_curSeletedHeroList;

		// Token: 0x04009BEB RID: 39915
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04009BEC RID: 39916
		public List<Hero> m_unLockedHeroList = new List<Hero>();

		// Token: 0x04009BED RID: 39917
		public List<Hero> m_lockedHeroList = new List<Hero>();

		// Token: 0x04009BEE RID: 39918
		public List<HeroItemUIController> m_unLockedHeroCtrlList = new List<HeroItemUIController>();

		// Token: 0x04009BEF RID: 39919
		public List<HeroItemUIController> m_lockedHeroCtrlList = new List<HeroItemUIController>();

		// Token: 0x04009BF0 RID: 39920
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009BF1 RID: 39921
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009BF2 RID: 39922
		[DoNotToLua]
		private HeroListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009BF3 RID: 39923
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009BF4 RID: 39924
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009BF5 RID: 39925
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009BF6 RID: 39926
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04009BF7 RID: 39927
		private LuaFunction m_UpdateViewInHeroListBoolean_hotfix;

		// Token: 0x04009BF8 RID: 39928
		private LuaFunction m_CreateHeroList_hotfix;

		// Token: 0x04009BF9 RID: 39929
		private LuaFunction m_SetHeroPowerValue_hotfix;

		// Token: 0x04009BFA RID: 39930
		private LuaFunction m_ResetHeroPowerValue_hotfix;

		// Token: 0x04009BFB RID: 39931
		private LuaFunction m_StopAllCoroutineInHeroList_hotfix;

		// Token: 0x04009BFC RID: 39932
		private LuaFunction m_SetHeroCharSkinPreviewStringInt32_hotfix;

		// Token: 0x04009BFD RID: 39933
		private LuaFunction m_Co_SetPowerValueSingleSingle_hotfix;

		// Token: 0x04009BFE RID: 39934
		private LuaFunction m_SetCurHeroListList`1List;

		// Token: 0x04009BFF RID: 39935
		private LuaFunction m_SetToInitState_hotfix;

		// Token: 0x04009C00 RID: 39936
		private LuaFunction m_SetToAtLeftState_hotfix;

		// Token: 0x04009C01 RID: 39937
		private LuaFunction m_OnHeroItemClickHeroItemUIController_hotfix;

		// Token: 0x04009C02 RID: 39938
		private LuaFunction m_OnHeroFragmentSearchButtonClick_hotfix;

		// Token: 0x04009C03 RID: 39939
		private LuaFunction m_OnBreakButtonClick_hotfix;

		// Token: 0x04009C04 RID: 39940
		private LuaFunction m_PlayBreakButtonClickEffectInt32_hotfix;

		// Token: 0x04009C05 RID: 39941
		private LuaFunction m_ComposeLockedHeroHero_hotfix;

		// Token: 0x04009C06 RID: 39942
		private LuaFunction m_CloseComposeHeroPanel_hotfix;

		// Token: 0x04009C07 RID: 39943
		private LuaFunction m_ConfirmComposeHero_hotfix;

		// Token: 0x04009C08 RID: 39944
		private LuaFunction m_OnComposeHeroSucceed_hotfix;

		// Token: 0x04009C09 RID: 39945
		private LuaFunction m_PlayHeroGetEffect_hotfix;

		// Token: 0x04009C0A RID: 39946
		private LuaFunction m_OnExtractionButtonClick_hotfix;

		// Token: 0x04009C0B RID: 39947
		private LuaFunction m_OnEquipmentsButtonClick_hotfix;

		// Token: 0x04009C0C RID: 39948
		private LuaFunction m_OnHeroJobUpButtonClick_hotfix;

		// Token: 0x04009C0D RID: 39949
		private LuaFunction m_OnHeroCharSkinChangeButton_hotfix;

		// Token: 0x04009C0E RID: 39950
		private LuaFunction m_HeroCharUIController_OnClick_hotfix;

		// Token: 0x04009C0F RID: 39951
		private LuaFunction m_ClickHeroByIdForUserGuideInt32_hotfix;

		// Token: 0x04009C10 RID: 39952
		private LuaFunction m_ClickLowLevelHeroForUserGuide_hotfix;

		// Token: 0x04009C11 RID: 39953
		private LuaFunction m_ClickLockedHeroForUserGuide_hotfix;

		// Token: 0x04009C12 RID: 39954
		private LuaFunction m_GetHeroItemPosInListGameObjectList;

		// Token: 0x04009C13 RID: 39955
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009C14 RID: 39956
		private LuaFunction m_SetSortTypeButtonAndToggles_hotfix;

		// Token: 0x04009C15 RID: 39957
		private LuaFunction m_ResetData_hotfix;

		// Token: 0x04009C16 RID: 39958
		private LuaFunction m_Open_hotfix;

		// Token: 0x04009C17 RID: 39959
		private LuaFunction m_OnFilterButtonClick_hotfix;

		// Token: 0x04009C18 RID: 39960
		private LuaFunction m_ResetScrollViewPosition_hotfix;

		// Token: 0x04009C19 RID: 39961
		private LuaFunction m_OnDetailButtonClick_hotfix;

		// Token: 0x04009C1A RID: 39962
		private LuaFunction m_OnSummonButtonClick_hotfix;

		// Token: 0x04009C1B RID: 39963
		private LuaFunction m_PlaySummonButtonClickEffect_hotfix;

		// Token: 0x04009C1C RID: 39964
		private LuaFunction m_ShowButtonGameObjectBoolean_hotfix;

		// Token: 0x04009C1D RID: 39965
		private LuaFunction m_OnCommentButtonClick_hotfix;

		// Token: 0x04009C1E RID: 39966
		private LuaFunction m_OnAddHeroButtonClick_hotfix;

		// Token: 0x04009C1F RID: 39967
		private LuaFunction m_OnSpeedUpHeroButtonClick_hotfix;

		// Token: 0x04009C20 RID: 39968
		private LuaFunction m_OnResetHeroButtonClick_hotfix;

		// Token: 0x04009C21 RID: 39969
		private LuaFunction m_ResetPanelPos_hotfix;

		// Token: 0x04009C22 RID: 39970
		private LuaFunction m_InactiveCharWordPanel_hotfix;

		// Token: 0x04009C23 RID: 39971
		private LuaFunction m_GetCurHeroList_hotfix;

		// Token: 0x04009C24 RID: 39972
		private LuaFunction m_HaveHeroCanCompose_hotfix;

		// Token: 0x04009C25 RID: 39973
		private LuaFunction m_PlayHeroPerformanceInt32_hotfix;

		// Token: 0x04009C26 RID: 39974
		private LuaFunction m_OnLevelToggleValueChangedBoolean_hotfix;

		// Token: 0x04009C27 RID: 39975
		private LuaFunction m_OnStarLevelToggleValueChangedBoolean_hotfix;

		// Token: 0x04009C28 RID: 39976
		private LuaFunction m_OnRankToggleValueChangedBoolean_hotfix;

		// Token: 0x04009C29 RID: 39977
		private LuaFunction m_OnPowerToggleValueChangedBoolean_hotfix;

		// Token: 0x04009C2A RID: 39978
		private LuaFunction m_OnSortButtonClick_hotfix;

		// Token: 0x04009C2B RID: 39979
		private LuaFunction m_CloseSortTypesPanel_hotfix;

		// Token: 0x04009C2C RID: 39980
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009C2D RID: 39981
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009C2E RID: 39982
		private LuaFunction m_add_EventOnFilterAction_hotfix;

		// Token: 0x04009C2F RID: 39983
		private LuaFunction m_remove_EventOnFilterAction_hotfix;

		// Token: 0x04009C30 RID: 39984
		private LuaFunction m_add_EventOnDetailAction_hotfix;

		// Token: 0x04009C31 RID: 39985
		private LuaFunction m_remove_EventOnDetailAction_hotfix;

		// Token: 0x04009C32 RID: 39986
		private LuaFunction m_add_EventOnCommentAction_hotfix;

		// Token: 0x04009C33 RID: 39987
		private LuaFunction m_remove_EventOnCommentAction_hotfix;

		// Token: 0x04009C34 RID: 39988
		private LuaFunction m_add_EventOnEquipmentAction_hotfix;

		// Token: 0x04009C35 RID: 39989
		private LuaFunction m_remove_EventOnEquipmentAction_hotfix;

		// Token: 0x04009C36 RID: 39990
		private LuaFunction m_add_EventOnJobAction_hotfix;

		// Token: 0x04009C37 RID: 39991
		private LuaFunction m_remove_EventOnJobAction_hotfix;

		// Token: 0x04009C38 RID: 39992
		private LuaFunction m_add_EventOnHeroCharClickAction_hotfix;

		// Token: 0x04009C39 RID: 39993
		private LuaFunction m_remove_EventOnHeroCharClickAction_hotfix;

		// Token: 0x04009C3A RID: 39994
		private LuaFunction m_add_EventOnHeroBreakAction;

		// Token: 0x04009C3B RID: 39995
		private LuaFunction m_remove_EventOnHeroBreakAction;

		// Token: 0x04009C3C RID: 39996
		private LuaFunction m_add_EventOnAddHeroAction;

		// Token: 0x04009C3D RID: 39997
		private LuaFunction m_remove_EventOnAddHeroAction;

		// Token: 0x04009C3E RID: 39998
		private LuaFunction m_add_EventOnComposeHeroAction;

		// Token: 0x04009C3F RID: 39999
		private LuaFunction m_remove_EventOnComposeHeroAction;

		// Token: 0x04009C40 RID: 40000
		private LuaFunction m_add_EventOnSortToggleClickAction;

		// Token: 0x04009C41 RID: 40001
		private LuaFunction m_remove_EventOnSortToggleClickAction;

		// Token: 0x04009C42 RID: 40002
		private LuaFunction m_add_EventOnShowGetPathAction;

		// Token: 0x04009C43 RID: 40003
		private LuaFunction m_remove_EventOnShowGetPathAction;

		// Token: 0x04009C44 RID: 40004
		private LuaFunction m_add_EventOnInitHeroListAction;

		// Token: 0x04009C45 RID: 40005
		private LuaFunction m_remove_EventOnInitHeroListAction;

		// Token: 0x04009C46 RID: 40006
		private LuaFunction m_add_EventOnUpdateViewInListAndDetailAction;

		// Token: 0x04009C47 RID: 40007
		private LuaFunction m_remove_EventOnUpdateViewInListAndDetailAction;

		// Token: 0x04009C48 RID: 40008
		private LuaFunction m_add_EventOnHeroCharSkinChangeButtonClickAction_hotfix;

		// Token: 0x04009C49 RID: 40009
		private LuaFunction m_remove_EventOnHeroCharSkinChangeButtonClickAction_hotfix;

		// Token: 0x04009C4A RID: 40010
		private LuaFunction m_add_EventOnGoToMemoryExtractionStoreAction_hotfix;

		// Token: 0x04009C4B RID: 40011
		private LuaFunction m_remove_EventOnGoToMemoryExtractionStoreAction_hotfix;

		// Token: 0x02000DD1 RID: 3537
		public enum HeroSortType
		{
			// Token: 0x04009C4D RID: 40013
			Level,
			// Token: 0x04009C4E RID: 40014
			StarLevel,
			// Token: 0x04009C4F RID: 40015
			Rank,
			// Token: 0x04009C50 RID: 40016
			Power
		}

		// Token: 0x02000DD2 RID: 3538
		public new class LuaExportHelper
		{
			// Token: 0x06010F02 RID: 69378 RVA: 0x00464A3C File Offset: 0x00462C3C
			public LuaExportHelper(HeroListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010F03 RID: 69379 RVA: 0x00464A4C File Offset: 0x00462C4C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010F04 RID: 69380 RVA: 0x00464A5C File Offset: 0x00462C5C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010F05 RID: 69381 RVA: 0x00464A6C File Offset: 0x00462C6C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010F06 RID: 69382 RVA: 0x00464A7C File Offset: 0x00462C7C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010F07 RID: 69383 RVA: 0x00464A94 File Offset: 0x00462C94
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010F08 RID: 69384 RVA: 0x00464AA4 File Offset: 0x00462CA4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010F09 RID: 69385 RVA: 0x00464AB4 File Offset: 0x00462CB4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010F0A RID: 69386 RVA: 0x00464AC4 File Offset: 0x00462CC4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010F0B RID: 69387 RVA: 0x00464AD4 File Offset: 0x00462CD4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010F0C RID: 69388 RVA: 0x00464AE4 File Offset: 0x00462CE4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010F0D RID: 69389 RVA: 0x00464AF4 File Offset: 0x00462CF4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010F0E RID: 69390 RVA: 0x00464B04 File Offset: 0x00462D04
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010F0F RID: 69391 RVA: 0x00464B14 File Offset: 0x00462D14
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010F10 RID: 69392 RVA: 0x00464B24 File Offset: 0x00462D24
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010F11 RID: 69393 RVA: 0x00464B34 File Offset: 0x00462D34
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010F12 RID: 69394 RVA: 0x00464B44 File Offset: 0x00462D44
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06010F13 RID: 69395 RVA: 0x00464B54 File Offset: 0x00462D54
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06010F14 RID: 69396 RVA: 0x00464B64 File Offset: 0x00462D64
			public void __callDele_EventOnFilter()
			{
				this.m_owner.__callDele_EventOnFilter();
			}

			// Token: 0x06010F15 RID: 69397 RVA: 0x00464B74 File Offset: 0x00462D74
			public void __clearDele_EventOnFilter()
			{
				this.m_owner.__clearDele_EventOnFilter();
			}

			// Token: 0x06010F16 RID: 69398 RVA: 0x00464B84 File Offset: 0x00462D84
			public void __callDele_EventOnDetail()
			{
				this.m_owner.__callDele_EventOnDetail();
			}

			// Token: 0x06010F17 RID: 69399 RVA: 0x00464B94 File Offset: 0x00462D94
			public void __clearDele_EventOnDetail()
			{
				this.m_owner.__clearDele_EventOnDetail();
			}

			// Token: 0x06010F18 RID: 69400 RVA: 0x00464BA4 File Offset: 0x00462DA4
			public void __callDele_EventOnComment()
			{
				this.m_owner.__callDele_EventOnComment();
			}

			// Token: 0x06010F19 RID: 69401 RVA: 0x00464BB4 File Offset: 0x00462DB4
			public void __clearDele_EventOnComment()
			{
				this.m_owner.__clearDele_EventOnComment();
			}

			// Token: 0x06010F1A RID: 69402 RVA: 0x00464BC4 File Offset: 0x00462DC4
			public void __callDele_EventOnEquipment()
			{
				this.m_owner.__callDele_EventOnEquipment();
			}

			// Token: 0x06010F1B RID: 69403 RVA: 0x00464BD4 File Offset: 0x00462DD4
			public void __clearDele_EventOnEquipment()
			{
				this.m_owner.__clearDele_EventOnEquipment();
			}

			// Token: 0x06010F1C RID: 69404 RVA: 0x00464BE4 File Offset: 0x00462DE4
			public void __callDele_EventOnJob()
			{
				this.m_owner.__callDele_EventOnJob();
			}

			// Token: 0x06010F1D RID: 69405 RVA: 0x00464BF4 File Offset: 0x00462DF4
			public void __clearDele_EventOnJob()
			{
				this.m_owner.__clearDele_EventOnJob();
			}

			// Token: 0x06010F1E RID: 69406 RVA: 0x00464C04 File Offset: 0x00462E04
			public void __callDele_EventOnHeroCharClick()
			{
				this.m_owner.__callDele_EventOnHeroCharClick();
			}

			// Token: 0x06010F1F RID: 69407 RVA: 0x00464C14 File Offset: 0x00462E14
			public void __clearDele_EventOnHeroCharClick()
			{
				this.m_owner.__clearDele_EventOnHeroCharClick();
			}

			// Token: 0x06010F20 RID: 69408 RVA: 0x00464C24 File Offset: 0x00462E24
			public void __callDele_EventOnHeroBreak(int obj)
			{
				this.m_owner.__callDele_EventOnHeroBreak(obj);
			}

			// Token: 0x06010F21 RID: 69409 RVA: 0x00464C34 File Offset: 0x00462E34
			public void __clearDele_EventOnHeroBreak(int obj)
			{
				this.m_owner.__clearDele_EventOnHeroBreak(obj);
			}

			// Token: 0x06010F22 RID: 69410 RVA: 0x00464C44 File Offset: 0x00462E44
			public void __callDele_EventOnAddHero(string obj)
			{
				this.m_owner.__callDele_EventOnAddHero(obj);
			}

			// Token: 0x06010F23 RID: 69411 RVA: 0x00464C54 File Offset: 0x00462E54
			public void __clearDele_EventOnAddHero(string obj)
			{
				this.m_owner.__clearDele_EventOnAddHero(obj);
			}

			// Token: 0x06010F24 RID: 69412 RVA: 0x00464C64 File Offset: 0x00462E64
			public void __callDele_EventOnComposeHero(int arg1, Action arg2)
			{
				this.m_owner.__callDele_EventOnComposeHero(arg1, arg2);
			}

			// Token: 0x06010F25 RID: 69413 RVA: 0x00464C74 File Offset: 0x00462E74
			public void __clearDele_EventOnComposeHero(int arg1, Action arg2)
			{
				this.m_owner.__clearDele_EventOnComposeHero(arg1, arg2);
			}

			// Token: 0x06010F26 RID: 69414 RVA: 0x00464C84 File Offset: 0x00462E84
			public void __callDele_EventOnSortToggleClick(HeroListUIController.HeroSortType obj)
			{
				this.m_owner.__callDele_EventOnSortToggleClick(obj);
			}

			// Token: 0x06010F27 RID: 69415 RVA: 0x00464C94 File Offset: 0x00462E94
			public void __clearDele_EventOnSortToggleClick(HeroListUIController.HeroSortType obj)
			{
				this.m_owner.__clearDele_EventOnSortToggleClick(obj);
			}

			// Token: 0x06010F28 RID: 69416 RVA: 0x00464CA4 File Offset: 0x00462EA4
			public void __callDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnShowGetPath(arg1, arg2, arg3);
			}

			// Token: 0x06010F29 RID: 69417 RVA: 0x00464CB4 File Offset: 0x00462EB4
			public void __clearDele_EventOnShowGetPath(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnShowGetPath(arg1, arg2, arg3);
			}

			// Token: 0x06010F2A RID: 69418 RVA: 0x00464CC4 File Offset: 0x00462EC4
			public void __callDele_EventOnInitHeroList(List<Hero> arg1, List<Hero> arg2)
			{
				this.m_owner.__callDele_EventOnInitHeroList(arg1, arg2);
			}

			// Token: 0x06010F2B RID: 69419 RVA: 0x00464CD4 File Offset: 0x00462ED4
			public void __clearDele_EventOnInitHeroList(List<Hero> arg1, List<Hero> arg2)
			{
				this.m_owner.__clearDele_EventOnInitHeroList(arg1, arg2);
			}

			// Token: 0x06010F2C RID: 69420 RVA: 0x00464CE4 File Offset: 0x00462EE4
			public void __callDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
			{
				this.m_owner.__callDele_EventOnUpdateViewInListAndDetail(arg1, arg2, arg3, arg4);
			}

			// Token: 0x06010F2D RID: 69421 RVA: 0x00464CF8 File Offset: 0x00462EF8
			public void __clearDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
			{
				this.m_owner.__clearDele_EventOnUpdateViewInListAndDetail(arg1, arg2, arg3, arg4);
			}

			// Token: 0x06010F2E RID: 69422 RVA: 0x00464D0C File Offset: 0x00462F0C
			public void __callDele_EventOnHeroCharSkinChangeButtonClick()
			{
				this.m_owner.__callDele_EventOnHeroCharSkinChangeButtonClick();
			}

			// Token: 0x06010F2F RID: 69423 RVA: 0x00464D1C File Offset: 0x00462F1C
			public void __clearDele_EventOnHeroCharSkinChangeButtonClick()
			{
				this.m_owner.__clearDele_EventOnHeroCharSkinChangeButtonClick();
			}

			// Token: 0x06010F30 RID: 69424 RVA: 0x00464D2C File Offset: 0x00462F2C
			public void __callDele_EventOnGoToMemoryExtractionStore()
			{
				this.m_owner.__callDele_EventOnGoToMemoryExtractionStore();
			}

			// Token: 0x06010F31 RID: 69425 RVA: 0x00464D3C File Offset: 0x00462F3C
			public void __clearDele_EventOnGoToMemoryExtractionStore()
			{
				this.m_owner.__clearDele_EventOnGoToMemoryExtractionStore();
			}

			// Token: 0x17003462 RID: 13410
			// (get) Token: 0x06010F32 RID: 69426 RVA: 0x00464D4C File Offset: 0x00462F4C
			// (set) Token: 0x06010F33 RID: 69427 RVA: 0x00464D5C File Offset: 0x00462F5C
			public GameObject m_scrollViewUnlockedHeroContent
			{
				get
				{
					return this.m_owner.m_scrollViewUnlockedHeroContent;
				}
				set
				{
					this.m_owner.m_scrollViewUnlockedHeroContent = value;
				}
			}

			// Token: 0x17003463 RID: 13411
			// (get) Token: 0x06010F34 RID: 69428 RVA: 0x00464D6C File Offset: 0x00462F6C
			// (set) Token: 0x06010F35 RID: 69429 RVA: 0x00464D7C File Offset: 0x00462F7C
			public GameObject m_scrollViewLockedHeroContent
			{
				get
				{
					return this.m_owner.m_scrollViewLockedHeroContent;
				}
				set
				{
					this.m_owner.m_scrollViewLockedHeroContent = value;
				}
			}

			// Token: 0x17003464 RID: 13412
			// (get) Token: 0x06010F36 RID: 69430 RVA: 0x00464D8C File Offset: 0x00462F8C
			// (set) Token: 0x06010F37 RID: 69431 RVA: 0x00464D9C File Offset: 0x00462F9C
			public ScrollRect m_scrollView
			{
				get
				{
					return this.m_owner.m_scrollView;
				}
				set
				{
					this.m_owner.m_scrollView = value;
				}
			}

			// Token: 0x17003465 RID: 13413
			// (get) Token: 0x06010F38 RID: 69432 RVA: 0x00464DAC File Offset: 0x00462FAC
			// (set) Token: 0x06010F39 RID: 69433 RVA: 0x00464DBC File Offset: 0x00462FBC
			public Text m_cvText
			{
				get
				{
					return this.m_owner.m_cvText;
				}
				set
				{
					this.m_owner.m_cvText = value;
				}
			}

			// Token: 0x17003466 RID: 13414
			// (get) Token: 0x06010F3A RID: 69434 RVA: 0x00464DCC File Offset: 0x00462FCC
			// (set) Token: 0x06010F3B RID: 69435 RVA: 0x00464DDC File Offset: 0x00462FDC
			public Button m_commentButton
			{
				get
				{
					return this.m_owner.m_commentButton;
				}
				set
				{
					this.m_owner.m_commentButton = value;
				}
			}

			// Token: 0x17003467 RID: 13415
			// (get) Token: 0x06010F3C RID: 69436 RVA: 0x00464DEC File Offset: 0x00462FEC
			// (set) Token: 0x06010F3D RID: 69437 RVA: 0x00464DFC File Offset: 0x00462FFC
			public Button m_detailButton
			{
				get
				{
					return this.m_owner.m_detailButton;
				}
				set
				{
					this.m_owner.m_detailButton = value;
				}
			}

			// Token: 0x17003468 RID: 13416
			// (get) Token: 0x06010F3E RID: 69438 RVA: 0x00464E0C File Offset: 0x0046300C
			// (set) Token: 0x06010F3F RID: 69439 RVA: 0x00464E1C File Offset: 0x0046301C
			public GameObject m_detailButtonRedPointImage
			{
				get
				{
					return this.m_owner.m_detailButtonRedPointImage;
				}
				set
				{
					this.m_owner.m_detailButtonRedPointImage = value;
				}
			}

			// Token: 0x17003469 RID: 13417
			// (get) Token: 0x06010F40 RID: 69440 RVA: 0x00464E2C File Offset: 0x0046302C
			// (set) Token: 0x06010F41 RID: 69441 RVA: 0x00464E3C File Offset: 0x0046303C
			public Button m_summonButton
			{
				get
				{
					return this.m_owner.m_summonButton;
				}
				set
				{
					this.m_owner.m_summonButton = value;
				}
			}

			// Token: 0x1700346A RID: 13418
			// (get) Token: 0x06010F42 RID: 69442 RVA: 0x00464E4C File Offset: 0x0046304C
			// (set) Token: 0x06010F43 RID: 69443 RVA: 0x00464E5C File Offset: 0x0046305C
			public GameObject m_summonButtonPressEffect
			{
				get
				{
					return this.m_owner.m_summonButtonPressEffect;
				}
				set
				{
					this.m_owner.m_summonButtonPressEffect = value;
				}
			}

			// Token: 0x1700346B RID: 13419
			// (get) Token: 0x06010F44 RID: 69444 RVA: 0x00464E6C File Offset: 0x0046306C
			// (set) Token: 0x06010F45 RID: 69445 RVA: 0x00464E7C File Offset: 0x0046307C
			public GameObject m_summonButtonReadyEffect
			{
				get
				{
					return this.m_owner.m_summonButtonReadyEffect;
				}
				set
				{
					this.m_owner.m_summonButtonReadyEffect = value;
				}
			}

			// Token: 0x1700346C RID: 13420
			// (get) Token: 0x06010F46 RID: 69446 RVA: 0x00464E8C File Offset: 0x0046308C
			// (set) Token: 0x06010F47 RID: 69447 RVA: 0x00464E9C File Offset: 0x0046309C
			public Button m_filterButton
			{
				get
				{
					return this.m_owner.m_filterButton;
				}
				set
				{
					this.m_owner.m_filterButton = value;
				}
			}

			// Token: 0x1700346D RID: 13421
			// (get) Token: 0x06010F48 RID: 69448 RVA: 0x00464EAC File Offset: 0x004630AC
			// (set) Token: 0x06010F49 RID: 69449 RVA: 0x00464EBC File Offset: 0x004630BC
			public Button m_addheroButton
			{
				get
				{
					return this.m_owner.m_addheroButton;
				}
				set
				{
					this.m_owner.m_addheroButton = value;
				}
			}

			// Token: 0x1700346E RID: 13422
			// (get) Token: 0x06010F4A RID: 69450 RVA: 0x00464ECC File Offset: 0x004630CC
			// (set) Token: 0x06010F4B RID: 69451 RVA: 0x00464EDC File Offset: 0x004630DC
			public Button m_speedUpHeroButton
			{
				get
				{
					return this.m_owner.m_speedUpHeroButton;
				}
				set
				{
					this.m_owner.m_speedUpHeroButton = value;
				}
			}

			// Token: 0x1700346F RID: 13423
			// (get) Token: 0x06010F4C RID: 69452 RVA: 0x00464EEC File Offset: 0x004630EC
			// (set) Token: 0x06010F4D RID: 69453 RVA: 0x00464EFC File Offset: 0x004630FC
			public Button m_resetHeroButton
			{
				get
				{
					return this.m_owner.m_resetHeroButton;
				}
				set
				{
					this.m_owner.m_resetHeroButton = value;
				}
			}

			// Token: 0x17003470 RID: 13424
			// (get) Token: 0x06010F4E RID: 69454 RVA: 0x00464F0C File Offset: 0x0046310C
			// (set) Token: 0x06010F4F RID: 69455 RVA: 0x00464F1C File Offset: 0x0046311C
			public InputField m_heroIdInputField
			{
				get
				{
					return this.m_owner.m_heroIdInputField;
				}
				set
				{
					this.m_owner.m_heroIdInputField = value;
				}
			}

			// Token: 0x17003471 RID: 13425
			// (get) Token: 0x06010F50 RID: 69456 RVA: 0x00464F2C File Offset: 0x0046312C
			// (set) Token: 0x06010F51 RID: 69457 RVA: 0x00464F3C File Offset: 0x0046313C
			public GameObject m_composeConfirmPanel
			{
				get
				{
					return this.m_owner.m_composeConfirmPanel;
				}
				set
				{
					this.m_owner.m_composeConfirmPanel = value;
				}
			}

			// Token: 0x17003472 RID: 13426
			// (get) Token: 0x06010F52 RID: 69458 RVA: 0x00464F4C File Offset: 0x0046314C
			// (set) Token: 0x06010F53 RID: 69459 RVA: 0x00464F5C File Offset: 0x0046315C
			public Text m_composeCostText
			{
				get
				{
					return this.m_owner.m_composeCostText;
				}
				set
				{
					this.m_owner.m_composeCostText = value;
				}
			}

			// Token: 0x17003473 RID: 13427
			// (get) Token: 0x06010F54 RID: 69460 RVA: 0x00464F6C File Offset: 0x0046316C
			// (set) Token: 0x06010F55 RID: 69461 RVA: 0x00464F7C File Offset: 0x0046317C
			public Button m_composeCancelButton
			{
				get
				{
					return this.m_owner.m_composeCancelButton;
				}
				set
				{
					this.m_owner.m_composeCancelButton = value;
				}
			}

			// Token: 0x17003474 RID: 13428
			// (get) Token: 0x06010F56 RID: 69462 RVA: 0x00464F8C File Offset: 0x0046318C
			// (set) Token: 0x06010F57 RID: 69463 RVA: 0x00464F9C File Offset: 0x0046319C
			public Button m_composeConfirmButton
			{
				get
				{
					return this.m_owner.m_composeConfirmButton;
				}
				set
				{
					this.m_owner.m_composeConfirmButton = value;
				}
			}

			// Token: 0x17003475 RID: 13429
			// (get) Token: 0x06010F58 RID: 69464 RVA: 0x00464FAC File Offset: 0x004631AC
			// (set) Token: 0x06010F59 RID: 69465 RVA: 0x00464FBC File Offset: 0x004631BC
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

			// Token: 0x17003476 RID: 13430
			// (get) Token: 0x06010F5A RID: 69466 RVA: 0x00464FCC File Offset: 0x004631CC
			// (set) Token: 0x06010F5B RID: 69467 RVA: 0x00464FDC File Offset: 0x004631DC
			public Text m_heroNameTextCh
			{
				get
				{
					return this.m_owner.m_heroNameTextCh;
				}
				set
				{
					this.m_owner.m_heroNameTextCh = value;
				}
			}

			// Token: 0x17003477 RID: 13431
			// (get) Token: 0x06010F5C RID: 69468 RVA: 0x00464FEC File Offset: 0x004631EC
			// (set) Token: 0x06010F5D RID: 69469 RVA: 0x00464FFC File Offset: 0x004631FC
			public Text m_heroNameTextEn
			{
				get
				{
					return this.m_owner.m_heroNameTextEn;
				}
				set
				{
					this.m_owner.m_heroNameTextEn = value;
				}
			}

			// Token: 0x17003478 RID: 13432
			// (get) Token: 0x06010F5E RID: 69470 RVA: 0x0046500C File Offset: 0x0046320C
			// (set) Token: 0x06010F5F RID: 69471 RVA: 0x0046501C File Offset: 0x0046321C
			public Image m_heroRankImage
			{
				get
				{
					return this.m_owner.m_heroRankImage;
				}
				set
				{
					this.m_owner.m_heroRankImage = value;
				}
			}

			// Token: 0x17003479 RID: 13433
			// (get) Token: 0x06010F60 RID: 69472 RVA: 0x0046502C File Offset: 0x0046322C
			// (set) Token: 0x06010F61 RID: 69473 RVA: 0x0046503C File Offset: 0x0046323C
			public GameObject m_heroStar
			{
				get
				{
					return this.m_owner.m_heroStar;
				}
				set
				{
					this.m_owner.m_heroStar = value;
				}
			}

			// Token: 0x1700347A RID: 13434
			// (get) Token: 0x06010F62 RID: 69474 RVA: 0x0046504C File Offset: 0x0046324C
			// (set) Token: 0x06010F63 RID: 69475 RVA: 0x0046505C File Offset: 0x0046325C
			public GameObject m_charGameObjectRoot
			{
				get
				{
					return this.m_owner.m_charGameObjectRoot;
				}
				set
				{
					this.m_owner.m_charGameObjectRoot = value;
				}
			}

			// Token: 0x1700347B RID: 13435
			// (get) Token: 0x06010F64 RID: 69476 RVA: 0x0046506C File Offset: 0x0046326C
			// (set) Token: 0x06010F65 RID: 69477 RVA: 0x0046507C File Offset: 0x0046327C
			public GameObject m_charWordGameObject
			{
				get
				{
					return this.m_owner.m_charWordGameObject;
				}
				set
				{
					this.m_owner.m_charWordGameObject = value;
				}
			}

			// Token: 0x1700347C RID: 13436
			// (get) Token: 0x06010F66 RID: 69478 RVA: 0x0046508C File Offset: 0x0046328C
			// (set) Token: 0x06010F67 RID: 69479 RVA: 0x0046509C File Offset: 0x0046329C
			public GameObject m_charSummonEffect
			{
				get
				{
					return this.m_owner.m_charSummonEffect;
				}
				set
				{
					this.m_owner.m_charSummonEffect = value;
				}
			}

			// Token: 0x1700347D RID: 13437
			// (get) Token: 0x06010F68 RID: 69480 RVA: 0x004650AC File Offset: 0x004632AC
			// (set) Token: 0x06010F69 RID: 69481 RVA: 0x004650BC File Offset: 0x004632BC
			public GameObject m_heroInfoPanel
			{
				get
				{
					return this.m_owner.m_heroInfoPanel;
				}
				set
				{
					this.m_owner.m_heroInfoPanel = value;
				}
			}

			// Token: 0x1700347E RID: 13438
			// (get) Token: 0x06010F6A RID: 69482 RVA: 0x004650CC File Offset: 0x004632CC
			// (set) Token: 0x06010F6B RID: 69483 RVA: 0x004650DC File Offset: 0x004632DC
			public Button m_heroCharSkinChangeButton
			{
				get
				{
					return this.m_owner.m_heroCharSkinChangeButton;
				}
				set
				{
					this.m_owner.m_heroCharSkinChangeButton = value;
				}
			}

			// Token: 0x1700347F RID: 13439
			// (get) Token: 0x06010F6C RID: 69484 RVA: 0x004650EC File Offset: 0x004632EC
			// (set) Token: 0x06010F6D RID: 69485 RVA: 0x004650FC File Offset: 0x004632FC
			public Button m_heroJobUpButton
			{
				get
				{
					return this.m_owner.m_heroJobUpButton;
				}
				set
				{
					this.m_owner.m_heroJobUpButton = value;
				}
			}

			// Token: 0x17003480 RID: 13440
			// (get) Token: 0x06010F6E RID: 69486 RVA: 0x0046510C File Offset: 0x0046330C
			// (set) Token: 0x06010F6F RID: 69487 RVA: 0x0046511C File Offset: 0x0046331C
			public Button m_heroEquipmentsButton
			{
				get
				{
					return this.m_owner.m_heroEquipmentsButton;
				}
				set
				{
					this.m_owner.m_heroEquipmentsButton = value;
				}
			}

			// Token: 0x17003481 RID: 13441
			// (get) Token: 0x06010F70 RID: 69488 RVA: 0x0046512C File Offset: 0x0046332C
			// (set) Token: 0x06010F71 RID: 69489 RVA: 0x0046513C File Offset: 0x0046333C
			public GameObject m_heroEquipmentsContent
			{
				get
				{
					return this.m_owner.m_heroEquipmentsContent;
				}
				set
				{
					this.m_owner.m_heroEquipmentsContent = value;
				}
			}

			// Token: 0x17003482 RID: 13442
			// (get) Token: 0x06010F72 RID: 69490 RVA: 0x0046514C File Offset: 0x0046334C
			// (set) Token: 0x06010F73 RID: 69491 RVA: 0x0046515C File Offset: 0x0046335C
			public GameObject m_heroEquipmentsRedPointImage
			{
				get
				{
					return this.m_owner.m_heroEquipmentsRedPointImage;
				}
				set
				{
					this.m_owner.m_heroEquipmentsRedPointImage = value;
				}
			}

			// Token: 0x17003483 RID: 13443
			// (get) Token: 0x06010F74 RID: 69492 RVA: 0x0046516C File Offset: 0x0046336C
			// (set) Token: 0x06010F75 RID: 69493 RVA: 0x0046517C File Offset: 0x0046337C
			public CommonUIStateController m_powerValueStateCtrl
			{
				get
				{
					return this.m_owner.m_powerValueStateCtrl;
				}
				set
				{
					this.m_owner.m_powerValueStateCtrl = value;
				}
			}

			// Token: 0x17003484 RID: 13444
			// (get) Token: 0x06010F76 RID: 69494 RVA: 0x0046518C File Offset: 0x0046338C
			// (set) Token: 0x06010F77 RID: 69495 RVA: 0x0046519C File Offset: 0x0046339C
			public Text m_powerValueText
			{
				get
				{
					return this.m_owner.m_powerValueText;
				}
				set
				{
					this.m_owner.m_powerValueText = value;
				}
			}

			// Token: 0x17003485 RID: 13445
			// (get) Token: 0x06010F78 RID: 69496 RVA: 0x004651AC File Offset: 0x004633AC
			// (set) Token: 0x06010F79 RID: 69497 RVA: 0x004651BC File Offset: 0x004633BC
			public GameObject m_powerArrowGo
			{
				get
				{
					return this.m_owner.m_powerArrowGo;
				}
				set
				{
					this.m_owner.m_powerArrowGo = value;
				}
			}

			// Token: 0x17003486 RID: 13446
			// (get) Token: 0x06010F7A RID: 69498 RVA: 0x004651CC File Offset: 0x004633CC
			// (set) Token: 0x06010F7B RID: 69499 RVA: 0x004651DC File Offset: 0x004633DC
			public Button m_breakButton
			{
				get
				{
					return this.m_owner.m_breakButton;
				}
				set
				{
					this.m_owner.m_breakButton = value;
				}
			}

			// Token: 0x17003487 RID: 13447
			// (get) Token: 0x06010F7C RID: 69500 RVA: 0x004651EC File Offset: 0x004633EC
			// (set) Token: 0x06010F7D RID: 69501 RVA: 0x004651FC File Offset: 0x004633FC
			public GameObject m_breakButtonReadyEffect
			{
				get
				{
					return this.m_owner.m_breakButtonReadyEffect;
				}
				set
				{
					this.m_owner.m_breakButtonReadyEffect = value;
				}
			}

			// Token: 0x17003488 RID: 13448
			// (get) Token: 0x06010F7E RID: 69502 RVA: 0x0046520C File Offset: 0x0046340C
			// (set) Token: 0x06010F7F RID: 69503 RVA: 0x0046521C File Offset: 0x0046341C
			public GameObject m_breakButtonPressEffect
			{
				get
				{
					return this.m_owner.m_breakButtonPressEffect;
				}
				set
				{
					this.m_owner.m_breakButtonPressEffect = value;
				}
			}

			// Token: 0x17003489 RID: 13449
			// (get) Token: 0x06010F80 RID: 69504 RVA: 0x0046522C File Offset: 0x0046342C
			// (set) Token: 0x06010F81 RID: 69505 RVA: 0x0046523C File Offset: 0x0046343C
			public Button m_breakAddBtn
			{
				get
				{
					return this.m_owner.m_breakAddBtn;
				}
				set
				{
					this.m_owner.m_breakAddBtn = value;
				}
			}

			// Token: 0x1700348A RID: 13450
			// (get) Token: 0x06010F82 RID: 69506 RVA: 0x0046524C File Offset: 0x0046344C
			// (set) Token: 0x06010F83 RID: 69507 RVA: 0x0046525C File Offset: 0x0046345C
			public Text m_breakNumText
			{
				get
				{
					return this.m_owner.m_breakNumText;
				}
				set
				{
					this.m_owner.m_breakNumText = value;
				}
			}

			// Token: 0x1700348B RID: 13451
			// (get) Token: 0x06010F84 RID: 69508 RVA: 0x0046526C File Offset: 0x0046346C
			// (set) Token: 0x06010F85 RID: 69509 RVA: 0x0046527C File Offset: 0x0046347C
			public Image m_breakIconImage
			{
				get
				{
					return this.m_owner.m_breakIconImage;
				}
				set
				{
					this.m_owner.m_breakIconImage = value;
				}
			}

			// Token: 0x1700348C RID: 13452
			// (get) Token: 0x06010F86 RID: 69510 RVA: 0x0046528C File Offset: 0x0046348C
			// (set) Token: 0x06010F87 RID: 69511 RVA: 0x0046529C File Offset: 0x0046349C
			public Button m_extractionButton
			{
				get
				{
					return this.m_owner.m_extractionButton;
				}
				set
				{
					this.m_owner.m_extractionButton = value;
				}
			}

			// Token: 0x1700348D RID: 13453
			// (get) Token: 0x06010F88 RID: 69512 RVA: 0x004652AC File Offset: 0x004634AC
			// (set) Token: 0x06010F89 RID: 69513 RVA: 0x004652BC File Offset: 0x004634BC
			public CommonUIStateController m_extractionTipsStateCtrl
			{
				get
				{
					return this.m_owner.m_extractionTipsStateCtrl;
				}
				set
				{
					this.m_owner.m_extractionTipsStateCtrl = value;
				}
			}

			// Token: 0x1700348E RID: 13454
			// (get) Token: 0x06010F8A RID: 69514 RVA: 0x004652CC File Offset: 0x004634CC
			// (set) Token: 0x06010F8B RID: 69515 RVA: 0x004652DC File Offset: 0x004634DC
			public Button m_sortButton
			{
				get
				{
					return this.m_owner.m_sortButton;
				}
				set
				{
					this.m_owner.m_sortButton = value;
				}
			}

			// Token: 0x1700348F RID: 13455
			// (get) Token: 0x06010F8C RID: 69516 RVA: 0x004652EC File Offset: 0x004634EC
			// (set) Token: 0x06010F8D RID: 69517 RVA: 0x004652FC File Offset: 0x004634FC
			public CommonUIStateController m_sortButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_sortButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_sortButtonStateCtrl = value;
				}
			}

			// Token: 0x17003490 RID: 13456
			// (get) Token: 0x06010F8E RID: 69518 RVA: 0x0046530C File Offset: 0x0046350C
			// (set) Token: 0x06010F8F RID: 69519 RVA: 0x0046531C File Offset: 0x0046351C
			public CommonUIStateController m_sortTypesPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_sortTypesPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_sortTypesPanelStateCtrl = value;
				}
			}

			// Token: 0x17003491 RID: 13457
			// (get) Token: 0x06010F90 RID: 69520 RVA: 0x0046532C File Offset: 0x0046352C
			// (set) Token: 0x06010F91 RID: 69521 RVA: 0x0046533C File Offset: 0x0046353C
			public Button m_sortTypesReturnBgImage
			{
				get
				{
					return this.m_owner.m_sortTypesReturnBgImage;
				}
				set
				{
					this.m_owner.m_sortTypesReturnBgImage = value;
				}
			}

			// Token: 0x17003492 RID: 13458
			// (get) Token: 0x06010F92 RID: 69522 RVA: 0x0046534C File Offset: 0x0046354C
			// (set) Token: 0x06010F93 RID: 69523 RVA: 0x0046535C File Offset: 0x0046355C
			public Toggle m_sortTypesLevelToggle
			{
				get
				{
					return this.m_owner.m_sortTypesLevelToggle;
				}
				set
				{
					this.m_owner.m_sortTypesLevelToggle = value;
				}
			}

			// Token: 0x17003493 RID: 13459
			// (get) Token: 0x06010F94 RID: 69524 RVA: 0x0046536C File Offset: 0x0046356C
			// (set) Token: 0x06010F95 RID: 69525 RVA: 0x0046537C File Offset: 0x0046357C
			public Toggle m_sortTypesStarToggle
			{
				get
				{
					return this.m_owner.m_sortTypesStarToggle;
				}
				set
				{
					this.m_owner.m_sortTypesStarToggle = value;
				}
			}

			// Token: 0x17003494 RID: 13460
			// (get) Token: 0x06010F96 RID: 69526 RVA: 0x0046538C File Offset: 0x0046358C
			// (set) Token: 0x06010F97 RID: 69527 RVA: 0x0046539C File Offset: 0x0046359C
			public Toggle m_sortTypesRarityToggle
			{
				get
				{
					return this.m_owner.m_sortTypesRarityToggle;
				}
				set
				{
					this.m_owner.m_sortTypesRarityToggle = value;
				}
			}

			// Token: 0x17003495 RID: 13461
			// (get) Token: 0x06010F98 RID: 69528 RVA: 0x004653AC File Offset: 0x004635AC
			// (set) Token: 0x06010F99 RID: 69529 RVA: 0x004653BC File Offset: 0x004635BC
			public Toggle m_sortTypesPowerToggle
			{
				get
				{
					return this.m_owner.m_sortTypesPowerToggle;
				}
				set
				{
					this.m_owner.m_sortTypesPowerToggle = value;
				}
			}

			// Token: 0x17003496 RID: 13462
			// (get) Token: 0x06010F9A RID: 69530 RVA: 0x004653CC File Offset: 0x004635CC
			// (set) Token: 0x06010F9B RID: 69531 RVA: 0x004653DC File Offset: 0x004635DC
			public int m_heroPowerValue
			{
				get
				{
					return this.m_owner.m_heroPowerValue;
				}
				set
				{
					this.m_owner.m_heroPowerValue = value;
				}
			}

			// Token: 0x17003497 RID: 13463
			// (get) Token: 0x06010F9C RID: 69532 RVA: 0x004653EC File Offset: 0x004635EC
			// (set) Token: 0x06010F9D RID: 69533 RVA: 0x004653FC File Offset: 0x004635FC
			public int m_curHeroNeedFragmentCount
			{
				get
				{
					return this.m_owner.m_curHeroNeedFragmentCount;
				}
				set
				{
					this.m_owner.m_curHeroNeedFragmentCount = value;
				}
			}

			// Token: 0x17003498 RID: 13464
			// (get) Token: 0x06010F9E RID: 69534 RVA: 0x0046540C File Offset: 0x0046360C
			// (set) Token: 0x06010F9F RID: 69535 RVA: 0x0046541C File Offset: 0x0046361C
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

			// Token: 0x17003499 RID: 13465
			// (get) Token: 0x06010FA0 RID: 69536 RVA: 0x0046542C File Offset: 0x0046362C
			// (set) Token: 0x06010FA1 RID: 69537 RVA: 0x0046543C File Offset: 0x0046363C
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

			// Token: 0x1700349A RID: 13466
			// (get) Token: 0x06010FA2 RID: 69538 RVA: 0x0046544C File Offset: 0x0046364C
			// (set) Token: 0x06010FA3 RID: 69539 RVA: 0x0046545C File Offset: 0x0046365C
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

			// Token: 0x06010FA4 RID: 69540 RVA: 0x0046546C File Offset: 0x0046366C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010FA5 RID: 69541 RVA: 0x0046547C File Offset: 0x0046367C
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x06010FA6 RID: 69542 RVA: 0x0046548C File Offset: 0x0046368C
			public void CreateHeroList()
			{
				this.m_owner.CreateHeroList();
			}

			// Token: 0x06010FA7 RID: 69543 RVA: 0x0046549C File Offset: 0x0046369C
			public IEnumerator Co_SetPowerValue(float newValue, float oldValue)
			{
				return this.m_owner.Co_SetPowerValue(newValue, oldValue);
			}

			// Token: 0x06010FA8 RID: 69544 RVA: 0x004654AC File Offset: 0x004636AC
			public void OnHeroItemClick(HeroItemUIController goCtrl)
			{
				this.m_owner.OnHeroItemClick(goCtrl);
			}

			// Token: 0x06010FA9 RID: 69545 RVA: 0x004654BC File Offset: 0x004636BC
			public void OnHeroFragmentSearchButtonClick()
			{
				this.m_owner.OnHeroFragmentSearchButtonClick();
			}

			// Token: 0x06010FAA RID: 69546 RVA: 0x004654CC File Offset: 0x004636CC
			public void OnBreakButtonClick()
			{
				this.m_owner.OnBreakButtonClick();
			}

			// Token: 0x06010FAB RID: 69547 RVA: 0x004654DC File Offset: 0x004636DC
			public IEnumerator PlayBreakButtonClickEffect(int heroId)
			{
				return this.m_owner.PlayBreakButtonClickEffect(heroId);
			}

			// Token: 0x06010FAC RID: 69548 RVA: 0x004654EC File Offset: 0x004636EC
			public void ComposeLockedHero(Hero h)
			{
				this.m_owner.ComposeLockedHero(h);
			}

			// Token: 0x06010FAD RID: 69549 RVA: 0x004654FC File Offset: 0x004636FC
			public void CloseComposeHeroPanel()
			{
				this.m_owner.CloseComposeHeroPanel();
			}

			// Token: 0x06010FAE RID: 69550 RVA: 0x0046550C File Offset: 0x0046370C
			public void ConfirmComposeHero()
			{
				this.m_owner.ConfirmComposeHero();
			}

			// Token: 0x06010FAF RID: 69551 RVA: 0x0046551C File Offset: 0x0046371C
			public void OnComposeHeroSucceed()
			{
				this.m_owner.OnComposeHeroSucceed();
			}

			// Token: 0x06010FB0 RID: 69552 RVA: 0x0046552C File Offset: 0x0046372C
			public IEnumerator PlayHeroGetEffect()
			{
				return this.m_owner.PlayHeroGetEffect();
			}

			// Token: 0x06010FB1 RID: 69553 RVA: 0x0046553C File Offset: 0x0046373C
			public void OnExtractionButtonClick()
			{
				this.m_owner.OnExtractionButtonClick();
			}

			// Token: 0x06010FB2 RID: 69554 RVA: 0x0046554C File Offset: 0x0046374C
			public void OnEquipmentsButtonClick()
			{
				this.m_owner.OnEquipmentsButtonClick();
			}

			// Token: 0x06010FB3 RID: 69555 RVA: 0x0046555C File Offset: 0x0046375C
			public void OnHeroJobUpButtonClick()
			{
				this.m_owner.OnHeroJobUpButtonClick();
			}

			// Token: 0x06010FB4 RID: 69556 RVA: 0x0046556C File Offset: 0x0046376C
			public void OnHeroCharSkinChangeButton()
			{
				this.m_owner.OnHeroCharSkinChangeButton();
			}

			// Token: 0x06010FB5 RID: 69557 RVA: 0x0046557C File Offset: 0x0046377C
			public void HeroCharUIController_OnClick()
			{
				this.m_owner.HeroCharUIController_OnClick();
			}

			// Token: 0x06010FB6 RID: 69558 RVA: 0x0046558C File Offset: 0x0046378C
			public int GetHeroItemPosInList(GameObject child, List<HeroItemUIController> parent)
			{
				return this.m_owner.GetHeroItemPosInList(child, parent);
			}

			// Token: 0x06010FB7 RID: 69559 RVA: 0x0046559C File Offset: 0x0046379C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06010FB8 RID: 69560 RVA: 0x004655AC File Offset: 0x004637AC
			public void SetSortTypeButtonAndToggles()
			{
				this.m_owner.SetSortTypeButtonAndToggles();
			}

			// Token: 0x06010FB9 RID: 69561 RVA: 0x004655BC File Offset: 0x004637BC
			public void ResetData()
			{
				this.m_owner.ResetData();
			}

			// Token: 0x06010FBA RID: 69562 RVA: 0x004655CC File Offset: 0x004637CC
			public void OnFilterButtonClick()
			{
				this.m_owner.OnFilterButtonClick();
			}

			// Token: 0x06010FBB RID: 69563 RVA: 0x004655DC File Offset: 0x004637DC
			public void ResetScrollViewPosition()
			{
				this.m_owner.ResetScrollViewPosition();
			}

			// Token: 0x06010FBC RID: 69564 RVA: 0x004655EC File Offset: 0x004637EC
			public void OnDetailButtonClick()
			{
				this.m_owner.OnDetailButtonClick();
			}

			// Token: 0x06010FBD RID: 69565 RVA: 0x004655FC File Offset: 0x004637FC
			public void OnSummonButtonClick()
			{
				this.m_owner.OnSummonButtonClick();
			}

			// Token: 0x06010FBE RID: 69566 RVA: 0x0046560C File Offset: 0x0046380C
			public IEnumerator PlaySummonButtonClickEffect()
			{
				return this.m_owner.PlaySummonButtonClickEffect();
			}

			// Token: 0x06010FBF RID: 69567 RVA: 0x0046561C File Offset: 0x0046381C
			public void OnCommentButtonClick()
			{
				this.m_owner.OnCommentButtonClick();
			}

			// Token: 0x06010FC0 RID: 69568 RVA: 0x0046562C File Offset: 0x0046382C
			public void OnAddHeroButtonClick()
			{
				this.m_owner.OnAddHeroButtonClick();
			}

			// Token: 0x06010FC1 RID: 69569 RVA: 0x0046563C File Offset: 0x0046383C
			public void OnSpeedUpHeroButtonClick()
			{
				this.m_owner.OnSpeedUpHeroButtonClick();
			}

			// Token: 0x06010FC2 RID: 69570 RVA: 0x0046564C File Offset: 0x0046384C
			public void OnResetHeroButtonClick()
			{
				this.m_owner.OnResetHeroButtonClick();
			}

			// Token: 0x06010FC3 RID: 69571 RVA: 0x0046565C File Offset: 0x0046385C
			public void OnLevelToggleValueChanged(bool isOn)
			{
				this.m_owner.OnLevelToggleValueChanged(isOn);
			}

			// Token: 0x06010FC4 RID: 69572 RVA: 0x0046566C File Offset: 0x0046386C
			public void OnStarLevelToggleValueChanged(bool isOn)
			{
				this.m_owner.OnStarLevelToggleValueChanged(isOn);
			}

			// Token: 0x06010FC5 RID: 69573 RVA: 0x0046567C File Offset: 0x0046387C
			public void OnRankToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRankToggleValueChanged(isOn);
			}

			// Token: 0x06010FC6 RID: 69574 RVA: 0x0046568C File Offset: 0x0046388C
			public void OnPowerToggleValueChanged(bool isOn)
			{
				this.m_owner.OnPowerToggleValueChanged(isOn);
			}

			// Token: 0x06010FC7 RID: 69575 RVA: 0x0046569C File Offset: 0x0046389C
			public void OnSortButtonClick()
			{
				this.m_owner.OnSortButtonClick();
			}

			// Token: 0x06010FC8 RID: 69576 RVA: 0x004656AC File Offset: 0x004638AC
			public void CloseSortTypesPanel()
			{
				this.m_owner.CloseSortTypesPanel();
			}

			// Token: 0x04009C51 RID: 40017
			private HeroListUIController m_owner;
		}
	}
}
