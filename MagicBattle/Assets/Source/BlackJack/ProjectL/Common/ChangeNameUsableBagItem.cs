using System;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000517 RID: 1303
	[CustomLuaClass]
	public class ChangeNameUsableBagItem : UseableBagItem
	{
		// Token: 0x06004E75 RID: 20085 RVA: 0x0017D100 File Offset: 0x0017B300
		public ChangeNameUsableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x0017D110 File Offset: 0x0017B310
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			string newName = param[0] as string;
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon;
			return playerBasicInfoComponentCommon.ChangePlayerName(newName);
		}
	}
}
