using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B1D RID: 2845
	[CustomLuaClass]
	public class LikeNetTask : UINetTask
	{
		// Token: 0x0600BFE8 RID: 49128 RVA: 0x00357BF0 File Offset: 0x00355DF0
		public LikeNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x00357C08 File Offset: 0x00355E08
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnLikeAck += this.OnLikeAck;
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x00357C40 File Offset: 0x00355E40
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnLikeAck -= this.OnLikeAck;
			}
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x00357C7C File Offset: 0x00355E7C
		protected void OnLikeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x00357C8C File Offset: 0x00355E8C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLikesSendReq(this.m_userID);
		}

		// Token: 0x04007A86 RID: 31366
		private string m_userID;
	}
}
