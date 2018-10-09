using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DE6 RID: 3558
	[CustomLuaClass]
	public class HeroJobLevelUpNetTask : UINetTask
	{
		// Token: 0x06011100 RID: 69888 RVA: 0x0046C37C File Offset: 0x0046A57C
		public HeroJobLevelUpNetTask(int id, int jobConnectionId) : base(10f, null, true)
		{
			this.m_heroId = id;
			this.m_jobConnectionId = jobConnectionId;
		}

		// Token: 0x06011101 RID: 69889 RVA: 0x0046C39C File Offset: 0x0046A59C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroJobLevelUpAck += this.OnHeroJobLevelUpAck;
		}

		// Token: 0x06011102 RID: 69890 RVA: 0x0046C3D4 File Offset: 0x0046A5D4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroJobLevelUpAck -= this.OnHeroJobLevelUpAck;
			}
		}

		// Token: 0x06011103 RID: 69891 RVA: 0x0046C410 File Offset: 0x0046A610
		protected void OnHeroJobLevelUpAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011104 RID: 69892 RVA: 0x0046C420 File Offset: 0x0046A620
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroJobLevelUpReq(this.m_heroId, this.m_jobConnectionId);
		}

		// Token: 0x04009CF2 RID: 40178
		private int m_heroId;

		// Token: 0x04009CF3 RID: 40179
		private int m_jobConnectionId;
	}
}
