using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A1C RID: 2588
	[CustomLuaClass]
	public class RealTimePVPGetInfoNetTask : UINetTask
	{
		// Token: 0x06009B5E RID: 39774 RVA: 0x002C3C64 File Offset: 0x002C1E64
		public RealTimePVPGetInfoNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x002C3C74 File Offset: 0x002C1E74
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRealTimePVPGetInfoAck += this.OnRealTimePVPGetInfoAck;
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x002C3CAC File Offset: 0x002C1EAC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRealTimePVPGetInfoAck -= this.OnRealTimePVPGetInfoAck;
			}
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x002C3CE8 File Offset: 0x002C1EE8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRealTimePVPGetInfoReq();
		}

		// Token: 0x06009B62 RID: 39778 RVA: 0x002C3D14 File Offset: 0x002C1F14
		protected void OnRealTimePVPGetInfoAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
