using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C89 RID: 3209
	[CustomLuaClass]
	public class HeroFetterLevelUpNetTask : UINetTask
	{
		// Token: 0x0600E71D RID: 59165 RVA: 0x003DEF68 File Offset: 0x003DD168
		public HeroFetterLevelUpNetTask(int heroId, int fetterId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_fetterId = fetterId;
		}

		// Token: 0x0600E71E RID: 59166 RVA: 0x003DEF88 File Offset: 0x003DD188
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroFetterLevelUpAck += this.OnHeroFetterLevelUp;
		}

		// Token: 0x0600E71F RID: 59167 RVA: 0x003DEFC0 File Offset: 0x003DD1C0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroFetterLevelUpAck -= this.OnHeroFetterLevelUp;
			}
		}

		// Token: 0x0600E720 RID: 59168 RVA: 0x003DEFFC File Offset: 0x003DD1FC
		protected void OnHeroFetterLevelUp(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600E721 RID: 59169 RVA: 0x003DF00C File Offset: 0x003DD20C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroFetterLevelUp(this.m_heroId, this.m_fetterId);
		}

		// Token: 0x04008B36 RID: 35638
		private int m_heroId;

		// Token: 0x04008B37 RID: 35639
		private int m_fetterId;
	}
}
