using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FEF RID: 4079
	[CustomLuaClass]
	public class UnchartedScoreChallengeLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x0601479E RID: 83870 RVA: 0x00533218 File Offset: 0x00531418
		public UnchartedScoreChallengeLevelBattleFinishedNetTask(int unchartedScoreId, int levelId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_unchartedScoreId = unchartedScoreId;
			this.m_levelId = levelId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x0601479F RID: 83871 RVA: 0x0053323C File Offset: 0x0053143C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnUnchartedScoreChallengeLevelBattleFinishedAck += this.OnUnchartedScoreChallengeLevelBattleFinishedAck;
		}

		// Token: 0x060147A0 RID: 83872 RVA: 0x00533274 File Offset: 0x00531474
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnUnchartedScoreChallengeLevelBattleFinishedAck -= this.OnUnchartedScoreChallengeLevelBattleFinishedAck;
			}
		}

		// Token: 0x060147A1 RID: 83873 RVA: 0x005332B0 File Offset: 0x005314B0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendUnchartedScoreChallengeLevelBattleFinishedReq(this.m_unchartedScoreId, this.m_levelId, this.m_battleReport);
		}

		// Token: 0x060147A2 RID: 83874 RVA: 0x005332EC File Offset: 0x005314EC
		protected void OnUnchartedScoreChallengeLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x060147A4 RID: 83876 RVA: 0x00533318 File Offset: 0x00531518
		// (set) Token: 0x060147A3 RID: 83875 RVA: 0x0053330C File Offset: 0x0053150C
		public bool IsWin { get; private set; }

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x060147A6 RID: 83878 RVA: 0x0053332C File Offset: 0x0053152C
		// (set) Token: 0x060147A5 RID: 83877 RVA: 0x00533320 File Offset: 0x00531520
		public BattleReward Reward { get; private set; }

		// Token: 0x0400B435 RID: 46133
		private int m_unchartedScoreId;

		// Token: 0x0400B436 RID: 46134
		private int m_levelId;

		// Token: 0x0400B437 RID: 46135
		private ProBattleReport m_battleReport;
	}
}
