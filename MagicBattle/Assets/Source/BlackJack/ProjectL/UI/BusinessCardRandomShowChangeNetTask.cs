using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B1C RID: 2844
	[CustomLuaClass]
	public class BusinessCardRandomShowChangeNetTask : UINetTask
	{
		// Token: 0x0600BFE3 RID: 49123 RVA: 0x00357B24 File Offset: 0x00355D24
		public BusinessCardRandomShowChangeNetTask(bool isRandomShow) : base(10f, null, true)
		{
			this.m_isRandomShow = isRandomShow;
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x00357B3C File Offset: 0x00355D3C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBusinessCardRandomShowChangeAck += this.OnBusinessCardRandomShowChangeAck;
		}

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x00357B74 File Offset: 0x00355D74
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBusinessCardRandomShowChangeAck -= this.OnBusinessCardRandomShowChangeAck;
			}
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x00357BB0 File Offset: 0x00355DB0
		private void OnBusinessCardRandomShowChangeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x00357BC0 File Offset: 0x00355DC0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroRandomActionSetReq(this.m_isRandomShow);
		}

		// Token: 0x04007A85 RID: 31365
		private bool m_isRandomShow;
	}
}
