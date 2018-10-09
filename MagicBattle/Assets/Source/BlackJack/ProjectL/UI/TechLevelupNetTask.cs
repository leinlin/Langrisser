using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C3C RID: 3132
	[CustomLuaClass]
	public class TechLevelupNetTask : UINetTask
	{
		// Token: 0x0600DC1D RID: 56349 RVA: 0x003BA5D0 File Offset: 0x003B87D0
		public TechLevelupNetTask(int techId) : base(10f, null, true)
		{
			this.m_techId = techId;
		}

		// Token: 0x0600DC1E RID: 56350 RVA: 0x003BA5E8 File Offset: 0x003B87E8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnTrainingGroundTechLevelupAck += this.OnTrainingGroundTechLevelupAck;
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x003BA620 File Offset: 0x003B8820
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnTrainingGroundTechLevelupAck -= this.OnTrainingGroundTechLevelupAck;
			}
		}

		// Token: 0x0600DC20 RID: 56352 RVA: 0x003BA65C File Offset: 0x003B885C
		protected void OnTrainingGroundTechLevelupAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600DC21 RID: 56353 RVA: 0x003BA66C File Offset: 0x003B886C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendTechLevelupReq(this.m_techId, 1);
		}

		// Token: 0x040086A6 RID: 34470
		private int m_techId;
	}
}
