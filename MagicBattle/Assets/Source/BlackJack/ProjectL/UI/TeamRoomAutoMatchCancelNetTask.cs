using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F5E RID: 3934
	[CustomLuaClass]
	public class TeamRoomAutoMatchCancelNetTask : UINetTask
	{
		// Token: 0x0601393A RID: 80186 RVA: 0x004FD894 File Offset: 0x004FBA94
		public TeamRoomAutoMatchCancelNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0601393B RID: 80187 RVA: 0x004FD8A4 File Offset: 0x004FBAA4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomAutoMatchCancelAck += this.OnTeamRoomAutoMatchCancelAck;
		}

		// Token: 0x0601393C RID: 80188 RVA: 0x004FD8DC File Offset: 0x004FBADC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomAutoMatchCancelAck -= this.OnTeamRoomAutoMatchCancelAck;
			}
		}

		// Token: 0x0601393D RID: 80189 RVA: 0x004FD918 File Offset: 0x004FBB18
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomAutoMatchCancelReq();
		}

		// Token: 0x0601393E RID: 80190 RVA: 0x004FD944 File Offset: 0x004FBB44
		protected void OnTeamRoomAutoMatchCancelAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
