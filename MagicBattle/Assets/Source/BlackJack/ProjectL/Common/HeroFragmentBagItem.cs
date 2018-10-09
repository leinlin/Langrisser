using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200051B RID: 1307
	[CustomLuaClass]
	public class HeroFragmentBagItem : BagItemBase
	{
		// Token: 0x06004E7A RID: 20090 RVA: 0x0017D170 File Offset: 0x0017B370
		public HeroFragmentBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x0017D180 File Offset: 0x0017B380
		public int GetAllExchangeMemoryEssence()
		{
			return base.Nums * this.ExchangeMemoryEssence;
		}

		// Token: 0x0400394F RID: 14671
		public int ExchangeMemoryEssence;
	}
}
