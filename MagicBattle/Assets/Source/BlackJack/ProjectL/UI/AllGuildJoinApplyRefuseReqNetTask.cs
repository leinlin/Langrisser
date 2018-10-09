using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D3B RID: 3387
	[CustomLuaClass]
	public class AllGuildJoinApplyRefuseReqNetTask : UINetTask
	{
		// Token: 0x0600F89A RID: 63642 RVA: 0x00418D50 File Offset: 0x00416F50
		public AllGuildJoinApplyRefuseReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F89B RID: 63643 RVA: 0x00418D60 File Offset: 0x00416F60
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnAllGuildJoinApplyRefuseAck += this.OnMsgAck;
		}

		// Token: 0x0600F89C RID: 63644 RVA: 0x00418D98 File Offset: 0x00416F98
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnAllGuildJoinApplyRefuseAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F89D RID: 63645 RVA: 0x00418DD4 File Offset: 0x00416FD4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendAllGuildJoinApplyRefuseReq();
		}

		// Token: 0x0600F89E RID: 63646 RVA: 0x00418E00 File Offset: 0x00417000
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
