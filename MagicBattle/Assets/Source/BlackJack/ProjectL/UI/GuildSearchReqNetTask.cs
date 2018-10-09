using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D29 RID: 3369
	[CustomLuaClass]
	public class GuildSearchReqNetTask : UINetTask
	{
		// Token: 0x0600F82E RID: 63534 RVA: 0x00417E34 File Offset: 0x00416034
		public GuildSearchReqNetTask(string searchText) : base(10f, null, true)
		{
			this.m_searchText = searchText;
		}

		// Token: 0x0600F82F RID: 63535 RVA: 0x00417E4C File Offset: 0x0041604C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildSearchAck += this.OnMsgAck;
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x00417E84 File Offset: 0x00416084
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildSearchAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F831 RID: 63537 RVA: 0x00417EC0 File Offset: 0x004160C0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildSearchReq(this.m_searchText);
		}

		// Token: 0x0600F832 RID: 63538 RVA: 0x00417EF0 File Offset: 0x004160F0
		protected void OnMsgAck(int result, List<GuildSearchInfo> guildSearchInfo)
		{
			base.Result = result;
			this.m_guildSearchInfoList = guildSearchInfo;
			this.OnTransactionComplete();
		}

		// Token: 0x0400922F RID: 37423
		private string m_searchText;

		// Token: 0x04009230 RID: 37424
		public List<GuildSearchInfo> m_guildSearchInfoList;
	}
}
