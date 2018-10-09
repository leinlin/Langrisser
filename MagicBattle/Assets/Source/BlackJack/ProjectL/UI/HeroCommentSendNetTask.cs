using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DEC RID: 3564
	[CustomLuaClass]
	public class HeroCommentSendNetTask : UINetTask
	{
		// Token: 0x0601111E RID: 69918 RVA: 0x0046C8B0 File Offset: 0x0046AAB0
		public HeroCommentSendNetTask(int heroId, string content) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_content = content;
		}

		// Token: 0x0601111F RID: 69919 RVA: 0x0046C8D0 File Offset: 0x0046AAD0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroCommentSendAck += this.OnHeroCommentSendAck;
		}

		// Token: 0x06011120 RID: 69920 RVA: 0x0046C908 File Offset: 0x0046AB08
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroCommentSendAck -= this.OnHeroCommentSendAck;
			}
		}

		// Token: 0x06011121 RID: 69921 RVA: 0x0046C944 File Offset: 0x0046AB44
		protected void OnHeroCommentSendAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011122 RID: 69922 RVA: 0x0046C954 File Offset: 0x0046AB54
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendCommentHeroReq(this.m_heroId, this.m_content);
		}

		// Token: 0x04009CFF RID: 40191
		private int m_heroId;

		// Token: 0x04009D00 RID: 40192
		private string m_content;
	}
}
