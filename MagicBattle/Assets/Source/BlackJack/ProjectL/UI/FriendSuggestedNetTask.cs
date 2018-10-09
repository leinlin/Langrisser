using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA0 RID: 3232
	[CustomLuaClass]
	public class FriendSuggestedNetTask : UINetTask
	{
		// Token: 0x0600E8DC RID: 59612 RVA: 0x003E5554 File Offset: 0x003E3754
		public FriendSuggestedNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x003E5564 File Offset: 0x003E3764
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendSuggestedAck += this.OnFriendSuggestedAck;
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x003E559C File Offset: 0x003E379C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendSuggestedAck -= this.OnFriendSuggestedAck;
			}
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x003E55D8 File Offset: 0x003E37D8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendSuggestedUserReq();
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x003E5604 File Offset: 0x003E3804
		protected void OnFriendSuggestedAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
