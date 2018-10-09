using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF7 RID: 3575
	[CustomLuaClass]
	public class AutoRemoveEquipmentNetTask : UINetTask
	{
		// Token: 0x06011155 RID: 69973 RVA: 0x0046D200 File Offset: 0x0046B400
		public AutoRemoveEquipmentNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x06011156 RID: 69974 RVA: 0x0046D218 File Offset: 0x0046B418
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnAutoTakeOffEquipmentsAck += this.OnAutoEquipAck;
		}

		// Token: 0x06011157 RID: 69975 RVA: 0x0046D250 File Offset: 0x0046B450
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnAutoTakeOffEquipmentsAck -= this.OnAutoEquipAck;
			}
		}

		// Token: 0x06011158 RID: 69976 RVA: 0x0046D28C File Offset: 0x0046B48C
		protected void OnAutoEquipAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011159 RID: 69977 RVA: 0x0046D29C File Offset: 0x0046B49C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendAutoTakeOffEquipmentsReq(this.m_heroId);
		}

		// Token: 0x04009D13 RID: 40211
		private int m_heroId;
	}
}
