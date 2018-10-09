using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D25 RID: 3365
	[CustomLuaClass]
	public class GuildJoinAdminConfirmReqNetTask : UINetTask
	{
		// Token: 0x0600F81A RID: 63514 RVA: 0x00417B08 File Offset: 0x00415D08
		public GuildJoinAdminConfirmReqNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600F81B RID: 63515 RVA: 0x00417B20 File Offset: 0x00415D20
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildJoinAdminConfirmAck += this.OnMsgAck;
		}

		// Token: 0x0600F81C RID: 63516 RVA: 0x00417B58 File Offset: 0x00415D58
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildJoinAdminConfirmAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F81D RID: 63517 RVA: 0x00417B94 File Offset: 0x00415D94
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GuildJoinAdminConfirmReq(this.m_userID);
		}

		// Token: 0x0600F81E RID: 63518 RVA: 0x00417BC4 File Offset: 0x00415DC4
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400922B RID: 37419
		private string m_userID;
	}
}
