using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A82 RID: 2690
	[CustomLuaClass]
	public class DanmakuPostNetTask : UINetTask
	{
		// Token: 0x0600A9F3 RID: 43507 RVA: 0x002F601C File Offset: 0x002F421C
		public DanmakuPostNetTask(int gameFunctionTypeId, int locationId, List<PostDanmakuEntry> entries) : base(10f, null, true)
		{
			this.m_gameFunctionTypeId = gameFunctionTypeId;
			this.m_locationId = locationId;
			this.m_entries = new List<PostDanmakuEntry>(entries);
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x002F6048 File Offset: 0x002F4248
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnSendLevelDanmakuAck += this.OnSendLevelDanmakuAck;
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x002F6080 File Offset: 0x002F4280
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnSendLevelDanmakuAck -= this.OnSendLevelDanmakuAck;
			}
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x002F60BC File Offset: 0x002F42BC
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendLevelDanmakuPostReq(this.m_gameFunctionTypeId, this.m_locationId, this.m_entries);
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x002F60F8 File Offset: 0x002F42F8
		protected void OnSendLevelDanmakuAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006FCE RID: 28622
		private int m_gameFunctionTypeId;

		// Token: 0x04006FCF RID: 28623
		private int m_locationId;

		// Token: 0x04006FD0 RID: 28624
		private List<PostDanmakuEntry> m_entries;
	}
}
