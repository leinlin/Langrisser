using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B85 RID: 2949
	[CustomLuaClass]
	public class ClimbTowerLevelAttackNetTask : UINetTask
	{
		// Token: 0x0600C92F RID: 51503 RVA: 0x00379DE0 File Offset: 0x00377FE0
		public ClimbTowerLevelAttackNetTask(int floorId) : base(10f, null, true)
		{
			this.m_floorId = floorId;
		}

		// Token: 0x0600C930 RID: 51504 RVA: 0x00379DF8 File Offset: 0x00377FF8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnClimbTowerLevelAttackAck += this.OnClimbTowerLevelAttackAck;
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x00379E30 File Offset: 0x00378030
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnClimbTowerLevelAttackAck -= this.OnClimbTowerLevelAttackAck;
			}
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x00379E6C File Offset: 0x0037806C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendClimbTowerLevelAttackReq(this.m_floorId);
		}

		// Token: 0x0600C933 RID: 51507 RVA: 0x00379E9C File Offset: 0x0037809C
		protected void OnClimbTowerLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04007EE4 RID: 32484
		private int m_floorId;
	}
}
