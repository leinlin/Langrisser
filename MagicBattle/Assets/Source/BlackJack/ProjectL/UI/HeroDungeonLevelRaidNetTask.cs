using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E14 RID: 3604
	[CustomLuaClass]
	public class HeroDungeonLevelRaidNetTask : UINetTask
	{
		// Token: 0x060114F3 RID: 70899 RVA: 0x0047D210 File Offset: 0x0047B410
		public HeroDungeonLevelRaidNetTask(int heroDungeonLevelID, int count) : base(10f, null, true)
		{
			this.m_heroDungeonLevelID = heroDungeonLevelID;
			this.m_count = count;
		}

		// Token: 0x060114F4 RID: 70900 RVA: 0x0047D230 File Offset: 0x0047B430
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroDungeonLevelRaidAck += this.OnHeroDungeonLevelRaidAck;
		}

		// Token: 0x060114F5 RID: 70901 RVA: 0x0047D268 File Offset: 0x0047B468
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroDungeonLevelRaidAck -= this.OnHeroDungeonLevelRaidAck;
			}
		}

		// Token: 0x060114F6 RID: 70902 RVA: 0x0047D2A4 File Offset: 0x0047B4A4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroDungeonLevelRaidReq(this.m_heroDungeonLevelID, this.m_count);
		}

		// Token: 0x060114F7 RID: 70903 RVA: 0x0047D2DC File Offset: 0x0047B4DC
		protected void OnHeroDungeonLevelRaidAck(int result, BattleReward reward, List<Goods> extraReward)
		{
			base.Result = result;
			this.Reward = reward;
			this.ExtraReward = extraReward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x060114F9 RID: 70905 RVA: 0x0047D308 File Offset: 0x0047B508
		// (set) Token: 0x060114F8 RID: 70904 RVA: 0x0047D2FC File Offset: 0x0047B4FC
		public BattleReward Reward { get; private set; }

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x060114FB RID: 70907 RVA: 0x0047D31C File Offset: 0x0047B51C
		// (set) Token: 0x060114FA RID: 70906 RVA: 0x0047D310 File Offset: 0x0047B510
		public List<Goods> ExtraReward { get; private set; }

		// Token: 0x04009E9C RID: 40604
		private int m_heroDungeonLevelID;

		// Token: 0x04009E9D RID: 40605
		private int m_count;
	}
}
