using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F5B RID: 3931
	[CustomLuaClass]
	public class TeamRoomCreateNetTask : UINetTask
	{
		// Token: 0x06013925 RID: 80165 RVA: 0x004FD5B4 File Offset: 0x004FB7B4
		public TeamRoomCreateNetTask(TeamRoomSetting setting) : base(10f, null, true)
		{
			this.m_setting = setting;
		}

		// Token: 0x06013926 RID: 80166 RVA: 0x004FD5CC File Offset: 0x004FB7CC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomCreateAck += this.OnTeamRoomCreateAck;
		}

		// Token: 0x06013927 RID: 80167 RVA: 0x004FD604 File Offset: 0x004FB804
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomCreateAck -= this.OnTeamRoomCreateAck;
			}
		}

		// Token: 0x06013928 RID: 80168 RVA: 0x004FD640 File Offset: 0x004FB840
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomCreateReq(this.m_setting);
		}

		// Token: 0x06013929 RID: 80169 RVA: 0x004FD670 File Offset: 0x004FB870
		protected void OnTeamRoomCreateAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400ADB1 RID: 44465
		private TeamRoomSetting m_setting;
	}
}
