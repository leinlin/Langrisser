using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C9A RID: 3226
	[CustomLuaClass]
	public class FriendInviteAcceptNetTask : UINetTask
	{
		// Token: 0x0600E8BC RID: 59580 RVA: 0x003E5058 File Offset: 0x003E3258
		public FriendInviteAcceptNetTask(List<string> userIDList) : base(10f, null, true)
		{
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E8BD RID: 59581 RVA: 0x003E5074 File Offset: 0x003E3274
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendInviteAcceptAck += this.OnFriendInviteAcceptAck;
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x003E50AC File Offset: 0x003E32AC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendInviteAcceptAck -= this.OnFriendInviteAcceptAck;
			}
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x003E50E8 File Offset: 0x003E32E8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFriendAcceptReq(this.m_userIDList);
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x003E5118 File Offset: 0x003E3318
		protected void OnFriendInviteAcceptAck(int result, UserSummary failedUser)
		{
			base.Result = result;
			this.FailedUser = failedUser;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600E8C2 RID: 59586 RVA: 0x003E513C File Offset: 0x003E333C
		// (set) Token: 0x0600E8C1 RID: 59585 RVA: 0x003E5130 File Offset: 0x003E3330
		public UserSummary FailedUser { get; private set; }

		// Token: 0x04008BDC RID: 35804
		private List<string> m_userIDList;
	}
}
