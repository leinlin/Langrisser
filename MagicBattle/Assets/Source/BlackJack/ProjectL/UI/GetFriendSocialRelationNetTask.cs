using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C98 RID: 3224
	[CustomLuaClass]
	public class GetFriendSocialRelationNetTask : UINetTask
	{
		// Token: 0x0600E8AF RID: 59567 RVA: 0x003E4E98 File Offset: 0x003E3098
		public GetFriendSocialRelationNetTask(FriendSocialRelationFlag friendSocialRelationFlag = FriendSocialRelationFlag.All) : base(10f, null, true)
		{
			this.m_friendSocialRelationFlag = friendSocialRelationFlag;
		}

		// Token: 0x0600E8B0 RID: 59568 RVA: 0x003E4EB0 File Offset: 0x003E30B0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendGetSocialRelationAck += this.OnFriendGetSocialRelationAck;
		}

		// Token: 0x0600E8B1 RID: 59569 RVA: 0x003E4EE8 File Offset: 0x003E30E8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendGetSocialRelationAck -= this.OnFriendGetSocialRelationAck;
			}
		}

		// Token: 0x0600E8B2 RID: 59570 RVA: 0x003E4F24 File Offset: 0x003E3124
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetSocialRelationReq(this.m_friendSocialRelationFlag);
		}

		// Token: 0x0600E8B3 RID: 59571 RVA: 0x003E4F54 File Offset: 0x003E3154
		protected void OnFriendGetSocialRelationAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BD8 RID: 35800
		private FriendSocialRelationFlag m_friendSocialRelationFlag;
	}
}
