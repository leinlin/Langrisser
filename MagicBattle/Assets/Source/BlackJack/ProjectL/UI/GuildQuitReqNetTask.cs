using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D2A RID: 3370
	[CustomLuaClass]
	public class GuildQuitReqNetTask : UINetTask
	{
		// Token: 0x0600F833 RID: 63539 RVA: 0x00417F08 File Offset: 0x00416108
		public GuildQuitReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F834 RID: 63540 RVA: 0x00417F18 File Offset: 0x00416118
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildQuitAck += this.OnMsgAck;
		}

		// Token: 0x0600F835 RID: 63541 RVA: 0x00417F50 File Offset: 0x00416150
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildQuitAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F836 RID: 63542 RVA: 0x00417F8C File Offset: 0x0041618C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildQuitReq();
		}

		// Token: 0x0600F837 RID: 63543 RVA: 0x00417FB8 File Offset: 0x004161B8
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
