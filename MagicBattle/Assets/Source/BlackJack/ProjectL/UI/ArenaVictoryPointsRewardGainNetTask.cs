using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A14 RID: 2580
	[CustomLuaClass]
	public class ArenaVictoryPointsRewardGainNetTask : UINetTask
	{
		// Token: 0x06009B32 RID: 39730 RVA: 0x002C3608 File Offset: 0x002C1808
		public ArenaVictoryPointsRewardGainNetTask(int id) : base(10f, null, true)
		{
			this.m_rewardId = id;
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x002C3620 File Offset: 0x002C1820
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaVictoryPointsRewardGainAck += this.OnArenaVictoryPointsRewardGainAck;
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x002C3658 File Offset: 0x002C1858
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaVictoryPointsRewardGainAck -= this.OnArenaVictoryPointsRewardGainAck;
			}
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x002C3694 File Offset: 0x002C1894
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaVictoryPointsRewardGainReq(this.m_rewardId);
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x002C36C4 File Offset: 0x002C18C4
		protected void OnArenaVictoryPointsRewardGainAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06009B38 RID: 39736 RVA: 0x002C36E8 File Offset: 0x002C18E8
		// (set) Token: 0x06009B37 RID: 39735 RVA: 0x002C36DC File Offset: 0x002C18DC
		public BattleReward Reward { get; private set; }

		// Token: 0x040069C8 RID: 27080
		private int m_rewardId;
	}
}
