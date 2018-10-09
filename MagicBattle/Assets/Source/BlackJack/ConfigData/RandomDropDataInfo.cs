using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000341 RID: 833
	[CustomLuaClass]
	public class RandomDropDataInfo
	{
		// Token: 0x0400256A RID: 9578
		public Dictionary<int, RandomDropRewardArea> Areas = new Dictionary<int, RandomDropRewardArea>();
	}
}
