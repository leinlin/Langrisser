using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D32 RID: 3378
	[CustomLuaClass]
	public class GuildAnnouncementSetReqNetTask : UINetTask
	{
		// Token: 0x0600F867 RID: 63591 RVA: 0x004185E0 File Offset: 0x004167E0
		public GuildAnnouncementSetReqNetTask(string announcement) : base(10f, null, true)
		{
			this.Announcement = announcement;
		}

		// Token: 0x0600F868 RID: 63592 RVA: 0x004185F8 File Offset: 0x004167F8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildAnnouncementSetAck += this.OnMsgAck;
		}

		// Token: 0x0600F869 RID: 63593 RVA: 0x00418630 File Offset: 0x00416830
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildAnnouncementSetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F86A RID: 63594 RVA: 0x0041866C File Offset: 0x0041686C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildAnnouncementSetReq(this.Announcement);
		}

		// Token: 0x0600F86B RID: 63595 RVA: 0x0041869C File Offset: 0x0041689C
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x0600F86C RID: 63596 RVA: 0x004186AC File Offset: 0x004168AC
		// (set) Token: 0x0600F86D RID: 63597 RVA: 0x004186B4 File Offset: 0x004168B4
		public string Announcement { get; private set; }
	}
}
