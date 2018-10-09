using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F34 RID: 3892
	[CustomLuaClass]
	public class GiftStoreBuyStoreItemNetTask : UINetTask
	{
		// Token: 0x06013673 RID: 79475 RVA: 0x004F2050 File Offset: 0x004F0250
		public GiftStoreBuyStoreItemNetTask(int giftStoreItemGoodsID) : base(10f, null, true)
		{
			this.m_giftStoreItemGoodsId = giftStoreItemGoodsID;
			this.m_autoRetry = false;
		}

		// Token: 0x06013674 RID: 79476 RVA: 0x004F2070 File Offset: 0x004F0270
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGiftStoreItemBuyAck += this.OnGiftStoreBuyStoreItemAck;
		}

		// Token: 0x06013675 RID: 79477 RVA: 0x004F20A8 File Offset: 0x004F02A8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGiftStoreItemBuyAck -= this.OnGiftStoreBuyStoreItemAck;
			}
		}

		// Token: 0x06013676 RID: 79478 RVA: 0x004F20E4 File Offset: 0x004F02E4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGiftStoreItemBuyReq(this.m_giftStoreItemGoodsId);
		}

		// Token: 0x06013677 RID: 79479 RVA: 0x004F2114 File Offset: 0x004F0314
		protected void OnGiftStoreBuyStoreItemAck(int result, int goodsId)
		{
			base.Result = result;
			this.m_goodsId = goodsId;
			this.OnTransactionComplete();
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x06013678 RID: 79480 RVA: 0x004F212C File Offset: 0x004F032C
		public int GoodsId
		{
			get
			{
				return this.m_goodsId;
			}
		}

		// Token: 0x0400AC63 RID: 44131
		private int m_fixedStoreID;

		// Token: 0x0400AC64 RID: 44132
		private int m_giftStoreItemGoodsId;

		// Token: 0x0400AC65 RID: 44133
		private int m_goodsId;
	}
}
