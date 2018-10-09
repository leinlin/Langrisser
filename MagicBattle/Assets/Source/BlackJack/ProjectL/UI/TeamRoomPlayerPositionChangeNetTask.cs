using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F67 RID: 3943
	[CustomLuaClass]
	public class TeamRoomPlayerPositionChangeNetTask : UINetTask
	{
		// Token: 0x06013969 RID: 80233 RVA: 0x004FE004 File Offset: 0x004FC204
		public TeamRoomPlayerPositionChangeNetTask(List<ProTeamRoomPlayerPositionInfo> positionInfos) : base(10f, null, true)
		{
			this.m_positionInfos = new List<ProTeamRoomPlayerPositionInfo>(positionInfos);
		}

		// Token: 0x0601396A RID: 80234 RVA: 0x004FE020 File Offset: 0x004FC220
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomPlayerPositionChangeAck += this.OnTeamRoomPlayerPositionChangeAck;
		}

		// Token: 0x0601396B RID: 80235 RVA: 0x004FE058 File Offset: 0x004FC258
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomPlayerPositionChangeAck -= this.OnTeamRoomPlayerPositionChangeAck;
			}
		}

		// Token: 0x0601396C RID: 80236 RVA: 0x004FE094 File Offset: 0x004FC294
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomPlayerPositionChangeReq(this.m_positionInfos);
		}

		// Token: 0x0601396D RID: 80237 RVA: 0x004FE0C4 File Offset: 0x004FC2C4
		protected void OnTeamRoomPlayerPositionChangeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADC6 RID: 44486
		private List<ProTeamRoomPlayerPositionInfo> m_positionInfos;
	}
}
