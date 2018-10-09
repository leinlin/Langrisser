using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E13 RID: 3603
	[CustomLuaClass]
	public class HeroDungeonLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x060114E6 RID: 70886 RVA: 0x0047D0C4 File Offset: 0x0047B2C4
		public HeroDungeonLevelBattleFinishedNetTask(int heroDungeonLevelID, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_heroDungeonLevelID = heroDungeonLevelID;
			this.m_battleReport = battleReport;
		}

		// Token: 0x060114E7 RID: 70887 RVA: 0x0047D0E4 File Offset: 0x0047B2E4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroDungeonLevelBattleFinishedAck += this.OnHeroDungeonLevelBattleFinishedAck;
		}

		// Token: 0x060114E8 RID: 70888 RVA: 0x0047D11C File Offset: 0x0047B31C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroDungeonLevelBattleFinishedAck -= this.OnHeroDungeonLevelBattleFinishedAck;
			}
		}

		// Token: 0x060114E9 RID: 70889 RVA: 0x0047D158 File Offset: 0x0047B358
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroDungeonLevelBattleFinishedReq(this.m_heroDungeonLevelID, this.m_battleReport);
		}

		// Token: 0x060114EA RID: 70890 RVA: 0x0047D190 File Offset: 0x0047B390
		protected void OnHeroDungeonLevelBattleFinishedAck(int result, int stars, BattleReward reward, bool isFirstWin, List<int> achievements)
		{
			base.Result = result;
			this.Stars = stars;
			this.Reward = reward;
			this.IsFirstWin = isFirstWin;
			this.Achievements = achievements;
			this.OnTransactionComplete();
		}

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x060114EC RID: 70892 RVA: 0x0047D1CC File Offset: 0x0047B3CC
		// (set) Token: 0x060114EB RID: 70891 RVA: 0x0047D1C0 File Offset: 0x0047B3C0
		public int Stars { get; private set; }

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x060114EE RID: 70894 RVA: 0x0047D1E0 File Offset: 0x0047B3E0
		// (set) Token: 0x060114ED RID: 70893 RVA: 0x0047D1D4 File Offset: 0x0047B3D4
		public bool IsFirstWin { get; private set; }

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x060114F0 RID: 70896 RVA: 0x0047D1F4 File Offset: 0x0047B3F4
		// (set) Token: 0x060114EF RID: 70895 RVA: 0x0047D1E8 File Offset: 0x0047B3E8
		public BattleReward Reward { get; private set; }

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x060114F2 RID: 70898 RVA: 0x0047D208 File Offset: 0x0047B408
		// (set) Token: 0x060114F1 RID: 70897 RVA: 0x0047D1FC File Offset: 0x0047B3FC
		public List<int> Achievements { get; private set; }

		// Token: 0x04009E98 RID: 40600
		private int m_heroDungeonLevelID;

		// Token: 0x04009E99 RID: 40601
		private ProBattleReport m_battleReport;
	}
}
