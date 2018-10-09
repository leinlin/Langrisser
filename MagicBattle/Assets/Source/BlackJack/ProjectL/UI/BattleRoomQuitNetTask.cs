using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A8B RID: 2699
	[CustomLuaClass]
	public class BattleRoomQuitNetTask : UINetTask
	{
		// Token: 0x0600AA20 RID: 43552 RVA: 0x002F6788 File Offset: 0x002F4988
		public BattleRoomQuitNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x002F6798 File Offset: 0x002F4998
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomQuitAck += this.OnBattleRoomQuitAck;
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x002F67D0 File Offset: 0x002F49D0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomQuitAck -= this.OnBattleRoomQuitAck;
			}
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x002F680C File Offset: 0x002F4A0C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomQuitReq();
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x002F6838 File Offset: 0x002F4A38
		protected void OnBattleRoomQuitAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
