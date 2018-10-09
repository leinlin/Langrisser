using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF3 RID: 3571
	[CustomLuaClass]
	public class EquipmentLockAndUnLockNetTask : UINetTask
	{
		// Token: 0x06011141 RID: 69953 RVA: 0x0046CEAC File Offset: 0x0046B0AC
		public EquipmentLockAndUnLockNetTask(ulong instanceId) : base(10f, null, true)
		{
			this.m_instanceId = instanceId;
		}

		// Token: 0x06011142 RID: 69954 RVA: 0x0046CEC4 File Offset: 0x0046B0C4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentLockAndUnLockAck += this.OnEquipmentLockAndUnLock;
		}

		// Token: 0x06011143 RID: 69955 RVA: 0x0046CEFC File Offset: 0x0046B0FC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentWearAck -= this.OnEquipmentLockAndUnLock;
			}
		}

		// Token: 0x06011144 RID: 69956 RVA: 0x0046CF38 File Offset: 0x0046B138
		protected void OnEquipmentLockAndUnLock(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011145 RID: 69957 RVA: 0x0046CF48 File Offset: 0x0046B148
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLockAndUnLockEquipmentReq(this.m_instanceId);
		}

		// Token: 0x04009D0D RID: 40205
		private ulong m_instanceId;
	}
}
