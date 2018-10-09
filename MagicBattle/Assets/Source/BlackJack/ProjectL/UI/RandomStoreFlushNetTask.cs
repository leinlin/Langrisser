using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F32 RID: 3890
	[CustomLuaClass]
	public class RandomStoreFlushNetTask : UINetTask
	{
		// Token: 0x06013669 RID: 79465 RVA: 0x004F1E9C File Offset: 0x004F009C
		public RandomStoreFlushNetTask(int randomStoreID) : base(10f, null, true)
		{
			this.m_randomStoreID = randomStoreID;
			this.m_autoRetry = false;
		}

		// Token: 0x0601366A RID: 79466 RVA: 0x004F1EBC File Offset: 0x004F00BC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFlushRandomStoreAck += this.OnFlushRandomStoreAck;
		}

		// Token: 0x0601366B RID: 79467 RVA: 0x004F1EF4 File Offset: 0x004F00F4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFlushRandomStoreAck -= this.OnFlushRandomStoreAck;
			}
		}

		// Token: 0x0601366C RID: 79468 RVA: 0x004F1F30 File Offset: 0x004F0130
		protected void OnFlushRandomStoreAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601366D RID: 79469 RVA: 0x004F1F40 File Offset: 0x004F0140
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFlushRandomStoreReq(this.m_randomStoreID);
		}

		// Token: 0x0400AC60 RID: 44128
		private int m_randomStoreID;
	}
}
