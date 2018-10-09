using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A7E RID: 2686
	[CustomLuaClass]
	public class BattleCancelNetTask : UINetTask
	{
		// Token: 0x0600A9DF RID: 43487 RVA: 0x002F5CC8 File Offset: 0x002F3EC8
		public BattleCancelNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x002F5CD8 File Offset: 0x002F3ED8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleCancelAck += this.OnBattleCancelAck;
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x002F5D10 File Offset: 0x002F3F10
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleCancelAck -= this.OnBattleCancelAck;
			}
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x002F5D4C File Offset: 0x002F3F4C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleCancelReq();
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x002F5D78 File Offset: 0x002F3F78
		protected void OnBattleCancelAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
