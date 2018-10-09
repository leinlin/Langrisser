using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A89 RID: 2697
	[CustomLuaClass]
	public class BattleRoomEndCurrentBPTurnNetTask : UINetTask
	{
		// Token: 0x0600AA16 RID: 43542 RVA: 0x002F65F8 File Offset: 0x002F47F8
		public BattleRoomEndCurrentBPTurnNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x002F6608 File Offset: 0x002F4808
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomEndCurrentBPTurnAck += this.OnBattleRoomEndCurrentBPTurnAck;
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x002F6640 File Offset: 0x002F4840
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomEndCurrentBPTurnAck -= this.OnBattleRoomEndCurrentBPTurnAck;
			}
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x002F667C File Offset: 0x002F487C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomEndCurrentBPTurnReq();
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x002F66A8 File Offset: 0x002F48A8
		protected void OnBattleRoomEndCurrentBPTurnAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
