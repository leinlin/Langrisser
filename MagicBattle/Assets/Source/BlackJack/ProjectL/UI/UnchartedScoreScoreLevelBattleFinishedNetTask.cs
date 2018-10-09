using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FF1 RID: 4081
	[CustomLuaClass]
	public class UnchartedScoreScoreLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x060147AC RID: 83884 RVA: 0x00533410 File Offset: 0x00531610
		public UnchartedScoreScoreLevelBattleFinishedNetTask(int unchartedScoreId, int levelId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_unchartedScoreId = unchartedScoreId;
			this.m_levelId = levelId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x060147AD RID: 83885 RVA: 0x00533434 File Offset: 0x00531634
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnUnchartedScoreScoreLevelBattleFinishedAck += this.OnUnchartedScoreScoreLevelBattleFinishedAck;
		}

		// Token: 0x060147AE RID: 83886 RVA: 0x0053346C File Offset: 0x0053166C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnUnchartedScoreScoreLevelBattleFinishedAck -= this.OnUnchartedScoreScoreLevelBattleFinishedAck;
			}
		}

		// Token: 0x060147AF RID: 83887 RVA: 0x005334A8 File Offset: 0x005316A8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendUnchartedScoreScoreLevelBattleFinishedReq(this.m_unchartedScoreId, this.m_levelId, this.m_battleReport);
		}

		// Token: 0x060147B0 RID: 83888 RVA: 0x005334E4 File Offset: 0x005316E4
		protected void OnUnchartedScoreScoreLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x060147B2 RID: 83890 RVA: 0x00533510 File Offset: 0x00531710
		// (set) Token: 0x060147B1 RID: 83889 RVA: 0x00533504 File Offset: 0x00531704
		public bool IsWin { get; private set; }

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x060147B4 RID: 83892 RVA: 0x00533524 File Offset: 0x00531724
		// (set) Token: 0x060147B3 RID: 83891 RVA: 0x00533518 File Offset: 0x00531718
		public BattleReward Reward { get; private set; }

		// Token: 0x0400B43C RID: 46140
		private int m_unchartedScoreId;

		// Token: 0x0400B43D RID: 46141
		private int m_levelId;

		// Token: 0x0400B43E RID: 46142
		private ProBattleReport m_battleReport;
	}
}
