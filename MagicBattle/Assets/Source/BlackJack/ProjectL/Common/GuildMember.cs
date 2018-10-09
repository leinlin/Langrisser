using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003F4 RID: 1012
	[CustomLuaClass]
	public class GuildMember
	{
		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x0010FC88 File Offset: 0x0010DE88
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x0010FC90 File Offset: 0x0010DE90
		public string UserId { get; set; }

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x0010FC9C File Offset: 0x0010DE9C
		// (set) Token: 0x06003B93 RID: 15251 RVA: 0x0010FCA4 File Offset: 0x0010DEA4
		public string Name { get; set; }

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x0010FCB0 File Offset: 0x0010DEB0
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x0010FCB8 File Offset: 0x0010DEB8
		public int Level { get; set; }

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x0010FCC4 File Offset: 0x0010DEC4
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x0010FCCC File Offset: 0x0010DECC
		public GuildTitle Title { get; set; }

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x0010FCD8 File Offset: 0x0010DED8
		// (set) Token: 0x06003B99 RID: 15257 RVA: 0x0010FCE0 File Offset: 0x0010DEE0
		public int TotalActivities { get; set; }

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x0010FCEC File Offset: 0x0010DEEC
		// (set) Token: 0x06003B9B RID: 15259 RVA: 0x0010FCF4 File Offset: 0x0010DEF4
		public int ThisWeekActivities { get; set; }

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x0010FD00 File Offset: 0x0010DF00
		// (set) Token: 0x06003B9D RID: 15261 RVA: 0x0010FD08 File Offset: 0x0010DF08
		public bool Online { get; set; }

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003B9E RID: 15262 RVA: 0x0010FD14 File Offset: 0x0010DF14
		// (set) Token: 0x06003B9F RID: 15263 RVA: 0x0010FD1C File Offset: 0x0010DF1C
		public DateTime LogoutTime { get; set; }

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003BA0 RID: 15264 RVA: 0x0010FD28 File Offset: 0x0010DF28
		// (set) Token: 0x06003BA1 RID: 15265 RVA: 0x0010FD30 File Offset: 0x0010DF30
		public int TopHeroBattlePower { get; set; }

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06003BA2 RID: 15266 RVA: 0x0010FD3C File Offset: 0x0010DF3C
		// (set) Token: 0x06003BA3 RID: 15267 RVA: 0x0010FD44 File Offset: 0x0010DF44
		public int HeadIcon { get; set; }

		// Token: 0x06003BA4 RID: 15268 RVA: 0x0010FD50 File Offset: 0x0010DF50
		public void WeeklyFlush()
		{
			this.ThisWeekActivities = 0;
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x0010FD5C File Offset: 0x0010DF5C
		public bool IsAdmin()
		{
			return this.Title == GuildTitle.President || this.Title == GuildTitle.VP;
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x0010FD78 File Offset: 0x0010DF78
		public static ProGuildMember ToPb(GuildMember m)
		{
			return new ProGuildMember
			{
				UserId = m.UserId,
				Name = m.Name,
				Level = m.Level,
				Title = (int)m.Title,
				TotalActivities = m.TotalActivities,
				ThisWeekActivities = m.ThisWeekActivities,
				Online = m.Online,
				LogoutTime = m.LogoutTime.Ticks,
				TopHeroBattlePower = m.TopHeroBattlePower,
				HeadIcon = m.HeadIcon
			};
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x0010FE0C File Offset: 0x0010E00C
		public static GuildMember FromPb(ProGuildMember pb)
		{
			return new GuildMember
			{
				UserId = pb.UserId,
				Name = pb.Name,
				Level = pb.Level,
				Title = (GuildTitle)pb.Title,
				TotalActivities = pb.TotalActivities,
				ThisWeekActivities = pb.ThisWeekActivities,
				Online = pb.Online,
				LogoutTime = new DateTime(pb.LogoutTime),
				TopHeroBattlePower = pb.TopHeroBattlePower,
				HeadIcon = pb.HeadIcon
			};
		}
	}
}
