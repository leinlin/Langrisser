using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D24 RID: 3364
	[CustomLuaClass]
	public class GuildJoinApplyReqNetTask : UINetTask
	{
		// Token: 0x0600F815 RID: 63509 RVA: 0x00417A10 File Offset: 0x00415C10
		public GuildJoinApplyReqNetTask(string guildID) : base(10f, null, true)
		{
			this.m_guildID = guildID;
		}

		// Token: 0x0600F816 RID: 63510 RVA: 0x00417A28 File Offset: 0x00415C28
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinApplyAck += this.OnMsgAck;
		}

		// Token: 0x0600F817 RID: 63511 RVA: 0x00417A60 File Offset: 0x00415C60
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinApplyAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F818 RID: 63512 RVA: 0x00417A9C File Offset: 0x00415C9C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildJoinApplyReq(this.m_guildID);
		}

		// Token: 0x0600F819 RID: 63513 RVA: 0x00417ACC File Offset: 0x00415CCC
		protected void OnMsgAck(int result)
		{
			if (result == 0)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				projectLPlayerContext.RefreshGuildListJoinState(this.m_guildID);
			}
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400922A RID: 37418
		private string m_guildID;
	}
}
