using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000513 RID: 1299
	[CustomLuaClass]
	public class PlayerExpUseableBagItem : UseableBagItem
	{
		// Token: 0x06004E65 RID: 20069 RVA: 0x0017CF78 File Offset: 0x0017B178
		public PlayerExpUseableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x0017CF88 File Offset: 0x0017B188
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon;
			return playerBasicInfoComponentCommon.AddPlayerExp(this.PlayerExp);
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x0017CFB4 File Offset: 0x0017B1B4
		// (set) Token: 0x06004E68 RID: 20072 RVA: 0x0017CFBC File Offset: 0x0017B1BC
		public int PlayerExp { get; set; }
	}
}
