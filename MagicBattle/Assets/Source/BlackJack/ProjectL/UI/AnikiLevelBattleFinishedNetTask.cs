using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009C9 RID: 2505
	[CustomLuaClass]
	public class AnikiLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x060091E3 RID: 37347 RVA: 0x002A3538 File Offset: 0x002A1738
		public AnikiLevelBattleFinishedNetTask(int levelId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_levelId = levelId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x002A3558 File Offset: 0x002A1758
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnAnikiGymLevelBattleFinishedAck += this.OnAnikiLevelBattleFinishedAck;
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x002A3590 File Offset: 0x002A1790
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnAnikiGymLevelBattleFinishedAck -= this.OnAnikiLevelBattleFinishedAck;
			}
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x002A35CC File Offset: 0x002A17CC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendAnikiGymLevelBattleFinishedReq(this.m_levelId, this.m_battleReport);
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x002A3604 File Offset: 0x002A1804
		protected void OnAnikiLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x002A3630 File Offset: 0x002A1830
		// (set) Token: 0x060091E8 RID: 37352 RVA: 0x002A3624 File Offset: 0x002A1824
		public bool IsWin { get; private set; }

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060091EB RID: 37355 RVA: 0x002A3644 File Offset: 0x002A1844
		// (set) Token: 0x060091EA RID: 37354 RVA: 0x002A3638 File Offset: 0x002A1838
		public BattleReward Reward { get; private set; }

		// Token: 0x04006617 RID: 26135
		private int m_levelId;

		// Token: 0x04006618 RID: 26136
		private ProBattleReport m_battleReport;
	}
}
