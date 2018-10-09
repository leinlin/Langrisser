using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B1E RID: 2846
	[CustomLuaClass]
	public class BusinessCardGetNetTask : UINetTask
	{
		// Token: 0x0600BFED RID: 49133 RVA: 0x00357CBC File Offset: 0x00355EBC
		public BusinessCardGetNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x00357CD4 File Offset: 0x00355ED4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBusinessCardGetAck += this.OnBusinessCardGetAck;
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x00357D0C File Offset: 0x00355F0C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBusinessCardGetAck -= this.OnBusinessCardGetAck;
			}
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x00357D48 File Offset: 0x00355F48
		protected void OnBusinessCardGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x00357D58 File Offset: 0x00355F58
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBusinessCardSelectReq(this.m_userID);
		}

		// Token: 0x04007A87 RID: 31367
		private string m_userID;
	}
}
