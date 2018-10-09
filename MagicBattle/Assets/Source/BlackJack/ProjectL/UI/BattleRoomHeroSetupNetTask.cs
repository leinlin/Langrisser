using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A84 RID: 2692
	[CustomLuaClass]
	public class BattleRoomHeroSetupNetTask : UINetTask
	{
		// Token: 0x0600A9FD RID: 43517 RVA: 0x002F61DC File Offset: 0x002F43DC
		public BattleRoomHeroSetupNetTask(int heroId, int position) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_position = position;
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x002F61FC File Offset: 0x002F43FC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomHeroSetupAck += this.OnBattleRoomHeroSetupAck;
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x002F6234 File Offset: 0x002F4434
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomHeroSetupAck -= this.OnBattleRoomHeroSetupAck;
			}
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x002F6270 File Offset: 0x002F4470
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomHeroSetupReq(this.m_heroId, this.m_position);
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x002F62A8 File Offset: 0x002F44A8
		protected void OnBattleRoomHeroSetupAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD2 RID: 28626
		private int m_heroId;

		// Token: 0x04006FD3 RID: 28627
		private int m_position;
	}
}
