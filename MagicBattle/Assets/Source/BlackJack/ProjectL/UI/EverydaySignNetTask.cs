using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F0B RID: 3851
	[CustomLuaClass]
	public class EverydaySignNetTask : UINetTask
	{
		// Token: 0x0601315C RID: 78172 RVA: 0x004DE380 File Offset: 0x004DC580
		public EverydaySignNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0601315D RID: 78173 RVA: 0x004DE390 File Offset: 0x004DC590
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnEverydaySignAck += this.OnEverydaySignAck;
		}

		// Token: 0x0601315E RID: 78174 RVA: 0x004DE3C8 File Offset: 0x004DC5C8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnEverydaySignAck -= this.OnEverydaySignAck;
			}
		}

		// Token: 0x0601315F RID: 78175 RVA: 0x004DE404 File Offset: 0x004DC604
		protected void OnEverydaySignAck(int result, List<Goods> rewards)
		{
			base.Result = result;
			this.Rewards = rewards;
			this.OnTransactionComplete();
		}

		// Token: 0x06013160 RID: 78176 RVA: 0x004DE41C File Offset: 0x004DC61C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendEverydaySignReq();
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x06013162 RID: 78178 RVA: 0x004DE454 File Offset: 0x004DC654
		// (set) Token: 0x06013161 RID: 78177 RVA: 0x004DE448 File Offset: 0x004DC648
		public List<Goods> Rewards { get; private set; }
	}
}
