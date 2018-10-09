using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF0 RID: 3568
	[CustomLuaClass]
	public class HeroJobUnlockNetTask : UINetTask
	{
		// Token: 0x06011132 RID: 69938 RVA: 0x0046CC18 File Offset: 0x0046AE18
		public HeroJobUnlockNetTask(int heroId, int jobRelateId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_jobRelateId = jobRelateId;
		}

		// Token: 0x06011133 RID: 69939 RVA: 0x0046CC38 File Offset: 0x0046AE38
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroJobUnlockAck += this.OnHeroJobUnlockAck;
		}

		// Token: 0x06011134 RID: 69940 RVA: 0x0046CC70 File Offset: 0x0046AE70
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroJobUnlockAck -= this.OnHeroJobUnlockAck;
			}
		}

		// Token: 0x06011135 RID: 69941 RVA: 0x0046CCAC File Offset: 0x0046AEAC
		protected void OnHeroJobUnlockAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011136 RID: 69942 RVA: 0x0046CCBC File Offset: 0x0046AEBC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroJobUnlockReq(this.m_heroId, this.m_jobRelateId);
		}

		// Token: 0x04009D07 RID: 40199
		private int m_heroId;

		// Token: 0x04009D08 RID: 40200
		private int m_jobRelateId;
	}
}
