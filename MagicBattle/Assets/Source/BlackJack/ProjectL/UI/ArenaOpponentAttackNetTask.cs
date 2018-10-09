using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A0E RID: 2574
	[CustomLuaClass]
	public class ArenaOpponentAttackNetTask : UINetTask
	{
		// Token: 0x06009B04 RID: 39684 RVA: 0x002C2F50 File Offset: 0x002C1150
		public ArenaOpponentAttackNetTask(bool autoBattle) : base(10f, null, true)
		{
			this.m_autoBattle = autoBattle;
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x002C2F68 File Offset: 0x002C1168
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaOpponentAttackAck += this.OnArenaOpponentAttackAck;
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x002C2FA0 File Offset: 0x002C11A0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaOpponentAttackAck -= this.OnArenaOpponentAttackAck;
			}
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x002C2FDC File Offset: 0x002C11DC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaOpponentAttackReq(this.m_autoBattle);
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x002C300C File Offset: 0x002C120C
		protected void OnArenaOpponentAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x040069BA RID: 27066
		private bool m_autoBattle;
	}
}
