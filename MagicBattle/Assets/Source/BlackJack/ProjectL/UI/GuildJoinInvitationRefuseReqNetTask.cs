using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D2E RID: 3374
	[CustomLuaClass]
	public class GuildJoinInvitationRefuseReqNetTask : UINetTask
	{
		// Token: 0x0600F84B RID: 63563 RVA: 0x0041824C File Offset: 0x0041644C
		public GuildJoinInvitationRefuseReqNetTask(string guildID) : base(10f, null, true)
		{
			this.m_guildID = guildID;
		}

		// Token: 0x0600F84C RID: 63564 RVA: 0x00418264 File Offset: 0x00416464
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinInvitationRefuseAck += this.OnMsgAck;
		}

		// Token: 0x0600F84D RID: 63565 RVA: 0x0041829C File Offset: 0x0041649C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinInvitationRefuseAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F84E RID: 63566 RVA: 0x004182D8 File Offset: 0x004164D8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildJoinInvitationRefuseReq(this.m_guildID);
		}

		// Token: 0x0600F84F RID: 63567 RVA: 0x00418308 File Offset: 0x00416508
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009234 RID: 37428
		private string m_guildID;
	}
}
