using System;
using BlackJack.ConfigData;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020009A9 RID: 2473
	public class FansRewardsFromPBTCBTActivity : AwardOperationalActivityBase
	{
		// Token: 0x06008F0B RID: 36619 RVA: 0x0029AF20 File Offset: 0x00299120
		public FansRewardsFromPBTCBTActivity(ulong instanceID, int activityID, long startDate, long endDate, OperationalActivityType operationalActivityType) : base(instanceID, activityID, operationalActivityType)
		{
			base.InitOperationalActivityTime(new DateTime(startDate), new DateTime(endDate), new DateTime(endDate), new DateTime(endDate));
		}

		// Token: 0x0400651A RID: 25882
		public bool claimed;
	}
}
