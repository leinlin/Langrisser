using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DEA RID: 3562
	[CustomLuaClass]
	public class HeroJobTransferNetTask : UINetTask
	{
		// Token: 0x06011114 RID: 69908 RVA: 0x0046C708 File Offset: 0x0046A908
		public HeroJobTransferNetTask(int heroId, int jobConnectionId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_jobConnectionId = jobConnectionId;
		}

		// Token: 0x06011115 RID: 69909 RVA: 0x0046C728 File Offset: 0x0046A928
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroJobTransferAck += this.OnHeroJobTransferAck;
		}

		// Token: 0x06011116 RID: 69910 RVA: 0x0046C760 File Offset: 0x0046A960
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroJobTransferAck -= this.OnHeroJobTransferAck;
			}
		}

		// Token: 0x06011117 RID: 69911 RVA: 0x0046C79C File Offset: 0x0046A99C
		protected void OnHeroJobTransferAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011118 RID: 69912 RVA: 0x0046C7AC File Offset: 0x0046A9AC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroJobTransferReq(this.m_heroId, this.m_jobConnectionId);
		}

		// Token: 0x04009CFC RID: 40188
		private int m_heroId;

		// Token: 0x04009CFD RID: 40189
		private int m_jobConnectionId;
	}
}
