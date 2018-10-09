using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B4C RID: 2892
	[CustomLuaClass]
	public class ChatMessageSendNetTask : UINetTask
	{
		// Token: 0x0600C4C1 RID: 50369 RVA: 0x003671B0 File Offset: 0x003653B0
		public ChatMessageSendNetTask(ChatChannel channel, string content) : base(10f, null, true)
		{
			this.m_channel = channel;
			this.m_content = content;
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x003671D0 File Offset: 0x003653D0
		public ChatMessageSendNetTask(ChatChannel channel, byte[] voiceBytes, int length, int frequency, int samples, string translateText, string userID) : base(10f, null, true)
		{
			this.m_channel = channel;
			this.m_translateText = translateText;
			this.m_voiceBytes = voiceBytes;
			this.m_length = length;
			this.m_frequency = frequency;
			this.m_samples = samples;
			this.m_userID = userID;
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x00367220 File Offset: 0x00365420
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_voiceBytes == null)
			{
				return projectLPlayerContext.SendChatTextMessage(this.m_channel, this.m_content);
			}
			return projectLPlayerContext.SendChatVoiceMessage(this.m_channel, this.m_voiceBytes, this.m_length, this.m_frequency, this.m_samples, this.m_translateText, this.m_userID);
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00367294 File Offset: 0x00365494
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatMessageAck += this.OnChatMessageAck;
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x003672CC File Offset: 0x003654CC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatMessageAck -= this.OnChatMessageAck;
			}
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x00367308 File Offset: 0x00365508
		protected void OnChatMessageAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04007C8F RID: 31887
		private ChatChannel m_channel;

		// Token: 0x04007C90 RID: 31888
		private string m_content;

		// Token: 0x04007C91 RID: 31889
		private string m_translateText;

		// Token: 0x04007C92 RID: 31890
		private byte[] m_voiceBytes;

		// Token: 0x04007C93 RID: 31891
		private int m_length;

		// Token: 0x04007C94 RID: 31892
		private int m_frequency;

		// Token: 0x04007C95 RID: 31893
		private int m_samples;

		// Token: 0x04007C96 RID: 31894
		private string m_userID;
	}
}
