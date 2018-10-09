using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F36 RID: 3894
	[CustomLuaClass]
	public class GiftStoreCancelBuyNetTask : UINetTask
	{
		// Token: 0x0601367F RID: 79487 RVA: 0x004F2218 File Offset: 0x004F0418
		public GiftStoreCancelBuyNetTask(int giftStoreItemid) : base(10f, null, true)
		{
			this.m_giftStoreItemId = giftStoreItemid;
		}

		// Token: 0x06013680 RID: 79488 RVA: 0x004F2230 File Offset: 0x004F0430
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGiftStoreItemCancelBuyAck += this.OnGiftStoreCancelBuyStoreItemAck;
		}

		// Token: 0x06013681 RID: 79489 RVA: 0x004F2268 File Offset: 0x004F0468
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGiftStoreItemCancelBuyAck -= this.OnGiftStoreCancelBuyStoreItemAck;
			}
		}

		// Token: 0x06013682 RID: 79490 RVA: 0x004F22A4 File Offset: 0x004F04A4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGiftStoreCancelBuyReq(this.m_giftStoreItemId);
		}

		// Token: 0x06013683 RID: 79491 RVA: 0x004F22D4 File Offset: 0x004F04D4
		protected void OnGiftStoreCancelBuyStoreItemAck(int result, int goodsId)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400AC69 RID: 44137
		private int m_giftStoreItemId;
	}
}
