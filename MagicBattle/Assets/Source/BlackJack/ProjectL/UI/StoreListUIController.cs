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
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F21 RID: 3873
	[HotFix]
	public class StoreListUIController : UIControllerBase
	{
		// Token: 0x060133CD RID: 78797 RVA: 0x004E72E8 File Offset: 0x004E54E8
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
			this.m_storeUnderItemPool = new GameObjectPool<StoreItemUIController>();
			this.m_storeUnderItemPool.Setup(this.m_storeItemPrefab, this.m_scrollViewStoreContent);
			this.m_storeSelfChooseUIController = GameObjectUtility.AddControllerToGameObject<StoreSelfChooseUIController>(this.m_selfChoosePanel);
			this.m_storeSelfChooseUIController.Init(this);
			this.m_storeHeroSkinItemPool = new GameObjectPool<StoreHeroSkinItemUIController>();
			this.m_storeHeroSkinItemPool.Setup(this.m_storeHeroSkinItemPrefab, this.m_scrollViewHeroContent);
			this.m_storeSoldierSkinItemPool = new GameObjectPool<StoreSoldierSkinItemUIController>();
			this.m_storeSoldierSkinItemPool.Setup(this.m_storeSoldierSkinItemPrefab, this.m_scrollViewStoreContent);
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_refreshButton.onClick.AddListener(new UnityAction(this.OnRefreshButtonClick));
			this.m_itemBuyPanelCloseButton.onClick.AddListener(new UnityAction(this.OnItemBuyPanelBGButtonClick));
			this.m_boxBuyPanelCloseButton.onClick.AddListener(new UnityAction(this.OnBoxBuyPanelBGButtonClick));
			this.m_rechargePanelCloseButton.onClick.AddListener(new UnityAction(this.OnRechargePanelBGButtonClick));
			this.m_itemBuyButton.onClick.AddListener(new UnityAction(this.OnItemBuyButtonClick));
			this.m_boxBuyButton.onClick.AddListener(new UnityAction(this.OnBoxBuyButtonClick));
			this.m_rechargeBuyButton.onClick.AddListener(new UnityAction(this.OnRechargeBuyButtonClick));
			this.m_storePrivilegeBuyDetailPanelBGButon.onClick.AddListener(new UnityAction(this.OnMonthCardPanelBGButtonClick));
			this.m_storePrivilegeItemBuyButton.onClick.AddListener(new UnityAction(this.OnMonthCardBuyButtonClick));
			this.m_memoryEntranceButton.onClick.AddListener(new UnityAction(this.OnMemoryEntranceButtonClick));
			this.m_memoryExtractionPanelCloseButton.onClick.AddListener(new UnityAction(this.CloseMemoryExtractionPanel));
			this.m_memoryExtractionPanelBGReturnButton.onClick.AddListener(new UnityAction(this.CloseMemoryExtractionPanel));
			this.m_memoryExtractionPanelHelpButton.onClick.AddListener(new UnityAction(this.OnMemeryExtractionHelpButtonClick));
			this.m_memoryExtractionPanelExtractionButton.onClick.AddListener(new UnityAction(this.OnMemoryExtractionPanelExtractionButtonClick));
			this.m_subscribePanelPrivateButton.onClick.AddListener(new UnityAction(this.OnSubscribePrivateClick));
			this.m_subscribePanelCancelSubscribeButton.onClick.AddListener(new UnityAction(this.OnCancelSubscribeClick));
			this.m_rechargeToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnRechargeToggleValueChanged));
			this.m_presentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnPresentToggleValueChanged));
			this.m_crystalToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnCystalToggleValueChanged));
			this.m_skinToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSkinToggleValueChanged));
			this.m_mysteriousToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousToggleValueChanged));
			this.m_mysteriousBlackMarketToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousBlackMarketToggleValueChanged));
			this.m_mysteriousHonorToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousHonorToggleValueChanged));
			this.m_mysteriousMedalToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousMedalToggleValueChanged));
			this.m_mysteriousFriendshipToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousFriendshipToggleValueChanged));
			this.m_mysteriousUnionToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousUnionToggleValueChanged));
			this.m_mysteriousMemoryToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousMemoryToggleValueChanged));
			this.m_mysteriousEquipmentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnMysteriousEquipmentToggleValueChange));
			this.m_presentPresentToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnPresentPresentToggleValueChanged));
			this.m_presentPreogativeToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnPresentPreogativeToggleValueChanged));
			this.m_heroSkinToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSkinTab_HeroToggleValueChanged));
			this.m_soldierSkinToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSkinTab_SoldierToggleValueChanged));
			this.InitStoreSubType2Toggle();
			this.SaveOriginalScrollViewLocalPosition();
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x060133CE RID: 78798 RVA: 0x004E7794 File Offset: 0x004E5994
		public StoreHeroSkinItemUIController GetHeroSkinItemCtrlByFixedStoreItemId(int fixedStoreItemId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroSkinItemCtrlByFixedStoreItemIdInt32_hotfix != null)
			{
				return (StoreHeroSkinItemUIController)this.m_GetHeroSkinItemCtrlByFixedStoreItemIdInt32_hotfix.call(new object[]
				{
					this,
					fixedStoreItemId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (StoreHeroSkinItemUIController storeHeroSkinItemUIController in this.m_storeHeroSkinItemPool.GetList())
			{
				if (storeHeroSkinItemUIController.m_storeItemConfig != null && storeHeroSkinItemUIController.m_storeItemConfig.ID == fixedStoreItemId)
				{
					return storeHeroSkinItemUIController;
				}
			}
			return null;
		}

		// Token: 0x060133CF RID: 78799 RVA: 0x004E7884 File Offset: 0x004E5A84
		public void UpdateHeroSkinItemLimitTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroSkinItemLimitTime_hotfix != null)
			{
				this.m_UpdateHeroSkinItemLimitTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (StoreHeroSkinItemUIController storeHeroSkinItemUIController in this.m_storeHeroSkinItemPool.GetList())
			{
				if (storeHeroSkinItemUIController != null)
				{
					storeHeroSkinItemUIController.SetLimitTime();
				}
			}
		}

		// Token: 0x060133D0 RID: 78800 RVA: 0x004E7944 File Offset: 0x004E5B44
		private StoreType GetStoreTypeByStoreId(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStoreTypeByStoreIdStoreId_hotfix != null)
			{
				return (StoreType)this.m_GetStoreTypeByStoreIdStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			foreach (KeyValuePair<int, ConfigDataStoreInfo> keyValuePair in configDataLoader.GetAllConfigDataStoreInfo())
			{
				if (keyValuePair.Value.StoreID == storeId)
				{
					return keyValuePair.Value.Type;
				}
			}
			return StoreType.StoreType_None;
		}

		// Token: 0x060133D1 RID: 78801 RVA: 0x004E7A3C File Offset: 0x004E5C3C
		public void UpdateStore(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateStoreStoreId_hotfix != null)
			{
				this.m_UpdateStoreStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateToggles(storeId);
			this.m_storeType = this.GetStoreTypeByStoreId(storeId);
			this.m_storeId = storeId;
			switch (this.m_storeType)
			{
			case StoreType.StoreType_Static:
				this.UpdateFixedStore(storeId);
				break;
			case StoreType.StoreType_Random:
				this.UpdateRandomStore();
				break;
			case StoreType.StoreType_Recharge:
				this.UpdateRechargeStore();
				break;
			case StoreType.StoreType_Gift:
				this.UpdateGiftStore(storeId);
				break;
			}
			bool flag = this.m_playerContext.GetAllStarLvlMaxHeroFragements().Count > 0;
			bool flag2 = this.m_playerContext.IsMemoryStoreOpen();
			this.m_memoryEntranceButtonRedPoint.SetActive(flag);
			if (this.m_mysteriousToggle.isOn)
			{
				this.m_mysteriousMemoryToggle.gameObject.SetActive(flag || LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction || flag2);
			}
			if (storeId == StoreId.StoreId_Memory)
			{
				if (flag && !LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction)
				{
					LocalAccountConfig.Instance.SetHaveDoneMemoryExtraction(true);
				}
				if (!flag2 && (flag || LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction))
				{
					SendOpenMemoryStoreNetTask sendOpenMemoryStoreNetTask = new SendOpenMemoryStoreNetTask();
					sendOpenMemoryStoreNetTask.Start(null);
				}
				this.m_memoryEntranceButton.gameObject.SetActive(flag || LocalAccountConfig.Instance.Data.HaveDoneMemoryExtraction || flag2);
				string stateName = (!flag) ? "Grey" : "Normal";
				this.m_memoryEntranceButtonStateCtrl.SetToUIState(stateName, false, true);
			}
			else
			{
				this.m_memoryEntranceButton.gameObject.SetActive(false);
			}
		}

		// Token: 0x060133D2 RID: 78802 RVA: 0x004E7C4C File Offset: 0x004E5E4C
		protected void UpdateRechargeStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRechargeStore_hotfix != null)
			{
				this.m_UpdateRechargeStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateRechargeStoreInfo();
		}

		// Token: 0x060133D3 RID: 78803 RVA: 0x004E7CB4 File Offset: 0x004E5EB4
		protected void UpdateGiftStore(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGiftStoreStoreId_hotfix != null)
			{
				this.m_UpdateGiftStoreStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (storeId == StoreId.StoreId_Gift || storeId == StoreId.StoreId_Privilege)
			{
				this.UpdateGiftStoreInfo(storeId, this.m_storeUnderItemPool);
			}
		}

		// Token: 0x060133D4 RID: 78804 RVA: 0x004E7D4C File Offset: 0x004E5F4C
		protected void UpdateFixedStore(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFixedStoreStoreId_hotfix != null)
			{
				this.m_UpdateFixedStoreStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (storeId)
			{
			case StoreId.StoreId_Crystal:
			case StoreId.StoreId_Honor:
			case StoreId.StoreId_Friendship:
			case StoreId.StoreId_Medal:
			case StoreId.StoreId_Union:
			case StoreId.StoreId_Memory:
			case StoreId.StoreId_Equipment:
				this.UpdateFixedStoreInfo(storeId);
				break;
			case StoreId.StoreId_SkinHero:
				this.UpdateHeroSkinInfo(storeId, this.m_storeHeroSkinItemPool);
				break;
			case StoreId.StoreId_SkinSoldier:
				this.UpdateSoldierSkinInfo(storeId, this.m_storeSoldierSkinItemPool);
				return;
			}
		}

		// Token: 0x060133D5 RID: 78805 RVA: 0x004E7E28 File Offset: 0x004E6028
		protected void UpdateRandomStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRandomStore_hotfix != null)
			{
				this.m_UpdateRandomStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateRandomStoreInfo(StoreId.StoreId_BlackMarket);
		}

		// Token: 0x060133D6 RID: 78806 RVA: 0x004E7E90 File Offset: 0x004E6090
		protected void ClearPool()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPool_hotfix != null)
			{
				this.m_ClearPool_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeUnderItemPool.Deactive();
			this.m_storeHeroSkinItemPool.Deactive();
			this.m_storeSoldierSkinItemPool.Deactive();
		}

		// Token: 0x060133D7 RID: 78807 RVA: 0x004E7F14 File Offset: 0x004E6114
		protected void UpdateFixedStoreInfo(StoreId storeID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateFixedStoreInfoStoreId_hotfix != null)
			{
				this.m_UpdateFixedStoreInfoStoreId_hotfix.call(new object[]
				{
					this,
					storeID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDefaultState(true);
			this.SetFixedStoreInfo(storeID, this.m_storeUnderItemPool);
		}

		// Token: 0x060133D8 RID: 78808 RVA: 0x004E7F98 File Offset: 0x004E6198
		protected void UpdateHeroSkinInfo(StoreId storeID, GameObjectPool<StoreHeroSkinItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroSkinInfoStoreIdGameObjectPool`1_hotfix != null)
			{
				this.m_UpdateHeroSkinInfoStoreIdGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					storeID,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDefaultState(true);
			if (pool == null)
			{
				return;
			}
			this.m_fixedStoreID = storeID;
			List<FixedStoreItem> fixedStoreItemList = this.m_playerContext.GetFixedStoreItemList((int)storeID);
			if (fixedStoreItemList == null)
			{
				return;
			}
			fixedStoreItemList.Sort(new Comparison<FixedStoreItem>(this.FixedStoreSkinListSortFunc));
			foreach (FixedStoreItem heroSkinItemInfo in fixedStoreItemList)
			{
				bool flag;
				StoreHeroSkinItemUIController storeHeroSkinItemUIController = pool.Allocate(out flag);
				if (storeHeroSkinItemUIController != null)
				{
					if (flag)
					{
						storeHeroSkinItemUIController.EventOnClick += this.OnHeroSkinItemClick;
						storeHeroSkinItemUIController.EventOnSkinItemOutOfDate += this.OnSkinItemOutOfDate;
					}
					storeHeroSkinItemUIController.SetHeroSkinItemInfo(heroSkinItemInfo);
				}
			}
			this.m_currency3Icon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_ETicket-God.png");
			this.m_currency3CountText.text = this.m_playerContext.GetSkinTicket().ToString();
			this.m_currency3AddButton.onClick.RemoveAllListeners();
			this.m_currency3AddButton.gameObject.SetActive(true);
			this.m_currency3AddButton.onClick.AddListener(delegate()
			{
				if (this.EventOnExtraButtonClick != null)
				{
					this.EventOnExtraButtonClick(GoodsType.GoodsType_SkinTicket);
				}
			});
			this.m_currency3Obj.SetActive(true);
		}

		// Token: 0x060133D9 RID: 78809 RVA: 0x004E816C File Offset: 0x004E636C
		public void SetSkinTicketCountText()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkinTicketCountText_hotfix != null)
			{
				this.m_SetSkinTicketCountText_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currency3CountText.text = this.m_playerContext.GetSkinTicket().ToString();
		}

		// Token: 0x060133DA RID: 78810 RVA: 0x004E81F0 File Offset: 0x004E63F0
		protected void UpdateSoldierSkinInfo(StoreId storeID, GameObjectPool<StoreSoldierSkinItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSoldierSkinInfoStoreIdGameObjectPool`1_hotfix != null)
			{
				this.m_UpdateSoldierSkinInfoStoreIdGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					storeID,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDefaultState(true);
			if (pool == null)
			{
				return;
			}
			this.m_fixedStoreID = storeID;
			List<FixedStoreItem> fixedStoreItemList = this.m_playerContext.GetFixedStoreItemList((int)storeID);
			if (fixedStoreItemList == null)
			{
				return;
			}
			fixedStoreItemList.Sort(new Comparison<FixedStoreItem>(this.FixedStoreSkinListSortFunc));
			foreach (FixedStoreItem soldierSkinItemInfo in fixedStoreItemList)
			{
				bool flag;
				StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = pool.Allocate(out flag);
				if (storeSoldierSkinItemUIController != null)
				{
					if (flag)
					{
						storeSoldierSkinItemUIController.EventOnClick += this.OnSoldierSkinItemClick;
					}
					storeSoldierSkinItemUIController.SetSoldierSkinItemInfo(soldierSkinItemInfo);
				}
			}
			this.m_currency3Icon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_ETicket-God.png");
			this.m_currency3CountText.text = this.m_playerContext.GetSkinTicket().ToString();
			this.m_currency3AddButton.onClick.RemoveAllListeners();
			this.m_currency3AddButton.gameObject.SetActive(true);
			this.m_currency3AddButton.onClick.AddListener(delegate()
			{
				if (this.EventOnExtraButtonClick != null)
				{
					this.EventOnExtraButtonClick(GoodsType.GoodsType_SkinTicket);
				}
			});
			this.m_currency3Obj.SetActive(true);
		}

		// Token: 0x060133DB RID: 78811 RVA: 0x004E83B0 File Offset: 0x004E65B0
		protected void UpdateRandomStoreInfo(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRandomStoreInfoStoreId_hotfix != null)
			{
				this.m_UpdateRandomStoreInfoStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDefaultState(false);
			if (this.m_playerContext.FindRandomStoreByID((int)storeId) != null)
			{
				this.SetRandomStoreInfo(storeId, this.m_storeUnderItemPool);
			}
			else if (this.EventOnGetRandomStore != null)
			{
				this.EventOnGetRandomStore(storeId);
			}
		}

		// Token: 0x060133DC RID: 78812 RVA: 0x004E8464 File Offset: 0x004E6664
		protected void UpdateRechargeStoreInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRechargeStoreInfo_hotfix != null)
			{
				this.m_UpdateRechargeStoreInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDefaultState(true);
			this.SetRechargeStoreInfo(this.m_storeUnderItemPool);
		}

		// Token: 0x060133DD RID: 78813 RVA: 0x004E84D8 File Offset: 0x004E66D8
		protected void SetDefaultState(bool hideRefreshPanel = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDefaultStateBoolean_hotfix != null)
			{
				this.m_SetDefaultStateBoolean_hotfix.call(new object[]
				{
					this,
					hideRefreshPanel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currency1Icon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_Gold.png");
			this.m_currency1CountText.text = this.m_playerContext.GetGold().ToString();
			this.m_currency1AddButton.onClick.RemoveAllListeners();
			this.m_currency1AddButton.onClick.AddListener(delegate()
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Crystal);
			});
			this.m_currency1AddButton.gameObject.SetActive(true);
			this.m_currency1DescriptionButton.gameObject.SetActive(false);
			this.m_currency1Obj.SetActive(true);
			this.m_currency2Icon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MagicCrystal.png");
			this.m_currency2CountText.text = this.m_playerContext.GetCrystal().ToString();
			this.m_currency2AddButton.onClick.RemoveAllListeners();
			this.m_currency2DescriptionButton.gameObject.SetActive(false);
			this.m_currency2AddButton.onClick.AddListener(delegate()
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Recharge);
			});
			this.m_currency2AddButton.gameObject.SetActive(true);
			this.m_currency2Obj.SetActive(true);
			this.m_currency3Obj.SetActive(false);
			this.m_currency3AddButton.onClick.RemoveAllListeners();
			this.m_currency3AddButton.gameObject.SetActive(false);
			this.m_currency3DescriptionButton.onClick.RemoveAllListeners();
			this.m_currency3DescriptionButton.gameObject.SetActive(false);
			this.ClearPool();
			if (hideRefreshPanel)
			{
				this.HideRefreshPanel();
			}
			this.m_scrollViewStoreContent.transform.localPosition = this.m_scrollViewStoreContentOriginalLocalPos;
			this.m_scrollViewHeroContent.transform.localPosition = this.m_scrollViewHeroContentOriginalLocalPos;
		}

		// Token: 0x060133DE RID: 78814 RVA: 0x004E8704 File Offset: 0x004E6904
		protected void SetFixedStoreInfo(StoreId fixedStoreID, GameObjectPool<StoreItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFixedStoreInfoStoreIdGameObjectPool`1_hotfix != null)
			{
				this.m_SetFixedStoreInfoStoreIdGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					fixedStoreID,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pool == null)
			{
				return;
			}
			this.m_fixedStoreID = fixedStoreID;
			List<FixedStoreItem> fixedStoreItemList = this.m_playerContext.GetFixedStoreItemList((int)fixedStoreID);
			if (fixedStoreItemList == null)
			{
				return;
			}
			fixedStoreItemList.Sort(new Comparison<FixedStoreItem>(this.SortFixedStoreItemByUISort));
			List<StoreItemUIController> list = new List<StoreItemUIController>();
			foreach (FixedStoreItem fixedStoreItemInfo in fixedStoreItemList)
			{
				bool flag;
				StoreItemUIController ctrl = pool.Allocate(out flag);
				if (ctrl != null)
				{
					if (flag)
					{
						ctrl.EventOnClick += this.OnStoreItemClick;
					}
					ctrl.SetFixedStoreItemInfo(fixedStoreItemInfo);
					if (ctrl.m_extraCurrencyType != GoodsType.GoodsType_None && list.Find((StoreItemUIController item) => item.m_extraCurrencyType == ctrl.m_extraCurrencyType) == null)
					{
						list.Add(ctrl);
					}
				}
			}
			this.RefreshCurrencyDisplay(list);
		}

		// Token: 0x060133DF RID: 78815 RVA: 0x004E8898 File Offset: 0x004E6A98
		private int SortFixedStoreItemByUISort(FixedStoreItem a, FixedStoreItem b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortFixedStoreItemByUISortFixedStoreItemFixedStoreItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortFixedStoreItemByUISortFixedStoreItemFixedStoreItem_hotfix.call(new object[]
				{
					this,
					a,
					b
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(a.Id);
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo2 = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(b.Id);
			int num = configDataFixedStoreItemInfo.UISort - configDataFixedStoreItemInfo2.UISort;
			if (num != 0)
			{
				return (num <= 0) ? -1 : 1;
			}
			if (a.Id == b.Id)
			{
				return 0;
			}
			return (a.Id <= b.Id) ? -1 : 1;
		}

		// Token: 0x060133E0 RID: 78816 RVA: 0x004E8998 File Offset: 0x004E6B98
		protected void RefreshCurrencyDisplay(List<StoreItemUIController> currencyTypeList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshCurrencyDisplayList`1_hotfix != null)
			{
				this.m_RefreshCurrencyDisplayList`1_hotfix.call(new object[]
				{
					this,
					currencyTypeList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<StoreItemUIController> currencyTypeList = currencyTypeList2;
			StoreListUIController $this = this;
			if (currencyTypeList.Count >= 1)
			{
				this.m_currency3Icon.sprite = AssetUtility.Instance.GetSprite(currencyTypeList[0].m_extraCurrencyTypeIconString);
				this.m_currency3CountText.text = currencyTypeList[0].m_extraCurrencyCount.ToString();
				this.m_currency3AddButton.onClick.RemoveAllListeners();
				this.m_currency3AddButton.onClick.AddListener(delegate()
				{
					if ($this.EventOnExtraButtonClick != null)
					{
						$this.EventOnExtraButtonClick(currencyTypeList[0].m_extraCurrencyType);
					}
				});
				this.m_currency3AddButton.gameObject.SetActive(false);
				this.m_currency3DescriptionButton.onClick.RemoveAllListeners();
				this.m_currency3DescriptionButton.onClick.AddListener(delegate()
				{
					RewardGoodsDescUITask.StartUITask($this, currencyTypeList[0].m_extraCurrencyType, 0, 0, $this.m_currency3DescriptionButton.gameObject, true);
				});
				this.m_currency3DescriptionButton.gameObject.SetActive(true);
				this.m_currency3Obj.SetActive(true);
			}
			if (currencyTypeList.Count >= 2)
			{
				this.m_currency2Icon.sprite = AssetUtility.Instance.GetSprite(currencyTypeList[1].m_extraCurrencyTypeIconString);
				this.m_currency2CountText.text = currencyTypeList[1].m_extraCurrencyCount.ToString();
				this.m_currency2AddButton.onClick.RemoveAllListeners();
				this.m_currency2AddButton.onClick.AddListener(delegate()
				{
					if ($this.EventOnExtraButtonClick != null)
					{
						$this.EventOnExtraButtonClick(currencyTypeList[1].m_extraCurrencyType);
					}
				});
				this.m_currency2AddButton.gameObject.SetActive(false);
				this.m_currency2DescriptionButton.onClick.RemoveAllListeners();
				this.m_currency2DescriptionButton.onClick.AddListener(delegate()
				{
					RewardGoodsDescUITask.StartUITask($this, currencyTypeList[1].m_extraCurrencyType, 0, 0, $this.m_currency3DescriptionButton.gameObject, true);
				});
				this.m_currency2DescriptionButton.gameObject.SetActive(true);
				this.m_currency2Obj.SetActive(true);
			}
			if (currencyTypeList.Count >= 3)
			{
				this.m_currency1Icon.sprite = AssetUtility.Instance.GetSprite(currencyTypeList[2].m_extraCurrencyTypeIconString);
				this.m_currency1CountText.text = currencyTypeList[2].m_extraCurrencyCount.ToString();
				this.m_currency1AddButton.onClick.RemoveAllListeners();
				this.m_currency1AddButton.onClick.AddListener(delegate()
				{
					if ($this.EventOnExtraButtonClick != null)
					{
						$this.EventOnExtraButtonClick(currencyTypeList[2].m_extraCurrencyType);
					}
				});
				this.m_currency1AddButton.gameObject.SetActive(false);
				this.m_currency1DescriptionButton.onClick.RemoveAllListeners();
				this.m_currency1DescriptionButton.onClick.AddListener(delegate()
				{
					RewardGoodsDescUITask.StartUITask($this, currencyTypeList[2].m_extraCurrencyType, 0, 0, $this.m_currency3DescriptionButton.gameObject, true);
				});
				this.m_currency1DescriptionButton.gameObject.SetActive(true);
				this.m_currency1Obj.SetActive(true);
			}
		}

		// Token: 0x060133E1 RID: 78817 RVA: 0x004E8CC8 File Offset: 0x004E6EC8
		protected void SetRandomStoreInfo(StoreId storeId, GameObjectPool<StoreItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRandomStoreInfoStoreIdGameObjectPool`1_hotfix != null)
			{
				this.m_SetRandomStoreInfoStoreIdGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					storeId,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pool == null)
			{
				return;
			}
			this.m_randomStoreID = storeId;
			List<RandomStoreItem> randomStoreList = this.m_playerContext.GetRandomStoreList((int)storeId);
			if (randomStoreList == null)
			{
				return;
			}
			for (int i = 0; i < randomStoreList.Count; i++)
			{
				bool flag;
				StoreItemUIController ctrl = pool.Allocate(out flag);
				if (ctrl != null)
				{
					if (flag)
					{
						ctrl.EventOnClick += this.OnStoreItemClick;
					}
					ctrl.SetRandomStoreItemInfo(randomStoreList[i], i);
					if (ctrl.m_extraCurrencyType != GoodsType.GoodsType_None)
					{
						this.m_currency3Icon.sprite = AssetUtility.Instance.GetSprite(ctrl.m_extraCurrencyTypeIconString);
						this.m_currency3CountText.text = ctrl.m_extraCurrencyCount.ToString();
						this.m_currency3AddButton.onClick.RemoveAllListeners();
						this.m_currency3AddButton.gameObject.SetActive(true);
						this.m_currency3AddButton.onClick.AddListener(delegate()
						{
							if (this.EventOnExtraButtonClick != null)
							{
								this.EventOnExtraButtonClick(ctrl.m_extraCurrencyType);
							}
						});
						this.m_currency3Obj.SetActive(true);
					}
				}
			}
			this.SetRefreshPanel(storeId);
			this.ShowRefreshPanel();
		}

		// Token: 0x060133E2 RID: 78818 RVA: 0x004E8E84 File Offset: 0x004E7084
		protected void SetRechargeStoreInfo(GameObjectPool<StoreItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRechargeStoreInfoGameObjectPool`1_hotfix != null)
			{
				this.m_SetRechargeStoreInfoGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pool == null)
			{
				return;
			}
			StoreType storeType = StoreType.StoreType_Recharge;
			List<PDSDKGood> list = StoreUITask.PDSDKGetGoods();
			if (list == null)
			{
				return;
			}
			foreach (KeyValuePair<int, ConfigDataRechargeStoreItemInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataRechargeStoreItemInfo())
			{
				int realGoodsId = keyValuePair.Value.ID;
				PDSDKGood pdsdkgood = list.Find((PDSDKGood m) => m.m_ID == RMBStoreoreGoodsIdTools.GetGoodsId((int)storeType, realGoodsId));
				if (!string.IsNullOrEmpty(pdsdkgood.m_ID))
				{
					bool flag;
					StoreItemUIController storeItemUIController = pool.Allocate(out flag);
					if (storeItemUIController != null)
					{
						if (flag)
						{
							storeItemUIController.EventOnClick += this.OnStoreItemClick;
						}
						bool flag2 = this.m_playerContext.IsRechargeGoodsBought(realGoodsId);
						int cystalRewardNums;
						if (flag2)
						{
							cystalRewardNums = this.m_playerContext.GetRechargeCrystalRepeatlyBoughtRewardNums(realGoodsId);
						}
						else
						{
							cystalRewardNums = this.m_playerContext.GetRechargeCrystalFirstBoughtRewardNums(realGoodsId);
						}
						string rechargeGoodsIcon = this.m_playerContext.GetRechargeGoodsIcon(realGoodsId);
						string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_RechargeItemTitle);
						if (!string.IsNullOrEmpty(text))
						{
							text = string.Format(text, this.m_playerContext.GetRechargeCrystalOriginalNums(realGoodsId));
						}
						storeItemUIController.SetRechargeStoreItemInfo(realGoodsId, storeType, flag2, pdsdkgood.m_price, text, cystalRewardNums, rechargeGoodsIcon);
					}
				}
			}
		}

		// Token: 0x060133E3 RID: 78819 RVA: 0x004E90AC File Offset: 0x004E72AC
		protected void ShowRefreshPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRefreshPanel_hotfix != null)
			{
				this.m_ShowRefreshPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_refreshPanelUIStateCtrl.GetCurrentUIState() == null || this.m_refreshPanelUIStateCtrl.GetCurrentUIState().StateName == "Close" || this.m_refreshPanelUIStateCtrl.GetCurrentUIState().StateName == "Out")
			{
				UIUtility.SetUIStateOpen(this.m_refreshPanelUIStateCtrl, "Show", null, false, true);
			}
			else if (this.m_refreshPanelUIStateCtrl.GetCurrentUIState().StateName == "Show" || this.m_refreshPanelUIStateCtrl.GetCurrentUIState().StateName == "In")
			{
				UIUtility.SetUIStateOpen(this.m_refreshPanelUIStateCtrl, "In", null, false, true);
			}
		}

		// Token: 0x060133E4 RID: 78820 RVA: 0x004E91C4 File Offset: 0x004E73C4
		protected void HideRefreshPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideRefreshPanel_hotfix != null)
			{
				this.m_HideRefreshPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_refreshPanelUIStateCtrl.GetCurrentUIState() == null || this.m_refreshPanelUIStateCtrl.GetCurrentUIState().StateName == "Show" || this.m_refreshPanelUIStateCtrl.GetCurrentUIState().StateName == "In")
			{
				UIUtility.SetUIStateOpen(this.m_refreshPanelUIStateCtrl, "Close", null, false, true);
			}
			else if (UIUtility.GetUIStateCurrentStateName(this.m_refreshPanelUIStateCtrl) == "Close" || UIUtility.GetUIStateCurrentStateName(this.m_refreshPanelUIStateCtrl) == "Out")
			{
				UIUtility.SetUIStateOpen(this.m_refreshPanelUIStateCtrl, "Out", null, false, true);
			}
		}

		// Token: 0x060133E5 RID: 78821 RVA: 0x004E92D4 File Offset: 0x004E74D4
		protected void SetRefreshPanel(StoreId randomStoreID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRefreshPanelStoreId_hotfix != null)
			{
				this.m_SetRefreshPanelStoreId_hotfix.call(new object[]
				{
					this,
					randomStoreID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRandomStoreInfo configDataRandomStoreInfo = this.m_configDataLoader.GetConfigDataRandomStoreInfo((int)randomStoreID);
			this.m_refreshPriceText.text = configDataRandomStoreInfo.Price.ToString();
			this.SetRandomStoreCountDown();
			if (configDataRandomStoreInfo.CurrencyType == GoodsType.GoodsType_Gold)
			{
				this.m_refreshCurrencyTypeIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_Gold.png");
			}
			else if (configDataRandomStoreInfo.CurrencyType == GoodsType.GoodsType_Crystal)
			{
				this.m_refreshCurrencyTypeIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MagicCrystal.png");
			}
			this.m_refreshCurrencyTypeIconEffectGameObject.SetActive(configDataRandomStoreInfo.CurrencyType == GoodsType.GoodsType_Crystal);
			this.m_needRefreshPanel = true;
			int manualFlushNums = this.m_playerContext.GetManualFlushNums((int)randomStoreID);
			int configableConstId_RandomStoreManualFlushMaxNums = this.m_configDataLoader.ConfigableConstId_RandomStoreManualFlushMaxNums;
			this.m_refreshTimesText.text = configableConstId_RandomStoreManualFlushMaxNums - manualFlushNums + "/" + configableConstId_RandomStoreManualFlushMaxNums;
		}

		// Token: 0x060133E6 RID: 78822 RVA: 0x004E9420 File Offset: 0x004E7620
		public bool IsNeedRefreshPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedRefreshPanel_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedRefreshPanel_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_needRefreshPanel;
		}

		// Token: 0x060133E7 RID: 78823 RVA: 0x004E9494 File Offset: 0x004E7694
		public void StoreOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreOpenTween_hotfix != null)
			{
				this.m_StoreOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_storeType == StoreType.StoreType_Random)
			{
				UIUtility.SetUIStateOpen(this.m_storeUIStateCtrl, "ShowCanRefresh", null, false, true);
			}
			else if (this.m_storeType == StoreType.StoreType_Static)
			{
				UIUtility.SetUIStateOpen(this.m_storeUIStateCtrl, "ShowCanNotRefresh", null, false, true);
			}
		}

		// Token: 0x060133E8 RID: 78824 RVA: 0x004E9538 File Offset: 0x004E7738
		protected void OnStoreItemClick(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStoreItemClickStoreItemUIController_hotfix != null)
			{
				this.m_OnStoreItemClickStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetStoreBuyPanel(goCtrl);
		}

		// Token: 0x060133E9 RID: 78825 RVA: 0x004E95B0 File Offset: 0x004E77B0
		protected void OnHeroSkinItemClick(StoreHeroSkinItemUIController itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroSkinItemClickStoreHeroSkinItemUIController_hotfix != null)
			{
				this.m_OnHeroSkinItemClickStoreHeroSkinItemUIController_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFixedStoreHeroSkinItemClick != null)
			{
				this.EventOnFixedStoreHeroSkinItemClick(itemCtrl);
			}
		}

		// Token: 0x060133EA RID: 78826 RVA: 0x004E9638 File Offset: 0x004E7838
		private void OnSkinItemOutOfDate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinItemOutOfDate_hotfix != null)
			{
				this.m_OnSkinItemOutOfDate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkinItemOutOfDate != null)
			{
				this.EventOnSkinItemOutOfDate();
			}
		}

		// Token: 0x060133EB RID: 78827 RVA: 0x004E96B0 File Offset: 0x004E78B0
		protected void OnSoldierSkinItemClick(StoreSoldierSkinItemUIController itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix != null)
			{
				this.m_OnSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFixedStoreSoldierSkinItemClick != null)
			{
				this.EventOnFixedStoreSoldierSkinItemClick(itemCtrl);
			}
		}

		// Token: 0x060133EC RID: 78828 RVA: 0x004E9738 File Offset: 0x004E7938
		protected void SetStoreBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStoreBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetStoreBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goCtrl.m_storeType == StoreType.StoreType_Recharge)
			{
				if (this.EventOnRechargeStoreBuyClick != null)
				{
					this.EventOnRechargeStoreBuyClick(goCtrl.m_storeType, goCtrl.m_goodsID, 1);
				}
				return;
			}
			if (goCtrl.m_storeType == StoreType.StoreType_Gift)
			{
				this.SetGiftStoreBuyPanel(goCtrl);
				return;
			}
			ConfigDataItemInfo configDataItemInfo = null;
			if (goCtrl.m_goodsType == GoodsType.GoodsType_Item)
			{
				configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(goCtrl.m_goodsID);
				if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_SelfSelectedBox)
				{
					this.m_selfChoosePanel.SetActive(true);
					this.m_storeSelfChooseUIController.SetSelfChooseItemID(this.m_storeId, goCtrl);
					return;
				}
			}
			if ((configDataItemInfo != null && configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox) || goCtrl.m_haveFirstBuyReward)
			{
				this.SetBoxBuyPanel(goCtrl);
				UIUtility.SetUIStateOpen(this.m_boxBuyPanelUIStateController, "Show", null, false, true);
			}
			else
			{
				this.SetNormalItemBuyPanel(goCtrl);
			}
		}

		// Token: 0x060133ED RID: 78829 RVA: 0x004E9884 File Offset: 0x004E7A84
		private void SetNormalItemBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNormalItemBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetNormalItemBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetItemBuyPanel(goCtrl);
			if (goCtrl.m_goodsType == GoodsType.GoodsType_EnchantStone)
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "ResonanceInfoShow", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x060133EE RID: 78830 RVA: 0x004E9934 File Offset: 0x004E7B34
		protected void SetRechargeBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRechargeBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetRechargeBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsID = goCtrl.m_goodsID;
			this.m_storeType = goCtrl.m_storeType;
			string goodIdStr = RMBStoreoreGoodsIdTools.GetGoodsId((int)this.m_storeType, this.m_goodsID);
			PDSDKGood pdsdkgood = StoreUITask.PDSDKGetGoods().Find((PDSDKGood t) => t.m_ID == goodIdStr);
			string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_RechargeItemTitle);
			if (!string.IsNullOrEmpty(text))
			{
				text = string.Format(text, this.m_playerContext.GetRechargeCrystalOriginalNums(this.m_goodsID));
			}
			this.m_rechargeNameText.text = text;
			this.m_rechargePriceText.text = pdsdkgood.m_price.ToString();
			string rechargeGoodsIcon = this.m_playerContext.GetRechargeGoodsIcon(this.m_goodsID);
			this.m_rechargeIconImage.sprite = AssetUtility.Instance.GetSprite(rechargeGoodsIcon);
			this.m_rechargeHaveCountText.text = this.m_playerContext.GetCrystal().ToString();
			int rechargeCrystalOriginalNums = this.m_playerContext.GetRechargeCrystalOriginalNums(this.m_goodsID);
			this.m_rechargeGetCountText.text = string.Format("{0} {1}", this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_Crystal), rechargeCrystalOriginalNums);
			string format = string.Empty;
			int num;
			if (!this.m_playerContext.IsRechargeGoodsBought(this.m_goodsID))
			{
				num = this.m_playerContext.GetRechargeCrystalFirstBoughtRewardNums(this.m_goodsID);
				format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_FirstBuyPresent);
			}
			else
			{
				num = this.m_playerContext.GetRechargeCrystalRepeatlyBoughtRewardNums(this.m_goodsID);
				format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ExtraBuyPresent);
			}
			this.m_rechargeGetExtraCountText.text = string.Format(format, num);
		}

		// Token: 0x060133EF RID: 78831 RVA: 0x004E9B68 File Offset: 0x004E7D68
		protected void SetBoxBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBoxBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetBoxBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_boxListScrollViewContent);
			ConfigDataItemInfo configDataItemInfo = null;
			this.m_boxIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goCtrl.m_goodsType, goCtrl.m_goodsID));
			this.m_boxIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goCtrl.m_goodsType, goCtrl.m_goodsID));
			this.m_boxCountText.text = goCtrl.Count;
			this.m_boxNameText.text = goCtrl.ItemNameText.text;
			this.m_boxPriceIcon.sprite = goCtrl.PriceIcon.sprite;
			this.m_boxPriceIconEffectGameObject.SetActive(goCtrl.m_currentGoodCurrencyType == GoodsType.GoodsType_Crystal);
			this.m_boxPriceText.text = goCtrl.PriceText.text;
			this.m_boxHaveCountText.text = UIUtility.GetGoodsCount(goCtrl.m_goodsType, goCtrl.m_goodsID).ToString();
			this.m_fixedStoreItemGoodsID = goCtrl.m_fixedStoreItemGoodsID;
			this.m_goodsID = goCtrl.m_goodsID;
			this.m_index = goCtrl.m_index;
			if (goCtrl.m_goodsType == GoodsType.GoodsType_Item)
			{
				configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(goCtrl.m_goodsID);
			}
			this.m_isStaticBox = (configDataItemInfo != null && configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox);
			this.m_gainGoodsList.Clear();
			if (this.m_isStaticBox)
			{
				this.m_boxDescText.text = configDataItemInfo.Desc;
				List<Goods> reward = this.m_configDataLoader.GetConfigDataStaticBoxInfo(configDataItemInfo.FuncTypeParam1).Reward;
				if (reward != null)
				{
					foreach (Goods goods in reward)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_storeBoxItemPrefab);
						PrefabControllerCreater.CreateAllControllers(gameObject);
						BoxItemInfoUIController component = gameObject.GetComponent<BoxItemInfoUIController>();
						component.SetBoxItemInfo(goods, false);
						gameObject.transform.SetParent(this.m_boxListScrollViewContent.transform, false);
						this.m_gainGoodsList.Add(goods);
					}
				}
			}
			else
			{
				this.m_itemDescText.text = UIUtility.GetGoodsDesc(goCtrl.m_goodsType, goCtrl.m_goodsID);
				this.m_boxDescText.text = this.m_itemDescText.text;
			}
			if (this.m_storeType == StoreType.StoreType_Static)
			{
				List<Goods> firstReward = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(goCtrl.m_fixedStoreItemGoodsID).FirstReward;
				if (firstReward != null)
				{
					foreach (Goods goods2 in firstReward)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_storeBoxItemPrefab);
						PrefabControllerCreater.CreateAllControllers(gameObject2);
						BoxItemInfoUIController component2 = gameObject2.GetComponent<BoxItemInfoUIController>();
						component2.SetBoxItemInfo(goods2, true);
						gameObject2.transform.SetParent(this.m_boxListScrollViewContent.transform, false);
						this.m_gainGoodsList.Add(goods2);
					}
				}
			}
		}

		// Token: 0x060133F0 RID: 78832 RVA: 0x004E9EE0 File Offset: 0x004E80E0
		protected void SetItemBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetItemBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsID = goCtrl.m_goodsID;
			this.m_giftStoreItem = goCtrl.m_giftStoreItem;
			this.m_storeType = goCtrl.m_storeType;
			Goods goods = new Goods();
			this.m_itemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goCtrl.m_goodsType, goCtrl.m_goodsID));
			this.m_itemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goCtrl.m_goodsType, goCtrl.m_goodsID));
			this.m_itemNameText.text = goCtrl.ItemNameText.text;
			this.m_itemPriceIcon.sprite = goCtrl.PriceIcon.sprite;
			this.m_itemPriceIconEffectGameObject.SetActive(goCtrl.m_currentGoodCurrencyType == GoodsType.GoodsType_Crystal);
			this.m_itemPriceText.text = goCtrl.PriceText.text;
			this.m_fixedStoreItemGoodsID = goCtrl.m_fixedStoreItemGoodsID;
			this.m_index = goCtrl.m_index;
			this.m_itemCountText.gameObject.SetActive(false);
			this.m_itemCountBgGo.SetActive(false);
			this.SetEnchantStoneResonanceInfoPanel(goCtrl.m_goodsType, goCtrl.m_goodsID);
			if (goCtrl.m_goodsType == GoodsType.GoodsType_Crystal || goCtrl.m_goodsType == GoodsType.GoodsType_Gold || goCtrl.m_goodsType == GoodsType.GoodsType_ArenaHonour)
			{
				this.m_itemGoodCountObj.SetActive(false);
			}
			else if (goCtrl.m_goodsType == GoodsType.GoodsType_Equipment)
			{
				this.m_itemHaveCountText.text = this.m_playerContext.GetBagItemCountByTypeAndID(goCtrl.m_goodsType, goCtrl.m_goodsID).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			else
			{
				this.m_itemHaveCountText.text = UIUtility.GetGoodsCount(goCtrl.m_goodsType, goCtrl.m_goodsID).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			this.m_itemDescText.text = UIUtility.GetGoodsDesc(goCtrl.m_goodsType, goCtrl.m_goodsID);
			this.m_gainGoodsList.Clear();
			goods.GoodsType = goCtrl.m_goodsType;
			goods.Count = Convert.ToInt32(goCtrl.Count);
			bool flag = goods.GoodsType == GoodsType.GoodsType_Item || goods.GoodsType == GoodsType.GoodsType_JobMaterial || goods.GoodsType == GoodsType.GoodsType_Equipment || goods.GoodsType == GoodsType.GoodsType_EnchantStone || goods.GoodsType == GoodsType.GoodsType_Hero;
			if (flag)
			{
				goods.Id = goCtrl.m_goodsID;
				if (Convert.ToInt32(goCtrl.Count) > 1)
				{
					this.m_itemCountText.text = goCtrl.Count;
					this.m_itemCountText.gameObject.SetActive(true);
					this.m_itemCountBgGo.SetActive(true);
				}
				else
				{
					this.m_itemCountText.gameObject.SetActive(false);
					this.m_itemCountBgGo.SetActive(false);
				}
			}
			this.m_gainGoodsList.Add(goods);
		}

		// Token: 0x060133F1 RID: 78833 RVA: 0x004EA220 File Offset: 0x004E8420
		public void SetNormalItemBuyPanel(Goods goods, StoreItemUIController storeItemUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNormalItemBuyPanelGoodsStoreItemUIController_hotfix != null)
			{
				this.m_SetNormalItemBuyPanelGoodsStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goods,
					storeItemUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetItemBuyPanel(goods, storeItemUIController);
			if (goods.GoodsType == GoodsType.GoodsType_EnchantStone)
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "ResonanceInfoShow", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x060133F2 RID: 78834 RVA: 0x004EA2E0 File Offset: 0x004E84E0
		public void SetItemBuyPanel(Goods goods, StoreItemUIController storeItemUIController)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemBuyPanelGoodsStoreItemUIController_hotfix != null)
			{
				this.m_SetItemBuyPanelGoodsStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goods,
					storeItemUIController
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsID = goods.Id;
			this.m_fixedStoreItemGoodsID = storeItemUIController.m_fixedStoreItemGoodsID;
			this.m_itemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
			this.m_itemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goods.GoodsType, goods.Id));
			this.m_itemNameText.text = UIUtility.GetGoodsName(goods.GoodsType, goods.Id);
			GoodsType currentGoodCurrencyType = storeItemUIController.m_currentGoodCurrencyType;
			switch (currentGoodCurrencyType)
			{
			case GoodsType.GoodsType_MemoryEssence:
				this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MemoryEssence.png");
				break;
			case GoodsType.GoodsType_MithralStone:
				this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Icon_DragonScale_01.png");
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Icon_DragonScale_02.png");
				break;
			default:
				if (currentGoodCurrencyType != GoodsType.GoodsType_Gold)
				{
					if (currentGoodCurrencyType != GoodsType.GoodsType_Crystal)
					{
						switch (currentGoodCurrencyType)
						{
						case GoodsType.GoodsType_ArenaHonour:
							this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_PvpCoin.png");
							break;
						case GoodsType.GoodsType_FriendshipPoints:
							this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Friendship_1.png");
							break;
						}
					}
					else
					{
						this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MagicCrystal.png");
						this.m_itemPriceIconEffectGameObject.SetActive(true);
					}
				}
				else
				{
					this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_Gold.png");
				}
				break;
			}
			this.m_itemPriceText.text = storeItemUIController.PriceText.text;
			this.SetEnchantStoneResonanceInfoPanel(goods.GoodsType, goods.Id);
			if (goods.GoodsType == GoodsType.GoodsType_Crystal || goods.GoodsType == GoodsType.GoodsType_Gold || goods.GoodsType == GoodsType.GoodsType_ArenaHonour)
			{
				this.m_itemGoodCountObj.SetActive(false);
			}
			else if (goods.GoodsType == GoodsType.GoodsType_Equipment)
			{
				this.m_itemHaveCountText.text = this.m_playerContext.GetBagItemCountByTypeAndID(goods.GoodsType, goods.Id).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			else
			{
				this.m_itemHaveCountText.text = UIUtility.GetGoodsCount(goods.GoodsType, goods.Id).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			this.m_itemDescText.text = UIUtility.GetGoodsDesc(goods.GoodsType, goods.Id);
			this.m_gainGoodsList.Clear();
			bool flag = goods.GoodsType == GoodsType.GoodsType_Item || goods.GoodsType == GoodsType.GoodsType_JobMaterial || goods.GoodsType == GoodsType.GoodsType_Equipment || goods.GoodsType == GoodsType.GoodsType_EnchantStone || goods.GoodsType == GoodsType.GoodsType_Hero;
			if (flag)
			{
				if (Convert.ToInt32(goods.Count) > 1)
				{
					this.m_itemCountText.text = goods.Count.ToString();
					this.m_itemCountText.gameObject.SetActive(true);
					this.m_itemCountBgGo.SetActive(true);
				}
				else
				{
					this.m_itemCountText.gameObject.SetActive(false);
					this.m_itemCountBgGo.SetActive(false);
				}
			}
			this.m_gainGoodsList.Add(goods);
		}

		// Token: 0x060133F3 RID: 78835 RVA: 0x004EA6D8 File Offset: 0x004E88D8
		protected void SetEnchantStoneResonanceInfoPanel(GoodsType goodsType, int goodsID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnchantStoneResonanceInfoPanelGoodsTypeInt32_hotfix != null)
			{
				this.m_SetEnchantStoneResonanceInfoPanelGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsType == GoodsType.GoodsType_EnchantStone)
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(goodsID);
				if (configDataEnchantStoneInfo != null)
				{
					ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(configDataEnchantStoneInfo.Resonance_ID);
					this.m_resonanceInfoPanelNameText.text = configDataResonanceInfo.Name;
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
					this.m_resonanceInfoPanel2SuitInfoText.text = configDataSkillInfo.Desc;
					configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
					this.m_resonanceInfoPanel4SuitInfoText.text = configDataSkillInfo.Desc;
				}
			}
			this.m_resonanceInfoPanel.SetActive(false);
		}

		// Token: 0x060133F4 RID: 78836 RVA: 0x004EA7E8 File Offset: 0x004E89E8
		public void SetRandomStoreCountDown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRandomStoreCountDown_hotfix != null)
			{
				this.m_SetRandomStoreCountDown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRandomStoreInfo configDataRandomStoreInfo = this.m_configDataLoader.GetConfigDataRandomStoreInfo((int)this.m_randomStoreID);
			if (configDataRandomStoreInfo == null)
			{
				return;
			}
			if (configDataRandomStoreInfo.FlushRuleType == FlushRuleType.FlushRuleType_FixedTime)
			{
				this.m_refreshTimeText.text = configDataRandomStoreInfo.Param.ToString() + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Point);
				if (this.m_playerContext.GetServerTime() >= this.m_playerContext.GetNextFlushTime((int)this.m_randomStoreID) && this.m_storeType == StoreType.StoreType_Random && this.m_storeId == StoreId.StoreId_BlackMarket)
				{
					UIUtility.SetUIStateClose(this.m_boxBuyPanelUIStateController, "Close", null, false, true);
					UIUtility.SetUIStateClose(this.m_itemBuyPanelUIStateController, "Close", null, false, true);
					if (this.EventOnGetRandomStore != null)
					{
						this.EventOnGetRandomStore(this.m_randomStoreID);
					}
				}
			}
			else if (configDataRandomStoreInfo.FlushRuleType == FlushRuleType.FlushRuleType_Period)
			{
				TimeSpan timeSpan = this.m_playerContext.GetNextFlushTime((int)this.m_randomStoreID) - this.m_playerContext.GetServerTime();
				if (timeSpan.Hours >= 1)
				{
					this.m_refreshTimeText.text = timeSpan.Hours + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Hour);
				}
				else
				{
					this.m_refreshTimeText.text = string.Format("{0:D2}:{1:D2}", (timeSpan.Minutes >= 0) ? timeSpan.Minutes : 0, (timeSpan.Seconds >= 0) ? timeSpan.Seconds : 0);
					if (timeSpan.Minutes <= 0 && timeSpan.Seconds <= 0 && timeSpan.Milliseconds <= 0 && this.m_storeType == StoreType.StoreType_Random && this.m_storeId == StoreId.StoreId_BlackMarket)
					{
						UIUtility.SetUIStateClose(this.m_boxBuyPanelUIStateController, "Close", null, false, true);
						UIUtility.SetUIStateClose(this.m_itemBuyPanelUIStateController, "Close", null, false, true);
						if (this.EventOnGetRandomStore != null)
						{
							this.EventOnGetRandomStore(this.m_randomStoreID);
						}
					}
				}
			}
		}

		// Token: 0x060133F5 RID: 78837 RVA: 0x004EAA68 File Offset: 0x004E8C68
		public void OpenBuyPanel(StoreId storeId, int itemId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenBuyPanelStoreIdInt32_hotfix != null)
			{
				this.m_OpenBuyPanelStoreIdInt32_hotfix.call(new object[]
				{
					this,
					storeId,
					itemId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (storeId)
			{
			case StoreId.StoreId_Crystal:
			case StoreId.StoreId_Honor:
			case StoreId.StoreId_Friendship:
			case StoreId.StoreId_Medal:
			case StoreId.StoreId_Union:
			case StoreId.StoreId_Memory:
			case StoreId.StoreId_Equipment:
				if (this.m_storeUnderItemPool == null || this.m_storeUnderItemPool.GetList() == null)
				{
					return;
				}
				foreach (StoreItemUIController storeItemUIController in this.m_storeUnderItemPool.GetList())
				{
					if (storeItemUIController != null && storeItemUIController.m_fixedStoreItemGoodsID == itemId)
					{
						this.SetStoreBuyPanel(storeItemUIController);
						break;
					}
				}
				break;
			case StoreId.StoreId_SkinHero:
				if (this.m_storeHeroSkinItemPool == null || this.m_storeHeroSkinItemPool.GetList() == null)
				{
					return;
				}
				foreach (StoreHeroSkinItemUIController storeHeroSkinItemUIController in this.m_storeHeroSkinItemPool.GetList())
				{
					if (storeHeroSkinItemUIController != null && storeHeroSkinItemUIController.m_storeItemConfig.ItemId == itemId && storeHeroSkinItemUIController.m_storeItemConfig.ItemType == GoodsType.GoodsType_HeroSkin)
					{
						if (this.EventOnFixedStoreHeroSkinItemClick != null)
						{
							this.EventOnFixedStoreHeroSkinItemClick(storeHeroSkinItemUIController);
						}
						break;
					}
				}
				break;
			case StoreId.StoreId_SkinSoldier:
				if (this.m_storeSoldierSkinItemPool == null || this.m_storeSoldierSkinItemPool.GetList() == null)
				{
					return;
				}
				foreach (StoreSoldierSkinItemUIController storeSoldierSkinItemUIController in this.m_storeSoldierSkinItemPool.GetList())
				{
					if (storeSoldierSkinItemUIController != null && storeSoldierSkinItemUIController.m_storeItemConfig.ItemId == itemId && storeSoldierSkinItemUIController.m_storeItemConfig.ItemType == GoodsType.GoodsType_HeroSkin)
					{
						if (this.EventOnFixedStoreSoldierSkinItemClick != null)
						{
							this.EventOnFixedStoreSoldierSkinItemClick(storeSoldierSkinItemUIController);
						}
						break;
					}
				}
				break;
			case StoreId.StoreId_Gift:
				if (this.m_storeUnderItemPool == null || this.m_storeUnderItemPool.GetList() == null)
				{
					return;
				}
				foreach (StoreItemUIController storeItemUIController2 in this.m_storeUnderItemPool.GetList())
				{
					if (storeItemUIController2 != null && storeItemUIController2.m_giftStoreItem != null && storeItemUIController2.m_giftStoreItem.GoodsId == itemId)
					{
						this.SetStoreBuyPanel(storeItemUIController2);
						break;
					}
				}
				break;
			case StoreId.StoreId_Privilege:
				if (this.m_storeUnderItemPool == null || this.m_storeUnderItemPool.GetList() == null)
				{
					return;
				}
				foreach (StoreItemUIController storeItemUIController3 in this.m_storeUnderItemPool.GetList())
				{
					if (storeItemUIController3 != null && storeItemUIController3.m_goodsID == itemId && storeItemUIController3.m_goodsType == GoodsType.GoodsType_MonthCard)
					{
						if (this.IsStoreItemIOSSubscribeItem(storeItemUIController3))
						{
							UIUtility.SetUIStateOpen(this.m_storePrivilegeBuyDetailPanelStateCtrl, "ShowWithRules", null, false, true);
						}
						else
						{
							UIUtility.SetUIStateOpen(this.m_storePrivilegeBuyDetailPanelStateCtrl, "Show", null, false, true);
						}
						this.SetMothCardBuyPanel(storeItemUIController3);
						break;
					}
				}
				break;
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x060133F6 RID: 78838 RVA: 0x004EAEB4 File Offset: 0x004E90B4
		public StoreId CurStoreId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CurStoreId_hotfix != null)
				{
					return (StoreId)this.m_get_CurStoreId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_storeId;
			}
		}

		// Token: 0x060133F7 RID: 78839 RVA: 0x004EAF28 File Offset: 0x004E9128
		protected void UpdateGiftStoreInfo(StoreId storeID, GameObjectPool<StoreItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGiftStoreInfoStoreIdGameObjectPool`1_hotfix != null)
			{
				this.m_UpdateGiftStoreInfoStoreIdGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					storeID,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetDefaultState(true);
			this.SetGiftStoreInfo(storeID, pool);
		}

		// Token: 0x060133F8 RID: 78840 RVA: 0x004EAFB8 File Offset: 0x004E91B8
		protected void SetGiftStoreInfo(StoreId storeId, GameObjectPool<StoreItemUIController> pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGiftStoreInfoStoreIdGameObjectPool`1_hotfix != null)
			{
				this.m_SetGiftStoreInfoStoreIdGameObjectPool`1_hotfix.call(new object[]
				{
					this,
					storeId,
					pool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pool == null)
			{
				return;
			}
			List<GiftStoreItem> giftStoreItemList = this.m_playerContext.GetGiftStoreItemList();
			List<PDSDKGood> list = StoreUITask.PDSDKGetGoods();
			using (List<GiftStoreItem>.Enumerator enumerator = giftStoreItemList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					StoreListUIController.<SetGiftStoreInfo>c__AnonStorey6 <SetGiftStoreInfo>c__AnonStorey = new StoreListUIController.<SetGiftStoreInfo>c__AnonStorey6();
					<SetGiftStoreInfo>c__AnonStorey.gift = enumerator.Current;
					if (<SetGiftStoreInfo>c__AnonStorey.gift.Config != null)
					{
						if (<SetGiftStoreInfo>c__AnonStorey.gift.Config.StoreId == storeId)
						{
							PDSDKGoodType m_giftType = UIUtility.GetGiftItemPdsdkGoodType(<SetGiftStoreInfo>c__AnonStorey.gift.Config.FirstPrice, <SetGiftStoreInfo>c__AnonStorey.gift.Config.NormalPrice, <SetGiftStoreInfo>c__AnonStorey.gift.IsFirstBuy, <SetGiftStoreInfo>c__AnonStorey.gift.Config.IsAppleSubscribe);
							PDSDKGood pdsdkgood = list.Find((PDSDKGood elem) => elem.m_ID == RMBStoreoreGoodsIdTools.GetGoodsId(4, <SetGiftStoreInfo>c__AnonStorey.gift.GoodsId) && elem.m_type == m_giftType);
							if (!string.IsNullOrEmpty(pdsdkgood.m_ID))
							{
								bool flag;
								StoreItemUIController storeItemUIController = pool.Allocate(out flag);
								if (storeItemUIController != null)
								{
									if (flag)
									{
										storeItemUIController.EventOnClick += this.OnStoreItemClick;
									}
									GoodsType itemType = <SetGiftStoreInfo>c__AnonStorey.gift.Config.ItemType;
									if (itemType != GoodsType.GoodsType_MonthCard)
									{
										storeItemUIController.SetGiftStoreItemInfo(<SetGiftStoreInfo>c__AnonStorey.gift, pdsdkgood.m_price, m_giftType);
									}
									else
									{
										storeItemUIController.SetGiftStoreMothCardItemInfo(<SetGiftStoreInfo>c__AnonStorey.gift, pdsdkgood.m_price, m_giftType);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060133F9 RID: 78841 RVA: 0x004EB1F0 File Offset: 0x004E93F0
		protected void SetGiftStoreBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGiftStoreBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetGiftStoreBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GoodsType goodsType = goCtrl.m_goodsType;
			if (goodsType != GoodsType.GoodsType_Item)
			{
				if (goodsType != GoodsType.GoodsType_MonthCard)
				{
					this.SetNormalItemBuyPanel(goCtrl);
				}
				else
				{
					if (this.IsStoreItemIOSSubscribeItem(goCtrl))
					{
						UIUtility.SetUIStateOpen(this.m_storePrivilegeBuyDetailPanelStateCtrl, "ShowWithRules", null, false, true);
					}
					else
					{
						UIUtility.SetUIStateOpen(this.m_storePrivilegeBuyDetailPanelStateCtrl, "Show", null, false, true);
					}
					this.SetMothCardBuyPanel(goCtrl);
				}
			}
			else
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(goCtrl.m_goodsID);
				if (configDataItemInfo == null)
				{
					return;
				}
				List<Goods> firstReward = goCtrl.m_giftStoreItem.Config.FirstReward;
				bool flag = goCtrl.m_giftStoreItem.IsFirstBuy && firstReward != null && firstReward.Count > 0;
				if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox || flag)
				{
					this.SetGiftStoreStaticBoxBuyPanel(goCtrl, configDataItemInfo);
					UIUtility.SetUIStateOpen(this.m_boxBuyPanelUIStateController, "Show", null, false, true);
				}
				else
				{
					this.SetNormalItemBuyPanel(goCtrl);
				}
			}
		}

		// Token: 0x060133FA RID: 78842 RVA: 0x004EB358 File Offset: 0x004E9558
		protected void SetGiftStoreStaticBoxBuyPanel(StoreItemUIController ctrl, ConfigDataItemInfo itemInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGiftStoreStaticBoxBuyPanelStoreItemUIControllerConfigDataItemInfo_hotfix != null)
			{
				this.m_SetGiftStoreStaticBoxBuyPanelStoreItemUIControllerConfigDataItemInfo_hotfix.call(new object[]
				{
					this,
					ctrl,
					itemInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_boxListScrollViewContent);
			this.m_giftStoreItem = ctrl.m_giftStoreItem;
			this.m_goodsID = ctrl.m_goodsID;
			this.m_storeType = ctrl.m_storeType;
			this.m_boxIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(ctrl.m_goodsType, this.m_goodsID));
			this.m_boxIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(ctrl.m_goodsType, this.m_goodsID));
			this.m_boxCountText.text = ctrl.Count;
			this.m_boxNameText.text = ctrl.ItemNameText.text;
			this.m_boxPriceIcon.sprite = ctrl.PriceIcon.sprite;
			this.m_boxPriceIconEffectGameObject.SetActive(false);
			this.m_boxPriceText.text = ctrl.PriceText.text;
			this.m_boxHaveCountText.text = UIUtility.GetGoodsCount(ctrl.m_goodsType, this.m_goodsID).ToString();
			this.m_index = ctrl.m_index;
			this.m_gainGoodsList.Clear();
			this.m_boxDescText.text = itemInfo.Desc;
			List<Goods> list = new List<Goods>();
			if (itemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox)
			{
				list = this.m_configDataLoader.GetConfigDataStaticBoxInfo(itemInfo.FuncTypeParam1).Reward;
				if (list != null)
				{
					foreach (Goods goods in list)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_storeBoxItemPrefab);
						PrefabControllerCreater.CreateAllControllers(gameObject);
						BoxItemInfoUIController component = gameObject.GetComponent<BoxItemInfoUIController>();
						component.SetBoxItemInfo(goods, false);
						gameObject.transform.SetParent(this.m_boxListScrollViewContent.transform, false);
						this.m_gainGoodsList.Add(goods);
					}
				}
			}
			if (this.m_giftStoreItem.IsFirstBuy && this.m_giftStoreItem.Config.FirstReward != null)
			{
				foreach (Goods goods2 in this.m_giftStoreItem.Config.FirstReward)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_storeBoxItemPrefab);
					PrefabControllerCreater.CreateAllControllers(gameObject2);
					BoxItemInfoUIController component2 = gameObject2.GetComponent<BoxItemInfoUIController>();
					component2.SetBoxItemInfo(goods2, true);
					gameObject2.transform.SetParent(this.m_boxListScrollViewContent.transform, false);
					this.m_gainGoodsList.Add(goods2);
				}
			}
		}

		// Token: 0x060133FB RID: 78843 RVA: 0x004EB684 File Offset: 0x004E9884
		protected void SetMothCardBuyPanel(StoreItemUIController goCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMothCardBuyPanelStoreItemUIController_hotfix != null)
			{
				this.m_SetMothCardBuyPanelStoreItemUIController_hotfix.call(new object[]
				{
					this,
					goCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftStoreItem = goCtrl.m_giftStoreItem;
			this.m_goodsID = goCtrl.m_goodsID;
			this.m_storeType = goCtrl.m_storeType;
			ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(this.m_goodsID);
			if (configDataMonthCardInfo == null)
			{
				return;
			}
			this.m_storePrivilegeItemCountText.text = goCtrl.Count;
			this.m_StorePrivilegeItemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goCtrl.m_goodsType, this.m_goodsID));
			this.m_StorePrivilegeItemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goCtrl.m_goodsType, this.m_goodsID));
			string text = goCtrl.PriceText.text;
			this.m_StorePrivilegeItemName.text = goCtrl.ItemNameText.text;
			this.m_storePrivilegeItemBuyPrice.text = text;
			this.m_storePrivilegeItemDescText.text = configDataMonthCardInfo.Desc;
			TimeSpan monthCardLeftTime = this.m_playerContext.GetMonthCardLeftTime(this.m_goodsID);
			if (monthCardLeftTime.TotalMilliseconds < 9.9999997473787516E-05)
			{
				this.m_storePrivilegeItemLeftDayGameObject.SetActive(false);
			}
			else
			{
				this.m_storePrivilegeItemLeftDayGameObject.SetActive(true);
				this.m_storePrivilegeItemLeftDay.text = string.Format("{0}{1}", this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Common_Remain), UIUtility.TimeSpanToString2(monthCardLeftTime));
			}
			if (UIUtility.IsIosSubscribe(configDataMonthCardInfo.IsAppleSubscribe))
			{
				this.m_storePrivilegeStateCtrl.SetToUIState("Subscribe", false, true);
				this.m_subscribePrice.text = string.Format("{0}/{1}{2}", text, configDataMonthCardInfo.ValidDays, this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day));
			}
			else if (configDataMonthCardInfo.Reward.Count > 0)
			{
				this.m_storePrivilegeStateCtrl.SetToUIState("Month", false, true);
				this.m_storeMonthExtraRewardCount.text = configDataMonthCardInfo.Reward[0].Count.ToString();
			}
			else
			{
				this.m_storePrivilegeStateCtrl.SetToUIState("MonthNoDesc", false, true);
			}
		}

		// Token: 0x060133FC RID: 78844 RVA: 0x004EB8F8 File Offset: 0x004E9AF8
		protected void OnPresentPresentToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPresentPresentToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnPresentPresentToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Gift);
			}
		}

		// Token: 0x060133FD RID: 78845 RVA: 0x004EB984 File Offset: 0x004E9B84
		protected void OnPresentPreogativeToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPresentPreogativeToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnPresentPreogativeToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Privilege);
			}
		}

		// Token: 0x060133FE RID: 78846 RVA: 0x004EBA10 File Offset: 0x004E9C10
		protected void OnMonthCardBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardBuyButtonClick_hotfix != null)
			{
				this.m_OnMonthCardBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGiftStoreBuyClick != null)
			{
				this.EventOnGiftStoreBuyClick(this.m_giftStoreItem.Config, this.m_giftStoreItem.IsFirstBuy, 1);
			}
			this.OnMonthCardPanelBGButtonClick();
		}

		// Token: 0x060133FF RID: 78847 RVA: 0x004EBAA4 File Offset: 0x004E9CA4
		protected void OnSubscribePrivateClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSubscribePrivateClick_hotfix != null)
			{
				this.m_OnSubscribePrivateClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string value = this.m_configDataLoader.GetConfigDataStringTable(3009).Value;
			Application.OpenURL(value);
		}

		// Token: 0x06013400 RID: 78848 RVA: 0x004EBB20 File Offset: 0x004E9D20
		protected void OnCancelSubscribeClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelSubscribeClick_hotfix != null)
			{
				this.m_OnCancelSubscribeClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string value = this.m_configDataLoader.GetConfigDataStringTable(3010).Value;
			Application.OpenURL(value);
		}

		// Token: 0x06013401 RID: 78849 RVA: 0x004EBB9C File Offset: 0x004E9D9C
		protected void OnMonthCardPanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardPanelBGButtonClick_hotfix != null)
			{
				this.m_OnMonthCardPanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string uistateCurrentStateName = UIUtility.GetUIStateCurrentStateName(this.m_storePrivilegeBuyDetailPanelStateCtrl);
			if (uistateCurrentStateName == "ShowWithRules")
			{
				UIUtility.SetUIStateClose(this.m_storePrivilegeBuyDetailPanelStateCtrl, "CloseWithRules", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateClose(this.m_storePrivilegeBuyDetailPanelStateCtrl, "Close", null, false, true);
			}
		}

		// Token: 0x06013402 RID: 78850 RVA: 0x004EBC44 File Offset: 0x004E9E44
		protected void OnPresentToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPresentToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnPresentToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Gift);
			}
		}

		// Token: 0x06013403 RID: 78851 RVA: 0x004EBCD0 File Offset: 0x004E9ED0
		protected void OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClick_hotfix != null)
			{
				this.m_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeType = StoreType.StoreType_None;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x06013404 RID: 78852 RVA: 0x004EBD50 File Offset: 0x004E9F50
		protected void OnRefreshButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRefreshButtonClick_hotfix != null)
			{
				this.m_OnRefreshButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanManualRefreshRandomStore(1);
			if (num == 0)
			{
				if (this.EventOnRefreshRandomStore != null)
				{
					this.EventOnRefreshRandomStore(StoreId.StoreId_BlackMarket);
				}
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
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06013405 RID: 78853 RVA: 0x004EBE18 File Offset: 0x004EA018
		protected void OnItemBuyPanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemBuyPanelBGButtonClick_hotfix != null)
			{
				this.m_OnItemBuyPanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_itemBuyPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x06013406 RID: 78854 RVA: 0x004EBE8C File Offset: 0x004EA08C
		protected void OnItemBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemBuyButtonClick_hotfix != null)
			{
				this.m_OnItemBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_storeType == StoreType.StoreType_Gift)
			{
				if (this.EventOnGiftStoreBuyClick != null)
				{
					this.EventOnGiftStoreBuyClick(this.m_giftStoreItem.Config, this.m_giftStoreItem.IsFirstBuy, 1);
				}
			}
			else if (this.m_storeType == StoreType.StoreType_Static)
			{
				if (this.EventOnFixedStoreItemBuyClick != null)
				{
					this.EventOnFixedStoreItemBuyClick(this.m_fixedStoreID, this.m_fixedStoreItemGoodsID, this.m_goodsID, this.m_selfChooseItemIndex, this.m_gainGoodsList);
				}
			}
			else if (this.m_storeType == StoreType.StoreType_Random && this.EventOnRandomStoreItemBuyClick != null)
			{
				this.EventOnRandomStoreItemBuyClick(this.m_randomStoreID, this.m_index, this.m_gainGoodsList);
			}
			UIUtility.SetUIStateClose(this.m_itemBuyPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x06013407 RID: 78855 RVA: 0x004EBFB8 File Offset: 0x004EA1B8
		protected void OnBoxBuyPanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBoxBuyPanelBGButtonClick_hotfix != null)
			{
				this.m_OnBoxBuyPanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_boxBuyPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x06013408 RID: 78856 RVA: 0x004EC02C File Offset: 0x004EA22C
		protected void OnRechargePanelBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRechargePanelBGButtonClick_hotfix != null)
			{
				this.m_OnRechargePanelBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_rechargePanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x06013409 RID: 78857 RVA: 0x004EC0A0 File Offset: 0x004EA2A0
		protected void OnBoxBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBoxBuyButtonClick_hotfix != null)
			{
				this.m_OnBoxBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_storeType == StoreType.StoreType_Gift)
			{
				if (this.EventOnGiftStoreBuyClick != null)
				{
					this.EventOnGiftStoreBuyClick(this.m_giftStoreItem.Config, this.m_giftStoreItem.IsFirstBuy, 1);
				}
			}
			else if (this.m_isStaticBox)
			{
				if (this.m_storeType == StoreType.StoreType_Static)
				{
					if (this.EventOnFixedStoreBoxBuyClick != null)
					{
						this.EventOnFixedStoreBoxBuyClick(this.m_fixedStoreID, this.m_fixedStoreItemGoodsID, this.m_goodsID, this.m_gainGoodsList);
					}
				}
				else if (this.m_storeType == StoreType.StoreType_Random && this.EventOnRandomStoreBoxBuyClick != null)
				{
					this.EventOnRandomStoreBoxBuyClick(this.m_randomStoreID, this.m_index, this.m_goodsID, this.m_gainGoodsList);
				}
			}
			else if (this.m_storeType == StoreType.StoreType_Static)
			{
				if (this.EventOnFixedStoreItemBuyClick != null)
				{
					this.EventOnFixedStoreItemBuyClick(this.m_fixedStoreID, this.m_fixedStoreItemGoodsID, this.m_goodsID, this.m_selfChooseItemIndex, this.m_gainGoodsList);
				}
			}
			else if (this.m_storeType == StoreType.StoreType_Random && this.EventOnRandomStoreItemBuyClick != null)
			{
				this.EventOnRandomStoreItemBuyClick(this.m_randomStoreID, this.m_index, this.m_gainGoodsList);
			}
			UIUtility.SetUIStateClose(this.m_boxBuyPanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x0601340A RID: 78858 RVA: 0x004EC254 File Offset: 0x004EA454
		private bool IsStoreItemIOSSubscribeItem(StoreItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsStoreItemIOSSubscribeItemStoreItemUIController_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsStoreItemIOSSubscribeItemStoreItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ctrl == null)
			{
				return false;
			}
			ConfigDataMonthCardInfo configDataMonthCardInfo = this.m_configDataLoader.GetConfigDataMonthCardInfo(ctrl.m_goodsID);
			return configDataMonthCardInfo != null && UIUtility.IsIosSubscribe(configDataMonthCardInfo.IsAppleSubscribe);
		}

		// Token: 0x0601340B RID: 78859 RVA: 0x004EC304 File Offset: 0x004EA504
		public void OnMemoryEntranceButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryEntranceButtonClick_hotfix != null)
			{
				this.m_OnMemoryEntranceButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerContext.GetAllStarLvlMaxHeroFragements().Count > 0;
			if (flag)
			{
				this.SetMemoryExtractionPanelInfo();
				UIUtility.SetUIStateOpen(this.m_memoryExtractionPanelStateCtrl, "Show", null, true, true);
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ExtractionFragmentNotEnough, 2f, null, true);
			}
		}

		// Token: 0x0601340C RID: 78860 RVA: 0x004EC3B4 File Offset: 0x004EA5B4
		public void SetMemoryExtractionPanelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMemoryExtractionPanelInfo_hotfix != null)
			{
				this.m_SetMemoryExtractionPanelInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_memoryExtractionPanelScrollRect.normalizedPosition = Vector2.one;
			GameObjectUtility.DestroyChildren(this.m_memoryExtractionPanelScrollContent);
			List<HeroFragmentBagItem> list = new List<HeroFragmentBagItem>(this.m_playerContext.GetAllStarLvlMaxHeroFragements());
			list.Sort(new Comparison<HeroFragmentBagItem>(this.SortFragmentItemComparer));
			if (list.Count > 0)
			{
				int num = 0;
				foreach (HeroFragmentBagItem heroFragmentBagItem in list)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_HeroFragmentItemPrefab);
					MemoryStoreHeroFragmentItemUIController memoryStoreHeroFragmentItemUIController = GameObjectUtility.AddControllerToGameObject<MemoryStoreHeroFragmentItemUIController>(gameObject);
					memoryStoreHeroFragmentItemUIController.InitHeroFragmentItem(heroFragmentBagItem);
					gameObject.transform.SetParent(this.m_memoryExtractionPanelScrollContent.transform, false);
					num += heroFragmentBagItem.GetAllExchangeMemoryEssence();
				}
				this.m_memoryExtractionPanelTotalValueText.text = num.ToString();
				this.m_memoryExtractionPanelEmptyTip.SetActive(false);
			}
			else
			{
				this.m_memoryExtractionPanelTotalValueText.text = "0";
				this.m_memoryExtractionPanelEmptyTip.SetActive(true);
			}
		}

		// Token: 0x0601340D RID: 78861 RVA: 0x004EC528 File Offset: 0x004EA728
		private int SortFragmentItemComparer(HeroFragmentBagItem f1, HeroFragmentBagItem f2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SortFragmentItemComparerHeroFragmentBagItemHeroFragmentBagItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_SortFragmentItemComparerHeroFragmentBagItemHeroFragmentBagItem_hotfix.call(new object[]
				{
					this,
					f1,
					f2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return f2.ItemInfo.Rank - f1.ItemInfo.Rank;
		}

		// Token: 0x0601340E RID: 78862 RVA: 0x004EC5CC File Offset: 0x004EA7CC
		private void OnMemoryExtractionPanelExtractionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryExtractionPanelExtractionButtonClick_hotfix != null)
			{
				this.m_OnMemoryExtractionPanelExtractionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroFragmentBagItem> list = new List<HeroFragmentBagItem>(this.m_playerContext.GetAllStarLvlMaxHeroFragements());
			int num = 0;
			foreach (HeroFragmentBagItem heroFragmentBagItem in list)
			{
				num += heroFragmentBagItem.GetAllExchangeMemoryEssence();
			}
			string msgText = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_CommitMemoryEssenceTip), num);
			CommonUIController.Instance.ShowDialogBox(msgText, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok && this.EventOnMemoryExtraction != null)
				{
					this.EventOnMemoryExtraction(delegate
					{
						this.CloseMemoryExtractionPanel();
					});
				}
			}, string.Empty, null);
		}

		// Token: 0x0601340F RID: 78863 RVA: 0x004EC6C8 File Offset: 0x004EA8C8
		private void OnMemeryExtractionHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemeryExtractionHelpButtonClick_hotfix != null)
			{
				this.m_OnMemeryExtractionHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_MemeryExtraction);
		}

		// Token: 0x06013410 RID: 78864 RVA: 0x004EC734 File Offset: 0x004EA934
		private void CloseMemoryExtractionPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseMemoryExtractionPanel_hotfix != null)
			{
				this.m_CloseMemoryExtractionPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_memoryExtractionPanelStateCtrl, "Close", null, true, true);
		}

		// Token: 0x06013411 RID: 78865 RVA: 0x004EC7A8 File Offset: 0x004EA9A8
		private void FireChangeStoreEvent(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FireChangeStoreEventStoreId_hotfix != null)
			{
				this.m_FireChangeStoreEventStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChangeStore != null)
			{
				this.EventOnChangeStore(storeId);
			}
		}

		// Token: 0x06013412 RID: 78866 RVA: 0x004EC830 File Offset: 0x004EAA30
		protected void OnRechargeBuyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRechargeBuyButtonClick_hotfix != null)
			{
				this.m_OnRechargeBuyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnRechargeStoreBuyClick != null)
			{
				this.EventOnRechargeStoreBuyClick(this.m_storeType, this.m_goodsID, 1);
			}
			UIUtility.SetUIStateClose(this.m_rechargePanelUIStateController, "Close", null, false, true);
		}

		// Token: 0x06013413 RID: 78867 RVA: 0x004EC8C8 File Offset: 0x004EAAC8
		protected void OnRechargeToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRechargeToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnRechargeToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Recharge);
			}
		}

		// Token: 0x06013414 RID: 78868 RVA: 0x004EC954 File Offset: 0x004EAB54
		protected void OnCystalToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCystalToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnCystalToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Crystal);
			}
		}

		// Token: 0x06013415 RID: 78869 RVA: 0x004EC9E0 File Offset: 0x004EABE0
		protected void OnSkinToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSkinToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_SkinHero);
			}
		}

		// Token: 0x06013416 RID: 78870 RVA: 0x004ECA6C File Offset: 0x004EAC6C
		protected void OnSkinTab_HeroToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinTab_HeroToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSkinTab_HeroToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_SkinHero);
			}
		}

		// Token: 0x06013417 RID: 78871 RVA: 0x004ECAF8 File Offset: 0x004EACF8
		protected void OnSkinTab_SoldierToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkinTab_SoldierToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSkinTab_SoldierToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_SkinSoldier);
			}
		}

		// Token: 0x06013418 RID: 78872 RVA: 0x004ECB84 File Offset: 0x004EAD84
		protected void OnMysteriousToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_BlackMarket);
			}
		}

		// Token: 0x06013419 RID: 78873 RVA: 0x004ECC10 File Offset: 0x004EAE10
		protected void OnMysteriousBlackMarketToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousBlackMarketToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousBlackMarketToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_BlackMarket);
			}
		}

		// Token: 0x0601341A RID: 78874 RVA: 0x004ECC9C File Offset: 0x004EAE9C
		protected void OnMysteriousMemoryToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousMemoryToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousMemoryToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Memory);
			}
		}

		// Token: 0x0601341B RID: 78875 RVA: 0x004ECD28 File Offset: 0x004EAF28
		protected void OnMysteriousEquipmentToggleValueChange(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousEquipmentToggleValueChangeBoolean_hotfix != null)
			{
				this.m_OnMysteriousEquipmentToggleValueChangeBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Equipment);
			}
		}

		// Token: 0x0601341C RID: 78876 RVA: 0x004ECDA8 File Offset: 0x004EAFA8
		protected void OnMysteriousHonorToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousHonorToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousHonorToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Honor);
			}
		}

		// Token: 0x0601341D RID: 78877 RVA: 0x004ECE34 File Offset: 0x004EB034
		protected void OnMysteriousMedalToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousMedalToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousMedalToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Medal);
			}
		}

		// Token: 0x0601341E RID: 78878 RVA: 0x004ECEC0 File Offset: 0x004EB0C0
		protected void OnMysteriousFriendshipToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousFriendshipToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousFriendshipToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Friendship);
			}
		}

		// Token: 0x0601341F RID: 78879 RVA: 0x004ECF4C File Offset: 0x004EB14C
		protected void OnMysteriousUnionToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMysteriousUnionToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnMysteriousUnionToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (isOn)
			{
				this.FireChangeStoreEvent(StoreId.StoreId_Union);
			}
		}

		// Token: 0x06013420 RID: 78880 RVA: 0x004ECFD8 File Offset: 0x004EB1D8
		private void InitStoreSubType2Toggle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitStoreSubType2Toggle_hotfix != null)
			{
				this.m_InitStoreSubType2Toggle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Recharge, new List<Toggle>
			{
				this.m_rechargeToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Gift, new List<Toggle>
			{
				this.m_presentToggle,
				this.m_presentPresentToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Privilege, new List<Toggle>
			{
				this.m_presentToggle,
				this.m_presentPreogativeToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_SkinHero, new List<Toggle>
			{
				this.m_skinToggle,
				this.m_skinHeroToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_SkinSoldier, new List<Toggle>
			{
				this.m_skinToggle,
				this.m_skinSoldierToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Crystal, new List<Toggle>
			{
				this.m_crystalToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_BlackMarket, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousBlackMarketToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Honor, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousHonorToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Medal, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousMedalToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Friendship, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousFriendshipToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Union, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousUnionToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Memory, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousMemoryToggle
			});
			this.m_storeSubType2ToggleDic.Add(StoreId.StoreId_Equipment, new List<Toggle>
			{
				this.m_mysteriousToggle,
				this.m_mysteriousEquipmentToggle
			});
		}

		// Token: 0x06013421 RID: 78881 RVA: 0x004ED254 File Offset: 0x004EB454
		private void SaveOriginalScrollViewLocalPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveOriginalScrollViewLocalPosition_hotfix != null)
			{
				this.m_SaveOriginalScrollViewLocalPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_scrollViewStoreContent != null)
			{
				this.m_scrollViewStoreContentOriginalLocalPos = this.m_scrollViewStoreContent.transform.localPosition;
			}
			if (this.m_scrollViewHeroContent != null)
			{
				this.m_scrollViewHeroContentOriginalLocalPos = this.m_scrollViewHeroContent.transform.localPosition;
			}
		}

		// Token: 0x06013422 RID: 78882 RVA: 0x004ED304 File Offset: 0x004EB504
		private bool UpdateToggles(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTogglesStoreId_hotfix != null)
			{
				return Convert.ToBoolean(this.m_UpdateTogglesStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Toggle> list = null;
			if (!this.m_storeSubType2ToggleDic.TryGetValue(storeId, out list))
			{
				return false;
			}
			if (list == null || list.Count == 0)
			{
				return false;
			}
			if (!list[0].isOn)
			{
				this.m_isIgnoreToggleEvent = true;
				list[0].isOn = true;
				if (list.Count > 1 && !list[1].isOn)
				{
					list[1].isOn = true;
				}
				this.m_isIgnoreToggleEvent = false;
				return true;
			}
			if (list.Count > 1 && !list[1].isOn)
			{
				this.m_isIgnoreToggleEvent = true;
				list[1].isOn = true;
				this.m_isIgnoreToggleEvent = false;
				return true;
			}
			return false;
		}

		// Token: 0x06013423 RID: 78883 RVA: 0x004ED440 File Offset: 0x004EB640
		protected int FixedStoreSkinListSortFunc(FixedStoreItem itemA, FixedStoreItem itemB)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FixedStoreSkinListSortFuncFixedStoreItemFixedStoreItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_FixedStoreSkinListSortFuncFixedStoreItemFixedStoreItem_hotfix.call(new object[]
				{
					this,
					itemA,
					itemB
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(itemA.Id);
			bool flag = this.m_playerContext.HasOwn(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId);
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo2 = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(itemB.Id);
			bool flag2 = this.m_playerContext.HasOwn(configDataFixedStoreItemInfo2.ItemType, configDataFixedStoreItemInfo2.ItemId);
			if (flag && !flag2)
			{
				return 1;
			}
			if (!flag && flag2)
			{
				return -1;
			}
			int num = configDataFixedStoreItemInfo.UISort - configDataFixedStoreItemInfo2.UISort;
			if (num != 0)
			{
				return (num <= 0) ? -1 : 1;
			}
			if (itemA.Id == itemB.Id)
			{
				return 0;
			}
			return (itemA.Id <= itemB.Id) ? -1 : 1;
		}

		// Token: 0x1400042E RID: 1070
		// (add) Token: 0x06013424 RID: 78884 RVA: 0x004ED590 File Offset: 0x004EB790
		// (remove) Token: 0x06013425 RID: 78885 RVA: 0x004ED62C File Offset: 0x004EB82C
		public event Action<StoreId> EventOnChangeStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeStoreAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeStoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId> action = this.EventOnChangeStore;
				Action<StoreId> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId>>(ref this.EventOnChangeStore, (Action<StoreId>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeStoreAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeStoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId> action = this.EventOnChangeStore;
				Action<StoreId> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId>>(ref this.EventOnChangeStore, (Action<StoreId>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400042F RID: 1071
		// (add) Token: 0x06013426 RID: 78886 RVA: 0x004ED6C8 File Offset: 0x004EB8C8
		// (remove) Token: 0x06013427 RID: 78887 RVA: 0x004ED764 File Offset: 0x004EB964
		public event Action<StoreHeroSkinItemUIController> EventOnFixedStoreHeroSkinItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFixedStoreHeroSkinItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnFixedStoreHeroSkinItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreHeroSkinItemUIController> action = this.EventOnFixedStoreHeroSkinItemClick;
				Action<StoreHeroSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreHeroSkinItemUIController>>(ref this.EventOnFixedStoreHeroSkinItemClick, (Action<StoreHeroSkinItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFixedStoreHeroSkinItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnFixedStoreHeroSkinItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreHeroSkinItemUIController> action = this.EventOnFixedStoreHeroSkinItemClick;
				Action<StoreHeroSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreHeroSkinItemUIController>>(ref this.EventOnFixedStoreHeroSkinItemClick, (Action<StoreHeroSkinItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000430 RID: 1072
		// (add) Token: 0x06013428 RID: 78888 RVA: 0x004ED800 File Offset: 0x004EBA00
		// (remove) Token: 0x06013429 RID: 78889 RVA: 0x004ED89C File Offset: 0x004EBA9C
		public event Action<StoreSoldierSkinItemUIController> EventOnFixedStoreSoldierSkinItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFixedStoreSoldierSkinItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnFixedStoreSoldierSkinItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreSoldierSkinItemUIController> action = this.EventOnFixedStoreSoldierSkinItemClick;
				Action<StoreSoldierSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreSoldierSkinItemUIController>>(ref this.EventOnFixedStoreSoldierSkinItemClick, (Action<StoreSoldierSkinItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFixedStoreSoldierSkinItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnFixedStoreSoldierSkinItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreSoldierSkinItemUIController> action = this.EventOnFixedStoreSoldierSkinItemClick;
				Action<StoreSoldierSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreSoldierSkinItemUIController>>(ref this.EventOnFixedStoreSoldierSkinItemClick, (Action<StoreSoldierSkinItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000431 RID: 1073
		// (add) Token: 0x0601342A RID: 78890 RVA: 0x004ED938 File Offset: 0x004EBB38
		// (remove) Token: 0x0601342B RID: 78891 RVA: 0x004ED9D4 File Offset: 0x004EBBD4
		public event Action EventOnSkinItemOutOfDate
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkinItemOutOfDateAction_hotfix != null)
				{
					this.m_add_EventOnSkinItemOutOfDateAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinItemOutOfDate;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinItemOutOfDate, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkinItemOutOfDateAction_hotfix != null)
				{
					this.m_remove_EventOnSkinItemOutOfDateAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkinItemOutOfDate;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkinItemOutOfDate, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000432 RID: 1074
		// (add) Token: 0x0601342C RID: 78892 RVA: 0x004EDA70 File Offset: 0x004EBC70
		// (remove) Token: 0x0601342D RID: 78893 RVA: 0x004EDB0C File Offset: 0x004EBD0C
		public event StoreListUIController.Action<StoreId, int, int, int, List<Goods>> EventOnFixedStoreItemBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFixedStoreItemBuyClickAction`5_hotfix != null)
				{
					this.m_add_EventOnFixedStoreItemBuyClickAction`5_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				StoreListUIController.Action<StoreId, int, int, int, List<Goods>> action = this.EventOnFixedStoreItemBuyClick;
				StoreListUIController.Action<StoreId, int, int, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<StoreListUIController.Action<StoreId, int, int, int, List<Goods>>>(ref this.EventOnFixedStoreItemBuyClick, (StoreListUIController.Action<StoreId, int, int, int, List<Goods>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFixedStoreItemBuyClickAction`5_hotfix != null)
				{
					this.m_remove_EventOnFixedStoreItemBuyClickAction`5_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				StoreListUIController.Action<StoreId, int, int, int, List<Goods>> action = this.EventOnFixedStoreItemBuyClick;
				StoreListUIController.Action<StoreId, int, int, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<StoreListUIController.Action<StoreId, int, int, int, List<Goods>>>(ref this.EventOnFixedStoreItemBuyClick, (StoreListUIController.Action<StoreId, int, int, int, List<Goods>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000433 RID: 1075
		// (add) Token: 0x0601342E RID: 78894 RVA: 0x004EDBA8 File Offset: 0x004EBDA8
		// (remove) Token: 0x0601342F RID: 78895 RVA: 0x004EDC44 File Offset: 0x004EBE44
		public event Action<StoreId, int, int, List<Goods>> EventOnFixedStoreBoxBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFixedStoreBoxBuyClickAction`4_hotfix != null)
				{
					this.m_add_EventOnFixedStoreBoxBuyClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId, int, int, List<Goods>> action = this.EventOnFixedStoreBoxBuyClick;
				Action<StoreId, int, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId, int, int, List<Goods>>>(ref this.EventOnFixedStoreBoxBuyClick, (Action<StoreId, int, int, List<Goods>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFixedStoreBoxBuyClickAction`4_hotfix != null)
				{
					this.m_remove_EventOnFixedStoreBoxBuyClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId, int, int, List<Goods>> action = this.EventOnFixedStoreBoxBuyClick;
				Action<StoreId, int, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId, int, int, List<Goods>>>(ref this.EventOnFixedStoreBoxBuyClick, (Action<StoreId, int, int, List<Goods>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000434 RID: 1076
		// (add) Token: 0x06013430 RID: 78896 RVA: 0x004EDCE0 File Offset: 0x004EBEE0
		// (remove) Token: 0x06013431 RID: 78897 RVA: 0x004EDD7C File Offset: 0x004EBF7C
		public event Action<StoreId, int, List<Goods>> EventOnRandomStoreItemBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRandomStoreItemBuyClickAction`3_hotfix != null)
				{
					this.m_add_EventOnRandomStoreItemBuyClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId, int, List<Goods>> action = this.EventOnRandomStoreItemBuyClick;
				Action<StoreId, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId, int, List<Goods>>>(ref this.EventOnRandomStoreItemBuyClick, (Action<StoreId, int, List<Goods>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRandomStoreItemBuyClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnRandomStoreItemBuyClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId, int, List<Goods>> action = this.EventOnRandomStoreItemBuyClick;
				Action<StoreId, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId, int, List<Goods>>>(ref this.EventOnRandomStoreItemBuyClick, (Action<StoreId, int, List<Goods>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000435 RID: 1077
		// (add) Token: 0x06013432 RID: 78898 RVA: 0x004EDE18 File Offset: 0x004EC018
		// (remove) Token: 0x06013433 RID: 78899 RVA: 0x004EDEB4 File Offset: 0x004EC0B4
		public event Action<StoreId, int, int, List<Goods>> EventOnRandomStoreBoxBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRandomStoreBoxBuyClickAction`4_hotfix != null)
				{
					this.m_add_EventOnRandomStoreBoxBuyClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId, int, int, List<Goods>> action = this.EventOnRandomStoreBoxBuyClick;
				Action<StoreId, int, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId, int, int, List<Goods>>>(ref this.EventOnRandomStoreBoxBuyClick, (Action<StoreId, int, int, List<Goods>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRandomStoreBoxBuyClickAction`4_hotfix != null)
				{
					this.m_remove_EventOnRandomStoreBoxBuyClickAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId, int, int, List<Goods>> action = this.EventOnRandomStoreBoxBuyClick;
				Action<StoreId, int, int, List<Goods>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId, int, int, List<Goods>>>(ref this.EventOnRandomStoreBoxBuyClick, (Action<StoreId, int, int, List<Goods>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000436 RID: 1078
		// (add) Token: 0x06013434 RID: 78900 RVA: 0x004EDF50 File Offset: 0x004EC150
		// (remove) Token: 0x06013435 RID: 78901 RVA: 0x004EDFEC File Offset: 0x004EC1EC
		public event Action<StoreType, int, int> EventOnRechargeStoreBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRechargeStoreBuyClickAction`3_hotfix != null)
				{
					this.m_add_EventOnRechargeStoreBuyClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreType, int, int> action = this.EventOnRechargeStoreBuyClick;
				Action<StoreType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreType, int, int>>(ref this.EventOnRechargeStoreBuyClick, (Action<StoreType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRechargeStoreBuyClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnRechargeStoreBuyClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreType, int, int> action = this.EventOnRechargeStoreBuyClick;
				Action<StoreType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreType, int, int>>(ref this.EventOnRechargeStoreBuyClick, (Action<StoreType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000437 RID: 1079
		// (add) Token: 0x06013436 RID: 78902 RVA: 0x004EE088 File Offset: 0x004EC288
		// (remove) Token: 0x06013437 RID: 78903 RVA: 0x004EE124 File Offset: 0x004EC324
		public event Action<ConfigDataGiftStoreItemInfo, bool, int> EventOnGiftStoreBuyClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGiftStoreBuyClickAction`3_hotfix != null)
				{
					this.m_add_EventOnGiftStoreBuyClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataGiftStoreItemInfo, bool, int> action = this.EventOnGiftStoreBuyClick;
				Action<ConfigDataGiftStoreItemInfo, bool, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataGiftStoreItemInfo, bool, int>>(ref this.EventOnGiftStoreBuyClick, (Action<ConfigDataGiftStoreItemInfo, bool, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGiftStoreBuyClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnGiftStoreBuyClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataGiftStoreItemInfo, bool, int> action = this.EventOnGiftStoreBuyClick;
				Action<ConfigDataGiftStoreItemInfo, bool, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataGiftStoreItemInfo, bool, int>>(ref this.EventOnGiftStoreBuyClick, (Action<ConfigDataGiftStoreItemInfo, bool, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000438 RID: 1080
		// (add) Token: 0x06013438 RID: 78904 RVA: 0x004EE1C0 File Offset: 0x004EC3C0
		// (remove) Token: 0x06013439 RID: 78905 RVA: 0x004EE25C File Offset: 0x004EC45C
		public event Action<StoreId> EventOnGetRandomStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetRandomStoreAction`1_hotfix != null)
				{
					this.m_add_EventOnGetRandomStoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId> action = this.EventOnGetRandomStore;
				Action<StoreId> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId>>(ref this.EventOnGetRandomStore, (Action<StoreId>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetRandomStoreAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetRandomStoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId> action = this.EventOnGetRandomStore;
				Action<StoreId> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId>>(ref this.EventOnGetRandomStore, (Action<StoreId>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000439 RID: 1081
		// (add) Token: 0x0601343A RID: 78906 RVA: 0x004EE2F8 File Offset: 0x004EC4F8
		// (remove) Token: 0x0601343B RID: 78907 RVA: 0x004EE394 File Offset: 0x004EC594
		public event Action<StoreId> EventOnRefreshRandomStore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRefreshRandomStoreAction`1_hotfix != null)
				{
					this.m_add_EventOnRefreshRandomStoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId> action = this.EventOnRefreshRandomStore;
				Action<StoreId> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId>>(ref this.EventOnRefreshRandomStore, (Action<StoreId>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRefreshRandomStoreAction`1_hotfix != null)
				{
					this.m_remove_EventOnRefreshRandomStoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreId> action = this.EventOnRefreshRandomStore;
				Action<StoreId> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreId>>(ref this.EventOnRefreshRandomStore, (Action<StoreId>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400043A RID: 1082
		// (add) Token: 0x0601343C RID: 78908 RVA: 0x004EE430 File Offset: 0x004EC630
		// (remove) Token: 0x0601343D RID: 78909 RVA: 0x004EE4CC File Offset: 0x004EC6CC
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

		// Token: 0x1400043B RID: 1083
		// (add) Token: 0x0601343E RID: 78910 RVA: 0x004EE568 File Offset: 0x004EC768
		// (remove) Token: 0x0601343F RID: 78911 RVA: 0x004EE604 File Offset: 0x004EC804
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400043C RID: 1084
		// (add) Token: 0x06013440 RID: 78912 RVA: 0x004EE6A0 File Offset: 0x004EC8A0
		// (remove) Token: 0x06013441 RID: 78913 RVA: 0x004EE73C File Offset: 0x004EC93C
		public event Action<GoodsType> EventOnExtraButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExtraButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnExtraButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType> action = this.EventOnExtraButtonClick;
				Action<GoodsType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType>>(ref this.EventOnExtraButtonClick, (Action<GoodsType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExtraButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnExtraButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType> action = this.EventOnExtraButtonClick;
				Action<GoodsType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType>>(ref this.EventOnExtraButtonClick, (Action<GoodsType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400043D RID: 1085
		// (add) Token: 0x06013442 RID: 78914 RVA: 0x004EE7D8 File Offset: 0x004EC9D8
		// (remove) Token: 0x06013443 RID: 78915 RVA: 0x004EE874 File Offset: 0x004ECA74
		public event Action<Action> EventOnMemoryExtraction
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMemoryExtractionAction`1_hotfix != null)
				{
					this.m_add_EventOnMemoryExtractionAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnMemoryExtraction;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnMemoryExtraction, (Action<Action>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMemoryExtractionAction`1_hotfix != null)
				{
					this.m_remove_EventOnMemoryExtractionAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Action> action = this.EventOnMemoryExtraction;
				Action<Action> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Action>>(ref this.EventOnMemoryExtraction, (Action<Action>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x06013444 RID: 78916 RVA: 0x004EE910 File Offset: 0x004ECB10
		// (set) Token: 0x06013445 RID: 78917 RVA: 0x004EE930 File Offset: 0x004ECB30
		[DoNotToLua]
		public new StoreListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013446 RID: 78918 RVA: 0x004EE93C File Offset: 0x004ECB3C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013447 RID: 78919 RVA: 0x004EE948 File Offset: 0x004ECB48
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013448 RID: 78920 RVA: 0x004EE950 File Offset: 0x004ECB50
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013449 RID: 78921 RVA: 0x004EE958 File Offset: 0x004ECB58
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601344A RID: 78922 RVA: 0x004EE96C File Offset: 0x004ECB6C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601344B RID: 78923 RVA: 0x004EE974 File Offset: 0x004ECB74
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601344C RID: 78924 RVA: 0x004EE980 File Offset: 0x004ECB80
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601344D RID: 78925 RVA: 0x004EE98C File Offset: 0x004ECB8C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601344E RID: 78926 RVA: 0x004EE998 File Offset: 0x004ECB98
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601344F RID: 78927 RVA: 0x004EE9A4 File Offset: 0x004ECBA4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013450 RID: 78928 RVA: 0x004EE9B0 File Offset: 0x004ECBB0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013451 RID: 78929 RVA: 0x004EE9BC File Offset: 0x004ECBBC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013452 RID: 78930 RVA: 0x004EE9C8 File Offset: 0x004ECBC8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013453 RID: 78931 RVA: 0x004EE9D4 File Offset: 0x004ECBD4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013454 RID: 78932 RVA: 0x004EE9E0 File Offset: 0x004ECBE0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013455 RID: 78933 RVA: 0x004EE9E8 File Offset: 0x004ECBE8
		private void __callDele_EventOnChangeStore(StoreId obj)
		{
			Action<StoreId> eventOnChangeStore = this.EventOnChangeStore;
			if (eventOnChangeStore != null)
			{
				eventOnChangeStore(obj);
			}
		}

		// Token: 0x06013456 RID: 78934 RVA: 0x004EEA0C File Offset: 0x004ECC0C
		private void __clearDele_EventOnChangeStore(StoreId obj)
		{
			this.EventOnChangeStore = null;
		}

		// Token: 0x06013457 RID: 78935 RVA: 0x004EEA18 File Offset: 0x004ECC18
		private void __callDele_EventOnFixedStoreHeroSkinItemClick(StoreHeroSkinItemUIController obj)
		{
			Action<StoreHeroSkinItemUIController> eventOnFixedStoreHeroSkinItemClick = this.EventOnFixedStoreHeroSkinItemClick;
			if (eventOnFixedStoreHeroSkinItemClick != null)
			{
				eventOnFixedStoreHeroSkinItemClick(obj);
			}
		}

		// Token: 0x06013458 RID: 78936 RVA: 0x004EEA3C File Offset: 0x004ECC3C
		private void __clearDele_EventOnFixedStoreHeroSkinItemClick(StoreHeroSkinItemUIController obj)
		{
			this.EventOnFixedStoreHeroSkinItemClick = null;
		}

		// Token: 0x06013459 RID: 78937 RVA: 0x004EEA48 File Offset: 0x004ECC48
		private void __callDele_EventOnFixedStoreSoldierSkinItemClick(StoreSoldierSkinItemUIController obj)
		{
			Action<StoreSoldierSkinItemUIController> eventOnFixedStoreSoldierSkinItemClick = this.EventOnFixedStoreSoldierSkinItemClick;
			if (eventOnFixedStoreSoldierSkinItemClick != null)
			{
				eventOnFixedStoreSoldierSkinItemClick(obj);
			}
		}

		// Token: 0x0601345A RID: 78938 RVA: 0x004EEA6C File Offset: 0x004ECC6C
		private void __clearDele_EventOnFixedStoreSoldierSkinItemClick(StoreSoldierSkinItemUIController obj)
		{
			this.EventOnFixedStoreSoldierSkinItemClick = null;
		}

		// Token: 0x0601345B RID: 78939 RVA: 0x004EEA78 File Offset: 0x004ECC78
		private void __callDele_EventOnSkinItemOutOfDate()
		{
			Action eventOnSkinItemOutOfDate = this.EventOnSkinItemOutOfDate;
			if (eventOnSkinItemOutOfDate != null)
			{
				eventOnSkinItemOutOfDate();
			}
		}

		// Token: 0x0601345C RID: 78940 RVA: 0x004EEA98 File Offset: 0x004ECC98
		private void __clearDele_EventOnSkinItemOutOfDate()
		{
			this.EventOnSkinItemOutOfDate = null;
		}

		// Token: 0x0601345D RID: 78941 RVA: 0x004EEAA4 File Offset: 0x004ECCA4
		private void __callDele_EventOnFixedStoreItemBuyClick(StoreId arg1, int arg2, int arg3, int arg4, List<Goods> arg5)
		{
			StoreListUIController.Action<StoreId, int, int, int, List<Goods>> eventOnFixedStoreItemBuyClick = this.EventOnFixedStoreItemBuyClick;
			if (eventOnFixedStoreItemBuyClick != null)
			{
				eventOnFixedStoreItemBuyClick(arg1, arg2, arg3, arg4, arg5);
			}
		}

		// Token: 0x0601345E RID: 78942 RVA: 0x004EEACC File Offset: 0x004ECCCC
		private void __clearDele_EventOnFixedStoreItemBuyClick(StoreId arg1, int arg2, int arg3, int arg4, List<Goods> arg5)
		{
			this.EventOnFixedStoreItemBuyClick = null;
		}

		// Token: 0x0601345F RID: 78943 RVA: 0x004EEAD8 File Offset: 0x004ECCD8
		private void __callDele_EventOnFixedStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
		{
			Action<StoreId, int, int, List<Goods>> eventOnFixedStoreBoxBuyClick = this.EventOnFixedStoreBoxBuyClick;
			if (eventOnFixedStoreBoxBuyClick != null)
			{
				eventOnFixedStoreBoxBuyClick(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x06013460 RID: 78944 RVA: 0x004EEB00 File Offset: 0x004ECD00
		private void __clearDele_EventOnFixedStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
		{
			this.EventOnFixedStoreBoxBuyClick = null;
		}

		// Token: 0x06013461 RID: 78945 RVA: 0x004EEB0C File Offset: 0x004ECD0C
		private void __callDele_EventOnRandomStoreItemBuyClick(StoreId arg1, int arg2, List<Goods> arg3)
		{
			Action<StoreId, int, List<Goods>> eventOnRandomStoreItemBuyClick = this.EventOnRandomStoreItemBuyClick;
			if (eventOnRandomStoreItemBuyClick != null)
			{
				eventOnRandomStoreItemBuyClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x06013462 RID: 78946 RVA: 0x004EEB30 File Offset: 0x004ECD30
		private void __clearDele_EventOnRandomStoreItemBuyClick(StoreId arg1, int arg2, List<Goods> arg3)
		{
			this.EventOnRandomStoreItemBuyClick = null;
		}

		// Token: 0x06013463 RID: 78947 RVA: 0x004EEB3C File Offset: 0x004ECD3C
		private void __callDele_EventOnRandomStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
		{
			Action<StoreId, int, int, List<Goods>> eventOnRandomStoreBoxBuyClick = this.EventOnRandomStoreBoxBuyClick;
			if (eventOnRandomStoreBoxBuyClick != null)
			{
				eventOnRandomStoreBoxBuyClick(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x06013464 RID: 78948 RVA: 0x004EEB64 File Offset: 0x004ECD64
		private void __clearDele_EventOnRandomStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
		{
			this.EventOnRandomStoreBoxBuyClick = null;
		}

		// Token: 0x06013465 RID: 78949 RVA: 0x004EEB70 File Offset: 0x004ECD70
		private void __callDele_EventOnRechargeStoreBuyClick(StoreType arg1, int arg2, int arg3)
		{
			Action<StoreType, int, int> eventOnRechargeStoreBuyClick = this.EventOnRechargeStoreBuyClick;
			if (eventOnRechargeStoreBuyClick != null)
			{
				eventOnRechargeStoreBuyClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x06013466 RID: 78950 RVA: 0x004EEB94 File Offset: 0x004ECD94
		private void __clearDele_EventOnRechargeStoreBuyClick(StoreType arg1, int arg2, int arg3)
		{
			this.EventOnRechargeStoreBuyClick = null;
		}

		// Token: 0x06013467 RID: 78951 RVA: 0x004EEBA0 File Offset: 0x004ECDA0
		private void __callDele_EventOnGiftStoreBuyClick(ConfigDataGiftStoreItemInfo arg1, bool arg2, int arg3)
		{
			Action<ConfigDataGiftStoreItemInfo, bool, int> eventOnGiftStoreBuyClick = this.EventOnGiftStoreBuyClick;
			if (eventOnGiftStoreBuyClick != null)
			{
				eventOnGiftStoreBuyClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x06013468 RID: 78952 RVA: 0x004EEBC4 File Offset: 0x004ECDC4
		private void __clearDele_EventOnGiftStoreBuyClick(ConfigDataGiftStoreItemInfo arg1, bool arg2, int arg3)
		{
			this.EventOnGiftStoreBuyClick = null;
		}

		// Token: 0x06013469 RID: 78953 RVA: 0x004EEBD0 File Offset: 0x004ECDD0
		private void __callDele_EventOnGetRandomStore(StoreId obj)
		{
			Action<StoreId> eventOnGetRandomStore = this.EventOnGetRandomStore;
			if (eventOnGetRandomStore != null)
			{
				eventOnGetRandomStore(obj);
			}
		}

		// Token: 0x0601346A RID: 78954 RVA: 0x004EEBF4 File Offset: 0x004ECDF4
		private void __clearDele_EventOnGetRandomStore(StoreId obj)
		{
			this.EventOnGetRandomStore = null;
		}

		// Token: 0x0601346B RID: 78955 RVA: 0x004EEC00 File Offset: 0x004ECE00
		private void __callDele_EventOnRefreshRandomStore(StoreId obj)
		{
			Action<StoreId> eventOnRefreshRandomStore = this.EventOnRefreshRandomStore;
			if (eventOnRefreshRandomStore != null)
			{
				eventOnRefreshRandomStore(obj);
			}
		}

		// Token: 0x0601346C RID: 78956 RVA: 0x004EEC24 File Offset: 0x004ECE24
		private void __clearDele_EventOnRefreshRandomStore(StoreId obj)
		{
			this.EventOnRefreshRandomStore = null;
		}

		// Token: 0x0601346D RID: 78957 RVA: 0x004EEC30 File Offset: 0x004ECE30
		private void __callDele_EventOnCrystalNotEnough()
		{
			Action eventOnCrystalNotEnough = this.EventOnCrystalNotEnough;
			if (eventOnCrystalNotEnough != null)
			{
				eventOnCrystalNotEnough();
			}
		}

		// Token: 0x0601346E RID: 78958 RVA: 0x004EEC50 File Offset: 0x004ECE50
		private void __clearDele_EventOnCrystalNotEnough()
		{
			this.EventOnCrystalNotEnough = null;
		}

		// Token: 0x0601346F RID: 78959 RVA: 0x004EEC5C File Offset: 0x004ECE5C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06013470 RID: 78960 RVA: 0x004EEC7C File Offset: 0x004ECE7C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06013471 RID: 78961 RVA: 0x004EEC88 File Offset: 0x004ECE88
		private void __callDele_EventOnExtraButtonClick(GoodsType obj)
		{
			Action<GoodsType> eventOnExtraButtonClick = this.EventOnExtraButtonClick;
			if (eventOnExtraButtonClick != null)
			{
				eventOnExtraButtonClick(obj);
			}
		}

		// Token: 0x06013472 RID: 78962 RVA: 0x004EECAC File Offset: 0x004ECEAC
		private void __clearDele_EventOnExtraButtonClick(GoodsType obj)
		{
			this.EventOnExtraButtonClick = null;
		}

		// Token: 0x06013473 RID: 78963 RVA: 0x004EECB8 File Offset: 0x004ECEB8
		private void __callDele_EventOnMemoryExtraction(Action obj)
		{
			Action<Action> eventOnMemoryExtraction = this.EventOnMemoryExtraction;
			if (eventOnMemoryExtraction != null)
			{
				eventOnMemoryExtraction(obj);
			}
		}

		// Token: 0x06013474 RID: 78964 RVA: 0x004EECDC File Offset: 0x004ECEDC
		private void __clearDele_EventOnMemoryExtraction(Action obj)
		{
			this.EventOnMemoryExtraction = null;
		}

		// Token: 0x0601347B RID: 78971 RVA: 0x004EED6C File Offset: 0x004ECF6C
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
					this.m_GetHeroSkinItemCtrlByFixedStoreItemIdInt32_hotfix = (luaObj.RawGet("GetHeroSkinItemCtrlByFixedStoreItemId") as LuaFunction);
					this.m_UpdateHeroSkinItemLimitTime_hotfix = (luaObj.RawGet("UpdateHeroSkinItemLimitTime") as LuaFunction);
					this.m_GetStoreTypeByStoreIdStoreId_hotfix = (luaObj.RawGet("GetStoreTypeByStoreId") as LuaFunction);
					this.m_UpdateStoreStoreId_hotfix = (luaObj.RawGet("UpdateStore") as LuaFunction);
					this.m_UpdateRechargeStore_hotfix = (luaObj.RawGet("UpdateRechargeStore") as LuaFunction);
					this.m_UpdateGiftStoreStoreId_hotfix = (luaObj.RawGet("UpdateGiftStore") as LuaFunction);
					this.m_UpdateFixedStoreStoreId_hotfix = (luaObj.RawGet("UpdateFixedStore") as LuaFunction);
					this.m_UpdateRandomStore_hotfix = (luaObj.RawGet("UpdateRandomStore") as LuaFunction);
					this.m_ClearPool_hotfix = (luaObj.RawGet("ClearPool") as LuaFunction);
					this.m_UpdateFixedStoreInfoStoreId_hotfix = (luaObj.RawGet("UpdateFixedStoreInfo") as LuaFunction);
					this.m_UpdateHeroSkinInfoStoreIdGameObjectPool`1_hotfix = (luaObj.RawGet("UpdateHeroSkinInfo") as LuaFunction);
					this.m_SetSkinTicketCountText_hotfix = (luaObj.RawGet("SetSkinTicketCountText") as LuaFunction);
					this.m_UpdateSoldierSkinInfoStoreIdGameObjectPool`1_hotfix = (luaObj.RawGet("UpdateSoldierSkinInfo") as LuaFunction);
					this.m_UpdateRandomStoreInfoStoreId_hotfix = (luaObj.RawGet("UpdateRandomStoreInfo") as LuaFunction);
					this.m_UpdateRechargeStoreInfo_hotfix = (luaObj.RawGet("UpdateRechargeStoreInfo") as LuaFunction);
					this.m_SetDefaultStateBoolean_hotfix = (luaObj.RawGet("SetDefaultState") as LuaFunction);
					this.m_SetFixedStoreInfoStoreIdGameObjectPool`1_hotfix = (luaObj.RawGet("SetFixedStoreInfo") as LuaFunction);
					this.m_SortFixedStoreItemByUISortFixedStoreItemFixedStoreItem_hotfix = (luaObj.RawGet("SortFixedStoreItemByUISort") as LuaFunction);
					this.m_RefreshCurrencyDisplayList`1_hotfix = (luaObj.RawGet("RefreshCurrencyDisplay") as LuaFunction);
					this.m_SetRandomStoreInfoStoreIdGameObjectPool`1_hotfix = (luaObj.RawGet("SetRandomStoreInfo") as LuaFunction);
					this.m_SetRechargeStoreInfoGameObjectPool`1_hotfix = (luaObj.RawGet("SetRechargeStoreInfo") as LuaFunction);
					this.m_ShowRefreshPanel_hotfix = (luaObj.RawGet("ShowRefreshPanel") as LuaFunction);
					this.m_HideRefreshPanel_hotfix = (luaObj.RawGet("HideRefreshPanel") as LuaFunction);
					this.m_SetRefreshPanelStoreId_hotfix = (luaObj.RawGet("SetRefreshPanel") as LuaFunction);
					this.m_IsNeedRefreshPanel_hotfix = (luaObj.RawGet("IsNeedRefreshPanel") as LuaFunction);
					this.m_StoreOpenTween_hotfix = (luaObj.RawGet("StoreOpenTween") as LuaFunction);
					this.m_OnStoreItemClickStoreItemUIController_hotfix = (luaObj.RawGet("OnStoreItemClick") as LuaFunction);
					this.m_OnHeroSkinItemClickStoreHeroSkinItemUIController_hotfix = (luaObj.RawGet("OnHeroSkinItemClick") as LuaFunction);
					this.m_OnSkinItemOutOfDate_hotfix = (luaObj.RawGet("OnSkinItemOutOfDate") as LuaFunction);
					this.m_OnSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix = (luaObj.RawGet("OnSoldierSkinItemClick") as LuaFunction);
					this.m_SetStoreBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetStoreBuyPanel") as LuaFunction);
					this.m_SetNormalItemBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetNormalItemBuyPanel") as LuaFunction);
					this.m_SetRechargeBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetRechargeBuyPanel") as LuaFunction);
					this.m_SetBoxBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetBoxBuyPanel") as LuaFunction);
					this.m_SetItemBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetItemBuyPanel") as LuaFunction);
					this.m_SetNormalItemBuyPanelGoodsStoreItemUIController_hotfix = (luaObj.RawGet("SetNormalItemBuyPanel") as LuaFunction);
					this.m_SetItemBuyPanelGoodsStoreItemUIController_hotfix = (luaObj.RawGet("SetItemBuyPanel") as LuaFunction);
					this.m_SetEnchantStoneResonanceInfoPanelGoodsTypeInt32_hotfix = (luaObj.RawGet("SetEnchantStoneResonanceInfoPanel") as LuaFunction);
					this.m_SetRandomStoreCountDown_hotfix = (luaObj.RawGet("SetRandomStoreCountDown") as LuaFunction);
					this.m_OpenBuyPanelStoreIdInt32_hotfix = (luaObj.RawGet("OpenBuyPanel") as LuaFunction);
					this.m_get_CurStoreId_hotfix = (luaObj.RawGet("get_CurStoreId") as LuaFunction);
					this.m_UpdateGiftStoreInfoStoreIdGameObjectPool`1_hotfix = (luaObj.RawGet("UpdateGiftStoreInfo") as LuaFunction);
					this.m_SetGiftStoreInfoStoreIdGameObjectPool`1_hotfix = (luaObj.RawGet("SetGiftStoreInfo") as LuaFunction);
					this.m_SetGiftStoreBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetGiftStoreBuyPanel") as LuaFunction);
					this.m_SetGiftStoreStaticBoxBuyPanelStoreItemUIControllerConfigDataItemInfo_hotfix = (luaObj.RawGet("SetGiftStoreStaticBoxBuyPanel") as LuaFunction);
					this.m_SetMothCardBuyPanelStoreItemUIController_hotfix = (luaObj.RawGet("SetMothCardBuyPanel") as LuaFunction);
					this.m_OnPresentPresentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnPresentPresentToggleValueChanged") as LuaFunction);
					this.m_OnPresentPreogativeToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnPresentPreogativeToggleValueChanged") as LuaFunction);
					this.m_OnMonthCardBuyButtonClick_hotfix = (luaObj.RawGet("OnMonthCardBuyButtonClick") as LuaFunction);
					this.m_OnSubscribePrivateClick_hotfix = (luaObj.RawGet("OnSubscribePrivateClick") as LuaFunction);
					this.m_OnCancelSubscribeClick_hotfix = (luaObj.RawGet("OnCancelSubscribeClick") as LuaFunction);
					this.m_OnMonthCardPanelBGButtonClick_hotfix = (luaObj.RawGet("OnMonthCardPanelBGButtonClick") as LuaFunction);
					this.m_OnPresentToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnPresentToggleValueChanged") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnRefreshButtonClick_hotfix = (luaObj.RawGet("OnRefreshButtonClick") as LuaFunction);
					this.m_OnItemBuyPanelBGButtonClick_hotfix = (luaObj.RawGet("OnItemBuyPanelBGButtonClick") as LuaFunction);
					this.m_OnItemBuyButtonClick_hotfix = (luaObj.RawGet("OnItemBuyButtonClick") as LuaFunction);
					this.m_OnBoxBuyPanelBGButtonClick_hotfix = (luaObj.RawGet("OnBoxBuyPanelBGButtonClick") as LuaFunction);
					this.m_OnRechargePanelBGButtonClick_hotfix = (luaObj.RawGet("OnRechargePanelBGButtonClick") as LuaFunction);
					this.m_OnBoxBuyButtonClick_hotfix = (luaObj.RawGet("OnBoxBuyButtonClick") as LuaFunction);
					this.m_IsStoreItemIOSSubscribeItemStoreItemUIController_hotfix = (luaObj.RawGet("IsStoreItemIOSSubscribeItem") as LuaFunction);
					this.m_OnMemoryEntranceButtonClick_hotfix = (luaObj.RawGet("OnMemoryEntranceButtonClick") as LuaFunction);
					this.m_SetMemoryExtractionPanelInfo_hotfix = (luaObj.RawGet("SetMemoryExtractionPanelInfo") as LuaFunction);
					this.m_SortFragmentItemComparerHeroFragmentBagItemHeroFragmentBagItem_hotfix = (luaObj.RawGet("SortFragmentItemComparer") as LuaFunction);
					this.m_OnMemoryExtractionPanelExtractionButtonClick_hotfix = (luaObj.RawGet("OnMemoryExtractionPanelExtractionButtonClick") as LuaFunction);
					this.m_OnMemeryExtractionHelpButtonClick_hotfix = (luaObj.RawGet("OnMemeryExtractionHelpButtonClick") as LuaFunction);
					this.m_CloseMemoryExtractionPanel_hotfix = (luaObj.RawGet("CloseMemoryExtractionPanel") as LuaFunction);
					this.m_FireChangeStoreEventStoreId_hotfix = (luaObj.RawGet("FireChangeStoreEvent") as LuaFunction);
					this.m_OnRechargeBuyButtonClick_hotfix = (luaObj.RawGet("OnRechargeBuyButtonClick") as LuaFunction);
					this.m_OnRechargeToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnRechargeToggleValueChanged") as LuaFunction);
					this.m_OnCystalToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnCystalToggleValueChanged") as LuaFunction);
					this.m_OnSkinToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSkinToggleValueChanged") as LuaFunction);
					this.m_OnSkinTab_HeroToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSkinTab_HeroToggleValueChanged") as LuaFunction);
					this.m_OnSkinTab_SoldierToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSkinTab_SoldierToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousBlackMarketToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousBlackMarketToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousMemoryToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousMemoryToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousEquipmentToggleValueChangeBoolean_hotfix = (luaObj.RawGet("OnMysteriousEquipmentToggleValueChange") as LuaFunction);
					this.m_OnMysteriousHonorToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousHonorToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousMedalToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousMedalToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousFriendshipToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousFriendshipToggleValueChanged") as LuaFunction);
					this.m_OnMysteriousUnionToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnMysteriousUnionToggleValueChanged") as LuaFunction);
					this.m_InitStoreSubType2Toggle_hotfix = (luaObj.RawGet("InitStoreSubType2Toggle") as LuaFunction);
					this.m_SaveOriginalScrollViewLocalPosition_hotfix = (luaObj.RawGet("SaveOriginalScrollViewLocalPosition") as LuaFunction);
					this.m_UpdateTogglesStoreId_hotfix = (luaObj.RawGet("UpdateToggles") as LuaFunction);
					this.m_FixedStoreSkinListSortFuncFixedStoreItemFixedStoreItem_hotfix = (luaObj.RawGet("FixedStoreSkinListSortFunc") as LuaFunction);
					this.m_add_EventOnChangeStoreAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeStore") as LuaFunction);
					this.m_remove_EventOnChangeStoreAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeStore") as LuaFunction);
					this.m_add_EventOnFixedStoreHeroSkinItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnFixedStoreHeroSkinItemClick") as LuaFunction);
					this.m_remove_EventOnFixedStoreHeroSkinItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnFixedStoreHeroSkinItemClick") as LuaFunction);
					this.m_add_EventOnFixedStoreSoldierSkinItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnFixedStoreSoldierSkinItemClick") as LuaFunction);
					this.m_remove_EventOnFixedStoreSoldierSkinItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnFixedStoreSoldierSkinItemClick") as LuaFunction);
					this.m_add_EventOnSkinItemOutOfDateAction_hotfix = (luaObj.RawGet("add_EventOnSkinItemOutOfDate") as LuaFunction);
					this.m_remove_EventOnSkinItemOutOfDateAction_hotfix = (luaObj.RawGet("remove_EventOnSkinItemOutOfDate") as LuaFunction);
					this.m_add_EventOnFixedStoreItemBuyClickAction`5_hotfix = (luaObj.RawGet("add_EventOnFixedStoreItemBuyClick") as LuaFunction);
					this.m_remove_EventOnFixedStoreItemBuyClickAction`5_hotfix = (luaObj.RawGet("remove_EventOnFixedStoreItemBuyClick") as LuaFunction);
					this.m_add_EventOnFixedStoreBoxBuyClickAction`4_hotfix = (luaObj.RawGet("add_EventOnFixedStoreBoxBuyClick") as LuaFunction);
					this.m_remove_EventOnFixedStoreBoxBuyClickAction`4_hotfix = (luaObj.RawGet("remove_EventOnFixedStoreBoxBuyClick") as LuaFunction);
					this.m_add_EventOnRandomStoreItemBuyClickAction`3_hotfix = (luaObj.RawGet("add_EventOnRandomStoreItemBuyClick") as LuaFunction);
					this.m_remove_EventOnRandomStoreItemBuyClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnRandomStoreItemBuyClick") as LuaFunction);
					this.m_add_EventOnRandomStoreBoxBuyClickAction`4_hotfix = (luaObj.RawGet("add_EventOnRandomStoreBoxBuyClick") as LuaFunction);
					this.m_remove_EventOnRandomStoreBoxBuyClickAction`4_hotfix = (luaObj.RawGet("remove_EventOnRandomStoreBoxBuyClick") as LuaFunction);
					this.m_add_EventOnRechargeStoreBuyClickAction`3_hotfix = (luaObj.RawGet("add_EventOnRechargeStoreBuyClick") as LuaFunction);
					this.m_remove_EventOnRechargeStoreBuyClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnRechargeStoreBuyClick") as LuaFunction);
					this.m_add_EventOnGiftStoreBuyClickAction`3_hotfix = (luaObj.RawGet("add_EventOnGiftStoreBuyClick") as LuaFunction);
					this.m_remove_EventOnGiftStoreBuyClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnGiftStoreBuyClick") as LuaFunction);
					this.m_add_EventOnGetRandomStoreAction`1_hotfix = (luaObj.RawGet("add_EventOnGetRandomStore") as LuaFunction);
					this.m_remove_EventOnGetRandomStoreAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetRandomStore") as LuaFunction);
					this.m_add_EventOnRefreshRandomStoreAction`1_hotfix = (luaObj.RawGet("add_EventOnRefreshRandomStore") as LuaFunction);
					this.m_remove_EventOnRefreshRandomStoreAction`1_hotfix = (luaObj.RawGet("remove_EventOnRefreshRandomStore") as LuaFunction);
					this.m_add_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("add_EventOnCrystalNotEnough") as LuaFunction);
					this.m_remove_EventOnCrystalNotEnoughAction_hotfix = (luaObj.RawGet("remove_EventOnCrystalNotEnough") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnExtraButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnExtraButtonClick") as LuaFunction);
					this.m_remove_EventOnExtraButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnExtraButtonClick") as LuaFunction);
					this.m_add_EventOnMemoryExtractionAction`1_hotfix = (luaObj.RawGet("add_EventOnMemoryExtraction") as LuaFunction);
					this.m_remove_EventOnMemoryExtractionAction`1_hotfix = (luaObj.RawGet("remove_EventOnMemoryExtraction") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601347C RID: 78972 RVA: 0x004EF9C0 File Offset: 0x004EDBC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AB3E RID: 43838
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_storeUIStateCtrl;

		// Token: 0x0400AB3F RID: 43839
		[AutoBind("./StoreUIPanel/RefreshPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_refreshPanelUIStateCtrl;

		// Token: 0x0400AB40 RID: 43840
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewStoreContent;

		// Token: 0x0400AB41 RID: 43841
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/HeroListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewHeroContent;

		// Token: 0x0400AB42 RID: 43842
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_itemBuyPanelUIStateController;

		// Token: 0x0400AB43 RID: 43843
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/Item/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_itemIconImage;

		// Token: 0x0400AB44 RID: 43844
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/Item/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemCountText;

		// Token: 0x0400AB45 RID: 43845
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/Item/Image", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemCountBgGo;

		// Token: 0x0400AB46 RID: 43846
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemNameText;

		// Token: 0x0400AB47 RID: 43847
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/GoodCount", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemGoodCountObj;

		// Token: 0x0400AB48 RID: 43848
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/GoodCount/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemHaveCountText;

		// Token: 0x0400AB49 RID: 43849
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/ItemGoodsDesc/DescPanel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemDescText;

		// Token: 0x0400AB4A RID: 43850
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/BuyPanel/Group/PriceIcon/PriceIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_itemPriceIcon;

		// Token: 0x0400AB4B RID: 43851
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/BuyPanel/Group/PriceIcon/PriceIcon/U_crystal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemPriceIconEffectGameObject;

		// Token: 0x0400AB4C RID: 43852
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/BuyPanel/Group/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemPriceText;

		// Token: 0x0400AB4D RID: 43853
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemBuyPanelCloseButton;

		// Token: 0x0400AB4E RID: 43854
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/LayoutRoot/BuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemBuyButton;

		// Token: 0x0400AB4F RID: 43855
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/ResonanceInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_resonanceInfoPanel;

		// Token: 0x0400AB50 RID: 43856
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/ResonanceInfoPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanelNameText;

		// Token: 0x0400AB51 RID: 43857
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/ResonanceInfoPanel/SuitInfo/2SuitInfo/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanel2SuitInfoText;

		// Token: 0x0400AB52 RID: 43858
		[AutoBind("./StoreUIPanel/StoreItemBuyPanel/ResonanceInfoPanel/SuitInfo/4SuitInfo/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanel4SuitInfoText;

		// Token: 0x0400AB53 RID: 43859
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_boxBuyPanelUIStateController;

		// Token: 0x0400AB54 RID: 43860
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BoxGoodsDesc/Item/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_boxIconImage;

		// Token: 0x0400AB55 RID: 43861
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BoxGoodsDesc/Item/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxCountText;

		// Token: 0x0400AB56 RID: 43862
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BoxGoodsDesc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxNameText;

		// Token: 0x0400AB57 RID: 43863
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BoxGoodsDesc/GoodCount/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxHaveCountText;

		// Token: 0x0400AB58 RID: 43864
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BoxGoodsDesc/DescPanel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxDescText;

		// Token: 0x0400AB59 RID: 43865
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/ListPanel/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_boxListScrollViewContent;

		// Token: 0x0400AB5A RID: 43866
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BuyPanel/Group/PriceIcon/PriceIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_boxPriceIcon;

		// Token: 0x0400AB5B RID: 43867
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BuyPanel/Group/PriceIcon/PriceIcon/U_crystal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_boxPriceIconEffectGameObject;

		// Token: 0x0400AB5C RID: 43868
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BuyPanel/Group/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_boxPriceText;

		// Token: 0x0400AB5D RID: 43869
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_boxBuyPanelCloseButton;

		// Token: 0x0400AB5E RID: 43870
		[AutoBind("./StoreUIPanel/StoreBoxBuyPanel/LayoutRoot/BuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_boxBuyButton;

		// Token: 0x0400AB5F RID: 43871
		[AutoBind("./Prefab", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400AB60 RID: 43872
		[AutoBind("./Prefab/StoreBoxItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storeBoxItemPrefab;

		// Token: 0x0400AB61 RID: 43873
		[AutoBind("./Prefab/StoreItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storeItemPrefab;

		// Token: 0x0400AB62 RID: 43874
		[AutoBind("./Prefab/HeroSkinItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storeHeroSkinItemPrefab;

		// Token: 0x0400AB63 RID: 43875
		[AutoBind("./Prefab/StoreItemSoldier", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storeSoldierSkinItemPrefab;

		// Token: 0x0400AB64 RID: 43876
		[AutoBind("./StoreUIPanel/Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x0400AB65 RID: 43877
		[AutoBind("./StoreUIPanel/Margin/StoreTab/Recharge", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_rechargeToggle;

		// Token: 0x0400AB66 RID: 43878
		[AutoBind("./StoreUIPanel/Margin/StoreTab/Present", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_presentToggle;

		// Token: 0x0400AB67 RID: 43879
		[AutoBind("./StoreUIPanel/Margin/StoreTab/Crystal", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_crystalToggle;

		// Token: 0x0400AB68 RID: 43880
		[AutoBind("./StoreUIPanel/Margin/StoreTab/Skin", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_skinToggle;

		// Token: 0x0400AB69 RID: 43881
		[AutoBind("./StoreUIPanel/Margin/StoreTab/Mysterious", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousToggle;

		// Token: 0x0400AB6A RID: 43882
		[AutoBind("./StoreUIPanel/StorePackagePanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selfChoosePanel;

		// Token: 0x0400AB6B RID: 43883
		[AutoBind("./StoreUIPanel/RefreshPanel/RefreshText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_refreshTimeText;

		// Token: 0x0400AB6C RID: 43884
		[AutoBind("./StoreUIPanel/RefreshPanel/PricePanel/PriceIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_refreshCurrencyTypeIcon;

		// Token: 0x0400AB6D RID: 43885
		[AutoBind("./StoreUIPanel/RefreshPanel/PricePanel/PriceIcon/U_crystal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_refreshCurrencyTypeIconEffectGameObject;

		// Token: 0x0400AB6E RID: 43886
		[AutoBind("./StoreUIPanel/RefreshPanel/PricePanel/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_refreshPriceText;

		// Token: 0x0400AB6F RID: 43887
		[AutoBind("./StoreUIPanel/RefreshPanel/RefreshButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_refreshButton;

		// Token: 0x0400AB70 RID: 43888
		[AutoBind("./StoreUIPanel/RefreshPanel/TimesText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_refreshTimesText;

		// Token: 0x0400AB71 RID: 43889
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/TabSoldier", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_soldierSkinToggle;

		// Token: 0x0400AB72 RID: 43890
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/TabHero", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_heroSkinToggle;

		// Token: 0x0400AB73 RID: 43891
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/BlackMarket", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousBlackMarketToggle;

		// Token: 0x0400AB74 RID: 43892
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Honor", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousHonorToggle;

		// Token: 0x0400AB75 RID: 43893
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Medal", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousMedalToggle;

		// Token: 0x0400AB76 RID: 43894
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Friendship", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousFriendshipToggle;

		// Token: 0x0400AB77 RID: 43895
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Union", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousUnionToggle;

		// Token: 0x0400AB78 RID: 43896
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Present", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_presentPresentToggle;

		// Token: 0x0400AB79 RID: 43897
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Prerogative", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_presentPreogativeToggle;

		// Token: 0x0400AB7A RID: 43898
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/TabHero", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_skinHeroToggle;

		// Token: 0x0400AB7B RID: 43899
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/TabSoldier", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_skinSoldierToggle;

		// Token: 0x0400AB7C RID: 43900
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Memory", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousMemoryToggle;

		// Token: 0x0400AB7D RID: 43901
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ToggleTab/Equipment", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_mysteriousEquipmentToggle;

		// Token: 0x0400AB7E RID: 43902
		[AutoBind("./StoreUIPanel/PlayerResource/Currency1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_currency1Obj;

		// Token: 0x0400AB7F RID: 43903
		[AutoBind("./StoreUIPanel/PlayerResource/Currency1/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_currency1Icon;

		// Token: 0x0400AB80 RID: 43904
		[AutoBind("./StoreUIPanel/PlayerResource/Currency1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currency1CountText;

		// Token: 0x0400AB81 RID: 43905
		[AutoBind("./StoreUIPanel/PlayerResource/Currency1/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency1AddButton;

		// Token: 0x0400AB82 RID: 43906
		[AutoBind("./StoreUIPanel/PlayerResource/Currency1/DescriptionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency1DescriptionButton;

		// Token: 0x0400AB83 RID: 43907
		[AutoBind("./StoreUIPanel/PlayerResource/Currency2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_currency2Obj;

		// Token: 0x0400AB84 RID: 43908
		[AutoBind("./StoreUIPanel/PlayerResource/Currency2/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_currency2Icon;

		// Token: 0x0400AB85 RID: 43909
		[AutoBind("./StoreUIPanel/PlayerResource/Currency2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currency2CountText;

		// Token: 0x0400AB86 RID: 43910
		[AutoBind("./StoreUIPanel/PlayerResource/Currency2/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency2AddButton;

		// Token: 0x0400AB87 RID: 43911
		[AutoBind("./StoreUIPanel/PlayerResource/Currency2/DescriptionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency2DescriptionButton;

		// Token: 0x0400AB88 RID: 43912
		[AutoBind("./StoreUIPanel/PlayerResource/Currency3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_currency3Obj;

		// Token: 0x0400AB89 RID: 43913
		[AutoBind("./StoreUIPanel/PlayerResource/Currency3/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_currency3Icon;

		// Token: 0x0400AB8A RID: 43914
		[AutoBind("./StoreUIPanel/PlayerResource/Currency3/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_currency3CountText;

		// Token: 0x0400AB8B RID: 43915
		[AutoBind("./StoreUIPanel/PlayerResource/Currency3/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency3AddButton;

		// Token: 0x0400AB8C RID: 43916
		[AutoBind("./StoreUIPanel/PlayerResource/Currency3/DescriptionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_currency3DescriptionButton;

		// Token: 0x0400AB8D RID: 43917
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/BoxGoodsDesc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rechargeNameText;

		// Token: 0x0400AB8E RID: 43918
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/BoxGoodsDesc/ItemIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rechargeIconImage;

		// Token: 0x0400AB8F RID: 43919
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/GoodCount/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rechargeHaveCountText;

		// Token: 0x0400AB90 RID: 43920
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/SureBth/SureText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rechargePriceText;

		// Token: 0x0400AB91 RID: 43921
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/ListPanel/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rechargeGetCountText;

		// Token: 0x0400AB92 RID: 43922
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/ListPanel/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rechargeGetExtraCountText;

		// Token: 0x0400AB93 RID: 43923
		[AutoBind("./StoreUIPanel/RechargePanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rechargePanelCloseButton;

		// Token: 0x0400AB94 RID: 43924
		[AutoBind("./StoreUIPanel/RechargePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_rechargePanelUIStateController;

		// Token: 0x0400AB95 RID: 43925
		[AutoBind("./StoreUIPanel/RechargePanel/LayoutRoot/SureBth", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rechargeBuyButton;

		// Token: 0x0400AB96 RID: 43926
		[AutoBind("./StoreUIPanel/CloseBtn", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x0400AB97 RID: 43927
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel", AutoBindAttribute.InitState.Inactive, false)]
		private CommonUIStateController m_storePrivilegeBuyDetailPanelStateCtrl;

		// Token: 0x0400AB98 RID: 43928
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_storePrivilegeBuyDetailPanelBGButon;

		// Token: 0x0400AB99 RID: 43929
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ItemDesc", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_storePrivilegeStateCtrl;

		// Token: 0x0400AB9A RID: 43930
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ItemDesc/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_StorePrivilegeItemName;

		// Token: 0x0400AB9B RID: 43931
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ItemDesc/Item/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_StorePrivilegeItemIconImage;

		// Token: 0x0400AB9C RID: 43932
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ItemDesc/Item/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_storePrivilegeItemCountText;

		// Token: 0x0400AB9D RID: 43933
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ListPanel/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_storePrivilegeItemDescText;

		// Token: 0x0400AB9E RID: 43934
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/Tape", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storePrivilegeItemLeftDayGameObject;

		// Token: 0x0400AB9F RID: 43935
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/Tape/TSurplusText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_storePrivilegeItemLeftDay;

		// Token: 0x0400ABA0 RID: 43936
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/BuyButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_storePrivilegeItemBuyButton;

		// Token: 0x0400ABA1 RID: 43937
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/BuyButton/SureText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_storePrivilegeItemBuyPrice;

		// Token: 0x0400ABA2 RID: 43938
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ItemDesc/Month/Count/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_storeMonthExtraRewardCount;

		// Token: 0x0400ABA3 RID: 43939
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/StoreMonth&SubscribePanel/ItemDesc/Subscribe/Count/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_subscribePrice;

		// Token: 0x0400ABA4 RID: 43940
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/SubscribePanel/ScrollView/Mask/Contect/AgreementButton1", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subscribePanelPrivateButton;

		// Token: 0x0400ABA5 RID: 43941
		[AutoBind("./StoreUIPanel/MonthCardDetailPanel/SubscribePanel/ScrollView/Mask/Contect/AgreementButton2", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_subscribePanelCancelSubscribeButton;

		// Token: 0x0400ABA6 RID: 43942
		[AutoBind("./StoreUIPanel/MemoryEntranceButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryEntranceButton;

		// Token: 0x0400ABA7 RID: 43943
		[AutoBind("./StoreUIPanel/MemoryEntranceButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_memoryEntranceButtonStateCtrl;

		// Token: 0x0400ABA8 RID: 43944
		[AutoBind("./StoreUIPanel/MemoryEntranceButton/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_memoryEntranceButtonRedPoint;

		// Token: 0x0400ABA9 RID: 43945
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_memoryExtractionPanelStateCtrl;

		// Token: 0x0400ABAA RID: 43946
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_memoryExtractionPanelScrollRect;

		// Token: 0x0400ABAB RID: 43947
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/ListScrollView/Mask/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_memoryExtractionPanelScrollContent;

		// Token: 0x0400ABAC RID: 43948
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/BoxGoodsDesc/HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryExtractionPanelHelpButton;

		// Token: 0x0400ABAD RID: 43949
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/BoxGoodsDesc/ExtractionButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryExtractionPanelExtractionButton;

		// Token: 0x0400ABAE RID: 43950
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/BoxGoodsDesc/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_memoryExtractionPanelTotalValueText;

		// Token: 0x0400ABAF RID: 43951
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/BoxGoodsDesc/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryExtractionPanelCloseButton;

		// Token: 0x0400ABB0 RID: 43952
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_memoryExtractionPanelBGReturnButton;

		// Token: 0x0400ABB1 RID: 43953
		[AutoBind("./StoreUIPanel/MemoryExtractionPanel/LayoutRoot/Empty", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_memoryExtractionPanelEmptyTip;

		// Token: 0x0400ABB2 RID: 43954
		[AutoBind("./Prefab/HeroFragmentItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_HeroFragmentItemPrefab;

		// Token: 0x0400ABB3 RID: 43955
		private bool m_needRefreshPanel;

		// Token: 0x0400ABB4 RID: 43956
		private bool m_isIgnoreToggleEvent;

		// Token: 0x0400ABB5 RID: 43957
		private StoreType m_storeType;

		// Token: 0x0400ABB6 RID: 43958
		private StoreId m_storeId;

		// Token: 0x0400ABB7 RID: 43959
		private int m_fixedStoreItemGoodsID;

		// Token: 0x0400ABB8 RID: 43960
		private int m_goodsID;

		// Token: 0x0400ABB9 RID: 43961
		private int m_index;

		// Token: 0x0400ABBA RID: 43962
		private StoreId m_fixedStoreID;

		// Token: 0x0400ABBB RID: 43963
		private StoreId m_randomStoreID;

		// Token: 0x0400ABBC RID: 43964
		private bool m_isStaticBox;

		// Token: 0x0400ABBD RID: 43965
		public int m_selfChooseItemIndex = -1;

		// Token: 0x0400ABBE RID: 43966
		private Vector3 m_scrollViewStoreContentOriginalLocalPos;

		// Token: 0x0400ABBF RID: 43967
		private Vector3 m_scrollViewHeroContentOriginalLocalPos;

		// Token: 0x0400ABC0 RID: 43968
		private GiftStoreItem m_giftStoreItem;

		// Token: 0x0400ABC1 RID: 43969
		private GameObjectPool<StoreItemUIController> m_storeUnderItemPool;

		// Token: 0x0400ABC2 RID: 43970
		private GameObjectPool<StoreHeroSkinItemUIController> m_storeHeroSkinItemPool;

		// Token: 0x0400ABC3 RID: 43971
		private GameObjectPool<StoreSoldierSkinItemUIController> m_storeSoldierSkinItemPool;

		// Token: 0x0400ABC4 RID: 43972
		private List<Goods> m_gainGoodsList = new List<Goods>();

		// Token: 0x0400ABC5 RID: 43973
		private Dictionary<StoreId, List<Toggle>> m_storeSubType2ToggleDic = new Dictionary<StoreId, List<Toggle>>();

		// Token: 0x0400ABC6 RID: 43974
		private StoreSelfChooseUIController m_storeSelfChooseUIController;

		// Token: 0x0400ABC7 RID: 43975
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400ABC8 RID: 43976
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400ABC9 RID: 43977
		[DoNotToLua]
		private StoreListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400ABCA RID: 43978
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400ABCB RID: 43979
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400ABCC RID: 43980
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400ABCD RID: 43981
		private LuaFunction m_GetHeroSkinItemCtrlByFixedStoreItemIdInt32_hotfix;

		// Token: 0x0400ABCE RID: 43982
		private LuaFunction m_UpdateHeroSkinItemLimitTime_hotfix;

		// Token: 0x0400ABCF RID: 43983
		private LuaFunction m_GetStoreTypeByStoreIdStoreId_hotfix;

		// Token: 0x0400ABD0 RID: 43984
		private LuaFunction m_UpdateStoreStoreId_hotfix;

		// Token: 0x0400ABD1 RID: 43985
		private LuaFunction m_UpdateRechargeStore_hotfix;

		// Token: 0x0400ABD2 RID: 43986
		private LuaFunction m_UpdateGiftStoreStoreId_hotfix;

		// Token: 0x0400ABD3 RID: 43987
		private LuaFunction m_UpdateFixedStoreStoreId_hotfix;

		// Token: 0x0400ABD4 RID: 43988
		private LuaFunction m_UpdateRandomStore_hotfix;

		// Token: 0x0400ABD5 RID: 43989
		private LuaFunction m_ClearPool_hotfix;

		// Token: 0x0400ABD6 RID: 43990
		private LuaFunction m_UpdateFixedStoreInfoStoreId_hotfix;

		// Token: 0x0400ABD7 RID: 43991
		private LuaFunction m_UpdateHeroSkinInfoStoreIdGameObjectPool;

		// Token: 0x0400ABD8 RID: 43992
		private LuaFunction m_SetSkinTicketCountText_hotfix;

		// Token: 0x0400ABD9 RID: 43993
		private LuaFunction m_UpdateSoldierSkinInfoStoreIdGameObjectPool;

		// Token: 0x0400ABDA RID: 43994
		private LuaFunction m_UpdateRandomStoreInfoStoreId_hotfix;

		// Token: 0x0400ABDB RID: 43995
		private LuaFunction m_UpdateRechargeStoreInfo_hotfix;

		// Token: 0x0400ABDC RID: 43996
		private LuaFunction m_SetDefaultStateBoolean_hotfix;

		// Token: 0x0400ABDD RID: 43997
		private LuaFunction m_SetFixedStoreInfoStoreIdGameObjectPool;

		// Token: 0x0400ABDE RID: 43998
		private LuaFunction m_SortFixedStoreItemByUISortFixedStoreItemFixedStoreItem_hotfix;

		// Token: 0x0400ABDF RID: 43999
		private LuaFunction m_RefreshCurrencyDisplayList;

		// Token: 0x0400ABE0 RID: 44000
		private LuaFunction m_SetRandomStoreInfoStoreIdGameObjectPool;

		// Token: 0x0400ABE1 RID: 44001
		private LuaFunction m_SetRechargeStoreInfoGameObjectPool;

		// Token: 0x0400ABE2 RID: 44002
		private LuaFunction m_ShowRefreshPanel_hotfix;

		// Token: 0x0400ABE3 RID: 44003
		private LuaFunction m_HideRefreshPanel_hotfix;

		// Token: 0x0400ABE4 RID: 44004
		private LuaFunction m_SetRefreshPanelStoreId_hotfix;

		// Token: 0x0400ABE5 RID: 44005
		private LuaFunction m_IsNeedRefreshPanel_hotfix;

		// Token: 0x0400ABE6 RID: 44006
		private LuaFunction m_StoreOpenTween_hotfix;

		// Token: 0x0400ABE7 RID: 44007
		private LuaFunction m_OnStoreItemClickStoreItemUIController_hotfix;

		// Token: 0x0400ABE8 RID: 44008
		private LuaFunction m_OnHeroSkinItemClickStoreHeroSkinItemUIController_hotfix;

		// Token: 0x0400ABE9 RID: 44009
		private LuaFunction m_OnSkinItemOutOfDate_hotfix;

		// Token: 0x0400ABEA RID: 44010
		private LuaFunction m_OnSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix;

		// Token: 0x0400ABEB RID: 44011
		private LuaFunction m_SetStoreBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABEC RID: 44012
		private LuaFunction m_SetNormalItemBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABED RID: 44013
		private LuaFunction m_SetRechargeBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABEE RID: 44014
		private LuaFunction m_SetBoxBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABEF RID: 44015
		private LuaFunction m_SetItemBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABF0 RID: 44016
		private LuaFunction m_SetNormalItemBuyPanelGoodsStoreItemUIController_hotfix;

		// Token: 0x0400ABF1 RID: 44017
		private LuaFunction m_SetItemBuyPanelGoodsStoreItemUIController_hotfix;

		// Token: 0x0400ABF2 RID: 44018
		private LuaFunction m_SetEnchantStoneResonanceInfoPanelGoodsTypeInt32_hotfix;

		// Token: 0x0400ABF3 RID: 44019
		private LuaFunction m_SetRandomStoreCountDown_hotfix;

		// Token: 0x0400ABF4 RID: 44020
		private LuaFunction m_OpenBuyPanelStoreIdInt32_hotfix;

		// Token: 0x0400ABF5 RID: 44021
		private LuaFunction m_get_CurStoreId_hotfix;

		// Token: 0x0400ABF6 RID: 44022
		private LuaFunction m_UpdateGiftStoreInfoStoreIdGameObjectPool;

		// Token: 0x0400ABF7 RID: 44023
		private LuaFunction m_SetGiftStoreInfoStoreIdGameObjectPool;

		// Token: 0x0400ABF8 RID: 44024
		private LuaFunction m_SetGiftStoreBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABF9 RID: 44025
		private LuaFunction m_SetGiftStoreStaticBoxBuyPanelStoreItemUIControllerConfigDataItemInfo_hotfix;

		// Token: 0x0400ABFA RID: 44026
		private LuaFunction m_SetMothCardBuyPanelStoreItemUIController_hotfix;

		// Token: 0x0400ABFB RID: 44027
		private LuaFunction m_OnPresentPresentToggleValueChangedBoolean_hotfix;

		// Token: 0x0400ABFC RID: 44028
		private LuaFunction m_OnPresentPreogativeToggleValueChangedBoolean_hotfix;

		// Token: 0x0400ABFD RID: 44029
		private LuaFunction m_OnMonthCardBuyButtonClick_hotfix;

		// Token: 0x0400ABFE RID: 44030
		private LuaFunction m_OnSubscribePrivateClick_hotfix;

		// Token: 0x0400ABFF RID: 44031
		private LuaFunction m_OnCancelSubscribeClick_hotfix;

		// Token: 0x0400AC00 RID: 44032
		private LuaFunction m_OnMonthCardPanelBGButtonClick_hotfix;

		// Token: 0x0400AC01 RID: 44033
		private LuaFunction m_OnPresentToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC02 RID: 44034
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x0400AC03 RID: 44035
		private LuaFunction m_OnRefreshButtonClick_hotfix;

		// Token: 0x0400AC04 RID: 44036
		private LuaFunction m_OnItemBuyPanelBGButtonClick_hotfix;

		// Token: 0x0400AC05 RID: 44037
		private LuaFunction m_OnItemBuyButtonClick_hotfix;

		// Token: 0x0400AC06 RID: 44038
		private LuaFunction m_OnBoxBuyPanelBGButtonClick_hotfix;

		// Token: 0x0400AC07 RID: 44039
		private LuaFunction m_OnRechargePanelBGButtonClick_hotfix;

		// Token: 0x0400AC08 RID: 44040
		private LuaFunction m_OnBoxBuyButtonClick_hotfix;

		// Token: 0x0400AC09 RID: 44041
		private LuaFunction m_IsStoreItemIOSSubscribeItemStoreItemUIController_hotfix;

		// Token: 0x0400AC0A RID: 44042
		private LuaFunction m_OnMemoryEntranceButtonClick_hotfix;

		// Token: 0x0400AC0B RID: 44043
		private LuaFunction m_SetMemoryExtractionPanelInfo_hotfix;

		// Token: 0x0400AC0C RID: 44044
		private LuaFunction m_SortFragmentItemComparerHeroFragmentBagItemHeroFragmentBagItem_hotfix;

		// Token: 0x0400AC0D RID: 44045
		private LuaFunction m_OnMemoryExtractionPanelExtractionButtonClick_hotfix;

		// Token: 0x0400AC0E RID: 44046
		private LuaFunction m_OnMemeryExtractionHelpButtonClick_hotfix;

		// Token: 0x0400AC0F RID: 44047
		private LuaFunction m_CloseMemoryExtractionPanel_hotfix;

		// Token: 0x0400AC10 RID: 44048
		private LuaFunction m_FireChangeStoreEventStoreId_hotfix;

		// Token: 0x0400AC11 RID: 44049
		private LuaFunction m_OnRechargeBuyButtonClick_hotfix;

		// Token: 0x0400AC12 RID: 44050
		private LuaFunction m_OnRechargeToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC13 RID: 44051
		private LuaFunction m_OnCystalToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC14 RID: 44052
		private LuaFunction m_OnSkinToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC15 RID: 44053
		private LuaFunction m_OnSkinTab_HeroToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC16 RID: 44054
		private LuaFunction m_OnSkinTab_SoldierToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC17 RID: 44055
		private LuaFunction m_OnMysteriousToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC18 RID: 44056
		private LuaFunction m_OnMysteriousBlackMarketToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC19 RID: 44057
		private LuaFunction m_OnMysteriousMemoryToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC1A RID: 44058
		private LuaFunction m_OnMysteriousEquipmentToggleValueChangeBoolean_hotfix;

		// Token: 0x0400AC1B RID: 44059
		private LuaFunction m_OnMysteriousHonorToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC1C RID: 44060
		private LuaFunction m_OnMysteriousMedalToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC1D RID: 44061
		private LuaFunction m_OnMysteriousFriendshipToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC1E RID: 44062
		private LuaFunction m_OnMysteriousUnionToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AC1F RID: 44063
		private LuaFunction m_InitStoreSubType2Toggle_hotfix;

		// Token: 0x0400AC20 RID: 44064
		private LuaFunction m_SaveOriginalScrollViewLocalPosition_hotfix;

		// Token: 0x0400AC21 RID: 44065
		private LuaFunction m_UpdateTogglesStoreId_hotfix;

		// Token: 0x0400AC22 RID: 44066
		private LuaFunction m_FixedStoreSkinListSortFuncFixedStoreItemFixedStoreItem_hotfix;

		// Token: 0x0400AC23 RID: 44067
		private LuaFunction m_add_EventOnChangeStoreAction;

		// Token: 0x0400AC24 RID: 44068
		private LuaFunction m_remove_EventOnChangeStoreAction;

		// Token: 0x0400AC25 RID: 44069
		private LuaFunction m_add_EventOnFixedStoreHeroSkinItemClickAction;

		// Token: 0x0400AC26 RID: 44070
		private LuaFunction m_remove_EventOnFixedStoreHeroSkinItemClickAction;

		// Token: 0x0400AC27 RID: 44071
		private LuaFunction m_add_EventOnFixedStoreSoldierSkinItemClickAction;

		// Token: 0x0400AC28 RID: 44072
		private LuaFunction m_remove_EventOnFixedStoreSoldierSkinItemClickAction;

		// Token: 0x0400AC29 RID: 44073
		private LuaFunction m_add_EventOnSkinItemOutOfDateAction_hotfix;

		// Token: 0x0400AC2A RID: 44074
		private LuaFunction m_remove_EventOnSkinItemOutOfDateAction_hotfix;

		// Token: 0x0400AC2B RID: 44075
		private LuaFunction m_add_EventOnFixedStoreItemBuyClickAction;

		// Token: 0x0400AC2C RID: 44076
		private LuaFunction m_remove_EventOnFixedStoreItemBuyClickAction;

		// Token: 0x0400AC2D RID: 44077
		private LuaFunction m_add_EventOnFixedStoreBoxBuyClickAction;

		// Token: 0x0400AC2E RID: 44078
		private LuaFunction m_remove_EventOnFixedStoreBoxBuyClickAction;

		// Token: 0x0400AC2F RID: 44079
		private LuaFunction m_add_EventOnRandomStoreItemBuyClickAction;

		// Token: 0x0400AC30 RID: 44080
		private LuaFunction m_remove_EventOnRandomStoreItemBuyClickAction;

		// Token: 0x0400AC31 RID: 44081
		private LuaFunction m_add_EventOnRandomStoreBoxBuyClickAction;

		// Token: 0x0400AC32 RID: 44082
		private LuaFunction m_remove_EventOnRandomStoreBoxBuyClickAction;

		// Token: 0x0400AC33 RID: 44083
		private LuaFunction m_add_EventOnRechargeStoreBuyClickAction;

		// Token: 0x0400AC34 RID: 44084
		private LuaFunction m_remove_EventOnRechargeStoreBuyClickAction;

		// Token: 0x0400AC35 RID: 44085
		private LuaFunction m_add_EventOnGiftStoreBuyClickAction;

		// Token: 0x0400AC36 RID: 44086
		private LuaFunction m_remove_EventOnGiftStoreBuyClickAction;

		// Token: 0x0400AC37 RID: 44087
		private LuaFunction m_add_EventOnGetRandomStoreAction;

		// Token: 0x0400AC38 RID: 44088
		private LuaFunction m_remove_EventOnGetRandomStoreAction;

		// Token: 0x0400AC39 RID: 44089
		private LuaFunction m_add_EventOnRefreshRandomStoreAction;

		// Token: 0x0400AC3A RID: 44090
		private LuaFunction m_remove_EventOnRefreshRandomStoreAction;

		// Token: 0x0400AC3B RID: 44091
		private LuaFunction m_add_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400AC3C RID: 44092
		private LuaFunction m_remove_EventOnCrystalNotEnoughAction_hotfix;

		// Token: 0x0400AC3D RID: 44093
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400AC3E RID: 44094
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400AC3F RID: 44095
		private LuaFunction m_add_EventOnExtraButtonClickAction;

		// Token: 0x0400AC40 RID: 44096
		private LuaFunction m_remove_EventOnExtraButtonClickAction;

		// Token: 0x0400AC41 RID: 44097
		private LuaFunction m_add_EventOnMemoryExtractionAction;

		// Token: 0x0400AC42 RID: 44098
		private LuaFunction m_remove_EventOnMemoryExtractionAction;

		// Token: 0x02000F22 RID: 3874
		// (Invoke) Token: 0x0601347E RID: 78974
		public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

		// Token: 0x02000F23 RID: 3875
		public new class LuaExportHelper
		{
			// Token: 0x06013481 RID: 78977 RVA: 0x004EFA28 File Offset: 0x004EDC28
			public LuaExportHelper(StoreListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013482 RID: 78978 RVA: 0x004EFA38 File Offset: 0x004EDC38
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013483 RID: 78979 RVA: 0x004EFA48 File Offset: 0x004EDC48
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013484 RID: 78980 RVA: 0x004EFA58 File Offset: 0x004EDC58
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013485 RID: 78981 RVA: 0x004EFA68 File Offset: 0x004EDC68
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013486 RID: 78982 RVA: 0x004EFA80 File Offset: 0x004EDC80
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013487 RID: 78983 RVA: 0x004EFA90 File Offset: 0x004EDC90
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013488 RID: 78984 RVA: 0x004EFAA0 File Offset: 0x004EDCA0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013489 RID: 78985 RVA: 0x004EFAB0 File Offset: 0x004EDCB0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601348A RID: 78986 RVA: 0x004EFAC0 File Offset: 0x004EDCC0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601348B RID: 78987 RVA: 0x004EFAD0 File Offset: 0x004EDCD0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601348C RID: 78988 RVA: 0x004EFAE0 File Offset: 0x004EDCE0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601348D RID: 78989 RVA: 0x004EFAF0 File Offset: 0x004EDCF0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601348E RID: 78990 RVA: 0x004EFB00 File Offset: 0x004EDD00
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601348F RID: 78991 RVA: 0x004EFB10 File Offset: 0x004EDD10
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013490 RID: 78992 RVA: 0x004EFB20 File Offset: 0x004EDD20
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013491 RID: 78993 RVA: 0x004EFB30 File Offset: 0x004EDD30
			public void __callDele_EventOnChangeStore(StoreId obj)
			{
				this.m_owner.__callDele_EventOnChangeStore(obj);
			}

			// Token: 0x06013492 RID: 78994 RVA: 0x004EFB40 File Offset: 0x004EDD40
			public void __clearDele_EventOnChangeStore(StoreId obj)
			{
				this.m_owner.__clearDele_EventOnChangeStore(obj);
			}

			// Token: 0x06013493 RID: 78995 RVA: 0x004EFB50 File Offset: 0x004EDD50
			public void __callDele_EventOnFixedStoreHeroSkinItemClick(StoreHeroSkinItemUIController obj)
			{
				this.m_owner.__callDele_EventOnFixedStoreHeroSkinItemClick(obj);
			}

			// Token: 0x06013494 RID: 78996 RVA: 0x004EFB60 File Offset: 0x004EDD60
			public void __clearDele_EventOnFixedStoreHeroSkinItemClick(StoreHeroSkinItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnFixedStoreHeroSkinItemClick(obj);
			}

			// Token: 0x06013495 RID: 78997 RVA: 0x004EFB70 File Offset: 0x004EDD70
			public void __callDele_EventOnFixedStoreSoldierSkinItemClick(StoreSoldierSkinItemUIController obj)
			{
				this.m_owner.__callDele_EventOnFixedStoreSoldierSkinItemClick(obj);
			}

			// Token: 0x06013496 RID: 78998 RVA: 0x004EFB80 File Offset: 0x004EDD80
			public void __clearDele_EventOnFixedStoreSoldierSkinItemClick(StoreSoldierSkinItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnFixedStoreSoldierSkinItemClick(obj);
			}

			// Token: 0x06013497 RID: 78999 RVA: 0x004EFB90 File Offset: 0x004EDD90
			public void __callDele_EventOnSkinItemOutOfDate()
			{
				this.m_owner.__callDele_EventOnSkinItemOutOfDate();
			}

			// Token: 0x06013498 RID: 79000 RVA: 0x004EFBA0 File Offset: 0x004EDDA0
			public void __clearDele_EventOnSkinItemOutOfDate()
			{
				this.m_owner.__clearDele_EventOnSkinItemOutOfDate();
			}

			// Token: 0x06013499 RID: 79001 RVA: 0x004EFBB0 File Offset: 0x004EDDB0
			public void __callDele_EventOnFixedStoreItemBuyClick(StoreId arg1, int arg2, int arg3, int arg4, List<Goods> arg5)
			{
				this.m_owner.__callDele_EventOnFixedStoreItemBuyClick(arg1, arg2, arg3, arg4, arg5);
			}

			// Token: 0x0601349A RID: 79002 RVA: 0x004EFBC4 File Offset: 0x004EDDC4
			public void __clearDele_EventOnFixedStoreItemBuyClick(StoreId arg1, int arg2, int arg3, int arg4, List<Goods> arg5)
			{
				this.m_owner.__clearDele_EventOnFixedStoreItemBuyClick(arg1, arg2, arg3, arg4, arg5);
			}

			// Token: 0x0601349B RID: 79003 RVA: 0x004EFBD8 File Offset: 0x004EDDD8
			public void __callDele_EventOnFixedStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
			{
				this.m_owner.__callDele_EventOnFixedStoreBoxBuyClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0601349C RID: 79004 RVA: 0x004EFBEC File Offset: 0x004EDDEC
			public void __clearDele_EventOnFixedStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
			{
				this.m_owner.__clearDele_EventOnFixedStoreBoxBuyClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x0601349D RID: 79005 RVA: 0x004EFC00 File Offset: 0x004EDE00
			public void __callDele_EventOnRandomStoreItemBuyClick(StoreId arg1, int arg2, List<Goods> arg3)
			{
				this.m_owner.__callDele_EventOnRandomStoreItemBuyClick(arg1, arg2, arg3);
			}

			// Token: 0x0601349E RID: 79006 RVA: 0x004EFC10 File Offset: 0x004EDE10
			public void __clearDele_EventOnRandomStoreItemBuyClick(StoreId arg1, int arg2, List<Goods> arg3)
			{
				this.m_owner.__clearDele_EventOnRandomStoreItemBuyClick(arg1, arg2, arg3);
			}

			// Token: 0x0601349F RID: 79007 RVA: 0x004EFC20 File Offset: 0x004EDE20
			public void __callDele_EventOnRandomStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
			{
				this.m_owner.__callDele_EventOnRandomStoreBoxBuyClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x060134A0 RID: 79008 RVA: 0x004EFC34 File Offset: 0x004EDE34
			public void __clearDele_EventOnRandomStoreBoxBuyClick(StoreId arg1, int arg2, int arg3, List<Goods> arg4)
			{
				this.m_owner.__clearDele_EventOnRandomStoreBoxBuyClick(arg1, arg2, arg3, arg4);
			}

			// Token: 0x060134A1 RID: 79009 RVA: 0x004EFC48 File Offset: 0x004EDE48
			public void __callDele_EventOnRechargeStoreBuyClick(StoreType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnRechargeStoreBuyClick(arg1, arg2, arg3);
			}

			// Token: 0x060134A2 RID: 79010 RVA: 0x004EFC58 File Offset: 0x004EDE58
			public void __clearDele_EventOnRechargeStoreBuyClick(StoreType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnRechargeStoreBuyClick(arg1, arg2, arg3);
			}

			// Token: 0x060134A3 RID: 79011 RVA: 0x004EFC68 File Offset: 0x004EDE68
			public void __callDele_EventOnGiftStoreBuyClick(ConfigDataGiftStoreItemInfo arg1, bool arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnGiftStoreBuyClick(arg1, arg2, arg3);
			}

			// Token: 0x060134A4 RID: 79012 RVA: 0x004EFC78 File Offset: 0x004EDE78
			public void __clearDele_EventOnGiftStoreBuyClick(ConfigDataGiftStoreItemInfo arg1, bool arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnGiftStoreBuyClick(arg1, arg2, arg3);
			}

			// Token: 0x060134A5 RID: 79013 RVA: 0x004EFC88 File Offset: 0x004EDE88
			public void __callDele_EventOnGetRandomStore(StoreId obj)
			{
				this.m_owner.__callDele_EventOnGetRandomStore(obj);
			}

			// Token: 0x060134A6 RID: 79014 RVA: 0x004EFC98 File Offset: 0x004EDE98
			public void __clearDele_EventOnGetRandomStore(StoreId obj)
			{
				this.m_owner.__clearDele_EventOnGetRandomStore(obj);
			}

			// Token: 0x060134A7 RID: 79015 RVA: 0x004EFCA8 File Offset: 0x004EDEA8
			public void __callDele_EventOnRefreshRandomStore(StoreId obj)
			{
				this.m_owner.__callDele_EventOnRefreshRandomStore(obj);
			}

			// Token: 0x060134A8 RID: 79016 RVA: 0x004EFCB8 File Offset: 0x004EDEB8
			public void __clearDele_EventOnRefreshRandomStore(StoreId obj)
			{
				this.m_owner.__clearDele_EventOnRefreshRandomStore(obj);
			}

			// Token: 0x060134A9 RID: 79017 RVA: 0x004EFCC8 File Offset: 0x004EDEC8
			public void __callDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__callDele_EventOnCrystalNotEnough();
			}

			// Token: 0x060134AA RID: 79018 RVA: 0x004EFCD8 File Offset: 0x004EDED8
			public void __clearDele_EventOnCrystalNotEnough()
			{
				this.m_owner.__clearDele_EventOnCrystalNotEnough();
			}

			// Token: 0x060134AB RID: 79019 RVA: 0x004EFCE8 File Offset: 0x004EDEE8
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x060134AC RID: 79020 RVA: 0x004EFCF8 File Offset: 0x004EDEF8
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x060134AD RID: 79021 RVA: 0x004EFD08 File Offset: 0x004EDF08
			public void __callDele_EventOnExtraButtonClick(GoodsType obj)
			{
				this.m_owner.__callDele_EventOnExtraButtonClick(obj);
			}

			// Token: 0x060134AE RID: 79022 RVA: 0x004EFD18 File Offset: 0x004EDF18
			public void __clearDele_EventOnExtraButtonClick(GoodsType obj)
			{
				this.m_owner.__clearDele_EventOnExtraButtonClick(obj);
			}

			// Token: 0x060134AF RID: 79023 RVA: 0x004EFD28 File Offset: 0x004EDF28
			public void __callDele_EventOnMemoryExtraction(Action obj)
			{
				this.m_owner.__callDele_EventOnMemoryExtraction(obj);
			}

			// Token: 0x060134B0 RID: 79024 RVA: 0x004EFD38 File Offset: 0x004EDF38
			public void __clearDele_EventOnMemoryExtraction(Action obj)
			{
				this.m_owner.__clearDele_EventOnMemoryExtraction(obj);
			}

			// Token: 0x170039FB RID: 14843
			// (get) Token: 0x060134B1 RID: 79025 RVA: 0x004EFD48 File Offset: 0x004EDF48
			// (set) Token: 0x060134B2 RID: 79026 RVA: 0x004EFD58 File Offset: 0x004EDF58
			public CommonUIStateController m_storeUIStateCtrl
			{
				get
				{
					return this.m_owner.m_storeUIStateCtrl;
				}
				set
				{
					this.m_owner.m_storeUIStateCtrl = value;
				}
			}

			// Token: 0x170039FC RID: 14844
			// (get) Token: 0x060134B3 RID: 79027 RVA: 0x004EFD68 File Offset: 0x004EDF68
			// (set) Token: 0x060134B4 RID: 79028 RVA: 0x004EFD78 File Offset: 0x004EDF78
			public CommonUIStateController m_refreshPanelUIStateCtrl
			{
				get
				{
					return this.m_owner.m_refreshPanelUIStateCtrl;
				}
				set
				{
					this.m_owner.m_refreshPanelUIStateCtrl = value;
				}
			}

			// Token: 0x170039FD RID: 14845
			// (get) Token: 0x060134B5 RID: 79029 RVA: 0x004EFD88 File Offset: 0x004EDF88
			// (set) Token: 0x060134B6 RID: 79030 RVA: 0x004EFD98 File Offset: 0x004EDF98
			public GameObject m_scrollViewStoreContent
			{
				get
				{
					return this.m_owner.m_scrollViewStoreContent;
				}
				set
				{
					this.m_owner.m_scrollViewStoreContent = value;
				}
			}

			// Token: 0x170039FE RID: 14846
			// (get) Token: 0x060134B7 RID: 79031 RVA: 0x004EFDA8 File Offset: 0x004EDFA8
			// (set) Token: 0x060134B8 RID: 79032 RVA: 0x004EFDB8 File Offset: 0x004EDFB8
			public GameObject m_scrollViewHeroContent
			{
				get
				{
					return this.m_owner.m_scrollViewHeroContent;
				}
				set
				{
					this.m_owner.m_scrollViewHeroContent = value;
				}
			}

			// Token: 0x170039FF RID: 14847
			// (get) Token: 0x060134B9 RID: 79033 RVA: 0x004EFDC8 File Offset: 0x004EDFC8
			// (set) Token: 0x060134BA RID: 79034 RVA: 0x004EFDD8 File Offset: 0x004EDFD8
			public CommonUIStateController m_itemBuyPanelUIStateController
			{
				get
				{
					return this.m_owner.m_itemBuyPanelUIStateController;
				}
				set
				{
					this.m_owner.m_itemBuyPanelUIStateController = value;
				}
			}

			// Token: 0x17003A00 RID: 14848
			// (get) Token: 0x060134BB RID: 79035 RVA: 0x004EFDE8 File Offset: 0x004EDFE8
			// (set) Token: 0x060134BC RID: 79036 RVA: 0x004EFDF8 File Offset: 0x004EDFF8
			public Image m_itemIconImage
			{
				get
				{
					return this.m_owner.m_itemIconImage;
				}
				set
				{
					this.m_owner.m_itemIconImage = value;
				}
			}

			// Token: 0x17003A01 RID: 14849
			// (get) Token: 0x060134BD RID: 79037 RVA: 0x004EFE08 File Offset: 0x004EE008
			// (set) Token: 0x060134BE RID: 79038 RVA: 0x004EFE18 File Offset: 0x004EE018
			public Text m_itemCountText
			{
				get
				{
					return this.m_owner.m_itemCountText;
				}
				set
				{
					this.m_owner.m_itemCountText = value;
				}
			}

			// Token: 0x17003A02 RID: 14850
			// (get) Token: 0x060134BF RID: 79039 RVA: 0x004EFE28 File Offset: 0x004EE028
			// (set) Token: 0x060134C0 RID: 79040 RVA: 0x004EFE38 File Offset: 0x004EE038
			public GameObject m_itemCountBgGo
			{
				get
				{
					return this.m_owner.m_itemCountBgGo;
				}
				set
				{
					this.m_owner.m_itemCountBgGo = value;
				}
			}

			// Token: 0x17003A03 RID: 14851
			// (get) Token: 0x060134C1 RID: 79041 RVA: 0x004EFE48 File Offset: 0x004EE048
			// (set) Token: 0x060134C2 RID: 79042 RVA: 0x004EFE58 File Offset: 0x004EE058
			public Text m_itemNameText
			{
				get
				{
					return this.m_owner.m_itemNameText;
				}
				set
				{
					this.m_owner.m_itemNameText = value;
				}
			}

			// Token: 0x17003A04 RID: 14852
			// (get) Token: 0x060134C3 RID: 79043 RVA: 0x004EFE68 File Offset: 0x004EE068
			// (set) Token: 0x060134C4 RID: 79044 RVA: 0x004EFE78 File Offset: 0x004EE078
			public GameObject m_itemGoodCountObj
			{
				get
				{
					return this.m_owner.m_itemGoodCountObj;
				}
				set
				{
					this.m_owner.m_itemGoodCountObj = value;
				}
			}

			// Token: 0x17003A05 RID: 14853
			// (get) Token: 0x060134C5 RID: 79045 RVA: 0x004EFE88 File Offset: 0x004EE088
			// (set) Token: 0x060134C6 RID: 79046 RVA: 0x004EFE98 File Offset: 0x004EE098
			public Text m_itemHaveCountText
			{
				get
				{
					return this.m_owner.m_itemHaveCountText;
				}
				set
				{
					this.m_owner.m_itemHaveCountText = value;
				}
			}

			// Token: 0x17003A06 RID: 14854
			// (get) Token: 0x060134C7 RID: 79047 RVA: 0x004EFEA8 File Offset: 0x004EE0A8
			// (set) Token: 0x060134C8 RID: 79048 RVA: 0x004EFEB8 File Offset: 0x004EE0B8
			public Text m_itemDescText
			{
				get
				{
					return this.m_owner.m_itemDescText;
				}
				set
				{
					this.m_owner.m_itemDescText = value;
				}
			}

			// Token: 0x17003A07 RID: 14855
			// (get) Token: 0x060134C9 RID: 79049 RVA: 0x004EFEC8 File Offset: 0x004EE0C8
			// (set) Token: 0x060134CA RID: 79050 RVA: 0x004EFED8 File Offset: 0x004EE0D8
			public Image m_itemPriceIcon
			{
				get
				{
					return this.m_owner.m_itemPriceIcon;
				}
				set
				{
					this.m_owner.m_itemPriceIcon = value;
				}
			}

			// Token: 0x17003A08 RID: 14856
			// (get) Token: 0x060134CB RID: 79051 RVA: 0x004EFEE8 File Offset: 0x004EE0E8
			// (set) Token: 0x060134CC RID: 79052 RVA: 0x004EFEF8 File Offset: 0x004EE0F8
			public GameObject m_itemPriceIconEffectGameObject
			{
				get
				{
					return this.m_owner.m_itemPriceIconEffectGameObject;
				}
				set
				{
					this.m_owner.m_itemPriceIconEffectGameObject = value;
				}
			}

			// Token: 0x17003A09 RID: 14857
			// (get) Token: 0x060134CD RID: 79053 RVA: 0x004EFF08 File Offset: 0x004EE108
			// (set) Token: 0x060134CE RID: 79054 RVA: 0x004EFF18 File Offset: 0x004EE118
			public Text m_itemPriceText
			{
				get
				{
					return this.m_owner.m_itemPriceText;
				}
				set
				{
					this.m_owner.m_itemPriceText = value;
				}
			}

			// Token: 0x17003A0A RID: 14858
			// (get) Token: 0x060134CF RID: 79055 RVA: 0x004EFF28 File Offset: 0x004EE128
			// (set) Token: 0x060134D0 RID: 79056 RVA: 0x004EFF38 File Offset: 0x004EE138
			public Button m_itemBuyPanelCloseButton
			{
				get
				{
					return this.m_owner.m_itemBuyPanelCloseButton;
				}
				set
				{
					this.m_owner.m_itemBuyPanelCloseButton = value;
				}
			}

			// Token: 0x17003A0B RID: 14859
			// (get) Token: 0x060134D1 RID: 79057 RVA: 0x004EFF48 File Offset: 0x004EE148
			// (set) Token: 0x060134D2 RID: 79058 RVA: 0x004EFF58 File Offset: 0x004EE158
			public Button m_itemBuyButton
			{
				get
				{
					return this.m_owner.m_itemBuyButton;
				}
				set
				{
					this.m_owner.m_itemBuyButton = value;
				}
			}

			// Token: 0x17003A0C RID: 14860
			// (get) Token: 0x060134D3 RID: 79059 RVA: 0x004EFF68 File Offset: 0x004EE168
			// (set) Token: 0x060134D4 RID: 79060 RVA: 0x004EFF78 File Offset: 0x004EE178
			public GameObject m_resonanceInfoPanel
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel = value;
				}
			}

			// Token: 0x17003A0D RID: 14861
			// (get) Token: 0x060134D5 RID: 79061 RVA: 0x004EFF88 File Offset: 0x004EE188
			// (set) Token: 0x060134D6 RID: 79062 RVA: 0x004EFF98 File Offset: 0x004EE198
			public Text m_resonanceInfoPanelNameText
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanelNameText;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanelNameText = value;
				}
			}

			// Token: 0x17003A0E RID: 14862
			// (get) Token: 0x060134D7 RID: 79063 RVA: 0x004EFFA8 File Offset: 0x004EE1A8
			// (set) Token: 0x060134D8 RID: 79064 RVA: 0x004EFFB8 File Offset: 0x004EE1B8
			public Text m_resonanceInfoPanel2SuitInfoText
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel2SuitInfoText;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel2SuitInfoText = value;
				}
			}

			// Token: 0x17003A0F RID: 14863
			// (get) Token: 0x060134D9 RID: 79065 RVA: 0x004EFFC8 File Offset: 0x004EE1C8
			// (set) Token: 0x060134DA RID: 79066 RVA: 0x004EFFD8 File Offset: 0x004EE1D8
			public Text m_resonanceInfoPanel4SuitInfoText
			{
				get
				{
					return this.m_owner.m_resonanceInfoPanel4SuitInfoText;
				}
				set
				{
					this.m_owner.m_resonanceInfoPanel4SuitInfoText = value;
				}
			}

			// Token: 0x17003A10 RID: 14864
			// (get) Token: 0x060134DB RID: 79067 RVA: 0x004EFFE8 File Offset: 0x004EE1E8
			// (set) Token: 0x060134DC RID: 79068 RVA: 0x004EFFF8 File Offset: 0x004EE1F8
			public CommonUIStateController m_boxBuyPanelUIStateController
			{
				get
				{
					return this.m_owner.m_boxBuyPanelUIStateController;
				}
				set
				{
					this.m_owner.m_boxBuyPanelUIStateController = value;
				}
			}

			// Token: 0x17003A11 RID: 14865
			// (get) Token: 0x060134DD RID: 79069 RVA: 0x004F0008 File Offset: 0x004EE208
			// (set) Token: 0x060134DE RID: 79070 RVA: 0x004F0018 File Offset: 0x004EE218
			public Image m_boxIconImage
			{
				get
				{
					return this.m_owner.m_boxIconImage;
				}
				set
				{
					this.m_owner.m_boxIconImage = value;
				}
			}

			// Token: 0x17003A12 RID: 14866
			// (get) Token: 0x060134DF RID: 79071 RVA: 0x004F0028 File Offset: 0x004EE228
			// (set) Token: 0x060134E0 RID: 79072 RVA: 0x004F0038 File Offset: 0x004EE238
			public Text m_boxCountText
			{
				get
				{
					return this.m_owner.m_boxCountText;
				}
				set
				{
					this.m_owner.m_boxCountText = value;
				}
			}

			// Token: 0x17003A13 RID: 14867
			// (get) Token: 0x060134E1 RID: 79073 RVA: 0x004F0048 File Offset: 0x004EE248
			// (set) Token: 0x060134E2 RID: 79074 RVA: 0x004F0058 File Offset: 0x004EE258
			public Text m_boxNameText
			{
				get
				{
					return this.m_owner.m_boxNameText;
				}
				set
				{
					this.m_owner.m_boxNameText = value;
				}
			}

			// Token: 0x17003A14 RID: 14868
			// (get) Token: 0x060134E3 RID: 79075 RVA: 0x004F0068 File Offset: 0x004EE268
			// (set) Token: 0x060134E4 RID: 79076 RVA: 0x004F0078 File Offset: 0x004EE278
			public Text m_boxHaveCountText
			{
				get
				{
					return this.m_owner.m_boxHaveCountText;
				}
				set
				{
					this.m_owner.m_boxHaveCountText = value;
				}
			}

			// Token: 0x17003A15 RID: 14869
			// (get) Token: 0x060134E5 RID: 79077 RVA: 0x004F0088 File Offset: 0x004EE288
			// (set) Token: 0x060134E6 RID: 79078 RVA: 0x004F0098 File Offset: 0x004EE298
			public Text m_boxDescText
			{
				get
				{
					return this.m_owner.m_boxDescText;
				}
				set
				{
					this.m_owner.m_boxDescText = value;
				}
			}

			// Token: 0x17003A16 RID: 14870
			// (get) Token: 0x060134E7 RID: 79079 RVA: 0x004F00A8 File Offset: 0x004EE2A8
			// (set) Token: 0x060134E8 RID: 79080 RVA: 0x004F00B8 File Offset: 0x004EE2B8
			public GameObject m_boxListScrollViewContent
			{
				get
				{
					return this.m_owner.m_boxListScrollViewContent;
				}
				set
				{
					this.m_owner.m_boxListScrollViewContent = value;
				}
			}

			// Token: 0x17003A17 RID: 14871
			// (get) Token: 0x060134E9 RID: 79081 RVA: 0x004F00C8 File Offset: 0x004EE2C8
			// (set) Token: 0x060134EA RID: 79082 RVA: 0x004F00D8 File Offset: 0x004EE2D8
			public Image m_boxPriceIcon
			{
				get
				{
					return this.m_owner.m_boxPriceIcon;
				}
				set
				{
					this.m_owner.m_boxPriceIcon = value;
				}
			}

			// Token: 0x17003A18 RID: 14872
			// (get) Token: 0x060134EB RID: 79083 RVA: 0x004F00E8 File Offset: 0x004EE2E8
			// (set) Token: 0x060134EC RID: 79084 RVA: 0x004F00F8 File Offset: 0x004EE2F8
			public GameObject m_boxPriceIconEffectGameObject
			{
				get
				{
					return this.m_owner.m_boxPriceIconEffectGameObject;
				}
				set
				{
					this.m_owner.m_boxPriceIconEffectGameObject = value;
				}
			}

			// Token: 0x17003A19 RID: 14873
			// (get) Token: 0x060134ED RID: 79085 RVA: 0x004F0108 File Offset: 0x004EE308
			// (set) Token: 0x060134EE RID: 79086 RVA: 0x004F0118 File Offset: 0x004EE318
			public Text m_boxPriceText
			{
				get
				{
					return this.m_owner.m_boxPriceText;
				}
				set
				{
					this.m_owner.m_boxPriceText = value;
				}
			}

			// Token: 0x17003A1A RID: 14874
			// (get) Token: 0x060134EF RID: 79087 RVA: 0x004F0128 File Offset: 0x004EE328
			// (set) Token: 0x060134F0 RID: 79088 RVA: 0x004F0138 File Offset: 0x004EE338
			public Button m_boxBuyPanelCloseButton
			{
				get
				{
					return this.m_owner.m_boxBuyPanelCloseButton;
				}
				set
				{
					this.m_owner.m_boxBuyPanelCloseButton = value;
				}
			}

			// Token: 0x17003A1B RID: 14875
			// (get) Token: 0x060134F1 RID: 79089 RVA: 0x004F0148 File Offset: 0x004EE348
			// (set) Token: 0x060134F2 RID: 79090 RVA: 0x004F0158 File Offset: 0x004EE358
			public Button m_boxBuyButton
			{
				get
				{
					return this.m_owner.m_boxBuyButton;
				}
				set
				{
					this.m_owner.m_boxBuyButton = value;
				}
			}

			// Token: 0x17003A1C RID: 14876
			// (get) Token: 0x060134F3 RID: 79091 RVA: 0x004F0168 File Offset: 0x004EE368
			// (set) Token: 0x060134F4 RID: 79092 RVA: 0x004F0178 File Offset: 0x004EE378
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

			// Token: 0x17003A1D RID: 14877
			// (get) Token: 0x060134F5 RID: 79093 RVA: 0x004F0188 File Offset: 0x004EE388
			// (set) Token: 0x060134F6 RID: 79094 RVA: 0x004F0198 File Offset: 0x004EE398
			public GameObject m_storeBoxItemPrefab
			{
				get
				{
					return this.m_owner.m_storeBoxItemPrefab;
				}
				set
				{
					this.m_owner.m_storeBoxItemPrefab = value;
				}
			}

			// Token: 0x17003A1E RID: 14878
			// (get) Token: 0x060134F7 RID: 79095 RVA: 0x004F01A8 File Offset: 0x004EE3A8
			// (set) Token: 0x060134F8 RID: 79096 RVA: 0x004F01B8 File Offset: 0x004EE3B8
			public GameObject m_storeItemPrefab
			{
				get
				{
					return this.m_owner.m_storeItemPrefab;
				}
				set
				{
					this.m_owner.m_storeItemPrefab = value;
				}
			}

			// Token: 0x17003A1F RID: 14879
			// (get) Token: 0x060134F9 RID: 79097 RVA: 0x004F01C8 File Offset: 0x004EE3C8
			// (set) Token: 0x060134FA RID: 79098 RVA: 0x004F01D8 File Offset: 0x004EE3D8
			public GameObject m_storeHeroSkinItemPrefab
			{
				get
				{
					return this.m_owner.m_storeHeroSkinItemPrefab;
				}
				set
				{
					this.m_owner.m_storeHeroSkinItemPrefab = value;
				}
			}

			// Token: 0x17003A20 RID: 14880
			// (get) Token: 0x060134FB RID: 79099 RVA: 0x004F01E8 File Offset: 0x004EE3E8
			// (set) Token: 0x060134FC RID: 79100 RVA: 0x004F01F8 File Offset: 0x004EE3F8
			public GameObject m_storeSoldierSkinItemPrefab
			{
				get
				{
					return this.m_owner.m_storeSoldierSkinItemPrefab;
				}
				set
				{
					this.m_owner.m_storeSoldierSkinItemPrefab = value;
				}
			}

			// Token: 0x17003A21 RID: 14881
			// (get) Token: 0x060134FD RID: 79101 RVA: 0x004F0208 File Offset: 0x004EE408
			// (set) Token: 0x060134FE RID: 79102 RVA: 0x004F0218 File Offset: 0x004EE418
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

			// Token: 0x17003A22 RID: 14882
			// (get) Token: 0x060134FF RID: 79103 RVA: 0x004F0228 File Offset: 0x004EE428
			// (set) Token: 0x06013500 RID: 79104 RVA: 0x004F0238 File Offset: 0x004EE438
			public Toggle m_rechargeToggle
			{
				get
				{
					return this.m_owner.m_rechargeToggle;
				}
				set
				{
					this.m_owner.m_rechargeToggle = value;
				}
			}

			// Token: 0x17003A23 RID: 14883
			// (get) Token: 0x06013501 RID: 79105 RVA: 0x004F0248 File Offset: 0x004EE448
			// (set) Token: 0x06013502 RID: 79106 RVA: 0x004F0258 File Offset: 0x004EE458
			public Toggle m_presentToggle
			{
				get
				{
					return this.m_owner.m_presentToggle;
				}
				set
				{
					this.m_owner.m_presentToggle = value;
				}
			}

			// Token: 0x17003A24 RID: 14884
			// (get) Token: 0x06013503 RID: 79107 RVA: 0x004F0268 File Offset: 0x004EE468
			// (set) Token: 0x06013504 RID: 79108 RVA: 0x004F0278 File Offset: 0x004EE478
			public Toggle m_crystalToggle
			{
				get
				{
					return this.m_owner.m_crystalToggle;
				}
				set
				{
					this.m_owner.m_crystalToggle = value;
				}
			}

			// Token: 0x17003A25 RID: 14885
			// (get) Token: 0x06013505 RID: 79109 RVA: 0x004F0288 File Offset: 0x004EE488
			// (set) Token: 0x06013506 RID: 79110 RVA: 0x004F0298 File Offset: 0x004EE498
			public Toggle m_skinToggle
			{
				get
				{
					return this.m_owner.m_skinToggle;
				}
				set
				{
					this.m_owner.m_skinToggle = value;
				}
			}

			// Token: 0x17003A26 RID: 14886
			// (get) Token: 0x06013507 RID: 79111 RVA: 0x004F02A8 File Offset: 0x004EE4A8
			// (set) Token: 0x06013508 RID: 79112 RVA: 0x004F02B8 File Offset: 0x004EE4B8
			public Toggle m_mysteriousToggle
			{
				get
				{
					return this.m_owner.m_mysteriousToggle;
				}
				set
				{
					this.m_owner.m_mysteriousToggle = value;
				}
			}

			// Token: 0x17003A27 RID: 14887
			// (get) Token: 0x06013509 RID: 79113 RVA: 0x004F02C8 File Offset: 0x004EE4C8
			// (set) Token: 0x0601350A RID: 79114 RVA: 0x004F02D8 File Offset: 0x004EE4D8
			public GameObject m_selfChoosePanel
			{
				get
				{
					return this.m_owner.m_selfChoosePanel;
				}
				set
				{
					this.m_owner.m_selfChoosePanel = value;
				}
			}

			// Token: 0x17003A28 RID: 14888
			// (get) Token: 0x0601350B RID: 79115 RVA: 0x004F02E8 File Offset: 0x004EE4E8
			// (set) Token: 0x0601350C RID: 79116 RVA: 0x004F02F8 File Offset: 0x004EE4F8
			public Text m_refreshTimeText
			{
				get
				{
					return this.m_owner.m_refreshTimeText;
				}
				set
				{
					this.m_owner.m_refreshTimeText = value;
				}
			}

			// Token: 0x17003A29 RID: 14889
			// (get) Token: 0x0601350D RID: 79117 RVA: 0x004F0308 File Offset: 0x004EE508
			// (set) Token: 0x0601350E RID: 79118 RVA: 0x004F0318 File Offset: 0x004EE518
			public Image m_refreshCurrencyTypeIcon
			{
				get
				{
					return this.m_owner.m_refreshCurrencyTypeIcon;
				}
				set
				{
					this.m_owner.m_refreshCurrencyTypeIcon = value;
				}
			}

			// Token: 0x17003A2A RID: 14890
			// (get) Token: 0x0601350F RID: 79119 RVA: 0x004F0328 File Offset: 0x004EE528
			// (set) Token: 0x06013510 RID: 79120 RVA: 0x004F0338 File Offset: 0x004EE538
			public GameObject m_refreshCurrencyTypeIconEffectGameObject
			{
				get
				{
					return this.m_owner.m_refreshCurrencyTypeIconEffectGameObject;
				}
				set
				{
					this.m_owner.m_refreshCurrencyTypeIconEffectGameObject = value;
				}
			}

			// Token: 0x17003A2B RID: 14891
			// (get) Token: 0x06013511 RID: 79121 RVA: 0x004F0348 File Offset: 0x004EE548
			// (set) Token: 0x06013512 RID: 79122 RVA: 0x004F0358 File Offset: 0x004EE558
			public Text m_refreshPriceText
			{
				get
				{
					return this.m_owner.m_refreshPriceText;
				}
				set
				{
					this.m_owner.m_refreshPriceText = value;
				}
			}

			// Token: 0x17003A2C RID: 14892
			// (get) Token: 0x06013513 RID: 79123 RVA: 0x004F0368 File Offset: 0x004EE568
			// (set) Token: 0x06013514 RID: 79124 RVA: 0x004F0378 File Offset: 0x004EE578
			public Button m_refreshButton
			{
				get
				{
					return this.m_owner.m_refreshButton;
				}
				set
				{
					this.m_owner.m_refreshButton = value;
				}
			}

			// Token: 0x17003A2D RID: 14893
			// (get) Token: 0x06013515 RID: 79125 RVA: 0x004F0388 File Offset: 0x004EE588
			// (set) Token: 0x06013516 RID: 79126 RVA: 0x004F0398 File Offset: 0x004EE598
			public Text m_refreshTimesText
			{
				get
				{
					return this.m_owner.m_refreshTimesText;
				}
				set
				{
					this.m_owner.m_refreshTimesText = value;
				}
			}

			// Token: 0x17003A2E RID: 14894
			// (get) Token: 0x06013517 RID: 79127 RVA: 0x004F03A8 File Offset: 0x004EE5A8
			// (set) Token: 0x06013518 RID: 79128 RVA: 0x004F03B8 File Offset: 0x004EE5B8
			public Toggle m_soldierSkinToggle
			{
				get
				{
					return this.m_owner.m_soldierSkinToggle;
				}
				set
				{
					this.m_owner.m_soldierSkinToggle = value;
				}
			}

			// Token: 0x17003A2F RID: 14895
			// (get) Token: 0x06013519 RID: 79129 RVA: 0x004F03C8 File Offset: 0x004EE5C8
			// (set) Token: 0x0601351A RID: 79130 RVA: 0x004F03D8 File Offset: 0x004EE5D8
			public Toggle m_heroSkinToggle
			{
				get
				{
					return this.m_owner.m_heroSkinToggle;
				}
				set
				{
					this.m_owner.m_heroSkinToggle = value;
				}
			}

			// Token: 0x17003A30 RID: 14896
			// (get) Token: 0x0601351B RID: 79131 RVA: 0x004F03E8 File Offset: 0x004EE5E8
			// (set) Token: 0x0601351C RID: 79132 RVA: 0x004F03F8 File Offset: 0x004EE5F8
			public Toggle m_mysteriousBlackMarketToggle
			{
				get
				{
					return this.m_owner.m_mysteriousBlackMarketToggle;
				}
				set
				{
					this.m_owner.m_mysteriousBlackMarketToggle = value;
				}
			}

			// Token: 0x17003A31 RID: 14897
			// (get) Token: 0x0601351D RID: 79133 RVA: 0x004F0408 File Offset: 0x004EE608
			// (set) Token: 0x0601351E RID: 79134 RVA: 0x004F0418 File Offset: 0x004EE618
			public Toggle m_mysteriousHonorToggle
			{
				get
				{
					return this.m_owner.m_mysteriousHonorToggle;
				}
				set
				{
					this.m_owner.m_mysteriousHonorToggle = value;
				}
			}

			// Token: 0x17003A32 RID: 14898
			// (get) Token: 0x0601351F RID: 79135 RVA: 0x004F0428 File Offset: 0x004EE628
			// (set) Token: 0x06013520 RID: 79136 RVA: 0x004F0438 File Offset: 0x004EE638
			public Toggle m_mysteriousMedalToggle
			{
				get
				{
					return this.m_owner.m_mysteriousMedalToggle;
				}
				set
				{
					this.m_owner.m_mysteriousMedalToggle = value;
				}
			}

			// Token: 0x17003A33 RID: 14899
			// (get) Token: 0x06013521 RID: 79137 RVA: 0x004F0448 File Offset: 0x004EE648
			// (set) Token: 0x06013522 RID: 79138 RVA: 0x004F0458 File Offset: 0x004EE658
			public Toggle m_mysteriousFriendshipToggle
			{
				get
				{
					return this.m_owner.m_mysteriousFriendshipToggle;
				}
				set
				{
					this.m_owner.m_mysteriousFriendshipToggle = value;
				}
			}

			// Token: 0x17003A34 RID: 14900
			// (get) Token: 0x06013523 RID: 79139 RVA: 0x004F0468 File Offset: 0x004EE668
			// (set) Token: 0x06013524 RID: 79140 RVA: 0x004F0478 File Offset: 0x004EE678
			public Toggle m_mysteriousUnionToggle
			{
				get
				{
					return this.m_owner.m_mysteriousUnionToggle;
				}
				set
				{
					this.m_owner.m_mysteriousUnionToggle = value;
				}
			}

			// Token: 0x17003A35 RID: 14901
			// (get) Token: 0x06013525 RID: 79141 RVA: 0x004F0488 File Offset: 0x004EE688
			// (set) Token: 0x06013526 RID: 79142 RVA: 0x004F0498 File Offset: 0x004EE698
			public Toggle m_presentPresentToggle
			{
				get
				{
					return this.m_owner.m_presentPresentToggle;
				}
				set
				{
					this.m_owner.m_presentPresentToggle = value;
				}
			}

			// Token: 0x17003A36 RID: 14902
			// (get) Token: 0x06013527 RID: 79143 RVA: 0x004F04A8 File Offset: 0x004EE6A8
			// (set) Token: 0x06013528 RID: 79144 RVA: 0x004F04B8 File Offset: 0x004EE6B8
			public Toggle m_presentPreogativeToggle
			{
				get
				{
					return this.m_owner.m_presentPreogativeToggle;
				}
				set
				{
					this.m_owner.m_presentPreogativeToggle = value;
				}
			}

			// Token: 0x17003A37 RID: 14903
			// (get) Token: 0x06013529 RID: 79145 RVA: 0x004F04C8 File Offset: 0x004EE6C8
			// (set) Token: 0x0601352A RID: 79146 RVA: 0x004F04D8 File Offset: 0x004EE6D8
			public Toggle m_skinHeroToggle
			{
				get
				{
					return this.m_owner.m_skinHeroToggle;
				}
				set
				{
					this.m_owner.m_skinHeroToggle = value;
				}
			}

			// Token: 0x17003A38 RID: 14904
			// (get) Token: 0x0601352B RID: 79147 RVA: 0x004F04E8 File Offset: 0x004EE6E8
			// (set) Token: 0x0601352C RID: 79148 RVA: 0x004F04F8 File Offset: 0x004EE6F8
			public Toggle m_skinSoldierToggle
			{
				get
				{
					return this.m_owner.m_skinSoldierToggle;
				}
				set
				{
					this.m_owner.m_skinSoldierToggle = value;
				}
			}

			// Token: 0x17003A39 RID: 14905
			// (get) Token: 0x0601352D RID: 79149 RVA: 0x004F0508 File Offset: 0x004EE708
			// (set) Token: 0x0601352E RID: 79150 RVA: 0x004F0518 File Offset: 0x004EE718
			public Toggle m_mysteriousMemoryToggle
			{
				get
				{
					return this.m_owner.m_mysteriousMemoryToggle;
				}
				set
				{
					this.m_owner.m_mysteriousMemoryToggle = value;
				}
			}

			// Token: 0x17003A3A RID: 14906
			// (get) Token: 0x0601352F RID: 79151 RVA: 0x004F0528 File Offset: 0x004EE728
			// (set) Token: 0x06013530 RID: 79152 RVA: 0x004F0538 File Offset: 0x004EE738
			public Toggle m_mysteriousEquipmentToggle
			{
				get
				{
					return this.m_owner.m_mysteriousEquipmentToggle;
				}
				set
				{
					this.m_owner.m_mysteriousEquipmentToggle = value;
				}
			}

			// Token: 0x17003A3B RID: 14907
			// (get) Token: 0x06013531 RID: 79153 RVA: 0x004F0548 File Offset: 0x004EE748
			// (set) Token: 0x06013532 RID: 79154 RVA: 0x004F0558 File Offset: 0x004EE758
			public GameObject m_currency1Obj
			{
				get
				{
					return this.m_owner.m_currency1Obj;
				}
				set
				{
					this.m_owner.m_currency1Obj = value;
				}
			}

			// Token: 0x17003A3C RID: 14908
			// (get) Token: 0x06013533 RID: 79155 RVA: 0x004F0568 File Offset: 0x004EE768
			// (set) Token: 0x06013534 RID: 79156 RVA: 0x004F0578 File Offset: 0x004EE778
			public Image m_currency1Icon
			{
				get
				{
					return this.m_owner.m_currency1Icon;
				}
				set
				{
					this.m_owner.m_currency1Icon = value;
				}
			}

			// Token: 0x17003A3D RID: 14909
			// (get) Token: 0x06013535 RID: 79157 RVA: 0x004F0588 File Offset: 0x004EE788
			// (set) Token: 0x06013536 RID: 79158 RVA: 0x004F0598 File Offset: 0x004EE798
			public Text m_currency1CountText
			{
				get
				{
					return this.m_owner.m_currency1CountText;
				}
				set
				{
					this.m_owner.m_currency1CountText = value;
				}
			}

			// Token: 0x17003A3E RID: 14910
			// (get) Token: 0x06013537 RID: 79159 RVA: 0x004F05A8 File Offset: 0x004EE7A8
			// (set) Token: 0x06013538 RID: 79160 RVA: 0x004F05B8 File Offset: 0x004EE7B8
			public Button m_currency1AddButton
			{
				get
				{
					return this.m_owner.m_currency1AddButton;
				}
				set
				{
					this.m_owner.m_currency1AddButton = value;
				}
			}

			// Token: 0x17003A3F RID: 14911
			// (get) Token: 0x06013539 RID: 79161 RVA: 0x004F05C8 File Offset: 0x004EE7C8
			// (set) Token: 0x0601353A RID: 79162 RVA: 0x004F05D8 File Offset: 0x004EE7D8
			public Button m_currency1DescriptionButton
			{
				get
				{
					return this.m_owner.m_currency1DescriptionButton;
				}
				set
				{
					this.m_owner.m_currency1DescriptionButton = value;
				}
			}

			// Token: 0x17003A40 RID: 14912
			// (get) Token: 0x0601353B RID: 79163 RVA: 0x004F05E8 File Offset: 0x004EE7E8
			// (set) Token: 0x0601353C RID: 79164 RVA: 0x004F05F8 File Offset: 0x004EE7F8
			public GameObject m_currency2Obj
			{
				get
				{
					return this.m_owner.m_currency2Obj;
				}
				set
				{
					this.m_owner.m_currency2Obj = value;
				}
			}

			// Token: 0x17003A41 RID: 14913
			// (get) Token: 0x0601353D RID: 79165 RVA: 0x004F0608 File Offset: 0x004EE808
			// (set) Token: 0x0601353E RID: 79166 RVA: 0x004F0618 File Offset: 0x004EE818
			public Image m_currency2Icon
			{
				get
				{
					return this.m_owner.m_currency2Icon;
				}
				set
				{
					this.m_owner.m_currency2Icon = value;
				}
			}

			// Token: 0x17003A42 RID: 14914
			// (get) Token: 0x0601353F RID: 79167 RVA: 0x004F0628 File Offset: 0x004EE828
			// (set) Token: 0x06013540 RID: 79168 RVA: 0x004F0638 File Offset: 0x004EE838
			public Text m_currency2CountText
			{
				get
				{
					return this.m_owner.m_currency2CountText;
				}
				set
				{
					this.m_owner.m_currency2CountText = value;
				}
			}

			// Token: 0x17003A43 RID: 14915
			// (get) Token: 0x06013541 RID: 79169 RVA: 0x004F0648 File Offset: 0x004EE848
			// (set) Token: 0x06013542 RID: 79170 RVA: 0x004F0658 File Offset: 0x004EE858
			public Button m_currency2AddButton
			{
				get
				{
					return this.m_owner.m_currency2AddButton;
				}
				set
				{
					this.m_owner.m_currency2AddButton = value;
				}
			}

			// Token: 0x17003A44 RID: 14916
			// (get) Token: 0x06013543 RID: 79171 RVA: 0x004F0668 File Offset: 0x004EE868
			// (set) Token: 0x06013544 RID: 79172 RVA: 0x004F0678 File Offset: 0x004EE878
			public Button m_currency2DescriptionButton
			{
				get
				{
					return this.m_owner.m_currency2DescriptionButton;
				}
				set
				{
					this.m_owner.m_currency2DescriptionButton = value;
				}
			}

			// Token: 0x17003A45 RID: 14917
			// (get) Token: 0x06013545 RID: 79173 RVA: 0x004F0688 File Offset: 0x004EE888
			// (set) Token: 0x06013546 RID: 79174 RVA: 0x004F0698 File Offset: 0x004EE898
			public GameObject m_currency3Obj
			{
				get
				{
					return this.m_owner.m_currency3Obj;
				}
				set
				{
					this.m_owner.m_currency3Obj = value;
				}
			}

			// Token: 0x17003A46 RID: 14918
			// (get) Token: 0x06013547 RID: 79175 RVA: 0x004F06A8 File Offset: 0x004EE8A8
			// (set) Token: 0x06013548 RID: 79176 RVA: 0x004F06B8 File Offset: 0x004EE8B8
			public Image m_currency3Icon
			{
				get
				{
					return this.m_owner.m_currency3Icon;
				}
				set
				{
					this.m_owner.m_currency3Icon = value;
				}
			}

			// Token: 0x17003A47 RID: 14919
			// (get) Token: 0x06013549 RID: 79177 RVA: 0x004F06C8 File Offset: 0x004EE8C8
			// (set) Token: 0x0601354A RID: 79178 RVA: 0x004F06D8 File Offset: 0x004EE8D8
			public Text m_currency3CountText
			{
				get
				{
					return this.m_owner.m_currency3CountText;
				}
				set
				{
					this.m_owner.m_currency3CountText = value;
				}
			}

			// Token: 0x17003A48 RID: 14920
			// (get) Token: 0x0601354B RID: 79179 RVA: 0x004F06E8 File Offset: 0x004EE8E8
			// (set) Token: 0x0601354C RID: 79180 RVA: 0x004F06F8 File Offset: 0x004EE8F8
			public Button m_currency3AddButton
			{
				get
				{
					return this.m_owner.m_currency3AddButton;
				}
				set
				{
					this.m_owner.m_currency3AddButton = value;
				}
			}

			// Token: 0x17003A49 RID: 14921
			// (get) Token: 0x0601354D RID: 79181 RVA: 0x004F0708 File Offset: 0x004EE908
			// (set) Token: 0x0601354E RID: 79182 RVA: 0x004F0718 File Offset: 0x004EE918
			public Button m_currency3DescriptionButton
			{
				get
				{
					return this.m_owner.m_currency3DescriptionButton;
				}
				set
				{
					this.m_owner.m_currency3DescriptionButton = value;
				}
			}

			// Token: 0x17003A4A RID: 14922
			// (get) Token: 0x0601354F RID: 79183 RVA: 0x004F0728 File Offset: 0x004EE928
			// (set) Token: 0x06013550 RID: 79184 RVA: 0x004F0738 File Offset: 0x004EE938
			public Text m_rechargeNameText
			{
				get
				{
					return this.m_owner.m_rechargeNameText;
				}
				set
				{
					this.m_owner.m_rechargeNameText = value;
				}
			}

			// Token: 0x17003A4B RID: 14923
			// (get) Token: 0x06013551 RID: 79185 RVA: 0x004F0748 File Offset: 0x004EE948
			// (set) Token: 0x06013552 RID: 79186 RVA: 0x004F0758 File Offset: 0x004EE958
			public Image m_rechargeIconImage
			{
				get
				{
					return this.m_owner.m_rechargeIconImage;
				}
				set
				{
					this.m_owner.m_rechargeIconImage = value;
				}
			}

			// Token: 0x17003A4C RID: 14924
			// (get) Token: 0x06013553 RID: 79187 RVA: 0x004F0768 File Offset: 0x004EE968
			// (set) Token: 0x06013554 RID: 79188 RVA: 0x004F0778 File Offset: 0x004EE978
			public Text m_rechargeHaveCountText
			{
				get
				{
					return this.m_owner.m_rechargeHaveCountText;
				}
				set
				{
					this.m_owner.m_rechargeHaveCountText = value;
				}
			}

			// Token: 0x17003A4D RID: 14925
			// (get) Token: 0x06013555 RID: 79189 RVA: 0x004F0788 File Offset: 0x004EE988
			// (set) Token: 0x06013556 RID: 79190 RVA: 0x004F0798 File Offset: 0x004EE998
			public Text m_rechargePriceText
			{
				get
				{
					return this.m_owner.m_rechargePriceText;
				}
				set
				{
					this.m_owner.m_rechargePriceText = value;
				}
			}

			// Token: 0x17003A4E RID: 14926
			// (get) Token: 0x06013557 RID: 79191 RVA: 0x004F07A8 File Offset: 0x004EE9A8
			// (set) Token: 0x06013558 RID: 79192 RVA: 0x004F07B8 File Offset: 0x004EE9B8
			public Text m_rechargeGetCountText
			{
				get
				{
					return this.m_owner.m_rechargeGetCountText;
				}
				set
				{
					this.m_owner.m_rechargeGetCountText = value;
				}
			}

			// Token: 0x17003A4F RID: 14927
			// (get) Token: 0x06013559 RID: 79193 RVA: 0x004F07C8 File Offset: 0x004EE9C8
			// (set) Token: 0x0601355A RID: 79194 RVA: 0x004F07D8 File Offset: 0x004EE9D8
			public Text m_rechargeGetExtraCountText
			{
				get
				{
					return this.m_owner.m_rechargeGetExtraCountText;
				}
				set
				{
					this.m_owner.m_rechargeGetExtraCountText = value;
				}
			}

			// Token: 0x17003A50 RID: 14928
			// (get) Token: 0x0601355B RID: 79195 RVA: 0x004F07E8 File Offset: 0x004EE9E8
			// (set) Token: 0x0601355C RID: 79196 RVA: 0x004F07F8 File Offset: 0x004EE9F8
			public Button m_rechargePanelCloseButton
			{
				get
				{
					return this.m_owner.m_rechargePanelCloseButton;
				}
				set
				{
					this.m_owner.m_rechargePanelCloseButton = value;
				}
			}

			// Token: 0x17003A51 RID: 14929
			// (get) Token: 0x0601355D RID: 79197 RVA: 0x004F0808 File Offset: 0x004EEA08
			// (set) Token: 0x0601355E RID: 79198 RVA: 0x004F0818 File Offset: 0x004EEA18
			public CommonUIStateController m_rechargePanelUIStateController
			{
				get
				{
					return this.m_owner.m_rechargePanelUIStateController;
				}
				set
				{
					this.m_owner.m_rechargePanelUIStateController = value;
				}
			}

			// Token: 0x17003A52 RID: 14930
			// (get) Token: 0x0601355F RID: 79199 RVA: 0x004F0828 File Offset: 0x004EEA28
			// (set) Token: 0x06013560 RID: 79200 RVA: 0x004F0838 File Offset: 0x004EEA38
			public Button m_rechargeBuyButton
			{
				get
				{
					return this.m_owner.m_rechargeBuyButton;
				}
				set
				{
					this.m_owner.m_rechargeBuyButton = value;
				}
			}

			// Token: 0x17003A53 RID: 14931
			// (get) Token: 0x06013561 RID: 79201 RVA: 0x004F0848 File Offset: 0x004EEA48
			// (set) Token: 0x06013562 RID: 79202 RVA: 0x004F0858 File Offset: 0x004EEA58
			public Button m_closeButton
			{
				get
				{
					return this.m_owner.m_closeButton;
				}
				set
				{
					this.m_owner.m_closeButton = value;
				}
			}

			// Token: 0x17003A54 RID: 14932
			// (get) Token: 0x06013563 RID: 79203 RVA: 0x004F0868 File Offset: 0x004EEA68
			// (set) Token: 0x06013564 RID: 79204 RVA: 0x004F0878 File Offset: 0x004EEA78
			public CommonUIStateController m_storePrivilegeBuyDetailPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_storePrivilegeBuyDetailPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_storePrivilegeBuyDetailPanelStateCtrl = value;
				}
			}

			// Token: 0x17003A55 RID: 14933
			// (get) Token: 0x06013565 RID: 79205 RVA: 0x004F0888 File Offset: 0x004EEA88
			// (set) Token: 0x06013566 RID: 79206 RVA: 0x004F0898 File Offset: 0x004EEA98
			public Button m_storePrivilegeBuyDetailPanelBGButon
			{
				get
				{
					return this.m_owner.m_storePrivilegeBuyDetailPanelBGButon;
				}
				set
				{
					this.m_owner.m_storePrivilegeBuyDetailPanelBGButon = value;
				}
			}

			// Token: 0x17003A56 RID: 14934
			// (get) Token: 0x06013567 RID: 79207 RVA: 0x004F08A8 File Offset: 0x004EEAA8
			// (set) Token: 0x06013568 RID: 79208 RVA: 0x004F08B8 File Offset: 0x004EEAB8
			public CommonUIStateController m_storePrivilegeStateCtrl
			{
				get
				{
					return this.m_owner.m_storePrivilegeStateCtrl;
				}
				set
				{
					this.m_owner.m_storePrivilegeStateCtrl = value;
				}
			}

			// Token: 0x17003A57 RID: 14935
			// (get) Token: 0x06013569 RID: 79209 RVA: 0x004F08C8 File Offset: 0x004EEAC8
			// (set) Token: 0x0601356A RID: 79210 RVA: 0x004F08D8 File Offset: 0x004EEAD8
			public Text m_StorePrivilegeItemName
			{
				get
				{
					return this.m_owner.m_StorePrivilegeItemName;
				}
				set
				{
					this.m_owner.m_StorePrivilegeItemName = value;
				}
			}

			// Token: 0x17003A58 RID: 14936
			// (get) Token: 0x0601356B RID: 79211 RVA: 0x004F08E8 File Offset: 0x004EEAE8
			// (set) Token: 0x0601356C RID: 79212 RVA: 0x004F08F8 File Offset: 0x004EEAF8
			public Image m_StorePrivilegeItemIconImage
			{
				get
				{
					return this.m_owner.m_StorePrivilegeItemIconImage;
				}
				set
				{
					this.m_owner.m_StorePrivilegeItemIconImage = value;
				}
			}

			// Token: 0x17003A59 RID: 14937
			// (get) Token: 0x0601356D RID: 79213 RVA: 0x004F0908 File Offset: 0x004EEB08
			// (set) Token: 0x0601356E RID: 79214 RVA: 0x004F0918 File Offset: 0x004EEB18
			public Text m_storePrivilegeItemCountText
			{
				get
				{
					return this.m_owner.m_storePrivilegeItemCountText;
				}
				set
				{
					this.m_owner.m_storePrivilegeItemCountText = value;
				}
			}

			// Token: 0x17003A5A RID: 14938
			// (get) Token: 0x0601356F RID: 79215 RVA: 0x004F0928 File Offset: 0x004EEB28
			// (set) Token: 0x06013570 RID: 79216 RVA: 0x004F0938 File Offset: 0x004EEB38
			public Text m_storePrivilegeItemDescText
			{
				get
				{
					return this.m_owner.m_storePrivilegeItemDescText;
				}
				set
				{
					this.m_owner.m_storePrivilegeItemDescText = value;
				}
			}

			// Token: 0x17003A5B RID: 14939
			// (get) Token: 0x06013571 RID: 79217 RVA: 0x004F0948 File Offset: 0x004EEB48
			// (set) Token: 0x06013572 RID: 79218 RVA: 0x004F0958 File Offset: 0x004EEB58
			public GameObject m_storePrivilegeItemLeftDayGameObject
			{
				get
				{
					return this.m_owner.m_storePrivilegeItemLeftDayGameObject;
				}
				set
				{
					this.m_owner.m_storePrivilegeItemLeftDayGameObject = value;
				}
			}

			// Token: 0x17003A5C RID: 14940
			// (get) Token: 0x06013573 RID: 79219 RVA: 0x004F0968 File Offset: 0x004EEB68
			// (set) Token: 0x06013574 RID: 79220 RVA: 0x004F0978 File Offset: 0x004EEB78
			public Text m_storePrivilegeItemLeftDay
			{
				get
				{
					return this.m_owner.m_storePrivilegeItemLeftDay;
				}
				set
				{
					this.m_owner.m_storePrivilegeItemLeftDay = value;
				}
			}

			// Token: 0x17003A5D RID: 14941
			// (get) Token: 0x06013575 RID: 79221 RVA: 0x004F0988 File Offset: 0x004EEB88
			// (set) Token: 0x06013576 RID: 79222 RVA: 0x004F0998 File Offset: 0x004EEB98
			public Button m_storePrivilegeItemBuyButton
			{
				get
				{
					return this.m_owner.m_storePrivilegeItemBuyButton;
				}
				set
				{
					this.m_owner.m_storePrivilegeItemBuyButton = value;
				}
			}

			// Token: 0x17003A5E RID: 14942
			// (get) Token: 0x06013577 RID: 79223 RVA: 0x004F09A8 File Offset: 0x004EEBA8
			// (set) Token: 0x06013578 RID: 79224 RVA: 0x004F09B8 File Offset: 0x004EEBB8
			public Text m_storePrivilegeItemBuyPrice
			{
				get
				{
					return this.m_owner.m_storePrivilegeItemBuyPrice;
				}
				set
				{
					this.m_owner.m_storePrivilegeItemBuyPrice = value;
				}
			}

			// Token: 0x17003A5F RID: 14943
			// (get) Token: 0x06013579 RID: 79225 RVA: 0x004F09C8 File Offset: 0x004EEBC8
			// (set) Token: 0x0601357A RID: 79226 RVA: 0x004F09D8 File Offset: 0x004EEBD8
			public Text m_storeMonthExtraRewardCount
			{
				get
				{
					return this.m_owner.m_storeMonthExtraRewardCount;
				}
				set
				{
					this.m_owner.m_storeMonthExtraRewardCount = value;
				}
			}

			// Token: 0x17003A60 RID: 14944
			// (get) Token: 0x0601357B RID: 79227 RVA: 0x004F09E8 File Offset: 0x004EEBE8
			// (set) Token: 0x0601357C RID: 79228 RVA: 0x004F09F8 File Offset: 0x004EEBF8
			public Text m_subscribePrice
			{
				get
				{
					return this.m_owner.m_subscribePrice;
				}
				set
				{
					this.m_owner.m_subscribePrice = value;
				}
			}

			// Token: 0x17003A61 RID: 14945
			// (get) Token: 0x0601357D RID: 79229 RVA: 0x004F0A08 File Offset: 0x004EEC08
			// (set) Token: 0x0601357E RID: 79230 RVA: 0x004F0A18 File Offset: 0x004EEC18
			public Button m_subscribePanelPrivateButton
			{
				get
				{
					return this.m_owner.m_subscribePanelPrivateButton;
				}
				set
				{
					this.m_owner.m_subscribePanelPrivateButton = value;
				}
			}

			// Token: 0x17003A62 RID: 14946
			// (get) Token: 0x0601357F RID: 79231 RVA: 0x004F0A28 File Offset: 0x004EEC28
			// (set) Token: 0x06013580 RID: 79232 RVA: 0x004F0A38 File Offset: 0x004EEC38
			public Button m_subscribePanelCancelSubscribeButton
			{
				get
				{
					return this.m_owner.m_subscribePanelCancelSubscribeButton;
				}
				set
				{
					this.m_owner.m_subscribePanelCancelSubscribeButton = value;
				}
			}

			// Token: 0x17003A63 RID: 14947
			// (get) Token: 0x06013581 RID: 79233 RVA: 0x004F0A48 File Offset: 0x004EEC48
			// (set) Token: 0x06013582 RID: 79234 RVA: 0x004F0A58 File Offset: 0x004EEC58
			public Button m_memoryEntranceButton
			{
				get
				{
					return this.m_owner.m_memoryEntranceButton;
				}
				set
				{
					this.m_owner.m_memoryEntranceButton = value;
				}
			}

			// Token: 0x17003A64 RID: 14948
			// (get) Token: 0x06013583 RID: 79235 RVA: 0x004F0A68 File Offset: 0x004EEC68
			// (set) Token: 0x06013584 RID: 79236 RVA: 0x004F0A78 File Offset: 0x004EEC78
			public CommonUIStateController m_memoryEntranceButtonStateCtrl
			{
				get
				{
					return this.m_owner.m_memoryEntranceButtonStateCtrl;
				}
				set
				{
					this.m_owner.m_memoryEntranceButtonStateCtrl = value;
				}
			}

			// Token: 0x17003A65 RID: 14949
			// (get) Token: 0x06013585 RID: 79237 RVA: 0x004F0A88 File Offset: 0x004EEC88
			// (set) Token: 0x06013586 RID: 79238 RVA: 0x004F0A98 File Offset: 0x004EEC98
			public GameObject m_memoryEntranceButtonRedPoint
			{
				get
				{
					return this.m_owner.m_memoryEntranceButtonRedPoint;
				}
				set
				{
					this.m_owner.m_memoryEntranceButtonRedPoint = value;
				}
			}

			// Token: 0x17003A66 RID: 14950
			// (get) Token: 0x06013587 RID: 79239 RVA: 0x004F0AA8 File Offset: 0x004EECA8
			// (set) Token: 0x06013588 RID: 79240 RVA: 0x004F0AB8 File Offset: 0x004EECB8
			public CommonUIStateController m_memoryExtractionPanelStateCtrl
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelStateCtrl;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelStateCtrl = value;
				}
			}

			// Token: 0x17003A67 RID: 14951
			// (get) Token: 0x06013589 RID: 79241 RVA: 0x004F0AC8 File Offset: 0x004EECC8
			// (set) Token: 0x0601358A RID: 79242 RVA: 0x004F0AD8 File Offset: 0x004EECD8
			public ScrollRect m_memoryExtractionPanelScrollRect
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelScrollRect;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelScrollRect = value;
				}
			}

			// Token: 0x17003A68 RID: 14952
			// (get) Token: 0x0601358B RID: 79243 RVA: 0x004F0AE8 File Offset: 0x004EECE8
			// (set) Token: 0x0601358C RID: 79244 RVA: 0x004F0AF8 File Offset: 0x004EECF8
			public GameObject m_memoryExtractionPanelScrollContent
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelScrollContent;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelScrollContent = value;
				}
			}

			// Token: 0x17003A69 RID: 14953
			// (get) Token: 0x0601358D RID: 79245 RVA: 0x004F0B08 File Offset: 0x004EED08
			// (set) Token: 0x0601358E RID: 79246 RVA: 0x004F0B18 File Offset: 0x004EED18
			public Button m_memoryExtractionPanelHelpButton
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelHelpButton;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelHelpButton = value;
				}
			}

			// Token: 0x17003A6A RID: 14954
			// (get) Token: 0x0601358F RID: 79247 RVA: 0x004F0B28 File Offset: 0x004EED28
			// (set) Token: 0x06013590 RID: 79248 RVA: 0x004F0B38 File Offset: 0x004EED38
			public Button m_memoryExtractionPanelExtractionButton
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelExtractionButton;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelExtractionButton = value;
				}
			}

			// Token: 0x17003A6B RID: 14955
			// (get) Token: 0x06013591 RID: 79249 RVA: 0x004F0B48 File Offset: 0x004EED48
			// (set) Token: 0x06013592 RID: 79250 RVA: 0x004F0B58 File Offset: 0x004EED58
			public Text m_memoryExtractionPanelTotalValueText
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelTotalValueText;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelTotalValueText = value;
				}
			}

			// Token: 0x17003A6C RID: 14956
			// (get) Token: 0x06013593 RID: 79251 RVA: 0x004F0B68 File Offset: 0x004EED68
			// (set) Token: 0x06013594 RID: 79252 RVA: 0x004F0B78 File Offset: 0x004EED78
			public Button m_memoryExtractionPanelCloseButton
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelCloseButton;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelCloseButton = value;
				}
			}

			// Token: 0x17003A6D RID: 14957
			// (get) Token: 0x06013595 RID: 79253 RVA: 0x004F0B88 File Offset: 0x004EED88
			// (set) Token: 0x06013596 RID: 79254 RVA: 0x004F0B98 File Offset: 0x004EED98
			public Button m_memoryExtractionPanelBGReturnButton
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelBGReturnButton;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelBGReturnButton = value;
				}
			}

			// Token: 0x17003A6E RID: 14958
			// (get) Token: 0x06013597 RID: 79255 RVA: 0x004F0BA8 File Offset: 0x004EEDA8
			// (set) Token: 0x06013598 RID: 79256 RVA: 0x004F0BB8 File Offset: 0x004EEDB8
			public GameObject m_memoryExtractionPanelEmptyTip
			{
				get
				{
					return this.m_owner.m_memoryExtractionPanelEmptyTip;
				}
				set
				{
					this.m_owner.m_memoryExtractionPanelEmptyTip = value;
				}
			}

			// Token: 0x17003A6F RID: 14959
			// (get) Token: 0x06013599 RID: 79257 RVA: 0x004F0BC8 File Offset: 0x004EEDC8
			// (set) Token: 0x0601359A RID: 79258 RVA: 0x004F0BD8 File Offset: 0x004EEDD8
			public GameObject m_HeroFragmentItemPrefab
			{
				get
				{
					return this.m_owner.m_HeroFragmentItemPrefab;
				}
				set
				{
					this.m_owner.m_HeroFragmentItemPrefab = value;
				}
			}

			// Token: 0x17003A70 RID: 14960
			// (get) Token: 0x0601359B RID: 79259 RVA: 0x004F0BE8 File Offset: 0x004EEDE8
			// (set) Token: 0x0601359C RID: 79260 RVA: 0x004F0BF8 File Offset: 0x004EEDF8
			public bool m_needRefreshPanel
			{
				get
				{
					return this.m_owner.m_needRefreshPanel;
				}
				set
				{
					this.m_owner.m_needRefreshPanel = value;
				}
			}

			// Token: 0x17003A71 RID: 14961
			// (get) Token: 0x0601359D RID: 79261 RVA: 0x004F0C08 File Offset: 0x004EEE08
			// (set) Token: 0x0601359E RID: 79262 RVA: 0x004F0C18 File Offset: 0x004EEE18
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x17003A72 RID: 14962
			// (get) Token: 0x0601359F RID: 79263 RVA: 0x004F0C28 File Offset: 0x004EEE28
			// (set) Token: 0x060135A0 RID: 79264 RVA: 0x004F0C38 File Offset: 0x004EEE38
			public StoreType m_storeType
			{
				get
				{
					return this.m_owner.m_storeType;
				}
				set
				{
					this.m_owner.m_storeType = value;
				}
			}

			// Token: 0x17003A73 RID: 14963
			// (get) Token: 0x060135A1 RID: 79265 RVA: 0x004F0C48 File Offset: 0x004EEE48
			// (set) Token: 0x060135A2 RID: 79266 RVA: 0x004F0C58 File Offset: 0x004EEE58
			public StoreId m_storeId
			{
				get
				{
					return this.m_owner.m_storeId;
				}
				set
				{
					this.m_owner.m_storeId = value;
				}
			}

			// Token: 0x17003A74 RID: 14964
			// (get) Token: 0x060135A3 RID: 79267 RVA: 0x004F0C68 File Offset: 0x004EEE68
			// (set) Token: 0x060135A4 RID: 79268 RVA: 0x004F0C78 File Offset: 0x004EEE78
			public int m_fixedStoreItemGoodsID
			{
				get
				{
					return this.m_owner.m_fixedStoreItemGoodsID;
				}
				set
				{
					this.m_owner.m_fixedStoreItemGoodsID = value;
				}
			}

			// Token: 0x17003A75 RID: 14965
			// (get) Token: 0x060135A5 RID: 79269 RVA: 0x004F0C88 File Offset: 0x004EEE88
			// (set) Token: 0x060135A6 RID: 79270 RVA: 0x004F0C98 File Offset: 0x004EEE98
			public int m_goodsID
			{
				get
				{
					return this.m_owner.m_goodsID;
				}
				set
				{
					this.m_owner.m_goodsID = value;
				}
			}

			// Token: 0x17003A76 RID: 14966
			// (get) Token: 0x060135A7 RID: 79271 RVA: 0x004F0CA8 File Offset: 0x004EEEA8
			// (set) Token: 0x060135A8 RID: 79272 RVA: 0x004F0CB8 File Offset: 0x004EEEB8
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x17003A77 RID: 14967
			// (get) Token: 0x060135A9 RID: 79273 RVA: 0x004F0CC8 File Offset: 0x004EEEC8
			// (set) Token: 0x060135AA RID: 79274 RVA: 0x004F0CD8 File Offset: 0x004EEED8
			public StoreId m_fixedStoreID
			{
				get
				{
					return this.m_owner.m_fixedStoreID;
				}
				set
				{
					this.m_owner.m_fixedStoreID = value;
				}
			}

			// Token: 0x17003A78 RID: 14968
			// (get) Token: 0x060135AB RID: 79275 RVA: 0x004F0CE8 File Offset: 0x004EEEE8
			// (set) Token: 0x060135AC RID: 79276 RVA: 0x004F0CF8 File Offset: 0x004EEEF8
			public StoreId m_randomStoreID
			{
				get
				{
					return this.m_owner.m_randomStoreID;
				}
				set
				{
					this.m_owner.m_randomStoreID = value;
				}
			}

			// Token: 0x17003A79 RID: 14969
			// (get) Token: 0x060135AD RID: 79277 RVA: 0x004F0D08 File Offset: 0x004EEF08
			// (set) Token: 0x060135AE RID: 79278 RVA: 0x004F0D18 File Offset: 0x004EEF18
			public bool m_isStaticBox
			{
				get
				{
					return this.m_owner.m_isStaticBox;
				}
				set
				{
					this.m_owner.m_isStaticBox = value;
				}
			}

			// Token: 0x17003A7A RID: 14970
			// (get) Token: 0x060135AF RID: 79279 RVA: 0x004F0D28 File Offset: 0x004EEF28
			// (set) Token: 0x060135B0 RID: 79280 RVA: 0x004F0D38 File Offset: 0x004EEF38
			public Vector3 m_scrollViewStoreContentOriginalLocalPos
			{
				get
				{
					return this.m_owner.m_scrollViewStoreContentOriginalLocalPos;
				}
				set
				{
					this.m_owner.m_scrollViewStoreContentOriginalLocalPos = value;
				}
			}

			// Token: 0x17003A7B RID: 14971
			// (get) Token: 0x060135B1 RID: 79281 RVA: 0x004F0D48 File Offset: 0x004EEF48
			// (set) Token: 0x060135B2 RID: 79282 RVA: 0x004F0D58 File Offset: 0x004EEF58
			public Vector3 m_scrollViewHeroContentOriginalLocalPos
			{
				get
				{
					return this.m_owner.m_scrollViewHeroContentOriginalLocalPos;
				}
				set
				{
					this.m_owner.m_scrollViewHeroContentOriginalLocalPos = value;
				}
			}

			// Token: 0x17003A7C RID: 14972
			// (get) Token: 0x060135B3 RID: 79283 RVA: 0x004F0D68 File Offset: 0x004EEF68
			// (set) Token: 0x060135B4 RID: 79284 RVA: 0x004F0D78 File Offset: 0x004EEF78
			public GiftStoreItem m_giftStoreItem
			{
				get
				{
					return this.m_owner.m_giftStoreItem;
				}
				set
				{
					this.m_owner.m_giftStoreItem = value;
				}
			}

			// Token: 0x17003A7D RID: 14973
			// (get) Token: 0x060135B5 RID: 79285 RVA: 0x004F0D88 File Offset: 0x004EEF88
			// (set) Token: 0x060135B6 RID: 79286 RVA: 0x004F0D98 File Offset: 0x004EEF98
			public GameObjectPool<StoreItemUIController> m_storeUnderItemPool
			{
				get
				{
					return this.m_owner.m_storeUnderItemPool;
				}
				set
				{
					this.m_owner.m_storeUnderItemPool = value;
				}
			}

			// Token: 0x17003A7E RID: 14974
			// (get) Token: 0x060135B7 RID: 79287 RVA: 0x004F0DA8 File Offset: 0x004EEFA8
			// (set) Token: 0x060135B8 RID: 79288 RVA: 0x004F0DB8 File Offset: 0x004EEFB8
			public GameObjectPool<StoreHeroSkinItemUIController> m_storeHeroSkinItemPool
			{
				get
				{
					return this.m_owner.m_storeHeroSkinItemPool;
				}
				set
				{
					this.m_owner.m_storeHeroSkinItemPool = value;
				}
			}

			// Token: 0x17003A7F RID: 14975
			// (get) Token: 0x060135B9 RID: 79289 RVA: 0x004F0DC8 File Offset: 0x004EEFC8
			// (set) Token: 0x060135BA RID: 79290 RVA: 0x004F0DD8 File Offset: 0x004EEFD8
			public GameObjectPool<StoreSoldierSkinItemUIController> m_storeSoldierSkinItemPool
			{
				get
				{
					return this.m_owner.m_storeSoldierSkinItemPool;
				}
				set
				{
					this.m_owner.m_storeSoldierSkinItemPool = value;
				}
			}

			// Token: 0x17003A80 RID: 14976
			// (get) Token: 0x060135BB RID: 79291 RVA: 0x004F0DE8 File Offset: 0x004EEFE8
			// (set) Token: 0x060135BC RID: 79292 RVA: 0x004F0DF8 File Offset: 0x004EEFF8
			public List<Goods> m_gainGoodsList
			{
				get
				{
					return this.m_owner.m_gainGoodsList;
				}
				set
				{
					this.m_owner.m_gainGoodsList = value;
				}
			}

			// Token: 0x17003A81 RID: 14977
			// (get) Token: 0x060135BD RID: 79293 RVA: 0x004F0E08 File Offset: 0x004EF008
			// (set) Token: 0x060135BE RID: 79294 RVA: 0x004F0E18 File Offset: 0x004EF018
			public Dictionary<StoreId, List<Toggle>> m_storeSubType2ToggleDic
			{
				get
				{
					return this.m_owner.m_storeSubType2ToggleDic;
				}
				set
				{
					this.m_owner.m_storeSubType2ToggleDic = value;
				}
			}

			// Token: 0x17003A82 RID: 14978
			// (get) Token: 0x060135BF RID: 79295 RVA: 0x004F0E28 File Offset: 0x004EF028
			// (set) Token: 0x060135C0 RID: 79296 RVA: 0x004F0E38 File Offset: 0x004EF038
			public StoreSelfChooseUIController m_storeSelfChooseUIController
			{
				get
				{
					return this.m_owner.m_storeSelfChooseUIController;
				}
				set
				{
					this.m_owner.m_storeSelfChooseUIController = value;
				}
			}

			// Token: 0x17003A83 RID: 14979
			// (get) Token: 0x060135C1 RID: 79297 RVA: 0x004F0E48 File Offset: 0x004EF048
			// (set) Token: 0x060135C2 RID: 79298 RVA: 0x004F0E58 File Offset: 0x004EF058
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

			// Token: 0x17003A84 RID: 14980
			// (get) Token: 0x060135C3 RID: 79299 RVA: 0x004F0E68 File Offset: 0x004EF068
			// (set) Token: 0x060135C4 RID: 79300 RVA: 0x004F0E78 File Offset: 0x004EF078
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

			// Token: 0x060135C5 RID: 79301 RVA: 0x004F0E88 File Offset: 0x004EF088
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060135C6 RID: 79302 RVA: 0x004F0E98 File Offset: 0x004EF098
			public StoreType GetStoreTypeByStoreId(StoreId storeId)
			{
				return this.m_owner.GetStoreTypeByStoreId(storeId);
			}

			// Token: 0x060135C7 RID: 79303 RVA: 0x004F0EA8 File Offset: 0x004EF0A8
			public void UpdateRechargeStore()
			{
				this.m_owner.UpdateRechargeStore();
			}

			// Token: 0x060135C8 RID: 79304 RVA: 0x004F0EB8 File Offset: 0x004EF0B8
			public void UpdateGiftStore(StoreId storeId)
			{
				this.m_owner.UpdateGiftStore(storeId);
			}

			// Token: 0x060135C9 RID: 79305 RVA: 0x004F0EC8 File Offset: 0x004EF0C8
			public void UpdateFixedStore(StoreId storeId)
			{
				this.m_owner.UpdateFixedStore(storeId);
			}

			// Token: 0x060135CA RID: 79306 RVA: 0x004F0ED8 File Offset: 0x004EF0D8
			public void UpdateRandomStore()
			{
				this.m_owner.UpdateRandomStore();
			}

			// Token: 0x060135CB RID: 79307 RVA: 0x004F0EE8 File Offset: 0x004EF0E8
			public void ClearPool()
			{
				this.m_owner.ClearPool();
			}

			// Token: 0x060135CC RID: 79308 RVA: 0x004F0EF8 File Offset: 0x004EF0F8
			public void UpdateFixedStoreInfo(StoreId storeID)
			{
				this.m_owner.UpdateFixedStoreInfo(storeID);
			}

			// Token: 0x060135CD RID: 79309 RVA: 0x004F0F08 File Offset: 0x004EF108
			public void UpdateHeroSkinInfo(StoreId storeID, GameObjectPool<StoreHeroSkinItemUIController> pool)
			{
				this.m_owner.UpdateHeroSkinInfo(storeID, pool);
			}

			// Token: 0x060135CE RID: 79310 RVA: 0x004F0F18 File Offset: 0x004EF118
			public void UpdateSoldierSkinInfo(StoreId storeID, GameObjectPool<StoreSoldierSkinItemUIController> pool)
			{
				this.m_owner.UpdateSoldierSkinInfo(storeID, pool);
			}

			// Token: 0x060135CF RID: 79311 RVA: 0x004F0F28 File Offset: 0x004EF128
			public void UpdateRandomStoreInfo(StoreId storeId)
			{
				this.m_owner.UpdateRandomStoreInfo(storeId);
			}

			// Token: 0x060135D0 RID: 79312 RVA: 0x004F0F38 File Offset: 0x004EF138
			public void UpdateRechargeStoreInfo()
			{
				this.m_owner.UpdateRechargeStoreInfo();
			}

			// Token: 0x060135D1 RID: 79313 RVA: 0x004F0F48 File Offset: 0x004EF148
			public void SetDefaultState(bool hideRefreshPanel)
			{
				this.m_owner.SetDefaultState(hideRefreshPanel);
			}

			// Token: 0x060135D2 RID: 79314 RVA: 0x004F0F58 File Offset: 0x004EF158
			public void SetFixedStoreInfo(StoreId fixedStoreID, GameObjectPool<StoreItemUIController> pool)
			{
				this.m_owner.SetFixedStoreInfo(fixedStoreID, pool);
			}

			// Token: 0x060135D3 RID: 79315 RVA: 0x004F0F68 File Offset: 0x004EF168
			public int SortFixedStoreItemByUISort(FixedStoreItem a, FixedStoreItem b)
			{
				return this.m_owner.SortFixedStoreItemByUISort(a, b);
			}

			// Token: 0x060135D4 RID: 79316 RVA: 0x004F0F78 File Offset: 0x004EF178
			public void RefreshCurrencyDisplay(List<StoreItemUIController> currencyTypeList)
			{
				this.m_owner.RefreshCurrencyDisplay(currencyTypeList);
			}

			// Token: 0x060135D5 RID: 79317 RVA: 0x004F0F88 File Offset: 0x004EF188
			public void SetRandomStoreInfo(StoreId storeId, GameObjectPool<StoreItemUIController> pool)
			{
				this.m_owner.SetRandomStoreInfo(storeId, pool);
			}

			// Token: 0x060135D6 RID: 79318 RVA: 0x004F0F98 File Offset: 0x004EF198
			public void SetRechargeStoreInfo(GameObjectPool<StoreItemUIController> pool)
			{
				this.m_owner.SetRechargeStoreInfo(pool);
			}

			// Token: 0x060135D7 RID: 79319 RVA: 0x004F0FA8 File Offset: 0x004EF1A8
			public void ShowRefreshPanel()
			{
				this.m_owner.ShowRefreshPanel();
			}

			// Token: 0x060135D8 RID: 79320 RVA: 0x004F0FB8 File Offset: 0x004EF1B8
			public void HideRefreshPanel()
			{
				this.m_owner.HideRefreshPanel();
			}

			// Token: 0x060135D9 RID: 79321 RVA: 0x004F0FC8 File Offset: 0x004EF1C8
			public void SetRefreshPanel(StoreId randomStoreID)
			{
				this.m_owner.SetRefreshPanel(randomStoreID);
			}

			// Token: 0x060135DA RID: 79322 RVA: 0x004F0FD8 File Offset: 0x004EF1D8
			public void OnStoreItemClick(StoreItemUIController goCtrl)
			{
				this.m_owner.OnStoreItemClick(goCtrl);
			}

			// Token: 0x060135DB RID: 79323 RVA: 0x004F0FE8 File Offset: 0x004EF1E8
			public void OnHeroSkinItemClick(StoreHeroSkinItemUIController itemCtrl)
			{
				this.m_owner.OnHeroSkinItemClick(itemCtrl);
			}

			// Token: 0x060135DC RID: 79324 RVA: 0x004F0FF8 File Offset: 0x004EF1F8
			public void OnSkinItemOutOfDate()
			{
				this.m_owner.OnSkinItemOutOfDate();
			}

			// Token: 0x060135DD RID: 79325 RVA: 0x004F1008 File Offset: 0x004EF208
			public void OnSoldierSkinItemClick(StoreSoldierSkinItemUIController itemCtrl)
			{
				this.m_owner.OnSoldierSkinItemClick(itemCtrl);
			}

			// Token: 0x060135DE RID: 79326 RVA: 0x004F1018 File Offset: 0x004EF218
			public void SetStoreBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetStoreBuyPanel(goCtrl);
			}

			// Token: 0x060135DF RID: 79327 RVA: 0x004F1028 File Offset: 0x004EF228
			public void SetNormalItemBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetNormalItemBuyPanel(goCtrl);
			}

			// Token: 0x060135E0 RID: 79328 RVA: 0x004F1038 File Offset: 0x004EF238
			public void SetRechargeBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetRechargeBuyPanel(goCtrl);
			}

			// Token: 0x060135E1 RID: 79329 RVA: 0x004F1048 File Offset: 0x004EF248
			public void SetBoxBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetBoxBuyPanel(goCtrl);
			}

			// Token: 0x060135E2 RID: 79330 RVA: 0x004F1058 File Offset: 0x004EF258
			public void SetItemBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetItemBuyPanel(goCtrl);
			}

			// Token: 0x060135E3 RID: 79331 RVA: 0x004F1068 File Offset: 0x004EF268
			public void SetEnchantStoneResonanceInfoPanel(GoodsType goodsType, int goodsID)
			{
				this.m_owner.SetEnchantStoneResonanceInfoPanel(goodsType, goodsID);
			}

			// Token: 0x060135E4 RID: 79332 RVA: 0x004F1078 File Offset: 0x004EF278
			public void UpdateGiftStoreInfo(StoreId storeID, GameObjectPool<StoreItemUIController> pool)
			{
				this.m_owner.UpdateGiftStoreInfo(storeID, pool);
			}

			// Token: 0x060135E5 RID: 79333 RVA: 0x004F1088 File Offset: 0x004EF288
			public void SetGiftStoreInfo(StoreId storeId, GameObjectPool<StoreItemUIController> pool)
			{
				this.m_owner.SetGiftStoreInfo(storeId, pool);
			}

			// Token: 0x060135E6 RID: 79334 RVA: 0x004F1098 File Offset: 0x004EF298
			public void SetGiftStoreBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetGiftStoreBuyPanel(goCtrl);
			}

			// Token: 0x060135E7 RID: 79335 RVA: 0x004F10A8 File Offset: 0x004EF2A8
			public void SetGiftStoreStaticBoxBuyPanel(StoreItemUIController ctrl, ConfigDataItemInfo itemInfo)
			{
				this.m_owner.SetGiftStoreStaticBoxBuyPanel(ctrl, itemInfo);
			}

			// Token: 0x060135E8 RID: 79336 RVA: 0x004F10B8 File Offset: 0x004EF2B8
			public void SetMothCardBuyPanel(StoreItemUIController goCtrl)
			{
				this.m_owner.SetMothCardBuyPanel(goCtrl);
			}

			// Token: 0x060135E9 RID: 79337 RVA: 0x004F10C8 File Offset: 0x004EF2C8
			public void OnPresentPresentToggleValueChanged(bool isOn)
			{
				this.m_owner.OnPresentPresentToggleValueChanged(isOn);
			}

			// Token: 0x060135EA RID: 79338 RVA: 0x004F10D8 File Offset: 0x004EF2D8
			public void OnPresentPreogativeToggleValueChanged(bool isOn)
			{
				this.m_owner.OnPresentPreogativeToggleValueChanged(isOn);
			}

			// Token: 0x060135EB RID: 79339 RVA: 0x004F10E8 File Offset: 0x004EF2E8
			public void OnMonthCardBuyButtonClick()
			{
				this.m_owner.OnMonthCardBuyButtonClick();
			}

			// Token: 0x060135EC RID: 79340 RVA: 0x004F10F8 File Offset: 0x004EF2F8
			public void OnSubscribePrivateClick()
			{
				this.m_owner.OnSubscribePrivateClick();
			}

			// Token: 0x060135ED RID: 79341 RVA: 0x004F1108 File Offset: 0x004EF308
			public void OnCancelSubscribeClick()
			{
				this.m_owner.OnCancelSubscribeClick();
			}

			// Token: 0x060135EE RID: 79342 RVA: 0x004F1118 File Offset: 0x004EF318
			public void OnMonthCardPanelBGButtonClick()
			{
				this.m_owner.OnMonthCardPanelBGButtonClick();
			}

			// Token: 0x060135EF RID: 79343 RVA: 0x004F1128 File Offset: 0x004EF328
			public void OnPresentToggleValueChanged(bool isOn)
			{
				this.m_owner.OnPresentToggleValueChanged(isOn);
			}

			// Token: 0x060135F0 RID: 79344 RVA: 0x004F1138 File Offset: 0x004EF338
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x060135F1 RID: 79345 RVA: 0x004F1148 File Offset: 0x004EF348
			public void OnRefreshButtonClick()
			{
				this.m_owner.OnRefreshButtonClick();
			}

			// Token: 0x060135F2 RID: 79346 RVA: 0x004F1158 File Offset: 0x004EF358
			public void OnItemBuyPanelBGButtonClick()
			{
				this.m_owner.OnItemBuyPanelBGButtonClick();
			}

			// Token: 0x060135F3 RID: 79347 RVA: 0x004F1168 File Offset: 0x004EF368
			public void OnItemBuyButtonClick()
			{
				this.m_owner.OnItemBuyButtonClick();
			}

			// Token: 0x060135F4 RID: 79348 RVA: 0x004F1178 File Offset: 0x004EF378
			public void OnBoxBuyPanelBGButtonClick()
			{
				this.m_owner.OnBoxBuyPanelBGButtonClick();
			}

			// Token: 0x060135F5 RID: 79349 RVA: 0x004F1188 File Offset: 0x004EF388
			public void OnRechargePanelBGButtonClick()
			{
				this.m_owner.OnRechargePanelBGButtonClick();
			}

			// Token: 0x060135F6 RID: 79350 RVA: 0x004F1198 File Offset: 0x004EF398
			public void OnBoxBuyButtonClick()
			{
				this.m_owner.OnBoxBuyButtonClick();
			}

			// Token: 0x060135F7 RID: 79351 RVA: 0x004F11A8 File Offset: 0x004EF3A8
			public bool IsStoreItemIOSSubscribeItem(StoreItemUIController ctrl)
			{
				return this.m_owner.IsStoreItemIOSSubscribeItem(ctrl);
			}

			// Token: 0x060135F8 RID: 79352 RVA: 0x004F11B8 File Offset: 0x004EF3B8
			public int SortFragmentItemComparer(HeroFragmentBagItem f1, HeroFragmentBagItem f2)
			{
				return this.m_owner.SortFragmentItemComparer(f1, f2);
			}

			// Token: 0x060135F9 RID: 79353 RVA: 0x004F11C8 File Offset: 0x004EF3C8
			public void OnMemoryExtractionPanelExtractionButtonClick()
			{
				this.m_owner.OnMemoryExtractionPanelExtractionButtonClick();
			}

			// Token: 0x060135FA RID: 79354 RVA: 0x004F11D8 File Offset: 0x004EF3D8
			public void OnMemeryExtractionHelpButtonClick()
			{
				this.m_owner.OnMemeryExtractionHelpButtonClick();
			}

			// Token: 0x060135FB RID: 79355 RVA: 0x004F11E8 File Offset: 0x004EF3E8
			public void CloseMemoryExtractionPanel()
			{
				this.m_owner.CloseMemoryExtractionPanel();
			}

			// Token: 0x060135FC RID: 79356 RVA: 0x004F11F8 File Offset: 0x004EF3F8
			public void FireChangeStoreEvent(StoreId storeId)
			{
				this.m_owner.FireChangeStoreEvent(storeId);
			}

			// Token: 0x060135FD RID: 79357 RVA: 0x004F1208 File Offset: 0x004EF408
			public void OnRechargeBuyButtonClick()
			{
				this.m_owner.OnRechargeBuyButtonClick();
			}

			// Token: 0x060135FE RID: 79358 RVA: 0x004F1218 File Offset: 0x004EF418
			public void OnRechargeToggleValueChanged(bool isOn)
			{
				this.m_owner.OnRechargeToggleValueChanged(isOn);
			}

			// Token: 0x060135FF RID: 79359 RVA: 0x004F1228 File Offset: 0x004EF428
			public void OnCystalToggleValueChanged(bool isOn)
			{
				this.m_owner.OnCystalToggleValueChanged(isOn);
			}

			// Token: 0x06013600 RID: 79360 RVA: 0x004F1238 File Offset: 0x004EF438
			public void OnSkinToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSkinToggleValueChanged(isOn);
			}

			// Token: 0x06013601 RID: 79361 RVA: 0x004F1248 File Offset: 0x004EF448
			public void OnSkinTab_HeroToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSkinTab_HeroToggleValueChanged(isOn);
			}

			// Token: 0x06013602 RID: 79362 RVA: 0x004F1258 File Offset: 0x004EF458
			public void OnSkinTab_SoldierToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSkinTab_SoldierToggleValueChanged(isOn);
			}

			// Token: 0x06013603 RID: 79363 RVA: 0x004F1268 File Offset: 0x004EF468
			public void OnMysteriousToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousToggleValueChanged(isOn);
			}

			// Token: 0x06013604 RID: 79364 RVA: 0x004F1278 File Offset: 0x004EF478
			public void OnMysteriousBlackMarketToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousBlackMarketToggleValueChanged(isOn);
			}

			// Token: 0x06013605 RID: 79365 RVA: 0x004F1288 File Offset: 0x004EF488
			public void OnMysteriousMemoryToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousMemoryToggleValueChanged(isOn);
			}

			// Token: 0x06013606 RID: 79366 RVA: 0x004F1298 File Offset: 0x004EF498
			public void OnMysteriousEquipmentToggleValueChange(bool isOn)
			{
				this.m_owner.OnMysteriousEquipmentToggleValueChange(isOn);
			}

			// Token: 0x06013607 RID: 79367 RVA: 0x004F12A8 File Offset: 0x004EF4A8
			public void OnMysteriousHonorToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousHonorToggleValueChanged(isOn);
			}

			// Token: 0x06013608 RID: 79368 RVA: 0x004F12B8 File Offset: 0x004EF4B8
			public void OnMysteriousMedalToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousMedalToggleValueChanged(isOn);
			}

			// Token: 0x06013609 RID: 79369 RVA: 0x004F12C8 File Offset: 0x004EF4C8
			public void OnMysteriousFriendshipToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousFriendshipToggleValueChanged(isOn);
			}

			// Token: 0x0601360A RID: 79370 RVA: 0x004F12D8 File Offset: 0x004EF4D8
			public void OnMysteriousUnionToggleValueChanged(bool isOn)
			{
				this.m_owner.OnMysteriousUnionToggleValueChanged(isOn);
			}

			// Token: 0x0601360B RID: 79371 RVA: 0x004F12E8 File Offset: 0x004EF4E8
			public void InitStoreSubType2Toggle()
			{
				this.m_owner.InitStoreSubType2Toggle();
			}

			// Token: 0x0601360C RID: 79372 RVA: 0x004F12F8 File Offset: 0x004EF4F8
			public void SaveOriginalScrollViewLocalPosition()
			{
				this.m_owner.SaveOriginalScrollViewLocalPosition();
			}

			// Token: 0x0601360D RID: 79373 RVA: 0x004F1308 File Offset: 0x004EF508
			public bool UpdateToggles(StoreId storeId)
			{
				return this.m_owner.UpdateToggles(storeId);
			}

			// Token: 0x0601360E RID: 79374 RVA: 0x004F1318 File Offset: 0x004EF518
			public int FixedStoreSkinListSortFunc(FixedStoreItem itemA, FixedStoreItem itemB)
			{
				return this.m_owner.FixedStoreSkinListSortFunc(itemA, itemB);
			}

			// Token: 0x0400AC43 RID: 44099
			private StoreListUIController m_owner;
		}
	}
}
