using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200056D RID: 1389
	[CustomLuaClass]
	public class RankingListInfo
	{
		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x00181FEC File Offset: 0x001801EC
		// (set) Token: 0x060050EB RID: 20715 RVA: 0x00181FF4 File Offset: 0x001801F4
		public RankingListType Type { get; set; }

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x00182000 File Offset: 0x00180200
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x00182008 File Offset: 0x00180208
		public int Score { get; set; }

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x00182014 File Offset: 0x00180214
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x0018201C File Offset: 0x0018021C
		public int CurrRank { get; set; }

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x00182028 File Offset: 0x00180228
		// (set) Token: 0x060050F1 RID: 20721 RVA: 0x00182030 File Offset: 0x00180230
		public int LastRank { get; set; }

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060050F2 RID: 20722 RVA: 0x0018203C File Offset: 0x0018023C
		// (set) Token: 0x060050F3 RID: 20723 RVA: 0x00182044 File Offset: 0x00180244
		public int ChampionHeroId { get; set; }

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060050F4 RID: 20724 RVA: 0x00182050 File Offset: 0x00180250
		// (set) Token: 0x060050F5 RID: 20725 RVA: 0x00182058 File Offset: 0x00180258
		public List<RankingTargetPlayerInfo> PlayerList { get; set; }

		// Token: 0x060050F6 RID: 20726 RVA: 0x00182064 File Offset: 0x00180264
		public static ProRankingListInfo RankingListToPBRankingList(RankingListInfo rankingList)
		{
			if (rankingList == null)
			{
				return null;
			}
			ProRankingListInfo proRankingListInfo = new ProRankingListInfo
			{
				Type = (int)rankingList.Type,
				Score = rankingList.Score,
				CurrRank = rankingList.CurrRank,
				LastRank = rankingList.LastRank,
				ChampionHeroId = rankingList.ChampionHeroId
			};
			if (rankingList.PlayerList != null)
			{
				foreach (RankingTargetPlayerInfo rankingTargetPlayerInfo in rankingList.PlayerList)
				{
					proRankingListInfo.PlayerList.Add(RankingPlayerInfo.RankingPlayerToPBRankingPlayer(rankingTargetPlayerInfo.PlayerInfo, rankingTargetPlayerInfo.Score));
				}
			}
			return proRankingListInfo;
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x00182130 File Offset: 0x00180330
		public static RankingListInfo PBRankingListToRankingList(ProRankingListInfo proRankingList)
		{
			if (proRankingList == null)
			{
				return null;
			}
			RankingListInfo rankingListInfo = new RankingListInfo
			{
				Type = (RankingListType)proRankingList.Type,
				Score = proRankingList.Score,
				CurrRank = proRankingList.CurrRank,
				LastRank = proRankingList.LastRank,
				ChampionHeroId = proRankingList.ChampionHeroId,
				PlayerList = new List<RankingTargetPlayerInfo>()
			};
			foreach (ProRankingPlayerInfo proRankingPlayerInfo in proRankingList.PlayerList)
			{
				RankingTargetPlayerInfo item = new RankingTargetPlayerInfo
				{
					Score = proRankingPlayerInfo.Score,
					PlayerInfo = RankingPlayerInfo.PBRankingPlayerToRankingPlayer(proRankingPlayerInfo)
				};
				rankingListInfo.PlayerList.Add(item);
			}
			return rankingListInfo;
		}
	}
}
