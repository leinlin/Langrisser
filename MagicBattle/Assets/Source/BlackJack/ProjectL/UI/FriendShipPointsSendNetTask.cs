using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA9 RID: 3241
	[CustomLuaClass]
	public class FriendShipPointsSendNetTask : UINetTask
	{
		// Token: 0x0600E915 RID: 59669 RVA: 0x003E5D68 File Offset: 0x003E3F68
		public FriendShipPointsSendNetTask(List<string> userIDList) : base(10f, null, true)
		{
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E916 RID: 59670 RVA: 0x003E5D84 File Offset: 0x003E3F84
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnFriendshipPointsSendAck += this.OnFriendshipPointsSendAck;
		}

		// Token: 0x0600E917 RID: 59671 RVA: 0x003E5DBC File Offset: 0x003E3FBC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnFriendshipPointsSendAck -= this.OnFriendshipPointsSendAck;
			}
		}

		// Token: 0x0600E918 RID: 59672 RVA: 0x003E5DF8 File Offset: 0x003E3FF8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendFriendshipPointsSendReq(this.m_userIDList);
		}

		// Token: 0x0600E919 RID: 59673 RVA: 0x003E5E28 File Offset: 0x003E4028
		protected void OnFriendshipPointsSendAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BF5 RID: 35829
		private List<string> m_userIDList;
	}
}
