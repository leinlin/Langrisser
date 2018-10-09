using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DE9 RID: 3561
	[CustomLuaClass]
	public class HeroSoldierSelectNetTask : UINetTask
	{
		// Token: 0x0601110F RID: 69903 RVA: 0x0046C62C File Offset: 0x0046A82C
		public HeroSoldierSelectNetTask(int heroId, int soldierId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_soldierId = soldierId;
		}

		// Token: 0x06011110 RID: 69904 RVA: 0x0046C64C File Offset: 0x0046A84C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroSoldierSelectAck += this.OnHeroSoldierSelectAck;
		}

		// Token: 0x06011111 RID: 69905 RVA: 0x0046C684 File Offset: 0x0046A884
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroSoldierSelectAck -= this.OnHeroSoldierSelectAck;
			}
		}

		// Token: 0x06011112 RID: 69906 RVA: 0x0046C6C0 File Offset: 0x0046A8C0
		protected void OnHeroSoldierSelectAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011113 RID: 69907 RVA: 0x0046C6D0 File Offset: 0x0046A8D0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroSoldierSelectReq(this.m_heroId, this.m_soldierId);
		}

		// Token: 0x04009CFA RID: 40186
		private int m_heroId;

		// Token: 0x04009CFB RID: 40187
		private int m_soldierId;
	}
}
