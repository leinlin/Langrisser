using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DEF RID: 3567
	[CustomLuaClass]
	public class ViewCommenterHeroNetTask : UINetTask
	{
		// Token: 0x0601112D RID: 69933 RVA: 0x0046CB34 File Offset: 0x0046AD34
		public ViewCommenterHeroNetTask(int heroId, string userId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_userId = userId;
		}

		// Token: 0x0601112E RID: 69934 RVA: 0x0046CB54 File Offset: 0x0046AD54
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCommenterHeroViewAck += this.OnCommenterHeroViewAck;
		}

		// Token: 0x0601112F RID: 69935 RVA: 0x0046CB8C File Offset: 0x0046AD8C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCommenterHeroViewAck -= this.OnCommenterHeroViewAck;
			}
		}

		// Token: 0x06011130 RID: 69936 RVA: 0x0046CBC8 File Offset: 0x0046ADC8
		protected void OnCommenterHeroViewAck(int result, Hero playerHero)
		{
			this.PlayerHero = playerHero;
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011131 RID: 69937 RVA: 0x0046CBE0 File Offset: 0x0046ADE0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendViewCommenterHeroReq(this.m_heroId, this.m_userId);
		}

		// Token: 0x04009D04 RID: 40196
		public Hero PlayerHero;

		// Token: 0x04009D05 RID: 40197
		private int m_heroId;

		// Token: 0x04009D06 RID: 40198
		private string m_userId;
	}
}
