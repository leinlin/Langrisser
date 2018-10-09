using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D37 RID: 3383
	[CustomLuaClass]
	public class GuildVicePresidentAppointReqNetTask : UINetTask
	{
		// Token: 0x0600F886 RID: 63622 RVA: 0x00418A10 File Offset: 0x00416C10
		public GuildVicePresidentAppointReqNetTask(string userId, bool appoint) : base(10f, null, true)
		{
			this.m_userId = userId;
			this.m_appoint = appoint;
		}

		// Token: 0x0600F887 RID: 63623 RVA: 0x00418A30 File Offset: 0x00416C30
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildVicePresidentAppointAck += this.OnMsgAck;
		}

		// Token: 0x0600F888 RID: 63624 RVA: 0x00418A68 File Offset: 0x00416C68
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildVicePresidentAppointAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F889 RID: 63625 RVA: 0x00418AA4 File Offset: 0x00416CA4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildVicePresidentAppointReq(this.m_userId, this.m_appoint);
		}

		// Token: 0x0600F88A RID: 63626 RVA: 0x00418ADC File Offset: 0x00416CDC
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400923F RID: 37439
		private string m_userId;

		// Token: 0x04009240 RID: 37440
		private bool m_appoint;
	}
}
