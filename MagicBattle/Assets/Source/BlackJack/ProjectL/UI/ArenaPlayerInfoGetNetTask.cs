using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A0C RID: 2572
	[CustomLuaClass]
	public class ArenaPlayerInfoGetNetTask : UINetTask
	{
		// Token: 0x06009AF6 RID: 39670 RVA: 0x002C2D8C File Offset: 0x002C0F8C
		public ArenaPlayerInfoGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x002C2D9C File Offset: 0x002C0F9C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaPlayerInfoGetAck += this.OnArenaPlayerInfoGetAck;
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x002C2DD4 File Offset: 0x002C0FD4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaPlayerInfoGetAck -= this.OnArenaPlayerInfoGetAck;
			}
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x002C2E10 File Offset: 0x002C1010
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaPlayerInfoGetReq();
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x002C2E3C File Offset: 0x002C103C
		protected void OnArenaPlayerInfoGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
