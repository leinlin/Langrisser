using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000413 RID: 1043
	[CustomLuaClass]
	public class TeamRoomPlayer
	{
		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x00113754 File Offset: 0x00111954
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x0011375C File Offset: 0x0011195C
		public string UserId { get; set; }

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x00113768 File Offset: 0x00111968
		// (set) Token: 0x06003CE4 RID: 15588 RVA: 0x00113770 File Offset: 0x00111970
		public ulong SessionId { get; set; }

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x0011377C File Offset: 0x0011197C
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x00113784 File Offset: 0x00111984
		public int ChannelId { get; set; }

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x00113790 File Offset: 0x00111990
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x00113798 File Offset: 0x00111998
		public string Name { get; set; }

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x001137A4 File Offset: 0x001119A4
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x001137AC File Offset: 0x001119AC
		public int HeadIcon { get; set; }

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x001137B8 File Offset: 0x001119B8
		// (set) Token: 0x06003CEC RID: 15596 RVA: 0x001137C0 File Offset: 0x001119C0
		public int ActiveHeroJobRelatedId { get; set; }

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x001137CC File Offset: 0x001119CC
		// (set) Token: 0x06003CEE RID: 15598 RVA: 0x001137D4 File Offset: 0x001119D4
		public int Level { get; set; }

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x001137E0 File Offset: 0x001119E0
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x001137E8 File Offset: 0x001119E8
		public int Position { get; set; }

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x001137F4 File Offset: 0x001119F4
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x001137FC File Offset: 0x001119FC
		public int ModenSkinId { get; set; }

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00113808 File Offset: 0x00111A08
		public static ProTeamRoomPlayer TeamRoomPlayerToPbTeamRoomPlayer(TeamRoomPlayer player)
		{
			return new ProTeamRoomPlayer
			{
				UserId = player.UserId,
				SessionId = player.SessionId,
				ChannelId = player.ChannelId,
				Name = player.Name,
				HeadIcon = player.HeadIcon,
				ActiveHeroJobRelatedId = player.ActiveHeroJobRelatedId,
				Level = player.Level,
				Position = player.Position,
				ModenSkinId = player.ModenSkinId
			};
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0011388C File Offset: 0x00111A8C
		public static TeamRoomPlayer PbTeamRoomPlayerToTeamRoomPlayer(ProTeamRoomPlayer pbPlayer)
		{
			return new TeamRoomPlayer
			{
				UserId = pbPlayer.UserId,
				SessionId = pbPlayer.SessionId,
				ChannelId = pbPlayer.ChannelId,
				Name = pbPlayer.Name,
				HeadIcon = pbPlayer.HeadIcon,
				ActiveHeroJobRelatedId = pbPlayer.ActiveHeroJobRelatedId,
				Level = pbPlayer.Level,
				Position = pbPlayer.Position,
				ModenSkinId = pbPlayer.ModenSkinId
			};
		}
	}
}
