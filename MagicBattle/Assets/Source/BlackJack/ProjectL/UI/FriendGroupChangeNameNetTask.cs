using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CA2 RID: 3234
	[CustomLuaClass]
	public class FriendGroupChangeNameNetTask : UINetTask
	{
		// Token: 0x0600E8E6 RID: 59622 RVA: 0x003E56F0 File Offset: 0x003E38F0
		public FriendGroupChangeNameNetTask(string chatGroupID, string newName) : base(10f, null, true)
		{
			this.m_chatGroupID = chatGroupID;
			this.m_newName = newName;
		}

		// Token: 0x0600E8E7 RID: 59623 RVA: 0x003E5710 File Offset: 0x003E3910
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatGroupChangeNameAck += this.OnChatGroupChangeNameAck;
		}

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x003E5748 File Offset: 0x003E3948
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatGroupChangeNameAck -= this.OnChatGroupChangeNameAck;
			}
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x003E5784 File Offset: 0x003E3984
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendChangeNameReq(this.m_chatGroupID, this.m_newName);
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x003E57BC File Offset: 0x003E39BC
		protected void OnChatGroupChangeNameAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04008BE5 RID: 35813
		private string m_chatGroupID;

		// Token: 0x04008BE6 RID: 35814
		private string m_newName;
	}
}
