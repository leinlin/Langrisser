using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A59 RID: 2649
	[CustomLuaClass]
	public class BagItemDecomposeNetTask : UINetTask
	{
		// Token: 0x0600A508 RID: 42248 RVA: 0x002E6D7C File Offset: 0x002E4F7C
		public BagItemDecomposeNetTask(List<ProGoods> goods) : base(10f, null, true)
		{
			this.m_goods = new List<ProGoods>(goods);
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x002E6D98 File Offset: 0x002E4F98
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBagItemDecomposeAck += this.OnBagItemDecomposeAck;
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x002E6DD0 File Offset: 0x002E4FD0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBagItemDecomposeAck -= this.OnBagItemDecomposeAck;
			}
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x002E6E0C File Offset: 0x002E500C
		protected void OnBagItemDecomposeAck(int result, List<Goods> reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x002E6E24 File Offset: 0x002E5024
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBagItemDecomposeReq(this.m_goods);
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x0600A50E RID: 42254 RVA: 0x002E6E60 File Offset: 0x002E5060
		// (set) Token: 0x0600A50D RID: 42253 RVA: 0x002E6E54 File Offset: 0x002E5054
		public List<Goods> Reward { get; private set; }

		// Token: 0x04006DEA RID: 28138
		private List<ProGoods> m_goods;
	}
}
