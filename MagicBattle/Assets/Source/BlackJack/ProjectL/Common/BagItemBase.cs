using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200050D RID: 1293
	[CustomLuaClass]
	public class BagItemBase
	{
		// Token: 0x06004E20 RID: 20000 RVA: 0x0017C3B4 File Offset: 0x0017A5B4
		public BagItemBase(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId)
		{
			this.GoodsTypeId = goodsTypeId;
			this.ContentId = contentId;
			this.Nums = nums;
			this.InstanceId = instanceId;
			this.UpdateConfigData();
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x0017C3E0 File Offset: 0x0017A5E0
		public virtual BagItemBase Clone()
		{
			return new BagItemBase(this.GoodsTypeId, this.ContentId, this.Nums, this.InstanceId);
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x0017C400 File Offset: 0x0017A600
		public static bool IsInstanceBagItem(GoodsType goodsTypeId)
		{
			return goodsTypeId == GoodsType.GoodsType_Equipment;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x0017C408 File Offset: 0x0017A608
		public override string ToString()
		{
			return string.Format("itemType = {0}, itemId = {1}, itemNums = {2}, instanceId = {3}", new object[]
			{
				this.GoodsTypeId,
				this.ContentId,
				this.Nums,
				this.InstanceId
			});
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x0017C460 File Offset: 0x0017A660
		public string ListItemName
		{
			get
			{
				return string.Format("{0}_{1}", this.GoodsTypeId, this.ContentId);
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x0017C490 File Offset: 0x0017A690
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x0017C484 File Offset: 0x0017A684
		public GoodsType GoodsTypeId { get; set; }

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x0017C4A4 File Offset: 0x0017A6A4
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x0017C498 File Offset: 0x0017A698
		public int ContentId { get; set; }

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x0017C4B8 File Offset: 0x0017A6B8
		// (set) Token: 0x06004E29 RID: 20009 RVA: 0x0017C4AC File Offset: 0x0017A6AC
		public int Nums { get; set; }

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x0017C4CC File Offset: 0x0017A6CC
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x0017C4C0 File Offset: 0x0017A6C0
		public ulong InstanceId { get; set; }

		// Token: 0x06004E2D RID: 20013 RVA: 0x0017C4D4 File Offset: 0x0017A6D4
		public static bool IsBagItem(GoodsType goodsType)
		{
			switch (goodsType)
			{
			case GoodsType.GoodsType_JobMaterial:
			case GoodsType.GoodsType_Item:
			case GoodsType.GoodsType_Equipment:
				break;
			default:
				if (goodsType != GoodsType.GoodsType_EnchantStone)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x0017C4FC File Offset: 0x0017A6FC
		public static bool IsMoney(GoodsType goodsType)
		{
			switch (goodsType)
			{
			case GoodsType.GoodsType_ArenaTicket:
			case GoodsType.GoodsType_ArenaHonour:
			case GoodsType.GoodsType_FriendshipPoints:
				break;
			default:
				switch (goodsType)
				{
				case GoodsType.GoodsType_SkinTicket:
				case GoodsType.GoodsType_RealTimePVPHonor:
				case GoodsType.GoodsType_MemoryEssence:
					break;
				default:
					if (goodsType != GoodsType.GoodsType_Gold && goodsType != GoodsType.GoodsType_Crystal)
					{
						return false;
					}
					break;
				}
				break;
			}
			return true;
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x0017C550 File Offset: 0x0017A750
		public bool IsEnough(int consumeNums)
		{
			return consumeNums <= this.Nums;
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x0017C560 File Offset: 0x0017A760
		public bool IsThisGoodsType(GoodsType goodsType)
		{
			return this.GoodsTypeId == goodsType;
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x0017C56C File Offset: 0x0017A76C
		public virtual ProGoods ToPBGoods()
		{
			return new ProGoods
			{
				GoodsType = (int)this.GoodsTypeId,
				Id = this.ContentId,
				Nums = this.Nums
			};
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x0017C5A4 File Offset: 0x0017A7A4
		public Goods ToGoods()
		{
			return new Goods
			{
				GoodsType = this.GoodsTypeId,
				Id = this.ContentId,
				Count = this.Nums
			};
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x0017C5E0 File Offset: 0x0017A7E0
		public static BagItemBase PBGoodsToBagItem(BagItemFactory bagItemFactory, ProGoods pbGoods)
		{
			if (BagItemBase.IsInstanceBagItem((GoodsType)pbGoods.GoodsType))
			{
				return bagItemFactory.CreateInstanceBagItemByClient(pbGoods);
			}
			return bagItemFactory.CreateBagItem((GoodsType)pbGoods.GoodsType, pbGoods.Id, pbGoods.Nums);
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x0017C614 File Offset: 0x0017A814
		public static List<BagItemBase> PBGoodsToBagItems(BagItemFactory bagItemFactory, List<ProGoods> goodsList)
		{
			List<BagItemBase> list = new List<BagItemBase>();
			foreach (ProGoods pbGoods in goodsList)
			{
				list.Add(BagItemBase.PBGoodsToBagItem(bagItemFactory, pbGoods));
			}
			return list;
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0017C678 File Offset: 0x0017A878
		public static List<ProGoods> BagItemsToPBGoods(List<BagItemBase> bagItems)
		{
			List<ProGoods> list = new List<ProGoods>();
			foreach (BagItemBase bagItemBase in bagItems)
			{
				list.Add(bagItemBase.ToPBGoods());
			}
			return list;
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x0017C6DC File Offset: 0x0017A8DC
		public static List<ProGoods> GoodsListToPBGoodsList(List<Goods> goodsList)
		{
			List<ProGoods> list = new List<ProGoods>();
			foreach (Goods goods in goodsList)
			{
				list.Add(BagItemBase.GoodsToPBGoods(goods));
			}
			return list;
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x0017C740 File Offset: 0x0017A940
		public static List<Goods> PBGoodsListToGoodsList(List<ProGoods> pbGoodsList)
		{
			List<Goods> list = new List<Goods>();
			foreach (ProGoods pbGoods in pbGoodsList)
			{
				list.Add(BagItemBase.PBGoodsToGoods(pbGoods));
			}
			return list;
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x0017C7A4 File Offset: 0x0017A9A4
		public static ProGoods GoodsToPBGoods(Goods goods)
		{
			return new ProGoods
			{
				GoodsType = (int)goods.GoodsType,
				Id = goods.Id,
				Nums = goods.Count
			};
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x0017C7DC File Offset: 0x0017A9DC
		public static Goods PBGoodsToGoods(ProGoods pbGoods)
		{
			return new Goods
			{
				GoodsType = (GoodsType)pbGoods.GoodsType,
				Id = pbGoods.Id,
				Count = pbGoods.Nums
			};
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x0017C814 File Offset: 0x0017AA14
		private void UpdateConfigData()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ItemInfo = null;
			this.JobMaterialInfo = null;
			if (this.GoodsTypeId == GoodsType.GoodsType_Item)
			{
				this.ItemInfo = configDataLoader.GetConfigDataItemInfo(this.ContentId);
			}
			else if (this.GoodsTypeId == GoodsType.GoodsType_JobMaterial)
			{
				this.JobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(this.ContentId);
			}
			else if (this.GoodsTypeId == GoodsType.GoodsType_Equipment)
			{
				this.EquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(this.ContentId);
			}
			else if (this.GoodsTypeId == GoodsType.GoodsType_EnchantStone)
			{
				this.EnchantStoneInfo = configDataLoader.GetConfigDataEnchantStoneInfo(this.ContentId);
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x0017C8D4 File Offset: 0x0017AAD4
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x0017C8C8 File Offset: 0x0017AAC8
		public ConfigDataItemInfo ItemInfo { get; private set; }

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x0017C8E8 File Offset: 0x0017AAE8
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x0017C8DC File Offset: 0x0017AADC
		public ConfigDataJobMaterialInfo JobMaterialInfo { get; private set; }

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x0017C8FC File Offset: 0x0017AAFC
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x0017C8F0 File Offset: 0x0017AAF0
		public ConfigDataEquipmentInfo EquipmentInfo { get; private set; }

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x0017C910 File Offset: 0x0017AB10
		// (set) Token: 0x06004E41 RID: 20033 RVA: 0x0017C904 File Offset: 0x0017AB04
		public ConfigDataEnchantStoneInfo EnchantStoneInfo { get; private set; }
	}
}
