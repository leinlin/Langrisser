using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EB7 RID: 3767
	[CustomLuaClass]
	public class RankingNetTask : UINetTask
	{
		// Token: 0x0601269F RID: 75423 RVA: 0x004BA1E0 File Offset: 0x004B83E0
		public RankingNetTask(RankingListType type, int heroId) : base(10f, null, true)
		{
			this.m_rankType = type;
			this.m_heroId = heroId;
		}

		// Token: 0x060126A0 RID: 75424 RVA: 0x004BA200 File Offset: 0x004B8400
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRankingListInfoQueryAck += this.OnRankingListAct;
		}

		// Token: 0x060126A1 RID: 75425 RVA: 0x004BA238 File Offset: 0x004B8438
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRankingListInfoQueryAck -= this.OnRankingListAct;
			}
		}

		// Token: 0x060126A2 RID: 75426 RVA: 0x004BA274 File Offset: 0x004B8474
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRankingListInfoQueryReq(this.m_rankType, this.m_heroId);
		}

		// Token: 0x060126A3 RID: 75427 RVA: 0x004BA2AC File Offset: 0x004B84AC
		protected void OnRankingListAct(int res)
		{
			base.Result = res;
			base.Stop();
		}

		// Token: 0x0400A5B2 RID: 42418
		protected RankingListType m_rankType;

		// Token: 0x0400A5B3 RID: 42419
		protected int m_heroId;
	}
}
