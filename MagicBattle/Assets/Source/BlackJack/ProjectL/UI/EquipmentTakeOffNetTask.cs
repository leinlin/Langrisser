using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF2 RID: 3570
	[CustomLuaClass]
	public class EquipmentTakeOffNetTask : UINetTask
	{
		// Token: 0x0601113C RID: 69948 RVA: 0x0046CDD0 File Offset: 0x0046AFD0
		public EquipmentTakeOffNetTask(int heroId, int slot) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_slot = slot;
		}

		// Token: 0x0601113D RID: 69949 RVA: 0x0046CDF0 File Offset: 0x0046AFF0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEquipmentTakeOffAck += this.OnEquipmentTakeOffAck;
		}

		// Token: 0x0601113E RID: 69950 RVA: 0x0046CE28 File Offset: 0x0046B028
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEquipmentTakeOffAck -= this.OnEquipmentTakeOffAck;
			}
		}

		// Token: 0x0601113F RID: 69951 RVA: 0x0046CE64 File Offset: 0x0046B064
		protected void OnEquipmentTakeOffAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011140 RID: 69952 RVA: 0x0046CE74 File Offset: 0x0046B074
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEquipmentTakeOffReq(this.m_heroId, this.m_slot);
		}

		// Token: 0x04009D0B RID: 40203
		private int m_heroId;

		// Token: 0x04009D0C RID: 40204
		private int m_slot;
	}
}
