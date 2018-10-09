using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200053D RID: 1341
	[CustomLuaClass]
	public class GiftStoreOperationalGoods
	{
		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x0017F204 File Offset: 0x0017D404
		// (set) Token: 0x06004F8C RID: 20364 RVA: 0x0017F20C File Offset: 0x0017D40C
		public int GoodsId { get; set; }

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x0017F218 File Offset: 0x0017D418
		// (set) Token: 0x06004F8E RID: 20366 RVA: 0x0017F220 File Offset: 0x0017D420
		public DateTime SaleStartTime { get; set; }

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x0017F22C File Offset: 0x0017D42C
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x0017F234 File Offset: 0x0017D434
		public DateTime SaleEndTime { get; set; }

		// Token: 0x06004F91 RID: 20369 RVA: 0x0017F240 File Offset: 0x0017D440
		public static ProGiftStoreOperationalGoods ToPB(GiftStoreOperationalGoods goods)
		{
			return new ProGiftStoreOperationalGoods
			{
				GoodsId = goods.GoodsId,
				SaleStartTime = goods.SaleStartTime.Ticks,
				SaleEndTime = goods.SaleEndTime.Ticks
			};
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x0017F288 File Offset: 0x0017D488
		public static GiftStoreOperationalGoods FromPB(ProGiftStoreOperationalGoods pbGoods)
		{
			return new GiftStoreOperationalGoods
			{
				GoodsId = pbGoods.GoodsId,
				SaleStartTime = new DateTime(pbGoods.SaleStartTime),
				SaleEndTime = new DateTime(pbGoods.SaleEndTime)
			};
		}
	}
}
