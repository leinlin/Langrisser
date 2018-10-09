using System;
using BlackJack.ConfigData;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000511 RID: 1297
	public abstract class UseableBagItem : BagItemBase
	{
		// Token: 0x06004E5D RID: 20061 RVA: 0x0017CEF0 File Offset: 0x0017B0F0
		public UseableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E5E RID: 20062
		public abstract int HaveEffect(IComponentOwner owner, params object[] param);
	}
}
