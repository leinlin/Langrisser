using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200053C RID: 1340
	[CustomLuaClass]
	public class GiftStoreItem
	{
		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004F7A RID: 20346 RVA: 0x0017F0F0 File Offset: 0x0017D2F0
		// (set) Token: 0x06004F7B RID: 20347 RVA: 0x0017F0F8 File Offset: 0x0017D2F8
		public int GoodsId { get; set; }

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004F7C RID: 20348 RVA: 0x0017F104 File Offset: 0x0017D304
		// (set) Token: 0x06004F7D RID: 20349 RVA: 0x0017F10C File Offset: 0x0017D30C
		public bool IsFirstBuy { get; set; }

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004F7E RID: 20350 RVA: 0x0017F118 File Offset: 0x0017D318
		// (set) Token: 0x06004F7F RID: 20351 RVA: 0x0017F120 File Offset: 0x0017D320
		public int BoughtNums { get; set; }

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x0017F12C File Offset: 0x0017D32C
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x0017F134 File Offset: 0x0017D334
		public DateTime NextFlushTime { get; set; }

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x0017F140 File Offset: 0x0017D340
		// (set) Token: 0x06004F83 RID: 20355 RVA: 0x0017F148 File Offset: 0x0017D348
		public DateTime SaleStartTime { get; set; }

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x0017F154 File Offset: 0x0017D354
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x0017F15C File Offset: 0x0017D35C
		public DateTime SaleEndTime { get; set; }

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x0017F168 File Offset: 0x0017D368
		// (set) Token: 0x06004F87 RID: 20359 RVA: 0x0017F170 File Offset: 0x0017D370
		public ConfigDataGiftStoreItemInfo Config { get; set; }

		// Token: 0x06004F88 RID: 20360 RVA: 0x0017F17C File Offset: 0x0017D37C
		public static ProGiftStoreItem ToPB(GiftStoreItem item)
		{
			return new ProGiftStoreItem
			{
				BoughtNums = item.BoughtNums,
				GoodsId = item.GoodsId,
				NextFlushTime = item.NextFlushTime.Ticks
			};
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x0017F1BC File Offset: 0x0017D3BC
		public static GiftStoreItem FromPB(ProGiftStoreItem pbItem)
		{
			return new GiftStoreItem
			{
				BoughtNums = pbItem.BoughtNums,
				GoodsId = pbItem.GoodsId,
				NextFlushTime = new DateTime(pbItem.NextFlushTime)
			};
		}
	}
}
