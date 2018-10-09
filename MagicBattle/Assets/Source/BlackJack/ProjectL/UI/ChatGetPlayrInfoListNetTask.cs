using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B4F RID: 2895
	[CustomLuaClass]
	public class ChatGetPlayrInfoListNetTask : UINetTask
	{
		// Token: 0x0600C4D2 RID: 50386 RVA: 0x003674D4 File Offset: 0x003656D4
		public ChatGetPlayrInfoListNetTask(List<string> playerIdList) : base(10f, null, true)
		{
			this.m_playerIdList = new List<string>(playerIdList);
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x003674F0 File Offset: 0x003656F0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatContactUserSummaryInfoAck += this.OnChatContactUserSummaryInfoAck;
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x00367528 File Offset: 0x00365728
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatContactUserSummaryInfoAck -= this.OnChatContactUserSummaryInfoAck;
			}
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x00367564 File Offset: 0x00365764
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetChatContactUserSummaryInfoMessage(this.m_playerIdList);
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x00367598 File Offset: 0x00365798
		private void OnChatContactUserSummaryInfoAck()
		{
			base.Result = 0;
			this.OnTransactionComplete();
		}

		// Token: 0x04007C9B RID: 31899
		private List<string> m_playerIdList;
	}
}
