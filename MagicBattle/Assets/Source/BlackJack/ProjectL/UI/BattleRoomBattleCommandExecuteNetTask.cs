using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A8A RID: 2698
	[CustomLuaClass]
	public class BattleRoomBattleCommandExecuteNetTask : UINetTask
	{
		// Token: 0x0600AA1B RID: 43547 RVA: 0x002F66B8 File Offset: 0x002F48B8
		public BattleRoomBattleCommandExecuteNetTask(LinkedList<BattleCommand> commands) : base(10f, null, true)
		{
			this.m_commands = new List<BattleCommand>(commands);
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x002F66D4 File Offset: 0x002F48D4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomBattleCommandExecuteAck += this.OnBattleRoomBattleCommandExecuteAck;
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x002F670C File Offset: 0x002F490C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomBattleCommandExecuteAck -= this.OnBattleRoomBattleCommandExecuteAck;
			}
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x002F6748 File Offset: 0x002F4948
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomBattleCommandExecuteReq(this.m_commands);
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x002F6778 File Offset: 0x002F4978
		protected void OnBattleRoomBattleCommandExecuteAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD9 RID: 28633
		private List<BattleCommand> m_commands;
	}
}
