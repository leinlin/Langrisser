using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D2C RID: 3372
	[CustomLuaClass]
	public class GuildHiringDeclarationSetReqNetTask : UINetTask
	{
		// Token: 0x0600F83F RID: 63551 RVA: 0x004180A4 File Offset: 0x004162A4
		public GuildHiringDeclarationSetReqNetTask(string hiringDeclaration) : base(10f, null, true)
		{
			this.HiringDeclaration = hiringDeclaration;
		}

		// Token: 0x0600F840 RID: 63552 RVA: 0x004180BC File Offset: 0x004162BC
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildHiringDeclarationSetAck += this.OnMsgAck;
		}

		// Token: 0x0600F841 RID: 63553 RVA: 0x004180F4 File Offset: 0x004162F4
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildHiringDeclarationSetAck -= this.OnMsgAck;
			}
		}

		// Token: 0x0600F842 RID: 63554 RVA: 0x00418130 File Offset: 0x00416330
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildHiringDeclarationSetReq(this.HiringDeclaration);
		}

		// Token: 0x0600F843 RID: 63555 RVA: 0x00418160 File Offset: 0x00416360
		protected void OnMsgAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600F844 RID: 63556 RVA: 0x00418170 File Offset: 0x00416370
		// (set) Token: 0x0600F845 RID: 63557 RVA: 0x00418178 File Offset: 0x00416378
		public string HiringDeclaration { get; private set; }
	}
}
