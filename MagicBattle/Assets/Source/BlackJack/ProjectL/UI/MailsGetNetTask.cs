using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E66 RID: 3686
	[CustomLuaClass]
	public class MailsGetNetTask : UINetTask
	{
		// Token: 0x06011E21 RID: 73249 RVA: 0x0049EDD8 File Offset: 0x0049CFD8
		public MailsGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06011E22 RID: 73250 RVA: 0x0049EDE8 File Offset: 0x0049CFE8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMailsGetAck += this.OnMailsGetAck;
		}

		// Token: 0x06011E23 RID: 73251 RVA: 0x0049EE20 File Offset: 0x0049D020
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMailsGetAck -= this.OnMailsGetAck;
			}
		}

		// Token: 0x06011E24 RID: 73252 RVA: 0x0049EE5C File Offset: 0x0049D05C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendMailsGetReq();
		}

		// Token: 0x06011E25 RID: 73253 RVA: 0x0049EE88 File Offset: 0x0049D088
		protected void OnMailsGetAck()
		{
			base.Result = 0;
			this.OnTransactionComplete();
		}
	}
}
