using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D30 RID: 3376
	[CustomLuaClass]
	public class GuildGetReqNetTask : UINetTask
	{
		// Token: 0x0600F855 RID: 63573 RVA: 0x004183D8 File Offset: 0x004165D8
		public GuildGetReqNetTask(string guildID) : base(10f, null, true)
		{
			this.m_guildID = guildID;
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x004183F0 File Offset: 0x004165F0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildGetAck += this.OnMsgAck;
		}

		// Token: 0x0600F857 RID: 63575 RVA: 0x00418428 File Offset: 0x00416628
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildGetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F858 RID: 63576 RVA: 0x00418464 File Offset: 0x00416664
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildGetReq(this.m_guildID);
		}

		// Token: 0x0600F859 RID: 63577 RVA: 0x00418494 File Offset: 0x00416694
		protected void OnMsgAck(int result, Guild guild)
		{
			base.Result = result;
			this.GuildInfo = guild;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600F85A RID: 63578 RVA: 0x004184AC File Offset: 0x004166AC
		// (set) Token: 0x0600F85B RID: 63579 RVA: 0x004184B4 File Offset: 0x004166B4
		public Guild GuildInfo { get; private set; }

		// Token: 0x04009235 RID: 37429
		private string m_guildID;
	}
}
