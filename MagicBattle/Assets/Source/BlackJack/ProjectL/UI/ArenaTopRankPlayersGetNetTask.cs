using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A17 RID: 2583
	[CustomLuaClass]
	public class ArenaTopRankPlayersGetNetTask : UINetTask
	{
		// Token: 0x06009B43 RID: 39747 RVA: 0x002C387C File Offset: 0x002C1A7C
		public ArenaTopRankPlayersGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x002C388C File Offset: 0x002C1A8C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaTopRankPlayersGetAck += this.OnArenaTopRankPlayersGetAck;
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x002C38C4 File Offset: 0x002C1AC4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaTopRankPlayersGetAck -= this.OnArenaTopRankPlayersGetAck;
			}
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x002C3900 File Offset: 0x002C1B00
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaTopRankPlayersGetReq();
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x002C392C File Offset: 0x002C1B2C
		protected void OnArenaTopRankPlayersGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
