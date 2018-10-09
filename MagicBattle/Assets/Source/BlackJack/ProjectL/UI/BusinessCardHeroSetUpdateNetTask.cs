using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B20 RID: 2848
	[CustomLuaClass]
	public class BusinessCardHeroSetUpdateNetTask : UINetTask
	{
		// Token: 0x0600BFF7 RID: 49143 RVA: 0x00357E54 File Offset: 0x00356054
		public BusinessCardHeroSetUpdateNetTask(List<BusinessCardHeroSet> heroSetList) : base(10f, null, true)
		{
			this.m_heroSetList = new List<BusinessCardHeroSet>(heroSetList);
		}

		// Token: 0x0600BFF8 RID: 49144 RVA: 0x00357E70 File Offset: 0x00356070
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnBusinessCardHeroSetUpdateAck += this.OnBusinessCardHeroSetUpdateAck;
		}

		// Token: 0x0600BFF9 RID: 49145 RVA: 0x00357EA8 File Offset: 0x003560A8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnBusinessCardHeroSetUpdateAck -= this.OnBusinessCardHeroSetUpdateAck;
			}
		}

		// Token: 0x0600BFFA RID: 49146 RVA: 0x00357EE4 File Offset: 0x003560E4
		protected void OnBusinessCardHeroSetUpdateAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0600BFFB RID: 49147 RVA: 0x00357EF4 File Offset: 0x003560F4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendBusinessCardHeroSetUpdateReq(this.m_heroSetList);
		}

		// Token: 0x04007A89 RID: 31369
		private List<BusinessCardHeroSet> m_heroSetList;
	}
}
