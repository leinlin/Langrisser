using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D23 RID: 3363
	[CustomLuaClass]
	public class GuildCreateReqNetTask : UINetTask
	{
		// Token: 0x0600F810 RID: 63504 RVA: 0x00417910 File Offset: 0x00415B10
		public GuildCreateReqNetTask(string guildName, string hiringDeclaration, string announcement, bool autoJoin, int joinLevel) : base(10f, null, true)
		{
			this.m_guildName = guildName;
			this.m_hiringDeclaration = hiringDeclaration;
			this.m_announcement = announcement;
			this.m_autoJoin = autoJoin;
			this.m_joinLevel = joinLevel;
		}

		// Token: 0x0600F811 RID: 63505 RVA: 0x00417944 File Offset: 0x00415B44
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildCreateAck += this.OnMsgAck;
		}

		// Token: 0x0600F812 RID: 63506 RVA: 0x0041797C File Offset: 0x00415B7C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildCreateAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F813 RID: 63507 RVA: 0x004179B8 File Offset: 0x00415BB8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildCreateReq(this.m_guildName, this.m_hiringDeclaration, this.m_announcement, this.m_autoJoin, this.m_joinLevel);
		}

		// Token: 0x0600F814 RID: 63508 RVA: 0x00417A00 File Offset: 0x00415C00
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009225 RID: 37413
		private string m_guildName;

		// Token: 0x04009226 RID: 37414
		private string m_hiringDeclaration;

		// Token: 0x04009227 RID: 37415
		private string m_announcement;

		// Token: 0x04009228 RID: 37416
		private bool m_autoJoin;

		// Token: 0x04009229 RID: 37417
		private int m_joinLevel;
	}
}
