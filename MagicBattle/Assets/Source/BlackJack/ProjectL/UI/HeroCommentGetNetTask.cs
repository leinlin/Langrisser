using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DED RID: 3565
	[CustomLuaClass]
	public class HeroCommentGetNetTask : UINetTask
	{
		// Token: 0x06011123 RID: 69923 RVA: 0x0046C98C File Offset: 0x0046AB8C
		public HeroCommentGetNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x06011124 RID: 69924 RVA: 0x0046C9A4 File Offset: 0x0046ABA4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroCommentGetAck += this.OnHeroCommentGetAck;
		}

		// Token: 0x06011125 RID: 69925 RVA: 0x0046C9DC File Offset: 0x0046ABDC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroCommentGetAck -= this.OnHeroCommentGetAck;
			}
		}

		// Token: 0x06011126 RID: 69926 RVA: 0x0046CA18 File Offset: 0x0046AC18
		protected void OnHeroCommentGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011127 RID: 69927 RVA: 0x0046CA28 File Offset: 0x0046AC28
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetHeroCommentReq(this.m_heroId);
		}

		// Token: 0x04009D01 RID: 40193
		private int m_heroId;
	}
}
