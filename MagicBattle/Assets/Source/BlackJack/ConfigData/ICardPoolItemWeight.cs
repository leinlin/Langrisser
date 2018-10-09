using System;
using System.Collections.Generic;

namespace BlackJack.ConfigData
{
	// Token: 0x02000350 RID: 848
	public interface ICardPoolItemWeight
	{
		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06003138 RID: 12600
		int CardPoolItemID { get; }

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06003139 RID: 12601
		List<Goods> Items { get; }

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x0600313A RID: 12602
		int ItemDefaultWeight { get; }
	}
}
