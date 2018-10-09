using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D38 RID: 3384
	[CustomLuaClass]
	public class GuildKickOutReqNetTask : UINetTask
	{
		// Token: 0x0600F88B RID: 63627 RVA: 0x00418AEC File Offset: 0x00416CEC
		public GuildKickOutReqNetTask(string userId) : base(10f, null, true)
		{
			this.m_userId = userId;
		}

		// Token: 0x0600F88C RID: 63628 RVA: 0x00418B04 File Offset: 0x00416D04
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildKickOutAck += this.OnMsgAck;
		}

		// Token: 0x0600F88D RID: 63629 RVA: 0x00418B3C File Offset: 0x00416D3C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildKickOutAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F88E RID: 63630 RVA: 0x00418B78 File Offset: 0x00416D78
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildKickOutReq(this.m_userId);
		}

		// Token: 0x0600F88F RID: 63631 RVA: 0x00418BA8 File Offset: 0x00416DA8
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009241 RID: 37441
		private string m_userId;
	}
}
