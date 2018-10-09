using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E70 RID: 3696
	[CustomLuaClass]
	public class MemoryCorridorLevelBattleFinishedNetTask : UINetTask
	{
		// Token: 0x06011EB2 RID: 73394 RVA: 0x004A0E4C File Offset: 0x0049F04C
		public MemoryCorridorLevelBattleFinishedNetTask(int memoryCorridorLevelID, ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_memoryCorridorLevelID = memoryCorridorLevelID;
			this.m_battleReport = battleReport;
		}

		// Token: 0x06011EB3 RID: 73395 RVA: 0x004A0E6C File Offset: 0x0049F06C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMemoryCorridorLevelBattleFinishedAck += this.OnMemoryCorridorLevelBattleFinishedAck;
		}

		// Token: 0x06011EB4 RID: 73396 RVA: 0x004A0EA4 File Offset: 0x0049F0A4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMemoryCorridorLevelBattleFinishedAck -= this.OnMemoryCorridorLevelBattleFinishedAck;
			}
		}

		// Token: 0x06011EB5 RID: 73397 RVA: 0x004A0EE0 File Offset: 0x0049F0E0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendMemoryCorridorLevelBattleFinishedReq(this.m_memoryCorridorLevelID, this.m_battleReport);
		}

		// Token: 0x06011EB6 RID: 73398 RVA: 0x004A0F18 File Offset: 0x0049F118
		protected void OnMemoryCorridorLevelBattleFinishedAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x06011EB8 RID: 73400 RVA: 0x004A0F44 File Offset: 0x0049F144
		// (set) Token: 0x06011EB7 RID: 73399 RVA: 0x004A0F38 File Offset: 0x0049F138
		public bool IsWin { get; private set; }

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x06011EBA RID: 73402 RVA: 0x004A0F58 File Offset: 0x0049F158
		// (set) Token: 0x06011EB9 RID: 73401 RVA: 0x004A0F4C File Offset: 0x0049F14C
		public BattleReward Reward { get; private set; }

		// Token: 0x0400A2A2 RID: 41634
		private int m_memoryCorridorLevelID;

		// Token: 0x0400A2A3 RID: 41635
		private ProBattleReport m_battleReport;
	}
}
