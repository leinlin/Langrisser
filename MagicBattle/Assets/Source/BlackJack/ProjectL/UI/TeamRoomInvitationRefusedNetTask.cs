using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F64 RID: 3940
	[CustomLuaClass]
	public class TeamRoomInvitationRefusedNetTask : UINetTask
	{
		// Token: 0x0601395A RID: 80218 RVA: 0x004FDD80 File Offset: 0x004FBF80
		public TeamRoomInvitationRefusedNetTask(ulong inviterSessionId, int inviterChannelId, int roomId) : base(10f, null, true)
		{
			this.m_inviterSessionId = inviterSessionId;
			this.m_inviterChannelId = inviterChannelId;
			this.m_roomId = roomId;
		}

		// Token: 0x0601395B RID: 80219 RVA: 0x004FDDA4 File Offset: 0x004FBFA4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomInvitationRefusedAck += this.OnTeamRoomInvitationRefusedAck;
		}

		// Token: 0x0601395C RID: 80220 RVA: 0x004FDDDC File Offset: 0x004FBFDC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomInvitationRefusedAck -= this.OnTeamRoomInvitationRefusedAck;
			}
		}

		// Token: 0x0601395D RID: 80221 RVA: 0x004FDE18 File Offset: 0x004FC018
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomInvitationRefusedReq(this.m_inviterSessionId, this.m_inviterChannelId, this.m_roomId);
		}

		// Token: 0x0601395E RID: 80222 RVA: 0x004FDE54 File Offset: 0x004FC054
		protected void OnTeamRoomInvitationRefusedAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADC1 RID: 44481
		private ulong m_inviterSessionId;

		// Token: 0x0400ADC2 RID: 44482
		private int m_inviterChannelId;

		// Token: 0x0400ADC3 RID: 44483
		private int m_roomId;
	}
}
