using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F38 RID: 3896
	[CustomLuaClass]
	public class RechargeStoreBuyStoreItemNetTask : UINetTask
	{
		// Token: 0x06013689 RID: 79497 RVA: 0x004F23B8 File Offset: 0x004F05B8
		public RechargeStoreBuyStoreItemNetTask(int storeItemGoodsID) : base(10f, null, true)
		{
			this.m_storeItemGoodsId = storeItemGoodsID;
			this.m_autoRetry = false;
		}

		// Token: 0x0601368A RID: 79498 RVA: 0x004F23D8 File Offset: 0x004F05D8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRechargeStoreItemBuyAck += this.OnStoreBuyStoreItemAck;
		}

		// Token: 0x0601368B RID: 79499 RVA: 0x004F2410 File Offset: 0x004F0610
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRechargeStoreItemBuyAck -= this.OnStoreBuyStoreItemAck;
			}
		}

		// Token: 0x0601368C RID: 79500 RVA: 0x004F244C File Offset: 0x004F064C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRechargeStoreBuyGoodsReq(this.m_storeItemGoodsId);
		}

		// Token: 0x0601368D RID: 79501 RVA: 0x004F247C File Offset: 0x004F067C
		protected void OnStoreBuyStoreItemAck(int result, int goodsId)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400AC6C RID: 44140
		private int m_storeItemGoodsId;
	}
}
