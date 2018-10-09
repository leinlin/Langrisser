using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A87 RID: 2695
	[CustomLuaClass]
	public class BattleRoomHeroProtectNetTask : UINetTask
	{
		// Token: 0x0600AA0C RID: 43532 RVA: 0x002F6460 File Offset: 0x002F4660
		public BattleRoomHeroProtectNetTask(int position) : base(10f, null, true)
		{
			this.m_position = position;
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x002F6478 File Offset: 0x002F4678
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomHeroProtectAck += this.OnBattleRoomHeroProtectAck;
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x002F64B0 File Offset: 0x002F46B0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomHeroProtectAck -= this.OnBattleRoomHeroProtectAck;
			}
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x002F64EC File Offset: 0x002F46EC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomHeroProtectReq(this.m_position);
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x002F651C File Offset: 0x002F471C
		protected void OnBattleRoomHeroProtectAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD7 RID: 28631
		private int m_position;
	}
}
