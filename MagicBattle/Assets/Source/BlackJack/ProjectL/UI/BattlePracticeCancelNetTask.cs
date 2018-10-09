using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CAE RID: 3246
	[CustomLuaClass]
	public class BattlePracticeCancelNetTask : UINetTask
	{
		// Token: 0x0600E930 RID: 59696 RVA: 0x003E6188 File Offset: 0x003E4388
		public BattlePracticeCancelNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600E931 RID: 59697 RVA: 0x003E6198 File Offset: 0x003E4398
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattlePracticeCancelAck += this.OnBattlePracticeCancelAck;
		}

		// Token: 0x0600E932 RID: 59698 RVA: 0x003E61D0 File Offset: 0x003E43D0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattlePracticeCancelAck -= this.OnBattlePracticeCancelAck;
			}
		}

		// Token: 0x0600E933 RID: 59699 RVA: 0x003E620C File Offset: 0x003E440C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattlePracticeCancelReq();
		}

		// Token: 0x0600E934 RID: 59700 RVA: 0x003E6238 File Offset: 0x003E4438
		protected void OnBattlePracticeCancelAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
