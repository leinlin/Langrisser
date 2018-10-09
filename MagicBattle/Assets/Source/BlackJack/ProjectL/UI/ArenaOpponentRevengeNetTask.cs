using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A10 RID: 2576
	[CustomLuaClass]
	public class ArenaOpponentRevengeNetTask : UINetTask
	{
		// Token: 0x06009B14 RID: 39700 RVA: 0x002C313C File Offset: 0x002C133C
		public ArenaOpponentRevengeNetTask(ulong arenaBattleReportInstanceId, bool autoBattle) : base(10f, null, true)
		{
			this.m_arenaBattleReportInstanceId = arenaBattleReportInstanceId;
			this.m_autoBattle = autoBattle;
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x002C315C File Offset: 0x002C135C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaOpponentRevengeAck += this.OnArenaOpponentRevengeAck;
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x002C3194 File Offset: 0x002C1394
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaOpponentRevengeAck -= this.OnArenaOpponentRevengeAck;
			}
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x002C31D0 File Offset: 0x002C13D0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaOpponentRevengeReq(this.m_arenaBattleReportInstanceId, this.m_autoBattle);
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x002C3208 File Offset: 0x002C1408
		protected void OnArenaOpponentRevengeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x040069BF RID: 27071
		private ulong m_arenaBattleReportInstanceId;

		// Token: 0x040069C0 RID: 27072
		private bool m_autoBattle;
	}
}
