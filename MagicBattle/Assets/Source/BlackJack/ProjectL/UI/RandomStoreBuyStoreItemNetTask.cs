using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F33 RID: 3891
	[CustomLuaClass]
	public class RandomStoreBuyStoreItemNetTask : UINetTask
	{
		// Token: 0x0601366E RID: 79470 RVA: 0x004F1F70 File Offset: 0x004F0170
		public RandomStoreBuyStoreItemNetTask(int randomStoreID, int randomStoreItemIndex) : base(10f, null, true)
		{
			this.m_randomStoreID = randomStoreID;
			this.m_randomStoreItemIndex = randomStoreItemIndex;
			this.m_autoRetry = false;
		}

		// Token: 0x0601366F RID: 79471 RVA: 0x004F1F94 File Offset: 0x004F0194
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRandomStoreBuyStoreItemAck += this.OnRandomStoreBuyStoreItemAck;
		}

		// Token: 0x06013670 RID: 79472 RVA: 0x004F1FCC File Offset: 0x004F01CC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRandomStoreBuyStoreItemAck -= this.OnRandomStoreBuyStoreItemAck;
			}
		}

		// Token: 0x06013671 RID: 79473 RVA: 0x004F2008 File Offset: 0x004F0208
		protected void OnRandomStoreBuyStoreItemAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06013672 RID: 79474 RVA: 0x004F2018 File Offset: 0x004F0218
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBuyRandomStoreItemReq(this.m_randomStoreID, this.m_randomStoreItemIndex, -1);
		}

		// Token: 0x0400AC61 RID: 44129
		private int m_randomStoreID;

		// Token: 0x0400AC62 RID: 44130
		private int m_randomStoreItemIndex;
	}
}
