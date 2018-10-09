using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D3F RID: 3391
	[CustomLuaClass]
	public class GuildMassiveCombatSurrenderNetTask : UINetTask
	{
		// Token: 0x0600F8B2 RID: 63666 RVA: 0x00419130 File Offset: 0x00417330
		public GuildMassiveCombatSurrenderNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x00419140 File Offset: 0x00417340
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildMassiveCombatSurrenderAck += this.OnGuildMassiveCombatSurrenderAck;
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x00419178 File Offset: 0x00417378
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildMassiveCombatSurrenderAck -= this.OnGuildMassiveCombatSurrenderAck;
			}
		}

		// Token: 0x0600F8B5 RID: 63669 RVA: 0x004191B4 File Offset: 0x004173B4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildMassiveCombatSurrenderReq();
		}

		// Token: 0x0600F8B6 RID: 63670 RVA: 0x004191E0 File Offset: 0x004173E0
		protected void OnGuildMassiveCombatSurrenderAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
