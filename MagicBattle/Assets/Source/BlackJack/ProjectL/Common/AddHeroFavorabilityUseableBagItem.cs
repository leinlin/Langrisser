using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200051F RID: 1311
	[CustomLuaClass]
	public class AddHeroFavorabilityUseableBagItem : UseableBagItem
	{
		// Token: 0x06004E88 RID: 20104 RVA: 0x0017D220 File Offset: 0x0017B420
		public AddHeroFavorabilityUseableBagItem(GoodsType goodsTypeId, int contentId, int nums, ulong instanceId) : base(goodsTypeId, contentId, nums, instanceId)
		{
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x0017D238 File Offset: 0x0017B438
		public override int HaveEffect(IComponentOwner owner, params object[] param)
		{
			HeroComponentCommon heroComponentCommon = owner.GetOwnerComponent("Hero") as HeroComponentCommon;
			this.HeroId = (int)param[0];
			int addExp = this.CalculateAddFavorabilityExp(this.HeroId);
			return heroComponentCommon.AddHeroFavorabilityLevel(this.HeroId, addExp);
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x0017D280 File Offset: 0x0017B480
		public int CalculateAddFavorabilityExp(int heroId)
		{
			int result = this.NormalAddExp;
			if (this.SpecificHeroes.Contains(heroId) || this.SpecificHeroes.Count == 0)
			{
				result = (int)(((double)this.SpecificHeroAddFavorabilityExpMultipleValue * 1.0 / 10000.0 + 1.0) * (double)this.NormalAddExp);
			}
			return result;
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x0017D2E8 File Offset: 0x0017B4E8
		// (set) Token: 0x06004E8C RID: 20108 RVA: 0x0017D2F0 File Offset: 0x0017B4F0
		private int HeroId { get; set; }

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x0017D2FC File Offset: 0x0017B4FC
		// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0017D304 File Offset: 0x0017B504
		public int NormalAddExp { get; set; }

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0017D310 File Offset: 0x0017B510
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x0017D318 File Offset: 0x0017B518
		public int SpecificHeroAddFavorabilityExpMultipleValue { get; set; }

		// Token: 0x04003956 RID: 14678
		public const int SpecificHeroAddFavorabilityExpBasicValue = 10000;

		// Token: 0x04003957 RID: 14679
		public List<int> SpecificHeroes = new List<int>();
	}
}
