using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B86 RID: 2950
	[CustomLuaClass]
	public class ClimbTowerLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x0600C934 RID: 51508 RVA: 0x00379EAC File Offset: 0x003780AC
		public ClimbTowerLevelBattleFinishedNetTask(int floorId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_floorId = floorId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x00379ECC File Offset: 0x003780CC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnClimbTowerLevelBattleFinishedAck += this.OnClimbTowerLevelBattleFinishedAck;
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x00379F04 File Offset: 0x00378104
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnClimbTowerLevelBattleFinishedAck -= this.OnClimbTowerLevelBattleFinishedAck;
			}
		}

		// Token: 0x0600C937 RID: 51511 RVA: 0x00379F40 File Offset: 0x00378140
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendClimbTowerLevelBattleFinishedReq(this.m_floorId, this.m_battleReport);
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x00379F78 File Offset: 0x00378178
		protected void OnClimbTowerLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170027F7 RID: 10231
		// (get) Token: 0x0600C93A RID: 51514 RVA: 0x00379FA4 File Offset: 0x003781A4
		// (set) Token: 0x0600C939 RID: 51513 RVA: 0x00379F98 File Offset: 0x00378198
		public bool IsWin { get; private set; }

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x0600C93C RID: 51516 RVA: 0x00379FB8 File Offset: 0x003781B8
		// (set) Token: 0x0600C93B RID: 51515 RVA: 0x00379FAC File Offset: 0x003781AC
		public BattleReward Reward { get; private set; }

		// Token: 0x04007EE7 RID: 32487
		private int m_floorId;

		// Token: 0x04007EE8 RID: 32488
		private ProBattleReport m_battleReport;
	}
}
