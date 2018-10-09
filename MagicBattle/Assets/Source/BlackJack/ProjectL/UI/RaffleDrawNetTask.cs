using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EA5 RID: 3749
	[CustomLuaClass]
	public class RaffleDrawNetTask : UINetTask
	{
		// Token: 0x060124FF RID: 75007 RVA: 0x004B46B4 File Offset: 0x004B28B4
		public RaffleDrawNetTask(int poolId) : base(10f, null, true)
		{
			this.m_poolId = poolId;
		}

		// Token: 0x06012500 RID: 75008 RVA: 0x004B46CC File Offset: 0x004B28CC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRaffleDrawAck += this.OnRaffleDrawAck;
		}

		// Token: 0x06012501 RID: 75009 RVA: 0x004B4704 File Offset: 0x004B2904
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRaffleDrawAck -= this.OnRaffleDrawAck;
			}
		}

		// Token: 0x06012502 RID: 75010 RVA: 0x004B4740 File Offset: 0x004B2940
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRaffleDrawReq(this.m_poolId);
		}

		// Token: 0x06012503 RID: 75011 RVA: 0x004B4770 File Offset: 0x004B2970
		protected void OnRaffleDrawAck(int res, int raffleId, Goods goods)
		{
			base.Result = res;
			this.DrawnRaffleId = raffleId;
			this.DrawnGoods = goods;
			base.Stop();
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x06012504 RID: 75012 RVA: 0x004B4790 File Offset: 0x004B2990
		// (set) Token: 0x06012505 RID: 75013 RVA: 0x004B4798 File Offset: 0x004B2998
		public Goods DrawnGoods { get; private set; }

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x06012506 RID: 75014 RVA: 0x004B47A4 File Offset: 0x004B29A4
		// (set) Token: 0x06012507 RID: 75015 RVA: 0x004B47AC File Offset: 0x004B29AC
		public int DrawnRaffleId { get; private set; }

		// Token: 0x0400A4F8 RID: 42232
		protected int m_poolId;
	}
}
