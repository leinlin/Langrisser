using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D39 RID: 3385
	[CustomLuaClass]
	public class GuildPresidentRelieveReqNetTask : UINetTask
	{
		// Token: 0x0600F890 RID: 63632 RVA: 0x00418BB8 File Offset: 0x00416DB8
		public GuildPresidentRelieveReqNetTask(string userId) : base(10f, null, true)
		{
			this.m_userId = userId;
		}

		// Token: 0x0600F891 RID: 63633 RVA: 0x00418BD0 File Offset: 0x00416DD0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildPresidentRelieveAck += this.OnMsgAck;
		}

		// Token: 0x0600F892 RID: 63634 RVA: 0x00418C08 File Offset: 0x00416E08
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildPresidentRelieveAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F893 RID: 63635 RVA: 0x00418C44 File Offset: 0x00416E44
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildPresidentRelieveReq(this.m_userId);
		}

		// Token: 0x0600F894 RID: 63636 RVA: 0x00418C74 File Offset: 0x00416E74
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009242 RID: 37442
		private string m_userId;
	}
}
