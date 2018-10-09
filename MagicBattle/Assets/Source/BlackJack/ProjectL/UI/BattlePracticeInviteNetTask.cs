using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CAB RID: 3243
	[CustomLuaClass]
	public class BattlePracticeInviteNetTask : UINetTask
	{
		// Token: 0x0600E921 RID: 59681 RVA: 0x003E5F24 File Offset: 0x003E4124
		public BattlePracticeInviteNetTask(string targetUserId) : base(10f, null, true)
		{
			this.m_targetUserId = targetUserId;
		}

		// Token: 0x0600E922 RID: 59682 RVA: 0x003E5F3C File Offset: 0x003E413C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattlePracticeInviteAck += this.OnBattlePracticeInviteAck;
		}

		// Token: 0x0600E923 RID: 59683 RVA: 0x003E5F74 File Offset: 0x003E4174
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattlePracticeInviteAck -= this.OnBattlePracticeInviteAck;
			}
		}

		// Token: 0x0600E924 RID: 59684 RVA: 0x003E5FB0 File Offset: 0x003E41B0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattlePracticeInviteReq(this.m_targetUserId);
		}

		// Token: 0x0600E925 RID: 59685 RVA: 0x003E5FE0 File Offset: 0x003E41E0
		protected void OnBattlePracticeInviteAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BF8 RID: 35832
		private string m_targetUserId;
	}
}
