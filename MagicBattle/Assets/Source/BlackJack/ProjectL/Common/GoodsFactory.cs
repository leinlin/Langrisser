using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200050E RID: 1294
	[CustomLuaClass]
	public class GoodsFactory
	{
		// Token: 0x06004E44 RID: 20036 RVA: 0x0017C920 File Offset: 0x0017AB20
		public static Goods CreateGoods(GoodsType goodsTypeId, int contentId, int nums)
		{
			return new Goods
			{
				GoodsType = goodsTypeId,
				Id = contentId,
				Count = nums
			};
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x0017C94C File Offset: 0x0017AB4C
		public static List<Goods> CloneGoods(List<Goods> goods)
		{
			List<Goods> list = new List<Goods>();
			foreach (Goods goods2 in goods)
			{
				Goods item = new Goods
				{
					GoodsType = goods2.GoodsType,
					Id = goods2.Id,
					Count = goods2.Count
				};
				list.Add(item);
			}
			return list;
		}
	}
}
