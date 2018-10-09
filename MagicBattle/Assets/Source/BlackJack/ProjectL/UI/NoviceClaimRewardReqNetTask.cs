using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000993 RID: 2451
	[CustomLuaClass]
	public class NoviceClaimRewardReqNetTask : UINetTask
	{
		// Token: 0x06008D30 RID: 36144 RVA: 0x0029342C File Offset: 0x0029162C
		public NoviceClaimRewardReqNetTask(int slot) : base(10f, null, true)
		{
			this.m_slot = slot;
		}

		// Token: 0x06008D31 RID: 36145 RVA: 0x00293444 File Offset: 0x00291644
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnNoviceClaimRewardAck += this.OnNoviceClaimRewardAck;
		}

		// Token: 0x06008D32 RID: 36146 RVA: 0x0029347C File Offset: 0x0029167C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnNoviceClaimRewardAck -= this.OnNoviceClaimRewardAck;
			}
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x002934B8 File Offset: 0x002916B8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendNoviceClaimRewardReq(this.m_slot);
		}

		// Token: 0x06008D34 RID: 36148 RVA: 0x002934E8 File Offset: 0x002916E8
		protected void OnNoviceClaimRewardAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06008D36 RID: 36150 RVA: 0x0029350C File Offset: 0x0029170C
		// (set) Token: 0x06008D35 RID: 36149 RVA: 0x00293500 File Offset: 0x00291700
		public List<Goods> Rewards { get; private set; }

		// Token: 0x04006447 RID: 25671
		private int m_slot;
	}
}
