using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D3A RID: 3386
	[CustomLuaClass]
	public class GuildPresidentAppointReqNetTask : UINetTask
	{
		// Token: 0x0600F895 RID: 63637 RVA: 0x00418C84 File Offset: 0x00416E84
		public GuildPresidentAppointReqNetTask(string userId) : base(10f, null, true)
		{
			this.m_userId = userId;
		}

		// Token: 0x0600F896 RID: 63638 RVA: 0x00418C9C File Offset: 0x00416E9C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildPresidentAppointAck += this.OnMsgAck;
		}

		// Token: 0x0600F897 RID: 63639 RVA: 0x00418CD4 File Offset: 0x00416ED4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildPresidentAppointAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F898 RID: 63640 RVA: 0x00418D10 File Offset: 0x00416F10
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildPresidentAppointReq(this.m_userId);
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x00418D40 File Offset: 0x00416F40
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009243 RID: 37443
		private string m_userId;
	}
}
