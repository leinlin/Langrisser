using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA5 RID: 3237
	[CustomLuaClass]
	public class FriendGroupAllGetNetTask : UINetTask
	{
		// Token: 0x0600E8FB RID: 59643 RVA: 0x003E59CC File Offset: 0x003E3BCC
		public FriendGroupAllGetNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x003E59DC File Offset: 0x003E3BDC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGetAllChatGroupAck += this.OnGetAllChatGroupAck;
		}

		// Token: 0x0600E8FD RID: 59645 RVA: 0x003E5A14 File Offset: 0x003E3C14
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGetAllChatGroupAck -= this.OnGetAllChatGroupAck;
			}
		}

		// Token: 0x0600E8FE RID: 59646 RVA: 0x003E5A50 File Offset: 0x003E3C50
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetAllChatGroupReq();
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x003E5A7C File Offset: 0x003E3C7C
		protected void OnGetAllChatGroupAck(int result, List<ProChatGroupCompactInfo> chatGroupList)
		{
			base.Result = result;
			this.ChatGroupList = chatGroupList;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0600E901 RID: 59649 RVA: 0x003E5AA0 File Offset: 0x003E3CA0
		// (set) Token: 0x0600E900 RID: 59648 RVA: 0x003E5A94 File Offset: 0x003E3C94
		public List<ProChatGroupCompactInfo> ChatGroupList { get; private set; }
	}
}
