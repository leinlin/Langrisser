using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EF0 RID: 3824
	[HotFix]
	public class SelectCardUIController : UIControllerBase
	{
		// Token: 0x06012DD2 RID: 77266 RVA: 0x004D2908 File Offset: 0x004D0B08
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
			this.m_detailButton.onClick.AddListener(new UnityAction(this.OnDetailButtonClick));
			this.m_archiveButton.onClick.AddListener(new UnityAction(this.OnArchiveButtonClick));
			this.m_tenSelectBtn.onClick.AddListener(new UnityAction(this.OnTenSelectButtonClick));
			this.m_diamondsAddBtn.onClick.AddListener(new UnityAction(this.OnAddCrystalBtnClick));
			this.m_diamondsAddBtn2.onClick.AddListener(new UnityAction(this.OnAddCrystalBtnClick));
			this.m_selectSkipButton.onClick.AddListener(new UnityAction(this.SkipShowRewardEffect));
			this.m_buyDiamondButton.onClick.AddListener(new UnityAction(this.OnBuyDiamondButtonClick));
			this.m_singleSelectBtn.onClick.AddListener(new UnityAction(this.OnSingleSelectButtonClick));
			this.m_selectAgainButton.onClick.AddListener(new UnityAction(this.OnSelectAgainButtonClick));
			this.m_singleSelectContinueImage.onClick.AddListener(new UnityAction(this.OnContinueButtonClick));
			this.m_detailCloseButton.onClick.AddListener(new UnityAction(this.OnCloseDetailPanelButtonClick));
			this.m_activityDetailButton.onClick.AddListener(new UnityAction(this.OnActivityDetailButtonClick));
			this.m_detailReturnBgButton.onClick.AddListener(new UnityAction(this.OnCloseDetailPanelButtonClick));
			this.m_afterSelectConfirmButton.onClick.AddListener(new UnityAction(this.CloseShowSelectRewardsPanel));
			this.m_changeCrystalToTicketPanelCancelButton.onClick.AddListener(new UnityAction(this.ChangeCrystalToTicketPanelCancelButtonClick));
			this.m_changeCrystalToTicketPanelConfirmButton.onClick.AddListener(new UnityAction(this.ChangeCrystalToTicketPanelConfirmButtonClick));
			this.m_crystalAndTicketNotEnoughPanelCancelButton.onClick.AddListener(new UnityAction(this.CrystalAndTicketNotEnoughPanelCancelButtonClick));
			this.m_crystalAndTicketNotEnoughPanelConfirmButton.onClick.AddListener(new UnityAction(this.CrystalAndTicketNotEnoughPanelConfirmButtonClick));
			EventTriggerListener eventTriggerListener = this.m_singleSelectArrowButton.AddComponent<EventTriggerListener>();
			EventTriggerListener eventTriggerListener2 = eventTriggerListener;
			eventTriggerListener2.onEndDrag = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener2.onEndDrag, new EventTriggerListener.VoidDelegate(this.OnClockButtonDrag));
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_singleSelectPanel);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("ShareButtonUIPrefab");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			gameObject.transform.SetParent(this.m_singleShareButtonDummy.transform, false);
			this.m_weiBoShareOneButton = GameObjectUtility.FindComponentByName<Button>(gameObject.transform, "WeiBoButton");
			this.m_weChatShareOneButton = GameObjectUtility.FindComponentByName<Button>(gameObject.transform, "WeChatButton");
			this.m_weiBoShareOneButton.onClick.AddListener(new UnityAction(this.OnWeiBoShareOnceClick));
			this.m_weChatShareOneButton.onClick.AddListener(new UnityAction(this.OnWeChatShareOnceClick));
			CommonUIStateController commonUIStateController = gameObject.GetComponent<CommonUIStateController>();
			if (commonUIStateController != null)
			{
				commonUIStateController.SetToUIState("BgNO", false, true);
			}
			gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			gameObject.transform.SetParent(this.m_tenShareButtonDummy.transform, false);
			this.m_weiBoShareTenButton = GameObjectUtility.FindComponentByName<Button>(gameObject.transform, "WeiBoButton");
			this.m_weChatShareTenButton = GameObjectUtility.FindComponentByName<Button>(gameObject.transform, "WeChatButton");
			this.m_weiBoShareTenButton.onClick.AddListener(new UnityAction(this.OnWeiBoShareTenClick));
			this.m_weChatShareTenButton.onClick.AddListener(new UnityAction(this.OnWeChatShareTenClick));
			commonUIStateController = gameObject.GetComponent<CommonUIStateController>();
			if (commonUIStateController != null)
			{
				commonUIStateController.SetToUIState("BgNO", false, true);
			}
			assetInContainer = base.GetAssetInContainer<GameObject>("SharePhotoUIPrefab");
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			gameObject2.transform.SetParent(this.m_sharePhotoDummy.transform, false);
			commonUIStateController = gameObject2.GetComponentInChildren<CommonUIStateController>();
			if (commonUIStateController != null)
			{
				commonUIStateController.SetToUIState("HeroName", false, true);
			}
			this.m_playerNameText = GameObjectUtility.FindComponentByName<Text>(gameObject2.transform, "NameText");
			this.m_playerLvText = GameObjectUtility.FindComponentByName<Text>(gameObject2.transform, "LvValueText");
			this.m_serverNameText = GameObjectUtility.FindComponentByName<Text>(gameObject2.transform, "ServerNameText");
			this.m_heroNameText = GameObjectUtility.FindComponentByName<Text>(gameObject2.transform, "HeroNameText");
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06012DD3 RID: 77267 RVA: 0x004D2DF0 File Offset: 0x004D0FF0
		public void UpdateViewInSelectCard(int cardPoolId = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInSelectCardInt32_hotfix != null)
			{
				this.m_UpdateViewInSelectCardInt32_hotfix.call(new object[]
				{
					this,
					cardPoolId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (cardPoolId != 0)
			{
				this.m_cardPoolId = cardPoolId;
			}
			if (this.m_cardPool == null)
			{
				this.CreateCardPoolTabs();
				if (this.m_cardPoolId == 0)
				{
					this.m_cardPoolId = this.m_toggleCtrlList[0].CardPool.PoolId;
				}
			}
			this.m_cardPool = this.m_playerContext.GetCardPoolById(this.m_cardPoolId);
			foreach (SummonToggleUIController summonToggleUIController in this.m_toggleCtrlList)
			{
				if (summonToggleUIController.CardPool.PoolId == this.m_cardPoolId)
				{
					summonToggleUIController.SetToggleIsOn(true);
				}
			}
			if (this.m_cardPool != null)
			{
				this.SetValuesAfterToggleChanged();
			}
			this.m_normalCardNumText.text = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, 4000).ToString();
			this.m_diamondsCardNumText.text = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, 4001).ToString();
			this.m_diamondsNumText.text = this.m_playerContext.GetCrystal().ToString();
		}

		// Token: 0x06012DD4 RID: 77268 RVA: 0x004D2FAC File Offset: 0x004D11AC
		public void UpdateSharePlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSharePlayerInfo_hotfix != null)
			{
				this.m_UpdateSharePlayerInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerNameText.text = this.m_playerContext.GetPlayerName();
			this.m_playerLvText.text = this.m_playerContext.GetPlayerLevel().ToString();
			this.m_serverNameText.text = LoginUITask.GetCurrentSelectServerInfo().m_name;
		}

		// Token: 0x06012DD5 RID: 77269 RVA: 0x004D305C File Offset: 0x004D125C
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

		// Token: 0x06012DD6 RID: 77270 RVA: 0x004D30D8 File Offset: 0x004D12D8
		public void SetShareTenSelectCardUIController(ShareTenSelectCardUIController controller)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetShareTenSelectCardUIControllerShareTenSelectCardUIController_hotfix != null)
			{
				this.m_SetShareTenSelectCardUIControllerShareTenSelectCardUIController_hotfix.call(new object[]
				{
					this,
					controller
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_shareTenSelectCardUIController = controller;
		}

		// Token: 0x06012DD7 RID: 77271 RVA: 0x004D3150 File Offset: 0x004D1350
		public void ShowSelectCardRewards(List<Goods> rewards, SelectCardBackground3DController selectCardBackground3DController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectCardRewardsList`1SelectCardBackground3DController_hotfix != null)
			{
				this.m_ShowSelectCardRewardsList`1SelectCardBackground3DController_hotfix.call(new object[]
				{
					this,
					rewards,
					selectCardBackground3DController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectCardBackground3DController = selectCardBackground3DController;
			this.m_mainUIGo.SetActive(false);
			this.m_afterSelectPanel.SetActive(true);
			base.StartCoroutine(this.PlayRewardsEffect(rewards));
		}

		// Token: 0x06012DD8 RID: 77272 RVA: 0x004D3200 File Offset: 0x004D1400
		[DebuggerHidden]
		private IEnumerator PlayRewardsEffect(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayRewardsEffectList`1_hotfix != null)
			{
				return (IEnumerator)this.m_PlayRewardsEffectList`1_hotfix.call(new object[]
				{
					this,
					rewards
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SelectCardUIController.<PlayRewardsEffect>c__Iterator0 <PlayRewardsEffect>c__Iterator = new SelectCardUIController.<PlayRewardsEffect>c__Iterator0();
			<PlayRewardsEffect>c__Iterator.rewards = rewards;
			<PlayRewardsEffect>c__Iterator.$this = this;
			return <PlayRewardsEffect>c__Iterator;
		}

		// Token: 0x06012DD9 RID: 77273 RVA: 0x004D3294 File Offset: 0x004D1494
		[DebuggerHidden]
		private IEnumerator PlaySingleRewardEffect(Goods goods, bool isNeedClockEffect, int rank, int maxRank, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySingleRewardEffectGoodsBooleanInt32Int32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_PlaySingleRewardEffectGoodsBooleanInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					goods,
					isNeedClockEffect,
					rank,
					maxRank,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SelectCardUIController.<PlaySingleRewardEffect>c__Iterator1 <PlaySingleRewardEffect>c__Iterator = new SelectCardUIController.<PlaySingleRewardEffect>c__Iterator1();
			<PlaySingleRewardEffect>c__Iterator.isNeedClockEffect = isNeedClockEffect;
			<PlaySingleRewardEffect>c__Iterator.maxRank = maxRank;
			<PlaySingleRewardEffect>c__Iterator.goods = goods;
			<PlaySingleRewardEffect>c__Iterator.index = index;
			<PlaySingleRewardEffect>c__Iterator.rank = rank;
			<PlaySingleRewardEffect>c__Iterator.$this = this;
			return <PlaySingleRewardEffect>c__Iterator;
		}

		// Token: 0x06012DDA RID: 77274 RVA: 0x004D3384 File Offset: 0x004D1584
		private void StopClockEffectSoundOnSkipButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopClockEffectSoundOnSkipButtonClick_hotfix != null)
			{
				this.m_StopClockEffectSoundOnSkipButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.PlaySound("stop,UI_SummonAni_Clock_R");
			AudioUtility.PlaySound("stop,UI_SummonAni_Clock_SR");
			AudioUtility.PlaySound("stop,UI_SummonAni_Clock_SSR");
			AudioUtility.PlaySound("stop,UI_SummonAni_ClockLoop");
		}

		// Token: 0x06012DDB RID: 77275 RVA: 0x004D3410 File Offset: 0x004D1610
		[DebuggerHidden]
		private IEnumerator AfterShowClockEffectFinished(Goods goods, int index, int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AfterShowClockEffectFinishedGoodsInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_AfterShowClockEffectFinishedGoodsInt32Int32_hotfix.call(new object[]
				{
					this,
					goods,
					index,
					rank
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SelectCardUIController.<AfterShowClockEffectFinished>c__Iterator2 <AfterShowClockEffectFinished>c__Iterator = new SelectCardUIController.<AfterShowClockEffectFinished>c__Iterator2();
			<AfterShowClockEffectFinished>c__Iterator.goods = goods;
			<AfterShowClockEffectFinished>c__Iterator.index = index;
			<AfterShowClockEffectFinished>c__Iterator.rank = rank;
			<AfterShowClockEffectFinished>c__Iterator.$this = this;
			return <AfterShowClockEffectFinished>c__Iterator;
		}

		// Token: 0x06012DDC RID: 77276 RVA: 0x004D34D0 File Offset: 0x004D16D0
		private void OnClockButtonDrag(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClockButtonDragGameObject_hotfix != null)
			{
				this.m_OnClockButtonDragGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isClockHold = true;
			this.m_singleSelectArrowButton.gameObject.SetActive(false);
		}

		// Token: 0x06012DDD RID: 77277 RVA: 0x004D3558 File Offset: 0x004D1758
		private void OnContinueButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnContinueButtonClick_hotfix != null)
			{
				this.m_OnContinueButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isContinueButtonClick = true;
			this.m_singleSelectContinueImage.gameObject.SetActive(false);
		}

		// Token: 0x06012DDE RID: 77278 RVA: 0x004D35D0 File Offset: 0x004D17D0
		[DebuggerHidden]
		private IEnumerator PlayTotalRewardsEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayTotalRewardsEffect_hotfix != null)
			{
				return (IEnumerator)this.m_PlayTotalRewardsEffect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SelectCardUIController.<PlayTotalRewardsEffect>c__Iterator3 <PlayTotalRewardsEffect>c__Iterator = new SelectCardUIController.<PlayTotalRewardsEffect>c__Iterator3();
			<PlayTotalRewardsEffect>c__Iterator.$this = this;
			return <PlayTotalRewardsEffect>c__Iterator;
		}

		// Token: 0x06012DDF RID: 77279 RVA: 0x004D364C File Offset: 0x004D184C
		private void SetAfterSelectCurrecyPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAfterSelectCurrecyPanel_hotfix != null)
			{
				this.m_SetAfterSelectCurrecyPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_afterSelectPanelNormalCardNumText.text = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, 4000).ToString();
			this.m_afterSelectPanelDiamondsCardNumText.text = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, 4001).ToString();
			this.m_afterSelectPanelDiamondsNumText.text = this.m_playerContext.GetCrystal().ToString();
		}

		// Token: 0x06012DE0 RID: 77280 RVA: 0x004D3724 File Offset: 0x004D1924
		private void SetSingleSelectRewardInfo(Goods goods, int index, int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSingleSelectRewardInfoGoodsInt32Int32_hotfix != null)
			{
				this.m_SetSingleSelectRewardInfoGoodsInt32Int32_hotfix.call(new object[]
				{
					this,
					goods,
					index,
					rank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_singleSelectFragmentIconImg.gameObject.SetActive(false);
			this.m_heroCharUIController.DestroyGraphic();
			string text = null;
			int num = 0;
			GoodsType goodsType = goods.GoodsType;
			switch (goodsType)
			{
			case GoodsType.GoodsType_Hero:
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(goods.Id);
				Hero hero = this.m_playerContext.GetHero(configDataHeroInfo.ID);
				ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
				this.m_heroCharUIController.CreateGraphic(hero, HeroCharUIController.PerformanceState.Summon, false, charImageInfo.Spine);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
				this.m_heroCharUIController.SetSpineColor(Color.black);
				this.m_heroNameText.text = configDataHeroInfo.Name;
				this.m_nToShareHeroId = configDataHeroInfo.ID;
				Dictionary<int, bool> isSelectHeroRewardTransferToFragmentDict = this.m_playerContext.GetIsSelectHeroRewardTransferToFragmentDict();
				if (!isSelectHeroRewardTransferToFragmentDict.ContainsKey(configDataHeroInfo.ID))
				{
					this.m_singleSelectFragmentIconImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(GoodsType.GoodsType_Item, configDataHeroInfo.FragmentItem_ID));
					this.m_singleSelectFragmentIconImg.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(GoodsType.GoodsType_Item, configDataHeroInfo.FragmentItem_ID));
					this.m_singleSelectFragmentIconImg.gameObject.SetActive(true);
					this.m_singleSelectFragmentCount.text = configDataHeroInfo.ExchangedFragmentCount.ToString();
				}
				text = null;
				num = configDataHeroInfo.Star;
				CommonUIStateController stateCtrl = this.m_singleSelectPanel.GetComponent<CommonUIStateController>();
				stateCtrl.SetActionForUIStateFinshed("ShowHero", delegate
				{
					this.m_singleShareButtonDummy.SetActive(true);
					stateCtrl.SetActionForUIStateFinshed("ShowHero", null);
				});
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = this.m_configDataLoader.GetConfigDataJobMaterialInfo(goods.Id);
				text = configDataJobMaterialInfo.Icon;
				num = 0;
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(goods.Id);
				text = configDataItemInfo.Icon;
				num = 0;
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(goods.Id);
				text = configDataEquipmentInfo.Icon;
				num = configDataEquipmentInfo.BornStarLevel;
				break;
			}
			}
			this.m_singleSelectItemImage.gameObject.SetActive(text != null);
			if (text != null)
			{
				this.m_singleSelectItemImage.sprite = AssetUtility.Instance.GetSprite(text);
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_singleSelectStarGroupObj, num);
			if (num != 0)
			{
				string name = this.m_configDataLoader.UtilityGetSound(SoundTableId.SoundTableId_ShowStartAnimation) + num.ToString();
				AudioUtility.PlaySound(name);
			}
			bool[] selectRewardsIsFirstGetArray = this.m_playerContext.GetSelectRewardsIsFirstGetArray();
			this.m_singleSelectNewTextObj.SetActive(selectRewardsIsFirstGetArray[index]);
			if (rank >= 4)
			{
				this.m_singleSelectFragmentSSRImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetRankImage(rank));
			}
			else
			{
				this.m_singleSelectFragmentSRImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetRankImage(rank));
			}
			this.m_singleSelectFragmentSSRImg.gameObject.SetActive(rank >= 4);
			this.m_singleSelectFragmentSRImg.gameObject.SetActive(rank < 4);
		}

		// Token: 0x06012DE1 RID: 77281 RVA: 0x004D3B08 File Offset: 0x004D1D08
		private void SetTenSelectRewardsInfo(List<Goods> goodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTenSelectRewardsInfoList`1_hotfix != null)
			{
				this.m_SetTenSelectRewardsInfoList`1_hotfix.call(new object[]
				{
					this,
					goodsList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_tenSelectContentObj);
			bool[] selectRewardsIsFirstGetArray = this.m_playerContext.GetSelectRewardsIsFirstGetArray();
			Dictionary<int, bool> isSelectHeroRewardTransferToFragmentDict = this.m_playerContext.GetIsSelectHeroRewardTransferToFragmentDict();
			for (int i = 0; i < goodsList.Count; i++)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("SelectRewardsItem");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				SelectRewardsItemUIController component = gameObject.GetComponent<SelectRewardsItemUIController>();
				if (goodsList[i].GoodsType == GoodsType.GoodsType_Hero)
				{
					if (isSelectHeroRewardTransferToFragmentDict.ContainsKey(goodsList[i].Id))
					{
						component.InitSelectRewardsInfo(goodsList[i], selectRewardsIsFirstGetArray[i], isSelectHeroRewardTransferToFragmentDict[goodsList[i].Id]);
						isSelectHeroRewardTransferToFragmentDict[goodsList[i].Id] = true;
					}
					else
					{
						component.InitSelectRewardsInfo(goodsList[i], selectRewardsIsFirstGetArray[i], true);
					}
				}
				else
				{
					component.InitSelectRewardsInfo(goodsList[i], selectRewardsIsFirstGetArray[i], false);
				}
				gameObject.transform.SetParent(this.m_tenSelectContentObj.transform, false);
			}
			this.m_tenShareButtonDummy.gameObject.SetActive(false);
			if (!this.m_isSingleSelect && this.m_cardPool != null && this.m_cardPool.Config.MissionCardPoolType == MissionCardPoolType.MissionCardPoolType_Hero)
			{
				this.m_tenShareButtonDummy.gameObject.SetActive(true);
			}
		}

		// Token: 0x06012DE2 RID: 77282 RVA: 0x004D3CCC File Offset: 0x004D1ECC
		private void CreateCardPoolTabs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCardPoolTabs_hotfix != null)
			{
				this.m_CreateCardPoolTabs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < this.m_cardPoolToggleGroupGo.transform.childCount; i++)
			{
				GameObject gameObject = this.m_cardPoolToggleGroupGo.transform.GetChild(i).gameObject;
				SummonToggleUIController component = this.m_cardPoolToggleGroupGo.transform.GetChild(i).GetComponent<SummonToggleUIController>();
				if (component != null && component.CardPool.Config.PoolType == CardPoolType.CardPoolType_ActivityCardPool)
				{
					list.Add(gameObject);
					if (this.m_toggleCtrlList.Contains(component))
					{
						this.m_toggleCtrlList.Remove(component);
					}
				}
			}
			foreach (GameObject obj in list)
			{
				UnityEngine.Object.Destroy(obj);
			}
			this.m_toggleCtrlList.Clear();
			SummonToggleUIController summonToggleUIController = this.m_ticketSummonToggle.gameObject.GetComponent<SummonToggleUIController>();
			if (summonToggleUIController == null)
			{
				summonToggleUIController = GameObjectUtility.AddControllerToGameObject<SummonToggleUIController>(this.m_ticketSummonToggle.gameObject);
				summonToggleUIController.EventOnToggleClick += this.SummonToggleCtrl_EventOnToggleClick;
			}
			summonToggleUIController.SetSummonToggleInfo(1);
			this.m_toggleCtrlList.Insert(0, summonToggleUIController);
			SummonToggleUIController summonToggleUIController2 = this.m_equipSummonToggle.gameObject.GetComponent<SummonToggleUIController>();
			if (summonToggleUIController2 == null)
			{
				summonToggleUIController2 = GameObjectUtility.AddControllerToGameObject<SummonToggleUIController>(this.m_equipSummonToggle.gameObject);
				summonToggleUIController2.EventOnToggleClick += this.SummonToggleCtrl_EventOnToggleClick;
			}
			summonToggleUIController2.SetSummonToggleInfo(3);
			this.m_toggleCtrlList.Insert(0, summonToggleUIController2);
			SummonToggleUIController summonToggleUIController3 = this.m_magicStoneSummonToggle.gameObject.GetComponent<SummonToggleUIController>();
			if (summonToggleUIController3 == null)
			{
				summonToggleUIController3 = GameObjectUtility.AddControllerToGameObject<SummonToggleUIController>(this.m_magicStoneSummonToggle.gameObject);
				summonToggleUIController3.EventOnToggleClick += this.SummonToggleCtrl_EventOnToggleClick;
			}
			summonToggleUIController3.SetSummonToggleInfo(2);
			this.m_toggleCtrlList.Insert(0, summonToggleUIController3);
			List<CardPool> activityCardPoolList = this.m_playerContext.GetActivityCardPoolList();
			foreach (CardPool cardPool in activityCardPoolList)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_summonToggleItemPrefab);
				SummonToggleUIController summonToggleUIController4 = GameObjectUtility.AddControllerToGameObject<SummonToggleUIController>(gameObject2);
				summonToggleUIController4.SetSummonToggleInfo(cardPool.PoolId);
				summonToggleUIController4.EventOnToggleClick += this.SummonToggleCtrl_EventOnToggleClick;
				gameObject2.transform.SetParent(this.m_cardPoolToggleGroupGo.transform, false);
				gameObject2.transform.SetAsFirstSibling();
				this.m_toggleCtrlList.Insert(0, summonToggleUIController4);
			}
		}

		// Token: 0x06012DE3 RID: 77283 RVA: 0x004D3FE8 File Offset: 0x004D21E8
		private void SummonToggleCtrl_EventOnToggleClick(SummonToggleUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SummonToggleCtrl_EventOnToggleClickSummonToggleUIController_hotfix != null)
			{
				this.m_SummonToggleCtrl_EventOnToggleClickSummonToggleUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl.CardPool.Config.PoolType == CardPoolType.CardPoolType_ActivityCardPool)
			{
				int num = this.m_playerContext.IsActivityCardPoolOnActivityTime(ctrl.CardPool.PoolId);
				if (num != 0)
				{
					this.m_cardPool = null;
					this.m_cardPoolId = 0;
					this.UpdateViewInSelectCard(0);
					CommonUIController.Instance.ShowErrorMessage(-1500, 2f, null, true);
					return;
				}
			}
			this.m_cardPoolId = ctrl.CardPool.PoolId;
			this.m_cardPool = ctrl.CardPool;
			this.SetValuesAfterToggleChanged();
		}

		// Token: 0x06012DE4 RID: 77284 RVA: 0x004D40DC File Offset: 0x004D22DC
		private void SetValuesAfterToggleChanged()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetValuesAfterToggleChanged_hotfix != null)
			{
				this.m_SetValuesAfterToggleChanged_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cardPool == null)
			{
				return;
			}
			this.m_tenSelectBtn3DEffect.SetActive(false);
			this.SetSelectButton(this.m_singleSelectBtnIconImg, this.m_singleSelectBtnTitleText, this.m_singleSelectBtnNumText, true);
			this.SetSelectButton(this.m_tenSelectBtnIconImg, this.m_tenSelectBtnTitleText, this.m_tenSelectBtnNumText, false);
			this.m_tenSelectBtn3DEffect.SetActive(true);
			this.m_adsImage.sprite = AssetUtility.Instance.GetSprite(this.m_cardPool.Config.AdsImage);
			this.m_adsImage.SetNativeSize();
			bool flag = this.m_cardPool.Config.PoolType == CardPoolType.CardPoolType_ActivityCardPool;
			if (flag)
			{
				DateTime operationEndTime = this.m_playerContext.FindOperationalActivityByActivityCardPoolId(this.m_cardPoolId).OperationEndTime;
				this.m_adsTimeText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ActivityCardPoolStopTime), operationEndTime.Year, operationEndTime.Month, operationEndTime.Day);
				this.m_adsTimeText.gameObject.SetActive(true);
			}
			else
			{
				this.m_adsTimeText.gameObject.SetActive(false);
			}
			this.m_activityDetailButton.gameObject.SetActive(!string.IsNullOrEmpty(this.m_cardPool.Config.CardPoolDetailDesc));
		}

		// Token: 0x06012DE5 RID: 77285 RVA: 0x004D4288 File Offset: 0x004D2488
		private void SetSelectButton(Image iconImage, Text titleText, Text numText, bool isSingle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectButtonImageTextTextBoolean_hotfix != null)
			{
				this.m_SetSelectButtonImageTextTextBoolean_hotfix.call(new object[]
				{
					this,
					iconImage,
					titleText,
					numText,
					isSingle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(this.m_cardPool.Config.TicketId);
			GameObject gameObject = Utility.FindChildGameObject(iconImage.gameObject, "U_crystal", true);
			if (gameObject != null)
			{
				gameObject.SetActive(false);
			}
			if (isSingle)
			{
				iconImage.sprite = AssetUtility.Instance.GetSprite(this.m_cardPool.Config.Icon);
				numText.text = "x1";
				titleText.text = configDataItemInfo.Name;
			}
			else
			{
				iconImage.sprite = AssetUtility.Instance.GetSprite(this.m_cardPool.Config.Icon);
				numText.text = "x10";
				titleText.text = configDataItemInfo.Name;
			}
		}

		// Token: 0x06012DE6 RID: 77286 RVA: 0x004D43E4 File Offset: 0x004D25E4
		private void OnActivityDetailButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActivityDetailButtonClick_hotfix != null)
			{
				this.m_OnActivityDetailButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowActivityDetail != null && this.m_cardPool != null)
			{
				this.EventOnShowActivityDetail(this.m_cardPool);
			}
		}

		// Token: 0x06012DE7 RID: 77287 RVA: 0x004D446C File Offset: 0x004D266C
		private void OnSingleSelectButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSingleSelectButtonClick_hotfix != null)
			{
				this.m_OnSingleSelectButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSingleSelect = true;
			if (this.EventOnSelectCard != null)
			{
				int num = this.m_playerContext.CanSelectCard(this.m_cardPoolId, this.m_isSingleSelect, true);
				if (num == -1500)
				{
					this.m_cardPool = null;
					this.m_cardPoolId = 0;
					this.UpdateViewInSelectCard(0);
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
					return;
				}
				if (this.m_cardPool.Config.PoolType == CardPoolType.CardPoolType_FreeCardPool)
				{
					if (num == -1502)
					{
						CommonUIController.Instance.ShowErrorMessage(-1502, 2f, null, true);
					}
					else
					{
						this.EventOnSelectCard(this.m_cardPoolId, this.m_isSingleSelect);
					}
				}
				else if (num == -1515)
				{
					this.ShowChangeCrystalToTicketPanel();
				}
				else if (num == -1514)
				{
					this.ShowCrystalAndTicketNotEnoughPanel();
				}
				else if (num == -401)
				{
					if (this.EventOnCrystalNotEnough != null)
					{
						this.EventOnCrystalNotEnough();
					}
				}
				else
				{
					this.EventOnSelectCard(this.m_cardPoolId, this.m_isSingleSelect);
				}
			}
		}

		// Token: 0x06012DE8 RID: 77288 RVA: 0x004D45EC File Offset: 0x004D27EC
		private void OnTenSelectButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTenSelectButtonClick_hotfix != null)
			{
				this.m_OnTenSelectButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSingleSelect = false;
			if (this.EventOnSelectCard != null)
			{
				int num = this.m_playerContext.CanSelectCard(this.m_cardPoolId, this.m_isSingleSelect, true);
				if (num == -1500)
				{
					this.m_cardPool = null;
					this.m_cardPoolId = 0;
					this.UpdateViewInSelectCard(0);
					CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
					return;
				}
				if (this.m_cardPool.Config.PoolType == CardPoolType.CardPoolType_FreeCardPool)
				{
					if (num == -1502)
					{
						CommonUIController.Instance.ShowErrorMessage(-1502, 2f, null, true);
					}
					else
					{
						this.EventOnSelectCard(this.m_cardPoolId, this.m_isSingleSelect);
					}
				}
				else if (num == -1515)
				{
					this.ShowChangeCrystalToTicketPanel();
				}
				else if (num == -1514)
				{
					this.ShowCrystalAndTicketNotEnoughPanel();
				}
				else if (num == -401)
				{
					if (this.EventOnCrystalNotEnough != null)
					{
						this.EventOnCrystalNotEnough();
					}
				}
				else
				{
					this.EventOnSelectCard(this.m_cardPoolId, this.m_isSingleSelect);
				}
			}
		}

		// Token: 0x06012DE9 RID: 77289 RVA: 0x004D476C File Offset: 0x004D296C
		private void OnSelectAgainButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectAgainButtonClick_hotfix != null)
			{
				this.m_OnSelectAgainButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = this.m_playerContext.CanSelectCard(this.m_cardPoolId, this.m_isSingleSelect, true);
			if (result == -500)
			{
				if (this.EventOnBagCapcityNotEnough != null)
				{
					this.EventOnBagCapcityNotEnough();
				}
				return;
			}
			if (result == -401)
			{
				if (this.EventOnCrystalNotEnough != null)
				{
					this.EventOnCrystalNotEnough();
				}
				return;
			}
			if (this.m_cardPool.Config.PoolType != CardPoolType.CardPoolType_FreeCardPool)
			{
				if (result == -1515)
				{
					this.ShowChangeCrystalToTicketPanel();
					return;
				}
				if (result == -1514)
				{
					this.ShowCrystalAndTicketNotEnoughPanel();
					return;
				}
			}
			else if (result == -1502)
			{
				CommonUIController.Instance.ShowErrorMessage(-1502, 2f, null, true);
				return;
			}
			if (result == -1500)
			{
				CommonUIStateController component = this.m_tenSelectPanel.GetComponent<CommonUIStateController>();
				UIUtility.SetUIStateClose(component, "Close", delegate
				{
					this.CloseShowSelectRewardsPanel();
					this.m_cardPool = null;
					this.m_cardPoolId = 0;
					this.UpdateViewInSelectCard(0);
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}, true, true);
			}
			if (result != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				return;
			}
			if (this.m_isSingleSelect)
			{
				this.OnSingleSelectButtonClick();
			}
			else
			{
				this.OnTenSelectButtonClick();
			}
		}

		// Token: 0x06012DEA RID: 77290 RVA: 0x004D492C File Offset: 0x004D2B2C
		public void CloseTenSelectPanel(Action action = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseTenSelectPanelAction_hotfix != null)
			{
				this.m_CloseTenSelectPanelAction_hotfix.call(new object[]
				{
					this,
					action2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action action = action2;
			SelectCardUIController $this = this;
			if (this.m_tenSelectPanel.activeSelf)
			{
				CommonUIStateController component = this.m_tenSelectPanel.GetComponent<CommonUIStateController>();
				UIUtility.SetUIStateClose(component, "Close", delegate
				{
					$this.m_tenSelectPanel.SetActive(false);
					if (action != null)
					{
						action();
					}
				}, false, true);
			}
		}

		// Token: 0x06012DEB RID: 77291 RVA: 0x004D49E8 File Offset: 0x004D2BE8
		private void ShowChangeCrystalToTicketPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChangeCrystalToTicketPanel_hotfix != null)
			{
				this.m_ShowChangeCrystalToTicketPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changeCrystalToTicketPanel.SetActive(true);
			CommonUIStateController component = this.m_changeCrystalToTicketPanel.GetComponent<CommonUIStateController>();
			component.SetToUIState("Show", false, true);
			int bagItemCountByType = this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, 4001);
			string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_ChangeCrystalToTicketTip);
			int num = 1;
			int crystalCost = this.m_cardPool.Config.CrystalCost;
			if (!this.m_isSingleSelect)
			{
				num = 10 - bagItemCountByType;
			}
			this.m_changeCrystalToTicketPanelTip.text = string.Format(format, crystalCost * num, num);
		}

		// Token: 0x06012DEC RID: 77292 RVA: 0x004D4AD4 File Offset: 0x004D2CD4
		private void ChangeCrystalToTicketPanelCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeCrystalToTicketPanelCancelButtonClick_hotfix != null)
			{
				this.m_ChangeCrystalToTicketPanelCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseChangeCrystalToTicketPanel();
		}

		// Token: 0x06012DED RID: 77293 RVA: 0x004D4B3C File Offset: 0x004D2D3C
		private void CloseChangeCrystalToTicketPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseChangeCrystalToTicketPanel_hotfix != null)
			{
				this.m_CloseChangeCrystalToTicketPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_changeCrystalToTicketPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_changeCrystalToTicketPanel.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x06012DEE RID: 77294 RVA: 0x004D4BD0 File Offset: 0x004D2DD0
		private void ChangeCrystalToTicketPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeCrystalToTicketPanelConfirmButtonClick_hotfix != null)
			{
				this.m_ChangeCrystalToTicketPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EventOnSelectCard(this.m_cardPoolId, this.m_isSingleSelect);
			this.CloseChangeCrystalToTicketPanel();
			if (this.m_afterSelectPanel.activeInHierarchy)
			{
				this.CloseShowSelectRewardsPanel();
			}
		}

		// Token: 0x06012DEF RID: 77295 RVA: 0x004D4C64 File Offset: 0x004D2E64
		private void ShowCrystalAndTicketNotEnoughPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCrystalAndTicketNotEnoughPanel_hotfix != null)
			{
				this.m_ShowCrystalAndTicketNotEnoughPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_crystalAndTicketNotEnoughPanel.SetActive(true);
			CommonUIStateController component = this.m_crystalAndTicketNotEnoughPanel.GetComponent<CommonUIStateController>();
			component.SetToUIState("Show", false, true);
			string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_CrystalAndTicketNotEnoughTip);
			this.m_crystalAndTicketNotEnoughPanelTip.text = text;
		}

		// Token: 0x06012DF0 RID: 77296 RVA: 0x004D4D08 File Offset: 0x004D2F08
		private void CrystalAndTicketNotEnoughPanelCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CrystalAndTicketNotEnoughPanelCancelButtonClick_hotfix != null)
			{
				this.m_CrystalAndTicketNotEnoughPanelCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseCrystalAndTicketNotEnoughPanel();
			if (this.m_afterSelectPanel.activeInHierarchy)
			{
				this.CloseShowSelectRewardsPanel();
			}
		}

		// Token: 0x06012DF1 RID: 77297 RVA: 0x004D4D84 File Offset: 0x004D2F84
		private void CloseCrystalAndTicketNotEnoughPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseCrystalAndTicketNotEnoughPanel_hotfix != null)
			{
				this.m_CloseCrystalAndTicketNotEnoughPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_crystalAndTicketNotEnoughPanel.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_crystalAndTicketNotEnoughPanel.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x06012DF2 RID: 77298 RVA: 0x004D4E18 File Offset: 0x004D3018
		private void CrystalAndTicketNotEnoughPanelConfirmButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CrystalAndTicketNotEnoughPanelConfirmButtonClick_hotfix != null)
			{
				this.m_CrystalAndTicketNotEnoughPanelConfirmButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.CloseCrystalAndTicketNotEnoughPanel();
			if (this.EventOnAddCrystal != null)
			{
				this.EventOnAddCrystal();
			}
		}

		// Token: 0x06012DF3 RID: 77299 RVA: 0x004D4E94 File Offset: 0x004D3094
		private void OnBuyDiamondButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyDiamondButtonClick_hotfix != null)
			{
				this.m_OnBuyDiamondButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06012DF4 RID: 77300 RVA: 0x004D4EF4 File Offset: 0x004D30F4
		private void OnAddCrystalBtnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddCrystalBtnClick_hotfix != null)
			{
				this.m_OnAddCrystalBtnClick_hotfix.call(new object[]
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

		// Token: 0x06012DF5 RID: 77301 RVA: 0x004D4F6C File Offset: 0x004D316C
		private void OnAddCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddCrystal_hotfix != null)
			{
				this.m_OnAddCrystal_hotfix.call(new object[]
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
			string cmd = ProjectLPlayerContext.GenerateAddItemGmCommand(GoodsType.GoodsType_Crystal, 0, 100000);
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateViewInSelectCard(0);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x06012DF6 RID: 77302 RVA: 0x004D5008 File Offset: 0x004D3208
		private void SkipShowRewardEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkipShowRewardEffect_hotfix != null)
			{
				this.m_SkipShowRewardEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StopAllCoroutines();
			this.m_singleSelectPanel.SetActive(false);
			this.m_selectSkipButton.gameObject.SetActive(false);
			this.m_singleSelectArrowButton.SetActive(false);
			this.m_singleSelectOpenNoticePanelGo.SetActive(false);
			this.m_singleSelectOpenNoticePanelImage.SetActive(false);
			this.Close3DUIEffect();
			CommonUIController.Instance.SetTouchFxStyle(0);
			base.StartCoroutine(this.PlayTotalRewardsEffect());
		}

		// Token: 0x06012DF7 RID: 77303 RVA: 0x004D50D0 File Offset: 0x004D32D0
		private void Close3DUIEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close3DUIEffect_hotfix != null)
			{
				this.m_Close3DUIEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectCardBackground3DController.ShowClockEffect(false);
			this.m_selectCardBackground3DController.ShowLightEffect(false);
			this.m_selectCardBackground3DController.ShowGetEffect(false, 2);
			this.m_selectCardBackground3DController.ShowGetEffect(false, 3);
			this.m_selectCardBackground3DController.ShowGetEffect(false, 4);
		}

		// Token: 0x06012DF8 RID: 77304 RVA: 0x004D5170 File Offset: 0x004D3370
		private void CloseShowSelectRewardsPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseShowSelectRewardsPanel_hotfix != null)
			{
				this.m_CloseShowSelectRewardsPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Close3DUIEffect();
			this.m_afterSelectPanel.SetActive(false);
			this.m_tenSelectPanel.SetActive(false);
			this.m_singleSelectPanel.SetActive(false);
			this.m_mainUIGo.SetActive(true);
			this.Open();
		}

		// Token: 0x06012DF9 RID: 77305 RVA: 0x004D520C File Offset: 0x004D340C
		public bool IsShowSelectCardResult()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsShowSelectCardResult_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsShowSelectCardResult_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_tenSelectPanel.activeSelf;
		}

		// Token: 0x06012DFA RID: 77306 RVA: 0x004D5284 File Offset: 0x004D3484
		private void ShowDetailScrollView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDetailScrollView_hotfix != null)
			{
				this.m_ShowDetailScrollView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSelectProbabilityInfo configDataSelectProbabilityInfo = this.m_configDataLoader.GetConfigDataSelectProbabilityInfo(this.m_cardPool.Config.SelectProbabilityInfoID);
			this.m_detailWeightTitleText.text = configDataSelectProbabilityInfo.Name;
			this.m_detailSSRWeightText.text = configDataSelectProbabilityInfo.SSRCardProbability;
			this.m_detailSRWeightText.text = configDataSelectProbabilityInfo.SRCardProbability;
			this.m_detailRWeightText.text = configDataSelectProbabilityInfo.RCardProbability;
			GameObjectUtility.DestroyChildren(this.m_detailScrollViewContent);
			ConfigDataSelectContentInfo configDataSelectContentInfo = this.m_configDataLoader.GetConfigDataSelectContentInfo(this.m_cardPool.Config.SelectContentInfoID);
			this.m_detailScrollViewContentTitleText.text = configDataSelectContentInfo.Name;
			foreach (PoolContentItemData item in configDataSelectContentInfo.PoolContent)
			{
				this.CreatePoolItemPrefab(item);
			}
		}

		// Token: 0x06012DFB RID: 77307 RVA: 0x004D53CC File Offset: 0x004D35CC
		private void CreatePoolItemPrefab(PoolContentItemData item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatePoolItemPrefabPoolContentItemData_hotfix != null)
			{
				this.m_CreatePoolItemPrefabPoolContentItemData_hotfix.call(new object[]
				{
					this,
					item
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_poolItemWithRankPrefab);
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				Transform child = gameObject.transform.GetChild(i);
				if (child.name == "NameText")
				{
					child.gameObject.GetComponent<Text>().text = UIUtility.GetGoodsName((GoodsType)item.GoodsType, item.GoodsId);
				}
			}
			CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
			if (item.Rank == "R")
			{
				component.SetToUIState("R", false, true);
			}
			else if (item.Rank == "SR")
			{
				component.SetToUIState("SR", false, true);
			}
			else if (item.Rank == "SSR")
			{
				component.SetToUIState("SSR", false, true);
			}
			gameObject.SetActive(true);
			gameObject.transform.SetParent(this.m_detailScrollViewContent.transform, false);
		}

		// Token: 0x06012DFC RID: 77308 RVA: 0x004D553C File Offset: 0x004D373C
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
			if (this.EventOnShowSelectCardHelp != null)
			{
				this.EventOnShowSelectCardHelp();
			}
		}

		// Token: 0x06012DFD RID: 77309 RVA: 0x004D55B4 File Offset: 0x004D37B4
		private void OnCloseDetailPanelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseDetailPanelButtonClick_hotfix != null)
			{
				this.m_OnCloseDetailPanelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_detailPanelStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_detailScrollRect.normalizedPosition = Vector2.one;
				this.m_detailPanelObj.SetActive(false);
			});
			this.m_detailPanelStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x06012DFE RID: 77310 RVA: 0x004D5644 File Offset: 0x004D3844
		private void OnArchiveButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArchiveButtonClick_hotfix != null)
			{
				this.m_OnArchiveButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnArchive != null)
			{
				this.EventOnArchive();
			}
		}

		// Token: 0x06012DFF RID: 77311 RVA: 0x004D56BC File Offset: 0x004D38BC
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
			this.m_cardPoolId = 0;
			this.m_cardPool = null;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06012E00 RID: 77312 RVA: 0x004D5740 File Offset: 0x004D3940
		private void OnWeiBoShareOnceClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeiBoShareOnceClick_hotfix != null)
			{
				this.m_OnWeiBoShareOnceClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.CaptureOnceFrame(3));
		}

		// Token: 0x06012E01 RID: 77313 RVA: 0x004D57B0 File Offset: 0x004D39B0
		private void OnWeChatShareOnceClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeChatShareOnceClick_hotfix != null)
			{
				this.m_OnWeChatShareOnceClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.CaptureOnceFrame(2));
		}

		// Token: 0x06012E02 RID: 77314 RVA: 0x004D5820 File Offset: 0x004D3A20
		private void OnWeiBoShareTenClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeiBoShareTenClick_hotfix != null)
			{
				this.m_OnWeiBoShareTenClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.CaptureTenFrame(3));
			if (this.EventOnWeiBoShareTen != null)
			{
				this.EventOnWeiBoShareTen();
			}
		}

		// Token: 0x06012E03 RID: 77315 RVA: 0x004D58A4 File Offset: 0x004D3AA4
		private void OnWeChatShareTenClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeChatShareTenClick_hotfix != null)
			{
				this.m_OnWeChatShareTenClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.CaptureTenFrame(2));
			if (this.EventOnWeChatShareTen != null)
			{
				this.EventOnWeChatShareTen();
			}
		}

		// Token: 0x06012E04 RID: 77316 RVA: 0x004D5928 File Offset: 0x004D3B28
		[DebuggerHidden]
		private IEnumerator CaptureOnceFrame(int sharePlatform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaptureOnceFrameInt32_hotfix != null)
			{
				return (IEnumerator)this.m_CaptureOnceFrameInt32_hotfix.call(new object[]
				{
					this,
					sharePlatform
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SelectCardUIController.<CaptureOnceFrame>c__Iterator4 <CaptureOnceFrame>c__Iterator = new SelectCardUIController.<CaptureOnceFrame>c__Iterator4();
			<CaptureOnceFrame>c__Iterator.sharePlatform = sharePlatform;
			<CaptureOnceFrame>c__Iterator.$this = this;
			return <CaptureOnceFrame>c__Iterator;
		}

		// Token: 0x06012E05 RID: 77317 RVA: 0x004D59BC File Offset: 0x004D3BBC
		[DebuggerHidden]
		private IEnumerator CaptureTenFrame(int sharePlatform)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaptureTenFrameInt32_hotfix != null)
			{
				return (IEnumerator)this.m_CaptureTenFrameInt32_hotfix.call(new object[]
				{
					this,
					sharePlatform
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SelectCardUIController.<CaptureTenFrame>c__Iterator5 <CaptureTenFrame>c__Iterator = new SelectCardUIController.<CaptureTenFrame>c__Iterator5();
			<CaptureTenFrame>c__Iterator.sharePlatform = sharePlatform;
			<CaptureTenFrame>c__Iterator.$this = this;
			return <CaptureTenFrame>c__Iterator;
		}

		// Token: 0x14000418 RID: 1048
		// (add) Token: 0x06012E06 RID: 77318 RVA: 0x004D5A50 File Offset: 0x004D3C50
		// (remove) Token: 0x06012E07 RID: 77319 RVA: 0x004D5AEC File Offset: 0x004D3CEC
		public event Action EventOnWeiBoShareTen
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWeiBoShareTenAction_hotfix != null)
				{
					this.m_add_EventOnWeiBoShareTenAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnWeiBoShareTen;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnWeiBoShareTen, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWeiBoShareTenAction_hotfix != null)
				{
					this.m_remove_EventOnWeiBoShareTenAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnWeiBoShareTen;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnWeiBoShareTen, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000419 RID: 1049
		// (add) Token: 0x06012E08 RID: 77320 RVA: 0x004D5B88 File Offset: 0x004D3D88
		// (remove) Token: 0x06012E09 RID: 77321 RVA: 0x004D5C24 File Offset: 0x004D3E24
		public event Action EventOnWeChatShareTen
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWeChatShareTenAction_hotfix != null)
				{
					this.m_add_EventOnWeChatShareTenAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnWeChatShareTen;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnWeChatShareTen, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWeChatShareTenAction_hotfix != null)
				{
					this.m_remove_EventOnWeChatShareTenAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnWeChatShareTen;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnWeChatShareTen, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400041A RID: 1050
		// (add) Token: 0x06012E0A RID: 77322 RVA: 0x004D5CC0 File Offset: 0x004D3EC0
		// (remove) Token: 0x06012E0B RID: 77323 RVA: 0x004D5D5C File Offset: 0x004D3F5C
		public event Action EventOnArchive
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnArchiveAction_hotfix != null)
				{
					this.m_add_EventOnArchiveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnArchive;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnArchive, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnArchiveAction_hotfix != null)
				{
					this.m_remove_EventOnArchiveAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnArchive;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnArchive, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400041B RID: 1051
		// (add) Token: 0x06012E0C RID: 77324 RVA: 0x004D5DF8 File Offset: 0x004D3FF8
		// (remove) Token: 0x06012E0D RID: 77325 RVA: 0x004D5E94 File Offset: 0x004D4094
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

		// Token: 0x1400041C RID: 1052
		// (add) Token: 0x06012E0E RID: 77326 RVA: 0x004D5F30 File Offset: 0x004D4130
		// (remove) Token: 0x06012E0F RID: 77327 RVA: 0x004D5FCC File Offset: 0x004D41CC
		public event Action<int, bool> EventOnSelectCard
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectCardAction`2_hotfix != null)
				{
					this.m_add_EventOnSelectCardAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool> action = this.EventOnSelectCard;
				Action<int, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool>>(ref this.EventOnSelectCard, (Action<int, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectCardAction`2_hotfix != null)
				{
					this.m_remove_EventOnSelectCardAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool> action = this.EventOnSelectCard;
				Action<int, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool>>(ref this.EventOnSelectCard, (Action<int, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400041D RID: 1053
		// (add) Token: 0x06012E10 RID: 77328 RVA: 0x004D6068 File Offset: 0x004D4268
		// (remove) Token: 0x06012E11 RID: 77329 RVA: 0x004D6104 File Offset: 0x004D4304
		public event Action EventOnShowSelectCardHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowSelectCardHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowSelectCardHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSelectCardHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSelectCardHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowSelectCardHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowSelectCardHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSelectCardHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSelectCardHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400041E RID: 1054
		// (add) Token: 0x06012E12 RID: 77330 RVA: 0x004D61A0 File Offset: 0x004D43A0
		// (remove) Token: 0x06012E13 RID: 77331 RVA: 0x004D623C File Offset: 0x004D443C
		public event Action<CardPool> EventOnShowActivityDetail
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowActivityDetailAction`1_hotfix != null)
				{
					this.m_add_EventOnShowActivityDetailAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<CardPool> action = this.EventOnShowActivityDetail;
				Action<CardPool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CardPool>>(ref this.EventOnShowActivityDetail, (Action<CardPool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowActivityDetailAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowActivityDetailAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<CardPool> action = this.EventOnShowActivityDetail;
				Action<CardPool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CardPool>>(ref this.EventOnShowActivityDetail, (Action<CardPool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400041F RID: 1055
		// (add) Token: 0x06012E14 RID: 77332 RVA: 0x004D62D8 File Offset: 0x004D44D8
		// (remove) Token: 0x06012E15 RID: 77333 RVA: 0x004D6374 File Offset: 0x004D4574
		public event Action EventOnBagCapcityNotEnough
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBagCapcityNotEnoughAction_hotfix != null)
				{
					this.m_add_EventOnBagCapcityNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBagCapcityNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBagCapcityNotEnough, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBagCapcityNotEnoughAction_hotfix != null)
				{
					this.m_remove_EventOnBagCapcityNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBagCapcityNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBagCapcityNotEnough, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000420 RID: 1056
		// (add) Token: 0x06012E16 RID: 77334 RVA: 0x004D6410 File Offset: 0x004D4610
		// (remove) Token: 0x06012E17 RID: 77335 RVA: 0x004D64AC File Offset: 0x004D46AC
		public event Action EventOnCrystalNotEnough
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_add_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCrystalNotEnoughAction_hotfix != null)
				{
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCrystalNotEnough;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCrystalNotEnough, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000421 RID: 1057
		// (add) Token: 0x06012E18 RID: 77336 RVA: 0x004D6548 File Offset: 0x004D4748
		// (remove) Token: 0x06012E19 RID: 77337 RVA: 0x004D65E4 File Offset: 0x004D47E4
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

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x06012E1A RID: 77338 RVA: 0x004D6680 File Offset: 0x004D4880
		// (set) Token: 0x06012E1B RID: 77339 RVA: 0x004D66A0 File Offset: 0x004D48A0
		[DoNotToLua]
		public new SelectCardUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelectCardUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012E1C RID: 77340 RVA: 0x004D66AC File Offset: 0x004D48AC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012E1D RID: 77341 RVA: 0x004D66B8 File Offset: 0x004D48B8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012E1E RID: 77342 RVA: 0x004D66C0 File Offset: 0x004D48C0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012E1F RID: 77343 RVA: 0x004D66C8 File Offset: 0x004D48C8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012E20 RID: 77344 RVA: 0x004D66DC File Offset: 0x004D48DC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012E21 RID: 77345 RVA: 0x004D66E4 File Offset: 0x004D48E4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012E22 RID: 77346 RVA: 0x004D66F0 File Offset: 0x004D48F0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012E23 RID: 77347 RVA: 0x004D66FC File Offset: 0x004D48FC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012E24 RID: 77348 RVA: 0x004D6708 File Offset: 0x004D4908
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012E25 RID: 77349 RVA: 0x004D6714 File Offset: 0x004D4914
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012E26 RID: 77350 RVA: 0x004D6720 File Offset: 0x004D4920
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012E27 RID: 77351 RVA: 0x004D672C File Offset: 0x004D492C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012E28 RID: 77352 RVA: 0x004D6738 File Offset: 0x004D4938
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012E29 RID: 77353 RVA: 0x004D6744 File Offset: 0x004D4944
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012E2A RID: 77354 RVA: 0x004D6750 File Offset: 0x004D4950
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012E2B RID: 77355 RVA: 0x004D6758 File Offset: 0x004D4958
		private void __callDele_EventOnWeiBoShareTen()
		{
			Action eventOnWeiBoShareTen = this.EventOnWeiBoShareTen;
			if (eventOnWeiBoShareTen != null)
			{
				eventOnWeiBoShareTen();
			}
		}

		// Token: 0x06012E2C RID: 77356 RVA: 0x004D6778 File Offset: 0x004D4978
		private void __clearDele_EventOnWeiBoShareTen()
		{
			this.EventOnWeiBoShareTen = null;
		}

		// Token: 0x06012E2D RID: 77357 RVA: 0x004D6784 File Offset: 0x004D4984
		private void __callDele_EventOnWeChatShareTen()
		{
			Action eventOnWeChatShareTen = this.EventOnWeChatShareTen;
			if (eventOnWeChatShareTen != null)
			{
				eventOnWeChatShareTen();
			}
		}

		// Token: 0x06012E2E RID: 77358 RVA: 0x004D67A4 File Offset: 0x004D49A4
		private void __clearDele_EventOnWeChatShareTen()
		{
			this.EventOnWeChatShareTen = null;
		}

		// Token: 0x06012E2F RID: 77359 RVA: 0x004D67B0 File Offset: 0x004D49B0
		private void __callDele_EventOnArchive()
		{
			Action eventOnArchive = this.EventOnArchive;
			if (eventOnArchive != null)
			{
				eventOnArchive();
			}
		}

		// Token: 0x06012E30 RID: 77360 RVA: 0x004D67D0 File Offset: 0x004D49D0
		private void __clearDele_EventOnArchive()
		{
			this.EventOnArchive = null;
		}

		// Token: 0x06012E31 RID: 77361 RVA: 0x004D67DC File Offset: 0x004D49DC
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06012E32 RID: 77362 RVA: 0x004D67FC File Offset: 0x004D49FC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06012E33 RID: 77363 RVA: 0x004D6808 File Offset: 0x004D4A08
		private void __callDele_EventOnSelectCard(int arg1, bool arg2)
		{
			Action<int, bool> eventOnSelectCard = this.EventOnSelectCard;
			if (eventOnSelectCard != null)
			{
				eventOnSelectCard(arg1, arg2);
			}
		}

		// Token: 0x06012E34 RID: 77364 RVA: 0x004D682C File Offset: 0x004D4A2C
		private void __clearDele_EventOnSelectCard(int arg1, bool arg2)
		{
			this.EventOnSelectCard = null;
		}

		// Token: 0x06012E35 RID: 77365 RVA: 0x004D6838 File Offset: 0x004D4A38
		private void __callDele_EventOnShowSelectCardHelp()
		{
			Action eventOnShowSelectCardHelp = this.EventOnShowSelectCardHelp;
			if (eventOnShowSelectCardHelp != null)
			{
				eventOnShowSelectCardHelp();
			}
		}

		// Token: 0x06012E36 RID: 77366 RVA: 0x004D6858 File Offset: 0x004D4A58
		private void __clearDele_EventOnShowSelectCardHelp()
		{
			this.EventOnShowSelectCardHelp = null;
		}

		// Token: 0x06012E37 RID: 77367 RVA: 0x004D6864 File Offset: 0x004D4A64
		private void __callDele_EventOnShowActivityDetail(CardPool obj)
		{
			Action<CardPool> eventOnShowActivityDetail = this.EventOnShowActivityDetail;
			if (eventOnShowActivityDetail != null)
			{
				eventOnShowActivityDetail(obj);
			}
		}

		// Token: 0x06012E38 RID: 77368 RVA: 0x004D6888 File Offset: 0x004D4A88
		private void __clearDele_EventOnShowActivityDetail(CardPool obj)
		{
			this.EventOnShowActivityDetail = null;
		}

		// Token: 0x06012E39 RID: 77369 RVA: 0x004D6894 File Offset: 0x004D4A94
		private void __callDele_EventOnBagCapcityNotEnough()
		{
			Action eventOnBagCapcityNotEnough = this.EventOnBagCapcityNotEnough;
			if (eventOnBagCapcityNotEnough != null)
			{
				eventOnBagCapcityNotEnough();
			}
		}

		// Token: 0x06012E3A RID: 77370 RVA: 0x004D68B4 File Offset: 0x004D4AB4
		private void __clearDele_EventOnBagCapcityNotEnough()
		{
			this.EventOnBagCapcityNotEnough = null;
		}

		// Token: 0x06012E3B RID: 77371 RVA: 0x004D68C0 File Offset: 0x004D4AC0
		private void __callDele_EventOnCrystalNotEnough()
		{
			Action eventOnCrystalNotEnough = this.EventOnCrystalNotEnough;
			if (eventOnCrystalNotEnough != null)
			{
				eventOnCrystalNotEnough();
			}
		}

		// Token: 0x06012E3C RID: 77372 RVA: 0x004D68E0 File Offset: 0x004D4AE0
		private void __clearDele_EventOnCrystalNotEnough()
		{
			this.EventOnCrystalNotEnough = null;
		}

		// Token: 0x06012E3D RID: 77373 RVA: 0x004D68EC File Offset: 0x004D4AEC
		private void __callDele_EventOnAddCrystal()
		{
			Action eventOnAddCrystal = this.EventOnAddCrystal;
			if (eventOnAddCrystal != null)
			{
				eventOnAddCrystal();
			}
		}

		// Token: 0x06012E3E RID: 77374 RVA: 0x004D690C File Offset: 0x004D4B0C
		private void __clearDele_EventOnAddCrystal()
		{
			this.EventOnAddCrystal = null;
		}

		// Token: 0x06012E43 RID: 77379 RVA: 0x004D699C File Offset: 0x004D4B9C
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
					this.m_UpdateViewInSelectCardInt32_hotfix = (luaObj.RawGet("UpdateViewInSelectCard") as LuaFunction);
					this.m_UpdateSharePlayerInfo_hotfix = (luaObj.RawGet("UpdateSharePlayerInfo") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SetShareTenSelectCardUIControllerShareTenSelectCardUIController_hotfix = (luaObj.RawGet("SetShareTenSelectCardUIController") as LuaFunction);
					this.m_ShowSelectCardRewardsList`1SelectCardBackground3DController_hotfix = (luaObj.RawGet("ShowSelectCardRewards") as LuaFunction);
					this.m_PlayRewardsEffectList`1_hotfix = (luaObj.RawGet("PlayRewardsEffect") as LuaFunction);
					this.m_PlaySingleRewardEffectGoodsBooleanInt32Int32Int32_hotfix = (luaObj.RawGet("PlaySingleRewardEffect") as LuaFunction);
					this.m_StopClockEffectSoundOnSkipButtonClick_hotfix = (luaObj.RawGet("StopClockEffectSoundOnSkipButtonClick") as LuaFunction);
					this.m_AfterShowClockEffectFinishedGoodsInt32Int32_hotfix = (luaObj.RawGet("AfterShowClockEffectFinished") as LuaFunction);
					this.m_OnClockButtonDragGameObject_hotfix = (luaObj.RawGet("OnClockButtonDrag") as LuaFunction);
					this.m_OnContinueButtonClick_hotfix = (luaObj.RawGet("OnContinueButtonClick") as LuaFunction);
					this.m_PlayTotalRewardsEffect_hotfix = (luaObj.RawGet("PlayTotalRewardsEffect") as LuaFunction);
					this.m_SetAfterSelectCurrecyPanel_hotfix = (luaObj.RawGet("SetAfterSelectCurrecyPanel") as LuaFunction);
					this.m_SetSingleSelectRewardInfoGoodsInt32Int32_hotfix = (luaObj.RawGet("SetSingleSelectRewardInfo") as LuaFunction);
					this.m_SetTenSelectRewardsInfoList`1_hotfix = (luaObj.RawGet("SetTenSelectRewardsInfo") as LuaFunction);
					this.m_CreateCardPoolTabs_hotfix = (luaObj.RawGet("CreateCardPoolTabs") as LuaFunction);
					this.m_SummonToggleCtrl_EventOnToggleClickSummonToggleUIController_hotfix = (luaObj.RawGet("SummonToggleCtrl_EventOnToggleClick") as LuaFunction);
					this.m_SetValuesAfterToggleChanged_hotfix = (luaObj.RawGet("SetValuesAfterToggleChanged") as LuaFunction);
					this.m_SetSelectButtonImageTextTextBoolean_hotfix = (luaObj.RawGet("SetSelectButton") as LuaFunction);
					this.m_OnActivityDetailButtonClick_hotfix = (luaObj.RawGet("OnActivityDetailButtonClick") as LuaFunction);
					this.m_OnSingleSelectButtonClick_hotfix = (luaObj.RawGet("OnSingleSelectButtonClick") as LuaFunction);
					this.m_OnTenSelectButtonClick_hotfix = (luaObj.RawGet("OnTenSelectButtonClick") as LuaFunction);
					this.m_OnSelectAgainButtonClick_hotfix = (luaObj.RawGet("OnSelectAgainButtonClick") as LuaFunction);
					this.m_CloseTenSelectPanelAction_hotfix = (luaObj.RawGet("CloseTenSelectPanel") as LuaFunction);
					this.m_ShowChangeCrystalToTicketPanel_hotfix = (luaObj.RawGet("ShowChangeCrystalToTicketPanel") as LuaFunction);
					this.m_ChangeCrystalToTicketPanelCancelButtonClick_hotfix = (luaObj.RawGet("ChangeCrystalToTicketPanelCancelButtonClick") as LuaFunction);
					this.m_CloseChangeCrystalToTicketPanel_hotfix = (luaObj.RawGet("CloseChangeCrystalToTicketPanel") as LuaFunction);
					this.m_ChangeCrystalToTicketPanelConfirmButtonClick_hotfix = (luaObj.RawGet("ChangeCrystalToTicketPanelConfirmButtonClick") as LuaFunction);
					this.m_ShowCrystalAndTicketNotEnoughPanel_hotfix = (luaObj.RawGet("ShowCrystalAndTicketNotEnoughPanel") as LuaFunction);
					this.m_CrystalAndTicketNotEnoughPanelCancelButtonClick_hotfix = (luaObj.RawGet("CrystalAndTicketNotEnoughPanelCancelButtonClick") as LuaFunction);
					this.m_CloseCrystalAndTicketNotEnoughPanel_hotfix = (luaObj.RawGet("CloseCrystalAndTicketNotEnoughPanel") as LuaFunction);
					this.m_CrystalAndTicketNotEnoughPanelConfirmButtonClick_hotfix = (luaObj.RawGet("CrystalAndTicketNotEnoughPanelConfirmButtonClick") as LuaFunction);
					this.m_OnBuyDiamondButtonClick_hotfix = (luaObj.RawGet("OnBuyDiamondButtonClick") as LuaFunction);
					this.m_OnAddCrystalBtnClick_hotfix = (luaObj.RawGet("OnAddCrystalBtnClick") as LuaFunction);
					this.m_OnAddCrystal_hotfix = (luaObj.RawGet("OnAddCrystal") as LuaFunction);
					this.m_SkipShowRewardEffect_hotfix = (luaObj.RawGet("SkipShowRewardEffect") as LuaFunction);
					this.m_Close3DUIEffect_hotfix = (luaObj.RawGet("Close3DUIEffect") as LuaFunction);
					this.m_CloseShowSelectRewardsPanel_hotfix = (luaObj.RawGet("CloseShowSelectRewardsPanel") as LuaFunction);
					this.m_IsShowSelectCardResult_hotfix = (luaObj.RawGet("IsShowSelectCardResult") as LuaFunction);
					this.m_ShowDetailScrollView_hotfix = (luaObj.RawGet("ShowDetailScrollView") as LuaFunction);
					this.m_CreatePoolItemPrefabPoolContentItemData_hotfix = (luaObj.RawGet("CreatePoolItemPrefab") as LuaFunction);
					this.m_OnDetailButtonClick_hotfix = (luaObj.RawGet("OnDetailButtonClick") as LuaFunction);
					this.m_OnCloseDetailPanelButtonClick_hotfix = (luaObj.RawGet("OnCloseDetailPanelButtonClick") as LuaFunction);
					this.m_OnArchiveButtonClick_hotfix = (luaObj.RawGet("OnArchiveButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnWeiBoShareOnceClick_hotfix = (luaObj.RawGet("OnWeiBoShareOnceClick") as LuaFunction);
					this.m_OnWeChatShareOnceClick_hotfix = (luaObj.RawGet("OnWeChatShareOnceClick") as LuaFunction);
					this.m_OnWeiBoShareTenClick_hotfix = (luaObj.RawGet("OnWeiBoShareTenClick") as LuaFunction);
					this.m_OnWeChatShareTenClick_hotfix = (luaObj.RawGet("OnWeChatShareTenClick") as LuaFunction);
					this.m_CaptureOnceFrameInt32_hotfix = (luaObj.RawGet("CaptureOnceFrame") as LuaFunction);
					this.m_CaptureTenFrameInt32_hotfix = (luaObj.RawGet("CaptureTenFrame") as LuaFunction);
					this.m_add_EventOnWeiBoShareTenAction_hotfix = (luaObj.RawGet("add_EventOnWeiBoShareTen") as LuaFunction);
					this.m_remove_EventOnWeiBoShareTenAction_hotfix = (luaObj.RawGet("remove_EventOnWeiBoShareTen") as LuaFunction);
					this.m_add_EventOnWeChatShareTenAction_hotfix = (luaObj.RawGet("add_EventOnWeChatShareTen") as LuaFunction);
					this.m_remove_EventOnWeChatShareTenAction_hotfix = (luaObj.RawGet("remove_EventOnWeChatShareTen") as LuaFunction);
					this.m_add_EventOnArchiveAction_hotfix = (luaObj.RawGet("add_EventOnArchive") as LuaFunction);
					this.m_remove_EventOnArchiveAction_hotfix = (luaObj.RawGet("remove_EventOnArchive") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnSelectCardAction`2_hotfix = (luaObj.RawGet("add_EventOnSelectCard") as LuaFunction);
					this.m_remove_EventOnSelectCardAction`2_hotfix = (luaObj.RawGet("remove_EventOnSelectCard") as LuaFunction);
					this.m_add_EventOnShowSelectCardHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowSelectCardHelp") as LuaFunction);
					this.m_remove_EventOnShowSelectCardHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowSelectCardHelp") as LuaFunction);
					this.m_add_EventOnShowActivityDetailAction`1_hotfix = (luaObj.RawGet("add_EventOnShowActivityDetail") as LuaFunction);
					this.m_remove_EventOnShowActivityDetailAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowActivityDetail") as LuaFunction);
					this.m_add_EventOnBagCapcityNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnBagCapcityNotEnough") as LuaFunction);
					this.m_remove_EventOnBagCapcityNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnBagCapcityNotEnough") as LuaFunction);
					this.m_add_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnCrystalNotEnough") as LuaFunction);
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnCrystalNotEnough") as LuaFunction);
					this.m_add_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("add_EventOnAddCrystal") as LuaFunction);
					this.m_remove_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("remove_EventOnAddCrystal") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012E44 RID: 77380 RVA: 0x004D7158 File Offset: 0x004D5358
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A890 RID: 43152
		[AutoBind("./MainUI/ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400A891 RID: 43153
		[AutoBind("./MainUI", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mainUIGo;

		// Token: 0x0400A892 RID: 43154
		[AutoBind("./MainUI/Currencys/NormalCard/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_normalCardNumText;

		// Token: 0x0400A893 RID: 43155
		[AutoBind("./MainUI/Currencys/DiamondCard/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_diamondsCardNumText;

		// Token: 0x0400A894 RID: 43156
		[AutoBind("./MainUI/Currencys/Diamond/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_diamondsAddBtn;

		// Token: 0x0400A895 RID: 43157
		[AutoBind("./MainUI/Currencys/Diamond/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_diamondsNumText;

		// Token: 0x0400A896 RID: 43158
		[AutoBind("./MainUI/SummonPanel/Ads/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_adsImage;

		// Token: 0x0400A897 RID: 43159
		[AutoBind("./MainUI/SummonPanel/Ads/Image/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_adsTimeText;

		// Token: 0x0400A898 RID: 43160
		[AutoBind("./MainUI/SummonPanel/Ads/Image/DetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_activityDetailButton;

		// Token: 0x0400A899 RID: 43161
		[AutoBind("./MainUI/SummonPanel/Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400A89A RID: 43162
		[AutoBind("./MainUI/SummonPanel/Margin/RightToggleGroup/CardPoolsScrollView/Viewport/CardPools", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_cardPoolToggleGroupGo;

		// Token: 0x0400A89B RID: 43163
		[AutoBind("./MainUI/SummonPanel/Margin/RightToggleGroup/CardPoolsScrollView/Viewport/CardPools/TicketSummonToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_ticketSummonToggle;

		// Token: 0x0400A89C RID: 43164
		[AutoBind("./MainUI/SummonPanel/Margin/RightToggleGroup/CardPoolsScrollView/Viewport/CardPools/MagicStoneSummonToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_magicStoneSummonToggle;

		// Token: 0x0400A89D RID: 43165
		[AutoBind("./MainUI/SummonPanel/Margin/RightToggleGroup/CardPoolsScrollView/Viewport/CardPools/EquipSummonToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_equipSummonToggle;

		// Token: 0x0400A89E RID: 43166
		[AutoBind("./MainUI/SummonPanel/SingleSelectButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_singleSelectBtn;

		// Token: 0x0400A89F RID: 43167
		[AutoBind("./MainUI/SummonPanel/SingleSelectButton/DetailGroup/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_singleSelectBtnIconImg;

		// Token: 0x0400A8A0 RID: 43168
		[AutoBind("./MainUI/SummonPanel/SingleSelectButton/DetailGroup/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_singleSelectBtnNumText;

		// Token: 0x0400A8A1 RID: 43169
		[AutoBind("./MainUI/SummonPanel/SingleSelectButton/DetailGroup/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_singleSelectBtnTitleText;

		// Token: 0x0400A8A2 RID: 43170
		[AutoBind("./MainUI/SummonPanel/TenSelectButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_tenSelectBtn;

		// Token: 0x0400A8A3 RID: 43171
		[AutoBind("./MainUI/SummonPanel/TenSelectButton/DetailGroup/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_tenSelectBtnIconImg;

		// Token: 0x0400A8A4 RID: 43172
		[AutoBind("./MainUI/SummonPanel/TenSelectButton/DetailGroup/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_tenSelectBtnNumText;

		// Token: 0x0400A8A5 RID: 43173
		[AutoBind("./MainUI/SummonPanel/TenSelectButton/DetailGroup/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_tenSelectBtnTitleText;

		// Token: 0x0400A8A6 RID: 43174
		[AutoBind("./MainUI/SummonPanel/TenSelectButton/U_TenSelectButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tenSelectBtn3DEffect;

		// Token: 0x0400A8A7 RID: 43175
		[AutoBind("./MainUI/BuyDiamondButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_buyDiamondButton;

		// Token: 0x0400A8A8 RID: 43176
		[AutoBind("./Prefab/SummonToggle", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_summonToggleItemPrefab;

		// Token: 0x0400A8A9 RID: 43177
		[AutoBind("./AfterSelectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_afterSelectPanel;

		// Token: 0x0400A8AA RID: 43178
		[AutoBind("./AfterSelectPanel/ArrowImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectArrowButton;

		// Token: 0x0400A8AB RID: 43179
		[AutoBind("./AfterSelectPanel/OpenNoticePanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectOpenNoticePanelGo;

		// Token: 0x0400A8AC RID: 43180
		[AutoBind("./AfterSelectPanel/OpenNoticePanel/ArrowImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectOpenNoticePanelImage;

		// Token: 0x0400A8AD RID: 43181
		[AutoBind("./AfterSelectPanel/SingleSelectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectPanel;

		// Token: 0x0400A8AE RID: 43182
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/Word", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleHeroWordPanel;

		// Token: 0x0400A8AF RID: 43183
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/ContinueImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_singleSelectContinueImage;

		// Token: 0x0400A8B0 RID: 43184
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/NewText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectNewTextObj;

		// Token: 0x0400A8B1 RID: 43185
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/GetText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectGetTextObj;

		// Token: 0x0400A8B2 RID: 43186
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleSelectStarGroupObj;

		// Token: 0x0400A8B3 RID: 43187
		[AutoBind("./AfterSelectPanel/SkipButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectSkipButton;

		// Token: 0x0400A8B4 RID: 43188
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/ItemImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_singleSelectItemImage;

		// Token: 0x0400A8B5 RID: 43189
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/FragmentIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_singleSelectFragmentIconImg;

		// Token: 0x0400A8B6 RID: 43190
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/FragmentIcon/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_singleSelectFragmentCount;

		// Token: 0x0400A8B7 RID: 43191
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/SSR", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_singleSelectFragmentSSRImg;

		// Token: 0x0400A8B8 RID: 43192
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/SR", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_singleSelectFragmentSRImg;

		// Token: 0x0400A8B9 RID: 43193
		[AutoBind("./AfterSelectPanel/SingleSelectPanel/ShareButtonDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_singleShareButtonDummy;

		// Token: 0x0400A8BA RID: 43194
		[AutoBind("./AfterSelectPanel/SharePhotoDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sharePhotoDummy;

		// Token: 0x0400A8BB RID: 43195
		[AutoBind("./AfterSelectPanel/TenSelectPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tenSelectPanel;

		// Token: 0x0400A8BC RID: 43196
		[AutoBind("./AfterSelectPanel/TenSelectPanel/ItemShowPanel/ItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tenSelectContentObj;

		// Token: 0x0400A8BD RID: 43197
		[AutoBind("./AfterSelectPanel/TenSelectPanel/ComfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_afterSelectConfirmButton;

		// Token: 0x0400A8BE RID: 43198
		[AutoBind("./AfterSelectPanel/TenSelectPanel/SelectAgainButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_selectAgainButton;

		// Token: 0x0400A8BF RID: 43199
		[AutoBind("./AfterSelectPanel/TenSelectPanel/SelectAgainButton/Single", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectAgainButtonSingleBgObj;

		// Token: 0x0400A8C0 RID: 43200
		[AutoBind("./AfterSelectPanel/TenSelectPanel/SelectAgainButton/Ten", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectAgainButtonTenBgObj;

		// Token: 0x0400A8C1 RID: 43201
		[AutoBind("./AfterSelectPanel/TenSelectPanel/SelectAgainButton/DetailGroup/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_selectAgainBtnIconImg;

		// Token: 0x0400A8C2 RID: 43202
		[AutoBind("./AfterSelectPanel/TenSelectPanel/SelectAgainButton/DetailGroup/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_selectAgainBtnNumText;

		// Token: 0x0400A8C3 RID: 43203
		[AutoBind("./AfterSelectPanel/TenSelectPanel/SelectAgainButton/DetailGroup/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_selectAgainBtnTitleText;

		// Token: 0x0400A8C4 RID: 43204
		[AutoBind("./AfterSelectPanel/TenSelectPanel/ShareButtonDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tenShareButtonDummy;

		// Token: 0x0400A8C5 RID: 43205
		[AutoBind("./AfterSelectPanel/TenSelectPanel/Currencys/Diamond/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_diamondsAddBtn2;

		// Token: 0x0400A8C6 RID: 43206
		[AutoBind("./ChangeCrystalToTicketPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changeCrystalToTicketPanel;

		// Token: 0x0400A8C7 RID: 43207
		[AutoBind("./ChangeCrystalToTicketPanel/Detail/Tip", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_changeCrystalToTicketPanelTip;

		// Token: 0x0400A8C8 RID: 43208
		[AutoBind("./ChangeCrystalToTicketPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeCrystalToTicketPanelCancelButton;

		// Token: 0x0400A8C9 RID: 43209
		[AutoBind("./ChangeCrystalToTicketPanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeCrystalToTicketPanelConfirmButton;

		// Token: 0x0400A8CA RID: 43210
		[AutoBind("./CrystalAndTicketNotEnoughPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_crystalAndTicketNotEnoughPanel;

		// Token: 0x0400A8CB RID: 43211
		[AutoBind("./CrystalAndTicketNotEnoughPanel/Detail/Tip", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_crystalAndTicketNotEnoughPanelTip;

		// Token: 0x0400A8CC RID: 43212
		[AutoBind("./CrystalAndTicketNotEnoughPanel/Detail/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_crystalAndTicketNotEnoughPanelCancelButton;

		// Token: 0x0400A8CD RID: 43213
		[AutoBind("./CrystalAndTicketNotEnoughPanel/Detail/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_crystalAndTicketNotEnoughPanelConfirmButton;

		// Token: 0x0400A8CE RID: 43214
		[AutoBind("./AfterSelectPanel/TenSelectPanel/Currencys/NormalCard/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_afterSelectPanelNormalCardNumText;

		// Token: 0x0400A8CF RID: 43215
		[AutoBind("./AfterSelectPanel/TenSelectPanel/Currencys/DiamondCard/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_afterSelectPanelDiamondsCardNumText;

		// Token: 0x0400A8D0 RID: 43216
		[AutoBind("./AfterSelectPanel/TenSelectPanel/Currencys/Diamond/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_afterSelectPanelDiamondsNumText;

		// Token: 0x0400A8D1 RID: 43217
		[AutoBind("./MainUI/SummonPanel/Margin/ArchiveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_archiveButton;

		// Token: 0x0400A8D2 RID: 43218
		[AutoBind("/MainUI/DetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detailButton;

		// Token: 0x0400A8D3 RID: 43219
		[AutoBind("/DetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_detailPanelObj;

		// Token: 0x0400A8D4 RID: 43220
		[AutoBind("/DetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_detailPanelStateCtrl;

		// Token: 0x0400A8D5 RID: 43221
		[AutoBind("/DetailPanel/Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detailCloseButton;

		// Token: 0x0400A8D6 RID: 43222
		[AutoBind("/DetailPanel/BgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detailReturnBgButton;

		// Token: 0x0400A8D7 RID: 43223
		[AutoBind("/DetailPanel/Detail/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_detailScrollRect;

		// Token: 0x0400A8D8 RID: 43224
		[AutoBind("/DetailPanel/Detail/ScrollView/Viewport/Content/ProbabilityGroup/WeightInfo/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_detailWeightTitleText;

		// Token: 0x0400A8D9 RID: 43225
		[AutoBind("/DetailPanel/Detail/ScrollView/Viewport/Content/ProbabilityGroup/WeightInfo/QualityGroup/SSR/WeightText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_detailSSRWeightText;

		// Token: 0x0400A8DA RID: 43226
		[AutoBind("/DetailPanel/Detail/ScrollView/Viewport/Content/ProbabilityGroup/WeightInfo/QualityGroup/SR/WeightText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_detailSRWeightText;

		// Token: 0x0400A8DB RID: 43227
		[AutoBind("/DetailPanel/Detail/ScrollView/Viewport/Content/ProbabilityGroup/WeightInfo/QualityGroup/R/WeightText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_detailRWeightText;

		// Token: 0x0400A8DC RID: 43228
		[AutoBind("/DetailPanel/Detail/ScrollView/Viewport/Content/InfoGroup/Title/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_detailScrollViewContentTitleText;

		// Token: 0x0400A8DD RID: 43229
		[AutoBind("/DetailPanel/Detail/ScrollView/Viewport/Content/InfoGroup/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_detailScrollViewContent;

		// Token: 0x0400A8DE RID: 43230
		[AutoBind("/Prefab/PoolItemWithRank", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_poolItemWithRankPrefab;

		// Token: 0x0400A8DF RID: 43231
		private Button m_weiBoShareOneButton;

		// Token: 0x0400A8E0 RID: 43232
		private Button m_weChatShareOneButton;

		// Token: 0x0400A8E1 RID: 43233
		private Button m_weiBoShareTenButton;

		// Token: 0x0400A8E2 RID: 43234
		private Button m_weChatShareTenButton;

		// Token: 0x0400A8E3 RID: 43235
		private Text m_playerNameText;

		// Token: 0x0400A8E4 RID: 43236
		private Text m_playerLvText;

		// Token: 0x0400A8E5 RID: 43237
		private Text m_serverNameText;

		// Token: 0x0400A8E6 RID: 43238
		private Text m_heroNameText;

		// Token: 0x0400A8E7 RID: 43239
		private int m_nToShareHeroId;

		// Token: 0x0400A8F2 RID: 43250
		private int m_cardPoolId;

		// Token: 0x0400A8F3 RID: 43251
		private CardPool m_cardPool;

		// Token: 0x0400A8F4 RID: 43252
		private bool m_isClockHold;

		// Token: 0x0400A8F5 RID: 43253
		private bool m_isSingleSelect;

		// Token: 0x0400A8F6 RID: 43254
		private bool m_isContinueButtonClick;

		// Token: 0x0400A8F7 RID: 43255
		private List<Goods> m_selectRewards;

		// Token: 0x0400A8F8 RID: 43256
		private const string PoolItemNameText = "NameText";

		// Token: 0x0400A8F9 RID: 43257
		private const int NormalCardId = 4000;

		// Token: 0x0400A8FA RID: 43258
		private const int CrystalCardId = 4001;

		// Token: 0x0400A8FB RID: 43259
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400A8FC RID: 43260
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400A8FD RID: 43261
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x0400A8FE RID: 43262
		private SelectCardBackground3DController m_selectCardBackground3DController;

		// Token: 0x0400A8FF RID: 43263
		private ShareTenSelectCardUIController m_shareTenSelectCardUIController;

		// Token: 0x0400A900 RID: 43264
		private bool m_hasShowClockEffect;

		// Token: 0x0400A901 RID: 43265
		private List<SummonToggleUIController> m_toggleCtrlList = new List<SummonToggleUIController>();

		// Token: 0x0400A902 RID: 43266
		[DoNotToLua]
		private SelectCardUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A903 RID: 43267
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A904 RID: 43268
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A905 RID: 43269
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A906 RID: 43270
		private LuaFunction m_UpdateViewInSelectCardInt32_hotfix;

		// Token: 0x0400A907 RID: 43271
		private LuaFunction m_UpdateSharePlayerInfo_hotfix;

		// Token: 0x0400A908 RID: 43272
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A909 RID: 43273
		private LuaFunction m_SetShareTenSelectCardUIControllerShareTenSelectCardUIController_hotfix;

		// Token: 0x0400A90A RID: 43274
		private LuaFunction m_ShowSelectCardRewardsList;

		// Token: 0x0400A90B RID: 43275
		private LuaFunction m_PlayRewardsEffectList;

		// Token: 0x0400A90C RID: 43276
		private LuaFunction m_PlaySingleRewardEffectGoodsBooleanInt32Int32Int32_hotfix;

		// Token: 0x0400A90D RID: 43277
		private LuaFunction m_StopClockEffectSoundOnSkipButtonClick_hotfix;

		// Token: 0x0400A90E RID: 43278
		private LuaFunction m_AfterShowClockEffectFinishedGoodsInt32Int32_hotfix;

		// Token: 0x0400A90F RID: 43279
		private LuaFunction m_OnClockButtonDragGameObject_hotfix;

		// Token: 0x0400A910 RID: 43280
		private LuaFunction m_OnContinueButtonClick_hotfix;

		// Token: 0x0400A911 RID: 43281
		private LuaFunction m_PlayTotalRewardsEffect_hotfix;

		// Token: 0x0400A912 RID: 43282
		private LuaFunction m_SetAfterSelectCurrecyPanel_hotfix;

		// Token: 0x0400A913 RID: 43283
		private LuaFunction m_SetSingleSelectRewardInfoGoodsInt32Int32_hotfix;

		// Token: 0x0400A914 RID: 43284
		private LuaFunction m_SetTenSelectRewardsInfoList;

		// Token: 0x0400A915 RID: 43285
		private LuaFunction m_CreateCardPoolTabs_hotfix;

		// Token: 0x0400A916 RID: 43286
		private LuaFunction m_SummonToggleCtrl_EventOnToggleClickSummonToggleUIController_hotfix;

		// Token: 0x0400A917 RID: 43287
		private LuaFunction m_SetValuesAfterToggleChanged_hotfix;

		// Token: 0x0400A918 RID: 43288
		private LuaFunction m_SetSelectButtonImageTextTextBoolean_hotfix;

		// Token: 0x0400A919 RID: 43289
		private LuaFunction m_OnActivityDetailButtonClick_hotfix;

		// Token: 0x0400A91A RID: 43290
		private LuaFunction m_OnSingleSelectButtonClick_hotfix;

		// Token: 0x0400A91B RID: 43291
		private LuaFunction m_OnTenSelectButtonClick_hotfix;

		// Token: 0x0400A91C RID: 43292
		private LuaFunction m_OnSelectAgainButtonClick_hotfix;

		// Token: 0x0400A91D RID: 43293
		private LuaFunction m_CloseTenSelectPanelAction_hotfix;

		// Token: 0x0400A91E RID: 43294
		private LuaFunction m_ShowChangeCrystalToTicketPanel_hotfix;

		// Token: 0x0400A91F RID: 43295
		private LuaFunction m_ChangeCrystalToTicketPanelCancelButtonClick_hotfix;

		// Token: 0x0400A920 RID: 43296
		private LuaFunction m_CloseChangeCrystalToTicketPanel_hotfix;

		// Token: 0x0400A921 RID: 43297
		private LuaFunction m_ChangeCrystalToTicketPanelConfirmButtonClick_hotfix;

		// Token: 0x0400A922 RID: 43298
		private LuaFunction m_ShowCrystalAndTicketNotEnoughPanel_hotfix;

		// Token: 0x0400A923 RID: 43299
		private LuaFunction m_CrystalAndTicketNotEnoughPanelCancelButtonClick_hotfix;

		// Token: 0x0400A924 RID: 43300
		private LuaFunction m_CloseCrystalAndTicketNotEnoughPanel_hotfix;

		// Token: 0x0400A925 RID: 43301
		private LuaFunction m_CrystalAndTicketNotEnoughPanelConfirmButtonClick_hotfix;

		// Token: 0x0400A926 RID: 43302
		private LuaFunction m_OnBuyDiamondButtonClick_hotfix;

		// Token: 0x0400A927 RID: 43303
		private LuaFunction m_OnAddCrystalBtnClick_hotfix;

		// Token: 0x0400A928 RID: 43304
		private LuaFunction m_OnAddCrystal_hotfix;

		// Token: 0x0400A929 RID: 43305
		private LuaFunction m_SkipShowRewardEffect_hotfix;

		// Token: 0x0400A92A RID: 43306
		private LuaFunction m_Close3DUIEffect_hotfix;

		// Token: 0x0400A92B RID: 43307
		private LuaFunction m_CloseShowSelectRewardsPanel_hotfix;

		// Token: 0x0400A92C RID: 43308
		private LuaFunction m_IsShowSelectCardResult_hotfix;

		// Token: 0x0400A92D RID: 43309
		private LuaFunction m_ShowDetailScrollView_hotfix;

		// Token: 0x0400A92E RID: 43310
		private LuaFunction m_CreatePoolItemPrefabPoolContentItemData_hotfix;

		// Token: 0x0400A92F RID: 43311
		private LuaFunction m_OnDetailButtonClick_hotfix;

		// Token: 0x0400A930 RID: 43312
		private LuaFunction m_OnCloseDetailPanelButtonClick_hotfix;

		// Token: 0x0400A931 RID: 43313
		private LuaFunction m_OnArchiveButtonClick_hotfix;

		// Token: 0x0400A932 RID: 43314
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400A933 RID: 43315
		private LuaFunction m_OnWeiBoShareOnceClick_hotfix;

		// Token: 0x0400A934 RID: 43316
		private LuaFunction m_OnWeChatShareOnceClick_hotfix;

		// Token: 0x0400A935 RID: 43317
		private LuaFunction m_OnWeiBoShareTenClick_hotfix;

		// Token: 0x0400A936 RID: 43318
		private LuaFunction m_OnWeChatShareTenClick_hotfix;

		// Token: 0x0400A937 RID: 43319
		private LuaFunction m_CaptureOnceFrameInt32_hotfix;

		// Token: 0x0400A938 RID: 43320
		private LuaFunction m_CaptureTenFrameInt32_hotfix;

		// Token: 0x0400A939 RID: 43321
		private LuaFunction m_add_EventOnWeiBoShareTenAction_hotfix;

		// Token: 0x0400A93A RID: 43322
		private LuaFunction m_remove_EventOnWeiBoShareTenAction_hotfix;

		// Token: 0x0400A93B RID: 43323
		private LuaFunction m_add_EventOnWeChatShareTenAction_hotfix;

		// Token: 0x0400A93C RID: 43324
		private LuaFunction m_remove_EventOnWeChatShareTenAction_hotfix;

		// Token: 0x0400A93D RID: 43325
		private LuaFunction m_add_EventOnArchiveAction_hotfix;

		// Token: 0x0400A93E RID: 43326
		private LuaFunction m_remove_EventOnArchiveAction_hotfix;

		// Token: 0x0400A93F RID: 43327
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400A940 RID: 43328
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400A941 RID: 43329
		private LuaFunction m_add_EventOnSelectCardAction;

		// Token: 0x0400A942 RID: 43330
		private LuaFunction m_remove_EventOnSelectCardAction;

		// Token: 0x0400A943 RID: 43331
		private LuaFunction m_add_EventOnShowSelectCardHelpAction_hotfix;

		// Token: 0x0400A944 RID: 43332
		private LuaFunction m_remove_EventOnShowSelectCardHelpAction_hotfix;

		// Token: 0x0400A945 RID: 43333
		private LuaFunction m_add_EventOnShowActivityDetailAction;

		// Token: 0x0400A946 RID: 43334
		private LuaFunction m_remove_EventOnShowActivityDetailAction;

		// Token: 0x0400A947 RID: 43335
		private LuaFunction m_add_EventOnBagCapcityNotEnoughAction_hotfix;

		// Token: 0x0400A948 RID: 43336
		private LuaFunction m_remove_EventOnBagCapcityNotEnoughAction_hotfix;

		// Token: 0x0400A949 RID: 43337
		private LuaFunction m_add_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400A94A RID: 43338
		private LuaFunction m_remove_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400A94B RID: 43339
		private LuaFunction m_add_EventOnAddCrystalAction_hotfix;

		// Token: 0x0400A94C RID: 43340
		private LuaFunction m_remove_EventOnAddCrystalAction_hotfix;

		// Token: 0x02000EF1 RID: 3825
		public new class LuaExportHelper
		{
			// Token: 0x06012E45 RID: 77381 RVA: 0x004D71C0 File Offset: 0x004D53C0
			public LuaExportHelper(SelectCardUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012E46 RID: 77382 RVA: 0x004D71D0 File Offset: 0x004D53D0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012E47 RID: 77383 RVA: 0x004D71E0 File Offset: 0x004D53E0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012E48 RID: 77384 RVA: 0x004D71F0 File Offset: 0x004D53F0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012E49 RID: 77385 RVA: 0x004D7200 File Offset: 0x004D5400
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012E4A RID: 77386 RVA: 0x004D7218 File Offset: 0x004D5418
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012E4B RID: 77387 RVA: 0x004D7228 File Offset: 0x004D5428
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012E4C RID: 77388 RVA: 0x004D7238 File Offset: 0x004D5438
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012E4D RID: 77389 RVA: 0x004D7248 File Offset: 0x004D5448
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012E4E RID: 77390 RVA: 0x004D7258 File Offset: 0x004D5458
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012E4F RID: 77391 RVA: 0x004D7268 File Offset: 0x004D5468
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012E50 RID: 77392 RVA: 0x004D7278 File Offset: 0x004D5478
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012E51 RID: 77393 RVA: 0x004D7288 File Offset: 0x004D5488
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012E52 RID: 77394 RVA: 0x004D7298 File Offset: 0x004D5498
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012E53 RID: 77395 RVA: 0x004D72A8 File Offset: 0x004D54A8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012E54 RID: 77396 RVA: 0x004D72B8 File Offset: 0x004D54B8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012E55 RID: 77397 RVA: 0x004D72C8 File Offset: 0x004D54C8
			public void __callDele_EventOnWeiBoShareTen()
			{
				this.m_owner.__callDele_EventOnWeiBoShareTen();
			}

			// Token: 0x06012E56 RID: 77398 RVA: 0x004D72D8 File Offset: 0x004D54D8
			public void __clearDele_EventOnWeiBoShareTen()
			{
				this.m_owner.__clearDele_EventOnWeiBoShareTen();
			}

			// Token: 0x06012E57 RID: 77399 RVA: 0x004D72E8 File Offset: 0x004D54E8
			public void __callDele_EventOnWeChatShareTen()
			{
				this.m_owner.__callDele_EventOnWeChatShareTen();
			}

			// Token: 0x06012E58 RID: 77400 RVA: 0x004D72F8 File Offset: 0x004D54F8
			public void __clearDele_EventOnWeChatShareTen()
			{
				this.m_owner.__clearDele_EventOnWeChatShareTen();
			}

			// Token: 0x06012E59 RID: 77401 RVA: 0x004D7308 File Offset: 0x004D5508
			public void __callDele_EventOnArchive()
			{
				this.m_owner.__callDele_EventOnArchive();
			}

			// Token: 0x06012E5A RID: 77402 RVA: 0x004D7318 File Offset: 0x004D5518
			public void __clearDele_EventOnArchive()
			{
				this.m_owner.__clearDele_EventOnArchive();
			}

			// Token: 0x06012E5B RID: 77403 RVA: 0x004D7328 File Offset: 0x004D5528
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06012E5C RID: 77404 RVA: 0x004D7338 File Offset: 0x004D5538
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06012E5D RID: 77405 RVA: 0x004D7348 File Offset: 0x004D5548
			public void __callDele_EventOnSelectCard(int arg1, bool arg2)
			{
				this.m_owner.__callDele_EventOnSelectCard(arg1, arg2);
			}

			// Token: 0x06012E5E RID: 77406 RVA: 0x004D7358 File Offset: 0x004D5558
			public void __clearDele_EventOnSelectCard(int arg1, bool arg2)
			{
				this.m_owner.__clearDele_EventOnSelectCard(arg1, arg2);
			}

			// Token: 0x06012E5F RID: 77407 RVA: 0x004D7368 File Offset: 0x004D5568
			public void __callDele_EventOnShowSelectCardHelp()
			{
				this.m_owner.__callDele_EventOnShowSelectCardHelp();
			}

			// Token: 0x06012E60 RID: 77408 RVA: 0x004D7378 File Offset: 0x004D5578
			public void __clearDele_EventOnShowSelectCardHelp()
			{
				this.m_owner.__clearDele_EventOnShowSelectCardHelp();
			}

			// Token: 0x06012E61 RID: 77409 RVA: 0x004D7388 File Offset: 0x004D5588
			public void __callDele_EventOnShowActivityDetail(CardPool obj)
			{
				this.m_owner.__callDele_EventOnShowActivityDetail(obj);
			}

			// Token: 0x06012E62 RID: 77410 RVA: 0x004D7398 File Offset: 0x004D5598
			public void __clearDele_EventOnShowActivityDetail(CardPool obj)
			{
				this.m_owner.__clearDele_EventOnShowActivityDetail(obj);
			}

			// Token: 0x06012E63 RID: 77411 RVA: 0x004D73A8 File Offset: 0x004D55A8
			public void __callDele_EventOnBagCapcityNotEnough()
			{
				this.m_owner.__callDele_EventOnBagCapcityNotEnough();
			}

			// Token: 0x06012E64 RID: 77412 RVA: 0x004D73B8 File Offset: 0x004D55B8
			public void __clearDele_EventOnBagCapcityNotEnough()
			{
				this.m_owner.__clearDele_EventOnBagCapcityNotEnough();
			}

			// Token: 0x06012E65 RID: 77413 RVA: 0x004D73C8 File Offset: 0x004D55C8
			public void __callDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__callDele_EventOnCrystalNotEnough();
			}

			// Token: 0x06012E66 RID: 77414 RVA: 0x004D73D8 File Offset: 0x004D55D8
			public void __clearDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__clearDele_EventOnCrystalNotEnough();
			}

			// Token: 0x06012E67 RID: 77415 RVA: 0x004D73E8 File Offset: 0x004D55E8
			public void __callDele_EventOnAddCrystal()
			{
				this.m_owner.__callDele_EventOnAddCrystal();
			}

			// Token: 0x06012E68 RID: 77416 RVA: 0x004D73F8 File Offset: 0x004D55F8
			public void __clearDele_EventOnAddCrystal()
			{
				this.m_owner.__clearDele_EventOnAddCrystal();
			}

			// Token: 0x170038D3 RID: 14547
			// (get) Token: 0x06012E69 RID: 77417 RVA: 0x004D7408 File Offset: 0x004D5608
			// (set) Token: 0x06012E6A RID: 77418 RVA: 0x004D7418 File Offset: 0x004D5618
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

			// Token: 0x170038D4 RID: 14548
			// (get) Token: 0x06012E6B RID: 77419 RVA: 0x004D7428 File Offset: 0x004D5628
			// (set) Token: 0x06012E6C RID: 77420 RVA: 0x004D7438 File Offset: 0x004D5638
			public GameObject m_mainUIGo
			{
				get
				{
					return this.m_owner.m_mainUIGo;
				}
				set
				{
					this.m_owner.m_mainUIGo = value;
				}
			}

			// Token: 0x170038D5 RID: 14549
			// (get) Token: 0x06012E6D RID: 77421 RVA: 0x004D7448 File Offset: 0x004D5648
			// (set) Token: 0x06012E6E RID: 77422 RVA: 0x004D7458 File Offset: 0x004D5658
			public Text m_normalCardNumText
			{
				get
				{
					return this.m_owner.m_normalCardNumText;
				}
				set
				{
					this.m_owner.m_normalCardNumText = value;
				}
			}

			// Token: 0x170038D6 RID: 14550
			// (get) Token: 0x06012E6F RID: 77423 RVA: 0x004D7468 File Offset: 0x004D5668
			// (set) Token: 0x06012E70 RID: 77424 RVA: 0x004D7478 File Offset: 0x004D5678
			public Text m_diamondsCardNumText
			{
				get
				{
					return this.m_owner.m_diamondsCardNumText;
				}
				set
				{
					this.m_owner.m_diamondsCardNumText = value;
				}
			}

			// Token: 0x170038D7 RID: 14551
			// (get) Token: 0x06012E71 RID: 77425 RVA: 0x004D7488 File Offset: 0x004D5688
			// (set) Token: 0x06012E72 RID: 77426 RVA: 0x004D7498 File Offset: 0x004D5698
			public Button m_diamondsAddBtn
			{
				get
				{
					return this.m_owner.m_diamondsAddBtn;
				}
				set
				{
					this.m_owner.m_diamondsAddBtn = value;
				}
			}

			// Token: 0x170038D8 RID: 14552
			// (get) Token: 0x06012E73 RID: 77427 RVA: 0x004D74A8 File Offset: 0x004D56A8
			// (set) Token: 0x06012E74 RID: 77428 RVA: 0x004D74B8 File Offset: 0x004D56B8
			public Text m_diamondsNumText
			{
				get
				{
					return this.m_owner.m_diamondsNumText;
				}
				set
				{
					this.m_owner.m_diamondsNumText = value;
				}
			}

			// Token: 0x170038D9 RID: 14553
			// (get) Token: 0x06012E75 RID: 77429 RVA: 0x004D74C8 File Offset: 0x004D56C8
			// (set) Token: 0x06012E76 RID: 77430 RVA: 0x004D74D8 File Offset: 0x004D56D8
			public Image m_adsImage
			{
				get
				{
					return this.m_owner.m_adsImage;
				}
				set
				{
					this.m_owner.m_adsImage = value;
				}
			}

			// Token: 0x170038DA RID: 14554
			// (get) Token: 0x06012E77 RID: 77431 RVA: 0x004D74E8 File Offset: 0x004D56E8
			// (set) Token: 0x06012E78 RID: 77432 RVA: 0x004D74F8 File Offset: 0x004D56F8
			public Text m_adsTimeText
			{
				get
				{
					return this.m_owner.m_adsTimeText;
				}
				set
				{
					this.m_owner.m_adsTimeText = value;
				}
			}

			// Token: 0x170038DB RID: 14555
			// (get) Token: 0x06012E79 RID: 77433 RVA: 0x004D7508 File Offset: 0x004D5708
			// (set) Token: 0x06012E7A RID: 77434 RVA: 0x004D7518 File Offset: 0x004D5718
			public Button m_activityDetailButton
			{
				get
				{
					return this.m_owner.m_activityDetailButton;
				}
				set
				{
					this.m_owner.m_activityDetailButton = value;
				}
			}

			// Token: 0x170038DC RID: 14556
			// (get) Token: 0x06012E7B RID: 77435 RVA: 0x004D7528 File Offset: 0x004D5728
			// (set) Token: 0x06012E7C RID: 77436 RVA: 0x004D7538 File Offset: 0x004D5738
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

			// Token: 0x170038DD RID: 14557
			// (get) Token: 0x06012E7D RID: 77437 RVA: 0x004D7548 File Offset: 0x004D5748
			// (set) Token: 0x06012E7E RID: 77438 RVA: 0x004D7558 File Offset: 0x004D5758
			public GameObject m_cardPoolToggleGroupGo
			{
				get
				{
					return this.m_owner.m_cardPoolToggleGroupGo;
				}
				set
				{
					this.m_owner.m_cardPoolToggleGroupGo = value;
				}
			}

			// Token: 0x170038DE RID: 14558
			// (get) Token: 0x06012E7F RID: 77439 RVA: 0x004D7568 File Offset: 0x004D5768
			// (set) Token: 0x06012E80 RID: 77440 RVA: 0x004D7578 File Offset: 0x004D5778
			public Toggle m_ticketSummonToggle
			{
				get
				{
					return this.m_owner.m_ticketSummonToggle;
				}
				set
				{
					this.m_owner.m_ticketSummonToggle = value;
				}
			}

			// Token: 0x170038DF RID: 14559
			// (get) Token: 0x06012E81 RID: 77441 RVA: 0x004D7588 File Offset: 0x004D5788
			// (set) Token: 0x06012E82 RID: 77442 RVA: 0x004D7598 File Offset: 0x004D5798
			public Toggle m_magicStoneSummonToggle
			{
				get
				{
					return this.m_owner.m_magicStoneSummonToggle;
				}
				set
				{
					this.m_owner.m_magicStoneSummonToggle = value;
				}
			}

			// Token: 0x170038E0 RID: 14560
			// (get) Token: 0x06012E83 RID: 77443 RVA: 0x004D75A8 File Offset: 0x004D57A8
			// (set) Token: 0x06012E84 RID: 77444 RVA: 0x004D75B8 File Offset: 0x004D57B8
			public Toggle m_equipSummonToggle
			{
				get
				{
					return this.m_owner.m_equipSummonToggle;
				}
				set
				{
					this.m_owner.m_equipSummonToggle = value;
				}
			}

			// Token: 0x170038E1 RID: 14561
			// (get) Token: 0x06012E85 RID: 77445 RVA: 0x004D75C8 File Offset: 0x004D57C8
			// (set) Token: 0x06012E86 RID: 77446 RVA: 0x004D75D8 File Offset: 0x004D57D8
			public Button m_singleSelectBtn
			{
				get
				{
					return this.m_owner.m_singleSelectBtn;
				}
				set
				{
					this.m_owner.m_singleSelectBtn = value;
				}
			}

			// Token: 0x170038E2 RID: 14562
			// (get) Token: 0x06012E87 RID: 77447 RVA: 0x004D75E8 File Offset: 0x004D57E8
			// (set) Token: 0x06012E88 RID: 77448 RVA: 0x004D75F8 File Offset: 0x004D57F8
			public Image m_singleSelectBtnIconImg
			{
				get
				{
					return this.m_owner.m_singleSelectBtnIconImg;
				}
				set
				{
					this.m_owner.m_singleSelectBtnIconImg = value;
				}
			}

			// Token: 0x170038E3 RID: 14563
			// (get) Token: 0x06012E89 RID: 77449 RVA: 0x004D7608 File Offset: 0x004D5808
			// (set) Token: 0x06012E8A RID: 77450 RVA: 0x004D7618 File Offset: 0x004D5818
			public Text m_singleSelectBtnNumText
			{
				get
				{
					return this.m_owner.m_singleSelectBtnNumText;
				}
				set
				{
					this.m_owner.m_singleSelectBtnNumText = value;
				}
			}

			// Token: 0x170038E4 RID: 14564
			// (get) Token: 0x06012E8B RID: 77451 RVA: 0x004D7628 File Offset: 0x004D5828
			// (set) Token: 0x06012E8C RID: 77452 RVA: 0x004D7638 File Offset: 0x004D5838
			public Text m_singleSelectBtnTitleText
			{
				get
				{
					return this.m_owner.m_singleSelectBtnTitleText;
				}
				set
				{
					this.m_owner.m_singleSelectBtnTitleText = value;
				}
			}

			// Token: 0x170038E5 RID: 14565
			// (get) Token: 0x06012E8D RID: 77453 RVA: 0x004D7648 File Offset: 0x004D5848
			// (set) Token: 0x06012E8E RID: 77454 RVA: 0x004D7658 File Offset: 0x004D5858
			public Button m_tenSelectBtn
			{
				get
				{
					return this.m_owner.m_tenSelectBtn;
				}
				set
				{
					this.m_owner.m_tenSelectBtn = value;
				}
			}

			// Token: 0x170038E6 RID: 14566
			// (get) Token: 0x06012E8F RID: 77455 RVA: 0x004D7668 File Offset: 0x004D5868
			// (set) Token: 0x06012E90 RID: 77456 RVA: 0x004D7678 File Offset: 0x004D5878
			public Image m_tenSelectBtnIconImg
			{
				get
				{
					return this.m_owner.m_tenSelectBtnIconImg;
				}
				set
				{
					this.m_owner.m_tenSelectBtnIconImg = value;
				}
			}

			// Token: 0x170038E7 RID: 14567
			// (get) Token: 0x06012E91 RID: 77457 RVA: 0x004D7688 File Offset: 0x004D5888
			// (set) Token: 0x06012E92 RID: 77458 RVA: 0x004D7698 File Offset: 0x004D5898
			public Text m_tenSelectBtnNumText
			{
				get
				{
					return this.m_owner.m_tenSelectBtnNumText;
				}
				set
				{
					this.m_owner.m_tenSelectBtnNumText = value;
				}
			}

			// Token: 0x170038E8 RID: 14568
			// (get) Token: 0x06012E93 RID: 77459 RVA: 0x004D76A8 File Offset: 0x004D58A8
			// (set) Token: 0x06012E94 RID: 77460 RVA: 0x004D76B8 File Offset: 0x004D58B8
			public Text m_tenSelectBtnTitleText
			{
				get
				{
					return this.m_owner.m_tenSelectBtnTitleText;
				}
				set
				{
					this.m_owner.m_tenSelectBtnTitleText = value;
				}
			}

			// Token: 0x170038E9 RID: 14569
			// (get) Token: 0x06012E95 RID: 77461 RVA: 0x004D76C8 File Offset: 0x004D58C8
			// (set) Token: 0x06012E96 RID: 77462 RVA: 0x004D76D8 File Offset: 0x004D58D8
			public GameObject m_tenSelectBtn3DEffect
			{
				get
				{
					return this.m_owner.m_tenSelectBtn3DEffect;
				}
				set
				{
					this.m_owner.m_tenSelectBtn3DEffect = value;
				}
			}

			// Token: 0x170038EA RID: 14570
			// (get) Token: 0x06012E97 RID: 77463 RVA: 0x004D76E8 File Offset: 0x004D58E8
			// (set) Token: 0x06012E98 RID: 77464 RVA: 0x004D76F8 File Offset: 0x004D58F8
			public Button m_buyDiamondButton
			{
				get
				{
					return this.m_owner.m_buyDiamondButton;
				}
				set
				{
					this.m_owner.m_buyDiamondButton = value;
				}
			}

			// Token: 0x170038EB RID: 14571
			// (get) Token: 0x06012E99 RID: 77465 RVA: 0x004D7708 File Offset: 0x004D5908
			// (set) Token: 0x06012E9A RID: 77466 RVA: 0x004D7718 File Offset: 0x004D5918
			public GameObject m_summonToggleItemPrefab
			{
				get
				{
					return this.m_owner.m_summonToggleItemPrefab;
				}
				set
				{
					this.m_owner.m_summonToggleItemPrefab = value;
				}
			}

			// Token: 0x170038EC RID: 14572
			// (get) Token: 0x06012E9B RID: 77467 RVA: 0x004D7728 File Offset: 0x004D5928
			// (set) Token: 0x06012E9C RID: 77468 RVA: 0x004D7738 File Offset: 0x004D5938
			public GameObject m_afterSelectPanel
			{
				get
				{
					return this.m_owner.m_afterSelectPanel;
				}
				set
				{
					this.m_owner.m_afterSelectPanel = value;
				}
			}

			// Token: 0x170038ED RID: 14573
			// (get) Token: 0x06012E9D RID: 77469 RVA: 0x004D7748 File Offset: 0x004D5948
			// (set) Token: 0x06012E9E RID: 77470 RVA: 0x004D7758 File Offset: 0x004D5958
			public GameObject m_singleSelectArrowButton
			{
				get
				{
					return this.m_owner.m_singleSelectArrowButton;
				}
				set
				{
					this.m_owner.m_singleSelectArrowButton = value;
				}
			}

			// Token: 0x170038EE RID: 14574
			// (get) Token: 0x06012E9F RID: 77471 RVA: 0x004D7768 File Offset: 0x004D5968
			// (set) Token: 0x06012EA0 RID: 77472 RVA: 0x004D7778 File Offset: 0x004D5978
			public GameObject m_singleSelectOpenNoticePanelGo
			{
				get
				{
					return this.m_owner.m_singleSelectOpenNoticePanelGo;
				}
				set
				{
					this.m_owner.m_singleSelectOpenNoticePanelGo = value;
				}
			}

			// Token: 0x170038EF RID: 14575
			// (get) Token: 0x06012EA1 RID: 77473 RVA: 0x004D7788 File Offset: 0x004D5988
			// (set) Token: 0x06012EA2 RID: 77474 RVA: 0x004D7798 File Offset: 0x004D5998
			public GameObject m_singleSelectOpenNoticePanelImage
			{
				get
				{
					return this.m_owner.m_singleSelectOpenNoticePanelImage;
				}
				set
				{
					this.m_owner.m_singleSelectOpenNoticePanelImage = value;
				}
			}

			// Token: 0x170038F0 RID: 14576
			// (get) Token: 0x06012EA3 RID: 77475 RVA: 0x004D77A8 File Offset: 0x004D59A8
			// (set) Token: 0x06012EA4 RID: 77476 RVA: 0x004D77B8 File Offset: 0x004D59B8
			public GameObject m_singleSelectPanel
			{
				get
				{
					return this.m_owner.m_singleSelectPanel;
				}
				set
				{
					this.m_owner.m_singleSelectPanel = value;
				}
			}

			// Token: 0x170038F1 RID: 14577
			// (get) Token: 0x06012EA5 RID: 77477 RVA: 0x004D77C8 File Offset: 0x004D59C8
			// (set) Token: 0x06012EA6 RID: 77478 RVA: 0x004D77D8 File Offset: 0x004D59D8
			public GameObject m_singleHeroWordPanel
			{
				get
				{
					return this.m_owner.m_singleHeroWordPanel;
				}
				set
				{
					this.m_owner.m_singleHeroWordPanel = value;
				}
			}

			// Token: 0x170038F2 RID: 14578
			// (get) Token: 0x06012EA7 RID: 77479 RVA: 0x004D77E8 File Offset: 0x004D59E8
			// (set) Token: 0x06012EA8 RID: 77480 RVA: 0x004D77F8 File Offset: 0x004D59F8
			public Button m_singleSelectContinueImage
			{
				get
				{
					return this.m_owner.m_singleSelectContinueImage;
				}
				set
				{
					this.m_owner.m_singleSelectContinueImage = value;
				}
			}

			// Token: 0x170038F3 RID: 14579
			// (get) Token: 0x06012EA9 RID: 77481 RVA: 0x004D7808 File Offset: 0x004D5A08
			// (set) Token: 0x06012EAA RID: 77482 RVA: 0x004D7818 File Offset: 0x004D5A18
			public GameObject m_singleSelectNewTextObj
			{
				get
				{
					return this.m_owner.m_singleSelectNewTextObj;
				}
				set
				{
					this.m_owner.m_singleSelectNewTextObj = value;
				}
			}

			// Token: 0x170038F4 RID: 14580
			// (get) Token: 0x06012EAB RID: 77483 RVA: 0x004D7828 File Offset: 0x004D5A28
			// (set) Token: 0x06012EAC RID: 77484 RVA: 0x004D7838 File Offset: 0x004D5A38
			public GameObject m_singleSelectGetTextObj
			{
				get
				{
					return this.m_owner.m_singleSelectGetTextObj;
				}
				set
				{
					this.m_owner.m_singleSelectGetTextObj = value;
				}
			}

			// Token: 0x170038F5 RID: 14581
			// (get) Token: 0x06012EAD RID: 77485 RVA: 0x004D7848 File Offset: 0x004D5A48
			// (set) Token: 0x06012EAE RID: 77486 RVA: 0x004D7858 File Offset: 0x004D5A58
			public GameObject m_singleSelectStarGroupObj
			{
				get
				{
					return this.m_owner.m_singleSelectStarGroupObj;
				}
				set
				{
					this.m_owner.m_singleSelectStarGroupObj = value;
				}
			}

			// Token: 0x170038F6 RID: 14582
			// (get) Token: 0x06012EAF RID: 77487 RVA: 0x004D7868 File Offset: 0x004D5A68
			// (set) Token: 0x06012EB0 RID: 77488 RVA: 0x004D7878 File Offset: 0x004D5A78
			public Button m_selectSkipButton
			{
				get
				{
					return this.m_owner.m_selectSkipButton;
				}
				set
				{
					this.m_owner.m_selectSkipButton = value;
				}
			}

			// Token: 0x170038F7 RID: 14583
			// (get) Token: 0x06012EB1 RID: 77489 RVA: 0x004D7888 File Offset: 0x004D5A88
			// (set) Token: 0x06012EB2 RID: 77490 RVA: 0x004D7898 File Offset: 0x004D5A98
			public Image m_singleSelectItemImage
			{
				get
				{
					return this.m_owner.m_singleSelectItemImage;
				}
				set
				{
					this.m_owner.m_singleSelectItemImage = value;
				}
			}

			// Token: 0x170038F8 RID: 14584
			// (get) Token: 0x06012EB3 RID: 77491 RVA: 0x004D78A8 File Offset: 0x004D5AA8
			// (set) Token: 0x06012EB4 RID: 77492 RVA: 0x004D78B8 File Offset: 0x004D5AB8
			public Image m_singleSelectFragmentIconImg
			{
				get
				{
					return this.m_owner.m_singleSelectFragmentIconImg;
				}
				set
				{
					this.m_owner.m_singleSelectFragmentIconImg = value;
				}
			}

			// Token: 0x170038F9 RID: 14585
			// (get) Token: 0x06012EB5 RID: 77493 RVA: 0x004D78C8 File Offset: 0x004D5AC8
			// (set) Token: 0x06012EB6 RID: 77494 RVA: 0x004D78D8 File Offset: 0x004D5AD8
			public Text m_singleSelectFragmentCount
			{
				get
				{
					return this.m_owner.m_singleSelectFragmentCount;
				}
				set
				{
					this.m_owner.m_singleSelectFragmentCount = value;
				}
			}

			// Token: 0x170038FA RID: 14586
			// (get) Token: 0x06012EB7 RID: 77495 RVA: 0x004D78E8 File Offset: 0x004D5AE8
			// (set) Token: 0x06012EB8 RID: 77496 RVA: 0x004D78F8 File Offset: 0x004D5AF8
			public Image m_singleSelectFragmentSSRImg
			{
				get
				{
					return this.m_owner.m_singleSelectFragmentSSRImg;
				}
				set
				{
					this.m_owner.m_singleSelectFragmentSSRImg = value;
				}
			}

			// Token: 0x170038FB RID: 14587
			// (get) Token: 0x06012EB9 RID: 77497 RVA: 0x004D7908 File Offset: 0x004D5B08
			// (set) Token: 0x06012EBA RID: 77498 RVA: 0x004D7918 File Offset: 0x004D5B18
			public Image m_singleSelectFragmentSRImg
			{
				get
				{
					return this.m_owner.m_singleSelectFragmentSRImg;
				}
				set
				{
					this.m_owner.m_singleSelectFragmentSRImg = value;
				}
			}

			// Token: 0x170038FC RID: 14588
			// (get) Token: 0x06012EBB RID: 77499 RVA: 0x004D7928 File Offset: 0x004D5B28
			// (set) Token: 0x06012EBC RID: 77500 RVA: 0x004D7938 File Offset: 0x004D5B38
			public GameObject m_singleShareButtonDummy
			{
				get
				{
					return this.m_owner.m_singleShareButtonDummy;
				}
				set
				{
					this.m_owner.m_singleShareButtonDummy = value;
				}
			}

			// Token: 0x170038FD RID: 14589
			// (get) Token: 0x06012EBD RID: 77501 RVA: 0x004D7948 File Offset: 0x004D5B48
			// (set) Token: 0x06012EBE RID: 77502 RVA: 0x004D7958 File Offset: 0x004D5B58
			public GameObject m_sharePhotoDummy
			{
				get
				{
					return this.m_owner.m_sharePhotoDummy;
				}
				set
				{
					this.m_owner.m_sharePhotoDummy = value;
				}
			}

			// Token: 0x170038FE RID: 14590
			// (get) Token: 0x06012EBF RID: 77503 RVA: 0x004D7968 File Offset: 0x004D5B68
			// (set) Token: 0x06012EC0 RID: 77504 RVA: 0x004D7978 File Offset: 0x004D5B78
			public GameObject m_tenSelectPanel
			{
				get
				{
					return this.m_owner.m_tenSelectPanel;
				}
				set
				{
					this.m_owner.m_tenSelectPanel = value;
				}
			}

			// Token: 0x170038FF RID: 14591
			// (get) Token: 0x06012EC1 RID: 77505 RVA: 0x004D7988 File Offset: 0x004D5B88
			// (set) Token: 0x06012EC2 RID: 77506 RVA: 0x004D7998 File Offset: 0x004D5B98
			public GameObject m_tenSelectContentObj
			{
				get
				{
					return this.m_owner.m_tenSelectContentObj;
				}
				set
				{
					this.m_owner.m_tenSelectContentObj = value;
				}
			}

			// Token: 0x17003900 RID: 14592
			// (get) Token: 0x06012EC3 RID: 77507 RVA: 0x004D79A8 File Offset: 0x004D5BA8
			// (set) Token: 0x06012EC4 RID: 77508 RVA: 0x004D79B8 File Offset: 0x004D5BB8
			public Button m_afterSelectConfirmButton
			{
				get
				{
					return this.m_owner.m_afterSelectConfirmButton;
				}
				set
				{
					this.m_owner.m_afterSelectConfirmButton = value;
				}
			}

			// Token: 0x17003901 RID: 14593
			// (get) Token: 0x06012EC5 RID: 77509 RVA: 0x004D79C8 File Offset: 0x004D5BC8
			// (set) Token: 0x06012EC6 RID: 77510 RVA: 0x004D79D8 File Offset: 0x004D5BD8
			public Button m_selectAgainButton
			{
				get
				{
					return this.m_owner.m_selectAgainButton;
				}
				set
				{
					this.m_owner.m_selectAgainButton = value;
				}
			}

			// Token: 0x17003902 RID: 14594
			// (get) Token: 0x06012EC7 RID: 77511 RVA: 0x004D79E8 File Offset: 0x004D5BE8
			// (set) Token: 0x06012EC8 RID: 77512 RVA: 0x004D79F8 File Offset: 0x004D5BF8
			public GameObject m_selectAgainButtonSingleBgObj
			{
				get
				{
					return this.m_owner.m_selectAgainButtonSingleBgObj;
				}
				set
				{
					this.m_owner.m_selectAgainButtonSingleBgObj = value;
				}
			}

			// Token: 0x17003903 RID: 14595
			// (get) Token: 0x06012EC9 RID: 77513 RVA: 0x004D7A08 File Offset: 0x004D5C08
			// (set) Token: 0x06012ECA RID: 77514 RVA: 0x004D7A18 File Offset: 0x004D5C18
			public GameObject m_selectAgainButtonTenBgObj
			{
				get
				{
					return this.m_owner.m_selectAgainButtonTenBgObj;
				}
				set
				{
					this.m_owner.m_selectAgainButtonTenBgObj = value;
				}
			}

			// Token: 0x17003904 RID: 14596
			// (get) Token: 0x06012ECB RID: 77515 RVA: 0x004D7A28 File Offset: 0x004D5C28
			// (set) Token: 0x06012ECC RID: 77516 RVA: 0x004D7A38 File Offset: 0x004D5C38
			public Image m_selectAgainBtnIconImg
			{
				get
				{
					return this.m_owner.m_selectAgainBtnIconImg;
				}
				set
				{
					this.m_owner.m_selectAgainBtnIconImg = value;
				}
			}

			// Token: 0x17003905 RID: 14597
			// (get) Token: 0x06012ECD RID: 77517 RVA: 0x004D7A48 File Offset: 0x004D5C48
			// (set) Token: 0x06012ECE RID: 77518 RVA: 0x004D7A58 File Offset: 0x004D5C58
			public Text m_selectAgainBtnNumText
			{
				get
				{
					return this.m_owner.m_selectAgainBtnNumText;
				}
				set
				{
					this.m_owner.m_selectAgainBtnNumText = value;
				}
			}

			// Token: 0x17003906 RID: 14598
			// (get) Token: 0x06012ECF RID: 77519 RVA: 0x004D7A68 File Offset: 0x004D5C68
			// (set) Token: 0x06012ED0 RID: 77520 RVA: 0x004D7A78 File Offset: 0x004D5C78
			public Text m_selectAgainBtnTitleText
			{
				get
				{
					return this.m_owner.m_selectAgainBtnTitleText;
				}
				set
				{
					this.m_owner.m_selectAgainBtnTitleText = value;
				}
			}

			// Token: 0x17003907 RID: 14599
			// (get) Token: 0x06012ED1 RID: 77521 RVA: 0x004D7A88 File Offset: 0x004D5C88
			// (set) Token: 0x06012ED2 RID: 77522 RVA: 0x004D7A98 File Offset: 0x004D5C98
			public GameObject m_tenShareButtonDummy
			{
				get
				{
					return this.m_owner.m_tenShareButtonDummy;
				}
				set
				{
					this.m_owner.m_tenShareButtonDummy = value;
				}
			}

			// Token: 0x17003908 RID: 14600
			// (get) Token: 0x06012ED3 RID: 77523 RVA: 0x004D7AA8 File Offset: 0x004D5CA8
			// (set) Token: 0x06012ED4 RID: 77524 RVA: 0x004D7AB8 File Offset: 0x004D5CB8
			public Button m_diamondsAddBtn2
			{
				get
				{
					return this.m_owner.m_diamondsAddBtn2;
				}
				set
				{
					this.m_owner.m_diamondsAddBtn2 = value;
				}
			}

			// Token: 0x17003909 RID: 14601
			// (get) Token: 0x06012ED5 RID: 77525 RVA: 0x004D7AC8 File Offset: 0x004D5CC8
			// (set) Token: 0x06012ED6 RID: 77526 RVA: 0x004D7AD8 File Offset: 0x004D5CD8
			public GameObject m_changeCrystalToTicketPanel
			{
				get
				{
					return this.m_owner.m_changeCrystalToTicketPanel;
				}
				set
				{
					this.m_owner.m_changeCrystalToTicketPanel = value;
				}
			}

			// Token: 0x1700390A RID: 14602
			// (get) Token: 0x06012ED7 RID: 77527 RVA: 0x004D7AE8 File Offset: 0x004D5CE8
			// (set) Token: 0x06012ED8 RID: 77528 RVA: 0x004D7AF8 File Offset: 0x004D5CF8
			public Text m_changeCrystalToTicketPanelTip
			{
				get
				{
					return this.m_owner.m_changeCrystalToTicketPanelTip;
				}
				set
				{
					this.m_owner.m_changeCrystalToTicketPanelTip = value;
				}
			}

			// Token: 0x1700390B RID: 14603
			// (get) Token: 0x06012ED9 RID: 77529 RVA: 0x004D7B08 File Offset: 0x004D5D08
			// (set) Token: 0x06012EDA RID: 77530 RVA: 0x004D7B18 File Offset: 0x004D5D18
			public Button m_changeCrystalToTicketPanelCancelButton
			{
				get
				{
					return this.m_owner.m_changeCrystalToTicketPanelCancelButton;
				}
				set
				{
					this.m_owner.m_changeCrystalToTicketPanelCancelButton = value;
				}
			}

			// Token: 0x1700390C RID: 14604
			// (get) Token: 0x06012EDB RID: 77531 RVA: 0x004D7B28 File Offset: 0x004D5D28
			// (set) Token: 0x06012EDC RID: 77532 RVA: 0x004D7B38 File Offset: 0x004D5D38
			public Button m_changeCrystalToTicketPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_changeCrystalToTicketPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_changeCrystalToTicketPanelConfirmButton = value;
				}
			}

			// Token: 0x1700390D RID: 14605
			// (get) Token: 0x06012EDD RID: 77533 RVA: 0x004D7B48 File Offset: 0x004D5D48
			// (set) Token: 0x06012EDE RID: 77534 RVA: 0x004D7B58 File Offset: 0x004D5D58
			public GameObject m_crystalAndTicketNotEnoughPanel
			{
				get
				{
					return this.m_owner.m_crystalAndTicketNotEnoughPanel;
				}
				set
				{
					this.m_owner.m_crystalAndTicketNotEnoughPanel = value;
				}
			}

			// Token: 0x1700390E RID: 14606
			// (get) Token: 0x06012EDF RID: 77535 RVA: 0x004D7B68 File Offset: 0x004D5D68
			// (set) Token: 0x06012EE0 RID: 77536 RVA: 0x004D7B78 File Offset: 0x004D5D78
			public Text m_crystalAndTicketNotEnoughPanelTip
			{
				get
				{
					return this.m_owner.m_crystalAndTicketNotEnoughPanelTip;
				}
				set
				{
					this.m_owner.m_crystalAndTicketNotEnoughPanelTip = value;
				}
			}

			// Token: 0x1700390F RID: 14607
			// (get) Token: 0x06012EE1 RID: 77537 RVA: 0x004D7B88 File Offset: 0x004D5D88
			// (set) Token: 0x06012EE2 RID: 77538 RVA: 0x004D7B98 File Offset: 0x004D5D98
			public Button m_crystalAndTicketNotEnoughPanelCancelButton
			{
				get
				{
					return this.m_owner.m_crystalAndTicketNotEnoughPanelCancelButton;
				}
				set
				{
					this.m_owner.m_crystalAndTicketNotEnoughPanelCancelButton = value;
				}
			}

			// Token: 0x17003910 RID: 14608
			// (get) Token: 0x06012EE3 RID: 77539 RVA: 0x004D7BA8 File Offset: 0x004D5DA8
			// (set) Token: 0x06012EE4 RID: 77540 RVA: 0x004D7BB8 File Offset: 0x004D5DB8
			public Button m_crystalAndTicketNotEnoughPanelConfirmButton
			{
				get
				{
					return this.m_owner.m_crystalAndTicketNotEnoughPanelConfirmButton;
				}
				set
				{
					this.m_owner.m_crystalAndTicketNotEnoughPanelConfirmButton = value;
				}
			}

			// Token: 0x17003911 RID: 14609
			// (get) Token: 0x06012EE5 RID: 77541 RVA: 0x004D7BC8 File Offset: 0x004D5DC8
			// (set) Token: 0x06012EE6 RID: 77542 RVA: 0x004D7BD8 File Offset: 0x004D5DD8
			public Text m_afterSelectPanelNormalCardNumText
			{
				get
				{
					return this.m_owner.m_afterSelectPanelNormalCardNumText;
				}
				set
				{
					this.m_owner.m_afterSelectPanelNormalCardNumText = value;
				}
			}

			// Token: 0x17003912 RID: 14610
			// (get) Token: 0x06012EE7 RID: 77543 RVA: 0x004D7BE8 File Offset: 0x004D5DE8
			// (set) Token: 0x06012EE8 RID: 77544 RVA: 0x004D7BF8 File Offset: 0x004D5DF8
			public Text m_afterSelectPanelDiamondsCardNumText
			{
				get
				{
					return this.m_owner.m_afterSelectPanelDiamondsCardNumText;
				}
				set
				{
					this.m_owner.m_afterSelectPanelDiamondsCardNumText = value;
				}
			}

			// Token: 0x17003913 RID: 14611
			// (get) Token: 0x06012EE9 RID: 77545 RVA: 0x004D7C08 File Offset: 0x004D5E08
			// (set) Token: 0x06012EEA RID: 77546 RVA: 0x004D7C18 File Offset: 0x004D5E18
			public Text m_afterSelectPanelDiamondsNumText
			{
				get
				{
					return this.m_owner.m_afterSelectPanelDiamondsNumText;
				}
				set
				{
					this.m_owner.m_afterSelectPanelDiamondsNumText = value;
				}
			}

			// Token: 0x17003914 RID: 14612
			// (get) Token: 0x06012EEB RID: 77547 RVA: 0x004D7C28 File Offset: 0x004D5E28
			// (set) Token: 0x06012EEC RID: 77548 RVA: 0x004D7C38 File Offset: 0x004D5E38
			public Button m_archiveButton
			{
				get
				{
					return this.m_owner.m_archiveButton;
				}
				set
				{
					this.m_owner.m_archiveButton = value;
				}
			}

			// Token: 0x17003915 RID: 14613
			// (get) Token: 0x06012EED RID: 77549 RVA: 0x004D7C48 File Offset: 0x004D5E48
			// (set) Token: 0x06012EEE RID: 77550 RVA: 0x004D7C58 File Offset: 0x004D5E58
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

			// Token: 0x17003916 RID: 14614
			// (get) Token: 0x06012EEF RID: 77551 RVA: 0x004D7C68 File Offset: 0x004D5E68
			// (set) Token: 0x06012EF0 RID: 77552 RVA: 0x004D7C78 File Offset: 0x004D5E78
			public GameObject m_detailPanelObj
			{
				get
				{
					return this.m_owner.m_detailPanelObj;
				}
				set
				{
					this.m_owner.m_detailPanelObj = value;
				}
			}

			// Token: 0x17003917 RID: 14615
			// (get) Token: 0x06012EF1 RID: 77553 RVA: 0x004D7C88 File Offset: 0x004D5E88
			// (set) Token: 0x06012EF2 RID: 77554 RVA: 0x004D7C98 File Offset: 0x004D5E98
			public CommonUIStateController m_detailPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_detailPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_detailPanelStateCtrl = value;
				}
			}

			// Token: 0x17003918 RID: 14616
			// (get) Token: 0x06012EF3 RID: 77555 RVA: 0x004D7CA8 File Offset: 0x004D5EA8
			// (set) Token: 0x06012EF4 RID: 77556 RVA: 0x004D7CB8 File Offset: 0x004D5EB8
			public Button m_detailCloseButton
			{
				get
				{
					return this.m_owner.m_detailCloseButton;
				}
				set
				{
					this.m_owner.m_detailCloseButton = value;
				}
			}

			// Token: 0x17003919 RID: 14617
			// (get) Token: 0x06012EF5 RID: 77557 RVA: 0x004D7CC8 File Offset: 0x004D5EC8
			// (set) Token: 0x06012EF6 RID: 77558 RVA: 0x004D7CD8 File Offset: 0x004D5ED8
			public Button m_detailReturnBgButton
			{
				get
				{
					return this.m_owner.m_detailReturnBgButton;
				}
				set
				{
					this.m_owner.m_detailReturnBgButton = value;
				}
			}

			// Token: 0x1700391A RID: 14618
			// (get) Token: 0x06012EF7 RID: 77559 RVA: 0x004D7CE8 File Offset: 0x004D5EE8
			// (set) Token: 0x06012EF8 RID: 77560 RVA: 0x004D7CF8 File Offset: 0x004D5EF8
			public ScrollRect m_detailScrollRect
			{
				get
				{
					return this.m_owner.m_detailScrollRect;
				}
				set
				{
					this.m_owner.m_detailScrollRect = value;
				}
			}

			// Token: 0x1700391B RID: 14619
			// (get) Token: 0x06012EF9 RID: 77561 RVA: 0x004D7D08 File Offset: 0x004D5F08
			// (set) Token: 0x06012EFA RID: 77562 RVA: 0x004D7D18 File Offset: 0x004D5F18
			public Text m_detailWeightTitleText
			{
				get
				{
					return this.m_owner.m_detailWeightTitleText;
				}
				set
				{
					this.m_owner.m_detailWeightTitleText = value;
				}
			}

			// Token: 0x1700391C RID: 14620
			// (get) Token: 0x06012EFB RID: 77563 RVA: 0x004D7D28 File Offset: 0x004D5F28
			// (set) Token: 0x06012EFC RID: 77564 RVA: 0x004D7D38 File Offset: 0x004D5F38
			public Text m_detailSSRWeightText
			{
				get
				{
					return this.m_owner.m_detailSSRWeightText;
				}
				set
				{
					this.m_owner.m_detailSSRWeightText = value;
				}
			}

			// Token: 0x1700391D RID: 14621
			// (get) Token: 0x06012EFD RID: 77565 RVA: 0x004D7D48 File Offset: 0x004D5F48
			// (set) Token: 0x06012EFE RID: 77566 RVA: 0x004D7D58 File Offset: 0x004D5F58
			public Text m_detailSRWeightText
			{
				get
				{
					return this.m_owner.m_detailSRWeightText;
				}
				set
				{
					this.m_owner.m_detailSRWeightText = value;
				}
			}

			// Token: 0x1700391E RID: 14622
			// (get) Token: 0x06012EFF RID: 77567 RVA: 0x004D7D68 File Offset: 0x004D5F68
			// (set) Token: 0x06012F00 RID: 77568 RVA: 0x004D7D78 File Offset: 0x004D5F78
			public Text m_detailRWeightText
			{
				get
				{
					return this.m_owner.m_detailRWeightText;
				}
				set
				{
					this.m_owner.m_detailRWeightText = value;
				}
			}

			// Token: 0x1700391F RID: 14623
			// (get) Token: 0x06012F01 RID: 77569 RVA: 0x004D7D88 File Offset: 0x004D5F88
			// (set) Token: 0x06012F02 RID: 77570 RVA: 0x004D7D98 File Offset: 0x004D5F98
			public Text m_detailScrollViewContentTitleText
			{
				get
				{
					return this.m_owner.m_detailScrollViewContentTitleText;
				}
				set
				{
					this.m_owner.m_detailScrollViewContentTitleText = value;
				}
			}

			// Token: 0x17003920 RID: 14624
			// (get) Token: 0x06012F03 RID: 77571 RVA: 0x004D7DA8 File Offset: 0x004D5FA8
			// (set) Token: 0x06012F04 RID: 77572 RVA: 0x004D7DB8 File Offset: 0x004D5FB8
			public GameObject m_detailScrollViewContent
			{
				get
				{
					return this.m_owner.m_detailScrollViewContent;
				}
				set
				{
					this.m_owner.m_detailScrollViewContent = value;
				}
			}

			// Token: 0x17003921 RID: 14625
			// (get) Token: 0x06012F05 RID: 77573 RVA: 0x004D7DC8 File Offset: 0x004D5FC8
			// (set) Token: 0x06012F06 RID: 77574 RVA: 0x004D7DD8 File Offset: 0x004D5FD8
			public GameObject m_poolItemWithRankPrefab
			{
				get
				{
					return this.m_owner.m_poolItemWithRankPrefab;
				}
				set
				{
					this.m_owner.m_poolItemWithRankPrefab = value;
				}
			}

			// Token: 0x17003922 RID: 14626
			// (get) Token: 0x06012F07 RID: 77575 RVA: 0x004D7DE8 File Offset: 0x004D5FE8
			// (set) Token: 0x06012F08 RID: 77576 RVA: 0x004D7DF8 File Offset: 0x004D5FF8
			public Button m_weiBoShareOneButton
			{
				get
				{
					return this.m_owner.m_weiBoShareOneButton;
				}
				set
				{
					this.m_owner.m_weiBoShareOneButton = value;
				}
			}

			// Token: 0x17003923 RID: 14627
			// (get) Token: 0x06012F09 RID: 77577 RVA: 0x004D7E08 File Offset: 0x004D6008
			// (set) Token: 0x06012F0A RID: 77578 RVA: 0x004D7E18 File Offset: 0x004D6018
			public Button m_weChatShareOneButton
			{
				get
				{
					return this.m_owner.m_weChatShareOneButton;
				}
				set
				{
					this.m_owner.m_weChatShareOneButton = value;
				}
			}

			// Token: 0x17003924 RID: 14628
			// (get) Token: 0x06012F0B RID: 77579 RVA: 0x004D7E28 File Offset: 0x004D6028
			// (set) Token: 0x06012F0C RID: 77580 RVA: 0x004D7E38 File Offset: 0x004D6038
			public Button m_weiBoShareTenButton
			{
				get
				{
					return this.m_owner.m_weiBoShareTenButton;
				}
				set
				{
					this.m_owner.m_weiBoShareTenButton = value;
				}
			}

			// Token: 0x17003925 RID: 14629
			// (get) Token: 0x06012F0D RID: 77581 RVA: 0x004D7E48 File Offset: 0x004D6048
			// (set) Token: 0x06012F0E RID: 77582 RVA: 0x004D7E58 File Offset: 0x004D6058
			public Button m_weChatShareTenButton
			{
				get
				{
					return this.m_owner.m_weChatShareTenButton;
				}
				set
				{
					this.m_owner.m_weChatShareTenButton = value;
				}
			}

			// Token: 0x17003926 RID: 14630
			// (get) Token: 0x06012F0F RID: 77583 RVA: 0x004D7E68 File Offset: 0x004D6068
			// (set) Token: 0x06012F10 RID: 77584 RVA: 0x004D7E78 File Offset: 0x004D6078
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

			// Token: 0x17003927 RID: 14631
			// (get) Token: 0x06012F11 RID: 77585 RVA: 0x004D7E88 File Offset: 0x004D6088
			// (set) Token: 0x06012F12 RID: 77586 RVA: 0x004D7E98 File Offset: 0x004D6098
			public Text m_playerLvText
			{
				get
				{
					return this.m_owner.m_playerLvText;
				}
				set
				{
					this.m_owner.m_playerLvText = value;
				}
			}

			// Token: 0x17003928 RID: 14632
			// (get) Token: 0x06012F13 RID: 77587 RVA: 0x004D7EA8 File Offset: 0x004D60A8
			// (set) Token: 0x06012F14 RID: 77588 RVA: 0x004D7EB8 File Offset: 0x004D60B8
			public Text m_serverNameText
			{
				get
				{
					return this.m_owner.m_serverNameText;
				}
				set
				{
					this.m_owner.m_serverNameText = value;
				}
			}

			// Token: 0x17003929 RID: 14633
			// (get) Token: 0x06012F15 RID: 77589 RVA: 0x004D7EC8 File Offset: 0x004D60C8
			// (set) Token: 0x06012F16 RID: 77590 RVA: 0x004D7ED8 File Offset: 0x004D60D8
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

			// Token: 0x1700392A RID: 14634
			// (get) Token: 0x06012F17 RID: 77591 RVA: 0x004D7EE8 File Offset: 0x004D60E8
			// (set) Token: 0x06012F18 RID: 77592 RVA: 0x004D7EF8 File Offset: 0x004D60F8
			public int m_nToShareHeroId
			{
				get
				{
					return this.m_owner.m_nToShareHeroId;
				}
				set
				{
					this.m_owner.m_nToShareHeroId = value;
				}
			}

			// Token: 0x1700392B RID: 14635
			// (get) Token: 0x06012F19 RID: 77593 RVA: 0x004D7F08 File Offset: 0x004D6108
			// (set) Token: 0x06012F1A RID: 77594 RVA: 0x004D7F18 File Offset: 0x004D6118
			public int m_cardPoolId
			{
				get
				{
					return this.m_owner.m_cardPoolId;
				}
				set
				{
					this.m_owner.m_cardPoolId = value;
				}
			}

			// Token: 0x1700392C RID: 14636
			// (get) Token: 0x06012F1B RID: 77595 RVA: 0x004D7F28 File Offset: 0x004D6128
			// (set) Token: 0x06012F1C RID: 77596 RVA: 0x004D7F38 File Offset: 0x004D6138
			public CardPool m_cardPool
			{
				get
				{
					return this.m_owner.m_cardPool;
				}
				set
				{
					this.m_owner.m_cardPool = value;
				}
			}

			// Token: 0x1700392D RID: 14637
			// (get) Token: 0x06012F1D RID: 77597 RVA: 0x004D7F48 File Offset: 0x004D6148
			// (set) Token: 0x06012F1E RID: 77598 RVA: 0x004D7F58 File Offset: 0x004D6158
			public bool m_isClockHold
			{
				get
				{
					return this.m_owner.m_isClockHold;
				}
				set
				{
					this.m_owner.m_isClockHold = value;
				}
			}

			// Token: 0x1700392E RID: 14638
			// (get) Token: 0x06012F1F RID: 77599 RVA: 0x004D7F68 File Offset: 0x004D6168
			// (set) Token: 0x06012F20 RID: 77600 RVA: 0x004D7F78 File Offset: 0x004D6178
			public bool m_isSingleSelect
			{
				get
				{
					return this.m_owner.m_isSingleSelect;
				}
				set
				{
					this.m_owner.m_isSingleSelect = value;
				}
			}

			// Token: 0x1700392F RID: 14639
			// (get) Token: 0x06012F21 RID: 77601 RVA: 0x004D7F88 File Offset: 0x004D6188
			// (set) Token: 0x06012F22 RID: 77602 RVA: 0x004D7F98 File Offset: 0x004D6198
			public bool m_isContinueButtonClick
			{
				get
				{
					return this.m_owner.m_isContinueButtonClick;
				}
				set
				{
					this.m_owner.m_isContinueButtonClick = value;
				}
			}

			// Token: 0x17003930 RID: 14640
			// (get) Token: 0x06012F23 RID: 77603 RVA: 0x004D7FA8 File Offset: 0x004D61A8
			// (set) Token: 0x06012F24 RID: 77604 RVA: 0x004D7FB8 File Offset: 0x004D61B8
			public List<Goods> m_selectRewards
			{
				get
				{
					return this.m_owner.m_selectRewards;
				}
				set
				{
					this.m_owner.m_selectRewards = value;
				}
			}

			// Token: 0x17003931 RID: 14641
			// (get) Token: 0x06012F25 RID: 77605 RVA: 0x004D7FC8 File Offset: 0x004D61C8
			public static string PoolItemNameText
			{
				get
				{
					return "NameText";
				}
			}

			// Token: 0x17003932 RID: 14642
			// (get) Token: 0x06012F26 RID: 77606 RVA: 0x004D7FD0 File Offset: 0x004D61D0
			public static int NormalCardId
			{
				get
				{
					return 4000;
				}
			}

			// Token: 0x17003933 RID: 14643
			// (get) Token: 0x06012F27 RID: 77607 RVA: 0x004D7FD8 File Offset: 0x004D61D8
			public static int CrystalCardId
			{
				get
				{
					return 4001;
				}
			}

			// Token: 0x17003934 RID: 14644
			// (get) Token: 0x06012F28 RID: 77608 RVA: 0x004D7FE0 File Offset: 0x004D61E0
			// (set) Token: 0x06012F29 RID: 77609 RVA: 0x004D7FF0 File Offset: 0x004D61F0
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

			// Token: 0x17003935 RID: 14645
			// (get) Token: 0x06012F2A RID: 77610 RVA: 0x004D8000 File Offset: 0x004D6200
			// (set) Token: 0x06012F2B RID: 77611 RVA: 0x004D8010 File Offset: 0x004D6210
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

			// Token: 0x17003936 RID: 14646
			// (get) Token: 0x06012F2C RID: 77612 RVA: 0x004D8020 File Offset: 0x004D6220
			// (set) Token: 0x06012F2D RID: 77613 RVA: 0x004D8030 File Offset: 0x004D6230
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

			// Token: 0x17003937 RID: 14647
			// (get) Token: 0x06012F2E RID: 77614 RVA: 0x004D8040 File Offset: 0x004D6240
			// (set) Token: 0x06012F2F RID: 77615 RVA: 0x004D8050 File Offset: 0x004D6250
			public SelectCardBackground3DController m_selectCardBackground3DController
			{
				get
				{
					return this.m_owner.m_selectCardBackground3DController;
				}
				set
				{
					this.m_owner.m_selectCardBackground3DController = value;
				}
			}

			// Token: 0x17003938 RID: 14648
			// (get) Token: 0x06012F30 RID: 77616 RVA: 0x004D8060 File Offset: 0x004D6260
			// (set) Token: 0x06012F31 RID: 77617 RVA: 0x004D8070 File Offset: 0x004D6270
			public ShareTenSelectCardUIController m_shareTenSelectCardUIController
			{
				get
				{
					return this.m_owner.m_shareTenSelectCardUIController;
				}
				set
				{
					this.m_owner.m_shareTenSelectCardUIController = value;
				}
			}

			// Token: 0x17003939 RID: 14649
			// (get) Token: 0x06012F32 RID: 77618 RVA: 0x004D8080 File Offset: 0x004D6280
			// (set) Token: 0x06012F33 RID: 77619 RVA: 0x004D8090 File Offset: 0x004D6290
			public bool m_hasShowClockEffect
			{
				get
				{
					return this.m_owner.m_hasShowClockEffect;
				}
				set
				{
					this.m_owner.m_hasShowClockEffect = value;
				}
			}

			// Token: 0x1700393A RID: 14650
			// (get) Token: 0x06012F34 RID: 77620 RVA: 0x004D80A0 File Offset: 0x004D62A0
			// (set) Token: 0x06012F35 RID: 77621 RVA: 0x004D80B0 File Offset: 0x004D62B0
			public List<SummonToggleUIController> m_toggleCtrlList
			{
				get
				{
					return this.m_owner.m_toggleCtrlList;
				}
				set
				{
					this.m_owner.m_toggleCtrlList = value;
				}
			}

			// Token: 0x06012F36 RID: 77622 RVA: 0x004D80C0 File Offset: 0x004D62C0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012F37 RID: 77623 RVA: 0x004D80D0 File Offset: 0x004D62D0
			public IEnumerator PlayRewardsEffect(List<Goods> rewards)
			{
				return this.m_owner.PlayRewardsEffect(rewards);
			}

			// Token: 0x06012F38 RID: 77624 RVA: 0x004D80E0 File Offset: 0x004D62E0
			public IEnumerator PlaySingleRewardEffect(Goods goods, bool isNeedClockEffect, int rank, int maxRank, int index)
			{
				return this.m_owner.PlaySingleRewardEffect(goods, isNeedClockEffect, rank, maxRank, index);
			}

			// Token: 0x06012F39 RID: 77625 RVA: 0x004D80F4 File Offset: 0x004D62F4
			public void StopClockEffectSoundOnSkipButtonClick()
			{
				this.m_owner.StopClockEffectSoundOnSkipButtonClick();
			}

			// Token: 0x06012F3A RID: 77626 RVA: 0x004D8104 File Offset: 0x004D6304
			public IEnumerator AfterShowClockEffectFinished(Goods goods, int index, int rank)
			{
				return this.m_owner.AfterShowClockEffectFinished(goods, index, rank);
			}

			// Token: 0x06012F3B RID: 77627 RVA: 0x004D8114 File Offset: 0x004D6314
			public void OnClockButtonDrag(GameObject go)
			{
				this.m_owner.OnClockButtonDrag(go);
			}

			// Token: 0x06012F3C RID: 77628 RVA: 0x004D8124 File Offset: 0x004D6324
			public void OnContinueButtonClick()
			{
				this.m_owner.OnContinueButtonClick();
			}

			// Token: 0x06012F3D RID: 77629 RVA: 0x004D8134 File Offset: 0x004D6334
			public IEnumerator PlayTotalRewardsEffect()
			{
				return this.m_owner.PlayTotalRewardsEffect();
			}

			// Token: 0x06012F3E RID: 77630 RVA: 0x004D8144 File Offset: 0x004D6344
			public void SetAfterSelectCurrecyPanel()
			{
				this.m_owner.SetAfterSelectCurrecyPanel();
			}

			// Token: 0x06012F3F RID: 77631 RVA: 0x004D8154 File Offset: 0x004D6354
			public void SetSingleSelectRewardInfo(Goods goods, int index, int rank)
			{
				this.m_owner.SetSingleSelectRewardInfo(goods, index, rank);
			}

			// Token: 0x06012F40 RID: 77632 RVA: 0x004D8164 File Offset: 0x004D6364
			public void SetTenSelectRewardsInfo(List<Goods> goodsList)
			{
				this.m_owner.SetTenSelectRewardsInfo(goodsList);
			}

			// Token: 0x06012F41 RID: 77633 RVA: 0x004D8174 File Offset: 0x004D6374
			public void CreateCardPoolTabs()
			{
				this.m_owner.CreateCardPoolTabs();
			}

			// Token: 0x06012F42 RID: 77634 RVA: 0x004D8184 File Offset: 0x004D6384
			public void SummonToggleCtrl_EventOnToggleClick(SummonToggleUIController ctrl)
			{
				this.m_owner.SummonToggleCtrl_EventOnToggleClick(ctrl);
			}

			// Token: 0x06012F43 RID: 77635 RVA: 0x004D8194 File Offset: 0x004D6394
			public void SetValuesAfterToggleChanged()
			{
				this.m_owner.SetValuesAfterToggleChanged();
			}

			// Token: 0x06012F44 RID: 77636 RVA: 0x004D81A4 File Offset: 0x004D63A4
			public void SetSelectButton(Image iconImage, Text titleText, Text numText, bool isSingle)
			{
				this.m_owner.SetSelectButton(iconImage, titleText, numText, isSingle);
			}

			// Token: 0x06012F45 RID: 77637 RVA: 0x004D81B8 File Offset: 0x004D63B8
			public void OnActivityDetailButtonClick()
			{
				this.m_owner.OnActivityDetailButtonClick();
			}

			// Token: 0x06012F46 RID: 77638 RVA: 0x004D81C8 File Offset: 0x004D63C8
			public void OnSingleSelectButtonClick()
			{
				this.m_owner.OnSingleSelectButtonClick();
			}

			// Token: 0x06012F47 RID: 77639 RVA: 0x004D81D8 File Offset: 0x004D63D8
			public void OnTenSelectButtonClick()
			{
				this.m_owner.OnTenSelectButtonClick();
			}

			// Token: 0x06012F48 RID: 77640 RVA: 0x004D81E8 File Offset: 0x004D63E8
			public void OnSelectAgainButtonClick()
			{
				this.m_owner.OnSelectAgainButtonClick();
			}

			// Token: 0x06012F49 RID: 77641 RVA: 0x004D81F8 File Offset: 0x004D63F8
			public void ShowChangeCrystalToTicketPanel()
			{
				this.m_owner.ShowChangeCrystalToTicketPanel();
			}

			// Token: 0x06012F4A RID: 77642 RVA: 0x004D8208 File Offset: 0x004D6408
			public void ChangeCrystalToTicketPanelCancelButtonClick()
			{
				this.m_owner.ChangeCrystalToTicketPanelCancelButtonClick();
			}

			// Token: 0x06012F4B RID: 77643 RVA: 0x004D8218 File Offset: 0x004D6418
			public void CloseChangeCrystalToTicketPanel()
			{
				this.m_owner.CloseChangeCrystalToTicketPanel();
			}

			// Token: 0x06012F4C RID: 77644 RVA: 0x004D8228 File Offset: 0x004D6428
			public void ChangeCrystalToTicketPanelConfirmButtonClick()
			{
				this.m_owner.ChangeCrystalToTicketPanelConfirmButtonClick();
			}

			// Token: 0x06012F4D RID: 77645 RVA: 0x004D8238 File Offset: 0x004D6438
			public void ShowCrystalAndTicketNotEnoughPanel()
			{
				this.m_owner.ShowCrystalAndTicketNotEnoughPanel();
			}

			// Token: 0x06012F4E RID: 77646 RVA: 0x004D8248 File Offset: 0x004D6448
			public void CrystalAndTicketNotEnoughPanelCancelButtonClick()
			{
				this.m_owner.CrystalAndTicketNotEnoughPanelCancelButtonClick();
			}

			// Token: 0x06012F4F RID: 77647 RVA: 0x004D8258 File Offset: 0x004D6458
			public void CloseCrystalAndTicketNotEnoughPanel()
			{
				this.m_owner.CloseCrystalAndTicketNotEnoughPanel();
			}

			// Token: 0x06012F50 RID: 77648 RVA: 0x004D8268 File Offset: 0x004D6468
			public void CrystalAndTicketNotEnoughPanelConfirmButtonClick()
			{
				this.m_owner.CrystalAndTicketNotEnoughPanelConfirmButtonClick();
			}

			// Token: 0x06012F51 RID: 77649 RVA: 0x004D8278 File Offset: 0x004D6478
			public void OnBuyDiamondButtonClick()
			{
				this.m_owner.OnBuyDiamondButtonClick();
			}

			// Token: 0x06012F52 RID: 77650 RVA: 0x004D8288 File Offset: 0x004D6488
			public void OnAddCrystalBtnClick()
			{
				this.m_owner.OnAddCrystalBtnClick();
			}

			// Token: 0x06012F53 RID: 77651 RVA: 0x004D8298 File Offset: 0x004D6498
			public void OnAddCrystal()
			{
				this.m_owner.OnAddCrystal();
			}

			// Token: 0x06012F54 RID: 77652 RVA: 0x004D82A8 File Offset: 0x004D64A8
			public void SkipShowRewardEffect()
			{
				this.m_owner.SkipShowRewardEffect();
			}

			// Token: 0x06012F55 RID: 77653 RVA: 0x004D82B8 File Offset: 0x004D64B8
			public void Close3DUIEffect()
			{
				this.m_owner.Close3DUIEffect();
			}

			// Token: 0x06012F56 RID: 77654 RVA: 0x004D82C8 File Offset: 0x004D64C8
			public void CloseShowSelectRewardsPanel()
			{
				this.m_owner.CloseShowSelectRewardsPanel();
			}

			// Token: 0x06012F57 RID: 77655 RVA: 0x004D82D8 File Offset: 0x004D64D8
			public void ShowDetailScrollView()
			{
				this.m_owner.ShowDetailScrollView();
			}

			// Token: 0x06012F58 RID: 77656 RVA: 0x004D82E8 File Offset: 0x004D64E8
			public void CreatePoolItemPrefab(PoolContentItemData item)
			{
				this.m_owner.CreatePoolItemPrefab(item);
			}

			// Token: 0x06012F59 RID: 77657 RVA: 0x004D82F8 File Offset: 0x004D64F8
			public void OnDetailButtonClick()
			{
				this.m_owner.OnDetailButtonClick();
			}

			// Token: 0x06012F5A RID: 77658 RVA: 0x004D8308 File Offset: 0x004D6508
			public void OnCloseDetailPanelButtonClick()
			{
				this.m_owner.OnCloseDetailPanelButtonClick();
			}

			// Token: 0x06012F5B RID: 77659 RVA: 0x004D8318 File Offset: 0x004D6518
			public void OnArchiveButtonClick()
			{
				this.m_owner.OnArchiveButtonClick();
			}

			// Token: 0x06012F5C RID: 77660 RVA: 0x004D8328 File Offset: 0x004D6528
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06012F5D RID: 77661 RVA: 0x004D8338 File Offset: 0x004D6538
			public void OnWeiBoShareOnceClick()
			{
				this.m_owner.OnWeiBoShareOnceClick();
			}

			// Token: 0x06012F5E RID: 77662 RVA: 0x004D8348 File Offset: 0x004D6548
			public void OnWeChatShareOnceClick()
			{
				this.m_owner.OnWeChatShareOnceClick();
			}

			// Token: 0x06012F5F RID: 77663 RVA: 0x004D8358 File Offset: 0x004D6558
			public void OnWeiBoShareTenClick()
			{
				this.m_owner.OnWeiBoShareTenClick();
			}

			// Token: 0x06012F60 RID: 77664 RVA: 0x004D8368 File Offset: 0x004D6568
			public void OnWeChatShareTenClick()
			{
				this.m_owner.OnWeChatShareTenClick();
			}

			// Token: 0x06012F61 RID: 77665 RVA: 0x004D8378 File Offset: 0x004D6578
			public IEnumerator CaptureOnceFrame(int sharePlatform)
			{
				return this.m_owner.CaptureOnceFrame(sharePlatform);
			}

			// Token: 0x06012F62 RID: 77666 RVA: 0x004D8388 File Offset: 0x004D6588
			public IEnumerator CaptureTenFrame(int sharePlatform)
			{
				return this.m_owner.CaptureTenFrame(sharePlatform);
			}

			// Token: 0x0400A94D RID: 43341
			private SelectCardUIController m_owner;
		}
	}
}
