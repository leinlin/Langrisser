using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E12 RID: 3602
	[CustomLuaClass]
	public class HeroDungeonLevelAttackNetTask : UINetTask
	{
		// Token: 0x060114E1 RID: 70881 RVA: 0x0047CFF8 File Offset: 0x0047B1F8
		public HeroDungeonLevelAttackNetTask(int levelID) : base(10f, null, true)
		{
			this.m_levelID = levelID;
		}

		// Token: 0x060114E2 RID: 70882 RVA: 0x0047D010 File Offset: 0x0047B210
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroDungeonLevelAttackAck += this.OnHeroDungeonLevelAttackAck;
		}

		// Token: 0x060114E3 RID: 70883 RVA: 0x0047D048 File Offset: 0x0047B248
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroDungeonLevelAttackAck -= this.OnHeroDungeonLevelAttackAck;
			}
		}

		// Token: 0x060114E4 RID: 70884 RVA: 0x0047D084 File Offset: 0x0047B284
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroDungeonLevelAttackReq(this.m_levelID);
		}

		// Token: 0x060114E5 RID: 70885 RVA: 0x0047D0B4 File Offset: 0x0047B2B4
		protected void OnHeroDungeonLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009E93 RID: 40595
		private int m_levelID;
	}
}
