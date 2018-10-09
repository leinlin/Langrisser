using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D3C RID: 3388
	[CustomLuaClass]
	public class GuildMassiveCombatAttackNetTask : UINetTask
	{
		// Token: 0x0600F89F RID: 63647 RVA: 0x00418E10 File Offset: 0x00417010
		public GuildMassiveCombatAttackNetTask(int levelId, List<int> heroIds) : base(10f, null, true)
		{
			this.m_levelId = levelId;
			this.m_heroIds = new List<int>();
			foreach (int num in heroIds)
			{
				if (num != 0)
				{
					this.m_heroIds.Add(num);
				}
			}
		}

		// Token: 0x0600F8A0 RID: 63648 RVA: 0x00418E94 File Offset: 0x00417094
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnGuildMassiveCombatAttackAck += this.OnGuildMassiveCombatAttackAck;
		}

		// Token: 0x0600F8A1 RID: 63649 RVA: 0x00418ECC File Offset: 0x004170CC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnGuildMassiveCombatAttackAck -= this.OnGuildMassiveCombatAttackAck;
			}
		}

		// Token: 0x0600F8A2 RID: 63650 RVA: 0x00418F08 File Offset: 0x00417108
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGuildMassiveCombatAttackReq(this.m_levelId, this.m_heroIds);
		}

		// Token: 0x0600F8A3 RID: 63651 RVA: 0x00418F40 File Offset: 0x00417140
		protected void OnGuildMassiveCombatAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04009244 RID: 37444
		private int m_levelId;

		// Token: 0x04009245 RID: 37445
		private List<int> m_heroIds;
	}
}
