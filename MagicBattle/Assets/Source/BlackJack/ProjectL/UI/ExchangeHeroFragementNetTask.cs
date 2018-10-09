using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F2F RID: 3887
	[CustomLuaClass]
	public class ExchangeHeroFragementNetTask : UINetTask
	{
		// Token: 0x06013658 RID: 79448 RVA: 0x004F1C3C File Offset: 0x004EFE3C
		public ExchangeHeroFragementNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06013659 RID: 79449 RVA: 0x004F1C4C File Offset: 0x004EFE4C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnExchangeHeroFragementAck += this.OnExchangeHeroFragementAck;
		}

		// Token: 0x0601365A RID: 79450 RVA: 0x004F1C84 File Offset: 0x004EFE84
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnExchangeHeroFragementAck -= this.OnExchangeHeroFragementAck;
			}
		}

		// Token: 0x0601365B RID: 79451 RVA: 0x004F1CC0 File Offset: 0x004EFEC0
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendExchangeHeroFragmentReq();
		}

		// Token: 0x0601365C RID: 79452 RVA: 0x004F1CEC File Offset: 0x004EFEEC
		protected void OnExchangeHeroFragementAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x0601365D RID: 79453 RVA: 0x004F1D04 File Offset: 0x004EFF04
		// (set) Token: 0x0601365E RID: 79454 RVA: 0x004F1D0C File Offset: 0x004EFF0C
		public List<Goods> Rewards { get; private set; }
	}
}
