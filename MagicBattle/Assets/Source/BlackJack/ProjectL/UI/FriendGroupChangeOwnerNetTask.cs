using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA1 RID: 3233
	[CustomLuaClass]
	public class FriendGroupChangeOwnerNetTask : UINetTask
	{
		// Token: 0x0600E8E1 RID: 59617 RVA: 0x003E5614 File Offset: 0x003E3814
		public FriendGroupChangeOwnerNetTask(string chatGroupID, string userID) : base(10f, null, true)
		{
			this.m_chatGroupID = chatGroupID;
			this.m_userID = userID;
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x003E5634 File Offset: 0x003E3834
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatGroupChangeOwnerAck += this.OnFriendGroupChangeOwnerAck;
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x003E566C File Offset: 0x003E386C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatGroupChangeOwnerAck -= this.OnFriendGroupChangeOwnerAck;
			}
		}

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x003E56A8 File Offset: 0x003E38A8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendChangeOwnerReq(this.m_chatGroupID, this.m_userID);
		}

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x003E56E0 File Offset: 0x003E38E0
		protected void OnFriendGroupChangeOwnerAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BE3 RID: 35811
		private string m_chatGroupID;

		// Token: 0x04008BE4 RID: 35812
		private string m_userID;
	}
}
