using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D2D RID: 3373
	[CustomLuaClass]
	public class GuildJoinInvitationGetReqNetTask : UINetTask
	{
		// Token: 0x0600F846 RID: 63558 RVA: 0x00418184 File Offset: 0x00416384
		public GuildJoinInvitationGetReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F847 RID: 63559 RVA: 0x00418194 File Offset: 0x00416394
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinInvitationGetAck += this.OnMsgAck;
		}

		// Token: 0x0600F848 RID: 63560 RVA: 0x004181CC File Offset: 0x004163CC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinInvitationGetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F849 RID: 63561 RVA: 0x00418208 File Offset: 0x00416408
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildJoinInvitationGetReq();
		}

		// Token: 0x0600F84A RID: 63562 RVA: 0x00418234 File Offset: 0x00416434
		protected void OnMsgAck(int result, List<GuildJoinInvitation> guildJoinInvitationList)
		{
			this.m_guildJoinInvitationList = guildJoinInvitationList;
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009233 RID: 37427
		public List<GuildJoinInvitation> m_guildJoinInvitationList;
	}
}
