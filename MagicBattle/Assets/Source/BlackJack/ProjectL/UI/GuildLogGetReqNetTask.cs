using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D35 RID: 3381
	[CustomLuaClass]
	public class GuildLogGetReqNetTask : UINetTask
	{
		// Token: 0x0600F87A RID: 63610 RVA: 0x00418868 File Offset: 0x00416A68
		public GuildLogGetReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F87B RID: 63611 RVA: 0x00418878 File Offset: 0x00416A78
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildLogGetAck += this.OnMsgAck;
		}

		// Token: 0x0600F87C RID: 63612 RVA: 0x004188B0 File Offset: 0x00416AB0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildLogGetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F87D RID: 63613 RVA: 0x004188EC File Offset: 0x00416AEC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildLogGetReq();
		}

		// Token: 0x0600F87E RID: 63614 RVA: 0x00418918 File Offset: 0x00416B18
		protected void OnMsgAck(int result, List<GuildLog> logs)
		{
			base.Result = result;
			this.GuildLogs = logs;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600F87F RID: 63615 RVA: 0x00418930 File Offset: 0x00416B30
		// (set) Token: 0x0600F880 RID: 63616 RVA: 0x00418938 File Offset: 0x00416B38
		public List<GuildLog> GuildLogs { get; private set; }
	}
}
