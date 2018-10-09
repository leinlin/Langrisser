using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200040C RID: 1036
	[CustomLuaClass]
	public class TeamRoom
	{
		// Token: 0x06003CA7 RID: 15527 RVA: 0x0011319C File Offset: 0x0011139C
		public TeamRoom()
		{
			this.Players = new List<TeamRoomPlayer>();
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06003CA8 RID: 15528 RVA: 0x001131B0 File Offset: 0x001113B0
		// (set) Token: 0x06003CA9 RID: 15529 RVA: 0x001131B8 File Offset: 0x001113B8
		public int RoomId { get; set; }

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06003CAA RID: 15530 RVA: 0x001131C4 File Offset: 0x001113C4
		// (set) Token: 0x06003CAB RID: 15531 RVA: 0x001131CC File Offset: 0x001113CC
		public TeamRoomPlayer Leader { get; set; }

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x06003CAC RID: 15532 RVA: 0x001131D8 File Offset: 0x001113D8
		// (set) Token: 0x06003CAD RID: 15533 RVA: 0x001131E0 File Offset: 0x001113E0
		public List<TeamRoomPlayer> Players { get; set; }

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06003CAE RID: 15534 RVA: 0x001131EC File Offset: 0x001113EC
		// (set) Token: 0x06003CAF RID: 15535 RVA: 0x001131F4 File Offset: 0x001113F4
		public DateTime LeaderKickOutTime { get; set; }

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x00113200 File Offset: 0x00111400
		// (set) Token: 0x06003CB1 RID: 15537 RVA: 0x00113208 File Offset: 0x00111408
		public TeamRoomSetting Setting { get; set; }

		// Token: 0x06003CB2 RID: 15538 RVA: 0x00113214 File Offset: 0x00111414
		public bool IsLeader(TeamRoomPlayer player)
		{
			return player == this.Leader;
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00113220 File Offset: 0x00111420
		public bool IsLeaderBySessionId(ulong sessionId)
		{
			return this.Leader.SessionId == sessionId;
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00113230 File Offset: 0x00111430
		public void JoinTeamRoom(TeamRoomPlayer player)
		{
			this.Players.Add(player);
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00113240 File Offset: 0x00111440
		public void QuitTeamRoom(TeamRoomPlayer player)
		{
			this.Players.Remove(player);
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x00113250 File Offset: 0x00111450
		public TeamRoomPlayer FindTeamRoomPlayer(ulong sessionId)
		{
			return this.Players.Find((TeamRoomPlayer m) => m.SessionId == sessionId);
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00113284 File Offset: 0x00111484
		public TeamRoomPlayer FindTeamRoomPlayerAtPosition(int position)
		{
			return this.Players.Find((TeamRoomPlayer m) => m.Position == position);
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x001132B8 File Offset: 0x001114B8
		public static ProTeamRoom TeamRoomToPbTeamRoom(TeamRoom room)
		{
			ProTeamRoom proTeamRoom = new ProTeamRoom
			{
				RoomId = room.RoomId,
				LeaderPosition = room.Leader.Position,
				LeaderKickOutTime = room.LeaderKickOutTime.Ticks
			};
			proTeamRoom.Setting = TeamRoomSetting.TeamRoomSettingToPbTeamRoomSetting(room.Setting);
			foreach (TeamRoomPlayer player in room.Players)
			{
				proTeamRoom.Players.Add(TeamRoomPlayer.TeamRoomPlayerToPbTeamRoomPlayer(player));
			}
			return proTeamRoom;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x0011336C File Offset: 0x0011156C
		public static TeamRoom PbTeamRoomToTeamRoom(ProTeamRoom pbRoom)
		{
			TeamRoom teamRoom = new TeamRoom
			{
				RoomId = pbRoom.RoomId,
				LeaderKickOutTime = new DateTime(pbRoom.LeaderKickOutTime)
			};
			teamRoom.Setting = TeamRoomSetting.PbTeamRoomSettingToTeamRoomSetting(pbRoom.Setting);
			foreach (ProTeamRoomPlayer pbPlayer in pbRoom.Players)
			{
				teamRoom.Players.Add(TeamRoomPlayer.PbTeamRoomPlayerToTeamRoomPlayer(pbPlayer));
			}
			teamRoom.Leader = teamRoom.Players.Find((TeamRoomPlayer m) => m.Position == pbRoom.LeaderPosition);
			return teamRoom;
		}
	}
}
