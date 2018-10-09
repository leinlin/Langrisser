using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DE8 RID: 3560
	[CustomLuaClass]
	public class HeroSkillsSelectNetTask : UINetTask
	{
		// Token: 0x0601110A RID: 69898 RVA: 0x0046C54C File Offset: 0x0046A74C
		public HeroSkillsSelectNetTask(int heroId, List<int> skillsId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_skillsId = new List<int>(skillsId);
		}

		// Token: 0x0601110B RID: 69899 RVA: 0x0046C570 File Offset: 0x0046A770
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnHeroSkillsSelectAck += this.OnHeroSkillsSelectAck;
		}

		// Token: 0x0601110C RID: 69900 RVA: 0x0046C5A8 File Offset: 0x0046A7A8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnHeroSkillsSelectAck -= this.OnHeroSkillsSelectAck;
			}
		}

		// Token: 0x0601110D RID: 69901 RVA: 0x0046C5E4 File Offset: 0x0046A7E4
		protected void OnHeroSkillsSelectAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}

		// Token: 0x0601110E RID: 69902 RVA: 0x0046C5F4 File Offset: 0x0046A7F4
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendHeroSkillsSelectReq(this.m_heroId, this.m_skillsId);
		}

		// Token: 0x04009CF8 RID: 40184
		private int m_heroId;

		// Token: 0x04009CF9 RID: 40185
		private List<int> m_skillsId;
	}
}
