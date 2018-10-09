using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CAD RID: 3245
	[CustomLuaClass]
	public class BattlePracticeDeclineNetTask : UINetTask
	{
		// Token: 0x0600E92B RID: 59691 RVA: 0x003E60BC File Offset: 0x003E42BC
		public BattlePracticeDeclineNetTask(string targetUserId) : base(10f, null, true)
		{
			this.m_targetUserId = targetUserId;
		}

		// Token: 0x0600E92C RID: 59692 RVA: 0x003E60D4 File Offset: 0x003E42D4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattlePracticeDeclineAck += this.OnBattlePracticeDeclineAck;
		}

		// Token: 0x0600E92D RID: 59693 RVA: 0x003E610C File Offset: 0x003E430C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattlePracticeDeclineAck -= this.OnBattlePracticeDeclineAck;
			}
		}

		// Token: 0x0600E92E RID: 59694 RVA: 0x003E6148 File Offset: 0x003E4348
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattlePracticeDeclineReq(this.m_targetUserId);
		}

		// Token: 0x0600E92F RID: 59695 RVA: 0x003E6178 File Offset: 0x003E4378
		protected void OnBattlePracticeDeclineAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BFA RID: 35834
		private string m_targetUserId;
	}
}
