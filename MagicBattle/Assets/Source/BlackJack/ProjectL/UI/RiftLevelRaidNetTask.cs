using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EEA RID: 3818
	[CustomLuaClass]
	public class RiftLevelRaidNetTask : UINetTask
	{
		// Token: 0x06012D11 RID: 77073 RVA: 0x004CF100 File Offset: 0x004CD300
		public RiftLevelRaidNetTask(int riftLevelId, int count) : base(10f, null, true)
		{
			this.m_riftLevelId = riftLevelId;
			this.m_count = count;
		}

		// Token: 0x06012D12 RID: 77074 RVA: 0x004CF120 File Offset: 0x004CD320
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRiftLevelRaidAck += this.OnRiftLevelRaidAck;
		}

		// Token: 0x06012D13 RID: 77075 RVA: 0x004CF158 File Offset: 0x004CD358
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRiftLevelRaidAck -= this.OnRiftLevelRaidAck;
			}
		}

		// Token: 0x06012D14 RID: 77076 RVA: 0x004CF194 File Offset: 0x004CD394
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRiftLevelRaidReq(this.m_riftLevelId, this.m_count);
		}

		// Token: 0x06012D15 RID: 77077 RVA: 0x004CF1CC File Offset: 0x004CD3CC
		protected void OnRiftLevelRaidAck(int result, BattleReward reward, List<Goods> extraReward)
		{
			base.Result = result;
			this.Reward = reward;
			this.ExtraReward = extraReward;
			this.OnTransactionComplete();
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x06012D17 RID: 77079 RVA: 0x004CF1F8 File Offset: 0x004CD3F8
		// (set) Token: 0x06012D16 RID: 77078 RVA: 0x004CF1EC File Offset: 0x004CD3EC
		public BattleReward Reward { get; private set; }

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x06012D19 RID: 77081 RVA: 0x004CF20C File Offset: 0x004CD40C
		// (set) Token: 0x06012D18 RID: 77080 RVA: 0x004CF200 File Offset: 0x004CD400
		public List<Goods> ExtraReward { get; private set; }

		// Token: 0x0400A845 RID: 43077
		private int m_riftLevelId;

		// Token: 0x0400A846 RID: 43078
		private int m_count;
	}
}
