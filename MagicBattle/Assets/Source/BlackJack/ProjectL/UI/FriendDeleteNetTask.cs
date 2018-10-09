using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C9C RID: 3228
	[CustomLuaClass]
	public class FriendDeleteNetTask : UINetTask
	{
		// Token: 0x0600E8C8 RID: 59592 RVA: 0x003E5214 File Offset: 0x003E3414
		public FriendDeleteNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600E8C9 RID: 59593 RVA: 0x003E522C File Offset: 0x003E342C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendDeleteAck += this.OnFriendDeleteAck;
		}

		// Token: 0x0600E8CA RID: 59594 RVA: 0x003E5264 File Offset: 0x003E3464
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendDeleteAck -= this.OnFriendDeleteAck;
			}
		}

		// Token: 0x0600E8CB RID: 59595 RVA: 0x003E52A0 File Offset: 0x003E34A0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFriendDeleteReq(this.m_userID);
		}

		// Token: 0x0600E8CC RID: 59596 RVA: 0x003E52D0 File Offset: 0x003E34D0
		protected void OnFriendDeleteAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BDE RID: 35806
		private string m_userID;
	}
}
