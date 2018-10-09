using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E8E RID: 3726
	[CustomLuaClass]
	public class ChangeHeadPortraitAndHeadFrameNetTask : UINetTask
	{
		// Token: 0x060122A9 RID: 74409 RVA: 0x004ACCC8 File Offset: 0x004AAEC8
		public ChangeHeadPortraitAndHeadFrameNetTask(int headPortraitId, int headFrameId) : base(10f, null, true)
		{
			this.m_headPortraitId = headPortraitId;
			this.m_headFrameId = headFrameId;
		}

		// Token: 0x060122AA RID: 74410 RVA: 0x004ACCE8 File Offset: 0x004AAEE8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeadPortraitAndHeadFrameSetAck += this.OnHeadPortraitAndHeadFrameSetAck;
		}

		// Token: 0x060122AB RID: 74411 RVA: 0x004ACD20 File Offset: 0x004AAF20
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeadPortraitAndHeadFrameSetAck -= this.OnHeadPortraitAndHeadFrameSetAck;
			}
		}

		// Token: 0x060122AC RID: 74412 RVA: 0x004ACD5C File Offset: 0x004AAF5C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeadPortraitAndHeadFrameSetReq(this.m_headPortraitId, this.m_headFrameId);
		}

		// Token: 0x060122AD RID: 74413 RVA: 0x004ACD94 File Offset: 0x004AAF94
		protected void OnHeadPortraitAndHeadFrameSetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400A408 RID: 41992
		private int m_headPortraitId;

		// Token: 0x0400A409 RID: 41993
		private int m_headFrameId;
	}
}
