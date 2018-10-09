using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000576 RID: 1398
	[CustomLuaClass]
	public class RandomStore
	{
		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600512B RID: 20779 RVA: 0x00182D58 File Offset: 0x00180F58
		// (set) Token: 0x0600512C RID: 20780 RVA: 0x00182D60 File Offset: 0x00180F60
		public int Id { get; set; }

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600512D RID: 20781 RVA: 0x00182D6C File Offset: 0x00180F6C
		// (set) Token: 0x0600512E RID: 20782 RVA: 0x00182D74 File Offset: 0x00180F74
		public DateTime NextFlushTime { get; set; }

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x0600512F RID: 20783 RVA: 0x00182D80 File Offset: 0x00180F80
		// (set) Token: 0x06005130 RID: 20784 RVA: 0x00182D88 File Offset: 0x00180F88
		public int ManualFlushNums { get; set; }

		// Token: 0x06005131 RID: 20785 RVA: 0x00182D94 File Offset: 0x00180F94
		public static ProRandomStore StoreToPBStore(RandomStore store)
		{
			ProRandomStore proRandomStore = new ProRandomStore
			{
				StoreId = store.Id,
				NextFlushTime = store.NextFlushTime.Ticks,
				ManualFlushNums = store.ManualFlushNums
			};
			foreach (RandomStoreItem storeItem in store.Items)
			{
				proRandomStore.Items.Add(RandomStoreItem.StoreItemToPBStoreItem(storeItem));
			}
			return proRandomStore;
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x00182E30 File Offset: 0x00181030
		public static List<ProRandomStore> StoresToPBStores(List<RandomStore> stores)
		{
			List<ProRandomStore> list = new List<ProRandomStore>();
			foreach (RandomStore store in stores)
			{
				list.Add(RandomStore.StoreToPBStore(store));
			}
			return list;
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00182E94 File Offset: 0x00181094
		public static RandomStore PBStoreToStore(ProRandomStore pbStore)
		{
			RandomStore randomStore = new RandomStore
			{
				Id = pbStore.StoreId,
				NextFlushTime = new DateTime(pbStore.NextFlushTime),
				ManualFlushNums = pbStore.ManualFlushNums
			};
			foreach (ProRandomStoreItem pbStoreItem in pbStore.Items)
			{
				randomStore.Items.Add(RandomStoreItem.PBStoreItemToStoreItem(pbStoreItem));
			}
			return randomStore;
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x00182F2C File Offset: 0x0018112C
		public static List<RandomStore> PBStoresToStores(List<ProRandomStore> pbStores)
		{
			List<RandomStore> list = new List<RandomStore>();
			foreach (ProRandomStore pbStore in pbStores)
			{
				list.Add(RandomStore.PBStoreToStore(pbStore));
			}
			return list;
		}

		// Token: 0x04003A6A RID: 14954
		public List<RandomStoreItem> Items = new List<RandomStoreItem>();
	}
}
