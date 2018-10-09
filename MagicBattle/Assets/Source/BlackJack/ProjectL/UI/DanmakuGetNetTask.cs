using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A81 RID: 2689
	[CustomLuaClass]
	public class DanmakuGetNetTask : UINetTask
	{
		// Token: 0x0600A9EE RID: 43502 RVA: 0x002F5F40 File Offset: 0x002F4140
		public DanmakuGetNetTask(int gameFunctionTypeId, int locationId) : base(10f, null, true)
		{
			this.m_gameFunctionTypeId = gameFunctionTypeId;
			this.m_locationId = locationId;
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x002F5F60 File Offset: 0x002F4160
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetLevelDanmakuAck += this.OnGetLevelDanmakuAck;
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x002F5F98 File Offset: 0x002F4198
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGetLevelDanmakuAck -= this.OnGetLevelDanmakuAck;
			}
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x002F5FD4 File Offset: 0x002F41D4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLevelDanmakuGetReq(this.m_gameFunctionTypeId, this.m_locationId);
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x002F600C File Offset: 0x002F420C
		protected void OnGetLevelDanmakuAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FCC RID: 28620
		private int m_gameFunctionTypeId;

		// Token: 0x04006FCD RID: 28621
		private int m_locationId;
	}
}
