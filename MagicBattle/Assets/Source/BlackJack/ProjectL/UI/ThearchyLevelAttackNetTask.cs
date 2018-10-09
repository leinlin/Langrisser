using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FC0 RID: 4032
	[CustomLuaClass]
	public class ThearchyLevelAttackNetTask : UINetTask
	{
		// Token: 0x06014226 RID: 82470 RVA: 0x00520C58 File Offset: 0x0051EE58
		public ThearchyLevelAttackNetTask(int levelId) : base(10f, null, true)
		{
			this.m_levelId = levelId;
		}

		// Token: 0x06014227 RID: 82471 RVA: 0x00520C70 File Offset: 0x0051EE70
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnThearchyTrialLevelAttackAck += this.OnThearchyLevelAttackAck;
		}

		// Token: 0x06014228 RID: 82472 RVA: 0x00520CA8 File Offset: 0x0051EEA8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnThearchyTrialLevelAttackAck -= this.OnThearchyLevelAttackAck;
			}
		}

		// Token: 0x06014229 RID: 82473 RVA: 0x00520CE4 File Offset: 0x0051EEE4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendThearchyTrialLevelAttackReq(this.m_levelId);
		}

		// Token: 0x0601422A RID: 82474 RVA: 0x00520D14 File Offset: 0x0051EF14
		protected void OnThearchyLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400B1FF RID: 45567
		private int m_levelId;
	}
}
