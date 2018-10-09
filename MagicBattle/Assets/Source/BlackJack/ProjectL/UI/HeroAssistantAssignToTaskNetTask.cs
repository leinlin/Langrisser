using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C39 RID: 3129
	[CustomLuaClass]
	public class HeroAssistantAssignToTaskNetTask : UINetTask
	{
		// Token: 0x0600DC0E RID: 56334 RVA: 0x003BA314 File Offset: 0x003B8514
		public HeroAssistantAssignToTaskNetTask(int taskIndex, List<int> heroIds, int workSeconds, int slot) : base(10f, null, true)
		{
			this.m_taskIndex = taskIndex;
			this.m_heroIds = new List<int>(heroIds);
			this.m_workSeconds = workSeconds;
			this.m_slot = slot;
		}

		// Token: 0x0600DC0F RID: 56335 RVA: 0x003BA348 File Offset: 0x003B8548
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroAssistantAssignToTaskAck += this.OnHeroAssistantAssignToTaskAck;
		}

		// Token: 0x0600DC10 RID: 56336 RVA: 0x003BA380 File Offset: 0x003B8580
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroAssistantAssignToTaskAck -= this.OnHeroAssistantAssignToTaskAck;
			}
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x003BA3BC File Offset: 0x003B85BC
		protected void OnHeroAssistantAssignToTaskAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600DC12 RID: 56338 RVA: 0x003BA3CC File Offset: 0x003B85CC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroAssistantAssignToTaskReq(this.m_taskIndex, this.m_slot, this.m_heroIds, this.m_workSeconds);
		}

		// Token: 0x0400869D RID: 34461
		private int m_slot;

		// Token: 0x0400869E RID: 34462
		private int m_taskIndex;

		// Token: 0x0400869F RID: 34463
		private List<int> m_heroIds;

		// Token: 0x040086A0 RID: 34464
		private int m_workSeconds;
	}
}
