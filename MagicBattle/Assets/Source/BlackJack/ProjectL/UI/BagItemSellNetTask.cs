using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A58 RID: 2648
	[CustomLuaClass]
	public class BagItemSellNetTask : UINetTask
	{
		// Token: 0x0600A503 RID: 42243 RVA: 0x002E6CA0 File Offset: 0x002E4EA0
		public BagItemSellNetTask(ulong instanceId, int count) : base(10f, null, true)
		{
			this.m_instanceId = instanceId;
			this.m_count = count;
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x002E6CC0 File Offset: 0x002E4EC0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnSellBagItemAck += this.OnSellBagItemAck;
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x002E6CF8 File Offset: 0x002E4EF8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnSellBagItemAck -= this.OnSellBagItemAck;
			}
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x002E6D34 File Offset: 0x002E4F34
		protected void OnSellBagItemAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x002E6D44 File Offset: 0x002E4F44
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendSellBagItemReq(this.m_instanceId, this.m_count);
		}

		// Token: 0x04006DE8 RID: 28136
		private ulong m_instanceId;

		// Token: 0x04006DE9 RID: 28137
		private int m_count;
	}
}
