using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D2B RID: 3371
	[CustomLuaClass]
	public class GuildInvitePlayerListReqNetTask : UINetTask
	{
		// Token: 0x0600F838 RID: 63544 RVA: 0x00417FC8 File Offset: 0x004161C8
		public GuildInvitePlayerListReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F839 RID: 63545 RVA: 0x00417FD8 File Offset: 0x004161D8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildInvitePlayerListAck += this.OnMsgAck;
		}

		// Token: 0x0600F83A RID: 63546 RVA: 0x00418010 File Offset: 0x00416210
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildInvitePlayerListAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F83B RID: 63547 RVA: 0x0041804C File Offset: 0x0041624C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildInvitePlayerListReq();
		}

		// Token: 0x0600F83C RID: 63548 RVA: 0x00418078 File Offset: 0x00416278
		protected void OnMsgAck(int result, List<UserSummary> playerList)
		{
			base.Result = result;
			this.PlayerList = playerList;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600F83D RID: 63549 RVA: 0x00418090 File Offset: 0x00416290
		// (set) Token: 0x0600F83E RID: 63550 RVA: 0x00418098 File Offset: 0x00416298
		public List<UserSummary> PlayerList { get; private set; }
	}
}
