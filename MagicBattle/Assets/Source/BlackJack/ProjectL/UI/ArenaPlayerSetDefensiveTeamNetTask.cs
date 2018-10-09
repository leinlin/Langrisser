using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A13 RID: 2579
	[CustomLuaClass]
	public class ArenaPlayerSetDefensiveTeamNetTask : UINetTask
	{
		// Token: 0x06009B2D RID: 39725 RVA: 0x002C351C File Offset: 0x002C171C
		public ArenaPlayerSetDefensiveTeamNetTask(int arenaDefenderRuleId, int battleId, List<ArenaPlayerDefensiveHero> defensiveHeroes) : base(10f, null, true)
		{
			this.m_arenaDefenderRuleId = arenaDefenderRuleId;
			this.m_battleId = battleId;
			this.m_defensiveHeroes = new List<ArenaPlayerDefensiveHero>(defensiveHeroes);
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x002C3548 File Offset: 0x002C1748
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaPlayerSetDefensiveTeamAck += this.OnArenaPlayerSetDefensiveTeamAck;
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x002C3580 File Offset: 0x002C1780
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaPlayerSetDefensiveTeamAck -= this.OnArenaPlayerSetDefensiveTeamAck;
			}
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x002C35BC File Offset: 0x002C17BC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaPlayerSetDefensiveTeamReq(this.m_arenaDefenderRuleId, this.m_battleId, this.m_defensiveHeroes);
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x002C35F8 File Offset: 0x002C17F8
		protected void OnArenaPlayerSetDefensiveTeamAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x040069C4 RID: 27076
		private int m_arenaDefenderRuleId;

		// Token: 0x040069C5 RID: 27077
		private int m_battleId;

		// Token: 0x040069C6 RID: 27078
		private List<ArenaPlayerDefensiveHero> m_defensiveHeroes;
	}
}
