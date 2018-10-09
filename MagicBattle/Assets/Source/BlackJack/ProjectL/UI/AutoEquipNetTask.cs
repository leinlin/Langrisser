using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DF6 RID: 3574
	[CustomLuaClass]
	public class AutoEquipNetTask : UINetTask
	{
		// Token: 0x06011150 RID: 69968 RVA: 0x0046D134 File Offset: 0x0046B334
		public AutoEquipNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x06011151 RID: 69969 RVA: 0x0046D14C File Offset: 0x0046B34C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnAutoEquipAck += this.OnAutoEquipAck;
		}

		// Token: 0x06011152 RID: 69970 RVA: 0x0046D184 File Offset: 0x0046B384
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnAutoEquipAck -= this.OnAutoEquipAck;
			}
		}

		// Token: 0x06011153 RID: 69971 RVA: 0x0046D1C0 File Offset: 0x0046B3C0
		protected void OnAutoEquipAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011154 RID: 69972 RVA: 0x0046D1D0 File Offset: 0x0046B3D0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendAutoEquipReq(this.m_heroId);
		}

		// Token: 0x04009D12 RID: 40210
		private int m_heroId;
	}
}
