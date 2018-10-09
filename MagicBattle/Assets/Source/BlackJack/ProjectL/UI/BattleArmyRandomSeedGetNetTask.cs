using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A7F RID: 2687
	[CustomLuaClass]
	public class BattleArmyRandomSeedGetNetTask : UINetTask
	{
		// Token: 0x0600A9E4 RID: 43492 RVA: 0x002F5D88 File Offset: 0x002F3F88
		public BattleArmyRandomSeedGetNetTask(int battleId) : base(10f, null, true)
		{
			this.m_battleId = battleId;
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x002F5DA0 File Offset: 0x002F3FA0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleArmyRandomSeedGetAck += this.OnBattleArmyRandomSeedGetAck;
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x002F5DD8 File Offset: 0x002F3FD8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleArmyRandomSeedGetAck -= this.OnBattleArmyRandomSeedGetAck;
			}
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x002F5E14 File Offset: 0x002F4014
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleArmyRandomSeedGetReq(this.m_battleId);
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x002F5E44 File Offset: 0x002F4044
		protected void OnBattleArmyRandomSeedGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FC8 RID: 28616
		private int m_battleId;
	}
}
