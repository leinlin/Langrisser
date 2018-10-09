using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004EF RID: 1263
	[CustomLuaClass]
	public class DataSectionRandomStore : DataSection
	{
		// Token: 0x06004CB9 RID: 19641 RVA: 0x0017921C File Offset: 0x0017741C
		public DataSectionRandomStore()
		{
			this.Stores = new List<RandomStore>();
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00179230 File Offset: 0x00177430
		public override object SerializeToClient()
		{
			DSRandomStoreNtf dsrandomStoreNtf = new DSRandomStoreNtf();
			dsrandomStoreNtf.Version = (uint)base.Version;
			dsrandomStoreNtf.Stores.AddRange(RandomStore.StoresToPBStores(this.Stores));
			return dsrandomStoreNtf;
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x00179268 File Offset: 0x00177468
		public override void ClearInitedData()
		{
			this.Stores.Clear();
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00179278 File Offset: 0x00177478
		public void InitStore(RandomStore store)
		{
			this.Stores.Add(store);
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x00179288 File Offset: 0x00177488
		public void AddStore(RandomStore store)
		{
			this.Stores.Add(store);
			base.SetDirty(true);
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x001792A0 File Offset: 0x001774A0
		public RandomStore FindStore(int id)
		{
			return this.Stores.Find((RandomStore m) => m.Id == id);
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x001792D4 File Offset: 0x001774D4
		public void SetStore(RandomStore store)
		{
			for (int i = 0; i < this.Stores.Count; i++)
			{
				if (this.Stores[i].Id == store.Id)
				{
					this.Stores[i] = store;
					base.SetDirty(true);
					return;
				}
			}
			this.AddStore(store);
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x00179338 File Offset: 0x00177538
		public void BuyStoreItem(RandomStoreItem storeItem)
		{
			storeItem.Bought = true;
			base.SetDirty(true);
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00179348 File Offset: 0x00177548
		public int GetManualFlushNums(int storeId)
		{
			RandomStore randomStore = this.Stores.Find((RandomStore t) => t.Id == storeId);
			return (randomStore != null) ? randomStore.ManualFlushNums : 0;
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x0017938C File Offset: 0x0017758C
		public void SetStoreNextFlushTime(RandomStore store, DateTime flushTime)
		{
			store.NextFlushTime = flushTime;
			base.SetDirty(true);
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x0017939C File Offset: 0x0017759C
		public void AddStoreItems(RandomStore store, List<RandomStoreItem> storeItems)
		{
			store.Items.AddRange(storeItems);
			base.SetDirty(true);
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x001793B4 File Offset: 0x001775B4
		public void ClearStoreItems(RandomStore store)
		{
			store.Items.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x001793C8 File Offset: 0x001775C8
		public RandomStoreItem GetStoreItem(RandomStore store, int index)
		{
			return store.Items[index];
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x001793D8 File Offset: 0x001775D8
		public void SetManualFlushNums(RandomStore store, int nums)
		{
			store.ManualFlushNums = nums;
			base.SetDirty(true);
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x001793E8 File Offset: 0x001775E8
		public void AddManualFlushNums(RandomStore store, int addNums)
		{
			store.ManualFlushNums += addNums;
			base.SetDirty(true);
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06004CC8 RID: 19656 RVA: 0x00179400 File Offset: 0x00177600
		// (set) Token: 0x06004CC9 RID: 19657 RVA: 0x00179408 File Offset: 0x00177608
		public List<RandomStore> Stores { get; set; }
	}
}
