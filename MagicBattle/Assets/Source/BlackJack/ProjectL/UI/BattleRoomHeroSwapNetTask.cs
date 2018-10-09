using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A85 RID: 2693
	[CustomLuaClass]
	public class BattleRoomHeroSwapNetTask : UINetTask
	{
		// Token: 0x0600AA02 RID: 43522 RVA: 0x002F62B8 File Offset: 0x002F44B8
		public BattleRoomHeroSwapNetTask(int fromPosition, int toPosition) : base(10f, null, true)
		{
			this.m_fromPosition = fromPosition;
			this.m_toPosition = toPosition;
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x002F62D8 File Offset: 0x002F44D8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomHeroSwapAck += this.OnBattleRoomHeroSwapAck;
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x002F6310 File Offset: 0x002F4510
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomHeroSwapAck -= this.OnBattleRoomHeroSwapAck;
			}
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x002F634C File Offset: 0x002F454C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomHeroSwapReq(this.m_fromPosition, this.m_toPosition);
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x002F6384 File Offset: 0x002F4584
		protected void OnBattleRoomHeroSwapAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD4 RID: 28628
		private int m_fromPosition;

		// Token: 0x04006FD5 RID: 28629
		private int m_toPosition;
	}
}
