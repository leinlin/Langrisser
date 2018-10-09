using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200051E RID: 1310
	[CustomLuaClass]
	public class SelfSelectedBoxBagItem : UseableBagItem
	{
		// Token: 0x06004E84 RID: 20100 RVA: 0x0017D1F0 File Offset: 0x0017B3F0
		public SelfSelectedBoxBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
			this.Result = 0;
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x0017D204 File Offset: 0x0017B404
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			return this.Result;
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x0017D20C File Offset: 0x0017B40C
		// (set) Token: 0x06004E87 RID: 20103 RVA: 0x0017D214 File Offset: 0x0017B414
		private int Result { get; set; }
	}
}
