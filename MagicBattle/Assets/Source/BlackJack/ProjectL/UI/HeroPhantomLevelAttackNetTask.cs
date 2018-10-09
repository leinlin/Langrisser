using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E1C RID: 3612
	[CustomLuaClass]
	public class HeroPhantomLevelAttackNetTask : UINetTask
	{
		// Token: 0x06011662 RID: 71266 RVA: 0x00482998 File Offset: 0x00480B98
		public HeroPhantomLevelAttackNetTask(int levelID) : base(10f, null, true)
		{
			this.m_levelID = levelID;
		}

		// Token: 0x06011663 RID: 71267 RVA: 0x004829B0 File Offset: 0x00480BB0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroPhantomAttackAck += this.OnHeroPhantomAttackAck;
		}

		// Token: 0x06011664 RID: 71268 RVA: 0x004829E8 File Offset: 0x00480BE8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroPhantomAttackAck -= this.OnHeroPhantomAttackAck;
			}
		}

		// Token: 0x06011665 RID: 71269 RVA: 0x00482A24 File Offset: 0x00480C24
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroPhantomAttackReq(this.m_levelID);
		}

		// Token: 0x06011666 RID: 71270 RVA: 0x00482A54 File Offset: 0x00480C54
		protected void OnHeroPhantomAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009F26 RID: 40742
		private int m_levelID;
	}
}
