using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FC1 RID: 4033
	[CustomLuaClass]
	public class ThearchyLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x0601422B RID: 82475 RVA: 0x00520D24 File Offset: 0x0051EF24
		public ThearchyLevelBattleFinishedNetTask(int levelId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_levelId = levelId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x0601422C RID: 82476 RVA: 0x00520D44 File Offset: 0x0051EF44
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnThearchyTrialLevelBattleFinishedAck += this.OnThearchyLevelBattleFinishedAck;
		}

		// Token: 0x0601422D RID: 82477 RVA: 0x00520D7C File Offset: 0x0051EF7C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnThearchyTrialLevelBattleFinishedAck -= this.OnThearchyLevelBattleFinishedAck;
			}
		}

		// Token: 0x0601422E RID: 82478 RVA: 0x00520DB8 File Offset: 0x0051EFB8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendThearchyTrialLevelBattleFinishedReq(this.m_levelId, this.m_battleReport);
		}

		// Token: 0x0601422F RID: 82479 RVA: 0x00520DF0 File Offset: 0x0051EFF0
		protected void OnThearchyLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x06014231 RID: 82481 RVA: 0x00520E1C File Offset: 0x0051F01C
		// (set) Token: 0x06014230 RID: 82480 RVA: 0x00520E10 File Offset: 0x0051F010
		public bool IsWin { get; private set; }

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x06014233 RID: 82483 RVA: 0x00520E30 File Offset: 0x0051F030
		// (set) Token: 0x06014232 RID: 82482 RVA: 0x00520E24 File Offset: 0x0051F024
		public BattleReward Reward { get; private set; }

		// Token: 0x0400B202 RID: 45570
		private int m_levelId;

		// Token: 0x0400B203 RID: 45571
		private ProBattleReport m_battleReport;
	}
}
