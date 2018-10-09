using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FF0 RID: 4080
	[CustomLuaClass]
	public class UnchartedScoreScoreLevelAttackNetTask : UINetTask
	{
		// Token: 0x060147A7 RID: 83879 RVA: 0x00533334 File Offset: 0x00531534
		public UnchartedScoreScoreLevelAttackNetTask(int unchartedScoreId, int levelId) : base(10f, null, true)
		{
			this.m_unchartedScoreId = unchartedScoreId;
			this.m_levelId = levelId;
		}

		// Token: 0x060147A8 RID: 83880 RVA: 0x00533354 File Offset: 0x00531554
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnUnchartedScoreScoreLevelAttackAck += this.OnUnchartedScoreScoreLevelAttackAck;
		}

		// Token: 0x060147A9 RID: 83881 RVA: 0x0053338C File Offset: 0x0053158C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnUnchartedScoreScoreLevelAttackAck -= this.OnUnchartedScoreScoreLevelAttackAck;
			}
		}

		// Token: 0x060147AA RID: 83882 RVA: 0x005333C8 File Offset: 0x005315C8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendUnchartedScoreScoreLevelAttackReq(this.m_unchartedScoreId, this.m_levelId);
		}

		// Token: 0x060147AB RID: 83883 RVA: 0x00533400 File Offset: 0x00531600
		protected void OnUnchartedScoreScoreLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400B438 RID: 46136
		private int m_unchartedScoreId;

		// Token: 0x0400B439 RID: 46137
		private int m_levelId;
	}
}
