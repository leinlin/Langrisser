using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D31 RID: 3377
	[CustomLuaClass]
	public class GuildInfoSetReqNetTask : UINetTask
	{
		// Token: 0x0600F85C RID: 63580 RVA: 0x004184C0 File Offset: 0x004166C0
		public GuildInfoSetReqNetTask(bool autoJoin, int joinLevel, string hiringDeclaration) : base(10f, null, true)
		{
			this.AutoJoin = autoJoin;
			this.JoinLevel = joinLevel;
			this.HiringDeclaration = hiringDeclaration;
		}

		// Token: 0x0600F85D RID: 63581 RVA: 0x004184E4 File Offset: 0x004166E4
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildBasicSetAck += this.OnMsgAck;
		}

		// Token: 0x0600F85E RID: 63582 RVA: 0x0041851C File Offset: 0x0041671C
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildBasicSetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F85F RID: 63583 RVA: 0x00418558 File Offset: 0x00416758
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildBasicSetReq(this.AutoJoin, this.JoinLevel, this.HiringDeclaration);
		}

		// Token: 0x0600F860 RID: 63584 RVA: 0x00418594 File Offset: 0x00416794
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600F861 RID: 63585 RVA: 0x004185A4 File Offset: 0x004167A4
		// (set) Token: 0x0600F862 RID: 63586 RVA: 0x004185AC File Offset: 0x004167AC
		public string HiringDeclaration { get; private set; }

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600F863 RID: 63587 RVA: 0x004185B8 File Offset: 0x004167B8
		// (set) Token: 0x0600F864 RID: 63588 RVA: 0x004185C0 File Offset: 0x004167C0
		public bool AutoJoin { get; private set; }

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600F865 RID: 63589 RVA: 0x004185CC File Offset: 0x004167CC
		// (set) Token: 0x0600F866 RID: 63590 RVA: 0x004185D4 File Offset: 0x004167D4
		public int JoinLevel { get; private set; }
	}
}
