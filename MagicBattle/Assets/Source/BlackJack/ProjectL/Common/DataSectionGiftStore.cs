using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004D2 RID: 1234
	[CustomLuaClass]
	public class DataSectionGiftStore : DataSection
	{
		// Token: 0x06004B19 RID: 19225 RVA: 0x00175930 File Offset: 0x00173B30
		public override void ClearInitedData()
		{
			this.m_localBoughtItems.Clear();
			this.m_firstboughtItemsRecords.Clear();
			this.m_operationalGoodsList.Clear();
			this.m_banBuyingGoodsList.Clear();
			this.m_orderRerads.Clear();
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0017596C File Offset: 0x00173B6C
		public override object SerializeToClient()
		{
			DSGiftStoreNtf dsgiftStoreNtf = new DSGiftStoreNtf();
			dsgiftStoreNtf.Version = (uint)base.Version;
			foreach (KeyValuePair<int, string> keyValuePair in this.m_firstboughtItemsRecords)
			{
				ProGiftStoreFirstBoughtRecord proGiftStoreFirstBoughtRecord = new ProGiftStoreFirstBoughtRecord();
				proGiftStoreFirstBoughtRecord.GoodsId = keyValuePair.Key;
				proGiftStoreFirstBoughtRecord.GoodsRegisterId = keyValuePair.Value;
				dsgiftStoreNtf.Records.Add(proGiftStoreFirstBoughtRecord);
			}
			foreach (GiftStoreItem item in this.m_localBoughtItems)
			{
				dsgiftStoreNtf.BoughtItems.Add(GiftStoreItem.ToPB(item));
			}
			foreach (KeyValuePair<string, OrderReward> keyValuePair2 in this.m_orderRerads)
			{
				dsgiftStoreNtf.OrderRewards.Add(OrderReward.ToPB(keyValuePair2.Value));
			}
			return dsgiftStoreNtf;
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00175AB8 File Offset: 0x00173CB8
		public GiftStoreItem FindLocalBoughtItemById(int goodsId)
		{
			return this.m_localBoughtItems.Find((GiftStoreItem t) => t.GoodsId == goodsId);
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x00175AEC File Offset: 0x00173CEC
		public void AddBoughtItem(GiftStoreItem item)
		{
			this.m_localBoughtItems.Add(item);
			base.SetDirty(true);
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00175B04 File Offset: 0x00173D04
		public void AddFirstBuyGoodsRecord(int goodsId, string goodsRegisterId)
		{
			this.m_firstboughtItemsRecords.Add(goodsId, goodsRegisterId);
			base.SetDirty(true);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00175B1C File Offset: 0x00173D1C
		public bool HasBought(int goodsId)
		{
			return this.m_firstboughtItemsRecords.ContainsKey(goodsId);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00175B2C File Offset: 0x00173D2C
		public string GetFirstBoughtItemRegisterId(int goodsId)
		{
			if (this.HasBought(goodsId))
			{
				return this.m_firstboughtItemsRecords[goodsId];
			}
			return null;
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00175B48 File Offset: 0x00173D48
		public void InitBoughtItem(GiftStoreItem storeItem)
		{
			this.m_localBoughtItems.Add(storeItem);
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00175B58 File Offset: 0x00173D58
		public void SetBoughtItems(List<GiftStoreItem> storeItems)
		{
			this.m_localBoughtItems.AddRange(storeItems);
			base.SetDirty(true);
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00175B70 File Offset: 0x00173D70
		public void InitFirstBuyGoodsRecord(int goodsId, string registerId)
		{
			this.m_firstboughtItemsRecords.Add(goodsId, registerId);
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00175B80 File Offset: 0x00173D80
		public List<GiftStoreItem> GetLocalBoughtItems()
		{
			return this.m_localBoughtItems;
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00175B88 File Offset: 0x00173D88
		public Dictionary<int, string> GetFirstBoughtRecords()
		{
			return this.m_firstboughtItemsRecords;
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00175B90 File Offset: 0x00173D90
		public bool IsGoodsOnBanBuyingPeriod(int goodsId, DateTime currentTime)
		{
			DateTime t;
			return this.m_banBuyingGoodsList.TryGetValue(goodsId, out t) && t > currentTime;
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00175BBC File Offset: 0x00173DBC
		public void SetBanBuyingGoodsTime(int goodsId, DateTime expiredTime)
		{
			this.m_banBuyingGoodsList[goodsId] = expiredTime;
			base.SetDirty(true);
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00175BD4 File Offset: 0x00173DD4
		public void InitmBanBuyingGoodsList(Dictionary<int, DateTime> goodsList)
		{
			foreach (KeyValuePair<int, DateTime> keyValuePair in goodsList)
			{
				this.m_banBuyingGoodsList.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x00175C40 File Offset: 0x00173E40
		public Dictionary<int, DateTime> BanBuyingGoodsList
		{
			get
			{
				return this.m_banBuyingGoodsList;
			}
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00175C48 File Offset: 0x00173E48
		public GiftStoreOperationalGoods FindGiftStoreOperationalGoods(int goodsId)
		{
			return this.m_operationalGoodsList.Find((GiftStoreOperationalGoods t) => t.GoodsId == goodsId);
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00175C7C File Offset: 0x00173E7C
		public void ClearGiftStoreOperationalGoods()
		{
			this.m_operationalGoodsList.Clear();
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00175C8C File Offset: 0x00173E8C
		public void InitOperationalGoodsList(GiftStoreOperationalGoods goods)
		{
			this.m_operationalGoodsList.Add(goods);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00175C9C File Offset: 0x00173E9C
		public List<GiftStoreOperationalGoods> GetOperationalGoodsList()
		{
			return this.m_operationalGoodsList;
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x00175CA4 File Offset: 0x00173EA4
		public void InitOrderReward(OrderReward orderReward)
		{
			this.m_orderRerads.Add(orderReward.OrderId, orderReward);
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00175CB8 File Offset: 0x00173EB8
		public void RemoveOrderReward(string orderId)
		{
			if (this.m_orderRerads.ContainsKey(orderId))
			{
				this.m_orderRerads.Remove(orderId);
				base.SetDirty(true);
			}
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x00175CE0 File Offset: 0x00173EE0
		public void AddOrderReward(string orderId, OrderReward reward)
		{
			this.m_orderRerads[orderId] = reward;
			base.SetDirty(true);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x00175CF8 File Offset: 0x00173EF8
		public OrderReward FindOrderReward(string orderId)
		{
			OrderReward result = null;
			this.m_orderRerads.TryGetValue(orderId, out result);
			return result;
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00175D18 File Offset: 0x00173F18
		public Dictionary<string, OrderReward> GetAllOrderRewards()
		{
			return this.m_orderRerads;
		}

		// Token: 0x04003853 RID: 14419
		private List<GiftStoreItem> m_localBoughtItems = new List<GiftStoreItem>();

		// Token: 0x04003854 RID: 14420
		private Dictionary<int, string> m_firstboughtItemsRecords = new Dictionary<int, string>();

		// Token: 0x04003855 RID: 14421
		protected List<GiftStoreOperationalGoods> m_operationalGoodsList = new List<GiftStoreOperationalGoods>();

		// Token: 0x04003856 RID: 14422
		private Dictionary<int, DateTime> m_banBuyingGoodsList = new Dictionary<int, DateTime>();

		// Token: 0x04003857 RID: 14423
		private Dictionary<string, OrderReward> m_orderRerads = new Dictionary<string, OrderReward>();
	}
}
