using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000530 RID: 1328
	[CustomLuaClass]
	public class HeroComment
	{
		// Token: 0x06004F0F RID: 20239 RVA: 0x0017E0EC File Offset: 0x0017C2EC
		public HeroComment()
		{
			this.LastUpdateTime = 0L;
			this.CommentEntries = new List<HeroCommentEntry>();
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06004F10 RID: 20240 RVA: 0x0017E108 File Offset: 0x0017C308
		// (set) Token: 0x06004F11 RID: 20241 RVA: 0x0017E110 File Offset: 0x0017C310
		public long LastUpdateTime { get; set; }

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06004F12 RID: 20242 RVA: 0x0017E11C File Offset: 0x0017C31C
		// (set) Token: 0x06004F13 RID: 20243 RVA: 0x0017E124 File Offset: 0x0017C324
		public List<HeroCommentEntry> CommentEntries { get; set; }

		// Token: 0x06004F14 RID: 20244 RVA: 0x0017E130 File Offset: 0x0017C330
		public static ProHeroComment HeroCommentToPBHeroComment(HeroComment comment)
		{
			ProHeroComment proHeroComment = new ProHeroComment();
			proHeroComment.LastUpdateTime = comment.LastUpdateTime;
			foreach (HeroCommentEntry entry in comment.CommentEntries)
			{
				proHeroComment.CommentEntries.Add(HeroCommentEntry.HeroCommentEntryToPBHeroCommentEntry(entry));
			}
			return proHeroComment;
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x0017E1AC File Offset: 0x0017C3AC
		public static HeroComment PBHeroCommentToHeroComment(ProHeroComment pbComment)
		{
			HeroComment heroComment = new HeroComment();
			heroComment.LastUpdateTime = pbComment.LastUpdateTime;
			foreach (ProHeroCommentEntry pbEntry in pbComment.CommentEntries)
			{
				heroComment.CommentEntries.Add(HeroCommentEntry.PBHeroCommentEntryToHeroCommentEntry(pbEntry));
			}
			return heroComment;
		}
	}
}
