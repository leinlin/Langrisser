using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001027 RID: 4135
	[CustomLuaClass]
	public class LevelWayPointMoveNetTask : UINetTask
	{
		// Token: 0x06014F25 RID: 85797 RVA: 0x0054D1BC File Offset: 0x0054B3BC
		public LevelWayPointMoveNetTask(int waypointId) : base(10f, null, true)
		{
			this.m_waypointId = waypointId;
		}

		// Token: 0x06014F26 RID: 85798 RVA: 0x0054D1D4 File Offset: 0x0054B3D4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnLevelWayPointMoveAck += this.OnLevelWayPointMoveAck;
		}

		// Token: 0x06014F27 RID: 85799 RVA: 0x0054D20C File Offset: 0x0054B40C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnLevelWayPointMoveAck -= this.OnLevelWayPointMoveAck;
			}
		}

		// Token: 0x06014F28 RID: 85800 RVA: 0x0054D248 File Offset: 0x0054B448
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLevelWayPointMoveReq(this.m_waypointId);
		}

		// Token: 0x06014F29 RID: 85801 RVA: 0x0054D278 File Offset: 0x0054B478
		protected void OnLevelWayPointMoveAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x06014F2B RID: 85803 RVA: 0x0054D29C File Offset: 0x0054B49C
		// (set) Token: 0x06014F2A RID: 85802 RVA: 0x0054D290 File Offset: 0x0054B490
		public BattleReward Reward { get; private set; }

		// Token: 0x0400B70B RID: 46859
		private int m_waypointId;
	}
}
