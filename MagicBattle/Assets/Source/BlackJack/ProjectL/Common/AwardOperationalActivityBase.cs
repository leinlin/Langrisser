using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200055D RID: 1373
	[CustomLuaClass]
	public class AwardOperationalActivityBase : OperationalActivityBase
	{
		// Token: 0x0600506C RID: 20588 RVA: 0x00180DE0 File Offset: 0x0017EFE0
		public AwardOperationalActivityBase()
		{
			this.GainedRewardIndexs = new List<int>();
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00180DF4 File Offset: 0x0017EFF4
		public AwardOperationalActivityBase(ulong instanceId, int operationalActivityId, OperationalActivityType operationalActivityType) : base(instanceId, operationalActivityId, operationalActivityType)
		{
			this.GainedRewardIndexs = new List<int>();
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00180E0C File Offset: 0x0017F00C
		public virtual int CanGainRewardByIndex(int rewardIndex, DateTime currentTime)
		{
			if (currentTime >= base.GainRewardEndTime)
			{
				return -2211;
			}
			if (rewardIndex < 0 || rewardIndex >= base.Config.OperationalActivityParms.Count)
			{
				return -2202;
			}
			if (this.GainedRewardIndexs.Contains(rewardIndex))
			{
				return -2203;
			}
			return 0;
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00180E6C File Offset: 0x0017F06C
		public void GainReward(int rewardIndex)
		{
			this.GainedRewardIndexs.Add(rewardIndex);
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x00180E7C File Offset: 0x0017F07C
		// (set) Token: 0x06005071 RID: 20593 RVA: 0x00180E84 File Offset: 0x0017F084
		public List<int> GainedRewardIndexs { get; set; }
	}
}
