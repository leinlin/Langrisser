using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000504 RID: 1284
	[CustomLuaClass]
	public class ArenaPlayerDefensiveHero
	{
		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x0017B50C File Offset: 0x0017970C
		// (set) Token: 0x06004DC6 RID: 19910 RVA: 0x0017B514 File Offset: 0x00179714
		public int HeroId { get; set; }

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06004DC7 RID: 19911 RVA: 0x0017B520 File Offset: 0x00179720
		// (set) Token: 0x06004DC8 RID: 19912 RVA: 0x0017B528 File Offset: 0x00179728
		public int ActionPositionIndex { get; set; }

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06004DC9 RID: 19913 RVA: 0x0017B534 File Offset: 0x00179734
		// (set) Token: 0x06004DCA RID: 19914 RVA: 0x0017B53C File Offset: 0x0017973C
		public int ActionValue { get; set; }

		// Token: 0x06004DCB RID: 19915 RVA: 0x0017B548 File Offset: 0x00179748
		public static ArenaPlayerDefensiveHero PBArenaDefensiveHeroToArenaDefensiveHero(ProArenaPlayerDefensiveHero pbDefensiveHero)
		{
			return new ArenaPlayerDefensiveHero
			{
				HeroId = pbDefensiveHero.HeroId,
				ActionPositionIndex = pbDefensiveHero.ActionPositionIndex,
				ActionValue = pbDefensiveHero.ActionValue
			};
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x0017B580 File Offset: 0x00179780
		public static ProArenaPlayerDefensiveHero ArenaDefensiveHeroToPBDfensiveHero(ArenaPlayerDefensiveHero defensiveHero)
		{
			return new ProArenaPlayerDefensiveHero
			{
				HeroId = defensiveHero.HeroId,
				ActionPositionIndex = defensiveHero.ActionPositionIndex,
				ActionValue = defensiveHero.ActionValue
			};
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x0017B5B8 File Offset: 0x001797B8
		public static ArenaPlayerDefensiveHero HeroToArenaDefensiveHero(Hero hero)
		{
			return new ArenaPlayerDefensiveHero
			{
				HeroId = hero.HeroId,
				ActionValue = hero.ActionValue,
				ActionPositionIndex = hero.ActionPositionIndex
			};
		}
	}
}
