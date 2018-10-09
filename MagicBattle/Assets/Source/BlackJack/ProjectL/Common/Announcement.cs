using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000501 RID: 1281
	[CustomLuaClass]
	public class Announcement
	{
		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004D8A RID: 19850 RVA: 0x0017AE9C File Offset: 0x0017909C
		// (set) Token: 0x06004D8B RID: 19851 RVA: 0x0017AEA4 File Offset: 0x001790A4
		public ulong InstanceId { get; set; }

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x0017AEB0 File Offset: 0x001790B0
		// (set) Token: 0x06004D8D RID: 19853 RVA: 0x0017AEB8 File Offset: 0x001790B8
		public DateTime ShowStartTime { get; set; }

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x0017AEC4 File Offset: 0x001790C4
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x0017AECC File Offset: 0x001790CC
		public DateTime ShowEndTime { get; set; }

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x0017AED8 File Offset: 0x001790D8
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0017AEE0 File Offset: 0x001790E0
		public string Title { get; set; }

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x0017AEEC File Offset: 0x001790EC
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x0017AEF4 File Offset: 0x001790F4
		public string Content { get; set; }

		// Token: 0x06004D94 RID: 19860 RVA: 0x0017AF00 File Offset: 0x00179100
		public static Announcement PBAnnouncementToAnnouncement(ProAnnouncement pbAnnouncement)
		{
			return new Announcement
			{
				InstanceId = pbAnnouncement.InstanceId,
				ShowStartTime = new DateTime(pbAnnouncement.ShowStartTime),
				ShowEndTime = new DateTime(pbAnnouncement.ShowEndTime),
				Title = pbAnnouncement.Title,
				Content = pbAnnouncement.Content
			};
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x0017AF5C File Offset: 0x0017915C
		public static ProAnnouncement AnnouncementToPBAnnouncement(Announcement announcement)
		{
			return new ProAnnouncement
			{
				InstanceId = announcement.InstanceId,
				ShowStartTime = announcement.ShowStartTime.Ticks,
				ShowEndTime = announcement.ShowEndTime.Ticks,
				Title = announcement.Title,
				Content = announcement.Content
			};
		}
	}
}
