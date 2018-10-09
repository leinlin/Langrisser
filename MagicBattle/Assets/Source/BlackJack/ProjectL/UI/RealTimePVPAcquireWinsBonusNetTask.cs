using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A1E RID: 2590
	[CustomLuaClass]
	public class RealTimePVPAcquireWinsBonusNetTask : UINetTask
	{
		// Token: 0x06009B68 RID: 39784 RVA: 0x002C3E00 File Offset: 0x002C2000
		public RealTimePVPAcquireWinsBonusNetTask(int bonusId) : base(10f, null, true)
		{
			this.bonusId = bonusId;
		}

		// Token: 0x06009B69 RID: 39785 RVA: 0x002C3E18 File Offset: 0x002C2018
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRealTimePVPAcquireWinsBonusAck += this.OnRealTimePVPAcquireWinsBonusAck;
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x002C3E50 File Offset: 0x002C2050
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRealTimePVPAcquireWinsBonusAck -= this.OnRealTimePVPAcquireWinsBonusAck;
			}
		}

		// Token: 0x06009B6B RID: 39787 RVA: 0x002C3E8C File Offset: 0x002C208C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRealTimePVPAcquireWinsBonusReq(this.bonusId);
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x002C3EBC File Offset: 0x002C20BC
		protected void OnRealTimePVPAcquireWinsBonusAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06009B6E RID: 39790 RVA: 0x002C3EE0 File Offset: 0x002C20E0
		// (set) Token: 0x06009B6D RID: 39789 RVA: 0x002C3ED4 File Offset: 0x002C20D4
		public BattleReward Reward { get; private set; }

		// Token: 0x040069CF RID: 27087
		private int bonusId;
	}
}
