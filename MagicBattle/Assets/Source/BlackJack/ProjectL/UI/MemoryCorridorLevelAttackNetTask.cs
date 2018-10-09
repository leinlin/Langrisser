using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E6F RID: 3695
	[CustomLuaClass]
	public class MemoryCorridorLevelAttackNetTask : UINetTask
	{
		// Token: 0x06011EAD RID: 73389 RVA: 0x004A0D80 File Offset: 0x0049EF80
		public MemoryCorridorLevelAttackNetTask(int levelId) : base(10f, null, true)
		{
			this.m_levelId = levelId;
		}

		// Token: 0x06011EAE RID: 73390 RVA: 0x004A0D98 File Offset: 0x0049EF98
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnMemoryCorridorLevelAttackAck += this.OnMemoryCorridorLevelAttackAck;
		}

		// Token: 0x06011EAF RID: 73391 RVA: 0x004A0DD0 File Offset: 0x0049EFD0
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnMemoryCorridorLevelAttackAck -= this.OnMemoryCorridorLevelAttackAck;
			}
		}

		// Token: 0x06011EB0 RID: 73392 RVA: 0x004A0E0C File Offset: 0x0049F00C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendMemoryCorridorLevelAttackReq(this.m_levelId);
		}

		// Token: 0x06011EB1 RID: 73393 RVA: 0x004A0E3C File Offset: 0x0049F03C
		protected void OnMemoryCorridorLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0400A29F RID: 41631
		private int m_levelId;
	}
}
