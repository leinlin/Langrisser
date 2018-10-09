using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A15 RID: 2581
	[CustomLuaClass]
	public class ArenaBattleReportBasicDataGetNetTask : UINetTask
	{
		// Token: 0x06009B39 RID: 39737 RVA: 0x002C36F0 File Offset: 0x002C18F0
		public ArenaBattleReportBasicDataGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x002C3700 File Offset: 0x002C1900
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaBattleReportBasicDataGetAck += this.OnArenaBattleReportBasicDataGetAck;
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x002C3738 File Offset: 0x002C1938
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaBattleReportBasicDataGetAck -= this.OnArenaBattleReportBasicDataGetAck;
			}
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x002C3774 File Offset: 0x002C1974
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaBattleReportBaiscDataGetReq();
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x002C37A0 File Offset: 0x002C19A0
		protected void OnArenaBattleReportBasicDataGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
