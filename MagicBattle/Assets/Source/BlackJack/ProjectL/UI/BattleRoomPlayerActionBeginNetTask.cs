using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A8C RID: 2700
	[CustomLuaClass]
	public class BattleRoomPlayerActionBeginNetTask : UINetTask
	{
		// Token: 0x0600AA25 RID: 43557 RVA: 0x002F6848 File Offset: 0x002F4A48
		public BattleRoomPlayerActionBeginNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x002F6858 File Offset: 0x002F4A58
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomPlayerActionBeginAck += this.OnBattleRoomPlayerActionBeginAck;
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x002F6890 File Offset: 0x002F4A90
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomPlayerActionBeginAck -= this.OnBattleRoomPlayerActionBeginAck;
			}
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x002F68CC File Offset: 0x002F4ACC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomPlayerActionBeginReq();
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x002F68F8 File Offset: 0x002F4AF8
		protected void OnBattleRoomPlayerActionBeginAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
