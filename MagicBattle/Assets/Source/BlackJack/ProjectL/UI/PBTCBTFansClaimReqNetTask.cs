using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000995 RID: 2453
	[CustomLuaClass]
	public class PBTCBTFansClaimReqNetTask : UINetTask
	{
		// Token: 0x06008D3C RID: 36156 RVA: 0x002935D4 File Offset: 0x002917D4
		public PBTCBTFansClaimReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x002935E4 File Offset: 0x002917E4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnActivityFansRewardsFromPBTCBT += this.OnPBTCBTFansClaimAck;
		}

		// Token: 0x06008D3E RID: 36158 RVA: 0x0029361C File Offset: 0x0029181C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnActivityFansRewardsFromPBTCBT -= this.OnPBTCBTFansClaimAck;
			}
		}

		// Token: 0x06008D3F RID: 36159 RVA: 0x00293658 File Offset: 0x00291858
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFansRewardsFromPBTCBTClaimReq();
		}

		// Token: 0x06008D40 RID: 36160 RVA: 0x00293684 File Offset: 0x00291884
		protected void OnPBTCBTFansClaimAck(int result, List<Goods> goodsdList)
		{
			this.goodsList = goodsdList;
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400644A RID: 25674
		public List<Goods> goodsList;
	}
}
