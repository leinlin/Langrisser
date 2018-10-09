using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004F4 RID: 1268
	[CustomLuaClass]
	public class DataSectionRechargeStore : DataSection
	{
		// Token: 0x06004CDE RID: 19678 RVA: 0x0017986C File Offset: 0x00177A6C
		public override void ClearInitedData()
		{
			this.m_boughtGoodsList.Clear();
			this.m_banBuyingGoodsList.Clear();
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x00179884 File Offset: 0x00177A84
		public override object SerializeToClient()
		{
			DSRechargeStoreNtf dsrechargeStoreNtf = new DSRechargeStoreNtf();
			dsrechargeStoreNtf.Version = (uint)base.Version;
			dsrechargeStoreNtf.BoughtGoodsList.AddRange(this.m_boughtGoodsList);
			return dsrechargeStoreNtf;
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x001798B8 File Offset: 0x00177AB8
		public void InitBoughtGoodsList(List<int> goodsList)
		{
			foreach (int item in goodsList)
			{
				this.m_boughtGoodsList.Add(item);
			}
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00179918 File Offset: 0x00177B18
		public void ClearBoughtGoodsList()
		{
			this.m_boughtGoodsList.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x0017992C File Offset: 0x00177B2C
		public bool IsGoodsBought(int goodsId)
		{
			return this.m_boughtGoodsList.Contains(goodsId);
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x0017993C File Offset: 0x00177B3C
		public void BuyGoods(int goodsId)
		{
			this.m_boughtGoodsList.Add(goodsId);
			base.SetDirty(true);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00179954 File Offset: 0x00177B54
		public HashSet<int> GetBoughtGoodsList()
		{
			return this.m_boughtGoodsList;
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x0017995C File Offset: 0x00177B5C
		public bool IsGoodsOnBanBuyingPeriod(int goodsId, DateTime currentTime)
		{
			DateTime t;
			return this.m_banBuyingGoodsList.TryGetValue(goodsId, out t) && t > currentTime;
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x00179988 File Offset: 0x00177B88
		public void SetBanBuyingGoodsTime(int goodsId, DateTime expiredTime)
		{
			this.m_banBuyingGoodsList[goodsId] = expiredTime;
			base.SetDirty(true);
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x001799A0 File Offset: 0x00177BA0
		public void InitmBanBuyingGoodsList(Dictionary<int, DateTime> goodsList)
		{
			foreach (KeyValuePair<int, DateTime> keyValuePair in goodsList)
			{
				this.m_banBuyingGoodsList.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x00179A0C File Offset: 0x00177C0C
		public Dictionary<int, DateTime> BanBuyingGoodsList
		{
			get
			{
				return this.m_banBuyingGoodsList;
			}
		}

		// Token: 0x040038D0 RID: 14544
		private HashSet<int> m_boughtGoodsList = new HashSet<int>();

		// Token: 0x040038D1 RID: 14545
		public Dictionary<int, DateTime> m_banBuyingGoodsList = new Dictionary<int, DateTime>();
	}
}
