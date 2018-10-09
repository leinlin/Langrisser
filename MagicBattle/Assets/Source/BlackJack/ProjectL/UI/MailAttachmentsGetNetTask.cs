using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E68 RID: 3688
	[CustomLuaClass]
	public class MailAttachmentsGetNetTask : UINetTask
	{
		// Token: 0x06011E2B RID: 73259 RVA: 0x0049EF64 File Offset: 0x0049D164
		public MailAttachmentsGetNetTask(ulong instanceID) : base(10f, null, true)
		{
			this.m_instanceID = instanceID;
		}

		// Token: 0x06011E2C RID: 73260 RVA: 0x0049EF7C File Offset: 0x0049D17C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMailAttachmentsGetAck += this.OnMailAttachmentsGetAck;
		}

		// Token: 0x06011E2D RID: 73261 RVA: 0x0049EFB4 File Offset: 0x0049D1B4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMailAttachmentsGetAck -= this.OnMailAttachmentsGetAck;
			}
		}

		// Token: 0x06011E2E RID: 73262 RVA: 0x0049EFF0 File Offset: 0x0049D1F0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendMailAttachmentsGetReq(this.m_instanceID);
		}

		// Token: 0x06011E2F RID: 73263 RVA: 0x0049F020 File Offset: 0x0049D220
		private void OnMailAttachmentsGetAck(int result, List<Goods> reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x06011E31 RID: 73265 RVA: 0x0049F044 File Offset: 0x0049D244
		// (set) Token: 0x06011E30 RID: 73264 RVA: 0x0049F038 File Offset: 0x0049D238
		public List<Goods> Reward { get; private set; }

		// Token: 0x0400A275 RID: 41589
		private ulong m_instanceID;
	}
}
