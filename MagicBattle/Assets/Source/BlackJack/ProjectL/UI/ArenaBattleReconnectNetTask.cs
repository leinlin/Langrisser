using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A19 RID: 2585
	[CustomLuaClass]
	public class ArenaBattleReconnectNetTask : UINetTask
	{
		// Token: 0x06009B4D RID: 39757 RVA: 0x002C39FC File Offset: 0x002C1BFC
		public ArenaBattleReconnectNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x002C3A0C File Offset: 0x002C1C0C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaBattleReconnectAck += this.OnArenaBattleReconnectAck;
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x002C3A44 File Offset: 0x002C1C44
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaBattleReconnectAck -= this.OnArenaBattleReconnectAck;
			}
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x002C3A80 File Offset: 0x002C1C80
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaBattleReconnectReq();
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x002C3AAC File Offset: 0x002C1CAC
		protected void OnArenaBattleReconnectAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
