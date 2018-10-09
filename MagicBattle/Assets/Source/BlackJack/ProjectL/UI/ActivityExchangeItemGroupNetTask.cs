using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000992 RID: 2450
	[CustomLuaClass]
	public class ActivityExchangeItemGroupNetTask : UINetTask
	{
		// Token: 0x06008D2B RID: 36139 RVA: 0x00293350 File Offset: 0x00291550
		public ActivityExchangeItemGroupNetTask(ulong activityInatanceID, int itemGroupIndex) : base(10f, null, true)
		{
			this.m_activityInstanceID = activityInatanceID;
			this.m_itemGroupIndex = itemGroupIndex;
		}

		// Token: 0x06008D2C RID: 36140 RVA: 0x00293370 File Offset: 0x00291570
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnActivityExchangeItemGroupAck += this.OnActivityExchangeItemGroupAck;
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x002933A8 File Offset: 0x002915A8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnActivityExchangeItemGroupAck -= this.OnActivityExchangeItemGroupAck;
			}
		}

		// Token: 0x06008D2E RID: 36142 RVA: 0x002933E4 File Offset: 0x002915E4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendOperationalActivityExchangeItemGroupReq(this.m_activityInstanceID, this.m_itemGroupIndex);
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x0029341C File Offset: 0x0029161C
		protected void OnActivityExchangeItemGroupAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006445 RID: 25669
		private ulong m_activityInstanceID;

		// Token: 0x04006446 RID: 25670
		private int m_itemGroupIndex;
	}
}
