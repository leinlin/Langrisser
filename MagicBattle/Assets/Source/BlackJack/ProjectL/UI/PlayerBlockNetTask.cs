using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C9D RID: 3229
	[CustomLuaClass]
	public class PlayerBlockNetTask : UINetTask
	{
		// Token: 0x0600E8CD RID: 59597 RVA: 0x003E52E0 File Offset: 0x003E34E0
		public PlayerBlockNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600E8CE RID: 59598 RVA: 0x003E52F8 File Offset: 0x003E34F8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnPlayerBlockAck += this.OnPlayerBlockAck;
		}

		// Token: 0x0600E8CF RID: 59599 RVA: 0x003E5330 File Offset: 0x003E3530
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPlayerBlockAck -= this.OnPlayerBlockAck;
			}
		}

		// Token: 0x0600E8D0 RID: 59600 RVA: 0x003E536C File Offset: 0x003E356C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendPlayerBlockReq(this.m_userID);
		}

		// Token: 0x0600E8D1 RID: 59601 RVA: 0x003E539C File Offset: 0x003E359C
		protected void OnPlayerBlockAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BDF RID: 35807
		private string m_userID;
	}
}
