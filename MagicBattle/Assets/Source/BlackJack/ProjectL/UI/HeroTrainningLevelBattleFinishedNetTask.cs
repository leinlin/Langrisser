using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E25 RID: 3621
	[CustomLuaClass]
	public class HeroTrainningLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x06011795 RID: 71573 RVA: 0x00486484 File Offset: 0x00484684
		public HeroTrainningLevelBattleFinishedNetTask(int heroTrainningLevelID, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_heroTrainningLevelId = heroTrainningLevelID;
			this.m_battleReport = battleReport;
		}

		// Token: 0x06011796 RID: 71574 RVA: 0x004864A4 File Offset: 0x004846A4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroTrainningLevelBattleFinishedAck += this.OnHeroTrainningLevelBattleFinishedAck;
		}

		// Token: 0x06011797 RID: 71575 RVA: 0x004864DC File Offset: 0x004846DC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroTrainningLevelBattleFinishedAck -= this.OnHeroTrainningLevelBattleFinishedAck;
			}
		}

		// Token: 0x06011798 RID: 71576 RVA: 0x00486518 File Offset: 0x00484718
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroTrainningLevelBattleFinishedReq(this.m_heroTrainningLevelId, this.m_battleReport);
		}

		// Token: 0x06011799 RID: 71577 RVA: 0x00486550 File Offset: 0x00484750
		protected void OnHeroTrainningLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0601179B RID: 71579 RVA: 0x0048657C File Offset: 0x0048477C
		// (set) Token: 0x0601179A RID: 71578 RVA: 0x00486570 File Offset: 0x00484770
		public bool IsWin { get; private set; }

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0601179D RID: 71581 RVA: 0x00486590 File Offset: 0x00484790
		// (set) Token: 0x0601179C RID: 71580 RVA: 0x00486584 File Offset: 0x00484784
		public BattleReward Reward { get; private set; }

		// Token: 0x04009F90 RID: 40848
		private int m_heroTrainningLevelId;

		// Token: 0x04009F91 RID: 40849
		private ProBattleReport m_battleReport;
	}
}
