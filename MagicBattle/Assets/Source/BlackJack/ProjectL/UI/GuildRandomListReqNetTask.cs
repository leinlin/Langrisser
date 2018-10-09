using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D28 RID: 3368
	[CustomLuaClass]
	public class GuildRandomListReqNetTask : UINetTask
	{
		// Token: 0x0600F829 RID: 63529 RVA: 0x00417D6C File Offset: 0x00415F6C
		public GuildRandomListReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F82A RID: 63530 RVA: 0x00417D7C File Offset: 0x00415F7C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildRandomListAck += this.OnMsgAck;
		}

		// Token: 0x0600F82B RID: 63531 RVA: 0x00417DB4 File Offset: 0x00415FB4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildRandomListAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F82C RID: 63532 RVA: 0x00417DF0 File Offset: 0x00415FF0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildRandomListReq();
		}

		// Token: 0x0600F82D RID: 63533 RVA: 0x00417E1C File Offset: 0x0041601C
		protected void OnMsgAck(int result, List<GuildSearchInfo> guildSearchInfo)
		{
			base.Result = result;
			this.m_guildSearchInfoList = guildSearchInfo;
			this.OnTransactionComplete();
		}

		// Token: 0x0400922E RID: 37422
		public List<GuildSearchInfo> m_guildSearchInfoList;
	}
}
