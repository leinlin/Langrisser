using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DE5 RID: 3557
	[CustomLuaClass]
	public class HeroStarLevelUpNetTask : UINetTask
	{
		// Token: 0x060110FB RID: 69883 RVA: 0x0046C2B0 File Offset: 0x0046A4B0
		public HeroStarLevelUpNetTask(int id) : base(10f, null, true)
		{
			this.m_heroId = id;
		}

		// Token: 0x060110FC RID: 69884 RVA: 0x0046C2C8 File Offset: 0x0046A4C8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroStarLevelUpAck += this.OnHeroStarLevelUpAck;
		}

		// Token: 0x060110FD RID: 69885 RVA: 0x0046C300 File Offset: 0x0046A500
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroStarLevelUpAck -= this.OnHeroStarLevelUpAck;
			}
		}

		// Token: 0x060110FE RID: 69886 RVA: 0x0046C33C File Offset: 0x0046A53C
		protected void OnHeroStarLevelUpAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x060110FF RID: 69887 RVA: 0x0046C34C File Offset: 0x0046A54C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroStarLevelUpReq(this.m_heroId);
		}

		// Token: 0x04009CF1 RID: 40177
		private int m_heroId;
	}
}
