using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A18 RID: 2584
	[CustomLuaClass]
	public class ArenaTicketsBuyNetTask : UINetTask
	{
		// Token: 0x06009B48 RID: 39752 RVA: 0x002C393C File Offset: 0x002C1B3C
		public ArenaTicketsBuyNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x002C394C File Offset: 0x002C1B4C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaTicketsBuyAck += this.OnArenaTicketsBuyAck;
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x002C3984 File Offset: 0x002C1B84
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaTicketsBuyAck -= this.OnArenaTicketsBuyAck;
			}
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x002C39C0 File Offset: 0x002C1BC0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBuyArenaTicketsReq();
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x002C39EC File Offset: 0x002C1BEC
		protected void OnArenaTicketsBuyAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
