using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F31 RID: 3889
	[CustomLuaClass]
	public class GetRandomStoreItemListNetTask : UINetTask
	{
		// Token: 0x06013664 RID: 79460 RVA: 0x004F1DD0 File Offset: 0x004EFFD0
		public GetRandomStoreItemListNetTask(int randomStoreID) : base(10f, null, true)
		{
			this.m_randomStoreID = randomStoreID;
		}

		// Token: 0x06013665 RID: 79461 RVA: 0x004F1DE8 File Offset: 0x004EFFE8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetRandomStoreListAck += this.OnGetRandomStoreListAck;
		}

		// Token: 0x06013666 RID: 79462 RVA: 0x004F1E20 File Offset: 0x004F0020
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGetRandomStoreListAck -= this.OnGetRandomStoreListAck;
			}
		}

		// Token: 0x06013667 RID: 79463 RVA: 0x004F1E5C File Offset: 0x004F005C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetRandomStoreReq(this.m_randomStoreID);
		}

		// Token: 0x06013668 RID: 79464 RVA: 0x004F1E8C File Offset: 0x004F008C
		protected void OnGetRandomStoreListAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400AC5F RID: 44127
		private int m_randomStoreID;
	}
}
