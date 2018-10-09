using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000512 RID: 1298
	[CustomLuaClass]
	public class HeroExpUseableBagItem : UseableBagItem
	{
		// Token: 0x06004E5F RID: 20063 RVA: 0x0017CF00 File Offset: 0x0017B100
		public HeroExpUseableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x0017CF10 File Offset: 0x0017B110
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			this.HeroId = (int)param[0];
			HeroComponentCommon heroComponentCommon = owner.GetOwnerComponent("Hero") as HeroComponentCommon;
			return heroComponentCommon.AddHeroExp(this.HeroId, this.HeroExp);
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x0017CF50 File Offset: 0x0017B150
		// (set) Token: 0x06004E62 RID: 20066 RVA: 0x0017CF58 File Offset: 0x0017B158
		private int HeroId { get; set; }

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x0017CF64 File Offset: 0x0017B164
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x0017CF6C File Offset: 0x0017B16C
		public int HeroExp { get; set; }
	}
}
