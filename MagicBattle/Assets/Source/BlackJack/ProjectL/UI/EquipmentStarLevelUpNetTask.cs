using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF5 RID: 3573
	[CustomLuaClass]
	public class EquipmentStarLevelUpNetTask : UINetTask
	{
		// Token: 0x0601114B RID: 69963 RVA: 0x0046D058 File Offset: 0x0046B258
		public EquipmentStarLevelUpNetTask(ulong instanceId, ulong materialId) : base(10f, null, true)
		{
			this.m_instanceId = instanceId;
			this.m_materialId = materialId;
		}

		// Token: 0x0601114C RID: 69964 RVA: 0x0046D078 File Offset: 0x0046B278
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentStarLevelUpAck += this.OnEquipmentStarLevelUp;
		}

		// Token: 0x0601114D RID: 69965 RVA: 0x0046D0B0 File Offset: 0x0046B2B0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentStarLevelUpAck -= this.OnEquipmentStarLevelUp;
			}
		}

		// Token: 0x0601114E RID: 69966 RVA: 0x0046D0EC File Offset: 0x0046B2EC
		protected void OnEquipmentStarLevelUp(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601114F RID: 69967 RVA: 0x0046D0FC File Offset: 0x0046B2FC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEquipmentStarLevelUpReq(this.m_instanceId, this.m_materialId);
		}

		// Token: 0x04009D10 RID: 40208
		private ulong m_instanceId;

		// Token: 0x04009D11 RID: 40209
		private ulong m_materialId;
	}
}
