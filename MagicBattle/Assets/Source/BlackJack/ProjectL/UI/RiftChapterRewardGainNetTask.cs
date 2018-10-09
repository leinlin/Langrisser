using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EEB RID: 3819
	[CustomLuaClass]
	public class RiftChapterRewardGainNetTask : UINetTask
	{
		// Token: 0x06012D1A RID: 77082 RVA: 0x004CF214 File Offset: 0x004CD414
		public RiftChapterRewardGainNetTask(int chapterId, int index) : base(10f, null, true)
		{
			this.m_chapterId = chapterId;
			this.m_index = index;
		}

		// Token: 0x06012D1B RID: 77083 RVA: 0x004CF234 File Offset: 0x004CD434
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRiftChapterRewardGainAck += this.OnRiftChapterRewardGainAck;
		}

		// Token: 0x06012D1C RID: 77084 RVA: 0x004CF26C File Offset: 0x004CD46C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRiftChapterRewardGainAck -= this.OnRiftChapterRewardGainAck;
			}
		}

		// Token: 0x06012D1D RID: 77085 RVA: 0x004CF2A8 File Offset: 0x004CD4A8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRiftChapterRewardGainReq(this.m_chapterId, this.m_index);
		}

		// Token: 0x06012D1E RID: 77086 RVA: 0x004CF2E0 File Offset: 0x004CD4E0
		protected void OnRiftChapterRewardGainAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x06012D20 RID: 77088 RVA: 0x004CF304 File Offset: 0x004CD504
		// (set) Token: 0x06012D1F RID: 77087 RVA: 0x004CF2F8 File Offset: 0x004CD4F8
		public BattleReward Reward { get; private set; }

		// Token: 0x0400A848 RID: 43080
		private int m_chapterId;

		// Token: 0x0400A849 RID: 43081
		private int m_index;
	}
}
