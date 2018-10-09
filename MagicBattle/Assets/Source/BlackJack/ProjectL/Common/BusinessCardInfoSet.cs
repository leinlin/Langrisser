using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003E4 RID: 996
	[CustomLuaClass]
	public class BusinessCardInfoSet
	{
		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x0010F424 File Offset: 0x0010D624
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x0010F42C File Offset: 0x0010D62C
		public string Desc { get; set; }

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x0010F438 File Offset: 0x0010D638
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x0010F440 File Offset: 0x0010D640
		public bool IsActionRandom { get; set; }

		// Token: 0x06003B54 RID: 15188 RVA: 0x0010F44C File Offset: 0x0010D64C
		public static ProBusinessCardInfoSet ToProtocol(BusinessCardInfoSet set)
		{
			ProBusinessCardInfoSet proBusinessCardInfoSet = new ProBusinessCardInfoSet();
			proBusinessCardInfoSet.IsActionRandom = set.IsActionRandom;
			proBusinessCardInfoSet.Desc = set.Desc;
			proBusinessCardInfoSet.Heroes.AddRange(BusinessCardHeroSet.ToProtocols(set.Heroes));
			return proBusinessCardInfoSet;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x0010F490 File Offset: 0x0010D690
		public static BusinessCardInfoSet FromProtocol(ProBusinessCardInfoSet pbSet)
		{
			BusinessCardInfoSet businessCardInfoSet = new BusinessCardInfoSet();
			businessCardInfoSet.IsActionRandom = pbSet.IsActionRandom;
			businessCardInfoSet.Desc = pbSet.Desc;
			businessCardInfoSet.Heroes.AddRange(BusinessCardHeroSet.FromProtocols(pbSet.Heroes));
			return businessCardInfoSet;
		}

		// Token: 0x04002D1F RID: 11551
		public List<BusinessCardHeroSet> Heroes = new List<BusinessCardHeroSet>();
	}
}
