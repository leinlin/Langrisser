using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000991 RID: 2449
	[CustomLuaClass]
	public class ActivityGainRewardNetTask : UINetTask
	{
		// Token: 0x06008D26 RID: 36134 RVA: 0x00293274 File Offset: 0x00291474
		public ActivityGainRewardNetTask(ulong activityInstanceID, int rewardIndex) : base(10f, null, true)
		{
			this.m_activityInstanceID = activityInstanceID;
			this.m_rewardIndex = rewardIndex;
		}

		// Token: 0x06008D27 RID: 36135 RVA: 0x00293294 File Offset: 0x00291494
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnActivityGainRewardAck += this.OnActivityGainRewardAck;
		}

		// Token: 0x06008D28 RID: 36136 RVA: 0x002932CC File Offset: 0x002914CC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnActivityGainRewardAck -= this.OnActivityGainRewardAck;
			}
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x00293308 File Offset: 0x00291508
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendOperationalActivityGainRewardReq(this.m_activityInstanceID, this.m_rewardIndex);
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x00293340 File Offset: 0x00291540
		protected void OnActivityGainRewardAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006443 RID: 25667
		private ulong m_activityInstanceID;

		// Token: 0x04006444 RID: 25668
		private int m_rewardIndex;
	}
}
