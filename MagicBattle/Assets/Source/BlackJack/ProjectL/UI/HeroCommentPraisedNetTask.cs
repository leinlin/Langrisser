using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DEE RID: 3566
	[CustomLuaClass]
	public class HeroCommentPraisedNetTask : UINetTask
	{
		// Token: 0x06011128 RID: 69928 RVA: 0x0046CA58 File Offset: 0x0046AC58
		public HeroCommentPraisedNetTask(int heroId, ulong instanceId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_instanceId = instanceId;
		}

		// Token: 0x06011129 RID: 69929 RVA: 0x0046CA78 File Offset: 0x0046AC78
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroCommentPraisedAck += this.OnHeroCommentPraisedAck;
		}

		// Token: 0x0601112A RID: 69930 RVA: 0x0046CAB0 File Offset: 0x0046ACB0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroCommentPraisedAck -= this.OnHeroCommentPraisedAck;
			}
		}

		// Token: 0x0601112B RID: 69931 RVA: 0x0046CAEC File Offset: 0x0046ACEC
		protected void OnHeroCommentPraisedAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601112C RID: 69932 RVA: 0x0046CAFC File Offset: 0x0046ACFC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendPraiseHeroCommentEntryReq(this.m_heroId, this.m_instanceId);
		}

		// Token: 0x04009D02 RID: 40194
		private int m_heroId;

		// Token: 0x04009D03 RID: 40195
		private ulong m_instanceId;
	}
}
