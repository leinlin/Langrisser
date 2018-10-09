using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D2F RID: 3375
	[CustomLuaClass]
	public class AllGuildJoinInvitationRefuseReqNetTask : UINetTask
	{
		// Token: 0x0600F850 RID: 63568 RVA: 0x00418318 File Offset: 0x00416518
		public AllGuildJoinInvitationRefuseReqNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F851 RID: 63569 RVA: 0x00418328 File Offset: 0x00416528
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnAllGuildJoinInvitationRefuseAck += this.OnMsgAck;
		}

		// Token: 0x0600F852 RID: 63570 RVA: 0x00418360 File Offset: 0x00416560
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnAllGuildJoinInvitationRefuseAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F853 RID: 63571 RVA: 0x0041839C File Offset: 0x0041659C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendAllGuildJoinInvitationRefuseReq();
		}

		// Token: 0x0600F854 RID: 63572 RVA: 0x004183C8 File Offset: 0x004165C8
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
