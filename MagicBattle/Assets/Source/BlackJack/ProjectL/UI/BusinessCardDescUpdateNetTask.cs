using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B1F RID: 2847
	[CustomLuaClass]
	public class BusinessCardDescUpdateNetTask : UINetTask
	{
		// Token: 0x0600BFF2 RID: 49138 RVA: 0x00357D88 File Offset: 0x00355F88
		public BusinessCardDescUpdateNetTask(string desc) : base(10f, null, true)
		{
			this.m_desc = desc;
		}

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x00357DA0 File Offset: 0x00355FA0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBusinessCardDescUpdateAck += this.OnBusinessCardDescUpdateAck;
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x00357DD8 File Offset: 0x00355FD8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBusinessCardDescUpdateAck -= this.OnBusinessCardDescUpdateAck;
			}
		}

		// Token: 0x0600BFF5 RID: 49141 RVA: 0x00357E14 File Offset: 0x00356014
		protected void OnBusinessCardDescUpdateAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600BFF6 RID: 49142 RVA: 0x00357E24 File Offset: 0x00356024
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBusinessCardDescUpdateReq(this.m_desc);
		}

		// Token: 0x04007A88 RID: 31368
		private string m_desc;
	}
}
