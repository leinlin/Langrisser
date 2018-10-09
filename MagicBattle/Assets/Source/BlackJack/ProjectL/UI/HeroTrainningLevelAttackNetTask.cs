using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E24 RID: 3620
	[CustomLuaClass]
	public class HeroTrainningLevelAttackNetTask : UINetTask
	{
		// Token: 0x06011790 RID: 71568 RVA: 0x004863B8 File Offset: 0x004845B8
		public HeroTrainningLevelAttackNetTask(int levelId) : base(10f, null, true)
		{
			this.m_levelId = levelId;
		}

		// Token: 0x06011791 RID: 71569 RVA: 0x004863D0 File Offset: 0x004845D0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroTrainningLevelAttackAck += this.OnHeroTrainningLevelAttackAck;
		}

		// Token: 0x06011792 RID: 71570 RVA: 0x00486408 File Offset: 0x00484608
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroTrainningLevelAttackAck -= this.OnHeroTrainningLevelAttackAck;
			}
		}

		// Token: 0x06011793 RID: 71571 RVA: 0x00486444 File Offset: 0x00484644
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroTrainningLevelAttackReq(this.m_levelId);
		}

		// Token: 0x06011794 RID: 71572 RVA: 0x00486474 File Offset: 0x00484674
		protected void OnHeroTrainningLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009F8D RID: 40845
		private int m_levelId;
	}
}
