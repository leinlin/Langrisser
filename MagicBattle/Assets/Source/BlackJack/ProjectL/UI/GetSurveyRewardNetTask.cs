using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E92 RID: 3730
	[CustomLuaClass]
	public class GetSurveyRewardNetTask : UINetTask
	{
		// Token: 0x060122BF RID: 74431 RVA: 0x004AD010 File Offset: 0x004AB210
		public GetSurveyRewardNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x060122C0 RID: 74432 RVA: 0x004AD020 File Offset: 0x004AB220
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetSurveyRewardAck += this.OnGetSurveyRewardAck;
		}

		// Token: 0x060122C1 RID: 74433 RVA: 0x004AD058 File Offset: 0x004AB258
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetSurveyRewardAck -= this.OnGetSurveyRewardAck;
		}

		// Token: 0x060122C2 RID: 74434 RVA: 0x004AD090 File Offset: 0x004AB290
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetSurveyRewardReq();
		}

		// Token: 0x060122C3 RID: 74435 RVA: 0x004AD0BC File Offset: 0x004AB2BC
		protected void OnGetSurveyRewardAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
