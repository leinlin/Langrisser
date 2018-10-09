using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000505 RID: 1285
	[CustomLuaClass]
	public class ArenaPlayerDefensiveTeamSnapshot
	{
		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06004DCF RID: 19919 RVA: 0x0017B610 File Offset: 0x00179810
		// (set) Token: 0x06004DD0 RID: 19920 RVA: 0x0017B618 File Offset: 0x00179818
		public int BattleId { get; set; }

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06004DD1 RID: 19921 RVA: 0x0017B624 File Offset: 0x00179824
		// (set) Token: 0x06004DD2 RID: 19922 RVA: 0x0017B62C File Offset: 0x0017982C
		public int ArenaDefenderRuleId { get; set; }

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06004DD3 RID: 19923 RVA: 0x0017B638 File Offset: 0x00179838
		// (set) Token: 0x06004DD4 RID: 19924 RVA: 0x0017B640 File Offset: 0x00179840
		public int PlayerLevel { get; set; }

		// Token: 0x04003910 RID: 14608
		public List<BattleHero> DefenderHeroes = new List<BattleHero>();

		// Token: 0x04003911 RID: 14609
		public List<TrainingTech> Techs = new List<TrainingTech>();
	}
}
