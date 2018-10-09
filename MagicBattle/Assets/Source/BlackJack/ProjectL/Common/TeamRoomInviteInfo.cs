using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000412 RID: 1042
	[CustomLuaClass]
	public class TeamRoomInviteInfo
	{
		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06003CCE RID: 15566 RVA: 0x001135B4 File Offset: 0x001117B4
		// (set) Token: 0x06003CCF RID: 15567 RVA: 0x001135BC File Offset: 0x001117BC
		public ulong SessionId { get; set; }

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x001135C8 File Offset: 0x001117C8
		// (set) Token: 0x06003CD1 RID: 15569 RVA: 0x001135D0 File Offset: 0x001117D0
		public int ChannelId { get; set; }

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x001135DC File Offset: 0x001117DC
		// (set) Token: 0x06003CD3 RID: 15571 RVA: 0x001135E4 File Offset: 0x001117E4
		public string Name { get; set; }

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x001135F0 File Offset: 0x001117F0
		// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x001135F8 File Offset: 0x001117F8
		public int Level { get; set; }

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x00113604 File Offset: 0x00111804
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x0011360C File Offset: 0x0011180C
		public int RoomId { get; set; }

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x00113618 File Offset: 0x00111818
		// (set) Token: 0x06003CD9 RID: 15577 RVA: 0x00113620 File Offset: 0x00111820
		public int GameFunctionTypeId { get; set; }

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x0011362C File Offset: 0x0011182C
		// (set) Token: 0x06003CDB RID: 15579 RVA: 0x00113634 File Offset: 0x00111834
		public int LocationId { get; set; }

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00113640 File Offset: 0x00111840
		// (set) Token: 0x06003CDD RID: 15581 RVA: 0x00113648 File Offset: 0x00111848
		public DateTime TimeOut { get; set; }

		// Token: 0x06003CDE RID: 15582 RVA: 0x00113654 File Offset: 0x00111854
		public static TeamRoomInviteInfo PbTeamRoomInviteInfoToTeamRoomInviteInfo(ProTeamRoomInviteInfo pbInfo)
		{
			return new TeamRoomInviteInfo
			{
				ChannelId = pbInfo.ChannelId,
				SessionId = pbInfo.SessionId,
				Level = pbInfo.Level,
				Name = pbInfo.Name,
				GameFunctionTypeId = pbInfo.GameFunctionTypeId,
				LocationId = pbInfo.LocationId,
				RoomId = pbInfo.RoomId,
				TimeOut = new DateTime(pbInfo.TimeOut)
			};
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x001136D0 File Offset: 0x001118D0
		public static ProTeamRoomInviteInfo TeamRoomInviteInfoToPbTeamRoomInviteInfo(TeamRoomInviteInfo info)
		{
			return new ProTeamRoomInviteInfo
			{
				ChannelId = info.ChannelId,
				SessionId = info.SessionId,
				Level = info.Level,
				Name = info.Name,
				GameFunctionTypeId = info.GameFunctionTypeId,
				LocationId = info.LocationId,
				RoomId = info.RoomId,
				TimeOut = info.TimeOut.Ticks
			};
		}
	}
}
