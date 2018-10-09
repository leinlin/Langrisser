using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B84 RID: 2948
	[CustomLuaClass]
	public class ClimbTowerGetNetTask : UINetTask
	{
		// Token: 0x0600C92A RID: 51498 RVA: 0x00379D20 File Offset: 0x00377F20
		public ClimbTowerGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600C92B RID: 51499 RVA: 0x00379D30 File Offset: 0x00377F30
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnClimbTowerGetAck += this.OnClimbTowerGetAck;
		}

		// Token: 0x0600C92C RID: 51500 RVA: 0x00379D68 File Offset: 0x00377F68
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnClimbTowerGetAck -= this.OnClimbTowerGetAck;
			}
		}

		// Token: 0x0600C92D RID: 51501 RVA: 0x00379DA4 File Offset: 0x00377FA4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendClimbTowerGetReq();
		}

		// Token: 0x0600C92E RID: 51502 RVA: 0x00379DD0 File Offset: 0x00377FD0
		protected void OnClimbTowerGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
