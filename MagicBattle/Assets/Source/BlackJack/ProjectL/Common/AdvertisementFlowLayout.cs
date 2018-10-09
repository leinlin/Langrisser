using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000565 RID: 1381
	[CustomLuaClass]
	public class AdvertisementFlowLayout
	{
		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x00181994 File Offset: 0x0017FB94
		// (set) Token: 0x060050AE RID: 20654 RVA: 0x0018199C File Offset: 0x0017FB9C
		public int ActivityId { get; set; }

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x001819A8 File Offset: 0x0017FBA8
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x001819B0 File Offset: 0x0017FBB0
		public bool IsLarge { get; set; }

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x001819BC File Offset: 0x0017FBBC
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x001819C4 File Offset: 0x0017FBC4
		public int SortId { get; set; }

		// Token: 0x060050B3 RID: 20659 RVA: 0x001819D0 File Offset: 0x0017FBD0
		public static ProAdvertisementFlowLayout ToPB(AdvertisementFlowLayout layout)
		{
			return new ProAdvertisementFlowLayout
			{
				ActivityId = layout.ActivityId,
				IsLarge = layout.IsLarge,
				SortId = layout.SortId
			};
		}

		// Token: 0x060050B4 RID: 20660 RVA: 0x00181A08 File Offset: 0x0017FC08
		public static AdvertisementFlowLayout FromPB(ProAdvertisementFlowLayout pbLayout)
		{
			return new AdvertisementFlowLayout
			{
				ActivityId = pbLayout.ActivityId,
				IsLarge = pbLayout.IsLarge,
				SortId = pbLayout.SortId
			};
		}
	}
}
