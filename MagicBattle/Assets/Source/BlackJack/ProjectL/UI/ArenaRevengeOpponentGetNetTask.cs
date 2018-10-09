using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A0F RID: 2575
	[CustomLuaClass]
	public class ArenaRevengeOpponentGetNetTask : UINetTask
	{
		// Token: 0x06009B09 RID: 39689 RVA: 0x002C301C File Offset: 0x002C121C
		public ArenaRevengeOpponentGetNetTask(ulong arenaBattleReportInstanceId) : base(10f, null, true)
		{
			this.m_arenaBattleReportInstanceId = arenaBattleReportInstanceId;
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x002C3034 File Offset: 0x002C1234
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaRevengeOpponentGetAck += this.OnArenaRevengeOpponentGetAck;
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x002C306C File Offset: 0x002C126C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaRevengeOpponentGetAck -= this.OnArenaRevengeOpponentGetAck;
			}
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x002C30A8 File Offset: 0x002C12A8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaRevengeOpponentGetReq(this.m_arenaBattleReportInstanceId);
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x002C30D8 File Offset: 0x002C12D8
		protected void OnArenaRevengeOpponentGetAck(int result, ProArenaOpponent arenaOpponent, List<ProBattleHero> heros, int battlePower)
		{
			base.Result = result;
			this.Heros = heros;
			this.ArenaOpponent = arenaOpponent;
			this.BattlePower = battlePower;
			this.OnTransactionComplete();
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06009B0F RID: 39695 RVA: 0x002C310C File Offset: 0x002C130C
		// (set) Token: 0x06009B0E RID: 39694 RVA: 0x002C3100 File Offset: 0x002C1300
		public List<ProBattleHero> Heros { get; private set; }

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06009B11 RID: 39697 RVA: 0x002C3120 File Offset: 0x002C1320
		// (set) Token: 0x06009B10 RID: 39696 RVA: 0x002C3114 File Offset: 0x002C1314
		public int BattlePower { get; private set; }

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06009B13 RID: 39699 RVA: 0x002C3134 File Offset: 0x002C1334
		// (set) Token: 0x06009B12 RID: 39698 RVA: 0x002C3128 File Offset: 0x002C1328
		public ProArenaOpponent ArenaOpponent { get; private set; }

		// Token: 0x040069BE RID: 27070
		private ulong m_arenaBattleReportInstanceId;
	}
}
