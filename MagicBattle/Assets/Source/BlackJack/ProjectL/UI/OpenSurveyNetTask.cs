using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E91 RID: 3729
	[CustomLuaClass]
	public class OpenSurveyNetTask : UINetTask
	{
		// Token: 0x060122BA RID: 74426 RVA: 0x004ACF54 File Offset: 0x004AB154
		public OpenSurveyNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x060122BB RID: 74427 RVA: 0x004ACF64 File Offset: 0x004AB164
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnOpenSurveyAck += this.OnSendOpenSurveyAck;
		}

		// Token: 0x060122BC RID: 74428 RVA: 0x004ACF9C File Offset: 0x004AB19C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnOpenSurveyAck -= this.OnSendOpenSurveyAck;
		}

		// Token: 0x060122BD RID: 74429 RVA: 0x004ACFD4 File Offset: 0x004AB1D4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendOpenSurveyReq();
		}

		// Token: 0x060122BE RID: 74430 RVA: 0x004AD000 File Offset: 0x004AB200
		protected void OnSendOpenSurveyAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
