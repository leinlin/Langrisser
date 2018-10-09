using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000516 RID: 1302
	[CustomLuaClass]
	public class EnergyUsableBagItem : UseableBagItem
	{
		// Token: 0x06004E71 RID: 20081 RVA: 0x0017D098 File Offset: 0x0017B298
		public EnergyUsableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x0017D0A8 File Offset: 0x0017B2A8
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon;
			playerBasicInfoComponentCommon.IncreamentEnergy((long)this.EnergyCount, true, GameFunctionType.GameFunctionType_Item, base.ContentId.ToString());
			return 0;
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x0017D0EC File Offset: 0x0017B2EC
		// (set) Token: 0x06004E74 RID: 20084 RVA: 0x0017D0F4 File Offset: 0x0017B2F4
		public int EnergyCount { get; set; }
	}
}
