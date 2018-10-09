using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA4 RID: 3236
	[CustomLuaClass]
	public class FriendGroupMemberGetNetTask : UINetTask
	{
		// Token: 0x0600E8F4 RID: 59636 RVA: 0x003E58E4 File Offset: 0x003E3AE4
		public FriendGroupMemberGetNetTask(string chatGroupID) : base(10f, null, true)
		{
			this.m_chatGroupID = chatGroupID;
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x003E58FC File Offset: 0x003E3AFC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetChatGroupMemberAck += this.OnGetFriendGroupMemberAck;
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x003E5934 File Offset: 0x003E3B34
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGetChatGroupMemberAck -= this.OnGetFriendGroupMemberAck;
			}
		}

		// Token: 0x0600E8F7 RID: 59639 RVA: 0x003E5970 File Offset: 0x003E3B70
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetChatGroupMemberReq(this.m_chatGroupID);
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x003E59A0 File Offset: 0x003E3BA0
		protected void OnGetFriendGroupMemberAck(int result, ProChatGroupInfo chatGroupInfo)
		{
			base.Result = result;
			this.ChatGroupInfo = chatGroupInfo;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600E8FA RID: 59642 RVA: 0x003E59C4 File Offset: 0x003E3BC4
		// (set) Token: 0x0600E8F9 RID: 59641 RVA: 0x003E59B8 File Offset: 0x003E3BB8
		public ProChatGroupInfo ChatGroupInfo { get; private set; }

		// Token: 0x04008BEC RID: 35820
		private string m_chatGroupID;
	}
}
