using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004FC RID: 1276
	[CustomLuaClass]
	public class DataSectionTeam : DataSection
	{
		// Token: 0x06004D54 RID: 19796 RVA: 0x0017A6DC File Offset: 0x001788DC
		public DataSectionTeam()
		{
			this.m_inviteInfos = new Dictionary<string, TeamRoomInviteInfo>();
			this.LastInviteSendTime = DateTime.MinValue;
			this.ClearTeamRoom();
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x0017A700 File Offset: 0x00178900
		public override void ClearInitedData()
		{
			this.ClearInviteInfos();
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x0017A708 File Offset: 0x00178908
		public void ClearTeamRoom()
		{
			this.RoomId = 0;
			GameFunctionType gameFunctionType = GameFunctionType.GameFunctionType_None;
			this.WaitingFunctionTypeId = gameFunctionType;
			this.GameFunctionTypeId = gameFunctionType;
			int num = 0;
			this.WaitingLocationId = num;
			this.LocationId = num;
			this.ClearInviteInfos();
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x0017A744 File Offset: 0x00178944
		public void ClearInviteInfos()
		{
			this.m_inviteInfos.Clear();
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x0017A754 File Offset: 0x00178954
		public void ClearAInviteInfo(ulong sessionId, int roomId)
		{
			string key = this.BuildInviteInfoKey(sessionId, roomId);
			this.m_inviteInfos.Remove(key);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x0017A778 File Offset: 0x00178978
		public bool IsInvited(ulong sessionId, int roomId)
		{
			string key = this.BuildInviteInfoKey(sessionId, roomId);
			return this.m_inviteInfos.ContainsKey(key);
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x0017A79C File Offset: 0x0017899C
		public List<TeamRoomInviteInfo> GetInviteInfos()
		{
			return this.m_inviteInfos.Values.ToList<TeamRoomInviteInfo>();
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x0017A7B0 File Offset: 0x001789B0
		public override object SerializeToClient()
		{
			DSTeamNtf dsteamNtf = new DSTeamNtf();
			dsteamNtf.RoomId = this.RoomId;
			dsteamNtf.GameFunctionTypeId = (int)this.GameFunctionTypeId;
			dsteamNtf.LocationId = this.LocationId;
			dsteamNtf.WaitingFunctionTypeId = (int)this.WaitingFunctionTypeId;
			dsteamNtf.WaitingLocationId = this.WaitingLocationId;
			dsteamNtf.LastInviteSendTime = this.LastInviteSendTime.Ticks;
			foreach (KeyValuePair<string, TeamRoomInviteInfo> keyValuePair in this.m_inviteInfos)
			{
				dsteamNtf.InviteInfos.Add(TeamRoomInviteInfo.TeamRoomInviteInfoToPbTeamRoomInviteInfo(keyValuePair.Value));
			}
			return dsteamNtf;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x0017A874 File Offset: 0x00178A74
		private string BuildInviteInfoKey(ulong sessionId, int roomId)
		{
			return CombineStringTools.BuildParam(new object[]
			{
				sessionId,
				roomId
			});
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x0017A894 File Offset: 0x00178A94
		public bool SetTeamRoomInviteInfo(TeamRoomInviteInfo info)
		{
			string key = this.BuildInviteInfoKey(info.SessionId, info.RoomId);
			if (this.m_inviteInfos.ContainsKey(key))
			{
				return false;
			}
			this.m_inviteInfos.Add(key, info);
			return true;
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x0017A8D8 File Offset: 0x00178AD8
		// (set) Token: 0x06004D5F RID: 19807 RVA: 0x0017A8E0 File Offset: 0x00178AE0
		public int RoomId { get; set; }

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x0017A8EC File Offset: 0x00178AEC
		// (set) Token: 0x06004D61 RID: 19809 RVA: 0x0017A8F4 File Offset: 0x00178AF4
		public GameFunctionType GameFunctionTypeId { get; set; }

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x0017A900 File Offset: 0x00178B00
		// (set) Token: 0x06004D63 RID: 19811 RVA: 0x0017A908 File Offset: 0x00178B08
		public int LocationId { get; set; }

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x0017A914 File Offset: 0x00178B14
		// (set) Token: 0x06004D65 RID: 19813 RVA: 0x0017A91C File Offset: 0x00178B1C
		public GameFunctionType WaitingFunctionTypeId { get; set; }

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x0017A928 File Offset: 0x00178B28
		// (set) Token: 0x06004D67 RID: 19815 RVA: 0x0017A930 File Offset: 0x00178B30
		public int WaitingLocationId { get; set; }

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x0017A93C File Offset: 0x00178B3C
		// (set) Token: 0x06004D69 RID: 19817 RVA: 0x0017A944 File Offset: 0x00178B44
		public DateTime LastInviteSendTime { get; set; }

		// Token: 0x040038EA RID: 14570
		private Dictionary<string, TeamRoomInviteInfo> m_inviteInfos;
	}
}
