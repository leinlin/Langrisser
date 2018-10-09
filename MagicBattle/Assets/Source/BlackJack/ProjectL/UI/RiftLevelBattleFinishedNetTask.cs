using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EE9 RID: 3817
	[CustomLuaClass]
	public class RiftLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x06012D04 RID: 77060 RVA: 0x004CEFB4 File Offset: 0x004CD1B4
		public RiftLevelBattleFinishedNetTask(int riftLevelId, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_riftLevelId = riftLevelId;
			this.m_battleReport = battleReport;
		}

		// Token: 0x06012D05 RID: 77061 RVA: 0x004CEFD4 File Offset: 0x004CD1D4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRiftLevelBattleFinishedAck += this.OnRiftLevelBattleFinishedAck;
		}

		// Token: 0x06012D06 RID: 77062 RVA: 0x004CF00C File Offset: 0x004CD20C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRiftLevelBattleFinishedAck -= this.OnRiftLevelBattleFinishedAck;
			}
		}

		// Token: 0x06012D07 RID: 77063 RVA: 0x004CF048 File Offset: 0x004CD248
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRiftLevelBattleFinishedReq(this.m_riftLevelId, this.m_battleReport);
		}

		// Token: 0x06012D08 RID: 77064 RVA: 0x004CF080 File Offset: 0x004CD280
		protected void OnRiftLevelBattleFinishedAck(int result, int stars, BattleReward reward, bool isFirstWin, List<int> achievements)
		{
			base.Result = result;
			this.Stars = stars;
			this.Reward = reward;
			this.IsFirstWin = isFirstWin;
			this.Achievements = achievements;
			this.OnTransactionComplete();
		}

		// Token: 0x170038B8 RID: 14520
		// (get) Token: 0x06012D0A RID: 77066 RVA: 0x004CF0BC File Offset: 0x004CD2BC
		// (set) Token: 0x06012D09 RID: 77065 RVA: 0x004CF0B0 File Offset: 0x004CD2B0
		public int Stars { get; private set; }

		// Token: 0x170038B9 RID: 14521
		// (get) Token: 0x06012D0C RID: 77068 RVA: 0x004CF0D0 File Offset: 0x004CD2D0
		// (set) Token: 0x06012D0B RID: 77067 RVA: 0x004CF0C4 File Offset: 0x004CD2C4
		public bool IsFirstWin { get; private set; }

		// Token: 0x170038BA RID: 14522
		// (get) Token: 0x06012D0E RID: 77070 RVA: 0x004CF0E4 File Offset: 0x004CD2E4
		// (set) Token: 0x06012D0D RID: 77069 RVA: 0x004CF0D8 File Offset: 0x004CD2D8
		public BattleReward Reward { get; private set; }

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x06012D10 RID: 77072 RVA: 0x004CF0F8 File Offset: 0x004CD2F8
		// (set) Token: 0x06012D0F RID: 77071 RVA: 0x004CF0EC File Offset: 0x004CD2EC
		public List<int> Achievements { get; private set; }

		// Token: 0x0400A841 RID: 43073
		private int m_riftLevelId;

		// Token: 0x0400A842 RID: 43074
		private ProBattleReport m_battleReport;
	}
}
