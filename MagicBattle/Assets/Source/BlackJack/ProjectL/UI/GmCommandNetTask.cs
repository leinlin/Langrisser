using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001026 RID: 4134
	[CustomLuaClass]
	public class GmCommandNetTask : UINetTask
	{
		// Token: 0x06014F20 RID: 85792 RVA: 0x0054D0E8 File Offset: 0x0054B2E8
		public GmCommandNetTask(string cmd) : base(10f, null, true)
		{
			this.m_autoRetry = true;
			this.m_command = cmd;
		}

		// Token: 0x06014F21 RID: 85793 RVA: 0x0054D108 File Offset: 0x0054B308
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGmCommandAck += this.OnGmCommandAck;
		}

		// Token: 0x06014F22 RID: 85794 RVA: 0x0054D140 File Offset: 0x0054B340
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGmCommandAck -= this.OnGmCommandAck;
			}
		}

		// Token: 0x06014F23 RID: 85795 RVA: 0x0054D17C File Offset: 0x0054B37C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGmCommandReq(this.m_command);
		}

		// Token: 0x06014F24 RID: 85796 RVA: 0x0054D1AC File Offset: 0x0054B3AC
		protected void OnGmCommandAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400B709 RID: 46857
		private string m_command;
	}
}
