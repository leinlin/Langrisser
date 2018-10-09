using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C8A RID: 3210
	[CustomLuaClass]
	public class HeroConfessNetTask : UINetTask
	{
		// Token: 0x0600E722 RID: 59170 RVA: 0x003DF044 File Offset: 0x003DD244
		public HeroConfessNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x0600E723 RID: 59171 RVA: 0x003DF05C File Offset: 0x003DD25C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroConfessAck += this.OnHeroConfessAck;
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x003DF094 File Offset: 0x003DD294
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroConfessAck -= this.OnHeroConfessAck;
			}
		}

		// Token: 0x0600E725 RID: 59173 RVA: 0x003DF0D0 File Offset: 0x003DD2D0
		protected void OnHeroConfessAck(int result, List<Goods> reward)
		{
			base.Result = result;
			this.Rewards = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x0600E726 RID: 59174 RVA: 0x003DF0E8 File Offset: 0x003DD2E8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroConfessReq(this.m_heroId);
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x003DF124 File Offset: 0x003DD324
		// (set) Token: 0x0600E727 RID: 59175 RVA: 0x003DF118 File Offset: 0x003DD318
		public List<Goods> Rewards { get; private set; }

		// Token: 0x04008B38 RID: 35640
		private int m_heroId;
	}
}
