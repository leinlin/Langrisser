using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C3B RID: 3131
	[CustomLuaClass]
	public class HeroAssistantClaimRewardNetTask : UINetTask
	{
		// Token: 0x0600DC18 RID: 56344 RVA: 0x003BA4EC File Offset: 0x003B86EC
		public HeroAssistantClaimRewardNetTask(int taskIndex, int slot) : base(10f, null, true)
		{
			this.m_taskIndex = taskIndex;
			this.m_slot = slot;
		}

		// Token: 0x0600DC19 RID: 56345 RVA: 0x003BA50C File Offset: 0x003B870C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroAssistantClaimRewardAck += this.OnHeroAssistantClaimRewardAck;
		}

		// Token: 0x0600DC1A RID: 56346 RVA: 0x003BA544 File Offset: 0x003B8744
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroAssistantClaimRewardAck -= this.OnHeroAssistantClaimRewardAck;
			}
		}

		// Token: 0x0600DC1B RID: 56347 RVA: 0x003BA580 File Offset: 0x003B8780
		protected void OnHeroAssistantClaimRewardAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x0600DC1C RID: 56348 RVA: 0x003BA598 File Offset: 0x003B8798
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroAssistantClaimRewardReq(this.m_taskIndex, this.m_slot);
		}

		// Token: 0x040086A3 RID: 34467
		private int m_slot;

		// Token: 0x040086A4 RID: 34468
		private int m_taskIndex;

		// Token: 0x040086A5 RID: 34469
		public List<Goods> Rewards;
	}
}
