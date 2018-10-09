using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200051A RID: 1306
	[CustomLuaClass]
	public class EnchantStoneBagItem : BagItemBase
	{
		// Token: 0x06004E79 RID: 20089 RVA: 0x0017D160 File Offset: 0x0017B360
		public EnchantStoneBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}
	}
}
