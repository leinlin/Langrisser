using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DEB RID: 3563
	[CustomLuaClass]
	public class HeroComposeNetTask : UINetTask
	{
		// Token: 0x06011119 RID: 69913 RVA: 0x0046C7E4 File Offset: 0x0046A9E4
		public HeroComposeNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x0601111A RID: 69914 RVA: 0x0046C7FC File Offset: 0x0046A9FC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroComposeAck += this.OnHeroComposeAck;
		}

		// Token: 0x0601111B RID: 69915 RVA: 0x0046C834 File Offset: 0x0046AA34
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroComposeAck -= this.OnHeroComposeAck;
			}
		}

		// Token: 0x0601111C RID: 69916 RVA: 0x0046C870 File Offset: 0x0046AA70
		protected void OnHeroComposeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601111D RID: 69917 RVA: 0x0046C880 File Offset: 0x0046AA80
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroComposeReqq(this.m_heroId);
		}

		// Token: 0x04009CFE RID: 40190
		private int m_heroId;
	}
}
