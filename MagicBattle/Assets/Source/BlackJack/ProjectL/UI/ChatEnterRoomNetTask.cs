using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B4E RID: 2894
	[CustomLuaClass]
	public class ChatEnterRoomNetTask : UINetTask
	{
		// Token: 0x0600C4CC RID: 50380 RVA: 0x003673F4 File Offset: 0x003655F4
		public ChatEnterRoomNetTask(int roomId) : base(10f, null, true)
		{
			this.m_requireRoomId = roomId;
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x0036740C File Offset: 0x0036560C
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatEnterRoomAck += this.OnChatEnterRoomAck;
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x00367444 File Offset: 0x00365644
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatEnterRoomAck -= this.OnChatEnterRoomAck;
			}
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x00367480 File Offset: 0x00365680
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendWorldEnterNewRoomMessage(this.m_requireRoomId);
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x003674B4 File Offset: 0x003656B4
		private void OnChatEnterRoomAck(int result, int roomId)
		{
			base.Result = result;
			this.m_resultRoomId = roomId;
			this.OnTransactionComplete();
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x0600C4D1 RID: 50385 RVA: 0x003674CC File Offset: 0x003656CC
		public int ResultRoomId
		{
			get
			{
				return this.m_resultRoomId;
			}
		}

		// Token: 0x04007C99 RID: 31897
		private int m_resultRoomId;

		// Token: 0x04007C9A RID: 31898
		private int m_requireRoomId;
	}
}
