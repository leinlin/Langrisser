using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000515 RID: 1301
	[CustomLuaClass]
	public class CrystalUsableBagItem : UseableBagItem
	{
		// Token: 0x06004E6D RID: 20077 RVA: 0x0017D030 File Offset: 0x0017B230
		public CrystalUsableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x0017D040 File Offset: 0x0017B240
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon;
			playerBasicInfoComponentCommon.AddCrystal(this.CrystalCount, GameFunctionType.GameFunctionType_Item, base.ContentId.ToString());
			return 0;
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004E6F RID: 20079 RVA: 0x0017D084 File Offset: 0x0017B284
		// (set) Token: 0x06004E70 RID: 20080 RVA: 0x0017D08C File Offset: 0x0017B28C
		public int CrystalCount { get; set; }
	}
}
