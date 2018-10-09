using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EEF RID: 3823
	[CustomLuaClass]
	public class CardSelectNetTask : UINetTask
	{
		// Token: 0x06012DCA RID: 77258 RVA: 0x004D27EC File Offset: 0x004D09EC
		public CardSelectNetTask(int cardPoolId, bool isSingleSlect, bool isUsingTicket = true) : base(10f, null, true)
		{
			this.m_cardPoolId = cardPoolId;
			this.m_isSingleSlect = isSingleSlect;
			this.m_isUsingTicket = isUsingTicket;
			this.m_autoRetry = false;
		}

		// Token: 0x06012DCB RID: 77259 RVA: 0x004D2818 File Offset: 0x004D0A18
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCardSelectAck += this.OnCardSelectAck;
		}

		// Token: 0x06012DCC RID: 77260 RVA: 0x004D2850 File Offset: 0x004D0A50
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCardSelectAck -= this.OnCardSelectAck;
			}
		}

		// Token: 0x06012DCD RID: 77261 RVA: 0x004D288C File Offset: 0x004D0A8C
		protected void OnCardSelectAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x06012DCE RID: 77262 RVA: 0x004D28A4 File Offset: 0x004D0AA4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendSelectCardReq(this.m_cardPoolId, this.m_isSingleSlect, this.m_isUsingTicket);
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x06012DD0 RID: 77264 RVA: 0x004D28EC File Offset: 0x004D0AEC
		// (set) Token: 0x06012DCF RID: 77263 RVA: 0x004D28E0 File Offset: 0x004D0AE0
		public List<Goods> Rewards { get; private set; }

		// Token: 0x0400A88C RID: 43148
		private int m_cardPoolId;

		// Token: 0x0400A88D RID: 43149
		private bool m_isSingleSlect;

		// Token: 0x0400A88E RID: 43150
		private bool m_isUsingTicket;
	}
}
