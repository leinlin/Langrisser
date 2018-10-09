using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000519 RID: 1305
	[CustomLuaClass]
	public class JobMaterialBagItem : BagItemBase
	{
		// Token: 0x06004E78 RID: 20088 RVA: 0x0017D150 File Offset: 0x0017B350
		public JobMaterialBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}
	}
}
