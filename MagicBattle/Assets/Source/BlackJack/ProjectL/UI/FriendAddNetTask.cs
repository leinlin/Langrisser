using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C99 RID: 3225
	[CustomLuaClass]
	public class FriendAddNetTask : UINetTask
	{
		// Token: 0x0600E8B4 RID: 59572 RVA: 0x003E4F64 File Offset: 0x003E3164
		public FriendAddNetTask(List<string> userIDList) : base(10f, null, true)
		{
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x003E4F80 File Offset: 0x003E3180
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendInviteAck += this.OnFriendAddAck;
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x003E4FB8 File Offset: 0x003E31B8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendInviteAck -= this.OnFriendAddAck;
			}
		}

		// Token: 0x0600E8B7 RID: 59575 RVA: 0x003E4FF4 File Offset: 0x003E31F4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFriendInivteReq(this.m_userIDList);
		}

		// Token: 0x0600E8B8 RID: 59576 RVA: 0x003E5024 File Offset: 0x003E3224
		protected void OnFriendAddAck(int result, UserSummary failedUser)
		{
			base.Result = result;
			this.FailedUser = failedUser;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600E8BA RID: 59578 RVA: 0x003E5048 File Offset: 0x003E3248
		// (set) Token: 0x0600E8B9 RID: 59577 RVA: 0x003E503C File Offset: 0x003E323C
		public UserSummary FailedUser { get; private set; }

		// Token: 0x0600E8BB RID: 59579 RVA: 0x003E5050 File Offset: 0x003E3250
		public List<string> GetUserIdLIst()
		{
			return this.m_userIDList;
		}

		// Token: 0x04008BDA RID: 35802
		private List<string> m_userIDList;
	}
}
