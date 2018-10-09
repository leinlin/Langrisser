using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F63 RID: 3939
	[CustomLuaClass]
	public class TeamRoomInviteNetTask : UINetTask
	{
		// Token: 0x06013955 RID: 80213 RVA: 0x004FDCB0 File Offset: 0x004FBEB0
		public TeamRoomInviteNetTask(List<string> inviteeUserIds) : base(10f, null, true)
		{
			this.m_inviteeUserIds = new List<string>(inviteeUserIds);
		}

		// Token: 0x06013956 RID: 80214 RVA: 0x004FDCCC File Offset: 0x004FBECC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomInviteAck += this.OnTeamRoomInviteAck;
		}

		// Token: 0x06013957 RID: 80215 RVA: 0x004FDD04 File Offset: 0x004FBF04
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomInviteAck -= this.OnTeamRoomInviteAck;
			}
		}

		// Token: 0x06013958 RID: 80216 RVA: 0x004FDD40 File Offset: 0x004FBF40
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomInviteReq(this.m_inviteeUserIds);
		}

		// Token: 0x06013959 RID: 80217 RVA: 0x004FDD70 File Offset: 0x004FBF70
		protected void OnTeamRoomInviteAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADC0 RID: 44480
		private List<string> m_inviteeUserIds;
	}
}
