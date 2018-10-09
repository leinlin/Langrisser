using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D33 RID: 3379
	[CustomLuaClass]
	public class GuildJoinApplyGetReqNetTask : UINetTask
	{
		// Token: 0x0600F86E RID: 63598 RVA: 0x004186C0 File Offset: 0x004168C0
		public GuildJoinApplyGetReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F86F RID: 63599 RVA: 0x004186D0 File Offset: 0x004168D0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinApplyGetAck += this.OnMsgAck;
		}

		// Token: 0x0600F870 RID: 63600 RVA: 0x00418708 File Offset: 0x00416908
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinApplyGetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F871 RID: 63601 RVA: 0x00418744 File Offset: 0x00416944
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildJoinApplyGetReq();
		}

		// Token: 0x0600F872 RID: 63602 RVA: 0x00418770 File Offset: 0x00416970
		protected void OnMsgAck(int result, List<UserSummary> players)
		{
			base.Result = result;
			this.Players = players;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600F873 RID: 63603 RVA: 0x00418788 File Offset: 0x00416988
		// (set) Token: 0x0600F874 RID: 63604 RVA: 0x00418790 File Offset: 0x00416990
		public List<UserSummary> Players { get; private set; }
	}
}
