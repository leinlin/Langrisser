using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003F9 RID: 1017
	[CustomLuaClass]
	public class GuildSearchInfo
	{
		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x00110068 File Offset: 0x0010E268
		// (set) Token: 0x06003BBA RID: 15290 RVA: 0x00110070 File Offset: 0x0010E270
		public string Id { get; set; }

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06003BBB RID: 15291 RVA: 0x0011007C File Offset: 0x0010E27C
		// (set) Token: 0x06003BBC RID: 15292 RVA: 0x00110084 File Offset: 0x0010E284
		public string Name { get; set; }

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06003BBD RID: 15293 RVA: 0x00110090 File Offset: 0x0010E290
		// (set) Token: 0x06003BBE RID: 15294 RVA: 0x00110098 File Offset: 0x0010E298
		public int MemberCount { get; set; }

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06003BBF RID: 15295 RVA: 0x001100A4 File Offset: 0x0010E2A4
		// (set) Token: 0x06003BC0 RID: 15296 RVA: 0x001100AC File Offset: 0x0010E2AC
		public int JoinLevel { get; set; }

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x001100B8 File Offset: 0x0010E2B8
		// (set) Token: 0x06003BC2 RID: 15298 RVA: 0x001100C0 File Offset: 0x0010E2C0
		public int LastWeekActivities { get; set; }

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x001100CC File Offset: 0x0010E2CC
		// (set) Token: 0x06003BC4 RID: 15300 RVA: 0x001100D4 File Offset: 0x0010E2D4
		public string HiringDeclaration { get; set; }

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x001100E0 File Offset: 0x0010E2E0
		// (set) Token: 0x06003BC6 RID: 15302 RVA: 0x001100E8 File Offset: 0x0010E2E8
		public GuildMember PresidentMemberInfo { get; set; }

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x001100F4 File Offset: 0x0010E2F4
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x001100FC File Offset: 0x0010E2FC
		public bool HaveSendJoinReq { get; set; }

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00110108 File Offset: 0x0010E308
		public static ProGuildSearchInfo ToPBGuildSearchInfo(GuildSearchInfo info)
		{
			return new ProGuildSearchInfo
			{
				Id = info.Id,
				Name = info.Name,
				JoinLevel = info.JoinLevel,
				LastWeekActivities = info.LastWeekActivities,
				HiringDeclaration = info.HiringDeclaration,
				HaveSendJoinReq = info.HaveSendJoinReq,
				MemberCount = info.MemberCount,
				PresidentMemberInfo = GuildMember.ToPb(info.PresidentMemberInfo)
			};
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x00110184 File Offset: 0x0010E384
		public static GuildSearchInfo ToGuildSearchInfo(ProGuildSearchInfo proInfo)
		{
			return new GuildSearchInfo
			{
				Id = proInfo.Id,
				Name = proInfo.Name,
				JoinLevel = proInfo.JoinLevel,
				LastWeekActivities = proInfo.LastWeekActivities,
				HiringDeclaration = proInfo.HiringDeclaration,
				HaveSendJoinReq = proInfo.HaveSendJoinReq,
				MemberCount = proInfo.MemberCount,
				PresidentMemberInfo = GuildMember.FromPb(proInfo.PresidentMemberInfo)
			};
		}
	}
}
