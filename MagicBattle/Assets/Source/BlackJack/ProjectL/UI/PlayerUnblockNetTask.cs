using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C9E RID: 3230
	[CustomLuaClass]
	public class PlayerUnblockNetTask : UINetTask
	{
		// Token: 0x0600E8D2 RID: 59602 RVA: 0x003E53AC File Offset: 0x003E35AC
		public PlayerUnblockNetTask(string userID) : base(10f, null, true)
		{
			this.m_userID = userID;
		}

		// Token: 0x0600E8D3 RID: 59603 RVA: 0x003E53C4 File Offset: 0x003E35C4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnPlayerUnblockAck += this.OnPlayerUnblockAck;
		}

		// Token: 0x0600E8D4 RID: 59604 RVA: 0x003E53FC File Offset: 0x003E35FC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPlayerUnblockAck -= this.OnPlayerUnblockAck;
			}
		}

		// Token: 0x0600E8D5 RID: 59605 RVA: 0x003E5438 File Offset: 0x003E3638
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendPlayerUnblockReq(this.m_userID);
		}

		// Token: 0x0600E8D6 RID: 59606 RVA: 0x003E5468 File Offset: 0x003E3668
		protected void OnPlayerUnblockAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BE0 RID: 35808
		private string m_userID;
	}
}
