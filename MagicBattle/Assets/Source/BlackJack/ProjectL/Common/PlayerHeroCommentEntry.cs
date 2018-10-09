using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000532 RID: 1330
	[CustomLuaClass]
	public class PlayerHeroCommentEntry
	{
		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x06004F29 RID: 20265 RVA: 0x0017E424 File Offset: 0x0017C624
		// (set) Token: 0x06004F2A RID: 20266 RVA: 0x0017E42C File Offset: 0x0017C62C
		public int HeroId { get; set; }

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x0017E438 File Offset: 0x0017C638
		// (set) Token: 0x06004F2C RID: 20268 RVA: 0x0017E440 File Offset: 0x0017C640
		public int CommentedNums { get; set; }

		// Token: 0x06004F2D RID: 20269 RVA: 0x0017E44C File Offset: 0x0017C64C
		public static ProPlayerHeroCommentEntry PlayerHeroCommentEntryToPBPlayerHeroCommentEntry(PlayerHeroCommentEntry entry)
		{
			ProPlayerHeroCommentEntry proPlayerHeroCommentEntry = new ProPlayerHeroCommentEntry();
			proPlayerHeroCommentEntry.HeroId = entry.HeroId;
			proPlayerHeroCommentEntry.CommentedEntryInstanceIds.AddRange(entry.CommentedEntryInstanceIds);
			proPlayerHeroCommentEntry.PraisedEntryInstanceIds.AddRange(entry.PraisedEntryInstanceIds);
			proPlayerHeroCommentEntry.CommentedNums = entry.CommentedNums;
			return proPlayerHeroCommentEntry;
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x0017E49C File Offset: 0x0017C69C
		public static PlayerHeroCommentEntry PBPlayerHeroCommentEntryToPlayerHeroCommentEntry(ProPlayerHeroCommentEntry pbEntry)
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = new PlayerHeroCommentEntry();
			playerHeroCommentEntry.HeroId = pbEntry.HeroId;
			playerHeroCommentEntry.CommentedEntryInstanceIds.AddRange(pbEntry.CommentedEntryInstanceIds);
			foreach (ulong item in pbEntry.PraisedEntryInstanceIds)
			{
				playerHeroCommentEntry.PraisedEntryInstanceIds.Add(item);
			}
			playerHeroCommentEntry.CommentedNums = pbEntry.CommentedNums;
			return playerHeroCommentEntry;
		}

		// Token: 0x040039A1 RID: 14753
		public List<ulong> CommentedEntryInstanceIds = new List<ulong>();

		// Token: 0x040039A2 RID: 14754
		public HashSet<ulong> PraisedEntryInstanceIds = new HashSet<ulong>();
	}
}
