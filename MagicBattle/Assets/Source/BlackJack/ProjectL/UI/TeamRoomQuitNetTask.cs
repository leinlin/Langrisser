using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F61 RID: 3937
	[CustomLuaClass]
	public class TeamRoomQuitNetTask : UINetTask
	{
		// Token: 0x06013949 RID: 80201 RVA: 0x004FDB14 File Offset: 0x004FBD14
		public TeamRoomQuitNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0601394A RID: 80202 RVA: 0x004FDB24 File Offset: 0x004FBD24
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomQuitAck += this.OnTeamRoomQuitAck;
		}

		// Token: 0x0601394B RID: 80203 RVA: 0x004FDB5C File Offset: 0x004FBD5C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomQuitAck -= this.OnTeamRoomQuitAck;
			}
		}

		// Token: 0x0601394C RID: 80204 RVA: 0x004FDB98 File Offset: 0x004FBD98
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomQuitReq();
		}

		// Token: 0x0601394D RID: 80205 RVA: 0x004FDBC4 File Offset: 0x004FBDC4
		protected void OnTeamRoomQuitAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
