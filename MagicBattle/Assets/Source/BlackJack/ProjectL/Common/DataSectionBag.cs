using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C0 RID: 1216
	[CustomLuaClass]
	public class DataSectionBag : DataSection
	{
		// Token: 0x06004A5E RID: 19038 RVA: 0x00173F8C File Offset: 0x0017218C
		public DataSectionBag()
		{
			this.m_instanceId2CacheIndex = new Dictionary<ulong, int>();
			this.Bag = new BagItemUpdateCache();
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x00173FAC File Offset: 0x001721AC
		public override void ClearInitedData()
		{
			this.m_instanceId2CacheIndex.Clear();
			this.Bag = new BagItemUpdateCache();
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x00173FC4 File Offset: 0x001721C4
		public List<object> SerializeMultipleToClient()
		{
			List<object> list = new List<object>();
			DSBagNtf dsbagNtf = new DSBagNtf();
			dsbagNtf.Version = (uint)base.Version;
			list.Add(dsbagNtf);
			int num = 0;
			DSBagExtraNtf dsbagExtraNtf = null;
			foreach (UpdateCache<BagItemBase> updateCache in this.Bag.Caches)
			{
				if (updateCache.IsValid())
				{
					if (num < 1000)
					{
						dsbagNtf.Bag.Add(updateCache.Data.ToPBGoods());
					}
					else
					{
						if (num % 1000 == 0)
						{
							dsbagExtraNtf = new DSBagExtraNtf();
							list.Add(dsbagExtraNtf);
						}
						dsbagExtraNtf.Bag.Add(updateCache.Data.ToPBGoods());
					}
					num++;
				}
			}
			return list;
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x001740B0 File Offset: 0x001722B0
		public void InitBagItem(BagItemBase bagItem)
		{
			int value = this.Bag.Init(bagItem);
			this.m_instanceId2CacheIndex.Add(bagItem.InstanceId, value);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x001740DC File Offset: 0x001722DC
		public void AddBagItem(BagItemBase bagItem)
		{
			int value = this.Bag.Add(bagItem);
			this.m_instanceId2CacheIndex.Add(bagItem.InstanceId, value);
			base.SetDirty(true);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00174110 File Offset: 0x00172310
		public BagItemBase SetBagItemNums(BagItemBase bagItem, int nums)
		{
			UpdateCache<BagItemBase> updateCache = this.FindCache(bagItem);
			updateCache.Data.Nums = nums;
			updateCache.Dirty = true;
			base.SetDirty(true);
			return bagItem;
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00174140 File Offset: 0x00172340
		public BagItemBase RemoveBagItem(BagItemBase bagItem, int nums)
		{
			int index = this.FindBagItemIndex(bagItem);
			UpdateCache<BagItemBase> updateCache = this.Bag.Find(index);
			bagItem.Nums -= nums;
			if (bagItem.Nums <= 0)
			{
				this.Bag.Remove(index);
				this.m_instanceId2CacheIndex.Remove(bagItem.InstanceId);
			}
			else
			{
				updateCache.Dirty = true;
			}
			base.SetDirty(true);
			return bagItem;
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x001741B0 File Offset: 0x001723B0
		public void RemoveAllBagItems()
		{
			this.Bag.Clear();
			this.m_instanceId2CacheIndex.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x001741D0 File Offset: 0x001723D0
		public BagItemBase FindBagItem(ulong instanceId)
		{
			int index;
			if (this.m_instanceId2CacheIndex.TryGetValue(instanceId, out index))
			{
				UpdateCache<BagItemBase> updateCache = this.Bag.Find(index);
				return updateCache.Data;
			}
			return null;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00174208 File Offset: 0x00172408
		public void SetBagItemDirty(BagItemBase bagItem)
		{
			UpdateCache<BagItemBase> updateCache = this.FindCache(bagItem);
			updateCache.Dirty = true;
			base.SetDirty(true);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0017422C File Offset: 0x0017242C
		public BagItemBase FindBagItem(GoodsType goodsTypeId, int contentId)
		{
			ulong instanceId = BagItemFactory.CreateBagItemInstanceId(goodsTypeId, contentId);
			return this.FindBagItem(instanceId);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00174248 File Offset: 0x00172448
		private int FindBagItemIndex(BagItemBase bagItem)
		{
			int minValue;
			if (!this.m_instanceId2CacheIndex.TryGetValue(bagItem.InstanceId, out minValue))
			{
				minValue = int.MinValue;
			}
			return minValue;
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00174274 File Offset: 0x00172474
		private UpdateCache<BagItemBase> FindCache(BagItemBase bagItem)
		{
			int index = this.FindBagItemIndex(bagItem);
			return this.Bag.Find(index);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00174298 File Offset: 0x00172498
		public int Size()
		{
			return this.Bag.ValidCount;
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x001742A8 File Offset: 0x001724A8
		public List<BagItemBase> GetAllBagItems()
		{
			return this.Bag.GetAllVaildDatas();
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x001742B8 File Offset: 0x001724B8
		public IEnumerable<BagItemBase> IterateAllBagItems()
		{
			return this.Bag.IterateAllBagItems();
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x06004A6E RID: 19054 RVA: 0x001742C8 File Offset: 0x001724C8
		public Dictionary<ulong, int> InstanceId2CacheIndex
		{
			get
			{
				return this.m_instanceId2CacheIndex;
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x001742D0 File Offset: 0x001724D0
		// (set) Token: 0x06004A70 RID: 19056 RVA: 0x001742D8 File Offset: 0x001724D8
		public BagItemUpdateCache Bag { get; set; }

		// Token: 0x04003827 RID: 14375
		private Dictionary<ulong, int> m_instanceId2CacheIndex;

		// Token: 0x04003829 RID: 14377
		private const int MaxBagNumsPerNtf = 1000;
	}
}
