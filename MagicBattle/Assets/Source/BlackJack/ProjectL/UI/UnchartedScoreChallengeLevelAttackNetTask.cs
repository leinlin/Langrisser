using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FEE RID: 4078
	[CustomLuaClass]
	public class UnchartedScoreChallengeLevelAttackNetTask : UINetTask
	{
		// Token: 0x06014799 RID: 83865 RVA: 0x0053313C File Offset: 0x0053133C
		public UnchartedScoreChallengeLevelAttackNetTask(int unchartedScoreId, int levelId) : base(10f, null, true)
		{
			this.m_unchartedScoreId = unchartedScoreId;
			this.m_levelId = levelId;
		}

		// Token: 0x0601479A RID: 83866 RVA: 0x0053315C File Offset: 0x0053135C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnUnchartedScoreChallengeLevelAttackAck += this.OnUnchartedScoreChallengeLevelAttackAck;
		}

		// Token: 0x0601479B RID: 83867 RVA: 0x00533194 File Offset: 0x00531394
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnUnchartedScoreChallengeLevelAttackAck -= this.OnUnchartedScoreChallengeLevelAttackAck;
			}
		}

		// Token: 0x0601479C RID: 83868 RVA: 0x005331D0 File Offset: 0x005313D0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendUnchartedScoreChallengeLevelAttackReq(this.m_unchartedScoreId, this.m_levelId);
		}

		// Token: 0x0601479D RID: 83869 RVA: 0x00533208 File Offset: 0x00531408
		protected void OnUnchartedScoreChallengeLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400B431 RID: 46129
		private int m_unchartedScoreId;

		// Token: 0x0400B432 RID: 46130
		private int m_levelId;
	}
}
