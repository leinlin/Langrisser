using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A0D RID: 2573
	[CustomLuaClass]
	public class ArenaOpponentViewNetTask : UINetTask
	{
		// Token: 0x06009AFB RID: 39675 RVA: 0x002C2E4C File Offset: 0x002C104C
		public ArenaOpponentViewNetTask(int opponentIndex) : base(10f, null, true)
		{
			this.m_opponentIndex = opponentIndex;
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x002C2E64 File Offset: 0x002C1064
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaOpponentViewAck += this.OnArenaOpponentViewAck;
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x002C2E9C File Offset: 0x002C109C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaOpponentViewAck -= this.OnArenaOpponentViewAck;
			}
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x002C2ED8 File Offset: 0x002C10D8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaOpponentViewReq(this.m_opponentIndex);
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x002C2F08 File Offset: 0x002C1108
		protected void OnArenaOpponentViewAck(int result, List<ProBattleHero> heros, int battlePower)
		{
			base.Result = result;
			this.Heros = heros;
			this.BattlePower = battlePower;
			this.OnTransactionComplete();
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06009B01 RID: 39681 RVA: 0x002C2F34 File Offset: 0x002C1134
		// (set) Token: 0x06009B00 RID: 39680 RVA: 0x002C2F28 File Offset: 0x002C1128
		public List<ProBattleHero> Heros { get; private set; }

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06009B03 RID: 39683 RVA: 0x002C2F48 File Offset: 0x002C1148
		// (set) Token: 0x06009B02 RID: 39682 RVA: 0x002C2F3C File Offset: 0x002C113C
		public int BattlePower { get; private set; }

		// Token: 0x040069B9 RID: 27065
		private int m_opponentIndex;
	}
}
