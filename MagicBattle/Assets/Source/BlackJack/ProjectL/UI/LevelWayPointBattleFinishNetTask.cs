using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001029 RID: 4137
	[CustomLuaClass]
	public class LevelWayPointBattleFinishNetTask : UINetTask
	{
		// Token: 0x06014F33 RID: 85811 RVA: 0x0054D38C File Offset: 0x0054B58C
		public LevelWayPointBattleFinishNetTask(int waypointId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_waypointId = waypointId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x06014F34 RID: 85812 RVA: 0x0054D3AC File Offset: 0x0054B5AC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnLevelWayPointBattleFinishAck += this.OnLevelWayPointBattleFinishAck;
		}

		// Token: 0x06014F35 RID: 85813 RVA: 0x0054D3E4 File Offset: 0x0054B5E4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnLevelWayPointBattleFinishAck -= this.OnLevelWayPointBattleFinishAck;
			}
		}

		// Token: 0x06014F36 RID: 85814 RVA: 0x0054D420 File Offset: 0x0054B620
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLevelWayPointBattleFinishReq(this.m_waypointId, this.m_battleReport);
		}

		// Token: 0x06014F37 RID: 85815 RVA: 0x0054D458 File Offset: 0x0054B658
		protected void OnLevelWayPointBattleFinishAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x06014F39 RID: 85817 RVA: 0x0054D484 File Offset: 0x0054B684
		// (set) Token: 0x06014F38 RID: 85816 RVA: 0x0054D478 File Offset: 0x0054B678
		public BattleReward Reward { get; private set; }

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x06014F3B RID: 85819 RVA: 0x0054D498 File Offset: 0x0054B698
		// (set) Token: 0x06014F3A RID: 85818 RVA: 0x0054D48C File Offset: 0x0054B68C
		public bool IsWin { get; private set; }

		// Token: 0x0400B710 RID: 46864
		private int m_waypointId;

		// Token: 0x0400B711 RID: 46865
		private ProBattleReport m_battleReport;
	}
}
