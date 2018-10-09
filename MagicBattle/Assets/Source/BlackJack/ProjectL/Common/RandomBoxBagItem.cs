using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200051D RID: 1309
	[CustomLuaClass]
	public class RandomBoxBagItem : UseableBagItem
	{
		// Token: 0x06004E80 RID: 20096 RVA: 0x0017D1C0 File Offset: 0x0017B3C0
		public RandomBoxBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
			this.Result = 0;
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x0017D1D4 File Offset: 0x0017B3D4
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			return this.Result;
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06004E82 RID: 20098 RVA: 0x0017D1DC File Offset: 0x0017B3DC
		// (set) Token: 0x06004E83 RID: 20099 RVA: 0x0017D1E4 File Offset: 0x0017B3E4
		private int Result { get; set; }
	}
}
