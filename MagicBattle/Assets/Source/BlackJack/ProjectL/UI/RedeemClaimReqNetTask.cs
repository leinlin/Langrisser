using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000994 RID: 2452
	[CustomLuaClass]
	public class RedeemClaimReqNetTask : UINetTask
	{
		// Token: 0x06008D37 RID: 36151 RVA: 0x00293514 File Offset: 0x00291714
		public RedeemClaimReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x00293524 File Offset: 0x00291724
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnActivityRedeemClaimAck += this.OnRedeemClaimAck;
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x0029355C File Offset: 0x0029175C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnActivityRedeemClaimAck -= this.OnRedeemClaimAck;
			}
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00293598 File Offset: 0x00291798
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRedeemClaimReq();
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x002935C4 File Offset: 0x002917C4
		protected void OnRedeemClaimAck(int crystal)
		{
			this.CrystalVal = crystal;
			this.OnTransactionComplete();
		}

		// Token: 0x04006449 RID: 25673
		public int CrystalVal;
	}
}
