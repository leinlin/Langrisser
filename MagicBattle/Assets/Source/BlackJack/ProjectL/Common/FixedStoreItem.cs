using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000579 RID: 1401
	[CustomLuaClass]
	public class FixedStoreItem
	{
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06005145 RID: 20805 RVA: 0x00183194 File Offset: 0x00181394
		// (set) Token: 0x06005144 RID: 20804 RVA: 0x00183188 File Offset: 0x00181388
		public int Id { get; set; }

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06005147 RID: 20807 RVA: 0x001831A8 File Offset: 0x001813A8
		// (set) Token: 0x06005146 RID: 20806 RVA: 0x0018319C File Offset: 0x0018139C
		public int BoughtCount { get; set; }

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x001831B0 File Offset: 0x001813B0
		// (set) Token: 0x06005149 RID: 20809 RVA: 0x001831B8 File Offset: 0x001813B8
		public bool IsFirstBuy { get; set; }

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x001831C4 File Offset: 0x001813C4
		// (set) Token: 0x0600514B RID: 20811 RVA: 0x001831CC File Offset: 0x001813CC
		public long NextFlushTime { get; set; }

		// Token: 0x0600514C RID: 20812 RVA: 0x001831D8 File Offset: 0x001813D8
		public static ProFixedStoreItem StoreItemToPBStoreItem(FixedStoreItem storeItem)
		{
			return new ProFixedStoreItem
			{
				Id = storeItem.Id,
				BoughtCount = storeItem.BoughtCount,
				IsFirstBuy = storeItem.IsFirstBuy,
				NextFlushTime = storeItem.NextFlushTime
			};
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00183220 File Offset: 0x00181420
		public static List<ProFixedStoreItem> StoreItemsToPBStoreItems(List<FixedStoreItem> storeItems)
		{
			List<ProFixedStoreItem> list = new List<ProFixedStoreItem>();
			foreach (FixedStoreItem storeItem in storeItems)
			{
				list.Add(FixedStoreItem.StoreItemToPBStoreItem(storeItem));
			}
			return list;
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00183284 File Offset: 0x00181484
		public static FixedStoreItem PBStoreItemToStoreItem(ProFixedStoreItem pbStoreItem)
		{
			return new FixedStoreItem
			{
				Id = pbStoreItem.Id,
				BoughtCount = pbStoreItem.BoughtCount,
				IsFirstBuy = pbStoreItem.IsFirstBuy,
				NextFlushTime = pbStoreItem.NextFlushTime
			};
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x001832CC File Offset: 0x001814CC
		public static List<FixedStoreItem> PBStoreItemsToStoreItems(List<ProFixedStoreItem> pbStoreItems)
		{
			List<FixedStoreItem> list = new List<FixedStoreItem>();
			foreach (ProFixedStoreItem pbStoreItem in pbStoreItems)
			{
				list.Add(FixedStoreItem.PBStoreItemToStoreItem(pbStoreItem));
			}
			return list;
		}
	}
}
