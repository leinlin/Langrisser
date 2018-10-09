using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DFC RID: 3580
	[CustomLuaClass]
	public class ModelSkinWearNetTask : UINetTask
	{
		// Token: 0x0601116E RID: 69998 RVA: 0x0046D628 File Offset: 0x0046B828
		public ModelSkinWearNetTask(int heroId, int jobRelatedId, int modelSkinId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_jobRelatedId = jobRelatedId;
			this.m_modelSkinId = modelSkinId;
		}

		// Token: 0x0601116F RID: 69999 RVA: 0x0046D64C File Offset: 0x0046B84C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnModelSkinWearAck += this.OnModelSkinWearAck;
		}

		// Token: 0x06011170 RID: 70000 RVA: 0x0046D684 File Offset: 0x0046B884
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnModelSkinWearAck -= this.OnModelSkinWearAck;
			}
		}

		// Token: 0x06011171 RID: 70001 RVA: 0x0046D6C0 File Offset: 0x0046B8C0
		protected void OnModelSkinWearAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011172 RID: 70002 RVA: 0x0046D6D0 File Offset: 0x0046B8D0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendModelSkinWear(this.m_heroId, this.m_jobRelatedId, this.m_modelSkinId);
		}

		// Token: 0x04009D1C RID: 40220
		private int m_heroId;

		// Token: 0x04009D1D RID: 40221
		private int m_jobRelatedId;

		// Token: 0x04009D1E RID: 40222
		private int m_modelSkinId;
	}
}
