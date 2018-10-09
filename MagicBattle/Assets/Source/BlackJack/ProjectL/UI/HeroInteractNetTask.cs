using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C87 RID: 3207
	[CustomLuaClass]
	public class HeroInteractNetTask : UINetTask
	{
		// Token: 0x0600E709 RID: 59145 RVA: 0x003DED28 File Offset: 0x003DCF28
		public HeroInteractNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x0600E70A RID: 59146 RVA: 0x003DED40 File Offset: 0x003DCF40
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroInteractAck += this.OnHeroInteractAck;
		}

		// Token: 0x0600E70B RID: 59147 RVA: 0x003DED78 File Offset: 0x003DCF78
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroInteractAck -= this.OnHeroInteractAck;
			}
		}

		// Token: 0x0600E70C RID: 59148 RVA: 0x003DEDB4 File Offset: 0x003DCFB4
		protected void OnHeroInteractAck(HeroInteractAck msg, List<Goods> rewards, int heroPerformanceId)
		{
			base.Result = msg.Result;
			this.Rewards = rewards;
			this.HeroPerformanceId = heroPerformanceId;
			this.InteractResult = (HeroInteractionResultType)msg.HeroInteractResult;
			this.AddFavoribilityExp = msg.AddFavorabilityExp;
			this.OnTransactionComplete();
		}

		// Token: 0x0600E70D RID: 59149 RVA: 0x003DEDF0 File Offset: 0x003DCFF0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroInteractReq(this.m_heroId);
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0600E70F RID: 59151 RVA: 0x003DEE2C File Offset: 0x003DD02C
		// (set) Token: 0x0600E70E RID: 59150 RVA: 0x003DEE20 File Offset: 0x003DD020
		public int HeroPerformanceId { get; private set; }

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0600E711 RID: 59153 RVA: 0x003DEE40 File Offset: 0x003DD040
		// (set) Token: 0x0600E710 RID: 59152 RVA: 0x003DEE34 File Offset: 0x003DD034
		public HeroInteractionResultType InteractResult { get; private set; }

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600E713 RID: 59155 RVA: 0x003DEE54 File Offset: 0x003DD054
		// (set) Token: 0x0600E712 RID: 59154 RVA: 0x003DEE48 File Offset: 0x003DD048
		public List<Goods> Rewards { get; private set; }

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600E715 RID: 59157 RVA: 0x003DEE68 File Offset: 0x003DD068
		// (set) Token: 0x0600E714 RID: 59156 RVA: 0x003DEE5C File Offset: 0x003DD05C
		public int AddFavoribilityExp { get; private set; }

		// Token: 0x04008B2E RID: 35630
		private int m_heroId;
	}
}
