using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A8D RID: 2701
	[CustomLuaClass]
	public class BattleRoomGetNetTask : UINetTask
	{
		// Token: 0x0600AA2A RID: 43562 RVA: 0x002F6908 File Offset: 0x002F4B08
		public BattleRoomGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x002F6918 File Offset: 0x002F4B18
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomGetAck += this.OnBattleRoomGetAck;
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x002F6950 File Offset: 0x002F4B50
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomGetAck -= this.OnBattleRoomGetAck;
			}
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x002F698C File Offset: 0x002F4B8C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomGetReq();
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x002F69B8 File Offset: 0x002F4BB8
		protected void OnBattleRoomGetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
