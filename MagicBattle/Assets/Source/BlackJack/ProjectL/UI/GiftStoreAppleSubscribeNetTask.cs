using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F35 RID: 3893
	[CustomLuaClass]
	public class GiftStoreAppleSubscribeNetTask : UINetTask
	{
		// Token: 0x06013679 RID: 79481 RVA: 0x004F2134 File Offset: 0x004F0334
		public GiftStoreAppleSubscribeNetTask(int giftStoreItemGoodsID) : base(10f, null, true)
		{
			this.m_giftStoreItemGoodsId = giftStoreItemGoodsID;
			this.m_autoRetry = false;
		}

		// Token: 0x0601367A RID: 79482 RVA: 0x004F2154 File Offset: 0x004F0354
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGiftStoreAppleSubscribeAck += this.OnGiftStoreAppleSubscribeAck;
		}

		// Token: 0x0601367B RID: 79483 RVA: 0x004F218C File Offset: 0x004F038C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGiftStoreAppleSubscribeAck -= this.OnGiftStoreAppleSubscribeAck;
			}
		}

		// Token: 0x0601367C RID: 79484 RVA: 0x004F21C8 File Offset: 0x004F03C8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGiftStoreAppleSubscribeReq(this.m_giftStoreItemGoodsId);
		}

		// Token: 0x0601367D RID: 79485 RVA: 0x004F21F8 File Offset: 0x004F03F8
		protected void OnGiftStoreAppleSubscribeAck(int result, int goodsId)
		{
			base.Result = result;
			this.m_goodsId = goodsId;
			this.OnTransactionComplete();
		}

		// Token: 0x17003A8C RID: 14988
		// (get) Token: 0x0601367E RID: 79486 RVA: 0x004F2210 File Offset: 0x004F0410
		public int GoodsId
		{
			get
			{
				return this.m_goodsId;
			}
		}

		// Token: 0x0400AC66 RID: 44134
		private int m_fixedStoreID;

		// Token: 0x0400AC67 RID: 44135
		private int m_giftStoreItemGoodsId;

		// Token: 0x0400AC68 RID: 44136
		private int m_goodsId;
	}
}
