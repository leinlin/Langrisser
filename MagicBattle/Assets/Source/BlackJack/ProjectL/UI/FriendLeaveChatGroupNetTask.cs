using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA7 RID: 3239
	[CustomLuaClass]
	public class FriendLeaveChatGroupNetTask : UINetTask
	{
		// Token: 0x0600E90B RID: 59659 RVA: 0x003E5BC0 File Offset: 0x003E3DC0
		public FriendLeaveChatGroupNetTask(string chatGroupID) : base(10f, null, true)
		{
			this.m_chatGroupID = chatGroupID;
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x003E5BD8 File Offset: 0x003E3DD8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnLeaveChatGroupAck += this.OnLeaveChatGroupAck;
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x003E5C10 File Offset: 0x003E3E10
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnLeaveChatGroupAck -= this.OnLeaveChatGroupAck;
			}
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x003E5C4C File Offset: 0x003E3E4C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLeaveChatGroupReq(this.m_chatGroupID);
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x003E5C7C File Offset: 0x003E3E7C
		protected void OnLeaveChatGroupAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BF2 RID: 35826
		private string m_chatGroupID;
	}
}
