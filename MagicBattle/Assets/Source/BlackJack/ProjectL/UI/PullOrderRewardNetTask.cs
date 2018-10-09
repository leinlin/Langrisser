using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F37 RID: 3895
	[CustomLuaClass]
	public class PullOrderRewardNetTask : UINetTask
	{
		// Token: 0x06013684 RID: 79492 RVA: 0x004F22E4 File Offset: 0x004F04E4
		public PullOrderRewardNetTask(string orderId) : base(10f, null, true)
		{
			this.m_orderId = orderId;
		}

		// Token: 0x06013685 RID: 79493 RVA: 0x004F22FC File Offset: 0x004F04FC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnPullOrderRewardAck += this.OnPullOrderRewardAck;
		}

		// Token: 0x06013686 RID: 79494 RVA: 0x004F2334 File Offset: 0x004F0534
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPullOrderRewardAck -= this.OnPullOrderRewardAck;
			}
		}

		// Token: 0x06013687 RID: 79495 RVA: 0x004F2370 File Offset: 0x004F0570
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendPullOrderRewardReq(this.m_orderId);
		}

		// Token: 0x06013688 RID: 79496 RVA: 0x004F23A0 File Offset: 0x004F05A0
		protected void OnPullOrderRewardAck(int result, string orderId, OrderReward orderReward)
		{
			base.Result = result;
			this.Reward = orderReward;
			this.OnTransactionComplete();
		}

		// Token: 0x0400AC6A RID: 44138
		private string m_orderId;

		// Token: 0x0400AC6B RID: 44139
		public OrderReward Reward;
	}
}
