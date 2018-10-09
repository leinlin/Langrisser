using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200051C RID: 1308
	[CustomLuaClass]
	public class StaticBoxBagItem : UseableBagItem
	{
		// Token: 0x06004E7C RID: 20092 RVA: 0x0017D190 File Offset: 0x0017B390
		public StaticBoxBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
			this.Result = 0;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x0017D1A4 File Offset: 0x0017B3A4
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			return this.Result;
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06004E7E RID: 20094 RVA: 0x0017D1AC File Offset: 0x0017B3AC
		// (set) Token: 0x06004E7F RID: 20095 RVA: 0x0017D1B4 File Offset: 0x0017B3B4
		private int Result { get; set; }
	}
}
