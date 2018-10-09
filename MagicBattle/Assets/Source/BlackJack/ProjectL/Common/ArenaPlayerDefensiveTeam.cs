using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000503 RID: 1283
	[CustomLuaClass]
	public class ArenaPlayerDefensiveTeam
	{
		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x0017B3CC File Offset: 0x001795CC
		// (set) Token: 0x06004DBF RID: 19903 RVA: 0x0017B3D4 File Offset: 0x001795D4
		public byte BattleId { get; set; }

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x0017B3E0 File Offset: 0x001795E0
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x0017B3E8 File Offset: 0x001795E8
		public byte ArenaDefenderRuleId { get; set; }

		// Token: 0x06004DC2 RID: 19906 RVA: 0x0017B3F4 File Offset: 0x001795F4
		public static ArenaPlayerDefensiveTeam PBArenaDefensiveTeamToArenaDefensiveTeam(ProArenaPlayerDefensiveTeam pbDefensiveTeam)
		{
			ArenaPlayerDefensiveTeam arenaPlayerDefensiveTeam = new ArenaPlayerDefensiveTeam();
			arenaPlayerDefensiveTeam.BattleId = (byte)pbDefensiveTeam.BattleId;
			arenaPlayerDefensiveTeam.ArenaDefenderRuleId = (byte)pbDefensiveTeam.ArenaDefenderRuleId;
			foreach (ProArenaPlayerDefensiveHero pbDefensiveHero in pbDefensiveTeam.DefenderHeroes)
			{
				arenaPlayerDefensiveTeam.Heroes.Add(ArenaPlayerDefensiveHero.PBArenaDefensiveHeroToArenaDefensiveHero(pbDefensiveHero));
			}
			return arenaPlayerDefensiveTeam;
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x0017B47C File Offset: 0x0017967C
		public static ProArenaPlayerDefensiveTeam ArenaDefensiveTeamToPBArenaDefensiveTeam(ArenaPlayerDefensiveTeam defensiveTeam)
		{
			ProArenaPlayerDefensiveTeam proArenaPlayerDefensiveTeam = new ProArenaPlayerDefensiveTeam();
			proArenaPlayerDefensiveTeam.BattleId = (int)defensiveTeam.BattleId;
			proArenaPlayerDefensiveTeam.ArenaDefenderRuleId = (int)defensiveTeam.ArenaDefenderRuleId;
			foreach (ArenaPlayerDefensiveHero defensiveHero in defensiveTeam.Heroes)
			{
				proArenaPlayerDefensiveTeam.DefenderHeroes.Add(ArenaPlayerDefensiveHero.ArenaDefensiveHeroToPBDfensiveHero(defensiveHero));
			}
			return proArenaPlayerDefensiveTeam;
		}

		// Token: 0x04003909 RID: 14601
		public List<ArenaPlayerDefensiveHero> Heroes = new List<ArenaPlayerDefensiveHero>();
	}
}
