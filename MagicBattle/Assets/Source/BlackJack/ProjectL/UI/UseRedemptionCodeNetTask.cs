using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E90 RID: 3728
	[CustomLuaClass]
	public class UseRedemptionCodeNetTask : UINetTask
	{
		// Token: 0x060122B3 RID: 74419 RVA: 0x004ACE70 File Offset: 0x004AB070
		public UseRedemptionCodeNetTask(string key) : base(10f, null, true)
		{
			this.m_key = key;
		}

		// Token: 0x060122B4 RID: 74420 RVA: 0x004ACE88 File Offset: 0x004AB088
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnExchangeGiftCDKeyAck += this.OnExchangeGiftCDKeyAck;
		}

		// Token: 0x060122B5 RID: 74421 RVA: 0x004ACEC0 File Offset: 0x004AB0C0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnExchangeGiftCDKeyAck -= this.OnExchangeGiftCDKeyAck;
		}

		// Token: 0x060122B6 RID: 74422 RVA: 0x004ACEF8 File Offset: 0x004AB0F8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendExchangeGiftCDKeyReq(this.m_key);
		}

		// Token: 0x060122B7 RID: 74423 RVA: 0x004ACF28 File Offset: 0x004AB128
		protected void OnExchangeGiftCDKeyAck(int result, int resultDetail)
		{
			base.Result = result;
			this.ResultDetail = resultDetail;
			this.OnTransactionComplete();
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x060122B9 RID: 74425 RVA: 0x004ACF4C File Offset: 0x004AB14C
		// (set) Token: 0x060122B8 RID: 74424 RVA: 0x004ACF40 File Offset: 0x004AB140
		public int ResultDetail { get; private set; }

		// Token: 0x0400A40B RID: 41995
		private string m_key;
	}
}
