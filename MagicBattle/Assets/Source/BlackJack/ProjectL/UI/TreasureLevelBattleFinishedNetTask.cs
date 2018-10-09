using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FCA RID: 4042
	[CustomLuaClass]
	public class TreasureLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x06014360 RID: 82784 RVA: 0x00524AD4 File Offset: 0x00522CD4
		public TreasureLevelBattleFinishedNetTask(int treasureLevelID, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_treasureLevelID = treasureLevelID;
			this.m_battleReport = battleReport;
		}

		// Token: 0x06014361 RID: 82785 RVA: 0x00524AF4 File Offset: 0x00522CF4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTreasureLevelBattleFinishedAck += this.OnTreasureLevelBattleFinishedAck;
		}

		// Token: 0x06014362 RID: 82786 RVA: 0x00524B2C File Offset: 0x00522D2C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTreasureLevelBattleFinishedAck -= this.OnTreasureLevelBattleFinishedAck;
			}
		}

		// Token: 0x06014363 RID: 82787 RVA: 0x00524B68 File Offset: 0x00522D68
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTreasureLevelBattleFinishedReq(this.m_treasureLevelID, this.m_battleReport);
		}

		// Token: 0x06014364 RID: 82788 RVA: 0x00524BA0 File Offset: 0x00522DA0
		protected void OnTreasureLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x06014366 RID: 82790 RVA: 0x00524BCC File Offset: 0x00522DCC
		// (set) Token: 0x06014365 RID: 82789 RVA: 0x00524BC0 File Offset: 0x00522DC0
		public bool IsWin { get; private set; }

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x06014368 RID: 82792 RVA: 0x00524BE0 File Offset: 0x00522DE0
		// (set) Token: 0x06014367 RID: 82791 RVA: 0x00524BD4 File Offset: 0x00522DD4
		public BattleReward Reward { get; private set; }

		// Token: 0x0400B26E RID: 45678
		private int m_treasureLevelID;

		// Token: 0x0400B26F RID: 45679
		private ProBattleReport m_battleReport;
	}
}
