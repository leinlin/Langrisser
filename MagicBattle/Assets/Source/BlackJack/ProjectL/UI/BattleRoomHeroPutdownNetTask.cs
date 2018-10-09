using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A86 RID: 2694
	[CustomLuaClass]
	public class BattleRoomHeroPutdownNetTask : UINetTask
	{
		// Token: 0x0600AA07 RID: 43527 RVA: 0x002F6394 File Offset: 0x002F4594
		public BattleRoomHeroPutdownNetTask(int position) : base(10f, null, true)
		{
			this.m_position = position;
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x002F63AC File Offset: 0x002F45AC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBattleRoomHeroPutdownAck += this.OnBattleRoomHeroPutdownAck;
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x002F63E4 File Offset: 0x002F45E4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBattleRoomHeroPutdownAck -= this.OnBattleRoomHeroPutdownAck;
			}
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x002F6420 File Offset: 0x002F4620
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBattleRoomHeroPutdownReq(this.m_position);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x002F6450 File Offset: 0x002F4650
		protected void OnBattleRoomHeroPutdownAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FD6 RID: 28630
		private int m_position;
	}
}
