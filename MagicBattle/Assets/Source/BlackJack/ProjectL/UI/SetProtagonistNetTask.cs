using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CC5 RID: 3269
	[CustomLuaClass]
	public class SetProtagonistNetTask : UINetTask
	{
		// Token: 0x0600ED4A RID: 60746 RVA: 0x003F6764 File Offset: 0x003F4964
		public SetProtagonistNetTask(int protagonistId) : base(10f, null, true)
		{
			this.m_protagonistId = protagonistId;
		}

		// Token: 0x0600ED4B RID: 60747 RVA: 0x003F677C File Offset: 0x003F497C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnSetProtagonistAck += this.OnSetProtagonistAck;
		}

		// Token: 0x0600ED4C RID: 60748 RVA: 0x003F67B4 File Offset: 0x003F49B4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnSetProtagonistAck -= this.OnSetProtagonistAck;
			}
		}

		// Token: 0x0600ED4D RID: 60749 RVA: 0x003F67F0 File Offset: 0x003F49F0
		protected void OnSetProtagonistAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600ED4E RID: 60750 RVA: 0x003F6800 File Offset: 0x003F4A00
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendSetProtagonistReq(this.m_protagonistId);
		}

		// Token: 0x04008DDD RID: 36317
		private int m_protagonistId;
	}
}
