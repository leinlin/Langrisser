using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C86 RID: 3206
	[CustomLuaClass]
	public class HeroFavorabilityExpAddNetTask : UINetTask
	{
		// Token: 0x0600E702 RID: 59138 RVA: 0x003DEC18 File Offset: 0x003DCE18
		public HeroFavorabilityExpAddNetTask(int heroId, GoodsType goodsType, int itemId, int count) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_goodsType = goodsType;
			this.m_itemId = itemId;
			this.m_count = count;
		}

		// Token: 0x0600E703 RID: 59139 RVA: 0x003DEC44 File Offset: 0x003DCE44
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroFavorabilityExpAddAck += this.OnHeroFavorabilityExpAddAck;
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x003DEC7C File Offset: 0x003DCE7C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroFavorabilityExpAddAck -= this.OnHeroFavorabilityExpAddAck;
			}
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x003DECB8 File Offset: 0x003DCEB8
		protected void OnHeroFavorabilityExpAddAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x003DECD0 File Offset: 0x003DCED0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroFavorabilityExpAddReq(this.m_heroId, this.m_goodsType, this.m_itemId, this.m_count);
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0600E708 RID: 59144 RVA: 0x003DED20 File Offset: 0x003DCF20
		// (set) Token: 0x0600E707 RID: 59143 RVA: 0x003DED14 File Offset: 0x003DCF14
		public List<Goods> Rewards { get; private set; }

		// Token: 0x04008B29 RID: 35625
		private int m_heroId;

		// Token: 0x04008B2A RID: 35626
		private GoodsType m_goodsType;

		// Token: 0x04008B2B RID: 35627
		private int m_itemId;

		// Token: 0x04008B2C RID: 35628
		private int m_count;
	}
}
