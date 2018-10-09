using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D27 RID: 3367
	[CustomLuaClass]
	public class GuildJoinPlayerConfirmReqNetTask : UINetTask
	{
		// Token: 0x0600F824 RID: 63524 RVA: 0x00417CA0 File Offset: 0x00415EA0
		public GuildJoinPlayerConfirmReqNetTask(string guildID) : base(10f, null, true)
		{
			this.m_guildID = guildID;
		}

		// Token: 0x0600F825 RID: 63525 RVA: 0x00417CB8 File Offset: 0x00415EB8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinPlayerConfirmAck += this.OnMsgAck;
		}

		// Token: 0x0600F826 RID: 63526 RVA: 0x00417CF0 File Offset: 0x00415EF0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinPlayerConfirmAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x00417D2C File Offset: 0x00415F2C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildJoinPlayerConfirmReq(this.m_guildID);
		}

		// Token: 0x0600F828 RID: 63528 RVA: 0x00417D5C File Offset: 0x00415F5C
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400922D RID: 37421
		private string m_guildID;
	}
}
