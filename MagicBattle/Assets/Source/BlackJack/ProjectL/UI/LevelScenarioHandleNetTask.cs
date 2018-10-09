using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001028 RID: 4136
	[CustomLuaClass]
	public class LevelScenarioHandleNetTask : UINetTask
	{
		// Token: 0x06014F2C RID: 85804 RVA: 0x0054D2A4 File Offset: 0x0054B4A4
		public LevelScenarioHandleNetTask(int scenarioId) : base(10f, null, true)
		{
			this.m_scenarioId = scenarioId;
		}

		// Token: 0x06014F2D RID: 85805 RVA: 0x0054D2BC File Offset: 0x0054B4BC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnLevelScenarioHandleAck += this.OnLevelScenarioHandleAck;
		}

		// Token: 0x06014F2E RID: 85806 RVA: 0x0054D2F4 File Offset: 0x0054B4F4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnLevelScenarioHandleAck -= this.OnLevelScenarioHandleAck;
			}
		}

		// Token: 0x06014F2F RID: 85807 RVA: 0x0054D330 File Offset: 0x0054B530
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLevelScenarioHandleReq(this.m_scenarioId);
		}

		// Token: 0x06014F30 RID: 85808 RVA: 0x0054D360 File Offset: 0x0054B560
		protected void OnLevelScenarioHandleAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x06014F32 RID: 85810 RVA: 0x0054D384 File Offset: 0x0054B584
		// (set) Token: 0x06014F31 RID: 85809 RVA: 0x0054D378 File Offset: 0x0054B578
		public BattleReward Reward { get; private set; }

		// Token: 0x0400B70D RID: 46861
		private int m_scenarioId;
	}
}
