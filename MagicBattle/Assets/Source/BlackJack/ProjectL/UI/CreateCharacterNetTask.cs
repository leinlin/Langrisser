using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E36 RID: 3638
	[CustomLuaClass]
	public class CreateCharacterNetTask : NetWorkTransactionTask
	{
		// Token: 0x0601197A RID: 72058 RVA: 0x0048CEC8 File Offset: 0x0048B0C8
		public CreateCharacterNetTask(string charactorName) : base(10f, null, false)
		{
			this.m_charactorName = charactorName;
			this.Result = -99;
		}

		// Token: 0x0601197B RID: 72059 RVA: 0x0048CEE8 File Offset: 0x0048B0E8
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCreateCharactorAck += this.OnCreateCharactorAck;
		}

		// Token: 0x0601197C RID: 72060 RVA: 0x0048CF20 File Offset: 0x0048B120
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCreateCharactorAck -= this.OnCreateCharactorAck;
			}
		}

		// Token: 0x0601197D RID: 72061 RVA: 0x0048CF5C File Offset: 0x0048B15C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendCreateCharactorReq(this.m_charactorName);
		}

		// Token: 0x0601197E RID: 72062 RVA: 0x0048CF8C File Offset: 0x0048B18C
		protected void OnCreateCharactorAck(int result)
		{
			this.Result = result;
			base.Stop();
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x06011980 RID: 72064 RVA: 0x0048CFA8 File Offset: 0x0048B1A8
		// (set) Token: 0x0601197F RID: 72063 RVA: 0x0048CF9C File Offset: 0x0048B19C
		public int Result { get; protected set; }

		// Token: 0x0400A041 RID: 41025
		private string m_charactorName;
	}
}
