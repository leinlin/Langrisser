using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E77 RID: 3703
	[CustomLuaClass]
	public class MissionRewardGetNetTask : UINetTask
	{
		// Token: 0x06011FD6 RID: 73686 RVA: 0x004A4840 File Offset: 0x004A2A40
		public MissionRewardGetNetTask(int id) : base(10f, null, true)
		{
			this.m_missionId = id;
		}

		// Token: 0x06011FD7 RID: 73687 RVA: 0x004A4858 File Offset: 0x004A2A58
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMissionRewardGetAck += this.OnMissionRewrdGetAck;
		}

		// Token: 0x06011FD8 RID: 73688 RVA: 0x004A4890 File Offset: 0x004A2A90
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMissionRewardGetAck -= this.OnMissionRewrdGetAck;
			}
		}

		// Token: 0x06011FD9 RID: 73689 RVA: 0x004A48CC File Offset: 0x004A2ACC
		protected void OnMissionRewrdGetAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x06011FDA RID: 73690 RVA: 0x004A48E4 File Offset: 0x004A2AE4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetMissionRewardReq(this.m_missionId);
		}

		// Token: 0x0400A304 RID: 41732
		public List<Goods> Rewards;

		// Token: 0x0400A305 RID: 41733
		private int m_missionId;
	}
}
