using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CAA RID: 3242
	[CustomLuaClass]
	public class FriendShipPointsClaimNetTask : UINetTask
	{
		// Token: 0x0600E91A RID: 59674 RVA: 0x003E5E38 File Offset: 0x003E4038
		public FriendShipPointsClaimNetTask(List<string> userIDList) : base(10f, null, true)
		{
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E91B RID: 59675 RVA: 0x003E5E54 File Offset: 0x003E4054
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendshipPointsClaimAck += this.OnFriendshipPointsClaimAck;
		}

		// Token: 0x0600E91C RID: 59676 RVA: 0x003E5E8C File Offset: 0x003E408C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendshipPointsClaimAck -= this.OnFriendshipPointsClaimAck;
			}
		}

		// Token: 0x0600E91D RID: 59677 RVA: 0x003E5EC8 File Offset: 0x003E40C8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFriendshipPointsClaimReq(this.m_userIDList);
		}

		// Token: 0x0600E91E RID: 59678 RVA: 0x003E5EF8 File Offset: 0x003E40F8
		protected void OnFriendshipPointsClaimAck(int result, int getFriendshipPointPlayerCount)
		{
			base.Result = result;
			this.GetFriendshipPointPlayerCount = getFriendshipPointPlayerCount;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600E920 RID: 59680 RVA: 0x003E5F1C File Offset: 0x003E411C
		// (set) Token: 0x0600E91F RID: 59679 RVA: 0x003E5F10 File Offset: 0x003E4110
		public int GetFriendshipPointPlayerCount { get; private set; }

		// Token: 0x04008BF7 RID: 35831
		private List<string> m_userIDList;
	}
}
