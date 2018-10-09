using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DFA RID: 3578
	[CustomLuaClass]
	public class CharSkinWearNetTask : UINetTask
	{
		// Token: 0x06011164 RID: 69988 RVA: 0x0046D480 File Offset: 0x0046B680
		public CharSkinWearNetTask(int heroId, int charSkinId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_charSkinid = charSkinId;
		}

		// Token: 0x06011165 RID: 69989 RVA: 0x0046D4A0 File Offset: 0x0046B6A0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCharSkinWearAck += this.OnCharSkinWearAck;
		}

		// Token: 0x06011166 RID: 69990 RVA: 0x0046D4D8 File Offset: 0x0046B6D8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCharSkinWearAck -= this.OnCharSkinWearAck;
			}
		}

		// Token: 0x06011167 RID: 69991 RVA: 0x0046D514 File Offset: 0x0046B714
		protected void OnCharSkinWearAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x06011168 RID: 69992 RVA: 0x0046D524 File Offset: 0x0046B724
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendCharSkinWear(this.m_heroId, this.m_charSkinid);
		}

		// Token: 0x04009D19 RID: 40217
		private int m_heroId;

		// Token: 0x04009D1A RID: 40218
		private int m_charSkinid;
	}
}
