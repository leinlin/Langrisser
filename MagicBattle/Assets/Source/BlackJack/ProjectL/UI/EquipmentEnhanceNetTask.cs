using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF4 RID: 3572
	[CustomLuaClass]
	public class EquipmentEnhanceNetTask : UINetTask
	{
		// Token: 0x06011146 RID: 69958 RVA: 0x0046CF78 File Offset: 0x0046B178
		public EquipmentEnhanceNetTask(ulong instanceId, List<ulong> materialIds) : base(10f, null, true)
		{
			this.m_instanceId = instanceId;
			this.m_materialIds = new List<ulong>(materialIds);
		}

		// Token: 0x06011147 RID: 69959 RVA: 0x0046CF9C File Offset: 0x0046B19C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentEnhanceAck += this.OnEquipmentEnhance;
		}

		// Token: 0x06011148 RID: 69960 RVA: 0x0046CFD4 File Offset: 0x0046B1D4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentEnhanceAck -= this.OnEquipmentEnhance;
			}
		}

		// Token: 0x06011149 RID: 69961 RVA: 0x0046D010 File Offset: 0x0046B210
		protected void OnEquipmentEnhance(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601114A RID: 69962 RVA: 0x0046D020 File Offset: 0x0046B220
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEquipmentEnhanceReq(this.m_instanceId, this.m_materialIds);
		}

		// Token: 0x04009D0E RID: 40206
		private ulong m_instanceId;

		// Token: 0x04009D0F RID: 40207
		private List<ulong> m_materialIds;
	}
}
