using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004CF RID: 1231
	[CustomLuaClass]
	public class DataSectionFixedStore : DataSection
	{
		// Token: 0x06004AEA RID: 19178 RVA: 0x00175384 File Offset: 0x00173584
		public DataSectionFixedStore()
		{
			this.Stores = new Dictionary<int, FixedStore>();
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00175398 File Offset: 0x00173598
		public override object SerializeToClient()
		{
			DSFixedStoreNtf dsfixedStoreNtf = new DSFixedStoreNtf();
			dsfixedStoreNtf.Version = (uint)base.Version;
			dsfixedStoreNtf.Stores.AddRange(FixedStore.FixedStoresToPBFixedStores(this.Stores.Values.ToList<FixedStore>()));
			return dsfixedStoreNtf;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x001753D8 File Offset: 0x001735D8
		public override void ClearInitedData()
		{
			this.Stores.Clear();
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x001753E8 File Offset: 0x001735E8
		public void SetStores(List<FixedStore> stores)
		{
			this.Stores.Clear();
			this.InitStores(stores);
			base.SetDirty(true);
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00175404 File Offset: 0x00173604
		public void InitStores(List<FixedStore> stores)
		{
			foreach (FixedStore fixedStore in stores)
			{
				this.Stores.Add(fixedStore.Id, fixedStore);
			}
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x00175468 File Offset: 0x00173668
		public void InitStore(FixedStore store)
		{
			this.Stores.Add(store.Id, store);
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x0017547C File Offset: 0x0017367C
		public void AddStore(FixedStore store)
		{
			this.Stores.Add(store.Id, store);
			base.SetDirty(true);
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x00175498 File Offset: 0x00173698
		public void ResetStore(FixedStore newStore)
		{
			FixedStore fixedStore;
			if (this.Stores.TryGetValue(newStore.Id, out fixedStore))
			{
				this.Stores[newStore.Id] = newStore;
				base.SetDirty(true);
			}
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x001754D8 File Offset: 0x001736D8
		public FixedStore FindStore(int id)
		{
			FixedStore result = null;
			this.Stores.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x001754F8 File Offset: 0x001736F8
		public void BuyStoreItem(FixedStoreItem storeItem, int count)
		{
			storeItem.BoughtCount += count;
			base.SetDirty(true);
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00175510 File Offset: 0x00173710
		public bool IsFirstBuy(FixedStoreItem storeItem)
		{
			return storeItem.IsFirstBuy;
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0017551C File Offset: 0x0017371C
		public FixedStoreItem GetStoreItem(FixedStore store, int goodsId)
		{
			return store.Items.Find((FixedStoreItem t) => t.Id == goodsId);
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06004AF6 RID: 19190 RVA: 0x00175550 File Offset: 0x00173750
		// (set) Token: 0x06004AF7 RID: 19191 RVA: 0x00175558 File Offset: 0x00173758
		public Dictionary<int, FixedStore> Stores { get; set; }
	}
}
