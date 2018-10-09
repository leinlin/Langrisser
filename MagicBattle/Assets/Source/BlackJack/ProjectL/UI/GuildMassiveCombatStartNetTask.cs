using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D3E RID: 3390
	[CustomLuaClass]
	public class GuildMassiveCombatStartNetTask : UINetTask
	{
		// Token: 0x0600F8AD RID: 63661 RVA: 0x00419064 File Offset: 0x00417264
		public GuildMassiveCombatStartNetTask(int difficulty) : base(10f, null, true)
		{
			this.m_difficulty = difficulty;
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x0041907C File Offset: 0x0041727C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildMassiveCombatStartAck += this.OnGuildMassiveCombatStartAck;
		}

		// Token: 0x0600F8AF RID: 63663 RVA: 0x004190B4 File Offset: 0x004172B4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildMassiveCombatStartAck -= this.OnGuildMassiveCombatStartAck;
			}
		}

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x004190F0 File Offset: 0x004172F0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildMassiveCombatStartReq(this.m_difficulty);
		}

		// Token: 0x0600F8B1 RID: 63665 RVA: 0x00419120 File Offset: 0x00417320
		protected void OnGuildMassiveCombatStartAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400924A RID: 37450
		private int m_difficulty;
	}
}
