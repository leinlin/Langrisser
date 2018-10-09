using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x0200102A RID: 4138
	[CustomLuaClass]
	public class BuyEnergyNetTask : UINetTask
	{
		// Token: 0x06014F3C RID: 85820 RVA: 0x0054D4A0 File Offset: 0x0054B6A0
		public BuyEnergyNetTask() : base(10f, null, true)
		{
			this.m_autoRetry = false;
		}

		// Token: 0x06014F3D RID: 85821 RVA: 0x0054D4B8 File Offset: 0x0054B6B8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBuyEnergyAck += this.OnBuyEnergyAck;
		}

		// Token: 0x06014F3E RID: 85822 RVA: 0x0054D4F0 File Offset: 0x0054B6F0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBuyEnergyAck -= this.OnBuyEnergyAck;
			}
		}

		// Token: 0x06014F3F RID: 85823 RVA: 0x0054D52C File Offset: 0x0054B72C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBuyEnergyReq();
		}

		// Token: 0x06014F40 RID: 85824 RVA: 0x0054D558 File Offset: 0x0054B758
		protected void OnBuyEnergyAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
