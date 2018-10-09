using System;
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
	// Token: 0x02000F1F RID: 3871
	[HotFix]
	public class StoreItemUIController : UIControllerBase
	{
		// Token: 0x06013303 RID: 78595 RVA: 0x004E3884 File Offset: 0x004E1A84
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
			this.m_storeItemButton.onClick.AddListener(new UnityAction(this.OnStoreItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06013304 RID: 78596 RVA: 0x004E3914 File Offset: 0x004E1B14
		private void OnStoreItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStoreItemClick_hotfix != null)
			{
				this.m_OnStoreItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_goodsType == GoodsType.GoodsType_MonthCard && UIUtility.IsIosSubscribe(this.m_giftStoreItem.Config.IsAppleSubscribe);
			if (flag && this.m_playerContext.GetMonthCardLeftTime(this.m_goodsID).Ticks > 0L)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_StillInSubscribeTime, 2f, null, true);
				return;
			}
			if (!this.m_disableBuyObj.activeSelf && this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x06013305 RID: 78597 RVA: 0x004E3A00 File Offset: 0x004E1C00
		public void SetFixedStoreItemInfo(FixedStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFixedStoreItemInfoFixedStoreItem_hotfix != null)
			{
				this.m_SetFixedStoreItemInfoFixedStoreItem_hotfix.call(new object[]
				{
					this,
					item
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemUIStateController.SetToUIState("Normal", false, true);
			this.SetItemDefaultState();
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(item.Id);
			if (configDataFixedStoreItemInfo != null)
			{
				this.m_goodsType = configDataFixedStoreItemInfo.ItemType;
				this.m_storeType = StoreType.StoreType_Static;
				this.m_countString = configDataFixedStoreItemInfo.Nums.ToString();
				this.m_itemNameText.text = configDataFixedStoreItemInfo.Name;
				this.m_fixedStoreItemGoodsID = configDataFixedStoreItemInfo.ID;
				this.m_haveFirstBuyReward = this.HaveFirstBuyReward(configDataFixedStoreItemInfo);
				this.m_goodsID = 0;
				bool flag = this.m_goodsType == GoodsType.GoodsType_Item || this.m_goodsType == GoodsType.GoodsType_JobMaterial || this.m_goodsType == GoodsType.GoodsType_Equipment || this.m_goodsType == GoodsType.GoodsType_EnchantStone || this.m_goodsType == GoodsType.GoodsType_Hero;
				if (flag)
				{
					this.m_goodsID = configDataFixedStoreItemInfo.ItemId;
				}
				this.SetLabel(configDataFixedStoreItemInfo);
				this.SetPrice(item);
				this.SetLimit(item, configDataFixedStoreItemInfo);
				this.SetRemoveTime(Convert.ToDateTime(configDataFixedStoreItemInfo.ShowEndTime));
				this.SetSellOut(item);
				this.UpdateIcon(this.m_goodsType, this.m_goodsID, configDataFixedStoreItemInfo.Nums);
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x06013306 RID: 78598 RVA: 0x004E3BA0 File Offset: 0x004E1DA0
		public void SetRandomStoreItemInfo(RandomStoreItem item, int itemIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRandomStoreItemInfoRandomStoreItemInt32_hotfix != null)
			{
				this.m_SetRandomStoreItemInfoRandomStoreItemInt32_hotfix.call(new object[]
				{
					this,
					item,
					itemIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemUIStateController.SetToUIState("Normal", false, true);
			this.SetItemDefaultState();
			ConfigDataRandomStoreItemInfo configDataRandomStoreItemInfo = this.m_configDataLoader.GetConfigDataRandomStoreItemInfo(item.Id);
			if (configDataRandomStoreItemInfo != null)
			{
				this.m_index = itemIndex;
				this.m_goodsType = configDataRandomStoreItemInfo.ItemType;
				this.m_storeType = StoreType.StoreType_Random;
				this.m_countString = configDataRandomStoreItemInfo.Count.ToString();
				this.m_itemNameText.text = configDataRandomStoreItemInfo.Name;
				this.m_goodsID = 0;
				bool flag = this.m_goodsType == GoodsType.GoodsType_Item || this.m_goodsType == GoodsType.GoodsType_JobMaterial || this.m_goodsType == GoodsType.GoodsType_Equipment || this.m_goodsType == GoodsType.GoodsType_EnchantStone || this.m_goodsType == GoodsType.GoodsType_Hero;
				if (flag)
				{
					this.m_goodsID = configDataRandomStoreItemInfo.ItemID;
				}
				this.SetLabel();
				this.SetPrice(configDataRandomStoreItemInfo);
				this.SetLimit();
				this.SetSellOut(item);
				this.UpdateIcon(this.m_goodsType, this.m_goodsID, configDataRandomStoreItemInfo.Count);
				this.SetRandomStoreItemNotShow();
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x06013307 RID: 78599 RVA: 0x004E3D30 File Offset: 0x004E1F30
		public void SetRechargeStoreItemInfo(int goodsId, StoreType storeType, bool isGoodsBought, double goodsPrice, string goodsName, int cystalRewardNums, string icon)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRechargeStoreItemInfoInt32StoreTypeBooleanDoubleStringInt32String_hotfix != null)
			{
				this.m_SetRechargeStoreItemInfoInt32StoreTypeBooleanDoubleStringInt32String_hotfix.call(new object[]
				{
					this,
					goodsId,
					storeType,
					isGoodsBought,
					goodsPrice,
					goodsName,
					cystalRewardNums,
					icon
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemUIStateController.SetToUIState("Money", false, true);
			this.SetItemDefaultState();
			this.m_storeType = storeType;
			this.m_goodsID = goodsId;
			this.m_itemNameText.text = goodsName;
			this.m_goodsType = GoodsType.GoodsType_None;
			this.SetLabel_RMB_Recharge(isGoodsBought);
			this.SetPrice_RMB(goodsPrice);
			this.SetLimit_RMB(isGoodsBought, cystalRewardNums);
			this.SetSellOut();
			this.UpdateIcon_RMB(icon);
			base.gameObject.SetActive(true);
		}

		// Token: 0x06013308 RID: 78600 RVA: 0x004E3E6C File Offset: 0x004E206C
		public void SetGiftStoreItemInfo(GiftStoreItem item, double price, PDSDKGoodType goodPDSDKType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGiftStoreItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix != null)
			{
				this.m_SetGiftStoreItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix.call(new object[]
				{
					this,
					item,
					price,
					goodPDSDKType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemUIStateController.SetToUIState("Money", false, true);
			this.SetItemDefaultState();
			ConfigDataGiftStoreItemInfo config = item.Config;
			if (config != null)
			{
				this.m_goodsType = config.ItemType;
				this.m_giftStoreItem = item;
				this.m_goodsID = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(item.GoodsId).ItemId;
				this.m_storeType = StoreType.StoreType_Gift;
				this.m_countString = config.Nums.ToString();
				this.m_itemNameText.text = config.Name;
				this.m_goodPDSDKType = goodPDSDKType;
				this.SetLabel();
				this.SetLimit(item, config);
				this.SetSellOut(item);
				this.SetRemoveTime(Convert.ToDateTime(config.ShowEndTime));
				this.SetPrice_RMB(price);
				this.UpdateIcon(this.m_goodsType, this.m_goodsID, config.Nums);
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x06013309 RID: 78601 RVA: 0x004E3FDC File Offset: 0x004E21DC
		public void SetGiftStoreMothCardItemInfo(GiftStoreItem item, double price, PDSDKGoodType goodPDSDKType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGiftStoreMothCardItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix != null)
			{
				this.m_SetGiftStoreMothCardItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix.call(new object[]
				{
					this,
					item,
					price,
					goodPDSDKType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemUIStateController.SetToUIState("Money", false, true);
			this.SetItemDefaultState();
			ConfigDataGiftStoreItemInfo config = item.Config;
			if (config != null)
			{
				this.m_goodsType = config.ItemType;
				this.m_giftStoreItem = item;
				this.m_goodsID = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(item.GoodsId).ItemId;
				this.m_storeType = StoreType.StoreType_Gift;
				this.m_countString = config.Nums.ToString();
				this.m_itemNameText.text = config.Name;
				this.m_goodPDSDKType = goodPDSDKType;
				this.SetLabel();
				this.SetLimit();
				this.SetSellOut();
				this.SetPrice_RMB(price);
				this.UpdateIcon(this.m_goodsType, this.m_goodsID, config.Nums);
				this.SetLeftDays(UIUtility.TimeSpanToString2(this.m_playerContext.GetMonthCardLeftTime(this.m_goodsID)));
				base.gameObject.SetActive(true);
			}
		}

		// Token: 0x0601330A RID: 78602 RVA: 0x004E4154 File Offset: 0x004E2354
		private void SetLabel(ConfigDataFixedStoreItemInfo itemInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLabelConfigDataFixedStoreItemInfo_hotfix != null)
			{
				this.m_SetLabelConfigDataFixedStoreItemInfo_hotfix.call(new object[]
				{
					this,
					itemInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LabelType lable = itemInfo.Lable;
			this.m_limitTimeLabelObj.SetActive(lable == LabelType.LabelType_FixedTime);
			this.m_commendLabelObj.SetActive(lable == LabelType.LabelType_Recommand);
			this.m_discountLabelObj.SetActive(lable == LabelType.LabelType_Discount);
			this.m_firstDiscountLabelObj.SetActive(lable == LabelType.LabelType_FirstDiscount);
			this.m_firstLabelObj.SetActive(false);
			this.m_labelObj.SetActive(true);
		}

		// Token: 0x0601330B RID: 78603 RVA: 0x004E4220 File Offset: 0x004E2420
		private void SetLabel_RMB_Recharge(bool isGoodsBought)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLabel_RMB_RechargeBoolean_hotfix != null)
			{
				this.m_SetLabel_RMB_RechargeBoolean_hotfix.call(new object[]
				{
					this,
					isGoodsBought
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isGoodsBought)
			{
				this.m_labelObj.SetActive(false);
			}
			else
			{
				this.m_labelObj.SetActive(true);
				this.m_limitTimeLabelObj.SetActive(false);
				this.m_commendLabelObj.SetActive(false);
				this.m_discountLabelObj.SetActive(false);
				this.m_firstDiscountLabelObj.SetActive(false);
				this.m_firstLabelObj.SetActive(true);
			}
		}

		// Token: 0x0601330C RID: 78604 RVA: 0x004E42F0 File Offset: 0x004E24F0
		private void SetLabel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLabel_hotfix != null)
			{
				this.m_SetLabel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_labelObj.SetActive(false);
		}

		// Token: 0x0601330D RID: 78605 RVA: 0x004E435C File Offset: 0x004E255C
		private void SetPrice(FixedStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPriceFixedStoreItem_hotfix != null)
			{
				this.m_SetPriceFixedStoreItem_hotfix.call(new object[]
				{
					this,
					item
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(item.Id);
			if (item.IsFirstBuy)
			{
				this.m_priceText.text = configDataFixedStoreItemInfo.FirstPrice.ToString();
			}
			else if (this.m_playerContext.IsOnDiscount(configDataFixedStoreItemInfo))
			{
				this.m_priceText.text = configDataFixedStoreItemInfo.DiscountPrice.ToString();
			}
			else
			{
				this.m_priceText.text = configDataFixedStoreItemInfo.NormalPrice.ToString();
			}
			this.m_pricePanelStateCtrl.SetToUIState("OtherItem", false, true);
			GoodsType currencyType = configDataFixedStoreItemInfo.CurrencyType;
			switch (currencyType)
			{
			case GoodsType.GoodsType_MemoryEssence:
				this.m_extraCurrencyType = GoodsType.GoodsType_MemoryEssence;
				this.m_extraCurrencyTypeIconString = "UI/Icon/Item_ABS/Item_MemoryEssence.png";
				this.m_extraCurrencyCount = this.m_playerContext.GetMemoryEssence();
				this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_MemoryEssence.png");
				break;
			case GoodsType.GoodsType_MithralStone:
				this.m_extraCurrencyType = GoodsType.GoodsType_MithralStone;
				this.m_extraCurrencyTypeIconString = "UI/Icon/Item_ABS/Icon_DragonScale_01.png";
				this.m_extraCurrencyCount = this.m_playerContext.GetMithralStone();
				this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Icon_DragonScale_01.png");
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				this.m_extraCurrencyType = GoodsType.GoodsType_BrillianceMithralStone;
				this.m_extraCurrencyTypeIconString = "UI/Icon/Item_ABS/Icon_DragonScale_02.png";
				this.m_extraCurrencyCount = this.m_playerContext.GetBrillianceMithralStone();
				this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Icon_DragonScale_02.png");
				break;
			case GoodsType.GoodsType_GuildMedal:
				this.m_extraCurrencyType = GoodsType.GoodsType_GuildMedal;
				this.m_extraCurrencyTypeIconString = "UI/Common_New_ABS/Icon/Icon_GuildCoin.png";
				this.m_extraCurrencyCount = this.m_playerContext.GetGuildMedal();
				this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_GuildCoin.png");
				break;
			default:
				if (currencyType != GoodsType.GoodsType_Gold)
				{
					if (currencyType != GoodsType.GoodsType_Crystal)
					{
						switch (currencyType)
						{
						case GoodsType.GoodsType_ArenaHonour:
							this.m_extraCurrencyType = GoodsType.GoodsType_ArenaHonour;
							this.m_extraCurrencyTypeIconString = "UI/Icon/Item_ABS/Item_PvpCoin.png";
							this.m_extraCurrencyCount = this.m_playerContext.GetArenaHonour();
							this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_PvpCoin.png");
							break;
						case GoodsType.GoodsType_FriendshipPoints:
							this.m_extraCurrencyType = GoodsType.GoodsType_FriendshipPoints;
							this.m_extraCurrencyTypeIconString = "UI/Common_New_ABS/Icon/Icon_Friendship_1.png";
							this.m_extraCurrencyCount = this.m_playerContext.GetFriendShipPoints();
							this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Common_New_ABS/Icon/Icon_Friendship_1.png");
							break;
						}
					}
					else
					{
						this.m_extraCurrencyType = GoodsType.GoodsType_None;
						this.m_pricePanelStateCtrl.SetToUIState("Crystal", false, true);
					}
				}
				else
				{
					this.m_extraCurrencyType = GoodsType.GoodsType_None;
					this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_Gold.png");
				}
				break;
			}
			this.m_currentGoodCurrencyType = currencyType;
		}

		// Token: 0x0601330E RID: 78606 RVA: 0x004E46A4 File Offset: 0x004E28A4
		private void SetPrice(ConfigDataRandomStoreItemInfo itemInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPriceConfigDataRandomStoreItemInfo_hotfix != null)
			{
				this.m_SetPriceConfigDataRandomStoreItemInfo_hotfix.call(new object[]
				{
					this,
					itemInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_priceText.text = itemInfo.Price.ToString();
			GoodsType currencyType = itemInfo.CurrencyType;
			this.m_pricePanelStateCtrl.SetToUIState("OtherItem", false, true);
			if (currencyType != GoodsType.GoodsType_Gold)
			{
				if (currencyType != GoodsType.GoodsType_Crystal)
				{
					if (currencyType == GoodsType.GoodsType_ArenaHonour)
					{
						this.m_extraCurrencyType = GoodsType.GoodsType_ArenaHonour;
						this.m_extraCurrencyTypeIconString = "UI/Icon/Item_ABS/Item_PvpCoin.png";
						this.m_extraCurrencyCount = this.m_playerContext.GetArenaHonour();
						this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_PvpCoin.png");
					}
				}
				else
				{
					this.m_extraCurrencyType = GoodsType.GoodsType_None;
					this.m_pricePanelStateCtrl.SetToUIState("Crystal", false, true);
				}
			}
			else
			{
				this.m_extraCurrencyType = GoodsType.GoodsType_None;
				this.m_priceIconImage.sprite = AssetUtility.Instance.GetSprite("UI/Icon/Item_ABS/Item_Gold.png");
			}
			this.m_currentGoodCurrencyType = currencyType;
		}

		// Token: 0x0601330F RID: 78607 RVA: 0x004E47F8 File Offset: 0x004E29F8
		private void SetPrice_RMB(double goodPrice)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPrice_RMBDouble_hotfix != null)
			{
				this.m_SetPrice_RMBDouble_hotfix.call(new object[]
				{
					this,
					goodPrice
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_priceText.text = goodPrice.ToString();
			this.m_extraCurrencyType = GoodsType.GoodsType_None;
			this.m_pricePanelStateCtrl.SetToUIState("RMB", false, true);
		}

		// Token: 0x06013310 RID: 78608 RVA: 0x004E489C File Offset: 0x004E2A9C
		private void SetLimit(FixedStoreItem item, ConfigDataFixedStoreItemInfo fixedStoreItemInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitFixedStoreItemConfigDataFixedStoreItemInfo_hotfix != null)
			{
				this.m_SetLimitFixedStoreItemConfigDataFixedStoreItemInfo_hotfix.call(new object[]
				{
					this,
					item,
					fixedStoreItemInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_extraPresentGameObj.SetActive(false);
			if (fixedStoreItemInfo.Count == 0)
			{
				this.m_limitObj.SetActive(false);
			}
			else
			{
				if (item.IsFirstBuy && fixedStoreItemInfo.FirstReward != null && fixedStoreItemInfo.FirstReward.Count > 0)
				{
					string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Once);
					this.m_limitText.text = text;
				}
				else
				{
					switch (fixedStoreItemInfo.BuyLimitType)
					{
					case BuyRuleType.BuyRuleType_FixedTime:
					{
						string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Fixed);
						this.m_limitText.text = string.Format(format, fixedStoreItemInfo.Param, fixedStoreItemInfo.Count, item.BoughtCount);
						break;
					}
					case BuyRuleType.BuyRuleType_WeekTime:
					{
						string format2 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Week);
						this.m_limitText.text = string.Format(format2, fixedStoreItemInfo.Count, item.BoughtCount);
						break;
					}
					case BuyRuleType.BuyRuleType_MonthTime:
					{
						string format3 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Month);
						this.m_limitText.text = string.Format(format3, fixedStoreItemInfo.Count, item.BoughtCount, fixedStoreItemInfo.Count);
						break;
					}
					case BuyRuleType.BuyRuleType_Forever:
					{
						string format4 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Forever);
						this.m_limitText.text = string.Format(format4, fixedStoreItemInfo.Count, item.BoughtCount);
						break;
					}
					}
				}
				this.m_limitObj.SetActive(true);
			}
		}

		// Token: 0x06013311 RID: 78609 RVA: 0x004E4ACC File Offset: 0x004E2CCC
		private void SetLimit(GiftStoreItem item, ConfigDataGiftStoreItemInfo giftStoreItemInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitGiftStoreItemConfigDataGiftStoreItemInfo_hotfix != null)
			{
				this.m_SetLimitGiftStoreItemConfigDataGiftStoreItemInfo_hotfix.call(new object[]
				{
					this,
					item,
					giftStoreItemInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_extraPresentGameObj.SetActive(false);
			if (giftStoreItemInfo.Count == 0)
			{
				this.m_limitObj.SetActive(false);
			}
			else
			{
				if (item.IsFirstBuy && giftStoreItemInfo.FirstReward != null && giftStoreItemInfo.FirstReward.Count > 0)
				{
					string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Once);
					this.m_limitText.text = text;
				}
				else
				{
					switch (giftStoreItemInfo.BuyLimitType)
					{
					case BuyRuleType.BuyRuleType_FixedTime:
					{
						string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Fixed);
						this.m_limitText.text = string.Format(format, giftStoreItemInfo.Param, giftStoreItemInfo.Count, item.BoughtNums);
						break;
					}
					case BuyRuleType.BuyRuleType_WeekTime:
					{
						string format2 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Week);
						this.m_limitText.text = string.Format(format2, giftStoreItemInfo.Count, item.BoughtNums);
						break;
					}
					case BuyRuleType.BuyRuleType_MonthTime:
					{
						string format3 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Month);
						this.m_limitText.text = string.Format(format3, giftStoreItemInfo.Count, item.BoughtNums, giftStoreItemInfo.Count);
						break;
					}
					case BuyRuleType.BuyRuleType_Forever:
					{
						string format4 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_Limit_Forever);
						this.m_limitText.text = string.Format(format4, giftStoreItemInfo.Count, item.BoughtNums);
						break;
					}
					}
				}
				this.m_limitObj.SetActive(true);
			}
		}

		// Token: 0x06013312 RID: 78610 RVA: 0x004E4CFC File Offset: 0x004E2EFC
		private bool HaveFirstBuyReward(ConfigDataFixedStoreItemInfo fixedStoreItemInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HaveFirstBuyRewardConfigDataFixedStoreItemInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HaveFirstBuyRewardConfigDataFixedStoreItemInfo_hotfix.call(new object[]
				{
					this,
					fixedStoreItemInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return fixedStoreItemInfo.FirstReward != null && fixedStoreItemInfo.FirstReward.Count > 0;
		}

		// Token: 0x06013313 RID: 78611 RVA: 0x004E4D94 File Offset: 0x004E2F94
		private void SetLimit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimit_hotfix != null)
			{
				this.m_SetLimit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_limitObj.SetActive(false);
			this.m_extraPresentGameObj.SetActive(false);
		}

		// Token: 0x06013314 RID: 78612 RVA: 0x004E4E0C File Offset: 0x004E300C
		private void SetLimit_RMB(bool isGoodsBought, int crystalNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimit_RMBBooleanInt32_hotfix != null)
			{
				this.m_SetLimit_RMBBooleanInt32_hotfix.call(new object[]
				{
					this,
					isGoodsBought,
					crystalNums
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (crystalNums <= 0)
			{
				this.m_limitObj.SetActive(false);
				this.m_presentedPanelObj.SetActive(false);
				this.m_extraPresentGameObj.SetActive(false);
				return;
			}
			if (!isGoodsBought)
			{
				string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_FirstBuyPresent);
				this.m_presentedText.text = string.Format(format, crystalNums);
				this.m_presentedPanelObj.SetActive(true);
				this.m_limitObj.SetActive(false);
				this.m_extraPresentGameObj.SetActive(false);
			}
			else
			{
				string format2 = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ExtraBuyPresent);
				this.m_extraPresentText.text = string.Format(format2, crystalNums);
				this.m_limitObj.SetActive(false);
				this.m_extraPresentGameObj.SetActive(true);
				this.m_presentedPanelObj.SetActive(false);
			}
		}

		// Token: 0x06013315 RID: 78613 RVA: 0x004E4F5C File Offset: 0x004E315C
		private void SetSellOut(FixedStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSellOutFixedStoreItem_hotfix != null)
			{
				this.m_SetSellOutFixedStoreItem_hotfix.call(new object[]
				{
					this,
					item
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(item.Id);
			if (configDataFixedStoreItemInfo.Count != 0 && item.BoughtCount >= configDataFixedStoreItemInfo.Count)
			{
				this.m_disableBuyOnlyObj.SetActive(false);
				this.m_disableBuyRefreshObj.SetActive(true);
				this.m_disableBuyObj.SetActive(true);
				if (configDataFixedStoreItemInfo.BuyLimitType != BuyRuleType.BuyRuleType_Forever)
				{
					DateTime d = new DateTime(item.NextFlushTime);
					TimeSpan t = d - this.m_playerContext.GetServerTime();
					string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_RefreshTime);
					if (configDataFixedStoreItemInfo.ShowEndTime != string.Empty)
					{
						TimeSpan t2 = Convert.ToDateTime(configDataFixedStoreItemInfo.ShowEndTime) - this.m_playerContext.GetServerTime();
						if (t >= t2)
						{
							this.m_disableBuyOnlyObj.SetActive(true);
							this.m_disableBuyRefreshObj.SetActive(false);
						}
						else
						{
							this.m_refreshOrRemoveTimeText.text = string.Format(format, t.Days + 1);
						}
					}
					else
					{
						this.m_refreshOrRemoveTimeText.text = string.Format(format, t.Days + 1);
					}
				}
				else
				{
					this.m_disableBuyOnlyObj.SetActive(true);
					this.m_disableBuyRefreshObj.SetActive(false);
				}
			}
			else
			{
				this.m_disableBuyObj.SetActive(false);
			}
		}

		// Token: 0x06013316 RID: 78614 RVA: 0x004E5128 File Offset: 0x004E3328
		private void SetSellOut(RandomStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSellOutRandomStoreItem_hotfix != null)
			{
				this.m_SetSellOutRandomStoreItem_hotfix.call(new object[]
				{
					this,
					item
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (item.Bought)
			{
				this.m_disableBuyObj.SetActive(true);
				this.m_disableBuyRefreshObj.SetActive(false);
				this.m_disableBuyOnlyObj.SetActive(true);
			}
			else
			{
				this.m_disableBuyObj.SetActive(false);
				this.m_disableBuyRefreshObj.SetActive(false);
				this.m_disableBuyOnlyObj.SetActive(false);
			}
		}

		// Token: 0x06013317 RID: 78615 RVA: 0x004E51F0 File Offset: 0x004E33F0
		private void SetSellOut(GiftStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSellOutGiftStoreItem_hotfix != null)
			{
				this.m_SetSellOutGiftStoreItem_hotfix.call(new object[]
				{
					this,
					item
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGiftStoreItemInfo config = item.Config;
			if (config.Count != 0 && item.BoughtNums == config.Count)
			{
				this.m_disableBuyOnlyObj.SetActive(false);
				this.m_disableBuyRefreshObj.SetActive(true);
				this.m_disableBuyObj.SetActive(true);
				if (config.BuyLimitType != BuyRuleType.BuyRuleType_Forever)
				{
					TimeSpan t = item.NextFlushTime - this.m_playerContext.GetServerTime();
					string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_RefreshTime);
					if (config.ShowEndTime != string.Empty)
					{
						TimeSpan t2 = Convert.ToDateTime(config.ShowEndTime) - this.m_playerContext.GetServerTime();
						if (t >= t2)
						{
							this.m_disableBuyOnlyObj.SetActive(true);
							this.m_disableBuyRefreshObj.SetActive(false);
						}
						else
						{
							this.m_refreshOrRemoveTimeText.text = string.Format(format, t.Days + 1);
						}
					}
					else
					{
						this.m_refreshOrRemoveTimeText.text = string.Format(format, t.Days + 1);
					}
				}
				else
				{
					this.m_disableBuyOnlyObj.SetActive(true);
					this.m_disableBuyRefreshObj.SetActive(false);
				}
			}
			else
			{
				this.m_disableBuyObj.SetActive(false);
			}
		}

		// Token: 0x06013318 RID: 78616 RVA: 0x004E53A8 File Offset: 0x004E35A8
		private void SetSellOut()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSellOut_hotfix != null)
			{
				this.m_SetSellOut_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_disableBuyObj.SetActive(false);
			this.m_disableBuyRefreshObj.SetActive(false);
			this.m_disableBuyOnlyObj.SetActive(false);
		}

		// Token: 0x06013319 RID: 78617 RVA: 0x004E542C File Offset: 0x004E362C
		private void SetRemoveTime(DateTime showEndTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRemoveTimeDateTime_hotfix != null)
			{
				this.m_SetRemoveTimeDateTime_hotfix.call(new object[]
				{
					this,
					showEndTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (showEndTime.ToString() != DateTime.MaxValue.ToString())
			{
				TimeSpan timeSpan = showEndTime - this.m_playerContext.GetServerTime();
				string text = UIUtility.TimeSpanToString2(timeSpan);
				this.m_LeftDayText.text = text;
				this.m_LeftDayGameobj.SetActive(true);
			}
			else
			{
				this.m_LeftDayGameobj.SetActive(false);
			}
		}

		// Token: 0x0601331A RID: 78618 RVA: 0x004E5508 File Offset: 0x004E3708
		private void UpdateIcon(GoodsType goodType, int itemId, int num)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateIconGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_UpdateIconGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodType,
					itemId,
					num
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (goodType)
			{
			case GoodsType.GoodsType_Gold:
			case GoodsType.GoodsType_Crystal:
				break;
			default:
				if (goodType != GoodsType.GoodsType_ArenaHonour)
				{
					this.SetGeneralGoodInfo(num);
					return;
				}
				break;
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(itemId);
				if (configDataItemInfo != null)
				{
					if (configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
					{
						this.SetNoFrameInfo(this.m_goodsType, configDataItemInfo.ID);
					}
					else
					{
						this.SetGeneralGoodInfo(num);
					}
				}
				else
				{
					base.gameObject.SetActive(false);
					global::Debug.LogError("Don't exist this item!");
				}
				return;
			}
			}
			this.SetGeneralGoodInfo(1);
		}

		// Token: 0x0601331B RID: 78619 RVA: 0x004E563C File Offset: 0x004E383C
		private void UpdateIcon_RMB(string icon)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateIcon_RMBString_hotfix != null)
			{
				this.m_UpdateIcon_RMBString_hotfix.call(new object[]
				{
					this,
					icon
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rechargeItemIconImage.sprite = AssetUtility.Instance.GetSprite(icon);
			this.m_generalGoodObj.SetActive(false);
			this.m_spineAnimObj.SetActive(false);
			this.m_noFrameItemObj.SetActive(false);
			this.m_rechargeItemObj.SetActive(true);
		}

		// Token: 0x0601331C RID: 78620 RVA: 0x004E56F4 File Offset: 0x004E38F4
		private void SetNoFrameInfo(GoodsType goodType, int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNoFrameInfoGoodsTypeInt32_hotfix != null)
			{
				this.m_SetNoFrameInfoGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodType,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_noFrameItemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goodType, goodsId));
			this.m_noFrameItemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goodType, goodsId));
			this.m_generalGoodObj.SetActive(false);
			this.m_spineAnimObj.SetActive(false);
			this.m_noFrameItemObj.SetActive(true);
			this.m_rechargeItemObj.SetActive(false);
		}

		// Token: 0x0601331D RID: 78621 RVA: 0x004E57DC File Offset: 0x004E39DC
		private void SetGeneralGoodInfo(int count = 1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGeneralGoodInfoInt32_hotfix != null)
			{
				this.m_SetGeneralGoodInfoInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_generalGoodCountText.text = count.ToString();
			this.m_generalGoodCountText.gameObject.SetActive(count > 1);
			this.m_generalGoodIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsID));
			this.m_generalGoodIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.m_goodsType, this.m_goodsID));
			this.m_generalGoodFrameImage.sprite = AssetUtility.Instance.GetSprite(this.GetFrameNameAndSetSSR());
			this.m_ssrEffectImage.gameObject.SetActive(this.m_isSSR);
			this.m_generalGoodObj.SetActive(true);
			this.m_spineAnimObj.SetActive(false);
			this.m_noFrameItemObj.SetActive(false);
			this.m_rechargeItemObj.SetActive(false);
		}

		// Token: 0x0601331E RID: 78622 RVA: 0x004E5928 File Offset: 0x004E3B28
		private string GetFrameNameAndSetSSR()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFrameNameAndSetSSR_hotfix != null)
			{
				return (string)this.m_GetFrameNameAndSetSSR_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSSR = false;
			switch (this.m_goodsType)
			{
			case GoodsType.GoodsType_Gold:
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_GoldRank);
			case GoodsType.GoodsType_Crystal:
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_CrystalRank);
			case GoodsType.GoodsType_Hero:
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(this.m_goodsID);
				if (configDataHeroInfo != null)
				{
					return UIUtility.GetGoodsFrameNameByRank(configDataHeroInfo.GetRank(configDataHeroInfo.Star));
				}
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = this.m_configDataLoader.GetConfigDataJobMaterialInfo(this.m_goodsID);
				if (configDataJobMaterialInfo != null)
				{
					this.m_isSSR = UIUtility.IsRankSSR(configDataJobMaterialInfo.Rank);
					return UIUtility.GetGoodsFrameNameByRank(configDataJobMaterialInfo.Rank);
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(this.m_goodsID);
				if (configDataItemInfo != null)
				{
					this.m_isSSR = UIUtility.IsRankSSR(configDataItemInfo.Rank);
					return UIUtility.GetGoodsFrameNameByRank(configDataItemInfo.Rank);
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(this.m_goodsID);
				if (configDataEquipmentInfo != null)
				{
					this.m_isSSR = UIUtility.IsRankSSR(configDataEquipmentInfo.Rank);
					return UIUtility.GetGoodsFrameNameByRank(configDataEquipmentInfo.Rank);
				}
				break;
			}
			case GoodsType.GoodsType_ArenaTicket:
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_ArenaTicketRank);
			case GoodsType.GoodsType_ArenaHonour:
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_ArenaHonourRank);
			case GoodsType.GoodsType_PlayerExp:
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_PlayerExpRank);
			case GoodsType.GoodsType_FriendshipPoints:
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_FriendshipPointsRank);
			case GoodsType.GoodsType_EnchantStone:
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(this.m_goodsID);
				if (configDataEnchantStoneInfo != null)
				{
					this.m_isSSR = UIUtility.IsRankSSR(configDataEnchantStoneInfo.Rank);
					return UIUtility.GetGoodsFrameNameByRank(configDataEnchantStoneInfo.Rank);
				}
				break;
			}
			case GoodsType.GoodsType_MonthCard:
				this.m_isSSR = UIUtility.IsRankSSR(this.m_clientConfigDataLoader.ConfigableConstId_PrivilegeItemRank);
				return UIUtility.GetGoodsFrameNameByRank(this.m_clientConfigDataLoader.ConfigableConstId_PrivilegeItemRank);
			}
			return "UI/Common_New_ABS/Border_Icon_Copper.png";
		}

		// Token: 0x0601331F RID: 78623 RVA: 0x004E5B98 File Offset: 0x004E3D98
		private void SetRandomStoreItemNotShow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRandomStoreItemNotShow_hotfix != null)
			{
				this.m_SetRandomStoreItemNotShow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_limitObj.SetActive(false);
			this.m_extraPresentGameObj.SetActive(false);
			this.m_presentedPanelObj.SetActive(false);
			this.m_labelObj.SetActive(false);
		}

		// Token: 0x06013320 RID: 78624 RVA: 0x004E5C28 File Offset: 0x004E3E28
		private void SetLeftDays(string remainTime = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLeftDaysString_hotfix != null)
			{
				this.m_SetLeftDaysString_hotfix.call(new object[]
				{
					this,
					remainTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(remainTime))
			{
				this.m_LeftDayGameobj.SetActive(false);
			}
			else
			{
				this.m_LeftDayGameobj.SetActive(true);
				this.m_LeftDayText.text = remainTime;
			}
		}

		// Token: 0x06013321 RID: 78625 RVA: 0x004E5CCC File Offset: 0x004E3ECC
		private void SetItemDefaultState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetItemDefaultState_hotfix != null)
			{
				this.m_SetItemDefaultState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_presentedPanelObj.SetActive(false);
			this.m_LeftDayGameobj.SetActive(false);
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x06013322 RID: 78626 RVA: 0x004E5D44 File Offset: 0x004E3F44
		// (set) Token: 0x06013323 RID: 78627 RVA: 0x004E5DB8 File Offset: 0x004E3FB8
		public string Count
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Count_hotfix != null)
				{
					return (string)this.m_get_Count_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_countString;
			}
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CountString_hotfix != null)
				{
					this.m_set_CountString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x06013324 RID: 78628 RVA: 0x004E5E28 File Offset: 0x004E4028
		// (set) Token: 0x06013325 RID: 78629 RVA: 0x004E5EE4 File Offset: 0x004E40E4
		public Image PriceIcon
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PriceIcon_hotfix != null)
				{
					return (Image)this.m_get_PriceIcon_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				string stateName = this.m_pricePanelStateCtrl.GetCurrentUIState().StateName;
				if (stateName != null)
				{
					if (stateName == "Crystal")
					{
						return this.m_priceCrystalImage;
					}
					if (stateName == "RMB")
					{
						return this.m_priceRMBImage;
					}
				}
				return this.m_priceIconImage;
			}
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PriceIconImage_hotfix != null)
				{
					this.m_set_PriceIconImage_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x06013326 RID: 78630 RVA: 0x004E5F54 File Offset: 0x004E4154
		// (set) Token: 0x06013327 RID: 78631 RVA: 0x004E5FC8 File Offset: 0x004E41C8
		public Text PriceText
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PriceText_hotfix != null)
				{
					return (Text)this.m_get_PriceText_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_priceText;
			}
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PriceTextText_hotfix != null)
				{
					this.m_set_PriceTextText_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x06013328 RID: 78632 RVA: 0x004E6038 File Offset: 0x004E4238
		// (set) Token: 0x06013329 RID: 78633 RVA: 0x004E60AC File Offset: 0x004E42AC
		public Text ItemNameText
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ItemNameText_hotfix != null)
				{
					return (Text)this.m_get_ItemNameText_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_itemNameText;
			}
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ItemNameTextText_hotfix != null)
				{
					this.m_set_ItemNameTextText_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0601332A RID: 78634 RVA: 0x004E611C File Offset: 0x004E431C
		// (set) Token: 0x0601332B RID: 78635 RVA: 0x004E6190 File Offset: 0x004E4390
		public Text LimitText
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LimitText_hotfix != null)
				{
					return (Text)this.m_get_LimitText_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_limitText;
			}
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_LimitTextText_hotfix != null)
				{
					this.m_set_LimitTextText_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0601332C RID: 78636 RVA: 0x004E6200 File Offset: 0x004E4400
		public PDSDKGoodType GoodPDSDKType
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GoodPDSDKType_hotfix != null)
				{
					return (PDSDKGoodType)this.m_get_GoodPDSDKType_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_goodPDSDKType;
			}
		}

		// Token: 0x1400042D RID: 1069
		// (add) Token: 0x0601332D RID: 78637 RVA: 0x004E6274 File Offset: 0x004E4474
		// (remove) Token: 0x0601332E RID: 78638 RVA: 0x004E6310 File Offset: 0x004E4510
		public event Action<StoreItemUIController> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreItemUIController> action = this.EventOnClick;
				Action<StoreItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreItemUIController>>(ref this.EventOnClick, (Action<StoreItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<StoreItemUIController> action = this.EventOnClick;
				Action<StoreItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<StoreItemUIController>>(ref this.EventOnClick, (Action<StoreItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0601332F RID: 78639 RVA: 0x004E63AC File Offset: 0x004E45AC
		// (set) Token: 0x06013330 RID: 78640 RVA: 0x004E63CC File Offset: 0x004E45CC
		[DoNotToLua]
		public new StoreItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013331 RID: 78641 RVA: 0x004E63D8 File Offset: 0x004E45D8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013332 RID: 78642 RVA: 0x004E63E4 File Offset: 0x004E45E4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013333 RID: 78643 RVA: 0x004E63EC File Offset: 0x004E45EC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013334 RID: 78644 RVA: 0x004E63F4 File Offset: 0x004E45F4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013335 RID: 78645 RVA: 0x004E6408 File Offset: 0x004E4608
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013336 RID: 78646 RVA: 0x004E6410 File Offset: 0x004E4610
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013337 RID: 78647 RVA: 0x004E641C File Offset: 0x004E461C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013338 RID: 78648 RVA: 0x004E6428 File Offset: 0x004E4628
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013339 RID: 78649 RVA: 0x004E6434 File Offset: 0x004E4634
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601333A RID: 78650 RVA: 0x004E6440 File Offset: 0x004E4640
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601333B RID: 78651 RVA: 0x004E644C File Offset: 0x004E464C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601333C RID: 78652 RVA: 0x004E6458 File Offset: 0x004E4658
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601333D RID: 78653 RVA: 0x004E6464 File Offset: 0x004E4664
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601333E RID: 78654 RVA: 0x004E6470 File Offset: 0x004E4670
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601333F RID: 78655 RVA: 0x004E647C File Offset: 0x004E467C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013340 RID: 78656 RVA: 0x004E6484 File Offset: 0x004E4684
		private void __callDele_EventOnClick(StoreItemUIController obj)
		{
			Action<StoreItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x06013341 RID: 78657 RVA: 0x004E64A8 File Offset: 0x004E46A8
		private void __clearDele_EventOnClick(StoreItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x06013342 RID: 78658 RVA: 0x004E64B4 File Offset: 0x004E46B4
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
					this.m_OnStoreItemClick_hotfix = (luaObj.RawGet("OnStoreItemClick") as LuaFunction);
					this.m_SetFixedStoreItemInfoFixedStoreItem_hotfix = (luaObj.RawGet("SetFixedStoreItemInfo") as LuaFunction);
					this.m_SetRandomStoreItemInfoRandomStoreItemInt32_hotfix = (luaObj.RawGet("SetRandomStoreItemInfo") as LuaFunction);
					this.m_SetRechargeStoreItemInfoInt32StoreTypeBooleanDoubleStringInt32String_hotfix = (luaObj.RawGet("SetRechargeStoreItemInfo") as LuaFunction);
					this.m_SetGiftStoreItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix = (luaObj.RawGet("SetGiftStoreItemInfo") as LuaFunction);
					this.m_SetGiftStoreMothCardItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix = (luaObj.RawGet("SetGiftStoreMothCardItemInfo") as LuaFunction);
					this.m_SetLabelConfigDataFixedStoreItemInfo_hotfix = (luaObj.RawGet("SetLabel") as LuaFunction);
					this.m_SetLabel_RMB_RechargeBoolean_hotfix = (luaObj.RawGet("SetLabel_RMB_Recharge") as LuaFunction);
					this.m_SetLabel_hotfix = (luaObj.RawGet("SetLabel") as LuaFunction);
					this.m_SetPriceFixedStoreItem_hotfix = (luaObj.RawGet("SetPrice") as LuaFunction);
					this.m_SetPriceConfigDataRandomStoreItemInfo_hotfix = (luaObj.RawGet("SetPrice") as LuaFunction);
					this.m_SetPrice_RMBDouble_hotfix = (luaObj.RawGet("SetPrice_RMB") as LuaFunction);
					this.m_SetLimitFixedStoreItemConfigDataFixedStoreItemInfo_hotfix = (luaObj.RawGet("SetLimit") as LuaFunction);
					this.m_SetLimitGiftStoreItemConfigDataGiftStoreItemInfo_hotfix = (luaObj.RawGet("SetLimit") as LuaFunction);
					this.m_HaveFirstBuyRewardConfigDataFixedStoreItemInfo_hotfix = (luaObj.RawGet("HaveFirstBuyReward") as LuaFunction);
					this.m_SetLimit_hotfix = (luaObj.RawGet("SetLimit") as LuaFunction);
					this.m_SetLimit_RMBBooleanInt32_hotfix = (luaObj.RawGet("SetLimit_RMB") as LuaFunction);
					this.m_SetSellOutFixedStoreItem_hotfix = (luaObj.RawGet("SetSellOut") as LuaFunction);
					this.m_SetSellOutRandomStoreItem_hotfix = (luaObj.RawGet("SetSellOut") as LuaFunction);
					this.m_SetSellOutGiftStoreItem_hotfix = (luaObj.RawGet("SetSellOut") as LuaFunction);
					this.m_SetSellOut_hotfix = (luaObj.RawGet("SetSellOut") as LuaFunction);
					this.m_SetRemoveTimeDateTime_hotfix = (luaObj.RawGet("SetRemoveTime") as LuaFunction);
					this.m_UpdateIconGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("UpdateIcon") as LuaFunction);
					this.m_UpdateIcon_RMBString_hotfix = (luaObj.RawGet("UpdateIcon_RMB") as LuaFunction);
					this.m_SetNoFrameInfoGoodsTypeInt32_hotfix = (luaObj.RawGet("SetNoFrameInfo") as LuaFunction);
					this.m_SetGeneralGoodInfoInt32_hotfix = (luaObj.RawGet("SetGeneralGoodInfo") as LuaFunction);
					this.m_GetFrameNameAndSetSSR_hotfix = (luaObj.RawGet("GetFrameNameAndSetSSR") as LuaFunction);
					this.m_SetRandomStoreItemNotShow_hotfix = (luaObj.RawGet("SetRandomStoreItemNotShow") as LuaFunction);
					this.m_SetLeftDaysString_hotfix = (luaObj.RawGet("SetLeftDays") as LuaFunction);
					this.m_SetItemDefaultState_hotfix = (luaObj.RawGet("SetItemDefaultState") as LuaFunction);
					this.m_get_Count_hotfix = (luaObj.RawGet("get_Count") as LuaFunction);
					this.m_set_CountString_hotfix = (luaObj.RawGet("set_Count") as LuaFunction);
					this.m_get_PriceIcon_hotfix = (luaObj.RawGet("get_PriceIcon") as LuaFunction);
					this.m_set_PriceIconImage_hotfix = (luaObj.RawGet("set_PriceIcon") as LuaFunction);
					this.m_get_PriceText_hotfix = (luaObj.RawGet("get_PriceText") as LuaFunction);
					this.m_set_PriceTextText_hotfix = (luaObj.RawGet("set_PriceText") as LuaFunction);
					this.m_get_ItemNameText_hotfix = (luaObj.RawGet("get_ItemNameText") as LuaFunction);
					this.m_set_ItemNameTextText_hotfix = (luaObj.RawGet("set_ItemNameText") as LuaFunction);
					this.m_get_LimitText_hotfix = (luaObj.RawGet("get_LimitText") as LuaFunction);
					this.m_set_LimitTextText_hotfix = (luaObj.RawGet("set_LimitText") as LuaFunction);
					this.m_get_GoodPDSDKType_hotfix = (luaObj.RawGet("get_GoodPDSDKType") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013343 RID: 78659 RVA: 0x004E69B4 File Offset: 0x004E4BB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AAC5 RID: 43717
		private PDSDKGoodType m_goodPDSDKType;

		// Token: 0x0400AAC7 RID: 43719
		private const string PriceState_OtherItem = "OtherItem";

		// Token: 0x0400AAC8 RID: 43720
		private const string PriceState_Crystal = "Crystal";

		// Token: 0x0400AAC9 RID: 43721
		private const string PriceState_RMBIcon = "RMB";

		// Token: 0x0400AACA RID: 43722
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_storeItemButton;

		// Token: 0x0400AACB RID: 43723
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_itemUIStateController;

		// Token: 0x0400AACC RID: 43724
		[AutoBind("./Item/GeneralGoods", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_generalGoodObj;

		// Token: 0x0400AACD RID: 43725
		[AutoBind("./Item/GeneralGoods/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_generalGoodIconImage;

		// Token: 0x0400AACE RID: 43726
		[AutoBind("./Item/GeneralGoods/FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_generalGoodFrameImage;

		// Token: 0x0400AACF RID: 43727
		[AutoBind("./Item/GeneralGoods/SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_ssrEffectImage;

		// Token: 0x0400AAD0 RID: 43728
		[AutoBind("./Item/GeneralGoods/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_generalGoodCountText;

		// Token: 0x0400AAD1 RID: 43729
		[AutoBind("./Item/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_spineAnimObj;

		// Token: 0x0400AAD2 RID: 43730
		[AutoBind("./Item/Item", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noFrameItemObj;

		// Token: 0x0400AAD3 RID: 43731
		[AutoBind("./Item/Item", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_noFrameItemIconImage;

		// Token: 0x0400AAD4 RID: 43732
		[AutoBind("./Item/Crystal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rechargeItemObj;

		// Token: 0x0400AAD5 RID: 43733
		[AutoBind("./Item/Crystal", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rechargeItemIconImage;

		// Token: 0x0400AAD6 RID: 43734
		[AutoBind("./LimitPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_limitObj;

		// Token: 0x0400AAD7 RID: 43735
		[AutoBind("./LimitPanel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_limitText;

		// Token: 0x0400AAD8 RID: 43736
		[AutoBind("./DisablePanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_disableBuyObj;

		// Token: 0x0400AAD9 RID: 43737
		[AutoBind("./DisablePanel/SoldOut&RefreshTime", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_disableBuyRefreshObj;

		// Token: 0x0400AADA RID: 43738
		[AutoBind("./DisablePanel/SoldOut&RefreshTime/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_refreshOrRemoveTimeText;

		// Token: 0x0400AADB RID: 43739
		[AutoBind("./DisablePanel/OnlySoldOut", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_disableBuyOnlyObj;

		// Token: 0x0400AADC RID: 43740
		[AutoBind("./ExtraPresentPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_extraPresentGameObj;

		// Token: 0x0400AADD RID: 43741
		[AutoBind("./ExtraPresentPanel/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_extraPresentText;

		// Token: 0x0400AADE RID: 43742
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemNameText;

		// Token: 0x0400AADF RID: 43743
		[AutoBind("./PresentedPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_presentedPanelObj;

		// Token: 0x0400AAE0 RID: 43744
		[AutoBind("./PresentedPanel/RemoveTimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_presentedText;

		// Token: 0x0400AAE1 RID: 43745
		[AutoBind("./PricePanel/Item", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_priceIconImage;

		// Token: 0x0400AAE2 RID: 43746
		[AutoBind("./PricePanel/CrystalIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_priceCrystalImage;

		// Token: 0x0400AAE3 RID: 43747
		[AutoBind("./PricePanel/RMBIcon ", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_priceRMBImage;

		// Token: 0x0400AAE4 RID: 43748
		[AutoBind("./PricePanel/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_priceText;

		// Token: 0x0400AAE5 RID: 43749
		[AutoBind("./PricePanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_pricePanelStateCtrl;

		// Token: 0x0400AAE6 RID: 43750
		[AutoBind("./LabelPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_labelObj;

		// Token: 0x0400AAE7 RID: 43751
		[AutoBind("./LabelPanel/CommendLabel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_commendLabelObj;

		// Token: 0x0400AAE8 RID: 43752
		[AutoBind("./LabelPanel/DiscountLabel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_discountLabelObj;

		// Token: 0x0400AAE9 RID: 43753
		[AutoBind("./LabelPanel/FirstDiscountLabel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_firstDiscountLabelObj;

		// Token: 0x0400AAEA RID: 43754
		[AutoBind("./LabelPanel/LimitTimeLabel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_limitTimeLabelObj;

		// Token: 0x0400AAEB RID: 43755
		[AutoBind("./LabelPanel/FirstLabel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_firstLabelObj;

		// Token: 0x0400AAEC RID: 43756
		[AutoBind("./Tape", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_LeftDayGameobj;

		// Token: 0x0400AAED RID: 43757
		[AutoBind("./Tape/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_LeftDayText;

		// Token: 0x0400AAEE RID: 43758
		private string m_countString;

		// Token: 0x0400AAEF RID: 43759
		private bool m_isSSR;

		// Token: 0x0400AAF0 RID: 43760
		public StoreType m_storeType;

		// Token: 0x0400AAF1 RID: 43761
		public GoodsType m_goodsType;

		// Token: 0x0400AAF2 RID: 43762
		public int m_fixedStoreItemGoodsID;

		// Token: 0x0400AAF3 RID: 43763
		public int m_goodsID;

		// Token: 0x0400AAF4 RID: 43764
		public int m_index;

		// Token: 0x0400AAF5 RID: 43765
		public bool m_haveFirstBuyReward;

		// Token: 0x0400AAF6 RID: 43766
		public GoodsType m_extraCurrencyType;

		// Token: 0x0400AAF7 RID: 43767
		public GoodsType m_currentGoodCurrencyType;

		// Token: 0x0400AAF8 RID: 43768
		public string m_extraCurrencyTypeIconString;

		// Token: 0x0400AAF9 RID: 43769
		public int m_extraCurrencyCount;

		// Token: 0x0400AAFA RID: 43770
		public GiftStoreItem m_giftStoreItem;

		// Token: 0x0400AAFB RID: 43771
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400AAFC RID: 43772
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400AAFD RID: 43773
		private ClientConfigDataLoader m_clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;

		// Token: 0x0400AAFE RID: 43774
		[DoNotToLua]
		private StoreItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AAFF RID: 43775
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AB00 RID: 43776
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AB01 RID: 43777
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AB02 RID: 43778
		private LuaFunction m_OnStoreItemClick_hotfix;

		// Token: 0x0400AB03 RID: 43779
		private LuaFunction m_SetFixedStoreItemInfoFixedStoreItem_hotfix;

		// Token: 0x0400AB04 RID: 43780
		private LuaFunction m_SetRandomStoreItemInfoRandomStoreItemInt32_hotfix;

		// Token: 0x0400AB05 RID: 43781
		private LuaFunction m_SetRechargeStoreItemInfoInt32StoreTypeBooleanDoubleStringInt32String_hotfix;

		// Token: 0x0400AB06 RID: 43782
		private LuaFunction m_SetGiftStoreItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix;

		// Token: 0x0400AB07 RID: 43783
		private LuaFunction m_SetGiftStoreMothCardItemInfoGiftStoreItemDoublePDSDKGoodType_hotfix;

		// Token: 0x0400AB08 RID: 43784
		private LuaFunction m_SetLabelConfigDataFixedStoreItemInfo_hotfix;

		// Token: 0x0400AB09 RID: 43785
		private LuaFunction m_SetLabel_RMB_RechargeBoolean_hotfix;

		// Token: 0x0400AB0A RID: 43786
		private LuaFunction m_SetLabel_hotfix;

		// Token: 0x0400AB0B RID: 43787
		private LuaFunction m_SetPriceFixedStoreItem_hotfix;

		// Token: 0x0400AB0C RID: 43788
		private LuaFunction m_SetPriceConfigDataRandomStoreItemInfo_hotfix;

		// Token: 0x0400AB0D RID: 43789
		private LuaFunction m_SetPrice_RMBDouble_hotfix;

		// Token: 0x0400AB0E RID: 43790
		private LuaFunction m_SetLimitFixedStoreItemConfigDataFixedStoreItemInfo_hotfix;

		// Token: 0x0400AB0F RID: 43791
		private LuaFunction m_SetLimitGiftStoreItemConfigDataGiftStoreItemInfo_hotfix;

		// Token: 0x0400AB10 RID: 43792
		private LuaFunction m_HaveFirstBuyRewardConfigDataFixedStoreItemInfo_hotfix;

		// Token: 0x0400AB11 RID: 43793
		private LuaFunction m_SetLimit_hotfix;

		// Token: 0x0400AB12 RID: 43794
		private LuaFunction m_SetLimit_RMBBooleanInt32_hotfix;

		// Token: 0x0400AB13 RID: 43795
		private LuaFunction m_SetSellOutFixedStoreItem_hotfix;

		// Token: 0x0400AB14 RID: 43796
		private LuaFunction m_SetSellOutRandomStoreItem_hotfix;

		// Token: 0x0400AB15 RID: 43797
		private LuaFunction m_SetSellOutGiftStoreItem_hotfix;

		// Token: 0x0400AB16 RID: 43798
		private LuaFunction m_SetSellOut_hotfix;

		// Token: 0x0400AB17 RID: 43799
		private LuaFunction m_SetRemoveTimeDateTime_hotfix;

		// Token: 0x0400AB18 RID: 43800
		private LuaFunction m_UpdateIconGoodsTypeInt32Int32_hotfix;

		// Token: 0x0400AB19 RID: 43801
		private LuaFunction m_UpdateIcon_RMBString_hotfix;

		// Token: 0x0400AB1A RID: 43802
		private LuaFunction m_SetNoFrameInfoGoodsTypeInt32_hotfix;

		// Token: 0x0400AB1B RID: 43803
		private LuaFunction m_SetGeneralGoodInfoInt32_hotfix;

		// Token: 0x0400AB1C RID: 43804
		private LuaFunction m_GetFrameNameAndSetSSR_hotfix;

		// Token: 0x0400AB1D RID: 43805
		private LuaFunction m_SetRandomStoreItemNotShow_hotfix;

		// Token: 0x0400AB1E RID: 43806
		private LuaFunction m_SetLeftDaysString_hotfix;

		// Token: 0x0400AB1F RID: 43807
		private LuaFunction m_SetItemDefaultState_hotfix;

		// Token: 0x0400AB20 RID: 43808
		private LuaFunction m_get_Count_hotfix;

		// Token: 0x0400AB21 RID: 43809
		private LuaFunction m_set_CountString_hotfix;

		// Token: 0x0400AB22 RID: 43810
		private LuaFunction m_get_PriceIcon_hotfix;

		// Token: 0x0400AB23 RID: 43811
		private LuaFunction m_set_PriceIconImage_hotfix;

		// Token: 0x0400AB24 RID: 43812
		private LuaFunction m_get_PriceText_hotfix;

		// Token: 0x0400AB25 RID: 43813
		private LuaFunction m_set_PriceTextText_hotfix;

		// Token: 0x0400AB26 RID: 43814
		private LuaFunction m_get_ItemNameText_hotfix;

		// Token: 0x0400AB27 RID: 43815
		private LuaFunction m_set_ItemNameTextText_hotfix;

		// Token: 0x0400AB28 RID: 43816
		private LuaFunction m_get_LimitText_hotfix;

		// Token: 0x0400AB29 RID: 43817
		private LuaFunction m_set_LimitTextText_hotfix;

		// Token: 0x0400AB2A RID: 43818
		private LuaFunction m_get_GoodPDSDKType_hotfix;

		// Token: 0x0400AB2B RID: 43819
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400AB2C RID: 43820
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000F20 RID: 3872
		public new class LuaExportHelper
		{
			// Token: 0x06013344 RID: 78660 RVA: 0x004E6A1C File Offset: 0x004E4C1C
			public LuaExportHelper(StoreItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013345 RID: 78661 RVA: 0x004E6A2C File Offset: 0x004E4C2C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013346 RID: 78662 RVA: 0x004E6A3C File Offset: 0x004E4C3C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013347 RID: 78663 RVA: 0x004E6A4C File Offset: 0x004E4C4C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013348 RID: 78664 RVA: 0x004E6A5C File Offset: 0x004E4C5C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013349 RID: 78665 RVA: 0x004E6A74 File Offset: 0x004E4C74
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601334A RID: 78666 RVA: 0x004E6A84 File Offset: 0x004E4C84
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601334B RID: 78667 RVA: 0x004E6A94 File Offset: 0x004E4C94
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601334C RID: 78668 RVA: 0x004E6AA4 File Offset: 0x004E4CA4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601334D RID: 78669 RVA: 0x004E6AB4 File Offset: 0x004E4CB4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601334E RID: 78670 RVA: 0x004E6AC4 File Offset: 0x004E4CC4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601334F RID: 78671 RVA: 0x004E6AD4 File Offset: 0x004E4CD4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013350 RID: 78672 RVA: 0x004E6AE4 File Offset: 0x004E4CE4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013351 RID: 78673 RVA: 0x004E6AF4 File Offset: 0x004E4CF4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013352 RID: 78674 RVA: 0x004E6B04 File Offset: 0x004E4D04
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013353 RID: 78675 RVA: 0x004E6B14 File Offset: 0x004E4D14
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013354 RID: 78676 RVA: 0x004E6B24 File Offset: 0x004E4D24
			public void __callDele_EventOnClick(StoreItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06013355 RID: 78677 RVA: 0x004E6B34 File Offset: 0x004E4D34
			public void __clearDele_EventOnClick(StoreItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x170039C7 RID: 14791
			// (get) Token: 0x06013356 RID: 78678 RVA: 0x004E6B44 File Offset: 0x004E4D44
			// (set) Token: 0x06013357 RID: 78679 RVA: 0x004E6B54 File Offset: 0x004E4D54
			public PDSDKGoodType m_goodPDSDKType
			{
				get
				{
					return this.m_owner.m_goodPDSDKType;
				}
				set
				{
					this.m_owner.m_goodPDSDKType = value;
				}
			}

			// Token: 0x170039C8 RID: 14792
			// (get) Token: 0x06013358 RID: 78680 RVA: 0x004E6B64 File Offset: 0x004E4D64
			public static string PriceState_OtherItem
			{
				get
				{
					return "OtherItem";
				}
			}

			// Token: 0x170039C9 RID: 14793
			// (get) Token: 0x06013359 RID: 78681 RVA: 0x004E6B6C File Offset: 0x004E4D6C
			public static string PriceState_Crystal
			{
				get
				{
					return "Crystal";
				}
			}

			// Token: 0x170039CA RID: 14794
			// (get) Token: 0x0601335A RID: 78682 RVA: 0x004E6B74 File Offset: 0x004E4D74
			public static string PriceState_RMBIcon
			{
				get
				{
					return "RMB";
				}
			}

			// Token: 0x170039CB RID: 14795
			// (get) Token: 0x0601335B RID: 78683 RVA: 0x004E6B7C File Offset: 0x004E4D7C
			// (set) Token: 0x0601335C RID: 78684 RVA: 0x004E6B8C File Offset: 0x004E4D8C
			public Button m_storeItemButton
			{
				get
				{
					return this.m_owner.m_storeItemButton;
				}
				set
				{
					this.m_owner.m_storeItemButton = value;
				}
			}

			// Token: 0x170039CC RID: 14796
			// (get) Token: 0x0601335D RID: 78685 RVA: 0x004E6B9C File Offset: 0x004E4D9C
			// (set) Token: 0x0601335E RID: 78686 RVA: 0x004E6BAC File Offset: 0x004E4DAC
			public CommonUIStateController m_itemUIStateController
			{
				get
				{
					return this.m_owner.m_itemUIStateController;
				}
				set
				{
					this.m_owner.m_itemUIStateController = value;
				}
			}

			// Token: 0x170039CD RID: 14797
			// (get) Token: 0x0601335F RID: 78687 RVA: 0x004E6BBC File Offset: 0x004E4DBC
			// (set) Token: 0x06013360 RID: 78688 RVA: 0x004E6BCC File Offset: 0x004E4DCC
			public GameObject m_generalGoodObj
			{
				get
				{
					return this.m_owner.m_generalGoodObj;
				}
				set
				{
					this.m_owner.m_generalGoodObj = value;
				}
			}

			// Token: 0x170039CE RID: 14798
			// (get) Token: 0x06013361 RID: 78689 RVA: 0x004E6BDC File Offset: 0x004E4DDC
			// (set) Token: 0x06013362 RID: 78690 RVA: 0x004E6BEC File Offset: 0x004E4DEC
			public Image m_generalGoodIconImage
			{
				get
				{
					return this.m_owner.m_generalGoodIconImage;
				}
				set
				{
					this.m_owner.m_generalGoodIconImage = value;
				}
			}

			// Token: 0x170039CF RID: 14799
			// (get) Token: 0x06013363 RID: 78691 RVA: 0x004E6BFC File Offset: 0x004E4DFC
			// (set) Token: 0x06013364 RID: 78692 RVA: 0x004E6C0C File Offset: 0x004E4E0C
			public Image m_generalGoodFrameImage
			{
				get
				{
					return this.m_owner.m_generalGoodFrameImage;
				}
				set
				{
					this.m_owner.m_generalGoodFrameImage = value;
				}
			}

			// Token: 0x170039D0 RID: 14800
			// (get) Token: 0x06013365 RID: 78693 RVA: 0x004E6C1C File Offset: 0x004E4E1C
			// (set) Token: 0x06013366 RID: 78694 RVA: 0x004E6C2C File Offset: 0x004E4E2C
			public Image m_ssrEffectImage
			{
				get
				{
					return this.m_owner.m_ssrEffectImage;
				}
				set
				{
					this.m_owner.m_ssrEffectImage = value;
				}
			}

			// Token: 0x170039D1 RID: 14801
			// (get) Token: 0x06013367 RID: 78695 RVA: 0x004E6C3C File Offset: 0x004E4E3C
			// (set) Token: 0x06013368 RID: 78696 RVA: 0x004E6C4C File Offset: 0x004E4E4C
			public Text m_generalGoodCountText
			{
				get
				{
					return this.m_owner.m_generalGoodCountText;
				}
				set
				{
					this.m_owner.m_generalGoodCountText = value;
				}
			}

			// Token: 0x170039D2 RID: 14802
			// (get) Token: 0x06013369 RID: 78697 RVA: 0x004E6C5C File Offset: 0x004E4E5C
			// (set) Token: 0x0601336A RID: 78698 RVA: 0x004E6C6C File Offset: 0x004E4E6C
			public GameObject m_spineAnimObj
			{
				get
				{
					return this.m_owner.m_spineAnimObj;
				}
				set
				{
					this.m_owner.m_spineAnimObj = value;
				}
			}

			// Token: 0x170039D3 RID: 14803
			// (get) Token: 0x0601336B RID: 78699 RVA: 0x004E6C7C File Offset: 0x004E4E7C
			// (set) Token: 0x0601336C RID: 78700 RVA: 0x004E6C8C File Offset: 0x004E4E8C
			public GameObject m_noFrameItemObj
			{
				get
				{
					return this.m_owner.m_noFrameItemObj;
				}
				set
				{
					this.m_owner.m_noFrameItemObj = value;
				}
			}

			// Token: 0x170039D4 RID: 14804
			// (get) Token: 0x0601336D RID: 78701 RVA: 0x004E6C9C File Offset: 0x004E4E9C
			// (set) Token: 0x0601336E RID: 78702 RVA: 0x004E6CAC File Offset: 0x004E4EAC
			public Image m_noFrameItemIconImage
			{
				get
				{
					return this.m_owner.m_noFrameItemIconImage;
				}
				set
				{
					this.m_owner.m_noFrameItemIconImage = value;
				}
			}

			// Token: 0x170039D5 RID: 14805
			// (get) Token: 0x0601336F RID: 78703 RVA: 0x004E6CBC File Offset: 0x004E4EBC
			// (set) Token: 0x06013370 RID: 78704 RVA: 0x004E6CCC File Offset: 0x004E4ECC
			public GameObject m_rechargeItemObj
			{
				get
				{
					return this.m_owner.m_rechargeItemObj;
				}
				set
				{
					this.m_owner.m_rechargeItemObj = value;
				}
			}

			// Token: 0x170039D6 RID: 14806
			// (get) Token: 0x06013371 RID: 78705 RVA: 0x004E6CDC File Offset: 0x004E4EDC
			// (set) Token: 0x06013372 RID: 78706 RVA: 0x004E6CEC File Offset: 0x004E4EEC
			public Image m_rechargeItemIconImage
			{
				get
				{
					return this.m_owner.m_rechargeItemIconImage;
				}
				set
				{
					this.m_owner.m_rechargeItemIconImage = value;
				}
			}

			// Token: 0x170039D7 RID: 14807
			// (get) Token: 0x06013373 RID: 78707 RVA: 0x004E6CFC File Offset: 0x004E4EFC
			// (set) Token: 0x06013374 RID: 78708 RVA: 0x004E6D0C File Offset: 0x004E4F0C
			public GameObject m_limitObj
			{
				get
				{
					return this.m_owner.m_limitObj;
				}
				set
				{
					this.m_owner.m_limitObj = value;
				}
			}

			// Token: 0x170039D8 RID: 14808
			// (get) Token: 0x06013375 RID: 78709 RVA: 0x004E6D1C File Offset: 0x004E4F1C
			// (set) Token: 0x06013376 RID: 78710 RVA: 0x004E6D2C File Offset: 0x004E4F2C
			public Text m_limitText
			{
				get
				{
					return this.m_owner.m_limitText;
				}
				set
				{
					this.m_owner.m_limitText = value;
				}
			}

			// Token: 0x170039D9 RID: 14809
			// (get) Token: 0x06013377 RID: 78711 RVA: 0x004E6D3C File Offset: 0x004E4F3C
			// (set) Token: 0x06013378 RID: 78712 RVA: 0x004E6D4C File Offset: 0x004E4F4C
			public GameObject m_disableBuyObj
			{
				get
				{
					return this.m_owner.m_disableBuyObj;
				}
				set
				{
					this.m_owner.m_disableBuyObj = value;
				}
			}

			// Token: 0x170039DA RID: 14810
			// (get) Token: 0x06013379 RID: 78713 RVA: 0x004E6D5C File Offset: 0x004E4F5C
			// (set) Token: 0x0601337A RID: 78714 RVA: 0x004E6D6C File Offset: 0x004E4F6C
			public GameObject m_disableBuyRefreshObj
			{
				get
				{
					return this.m_owner.m_disableBuyRefreshObj;
				}
				set
				{
					this.m_owner.m_disableBuyRefreshObj = value;
				}
			}

			// Token: 0x170039DB RID: 14811
			// (get) Token: 0x0601337B RID: 78715 RVA: 0x004E6D7C File Offset: 0x004E4F7C
			// (set) Token: 0x0601337C RID: 78716 RVA: 0x004E6D8C File Offset: 0x004E4F8C
			public Text m_refreshOrRemoveTimeText
			{
				get
				{
					return this.m_owner.m_refreshOrRemoveTimeText;
				}
				set
				{
					this.m_owner.m_refreshOrRemoveTimeText = value;
				}
			}

			// Token: 0x170039DC RID: 14812
			// (get) Token: 0x0601337D RID: 78717 RVA: 0x004E6D9C File Offset: 0x004E4F9C
			// (set) Token: 0x0601337E RID: 78718 RVA: 0x004E6DAC File Offset: 0x004E4FAC
			public GameObject m_disableBuyOnlyObj
			{
				get
				{
					return this.m_owner.m_disableBuyOnlyObj;
				}
				set
				{
					this.m_owner.m_disableBuyOnlyObj = value;
				}
			}

			// Token: 0x170039DD RID: 14813
			// (get) Token: 0x0601337F RID: 78719 RVA: 0x004E6DBC File Offset: 0x004E4FBC
			// (set) Token: 0x06013380 RID: 78720 RVA: 0x004E6DCC File Offset: 0x004E4FCC
			public GameObject m_extraPresentGameObj
			{
				get
				{
					return this.m_owner.m_extraPresentGameObj;
				}
				set
				{
					this.m_owner.m_extraPresentGameObj = value;
				}
			}

			// Token: 0x170039DE RID: 14814
			// (get) Token: 0x06013381 RID: 78721 RVA: 0x004E6DDC File Offset: 0x004E4FDC
			// (set) Token: 0x06013382 RID: 78722 RVA: 0x004E6DEC File Offset: 0x004E4FEC
			public Text m_extraPresentText
			{
				get
				{
					return this.m_owner.m_extraPresentText;
				}
				set
				{
					this.m_owner.m_extraPresentText = value;
				}
			}

			// Token: 0x170039DF RID: 14815
			// (get) Token: 0x06013383 RID: 78723 RVA: 0x004E6DFC File Offset: 0x004E4FFC
			// (set) Token: 0x06013384 RID: 78724 RVA: 0x004E6E0C File Offset: 0x004E500C
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

			// Token: 0x170039E0 RID: 14816
			// (get) Token: 0x06013385 RID: 78725 RVA: 0x004E6E1C File Offset: 0x004E501C
			// (set) Token: 0x06013386 RID: 78726 RVA: 0x004E6E2C File Offset: 0x004E502C
			public GameObject m_presentedPanelObj
			{
				get
				{
					return this.m_owner.m_presentedPanelObj;
				}
				set
				{
					this.m_owner.m_presentedPanelObj = value;
				}
			}

			// Token: 0x170039E1 RID: 14817
			// (get) Token: 0x06013387 RID: 78727 RVA: 0x004E6E3C File Offset: 0x004E503C
			// (set) Token: 0x06013388 RID: 78728 RVA: 0x004E6E4C File Offset: 0x004E504C
			public Text m_presentedText
			{
				get
				{
					return this.m_owner.m_presentedText;
				}
				set
				{
					this.m_owner.m_presentedText = value;
				}
			}

			// Token: 0x170039E2 RID: 14818
			// (get) Token: 0x06013389 RID: 78729 RVA: 0x004E6E5C File Offset: 0x004E505C
			// (set) Token: 0x0601338A RID: 78730 RVA: 0x004E6E6C File Offset: 0x004E506C
			public Image m_priceIconImage
			{
				get
				{
					return this.m_owner.m_priceIconImage;
				}
				set
				{
					this.m_owner.m_priceIconImage = value;
				}
			}

			// Token: 0x170039E3 RID: 14819
			// (get) Token: 0x0601338B RID: 78731 RVA: 0x004E6E7C File Offset: 0x004E507C
			// (set) Token: 0x0601338C RID: 78732 RVA: 0x004E6E8C File Offset: 0x004E508C
			public Image m_priceCrystalImage
			{
				get
				{
					return this.m_owner.m_priceCrystalImage;
				}
				set
				{
					this.m_owner.m_priceCrystalImage = value;
				}
			}

			// Token: 0x170039E4 RID: 14820
			// (get) Token: 0x0601338D RID: 78733 RVA: 0x004E6E9C File Offset: 0x004E509C
			// (set) Token: 0x0601338E RID: 78734 RVA: 0x004E6EAC File Offset: 0x004E50AC
			public Image m_priceRMBImage
			{
				get
				{
					return this.m_owner.m_priceRMBImage;
				}
				set
				{
					this.m_owner.m_priceRMBImage = value;
				}
			}

			// Token: 0x170039E5 RID: 14821
			// (get) Token: 0x0601338F RID: 78735 RVA: 0x004E6EBC File Offset: 0x004E50BC
			// (set) Token: 0x06013390 RID: 78736 RVA: 0x004E6ECC File Offset: 0x004E50CC
			public Text m_priceText
			{
				get
				{
					return this.m_owner.m_priceText;
				}
				set
				{
					this.m_owner.m_priceText = value;
				}
			}

			// Token: 0x170039E6 RID: 14822
			// (get) Token: 0x06013391 RID: 78737 RVA: 0x004E6EDC File Offset: 0x004E50DC
			// (set) Token: 0x06013392 RID: 78738 RVA: 0x004E6EEC File Offset: 0x004E50EC
			public CommonUIStateController m_pricePanelStateCtrl
			{
				get
				{
					return this.m_owner.m_pricePanelStateCtrl;
				}
				set
				{
					this.m_owner.m_pricePanelStateCtrl = value;
				}
			}

			// Token: 0x170039E7 RID: 14823
			// (get) Token: 0x06013393 RID: 78739 RVA: 0x004E6EFC File Offset: 0x004E50FC
			// (set) Token: 0x06013394 RID: 78740 RVA: 0x004E6F0C File Offset: 0x004E510C
			public GameObject m_labelObj
			{
				get
				{
					return this.m_owner.m_labelObj;
				}
				set
				{
					this.m_owner.m_labelObj = value;
				}
			}

			// Token: 0x170039E8 RID: 14824
			// (get) Token: 0x06013395 RID: 78741 RVA: 0x004E6F1C File Offset: 0x004E511C
			// (set) Token: 0x06013396 RID: 78742 RVA: 0x004E6F2C File Offset: 0x004E512C
			public GameObject m_commendLabelObj
			{
				get
				{
					return this.m_owner.m_commendLabelObj;
				}
				set
				{
					this.m_owner.m_commendLabelObj = value;
				}
			}

			// Token: 0x170039E9 RID: 14825
			// (get) Token: 0x06013397 RID: 78743 RVA: 0x004E6F3C File Offset: 0x004E513C
			// (set) Token: 0x06013398 RID: 78744 RVA: 0x004E6F4C File Offset: 0x004E514C
			public GameObject m_discountLabelObj
			{
				get
				{
					return this.m_owner.m_discountLabelObj;
				}
				set
				{
					this.m_owner.m_discountLabelObj = value;
				}
			}

			// Token: 0x170039EA RID: 14826
			// (get) Token: 0x06013399 RID: 78745 RVA: 0x004E6F5C File Offset: 0x004E515C
			// (set) Token: 0x0601339A RID: 78746 RVA: 0x004E6F6C File Offset: 0x004E516C
			public GameObject m_firstDiscountLabelObj
			{
				get
				{
					return this.m_owner.m_firstDiscountLabelObj;
				}
				set
				{
					this.m_owner.m_firstDiscountLabelObj = value;
				}
			}

			// Token: 0x170039EB RID: 14827
			// (get) Token: 0x0601339B RID: 78747 RVA: 0x004E6F7C File Offset: 0x004E517C
			// (set) Token: 0x0601339C RID: 78748 RVA: 0x004E6F8C File Offset: 0x004E518C
			public GameObject m_limitTimeLabelObj
			{
				get
				{
					return this.m_owner.m_limitTimeLabelObj;
				}
				set
				{
					this.m_owner.m_limitTimeLabelObj = value;
				}
			}

			// Token: 0x170039EC RID: 14828
			// (get) Token: 0x0601339D RID: 78749 RVA: 0x004E6F9C File Offset: 0x004E519C
			// (set) Token: 0x0601339E RID: 78750 RVA: 0x004E6FAC File Offset: 0x004E51AC
			public GameObject m_firstLabelObj
			{
				get
				{
					return this.m_owner.m_firstLabelObj;
				}
				set
				{
					this.m_owner.m_firstLabelObj = value;
				}
			}

			// Token: 0x170039ED RID: 14829
			// (get) Token: 0x0601339F RID: 78751 RVA: 0x004E6FBC File Offset: 0x004E51BC
			// (set) Token: 0x060133A0 RID: 78752 RVA: 0x004E6FCC File Offset: 0x004E51CC
			public GameObject m_LeftDayGameobj
			{
				get
				{
					return this.m_owner.m_LeftDayGameobj;
				}
				set
				{
					this.m_owner.m_LeftDayGameobj = value;
				}
			}

			// Token: 0x170039EE RID: 14830
			// (get) Token: 0x060133A1 RID: 78753 RVA: 0x004E6FDC File Offset: 0x004E51DC
			// (set) Token: 0x060133A2 RID: 78754 RVA: 0x004E6FEC File Offset: 0x004E51EC
			public Text m_LeftDayText
			{
				get
				{
					return this.m_owner.m_LeftDayText;
				}
				set
				{
					this.m_owner.m_LeftDayText = value;
				}
			}

			// Token: 0x170039EF RID: 14831
			// (get) Token: 0x060133A3 RID: 78755 RVA: 0x004E6FFC File Offset: 0x004E51FC
			// (set) Token: 0x060133A4 RID: 78756 RVA: 0x004E700C File Offset: 0x004E520C
			public string m_countString
			{
				get
				{
					return this.m_owner.m_countString;
				}
				set
				{
					this.m_owner.m_countString = value;
				}
			}

			// Token: 0x170039F0 RID: 14832
			// (get) Token: 0x060133A5 RID: 78757 RVA: 0x004E701C File Offset: 0x004E521C
			// (set) Token: 0x060133A6 RID: 78758 RVA: 0x004E702C File Offset: 0x004E522C
			public bool m_isSSR
			{
				get
				{
					return this.m_owner.m_isSSR;
				}
				set
				{
					this.m_owner.m_isSSR = value;
				}
			}

			// Token: 0x170039F1 RID: 14833
			// (get) Token: 0x060133A7 RID: 78759 RVA: 0x004E703C File Offset: 0x004E523C
			// (set) Token: 0x060133A8 RID: 78760 RVA: 0x004E704C File Offset: 0x004E524C
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

			// Token: 0x170039F2 RID: 14834
			// (get) Token: 0x060133A9 RID: 78761 RVA: 0x004E705C File Offset: 0x004E525C
			// (set) Token: 0x060133AA RID: 78762 RVA: 0x004E706C File Offset: 0x004E526C
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

			// Token: 0x170039F3 RID: 14835
			// (get) Token: 0x060133AB RID: 78763 RVA: 0x004E707C File Offset: 0x004E527C
			// (set) Token: 0x060133AC RID: 78764 RVA: 0x004E708C File Offset: 0x004E528C
			public ClientConfigDataLoader m_clientConfigDataLoader
			{
				get
				{
					return this.m_owner.m_clientConfigDataLoader;
				}
				set
				{
					this.m_owner.m_clientConfigDataLoader = value;
				}
			}

			// Token: 0x170039F4 RID: 14836
			// (set) Token: 0x060133AD RID: 78765 RVA: 0x004E709C File Offset: 0x004E529C
			public string Count
			{
				set
				{
					this.m_owner.Count = value;
				}
			}

			// Token: 0x170039F5 RID: 14837
			// (set) Token: 0x060133AE RID: 78766 RVA: 0x004E70AC File Offset: 0x004E52AC
			public Image PriceIcon
			{
				set
				{
					this.m_owner.PriceIcon = value;
				}
			}

			// Token: 0x170039F6 RID: 14838
			// (set) Token: 0x060133AF RID: 78767 RVA: 0x004E70BC File Offset: 0x004E52BC
			public Text PriceText
			{
				set
				{
					this.m_owner.PriceText = value;
				}
			}

			// Token: 0x170039F7 RID: 14839
			// (set) Token: 0x060133B0 RID: 78768 RVA: 0x004E70CC File Offset: 0x004E52CC
			public Text ItemNameText
			{
				set
				{
					this.m_owner.ItemNameText = value;
				}
			}

			// Token: 0x170039F8 RID: 14840
			// (set) Token: 0x060133B1 RID: 78769 RVA: 0x004E70DC File Offset: 0x004E52DC
			public Text LimitText
			{
				set
				{
					this.m_owner.LimitText = value;
				}
			}

			// Token: 0x060133B2 RID: 78770 RVA: 0x004E70EC File Offset: 0x004E52EC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060133B3 RID: 78771 RVA: 0x004E70FC File Offset: 0x004E52FC
			public void OnStoreItemClick()
			{
				this.m_owner.OnStoreItemClick();
			}

			// Token: 0x060133B4 RID: 78772 RVA: 0x004E710C File Offset: 0x004E530C
			public void SetLabel(ConfigDataFixedStoreItemInfo itemInfo)
			{
				this.m_owner.SetLabel(itemInfo);
			}

			// Token: 0x060133B5 RID: 78773 RVA: 0x004E711C File Offset: 0x004E531C
			public void SetLabel_RMB_Recharge(bool isGoodsBought)
			{
				this.m_owner.SetLabel_RMB_Recharge(isGoodsBought);
			}

			// Token: 0x060133B6 RID: 78774 RVA: 0x004E712C File Offset: 0x004E532C
			public void SetLabel()
			{
				this.m_owner.SetLabel();
			}

			// Token: 0x060133B7 RID: 78775 RVA: 0x004E713C File Offset: 0x004E533C
			public void SetPrice(FixedStoreItem item)
			{
				this.m_owner.SetPrice(item);
			}

			// Token: 0x060133B8 RID: 78776 RVA: 0x004E714C File Offset: 0x004E534C
			public void SetPrice(ConfigDataRandomStoreItemInfo itemInfo)
			{
				this.m_owner.SetPrice(itemInfo);
			}

			// Token: 0x060133B9 RID: 78777 RVA: 0x004E715C File Offset: 0x004E535C
			public void SetPrice_RMB(double goodPrice)
			{
				this.m_owner.SetPrice_RMB(goodPrice);
			}

			// Token: 0x060133BA RID: 78778 RVA: 0x004E716C File Offset: 0x004E536C
			public void SetLimit(FixedStoreItem item, ConfigDataFixedStoreItemInfo fixedStoreItemInfo)
			{
				this.m_owner.SetLimit(item, fixedStoreItemInfo);
			}

			// Token: 0x060133BB RID: 78779 RVA: 0x004E717C File Offset: 0x004E537C
			public void SetLimit(GiftStoreItem item, ConfigDataGiftStoreItemInfo giftStoreItemInfo)
			{
				this.m_owner.SetLimit(item, giftStoreItemInfo);
			}

			// Token: 0x060133BC RID: 78780 RVA: 0x004E718C File Offset: 0x004E538C
			public bool HaveFirstBuyReward(ConfigDataFixedStoreItemInfo fixedStoreItemInfo)
			{
				return this.m_owner.HaveFirstBuyReward(fixedStoreItemInfo);
			}

			// Token: 0x060133BD RID: 78781 RVA: 0x004E719C File Offset: 0x004E539C
			public void SetLimit()
			{
				this.m_owner.SetLimit();
			}

			// Token: 0x060133BE RID: 78782 RVA: 0x004E71AC File Offset: 0x004E53AC
			public void SetLimit_RMB(bool isGoodsBought, int crystalNums)
			{
				this.m_owner.SetLimit_RMB(isGoodsBought, crystalNums);
			}

			// Token: 0x060133BF RID: 78783 RVA: 0x004E71BC File Offset: 0x004E53BC
			public void SetSellOut(FixedStoreItem item)
			{
				this.m_owner.SetSellOut(item);
			}

			// Token: 0x060133C0 RID: 78784 RVA: 0x004E71CC File Offset: 0x004E53CC
			public void SetSellOut(RandomStoreItem item)
			{
				this.m_owner.SetSellOut(item);
			}

			// Token: 0x060133C1 RID: 78785 RVA: 0x004E71DC File Offset: 0x004E53DC
			public void SetSellOut(GiftStoreItem item)
			{
				this.m_owner.SetSellOut(item);
			}

			// Token: 0x060133C2 RID: 78786 RVA: 0x004E71EC File Offset: 0x004E53EC
			public void SetSellOut()
			{
				this.m_owner.SetSellOut();
			}

			// Token: 0x060133C3 RID: 78787 RVA: 0x004E71FC File Offset: 0x004E53FC
			public void SetRemoveTime(DateTime showEndTime)
			{
				this.m_owner.SetRemoveTime(showEndTime);
			}

			// Token: 0x060133C4 RID: 78788 RVA: 0x004E720C File Offset: 0x004E540C
			public void UpdateIcon(GoodsType goodType, int itemId, int num)
			{
				this.m_owner.UpdateIcon(goodType, itemId, num);
			}

			// Token: 0x060133C5 RID: 78789 RVA: 0x004E721C File Offset: 0x004E541C
			public void UpdateIcon_RMB(string icon)
			{
				this.m_owner.UpdateIcon_RMB(icon);
			}

			// Token: 0x060133C6 RID: 78790 RVA: 0x004E722C File Offset: 0x004E542C
			public void SetNoFrameInfo(GoodsType goodType, int goodsId)
			{
				this.m_owner.SetNoFrameInfo(goodType, goodsId);
			}

			// Token: 0x060133C7 RID: 78791 RVA: 0x004E723C File Offset: 0x004E543C
			public void SetGeneralGoodInfo(int count)
			{
				this.m_owner.SetGeneralGoodInfo(count);
			}

			// Token: 0x060133C8 RID: 78792 RVA: 0x004E724C File Offset: 0x004E544C
			public string GetFrameNameAndSetSSR()
			{
				return this.m_owner.GetFrameNameAndSetSSR();
			}

			// Token: 0x060133C9 RID: 78793 RVA: 0x004E725C File Offset: 0x004E545C
			public void SetRandomStoreItemNotShow()
			{
				this.m_owner.SetRandomStoreItemNotShow();
			}

			// Token: 0x060133CA RID: 78794 RVA: 0x004E726C File Offset: 0x004E546C
			public void SetLeftDays(string remainTime)
			{
				this.m_owner.SetLeftDays(remainTime);
			}

			// Token: 0x060133CB RID: 78795 RVA: 0x004E727C File Offset: 0x004E547C
			public void SetItemDefaultState()
			{
				this.m_owner.SetItemDefaultState();
			}

			// Token: 0x0400AB2D RID: 43821
			private StoreItemUIController m_owner;
		}
	}
}
