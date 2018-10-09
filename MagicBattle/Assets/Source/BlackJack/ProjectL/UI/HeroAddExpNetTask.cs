using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DE7 RID: 3559
	[CustomLuaClass]
	public class HeroAddExpNetTask : UINetTask
	{
		// Token: 0x06011105 RID: 69893 RVA: 0x0046C458 File Offset: 0x0046A658
		public HeroAddExpNetTask(int heroId, GoodsType goodsType, int itemId, int count) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_goodsType = goodsType;
			this.m_itemId = itemId;
			this.m_count = count;
		}

		// Token: 0x06011106 RID: 69894 RVA: 0x0046C484 File Offset: 0x0046A684
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroExpAddAck += this.OnHeroExpAddAck;
		}

		// Token: 0x06011107 RID: 69895 RVA: 0x0046C4BC File Offset: 0x0046A6BC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroExpAddAck -= this.OnHeroExpAddAck;
			}
		}

		// Token: 0x06011108 RID: 69896 RVA: 0x0046C4F8 File Offset: 0x0046A6F8
		protected void OnHeroExpAddAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011109 RID: 69897 RVA: 0x0046C508 File Offset: 0x0046A708
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroExpAddReq(this.m_heroId, this.m_goodsType, this.m_itemId, this.m_count);
		}

		// Token: 0x04009CF4 RID: 40180
		private int m_heroId;

		// Token: 0x04009CF5 RID: 40181
		private GoodsType m_goodsType;

		// Token: 0x04009CF6 RID: 40182
		private int m_itemId;

		// Token: 0x04009CF7 RID: 40183
		private int m_count;
	}
}
