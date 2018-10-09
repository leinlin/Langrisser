using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FC9 RID: 4041
	[CustomLuaClass]
	public class TreasureLevelUINetTask : UINetTask
	{
		// Token: 0x0601435B RID: 82779 RVA: 0x00524A08 File Offset: 0x00522C08
		public TreasureLevelUINetTask(int levelID) : base(10f, null, true)
		{
			this.m_levelID = levelID;
		}

		// Token: 0x0601435C RID: 82780 RVA: 0x00524A20 File Offset: 0x00522C20
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTreasureLevelAttackAck += this.OnTreasureLevelAttackAck;
		}

		// Token: 0x0601435D RID: 82781 RVA: 0x00524A58 File Offset: 0x00522C58
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTreasureLevelAttackAck -= this.OnTreasureLevelAttackAck;
			}
		}

		// Token: 0x0601435E RID: 82782 RVA: 0x00524A94 File Offset: 0x00522C94
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTreasureLevelAttackReq(this.m_levelID);
		}

		// Token: 0x0601435F RID: 82783 RVA: 0x00524AC4 File Offset: 0x00522CC4
		protected void OnTreasureLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400B26B RID: 45675
		private int m_levelID;
	}
}
