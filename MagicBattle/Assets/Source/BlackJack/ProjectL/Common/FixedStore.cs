using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000578 RID: 1400
	[CustomLuaClass]
	public class FixedStore
	{
		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x0600513D RID: 20797 RVA: 0x00183034 File Offset: 0x00181234
		// (set) Token: 0x0600513E RID: 20798 RVA: 0x0018303C File Offset: 0x0018123C
		public int Id { get; set; }

		// Token: 0x0600513F RID: 20799 RVA: 0x00183048 File Offset: 0x00181248
		public static FixedStore PBFixedStoreToFixedStore(ProFixedStore pbStore)
		{
			FixedStore fixedStore = new FixedStore();
			fixedStore.Id = pbStore.StoreId;
			fixedStore.Items.AddRange(FixedStoreItem.PBStoreItemsToStoreItems(pbStore.Items));
			return fixedStore;
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00183080 File Offset: 0x00181280
		public static List<FixedStore> PBFixedStoresToFixedStores(List<ProFixedStore> pbStores)
		{
			List<FixedStore> list = new List<FixedStore>();
			foreach (ProFixedStore pbStore in pbStores)
			{
				list.Add(FixedStore.PBFixedStoreToFixedStore(pbStore));
			}
			return list;
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x001830E4 File Offset: 0x001812E4
		public static ProFixedStore FixedStoreToPBFixedStore(FixedStore store)
		{
			ProFixedStore proFixedStore = new ProFixedStore();
			proFixedStore.StoreId = store.Id;
			proFixedStore.Items.AddRange(FixedStoreItem.StoreItemsToPBStoreItems(store.Items));
			return proFixedStore;
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x0018311C File Offset: 0x0018131C
		public static List<ProFixedStore> FixedStoresToPBFixedStores(List<FixedStore> stores)
		{
			List<ProFixedStore> list = new List<ProFixedStore>();
			foreach (FixedStore store in stores)
			{
				list.Add(FixedStore.FixedStoreToPBFixedStore(store));
			}
			return list;
		}

		// Token: 0x04003A6E RID: 14958
		public List<FixedStoreItem> Items = new List<FixedStoreItem>();
	}
}
