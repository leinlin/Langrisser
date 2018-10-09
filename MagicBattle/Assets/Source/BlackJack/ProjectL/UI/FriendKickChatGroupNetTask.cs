using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA8 RID: 3240
	[CustomLuaClass]
	public class FriendKickChatGroupNetTask : UINetTask
	{
		// Token: 0x0600E910 RID: 59664 RVA: 0x003E5C8C File Offset: 0x003E3E8C
		public FriendKickChatGroupNetTask(string chatGroupID, string userID) : base(10f, null, true)
		{
			this.m_chatGroupID = chatGroupID;
			this.m_userID = userID;
		}

		// Token: 0x0600E911 RID: 59665 RVA: 0x003E5CAC File Offset: 0x003E3EAC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnKickUserFromGroupAck += this.OnKickUserFromGroupAck;
		}

		// Token: 0x0600E912 RID: 59666 RVA: 0x003E5CE4 File Offset: 0x003E3EE4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnKickUserFromGroupAck -= this.OnKickUserFromGroupAck;
			}
		}

		// Token: 0x0600E913 RID: 59667 RVA: 0x003E5D20 File Offset: 0x003E3F20
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendKickUserReq(this.m_chatGroupID, this.m_userID);
		}

		// Token: 0x0600E914 RID: 59668 RVA: 0x003E5D58 File Offset: 0x003E3F58
		protected void OnKickUserFromGroupAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BF3 RID: 35827
		private string m_chatGroupID;

		// Token: 0x04008BF4 RID: 35828
		private string m_userID;
	}
}
