using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E1D RID: 3613
	[CustomLuaClass]
	public class HeroPhantomLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x06011667 RID: 71271 RVA: 0x00482A64 File Offset: 0x00480C64
		public HeroPhantomLevelBattleFinishedNetTask(int levelID, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_levelID = levelID;
			this.m_battleReport = battleReport;
		}

		// Token: 0x06011668 RID: 71272 RVA: 0x00482A84 File Offset: 0x00480C84
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroPhantomBattleFinishedAck += this.OnHeroPhantomBattleFinishedAck;
		}

		// Token: 0x06011669 RID: 71273 RVA: 0x00482ABC File Offset: 0x00480CBC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroPhantomBattleFinishedAck -= this.OnHeroPhantomBattleFinishedAck;
			}
		}

		// Token: 0x0601166A RID: 71274 RVA: 0x00482AF8 File Offset: 0x00480CF8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroPhantomBattleFinishedReq(this.m_levelID, this.m_battleReport);
		}

		// Token: 0x0601166B RID: 71275 RVA: 0x00482B30 File Offset: 0x00480D30
		protected void OnHeroPhantomBattleFinishedAck(int result, bool isWin, BattleReward reward, bool isFirstWin, List<int> achievements)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.IsFirstWin = isFirstWin;
			this.Achievements = achievements;
			this.OnTransactionComplete();
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0601166D RID: 71277 RVA: 0x00482B6C File Offset: 0x00480D6C
		// (set) Token: 0x0601166C RID: 71276 RVA: 0x00482B60 File Offset: 0x00480D60
		public bool IsWin { get; private set; }

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0601166F RID: 71279 RVA: 0x00482B80 File Offset: 0x00480D80
		// (set) Token: 0x0601166E RID: 71278 RVA: 0x00482B74 File Offset: 0x00480D74
		public bool IsFirstWin { get; private set; }

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x06011671 RID: 71281 RVA: 0x00482B94 File Offset: 0x00480D94
		// (set) Token: 0x06011670 RID: 71280 RVA: 0x00482B88 File Offset: 0x00480D88
		public BattleReward Reward { get; private set; }

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x06011673 RID: 71283 RVA: 0x00482BA8 File Offset: 0x00480DA8
		// (set) Token: 0x06011672 RID: 71282 RVA: 0x00482B9C File Offset: 0x00480D9C
		public List<int> Achievements { get; private set; }

		// Token: 0x04009F2B RID: 40747
		private int m_levelID;

		// Token: 0x04009F2C RID: 40748
		private ProBattleReport m_battleReport;
	}
}
