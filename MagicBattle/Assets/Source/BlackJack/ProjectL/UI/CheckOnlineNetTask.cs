using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E93 RID: 3731
	[CustomLuaClass]
	public class CheckOnlineNetTask : UINetTask
	{
		// Token: 0x060122C4 RID: 74436 RVA: 0x004AD0CC File Offset: 0x004AB2CC
		public CheckOnlineNetTask() : base(10f, null, true)
		{
			this.m_autoRetry = true;
			this.m_isDisableInput = false;
		}

		// Token: 0x060122C5 RID: 74437 RVA: 0x004AD0EC File Offset: 0x004AB2EC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCheckOnlineAck += this.OnCheckOnlineAck;
		}

		// Token: 0x060122C6 RID: 74438 RVA: 0x004AD124 File Offset: 0x004AB324
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCheckOnlineAck -= this.OnCheckOnlineAck;
			}
		}

		// Token: 0x060122C7 RID: 74439 RVA: 0x004AD160 File Offset: 0x004AB360
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendCheckOnlineReq();
		}

		// Token: 0x060122C8 RID: 74440 RVA: 0x004AD18C File Offset: 0x004AB38C
		protected void OnCheckOnlineAck()
		{
			base.Result = 0;
			this.OnTransactionComplete();
		}
	}
}
