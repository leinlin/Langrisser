using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A83 RID: 2691
	[CustomLuaClass]
	public class BattleRoomPlayerStatusChangeNetTask : UINetTask
	{
		// Token: 0x0600A9F8 RID: 43512 RVA: 0x002F6108 File Offset: 0x002F4308
		public BattleRoomPlayerStatusChangeNetTask(PlayerBattleStatus status) : base(10f, null, true)
		{
			this.m_autoRetry = true;
			this.m_status = status;
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x002F6128 File Offset: 0x002F4328
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomPlayerStatusChangeAck += this.OnBattleRoomPlayerStatusChangeAck;
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x002F6160 File Offset: 0x002F4360
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomPlayerStatusChangeAck -= this.OnBattleRoomPlayerStatusChangeAck;
			}
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x002F619C File Offset: 0x002F439C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomPlayerStatusChangeReq(this.m_status);
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x002F61CC File Offset: 0x002F43CC
		protected void OnBattleRoomPlayerStatusChangeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD1 RID: 28625
		private PlayerBattleStatus m_status;
	}
}
