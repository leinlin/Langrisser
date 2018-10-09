using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E67 RID: 3687
	[CustomLuaClass]
	public class MailReadNetTask : UINetTask
	{
		// Token: 0x06011E26 RID: 73254 RVA: 0x0049EE98 File Offset: 0x0049D098
		public MailReadNetTask(ulong instanceID) : base(10f, null, true)
		{
			this.m_instanceID = instanceID;
		}

		// Token: 0x06011E27 RID: 73255 RVA: 0x0049EEB0 File Offset: 0x0049D0B0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMailReadAck += this.OnMailReadAck;
		}

		// Token: 0x06011E28 RID: 73256 RVA: 0x0049EEE8 File Offset: 0x0049D0E8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMailReadAck -= this.OnMailReadAck;
			}
		}

		// Token: 0x06011E29 RID: 73257 RVA: 0x0049EF24 File Offset: 0x0049D124
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendMailReadReq(this.m_instanceID);
		}

		// Token: 0x06011E2A RID: 73258 RVA: 0x0049EF54 File Offset: 0x0049D154
		private void OnMailReadAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400A273 RID: 41587
		public ulong m_instanceID;
	}
}
