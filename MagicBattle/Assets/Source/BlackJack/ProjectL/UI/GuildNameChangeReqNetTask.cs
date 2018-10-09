using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D34 RID: 3380
	[CustomLuaClass]
	public class GuildNameChangeReqNetTask : UINetTask
	{
		// Token: 0x0600F875 RID: 63605 RVA: 0x0041879C File Offset: 0x0041699C
		public GuildNameChangeReqNetTask(string name) : base(10f, null, true)
		{
			this.m_guildName = name;
		}

		// Token: 0x0600F876 RID: 63606 RVA: 0x004187B4 File Offset: 0x004169B4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildNameChangeAck += this.OnMsgAck;
		}

		// Token: 0x0600F877 RID: 63607 RVA: 0x004187EC File Offset: 0x004169EC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildNameChangeAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F878 RID: 63608 RVA: 0x00418828 File Offset: 0x00416A28
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildNameChangeReq(this.m_guildName);
		}

		// Token: 0x0600F879 RID: 63609 RVA: 0x00418858 File Offset: 0x00416A58
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400923C RID: 37436
		private string m_guildName;
	}
}
