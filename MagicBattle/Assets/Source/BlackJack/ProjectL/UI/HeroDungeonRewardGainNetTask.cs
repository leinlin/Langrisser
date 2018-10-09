using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E15 RID: 3605
	[CustomLuaClass]
	public class HeroDungeonRewardGainNetTask : UINetTask
	{
		// Token: 0x060114FC RID: 70908 RVA: 0x0047D324 File Offset: 0x0047B524
		public HeroDungeonRewardGainNetTask(int chapterId, int index) : base(10f, null, true)
		{
			this.m_chapterId = chapterId;
			this.m_index = index;
		}

		// Token: 0x060114FD RID: 70909 RVA: 0x0047D344 File Offset: 0x0047B544
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroDungeonRewardGainAck += this.OnHeroDungeonRewardGainAck;
		}

		// Token: 0x060114FE RID: 70910 RVA: 0x0047D37C File Offset: 0x0047B57C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroDungeonRewardGainAck -= this.OnHeroDungeonRewardGainAck;
			}
		}

		// Token: 0x060114FF RID: 70911 RVA: 0x0047D3B8 File Offset: 0x0047B5B8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroDungeonChapterStarRewardGainReq(this.m_chapterId, this.m_index);
		}

		// Token: 0x06011500 RID: 70912 RVA: 0x0047D3F0 File Offset: 0x0047B5F0
		protected void OnHeroDungeonRewardGainAck(int result, BattleReward reward)
		{
			base.Result = result;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x06011502 RID: 70914 RVA: 0x0047D414 File Offset: 0x0047B614
		// (set) Token: 0x06011501 RID: 70913 RVA: 0x0047D408 File Offset: 0x0047B608
		public BattleReward Reward { get; private set; }

		// Token: 0x04009E9F RID: 40607
		private int m_chapterId;

		// Token: 0x04009EA0 RID: 40608
		private int m_index;
	}
}
