using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200054A RID: 1354
	[CustomLuaClass]
	public class HeroDungeonLevel
	{
		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06004FD1 RID: 20433 RVA: 0x0017F9F8 File Offset: 0x0017DBF8
		// (set) Token: 0x06004FD2 RID: 20434 RVA: 0x0017FA00 File Offset: 0x0017DC00
		public int LevelId { get; set; }

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06004FD3 RID: 20435 RVA: 0x0017FA0C File Offset: 0x0017DC0C
		// (set) Token: 0x06004FD4 RID: 20436 RVA: 0x0017FA14 File Offset: 0x0017DC14
		public int Stars { get; set; }

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x0017FA20 File Offset: 0x0017DC20
		// (set) Token: 0x06004FD6 RID: 20438 RVA: 0x0017FA28 File Offset: 0x0017DC28
		public int Nums { get; set; }

		// Token: 0x06004FD7 RID: 20439 RVA: 0x0017FA34 File Offset: 0x0017DC34
		public static ProHeroDungeonLevel ToPBLevel(HeroDungeonLevel level)
		{
			return new ProHeroDungeonLevel
			{
				LevelId = level.LevelId,
				Nums = level.Nums,
				Stars = level.Stars
			};
		}
	}
}
