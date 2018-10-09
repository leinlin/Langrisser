using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C9B RID: 3227
	[CustomLuaClass]
	public class FriendInviteDeclineNetTask : UINetTask
	{
		// Token: 0x0600E8C3 RID: 59587 RVA: 0x003E5144 File Offset: 0x003E3344
		public FriendInviteDeclineNetTask(List<string> userIDList) : base(10f, null, true)
		{
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E8C4 RID: 59588 RVA: 0x003E5160 File Offset: 0x003E3360
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendInviteDeclineAck += this.OnFriendInviteDeclineAck;
		}

		// Token: 0x0600E8C5 RID: 59589 RVA: 0x003E5198 File Offset: 0x003E3398
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendInviteDeclineAck -= this.OnFriendInviteDeclineAck;
			}
		}

		// Token: 0x0600E8C6 RID: 59590 RVA: 0x003E51D4 File Offset: 0x003E33D4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFriendDeclineReq(this.m_userIDList);
		}

		// Token: 0x0600E8C7 RID: 59591 RVA: 0x003E5204 File Offset: 0x003E3404
		protected void OnFriendInviteDeclineAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BDD RID: 35805
		private List<string> m_userIDList;
	}
}
