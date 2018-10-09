using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A16 RID: 2582
	[CustomLuaClass]
	public class ArenaBattleReportPlayBackDataGetNetTask : UINetTask
	{
		// Token: 0x06009B3E RID: 39742 RVA: 0x002C37B0 File Offset: 0x002C19B0
		public ArenaBattleReportPlayBackDataGetNetTask(ulong arenaBattleReportInstanceId) : base(10f, null, true)
		{
			this.m_arenaBattleReportInstanceId = arenaBattleReportInstanceId;
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x002C37C8 File Offset: 0x002C19C8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaBattleReportPlayBackDataGetAck += this.OnArenaBattleReportPlayBackDataGetAck;
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x002C3800 File Offset: 0x002C1A00
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaBattleReportPlayBackDataGetAck -= this.OnArenaBattleReportPlayBackDataGetAck;
			}
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x002C383C File Offset: 0x002C1A3C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaBattleReportPlayBackDataGetReq(this.m_arenaBattleReportInstanceId);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x002C386C File Offset: 0x002C1A6C
		protected void OnArenaBattleReportPlayBackDataGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x040069C9 RID: 27081
		private ulong m_arenaBattleReportInstanceId;
	}
}
