using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B50 RID: 2896
	[CustomLuaClass]
	public class FriendGetUserSummaryReqNetTask : UINetTask
	{
		// Token: 0x0600C4D7 RID: 50391 RVA: 0x003675A8 File Offset: 0x003657A8
		public FriendGetUserSummaryReqNetTask(List<string> playerIdList) : base(10f, null, true)
		{
			this.m_playerIdList = new List<string>(playerIdList);
		}

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x003675C4 File Offset: 0x003657C4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetUserSummaryAck += this.OnGetUserSummaryAck;
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x003675FC File Offset: 0x003657FC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGetUserSummaryAck -= this.OnGetUserSummaryAck;
			}
		}

		// Token: 0x0600C4DA RID: 50394 RVA: 0x00367638 File Offset: 0x00365838
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.GetGuildMemberSummary(this.m_playerIdList);
		}

		// Token: 0x0600C4DB RID: 50395 RVA: 0x0036766C File Offset: 0x0036586C
		private void OnGetUserSummaryAck(int result, List<UserSummary> players)
		{
			base.Result = result;
			this.Players = players;
			this.OnTransactionComplete();
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x0600C4DC RID: 50396 RVA: 0x00367684 File Offset: 0x00365884
		// (set) Token: 0x0600C4DD RID: 50397 RVA: 0x0036768C File Offset: 0x0036588C
		public List<UserSummary> Players { get; private set; }

		// Token: 0x04007C9C RID: 31900
		private List<string> m_playerIdList;
	}
}
