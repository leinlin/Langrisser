using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C88 RID: 3208
	[CustomLuaClass]
	public class FetterSkillUnlockNetTask : UINetTask
	{
		// Token: 0x0600E716 RID: 59158 RVA: 0x003DEE70 File Offset: 0x003DD070
		public FetterSkillUnlockNetTask(int heroId, int fetterId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_fetterId = fetterId;
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x003DEE90 File Offset: 0x003DD090
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFetterUnlockAck += this.OnFetterUnlockAck;
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x003DEEC8 File Offset: 0x003DD0C8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFetterUnlockAck -= this.OnFetterUnlockAck;
			}
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x003DEF04 File Offset: 0x003DD104
		protected void OnFetterUnlockAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x003DEF1C File Offset: 0x003DD11C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroFetterUnlockReq(this.m_heroId, this.m_fetterId);
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600E71C RID: 59164 RVA: 0x003DEF60 File Offset: 0x003DD160
		// (set) Token: 0x0600E71B RID: 59163 RVA: 0x003DEF54 File Offset: 0x003DD154
		public List<Goods> Rewards { get; private set; }

		// Token: 0x04008B33 RID: 35635
		private int m_heroId;

		// Token: 0x04008B34 RID: 35636
		private int m_fetterId;
	}
}
