using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F65 RID: 3941
	[CustomLuaClass]
	public class TeamBattleRoomCreateNetTask : UINetTask
	{
		// Token: 0x0601395F RID: 80223 RVA: 0x004FDE64 File Offset: 0x004FC064
		public TeamBattleRoomCreateNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06013960 RID: 80224 RVA: 0x004FDE74 File Offset: 0x004FC074
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomCreateAck += this.OnBattleRoomCreateAck;
		}

		// Token: 0x06013961 RID: 80225 RVA: 0x004FDEAC File Offset: 0x004FC0AC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomCreateAck -= this.OnBattleRoomCreateAck;
			}
		}

		// Token: 0x06013962 RID: 80226 RVA: 0x004FDEE8 File Offset: 0x004FC0E8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamBattleRoomCreateReq();
		}

		// Token: 0x06013963 RID: 80227 RVA: 0x004FDF14 File Offset: 0x004FC114
		protected void OnBattleRoomCreateAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
