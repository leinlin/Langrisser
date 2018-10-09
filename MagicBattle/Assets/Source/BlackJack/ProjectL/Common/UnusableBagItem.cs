using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000518 RID: 1304
	[CustomLuaClass]
	public class UnusableBagItem : BagItemBase
	{
		// Token: 0x06004E77 RID: 20087 RVA: 0x0017D140 File Offset: 0x0017B340
		public UnusableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}
	}
}
