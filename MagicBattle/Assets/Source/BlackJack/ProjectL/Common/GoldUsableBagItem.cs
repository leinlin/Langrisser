using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000514 RID: 1300
	[CustomLuaClass]
	public class GoldUsableBagItem : UseableBagItem
	{
		// Token: 0x06004E69 RID: 20073 RVA: 0x0017CFC8 File Offset: 0x0017B1C8
		public GoldUsableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x0017CFD8 File Offset: 0x0017B1D8
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon;
			playerBasicInfoComponentCommon.AddGold(this.GoldCount, GameFunctionType.GameFunctionType_Item, base.ContentId.ToString());
			return 0;
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x0017D01C File Offset: 0x0017B21C
		// (set) Token: 0x06004E6C RID: 20076 RVA: 0x0017D024 File Offset: 0x0017B224
		public int GoldCount { get; set; }
	}
}
