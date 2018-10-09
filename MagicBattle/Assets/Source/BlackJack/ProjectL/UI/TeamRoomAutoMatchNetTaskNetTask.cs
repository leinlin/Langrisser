using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F5D RID: 3933
	[CustomLuaClass]
	public class TeamRoomAutoMatchNetTaskNetTask : UINetTask
	{
		// Token: 0x06013931 RID: 80177 RVA: 0x004FD780 File Offset: 0x004FB980
		public TeamRoomAutoMatchNetTaskNetTask(GameFunctionType gameFunctionTypeId, int locationId) : base(10f, null, true)
		{
			this.m_gameFunctionTypeId = gameFunctionTypeId;
			this.m_locationId = locationId;
		}

		// Token: 0x06013932 RID: 80178 RVA: 0x004FD7A0 File Offset: 0x004FB9A0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomAutoMatchAck += this.OnTeamRoomAutoMatchAck;
		}

		// Token: 0x06013933 RID: 80179 RVA: 0x004FD7D8 File Offset: 0x004FB9D8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomAutoMatchAck -= this.OnTeamRoomAutoMatchAck;
			}
		}

		// Token: 0x06013934 RID: 80180 RVA: 0x004FD814 File Offset: 0x004FBA14
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomAutoMatchReq(this.m_gameFunctionTypeId, this.m_locationId);
		}

		// Token: 0x06013935 RID: 80181 RVA: 0x004FD84C File Offset: 0x004FBA4C
		protected void OnTeamRoomAutoMatchAck(int result, int frontOfYouWaitingNums, bool isEnterRoom)
		{
			base.Result = result;
			this.FrontOfYouWaitingNums = frontOfYouWaitingNums;
			this.IsEnterRoom = isEnterRoom;
			this.OnTransactionComplete();
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x06013937 RID: 80183 RVA: 0x004FD878 File Offset: 0x004FBA78
		// (set) Token: 0x06013936 RID: 80182 RVA: 0x004FD86C File Offset: 0x004FBA6C
		public int FrontOfYouWaitingNums { get; private set; }

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x06013939 RID: 80185 RVA: 0x004FD88C File Offset: 0x004FBA8C
		// (set) Token: 0x06013938 RID: 80184 RVA: 0x004FD880 File Offset: 0x004FBA80
		public bool IsEnterRoom { get; private set; }

		// Token: 0x0400ADB8 RID: 44472
		private GameFunctionType m_gameFunctionTypeId;

		// Token: 0x0400ADB9 RID: 44473
		private int m_locationId;
	}
}
