using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EE8 RID: 3816
	[CustomLuaClass]
	public class RiftLevelAttackNetTask : UINetTask
	{
		// Token: 0x06012CFF RID: 77055 RVA: 0x004CEEE8 File Offset: 0x004CD0E8
		public RiftLevelAttackNetTask(int levelId) : base(10f, null, true)
		{
			this.m_levelId = levelId;
		}

		// Token: 0x06012D00 RID: 77056 RVA: 0x004CEF00 File Offset: 0x004CD100
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRiftLevelAttackAck += this.OnRiftLevelAttackAck;
		}

		// Token: 0x06012D01 RID: 77057 RVA: 0x004CEF38 File Offset: 0x004CD138
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRiftLevelAttackAck -= this.OnRiftLevelAttackAck;
			}
		}

		// Token: 0x06012D02 RID: 77058 RVA: 0x004CEF74 File Offset: 0x004CD174
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRiftLevelAttackReq(this.m_levelId);
		}

		// Token: 0x06012D03 RID: 77059 RVA: 0x004CEFA4 File Offset: 0x004CD1A4
		protected void OnRiftLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400A83C RID: 43068
		private int m_levelId;
	}
}
