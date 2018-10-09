using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F5C RID: 3932
	[CustomLuaClass]
	public class TeamRoomViewNetTask : UINetTask
	{
		// Token: 0x0601392A RID: 80170 RVA: 0x004FD680 File Offset: 0x004FB880
		public TeamRoomViewNetTask(GameFunctionType gameFunctionTypeId, int chapterId, int locationId) : base(10f, null, true)
		{
			this.m_gameFunctionTypeId = gameFunctionTypeId;
			this.m_chapterId = chapterId;
			this.m_locationId = locationId;
		}

		// Token: 0x0601392B RID: 80171 RVA: 0x004FD6A4 File Offset: 0x004FB8A4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTeamRoomViewAck += this.OnTeamRoomViewAck;
		}

		// Token: 0x0601392C RID: 80172 RVA: 0x004FD6DC File Offset: 0x004FB8DC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTeamRoomViewAck -= this.OnTeamRoomViewAck;
			}
		}

		// Token: 0x0601392D RID: 80173 RVA: 0x004FD718 File Offset: 0x004FB918
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTeamRoomViewReq(this.m_gameFunctionTypeId, this.m_chapterId, this.m_locationId);
		}

		// Token: 0x0601392E RID: 80174 RVA: 0x004FD754 File Offset: 0x004FB954
		protected void OnTeamRoomViewAck(int result, List<TeamRoom> rooms)
		{
			base.Result = result;
			this.TeamRooms = rooms;
			this.OnTransactionComplete();
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x06013930 RID: 80176 RVA: 0x004FD778 File Offset: 0x004FB978
		// (set) Token: 0x0601392F RID: 80175 RVA: 0x004FD76C File Offset: 0x004FB96C
		public List<TeamRoom> TeamRooms { get; private set; }

		// Token: 0x0400ADB3 RID: 44467
		private GameFunctionType m_gameFunctionTypeId;

		// Token: 0x0400ADB4 RID: 44468
		private int m_chapterId;

		// Token: 0x0400ADB5 RID: 44469
		private int m_locationId;
	}
}
