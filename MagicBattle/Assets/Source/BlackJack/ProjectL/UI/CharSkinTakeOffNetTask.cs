using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DFB RID: 3579
	[CustomLuaClass]
	public class CharSkinTakeOffNetTask : UINetTask
	{
		// Token: 0x06011169 RID: 69993 RVA: 0x0046D55C File Offset: 0x0046B75C
		public CharSkinTakeOffNetTask(int heroId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
		}

		// Token: 0x0601116A RID: 69994 RVA: 0x0046D574 File Offset: 0x0046B774
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCharSkinTakeOffAck += this.OnCharSkinTakeOffAck;
		}

		// Token: 0x0601116B RID: 69995 RVA: 0x0046D5AC File Offset: 0x0046B7AC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCharSkinTakeOffAck -= this.OnCharSkinTakeOffAck;
			}
		}

		// Token: 0x0601116C RID: 69996 RVA: 0x0046D5E8 File Offset: 0x0046B7E8
		protected void OnCharSkinTakeOffAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601116D RID: 69997 RVA: 0x0046D5F8 File Offset: 0x0046B7F8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendCharSkinTakeOff(this.m_heroId);
		}

		// Token: 0x04009D1B RID: 40219
		private int m_heroId;
	}
}
