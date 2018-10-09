using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C9F RID: 3231
	[CustomLuaClass]
	public class FriendFindNetTask : UINetTask
	{
		// Token: 0x0600E8D7 RID: 59607 RVA: 0x003E5478 File Offset: 0x003E3678
		public FriendFindNetTask(int bornChannelID, string partialName) : base(10f, null, true)
		{
			this.m_bornChannelID = bornChannelID;
			this.m_partialName = partialName;
		}

		// Token: 0x0600E8D8 RID: 59608 RVA: 0x003E5498 File Offset: 0x003E3698
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendFindAck += this.OnFriendFindAck;
		}

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x003E54D0 File Offset: 0x003E36D0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendFindAck -= this.OnFriendFindAck;
			}
		}

		// Token: 0x0600E8DA RID: 59610 RVA: 0x003E550C File Offset: 0x003E370C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendPlayerFindReq(this.m_bornChannelID, this.m_partialName);
		}

		// Token: 0x0600E8DB RID: 59611 RVA: 0x003E5544 File Offset: 0x003E3744
		protected void OnFriendFindAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BE1 RID: 35809
		private int m_bornChannelID;

		// Token: 0x04008BE2 RID: 35810
		private string m_partialName;
	}
}
