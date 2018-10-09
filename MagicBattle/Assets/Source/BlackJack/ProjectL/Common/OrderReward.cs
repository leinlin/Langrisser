using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200053E RID: 1342
	[CustomLuaClass]
	public class OrderReward
	{
		// Token: 0x06004F93 RID: 20371 RVA: 0x0017F2CC File Offset: 0x0017D4CC
		public OrderReward()
		{
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x0017F2E0 File Offset: 0x0017D4E0
		public OrderReward(string orderId)
		{
			this.OrderId = orderId;
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x0017F2FC File Offset: 0x0017D4FC
		// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0017F304 File Offset: 0x0017D504
		public string OrderId { get; set; }

		// Token: 0x06004F97 RID: 20375 RVA: 0x0017F310 File Offset: 0x0017D510
		public static ProOrderReward ToPB(OrderReward orderReward)
		{
			ProOrderReward proOrderReward = new ProOrderReward();
			proOrderReward.OrderId = orderReward.OrderId;
			proOrderReward.Rewards.AddRange(BagItemBase.GoodsListToPBGoodsList(orderReward.Rewards));
			return proOrderReward;
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x0017F348 File Offset: 0x0017D548
		public static OrderReward FromPB(ProOrderReward pbOrderReward)
		{
			OrderReward orderReward = new OrderReward();
			orderReward.OrderId = pbOrderReward.OrderId;
			orderReward.Rewards.AddRange(BagItemBase.PBGoodsListToGoodsList(pbOrderReward.Rewards));
			return orderReward;
		}

		// Token: 0x040039C5 RID: 14789
		public List<Goods> Rewards = new List<Goods>();
	}
}
