using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F2E RID: 3886
	[CustomLuaClass]
	public class FixedStoreBuyStoreItemNetTask : UINetTask
	{
		// Token: 0x06013653 RID: 79443 RVA: 0x004F1B50 File Offset: 0x004EFD50
		public FixedStoreBuyStoreItemNetTask(int fixedStoreID, int fixedStoreItemGoodsID, int selfChoooseItemIndex = -1) : base(10f, null, true)
		{
			this.m_fixedStoreID = fixedStoreID;
			this.m_fixedStoreItemGoodsID = fixedStoreItemGoodsID;
			this.m_selfChooseItemIndex = selfChoooseItemIndex;
			this.m_autoRetry = false;
		}

		// Token: 0x06013654 RID: 79444 RVA: 0x004F1B7C File Offset: 0x004EFD7C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFixedStoreBuyStoreItemAck += this.OnFixedStoreBuyStoreItemAck;
		}

		// Token: 0x06013655 RID: 79445 RVA: 0x004F1BB4 File Offset: 0x004EFDB4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFixedStoreBuyStoreItemAck -= this.OnFixedStoreBuyStoreItemAck;
			}
		}

		// Token: 0x06013656 RID: 79446 RVA: 0x004F1BF0 File Offset: 0x004EFDF0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFixedStoreBuyStoreItemReq(this.m_fixedStoreID, this.m_fixedStoreItemGoodsID, this.m_selfChooseItemIndex);
		}

		// Token: 0x06013657 RID: 79447 RVA: 0x004F1C2C File Offset: 0x004EFE2C
		protected void OnFixedStoreBuyStoreItemAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400AC5B RID: 44123
		private int m_fixedStoreID;

		// Token: 0x0400AC5C RID: 44124
		private int m_fixedStoreItemGoodsID;

		// Token: 0x0400AC5D RID: 44125
		private int m_selfChooseItemIndex;
	}
}
