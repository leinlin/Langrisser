using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F30 RID: 3888
	[CustomLuaClass]
	public class SendOpenMemoryStoreNetTask : UINetTask
	{
		// Token: 0x0601365F RID: 79455 RVA: 0x004F1D18 File Offset: 0x004EFF18
		public SendOpenMemoryStoreNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06013660 RID: 79456 RVA: 0x004F1D28 File Offset: 0x004EFF28
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOpenMemoryStoreAck += this.OnSendOpenMemoryStoreAck;
		}

		// Token: 0x06013661 RID: 79457 RVA: 0x004F1D60 File Offset: 0x004EFF60
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOpenMemoryStoreAck -= this.OnSendOpenMemoryStoreAck;
			}
		}

		// Token: 0x06013662 RID: 79458 RVA: 0x004F1D9C File Offset: 0x004EFF9C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendOpenMemoryStoreReq();
		}

		// Token: 0x06013663 RID: 79459 RVA: 0x004F1DC8 File Offset: 0x004EFFC8
		protected void OnSendOpenMemoryStoreAck()
		{
			this.OnTransactionComplete();
		}
	}
}
