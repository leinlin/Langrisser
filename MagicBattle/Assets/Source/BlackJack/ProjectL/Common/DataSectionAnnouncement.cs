using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004BB RID: 1211
	[CustomLuaClass]
	public class DataSectionAnnouncement : DataSection
	{
		// Token: 0x06004A21 RID: 18977 RVA: 0x001738F0 File Offset: 0x00171AF0
		public DataSectionAnnouncement()
		{
			this.m_announcements = new List<Announcement>();
			this.ClientCurrentVersion = 0u;
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x0017390C File Offset: 0x00171B0C
		public override void ClearInitedData()
		{
			this.m_announcements.Clear();
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x0017391C File Offset: 0x00171B1C
		public override object SerializeToClient()
		{
			DSAnnouncementNtf dsannouncementNtf = new DSAnnouncementNtf();
			dsannouncementNtf.Version = this.ClientCurrentVersion;
			foreach (Announcement announcement in this.m_announcements)
			{
				dsannouncementNtf.Announcements.Add(Announcement.AnnouncementToPBAnnouncement(announcement));
			}
			return dsannouncementNtf;
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00173998 File Offset: 0x00171B98
		public void InitAnnouncements(List<Announcement> announcements)
		{
			this.m_announcements.AddRange(announcements);
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x001739A8 File Offset: 0x00171BA8
		public void SetAnnouncements(List<Announcement> announcements)
		{
			this.m_announcements.Clear();
			this.m_announcements.AddRange(announcements);
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x001739C4 File Offset: 0x00171BC4
		public void SetClientAnnouncementCurrentVersion(uint currentVersion)
		{
			this.ClientCurrentVersion = currentVersion;
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x001739D0 File Offset: 0x00171BD0
		public void SetServerAnnouncementCurrentVersion(int serverCurrentVersion)
		{
			if ((long)serverCurrentVersion != (long)((ulong)this.ClientCurrentVersion))
			{
				this.ClientCurrentVersion = (uint)serverCurrentVersion;
				base.SetDirty(true);
			}
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x001739F0 File Offset: 0x00171BF0
		public void RemoveAnnouncement(Announcement announcement)
		{
			this.m_announcements.Remove(announcement);
			base.SetDirty(true);
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x00173A08 File Offset: 0x00171C08
		public List<Announcement> FindAnnouncementsByCondition(Predicate<Announcement> isConditionMatched)
		{
			return this.m_announcements.FindAll((Announcement t) => isConditionMatched(t));
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00173A3C File Offset: 0x00171C3C
		public Announcement FindAnnouncementsByInstanceId(ulong instanceId)
		{
			return this.m_announcements.Find((Announcement t) => t.InstanceId == instanceId);
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00173A70 File Offset: 0x00171C70
		public void AddAnnouncement(Announcement announcement)
		{
			this.m_announcements.Add(announcement);
			base.SetDirty(true);
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06004A2C RID: 18988 RVA: 0x00173A88 File Offset: 0x00171C88
		// (set) Token: 0x06004A2D RID: 18989 RVA: 0x00173A90 File Offset: 0x00171C90
		public uint ClientCurrentVersion { get; set; }

		// Token: 0x04003820 RID: 14368
		private List<Announcement> m_announcements;
	}
}
