using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF1 RID: 3569
	[CustomLuaClass]
	public class EquipmentWearNetTask : UINetTask
	{
		// Token: 0x06011137 RID: 69943 RVA: 0x0046CCF4 File Offset: 0x0046AEF4
		public EquipmentWearNetTask(int heroId, ulong instanceId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_instanceId = instanceId;
		}

		// Token: 0x06011138 RID: 69944 RVA: 0x0046CD14 File Offset: 0x0046AF14
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentWearAck += this.OnEquipmentWearAck;
		}

		// Token: 0x06011139 RID: 69945 RVA: 0x0046CD4C File Offset: 0x0046AF4C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentWearAck -= this.OnEquipmentWearAck;
			}
		}

		// Token: 0x0601113A RID: 69946 RVA: 0x0046CD88 File Offset: 0x0046AF88
		protected void OnEquipmentWearAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601113B RID: 69947 RVA: 0x0046CD98 File Offset: 0x0046AF98
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEquipmentWearReq(this.m_heroId, this.m_instanceId);
		}

		// Token: 0x04009D09 RID: 40201
		private int m_heroId;

		// Token: 0x04009D0A RID: 40202
		private ulong m_instanceId;
	}
}
