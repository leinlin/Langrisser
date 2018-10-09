using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DFF RID: 3583
	[CustomLuaClass]
	public class SoldierSkinTakeOffNetTask : UINetTask
	{
		// Token: 0x0601117D RID: 70013 RVA: 0x0046D8DC File Offset: 0x0046BADC
		public SoldierSkinTakeOffNetTask(int heroId, int soldierId, bool isSetToAllSoldier) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_soldierId = soldierId;
			this.m_isSetToAll = isSetToAllSoldier;
		}

		// Token: 0x0601117E RID: 70014 RVA: 0x0046D900 File Offset: 0x0046BB00
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnSoldierSkinTakeOffAck += this.OnSoldierSkinTakeOffAck;
		}

		// Token: 0x0601117F RID: 70015 RVA: 0x0046D938 File Offset: 0x0046BB38
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnSoldierSkinTakeOffAck -= this.OnSoldierSkinTakeOffAck;
			}
		}

		// Token: 0x06011180 RID: 70016 RVA: 0x0046D974 File Offset: 0x0046BB74
		protected void OnSoldierSkinTakeOffAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011181 RID: 70017 RVA: 0x0046D984 File Offset: 0x0046BB84
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendSoldierSkinTakeOffReq(this.m_heroId, this.m_soldierId, this.m_isSetToAll);
		}

		// Token: 0x04009D25 RID: 40229
		private int m_heroId;

		// Token: 0x04009D26 RID: 40230
		private int m_soldierId;

		// Token: 0x04009D27 RID: 40231
		private bool m_isSetToAll;
	}
}
