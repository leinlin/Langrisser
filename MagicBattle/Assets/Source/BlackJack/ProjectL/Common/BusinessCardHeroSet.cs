using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003E5 RID: 997
	[CustomLuaClass]
	public class BusinessCardHeroSet
	{
		// Token: 0x06003B56 RID: 15190 RVA: 0x0010F4D4 File Offset: 0x0010D6D4
		public BusinessCardHeroSet()
		{
			this.Direction = HeroDirectionType.Left;
			this.Action = HeroActionType.Idle;
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x0010F4EC File Offset: 0x0010D6EC
		// (set) Token: 0x06003B58 RID: 15192 RVA: 0x0010F4F4 File Offset: 0x0010D6F4
		public int HeroId { get; set; }

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x0010F500 File Offset: 0x0010D700
		// (set) Token: 0x06003B5A RID: 15194 RVA: 0x0010F508 File Offset: 0x0010D708
		public HeroDirectionType Direction { get; set; }

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x0010F514 File Offset: 0x0010D714
		// (set) Token: 0x06003B5C RID: 15196 RVA: 0x0010F51C File Offset: 0x0010D71C
		public HeroActionType Action { get; set; }

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x0010F528 File Offset: 0x0010D728
		// (set) Token: 0x06003B5E RID: 15198 RVA: 0x0010F530 File Offset: 0x0010D730
		public int PositionIndex { get; set; }

		// Token: 0x06003B5F RID: 15199 RVA: 0x0010F53C File Offset: 0x0010D73C
		public static ProBusinessCardHeroSet ToProtocol(BusinessCardHeroSet heroSet)
		{
			return new ProBusinessCardHeroSet
			{
				HeroId = heroSet.HeroId,
				PositionIndex = heroSet.PositionIndex,
				Action = (int)heroSet.Action,
				Direction = (int)heroSet.Direction
			};
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x0010F580 File Offset: 0x0010D780
		public static List<ProBusinessCardHeroSet> ToProtocols(List<BusinessCardHeroSet> heroSets)
		{
			List<ProBusinessCardHeroSet> list = new List<ProBusinessCardHeroSet>();
			foreach (BusinessCardHeroSet heroSet in heroSets)
			{
				list.Add(BusinessCardHeroSet.ToProtocol(heroSet));
			}
			return list;
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x0010F5E4 File Offset: 0x0010D7E4
		public static BusinessCardHeroSet FromProtocol(ProBusinessCardHeroSet pbHeroSet)
		{
			return new BusinessCardHeroSet
			{
				HeroId = pbHeroSet.HeroId,
				PositionIndex = pbHeroSet.PositionIndex,
				Action = (HeroActionType)pbHeroSet.Action,
				Direction = (HeroDirectionType)pbHeroSet.Direction
			};
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x0010F628 File Offset: 0x0010D828
		public static List<BusinessCardHeroSet> FromProtocols(List<ProBusinessCardHeroSet> pbHeroSets)
		{
			List<BusinessCardHeroSet> list = new List<BusinessCardHeroSet>();
			foreach (ProBusinessCardHeroSet pbHeroSet in pbHeroSets)
			{
				list.Add(BusinessCardHeroSet.FromProtocol(pbHeroSet));
			}
			return list;
		}
	}
}
