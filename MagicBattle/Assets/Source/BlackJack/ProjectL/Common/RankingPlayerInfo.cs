using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200056B RID: 1387
	[CustomLuaClass]
	public class RankingPlayerInfo
	{
		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060050D6 RID: 20694 RVA: 0x00181EAC File Offset: 0x001800AC
		// (set) Token: 0x060050D7 RID: 20695 RVA: 0x00181EB4 File Offset: 0x001800B4
		public string UserId { get; set; }

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060050D8 RID: 20696 RVA: 0x00181EC0 File Offset: 0x001800C0
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x00181EC8 File Offset: 0x001800C8
		public int HeadIcon { get; set; }

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060050DA RID: 20698 RVA: 0x00181ED4 File Offset: 0x001800D4
		// (set) Token: 0x060050DB RID: 20699 RVA: 0x00181EDC File Offset: 0x001800DC
		public int Level { get; set; }

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060050DC RID: 20700 RVA: 0x00181EE8 File Offset: 0x001800E8
		// (set) Token: 0x060050DD RID: 20701 RVA: 0x00181EF0 File Offset: 0x001800F0
		public string Name { get; set; }

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x00181EFC File Offset: 0x001800FC
		// (set) Token: 0x060050DF RID: 20703 RVA: 0x00181F04 File Offset: 0x00180104
		public int ChampionHeroId { get; set; }

		// Token: 0x060050E0 RID: 20704 RVA: 0x00181F10 File Offset: 0x00180110
		public static ProRankingPlayerInfo RankingPlayerToPBRankingPlayer(RankingPlayerInfo playerInfo, int score)
		{
			return new ProRankingPlayerInfo
			{
				HeadIcon = playerInfo.HeadIcon,
				Level = playerInfo.Level,
				Name = playerInfo.Name,
				ChampionHeroId = playerInfo.ChampionHeroId,
				Score = score
			};
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00181F5C File Offset: 0x0018015C
		public static RankingPlayerInfo PBRankingPlayerToRankingPlayer(ProRankingPlayerInfo proPlayerInfo)
		{
			return new RankingPlayerInfo
			{
				HeadIcon = proPlayerInfo.HeadIcon,
				Level = proPlayerInfo.Level,
				Name = proPlayerInfo.Name,
				ChampionHeroId = proPlayerInfo.ChampionHeroId
			};
		}
	}
}
