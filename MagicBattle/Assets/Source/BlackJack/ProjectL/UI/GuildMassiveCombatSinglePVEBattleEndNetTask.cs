using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D3D RID: 3389
	[CustomLuaClass]
	public class GuildMassiveCombatSinglePVEBattleEndNetTask : UINetTask
	{
		// Token: 0x0600F8A4 RID: 63652 RVA: 0x00418F50 File Offset: 0x00417150
		public GuildMassiveCombatSinglePVEBattleEndNetTask(int levelId, ProBattleReport report) : base(10f, null, true)
		{
			this.m_levelId = levelId;
			this.m_report = report;
		}

		// Token: 0x0600F8A5 RID: 63653 RVA: 0x00418F70 File Offset: 0x00417170
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildMassiveCombatAttackFinishedAck += this.OnGuildMassiveCombatSinglePVEBattleEndAck;
		}

		// Token: 0x0600F8A6 RID: 63654 RVA: 0x00418FA8 File Offset: 0x004171A8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildMassiveCombatAttackFinishedAck -= this.OnGuildMassiveCombatSinglePVEBattleEndAck;
			}
		}

		// Token: 0x0600F8A7 RID: 63655 RVA: 0x00418FE4 File Offset: 0x004171E4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildMassiveCombatAttackFinishedReq(this.m_levelId, this.m_report);
		}

		// Token: 0x0600F8A8 RID: 63656 RVA: 0x0041901C File Offset: 0x0041721C
		protected void OnGuildMassiveCombatSinglePVEBattleEndAck(int result, bool isWin, BattleReward reward)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600F8AA RID: 63658 RVA: 0x00419048 File Offset: 0x00417248
		// (set) Token: 0x0600F8A9 RID: 63657 RVA: 0x0041903C File Offset: 0x0041723C
		public bool IsWin { get; private set; }

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600F8AC RID: 63660 RVA: 0x0041905C File Offset: 0x0041725C
		// (set) Token: 0x0600F8AB RID: 63659 RVA: 0x00419050 File Offset: 0x00417250
		public BattleReward Reward { get; private set; }

		// Token: 0x04009248 RID: 37448
		private int m_levelId;

		// Token: 0x04009249 RID: 37449
		private ProBattleReport m_report;
	}
}
