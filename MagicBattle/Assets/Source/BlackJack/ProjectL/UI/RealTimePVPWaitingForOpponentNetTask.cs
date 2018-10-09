using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A1A RID: 2586
	[CustomLuaClass]
	public class RealTimePVPWaitingForOpponentNetTask : UINetTask
	{
		// Token: 0x06009B52 RID: 39762 RVA: 0x002C3ABC File Offset: 0x002C1CBC
		public RealTimePVPWaitingForOpponentNetTask(BattleMode mode) : base(10f, null, true)
		{
			this.m_mode = mode;
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x002C3AD4 File Offset: 0x002C1CD4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRealTimePVPWaitingForOpponentAck += this.OnRealTimePVPWaitingForOpponentAck;
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x002C3B0C File Offset: 0x002C1D0C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRealTimePVPWaitingForOpponentAck -= this.OnRealTimePVPWaitingForOpponentAck;
			}
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x002C3B48 File Offset: 0x002C1D48
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRealTimePVPWaitingForOpponentReq(this.m_mode);
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x002C3B78 File Offset: 0x002C1D78
		protected void OnRealTimePVPWaitingForOpponentAck(int result, int expectedWaitingTime)
		{
			base.Result = result;
			this.ExpectedWaitingTime = expectedWaitingTime;
			this.OnTransactionComplete();
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06009B58 RID: 39768 RVA: 0x002C3B9C File Offset: 0x002C1D9C
		// (set) Token: 0x06009B57 RID: 39767 RVA: 0x002C3B90 File Offset: 0x002C1D90
		public int ExpectedWaitingTime { get; private set; }

		// Token: 0x040069CB RID: 27083
		private BattleMode m_mode;
	}
}
