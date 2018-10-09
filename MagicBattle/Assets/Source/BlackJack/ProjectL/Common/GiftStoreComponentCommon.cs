using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000459 RID: 1113
	[HotFix]
	public class GiftStoreComponentCommon : IComponentBase
	{
		// Token: 0x060040BF RID: 16575 RVA: 0x0012E910 File Offset: 0x0012CB10
		public GiftStoreComponentCommon()
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

		// Token: 0x060040C0 RID: 16576 RVA: 0x0012E984 File Offset: 0x0012CB84
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
			return "GiftStore";
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0012E9F8 File Offset: 0x0012CBF8
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

		// Token: 0x060040C2 RID: 16578 RVA: 0x0012EA58 File Offset: 0x0012CC58
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushBoughtNums;
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0012EB20 File Offset: 0x0012CD20
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

		// Token: 0x060040C4 RID: 16580 RVA: 0x0012EB80 File Offset: 0x0012CD80
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

		// Token: 0x060040C5 RID: 16581 RVA: 0x0012EBF0 File Offset: 0x0012CDF0
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

		// Token: 0x060040C6 RID: 16582 RVA: 0x0012EC70 File Offset: 0x0012CE70
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

		// Token: 0x060040C7 RID: 16583 RVA: 0x0012ECE0 File Offset: 0x0012CEE0
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

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x0012ED40 File Offset: 0x0012CF40
		// (set) Token: 0x060040C9 RID: 16585 RVA: 0x0012EDB4 File Offset: 0x0012CFB4
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

		// Token: 0x060040CA RID: 16586 RVA: 0x0012EE2C File Offset: 0x0012D02C
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
			foreach (GiftStoreItem giftStoreItem in this.m_giftStoreDS.GetLocalBoughtItems())
			{
				ConfigDataGiftStoreItemInfo configDataGiftStoreItemInfo = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(giftStoreItem.GoodsId);
				if (configDataGiftStoreItemInfo != null && !(giftStoreItem.NextFlushTime > currentTime))
				{
					giftStoreItem.BoughtNums = 0;
					giftStoreItem.NextFlushTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(configDataGiftStoreItemInfo.BuyLimitType, configDataGiftStoreItemInfo.Param, currentTime, giftStoreItem.NextFlushTime.Ticks);
					this.m_giftStoreDS.SetDirty(true);
				}
			}
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x0012EF50 File Offset: 0x0012D150
		private List<GiftStoreItem> GetOfferedStoreItemsByConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOfferedStoreItemsByConfig_hotfix != null)
			{
				return (List<GiftStoreItem>)this.m_GetOfferedStoreItemsByConfig_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<GiftStoreItem> list = new List<GiftStoreItem>();
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			foreach (KeyValuePair<int, ConfigDataGiftStoreItemInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataGiftStoreItemInfo())
			{
				GiftStoreItem giftStoreItem;
				if (keyValuePair.Value.IsOperateGoods)
				{
					GiftStoreOperationalGoods giftStoreOperationalGoods = this.m_giftStoreDS.FindGiftStoreOperationalGoods(keyValuePair.Value.ID);
					if (giftStoreOperationalGoods == null)
					{
						continue;
					}
					if (!this.IsOnSaleTime(giftStoreOperationalGoods.SaleStartTime, giftStoreOperationalGoods.SaleEndTime, currentTime))
					{
						continue;
					}
					giftStoreItem = new GiftStoreItem();
					giftStoreItem.GoodsId = giftStoreOperationalGoods.GoodsId;
					giftStoreItem.SaleStartTime = giftStoreOperationalGoods.SaleStartTime;
					giftStoreItem.SaleEndTime = giftStoreOperationalGoods.SaleEndTime;
				}
				else
				{
					if (!this.IsOnSaleTime(DateTime.Parse(keyValuePair.Value.ShowStartTime), DateTime.Parse(keyValuePair.Value.ShowEndTime), currentTime))
					{
						continue;
					}
					giftStoreItem = new GiftStoreItem();
					giftStoreItem.GoodsId = keyValuePair.Value.ID;
					giftStoreItem.SaleStartTime = DateTime.Parse(keyValuePair.Value.ShowStartTime);
					giftStoreItem.SaleEndTime = DateTime.Parse(keyValuePair.Value.ShowEndTime);
				}
				giftStoreItem.BoughtNums = 0;
				giftStoreItem.Config = keyValuePair.Value;
				giftStoreItem.IsFirstBuy = !this.HasBought(keyValuePair.Value.ID);
				giftStoreItem.NextFlushTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(keyValuePair.Value.BuyLimitType, keyValuePair.Value.Param, currentTime, 0L);
				list.Add(giftStoreItem);
			}
			return list;
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x0012F188 File Offset: 0x0012D388
		public List<GiftStoreItem> GetOfferedStoreItems()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOfferedStoreItems_hotfix != null)
			{
				return (List<GiftStoreItem>)this.m_GetOfferedStoreItems_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			List<GiftStoreItem> offeredStoreItemsByConfig = this.GetOfferedStoreItemsByConfig();
			using (List<GiftStoreItem>.Enumerator enumerator = this.m_giftStoreDS.GetLocalBoughtItems().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GiftStoreItem localItem = enumerator.Current;
					GiftStoreItem giftStoreItem = offeredStoreItemsByConfig.Find((GiftStoreItem t) => t.GoodsId == localItem.GoodsId);
					if (giftStoreItem != null)
					{
						if (localItem.NextFlushTime == DateTime.MaxValue)
						{
							ConfigDataGiftStoreItemInfo configDataGiftStoreItemInfo = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(localItem.GoodsId);
							if (configDataGiftStoreItemInfo.Count != 0 && localItem.BoughtNums >= configDataGiftStoreItemInfo.Count)
							{
								offeredStoreItemsByConfig.Remove(giftStoreItem);
								continue;
							}
						}
						if (localItem.NextFlushTime > currentTime)
						{
							giftStoreItem.BoughtNums = localItem.BoughtNums;
							giftStoreItem.NextFlushTime = localItem.NextFlushTime;
						}
						else
						{
							giftStoreItem.NextFlushTime = GoodsNextFlushCaculateTools.CaculateNextFlushTime(giftStoreItem.Config.BuyLimitType, giftStoreItem.Config.Param, currentTime, localItem.NextFlushTime.Ticks);
						}
					}
				}
			}
			return offeredStoreItemsByConfig;
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x0012F36C File Offset: 0x0012D56C
		protected bool IsOnSaleTime(DateTime saleStartTime, DateTime saleEndTime, DateTime currentTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOnSaleTimeDateTimeDateTimeDateTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOnSaleTimeDateTimeDateTimeDateTime_hotfix.call(new object[]
				{
					this,
					saleStartTime,
					saleEndTime,
					currentTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !(currentTime < saleStartTime) && !(currentTime >= saleEndTime);
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0012F424 File Offset: 0x0012D624
		public bool HasBought(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasBoughtInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasBoughtInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_giftStoreDS.HasBought(goodsId);
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x0012F4AC File Offset: 0x0012D6AC
		public virtual int CanBuyGoods(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyGoodsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyGoodsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGiftStoreItemInfo configDataGiftStoreItemInfo = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(goodsId);
			if (configDataGiftStoreItemInfo == null)
			{
				return -5100;
			}
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			if (configDataGiftStoreItemInfo.IsOperateGoods)
			{
				GiftStoreOperationalGoods giftStoreOperationalGoods = this.m_giftStoreDS.FindGiftStoreOperationalGoods(goodsId);
				if (giftStoreOperationalGoods == null || !this.IsOnSaleTime(giftStoreOperationalGoods.SaleStartTime, giftStoreOperationalGoods.SaleEndTime, currentTime))
				{
					return -5101;
				}
			}
			else if (!this.IsOnSaleTime(DateTime.Parse(configDataGiftStoreItemInfo.ShowStartTime), DateTime.Parse(configDataGiftStoreItemInfo.ShowEndTime), currentTime))
			{
				return -5101;
			}
			GiftStoreItem giftStoreItem = this.m_giftStoreDS.FindLocalBoughtItemById(goodsId);
			if (giftStoreItem != null && giftStoreItem.NextFlushTime > currentTime && configDataGiftStoreItemInfo.Count != 0 && configDataGiftStoreItemInfo.Count <= giftStoreItem.BoughtNums)
			{
				return -5102;
			}
			return 0;
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x0012F600 File Offset: 0x0012D800
		public int CanAppleSubscribeGoods(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAppleSubscribeGoodsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAppleSubscribeGoodsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanBuyGoods(goodsId);
			if (num != 0)
			{
				return num;
			}
			ConfigDataGiftStoreItemInfo configDataGiftStoreItemInfo = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(goodsId);
			if (!configDataGiftStoreItemInfo.IsAppleSubscribe)
			{
				return -5105;
			}
			if (configDataGiftStoreItemInfo.ItemType != GoodsType.GoodsType_MonthCard)
			{
				return -5106;
			}
			if (configDataGiftStoreItemInfo.Nums != 1)
			{
				return -5111;
			}
			MonthCard monthCard = this.m_resource.FindMonthCardById(configDataGiftStoreItemInfo.ItemId);
			if (monthCard != null && monthCard.ExpiredTime > this.m_basicInfo.GetCurrentTime())
			{
				return -5107;
			}
			return 0;
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x0012F70C File Offset: 0x0012D90C
		public void AddFirstBuyGoodsRecord(int goodsId, string goodsRegisterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddFirstBuyGoodsRecordInt32String_hotfix != null)
			{
				this.m_AddFirstBuyGoodsRecordInt32String_hotfix.call(new object[]
				{
					this,
					goodsId,
					goodsRegisterId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftStoreDS.AddFirstBuyGoodsRecord(goodsId, goodsRegisterId);
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x0012F79C File Offset: 0x0012D99C
		public List<OrderReward> GetAllOrderRewards()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllOrderRewards_hotfix != null)
			{
				return (List<OrderReward>)this.m_GetAllOrderRewards_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_giftStoreDS.GetAllOrderRewards().Values.ToList<OrderReward>();
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x0012F820 File Offset: 0x0012DA20
		public void RemoveOrderReward(string orderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveOrderRewardString_hotfix != null)
			{
				this.m_RemoveOrderRewardString_hotfix.call(new object[]
				{
					this,
					orderId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftStoreDS.RemoveOrderReward(orderId);
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x0012F89C File Offset: 0x0012DA9C
		public void AddOrderReward(string orderId, OrderReward reward)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddOrderRewardStringOrderReward_hotfix != null)
			{
				this.m_AddOrderRewardStringOrderReward_hotfix.call(new object[]
				{
					this,
					orderId,
					reward
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftStoreDS.AddOrderReward(orderId, reward);
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x0012F92C File Offset: 0x0012DB2C
		public OrderReward FindOrderReward(string orderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOrderRewardString_hotfix != null)
			{
				return (OrderReward)this.m_FindOrderRewardString_hotfix.call(new object[]
				{
					this,
					orderId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_giftStoreDS.FindOrderReward(orderId);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x0012F9B4 File Offset: 0x0012DBB4
		protected void OnBuyGiftStoreGoods(ConfigDataGiftStoreItemInfo goodsInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyGiftStoreGoodsConfigDataGiftStoreItemInfo_hotfix != null)
			{
				this.m_OnBuyGiftStoreGoodsConfigDataGiftStoreItemInfo_hotfix.call(new object[]
				{
					this,
					goodsInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.BuyGiftStoreGoodsEvent != null)
			{
				this.BuyGiftStoreGoodsEvent(goodsInfo.ID);
			}
			if (this.BuyStoreItemEvent != null)
			{
				if (goodsInfo.ItemType == GoodsType.GoodsType_MonthCard)
				{
					this.BuyStoreItemEvent(8, goodsInfo.ID);
				}
				else
				{
					this.BuyStoreItemEvent(7, goodsInfo.ID);
				}
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x060040D7 RID: 16599 RVA: 0x0012FA84 File Offset: 0x0012DC84
		// (remove) Token: 0x060040D8 RID: 16600 RVA: 0x0012FB20 File Offset: 0x0012DD20
		public event Action<int> BuyGiftStoreGoodsEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_BuyGiftStoreGoodsEventAction`1_hotfix != null)
				{
					this.m_add_BuyGiftStoreGoodsEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.BuyGiftStoreGoodsEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.BuyGiftStoreGoodsEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_BuyGiftStoreGoodsEventAction`1_hotfix != null)
				{
					this.m_remove_BuyGiftStoreGoodsEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.BuyGiftStoreGoodsEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.BuyGiftStoreGoodsEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x060040D9 RID: 16601 RVA: 0x0012FBBC File Offset: 0x0012DDBC
		// (remove) Token: 0x060040DA RID: 16602 RVA: 0x0012FC58 File Offset: 0x0012DE58
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

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x0012FCF4 File Offset: 0x0012DEF4
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x0012FD14 File Offset: 0x0012DF14
		[DoNotToLua]
		public GiftStoreComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GiftStoreComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x0012FD20 File Offset: 0x0012DF20
		private void __callDele_BuyGiftStoreGoodsEvent(int obj)
		{
			Action<int> buyGiftStoreGoodsEvent = this.BuyGiftStoreGoodsEvent;
			if (buyGiftStoreGoodsEvent != null)
			{
				buyGiftStoreGoodsEvent(obj);
			}
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x0012FD44 File Offset: 0x0012DF44
		private void __clearDele_BuyGiftStoreGoodsEvent(int obj)
		{
			this.BuyGiftStoreGoodsEvent = null;
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x0012FD50 File Offset: 0x0012DF50
		private void __callDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			Action<int, int> buyStoreItemEvent = this.BuyStoreItemEvent;
			if (buyStoreItemEvent != null)
			{
				buyStoreItemEvent(arg1, arg2);
			}
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x0012FD74 File Offset: 0x0012DF74
		private void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			this.BuyStoreItemEvent = null;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x0012FD80 File Offset: 0x0012DF80
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
					this.m_GetOfferedStoreItemsByConfig_hotfix = (luaObj.RawGet("GetOfferedStoreItemsByConfig") as LuaFunction);
					this.m_GetOfferedStoreItems_hotfix = (luaObj.RawGet("GetOfferedStoreItems") as LuaFunction);
					this.m_IsOnSaleTimeDateTimeDateTimeDateTime_hotfix = (luaObj.RawGet("IsOnSaleTime") as LuaFunction);
					this.m_HasBoughtInt32_hotfix = (luaObj.RawGet("HasBought") as LuaFunction);
					this.m_CanBuyGoodsInt32_hotfix = (luaObj.RawGet("CanBuyGoods") as LuaFunction);
					this.m_CanAppleSubscribeGoodsInt32_hotfix = (luaObj.RawGet("CanAppleSubscribeGoods") as LuaFunction);
					this.m_AddFirstBuyGoodsRecordInt32String_hotfix = (luaObj.RawGet("AddFirstBuyGoodsRecord") as LuaFunction);
					this.m_GetAllOrderRewards_hotfix = (luaObj.RawGet("GetAllOrderRewards") as LuaFunction);
					this.m_RemoveOrderRewardString_hotfix = (luaObj.RawGet("RemoveOrderReward") as LuaFunction);
					this.m_AddOrderRewardStringOrderReward_hotfix = (luaObj.RawGet("AddOrderReward") as LuaFunction);
					this.m_FindOrderRewardString_hotfix = (luaObj.RawGet("FindOrderReward") as LuaFunction);
					this.m_OnBuyGiftStoreGoodsConfigDataGiftStoreItemInfo_hotfix = (luaObj.RawGet("OnBuyGiftStoreGoods") as LuaFunction);
					this.m_add_BuyGiftStoreGoodsEventAction`1_hotfix = (luaObj.RawGet("add_BuyGiftStoreGoodsEvent") as LuaFunction);
					this.m_remove_BuyGiftStoreGoodsEventAction`1_hotfix = (luaObj.RawGet("remove_BuyGiftStoreGoodsEvent") as LuaFunction);
					this.m_add_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("add_BuyStoreItemEvent") as LuaFunction);
					this.m_remove_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("remove_BuyStoreItemEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x001300F0 File Offset: 0x0012E2F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400315F RID: 12639
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003160 RID: 12640
		protected DataSectionGiftStore m_giftStoreDS = new DataSectionGiftStore();

		// Token: 0x04003161 RID: 12641
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003162 RID: 12642
		protected BagComponentCommon m_bag;

		// Token: 0x04003163 RID: 12643
		protected ResourceComponentCommon m_resource;

		// Token: 0x04003166 RID: 12646
		[DoNotToLua]
		private GiftStoreComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003167 RID: 12647
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003168 RID: 12648
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003169 RID: 12649
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400316A RID: 12650
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400316B RID: 12651
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400316C RID: 12652
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400316D RID: 12653
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400316E RID: 12654
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x0400316F RID: 12655
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003170 RID: 12656
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003171 RID: 12657
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003172 RID: 12658
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003173 RID: 12659
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003174 RID: 12660
		private LuaFunction m_OnFlushBoughtNums_hotfix;

		// Token: 0x04003175 RID: 12661
		private LuaFunction m_GetOfferedStoreItemsByConfig_hotfix;

		// Token: 0x04003176 RID: 12662
		private LuaFunction m_GetOfferedStoreItems_hotfix;

		// Token: 0x04003177 RID: 12663
		private LuaFunction m_IsOnSaleTimeDateTimeDateTimeDateTime_hotfix;

		// Token: 0x04003178 RID: 12664
		private LuaFunction m_HasBoughtInt32_hotfix;

		// Token: 0x04003179 RID: 12665
		private LuaFunction m_CanBuyGoodsInt32_hotfix;

		// Token: 0x0400317A RID: 12666
		private LuaFunction m_CanAppleSubscribeGoodsInt32_hotfix;

		// Token: 0x0400317B RID: 12667
		private LuaFunction m_AddFirstBuyGoodsRecordInt32String_hotfix;

		// Token: 0x0400317C RID: 12668
		private LuaFunction m_GetAllOrderRewards_hotfix;

		// Token: 0x0400317D RID: 12669
		private LuaFunction m_RemoveOrderRewardString_hotfix;

		// Token: 0x0400317E RID: 12670
		private LuaFunction m_AddOrderRewardStringOrderReward_hotfix;

		// Token: 0x0400317F RID: 12671
		private LuaFunction m_FindOrderRewardString_hotfix;

		// Token: 0x04003180 RID: 12672
		private LuaFunction m_OnBuyGiftStoreGoodsConfigDataGiftStoreItemInfo_hotfix;

		// Token: 0x04003181 RID: 12673
		private LuaFunction m_add_BuyGiftStoreGoodsEventAction;

		// Token: 0x04003182 RID: 12674
		private LuaFunction m_remove_BuyGiftStoreGoodsEventAction;

		// Token: 0x04003183 RID: 12675
		private LuaFunction m_add_BuyStoreItemEventAction;

		// Token: 0x04003184 RID: 12676
		private LuaFunction m_remove_BuyStoreItemEventAction;

		// Token: 0x0200045A RID: 1114
		public class LuaExportHelper
		{
			// Token: 0x060040E3 RID: 16611 RVA: 0x00130158 File Offset: 0x0012E358
			public LuaExportHelper(GiftStoreComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060040E4 RID: 16612 RVA: 0x00130168 File Offset: 0x0012E368
			public void __callDele_BuyGiftStoreGoodsEvent(int obj)
			{
				this.m_owner.__callDele_BuyGiftStoreGoodsEvent(obj);
			}

			// Token: 0x060040E5 RID: 16613 RVA: 0x00130178 File Offset: 0x0012E378
			public void __clearDele_BuyGiftStoreGoodsEvent(int obj)
			{
				this.m_owner.__clearDele_BuyGiftStoreGoodsEvent(obj);
			}

			// Token: 0x060040E6 RID: 16614 RVA: 0x00130188 File Offset: 0x0012E388
			public void __callDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x060040E7 RID: 16615 RVA: 0x00130198 File Offset: 0x0012E398
			public void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x17001134 RID: 4404
			// (get) Token: 0x060040E8 RID: 16616 RVA: 0x001301A8 File Offset: 0x0012E3A8
			// (set) Token: 0x060040E9 RID: 16617 RVA: 0x001301B8 File Offset: 0x0012E3B8
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

			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x060040EA RID: 16618 RVA: 0x001301C8 File Offset: 0x0012E3C8
			// (set) Token: 0x060040EB RID: 16619 RVA: 0x001301D8 File Offset: 0x0012E3D8
			public DataSectionGiftStore m_giftStoreDS
			{
				get
				{
					return this.m_owner.m_giftStoreDS;
				}
				set
				{
					this.m_owner.m_giftStoreDS = value;
				}
			}

			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x060040EC RID: 16620 RVA: 0x001301E8 File Offset: 0x0012E3E8
			// (set) Token: 0x060040ED RID: 16621 RVA: 0x001301F8 File Offset: 0x0012E3F8
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

			// Token: 0x17001137 RID: 4407
			// (get) Token: 0x060040EE RID: 16622 RVA: 0x00130208 File Offset: 0x0012E408
			// (set) Token: 0x060040EF RID: 16623 RVA: 0x00130218 File Offset: 0x0012E418
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

			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x060040F0 RID: 16624 RVA: 0x00130228 File Offset: 0x0012E428
			// (set) Token: 0x060040F1 RID: 16625 RVA: 0x00130238 File Offset: 0x0012E438
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

			// Token: 0x060040F2 RID: 16626 RVA: 0x00130248 File Offset: 0x0012E448
			public void OnFlushBoughtNums()
			{
				this.m_owner.OnFlushBoughtNums();
			}

			// Token: 0x060040F3 RID: 16627 RVA: 0x00130258 File Offset: 0x0012E458
			public List<GiftStoreItem> GetOfferedStoreItemsByConfig()
			{
				return this.m_owner.GetOfferedStoreItemsByConfig();
			}

			// Token: 0x060040F4 RID: 16628 RVA: 0x00130268 File Offset: 0x0012E468
			public bool IsOnSaleTime(DateTime saleStartTime, DateTime saleEndTime, DateTime currentTime)
			{
				return this.m_owner.IsOnSaleTime(saleStartTime, saleEndTime, currentTime);
			}

			// Token: 0x060040F5 RID: 16629 RVA: 0x00130278 File Offset: 0x0012E478
			public void OnBuyGiftStoreGoods(ConfigDataGiftStoreItemInfo goodsInfo)
			{
				this.m_owner.OnBuyGiftStoreGoods(goodsInfo);
			}

			// Token: 0x04003185 RID: 12677
			private GiftStoreComponentCommon m_owner;
		}
	}
}
