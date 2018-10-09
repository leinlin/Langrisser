using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A80 RID: 2688
	[CustomLuaClass]
	public class BattleTeamSetNetTask : UINetTask
	{
		// Token: 0x0600A9E9 RID: 43497 RVA: 0x002F5E54 File Offset: 0x002F4054
		public BattleTeamSetNetTask(BattleType battleType, int battleId, List<int> heros) : base(10f, null, true)
		{
			this.m_battleType = battleType;
			this.m_battleId = battleId;
			this.m_heros = new List<int>(heros);
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x002F5E80 File Offset: 0x002F4080
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleTeamSetAck += this.OnBattleTeamSetAck;
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x002F5EB8 File Offset: 0x002F40B8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleCancelAck -= this.OnBattleTeamSetAck;
			}
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x002F5EF4 File Offset: 0x002F40F4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleTeamSetReq(this.m_battleType, this.m_battleId, this.m_heros);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x002F5F30 File Offset: 0x002F4130
		protected void OnBattleTeamSetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FC9 RID: 28617
		private BattleType m_battleType;

		// Token: 0x04006FCA RID: 28618
		private int m_battleId;

		// Token: 0x04006FCB RID: 28619
		private List<int> m_heros;
	}
}
