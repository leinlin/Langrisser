using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000453 RID: 1107
	[HotFix]
	public class FixedStoreComponentCommon : IComponentBase
	{
		// Token: 0x0600404A RID: 16458 RVA: 0x0012B2F0 File Offset: 0x001294F0
		public FixedStoreComponentCommon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x0012B364 File Offset: 0x00129564
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "FixedStore";
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0012B3D8 File Offset: 0x001295D8
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x0012B438 File Offset: 0x00129638
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushBoughtNums;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0012B500 File Offset: 0x00129700
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x0012B560 File Offset: 0x00129760
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0012B5D0 File Offset: 0x001297D0
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x0012B650 File Offset: 0x00129850
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x0012B6C0 File Offset: 0x001298C0
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x0012B720 File Offset: 0x00129920
		// (set) Token: 0x06004054 RID: 16468 RVA: 0x0012B794 File Offset: 0x00129994
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0012B80C File Offset: 0x00129A0C
		private void OnFlushBoughtNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushBoughtNums_hotfix != null)
			{
				this.m_OnFlushBoughtNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			foreach (KeyValuePair<int, FixedStore> keyValuePair in this.m_fixedStoreDS.Stores)
			{
				foreach (FixedStoreItem fixedStoreItem in keyValuePair.Value.Items)
				{
					ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItem.Id);
					if (configDataFixedStoreItemInfo != null && fixedStoreItem.NextFlushTime <= currentTime.Ticks)
					{
						fixedStoreItem.BoughtCount = 0;
						fixedStoreItem.NextFlushTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(configDataFixedStoreItemInfo.BuyLimitType, configDataFixedStoreItemInfo.Param, currentTime, fixedStoreItem.NextFlushTime).Ticks;
						this.m_fixedStoreDS.SetDirty(true);
					}
				}
			}
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x0012B980 File Offset: 0x00129B80
		public bool IsSoldOut(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSoldOutConfigDataFixedStoreItemInfoFixedStoreItem_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSoldOutConfigDataFixedStoreItemInfoFixedStoreItem_hotfix.call(new object[]
				{
					this,
					itemConfig,
					item
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return itemConfig.Count != 0 && item.BoughtCount >= itemConfig.Count;
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x0012BA2C File Offset: 0x00129C2C
		public bool IsInSaleTime(ConfigDataFixedStoreItemInfo itemConfig)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInSaleTimeConfigDataFixedStoreItemInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInSaleTimeConfigDataFixedStoreItemInfo_hotfix.call(new object[]
				{
					this,
					itemConfig
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !(DateTime.Parse(itemConfig.ShowEndTime) <= this.m_basicInfo.GetCurrentTime()) && !(this.m_basicInfo.GetCurrentTime() < DateTime.Parse(itemConfig.ShowStartTime));
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0012BAEC File Offset: 0x00129CEC
		public virtual int CanBuyGoods(int storeId, int goodsId, int selectedIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyGoodsInt32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyGoodsInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					storeId,
					goodsId2,
					selectedIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int goodsId = goodsId2;
			FixedStoreInfo fixedStoreInfo;
			if (!this.m_configDataLoader.FixedStoreData.Stores.TryGetValue(storeId, out fixedStoreInfo))
			{
				return -1300;
			}
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo;
			if (!fixedStoreInfo.StoreItems.TryGetValue(goodsId, out configDataFixedStoreItemInfo))
			{
				return -1301;
			}
			if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Item)
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
				if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_SelfSelectedBox)
				{
					ConfigDataSelfSelectedBoxInfo configDataSelfSelectedBoxInfo = this.m_configDataLoader.GetConfigDataSelfSelectedBoxInfo(configDataItemInfo.FuncTypeParam1);
					if (configDataSelfSelectedBoxInfo.Reward.Count <= selectedIndex || selectedIndex < 0)
					{
						return -539;
					}
				}
				else if (selectedIndex != -1)
				{
					return -540;
				}
			}
			else
			{
				if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Gold && this.m_basicInfo.IsGoldOverFlow(configDataFixedStoreItemInfo.Nums))
				{
					return -422;
				}
				if (selectedIndex != -1)
				{
					return -540;
				}
			}
			FixedStoreItem item = null;
			FixedStore fixedStore = this.m_fixedStoreDS.FindStore(storeId);
			if (fixedStore != null)
			{
				item = fixedStore.Items.Find((FixedStoreItem t) => t.Id == goodsId);
			}
			return this.CanBuyFixedStoreItem(configDataFixedStoreItemInfo, item);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x0012BCBC File Offset: 0x00129EBC
		protected int CanBuyFixedStoreItem(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyFixedStoreItemConfigDataFixedStoreItemInfoFixedStoreItem_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyFixedStoreItemConfigDataFixedStoreItemInfoFixedStoreItem_hotfix.call(new object[]
				{
					this,
					itemConfig,
					item
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsInSaleTime(itemConfig))
			{
				return -1303;
			}
			bool isFirstBuy;
			if (item == null)
			{
				isFirstBuy = true;
			}
			else
			{
				isFirstBuy = this.m_fixedStoreDS.IsFirstBuy(item);
				if (new DateTime(item.NextFlushTime) > this.m_basicInfo.GetCurrentTime() && this.IsSoldOut(itemConfig, item))
				{
					return -1302;
				}
			}
			int consumeNums = this.CaculateCurrencyCount(itemConfig, isFirstBuy);
			int num = this.m_basicInfo.IsCurrencyEnough(itemConfig.CurrencyType, consumeNums);
			if (num != 0)
			{
				return num;
			}
			if (BagItemBase.IsBagItem(itemConfig.ItemType) && this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0012BDF4 File Offset: 0x00129FF4
		public int CaculateCurrencyCount(ConfigDataFixedStoreItemInfo storeItemConfig, bool isFirstBuy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaculateCurrencyCountConfigDataFixedStoreItemInfoBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CaculateCurrencyCountConfigDataFixedStoreItemInfoBoolean_hotfix.call(new object[]
				{
					this,
					storeItemConfig,
					isFirstBuy
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isFirstBuy)
			{
				return storeItemConfig.FirstPrice;
			}
			if (this.IsOnDiscountPeriod(storeItemConfig))
			{
				return storeItemConfig.DiscountPrice;
			}
			return storeItemConfig.NormalPrice;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x0012BEA8 File Offset: 0x0012A0A8
		public bool IsOnDiscountPeriod(ConfigDataFixedStoreItemInfo storeItemConfig)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOnDiscountPeriodConfigDataFixedStoreItemInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOnDiscountPeriodConfigDataFixedStoreItemInfo_hotfix.call(new object[]
				{
					this,
					storeItemConfig
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return currentTime >= DateTime.Parse(storeItemConfig.DiscountStartTime) && currentTime < DateTime.Parse(storeItemConfig.DiscountEndTime);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0012BF5C File Offset: 0x0012A15C
		public FixedStore GetStore(int storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStoreInt32_hotfix != null)
			{
				return (FixedStore)this.m_GetStoreInt32_hotfix.call(new object[]
				{
					this,
					storeId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FixedStore storeOfferingById = this.GetStoreOfferingById(storeId);
			if (storeOfferingById == null)
			{
				return null;
			}
			FixedStore fixedStore = this.m_fixedStoreDS.FindStore(storeId);
			if (fixedStore == null)
			{
				return storeOfferingById;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			using (List<FixedStoreItem>.Enumerator enumerator = fixedStore.Items.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					FixedStoreItem localStoreItem = enumerator.Current;
					FixedStoreItem fixedStoreItem = storeOfferingById.Items.Find((FixedStoreItem t) => t.Id == localStoreItem.Id);
					if (fixedStoreItem != null)
					{
						ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItem.Id);
						if (new DateTime(localStoreItem.NextFlushTime) == DateTime.MaxValue && configDataFixedStoreItemInfo.Count != 0 && localStoreItem.BoughtCount >= configDataFixedStoreItemInfo.Count)
						{
							storeOfferingById.Items.Remove(fixedStoreItem);
						}
						else
						{
							if (new DateTime(localStoreItem.NextFlushTime) > this.m_basicInfo.GetCurrentTime())
							{
								fixedStoreItem.BoughtCount = localStoreItem.BoughtCount;
								fixedStoreItem.NextFlushTime = localStoreItem.NextFlushTime;
							}
							else
							{
								fixedStoreItem.NextFlushTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(configDataFixedStoreItemInfo.BuyLimitType, configDataFixedStoreItemInfo.Param, currentTime, localStoreItem.NextFlushTime).Ticks;
							}
							fixedStoreItem.IsFirstBuy = localStoreItem.IsFirstBuy;
						}
					}
				}
			}
			return storeOfferingById;
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0012C18C File Offset: 0x0012A38C
		private FixedStore GetStoreOfferingById(int storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStoreOfferingByIdInt32_hotfix != null)
			{
				return (FixedStore)this.m_GetStoreOfferingByIdInt32_hotfix.call(new object[]
				{
					this,
					storeId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime maxValue = DateTime.MaxValue;
			FixedStoreInfo fixedStoreInfo;
			if (!this.m_configDataLoader.FixedStoreData.Stores.TryGetValue(storeId, out fixedStoreInfo))
			{
				return null;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			FixedStore fixedStore = new FixedStore();
			fixedStore.Id = storeId;
			foreach (ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo in fixedStoreInfo.StoreItems.Values)
			{
				if (DateTime.Parse(configDataFixedStoreItemInfo.ShowStartTime) <= currentTime && currentTime < DateTime.Parse(configDataFixedStoreItemInfo.ShowEndTime))
				{
					FixedStoreItem fixedStoreItem = new FixedStoreItem();
					fixedStoreItem.Id = configDataFixedStoreItemInfo.ID;
					fixedStoreItem.BoughtCount = 0;
					fixedStoreItem.IsFirstBuy = true;
					fixedStoreItem.NextFlushTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(configDataFixedStoreItemInfo.BuyLimitType, configDataFixedStoreItemInfo.Param, currentTime, 0L).Ticks;
					fixedStore.Items.Add(fixedStoreItem);
				}
			}
			return fixedStore;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0012C31C File Offset: 0x0012A51C
		protected void BuyStoreItem(int storeId, FixedStoreItem storeItem, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyStoreItemInt32FixedStoreItemInt32_hotfix != null)
			{
				this.m_BuyStoreItemInt32FixedStoreItemInt32_hotfix.call(new object[]
				{
					this,
					storeId,
					storeItem,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (storeItem.IsFirstBuy)
			{
				storeItem.IsFirstBuy = false;
			}
			this.m_fixedStoreDS.BuyStoreItem(storeItem, count);
			this.OnBuyStoreItem(storeItem, count);
			if (this.BuyStoreItemEvent != null)
			{
				this.BuyStoreItemEvent(storeId, storeItem.Id);
			}
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0012C3F0 File Offset: 0x0012A5F0
		private void OnBuyStoreItem(FixedStoreItem storeItem, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyStoreItemFixedStoreItemInt32_hotfix != null)
			{
				this.m_OnBuyStoreItemFixedStoreItemInt32_hotfix.call(new object[]
				{
					this,
					storeItem,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnAddSkin(storeItem);
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0012C478 File Offset: 0x0012A678
		private void OnAddSkin(FixedStoreItem storeItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddSkinFixedStoreItem_hotfix != null)
			{
				this.m_OnAddSkinFixedStoreItem_hotfix.call(new object[]
				{
					this,
					storeItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(storeItem.Id);
			StoreId storeID = configDataFixedStoreItemInfo.StoreID;
			if (storeID != StoreId.StoreId_SkinHero)
			{
				if (storeID == StoreId.StoreId_SkinSoldier)
				{
					this.m_resource.AddSoldierSkin(configDataFixedStoreItemInfo.ItemId, GameFunctionType.GameFunctionType_None, null);
				}
			}
			else
			{
				this.m_resource.AddHeroSkin(configDataFixedStoreItemInfo.ItemId, GameFunctionType.GameFunctionType_None, null);
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06004061 RID: 16481 RVA: 0x0012C544 File Offset: 0x0012A744
		// (remove) Token: 0x06004062 RID: 16482 RVA: 0x0012C5E0 File Offset: 0x0012A7E0
		public event Action<int, int> BuyStoreItemEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_BuyStoreItemEventAction`2_hotfix != null)
				{
					this.m_add_BuyStoreItemEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.BuyStoreItemEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.BuyStoreItemEvent, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_BuyStoreItemEventAction`2_hotfix != null)
				{
					this.m_remove_BuyStoreItemEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.BuyStoreItemEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.BuyStoreItemEvent, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06004063 RID: 16483 RVA: 0x0012C67C File Offset: 0x0012A87C
		// (set) Token: 0x06004064 RID: 16484 RVA: 0x0012C69C File Offset: 0x0012A89C
		[DoNotToLua]
		public FixedStoreComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FixedStoreComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x0012C6A8 File Offset: 0x0012A8A8
		private void __callDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			Action<int, int> buyStoreItemEvent = this.BuyStoreItemEvent;
			if (buyStoreItemEvent != null)
			{
				buyStoreItemEvent(arg1, arg2);
			}
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x0012C6CC File Offset: 0x0012A8CC
		private void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			this.BuyStoreItemEvent = null;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0012C6D8 File Offset: 0x0012A8D8
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_OnFlushBoughtNums_hotfix = (luaObj.RawGet("OnFlushBoughtNums") as LuaFunction);
					this.m_IsSoldOutConfigDataFixedStoreItemInfoFixedStoreItem_hotfix = (luaObj.RawGet("IsSoldOut") as LuaFunction);
					this.m_IsInSaleTimeConfigDataFixedStoreItemInfo_hotfix = (luaObj.RawGet("IsInSaleTime") as LuaFunction);
					this.m_CanBuyGoodsInt32Int32Int32_hotfix = (luaObj.RawGet("CanBuyGoods") as LuaFunction);
					this.m_CanBuyFixedStoreItemConfigDataFixedStoreItemInfoFixedStoreItem_hotfix = (luaObj.RawGet("CanBuyFixedStoreItem") as LuaFunction);
					this.m_CaculateCurrencyCountConfigDataFixedStoreItemInfoBoolean_hotfix = (luaObj.RawGet("CaculateCurrencyCount") as LuaFunction);
					this.m_IsOnDiscountPeriodConfigDataFixedStoreItemInfo_hotfix = (luaObj.RawGet("IsOnDiscountPeriod") as LuaFunction);
					this.m_GetStoreInt32_hotfix = (luaObj.RawGet("GetStore") as LuaFunction);
					this.m_GetStoreOfferingByIdInt32_hotfix = (luaObj.RawGet("GetStoreOfferingById") as LuaFunction);
					this.m_BuyStoreItemInt32FixedStoreItemInt32_hotfix = (luaObj.RawGet("BuyStoreItem") as LuaFunction);
					this.m_OnBuyStoreItemFixedStoreItemInt32_hotfix = (luaObj.RawGet("OnBuyStoreItem") as LuaFunction);
					this.m_OnAddSkinFixedStoreItem_hotfix = (luaObj.RawGet("OnAddSkin") as LuaFunction);
					this.m_add_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("add_BuyStoreItemEvent") as LuaFunction);
					this.m_remove_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("remove_BuyStoreItemEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004068 RID: 16488 RVA: 0x0012C9FC File Offset: 0x0012ABFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FixedStoreComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003105 RID: 12549
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003106 RID: 12550
		protected BagComponentCommon m_bag;

		// Token: 0x04003107 RID: 12551
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003108 RID: 12552
		protected ResourceComponentCommon m_resource;

		// Token: 0x04003109 RID: 12553
		protected DataSectionFixedStore m_fixedStoreDS = new DataSectionFixedStore();

		// Token: 0x0400310B RID: 12555
		[DoNotToLua]
		private FixedStoreComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400310C RID: 12556
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400310D RID: 12557
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400310E RID: 12558
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400310F RID: 12559
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003110 RID: 12560
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003111 RID: 12561
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003112 RID: 12562
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003113 RID: 12563
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003114 RID: 12564
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003115 RID: 12565
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003116 RID: 12566
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003117 RID: 12567
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003118 RID: 12568
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003119 RID: 12569
		private LuaFunction m_OnFlushBoughtNums_hotfix;

		// Token: 0x0400311A RID: 12570
		private LuaFunction m_IsSoldOutConfigDataFixedStoreItemInfoFixedStoreItem_hotfix;

		// Token: 0x0400311B RID: 12571
		private LuaFunction m_IsInSaleTimeConfigDataFixedStoreItemInfo_hotfix;

		// Token: 0x0400311C RID: 12572
		private LuaFunction m_CanBuyGoodsInt32Int32Int32_hotfix;

		// Token: 0x0400311D RID: 12573
		private LuaFunction m_CanBuyFixedStoreItemConfigDataFixedStoreItemInfoFixedStoreItem_hotfix;

		// Token: 0x0400311E RID: 12574
		private LuaFunction m_CaculateCurrencyCountConfigDataFixedStoreItemInfoBoolean_hotfix;

		// Token: 0x0400311F RID: 12575
		private LuaFunction m_IsOnDiscountPeriodConfigDataFixedStoreItemInfo_hotfix;

		// Token: 0x04003120 RID: 12576
		private LuaFunction m_GetStoreInt32_hotfix;

		// Token: 0x04003121 RID: 12577
		private LuaFunction m_GetStoreOfferingByIdInt32_hotfix;

		// Token: 0x04003122 RID: 12578
		private LuaFunction m_BuyStoreItemInt32FixedStoreItemInt32_hotfix;

		// Token: 0x04003123 RID: 12579
		private LuaFunction m_OnBuyStoreItemFixedStoreItemInt32_hotfix;

		// Token: 0x04003124 RID: 12580
		private LuaFunction m_OnAddSkinFixedStoreItem_hotfix;

		// Token: 0x04003125 RID: 12581
		private LuaFunction m_add_BuyStoreItemEventAction;

		// Token: 0x04003126 RID: 12582
		private LuaFunction m_remove_BuyStoreItemEventAction;

		// Token: 0x02000454 RID: 1108
		public class LuaExportHelper
		{
			// Token: 0x06004069 RID: 16489 RVA: 0x0012CA64 File Offset: 0x0012AC64
			public LuaExportHelper(FixedStoreComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600406A RID: 16490 RVA: 0x0012CA74 File Offset: 0x0012AC74
			public void __callDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x0600406B RID: 16491 RVA: 0x0012CA84 File Offset: 0x0012AC84
			public void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x17001126 RID: 4390
			// (get) Token: 0x0600406C RID: 16492 RVA: 0x0012CA94 File Offset: 0x0012AC94
			// (set) Token: 0x0600406D RID: 16493 RVA: 0x0012CAA4 File Offset: 0x0012ACA4
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

			// Token: 0x17001127 RID: 4391
			// (get) Token: 0x0600406E RID: 16494 RVA: 0x0012CAB4 File Offset: 0x0012ACB4
			// (set) Token: 0x0600406F RID: 16495 RVA: 0x0012CAC4 File Offset: 0x0012ACC4
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x17001128 RID: 4392
			// (get) Token: 0x06004070 RID: 16496 RVA: 0x0012CAD4 File Offset: 0x0012ACD4
			// (set) Token: 0x06004071 RID: 16497 RVA: 0x0012CAE4 File Offset: 0x0012ACE4
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001129 RID: 4393
			// (get) Token: 0x06004072 RID: 16498 RVA: 0x0012CAF4 File Offset: 0x0012ACF4
			// (set) Token: 0x06004073 RID: 16499 RVA: 0x0012CB04 File Offset: 0x0012AD04
			public ResourceComponentCommon m_resource
			{
				get
				{
					return this.m_owner.m_resource;
				}
				set
				{
					this.m_owner.m_resource = value;
				}
			}

			// Token: 0x1700112A RID: 4394
			// (get) Token: 0x06004074 RID: 16500 RVA: 0x0012CB14 File Offset: 0x0012AD14
			// (set) Token: 0x06004075 RID: 16501 RVA: 0x0012CB24 File Offset: 0x0012AD24
			public DataSectionFixedStore m_fixedStoreDS
			{
				get
				{
					return this.m_owner.m_fixedStoreDS;
				}
				set
				{
					this.m_owner.m_fixedStoreDS = value;
				}
			}

			// Token: 0x06004076 RID: 16502 RVA: 0x0012CB34 File Offset: 0x0012AD34
			public void OnFlushBoughtNums()
			{
				this.m_owner.OnFlushBoughtNums();
			}

			// Token: 0x06004077 RID: 16503 RVA: 0x0012CB44 File Offset: 0x0012AD44
			public int CanBuyFixedStoreItem(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
			{
				return this.m_owner.CanBuyFixedStoreItem(itemConfig, item);
			}

			// Token: 0x06004078 RID: 16504 RVA: 0x0012CB54 File Offset: 0x0012AD54
			public FixedStore GetStoreOfferingById(int storeId)
			{
				return this.m_owner.GetStoreOfferingById(storeId);
			}

			// Token: 0x06004079 RID: 16505 RVA: 0x0012CB64 File Offset: 0x0012AD64
			public void BuyStoreItem(int storeId, FixedStoreItem storeItem, int count)
			{
				this.m_owner.BuyStoreItem(storeId, storeItem, count);
			}

			// Token: 0x0600407A RID: 16506 RVA: 0x0012CB74 File Offset: 0x0012AD74
			public void OnBuyStoreItem(FixedStoreItem storeItem, int count)
			{
				this.m_owner.OnBuyStoreItem(storeItem, count);
			}

			// Token: 0x0600407B RID: 16507 RVA: 0x0012CB84 File Offset: 0x0012AD84
			public void OnAddSkin(FixedStoreItem storeItem)
			{
				this.m_owner.OnAddSkin(storeItem);
			}

			// Token: 0x04003127 RID: 12583
			private FixedStoreComponentCommon m_owner;
		}
	}
}
