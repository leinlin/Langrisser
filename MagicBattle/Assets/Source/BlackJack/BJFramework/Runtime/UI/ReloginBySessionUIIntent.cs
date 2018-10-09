using System;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000FA RID: 250
	public class ReloginBySessionUIIntent : UIIntent
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x0002AD14 File Offset: 0x00028F14
		public ReloginBySessionUIIntent(string targetTaskName, Action onReloginSuccess, string targetMode = "WaitForReloginConfirm") : base(targetTaskName, targetMode)
		{
			this.m_onReloginSuccessCallBack = onReloginSuccess;
		}

		// Token: 0x0400060B RID: 1547
		public Action m_onReloginSuccessCallBack;
	}
}
