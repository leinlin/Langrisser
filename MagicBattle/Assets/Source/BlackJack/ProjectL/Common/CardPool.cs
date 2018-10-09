using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000527 RID: 1319
	[CustomLuaClass]
	public class CardPool
	{
		// Token: 0x06004EB2 RID: 20146 RVA: 0x0017D5C0 File Offset: 0x0017B7C0
		public CardPool(int poolId)
		{
			this.PoolId = poolId;
			this.SelectCardCount = 0;
			this.DisconnectCount = 0;
			this.IsFirstSignleSelect = true;
			this.IsFirstTenSelect = true;
			this.ActivityInstanceId = 0UL;
			this.SummonedRareHero = false;
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06004EB3 RID: 20147 RVA: 0x0017D5FC File Offset: 0x0017B7FC
		// (set) Token: 0x06004EB4 RID: 20148 RVA: 0x0017D604 File Offset: 0x0017B804
		public int PoolId { get; set; }

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x0017D610 File Offset: 0x0017B810
		// (set) Token: 0x06004EB6 RID: 20150 RVA: 0x0017D618 File Offset: 0x0017B818
		public bool SummonedRareHero { get; set; }

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x0017D624 File Offset: 0x0017B824
		// (set) Token: 0x06004EB8 RID: 20152 RVA: 0x0017D62C File Offset: 0x0017B82C
		public int SelectCardCount { get; set; }

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06004EB9 RID: 20153 RVA: 0x0017D638 File Offset: 0x0017B838
		// (set) Token: 0x06004EBA RID: 20154 RVA: 0x0017D640 File Offset: 0x0017B840
		public int DisconnectCount { get; set; }

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06004EBB RID: 20155 RVA: 0x0017D64C File Offset: 0x0017B84C
		// (set) Token: 0x06004EBC RID: 20156 RVA: 0x0017D654 File Offset: 0x0017B854
		public bool IsFirstSignleSelect { get; set; }

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x06004EBD RID: 20157 RVA: 0x0017D660 File Offset: 0x0017B860
		// (set) Token: 0x06004EBE RID: 20158 RVA: 0x0017D668 File Offset: 0x0017B868
		public bool IsFirstTenSelect { get; set; }

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x06004EBF RID: 20159 RVA: 0x0017D674 File Offset: 0x0017B874
		// (set) Token: 0x06004EC0 RID: 20160 RVA: 0x0017D67C File Offset: 0x0017B87C
		public ulong ActivityInstanceId { get; set; }

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x0017D688 File Offset: 0x0017B888
		// (set) Token: 0x06004EC2 RID: 20162 RVA: 0x0017D690 File Offset: 0x0017B890
		public ConfigDataCardPoolInfo Config { get; set; }

		// Token: 0x06004EC3 RID: 20163 RVA: 0x0017D69C File Offset: 0x0017B89C
		public static CardPool PBCardPoolToCardPool(ProCardPool pbCardPool)
		{
			return new CardPool(pbCardPool.CardPoolId)
			{
				SelectCardCount = pbCardPool.SelectCount,
				DisconnectCount = pbCardPool.DiscountCount
			};
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x0017D6D0 File Offset: 0x0017B8D0
		public static List<CardPool> PBActivityCardPoolsToCardPools(List<ProCardPool> pbCardPools)
		{
			List<CardPool> list = new List<CardPool>();
			foreach (ProCardPool pbCardPool in pbCardPools)
			{
				list.Add(CardPool.PBCardPoolToCardPool(pbCardPool));
			}
			return list;
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x0017D734 File Offset: 0x0017B934
		public static ProCardPool CardPoolToPBCardPool(CardPool cardPool)
		{
			if (cardPool.Config.PoolType == CardPoolType.CardPoolType_FreeCardPool)
			{
				return null;
			}
			return new ProCardPool
			{
				CardPoolId = cardPool.PoolId,
				SelectCount = cardPool.SelectCardCount,
				DiscountCount = cardPool.DisconnectCount
			};
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x0017D780 File Offset: 0x0017B980
		public static List<ProCardPool> CardPoolsToPBActivityCardPools(List<CardPool> cardPools)
		{
			List<ProCardPool> list = new List<ProCardPool>();
			foreach (CardPool cardPool in cardPools)
			{
				ProCardPool proCardPool = CardPool.CardPoolToPBCardPool(cardPool);
				if (proCardPool != null)
				{
					list.Add(proCardPool);
				}
			}
			return list;
		}
	}
}
