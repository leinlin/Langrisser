using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F39 RID: 3897
	[CustomLuaClass]
	public class RechargeStoreCancelBuyNetTask : UINetTask
	{
		// Token: 0x0601368E RID: 79502 RVA: 0x004F248C File Offset: 0x004F068C
		public RechargeStoreCancelBuyNetTask(int storeItemGoodsID) : base(10f, null, true)
		{
			this.m_storeItemGoodsId = storeItemGoodsID;
		}

		// Token: 0x0601368F RID: 79503 RVA: 0x004F24A4 File Offset: 0x004F06A4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRechargeStoreCancelBuyAck += this.OnStoreCancelBuyStoreItemAck;
		}

		// Token: 0x06013690 RID: 79504 RVA: 0x004F24DC File Offset: 0x004F06DC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRechargeStoreCancelBuyAck -= this.OnStoreCancelBuyStoreItemAck;
			}
		}

		// Token: 0x06013691 RID: 79505 RVA: 0x004F2518 File Offset: 0x004F0718
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRechargeStoreCancelBuyReq(this.m_storeItemGoodsId);
		}

		// Token: 0x06013692 RID: 79506 RVA: 0x004F2548 File Offset: 0x004F0748
		protected void OnStoreCancelBuyStoreItemAck(int result, int goodsId)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400AC6D RID: 44141
		private int m_storeItemGoodsId;
	}
}
