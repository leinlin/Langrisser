using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F60 RID: 3936
	[CustomLuaClass]
	public class TeamRoomJoinNetTask : UINetTask
	{
		// Token: 0x06013944 RID: 80196 RVA: 0x004FDA20 File Offset: 0x004FBC20
		public TeamRoomJoinNetTask(int roomId, GameFunctionType gameFunctionTypeId, int locationId, ulong inviterSessionId) : base(10f, null, true)
		{
			this.m_roomId = roomId;
			this.m_gameFunctionTypeId = gameFunctionTypeId;
			this.m_locationId = locationId;
			this.m_inviterSessionId = inviterSessionId;
		}

		// Token: 0x06013945 RID: 80197 RVA: 0x004FDA4C File Offset: 0x004FBC4C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomJoinAck += this.OnTeamRoomJoinAck;
		}

		// Token: 0x06013946 RID: 80198 RVA: 0x004FDA84 File Offset: 0x004FBC84
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomJoinAck -= this.OnTeamRoomJoinAck;
			}
		}

		// Token: 0x06013947 RID: 80199 RVA: 0x004FDAC0 File Offset: 0x004FBCC0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomJoinReq(this.m_roomId, this.m_gameFunctionTypeId, this.m_locationId, this.m_inviterSessionId);
		}

		// Token: 0x06013948 RID: 80200 RVA: 0x004FDB04 File Offset: 0x004FBD04
		protected void OnTeamRoomJoinAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADBB RID: 44475
		private int m_roomId;

		// Token: 0x0400ADBC RID: 44476
		private GameFunctionType m_gameFunctionTypeId;

		// Token: 0x0400ADBD RID: 44477
		private int m_locationId;

		// Token: 0x0400ADBE RID: 44478
		private ulong m_inviterSessionId;
	}
}
