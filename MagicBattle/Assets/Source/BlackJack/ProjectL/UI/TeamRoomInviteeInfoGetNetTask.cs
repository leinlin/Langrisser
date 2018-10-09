using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F66 RID: 3942
	[CustomLuaClass]
	public class TeamRoomInviteeInfoGetNetTask : UINetTask
	{
		// Token: 0x06013964 RID: 80228 RVA: 0x004FDF24 File Offset: 0x004FC124
		public TeamRoomInviteeInfoGetNetTask(List<string> inviteeUserIds, TeamRoomInviteeInfoType infoType) : base(10f, null, true)
		{
			this.m_inviteeUserIds = new List<string>(inviteeUserIds);
			this.m_infoType = infoType;
		}

		// Token: 0x06013965 RID: 80229 RVA: 0x004FDF48 File Offset: 0x004FC148
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomInviteeInfoGetAck += this.OnTeamRoomInviteeLevelInfoGetAck;
		}

		// Token: 0x06013966 RID: 80230 RVA: 0x004FDF80 File Offset: 0x004FC180
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomInviteeInfoGetAck -= this.OnTeamRoomInviteeLevelInfoGetAck;
			}
		}

		// Token: 0x06013967 RID: 80231 RVA: 0x004FDFBC File Offset: 0x004FC1BC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomInviteeInfoGetReq(this.m_inviteeUserIds, this.m_infoType);
		}

		// Token: 0x06013968 RID: 80232 RVA: 0x004FDFF4 File Offset: 0x004FC1F4
		protected void OnTeamRoomInviteeLevelInfoGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADC4 RID: 44484
		private List<string> m_inviteeUserIds;

		// Token: 0x0400ADC5 RID: 44485
		private TeamRoomInviteeInfoType m_infoType;
	}
}
