using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C5 RID: 1221
	[CustomLuaClass]
	public class DataSectionComment : DataSection
	{
		// Token: 0x06004AC0 RID: 19136 RVA: 0x00174B74 File Offset: 0x00172D74
		public DataSectionComment()
		{
			this.m_playerHeroCommentEntries = new List<PlayerHeroCommentEntry>();
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00174B94 File Offset: 0x00172D94
		public override void ClearInitedData()
		{
			this.m_playerHeroCommentEntries.Clear();
			this.m_bannedTime = DateTime.MinValue;
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x00174BAC File Offset: 0x00172DAC
		public void InitPlayerHeroCommentEntry(PlayerHeroCommentEntry playerCommentEntry)
		{
			this.m_playerHeroCommentEntries.Add(playerCommentEntry);
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00174BBC File Offset: 0x00172DBC
		public PlayerHeroCommentEntry FindPlayerHeroCommentEntry(int heroId)
		{
			return this.m_playerHeroCommentEntries.Find((PlayerHeroCommentEntry m) => m.HeroId == heroId);
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00174BF0 File Offset: 0x00172DF0
		public void PraiseHeroComment(int heroId, ulong commentInstanceId)
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = this.FindPlayerHeroCommentEntry(heroId);
			if (playerHeroCommentEntry == null)
			{
				playerHeroCommentEntry = new PlayerHeroCommentEntry();
				playerHeroCommentEntry.HeroId = heroId;
				this.m_playerHeroCommentEntries.Add(playerHeroCommentEntry);
			}
			playerHeroCommentEntry.PraisedEntryInstanceIds.Add(commentInstanceId);
			base.SetDirty(true);
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00174C38 File Offset: 0x00172E38
		public void CommentHero(int heroId, HeroCommentEntry commentEntry)
		{
			PlayerHeroCommentEntry playerHeroCommentEntry = this.FindPlayerHeroCommentEntry(heroId);
			ulong instanceId = commentEntry.InstanceId;
			if (playerHeroCommentEntry == null)
			{
				playerHeroCommentEntry = new PlayerHeroCommentEntry();
				playerHeroCommentEntry.HeroId = heroId;
				this.m_playerHeroCommentEntries.Add(playerHeroCommentEntry);
				playerHeroCommentEntry.CommentedEntryInstanceIds.Add(instanceId);
			}
			else if (!playerHeroCommentEntry.CommentedEntryInstanceIds.Contains(instanceId))
			{
				playerHeroCommentEntry.CommentedEntryInstanceIds.Add(instanceId);
			}
			playerHeroCommentEntry.CommentedNums++;
			base.SetDirty(true);
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00174CB8 File Offset: 0x00172EB8
		public bool IsBanned(DateTime currentTime)
		{
			return this.m_bannedTime != DateTime.MinValue && this.m_bannedTime > currentTime;
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x00174CE0 File Offset: 0x00172EE0
		public void Ban(DateTime bannedTime)
		{
			this.m_bannedTime = bannedTime;
			base.SetDirty(true);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00174CF0 File Offset: 0x00172EF0
		public void Unban()
		{
			this.m_bannedTime = DateTime.MinValue;
			base.SetDirty(true);
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06004AC9 RID: 19145 RVA: 0x00174D04 File Offset: 0x00172F04
		// (set) Token: 0x06004ACA RID: 19146 RVA: 0x00174D0C File Offset: 0x00172F0C
		public List<PlayerHeroCommentEntry> m_playerHeroCommentEntries { get; private set; }

		// Token: 0x0400383C RID: 14396
		public DateTime m_bannedTime = DateTime.MinValue;
	}
}
