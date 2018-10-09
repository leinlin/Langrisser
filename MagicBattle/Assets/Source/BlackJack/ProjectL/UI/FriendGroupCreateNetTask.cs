using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA3 RID: 3235
	[CustomLuaClass]
	public class FriendGroupCreateNetTask : UINetTask
	{
		// Token: 0x0600E8EB RID: 59627 RVA: 0x003E57CC File Offset: 0x003E39CC
		public FriendGroupCreateNetTask(string groupName, List<string> userIDList) : base(10f, null, true)
		{
			this.m_groupNmae = groupName;
			this.m_userIDList = new List<string>(userIDList);
		}

		// Token: 0x0600E8EC RID: 59628 RVA: 0x003E57F0 File Offset: 0x003E39F0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnCreateChatGroupAck += this.OnFriendGroupCreateAck;
		}

		// Token: 0x0600E8ED RID: 59629 RVA: 0x003E5828 File Offset: 0x003E3A28
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnCreateChatGroupAck -= this.OnFriendGroupCreateAck;
			}
		}

		// Token: 0x0600E8EE RID: 59630 RVA: 0x003E5864 File Offset: 0x003E3A64
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendCreateChatGroupReq(this.m_groupNmae, this.m_userIDList);
		}

		// Token: 0x0600E8EF RID: 59631 RVA: 0x003E589C File Offset: 0x003E3A9C
		protected void OnFriendGroupCreateAck(int result, ProChatGroupInfo chatGroupInfo, ProChatUserInfo userInfo)
		{
			base.Result = result;
			this.ChatGroupInfo = chatGroupInfo;
			this.FailedUser = userInfo;
			this.OnTransactionComplete();
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600E8F1 RID: 59633 RVA: 0x003E58C8 File Offset: 0x003E3AC8
		// (set) Token: 0x0600E8F0 RID: 59632 RVA: 0x003E58BC File Offset: 0x003E3ABC
		public ProChatGroupInfo ChatGroupInfo { get; private set; }

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600E8F3 RID: 59635 RVA: 0x003E58DC File Offset: 0x003E3ADC
		// (set) Token: 0x0600E8F2 RID: 59634 RVA: 0x003E58D0 File Offset: 0x003E3AD0
		public ProChatUserInfo FailedUser { get; private set; }

		// Token: 0x04008BE9 RID: 35817
		private string m_groupNmae;

		// Token: 0x04008BEA RID: 35818
		private List<string> m_userIDList;
	}
}
