using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A88 RID: 2696
	[CustomLuaClass]
	public class BattleRoomHeroBanNetTask : UINetTask
	{
		// Token: 0x0600AA11 RID: 43537 RVA: 0x002F652C File Offset: 0x002F472C
		public BattleRoomHeroBanNetTask(int position) : base(10f, null, true)
		{
			this.m_position = position;
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x002F6544 File Offset: 0x002F4744
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomHeroBanAck += this.OnBattleRoomHeroBanAck;
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x002F657C File Offset: 0x002F477C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomHeroBanAck -= this.OnBattleRoomHeroBanAck;
			}
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x002F65B8 File Offset: 0x002F47B8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomHeroBanReq(this.m_position);
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x002F65E8 File Offset: 0x002F47E8
		protected void OnBattleRoomHeroBanAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD8 RID: 28632
		private int m_position;
	}
}
