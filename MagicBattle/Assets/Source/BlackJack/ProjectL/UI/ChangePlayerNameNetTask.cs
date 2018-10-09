using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E8F RID: 3727
	[CustomLuaClass]
	public class ChangePlayerNameNetTask : UINetTask
	{
		// Token: 0x060122AE RID: 74414 RVA: 0x004ACDA4 File Offset: 0x004AAFA4
		public ChangePlayerNameNetTask(string playerNewName) : base(10f, null, true)
		{
			this.m_playerNewName = playerNewName;
		}

		// Token: 0x060122AF RID: 74415 RVA: 0x004ACDBC File Offset: 0x004AAFBC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnPlayerNameChangeAck += this.OnPlayerNameChangeAck;
		}

		// Token: 0x060122B0 RID: 74416 RVA: 0x004ACDF4 File Offset: 0x004AAFF4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPlayerNameChangeAck -= this.OnPlayerNameChangeAck;
			}
		}

		// Token: 0x060122B1 RID: 74417 RVA: 0x004ACE30 File Offset: 0x004AB030
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendChangePlayerNameReq(this.m_playerNewName);
		}

		// Token: 0x060122B2 RID: 74418 RVA: 0x004ACE60 File Offset: 0x004AB060
		protected void OnPlayerNameChangeAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400A40A RID: 41994
		private string m_playerNewName;
	}
}
