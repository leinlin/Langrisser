using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F5F RID: 3935
	[CustomLuaClass]
	public class TeamRoomAuthorityChangeNetTask : UINetTask
	{
		// Token: 0x0601393F RID: 80191 RVA: 0x004FD954 File Offset: 0x004FBB54
		public TeamRoomAuthorityChangeNetTask(TeamRoomAuthority authority) : base(10f, null, true)
		{
			this.m_authority = authority;
		}

		// Token: 0x06013940 RID: 80192 RVA: 0x004FD96C File Offset: 0x004FBB6C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomAuthorityChangeAck += this.OnTeamRoomAuthorityChangeAck;
		}

		// Token: 0x06013941 RID: 80193 RVA: 0x004FD9A4 File Offset: 0x004FBBA4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomAuthorityChangeAck -= this.OnTeamRoomAuthorityChangeAck;
			}
		}

		// Token: 0x06013942 RID: 80194 RVA: 0x004FD9E0 File Offset: 0x004FBBE0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomAuthorityChangeReq(this.m_authority);
		}

		// Token: 0x06013943 RID: 80195 RVA: 0x004FDA10 File Offset: 0x004FBC10
		protected void OnTeamRoomAuthorityChangeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADBA RID: 44474
		private TeamRoomAuthority m_authority;
	}
}
