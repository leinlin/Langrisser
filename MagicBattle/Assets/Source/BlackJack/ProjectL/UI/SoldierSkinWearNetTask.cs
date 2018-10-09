using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DFE RID: 3582
	[CustomLuaClass]
	public class SoldierSkinWearNetTask : UINetTask
	{
		// Token: 0x06011178 RID: 70008 RVA: 0x0046D7E8 File Offset: 0x0046B9E8
		public SoldierSkinWearNetTask(int heroId, int soldierId, int soldierSkinId, bool isSetToAllSoldier) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_soldierId = soldierId;
			this.m_soldierSkinId = soldierSkinId;
			this.m_isSetToAll = isSetToAllSoldier;
		}

		// Token: 0x06011179 RID: 70009 RVA: 0x0046D814 File Offset: 0x0046BA14
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnSoldierSkinWearAck += this.OnSoldierSkinWearAck;
		}

		// Token: 0x0601117A RID: 70010 RVA: 0x0046D84C File Offset: 0x0046BA4C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnSoldierSkinWearAck -= this.OnSoldierSkinWearAck;
			}
		}

		// Token: 0x0601117B RID: 70011 RVA: 0x0046D888 File Offset: 0x0046BA88
		protected void OnSoldierSkinWearAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601117C RID: 70012 RVA: 0x0046D898 File Offset: 0x0046BA98
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendSoldierSkinWearReq(this.m_heroId, this.m_soldierId, this.m_soldierSkinId, this.m_isSetToAll);
		}

		// Token: 0x04009D21 RID: 40225
		private int m_heroId;

		// Token: 0x04009D22 RID: 40226
		private int m_soldierId;

		// Token: 0x04009D23 RID: 40227
		private int m_soldierSkinId;

		// Token: 0x04009D24 RID: 40228
		private bool m_isSetToAll;
	}
}
