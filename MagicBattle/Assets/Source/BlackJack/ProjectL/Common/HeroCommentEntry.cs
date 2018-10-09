using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000531 RID: 1329
	[CustomLuaClass]
	public class HeroCommentEntry
	{
		// Token: 0x06004F16 RID: 20246 RVA: 0x0017E228 File Offset: 0x0017C428
		public HeroCommentEntry()
		{
			this.CommentTime = 0L;
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x0017E238 File Offset: 0x0017C438
		public HeroCommentEntry(HeroCommentEntry other)
		{
			this.InstanceId = other.InstanceId;
			this.Content = other.Content;
			this.CommenterUserId = other.CommenterUserId;
			this.CommenterName = other.CommenterName;
			this.CommenterLevel = other.CommenterLevel;
			this.PraiseNums = other.PraiseNums;
			this.CommentTime = other.CommentTime;
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06004F18 RID: 20248 RVA: 0x0017E2A0 File Offset: 0x0017C4A0
		// (set) Token: 0x06004F19 RID: 20249 RVA: 0x0017E2A8 File Offset: 0x0017C4A8
		public ulong InstanceId { get; set; }

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06004F1A RID: 20250 RVA: 0x0017E2B4 File Offset: 0x0017C4B4
		// (set) Token: 0x06004F1B RID: 20251 RVA: 0x0017E2BC File Offset: 0x0017C4BC
		public string Content { get; set; }

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06004F1C RID: 20252 RVA: 0x0017E2C8 File Offset: 0x0017C4C8
		// (set) Token: 0x06004F1D RID: 20253 RVA: 0x0017E2D0 File Offset: 0x0017C4D0
		public string CommenterUserId { get; set; }

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06004F1E RID: 20254 RVA: 0x0017E2DC File Offset: 0x0017C4DC
		// (set) Token: 0x06004F1F RID: 20255 RVA: 0x0017E2E4 File Offset: 0x0017C4E4
		public string CommenterName { get; set; }

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06004F20 RID: 20256 RVA: 0x0017E2F0 File Offset: 0x0017C4F0
		// (set) Token: 0x06004F21 RID: 20257 RVA: 0x0017E2F8 File Offset: 0x0017C4F8
		public int CommenterLevel { get; set; }

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06004F22 RID: 20258 RVA: 0x0017E304 File Offset: 0x0017C504
		// (set) Token: 0x06004F23 RID: 20259 RVA: 0x0017E30C File Offset: 0x0017C50C
		public int PraiseNums { get; set; }

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06004F24 RID: 20260 RVA: 0x0017E318 File Offset: 0x0017C518
		// (set) Token: 0x06004F25 RID: 20261 RVA: 0x0017E320 File Offset: 0x0017C520
		public long CommentTime { get; set; }

		// Token: 0x06004F26 RID: 20262 RVA: 0x0017E32C File Offset: 0x0017C52C
		public static ProHeroCommentEntry HeroCommentEntryToPBHeroCommentEntry(HeroCommentEntry entry)
		{
			return new ProHeroCommentEntry
			{
				InstanceId = entry.InstanceId,
				Content = entry.Content,
				CommenterUserId = entry.CommenterUserId,
				CommenterName = entry.CommenterName,
				CommenterLevel = entry.CommenterLevel,
				PraiseNums = entry.PraiseNums,
				CommentTime = entry.CommentTime
			};
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0017E398 File Offset: 0x0017C598
		public static HeroCommentEntry PBHeroCommentEntryToHeroCommentEntry(ProHeroCommentEntry pbEntry)
		{
			return new HeroCommentEntry
			{
				InstanceId = pbEntry.InstanceId,
				Content = pbEntry.Content,
				CommenterUserId = pbEntry.CommenterUserId,
				CommenterName = pbEntry.CommenterName,
				CommenterLevel = pbEntry.CommenterLevel,
				PraiseNums = pbEntry.PraiseNums,
				CommentTime = pbEntry.CommentTime
			};
		}
	}
}
