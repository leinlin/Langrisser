using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F62 RID: 3938
	[CustomLuaClass]
	public class TeamRoomGetNetTask : UINetTask
	{
		// Token: 0x0601394E RID: 80206 RVA: 0x004FDBD4 File Offset: 0x004FBDD4
		public TeamRoomGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0601394F RID: 80207 RVA: 0x004FDBE4 File Offset: 0x004FBDE4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomGetAck += this.OnTeamRoomGetAck;
		}

		// Token: 0x06013950 RID: 80208 RVA: 0x004FDC1C File Offset: 0x004FBE1C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomGetAck -= this.OnTeamRoomGetAck;
			}
		}

		// Token: 0x06013951 RID: 80209 RVA: 0x004FDC58 File Offset: 0x004FBE58
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomGetReq();
		}

		// Token: 0x06013952 RID: 80210 RVA: 0x004FDC84 File Offset: 0x004FBE84
		protected void OnTeamRoomGetAck(int result, int frontOfYouWaitingNums)
		{
			base.Result = result;
			this.FrontOfYouWaitingNums = frontOfYouWaitingNums;
			this.OnTransactionComplete();
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x06013954 RID: 80212 RVA: 0x004FDCA8 File Offset: 0x004FBEA8
		// (set) Token: 0x06013953 RID: 80211 RVA: 0x004FDC9C File Offset: 0x004FBE9C
		public int FrontOfYouWaitingNums { get; private set; }
	}
}
