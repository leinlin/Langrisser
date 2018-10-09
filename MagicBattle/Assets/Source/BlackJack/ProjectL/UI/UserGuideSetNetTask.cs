using System;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.PlayerContext;
using PD.SDK;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001006 RID: 4102
	[CustomLuaClass]
	public class UserGuideSetNetTask : UINetTask
	{
		// Token: 0x06014A9D RID: 84637 RVA: 0x0053C8A4 File Offset: 0x0053AAA4
		public UserGuideSetNetTask(int step) : base(10f, null, true)
		{
			this.m_step = step;
		}

		// Token: 0x06014A9E RID: 84638 RVA: 0x0053C8BC File Offset: 0x0053AABC
		public static UserGuideSetNetTask StartUserGuideSetNetTask(int step)
		{
			UserGuideSetNetTask userGuideSetNetTask = new UserGuideSetNetTask(step);
			userGuideSetNetTask.EventOnStop += delegate(Task task)
			{
				UserGuideSetNetTask userGuideSetNetTask2 = task as UserGuideSetNetTask;
				if (userGuideSetNetTask2.Result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(userGuideSetNetTask2.Result, 2f, null, true);
				}
			};
			userGuideSetNetTask.Start(null);
			PDSDK.Instance.printGameEventLog((1000 + step).ToString(), string.Empty);
			return userGuideSetNetTask;
		}

		// Token: 0x06014A9F RID: 84639 RVA: 0x0053C920 File Offset: 0x0053AB20
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnUserGuideSetAck += this.OnUserGuideSetAck;
		}

		// Token: 0x06014AA0 RID: 84640 RVA: 0x0053C958 File Offset: 0x0053AB58
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnUserGuideSetAck -= this.OnUserGuideSetAck;
			}
		}

		// Token: 0x06014AA1 RID: 84641 RVA: 0x0053C994 File Offset: 0x0053AB94
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendUserGuideSetReq(this.m_step);
		}

		// Token: 0x06014AA2 RID: 84642 RVA: 0x0053C9C4 File Offset: 0x0053ABC4
		protected void OnUserGuideSetAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
			if (UserGuideSetNetTask.m_completeEvent != null && result == 0)
			{
				UserGuideSetNetTask.m_completeEvent(this.m_step);
			}
		}

		// Token: 0x1400048D RID: 1165
		// (add) Token: 0x06014AA3 RID: 84643 RVA: 0x0053C9F4 File Offset: 0x0053ABF4
		// (remove) Token: 0x06014AA4 RID: 84644 RVA: 0x0053CA28 File Offset: 0x0053AC28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<int> m_completeEvent;

		// Token: 0x0400B54E RID: 46414
		private int m_step;
	}
}
