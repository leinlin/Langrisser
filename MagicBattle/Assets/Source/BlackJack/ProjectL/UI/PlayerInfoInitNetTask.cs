using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E34 RID: 3636
	[CustomLuaClass]
	public class PlayerInfoInitNetTask : NetWorkTransactionTask
	{
		// Token: 0x06011973 RID: 72051 RVA: 0x0048CDB0 File Offset: 0x0048AFB0
		public PlayerInfoInitNetTask() : base(100f, null, false)
		{
		}

		// Token: 0x06011974 RID: 72052 RVA: 0x0048CDC0 File Offset: 0x0048AFC0
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnPlayerInfoInitEnd += this.OnPlayerInfoInitEnd;
			projectLPlayerContext.EventOnPlayerInfoInitAck += this.OnPlayerInfoInitAck;
		}

		// Token: 0x06011975 RID: 72053 RVA: 0x0048CE08 File Offset: 0x0048B008
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPlayerInfoInitEnd -= this.OnPlayerInfoInitEnd;
				projectLPlayerContext.EventOnPlayerInfoInitAck -= this.OnPlayerInfoInitAck;
			}
		}

		// Token: 0x06011976 RID: 72054 RVA: 0x0048CE58 File Offset: 0x0048B058
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendPlayerInfoInitReq();
		}

		// Token: 0x06011977 RID: 72055 RVA: 0x0048CE84 File Offset: 0x0048B084
		private void OnPlayerInfoInitAck(object msg)
		{
			PlayerInfoInitAck playerInfoInitAck = msg as PlayerInfoInitAck;
			if (playerInfoInitAck.NeedCreateCharactor)
			{
				this.m_state = PlayerInfoInitNetTask.ResultState.CreateCharacter;
				this.OnTransactionComplete();
			}
		}

		// Token: 0x06011978 RID: 72056 RVA: 0x0048CEB0 File Offset: 0x0048B0B0
		private void OnPlayerInfoInitEnd()
		{
			this.m_state = PlayerInfoInitNetTask.ResultState.InitEnd;
			this.OnTransactionComplete();
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x06011979 RID: 72057 RVA: 0x0048CEC0 File Offset: 0x0048B0C0
		public PlayerInfoInitNetTask.ResultState ReqResultState
		{
			get
			{
				return this.m_state;
			}
		}

		// Token: 0x0400A03B RID: 41019
		protected PlayerInfoInitNetTask.ResultState m_state;

		// Token: 0x02000E35 RID: 3637
		public enum ResultState
		{
			// Token: 0x0400A03D RID: 41021
			None,
			// Token: 0x0400A03E RID: 41022
			CreateCharacter,
			// Token: 0x0400A03F RID: 41023
			InitEnd
		}
	}
}
