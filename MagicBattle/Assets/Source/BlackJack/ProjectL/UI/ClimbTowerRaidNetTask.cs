using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B87 RID: 2951
	[CustomLuaClass]
	public class ClimbTowerRaidNetTask : UINetTask
	{
		// Token: 0x0600C93D RID: 51517 RVA: 0x00379FC0 File Offset: 0x003781C0
		public ClimbTowerRaidNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x00379FD0 File Offset: 0x003781D0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnClimbTowerRaidAck += this.OnClimbTowerRaidAck;
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x0037A008 File Offset: 0x00378208
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnClimbTowerRaidAck -= this.OnClimbTowerRaidAck;
			}
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x0037A044 File Offset: 0x00378244
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendClimbTowerRaidReq();
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x0037A070 File Offset: 0x00378270
		protected void OnClimbTowerRaidAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x0600C943 RID: 51523 RVA: 0x0037A094 File Offset: 0x00378294
		// (set) Token: 0x0600C942 RID: 51522 RVA: 0x0037A088 File Offset: 0x00378288
		public BattleReward Reward { get; private set; }
	}
}
