using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E69 RID: 3689
	[CustomLuaClass]
	public class MailAttachmentsAutoGetNetTask : UINetTask
	{
		// Token: 0x06011E32 RID: 73266 RVA: 0x0049F04C File Offset: 0x0049D24C
		public MailAttachmentsAutoGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06011E33 RID: 73267 RVA: 0x0049F05C File Offset: 0x0049D25C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMailAttachmentsAutoGetAck += this.OnMailAttachmentsAutoGetAck;
		}

		// Token: 0x06011E34 RID: 73268 RVA: 0x0049F094 File Offset: 0x0049D294
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMailAttachmentsAutoGetAck -= this.OnMailAttachmentsAutoGetAck;
			}
		}

		// Token: 0x06011E35 RID: 73269 RVA: 0x0049F0D0 File Offset: 0x0049D2D0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendMailAttachmentAutoGetReq();
		}

		// Token: 0x06011E36 RID: 73270 RVA: 0x0049F0FC File Offset: 0x0049D2FC
		private void OnMailAttachmentsAutoGetAck(int result, List<Goods> reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x06011E38 RID: 73272 RVA: 0x0049F120 File Offset: 0x0049D320
		// (set) Token: 0x06011E37 RID: 73271 RVA: 0x0049F114 File Offset: 0x0049D314
		public List<Goods> Reward { get; private set; }
	}
}
