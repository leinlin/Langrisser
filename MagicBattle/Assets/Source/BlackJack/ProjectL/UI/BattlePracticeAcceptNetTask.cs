using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CAC RID: 3244
	[CustomLuaClass]
	public class BattlePracticeAcceptNetTask : UINetTask
	{
		// Token: 0x0600E926 RID: 59686 RVA: 0x003E5FF0 File Offset: 0x003E41F0
		public BattlePracticeAcceptNetTask(string targetUserId) : base(10f, null, true)
		{
			this.m_targetUserId = targetUserId;
		}

		// Token: 0x0600E927 RID: 59687 RVA: 0x003E6008 File Offset: 0x003E4208
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattlePracticeAcceptAck += this.OnBattlePracticeAcceptAck;
		}

		// Token: 0x0600E928 RID: 59688 RVA: 0x003E6040 File Offset: 0x003E4240
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattlePracticeAcceptAck -= this.OnBattlePracticeAcceptAck;
			}
		}

		// Token: 0x0600E929 RID: 59689 RVA: 0x003E607C File Offset: 0x003E427C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattlePracticeAcceptReq(this.m_targetUserId);
		}

		// Token: 0x0600E92A RID: 59690 RVA: 0x003E60AC File Offset: 0x003E42AC
		protected void OnBattlePracticeAcceptAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BF9 RID: 35833
		private string m_targetUserId;
	}
}
