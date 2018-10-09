using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C3A RID: 3130
	[CustomLuaClass]
	public class HeroAssistantCancelTaskNetTask : UINetTask
	{
		// Token: 0x0600DC13 RID: 56339 RVA: 0x003BA410 File Offset: 0x003B8610
		public HeroAssistantCancelTaskNetTask(int taskIndex, int slot) : base(10f, null, true)
		{
			this.m_taskIndex = taskIndex;
			this.m_slot = slot;
		}

		// Token: 0x0600DC14 RID: 56340 RVA: 0x003BA430 File Offset: 0x003B8630
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroAssistantCancelTaskAck += this.OnHeroAssistantCancelTaskAck;
		}

		// Token: 0x0600DC15 RID: 56341 RVA: 0x003BA468 File Offset: 0x003B8668
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroAssistantCancelTaskAck -= this.OnHeroAssistantCancelTaskAck;
			}
		}

		// Token: 0x0600DC16 RID: 56342 RVA: 0x003BA4A4 File Offset: 0x003B86A4
		protected void OnHeroAssistantCancelTaskAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600DC17 RID: 56343 RVA: 0x003BA4B4 File Offset: 0x003B86B4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroAssistantCancelTaskReq(this.m_taskIndex, this.m_slot);
		}

		// Token: 0x040086A1 RID: 34465
		private int m_taskIndex;

		// Token: 0x040086A2 RID: 34466
		private int m_slot;
	}
}
