using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A1D RID: 2589
	[CustomLuaClass]
	public class RealTimePVPGetTopPlayersNetTask : UINetTask
	{
		// Token: 0x06009B63 RID: 39779 RVA: 0x002C3D24 File Offset: 0x002C1F24
		public RealTimePVPGetTopPlayersNetTask(int topN, bool isGlobal) : base(10f, null, true)
		{
			this.m_topN = topN;
			this.m_isGlobal = isGlobal;
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x002C3D44 File Offset: 0x002C1F44
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnRealTimePVPGetTopPlayersAck += this.OnRealTimePVPGetTopPlayersAck;
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x002C3D7C File Offset: 0x002C1F7C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnRealTimePVPGetTopPlayersAck -= this.OnRealTimePVPGetTopPlayersAck;
			}
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x002C3DB8 File Offset: 0x002C1FB8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendRealTimePVPGetTopPlayersReq(this.m_topN, this.m_isGlobal);
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x002C3DF0 File Offset: 0x002C1FF0
		protected void OnRealTimePVPGetTopPlayersAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x040069CC RID: 27084
		private int m_topN;

		// Token: 0x040069CD RID: 27085
		private bool m_isGlobal;
	}
}
