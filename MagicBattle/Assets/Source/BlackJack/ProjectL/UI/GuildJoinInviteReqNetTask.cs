using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D36 RID: 3382
	[CustomLuaClass]
	public class GuildJoinInviteReqNetTask : UINetTask
	{
		// Token: 0x0600F881 RID: 63617 RVA: 0x00418944 File Offset: 0x00416B44
		public GuildJoinInviteReqNetTask(string userId) : base(10f, null, true)
		{
			this.m_userId = userId;
		}

		// Token: 0x0600F882 RID: 63618 RVA: 0x0041895C File Offset: 0x00416B5C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinInviteAck += this.OnMsgAck;
		}

		// Token: 0x0600F883 RID: 63619 RVA: 0x00418994 File Offset: 0x00416B94
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinInviteAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F884 RID: 63620 RVA: 0x004189D0 File Offset: 0x00416BD0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildJoinInviteReq(this.m_userId);
		}

		// Token: 0x0600F885 RID: 63621 RVA: 0x00418A00 File Offset: 0x00416C00
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400923E RID: 37438
		private string m_userId;
	}
}
