using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA6 RID: 3238
	[CustomLuaClass]
	public class FriendInviteToGroupGetNetTask : UINetTask
	{
		// Token: 0x0600E902 RID: 59650 RVA: 0x003E5AA8 File Offset: 0x003E3CA8
		public FriendInviteToGroupGetNetTask(string chatGroupID, List<string> userIDList) : base(10f, null, true)
		{
			this.m_chatGroupID = chatGroupID;
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E903 RID: 59651 RVA: 0x003E5ACC File Offset: 0x003E3CCC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnInviteToChatGroupAck += this.OnInviteToChatGroupAck;
		}

		// Token: 0x0600E904 RID: 59652 RVA: 0x003E5B04 File Offset: 0x003E3D04
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnInviteToChatGroupAck -= this.OnInviteToChatGroupAck;
			}
		}

		// Token: 0x0600E905 RID: 59653 RVA: 0x003E5B40 File Offset: 0x003E3D40
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendInviteToChatGroupReq(this.m_chatGroupID, this.m_userIDList);
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x003E5B78 File Offset: 0x003E3D78
		protected void OnInviteToChatGroupAck(int result, ProChatGroupInfo chatGroupInfo, ProChatUserInfo userInfo)
		{
			base.Result = result;
			this.ChatGroupInfo = chatGroupInfo;
			this.FailedUser = userInfo;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600E908 RID: 59656 RVA: 0x003E5BA4 File Offset: 0x003E3DA4
		// (set) Token: 0x0600E907 RID: 59655 RVA: 0x003E5B98 File Offset: 0x003E3D98
		public ProChatGroupInfo ChatGroupInfo { get; private set; }

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600E90A RID: 59658 RVA: 0x003E5BB8 File Offset: 0x003E3DB8
		// (set) Token: 0x0600E909 RID: 59657 RVA: 0x003E5BAC File Offset: 0x003E3DAC
		public ProChatUserInfo FailedUser { get; private set; }

		// Token: 0x04008BF0 RID: 35824
		private List<string> m_userIDList;

		// Token: 0x04008BF1 RID: 35825
		private string m_chatGroupID;
	}
}
