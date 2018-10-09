using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A1B RID: 2587
	[CustomLuaClass]
	public class RealTimePVPCancelWaitingForOpponentNetTask : UINetTask
	{
		// Token: 0x06009B59 RID: 39769 RVA: 0x002C3BA4 File Offset: 0x002C1DA4
		public RealTimePVPCancelWaitingForOpponentNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x002C3BB4 File Offset: 0x002C1DB4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRealTimePVPCancelWaitingForOpponentAck += this.OnRealTimePVPCancelWaitingForOpponentAck;
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x002C3BEC File Offset: 0x002C1DEC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRealTimePVPCancelWaitingForOpponentAck -= this.OnRealTimePVPCancelWaitingForOpponentAck;
			}
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x002C3C28 File Offset: 0x002C1E28
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRealTimePVPCancelWaitingForOpponentReq();
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x002C3C54 File Offset: 0x002C1E54
		protected void OnRealTimePVPCancelWaitingForOpponentAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
