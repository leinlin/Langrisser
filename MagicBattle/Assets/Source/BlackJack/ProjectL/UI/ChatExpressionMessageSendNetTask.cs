using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B4D RID: 2893
	[CustomLuaClass]
	public class ChatExpressionMessageSendNetTask : UINetTask
	{
		// Token: 0x0600C4C7 RID: 50375 RVA: 0x00367318 File Offset: 0x00365518
		public ChatExpressionMessageSendNetTask(ChatChannel channel, string content) : base(10f, null, true)
		{
			this.m_channel = channel;
			this.m_content = content;
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x00367338 File Offset: 0x00365538
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendChatExpressionMessage(this.m_channel, this.m_content);
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x00367370 File Offset: 0x00365570
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatMessageAck += this.OnChatMessageAck;
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x003673A8 File Offset: 0x003655A8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatMessageAck -= this.OnChatMessageAck;
			}
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x003673E4 File Offset: 0x003655E4
		protected void OnChatMessageAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04007C97 RID: 31895
		private ChatChannel m_channel;

		// Token: 0x04007C98 RID: 31896
		private string m_content;
	}
}
