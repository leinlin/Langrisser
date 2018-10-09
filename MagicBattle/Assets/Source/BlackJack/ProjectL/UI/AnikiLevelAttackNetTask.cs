using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009C8 RID: 2504
	[CustomLuaClass]
	public class AnikiLevelAttackNetTask : UINetTask
	{
		// Token: 0x060091DE RID: 37342 RVA: 0x002A346C File Offset: 0x002A166C
		public AnikiLevelAttackNetTask(int levelId) : base(10f, null, true)
		{
			this.m_levelId = levelId;
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x002A3484 File Offset: 0x002A1684
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnAnikiGymLevelAttackAck += this.OnAnikiLevelAttackAck;
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x002A34BC File Offset: 0x002A16BC
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnAnikiGymLevelAttackAck -= this.OnAnikiLevelAttackAck;
			}
		}

		// Token: 0x060091E1 RID: 37345 RVA: 0x002A34F8 File Offset: 0x002A16F8
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendAnikiGymLevelAttackReq(this.m_levelId);
		}

		// Token: 0x060091E2 RID: 37346 RVA: 0x002A3528 File Offset: 0x002A1728
		protected void OnAnikiLevelAttackAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x04006614 RID: 26132
		private int m_levelId;
	}
}
