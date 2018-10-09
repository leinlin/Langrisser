using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DFD RID: 3581
	[CustomLuaClass]
	public class ModelSkinTakeOffNetTask : UINetTask
	{
		// Token: 0x06011173 RID: 70003 RVA: 0x0046D70C File Offset: 0x0046B90C
		public ModelSkinTakeOffNetTask(int heroId, int jobRelatedId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_jobRelatedId = jobRelatedId;
		}

		// Token: 0x06011174 RID: 70004 RVA: 0x0046D72C File Offset: 0x0046B92C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnModelSkinTakeOffAck += this.OnModelSkinTakeOffAck;
		}

		// Token: 0x06011175 RID: 70005 RVA: 0x0046D764 File Offset: 0x0046B964
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnModelSkinTakeOffAck -= this.OnModelSkinTakeOffAck;
			}
		}

		// Token: 0x06011176 RID: 70006 RVA: 0x0046D7A0 File Offset: 0x0046B9A0
		protected void OnModelSkinTakeOffAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011177 RID: 70007 RVA: 0x0046D7B0 File Offset: 0x0046B9B0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendModelSkinTakeOff(this.m_heroId, this.m_jobRelatedId);
		}

		// Token: 0x04009D1F RID: 40223
		private int m_heroId;

		// Token: 0x04009D20 RID: 40224
		private int m_jobRelatedId;
	}
}
