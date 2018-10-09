using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D26 RID: 3366
	[CustomLuaClass]
	public class GuildJoinAdminRefuseReqNetTask : UINetTask
	{
		// Token: 0x0600F81F RID: 63519 RVA: 0x00417BD4 File Offset: 0x00415DD4
		public GuildJoinAdminRefuseReqNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600F820 RID: 63520 RVA: 0x00417BEC File Offset: 0x00415DEC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinApplyRefuseAck += this.OnMsgAck;
		}

		// Token: 0x0600F821 RID: 63521 RVA: 0x00417C24 File Offset: 0x00415E24
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinApplyRefuseAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F822 RID: 63522 RVA: 0x00417C60 File Offset: 0x00415E60
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildJoinApplyRefuseReq(this.m_userID);
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x00417C90 File Offset: 0x00415E90
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400922C RID: 37420
		private string m_userID;
	}
}
